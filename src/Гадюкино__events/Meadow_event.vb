﻿if $ARGS[0] = 'mira_mitka':
	*clr & cla
	minut += 5
	horny += 15
	voyeurism += 1
	gs 'stat'
	gs'time'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/MiraMeadowSex.jpg'
	gs 'zz_render','','','Выйдя на поляну вы вдруг замечаете Миру с Митькой. Они болтают между собой, попутно раздеваясь, но о чем именно они говорят, вам не удается услышать из-за растояния.'
	act 'Смотреть':
		*clr & cla
		minut += 5
		horny += 25
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowSex1.jpg'
		gs 'zz_render','','','Через пару минут Мирослава ложится перед Митькой на покрывало и призывно расставляет перед ним ноги. Тот, не заставляя себя ждать, тут же пристраивается у нее между ног и начинает грубо и сильно вколачивать в нее свой член, отчего она начинает громко и охать и подвизгивать.'
		act 'Смотреть':
			*clr & cla
			minut += 5
			horny += 15
			if miragopQW = 2:miragopQW = 3
			mirasextimes += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowSex2.jpg'
			gs 'zz_render','','','Минуть через пятнадцать Митька наконец кончает Мирославе на живот и еще немного полежав, они начинают собираться...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		end
	end
end
if $ARGS[0] = 'mira_gang':
	*clr & cla
	minut += 30
	horny += 25
	miragopQW += 1
	mirasextimes += 1
	voyeurism += 1
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ12.jpg'
	gs 'zz_render','','','Миры за ихними телами почти не видно, только кусок голого зада да покачивающиеся в кроссовках ноги. Вы с полчаса наблюдаете за тем, как мужики по очереди ебут безвольную и уставшую Мирославу, но потом вам надоедает и вы решаете уйти...'
	act 'Уйти':minut += 30 & gt'Gaddvor'
end
if $ARGS[0] = 'miragopQW11':
	minut += 5
	horny += 10
	miragopQW = 12
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render','','','Вы долго молчите, не зная с чего начать, а Мирослава все это время смотрит себе под ноги и усиленно краснеет. Наконец вы решаетесь заговорить и Мира, запинаясь и по-прежнему не смотря вам в глаза, говорит, что сама не знает, что на нее тогда нашло, но она себя не контролировала. То ли это она напилась до такой, то ли еще чего, но она теперь сквозь землю готова провалиться со стыда. Вы кое-как успокаиваете ее и говорите, что всякое в жизни бывает, надо просто переступить и жить дальше. Мира искренне благодарит вас за поддержку, но в глаза все равно не смотрит...'
	act 'Уйти':gt $loc, $metka
end
if $ARGS[0] = 'lesb_mira':
	minut += 5
	horny += 5
	miraday = day
	mirahorny = rand(0,80)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/mirakiss1.jpg'
	gs 'zz_render','','','На поляне вы разу подошли к Мире.'
	gs 'zz_render','','',' - Мир, я хочу тебя - прошептали вы ей на ухо и страстно поцеловали её в губы.'
	if mirahorny < 20:act 'Далее':gt 'mirasex','mirakiss'
	if mirahorny >= 20:act 'Далее':gt 'mirasex','foreplay'
end
if $ARGS[0] = 'mira_lesb':
	*clr & cla
	minut += 5
	horny += 5
	miraday = day
	mirahorny = rand(40,80)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/mirakiss4.jpg'
	gs 'zz_render','','','На поляне к вам подошла Мира, озорно улыбаясь.'
	gs 'zz_render','','',' - Светуля, пошалим? - шепнула она вам на ухо и прижав вас к дереву, впилась в губы страстным поцелуем.'
	if horny < 20:act 'Согласиться':gt 'mirasex','mirakiss'
	if horny >= 20:act 'Согласиться':gt 'mirasex','foreplay'
	if horny < 40:
		act 'Отказаться':
			*clr & cla
			minut += 5
			horny -= 5
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/mira_lesb_talk2.jpg'
			gs 'zz_render','','','Вам пришлось приложитить немало сил, чтобы вырваться из её объятий.'
			gs 'zz_render','','',' - Мир, давай не сейчас, - сказали вы, видя немой вопрос в её глазах. - Настроения нет совсем.'
			gs 'zz_render','','',' - Ну ты и бяка, - надула она обиженно губки в ответ.'
			act 'Далее':gt $loc, $metka
		end
	end
end
if $ARGS[0] = 'lesb_talk_mira1':
	minut += 5
	if horny < 40:
		horny = 40
	else
		horny += 5
	end
	dom += 1
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render','','','Вы долго молчите, глядя на Миру, не зная как начать разговор. Но потом все таки решаетесь.'
	gs 'zz_render','','',' - Мира, ты ведь уже всем пацанам в нашей компашке дала, - начали вы. - Так?'
	gs 'zz_render','','',' - Угу, - немного смутившись ответила Мирослава и с подозрением уставилась на вас. - А что?'
	gs 'zz_render','','',' - Да я тут подумала просто, всем дала, всех обслужила, а подругу забыла, - с укором в голосе произнесли вы.'
	gs 'zz_render','','',' - Так ты же не парень, как тебя обслужить то?, - удивилась Мира.'
	gs 'zz_render','','',' - А то ты маленькая и не знаешь, как это девочки девочкам доставляют удовольствие, - ответили вы ей.'
	gs 'zz_render','','',' - Но я же не такая, не эта... эээ... не лесбиянка, - округлила глаза Мира. Но по раскрасневшимся щекам и блеску в глазах, вы поняли, что сама мысль, что она будет отлизывать девочке очень её возбудила.'
	gs 'zz_render','','',' - Не ломайся Мирка, тебе это не идет, - продолжили вы давить на неё. - Короче, или ты сейчас мне делаешь приятно, или я ухожу. Но тогда тебе останется общаться только с хуями деревенских мужиков, про меня можешь забыть.'
	gs 'zz_render','','','Мира задумалась, смешно нахмурив лоб. Но это длилось не долго, возбуждение и перспектива потерять подругу сделали свое дело.'
	gs 'zz_render','','',' - Хорошо Света, я сделаю это, - сказала она опускаясь на колени.'
	act 'Далее':gt 'mirasex','miralick_first'
end
if $ARGS[0] = 'lesb_talk_mira2':
	minut += 5
	horny += 5
	mirasex = 2
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render','','','Вы долго разглядываете Миру с ехидной улыбкой на губах, потом начинаете разговор.'
	gs 'zz_render','','',' - Ну что, Мирка, поздравляю, - сказали вы. - Ты теперь такая же шлюха, как и я. Всем пацанам дала. Так?'
	gs 'zz_render','','','Она попыталась отмолчаться, но вас это не устроило.'
	gs 'zz_render','','',' - Так или нет?, - продолжили вы настаивать на ответе.'
	gs 'zz_render','','',' - Ну так, - не хотя признала она.'
	gs 'zz_render','','',' - А ты догадываешься, что это значит?, - продолжили вы вкрадчивым голосом.'
	gs 'zz_render','','',' - Что? - жутко краснея спросила Мира, хотя явно уже догадывалась куда вы клоните.'
	gs 'zz_render','','',' - Пора должок возвращать, - торжествующим тоном ответили вы и оперевшись на дерево, поманили её пальцем. - Можешь приступать.'
	gs 'zz_render','','','Мира колебалась еще пару мгновений, будто обдумывая что-то, а потом опустилась перед вами на колени.'
	act 'Далее':gt 'mirasex','miralick_first'
end
if $ARGS[0] = 'lesb_talk_mira3':
	minut += 5
	horny += 5
	dom += 1
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render','','','Вы облокотились на дерево и поманили Миру пальцем.'
	gs 'zz_render','','',' - Нужно поработать язычком Мира, - сказали вы. - Приступай.'
	gs 'zz_render','','','Она сразу, уже привычно, опустилась перед вами на колени.'
	act 'Далее':gt 'mirasex','miralick_first'
end
if $ARGS[0] = 'mira_lesb_talk1':
	*clr & cla
	minut += 5
	horny += 5
	dom -= 1
	mirahorny = rand(0,80)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/mira_lesb_talk.jpg'
	if mirainmeadow = 0:'На поляне вы встретили Миру. Увидев вас, она тут же подошла с хитрой улыбкой на губах.'
	if mirainmeadow = 1:'Когда вы пришли на поляну, Мира тут же подошла к вам с хитрой улыбкой на губах.'
	gs 'zz_render','','',' - Света, ты ведь уже всем пацанам в нашей компашке дала, - начала она. - Так?'
	gs 'zz_render','','','Вы попытались отмолчаться, но это не устроило Миру.'
	gs 'zz_render','','',' - Так или нет?, - продолжала настаивать она на ответе.'
	gs 'zz_render','','',' - Ну так, - не хотя признали вы.'
	gs 'zz_render','','',' - Да я тут подумала просто, всем дала, всех обслужила, а подругу забыла, - продолжила Мира глядя вам в глаза.'
	if lesbian = 0:
		gs 'zz_render','','',' - Так ты же не парень, как тебя обслужить то?, - удивилась вы.'
		gs 'zz_render','','',' - А то ты маленькая и не знаешь, как это девочки девочкам доставляют удовольствие, - ответили она вам.'
	else
		gs 'zz_render','','','Вы, хотя уже догадывались куда она клонит, но все равно медлили с ответом.'
		gs 'zz_render','','',' - Да ладно, не ломайся Светик, тебе это не идет, - продолжила она давить устраиваться поудобнее на ближайшем камне.'
		gs 'zz_render','','',' - Хорошо Мира, я сделаю это, - сказали вы опускаясь на колени.'
		gs 'zz_render','','','"В конце концов почему бы не сделать подруге приятно?" - подумали вы про себя.'
	end
	if lesbian = 0:
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 30
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/mira_lesb_talk2.jpg'
			gs 'zz_render','','','От этих слов вы ошарашено уставились на Миру.'
			gs 'zz_render','','',' - Но я же не такая, не эта... эээ... не лесбиянка, - попытались отнекиваться вы. Но сама мысль, что вы будете отлизывать девочке, прямо здесь, посреди поляны, заставляла вашу писю предательски зазудеть.'
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/new/mira_lesb_talk3.jpg'
				gs 'zz_render','','','Вы еще надеялись, глядя на Миру, что она передумает.'
				gs 'zz_render','','',' - Да ладно, не ломайся Светик, - сказала Мира, взяв вас за майку и потянув за собой к ближайшему камню. - Маленькие шлюшки должны всегда доставлять радость своим подругам.'
				gs 'zz_render','','','Устроившись по удобнее она нетерпеливо посмотрела на вас:'
				gs 'zz_render','','',' - Ну что ты медлишь, я жду.'
				gs 'zz_render','','',' - Хорошо Мира, я сделаю это, - сдались наконец вы, опускаясь на колени. "В конце концов почему бы не сделать подруге приятно?" - думая про себя.'
				act 'Далее':gt 'mirasex','lickmira_start'
			end
		end
	else
		act 'Далее':gt 'mirasex','lickmira_first'
	end
end
if $ARGS[0] = 'mira_lesb_talk2':
	minut += 5
	horny += 5
	mirasex = 2
	mirahorny = rand(0,80)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/mira_lesb_talk.jpg'
	gs 'zz_render','','','Когда вы пришли на поляну, Мира тут же подошла к вам с хитрой улыбкой на губах.'
	gs 'zz_render','','',' - Ну что, Светик, поздравляю, - сказала она. - Ты теперь такая же шлюха, как и я. Всем пацанам дала. Так?'
	gs 'zz_render','','','Вы попытались отмолчаться, но это не устроило Миру.'
	gs 'zz_render','','',' - Так или нет?, - продолжала настаивать она на ответе.'
	gs 'zz_render','','',' - Ну так, - не хотя признали вы.'
	gs 'zz_render','','',' - А ты догадываешься, что это значит?, - продолжила Мира вкрадчивым голосом.'
	gs 'zz_render','','',' - Что?, - спросили вы, хотя уже догадывались куда она клонит.'
	gs 'zz_render','','',' - Пора должок возвращать, - торжествующим тоном ответила Мира и стала устраиваться поудобнее на ближайшем камне. - Можешь приступать.'
	gs 'zz_render','','','"Ну что же, все логично.", - подумали вы опускаясь перед ней на колени.'
	act 'Далее':gt 'mirasex','lickmira_first'
end
if $ARGS[0] = 'mira_lesb_talk3':
	minut += 5
	horny += 5
	dom -= 1
	mirahorny = rand(40,80)
	miraday = day
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/mira_lesb_talk3.jpg'
	if mirainmeadow = 0:
		gs 'zz_render','','','На поляне вы встретили Миру. Увидев вас, она тут же подошла к вам с возбужденным лицом.'
		gs 'zz_render','','',' - А вот ты где Светик, а я тебя ищу, ищу, - сказала она. - Нужно поработать язычком.'
		gs 'zz_render','','','И начала устраиваться поудобнее.'
	else
		gs 'zz_render','','','Когда вы пришли на поляну, Мира тут же повернулась к вам с возбужденным лицом.'
		gs 'zz_render','','',' - Нужно поработать язычком Светик, - сказала она и начала устраиваться поудобнее. - Приступай.'
	end
	gs 'zz_render','','','Вы уже привычно опустились перед ней на колени.'
	act 'Далее':gt 'mirasex','lickmira_first'
end
if $ARGS[0] = 'mira_lesb_talk4':
	minut += 20
	horny += 5
	dom -= 1
	mirahorny = rand(40,80)
	miraday = day
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render','','','Идя по деревне вы встретили Миру. Увидев вас, она тут же подошла к вам с возбужденным лицом.'
	gs 'zz_render','','',' - А вот ты где Светик, а я тебя ищу, ищу, - сказала она. - Пошли-ка прогуляемся на нашу поляну.'
	gs 'zz_render','','','И схватив вас за руку, буквально поволокла за собой. Вы шли вслед за Мирой, слыша впереди её возбужденное сопение, прекрасно понимая, зачем она вас туда ведет. Придя на поляну Мира тут же повернулась к вам с возбужденным лицом.'
	gs 'zz_render','','',' - Нужно поработать язычком Светик, - сказала она и начала устраиваться поудобнее. - Приступай.'
	gs 'zz_render','','','Вы уже привычно опустились перед ней на колени.'
	act 'Далее':gt 'mirasex','lickmira_first'
end
if $ARGS[0] = 'mirameadow':
	*clr & cla
	minut += 2
	voyeurism += 1
	gs 'stat'
	gs'time'
	if meadow = 3 and mirainmeadow = 0 and mirasextimes < 15 and temper >= 15 and temper < 25 and sunWeather >= 0 and temp = 0:
		*clr & cla
		minut += 2
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr.jpg'
		gs 'zz_render','','','Вы уже собрались было к ней подойти, но тут с удивлением замечаете, как она расстегивает штаны... Вы, повинуясь извечному женскому любопытству, решаете понаблюдать за ней...'
		act 'Смотреть':
			*clr & cla
			minut += 2
			horny += 5
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr1.jpg'
			gs 'zz_render','','','Мирослава, с силой приподнимая трусики так, что они врезаются ей между половых губ, воровато оглядывается по сторонам, но вас, конечно же, из-за густых зарослей не замечает, а потому продолжает...'
			act 'Смотреть':
				*clr & cla
				minut += 2
				horny += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr2.jpg'
				gs 'zz_render','','','Она пару секунд медленно гладит рукой себя по животе, а после, уставившись взглядом куда-то в пустоту, так же неспешно ныряет ею себе в трусы, начиная поглаживать промежность.'
				act 'Смотреть':
					*clr & cla
					minut += 1
					horny += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr3.jpg'
					gs 'zz_render','','','Внезапно она вытягивает из промежности руку и заглядываете себе в трусы, что-то там высматривая.'
					act 'Смотреть':
						*clr & cla
						minut += 2
						horny += 10
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr4.jpg'
						gs 'zz_render','','','Но вскоре ей это надоедает и она снимает с себя куртку, а за ней и кофточку, обнажая вам свои небольшие упругие грудки.'
						act 'Смотреть':
							*clr & cla
							minut += 2
							horny += 10
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr5.jpg'
							gs 'zz_render','','','Сняв кофту, она зачем-то снова надевает на себя куртку и запустив одну руку себе в трусики, другой начинает ласкать грудь.'
							act 'Смотреть':
								*clr & cla
								minut += 10
								horny += 20
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr6.jpg'
								gs 'zz_render','','','Через минуту она приваливается спиной к ближайшему дереву, ее штаны спадают до колен и она, продолжая одной рукой мять и тискать свою грудь, другой доводит себя до оргазма. Вы смотрите еще пару минут в надежде на продолжение, но Мира уже приходит в себя и начинает одеваться, поэтому вы решаете поспешно ретироваться...'
								act 'Уйти':minut += 30 & gt'Gaddvor'
							end
						end
					end
				end
			end
		end
	elseif meadow = 3 and mirainmeadow = 0 and mirasextimes < 15 and temper >= 25 and temper < 30 and sunWeather >= 0 and temp = 0:
		*clr & cla
		minut += 2
		horny += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr7.jpg'
		gs 'zz_render','','','Мира стоит, прислонившись спиной к дереву и ласкает себя.'
		act 'Смотреть':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr8.jpg'
			gs 'zz_render','','','Она несколько минут продолжает играть с собой, а потом прекращает и пару мгновений задумчиво смотрит на валяющееся рядом бревно...'
			act 'Смотреть':
				*clr & cla
				minut += 2
				horny += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr9.jpg'
				gs 'zz_render','','','Наконец, приняв решение, она подходит к нему и начинает снимать с себя трусики.'
				act 'Смотреть':
					*clr & cla
					minut += 1
					horny += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr10.jpg'
					gs 'zz_render','','','Сняв трусы, она осторожно присаживается на бревно и пробует на нем немного покачаться, проверяя, видать, на прочность...'
					act 'Смотреть':
						*clr & cla
						minut += 10
						horny += 20
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr11.jpg'
						gs 'zz_render','','','Удостоверившись, что нечаянно не свалится с него, Мира начинает ласкать себя, при этом не забывая оглядываться по сторонам, пока, наконец, не доводит себя до оргазма... Вы смотрите еще пару минут в надежде на продолжение, но Мира уже приходит в себя и начинает одеваться, поэтому вы решаете поспешно ретироваться...'
						act 'Уйти':minut += 30 & gt'Gaddvor'
					end
				end
			end
		end
	elseif meadow = 3 and mirainmeadow = 0 and mirasextimes < 15 and temper >= 30 and sunWeather >= 0 and temp = 0:
		*clr & cla
		minut += 2
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr12.jpg'
		gs 'zz_render','','','Вы успеваете как раз на самое интересное. Мира стоит на пеньке, возле которого валяется растеленное покрывало, и задрав повыше блузку, наслаждается прохладным ветерком, поглаживая рукой себе промежность.'
		act 'Смотреть':
			*clr & cla
			minut += 2
			horny += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr13.jpg'
			gs 'zz_render','','','Но ей это вскоре надоедает и она, словно нарочно, повернувшись к вам попкой, стаскивает с себя юбку.'
			act 'Смотреть':
				*clr & cla
				minut += 5
				horny += 15
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr14.jpg'
				gs 'zz_render','','','Сделав это, она присаживается на пенек и продолжает себя ласкать, но через пару минут и этого ей оказывается мало...'
				act 'Смотреть':
					*clr & cla
					minut += 1
					horny += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr15.jpg'
					gs 'zz_render','','','Пройдясь от пня до покрывала, Мира снимает с себя кофточку и остается только в одних трусиках.'
					act 'Смотреть':
						*clr & cla
						minut += 10
						horny += 30
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/MiraMeadowMastr16.jpg'
						gs 'zz_render','','','Которые сразу же снимает вслед за блузкой и оставшись в чем мать родила, на корточках доводит себя до оргазма. Вы смотрите еще пару минут в надежде на продолжение, но Мира уже приходит в себя и начинает одеваться, поэтому вы решаете поспешно ретироваться...'
						act 'Уйти':minut += 30 & gt'Gaddvor'
					end
				end
			end
		end
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 2 and temper >= 20 and sunWeather >= 0 and temp = 1:
		*clr & cla
		minut += 2
		horny += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowSex.jpg'
		gs 'zz_render','','','Они болтают между собой, попутно раздеваясь, но о чем именно они говорят, вам не удается услышать из-за растояния.'
		act 'Смотреть':
			*clr & cla
			minut += 5
			horny += 25
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowSex1.jpg'
			gs 'zz_render','','','Через пару минут Мирослава ложится перед Митькой на покрывало и призывно расставляет перед ним ноги. Тот, не заставляя себя ждать, тут же пристраивается у нее между ног и начинает грубо и сильно вколачивать в нее свой член, отчего она начинает громко и охать и подвизгивать.'
			act 'Смотреть':
				*clr & cla
				minut += 5
				horny += 15
				if miragopQW = 2:miragopQW = 3
				mirasextimes += 1
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/MiraMeadowSex2.jpg'
				gs 'zz_render','','','Минуть через пятнадцать Митька наконец кончает Мирославе на живот и еще немного полежав, они начинают собираться...'
				act 'Уйти':minut += 30 & gt'Gaddvor'
			end
		end
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 8 and temper >= 20 and sunWeather >= 0 and temp = 2:
		*clr & cla
		minut += 2
		horny += RAND(15,30)
		temp = RAND(0,1)
		gs 'stat'
		if temp = 0:
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowAnal.jpg'
			gs 'zz_render','','','Мирка прыгает задницей на митькином члене, каждый раз шлепаясь ягодицами о его бедра, и громко постанывает.'
		else
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowAnal1.jpg'
			gs 'zz_render','','','Мирка, раздвинув руками ягодицы, стоит на четвереньках и громко охает, когда Митька, полностью вынимая, вгоняет в ее распахнутую задницу свой член.'
		end
		act 'Смотреть':
			*clr & cla
			minut += 5
			horny += RAND(15,30)
			mirasextimes += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowAnal2.jpg'
			gs 'zz_render','','','Через пару минут Митька сильно шлепает ее по заднице и Мира быстро разворачивается, встает перед ним на колени и далеко высунув язык, принимает на свое лицо его теплую сперму...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		end
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 11 and temper >= 20 and sunWeather >= 0 and temp = 3:
		*clr & cla
		minut += 2
		horny += 15
		gs 'stat'
		if temper < 20:
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ.jpg'
			gs 'zz_render','','','Она с увлечением сосет его член и видит ямки на ее щеках, когда она всасывает его в свою глотку...'
			act 'Смотреть':
				*clr & cla
				minut += 5
				horny += RAND(15,30)
				mirasextimes += 1
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ1.jpg'
				gs 'zz_render','','','Но, видимо, вы немного опоздали, потому что уже через пару минут Колямба кладет руку Мирославе на затылок и одним резком рывком насаживает на себя. Она сначала давится и кашляет отнеожиданности, но потом все же справляется с рвотными позывами и высунув немного язык, послушно глотает его сперму...'
				act 'Уйти':minut += 30 & gt'Gaddvor'
			end
		else
			*clr & cla
			minut += 5
			horny += 30
			mirasextimes += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ2.jpg'
			gs 'zz_render','','','Она в одних шлепанцах стоит раком, оттопырив как раз в вашу сторону свою задницу, и громко охает, когда Колямба шлепает ее по промежности своими яйцами, вгоняя в ее влагалище свой член. Мирослава скребет руками по земле и выгибается как кошка, при этом что-то в перерывах между оханьями говоря Колямбе. Но тот, кажется. не обращает на это совершенно никакого внимания, продолжая долбить ее в киску, и вскоре доводит девушку до оргазма, а через минуту кончает и сам...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		end
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 11 and temper >= 20 and sunWeather >= 0 and temp = 4:
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		if temper < 25:
			minut += 5
			horny += 50
			mirasextimes += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ5.jpg'
			gs 'zz_render','','','Васян с энтузиазмом вгоняет член в рот привязанной к дереву Мирославы. Та давится и кашляет, но в то же время сама двигает головой навстречу члену. Через пару минут Васян откидывает назад голову и с блаженным рыком кончает ей в рот...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		else
			minut += 5
			horny += 40
			mirasextimes += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ6.jpg'
			gs 'zz_render','','','Полностью голая Мирослава, согнувшись, стоит перед Васяном и усиленно подставляет ему попку, в которую он и вгоняет свой член. Судя по ее похотливым стонам, ей вполне нравится, что ее имеют в задницу, но уже через пару минут Васян вынимает из нее свой член и спускает ей на ягодицы...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		end
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 11 and temper >= 20 and sunWeather >= 0 and temp = 5:
		*clr & cla
		minut += 5
		horny += 20
		gs 'stat'
		if temper < 25:
			minut += 5
			horny += 40
			mirasextimes += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ3.jpg'
			gs 'zz_render','','','Они оба совершенно голые и Мира, далеко оттопырив попку, с чувством отсасывает кайфующему Васяну. Через пару минуту вы видите, как Мирослава насаживается головой на его член и затихает, глотая сперму...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		else
			minut += 5
			horny += 30
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ4.jpg'
			gs 'zz_render','','','Они оба совершенно голые и Мира с похотливыми визгами, словно бешеная, скачет на Васькином члене. Тот долго такого темпа не выдерживает и бесцеремонно сбросив с себя наездницу, кончает ей на ягодицы...'
			act 'Уйти':minut += 30 & gt'Gaddvor'
		end
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 11 and temper >= 20 and sunWeather >= 0 and temp = 6:
		*clr & cla
		minut += 5
		horny += 25
		mirasextimes += 1
		gs 'stat'
		if temper < 25:
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ7.jpg'
			gs 'zz_render','','','Мира на коленях стоит между тремя дружками и с удовольствием отсасывает их члены. Вы наблюдаете, как они по очереди спукают ей кто в рот, кто на грудь, а кто просто на лицо...'
		else
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ8.jpg'
			gs 'zz_render','','','Мира на корточках сидит между тремя дружками и с удовольствием чавкает их членами. Вы наблюдаете, как они по очереди спукают ей кто в рот, а кто просто на лицо...'
		end
		act 'Уйти':minut += 30 & gt'Gaddvor'
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 11 and temper >= 20 and sunWeather >= 0 and temp = 7:
		*clr & cla
		minut += 5
		horny += 25
		if miragopQW < 20: miragopQW += 1
		gs 'stat'
		if temper < 25:
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ11.jpg'
			gs 'zz_render','','','Мира на корточках сидит перед одним из пацанов и как раз принимает себе в рот его сперму. Облизав и спрятав в штаны его член, она то же самое прожелывает с другим...'
		elseif temper >= 25 and temper < 30:
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ10.jpg'
			gs 'zz_render','','','Пацаны, вдвоем трахая Миру в рот и в киску, о чем-то со смехом разговаривают между собой. Мирослава же вторит им своими стонами и плямканьями... Минут через пятнадцать они заканчивают и начинают собираться...'
		else
			gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ9.jpg'
			gs 'zz_render','','','Все трое почти голые и одному из них Мира как раз отсасывает, а второй, судя по всему, уже кончил, а потому просто лапает ее грудь и шебуршит рукой у нее между похотливо рассталвенных ног...'
		end
		act 'Уйти':minut += 30 & gt'Gaddvor'
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW > 33 and temper >= 20 and sunWeather >= 0 and temp = 8:
		*clr & cla
		minut += 30
		horny += 25
		miragopQW += 1
		mirasextimes += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowBJ12.jpg'
		gs 'zz_render','','','Миры за ихними телами почти не видно, только кусок голого зада да покачивающиеся в кроссовках ноги. Вы с полчаса наблюдаете за тем, как мужики по очереди ебут безвольную и уставшую Мирославу, но потом вам надоедает и вы решаете уйти...'
		act 'Уйти':minut += 30 & gt'Gaddvor'
	end
	if meadow = 3 and mirainmeadow = 0 and miragopQW >= 20 and temper >= 20 and sunWeather >= 0 and temp = 9:
		*clr & cla
		minut += 10
		horny += 25
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/MiraMeadowS.jpg'
		gs 'zz_render','','','Она стоит на четвереньках к вам спиной и болезненно, но довольно постанывая, дрочит свою попку кочаном кукурузы.'
		act 'Уйти':minut += 30 & gt'Gaddvor'
	end
end