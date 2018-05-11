$loc = $curloc
if $args[0] = 'init':
	! точка возврата
	$_back_loc = $args[1]
	$_back_arg = $args[2]
	gt 'shop'
end
!---
if $args[0] = '':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Супермаркет','images/common/shop/shop.jpg','В холле стоит <a href="exec: gt''zz_atm'',''main'' ">универсальный банковский терминал</a>, где вы можете положить или снять деньги со счета, пополнить баланс мобильного, а также оплатить некоторые услуги.**Самое большое место в супермаркете занимает <a href="exec: gt ''shop'',''food''">продуктовый отдел</a>, но в магазине есть еще отделы <a href="exec: gt ''shop'',''cosmetics''">косметики</a>, <a href="exec: gt ''shop'',''common''">хозяйственный</a>, <a href="exec: gt ''shop'',''clothing''">одежды</a>, и отдел <a href="exec: gt ''shop'',''tech''">бытовой техники</a>.'
	if hour >= 8 and hour <= 20:
		gs 'shop','store_list'
		gs 'zz_render','','','Чуть в сторонке разместился небольшой <a href="exec:gt''shop'',''sport''">магазинчик спорттоваров.</a>'
		gs 'zz_render','','','Недалеко от входа стоит <a href="exec:gt ''zz_common'',''icecream''">прилавок с мороженным</a> и <a href="exec: gt ''zz_common'',''coffee''">кофейня.</a>'
	end
	if $control_point = 'gorodok':
		if week < 6 and hour >= 8 and hour < 16: gs 'zz_render','','','Ваша сестра <a href="exec:GT ''sister''">Аня</a> сидит на кассе.'
		gs 'zz_family', 'mother_sheduler'
	end
	if hour >= 8 and hour <= 20:
		gs 'zz_render','','','В магазине толпы покупателей.'
		if TorgPredZ > 0 and (($control_point = 'south' and StreetShopTPday ! day) or ($control_point = 'north' and nordShopTPday ! day)):
			act 'Расставлять продукцию':
				*clr & cla
				minut += RAND(40,130)
				gs 'stat'
				TorgPredZ -= 1
				TorgPredZV += 1
				if $control_point = 'south':
					StreetShopTPday = day
				elseif $control_point = 'north':
					nordShopTPday = day
				end
				gs 'zz_render','Супермаркет','images/common/shop/work'+rand(1,3)+'.jpg','Вы расставляли продукцию довольно долгое время и когда наконец справились, то пошли на кассу, где вам пробили чек.'
				act 'Выйти': gt 'shop'
			end
		end
	else
		gs 'zz_render','','','Магазин закрыт.'
	end
	act 'Выйти из магазина': gt $control_point
end
if $ARGS[0] = 'food':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if hour < 8 or hour > 20: gs 'shop','closed','food' & exit
	*pl func('shop','make_table','food',11)
	act 'Выйти из отдела': gt 'shop'
end
if $ARGS[0] = 'cosmetics':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if hour < 8 or hour > 20: gs 'shop', 'closed' & exit
	*pl func('shop','make_table','cosmetics', iif($settings['hapri_mod'] = 1,7,6))
	act 'Выйти из отдела': gt 'shop'
end
if $ARGS[0] = 'common':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if hour < 8 or hour > 20: gs 'shop', 'closed' & exit
	*pl func('shop','make_table','common', 4)
	act 'Выйти из отдела': gt 'shop'
end
if $ARGS[0] = 'clothing':
	! Доделать разбиение
	*clr & cla
	$metka = $args[0]
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	act 'Выйти из отдела': gt 'shop'
	gs 'zz_clothing2','make_shop',6
	gs 'zz_clothing2','make_shop',2
	gs 'zz_clothing2','make_shop',3
	*pl func('shop','make_table','clothing',2)
end
if $ARGS[0] = 'tech':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if hour < 8 or hour > 20: gs 'shop','closed' & exit
	*pl func('shop', 'make_table', 'tech', 4)
	act 'Выйти из отдела': gt 'shop'
end
if $ARGS[0] = 'sport':
	*clr & cla
	$metka = $args[0]
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	act 'Выйти из отдела':
		minut += 5
		gs 'zz_clothing2', 'dispose'
		gt 'shop'
	end
	if hour >= 8 and hour <= 20:
		*pl func('shop', 'make_table', 'sport', 2)
		*nl
		gs 'zz_clothing2','make_shop',1
	end
end
if $args[0] = 'make_table':
	local $store_type = $args[1]
	local $zz_str = '<ul class="products" id="'+$store_type+'-store">'
	FOR i = 0 TO args[2]:
		local item_price = func('shop_list_items', $store_type, 'price', i)
		$zz_str += '<li class="product-wrapper">'
		$zz_str += '<div class="product">'
		$zz_str += 	'<div class="product-main">'
		$zz_str += 		'<div class="product-text">'
		$zz_str += 			'<h2 class="product-name">'+ func('shop_list_items', $store_type, 'name', i)  +'</h2><div class="product-price"><b>'+ item_price + '</b><small> руб.</small></div><div class="product-photo"><img src="images/common/shop/products/'+ func('shop_list_items', $store_type, 'img', i)+'"></div>'
		$zz_str += 		'</div>'
		$zz_str += 	'</div>'
		$zz_str += 	'<div class="product-details-wrap">'
		$zz_str += 		'<div class="product-details">'
		$zz_str += 			'<div class="product-availability">'
		$zz_str +=  		 	iif(func('zz_funcs','prepayment',2,item_price) = 1,'<a class="product-button" href="exec:gs''shop'',''buy'',''<<$store_type>>'',<<i>>">Купить</a>','<span class="product-expensive">Недостаточно средств</span>')
		$zz_str +=			'</div>'
		$zz_str += 		'</div>'
		$zz_str +=	'</div>'
		$zz_str += '</div>'
		$zz_str += '</li>'
	end
	$zz_str += '</ul>'
	$result = $zz_str
	exit
end
if $args[0] = 'buy':
	local $_store_type = $args[1]
	local $_item_name = func('shop_list_items', $args[1], 'name', args[2])
	local item_price = func('shop_list_items', $args[1], 'price', args[2])
	! ключ к записям
	local $_item_key = $args[1] +'_'+ args[2]
	if ($inventory[5+'_count'] = 1 and $_item_key = 'food_4') or ($inventory[6+'_count'] = 1 and $_item_key = 'food_3') or ($inventory[8+'_count'] = 1 and $_item_key = 'food_5') or (greben = 1 and $_item_key = 'cosmetics_7'): gs 'shop','buy_error', '$_store_type','$_item_name' & exit
	if (tv = 1 and $_item_key = 'tech_0') or (tv = 2 and $_item_key = 'tech_1') or (komp = 1 and $_item_key = 'tech_2') or (posudomashina = 1 and $_item_key = 'tech_3') or (stiralka = 1 and $_item_key = 'tech_4'): gs 'shop','buy_error','$_store_type','$_item_name' & exit
	if (palto = 2 and $_item_key = 'clothing_2') or (skates = 1 and $_item_key = 'sport_0') or (skak = 1 and $_item_key = 'sport_1') or (obruch = 1 and $_item_key = 'sport_2'): gs 'shop','buy_error','$_store_type','$_item_name' & exit
	if $_item_key = 'food_0' or $_item_key = 'food_1' or $_item_key = 'cosmetics_0' or $_item_key = 'cosmetics_1':
		item_count = val(input("Сколько вы хотите купить?"))
	else
		item_count = 1
	end
	if item_count < 1: gs 'shop','buy_finalize' & exit
	if item_count > 0 and item_count <= 30:
		if func('zz_funcs', 'payment', 2, item_price * item_count, 1) = 1:
			minut += 1
				if $_item_key = 'food_0': eda += item_count
				if $_item_key = 'food_1': edaD += item_count
				! check inventory_list loc for $inventory id
				! чтобы узнать идентификатор предмета смотрите inventory_list
				if $_item_key = 'food_2': $inventory[0+'_count'] += 1
				if $_item_key = 'food_3': $inventory[6+'_count'] += 1
				if $_item_key = 'food_4': $inventory[5+'_count'] += 1
				if $_item_key = 'food_5': $inventory[8+'_count'] += 1
				if $_item_key = 'food_6': $inventory[1+'_count'] += 1
				if $_item_key = 'food_7': $inventory[2+'_count'] += 1
				if $_item_key = 'food_8': $inventory[3+'_count'] += 1
				if $_item_key = 'food_9': $inventory[4+'_count'] += 1
				if $_item_key = 'food_10': $inventory[7+'_count'] += 10
				if $_item_key = 'food_11': $inventory[9+'_count'] += 37
				if $_item_key = 'cosmetics_0': kosmetica += item_count*15
				if $_item_key = 'cosmetics_1': kosmetica += item_count*30
				if $_item_key = 'cosmetics_2': stanok += item_count*5
				if $_item_key = 'cosmetics_3': krem += item_count*20
				if $_item_key = 'cosmetics_4': shampoo += item_count*30
				if $_item_key = 'cosmetics_5': tampon += item_count*20
				if $_item_key = 'cosmetics_6': salfetka += item_count*10
				if $_item_key = 'cosmetics_7': greben = 1
				if $_item_key = 'common_0': fairy += item_count*20
				if $_item_key = 'common_1': poroshok += item_count*30
				if $_item_key = 'common_2': cltarelka += item_count*3
				if $_item_key = 'common_3': paint_blue += item_count
				if $_item_key = 'common_4': tkan += item_count
				if $_item_key = 'tech_0': tv = 1
				if $_item_key = 'tech_1': tv = 2
				if $_item_key = 'tech_2': komp = 1
				if $_item_key = 'tech_3': posudomashina = 1
				if $_item_key = 'tech_4': stiralka = 1
				if $_item_key = 'clothing_0': panties += 500
				if $_item_key = 'clothing_1': panties += 7*500
				if $_item_key = 'clothing_2': palto = 2 & $palto = 'зимнее пальто'
				if $_item_key = 'sport_0': skates = 1
				if $_item_key = 'sport_1': skak = 1
				if $_item_key = 'sport_2': obruch = 1
			$_store_msg = '<green>Вы купили '+ iif($_item_count > 1,$_item_count,'') + ' ' + $_item_name + '</green>'
		end
	else
		$_store_msg = '<red>Вы столько не унесете!</red>'
	end
	gs 'shop','buy_finalize'
	gs 'shop', $args[1]
end
if $args[0] = 'buy_finalize':
	if $_store_msg!'':
		gs 'zz_funcs','message','', $_store_msg
		killvar '$_store_msg'
	end
	killvar 'item_count'
end
if $args[0] = 'buy_error':
	$_store_msg = '<red>У вас уже есть ' + $args[3] + '</red>'
	gs 'shop','buy_finalize'
	gs 'shop', $args[2]
end
if $args[0] = 'closed':
	cla
	gs 'zz_render','','images/common/shop/security'+iif($args[1] = 'food',1,2),'-\\\Извините, мы закрыты. Работаем с 8 до 21 часов.///'
	act 'Уйти': gt 'shop'
end