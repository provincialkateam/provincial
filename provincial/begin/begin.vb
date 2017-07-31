if $args[0] = '' or $args[0] = 'main':
	gs 'zz_funcs', 'colorize_day'
	! make-hero page
	$_str = '<table border=0 width=630 cellpadding=0 cellspacing=0>'
	$_str += '<tr>'
	$_str += '<td>'+func('begin','box','nerd','Эмо','Бонус за чтение<br>Девушка в теле<br>Штраф к общению<br>Очки')+'</td>'
	$_str += '<td width=15></td>'
	$_str += '<td>'+func('begin','box','schoolgirl','Ботанка','Бонус к успеваемости<br>Хрупкое телосложение<br>Штраф к общению<br>Очки')+'</td>'
	$_str += '<td width=15></td>'
	$_str += '<td>'+func('begin','box','dancer','Творческая','Навык танцев<br>Навык вокала<br>Причёска<br>')+'</td>'
	$_str += '</tr>'
	$_str += '<tr><td colspan=5>&nbsp;</td></tr>'
	$_str += '<tr>'
	$_str += '<td>'+func('begin','box','sportgirl','Спортсменка','Членство в спортсекциях<br>Спортивное телосложение<br>Бонус к доминантности')+'</td>'
	$_str += '<td width=15></td>'
	$_str += '<td>'+func('begin','box','playgirl','Пацанка','Бонус в отношения<br>Бонус к доминантности<br>Цветные линзы<br>')+'</td>'
	!$_str += '<td width=15></td>'
	!$_str += '<td>'+func('begin','box','enrollee','Абитуриент','18 лет<br>Школьный аттестат<br>Старт с города<br>')+'</td>'
	$_str += '</tr>'
	$_str += '</table>'
	*pl '<center><br><br><font size=8 color=maroon>Выберите персонажа:</font><br><br>'+$_str+'</center>'
	killvar '$_str'
	exit
end
if $args[0] = 'box':
	$_img = 'images/common/mobile/'
	$result = '<table border=0 width=200 cellpadding=0 cellspacing=0>'
	! header
	$result += '<tr><td width=10><img src="'+$_img+'/tl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_img+'/tr.png"></td></tr>'
	! image
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee"><img width=180 src="images/common/start/'+$args[1]+'.jpg"></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! text
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee" align=center><font size=6><a href="exec:gt''begin'',''description'',''<<$args[1]>>''">'+$args[2]+'</a></font><br>'+$args[3]+'</td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! footer
	$result += '<tr><td width=10><img src="'+$_img+'/bl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_img+'/br.png"></td></tr>'
	$result += '</table>'
	killvar '$_img'
end
if $args[0] = 'description':
	$_str = $args[1]
	$_img = 'images/common/start/'+$_str+'_big.jpg'
	if $_str = 'nerd':
		gs 'zz_render','Эмо',$_img,'С детства вы были инфантильной девицей, вечной эльфой, витающей в облаках средь книжных миров. Персонажи фэнтези и выдуманные вселенные заменили вам реальных людей и обычный, бренный мир. Чтением посажено зрение. Учёба тоже хромает: вы слишком увлечены выдуманными мирами, чтобы обращать внимание на жалкий скучный Мидгард.'
	elseif $_str = 'schoolgirl':
		gs 'zz_render','Ботанка',$_img,'Вы рано научились читать, и книги заменили вам всё: когда сверстницы играли во дворе в "резиночку", вы сажали зрение, просиживая за "умными книжками" целыми днями. Одноклассники с первых классов просят списать, но сторонятся "очкастой заучки".'
	elseif $_str = 'dancer':
		gs 'zz_render','Творческая',$_img,'С детства в вас проявилась творческая жилка: на любом утреннике ещё с детсада вы всегда пели и танцевали; в школе вы всегда участвовали во всевозможных постановках, уже тогда всерьёз подумывая о профессиональной карьере в шоубизнесе. Благо, хороший голос и слух позволяют на это надеяться. Но заниматься профессионально танцами и вокалом в Павлово негде: а ездить постоянно в город, где такая возможно есть, дорого и долго. Родители, помявшись, в своё время вам отказали: "Не потянем, прости!". Секция спортивных танцев в ДК вам уже неинтересна: вы сами можете там преподавать.'
	elseif $_str = 'sportgirl':
		gs 'zz_render','Спортсменка',$_img,'Вы с детства занимались спортом. Свободного времени почти не оставалось: тренировки, режим и ещё раз тренировки. На учёбе это отразилось не в лучшую сторону, вы лишь кое-как учитесь на тройки-четвёрки, но по физкультуре у вас неизменная "пятёрка". Жёсткий режим не дал возможности завести подруг-друзей, но зато вашей поджарой атлетичной фигуре завидуют все девчонки, хоть некоторые и хихикают втихаря, боясь сказать в лицо: "баба-конь"!'
	elseif $_str = 'playgirl':
		gs 'zz_render','Пацанка',$_img,'Учились вы всегда неважно, но зато были бессменной "королевой Камчатки" - задних парт в классе - и "заводилой". С вами стремятся дружить все: вы легко общаетесь как со школьной гопотой - "Она ж свой пацан, хоть и девка!" - так и умудряетесь находить общий язык с ботанами с первых парт (списывать они вам всегда дают). Вы всегда можете "разрулить вопрос" так, что и волки сыты, и овцы целы.'
	else
		gs 'zz_render','Абитуриент',$_img,'Вы недавно закончили школу, отгуляли выпускной, и пришло время начинать свою взрослую жизнь в большом городе. Родители собрали для вас стартовый капитал в 20 тыс. рублей и отправили поступать в ВУЗ.'
	end
	gs 'zz_render','','','<center><font size=8><a href="exec:gt''begin'',''main''">Назад</a>   <a href="exec:gt''begin'',''start_date'',''<<$_str>>''">Начать</a></font></center>'
	killvar '$_str'
	killvar '$_img'
end
if $args[0] = 'start_date':
	$_hero_type =  $args[1]
	if $_hero_type = 'enrollee': gt 'begin','hero',$_hero_type
	$_str = '<table border=0 width=630 cellpadding=0 cellspacing=0>'
	$_str += '<tr>'
	$_str += '<td>'+func('begin','box2','start1','Павлово','Старт: 01.06.2015')+'</td>'
	$_str += '<td width=15></td>'
	$_str += '<td>'+func('begin','box2','start2','Гадюкино','Старт: 01.06.2015')+'</td>'
	$_str += '<td width=15></td>'
	$_str += '<td>'+func('begin','box2','start3','Павлово','Старт: 29.08.2015')+'</td>'
	$_str += '</tr>'
	*pl '<center><br><br><font size=8 color=maroon>Выберите время и место начала игры:</font><br><br>'+$_str+'</center>'
	killvar '$_str'
	exit
end
if $args[0] = 'box2':
	$_img = 'images/common/mobile/'
	$result = '<table border=0 width=200 cellpadding=0 cellspacing=0>'
	! header
	$result += '<tr><td width=10><img src="'+$_img+'/tl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_img+'/tr.png"></td></tr>'
	! image
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee"><img width=180 src="images/common/start/'+$args[1]+'.jpg"></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! text
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee" align=center><font size=6><a href="exec:gt''begin'',''hero'',''<<$args[1]>>''">'+$args[2]+'</a></font><br>'+$args[3]+'</td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! footer
	$result += '<tr><td width=10><img src="'+$_img+'/bl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_img+'/br.png"></td></tr>'
	$result += '</table>'
	killvar '$_img'
end
if $args[0] = 'hero':
	$_start = $args[1]
	$name = 'Светлана' & $name_a = 'Светлану' & $name_b = 'Светланы'
	$name[1] = 'Света' & $name_a[1] = 'Свету' & $name_b[1] = 'Светы'
	$name[2] = 'Светик' & $name_a[2] = 'Светочку' & $name_b[2] = 'Светочки'
	$name[3] = 'Светуля' & $name_a[3] = 'Светулечку' & $name_b[3] = 'Светулечки'
	$name[4] = 'Свет' & $name_a[4] = 'Светуль' & $name_b[4] = 'Светлан'
	$surname = 'Лебедева' & $surname_a = 'Лебедеву' & $surname_b = 'Лебедевой'
	birthday = 5
	birthmonth = 3
	! ---
	glacol = 1
	glaraz = 2
	hcol = 1
	hcolmotherremember = 1
	father['haircolor'] = 1
	lip = 0
	! ---
	age = 17
	vidage = 16
	year = 2015
	year_start = 2015
	if $_start = 'start3':
		month = 8
		day = 28
		week = 5
	else
		month = 6
		day = 1
		week = 1
	end
	hour = 9
	birthyear = year - age
	!тело
	energy = 15
	water = 15
	son = 24
	!Статы
	stren = 10
	speed = 10
	agil = 10
	vital = 10
	intel = 10
	react = 10
	health = 100
	manna = 100
	money = 500
	vidageday = 300
	housrA = 0
	! ---
	mop = 1
	housr = 0
	tanga = 1
	lobok = 3
	! ---
	daystart = 0
	! ---
	$car['id'] = -1
	! ---
	prezikProver = 3
	! Нужные для работы квестов на пляже глобальные переменные.
	! Можно запихнуть их в другое место - главное чтобы были определены глобально.
	voyeurism = 0
	voyeurism_start = 0
	voyeurism_forest = 0
	voyeurism_nudist = 0
	! ---
	DrunkGirl_end = 0
	leghair = 5
	clrbelo = 10
	tampon = 20
	palto = 1
	$palto = 'китайский пуховик'
	school['progress'] = 75
	! relation
	$npc['35,relation'] = 50
	$npc['37,relation'] = 50
	$npc['38,relation'] = 50
	$npc['39,relation'] = 50
	grandmaQW = 60
	grandpaQW = 60
	gs 'npc_editor','init'
	! body & bonuses
	body['height'] = iif($_hero_type = 'sportgirl',rand(173,180),rand(165,172))
	gs 'zz_body'
	body['weight'] = body['base_weight'] + rand(1,5)
	if $_hero_type = 'nerd':
		body['weight'] = body['base_weight'] + rand(25,30)
		glaraz = 0
		stren = 1
		vital = 5
		agil = 1
		tan = 0
		blizoruk = 300
		glass = 1
		dom = 0
		school['progress'] = 50
		nerdism = 100
		grupTipe = 1
		skin = 0
		leghair = 10
	elseif $_hero_type = 'schoolgirl':
		body['weight'] = body['base_weight'] - rand(1,5)
		stren = 1
		vital = 5
		agil = 1
		intel = 70
		tan = 0
		$npc['37,relation'] = 100
		$npc['35,relation'] = 60
		money = 2000
		blizoruk = 300
		dom = -20
		glass = 1
		school['progress'] = 100
		nerdism = 100
		grupTipe = 1
		skin = 1
		leghair = 3
	elseif $_hero_type = 'dancer':
		intel = 30
		agil = 60
		stren = 20
		vital = 20
		lip = 1
		school['progress'] = 70
		$npc['37,relation'] = 70
		vokal = 80
		dance = 90
		tan = 30
		grupTipe = 0
		skin = 2
		dom = rand(-10,10)
		leghair = -5
	elseif $_hero_type = 'sportgirl':
		stren = 50
		vital = 50
		speed = 25
		agil = 25
		volleyboll = 70
		beg = 40
		gsAboVolley = 120
		gsAboBeg = 30
		dom = rand(10,30)
		tan = 30
		school['progress'] = 50
		grupTipe = 2
		skin = 1
		leghair = 0
		body['weight'] = body['base_weight'] + rand(3,7)
	elseif $_hero_type = 'playgirl':
		agil = 20
		vital = 20
		dom = rand(30,60)
		school['progress'] = 50
		tan = 30
		grupTipe = 5
		skin = 2
		colorful_lenses = 30
		leghair = -5
	else
		skin = 1
		tan = 30
		money = 20000
		school['certificate'] = 1
		grupTipe = 0
		age = 18
		vidage = 16
		month = 6
		week = 3
		hour = 13
		leghair = 3
		son = 16
		cltarelka = 1
		fairy = 10
		eda = 5
		clrbelo = 2
		poroshok = 5
		shampoo = 5
		ArendHouseSL = 30
		housr = 1
	end
	motherAge = age + 19
	sisterAge = age + 2
	brotherAge = age - 1
	i = 1
	:mark_grup
	if grupTipe = 1:
		$npc['<<i>>,relation'] = rand(40,45)
	elseif grupTipe = 2:
		if $npc['<<i>>,group'] = grupTipe:
			$npc['<<i>>,relation'] = rand(60,70)
		else
			$npc['<<i>>,relation'] = rand(45,55)
		end
	else
		$npc['<<i>>,relation'] = rand(45,55)
	end
	i += 1
	if i <= 25: jump 'mark_grup'
	! ---
	! init stats
	gs 'stat'
	! ---
	! init clothing & wardrobe
	gs 'zz_clothing', 'init_clothing'
	! ---
	! start clothing
	gs 'zz_clothing', 'add_to_wardrobe', 0
	gs 'zz_clothing', 'add_to_wardrobe', 1
	gs 'zz_clothing', 'add_to_wardrobe', 2
	! add sarafan
	gs 'zz_clothing', 'add_to_wardrobe', 3
	! add jeans
	gs 'zz_clothing', 'add_to_wardrobe', 6
	! add sportswear
	gs 'zz_clothing', 'add_to_wardrobe', 25
	! add dress
	gs 'zz_clothing', 'add_to_wardrobe', rand(68,127)
	tanga = 1
	current_clothing = 4
	! add school dress
	!if $_start ! 'enrollee':
		gs 'zz_clothing', 'add_to_wardrobe', 151
		gs 'zz_school','vacation_status'
	!end
	! set new sizes
	gs 'zz_clothing', 'resize_all'
	! clearing clothing variables
	gs 'zz_clothing', 'dispose'
	! ---
	! render settings
	gs 'zz_render_settings','default'
	! load dynamics
	gs 'din2'
	gs 'din_bag'
	gs 'dinSex'
	!
	SHOWSTAT 1
	SHOWOBJS 1
	SHOWACTS 1
	! set menu
	addobj '<img src="images/common/icons/pers.png">'
	addobj '<img src="images/common/icons/look.png">'
	addobj '<img src="images/common/icons/proch.png">'
	addobj '<img src="images/common/icons/purse.png">'
	! start game
	!if $_hero_type = 'enrollee':
	!	killvar '$_hero_type'
	!	gt 'street'
	!end
	killvar '$_hero_type'
	if $_start = 'start2':
		killvar '$_start'
		gt 'Gaddvor'
	else
		killvar '$_start'
		gt 'bedrPar'
	end
end
exit