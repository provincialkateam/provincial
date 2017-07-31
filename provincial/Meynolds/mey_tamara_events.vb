! tamara shedule
! 0.00-6.00 - her room
! 6.00-6.30 - bath
! 6.30-7.00 - her room
! 7.00-7.30 - kitchen
! 7.30-8.00 - courtyard
! 8.00-8.30 - way to work
! 8.30-16.30 - bank
! 16.30-17.00 - bank inner
! 17.00-17.30 - way to home
! 17.30-18.00 - kitchen
! 18.00-22.00 - hall
! 22.00-24.00 - her room, reading/ event time
! weekend
! 7.30-8.30 - her room
! 8.30-11.00 - hall, tv
! 11.00-16.00 - courtyard/terrace or n/a
! 16.00-17.00 - kitchen
! --- стадии ветки ТМ --- !
! 0 - не знакомы
! 1 - первое чаепитие
! 2 - второе чаепитие
! 3 - ГГ начинает обучение у ТМ
! 5 - первый урок от ТМ
! 6 - ГГ ушла гулять в город
! 7 - ГГ не вернулась с ТМ - наказание
! 10 - ГГ вернулась вовремя с ТМ, получает приглашение на корпоратив
! 15 - приглашение получено
! 16 - ГГ надо привести себя в приличный вид
! 20 - поездка на корпоратив
! 30 - хороший конец вечеринки
! 40 - ГГ отказалась ехать на вечеринку
! 50 - плохое завершение вечеринки
! ---
! собсно сабж
if $args[0] = 'tamara':
	*clr & cla
	gs 'zz_render', 'Тамара Михайловна', 'pavlovo/meynolds/tamara/tamara.jpg', func('mey_tamara_strings', 'description')
	if $curloc = 'bank': act 'Ехать домой': minut += 30 & gt 'mey_home', 0
	if $curloc = 'mey_home' and $npc['45,qwTamara'] >= 3 and $npc['45,qwTamara'] < 50:
		if week >= 6 or school['vacation'] > 0: act 'Попросить отвезти в город': minut += 30 & gt 'down'
		if GorSlut >= 3 and $npc['45,reputation_qw'] = 0: act 'Рассказать о падении': gt 'mey_tamara_events', 'reputation'
	end
	act 'Отойти': gt $curloc, iif($curloc = 'mey_home',mey_loc_id,$metka)
end
! первая встреча
if $args[0] = 'first_meet':
	*clr & cla
	! кто знакомит
	$introducer = $args[1]
	$npc['45,know'] = 1
	$npc['45,qwTamara'] = 1
	gs 'zz_render', 'Тамара Михайловна', 'pavlovo/meynolds/tamara/tamara.jpg', func('mey_tamara_strings', 'first_meet')
	act 'На кухню':
		*clr & cla
		minut += 60
		gs 'stat'
		gs 'zz_render', 'Тамара Михайловна', 'pavlovo/meynolds/tamara/meeting/first_meet_tea', func('mey_tamara_strings', 'first_tea')
		if $introducer = 'vika':
			$npc['15,qwVika'] = 25
			killvar '$introducer'
			act 'Идти с Викой': gs 'mey_vika_events', 'first_visit'
		else
			$npc['14,qwKatya'] = 15
			killvar '$introducer'
			act 'Идти с Катей': gt 'mey_home',5
		end
	end
end
! первая встреча - самостоятельное знакомство
if $args[0] = 'first_ind_meet':
	*clr & cla
	gs 'zz_render','','pavlovo/meynolds/tamara/meeting/tea1',func('mey_tamara_strings','first_ind_meet')
	act 'Идти с Катей': gt 'mey_home',5
	exit
end
! второе чаепитие
if $args[0] = 'next_meet':
	*clr & cla
	minut += 1
	zz_stage = args[1]
	gs 'stat'
	if zz_stage < 1:
		gs 'zz_render','','pavlovo/meynolds/home/door', func('mey_tamara_strings', 'next_tea0')
		act '...': gt 'mey_tamara_events', 'next_meet', 1
	else
		if zz_stage < 8:
			! переводим часы, если надо
			if zz_stage = 7 and hour < 22:
				hour = 22
				minut = rand(0,59)
				energy = iif(energy < 20,20,energy)
				water = iif(water < 20,20,water)
				manna += 20
				gs 'stat'
			end
			gs 'zz_render', '', 'pavlovo/meynolds/tamara/meeting/tea' + zz_stage, func('mey_tamara_strings', 'next_tea' + zz_stage)
			act '...': gt 'mey_tamara_events', 'next_meet', zz_stage + 1
		else
			$npc['45,qwTamara'] = 2
			! перевод стадий квестов Вики и Кати
			if $npc['15,qwVika'] = 27:
				$npc['15,qw_day'] = day
				$npc['15,qwVika'] = 30
			end
			if $npc['14,qwKatya'] = 15: $npc['14,qwKatya'] = 20
			! ---
			gs 'zz_render', '', '', func('mey_tamara_strings', 'next_tea8')
			killvar 'zz_stage'
			act 'Уйти': gt 'gorodok'
			act 'Остаться на ночь': gt 'mey_home'
		end
	end
end
! обучение, начало
if $args[0] = 'learning0':
	*clr & cla
	$_img = 'pavlovo/meynolds/tamara/learning/'
	gs 'zz_render', '', $_img + 10, func('mey_tamara_strings', 'learning10')
	act '...':
		*clr & cla
		gs 'zz_render', '', $_img + 11, func('mey_tamara_strings', 'learning11')
		act 'Танцевать':
			*clr & cla
			gs 'zz_render', '', $_img + 10, func('mey_tamara_strings', iif(dance < 50,'learning12',iif(dancePRO < 50,'learning13','learning14')))
			act 'Хм...':
				*clr & cla
				gs 'zz_render', '', $_img + 10, func('mey_tamara_strings', 'learning15')
				if vnesh < 40: gs 'zz_render', '', '', func('mey_tamara_strings', 'learning16')
				if vnesh >= 40 and vnesh < 60: gs 'zz_render', '', '', func('mey_tamara_strings', 'learning17')
				if vnesh >= 60 and vnesh < 80: gs 'zz_render', '', '', func('mey_tamara_strings', 'learning18')
				if vnesh >= 80: gs 'zz_render', '', '', func('mey_tamara_strings', 'learning19')
				killvar '$_img'
				act 'Ехать в город': gt 'mey_tamara_events', 'learning1'
			end
		end
	end
end
! обучение, поездка в город
if $args[0] = 'learning1':
	*clr & cla
	minut += 30
	$_img = 'pavlovo/meynolds/tamara/learning/'
	gs 'stat'
	gs 'zz_render', '',func('zz_funcs','mk_image',$_img+'go_city'), func('mey_tamara_strings', 'learning25')
	act '...':
		*clr & cla
		gs 'zz_render', '', $_img + 26, func('mey_tamara_strings', 'learning26')
		!128 - 148
		newdress_id = rand(128,148)
		gs 'zz_clothing', 'init_clothing'
		gs 'zz_clothing', 'add_to_wardrobe', newdress_id
		gs 'zz_render', '', '', '<green>Молодёжный наряд ' + (newdress_id - 127) + '</green>'
		newdress_id = iif(newdress_id >= 138,rand(128,137),rand(138,148))
		gs 'zz_clothing', 'add_to_wardrobe', newdress_id
		gs 'zz_render', '', '', '<green>Молодёжный наряд ' + (newdress_id - 127) + '</green>'
		if func('zz_clothing','is_exists', 157) < 0:
			gs 'zz_clothing', 'add_to_wardrobe', 157
			zz_added = 1
		end
		gs 'zz_clothing', 'dispose'
		killvar 'newdress_id'
		act '...':
			*clr & cla
			gs 'zz_render', '', $_img + 20, func('mey_tamara_strings', 'learning20')
			act 'В салон красоты':
				*clr & cla
				gs 'zz_render', '', $_img + 29, func('mey_tamara_strings', 'learning29')
				tan = 10
				resnic = 2
				skin = 4
				if shorthair <= iif(cheatHapri = 0,0,2): curly += 7
				hapri = 1
				brow = 10
				lobok = 0
				lipbalmstat = 1
				mop = 3
				hour = 19
				minut = 40
				gs 'stat'
				act 'Идти дальше':
					*clr & cla
					gs 'zz_render', '', $_img + 21, func('mey_tamara_strings', 'learning21')
					if zz_added = 0:
						gs 'zz_render', '', '', func('mey_tamara_strings', 'learning23')
						$npc['45,qwTamara'] = 6
						killvar 'zz_added'
						act 'Я успею': gt 'down'
					else
						cla
						minut += 20
						killvar 'zz_added'
						gs 'stat'
						gs 'zz_render', '', '', func('mey_tamara_strings', 'learning22')
						act 'Ехать домой': $npc['45,qwTamara'] = 10 & minut += 30 & gt 'mey_home', 0
						act 'Остаться в городе':
							cla
							gs 'zz_render', '', '', func('mey_tamara_strings', 'learning24')
							act 'Я успею': $npc['45,qwTamara'] = 6 & gt 'down'
							act 'Ехать домой': $npc['45,qwTamara'] = 10 & minut += 30 & gt 'mey_home', 0
						end
					end
				end
			end
		end
	end
end
! тм ожидает гг возле ресторана
if $args[0] = 'wait_qw':
	*clr & cla
	gs 'zz_render', '', 'images/pic/restoran.jpg', func('mey_tamara_strings', 'learning28')
	act 'Ехать домой': $npc['45,qwTamara'] = 10 & minut += 30 & gt 'mey_home', 0
end
! преступление и наказание
if $args[0] = 'rebuke':
	*clr & cla
	$_img = 'pavlovo/meynolds/tamara/'
	gs 'zz_render','','pavlovo/meynolds/home/door', func('mey_tamara_strings', 'rebuke0')
	act 'Позвонить еще раз...':
		cla
		gs 'zz_render','','pavlovo/meynolds/home/ringer',func('mey_tamara_strings','rebuke1')
		act '...':
			*clr & cla
			gs 'zz_render','', $_img + 'learning/10',func('mey_tamara_strings','rebuke2')
			act 'Войти':
				*clr & cla
				gs 'zz_render','', $_img + 'rebuke/3',func('mey_tamara_strings','rebuke3')
				act '...':
					*clr & cla
					gs 'zz_render','', $_img + 'rebuke/4.jpg',func('mey_tamara_strings','rebuke4')
					act '...':
						*clr & cla
						gs 'zz_render','', $_img + 'rebuke/5',func('mey_tamara_strings','rebuke5')
						act '...':
							cla
							gs 'zz_render','','',func('mey_tamara_strings', iif(school['progress'] < 80,'rebuke6','rebuke7')) + func('mey_tamara_strings', iif(school['progress'] >= 80,'rebuke8','rebuke9'))
							act '...':
								*clr & cla
								minut += 30
								$npc['45,qwTamara'] = 7
								gs 'zz_render','',$_img + 'rebuke/10', func('mey_tamara_strings', 'rebuke10')
								killvar '$_img'
								act 'Уйти': gt 'mey_home', 0
							end
						end
					end
				end
			end
		end
	end
	act 'Уйти':
		minut += 10
		gt 'gorodok'
	end
end
! тм говорит гг о корпоративе
if $args[0] = 'party0':
	*clr & cla
	gs 'zz_render', '', 'pavlovo/meynolds/tamara/party/0', func('mey_tamara_strings', 'party0')
	act 'Отказаться':
		cla
		! закрываем ивент до следующего месяца
		$npc['45,qwTamara'] = 40
		gs 'zz_render', '', '', func('mey_tamara_strings', 'party1')
		act 'Отойти': gt 'mey_home', 0
	end
	act 'Согласиться':
		cla
		! надо привести себя в божеский вид
		$npc['45,qwTamara'] = 16
		gs 'zz_render', '', '', func('mey_tamara_strings', 'party2')
		act 'Отойти': gt 'mey_home', 0
	end
end
! проверка внешности
if $args[0] = 'check_look':
	*clr & cla
	! платье, средняя расскраска, чистая, внешность сногсшибательная
	if func('zz_clothing','is_glamour') >= 1 and hapri = 1 and (mop = 2 or mop = 3) and sweat <= 0 and vnesh >= 60:
		! если длинные волосы - требуем укладку
		if shorthair = 0 and curly = 0:
			gs 'zz_render', '', 'pavlovo/meynolds/tamara/party/0', func('mey_tamara_strings', 'party4')
			act 'Отойти': gt 'mey_home', 0
		else
			gs 'zz_render', '', 'pavlovo/meynolds/tamara/party/0', func('mey_tamara_strings', 'party3')
			act 'Ехать на корпоратив': gt 'mey_tamara_events', 'party1'
		end
	else
		gs 'zz_render', '', 'pavlovo/meynolds/tamara/party/0', func('mey_tamara_strings', 'party4')
		act 'Отойти': gt 'mey_home', 0
	end
end
! корпоратив, начало
if $args[0] = 'party1':
	*clr & cla
	minut += 30
	gs 'zz_render', '', 'images/pic/restoran.jpg', func('mey_tamara_strings', 'party5')
	act 'Понятно':
		*clr & cla
		$_img = 'pavlovo/meynolds/tamara/party/'
		gs 'zz_render', '', $_img + 6, func('mey_tamara_strings', 'party6')
		act 'Осмотреться':
			*clr & cla
			gs 'zz_render', '', $_img + 7, func('mey_tamara_strings', 'party7')
			act 'Пройтись по залу':
				*clr & cla
				gs 'zz_funcs', 'alko'
				gs 'stat'
				gs 'zz_render', '', $_img + 8, func('mey_tamara_strings', 'party8')
				act '...':
					*clr & cla
					gs 'zz_render', '', $_img + 9, func('mey_tamara_strings', 'party9')
					act '...':
						*clr & cla
						gs 'zz_funcs', 'alko', 2
						gs 'stat'
						gs 'zz_render', '', $_img + 10, func('mey_tamara_strings', 'party10')
						!killvar '$_img'
						act '...': gt 'mey_tamara_events', 'party2'
					end
				end
			end
		end
	end
end
! корпоратив, вторая фаза
if $args[0] = 'party2':
	*clr & cla
	if hour = 2:
		gs 'zz_render', '', 'images/pic/restoran.jpg', func('mey_tamara_strings', 'party32')
		act 'Ехать домой': minut += 30 & gt 'mey_home', 0
		exit
	end
	gs 'zz_render', '', $_img + rand(8,10), func('mey_tamara_strings', 'party11')
	act 'Пробовать закуски':
		*clr & cla
		if energy < 24:
			if alko > 0: alko -= 1
			energy += 1
		end
		minut += 10
		gs 'stat'
		gs 'zz_render', '', $_img + 12, func('mey_tamara_strings', 'party12')
		act 'Отойти от стола': gt 'mey_tamara_events', 'party2'
	end
	act 'Взять бокал шампанского':
		*clr & cla
		gs 'zz_funcs', 'alko'
		gs 'stat'
		gs 'zz_render', '', $_img + 7, func('mey_tamara_strings', 'party13')
		act 'Отойти от стола': gt 'mey_tamara_events', 'party2'
	end
	act 'Пройтись по залу':
		*clr & cla
		minut += 10
		gs 'stat'
		gs 'zz_render', '', $_img + 9, func('mey_tamara_strings', 'party14')
		if alko >= 3:
			if mesec = 0 and vagina > 0 and $npc['45,drink_qw'] = 0:
				act 'Искать приключения':
					minut += rand(30,40)
					gs 'stat'
					gt 'mey_tamara_events', 'party4'
				end
			else
				act 'Пойти в машину проспаться': gt 'mey_tamara_events', 'party3'
			end
		else
			if $npc['45,builder_qw'] = 0: gt 'mey_tamara_events', 'party5'
			if $npc['45,bronson_qw'] = 0: gt 'mey_tamara_events', 'party6'
			gt 'mey_tamara_events', 'party2'
		end
	end
	if hour = 23 or hour < 2:
		act 'Ехать домой':
			killvar '$_img'
			minut += 30
			gt 'mey_home', 0
		end
	end
end
! пьянь, спит в машине
if $args[0] = 'party3':
	*clr & cla
	gs 'zz_render', '', $_img + 15, func('mey_tamara_strings', 'party15')+'<br>'+func('mey_tamara_strings', 'party31')
	$npc['45,qwTamara'] = 50
	hour = 23
	minut = 55
	manna -= 20
	son += 3
	gs 'stat'
	killvar '$_img'
	act '...': gt 'mey_home', 3
end
! пьянь, секас
if $args[0] = 'party4':
	*clr & cla
	zz_stage = args[1]
	if zz_stage = 0: zz_stage = 16
	gs 'zz_render', '', $_img + zz_stage, func('mey_tamara_strings', 'party'+zz_stage)
	if zz_stage < 24:
		if zz_stage = 17:
			act 'Отказаться':
				$npc['45,drink_qw'] = 1
				gt 'mey_tamara_events', 'party2'
			end
		end
		act '...': gt 'mey_tamara_events', 'party4', zz_stage+1
	else
		killvar 'zz_stage'
		act 'Ждать...':
			*clr & cla
			$npc['45,qwTamara'] = 50
			$npc['45,drink_qw'] = 1
			hour = 23
			minut = 55
			manna -= 20
			if alko > 0: alko -= 1
			son += 3
			gs 'stat'
			gs 'zz_render', '', $_img + 15, func('mey_tamara_strings', 'party31')
			killvar '$_img'
			act 'В свою комнату': gt 'mey_home', 3
		end
	end
end
! знакомство с жирдяем
if $args[0] = 'party5':
	*clr & cla
	gs 'zz_render', '', $_img + 25, func('mey_tamara_strings', 'party25')
	act '...':
		*clr & cla
		gs 'zz_render', '', $_img + 26, func('mey_tamara_strings', 'party26')
		act '...':
			*clr & cla
			$npc['45,builder_qw'] = 1
			minut += 15
			gs 'zz_render', '', $_img + 27, func('mey_tamara_strings', 'party27')
			act 'Пройтись по залу': gt 'mey_tamara_events', 'party2'
		end
	end
end
! знакомство с бронсоном
if $args[0] = 'party6':
	*clr & cla
	gs 'zz_render', '', $_img + 28, func('mey_tamara_strings', 'party28')
	act '...':
		*clr & cla
		gs 'zz_render', '', $_img + 29, func('mey_tamara_strings', 'party29')
		act 'Идти':
			*clr & cla
			$npc['45,bronson_qw'] = 1
			minut += 15
			gs 'zz_render', '', '', func('mey_tamara_strings', 'party30')
			act 'Пройтись по залу': gt 'mey_tamara_events', 'party2'
		end
	end
end
! падение репутации
if $args[0] = 'reputation':
	*clr & cla
	zz_stage = args[1]
	gs 'zz_render', '', 'pavlovo/meynolds/tamara/reputation/'+zz_stage+iif(zz_stage!3,'.jpg','.gif'), func('mey_tamara_strings', 'reputation'+zz_stage)
	if zz_stage < 11:
		act '...': gt 'mey_tamara_events', 'reputation', zz_stage+1
		exit
	else
		killvar 'zz_stage'
		act 'Уйти':
			$npc['45,reputation_qw'] = 1
			minut += rand(20,40)
			GorSlut -= 2
			horny = 0
			spanked += 40
			gt 'mey_home', 3
		end
	end
end