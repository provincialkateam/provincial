grandpaage = age + 44
*clr & cla
minut += 2
if grandpatalkday ! daystart:grandpatalk = 0
gs 'stat'
'<center><B>Дедушка</B></center>'
if $loc = 'Gadgarden':
	if month = 5 and month = 9:
		'<center><img src="images/qwest/gadukino/new/grandpa_gadgarden.jpg"></center>'
	else
		'<center><img src="images/qwest/gadukino/new/grandpa_fruit_garden.jpg"></center>'
	end
elseif $loc = 'Gaddvor':
	'<center><img src="images/qwest/gadukino/new/grandpa_gaddvor.jpg"></center>'
elseif $loc = 'Gadhouse' and (hour = 7 or hour = 13 or hour = 18):
	'<center><img src="images/qwest/gadukino/grandpa1.jpg"></center>'
elseif $loc = 'Gadsarai':
	'<center><img src="images/qwest/gadukino/new/grandpa_gadsarai.jpg"></center>'
elseif $loc = 'gadukino':
	if week = 6:
		'<center><img src="images/qwest/gadukino/new/grandpa_gadukino1.jpg"></center>'
	else
		'<center><img src="images/qwest/gadukino/new/grandpa_gadukino2.jpg"></center>'
	end
else
	'<center><img src="images/qwest/gadukino/grandpa.jpg"></center>'
end
'Ваш дедушка, всю жизнь проработавший скотником в колхозе, а после его развала - ещё и в новообразованном ООО "Скотолэнд", только недавно вышел на пенсию. У них с бабулей немалое хозяйство и много всякой живности: корова, конёк Буян, поросёнок, куры, не говоря уж про необходимых в деревне кота-мышелова и пса, охраняющего дом. За молоком, сметаной и яйцами к ним приезжают даже из города - так что старики особо не бедствуют.'
if grandpaQW < 20: 'У вас с ним ужасный скандал.'
if grandpaQW >= 20 and grandpaQW < 40: 'У вас с ним напряженные отношения.'
if grandpaQW >= 40 and grandpaQW < 60: 'У вас с ним нормальные отношения.'
if grandpaQW >= 60 and grandpaQW < 80: 'У вас с ним хорошие отношения.'
if grandpaQW >= 80: 'У вас с ним отличные отношения.'
if grandpaQW < 0:grandpaQW = 0
if grandpaQW > 100:grandpaQW = 100
if go_in_boletus = 1:'Вы обещали принести дедушке <<grandpa_boletus>> кг грибов.'
if go_in_bilberry = 1:'Вы обещали принести дедушке <<grandpa_bilberry>> кг ягод.'
if go_in_boletus_bilberry = 1:'Вы обещали принести дедушке <<grandpa_boletus>> кг грибов и <<grandpa_bilberry>> кг ягод.'
if current_clothing = 0:
	grandpa_notalk = 1
	grandpaQW -= 5
	grandmaknownude += 1
	' - <<$name>>, ты чего в таком виде разгуливаешь? Я ведь мужик, хоть и твой дед. А ну марш одеваться, пока бабка не увидела!.'
end
if cumface or cumfrot > 0:
	grandpa_notalk = 1
	grandpaQW -= 10
	if grandpaQW < 40:
		'Дед посмотрел на вас гневным взглядом. На вас была заметна сперма.'
		if grandpa_know = 0:grandpa_know = 1 & '- <<$name[1]>>, это что такое на тебе? Я думаю, что у меня внучка приличная, а она ебется где-то. Пошла отсюда, глаза б мои тебя не видели!'
		if grandpa_know = 1:'- Опять где-то трахалась блядища малолетняя? Ты бы кончину то вытерла, а то вся деревня скоро будет знать, что ты шлюха... Пошла отсюда, глаза б мои тебя не видели!'
	else
		'Дед присмотрелся к вам внимательным взглядом. На вас была заметна сперма. Он нахмурился, но промолчал, и покачав головой пошел прочь.'
	end
end
if alko > 0 and age < 20:
	if alko < 3:'Он принюхался к вам и хмыкнул. Но ничего не сказал.'
	if alko >= 3 and alko < 6:
		grandpaQW -= 1
		grandpa_notalk = 1
		'Он принюхался и внимательно глянул на вас :'
		'-<<$name[1]>>, да ты никак пьяная? Ты же еще так молодая совсем, зачем тебе это нужно? Иди приведи себя в порядок, пока бабка не увидела!'
	end
	if alko >= 6:
		grandpaQW -= 5
		grandpa_notalk = 1
		'Он глянул на вас и удивлённо приподнял брови:'
		'-<<$name>>, да ты напилась как сапожник! Иди-ка ты отдохни, пока бабка тебя, такую красивую, не увидела!'
	end
end
if grandpahelpday ! daystart and grandpa_notalk = 0 and current_clothing > 0 and grandmaknowsick = 0 and alko < 3:act 'Предложить помощь':grandpahelpday = daystart & gt'grandpahelp'
if grandpatalkforest = 0 and grandpa_notalk = 0 and current_clothing > 0 and alko < 3:
	act 'Спросить про лес':
		cla
		*clr
		grandpatalkforest = 1
		minut += 10
		manna += 5
		goforest += 1
		grandpaQW += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/grandpa.jpg"></center>'
		' - А что тут тут рассказывать внучка. Лес как лес. Большой правда. Если пойти вглубь, то без знания леса можно запросто заблудиться. Так что сначала лучше далеко не заходить, грибы с ягодами можно найти и на окраине леса. Правда не так много. В центре леса есть лесное болото, вот вокруг него можно много чего насобирать... и грибов, и ягод. Ночью по лесу вообще лучше не ходить, тут и зверь дикий напасть может, да и вообще места нехорошие.'
		' Если все таки заблудилась внучка, то по темноте лучше костер разведи, да посиди на одном месте до утра. Зверь лесной огня-то боится, близко даже не подходит.'
		' Да вот, еще... Ты в лес особо не наряжайся, попортишь всю свою красивую одежку. В лес лучше ходить в этих.... как их... в жинсах. Во!.'
		' Ну все <<$name[1]>>, беги гуляй, все что знал я рассказал.'
		act 'Закончить':gt $loc, $metka
	end
end
if hour >= grandpatalk + 3 and grandpa_notalk = 0 and current_clothing > 0 and alko < 3:
	act 'Поболтать':
		cla
		*clr
		grandpatalk = hour
		grandpatalkday = day
		minut += 10
		manna += rand(5,10)
		if grandpaQW < 60:grandpaQW += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/grandpa.jpg"></center>'
		if grandpaQW < 60:'Вы, некоторое время, болтаете со своим дедушкой, но тот ворчит вам о том, что времена давно уже не те, и настоящего русского мужика сейчас днем с огнем не сыщешь.'
		if grandpaQW >= 60:'Вы, некоторое время, весело болтаете со своим дедушкой. Он много шутит и рассказывает разные забавные случаи из своей жизни.'
		act 'Закончить':gt $loc, $metka
	end
end
act 'Уйти':
	if alko < 6 and current_clothing > 0:gt $loc, $metka
	if alko < 6 and current_clothing = 0:gt 'Gadhouse'
	if alko >= 6:$loc = 'Gadhouse' & gt 'bed', 'sleep'
end