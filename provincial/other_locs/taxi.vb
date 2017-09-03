if $args[0] = '' or $args[0] = 'init':
	*clr & cla
	minut += 5
	gs 'zz_render','',func('zz_funcs','mk_image','common/transport/taxi/taxi')
	killvar '$zz_funcs_result'
	$zz_funcs_result[0] = ' ,Спальный район,Центр,Северный район,Дачный кооператив,Гадюкино,Павлово'
	$zz_funcs_result[1] = 'Спальный район,-,250,250,500,750,1000'
	$zz_funcs_result[2] = 'Центр,250,-,250,500,750,1000'
	$zz_funcs_result[3] = 'Северный район,250,250,-,500,750,1000'
	$zz_funcs_result[4] = 'Дачный кооператив,500,500,500,-,500,750'
	$zz_funcs_result[5] = 'Гадюкино,750,750,750,500,-,500'
	$zz_funcs_result[6] = 'Павлово,1000,1000,1000,750,500,-'
	gs 'zz_funcs','make_table',$zz_funcs_result,700
	if $loc ! 'street': act 'Ехать в Спальный район': gt 'taxi', 'move', 'street'
	if $loc ! 'down': act 'Ехать в Центр': gt 'taxi', 'move', 'down'
	if $loc ! 'nord': act 'Ехать в Северный район': gt 'taxi', 'move', 'nord'
	if $loc ! 'dachi': act 'Ехать в дачный кооператив': gt 'taxi', 'move', 'dachi'
	if $loc ! 'gadukino': act 'Ехать в Гадюкино': gt 'taxi', 'move', 'gadukino'
	if $loc ! 'gorodok': act 'Ехать в Павлово': gt 'taxi', 'move', 'gorodok'
	act 'Отказаться': _taxi_time = -1 & gt $loc,$metka
end
if $args[0] = 'check':
	! проверяем время ожидания
	if (hour*60 + minut) >= _taxi_time and (hour*60 + minut) <= (_taxi_time+20): gs 'zz_render','','','<red>Возле '+iif($control_point='nord' or $control_point='street' or $control_point='down' or $control_point='gorodok','тротуара','обочины')+' мигает шашечками <a href="exec:gt''taxi''">такси</a>.</red>'
	! сбрасываем время такси
	if hour*60 + minut > (_taxi_time+20): _taxi_time = -1
end
if $args[0] = 'move':
	$loc = $args[1]
	! формируем массив локаций
	$_places = 'street,down,nord,dachi,gadukino,gorodok'
	! получаем индекс отправной точки - она у нас $control_point
	_from = func('zz_funcs','get_item_id',$_places,$control_point)
	! получаем конечную точку
	_to = func('zz_funcs','get_item_id',$_places,$loc)
	! формируем массив цен
	$_taxes[0] = '0,250,250,500,750,1000'
	$_taxes[1] = '250,0,250,500,750,1000'
	$_taxes[2] = '250,250,0,500,750,1000'
	$_taxes[3] = '500,500,500,0,500,750'
	$_taxes[4] = '750,750,750,500,0,500'
	$_taxes[5] = '1000,1000,1000,750,500,0'
	! получаем цену за поездку
	_price = val(func('zz_funcs','get_item_string',$_taxes[_from],_to))
	! время поездки, добавляем пробки в час-пик
	minut += _price/iif((hour >= 7 and hour <= 10) or (hour >= 16 and hour <= 19), rand(18,20), rand(20,22))
	killvar '$_places'
	killvar '$_taxes'
	killvar '_from'
	killvar '_to'
	if workDisk = 3 and konvert = 1 and rand(0,100) >= 98: konvert = 0
	if money >= _price:
		money -= _price
		killvar '_price'
		gt $loc
	else
		gs 'zz_render','','common/transport/taxi/inner'+iif(hour > func('zz_weather','sunset') or hour < func('zz_weather','sunrise'),'_night',''),'У вас нет денег, что бы заплатить таксисту. Он подъехал к каким то гаражам и достав член из штанов, сказал вам:<br><do>- Нет денег - тогда отрабатывай.</do>'
		act 'Сосать':
			*clr & cla
			bj += 1
			gs 'zz_render','','common/transport/taxi/'+rand(0,1)+'.gif','Вы наклонились к ширинке таксиста и взяли в рот его член.'
			if rand(0,100) < 50:
				act 'Дальше':
					*clr & cla
					gs 'zz_funcs','cum','lip'
					gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif','Через несколько минут работы ртом таксист разрядился вам в рот и вы вынуждены были проглотить его кончу.'
					act 'Уйти': killvar '_price' & gt $loc
				end
			else
				act 'Дальше':
					*clr & cla
					gs 'zz_funcs', 'cum', 'face'
					guy += 1
					dynamic $venerasiak
					$boy = 'Таксист'
					_where = rand(0,1)
					pose = 1
					gs 'zz_render','','common/transport/taxi/'+iif(_where = 0,rand(2,3),rand(4,5)),'<do>- Этого все равно не достаточно</do> - сказал таксист, и силой подтащил вашу попу к себе.'
					if _where = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick', 1
						gs 'zz_dynamic_sex', 'anal', 'dick'
					end
					killvar '_where'
					killvar '_price'
					gs 'zz_render','','','Вдоволь насытившись вашим юным телом, таксист кончил, полив ваше личико противной, вязкой спермой.'
					act 'Уйти': gt $loc
				end
			end
		end
	end
end