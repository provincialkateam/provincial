if $ARGS[0] = 'field':
    $metka = $ARGS[0]
    $loc = $CURLOC
    *clr & cla
    gs 'stat'
    gs 'time'
    $_str = 'Поле'
    gs 'zz_render', $_str, func('zz_funcs','mk_image','qwest/gadukino/gadfield/gadfield'), 'Поле за деревней.'
    if month > 4 and month < 10:
		if hour >= 9 and hour <= 19 and week < 6 :gs 'zz_render', '', '','На поле пасется дедушкин конь <a href="exec: gt ''gadfield'',''horse''">Буян</a>.'
		if hour >= 9 and hour <= 19 and graze_cow = 0 or hour >= 6 and hour <= 20 and graze_cow = 1:gs 'zz_render', '', '','На поле вы видите <a href="exec: gt ''gadfield'',+iif(graze_cow = 0,''graze_field'',iif(hour < 13,''graze_field'',iif(hour < 16,''watering_place'',''forest_field'')))">стадо коров</a>.'
		if hour >= 7 and hour <= 20 and haying_time = 1:
			gs 'zz_render', '', '','На поле вы видите толпу местных жителей.'
			act 'Отправиться на сенокос':
				*clr & cla
				minut += 360
				grandmahelp += 1
				grandpaQW += 1
				water += 10
				energy += 10
				haying_time = 0
				gs 'stat'
				if miraQW >= 15 and rand(0,1) = 0:
					miraQW += 1
					gs 'zz_render', $_str, 'qwest/gadukino/gadfield/haying_time_mira.jpg','На сенокос собралася практически вся деревня, и вы  тоже приняли посильное участие в работе. В принципе было весело, особенно учитывая, что большую часть времени вы проболтали с Мирой, валяясь на свежем сене.'
				else
					body['day_weight'] -= 1
					stren += iif(stren<30,1,rand(0,1))
					agil += iif(agil<30,1,rand(0,1))
					vital += iif(vital<30,1,rand(0,1))
					gs 'zz_funcs', 'sport', 3
					gs 'zz_render', $_str, 'qwest/gadukino/gadfield/haying_time.jpg','На сенокос собралася практически вся деревня, и вы тоже приняли посильное участие в работе.'
				end
				act 'Далее':gt'gadfield','field'
			end
		end
	end
	act 'Вернуться на дорогу':
		killvar '$_str'
		minut += 10
		gt 'gadroad'
	end
end
if $ARGS[0] = 'horse':
	*clr & cla
	gs 'stat'
	gs 'time'
	gs 'zz_render', 'Буян', 'gadukino/horse/field.jpg','Дедушкин конь Буян.'
	if hour = 19:
		act 'Отвести коня домой':
			*clr & cla
			minut += 60
			grandmahelp += rand(0,1)
			grandpaQW += rand(0,1)
			killvar '$_str'
			gs 'stat'
			gs 'zz_render', 'Буян', 'gadukino/horse/lead.jpg','Увидев коня в поле, вы решили помочь дедушке, и отвести Буяна домой. Взяв коня под уздцы, вы отправились с ним в сторону деревни.'
			act 'Далее':gt'Gadsarai'
		end
    end
    act 'Назад':gt'gadfield','field'
end
if $ARGS[0] = 'graze_field':
    $metka = $ARGS[0]
    $loc = $CURLOC
    *clr & cla
    $_str = 'Поле'
	gs'stat'
	gs'time'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/cow.jpg','Стадо деревенских коров стоит посреди поля.'+iif(mira = 1,'**Рядом с вами сидит <a href="exec: gt ''Miroslava''">Мира</a>.','')
    if hour = 19 and graze_cow = 0:
		act 'Отвести корову домой':
			*clr & cla
			minut += 60
			grandmahelp += rand(0,1)
			grandpaQW += rand(0,1)
			gs 'stat'
			gs 'zz_render', '', 'gadukino/new/cow_field.jpg','Увидев стадо в поле, вы решили помочь дедушке, и отвести Зорьку домой..'
			act 'Далее': gt'Gadsarai'
		end
    end
    if graze_cow = 1:
        if hour < 10:
            act 'Ждать пока соберется стадо':
			    *clr & cla
                minut += 120
                hour = 10
                minut = 0
                gs 'stat'
                gs 'zz_render', $_str, 'images/qwest/gadukino/gadfield/graze_cow_wait.jpg','В течение некоторого времени вы ждете, пока все местные пригонят своих коров' + iif(graze_cow_exp = 0,'.',', и придет дед с Зорькой.')
                act 'Далее':gt'gadfield','graze_field'
            end
        elseif hour >= 10 and hour < 13:
            act 'Пасти коров с дедом': gt'gadfield','graze_cow'
            if sunWeather >= 0  and mira = 0:
				if daybegskver ! daystart: act 'Бегать по полю': gt'gadfield','run'
				if temper >= 20:
					act 'Загорать': gt'gadfield','sunbathe'
					if son < 17: act 'Вздремнуть на траве': gt'gadfield','sleep'
					act 'Собирать цветы': gt'gadfield','flowers'
					if reading['in_bag'] >= 0: act 'Читать '+func('zz_books','get_name',reading['in_bag']): gt 'zz_books','read_on_walk'
					if miraQW >= 15 and mira = 0 and rand(1,5) = 1 and Mira_no = 0 and(mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1) and miraday ! day: gt'gadfield','mira'
				end
            end
        else
            *clr & cla
	        grandmahelp += 1
            minut += 60
            gs 'stat'
			gs 'zz_render', $_str, 'qwest/gadukino/gadfield/cow_go.jpg','Посмотрев на часы, дедушка казал, что уже обед и пора гнать стадо на водопой. Вместе вы принялись поднимать лежащих коров, направляя их в сторону реки.'
			killvar '$_str'
            act 'Далее':gt'gadfield','watering_place'
        end
    else
		act 'Назад':gt'gadfield','field'
	end
end
if $ARGS[0] = 'watering_place':
    $metka = $ARGS[0]
    $loc = $CURLOC
    *clr & cla
    $_str = 'Водопой'
    gs'stat'
    gs'time'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/cow_river.jpg', 'Стадо деревенских коров стоит у реки.'+iif(mira = 1,'**Рядом с вами сидит <a href="exec: gt ''Miroslava''">Мира</a>.','')+iif(temper >= 20 and sunWeather >= 0,'**\\\- Можешь искупнуться внучка, пока есть время. Я пригляжу за стадом, -/// сказал вам дедушка.','')
    if graze_cow = 1:
        if hour < 16:
			act 'Пасти коров с дедом': gt'gadfield','graze_cow'
            if temper >= 20 and sunWeather >= 0 and mira = 0:
                act 'Купаться': gt'gadfield','swim'
				act 'Загорать': gt'gadfield','sunbathe'
				if son < 17: act 'Вздремнуть на траве': gt'gadfield','sleep'
				if reading['in_bag'] >= 0: act 'Читать '+func('zz_books','get_name',reading['in_bag']): gt 'zz_books','read_on_walk'
            end
        else
            *clr & cla
	       	grandmahelp += 1
            minut += 60
            gs 'stat'
            gs 'zz_render', $_str, 'qwest/gadukino/gadfield/cow_go.jpg', 'Посмотрев на часы, дедушка казал, что пора гнать стадо обратно на поле, но теперь ближе к лесу. Вместе вы принялись собирать разбредшихся и стоящих в воде коров и направлять в сторону леса.'
            killvar '$_str'
            act 'Далее':gt'gadfield','forest_field'
        end
    end
end
if $ARGS[0] = 'forest_field':
    $metka = $ARGS[0]
    $loc = $CURLOC
    *clr & cla
    $_str = 'Поле у леса'
    gs'stat'
    gs'time'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/cow_forest.jpg', 'Стадо деревенских коров стоит на поле возле леса.'+iif(mira = 1,'**Рядом с вами сидит <a href="exec: gt ''Miroslava''">Мира</a>.','')
    if graze_cow = 1:
        if hour < 19:
            act 'Пасти коров с дедом': gt'gadfield','graze_cow'
            if sunWeather >= 0  and mira = 0:
				if daybegskver ! daystart: act 'Бегать по полю': gt'gadfield','run'
				if temper >= 20:
					act 'Загорать': gt'gadfield','sunbathe'
					if son < 17: act 'Вздремнуть на траве': gt'gadfield','sleep'
					act 'Собирать цветы': gt'gadfield','flowers'
					if reading['in_bag'] >= 0: act 'Читать '+func('zz_books','get_name',reading['in_bag']): gt 'zz_books','read_on_walk'
					if miraQW >= 15 and mira = 0 and rand(1,5) = 1 and Mira_no = 0 and(mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1): gt'gadfield','mira'
				end
            end
        else
            *clr & cla
            minut += 60
            mira = 0
            graze_cow = 0
            grandmahelp += 1
            grandpaQW += 1
            gs 'stat'
            gs 'zz_render', $_str, 'qwest/gadukino/gadfield/cow_go_home.jpg', 'Посмотрев на часы, дедушка казал, что уже поздно и пора гнать стадо домой. Коров дважды упрашивать не пришлось, они сами ломанулись в сторону деревни, а вы еле поспевали за ними.'
            killvar '$_str'
            act 'Далее':gt'gadukino'
        end
    end
end
if $ARGS[0] = 'graze_cow':
	*clr & cla
    minut += 60
    graze_cow_exp = 1
    grandmahelp += 1
    gs 'stat'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/graze_cow'+rand(1,4)+'.jpg','Вы в течение часа пасли деревенских коров. Вернее пас их дед, вы по большей части развлекались, ловя бабочек и валяясь в стогу сена.'
    act 'Далее': gt $loc, $metka
end
if $ARGS[0] = 'run':
	*clr & cla
	minut += 60
	manna += 15
	body['day_weight'] -= 1
	beg += RAND(3,6)
	gs 'zz_funcs', 'sport', 2
	speed += iif(speed < 40, 1,rand(0,1))
	if vital < 20:vital += 1
	daybegskver = daystart
    gs 'stat'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/graze_cow_run'+iif(mira = 1,'_mira','')+'.jpg','Вы, в течение часа, от нечего делать, носились по полю.'
    act 'Далее': gt $loc, $metka
end
if $ARGS[0] = 'sunbathe':
	*clr & cla
	minut += 30
    manna += 10
	if sunWeather <= 2:
		tan += iif(current_clothing > 0,rand(0,1),1)
	else
		tan += iif(current_clothing > 0,1,2)
	end
	hapri = 1
    sweat += iif(temper < 22,0,iif(temper < 30,1,2))
    gs 'stat'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/graze_cow_sun'+iif(mira = 1,'_mira2','')+'.jpg','В течение часа, бросив все, вы загорали.'
    act 'Далее': gt $loc, $metka
end
if $ARGS[0] = 'sleep':
	*clr & cla
	minut += 60
    manna += 10
    son += 4
    gs 'stat'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/graze_cow_lying.jpg','Вы легли на траву и сами не заметили как задремали, проспав в течение часа.'
    act 'Далее': gt $loc, $metka
end
if $ARGS[0] = 'flowers':
	*clr & cla
	minut += 60
    manna += 20
    gs 'stat'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/graze_cow_flowers.jpg','Вы в течение часа бродили по полю и собирали цветы.'
    act 'Далее': gt $loc, $metka
end
if $ARGS[0] = 'swim':
	*clr & cla
	minut += 30
	gs 'zz_bathroom', 'clean_me'
	if stren < 20: stren += 1
	horny -= iif(temper <= 25,10,5)
	manna += 10
    gs 'stat'
    gs 'zz_render', $_str, 'qwest/gadukino/gadfield/graze_cow_river'+iif(mira = 1,'_mira','')+'.jpg', 'Вы быстро искупнулись в речушке, пока есть время.'
    act 'Далее': gt $loc, $metka
end
if $ARGS[0] = 'mira':
	*clr & cla
    minut += 5
    miraQW += 1
    mira = 1
    miraday = day
    gs 'stat'
    gs 'zz_render', 'Мирослава', 'qwest/gadukino/Mira2.jpg','Оторвавшись от созерцания коров, вы заметили приближающуюся к вам Миру. Вы радостно поднялись ей на встречу.**\\\- Привет,<<$name[1]>>. А я вот решила тебя навестить и попить принести, -/// сказала она подойдя к вам.\\\ - Скучаешь небось?///'
    act 'Далее': gt $loc, $metka
end