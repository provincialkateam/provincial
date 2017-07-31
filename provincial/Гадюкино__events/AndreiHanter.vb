$boy = 'Андрей'
dick = 20
silaVag = 0
harakBoy = 2
boyage = age+21
gs'stat'
'<center><b><font color = maroon>Андрей</font></b></center>'
'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
'Андрей один из знакомых вам охотников. Ему <<boyage>> лет. Он разведен и живет в Гадюкино один.'
if hantersAndreiQw < 0:'У вас с ним плохие отношения, похоже он затаил на вас какую-то обиду.'
if hantersAndreiQw >= 0 and hantersAndreiQw < 10:'У вас с ним нормальные отношения.'
if hantersAndreiQw >= 10 and hantersAndreiQw < 15:'У вас с ним дружеские отношения.'
if hantersAndreiQw >= 15 and hantersAndreiQw < 25:'Похоже он вам симпотизирует.'
if hantersAndreiQw > 25 :'У вас с ним любовь.'
if hantersAndreiLove = 1:'Вы с ним встречаетесь.'
act 'Поболтать':
	*clr & cla
	minut += 60
	if hantersAndreiQw < 10:hantersAndreiQw += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/talk1.'+rand(1,3)+'.jpg"></center>'
	if hantersAndreiQw >= 0:'Вы поболтали с Андреем, выслушивая разные интересные истории из его жизни, и рассказывая свои.'
	if hantersAndreiQw < 0:'Вы разговариваете с Андреем. Он хмурится и ведет себя не очень дружелюбно, но все же поддерживает разговор.'
	act'Далее':gt $loc, $metka
end
if hantersAndreiQw >= 10:
	if hantersAndreiLove = 0:
		act 'Флиртовать':
			*clr & cla
			minut += 120
			horny += 10
			if hantersAndreiQw <= 35 and hantersKnowSlut = 0:hantersAndreiQw += 1
			if hantersIgorQw >= 10 and hantersKnowSlut = 0:hantersIgorQw -= 1
			if hantersSergeiQw >= 10 and hantersKnowSlut = 0:hantersSergeiQw -= 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterflirt1.'+rand(1,3)+'.jpg"></center>'
			'Вы вовсю кокетничаете с Андреем. Он рад вашей компании и пару раз вы замечаете на себе его блуждающий недвусмысленный взгляд.'
			if hantersAndreiLove = 0 and hantersAndreiQw >= 25 and hantersKnowSlut = 0 and vnesh >= 20:
				*clr & cla
				minut += 5
				horny += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/Swamp/hanterkiss1.jpg"></center>'
				'Вы мило улыбаетесь Андрею и флиртуете с ним. Неожиданно он приближает к вам свое лицо и впивается в ваши губы страстным, долгим поцелуем...'
				act 'Ответить на поцелуй':
					*clr & cla
					minut += 5
					horny += 5
					hantersAndreiLove = 1
					hantersAndreiQw += 1
					manna = 100
					gs'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterkiss2.jpg"></center>'
					'Ваши губы соприкасаются, у вас замирает сердце и дыхание. <<$boy>> страстно целует вас и вы ему отвечаете, сильнее прижимаясь к его губам.'
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
							'- Это было круто, <<$name[2]>>, - сказал вам на <<$boy>>, когда ваши губы наконец разомкнулись.'
							act'Далее':gt $loc, $metka
						end
					end
				end
				act 'Убрать лицо':
					*clr & cla
					minut += 5
					hanterslut += 1
					hantersAndreiQw -= 50
					gs'stat'
					'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
					' - Нет, <<$boy>>, не нужно этого, - сказали вы, и стараясь не смотреть на Андрея ушли.'
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
			hantersAndreiQw += 1
			if hantersIgorLove > 0 or hantersSergeiLove > 0:hanterslut += 1
			if hantersIgorLove = 0 and hantersSergeiLove = 0:hanterslut -= 1
			manna = 100
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.'+rand(1,4)+'.jpg"></center>'
			'Вы проводите с Андреем вместе время нежно воркуя, обнимаясь и целуясь. Он рад вашей компании, вы не можете не замечать его полный счастья взгляд, и от этого вам хочется петь и летать.'
			act'Отойти':gt $loc, $metka
		end
	end
end
if hantersAndreiLove > 0 and horny >= 60:
	act 'Приставать':
		*clr & cla
		minut += 10
		horny += 5
		hantersAndreiQw += 1
		hantersAndreisex += rand(6,24)
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(1,6)+'.jpg"></center>'
		'Вы совсем уж внаглую подмигиваете Игорю, томно вздыхаете, проводя язычком по губам и Игорь, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
end
if hantersAndreiLove > 0 and horny <= 60 and hantersAndreiQw >= 10 and temp = 1 and hantersAndreisex = 0:
	*clr & cla
	minut += 5
	horny += 5
	hantersAndreisex += rand(6,24)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Вы подошли к Андрею, чтобы провести время вместе, но он неожиданно впился в ваши губы страстным поцелуем и ни слова не говоря потянул вас за собой.'
	act 'Идти с Андреем':
		*clr & cla
		minut += 5
		hantersAndreiQw += 1
		horny += 5
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterhands.jpg"></center>'
		'Вы идете с Андреем держась за руки, прекрасно понимая, куда и зачем он вас ведет. И вы совсем даже не против.'
		act 'Далее':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersAndreiQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, <<$boy>>, давай не сейчас, - сказали вы, и стараясь не смотреть на него ушли.'
		act 'Идти':gt $loc, $metka
	end
end
if hantersAndreiLove > 0:
	act 'Расстаться с парнем':
		*clr & cla
		minut += 5
		hantersAndreiLove = 0
		hantersAndreiQw -= 100
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/brosila.jpg"></center>'
		' - <<$boy>>, я решила, что у наших отношений нет будущего, и нам нужно расстаться, - сказали вы, и стараясь не смотреть на Андрея, ушли.'
		act 'Идти':gt $loc, $metka
	end
end
act'Отойти':gt $loc, $metka
if hantersAndreiQw < 10 and hantersAndreiLove > 0:
	*clr & cla
	minut += 5
	hantersAndreiLove = 0
	hantersAndreiQw -= 10
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/brosil.jpg"></center>'
	'Вы хотели поговорить с Андреем, но он вас опередил, не дав сказать вам сказать нислова.'
	' - <<$name[1]>>, между нами ничего не получится, так что лучше нам расстаться, - сказали он и  решительно ушел прочь.'
	' - Ну , может оно и к лучшему, - подумали вы, уходя в другую сторону.'
	act 'Идти':gt $loc, $metka
end