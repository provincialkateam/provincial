$loc = $curloc
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	$metka = $args[0]
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','','city/center/fitness/reception','Абонемент на 30 дней стоит 6000 рублей.**Ваш абонемент действителен на <<abonement>> дней.'
	act '<b>Уйти</b>': gt 'center'
	if abonement < 5:
		act 'Купить абонемент':
			if func('zz_funcs','money',6000) = 1:
				abonement += 30
				gt 'fitness'
			end
		end
	end
	if abonement > 0 and sport = 0 and func('zz_drugs','block') = 0: act 'Идти в раздевалку': gt 'fitness','dressroom'
	act 'Фитобар':
		*clr & cla
		gs 'zz_render','','city/center/fitness/bar','Вы можете заказать мультивитаминный сок - 100 рублей.'
		act '<b>Назад</b>': gt 'fitness'
		act 'Купить сок':
			if func('zz_funcs','money',100) = 1:
				*clr
				minut += rand(15,30)
				manna += 5
				cumlip = 0
				gs 'stat'
				gs 'zz_kitchen_acts','drink','','city/center/fitness/smoozy'
			end
		end
	end
	! Удалить нахер этого китайца неведомого!
	if hour >= 10 and hour < 12 and week = 7:
		if centr = 1: gs 'zz_render','','','В зале вы увидели <a href="exec:GT ''VolleyTrenCentr''">Михаил Николаича</a>, разговаривающего с незнакомым мужчиной.'
		if centr = 2: gs 'zz_render','','','В зале вы увидели <a href="exec:GT ''VolleyTrenCentr''">китайца Гуанга'
	end
end
!---
if $args[0] = 'dressroom':
	*clr & cla
	$metka = $args[0]
	if hour >= 12 and hour <= 14 and week >= 6:
		gs 'zz_render','','city/center/fitness/dressroom_tanya'
		if dom >= 50 and $npc['31,qwTanyaMain'] < 10 and $npc['31,meet_day'] ! day: gt 'tanya_events','fitness_meet'
		if $npc['31,qwTanyaMain'] >= 10: gs 'zz_render','','','В раздевалке вы видите <a href="exec:gt''tanya_events'',''talk''">Таню</a>.'
	else
		gs 'zz_render','','city/center/fitness/dressroom'
	end
	act '<b>Уйти</b>': gt 'center'
	act '<b>Шкафчик</b>': gt 'loker'
	act 'Принять душ':
		*clr & cla
		gs 'zz_render','','city/center/fitness/shower','Вы залезли под душ и включили воду. Намылившись, вы ополоснулись под душем.'
		gs 'zz_bathroom','shower'
		act 'Выйти из душевой': gt 'fitness','dressroom'
	end
	!--
	if sport = 1: gs 'zz_render','','','Вы сегодня уже тренировались - не стоит перенапрягать мышцы.'
	if func('zz_clothing2','get_group') = 1 and sport = 0:
		act 'Бассейн': gt 'fitness','pool'
		act 'Секция бега':
			*clr & cla
			gs 'zz_common','crossing',1
			if beg < 50:
				gs 'zz_render','','','После занятий тренер выдал свой извечный совет:**\\\- Тебе нужно тренироваться, ты пока даже на третий разряд не вытягиваешь! В беге главное атлетизм и дыхалка. Еще важно что бы не было лишнего веса, но диеты подрывают спортивную форму - для подсушивания лучше использовать сауну.///'
			else
				gs 'zz_render','','','После занятий тренер выдал свой извечный совет:**\\\- Ты молодец, действительно молодец, у тебя может быть очень хорошее спортивное будущее. Но не забывай, ключ к победам, дыхалка, атлетизм и ни грамма лишнего веса!///'
			end
			act '<b>В раздевалку</b>': gt 'fitness','dressroom'
		end
		act 'Аэробика':
			*clr & cla
			minut += 60
			sport = 1
			body['day_weight'] -= 2
			react += RAND(1,3)
			gs 'zz_funcs','sport',5
			gs 'stat'
			gs 'zz_render','','city/center/fitness/0/<<rand(0,2)>>','Вы очень энергично под музыку выполняли упражнения для сгона жира.'
			act '<b>В раздевалку</b>': gt 'fitness','dressroom'
		end
		act 'Тренажерка':
			cla
			act 'Тренировка силы':
				*clr & cla
				minut += 60
				sport = 1
				stren += RAND(1,3)
				body['day_weight'] -= 1
				gs 'zz_funcs','sport',5
				gs 'stat'
				gs 'zz_render','','city/center/fitness/1/<<rand(0,2)>>','Вы "качали железо" для развития силы, поглядывая на мускулистыых парней в зале.'
				act '<b>В раздевалку</b>': gt 'fitness','dressroom'
			end
			act 'Тренировка выносливости':
				*clr & cla
				minut += 60
				sport = 1
				vital += RAND(1,3)
				body['day_weight'] -= 1
				gs 'zz_funcs','sport',5
				gs 'stat'
				gs 'zz_render','','city/center/fitness/2/<<rand(0,2)>>','Вы занимались на тренажерах для развития выносливости.'
				act '<b>В раздевалку</b>': gt 'fitness','dressroom'
			end
		end
		act 'Кикбоксинг': gs 'fitness','kik'
	end
end
if $args[0] = 'pool':
	*clr & cla
	$metka = $args[0]
	gs 'zz_render','','city/center/pool/pool'
	act '<b>В раздевалку</b>': minut += 5 & gt 'fitness','dressroom'
	if sport = 0:
		act 'Купаться':
			*clr & cla
			gs 'zz_bathroom','shower'
			minut += 60
			sport = 1
			if stren < 40: stren += 1
			gs 'stat'
			gs 'zz_render','','city/center/pool/swim','Вы искупались в бассейне, вода освежает и бодрит.'
			act 'Выйти из воды': gt 'fitness','pool'
		end
	end
end
!---
if $ARGS[0] = 'sorevnovania':
	*clr & cla
	minut += 60
	gs 'stat'
	kolsorev += 1
	begmon = month
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
		act $zz_str[9]: xgt 'zz_common', 'run_competition','run<<razradbeg>>'
	elseif razradbeg >= 6 and razradbeg < 16:
		gs 'zz_render','','', $zz_str[6]
		act $zz_str[9]: xgt 'zz_common', 'run_competition','run6'
	elseif razradbeg = 16:
		if razradbegK < 8:
			cla
			razradbegK = 0
			razradbeg = 6
			gs 'zz_render','','', $zz_str[8]
			act 'В раздевалку': gt 'fitness','dressroom'
		else
			cla
			razradbegK = 0
			razradbeg = 6
			gs 'zz_render','','', $zz_str[7]
			act $zz_str[9]: xgt 'zz_common', 'run_competition', 'run7'
		end
	end
	killvar '$zz_str'
end
!---
if $ARGS[0] = 'kik':
	cla
	act 'Отработка джебов на груше':
		*clr & cla
		minut += 120
		speed += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		Jab += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали на груше джебы, длинные прямые удары с шагом вперед. Эти удары не так мощны как силовые, но они быстрее.'
		act 'Уйти': gt 'fitness','dressroom'
	end
	act 'Отработка силовых ударов на груше':
		*clr & cla
		minut += 120
		stren += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		Punch += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали на груше мощные силовые удары, способные потрясти соперника. Эти удары мощны, но ими трудно попасть.'
		act 'Уйти': gt 'fitness','dressroom'
	end
	act 'Отработка ударов ног':
		*clr & cla
		minut += 120
		stren += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		Kik += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали на груше мощные удары ногами, способные "вырубить" соперника. Эти удары мощны, но ими очень трудно попасть.'
		act 'Уйти': gt 'fitness','dressroom'
	end
	act 'Отработка защиты':
		*clr & cla
		minut += 120
		agil += RAND(1,3)
		body['day_weight'] -= 1
		gs 'zz_funcs', 'sport', 5
		KikDef += RAND(1,3)
		gs 'zz_render','','images/pic/kik1','Вы отрабатывали защитные движения.'
		act 'Уйти': gt 'fitness','dressroom'
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