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
	if apteka_init ! day:
		_apt_i = 0
		:loop_apteka
		if _apt_i <= 8:
			aptStore['0,<<_apt_i>>'] = iif(_apt_i = 7,iif(KandidNapr = 1 or Kandidoz >= 30,1,0),rand(3,5))
			aptStore['1,<<_apt_i>>'] = iif(_apt_i = 7,iif(KandidNapr = 1 or Kandidoz >= 30,1,0),rand(15,25))
			_apt_i += 1
			jump 'loop_apteka'
		end
		apteka_init = day
	end
	! формируем табличку
	_apt_num = iif($control_point = 'gorodok',0,1)
	gs 'zz_render','','','<div id="apteka">' + func('apteka','mk_table') + '</div>'
	if _apt_num = 0:
		gs 'zz_render','','','За прилавком как всегда сидит тетя Люда.**\\\- Привет <<$name[3]>>. Как жизнь? Как настроение?///'
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
	$_apt_msg = 'Вы купили ' + $apt['<<args[1]>>,name']
	if money >= _apt_price:
		money -= _apt_price
	elseif karta >= _apt_price:
		karta -= _apt_price
	else
		! без денег сюда не должны попасть, но на всякий случай предусмотрим
		$_apt_msg = 'У вас не недостаточно денег.'
		gt 'apteka','init',$_apt_msg
	end
	!убираем покупку с аптеки
	aptStore['<<_apt_num>>,<<args[1]>>'] -= 1
	! добавляем покупки в инвентарь ГГ
	if args[1] = 0: prezik += 5
	if args[1] = 1: pregtest += 2
	if args[1] = 2: tabletki += 28
	if args[1] = 3: vitamin += 20
	if args[1] = 4: lekarstvo += 10
	if args[1] = 5: lipbalm += 25
	if args[1] = 6: fatdel += 1
	if args[1] = 7: Kandidoz = 0 & $_apt_msg += '<br>Сразу же около кассы вы приняли таблетку от молочницы'
	if args[1] = 8: lubri += 5
	killvar '_apt_price'
	gt 'apteka','init',$_apt_msg
end
! формирование таблицы товаров
if $args[0] = 'mk_table':
	$_apt_table = '<table width=100%>'
	$_apt_table += '<tr><th rowspan=10 width=420><img src=images/qwest/apteka/apteka_worker_<<_apt_num+1>>.jpg></th>'
	$_apt_table += '<th colspan=2>Наименование</th>'
	$_apt_table += '<th width=80>Цена</th></tr>'
	_apt_i = 0
	:loop_apteka_table
	if _apt_i <= 8:
		if aptStore['<<_apt_num>>,<<_apt_i>>'] > 0:
			$_apt_table += '<tr>'
				$_apt_table += '<td width=25><a href="exec:msg '''+$apt['<<_apt_i>>,desc']+'''"><img src=images/qwest/apteka/anptekainfo.jpg></a></td>'
				$_apt_table += '<td>'+$apt['<<_apt_i>>,name']+'</td>'
				$_apt_table += '<td>' + iif(money > $apt['<<_apt_i>>,price'] or karta > $apt['<<_apt_i>>,price'],'<a href="exec:gs''apteka'',''buy'',<<_apt_i>>">'+$apt['<<_apt_i>>,price']+'</a>',$apt['<<_apt_i>>,price']) + ' руб.</td>'
			$_apt_table += '</tr>'
		end
		_apt_i += 1
		jump 'loop_apteka_table'
	end
	$_apt_table += '</table>'
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
	$apt['7,name'] = 'Таблетки от молочницы'
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
	$apt['0,desc'] = '<b><<$apt[''0,name'']>></b><br>Средство контрацепции барьерного типа, а также средство защиты от многих патогенов, передающихся половым путём. Презервативы вторично использовать нельзя.<br>В упаковке 5 шт.'
	$apt['1,desc'] = '<b><<$apt[''1,name'']>></b><br>Экспресс-тест позволяющий определить признаки беременности женщины на ранней стадии. Тест-полоску можно использовать только один раз.<br>В упаковке 2 шт.'
	$apt['2,desc'] = '<b><<$apt[''2,name'']>></b><br>Комбинированные оральные контрацептивы на основе эстрогена и прогестина.<br>Применение: ежедневно по одной таблетке в день.<br>В упаковке 28 таблеток в блистере.'
	$apt['3,desc'] = '<b><<$apt[''3,name'']>></b><br>Комплексное решение для вашего здоровья и поддержания имунитета. Помогют увеличить эффективность антибиотиков и противогрипковых препаратов. Противопоказаний нет.<br>Применение: по одной таблетки в день.<br>В упаковке 20 таблеток в блистере.'
	$apt['4,desc'] = '<b><<$apt[''4,name'']>></b><br>Антибиотики. Необходимо принимать во время простудных заболеваний, хорошо помогает сократить процесс лечения и улучшает здоровье. При отсутствии болезни неэффективны.<br>Применение: по одной таблетке в день.<br>В упаковке 10 таблеток в блистере.'
	$apt['5,desc'] = '<b><<$apt[''5,name'']>></b><br>Бальзам увлажняет губы, придает им блеск, тем самым увеличивает привлекательность губ. Есть побочные эффекты: при постоянном использовании необратимо увеличивает губы.<br>Тюбик, хватит на 25 применений.'
	$apt['6,desc'] = '<b><<$apt[''6,name'']>></b><br>Средство для сжигания жира, действует в течение Х дней с момента приема. Интенсивные физические нагрузки, например бег, значительно увеличивают эффективность препарата.<br>В упаковке 1 ядреная капсула.'
	$apt['7,desc'] = '<b><<$apt[''7,name'']>></b><br>Весьма эффективное средство. Действует мнгновенно, можно даже не запивать водой. Принимайте сразу как окажется в руках.<br>Рекомендуется так же пропить курс витаминов.<br>В упаковке 1 шт.'
	$apt['8,desc'] = '<b><<$apt[''8,name'']>></b><br>Гель-смазка защищает слизистую оболочку от появления микротрещин и раздражения, через которые проникают инфекции, снимает болевые ощущения и повышает комфорт. Лубрикант не имеет противопоказаний к применению.<br>Тюбик, хватит на 5 применений.'
	exit
end