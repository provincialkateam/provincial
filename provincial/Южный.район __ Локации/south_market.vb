if $args[0] = '': $args[0] = 'start'
if $ARGS[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'time'
	gs 'zz_render', 'Рынок', 'images/city/south/south_market/market'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', iif(hour >= 8 and hour <= 14,'Большой и шумный рынок.<br>При входе на рынок можно купить <a href="exec: gt ''south_market'',''book''">книги</a>.<br>На самом рынке есть продуктовые ряды <a href="exec: gt ''south_market'',''food''">продуктовые ряды</a>.<br>Пройдя немного дальше можно купить <a href="exec: gt ''south_market'',''cosm''">бельё и косметику</a>.<br>Там же находятся и <a href="exec: gt ''south_market'',''hos''">хозяйственные</a> ряды.<br>В самом конце есть <a href="exec: gt ''south_market'',''clo''">вещевой рынок</a>.'+iif(BuyHous = 1 and (remkorr = 0 or remvanr = 0 or remkuhr = 0 or remsitr = 0 or rembedr = 0),'<br> На самой окраине расположилась стихийная <a href="exec: gt ''south_market'',''flea_market''">барахолка</a>.',''),'Рынок закрыт закрыт.')
	if work = 0 and workrin = 0 and bad_trade <= 10 and workrin_hooky < 4:
		gs 'zz_render', '', '','На одной из палаток висит объявление:<b>"Нужен женщин продавщиц. Зарплат большой."</b>'
		act 'Подойти к хозяину палатки с объявлением':
			*clr & cla
			gs 'zz_render', 'Рустам', 'images/city/south/south_market/market_work/rustam.jpg','\\\- Прывэт, '+iif(rustam_know = 0,'мэня зовут Рустам. Я хозяин палатки, мнэ нужен продавщиц.',iif(market_sex <= 20,replace($name[1],'е','э'),replace($name[2],'е','э'))+', рэшила вэрнутся ко мнэ на работу?')+' Сам нэ справляюсь. Плачу процент от заработанного. Работать будэшь по вторникам, четвэргам и субботам. С 8-ми до 14-ти. Работа по трудовой, если будет больше трёх прогулов - уволю. Ну как? Пойдешь?///'
			act 'Уйти': gt'south_market','start'
			act 'Устроиться на работу':
				cla
				rustam_know = 1
				work = 1
				workrin = 1
				rustam_plan = 5000
				gs 'zz_render', '', '','Вы устроились работать к Рустаму и отдали ему трудовую.'
				act 'Выйти':gt'south_market','start'
			end
		end
	end
	if workrin = 1 and (week = 2 or week = 4 or week = 6):
		if workrin_hooky < iif(market_sex < 10,4,iif(rinslut = 0,6,10)):
			if hour < 9:
				gs 'zz_render', '', '','Рустам с товаром уже ждет вас.'
				act '<b>Принимать товар</b>':
					*clr & cla
					hour = 9
					minut = 0
					prodpayum = 1200
					workrin_hooky -= 1
					gs 'zz_render', 'Рустам', 'images/city/south/south_market/market_work/accept_goods.jpg', iif(workrin_hooky > rustam_know_hooky,'<do> - Вай '+replace($name[1],'е','э')+', зачэм прогуливаешь?, -</do> накинулся на вас Рустам, когда вы подошли к нему.<do> - Я за тэбя работать должэн что-ли? Смотри, дограешься, уволю'+iif(market_sex < 10,'',iif(rinslut = 0,'не смотря на твои ... эээ... качэства','не глядя на все твои "заслуги"'))+'...</do>**','')+'Рустам выгрузил барахло из своей ушатанной шохи к лотку и отдал вам. Вы начали развешивать одежду по палатке.<br>Перед тем как уйти Артур дает вам инструкции:**<do>- Продавай как хочешь, но чтобы вэчером мнэ отдала с каждой проданной вэщи по 1000. И чтоб наторговала нэ мэньше чэм <<rustam_plan>> рублей.</do>'
					act 'Работать':rustam_know_hooky = workrin_hooky & gt'market_work','start'
				end
			end
		else
			workrin = 0
			work = 0
			gs 'zz_render', '', '','Разгневаный Рустам ждёт вас у входа:**<do>- Опять прогуляла, '+replace($name[1],'е','э')+'. Маё тэрпенье лопнуло, вот твоя трудовая, вали давай!<do>**Вы забрали у него из рук трудовую и он пошёл прочь.'
		end
		act 'Уволиться с работы':
			*clr & cla
			workrin = 0
			work = 0
			workrin_hooky = 0
			gs 'zz_render', 'Рустам', 'images/city/south/south_market/market_work/rustam.jpg','Вы уволились с работы и забрали трудовую.'
			act 'Выйти':gt'south_market','start'
		end
	end
	if analplugIN = 1 and tanga = 0 and func('zz_clothing','is_skirt') = 1 and temper > 20 and rand(1,10) = 10:
		horny += 10
		gs 'zz_render', 'Рынок', '','Вы чувствуете что кто-то мягко коснулся <a href="exec: gt ''south_market'',''analplug''">вашей попы рукой!</a>'
	end
	act 'Выйти':minut += 15 & gt 'street'
end
if $ARGS[0] = 'analplug':
	*clr & cla
	gs'stat'
	gs 'zz_render', 'Рынок', 'images/city/south/south_market/event/rinokplug.jpg','Вы почувствовали приятный, даже пьянящий, запах дорогой, мужской, туалетной воды. Внизу живота моментально "зазудело", по телу прошёл жар возбуждения.<br>Сзади стоял парень с определённой целью - он был любитель пощупать девушек в толпе, и сейчас намеревался пощупать вашу попку.<br>А рука тем временем развернулась и легла ладонью на одну из половинок вашей попки.'
	act 'Отойти':gt'south_market','start'
	act 'Далее':
		*clr & cla
		minut += 10
		gs'stat'
		gs 'zz_render', 'Рынок', 'images/city/south/south_market/event/butplag.jpg','Парню фартило: "жертва" не выказывала неудовольствия, а его действия были закрыты от окружающих. Народу было плевать на него, все изнывали от жары.<br>Он передвинул руку на другую "булочку", остановил посередине, спустился чуть ниже. Начал понемногу сжимать попку в ладони. Вы не реагировали. Тогда он начал продвигать пальцы через ткань юбки вглубь, к бугорочку между ножек.<br>Он почувствовал, как вы вздрогнули, но не от неожиданности. Он тоже был опытен, он понял, что вы возбудились и уже "плывёте".<br>Вы действительно плыли. Вы были уже неподвластны себе. Вы хотели, чтобы парень забрался под юбку и вставил член... Ощущения захватывали вас, возбуждение переполняло. Вы еле сдерживались, чтобы не начать охать и стонать...'
		act 'Стоять':
			*clr & cla
			minut += 10
			orgasm += 1
			horny = 0
			gs 'zz_render', 'Рынок', 'images/city/south/south_market/event/finger.jpg','А парень, тем временем, потянул подол юбки вверх, добрался рукой до разреза, и умелым движением залез под юбку. Его рука легла на низ, влажной от испарины попки, и пальцы коснулись анальной пробки между ног.<br>Вы даже чуть пошатнулась, но никто этого в давке не заметил, кроме этого искусителя. Он немного замер, похоже в шоке от того, что девушка вот так вот может разгуливать по рынку без трусов и с пробкой в попе.<br>В голове у вас всё кружилось, вы были на пике возбуждения, ещё немного - и вы кончите.<br>Парню конечно было мало. Он проник во влагалище пальцами и начал их вводить, и выводить. И тут же вы задрожали, сделали несколько шумных, глубоких вздохов, а на пальцы парню брызнула влага.**<do>- Ничего себе!... -</do> парень не ожидал такой реакции от вас, и даже струхнул, что его могут "запалить".<br>И действительно, одна женщина предпенсионного возраста спросила у вас:<br><do>- Девонька, тебе плохо?</do><br><dh>- Нет, спасибо, всё уже прошло? -</dh> собравшись с силами ответили вы.<br>Видимо женщина спугнула извращенца. Так как за вами уже никто не стоял.'
			act 'Далее': gt 'south_market', 'start'
		end
	end
end
if $ARGS[0] = 'book':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', 'Книжный ряд', 'images/city/south/south_market/book'+iif(month >= 4 or month <= 10,'','_winter')+'.jpg',''
	if hour < 8 or hour > 14: gs 'south_market', 'closed' & exit
	act 'Посмотреть книги':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_books', 'shop'
		act 'Назад': gt 'south_market', 'book'
	end
	act 'Посмотреть эротическую литературу':
		*clr & cla
		minut += 15
		if ero_books_view < 5:ero_books_view += 1
		gs 'stat'
		gs 'zz_books', 'shop', 'ero'
		act 'Назад': gt 'south_market', 'book'
	end
	if ero_books_view = 6:
		act 'Посмотреть порножурналы':
			cla
			minut += 5
			horny += 10
			gs 'stat'
			if pornMagazine > 1:
				gs 'zz_render', '', '','У вас уже есть журнал, еще один вам никчему, и вы просто стояли и рассматривали картинки с красивыми, и стройными девушками, мускулистыми парнями, и то, чем они вместе занимались.'
			elseif pornMagazine = 1:
				gs 'zz_render', '', '','Вы зачитали свой журнал до дыр и было бы не плохо купить новый.'
			else
				gs 'zz_render', '', '','Вы начали оразглядывать различные журналы, где сфотографированы полуголые девицы, мужики со стоячими членами наперевес, и то чем они могут вместе заниматься.'
			end
			if pornMagazine <= 1: gs 'south_market', 'buy_pornMagazine'
			act 'Назад': gt 'south_market', 'book'
		end
	end
	act 'Уйти': gt 'south_market', 'start'
	if ero_books_view = 5:
		cla
		minut += 1
		ero_books_view = 6
		gs 'stat'
		gs 'zz_render', '', '','Вы рассматривали очередную книгу, выбирая, что же вам купить почитать, когда продавщица, понизив голос, спросила:**<do>- Не можете выбрать, девушка? Может вас заинтересуют более пикантные журналы? Всего по 400 рублей.</do>'
		act 'Заинтересоваться':
			cla
			minut += 1
			horny += 20
			gs 'stat'
			gs 'zz_render', '', '','Видя вашу заитересованность, продавщица показала вам стопку журналов, до этого спрятаных под прилавком. Вы начали разглядывать журналы, где сфотографированы полуголые девицы, мужики со стоячими членами наперевес, и то чем они могут вместе заниматься.'
			if pornMagazine <= 1 and money >= 400: gs 'south_market', 'buy_pornMagazine'
			act 'Назад': gt 'south_market', 'book'
		end
		act 'Не интересует':
			cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', '','<dh>- Нет, знаете, меня это не интересует, -<dh> ответили вы.**<do>- Ну, сейчас может и не интересует, -</do> улыбнулась вам продавщица.<do> - А потом может заинтересовать. В любом случае, вы знаете где искать. Просто подойдите и спросите.</do>'
			act 'Назад': gt 'south_market', 'book'
		end
	end
end
if $ARGS[0] = 'buy_pornMagazine':
	act 'Купить':
		*clr & cla
		minut += 1
		money -= 400
		pornMagazine = 50
		TimesBuyPorno += 1
		gs 'stat'
		gs 'zz_render', 'Книжный ряд', 'images/city/south/south_market/book'+iif(month >= 4 or month <= 10,'','_winter')+'.jpg','Отсчитав деньги, вы взяли журнал, и быстро его спрятали.'
		act 'Далее': gt 'south_market', 'book'
	end
end
if $ARGS[0] = 'food':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', 'Продуктовые ряды', 'images/city/south/south_market/food'+iif(month >= 4 or month <= 10,'','_winter')+'.jpg',''
	if hour < 8 or hour > 14: gs 'south_market', 'closed' & exit
	gs 'south_market', 'make_table', 0, 2
	act 'Уйти': gt 'south_market', 'start'
end
if $ARGS[0] = 'cosm':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Павильон косметики', 'images/city/south/south_market/cosm.jpg',''
	if hour < 8 or hour > 14: gs 'south_market', 'closed' & exit
	gs 'south_market', 'make_table', 3, 7
	act 'Уйти': gt 'south_market', 'start'
end
if $ARGS[0] = 'hos':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', 'Ряды хозяйственных товаров', 'images/city/south/south_market/hos'+iif(month >= 4 or month <= 10,'','_winter')+'.jpg',''
	if hour < 8 or hour > 14: gs 'south_market', 'closed' & exit
	gs 'south_market', 'make_table', 8, 10
	act 'Уйти': gt'south_market','start'
end
if $ARGS[0] = 'clo':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', 'Вещевые ряды', 'images/city/south/south_market/clo'+iif(month >= 4 or month <= 10,'','_winter')+'.jpg',''
	if hour < 8 or hour > 14: gs 'south_market', 'closed' & exit
	! 2 - shop_id
	gs 'zz_clothing', 'make_shop', 2
	gs 'zz_clothing', 'dispose'
	act 'Уйти': gt'south_market','start'
end
if $ARGS[0] = 'flea_market':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', 'Барахолка', 'images/city/south/south_market/flea_market'+iif(month >= 4 or month <= 10,'','_winter')+'.jpg',''
	if hour < 8 or hour > 14: gs 'south_market', 'closed' & exit
	gs 'south_market', 'make_table', 11, 15
	act 'Уйти': gt'south_market','start'
end
if $args[0] = 'make_table':
	$zz_arr0[0] = 'Продукты(10 порций)' & zz_arr1[0] = 1500
	$zz_arr0[1] = 'Овощи и фрукты(низкокалорийная еда-10 порций)' & zz_arr1[1] = 3000
	$zz_arr0[2] = 'Печенье(высококалорийная еда, большая упаковка)' & zz_arr1[2] = 3000
	$zz_arr0[3] = 'Бельё(упаковка 10шт)' & zz_arr1[3] = 1200
	$zz_arr0[4] = 'Огромная косметичка' & zz_arr1[4] = 1500
	$zz_arr0[5] = 'Бритвенный станок(10шт)' & zz_arr1[5] = 500
	$zz_arr0[6] = 'Шампунь(большая ёмкость)' & zz_arr1[6] = 500
	$zz_arr0[7] = 'Тампоны(30шт)' & zz_arr1[7] = 250
	$zz_arr0[8] = 'Средство для мытья посуды(большая ёмкость)' & zz_arr1[8] = 400
	$zz_arr0[9] = 'Стиральный порошок(большая упаковка)' & zz_arr1[9] = 300
	$zz_arr0[10] = 'Набор из пяти тарелок' & zz_arr1[10] = 1000
	$zz_arr0[11] = 'Набор подержанной мебели для прихожей' & zz_arr1[11] = 5000
	$zz_arr0[12] = 'Набор подержанной мебели для ванной комнаты' & zz_arr1[12] = 10000
	$zz_arr0[13] = 'Набор подержанной мебели для кухни' & zz_arr1[13] = 10000
	$zz_arr0[14] = 'Набор подержанной мебели для зала' & zz_arr1[14] = 10000
	$zz_arr0[15] = 'Набор подержанной мебели для спальни' & zz_arr1[15] = 10000
	$zz_color = '#f3f4ee'
	$zz_str = '<center><table border=0 cellpadding=1 cellspacing=1 align=center width=600 bgcolor=#ffffff>'
	$zz_str += '<tr bgcolor='+$zz_color+'><th>&nbsp;Название&nbsp;</th><th colspan=2>&nbsp;Цена за ед., руб&nbsp;</th></tr>'
	i = args[1]
	:loop_shop_table
	if i <= args[2]:
		$zz_color = iif($zz_color = '#f3f4ee', '#ffffff', '#f3f4ee')
		$zz_str += '<tr bgcolor='+$zz_color+'><td>'+$zz_arr0[i]+'</td><td>'+zz_arr1[i]+'</td><td><a href="exec:gs''south_market'',''buy'',<<i>>,'+zz_arr1[i]+'">Купить</a></td></tr>'
		i += 1
		jump 'loop_shop_table'
	end
	$zz_str += '</table><br>'
	gs 'zz_render','','', $zz_str
	killvar '$zz_str'
	killvar '$zz_color'
end
if $args[0] = 'buy':
	zz_id = args[1]
	zz_price = args[2]
	if (remkorr = 1 and zz_id = 11) or (remvanr = 1 and zz_id = 12) or (remkuhr = 1 and zz_id = 13) or (remsitr = 1 and zz_id = 14) or (rembedr = 1 and zz_id = 15):
		gs 'zz_funcs','message','','<font color=red>У вас уже есть ' + $zz_arr0[zz_id] + '</font>'
		gs 'south_market','buy_finalize'
		exit
	end
	if zz_id >= 11:
		zz_count = 1
	else
		zz_count = val(input("Сколько вы хотите купить?"))
	end
	if zz_count < 1: gs 'south_market','buy_finalize' & exit
	if zz_count > 0 and zz_count <= 100:
		if money >= zz_price * zz_count:
			money -= zz_price * zz_count
			minut += 1
			if zz_id = 0: eda += zz_count*10
			if zz_id = 1: edaD += zz_count*10
			if zz_id = 2: pranik += zz_count*10
			if zz_id = 3: clrbelo += zz_count*10
			if zz_id = 4: kosmetica += zz_count*50
			if zz_id = 5: stanok += zz_count*10
			if zz_id = 6: shampoo += zz_count*60
			if zz_id = 7: tampon += zz_count*30
			if zz_id = 8: fairy += zz_count*50
			if zz_id = 9: poroshok += zz_count*50
			if zz_id = 10: cltarelka += zz_count*5
			if zz_id = 11: remkorr = 1
			if zz_id = 12: remvanr = 1
			if zz_id = 13: remkuhr = 1
			if zz_id = 14: remsitr = 1
			if zz_id = 15: rembedr = 1
			gs 'stat'
			gs 'zz_funcs','message','','<font color=green>' + $zz_arr0[zz_id] + ':</font><font color=green> +' + zz_count + '</font>'
		else
			gs 'zz_funcs','message','','<font color=red>У вас недостаточно денег.</font>'
		end
	elseif zz_count > 10:
		gs 'zz_funcs','message','','<font color=red>Вы столько не унесете!</font>'
	end
	gs 'south_market','buy_finalize'
end
if $args[0] = 'buy_finalize':
	killvar 'zz_id'
	killvar 'zz_price'
	killvar 'zz_count'
end
if $args[0] = 'closed':
	cla
	gs 'zz_render', '', '','<center><font color=red>Рынок закрыт, рабочие часы: 08.00-15.00</font></center>'
	act 'Назад': gt 'south_market', 'start'
end