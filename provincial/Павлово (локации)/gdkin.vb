if $args[0] = 'main' or $args[0] = '':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if hour >= 20 and hour < 23:
		gs 'zz_render','Дискотека','pavlovo/dk/disco/disco',func('gdkin_strings',0)+'<table><tr><td width=250 valign=top>На танцполе танцуют:<br>'+func('npc_editor','make_npc_group',3,1)+'</td><td width=250 valign=top>В углу стоят:<br>'+func('npc_editor','make_npc_group',4,1)+'</td></tr></table>'
		if hour >= 21 and week = 5: gs 'zz_render','','',func('gdkin_strings',1)
		! начало ветки Сони
		if hour = 21 and $npc['25,qwSonya'] = 0 and rand(0,10) < 2: gt 'sonya','falling_init'
		! после 22 часов Котов приводит Соню
		if $npc['25,qwSonya'] >= 1 and $npc['25,qwSonya'] < 5 and hour = 22: gt 'sonya','falling_finish'
		! подкаты однокласников
		if GorSlut < 2:
			numnpc = 9 + rand(0,2)
			if $npc['<<numnpc>>,relation'] >= 40 and rand(0,150) <= vnesh and $npc['<<numnpc>>,drink'] ! day: gt 'gdkin','gop_drink'
			if $npc['9,relation'] >= 80 and (vnesh >= 60 or $npc['9,qwKotovLove'] > 5) and rand(50,100) <= vnesh and $npc['9,dance'] ! day: gt 'gdkin','kotov_dance'
			if $npc['1,relation'] >= 40 and vnesh >= 40 and rand(30,100) <= vnesh and $npc['1,dance'] ! day: gt 'gdkin','dima_dance'
			if $npc['4,relation'] >= 40 and vnesh >= 40 and rand(30,100) <= vnesh and $npc['4,dance'] ! day: gt 'gdkin','igor_dance'
		end
		! --
		if $npc['14,qwKatya'] = 55 and $npc['14,qwKatya_day'] ! day: act 'Наблюдать за Катей': gt 'mey_katya_events','disco_observing'
		! --
		act 'Танцевать одной': gt 'gdkin','dancing'
		act 'Стоять у стенки': gt 'gdkin','waiting'
	else
		gs 'zz_render','Дискотека','pavlovo/dk/disco/disco_end',func('gdkin_strings',2)
	end
	act 'Выйти наружу': gt 'gdk'
	if DansOralSlut = 1 and GorSlut = 0 and dentoilet ! daystart and hour < 23 and rand (0,3) = 1 :
		act 'Туалет': gt 'gdkin_toilet'
	else
		act 'Туалет': gt 'zz_toilet'
	end
	exit
end
! гг танцует
if $args[0] = 'dancing':
	*clr & cla
	minut += 5
	if dance < 50 and agil >= dance: dance += 1
	manna += rand(3,7)
	gs 'stat'
	! здесь надо будет привязать шалости на дискотеке с Катей
	if alko = 0:
		gs 'zz_render','','pavlovo/dk/disco/dancing/0',func('gdkin_strings',3)
	elseif alko > 0 and alko < 4:
		if tanga = 0 and func('zz_clothing','is_skirt') = 1:
			gs 'zz_render','','pavlovo/dk/disco/dancing/1.gif',func('gdkin_strings',5)
		else
			gs 'zz_render','','pavlovo/dk/disco/dancing/2',func('gdkin_strings',4)
		end
	else
		if $npc['14,relation'] >= 60 and $npc['14,qwKatya_day'] ! day:
			gt 'mey_katya_events','drunk_meet'
		else
			gs 'zz_render','','pavlovo/dk/disco/dancing/3',func('gdkin_strings',6)
		end
	end
	act 'Далее': gt 'gdkin'
	if cumface > 0 or cumfrot > 0: xgt 'gdkin','check_cum'
	gs 'gdkin','dance_with_boy'
end
! гг стоит у стенки
if $args[0] = 'waiting':
	*clr & cla
	minut += 5
	manna -= 5
	gs 'stat'
	gs 'zz_render','','pavlovo/dk/disco/disco'
	if alko = 0:
		gs 'zz_render','','',func('gdkin_strings',7)
	elseif alko > 0 and alko < 4:
		gs 'zz_render','','',func('gdkin_strings',8)
	else
		gs 'zz_render','','',func('gdkin_strings',9)
	end
	act 'Далее': gt 'gdkin'
	if cumface > 0 or cumfrot > 0: xgt 'gdkin','check_cum'
	gs 'gdkin','dance_with_boy'
end
! проверка присутствия спермы на лице или одежде
if $args[0] = 'check_cum':
	cla
	if GorSlut < 2: GorSlut = 2
	manna = manna/2
	gs 'zz_render','','',func('gdkin_strings',10)
	act 'Уйти': gt 'gdk'
	exit
end
! предложение танца с парнем
if $args[0] = 'dance_with_boy':
	if rand(0,100) <= vnesh + alko:
		cla
		!создание партнера для танца
		gs 'BnameGen'
		i = rand(0,100)
		if i < 70:
			!обыкновенный местный парень
			DPgrup = 1
			DPtipe = iif(rand(0,100) < 70,1,2)
			gs 'zz_render','','',func('gdkin_strings',15)
		elseif i >= 70 and i < 90:
			!местный гопарь
			DPgrup = 2
			DPtipe = iif(rand(0,100) < 50,1,2)
			gs 'zz_render','','',func('gdkin_strings',16)
		else
			!командировочный
			DPgrup = 3
			DPtipe = iif(rand(0,100) < 90,1,2)
			gs 'zz_render','','',func('gdkin_strings',17)
		end
		act 'Танцевать':
			*clr & cla
			minut += 5
			if dance < 50 and agil >= dance: dance += 1
			gs 'stat'
			gs 'zz_render','','pavlovo/dk/disco/boys/<<DPgrup>><<DPtipe>>',func('gdkin_strings',val(str(DPgrup)+str(DPtipe)))
			if (alko = 0 and DPtipe = 1) or (alko > 0 and DPtipe = 2) or shameless['flag'] >= 2:
				horny += 10
				manna += 10
				gs 'zz_render','','',func('gdkin_strings',iif(alko = 0,13,23))
				act 'Танцевать дальше': gs 'gdkin','select_dance'
			else
				horny -= 5
				manna -= 5
				gs 'zz_render','','',func('gdkin_strings',iif(alko > 0,14,24))
				act 'Прекратить танец': gt $curloc
			end
		end
		if alko < 3 and dom > -10: act 'Отказаться': gt $curloc
	end
end
! выбор танца
if $args[0] = 'select_dance':
	cla
	if dance > 60 and alko > 0 and horny > 60 and shameless['flag'] > 0:
		act 'Сексуально танцевать':
			*clr & cla
			if tanga = 0 and func('zz_clothing','is_skirt') = 1:
				gs 'zz_render','','pavlovo/dk/disco/dancing/sexy0',func('gdkin_strings',18)
			else
				gs 'zz_render','','pavlovo/dk/disco/dancing/sexy1',func('gdkin_strings',19)
			end
			gs 'stat'
			act 'Далее': gt 'gdkin'
		end
	end
	if $npc['9,qwKotovLove'] > 5: gt 'gdkin','boyfriend_kotov'
	if DPgrup = 1:
		gs 'zz_render','','',func('gdkin_strings',iif(DPtipe = 1,20,25))
		act 'Идти с парнем': gt 'EvBoyBuh'
	elseif DPgrup = 2:
		gs 'zz_render','','',func('gdkin_strings',iif(DPtipe = 1,26,27))
		act 'Идти бухать': gt 'EvgopBuh'
	else
		if DPtipe = 1:
			gs 'zz_render','','',func('gdkin_strings',28)
			act 'Идти с мужчиной':
				*clr & cla
				gs 'zz_render','','pavlovo/dk/dk_night.jpg', func('gdkin_strings',29)
				if shameless['flag'] > 0: act 'Ехать в отель': gt 'EvOtelMan'
				act 'Отказаться': gt 'gdkin'
			end
		else
			gs 'zz_render','','',func('gdkin_strings',30)
			act 'Ехать в отель': gt 'EvOtelMan'
			if alko < 3:act 'Отказаться': gt 'gdkin'
		end
	end
	if alko < 3: act 'Отказаться': gt 'gdkin'
end
!
if $args[0] = 'boyfriend_kotov':
	*clr & cla
	gs 'npc_editor','get_npc_profile',9
	gs 'zz_render','','',func('gdkin_strings',33)
	if DPgrup = 1:
		i = RAND(0,10)
		if i <= 5:
			gs 'zz_render','','',func('gdkin_strings',34)
		elseif i > 5 and i < 10:
			gs 'zz_render','','',func('gdkin_strings',35)
		else
			gs 'zz_render','','',func('gdkin_strings',36)
		end
	elseif DPgrup = 2:
		gs 'zz_render','','',func('gdkin_strings',37)
	else
		gs 'zz_render','','',func('gdkin_strings',38)
	end
	act 'Уйти с Витьком': numnpc = 9 & gt 'Snpc'
end
if $args[0] = 'gop_drink':
	*clr & cla
	$npc['<<numnpc>>,drink'] = day
	gs 'npc_editor','get_npc_profile',numnpc
	gs 'zz_render', '','','Распихивая танцующих на танцполе к вам протискивается <<$npc[''<<numnpc>>,surname'']>>:**\\\- Эй, <<$name[2]>>, давай подбухнем, а то ваще чёта стрёмно.///'
	gs 'gnpc_events','drink'
end
if $args[0] = 'kotov_dance':
	$npc['9,dance'] = day
	gs 'npc_editor','get_npc_profile',9
	gs 'zz_render', '','','Нагло распихивая людей на танцполе, к вам подруливает Витёк Котов:**\\\- Эй, <<$name[2]>>, слышь, давай потанцуем чё-ли?///'
	act 'Танцевать': gt 'kotovtalker','kotov_dance'
	if dom >= 10 and alko < 6: act 'Отказаться': $npc['9,relation'] -= 5 & gt $loc, $metka
end
if $args[0] = 'dima_dance':
	*clr & cla
	$npc['1,dance'] = day
	numnpc = 1
	gs 'npc_editor','get_npc_profile',1
	gs 'zz_render', '', '', 'На танцполе к вам подошёл Дима Носов:**\\\- <<$name[3]>>, может, потанцуем?///'
	act 'Танцевать': gt 'gnpc_events','krutishi_dance'
	if $npc['1,qwDimaRude'] = 0 and alko < 6 and dom > -25: act 'Отказаться': $npc['1,relation'] -= 5 & gt $loc, $metka
end
if $args[0] = 'igor_dance':
	*clr & cla
	$npc['4,dance'] = day
	numnpc = 4
	gs 'npc_editor','get_npc_profile',4
	gs 'zz_render', '', '', 'На танцполе к вам подошёл Игорь Круглов:**\\\- <<$name[3]>>, может, потанцуем?///'
	act 'Танцевать': gt 'gnpc_events','krutishi_dance'
	if $npc['1,qwDimaRude'] = 0 and alko < 6 and dom > -50: act 'Отказаться': $npc['4,relation'] -= 5 & gt $loc, $metka
end