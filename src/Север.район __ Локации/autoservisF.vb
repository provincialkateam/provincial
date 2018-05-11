$loc = $CURLOC
if $args[0] = '' or $args[0] = 'start':
	$metka = $ARGS[0]
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','images/pic/autoservis1.jpg'
	gs 'car', 'check'
	if $car['location'] = $curloc:
		! calc repair price
		if $car['cur_cond'] >= $car['base_cond'] * 3/4 and $car['wreck'] = 0: 'Мастер осмотрел вашу машину и сказал, что она не нуждается ни в ремонте, ни в тех обслуживании.'
		if $car['cur_cond'] < $car['base_cond'] * 3/4 or $car['wreck'] = 1:
			zz_repair = ($car['base_cond'] - $car['cur_cond']) * $car['price'] * 50 / $car['base_cond']
			gs 'zz_render','','','Мастер осмотрел вашу машину и сказал, что стоимость работ <<zz_repair>>.'
			if money >= zz_repair:
				act 'Оплатить и отремонтировать':
					*clr & cla
					money -= zz_repair
					minut += 60
					if $car['wreck'] = 1: $car['base_cond'] = $car['base_cond'] / 2
					$car['cur_cond'] = $car['base_cond']
					$car['wreck'] = 0
					gs 'zz_render','','images/pic/autoservis2.jpg'
					gs 'zz_render','','','Вы просидели целый час в комнате отдыха делая вид, что смотрите телевизор. Наконец, машину починили и вы заплатили в кассу <<zz_repair>> рублей.'
					if $car['wreck'] = 1: 'Мастер, перед тем как отдать вам ключи сказал, чтобы вы постарались не доводить машину до такого состояния.'
					killvar 'zz_repair'
					act 'Уйти': gt 'north'
				end
			end
		end
	end
	if $car['location'] ! $curloc: 'Мастер усмехнулся и сказал "Девушка, мне нужно машину посмотреть, что бы хоть, что-то вам сказать. Пригоняйте ее к автосервису, поглядим."'
	if $car['wreck'] = 1 and $car['location'] ! $curloc and $car['id'] >= 0:
		gs 'zz_render','','','В автосервисе действует услуга эвакуации поврежденных автомобилей до автосервиса, стоимость 2500'
		if money >= 2500:
			act 'Оплатить доставку авто (2500 руб 1 час)':
				*clr & cla
				money -= 2500
				$car['location'] = 'autoservisF'
				minut += 60
				gs 'zz_render','','images/pic/autoservis2.jpg'
				gs 'zz_render','','','Вы просидели целый час в автосервисе, ожидая, когда привезут ваш автомобиль. Наконец, время прошло и ваш автомобиль был доставлен к воротам автосервиса.'
				act 'К мастеру': gt 'autoservisF','start'
			end
		end
	end
	act 'Уйти': gt'north'
end