$loc = $curloc
if $ARGS[0] = 'corridor':
	*clr & cla
	$metka = $ARGS[0]
	frost = 0
	gs 'zz_funcs', 'colorize_day'
	minut += 1
	gs 'banda_events','banda_check'
	gs 'stat'
	gs 'zz_render','Прихожая','city/north/banda/home/korr.jpg','На стене висит большое <a href="exec:GT ''mirror'',''start''">зеркало</a>'
	act 'В комнату': gt 'banda_home','room'
	act 'На кухню': gt 'banda_home','kitchen'
	act 'В ванную': gt 'banda_home','bathroom'
	!!условия для старта ивента по выбору проффесии
	!if banda['agent_zeropussy'] = 1 and week <= 5 and banda['banda_home'] = 1 and banda['banda_event15'] = 0: gt 'banda_events','banda_event15'
	!!Условия старта ивента при неудачном прохождении первого ивента вора
	!if banda['theffail'] = 1 : gt 'rb_thef','eventthef2'
	if banda['location'] = 1 and banda['stage'] < 20:
		! светка находит документы одного из бандюков
		if banda['documents'] = 0: gt 'banda_home_events','eventmini1'
		! побег светки рабыни
		if banda['escape_day'] ! day and banda['stage'] >= 6 and banda['stage'] <= 8: gt 'banda_home_events','event13'
	end
	! Самостоятельного ухода светки из квартиры
	if banda['stage'] >= 20: act '<b>Уйти</b>': gt 'north'
end
if $args[0] = '' or $args[0] = 'room':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 1
	gs 'banda_events','banda_check'
	gs 'stat'
	gs 'zz_render','Комната','city/north/banda/home/bedr.jpg','Комната в которой есть <a href="exec: gt ''bed'',''start''">кровать</a>, диван и телевизор напротив него.**На полке у телевизора валяются несколько порнографических журналов и книга.'
	gs 'zz_funcs','waiting',1
	if banda['location'] = 0: gs 'zz_render','','','На диване сидят <a href="exec: gt ''banda''">бандиты</a>'
	if banda['location'] ! 0:
		if banda['counter'] < 2 and banda['stage'] <= 10:
			if (hour = 8 or hour = 9) and banda['stage'] = 1: gt 'banda_home_events','event1'
			if (hour = 14 or hour = 15) and banda['stage'] = 2: gt 'banda_home_events','event2'
			if (hour >= 17 and hour <= 19) and banda['stage'] = 3: gt 'banda_home_events','event3'
			if hour = 21 or hour = 22:
				if banda['stage'] = 4: gt 'banda_home_events','event4'
				if banda['stage'] = 5: gt 'banda_home_events','event5'
				if banda['stage'] = 10: gt 'banda_home_events','event10'
			end
		end
	end
	! выбор "профессии"
	if banda['stage'] = 20 and banda['day'] ! day and banda['location'] = 0:
		gt 'banda_home_events','event14'
	end
	!Условие старта повторяющегося ивента
	!if hour >= 21 and hour < 23 and banda['happyend'] > 10 and rand(1,5) = 1 and banda['banda_event13'] ! day: gt 'banda_events','banda_event13'
	!Условия для старта ивента наказания Светки
	!if banda['banda_home'] = 1 and banda['madam'] = 5 and banda['eventmadam6'] = 0: gt 'rb_madam','eventmadam6'
	!Условия старта повторяющегося ивента с самантой
	!if banda['banda_home'] = 1 and rand(1,2) = 1 and banda['madam'] = 6 and banda['eventmadam7'] ! day: gt 'rb_madam','eventmadam7'
	!Условие старта второго ивента с Самантой
	!if banda['banda_home'] = 1 and rand(1,3) = 1 and banda['madam'] = 3 and madam['eventmadam3'] <= daystart: gt 'rb_madam','eventmadam4'
	!Условие старта третьего ивента с Самантой
	!if (hour >= 10 and hour < 14) or (hour >= 15 and hour < 17) and rand(1,3) = 1 and banda['madam'] = 4 and madam['eventmadam3'] <= daystart: act'Развлечься с Самантой': gt 'rb_madam','eventmadam5'
	act 'В коридор': gt 'banda_home','corridor'
end
if $ARGS[0] = 'kitchen':
	*clr & cla
	$metka = $ARGS[0]
	minut += 1
	gs 'banda_events','banda_check'
	gs 'stat'
	gs 'zz_render','Кухня','city/north/banda/home/kuhr.jpg'
	if banda['location'] = 1:
		gs 'zz_render', '','','За столом сидят <a href="exec: gt ''banda''">казаки-разбойники</a>'
		if banda['counter'] < 2 and banda['stage'] = 9:
			gt 'banda_home_events','event9'
		end
		! завершение пребывания на квартире - либо выбрасывают, либо разговор о присоединении
		if banda['stage'] = 11:
			if banda['fail'] > 3:
				banda['stage'] = 255
				gt 'banda_home_events','event11'
			else
				banda['stage'] = 20
				banda['day'] = day
				gt 'banda_home_events','event12'
			end
		end
	end
	gs 'zz_kitchen_acts', 'all'
	act 'В коридор':gt 'banda_home','corridor'
end
if $args[0] = 'bathroom':
	*clr & cla
	$metka = 'corridor'
	gs 'banda_events','banda_check'
	gs 'zz_render','Ванная','city/north/banda/home/bath.jpg','Ванная комната. Здесь вы можете принять душ или ванну.**На стене висит <a href="exec:GT ''mirror'',''start''">зеркало</a>.'
	if banda['counter'] < 2 and banda['location'] = 1:
		if banda['stage'] >= 6 and banda['stage'] <= 8: gt 'banda_home_events','event<<banda[''stage'']>>'
	end
	gt 'zz_bathroom','init','banda_home','corridor'
end