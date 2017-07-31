if $args[0] = '': $args[0] = 'start'
if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 5
	gs 'stat'
	'<center><b>Авторынок</b></center>'
	'<center><img src="images/pic/autotraid.jpg"></center>'
	'Машину можно купить только при наличии прав. И две машины иметь нельзя.'
	gs 'car', 'check'
	if hour <= 17:
		if $car['id'] >= 0: act 'Подойти к скупщику': gt 'autotraidF', 'manager1'
		if age >= 18 and prava = 1: act 'Посмотреть машины': gt 'autotraidF' ,'car'
	end
	act 'Уйти': gt'nord'
end
if $ARGS[0] = 'manager1':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 5
	gs 'stat'
	'<center><b>Авторынок</b></center>'
	'<center><img src="images/pic/autotraid.jpg"></center>'
	if $car['location'] = $curloc and $car['id'] >= 0:
		zz_price = func('zz_cars', 'get_sell_price') * 1000
		'Скупщик походил вокруг машины и предложил вам за нее ' + zz_price + ' рублей'
		act 'Продать':
			cla
			minut += 30
			money += zz_price
			! disposing car array
			killvar '$car'
			$car['id'] = -1
			! ---
			killvar 'zz_price'
			'Вы продали свою машину.'
			act 'Уйти': gt'nord'
		end
	elseif $car['location'] ! $curloc:
		'Скупщик говорит, что ему нужно посмотреть на машину, прежде чем назначить цену, и если вы хотите, он вызовет эвакуатор за 2500, что бы доставить вашу машину к рынку.'
		if money >= 2500:
			act 'Эвакуатор до рынка (2500 руб 1 час)':
				cla
				minut += 60
				$car['location'] = 'autotraidF'
				money -= 2500
				'Вы отдали деньги и целый час ждали когда же вам привезут машину, наконец вы увидели как ее выгрузил эвакуатор около рынка.'
				act 'К скупщику': gt 'autotraidF', 'manager1'
			end
		end
	end
	act 'Уйти':gt'nord'
end
if $ARGS[0] = 'car':
	cla
	*clr
	minut += 5
	gs 'stat'
	'<center><b>Авторынок</b></center>'
	'<center><img src="images/pic/autotraid.jpg"></center>'
	'Машин так много на стоянке, что можно потратить всю жизнь и никогда не осмотришь все машины, если еще с машинами на ходу можно понять их техническое состояние, то машины не на ходы это кот в мешке, может быть выгодной покупкой, а может быть пустой тратой денег, и не забывайте, вам ее еще доставить в сервис нужно будет.'
	gs 'zz_cars', 'create_shop', 1
	act 'Уйти':
		gs 'zz_cars', 'dispose'
		gt 'nord'
	end
end