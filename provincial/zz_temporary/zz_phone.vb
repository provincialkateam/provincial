if $args[0] = '' or $args[0] = 'menu':
	*clr & cla
	gs 'zz_funcs','colorize_day'
	act 'Exit': gs 'zz_phone','exit'
	! check contacts
	if arrsize('$_contact') = 0: gs 'zz_phone','list'
	! make table
	$_img = 'images/common/mobile/'
	gs 'zz_phone','header'
	$_str = '<center><table bgcolor="#0094A8" width=360 border=0 cellspacing=0 cellpadding=0><tr><td colspan=3>&nbsp;</td></tr><tr><td align=center width=120><a href="exec:gs''zz_phone'',''phonebook''"><img src="'+$_img+'buttons/contacts.png"></a></td>'
	$_str += '<td align=center width=120><img src="'+$_img+'buttons/camera.png"></td>'
	$_str += '<td align=center width=120><img src="'+$_img+'buttons/photos.png"></td></tr>'
	$_str += '<tr><td align=center><a href="exec:gs''zz_phone'',''weather''"><img src="'+$_img+'buttons/weather.png"></a></td>'
	$_str += '<td align=center><a href="exec:gs''zz_phone'',''gmap''"><img src="'+$_img+'buttons/maps.png"></a></td>'
	$_str += '<td align=center><img src="'+$_img+'buttons/reminder.png"></td></tr>'
	$_str += '<tr><td align=center><img src="'+$_img+'buttons/notes.png"></td>'
	$_str += '<td align=center><a href="exec:gs''zz_phone'',''calendar''"><img src="'+$_img+'buttons/health.png"></td>'
	$_str += '<td align=center><a href="exec:gs''zz_phone'',''taxi''"><img src="'+$_img+'buttons/taxi.png"></a></td></tr>'
	$_str += '</table></center>'
	gs 'zz_render', '', '', $_str
	killvar '$_str'
end
! contact array
if $args[0] = 'list':
	_contact_i = 0
	! формируем список контактов из списка нпс
	! вначале семья - в списке постоянно
	_npc_i = 1
	:loop_contacts_list_family
	if _npc_i < npc_arrsize:
		if $npc['<<_npc_i>>,group'] = 5:
			$_contact['<<_contact_i>>,id'] = _npc_i
			$_contact['<<_contact_i>>,name'] = $npc['<<_npc_i>>,nickname']
			_contact_i += 1
		end
		_npc_i += 1
		jump 'loop_contacts_list_family'
	end
	! дальше одноклассники - если отношения >= 40
	_npc_i = 1
	:loop_contacts_list_schoolmates
	if _npc_i < npc_arrsize:
		if $npc['<<_npc_i>>,group'] <= 4 and $npc['<<_npc_i>>,relation'] >= 40:
			$_contact['<<_contact_i>>,id'] = _npc_i
			$_contact['<<_contact_i>>,name'] = iif($npc['<<_npc_i>>,nickname']!'',$npc['<<_npc_i>>,nickname'],$npc['<<_npc_i>>,name'])
			_contact_i += 1
		end
		_npc_i += 1
		jump 'loop_contacts_list_schoolmates'
	end
	! остальные нпс - если отношения >= 60
	_npc_i = 1
	:loop_contacts_list_other
	if _npc_i < npc_arrsize:
		if $npc['<<_npc_i>>,group'] >= 6 and $npc['<<_npc_i>>,relation'] >= 60:
			$_contact['<<_contact_i>>,id'] = _npc_i
			$_contact['<<_contact_i>>,name'] = iif($npc['<<_npc_i>>,nickname']!'',$npc['<<_npc_i>>,nickname'],$npc['<<_npc_i>>,name'])
			_contact_i += 1
		end
		_npc_i += 1
		jump 'loop_contacts_list_other'
	end
	! GPS-Taxi
	$_contact['<<arrsize(''$_contact'')/2>>,id'] = arrsize('$_contact')/2
	$_contact['<<arrsize(''$_contact'')/2>>,name'] = 'GPS-Taxi'
	! завершение звонка
	$_contact['<<arrsize(''$_contact'')/2>>,id'] = arrsize('$_contact')/2
	$_contact['<<arrsize(''$_contact'')/2>>,name'] = ''
	!---
	killvar '_npc_i'
	killvar '_contact_i'
	!---
end
if $args[0] = 'exit':
	gs 'zz_phone', 'clearing'
	gt $loc, $metka
end
if $args[0] = 'clearing':
	killvar '_call'
	killvar '_call_npc'
	killvar '_noanswer'
	killvar '$_str'
	killvar '$_dialogue'
	killvar '_dialogue_i'
	killvar '$_contact'
	killvar '$_img'
end
if $args[0] = 'header':
	$_str = '<center><table width=360 border=0 cellspacing=0 cellpadding=0>'
	$_str += '<tr><td colspan=3 align=center><img src="'+$_img+'samsung.png"></td></tr>'
	$_str += '<tr><td align=left width=120><font size=5>'+func('zz_funcs','make_datetime',hour,minut,':')+'</font></td>'
	$_str += '<td colspan=2 align=right><img src="'+$_img+'network.png"> <img src="'+$_img+'battery.png"></td></tr>'
	$_str += '<tr><td colspan=3 align=center><img src="'+$_img+'line.png"></td></tr></table></center>'
	gs 'zz_render','','',$_str
end
if $args[0] = 'phonebook':
	*clr & cla
	! получаем текущую страницу телефонной книги
	_phonebook_page = args[1]
	!--
	act 'Exit': gs 'zz_phone','exit'
	act 'Menu': gs 'zz_phone','menu'
	! make table
	gs 'zz_phone','header'
	!---
	! формируем список контактов - по 5 на страницу
	! вычисляем количество страниц
	_phonebook_page_count = (arrsize('$_contact')/2 - 3)/5
	! вычисляем начальную позицию счетчика
	_phonebook_i = _phonebook_page*5
	! выводим список контактов для страницы
	:loop_contacts
	if _phonebook_i < iif(_phonebook_page = _phonebook_page_count,arrsize('$_contact')/2 - 2,_phonebook_page*5 + 5):
		gs 'zz_phone','box',_phonebook_i,'<a href="exec:gs''zz_phone'',''call'',<<_phonebook_i>>"><img src="'+$_img+'contact_call.png" width=36></a>  <img src="'+$_img+'contact_sms.png" width=36>',-1
		_phonebook_i += 1
		jump 'loop_contacts'
	end
	! добавляем пагинатор
	$_str = '<br><br><center><table width=360 border=0 cellspacing=0 cellpadding=0><tr><td colspan=3 align=center>'
	if _phonebook_page = 0:
		$_str += '<img src="'+$_img+'buttons/pager_back.png"> '
	else
		$_str += '<a href="exec:gs''zz_phone'',''phonebook'',<<_phonebook_page-1>>"><img src="'+$_img+'buttons/pager_back_active.png"></a> '
	end
	if _phonebook_page = _phonebook_page_count:
		$_str += '<img src="'+$_img+'buttons/pager_next.png">'
	else
		$_str += '<a href="exec:gs''zz_phone'',''phonebook'',<<_phonebook_page+1>>"><img src="'+$_img+'buttons/pager_next_active.png"></a>'
	end
	$_str += '</td></tr></table></center>'
	gs 'zz_render','','',$_str
	! чистим переменные
	killvar '_phonebook_page'
	killvar '_phonebook_page_count'
	killvar '_phonebook_i'
end
! message/call box
! args[1] - id
! $args[2] - text
! args[3]  - padding, 0/1
! args[4]  - function - 0/1, return box content
if $args[0] = 'box':
	_box_id = args[1]
	$_box_text = $args[2]
	_box_padding = args[3]
	_box_function = args[4]
	! id = 900 - boyfriend
	! id = 901 - question icon
	$_img = 'images/common/mobile/'
	$_box += '<center><table width=360 border=0 cellspacing=0 cellpadding=0><tr><td>'
	$_box += '<table border=0 cellspacing=0 cellpadding=0>'
	$_box += '<tr bgcolor="#ffffff"><td colspan=3><font size=-3> </font></td></tr>'
	$_box += '<tr bgcolor="#ffffff"><td width='+iif(_box_padding=1,60,iif(_box_padding=-1,40,20))+'></td><td width=280>'
	$_box += '<table border=0 cellspacing=0 cellpadding=0>'
	$_box += '<tr><td width=10><img src="'+$_img+'tl.png"></td><td colspan=3 bgcolor="#eeeeee"></td><td width=10><img src="'+$_img+'tr.png"></td></tr>'
	$_box += '<tr bgcolor="#eeeeee"><td rowspan=2></td><td width=60 rowspan=2><img src='+func('zz_phone','get_box_photo')+' width=60></td><td width=10 rowspan=2></td><td width=190><b>'+iif(_id=900,$nameBoyfrend[numnpcboy],$_contact['<<_box_id>>,name'])+'</b></td><td rowspan=2></td></tr>'
	$_box += '<tr bgcolor="#eeeeee"><td width=190><font size=3><i>'+$_box_text+'</i></font></td></tr>'
	$_box += '<tr><td width=10><img src="'+$_img+'bl.png"></td><td colspan=3 bgcolor="#eeeeee"></td><td width=10><img src="'+$_img+'br.png"></td></tr>'
	$_box += '</table>'
	$_box += '</td><td></td></tr></table>'
	$_box += '</td></tr></table></center>'
	if _box_function = 1:
		$result = $_box
	else
		gs 'zz_render', '', '', $_box
	end
	killvar '$_box'
	killvar '_box_id'
	killvar '$_box_text'
	killvar '_box_padding'
	killvar '_box_function'
end
if $args[0] = 'get_box_photo':
	! hero
	if _box_id = -1: $result = func('zz_common','get_hero_face')
	! contacts
	if _box_id >= 0:
		if _box_id < 900: $result = 'images/common/npc/'+$_contact['<<_box_id>>,id']+'.jpg'
		if _box_id = 900: $result = 'images/common/npc/<<numnpcboy>>.jpg'
		if _box_id = 901: $result = 'images/common/mobile/que_icon.png'
		if _box_id = 902: $result = 'images/common/mobile/buttons/taxi.png'
		if _box_id = 903: $result = 'images/common/mobile/call_end.gif'
	end
end
if $args[0] = 'call':
	*clr & cla
	_call = args[1]
	_call_npc = $_contact['<<_call>>,id']
	! make table
	gs 'zz_phone', 'header'
	gs 'zz_render', '', $_img + 'call.gif'
	! wait
	wait rand(10,30)*100
	! clear & remake table
	*clr
	act 'Exit': gs 'zz_phone','exit'
	act 'Menu': gs 'zz_phone','menu'
	act 'Phonebook': gs 'zz_phone','phonebook'
	gs 'zz_phone', 'header'
	! ограничения звонков
	_noanswer = 0
	if hour <= 8 and hour >= 21:
		_noanswer = 1
	else
		if _call_npc <= 25 and ((week <= 5 and hour < 15) or (week >= 5 and hour < 10)): _noanswer = 1
		if _call_npc = 37 and (hour >= 18 or (week < 6 and hour < 8) or (week >= 6 and (hour < 9 or hour = 11 or hour = 12))): _noanswer = 1
		if _call_npc = 38 and (hour > 22 or (week < 6 and hour < 16) or (week >= 6 and hour < 12)): _noanswer = 1
		if _call_npc = 39 and (hour >= 18 or (week < 6 and hour < 16) or (week >= 6 and hour < 11)): _noanswer = 1
		if _call_npc = 35 and (hour >= 21 or (week >= 6 and hour < 18) or (hour >= 18 and father['in_garage'] = 0)): _noanswer = 1
		! временно глушим всех остальных нпс
		!if (_call_npc >= 25 and _call_npc <= 34) or _call_npc = 36 or _call_npc >= 40 and _call_npc < npc_arrsize: _noanswer = 1
	end
	!--
	gs 'zz_phone','dialogues',_noanswer
	killvar '_noanswer'
end
if $args[0] = 'dialogues':
	! no answer
	if args[1] = 1: gs 'zz_phone','box',_call,'Абонент не отвечает.',-1 & exit
	! mother
	if _call_npc = 37:
		! проверяем, где мать
		gs 'zz_family','mother_sheduler'
		! ---
		$_dialogue['0,que'] = 'Привет, мамуля, как дела?'
		$_dialogue['0,ans'] = iif($npc['37,relation'] < 40,'<font color=red>Что на этот раз натворила?</font>','<<$name[1]>>, что-то случилось?')
		$_dialogue['1,que'] = 'Да ничего, хотела спросить где ты?'
		if $npc['37,relation'] < 40:
			$_dialogue['1,ans'] = '<font color=red>Раз не дома - значит работаю, лишь бы вас, спиногрызов, прокормить.</font>'
		else
			if $mother['location'] = 'grinok' or $mother['location'] = 'shop':
				$_dialogue['1,ans'] = func('zz_phone','loc_name',$mother['location']) + ', за покупками пошла.'
			elseif $mother['location'] = 'glake' or $mother['location'] = 'zz_park':
				$_dialogue['1,ans'] = func('zz_phone','loc_name',$mother['location']) + ' я. Маме тоже надо отдыхать иногда.'
			elseif lcase($sister['location']) = 'gadhouse':
				$_dialogue['1,ans'] = '<<$name[1]>>, с тобой все в порядке? В дедушки с бабушкой в деревне мы.'
			else
				$_dialogue['1,ans'] = 'На работе я. Некогда мне, дома поговорим.'
			end
		end
		! дополнительный диалог, не обязателен
		if week > 5 and motherClotheMonth ! month and motherKnowWhore = 0:
			$_dialogue['2,que'] = 'А можно мне что-нибудь купить? Ну пож-а-алуйста!'
			$_dialogue['2,ans'] = 'Ох, горе ты мое, <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt '''+$mother['location']+'''">приходи</a>, только быстро.'
		end
	end
	! sister
	if _call_npc = 38:
		! проверяем, где сестра
		gs 'zz_family','sister_sheduler'
		! ---
		$_dialogue['0,que'] = 'Привет, как дела?'
		$_dialogue['0,ans'] = iif($npc['38,relation'] < 40,'<font color=red>А тебе какая разница? Чего надо?</font>','Привет, неплохо, не жалуюсь. Может, дома поболтаем?')
		$_dialogue['1,que'] = 'А где ты сейчас?'
		if $npc['38,relation'] < 40:
			$_dialogue['1,ans'] = '<font color=red>Раз ничего не надо - значит пока.</font>'
		else
			if $sister['location'] = 'reks_home':
				$_dialogue['1,ans'] = 'У Рексика мы гуляем, разве не слышно?'
			elseif $sister['location'] = 'roma_home':
				$_dialogue['1,ans'] = 'Гуляем с Ромой - то тут, то там. Тебе привет. Ладно, мне пора.'
			elseif lcase($sister['location']) = 'gadhouse':
				$_dialogue['1,ans'] = 'Странный вопрос, в деревне торчу бесполезно. Бабка зовет, пока.'
			else
				$_dialogue['1,ans'] = func('zz_phone','loc_name',$sister['location'])+', с подружками тусим. <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt'''+$sister['location']+'''">Присоединяйся.</a>'
			end
		end
		! дополнительный диалог, не обязателен
		if week = 5 and sisboyparty = 2:
			$_dialogue['2,que'] = 'Я еще успеваю на вечеринку?'
			$_dialogue['2,ans'] = 'Да, конечно, <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt ''sisterQW'',''party_pre_conditions''">приходи</a>, только быстро.'
		end
	end
	! brother
	if _call_npc = 39:
		! проверяем, где брат
		gs 'zz_family','brother_sheduler'
		! ---
		$_dialogue['0,que'] = 'Привет, как дела?'
		$_dialogue['0,ans'] = iif($npc['39,relation'] < 40,'<font color=red>А тебе какая разница? Чего надо, придурочная?</font>','Да нормально, что-то случилось или ты поболтать?')
		$_dialogue['1,que'] = 'А где ты сейчас?'
		if $npc['39,relation'] < 40:
			$_dialogue['1,ans'] = '<font color=red>Раз ничего не случилось - значит пока.</font>'
		else
			if $brother['location'] = 'misha_home':
				$_dialogue['1,ans'] = 'У Мишки, ' + iif($npc['39,qwPornoFootball'] > 0,'порнушку','фильм') + ' смотрим.'
			elseif lcase($brother['location']) = 'gadhouse':
				$_dialogue['1,ans'] = 'В деревне торчу бесполезно. Ладно, дед зовет, опять о пропавшем Пирате рассказывать будет.'
			else
				$_dialogue['1,ans'] = 'Возле школы, с пацанами, ' + iif(sunWeather >= 0 and month > 2 and month < 12,'футбол гоняем. <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt''gschool''">Приходи, если надумаешь.</a>','думаем, что делать в такую погоду-то.')
			end
		end
		! дополнительный диалог, не обязателен
		if $npc['39,qwPornoFootball'] > 0 and $brother['location'] = 'misha_home':
			$_dialogue['2,que'] = 'А мне к вам можно?'
			$_dialogue['2,ans'] = iif($npc['39,qwPornoFootball'] >= 10,'Ты еще спрашиваешь? <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt''porn_view''">Конечно ДА!</a>','Ну давай, <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt''porn_view''">приходи</a>, дорогу помнишь.')
		end
	end
	! father
	if _call_npc = 35:
		! проверяем, где отчим
		gs 'zz_family','father_sheduler'
		! ---
		$_dialogue['0,que'] = 'Привет, папочка, как дела?'
		$_dialogue['0,ans'] = iif($npc['35,relation'] < 40,'<font color=red>Что на этот раз натворила?</font>','<<$name[1]>>, что-то случилось?')
		$_dialogue['1,que'] = 'Да ничего, хотела спросить где ты?'
		if $npc['35,relation'] < 40:
			$_dialogue['1,ans'] = '<red>Раз не дома - значит работаю, лишь бы вас, спиногрызов, прокормить.</red>'
		else
			if father['in_garage'] = 1 and $father['location'] = 'gargazel':
				$_dialogue['1,ans'] = 'В гараже, как обычно, впрочем.'
			elseif lcase($father['location']) = 'gadhouse':
				$_dialogue['1,ans'] = '<<$name[1]>>, с тобой все в порядке? В Гадюкино мы.'
			else
				$_dialogue['1,ans'] = 'На работе я. Некогда мне, дома поболтаем.'
			end
		end
		! дополнительный диалог, не обязателен
		if $father['in_garage'] = 'gargazel' and father['in_garage'] = 1 and father['hadsex'] = 1:
			$_dialogue['2,que'] = 'Может, мне придти помочь папочке что-то поднять? Или спустить?'
			$_dialogue['2,ans'] = 'Ох, <<$name[2]>>, <a href="exec:minut+=10 & gs''zz_phone'',''clearing'' & gt ''gargazel''">приходи</a>, порадуй папочку.'
		end
	end
	! taxi
	if _call_npc =  arrsize('$_contact')/2 - 2:
		$_dialogue['0,que'] = 'Здравствуйте, мне б такси...'
		$_dialogue['0,ans'] = 'Здравствуйте, недалеко от Вас есть машина, будет ' + iif($control_point='nord' or $control_point='street' or $control_point='down' or $control_point='gorodok','с минуты на минуту.','минут через 20.')
		$_dialogue['1,que'] = 'Отлично, спасибо.'
		$_dialogue['1,ans'] = 'Благодарим за использование нашего приложения. Всего хорошего.'
	end
	! вывод разговора
	_dialogue_i = 0
	:loop_dialogue
	if _dialogue_i < arrsize('$_dialogue')/2:
		gs 'zz_phone','box',-1,$_dialogue['<<_dialogue_i>>,que'],0
		wait 700
		gs 'zz_phone','box', iif(_call = arrsize('$_contact')/2 - 2,902,_call),$_dialogue['<<_dialogue_i>>,ans'],1
		wait 700
		_dialogue_i += 1
		jump 'loop_dialogue'
	end
	! call end
	gs 'zz_phone','box',903,'<a href="exec:gs ''zz_phone'',''menu''">Закончить разговор</a>',-1
	killvar '$_dialogue'
	killvar '_dialogue_i'
end
if $args[0] = 'loc_name':
	if lcase($args[1]) = 'glake': $result = 'На пляже'
	if lcase($args[1]) = 'gdk': $result = 'Возле ДК'
	if lcase($args[1]) = 'cafe_parco': $result = 'В "Del Parco"'
	if lcase($args[1]) = 'grinok': $result = 'На рынке'
	if lcase($args[1]) = 'shop': $result = 'В супермаркете'
	if lcase($args[1]) = 'zz_park': $result = 'В парке'
end
if $args[0] = 'calendar':
	*clr & cla
	act 'Exit': gs 'zz_phone','exit'
	act 'Menu': gs 'zz_phone','menu'
	! make table
	gs 'zz_phone','header'
	!_count - счетчик дней в месяце
	!_i - текущий день 1 - count
	!_wday - день недели, 1-7
	!_startday - день недели, на который попадает 1-е число, 0-6
	if month = 1 or month = 3 or month = 5 or month = 7 or month = 8 or month = 10 or month = 12: _count = 31
	if month = 4 or month = 6 or month = 9 or month = 11: _count = 30
	if month = 2: _count = iif(year mod 4 = 0,29,28)
	! вычисляем, на какой день недели попадает 1-е число
	_zz_day = day mod 7
	if week = _zz_day: _startday = 0
	if week > _zz_day: _startday = week - _zz_day
	if week < _zz_day: _startday = 7 + week - _zz_day
	$_str = ''
	! если начало месяца не в пн
	if _startday ! 0:
		$_str = '<tr bgcolor="#f3f4ee">'
		_i = 0
		! добавим пустые клетки вначале
		$result = ''
		:loop_miss_days
		if _i < _startday:
			$_str += '<td></td>'
			_i += 1
			jump 'loop_miss_days'
		end
	end
	! просчитываем месячный календарь
	if mesec = 0:
		_mdays1 = day - cikl - 4
		_mdays2 = day + (24 - cikl)
	else
		_mdays1 = day - (4 - mesec)
		_mdays2 = day - (4 - mesec) + 28
	end
	_i = 1
	_wday = _startday + 1
	:loop_days
	! открываем строчку в начале недели
	if _wday = 1: $_str += '<tr bgcolor="#f3f4ee">'
	$_str += '<td width=40' + iif(_i = day,' bgcolor="#ffff00"',iif((_i >= _mdays1 and _i < _mdays1 + 4) or ((_i >= _mdays2 and _i < _mdays2 + 4)),' bgcolor="#ff0000"','')) + '>' + iif(_i = day,'<b><<_i>></b>','<<_i>>') + '</td>'
	! закрываем строчку в конце недели
	if _wday = 7:
		$_str += '</tr>'
		_wday = 1
	else
		_wday += 1
	end
	_i += 1
	if _i <= _count: jump 'loop_days'
	! дорисовываем пустые клетки в конце месяца
	_i = 0
	if _wday ! 1:
		:loop_miss_days_ender
		$_str += '<td></td>'
		_wday += 1
		if _wday <= 7: jump 'loop_miss_days_ender'
		! закрываем строчку
		$_str += '</tr>'
	end
	! формируем табличку
	$_str = '<center><font size=3><br/><br/><table align=center border=0><tr bgcolor="#f3f4ee"><td><b>Пн</b></td><td><b>Вт</b></td><td><b>Ср</b></td><td><b>Чт</b></td><td><b>Пт</b></td><td><b>Сб</b></td><td><b>Вс</b></td></tr>' + $_str + '</table></font></center>'
	gs 'zz_render','<br/><br/>Женский календарь','',$_str
	killvar '_wday'
	killvar '_startday'
	killvar '$_str'
	killvar '_zz_day'
	killvar '_i'
	killvar '_mdays1'
	killvar '_mdays2'
end
if $args[0] = 'gmap':
	*clr & cla
	! make table
	gs 'zz_phone','header'
	gs 'zz_render', '', '','<br/><br/><br/><br/><br/><br/>'
	gs 'zz_render', '', $_img + 'map_load.gif'
	! wait
	wait rand(5,15)*100
	! clear & remake table
	*clr
	act 'Exit': gs 'zz_phone','exit'
	act 'Menu': gs 'zz_phone','menu'
	gs 'zz_phone', 'header'
	$_map = ''
	if func('zz_funcs','get_item_id','bedrPar,bedrPar2,korrPar,kuhrPar,sitrPar,pod_ezd,shulgahome,shulga_room',$loc) >= 0:
		$_map = 'p_parent_home'
	elseif func('zz_funcs','get_item_id','gdk,gdkbibl,gdkin,gdkkru,gdksport,krupo,volley',$loc) >= 0:
		$_map = 'p_dk'
	elseif $loc = 'mey_home':
		$_map = 'p_meynolds_home'
	elseif $loc = 'albina_ev':
		$_map = 'p_barlovsky_home'
	elseif $loc = 'barbershop':
		$_map = 'p_barbershop'
	elseif $loc = 'cafe_parco':
		$_map = 'p_delparco'
	elseif $loc = 'gargazel':
		$_map = 'p_garage'
	elseif $loc = 'gkafe':
		$_map = 'p_cafe'
	elseif $loc = 'glake':
		$_map = 'p_beach'
	elseif func('zz_funcs','get_item_id','gLakeNude,gLakeNudeForest',$loc) >= 0:
		$_map = 'p_nude_beach'
	elseif $loc = 'gpoli':
		$_map = 'p_clinick'
	elseif func('zz_funcs','get_item_id','grinok,Gpornmark',$loc) >= 0:
		$_map = 'p_marketplace'
	elseif func('zz_funcs','get_item_id','gschool,gschool2,gschool_tualete',$loc) >= 0:
		$_map = 'p_school'
	elseif $loc = 'Gshveyfab':
		$_map = 'p_clothing_factory'
	elseif $loc = 'gskino':
		$_map = 'p_cinema'
	elseif $loc = 'zz_park':
		$_map = 'p_park'
	elseif $loc = 'hotel':
		$_map = 'p_hotel'
	elseif $loc = 'kotovdom':
		$_map = 'p_kotov_home'
	elseif $loc = 'igorhome':
		$_map = 'p_kruglov_home'
	elseif $loc = 'LariskaHome':
		$_map = 'p_gruzdeva_home'
	elseif func('zz_funcs','get_item_id','vokzalG,vokzalperG',$loc) >= 0:
		$_map = 'p_train_station'
	elseif $loc = 'gorodok':
		$_map = 'p_pavlovo'
	end
	if $_map = '':
		gs 'zz_render', '', $_img + 'map_error.png'
	else
		gs 'zz_render', 'Ваше местонахождение', $_img + '/maps/'+$_map+'.png'
	end
	killvar '$_map'
end
if $args[0] = 'weather':
	*clr
	act 'Exit': gs 'zz_phone','exit'
	act 'Menu': gs 'zz_phone','menu'
	gs 'zz_phone', 'header'
	!gs 'zz_weather'
	gs 'zz_weather','forecast'
end
if $args[0] = 'taxi':
	*clr & cla
	act 'Exit': gs 'zz_phone','exit'
	act 'Menu': gs 'zz_phone','menu'
	gs 'zz_phone', 'header'
	! время прибытия такси
	_taxi_time = hour*60 + minut + iif($control_point='nord' or $control_point='street' or $control_point='down' or $control_point='gorodok',2,20)
	! суточный переход
	if _taxi_time > 24*60: _taxi_time -= 24*60
	! в городе паркуем такси сразу после звонка
	minut += 2
	gs 'zz_phone','call',arrsize('$_contact')/2 - 2
end
if $args[0] = 'incoming_box':
	*clr & cla
	gs 'zz_funcs','colorize_day'
	$_img = 'images/common/mobile/'
	gs 'zz_phone','header'
	$_box_accept = $args[1]
	$_box_decline = $args[2]
	$_box_image = $args[3]
	$_box_text = $args[4]
	$_box = '<center><table width=240 border=0 cellspacing=0 cellpadding=0 bgcolor="#ffffff">'
	$_box += '<tr><td colspan=2>&nbsp;</td></tr>'
	$_box += '<tr><td colspan=2 align=center>'+func('zz_funcs','make_image_box',$_box_image,200)+'</td></tr>'
	$_box += '<tr><td colspan=2>&nbsp;</td></tr><tr><td colspan=2 align=center><b>'+$_box_text+'</b></td></tr><tr><td colspan=2>&nbsp;</td></tr>'
	$_box += '<tr><td align=center width=50%><a href="exec:gt''zz_phone'',''<<$_box_accept>>''">'+func('zz_funcs','make_image_box','images/common/mobile/call.gif',64)+'</a></td><td align=center width=50%><a href="exec:gt''zz_phone'',''<<$_box_decline>>''">'+func('zz_funcs','make_image_box','images/common/mobile/call_end.gif',64)+'</a></td></tr>'
	$_box += '</table></center>'
	gs 'zz_render','','',$_box
	killvar '$_img'
	killvar '$_box_accept'
	killvar '$_box_decline'
	killvar '$_box_image'
	killvar '$_box_text'
	killvar '$_box'
end
! --- boyfriend ---
if $args[0] = 'boyfriend_call_init':
	if hour >= 16 and hour < 20 and next_call_time < (hour*60 + minut):
		if Gcall = 0:
			numnpcboy = 1
			:markboyfrendcall
			if otnBoyFrend[numnpcboy] >= 20 and boyinday[numnpcboy] ! day:
				Gcall = 1
				gt 'zz_phone', 'incoming_box', 'boyfriend_call', 'boyfriend_call_decline', 'images/common/npc/<<numnpcboy>>.jpg',$nameBoyfrend[numnpcboy]
			end
			numnpcboy += 1
			if numboyFrend > numnpcboy: jump 'markboyfrendcall'
		end
	else
		if Gcall > 0: Gcall = 0
	end
end
if $args[0] = 'boyfriend_call':
	cla
	gs 'zz_funcs','colorize_day'
	$_img = 'images/common/mobile/'
	gs 'zz_phone','header'
	gs 'zz_phone','list'
	! boyfriend
	gs 'zz_phone','box',900,'Привет, <<$name[2]>>, давай сходим куда-нибудь погулять.',0
	wait 700
	gs 'zz_phone','box',-1,'Привет, <<$nameBoyfrend[numnpcboy]>>. Я даже не знаю...<br><a href="exec:gs''zz_phone'',''ans_gt_date''">Давай в парке</a><br><a href="exec:gs''zz_phone'',''ans_busy''">Сегодня занята</a><br><a href="exec:gs''zz_phone'',''ans_getoff''">Расстаться</a>',1
end
if $args[0] = 'boyfriend_call_decline':
	Gcall = 0
	next_call_time = hour*60 + minut + rand(15,30)
	gt $loc
end
if $args[0] = 'ans_gt_date':
	GvstreBoy = 1
	GvstreBoyAfter[numnpcboy] = 1
	SkverBoy = numnpcboy
	gs 'zz_phone','box',-1,'Давай встретимся в парке, возле летней площадки.',1
	wait 700
	gs 'zz_phone','box',900,'Отлично, буду <a href="exec: minut+=15 & $control_point=''gorodok'' & & gt''zz_park''">тебя там ждать.</a>',0
	wait 700
	gs 'zz_phone','box',arrsize('$_contact')/2 - 1,'<a href="exec:gt ''<<$loc>>''">Закончить разговор</a>',-1
end
if $args[0] = 'ans_busy':
	gs 'zz_phone','box',-1,'Извини, но я сегодня занята',1
	wait 700
	if boyvstre[numnpcboy] = 0: otnBoyFrend[numnpcboy] -= 10
	if boyvstre[numnpcboy] > 0: otnBoyFrend[numnpcboy] -= 5
	if otnBoyFrend[numnpcboy] > 20:
		gs 'zz_phone','box',900,'Ну, тогда как-нибудь в следующий раз...',0
	else
		otnBoyFrend[numnpcboy] = 0
		gs 'zz_phone','box',900,'Ну и пошла ты тогда к чёрту!',0
	end
	wait 700
	gs 'zz_phone','box',arrsize('$_contact')/2 - 1,'<a href="exec:gt ''<<$loc>>''">Закончить разговор</a>',-1
	Gcall = 0
	next_call_time = hour*60 + minut + rand(15,30)
end
if $args[0] = 'ans_getoff':
	otnBoyFrend[numnpcboy] = 0
	gs 'zz_phone','box',-1,'Извини, но я не хочу с тобой встречаться...',1
	wait 700
	gs 'zz_phone','box',900,'Ну и пошла ты тогда нахер, недотрога!',0
	wait 700
	gs 'zz_phone','box',arrsize('$_contact')/2 - 1,'<a href="exec:gt ''<<$loc>>''">Закончить разговор</a>',-1
	Gcall = 0
	next_call_time = hour*60 + minut + rand(15,30)
end
! ---