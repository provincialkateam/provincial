if $args[0] = '' or $args[0] = 'start':
	*clr & cla
	minut += 1
	killvar '$zz_arr0'
	killvar 'zz_arr1'
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Супермаркет','images/common/shop/shop.jpg','В холле стоит <a href="exec: gt''zz_atm'',''main'' ">универсальный банковский терминал</a>, где вы можете положить или снять деньги со счета, пополнить баланс мобильного, а также оплатить некоторые услуги.<br>Самое большое место в супермаркете занимает <a href="exec: gt ''shop'',''food''">продуктовый отдел</a>, но в магазине есть еще отделы <a href="exec: gt ''shop'',''cosm''">косметики</a>, <a href="exec: gt ''shop'',''hos''">хозяйственный</a>, <a href="exec: gt ''shop'',''clo''">одежды</a>, и отдел <a href="exec: gt ''shop'',''teh''">бытовой техники</a>.'
	if hour >= 8 and hour <= 20:
		if $loc = 'gorodok': gs 'zz_render','','','Чуть в сторонке разместился небольшой <a href="exec:gt''shop'',''sport''">магазинчик спорттоваров.</a>'
		gs 'zz_render','','','Недалеко от входа стоит <a href="exec:gt ''zz_common'',''icecream''">прилавок с мороженным</a> и <a href="exec: gt ''zz_common'',''coffee''">кофейня.</a>'
	end
	if $loc = 'gorodok':
		if week < 6 and hour >= 8 and hour < 16: gs 'zz_render','','','Ваша сестра <a href="exec:GT ''sister''">Аня</a> сидит на кассе.'
		gs 'zz_family', 'mother_sheduler'
	end
	if $loc = 'street' and rand(1,100) >= 95: gs 'event','dimaQW_intro'
	if hour >= 8 and hour <= 20:
		gs 'zz_render','','','В магазине толпы покупателей.'
		if TorgPredZ > 0 and (($loc = 'street' and StreetShopTPday ! day) or ($loc = 'nord' and nordShopTPday ! day) or ($loc = 'torgcentr' and downShopTPday ! day)):
			act 'Расставлять продукцию':
				*clr & cla
				minut += RAND(40,130)
				gs 'stat'
				TorgPredZ -= 1
				TorgPredZV += 1
				if $loc = 'street':
					StreetShopTPday = day
				elseif $loc = 'nord':
					nordShopTPday = day
				elseif $loc = 'torgcentr':
					downShopTPday = day
				end
				gs 'zz_render','Супермаркет','images/common/shop/work'+rand(1,3)+'.jpg','Вы расставляли продукцию довольно долгое время и когда наконец справились, то пошли на кассу, где вам пробили чек.'
				act 'Выйти': gt'shop','start'
			end
		end
	else
		gs 'zz_render','','','Магазин закрыт.'
	end
	act 'Выйти из магазина': gt $loc, $metka
end
if $ARGS[0] = 'food':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Продуктовый отдел','images/common/shop/food.jpg'
	if hour < 8 or hour > 20: gs 'shop', 'closed' & exit
	gs 'shop', 'make_table', 0, 5
	act 'Выйти из отдела': gt 'shop'
end
if $ARGS[0] = 'cosm':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Отдел косметики','images/common/shop/cosm.jpg'
	if hour < 8 or hour > 20: gs 'shop', 'closed' & exit
	if cheatHapri_mod = 1:
		gs 'shop', 'make_table', 6, 13
	else
		gs 'shop', 'make_table', 6, 12
	end
	act 'Выйти из отдела': gt 'shop', 'start'
end
if $ARGS[0] = 'hos':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Отдел хозтоваров','images/common/shop/hos.jpg'
	if hour < 8 or hour > 20: gs 'shop', 'closed' & exit
	gs 'shop', 'make_table', 14, 18
	act 'Выйти из отдела': gt'shop','start'
end
if $ARGS[0] = 'clo':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Отдел женской одежды','images/common/shop/clo.jpg'
	act 'Выйти из отдела': gt 'shop','start'
	gs 'shop', 'make_table', 26, 28
	gs 'zz_render','','','<center><b>Офисная одежда</b></center>'
	gs 'zz_clothing', 'make_shop', 10
	gs 'zz_render','','','<center><b>Сарафаны</b></center>'
	gs 'zz_clothing', 'make_shop', 1
	gs 'zz_render','','','<center><b>Джинсы</b></center>'
	gs 'zz_clothing', 'make_shop', 2
	gs 'zz_render','','','<center><b>Шорты, майки</b></center>'
	gs 'zz_clothing', 'make_shop', 4
	gs 'zz_render','','','<center><b>Юбки, блузки</b></center>'
	gs 'zz_clothing', 'make_shop', 5
	gs 'zz_render','','','<center><b>Леггинсы</b></center>'
	gs 'zz_clothing', 'make_shop', 6
end
if $ARGS[0] = 'teh':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Отдел бытовой техники','images/common/shop/teh.jpg'
	if hour < 8 or hour > 20: gs 'shop','closed' & exit
	gs 'shop', 'make_table', 19, 25
	act 'Выйти из отдела': gt 'shop'
end
if $args[0] = 'sport':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Спортивные товары','images/common/shop/sport.jpg'
	act 'Выйти':
		minut += 5
		gs 'zz_clothing', 'dispose'
		gt iif($loc = 'gorodok','shop','torgcentr')
	end
	if hour >= 8 and hour <= 20:
		gs 'shop', 'make_table', 29, 31
		! 3 - shop_id
		gs 'zz_clothing','make_shop',3
	end
end
if $args[0] = 'make_table':
	! food
	$zz_arr0[0] = 'Еда' & zz_arr1[0] = 200
	$zz_arr0[1] = 'Диетическая еда' & zz_arr1[1] = 400
	$zz_arr0[2] = 'Бутылочка воды' & zz_arr1[2] = 50
	$zz_arr0[3] = 'Бутерброд' & zz_arr1[3] = 50
	$zz_arr0[4] = 'Печенье' & zz_arr1[4] = 400
	$zz_arr0[5] = 'Бутылка вина' & zz_arr1[5] = 500
	! cosmetics
	$zz_arr0[6] = 'Маленькая косметичка' & zz_arr1[6] = 500
	$zz_arr0[7] = 'Косметичка' & zz_arr1[7] = 1000
	$zz_arr0[8] = 'Бритвенный станок(5шт)' & zz_arr1[8] = 300
	$zz_arr0[9] = 'Крем для загара' & zz_arr1[9] = 300
	$zz_arr0[10] = 'Шампунь' & zz_arr1[10] = 300
	$zz_arr0[11] = 'Тампоны(20шт)' & zz_arr1[11] = 200
	$zz_arr0[12] = 'Влажные салфетки' & zz_arr1[12] = 100
	if cheatHapri_mod = 1: $zz_arr0[13] = 'Расческа' & zz_arr1[13] = 200
	! common
	$zz_arr0[14] = 'Средство для мытья посуды' & zz_arr1[14] = 200
	$zz_arr0[15] = 'Стиральный порошок' & zz_arr1[15] = 200
	$zz_arr0[16] = 'Набор из 3-х тарелок' & zz_arr1[16] = 1000
	$zz_arr0[17] = 'Краска для стен' & zz_arr1[17] = 800
	$zz_arr0[18] = 'Рулон ткани' & zz_arr1[18] = 500
	! tech
	$zz_arr0[19] = 'Небольшой телевизор с кинескопом' & zz_arr1[19] = 10000
	$zz_arr0[20] = 'Большой плазменный телевизор' & zz_arr1[20] = 35000
	$zz_arr0[21] = 'Ноутбук' & zz_arr1[21] = 25000
	$zz_arr0[22] = 'Посудомоечная машина' & zz_arr1[22] = 30000
	$zz_arr0[23] = 'Стиральная машина' & zz_arr1[23] = 20000
	$zz_arr0[24] = 'Мини фотоаппарат, замаскированный под сигаретную пачку' & zz_arr1[24] = 40000
	$zz_arr0[25] = 'Вебкамера' & zz_arr1[25] = 1000
	! clothing
	$zz_arr0[26] = 'Белье' & zz_arr1[26] = 150
	$zz_arr0[27] = 'Набор белья "Неделька"' & zz_arr1[27] = 1000
	$zz_arr0[28] = 'Зимнее пальто' & zz_arr1[28] = 10000
	! sport
	$zz_arr0[29] = 'Коньки' & zz_arr1[29] = 2000
	$zz_arr0[30] = 'Скакалка' & zz_arr1[30] = 300
	$zz_arr0[31] = 'Обруч' & zz_arr1[31] = 500
	! ---
	$zz_color = '#f3f4ee'
	$zz_str = '<center><table border=0 cellpadding=1 cellspacing=1 align=center width=600 bgcolor=#ffffff>'
	$zz_str += '<tr bgcolor='+$zz_color+'><th>&nbsp;Название&nbsp;</th><th colspan=2>&nbsp;Цена за ед., руб&nbsp;</th></tr>'
	i = args[1]
	:loop_shop_table
	if i <= args[2]:
		$zz_color = iif($zz_color = '#f3f4ee', '#ffffff', '#f3f4ee')
		$zz_str += '<tr bgcolor='+$zz_color+'><td>'+$zz_arr0[i]+'</td><td>'+zz_arr1[i]+'</td><td><a href="exec:gs''shop'',''buy'',<<i>>,'+zz_arr1[i]+'">Купить</a></td></tr>'
		i += 1
		jump 'loop_shop_table'
	end
	$zz_str += '</table><br>'
	gs 'zz_render','','',$zz_str
	killvar '$zz_str'
	killvar '$zz_color'
end
if $args[0] = 'buy':
	zz_id = args[1]
	zz_price = args[2]
	if (bottle = 1 and zz_id = 2) or (buterbrod = 1 and zz_id = 3) or (wine = 1 and zz_id = 5) or (greben = 1 and zz_id = 13): gs 'shop','buy_error' & exit
	if (tv = 1 and zz_id = 19) or (tv = 2 and zz_id = 20) or (komp = 1 and zz_id = 21) or (posudomashina = 1 and zz_id = 22) or (stiralka = 1 and zz_id = 23) or (minifoto = 1 and zz_id = 24) or (webcamera = 1 and zz_id = 25): gs 'shop','buy_error' & exit
	if (palto = 2 and zz_id = 28) or (skates = 1 and zz_id = 29) or (skak = 1 and zz_id = 30) or (obruch = 1 and zz_id = 31): gs 'shop','buy_error' & exit
	if zz_id = 2 or zz_id = 3 or zz_id = 5 or zz_id = 13 or zz_id >= 19:
		zz_count = 1
	else
		zz_count = val(input("Сколько вы хотите купить?"))
	end
	if zz_count < 1: gs 'shop','buy_finalize' & exit
	if zz_count > 0 and zz_count <= 100:
		if money >= zz_price * zz_count:
			money -= zz_price * zz_count
			minut += 1
			if zz_id = 0: eda += zz_count
			if zz_id = 1: edaD += zz_count
			if zz_id = 2: bottle = 1
			if zz_id = 3: buterbrod = 1
			if zz_id = 4: pranik += zz_count*10
			if zz_id = 5: wine = 1
			if zz_id = 6: kosmetica += zz_count*15
			if zz_id = 7: kosmetica += zz_count*30
			if zz_id = 8: stanok += zz_count*5
			if zz_id = 9: krem += zz_count*20
			if zz_id = 10: shampoo += zz_count*30
			if zz_id = 11: tampon += zz_count*20
			if zz_id = 12: salfetka += zz_count*10
			if zz_id = 13: greben = 1
			if zz_id = 14: fairy += zz_count*20
			if zz_id = 15: poroshok += zz_count*30
			if zz_id = 16: cltarelka += zz_count*3
			if zz_id = 17: paint_blue += zz_count
			if zz_id = 18: tkan += zz_count
			if zz_id = 19: tv = 1
			if zz_id = 20: tv = 2
			if zz_id = 21: komp = 1
			if zz_id = 22: posudomashina = 1
			if zz_id = 23: stiralka = 1
			if zz_id = 24: minifoto = 1
			if zz_id = 25: webcamera = 1
			if zz_id = 26: clrbelo += zz_count
			if zz_id = 27: clrbelo += 7
			if zz_id = 28: palto = 2 & $palto = 'зимнее пальто'
			if zz_id = 29: skates = 1
			if zz_id = 30: skak = 1
			if zz_id = 31: obruch = 1
			gs 'stat'
			gs 'zz_funcs','message','','<font color=green>' + $zz_arr0[zz_id] + ':</font><font color=green> +' + zz_count + '</font>'
		else
			gs 'zz_funcs','message','','<font color=red>У вас недостаточно денег.</font>'
		end
	else
		gs 'zz_funcs','message','','<font color=red>Вы столько не унесете!</font>'
	end
	gs 'shop','buy_finalize'
end
if $args[0] = 'buy_error':
	gs 'zz_funcs','message','','<font color=red>У вас уже есть ' + $zz_arr0[zz_id] + '</font>'
	gs 'shop','buy_finalize'
end
if $args[0] = 'buy_finalize':
	killvar 'zz_id'
	killvar 'zz_price'
	killvar 'zz_count'
end
if $args[0] = 'closed':
	cla
	gs 'zz_render','','','<center><font color=red>Отдел закрыт, рабочие часы: 08.00-21.00</font></center>'
	act 'Назад': gt 'shop', 'start'
end