*clr & cla
minut += 5
gs 'stat'
gs 'zz_render','АЗС','pic/zapr.jpg','В связи с особенностями устройства бензоколонок, все автомобили заправляются до полного бака.<br>Стоимость 1 литра бензина - 30 рублей.'
gs 'car', 'check'
if $car['fuel'] < 40 and $car['id'] >= 0:
	zprbenz = 40 - $car['fuel']
	if zprbenz * 30 <= money:
		act 'Заправить бензин':
			*clr & cla
			$car['fuel'] = 40
			money -= zprbenz * 30
			gs 'zz_render','','pic/zapr1.jpg','Вы залили полный бак и оплатили ' + zprbenz * 30 + ' рублей.'
			act 'Убрать пистолет': gt 'zaprF'
		end
	else
		gs 'zz_render','','','У вас не хватает денег на заправку.'
	end
end