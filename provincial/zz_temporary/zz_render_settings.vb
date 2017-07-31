! render settings
if $args[0] = 'default':
	$settings['autosave'] = 1
	$settings['status_display'] = 0
	$settings['table_width'] = '100%'
	$settings['hero_dialogue_color'] = '#000080'
	$settings['npc_dialogue_color'] = '#800000'
	$settings['header_color'] = '#800000'
	$settings['font_family'] = 'Calibri'
	$settings['image_height'] = 0
  $settings['image_render_debug'] = 0
	$settings['enable_background'] = 0
	$settings['background_color'] = '#FFFFFF'
	$settings['day_color_0'] = '#000000'
	$settings['day_color_1'] = '#404040'
	$settings['day_color_2'] = '#919191'
	$settings['day_color_3'] = '#C8C8C8'
	$settings['day_color_4'] = '#E6E6E6'
	$settings['day_color_5'] = '#FFFFFF'
	$settings['day_color_6'] = '#EEE2E2'
	$settings['day_color_7'] = '#D6BBBB'
	$settings['day_color_8'] = '#BA8C8C'
	$settings['day_color_9'] = '#604040'
	!--
	$settings['bodytype'] = 1
	$settings['body_tits'] = 1
	$settings['pubic_hair'] = 0
end
! кнопка Применить
if $args[0] = 'apply_general':
	$settings['autosave'] = $_tmp['autosave']
	$settings['status_display'] = $_tmp['status_display']
	$settings['table_width'] = $_tmp['table_width']
	$settings['header_color'] = $_tmp['header_color']
	$settings['hero_dialogue_color'] = $_tmp['hero_dialogue_color']
	$settings['npc_dialogue_color'] = $_tmp['npc_dialogue_color']
	$settings['font_family'] = $_tmp['font_family']
	$settings['image_height'] = $_tmp['image_height']
	$settings['enable_background'] = $_tmp['enable_background']
	$settings['background_color'] = $_tmp['background_color']
  $settings['image_render_debug'] = $_tmp['image_render_debug']
	i = 0
	:loop_apply_colors
	$settings['day_color_<<i>>'] = $_tmp['day_color_<<i>>']
	i += 1
	if i < 10: jump 'loop_apply_colors'
	! set background
	if $settings['enable_background'] = 1:
		BColor = func('zz_funcs','HEX2RGB',$settings['background_color'])
	else
		BColor = rgb(255,255,255)
	end
	gt 'zz_render_settings','tabs',_selected_page
end
! general settings
if $args[0] = 'tab0':
	act 'Применить': gt 'zz_render_settings','apply_general'
	! проверка настройки
	if $_tmp['autosave'] = '': $_tmp['autosave'] = $settings['autosave']
	if $_tmp['status_display'] = '': $_tmp['status_display'] = $settings['status_display']
	if $_tmp['table_width'] = '': $_tmp['table_width'] = $settings['table_width']
	if $_tmp['header_color'] = '': $_tmp['header_color'] = $settings['header_color']
	if $_tmp['hero_dialogue_color'] = '': $_tmp['hero_dialogue_color'] = $settings['hero_dialogue_color']
	if $_tmp['npc_dialogue_color'] = '': $_tmp['npc_dialogue_color'] = $settings['npc_dialogue_color']
	if $_tmp['font_family'] = '': $_tmp['font_family'] = $settings['font_family']
	if $_tmp['image_height'] = '': $_tmp['image_height'] = $settings['image_height']
	if $_tmp['enable_background'] = '': $_tmp['enable_background'] = $settings['enable_background']
	if $_tmp['background_color'] = '': $_tmp['background_color'] = $settings['background_color']
  if $_tmp['image_render_debug'] = '': $_tmp['image_render_debug'] = $settings['image_render_debug']
	i = 0
	:loop_colors
	if $_tmp['day_color_<<i>>'] = '': $_tmp['day_color_<<i>>'] = $settings['day_color_<<i>>']
	i += 1
	if i < 10: jump 'loop_colors'
	! ---
	$_str = '<center><table border=0 cellspacing=1 cellpadding=1 width=800 align=center>'
	$_str += '<tr bgcolor=#f3f4ee><td width=500 align=center><b>Параметр</b></td><td width=150 align=center><b>По умолчанию</b></td><td width=150 align=center colspan=2><b>Ваше значение</b></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Автосохранение во время сна</td><td>Включено</td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_setting'',''autosave''">'+iif($_tmp['autosave']=0,'Выключено','Включено')+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Отображение характеристик ГГ</td><td>Шкала</td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_setting'',''status_display''">'+iif($_tmp['status_display']=0,'Шкала','Текст')+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Ширина таблицы<br><font size=-1><i>(800-1200, укажите 100 для растягивания на всю ширину)</i></font></td><td>100</td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_width''">'+$_tmp['table_width']+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Цвет заголовка (названия локации)</td><td>#800000</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''header_color''">'+$_tmp['header_color']+'</a></td><td bgcolor='+$_tmp['header_color']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Цвет диалогов ГГ</td><td>#000080</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''hero_dialogue_color''">'+$_tmp['hero_dialogue_color']+'</a></td><td bgcolor='+$_tmp['hero_dialogue_color']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Цвет диалогов NPC</td><td>#800000</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''npc_dialogue_color''">'+$_tmp['npc_dialogue_color']+'</a></td><td bgcolor='+$_tmp['npc_dialogue_color']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Шрифт<br><font size=-1><i>(название семейства, например: Verdana)</i></font></td><td><font name="Calibri">Calibri</font></td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_font''"><font name="'+$_tmp['font_family']+'">'+$_tmp['font_family']+'</font></a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Высота рисунков<br><font size=-1><i>(400-600, оставьте 0 для реальных размеров)</i></font></td><td>0</td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_image_height''">'+iif(len($_tmp['image_height'])>0,$_tmp['image_height'],0)+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Показать путь изображения<br><font size=-1><i>(если хотите узнать путь до пикчи в коде)</i></font></td><td>Выключено</td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_setting'',''image_render_debug''">'+iif($_tmp['image_render_debug']=1,'Включено','Выключено')+'</a></td></tr>'
  $_str += '<tr bgcolor=#f3f4ee><td>Постоянный фон<br><font size=-1><i>(отключает смену цветов в зависимости от времени суток)</i></font></td><td>Выключено</td><td colspan=2><a href="exec:gs''zz_render_settings'',''set_setting'',''enable_background''">'+iif($_tmp['enable_background']=1,'Включено','Выключено')+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Цвет фона</td><td>#FFFFFF</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''background_color''">'+$_tmp['background_color']+'</a></td><td bgcolor='+$_tmp['background_color']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td colspan=4><b>Цветовая гамма дня</b><br><font size=-1><i>(не работает, если включен постоянный фон)</i></font></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Ночь</td><td>#000000</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_0''">'+$_tmp['day_color_0']+'</a></td><td bgcolor='+$_tmp['day_color_0']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Час до рассвета</td><td>#404040</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_1''">'+$_tmp['day_color_1']+'</a></td><td bgcolor='+$_tmp['day_color_1']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Рассвет</td><td>#919191</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_2''">'+$_tmp['day_color_2']+'</a></td><td bgcolor='+$_tmp['day_color_2']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Час поле рассвета</td><td>#C8C8C8</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_3''">'+$_tmp['day_color_3']+'</a></td><td bgcolor='+$_tmp['day_color_3']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Два часа поле рассвета</td><td>#E6E6E6</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_4''">'+$_tmp['day_color_4']+'</a></td><td bgcolor='+$_tmp['day_color_4']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>День</td><td>#FFFFFF</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_5''">'+$_tmp['day_color_5']+'</a></td><td bgcolor='+$_tmp['day_color_5']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Два часа до заката</td><td>#EEE2E2</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_6''">'+$_tmp['day_color_6']+'</a></td><td bgcolor='+$_tmp['day_color_6']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Час до заката</td><td>#D6BBBB</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_7''">'+$_tmp['day_color_7']+'</a></td><td bgcolor='+$_tmp['day_color_7']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Закат</td><td>#BA8C8C</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_8''">'+$_tmp['day_color_8']+'</a></td><td bgcolor='+$_tmp['day_color_8']+'></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Час после заката</td><td>#604040</td><td width=135><a href="exec:gs''zz_render_settings'',''set_color'',''day_color_9''">'+$_tmp['day_color_9']+'</a></td><td bgcolor='+$_tmp['day_color_9']+'></td></tr>'
	$_str += '</table></center>'
	gs 'zz_render','','',$_str
	killvar '$_str'
end
if $args[0] = 'set_width':
	_value = val(input('Укажите ширину таблицы: 800-1200, 100 для растягивания на всю ширину'))
	if _value = 0: exit
	if _value = 100:
		$_tmp['table_width'] = '100%'
	elseif _value >= 800 and _value <= 1200:
		$_tmp['table_width'] = _value
	else
		msg 'Недопустимое значение ширины таблицы!'
	end
	gt 'zz_render_settings','tabs',_selected_page
end
if $args[0] = 'set_color':
	$u_color = lcase(input('Укажите hex-код цвета:'))
	if len($u_color) = 0: exit
	if strcomp($u_color,'^#[0-9a-f]{6}$') >= 0:
		msg 'Недопустимое значение цвета!'
	else
		$_tmp[$args[1]] = $u_color
	end
	gt 'zz_render_settings','tabs',_selected_page
end
if $args[0] = 'set_font':
	$u_color = input('Укажите название семейства, например, Verdana:')
	if len($u_color) > 2: $_tmp['font_family'] = $u_color
	gt 'zz_render_settings','tabs',_selected_page
end
if $args[0] = 'set_image_height':
	_value = val(input('Укажите высоту рисунка: 400-600, оставьте 0 для реальных размеров'))
	if _value = 0:
		$_tmp['image_height'] = 0
	elseif _value >= 400 and _value <= 600:
		$_tmp['image_height'] = _value
	else
		msg 'Недопустимое значение высоты рисунка!'
	end
	gt 'zz_render_settings','tabs',_selected_page
end
if $args[0] = 'set_setting':
	$_tmp[$args[1]] = iif($_tmp[$args[1]] = 0,1,0)
	gt 'zz_render_settings','tabs',_selected_page
end
! настройка на 3 значения - 0,1,2
if $args[0] = 'set_setting_ex':
	! получаем текущее значение
	_ex_setting = val($_tmp[$args[1]])
	! проверяем границы и присваиваем новое значение
	if _ex_setting = 2:
		$_tmp[$args[1]] = 0
	else
		$_tmp[$args[1]] = _ex_setting + 1
	end
	killvar '_ex_setting'
	gt 'zz_render_settings','tabs',_selected_page
end
! общая страничка с закладками
if $args[0] = 'tabs':
	*clr & cla
	! кнопки действий
	act '<b>Закрыть</b>':
		killvar '$_tmp'
		killvar '$_str'
		killvar '$u_color'
		killvar '_value'
		killvar '_selected_page'
		gt $loc, $metka
	end
	_selected_page = args[1]
	i = 0
	$_arr[0] = 'Общие'
	$_arr[1] = 'Предпочтения'
	$_arr[2] = 'Моддинг'
	$_str = ''
	:loop_pager
	if i < arrsize('$_arr'):
		$_str += '<td width='+(800/arrsize('$_arr'))+' bgcolor='+iif(_selected_page=i,'#e6f4be','#f3f4ee')+'><br><br><b>'+ iif(_selected_page=i,$_arr[i],'<a href="exec:gt''zz_render_settings'',''tabs'',<<i>>">'+$_arr[i]+'</a>')+'</b><br></td>'
		i += 1
		jump 'loop_pager'
	end
	gs 'zz_render','Настройки','','<center><table cellpadding=0 cellspacing=1 border=0 width=800 align=center><tr>'+$_str+'</tr></table></center>'
	killvar '_arr'
	killvar '$_str'
	gs 'zz_render_settings','tab<<_selected_page>>'
end
! preferences page
if $args[0] = 'tab1':
	act 'Применить': gt 'zz_render_settings','apply_preferences'
	! проверка настройки
	if $_tmp['bodytype'] = '': $_tmp['bodytype'] = $settings['bodytype']
	if $_tmp['pubic_hair'] = '': $_tmp['pubic_hair'] = $settings['pubic_hair']
	if $_tmp['body_tits'] = '': $_tmp['body_tits'] = $settings['body_tits']
	!--
	$_str = '<center><table border=0 cellspacing=1 cellpadding=1 width=800 align=center>'
	$_str += '<tr bgcolor=#f3f4ee><td width=500 align=center><b>Параметр</b></td><td width=150 align=center><b>По умолчанию</b></td><td width=150 align=center><b>Ваше значение</b></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td colspan=3><b>Внешность</b></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Телосложение</td><td>Обычное</td><td><a href="exec:gs''zz_render_settings'',''set_setting_ex'',''bodytype''">'+func('zz_funcs','get_item_string','Худощавое,Обычное,Пышка',val($_tmp['bodytype']))+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Лобок</td><td>Бритый</td><td><a href="exec:gs''zz_render_settings'',''set_setting'',''pubic_hair''">'+iif($_tmp['pubic_hair']=0,'Бритый','Волосатый')+'</a></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Грудь</td><td>Средняя</td><td><a href="exec:gs''zz_render_settings'',''set_setting_ex'',''body_tits''">'+func('zz_funcs','get_item_string','Маленькая,Средняя,Большая',val($_tmp['body_tits']))+'</a></td></tr>'
	$_str += '</table></center>'
	gs 'zz_render','','',$_str
	killvar '$_str'
end
if $args[0] = 'apply_preferences':
	$settings['bodytype'] = $_tmp['bodytype']
	$settings['pubic_hair'] = $_tmp['pubic_hair']
	$settings['body_tits'] = $_tmp['body_tits']
	gt 'zz_render_settings','tabs',_selected_page
end
! modding page
if $args[0] = 'tab2':
	gs 'mod_init','mod_list'
end