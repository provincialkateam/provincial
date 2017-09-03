$metka = $ARGS[0]
$loc = $CURLOC
frost = 0
lost_girl = 0
gs 'zz_render', 'Изба', 'qwest/gadukino/izba.jpg', 'Простая деревенская изба.**В маленькой комнате стоит <a href="exec:GT ''loker'',''start''">шкаф</a> и <a href="exec:GT ''bed'',''start''">кровать</a> на которой вы можете спать.**В большой комнате, посередине, стоит стол. Возле окна стоит <a href="exec: gs ''zz_common'',''watch_tv_on_sofa''">телевизор</a>, а рядом с ним древний <a href="exec:GT ''mirror'',''start''">трельяж</a> и <a href="exec: gt ''zz_books'',''custom_shelf'',0,9">книжный шкаф</a>.'
if rand(0,5) = 0: gs 'zz_render', '', '','На столе у окна возле батареи лениво валяется кот <a href="exec: gt ''grandparents_events'',''villagecat''">Бонифаций</a>.'
if hour < 6 or hour > 21:
	gs 'zz_render', '', '','В отдельных кроватях спят ваши дедушка с бабушкой.'
elseif hour = 6:
	gs 'zz_render', '', '','У печи крутится, готовя завтрак, ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+'.'
	gs 'zz_render', '', '','По комнате ходит ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+'.'
elseif hour = 7 or hour = 13 or hour = 18:
	gs 'zz_render', '', '','За столом, у окна, кушают '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','бабушка')+' и '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+'.'
elseif hour > 13 and hour < 18 and week = 7 and (month >= 5 or month <= 9):
	gs 'zz_render', '', '','На кровати отдыхает ваш дедушка.'
elseif hour > 19 and hour < 22:
	gs 'zz_render', '', '','На диване сидит ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+' и смотрит телевизор.'
elseif hour > 20 and hour < 22:
	gs 'zz_render', '', '','На диване сидят ваши '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+' и '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','бабушка')+' и смотрят телевизор.'
end
if month < 5 or month > 9 or sunWeather < 0:
	if hour > 7 and hour < 13:
		gs 'zz_render', '', '','В избе хлопочет по хозяйству ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+'. '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">Дедушка</a>','дедушка')+' занимается какими-то своими делами.'
	elseif hour > 13 and hour < 18:
		gs 'zz_render', '', '','На диване сидит и что-то вяжет ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+'. '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">Дедушка</a>','дедушка')+' смотрит телевизор.'
	end
end
if mira_guest = 1:gs 'zz_render', '', '','На диване, рядом с вами, сидит <a href="exec: gt ''Miroslava''">Мира</a>.'
gs 'stat'
gs 'zz_funcs', 'colorize_day'
act 'Выйти во двор':
	if current_clothing > 2:
		minut += 5 & gt'Gaddvor'
	else
		gs 'zz_render', '', '','<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
	end
end
act 'Есть':
	*clr & cla
	gs 'zz_kitchen_acts', 'eat'
	gs 'zz_kitchen_acts', 'drink', 'tea'
	gs 'stat'
	act 'Встать из за стола': gt $loc, $metka
end
gs 'zz_kitchen_acts', 'drink_all'
gs 'zz_kitchen_acts', 'cookie'
gs 'zz_kitchen_acts', 'fatdel'
gs 'zz_kitchen_acts', 'vitamin'
gs 'zz_kitchen_acts', 'pills'
if drybelo > 0: act 'Погладить <<drybelo>> штук высохшего белья':gt 'apartment_south_event','iron_clothes'
if boletus > 0 or bilberry > 0:
	act 'Засушить грибы и ягоды(продукты)':
		*clr & cla
		eda += boletus + bilberry
		boletus = 0
		bilberry = 0
		gs 'zz_render','Изба','images/gadukino/grandparents_house/house/dried_mushrooms.jpg','Посчитав, что вам нужны продукты, вы отправили на сушку найденые грибы и ягоды.'
		act 'Далее': gt 'Gadhouse'
	end
end
gs 'zz_common', 'fancywork'
gs 'zz_common','home_workout'
gs 'zz_family', 'father_sheduler'
if $father['location'] = $curloc:
	gs 'zz_render','','','В комнате отдыхают родители.'
	gs 'gadukino_event', 'go_home'
end
if grandmahelp > 0 and monthgrandmahelp ! month and hour >= 6 and hour < 22 and grandmaQW >= 40:
	monthgrandmahelp = month
	money += grandmahelp*50
	grandmaQW += 1
	grandpaQW += 1
	gs'stat'
	gs 'zz_render','','','Бабушка дает вам <b><<grandmahelp*50>></b> рублей.'
	grandmahelp = 0
end
! add random book to bag
if reading['in_bag'] < 0: gs 'zz_books','book2bag'
grandparentsQW = (grandmaQW + grandpaQW)/2
if gadukino_nude = 7 and hour >= 15 and hour <= 21 or gadukino_nude > 7 and hour >= 6 and hour <= 21:gt 'gadukino_event', 'gadukino_nude_end'
if onlooker_woman = 1 and hour >= 6 and hour <= 21:gt 'gadukino_event', 'gadukino_onlooker_woman'
if grandparentsQW < 10 and hour >= 6 and hour <= 21 and (week = 6 or week = 7):gt 'gadukino_event', 'gadukino_end'
if monthbabkapay = 0: gt 'grandparents_events','talk_pay'
if go_in_boletus = 1 and boletus >= grandpa_boletus and hour >= 6 and hour < 22: gt 'grandparents_events','grandpa_boletus'
if go_in_boletus_bilberry = 1 and boletus >= grandpa_boletus and bilberry >= grandpa_bilberry and hour >= 6 and hour < 22: gt 'grandparents_events','grandpa_boletus_bilberry'
if go_in_bilberry = 1 and bilberry >= grandpa_bilberry and hour >= 6 and hour < 22: gt 'grandparents_events','grandpa_bilberry'
if rand(1,5) = 1 and hour >= 9 and hour <= 19 and miraQW >= 15 and Mira_no = 0 and mira_guest = 0 and sunWeather < 0 and mira_guestday ! daystart and (mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1): gt 'grandparents_events','mira_house'
if forester = 1 and hour>= 6 and hour <= 21: gt 'grandparents_events','talk_swamp'