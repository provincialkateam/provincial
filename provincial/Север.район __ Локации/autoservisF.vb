if $args[0] = '': $args[0] = 'start'
if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 5
	gs 'stat'
	'<center><b>Автосервис</b></center>'
	'<center><img src="images/pic/autoservis1.jpg"></center>'
	gs 'car', 'check'
	if $car['location'] = $curloc:
		! calc repair price
		if $car['cur_cond'] >= $car['base_cond'] * 3/4 and $car['wreck'] = 0: 'Мастер осмотрел вашу машину и сказал, что она не нуждается ни в ремонте, ни в тех обслуживании.'
		if $car['cur_cond'] < $car['base_cond'] * 3/4 or $car['wreck'] = 1:
			zz_repair = ($car['base_cond'] - $car['cur_cond']) * $car['price'] * 50 / $car['base_cond']
			'Мастер осмотрел вашу машину и сказал, что стоимость работ <<zz_repair>>.'
			if money >= zz_repair:
				act 'Оплатить и отремонтировать':
					cla
					*clr
					money -= zz_repair
					minut += 60
					if $car['wreck'] = 1: $car['base_cond'] = $car['base_cond'] / 2
					$car['cur_cond'] = $car['base_cond']
					$car['wreck'] = 0
					'<center><img src="images/pic/autoservis2.jpg"></center>'
					'Вы просидели целый час в комнате отдыха делая вид, что смотрите телевизор. Наконец, машину починили и вы заплатили в кассу <<zz_repair>> рублей.'
					if $car['wreck'] = 1: 'Мастер, перед тем как отдать вам ключи сказал, чтобы вы постарались не доводить машину до такого состояния.'
					killvar 'zz_repair'
					act 'Уйти': gt 'nord'
				end
			end
		end
	end
	if $car['location'] ! $curloc: 'Мастер усмехнулся и сказал "Девушка, мне нужно машину посмотреть, что бы хоть, что-то вам сказать. Пригоняйте ее к автосервису, поглядим."'
	if $car['wreck'] = 1 and $car['location'] ! $curloc and $car['id'] >= 0:
		'В автосервисе действует услуга эвакуации поврежденных автомобилей до автосервиса, стоимость 2500'
		if money >= 2500:
			act 'Оплатить доставку авто (2500 руб 1 час)':
				cla
				*clr
				money -= 2500
				$car['location'] = 'autoservisF'
				minut += 60
				'<center><img src="images/pic/autoservis2.jpg"></center>'
				'Вы просидели целый час в автосервисе, ожидая, когда привезут ваш автомобиль. Наконец, время прошло и ваш автомобиль был доставлен к воротам автосервиса.'
				act 'К мастеру': gt 'autoservisF','start'
			end
		end
	end
	act 'Уйти': gt'nord'
end