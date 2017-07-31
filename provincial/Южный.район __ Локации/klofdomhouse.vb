if $ARGS[0] = 'start':
	cla
	*clr
	minut += 5
	act 'Позвонить в дверь':
		cla
		if klofQW = 2 and hour >= 16 and klofday ! day:
			klofday = day
			gt'klofdomhouse','ev1'
		elseif klofQW > 2 and hour >= 16 and klofday ! day:
			klofday = day
			gt'klofdomhouse','start1'
		else
			gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str1')
			act 'Уйти домой':gt'street'
		end
	end
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'start1':
	cla
	*clr
	klofday = day
	minut += 5
	kloftimes += 1
	gs'stat'
	if kloftimes < 10:
		gt'klofdomhouse','ev7'
	else
		gs 'zz_render', '', 'images/klof/klof.jpg', func('klofdomhouse_strings', 'local_str2')
		act 'Уйти домой':gt'street'
	end
end
if $ARGS[0] = 'ev1':
	cla
	*clr
	klofday = day
	minut += 5
	kloftimes += 1
	gs'stat'
	if kloftimes < 10:
		gs 'zz_render', '', 'images/klof/klof.jpg', func('klofdomhouse_strings', 'local_str3')
		act 'Зайти':gt'klofdomhouse','ev2'
	else
		gs 'zz_render', '', 'images/klof/klof.jpg', func('klofdomhouse_strings', 'local_str4')
		act 'Уйти домой':gt'street'
	end
end
if $ARGS[0] = 'ev2':
	cla
	*clr
	minut += 5
	gs 'zz_render', '', 'images/klof/klof1.jpg', func('klofdomhouse_strings', 'local_str5')
	act 'Прибираться':gt'klofdomhouse','ev4'
	if dom >= -30 and horny < 75:act 'Уйти':gt'klofdomhouse','ev3'
end
if $ARGS[0] = 'ev3':
	cla
	*clr
	minut += 5
	klofQW -= 1
	dom += 1
	gs 'zz_render', '', 'images/picQW/pnx.jpg', func('klofdomhouse_strings', 'local_str6')
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'ev4':
	cla
	*clr
	minut += 5
	gs 'zz_render', '', 'images/klof/klof3.jpg', func('klofdomhouse_strings', 'local_str7')
	act 'Раздвинуть ноги Жоре':gt'klofdomhouse','ev5'
end
if $ARGS[0] = 'ev5':
	cla
	*clr
	minut += 5
	sex += 1
	vagina += 1
	gs 'zz_render', '', 'images/klof/klof4.jpg', func('klofdomhouse_strings', 'local_str8')
	act 'Взять в рот у Сени':gt'klofdomhouse','ev6'
end
if $ARGS[0] = 'ev6':
	cla
	*clr
	minut += 5
	klofQW += 1
	money += 2000
	bj += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_render', '', 'images/klof/klof5.jpg', func('klofdomhouse_strings', 'local_str9')
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str10')
	gs 'zz_funcs', 'cum', 'pussy'
	if bj >= anal and bj >= sex:callnm = 1
	if anal >= oral and anal >= sex:callnm = 2
	if sex >= oral and sex >= anal:callnm = 3
	if vaf >= 100:callnm = 4
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev7':
	cla
	*clr
	minut += 5
	gs 'zz_render', '', 'images/klof/klof1.jpg', func('klofdomhouse_strings', 'local_str11')
	act 'Поздороваться с парнями':gt'klofdomhouse','ev8'
end
if $ARGS[0] = 'ev8':
	cla
	*clr
	minut += 5
	gs 'zz_render', '', 'images/klof/klof6.jpg', func('klofdomhouse_strings', 'local_str12')
	act 'Развлечь Жору':gt'klofdomhouse','ev9'
	act 'Развлечь Сеню':gt'klofdomhouse','ev10'
	act 'Развлечь обоих':gt'klofdomhouse','ev19'
	act 'Поговорить с Жорой о делах':gt'klofdomhouse','ev20'
end
if $ARGS[0] = 'ev9':
	cla
	*clr
	act 'Дать в киску Жоре':gt'klofdomhouse','ev13'
	act 'Дать в жопу Жоре':gt'klofdomhouse','ev14'
	act 'Отсосать Жоре':gt'klofdomhouse','ev19'
end
if $ARGS[0] = 'ev13':
	cla
	*clr
	minut += 30
	klofQW += 1
	money += 100
	vagina += 1
	sex += 1
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str13')
	'<center><img src="images/klof/klof'+RAND(7,9)+'.jpg"</center>'
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', 'images/klof/klof10.jpg', func('klofdomhouse_strings', 'local_str14')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev14':
	cla
	*clr
	minut += 30
	klofQW += 1
	money += 100
	anal += 1
	anus += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str15')
	'<center><img src="images/klof/klof'+RAND(11,13)+'.jpg"></center>'
	gs 'zz_funcs', 'hornyrand'
	act '...':
		cla
		*clr
		gs 'zz_render', '', 'images/klof/klof14.jpg', func('klofdomhouse_strings', 'local_str16')
		act 'Уйти домой':gt'street'
	end
end
if $ARGS[0] = 'ev10':
	cla
	*clr
	act 'Дать в киску Сене':gt'klofdomhouse','ev 16'
	act 'Дать в жопу Сене':gt'klofdomhouse','ev 17'
	act 'Отсосать Сене':gt'klofdomhouse','ev 18'
end
if $ARGS[0] = 'ev 16':
	cla
	*clr
	minut += 30
	klofQW += 1
	money += 100
	vagina += 1
	sex += 1
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str17')
	'<center><img src="images/klof/klof'+RAND(7,9)+'.jpg"></center>'
	gs 'zz_funcs', 'hornyrand'
	act '...':
		cla
		*clr
		gs 'zz_render', '', 'images/klof/klof10.jpg', func('klofdomhouse_strings', 'local_str18')
		act 'Уйти домой':gt'street'
	end
end
if $ARGS[0] = 'ev 17':
	cla
	*clr
	minut += 30
	klofQW += 1
	money += 100
	gs 'zz_funcs', 'cum', 'ass'
	anal += 1
	anus += 1
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str19')
	'<center><img src="images/klof/klof'+RAND(11,13)+'.jpg"></center>'
	gs 'zz_funcs', 'hornyrand'
	act '...':
		cla
		*clr
		gs 'zz_render', '', 'images/klof/klof14.jpg', func('klofdomhouse_strings', 'local_str20')
		act 'Уйти домой':gt'street'
	end
end
if $ARGS[0] = 'ev 18':
	cla
	*clr
	minut += 30
	klofQW += 1
	money += 100
	bj += 1
	guy += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str21')
	'<center><img src="images/klof/klof'+RAND(15,17)+'.jpg"></center>'
	gs 'zz_funcs', 'hornyrand'
	act '...':
		cla
		*clr
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str22')
		gs 'zz_render', '', 'images/klof/klof'+RAND(18,20)+'.jpg', func('klofdomhouse_strings', 'local_str23')
		act 'Уйти домой':gt'street'
	end
end
if $ARGS[0] = 'ev19':
	cla
	*clr
	minut += 30
	klofQW += 2
	money += 200
	sex += 1
	bj += 1
	vagina += 1
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str24')
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str25')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev20':
	cla
	*clr
	klofday = day
	minut += 5
	gs 'zz_render', '', 'images/klof/klof.jpg', func('klofdomhouse_strings', 'local_str26')
	act 'Поговорить с боссом':
		cla
		gt 'klofdomhouse', iif(klofQW<10,'ev21','ev22')
	end
end
if $ARGS[0] = 'ev21':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof24.jpg', func('klofdomhouse_strings', 'local_str27')
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev22':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof24.jpg', func('klofdomhouse_strings', 'local_str28')
	act 'Идти в комнату босса':gt'klofdomhouse','ev23'
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev23':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof25.jpg', func('klofdomhouse_strings', 'local_str29')
	act 'Показать себя':gt'klofdomhouse','ev24'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev24':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof26.jpg', func('klofdomhouse_strings', 'local_str30')
	act 'Показать грудь':gt'klofdomhouse','ev25'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev25':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof26_1.jpg', func('klofdomhouse_strings', 'local_str31')
	act 'Показать попку':gt'klofdomhouse','ev26'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev26':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof26_3.jpg', func('klofdomhouse_strings', 'local_str32')
	act 'Снять платье':gt'klofdomhouse','ev27'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev27':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof26_4.jpg', func('klofdomhouse_strings', 'local_str33')
	act 'Раздвинуть ножки':gt'klofdomhouse','ev28'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev28':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof26_6.jpg', func('klofdomhouse_strings', 'local_str34')
	act 'Соблазнять босса':gt'klofdomhouse','ev29'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev29':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/1284364hjl.jpg', func('klofdomhouse_strings', 'local_str35')
	act 'Покрутить попкой перед боссом':gt'klofdomhouse','ev30'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev30':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/1284365sgp.jpg', func('klofdomhouse_strings', 'local_str36')
	act 'Полизать головку у босса':gt'klofdomhouse','ev31'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev31':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof27.jpg', func('klofdomhouse_strings', 'local_str37')
	act 'Обхватить член губами':gt'klofdomhouse','ev32'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev32':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof28.jpg', func('klofdomhouse_strings', 'local_str38')
	act 'Раздвинуть ноги':gt'klofdomhouse','ev33'
	act 'Послать его на...':gt'street'
end
if $ARGS[0] = 'ev33':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof26_5.jpg', func('klofdomhouse_strings', 'local_str39')
	act 'Дать в киску':gt'klofdomhouse','ev34'
	act 'Отказаться':gt'street'
end
if $ARGS[0] = 'ev34':
	cla
	*clr
	minut += 30
	klofQW += 1
	vagina += 1
	sex += 1
	gs 'zz_render', '', 'images/klof/klof28.jpg', func('klofdomhouse_strings', 'local_str40')
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str41')
	act 'Дать в жопу':gt'klofdomhouse','ev35'
	act 'Отказаться':gt'street'
end
if $ARGS[0] = 'ev35':
	cla
	*clr
	minut += 30
	klofQW += 1
	anal += 1
	anus += 1
	gs 'zz_render', '', 'images/klof/klof29.jpg', func('klofdomhouse_strings', 'local_str42')
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', '', func('klofdomhouse_strings', 'local_str43')
	act 'Подставить лицо чтоб он кончил':gt'klofdomhouse','ev36'
	act 'Пускай кончает в жопу':gt'klofdomhouse','ev37'
	act 'Вставить член в киску':gt'klofdomhouse','ev38'
end
if $ARGS[0] = 'ev36':
	cla
	*clr
	gs 'zz_funcs', 'cum', 'face'
	money += 500
	gs 'zz_render', '', 'images/klof/klof30.jpg', func('klofdomhouse_strings', 'local_str44')
	act 'Встать с кровати':gt'klofdomhouse','ev39'
end
if $ARGS[0] = 'ev37':
	cla
	*clr
	money += 500
	gs 'zz_render', '', 'images/klof/klof32.jpg', func('klofdomhouse_strings', 'local_str45')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Встать с кровати':gt'klofdomhouse','ev39'
end
if $ARGS[0] = 'ev38':
	cla
	*clr
	money += 500
	gs 'zz_render', '', 'images/klof/klof31.jpg', func('klofdomhouse_strings', 'local_str46')
	act 'Встать с кровати':gt'klofdomhouse','ev39'
end
if $ARGS[0] = 'ev39':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof33l.jpg', func('klofdomhouse_strings', 'local_str47')
	act 'Послушно обслужить ребят':gt'klofdomhouse','ev40'
	act 'Отказаться':gt'street'
end
if $ARGS[0] = 'ev40':
	cla
	*clr
	minut += 30
	klofQW += 1
	db += 1
	bj += 1
	vagina += 2
	gs 'zz_render', '', 'images/klof/klof33.jpg', func('klofdomhouse_strings', 'local_str48')
	gs 'zz_funcs', 'hornyrand'
	act 'Встать и одеться':gt'klofdomhouse','ev41'
end
if $ARGS[0] = 'ev41':
	cla
	*clr
	money += 5000
	gs 'zz_render', '', 'images/klof/klof3.jpg', func('klofdomhouse_strings', 'local_str49')
	act 'Идти домой':gt'street'
end
if $ARGS[0] = 'ev42':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/klof3.jpg', func('klofdomhouse_strings', 'local_str50')
	act 'Идти купаться':gt'klofdomhouse','ev43'
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev43':
	cla
	*clr
	gs 'zz_render', '', 'images/klof/bas.jpg', func('klofdomhouse_strings', 'local_str51')
	act 'Прилечь возле бассейна':gt'klofdomhouse','ev44'
	act 'Уйти домой':gt'street'
end
if $ARGS[0] = 'ev44':
	cla
	*clr
	minut += 30
	gs 'zz_render', '', 'images/klof/bas1.jpg', func('klofdomhouse_strings', 'local_str52')
	if dom < 0:act 'Нерешительно снимать лифчик':gt'klofdomhouse','ev45'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev45':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas3.jpg', func('klofdomhouse_strings', 'local_str53')
	gs 'zz_render', '', 'images/klof/bas2.jpg', func('klofdomhouse_strings', 'local_str54')
	gs 'zz_render', '', 'images/klof/bas4.jpg', func('klofdomhouse_strings', 'local_str55')
	if dom <= -5:act 'Убрать руки':gt'klofdomhouse','ev46'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev46':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas5.jpg', func('klofdomhouse_strings', 'local_str56')
	gs 'zz_render', '', 'images/klof/bas6.jpg', func('klofdomhouse_strings', 'local_str57')
	if dom <= -10:act 'Идти в воду снимая трусики':gt'klofdomhouse','ev47'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev47':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas7.jpg', func('klofdomhouse_strings', 'local_str58')
	gs 'zz_render', '', 'images/klof/bas8.jpg', func('klofdomhouse_strings', 'local_str59')
	if dom <= -15:act 'Выйти из воды':gt'klofdomhouse','ev48'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev48':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas9.jpg', func('klofdomhouse_strings', 'local_str60')
	gs 'zz_render', '', 'images/klof/bas10.jpg', func('klofdomhouse_strings', 'local_str61')
	if dom <= -20: act 'Раздвинуть ноги':gt'klofdomhouse','ev49'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev49':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas11.jpg', func('klofdomhouse_strings', 'local_str62')
	gs 'zz_render', '', 'images/klof/bas12.jpg', func('klofdomhouse_strings', 'local_str63')
	if dom <= -25:act 'Раздвинуть губки':gt'klofdomhouse','ev50'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev50':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/vas13.jpg', func('klofdomhouse_strings', 'local_str64')
	if dom <= -30:act 'Ласкать свою киску':gt'klofdomhouse','ev51'
	act 'Послать его':gt'street'
end
if $ARGS[0] = 'ev51':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/vas14.gif', func('klofdomhouse_strings', 'local_str65')
	act 'Кончить':gt'klofdomhouse','ev52'
end
if $ARGS[0] = 'ev52':
	cla
	*clr
	minut += 5
	orgasm += 1
	horny = 0
	gs 'zz_render', '', 'images/klof/vas15.gif', func('klofdomhouse_strings', 'local_str66')
	act 'Вставить дидло':gt'klofdomhouse','ev53'
end
if $ARGS[0] = 'ev53':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas16.jpg', func('klofdomhouse_strings', 'local_str67')
	act 'Вставить второе дидло':gt'klofdomhouse','ev54'
end
if $ARGS[0] = 'ev54':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas17.jpg', func('klofdomhouse_strings', 'local_str68')
	act 'Вставить в попу':gt'klofdomhouse','ev55'
end
if $ARGS[0] = 'ev55':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas18.jpg', func('klofdomhouse_strings', 'local_str69')
	act 'Кайфовать':gt'klofdomhouse','ev56'
end
if $ARGS[0] = 'ev56':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas19.jpg', func('klofdomhouse_strings', 'local_str70')
	act 'Покорно держать стакан':gt'klofdomhouse','ev57'
end
if $ARGS[0] = 'ev57':
	cla
	*clr
	minut += 5
	horny += 10
	gs 'zz_render', '', 'images/klof/bas20.jpg', func('klofdomhouse_strings', 'local_str71')
	act 'Отсасывать у Жоры':gt'klofdomhouse','ev58'
end
if $ARGS[0] = 'ev58':
	cla
	*clr
	minut += 5
	bj += 1
	gs 'zz_render', '', 'images/klof/bas21.jpg', func('klofdomhouse_strings', 'local_str72')
	act 'Прыгать на члене':gt'klofdomhouse','ev60'
end
if $ARGS[0] = 'ev60':
	cla
	*clr
	minut += 10
	vagina += 1
	sex += 1
	gs 'zz_render', '', 'images/klof/bas27.jpg', func('klofdomhouse_strings', 'local_str73')
	act 'Принять заряд в себя':gt'klofdomhouse','ev61'
end
if $ARGS[0] = 'ev61':
	cla
	*clr
	gs 'zz_funcs', 'cum', 'face'
	minut += 10
	orgasm += 1
	horny = 0
	gs 'zz_render', '', 'images/klof/bas22.jpg', func('klofdomhouse_strings', 'local_str74')
	act 'Трахаться с толпой':gt'klofdomhouse','ev62'
end
if $ARGS[0] = 'ev62':
	cla
	*clr
	minut += 10
	orgasm += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_render', '', 'images/klof/bas23.jpg', func('klofdomhouse_strings', 'local_str75')
	act 'Трахаться с толпой':gt'klofdomhouse','ev63'
end
if $ARGS[0] = 'ev63':
	cla
	*clr
	minut += 10
	bj += 1
	gs 'zz_funcs', 'cum', 'lip'
	sex += 1
	orgasm += 1
	gs 'zz_funcs', 'cum', 'ass'
	anal += 1
	anus += 1
	gs 'zz_render', '', 'images/klof/bas24.jpg', func('klofdomhouse_strings', 'local_str76')
	act 'Трахаться с толпой':gt'klofdomhouse','ev64'
end
if $ARGS[0] = 'ev64':
	cla
	*clr
	minut += 10
	orgasm += 1
	bj += 1
	gs 'zz_funcs', 'cum', 'lip'
	sex += 1
	gs 'zz_funcs', 'cum', 'ass'
	anal += 1
	anus += 1
	gs 'zz_render', '', 'images/klof/bas25.jpg', func('klofdomhouse_strings', 'local_str77')
	act 'Встать и надеть купальник':gt'klofdomhouse','ev65'
end
if $ARGS[0] = 'ev65':
	cla
	*clr
	money += 200
	gs 'zz_render', '', 'images/klof/bas26.jpg', func('klofdomhouse_strings', 'local_str78')
	act 'Идти домой':gt'street'
end