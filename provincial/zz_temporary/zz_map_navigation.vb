! отключаем показ карты на отдельных локациях
if func('zz_funcs','get_item_id','Testroom,menu_description,menu_statistika,menu_bag,zz_settings,zz_phone,zz_common,glake,gLakeNude,gLakeNudeForest,zz_school',$curloc) >= 0: exit
!---
killvar '$poi'
if $control_point = 'gorodok':
	! создаем массив точек интереса - $poi
	! Парк
	_poi_i = 0
	$poi['<<_poi_i>>,x'] = 210
	$poi['<<_poi_i>>,y'] = 189
	$poi['<<_poi_i>>,target'] = 'zz_park'
	! DelParco
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 276
	$poi['<<_poi_i>>,y'] = 197
	$poi['<<_poi_i>>,target'] = 'cafe_parco'
	! Больница
	if hour >= 8 and hour <= 17:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 42
		$poi['<<_poi_i>>,y'] = 206
		$poi['<<_poi_i>>,target'] = 'gpoli'
	end
	! Озеро, пляж
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 12
	$poi['<<_poi_i>>,y'] = 519
	$poi['<<_poi_i>>,target'] = 'glake'
	! Озеро, дикий пляж
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 100
	$poi['<<_poi_i>>,y'] = 690
	$poi['<<_poi_i>>,target'] = 'gLakeNude'
	! Школа
	if hour >= 7 and hour <= 18 and school['block'] = 0:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 239
		$poi['<<_poi_i>>,y'] = 422
		$poi['<<_poi_i>>,target'] = 'gschool'
	end
	! ДК
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 405
	$poi['<<_poi_i>>,y'] = 483
	$poi['<<_poi_i>>,target'] = 'gdk'
	! Зал игровых автоматов
	if hour >= 10 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 356
		$poi['<<_poi_i>>,y'] = 304
		$poi['<<_poi_i>>,target'] = 'gamehall'
	end
	!Кинотеатр
	if hour >= 10 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 160
		$poi['<<_poi_i>>,y'] = 354
		$poi['<<_poi_i>>,target'] = 'cinema'
	end
	! Супермаркет
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 455
		$poi['<<_poi_i>>,y'] = 307
		$poi['<<_poi_i>>,target'] = 'shop'
	end
	! Парикмахерская
	if hour >= 10 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 530
		$poi['<<_poi_i>>,y'] = 286
		$poi['<<_poi_i>>,target'] = 'barbershop'
	end
	! Рынок
	if hour >= 8 and hour <= 16:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 596
		$poi['<<_poi_i>>,y'] = 428
		$poi['<<_poi_i>>,target'] = 'grinok'
	end
	! Привокзальная площадь
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 674
	$poi['<<_poi_i>>,y'] = 387
	$poi['<<_poi_i>>,target'] = 'vokzalG'
	! Отель
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 680
	$poi['<<_poi_i>>,y'] = 481
	$poi['<<_poi_i>>,target'] = 'hotel'
	! Ж/д вокзал
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 731
	$poi['<<_poi_i>>,y'] = 376
	$poi['<<_poi_i>>,target'] = 'vokzalGin'
	! привокзальное кафе
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 725
		$poi['<<_poi_i>>,y'] = 438
		$poi['<<_poi_i>>,target'] = 'gkafe'
	end
	! аптека
	if hour >= 8 and hour <= 18:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 524
		$poi['<<_poi_i>>,y'] = 499
		$poi['<<_poi_i>>,target'] = 'apteka'
	end
	! швейная фабрика
	if hour >= 8 and hour <= 20:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 668
		$poi['<<_poi_i>>,y'] = 59
		$poi['<<_poi_i>>,target'] = 'Gshveyfab'
	end
	! гаражи
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 765
	$poi['<<_poi_i>>,y'] = 650
	$poi['<<_poi_i>>,target'] = 'gargazel'
	! Дом Мейнольдов
	if $npc['15,qwVika'] >= 27 or ($npc['14,qwKatya'] >= 10 and $npc['14,homeward'] = 1) or $npc['0,meynold_key'] = 1:
		_poi_i += 1
		$poi['<<_poi_i>>,x'] = 54
		$poi['<<_poi_i>>,y'] = 397
		$poi['<<_poi_i>>,target'] = 'mey_home'
	end
	if func('zz_common','check_inhome') = 1:
		! Дом Альбины
		if $npc['23,qwMain'] = 55:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 142
			$poi['<<_poi_i>>,y'] = 516
			$poi['<<_poi_i>>,target'] = 'albina_ev'
		end
		! Дом Носова
		if DimaBeHomeOnce = 1 and DimaRudeBlock = 0:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 279
			$poi['<<_poi_i>>,y'] = 597
			$poi['<<_poi_i>>,target'] = 'dimaGoHome2'
		end
		! квартира Груздевой
		if LariskaHomeIn > 0:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 547
			$poi['<<_poi_i>>,y'] = 367
			$poi['<<_poi_i>>,target'] = 'LariskaHome'
		end
		! квартира Круглова
		if $npc['4,qwIgorLove'] > 0:
			_poi_i += 1
			$poi['<<_poi_i>>,x'] = 482
			$poi['<<_poi_i>>,y'] = 234
			$poi['<<_poi_i>>,target'] = 'igorhome'
		end
	end
	!Квартира родителей
	_poi_i += 1
	$poi['<<_poi_i>>,x'] = 293
	$poi['<<_poi_i>>,y'] = 342
	$poi['<<_poi_i>>,target'] = 'korrPar'
	!------------------
	$_poi_str = ''
	_poi_i = 0
	:loop_poi
	if _poi_i < arrsize('$poi')/3:
		$_poi_str += '<a href="exec:minut+=rand(5,10) & gt '''+$poi['<<_poi_i>>,target']+''','''+$poi['<<_poi_i>>,arg']+'''"><div class="poi" style="left:'+$poi['<<_poi_i>>,x']+'px;top:'+$poi['<<_poi_i>>,y']+'px;"></div></a>'
		_poi_i += 1
		jump 'loop_poi'
	end
	*p '<div id="qsp-mapbox" class="tip" title="Карта" style="background:url(images/common/maps/pavlovo.png)" onclick="resizeUIMap();"><<$_poi_str>></div>'
end
killvar '$poi'
killvar '$_poi_str'
killvar '_poi_i'