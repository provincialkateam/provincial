! stages
! $npc['49,mainQW'] = 0 - ветка не начата
! $npc['49,mainQW'] = 1 - ГГ познакомилась с Альгуль, откривает ивент с фотосессией
! -- все последующие ивенты стартуют для развращенной Светки
! $npc['49,mainQW'] = 2 - ивент с фотосессией закончен, открывает ивент с полизушками
! $npc['49,mainQW'] = 3 - после полизушек в комнате Айгуль, открываются ивенты на подглядывание: в душе и 2 в коридоре
! $npc['49,mainQW'] = 4-6 - подглядывание за Айки, суммируем
! $npc['49,mainQW'] = 10 - после секса с старостой, открывает групповушку с Сашей и Сирожей
! $npc['49,mainQW'] = 15 - после секса с Сашей и Сирожей, открывает визит к неграм
! $npc['49,mainQW'] = 20 - после порнофотосессий в комнате Демаркуса, открывает подглядывание за групповушкой Айгуль и негров
! $npc['49,mainQW'] = 25 - после групповушки Айгуль с негром, открывает возможность присоединиться к очереднымому развлечению Айгуль с неграми
! $npc['49,mainQW'] = 30 - после секса с Айгуль и негром, выход на завершающий ивент ветки
! концовки $npc['49,mainQW']:
!	200 - ГГ не сбежала, но и не помогла Айгуль
!	210 - ГГ отбила Айгуль и взяла визитку фотографа
!	220 - ГГ отбила Айгуль, но не взяла визитку фотографа
!	230 - ГГ не смогла отбить Айгуль
!	255 - ГГ позорно сбежала, обрыв всех отношений
! --
! $npc['49,mainQW_day'] - счетчик дней
!--------
! комната Альгуль
$loc = $curloc
if $args[0] = '' or $args = 'main':
	*clr & cla
	! автозапуск ивента на секс с Олегом
	if hour >= 17 and hour <= 21 and $npc['49,mainQW_day'] ! day:
		if $npc['49,mainQW'] = 6: gt 'npc_algul','algyl_ev7'
		if $npc['49,mainQW'] = 10: gt 'npc_algul','algyl_ev8'
		if $npc['49,mainQW'] = 15: gt 'npc_algul','algyl_ev9'
	end
	!----
	gs 'zz_render','','city/center/university/dorm/interiors/rooms/algul',func('uni_npc_str',15)
	if hour < 8:
		gs 'zz_render','','','В кроватке посапивает Айгуль.'
	elseif hour >= 16:
		gs 'zz_render','','','На кровати валяется <a href="exec:gt''npc_algul'',''talk''">Айгуль</a>'
	end
	act '<b>Уйти</b>': gt 'uni_dorm','5'
	exit
end
! болтовня
if $args[0] = 'talk':
	*clr & cla
	! локация нужна как разводящая
	if shameless['flag'] >= 2 and vnesh >= 40 and $npc['49,relation'] >= 60 and $npc['49,mainQW_day'] ! day:
		if $npc['49,mainQW'] = 1: gt 'npc_algul','algyl_ev2'
		if $npc['49,mainQW'] = 2 and horny >= 60: gt 'npc_algul','algyl_ev3'
	end
	!---
	gs 'npc_editor','get_npc_profile',49
	gs 'npc_editor','check_dialogs',49,'npc_algul','dialogs'
	if $npc['49,mainQW'] >= 3 and horny >= 60: act 'Предложить полизаться': gt 'npc_algul','algyl_ev3'
	!act 'Отойти': gt 'npc_algul'
	exit
end
if $args[0] = 'dialogs':
	minut += rand(5,10)
	gs 'npc_editor','get_npc_profile',49
	gs 'npc_editor','change_rep','+',49
	gs 'zz_render','','',func('uni_npc_str',rand(0,9))
	act 'Отойти': gt 'npc_algul'
	exit
end
!---
! знакомство с Альгуль
if $args[0] = 'algyl_ev1':
	*clr & cla
	_stage = args[1]
	minut += 1
	gs 'stat'
	if _stage = 0: gs 'npc_editor','get_npc_profile',50
	gs 'zz_render','', iif(_stage=0,'','city/center/university/dorm/algul/1/<<_stage>>'),func('uni_npc_str',10+_stage)
	act iif(_stage < 4,'...','Уйти'):
		if _stage < 4:
			gt 'npc_algul','algyl_ev1',_stage+1
		else
			$npc['49,mainQW'] = 1
			$npc['49,know'] = 1
			gt 'uni_dorm','5'
		end
	end
	exit
end
! фотосессия с Альгуль
if $args[0] = 'algyl_ev2':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if _stage = 15 or _stage = 17:
		horny = 0
	elseif _stage > 3:
		horny += rand(7,12)
	end
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/algul/1/'+(_stage + iif(_stage < 3,5,4)),func('uni_npc_str',16+_stage)
	if _stage = 3:
		act 'Не, как-нибудь потом!':
			cla
			gs 'zz_render','','',func('uni_npc_str',20)
			act 'Уйти': gt 'uni_dorm','5'
		end
		act 'Да запросто!': gt 'npc_algul','algyl_ev2',_stage+2
	elseif _stage = 18:
		if lesbo >= 5:
			act 'Полизать ей попку': gt 'npc_algul','algyl_ev2',_stage+1
		else
			act '...': gt 'npc_algul','algyl_ev2',_stage+3
		end
	else
		act iif(_stage < 21,'...','Уйти'):
			if _stage < 21:
				gt 'npc_algul','algyl_ev2',_stage+1
			else
				orgasm += 2
				$npc['49,mainQW'] += 1
				$npc['49,mainQW_day'] = day
				killvar '_stage'
				gt 'uni_dorm','5'
			end
		end
	end
	exit
end
! полизушки с Альгуль - новое только начало, продолжение повторяет второй ивент
if $args[0] = 'algyl_ev3':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	horny += rand(7,12)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/algul/1/'+(_stage + 26),func('uni_npc_str',38+_stage)
	act '...':
		if _stage < 2:
			gt 'npc_algul','algyl_ev3',_stage+1
		else
			! переброс на второй ивент с Айгуль
			killvar '_stage'
			gt 'npc_algul','algyl_ev2',14
		end
	end
end
! ивент в душе
if $args[0] = 'algyl_ev4':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if _stage >= 2: horny += rand(5,15)
	gs 'stat'
	gs 'zz_render','<<_stage>>','city/center/university/dorm/algul/1/'+(31+_stage),func('uni_npc_str',41+_stage)
	if _stage = 0:
		act 'Одеться и выйти':
			cla
			$npc['49,mainQW_day'] = day
			gs 'zz_render','','',func('uni_npc_str',42)
			act 'Уйти': gt 'uni_dorm'
		end
		act 'Подсмотреть': gt 'npc_algul','algyl_ev4',_stage+2
	else
		act iif(_stage < 6,'...','Уйти'):
			if _stage < 6:
				gt 'npc_algul','algyl_ev4',_stage+1
			else
				$npc['49,mainQW_day'] = day
				$npc['49,mainQW'] += 1
				killvar '_stage'
				gt 'uni_dorm'
			end
		end
	end
end
! подглядывание за Айгуль и арабом
if $args[0] = 'algyl_ev5':
	*clr & cla
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 3: horny += rand(5,15)
	gs 'stat'
	gs 'zz_render','',iif(_stage=0,'Картинка коридора','city/center/university/dorm/algul/1/'+(37+_stage)),func('uni_npc_str',49+_stage)
	if _stage = 0:
		act 'Пройти мимо':
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			gt 'uni_dorm','5'
		end
	end
	act iif(_stage = 7 or _stage = 12,'Уйти',iif(_stage=0,'Подсмотреть','...')):
		if _stage = 7 or _stage = 12:
			$npc['49,mainQW_day'] = day
			$npc['49,mainQW'] += 1
			killvar '_stage'
			gt 'uni_dorm','5'
		else
			if _stage = 4 and rand(0,1) = 1:
				gt 'npc_algul','algyl_ev5',_stage+4
			else
				gt 'npc_algul','algyl_ev5',_stage+1
			end
		end
	end
end
! подглядывание за Айгуль с парнями
if $args[0] = 'algyl_ev6':
	*clr & cla
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 1: horny += rand(10,15)
	gs 'stat'
	gs 'zz_render','',iif(_stage=0,'Картинка коридора','city/center/university/dorm/algul/1/'+(49+_stage)),func('uni_npc_str',62+_stage)
	if _stage = 0:
		act 'Побыстрее свалить':
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			gt 'uni_dorm','5'
		end
	end
	act iif(_stage = 4,'Уйти',iif(_stage=0,'Подсмотреть','...')):
		if _stage = 4:
			$npc['49,mainQW_day'] = day
			$npc['49,mainQW'] += 1
			killvar '_stage'
			gt 'uni_dorm','5'
		else
			gt 'npc_algul','algyl_ev6',_stage+1
		end
	end
end
! Светка и Айгуль идут на потрахушки к старосте группы
if $args[0] = 'algyl_ev7':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if _stage >= 3:
		horny += rand(5,10)
		if _stage = 3: gs 'zz_funcs','alko',4
	end
	if _stage = 16 or _stage = 23 or _stage = 30:
		horny = 0
		orgasm += 1
		manna += rand(20,30)
		if _stage = 30:
			analorgasm += 1
		else
			vaginalorgasm += 1
		end
	end
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/algul/1/'+(54+_stage),func('uni_npc_str',67+_stage)
	if _stage = 0:
		if shameless['flag'] = 3 and anal >= 15 and vaginal >= 15: act 'Идти к Олегу': gt 'npc_algul','algyl_ev7',_stage+1
		act 'Может, как-нибудь в другой раз':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render','','city/center/university/dorm/algul/1/54',func('uni_npc_str',99)
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			act 'Уйти': gt 'uni_dorm','5'
		end
	elseif _stage = 10:
		act 'Подставить киску Айгуль': gt 'npc_algul','algyl_ev7',_stage+1
		act 'Подставить свою киску': gt 'npc_algul','algyl_ev7',_stage+9
		act 'Подставить попку': gt 'npc_algul','algyl_ev7',_stage+18
	elseif _stage = 18 or _stage = 27 or _stage = 32:
		killvar '_stage'
		gt 'npc_algul','algyl_ev7_ender'
	else
		act '...': gt 'npc_algul','algyl_ev7',_stage+1
	end
end
if $args[0] = 'algyl_ev7_ender':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/algul/1/'+(98+_stage),func('uni_npc_str',100+_stage)
	act iif(_stage = 4,'Уйти','...'):
		if _stage = 4:
			! прыжок с 6 на 10 - на всякий случай оставим место, если вдруг надо будет повторить ивент
			$npc['49,mainQW'] = 10
			$npc['49,mainQW_day'] = day
			gs 'zz_funcs', 'cum', 'lip'
			killvar '_stage'
			gt 'uni_dorm','5'
		else
			gt 'npc_algul','algyl_ev7_ender',_stage+1
		end
	end
end
! Светка и Айгуль идут на потрахушки к Саше и Сергею
if $args[0] = 'algyl_ev8':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if _stage = 2: gs 'zz_funcs','alko',4
	if _stage >= 4 and _stage <= 26: horny += rand(5,10)
	if _stage = 23:
		horny = 0
		orgasm += 1
		vaginalorgasm += 1
		manna += rand(20,30)
	end
	gs 'stat'
	if _stage = 0: gs 'npc_editor','get_npc_profile',49
	gs 'zz_render','',iif(_stage=0,'','city/center/university/dorm/algul/1/'+(102+_stage)+iif(_stage=5,'.webm','.jpg')),func('uni_npc_str',105+_stage)
	if _stage = 0:
		act 'Не, мне учиться надо':
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			gt 'npc_algul'
		end
		act 'Идти с Айгуль в гости к парням': gt 'npc_algul','algyl_ev8',_stage+1
	elseif _stage = 6:
		act 'Давай': gt 'npc_algul','algyl_ev8',_stage+1
		act 'Лучше не надо': gt 'npc_algul','algyl_ev8',_stage+7
	elseif _stage = 12:
		gt 'npc_algul','algyl_ev8',_stage+4
	else
		if _stage = 26: gs 'zz_reputation','edit',20
		act iif(_stage = 27,'Уйти','...'):
			if _stage = 27:
				gs 'zz_bathroom','clean_me'
				$npc['49,mainQW'] = 15
				$npc['49,mainQW_day'] = day
				killvar '_stage'
				gt 'uni_dorm','5'
			else
				gt 'npc_algul','algyl_ev8',_stage+1
			end
		end
	end
end
! Светка и Айгуль идут на порнофотосессию к Демаркусу
if $args[0] = 'algyl_ev9':
	*clr & cla
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 3 and stage <= 15: horny += rand(5,10)
	gs 'stat'
	if _stage = 0: gs 'npc_editor','get_npc_profile',49
	gs 'zz_render','',iif(_stage=0,'','city/center/university/dorm/algul/2/'+_stage),func('uni_npc_str',133+_stage)
	if _stage = 0:
		act 'Отказаться и уйти':
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			gt 'uni_dorm','5'
		end
		act 'Идти с Айки': gt 'npc_algul','algyl_ev9',_stage+1
	else
		act iif(_stage < 16,'...','Уйти'):
			if _stage < 16:
				gt 'npc_algul','algyl_ev9',_stage+1
			else
				$npc['49,mainQW'] = 20
				$npc['49,mainQW_day'] = day
				$npc['47,know'] = 1
				killvar '_stage'
				gt 'uni_dorm','3'
			end
		end
	end
end
! Светка подсматривает за групповушкой негров и Айгуль
if $args[0] = 'algyl_ev10':
	*clr & cla
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 1 and _stage <= 8: horny += rand(3,7) * (_stage_mast + 1)
	if _stage = 9 and _stage_mast = 1:
		horny = 0
		manna += rand(10,20)
		mastr += 1
		orgasm += 1
	end
	gs 'stat'
	gs 'zz_render','',iif(_stage=0,'коридор общаги','city/center/university/dorm/algul/2/'+(17+_stage)),func('uni_npc_str',150+_stage)
	if _stage_mast = 1:
		if _stage = 4: gs 'zz_render','','',func('uni_npc_str',161)
		if _stage = 7: gs 'zz_render','','',func('uni_npc_str',162)
		if _stage = 9: gs 'zz_render','','',func('uni_npc_str',163)
	end
	if _stage = 0:
		act 'Пожать плечами и уйти':
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			gt 'uni_dorm','5'
		end
		act 'Подсматривать': gt 'npc_algul','algyl_ev10',_stage+1
	elseif _stage = 3:
		if horny >= 40: act 'Мастурбировать': _stage_mast = 1 & gt 'npc_algul','algyl_ev10',_stage+1
		act 'Подсматривать': gt 'npc_algul','algyl_ev10',_stage+1
	else
		act iif(_stage < 10,'...','Уйти'):
			if _stage < 10:
				gt 'npc_algul','algyl_ev10',_stage+1
			else
				$npc['49,mainQW'] = 25
				$npc['49,mainQW_day'] = day
				killvar '_stage'
				killvar '_stage_mast'
				gt 'uni_dorm','5'
			end
		end
	end
end
! Светка снова проходит мимо комнаты Айгуль, а там снова негры
if $args[0] = 'algyl_ev11':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if _stage > 0 and _stage < 8: horny += rand(10,15)
	if _stage = 8: gs 'zz_reputation','edit',10
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/'+iif(_stage = 0 or _stage = 8,'interiors/floor5','algul/2/'+(28+_stage)),func('uni_npc_str',164+_stage)
	if _stage = 0:
		act 'Хмыкнуть и уйти':
			$npc['49,mainQW_day'] = day
			killvar '_stage'
			gt 'uni_dorm','5'
		end
	end
	act func('zz_funcs','get_item_string','Посмотреть,Раздеться и помочь,...,...,...,...,...,Как нибудь потом,Уйти',_stage):
		if _stage < 8:
			gt 'npc_algul','algyl_ev11',_stage+1
		else
			$npc['49,mainQW'] = 30
			$npc['49,mainQW_day'] = day
			gs 'zz_funcs','cum','lip'
			killvar '_stage'
			gt 'uni_dorm','5'
		end
	end
end
! Светка снова проходит мимо комнаты Айгуль, а там снова негры
if $args[0] = 'algyl_ev12':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if (_stage > 5 and _stage < 15) or (_stage >= 26 and _stage < 32): horny += rand(5,10)
	if _stage = 15 or _stage = 32:
		horny = 0
		orgasm += 1
		mastr += 1
		manna += rand(10,20)
		if _stage = 33:
			bj += 1
			sex += 1
			vaginalorgasm += 1
			analorgasm += 1
			swallow += 1
			gs 'zz_funcs','set_gape','vagina',100,15,1
			gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),15,1
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
		end
	end
	gs 'stat'
	if _stage = 0:
		$_al_img = 'надо_пикчу0,надо_пикчу1,надо_пикчу2,37,38,39.webm,40,41,42.webm,43.webm,44.webm,45.webm,46.webm,47.webm,48.webm,49,50.webm,51'
		$_al_img += ',надо_пикчу3,52,надо_пикчу4,надо_пикчу5,надо_пикчу6,52,53,54,55,56,57,59,60,62,64,66,67'
	end
	gs 'zz_render','','city/center/university/dorm/algul/2/'+func('zz_funcs','get_item_string',$_al_img,_stage),func('uni_npc_str',173+_stage)
	if _stage = 0:
		act 'Ничего не предпринимать': gt 'npc_algul','algyl_ev12',_stage+1
		act 'Спрятаться и подсмотреть, что будет': gt 'npc_algul','algyl_ev12',_stage+2
		if dom >= 10: act 'Вмешаться и попробовать отбить девушку': gt 'npc_algul','algyl_ev12',_stage+18
	elseif _stage = 1:
		! фейл, разрыв всех отношений с Айгуль
		gs 'npc_editor','change_rep','down',49,100
		$npc['49,mainQW'] = 255
		gs 'npc_algul','algyl_ev12_ender'
	elseif _stage = 17:
		$npc['49,mainQW'] = 200
		gs 'npc_algul','algyl_ev12_ender'
	elseif _stage = 18:
		act 'Дать отпор супостатам':
			if agil >= 60 and stren >= 60:
				dom += 2
				gt 'npc_algul','algyl_ev12',_stage+1
			else
				gt 'npc_algul','algyl_ev12',_stage+5
			end
		end
	elseif _stage = 20:
		act 'Не, Гуль, как-то не тянет': gt 'npc_algul','algyl_ev12',_stage+1
		act 'Я не против, даже интересно': gt 'npc_algul','algyl_ev12',_stage+2
	elseif _stage = 21 or _stage = 22:
		$npc['49,mainQW'] = iif(_stage = 21,210,220)
		gs 'npc_algul','algyl_ev12_ender',1
	elseif _stage = 34:
		$npc['49,mainQW'] = 230
		gs 'npc_algul','algyl_ev12_ender'
	else
		act '...': gt 'npc_algul','algyl_ev12',_stage+1
	end
end
if $args[0] = 'algyl_ev12_ender':
	$npc['49,mainQW_day'] = day
	killvar '_stage'
	killvar '$_al_img'
	act iif(args[1] = 1,'Отойти','Уйти'):
		if args[1] = 1:
			gt 'npc_algul'
		else
			gt 'uni_dorm','5'
		end
	end
end