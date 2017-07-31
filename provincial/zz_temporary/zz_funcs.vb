! make array from comma-separated string
! $args[1] - comma-separated string
if $args[0] = 'make_array':
	if len($args[1]) > 0:
		$zz_arr = trim($args[1])
		zz_pos = 0
		! split string
		:loop_split_arr
		! find comma position
		zz_pos = instr($zz_arr, ',')
		if zz_pos > 0:
			! add word to array
			$result[] = str(mid($zz_arr, 1, zz_pos - 1))
			! remove first word
			$zz_arr = mid($zz_arr, zz_pos + 1)
			jump 'loop_split_arr'
		end
		! last word
		$result[] = $zz_arr
		killvar '$zz_arr'
		killvar 'zz_pos'
	else
		$result = ''
	end
end
! получаем запись по id из строки-массива
! $args[1] - строка-массив
! args[2] - id строки
if $args[0]  = 'get_item_string':
	_id = args[2]
	! получаем массив со строки
	gs 'zz_funcs','make_array',$args[1]
	! копируем во временный массив и чистим $result
	copyarr '$_arr','$result'
	killvar '$result'
	! если значение меньше 0 возвращает рандомный элемент
	if _id < 0:
		$result = $_arr[rand(0,arrsize('$_arr')-1)]
	else
		! сверяем размер массива с id и возвращаем результирующую строку
		$result = iif(arrsize('$_arr') > _id,$_arr[_id],'')
	end
	killvar '_id'
	killvar '$_arr'
end
! получаем индекс искомого элемента со строки-массива
! $args[1] - строка-массив
! $args[2] - искомая строка
if $args[0] = 'get_item_id':
	$_item = lcase($args[2])
	gs 'zz_funcs','make_array',lcase($args[1])
	copyarr '$_arr','$result'
	killvar '$result'
	_pos = 0
	:loop_item
	if $_arr[_pos] = $_item:
		result = _pos
		killvar '$_item'
		exit
	end
	_pos += 1
	if _pos < arrsize('$_arr'): jump 'loop_item'
	! если ничего не нашли - возвращаем -1
	result = -1
	killvar '$_item'
end
! return formatted date or time string
! args[1] - day/hours
! args[2] - month/minutes
! $args[3] - delimeter
! optional
! args[4] - year
if $args[0] = 'make_datetime':
	$result = iif(args[1]<10,'0'+str(args[1]),args[1]) + $args[3] + iif(args[2]<10,'0'+str(args[2]),args[2]) + iif(args[4]>0,$args[3]+args[4],'')
end
if $args[0] = 'colorize_day':
	if $settings['enable_background'] = 0:
		FColor = RGB(0,0,0)
		BColor = RGB(255,255,255)
		LColor = RGB(106,90,205)
	end
end
! args1 - value
! args2 - max.value
! args3 - reverse
if $args[0] = 'scale':
	if args[2] = 0: args[2] = 1
	_value = args[1] * 100 / args[2]
	if _value < 1: _value = 1
	if _value > 100: _value = 100
	! scalewidth = 120px
	_width = _value * 120 / 100
	if _value < 30: $_color = iif(args[3] = 1,'green','red')
	if _value >= 30 and _value < 70 and args[3] = 0: $_color = 'blue'
	! reverse colors
	if _value >= 30 and _value < 50 and args[3] = 1: $_color = 'yellow'
	if _value >= 50 and _value < 70 and args[3]  = 1: $_color = 'orange'
	if _value >= 70: $_color = iif(args[3]= 1,'red','green')
	! colors 2
	if _value < 20 and args[3] = 2: $_color = 'red'
	if _value >= 20 and _value < 40 and args[3] = 2: $_color = 'orange'
	if _value >= 40 and _value < 60 and args[3] = 2: $_color = 'yellow'
	if _value >= 60 and _value < 80 and args[3] = 2: $_color = 'blue'
	if _value >= 80 and args[3] = 2: $_color = 'green'
	! ---
	$result = ' <img src="images/common/icons/'+$_color+'.png" height=15 width=' + _width + '><img src="images/common/icons/blank.png" height=15 width=' + (120-_width) + '> <font color='+$_color+'>'+args[1]+'</font> '
	killvar '_width'
	killvar '_value'
	killvar '$_color'
end
! ---
! check HEX-color
if $args[0] = 'check_hex_color':
	$result = iif(strcomp(lcase($args[1]),'^#[0-9a-f]{6}$') >= 0,'',lcase($args[1]))
end
! функция возвращает RGB-цвет из HEX-строки
if $args[0] = 'HEX2RGB':
	! remove '#'
	$_hex = mid($args[1],2)
	! get RGB
	_r = func('zz_funcs','HEX2DEC',mid($_hex,1,1))*16 + func('zz_funcs','HEX2DEC',mid($_hex,2,1))
	_g = func('zz_funcs','HEX2DEC',mid($_hex,3,1))*16 + func('zz_funcs','HEX2DEC',mid($_hex,4,1))
	_b = func('zz_funcs','HEX2DEC',mid($_hex,5,1))*16 + func('zz_funcs','HEX2DEC',mid($_hex,6,1))
	result = RGB(_r,_g,_b)
	killvar '_r'
	killvar '_g'
	killvar '_b'
	killvar '$_hex'
end
! функция конвертирует HEX-символ в десятичное число
if $args[0] = 'HEX2DEC':
	$_hchar = lcase($args[1])
	if val($_hchar) > 0 and val($_hchar) < 10:
		result = val($_hchar)
	elseif $_hchar = '0':
		result = 0
	elseif $_hchar = 'a':
		result = 10
	elseif $_hchar = 'b':
		result = 11
	elseif $_hchar = 'c':
		result = 12
	elseif $_hchar = 'd':
		result = 13
	elseif $_hchar = 'e':
		result = 14
	elseif $_hchar = 'f':
		result = 15
	end
	killvar '$_hchar'
end
! make table row from comma-separated string
! $args[1] - comma-separated string
! optional:
! $args[2] - row background color
! args[3] - th tag, 0/1
! optional - set color for some cell
! args[4] - cell_id
! $args[5] - cell color
if $args[0] = 'make_table_row':
	$_row_data = $args[1]
	$_row_color = $args[2]
	_row_th = args[3]
	_row_cell_id = args[4]
	$_row_cell_color = func('zz_funcs','check_hex_color',$args[5])
	! start row & set bgcolor if needed
	$_row_str = '<tr' + iif(func('zz_funcs','check_hex_color',$_row_color)='','',' bgcolor='+$_row_color) + '>'
	! make array from string
	gs 'zz_funcs','make_array',$_row_data
	copyarr '$_row_arr','$result'
	killvar '$result'
	! fill row with columns
	_col_i = 0
	:make_row
	! start cell & check TH-tag
	$_row_str += '<'+iif(_row_th = 1,'th','td')
	! set cell bgcolor if needed
	$_row_str += iif(_row_cell_id = _col_i,iif(func('zz_funcs','check_hex_color',$_row_cell_color)='','',' bgcolor='+$_row_cell_color),'')+'>'
	! add cell text
	$_row_str += $_row_arr[_col_i]
	! close cell & check TH-tag
	$_row_str += '</'+iif(_row_th = 1,'th','td') + '>'
	! ---
	_col_i += 1
	if _col_i < arrsize('$_row_arr'): jump 'make_row'
	! close row
	$_row_str += '</tr>'
	$result = $_row_str
	! clean
	killvar '$_row_data'
	killvar '_row_th'
	killvar '$_row_color'
	killvar '_row_cell_id'
	killvar '$_row_cell_color'
	killvar '$_row_str'
	killvar '_col_i'
	killvar '$_row_arr'
end
! функция создает табличку с массива строк
! $args[1] - массив строк
! опционально:
! args[2] - ширина таблицы, если меньше 200 - растягиваем на 100%
! args[3] - вывод: 0 - в главное окно с помощью zz_render, 1 - вывод в окно доп.описания
if $args[0] = 'make_table':
	i = 0
	$_table_width = iif(args[2] > 800 or args[2] < 200,'100%',args[2])
	_table_func = args[3]
	copyarr('$_table_arr','$result')
	$_table = '<center><font color=#000000><table cellpadding=0 cellspacing=1 border=0 width="'+$_table_width+'" align=center>'
	:loop_table
	$_table += func('zz_funcs','make_table_row',$_table_arr[i],iif(i=0,'#bbee77',iif(i mod 2 = 0,'#f3f4ee','#ffffff')),iif(i=0,1,0))
	i += 1
	if i < arrsize('$_table_arr'): jump 'loop_table'
	$_table += '</table></font></center>'
	if _table_func = 1:
		pl $_table
	else
		gs 'zz_render','','',$_table
	end
	killvar '$_table'
	killvar '$_table_width'
	killvar '_table_func'
end
if $args[0] = 'splitter':
	$result = '<img src="images/common/icons/splitter.png" width=100% height=3 alt=<<rand(10000)>> >'
end
! создаем линк из условий - во вне рабочее время выводим текст
! args[1] - время начала работы
! args[2] - время конца работы
! $args[3] - текст ссылки
! $args[4] - адресс ссылки - локация перехода
! $args[5] - аргумент, опционально
! args[6] - время перехода, опционально, по умолчанию - 5 мин
if $args[0] = 'mk_link':
	if args[6] <= 0: args[6] = 5
	$_link = '<a href="exec: minut+=<<args[6]>> & gt ''<<$args[4]>>'',''<<$args[5]>>''"><<$args[3]>></a>'
	if args[1] < args[2]:
		! если время начала меньше времени конца работы: 06.00 - 20.00
		if hour >= args[1] and hour <= args[2]:
			$result = $_link
		else
			$result = $args[3]
		end
	else
		! если время конца работы меньше времени начала: 15.00 - 03.00
		if hour >= args[1] or hour <= args[2]:
			$result = $_link
		else
			$result = $args[3]
		end
	end
	killvar '$_link'
end
! relation desc
if $args[0] = 'relations':
	$zz_rel[0] = 'плохие отношения'
	$zz_rel[1] = 'напряженные отношения'
	$zz_rel[2] = 'нормальные отношения'
	$zz_rel[3] = 'хорошие отношения'
	$zz_rel[4] = 'отличные отношения'
	$result = 'У вас ' + $zz_rel[iif(val($args[1])/20>4,4,val($args[1])/20)] + '.'
	killvar '$zz_rel'
end
if $args[0] = 'waiting':
	act iif(args[1] > 0,'Бездельничать','Ждать'):
		cla
		waiting = input('Сколько минут ждать? (Не больше 120 минут)')
		if waiting > 120: waiting = 120
		if waiting < 0: waiting = 0
		if waiting ! 0: minut += waiting & gs 'stat'
		gt $curloc
	end
end
if $args[0] = 'hornyrand':
	if rand(1,100) > horny:
		horny += 10
		gs 'zz_render','','','Вы остались не удовлетворены'
	else
		horny = 0
		orgasm += 1
		gs 'zz_render','','','Вас охватил оргазм'
	end
end
if $args[0] = 'cum':
	if $args[1] = 'face': cumface = iif(minut < 30, 1, 2) & facial += 1 & exit
	if $args[1] = 'lip': cumlip = iif(minut < 30, 1, 2) & exit
	if $args[1] = 'belly': cumbelly = iif(minut < 30, 2, 3) & exit
	if $args[1] = 'ass': cumass = iif(minut < 30, 2, 3) & exit
	if $args[1] = 'pussy':
		if preg ! 0:
			gs 'zz_render', '', '', 'Вы усмехнулись про себя, ну по крайней мере вы не залетите.'
		elseif mesec > 0:
			gs 'zz_render', '', '', '\\\"- Хорошо, что месячные, хоть не залечу..."///, - с облегчением подумали вы.'
		elseif tabletki > 0:
			gs 'zz_render', '', '', '\\\"- Надеюсь таблетки помогут"///, - подумали вы.'
		else
			gs 'preg'
			manna -= 15
			gs 'zz_render', '', '', '\\\"- Черт, так ведь и залететь можно"///, - подумали вы с ужасом.'
		end
		cumpussy = iif(minut < 30, 3, 4) & exit
	end
	if $args[1] = 'anus': cumanus = iif(minut < 30, 3, 4) & exit
end
if $args[0] = 'wanted':
	gs 'zz_render','','wanted.png','<center><font size=3 color=red>Разыскивается фотка, соответствующая описанию ниже!<br><br><br></font></center>'
end
! обертка для рисунков
if $args[0] = 'make_image_box':
	! $args[1] - image path
	! args[2] - image width
	$mib_img = 'images/common/mobile/'
	$result = '<table cellpadding=0 cellspacing=0>'
	! header
	$result += '<tr><td width=10><img src="'+$mib_img+'/tl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$mib_img+'/tr.png"></td></tr>'
	! image
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee"><img '+iif(args[2]>0,'width='+args[2],'')+' src="'+$args[1]+'"></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! footer
	$result += '<tr><td width=10><img src="'+$mib_img+'/bl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$mib_img+'/br.png"></td></tr>'
	$result += '</table>'
	killvar '$mib_img'
end
if $args[0] = 'message':
	! $args[1] - image path
	! $args[2] - text
	$mib_img = 'images/common/mobile/'
	$_msg = '<center><table cellpadding=0 cellspacing=0>'
	! header
	$_msg += '<tr><td width=10><img src="'+$mib_img+'/tl.png"></td><td colspan=3 bgcolor="#eeeeee"></td><td width=10><img src="'+$mib_img+'/tr.png"></td></tr>'
	! message
	$_msg += '<tr><td width=10 bgcolor="#eeeeee"></td>'
	$_msg += '<td width=36 bgcolor="#eeeeee">' + iif(len($args[1])>4,'<img src="'+$args[1]+'" width=36>','') + '</td>'
	$_msg += '<td width=10 bgcolor="#eeeeee"> </td>'
	$_msg += '<td bgcolor="#eeeeee">'+$args[2]+'</td>'
	$_msg += '<td width=10 bgcolor="#eeeeee"></td></tr>'
	! footer
	$_msg += '<tr><td width=10><img src="'+$mib_img+'/bl.png"></td><td colspan=3 bgcolor="#eeeeee"></td><td width=10><img src="'+$mib_img+'/br.png"></td></tr>'
	$_msg += '</table></center><br>'
	pl $_msg
	killvar '$_msg'
	killvar '$mib_img'
end
! Алкоголь
! args[1] - необязательный аргумент, прирост алко, по умолчанию +1
if $args[0] = 'alko':
	frost = 0
    minut += iif(args[1]<=0,10,10*args[1])
    manna += 10*args[1]
    cumlip = 0
	energy += iif(args[1]<=0,1,args[1])
	water = 24
    alko += iif(args[1]<=0,1,args[1])
    if energy > 20: body['day_weight'] += 1
    !Алкоголь плохо вляет на кожу
    if args[1] > 2: gs 'zz_funcs', 'skin', '-'
    !Алкоголь плохо вляет на внешность
    if alko >= 6: vidageday -= 1
end
! Спорт
! args[1] - необязательный аргумент, уменьшение енергии и потливости по умолчанию -1, жажды -2
if $args[0] = 'sport':
	frost = 0
	energy -= iif(args[1]<=0,1,args[1])
	water -= iif(args[1]<=0,2,args[1]*2)
	!manna -= 5
	son -= iif(args[1]<=0,1,args[1]/2)
	sweat += iif(args[1]<=0,1,args[1])
    !Износ спортивной одежды при занятиях спортом
    if sportday ! day and func('zz_clothing','get_group') = 3: sportday = day & gs 'zz_clothing', 'decrease_condition'
end
! Кожа
! args[1] -  повышение/понижение состояния
! args[2] - необязательный аргумент, по умолчанию 1
if $args[0] = 'skin':
	if $args[1] = '+':
		skinvan += iif(args[2]<=0,1,args[2])
		if skinvan >= 20:skinvan = 0 & skin += 1
		if skin > 4: skin = 4
	else
		skinvan -= iif(args[2]<=0,1,args[2])
		if skinvan < 0 and skin > 0: skinvan = 19 & skin -= 1
		if skinvan < 0 and skin = 0: skinvan = 0 & skin = 0
		if skin < 0: skin = 0
	end
end
! функция добавляет к рисунку время суток и года
! $args[1] - путь к рисунку
if $args[0] = 'mk_image':
	$_img = $args[1]
	! проверяем длину входной строки
	if len($_img) = 0 or (len($_img) > 0 and len($_img) < 5 and func('zz_funcs','get_item_id','.jpg,.png,.gif',$_img) >= 0):
		$result = ''
		exit
	end
	! получаем расширение
	$_ext = mid($_img,len($_img)-3)
	! проверяем, есть ли оно, если нет - присваиваем .jpg
	if func('zz_funcs','get_item_id','.jpg,.png,.gif',$_ext) < 0:
		! расширения нет
		$_ext = '.jpg'
	else
		! расширение есть
		! получаем путь без расширения файла
		$_img = mid($_img,1,len($_img)-4)
	end
	! формируем путь с учетом времени суток и года
	$result = $_img + iif(snow <= 0,'','_winter') + iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night') + $_ext
	killvar '$_img'
	killvar '$_ext'
end
! функция добавляет к рисунку время суток и года, а также текущую погоду
! $args[1] - путь к рисунку
! args[2] - переключатель лето/зима или весна/лето/осень/зима, 0/1
! args[3] - переключатель день/ночь или утро/день/вечер/ночь, 0/1
! args[4] - погода, 0 - отключено, 1 - включено
if $args[0] = 'mk_image_ex':
	$_img = $args[1]
	_season_set = args[2]
	_day_set = args[3]
	_weather_set = args[4]
	! проверяем длину входной строки
	if len($_img) = 0 or (len($_img) > 0 and len($_img) < 5 and func('zz_funcs','get_item_id','.jpg,.png,.gif',$_img) >= 0):
		$result = ''
		exit
	end
	! получаем расширение
	$_ext = mid($_img,len($_img)-3)
	! проверяем, есть ли оно, если нет - присваиваем .jpg
	if func('zz_funcs','get_item_id','.jpg,.png,.gif',$_ext) < 0:
		! расширения нет
		$_ext = '.jpg'
	else
		! расширение есть
		! получаем путь без расширения файла
		$_img = mid($_img,1,len($_img)-4)
	end
	! формируем путь с учетом дополнительных параметров
	! получаем время рассвета и заката
	_sunrise_hour = func('zz_weather','sunrise')
	_sunset_hour = func('zz_weather','sunset')
	! -- НАСТРОЙКА ВРЕМЕНИ ГОДА -- !
	! настройка по умолчанию - лето/зима
	if _season_set = 0:
		$_season_set = iif(snow <= 0,'','_winter')
	else
		! настройка весна/лето/осень/зима
		if month >= 3 and month <= 5:
			$_season_set = '_spring'
		elseif month >= 6 and month <= 8:
			$_season_set = '_summer'
		elseif month >= 9 and month <= 11:
			$_season_set = '_autumn'
		else
			$_season_set = '_winter'
		end
	end
	! -- НАСТРОЙКА ВРЕМЕНИ СУТОК -- !
	! настройка по умолчанию - день/ночь
	if _day_set = 0:
		$_day_set = iif(hour >= _sunrise_hour and hour <= _sunset_hour,'','_night')
	else
		! настройка утро/день/вечер/ночь
		if (hour >= _sunrise_hour and hour <= _sunrise_hour + 2):
			! утро
			$_day_set = '_sunrise'
		elseif (hour >= _sunset_hour - 2 and hour <= _sunset_hour):
			! вечер
			$_day_set = '_sunset'
		elseif (hour > _sunrise_hour + 2 and hour < _sunset_hour - 2):
			! день
			$_day_set = '_day'
		else
			! ночь
			$_day_set = '_night'
		end
	end
	! -- НАСТРОЙКА ПОГОДЫ -- !
	! по умолчанию - отключено
	if _weather_set = 0:
		$_weather_set = ''
	else
		if temper > 0:
			$_weather_set = iif(sunWeather >= 0,'_sun','_rain')
		else
			$_weather_set = iif(sunWeather >= 0,'_sun','_snow')
		end
	end
	$result = $_img + $_season_set + $_day_set + $_weather_set + $_ext
	killvar '$_img'
	killvar '$_ext'
	killvar '_season_set'
	killvar '_day_set'
	killvar '_weather_set'
	killvar '_sunrise_hour'
	killvar '_sunset_hour'
end
! функция-бокс для карты
! $args[1] - базовая локация
! args[2] - позиция:
!  0 - NW
!  1 - NE
!  2 - SW
!  3 - SE
if $args[0] = 'mk_map':
	*clr & cla
	act 'Закрыть': gt $loc,$metka
	$_map_location = $args[1]
	_map_id = args[2]
	$_map = '<tr><td><img src="images/common/maps/box/top_left.png"></td><td>' + iif(_map_id >= 2,'<a href="exec:gt''zz_funcs'',''mk_map'',''<<$_map_location>>'',<<_map_id-2>>"><img src="images/common/maps/box/top_a.png"></a>','<img src="images/common/maps/box/top.png">') + '</td><td><img src="images/common/maps/box/top_right.png"></td></tr>'
	$_map += '<tr><td>' + iif(_map_id = 1 or _map_id = 3,'<a href="exec:gt''zz_funcs'',''mk_map'',''<<$_map_location>>'',<<_map_id-1>>"><img src="images/common/maps/box/left_a.png"></a>','<img src="images/common/maps/box/left.png">') + '</td><td><img src="images/common/maps/<<$_map_location>>/<<_map_id>>.png"></td><td>' + iif(_map_id = 0 or _map_id = 2,'<a href="exec:gt''zz_funcs'',''mk_map'',''<<$_map_location>>'',<<_map_id+1>>"><img src="images/common/maps/box/right_a.png"></a>','<img src="images/common/maps/box/right.png">') + '</td></tr>'
	$_map += '<tr><td><img src="images/common/maps/box/bottom_left.png"></td><td>' + iif(_map_id < 2,'<a href="exec:gt''zz_funcs'',''mk_map'',''<<$_map_location>>'',<<_map_id+2>>"><img src="images/common/maps/box/bottom_a.png"></a>','<img src="images/common/maps/box/bottom.png">') + '</td><td><img src="images/common/maps/box/bottom_right.png"></td></tr>'
	gs 'zz_render','','','<center><table cellpadding=0 cellspacing=0 border=0 width=840>' + $_map + '</table></center>'
	killvar '$_map_location'
	killvar '_map_id'
	killvar '$_links'
	killvar '$_map'
end