! --- АПТЕКА --- !
if $args[0] = '' or $args[0] = 'init':
	*clr & cla
	$_apt_msg = $args[1]
	!--
	if $_apt_msg!'':
		! сообщение о покупке
		gs 'zz_funcs','message','',$_apt_msg
		!wait 2000
		killvar '$_apt_msg'
	end
	!--
	minut += 1
	gs 'stat'
	act 'Уйти': gt 'apteka','go_out'
	if hour < 8 or hour > 18:
		gs 'zz_render','','images/qwest/apteka/aptekaclose.jpg','Аптека закрыта. Аптека работает с 8 до 19 часов.'
		exit
	end
	! базовые значения массива
	gs 'apteka','set_values'
	! заливаем текущие товары
	if apteka_init ! daystart:
		_apt_i = 0
		:loop_apteka
		if _apt_i <= 8:
			aptStore['0,<<_apt_i>>'] = iif(_apt_i = 7,iif(KandidNapr = 1 or Kandidoz >= 30,1,0),rand(3,5))
			aptStore['1,<<_apt_i>>'] = iif(_apt_i = 7,iif(KandidNapr = 1 or Kandidoz >= 30,1,0),rand(15,25))
			_apt_i += 1
			jump 'loop_apteka'
		end
		apteka_init = daystart
	end
	! формируем табличку
	_apt_num = iif($control_point = 'gorodok',0,1)
	gs 'zz_render','','','<div id="pharmacy">' + func('apteka','mk_table') + '</div>'
	if _apt_num = 0:
		gs 'zz_render','','','За прилавком как всегда сидит тетя Люда.**\\\- Привет Светуля. Как жизнь? Как настроение?///'
	else
		gs 'zz_render','','','За прилавком девушка в белом халате.**\\\- Здравствуйте, что вам необходимо?///'
	end
	exit
end
! выход с аптеки
if $args[0] = 'go_out':
	killvar '$apt'
	killvar '_apt_num'
	killvar '_apt_price'
	killvar '_apt_i'
	killvar '$_apt_table'
	killvar '$_apt_msg'
	gt $control_point
end
! обработка покупки
if $args[0] = 'buy':
	_apt_price = $apt['<<args[1]>>,price']
	if func('zz_funcs', 'payment', 2,_apt_price, 1) = 1:
		$_apt_msg = '<green>Вы купили ' + $apt['<<args[1]>>,name'] +'</green>'
		!убираем покупку с аптеки
		aptStore['<<_apt_num>>,<<args[1]>>'] -= 1
		! добавляем покупки в инвентарь ГГ
		if args[1] = 0: condom += 5
		if args[1] = 1: pregtest += 2
		if args[1] = 2: tabletki += 28
		if args[1] = 3: vitamin += 20
		if args[1] = 4: lekarstvo += 10
		if args[1] = 5: lipbalm += 25
		if args[1] = 6: fatdel += 1
		if args[1] = 7: Kandidoz = 0 & $_apt_msg += '**Сразу же около кассы вы приняли таблетку от молочницы'
		if args[1] = 8: lubri += 5
	end
	killvar '_apt_price'
	gs 'stat'
	gt 'apteka','init',$_apt_msg
end
! формирование таблицы товаров
if $args[0] = 'mk_table':
	$_apt_table = '<ul class="products">'
	_apt_i = 0
	:loop_apteka_table
	if _apt_i <= 8:
		if aptStore['<<_apt_num>>,<<_apt_i>>'] > 0:
			$_apt_table += '<li class="product-wrapper">'
			$_apt_table += '<div class="product">'
			$_apt_table += 	'<div class="product-main">'
			$_apt_table += 		'<div class="product-text">'
			$_apt_table += 		'<h2 class="product-name">'+$apt['<<_apt_i>>,name']+'</h2><div class="product-price"><b>'+ $apt['<<_apt_i>>,price']+ '</b><small> руб.</small></div><p>'+$apt['<<_apt_i>>,desc']+'</p>'
			$_apt_table += 		'</div>'
			$_apt_table += 	'</div>'
			$_apt_table += 	'<div class="product-details-wrap">'
			$_apt_table += 		'<div class="product-details">'
			$_apt_table += 			'<div class="product-availability">'
			$_apt_table +=  		 iif(func('zz_funcs','prepayment',2,$apt['<<_apt_i>>,price']) = 1,'<a class="product-button" href="exec:gs''apteka'',''buy'',<<_apt_i>>">Купить</a>','<span class="product-expensive">Нужно больше золота</span>')
			$_apt_table +=	        '</div>'
			$_apt_table += 	    '</div>'
			$_apt_table += 	'</div>'
			$_apt_table += '</div>'
			$_apt_table += '</li>'
		end
		_apt_i += 1
		jump 'loop_apteka_table'
	end
	$_apt_table += '<img class="pharmacy-seller" src=images/qwest/apteka/apteka_worker_<<_apt_num+1>>.jpg></ul>'
	$result = $_apt_table
	killvar '$_apt_table'
	exit
end
! базовая заливка товаров
if $args[0] = 'set_values':
	! init values
	!Наименование товаров
	$apt['0,name'] = 'Презервативы'
	$apt['1,name'] = 'Тест на беременность'
	$apt['2,name'] = 'Противозачаточные таблетки'
	$apt['3,name'] = 'Витамины'
	$apt['4,name'] = 'Лекарства'
	$apt['5,name'] = 'Увлажняющий бальзам для губ'
	$apt['6,name'] = 'Жиросжигатели'
	$apt['7,name'] = 'Таблетка от молочницы'
	$apt['8,name'] = 'Лубрикант'
	!Цены товаров
	$apt['0,price'] = 100
	$apt['1,price'] = 100
	$apt['2,price'] = 500
	$apt['3,price'] = 500
	$apt['4,price'] = 500
	$apt['5,price'] = 1000
	$apt['6,price'] = 1500
	$apt['7,price'] = 1500
	$apt['8,price'] = 300
	!Описание товаров
	$apt['0,desc'] = 'Средство контрацепции барьерного типа, а также средство защиты от многих патогенов, передающихся половым путём. Презервативы вторично использовать нельзя.**В упаковке 5 шт.'
	$apt['1,desc'] = 'Экспресс-тест позволяющий определить признаки беременности женщины на ранней стадии. Тест-полоску можно использовать только один раз.**В упаковке 2 шт.'
	$apt['2,desc'] = 'Комбинированные оральные контрацептивы на основе эстрогена и прогестина.**Применение: ежедневно по одной таблетке в день.**В упаковке 28 таблеток в блистере.'
	$apt['3,desc'] = 'Комплексное решение для вашего здоровья и поддержания имунитета. Помогают увеличить эффективность антибиотиков и противогрипковых препаратов. Противопоказаний нет.**Применение: по одной таблетки в день.**В упаковке 20 таблеток в блистере.'
	$apt['4,desc'] = 'Антибиотики. Необходимо принимать во время простудных заболеваний, хорошо помогает сократить процесс лечения и улучшает здоровье. При отсутствии болезни неэффективны.**Применение: по одной таблетке в день.**В упаковке 10 таблеток в блистере.'
	$apt['5,desc'] = 'Бальзам увлажняет губы, придает им блеск, тем самым увеличивает привлекательность губ. Есть побочные эффекты: при постоянном использовании необратимо увеличивает губы.**Тюбик, хватит на 25 применений.'
	$apt['6,desc'] = 'Cредство для сжигания жира, действует в течение 10 дней с момента приема. Интенсивные физические нагрузки, например бег, значительно увеличивают эффективность препарата.**В упаковке 1 капсула.'
	$apt['7,desc'] = 'Весьма эффективное средство. Действует мнгновенно, можно даже не запивать водой. Принимайте сразу как окажется в руках.**Рекомендуется так же пропить курс витаминов.**В упаковке 1 шт.'
	$apt['8,desc'] = 'Гель-смазка защищает слизистую оболочку от появления микротрещин и раздражения, через которые проникают инфекции, снимает болевые ощущения и повышает комфорт. Лубрикант не имеет противопоказаний к применению.**Тюбик, хватит на 5 применений.'
	exit
end