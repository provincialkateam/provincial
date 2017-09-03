if $ARGS[0] = 'youry_start':
	*clr & cla
	jouryQW += 1
	gs 'zz_render', '', 'images/city/south/south_office/cleaning_office.jpg','Вы набрали воды в ведро и пошли в офис захватив швабру с тряпкой. Все сотрудники вышли из офиса, кроме краснолицего блондина.'
	act 'Далее':
		*clr & cla
		gs 'zz_render', '', 'images/city/north/youry/youry.jpg','Он подошел к вам и заметно нервничая сказал вам тихо:**<do>- Привет, меня зовут Юра. Ты мне очень понравилась. Может сходим куда-нибудь после работы?</do>'
		act 'Нет':
			*clr & cla
			jouryQWNo = 1
			gs 'zz_render', '', 'images/city/south/south_office/cleaning_office.jpg','Вы ответили Юрию отказом. После окончания уборки вы зашли к коменданту здания Борису Ивановичу и получили заработанные сто рублей.'
			act 'Выйти': gt'south_office','start'
		end
		act 'Да':
			cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', '','Юрий сказал что он сейчас закончит работу и встретит вас на проходной в здание.**После выполненной работы вы зашли к коменданту здания Борису Ивановичу. Он дал вам 100 рублей за работу.**Когда вы вышли от коменданта, на проходной вас уже ждал Юрий. Он довольно сильно взволнован и кажется, как будто он лом проглотил. Не зная что сказать он выпалил:**<do>- Может поедем ко мне? Кино посмотрим, шампанского выпьем, поговорим...</do>'
			act 'Нет':jouryQWNo = 1 & gt'south_office','start'
			act 'Ехать с Юрием': gt 'youry','qwest'
		end
	end
end
if $ARGS[0] = 'youry_talk':
	*clr & cla
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/city/north/youry/youry.jpg','Юрий подошел к вам и сказал:**<do>- <<$name[1]>>, может сходим попьем кофе?</do>'
	act 'Нет': gt'south_office','start'
	act 'Пить кофе':
		*clr & cla
		minut += 30
		son += 3
		water = 24
		gs'stat'
		gs 'zz_render', '', 'images/city/south/south_office/cofee.jpg','Вы пошли в кафе, где Юрий заказал кофе. Вы сели за столик и стали пить. Юрий мучительно соображает, что бы сказать. Он совершенно не обладает даже тенью чувства юмора и очень скованы. Очевидно вы ему нравитесь, но он не знает, что ему делать. Когда кофе был допит Юрий предложил поехать к нему.'
		act 'Нет': gt'south_office','start'
		act 'Ехать с Юрием': gt 'youry','qwest'
	end
end
if $ARGS[0] = 'youry_talk2':
	*clr & cla
	gs 'zz_render', '', 'images/city/south/south_office/cleaning.jpg','Вы вошли в кабинку туалета и начали драить унитаз. В туалете хлопнула дверь и кто то вошел, вы выглянули из кабинки и увидели Юрия.'
	act 'Далее':
		*clr & cla
		gs 'zz_render', '', 'images/city/north/youry/youry.jpg','Увидев вас он подошел и сказал:**<do>- <<$name>>, не подходи ко мне в офисе. Ну ты же понимаешь, коллектив не поймет, если узнает, что я встречаюсь с уборщицей...</do>'
		act 'Ты меня стесняешься?':
			*clr & cla
			gs 'zz_render', '', 'images/city/north/youry/youry.jpg','Вы оторвались от унитаза и взглянув Юрию в глаза спросили:**<dh>- Ты меня стесняешься?</dh>**Юрий замялся**<do>- Ну не то что бы стесняюсь, но ты пойми, я менеджер, а ты уборщица. Нас не должны видеть вместе. Но я хочу с тобой продолжать дальше встречаться. Ты знаешь где я живу, заезжай ко мне после четырёх вечера...</do>'
			act 'Да пошел ты':
				*clr & cla
				dom += 1
				jouryResult = 1
				gs 'zz_render', '','images/city/south/south_office/fuck.jpg''Вас оскорбило подобное поведение Юрия и вы не долго думая послали его. Он развернулся и ушел из туалета.**Вы закончили работу и забрав у Бориса Ивановича сто рублей рублей, ушли.'
				act 'Выйти':gt'south_office','start'
			end
			act 'Ладно':
				*clr & cla
				dom -= 1
				jouryResult = 10
				gs 'zz_render', '', 'images/city/south/south_office/cleaning.jpg','Юрий видит в вас только дыру для своего члена. Но вы смирились с этим и согласились ездить к нему домой. Юрий довольно кивнул и вышел из туалета.**Вы вымыли пол в туалете и надраили все унитазы и писсуары до блеска, после чего получив 100 рублей за работу, ушли.'
				act 'Выйти':gt'south_office','start'
			end
		end
	end
end
if $ARGS[0] = 'stasik_work':
	*clr & cla
	gs 'zz_render', '', 'images/city/south/south_office/cleaning.jpg', 'Вы надраивали унитаз до блеска и в этот момент услышали, как в туалет кто то вошел. Обернувшись вы увидели мужчину. Внезапно вы узнали его - это Стас, с ним и его другом Валерой вы познакомились на пляже.'
	act 'Далее':
		*clr & cla
		gs 'zz_render', '', 'images/city/south/stas/stas.jpg', 'Стас тоже видимо вас узнал и подошел к вам:**<do>- Привет <<$name[2]>>! Ты оказывается уборщицей работаешь?</do>'
		act 'Я подрабатываю, деньги нужны':
			cla
			svQW = 2
			gs 'zz_render', '', '', '<dh>- Я подрабатываю, -</dh> пожали вы плечами.<dh> - Мне нужны деньги.</dh>**<do>- Ну для привлекательной девушки я могу найти более достойную подработку, -</do> улыбнулся Стасик.<do> - Мне как раз нужны мерчендайзеры.</do>**<dh>- Можно подробней?, -</dh> спросили вы.**<do>- Все очень просто, -</do> ответил он.<do> - В северном, центральном и Южном районах находятся супермаркеты. Ты будешь заходить в наш офис, брать задание на работу, потом ехать во все эти супермаркеты и расставлять там нашу продукцию согласно заданию. На кассе возьмешь чек подтверждающий то, что ты была на работе. После этого ты являешься в наш офис и мы выплачиваем тебе вознаграждение - 500 рублей. Работы у тебя будет на несколько часов. Трудовую я с тебя не спрашиваю. Ну так как?</do>'
			act 'Не интересует':gt'south_office','start'
			act 'Я согласна':
				*clr & cla
				svQW = 3
				gs'stat'
				gs 'zz_render', '', 'images/city/south/south_office/cleaning.jpg', 'Вы согласились и Стас довольно кивнул, после чего вышел из туалета. Вы закончили работу и отправились к Борису Ивановичу за деньгами.'
				act 'Уйти': gt 'south_office','start'
			end
		end
	end
end
if $ARGS[0] = 'stasik_work2':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/stas.jpg', 'Вы подошли к сидевшему за столом Стасу.**<dh>- Стас, я '+iif(svQW = 1,'передумала','подумала')+' и решила принять твоё предложение, -</dh> сказали вы ему.**<do>- '+iif(svQW = 1,'Хорошо','Отлично!')+', -</do> заулыбался Стасик.<do> - '+iif(svQW = 1,'Тогда давай сходим в кафе, обсудим наши дальнейшие перспективы','Напомню правила. В северном, центральном и Южном районах находятся супермаркеты. Ты будешь заходить в наш офис, брать задание на работу, потом ехать во все эти супермаркеты и расставлять там нашу продукцию согласно заданию. На кассе возьмешь чек подтверждающий то, что ты была на работе. После этого ты возвращаешься в офис и мы выплачиваем тебе вознаграждение')+'.</do>'
	if svQW = 1: act 'Согласиться':svQW = 3 & gt 'south_office_events','stasik_yes'
	if svQW = 2: act 'Уйти': svQW = 3 & gt 'south_office','start'
end
if $ARGS[0] = 'stasik_talk':
	act 'Отлично!':
		*clr & cla
		minut += 5
		TPmainQW = 1
		gs'stat'
		gs 'zz_render', '', 'images/city/south/stas/stas.jpg', 'Вы ответили Стасу, что все отлично, и он довольно улыбнулся:**<do>- Наша фирма только развивается, и для умного человека тут найдется место и получше. Кстати, давай сходим в кафе, ты еще не проставлялась за работу.</do>'
		act 'Согласиться': gt 'south_office_events','stasik_yes'
		act 'Отказаться': gt 'south_office_events','stasik_no'
	end
	act 'Так себе':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/city/south/stas/stas.jpg', 'Вы ответили Стасу, что так себе, и он расстроенно нахмурился:**<do>- <<$name[2]>> пойми, наша фирма только развивается, но для умного человека тут может найтись место и получше. Может сходим в кафе, обсудим дальнейшие перспективы?</do>'
		act 'Согласиться': gt 'south_office_events','stasik_yes'
		act 'Отказаться': gt 'south_office_events','stasik_no'
	end
end
if $ARGS[0] = 'stasik_yes':
	*clr & cla
	TPmainQW = 2
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/stas.jpg', 'Вам пришлось согласиться, так как вся ваша новая работа и перспективы зависят от Стаса. Он обрадовался и повел вас в кафе, по пути рассказывая о работе. В кафе Стас галантно пододвинул для вас стульчик.'
	act 'Сесть': gt 'StasQW','cafe'
end
if $ARGS[0] = 'stasik_no':
	*clr & cla
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/stas.jpg', 'Вы ответили отказом и Стас '+iif(TPmainQW = 1,'заметно расстроился:**<do>- Ну ладно, я хотел лишь помочь тебе...</do>','нахмурился:**<do>- Как хочешь, я хотел лишь помочь тебе, но раз тебя эта работа не устраивает, считай, что ты уволена...</do>')
	act 'Передумать': gt 'south_office_events','stasik_yes'
	act 'Уйти':
		if TPmainQW = 0: svQW = 1
		gt 'south_office','start'
	end
end
if $ARGS[0] = 'stasik_bf':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/stas.jpg','Вы зашли в офис и тут же, нос к носу, столкнулись со Стасом, во взгляде которого явно мелькает радость. Негромко, чтобы не было слышно его коллегам, он предлагает вам продолжить ваши отношения и начать встречаться.'+iif(bfa >= 1, 'Вы подумали, что ваш нынешний парень вряд ли обрадуется, прими вы это предложение. Стас, конечно, очень мил, но вам сперва надо разобраться в своих текущих отношениях.','')
	if bfa < 1:
		act 'Согласиться':
			cla
			TPmainQW = 4
			$boy = 'Стас'
			boybodyrand = 1
			$boybody = 'высокий'
			boybodrand = 1
			$boybod = 'худощавый'
			boyfacerand = 3
			$boyface = 'блондин'
			boypic = 32
			dick = 15
			silavag = 1
			harakBoy = 1
			finance = 1
			vneshBoy = 1
			$boyClo = 'одет в джинсы и свитер.'
			figurBoy = RAND(0,2)
			titBoy = RAND(0,2)
			haerBoy = RAND(0,3)
			izvrat = 0
			gs'boyfrend','start'
			stopboy = 0
			bfa = 70
			boyonceA = 1
			manna = 100
			gs 'zz_render', '', '','Вы ответили Стасу согласием, на что тот просиял и пообещал вскоре перезвонить вам.'
			act 'Далее': gt'south_office','torgpred'
		end
	end
	act 'Мне нужно подумать':
		cla
		stas_wait = 0
		gs 'zz_render', '', '', 'Вы ответили Стасу, что он вам очень нравится, но вы пока не готовы дать ответ, и просите его чуть-чуть подождать. Стас хмурится, но принимает ваш ответ.'
		act 'Далее': gt'south_office','torgpred'
	end
	act 'Отказать':
		cla
		TPmainQW = 3
		gs'stat'
		gs 'zz_render', '', '', 'Вы довольно резко отказали Стасу, на что он обиделся:**<do>- Ну и ладно! Я то думал, что у нас что-то большее, чем случайный перепих...</do>'
		act 'Далее': gt'south_office','torgpred'
	end
end
if $ARGS[0] = 'security_start':
	*clr & cla
	borodachQW = 1
	borodachSexDay = day
	gs 'zz_render', '', 'images/city/south/south_office/security.jpg', '<dh>- Фиаско, -</dh> ответили вы.**<do>- Точно, -</do> почесал затылок охранник.<do> - То-то я думаю ПИЗДЕЦ не может быть ответом!</do>'
	act 'Уйти': gt'south_office','start'
	act 'Засмеяться':
		*clr & cla
		gs 'zz_render', '', 'images/city/south/south_office/security.jpg', 'Вы засмеялись над охранником, он заулыбался и отложил кроссворд в сторону.**<do>- Я тебя тут уже не раз видел. Уборщицей работаешь?, -</do> спросил он вас.**<dh>- Да, подрабатываю, -</dh> кивнули вы в ответ.<dh> - Тут такие деньги платят, что работой это не назовешь...</dh>**<do>- Понятно, -</do> сказал охранник.<do> - Меня кстати Саша зовут, а тебя?</do>**<dh>- Меня <<$name[1]>>, -</dh> ответили вы.**<do>- Очень приятно, <<$name[1]>>, -</do> улыбнувшись сказал Саша.<do> - У меня тут бутылка есть и закусь, составишь компанию?</do>'
		act 'Извини, мне пора идти':gt'south_office','start'
		act 'Почему бы и нет': gt'south_office_events','security_drink'
	end
end
if $ARGS[0] = 'security':
	*clr & cla
	gs 'zz_render', '', 'images/city/south/south_office/security.jpg','Вы подошли к охраннику Сашке и поздоровались.'+iif(borodachSexDay = day or vnesh < 20,' Немного поболтав с вами Сашка собрался на идти обход и вы отошли, не став ему мешать.',' Он подмигнул вам:**<do>- У меня пузырек тут припрятан. Как смотришь на культурно массовый досуг?</do>')
	if borodachSexDay = day or vnesh < 20:
		act 'Отойти':gt'south_office','start'
	else
		act 'Давай в другой раз':gt'south_office','start'
		act 'Пойдем': gt'south_office_events','security_drink'
	end
end
if $ARGS[0] = 'security_drink':
	*clr & cla
	borodachSexDay = day
	i = rand(1,2)
	minut += 5
	$boy = 'Сашка'
	dick = 15
	silavag = 2
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_office/vodka<<i>>.jpg','Сашка отвел вас в свой закуток и достал из под стола бутылку водки, залез в ящик и вытащил оттуда '+iif(i = 1,'банку "кильки" и плавленый сырок','нехитрую закуску')+'. Вынув пару стаканов, он протёр их и налил туда водку.'
	act 'Выпить':
		*clr & cla
		gs 'zz_funcs', 'alko', rand(2,4)
		energy += 2
		gs'stat'
		gs 'zz_render', '', 'images/city/south/south_office/drink.jpg', 'Вы выпили водки, дыханье у вас спёрло, и вы схватив скорей '+iif(i = 1,'сырок','огурец')+', стали занюхивать. Сашка привычно хлопнул стакан и даже не поморщился:**<do>- Эх, хорошо пошла!</do>**Пока вы, наклонившись к столу, занюхивали и закусывали, вы почувствовали как рука охранника,'+iif(borodachSex = 0,' как бы случайно,','')+' легкими прикосновениями, гладит вас по попе.'
		if borodachSex = 0:
			act 'Эй! Ты чего задумал?':
				cla
				minut += 15
				horny += 5
				gs'stat'
				gs 'zz_render', '', '', '<dh>- Эй! Ты чего задумал?, -</dh> воскликнули вы.**<do>- Да ладно, я случайно... -</do> начал бормотать Сашка, наливая ещё водки.<do> - Давай лучше выпьем!</do>'
				if horny < 70: act 'Мне хватит': gt'south_office_events','security_no'
				act 'Выпить еще': gt'south_office_events','security_drink2'
			end
		end
		act iif(borodachSex = 0,'Сделать вид, что не заметили','Улыбаться'):
			cla
			minut += 15
			horny += 5
			gs'stat'
			gs 'zz_render', '', '', iif(borodachSex = 0,'Вы закусили, стараясь не обращать внимания на, как бы, случайные прикосновения','Вы улыбнулись и Сашка налил еще водки, не отрывая руку ласкающую вас от вашей попы.')+'. Сашка налил еще водки**<do>- Между первой и второй, перерывчик не большой, -</do> сказал он и опрокинул стакан.'
			if horny < 70: act 'Мне хватит': gt'south_office_events','security_no'
			act 'Выпить еще': gt'south_office_events','security_drink2'
		end
		if borodachSex > 0 or shameless['flag'] > 1:
			act 'Положить руку ему на ширинку':
				*clr & cla
				minut += 5
				i = rand(1,2)
				horny += iif(i = 1,5,10)
				gs'stat'
				gs 'zz_render', '', 'images/city/south/south_office/security_hand<<i>>.jpg', 'Вы положили ему на ширинку свою руку и почувствовали как у него стоит член. Ваши тонкие пальчики скользнули по молнии расстегивая ее.'+iif(i = 1,'Сашка расслабился на диване и с нетерпением ожидает ваших дальнейших действий.',' Сашка тут же впился в ваши губы поцелуем одновременно рукой лаская грудь.')
				act 'Дрочить ему':
					*clr & cla
					i = rand(1,2)
					minut += 5
					horny += 5
					if borodachSex = 0:borodachSex = 1 & guy += 1
					gs'stat'
					hj += 1
					gs 'zz_render', '', 'images/city/south/south_office/security_hj<<i>>.jpg', 'Вы начали ласкать его орган руками. Вскоре Сашка закряхтел:**<do>- Я так кончу скоро!</do>'
					act 'Дрочить ему дальше': gt'south_office_events','security_hjcum'
					act 'Взять в рот': gt'south_office_events','security_bjcum','bj'
					if vgape < 2:act 'Секс': gt'south_office_events','security_sex'
				end
				act 'Взять в рот':
					*clr & cla
					i = rand(1,5)
					minut += 5
					horny += 5
					if borodachSex = 0:borodachSex = 1 & guy += 1
					gs'stat'
					bj += 1
					gs 'zz_render', '', 'images/city/south/south_office/security_bj<<i>>.jpg', iif(i < 3,'Вы взяли Сашкин член в руку и','Вы опустились на колени перед Сашкой и взяв его член в руку,')+' приблизили к нему своё лицо.'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_render', '', '','Сашка закряхтел:**<do>- Я сейчас кончу!</do>'
					act 'Вынуть член изо рта': gt'south_office_events','security_hjcum','bj'
					act 'Обхватить ещё сильнее губами': gt'south_office_events','security_bjcum'
					if vgape < 2:act 'Секс': gt'south_office_events','security_sex'
				end
			end
		end
	end
end
if $ARGS[0] = 'security_drink2':
	*clr & cla
	minut += 15
	horny += 5
	gs 'zz_funcs', 'alko', rand(2,4)
	energy += 2
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_office/drink.jpg', 'Вы выпили ещё, и закусив сырком, поняли что резко опьянели. Рука охранника уже не скрываясь ласкала вашу попу.'
	if alko < 6:act 'Мне пора идти': gt'south_office_events','security_no2'
	act 'Расслабиться': gt'south_office_events','security_relax'
end
if $ARGS[0] = 'security_no':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/south_office/no.jpg', 'Вы отказались больше пить и стали собираться уходить. Охранник начал вас уговаривать остаться с ним и продолжить.'
	if dom > -10: act 'Уйти': dom += 1 & gt 'south_office', 'start'
	act 'Выпить еще': gt'south_office_events','security_drink2'
end
if $ARGS[0] = 'security_no2':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/south_office/no.jpg', 'Вы начали собираться, но Саша стал вас уговаривать остаться с ним и продолжить.'
	if dom > 0 and horny < 70:act 'Уйти': dom += 1 & gt 'south_office', 'start'
	act 'Расслабиться': gt'south_office_events','security_relax'
end
if $ARGS[0] = 'security_relax':
	*clr & cla
	if borodachSex = 0:borodachSex = 1 & guy += 1
	i = rand(1,2)
	minut += 5
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_office/security_undress<<i>>.jpg', 'Вы расслабились и стали получать удовольствие от рук, ласкающих вас. Сашка уже не таясь обнял вас и начал целовать. Его руки заскользили по вашей одежде, расстёгивая и снимая ее.'+iif(i = 1,'',' Вскоре он добрался до вашей груди и начал целовать её, играя языком с сосочком.')
	act 'Лечь на диван':
		*clr & cla
		minut += 5
		horny += 5
		minut += 30
		pose = 0
		gs'stat'
		gs 'zz_render', '', 'images/city/south/south_office/security_sex'+iif(horny < 50,1,iif(horny < 80,2,3))+'.jpg', '<<$boy>> положил вас на диван, раздвинул ваши ноги руками и достав свой член, стал ласкать пальцами вашу киску готовясь войти в нее.'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Уйти': gt 'south_office', 'start'
	end
end
if $ARGS[0] = 'security_hjcum':
	*clr & cla
	minut += 5
	borodachSexDay = day
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_office/security_hjcum.jpg', iif($args[1] = 'bj','Вы вынули член изо рта и принялись его дрочить, глядя парню в глаза. ','')+'Сашка сладко застонал и вы почувствовали пульсацию его члена, предвещающую скорый оргазм. Он зарычал и обмякнув, излился вам в ладошки, покрывая их толстым слоем вязкой спермы.'
	act 'Уйти': gt 'south_office', 'start'
end
if $ARGS[0] = 'security_bjcum':
	*clr & cla
	minut += 5
	vaf += 1
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/south_office/security_bjcum<<i>>.jpg', iif(i < 3,'Опустившись перед парнем на колени вы','Вы')+iif($args[1] = 'bj',' взяли член в рот',' удвоили свои усилия')+', обрабатывая '+iif($args[1] = 'bj','его','твёрдый член')+' своими <<$liptalk>>.'
	gs 'zz_dynamic_sex', 'swallow'
	act 'Уйти': gt 'south_office', 'start'
end
if $ARGS[0] = 'security_sex':
	*clr & cla
	i = rand(3,5)
	minut += 5
	horny += 5
	minut += 30
	pose = 0
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_office/security_sex<<i>>.jpg','<<$boy>> '+iif(i = 3,'положил вас на диван, раздвинул ваши ноги руками,',iif(i = 4,'посадил вас на себя сверху','поставил вас раком на диване'))+' и начал ласкать пальцами вашу киску, готовясь войти в нее.'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Уйти': gt 'south_office', 'start'
end