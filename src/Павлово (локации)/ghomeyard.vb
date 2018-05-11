if $args[0] = '':
	*clr & cla
	$loc = $curloc
	$metka = ''
	minut += 5
	gs 'stat'
	gs 'time'
	act '<b>На улицу</b>': minut += 5 & gt 'gorodok'
    act '<b>В подъезд</b>': minut += 1 & gt 'pod_ezd','etaj_1'
	! миник
	if $npc['0,mini_event_day'] ! day and rand(0,10) < 4 and func('zz_weather','is_day') = 1 and $settings['mini_events'] = 1:
		gt 'homeyard_mini', 'start'
	end
	gs 'zz_render','',func('zz_funcs','mk_image','pavlovo/homeyard/homeyard'),'Двор вашего дома: посерёдке расположилась детская площадка с песочницей под грибком и качелями и пара лавочек.
	Рядом с детской площадкой находится небольшая беседка, где по вечерам в хорошую погоду мужики рубятся в доминошку, и старенький турник.'
	gs 'car','check'
    !Гопники Котов & Co на лавочке
    if sunWeather >= 0 and temper > 0 and hour = 23:
		gs 'zz_render','','','Вы видите сидящих на лавочке с неизменным пивасом <a href="exec: gt''gopskver''">Витька Котова, Дэна Рыжова и Шульгу.</a>'
	end
    !бабульки у подъезда
    if hour = 7 or hour = 8:
        gs 'zz_render','','','<a href="exec:GT ''short_random'',''babushki''">Бабульки</a> как обычно заседают на лавочке у подъезда. Сколько вы себя помните - они здесь всегда сидят, обсуждая увиденное в "тиливизере" и всех мимо проходящих.'
    end
    ! птушники подкатывают к Светке-давалке
    if func('zz_weather','is_day') = 1 and hour >= 12 and rand(0,5) = 1 and $npc['0,park_slut_event'] ! day and shameless['flag'] >= 3 and mesec = 0:
	    gt 'park_events',iif($npc['0,park_slut_counter'] <= 5,'slut_ev1','slut_ev5')
    end
    if func('zz_weather','is_day') = 1:
        if sunWeather >= 0:
            if temper >= 5:
                !act 'Подойти к мужикам':
                !   место для ивентов с мужиками
                !end
                act 'Качаться на качелях':
                    *clr & cla
                    manna += rand(10,15)
                    minut += rand(10,15)
                    gs 'stat'
					if func('zz_clothing2','is_skirt') = 1 and cloth[1] = 0:
						if shameless['flag'] > 0:
							gs 'zz_render','','city/south/homeyard/0,0','Вы раскачиваетесь на качелях, ощущая под подолом ветерок неприкрытой бельём киской'
							!место для запуска какого-нибудь ивента
						else
							gs 'zz_render','','images/common/beach/shyness.jpg','Хочется покачаться на качелях, но памятуя, что нижнего белья на вас нет, а все об этом тут же узнают, стоит задраться случайно подолу, вы с сожалением отходите от качелей.'
						end
					else
						gs 'zz_render','','city/south/homeyard/0,1','Вы весело раскачиваетесь на качельке, вспоминая беззаботное детство.'
					end
                    act 'Уйти': gt 'ghomeyard'
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
								gs 'zz_render','','city/south/homeyard/1,0','Помио подтягиваний вы решили сделать на турнике еще пару других упражнений, совершенно не заботясь о том, что могут увидеть случайные прохожие.'
								!место для запуска какого-нибудь ивента
							else
								gs 'zz_render','','images/common/beach/shyness.jpg','Хочется немножко размять мышцы рук, но памятуя, что нижнего белья на вас нет, а ветер может сделать так, что все об этом тут же узнают. Вы с сожалением отходите от турника.'
							end
						else
							gs 'zz_render','','city/south/homeyard/1,1','Вы несколько раз подтягиваетесь и отходите от турника.'
						end
                        act 'Закончить': gt 'ghomeyard'
                    end
                end
                act 'Пробежаться во дворике':
                    *clr & cla
                    gs 'zz_common','crossing'
                    act 'Закончить пробежку': gt 'ghomeyard'
                end
            end
        end
        act '<b>На улицу</b>': minut += 5 & gt 'gorodok'
    end
end