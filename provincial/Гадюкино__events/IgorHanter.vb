$boy = 'Игорь'
$boybody = 'высокий'
$boybod = 'атлетичный'
$boyface = 'брюнет'
boypic = 31
dick = 16
silaVag = 2
finance = 1
vneshBoy = 8
$boyClo = 'одет в джинсы и свитер.'
figurBoy = 1
titBoy = 1
haerBoy = 3
harakBoy = 1
izvrat = 0
boyage = age+8
gs 'stat'
temp = rand(1,5)
'<center><b><font color = maroon>Игорь Анисимов</font></b></center>'
'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
'Игорь один из знакомых вам охотников, он приезжает в гости к Андрею поохотится. Ему <<boyage>> лет. Он не женат и живет в Центре..'
if hantersIgorQw < 0:'У вас с ним плохие отношения, похоже он затаил на вас какую-то обиду.'
if hantersIgorQw >= 0 and hantersIgorQw < 10:'У вас с ним нормальные отношения.'
if hantersIgorQw >= 10 and hantersIgorQw < 20:'У вас с ним дружеские отношения.'
if hantersIgorQw >= 20 and hantersIgorQw < 25:'Похоже он вам симпотизирует.'
if hantersIgorQw >= 25 and hantersIgorQw < 30:'Похоже он в вас влюблен.'
if hantersIgorQw >= 30 and hantersIgorQw <= 35:'Похоже он у вас с ним любовь.'
if hantersIgorQw > 35 :'У вас с ним любовь.'
if hantersIgorLove = 1:'Вы с ним встречаетесь.'
if hantersIgorLove = 2:'<<$boy>> ваш парень.'
if hantersIgorLove = 3:'<<$boy>> ваш муж.'
act 'Поболтать':
	*clr & cla
	minut += 60
	if hantersIgorQw < 10:hantersIgorQw += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/talk1.'+rand(1,3)+'.jpg"></center>'
	if hantersIgorQw >= 0:'Вы весело поболтали с Игорем, выслушивая разные интересные истории из его жизни, и рассказывая свои.'
	if hantersIgorQw < 0:'Вы разговариваете с Игорем. Он хмурится и ведет себя не очень дружелюбно, но все же поддерживает разговор.'
	act'Далее':gt $loc, $metka
end
if hantersIgorQw >= 10:
	if hantersIgorLove = 0:
		act 'Флиртовать':
			*clr & cla
			minut += 120
			horny += 10
			if hantersIgorQw <= 35 and hantersKnowSlut = 0:hantersIgorQw += 1
			if hantersAndreiQw >= 10 and hantersKnowSlut = 0:hantersAndreiQw -= 1
			if hantersSergeiQw >= 10 and hantersKnowSlut = 0:hantersSergeiQw -= 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterflirt1.'+rand(1,3)+'.jpg"></center>'
			'Вы перекидываетесь с Игорем игривыми взглядами и вовсю кокетничаете. Он рад вашей компании и пару раз вы замечаете на себе его блуждающий недвусмысленный взгляд.'
			if hantersIgorLove = 0 and hantersIgorQw >= 35 and hantersKnowSlut = 0 and bfA = 1 and vnesh >= 40:
				*clr & cla
				minut += 5
				horny += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/Swamp/hanterkiss1.jpg"></center>'
				'Вы мило улыбаетесь Игорю и флиртуете с ним. Неожиданно Игорь приближает к вам свое лицо, вы чувствуете его дыхание на своей коже, чувствуете аромат его тела, который нежными нотками доносится до вас. Медленно, боясь вас спугнуть, Игорь касается пальцами вашей щеки и вы с замиранием сердца наблюдаете как его губы приближаются к вашим...'
				act 'Ответить на поцелуй':
					*clr & cla
					minut += 5
					horny += 5
					manna = 100
					hantersIgorLove = 1
					hantersIgorQw += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterkiss2.jpg"></center>'
					'Ваши губы соприкасаются, у вас замирает сердце и дыхание. Игорь нежно целует вас и вы ему отвечаете, сильнее прижимаясь к его губам.'
					if horny >= 40:
						act'Далее':
							*clr & cla
							minut += 5
							gs'stat'
							'<center><img src="images/qwest/gadukino/Swamp/hanterkiss3.jpg"></center>'
							'- <<$name[2]>>, я хочу тебя, - прошептал вам на ухо <<$boy>>, когда ваши губы наконец разомкнулись. Видя , что вы не против, Игорь нежно взял вас за руку и повел за собой.'
							act 'Идти':gt'HanterLoveSex'
						end
					else
						act'Далее':
							*clr & cla
							minut += 5
							gs'stat'
							'<center><img src="images/qwest/gadukino/Swamp/hanterkiss3.jpg"></center>'
							'- Это было восхитительно, <<$name[2]>>, - прошептал вам на ухо <<$boy>>, когда ваши губы наконец разомкнулись. Вы таете у него в руках, видя его счастливый взгляд и улыбку.'
							act'Далее':gt $loc, $metka
						end
					end
				end
				act 'Убрать лицо':
					*clr & cla
					minut += 5
					hantersIgorQw -= 50
					gs'stat'
					'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
					' - Нет, <<$boy>>, не нужно этого, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
					act'Уйти':gt $loc, $metka
				end
			else
				act'Отойти':gt $loc, $metka
			end
		end
	else
		act 'Проводить вместе время':
			*clr & cla
			minut += 120
			horny += 10
			manna = 100
			hantersIgorQw += 1
			if hantersSergeiLove > 0 or hantersAndreiLove > 0:hanterslut += 1
			if hantersSergeiLove = 0 and hantersAndreiLove = 0:hanterslut -= 1
			if hantersIgorLove = 2:bfA += 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.'+rand(1,4)+'.jpg"></center>'
			'Вы проводите с Игорем вместе время нежно воркуя, обнимаясь и целуясь. Он рад вашей компании, вы не можете не замечать его полный счастья взгляд, и от этого вам хочется петь и летать.'
			act'Отойти':gt $loc, $metka
		end
	end
end
if hantersIgorLove > 0 and horny >= 60:
	act 'Приставать':
		*clr & cla
		minut += 10
		horny += 5
		hantersIgorQw += 1
		hantersIgorsex += rand(12,36)
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(1,6)+'.jpg"></center>'
		'Вы совсем уж внаглую подмигиваете Игорю, томно вздыхаете, проводя язычком по губам и Игорь, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
end
if hantersIgorLove > 0 and horny <= 60 and hantersIgorQw >= 10 and temp = 1 and hantersIgorsex = 0:
	*clr & cla
	minut += 5
	horny += 5
	hantersIgorsex += rand(12,36)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Вы подошли к Игорю, чтобы провести время вместе, но он неожиданно впился в ваши губы страстным поцелуем и прошептал:'
	'- <<$name[1]>>, я хочу тебя.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersIgorQw += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(4,6)+'.jpg"></center>'
		'Улыбнувшись вы подмигиваете Игорю. Он, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersIgorQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, <<$boy>>, давай не сейчас, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Идти':gt $loc, $metka
	end
end
if hantersIgorLove > 0:
	act 'Расстаться с парнем':
		*clr & cla
		minut += 5
		hantersIgorLove = 0
		if hantersIgorLove = 2:bfA = 0
		hantersIgorQw -= 100
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/brosila.jpg"></center>'
		' - <<$boy>>, я решила, что у наших отношений нет будущего, и нам нужно расстаться, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Идти':gt $loc, $metka
	end
end
act'Отойти':gt $loc, $metka
if hantersIgorQw < 10 and hantersIgorLove > 0:
	*clr & cla
	minut += 5
	hantersIgorLove = 0
	if hantersIgorLove = 2:bfA = 0
	hantersIgorQw -= 10
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/brosil.jpg"></center>'
	'Вы хотели поговорить с Игорем, но он вас опередил, не дав сказать вам сказать нислова.'
	' - <<$name[1]>>, я понял, что у наших отношений нет будущего, и нам нужно расстаться, - сказали он, и стараясь не смотреть в вашу сторону, решительно ушел прочь.'
	' - Ну , может оно и к лучшему, - подумали вы, уходя в другую сторону.'
	act 'Идти':gt $loc, $metka
end
if hantersIgorLove < 2 and hantersIgorQw >= 35 and hantersKnowSlut = 0 and bfA < 1 and hour >= 8 and hour < 20 and vnesh >= 40:
	*clr & cla
	minut += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterkiss1.jpg"></center>'
	'Неожиданно <<$boy>> приблизил к вам свое лицо, вы почувствовали его дыхание на своей коже, еле уловимый аромат его тела, который нежными нотками доносится до вас. Медленно, боясь вас спугнуть, Игорь прикоснулся пальцами к вашей щеке и вы с замиранием сердца почувствовали его губы на своих губах...'
	act 'Ответить на поцелуй':
		*clr & cla
		minut += 5
		!stopboy = 0
		$boyA = $boy
		$boybodyA = $boybody
		$boybodA = $boybod
		$boyfaceA = $boyface
		dickA = dick
		silaVagA = silaVag
		financeA = finance
		vneshBoyA = vneshBoy
		$boyCloA = $boyClo
		figurBoyA = figurBoy
		titBoyA = titBoy
		haerBoyA = haerBoy
		harakBoyA = harakBoy
		boyageA = boyage
		boydayA = day
		bfA = 1
		daya = 0
		boyonceA = 0
		izvratA = izvrat
		giftDayA = 0
		giftNumA = 0
		love = 0
		boypicA = boypic
		hantersIgorLove = 2
		manna = 100
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterkiss2.jpg"></center>'
		'Ваши губы соприкасаются, у вас замирает сердце и дыхание. <<$boy>> нежно целует вас и вы ему отвечаете, сильнее прижимаясь к его губам.'
		if horny >= 40:
			act'Далее':
				*clr & cla
				minut += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/Swamp/hanterkiss3.jpg"></center>'
				'- <<$name[2]>>, я хочу тебя, - прошептал вам на ухо <<$boy>>, когда ваши губы наконец разомкнулись. Видя , что вы не против, Игорь нежно взял вас за руку и повел за собой.'
				act 'Идти':gt'HanterLoveSex'
			end
		else
			act'Далее':
				*clr & cla
				minut += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/Swamp/hanterkiss3.jpg"></center>'
				'- Это было восхитительно, <<$name[2]>>, - прошептал вам на ухо <<$boy>>, когда ваши губы наконец разомкнулись. Вы таете у него в руках, видя его счастливый взгляд и улыбку.'
				act'Далее':gt $loc, $metka
			end
		end
	end
	act 'Убрать лицо':
		*clr & cla
		minut += 5
		hantersIgorQw -= 50
		gs'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, <<$boy>>, не нужно этого, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act'Уйти':gt $loc, $metka
	end
end