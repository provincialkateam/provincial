$loc = $CURLOC
if $args[0] = '' or $args[0] = 'start':
	*clr & cla
	$metka = $ARGS[0]
	gs 'zz_phone','boyfriend_call_init'
	minut += 10
	gs 'stat'
	gs 'zz_render', 'Швейная фабрика им."Парижской коммуны"', 'images/pic/Gshveyfab.jpg', func('Gshveyfab_strings', 'local_str1')
	if hour >= 8 and hour <= 20 and week >= 1 and week <= 5:
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str2')
	else
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str3')
	end
	act '<B>Уйти</B>':minut += 15 & gt'gorodok'
end
if $ARGS[0] = 'enter':
	*clr & cla
	minut += 2
	$metka = $ARGS[0]
	gs 'stat'
	gs 'zz_render', 'Швейная фабрика им."Парижской коммуны"', 'images/qwest/alter/fabrika/pusto.jpg', func('Gshveyfab_strings', 'local_str4')
	if workFabrika = 0 and age => 16 and age < 18:'Вы можете устроиться на пол ставки на <a href="exec:minut += 15 & GT ''Gshveyfab'', ''job_start''">работу</a>.'
	if work = 0 and workFabrika = 0 and age => 18:'Вы можете устроиться на <a href="exec:minut += 15 & GT ''Gshveyfab'', ''job_start''">работу</a>.'
	if workFabrika = 1 and week => 1 and week <= 5 and hour = 16 and age => 16 and age < 18:
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str5')
		act 'Выйти на смену': gt'Gshveyfab','job'
	end
	if workFabrika = 1 and FabrikaProgul <= 4:
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str6')
		act 'Уволится':workFabrika = 0 & work = 0 & gt 'Gshveyfab','enter'
	end
	if workFabrika = 1 and FabrikaProgul > 4:
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str7')
		act 'Уволится':workFabrika = 0 & work = 0 & smenaFabrika = 0 & FabrikaProgul = 0 & gt 'Gshveyfab','enter'
	end
	act '<B>Уйти</B>':gt'Gshveyfab','start'
end
if $ARGS[0] = 'job_start':
	*clr & cla
	minut += 2
	$metka = $ARGS[0]
	gs 'stat'
	gs 'zz_render', 'Кабинет начальника цеха', 'images/qwest/alter/fabrika/nachalnik.jpg', func('Gshveyfab_strings', 'local_str8')
	if age >= 16 and age < 18 and workFabrika = 0:
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str9')
			act 'Устроиться на работу':
				cla
				work = 1
				workFabrika = 1
				smenaFabrika = 0
				FabrikaProgul = 0
				gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str10')
				act 'Отойти':gt'Gshveyfab', 'enter'
			end
	elseif age >= 18 and workFabrika = 0:
		gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str11')
			act 'Устроиться на работу':
				cla
				work = 1
				workFabrika = 1
				smenaFabrika = 0
				FabrikaProgul = 0
				gs 'zz_render', '', '', func('Gshveyfab_strings', 'local_str12')
				act 'Отойти': gt 'Gshveyfab', 'enter'
			end
	end
	act 'Отойти':gt'Gshveyfab', 'enter'
end
if $ARGS[0] = 'job':
	*clr & cla
	$metka = $ARGS[0]
	FabrikaProgul -= 1
	if FabrikaProgul < 0: FabrikaProgul = 0
	if age >= 16 and age < 18:
		smenaFabrika += 1
		minut += 240
	end
	if age >= 18:
		smenaFabrika += 2
		health += 10
		minut += 540
		energy += 10
	end
	gs 'zz_funcs', 'break_nail3'
	gs 'stat'
	gs 'zz_render', 'Швейная фабрика им."Парижской коммуны"', 'images/qwest/alter/fabrika/smena.jpg', func('Gshveyfab_strings', 'local_str13')
	act '<B>Уйти</B>': gt'gorodok'
end