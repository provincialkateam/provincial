if $ARGS[0] = 'start':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	frost = 0
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Офисное здание', 'images/city/south/south_office/south_office.jpg','На стене висит доска <a href="exec:gt ''south_office'',''ads''">объявлений</a>**Над одной из дверей табличка с надписью "'+iif(hour >= 7 and hour <= 17,'<a href="exec:GT ''zz_clothing'',''tailor''">Ателье по пошиву и ремонту одежды</a>','Ателье по пошиву и ремонту одежды')+'. Время работы с 7.00 до 18.00"**'+iif(svQW < 1,'','Офис '+iif(hour >= 8 and hour <= 16 and week < 6,'<a href="exec:GT ''south_office'',''torgpred''">торгового представительства</a> открыт.','торгового представительства закрыт. График работы с 8.00 до 17.00, выходные - суббота, воскресенье.'))
	if clener = 1:
		act 'Поговорить о работе':
			*clr & cla
			gs 'zz_render', '', 'images/city/south/south_office/administrator.jpg','Вы зашли в кабинет, который был указан в объявлении. Вас встретил грузный мужчина в пиджаке. Он объяснил вам, работать можно хоть каждый день. Уборка офиса один час, оплата - 100 рублей сразу же на руки.'
			act 'Отказаться и уйти': gt'south_office','start'
			act 'Согласиться на работу':
				cla
				clener = 2
				gs 'zz_render', '', '','Вы согласились на работу.'
				act 'Выйти': gt'south_office','start'
			end
		end
	end
	if clener >= 10 and clenerT = 0:
		act 'Спросить нет ли еще работы':
			*clr & cla
			gs 'zz_render', '', 'images/city/south/south_office/administrator.jpg','Вы спросили у Бориса Ивановича, нет ли еще работы. Он сказал, что требуется уборщица для уборки туалета, работать можно хоть каждый день. Уборка туалета один час, оплата - 100 рублей сразу же на руки.'
			act 'Отказаться и уйти': gt'south_office','start'
			act 'Согласиться на работу':
				cla
				clenerT = 1
				gs 'zz_render', '', '','Вы согласились на работу.'
				act 'Выйти':gt'south_office','start'
			end
		end
	end
	if jouryQWNo = 1 and hour = 17:
		gs 'zz_render', '', '','По коридору идет Юрий, тот самый офисный работник который предлагал вам погулять, но вы отказали. Он пристально смотрит на вас и подходит к вам.'
		act 'Поговорить с Юрием': gt'south_office_events','youry_talk'
	end
	if clener > 1 and hour >= 19:
		gs 'zz_render', '', '',	'За столом, перед входом, сидит охранник '+iif(clener < 5 or vnesh < 20,'и пялится в монитор видеонаблюдения.',iif(borodachQW = 0,'с кроссвордом и мучительно вспоминает что-то. Увидев вас он спрашивает:**<do>- Плохое окончание дела, вторая буква И?"','Сашка. Увидев вас он '+iif(borodachSex = 0,'кивнул вам, приветствуя.','улыбнулся и сказал:**<do>- Привет, <<$name[2]>>!</do>')))
		if clener >= 5 and vnesh >= 20 or borodachQW > 0:act iif(borodachQW = 0,'Ответить охраннику','Подойти к Сашке'): gt'south_office_events','security'+iif(borodachQW = 0,'_start','')
	end
	if clener > 1 and clenday ! day:
		act 'Мыть пол в офисе (1 час)':
			*clr & cla
			clenday = day
			minut += 60
			clener += 1
			manna -= 15
			money += 100
			sweat += 2
			if clener >= 10 and jouryQW < 7 and vnesh >= 40: jouryQW += 1
			gs 'zz_render', '', 'images/city/south/south_office/cleaning_office.jpg', iif(hour < 9 or hour > 16,'В офисе никого нет, вы спокойно вымыли пол и протерли пол.','Вы набрали воды в ведро и пошли в офис захватив швабру с тряпкой. Сотрудникики в офисе расступились и дали вам помыть пол.'+iif(clener < 5 or vnesh < 40,'',iif(jouryQW < 7,' Один из сотрудников, мужчина с светлыми волосами и красным лицом разглядывал вас стараясь спрятать взгляд, но вы чувствовали его обжигающий взгляд на себе.',iif(jourySex = 0,' Юрий разглядывал вас шаря взглядом по вашей фигуре.',' Юрий делая вид, что вас не замечает, вышел из офиса.'))))+' После уборки вы зашли к коменданту здания Борису Ивановичу. Он выдал вам сто рублей за проделанную работу.'
			if jouryQW = 7 and hour >= 9 and hour <= 16 and vnesh >= 40: gt'south_office_events','youry_start'
			act 'Выйти': gt'south_office','start'
		end
	end
	if clenerT >= 1 and clendayT ! day:
		act 'Чистить унитазы (1 час)':
			*clr & cla
			clendayT = day
			minut += 60
			clenerT += 1
			manna -= 25
			money += 100
			sweat += 3
			gs 'zz_render', '', 'images/city/south/south_office/cleaning.jpg', 'Вы вымыли пол в туалете и надраили все унитазы и писсуары до блеска. После окончания работы Борис Иванович выдал вам сто рублей.'
			if jouryQW > 7 and hour >= 9 and hour <= 16 and jourySex > 0 and jouryResult = 0: gt'south_office_events','youry_talk2'
			if StasikValera > 0 and svQW = 0  and clenerT > 5 and hour >= 8 and hour <= 16: gt'south_office_events','stasik_work'
			act 'Выйти':gt'south_office','start'
		end
	end
	act 'Выйти':gt'street'
end
if $ARGS[0] = 'ads':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Доска объявлений', 'images/city/south/south_office/ads.jpg','Вы подошли к доске, где расклеено множество различных объявлений'+iif(clener = 0,', среди которых бросается в глаза объявление - <b>Требуются уборщицы</b>.','. Но ничего интересно вы не нашли.')
	if clener = 0: clener = 1
	act 'Уйти': gt'south_office','start'
end
if $ARGS[0] = 'torgpred':
	gs'stat'
	gs 'zz_render', 'Торговое представительство', 'images/city/south/south_office/torgpred.jpg','Светлый кабинет в котором стоят офисные столы и орг техника. В кабинете есть еще дверь на которой написано "Директор"**За одним из столов сидит Стас, за другим Виталий, за третьим столом сидит девушка главный бухгалтер.'
	act 'Выйти':gt'south_office','start'
	if svQW <= 2 and TorgPredDay ! day: act 'Поговорить со Стасом': gt'south_office_events','stasik_work2'
	if svQW = 3:
		if TorgPredDay ! day:
			if TorgPredZ = 0 and TorgPredZV = 0:
				act 'Взять задание':
					*clr & cla
					TorgPredZ = 3
					minut += 5
					TorgPredDay = day
					!gs'stat'
					gs 'zz_render', '', 'images/city/south/stas/stas.jpg','Вы подошли к Стасу за заданием. Он улыбнулся и протянул вам бумагу:**<do>- Не забудь. Супермаркетов три штуки. Тебе нужно расставить товар во всех супермаркетах.</do>'
					act 'Выйти': gt'south_office','start'
				end
			end
		end
		if TorgPredZ = 0 and TorgPredZV = 3:
			act 'Получить деньги':
				*clr & cla
				TorgPredZV = 0
				minut += 5
				money += 500
				TPworkTimes += 1
				if stas_wait < 3:stas_wait += 1
				gs'stat'
				gs 'zz_render', '', 'images/city/south/stas/stas.jpg','Вы подошли к Стасу за деньгами. Он улыбнулся и протянул вам 500 рублей'+iif(StasikSex = 0 and TPworkTimes >= 10 and TPmainQW = 0 and mesec = 0 and vnesh >= 40,'Стас с интересом спрашивает^**<do>- Ну как тебе работа?</do>','')
				if StasikSex = 0 and TPworkTimes >= 10 and TPmainQW = 0 and mesec = 0 and vnesh >= 40: gs'south_office_events','stasik_talk'
				if TPmainQW = 2:
					if StasikSex > 0 and StVaGang = 0:
						!<<$name[1]>> дала Стасу, тот не считает ее шлюхой, и хочет продолжать отношения
						''
					end
					if StasikSex = 0:
						!<<$name[1]>> отказала Стасу, Стас не доволен и идет ва банк
						''
					end
				end
				if StVaGang > 0:
					!И Стас и Валера считают <<$name_a[1]>> шлюхой
					''
				end
				act 'Выйти':gt'south_office','start'
			end
		end
		if TPmainQW = 2 and StasikSex > 0 and StVaGang = 0 and stas_wait = 3: gt'south_office_events','stasik_bf'
	end
end