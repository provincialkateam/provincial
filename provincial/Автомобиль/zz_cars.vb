! make car array
if $args[0] = 'init_cars':
	! args[1] - car id
	! $args[2] - name
	! args[3] - price/1000
	! args[4] - base (full) condition
	! args[5] - sec.hand flag, 0/1
	gs 'zz_cars', 'fill_car_params', 0, 'ВАЗ 2107', 180, 200, 1
	gs 'zz_cars', 'fill_car_params', 1, 'ВАЗ 2115', 180, 300, 1
	gs 'zz_cars', 'fill_car_params', 2, 'ВАЗ 2113', 180, 290, 1
	gs 'zz_cars', 'fill_car_params', 3, 'ВАЗ 2114', 180, 300, 1
	gs 'zz_cars', 'fill_car_params', 4, 'ВАЗ 2110', 180, 350, 1
	gs 'zz_cars', 'fill_car_params', 5, 'ВАЗ КАЛИНА', 400, 400
	gs 'zz_cars', 'fill_car_params', 6, 'ВАЗ ПРИОРА', 450, 450
	gs 'zz_cars', 'fill_car_params', 7, 'НИВА ШЕВРОЛЕ', 500, 500
	gs 'zz_cars', 'fill_car_params', 8, 'УАЗ ХАНТЕР', 500, 300
	gs 'zz_cars', 'fill_car_params', 9, 'УАЗ ПАТРИОТ', 600, 400
	gs 'zz_cars', 'fill_car_params', 10, 'ГАЗ 3102', 100, 1000, 1
	gs 'zz_cars', 'fill_car_params', 11, 'ГАЗ 3110', 100, 800, 1
	gs 'zz_cars', 'fill_car_params', 12, 'Ford Focus 2', 500, 800
	gs 'zz_cars', 'fill_car_params', 13, 'Mitsubishi l200', 1000, 2000
	gs 'zz_cars', 'fill_car_params', 14, 'Audi Q7', 5000, 5000
	gs 'zz_cars', 'fill_car_params', 15, 'Cadillac Escalade', 2000, 4000
	gs 'zz_cars', 'fill_car_params', 16, 'Porsche Cayenne', 5000, 3000
	gs 'zz_cars', 'fill_car_params', 17, 'BMW X6', 4500, 4000
	gs 'zz_cars', 'fill_car_params', 18, 'Mercedes-Benz S 600', 8000, 8000
	gs 'zz_cars', 'fill_car_params', 19, 'BMW Z4', 3000, 4000
	gs 'zz_cars', 'fill_car_params', 20, 'Renault LOGAN', 700, 1000
	gs 'zz_cars', 'fill_car_params', 21, 'Toyоta Corolla', 1100, 3000
	gs 'zz_cars', 'fill_car_params', 22, 'Toyota Celica', 1000, 3000
	gs 'zz_cars', 'fill_car_params', 23, 'Mazda 6', 1200, 3000
	gs 'zz_cars', 'fill_car_params', 24, 'Mercedes-Benz E 212', 1700, 5000
	gs 'zz_cars', 'fill_car_params', 25, 'BMW M5', 4500, 6000
	gs 'zz_cars', 'fill_car_params', 26, 'Jaguar XKR-S', 7000, 4000
	gs 'zz_cars', 'fill_car_params', 27, 'Audi A6', 1900, 5000
	gs 'zz_cars', 'fill_car_params', 28, 'Ford Mondeo', 850, 2000
	gs 'zz_cars', 'fill_car_params', 29, 'Bentley Continental GT', 10000, 8000
	gs 'zz_cars', 'fill_car_params', 30, 'Ferrari 458 Italia', 20000, 10000
end
! fill array with values
! args[1] - car id
! $args[2] - name
! args[3] - price/1000
! args[4] - base (full) condition
! args[5] - sec.hand flag, 0/1
if $args[0] = 'fill_car_params':
	zz_id = args[1]
	$zz_car_names[zz_id] = $args[2]
	zz_cars[zz_id+"_"+'price'] = args[3]
	zz_cars[zz_id+"_"+'base_cond'] = args[4]
	! current condition for sec.hand cars
	zz_cars[zz_id+"_"+'cur_cond'] = iif(val(args[5]) = 1, rand(1, args[4]-1), args[4])
	killvar 'zz_id'
end
! make shop table
! args[1] - sec.hand flag, 0/1
if $args[0] = 'create_shop':
	! init car array
	gs 'zz_cars', 'init_cars'
	! zebra_colors
	$zz_color = '#f3f4ee'
	! make table
	$zz_str = '<center><table border=0 cellpadding=0 cellspacing=1 align=center>'
	! table headers
	$zz_str += '<tr bgcolor='+$zz_color+'><th>Фото</th><th>Салон</th><th>&nbsp;Название&nbsp;</th><th>&nbsp;Сосотояние&nbsp;</th><th>&nbsp;Цена, руб&nbsp;</th></tr>'
	i = 0
	:loop_car_shop
	if i <= arrsize('zz_cars')/3 - 1:
		! sec.hand or shop
		if val(args[1]) = 0:
			! exclude market
			if zz_cars[i+"_"+'base_cond'] ! zz_cars[i+"_"+'cur_cond']:
				i += 1
				jump 'loop_car_shop'
			end
		else
			! exclude carshop
			if zz_cars[i+"_"+'base_cond'] = zz_cars[i+"_"+'cur_cond']:
				i += 1
				jump 'loop_car_shop'
			end
		end
		! condition string
		if val(args[1]) = 1:
			$zz_cond = func('zz_cars','get_condition_status',zz_cars[i+"_"+'base_cond'],zz_cars[i+"_"+'cur_cond'])
		else
			$zz_cond = 'Новая'
		end
		! purchase price for market
		if val(args[1]) = 1:
			! min price - 10% base-price
			zz_min_price = zz_cars[i+"_"+'price'] / 10
			! current price
			zz_price = zz_cars[i+"_"+'cur_cond'] * zz_cars[i+"_"+'price'] / zz_cars[i+"_"+'base_cond']
			! check min price
			if zz_price < zz_min_price: zz_price = zz_min_price
		else
			! without changes for shop
			zz_price = zz_cars[i+"_"+'price']
		end
		! make price string
		$zz_price = iif(zz_price >= 1000, zz_price/1000 + 'млн.', zz_price + 'тыс.')
		! zebra colors
		$zz_color = iif($zz_color = '#f3f4ee', '#ffffff', '#f3f4ee')
		! starting table row
		$zz_str += '<tr bgcolor=' + $zz_color + '>'
		! car photo cell
		$zz_str += '<td><a href="exec: view ''images/picar/car' + i + '.jpg''"><img src="images/picar/car' + i + '.jpg" width=140></a></td>'
		! car interior photo cell
		$zz_str += '<td><a href="exec: view ''images/picar/salon' + i + '.jpg''"><img src="images/picar/salon' + i + '.jpg" width=140></a></td>'
		! name cell
		$zz_str += '<td>' + $zz_car_names[i] + '</td>'
		! condition cell
		$zz_str += '<td>' + $zz_cond + '</td>'
		! check cash for market or check card balance
		if ((val(args[1]) = 1 and money >= zz_price * 1000) or (val(args[1]) ! 1 and karta >= zz_price * 1000)) and $car['id'] < 0:
			! purchase cell - link
			$zz_str += '<td><a href="exec: gt ''zz_cars'',''buy_car'',' + i + ',' + zz_price + ',' + val(args[1]) + '">' + $zz_price + '</a></td>'
		else
			! purchase cell - no money
			$zz_str += '<td><b>' + $zz_price + '</b></td>'
		end
		! closing row
		$zz_str += '</tr>'
		i += 1
		jump 'loop_car_shop'
	end
	! output
	gs 'zz_render','','', $zz_str + '</table></center>'
	! kill variables
	killvar '$zz_cond'
	killvar '$zz_color'
	killvar '$zz_str'
	killvar 'zz_price'
	killvar 'zz_min_price'
end
! return condition string
! args[1] - base condition
! args[2] - current condition
if $args[0] = 'get_condition_status':
	if args[2] >= args[1] * 3/4: $result = 'в отличном состоянии'
	if args[2] >= args[1] * 2/4 and args[2] < args[1] * 3/4: $result = 'в хорошем состоянии'
	if args[2] >= args[1] * 1/4 and args[2] < args[1] * 2/4: $result = 'в плохом состоянии'
	if args[2] < args[1] * 1/4: $result = 'не на ходу'
end
! buy car procedure
! args[1] - car id
! args[2] - current price
! args[3] - sec.hand flag, 0/1
if $args[0] = 'buy_car':
	! car - current car array
	$car['id'] = args[1]
	$car['cur_cond'] = zz_cars[$car['id']+"_"+'cur_cond']
	$car['base_cond'] = zz_cars[$car['id']+"_"+'base_cond']
	$car['price'] = zz_cars[$car['id']+"_"+'price']
	$car['fuel'] = 3
	$car['wreck'] = iif($car['cur_cond'] < $car['base_cond']/4, 1, 0)
	$car['name'] = $zz_car_names[val($car['id'])]
	if val(args[3]) = 1:
		*clr & cla
		money -= args[2]*1000
		$car['location'] = 'nord'
		gs 'zz_render','Авторынок','pic/autotraid.jpg','Вы заплатили ' + args[2]*1000 + ' рублей и купили машину. Торговец ее поставил около рынка и предупредил, что там мало бензина.'
	else
		*clr & cla
		$car['location'] = 'nord'
		karta -= zz_cars[$car['id']+"_"+'price']*1000
		gs 'zz_render','Автосалон','pic/manager.jpg','Вы перечислили деньги и менеджер вам выдала ключи. Она уточнила, что ваша машина уже стоит на улице. Бензина мало и она рекомендует вам заправится.'
	end
	gs 'zz_cars', 'dispose'
	act 'Уйти': gt 'nord'
end
! return sell price
if $args[0] = 'get_sell_price':
	! min price - 5% base-price
	zz_min_price = $car['price'] / 20
	! max price - 80% base-price
	zz_max_price = $car['price'] * 4/5
	! current price
	result = $car['cur_cond'] * zz_max_price / $car['base_cond']
	if result < zz_min_price: result = zz_min_price
	killvar 'zz_min_price'
	killvar 'zz_max_price'
end
! disposing
if $args[0] = 'dispose':
	killvar '$zz_car_names'
	killvar 'zz_cars'
end