$boy = 'Сергей'
dick = 18
silaVag = 1
harakBoy = 1
boyage = age+15
gs'stat'
'<center><b><font color = maroon>Сергей</font></b></center>'
'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
'Сергей друг Андрея и Игоря, и один из знакомых вам охотников. Ему <<boyage>> лет. Он женат и живет в Центре..'
if hantersSergeiQw < 0:'У вас с ним плохие отношения, похоже он затаил на вас какую-то обиду.'
if hantersSergeiQw >= 0 and hantersSergeiQw < 10:'У вас с ним нормальные отношения.'
if hantersSergeiQw >= 10 and hantersSergeiQw < 20:'У вас с ним дружеские отношения.'
if hantersSergeiQw >= 20 and hantersSergeiQw < 25:'Похоже он вам симпотизирует.'
if hantersSergeiQw >= 25 and hantersSergeiQw < 30:'Похоже он в вас влюблен.'
if hantersSergeiQw >= 30 and hantersSergeiQw <= 35:'Похоже он у вас с ним любовь.'
if hantersSergeiQw > 35 :'У вас с ним любовь.'
if hantersSergeiLove = 1:'Вы с ним встречаетесь.'
act 'Поболтать':
	*clr & cla
	minut += 60
	if hantersSergeiQw < 10:hantersSergeiQw += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/talk1.'+rand(1,3)+'.jpg"></center>'
	if hantersIgorQw >= 0:'Вы весело поболтали с Сергеем, выслушивая разные интересные истории из его жизни, и рассказывая свои.'
	if hantersIgorQw < 0:'Вы разговариваете с Игорем. Он хмурится и ведет себя не очень дружелюбно, но все же поддерживает разговор.'
	act'Далее':gt $loc, $metka
end
if hantersSergeiQw >= 10:
	if hantersSergeiLove = 0:
		act 'Флиртовать':
			*clr & cla
			minut += 120
			horny += 10
			if hantersSergeiQw <= 35 and hantersKnowSlut = 0:hantersSergeiQw += 1
			if hantersIgorQw >= 10 and hantersKnowSlut = 0:hantersIgorQw -= 1
			if hantersAndreiQw >= 10 and hantersKnowSlut = 0:hantersAndreiQw -= 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterflirt1.'+rand(1,3)+'.jpg"></center>'
			'Вы перекидываетесь с Сергеем игривыми взглядами и вовсю кокетничаете. Он рад вашей компании и пару раз вы замечаете на себе его блуждающий недвусмысленный взгляд.'
			if hantersSergeiLove = 0 and hantersSergeiQw >= 30 and hantersKnowSlut = 0 and vnesh >= 40:
				*clr & cla
				minut += 5
				horny += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/Swamp/hanterkiss1.jpg"></center>'
				'Вы мило улыбаетесь Сергею и флиртуете с ним. Неожиданно он берет ваше лицо в ладони и приближает свои губы к вашим губам.'
				act 'Ответить на поцелуй':
					*clr & cla
					minut += 5
					horny += 5
					hantersSergeiLove = 1
					hantersSergeiQw += 1
					manna = 100
					gs'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterkiss2.jpg"></center>'
					'Ваши губы соприкасаются, у вас замирает сердце и дыхание. <<$boy>> целует вас и вы ему отвечаете, сильнее прижимаясь к его губам.'
					if horny >= 40:
						act'Далее':
							*clr & cla
							minut += 5
							gs'stat'
							'<center><img src="images/qwest/gadukino/Swamp/hanterkiss3.jpg"></center>'
							'- <<$name[2]>>, я хочу тебя, - прошептал вам на ухо <<$boy>>, когда ваши губы наконец разомкнулись. Видя , что вы не против, <<$boy>> нежно взял вас за руку и повел за собой.'
							act 'Идти':gt'HanterLoveSex'
						end
					else
						act'Далее':
							*clr & cla
							minut += 5
							gs'stat'
							'<center><img src="images/qwest/gadukino/Swamp/hanterkiss3.jpg"></center>'
							'- Это было здорово, <<$name[2]>>, - сказал вам <<$boy>>, когда ваши губы наконец разомкнулись. Вы счастливы, видя его радостный взгляд и улыбку.'
							act'Далее':gt $loc, $metka
						end
					end
				end
				act 'Убрать лицо':
					*clr & cla
					minut += 5
					hantersSergeiQw -= 50
					gs'stat'
					'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
					' - Нет, <<$boy>>, не нужно этого, - сказали вы, и стараясь не смотреть на парня, ушли.'
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
			hantersSergeiQw += 1
			if hantersIgorLove > 0 or hantersAndreiLove > 0:hanterslut += 1
			if hantersIgorLove = 0 and hantersAndreiLove = 0:hanterslut -= 1
			manna = 100
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.'+rand(1,4)+'.jpg"></center>'
			'Вы проводите с Сергеем вместе время, обнимаясь и целуясь. Он рад вашей компании, вы не можете не замечать его счастливый взгляд, и от этого вам самой очень радостно на душе.'
			act'Отойти':gt $loc, $metka
		end
	end
end
if hantersSergeiLove > 0 and horny >= 60:
	act 'Приставать':
		*clr & cla
		minut += 10
		horny += 5
		hantersSergeiQw += 1
		hantersSergeisex += rand(9,30)
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(1,6)+'.jpg"></center>'
		'Вы совсем уж внаглую подмигиваете Сергею, томно вздыхаете, проводя язычком по губам и <<$boy>>, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
end
if hantersSergeiLove > 0 and horny <= 60 and hantersSergeiQw >= 10 and temp = 1 and hantersSergeisex = 0:
	*clr & cla
	minut += 5
	horny += 5
	hantersSergeisex += rand(9,30)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Вы подошли к Сергею, чтобы провести время вместе, но вместо этого он страстно впивается в ваши губы.'
	'- <<$name[1]>>, я хочу тебя, - прошептал он после поцелуя.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersSergeiQw += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(4,6)+'.jpg"></center>'
		'Улыбнувшись вы подмигиваете Сергею. Он, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersSergeiQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, <<$boy>>, давай не сейчас, - сказали вы, и стараясь не смотреть на парня, ушли.'
		act 'Идти':gt $loc, $metka
	end
end
if hantersSergeiLove > 0:
	act 'Расстаться с парнем':
		*clr & cla
		minut += 5
		hantersSergeiLove = 0
		hantersSergeiQw -= 100
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/brosila.jpg"></center>'
		' - <<$boy>>, я решила, что у наших отношений нет будущего, и нам нужно расстаться, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Идти':gt $loc, $metka
	end
end
act'Отойти':gt $loc, $metka
if hantersSergeiQw < 10 and hantersSergeiLove > 0:
	*clr & cla
	minut += 5
	hantersSergeiLove = 0
	hantersSergeiQw -= 10
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/brosil.jpg"></center>'
	'Вы хотели поговорить с Сергеем, но он вас опередил, не дав сказать вам сказать нислова.'
	' - <<$name[1]>>, я понял, что у наших отношений нет будущего, и нам нужно расстаться, - сказали он, и стараясь не смотреть в вашу сторону, решительно ушел прочь.'
	' - Ну , может оно и к лучшему, - подумали вы, уходя в другую сторону.'
	act 'Идти':gt $loc, $metka
end
if hantersSergeiQw > 50 and hantersSergeiLove > 0:
	*clr & cla
	minut += 5
	hantersSergeiLove = 0
	hantersSergeiQw -= 50
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/brosil.jpg"></center>'
	'Вы хотели поговорить с Сергеем, но он вас опередил, не дав сказать вам сказать нислова.'
	' - <<$name[1]>>, я понял, что у наших отношений нет будущего. Ты хорошая девушка, но я очень ценю свою семью, чтобы рисковать продолжая отношения с тобой, - сказали он, и стараясь не смотреть в вашу сторону, решительно ушел прочь.'
	' - Ну как же так? Хотя может оно и к лучшему, - расстроенно подумали вы, уходя в другую сторону.'
	act 'Идти':gt $loc, $metka
end