if $ARGS[0] = 'miralick_first':
	*clr & cla
	minut += 5
	if horny < 60:
		horny = 60
	else
		horny += 10
	end
	miralick += 1
	if mirasex = 0:mirasex = 1 & girl += 1
	lesbian += 1
	gs 'stat'
	gs'time'
	if tanga = 1:
		'<center><img src="images/qwest/gadukino/new/mira_start_tanga1.jpg"></center>'
		'Опустившись на колени, Мира несмело потянулась к вашим трусам, глядя вам в глаза и робко улыбаясь. Вы, облокотившись на дерево и прикрыв глаза, стали ждать продолжения...'
	else
		'<center><img src="images/qwest/gadukino/new/mira_start_tanga0.jpg"></center>'
		'Опустившись на колени и не обнаружив на вас трусов, Мира несмело коснулась языком вашей вагине, как будто пробовала на вкус, вызвав у вас непроизвольный стон наслаждения. Вы, облокотившись на дерево и прикрыв глаза, стали ждать продолжения...'
	end
	act 'Стонать':gt 'mirasex','miralick_stand1'
end
if $ARGS[0] = 'mirakiss':
	*clr & cla
	minut += 5
	if horny < 60:horny += 5
	if mirahorny < 60:mirahorny += 5
	gs 'stat'
	'<center><img src="images/qwest/gadukino/new/mirakiss'+rand(1,4)+'.jpg"></center>'
	temp = rand(1,4)
	if temp = 1:'Вы страстно впиваетесь губами в сочные губы Миры. Она отвечает на ваш поцелуй не менее страстно, вызвав у вас стон наслождения.'
	if temp = 2:'Вы целуетесь с Мирой ощущая ее мягкие губы на своих губах и ее тонкий ловкий язычок проникающий в ваш рот.'
	if temp = 3:'Мирослава нежно целует вас в <<$liptalk3>> и вы чуствуете как возбуждение от ее поцелуя охватывает вас.'
	if temp = 4:'Мира страстно целует ваши <<$liptalk3>> и вы отвечаете взаимностью на этот поцелуй, чувствуя как возбуждение охватывает каждую частичку вашего тела.'
	''
	if horny < 20 or mirahorny < 20:
		act 'Целоваться дальше':gt 'mirasex','mirakiss'
	else
		act 'Далее':gt 'mirasex','foreplay'
	end
end
if $ARGS[0] = 'foreplay':
	*clr & cla
	minut += 5
	gs 'stat'
	if horny >= mirahorny:
		'<center><img src="images/qwest/gadukino/new/miraforeplay'+rand(1,4)+'.jpg"></center>'
		if horny < 60:horny += rand(0,5)
		mirahorny += 10
		temp = rand(1,3)
		if temp = 1:'Вы страстно целуетесь с Мирой, поглаживая лодошкой её промежность и возбуждая еще сильнее.'
		if temp = 2:'Вы целуете Миру в губы нежным поцелуем, поглаживая при этом её писю, через трусики, своей рукой..'
		if temp = 3:'Вы целуетесь с Мирославой, ваши <<$liptalk3>> соприкасаются с её губами в жарком поцелуе, а ваша ладонь на промежности заставляет её возбужденно постанывать.'
	else
		'<center><img src="images/qwest/gadukino/new/miraforeplay'+rand(5,7)+'.jpg"></center>'
		horny += 10
		temp = rand(1,3)
		if temp = 1:'Мира ласкает ваши груди <<body[''tits'']>> размера, нежно сжимая их в руках и покрывая поцелуями.'
		if temp = 2:'Вы чувствуете жаркое дыхание у себя на груди и ловкий язычок Миры, неустаноо ласкающий ваши соски и доставляющий вам огромное наслаждение.'
		if temp = 3:'Мира ласкает ваши груди, нежно сжимая их в руках, покрырывая поцелуями и играя с сосочками кончиком языка.'
	end
	''
	if horny < 40 or mirahorny < 40:
		act 'Продолжать ласки':gt 'mirasex','foreplay'
	else
		if horny >= mirahorny:
			act 'Далее':gt 'mirasex','lickmira_start'
		else
			act 'Далее':gt 'mirasex','miralick_start'
		end
	end
end
if $ARGS[0] = 'miralick_start':
	*clr & cla
	minut += 5
	horny += rand(0,5)
	miralick += 1
	lesbian += 1
	gs 'stat'
	gs'time'
	if tanga = 1:
		'<center><img src="images/qwest/gadukino/new/mira_start_tanga1.jpg"></center>'
		'Опустившись на колени, Мира потянулась к вашим трусам с улыбкой на лице, заглядывая вам в глаза. Вы, облокотившись на дерево и прикрыв глаза, стали ждать продолжения...'
	else
		'<center><img src="images/qwest/gadukino/new/mira_start_tanga0.jpg"></center>'
		'Опустившись на колени и не обнаружив на вас трусов, Мира лизнула языком вашу <<$vaginatipe2>> вагину, пробуя её вкус, вызвав у вас непроизвольный стон наслаждения. Вы, облокотившись на дерево и прикрыв глаза, стали ждать продолжения...'
	end
	''
	if tanga = 1:
		act 'Стоять на ногах':gt 'mirasex','miralick_stand2'
		act 'Стать раком':
			temp = rand(1,2)
			if temp = 1:gt 'mirasex','miralick_dog'
			if temp = 2:gt 'mirasex','mirafinger_dog'
		end
	end
	if tanga = 0:act 'Стонать':gt 'mirasex','miralick_stand2'
end
if $ARGS[0] = 'lickmira_first':
	*clr & cla
	minut += 5
	mirahorny += rand(0,5)
	if mirasex = 0:mirasex = 1 & girl += 1
	lickmira += 1
	lesbian += 1
	gs 'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/new/lickmira_start.jpg"></center>'
	if lesbian < 10:
		'Опустившись на колени, вы осторожно прикоснулись к трусам Миры и принялись неловко их стягивать с неё. Она, сгорая от возбуждения, приподняла попку с камня, решив помочь вам и убыстряя процесс...'
	else
		'Опустившись на колени, вы потянулись к трусам Миры и принялись привычным движением их стягивать с неё. Она, сгорая от возбуждения, приподняла попку с камня, решив помочь вам и убыстряя процесс...'
	end
	act 'Лизать':gt 'mirasex','lickmira_mis1'
end
if $ARGS[0] = 'lickmira_start':
	*clr & cla
	minut += 5
	mirahorny += rand(0,5)
	if mirasex = 0:mirasex = 1 & girl += 1
	lesbian += 1
	gs 'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/new/lickmira_start.jpg"></center>'
	if lesbian < 10:
		'Опустившись на колени, вы осторожно прикоснулись к трусам Миры и принялись неловко их стягивать с неё. Она, сгорая от возбуждения, приподняла попку с камня, решив помочь вам и убыстряя процесс...'
	else
		'Опустившись на колени, вы потянулись к трусам Миры и принялись привычным движением их стягивать с неё. Она, сгорая от возбуждения, приподняла попку с камня, решив помочь вам и убыстряя процесс...'
	end
	act 'Лизать':gt 'mirasex','lickmira_mis2'
end
if $ARGS[0] = 'horny_talk':
	*clr & cla
	minut += 5
	horny += 5
	gs 'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/new/horny_talk.jpg"></center>'
	'Мира поймав ваш взгляд усмехнулась. Подойдя к вам в плотную, она развернула вас спиной к себе и занув руку в ваши трусики воскликнула:'
	if horny >= 80:
		' - О, да тут целый водопад!'
	else
		' - Смотри ты, сучка потекла!'
	end
	'Поелозив в ваших трусах еще пару мгновений, Мира сказала:'
	if miraQW < 15:
		' - Всё, вали отсюда, шлюшка, некогда мне с тобой заниматься.'
		'И напевая под какую-то песенку отправилась домой. Вы посмотрев ей в след пару мгновений, тоже пошли в сторону своего дома.'
	else
		' - Ладно, становись раком, помогу своей шлюшке.'
		'Вы с готовностью стянули свои трусики и бухнулись на колени, становясь перед ней раком.'
	end
	if miraQW < 15:act 'Далее':gt 'mirasex','end'
	if miraQW >= 15:act 'Стонать':gt 'mirasex','mirafinger'
end
if $ARGS[0] = 'miralick_orgasm':
	if horny >= 100:
		orgasm += 1
		horny = 0
		manna += 15
		you_orgasm = 1
		'Неожиданно для вас Отлизывая Мире вы начали кончать сами. Между ног полыхал пожар и волны удовольствия охватывали тело, вы стонали, но лизать не прекращали.'
	end
end
if $ARGS[0] = 'lickmira_mis1':
	*clr & cla
	minut += 5
	if lesbian < 10:mirahorny += 10 & horny += rand(0,5)
	if lesbian >= 10:mirahorny += 20 & horny += rand(3,7)
	gs 'stat'
	if mirahorny < 100:
		'<center><img src="images/qwest/gadukino/new/lickmira_mis'+rand(1,3)+'.jpg"></center>'
		$textmis[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]
		gs 'mirasex','miralick_orgasm'
	else
		miraorgasm = 1
		mirahorny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_mis_cum.jpg"></center>'
		$textmis[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[7]+$text_cum[2]
		gs 'mirasex','miralick_orgasm'
		if horny < 60:
			'Отойдя от оргазма, Мира разжала свои ноги, выпустив вашу голову из плена. Стерев её соки со своего лица и приведя себя себя в порядок, вы отправились домой.'
		else
			'Отойдя от оргазма, Мира разжала свои ноги, выпустив вашу голову из плена. Стерев её соки со своего лица и приведя себя себя в порядок, вы посмотрели на Миру.'
		end
	end
	''
	killvar '$textmis'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0:
		act 'Лизать дальше':gt 'mirasex','lickmira_mis1'
	else
		if horny < 60:act 'Далее':gt 'mirasex','end'
		if horny >= 60:act 'Далее':gt 'mirasex','horny_talk'
	end
end
if $ARGS[0] = 'lickmira_mis2':
	*clr & cla
	minut += 5
	if lesbian < 10:mirahorny += 10 & horny += rand(0,5)
	if lesbian >= 10:mirahorny += 20 & horny += rand(3,7)
	gs 'stat'
	gs'time'
	if mirahorny < 100:
		'<center><img src="images/qwest/gadukino/new/lickmira_mis'+rand(1,3)+'.jpg"></center>'
		$textmis[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]
		gs 'mirasex','miralick_orgasm'
	else
		miraorgasm = 1
		'<center><img src="images/qwest/gadukino/new/lickmira_mis_cum.jpg"></center>'
		$textmis[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[7]+$text_cum[2]
		gs 'mirasex','miralick_orgasm'
		if you_orgasm = 0:'Отойдя от оргазма, Мира разжала свои ноги, выпустив вашу голову из плена. Через некоторое время, отойдя от оргазма, вы продолжили с Мирой...'
		if you_orgasm = 1:'Отойдя от оргазма, Мира разжала свои ноги, выпустив вашу голову из плена. Стерев её соки со своего лица и приведя себя себя в порядок, вы с Мирой отправились домой.'
	end
	''
	killvar '$textmis'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0 and you_orgasm = 0:
		if horny >= mirahorny:
			temp = rand(1,2)
			if temp = 1:act 'Лечь на землю':gt 'mirasex','69_2'
			if temp = 2:act 'Лизать дальше':gt 'mirasex','lickmira_mis2'
		else
			act 'Лечь на землю':gt 'mirasex','69_2'
			act 'Встать на ноги':gt 'mirasex','miralick_stand2'
			act 'Стать раком':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
		end
	elseif miraorgasm = 1 and you_orgasm = 0:
		act 'Встать на ноги':gt 'mirasex','miralick_stand2'
		act 'Стать раком':
			temp = rand(1,2)
			if temp = 1:gt 'mirasex','miralick_dog'
			if temp = 2:gt 'mirasex','mirafinger_dog'
		end
	elseif miraorgasm = 0 and you_orgasm = 1:
		act 'Лизать дальше':gt 'mirasex','lickmira_mis2'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = '69_1':
	*clr & cla
	minut += 5
	if lesbian < 10:mirahorny += 10
	if lesbian >= 10:mirahorny += 20
	if miralick < 10:horny += 10
	if miralick >= 10:horny += 20
	gs 'stat'
	if mirahorny < 100 and horny < 100:
		'<center><img src="images/qwest/gadukino/new/lickmira_69_'+rand(1,3)+'.jpg"></center>'
		$text69[4]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]
	elseif mirahorny >= 100 and horny < 100:
		miraorgasm = 1
		mirahorny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_69_cum2.jpg"></center>'
		$text69[4]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]+$text_cum[2]
		'Отойдя от оргазма, Мира разжала свои ноги, выпустив вашу голову из плена.'
	elseif mirahorny < 100 and horny >= 100:
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_69_cum1.jpg"></center>'
		$text69[4]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]+$text_cum[1]
		'Через некоторое время, отойдя от оргазма, вы улыбнулись Мире и продолжили...'
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		miraorgasm = 1
		mirahorny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_69_cum'+rand(1,2)+'.jpg"></center>'
		$text69[4]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]+$text_cum[3]
		'Через некоторое время, отойдя от оргазма, вы с Мирой привели себя в проядок и счастливые отправились домой...'
	end
	''
	killvar '$text69'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0 and you_orgasm = 0:
		if horny >= mirahorny:
			temp = rand(1,2)
			if temp = 1:act 'Лизать дальше':gt 'mirasex','69_2'
			if temp = 2:act 'Встать на колени':gt 'mirasex','lickmira_mis2'
		else
			act 'Лизать дальше':gt 'mirasex','69_2'
			act 'Встать на ноги':gt 'mirasex','miralick_stand2'
			act 'Стать раком':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
		end
	elseif miraorgasm = 1 and you_orgasm = 0:
		act 'Встать на ноги':gt 'mirasex','miralick_stand2'
		act 'Стать раком':
			temp = rand(1,2)
			if temp = 1:gt 'mirasex','miralick_dog'
			if temp = 2:gt 'mirasex','mirafinger_dog'
		end
	elseif miraorgasm = 0 and you_orgasm = 1:
		act 'Встать на колени':gt 'mirasex','lickmira_mis2'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = '69_2':
	*clr & cla
	minut += 5
	if lesbian < 10:mirahorny += 10
	if lesbian >= 10:mirahorny += 20
	if miralick < 10:horny += 10
	if miralick >= 10:horny += 20
	gs 'stat'
	if mirahorny < 100 and horny < 100:
		'<center><img src="images/qwest/gadukino/new/lickmira_69_'+rand(1,3)+'.jpg"></center>'
		$text69[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]
	elseif mirahorny >= 100 and horny < 100:
		miraorgasm = 1
		mirahorny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_69_cum2.jpg"></center>'
		$text69[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]+$text_cum[2]
		'Отойдя от оргазма, Мира разжала свои ноги, выпустив вашу голову из плена.'
	elseif mirahorny < 100 and horny >= 100:
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_69_cum1.jpg"></center>'
		$text69[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]+$text_cum[1]
		'Через некоторое время, отойдя от оргазма, вы улыбнулись Мире и продолжили...'
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		miraorgasm = 1
		mirahorny = 0
		'<center><img src="images/qwest/gadukino/new/lickmira_69_cum'+rand(1,2)+'.jpg"></center>'
		$text69[rand(1,3)]+$textlick[iif(lesbian < 10,rand(7,9),rand(10,12))]+$text_emotions[iif(horny < 60,5,iif(horny < 80,6,7))]+$text69[5]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]+$text_cum[3]
		'Через некоторое время, отойдя от оргазма, вы с Мирой привели себя в проядок и счастливы отправились домой...'
	end
	''
	killvar '$text69'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0 and you_orgasm = 0:
		if horny >= mirahorny:
			temp = rand(1,2)
			if temp = 1:act 'Лизать дальше':gt 'mirasex','69_2'
			if temp = 2:act 'Встать на колени':gt 'mirasex','lickmira_mis2'
		else
			act 'Лизать дальше':gt 'mirasex','69_2'
			act 'Встать на ноги':gt 'mirasex','miralick_stand2'
			act 'Стать раком':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
		end
	elseif miraorgasm = 1 and you_orgasm = 0:
		act 'Встать на ноги':gt 'mirasex','miralick_stand2'
		act 'Стать раком':
			temp = rand(1,2)
			if temp = 1:gt 'mirasex','miralick_dog'
			if temp = 2:gt 'mirasex','mirafinger_dog'
		end
	elseif miraorgasm = 0 and you_orgasm = 1:
		act 'Встать на колени':gt 'mirasex','lickmira_mis2'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = 'miralick_stand1':
	*clr & cla
	minut += 5
	if miralick < 10:horny += 10
	if miralick >= 10:horny += 20 & mirahorny += rand(0,5)
	gs 'stat'
	gs'time'
	if horny < 100:
		'<center><img src="images/qwest/gadukino/new/miralick_stand'+rand(1,2)+'.jpg"></center>'
		$textstand[rand(1,3)]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/miralick_stand_cum.jpg"></center>'
		$textstand[rand(1,3)]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[3]+$text_cum[1]
		'Ноги вас не держат и вы сползаете вниз, не в состоянии шевельнуться. Через некоторое время, отойдя от оргазма, вы привели себя в порядок и отправились домой.'
	end
	''
	killvar '$textstand'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if you_orgasm = 0:
		act 'Стонать':gt 'mirasex','miralick_stand1'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = 'miralick_stand2':
	*clr & cla
	minut += 5
	if miralick < 10:horny += 10
	if miralick >= 10:horny += 20 & mirahorny += rand(0,5)
	gs 'stat'
	gs'time'
	if horny < 100:
		'<center><img src="images/qwest/gadukino/new/miralick_stand'+rand(1,2)+'.jpg"></center>'
		$textstand[rand(1,3)]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,3))]
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/miralick_stand_cum.jpg"></center>'
		$textstand[rand(1,3)]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[3]+$text_cum[1]
		if miraorgasm = 0:'Ноги вас не держат и вы сползаете вниз, не в состоянии шевельнуться. Через некоторое время, отойдя от оргазма, вы продолжили с Мирой...'
		if miraorgasm = 1:'Ноги вас не держат и вы сползаете вниз, не в состоянии шевельнуться. Через некоторое время, отойдя от оргазма, вы с Мирой привели себя в порядок и отправились домой.'
	end
	''
	killvar '$textstand'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0 and you_orgasm = 0:
		if horny >= mirahorny:
			temp = rand(1,2)
			if temp = 1:act 'Лечь на землю':gt 'mirasex','69_2'
			if temp = 2:act 'Встать на колени':gt 'mirasex','lickmira_mis2'
		else
			act 'Стоять дальше':gt 'mirasex','miralick_stand2'
			act 'Лечь на землю':gt 'mirasex','69_2'
			act 'Стать раком':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
		end
	elseif miraorgasm = 1 and you_orgasm = 0:
		act 'Стоять дальше':gt 'mirasex','miralick_stand2'
		act 'Стать раком':
			temp = rand(1,2)
			if temp = 1:gt 'mirasex','miralick_dog'
			if temp = 2:gt 'mirasex','mirafinger_dog'
		end
	elseif miraorgasm = 0 and you_orgasm = 1:
		act 'Встать на колени':gt 'mirasex','lickmira_mis2'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = 'miralick_dog':
	*clr & cla
	minut += 5
	if miralick < 10:horny += 10
	if miralick >= 10:horny += 20 & mirahorny += rand(0,5)
	gs 'stat'
	gs'time'
	if horny < 100:
		'<center><img src="images/qwest/gadukino/new/miralick_dog'+rand(1,2)+'.jpg"></center>'
		$textdog[rand(1,3)]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,4))]
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/miralick_dog_cum.jpg"></center>'
		$textdog[rand(1,3)]+$textlick[iif(miralick < 10,rand(1,3),rand(4,6))]+$text_emotions[4]+$text_cum[1]
		if miraorgasm = 0:'Тело вас не слушается и вы плюхаетесь на живот, не в состоянии пошевелиться. Через некоторое время, отойдя от оргазма, вы продолжили с Мирой.'
		if miraorgasm = 1:'Тело вас не слушается и вы плюхаетесь на живот, не в состоянии пошевелиться. Через некоторое время, отойдя от оргазма, вы с Мирой привели себя в порядок и отправились домой.'
	end
	''
	killvar '$textdog'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0 and you_orgasm = 0:
		if horny >= mirahorny:
			temp = rand(1,2)
			if temp = 1:act 'Лечь на землю':gt 'mirasex','69_2'
			if temp = 2:act 'Встать на колени':gt 'mirasex','lickmira_mis2'
		else
			act 'Стоять раком дальше':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
			act 'Встать на ноги':gt 'mirasex','miralick_stand2'
			act 'Лечь на землю':gt 'mirasex','69_2'
		end
	elseif miraorgasm = 1 and you_orgasm = 0:
			act 'Стоять раком дальше':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
		act 'Встать на ноги':gt 'mirasex','miralick_stand2'
	elseif miraorgasm = 0 and you_orgasm = 1:
		act 'Встать на колени':gt 'mirasex','lickmira_mis2'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = 'mirafinger':
	*clr & cla
	minut += 5
	horny += 15
	mirahorny += rand(0,5)
	gs 'stat'
	gs'time'
	if horny < 100:
		'<center><img src="images/qwest/gadukino/new/mirafinger_dog'+rand(1,2)+'.jpg"></center>'
		$textdog[4]+$textfinger[rand(1,3)]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,4))]
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/mirafinger_dog_cum.jpg"></center>'
		$textdog[4]+$textfinger[rand(1,3)]+$text_emotions[4]+$text_cum[1]
		'Тело вас не слушается и вы плюхаетесь на живот, не в состоянии пошевелиться. Мира ехидно взглянула на вас и дав облизать свои пальцы, чтобы очистить их от ваших же выделений, пошла в сторону дома. Через некоторое время, отойдя от оргазма, вы привели себя в порядок и отправились домой.'
	end
	''
	killvar '$textdog'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if you_orgasm = 0:
		act 'Стоять раком дальше':gt 'mirasex','mirafinger'
	else
		act 'Далее':gt 'mirasex','end'
	end
end
if $ARGS[0] = 'mirafinger_dog':
	*clr & cla
	minut += 5
	horny += 15
	mirahorny += rand(0,5)
	gs 'stat'
	gs'time'
	if horny < 100:
		'<center><img src="images/qwest/gadukino/new/mirafinger_dog'+rand(1,4)+'.jpg"></center>'
		$textdog[rand(1,3)]+$textfinger[rand(1,3)]+$text_emotions[iif(horny < 60,1,iif(horny < 80,2,4))]
	else
		orgasm += 1
		you_orgasm = 1
		horny = 0
		'<center><img src="images/qwest/gadukino/new/mirafinger_dog_cum.jpg"></center>'
		$textdog[rand(1,3)]+$textfinger[rand(1,3)]+$text_emotions[4]+$text_cum[1]
		if miraorgasm = 0:'Тело вас не слушается и вы плюхаетесь на живот, не в состоянии пошевелиться. Через некоторое время, отойдя от оргазма, вы продолжили с Мирой.'
		if miraorgasm = 1:'Тело вас не слушается и вы плюхаетесь на живот, не в состоянии пошевелиться. Через некоторое время, отойдя от оргазма, вы с Мирой привели себя в порядок и отправились домой.'
	end
	''
	killvar '$textdog'
	killvar '$textlick'
	killvar '$text_emotions'
	killvar '$text_cum'
	if miraorgasm = 0 and you_orgasm = 0:
		if horny >= mirahorny:
			temp = rand(1,2)
			if temp = 1:act 'Лечь на землю':gt 'mirasex','69_2'
			if temp = 2:act 'Встать на колени':gt 'mirasex','lickmira_mis2'
		else
			act 'Стоять раком дальше':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
			act 'Встать на ноги':gt 'mirasex','miralick_stand2'
			act 'Лечь на землю':gt 'mirasex','69_2'
		end
	elseif miraorgasm = 1 and you_orgasm = 0:
			act 'Стоять раком дальше':
				temp = rand(1,2)
				if temp = 1:gt 'mirasex','miralick_dog'
				if temp = 2:gt 'mirasex','mirafinger_dog'
			end
		act 'Встать на ноги':gt 'mirasex','miralick_stand2'
	elseif miraorgasm = 0 and you_orgasm = 1:
		act 'Встать на колени':gt 'mirasex','lickmira_mis2'
	else
		act 'Далее': gt 'mirasex','end'
	end
end
if $ARGS[0] = 'end':
	mirainmeadow = 0
	you_orgasm = 0
	miraorgasm = 0
	minut += 20
	gt'Gaddvor'
end
$textstand[1] = 'Стоя, облокотившись на дерево, вы чувствуете жаркое дыхание Миры у себя между ног и возбуждающие прикосновения её языка. '
$textstand[2] = 'Закрыв глаза и облокотившись на дерево, вы ощущаете легкие прикосновения языка Миры к вашей вагине. '
$textstand[3] = 'Облокотившись на дерево, вы ощущаете жаркое дыхание Миры у себя между ног и легкие прикосновения её языка к вашей вагине. '
$textdog[1] = 'Стоя раком, вы чувствуете жаркое дыхание Миры у себя на попе и возбуждающие прикосновения её языка к вашей киске. '
$textdog[2] = 'Закрыв глаза и оттопырив попу перед Мирой, вы ощущаете легкие прикосновения её языка к вашей вагине. '
$textdog[3] = 'Стоя раком перед Мирой, вы ощущаете жаркое дыхание у себя между ног, чувствуете возбуждающие прикосновения её языка и пальчиков к вашей вагине. '
$textdog[4] = 'Стоя раком перед Мирой, вы ощущаете возбуждающие прикосновения её рук к вашей возбужденной киске. '
$textmis[1] = 'Мира сидит на камне перед вами, широко раздвинув свои ноги и наблюдает за процессом. '
$textmis[2] = 'Сидя на камне с широко раздвинутыми ногами, Мира наслаждается лаской ваших губ и язычка. '
$textmis[3] = 'Широко раздвинув ноги, Мира наслаждается, ощущая ваше жаркое дыхание на своей промежности и чувствуя возбуждающие прикосновения язычка к вагине. '
$text69[1] = 'Вы с Мирой лежите в позе "69", и жадно вылизываете друг друга. '
$text69[2] = 'Вы лежите на земле и видите перед глазами, истекающую соками Мирину киску. '
$text69[3] = 'Широко раздвинув ноги, Мира нависла своей киской над вами и наслаждается, ощущая ваше жаркое дыхание на своей промежности и чувствуя возбуждающие прикосновения язычка к вагине. '
$text69[4] = 'Вы ложитесь на землю, Мира, перекинув ногу через вас, занимает позицию сверху. Вы чувствуете жаркое дыхание Миры у себя между ног и возбуждающие прикосновения её языка. '
$text69[5] = 'Вылизывая Миру вы ощущаете жаркое дыхание у себя между ног и возбуждающие прикосновения её языка. '
$textlick[1] ='Раздвинув пальцами половые губки, она неумело лижет, проводя неопытным язычком по всей длине вашей писи, '
$textlick[2] ='Она несмело цeлует вашу писeчку, пoсaсывaя ee губки, иногда задевая неопытным язычкoм ваш клитoр, '
$textlick[3] ='Она осторожно водит неопытным язычком сверху вниз, по всей длине вашей писи, иногда нежно касаясь клитoра, '
$textlick[4] ='Раздвинув пальцами половые губки, она умело лижет, проводя язычком по всей длине вашей писи и щекоча ваш клиторок, '
$textlick[5] ='Она цeлует вашу писeчку, пoсaсывaя ee губки, иногда пытаясь проникнуть шаловливым язычкoм в вашу <<$vaginatipe2>> вагину, '
$textlick[6] ='Она быстро водит умелым язычком сверху вниз, по всей длине вашей писи, иногда делая круговые движения, и нежно касаясь клитoра, '
$textlick[7] ='Уткнувшись лицом между её ног, вы неумело лижете, проводя неопытным язычком по всей длине писи, '
$textlick[8] ='Вы несмело цeлуете её писeчку, пoсaсывaя половые губки, иногда задевая неопытным язычкoм её клитoр, '
$textlick[9] ='Вы осторожно водите неопытным язычком сверху вниз, по всей длине её писи, иногда осторожно касаясь клитoра, '
$textlick[10] ='Уткнувшись лицом между её ног, вы бойко лижете, проводя язычком по всей длине её писи, не забывая про клитор, '
$textlick[11] ='Вы цeлуете её киску, лаская половые губки, иногда проникая своим язычком между ними, касаетесь клитора, '
$textlick[12] ='Вы быстро водите умелым язычком сверху вниз, скользя вдоль всей её промежности, проникая в вагину и лаская её клитор, '
$textfinger[1] ='Вы чувствуете быстрые движения её пальцев, снующих туда-сюда в вашей писе, '
$textfinger[2] ='Она трахает двумя пальцами вашу <<$vaginatipe2>> вагину, '
$textfinger[3] ='Она вводит пальцы на всю длинну в вашу <<$vaginatipe2>>, делая поступательные движения, '
$text_emotions[1] = 'вызывая бурю эмоций внизу живота.'
$text_emotions[2] = 'вызывая у вас стоны наслаждения.'
$text_emotions[3] = 'срывая с ваших губ стоны наслаждения и заставляя двигаться бедрами навстречу.'
$text_emotions[4] = 'срывая с ваших губ стоны наслаждения и заставляя подмахивать попой.'
$text_emotions[5] = 'заставляя вздрагивать всем телом, при каждом прикосновении.'
$text_emotions[6] = 'срывая с её губ стоны наслаждения.'
$text_emotions[7] = 'заставляя выгибаться всем телом и сильнее прижимать вашу голуву к своей промежности.'
$text_cum[1] = 'Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас и все ваше тело охватывают горячие волны оргазма. Вы невольно кричите от удовольствия извиваясь и вздрагивая всем телом.'
$text_cum[2] = 'Через некоторое время Мира задрожала и ее киска начала ритмично пульсировать перед вашим лицом. Она выгнулась в оргазме и уже не сдерживаясь стонала во весь голос, сжав вашу голову ногами и заливая лицо своими соками.'
$text_cum[3] = 'Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас и все ваше тело охватывают горячие волны оргазма. Одновременно вы замечаете, что Мира задрожала всем телом и ее киска начала ритмично пульсировать. Она выгнулась в оргазме и уже не сдерживаясь стонала во весь голос, сжав вашу голову ногами и заливая лицо своими соками.'