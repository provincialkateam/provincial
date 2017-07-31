$loc = $CURLOC
! квартира Тани, прихожая
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_render','','city/center/tanya/house.jpg',''
	act '<b>На улицу</b>':
		if current_clothing > 2:
			gt 'down'
		else
			gs 'zz_render','','','<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
		end
	end
	act 'Зал': gt $curloc,'hall'
	act 'Ваша комната': gt $curloc,'bedroom'
	act 'Комната Тани': gt $curloc,'tanya_room'
	act 'Кухня': gt $curloc,'kitchen'
	act 'Ванная': gt 'zz_bathroom', 'start'
	gs 'tanya_events','check_room'
	if hour > 8 and hour < 19 and week < 7 and tanya['clean_day'] ! day: act 'Убираться': gt 'tanya_events','clean_room'
	if week < 6 and hour >= 22:
		if tanya['punish_day'] + 14 <= daystart:
			act 'Наказать Таню': gt 'tanya_events','punish2'
		elseif tanya['punish_day'] + 7 <= daystart:
			act 'Наказать Таню': gt 'tanya_events','punish'
		end
	end
end
! кухня
if $args[0] = 'kitchen':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_render','','city/center/tanya/kitchen.jpg',iif(hour = 8 or (hour = 21 and week < 6),'На кухне хлопочет <a href="exec:gt''tanya_events'',''talk''">Таня</a>.','')
	act '<b>В прихожую</b>': gt $curloc
	gs 'zz_kitchen_acts','all'
	gs 'tanya_events','check_room'
end
! комната ГГ
if $args[0] = 'bedroom':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_render','','city/center/tanya/bedroom.jpg',''
	if komp = 1:'<a href="exec:GT ''Komp'',''start''">Ноутбук</a>.'
	! --
	act '<b>В прихожую</b>': gt $curloc
	act 'Зеркало': gt 'mirror','start'
	act 'Шкаф': gt 'loker','start'
	act 'В кровать': gt 'bed','start'
	! --
	!gs 'zz_common','course_project'
	gs 'zz_common','home_workout'
	gs 'tanya_events','check_room'
end
! комната Тани
if $args[0] = 'tanya_room':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_render','','city/center/tanya/tanya_room.jpg',''
	act '<b>В прихожую</b>': gt $curloc
	gs 'tanya_events','check_room'
	if hour < 8: gs 'zz_render','','','В кровати спит Таня.'
	if hour >= 22 and week < 6: gs 'zz_render','','','На кровати валяется <a href="exec:gt''tanya_events'',''talk''">Таня</a>, что-то бодренько печатая на клавиатуре свого ноутбука.'
end
! зал
if $args[0] = 'hall':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	gs 'zz_render','','city/center/tanya/hall.jpg',''
	act '<b>В прихожую</b>': gt $curloc
	gs $curloc,'check_room'
	if (week = 3 or week = 6) and hour >= 13 and hour <= 18:
		if week = 6 and hour >= 17:
			gs 'zz_render','','','В зале ботают Таня и ее отчим. Лучше им не мешать.'
		else
			gs 'zz_render','','','В зале читает газеты отчим Тани. Лучше ему не мешать.'
		end
	else
		if week = 7 and (hour = 17 or hour = 18): gs 'zz_render','','','На диване валяется <a href="exec:gt''tanya_events'',''talk''">Таня</a> и смотрит телик.'
		act 'Заглянуть в книжный шкаф':
			*clr & cla
			gs 'zz_books','custom_shelf',20,39
			gs 'zz_render','','','Полки в книжном шкафу забиты женскими романами и эротической литературой.'
		end
		act 'Смотреть телевизор': gt 'zz_common','watch_tv_on_sofa'
		if hour > 8 and hour < 19 and week < 7 and tanya['clean_day'] ! day: act 'Убираться': gt 'tanya_events','clean_room'
	end
end