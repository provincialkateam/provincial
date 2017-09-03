! --- railroad --- !
! args[1] - from
! args[2] - to
if $args[0] = 'train':
	_from = args[1]
	_to = args[2]
	gs 'zz_train', 'train_station'
	gs 'gadukino_event','clearing_basket'
	act 'Ехать':
		! move to town, 0 -> 4
		if _from < _to: _from += 1
		! move to city, 4 -> 0
		if _from > _to: _from -= 1
		minut += 15
		gs 'stat'
		killvar '$_str'
		if _from = _to:
			cla
			gs 'zz_train', 'train_station'
			gs 'zz_render','','','Вы приехали в пункт назначения.'
			gs 'zz_train', 'train_out'
		else
			gs 'zz_train', 'train', _from, _to
		end
	end
	if _from ! _to: gs 'zz_train', 'train_out'
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
	if $loc = 'vokzal': _from = 0
	if $loc = 'vokzalGin': _from = 4
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
		if money < _money * 50:
			gs 'zz_render', '', '', 'У вас недостаточно денег на билет ' + $_str[i] + ' ('+ _money * 50 +'р.)'
		else
			gs 'zz_render', '', '', '<a href="exec:gs''zz_train'',''train_go'',<<i>> & gs''zz_train'',''train'',<<_from>>,<<i>>">Билет '+$_str[i]+' ('+ _money*50 +'р.)</a>'
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
	cla
	money -= iif(args[1] < _from,_from - args[1],args[1] - _from) * 50
	minut += func('zz_train','time_to_train',args[1])
	gs 'stat'
end
if $args[0] = 'train_out':
	act 'Выйти с электрички':
		killvar '_to'
		minut += rand(1,5)
		if _from = 4:
			killvar '_from' & gt 'vokzalGin'
		elseif _from = 0:
			killvar '_from' & gt 'vokzal'
		else
			nroad = _from*10
			killvar '_from' & gt 'road'
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
	!gs 'zz_funcs','make_table',$result,400
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