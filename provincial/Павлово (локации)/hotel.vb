! $npc['0,hotelwork'] - флаг работы в отеле:
! 0 - не работала
! 1 - работает
! 2 - попалась на воровстве, не работает
! 3 - повторно устроилась на работу
! 4 - уволена за блядство
! $npc['0,hotelwork_day'] - день рабочей смены
! $npc['0,hotelwork_purse_day'] - день выпадения ивента с кошельком
! $npc['0,hotelwork_peepshow'] - флаг на подглядывания:
! 0 - не открыто
! 1 - встреча с Соней, открываем возможность подглядывания, поиск в подсобке
! 2 - обычное подглядывание в подсобке
! $npc['0,hotel_event_day'] - день выпадения мини-ивента в отеле
! ресепшен
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	gs 'zz_phone','boyfriend_call_init'
	gs 'zz_render','','pavlovo/hotel/hotel.jpg',func('hotel_strings',0)
	act 'Уйти': gt 'vokzalG'
	! гг увольняют за блядство
	if ($npc['0,hotelwork'] = 1 or $npc['0,hotelwork'] = 3) and $npc['0,hotel_sex'] >= 10: gt $curloc,'fired'
	! спрашиваем о работе
	if hour >= 8 and hour < 19 and ($npc['0,hotelwork'] = 0 or $npc['0,hotelwork'] = 2): act 'Спросить о работе': gt $curloc,'ask_about_work'
	! рабочая смена
	if hour = 16 and $npc['0,hotelwork'] = 1 and $npc['0,hotelwork_day'] ! day: act 'Идти работать': gt $curloc,'work_redress'
	! ивент с Катей
	if hour = 17 and minut <= 20 and $npc['14,qwKatya'] = 72 and $npc['14,qwKatya_trio_day'] = daystart and (month <= 3 or month >= 11 or sunWeather < 0): act 'Идти на трио с Катей': gt 'mey_katya_events','hotel_trio_prepeare'
end
! предупреждение и увольнение с работы за блядство
if $args[0] = 'fired':
	if $npc['0,hotel_sex'] = 10:
		gs 'zz_render','','pavlovo/hotel/resepgirl.jpg',func('hotel_strings',77)
		act 'Уйти': gt 'vokzalG'
	else
		gs 'zz_render','','pavlovo/hotel/resepgirl.jpg',func('hotel_strings',78)
		$npc['0,hotelwork'] = 4
		act 'Уйти': gt 'vokzalG'
	end
end
! гг спрашивает о работе
if $args[0] = 'ask_about_work':
	*clr & cla
	if $npc['0,hotel_sex'] >= 10:
		gs 'zz_render','','pavlovo/hotel/resepgirl.jpg',func('hotel_strings',76)
		act 'Уйти': act 'Уйти': gt 'vokzalG'
		exit
	end
	gs 'zz_render','','pavlovo/hotel/resepgirl.jpg',func('hotel_strings',iif($npc['0,hotelwork'] = 0,9,11))
	act 'Согласиться':
		cla
		$npc['0,hotelwork_day'] = day
		$npc['0,hotelwork'] += 1
		gs 'zz_render','','',func('hotel_strings',10)
		act 'Отойти': gt $curloc
	end
	if $npc['0,hotelwork'] = 0: act 'Я подумаю': gt $curloc
end
if $args[0] = 'work_redress':
	*clr & cla
	minut += rand(5,10)
	$npc['0,hotelwork_day'] = day
	gs 'stat'
	gs 'zz_render','','pavlovo/hotel/work/redress'+rand(0,1),func('hotel_strings',1)
	act 'Работать':
		! заполняем массив
		! 0 - почти чисто					10
		! 1 - менять белье					20
		! 2 - загажено, вариант 1			30
		! 3 - загажено, вариант 2			40
		! 4 - номер заперт, не тревожить	60-100
		_var[0] = 0
		_var[1] = 1
		_var[2] = 2
		_var[3] = 3
		_var[4] = 4
		! генерируем события в номерах, не повторяемся
		i = 0
		:loop_events
		j = rand(0,arrsize('_var')-1)
		_work[i] = _var[j]
		killvar '_var',j
		i += 1
		if i < 5: jump 'loop_events'
		killvar 'j'
		gt $curloc,'work'
	end
end
if $args[0] = 'work':
	*clr & cla
	gs 'zz_render','','pavlovo/hotel/corridor.jpg'
	_current_room = args[1]
	! в коридоре раз в день можем получить случайный ивент
	if _current_room = 0 and $npc['0,hotel_event_day'] ! day and rand(0,10) < 3: gt $curloc,'mini_events'
	! если все номера убраны - открываем выход
	if func($curloc,'clean_count') = 5:
		act 'Закончить смену':
			! чистим временные переменные
			killvar '_current_room'
			killvar '_work'
			killvar '_work_time'
			! приращиваем статы
			if maidstat < 100: maidstat += 1
			manna -= 20 - maidstat/10
			sweat += 2
			money += 300
			gs 'stat'
			gt $curloc
		end
		exit
	end
 ! ИВЕНТ С РАБОЧИМ В ПОДСОБКЕ
	if _current_room = 0 and $npc['0,hotel_events_worker_day'] ! day and $npc['0,hotel_events_stage'] >= 5 and rand(1,3) = 1:
		$npc['0,hotel_events_worker_day'] = day
		if $npc['0,hotel_events_worker_flag'] = 0:
			gt $curloc, 'maid_event_worker_1', 0
			!Только в среду если возбуждение > 50 можно зайти в подсобку
		elseif week = 3 and horny > 50 and $npc['0,hotel_events_worker_flag'] = 1:
			act 'Зайти к Ренату в подсобку': gt $curloc, 'maid_event_worker_2', 0
		end
	end
	! ИВЕНТ С НЕФТЯНИКАМИ В КОРИДОРЕ
	if _current_room = 0 and $npc['0,hotel_events_oilers_day'] ! day and $npc['0,hotel_events_oilers_stage'] > 0 and $npc['0,hotel_events_stage'] >= 5 and rand(1,3) = 1:
		$npc['0,hotel_events_oilers_day'] = day
		gt $curloc, 'maid_event_4', 0
	end
	! уборка
	! current_room - текущий номер, 1 - 5
	if _current_room > 0:
		*clr & cla
		! если номер заперт - приходим позже
		if _work[_current_room-1] = 4:
			! проверяем время последнего визита к номеру
			! сегодня еще не были ИЛИ еще не пришло установленное время ожидания
			if _work_time = 0 or _work_time > hour * 60 + minut:
				gs 'zz_render','','pavlovo/hotel/corridor.jpg',func('hotel_strings',7)
				! если сегодня еще не были - устанавливаем время ожидания
				if _work_time = 0: _work_time = hour * 60 + minut + rand(60,100)
				! если все номера уже убраны
				if func($curloc,'clean_count') = 0:
					act 'Подождать и убрать':
					 minut += _work_time - (hour * 60 + minut)
						gt $curloc,'work',_current_room
					end
				else
					act 'Отойти': gt $curloc,'work'
				end
				if $npc['0,hotelwork_peepshow'] > 0: act 'Идти в подсобку': gt $curloc,'peepshow'
			else
				! встреча с Соней, открывает подглядывания в отеле
				if hour >= 19 and $npc['25,qwSonya'] >= 5 and $npc['25,qwSonya'] < 50 and _current_room = 4 and $npc['0,hotelwork_peepshow'] = 0:
					$npc['0,hotelwork_peepshow'] = 1
					gs 'zz_render','','пикча с соней в коридоре',func('hotel_strings',38)
					act 'Убираться в номере': gt $curloc,'work',_current_room
					exit
				end
				! время ожидания уже прошло, можно убирать номер
				gs 'zz_render','','pavlovo/hotel/work/work'+rand(1,3)+'.jpg',func('hotel_strings',6)
				! ---
				minut += 40
				_work[_current_room-1] = -1
				if maidstat > 20 and rand(0,10) < 3:
					money += (maidstat/10) * 10
					gs 'zz_render','','',func('hotel_strings',8)
				end
				gs 'stat'
				act 'Выйти из номера': gt $curloc,'work'
			end
		else
			gs 'zz_render','','pavlovo/hotel/work/work' + _work[_current_room-1],func('hotel_strings',_work[_current_room-1]+2)
			act 'Выйти из номера': gt $curloc,'work'
			minut += (_work[_current_room-1] + 1) * 10
			_work[_current_room-1] = -1
			gs 'stat'
			!ВСЕ ИВЕНТЫ С РАНДОМОМ 1 К 3
			!$npc['0,hotel_events_worker_day'] - день ивента с рабочим, нужен чтобы был раз в день
			!$npc['0,hotel_events_oilers_day'] - день ивента с нефтяниками в коридоре, нужен чтобы был раз в день
			!флаги сюжета
			!$npc['0,hotel_events_stage'] - уровень развития ивентов в отеле, изначально ноль
			!$npc['0,hotel_events_stage'] += 1 - плюс одно очко, дается за участие в ивентах event, event_1, event_2
			!$npc['0,hotel_events_stage'] >= 5 - когда уровень развития становится больше или равен 5 открываются первый ивент с нефтяниками maid_event3 в субботу в номере люкс
			!после встречи с ними срабатывает флаг $npc['0,hotel_events_oilers_stage'] = 1
			!$npc['0,hotel_events_oilers_stage'] > 0 - значит что гг уже встречалась с нефтяниками
			!$npc['0,hotel_events_worker_flag'] = 0 - флаг ивента с рабочим в подсобке maid_event_worker_1. После первого минета с ним $npc['0,hotel_events_worker_flag'] = 1
			!$npc['0,hotel_events_oilers_gift'] = 1 - наличие подарка от нефтяников, если есть то включается maid_event_6 в котором $npc['0,hotel_events_oilers_stage'] = 2
			!после $npc['0,hotel_events_oilers_stage'] > 1 включается maid_event_7(алена с ноутбуком)
			!В общем для прохождения нужно запустить первые 3 ивента больше 5 раз, после чего станет доступен рабочий
			!а в субботу в люксе доступны нефтяники, после чего в выходные доступен ивент с получением ожерелья от нефтяников
			!если ожерелье получено то доступен шестой ивент.
			!после шестого ивента на выходных доступен ивент с Алёной и ешестым ивентом c вероятностью 50/50 соответсвенно
			if day < 14 and _current_room < 4 and rand(1,3) = 1 and shameless['flag'] >= 2: gt $curloc,'maid_event', 0
			if _current_room < 4 and rand(1,3) = 1 and shameless['flag'] >= 2: gt $curloc,'maid_event_1', 0
			if week = 7 and _current_room = 4 and rand(1,3) = 1 and shameless['flag'] >= 2: gt $curloc,'maid_event_2', 0
			if week = 6 and _current_room = 5 and $npc['0,hotel_events_stage'] >= 5 and $npc['0,hotel_events_oilers_stage'] = 0 and rand(1,3) = 1:
				$npc['0,hotel_events_oilers_stage'] = 1
				gt $curloc,'maid_event3'
			end
			if week > 5 and $npc['0,hotel_events_oilers_stage'] = 1 and _current_room = 5 and rand(1,3) = 1 and $npc['0,hotel_events_oilers_gift'] = 0: gt $curloc,'maid_event_5', 0
			if week > 5 and $npc['0,hotel_events_oilers_gift'] = 1 and _current_room = 5 and rand(1,3) = 1: gt $curloc,'maid_event_6', 0
			if week > 5 and $npc['0,hotel_events_oilers_stage'] > 1 and _current_room = 5 and rand(1,3) = 1:
			if rand(1,2) = 1:
				gt $curloc,'maid_event_7', 0
			else
				gt $curloc,'maid_event_6', 0
			end
		end
			if $npc['0,hotelwork_purse_day'] ! day and rand(0,20) = 1: gs $curloc,'purse_event'
		end
	else
		! заполняем неубранные номера
		if _work[0] >= 0: act '№1 "Обычный"': gt $curloc,'work',1
		if _work[1] >= 0: act '№2 "Обычный"': gt $curloc,'work',2
		if _work[2] >= 0: act '№3 "Обычный"': gt $curloc,'work',3
		if _work[3] >= 0: act '№4 "Семейный"': gt $curloc,'work',4
		if _work[4] >= 0: act '№5 "Люкс"': gt $curloc,'work',5
	end
end
! получаем количество убраных номеров
! для убраного номера стоит флаг -1, поэтому умножаем на -1
if $args[0] = 'clean_count':
	result = -1 * (_work[0] + _work[1] + _work[2] + _work[3] + _work[4])
end
! ивент с кошельком
if $args[0] = 'purse_event':
	*clr & cla
	$npc['0,hotelwork_purse_day'] = day
	gs 'zz_render','','pavlovo/hotel/work/purse.jpg',func('hotel_strings',12)
	act 'Отнести администратору':
		cla
		gs 'zz_render','','',func('hotel_strings',13)
		act 'Дальше': gt $curloc,'work'
	end
	! своровать можно только при первом трудоустройстве
	if $npc['0,hotelwork'] = 1:
		act 'Оставить себе':
			cla
			gs 'zz_render','','',func('hotel_strings',14)
			act 'Дальше':
				cla
				gs 'zz_render','','',func('hotel_strings',15)
				act 'Отдать кошелёк':
					*clr & cla
					gs 'zz_render','','pavlovo/hotel/work/purse_event2.jpg',func('hotel_strings',16)
					act 'Идти работать': gt $curloc,'work'
				end
				act 'Пожать плечами':
					cla
					gs 'zz_render','','',func('hotel_strings',17)
					if rand(0,10) < 2:
						*clr & cla
						gs 'zz_render','','pavlovo/hotel/work/purse_event2.jpg',func('hotel_strings',19)
						act 'Ждать полицию': gt $curloc,'police_event'
					else
						cla
						money += rand(5,20)*100
						manna += rand(1,10)
						gs 'stat'
						gs 'zz_render','','',func('hotel_strings',18)
						act 'Идти работать': gt $curloc,'work'
					end
				end
			end
		end
	end
end
if $args[0] = 'police_event':
	*clr & cla
	minut += rand(25,35)
	gs 'stat'
	gs 'zz_render','','pavlovo/police/katalkin.jpg',func('hotel_strings',20) + func('hotel_strings',iif($npc['41,know'] = 1,21,22))
	act 'Дальше':
		*clr & cla
		minut += rand(25,35)
		manna = manna/2
		gs 'stat'
		gs 'zz_render','','pavlovo/police/interrogation.jpg',func('hotel_strings',23) + func('hotel_strings',iif($npc['41,sex'] > 0,24,25))
		if $npc['41,sex'] > 0 and vagina > 0: act 'Дать капитану': gt $curloc,'police_sex'
		act 'Не дать капитану':
			*clr & cla
			gs 'zz_render','','pavlovo/police/interrogation.jpg',func('hotel_strings',27)
			act 'Согласиться':
				*clr & cla
				gs 'zz_render','','pavlovo/police/interrogation.jpg',func('hotel_strings',28) + func('hotel_strings',30)
				gs $curloc,'police_agreement'
			end
			act 'Отказаться':
				*clr & cla
				gs 'zz_render','','pavlovo/police/interrogation.jpg',func('hotel_strings',29) + func('hotel_strings',30)
				act 'Идти с капитаном':
					*clr & cla
					minut += rand(10,20)
					gs 'stat'
					gs 'zz_render','','pavlovo/hotel/resepgirl2.jpg',func('hotel_strings',32)
					act 'Идти домой': minut += rand(10,20) & gt 'hotel','purse_punish'
				end
			end
		end
	end
end
! если гг согласилась стучать или дала Каталкину
if $args[0] = 'police_agreement':
	act 'Идти с капитаном':
		*clr & cla
		minut += rand(10,20)
		gs 'stat'
		gs 'zz_render','','pavlovo/hotel/resepgirl2.jpg',func('hotel_strings',31)
		act 'Идти домой': minut += rand(10,20) & gt 'gorodok'
	end
end
! --
! наказание после кражи кошелька в отеле
if $args[0] = 'purse_punish':
	*clr & cla
	gs 'zz_render','','pavlovo/family/mother/prost5.jpg',func('hotel_strings',33)
	act 'Идти в зал':
		*clr & cla
		gs 'zz_render','','pavlovo/hotel/punish/0.jpg',func('hotel_strings',34)
		act 'Терпеть':
			*clr & cla
			minut += rand(2,5)
			spank += 1
			spanked += 35
			if $npc['37,relation'] > 30: $npc['37,relation'] = 30
			if $npc['35,relation'] > 40: $npc['35,relation'] = 40
			gs 'stat'
			gs 'zz_render','','pavlovo/hotel/punish/1.jpg',func('hotel_strings',35)
			act 'Терпеть':
				*clr & cla
				minut += rand(2,5)
				spanked += 35
				gs 'stat'
				gs 'zz_render','','pavlovo/hotel/punish/2.jpg',func('hotel_strings',36)
				act 'Плакать, стоя в углу':
					*clr & cla
					minut += rand(5,10)
					gs 'stat'
					gs 'zz_render','','pavlovo/hotel/punish/3.jpg',func('hotel_strings',37)
					act 'Уйти': gt 'korrPar'
				end
			end
		end
	end
end
! подглядывание
if $args[0] = 'peepshow':
	*clr & cla
	horny += rand(10,20)
	minut += rand(5,10)
	gs 'stat'
	! первое подглядывание в отеле
	if $npc['0,hotelwork_peepshow'] = 1:
		$npc['0,hotelwork_peepshow'] = 2
		i = 0
	else
		i = rand(1,6)
	end
	if i <= 5:
		! Соня больше не работает шлюхой
		if $npc['25,qwSonya'] >= 50 and i >= 4:
			gt $curloc,'mini_steps_events',1
		else
			if $npc['25,qwSonya'] < 15: $npc['25,qwSonya'] += 1
			$npc['25,qwSonya_day'] = day
		end
		! --
		gs 'zz_render','','pavlovo/hotel/peepshow/'+ i + iif(i<5,'.jpg','.webm'),func('hotel_strings',39+i)
		act 'Идти работать': gt $curloc,'work'
	else
		gt $curloc,'mini_steps_events',rand(1,2)
	end
end
! мини-ивенты в отеле
if $args[0] = 'mini_events':
	*clr & cla
	$npc['0,hotel_event_day'] = day
	i = rand(0,iif($npc['0,hotelwork_peepshow']<2,8,10))
	if i < 10:
		! если соня больше не работает шлюхой - исключаем
		if i = 9:
			if $npc['25,qwSonya'] >= 50:
				i = rand(0,8)
			else
				if $npc['25,qwSonya'] < 15: $npc['25,qwSonya'] += 1
				$npc['25,qwSonya_day'] = day
			end
		end
		!--
		minut += rand(2,5)
		gs 'zz_render','','pavlovo/hotel/mini/' + i,func('hotel_strings',45 + i)
		act 'Работать': gt $curloc,'work'
	else
		gt $curloc,'mini_steps_events',0
	end
end
! многотактные миники
if $args[0] = 'mini_steps_events':
	*clr & cla
	_mini = args[1]
	_stage = args[2]
	! макс количество шагов ивента
	_max_stage[0] = 5
	_max_stage[1] = 2
	_max_stage[2] = 5
	! мин значение строки текста
	_min_stage[0] = 55
	_min_stage[1] = 61
	_min_stage[2] = 64
	! --
	minut += rand(2,5)
	horny += rand(5,10)
	gs 'stat'
	! --
	gs 'zz_render','','pavlovo/hotel/mini/' + _mini + '/' + _stage,func('hotel_strings',(_min_stage[_mini] + _stage))
	act iif(_stage < _max_stage[_mini],'Дальше','Идти работать'):
		if _stage < _max_stage[_mini]:
			gt $curloc, 'mini_steps_events',_mini,_stage+1
		else
			! если Соня рабоатет шлюхой - приращиваем счетчик
			if _mini = 2:
				if $npc['25,qwSonya'] < 15: $npc['25,qwSonya'] += 1
				$npc['25,qwSonya_day'] = day
			end
			!--
			killvar '_min_stage'
			killvar '_max_stage'
			killvar '_mini'
			killvar '_stage'
			gt $curloc,'work'
		end
	end
end
! секс с Каталкиным
if $args[0] = 'police_sex':
	*clr & cla
	_stage = args[1]
	if _stage < 4:
		gs 'zz_render','','pavlovo/police/sex/'+_stage,func('hotel_strings',70 + _stage)
		act 'Дальше': gt $curloc,'police_sex',_stage+1
	else
		bj += 1
		sex += 1
		minut += rand(5,15)
		horny += rand(20,30)
		gs 'stat'
		gs 'zz_render','','pavlovo/police/katalkin.jpg',func('hotel_strings',75) + func('hotel_strings',30)
		killvar '_stage'
		gs $curloc,'police_agreement'
	end
end
!------
if $args[0] = 'maid_event':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	if _stage < 3:
		gs 'zz_render','','pavlovo/hotel/event/M0_'+ _stage + iif(_stage=0,'.jpg','.webm'), func('hotel_strings', 111 + _stage)
		act 'Далее': gt $curloc,'maid_event',_stage+1
	elseif _stage = 3:
		gs 'zz_render','','pavlovo/hotel/event/M0_'+ _stage+ '.webm', func('hotel_strings', 111 + _stage)
		horny += 5
		act 'Возмутиться и уйти.':
			gs 'zz_render', '', '', '\\Мужчина, здесь вам не бордель!// - резко осаживаете вы “ухажёра”.'
			cla
			killvar '_stage'
			act 'Уйти': gt $curloc, 'work'
		end
		act 'Смутиться и убежать':
			killvar '_stage'
			gt $curloc, 'work'
		end
		if sex > 0 and vagina >= 8 and anus >= 8 and shameless['flag'] >= 2:
			act 'Поддаться и согласиться на предложение': gt $curloc, 'maid_event', _stage+1
			act 'Намекнуть на оплату':
				hotel_maid_event_ask_pay = 1
				gt $curloc, 'maid_event', _stage+1
			end
		end
	elseif _stage >= 4 and _stage < 10:
		if horny < 70:
			horny += 10
			gs 'zz_render','','pavlovo/hotel/event/M0_'+ _stage+ '.webm', func('hotel_strings', 111 + _stage)
			act 'Далее': gt $curloc,'maid_event',_stage+1
		else
			gs 'zz_render','','pavlovo/hotel/event/M0_'+ _stage+ '.webm', func('hotel_strings', 111 + _stage)
			_stage += 7
			act 'Далее': gt $curloc,'maid_event',_stage+1
		end
	elseif _stage = 10:
		swallow += 1
		if hotel_maid_event_ask_pay = 1:
			money += 1500
			gs 'zz_render','','', func('hotel_strings', 122)
		else
			money += 1000
			gs 'zz_render','','', func('hotel_strings', 121)
		end
		killvar 'hotel_maid_event_ask_pay'
		act 'Уйти':
			killvar '_stage'
			gt $curloc, 'work'
		end
	elseif _stage >= 12 and _stage < 21:
		horny += 20
		gs 'zz_render','','pavlovo/hotel/event/M0_'+ _stage+ '.webm', func('hotel_strings', 111 + _stage)
		act 'Далее': gt $curloc,'maid_event',_stage+1
	elseif _stage = 21:
		anal += 1
		money += 1500
		$npc['0,hotel_events_stage'] += 1
		gs 'zz_render','','pavlovo/hotel/event/M0_'+ 9 + '.webm', func('hotel_strings', 132)
		act 'Уйти':
		killvar '_stage'
		gt $curloc, 'work'
		end
	end
end
!------
if $args[0] = 'maid_event_1':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	if _stage < 4:
		horny += 5
		gs 'zz_render','','pavlovo/hotel/event1/M1_'+ _stage + '.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_1',_stage+1
	elseif _stage = 4:
		gs 'zz_render', '', 'pavlovo/hotel/event1/M1_'+ _stage + '.webm', func('hotel_events_data', $args[0], _stage)
		act 'Отказаться и уйти':
			killvar '_stage'
			gt $curloc, 'work'
		end
		act 'Согласиться и приступить.': gt $curloc, 'maid_event_1', _stage+1
		act 'Сказать, что маловато будет':
			cla
			hotel_maid_event_ask_pay = 1
			gs 'zz_render', '', '', '-\\ Мне кажется вы меня недооценили//<br>\\\- Ладно, дам побольше!///<br>Вы удовлетворённо киваете.'
			act 'Далее': gt $curloc, 'maid_event_1', _stage+1
		end
	elseif _stage > 4 and _stage < 9:
		gs 'zz_render', '', 'pavlovo/hotel/event1/M1_'+ _stage + '.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_1',_stage+1
	elseif _stage = 9:
		horny += 25
		bj += 1
		swallow += 1
		if hotel_maid_event_ask_pay = 1:
			killvar 'hotel_maid_event_ask_pay'
			money += 400
			gs 'zz_render', '', 'pavlovo/hotel/event1/M1_4.webm', func('hotel_events_data', $args[0], _stage+1)
		else
			money += 300
			gs 'zz_render', '', 'pavlovo/hotel/event1/M1_4.webm', func('hotel_events_data', $args[0], _stage)
		end
		if hotel_maid_event_forgot_pay = 1:
			gs 'zz_render', '', '', func('hotel_events_data', $args[0], _stage+1)
			killvar 'hotel_maid_event_forgot_pay'
		end
		$npc['0,hotel_events_stage'] += 1
		killvar '_stage'
		act 'Уйти': gt $curloc, 'work'
		act 'Попросить после минета отлизать вам киску.': gt $curloc, 'maid_event_1_anal', 0
	end
end
!---
if $args[0] = 'maid_event_1_anal':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	if _stage = 0:
		gs 'zz_render','','pavlovo/hotel/event1/M1_A_'+ _stage + '.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее':
			cla
			if horny > 85:
				orgasm += 1
				gs 'zz_render','','', func('hotel_events_data', $args[0], 1)
				hotel_maid_event_forgot_pay = 1
				killvar '_stage'
				act 'Уйти': gt $curloc, 'work'
			else
				gs 'zz_render','','', func('hotel_events_data', $args[0], 2)
				act 'Возмутиться и потребовать прекратить':
					*clr & cla
					money += 300
					gs 'zz_render','','pavlovo/hotel/event1/M1_4.webm', func('hotel_events_data', $args[0], 3)
					killvar '_stage'
					act 'Уйти': gt $curloc, 'work'
				end
				act 'Позволить ему и наслаждаться процессом.':
					gt $curloc,'maid_event_1_anal',_stage+4
				end
			end
		end
	elseif _stage > 3 and _stage < 16:
		horny += 15
		gs 'zz_render','','pavlovo/hotel/event1/M1_A_'+ _stage + '.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_1_anal',_stage+1
	elseif _stage = 16:
		money += 600
		horny = 0
		anal += 1
		orgasm += 1
		gs 'zz_render','','pavlovo/hotel/event1/M1_A_'+ _stage + '.webm', func('hotel_events_data', $args[0], _stage)
		killvar '_stage'
		act 'Уйти': gt $curloc, 'work'
	end
end
!------
! maid_event_2
if $args[0] = 'maid_event_2':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	if _stage = 0:
		gs 'zz_render','','', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_2', _stage+1
	elseif _stage = 1:
		gs 'zz_render','','pavlovo/hotel/event2/M2_'+ _stage+'.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_2', _stage+1
	elseif _stage = 2:
		gs 'zz_render','','pavlovo/hotel/event2/M2_'+ _stage+'.webm', func('hotel_events_data', $args[0], _stage)
		act 'Смущенно убежать':
			killvar '_stage'
			gt $curloc, 'work'
		end
		act 'Не обращать внимания, доделать работу и уйти':
			cla
			gs 'zz_render','','', 'Вы доделываете работу и уходите'
			killvar '_stage'
			act 'Уйти': gt $curloc, 'work'
		end
		act 'Заглянуть в спальню': gt $curloc, 'maid_event_2', _stage+1
	elseif _stage > 2 and _stage < 8:
		gs 'zz_render','','pavlovo/hotel/event2/M2_'+ _stage+'.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_2', _stage+1
	elseif _stage = 8:
		gs 'zz_render','','pavlovo/hotel/event2/M2_'+ _stage+'.webm', func('hotel_events_data', $args[0], _stage)
		act 'Отказаться':
			cla
			gs 'zz_render','','', 'Вы бормочете: -\\Нет, я не могу...я...мне надо...простите, я пойду!//'
			killvar '_stage'
			act 'Уйти': gt $curloc, 'work'
		end
		act 'Принять участие.': gt $curloc, 'maid_event_2', _stage+1
	elseif _stage > 8 and _stage < 21:
		horny += 10
		gs 'zz_render','','pavlovo/hotel/event2/M2_'+ _stage+'.webm', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_2', _stage+1
	elseif _stage = 21:
		orgasm += 1
		horny = 0
		money += 3000
		swallow += 1
		$npc['0,hotel_events_stage'] += 1
		gs 'zz_render','','pavlovo/hotel/event2/M2_'+ _stage+'.webm', func('hotel_events_data', $args[0], _stage)
		killvar '_stage'
		gs 'stat'
		act 'Уйти': gt $curloc, 'work'
	end
end
! maid_event3
if $args[0] = 'maid_event3':
	*clr & cla
	_stage = args[1]
	if _stage = 5:
		horny += 10
		gs 'stat'
	end
	$_m_img = func('zz_funcs','get_item_string','M3-01,M3-02,M3-04,M3-05,M3-08,M3-09,M3-09',_stage)
	gs 'zz_render','','pavlovo/hotel/event3/' + $_m_img + '.webm',func('hotel_strings',79+_stage)
	act iif(_stage ! 5,'Далее','Вырваться и убежать'):
		if _stage < 5:
			gt $curloc,'maid_event3',_stage+1
		elseif _stage = 5:
			if dom >= 10 and stren >= 40 and agil >= 30:
				gt $curloc,'maid_event3',_stage+1
			else
				cla
				killvar '_stage'
				killvar '$_m_img'
				act func('hotel_strings',87): gt $curloc,'maid_event3_bj',1
				act func('hotel_strings',88): gt $curloc,'maid_event3_bj',2
				if vagina >= 15 and anus >= 15:
					act func('hotel_strings',89): gt $curloc,'maid_event3_sex',1
					act func('hotel_strings',90): gt $curloc,'maid_event3_sex',2
				end
			end
		else
			killvar '_stage'
			killvar '$_m_img'
			gt $curloc,'work'
		end
	end
end
!---
if $args[0] = 'maid_event3_bj':
	_bj_var = args[1]
	_stage = args[2]
	minut += rand(2,5)
	horny += rand(5,10)
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','M3-11,M3-15,M3-12,M3-41',_stage)
	gs 'zz_render','','pavlovo/hotel/event3/' + $_m_img + '.webm',func('hotel_strings',91+_stage) + iif(_stage = 3,func('hotel_strings',iif(_bj_var=1,95,96)),'')
	act iif(_stage < 3,'Далее','Уйти'):
		if _stage < 3:
			gt $curloc,'maid_event3_bj',_bj_var,_stage+1
		else
			if _bj_var = 1:
				money += 100
				dom += 1
			else
				dom -= 1
			end
			bj += 2
			gs 'zz_funcs','cum','lip'
			gs 'stat'
			killvar '_bj_var'
			killvar '_stage'
			killvar '$_m_img'
			gt $curloc,'work'
		end
	end
end
!---
if $args[0] = 'maid_event3_sex':
	_sex_var = args[1]
	_stage = args[2]
	minut += rand(2,5)
	if _stage < 10:
		horny += rand(7,15)
	elseif _stage = 10:
		horny = 0
	end
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','M3-16,M3-21,M3-24,M3-21,M3-28,M3-31,M3-33,M3-29,M3-36,M3-40,M3-37,M3-41,M3-42',_stage)
	gs 'zz_render','','pavlovo/hotel/event3/' + $_m_img + '.webm',func('hotel_strings',97+_stage) + iif(_stage = 12,func('hotel_strings',iif(_sex_var=1,109,110)),'')
	act iif(_stage < 12,'Далее','Уйти'):
		if _stage < 12:
			gt $curloc,'maid_event3_sex',_sex_var,_stage+1
		else
			if _sex_var = 1:
				money += 2500
				dom += 1
			else
				dom -= 3
			end
			gs 'zz_funcs', 'cum', 'lip'
			orgasm += 1
			DPorgasm += 1
			if agape < 1: agape = 1
			agapetime = totminut + (agape + 1) * 1440
			gs 'stat'
			killvar '_sex_var'
			killvar '_stage'
			killvar '$_m_img'
			gt $curloc,'work'
		end
	end
end
!------
! maid_event_4
if $args[0] = 'maid_event_4':
	*clr & cla
	_stage = args[1]
	if _stage < 2:
		gs 'zz_render','','pavlovo/hotel/event4/M4_'+ _stage + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_4', _stage+1
	elseif _stage = 2:
		gt $curloc, 'maid_event_4_opt<<rand(1,2)>>', 0
	end
end
!---
if $args[0] = 'maid_event_4_opt1':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','1_0,1_1,,,1_2,1_3,1_4,1_5,1_6,1_7,1_8,2_2,1_9,1_10,1_11',_stage)
	if _stage < 1:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_4_opt1',_stage+1
	elseif _stage = 1:
		horny += 10
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Обслужить':
			gs 'zz_render','','', func('hotel_events_data', $args[0], 2)
			cla
			act 'Далее': gt $curloc,'maid_event_4_opt1',_stage+3
		end
		act 'Потребовать деньги':
			cla
			maid_event_4_ask_pay = 1
			gs 'zz_render','','', func('hotel_events_data', $args[0], 3)
			act 'Далее': gt $curloc,'maid_event_4_opt1',_stage+3
		end
	elseif _stage > 3 and _stage < 8:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_4_opt1',_stage+1
	elseif _stage = 8:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Отлизать':
			dom -= 2
			gt $curloc,'maid_event_4_opt1',_stage+1
		end
		act 'Отказать': gt $curloc,'maid_event_4_opt1',_stage+3
	elseif _stage > 8 and _stage < 14:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_4_opt1',_stage+1
	elseif _stage = 14:
		horny += 25
		swallow += 1
		if maid_event_4_ask_pay = 0:
			gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		else
			killvar 'maid_event_4_ask_pay'
			money += 400
			gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage+1)
		end
		killvar '_stage'
		killvar '$_m_img'
		act 'Уйти': gt $curloc, 'work'
	end
end
!---
if $args[0] = 'maid_event_4_opt2':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','2_0,1_0,1_2,1_3,1_4,2_1,2_2,1_9,1_10,1_11,2_3',_stage)
	if _stage < 1:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_4_opt2',_stage+1
	elseif _stage = 1:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Отсосать': gt $curloc,'maid_event_4_opt2',_stage+1
		act 'Отказать':
			cla
			gs 'zz_render','','', '-\\ Извините, я пойду, мне работать надо!//'
			killvar '_stage'
			killvar '$_m_img'
			act 'Уйти': gt $curloc, 'work'
		end
		act 'Потребовать деньги':
			cla
			maid_event_4_ask_pay = 1
			gs 'zz_render','','', '-\\ Три сотни, Сергей Александрович, раз уж вы торопитесь!//<br>Вы задорно подмигнули развратному постояльцу.'
			act 'Далее': gt $curloc,'maid_event_4_opt2',_stage+1
		end
	elseif _stage > 1 and _stage < 10:
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_4_opt2',_stage+1
	elseif _stage = 10:
		horny += 25
		swallow += 1
		gs 'zz_render','','pavlovo/hotel/event4/M4_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		if maid_event_4_ask_pay = 1:
			gs 'zz_render','','', func('hotel_events_data', $args[0], _stage+1)
			killvar 'maid_event_4_ask_pay'
			money += 400
		end
		killvar '_stage'
		killvar '$_m_img'
		act 'Уйти': gt $curloc, 'work'
	end
end
!------
! maid_event_5
if $args[0] = 'maid_event_5':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','0.webm,1,2.webm,3.webm,4.webm,5.webm,6.webm,7.webm,8.webm,9.webm,10.webm,11.webm,12.webm,13.webm,,15',_stage)
	if _stage < 1:
		horny += 10
		gs 'zz_render','','pavlovo/hotel/event5/M5_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_5', _stage+1
	elseif _stage = 1:
		gs 'zz_render','','pavlovo/hotel/event5/M5_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		if dom > 40 or horny < 40:
			act 'Вежливо отказать и уйти.':
				cla
				gs 'zz_render','','', '-\\ Простите, я сегодня не в настроении...//'
				killvar '_stage'
				killvar '$_m_img'
				act 'Уйти': gt $curloc, 'work'
			end
			act 'Согласиться и удовлетворить постояльцев.': gt $curloc, 'maid_event_5', _stage+1
		else
			act 'Отдаться':
				dom -= 1
				$npc['0,hotel_events_oilers_gift'] = 1
				gt $curloc, 'maid_event_5', _stage+1
			end
		end
	elseif _stage > 1 and _stage < 13:
		horny += rand(5,10)
		gs 'zz_render','','pavlovo/hotel/event5/M5_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_5', _stage+1
	elseif _stage = 13:
		orgasm += 1
		DPorgasm += 1
		horny = 0
		gs 'zz_render','','pavlovo/hotel/event5/M5_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		if $npc['0,hotel_events_oilers_gift'] = 1:
			gs 'zz_render','','', func('hotel_events_data', $args[0], _stage+1)
			act 'Далее': gt $curloc, 'maid_event_5', _stage+2
		else
			killvar '_stage'
			killvar '$_m_img'
			act 'Уйти': gt $curloc, 'work'
		end
	elseif _stage = 15:
		gs 'zz_render','','pavlovo/hotel/event5/M5_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		killvar '_stage'
		killvar '$_m_img'
		act 'Уйти': gt $curloc, 'work'
	end
end
!------
! maid_event_6
if $args[0] = 'maid_event_6':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','0,1,2,3,4,5.webm,6,7.webm,8.webm,9,10.webm,11.webm,12.webm,13.webm,14.webm,15.webm,17.webm,18.webm,19.webm,20',_stage)
	if _stage < 20:
		horny += 5
		gs 'zz_render','','pavlovo/hotel/event6/M6_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_6', _stage+1
	elseif _stage = 20:
		orgasm += 1
		DPorgasm += 1
		money += 500
		horny = 0
		$npc['0,hotel_events_oilers_stage'] += 1
		gs 'zz_render','','pavlovo/hotel/event6/M6_'+ _stage, func('hotel_events_data', $args[0], _stage)
		killvar '_stage'
		killvar '$_m_img'
		act 'Уйти': gt $curloc, 'work'
	end
end
!------
! maid_event_7
if $args[0] = 'maid_event_7':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string',',1,2,3,4,5,6,7,8,9,10,11,12,13',_stage)
	if _stage = 0:
		gs 'zz_render','','', func('hotel_events_data', $args[0], _stage)
		act 'Проследить': gt $curloc, 'maid_event_7', _stage+1
	elseif _stage = 1:
		gs 'zz_render','','pavlovo/hotel/event7/M7_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_7', _stage+1
	elseif _stage > 1 and _stage < 4:
		gs 'zz_render','','pavlovo/hotel/event7/M7_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_7', _stage+1
	elseif _stage = 4:
		gs 'zz_render','','pavlovo/hotel/event7/M7_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Пожелать нефтяникам успехов и выйти.':
			cla
			gs 'zz_render','','', '-\\\ Ага, Светка, спасибо. Еще отблагодарим, не ссы, - бросил вам вслед Мишаня, по-хозяйски шерудя у Алены под юбкой.///'
			killvar '_stage'
			killvar '$_m_img'
			act 'Уйти': gt $curloc, 'work'
		end
		act 'Остаться посмотреть':
			cla
			act 'Далее': gt $curloc, 'maid_event_7', _stage+1
		end
	elseif _stage > 4 and _stage < 13:
		horny += 15
		gs 'zz_render','','pavlovo/hotel/event7/M7_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc, 'maid_event_7', _stage+1
	elseif _stage = 13:
		gs 'zz_render','','pavlovo/hotel/event7/M7_'+ $_m_img, func('hotel_events_data', $args[0], _stage)
		horny = 0
		orgasm += 1
		killvar '_stage'
		killvar '$_m_img'
		maid_event_7_request_phone = 1
		act 'Уйти': gt $curloc, 'work'
	end
end
!ивент с горничной/отсос рабочему в подсобке
if $args[0] = 'maid_event_worker_1':
	*clr & cla
	gs 'stat'
	_stage = args[1]
	if _stage < 2:
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + _stage + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_worker_1',_stage+1
	elseif _stage = 2:
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + _stage + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Отказать':
			dom += 1
			*clr & cla
			gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + _stage + '.jpg', func('hotel_events_data', $args[0], 3)
			killvar '_stage'
			act 'Уйти': gt $curloc, 'work'
		end
		act 'Согласиться':
			dom -= 1
			*clr & cla
			gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + _stage + '.jpg', func('hotel_events_data', $args[0], 4)
			act 'Далее': gt $curloc,'maid_event_worker_1',_stage+1
		end
	elseif _stage > 2 and _stage < 14:
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + _stage + '.jpg', func('hotel_events_data', $args[0], _stage+2)
		act 'Далее': gt $curloc,'maid_event_worker_1',_stage+1
	elseif _stage = 14:
		swallow += 1
		bj += 1
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + _stage + '.jpg', func('hotel_events_data', $args[0], _stage+2)
		killvar '_stage'
		$npc['0,hotel_events_worker_flag'] = 1
		act 'Уйти': gt $curloc, 'work'
	end
end
if $args[0] = 'maid_event_worker_2':
	*clr & cla
	_stage = args[1]
	gs 'stat'
	$_m_img = func('zz_funcs','get_item_string','2,6,8,REPEAT_3,REPEAT_4,REPEAT_5,REPEAT_6,REPEAT_7,13',_stage)
	if _stage = 0:
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Порадовать': gt $curloc,'maid_event_worker_2',_stage+1
		act 'Отказать':
			gs 'zz_render','','', '-\\Эээ, нет.//'
			killvar '_stage'
			killvar '$_m_img'
			act 'Уйти': gt $curloc, 'work'
		end
	elseif _stage > 0 and _stage < 5:
		horny += 20
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_worker_2',_stage+1
	elseif _stage = 5:
		horny = 0
		orgasm += 1
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_worker_2',_stage+1
	elseif _stage > 5 and _stage < 8:
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		act 'Далее': gt $curloc,'maid_event_worker_2',_stage+1
	elseif _stage = 8:
		swallow += 1
		bj += 1
		gs 'zz_render','','pavlovo/hotel/event_worker_bj/MW_' + $_m_img + '.jpg', func('hotel_events_data', $args[0], _stage)
		killvar '_stage'
		killvar '$_m_img'
		act 'Уйти': gt $curloc, 'work'
	end
end