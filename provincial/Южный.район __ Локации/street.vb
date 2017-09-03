$metka = $ARGS[0]
$loc = $CURLOC
$control_point = $curloc
bordysh = 0
housrA = 0
obdysh = 0
gs 'stat'
gs 'time'
gs 'zz_render','Южный район',func('zz_funcs','mk_image','images/city/south/street.jpg'),iif(opusk > 0 and housr > 0,'На стене вашего дома, рядом с дверью в ваш подъезд красуется большая надпись краской <b>"<<$name[2]>> из '+iif(BuyHous ! 1,'69','70')+'-й квартиры опущенная хуесоска"</b>','')
if gopdeath = 1 and vsehsdaladay ! day:
	gt 'gameover',4
	exit
end
if shantpopala > 0:
	cla
	*clr
	hour += 8
	gs 'zz_funcs', 'cum', 'belly'
	gs 'zz_funcs', 'cum', 'ass'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	cumfrot += 1
	gs 'zz_funcs', 'cum', 'anus'
	guy += 2
	rape += 1
	sex += 1
	bj += 1
	anal += 1
	shantpopala -= 1
	gs 'zz_render', '', 'images/img/centr/rape.jpg', func('street_strings', 'local_str1')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Уйти':gt $curloc
	exit
end
if workDolgDay <= 0 and workDolg > 0:
	*clr & cla
	gs 'stat'
	gs 'time'
	workDisk = 0
	gs 'zz_render', '', 'images/sauna/bug.jpg', func('street_strings', 'local_str2')
	if money >= workDolg:
		money -= workDolg
		workDolg = 0
		gs 'zz_render', '', '', func('street_strings', 'local_str3')
		act 'Уйти':gt $curloc
		exit
	else
		if money + karta >= workDolg:
			money += karta
			karta = 0
			money -= workDolg
			workDolg = 0
			gs 'zz_render', '', '', func('street_strings', 'local_str4')
			act 'Уйти':gt'korr'
			exit
		else
			money += karta
			karta = 0
			workDolg -= money
			money = 0
			workDolg += 10000
			gs 'zz_render', '', '', func('street_strings', 'local_str5')
			act 'Выйти из машины':
				*clr & cla
				minut += 30
				gs'stat'
				gs 'zz_render', '', '', func('street_strings', 'local_str6')
				act 'Оглядеться':gt'saunaroom'
			end
		end
	end
	exit
end
if workDiskAtkPlayer = 1:
	workDisk = 1
	workDiskAtkPlayer = 0
	gs 'zz_render', '', 'images/sauna/car.jpg', func('street_strings', 'local_str7')
	if konvert = 0:
		workDolg = 200000
		workDolgDay = 7
		gs 'zz_render', '', '', func('street_strings', 'local_str8')
	else
		konvert = 0
		money += 5000
		gs 'zz_render', '', '', func('street_strings', 'local_str9')
	end
	act 'Уйти':gt $curloc
	exit
end
$zz_str = 'Перед вашим подъездом стоит ауди и около него флегматично стоит дожидаясь вас водитель Слава'
if vladimirday = day and hour >= 16 and week = 6:
	if vladimirQW = 30: '<a href="exec:GT ''qwmeet2''">'+$zz_str+'</a>'
	if vladimirQW = 40: '<a href="exec:GT ''qwmeet3''">'+$zz_str+'</a>'
end
killvar '$zz_str'
gs 'car', 'check'
gs 'zz_funcs', 'waiting'
if _taxi_time >= 0: gs 'taxi','check'
if tanga = 0 and func('zz_clothing', 'is_skirt') = 1 and hour > 6 and hour <= 20 and month > 3 and month < 10:
	if rand(0,100) >= 90:
		manna -= 5
		dom -= 1
		gs 'zz_render', '', '', func('street_strings', 'local_str11')
	end
end
if housr = 1: gs 'zz_render', '', '','В одной из многоэтажек расположен <a href="exec:gt''front_door'',''start''"><b>подъезд</b></a> вашего дома'
if hour > 22 or hour <= 3: gs 'zz_render', '', '','Во дворе дома вечно громко матерятся <a href="exec:GT''gopnew'',''start''">гопники</a>'
gs 'zz_render', '', '','Неподалеку от дома находится <a href="exec:GT ''trashplace''">мусорка</a>'
if hour >= 5 and hour <= 23: gs 'zz_render', '', '','Станция <a href="exec:GT ''metro'',''start''">Метро</a> расположена в 15 минутах ходьбы.'
if hour >= 8 and hour <= 20: gs 'zz_render', '', '','Недалеко от дома находится <a href="exec:GT ''shop'',''start''">Супермаркет</a><br>Бабушки стайками идут к <a href="exec:GT ''poli'',''start''">Поликлиннике</a>'
if hour >= 8 and hour <= 14 and week ! 1: gs 'zz_render', '', '','В 20-ти минутах ходьбы есть <a href="exec: minut += 10 & gt ''south_market'',''start''">Рынок</a>'
if hour >= 11 and hour < 12 and week > 1 and week < 5 and workKafe = 1: gs 'zz_render', '', '','Вы можете выйти на рабочую смену в <a href="exec:GT ''kafe'',''work''">Кафе</a>'
if hour >= 12 and hour <= 22 and week ! 1: gs 'zz_render', '', '','Неподалеку находится <a href="exec:GT ''kafe'',''start''">Кафе</a>.'
if clener > 1 and hour >= 7 and hour <= 22 or clener <= 1 and hour >= 8 and hour <= 17: gs 'zz_render', '', '','Немного дальше расположено <a href="exec:GT ''south_office'',''start''">офисное здание</a>, в котором есть небольшое швейное ателье.'
gs 'zz_render', '', '','В 20 минутах ходьбы расположен большой <a href="exec: minut += 20 & gt ''zz_park''">Парк Победы</a>, соединяющий все части города.<br>Единственное <a href="exec:minut += 60 & GT ''lake''">озеро</a> в городе находится на окраине в часе ходьбы<br><a href="exec:GT ''apteka''">Аптека</a>'
if katkey = 1: gs 'zz_render', '', '','Квартира <a href="exec:gt''katspalnya'',''start''">Кати</a>'
if $npc['44,qwIrina'] >= 1: gs 'zz_render', '', '','Дом в котором расположена квартира <a href="exec:GT ''IrinaRoom'',''start''">Ирины</a>'
if klofQW >= 2: gs 'zz_render', '', '','Квартира <a href="exec:GT ''klofdomhouse'',''start''">Жоры</a>'
if SNarkPriton > 0 and narkossista = 0: gs 'zz_render', '', '','Возле одного из подъездов постоянно валяются шприцы и на корточках сидят нарики с пустыми глазами: в одной из квартир тут находится <a href="exec:minut += 5 & GT ''narkopriton''">наркопритон</a>'
if hour >= 8 and hour <= 23 or saunaWorkWhore > 0 or workDisk = 2: gs 'zz_render', '', '','В 10 минутах ходьбы находится <a href="exec:minut += 15 & GT ''sauna''">Сауна</a>.'
if hour >= 10 and hour <= 20: gs 'zz_render','','','Под вывеской "Лотерея" на виду у всех работает <a href="exec:gt''gamehall''">Зал игровых автоматов</a>.'
if housr = 1 and hour = meethour:
	if svidanieA = 1: gs 'zz_render', '', '','<b>Около подъезда вас ожидает <a href="exec:GT ''meet'',''start''"><<$boyA>></a></b>'
	if svidanieB = 1: gs 'zz_render', '', '','<b>Около подъезда вас ожидает <a href="exec:GT ''svidan'',''start''"><<$boyB>></a></b>'
	if svidanieC = 1: gs 'zz_render', '', '','<b>Около подъезда вас ожидает <a href="exec:GT ''svidan'',''start''"><<$boyC>></a></b>'
end
if hour >= 8 and BDSMmeet >= 5 and BDSMclub = 1: gs 'zz_render', '', '','На самой окраине стоит роскошный особняк <a href="exec:GT ''BDSM_Club'',''start''">БДСМ клуба</a>'
if rand(0,100) = 100 and hour <= 3:
	gt 'zz_park','rapist'
end
if rand(0,100) = 100 and money >= 1000 and daystart >= 10 and hour <= 3:
	gt 'zz_park','robber'
end
streetrand = RAND(0,100)
if streetrand >= 100 and money >= 1000 and daystart >= 10 and hour <= 3:
	gt 'zz_park','theft'
elseif streetrand >= 10 and bfa < 1:
	if RAND(0,600) <= vnesh:
		gs'boy'
		gs 'zz_render', '', '', func('street_strings', 'local_str27')
		act 'Сказать ему телефон':
			cla
			gs'boyfrend','start'
			stopboy = 0
			gs 'zz_render', '', '', func('street_strings', 'local_str28')
			act 'Завершить прогулку':gt $curloc
		end
	end
end
gs 'zz_dyns', 'street_cum'