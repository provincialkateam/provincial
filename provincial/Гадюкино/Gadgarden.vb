if $ARGS[0] = 'garden':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	grandpa_ingadgarden = 0
	grandma_ingadgarden = 0
	gs 'stat'
	gs 'time'
	$_str = 'Огород'
	gs 'zz_render', $_str, func('zz_funcs','mk_image','qwest/gadukino/new/garden'),	'Большой огород на котором растет практически все.'
	if snow = 0:gs 'zz_render', '', '','Немного в стороне есть <a href="exec: gt ''Gadgarden'',''strawberry'' ">клубничная делянка</a> и <a href="exec: gt ''Gadgarden'',''fruit_garden'' ">фруктовый сад</a>.'
	if (month >= 6 and month <= 8 and graze_cow = 0 or  month >= 5 and month <= 9 and graze_cow > 0) and sunWeather >= 0 and hour > 7 and hour < 13:grandma_ingadgarden = 1 & 'На огороде ковыряется в грядках ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+'.'
	if sunWeather >= 0 and hour > 7 and hour < 13 and graze_cow = 0 and (month = 5 or month = 9):grandpa_ingadgarden = 1 & grandma_ingadgarden = 1 & 'На огороде работают ваши '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+' и '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','бабушка')+'.'
	if grandma_ingadgarden = 1 and grandmaknowsick = 1:gt'grandma'
	!задание бабушки
	if work_garden = 1:
		act 'Работать на огороде':
			*clr & cla
			minut += 180
			sweat += 1
			work_garden = 0
			grandmahelp += 3
			grandmaQW += 1
			if stren < 30:stren += 1
			body['day_weight'] -= 1
			gs 'stat'
			gs 'zz_render', $_str, 'qwest/gadukino/new/work_garden'+rand(1,5)+'.jpg','Вы некоторое время выполняете различную работу на огороде.'
			act 'Закончить': gt 'Gadgarden', 'garden'
		end
	end
	!задание бабушки
	if water_garden = 1:
		act 'Поливать огород':
			*clr & cla
			sweat += 1
			minut += 60
			water_garden = 0
			grandmahelp += 1
			grandmaQW += 1
			if vital < 30:vital += 1
			body['day_weight'] -= 1
			gs 'stat'
			gs 'zz_render', $_str, 'qwest/gadukino/new/water_garden.jpg','Вы в течение часа поливаете грядки на огороде.'
			act 'Закончить': gt'Gadgarden','garden'
		end
	end
	!задание бабушки
	if harvest_garden = 1:
		act 'Собирать урожай':
			*clr & cla
			minut += 180
			sweat += 1
			harvest_garden = 0
			grandmahelp += 3
			grandmaQW += 1
			if stren < 30:stren += 1
			body['day_weight'] -= 1
			gs 'stat'
			gs 'zz_render', $_str, 'qwest/gadukino/new/harvest_garden'+rand(1,5)+'.jpg','Вы в течение нескольких часов собираете овощи на огороде.'
			act 'Закончить': gt'Gadgarden','garden'
		end
	end
	act 'Выйти во двор':
		minut += 5
		gt 'Gaddvor'
		killvar '$_str'
	end
	if current_clothing = 0: gt 'grandparents_events','garden_nude'
end
if $ARGS[0] = 'strawberry':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs 'stat'
	gs 'time'
	$_str = 'Клубничная делянка'
	gs 'zz_render', $_str, 'qwest/gadukino/new/strawberry'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),iif(month = 6 or month = 7,1,2),'_night')+'.jpg','Клубничная делянка на которой, в сезон, можно вырастить немного клубники.'
	if month >= 6 and month <= 7 and strawberriesday ! daystart:
		act 'Поесть клубники':
			*clr & cla
			strawberriesday = daystart
			minut += 30
			manna += 10
			water += 10
			energy += 5
			cumlip = 0
			gs 'stat'
			gs 'zz_render', $_str, 'qwest/gadukino/new/eat_strawberries.jpg','Вы некоторое время бродите по делянке собирая спелые ягоды тут же кидая их в рот.'
			act 'Закончить':gt'Gadgarden','strawberry'
		end
	end
	!задание бабушки
	if collect_strawberries = 1:
		act 'Собирать клубнику':
			*clr & cla
			minut += 180
			sweat += 1
			collect_strawberries = 0
			grandmahelp += 5
			grandmaQW += 1
			if agil < 30:agil += 1
			body['day_weight'] -= 1
			gs 'stat'
			if func('zz_clothing','is_skirt') = 0:
				gs 'zz_render', $_str, 'qwest/gadukino/new/collect_strawberries.jpg'
			else
				gs 'zz_render', $_str, 'qwest/gadukino/new/collect_strawberries'+iif(tanga = 1,'_ski','_tanga')+'.jpg'
			end
			gs 'zz_render', '', '','Вы бродите по делянке собирая спелые ягоды в корзину.'
			act 'Закончить':gt'Gadgarden','strawberry'
		end
	end
	act 'Уйти': minut += 5 & gt'Gadgarden','garden'
end
if $ARGS[0] = 'fruit_garden':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs 'stat'
    gs 'time'
    $_str = 'Фруктовый сад'
	gs 'zz_render', $_str, 'qwest/gadukino/new/fruit_garden'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'.jpg','Фруктовый сад в котором растут яблоки и груши.'
	if month >= 6 and month <= 8 and sunWeather >= 0 and hour > 7 and hour < 13 and week = 6 and graze_cow = 0:gs 'zz_render', '', '','Ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+' косит в саду траву.'
	if month >= 7 and month <= 9 and fruitday ! daystart:
		act 'Поесть фруктов':
			*clr & cla
			fruitday = daystart
			minut += 30
			manna += 10
			water += 5
			energy += 10
			cumlip = 0
			gs 'stat'
			gs 'zz_render', $_str, 'qwest/gadukino/new/eat_fruit.jpg','Вы некоторое время бродите по саду жуя спелые фрукты.'
			act 'Закончить':gt 'Gadgarden','fruit_garden'
		end
	end
	!задание бабушки
	if fruit_collect = 1:
		act 'Собирать фрукты':
			*clr & cla
			minut += 180
			sweat += 1
			fruit_collect = 0
			grandmahelp += 5
			grandmaQW += 1
			if agil < 30:agil += 1
			body['day_weight'] -= 1
			gs 'stat'
			if func('zz_clothing','is_skirt') = 0:
				gs 'zz_render', $_str, 'qwest/gadukino/new/fruit_collect.jpg'
			else
				gs 'zz_render', $_str, 'qwest/gadukino/new/fruit_collect'+iif(tanga = 1,'_ski','_tanga')+'.jpg'
			end
			gs 'zz_render', '', '','Вы собираете в саду спелые фрукты.'
			act 'Закончить': gt 'Gadgarden','fruit_garden'
		end
	end
	act 'Уйти': minut += 5 & gt 'Gadgarden','garden'
end