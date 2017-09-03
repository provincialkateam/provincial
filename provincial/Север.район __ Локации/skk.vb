$loc = $curloc
$metka = $args[0]
! холл
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	minut += rand(2,7)
	gs 'zz_funcs','colorize_day'
	gs 'stat'
	gs 'zz_render','Холл','city/north/skk/hall.jpg',func('skk_strings',0)
	act '<b>В город</b>': minut += rand(5,10) & gt 'nord'
	act 'К торговым площадям': gt 'skk','market'
	act 'В спорткомплекс': gt 'skk','sport'
	act 'На второй этаж': gt 'skk','second_floor'
	act 'К лифтам': gt 'skk','elevator',1
	act 'Кофейня': gt 'zz_common','coffee'
	act 'Моржо': gt 'zz_common','icecream'
	act 'Уборная': gt 'zz_toilet'
end
! торговые площади
if $args[0] = 'market':
	*clr & cla
	minut += rand(2,7)
	gs 'stat'
	gs 'zz_render','Торговые площади','city/north/skk/market.jpg',func('skk_strings',1)
	act '<b>В город</b>': minut += rand(5,10) & gt 'nord'
	act 'В холл': gt 'skk'
	act 'В спорткомплекс': gt 'skk','sport'
	act 'На второй этаж': gt 'skk','second_floor'
	act 'К лифтам': gt 'skk','elevator',1
end
! спорткомплекс
if $args[0] = 'sport':
	*clr & cla
	minut += rand(2,7)
	gs 'stat'
	gs 'zz_render','Спорткомплекс','city/north/skk/arena.jpg',func('skk_strings',2)
	act '<b>В холл</b>': gt 'skk'
	if $npc['0,karate_day'] ! day and hour >= 12 and hour <= 19: act 'Секция карате': minut += 5 & gt 'skk_events',iif($npc['0,karate'] = 0,'karate_init','karate_training')
	if $npc['0,karate_count'] > 0: act 'В душевую': minut += 5 & gt 'zz_bathroom', 'start'
end
! второй этаж
if $args[0] = 'second_floor':
	*clr & cla
	minut += rand(5,10)
	gs 'stat'
	gs 'zz_render','Второй этаж','city/north/skk/hall2.jpg',func('skk_strings',3)
	act 'На первый этаж': gt 'skk'
	act 'На третий этаж': gt 'skk','third_floor'
	act 'К лифтам': gt 'skk','elevator',2
	if hour >= 10 and hour <= 18: act 'Кинотеатр "ГЭС"': gt 'cinema','',1
end
! третий этаж
if $args[0] = 'third_floor':
	*clr & cla
	minut += rand(5,10)
	gs 'stat'
	gs 'zz_render','Третий этаж','city/north/skk/hall3.jpg',func('skk_strings',4)
	if uber['work'] < 5: act 'Служба такси "Довезёт"': gt 'skk_events','uber'
	act 'На второй этаж': gt 'skk','second_floor'
	act 'На четвертый этаж': gt 'skk','fourth_floor'
	act 'К лифтам': gt 'skk','elevator',3
end
! четвертый этаж
if $args[0] = 'fourth_floor':
	*clr & cla
	minut += rand(5,10)
	gs 'stat'
	gs 'zz_render','Четвертый этаж','city/north/skk/hall4.jpg',func('skk_strings',5)
	act 'На третий этаж': gt 'skk','third_floor'
	act 'К лифтам': gt 'skk','elevator',4
end
! лифт
if $args[0] = 'elevator':
	*clr & cla
	gs 'zz_render','','city/north/skk/elevator.jpg'
	if args[1] ! 1: act 'На первый этаж': gt 'skk'
	if args[1] ! 2: act 'На второй этаж': gt 'skk','second_floor'
	if args[1] ! 3: act 'На третий этаж': gt 'skk','third_floor'
	if args[1] ! 4: act 'На четвертый этаж': gt 'skk','fourth_floor'
end