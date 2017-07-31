! Ветка Сони Иванько
! $npc['25,qwSonya_day'] - день ивента
! $npc['25,qwSonya_payday'] - день последней оплаты кружка пения
! $npc['25,qwSonya_paysuck'] - флаг сосала или нет ГГ преподавателю кружка
! $npc['25,qwSonya_lesbo'] - флаг для начала побочного ивента с лесбо-сценкой с Соней
! $npc['25,qwSonya_demo'] = день записи демо
! $npc['25,qwSonya'] - стадия ивента
! стадии
! 0 - приличная девушка, одноклассница
! 1 - Светка отказалась идти бухать, Котов после 22 часов приводит бухую Соню обратно на дискотеку
! 2 - Светка пошла бухать, но смотреть, как Соня работает ртом отказалась, Котов после 22 часов приводит бухую Соню обратно на дискотеку
! 3 - Светка пошла бухать и просмотрела почти до конца
! 5 - падение Сони завершено
! 6-15 - ГГ видит за Соню работой в туалете школы, в парке, в отеле
! 15 - Соня отбивает ГГ от гопоты - начало
! 20 - Соня отбила ГГ от гопоты,открывается диалог с отчимом о Соне
! 25 - отчим рассказал о Соне
! 30 - ГГ проследила за Соней в Сити
! 35 - ГГ поболтала с Соней в кафешке
! 40 - после диалога с гопотой в туалете
! 41 - Иван согласился помочь
! 45 - первый разговор с ТМ о Соне
! 46 - второй разговор с ТМ о Соне
! 50 - Соня больше не шлюха - отбита ГГ или с помощью Ивана или ТМ
! 55 - после разговора Сони и ГГ о будущем
! 56 - ГГ оплатила кружок деньгами
! 57 - ГГ оплатила кружок минетом
! 60 - после разговора ГГ с Соней по поводу оплаты, дальше переход на еженедельную оплату, в случае пропуска - Соня напоминает, если и дальше не оплатить - конец ветки
! 60 - 79 - прогулки с Соней: +1 - в парке, +2 - в кино, +3 - в кафе
! 80 - после разговора с Соней о демке
! 85 - разговор с руководителем кружка
! 90 - демка записана
! 95 - ГГ забрала демку
! 100 - ГГ нашла кафешку для выступлений
! 255 - ветка провалена
! ---
! падение - начало
if $args[0] = 'falling_init':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/falling/0.gif',func('sonya_strings',0)
	act '...':
		*clr & cla
		gs 'zz_render','','pavlovo/sonya/falling/1',func('sonya_strings',1)
		act 'Отказаться':
			*clr & cla
			gs 'zz_render','','pavlovo/sonya/falling/1',func('sonya_strings',2)
			minut += rand(3,7)
			$npc['25,qwSonya'] = 1
			act 'Отойти': gt 'gdkin'
		end
		act 'Идти бухать': gt 'sonya','falling_drink'
	end
end
! процедура бухания
if $args[0] = 'falling_drink':
	*clr & cla
	_stage = args[1]
	minut += rand(3,5)
	if _stage >= 1 and _stage <= 3:
		gs 'zz_funcs','alko',iif(energy < 12,2,1)
		manna += rand(3,5)
	end
	gs 'stat'
	gs 'zz_render','','pavlovo/sonya/falling/'+iif(_stage<=3,2,_stage)+iif(_stage<=3 or _stage=6,'.jpg','.gif'),func('sonya_strings',3+_stage)
	act func('zz_funcs','get_item_string','Выпить,Выпить еще,Еще по одной,...,Слушать,...,Смотреть,Смотреть,Уйти',_stage):
		if _stage < 8:
			gt 'sonya','falling_drink',_stage+1
		else
			$npc['25,qwSonya'] = 3
			minut += rand(3,5)
			gt 'gdkin'
		end
	end
	! кнопка отговаривать Соню
	if _stage = 7:
		act 'Уйти':
			$npc['25,qwSonya'] = 2
			minut += rand(5,10)
			gt 'gdkin'
		end
	end
end
! Котов после 22 часов приводит бухую Соню обратно на дискотеку
if $args[0] = 'falling_finish':
	*clr & cla
	$npc['25,qwSonya'] = 5
	gs 'zz_render','','pavlovo/sonya/falling/9',func('sonya_strings',12)
	act 'Отойти': gt 'gdkin'
end
! потрахушки Сони в парке
if $args[0] = 'suck_in_park':
	*clr & cla
	gs 'zz_render','',func('zz_funcs','mk_image','common/park/walk'),func('sonya_strings',13)
	act 'Посмотреть':
		*clr & cla
		minut += rand(3,7)
		if $npc['25,qwSonya'] < 15: $npc['25,qwSonya'] += 1
		gs 'zz_render','','pavlovo/sonya/park/suck',func('sonya_strings',14)
		act 'Уйти': gt 'zz_park'
	end
end
! Соня спасает ГГ от гопников
if $args[0] = 'help_in_park':
	*clr & cla
	$npc['25,qwSonya_day'] = day
	gs 'zz_render','','',func('sonya_strings',15)
	act iif(dom >= 20,'Отвали!','Нуу-у...'):
		*clr & cla
		if dom >= 20:
			if boxing > 60 and rand(0,10) mod 3 = 0:
				! Светка справляется сама
				minut += rand(5,10)
				gs 'zz_render','','',func('sonya_strings',16)
				act 'Уйти': gt 'zz_park'
			else
				! помогает Соня
				gs 'zz_render','','',func('sonya_strings',17)
				act '...': gt 'sonya','help_in_park_finish'
			end
		else
			if rand(0,10) mod 3 = 0:
				! вспугивает случайный прохожий мент
				minut += rand(15,30)
				gs 'zz_render','','',func('sonya_strings',18)+func('sonya_strings',19)
				act 'В городок': gt 'gorodok'
			else
				! помогает Соня
				gs 'zz_render','','',func('sonya_strings',18)
				act '...': gt 'sonya','help_in_park_finish'
			end
		end
	end
end
if $args[0] = 'help_in_park_finish':
	*clr & cla
	gs 'zz_render','','',func('sonya_strings',20)
	act 'Бежать':
		*clr & cla
		minut += rand(5,10)
		$npc['25,qwSonya'] = 20
		gs 'stat'
		gs 'npc_editor','change_rep','+',25,100
		gs 'zz_render','','',func('sonya_strings',21)
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
end
! отчим рассказывает ГГ о Соне
if $args[0] = 'father_talk_about_sonya':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/singer/breakfast',func('sonya_strings',22)
	act 'Да ну!':
		*clr & cla
		gs 'zz_render','','',func('sonya_strings',23)
		act 'Хм...':
			*clr & cla
			gs 'zz_render','','',func('sonya_strings',24)
			minut += rand(3,5)
			$npc['25,qwSonya'] = 25
			act 'Отойти': gt 'kuhrPar'
		end
	end
end
! ДК, ГГ подглядывает за репетицией Сони
if $args[0] = 'meet_in_dk':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/dk/0',func('sonya_strings',25)
	act '...':
		*clr & cla
		minut += rand(30,60)
		gs 'stat'
		gs 'zz_render','','city/north/dk/hall',func('sonya_strings',26)
		act '...':
			*clr & cla
			minut += rand(5,10)
			$npc['25,qwSonya'] = 30
			$npc['25,qwSonya_day'] = day
			gs 'zz_render','','',func('sonya_strings',27)
			act 'Уйти': gt 'nord'
		end
	end
end
! разговор Светки и Сони после школы
if $args[0] = 'meet_near_school':
	*clr & cla
	_stage = args[1]
	gs 'zz_render','','pavlovo/sonya/cafe_talk/'+iif(_stage <= 1,0,_stage),func('sonya_strings',_stage+28)
	act iif(_stage=1 or _stage=3,'Уйти','...'):
		if _stage < 3:
			if _stage = 0:
				gt 'sonya','meet_near_school',iif(dom < 10 and GorSlut > 1,1,2)
			else
				gt 'sonya','meet_near_school',_stage+1
			end
		else
			$npc['25,qwSonya'] = 35
			$npc['25,qwSonya_day'] = day
			minut += rand(3,7)
			killvar '_stage'
			gt 'zz_park'
		end
	end
end
! отбиваем Соню от гопоты - разговор
if $args[0] = 'talk_in_toilet':
	gs 'zz_render','','pavlovo/sonya/school/toilet/toilet_group1',func('sonya_strings',32)
	if boxing > 90 and dom > 40:
		act	'Вписаться за Соню': gt 'sonya','toilet_fight'
	else
		$npc['25,qwSonya'] = 40
		gs 'zz_render','','',func('sonya_strings',37)
		if $npc['45,qwTamara'] >= 10 and $npc['45,qwTamara'] < 50: gs 'zz_render','','',func('sonya_strings',38)
	end
end
! отбиваем Соню от гопоты - бой
if $args[0] = 'toilet_fight':
	*clr & cla
	_stage = args[1]
	gs 'zz_render','','pavlovo/sonya/toilet/fight/<<_stage>>',func('sonya_strings',_stage+33)
	act iif(_stage=3,'Уйти','...'):
		if _stage < 3:
			gt 'sonya','toilet_fight',_stage+1
		else
			$npc['25,qwSonya'] = 50
			dom += rand(5,10)
			killvar '_stage'
			gt 'zz_school'
		end
	end
end
! просим Ивана о помощи
if $args[0] = 'ask_ivan_for_help':
	*clr & cla
	gs 'npc_editor','get_npc_profile',3
	gs 'zz_render','','',func('sonya_strings',39)
	act 'Уйти':
		*clr & cla
		gs 'npc_editor','get_npc_profile',3
		gs 'zz_render','','',func('sonya_strings',40)
		$npc['25,qwSonya'] = 41
		$npc['25,qwSonya_day'] = day
		act 'Уйти': gt $loc,$metka
	end
end
! Иван помогает отбить Соню
if $args[0] = 'ivan_help':
	*clr & cla
	gs 'zz_render','','',func('sonya_strings',41)
	act '...':
		*clr & cla
		gs 'zz_render','','',func('sonya_strings',42)
		act '...':
			*clr & cla
			gs 'zz_render','','',func('sonya_strings',43)
			$npc['25,qwSonya'] = 50
			$npc['25,qwSonya_day'] = day
			act 'Уйти': gt 'zz_school'
		end
	end
end
! спрашивем о Соне у ТМ - первый шаг
if $args[0] = 'ask_tamara_for_help':
	*clr & cla
	gs 'npc_editor','get_npc_profile',45
	gs 'zz_render','','',func('sonya_strings',44)
	$npc['25,qwSonya'] = 45
	$npc['25,qwSonya_day'] = day
	act 'Отойти': gt 'mey_home',4
end
! спрашивем о Соне у ТМ - второй шаг
if $args[0] = 'ask_tamara_for_help2':
	*clr & cla
	gs 'npc_editor','get_npc_profile',45
	gs 'zz_render','','',func('sonya_strings',45)
	$npc['25,qwSonya'] = 46
	$npc['25,qwSonya_day'] = day
	act 'Отойти': gt 'mey_home',4
end
! помощь ТМ
if $args[0] = 'tamara_help':
	*clr & cla
	gs 'zz_render','','',func('sonya_strings',46)
	act '...':
		*clr & cla
		gs 'zz_render','','',func('sonya_strings',47)
		act '...':
			*clr & cla
			gs 'zz_render','','',func('sonya_strings',48)
			$npc['25,qwSonya'] = 50
			$npc['25,qwSonya_day'] = day
			act 'Уйти': gt 'zz_school'
		end
	end
end
! ГГ болтает с Соней о Сергее Шульгине
if $args[0] = 'talk_about_sergey':
	*clr & cla
	gs 'npc_editor','get_npc_profile',25
	gs 'zz_render','','',func('sonya_strings',49)
	$npc['25,qwSonya'] = 55
	$npc['25,qwSonya_day'] = day
	act 'Отойти': gt $loc,$metka
end
! ГГ болтает с руководителем кружка в Сити
if $args[0] = 'talk_with_teacher':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/dk/2',func('sonya_strings',50)
	$npc['25,qwSonya_day'] = day
	if shameless['flag'] > 0:
		act 'Дождаться преподавателя':
			*clr & cla
			$npc['25,qwSonya'] = 57
			$npc['25,qwSonya_paysuck'] = 1
			gs 'zz_render','','pavlovo/sonya/dk/2',func('sonya_strings',51)
			act 'Закрыть дверь': gt 'sonya','payment_bj'
		end
	end
	act 'Заплатить за неделю (1000р.)':
		if money >= 1000:
			gt 'sonya','payment_money'
		else
			gs 'zz_render','','','<red>У вас недостаточно денег!</red>'
		end
	end
	act 'Уйти': gt 'nord'
end
! ГГ оплачивает натурой кружок Сони
if $args[0] = 'payment_bj':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/dk/3.gif',func('sonya_strings',52)
	act 'Сосать':
		*clr & cla
		minut += rand(5,10)
		bj += 1
		gs 'zz_funcs','cum','lip'
		$npc['25,qwSonya_payday'] = -7
		gs 'stat'
		gs 'zz_render','','pavlovo/sonya/dk/3.gif',func('sonya_strings',53)
		act 'Уйти': gt 'nord'
	end
end
! ГГ оплачивает деньгами кружок Сони
if $args[0] = 'payment_money':
	*clr & cla
	! шаг ветки только для первого раза
	if $npc['25,qwSonya'] = 55: $npc['25,qwSonya'] = 56
	money -= 1000
	minut += rand(5,10)
	! ставим -7 - до конца недели в плюс не выйдем
	$npc['25,qwSonya_payday'] = -7
	gs 'stat'
	gs 'zz_render','','pavlovo/sonya/dk/2',func('sonya_strings',54)
	act 'Уйти': gt 'nord'
end
! разговор об оплате кружка
if $args[0] = 'talk_about_payment':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/dk/5',func('sonya_strings',55)
	act '...':
		*clr & cla
		gs 'zz_render','','pavlovo/sonya/dk/5',func('sonya_strings',56)
		$npc['25,qwSonya'] = 60
		act 'Отойти': gt $loc,$metka
	end
end
! проверка оплаты и вывод сообщения
if $args[0] = 'check_payment':
	if $npc['25,qwSonya_payday'] <= 1:
		exit
	elseif $npc['25,qwSonya_payday'] > 1 and $npc['25,qwSonya_payday'] < 5:
		! напоминаем, что надо оплатить
		*clr & cla
		$npc['25,qwSonya_day'] = day
		gs 'npc_editor','get_npc_profile',25
		gs 'zz_render','','',func('sonya_strings',57)
		if money >= 1000:
			act 'Дать денег (1000р.)':
				*clr & cla
				money -= 1000
				! ставим -7 - до конца недели в плюс не выйдем
				$npc['25,qwSonya_payday'] = -7
				gs 'stat'
				gs 'npc_editor','get_npc_profile',25
				gs 'zz_render','','',func('sonya_strings',58)
				act 'Отойти': gt $loc,$metka
			end
		end
		act 'Я разберусь': gt $loc,$metka
	else
		! закрываем ветку, если ГГ не оплатила кружок Сони
		*clr & cla
		$npc['25,qwSonya'] = 255
		gs 'npc_editor','get_npc_profile',25
		gs 'npc_editor','change_rep','down',25,100
		gs 'zz_render','','',func('sonya_strings',59) + func('sonya_strings',iif($npc['25,qwSonya_paysuck']=1,60,61))
		if $npc['25,qwSonya_paysuck'] = 1 and GorSlut = 0: GorSlut = 1
		act 'Отойти': gt $loc,$metka
	end
end
! --- выгуливаем Соню
if $args[0] = 'walk_after_school':
	*clr & cla
	! проверка оплаты и вывод сообщения
	if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] < 255 and $npc['25,qwSonya_day'] ! day: gs 'sonya','check_payment'
	!--
	$npc['25,qwSonya_day'] = day
	gs 'npc_editor','get_npc_profile',25
	gs 'zz_render','','',func('sonya_strings',62)
	act 'В парк':
		*clr & cla
		if $npc['25,qwSonya'] < 75: $npc['25,qwSonya'] += 1
		minut += rand(30,60)
		manna += rand(5,10)
		gs 'stat'
		gs 'zz_render','',func('zz_funcs','mk_image_ex','common/park/park',1),func('sonya_strings',63)
		gs 'sonya','walk_ender'
	end
	if money >= 300:
		act 'В кино (300р.)':
			*clr & cla
			minut += 120
			manna += rand(5,10)
			gs 'stat'
			if $npc['25,qwSonya'] < 75: $npc['25,qwSonya'] += 2
			gs 'zz_render','','pavlovo/sonya/walk/cinema',func('sonya_strings',65)
			gs 'sonya','walk_ender'
		end
	end
	if money >= 600:
		act 'В "Del Parco" (600р.)':
			*clr & cla
			minut += rand(60,120)
			energy += rand(3,5)
			water += rand(3,5)
			manna += rand(5,10)
			gs 'stat'
			if $npc['25,qwSonya'] < 75: $npc['25,qwSonya'] += 3
			gs 'zz_render','','pavlovo/sonya/cafe_talk/2',func('sonya_strings',64)
			gs 'sonya','walk_ender'
		end
	end
	! 7000р: 6000 - на запись, 1000 - на дорогу
	if $npc['25,qwSonya'] = 85 and money >= 7000: act 'Ехать на запись демо': gt 'sonya','record_demo'
end
if $args[0] = 'walk_ender':
	if $npc['25,qwSonya'] >= 75 and $npc['25,qwSonya'] < 80: act 'Поговорить о записи демо': gt 'sonya','talk_about_demo'
	if $npc['25,qwSonya_lesbo'] > 0:
		act 'А поцеловать?':
			*clr & cla
			gs 'zz_render','','pavlovo/sonya/walk/kiss1',func('sonya_strings',66)
			act 'Уйти': gt 'gorodok'
		end
	end
	act 'Уйти': gt 'gorodok'
end
! разговор c Соней о записи демки
if $args[0] = 'talk_about_demo':
	*clr & cla
	gs 'zz_render','','',func('sonya_strings',67)
	$npc['25,qwSonya'] = 80
	! надо написать лесбо-сценку для Светки с Соней
	if shameless['flag'] > 0 and lesbi > 0:
		act 'Подставить губы':
			*clr & cla
			$npc['25,qwSonya_lesbo'] = 1
			gs 'zz_render','','pavlovo/sonya/walk/kiss1',func('sonya_strings',68) + func('sonya_strings',70)
			act 'Уйти': gt 'gorodok'
		end
	end
	act 'Подставить щечку':
		*clr & cla
		gs 'zz_render','','pavlovo/sonya/walk/kiss0',func('sonya_strings',69) + func('sonya_strings',70)
		act 'Уйти': gt 'gorodok'
	end
end
! разговор c руководителем кружка о записи демки
if $args[0] = 'talk_about_demo_with_boss':
	*clr & cla
	gs 'zz_render','','pavlovo/sonya/dk/1',func('sonya_strings',71)
	$npc['25,qwSonya'] = 85
	act 'Уйти': gt 'nord'
end
! запись демо
if $args[0] = 'record_demo':
	*clr & cla
	gs 'npc_editor','get_npc_profile',25
	gs 'zz_render','','',func('sonya_strings',72)
	act '...':
		*clr & cla
		! если кто будет крутить время читами - сам виноват
		minut += 19*60 - (hour*60 + minut)
		money -= 400
		gs 'stat'
		gs 'zz_render','','city/north/dk/sound',func('sonya_strings',73)
		act '...':
			*clr & cla
			minut += rand(90,120)
			money -= 6000
			gs 'stat'
			gs 'zz_render','','pavlovo/sonya/dk/demo',func('sonya_strings',74)
			act 'Ехать домой':
				$npc['25,qwSonya'] = 90
				$npc['25,qwSonya_demo'] = daystart + rand(2,5)
				minut += (23*60 + 45) - (hour*60 + minut)
				money -= 400
				gt 'gorodok'
			end
		end
	end
end
! забираем демо
if $args[0] = 'take_demo':
	*clr & cla
	$npc['25,qwSonya'] = 95
	$npc['25,qwSonya_day'] = day
	gs 'zz_render','','',func('sonya_strings',75)
	act 'Уйти': gt 'nord'
end
! ходим по клубам, продвигаем Соню
if $args[0] = 'sonya_promo_init':
	*clr & cla
	gs 'zz_render','','',func('sonya_strings',76)
	$_places['0,name'] = '"Спутник"'
	$_places['1,name'] = '"Tarantino"'
	$_places['2,name'] = '"Генацвале"'
	$_places['3,name'] = '"Блюз"'
	$_places['4,name'] = 'Арт-кафе "Бункер"'
	$_places['0,visited'] = 0
	$_places['1,visited'] = 0
	$_places['2,visited'] = 0
	$_places['3,visited'] = 0
	$_places['4,visited'] = 0
	act 'Искать дальше': gt 'sonya','sonya_promo'
end
if $args[0] = 'sonya_promo':
	*clr & cla
	minut += rand(15,30)
	gs 'stat'
	! время на поиски вышло
	if hour >= 18:
		gs 'zz_render','','','Что-то вы совсем устали ходить по кафешкам, на сегодня пора завязывать.'
		killvar '_cur_place'
		act 'Уйти': gt 'nord'
		exit
	end
	! выбираем рандомно место
	:loop_place
	_cur_place = rand(0,4)
	if $_places['<<_cur_place>>,visited'] = 1: jump 'loop_place'
	!---
	$_places['<<_cur_place>>,visited'] = 1
	gs 'zz_render','','pavlovo/sonya/promo/<<_cur_place>>',func('sonya_strings',77) + $_places[_cur_place]
	if _cur_place < 3:
		! проходим мимо
		gs 'zz_render','','',func('sonya_strings',78)
		act 'Искать дальше': gt 'sonya','sonya_promo'
	elseif _cur_place = 3:
		! не тот репертуар, проходим мимо
		gs 'zz_render','','',func('sonya_strings',79)
		act 'Идти к директору':
			*clr & cla
			gs 'zz_render','','pavlovo/sonya/promo/5',func('sonya_strings',80)
			act 'Искать дальше': gt 'sonya','sonya_promo'
		end
	else
		! самое то
		gs 'zz_render','','',func('sonya_strings',81)
		act '...':
			*clr & cla
			gs 'zz_render','','pavlovo/sonya/promo/6',func('sonya_strings',82)
			act '...':
				*clr & cla
				gs 'zz_render','','pavlovo/sonya/promo/6',func('sonya_strings',83)
				act '...':
					*clr & cla
					gs 'zz_render','','pavlovo/sonya/promo/6',func('sonya_strings',84)
					killvar '$_places'
					killvar '_cur_place'
					$npc['25,qwSonya'] = 100
					$npc['25,qwSonya_day'] = day
					act 'Уйти': gt 'nord'
				end
			end
		end
	end
end