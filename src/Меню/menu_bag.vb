*clr & cla
act '<b>Закрыть</b>': gt $loc, $metka
!---
! Вся информация о продуктах в inventory_list
$_bag_text = ''
if greben > 0 and hapri = 0 and $settings['hapri_mod'] = 1: $_bag_text += 'У вас есть расческа. <a href="exec:minut += 3 & hapri = 1 & gs''stat''"><b>Причесаться</b></a>'
if salfetka > 0: $_bag_text += '**У вас есть влажные салфетки, <<salfetka>> штук. ' + iif(cumface+cumfrot+cumbelly+cumass+cumpussy+cumanus>0,'<a href="exec:gs''zz_common'',''wet_wipes''"><b>Использовать салфетки</b></a>','')
if kosmetica > 0: $_bag_text += '**У вас есть <a href="exec:gt''mirror'',''start'',''menu_bag''">переносная косметичка</a>. Косметики хватит на <<kosmetica>> раз.'
if condom + Scondom > 0:
	if CondomToggle = 0:
		$_bag_text += '**У вас <<condom + Scondom>> презервативов и вы пользуетесь ими в случае необходимости. <a href="exec:CondomToggle = 1 & dynamic $d_bag"><b>Перестать пользоваться.</b></a>'
	else
		$_bag_text += '**У вас <<condom + Scondom>> презервативов, но вы не пользуетесь ими. <a href="exec:CondomToggle = 0 & dynamic $d_bag"><b>Начать пользоваться.</b></a>'
	end
end
if tabletki + Stabletki > 0:
	if PillToggle = 0:
		$_bag_text += '**У вас <<tabletki + Stabletki>> противозачаточных таблеток и вы принимаете их.<a href="exec:PillToggle = 1 & dynamic $d_bag"><b>Прекратить принимать таблетки.</b></a>'
	else
		$_bag_text += '**У вас <<tabletki + Stabletki>> противозачаточных таблеток, но вы не принимаете их.<a href="exec:PillToggle = 0 & dynamic $d_bag"><b>Начать принимать таблетки.</b></a>'
	end
end
if lubri > 0: $_bag_text += '**У вас есть лубрикант. Хватит на <<lubri>> раз.'
if foto = 1: $_bag_text += '**В сумочке лежит странное фото'
if abonement > 0: $_bag_text += '**Абонемент, на посещение фитнесс-центра, действителен на <<abonement>> занятий.'
if krem > 0: $_bag_text += '**Крем для загара <<krem>>.'
if reading['in_bag'] >= 0: $_bag_text += '**В сумочке лежит книга "'+func('zz_books','get_name',reading['in_bag'])+'".'
!---
$_html = '<div id="hero_description">'
	$_html += '<div id="hero_text">'+$_bag_text+'</div>'
$_html += '</div>'
gs 'zz_render','','',$_html
! новая сумка
$_items_table = '<ul class="products">'
items_count = 0
:loop_bag_table
if items_count <= 9:
	if ($inventory[items_count+'_'+'count'] > 0):
		$item_name = func('inventory_list', items_count, 'name')
		$item_img = func('inventory_list', items_count, 'img')
		$item_description = func('inventory_list', items_count, 'description')
		$item_action = func('inventory_list', items_count, 'action')
		$_items_table += '<li class="product-wrapper">'
		$_items_table += '<div class="product">'
		$_items_table += '<div class="product-main">'
		$_items_table += 		'<div class="items-text">'
		$_items_table += 			'<h3 class="product-name">'+ $item_name +'</h3><p>'+$item_description+'</p><div class="product-photo"><img src="images/common/shop/products/'+ $item_img +'"></div>'
		$_items_table += 		'</div>'
		$_items_table += 	'</div>'
		$_items_table += 	'<div class="product-details-wrap">'
		$_items_table += 		'<div class="product-details">'
		$_items_table += 			'<div class="items-count"><h1>'+ $inventory[items_count+'_'+'count'] +'</h1></div>'
		$_items_table += 			'<div class="product-availability">'
		$_items_table +=  		 	'<a class="items-button" href="exec: gs ''menu_bag'', ''action'', '+items_count+', '''+$item_name+''' ">'+$item_action+'</a>'
		$_items_table +=			'</div>'
		$_items_table += 		'</div>'
		$_items_table +=	'</div>'
		$_items_table += '</div>'
		$_items_table += '</li>'
	end
	items_count += 1
	jump 'loop_bag_table'
end
$_items_table += '</ul>'
gs 'zz_render','','', $_items_table
if $args[0]= 'action':
	key = args[1]
	$item_name = $args[2]
	$inventory[key+'_count'] -= 1
	if key = 1:
		gs 'zz_funcs','message', '', 'Вы выпили бутылку '+ $item_name
	elseif key = 8:
		gs 'zz_funcs','message', '', 'Вы выпили '+ $item_name
	else
		gs 'zz_funcs','message', '', 'Вы съели '+ $item_name
	end
		if key = 0: energy += 4 & body['day_weight'] += 1
		if key = 1: gs 'zz_funcs', 'alko', 6
		if key = 2: energy += 20 & body['day_weight'] += 1
		if key = 3: energy += 15 & body['day_weight'] += 1
		if key = 4: energy += 10 & body['day_weight'] += 1
		if key = 5: water = 20 & cumlip = 0
		if key = 6: energy += 10 & body['day_weight'] += 1
		if key = 7: energy += 10 & body['day_weight'] += 1
		if key = 8: gs 'zz_funcs','alko',4
		if key = 9: cumlip = 0
	gs 'stat'
	killvar 'key'
	killvar '$item_name'
	gt $curloc
end
killvar '$_items_table'
killvar 'items_count'
killvar '$_bag_text'
killvar '$_html'