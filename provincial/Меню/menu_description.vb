! формируем табы
if $args[0] = '' or $args[0] = 'tabs':
	*clr & cla
	! кнопки действий
	act '<b>Закрыть</b>': gt $loc, $metka
	_hero_selected_page = args[1]
	i = 0
	killvar '$_arr'
	$_arr[0] = 'Персонаж'
	$_arr[1] = 'Характеристики'
	$_arr[2] = 'Репутация'
	$_arr[3] = 'Отношения'
	$_arr[4] = 'Тату/Пирсинг'
	$_arr[5] = 'Статистика'
	$_arr[6] = 'Достижения'
	$_str = ''
	:loop_pager
	if i < arrsize('$_arr'):
		$_str += '<div class="tab_header'+iif(_hero_selected_page=i,'_selected','')+'" style="width:'+(880/arrsize('$_arr')-1)+'px;">' + iif(_hero_selected_page=i,$_arr[i],'<a href="exec:gt''menu_description'',''tabs'',<<i>>">'+$_arr[i]+'</a>')+'</div>'
		i += 1
		jump 'loop_pager'
	end
	gs 'zz_render','','','<div class="tab_page">'+$_str+'</div>'
	killvar '$_arr'
	killvar '$_str'
	gs 'menu_description','tab<<_hero_selected_page>>'
	exit
end
! Описание ГГ
if $args[0] = 'tab0':
	! добавляем картинки лица, тела и т.п.
	i = 0
	killvar '$_arr'
	killvar '$_arr_path'
	$_arr[0] = 'Лицо'
	$_arr[1] = 'Одежда'
	$_arr[2] = 'Тело'
	$_arr[3] = 'Грудь'
	$_arr[4] = 'Лобок'
	$_arr[5] = 'Вагина'
	$_arr[6] = 'Анус'
	$_arr_path[0] = func('zz_common','get_face')
	$_arr_path[1] = func('zz_common','get_clothing')
	$_arr_path[2] = func('zz_common','get_body')
	$_arr_path[3] = 'images/picb/boobs/'+body['tits']+'.jpg'
	$_arr_path[4] = func('zz_common','get_pubic')
	$_arr_path[5] = func('zz_common','get_pussy')
	$_arr_path[6] = func('zz_common','get_anus')
	$_hero_images = ''
	:loop_pager_photo
	if i < arrsize('$_arr'):
		!msg $_arr_path[i]
		$_hero_images += '<div class="tab_header_small'+iif(i=0,'_selected','')+'" style="width:'+(450/arrsize('$_arr')-1)+'px;"><a href="#" onclick="javascript:getHeroImage(<<i>>,&quot;'+$_arr_path[i]+'&quot;,''hero_photo'')";>'+$_arr[i]+'</a></div>'
		i += 1
		jump 'loop_pager_photo'
	end
	killvar '$_arr_path'
	killvar '$_str'
	!-----
	! текст описания
	$_hero_text = 'Вас зовут <b><<$name>> <<$surname>></b>.'
	$_hero_text += '<br>'+'Вам <<age>> <<$letgoda>>, на вид вам можно дать не больше ' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''age'',1"><<vidage>></a>',vidage) + ' <<$letgoda2>>.'
	!if birthday > 0 and birthmonth > 0:$_str += '<br>'+'Дата вашего рождения <<birthday>>.0<<birthmonth>>.<<birthyear>>г.'
	$_hero_text += '<br>Рост '+iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''body_height'',1">'+body['height']+'</a>',body['height'])+' см, вес '+iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''body_weight'',1">'+body['weight']+'</a>',body['weight'])+' кг.'
	$_hero_text += '<br>' + $body
	$_hero_text += '<br>' + body['breast']+' - '+body['waist']+' - '+body['hips']+', размер груди '+body['tits']+'.'
	$_hero_text += '<br><<$vnesh>>'
	$_hero_text += '<br>' + $hair
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''lip'',1"><<$lip>></a>',$lip)
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''throat'',1"><<$throat>></a>',$throat)
	$_hero_text += '<br>' + $skin
	$_hero_text += '<br>' + $glaza
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''mop'',1"><<$mop>></a>',$mop)
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''leghair'',1"><<$leghair>></a>',$leghair)
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''lobok'',1"><<$lobok>></a>',$lobok)
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''vagina'',1"><<$vagina>></a>',$vagina)
	$_hero_text += '<br>' + iif($settings['cheats']=1,'<a class="cheat" href="exec:gs''zz_cheats'',''anus'',1"><<$anus>></a>',$anus)
	if curly > 0: $_hero_text += '<br>Завивки хватит еще на <<curly>> дней.'
	!-----
	$_html = '<div id="hero_description">'
		$_html += '<div id="hero_photo_container">'
			$_html += '<div id="hero_photo_tabber">'+$_hero_images+'</div>'
			$_html += '<div id="hero_photo_photo"><img src="'+func('zz_common','get_face')+'"></div>'
		$_html += '</div>'
		$_html += '<div id="hero_description_text">'+$_hero_text+'</div>'
	$_html += '</div>'
	gs 'zz_render','','','<center>'+$_html+'</center>'
	killvar '$_hero_images'
	killvar '$_hero_text'
	killvar '$_html'
end
! Характеристики
if $args[0] = 'tab1':
	$rc_param = ''
	$rc_param += func('zz_funcs', 'scale', stren, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''stren'',2">Сила</a>','Сила'))
	$rc_param += func('zz_funcs', 'scale', speed, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''speed'',2">Скорость</a>','Скорость'))
	$rc_param += func('zz_funcs', 'scale', agil, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''agil'',2">Ловкость</a>','Ловкость'))
	$rc_param += func('zz_funcs', 'scale', vital, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''vital'',2">Выносливость</a>','Выносливость'))
	$rc_param += func('zz_funcs', 'scale', intel, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''intel'',2">Интеллект</a>','Интеллект'))
	$rc_param += func('zz_funcs', 'scale', react, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''react'',2">Реакция</a>','Реакция'))
	if dom <= -10:
		if dom <= -10 and dom > -25: $_dom = 'Склонная к подчинению'
		if dom <= -25 and dom > -50: $_dom = 'Покорная'
		if dom <= -50 and dom > -75: $_dom = 'Рабыня'
		if dom <= -75: $_dom += 'На всё готовая рабыня'
	elseif dom >= 10:
		if dom >= 10 and dom < 25: $_dom = 'Склонная к доминированию'
		if dom >= 25 and dom < 50: $_dom = 'Домина'
		if dom >= 50 and dom < 75: $_dom = 'Госпожа'
		if dom >= 75: $_dom = 'Строгая госпожа'
	else
		$_dom = 'Без склонностей'
	end
	if dom < 0:
		$rc_param += func('zz_funcs', 'scale', -dom, 100,1,'Сабмиссивность: ' + iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''dom'',2"><<$_dom>></a>',$_dom))
	else
		$rc_param += func('zz_funcs', 'scale', dom, 100,0,'Доминантность: ' + iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''dom'',2"><<$_dom>></a>',$_dom))
	end
	killvar '$_dom'
	$rc_param += func('zz_funcs', 'scale', Jab, 120, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''Jab'',2">Джебы</a>','Джебы'))
	$rc_param += func('zz_funcs', 'scale', Punch, 120, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''Punch'',2">Силовые удары</a>','Силовые удары'))
	$rc_param += func('zz_funcs', 'scale', Kik, 120, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''Kik'',2">Удары ногами</a>','Удары ногами'))
	$rc_param += func('zz_funcs', 'scale', KikDef, 120, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''KikDef'',2">Защита от ударов</a>','Защита от ударов'))
	$rc_param += func('zz_funcs', 'scale', beg, 2000, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''beg'',2">Бег</a>','Бег'))
	$rc_param += func('zz_funcs', 'scale', volleyboll, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''volleyboll'',2">Волейбол</a>','Волейбол'))
	$rc_param += func('zz_funcs', 'scale', oficiant, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''oficiant'',2">Навыки официантки</a>','Навыки официантки'))
	$rc_param += func('zz_funcs', 'scale', maidstat, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''maidstat'',2">Навыки гувернантки</a>','Навыки гувернантки'))
	$rc_param += func('zz_funcs', 'scale', vokal, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''vokal'',2">Вокал</a>','Вокал'))
	$rc_param += func('zz_funcs', 'scale', dance, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''dance'',2">Танцы</a>','Танцы'))
	$rc_param += func('zz_funcs', 'scale', dancePRO, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''dancePRO'',2">Проф.танцы</a>','Проф.танцы'))
	$rc_param += func('zz_funcs', 'scale', stripdance, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''stripdance'',2">Стриптиз</a>','Стриптиз'))
	$rc_param += func('zz_funcs', 'scale', poledance, 100, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''poledance'',2">Танцы на шесте</a>','Танцы на шесте'))
	$rc_param += func('zz_funcs', 'scale', poSkill, 1000, 0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''poSkill'',2">Кройка и шитьё</a>','Кройка и шитьё'))
	if school['certificate'] = 0:
		if school['progress'] < 40:
			$_progress = 'двоечница'
		elseif school['progress'] >= 40 and school['progress'] < 70:
			$_progress = 'троечница'
		elseif school['progress'] >= 70 and school['progress'] < 90:
			$_progress = 'хорошистка'
		else
			$_progress = 'отличница'
		end
		$rc_param += func('zz_funcs', 'scale', school['progress'], 100,0, 'Успеваемость: ' + iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''progress'',2"><<$_progress>></a>',$_progress))
		$rc_param += func('zz_funcs', 'scale', school['absent'],30,1, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''absent'',2">Прогулы</a>','Прогулы'))
		killvar '$_progress'
	end
	if university['student'] > 0: $rc_param += func('zz_funcs', 'scale', university['progress'], 100,0, iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''uni_progress'',2">Уровень знаний в универе</a>','Уровень знаний в универе'))
	gs 'zz_render', '', '', '<div style="padding:20px 0 0 300px;text-align:left;font-size:0.9em;">' + $rc_param + '</div>'
	killvar '$rc_param'
end
! Репутация
if $args[0] = 'tab2':
	$_str = '<div id="reputation_box">'
	$_str += iif($settings['cheats']= 1,'<a class="cheat" href="exec:gs''zz_cheats'',''slut'',1">'+func('zz_reputation','rep_description')+'</a>',func('zz_reputation','rep_description'))
	if rinslut > 1 and kavslut > 0:$_str += '<br>В Южном районе Сити вас знают как шлюху для кавказцев'
	!if afra > 80: $_str += '<br>В студенческой общаге вы известны как подстилка для черномазых'
	if opusk > 0: $_str += '<br>В Южном районе все чёткие пацаны знают за вас, что вы опущенная хуесоска'
	if motherKnowSpravka > 0 and motherKnowWhore > 0:
		$_str += '<br>Ваша мать знает, что вы уже не девственица и считает вас шлюхой'
	elseif motherKnowWhore > 0:
		$_str += '<br>Ваша мать считает вас шлюхой'
	elseif motherKnowSpravka > 0:
		$_str += '<br>Ваша мать знает, что вы уже не девственица'
	else
		$_str += '<br>Ваша мать думает, что вы девственница'
	end
	if $npc['39,qwPornoFootball'] >= 30 and $npc['39,sex'] = 1:
		$_str += '<br>Ваш брат считает вас нимфоманкой.'
	elseif $npc['39,sex'] = 1 or ($npc['39,qwPornoFootball'] >= 16 and $npc['39,qwPornoFootball'] < 30):
		$_str += '<br>Ваш брат считает, что вы - удобная телка.'
	elseif brotherknowslut = 1:
		$_str += '<br>Ваш брат видел сперму на вашем теле и думает, что вы даете'
	elseif brotherknowslut = 2:
		$_str += '<br>Ваш брат видел как вы отсасывали гопникам'
	else
		$_str += '<br>Ваш брат о вас хорошего мнения'
	end
	if sisterknowslut > 1 and sisboypartyQW = 2:
		$_str += '<br>Ваша сестра считает вас отвязной шлюшкой'
	elseif sisterknowslut > 0:
		$_str += '<br>Ваша сестра знает, что вы даете'
	else
		$_str += '<br>Ваша сестра о вас хорошего мнения'
	end
	$_str += '</div>'
	gs 'zz_render','','',$_str
	killvar '$_str'
end
! Отношения/NPC
if $args[0] = 'tab3':
	gs 'npc_editor','relation_list'
end
! Тату/Пирсинг
if $args[0] = 'tab4':
	killvar '$_arr_path'
	! выводим блок для тату если те есть в наличии
	if tattoo['lip'] > 0:		$_arr[] = 'Губы'		&	$_arr_path[] = 'lip/' + (tattoo['lip'] - 1)
	if tattoo['shoulder'] > 0:	$_arr[] = 'Плечи'		&	$_arr_path[] = 'shoulder/' + (tattoo['shoulder'] - 1)
	if tattoo['back'] > 0:		$_arr[] = 'Спина'		&	$_arr_path[] = 'back/' + (tattoo['back'] - 1)
	if tattoo['waist'] > 0:		$_arr[] = 'Поясница'	&	$_arr_path[] = 'waist/' + (tattoo['waist'] - 1)
	if tattoo['vag'] > 0:		$_arr[] = 'Пах'			&	$_arr_path[] = 'vag/' + (tattoo['vag'] - 1)
	if tattoo['leg'] > 0:		$_arr[] = 'Ноги'		&	$_arr_path[] = 'leg/' + (tattoo['leg'] - 1)
	if arrsize('$_arr') > 0:
		i = 0
		$_tattoo_images = ''
		:loop_pager_tattoo
		if i < arrsize('$_arr'):
			$_tattoo_images += '<div class="tab_header_small'+iif(i=0,'_selected','')+'" style="width:'+(430/arrsize('$_arr')-1)+'px;"><a href="#" onclick="javascript:getHeroImage(<<i>>,&quot;images/picb/tattoo/'+$_arr_path[i]+'.jpg&quot;,''tattoo'')";>'+$_arr[i]+'</a></div>'
			i += 1
			jump 'loop_pager_tattoo'
		end
		$_tattoo = '<div id="tattoo_container">'
		$_tattoo += '<div class="tattoo_header">Тату</div>'
		$_tattoo += '<div id="tattoo_tabber">'+$_tattoo_images+'</div>'
		$_tattoo += '<div id="tattoo_photo"><img src="images/picb/tattoo/'+$_arr_path[0]+'.jpg"></div>'
		$_tattoo += '</div>'
		!gs 'zz_render','','',$_tattoo
	end
	killvar '$_arr'
	killvar '$_arr_path'
	!---
	! выводим блок для пирсинга если есть в наличии
	if pirsA = 1:	$_arr[] = 'Язык'	&	$_arr_path[] = 'pirsA'
	if pirsB = 1:	$_arr[] = 'Губы'	&	$_arr_path[] = 'pirsB'
	if pirsC = 1:	$_arr[] = 'Уши'		&	$_arr_path[] = 'pirsC'
	if pirsD = 1:	$_arr[] = 'Нос'		&	$_arr_path[] = 'pirsD'
	if pirsE = 1:	$_arr[] = 'Брови'	&	$_arr_path[] = 'pirsE'
	if pirsF = 1:	$_arr[] = 'Соски'	&	$_arr_path[] = 'pirsF'
	if pirsN = 1:	$_arr[] = 'Пупок'	&	$_arr_path[] = 'pirsN'
	if pirsG = 1 and pirsGL = 0:	$_arr[] = 'Киска'	&	$_arr_path[] = 'pirsG'
	if pirsG = 0 and pirsGL = 1:	$_arr[] = 'Клитор'	&	$_arr_path[] = 'pirsCli'
	if pirsG = 1 and pirsGL = 1:	$_arr[] = 'Киска'	&	$_arr_path[] = 'pirscligub'
	if arrsize('$_arr') > 0:
		i = 0
		$_piercing_images = ''
		:loop_pager_piercing
		if i < arrsize('$_arr'):
			$_piercing_images += '<div class="tab_header_small'+iif(i=0,'_selected','')+'" style="width:'+(430/arrsize('$_arr')-1)+'px;"><a href="#" onclick="javascript:getHeroImage(<<i>>,&quot;images/picb/piercing/'+$_arr_path[i]+'.jpg&quot;,''piercing'')";>'+$_arr[i]+'</a></div>'
			i += 1
			jump 'loop_pager_piercing'
		end
		$_piercing = '<div id="piercing_container">'
		$_piercing += '<div class="piercing_header">Пирсинг</div>'
		$_piercing += '<div id="piercing_tabber">'+$_piercing_images+'</div>'
		$_piercing += '<div id="piercing_photo"><img src="images/picb/piercing/'+$_arr_path[0]+'.jpg"></div>'
		$_piercing += '</div>'
		gs 'zz_render','','',$_tattoo + $_piercing
	end
	killvar '$_arr'
	killvar '$_arr_path'
	killvar '$_piercing'
	killvar '$_piercing_images'
	killvar '$_tattoo'
	killvar '$_tattoo_images'
end
!Статистика
if $args[0] = 'tab5':
	gs 'menu_statistics'
end
! Достижения
if $args[0] = 'tab6':
	gs 'zz_achievements','ach_page'
end