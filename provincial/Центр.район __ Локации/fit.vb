if $ARGS[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Фитнес центр','images/pic/fit.jpg','Абонемент на 30 занятий стоит 6000 рублей. На занятия обязательно приходить в спортивной одежде.**Ваш абонемент действителен на <<abonement>> занятий.'
	act 'Выйти':
		cla
		minut += 5
		gt'down'
	end
	if (money >= 6000 or karta >= 6000) and abonement <= 2:
		act 'Купить абонемент на 30 занятий(6 тыс.руб)':
			cla
			if karta >= 6000:
				karta -= 6000
			else
				money -= 6000
			end
			abonement += 30
			gs 'zz_render','','','Вы приобрели абонемент на 30 занятий.'
			act 'Отойти от кассы':gt'fit','start'
		end
	end
	if abonement > 0 and fitday ! day:
		act 'Идти в раздевалку':
			cla
			abonement -= 1
			fitday = day
			razdtumbler = 1
			gt 'fit', 'razd'
		end
	end
end
if $ARGS[0] = 'razd':
	$loc = $curloc
	$metka = $args[0]
	minut += 5
	gs 'stat'
	gs 'zz_render','Раздевалка','images/pic/razd.jpg','<b>Объявления:</b>**Производится набор девушек в секцию бега. Призеры соревнований получают денежные призы.**Внимание, посещать спортивные секции разрешается только со спортивном костюмом!'
	if hour >= 12 and hour <= 14 and week >= 6:
		if dom >= 50 and $npc['31,qwTanyaMain'] < 10 and tanya['fit_meet_day'] ! day: gt 'tanya_events','fitness_meet'
		if $npc['31,qwTanyaMain'] >= 10: gs 'zz_render','','','В раздевалке вы видите <a href="exec:gt''tanya_events'',''talk''">Таню</a>.'
	end
	if begsec = 0: act 'Записаться в секцию бега': gt'fit','1'
	if begsec > 0 and razdtumbler = 1 and func('zz_clothing','get_group') = 3 and sick < 1:
		act 'Идти в секцию': gt 'fit','beg'
		if beg >= 20 and week = 6: act '<b>Соревнования по бегу</b>': gt 'fit','sorevnovania'
	end
	act 'Принять душ 15 мин':
		*clr & cla
		gs 'zz_render','','images/pics/dush.jpg','Вы залезли под ду и включили воду. Намылившись, вы ополоснулись под душем.'
		gs 'zz_bathroom', 'shower'
		act 'Выйти из душевой': gt'fit','razd'
	end
	act 'Зеркало': gt 'mirror','start'
	act 'Шкафчик': gt 'loker', 'start'
	if razdtumbler = 1 and func('zz_clothing','get_group') = 3 and sick < 1:
		act 'Идти в спортзал': gt 'fit','raz'
		act 'Идти в танцевальную студию': gt 'danceclass'
	end
	act '<b>Уйти</b>':
		if current_clothing < 2:
			gs 'zz_render','','','<red>ВАМ НАДО ОДЕТЬСЯ.</red>'
			gt 'loker', 'start'
		else
			gt 'fit', 'start'
		end
	end
end
if $ARGS[0] = 'raz':
	*clr & cla
	minut += 5
	razdtumbler = 0
	sportzalrand = RAND(0,20)
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Фитнес центр','images/pic/fit','В фитнес-центре представлено множество различных программ для физического развития организма.'
	! Удалить нахер этого китайца неведомого!
	if hour >= 10 and hour < 12 and week=7:
		if centr=1: gs 'zz_render','','','В зале вы увидели <a href="exec:GT ''VolleyTrenCentr''">Михаил Николаича</a>, разговаривающего с незнакомым мужчиной.'
		if centr=2: gs 'zz_render','','','В зале вы увидели <a href="exec:GT ''VolleyTrenCentr''">китайца Гуанга'
	end
	act 'Аэробика (сгон жира)':
		*clr & cla
		minut += 120
		body['day_weight'] -= 2
		react += RAND(1,3)
		gs 'zz_funcs', 'sport', 5
		if sportzalrand <= 3: gt 'zal', str(sportzalrand)
		gs 'zz_render','','images/pic/fit1','Вы очень энергично под музыку выполняли упражнения для сгона жира.'
		act 'Уйти': gt 'fit','razd'
	end
	act 'Тренажёрка (на силу)':
		*clr & cla
		minut += 120
		stren += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		if sportzalrand <= 3: gt 'zal', str(sportzalrand)
		gs 'zz_render','','images/pic/fit2','Вы "качали железо" для развития силы, поглядывая на мускулистыых парней в зале.'
		act 'Уйти': gt 'fit','razd'
	end
	act 'Тренажёрка (на выносливость)':
		*clr & cla
		minut += 120
		vital += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		if sportzalrand <= 3: gt'zal', str(sportzalrand)
		gs 'zz_render','','images/pic/fit3','Вы занимались на тренажерах для развития выносливости.'
		act 'Уйти': gt 'fit','razd'
	end
	act 'Теннис, развитие ловкости':
		*clr & cla
		minut += 120
		agil += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		TenisDef += 1
		if sportzalrand <= 3: gt 'zal', str(sportzalrand)
		gs 'zz_render','','images/pic/fit4','Вы прыгаете с теннисной ракеткой, стараясь попасть по мячику, отрабатывая ловкость.'
		act 'Уйти': gt 'fit','razd'
	end
	act 'Теннис, отработка атак (на скорость)':
		*clr & cla
		minut += 120
		speed += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		TenisAt += 1
		if sportzalrand <= 3: gt'zal', str(sportzalrand)
		gs 'zz_render','','images/pic/fit4','Вы прыгаете с теннисной ракеткой, отрабатывая атакующие действия.'
		act 'Уйти': gt'fit','razd'
	end
	act 'Секция кикбоксинга': gt 'fit','kik'
end
if $ARGS[0] = 'kik':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'razrKik'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Секция кикбоксинга','images/pic/kik'
	act 'Отработка джебов на груше':
		*clr & cla
		minut += 120
		speed += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		Jab += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали на груше джебы, длинные прямые удары с шагом вперед. Эти удары не так мощны как силовые, но они быстрее.'
		act 'Уйти':gt'fit','razd'
	end
	act 'Отработка силовых ударов на груше':
		*clr & cla
		minut += 120
		stren += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		Punch += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали на груше мощные силовые удары, способные потрясти соперника. Эти удары мощны, но ими трудно попасть.'
		act 'Уйти':gt'fit','razd'
	end
	act 'Отработка ударов ног':
		*clr & cla
		minut += 120
		stren += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		Kik += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали на груше мощные удары ногами, способные "вырубить" соперника. Эти удары мощны, но ими очень трудно попасть.'
		act 'Уйти':gt'fit','razd'
	end
	act 'Отработка защиты':
		*clr & cla
		minut += 120
		agil += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		KikDef += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали защитные движения.'
		act 'Уйти':gt'fit','razd'
	end
	act 'Спарринг (тренировочный бой в ринге)':
		*clr & cla
		round = 0
		gs 'zz_render','','','Вам нужно выбрать себе соперника для спарринга'
		act 'Соперница':
			minut += 120
			body['day_weight'] -= 1
			gs 'zz_funcs', 'sport', 5
			strenV = RAND(10,20)
			speedV = RAND(10,20)
			agilV = RAND(10,20)
			reactV = RAND(10,20)
			vitalV = RAND(10,20)
			!Навыки
			JabV = RAND(5,20)
			PunchV = RAND(5,20)
			KikV = RAND(5,20)
			KikDefV = RAND(5,20)
			!Параметры
			healthV = vitalV*10 + strenV*5
			$boy = 'Спарринг партнерша'
			formula = 3
			sparing = 1
			gt'kikbox','start'
		end
	end
	if week >= 5:
		gs 'zz_render','','','Вы можете провести любительский бой.'
		act 'Любительский бой':
			round = 0
			minut += 120
			body['day_weight'] -= 1
			gs 'zz_funcs', 'sport', 5
			razrand = RAND(0,1)
			if razradKik + razrand = 0:
				strenV = RAND(10,20)
				speedV = RAND(10,20)
				agilV = RAND(10,20)
				reactV = RAND(10,20)
				vitalV = RAND(10,20)
				!Навыки
				JabV = RAND(10,30)
				PunchV = RAND(10,30)
				KikV = RAND(10,30)
				KikDefV = RAND(10,30)
				!Параметры
				healthV = vitalV*10 + strenV*5
				$boy = 'Соперница без разряда'
				formula = 3
				amature = 1
			elseif razradKik + razrand = 1:
				strenV = RAND(15,25)
				speedV = RAND(15,25)
				agilV = RAND(15,25)
				reactV = RAND(15,25)
				vitalV = RAND(15,25)
				!Навыки
				JabV = RAND(15,35)
				PunchV = RAND(15,35)
				KikV = RAND(15,35)
				KikDefV = RAND(15,35)
				!Параметры
				healthV = vitalV*10 + strenV*5
				$boy = 'Соперница с третьим разрядом'
				formula = 3
				amature = 1
			elseif razradKik + razrand = 2:
				strenV = RAND(20,30)
				speedV = RAND(20,30)
				agilV = RAND(20,30)
				reactV = RAND(20,30)
				vitalV = RAND(20,30)
				!Навыки
				JabV = RAND(30,50)
				PunchV = RAND(30,50)
				KikV = RAND(30,50)
				KikDefV = RAND(30,50)
				!Параметры
				healthV = vitalV*10 + strenV*5
				$boy = 'Соперница со вторым разрядом'
				formula = 3
				amature = 1
			elseif razradKik + razrand = 3:
				strenV = RAND(30,40)
				speedV = RAND(30,40)
				agilV = RAND(30,40)
				reactV = RAND(30,40)
				vitalV = RAND(30,40)
				!Навыки
				JabV = RAND(40,60)
				PunchV = RAND(40,60)
				KikV = RAND(40,60)
				KikDefV = RAND(40,60)
				!Параметры
				healthV = vitalV*10 + strenV*5
				$boy = 'Соперница с первым разрядом'
				formula = 3
				amature = 1
			elseif razradKik + razrand = 4:
				strenV = RAND(40,60)
				speedV = RAND(40,60)
				agilV = RAND(40,60)
				reactV = RAND(40,60)
				vitalV = RAND(40,60)
				!Навыки
				JabV = RAND(60,80)
				PunchV = RAND(60,80)
				KikV = RAND(60,80)
				KikDefV = RAND(60,80)
				!Параметры
				healthV = vitalV*10 + strenV*5
				$boy = 'Соперница КМС'
				formula = 3
				amature = 1
			elseif razradKik + razrand >= 5:
				strenV = RAND(60,100)
				speedV = RAND(60,100)
				agilV = RAND(60,100)
				reactV = RAND(60,100)
				vitalV = RAND(60,100)
				!Навыки
				JabV = RAND(80,110)
				PunchV = RAND(80,110)
				KikV = RAND(80,110)
				KikDefV = RAND(80,110)
				!Параметры
				healthV = vitalV*10 + strenV*5
				$boy = 'Соперница МС'
				formula = 3
				amature = 1
			end
			gt 'kikbox','start'
		end
	end
end
if $ARGS[0] = '1':
	cla
	minut += 5
	begsec = 1
	gs 'zz_render','','','Вы записались на секцию бега'
	act 'Уйти': gt 'fit','razd'
end
if $ARGS[0] = 'beg':
	*clr & cla
	minut += 5
	razdtumbler = 0
	act 'Секция бега':
		*clr & cla
		gs 'zz_common','crossing',1
		! совет от тренера
		if beg < 50:
			gs 'zz_render','','','После занятий тренер выдал свой извечный совет:**\\\- Тебе нужно тренироваться, ты пока даже на третий разряд не вытягиваешь! В беге главное атлетизм и дыхалка. Еще важно что бы не было лишнего веса, но диеты подрывают спортивную форму - для подсушивания лучше использовать сауну.///'
		else
			gs 'zz_render','','','После занятий тренер выдал свой извечный совет:**\\\- Ты молодец, действительно молодец, у тебя может быть очень хорошее спортивное будущее. Но не забывай, ключ к победам, дыхалка, атлетизм и ни грамма лишнего веса!///'
		end
		act 'Уйти': gt 'fit', 'razd'
	end
end
if $ARGS[0] = 'sorevnovania':
	*clr & cla
	minut += 60
	gs 'stat'
	kolsorev += 1
	begmon = month
	razdtumbler = 0
	$zz_str[0] = 'Вас записывают в группу новичков.'
	$zz_str[1] = 'Вас записывают в группу третеразрядников.'
	$zz_str[2] = 'Вас записывают в группу вторых разрядов. Чемпионат города.'
	$zz_str[3] = 'Вас записывают в группу первых разрядов. Чемпионат области.'
	$zz_str[4] = 'Вас записывают в группу КМС. Чемпионат региона.'
	$zz_str[5] = 'Вас записывают в группу Мастеров Спорта. Чемпионат России.'
	$zz_str[6] = 'Вас записывают в группу Мастеров Спорта международного класса. Квалификационные соревнование за выход на Чемпионат Европы.'
	$zz_str[7] = 'Вас записывают на чемпионат Европы.'
	$zz_str[8] = 'Вы не прошли квалификационный отбор на Чемпионат Европы.'
	$zz_str[9] = 'Выйти на беговую дорожку'
	if razradbeg < 6:
		gs 'zz_render','','', $zz_str[razradbeg]
		act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run' + razradbeg
	elseif razradbeg >= 6 and razradbeg < 16:
		gs 'zz_render','','', $zz_str[6]
		act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run6'
	elseif razradbeg = 16:
		if razradbegK < 8:
			cla
			razradbegK = 0
			razradbeg = 6
			gs 'zz_render','','', $zz_str[8]
			act 'Уйти': gt 'fit', 'razd'
		elseif razradbegK >= 8:
			cla
			razradbegK = 0
			razradbeg = 6
			gs 'zz_render','','', $zz_str[7]
			act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run7'
		end
	end
	killvar '$zz_str'
end