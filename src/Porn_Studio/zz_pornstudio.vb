! локации порностудии
! рабочий офис
$loc = $curloc
gs 'banda_events','banda_check'
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	$metka = $args[0]
	gs 'zz_funcs','colorize_day'
	gs 'stat'
	if studio['init'] = 0: gs 'zz_pornstudio_init'
	gs 'zz_render','Офис','city/north/pornstudio/office','Офис вашей студии. Отсюда вы руководите кастингом и съемками.
		Ежемесячно вы платите 10000р. за аренду + 500р. за каждое обновление помещений.
		25% прибыли вы отдаете за "крышу", еще 20% - налоги.
		10% от оставшеся суммы зачисляется вам на карту, остальное - на баланс студии.'
	if hour >= 15 and hour < 17: gs 'zz_render','','','На диване сидят <a href="exec: gt ''banda''">парни из банды</a>.'
	gs 'zz_pornstudio','navigation'
	!Условия старта ивента с маструбацией Светки
	if horny >= 50 and hour >= 10 and hour < 15: act' Поласкать себя, глядя порноролики': gt 'banda_studioQW','ofisevent1'
	!Условия старта ивента с Стасом
	if week <= 5 and horny >= 30 and studio['ofisevent9_day'] ! day and rand(1,10) = 1: gt 'banda_studioQW','ofisevent9'
	if banda['banda_sklad'] = 1 and rand(1,10) = 1:
		!Условие старта мини ивента в офисе с гримершей
		if studio['ofisevent2'] = 0: gt 'banda_studioQW','mini4'
		!Условия старта ивента с Инной и Геннадием
		if studio['inna'] = 1 and studio['ofisevent2_day'] ! day: gt 'banda_studioQW','ofisevent2'
		!Условие старта ивента с тройничком Инны
		if studio['ofisevent2'] >= 5 and studio['ofisevent3_day'] ! day: gt 'banda_studioQW','ofisevent3'
		!Условие старта мини ивента в офисе 4 и выше уровня
		gt 'banda_studioQW','mini5'
		!Условия старта ивента с Геннадием
		if week > 5 and horny >= 30 and studio['ofisevent10_day'] ! day: gt 'banda_studioQW','ofisevent10'
		!Условие старта ивента со Стасом и Геннадием
		if studio['ofisevent11_day'] ! day: gt 'banda_studioQW','ofisevent11'
	end
	if hour < 9 or hour > 18: exit
	act 'Список актрисс': gt 'zz_pornstudio_actress','actress_list'
	act 'Фильмография студии': gt 'zz_pornstudio_films','films'
	act 'Данные о студии': gt 'zz_pornstudio','studio'
	!---
	if studio['film_day'] ! day: act 'Снять фильм': gs 'zz_pornstudio_films','select_film',-1,-1
	act 'Как это работает':
		*clr & cla
		act 'Закрыть': gt 'zz_pornstudio'
		gs 'zz_render','','','Ежемесячно вы платите 10000р. за аренду + 500р. за каждое обновление помещений.
			25% прибыли вы отдаете за "крышу", еще 20% - налоги.
			10% от оставшеся суммы зачисляется вам на карту, остальное - на баланс студии.
			В день можно снять только один фильм. Качество, а, значит, и рейтинг фильма зависят от развитости инфраструктуры, но во время ремонта съемки невозможны.
			В данный момент у вас может быть максимум 5 актрисс. У каждой из них свой набор доступных жанров для съемок. За найм на работу вы должны заплатить актриссе бонус - 10000р.
			Для восстановления актриссам надо 2 дня и более в зависимости от жанра предыдущего фильма и развитости зоны отдыха.
			В лесбосценах второй актриссой всегда будет ваша героиня - в случае ее недоступности снять фильм не получится.
			Прибыль зависит от количества просмотров, реклама может помочь увеличить их, но не всякая реклама хороша - подберите правильное время и сумму. После 10 дней возможность рекламы фильма откючается.
			Ежедневно количество просмотров будет падать и со временем фильм перестанет приносить прибыль.'
	end
end
! гримерка
if $args[0] = 'dressing_room':
	*clr & cla
	$metka = $args[0]
	gs 'zz_pornstudio','navigation',$args[0]
	gs 'zz_render','Офис','city/north/pornstudio/grim','Гримерная, где артистки веселого жанра готовятся к съемкам. Здесь можно соответствующе приодеться и наложить макияж'
	!Условие старта мини ивентов в гримерной
	if hour >= 10 and hour < 18 and rand(1,10) = 1: gt 'banda_studioQW','mini2'
	!Условие старта мини ивентов в гримерной 3 и выше уровня
	if hour >= 10 and hour < 18 and banda_grim >= 4 and rand(1,10) = 1: gt 'banda_studioQW','mini3'
	!Условия старта ивента с Инной в ванной
	if banda['banda_sklad'] = 1 and studio['ofisevent3'] >= 5 and rand(1,5) = 1 and studio['ofisevent4_day'] ! day: gt 'banda_studioQW','ofisevent4'
	!Условие старта ивента в ванной
	if banda['banda_sklad'] = 1 and studio['ofisevent6'] = day: gt 'banda_studioQW','ofisevent8'
end
! съемочная площадка
if $args[0] = 'shooting_space':
	*clr & cla
	$metka = $args[0]
	gs 'zz_pornstudio','navigation',$args[0]
	gs 'zz_render','Офис','city/north/pornstudio/studia','Просторная студия с ярким освещением и удобными широкими диванами да кроватями, на которых и снимается основная часть сцен. Здесь сделан неплохой ремонт, даже не верится, что раньше это было обычным складом.'
	!Условия старта мини ивента в студии
	if hour >= 10 and hour <= 20 and rand(1,10) = 1: gt 'banda_studioQW','mini1'
end
! навигация
if $args[0] = 'navigation':
	act '<b>Уйти<b>': minut += rand(10,15) & gt 'north'
	if studio['upgrade'] > 0:
		*clr
		gs 'zz_render','','city/north/pornstudio/closed','Студия закрыта на ремонт! Открытие через <<studio[''upgrade'']>> дн.'
		exit
	end
	if $args[1] ! '' and $args[1] ! 'main': act '<font color=maroon>Офис</font>': gt 'zz_pornstudio','main'
	if $args[1] ! 'dressing_room': act '<font color=maroon>Гримерка</font>': gt 'zz_pornstudio','dressing_room'
	if $args[1] ! 'shooting_space': act '<font color=maroon>Съемочная площадка</font>': gt 'zz_pornstudio','shooting_space'
end
! описание помещений студии
if $args[0] = 'studio':
	*clr & cla
	act 'Закрыть': gt 'zz_pornstudio'
	$_studio_str = '<div class="film-info">Прибыль за текущий месяц: <b><<studio[''money_month'']>></b>р.'
	$_studio_str += '**Прибыль за прошлый месяц: <b><<studio[''money_last_month'']>></b>р.'
	$_studio_str += '**Баланс студии: <b><<studio[''money'']>></b>р.</div>'
	gs 'zz_render','','',$_studio_str
	!--
	$_studio_str = '<tr><th>Название</th><th>Состояние</th><th>...</th>'
	$_studio_name[0] = 'Съемочная площадка'
	$_studio_name[1] = 'Гримерная'
	$_studio_name[2] = 'Офис'
	$_studio_name[3] = 'Зона отдыха'
	i = 0
	:loop_studio
	if i < 4:
		$_studio_str += '<tr><td>'+$_studio_name[i]+'</td><td><img src="images/city/north/pornstudio/rating/'+(studio['room,<<i>>']*2)+'.png"></td><td>'+func('zz_pornstudio','mk_upgrade_str','<<i>>')+'</td></tr>'
		i += 1
		jump 'loop_studio'
	end
	gs 'zz_render','','','<center><table width=700 class="film-table">'+$_studio_str+'</table></center>'
	killvar '$_studio_name'
	killvar '$_studio_str'
end
! формирование ссылок для улучшения помещений студии
! $args[1] - id комнаты для улучшения
if $args[0] = 'mk_upgrade_str':
	_studio_id = val($args[1])
	_studio_price[0] = 40000
	_studio_price[1] = 20000
	_studio_price[2] = 30000
	_studio_price[3] = 50000
	_studio_upgrade_price = (studio['room,<<_studio_id>>'] + 1)*_studio_price[_studio_id]
	if studio['room,<<_studio_id>>'] < 5:
		$result = iif(studio['money'] >= _studio_upgrade_price,'<a href="exec:gt''zz_pornstudio'',''studio_upgrade'',<<_studio_id>>,<<_studio_upgrade_price>>">Улучшить (<<_studio_upgrade_price>>р.)</a>','Улучшить (<<_studio_upgrade_price>>р.)')
	else
		$result = ''
	end
	killvar '_studio_id'
	killvar '_studio_price'
	killvar '_studio_upgrade_price'
end
! ремонт студии
if $args[0] = 'studio_upgrade':
	*clr & cla
	act '<b>Уйти<b>':
		minut += rand(10,15)
		gt 'north'
	end
	studio['upgrade_room'] = args[1]
	studio['upgrade'] = 3 + studio['room,<<args[1]>>']
	_studio_upgrade_price = args[2]
	studio['money'] -= _studio_upgrade_price
	gs 'zz_render','','city/north/pornstudio/closed','Студия закрывается на <<studio[''upgrade'']>> дней на ремонт, который обойдется в <<_studio_upgrade_price>>р.'
	killvar '_studio_upgrade_price'
end
! суточные пересчеты
if $args[0] = 'update_info':
	! ремонт студийных помещений
	if studio['upgrade'] > 0:
		studio['upgrade'] -= 1
		if studio['upgrade'] = 0:
			studio['room,<<studio[''upgrade_room'']>>'] += 1
			studio['upgrade_room'] = -1
		end
	end
	! рейтинги фильмов
	gs 'zz_pornstudio_films','update_films_info'
	! рейтинги актрисс
	gs 'zz_pornstudio_actress','update_actress_info'
	! рейтинги студии
	studio['work_rating'] = studio['room,0'] * 6 + studio['room,1'] * 6 + studio['room,2'] * 3 + studio['room,3'] * 5
	studio['rating'] = (func('zz_pornstudio_films','avg_rating') + func('zz_pornstudio_actress','avg_rating'))/2
end