! global variable
! $zz_funcs_result
!--------------------
! make array from comma-separated string
! $args[1] - comma-separated string
if $args[0] = 'make_array':
	if len($args[1]) > 0:
		$zz_arr = trim($args[1])
		zz_pos = 0
		! split string
		:loop_split_arr
		! find comma position
		zz_pos = instr($zz_arr,',',1)
		if zz_pos > 0:
			! add word to array
			$zz_funcs_result[] = str(mid($zz_arr, 1, zz_pos - 1))
			! remove first word
			$zz_arr = mid($zz_arr, zz_pos + 1)
			jump 'loop_split_arr'
		end
		! last word
		$zz_funcs_result[] = $zz_arr
		killvar '$zz_arr'
		killvar 'zz_pos'
	else
		$result = ''
	end
end
! получаем запись по id из строки-массива
! $args[1] - строка-массив
! args[2] - id строки
if $args[0] = 'get_item_string':
	_id = args[2]
	! получаем массив со строки
	gs 'zz_funcs','make_array',$args[1]
	! копируем во временный массив и чистим $result
	copyarr '$_arr','$zz_funcs_result'
	killvar '$zz_funcs_result'
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
	copyarr '$_arr','$zz_funcs_result'
	killvar '$zz_funcs_result'
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
		*p '<script type="text/javascript">setBodyColors("#FFFFFF","#000000");</script>'
	else
		*p '<script type="text/javascript">setBodyColors("'+$settings['background_color']+'");</script>'
	end
end
! args1 - value
! args2 - max.value
! args3 - reverse
! $args4 - name
if $args[0] = 'scale':
	if args[2] = 0: args[2] = 1
	_value = args[1] * 100 / args[2]
	if _value < 1: _value = 1
	if _value > 100: _value = 100
	! scalewidth = 120px
	_width = _value * 120 / 100
	if _value < 30: $_color = iif(args[3] = 1,'#348017','#C11B17')
	if _value >= 30 and _value < 70 and args[3] = 0: $_color = '#3BB9FF'
	! reverse colors
	if _value >= 30 and _value < 50 and args[3] = 1: $_color = '#FFA62F'
	if _value >= 50 and _value < 70 and args[3] = 1: $_color = '#E56717'
	if _value >= 70: $_color = iif(args[3]= 1,'#C11B17','#348017')
	! colors 2
	if _value < 20 and args[3] = 2: $_color = '#C11B17'
	if _value >= 20 and _value < 40 and args[3] = 2: $_color = '#E56717'
	if _value >= 40 and _value < 60 and args[3] = 2: $_color = '#FFA62F'
	if _value >= 60 and _value < 80 and args[3] = 2: $_color = '#3BB9FF'
	if _value >= 80 and args[3] = 2: $_color = '#348017'
	! ---
	$result = '<div class="scale_placer"><div class="scale_empty_row"><div class="scale_filled_row" style="width:<<_width>>px;background:<<$_color>>;"></div></div>&nbsp;<span style="color:<<$_color>>">'+args[1]+'&nbsp;'+$args[4]+'</span></div>'
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
	copyarr '$_row_arr','$zz_funcs_result'
	killvar '$zz_funcs_result'
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
	copyarr('$_table_arr','$zz_funcs_result')
	killvar '$zz_funcs_result'
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
		if pregnancy ! 0:
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
! $args[1] - image path
! $args[2] - text
if $args[0] = 'message':
	$_msg_img = $args[1]
	$_msg_str = $args[2]
	! <red>, <green> tags
	$_msg_str = replace($_msg_str,'<red>','<span class="red_color">')
	$_msg_str = replace($_msg_str,'</red>','</span>')
	$_msg_str = replace($_msg_str,'<green>','<span class="green_color">')
	$_msg_str = replace($_msg_str,'</green>','</span>')
	*p '<div id="message_box"><p>'+$_msg_str+'</p><p><img src="'+$_msg_img+'"></p></div>'
	*p '<script type="text/javascript">showMessage();</script>'
	killvar '$_msg_img'
	killvar '$_msg_str'
end
! Алкоголь
! args[1] - необязательный аргумент, прирост алко, по умолчанию +1
if $args[0] = 'alko':
	frost = 0
	minut += iif(args[1]<=0,10,10*args[1])
	manna += 10*args[1]
	cumlip = 0
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
! args[1] - повышение/понижение состояния
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
	$result = $_img + iif(snow <= 0,'','_winter') + iif(func('zz_weather','is_day')=1,'','_night') + $_ext
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
if $args[0] = 'set_statuses':
	! все статусы
	! 0. болят соски, язык,влагалище после пирсинга
	! 1. болит попа
	! 2. волосатые ноги видны из-под юбки
	! 3. потек макияж/насыщенность макияжа
	! 4. потность
	! 5. грязная одежда
	! 6. месячные, нет прокладки/есть прокладка
	! 7. беременность
	! 8. запах спермы из рта
	! 9. следы спермы по телу и одежде
	!10. болит влагалище и/или анус из-за секса
	!11. частичная/полная обнаженка, гг без трусиков
	!12. пробка в заднице, вибратор в письке
	!13. венерическое заболевание, простуда, депрессия
	!14. статус нердизма
	!15. опьянение или наркоманский кайф
	!16. холод
	!17. ломка
	!18. корзинка с грибами и ягодами
	!19. долг за квартиру
	!20. каникулы
	!21. напоминалка о работе
	!22. напоминалка об ивентах
	!-------------------
	! обнуляем все статусы
	killvar '$_statuses'
	!-- 0 --
	$_statuses_img[0] = 'pin'
	$_status[0] = 'У вас немного болят соски.<br>'
	$_status[1] = 'У вас сильно болят соски.<br>'
	$_status[2] = 'У вас немного болит влагалище.<br>'
	$_status[3] = 'У вас сильно болит влагалище.<br>'
	$_status[7] = 'У вас ноет язык и он немного припухший.'
	$_status[8] = 'У вас сильно ноет язык и он заметно припухший.'
	$_status[9] = 'У вас болит язык, он сильно опух и едва ворочается во рту.'
	!-- 1 --
	$_status[4] = 'Ваши ягодицы немного покраснели от шлепков и грубых прикосновений и побаливают.'
	$_status[5] = 'Ваши ягодицы горят огнём, на них отчётливо видны полосы.'
	$_status[6] = 'Ваша бедная задница нещадно болит, на ней видны ярко красные рубцы от ударов, местами переходящие в синяки.'
	$_statuses_img[1] = 'ass'
	!-- 2 --
	$_statuses_img[2] = 'depilation'
	!-- 3 --
	$_statuses_img[3] = 'makeup<<mop>>'
	!-- 4 --
	$_statuses_img[4] = 'sweat<<sweat>>'
	$_status[10] = 'Вы вспотели.'
	$_status[11] = 'От вас немного пахнет.'
	$_status[12] = 'От вас разит потом.'
	$_status[13] = 'От вас разит как от бомжихи.'
	!-- 5 --
	$_statuses_img[5] = 'dirty'
	$_status[14] = 'Вы с ног до головы перемазаны в грязи.'
	$_status[15] = 'У вас грязная одежда.'
	!-- 6 --
	$_statuses_img[6] = 'wday'+iif(isprok = 0 and $settings['autotampon'] = 0,0,1)
	$_status[16] = 'У вас течёт кровь между ног, срочно нужна прокладка.'
	$_status[17] = 'У вас месячные, но прокладка вас защищает.'
	!-- 7 --
	$_statuses_img[7] = 'pregnancy'
	!-- 8 --
	$_statuses_img[8] = 'mouthsmell'
	!-- 9 --
	$_statuses_img[9] = 'cum'
	!-- 10 --
	$_statuses_img[10] = 'pain'
	$_status[18] = 'У вас немного болит влагалище.'
	$_status[19] = 'У вас болит влагалище и вы с трудом можете свести ноги вместе.'
	$_status[20] = 'У вас сильно болит влагалище, вы даже с трудом ходите, при этом стараясь пошире расставлять ноги.'
	$_status[21] = 'У вас немного болит и чешется анус.'
	$_status[22] = 'У вас болит анус.'
	$_status[23] = 'У вас сильно болит и кровоточит анус.'
	!-- 11 --
	$_statuses_img[11] = 'nude'
	$_status[24] = 'Вы абсолютно обнажены, и от этого внутри всё трепещет.'
	$_status[25] = 'Вы разделись до трусиков и ваши сисечки призывно раскачиваются при ходьбе.'
	$_status[26] = 'Ваше голое тело прикрывает лишь короткое полотенце.'
	$_status[27] = 'Румянец заливает ваше лицо: вы не надели трусики и теперь из под вашей короткой юбки иногда сверкает голая задница.'
	$_status[28] = 'Вы не надели трусики.'
	!-- 12 --
	$_statuses_img[12] = 'toy'
	!-- 13 --
	$_statuses_img[13] = 'remedy'
	!-- 14 --
	$_status[29] = 'Вы жутко хотите хоть что-нибудь почитать!!!'
	$_status[30] = 'Вам очень хочется что-нибудь почитать.'
	$_status[31] = 'Вам немного скучно и хочется опять погрузится в книги.'
	$_status[32] = 'Вы погружены в свои фантазии после прочтения книги.'
	!-- 15 --
	$_statuses_img[15] = 'drunk'
	!-- 16 --
	$_statuses_img[16] = 'frost'
	!-- 17 --
	$_statuses_img[17] = 'addict'
	!-- 19 --
	$_statuses_img[19] = 'debt'
	!-- 20 --
	$_statuses_img[20] = 'bell'
	!-- 21 --
	$_statuses_img[21] = 'work'
	!-- 22 --
	$_statuses_img[22] = 'info'
	!--
	$_statuses[0] = ''
	if nippain > 0: $_statuses[0] += $_status[iif(nippain < 5,0,1)]
	if painpub > 0: $_statuses[0] += $_status[iif(painpub < 5,2,3)]
	if pirs_pain_ton > 0: $_statuses[0] += $_status[iif(pirs_pain_ton > 2,9,pirs_pain_ton + 6)]
	!--
	if spanked > 0: $_statuses[1] += $_status[iif(spanked/25 >= 2,4,spanked/25 + 4)]
	!--
	if leghair > 0: $_statuses[2] = $leghair
	!--
	$_statuses[3] = $mop
	!--
	if sweat > 0: $_statuses[4] = $_status[9 + sweat]
	!--
	if dirtyclothes = 1: $_statuses[5] = $_status[iif(sweat > 3,14,15)]
	!--
	if mesec > 0 and pregnancy = 0: $_statuses[6] = $_status[iif(isprok = 0 and $settings['autotampon'] = 0,16,17)]
	!--
	if (pregnancyKnow = 1 or pregnancy > 30) and pregnancy < 280:
		$_statuses[7] = 'Вы беременны <<pregnancy>> дней, до родов осталось <<280 - pregnancy>> дней.'
	elseif pregnancy = 280:
		$_statuses[7] = 'У ВАС НАЧАЛИСЬ СХВАТКИ. ВАМ СРОЧНО НАДО В РОДДОМ!'
	end
	!--
	if cumlip > 0: $_statuses[8] = 'Из вашего рта пахнет спермой.'
	!--
	$_statuses[9] = ''
	if cumface > 0: $_statuses[9] += 'Ваше лицо и волосы измазаны в сперме.<br>'
	if cumfrot > 0: $_statuses[9] += 'У вас на одежде пятно спермы.<br>'
	if cumbelly > 0: $_statuses[9] += 'Ваш живот перемазан в сперме.<br>'
	if cumpussy > 0: $_statuses[9] += 'Из вашей киски медленно вытекает сперма.<br>'
	if cumass > 0: $_statuses[9] += 'Ваша попа перемазана в сперме.<br>'
	if cumanus > 0: $_statuses[9] += 'Из вашей попки медленно вытекает сперма.<br>'
	!--
	$_statuses[10] = ''
	if vgape > 0: $_statuses[10] += $_status[17 + vgape]
	if agape > 0: $_statuses[10] += $_status[20 + agape]
	!--
	if current_clothing = 0:
		$_statuses[11] = $_status[iif(tanga = 0,24,25)]
	elseif current_clothing = 1:
		$_statuses[11] = $_status[26]
	elseif current_clothing > 2:
		if tanga = 0:
			if func('zz_clothing', 'is_skirt') = 1 and shameless['flag'] = 0 :
				$_statuses[11] = $_status[27]
			else
				$_statuses[11] = $_status[28]
			end
		end
	end
	!--
	$_statuses[12] = ''
	if analplugIN = 1: $_statuses[12] += 'У вас в попу вставлена анальная пробка.<br>'
	if vibratorin = 1: $_statuses[12] += 'У вас во влагалище работает вибратор.'
	!--
	$_statuses[13] = ''
	if sick > 0:
		if sick = 1: $_statuses[13] += 'Вам что-то нехорошо, першит в горле и немного течёт из носа.<br>'
		if sick > 1 and sick < 24: $_statuses[13] += 'Вас знобит. У вас течёт из носа и саднит горло, вы покашливаете и чихаете - похоже, вы простыли.<br>'
		if sick >= 24 and sick < 48: $_statuses[13] += 'У вас поднялась температура. Вы постоянно кашляете и чихаете - похоже, вы простудились.<br>'
		if sick >= 48 and sick < 72: $_statuses[13] += 'У вас сильный жар. Может быть, это грипп.<br>'
		if sick >= 72: $_statuses[13] += 'Вы мечетесь в жару. Вы тяжело с надрывом кашляете - похоже, вы серьезно больны. Может быть, это ангина.<br>'
	end
	if crazy >= 4 and crazy < 7: $_statuses[13] += 'Вы подавлены. Надо что-то в жизни менять.'
	if crazy >= 7 and crazy <= 10: $_statuses[13] += 'У вас депрессия. До добра это не доведёт, надо к врачу.'
	if crazy > 10: $_statuses[13] += 'Ваша депрессия затянулась, еще немного - и суицид неизбежен!'
	!--
	if nerdism > 0:
		j = nerdism / 20 + 1
		if j > 5: j = 5
		if j < 2: j = 2
		$_statuses[14] = $_status[27+j]
		$_statuses_img[14] = 'books<<j-2>>'
	end
	!--
	if StrongNarkota > 20: $_statuses[15] = 'Вы под кайфом.<br>'
	if alko > 0:
		if alko < 3:
			$_statuses[15] += 'Вы немного выпивши.'
		elseif alko >= 3 and alko < 6:
			$_statuses[15] += 'Вы пьяны.'
		else
			$_statuses[15] += 'Вы в стельку пьяны.'
		end
	end
	!--
	if frost > 0:
		if frost <= 5:
			$_statuses[16] = 'Вам немного холодно.'
		elseif frost > 5 and frost <= 10:
			$_statuses[16] = 'Вы замёрзли.'
		else
			$_statuses[16] = 'Вы очень замёрзли.'
		end
	end
	!--
	$_statuses[17] = ''
	if SLomka > 0: $_statuses[17] += 'Вам очень плохо и болят все кости. У вас ломка.<br>'
	if narkday ! day and narkoman = 1: $_statuses[17] += 'Вам очень плохо и болят все кости. Срочно нужна бледная леди!'
	!--
	if boletus + bilberry >= 10:
		$_statuses_img[19] = 'basket_full'
		$_statuses[18] = 'У вас полная корзина, больше в неё ничего не влазит. В ней <b><<boletus>></b> кг грибов и <b><<bilberry>></b> кг ягод.'
	else
		$_statuses_img[19] = 'basket'
		if boletus > 0 and bilberry = 0: $_statuses[18] = 'У вас в корзинке <b><<boletus>></b> кг грибов.'
		if boletus = 0 and bilberry > 0: $_statuses[18] = 'У вас в корзинке <b><<bilberry>></b> кг ягод.'
		if boletus > 0 and bilberry > 0: $_statuses[18] = 'У вас в корзинке <b><<boletus>></b> кг грибов и <b><<bilberry>></b> кг ягод.'
	end
	!--
	if house_debt > 0: $_statuses[19] = 'У вас задолженность за квартиру <<house_debt>> рублей.'
	!--
	if school['vacation'] > 0: $_statuses[20] = $holiday
	!--
	if hour >= 8:
		if hour < 12 and week > 1 and week < 5 and workKafe = 1: $_statuses[21] = 'Вы можете выйти на рабочую смену официанткой в кафе.<br>'
		if hour < 9 and week < 5 and workSec >= 1: $_statuses[21] += 'Вам нужно на работу секретарём в проектную организацию.<br>'
		if hour <= 9 and week < 6 and PersSecWork = 1: $_statuses[21] += 'Вам нужно на работу секретаршей в "Быстроежку", не позднее 9 часов.<br>'
		if (workFabrika = 1 and week => 1 and week <= 5 and hour = 8 and age >= 18) or (workFabrika = 1 and week => 1 and week <= 5 and hour = 16 and age < 18): $_statuses[21] += 'Вaм нужно на работу швеей на фабрику Павлово.'
	end
	if young_shop_work = 1 and week < 6:
		if hour = 14: $_statuses[21] += 'В 15 часов вам надо быть на работе в магазине "Кис-Киска"'
	end
	if uber['work'] = 1:
		if uber['work_day'] ! day and week ! 3 and week ! 7:
			if hour = uber['work_week']*8-1 or hour = uber['work_week']*8:
				$_statuses[21] += 'В <<uber[''work_week'']*8>> часов вам надо быть на работе в службе такси.'
			elseif hour > uber['work_week']*8:
				uber['work_day'] = day
				uber['work_absent'] += 1
			end
		end
	end
	if workrin = 1 and week mod 2 = 0 and hour <= 8: $_statuses[21] += 'Вам надо на работу на рынок.'
	!--
	$_statuses[22] = ''
	if svidanieA = 1:
		if hour < meethour: $_statuses[22] += '<<$boyA>> будет вас ждать около вашего дома в <<meethour>> часов.'
		if hour = meethour: $_statuses[22] += '<<$boyA>> уже ждёт вас около дома.'
	end
	if day = 29 and month = 12 and age <= 17 and school['certificate'] = 0 and school['block'] < 3:
		if hour >= 5 and hour <= 14: $_statuses[22] += 'В 14 часов пройдёт школьная новогодняя вечеринка.'
	end
	if sisboyday + 1 = daystart and hour < 19:
		if ($npc['38,qwSisterBoy'] = 3 or $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 7 or ($npc['38,qwSisterBoy'] = 9 and $npc['38,qwSisterTrio'] ! 1)): $_statuses[22] += 'Вы обещали сестре не заходить в вашу комнату в 18 часов'
		if $npc['38,qwSisterTrio'] = 1: $_statuses[22] += 'Вы обещали сестре прийти в вашу комнату в 18 часов'
	end
	!--
	! вывод статусов
	! если больше 11 статусов - перекладываем на правый блок
	_status_i = 0
	_status_count = 0
	$_statuses_str = ''
	$_statuses_str2 = ''
	:loop_statuses
	if _status_i < arrsize('$_statuses'):
		if len($_statuses[_status_i]) > 0:
			if _status_count <= 10:
				$_statuses_str += '<div class="hero_statuses tip" title="'+$_statuses[_status_i]+'"><img src="images/common/icons/statuses/'+$_statuses_img[_status_i]+'.png"></div>'
			else
				$_statuses_str2 += '<div class="hero_statuses tip" title="'+$_statuses[_status_i]+'"><img src="images/common/icons/statuses/'+$_statuses_img[_status_i]+'.png"></div>'
			end
			_status_count += 1
		end
		_status_i += 1
		jump 'loop_statuses'
	end
	*p '<div id="hero_status">' + $_statuses_str + '</div>'
	if len($_statuses_str2) > 0: *p '<div id="hero_status2">' + $_statuses_str2 + '</div>'
	killvar '$_status'
	killvar '$_statuses'
	killvar '$_statuses_img'
	killvar '$_statuses_str'
	killvar '$_statuses_str2'
	killvar '_statuses_i'
	killvar '_status_count'
end