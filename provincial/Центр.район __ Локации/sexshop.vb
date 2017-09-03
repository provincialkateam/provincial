if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	*clr & cla
	i = RAND(0,100)
	if kendra > 0 and i < 10:gt 'sexshop', 'kendra'
	if tanga = 0 and i > 90:gt 'sexshop', 'shprod'
	minut += 5
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if len($_buy_item) > 0: gs 'zz_funcs','message','', $_buy_item & killvar '$_buy_item'
	gs 'zz_render', 'Сексшоп', 'images/pic/sexshop.jpg', func('sexshop_strings', 'local_str1')
	act 'Выйти':
		cla
		killvar '$_buy_item'
		ghnow = 0
		minut += 5
		gs 'zz_clothing', 'dispose'
		gt 'down'
	end
	if dom = -100 and analplug = 1 and dildo = 1 and vnesh >= 60 and $npc['32,relation'] < 1:
		if RAND(0, 100) > 50:
			gs 'zz_render', '', '', func('sexshop_strings', 'local_str2')
			act 'Заинтересоваться хозяином магазина':
				*clr & cla
				gs 'zz_render', '', 'images/peter/peter.jpg', func('sexshop_strings', 'local_str3')
				act 'Идти с Питером':gt'Peterroom','start'
				act 'Выйти':
					cla
					ghnow = 0
					minut += 5
					gt'down'
				end
			end
		end
	end
	! если знакомы с Таней - можно переброситься парой-тройкой слов
	if week < 6 and hour >= 9 and hour <= 17 and $npc['31,qwTanyaMain'] >= 10:
		gs 'zz_render','','','За прилавком стоит <a href="exec:gt''tanya_events'',''talk''">Таня</a>.'
	end
	! ---
	act 'Идти в подвал': gt 'sexshop', 'podval'
	if gloryhole >= 20 and pornstudio = 0:
		gs 'zz_render', '', '', func('sexshop_strings', 'local_str4')
		act 'Подойти, узнать, в чём дело': gt'sexshop','porn'
	end
	$_str = '<tr bgcolor=#f3f4ee><td><b>Товар</b></td><td></b>Цена</b></td><td></b>***</b></td></tr>'
	$_str += '<tr bgcolor=#f3f4ee><td>Лубрикант</td><td>300р.</td><td>'+iif(money >= 200,'<a href="exec: gs''sexshop'',''buy_item'',7">Купить</a>','Купить')+'</td></tr>'
	if pornMagazine = 0: $_str += '<tr bgcolor=#f3f4ee><td>Порножурнал</td><td>400р.</td><td>'+iif(money >= 400,'<a href="exec: gs''sexshop'',''buy_item'',8">Купить</a>','Купить')+'</td></tr>'
	if strapon = 0: $_str += '<tr bgcolor=#f3f4ee><td>Страпон</td><td>1200р.</td><td>'+iif(money >= 1200,'<a href="exec: gs''sexshop'',''buy_item'',9">Купить</a>','Купить')+'</td></tr>'
	if analplug = 0: $_str += '<tr bgcolor=#f3f4ee><td>Анальная пробка</td><td>1200р.</td><td>'+iif(money >= 1200,'<a href="exec: gs''sexshop'',''buy_item'',10">Купить</a>','Купить')+'</td></tr>'
	if vibrator = 0: $_str += '<tr bgcolor=#f3f4ee><td>Вибратор</td><td>1300р.</td><td>'+iif(money >= 1300,'<a href="exec: gs''sexshop'',''buy_item'',11">Купить</a>','Купить')+'</td></tr>'
	if dildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Маленький фалоимитатор</td><td>800р.</td><td>'+iif(money >= 800,'<a href="exec: gs''sexshop'',''buy_item'',0">Купить</a>','Купить')+'</td></tr>'
	if middildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Фалоимитатор, 15 см</td><td>1500р.</td><td>'+iif(money >= 1500,'<a href="exec: gs''sexshop'',''buy_item'',1">Купить</a>','Купить')+'</td></tr>'
	if largedildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Фалоимитатор, 20 см</td><td>2500р.</td><td>'+iif(money >= 2500,'<a href="exec: gs''sexshop'',''buy_item'',2">Купить</a>','Купить')+'</td></tr>'
	if bigdildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Фалоимитатор, 25 см</td><td>4500р.</td><td>'+iif(money >= 4500,'<a href="exec: gs''sexshop'',''buy_item'',3">Купить</a>','Купить')+'</td></tr>'
	if extradildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Фалоимитатор, 30 см</td><td>6500р.</td><td>'+iif(money >= 6500,'<a href="exec: gs''sexshop'',''buy_item'',4">Купить</a>','Купить')+'</td></tr>'
	if superdildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Фалоимитатор, 35 см</td><td>8500р.</td><td>'+iif(money >= 8500,'<a href="exec: gs''sexshop'',''buy_item'',5">Купить</a>','Купить')+'</td></tr>'
	if maddildo = 0: $_str += '<tr bgcolor=#f3f4ee><td>Фалоимитатор, 40 см</td><td>12000р.</td><td>'+iif(money >= 12000,'<a href="exec: gs''sexshop'',''buy_item'',6">Купить</a>','Купить')+'</td></tr>'
	gs 'zz_render','','','<center><table width=600>'+$_str+'</table></center>'
	killvar '$_str'
	! 12 - shop_id
	gs 'zz_clothing', 'make_shop', 12
end
! args[1] - id
! args[2] - price
if $ARGS[0] = 'buy_item':
	*clr & cla
	minut += rand(5,10)
	if args[1] = 0: dildo = 1 & money -= 800
	if args[1] = 1: middildo = 1 & money -= 1500
	if args[1] = 2: largedildo = 1 & money -= 2500
	if args[1] = 3: bigdildo = 1 & money -= 4500
	if args[1] = 4: extradildo = 1 & money -= 6500
	if args[1] = 5: superdildo = 1 & money -= 8500
	if args[1] = 6: maddildo = 1 & money -= 12000
	if args[1] = 7: lubri += 5 & money -= 200 & $_buy_item = 'лубрикант'
	if args[1] = 8: pornMagazine = 50 & money -= 400 & $_buy_item = 'порножурнал'
	if args[1] = 9: strapon = 1 & money -= 1200 & $_buy_item = 'страпон'
	if args[1] = 10: analplug = 1 & money -= 1200 & $_buy_item = 'анальная пробка'
	if args[1] = 11: vibrator = 1 & money -= 1300 & $_buy_item = 'вибратор'
	if args[1] <= 6: $_buy_item = 'фалоимитатор'
	$_buy_item = '<font color=green><b>Вы купили '+$_buy_item+'</b></font>'
	gt 'sexshop','start'
end
if $ARGS[0] = 'podval':
	*clr & cla
	minut += 5
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Подвал с кабинками для просмотра фильмов', 'images/pic/gloryholeBooths1.jpg', func('sexshop_strings', 'local_str5')
	act 'Зайти в свободную кабинку': gt'sexshop','pip'
	act 'Идти в туалет': gt 'zz_toilet', 'main'
	if masharab = 1: act 'Зайти к Маше': gt'masharoom','start'
	act 'Выйти из подвала': gt'sexshop','start'
end
if $ARGS[0] = 'pip':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Кабинка с фильмами', 'images/pic/ghBooths.jpg', func('sexshop_strings', 'local_str6')
	if ghnow > 0:'Вы обслужили <<ghnow>> хуев.'
	act 'Выйти из кабинки':gt'sexshop','podval'
	if money >= 50 and hour < 23:
		act 'Сунуть 50 рублей в автомат':
			cla
			money -= 50
			minut += 15
			horny += 5
			manna += 5
			gs 'zz_render', '', '', func('sexshop_strings', 'local_str7')
			act 'Фильм закончился':gt'sexshop','pip'
			if horny >= 50:
				act 'Мастурбировать':
					cla
					horny += 10
					manna += 10
					gs 'zz_render', '', '', func('sexshop_strings', 'local_str8')
					if horny >= 100:
						orgasm += 1
						horny = 0
						manna += 15
						mastr += 1
						gs 'zz_render', '', '', func('sexshop_strings', 'local_str9')
					end
					act 'Фильм закончился':gt'sexshop','pip'
				end
			end
			if RAND(0,10) >= 10 - (cumlip*2):
				gs 'zz_render', '', '', func('sexshop_strings', 'local_str10')
				act 'Сунуть пальчик в отверстие (обслужить незнакомца)':
					*clr & cla
					ghnow += 1
					money += 300
					gs 'zz_render', '', 'images/pic/ghFinger'+RAND(0,4)+'.jpg', func('sexshop_strings', 'local_str11')
					act 'Сосать член':
						cla
						*clr
						if mistressqwest > 0: mistressqwest += 1
						horny += VAF
						guy += 1
						bj += 1
						gloryhole += 1
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						dynamic $venerasiak
						gs 'zz_render', '', 'images/picV/gloryhole'+RAND(0,37)+'.jpg', func('sexshop_strings', 'local_str12')
						if horny >= 100:
							VAF += 1
							orgasm += 1
							horny = 0
							manna += 15
							lip += 1
							gs 'zz_render', '', '', func('sexshop_strings', 'local_str13')
						end
						gs 'zz_render', '', '', func('sexshop_strings', 'local_str14')
						act 'Вытереть лицо':gt'sexshop','pip'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'porn':
	*clr & cla
	minut += 5
	gs 'zz_render', '', '', func('sexshop_strings', 'local_str15')
	act 'Согласиться':
		cla
		*clr
		pornstudio = 2
		gt'pornstudio','1'
	end
	act 'Отказаться':
		cla
		*clr
		pornstudio = 1
		gt'sexshop','start'
	end
end
if $ARGS[0] = 'kendra':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/img/centr/shkend.jpg', func('sexshop_strings', 'local_str16')
	act 'Отойти от неё':gt'sexshop','start'
	if DOM > 10: act 'Сначала заслужи':gt'sexshop','kendra4'
	act 'Обслужить Кендру':
		*clr & cla
		dom -= 1
		lesbian += 1
		gs 'zz_render', '', 'images/img/centr/shkend1.jpg', func('sexshop_strings', 'local_str17')
		act 'Взять дилдо': gt'sexshop','kendra1'
		act 'Дать её страпон': gt'sexshop','kendra2'
	end
end
if $ARGS[0] = 'kendra1':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/img/centr/shkend2.jpg', func('sexshop_strings', 'local_str18')
	if RAND(0,3) > 0:
		orgasm += 1
		gs 'zz_render', '', '', func('sexshop_strings', 'local_str19')
		act 'Закончить':gt'sexshop','start'
	else
		act 'Упс...':
			*clr & cla
			sweat += 1
			gs 'zz_render', '', 'images/img/centr/shkend4.jpg', func('sexshop_strings', 'local_str20')
			act 'Послать её':gt'sexshop','kendra3'
			act 'Продолжать':
				*clr & cla
				sweat += 3
				dom -= 2
				horny = 0
				gs 'zz_render', '', 'images/img/centr/shkend3.jpg', func('sexshop_strings', 'local_str21')
				act 'Послать её':gt'sexshop','kendra3'
				act 'Слизать':
					*clr & cla
					dom -= 2
					gs 'zz_render', '', 'images/img/centr/shkend5.jpg', func('sexshop_strings', 'local_str22')
					act 'Уйти':gt'sexshop','start'
				end
			end
		end
	end
end
if $ARGS[0] = 'kendra2':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/img/centr/shkend8.jpg', func('sexshop_strings', 'local_str23')
	act 'В вагину':
		*clr & cla
		sex += 1
		vagina += 1
		orgasm += 1
		horny = 0
		gs 'zz_render', '', 'images/img/centr/shkend10.jpg', func('sexshop_strings', 'local_str24')
		act 'Уйти':gt'sexshop','start'
	end
	act 'В анус':
		*clr & cla
		anal += 1
		orgasm += 1
		anus += 1
		horny = 0
		gs 'zz_render', '', 'images/img/centr/shkend9.jpg', func('sexshop_strings', 'local_str25')
		act 'Уйти':gt'sexshop','start'
	end
end
if $ARGS[0] = 'kendra3':
	*clr & cla
	minut += 10
	anal += 1
	anus += 1
	rape += 1
	gs 'zz_render', '', 'images/img/centr/shkend6.jpg', func('sexshop_strings', 'local_str26')
	act 'Встать на колени':
		*clr & cla
		gs 'zz_render', '', 'images/img/centr/shkend7.jpg', func('sexshop_strings', 'local_str27')
		act 'Уйти':gt'sexshop','start'
	end
end
if $ARGS[0] = 'kendra4':
	*clr & cla
	minut += 10
	orgasm += 1
	horny = 0
	picrand = RAND(11,12)
	gs 'zz_render', '', 'images/img/centr/shkend<<picrand>>.jpg', func('sexshop_strings', 'local_str28')
	if picrand = 11:'Кендра опустилась на колени и начала вылизывать вам киску, ей язычок скользил по половым губкам, щекотал клитор, и поникал в вагину, через несколько минут её стараний, вы кончили.'
	if picrand = 12:'Кендра опустилась на колени и её язычок с ходу вонзился вам в анус проникая внутрь, у вас было ощущение что вам в зад забралась змея и крутиться в нем во все стороны, пальчиками она проникла в вагину и через несколько минут благодаря её языку извивающемуся у вас в попке и пальчикам старательно массирующим киску вы испытали оргазм.'
	gs 'zz_render', '', '', func('sexshop_strings', 'local_str29')
	act 'Дать её страпон':gt'sexshop','kendra2'
	if DOM > 25: act 'Перебьешься':gt'sexshop','start'
end
if $ARGS[0] = 'shprod':
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/img/centr/shprod.jpg', func('sexshop_strings', 'local_str30')
	act 'Отказаться':gt'sexshop','start'
	act 'Примерить':
		*clr & cla
		picrand = 47
		gs 'zz_render', '', 'images/img/centr/shprod1.jpg', func('sexshop_strings', 'local_str31')
		act 'Оттолкнуть его': gt'sexshop','start'
		act 'Позволить ему': gt'sex','kuni'
	end
end