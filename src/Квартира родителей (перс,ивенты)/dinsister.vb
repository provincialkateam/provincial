if $args[0] = 'talk':
	if $npc['38,relation'] < 40:
		gs 'zz_render','','',func('dinsister_strings', iif($npc['38,relation']<20,26,30))
		if sistersorryday ! day:
			act 'Просить прощения':
				cla
				sistersorryday = day
				gs 'npc_editor','change_rep','+', 38, 10
				gs 'zz_render','','', func('dinsister_strings', iif($npc['38,relation']<20,28,31))
				act '<B>Отойти</B>': gt $loc, $metka
			end
		end
	else
		gs 'zz_render','','',func('dinsister_strings', 32) + func('dinsister_strings', rand(33,65))
	end
end
if $args[0] = 'sex_stories':
	gs 'zz_render','','pavlovo/family/sister/sister' + (i+1) + '.jpg', func('dinsister_strings', rand(66,72))
end
if $args[0] = 'piercing':
	if pirsA >= 1 and pirsAsister = 0 and sisterpirsadaytalk ! day:
		! пирсинг языка
		sisterpirsadaytalk = day
		if rand(1,100) >= 75:
			gs 'zz_render','','', func('dinsister_strings', 1)
			act 'Ничего':
				cla
				gs 'zz_render','','', func('dinsister_strings', 2)
				act '<B>Отойти</B>': gt $loc, $metka
			end
			act 'Показать пирсинг языка':
				*clr & cla
				pirsAsister = 1
				gs 'zz_render','','images/picb/piercing/pirsA.jpg', func('dinsister_strings', 3)
				act '<B>Отойти</B>': gt $loc, $metka
			end
		end
		exit
	end
	if pirsB = 1 and pirsBsister = 0:
		! пирсинг губ
		gs 'zz_render','','', func('dinsister_strings', 4)
		act 'Спасибо':
			*clr & cla
			pirsBsister = 1
			gs 'zz_render','','images/picb/piercing/pirsB.jpg', func('dinsister_strings', 5)
			act '<B>Отойти</B>': gt $loc, $metka
		end
		exit
	end
	if pirsC = 1 and pirsCsister = 0:
		! сережки
		pirsCsister=1
		gs 'zz_render','','', func('dinsister_strings', 6)
		exit
	end
	if pirsD = 1 and pirsDsister = 0:
		! кольцо в носу
		pirsDsister=1
		gs 'zz_render','','', func('dinsister_strings', 7)
		exit
	end
	if pirsE = 1 and pirsEsister = 0:
		! пирсинг брови
		pirsEsister=1
		gs 'zz_render','','', func('dinsister_strings', 8)
		exit
	end
end
if $args[0] = 'sister_show':
	*clr & cla
	gs 'zz_render','','pavlovo/family/sister/dreaming00.jpg', func('dinsister_strings', 9)
	act '...':
		*clr & cla
		horny += 20
		minut += 2
		gs 'stat'
		gs 'zz_render','','pavlovo/family/sister/dreaming01.jpg', func('dinsister_strings', 10)
		act '...':
			*clr & cla
			horny += 20
			minut += 2
			gs 'stat'
			gs 'zz_render','','pavlovo/family/sister/dreaming02.jpg', func('dinsister_strings', 11)
			act '...':
				*clr & cla
				horny += 20
				minut += 1
				sister_show = 1
				gs 'stat'
				gs 'zz_render','','pavlovo/family/sister/dreaming03.jpg', func('dinsister_strings', 12)
				act '...': gt 'korrPar'
			end
		end
	end
end
! ивенты на пляже с сестрой
if $args[0] = 'beach_events':
	*clr & cla
	! выводим на экран, рандомно выбираем текст
	gs 'zz_render','','pavlovo/family/sister/beach_ev/0', func('dinsister_strings', rand(73,76))
	! действия
	act 'Играть в волейбол':
		*clr & cla
		minut += rand(40,60)
		gs 'zz_funcs','sport'
		gs 'stat'
		gs 'zz_render','','pavlovo/family/sister/beach_ev/0/<<rand(0,2)>>', func('dinsister_strings', 13)
		act 'Отойти': gt 'glake'
	end
	act 'Плавать':
		*clr & cla
		minut += rand(10,20)
		gs 'zz_bathroom','clean_me'
		gs 'stat'
		gs 'zz_render','','pavlovo/family/sister/beach_ev/1/<<rand(0,2)>>', func('dinsister_strings', 14)
		act 'Плавать самой':
			*clr & cla
			gs 'zz_render','','pavlovo/family/sister/beach_ev/2/<<rand(0,2)>>', func('dinsister_strings', 15)
			act '...': gt 'glake'
		end
		act 'Плавать с Аней':
			*clr & cla
			if horny >= 70 and sisboytrio > 0 and $npc['38,wedding'] = 0:
				gs 'zz_render','','pavlovo/family/sister/beach_ev/3/<<rand(0,1)>>', func('dinsister_strings', 16)
				act 'Поцеловать':
					*clr & cla
					gs 'zz_render','','pavlovo/family/sister/beach_ev/4/<<rand(0,2)>>', func('dinsister_strings', 17)
					act 'Вернуться и самой': gt 'glake'
				end
			else
				gs 'zz_render','','pavlovo/family/sister/beach_ev/5/<<rand(0,2)>>', func('dinsister_strings', 18)
				act '...': gt 'glake'
			end
		end
	end
	act 'Я лучше позагораю':
		*clr & cla
		gs 'zz_render','','pavlovo/family/sister/beach_ev/6/<<rand(0,2)>>', func('dinsister_strings', 19)
		act 'Лечь':
			*clr & cla
			minut += rand(5,10)
			horny += rand(2,7)
			gs 'stat'
			gs 'zz_render','','pavlovo/family/sister/beach_ev/7/0', func('dinsister_strings', 20)
			act 'Намажь мне ещё животик':
				*clr & cla
				minut += rand(2,5)
				gs 'stat'
				gs 'zz_render','','pavlovo/family/sister/beach_ev/7/0', func('dinsister_strings', 21)
				act 'Перевернуться на спину':
					*clr & cla
					minut += rand(2,5)
					gs 'stat'
					gs 'zz_render','','pavlovo/family/sister/beach_ev/8/0', func('dinsister_strings', 22)
					if horny >= 70 and sisboytrio > 0:
						act 'Оголить грудь':
							*clr & cla
							gs 'zz_render','','pavlovo/family/sister/beach_ev/9/0', func('dinsister_strings', 23)
							act 'Загорать':
								*clr & cla
								minut += rand(2,5)
								horny += rand(2,7)
								gs 'stat'
								gs 'zz_render','','pavlovo/family/sister/beach_ev/6/2', func('dinsister_strings', 24)
								act '...':
									minut += rand(15,30)
									manna += 5
									tan += iif(sunWeather < 2,1,2)
									sweat += iif(temper < 22,0,iif(temper < 30,1,2))
									gt 'glake'
								end
							end
						end
					end
					act 'Спасибо!':
						*clr & cla
						gs 'zz_render','','pavlovo/family/sister/beach_ev/6/1', func('dinsister_strings', 25)
						act '...':
							minut += rand(15,30)
							manna += 5
							tan += iif(sunWeather < 2,1,2)
							sweat += iif(temper < 22,0,iif(temper < 30,1,2))
							gt 'glake'
						end
					end
				end
			end
		end
	end
end