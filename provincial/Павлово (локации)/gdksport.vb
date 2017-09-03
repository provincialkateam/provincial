if $args[0] = '' or $args[0] = 'main':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if current_clothing <= 2:
		gs 'zz_render','','','<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
		gs 'loker', 'start'
		exit
	end
	$_str = '<table border=0 cellpadding=0 cellspacing=1 width=600>'
	$_str += '<tr bgcolor=#f3f4ee><td width=40%><b>Секция</b></td><td align=center><b>Абонемент</b></td></tr>'
	$_str += '<tr bgcolor=#ffffff><td>Бег</td><td align=center>'+iif(gsAboBeg>0,'<<gsAboBeg>> посещений',iif(money>=2000,'<a href="exec:gt''gdksport'',''buy'',0">Купить (2000р.- 30 занятий)</a>','2000р.- 30 занятий'))+'</td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Танцы</td><td align=center>'+iif(gsAboDance>0,'<<gsAboDance>> посещений',iif(money>=3000,'<a href="exec:gt''gdksport'',''buy'',1">Купить (3000р.- 30 занятий)</a>','3000р.- 30 занятий'))+'</td></tr>'
	$_str += '<tr bgcolor=#ffffff><td>Волейбол</td><td align=center>'+iif(gsAboVolley>0,'<<gsAboVolley>> посещений',iif(money>=1500,'<a href="exec:gt''gdksport'',''buy'',2">Купить (1500р.- 30 занятий)</a>','1500р.- 30 занятий'))+'</td></tr></table></center>'
	gs 'zz_render','Дом культуры','pavlovo/dk/gdksport', func('gdksport_strings', 'local_str2') + $_str
	killvar '$_str'
	if $npc['9,qwKotovLove'] >= 5 and hour = 16:
		gs 'zz_render', '', '', func('gdksport_strings', 'local_str70')
	elseif $npc['3,relation'] >= 80 and (hour = 16 or hour = 17) and ivansportday ! day and week mod 2 ! 0:
		gs 'zz_render', '', '', func('gdksport_strings', 'local_str71')
	end
	if lariskaQwestStart <= daystart and week = 4 and $npc['13,relation'] >= 80 and lariskaHelp = 0 and $npc['18,qwZverevaSlut'] = 1:
		act 'Выйти': gt'LariskaStart','start'
	elseif lariskaQwestDay = daystart and AlbZverHelp ! 1 and lariskaHelp ! 0:
		act 'Выйти': gt'LariskaStart','end'
	else
		act 'Выйти': gt'gdk'
	end
	if ($npc['23,qwMain'] > 0 and $npc['23,qwMain'] < 50) or (gsAboDance + gsAboBeg + ivan_trainer_qw + gsAboVolley > 0):
		act 'Переодеться в раздевалке': gt 'loker','start'
		if hapri = 0 and $settings['hapri_mod'] = 1: act 'Посмотреться в зеркало':gt 'mirror','start'
		if sweat >= 0:
			act 'Помыться в душе':
				*clr & cla
				gs 'zz_bathroom', 'shower'
				horny += 1
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/ev/Shower.jpg'
				if IvanShowerYes = 1 and week mod 2 ! 0 and (hour = 16 or hour = 17):
					gs 'zz_render', '', '', func('gdksport_strings', 'local_str9')
					act 'Далее': gt 'gdksport','ShowerWithIvan'
				elseif $npc['3,qwKotovVsProhorov'] ! 1:
					gs 'zz_render', '', '', func('gdksport_strings', 'local_str10')
					if Voltrenersee >= 3 and sopr = 1: gt 'VoltrenerSexShower'
					gs 'zz_render', '', '', func('gdksport_strings', 'local_str11')
					act 'Выйти из душевой': gt $loc, $metka
				end
				if $npc['3,qwKotovVsProhorov'] = 1:
					$npc['3,qwKotovVsProhorov'] = 2
					gs 'zz_render', '', '', func('gdksport_strings', 'local_str12')
					act 'Выгнать Ивана':
						*clr & cla
						$npc['3,qwIvanShower'] = 1
						gs 'zz_render', '', 'images/qwest/alter/ev/Shower1.jpg', func('gdksport_strings', 'local_str13')
						act 'Выйти из душевой':gt $loc, $metka
					end
					act 'Эээ, что?':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/ev/Shower2.jpg', func('gdksport_strings', 'local_str14')
						act 'Сбежать из душевой':$npc['3,qwIvanShower'] = 1 & gt $loc, $metka
						act 'Мыться вместе':
							IvanShowerYes = 0
							gt 'gdksport','ShowerWithIvan'
						end
					end
					exit
				end
			end
		end
	end
	if hour >= 15 and hour < 20:
		if val($wardrobe[current_clothing+"_"+'group']) = 3:
			if sick >= 1:
				gs 'zz_render', '', '', func('gdksport_strings', 'local_str22')
				exit
			end
			! тренировка с Иваном, дни - пн, ср, пт, время начала - 18.00-18.20
			if ivan_trainer_qw = 1 and week mod 2 ! 0 and week < 6 and hour = 18 and minut < 20 and ivan_trainer_qw_day ! day:
				act 'Идти на тренировку к Ивану':
					*clr & cla
					minut += 60
					body['day_weight'] -= 1
					gs 'zz_funcs', 'sport', 5
					ivan_trainer_qw_day = day
					if week = 1:
						vital += iif(vital<60,1,rand(0,1))
						stren += iif(stren<60,1,rand(0,1))
						$_str = 'Сегодня был день изнурительных тренировок на силу и выносливость.'
						$_img = rand(10,14)
					end
					if week = 3:
						agil += iif(agil<60,1,rand(0,1))
						react += iif(react<60,1,rand(0,1))
						$_str = 'Сегодня был день более спокойных, но не менее важных тренировок на ловкость и реакцию.'
						$_img = rand(20,23)
					end
					if week = 5:
						jab += iif(jab<60,1,rand(0,1))
						punch += iif(punch<60,1,rand(0,1))
						kik += iif(kik<60,1,rand(0,1))
						kikdef += iif(kikdef<60,1,rand(0,1))
						$_str = 'Сегодня Иван обучал вас технике ударов.'
						$_img = rand(30,36)
					end
					gs 'zz_render','','images/qwest/alter/boxing/box'+$_img+'.jpg','На протяжении часа вы занимались под присмотром Ивана. <br>'+$_str
					killvar '$_img'
					killvar '$_str'
					gs 'stat'
					act 'Закончить': gt 'gdksport'
				end
			end
			if $npc['23,qwMain'] > 0 and $npc['23,qwMain'] < 50: gs 'albina_ev','stars_dancing'
			if gsAboDance > 0 and dancing_day ! day:
				act 'Секция танцев':
					*clr & cla
					dancing_day = day
					gsAboDance -= 1
					minut += 120
					body['day_weight'] -= 1
					if agil < 50: agil += RAND(1,3)
					if agil >= 50 and agil < 80: agil += RAND(0,2)
					if agil >= 80: agil += RAND(0,1)
					gs 'zz_funcs', 'sport', 3
					if dance < agil: dance += RAND(5,15)
					gs 'stat'
					gs 'zz_render','','images/pic/fit1.jpg'
					act 'Уйти': gt 'gdksport'
					if dance < 100:
						gs 'zz_render','','',func('gdksport_strings', 'local_str47') + func('gdksport_strings', 'local_str'+iif(dance < agil,48,49))
						!место для ивентов
						if RAND(0,1) = 1: gs 'zz_render', '', '', func('gdksport_strings', 'local_str50')
					else
						gs 'zz_render', '', '', func('gdksport_strings', 'local_str51')
						!место для ивентов
						if RAND(0,1) = 0: gs 'zz_render', '', '', func('gdksport_strings', 'local_str50')
						if $npc['23,qwMain'] = 0 and $npc['23,relation'] >= 40 and vnesh >= 20:
							cla
							act 'Дальше': gt 'albina_ev','stars_init'
						end
					end
				end
			end
			if gsAboBeg > 0 and running_day ! day:
				act 'Секция бега':
					*clr & cla
					gsAboBeg -= 1
					gs 'zz_common','crossing',1
					gs 'zz_render', '', 'images/pic/parkbeg.jpg', func('gdksport_strings', 'local_str61')
					act 'Уйти': gt 'gdksport'
				end
			end
			if gsAboVolley > 0 and volleysostav = 0 and volley_day ! day:
				act 'Секция волейбола':
					*clr & cla
					volley_day = day
					gsAboVolley -= 1
					minut += 120
					body['day_weight'] -= 1
					gs 'zz_funcs', 'sport', 3
					if week = 5:
						if alko <= 0:
							speed += RAND(1,2)
							agil += RAND(1,2)
							if stren < 40: stren += RAND(1,2)
							if vital < 40: vital += RAND(1,2)
							beg += RAND(1,2)
							volleyboll += 1
							dom += 1
						end
						gs 'zz_render', '', 'images/pavlovo/dk/volley/game5.jpg', func('gdksport_strings', 'local_str62')
						if alko <= 0:
							$_str[0] = 'Вы совершенно паршиво играете и постоянно ошибаетесь. Наконец нервы тренера не выдерживают и он удаляет вас с поля.'
							$_str[1] = 'Вы играете не очень. Иногда делаете грубые ошибки. Тренер злится, но терпит ваши выходки.'
							$_str[2] = 'Вы неплохо играете на поле и редко ошибаетесь. Тренер выглядит довольным вами.'
							$_str[3] = 'Вы великолепно играете на поле, легко переигрывая своих соперников. Тренер выглядит довольным вашей игрой.'
							gs 'zz_render','','',$_str[volleyboll/25]
							killvar '$_str'
						else
							gs 'zz_render','','',func('gdksport_strings', 'local_str63')
						end
					else
						if alko <= 0:
							volleyboll += 1
							speed += RAND(1,3)
							beg += RAND(1,2)
							if agil < 50: agil += RAND(1,3)
							if agil >= 50 and agil < 80: agil += RAND(0,2)
							if agil >= 80: agil += RAND(0,1)
							if stren < 10: stren += RAND(1,3)
							if stren >= 10 and stren < 20: stren += RAND(1,2)
							if stren >= 20 and stren < 30: stren += 1
							if stren >= 30 and stren < 40: stren += RAND(0,1)
							if vital < 10: vital += RAND(1,3)
							if vital >= 10 and vital < 20: vital += RAND(1,2)
							if vital >= 20 and vital < 30: vital += 1
							if vital >= 30 and vital < 40: vital += RAND(0,1)
						end
						gs 'zz_render', '', 'pavlovo/dk/gdksport.jpg', func('gdksport_strings', 'local_str'+iif(alko <= 0,68,69))
					end
					gs 'stat'
					act 'Уйти': gt 'gdksport'
					act 'Зайти в тренерскую': gt 'Voltrener'
				end
			end
			if volleysostav > 0:
				if week ! 6 and volkomday ! day:
					act 'Заниматься с командой':
						*clr & cla
						volkomday = day
						minut += 120
						speed += RAND(1,3)
						agil += RAND(1,3)
						if stren < 50:stren += RAND(1,3)
						if vital < 50:vital += RAND(1,3)
						body['day_weight'] -= 1
						gs 'zz_funcs', 'sport', 4
						beg += RAND(1,2)
						volleyboll += 1
						gs 'npc_editor','change_rep','+', 28
						dom += 1
						gs 'stat'
						gs 'zz_render', '', 'images/pavlovo/dk/volley/game.jpg', func('gdksport_strings', 'local_str64')
						act 'Уйти': gt'gdksport'
						act 'Зайти в тренерскую':gt'Voltrener'
						if tanga = 0 and volleytanga = 1:
							delact 'Зайти в тренерскую'
							act 'Поправить одежду':
								*clr & cla
								Voltrenersee += 1
								gs 'zz_render', '', 'images/pavlovo/dk/volley/game'+rand(1,2)+'.jpg','Похоже тренер заметил ваши манипуляции и вашу молодую письку, глаза его зажглись и он с трудом отворачиваясь произнес: "<<$surname>> зайдешь ко мне после тренировки. Мне нужно показать тебе ЭЭЭ ... пару приемов" '
								act 'Уйти': gt 'gdksport'
								act 'Подойти к двери тренерской':gt'Voltrenersex'
							end
						end
					end
				elseif week = 6 and sorevday ! day:
					act 'Выехать на соревнования с командой':
						cla
						*clr
						if poverkomand = 0: poverkomand = 600
						if LariskaProfi = 1 and lariskInTeam = 0:poverkomand = 800 & lariskInTeam = 1
						volltime = 0
						sorevday = day
						minut += 180
						speed += RAND(1,3)
						agil += RAND(1,3)
						if strn < 60: stren += RAND(1,3)
						if vital < 60: vital += RAND(1,3)
						body['day_weight'] -= 1
						gs 'zz_funcs', 'sport', 5
						beg += RAND(1,2)
						volleyboll += RAND(1,3)
						dom += 1
						gs 'npc_editor','change_rep','+', 28
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/dk/gdksport.jpg', func('gdksport_strings', 'local_str65')
						act 'Играть': gt'volley'
					end
				end
			end
		elseif val($wardrobe[current_clothing+"_"+'group']) = 3 and ($npc['23,qwMain'] + gsAboDance + gsAboBeg + gsAboVolley > 0):
			gs 'zz_render', '', '', func('gdksport_strings', 'local_str66')
		end
	else
		gs 'zz_render', '', '', func('gdksport_strings', 'local_str67')
	end
end
if $args[0] = 'buy':
	if args[1] = 0:
		money -= 2000
		gsAboBeg += 30
	elseif args[1] = 1:
		money -= 3000
		gsAboDance += 30
	else
		money -= 1500
		gsAboVolley += 30
	end
	gt 'gdksport'
end
if $args[0] = 'ShowerWithIvan':
	*clr & cla
	minut += 5
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/ev/Shower2.jpg', func('gdksport_strings', 'local_str15')
	act 'Намылить Ивана':
		*clr & cla
		minut += 5
		horny += 20
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev/shower3.jpg', func('gdksport_strings', 'local_str16')
		act 'Сделать минет':
			*clr & cla
			minut += 5
			horny += 20
			bj += 1
			if $npc['3,sex'] = 0: $npc['3,sex'] = 1 & guy += 1
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/ev/shower4.gif', func('gdksport_strings', 'local_str17')
			act 'Позволить ему продолжить':
				cla & *clr
				if throat<15:
					gs 'zz_render', '', 'images/qwest/alter/ev/shower6.gif', func('gdksport_strings', 'local_str18')
				else
					gs 'zz_render', '', 'images/qwest/alter/ev/shower7.gif', func('gdksport_strings', 'local_str19')
				end
				act 'Стоять раком':
					*clr & cla
					if IvanShowerYes = 0:$npc['3,qwIvanShower'] = 10
					minut += 5
					horny += 20
					$boy = 'Иван'
					dick = $npc['3,dick']
					lubonus = 2
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/ev/shower8.jpg', func('gdksport_strings', 'local_str20')
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					if ShowerIvan = 1 and rand(1,2) = 2 and $npc['28,sex'] = 0 and flag1 ! 1: gt 'VoltrenerSexShower'
					gs 'zz_render', '', 'images/qwest/alter/ev/shower9.gif', func('gdksport_strings', 'local_str21')
					act 'Выйти из душевой': gt $loc, $metka
				end
			end
		end
	end
end