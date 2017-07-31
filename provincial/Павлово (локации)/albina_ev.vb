! Альбина - стадии
! 0 - одноклассница
! 1 - Светка начинает танцевать в Звездушках
! 2 - 10 - танцы со Звездушками
! 10 - первое предложение поездки на подработку, в городке появляется агитация за Барловского
! ---
! 20 - Светка отказалась
! 21 - 25 - танцы со Звездушками
! 25 - второе предложение поездки на подработку, в случае отказа - выгоняем - 60
! 26 - Чернов предлагает сдать Альбину, согласие - 70, отказ - 50
! ---
! 30 - Светка согласилась
! 30 - 35 - танцы со Звездушками
! 35 - второе предложение поездки на подработку, в случае отказа - выгоняем - 60
! 36 - Чернов предлагает сдать Альбину, согласие - 70, отказ - 50
! ---
! 55 - после первого визита в дом Альбины
! 70 - Светка сдала Альбину - на следующий день ее потащат в полицию на глазах у Светки и счетчик тикнет на 80
! ---
! варианты конца ивентов:
! 50 - друзья - Светка не сдала Альбину
! 60 - нейтрал - Альбина выгнала Светку со Звездушек
! 80 - враги - Светка сдала Альбину
! ---
! переменные
! $npc['23,qwMain'] - стадия ивента
! $npc['23,sport_day'] - дата последнего совместного занятия спортом
! $npc['23,sex_day'] - дата последнего секса с ГГ
! $npc['23,arrest_day'] - дата ареста Альбины
! ---
if $args[0] = '' or $args[0] = 'main':
	$loc = $curloc
	if frost > 0: frost =0
	gs 'npc_editor','get_npc_profile',23
	if hour < 20:
		if $npc['23,sex'] = 0:
			xgt 'albina_ev','first_visit'
		else
			gs 'albina_ev',iif($npc['23,sport_day'] ! day,'training','home_actions')
		end
	else
		gs 'zz_render','','',func('albina_ev_strings','str23')
		act 'Идти на дискотеку': gt 'gdk'
	end
	act 'Попрощаться и идти домой': gt 'gorodok'
end
if $args[0] = 'first_visit':
	_zz_stage = args[1]
	if _zz_stage = 0:
		gs 'zz_render','','',func('albina_ev_strings','str1')
		act 'Выпить': gt 'albina_ev','first_visit',_zz_stage+1
		exit
	end
	$_str[0] = 'А как он отреагировал на то, что у тебя такой специфический бизнес?'
	$_str[1] = 'Ты так отзываешься о своем отце?'
	$_str[2] = 'И как же ты сейчас без бизнеса будешь?'
	$_str[3] = 'У меня все это в голове не укладывается'
	$_str[4] = 'Выпить'
	$_str[5] = 'Целоваться'
	$_str[6] = 'Целоваться'
	$_str[7] = 'Целоваться'
	$_str[8] = 'Дальше'
	$_str[9] = 'Попрощаться и идти домой'
	minut += 5
	if _zz_stage <= 6:
		gs 'zz_funcs','alko'
		$_zz_img = 'drunk'
	elseif _zz_stage >= 7 and _zz_stage <= 9:
		horny += rand(10,20)
		$_zz_img = 'kiss'+iif(_zz_stage = 7,'',_zz_stage - 6)
	else
		minut += rand(10,20)
		$npc['23,sex_day'] = day
		if $npc['23,sex'] = 0: $npc['23,sex'] = 1 & girl += 1
		lesbian += 1
		horny = 0
		orgasm += 1
		$_zz_img = 'lesb'
	end
	gs 'stat'
	gs 'zz_render','','pavlovo/albina/' + $_zz_img,func('albina_ev_strings','str'+(_zz_stage+1))
	act $_str[_zz_stage-1]:
		if _zz_stage < 10:
			gt 'albina_ev','first_visit',_zz_stage+1
		else
			$npc['23,qwMain'] = 55
			$npc['23,relation'] = 100
			killvar '$_zz_img'
			killvar '$_str'
			killvar '_zz_stage'
			gt 'gorodok'
		end
	end
end
if $args[0] = 'ride2home':
	gs 'npc_editor','get_npc_profile',23
	gs 'zz_render','','',func('albina_ev_strings','str27')
	act 'Ехать с Альбиной':
		*clr & cla
		minut += 10
		gs 'stat'
		gs 'zz_render','','',func('albina_ev_strings','str28')
		act 'Идти в комнату Альбины': gt 'albina_ev'
	end
end
if $args[0] = 'training':
	*clr & cla
	$npc['23,sport_day'] = day
	gs 'zz_render','','pavlovo/albina/train.jpg',func('albina_ev_strings','str14')
	act 'Стрипдэнс':
		*clr & cla
		minut += 120
		body['day_weight'] -= 1
		agil += RAND(1,3)
		gs 'zz_funcs', 'sport', 4
		gs 'stat'
		gs 'zz_render','','images/pic/stripdance.jpg'
		if dance >= 100:
			stripdance += RAND(2,10)
			gs 'zz_render','','',func('albina_ev_strings','str15')
			if stripdance >= 100: gs 'zz_render','','',func('albina_ev_strings','str24')
		else
			dance += RAND(5,15)
			gs 'zz_render','','',func('albina_ev_strings','str16')
		end
		act 'Передохнуть': gt $curloc
	end
	act 'Танцы на шесте':
		*clr & cla
		minut += 120
		body['day_weight'] -= 1
		stren += RAND(1,3)
		vital += RAND(1,3)
		gs 'zz_funcs', 'sport', 5
		gs 'stat'
		gs 'zz_render','','images/pic/poledance.jpg'
		if dance >= 100 and stripdance >= 100 and stren >= 80:
			if poledance >= 100:
				gs 'zz_render','','',func('albina_ev_strings','str24')
			else
				poledance += RAND(2,5)
				gs 'zz_render','','',func('albina_ev_strings', 'str17')
			end
		else
			gs 'zz_render', '', '', func('albina_ev_strings', 'str18')
			if stren < 80: gs 'zz_render','','',func('albina_ev_strings','str24')
		end
		act 'Передохнуть': gt $curloc
	end
	if stren < 80:
		gs 'zz_render', '', '', func('albina_ev_strings','str19')
		act 'Развивать силу':
			*clr & cla
			minut += 120
			stren += RAND(2,5)
			gs 'zz_funcs', 'sport', 5
			gs 'stat'
			gs 'zz_render','','pavlovo/albina/stren.jpg',func('albina_ev_strings','str20')
			act 'Передохнуть': gt $curloc
		end
	end
	act 'Да ну, неохота': gt $curloc
end
if $args[0] = 'home_actions':
	i = RAND(0,3)
	if i = 0:
		gs 'zz_render','','',func('albina_ev_strings','str29')
		gs 'albina_ev','play_game'
	elseif i = 1:
		gs 'zz_render','','',func('albina_ev_strings','str30')
		gs 'albina_ev','dressing'
	elseif i = 2:
		gs 'zz_render','','',func('albina_ev_strings','str31')
		gs 'albina_ev','talking'
	else
		gs 'zz_render','','',func('albina_ev_strings','str32')
		gs 'albina_ev','drinking'
	end
end
if $args[0] = 'play_game':
	act 'Играть':
		*clr & cla
		minut += 60
		manna += 10
		react += RAND(0,1)
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/albina/game.jpg', func('albina_ev_strings','str33')
		if $npc['23,sex_day'] ! day:
			$npc['23,sex_day'] = day
			gs 'zz_render','','',func('albina_ev_strings', 'str34')
			act 'Ну уж нет': gt $curloc
			act 'Давай':
				*clr & cla
				gs 'zz_render','','pavlovo/albina/game.jpg'
				if RAND(0,100) > react:
					gs 'zz_render','','',func('albina_ev_strings', 'str35')
					gs 'albina_ev',iif(RAND(0,1)=0,'vag_strapon','anal_strapon')
				else
					gs 'zz_render','','',func('albina_ev_strings', 'str36')
					gs 'albina_ev','albina_vag'
					gs 'albina_ev','albina_anal'
				end
			end
		else
			act 'Передохнуть': gt $curloc
		end
	end
end
if $args[0] = 'dressing':
	act 'Примерять наряды':
		*clr & cla
		minut += 60
		manna += 10
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/dressing.jpg',func('albina_ev_strings','str37')
		act 'Передохнуть': gt $curloc
	end
end
if $args[0] = 'talking':
	act 'Болтать':
		*clr & cla
		minut += 60
		manna += 10
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/drunk.jpg'
		act 'Передохнуть': gt $curloc
	end
end
if $args[0] = 'drinking':
	act 'Пить вино':
		*clr & cla
		gs 'zz_funcs', 'alko', 4
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/drunk.jpg'
		act 'Передохнуть': gt $curloc
	end
end
if $args[0] = 'vag_strapon':
	act 'Встать раком':
		*clr & cla
		minut += 15
		$boy = 'Альбина'
		dick = iif(vagina < 10,10,15)
		lesbian += 1
		protect = 1
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/strapon.jpg',func('albina_ev_strings','str38')
		gs 'zz_dynamic_sex','sex_start', 1
		gs 'zz_dynamic_sex','vaginal','strapon'
		act 'Передохнуть': gt $curloc
	end
end
if $args[0] = 'anal_strapon':
	act 'Встать раком':
		*clr & cla
		minut += 15
		$boy = 'Альбина'
		dick = iif(anus < 10,10,15)
		lesbian += 1
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/analstrapon.jpg',func('albina_ev_strings','str39')
		gs 'zz_dynamic_sex','anal_start','strapon'
		gs 'zz_dynamic_sex','anal','strapon'
		act 'Передохнуть': gt $curloc
	end
end
if $args[0] = 'albina_vag':
	act 'Поставить Альбину раком и трахнуть в киску страпоном':
		*clr & cla
		minut += 15
		lesbian += 1
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/straponakt.jpg',func('albina_ev_strings','str40')
		act 'Передохнуть': gt $curloc
	end
end
if $args[0] = 'albina_anal':
	act 'Поставить Альбину раком и трахнуть в зад страпоном':
		*clr & cla
		minut += 15
		lesbian += 1
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/straponaktanal.jpg', func('albina_ev_strings','str41')
		act 'Передохнуть': gt $curloc
	end
end
! --- Ивенты Звездушек --- !
if $args[0] = 'stars_init':
	*clr
	gs 'zz_render','','pavlovo/albina/zvezdy/dance0.gif',func('albina_ev_strings','str42')
	act 'Поздороваться с Альбиной':
		*clr & cla
		gs 'npc_editor','get_npc_profile',23
		gs 'zz_render','','',func('albina_ev_strings','str43')
		act 'Да мне плевать':
			*clr & cla
			dom += 1
			gs 'npc_editor','change_rep','-',23,5
			gs 'npc_editor','get_npc_profile',23
			gs 'zz_render','','',func('albina_ev_strings','str44')
			act 'Уйти': gt 'gdksport'
		end
		act 'Я умею танцевать':
			*clr & cla
			gs 'zz_render','','pavlovo/albina/zvezdy/dance1.gif',func('albina_ev_strings','str45')
			act 'Уйти': gt 'gdksport'
			act 'Смотреть':
				*clr & cla
				minut += 15
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/albina/zvezdy/dance2.gif',func('albina_ev_strings','str46')
				act 'Уйти': gt 'gdksport'
				act 'Попроситься к ним в коллектив':
					*clr & cla
					gs 'npc_editor','get_npc_profile',23
					gs 'zz_render','','',func('albina_ev_strings','str47')
					act 'Танцевать':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/albina/zvezdy/dance3.gif',func('albina_ev_strings','str48')
						act 'Ну как возьмете меня в свой коллектив?':
							*clr & cla
							$npc['23,qwMain'] = 1
							gs 'npc_editor','get_npc_profile',23
							gs 'zz_render','','',func('albina_ev_strings','str49')
							act 'Уйти': gt 'gdksport'
						end
					end
				end
			end
		end
	end
end
if $args[0] = 'stars_dancing':
	act 'Тренироваться со Звездушками':
		*clr & cla
		minut += 120
		body['day_weight'] -= 1
		agil += iif(agil<50,1,rand(0,1))
		gs 'zz_funcs', 'sport', 5
		dancePRO += RAND(1,3)
		if dancePRO >= 100: dancePRO = 99
		gs 'stat'
		gs 'zz_render','','pavlovo/albina/zvezdy/dance'+rand(4,7)+'.gif',func('albina_ev_strings','str'+(50+dancePRO/20))
		if dancePRO < 80:
			if dancePRO < 40: dom -= 1
		else
			cla
			! ограничения на прирост: 26 или 36 - появляется Чернов с предложением сдать Альбину
			if $npc['23,qwMain'] ! 26 and $npc['23,qwMain'] ! 36: $npc['23,qwMain'] += 1
			if $npc['23,qwMain'] = 10 or $npc['23,qwMain'] = 25 or $npc['23,qwMain'] = 35:
				gs 'zz_render','','',func('albina_ev_strings','str55')
				act 'Ехать на подработку':
					*clr & cla
					mop = 1
					gs 'zz_funcs', 'sport', 3
					sweat = 0
					money += 2000
					minut += rand(90,150)
					profiDanceTime += 1
					gs 'stat'
					gs 'zz_render','','',func('albina_ev_strings','str56')
					! первое предложение подзаработать
					i = rand(1,8)
					gs 'zz_render','','',func('albina_ev_strings','str57') + func('albina_ev_strings','str'+iif(i=1 or i=3 or i=6,58,59))
					act 'Отказаться':
						*clr & cla
						minut += 15
						act 'Ехать обратно': gt 'gorodok'
						if $npc['23,qwMain'] = 25 or $npc['23,qwMain'] = 35:
							! выгоняем
							$npc['23,qwMain'] = 60
							$npc['23,relation'] -= 10
							gs 'zz_render','','',func('albina_ev_strings','str60')
						else
							! первое и последнее предупреждение
							$npc['23,qwMain'] = 20
							gs 'zz_render','','',func('albina_ev_strings','str61')
						end
					end
					act 'Согласиться':
						*clr & cla
						if $npc['23,qwMain'] = 10: $npc['23,qwMain'] = 30
						money += i * 3000
						slutty += 1
						gs 'zz_render','','',func('albina_ev_strings','str62')
						act 'Идти с '+iif(i=1 or i=3 or i=6,'парнем','парнями'): gt 'DanceWhore', i
					end
				end
			end
		end
		act 'Уйти': gt 'gdksport'
	end
end
if $args[0] = 'stars_end':
	*clr & cla
	$npc['23,qwMain'] = 80
	$npc['23,group'] = 0
	gs 'zz_render','','',func('albina_ev_strings','str63')
	act 'Уйти': gt 'gorodok'
end