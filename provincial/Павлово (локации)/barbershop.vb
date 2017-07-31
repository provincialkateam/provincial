if $args[0] = '' or $args[0] = 'start':
	frost = 0
	$loc = $curloc
	$metka = $args[0]
	*clr & cla
	gs 'stat'
	if money >= 1000:
		if cheatHapri_mod = 1:
			$_str = '<a href="exec: gt ''barbershop'', ''hair_short'' ">Прическа под мальчика - 1 тыс.руб</a>'
			if shorthair <= 2: $_str += '<br><a href="exec: gt ''barbershop'', ''hair_medium_short'' ">Короткая прическа - 1 тыс.руб</a>'
			if shorthair <= 1: $_str += '<br><a href="exec: gt ''barbershop'', ''hair_medium''">Средняя прическа - 1 тыс.руб</a>'
			$_str += '<br><a href="exec: gt ''barbershop'', ''hair_coloring'' ">Покрасить волосы - 1 тыс.руб</a><br>'+iif(shorthair < 3,'<a href="exec: gt ''barbershop'', ''hair_curl'' ">Завить волосы - 1 тыс.руб</a>','Завить волосы - 1 тыс.руб')
		else
			$_str = '<a href="exec: gt ''barbershop'', ''hair_short'' ">Короткая прическа - 1 тыс.руб</a><br><a href="exec: gt ''barbershop'', ''hair_coloring'' ">Покрасить волосы - 1 тыс.руб</a>'
			$_str += '<br>'+iif(shorthair = 0,'<a href="exec: gt ''barbershop'', ''hair_curl'' ">Завить волосы - 1 тыс.руб</a>','Завить волосы - 1 тыс.руб')
		end
	else
		$_str = '<br>Короткая прическа - 1 тыс.руб<br>Окрашивание волос 1 тыс.руб<br>Завить волосы - 1 тыс.руб'
	end
	gs 'zz_render','Парикмахерская "Локон"','images/qwest/alter/parikmaherskoy1.jpg',$_str
	killvar '$_str'
	act 'Выйти': gt 'gorodok'
end
! --------------
! --- HAIR ---
if $args[0] = 'hair_coloring':
	*clr & cla
	gs 'barbershop','hair_loc_description','color'
	gs 'zz_render','','','Вы сели в кресло, к вам подошла девушка и спросила в какой цвет желаете перекрасится.'
	if hcol ! 0: act 'Черный цвет': gs 'barbershop', 'hair_coloring_sub',0
	if hcol ! 1: act 'Русый цвет': gs 'barbershop', 'hair_coloring_sub',1
	if hcol ! 2: act 'Рыжий цвет': gs 'barbershop', 'hair_coloring_sub',2
	if hcol ! 3: act 'Светлый цвет': gs 'barbershop', 'hair_coloring_sub',3
	act 'Передумать': gt $loc, $metka
end
if $args[0] = 'hair_coloring_sub':
	cla
	hcol = args[1]
	money -= iif($loc = 'salon',1500,1000)
	minut += 60
	if salonrand = 0 and masha = 0 and $loc = 'salon': gt 'salon', '0'
	gs 'stat'
	gs 'zz_render','','','Вам покрасили волосы.'
	act 'Выйти': gt $loc, $metka
end
if $args[0] = 'hair_curl':
	minut += 60
	curly += 10
	money -= iif($loc = 'salon',1500,1000)
	if salonrand = 0 and masha = 0 and $loc = 'salon': gt'salon','0'
	gs 'stat'
	*clr
	gs 'barbershop','hair_loc_description','curl'
	gs 'zz_render','','','Вам завили волосы.'
	act 'Выйти': gt $loc, $metka
end
if $args[0] = 'hair_medium':
	minut += 60
	shorthair = 1
	shorthairday = 0
	hapri = 1
	money -= iif($loc = 'salon',1500,1000)
	if salonrand = 0 and masha = 0 and $loc = 'salon': gt'salon','0'
	gs'stat'
	*clr
	gs 'barbershop','hair_loc_description','short'
	'Вас подстригли, сделав вам волосы средней длинны.'
	act 'Выйти': gt $loc, $metka
end
if $args[0] = 'hair_medium_short':
	minut += 60
	shorthair = 2
	shorthairday = 0
	hapri = 1
	money -= iif($loc = 'salon',1500,1000)
	if salonrand = 0 and masha = 0 and $loc = 'salon': gt'salon','0'
	gs'stat'
	*clr
	gs 'barbershop','hair_loc_description','short'
	'Вам подстригли волосы, сделав короткую прическу.'
	act 'Выйти': gt $loc, $metka
end
if $args[0] = 'hair_short':
	minut += 60
	shorthair = 3
	shorthairday = 0
	money -= iif($loc = 'salon',1500,1000)
	if salonrand = 0 and masha = 0 and $loc = 'salon': gt'salon','0'
	gs 'stat'
	*clr
	gs 'barbershop','hair_loc_description','short'
	gs 'zz_render','','','Вам подстригли волосы очень коротко, сделав прическу под мальчика.'
	act 'Выйти': gt $loc, $metka
end
if $args[0] = 'hair_loc_description':
	if $loc = 'salon':
		if $args[1] = 'color': $zz_str = 'salon1'
		if $args[1] = 'curl': $zz_str = 'salon0'
		if $args[1] = 'short': $zz_str = 'salon2'
		gs 'zz_render','Салон красоты','images/img/centr/'+$zz_str+'.jpg'
		killvar '$zz_str'
	else
		gs 'zz_render','Парикмахерская "Локон"','images/qwest/alter/parikmaherskoy1.jpg'
	end
end
if $args[0] = 'change_haircolor':
	if hcol = 0: $result = 'Решила стать жгучей брюнеткой?'
	if hcol = 1: $result = 'Решила вернуть свой естественный цвет волос?'
	if hcol = 2: $result = 'Решила стать рыжей и бесстыжей?'
	if hcol = 3: $result = 'Решила стать блондинкой?'
end
! ------------