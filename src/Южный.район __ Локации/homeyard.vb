if $args[0] = '':
	*clr & cla
	$loc = $curloc
	$metka = ''
	minut += 5
	gs 'stat'
	gs 'time'
	! миник
	if $npc['0,mini_event_day'] ! day and rand(0,10) < 4 and func('zz_weather','is_day') = 1 and $settings['mini_events'] = 1:
		gt 'homeyard_mini', 'start'
	end
	gs 'zz_render','',func('zz_funcs','mk_image','city/south/homeyard/homeyard'),'Уютный дворик дома. Посерёдке расположилась детская площадка, где можно покататься на качельке.
	Справа от площадки находится небольшая беседка, где по вечерам в хорошую погоду мужики рубятся в доминошку, и старенький турник. Идиллию портит расположенная чуть ближе к выезду мусорка.'
	gs 'car','check'
	! свидания
	if housr = 1 and hour = meethour:
		if svidanieA = 1: gs 'zz_render', '', '','<b>Около подъезда вас ожидает <a href="exec:GT ''meet'',''start''"><<$boyA>></a></b>'
		if svidanieB = 1: gs 'zz_render', '', '','<b>Около подъезда вас ожидает <a href="exec:GT ''svidan'',''start''"><<$boyB>></a></b>'
		if svidanieC = 1: gs 'zz_render', '', '','<b>Около подъезда вас ожидает <a href="exec:GT ''svidan'',''start''"><<$boyC>></a></b>'
	end
	if housr = 1:
		act '<b>В дом</b>': gt 'front_door','start'
		if func('zz_weather','is_day') = 1:
			if sunWeather >= 0:
				if temper >= 5:
					!act 'Подойти к мужикам':
					!	место для ивентов с мужиками
					!end
					act 'Кататься на качели':
						*clr & cla
						manna += rand(10,15)
						minut += rand(10,15)
						gs 'stat'
						if func('zz_clothing2','is_skirt') = 1 and cloth[1] = 0:
							if shameless['flag'] > 0:
								gs 'zz_render','','city/south/homeyard/0,0','Вы раскачиваетесь на качелях, ощущая под подолом ветерок неприкрытой бельём киской.'
								!место для запуска какого-нибудь ивента
							else
								gs 'zz_render','','images/common/beach/shyness.jpg','Хочется покачаться на качелях, но памятуя что нижнего белья на вас нет, и все об этом тут же узнают, стоит задраться случайно подолу, вы с сожалением отходите от качелей.'
							end
						else
							gs 'zz_render','','city/south/homeyard/0,1','Вы весело раскачиваетесь на качельке, вспоминая беззаботное детство.'
						end
						act 'Уйти': gt 'homeyard'
					end
				end
				if workout < 3 and func('zz_clothing2','get_group') = 1 and sick <= 0:
					if temper >= 5:
						act 'Подтягиваться на турнике':
							*clr & cla
							workout += 1
							manna += rand(1,5)
							minut += rand(10,15)
							gs 'zz_funcs','sport'
							gs 'stat'
							if func('zz_clothing2','is_skirt') = 1 and cloth[1] = 0:
								if shameless['flag'] > 0:
									gs 'zz_render','','city/south/homeyard/1,0','Помио подтягиваний вы решили сделать на турнике ещё пару других упражнений, совершенно не заботясь о том, что могут увидеть случайные прохожие.'
									!место для запуска какого-нибудь ивента
								else
									gs 'zz_render','','images/common/beach/shyness.jpg','Хочется немножко размять мышцы рук, но памятуя, что нижнего белья на вас нет, а ветер может сделать так, что все об этом тут же узнают, вы с сожалением отходите от турника.'
								end
							else
								gs 'zz_render','','city/south/homeyard/1,1','Вы несколько раз подтягиваетесь и отходите от турника.'
							end
							act 'Отойти': gt 'homeyard'
						end
					end
					act 'Пробежаться во дворике':
						*clr & cla
						gs 'zz_common','crossing'
						act 'Отойти': gt 'homeyard'
					end
				end
			end
			act 'Идти к мусорке': gt 'trashplace'
			act '<b>На улицу</b>': gt 'south'
		end
	end
end