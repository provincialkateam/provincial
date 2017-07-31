$autostop_drive_bj_hj = {
	'Как только вы садитесь в машину, молча не дожидаясь приглошения начинаете расстегивать ему ширинку и достаете член.'
	dick = RAND(14,22)
	if dick >= 14 and dick < 16: $raod_text_sex = 'не очень большой'
	if dick >= 16 and dick < 18: $raod_text_sex = 'обычных размеров'
	if dick >= 18 and dick < 20: $raod_text_sex = 'довольно большой'
	if dick >= 20: $raod_text_sex = 'просто огромный'
	'Его член оказался <<$raod_text_sex>>.'
}
$autostop_drive_price = {
	cla
	'- Могу вообще бесплатно, но только если отработаешь.'
	'- Каким образом? - спрашиваете вы.'
	'- Сама знаешь, уже взрослая девочка.'
	act'Отказаться':
		cla
		'- Извините, все равно это слишком для меня.'
		act 'Далее': gt $curloc
	end
	act'Могу ротиком поработать':
		cla
		drive_sex[1] = 1
		autostop_price = 0
		'После недолгих раздумий вы отвечаете:'
		'- Хорошо, могу ротиком отработать'
		'- Давай, залазь.'
		act'Сесть в машину': dynamic $drive_sex[1]
	end
	act'Могу, но только ручками':
		cla
		drive_sex[2] = 1
		autostop_price = 0
		'После недолгих раздумий вы отвечаете:'
		'- Хорошо, но только ручками.'
		'- Это еще чего? Брезгуешь?'
		'- Нет... - не зная, что ответить выдавливаете вы.'
		'После небольших раздумий он отвечает:'
		'- Ладно, залазь.'
		act'Сесть в машину': dynamic $drive_sex[2]
	end
}
!доделать предложение интима, саму поездку, приставание в машине.
$drive_sex[1] = {
	*clr & cla
	gs 'stat'
	horny += RAND(20,30)
	guy += 1
	bj += 1
	hja += 1
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	if $road_textrand0 = 'Гадюкино':
		minut += 15
		nroad = 20
	elseif $road_textrand0 = 'Павлово':
		minut += 15
		nroad = 40
	elseif $road_textrand0 = 'Города':
		minut += 15
		nroad = 0
	end
	gs 'zz_render','Трасса М-7','pic/city/road/bj1.gif'
	dynamic $autostop_drive_bj_hj
	'Немного поработав ручками, вы привели его в стоячее положение, опустили голову и обхватили его губками.'
	'Вы принялись усердно сосать, заглатывая и лаская его язычком. Пикантность отсоса незнакомцу вас не на шутку возбудила и вы с неприкрытым удовольствием начали заглатывать его как можно глубже.'
	'Вскоре, ваши старания увенчались успехом и член начал извергаться прямо у вас во рту теплой спермой, которую вы исправно всю проглотили.'
	act'Ехать дальше': dynamic $autostop_drive
}
$drive_sex[2] = {
	*clr & cla
	gs'stat'
	horny += RAND(20,30)
	guy += 1
	hja += 1
	cumfrot += 1
	if $road_textrand0 = 'Гадюкино':
		minut += 15
		nroad = 20
	elseif $road_textrand0 = 'Павлово':
		minut+=15
		nroad = 40
	elseif $road_textrand0 = 'Города':
		minut += 15
		nroad = 0
	end
	gs 'zz_render','Трасса М-7','pic/city/road/hj1.gif'
	dynamic $autostop_drive_bj_hj
	'Немного поработав ручками, вы привели его в стоячее положение.'
	'Вы принялись усердно надрачивать его и немного мять ладошкой. Пикантность ситуации вас не на шутку возбудила и вы с неприкрытым старанием начали надрачивать ему.'
	'Вскоре, ваши старания увенчались успехом и член начал извергаться прямо на вас, попадая на одежду.'
	act'Ехать дальше': dynamic $autostop_drive
}
$autostop_drive = {
	*clr & cla
	gs'stat'
	money -= autostop_price*100
	if $road_textrand0 = 'Гадюкино':
		minut += 15
		nroad = 20
	elseif $road_textrand0 = 'Павлово':
		minut += 15
		nroad = 40
	elseif $road_textrand0 = 'Города':
		minut += 15
		nroad = 0
	end
	gs 'zz_render','Трасса М-7','pic/city/road/' + iif(truck_drive = 1,'truck_drive','drive') + RAND(1,2)
	act'Выйти из машины':gt $curloc
}
$autostop_money = {
	cla
	gs 'stat'
	autostop_price = RAND(3,6)
	gs 'zz_render','Трасса М-7','pic/city/road/' + iif(truck_drive = 1,'truck_drive','drive') + RAND(1,2)
	'<center><B>Трасса М-7</B></center>'
	if truck_drive = 1:
		'<center><img src="images/pic/city/road/truck_guy'+rand(1,3)+'.jpg" ></center>'
	elseif bandit_drive = 1:
		'<center><img src="images/pic/city/road/guy1.jpg" ></center>'
	else
		'<center><img src="images/pic/city/road/guy'+rand(1,4)+'.jpg" ></center>'
	end
	'Вы просите подвезти вас до <<$road_textrand0>>'
	'Водитель осматривает вас оценивающим взглядом и говорит:'
	if rand(0,300) <= vnesh:
		dynamic $autostop_drive_price
		exit
	else
		'<<autostop_price*100>> рублей и поехали.'
	end
	if money > autostop_price*100: act'Согласиться': dynamic $autostop_drive
	act'Отказаться':
		cla
		'- Извините, но это слишком дорого для меня - говорите вы и отходите от машины.'
		act 'Далее': gt $curloc
	end
	act 'Просить снизить цену':
		cla
		textrand = RAND(1,4)
		if textrand = 1: $road_textrand5 = '- Бли-и-ин, так дорого... а может можно как-то дешевле?'
		if textrand = 2: $road_textrand5 = '- Мужчина, я совсем на мели... Можно чуть-чуть дешевле?'
		if textrand = 3: $road_textrand5 = '- Может как-нибудь договоримся?'
		if textrand = 4: $road_textrand5 = '- Может снизите немного цену для меня?'
		'Вы кокетливо играя волосами и стреляя глазками просите снизить цену:'
		'<<$road_textrand5>>'
		'Он еще раз оценивающе вас осматривает и говорит:'
		if RAND(0,100) <= vnesh:
			dynamic $autostop_drive_price
		else
			ivrand = RAND(1,2)
			autostop_price -= ivrand
			'- Ладно, так уж и быть. Скину тебе <<ivrand*100>> рублей. За <<autostop_price*100>> довезу.'
			if money > autostop_price*100:
				act'Согласиться':
					!поездка
					dynamic $autostop_drive
				end
			end
			act'Отказаться':
				cla
				'- Извините, все равно это слишком дорого для меня.'
				act 'Далее':gt $curloc
			end
			act'Предложить ему минет':
				cla
				drive_sex[1] = 1
				autostop_price = 0
				'- А может я с вами как-то по-другому расплачусь? - говорите вы облизывая губки.'
				'- Хм... Ну давай, садись в машину тогда.'
				act'Сесть в машину':dynamic $drive_sex[1]
			end
		end
	end
}
$autostop_d = {
	*clr & cla
	gs 'stat'
	truck_drive = 0
	bandit_drive = 0
	drive_sex[1] = 0
	drive_sex[2] = 0
	textrand = RAND(1,5)
	if textrand = 1:$road_textrand1 = '- Девушка, куда путь держим?'
	if textrand = 2:$road_textrand1 = '- Эй, красавица, давай подвезу?'
	if textrand = 3:$road_textrand1 = '- Девушка, вас подвезти?'
	if textrand = 4:$road_textrand1 = '- Куда вам?'
	if textrand = 5:$road_textrand1 = '- Девушка, вы знаете как опасно одной вот так посреди трассы стоять?'
	textrand = RAND(1,5)
	if textrand = 1:$road_textrand2 = 'идеально чистая и блестящая'
	if textrand = 2:$road_textrand2 = 'грязная'
	if textrand = 3:$road_textrand2 = 'пыльная'
	if textrand = 4:$road_textrand2 = 'слегка пыльная'
	if textrand = 5:$road_textrand2 = 'очень грязная'
	textrand = RAND(1,5)
	if textrand = 1:$road_textrand3 = 'черная'
	if textrand = 2:$road_textrand3 = 'белая'
	if textrand = 3:$road_textrand3 = 'красная'
	if textrand = 4:$road_textrand3 = 'синяя'
	if textrand = 5:$road_textrand3 = 'серая'
	!фура или легковая
	'<center><B>Трасса М-7</B></center>'
	if RAND(1,2) = 1:
		!бандиты или нет
		if RAND(1,4) > 1:
			bandit_drive = 1
			'<center><img src="images/pic/city/road/guy'+RAND(2,4)+'.jpg" ></center>'
			'Возле вас остановилась <<$road_textrand3>>, <<$road_textrand2>> машина и из окна на вас выглянул мужчина:'
			if vnesh < 40:'- Женщина, вам куда?'
			if vnesh >= 40:'<<$road_textrand1>>'
		else
			'<center><img src="images/pic/city/road/guy1.jpg" ></center>'
			'Возле вас остановилась черная, тонированная машина и из окна на вас выглянули 2 похожих на бандитов мужика, одетых в кожу:'
			'- Слышь, малыха, зачаливай к нам - подвезем куда надо!'
		end
	else
		truck_drive = 1
		'<center><img src="images/pic/city/road/truck_guy'+RAND(1,3)+'.jpg" ></center>'
		'Возле вас остановилась огромная <<$road_textrand3>>, <<$road_textrand2>> фура и из окна на вас выглянул мужчина:'
		if vnesh < 40:'- Женщина, вам куда?'
		if vnesh >= 40:'<<$road_textrand1>>'
	end
}
$metka = $ARGS[0]
$loc = $CURLOC
*clr
gs 'stat'
gs 'time'
gs 'zz_render','Трасса М-7','images/pic/city/road/'+iif(snow > 0,iif(nroad = 40,'pavlovo_zima','road_zima'+RAND(1,5)),iif(nroad = 40,'pavlovo_leto','road_leto'+RAND(1,4)))
gs 'zz_render','','','<center><<nroad>> километр</center><br>Шоссе по которому летят автомобили на огромной скорости, с гулом проносятся фуры обдавая ветром.'
if nroad = 0 or nroad = 40: gs 'gadukino_event','clearing_basket'
if nroad = 0 and current_clothing > 2: act 'Идти в город': minut += 5 & gt 'nord'
if nroad = 40 and current_clothing > 2: act 'Идти в Павлово': minut += 5 & gt 'vokzalG'
if nroad < 40: act 'Идти в сторону Павлово': minut += 60 & nroad += 5 & gt $curloc
if nroad > 0: act 'Идти в сторону города': minut += 60 & nroad -= 5 & gt $curloc
if nroad > 0 and nroad < 40 and current_clothing > 2:
	act 'Голосовать в сторону Павлово':
		*clr & cla
		minut += 15
		gs 'stat'
		if rand(1,100) <= 60:
			gs 'zz_render','Трасса М-7','pic/city/road/autostop'+rand(1,3),'Вы голосуете, но машины просто проносятся мимо не обращая на вас никакого внимания.'
			act 'Далее':gt $curloc
		else
			dynamic $autostop_d
			if nroad < 20:
				act 'Попросить отвезти вас до Гадюкино':
					*clr & cla
					$road_textrand0 = 'Гадюкино'
					dynamic $autostop_money
				end
			end
			act 'Попросить отвезти вас до Павлово':
				*clr & cla
				$road_textrand0 = 'Павлово'
				dynamic $autostop_money
			end
		end
	end
	act 'Голосовать в сторону города':
		*clr & cla
		minut += 15
		gs 'stat'
		if rand(1,100) <= 60:
			gs 'zz_render','Трасса М-7','pic/city/road/autostop'+rand(1,3),'Вы голосуете но машины просто проносятся мимо не обращая на вас никакого внимания.'
			act 'Далее': gt $curloc
		else
			dynamic $autostop_d
			if nroad > 20:
				act 'Попросить отвезти вас до Гадюкино':
					*clr & cla
					$road_textrand0 = 'Гадюкино'
					dynamic $autostop_money
				end
			end
			act 'Попросить отвезти вас до Города':
				*clr & cla
				$road_textrand0 = 'Города'
				dynamic $autostop_money
			end
		end
	end
end
if nroad = 0:
	'Окраина города на которой собрались унылые полуразвалившиеся домишки среди кряжистых деревьев.'
	'У обочины стоят <a href="exec:minut += 5 & GT ''furi''">фуры</a>'
elseif nroad = 10:
	'Неподалеку от трассы находится '+iif(current_clothing > 2,'<a href="exec:_from=1 & gs''zz_train'',''train_tickets''">железнодорожный полустанок</a>','железнодорожный полустанок')+' рядом с которыми находится '+iif(current_clothing > 2,'<a href="exec:minut += 15 & GT ''dachi''">дачный кооператив</a>','дачный кооператив')+'.'
elseif nroad = 20:
	'Неподалеку от трассы находится '+iif(current_clothing > 2,'<a href="exec:_from=2 & gs''zz_train'',''train_tickets''">железнодорожный полустанок</a>','железнодорожный полустанок')+'. От полустанка ведет грунтовая дорога к <a href="exec:minut += 30 & GT ''gadukino''">деревне Гадюкино</a>'
	if current_clothing = 0:'<b>У вас не подобающий вид, для прогулки по деревне, можно пробраться <a href="exec:minut += 40 & GT ''gadukino_event'',''gadukino_back''">огородами</a>.</b>'
elseif nroad = 30:
	'Неподалеку от трассы находится '+iif(current_clothing > 2,'<a href="exec:_from=3 & gs''zz_train'',''train_tickets''">железнодорожный полустанок</a>','железнодорожный полустанок')+'.'
elseif nroad = 40:
	'Трасса упирается в старинный провинциальный городишко.'
	'У обочины стоят <a href="exec:minut += 5 & GT ''furi''">фуры</a>'
end
gs 'zz_funcs','waiting'