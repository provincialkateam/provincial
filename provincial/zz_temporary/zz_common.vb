if $args[0] = 'icecream':
	*clr & cla
	gs 'zz_render','','pic/icecream_shop.jpg','Мороженое предлагают за 50 рублей.'
	act 'Назад': gt 'zz_common','shop_back'
	if money >= 50:
		act 'Купить мороженое':
			*clr & cla
			minut += 10
			money -= 50
			body['day_weight'] += 1
			manna += 10
			water += 3
			energy += 3
			gs 'stat'
			gs 'zz_render','','images/pic/icecream.jpg','Вы купили мороженое и съели его не отходя далеко от прилавка.'
			act 'Назад': gt 'zz_common','shop_back'
		end
	end
end
if $args[0] = 'coffee':
	*clr & cla
	act 'Назад': gt 'zz_common','shop_back'
	killvar '$_coffee'
	$_coffee['0,name'] = 'Эспрессо'
	$_coffee['0,price'] = 30
	$_coffee['0,water'] = 1
	$_coffee['0,fun'] = 5
	$_coffee['1,name'] = 'Допио'
	$_coffee['1,price'] = 30
	$_coffee['1,water'] = 1
	$_coffee['1,fun'] = 5
	$_coffee['2,name'] = 'Американо'
	$_coffee['2,price'] = 30
	$_coffee['2,water'] = 3
	$_coffee['2,fun'] = 5
	$_coffee['3,name'] = 'Капуччино'
	$_coffee['3,price'] = 40
	$_coffee['3,water'] = 3
	$_coffee['3,fun'] = 10
	$_coffee['4,name'] = 'Мокаччино'
	$_coffee['4,price'] = 50
	$_coffee['4,water'] = 3
	$_coffee['4,fun'] = 15
	$_coffee['5,name'] = 'Латте'
	$_coffee['5,price'] = 50
	$_coffee['5,water'] = 3
	$_coffee['5,fun'] = 15
	! make table
	$_str = '<table border=0 width=400 cellpadding=0 cellspacing=1>'
	i = 0
	:loop_coffee
	$_str += '<tr bgcolor='+iif(i mod 2 = 0,'#f3f4ee','#ffffff')+'><td>'+$_coffee['<<i>>,name']+'</td><td align=center>'+iif(money>=val($_coffee['<<i>>,price']),'<a href="exec:gt''zz_common'',''select_coffee'',<<i>>">'+$_coffee['<<i>>,price']+'</a>',$_coffee['<<i>>,price'])+' руб.</td></tr>'
	i += 1
	if i < arrsize('$_coffee')/4: jump 'loop_coffee'
	$_str += '</table></center>'
	gs 'zz_render','','pic/coffee_shop.jpg','<center>На ваш выбор есть несколько напитков:<br>'+$_str
	killvar '$_str'
end
if $args[0] = 'select_coffee':
	*clr & cla
	money -= val($_coffee['<<args[1]>>,price'])
	water += val($_coffee['<<args[1]>>,water'])
	manna += val($_coffee['<<args[1]>>,fun'])
	minut += 15
	son += 3
	coffee_drink += 1
	if coffee_drink = 3:
		manna -= RAND(15,30)
		health -= 5
		gs 'zz_render','','pic/davlenie.jpg','Сегодня вы выпили слишком много кофе и у вас поднялось давление.'
	else
		gs 'zz_render','','pic/coffee_cup0.jpg','Вы выпили чашечку ароматного '+$_coffee['<<args[1]>>,name']+', отчего чувствуете себя немного бодрее и веселее.'
	end
	killvar '$_coffee'
	gs 'stat'
	act 'Назад': gt 'zz_common','shop_back'
end
if $args[0] = 'shop_back':
	if $loc = 'cafe_parco':
		gt 'cafe_parco','inner'
	elseif $loc = 'uni_campus':
		gt 'uni_campus','caffe'
	elseif $loc = 'burger':
		gt 'burger','start'
	elseif $loc = 'skk':
		gt 'skk'
	else
		gt 'shop'
	end
end
! ---
if $args[0] = 'drug_day':
	act 'Нюхнуть бледной леди 5 мин':
		*clr & cla
		minut += 5
		narkday = day
		health = 100
		manna += 10
		horny = 100
		nark += 10
		dur -= 1
		gs 'zz_render','','pic/dur.jpg','Вы отсыпали дозу порошка и нюхнули его, после этого вы почувствовали себя просто превосходно.'
		act 'Выйти': gt $loc, $metka
	end
end
if $args[0] = 'read_porn':
	act 'Листать порножурнал':
		*clr & cla
		gs 'zz_render', '', 'qwest/alter/porn.jpg'
		if pornMagazine = 1:
			gs 'zz_render', '', '', func('din2_strings', 'local_str3')
		else
			pornMagazine -= 1
			horny += 10
			minut += 5
			gs 'stat'
			gs 'zz_render', '', '', func('din2_strings', 'local_str4')
		end
		act 'Выйти':gt $curloc
	end
end
if $args[0] = 'cumeater':
	gs 'zz_funcs', 'cum', 'lip'
	vaf += 1
	if $args[0] = 'belly': cumbelly = 0 & $_str = 'с живота'
	if $args[0] = 'pussy': cumpussy = 0 & $_str = 'из киски'
	if $args[0] = 'ass': cumass = 0 & $_str = 'с попы'
	if $args[0] = 'face': cumface = 0 & $_str = 'с лица'
	if $args[0] = 'frot': cumfrot = 0 & $_str = 'с одежды'
	if $args[0] = 'anus': cumanus = 0 & $_str = 'из ануса'
	$result = 'Вы собрали пальцами сперму ' + $_str + ' и облизали их, почувствовав терпкий вкус спермы.'
	killvar '$_str'
	gs 'stat'
end
! args[1] - пробежка (0) или тренировка (1)
if $args[0] = 'crossing':
	_training = iif(args[1]=0,1,2)
	running_day = day
	body['day_weight'] -= 1
	beg += RAND(2,5) * _training
	speed += RAND(1,2) * _training
	minut += 60 * _training
	gs 'zz_funcs','sport', _training
	if _training = 1:
		gs 'zz_render','',func('zz_funcs','mk_image','common/sport/cross/cross_park'),'Вы в течение часа бегаете по парку, не давая себе заплыть жирком.'
	else
		gs 'zz_render','',func('zz_funcs','mk_image','common/sport/cross/cross'),'Вы в течение двух часов бегаете стадиону, развивая скорость и навыки бега.'
	end
	killvar '_training'
	gs 'stat'
end
! --- start workout ---!
if $args[0] = 'home_workout':
	$zz_str = ''
	if obruch > 0 and obruchday ! day: $zz_str += '<a href="exec: gs''zz_common'',''sitrobrd''">крутить обруч</a>, '
	if skak > 0 and skakday ! day: $zz_str += '<a href="exec: gs''zz_common'',''sitrskakd''">прыжки на скакалке</a>, '
	if pressday ! day: $zz_str += '<a href="exec: gs''zz_common'',''sitrpressd''">упражнения на пресс</a>, '
	if pushday ! day: $zz_str += '<a href="exec: gs''zz_common'',''sitrpushd''">отжимания</a>, '
	if (obruch > 0 and obruchday ! day) or (skak > 0 and skakday ! day) or pressday ! day or pushday ! day: gs 'zz_render','','','В тесной комнатке однако есть место, где можно поделать разные спортивные упражнения, такие как ' + mid($zz_str, 1, len($zz_str) - 2)
	killvar '$zz_str'
end
if $args[0] = 'sitrobrd':
	*clr & cla
	minut += 15
	obruchday = day
	if agil < 40: agil += 1
	gs 'zz_funcs', 'sport'
	gs 'zz_render','','pic/obruch.gif','Вы крутите обруч в течение пятнадцати минут, развивая ловкость.'
	act 'Выйти': gt $curloc, $metka
end
if $args[0] = 'sitrskakd':
	*clr & cla
	minut += 15
	skakday = day
	if speed < 40: speed += 1
	gs 'zz_funcs', 'sport'
	gs 'zz_render','','pic/skak.jpg','Вы в течение пятнадцати минут прыгаете на скакалке, развивая скорость.'
	act 'Выйти': gt $curloc, $metka
end
if $args[0] = 'sitrpressd':
	*clr & cla
	minut += 15
	pressday = day
	if vital < 40: vital += 1
	gs 'zz_funcs', 'sport'
	gs 'zz_render','','common/body/gym/press.jpg','Вы делаете упражнения на пресс в течение пятнадцати минут, развивая выносливость.'
	act 'Выйти': gt $curloc, $metka
end
if $args[0] = 'sitrpushd':
	*clr & cla
	minut += 15
	pushday = day
	if stren < 40: stren += 1
	gs 'zz_funcs', 'sport'
	gs 'zz_render','','common/body/gym/push.jpg','Вы отжимаетесь от пола в течение пятнадцати минут, развивая силу.<br>Вам удалось чисто отжаться <<RAND(stren/10,stren/5)>> раз.'
	act 'Выйти': gt $curloc, $metka
end
! --- end workout ---!
if $args[0] = 'watch_tv_on_sofa':
	*clr & cla
	if watch_tv_count = 0:
		gs 'zz_render','','wannabe/tv_off.jpg','Вы садитесь рядом с выключенным телевизором'
		act 'Включить телевизор':
			minut += 60
			manna += RAND(10,50)
			watch_tv_count = 1
			gs 'zz_common', 'watch_tv_on_sofa'
		end
	else
		! Светка может случайно уснуть на пару часиков
		if son < 8 and hour < 5 and rand(0,100) > manna:
			cla
			act 'Встать': gt $loc, $metka
			gs 'zz_render','','wannabe/tv_off.jpg','Вы задремали под монотонное бубнение телевизора и проспали некоторое время.'
			minut += rand(60,120)
			son += 4
			gs 'stat'
			exit
		end
		gs 'stat'
		$zz_str = 'common/tv/tv_watch_'+rand(1,3)
		gs 'zz_render','',$zz_str+'.jpg','Вы смотрите телевизор, лёжа на диване. Смотреть почти нечего - сплошная реклама, идиотские телешоу и унылые сериалы.'
		killvar '$zz_str'
		if $loc = 'sitrPar' and hour = 23 and brother_tv_enable = 0 and family_trip = 0: gt 'brother_events','go_away'
		act 'Переключить канал':
			minut += 60
			manna += RAND(10,50)
			gs 'zz_common', 'watch_tv_on_sofa'
		end
	end
	act 'Встать с дивана': killvar 'watch_tv_count' & gt $loc, $metka
end
if $args[0] = 'run_competition':
	gs 'zz_render','','pic/begsor.jpg','Девушки, забег на 400 метров. Вы переодеваетесь, выходите на беговую дорожку и встаёте на старт. Раздаётся стартовый выстрел.'
	cla
	! базовое значение сложности
	zz_base = 0
	! приращение
	zz_step = 10
	! итератор
	zz_i = 0
	! уровень сложность
	zz_diff = 1
	zz_money = 0
	if $args[1] = 'school': zz_base = 0					  & $zz_wins[0] = ''
	if $args[1] = 'city': zz_base = 70  				  & $zz_wins[0] = ''
	if $args[1] = 'run0': zz_base = 0   & zz_money = 300  & $zz_wins[0] = ' и 3й спортивный разряд по бегу.'
	if $args[1] = 'run1': zz_base = 70  & zz_money = 600  & $zz_wins[0] = ' и 2й спортивный разряд по бегу.'
	if $args[1] = 'run2': zz_base = 130 & zz_money = 1000 & $zz_wins[0] = ' и 1й спортивный разряд по бегу. Вы становитесь Чемпионкой города по бегу.'
	if $args[1] = 'run3': zz_base = 200 & zz_money = 1500 & $zz_wins[0] = ' и звание КМС по бегу. Вы становитесь чемпионкой области.'
	if $args[1] = 'run4': zz_base = 270 & zz_money = 2000 & $zz_wins[0] = ' и звание Мастер спорта по бегу. Вы становитесь чемпионкой региона.'
	if $args[1] = 'run5': zz_base = 330 & zz_diff = 2 	& zz_money = 3000 & $zz_wins[0] = ' и звание Мастер спорта международного класса по бегу. Вы становитесь Чемпионкой России.'
	if $args[1] = 'run6': zz_base = 450 & zz_step = 50  & zz_diff = 3 & zz_money = 5000 & $zz_wins[0] = ''
	if $args[1] = 'run7': zz_base = 450 & zz_step = 340 & zz_diff = 4 & zz_money = 8000 & $zz_wins[0] = ' Вы чемпионка Европы.'
	$zz_result[0] = 'Вы неплохо пробежали, для дилетантки конечно, заняв последнее 8 место.'
	$zz_result[1] = 'Вы упорно боролись, но сумели занять только предпоследнее 7 место.'
	$zz_result[2] = 'Вы упорно боролись, но сумели занять только 6 место.'
	$zz_result[3] = 'Вы упорно боролись, но сумели занять только 5 место.'
	$zz_result[4] = 'Вы упорно боролись, но сумели занять только 4 место.'
	$zz_result[5] = 'Вы упорно боролись, и сумели занять призовое 3 место.'
	$zz_result[6] = 'Вы упорно боролись, и сумели занять призовое 2 место.'
	$zz_result[7] = 'Вы упорно боролись, и сумели занять 1 место.'
	$zz_wins[1] = ' Физрук поздравляет вас с успехом.'
	$zz_wins[2] = ' Физрук поздравляет вас с победой на соревнованиях.'
	$zz_wins[3] = ' Вы получаете бронзовую медаль и приз <<zz_money>> рублей'
	$zz_wins[4] = ' Вы получаете серебряную медаль и приз <<zz_money*2>> рублей'
	$zz_wins[5] = ' Вы получаете золотую медаль, приз <<zz_money*3>> рублей'
	beg += 1
	body['day_weight'] -= 1
	begresult = beg + speed*5 + vital*5 + rand(-100,100) - body['group']*100
	if begresult <= zz_base:
		! последнее место
		gs 'zz_render','','', $zz_result[0]
		act 'Уйти': gt $loc, $metka
		exit
	elseif begresult >= zz_base + zz_step * 7:
		! победитель
		if $args[1] = 'school' or $args[1] = 'city':
			gs 'zz_render','','', $zz_result[7] + $zz_wins[2]
			if $args[1] = 'school': swinbeg += 1
			if $args[1] = 'city': swinbeggor += 1
		else
			goldbeg += 1
			money += zz_money*3
			razradbeg += 1
			if razradbeg >= 6 and razradbeg < 16: razradbegK += 1
			if $args[1] = 'run7': razradbegEG += 1
			gs 'zz_render','','', $zz_result[7] + $zz_wins[5] + $zz_wins[0]
		end
		act 'Уйти': gt $loc, $metka
		exit
	else
		! 2 - 7 место
		:loop_begresult
		if begresult >= zz_base + zz_step * zz_i and begresult < zz_base + zz_step * (zz_i + 1):
			gs 'zz_render','','', $zz_result[zz_i]
			if $args[1] = 'school' or $args[1] = 'city':
				gs 'zz_render','','', $zz_wins[0]
			else
				! 3 место
				if zz_i = 5:
					gs 'zz_render','','', $zz_wins[3]
					money += zz_money
					bronzebeg += 1
					if razradbeg >= 6 and razradbeg < 16: razradbegK += 1
					if $args[1] = 'run7': razradbegEB += 1
				end
				! 2 место
				if zz_i = 6:
					gs 'zz_render','','', $zz_wins[4]
					money += zz_money*2
					silverbeg += 1
					if razradbeg >= 6 and razradbeg < 16: razradbegK += 1
					if $args[1] = 'run7': razradbegES += 1
				end
			end
			act 'Уйти': gt $loc, $metka
			exit
		else
			zz_i += 1
			jump 'loop_begresult'
		end
	end
	killvar '$zz_result'
	killvar '$zz_wins'
	killvar 'zz_base'
	killvar 'zz_step'
	killvar 'zz_i'
	killvar 'zz_diff'
	killvar 'zz_money'
end
if $args[0] = 'fancywork':
	if gobelen > 0: 'Готовых гобеленов <<gobelen>> шт'
	if poSkill >= 50:
		if tkan > 0:
			gs 'zz_render','','','Вашей ткани хватит ещё на <<tkan>> уроков'
		else
			gs 'zz_render','','','У вас нет ткани. Её можно купить в хозяйственном отделе супермаркета.'
		end
	end
	if poSkill >= 200:
		if newgobelen = 0 and tkan>0:
			act 'Начать новый гобелен':
				*clr & cla
				tkan -= 1
				newgobelen = 1
				minut += 15
				gs 'stat'
				gs 'zz_render','','pic/fancywork/newgobelen_start.jpg','Вы в течение 15 минут приготовили ткань, на которой будете вышивать узор, и в общих чертах разметили контуры узора.'
				act 'Отложить': gt $curloc
			end
		end
		if newgobelen>=1:
			gs 'zz_render','','','Гобелен готов на <<newgobelen>> процентов.'
			act 'Вышивать гобелен в течение часа.':
				*clr & cla
				minut += 60
				poSkill += rand(intel/20,intel/10)
				newgobelen += agil/20 + poSkill/200
				if intel < 50: intel += rand(0,1)
				if agil < 50: agil += rand(0,1)
				gs 'stat'
				gs 'zz_render','','pic/fancywork/newgobelen_work'+rand(1,2)+'.jpg'
				if newgobelen < 100:
					gs 'zz_render','','','Вы в течение часа вышиваете гобелен и теперь он готов на <<newgobelen>> процентов'
				else
					newgobelen = 0
					gobelen += 1
					gs 'zz_render','','','Вы полностью закончили гобелен.'
				end
				act 'Отложить':gt $curloc
			end
		end
		if func('zz_clothing','is_exists', 151) >= 0 and func('zz_clothing','is_exists', 157) < 0:
			act 'Перешить школьную форму':
				*clr & cla
				fancywork_sexishcooldress=1
				! получаем wardrobe_id для шмотки
				zz_id = func('zz_clothing','is_exists', 151)
				! удаляем одежду
				if zz_id >= 0: gs 'zz_clothing', 'remove_at', zz_id
				! чистим хвосты
				killvar 'zz_id'
				minut += 15
				gs 'stat'
				gs 'zz_render','','pic/fancywork/start.jpg','Вы в течение 15 минут приготовили школьное платье, которое решили перешить и в общих чертах разметили контуры работы.'
				act 'Отложить':gt $curloc
			end
		end
		if fancywork_sexishcooldress > 0:
			gs 'zz_render','','','Школьная форма готова на <<fancywork_sexishcooldress>> процентов'
			act 'Перешивать школьную форму в течение часа':
				*clr & cla
				minut += 60
				poSkill += rand(intel/20,intel/10)
				fancywork_sexishcooldress += agil/20 + poSkill/200
				if intel < 50: intel += rand(0,1)
				if agil < 50: agil += rand(0,1)
				gs 'stat'
				if fancywork_sexishcooldress < 100:
					gs 'zz_render','','pic/fancywork/fancywork.jpg','Вы в течение часа перешиваете школьное платье и теперь оно готово на <<fancywork_sexishcooldress>> процентов'
				else
					fancywork_sexishcooldress = 0
					gs 'zz_clothing', 'init_clothing'
					gs 'zz_clothing', 'add_to_wardrobe', 157
					gs 'zz_clothing', 'dispose'
					gs 'zz_render','','pic/fancywork/finish.jpg','Вы полностью перешили школьное платье.'
				end
				act'Отложить': gt $curloc
			end
		end
	end
end
! проверка дома/не дома школьные npc
if $args[0] = 'check_inhome':
	if ((school['vacation'] > 0 or week >= 6) and hour > 10 and hour < 20) or (week <= 5 and hour >= 15 and hour < 20):
		result = 1
	else
		result = 0
	end
end
! использование салфеток - очистка от следов спермы
! args[1] - автоприменение - 0/1
if $args[0] = 'wet_wipes':
	if salfetka = 0: exit
	! сперва очищаем видимые следы - лицо и одежда, каждый раз по салфетке, если такие есть
	! при очистке лица также убираем макияж
	if cumface > 0 and salfetka > 0: cumface = 0 & mop = 1 & salfetka -= 1
	if cumfrot > 0 and salfetka > 0: cumfrot = 0 & salfetka -= 1
	! очистка других частей тела
	if cumbelly > 0 and salfetka > 0: cumbelly = 0 & salfetka -= 1
	if cumass > 0 and salfetka > 0: cumass = 0 & salfetka -= 1
	if cumpussy > 0 and salfetka > 0: cumpussy = 0 & salfetka -= 1
	if cumanus > 0 and salfetka > 0: cumanus = 0 & salfetka -= 1
	if args[1] = 0:
		minut += rand(5,10)
		gs 'stat'
		gs 'zz_render','','','С помощью влажных салфеток вы быстро подчистили себя и одежду от неприятных следов.'
	end
	exit
end
!------------------
! Описания ГГ
!------------------
!---
! рисунки
!---
! лицо
if $args[0] = 'get_face':
	if $settings['hapri_mod'] = 1:
		if mop > 0:
			$result = 'images/common/body/face/'+hapri+'/' + str(hcol) + str iif(glass > 2 ,2,glass) + str(shorthair) + iif(hapri = 0,'',str(iif(curly > 0,1,0)) + str(mop)) + '.jpg'
		else
			$result = 'images/common/body/face/2/' + str(hcol) + str(iif(curly > 0,1,0)) + '.jpg'
		end
	else
		$result = 'images/common/body/face/' + str(hcol) + str(glass) + str(iif(shorthair <= 1,0,1)) + str(iif(curly > 0,1,0)) + '.jpg'
	end
end
! тело
if $args[0] = 'get_body':
	if body['group'] = 0:
		if (stren + vital) >= 50:
			$result = 'images/picb/body/fit/0.jpg'
		else
			$result = 'images/picb/body/normal/3.jpg'
		end
	elseif body['group'] = 1:
		if (stren + vital) < 50:
			$result = 'images/picb/body/normal/5.jpg'
		elseif (stren + vital) >= 50 and (stren + vital) < 100:
			$result = 'images/picb/body/fit/3.jpg'
		else
			$result = 'images/picb/body/fit/4.jpg'
		end
	elseif body['group'] = 2:
		if (stren + vital) >= 50:
			$result = 'images/picb/body/fit/5.jpg'
		else
			$result = 'images/picb/body/normal/9.jpg'
		end
	elseif body['group'] = 3:
		if (stren + vital) >= 50:
			$result = 'images/picb/body/fit/6.jpg'
		else
			$result = 'images/picb/body/normal/11.jpg'
		end
	elseif body['group'] = 4:
		if (stren + vital) >= 50:
			$result = 'images/picb/body/fit/7.jpg'
		else
			$result = 'images/picb/body/normal/12.jpg'
		end
	end
end
! лобок
if $args[0] = 'get_pubic':
	if lobok <= 0:
		$result = 'images/picb/pussy/shaved.jpg'
	elseif lobok > 0 and lobok <= 2:
		$result = 'images/picb/pussy/trim.jpg'
	else
		$result = 'images/picb/pussy/hairy.jpg'
	end
end
! одежда
if $args[0] = 'get_clothing':
	if current_clothing = 0 and tanga = 0:
		$result = 'images/clothing/0.jpg'
	elseif current_clothing = 0 and tanga = 1:
		$result = 'images/clothing/tanga.jpg'
	elseif current_clothing = 1:
		$result = 'images/clothing/1.jpg'
	elseif current_clothing = 2:
		$result = 'images/nigma/gor/lake/lake.walk.bikini0,3.jpg'
	else
		$result = func('zz_clothing','get_image_path')
	end
end
! киска
if $args[0] = 'get_pussy':
	if vagina = 0:
		tmp_pussy = 0
	elseif vagina > 0 and vagina <= 15:
		tmp_pussy = (vagina - 1)/5 + 1
	else
		tmp_pussy = (vagina - 16)/10 + 4
	end
	$result = 'images/picb/pussy/<<tmp_pussy>>.jpg'
	killvar 'tmp_pussy'
end
! попа
if $args[0] = 'get_anus':
	if analplugIN = 0:
		if anus = 0:
			$tmp_anus = 0
		elseif anus > 0 and anus <= 15:
			$tmp_anus = (anus - 1)/5 + 1
		else
			$tmp_anus = (anus - 16)/10 + 4
		end
	else
		if tanga = 1:
			$tmp_anus = 'analplug'
		else
			if pirsG = 0:
				$tmp_anus = iif(pirsGL = 0,'analplugnotanga','analplugpirsclit')
			else
				$tmp_anus = iif(pirsGL = 0,'analplugpirsring','analplugpirscligub')
			end
		end
	end
	$result = 'images/picb/ass/<<$tmp_anus>>.jpg'
	killvar '$tmp_anus'
end
!---
!текст
!---
if $args[0] = 'error':
	*clr & cla
	gs 'zz_render','','','<center><b>ВАМИ ТОЛЬКО ЧТО БЫЛ ИСПОЛЬЗОВАН АВАРИЙНЫЙ ВЫХОД ИЗ БАГА ПУСТОГО ЭКРАНА!**НЕ ИСПОЛЬЗУЙТЕ ЭТУ ВОЗМОЖНОСТЬ БЕЗ ВЕСКОЙ ПРИЧИНЫ: ЭТИМ ВЫ МОЖЕТЕ ВЫЗВАТЬ СБОЙ, КОТОРЫЙ РАЗРУШИТ ВАШИ СОХРАНЕНИЯ</b></center>'
	act 'Далее >>':
		if current_clothing < 3: gs 'zz_clothing', 'fix_emergency'
		gt iif($control_point = '','gorodok',$control_point)
	end
end