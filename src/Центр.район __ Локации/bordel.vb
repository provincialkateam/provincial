$borsex_dyn = {
	borsexkol += 1
	slutty += 1
	minut += 120
	if RAND(0,100) >= 70: dynamic $venerasiak
}
$sexloc = $CURLOC
gs 'stat'
gs 'zz_render','','images/img/centr/bordel.jpg'
if vnesh < 0:
	gs 'zz_render','','','"Слушай, у тебя зараза какая то, иди полечись."'
	act 'Уйти':gt'center'
elseif vnesh >= 0 and vnesh < 40:
	gs 'zz_render','','','"Ты посмотри на себя, за такой товар никто не заплатит приведи себя в порядок и возвращайся."'
	act 'Уйти':gt'center'
else
	act 'В комнату':gt'bordel','start'
end
if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/centr/borroom.jpg'
	gs 'zz_render','','','В борделе большая конкуренция и во избежании мордобоя введено правило, не более двух клиентов в сутки'
	gs 'zz_render','','','По середине стоит огромная кровать, а сбоку дверь в небольшую <a href="exec:GT ''bordel'',''dysh''">ванну</a>.'
	act 'Уйти':
		i = func('zz_clothing2','get_group')
		if i ! 7:
			gt 'center'
		elseif i = 7:
			cla
			gs 'zz_render','','','Вам надо переодеться в свою одежду.'
			act 'В ванную': gt 'bordel', 'dysh'
		elseif cloth[0] = 0:
			gs 'zz_render','','','<red>ВАМ НАДО ОДЕТЬСЯ.</red>'
		end
	end
	act 'Идти в зал, ждать клиентов':
		if func('zz_clothing2', 'get_group') ! 7:
			cla
			gs 'zz_render','','','Вам надо переодеться во что-то более подходящее, в шкафчике в ванной все есть.'
			act 'В ванную': gt 'bordel', 'dysh'
		end
		if (cumbelly + cumpussy + cumass + cumlip + cumface + cumfrot + cumanus) > 0 or mop < 2 or leghair > 0 or lobok > 0 or sweat > 0:
			cla
			gs 'zz_render','','','Вам надо привести себя в порядок.'
			act 'В ванную': gt'bordel', 'dysh'
		elseif (cumbelly + cumpussy + cumass + cumlip + cumface + cumfrot + cumanus) = 0 and func('zz_clothing2','get_group') = 7 and mop > 1 and leghair < 1 and lobok < 1 and sweat < 1:
			gt 'bordel','var'
		end
	end
end
if $ARGS[0] = 'dysh':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs 'zz_render','','images/img/centr/bordysh.jpg'
	act 'В комнату': gt 'bordel', 'start'
	act 'Ванная': gt 'zz_bathroom','init','bordel','dysh'
	act 'Зеркало': gt 'mirror', 'start'
	act 'Шкафчик для одежды': gt 'loker'
end
if $ARGS[0] = 'var':
	if borsexkol >= 2:gt'bordel','start'
	minut += 30
	borrand = RAND(0,10)
	if borrand = 0:
		gs 'zz_render','','','Клиент заказал одну девушку, цена 1000 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1000
			dynamic $borsex_dyn
			gt'sex','start'
		end
	elseif borrand = 1:
		gs 'zz_render','','','Клиент заказал двух девушек, цена 1000 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1000
			dynamic $borsex_dyn
			gt'podrsex','start'
		end
	elseif borrand = 2:
		gs 'zz_render','','','Два клиента заказали одну девушку, цена 1500 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1500
			dynamic $borsex_dyn
			gt'sexdvoe','start'
		end
	elseif borrand = 3:
		gs 'zz_render','','','Два клиента заказали двух девушек, цена 1500 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1500
			dynamic $borsex_dyn
			gt'sexdvanadva','start'
		end
	elseif borrand = 4:
		gs 'zz_render','','','Группа клиентов заказала одну девушку, цена 2000 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 2000
			dynamic $borsex_dyn
			gt'paysex','start'
		end
	elseif borrand > 4:
		gs 'zz_render','','','Вас никто не выбрал.'
		act 'Уйти в комнату':gt'bordel','start'
		act 'Ждать еще':gt'bordel','var'
	end
end