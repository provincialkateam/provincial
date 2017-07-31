$_img = 'images/city/south/apartment/telephone/call_'+iif(my_house = 2 and remkorr < 2,'old','new')+'.jpg'
if $ARGS[0] = 'start':
	*clr & cla
	gs'stat'
	gs 'zz_render','','images/city/south/apartment/telephone/'+iif(my_house = 2 and remkorr < 2,'old','new')+'.jpg',''
	if ring = 0:
		if hour >= 8 and hour <= 19:
			if telalla > 0:
				act 'Позвонить Алле':
					$telsob = 'Алла'
					telsob_boy = 0
					gt'telefon','objmobilaraz'
				end
			end
			if telmasha > 0:
				act 'Позвонить Маше':
					$telsob = 'Маша'
					telsob_boy = 0
					gt'telefon','objmobilaraz'
				end
			end
			if telkat > 0:
				act 'Позвонить Кате':
					$telsob = 'Катя'
					telsob_boy = 0
					gt'telefon','objmobilaraz'
				end
			end
			if bfA > 0 and svidanieA = 0:
				act 'Позвонить: <<$boyA>>':
					$telsob = $boyA
					telsob_boy = 1
					gt'telefon','objmobilaraz'
				end
			end
			!---------------------------!
			if sick > 72 and doktorday ! day:act 'Вызвать врача': gt 'telefon','polidin'
		end
		if $npc['0,qwNastya'] = 1 and week = 6 and vnesh >= 40:act 'Позвонить Насте':gt'nastja','pos4'
		if $npc['0,qwNastya'] = 2 and week ! 6 and nastjaday ! day:act 'Поболтать с Настей':gt'nastja','pos13'
		if hour >= 8 and hour <= 20 and $npc['0,qwNastya'] = 2 and week = 6 and vnesh >= 40 and nastjaday ! day:act 'На пляж с Настей':gt'nastja','pos12'
		if $npc['0,qwNastya'] = 5 and week = 6 and nastjaday ! day:act 'Пригласить Настю':gt'nastja','pos22'
		if $npc['0,qwNastya'] = 6 and nastjaday ! day:act 'Позвонить Насте':gt'nastja','pos31'
		act 'Положить трубку':
			cla
			gt'telefon','fin'
		end
	else
		if ringV = 1 and vladimirQW = 10: gt'telefon','qwloc1'
		if ringV = 1 and vladimirQW = 20: gt 'telefon','qwloc2'
		if ringV = 1 and vladimirQW = 30: gt'telefon', 'qwloc3'
		if ringA = 1: gt'telefon','boyA'
		if ringB = 1: gt'telefon','boyB'
		if ringC = 1: gt'telefon','boyC'
	end
end
if $ARGS[0] = 'qwloc1':
	*clr & cla
	ring = 0
	ringV = 0
	gs 'zz_render','',$_img,'Вы подняли трубку и мужской голос сказал:<br>- Здраствуйте <<$name>>, это Владимир. Помните мы не давно познакомились в парке?'
	act 'Здравствуйте, конечно помню':
		cla
		gs 'zz_render','','','- Здравствуйте, конечно помню, - ответили вы.<br>- Отлично! - сказал Владимир. - Мое предложение сходить в ресторан все еще в силе. Как вы на это смотрите?'
		act 'Ой, у меня много дел, я сегодня никак не могу':
			cla
			vladimirday = day
			gs 'zz_render','','','- Ой, у меня много дел, я сегдня никак не могу, - ответили вы ему.<br>- Ладно, - согласился Владимир, хотя было слышно , что он расстроился. - Тогда я позвоню вам завтра в четыре вечера.'
			act 'Повесить трубку':gt'korr'
		end
		act 'Я не против':
			cla
			vladimirQW = 15
			vladimirday = day
			gs 'zz_render','','','- Я не против, - ответили вы ему.<br>- Замечательно, - обрадовался Владимир. - Тогда приходите к ресторану в 20 часов.'
			act 'Повесить трубку':gt'korr'
		end
	end
end
if $ARGS[0] = 'qwloc2':
	*clr & cla
	ring = 0
	ringV = 0
	gs 'zz_render','',$_img,'Вы подняли трубку и мужской голос сказал:<br>- Привет <<$name[1]>>, это Владимир. Хочешь покататься на катере?'
	act 'Ой, у меня много дел, я сегодня никак не могу':
		cla
		vladimirday = day
		gs 'zz_render','','','- Ой, у меня много дел, я сегдня никак не могу, - ответили вы ему.<br>- Ладно, - согласился Владимир, хотя было слышно , что он расстроился. - Тогда я позвоню вам завтра в четыре вечера.'
		act 'Повесить трубку':gt'korr'
	end
	act 'Я не против':
		cla
		vladimirQW = 25
		vladimirday = day
		gs 'zz_render','','','- Я не против, - ответили вы ему.<br>- Замечательно, - обрадовался Владимир. - Сейчас за тобой приедет мой водитель Слава, и отвезет тебя.'
		act 'Повесить трубку':gt'korr'
	end
end
if $ARGS[0] = 'qwloc3':
	gs'stat'
	gs 'zz_render','',$_img,'Вы подняли трубку и мужской голос сказал:<br>- Привет <<$name[1]>>, это Владимир. Может сходим куда-нибудь?'
	act 'Ой, у меня много дел, я сегодня никак не могу':
		cla
		vladimirday = day
		gs 'zz_render','','','- Ой, у меня много дел, я сегдня никак не могу, - ответили вы ему.<br>- Ладно, - согласился Владимир, хотя было слышно , что он расстроился. - Тогда я позвоню вам завтра в четыре вечера.'
		act 'Повесить трубку':gt'korr'
	end
	act 'Я не против':
		cla
		vladimirQW = 35
		vladimirday = day
		gs 'zz_render','','','- Я не против, - ответили вы ему.<br>- Замечательно, - обрадовался Владимир. - Сейчас за тобой приедет мой водитель Слава, и отвезет тебя.'
		act 'Повесить трубку':gt'korr'
	end
end
if $ARGS[0] = 'objmobilaraz':
	*clr & cla
	telotvet = RAND(0,10)
	If telsob_boy = 0:
		gs 'zz_render','',$_img,' - Да, слушаю? - раздался голос из динамика.<br>- Привет <<$telsob>>! Это <<$name[1]>>, - поздоровались вы в ответ.'
		if sunWeather >= 0:
			act 'Пригласить прогуляться в парке':
				cla
				gs 'zz_render','','','- Может прогуляемся? - спросили вы.'
				if telotvet > 3:
					gs 'zz_render','','','- Хорошо, давай встретимся в парке, - ответила <<$telsob>>.'
					if current_clothing > 2:
						act 'Идти': gt 'parksvid'
					else
						msg '<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
						gt $loc, $metka
					end
				else
					gt'telefon','telotkaz'
				end
			end
		end
		act 'Пригласить в кино':
			cla
			gs 'zz_render','','','- Пойдешь со мной в кино? - спросили вы.'
			if telotvet > 3:
				gs 'zz_render','','','Хорошо, давай встретимся в кинотеатре, - ответила <<$telsob>>.'
				act 'Идти': gt'kinosvid'
			else
				gt'telefon','telotkaz'
			end
		end
		act 'Пригласить в бильярд':
			cla
			gs 'zz_render','','','Может в бильярд поиграем? - спросили вы.'
			if telotvet > 3:
				gs 'zz_render','','','- Хорошо, давай встре в бильярдной, - ответила <<$telsob>>.'
				if current_clothing > 2:
					act 'Идти':gt'billsvid'
				else
					msg'<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
					gt $loc, $metka
				end
			else
				gt'telefon','telotkaz'
			end
		end
		act 'Пригласить в кафе':
			cla
			gs 'zz_render','','','- Может посидим в кафе? - спросили вы.'
			if telotvet > 3:
				gs 'zz_render','','','- Хорошо, встретимся в кафе, - ответила <<$telsob>>.'
				if current_clothing > 2:
					act 'Идти':gt'kafesvid'
				else
					msg'<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
					gt $loc, $metka
				end
			else
				gt'telefon','telotkaz'
			end
		end
		act 'Пригласить в казино':
			cla
			gs 'zz_render','','','Может в казино сходим? - спросили вы.'
			if telotvet > 3:
				gs 'zz_render','','','- Хорошо, встретимся там, - ответила <<$telsob>>.'
				if current_clothing > 2:
					act 'Идти':gt'kazinosvid'
				else
					msg'<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
					gt $loc, $metka
				end
			else
				gt'telefon','telotkaz'
			end
		end
	else
		gs 'zz_render','',$_img,' - Да, слушаю? - раздался голос из динамика.<br>- Привет <<$telsob>>! Это <<$name[1]>>, - поздоровались вы в ответ.'
		if sunWeather >= 0:
			act 'Предложить сходить прогуляться в парке':
				cla
				gs 'zz_render','','','- Может прогуляемся? - спросили вы.'
				if telotvet > 3:
					gs 'zz_render','','','- Хорошо, давай встретимся в парке, - ответил <<$telsob>>.'
					act 'Идти': gt'parkM','start'
				else
					gt'telefon','telotkaz'
				end
			end
		end
		act 'Предложить сходить в кафе':
			cla
			gs 'zz_render','','','- Может сходим в кафе? - спросили вы.'
			if telotvet > 3:
				gs 'zz_render','','','- Хорошо, давай встретимся там, - ответил <<$telsob>>.'
				act 'Идти': gt'kafeM','start'
			else
				gt'telefon','telotkaz'
			end
		end
		act 'Предложить сходить в кино':
			cla
			gs 'zz_render','','','- Может сходим в кино? - спросили вы.'
			if telotvet > 3:
				gs 'zz_render','','','- Хорошо, я тогда буду ждать тебя там, - ответил <<$telsob>>.'
				act 'Идти': gt'kinoM','start'
			else
				gt'telefon','telotkaz'
			end
		end
	end
	act 'Повесить трубку':gt'telefon','fin'
end
if $ARGS[0] = 'boyA':
	*clr & cla
	ring = 0
	ringA = 0
	boydayA = day
	gs 'stat'
	$sveta = func('zz_funcs','get_item_string','лапуля,зайчик,котик,рыбка,<<$name[1]>>,<<$name[2]>>,<<$name[3]>>',-1)
	gs 'zz_render','',$_img,'- Привет <<$sveta>>, это <<$boyA>>, как делишки? - услышали вы голос в трубке.'
	act 'Нормально':
		cla
		gs 'zz_render','','','- Нормально, - ответили вы. - А у тебя как?<br>- Просто замечательно, вот только по тебе скучаю, - произнёс <<$boyA>>. - Может встретимся сегодня?'
		if pregtime <= dayA and pregtime >= 7 and pregtalk = 0:
			act 'Сообщить о беременности':
				cla
				pregtalk = 1
				gs 'zz_render','','','- Дорогой, ты скоро станешь папой? - сказали вы парню.'
				if pregtime <= dayA and pregtime >= 7 and pregtalk = 0:
					if harakBoyA = 0:
						if bfA >= 90:
							love = 1
							gs 'zz_render','','','- Это же замечательно!!! - воскликнул он в ответ. -  У нас скоро будет прибавление!<br>Вы начали разговор о сожительстве. <<$boyA>> сказал вам, что он в принципе, не против, но сперва он хочет вас познакомить с своими родителями.<br>Он вас предупреждает, что мама очень требовательная и строгая, что он её очень любит, и не хочет ее расстраивать. Поэтому вы должны выглядеть шикарно, только платье из бутика, ухоженные и завитые волосы, косметика в меру.<br>На ближайшей встрече, как только вы полностью будете готовы <<$boyA>> отвезет вас к своим родителям.'
							act 'Положить трубку':gt'telefon','fin'
							act 'Встретиться сегодня вечером':
								cla
								svidanieA = 1
								gs 'zz_render','','','- Можно встреться вечером, - подумав, сказали вы.<br>- Отлично! Во сколько мне подойти к твоему дому? - спросил обрадованный <<$boyA>>'
								act 'Назвать время':
									cla
									meetday = daystart
									meethour = input ("Назовите час в котором придти парню. Сейчас <<hour>> час, можно назначить только большее число")
									if meethour <= hour or meethour > 23:meethour = 20
									gs 'zz_render','','','- Давай в <<meethour>> часов, - предложили вы.<br>- Ладно, <<$sveta>> тогда до <<meethour>> часов, - ответил <<$boyA>>.'
									act 'Положить трубку':gt'telefon','fin'
								end
							end
						elseif bfA < 90:
							money += 20000
							gs 'zz_render','','','- Я пока еще не готов стать папой, - ответил <<$boyA>>. - Я дам тебе деньги на аборт. Иди и избавься от ребенка.'
							act 'Положить трубку':gt'telefon','fin'
						end
					elseif harakBoyA = 1:
						money += 20000
						gs 'zz_render','','','- Я пока еще не готов стать папой, - ответил <<$boyA>>. - Я дам тебе деньги на аборт. Иди и избавься от ребенка.'
						act 'Положить трубку':gt'telefon','fin'
					elseif harakBoyA = 2:
						bfA = 0
						pregtalk = 0
						gs 'zz_render','','','- Что? Да ты охуела! - закричал <<$boyA>>. - Где то подвернула пизду, а теперь на меня сваливаешь. Иди ты на хуй!'
						act 'Положить трубку':gt'telefon','fin'
					end
				elseif pregtime > dayA and pregtime >= 7 and pregtalk = 0:
					bfA = 0
					pregtalk = 0
					gs 'zz_render','','','- Каким нахрен папой? - воскликнул <<$boyA>>. -  Мы с тобой встречаемся меньше, чем ты беременна! Подвернула шлюха кому то, вот и иди к нему. Все! Можешь мне больше не звонить. Прощай!!!'
					act 'Положить трубку':gt'telefon','fin'
				end
			end
		end
		if week > 1 and week < 5 and workKafe = 1:
			act 'Ой, извини, я сегодня работаю':
				cla
				gs 'zz_render','','','- Ой, извини, я сегодня работаю - ответили вы.<br>- Ну ладно, позвоню завтра, - сказал <<$boyA>>, погрусневшим голосом.'
				act 'Положить трубку':gt'telefon','fin'
			end
		end
		act 'Сегодня вечером':
			cla
			bfA += 1
			svidanieA = 1
			meetday = daystart
			gs 'zz_render','','','- Можно встреться вечером, - сказали вы парню.<br>- Во сколько мне подойти к твоему дому? - спросил <<$boyA>>'
			act 'Назвать время':
				cla
				meethour = input ("Назовите час в котором придти парню. Сейчас <<hour>> час, можно назначить только большее число одной цифрой")
				if meethour <= hour or meethour > 23:meethour = 20
				gs 'zz_render','','','- Давай в <<meethour>> часов, - предложили вы.<br>- Ладно, <<$sveta>> тогда до <<meethour>> часов, - ответил <<$boyA>>.'
				act 'Положить трубку':gt'telefon','fin'
			end
		end
		act 'Я сегодня занята. Перезвони завтра':
			cla
			bfA -= 1
			if bfa <= 0:bfa = 0
			gs 'zz_render','','','- Я сегодня занята, - сказали вы парню. - Перезвони завтра.<br>'+iif(bfa <= 0,'- Блядь, ты уже заебала меня! - крикнул, в сердцах, <<$boyA>>. - Иди на хер!!!','- Ну ладно, тогда пока, - сказал <<$boyA>>, погрусневшим голосом.')
			act 'Положить трубку':gt'telefon','fin'
		end
	end
	act 'Расстаться':
		cla
		bfA = 0
		gt'telefon','fin'
	end
end
if $ARGS[0] = 'boyB':
	*clr & cla
	ring = 0
	ringB = 0
	boydayB = day
	gs'stat'
	'<<$boyB>> предлагает вам погулять.'
	act 'Расстаться':
		cla
		bfB = 0
		gt'telefon','fin'
	end
	act 'Перезвони завтра':
		cla
		bfB -= 1
		if bfB <= 0:bfB = 0 & '<<$boyB>> сказал, что он вас бросает.'
		if bfB > 0:'<<$boyB>> огорчился и положил трубку.'
		gt'telefon','fin'
	end
	act 'Сегодня вечером':
		cla
		bfB += 1
		svidanieB = 1
		'<<$boyB>> спрашивает во сколько ему подойти к вашему дому.'
		act 'Давай в 20 часов':
			cla
			'Вы тепло попрощались и разговор на этом закончился.'
			act 'Положить трубку':gt'telefon','fin'
		end
	end
end
if $ARGS[0] = 'boyC':
	*clr & cla
	ring = 0
	ringC = 0
	boydayC = day
	gs'stat'
	'<<$boyC>> предлагает вам погулять.'
	act 'Расстаться':
		cla
		bfC = 0
		gt'telefon','fin'
	end
	act 'Перезвони завтра':
		cla
		bfC -= 1
		if bfC <= 0:bfC = 0 & '<<$boyC>> сказал, что он вас бросает.'
		if bfC > 0:'<<$boyC>> огорчился и положил трубку.'
		gt'telefon','fin'
	end
	act 'Сегодня вечером':
		cla
		bfC += 1
		svidanieC = 1
		'<<$boyC>> спрашивает во сколько ему подойти к вашему дому.'
		act 'Давай в 20 часов':
			cla
			'Вы тепло попрощались и разговор на этом закончился.'
			act 'Положить трубку':gt'telefon','fin'
		end
	end
end
if $ARGS[0] = 'telotkaz':
	cla
	minut += 10
	If telsob_boy = 0:
		'<<$telsob>>: Извини я сейчас занята, давай в следующий раз.'
	else
		'<<$telsob>>: Извини я не могу, давай в другой раз.'
	end
	act 'Повесить трубку':gt'telefon','fin'
end
if $ARGS[0] = 'fin':
	cla
	gt $loc, $metka
end