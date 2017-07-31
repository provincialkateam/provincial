if $args = 'main':
	act 'Выйти из комнаты': gt 'korrPar'
	$metka = $ARGS[0]
	$loc = $CURLOC
	if hour = 21 and father['horny'] >= 70 and family_trip = 0: gt 'seeparentsex'
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if (hour >= 21 or hour < 6) and family_trip = 0:
		if week ! 1:
			gs 'zz_render','Спальня родителей','pavlovo/family/parents/parents_sleep','На кровати спят мать и отчим.'
		else
			gs 'zz_render','Спальня родителей','pavlovo/family/parents/mother_sleep','На кровати спит ваша мать.'
		end
		exit
	else
		gs 'zz_render','Спальня родителей','pavlovo/family/apartment/bedr_par','Комната, в которой живут родители. В центре стоит двухспальная кровать и '+iif((hour>8 and hour<16) or (family_trip_month ! month and week >= 6),'<a href="exec: gt ''bedrPar2'',''parents_wardrobe''">большой шкаф</a>','большой шкаф')+' у стены.'
	end
	gs 'zz_family', 'mother_sheduler'
	if $mother['location'] = $curloc and (current_clothing <= 2 or alko >= 6): *clr & gs 'mother' & exit
	if hour > 7 and hour < 21 and $mother['location'] ! $curloc:
		if kamasutra_day ! day: gs 'zz_render','','','На кровати лежит какая-то <a href="exec: gt ''bedrPar2'',''kamasutra''">книга</a>'
		if prezikday ! day:
			if prezikProver >= 3:
				prezikday = day - 4
				act 'Стащить у родителей презервативы':
					*clr & cla
					minut += rand(5,7)
					prezik += rand(1,3)
					prezikday = day
					prezikProver = 0
					gs 'zz_render','','pavlovo/family/parents/condoms_steal','Вы незаметно достаёте из родительского схрона несколько презервативов. Теперь их у вас <<prezik>> штук.'
					act 'Выйти из комнаты': gt 'korrPar'
				end
			else
				gs 'zz_render','','','Вы недавно уже брали презервативы из родительского схрона. Если их часто таскать, то родители могут что-то заподозрить.'
			end
		end
	end
end
! book
if $args = 'kamasutra':
	*clr & cla
	minut += 1
	kamasutra_day = day
	kamasutra_page = 0
	gs 'zz_render','','pavlovo/family/parents/book','На обложке написано "Камасутра"'
	act 'Смотреть': gt 'bedrPar2', 'read_book'
	act 'Отойти': gt $loc, $metka
end
! read book
if $args = 'read_book':
	*clr & cla
	horny += 2
	minut += 3
	gs 'stat'
	if (hour = 20 and minut > 50) or hour = 21:
		gs 'zz_render','','pavlovo/family/parents/kamasutra/ik' + kamasutra_page,'Пора валить, а то родители застукают...'
	else
		gs 'zz_render','','pavlovo/family/parents/kamasutra/ik' + kamasutra_page,'<center>'+iif(kamasutra_page < 1,'','<a href="exec: kamasutra_page-=1 & gt''bedrPar2'',''read_book''">Предыдущая страница</a>')+ '	' +iif(kamasutra_page > 45,'','<a href="exec: kamasutra_page+=1 & gt''bedrPar2'',''read_book''">Следующая страница</a>')+'</center>'
		if horny >= 60 and week = 6 and family_trip = 1: act 'Мастурбировать': gt 'selfplay'
	end
	act 'Закрыть': gt $loc, $metka
end
! parent`s wardrobe
if $args = 'parents_wardrobe':
	*clr & cla
	gs 'zz_render','','pavlovo/family/parents/wardrobe','Старый советский шкаф'
	act 'Рыться в вещах': gt 'bedrPar2', 'wardrobe_search'
	act 'Отойти': gt $loc, $metka
end
if $args = 'wardrobe_search':
	*clr & cla
	if rand(1,100) > 75:
		$failwords[0]='Вам не удалось найти ничего интересного'
		$failwords[1]='Здесь одна одежда и нижнее бельё'
		$failwords[2]='Вы покопались в шкафу, но ничего кроме нижнего белья матери не нашли'
		gs 'zz_render','','pavlovo/family/parents/wardrobesearch'+rand(1,4), $failwords[rand(0,2)]
		killvar '$failwords'
	else
		$findmomtoy[0]='Копаясь в шкафу, вы неожиданно нашли небольшой <a href="exec: gt ''bedrPar2'',''momtoy_play''">дилдо</a>'
		$findmomtoy[1]='В ящике с нижним бельём матери находится вдруг упрятанный под лифчиками и трусами маленький <a href="exec: gt ''bedrPar2'',''momtoy_play''">дилдо</a>'
		'"Однако! - думаете вы про себя. - запомним!"'
		$findmomtoy[2]='Вы нашли мамину <a href="exec: gt ''bedrPar2'',''momtoy_play''">игрушку</a>'
		gs 'zz_render','','pavlovo/family/parents/wardrobetoy.jpg', $findmomtoy[rand(0,2)]
		killvar '$findmomtoy'
	end
	act 'Закрыть шкаф': gt $loc, $metka
end
if $args[0] = 'momtoy_play':
	*clr & cla
	dildo = 1
	dildohand = 10
	selfmomtoyplay = 1
	gs 'zz_render','','qwest/selfplay/start'
	if horny >= 70: act 'Поиграться': gt 'selfplay'
	act 'Отойти': gt $loc, $metka
end
! мать рукоблудит, Светка подглядывает
if $args[0] = 'mom_selfplay':
	*clr & cla
	$_str = 'Проходя мимо комнаты родителей, вы вдруг слышите оттуда странные звуки.'
	if voyeurism > 0:
		$_str += 'Вы, конечно, догадываетесь, что может происходить за дверью - вы же взрослая девочка, но вас смутил тот факт, что отчим обычно по понедельникам на складе в городе затаривается, возя оттуда на своей "Газельке" в Павлово что закажут, и домой возвращается обычно к полуночи и замотанный.'
	else
		$_str += 'Поддавшись соблазну любознательности, вы решили посмотреть, что происходит за дверью.'
	end
	$_str += 'Подкравшись на цыпочках, вы тихонько поворачиваете дверную ручку, и приоткрыв дверь, приникаете глазом к щёлке.'
	! если впервой
	if mom_selfplay = 0:
		$_str += ', и замираете от увиденного: ваша мама, раскинувшись на кровати абсолютно голой, яростно сношает себя фаллоимитатором, закатывая глаза от наслаждения и тихо постанывая.'
	else
		! уже видела
		$_str += '. "Папочка из дому - мама в рукопашную" - иронически усмехаетесь вы про себя, наблюдая, как мама яростно яростно самозабвенно вгоняет в себя силиконовый "заменитель мужика", охая и тяжело дыша.'
	end
	gs 'zz_render','','pavlovo/family/mother/selfplay'+rand(0,4)+'.gif',$_str
	killvar '$_str'
	mom_selfplay = 1
	parentsexday = day
	horny += rand(10,20)
	minut += rand(2,5)
	act 'Закрыть дверь': gt 'korrPar'
end