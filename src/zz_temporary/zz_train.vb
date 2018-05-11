$loc = $curloc
! --- railroad --- !
! args[1] - from
! args[2] - to
if $args[0] = 'train':
	$metka = $args[0]
	gs 'zz_train', 'train_station'
	gs 'gadukino_event','clearing_basket'
	act 'Ехать':
		! move to town, 0 -> 4
		if _from < _too: _from += 1
		! move to city, 4 -> 0
		if _from > _too: _from -= 1
		minut += 15
		gs 'stat'
		killvar '$_str'
		if _from = _too:
			cla
			gs 'zz_train', 'train_station'
			gs 'zz_render','','','Вы приехали в пункт назначения.'
			gs 'zz_train','train_out'
		else
			gt 'zz_train','train', _from, _too
		end
	end
	if _from ! _too: gs 'zz_train', 'train_out'
end
if $args[0] = 'train_station':
	*clr
	if _from = 4: $_str = 'станции Павлово'
	if _from = 3: $_str = 'платформе "130км"'
	if _from = 2: $_str = 'платформе Гадюкино'
	if _from = 1: $_str = 'платформе Дачная'
	if _from = 0: $_str = 'станции Северный Вокзал'
	gs 'zz_render','','common/transport/railroad/'+func('zz_weather','is_day'),'Электричка остановилась на ' + $_str
end
if $args[0] = 'train_tickets':
	if $loc ! 'road':
		if $control_point = 'gorodok': _from = 4
		if $control_point = 'north': _from = 0
	end
	gs 'zz_train','shedule'
	! проверяем макс время для поезда
	if hour < 5 or (hour = 22 and minut > iif(_from=4 or _from=0,0,iif(_from=2,30,45))) or hour > 22:
		gs 'zz_render','','','Ночью пригородные электрички не ходят.'
		exit
	end
	$_str[0] = 'в Город'
	$_str[1] = 'до платформы Дачная'
	$_str[2] = 'до платформы Гадюкино'
	$_str[3] = 'до платформы "130км"'
	$_str[4] = 'до станции Павлово'
	i = 0
	:loop_tickets
	if i ! _from and i <= 4:
		_money = iif(i < _from,_from - i,i - _from)
		! если время следующей электрички в заданном направлении больше 24 часов - линк не выводим
		if func('zz_train','last_train',i) >= 24*60:
			i += 1
			jump 'loop_tickets'
		end
		! линки на покупку билетов
		if func('zz_funcs','prepayment',2,_money * 50) = 1:
			gs 'zz_render','','','<a href="exec:gs''zz_train'',''train_go'',<<i>> & gt''zz_train'',''train''">Билет '+$_str[i]+' ('+ _money*50 +'р.)</a>'
		else
			gs 'zz_render','','','У вас недостаточно денег на билет ' + $_str[i] + ' ('+ _money * 50 +'р.)'
		end
	end
	i += 1
	if i <= 4: jump 'loop_tickets'
	!--------------------
	killvar '$_str'
	killvar '_money'
end
! обработчик клика по линку
if $args[0] = 'train_go':
	_too = args[1]
	_money=iif(args[1] < _from,_from - args[1],args[1] - _from) * 50
	!Решение костыль, пока некогда делать проверку на невозможное
	!без читов обнуление денег у ГГ, потом как нибудь переделаю.
	gs 'zz_funcs', 'payment', 2, _money, 0
	cla
	minut += func('zz_train','time_to_train',args[1])
	killvar '_money'
	gs 'stat'
end
if $args[0] = 'train_out':
	act 'Выйти с электрички':
		killvar '_too'
		minut += rand(1,5)
		if _from = 4:
			gt 'vokzalGin'
		elseif _from = 0:
			gt 'vokzal'
		else
			gt 'road','main','<<_from>>'
		end
	end
end
! расписание электричек по станции
if $args[0] = 'shedule':
	killvar '$zz_funcs_result'
	$zz_funcs_result[0] = iif(_from!0,'В город','') + ',' + iif(_from!4,'В Павлово','')
	i = 1
	:loop_shedule
	$zz_funcs_result[i] = iif(_from=0,'','<<i*4+2>>:'+iif(_from=4,'00',(4-_from)*15)) + ',' + iif(_from=4,'','<<i*4+2>>:'+iif(_from=0,'00',_from*15))
	i += 1
	if i <= 5: jump 'loop_shedule'
	gs 'zz_funcs','make_table',$zz_funcs_result,0,1
end
! расчет времени до следующей электрички
if $args[0] = 'time_to_train':
	if hour >= 5 and hour <= 22:
		!_from - текущая локация, 0-4
		! args[1] - направление движения
		! поезд может быть в 00, 15, 30, 45 мин
		! время до прибытия поезда
		result = func('zz_train','last_train',args[1]) - (hour*60 + minut)
	else
		! заглушка
		result = 24*60
	end
end
! вычисляем время последнего поезда в заданном направлении
if $args[0] = 'last_train':
	_direct = iif(args[1] < _from,1,0)
	! проверяем, есть ли в этом часу поезд
	if (hour - 2) mod 4 = 0:
		! вычисляем точное время
		_train_time = hour*60 + iif(_direct = 0,_from*15,(4-_from)*15)
		! если текущие минуты больше расчетных - опоздание, добавляем еще 4 часа
		if hour*60 + minut > _train_time: _train_time += 4*60
	else
		! если нет - вычисляем время ближаешего
		_train_time = hour*60 + (4 - (hour - 2) mod 4)*60 + iif(_direct = 0,iif(_from=4,0,_from)*15,(4-_from)*15)
	end
	result = _train_time
	killvar '_train_time'
	killvar '_direct'
end
! --- end railroad --- !