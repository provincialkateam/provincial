! katya shedule
! 0.00-6.30 - her room, sleep
! 6.30-7.00 - bath
! 7.00-8.00 - her room
! 8.00-8.30 - kitchen
! 8.30-9.00 - way to school
! 9.00-15.00 - school
! 15.00-20.00 - her room
! 20.00-23.00 - DK
! 23.00-24.00 - her room, read
! weekend
! 8.30-11.00 - hall, tv
! 11.00-16.00 - courtyard/terrace or her room
! ---
! переменные ивентов Кати:
! $npc['14,qwKatya'] - стадия ветки
! $npc['14,qwKatya_day'] - день ивента, раз в день
! $npc['14,bath_event_day'] - флаг рандомного ивента в душе, раз в день
! $npc['14,talk_about_sex_day'] - флаг разговора о сексе, раз в день
! $npc['14,qwKatya_trio_day'] - день тройничка с Катей
! $npc['14,hub_talk_day'] - день серьезного разговора с Катей
! $npc['14,homeward'] - проверка местожительства Кати после завершения ветки: 0 - в сити, 1 - в городке
!---
! ветка Кати, стадии
! 0 - ветка не начата
! 1 - Катя уводит Свету с дискотеки, начало ветки
! 2,4,6 - Катя повторно уводит Свету с дискотеки, на этот раз к себе домой
! 3,5,7 - Светка трогает Катю
! 10 - устанавливаем после третьего лапания и разоблачения Кати, открываются уроки с Катей, при следующем визите в дом - запускается знакоство с ТМ
! 15 - после первого чаепития с ТМ
! 20 - поcле второго чаепития
! 20-24 - болтаем с Катей о сексе
! 25 - прогулка с поцелуями в парке
! 30 - прогулка с поцелуями в парке закончена, в душ ГГ пошла одна - закрываем продолжения, пока не пойдут вместе
! 35 - прогулка с поцелуями в парке закончена, в душ ГГ пошла с Катей
! 40 - после первого секса в комнате Кати
! 41-43 - полизушки в комнате Кати
! 43 - можно сломать Кате целку, иначе дальше не двигаем
! 45 - шалости со страпоном, Катя теряет целку
! 46-50 - шалости со страпоном
! 50 - болтаем о сексе с парнем
! 55 - наблюдаем за Катей на дискотеке
! 57 - денег на номер в отеле нет, никуда не идем
! 60 - наблюдаем за Катей в отеле
! 65 - Катя ходит в школу без трусиков, что и показывает на перемене ГГ
! 70 - Катя мастурбирует на уроке, открывает секс с незнакомцем в парке
! 71 - после секса с незнакомцем в парке, открывает диалог об трио
! 72 - договорились о трио с Катей
! 75 - после трио в парке или отеле
! 80,81,82 - Катя ушла в отель, убираем ее с дискотеки
! 90 - серьезный разговор Кати и ГГ
! 95 - Катя обещает подумать о словах ГГ
! 100 - Катя отказывается послушать ГГ, дальше - скат по наклонной
! 200 - Катя уезжает в город, появляется только по выходным дома и на дискотеке
! ---------------
! random bath event
if $args[0] = 'bath_event':
	zz_stage = args[1]
	if zz_stage < 1:
		cla
		$npc['14,bath_event_day'] = day
		gs 'zz_render','','',func('mey_katya_strings',0)
		act 'Пройти мимо': gs 'mey_katya_events','bath_event', 5
		act 'Подглядеть': gs 'mey_katya_events','bath_event', zz_stage+1
	else
		if zz_stage <= 4:
			*clr & cla
			horny += rand(1,8)
			minut += rand(1,3)
			gs 'stat'
			gs 'zz_render','','pavlovo/meynolds/katya/bath/'+zz_stage,func('mey_katya_strings',zz_stage)
			act '...': gs 'mey_katya_events', 'bath_event', zz_stage+1
		else
			killvar 'zz_stage'
			gt 'mey_home',0
		end
	end
end
! сплетни об одноклассниках для болтовни Кати и Светки
if $args[0] = 'gossip':
	$_str[0] = 'А ты в курсе, что Иванько подрабатывает проституцией? Прикинь, ее видели в гостинице с какими-то мужиками!'
	$_str[1] = 'А ты слышала, что наш Царек хорошо дерется? Пацаны хотели ему темную устроить, так он их как котят..'
	$_str[2] = 'Ой, я тут такое узнала - ты ща офигеешь! Оказывается, "Звездушки" на выездах подрабатывают - ну ты понимаешь, чем! Не "Звездушки, а "Потрахушки", ха-ха!'
	$_str[3] = 'В школе тут судачат, что скоро форму школьную отменят и вообще можно будет ходить как хочешь. Лерка Царева, небось, в одних трусах припрется!'
	$_str[4] = 'Ты не поверишь - что я узнала! Кто-то в спортзале в раздевалке нашей дырочку провертел. Прикинь, мы раздеваемся, а мальчишки подсматривают...'
	$_str[5] = 'Говорят, что кто-от у нас в школе наркотой торгует. Интересно, кто?'
	$_str[6] = 'Не, ну ты слушай! Директор-то наш, Зольский, кобель! Себаготуллина набедокурила, так он ей предложил... ты не поверишь!'
	$_str[7] = 'Слышала я, что если надо справку о девственности, то можно с гинекологом договориться в поликлинике. Можно за деньги, а можно так...'
	$_str[8] = 'По секрету только тебе: я тут услышала, что у нас в классе не осталось ни одноц двеушки, прикинь!Интересно, а как...'
	$_str[9] = 'А знаешь, что в Сити есть сексшоп? Вот бы туда попасть!'
	gs 'zz_render','','','\\\- '+$_str[rand(0,arrsize('$_str')-1)]+'///'
	killvar '$_str'
	act 'Дальше': gt 'mey_katya_events','hometalk'
end
! drunk_qw
if $args[0] = 'drunk_meet':
	*clr & cla
	gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/drunk',func('mey_katya_strings',5)
	act '...':
		*clr & cla
		gs 'zz_render','','pavlovo/meynolds/katya/common/katya',func('mey_katya_strings',6)
		act 'Остаться':
			*clr & cla
			$npc['14,qwKatya_day'] = day
			gs 'npc_editor','change_rep','down',14
			gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/drunk',func('mey_katya_strings',7)
			act 'Отойти': gt $loc,$metka
		end
		act 'Идти с Катей':
			*clr & cla
			if $npc['14,qwKatya'] < 10: $npc['14,qwKatya'] += 1
			gs 'npc_editor','change_rep','up',14
			gs 'zz_render','','pavlovo/meynolds/katya/common/katya',func('mey_katya_strings',8)
			act 'Идти':
				*clr & cla
				minut += rand(10,20)
				gs 'stat'
				if $npc['14,qwKatya'] > 1:
					gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/drunk_sit',func('mey_katya_strings',iif($npc['0,meynold_key'] = 1,11,10)) + func('mey_katya_strings',12)
					act 'В дом':
						*clr & cla
						gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/drunk_sleep',func('mey_katya_strings',13)
						act 'Спать': gt $curloc,'sleep_together'
					end
				else
					gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/drunk_walk',func('mey_katya_strings',9)
					act 'Спать': $loc = 'bedrPar' & gt 'bed','sleep'
				end
			end
		end
	end
end
if $args[0] = 'sleep_together':
	*clr & cla
	! ставим принудительно место сна
	$loc = 'mey_home'
	$metka = '5'
	! --
	gs 'zz_render','фото спящих рядом девиц','pavlovo/meynolds/katya/drunk_qw/drunk_sleep1',func('mey_katya_strings',14)
	if (lesbian > 0 or shameless['flag'] > 0) and $npc['14,qwKatya'] < 10:
		act 'Дать волю рукам':
			*clr & cla
			$npc['14,qwKatya'] += 1
			!---
			! 3	- трогает первый раз - только начало
			! 5 - трогает второй раз - если полезть дальше - получаем по рукам, -10 отношения
			! 7 - третий раз - Катька не спит, разоблачение
			!---
			gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/sleep_touch0.gif',func('mey_katya_strings',15)
			act 'Продолжить':
				*clr & cla
				horny += rand(10,20)
				minut += rand(2,5)
				gs 'stat'
				gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/sleep_touch1.gif',func('mey_katya_strings',iif($npc['14,qwKatya'] >= 5,17,16))
				act 'Оставить эту затею':
					cla
					gs 'zz_render','','',func('mey_katya_strings',18)
					act 'Спать': gt 'bed','sleep'
				end
				if $npc['14,qwKatya'] >= 5:
					act 'Ласкать дальше':
						*clr & cla
						gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/'+iif($npc['14,qwKatya'] = 5,'sleep_touch2.gif','lesb2.jpg'),func('mey_katya_strings',19)
						if $npc['14,qwKatya'] = 5:
							gs 'zz_render','','',func('mey_katya_strings',20)
							gs 'npc_editor','change_rep','down',14,10
							act 'Спать в гостевой':
								$metka = '3'
								gt 'bed','sleep'
							end
						else
							! Катька не спит - разоблачение
							gs 'zz_render','','',func('mey_katya_strings',21) + func('mey_katya_strings',22)
							act 'Продолжить':
								*clr & cla
								gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/lesb4',func('mey_katya_strings',23)
								act '...':
									*clr & cla
									gs 'zz_render','','pavlovo/meynolds/katya/drunk_qw/lesb6',func('mey_katya_strings',24)
									$npc['14,sex'] = 1
									$npc['14,qwKatya'] = 10
									act 'Спать': gt 'bed','sleep'
								end
							end
						end
					end
				end
			end
		end
	end
	act 'Спать':
		if $npc['14,qwKatya'] < 10: $npc['14,qwKatya'] -= 1
		gt 'bed','sleep'
	end
end
! идут учить уроки к Кате
if $args[0] = 'goto_home':
	*clr & cla
	gs 'zz_render','',func('zz_funcs','mk_image','pavlovo/meynolds/katya/common/go_home'),func('mey_katya_strings',25)
	minut += rand(10,20)
	gs 'stat'
	act 'В дом':
		! переводим стадию, если ГГ уже знакома с ТМ
		if $npc['45,qwTamara'] > 1 and $npc['14,qwKatya'] < 20: $npc['14,qwKatya'] = 20
		if $npc['14,qwKatya'] = 10 and $npc['45,qwTamara'] = 0:
			gt 'mey_tamara_events','first_meet','katya'
		else
			gt 'mey_katya_events','homework'
		end
	end
end
if $args[0] = 'homework':
	*clr & cla
	minut += 30 + (100 - intel)/2
	school['homework'] = 0
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/common/learn',func('mey_katya_strings',27)
	if ($npc['14,qwKatya'] = 25 or $npc['14,qwKatya'] = 30) and $npc['14,qwKatya_day'] ! day:
		gs 'zz_render','','',func('mey_katya_strings',38)
		act 'Идти в парк': gt 'mey_katya_events','park_walk'
	else
		act 'Отойти':gt 'mey_home',5
	end
end
! Светка уходит: в городок или в холл дома, зависит от знакомства с ТМ
if $args[0] = 'go_out':
	cla
	act iif(args[1] = 1,'Отойти','Уйти'):
		! если ключ не получен или не знакома с ТМ - выход только на улицу
		if $npc['0,meynold_key'] = 0:
			minut += rand(5,10)
			gt 'gorodok'
		else
			minut += 1
			gt 'mey_home',iif(args[1] = 1,5,10)
		end
	end
end
! болтовня
if $args[0] = 'hometalk':
	*clr & cla
	gs 'npc_editor','get_npc_profile',14
	act 'Отойти':gt 'mey_home',5
	if hour >= 21: exit
	act 'Поболтать':
		*clr & cla
		if hour = 20:
			gs 'npc_editor','get_npc_profile',14
			gs 'zz_render','','',func('mey_katya_strings',28)
			minut += rand(10,15)
			act 'Идти домой': gt 'gorodok'
			act 'Идти на дискотеку': gt 'gdk'
			exit
		else
			act 'Далее': gt 'mey_katya_events','hometalk'
			if school['homework'] > 0 and week <= 5 and hour >= 15:
				minut += 1
				gs 'stat'
				gs 'zz_render','','pavlovo/meynolds/katya/common/talk_no',func('mey_katya_strings',29)
				act 'Делать уроки': gt 'mey_katya_events','homework'
			else
				cla
				minut += rand(5,10)
				gs 'stat'
				gs 'npc_editor','change_rep','+',14,1
				gs 'zz_render','','pavlovo/meynolds/katya/common/talk',func('mey_katya_strings',30)
				gs 'mey_katya_events',iif((mastr + bj + sex + anal) > 0 and rand(0,2) = 0 and $npc['14,talk_about_sex_day'] ! day,'talk_about_sex','gossip')
			end
		end
	end
	if $npc['14,qwKatya_day'] ! day:
		if $npc['14,qwKatya'] = 70: act 'Предложить погулять в парке': gt 'mey_katya_events','park_sex_prepeare'
		if $npc['14,qwKatya'] >= 35 and horny >= 60 and mesec = 0: act 'Пошалить': gt 'mey_katya_events','room_sex'
	end
end
! разговоры на сексуальную тематику
if $args[0] = 'talk_about_sex':
	cla
	gs 'zz_render','','',func('mey_katya_strings',31)
	act 'Отказаться разговаривать на такие темы':
		*clr & cla
		gs 'zz_render','','',func('mey_katya_strings',32)
		act 'Дальше': gt 'mey_katya_events','hometalk'
	end
	! для продолжения ветки нужна развратность
	if shameless['flag'] = 0: exit
	! ---
	if mastr > 0: _arr[0] = 1
	if bj > 0: _arr[1] = 1
	if sex > 0: _arr[2] = 1
	if anal > 0: _arr[3] = 1
	if SelfFisting > 0: _arr[4] = 1
	$_arr[0] = 'мастурбировали'
	$_arr[1] = 'делали минет'
	$_arr[2] = 'занимались сексом'
	$_arr[3] = 'давали в попу'
	$_arr[4] = 'засунули себе кулак в попу'
	:loop_talk
	_j = rand(0,4)
	if _arr[_j] = 1:
		act 'Рассказать как вы '+$_arr[_j]:
			*clr & cla
			$npc['14,talk_about_sex_day'] = day
			if $npc['14,qwKatya'] >= 20 and $npc['14,qwKatya'] < 25: $npc['14,qwKatya'] += 1
			gs 'zz_render','','pavlovo/meynolds/katya/sextalk/'+_j,func('mey_katya_strings',33+_j)
			act 'Дальше': gt 'mey_katya_events','hometalk'
		end
		killvar '$_arr'
		exit
	else
		jump 'loop_talk'
	end
end
! прогулка в парке
if $args[0] = 'park_walk':
	*clr & cla
	_stage = args[1]
	minut += rand(5,10)
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/park_walk/<<_stage>>',func('mey_katya_strings',39+_stage)
	act iif(_stage < 2,'...','Идти домой'):
		if _stage < 2:
			gt 'mey_katya_events','park_walk',_stage+1
		else
			killvar '_stage'
			minut += rand(15,30)
			$npc['14,qwKatya'] = 30
			gt 'mey_katya_events','bath_sex'
		end
	end
end
! секс в ванной
if $args[0] = 'bath_sex':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/bath_sex/<<_stage>>'+iif(_stage=1 or _stage=3 or _stage=7,'.gif','.jpg'),func('mey_katya_strings',43+_stage)
	if _stage = 0:
		act 'Согласиться':
			*clr & cla
			killvar '_stage'
			minut += rand(1,5)
			gs 'zz_render','','pavlovo/meynolds/vika/bath/0',func('mey_katya_strings',51)
			act 'Закончить': gt 'mey_home',5
		end
		act 'Давай вместе': gt 'mey_katya_events','bath_sex',_stage+1
	else
		act iif(_stage < 7,'...','Закончить'):
			if _stage < 7:
				gt 'mey_katya_events','bath_sex',_stage+1
			else
				killvar '_stage'
				$npc['14,qwKatya_day'] = day
				$npc['14,qwKatya'] = 35
				minut += rand(1,5)
				gt 'mey_home',5
			end
		end
	end
end
! шалости в комнате Кати
if $args[0] = 'room_sex':
	*clr & cla
	$npc['14,qwKatya_day'] = day
	gs 'zz_render','','pavlovo/meynolds/katya/room_sex/0',func('mey_katya_strings',52)
	act '...':
		*clr & cla
		minut += rand(2,5)
		horny += rand(10,20)
		gs 'stat'
		gs 'zz_render','','pavlovo/meynolds/katya/room_sex/1',func('mey_katya_strings',53)
		act '...':
			*clr & cla
			minut += rand(2,5)
			horny += rand(10,20)
			gs 'stat'
			gs 'zz_render','','pavlovo/meynolds/katya/room_sex/2',func('mey_katya_strings',54)
			if $npc['14,qwKatya'] >= 43:
				act 'Лизать':
					*clr & cla
					gs 'zz_render','','pavlovo/meynolds/katya/room_sex/3.gif',func('mey_katya_strings',55)
					act 'Еще':
						*clr & cla
						! Катя теряет девственность
						if $npc['14,qwKatya'] = 43:
							$npc['14,qwKatya'] = 45
						else
							if $npc['14,qwKatya'] < 50: $npc['14,qwKatya'] += 1
						end
						gs 'zz_render','','pavlovo/meynolds/katya/room_sex/7',func('mey_katya_strings',iif($npc['14,qwKatya'] = 45,59,65))
						act 'Заняться Катей':
							*clr & cla
							gs 'zz_render','','pavlovo/meynolds/katya/room_sex/8',func('mey_katya_strings',iif($npc['14,qwKatya'] = 45,60,66))
							act 'Давай':
								*clr & cla
								gs 'zz_render','','pavlovo/meynolds/katya/room_sex/9',func('mey_katya_strings',iif($npc['14,qwKatya'] = 45,61,67))
								act '...':
									*clr & cla
									gs 'zz_render','','pavlovo/meynolds/katya/room_sex/10',func('mey_katya_strings',62)
									act 'А как же я?':
										*clr & cla
										horny = 0
										orgasm += 1
										minut += rand(10,15)
										manna += rand(10,20)
										gs 'stat'
										gs 'zz_render','','pavlovo/meynolds/katya/room_sex/5',func('mey_katya_strings',63)+func('mey_katya_strings',iif($npc['14,qwKatya'] = 45,64,68))
										if $npc['14,qwKatya'] = 50:
											act 'Поговорить о сексе с парнем': gt 'mey_katya_events','talk_about_boy'
										else
											act 'Закончить': gt 'mey_home',5
										end
									end
								end
							end
						end
					end
				end
			end
			act 'Попросить полизать':
				*clr & cla
				gs 'zz_render','','pavlovo/meynolds/katya/room_sex/4.gif',func('mey_katya_strings',56)
				act 'Кончить':
					*clr & cla
					horny = 0
					orgasm += 1
					manna += rand(10,20)
					minut += rand(3,7)
					if $npc['14,qwKatya'] < 40:
						$npc['14,qwKatya'] = 40
					else
						if $npc['14,qwKatya'] < 43: $npc['14,qwKatya'] += 1
					end
					gs 'stat'
					gs 'zz_render','','pavlovo/meynolds/katya/room_sex/5',func('mey_katya_strings',57)
					act 'Поменяться местами':
						*clr & cla
						gs 'zz_render','','pavlovo/meynolds/katya/room_sex/6',func('mey_katya_strings',58)
						if $npc['14,qwKatya'] = 50:
							act 'Поговорить о сексе с парнем': gt 'mey_katya_events','talk_about_boy'
						else
							act 'Закончить': gt 'mey_home',5
						end
					end
				end
			end
		end
	end
end
! разговор о сексе с парнем
if $args[0] = 'talk_about_boy':
	*clr & cla
	$npc['14,qwKatya'] = 55
	gs 'zz_render','','',func('mey_katya_strings',69)
	act 'Отойти': gt 'mey_home',5
end
! наблюдаем за Катей на дискотеке
if $args[0] = 'disco_observing':
	*clr & cla
	minut += rand(10,15)
	gs 'stat'
	if rand(1,20) mod 7 > 0:
		gs 'zz_render','','',func('mey_katya_strings',70)
		act 'Отойти': gt 'gdkin'
	else
		gs 'zz_render','','',func('mey_katya_strings',71)
		$npc['14,qwKatya'] = 60
		act 'Идти за ними':
			*clr & cla
			minut += rand(10,15)
			! идем в отель
			if $npc['0,hotelwork'] = 1 or $npc['0,hotelwork'] = 3:
				! гг работает в отеле
				gs 'zz_render','','',func('mey_katya_strings',73)
			else
				! снимаем номер, если есть деньги
				gs 'zz_render','','',func('mey_katya_strings',74)
				if money >= 500:
					money -= 500
					gs 'stat'
				else
					gs 'zz_render','','',func('mey_katya_strings',72)
					act 'Уйти': gt 'gorodok'
					exit
				end
			end
			gs 'zz_render','','',func('mey_katya_strings',75)
			act 'Подглядывать': gt 'mey_katya_events','hotel_observing'
		end
	end
end
! подглядываем за Катей и парнем в отеле
if $args[0] = 'hotel_observing':
	*clr & cla
	_stage = args[1]
	gs 'zz_render','','pavlovo/meynolds/katya/hotel_sex/<<_stage>>',func('mey_katya_strings',76+_stage)
	act iif(_stage < 9,'...','Уйти'):
		if _stage < 9:
			gt 'mey_katya_events','hotel_observing',_stage+1
		else
			$npc['14,qwKatya_day'] = day
			minut += rand(50,70)
			gt 'gorodok'
		end
	end
end
! случай на перемене в школе
if $args[0] = 'school_no_panty':
	*clr & cla
	gs 'zz_render','','pavlovo/meynolds/katya/school/0',func('mey_katya_strings',86)
	act 'Идти с Катей':
		*clr & cla
		minut += rand(1,3)
		$npc['14,qwKatya'] = 65
		$npc['14,qwKatya_day'] = day
		gs 'stat'
		gs 'zz_render','','pavlovo/meynolds/katya/school/1',func('mey_katya_strings',87)
		if tanga = 1:
			gs 'zz_render','','',func('mey_katya_strings',88)
			act 'Назад': gt 'zz_school'
		else
			act 'И я!':
				*clr & cla
				act 'Назад': gt 'zz_school'
				gs 'zz_render','','pavlovo/meynolds/katya/school/2',func('mey_katya_strings',89)
			end
		end
	end
end
! мастурбация на уроке
if $args[0] = 'school_selfplay':
	$npc['14,qwKatya'] = 70
	$npc['14,qwKatya_day'] = day
	gs 'zz_render','','pavlovo/meynolds/katya/school/3',func('mey_katya_strings',90)
end
! cекс с незнакомцем в парке
if $args[0] = 'park_sex_prepeare':
	*clr & cla
	minut += rand(15,30)
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/park_sex/prepeare',func('mey_katya_strings',91)
	act 'Идти за Катей': gt 'mey_katya_events','park_sex'
end
if $args[0] = 'park_sex':
	*clr & cla
	_stage = args[1]
	minut += rand(3,5)
	if _stage > 0 and _stage < 6: horny += rand(3,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/park_sex/<<_stage>>',func('mey_katya_strings',92+_stage)
	act iif(_stage < 7,'...','Уйти'):
		if _stage < 7:
			gt 'mey_katya_events','park_sex',_stage+1
		else
			$npc['14,qwKatya'] = 71
			$npc['14,qwKatya_day'] = day
			killvar '_stage'
			gt 'zz_park'
		end
	end
end
! рандомный секс в отеле
if $args[0] = 'random_hotel_sex':
	*clr & cla
	if $npc['14,qwKatya'] < 80:
		$npc['14,qwKatya'] = 80
	else
		$npc['14,qwKatya'] += 1
	end
	$npc['14,qwKatya_day'] = day
	gs 'zz_render','Нужна картинка','',func('mey_katya_strings',100)
	if $npc['0,hotelwork'] = 1 or $npc['0,hotelwork'] = 3:
		act 'Проследить':
			minut += rand(40,60)
			gs 'stat'
			gs 'zz_render','','pavlovo/meynolds/katya/hotel_sex/10',func('mey_katya_strings',101)
			act 'Уйти': minut += rand(10,15) & gt 'gorodok'
		end
	else
		act 'Отойти':
			minut += rand(5,10)
			gt 'gdkin'
		end
	end
end
! серьезный разговор с Катей
if $args[0] = 'hub_talk':
	*clr & cla
	minut += rand(1,3)
	gs 'zz_render','','common/npc/14',func('mey_katya_strings',102)
	act 'Согласиться':
		*clr & cla
		$npc['14,qwKatya'] = 100
		gs 'zz_render','','common/npc/14',func('mey_katya_strings',103)
		act 'Отойти': gt 'zz_school'
	end
	act 'Настаивать':
		*clr & cla
		$npc['14,qwKatya'] = 95
		$npc['14,hub_talk_day'] = daystart + rand(4,7)
		gs 'zz_render','','common/npc/14',func('mey_katya_strings',104)
		act 'Отойти': gt 'zz_school'
	end
end
! Катя уезжает в город
if $args[0] = 'after_talk':
	*clr & cla
	$npc['14,qwKatya'] = 200
	minut += rand(1,3)
	gs 'zz_render','','common/npc/14',func('mey_katya_strings',105)
	act 'Отойти': gt 'zz_school'
end
! разговор о трио
if $args[0] = 'ask_about_trio':
	*clr & cla
	$npc['14,qwKatya'] = 72
	$npc['14,qwKatya_day'] = day
	$npc['14,qwKatya_trio_day'] = daystart + 1
	gs 'zz_render','','common/npc/14',func('mey_katya_strings',106)+func('mey_katya_strings',iif(month > 3 and month < 11,107,108))
	act 'Отойти': gt 'gdkin'
end
! трио в парке
if $args[0] = 'park_trio':
	*clr & cla
	_stage = args[1]
	minut += rand(5,10)
	if _stage = 2: horny = 0
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/park_trio/<<_stage>>.gif',func('mey_katya_strings',109+_stage)
	act '...':
		if _stage < 3:
			gt 'mey_katya_events','park_trio',_stage+1
		else
			bj += 1
			sex += 1
			guy += 1
			orgasm += 1
			minut += rand(10,20)
			gs 'zz_funcs','alko'
			if vagina < 10: vagina += 1
			$npc['14,qwKatya'] = 75
			$npc['14,qwKatya_day'] = day
			killvar '_stage'
			gt 'zz_park'
		end
	end
end
! трио в отеле
if $args[0] = 'hotel_trio_prepeare':
	*clr & cla
	gs 'zz_render','','pavlovo/hotel/hotel',func('mey_katya_strings',iif($npc['0,hotelwork'] = 1 or $npc['0,hotelwork'] = 3,113,114))
	act '...': gt 'mey_katya_events','hotel_trio'
end
if $args[0] = 'hotel_trio':
	*clr & cla
	_stage = args[1]
	minut += rand(5,10)
	if _stage = 2: horny = 0
	gs 'stat'
	gs 'zz_render','','pavlovo/meynolds/katya/hotel_trio/<<_stage>>.gif',func('mey_katya_strings',115+_stage)
	act '...':
		if _stage < 3:
			gt 'mey_katya_events','hotel_trio',_stage+1
		else
			bj += 1
			anal += 1
			guy += 1
			orgasm += 1
			minut += rand(10,20)
			if anus < 10: anus += 1
			gs 'zz_funcs','alko'
			$npc['14,qwKatya'] = 75
			$npc['14,qwKatya_day'] = day
			killvar '_stage'
			gt 'gorodok'
		end
	end
end
!--