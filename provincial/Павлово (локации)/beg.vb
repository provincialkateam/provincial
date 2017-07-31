if $ARGS[0] = 'start':
	cla
	*clr
	minut += 5
	razdtumbler = 0
	act 'Секция бега':
		cla
		*clr
		minut += 120
		speed += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 3
		beg += RAND(2,5)
		'<center><img src="images/pic/fit5.jpg"></center>'
		'Вы бегали по стадиону упражняясь в навыке бега и развивая скорость.'
		act 'Уйти': gt 'fit', 'razd'
	end
end
if begsec > 0:
	act 'Зайти в тренерскую':
		cla
		'Игорь Яковлевич у себя в тренерской. Вы интересуетесь у него вашими успехами.'
		if beg < 50:
			'Тебе нужно тренироваться, ты пока даже на третий разряд не вытягиваешь, в беге главное атлетизм и дыхалка. Еще важно что бы не было лишнего веса, но диеты подрывают спортивную форму, поэтому тренер рекомендует для подсушивания использовать сауну.'
			act 'Выйти': gt 'beg', 'start'
		elseif beg >= 50 and razradbegEG = 0:
			'Ты молодец, действительно молодец, у тебя может быть очень хорошее спортивное будущее. Может даже чемпионкой Европы станешь. Но не забывай, ключ к победам, дыхалка, атлетизм и ни грамма лишнего веса.'
			act 'Уйти': gt 'beg', 'start'
		end
	end
end
if $ARGS[0] = 'sorevnovania':
	cla
	*clr
	gs 'stat'
	minut += 60
	kolsorev += 1
	begmon = month
	razdtumbler = 0
	$zz_str[0] = 'Вас записывают в группу новичков.'
	$zz_str[1] = 'Вас записывают в группу третеразрядников.'
	$zz_str[2] = 'Вас записывают в группу вторых разрядов. Чемпионат города.'
	$zz_str[3] = 'Вас записывают в группу первых разрядов. Чемпионат области.'
	$zz_str[4] = 'Вас записывают в группу КМС. Чемпионат региона.'
	$zz_str[5] = 'Вас записывают в группу Мастеров Спорта. Чемпионат России.'
	$zz_str[6] = 'Вас записывают в группу Мастеров Спорта международного класса. Квалификационные соревнование за выход на Чемпионат Европы.'
	$zz_str[7] = 'Вас записывают на чемпионат Европы.'
	$zz_str[8] = 'Вы не прошли квалификационный отбор на Чемпионат Европы.'
	$zz_str[9] = 'Выйти на беговую дорожку'
	if razradbeg < 6:
		*pl $zz_str[razradbeg]
		act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run' + razradbeg
	elseif razradbeg >= 6 and razradbeg < 16:
		*pl $zz_str[6]
		act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run6'
	elseif razradbeg = 16:
		if razradbegK < 8:
			cla
			razradbegK = 0
			razradbeg = 6
			*pl $zz_str[8]
			act 'Уйти': gt 'fit', 'razd'
		elseif razradbegK >= 8:
			cla
			razradbegK = 0
			razradbeg = 6
			*pl $zz_str[7]
			act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run7'
		end
	end
	killvar '$zz_str'
end