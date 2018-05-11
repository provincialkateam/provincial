! 0 - голая
! 1 - полотенце
! 2 - купальник
! 3 - неубиваемый сарафан
! 4 - школьная форма
! 5 - форма официантки
! 6-9 - резерв
! 10-29 - спорткостюм 1
! 30-49 - джинсы 2
! 50-69 - юбка+ 3
! 70-89 - повседневные платья 4
! 90-109 - вечерние платья 5
! 110-129 - офисные костюмы 6
! 130-149 - откровенный наряд 7
! 150-169 - сексуальное белье 8
!-------------
! cloth[0] - главная одежда
! cloth[1] - трусики
! cloth[2] - чулки
! -- предыдущая одежда --
! cloth[3] - главная одежка
! cloth[4] - трусики
! cloth[5] - чулки
!-------------
!---
! инициализация массива одежды для формирования магазина
!---
if $args[0] = 'init':
	killvar '$clothing'
	! голая
	$clothing['0,id'] = 0
	$clothing['0,name'] = ''
	$clothing['0,group'] = 0
	$clothing['0,price'] = 0
	$clothing['0,bonus'] = 0
	$clothing['0,condition'] = -99
	! Полотенце
	$clothing['1,id'] = 1
	$clothing['1,name'] = ''
	$clothing['1,group'] = 0
	$clothing['1,price'] = 0
	$clothing['1,bonus'] = 10
	$clothing['1,condition'] = -99
	! купальник
	$clothing['2,id'] = 2
	$clothing['2,name'] = 'Купальник'
	$clothing['2,group'] = 0
	$clothing['2,price'] = 0
	$clothing['2,bonus'] = 10
	$clothing['2,condition'] = -99
	! неубываемый сарафан, одежда на все случаи жизни
	! минимальный бонус к привлекательности, т.к. не должен носиться постоянно
	$clothing['3,id'] = 3
	$clothing['3,name'] = 'Сарафан'
	$clothing['3,group'] = 0
	$clothing['3,price'] = 0
	$clothing['3,bonus'] = 5
	$clothing['3,condition'] = -99
	! школьная форма
	$clothing['4,id'] = 4
	$clothing['4,name'] = 'Школьная форма'
	$clothing['4,group'] = 0
	$clothing['4,price'] = 0
	$clothing['4,bonus'] = 15
	$clothing['4,condition'] = -99
	! Форма официантки
	$clothing['5,id'] = 5
	$clothing['5,name'] = 'Форма официантки'
	$clothing['5,group'] = 0
	$clothing['5,price'] = 0
	$clothing['5,bonus'] = 15
	$clothing['5,condition'] = -99
	! резерв
	for _cid = 6 to 9:
		$clothing['<<_cid>>,id'] = _cid
		$clothing['<<_cid>>,name'] = ''
		$clothing['<<_cid>>,group'] = 0
		$clothing['<<_cid>>,price'] = 0
		$clothing['<<_cid>>,condition']=0
		$clothing['<<_cid>>,bonus'] = 0
	end
	killvar '_cid'
	!---
	! одежда по группам
	gs 'zz_clothing2','fill_clothing',1,'Спортивный костюм',5000,5,100
	gs 'zz_clothing2','fill_clothing',2,'Джинсы',3000,10,100
	gs 'zz_clothing2','fill_clothing',3,'Наряд с юбкой',7000,15,100
	gs 'zz_clothing2','fill_clothing',4,'Повседневное платье',10000,20,100
	gs 'zz_clothing2','fill_clothing',5,'Вечернее платье',40000,30,100
	gs 'zz_clothing2','fill_clothing',6,'Офисный костюм',20000,15,100
	gs 'zz_clothing2','fill_clothing',7,'Откровенный наряд',15000,15,100
	gs 'zz_clothing2','fill_clothing',8,'Эротическое белье',20000,30,100
end
!---
! заполнение массива одежды для отдельных групп
!---
! args[1] - group_id
! $args[2] - name
! args[3] - price
! args[4] - bonus
if $args[0] = 'fill_clothing':
	local _cbase = arrsize('$clothing')/6
	local _cid
	for _cid = _cbase to _cbase + 19:
		$clothing['<<_cid>>,id'] = _cid
		$clothing['<<_cid>>,group'] = args[1]
		$clothing['<<_cid>>,name'] = $args[2]
		$clothing['<<_cid>>,price'] = args[3]
		$clothing['<<_cid>>,bonus'] = args[4]
		$clothing['<<_cid>>,condition']= args[5]
	end
	killvar '_cbase'
	killvar '_cid'
end
!---
! тест: вывод полного списка одежды
!gt 'zz_clothing2','list'
!---
if $args[0] = 'list':
	gs 'zz_clothing2','init'
	local $_cstr
	for i = 0 to arrsize('$clothing')/5 - 1:
		$_cstr += '<tr bgcolor='+iif(i mod 2 = 0,'#f3f4ee','#ffffff')+'>'
		$_cstr += '<td><<i>></td>'
		$_cstr += '<td>' + $clothing['<<i>>,id'] + '</td>'
		$_cstr += '<td>' + $clothing['<<i>>,group'] + '</td>'
		$_cstr += '<td>' + $clothing['<<i>>,name'] + '</td>'
		$_cstr += '<td>' + $clothing['<<i>>,price'] + '</td>'
		$_cstr += '<td>' + $clothing['<<i>>,bonus'] + '</td>'
		$_cstr += '</tr>'
	end
	gs 'zz_render','','','<center><table><<$_cstr>></table></center>'
	killvar '$_cstr'
end
!---
! магазин одежды
!---
!gt 'zz_clothing2','make_shop',3
! args[1] - group_id
if $args[0] = 'make_shop':
	local _group_id = args[1]
	local _item_price
	gs 'zz_clothing2','init'
	local $zz_str = '<ul class="products">'
	FOR i = (_group_id*20-10) TO (_group_id*20+9):
		if $clothing['<<i>>,group'] = _group_id and val($wardrobe["<<func('zz_clothing2','get_wardrobe_id',val($clothing['<<i>>,id']))>>,group"]) <= 0 :
			_item_price = $clothing['<<i>>,price']
			$zz_str += '<li class="product-wrapper">'
			$zz_str += '<div class="product">'
			$zz_str += 	'<div class="product-main">'
			$zz_str += 		'<div class="product-text">'
			$zz_str += 			'<h2 class="product-name">'+ $clothing['<<i>>,name'] +'</h2>'
			$zz_str += 			'<div class="product-price"><b>'+ _item_price + '</b><small> руб.</small></div>'
			$zz_str += 			'<div class="product-cloth"><a href="exec:view ''images/common/clothing/<<_group_id>>/<<i>>.jpg''"><img src="images/common/clothing/<<_group_id>>/<<i>>.jpg"></a></div>'
			$zz_str += 		'</div>'
			$zz_str += 	'</div>'
			$zz_str += 	'<div class="product-details-wrap">'
			$zz_str += 		'<div class="product-details">'
			$zz_str += 			'<div class="product-availability">'
			$zz_str +=  		 	iif(money >= _item_price,'<a class="product-button" href="exec:gs''zz_clothing2'',''buy'','+val($clothing['<<i>>,id'])+'">Купить</a>','<span class="product-expensive">Недостаточно средств</span>')
			$zz_str +=			'</div>'
			$zz_str += 		'</div>'
			$zz_str +=	'</div>'
			$zz_str += '</div>'
			$zz_str += '</li>'
		end
	end
	$zz_str += '</ul>'
	gs 'zz_render','','',$zz_str
	killvar '_group_id'
	killvar '_item_price'
	killvar '$zz_str'
	exit
end
!---
! процедура-обработчик покупки
!---
! args[1] - id одежды
if $args[0] = 'buy':
	local _cid = args[1]
	if money >= $clothing['<<_cid>>,price']:
		money -= $clothing['<<_cid>>,price']
		achiev['cloth,'+val($clothing['<<_cid>>,group'])] += 1
		gs 'stat'
		gs 'zz_clothing2','add_to_wardrobe',_cid
		gs 'zz_funcs','message','','<green>Вы купили ' + $clothing['<<_cid>>,name'] + '</green>'
	elseif karta >= $clothing['<<_cid>>,price']:
		karta -= $clothing['<<_cid>>,price']
		achiev['cloth,'+val($clothing['<<_cid>>,group'])] += 1
		gs 'stat'
		gs 'zz_clothing2','add_to_wardrobe',_cid
		gs 'zz_funcs','message','','<green>Вы купили ' + $clothing['<<_cid>>,name'] + '</green>'
	else
		gs 'zz_funcs','message','','<red>У вас недостаточно денег для покупки!</red>'
	end
	killvar '_cid'
	exit
end
!---
! add item to wardrobe
!---
! args[1] - clothing_id
if $args[0] = 'add_to_wardrobe':
	! get max wardrobe_id
	local _wid = arrsize('$wardrobe')/9
	$wardrobe['<<_wid>>,wardrobe_id'] = iif(_wid - 1 < 0,0,$wardrobe['<<_wid-1>>,wardrobe_id']+1)
	$wardrobe['<<_wid>>,clothing_id'] = $clothing['<<args[1]>>,id']
	$wardrobe['<<_wid>>,group'] = $clothing['<<args[1]>>,group']
	$wardrobe['<<_wid>>,name'] = $clothing['<<args[1]>>,name']
	$wardrobe['<<_wid>>,price'] = $clothing['<<args[1]>>,price']
	$wardrobe['<<_wid>>,condition'] = $clothing['<<args[1]>>,condition']
	$wardrobe['<<_wid>>,bonus'] = $clothing['<<args[1]>>,bonus']
	$wardrobe['<<_wid>>,size'] = iif(val($clothing['<<args[1]>>,group']) >= 0,body['hips'],0)
	$wardrobe['<<_wid>>,trashbag'] = 0
	killvar '_wid'
end
!---
! return image_path
!---
if $args[0] = 'get_image':
	$result = 'images/common/clothing/'+func('zz_clothing2','get_group')+'/<<cloth[0]>>.jpg'
end
!---
! get group_id
!---
! args[1] - wardrobe_id
if $args[0] = 'get_group':
	if args[1] <= 0:
		_wid = func('zz_clothing2','get_wardrobe_id',cloth[0])
	else
		_wid = args[1]
	end
	result = val($wardrobe['<<_wid>>,group'])
	killvar '_wid'
end
!---
! make wardrobe
!---
! args[1] - group
if $args[0] = 'wardrobe':
	$zz_str = ''
	for i = 0 to arrsize('$wardrobe')/9 - 1:
		if val($wardrobe['<<i>>,clothing_id']) = 3 or val($wardrobe['<<i>>,clothing_id']) = 4 or val($wardrobe['<<i>>,clothing_id']) >= 10:
			if cloth[0] ! val($wardrobe['<<i>>,clothing_id']) and val($wardrobe['<<i>>,trashbag']) = 0 and val($wardrobe['<<i>>,group']) >= 0:
				! бокс для одежки
				$zz_str += '<div class="wardrobe-item">'
				$zz_str += '<div class="wardrobe-item-photo"><a href="exec: view''images/common/clothing/'+$wardrobe['<<i>>,group']+'/'+$wardrobe['<<i>>,clothing_id']+'.jpg''"><img src="images/common/clothing/'+$wardrobe['<<i>>,group']+'/'+$wardrobe['<<i>>,clothing_id']+'.jpg" class="tip" title="'+$wardrobe['<<i>>,name']+'"></a></div>'
				$zz_str += '<div class="wardrobe-item-status">' + func('zz_clothing2','get_action_string') + '</div>'
				$zz_str += '</div>'
			end
		end
	end
	gs 'zz_render','','','<div id="wardrobe">' + $zz_str + '</div>'
	killvar '$zz_str'
end
!---
! кнопки действий с одеждой - надеть, перешить, в корзину, выбросить
!---
if $args[0] = 'get_action_string':
	$_str = ''
	$_zz_img = '<img class="tip" src="images/common/clothing/icons/'
	! кнопка Надеть
	if val($wardrobe['<<i>>,condition']) <= 0 and val($wardrobe['<<i>>,condition']) ! -99:
		$_zz_img_st = '0.png" title="Вы не можете надеть эту вещь.<br>Вещь изношена.">'
	elseif val($wardrobe['<<i>>,condition']) = -99 or val($wardrobe['<<i>>,condition']) > 75:
		$_zz_img_st = '4.png" title="Надеть.<br>Вещь в отличном состоянии.">'
	elseif val($wardrobe['<<i>>,condition']) > 50 and val($wardrobe['<<i>>,condition']) <= 75:
		$_zz_img_st = '3.png" title="Надеть.<br>Вещь в хорошем состоянии.">'
	elseif val($wardrobe['<<i>>,condition']) > 25 and val($wardrobe['<<i>>,condition']) <= 50:
		$_zz_img_st = '2.png" title="Надеть.<br>Вещь в нормальном состоянии.">'
	else
		$_zz_img_st = '1.png" title="Надеть.<br>Вещь в плохом состоянии.">'
	end
	if val($wardrobe['<<i>>,group']) = 0 or (val($wardrobe['<<i>>,size']) >= body['hips'] - 8 and val($wardrobe['<<i>>,size']) <= body['hips'] + 8 and val($wardrobe['<<i>>,condition']) > 0):
		$_str += '<a href="exec: gs''zz_clothing2'',''redress'','+val($wardrobe['<<i>>,clothing_id'])+' & gt ''loker''">'+ $_zz_img + $_zz_img_st + '</a>'
	else
		$_str += $_zz_img + $_zz_img_st
	end
	! кнопка Перешить
	if val($wardrobe['<<i>>,size']) > body['hips']:
		if poSkill >= 100:
			$_str += '<a href="exec: gs''zz_clothing2'',''alter_clothing'','+val($wardrobe['<<i>>,wardrobe_id'])+'">' + $_zz_img + '5.svg" title="Перешить"></a>'
		else
			$_str += $_zz_img + '6.svg" title="У вас не хватает навыков чтобы перешить эту вещь.">'
		end
	else
		$_str += $_zz_img + '6.svg" title="Вы не можете перешить эту вещь.">'
	end
	! кнопки В корзину и Выбросить
	if val($wardrobe['<<i>>,group']) = 0:
		$_str += $_zz_img + '8.svg" title="Вы не можете отправить эту вещь в корзину.">'
		$_str += $_zz_img + '10.svg" title="Вы не можете выбросить эту вещь.">'
	else
		$_str += '<a href="exec: $wardrobe[''<<i>>,trashbag''] = 1 & gt ''loker''"><<$_zz_img>>7.svg" title="В корзину"></a>'
		$_str += '<a href="exec: $wardrobe[''<<i>>,group''] = -1 & $wardrobe[''<<i>>,clothing_id''] = -1 & gt ''loker''"><<$_zz_img>>9.svg" title="Выбросить"></a>'
	end
	$result = $_str
	killvar '$_str'
	killvar '$_zz_img'
	killvar '$_zz_img_st'
end
!---
! перешивание одежды
!---
! args[1] - wardrobe_id
if $args[0] = 'alter_clothing':
	*clr & cla
	minut += 30
	$wardrobe['<<args[1]>>,size'] = body['hips']
	gs 'stat'
	gs 'zz_render','','','В течение получаса вы перешивали одежду, делая ее подходящей вам по размеру.'
	act 'Положить в шкаф': gt 'loker'
end
!---
! корзина
!---
! args[1] - wardrobe_id
if $args[0] = 'trashbag':
	$zz_str = ''
	$_zz_img = '<img class="tip" src="images/common/clothing/icons/'
	for i = 0 to arrsize('$wardrobe')/9 - 1:
		if val($wardrobe['<<i>>,trashbag']) > 0 and $wardrobe['<<i>>,group'] > 0:
			! бокс для одежки
			$zz_str += '<div class="wardrobe-item">'
			$zz_str += '<div class="wardrobe-item-photo"><a href="exec: view''images/common/clothing/'+$wardrobe['<<i>>,group']+'/'+$wardrobe['<<i>>,clothing_id']+'.jpg''"><img src="images/common/clothing/'+$wardrobe['<<i>>,group']+'/'+$wardrobe['<<i>>,clothing_id']+'.jpg" class="tip" title="'+$wardrobe['<<i>>,name']+'"></a></div>'
			$zz_str += '<div class="wardrobe-item-status">'
			$zz_str += '<a href="exec: $wardrobe[''<<i>>,trashbag''] = 0 & gt ''zz_clothing2'',''trashbag''"><<$_zz_img>>11.svg" title="В шкаф"></a>'
			$zz_str += '<a href="exec: $wardrobe[''<<i>>,group''] = -1 & gt ''zz_clothing2'',''trashbag''"><<$_zz_img>>9.svg" title="Выбросить"></a>'
			$zz_str += '</div>'
			$zz_str += '</div>'
		end
	end
	gs 'zz_render','','','<div id="wardrobe">' + $zz_str + '</div>'
	act 'В шкаф': gt 'loker'
	killvar '$zz_str'
	killvar '$_zz_img'
end
!---
! dressing for emergency button
!---
if $args[0] = 'fix_emergency':
	if cloth[0] >= 3:
		exit
	else
		if cloth[3] = 5: cloth[3] = 3
		gs 'zz_clothing2','redress',iif(cloth[3] >= 3,cloth[3],3)
	end
end
!---
! get wardrobe_id for clothing_id
!---
! args[1] - clothing_id
if $args[0] = 'get_wardrobe_id':
	result = -1
	for i = 0 to arrsize('$wardrobe')/9 - 1:
		if args[1] = $wardrobe['<<i>>,clothing_id']:
			result = $wardrobe['<<i>>,wardrobe_id']
			exit
		end
	end
end
!---
! get dress-bonus for view
!---
if $args[0] = 'get_bonus':
	_wid = func('zz_clothing2','get_wardrobe_id',cloth[0])
	! бонус рассчитываем в зависимости от состояния одежды
	result = val($wardrobe['<<_wid>>,bonus']) * val($wardrobe['<<_wid>>,condition']) / 100 + iif(cloth[2] = 1,5,0)
	killvar '_wid'
end
!---
! проверка школьной формы
!---
if $args[0] = 'is_schooldress':
	result = iif(cloth[0] = 4,1,0)
end
!---
! check skirt
!---
if $args[0] = 'is_skirt':
	_wid = func('zz_clothing2','get_wardrobe_id',cloth[0])
	if val($wardrobe['<<_wid>>,group']) >= 3 or val($wardrobe['<<_wid>>,clothing_id']) = 3 or val($wardrobe['<<_wid>>,clothing_id']) = 4:
		result = 1
	else
		result = 0
	end
	killvar '_wid'
end
!---
! проверка вечерних платьев
!---
if $args[0] = 'is_glamour':
	result = iif(func('zz_clothing2','get_group') = 5,1,0)
end
!---
! переодевание
!---
! args[1] - id новой одежды
if $args[0] = 'redress':
	! cloth[0] - текущая одежда
	! cloth[1] - наличие трусиков 0/1
	! cloth[2] - наличие чулков 0/1
	! предыдущие значения
	! cloth[3] - одежда
	! cloth[4] - наличие трусиков 0/1
	! cloth[5] - наличие чулков 0/1
	local _new_id = args[1]
	!-- переодевание --!
	! если ГГ одета - переписываем значения предыдущей одежды
	_wid = func('zz_clothing2','get_wardrobe_id',_new_id)
	if cloth[0] >= 3:
		cloth[3] = cloth[0]
		cloth[4] = cloth[1]
		cloth[5] = cloth[2]
		! если ГГ раздевается догола, полотенце/купальник - снимаем автоматом чулки и трусики
		if _new_id <= 2:
			cloth[1] = 0
			cloth[2] = 0
		else
			! если ГГ переодевается в спорткостюм/джинсы - снимаем только чулки
			if val($wardrobe['<<_wid>>,group']) = 1 or val($wardrobe['<<_wid>>,group']) = 2:
				cloth[2] = 0
			end
		end
	else
		! ГГ в текущий момент голая
		! одеваем
		if _new_id >= 3:
			! если ГГ переодевается в спорткостюм/джинсы - чулки недоступны
			if val($wardrobe['<<_wid>>,group']) = 1 or val($wardrobe['<<_wid>>,group']) = 2:
				cloth[2] = 0
			else
				cloth[2] = cloth[5]
			end
			! при одевании проверяем состояние трусиков: если 0 - надеть невозможно
			cloth[1] = iif(panties > 0,cloth[4],0)
		end
	end
	cloth[0] = _new_id
	killvar '_new_id'
	killvar '_wid'
	gs 'stat'
	exit
end
!---
! износ белья
!---
if $args[0] = 'panty_check':
	! 1 трусики на 500 часов, каждый час -1, если месячные - еще -2, если с попы или киски вытекает сперма - еще по -2
	if cloth[1] > 0:
		panties -= 1
		if mesec > 0: panties -= 2
		if cumpussy > 0: panties -= 2
		if cumanus > 0: panties -= 2
		if panties < 0: panties = 0
	end
end
!---
! износ одежды
! args[1] - значение износа, по умолчанию 1
!---
if $args[0] = 'decrease_condition':
	local _wid = func('zz_clothing2', 'get_wardrobe_id', cloth[0])
	if $wardrobe['<<_wid>>,condition'] > 0: $wardrobe['<<_wid>>,condition'] -= iif(val(args[1]) > 1, val(args[1]), 1)
	killvar '_wid'
end
!---
!при занятиях спортом каждая одежда изнашивается по разному
!значение 0 или 1 не имеет смысла, но включаем в расчет на будущее
!Неспортивная одежда изнашивается сильнее, ибо жизнь-боль
!---
if $args[0] = 'decrease_condition_level':
	local _decrease_condition_level = 0
	if cloth[0]=>10 and cloth[0]<=29:
		!спортивная
		_decrease_condition_level = 0
	elseif cloth[0]=>30 and cloth[0]<=49:
		!джинсы
		_decrease_condition_level = 2
	elseif cloth[0]=>50 and cloth[0]<=69:
		!юбка+
		_decrease_condition_level = 3
	elseif cloth[0]=>70 and cloth[0]<=89:
		!повседневные платья
		_decrease_condition_level = 3
	elseif cloth[0]=>90 and cloth[0]<=109:
		!вечерние платья
		_decrease_condition_level = 10
	elseif cloth[0]=>110 and cloth[0]<=129:
		!откровенный наряд
		_decrease_condition_level = 4
	elseif cloth[0]=>130 and cloth[0]<=149:
		!офисные костюмы
		_decrease_condition_level = 4
	elseif cloth[0]=>150 and cloth[0]<=169:
		!сексуальное белье
		_decrease_condition_level = 2
	end
	result = _decrease_condition_level
	killvar '_decrease_condition_level'
end
!---
! добавление рандомной одежки в гардероб
! args[1] - id группы
!---
if $args[0] = 'add_rand_dress':
	local _group_id = args[1]
	if _group_id < 1 or _group_id >= 8:
		killvar '_group_id'
		exit
	end
	_rand_dress = rand(_group_id*20-10,_group_id*20+9)
 	gs 'zz_clothing2','init'
	gs 'zz_clothing2','add_to_wardrobe',_rand_dress
	gs 'zz_clothing2','dispose'
	!---
	result = _rand_dress
	!---
	killvar '_rand_dress'
	killvar '_group_id'
end
!---
! удаление одежды из гардероба
! args[1] - id одежды
!---
if $args[0] = 'remove_at':
	_wid = func('zz_clothing2','get_wardrobe_id',args[1])
	$wardrobe['<<_wid>>,group'] = -1
	$wardrobe['<<_wid>>,clothing_id'] = -1
	killvar '_wid'
end
!---
! disposing
!---
if $args[0] = 'dispose':
	killvar '$clothing'
end
!---
! ателье
!---
if $args[0] = 'tailor_list':
	$zz_str = ''
	$_zz_img = '<img class="tip" src="images/common/clothing/icons/'
	for i = 0 to arrsize('$wardrobe')/9 - 1:
		if $wardrobe['<<i>>,group'] >= 1 and $wardrobe['<<i>>,group'] > 0:
			_cloth_price = val($wardrobe['<<i>>,price'])
			_cloth_cond = val($wardrobe['<<i>>,condition'])
			if _cloth_cond < 25:
				_cloth_price = 0
			else
				_cloth_price = _cloth_price * _cloth_cond * 4 / 500
			end
			$zz_str += '<div class="wardrobe-item">'
			$zz_str += '<div class="wardrobe-item-photo"><a href="exec: view''images/common/clothing/'+$wardrobe['<<i>>,group']+'/'+$wardrobe['<<i>>,clothing_id']+'.jpg''"><img src="images/common/clothing/'+$wardrobe['<<i>>,group']+'/'+$wardrobe['<<i>>,clothing_id']+'.jpg" class="tip" title="'+$wardrobe['<<i>>,name']+'"></a></div>'
			$zz_str += '<div class="wardrobe-item-status">'
			if $wardrobe['<<i>>,size'] > body['hips']: $zz_str += '<a href="exec: gs ''zz_clothing2'',''fit_cloth'',<<i>> & gt ''zz_clothing2'',''tailor_list''"><<$_zz_img>>5.svg" title="Перешить (500р.)"></a>'
			if _cloth_price > 0: $zz_str += '<a href="exec: gs ''zz_clothing2'',''sell_cloth'',<<i>>,<<_cloth_price>> & gt ''zz_clothing2'',''tailor_list''"><<$_zz_img>>12.svg" title="Продать за <<_cloth_price>>р."></a>'
			$zz_str += '</div>'
			$zz_str += '</div>'
		end
	end
	gs 'zz_render','','','<div id="wardrobe">' + iif($zz_str = '','<red>Нечего перешивать или продавать!</red>',$zz_str)  + '</div>'
	act '<b>Назад</b>': gt 'tailor'
	killvar '_cloth_cond'
	killvar '_cloth_price'
	killvar '$zz_str'
	killvar '$_zz_img'
end
!---
! ресайз одежды
! args[1] - id одежды
!---
if $args[0] = 'resize':
	_wid = func('zz_clothing2','get_wardrobe_id',args[1])
	$wardrobe['<<_wid>>,size'] = body['hips']
	killvar '_wid'
end
!---
! ремонт одежды в ателье
! args[1] - id одежды
!---
if $args[0] = 'fit_cloth':
	_cloth_id = args[1]
	if func('zz_funcs','money',500) = 1:
		minut += rand(20,30)
		gs 'zz_clothing2','resize',_cloth_id
		gt 'zz_clothing2','tailor_list'
	end
	killvar '_cloth_id'
end
!---
! продажа одежды в ателье
! args[1] - wardrobe_id
! args[2] - цена продажи
!---
if $args[0] = 'sell_cloth':
	_price = args[2]
	money += _price
	$wardrobe['<<args[1]>>,group'] = -1
	gs 'zz_funcs','message','images/common/icons/money.png','<green>+<<_price>></green>'
	gs 'stat'
	killvar '_price'
end