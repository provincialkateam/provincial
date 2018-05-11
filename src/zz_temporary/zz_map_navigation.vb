! отключаем показ карты на отдельных локациях
!---
killvar '$poi'
if func('zz_funcs','get_item_id','Testroom,menu_description,menu_statistika,menu_bag,zz_bathroom,zz_settings,zz_phone,zz_common,lake,ice_rink,glake,gLakeNude,gLakeNudeForest,zz_school,banda_home',$curloc) >= 0: exit
if $control_point = 'gorodok':
	! создаем массив точек интереса - $poi
	! Парк
	_poi_i = 0
	$poi['<<_poi_i>>,x'] = 208
	$poi['<<_poi_i>>,y'] = 70
	$poi['<<_poi_i>>,target'] = 'zz_park'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Парк'
	! 'DelParco
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 273
	$poi['<<_poi_i>>,y'] = 79
	$poi['<<_poi_i>>,target'] = 'cafe_parco'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Кафе "DelParco"''
	! Больница
	if hour >= 8 and hour <= 17:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 38
		$poi['<<_poi_i>>,y'] = 90
		$poi['<<_poi_i>>,target'] = 'gpoli'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Больница'
	end
	! Озеро, пляж
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 9
	$poi['<<_poi_i>>,y'] = 404
	$poi['<<_poi_i>>,target'] = 'glake'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Озеро'
	! Озеро, дикий пляж
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 97
	$poi['<<_poi_i>>,y'] = 577
	$poi['<<_poi_i>>,target'] = 'gLakeNude'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Дикий пляж'
	! Школа
	if hour >= 7 and hour <= 18 and school['block'] = 0:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 238
		$poi['<<_poi_i>>,y'] = 306
		$poi['<<_poi_i>>,target'] = 'gschool'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Школа'
	end
	! ДК
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 402
	$poi['<<_poi_i>>,y'] = 369
	$poi['<<_poi_i>>,target'] = 'gdk'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Дом культуры'
	! Зал игровых автоматов
	if hour >= 10 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 356
		$poi['<<_poi_i>>,y'] = 187
		$poi['<<_poi_i>>,target'] = 'gamehall'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Игровые автоматы'
	end
	!Кинотеатр
	if hour >= 10 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 154
		$poi['<<_poi_i>>,y'] = 239
		$poi['<<_poi_i>>,target'] = 'cinema'
		$poi['<<_poi_i>>,arg'] = 'init'
		$poi['<<_poi_i>>,tip'] = 'Кинотеатр'
	end
	! Супермаркет
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 456
		$poi['<<_poi_i>>,y'] = 191
		$poi['<<_poi_i>>,target'] = 'shop'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Супермаркет'
	end
	! Парикмахерская
	if hour >= 10 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 530
		$poi['<<_poi_i>>,y'] = 169
		$poi['<<_poi_i>>,target'] = 'barbershop'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Парикмахерская'
	end
	! Рынок
	if hour >= 8 and hour <= 16:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 596
		$poi['<<_poi_i>>,y'] = 312
		$poi['<<_poi_i>>,target'] = 'grinok'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Рынок'
	end
	! Привокзальная площадь
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 677
	$poi['<<_poi_i>>,y'] = 274
	$poi['<<_poi_i>>,target'] = 'vokzalG'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Привокзальная площадь'
	! Отель
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 681
	$poi['<<_poi_i>>,y'] = 365
	$poi['<<_poi_i>>,target'] = 'hotel'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Отель "Мимоза"'
	! Ж/д вокзал
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 732
	$poi['<<_poi_i>>,y'] = 260
	$poi['<<_poi_i>>,target'] = 'vokzalGin'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Ж/д вокзал'
	! привокзальное кафе
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 727
		$poi['<<_poi_i>>,y'] = 323
		$poi['<<_poi_i>>,target'] = 'gkafe'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Кафе "Привокзальное"'
	end
	! аптека
	if hour >= 8 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 525
		$poi['<<_poi_i>>,y'] = 383
		$poi['<<_poi_i>>,target'] = 'apteka'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Аптека'
	end
	! швейная фабрика
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 694
		$poi['<<_poi_i>>,y'] = 4
		$poi['<<_poi_i>>,target'] = 'Gshveyfab'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Швейная фабрика'
	end
	! гаражи
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 768
	$poi['<<_poi_i>>,y'] = 538
	$poi['<<_poi_i>>,target'] = 'gargazel'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Гаражи'
	! Дом Мейнольдов
	if $npc['15,qwVika'] >= 27 or ($npc['14,qwKatya'] >= 10 and $npc['14,homeward'] = 1) or $npc['0,meynold_key'] = 1:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 51
		$poi['<<_poi_i>>,y'] = 281
		$poi['<<_poi_i>>,target'] = 'mey_home'
		$poi['<<_poi_i>>,arg'] = 'main'
		$poi['<<_poi_i>>,tip'] = 'Дом Мейнольдов'
	end
	if func('zz_common','check_inhome') = 1:
		! Дом Альбины
		if $npc['23,qwMain'] = 55:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 139
			$poi['<<_poi_i>>,y'] = 400
			$poi['<<_poi_i>>,target'] = 'albina_ev'
			$poi['<<_poi_i>>,arg'] = ''
			$poi['<<_poi_i>>,tip'] = 'Дом Альбины'
		end
		! Дом Носова
		if DimaBeHomeOnce = 1 and DimaRudeBlock = 0:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 277
			$poi['<<_poi_i>>,y'] = 484
			$poi['<<_poi_i>>,target'] = 'dimaGoHome2'
			$poi['<<_poi_i>>,arg'] = ''
			$poi['<<_poi_i>>,tip'] = 'Дом Носова'
		end
		! квартира Груздевой
		if LariskaHomeIn > 0:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 547
			$poi['<<_poi_i>>,y'] = 251
			$poi['<<_poi_i>>,target'] = 'LariskaHome'
			$poi['<<_poi_i>>,arg'] = ''
			$poi['<<_poi_i>>,tip'] = 'квартира Груздевой'
		end
		! квартира Круглова
		if $npc['4,qwIgorLove'] > 0:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 483
			$poi['<<_poi_i>>,y'] = 117
			$poi['<<_poi_i>>,target'] = 'igorhome'
			$poi['<<_poi_i>>,arg'] = ''
			$poi['<<_poi_i>>,tip'] = 'квартира Круглова'
		end
	end
	!Квартира родителей
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 293
	$poi['<<_poi_i>>,y'] = 226
	$poi['<<_poi_i>>,target'] = 'korrPar'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Квартира родителей'
	! Выезд на трассу
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 870
	$poi['<<_poi_i>>,y'] = 165
	$poi['<<_poi_i>>,target'] = 'road'
	$poi['<<_poi_i>>,arg'] = '4'
	$poi['<<_poi_i>>,tip'] = 'Трасса М-7'
	! Автомойка, открывается только по ветке учителя
	if ($npc['26,qwMain'] = 127 and hour >= 10 and hour <= 17) or ($npc['0,carwash'] = 1 and hour >= 16 and hour <= 17):
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 845
		$poi['<<_poi_i>>,y'] = 225
		$poi['<<_poi_i>>,target'] = 'carwash'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Автомойка'
	end
	!------------------
elseif $control_point = 'north':
	! создаем массив точек интереса - $poi
	! Парк
	_poi_i = 0
	$poi['<<_poi_i>>,x'] = 825
	$poi['<<_poi_i>>,y'] = 555
	$poi['<<_poi_i>>,target'] = 'zz_park'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Парк Победы'
	! Северное шоссе
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 225
	$poi['<<_poi_i>>,y'] = 537
	$poi['<<_poi_i>>,target'] = 'road'
	$poi['<<_poi_i>>,arg'] = '0'
	$poi['<<_poi_i>>,tip'] = 'Северное шоссе'
	! Клиника милосердия
	if ((school['certificate'] = 0 and bumtolik = 0) or bumtolik > 3) and hour >= 9 and hour <= 17:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 27
		$poi['<<_poi_i>>,y'] = 70
		$poi['<<_poi_i>>,target'] = 'buklinik'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Клиника милосердия'
	end
	! Ж/д вокзал
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 178
	$poi['<<_poi_i>>,y'] = 51
	$poi['<<_poi_i>>,target'] = 'vokzal'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Ж/д вокзал'
	if hour >= 8 and hour <= 21:
		! Складской терминал
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 38
		$poi['<<_poi_i>>,y'] = 513
		$poi['<<_poi_i>>,target'] = 'Terminal'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Складской терминал'
	end
	if hour >= 9 and hour <= 17:
		! Автосалон
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 54
		$poi['<<_poi_i>>,y'] = 187
		$poi['<<_poi_i>>,target'] = 'autosalonF'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Автосалон'
		! Авторынок
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 16
		$poi['<<_poi_i>>,y'] = 200
		$poi['<<_poi_i>>,target'] = 'autotraidF'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Авторынок'
		! Автомастерская
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 38
		$poi['<<_poi_i>>,y'] = 129
		$poi['<<_poi_i>>,target'] = 'autoservisF'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Автомастерская'
	end
	if hour >= 5 and hour <= 23:
		! метро
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 261
		$poi['<<_poi_i>>,y'] = 91
		$poi['<<_poi_i>>,target'] = 'metro'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Метро'
	end
	if hour >= 9 and hour <= 20:
		! ДК имени Ленина
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 405
		$poi['<<_poi_i>>,y'] = 531
		$poi['<<_poi_i>>,target'] = 'dk'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'ДК им.Ленина'
	end
	if hour >= 12 or hour <= 4:
		! Шашлычная
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 468
		$poi['<<_poi_i>>,y'] = 28
		$poi['<<_poi_i>>,target'] = 'lakecafe'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Шашлычная'
	end
	if hour >= 8 and hour <= 20:
		! Супермаркет
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 493
		$poi['<<_poi_i>>,y'] = 120
		$poi['<<_poi_i>>,target'] = 'shop'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Супермаркет'
		! СКК “Турбина”
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 64
		$poi['<<_poi_i>>,y'] = 392
		$poi['<<_poi_i>>,target'] = 'skk'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'СКК “Турбина”'
	end
	if hour >= 10 and hour <= 20:
		! Игровые автоматы
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 588
		$poi['<<_poi_i>>,y'] = 477
		$poi['<<_poi_i>>,target'] = 'gamehall'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Игровые автоматы'
	end
	if hour >= 12 and hour <= 19:
		! Пирсинг-салон
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 632
		$poi['<<_poi_i>>,y'] = 335
		$poi['<<_poi_i>>,target'] = 'pirsingsalon'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Пирсинг-салон'
	end
	if hour >= 8 and hour <= 18:
		! Аптека
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 440
		$poi['<<_poi_i>>,y'] = 392
		$poi['<<_poi_i>>,target'] = 'apteka'
		$poi['<<_poi_i>>,arg'] = 'init'
		$poi['<<_poi_i>>,tip'] = 'Аптека'
	end
	! Банда
	if banda['agent_zeropussy'] = 1:
		! Бандитская квартира
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 611
		$poi['<<_poi_i>>,y'] = 381
		$poi['<<_poi_i>>,target'] = 'banda_home'
		$poi['<<_poi_i>>,arg'] = 'corridor'
		$poi['<<_poi_i>>,tip'] = 'Бандитская квартира'
	end
	if banda['studio_start'] = 1 and banda['studio'] = 0:
		! Бандитский склад
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 26
		$poi['<<_poi_i>>,y'] = 448
		$poi['<<_poi_i>>,target'] = 'banda_sklad'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Бандитский склад'
	end
	if banda['studio'] = 1 and hour >= 9 and hour <= 18:
		! Порностудия
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 152
		$poi['<<_poi_i>>,y'] = 456
		$poi['<<_poi_i>>,target'] = 'zz_pornstudio'
		$poi['<<_poi_i>>,arg'] = 'main'
		$poi['<<_poi_i>>,tip'] = 'Ваша порностудия'
	end
elseif $control_point = 'center':
	! Парк
	_poi_i = 0
	$poi['<<_poi_i>>,x'] = 872
	$poi['<<_poi_i>>,y'] = 47
	$poi['<<_poi_i>>,target'] = 'zz_park'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Парк Победы'
	! Аптека
	if hour >= 8 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 186
		$poi['<<_poi_i>>,y'] = 153
		$poi['<<_poi_i>>,target'] = 'apteka'
		$poi['<<_poi_i>>,arg'] = 'init'
		$poi['<<_poi_i>>,tip'] = 'Аптека'
	end
	! Квартира Тани
	if $npc['31,qwTanyaMain'] > 3:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 65
		$poi['<<_poi_i>>,y'] = 248
		$poi['<<_poi_i>>,target'] = 'tanya_apartment'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Квартира Тани'
	end
	! Квартира Питэра
	if $npc['32,relation'] > 45:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 815
		$poi['<<_poi_i>>,y'] = 502
		$poi['<<_poi_i>>,target'] = 'peterroom'
		$poi['<<_poi_i>>,arg'] = 'start_door'
		$poi['<<_poi_i>>,tip'] = 'Квартира Питэра'
	end
	! Стрип-клуб
	if hour >= 15 or hour <= 2:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 420
		$poi['<<_poi_i>>,y'] = 91
		$poi['<<_poi_i>>,target'] = 'stripclub'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Стрип-клуб'
	end
	! Бордель
	if bordel > 0 and (hour >= 20 or hour <= 3):
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 623
		$poi['<<_poi_i>>,y'] = 201
		$poi['<<_poi_i>>,target'] = 'bordel'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Бордель'
	end
	! Ресторан
	if hour >= 12 and hour <= 22:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 318
		$poi['<<_poi_i>>,y'] = 489
		$poi['<<_poi_i>>,target'] = 'restoran'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Ресторан \"Bordeaux\"'
	end
	! Ночной клуб
	if hour >= 15:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 200
		$poi['<<_poi_i>>,y'] = 410
		$poi['<<_poi_i>>,target'] = 'club'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Ночной клуб \"Магнат\"'
	end
	!--
	if hour >= 9 and hour <= 20:
		! Фитнес-центр
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 299
		$poi['<<_poi_i>>,y'] = 14
		$poi['<<_poi_i>>,target'] = 'fitness'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Фитнес-центр'
		! Кино
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 413
		$poi['<<_poi_i>>,y'] = 283
		$poi['<<_poi_i>>,target'] = 'cinema'
		$poi['<<_poi_i>>,arg'] = 'init'
		$poi['<<_poi_i>>,tip'] = 'Кинотеатр'
		! Игровые автоматы
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 44
		$poi['<<_poi_i>>,y'] = 44
		$poi['<<_poi_i>>,target'] = 'gamehall'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Игровые автоматы'
	end
	! Супермаркет
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 64
		$poi['<<_poi_i>>,y'] = 492
		$poi['<<_poi_i>>,target'] = 'shop'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Супермаркет'
	end
	! Кафе "Быстроешка"
	if hour >= 6 and hour <= 23:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 484
		$poi['<<_poi_i>>,y'] = 424
		$poi['<<_poi_i>>,target'] = 'burger'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Кафе \"Быстроешка\"'
	end
	if hour >= 9 and hour <= 20:
		! Боулинг
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 91
		$poi['<<_poi_i>>,y'] = 338
		$poi['<<_poi_i>>,target'] = 'bouling'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Боулинг-клуб'
	end
	if hour >= 10 and hour <= 17:
		! Фотостудия "Стоп-кадр"
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 470
		$poi['<<_poi_i>>,y'] = 373
		$poi['<<_poi_i>>,target'] = 'foto'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Фотостудия \"Стоп-кадр\"'
		! Кис-Киска
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 312
		$poi['<<_poi_i>>,y'] = 318
		$poi['<<_poi_i>>,target'] = 'kiskis'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Магазин одежды \"Кис-Киска\"'
		! Бутик
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 553
		$poi['<<_poi_i>>,y'] = 255
		$poi['<<_poi_i>>,target'] = 'butik'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Бутик'
		! Салон красоты
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 660
		$poi['<<_poi_i>>,y'] = 223
		$poi['<<_poi_i>>,target'] = 'salon'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Салон красоты'
		! Киностудия "Ню"
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 402
		$poi['<<_poi_i>>,y'] = 181
		$poi['<<_poi_i>>,target'] = 'pornstudio'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Киностудия \"Ню\"'
	end
	! Центральный Банк
	if hour >= 9 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 254
		$poi['<<_poi_i>>,y'] = 330
		$poi['<<_poi_i>>,target'] = 'bank'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Центральный Банк \"Кащей и Ко\"'
	end
	if hour >= 8 and hour <= 17:
		! Проектная организация
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 729
		$poi['<<_poi_i>>,y'] = 113
		$poi['<<_poi_i>>,target'] = 'office'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Проектная организация'
		! Агентство недвижимости
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 503
		$poi['<<_poi_i>>,y'] = 110
		$poi['<<_poi_i>>,target'] = 'agentned'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Агентство недвижимости'
	end
	! Метро "Университетская"
	if hour >= 5 and hour <= 23:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 502
		$poi['<<_poi_i>>,y'] = 311
		$poi['<<_poi_i>>,target'] = 'metro'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Метро \"Университетская\"'
	end
	! Студенческий городок
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 682
	$poi['<<_poi_i>>,y'] = 397
	$poi['<<_poi_i>>,target'] = 'uni_campus'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Студенческий городок'
	 !Учебный корпус
	if hour >= 7 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 483
		$poi['<<_poi_i>>,y'] = 515
		$poi['<<_poi_i>>,target'] = 'university'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Университет'
	end
	! Кафе "Gaudeamus"
	if hour >= 10 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 700
		$poi['<<_poi_i>>,y'] = 345
		$poi['<<_poi_i>>,target'] = 'uni_campus'
		$poi['<<_poi_i>>,arg'] = 'caffe'
		$poi['<<_poi_i>>,tip'] = 'Кафе \"Gaudeamus\"'
	end
	!--
	if university['student'] > 0:
		! Университетское общежитие
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 584
		$poi['<<_poi_i>>,y'] = 454
		$poi['<<_poi_i>>,target'] = 'uni_dorm'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Университетское общежитие'
	end
	! Секс-шоп "Подружка"
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 278
	$poi['<<_poi_i>>,y'] = 210
	$poi['<<_poi_i>>,target'] = 'sexshop'
	$poi['<<_poi_i>>,arg'] = 'start'
	$poi['<<_poi_i>>,tip'] = 'Секс-шоп \"Подружка\"'
elseif $control_point = 'south':
	! Парк
	_poi_i = 0
	$poi['<<_poi_i>>,x'] = 146
	$poi['<<_poi_i>>,y'] = 71
	$poi['<<_poi_i>>,target'] = 'zz_park'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Парк Победы'
	!' Аттракционы в парке
	if month >= 5 and month <= 9 and func('zz_weather','is_day') = 1:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 127
		$poi['<<_poi_i>>,y'] = 172
		$poi['<<_poi_i>>,target'] = 'zz_park'
		$poi['<<_poi_i>>,arg'] = 'lunapark'
		$poi['<<_poi_i>>,tip'] = 'Аттракционы'
	end'
	! Озеро
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 691
	$poi['<<_poi_i>>,y'] = 38
	$poi['<<_poi_i>>,target'] = 'lake'
	$poi['<<_poi_i>>,arg'] = ''
	$poi['<<_poi_i>>,tip'] = 'Озеро'
	! Аптека
	if hour >= 8 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 717
		$poi['<<_poi_i>>,y'] = 176
		$poi['<<_poi_i>>,target'] = 'apteka'
		$poi['<<_poi_i>>,arg'] = 'init'
		$poi['<<_poi_i>>,tip'] = 'Аптека'
	end
	!--
	if hour >= 10 and hour <= 20:
		!'Зоопарк
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 238
		$poi['<<_poi_i>>,y'] = 15
		$poi['<<_poi_i>>,target'] = 'zoo'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Зоопарк''
		! Игровые автоматы
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 439
		$poi['<<_poi_i>>,y'] = 263
		$poi['<<_poi_i>>,target'] = 'gamehall'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Игровые автоматы'
		! 'Кафешка в парке
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 211
		$poi['<<_poi_i>>,y'] = 149
		$poi['<<_poi_i>>,target'] = 'parkKafe'
		$poi['<<_poi_i>>,arg'] = 'food'
		$poi['<<_poi_i>>,tip'] = 'Кафе \"Парк\"''
		! Йога, массаж, сауна
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 332
		$poi['<<_poi_i>>,y'] = 372
		$poi['<<_poi_i>>,target'] = 'relax'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Студия \"Relax\"'
		! Школа танцев
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 450
		$poi['<<_poi_i>>,y'] = 512
		$poi['<<_poi_i>>,target'] = 'danceclass'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Школа танцев'
		! Бильярд
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 811
		$poi['<<_poi_i>>,y'] = 276
		$poi['<<_poi_i>>,target'] = 'billiard'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Бильярдный зал \"Дуплет\"'
	end
	!--
	if housr = 1:
		! 'Подъезд дома
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 305
		$poi['<<_poi_i>>,y'] = 490
		$poi['<<_poi_i>>,target'] = 'front_door'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Подъезд дома''
		! Дворик дома
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 257
		$poi['<<_poi_i>>,y'] = 467
		$poi['<<_poi_i>>,target'] = 'homeyard'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Дворик дома'
	end
	! Квартира Кати
	if katkey = 1:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 539
		$poi['<<_poi_i>>,y'] = 193
		$poi['<<_poi_i>>,target'] = 'katspalnya'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Квартира Кати'
	end
	! Квартира Ирины
	if $npc['44,qwIrina'] >= 1:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 624
		$poi['<<_poi_i>>,y'] = 448
		$poi['<<_poi_i>>,target'] = 'IrinaRoom'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Квартира Ирины'
	end
	! Кафе Кавказ
	if hour >= 11 and hour <= 22:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 718
		$poi['<<_poi_i>>,y'] = 393
		$poi['<<_poi_i>>,target'] = 'kafe'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Кафе \"Кавказ\"'
	end
	! Пиццерия
	if hour >= 11 and hour <= 21:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 424
		$poi['<<_poi_i>>,y'] = 102
		$poi['<<_poi_i>>,target'] = 'pizza'
		$poi['<<_poi_i>>,arg'] = 'pizzaholl'
		$poi['<<_poi_i>>,tip'] = 'Пиццерия \"Феличита\"'
	end
	! Супермаркет
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 82
		$poi['<<_poi_i>>,y'] = 352
		$poi['<<_poi_i>>,target'] = 'shop'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Супермаркет \"Карта\"'
	end
	! Рынок
	if hour >= 8 and hour <= 14:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 321
		$poi['<<_poi_i>>,y'] = 286
		$poi['<<_poi_i>>,target'] = 'south_market'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Рынок \"Бабушкинский\"'
	end
	! Офисное здание
	if clener > 1 and hour >= 7 and hour <= 22 or clener <= 1 and hour >= 8 and hour <= 17:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 334
		$poi['<<_poi_i>>,y'] = 110
		$poi['<<_poi_i>>,target'] = 'south_office'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Офисное здание'
	end
	! Метро "Южная"
	if hour >= 5 and hour <= 23:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 409
		$poi['<<_poi_i>>,y'] = 416
		$poi['<<_poi_i>>,target'] = 'metro'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Метро \"Южная\"'
	end
	if hour >= 8 and hour <= 17:
		! Поликлиника
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 87
		$poi['<<_poi_i>>,y'] = 553
		$poi['<<_poi_i>>,target'] = 'poli'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'Поликлиника'
		! Ателье
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 215
		$poi['<<_poi_i>>,y'] = 304
		$poi['<<_poi_i>>,target'] = 'tailor'
		$poi['<<_poi_i>>,arg'] = ''
		$poi['<<_poi_i>>,tip'] = 'Ателье \"БелоШвейк\"'
	end
	!Особняк - БДСМ клуб
	if hour >= 8 and BDSMmeet >= 5 and BDSMclub = 1:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 835
		$poi['<<_poi_i>>,y'] = 82
		$poi['<<_poi_i>>,target'] = 'BDSM_Club'
		$poi['<<_poi_i>>,arg'] = 'start'
		$poi['<<_poi_i>>,tip'] = 'БДСМ клуб."'
	end
	! временная локация - квартира Суворова - появляется только при прохождении ветки учителя
	if (hour = 19 or hour = 20) and $npc['26,qwMain'] >= 116 and $npc['26,qwMain'] < 120:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 748
		$poi['<<_poi_i>>,y'] = 526
		$poi['<<_poi_i>>,target'] = 'tsarev_events'
		$poi['<<_poi_i>>,arg'] = 'teacher_choice_detective10'
		$poi['<<_poi_i>>,tip'] = 'Квартира Суворова'
	end
end
$_poi_str = ''
for _poi_i = 0 to arrsize('$poi')/5 - 1:
	$_poi_str += '<a class="tip" title="<font color=black>'+$poi['<<_poi_i>>,tip']+'" onclick="javascript:clearPoiTip()" href="exec: gs ''zz_clothing2'',''fix_emergency'' & gt '''+$poi['<<_poi_i>>,target']+''','''+$poi['<<_poi_i>>,arg']+'''"><div class="poi" style="left:'+$poi['<<_poi_i>>,x']+'px;top:'+$poi['<<_poi_i>>,y']+'px;"></font></div></a>'
end
if $_poi_str ! '' :
	!карта на весь экран, если включена в настройках
	if $settings['show_map'] = 1 and $curloc = $control_point:
		*p '<div id="qsp-mapbox-full" style="background:url(images/common/maps/'+$control_point+'.png)"><<$_poi_str>></div>'
		*p '<script>showPoi();</script>'
	else
		!*p '<div id="qsp-mapbox" class="tip" title="Карта" style="background:url(images/common/maps/'+$control_point+'.png)" onclick="resizeUIMap();"><<$_poi_str>></div>'
	end
	!вызов карты из меню справа
	if $args[0] = 'button' and $curloc = $control_point:
		*p '<div id="qsp-mapbox-full" style="background:url(images/common/maps/'+$control_point+'.png)"><<$_poi_str>></div>'
		*p '<script>showPoi();</script>'
		act 'Убрать карту': gt $curloc
	elseif $args[0] = 'button' and ($curloc ! $control_point or $curloc = 'vokzalG'):
		msg '<font color=black>Картой можно воспользоваться только на улице!</font>'
	end
end
killvar '$poi'
killvar '$_poi_str'
killvar '_poi_i'