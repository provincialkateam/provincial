! проверяем местонахождение, если совпадает - выводим строчку
if $args[0] = 'check':
	if $car['id'] >= 0 and $car['location'] = $curloc:
		gs 'zz_render','','','Возле дороги припаркован <a href="exec:gs ''car'',''salon''">ваш '+$car['name']+'</a>.'
	end
	exit
end
! авто, салон
if $args[0] = 'salon':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'picar/salon' + $car['id'] + '.jpg', func('car_strings', 'local_str1')
	if $car['cur_cond'] <= 0: $car['cur_cond'] = 0 & $car['wreck'] = 1
	if $car['cur_cond'] <= 0 or $car['wreck'] = 1: 'Машина не заводится, ей нужен ремонт.'
	if $car['cur_cond'] >= $car['base_cond']*3/4 and $car['wreck'] = 0: 'Машина в отличном состоянии.'
	if $car['cur_cond'] < $car['base_cond']*3/4 and $car['cur_cond'] >= $car['base_cond']*2/4 and $car['wreck'] = 0: 'При движении машины есть какие то посторонние шумы'
	if $car['cur_cond'] < $car['base_cond']*2/4 and $car['cur_cond'] >= $car['base_cond']*1/4 and $car['wreck'] = 0: 'Машина грохочет и еле едет.'
	if $car['cur_cond'] < $car['base_cond']*1/4 and $car['wreck'] = 0: 'Как этот унитаз все еще может ехать, является загадкой даже для конструкторов.'
	if prava = 0: 'У вас нет прав.'
	act 'Выйти из машины': gt iif($curloc = 'zaprF', $curloc, $loc), $metka
	if $car['fuel'] > 0 and $car['wreck'] = 0 and prava > 0:
		if $car['cur_cond'] >= $car['base_cond']*3/4 and $car['wreck'] = 0:
			if RAND(0,1000) = 1000: $car['wreck'] = 1
		elseif $car['cur_cond'] < $car['base_cond']*3/4 and $car['cur_cond'] >= $car['base_cond']/2 and $car['wreck'] = 0:
			if RAND(0,100) = 100: $car['wreck'] = 1
		elseif $car['cur_cond'] < $car['base_cond']/2 and $car['cur_cond'] >= $car['base_cond']/4 and $car['wreck'] = 0:
			if RAND(0,100) >= 80: $car['wreck'] = 1
		elseif $car['cur_cond'] < $car['base_cond']/4 and $car['wreck'] = 0:
			if RAND(0,100) >= 40: $car['wreck'] = 1
		elseif $car['wreck'] = 1:
			gs 'zz_render', '', '', func('car_strings', 'local_str2')
			act 'Твою мать': gs 'car', 'salon'
		end
		if alko > 0:
			if RAND(0,100) <= alko:
				gs 'zz_render', '', '', func('car_strings', 'local_str3')
				if money >= 50000:
					act 'Дать взятку 50 тысяч':
						cla
						money -= 50000
						gs 'zz_render', '', '', func('car_strings', 'local_str4')
						act 'В салон': gs 'car','salon'
					end
				end
				act 'Давай, все по закону':
					cla
					prava = 0
					gs 'zz_render', '', '', func('car_strings', 'local_str5')
					act 'В салон': gs 'car','salon'
				end
				exit
			end
		elseif alko >= 10:
			if RAND(0,100) >= 50:
				$car['cur_cond'] = $car['cur_cond'] / 2
				$car['wreck'] = 1
				gs 'zz_render', '', '', func('car_strings', 'local_str6')
				act 'В салон': gs 'car', 'salon'
				exit
			end
		end
		if $car['wreck'] = 0: gs 'car', 'list'
	end
	exit
end
! список мест
if $args[0] = 'list':
	$_str = ''
	if $car['fuel'] < 10: $_str += '<red>Вам '+ iif($car['fuel'] <= 5, 'срочно','') +' надо заправить автомобиль!</red><br/>'
	if money < (40-$car['fuel']+1)*30:
		$_str += '<red>Вот только в карманах пустота...</red><br/>'
	else
		if $car['location'] ! 'zaprF': $_str += '<a href="exec:gs ''car'',''drive'',''zaprF''">Ехать на заправку</a><br/>'
	end
	if $car['fuel'] >= 3:
		if $car['location'] ! 'down': $_str += '<a href="exec:gs ''car'',''drive'',''down''">Ехать в Центр</a><br/>'
		if $car['location'] ! 'street': $_str += '<a href="exec:gs ''car'',''drive'',''street''">Ехать в Южный район</a><br/>'
		if $car['location'] ! 'lake': $_str += '<a href="exec:gs ''car'',''drive'',''lake'',''start''">Ехать к озеру</a><br/>'
		if $car['location'] ! 'zz_park': $_str += '<a href="exec:$control_point = ''street'' & gs ''car'',''drive'',''zz_park''">Ехать в городской парк</a><br/>'
		if $car['location'] ! 'nord': $_str += '<a href="exec:gs ''car'',''drive'',''nord''">Ехать в Северный район</a><br/>'
		if $car['location'] ! 'autotraidF': $_str += '<a href="exec:gs ''car'',''drive'',''autotraidF''">Ехать на авторынок</a><br/>'
		if $car['location'] ! 'autoservisF': $_str += '<a href="exec:gs ''car'',''drive'',''autoservisF''">Ехать в автосервис</a><br/>'
		if $car['location'] ! 'dachi': $_str += '<a href="exec:gs ''car'',''drive'',''dachi''">Ехать на дачу</a><br/>'
		if $car['location'] ! 'gorodok': $_str += '<a href="exec:gs ''car'',''drive'',''gorodok''">Ехать в Павлово</a><br/>'
		if $car['location'] ! 'gadukino': $_str += '<a href="exec:gs ''car'',''drive'',''gadukino''">Ехать в Гадюкино</a><br/>'
	end
	gs 'zz_render','','', '<center>'+$_str+'</center>'
	killvar '$_str'
	exit
end
! поездка
if $args[0] = 'drive':
	! $args[1] - destination
	minut += rand(15,25)
	$car['fuel'] -= 1
	$car['location'] = $args[1]
	$metka = $args[2]
	gt $car['location'], $metka
	exit
end