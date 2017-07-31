$borsex_dyn = {
	borsexkol += 1
	slutty += 1
	bordelslutty += 1
	minut += 120
	if RAND(0,100) >= 70: dynamic $venerasiak
}
$sexloc = $CURLOC
gs'stat'
'<center><b>Бордель</b></center>'
'<center><img src="images/img/centr/bordel.jpg"></center>'
if vnesh < 0:
	'"Слушай, у тебя зараза какая то, иди полечись."'
	act 'Уйти':gt'down'
elseif vnesh >= 0 and vnesh < 40:
	'"Ты посмотри на себя, за такой товар никто не заплатит приведи себя в порядок и возвращайся."'
	act 'Уйти':gt'down'
else
	act 'В комнату':gt'bordel','start'
end
if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	gs'stat'
	'<center><b>Ваша комната в борделе</b></center>'
	'<center><img src="images/img/centr/borroom.jpg"></center>'
	'В борделе большая конкуренция и во избежании мордобоя введено правило, не более двух клиентов в сутки'
	'По середине стоит огромная кровать, а сбоку дверь в небольшую <a href="exec:GT ''bordel'',''dysh''">ванну</a>.'
	act 'Уйти':
		i = func('zz_clothing', 'get_group')
		if i ! 13:
			gt 'down'
		elseif i = 13:
			cla
			'Вам надо переодеться в свою одежду.'
			act 'В ванную': gt 'bordel', 'dysh'
		elseif current_clothing = 0:
			msg '<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
			gt 'bordel', 'dysh'
		end
	end
	act 'Идти в зал, ждать клиентов':
		if func('zz_clothing', 'get_group') ! 13:
			cla
			'Вам надо переодеться во что-то более подходящее, в шкафчике в ванной все есть.'
			act 'В ванную': gt 'bordel', 'dysh'
		end
		if (cumbelly + cumpussy + cumass + cumlip + cumface + cumfrot + cumanus) > 0 or mop < 2 or leghair > 0 or lobok > 0 or sweat > 0:
			cla
			'Вам надо привести себя в порядок.'
			act 'В ванную': gt'bordel', 'dysh'
		elseif (cumbelly + cumpussy + cumass + cumlip + cumface + cumfrot + cumanus) = 0 and func('zz_clothing', 'get_group') = 13 and mop > 1 and leghair < 1 and lobok < 1 and sweat < 1:
			gt 'bordel','var'
		end
	end
end
if $ARGS[0] = 'dysh':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	! проверяем наличие шмотки из группы, если нет - добавляем
	if func('zz_clothing','is_exists', 158) = -1:
		_i = 158
		gs 'zz_clothing', 'init_clothing'
		:loop_bordel_dress
		gs 'zz_clothing', 'add_to_wardrobe', _i
		_i += 1
		if _i <= 175: jump 'loop_bordel_dress'
		gs 'zz_clothing', 'dispose'
	end
	'<center><img src="images/img/centr/bordysh.jpg"></center>'
	act 'В комнату': gt 'bordel', 'start'
	act 'Ванная': gt 'zz_bathroom', 'start'
	act 'Зеркало': gt 'mirror', 'start'
	act 'Шкафчик для одежды': gt 'loker', 'start', 13
end
if $ARGS[0] = 'var':
	if borsexkol >= 2:gt'bordel','start'
	minut += 30
	borrand = RAND(0,10)
	if borrand = 0:
		'Клиент заказал одну девушку, цена 1000 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1000
			dynamic $borsex_dyn
			gt'sex','start'
		end
	elseif borrand = 1:
		'Клиент заказал двух девушек, цена 1000 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1000
			dynamic $borsex_dyn
			gt'podrsex','start'
		end
	elseif borrand = 2:
		'Два клиента заказали одну девушку, цена 1500 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1500
			dynamic $borsex_dyn
			gt'sexdvoe','start'
		end
	elseif borrand = 3:
		'Два клиента заказали двух девушек, цена 1500 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 1500
			dynamic $borsex_dyn
			gt'sexdvanadva','start'
		end
	elseif borrand = 4:
		'Группа клиентов заказала одну девушку, цена 2000 руб.'
		act 'Отказаться':gt'bordel','start'
		act 'Согласиться':
			money += 2000
			dynamic $borsex_dyn
			gt'paysex','start'
		end
	elseif borrand > 4:
		'Вас никто не выбрал.'
		act 'Уйти в комнату':gt'bordel','start'
		act 'Ждать еще':gt'bordel','var'
	end
end