$metka = $ARGS[0]
$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
minut += 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
act 'Выйти из комнаты': gt 'korrPar'
gs 'zz_render','Зал','pavlovo/family/apartment/sitr','У окна стоит <a href="exec: gs ''brother_events'', ''watch_tv''">телевизор</a>. Напротив телевизора находится диван, на котором по ночам спит ваш брат. У стены стоит стенка с посудой и книгами.'
gs 'zz_family', 'mother_sheduler'
if father['in_garage'] = 0: gs 'zz_family', 'father_sheduler'
gs 'zz_family', 'brother_sheduler'
if month = 1 and day >= 1 and day <= 6 and hour >= 21 and hour < 23 and brother_newyear_qw = 0 and family_trip = 0: gt 'brother_events','happy_ny',1
if $npc['38,qwKolka'] = 1 and week <=6 and hour = 6 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event2'
if $npc['38,qwKolka'] = 2 and week <=5 and hour = 16 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event3'
if $npc['38,qwKolka'] >= 3 and week <=5 and hour = 16 and rand(1,5) = 1 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event3_sub'
if $npc['38,qwKolka'] = 6 and week >=2 and week <=5 and hour = 16 and minut >= 30 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event7'
if $npc['38,qwKolka'] = 7 and family_trip = 0 and week = 7 and hour >=9 and hour <= 11 and lubri > 0 and $npc['38,qwotchim'] = 1: gt 'sisterQW','incest_event8'
if $npc['38,qwKolka'] >= 8 and week = 6 and hour = 10 and family_trip = 0 and lubri > 0 and horny > 60: gt 'sisterQW','incest_event8sub'
! если гг голой или бухой в стельку завалилась в зал
if current_clothing <= 2 or alko >= 6:
	if $mother['location'] = $curloc: *clr & gs 'mother' & exit
	if $father['location'] = $curloc: *clr & gs 'zz_father','main' & exit
end
! --
if week ! 7 and $father['location'] = $curloc and $father['location'] ! $brother['location'] and $father['location'] ! $mother['location'] and father['clean_day'] ! day and hour <= 19:
	gs 'zz_father','cleaning'
end
if month = 12 and day >= 25: gs 'zz_render','','','Возле телевизора стоит новогодняя ёлка, украшенная игрушками и гирляндами.'
if month = 12 and day = 31 and hour >= 20:
	act 'Встречать новый год с семьёй.':
		*clr & cla
		gs 'npc_editor','change_rep','+', 37, 20
		gs 'npc_editor','change_rep','+', 35, 20
		gs 'npc_editor','change_rep','+', 38, 20
		gs 'npc_editor','change_rep','+', 39, 20
		money += 5000
		body['day_weight'] += 1
		hour = 23
		minut += 120
		manna += 50
		energy += 20
		water += 20
		gs 'stat'
		gs 'zz_render','','pavlovo/family/newyear','Вы сели за праздничный стол, накрытый перед телевизором, и стали провожать Старый Год в семейном кругу под неизменные "Голубой огонёк" и "Иронию судьбы, или С легким паром!" по телевизору. За столом завязалась общая беседа, и проблемы были забыты, все веселились и разговаривали между собой. За несколько минут до полуночи, перед курантами, вы выслушали традиционные поздравления президента с не менее традиционными обещаниями, что в наступающем году обязательно станет всё лучше, если вы будете лучше трудиться. Затем выпили шампанского, чокаясь и поздравляя друг друга с новым годом. Мама вам подарила конвертик с поздравительной открыткой и пятью тысячами рублей. Какое-то время вы, продолжая смотреть телевизор, ели и пили шампанское, но вскоре стало заметно ,что члены семьи выдохлись и стали разбредаться поближе к кроватям.'
		act 'Уйти': gt $curloc
	end
elseif month = 1 and day = 1:
	act 'Доедать салаты с праздничного стола':
		*clr & cla
		gs 'zz_render','','pics/food.jpg'
		minut += 15
		cumlip = 0
		body['day_weight'] += 1
		if energy >= 50:
			gs 'zz_render','','','Вы больше не можете есть.'
		else
			gs 'zz_render','','','Вы доедали салаты, оставшиеся на столе после праздника.'
			health += 10
			manna += 20
			energy += 20
			water += 20
		end
		gs 'stat'
		act 'Встать из-за стола': gt $loc, $metka
	end
end