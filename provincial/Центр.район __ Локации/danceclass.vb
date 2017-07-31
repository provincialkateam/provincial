clr
minut += 5
razdtumbler = 0
gs'stat'
gs 'zz_funcs', 'colorize_day'
'<center><b><font color = maroon>Танцевальный класс</font></b></center>'
'<center><img src="images/pic/danceclass.jpg"></center>'
'Современный зал с хорошим освещением и зеркалами для развития танцевальных навыков.'
act 'Современные клубные танцы':
	cla
	*clr
	minut += 120
	body['day_weight'] -= 1
	speed += RAND(1,3)
	gs 'zz_funcs', 'sport', 3
	dance += RAND(5,15)
	'<center><img src="images/pic/fit1.jpg"></center>'
	if dance < 100:'Вы обучались современным клубным танцам, которые очень популярны на дискотеках.'
	if dance >= 100:'Вы попытались почерпнуть что-то новое в современных клубных танцах, но вы все это уже прекрасно знаете.'
	act 'Уйти':gt'fit','razd'
end
act 'Стриптиз':
	cla
	*clr
	minut += 120
	body['day_weight'] -= 1
	agil += RAND(1,3)
	gs 'zz_funcs', 'sport', 4
	'<center><img src="images/pic/stripdance.jpg"></center>'
	if dance >= 100:
		stripdance += RAND(2,10)
		'Вы обучались страстно раздеваться в танце под музыку.'
		if stripdance >= 100:'Но вы не смогли научится ничему новому, все это вы уже прекрасно умеете и знаете.'
	elseif dance < 100:
		dance += RAND(5,15)
		'Стриптиз для вас слишком сложен, вы не можете выполнять танцевальные движения совмещая их с раздеванием. Учитель рекомендует вам для начала научится обыкновенным клубным танцам.'
	end
	act 'Уйти':gt'fit','razd'
end
act 'Танцы на шесте':
	cla
	*clr
	minut += 120
	body['day_weight'] -= 1
	stren += RAND(1,3)
	vital += RAND(1,3)
	gs 'zz_funcs', 'sport', 5
	'<center><img src="images/pic/poledance.jpg"></center>'
	if dance >= 100 and stripdance >= 100 and stren >= 80:
		poledance += RAND(2,5)
		'Вы обучались разным акробатическим номерам на шесте.'
		if poledance >= 100:'Но вы не смогли научится ничему новому, все это вы уже прекрасно умеете и знаете.'
	elseif dance < 100 or stripdance < 100 or stren < 80:
		'Уже на первом же упражнении вы грохнулись с шеста. Похоже этот вид танцев вам пока не по зубам'
		if stren < 80:'Учитель объяснил вам что для танцев на шесте, кроме умения танцевать, необходима еще и физическая сила.'
	end
	act 'Уйти':gt'fit','razd'
end