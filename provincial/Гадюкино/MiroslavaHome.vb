$metka = $ARGS[0]
$loc = $CURLOC
minut += 5
mira_temp = rand(0,15)
grandpa_guest = 0
gs 'stat'
gs 'time'
gs 'zz_render', 'Двор Мирославы', func('zz_funcs','mk_image','qwest/gadukino/MiraHome')
if hour >= 7 and hour <= 22:
	temp = RAND(0,30)
	if month > 5 and month < 9 and sunWeather >= 0 and hour > 13 and hour < 18 and graze_cow = 0 and (week = 1 or week = 3 or week = 5):
		grandpa_guest = 1
		gs 'zz_render', '', '','Во дворе, возле дома ,беседуют ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+' и <a href="exec: gt ''mirafather''">'+iif(MiraFatherQW < 10,'отец Миры','Афанасий')+'</a>.'
	else
		gs 'zz_render', '', '','Возле дома занимается хозяйственными делами <a href="exec: gt ''mirafather''">'+iif(MiraFatherQW < 10,'отец Миры','Афанасий')+'</a>.'
	end
	!if month >= 5 and month <= 9 and hour >= 18 and hour <= 21 and temp > 25:'Ненадолго приехал на своем мотоцикле из города <a href="exec: dynamic $mirabrother ">брат Миры</a>.'
	if mira_no_home = 0:
		act 'Позвать Мирославу':
			if mira_temp >= 10 and sunWeather >= 0 and temper >= 20 and hour < 20 and mirainhome = 0 and Mira_no = 0:
				*clr & cla
				minut += 2
				mirainriver = 1
				mira_no_home += rand(1,4)
				gs 'stat'
				gs 'zz_render', '', 'qwest/gadukino/MiraFather.jpg','Отец Миры сказал вам, что её нет дома, она ушла на речку.'
				act 'Уйти':gt 'miroslavahome'
			elseif mira_temp >= 10 and sunWeather >= 0 and hour < 20 and mirainhome = 0 and Mira_no = 0:
				*clr & cla
				minut += 2
				mira_no_home += rand(1,4)
				gs 'stat'
				gs 'zz_render', '', 'qwest/gadukino/MiraFather.jpg','Отец Миры сказал вам, что её нет дома.'
				act 'Уйти': gt 'miroslavahome'
			else
				mirainhome = 1
				mirainriver = 0
				mira_guest = 0
				mirainmeadow = 0
				mirainforest = 0
				gt 'Miroslava'
			end
		end
	end
else
	gs 'zz_render', '', '','Слишком '+iif(hour > 3 and hour < 7,'рано','поздно')+', семья Мирославы спит, незачем будить людей понапрасну.'
end
act 'Уйти':mirainhome = 0 & gt 'gadukino'
if Mira_no > 0 and mirafathertalk = 0 and miraday ! daystart:
	*clr & cla
	minut += 10
	mirafathertalk = 1
	gs'stat'
	gs 'zz_render', '', 'qwest/gadukino/MiraFather.jpg','Увидя вас во дворе, отец Миры направился в вашу сторону.**\\\- <<$name>>, постой. Поговорить нужно, -/// сказал он подойдя к вам поближе.**Вы остановились и посмотрели на него с испугом.**\\"Неужели Мира ему все расказала?"// метались в вашей голове панические мысли.**\\\- <<$name[1]>>, ты не знаешь, что с Мирой происходит?, -/// спросил Афанасий глядя вам в глаза.**\\- Н-нет, а что с ней?, -// растерянно спросили вы, ожидая услышать поток брани в вашу сторону.**\\\- Да вот не знаю. Сидит все время дома, со двора совсем не выходит, мне ничего не расказывает, -/// ответил отец Миры.**\\- Ой, даже не знаю, -// сказали вы, стараясь, чтобы это прозвучало как можно больше правдоподобно и сделав честные глаза.\\ - Может обидел кто из местных, или поругалась с кем...//**\\\- Ладно, думаю это пройдет скоро. Но ты, <<$name[1]>>, заходи к нам в гости, думаю в твоей компании Мире лучше будет, чем одной. Может отойдет быстрее, -/// сказал отец Миры на прощание и ушел заниматься прерванной работой.**\\"Пронесло," //подумали вы глядя ему в след и облегченно выдыхая.'
	act 'Далее':gt 'miroslavahome'
end
if temper >= 20 and sunWeather >= 0 and miragopQW = 7 and hour >= 8 and hour <= 18:
	*clr & cla
	gs 'zz_render', '', 'qwest/gadukino/MiraQW7.jpg','Зайдя во двор, вы замечаете Мирославу, копающуюся у себя на огороде. Она стоит раком и, к вашему изумлению, светит голой промежностью...'
	act 'Подойти к ней':
		*clr & cla
		miraQW = 1
		minut += 15
		gs 'stat'
		if miragopQW = 0:
			gs 'zz_render', '','qwest/gadukino/Mira.jpg"'
		elseif miragopQW > 0 and miragopQW < 4:
			gs 'zz_render', '','qwest/gadukino/Mira3.jpg'
		elseif miragopQW >= 4 and miragopQW < 8:
			gs 'zz_render', '','qwest/gadukino/mira0,'+rand(0,5)+'.jpg'
		elseif miragopQW >= 8 and miragopQW < 12:
			gs 'zz_render', '','qwest/gadukino/mira1,'+rand(0,2)+'.jpg'
		elseif miragopQW >= 12 and miragopQW < 20:
			gs 'zz_render', '','qwest/gadukino/mira2,'+rand(0,5)+'.jpg'
		elseif miragopQW >= 20:
			gs 'zz_render', '','qwest/gadukino/mira3,'+rand(0,3)+'.jpg'
		end
			gs 'zz_render', '', '','Вы тихонько подкрадываетесь к ней, но она вас замечает и оборачивается, тут же стремительно краснея. Вы пару секунд молча смотрите на нее, а потом бесцеремонно спрашиваете, почему она без трусов. Мирослава, отведя глаза, мнется с ноги и на ногу, объясняя, что так получилось, жарко очень, вот она и... Вы тут же напоминаете ей о втором желании и просите присесть. Мирослава неохотно соглашается, а когда садится, вы тут же приказываете ей, чтобы она опять показала вам промежность, а то вы плохо рассмотрели. Девушка мямлит что-то невнятное, но потом все же на полминуты задирает юбку и дает вам хорошенько рассмотреть свою промежность.'
		act 'Смотреть':
			*clr & cla
			minut += 2
			horny += 15
			gs 'stat'
			gs 'zz_render', '', 'qwest/gadukino/Mirawish2.jpg','Вы наслаждаетесь открывшимся видом, после чего вам в голову приходит безумная идея и вы решаете загадать второе желание. Мира уныло говорит, что думала, будто это и было второе желание, но вы отвечаете, что просто не удержались, после чего гворите ей, чтобы шла за вами.'
			act 'Выйти на дорогу':
				*clr & cla
				minut += 45
				miragopQW = 8
				gs 'stat'
				gs 'zz_render', '', 'qwest/gadukino/Mirawish2_1.jpg','Выйдя на дорогу вы говорите Мирославе, чтобы она изобразила из себя проститутку, это и будет вторым желанием. Мира уныло кивает головой, оглядывается по сторонам и видя, что улица безлюдна, выполняет ваше желание...'
				act 'Уйти':gt'gadukino'
			end
		end
	end
end
$mirabrother = {
	*clr & cla
	minut += 2
	gs 'stat'
	gs 'zz_render', '', 'qwest/gadukino/MiraBrother.jpg'
	act 'Попросить прокатить на мотоцикле':
		*clr & cla
		minut += 2
		gs 'stat'
		gs 'zz_render', '', 'qwest/gadukino/MiraBrother.jpg','Вы просите брата Миры прокатнуть вас на своем мотоцикле.'
		if vnesh < 40:
			if miraQW > 20:
				gs 'zz_render', '', '','Он оценивающим взглядом осматривает вас с ног до головы и отвечает, что как-нибудь в другой раз.'
			else
				gs 'zz_render', '', '','Он с удивлеением пару секунд смотрит на вас, а потом спрашивает, кто вы вообще такая...'
			end
			act 'Уйти':gt 'gadukino'
		else
			if tanga > 0:
				gs 'zz_render', '', '','\\\- Без проблем, -/// отвечает он вам, окидывая вас странным взглядом.\\\ - Но мой мотоцикл катает на себе девушек только без трусиков и я ничего не могу с этим поделать! Вредный он у меня, чертяка...///'
				act 'Уйти':gt 'gadukino'
			else
				gs 'zz_render', '', '','\\\- Без проблем, -/// отвечает вам парень, а потом добавляет с ехидной улыбкой:\\\- Но сначала присядь на него, он проверит... Ну, ты знаешь, какой он у меня привередливый...///'
				act 'Сесть на мотоцикл':
					*clr & cla
					horny += 10
					minut += 2
					gs 'stat'
					gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto.jpg','Вы, закинув ногу, быстро перекидаете ее через железного коня и садитесь на мотоцикл, кладя руки на руль. Брат Миры с довольной улыбкой неотрывно смотрит вам в промежность, которая открывает ему отличный вид вашей голой киски.**\\\- Отлично, -/// улыбается парень.\\\ - Просто отлично! У тебя классная киска, думаю, мой друг не против прокатить её на себе. Нуу, ты ведь понимаешь, да? Прокачу тебя с лихим ветерком, если ты потом сделаешь ротиком мне приятно...///'
					act 'Согласиться':
						*clr & cla
						horny += 10
						minut += 2
						dom -= 1
						gs 'stat'
						gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto.jpg','\\\- Ну тогда вставай, сейчас достану тебе шлем.///'
						act 'Встать':
							*clr & cla
							minut += 2
							gs 'stat'
							gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto1.jpg','Вы встаете с мотоцикла и он, откинув седушку, достает еще один шлем и протягивает вам. Вы надеваете шлем и парень тут же садится на мотоцикл, головой кивая, чтобы вы садились сзади него.'
							act 'Сесть':
								*clr & cla
								hour = 22
								manna = 100
								gs 'stat'
								gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto2.jpg','Вы садитесь на мотоцикл и парень тут же заводит его, после чего с бешеной скоростью катает вас по шоссе, пока наконец не сворачивает в Гадюкино и не останавливается. '
								act 'Встать':
									*clr & cla
									horny += RAND(5,15)
									minut += 2
									gs 'stat'
									gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto3.jpg','Он встает с мотоцикла вслед за вами и подойдя сзади, уверенно начинает лапать вас...'
									act 'Стоять':
										*clr & cla
										horny += RAND(5,15)
										minut += 2
										gs 'stat'
										gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto4.jpg','Вы, памятуя об уговоре, послушно стоите, пока его руки властно мнут вашу грудь и гладят промежность.'
										act 'Стоять':
											*clr & cla
											horny += RAND(5,15)
											minut += 2
											gs 'stat'
											gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto5.jpg','Вы чувствуете, как его ладонь трет вашу промежность, теребя половые губы. Через минуту парень разворачивает вас к себе и настойчиво давит вам на плечи...'
											act 'Сесть на корточки':
												*clr & cla
												horny += RAND(5,15)
												minut += 2
												gs 'stat'
												gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto6.jpg','Вы послушно присаживаетесь перед ним на корточки и расстегиваете ему штаны. Приспустив их вместе с трусами, вы видите прямо перед своим лицом его набухающий член...'
												act 'Сосать':
													*clr & cla
													horny += RAND(10,20)
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto7.jpg','Вы еще пару секунд завороженно смотрите, как он набирает силу, а потом, широко открыв рот, нежно вбираете его в себя и тут же выпускаете, после чего берете в руку и начинаете сосать его и одновременно надрачивать рукой.'
													act 'Глотать':
														*clr & cla
														horny += RAND(15,25)
														minut += 5
														gs 'zz_funcs', 'cum', 'lip'
														swallow += 1
														bja += 1
														if mirabrosextime = 0:mirabrosextime = 1 & guy += 1
														gs 'stat'
														gs 'zz_render', '', 'qwest/gadukino/MiraBroMoto8.jpg','Через пару минут вам в рот неожиданно ударяет теплая вязкая сперма и вы поспешно начинаете ее глотать. Мирославин брат еще минуту стоит, блаженно закрыв глаза, пока вы обсасываете его член, а потом застегивает штаны, садится на мотоцикл и уезжает...'
														act 'Идти домой':gt 'Gadhouse'
													end
												end
											end
										end
									end
								end
							end
						end
					end
					act 'Отказаться':gt 'gadukino'
				end
			end
		end
	end
	act 'Уйти':gt 'miroslavahome'
}