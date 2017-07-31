$metka = $ARGS[0]
$loc = $CURLOC
popolaini = 0
boycherdaksex = 0
bonusZ = 0
frost = 0
minut += 1
housrA = 1
elektro += 1
if my_house = 1:
	dirt_apartment_rent += iif(husband = 0,1,2)
else
	dirt_apartment_buy += iif(husband = 0,1,2)
end
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Коридор', 'images/city/south/apartment/korr'+iif(my_house = 1,'',iif(repairs_korr > 0,'_repairs',iif(remkorr = 0,0,iif(remkorr = 1,1,iif(remkorr = 2,2,3)))))+'.jpg', iif(my_house = 1,'Прихожая вашей съёмной квартиры. У входа висит ваша верхняя одежда и стоит полочка для обуви.',iif(repairs_korr > 0,'В прихожей идет ремонт.',iif(remkorr = 0,'В прихожей обои кое где отошли от стен и давно уже выцвели. Мебели нет, передыдущие хозяева всё вывезли.',iif(remkorr = 1,'В прихожей обои кое где отошли от стен и давно уже выцвели. У входа висит верхняя одежда и стоит полочка для обуви.',iif(remkorr = 2,'Прихожая с недорогим, но аккуратным ремонтом и мебелью.','Современная прихожая со стильной мебелью.')))))
gs 'zz_render', '', '',iif(my_house = 2 and remkorr = 0,'На полу лежит старый телефон <a href="exec:GT ''telefon'',''start''">телефон</a>','На стене висит большое <a href="exec:GT ''mirror'',''start''">зеркало</a>, рядом висит <a href="exec:GT ''telefon'',''start''">телефон</a>')
if my_house = 2 and repairs_bedr > 0: gs 'zz_render', '', '','На время ремонта в спальне <a href="exec:GT ''loker'',''start''">шкаф</a> переместился в коридор.'
if my_house = 2 and repairs_sitr > 0: gs 'zz_render', '', '', iif(komp = 1,'На полочке лежит ваш <a href="exec:GT ''Komp'',''start''">ноутбук</a>.','')
if palto > 0 and repairs_korr = 0: gs 'zz_render', '', '','На крючке висит <<$palto>>'
if my_house = 1 and dirt_apartment_rent > 25 or my_house = 2 and dirt_apartment_buy > 25:
	dirt_apartment = iif(my_house = 1,dirt_apartment_rent,dirt_apartment_buy)
	if dirt_apartment > 50:
		manna -= iif(dirt_apartment < 100,5,iif(dirt_apartment < 100,10,20))
		gs 'zz_render', '', '','<b>В квартире '+iif(dirt_apartment < 100,'заметен тонкий налёт пыли на мебели и полу',iif(dirt_apartment < 200,'грязно, на полу разводы грязи, на мебели толстый слой пыли.','так грязно, что даже одежда пачкается. В углах висит паутина, на полу грязь, пыли столько, что и мебели толком не видно, а на кухне разве, что тараканы не бегают'))+'.</b>'
		act '<b>Убираться в квартире</b>':gt 'apartment_south_event','cleaning_apartment'
	end
end
if my_house = 1 or my_house = 2 and repairs_bedr = 0:act 'В спальню': gt 'bedr'
if my_house = 1 or my_house = 2 and repairs_vanr = 0: act 'В ванную': gt 'zz_bathroom', 'start'
if my_house = 1 or my_house = 2 and repairs_kuhr = 0:act 'На кухню': gt 'kuhr'
if my_house = 1 or my_house = 2 and repairs_sitr = 0:act 'В зал': gt 'sitr'
act '<font color = maroon>В подъезд</font>':gt 'apartment_south_event','go_out'
act '<b><font color = maroon>НА УЛИЦУ</font></b>':gt 'apartment_south_event','go_out','street'
if parkday ! day and parkblackmail = 1:
	parkblackmail = 2
	parkday = day
	gs 'zz_render', '', '','Вам приходит по почте плотный конверт, раскрыв его вы видите фотографии. Черт, это фотки как вы делаете минет двум парням в парке.<br>Небольшая записка гласит:<br>Если не хочешь что бы эти фотки были расклеены по твоему подъезду и отосланы на твою работу, приходи по адресу (В адресе указана Фотостудия)<br>PS, если не придешь сегодня, завтра же фотографии будут висеть у тебя в подъезде.'
elseif parkday ! day and parkblackmail = 2:
	parkblackmail = 0
	fotoyousuck = 1
	gs 'zz_render', '', '','Черт, ваши фотки с перемазанным в сперме лицом, и с двумя хуями во рту расклеены по всему подъезду.'
end
$phone_ring = '<b><font color = red>Звонит телефон</font></b>'
$boy_no_call = '<b><font color = red>Ваш парень вам не звонит, видимо он вас бросил.</font></b>'
if vladimirQW >= 10 and vladimirday ! day and hour >= 15 and hour <= 17 and week = 6 and ring = 0 and ringV = 0:ring = 1 & ringV = 1 & '<<$phone_ring>>'
if bfA > 0 and boydayA ! day and hour >= 5 and hour < 20 and ring = 0 and ringA = 0:
	if vnesh >= vneshBoyA:
		ring = 1
		ringA = 1
		gs 'zz_render', '', '','<<$phone_ring>>'
	else
		bfA = 0
		gs 'zz_render', '', '','<<$boy_no_call>>'
	end
end
if bfA < 0: bfA = 0 & gs 'zz_render', '', '','<<$boy_no_call>>'
if bfB > 0 and boydayB ! day and hour >= 5 and hour < 20 and ring = 0 and ringB = 0:
	if vnesh >= vneshBoyB:
		ring = 1
		ringB = 1
		gs 'zz_render', '', '','<<$phone_ring>>'
	else
		bfB = 0
		gs 'zz_render', '', '','<<$boy_no_call>>'
	end
end
if bfB < 0: bfB = 0 & gs 'zz_render', '', '','<<$boy_no_call>>'
if bfC > 0 and boydayC ! day and hour >= 5 and hour < 20 and ring = 0 and ringC = 0:
	if vnesh >= vneshBoyC:
		ring = 1
		ringC = 1
		gs 'zz_render', '', '','<<$phone_ring>>'
	else
		bfC = 0
		gs 'zz_render', '', '','<<$boy_no_call>>'
	end
end
if bfC < 0: bfC = 0 & gs 'zz_render', '', '','<<$boy_no_call>>'
$door_ring = '<b><font color = red>Раздается звонок в дверь</font></b>'
if hour >= 9 and hour <= 20 and santehnikDolg > 0 and money >= santehnikDolg:
	gs 'zz_render', '', '','<<$door_ring>>'
	act 'Подойти к двери':gt 'apartment_south_event','plumber_credit_end'
end
if $npc['0,qwIvanPodstava'] = 3 and hour >= 9 and hour <= 20: gt 'apartment_south_event','Podstava_1'
if IvanPodstavaDay ! day and $npc['0,qwIvanPodstava'] = 1 and hour >= 8 and hour <= 20:
	gs 'zz_render', '', '','<<$door_ring>>'
	act 'Подойти к двери':gt 'apartment_south_event','Podstava_2'
end
if gopstop > 30: gt 'police', '1'
if rent_event_oleg_flag = 1 and hour >= 7 and hour <= 21 and day = 25 and ArendHouseSL < 10:
	gt 'rent_flat_oleg', 'rent_event_2'
end
if rent_event_oleg_flag = 1 and hour >= 7 and hour <= 21 and day = 5 and ArendHouseSL < 10 and ask_defer_pay = 1:
	if money > 10000:
		money -= 10000
		ArendHouseSL += 20
		gs 'zz_render', '', '','<red>Вы заплатили за аренду</red>'
	elseif karta > 10000:
		karta -= 10000
		ArendHouseSL += 20
		gs 'zz_render', '', '','<red>Вы заплатили за аренду</red>'
	else
		gs 'zz_render', '', '','<red>Вам нужно заплатить за аренду!</red>'
	end
	killvar 'ask_defer_pay'
end