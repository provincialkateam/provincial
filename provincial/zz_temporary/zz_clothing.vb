! create clothing array
if $args[0] = 'init_clothing':
	! kill if exists
	killvar '$clothing'
	! group_id, name, price, base_condition, bonus, [count - for array]
	! nude, towel, bikini: group_id - 0
	gs 'zz_clothing', 'fill_clothing', 0, 'nude', 0, -99, 0
	gs 'zz_clothing', 'fill_clothing', 0, 'towel', 0, -99, 0
	gs 'zz_clothing', 'fill_clothing', 0, 'bikini', 0, -99, 0
	! sarafan: group_id - 1
	gs 'zz_clothing', 'fill_clothing', 1, 'Цветастый свободный сарафан', 2500, 60, 10
	gs 'zz_clothing', 'fill_clothing', 1, 'Светлый свободный сарафан', 2500, 60, 10
	gs 'zz_clothing', 'fill_clothing', 1, 'Простенький сарафан из дешёвой ткани', 2500, 60, 10
	! jeans: group_id - 2
	gs 'zz_clothing', 'fill_clothing_array', 2, 'Джинсы', 1500, 60, 8, 5
	! sportswear: group_id - 3
	gs 'zz_clothing', 'fill_clothing_array', 3, 'Спортивная одежда', 4000, 60, 5, 18
	! shorts: group_id - 4
	gs 'zz_clothing', 'fill_clothing', 4, 'Чёрные шорты с фиолетовой майкой', 2500, 60, 10
	gs 'zz_clothing', 'fill_clothing', 4, 'Чёрные шорты с полосатой майкой', 2500, 60, 10
	gs 'zz_clothing', 'fill_clothing', 4, 'Чёрные шорты с чёрной майкой', 2500, 60, 10
	gs 'zz_clothing', 'fill_clothing', 4, 'Розовые шорты с розовым топиком', 2500, 60, 10
	gs 'zz_clothing', 'fill_clothing', 4, 'Сексуальные белые шорты с майкой', 2500, 60, 10
	! skirts: group_id - 5
	gs 'zz_clothing', 'fill_clothing', 5, 'Белая юбка с цветастой блузкой', 2500, 60, 12
	gs 'zz_clothing', 'fill_clothing', 5, 'Чёрная кожаная юбка с красной кофтой', 2500, 60, 12
	gs 'zz_clothing', 'fill_clothing', 5, 'Белая юбка с полосатой блузкой', 2500, 60, 12
	gs 'zz_clothing', 'fill_clothing', 5, 'Белая юбка с цветастой блузкой', 2500, 60, 12
	gs 'zz_clothing', 'fill_clothing', 5, 'Чёрная кожаная юбка с красной блузкой', 2500, 60, 12
	! pants: group_id - 6
	gs 'zz_clothing', 'fill_clothing', 6, 'Чёрные обтягивающие леггинсы с чёрным топиком', 2500, 60, 9
	gs 'zz_clothing', 'fill_clothing', 6, 'Чёрные обтягивающие леггинсы с красной блузкой', 2500, 60, 9
	gs 'zz_clothing', 'fill_clothing', 6, 'Фиолетовые обтягивающие леггинсы с черным топиком', 2500, 60, 9
	gs 'zz_clothing', 'fill_clothing', 6, 'Белые обтягивающие джинсы с черным топиком', 2500, 60, 9
	gs 'zz_clothing', 'fill_clothing', 6, 'Чёрные обтягивающие леггинсы с коротким топиком', 2500, 60, 9
	! brend-dress: group_id - 7
	gs 'zz_clothing', 'fill_clothing_array', 7, 'Брендовое платье', 25000, 160, 30, 24
	! dress: group_id - 8
	gs 'zz_clothing', 'fill_clothing_array', 8, 'Одежда из "Модницы"', 3000, 60, 15, 60
	! young-dress: group_id - 9
	gs 'zz_clothing', 'fill_clothing_array', 9, 'Молодёжный наряд', 10000, 100, 24, 21
	! work.uniform: group_id - 10
	gs 'zz_clothing', 'fill_clothing_array', 10, 'Офисная одежда', 2500, 60, 15, 2
	! school uniform: group_id - 11
	gs 'zz_clothing', 'fill_clothing', 11, 'Школьная форма', 0, -99, 15
	! hooker uniform: group_id - 12
	gs 'zz_clothing', 'fill_clothing_array', 12, 'Наряд проститутки', 2000, 100, 5, 5
	gs 'zz_clothing', 'fill_clothing', 12, 'Сексуальная школьная форма', 2000, 100, 20
	! erotic: group_id - 13
	gs 'zz_clothing', 'fill_clothing', 13, 'Сетчатая белая кофта с джинсовой юбкой', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Сетчатое голубое платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Прозрачное белое платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Маленькое прозрачное белое платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Латексный корсет с юбкой', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Короткое прозрачное черное платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Сетчатое черное платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Длинное прозрачное черное платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Прозрачное леопардовое платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Чёрный топ с сетчатыми колготками', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Сетчатая чёрная кофта с чёрными шортами', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Прозрачное красное платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Прозрачные розовые шорты с топом', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Маленькое сетчатое чёрное платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Маленькая чёрная юбка с прозрачным топом', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Сетчатое белое платье', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Маленькая розовая юбка с прозрачным топом', 0, -99, 30
	gs 'zz_clothing', 'fill_clothing', 13, 'Что-то сетчатое', 0, -99, 30
end
! args[1] - group_id
! $args[2] - name
! args[3] - price
! args[4] - condition
! args[5] - bonus
if $args[0] = 'fill_clothing':
	zz_id = arrsize('$clothing')/6
	$clothing[zz_id+"_"+'id'] = str(zz_id)
	$clothing[zz_id+"_"+'group'] = str(args[1])
	$clothing[zz_id+"_"+'name'] = str($args[2])
	$clothing[zz_id+"_"+'price'] = str(args[3])
	$clothing[zz_id+"_"+'condition'] = str(args[4])
	$clothing[zz_id+"_"+'bonus'] = str(args[5])
	killvar 'zz_id'
end
! args[1] - group_id
! $args[2] - name
! args[3] - price
! args[4] - condition
! args[5] - bonus
! args[6] - count
if $args[0] = 'fill_clothing_array':
	i = 1
	:loop_fill_clothing_array
	if i <= val(args[6]):
		gs 'zz_clothing', 'fill_clothing', args[1], $args[2] + ' ' + str(i), args[3], args[4], args[5]
		i += 1
		jump 'loop_fill_clothing_array'
	end
end
! clothing full-list
if $args[0] = 'show_all':
	gs 'zz_clothing', 'init_clothing'
	$zz_str = '<center><table border=0>'
	i = 0
	:loop_cloth_table
	if i < arrsize('$clothing')/6:
		$zz_color = iif($zz_color='#f3f4ee','#ffffff','#f3f4ee')
		$zz_str += '<tr bgcolor='+$zz_color+'>'
		$zz_str += '<td>' + i + '</td>'
		$zz_str += '<td>' + $clothing[i+"_"+'id'] + '</td>'
		$zz_str += '<td>' + $clothing[i+"_"+'group'] + '</td>'
		$zz_str += '<td>' + $clothing[i+"_"+'name'] + '</td>'
		$zz_str += '<td>' + $clothing[i+"_"+'price'] + '</td>'
		$zz_str += '<td>' + $clothing[i+"_"+'condition'] + '</td>'
		$zz_str += '<td>' + $clothing[i+"_"+'bonus'] + '</td>'
		$zz_str += '</tr>'
		i += 1
		jump 'loop_cloth_table'
	end
	gs 'zz_render','','',$zz_str + '</table></center>'
	killvar '$zz_str'
	killvar '$zz_color'
end
! clothing shops
! args[1] - group_id
if $args[0] = 'make_shop':
	killvar 'zz_shop_id'
	gs 'zz_clothing', 'init_clothing'
	$zz_str = '<center><table border=0 width=600>'
	$zz_group = func('zz_clothing', 'get_group_name', args[1])
	i = 0
	:loop_make_cloth_shop
	if i < arrsize('$clothing')/6:
		if args[1] = val($clothing[i+"_"+'group']) and i!127:
			$zz_color = iif($zz_color='#f3f4ee','#ffffff','#f3f4ee')
			$zz_str += '<tr bgcolor='+$zz_color+'>'
			$zz_str += '<td width=60%><a href="exec:view ''images/clothing/'+ $zz_group +'/' + $clothing[i+"_"+'id'] + '.jpg''">' + $clothing[i+"_"+'name'] + '</a></td>'
			$zz_str += '<td width=10%>' + iif(func('zz_clothing','is_exists', i) >= 0,'Есть','') + '</td>'
			$zz_str += '<td width=15%>'+ iif(val($clothing[i+"_"+'price']) >= 0, + $clothing[i+"_"+'price'] +' р.', '') + '</td>'
			$zz_str += '<td width=15%>'+ iif(val($clothing[i+"_"+'price']) <= money, '<a href="exec: gs ''zz_clothing'',''buy'',' + $clothing[i+"_"+'id'] + '">Купить</a>', '') + '</td>'
			$zz_str += '</tr>'
		end
		i += 1
		jump 'loop_make_cloth_shop'
	end
	gs 'zz_render','','',$zz_str + '</table></center>'
	killvar '$zz_str'
	killvar '$zz_color'
	killvar '$zz_group'
end
! buy item
if $args[0] = 'buy':
	if money >= val($clothing[args[1]+"_"+'price']):
		money -= val($clothing[args[1]+"_"+'price'])
		achiev['cloth,'+val($clothing[args[1]+"_"+'group'])] += 1
		gs 'stat'
		gs 'zz_clothing', 'add_to_wardrobe', val($clothing[args[1]+"_"+'id'])
		gs 'zz_funcs','message','','<green>Вы купили ' + $clothing[args[1]+"_"+'name'] + '</green>'
	else
		gs 'zz_funcs','message','','<red>У вас недостаточно денег для покупки!</red>'
	end
end
! add item to wardrobe
! args[1] - clothing_id
if $args[0] = 'add_to_wardrobe':
	! get max wardrobe_id
	zz_id = arrsize('$wardrobe')/10
	zz_max_id = zz_id - 1
	$wardrobe[zz_id+"_"+'wardrobe_id'] = iif(zz_max_id < 0, 0, $wardrobe[zz_max_id+"_"+'wardrobe_id']+1)
	$wardrobe[zz_id+"_"+'clothing_id'] = $clothing[args[1]+"_"+'id']
	$wardrobe[zz_id+"_"+'group'] = $clothing[args[1]+"_"+'group']
	$wardrobe[zz_id+"_"+'name'] = $clothing[args[1]+"_"+'name']
	$wardrobe[zz_id+"_"+'price'] = $clothing[args[1]+"_"+'price']
	$wardrobe[zz_id+"_"+'condition'] = $clothing[args[1]+"_"+'condition']
	$wardrobe[zz_id+"_"+'base_condition'] = $clothing[args[1]+"_"+'condition']
	$wardrobe[zz_id+"_"+'bonus'] = $clothing[args[1]+"_"+'bonus']
	$wardrobe[zz_id+"_"+'size'] = func('zz_clothing', 'set_size', $clothing[args[1]+"_"+'group'])
	$wardrobe[zz_id+"_"+'trashbag'] = 0
	killvar 'zz_id'
	killvar 'zz_max_id'
end
! set clothing size
if $args[0] = 'set_size':
	if $args[1] = '0' or $args[1] = '1' or $args[1] = '3' or $args[1] = '11' or $args[1] = '12' or $args[1] = '13':
		result = 0
	else
		result = body['hips']
	end
end
! get clothing_id for current wardrobe_id
if $args[0] = 'get_clothing_id':
	result = val($wardrobe[current_clothing+"_"+'clothing_id'])
end
! get wardrobe_id for clothing_id
! args[1] - clothing_id
if $args[0] = 'get_wardrobe_id':
	zz_id = func('zz_clothing', 'is_exists', args[1])
	result = iif(zz_id >= 0, zz_id, -1)
	killvar 'zz_id'
end
! get group_id
! args[1] - wardrobe_id
if $args[0] = 'get_group':
	j = 0
	! for current_clothing
	if args[1] = 0:
		result = val($wardrobe[current_clothing+"_"+'group'])
		exit
	end
	result = -1
	:find_group
	if j < arrsize('$wardrobe')/10:
		if val($wardrobe[j+"_"+'wardrobe_id']) = args[1]:
			! return group_id
			result = val($wardrobe[j+"_"+'group'])
			exit
		end
		j += 1
		jump 'find_group'
	end
end
! get group_name
! args[1] - group_id
if $args[0] = 'get_group_name':
	gs 'zz_funcs', 'make_array', 'sarafan,jeans,sportswear,shorts,skirts,pants,brend_dress,dress,young_dress,work,school,hooker,erotic'
	if args[1] = 0:
		$result = ''
	else
		$result = $zz_funcs_result[args[1]-1]
		killvar '$zz_funcs_result'
	end
end
! make wardrobe
! args[1] - group (1-13 or nothing for all)
if $args[0] = 'wardrobe':
	$zz_str = '<center><table border=0 align=center>'
	$zz_str += '<tr>'+ iif(val($settings['wardrobe_show_thumbnail']) = 1,'<th>Фото</th>','') +'<th>Название</th><th>Размер</th><th>Состояние</th><th colspan=2>Действие</th></tr>'
	! init action_strings array
	$zz_str_act[0] = ''
	$zz_str_act[1] = ''
	$zz_str_act[2] = ''
	$zz_str_act[3] = ''
	!excluding 0-2
	i = 3
	:loop_wardrobe
	if i < arrsize('$wardrobe')/10:
		zz_id = val($wardrobe[i+"_"+'wardrobe_id'])
		! exclude current clothing & trashbag clothing
		if current_clothing ! i and val($wardrobe[i+"_"+'trashbag']) = 0:
			!
			if args[1] ! 13:
				if val($wardrobe[i+"_"+'group']) = 13:
					i += 1
					jump 'loop_wardrobe'
				end
			end
			! get action_id
			zz_action_id = func('zz_clothing','get_action_id', val($wardrobe[i+"_"+'condition']),val($wardrobe[i+"_"+'size']),val($wardrobe[i+"_"+'group']))
			! get image path
			$zz_image = func('zz_clothing','get_image_path',val($wardrobe[i+"_"+'group']),val($wardrobe[i+"_"+'clothing_id']))
			! fill action_strings array
			$zz_str_act[zz_action_id] += '<tr bgcolor=#f3f4ee>'
			! thumbnail cell
			if val($settings['wardrobe_show_thumbnail']) = 1:
				$zz_str_act[zz_action_id] += '<td><img width=' + ($settings['wardrobe_thumbnail_size']*10+50) + ' src="' + $zz_image + '"></td>'
			end
			$zz_str_act[zz_action_id] += '<td align=left><a href="exec:view ''' + $zz_image + '''">' + $wardrobe[i+"_"+'name'] + '</a></td>'
			$zz_str_act[zz_action_id] += '<td>' + iif($wardrobe[i+"_"+'size'] > 0, $wardrobe[i+"_"+'size'], '') + '</td>'
			$zz_str_act[zz_action_id] += '<td>' + func('zz_clothing','get_status',val($wardrobe[i+"_"+'condition']),val($wardrobe[i+"_"+'base_condition'])) + '</td>'
			$zz_str_act[zz_action_id] += '<td>' + func('zz_clothing','get_action_string',zz_action_id,zz_id,i) + '</td>'
			$zz_str_act[zz_action_id] += '<td>' + func('zz_clothing','get_trashbag_string',zz_id) +'</td>'
			$zz_str_act[zz_action_id] += '</tr>'
		end
		i += 1
		jump 'loop_wardrobe'
	end
	! output by actions
	gs 'zz_render','','',$zz_str + $zz_str_act[0] + $zz_str_act[1] + $zz_str_act[2] + $zz_str_act[3] + '</table></center>'
	killvar '$zz_str'
	killvar '$zz_str_act'
	killvar 'zz_action_id'
	killvar 'zz_id'
	killvar '$zz_image'
end
! -----
! move to trashbag string
! args[1] - wardrobe_id
if $args[0] = 'get_trashbag_string':
	$result = iif(args[1] > 2,'<a href="exec:gs''zz_clothing'',''trashbag_action'',' + args[1] + '">В корзину</a>','')
end
! move to wardrobe string
! args[1] - wardrobe_id
if $args[0] = 'get_wardrobe_string':
	$result = '<a href="exec:gs''zz_clothing'',''trashbag_action'',' + args[1] + '">В шкаф</a>'
end
! move to trashbag/wardrobe
! args[1] - wardrobe_id
if $args[0] = 'trashbag_action':
	i = 0
	:loop_move_to
	if i < arrsize('$wardrobe')/10:
		if val($wardrobe[i+"_"+'wardrobe_id']) = args[1]:
			$wardrobe[i+"_"+'trashbag'] = iif($wardrobe[i+"_"+'trashbag']=1,0,1)
			if $wardrobe[i+"_"+'trashbag'] = 0:
				gt 'zz_clothing','trashbag'
			else
				gt 'loker','start'
			end
			exit
		end
		i += 1
		jump 'loop_move_to'
	end
end
! trashbag
if $args[0] = 'trashbag':
	$zz_str = '<center><table border=0 align=center>'
	$zz_str += '<tr>'+ iif(val($settings['wardrobe_show_thumbnail']) = 1,'<th>Фото</th>','') +'<th>Название</th><th>Размер</th><th>Состояние</th><th>Действие</th></tr>'
	i = 3
	:loop_trashbag
	if i < arrsize('$wardrobe')/10:
		! trashbag clothing only
		if val($wardrobe[i+"_"+'trashbag']) = 1:
			$zz_str += '<tr bgcolor=#f3f4ee>'
			$zz_image = func('zz_clothing','get_image_path',val($wardrobe[i+"_"+'group']),val($wardrobe[i+"_"+'clothing_id']))
			! thumbnail cell
			if val($settings['wardrobe_show_thumbnail']) = 1:
				$zz_str += '<td><img width=' + ($settings['wardrobe_thumbnail_size']*10+50)+ ' src="' + $zz_image + '"></td>'
			end
			$zz_str += '<td align=left><a href="exec:view ''' + $zz_image + '''">' + $wardrobe[i+"_"+'name'] + '</a></td>'
			$zz_str += '<td>' + iif($wardrobe[i+"_"+'size'] > 0, $wardrobe[i+"_"+'size'], '') + '</td>'
			$zz_str += '<td>' + func('zz_clothing','get_status',val($wardrobe[i+"_"+'condition']),val($wardrobe[i+"_"+'base_condition'])) + '</td>'
			$zz_str += '<td>' + func('zz_clothing','get_wardrobe_string',val($wardrobe[i+"_"+'wardrobe_id'])) +'</td>'
			$zz_str += '</tr>'
		end
		i += 1
		jump 'loop_trashbag'
	end
	! output by actions
	gs 'zz_render','Корзина','',$zz_str + '</table></center>'
	act 'В шкаф': gt 'loker','start'
	killvar '$zz_str'
	killvar '$zz_image'
end
! -----
! return image_path
! args[1] - int group_id
! args[2] - int clothing_id
! if args[1] = 0 and args[1] = 0 -> get current_clothing
if $args[0] = 'get_image_path':
	! check for current_clothing
	zz_clothing_id = 0
	if args[1] < 1 and args[2] < 1:
		! get group_id for current clothing
		zz_group_id = func('zz_clothing','get_group')
		! get clothing_id for current clothing
		zz_clothing_id = func('zz_clothing','get_clothing_id')
	else
		zz_group_id = args[1]
	end
	! get group_name
	if zz_group_id < 1:
		! unknown group_id
		$zz_group_name = ''
		zz_clothing_id = 0
	else
		! ... from string
		$zz_group_name = func('zz_clothing','get_group_name',zz_group_id) + '/'
		zz_clothing_id = iif(zz_clothing_id < 1, args[2], zz_clothing_id)
	end
	$result = 'images/clothing/'+ $zz_group_name + zz_clothing_id + '.jpg'
end
!---
! args[1] - condition
! args[2] - base_condition
! -99 - no condition
if $args[0] = 'get_status':
	if args[1] = -99 or args[1] >= args[2]*3/4: $result = 'отличное '
	if args[1] >= args[2]*2/4 and args[1] < args[2]*3/4: $result = 'хорошее '
	if args[1] >= args[2]*1/4 and args[1] < args[2]*2/4: $result = 'нормальное '
	if args[1] > 0 and args[1] < args[2]*1/4: $result = 'плохое '
	if args[1] <= 0 and args[1] ! -99: $result = 'вещь изношена '
end
! get action_id for sorting by action
! args[1] - condition
! args[2] - size
! args[3] - group
if $args[0] = 'get_action_id':
	! check unsized clothing or size for other & condition
	if ((args[3] = 1 or args[3] = 3 or args[3] = 11 or args[3] = 12 or args[3] = 13) or (args[2] >= body['hips'] - 8 and args[2] <= body['hips'] + 8)) and (args[1] = -99 or args[1] > 0):
		result = 0
		exit
	! check condition/condition = 0
	elseif args[1] <= 0 and args[1] ! -99:
		result = 2
		exit
	! check size
	elseif args[1] > 0 and args[2] >= body['hips']:
		result = 1
		exit
	! other
	else
		result = 3
		exit
	end
end
! make action_string by action_id
! args[1] - action_id
! args[2] - wardrobe_id
! args[3] - counter_id
if $args[0] = 'get_action_string':
	if args[1] = 0: $result = '<a href="exec: gs ''zz_clothing'', ''redress'', ' + args[3] + ' & gt ''loker'', ''start''">Надеть</a>'
	if args[1] = 1:
		if poSkill >= 100:
			$result = '<a href="exec: gs ''zz_clothing'',''alter_clothing'', ' + args[3] + ' & gt ''loker'', ''start''">Перешить</a>'
		else
			$result = ''
		end
	end
	if args[1] = 2: $result = '<a href="exec: gs ''zz_clothing'', ''remove_at'', ' + args[2] + ' & gt ''loker'',''start''">Выбросить</a>'
	if args[1] = 3: $result = ''
end
! decrease current clothing condition
if $args[0] = 'decrease_condition':
	if $wardrobe[current_clothing+"_"+'base_condition'] > 0: $wardrobe[current_clothing+"_"+'condition'] -= iif(val(args[1]) > 1, val(args[1]), 1)
end
! args[1] - counter_id
! change clothing
if $args[0] = 'redress':
	odevnesh -= func('zz_clothing', 'get_view_bonus')
	if current_clothing > 2: prev_clothing = current_clothing
	current_clothing = args[1]
	odevnesh += func('zz_clothing','get_view_bonus')
end
! remove clothing from wardrobe
! args[1] - wardrobe_id
if $args[0] = 'remove_at':
	i = 0
	deleted_item = -1
	:loop_remove_clothing
	if i < arrsize('$wardrobe')/10:
		if $wardrobe[i+"_"+'wardrobe_id'] ! args[1]:
			zz_id = arrsize('$zz_tmp')/10
			$zz_tmp[zz_id+"_"+'wardrobe_id'] = $wardrobe[i+"_"+'wardrobe_id']
			$zz_tmp[zz_id+"_"+'clothing_id'] = $wardrobe[i+"_"+'clothing_id']
			$zz_tmp[zz_id+"_"+'group'] = $wardrobe[i+"_"+'group']
			$zz_tmp[zz_id+"_"+'name'] = $wardrobe[i+"_"+'name']
			$zz_tmp[zz_id+"_"+'price'] = $wardrobe[i+"_"+'price']
			$zz_tmp[zz_id+"_"+'condition'] = $wardrobe[i+"_"+'condition']
			$zz_tmp[zz_id+"_"+'base_condition'] = $wardrobe[i+"_"+'base_condition']
			$zz_tmp[zz_id+"_"+'bonus'] = $wardrobe[i+"_"+'bonus']
			$zz_tmp[zz_id+"_"+'size'] = $wardrobe[i+"_"+'size']
			$zz_tmp[zz_id+"_"+'trashbag'] = $wardrobe[i+"_"+'trashbag']
		else
			deleted_item = i
		end
		i += 1
		jump 'loop_remove_clothing'
	end
	killvar '$wardrobe'
	killvar 'zz_id'
	copyarr '$wardrobe', '$zz_tmp'
	killvar '$zz_tmp'
	! fix current_clothing i
	if current_clothing > deleted_item: current_clothing -= 1
	killvar 'deleted_item'
end
! args[1] - counter_id
if $args[0] = 'alter_clothing':
	*clr & cla
	minut += 15
	$wardrobe[args[1]+"_"+'size'] = body['hips']
	gs 'stat'
	gs 'zz_render','','','В течение пятнадцати минут вы перешивали одежду, делая ее подходящей вам по размеру.'
	act 'Положить в шкаф': gt 'loker', 'start'
end
! args[0] - wardrobe_id
if $args[0] = 'get_size':
	result = val($wardrobe[iif(args[0]>=0,args[0],current_clothing)+"_"+'size'])
end
! args[0] - wardrobe_id
! 80% base price & current_condition
if $args[0] = 'get_price':
	result = val($wardrobe[args[1]+"_"+'price']) * (val($wardrobe[args[1]+"_"+'condition']) / val($wardrobe[args[1]+"_"+'base_condition'])) * 4/5
end
! tailor
if $args[0] = 'tailor':
	*clr & cla
	gs 'zz_render','Ателье по пошиву и ремонту одежды','qwest/alter/atelie.jpg','Небольшое ателье, в котором можно перешить или продать неподходящую одежду.'
	act 'Уйти': gt $loc, $metka
	$zz_str = '<center><table border=0 align=center>'
	$zz_str += '<tr>'+ iif(val($settings['wardrobe_show_thumbnail']) = 1,'<th>Фото</th>','') +'<th>Название</th><th>Размер</th><th>Состояние</th><th colspan=2>Действие</th></tr>'
	i = 3
	:loop_tailor
	if i < arrsize('$wardrobe')/10:
		zz_id = val($wardrobe[i+"_"+'wardrobe_id'])
		$zz_image = func('zz_clothing','get_image_path',val($wardrobe[i+"_"+'group']),val($wardrobe[i+"_"+'clothing_id']))
		!if current_clothing ! zz_id:
		! exclude current clothing
		if current_clothing ! i:
			$zz_str += '<tr bgcolor=#f3f4ee>'
			! thumbnail cell
			if val($settings['wardrobe_show_thumbnail']) = 1:
				$zz_str += '<td><img width=' + $settings['wardrobe_thumbnail_size'] + ' src="' + $zz_image + '"></td>'
			end
			! name cell
			$zz_str += '<td align=left><a href="exec:view ''' + $zz_image + '''">' + $wardrobe[i+"_"+'name'] + '</a></td>'
			! size
			$zz_str += '<td>' + iif($wardrobe[i+"_"+'size'] > 0, $wardrobe[i+"_"+'size'], '') + '</td>'
			! current condition
			$zz_str += '<td>' + func('zz_clothing','get_status',val($wardrobe[i+"_"+'condition']),val($wardrobe[i+"_"+'base_condition'])) + '</td>'
			! actions - get id
			zz_action_id = func('zz_clothing','get_action_id', val($wardrobe[i+"_"+'condition']),val($wardrobe[i+"_"+'size']),val($wardrobe[i+"_"+'group']))
			! action #1 - fit clothing
			if zz_action_id = 1 and money >= 500:
				$zz_str += '<td><a href="exec: gs ''zz_clothing'',''tailor_fit_clothing'',' + i + '">Перешить</a></td>'
			else
				$zz_str += '<td></td>'
			end
			! action #2 - sell
			if val($wardrobe[i+"_"+'condition']) = 0: $wardrobe[i+"_"+'condition'] = 1
			if val($wardrobe[i+"_"+'base_condition'] > 0) and ((val($wardrobe[i+"_"+'base_condition'])) / (val($wardrobe[i+"_"+'condition'])) < 2):
				zz_price = func('zz_clothing','get_price',i)
				$zz_str += '<td><a href="exec: gs ''zz_clothing'',''tailor_sell_clothing'',' + zz_id + ','+ zz_price +'">Продать (' + zz_price + 'р.)</a></td>'
			else
				$zz_str += '<td></td>'
			end
			$zz_str += '</tr>'
		end
		i += 1
		jump 'loop_tailor'
	end
	$zz_str += '</table></center>'
	! output by actions
	gs 'zz_render','','',$zz_str
	killvar '$zz_str'
	killvar 'zz_price'
	killvar 'zz_id'
	killvar '$zz_image'
	killvar 'zz_action_id'
end
! args[1] - counter_id
if $args[0] = 'tailor_fit_clothing':
	money -= 500
	minut += 15
	$wardrobe[args[1]+"_"+'size'] = body['hips']
	gs 'stat'
	gt 'zz_clothing', 'tailor'
end
! args[1] - wardrobe_id
! args[2] - price
if $args[0] = 'tailor_sell_clothing':
	money += args[2]
	! remove item
	zz_id = args[1]
	gs 'zz_clothing', 'remove_at', zz_id
	killvar 'zz_id'
	gs 'stat'
	gt 'zz_clothing', 'tailor'
end
! args[1] - counter_id
! args[2] - 1 for town tailor
if $args[0] = 'fit_clothing':
	cla
	counter_id = args[1]
	zz_size = func('zz_clothing', 'get_size', counter_id)
	if zz_size > 0 and zz_size >= body['hips']:
		gs 'zz_render','','pavlovo/market/tailor','<do>- Я не могу ушить данное изделие, оно не сходится на вас.</do>'
	else
		$wardrobe[counter_id+"_"+'size'] = body['hips']
		gs 'zz_render','','pavlovo/market/tailor','Вы разделись за ширмочкой и подали одежду ' + iif(args[2]>0,'портному','Якову Соломоновичу') + ', он за пятнадцать минут ушил вашу одежду и вернул вам.'
	end
	killvar 'zz_size'
	killvar 'counter_id'
	!act 'Назад': gt 'zz_clothing', 'tailor'
end
if $args[0] = 'fit_all_clothing':
	i = 3
	:loop_fit_clothing
	if i < arrsize('$wardrobe')/10 and money >= 500:
		zz_size = $wardrobe[i+"_"+'size']
		if zz_size > 0 and zz_size > body['hips']:
			$wardrobe[i+"_"+'size'] = body['hips']
			money -= 500
		end
		i += 1
		jump 'loop_fit_clothing'
	end
	gs 'zz_render','','pavlovo/market/tailor','Портной перешил вашу одежду.'
	killvar 'zz_size'
end
! resizer
if $args[0] = 'resize_all':
	i = 0
	:loop_resize_all
	if i < arrsize('$wardrobe')/10:
		if $wardrobe[i+"_"+'size'] > 0: $wardrobe[i+"_"+'size'] = body['hips']
		i += 1
		jump 'loop_resize_all'
	end
end
! dressing for emergency button
if $args[0] = 'fix_emergency':
	i = 3
	:loop_emergency
	if i < arrsize('$wardrobe')/10:
		if ((val($wardrobe[i+"_"+'group']) = 1 or val($wardrobe[i+"_"+'group']) = 3) or (val($wardrobe[i+"_"+'size']) >= body['hips'] - 8 and val($wardrobe[i+"_"+'size']) <= body['hips'] + 8)) and (val($wardrobe[i+"_"+'condition']) = -99 or val($wardrobe[i+"_"+'condition']) > 0):
			current_clothing = i
			exit
		end
		i += 1
		jump 'loop_emergency'
	end
end
! check skirt
if $args[0] = 'is_skirt':
	if val($wardrobe[current_clothing+"_"+'group']) = 1 or val($wardrobe[current_clothing+"_"+'group']) = 5 or val($wardrobe[current_clothing+"_"+'group']) >= 7:
		result = 1
	else
		result = 0
	end
end
! check glamour
if $args[0] = 'is_glamour':
	if val($wardrobe[current_clothing+"_"+'group']) = 7 or val($wardrobe[current_clothing+"_"+'group']) = 9:
		result = 1
	else
		result = 0
	end
end
! return wardrobe_id (if exists) or -1
! args[1] - clothing_id
if $args[0] = 'is_exists':
	j = 0
	result = -1
	:find_exists
	if j < arrsize('$wardrobe')/10:
		if val($wardrobe[j+"_"+'clothing_id']) = args[1]:
			! return wardrobe_id
			result = val($wardrobe[j+"_"+'wardrobe_id'])
			exit
		end
		j += 1
		jump 'find_exists'
	end
end
! check schooldress
if $args[0] = 'is_schooldress':
	if func('zz_clothing','get_clothing_id') = 151 or func('zz_clothing','get_clothing_id') = 157:
		result = 1
	else
		result = 0
	end
end
! lock schooldress
if $args[0] = 'lock_school_dress':
	i = 0
	:find_school_dress
	if i < arrsize('$wardrobe')/10:
		if val($wardrobe[i+"_"+'clothing_id']) = 151 or val($wardrobe[i+"_"+'clothing_id']) = 157:
			gs 'zz_clothing', 'remove_at', val($wardrobe[i+"_"+'clothing_id'])
		end
		i += 1
		jump 'find_school_dress'
	end
	exit
end
! get dress-bonus for view
if $args[0] = 'get_view_bonus':
	result = val($wardrobe[current_clothing+"_"+'bonus'])
end
! disposing
if $args[0] = 'dispose':
	killvar '$clothing'
end