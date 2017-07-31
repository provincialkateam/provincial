! vika shedule
! 0.00-7.00 - her room, sleep
! 7.00-7.30 - bath
! 7.30-8.00 - her room
! 8.00-8.30 - kitchen
! 8.30-9.00 - way to school
! 9.00-15.00 - school
! 15.00-18.00 - park/cafe or her room
! 18.00-20.00 - park or her room
! 20.00-23.00 - DK
! 23.00-24.00 - event-time/her room
! weekend
! 8.30-11.00 - hall, tv
! 11.00-16.00 - courtyard/terrace or her room
! --- стадии ветки --- !
! 0 - одноклассицы
! 1 - первая слежка в парке за Викой и Иваном после подсказки Кати
! 2 - первая слежка в парке без подсказки Кати
! 3-4 - встреча в парке, болтаем
! 5-6 - веселые разговоры в парке
! 7-9 - Вика с Иваном что-то замышляют
! 10 - предложение сходить в кафешку, при отказе замораживается
! 15 - совмесный поход в кафешку
! 18 - после похода в кафешку
! 19 - повторный поход в кафешку
! 20 - после похода в кафе либо после ивента на пляже
! 25 - после знакомства с ТМ, первое чаепитие с ТМ
! 26-27 - после игры на желания
! 27 - вротое чаепитие с ТМ
! 30 - после второго чаепития с ТМ, ивент Вики с подарком от ТМ
! 31 - ивент с подарком закончен
! 32 - следующий разговор Вики и ГГ, ГГ получает ключ от дома Менольдов
! 33 - первое подглядывание за обучением Вики
! 34 - второе подглядывание за обучением Вики
! 35 - ГГ поймали за третим подглядыванием, старт обучения в ТМ, ветка Вики на этом все.
! ---
if $args[0] = 'first_visit':
	*clr & cla
	! для первого раза - знакомство с ТМ
	if $npc['15,qwVika'] = 20 and $npc['45,qwTamara'] = 0: gt 'mey_tamara_events','first_meet','vika'
	minut += 10
	horny += 10
	gs 'stat'
	gs 'zz_render','Комната Вики','pavlovo/meynolds/vika/first_visit/qw_30', func('mey_vika_strings', 'first_visit')
	act 'Далее':
		*clr & cla
		horny += 10
		alko = 2
		gs 'stat'
		gs 'zz_render','Комната Вики','pavlovo/meynolds/vika/first_visit/qw_35', func('mey_vika_strings', 'first_visit_qw35')
		act 'Играть': gt 'mey_vika_events', 'play_game'
	end
end
if $args[0] = 'end_game':
	minut += 5
	killvar 'win'
	gt 'gorodok'
end
if $args[0] = 'play_game':
	! начало игры
	*clr & cla
	minut += 5
	gs 'mey_vika_events', 'play_game_sub', 1
	! инфо о победителе/проигравшем
	if win[0] = 0:
		! победила светка
		gs 'zz_render', '', '', func('mey_vika_strings', 'play_game0') + func('mey_vika_strings', iif(win[1]=2,'play_game1','play_game2'))
		if win[1] = 1:
			! проиграл иван, атлет
			cla
			act 'Загадать желание': gt 'mey_vika_events', 'play_game_wish0'
		else
			! проиграла вика, стриптиз
			cla
			act 'Загадать желание': gt 'mey_vika_events', 'play_game_wish1'
		end
	elseif win[0] = 1:
		! победил иван
		gs 'zz_render', '', '', func('mey_vika_strings', 'play_game3') + func('mey_vika_strings', iif(win[1]=0,'play_game4','play_game5'))
		if win[1] = 0:
			! проиграла светка, поцелуй #2
			cla
			act 'Выполнить задание': gt 'mey_vika_events', 'play_game_wish2'
		else
			! проиграла вика, играем заново
			cla
			act 'Играть дальше': gt 'mey_vika_events', 'play_game'
			act 'Закончить': gt 'mey_vika_events', 'end_game'
		end
	else
		! победила вика
		gs 'zz_render', '', '', func('mey_vika_strings', 'play_game6') + func('mey_vika_strings', iif(win[1]=0,'play_game7','play_game8'))
		if win[1] = 0:
			! проиграла светка, поцелуй
			cla
			act 'Выполнить задание': gt 'mey_vika_events', 'play_game_wish3'
		else
			! проиграл иван, атлет
			cla
			act '...': gt 'mey_vika_events', 'play_game_wish0'
		end
	end
end
! желание ивану от девушек
if $args[0] = 'play_game_wish0':
	! иван проиграл
	*clr & cla
	$_img = 'pavlovo/meynolds/vika/game/'
	if $npc['15,qwVika'] < 27 and $npc['15,qw_day'] ! day: $npc['15,qwVika'] += 1
	gs 'zz_render','',$_img + 0, func('mey_vika_strings', 'play_game10')
	horny += iif(horny < 60,40,20)
	gs 'stat'
	if vagina > 0:
		act '...':
			*clr & cla
			gs 'zz_render','',$_img + 1, func('mey_vika_strings', 'play_game11')
			act '...':
				*clr & cla
				gs 'zz_render','',$_img + '2.gif', func('mey_vika_strings', 'play_game12')
				act '...':
					*clr & cla
					gs 'zz_render','',$_img + '3.gif', func('mey_vika_strings', 'play_game13')
					horny = 0
					gs 'stat'
					act '...':
						*clr & cla
						gs 'zz_render','',$_img + '4.gif', func('mey_vika_strings', 'play_game14')
						killvar '$_img'
						act 'Уйти': gt 'mey_vika_events', 'end_game'
					end
				end
			end
		end
	else
		*clr & cla
		gs 'zz_render', '', '', 'А нету ничего!!!'
		act 'Уйти': gt 'mey_vika_events', 'end_game'
	end
end
! желание вике от светки, стриптиз
if $args[0] = 'play_game_wish1':
	*clr & cla
	if $npc['15,qwVika'] < 27 and $npc['15,qw_day'] ! day: $npc['15,qwVika'] += 1
	horny += 10
	minut += 1
	zz_stage = args[1]
	gs 'stat'
	if zz_stage < 1:
		gs 'zz_render','','pavlovo/meynolds/vika/game/strip/0.gif', func('mey_vika_strings', 'play_game15')
		act '...': gt 'mey_vika_events', 'play_game_wish1', 16
	else
		if zz_stage <= 33:
			gs 'zz_render','','pavlovo/meynolds/vika/game/strip/' + zz_stage + iif(zz_stage=16 or zz_stage=22 or zz_stage=25 or (zz_stage>=27 and zz_stage<=30),'.gif','.jpg'), func('mey_vika_strings', 'play_game' + zz_stage)
			act '...': gt 'mey_vika_events', 'play_game_wish1', zz_stage+1
		else
			gs 'zz_render', '', '', func('mey_vika_strings','play_game34')+func('mey_vika_strings','play_game14')
			killvar 'zz_stage'
			act 'Уйти': gt 'mey_vika_events', 'end_game'
		end
	end
end
! желание светке от ивана, поцелуй #2
if $args[0] = 'play_game_wish2':
	*clr & cla
	if $npc['15,qwVika'] < 27 and $npc['15,qw_day'] ! day: $npc['15,qwVika'] += 1
	gs 'zz_render', '', 'pavlovo/meynolds/vika/game/kiss2.jpg', func('mey_vika_strings', 'play_game35')
	act 'Целоваться':
		*clr & cla
		gs 'zz_render', '', 'pavlovo/meynolds/vika/game/kiss3.jpg', func('mey_vika_strings', 'play_game36')
		act 'Играть дальше': gt 'mey_vika_events', 'play_game'
		act 'Уйти': gt 'mey_vika_events', 'end_game'
	end
end
! желание светке от вики, поцелуй
if $args[0] = 'play_game_wish3':
	*clr & cla
	if $npc['15,qwVika'] < 27 and $npc['15,qw_day'] ! day: $npc['15,qwVika'] += 1
	gs 'zz_render', '', 'pavlovo/meynolds/vika/game/kiss1.gif', func('mey_vika_strings', 'play_game9')
	horny += iif(horny < 60,40,20)
	gs 'stat'
	act 'Играть дальше': gt 'mey_vika_events', 'play_game'
	act 'Закончить': gt 'mey_vika_events', 'end_game'
end
if $args[0] = 'play_game_sub':
	! winner
	! 0 - sveta
	! 1 - vanya
	! 2 - vika
	win[0] = rand(0,2)
	if win[0] = 0:
		win[1] = rand(1,2)
	elseif win[0] = 1:
		win[1] = iif(rand(0,10)>5,0,2)
	elseif win[0] = 2:
		win[1] = rand(0,1)
	end
end
if $args[0] = 'near_school':
	!*clr & cla
	if week < 6 and hour = 15 and minut >= 0 and minut <= 15 and school['vacation'] = 0:
		if week mod 2 = 0:
			gs 'zz_render', '', '', func('mey_vika_strings', 'near_school0')
			! Начало квеста, Светка ничего не знает об отношениях Вики и Ивана
			if $npc['15,qwVika'] = 0:
				gs 'zz_render', '', '', func('mey_vika_strings', 'near_school1')
				! расспрос Кати
				gs 'zz_render', '', '', func('mey_vika_strings', 'near_school2')
				! проверяем отношения с Катей
				if $npc['14,relation'] >= 60:
					gs 'zz_render', '', '', func('mey_vika_strings', 'near_school3')
					$npc['15,qwVika'] = 1
					act 'Идти в парк': gt 'zz_park'
				else
					gs 'zz_render', '', '', func('mey_vika_strings', 'near_school4')
					$npc['15,qwVika'] = 2
					act 'Проследить': minut += rand(5,15) & gt 'zz_park'
				end
			else
				if $npc['15,qwVika'] >= 20 and $npc['15,qwVika'] < 27 and $npc['15,qw_day'] ! day:
					! goto Meynolds home
					cla
					gs 'zz_render', '', '', func('mey_vika_strings', 'near_school7')
					! первый визит, знакомим с мамой
					act 'Идти к Вике': gt 'mey_vika_events','first_visit'
				elseif $npc['15,qwVika'] = 27 and $npc['15,qw_day'] ! day:
					$npc['15,qw_day'] = day
					gs 'zz_render', '', '', func('mey_vika_strings', 'near_school8')
					act 'Идти в гости к тете Тамаре': gt 'mey_tamara_events', 'next_meet'
				elseif $npc['15,qwVika'] = 31:
					$npc['15,qwVika'] = 32
					$npc['15,qw_day'] = day
					$npc['0,meynold_key'] = 1
					gs 'zz_render', '', '', func('mey_vika_strings', 'near_school9')
					act 'Отойти': gt 'gschool'
				else
					gs 'zz_render', '', '', func('mey_vika_strings', 'near_school5')
				end
			end
		else
			gs 'zz_render', '', '', func('mey_vika_strings', 'near_school6')
		end
	end
end
if $args[0] = 'park_meet':
	minut += rand(10,20)
	! отправляем Ваньку на тренировки
	if week mod 2 = 1 and hour >= 15 and hour < 18:
		gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet_another_time'+iif($npc['15,qwVika'] < 3,0,1))
		exit
	end
	if hour >= 15 and hour < 20 and $npc['15,qw_day'] ! day:
		! плохая погода, нечего гулять, отправляем парочку в новую кафешку
		if sunWeather < 0 or temper < 5:
			gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet_bad_weather'+iif($npc['15,qwVika'] < 3,0,1))
			exit
		end
		*clr & cla
		act 'Отойти': gt 'zz_park'
		! случайно натыкаемся на парочку в парке, начало квеста
		if $npc['15,qwVika'] = 0: $_str = func('mey_vika_strings', 'park_meet0')
		! Катя рассказала - знаем, что парочка здесь
		if $npc['15,qwVika'] = 1: $_str = func('mey_vika_strings', 'park_meet1')
		! следим
		if $npc['15,qwVika'] = 2: $_str = func('mey_vika_strings', 'park_meet2')
		! повтор 3 - 4
		if $npc['15,qwVika'] >= 3: $_str = func('mey_vika_strings', 'park_meet3')
		! mey_vika_park_action: 0 - гуляют, 1 - целуются
		if $npc['15,park_action'] = 0: gs 'zz_render','','pavlovo/meynolds/vika/park/walk.jpg', $_str
		if $npc['15,park_action'] = 1: gs 'zz_render','','pavlovo/meynolds/vika/park/kiss'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg',$_str
		if $npc['15,park_action'] = 2: gs 'zz_render','','pavlovo/meynolds/vika/park/bench.jpg', $_str
		killvar '$_str'
		!---
		gs 'mey_vika_events','meet_process'
		!---
		! чередуем событие
		$npc['15,park_action'] += 1
		if $npc['15,park_action'] > 2: $npc['15,park_action'] = 0
		! переводим счетчики
		if $npc['15,qwVika'] < 10: $npc['15,qwVika'] += 1
		exit
	end
end
if $args[0] = 'meet_process':
	$npc['15,qw_day'] = day
	if $npc['15,qwVika'] <= 2:
		! мимокрокодил
		gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet4')
		! стадии 3-4
	elseif $npc['15,qwVika'] = 3 or $npc['15,qwVika'] = 4:
		! привет
		gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet5')
		! подключаем взаимоотношения и ответ
		gs 'zz_render', '', '', func('mey_vika_strings', iif($npc['15,relation'] < 60,'park_meet6','park_meet7'))
		! стадия 5 и више
	else
		gs 'zz_render', '', '', func('mey_vika_strings', iif($npc['15,relation'] < 60,'park_meet8','park_meet9'))
		if $npc['15,relation'] >= 60:
			gs 'npc_editor','change_rep','+',3
			gs 'npc_editor','change_rep','+',15
		end
		! что-то здесь намечается
		if $npc['15,relation'] >= 80:
			if $npc['15,qwVika'] >= 7: gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet10')
			! приглос в кафешку
			if $npc['15,qwVika'] = 10:
				cla
				gs 'zz_render', '', '', func('mey_vika_strings', iif($loc = 'zz_park','park_meet11','park_meet13'))
				if money >= 300:
					act 'Согласиться':
						$npc['15,qwVika'] = 15
						gt 'mey_vika_events','cafe_qw'
					end
				else
					act 'Отказаться':
						cla
						gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet12')
						act 'Уйти': gt 'zz_park'
					end
				end
			end
			if $npc['15,qwVika'] >= 18 and $npc['15,qwVika'] < 20 and $loc = 'zz_park':
				if sunWeather >= 0 and temper >= 20 and month >= 5 and month <= 9 and hour <= 17:
					cla
					gs 'zz_render', '', '', func('mey_vika_strings', 'case_beach0')
					act 'Отказаться': gt 'gorodok'
					if mesec = 0: act 'Пойти с ними на пляж': gt 'mey_vika_events', 'beach_event0'
				else
					cla
					gs 'zz_render', '', '', func('mey_vika_strings', 'park_meet11')
					act 'Отказаться': gt 'gorodok'
					if money > 300: act 'Идти в кафе': gt 'mey_vika_events','cafe_repeat_qw'
				end
			end
		else
			! если отношения не отличные - замораживаем квест
			$npc['15,qwVika'] -= 1
		end
	end
end
if $args[0] = 'cafe_qw':
	*clr & cla
	money -= rand(150,250)
	gs 'zz_render','','pavlovo/meynolds/vika/cafe/0',func('mey_vika_strings','cafe_qw1')
	act 'Хм...':
		*clr & cla
		minut += 10
		horny += 10
		energy += 20
		gs 'stat'
		gs 'zz_render','','pavlovo/meynolds/vika/cafe/1',func('mey_vika_strings','cafe_qw2')
		act '...':
			*clr & cla
			minut += 2
			horny = 100
			gs 'stat'
			gs 'zz_render','','pavlovo/meynolds/vika/cafe/2',func('mey_vika_strings','cafe_qw3')
			act 'Попрощаться':
				*clr & cla
				minut += 2
				gs 'stat'
				gs 'zz_funcs','wanted'
				gs 'zz_render','','',func('mey_vika_strings','cafe_qw4')
				act 'Уйти':
					minut += 2
					horny = 0
					manna += 10
					$npc['15,qwVika'] = 18
					gs 'stat'
					gt 'cafe_parco', 'start'
				end
			end
		end
	end
end
if $args[0] = 'cafe_repeat_qw':
	*clr & cla
	money -= 150
	horny += 10
	gs 'zz_render', '', 'pavlovo/meynolds/vika/cafe/0', func('mey_vika_strings', 'cafe_qw1')
	gs 'zz_render', '', '', func('mey_vika_strings', 'cafe_qw'+iif($npc['15,qwVika'] > 15,5,6))
	if $npc['15,qwVika'] = 18 or $npc['15,qwVika'] = 19: $npc['15,qwVika'] += 1
	act 'Попрощаться и уйти': gt 'cafe_parco','inner'
end
if $args[0] = 'beach_event0':
	*clr & cla
	! +Prohorov rel
	$_img = 'pavlovo/meynolds/vika/beach/'
	$npc['3,relation'] += 3
	if args[1] < 1:
		gs 'zz_render', '', $_img + 1, func('mey_vika_strings', 'case_beach1')
		act 'Идти на дикий пляж': gt 'mey_vika_events', 'beach_event0', 1
	else
		*clr & cla
		$npc['15,qw_day'] = day
		gs 'zz_render', '', $_img + 2, func('mey_vika_strings', 'case_beach2')
		if hour < 20:
			! переодеваем в купальник
			gs 'zz_clothing', 'redress', 2
			flag_tanga = tanga
			tanga = 0
			act 'Купаться':
				*clr & cla
				minut += 10
				manna += 10
				gs 'zz_bathroom', 'clean_me'
				gs 'stat'
				gs 'zz_render', '', $_img + 3, func('mey_vika_strings', 'case_beach3')
				act '...': gt 'mey_vika_events', 'beach_event0', 1
			end
			act 'Загорать':
				*clr & cla
				minut += 10
				manna += 10
				hapri = 1
				tan += 1
				gs 'zz_bathroom', 'clean_me'
				gs 'stat'
				gs 'zz_render', '', $_img + 4, func('mey_vika_strings', 'case_beach4')
				act '...':
					*clr & cla
					horny += iif(horny < 60, 50, 20)
					minut += 5
					gs 'zz_render', '', $_img + 5, func('mey_vika_strings', 'case_beach5')
					! проверяем целкостность
					if vagina = 0:
						! если целка - уходим с пляжа
						*clr & cla
						minut += rand(60,90)
						gs 'zz_render', '', '', func('mey_vika_strings', 'case_beach16')
						gs 'mey_vika_events', 'beach_ender'
					else
						! гг не девочка, продолжаем
						act '...':
							*clr & cla
							horny += 20
							minut += 5
							gs 'stat'
							gs 'zz_render', '', $_img + 6, func('mey_vika_strings', 'case_beach6')
							act '...':
								*clr & cla
								horny += 20
								minut += 5
								gs 'stat'
								gs 'zz_render', '', $_img + 7, func('mey_vika_strings', 'case_beach7')
								act '...':
									*clr & cla
									gs 'zz_render', '', $_img + 8, func('mey_vika_strings', 'case_beach8')
									act '...':
										*clr & cla
										horny += 20
										minut += 30
										gs 'stat'
										gs 'zz_render', '', $_img + 9, func('mey_vika_strings', 'case_beach9')
										act '...':
											*clr & cla
											gs 'zz_render', '', $_img + 10, func('mey_vika_strings', 'case_beach10')
											act '...':
												*clr & cla
												horny = 0
												minut += 10
												gs 'stat'
												gs 'zz_render', '', $_img + 11, func('mey_vika_strings', 'case_beach11')
												$npc['15,qwVika'] = 20
												gs 'mey_vika_events', 'beach_ender'
											end
										end
									end
								end
							end
						end
					end
				end
			end
		else
			gs 'mey_vika_events', 'beach_ender'
		end
	end
end
if $args[0] = 'beach_ender':
	act 'Уйти':
		killvar '$_img'
		if current_clothing < 3: gs 'zz_clothing', 'redress', prev_clothing
		! на всяк пожарный еще проверяем одета ли гг
		if current_clothing < 3: gs 'zz_clothing', 'fix_emergency'
		gt 'gorodok'
	end
end
if $args[0] = 'beach_event1':
	if temper >= 20 and sunWeather >= 0 and month >= 5 and month <= 9 and hour < 20 and $npc['15,qwVika'] >= 18 and $npc['15,qwVika'] < 20 and $npc['15,qw_day'] ! day:
		if (hour >= 10 and week >= 6) or (hour >= 15 and week < 6):
			*clr & cla
			$npc['15,qw_day'] = day
			gs 'zz_render', '', 'pavlovo/meynolds/vika/beach/1', func('mey_vika_strings', 'case_beach12')
			act 'Отказаться':
				cla
				gs 'zz_render', '', '', func('mey_vika_strings', 'case_beach13')
				act 'Уйти': gt 'glake'
			end
			act 'Присоединиться':
				cla
				gs 'zz_render', '', '', func('mey_vika_strings', 'case_beach14')
				act '...':
					*clr & cla
					gs 'zz_render', '', '', func('mey_vika_strings', 'case_beach15')
					act 'Идти на дикий пляж':
						gs 'mey_vika_events', 'beach_event0', 1
					end
				end
			end
		end
	end
end
! case with a gift
if $args[0] = 'case_gift':
	if $npc['15,qwVika'] = 30 and $npc['15,qw_day'] ! day and hour = 23:
		zz_stage = args[1]
		if zz_stage < 2:
			*clr & cla
			gs 'zz_render', '', 'pavlovo/meynolds/vika/gift/0', func('mey_vika_strings', 'case_gift0')
			act 'Пройти мимо': gs 'mey_vika_events', 'case_gift_ender'
			act 'Подслушивать':
				*clr & cla
				gs 'zz_render', '', 'pavlovo/meynolds/vika/gift/1.gif', func('mey_vika_strings', 'case_gift1')
				act 'Уйти': gs 'mey_vika_events', 'case_gift_ender'
				act 'Приоткрыть дверь': gs 'mey_vika_events','case_gift', 2
			end
		else
			*clr & cla
			if zz_stage < 14:
				gs 'zz_render', '', 'pavlovo/meynolds/vika/gift/'+zz_stage+iif(zz_stage=12,'.gif','.jpg'), func('mey_vika_strings', 'case_gift'+zz_stage)
				act '...': gs 'mey_vika_events','case_gift', zz_stage + 1
			else
				horny = 100
				minut += 10
				gs 'zz_render', '', 'pavlovo/meynolds/vika/gift/14.jpg', func('mey_vika_strings', 'case_gift14')
				act 'Быстро уйти в свою комнату': $npc['15,qwVika'] = 31 & gs 'mey_vika_events', 'case_gift_ender'
			end
		end
	end
end
if $args[0] = 'case_gift_ender':
	$npc['15,qw_day'] = day
	killvar 'zz_stage'
	gt 'mey_home', 3
end
if $args[0] = 'learning0':
	if $npc['15,qwVika'] >= 32 and $npc['15,qwVika'] < 35 and $npc['15,qw_day'] ! day and hour >= 23:
		*clr & cla
		minut += 5
		$npc['15,qw_day'] = day
		gs 'zz_render', '', 'pavlovo/meynolds/vika/gift/0', func('mey_vika_strings', 'learning0')
		act 'Пройти мимо': gt 'mey_home', 3
		act 'Приоткрыть дверь':
			*clr & cla
			gs 'zz_render', '', 'pavlovo/meynolds/tamara/learning/1', func('mey_vika_strings', 'learning1')
			act 'Уйти': gt 'mey_home', 3
			act '...':
				*clr
				i = rand(0,4)
				gs 'zz_render', '', 'pavlovo/meynolds/tamara/learning/l<<i>>', func('mey_vika_strings', 'learning2<<i>>')
				if $npc['15,qwVika'] = 34:
					cla
					gs 'zz_render', '', '', func('mey_vika_strings', 'learning3')
					act '...':
						*clr & cla
						manna -= iif(manna > 50, 30, iif(manna > 20, 20, 0))
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/meynolds/tamara/learning/3', func('mey_vika_strings', 'learning4')
						act 'Сбежать в свою комнату':
							*clr & cla
							gs 'zz_render', '', 'pavlovo/meynolds/home/guestroom', func('mey_vika_strings', 'learning7')
							act 'Идти в зал':
								*clr & cla
								$npc['15,qwVika'] = 35
								$npc['45,qwTamara'] = 3
								gs 'zz_render', '', 'pavlovo/meynolds/tamara/learning/4', func('mey_vika_strings', 'learning8') + func('mey_vika_strings', 'learning6')
								act 'В свою комнату': gt 'mey_home', 3
							end
						end
						act 'Реветь от стыда и обиды':
							*clr & cla
							gs 'zz_render', '', 'pavlovo/meynolds/tamara/learning/4', func('mey_vika_strings', 'learning5') + 'br' + func('mey_vika_strings', 'learning6')
							$npc['15,qwVika'] = 35
							$npc['45,qwTamara'] = 3
							act 'В свою комнату': gt 'mey_home', 3
						end
					end
				else
					cla
					$npc['15,qwVika'] += 1
					act 'Уйти': gt 'mey_home', 3
				end
			end
		end
	end
end
if $args[0] = 'gym0':
	if week mod 2 ! 0 and $npc['15,qwVika'] >= 32 and $npc['15,gym_day'] ! day and hour = 15 and minut >= 30:
		zz_stage = args[1]
		if zz_stage < 1:
			*clr & cla
			gs 'zz_render', '', 'pavlovo/meynolds/vika/gym/0', func('mey_vika_strings', 'gym0')
			act 'Отказаться':
				cla
				gs 'zz_render', '', '', func('mey_vika_strings', 'gym1')
				act 'Уйти': gt 'mey_home', 0
			end
			act 'Согласиться':
				cla
				gs 'zz_render', '', '', func('mey_vika_strings', 'gym2')
				act '...': gs 'mey_vika_events','gym0', 3
			end
		else
			*clr & cla
			if zz_stage <= 10:
				gs 'zz_render', '', 'pavlovo/meynolds/vika/gym/' + zz_stage, func('mey_vika_strings', 'gym'+zz_stage)
				if zz_stage = 10:
					!cla
					minut += 30
					body['day_weight'] -= 1
					react += RAND(1,2)
					sweat += 3
					$npc['15,gym_day'] = day
					killvar 'zz_stage'
					if mesec = 0 and vagina > 0 and $npc['15,bath_qw'] = 1 and $npc['15,bath_qw_day'] ! day:
						act 'Идти с Викой в душ':
							gt 'mey_vika_events', 'bath_common',1
						end
					end
					act 'Пойти в душ самой':
						minut += 15
						*clr & cla
						gs 'zz_bathroom', 'clean_me'
						gs 'zz_render', '', 'pavlovo/meynolds/vika/bath/0', func('mey_vika_strings', 'after_bath')
						act 'Выйти': gs 'mey_home', 0
					end
					act 'Выйти из комнаты': gt 'mey_home', 0
				else
					act '...': gs 'mey_vika_events','gym0', zz_stage+1
				end
			end
		end
	end
end
if $args[0] = 'gym1':
	if week mod 2 ! 0 and $npc['15,qwVika'] >= 32 and $npc['15,gym_day'] ! day and hour = 17 and minut >= 30:
		zz_stage = args[1]
		if zz_stage < 1:
			*clr & cla
			gs 'zz_render', '', 'pavlovo/meynolds/vika/gym/20', func('mey_vika_strings', 'gym20')
			act 'Смотреть': gs 'mey_vika_events','gym1', 21
		else
			*clr & cla
			if zz_stage <= 26:
				gs 'zz_render', '', 'pavlovo/meynolds/vika/gym/' + zz_stage, func('mey_vika_strings', 'gym'+zz_stage)
				if zz_stage = 26:
					minut += rand(10,20)
					horny += 20
					gs 'stat'
 					$npc['15,gym_day'] = day
					killvar 'zz_stage'
					act 'Хм...': gt 'mey_home', 0
				else
					act '...': gs 'mey_vika_events','gym1', zz_stage+1
				end
			end
		end
	end
end
if $args[0] = 'bath_qw0':
	*clr & cla
	gs 'zz_render','','pavlovo/meynolds/home/common/vaccleaner', func('mey_vika_strings', 'bath_qw0')
	if mesec = 0 and vagina > 0:
		act 'Идти':
			$npc['15,bath_qw'] = 1
			$npc['15,bath_qw_day'] = day
			gt 'mey_vika_events', 'bath_common',1
		end
	else
		act 'Отказаться':
			*clr & cla
			gs 'zz_render', '', 'pavlovo/meynolds/home/common/vaccleaner.jpg', func('mey_vika_strings', 'bath_qw12')
			act '...': gt 'mey_home', 0
		end
	end
end
if $args[0] = 'bath_qw1':
	cla
	$npc['15,bath_qw_day'] = day
	gs 'zz_render', '', '', func('mey_vika_strings', 'bath_qw11')
	if mesec = 0 and vagina > 0:
		act 'Идти':
			gt 'mey_vika_events', 'bath_common',1
		end
	end
	act 'Отказаться':
		cla
		gs 'zz_render', '', '', '<br>' + func('mey_vika_strings', 'bath_qw12')
		act '...': gt 'mey_home', 0
	end
end
if $args[0] = 'bath_common':
	zz_stage = args[1]
	if zz_stage <= 0: zz_stage = 1
	if zz_stage <= 10:
		*clr & cla
		gs 'zz_render', '', 'pavlovo/meynolds/vika/bath/' + zz_stage, func('mey_vika_strings', 'bath_qw'+zz_stage)
		if zz_stage = 10:
			minut += rand(15,30)
			horny = 0
			manna += 20
			killvar 'zz_stage'
			gs 'zz_bathroom', 'clean_me'
			gs 'stat'
			act 'Выйти': gt 'mey_home', 0
		else
			act '...': gt 'mey_vika_events','bath_common', zz_stage+1
		end
	end
end
if $args[0] = 'bang_katya':
	zz_stage = args[1]
	if zz_stage = 0:
		cla
		gs 'zz_render','','', func('mey_vika_strings', 'bang_katya0')
		act 'Согласиться':
			cla
			gs 'zz_render','','', func('mey_vika_strings', 'bang_katya2')
			act 'В комнату Кати': gt 'mey_vika_events', 'bang_katya', 3
		end
		act 'Отказаться':
			cla
			killvar 'zz_stage'
			gs 'zz_render','','', func('mey_vika_strings', 'bang_katya1')
			act 'Уйти': gt 'mey_home', 3
		end
	else
		*clr & cla
		gs 'zz_render','','pavlovo/meynolds/vika/bang_katya'+zz_stage, func('mey_vika_strings', 'bang_katya'+zz_stage)
		if zz_stage < 8:
			act '...': gt 'mey_vika_events', 'bang_katya', zz_stage+1
		else
			killvar 'zz_stage'
			minut += rand(15,20)
			horny += rand(10,30)
			$npc['15,mey_vika_bang_qw'] = 1
			$npc['14,sex'] += 1
			gs 'stat'
			gs 'zz_render','','', func('mey_vika_strings', 'bang_katya'+iif($npc['14,qwKatya'] < 5,9,iif($npc['14,qwKatya']>=5 and $npc['14,qwKatya']<10,10,11)))
			act 'Идти к себе': gt 'mey_home', 3
		end
	end
end
! рандомное подглядывание за Викой с Иваном
if $args[0] = 'random_sex_prepeare':
	*clr & cla
	$npc['15,qwVika_random_day'] = day
	gs 'zz_render', '', 'pavlovo/meynolds/vika/gift/0', func('mey_vika_strings','case_gift0')
	act 'Подсмотреть': gt 'mey_vika_events','random_sex'
	act 'Уйти': minut += rand(1,5) & gt 'mey_home',10
end
if $args[0] = 'random_sex':
	*clr & cla
	_stage = args[1]
	horny += rand(5,10)
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/meynolds/vika/random/' + _stage, func('mey_vika_strings','random_sex'+_stage)
	act iif(_stage < 12,'...','Уйти'):
		if _stage < 12:
			gt 'mey_vika_events','random_sex', _stage+1
		else
			killvar '_stage'
			gt 'mey_home',10
		end
	end
end