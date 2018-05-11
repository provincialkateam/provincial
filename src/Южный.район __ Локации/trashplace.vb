if $args[0] = '':
	*clr & cla
	gs 'stat'
	gs 'time'
	if anus > 10 and vagina > 10 and mesec = 0 and func('zz_weather','is_day') = 1 and city['cherdak'] = 3 and city['cherdak_day'] ! day and rand(0,10) > 8:
		gt 'front_door_event','front_ev1_init'
	end
	gs 'zz_render','','images/pic/musorka.jpg', func('trashplace_strings', 'local_str25')
	if bumtolik = 3 and func('zz_weather','is_day') = 1 and RAND(0,100) >= 50:
		*clr & cla
		gs 'zz_render','','images/etogame/bumt2.jpg', func('trashplace_strings', 'local_str27')
		act 'Поинтересоваться для чего ей это нужно':
			*clr & cla
			minut += 5
			bumtolik = 4
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/bumt4.jpg', func('trashplace_strings', 'local_str10')
			act 'Уйти': gt 'homeyard'
		end
	end
	if take_out_trash > 0:
		act 'Выбросить мусор':
			*clr & cla
			minut += 5
			take_out_trash = 0
			garbage = 0
			gs 'stat'
			gs 'zz_render','','pic/musorka.jpg', func('trashplace_strings', 'local_str29')
			if bumtolik = 0:
				gs 'zz_render','','',func('trashplace_strings', 'local_str31')
				act 'Посмотреть кто это сказал':
					*clr & cla
					bumtolik = 1
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/etogame/bum.jpg', func('trashplace_strings', 'local_str1')
					act 'Уйти': gt 'homeyard'
				end
			else
				gs 'zz_render','','images/etogame/bum.jpg',func('trashplace_strings', 'local_str32')
				act 'Взглянуть на бомжа':
					*clr & cla
					if bumtolik < 2: bumtolik = 2
					minut += 5
					gs 'stat'
					gs 'zz_render','','', func('trashplace_strings', 'local_str2')
					act 'Спросить что ему нужно':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render','','', func('trashplace_strings', 'local_str3')
						if money >= 200:
							act 'Дать ему 200 рублей':
								cla
								minut += 5
								if bumtolik < 3: bumtolik = 3
								money -= 200
								gs 'stat'
								gs 'zz_render','','',func('trashplace_strings', 'local_str5')
								act 'Уйти': gt 'homeyard'
							end
						end
						act 'Уйти': gt 'homeyard'
					end
					act 'Уйти': gt 'homeyard'
				end
			end
			act 'Отойти от бака': gt $CURLOC
		end
	end
	act 'Уйти': gt 'homeyard'
end