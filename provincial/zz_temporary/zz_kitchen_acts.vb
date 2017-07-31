if $args[0] = 'drink':
	if $args[1] = 'tea':
		$zz_str[0] = 'Чай'
		$zz_str[1] = 'кружку чая'
	elseif $args[1] = 'water':
		$zz_str[0] = 'Вода'
		$zz_str[1] = 'стакан воды'
	elseif $args[1] = 'coffee':
		$zz_str[0] = 'Кофе'
		$zz_str[1] = 'кружку кофе'
	else
		$zz_str[0] = 'Лимонад'
		$zz_str[1] = 'банку лимонада'
	end
	cumlip = 0
	if water >= 20:
		water = 24
		gs 'zz_render','',$args[2],$zz_str[0] + ' в вас больше не лезет.'
	else
		water += 20
		gs 'zz_render','',$args[2],'Вы с удовольствием выпили ' + $zz_str[1]
	end
	killvar '$zz_str'
end
if $args[0] = 'drink_all':
	act 'Пить':
		cumlip = 0
		minut += 1
		gs 'zz_kitchen_acts', 'drink', 'tea'
		gs 'stat'
	end
end
if $args[0] = 'eat':
	! $args[1] - тип: перекус (lunch), диетическая еда (diet) или плотный обед (по умолчанию)
	! $eat_img - фотка, при отсутствии - фотка по умолчанию
	! $eat_text - текст, при отсутствии - текст по умолчанию
	manna += iif($args[1]='lunch' or $args[1]='diet',10,20)
	minut += iif($args[1]='lunch',15,30)
	health += iif($args[1]='lunch' or $args[1]='diet',5,10)
	cumlip = 0
	if $loc = 'kuhr':
		edahot -= 1
		dirttarelka += 1
		garbage += 1
		cltarelka -= 1
	end
	if $loc = 'kat_apartment' and kat_house = 0: eda -= 1
	if energy >= 24:
		$eat_str = 'Еда в вас больше не лезет, и вы просто ковыряетесь в ней.'
		energy = 24
	elseif energy >= 18 and energy < 24:
		if $args[1] = 'diet': edaD -= 1
		body['day_weight'] += iif($args[1]='diet',1,iif($args[1]='lunch',2, 3))
		energy = 24
		$eat_str = 'Вы через силу затолкали в себя еду.'
	elseif energy >= 8 and energy < 18:
		if $args[1] = 'diet': edaD -= 1
		body['day_weight'] += iif($args[1]='diet',0,iif($args[1]='lunch',1, 2))
		energy += iif($args[1]='lunch',10,20)
		$eat_str = 'Вы с удовольствием поели.'
	else
		if $args[1] = 'diet': edaD -= 1
		body['day_weight'] += iif($args[1]='diet',-1,iif($args[1]='lunch',0,1))
		energy += iif($args[1]='lunch',10,20)
		$eat_str = 'Вы с большим удовольствием поели.'
	end
	gs 'zz_render','',iif($eat_img='','images/pics/food.jpg',$eat_img),iif($eat_text='',$eat_str,$eat_text)
	if energy >= 24: energy = 24
	$eat_text = ''
	$eat_img = ''
	killvar '$eat_img'
	killvar '$eat_text'
	killvar '$eat_str'
end
if $args[0] = 'eat_full':
	act 'Плотно покушать':
		*clr & cla
		gs 'zz_kitchen_acts', 'eat'
		gs 'zz_kitchen_acts', 'drink', 'tea'
		gs 'stat'
		act 'Встать из за стола': gt $loc, $metka
	end
end
if $args[0] = 'eat_diet':
	if edaD > 0:
		gs 'zz_render','','','В холодильнике хранится диетическая еда, которой хватит на <b><<edaD>></b> порций.'
		act 'Есть диетическую еду (30 мин)':
			*clr & cla
			gs 'zz_kitchen_acts', 'eat', 'diet'
			gs 'zz_kitchen_acts', 'drink', 'tea'
			gs 'stat'
			act 'Встать из за стола': gt $loc, $metka
		end
	end
end
if $args[0] = 'lunch':
	act 'Перекусить':
		*clr & cla
		gs 'zz_kitchen_acts', 'eat', 'lunch'
		gs 'zz_kitchen_acts', 'drink', 'tea'
		gs 'stat'
		act 'Встать из за стола': gt $loc, $metka
	end
end
if $args[0] = 'vitamin':
	if vitamin > 0:
		gs 'zz_render','','','У вас <<vitamin>> витаминок.'
		if vitaminday ! day:
			act 'Выпить витаминку':
				*clr & cla
				minut += 2
				water += 5
				vitaminday = day
				vitamin -= 1
				if KandidozOnce = 1: Kandidoz -= 2
				if GerpesOnce = 1: Gerpes -= 2
				if SifacOnce = 1 and Sifilis >= 10:Sifilis -= RAND(0,1)
				gs 'zz_funcs', 'skin', '+'
				cumlip = 0
				gs 'zz_render','','','Вы выпили витаминку'
				act 'Отойти': gt $loc, $metka
			end
		end
	end
end
if $args[0] = 'pills':
	if lekarstvo > 0:
		gs 'zz_render','','','У вас <<lekarstvo>> таблеток.'
		if sick > 0 and lekarday ! day:
			act 'Выпить таблетку':
				*clr & cla
				minut += 5
				lekarday = day
				lekarstvo -= 1
				sick -= sick / 5
				cumlip = 0
				gs 'zz_render','','images/inBed/lekr' + RAND(1,9) + '.jpg','Вы выпили таблетку'
				act 'Отойти': gt $loc, $metka
			end
		end
	end
end
if $args[0] = 'fatdel':
	if fatdel > 0:
		act 'Употребить жиросжигатели':
			*clr & cla
			fatdel -= 1
			fatdel_day += 10
			cumlip = 0
			gs 'zz_render','','','Вы выпили жиросжигающую капсулу. Эти капсулы действуют постепенно и результаты будут видны не сразу.'
			act '...': gt $loc, $metka
		end
	end
end
if $args[0] = 'cookie':
	if pranik > 0:
		gs 'zz_render','','','Печенья хватит ещё на <<pranik>> раз.'
		act 'Выпить чаю с печеньем (5 мин)':
			*clr & cla
			minut += 5
			pranik -= 1
			health += 5
			manna += 10
			energy += 10
			water += 10
			cumlip = 0
			body['day_weight'] += iif(energy > 24,2,iif(energy>15 and energy<24,1,0))
			gs 'stat'
			gs 'zz_render','','images/pics/food.jpg','Вы попили чаю с печеньем: очень сладко и вредно для фигуры, но так приятно!'
			act 'Встать из за стола': gt $loc, $metka
		end
	end
end
if $args[0] = 'all':
	if args[1] ! 1 or args[1] = 1 and edahot > 0 and cltarelka > 0:
		gs 'zz_kitchen_acts', 'eat_full'
		gs 'zz_kitchen_acts', 'lunch'
	end
	gs 'zz_kitchen_acts', 'eat_diet'
	gs 'zz_kitchen_acts', 'drink_all'
	gs 'zz_kitchen_acts', 'cookie'
	gs 'zz_kitchen_acts', 'fatdel'
	gs 'zz_kitchen_acts', 'vitamin'
	gs 'zz_kitchen_acts', 'pills'
end