! current page
! $books['0,page']
! reading count
! $books['0,exists']
! ranges
! 0-9 - non-fiction
! 10-19 - fantasy
! 20-29 - women novels
! 30-39 - erotic
! shelf in parant`s house
if $args[0] = 'main':
	*clr & cla
	act 'Отойти': gt $loc,$metka
	i = 0
	$_str = '<center><table width=700>'
	:loop_shelf
	if $books['<<i>>,exists'] = 1 and i ! reading['sister_book']:
		$zz_color = iif($zz_color='#f3f4ee','#ffffff','#f3f4ee')
		$_str += '<tr bgcolor='+$zz_color+'>'
		$_str += '<td width=50><img src="images/common/books/<<i>>.jpg" width=50></td>'
		$_str += '<td width=550><a href="exec:gt''zz_books'',''read'',<<i>>">'+func('zz_books','get_name',i)+'</a>(<<i>>)</td>'
		$_str += '<td width=150 align=center>' + iif($books['<<i>>,page']/20 = 0,$books['<<i>>,page'] * 20,'(Уже прочтена)<br>'+($books['<<i>>,page'] mod 20) * 20) + ' стр.</td>'
		$_str += '</tr>'
	end
	i += 1
	if i < arrsize('$books')/2: jump 'loop_shelf'
	$_str += '</table></center>'
	gs 'zz_render','','',$_str
	killvar '$_str'
	exit
end
! make start array
if $args[0] = 'init':
	i = 0
	:loop_make_shelf
	$books['<<i>>,page'] = 0
	$books['<<i>>,exists'] = 0
	i += 1
	if i < 40: jump 'loop_make_shelf'
	! add some random books to shelf
	$books['<<rand(0,9)>>,exists'] = 1
	$books['<<rand(10,14)>>,exists'] = 1
	$books['<<rand(14,19)>>,exists'] = 1
	$books['<<rand(20,24)>>,exists'] = 1
	$books['<<rand(25,29)>>,exists'] = 1
end
if $args[0] = 'sister_book':
	! make books-exists array
	i = 0
	:loop_books_exist
	if $books['<<i>>,exists'] = 1: arr_books[] = i
	i += 1
	if i < arrsize('$books')/2: jump 'loop_books_exist'
	result = arr_books[rand(0,arrsize('arr_books')-1)]
	killvar 'arr_books'
end
if $args[0] = 'read':
	*clr & cla
	_book = args[1]
	$_str = '<center>Прочтено ' + iif($books['<<_book>>,page']/20 = 0,$books['<<_book>>,page'] * 20,($books['<<_book>>,page'] mod 20) * 20) + ' из 400 страниц</center>'
	gs 'zz_render',func('zz_books','get_name',_book),'common/books/<<_book>>.jpg',$_str
	killvar '$_str'
	act 'Читать':
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':killvar '_book' & gt $loc, $metka
		end
		if reading['read_per_day'] >= iif(nerdism >= 40,5,3):
			cla
			gs 'zz_render','','','<center><red>Нее, на сегодня хватит!</red></center>'
			act '...': killvar '_book' & gt $loc,$metka
			exit
		end
		gs 'zz_books', 'read_procedure'
		if $books['<<_book>>,page'] >= 20 and $books['<<_book>>,page'] mod 20 = 0:
			! intellect bonus
			if _book < 10: intel += iif($books['<<i>>,page']/20 < 1, 3, 1)
			gt 'zz_books', 'readed', _book
			exit
		else
			gt 'zz_books', 'read', _book
		end
	end
	act 'Поставить на место': killvar '_book' & gt $loc,$metka
end
! recalc bonuses
if $args[0] = 'read_procedure':
	$books['<<_book>>,page'] += 1
	! bonuses
	reading['read_per_day'] += 1
	minut += rand(50,70)
	blizoruk += 1
	if nerdism > 0:
		nerdism += 20
		manna += 30
	else
		if _book >= 10 and _book < 20: manna += iif($books['<<i>>,page'] < 20,10,5)
		if _book >= 20 and _book < 30: horny += iif($books['<<i>>,page'] < 20,5,3) & manna += iif($books['<<_book>>,page'] < 20,5,3)
		if _book >= 30 and _book < 40: horny += iif($books['<<i>>,page'] < 20,10,5)
	end
	if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
	gs 'stat'
end
if $args[0] = 'readed':
	*clr & cla
	gs 'zz_render','','', func('zz_books','get_name',args[1])+'<br>Вы наконец-то прочли эту книгу.'
	act '...': gt $loc,$metka
end
if $args[0] = 'get_name':
	$_bookname[0] = 'Перельман Я.И. «Занимательная арифметика».'
	$_bookname[1] = 'Стивен Хокинг. «Краткая история времени»'
	$_bookname[2] = 'Митио Каку. «Физика невозможного»'
	$_bookname[3] = 'Тур Хейердал. «Путешествие на „Кон-Тики“»'
	$_bookname[4] = 'Владимир Мезенцев. «Энциклопедия чудес»'
	$_bookname[5] = 'Михаил Гаспаров. «Занимательная Греция. Рассказы о древнегреческой культуре»'
	$_bookname[6] = 'Чарльз Дарвин. «Происхождение видов»'
	$_bookname[7] = 'Билл Брайсон. «Краткая история почти всего»'
	$_bookname[8] = 'Роберт Мартин. «Как мы делаем это: Эволюция и будущее репродуктивного поведения человека»'
	$_bookname[9] = 'Стэнли Милгрэм. «Подчинение авторитету: Научный взгляд на власть и мораль»'
	$_bookname[10] = 'Роберт Хайнлайн. "Кошка, проходящая сквозь стены"'
	$_bookname[11] = 'Анджей Сапковский. "Ведьмак"'
	$_bookname[12] = 'Гарри Гаррисон. "Стальная крыса"'
	$_bookname[13] = 'Дж.Р.Р. Толкин. "Властелин Колец"'
	$_bookname[14] = 'Роджер Желязны. "Хроники Амбера"'
	$_bookname[15] = 'Майкл Суэнвик. "Вакуумные цветы"'
	$_bookname[16] = 'Г.Л. Олди. "Путь меча"'
	$_bookname[17] = 'Михаил Успенский. "Приключения Жихаря"'
	$_bookname[18] = 'Уильям Гибсон. «Киберпространство»'
	$_bookname[19] = 'Джоан Роулинг. "Гарри Поттер"'
	$_bookname[20] = 'Сандра Браун. "Сокровенные тайны"'
	$_bookname[21] = 'Джейн Энн Кренц. Сладкая судьба'
	$_bookname[22] = 'Люсиль Картер. "Невзгодам вопреки"'
	$_bookname[23] = 'Кимберли Рэнделл. "Золушка-грешница"'
	$_bookname[24] = 'Эмма Дарси. "Путешествие с шейхом"'
	$_bookname[25] = 'Сара Вуд. "Островок любви"'
	$_bookname[26] = 'Кристина Дорсей. "Сердце пирата"'
	$_bookname[27] = 'Тереза Карпентер. "Эта несносная няня"'
	$_bookname[28] = 'Энн Мэтер. "Наслаждение и боль"'
	$_bookname[29] = 'Шарлотта Бронте. "Джейн Эйр"'
	$_bookname[30] = 'Франциска Вудворт. "Аромат невинности"'
	$_bookname[31] = 'Дж. Р. Уорд. "Освобожденный любовник"'
	$_bookname[32] = 'Саманта Янг. "Город моей любви"'
	$_bookname[33] = 'Э. Л. Джеймс. "Пятьдесят оттенков серого"'
	$_bookname[34] = 'Эммануэль Арсан. «Эммануэль»'
	$_bookname[35] = 'Полин Реаж. «История О»'
	$_bookname[36] = 'Владимир Набоков. "Лолита"'
	$_bookname[37] = 'Маркиз де Сад. «Жюстина, или Несчастная судьба добродетели»'
	$_bookname[38] = 'Элизабет Макнейл. «9 ½ недель»'
	$_bookname[39] = 'Ги де Мопассан. «Милый друг».'
	$result = $_bookname[args[1]]
	killvar '$_bookname'
end
! --- sister quest --- !
! --- enable erotic books --- !
if $args[0] = 'erotic_enable':
	! возникает при выполенении одного из условий:
	! сестра спалила за мастурбацией
	! сестра в курсе, что ГГ дает
	! ГГ прочла хоть один дамский роман
	! обязательное условие - отличные отношения с сестрой
	*clr & cla
	$_str = '<dh>- Привет, сестренка, что читаешь?</dh> - спросили вы Аньку.<br>'
	if (sisterknowslut + SisterKnowMastr) > 0:
		$_str += '<do>- Да ничего такого, чего б ты не знала!</do> - хихикнула она. - <do>Эротику!</do><br><dh>- Дай и мне почитать</dh> - не угомонивались вы, пытаясь забрать у Аньки книгу.<br><do>- Отстань, завтра возьмешь, я уже дочитываю.<br>- Не понравится эта - сходи на рынок - за центральным входом второй ряд налево и в самый конец - там лоток с порнухой и эротикой. Вот только порножурналы я не советовала б тащить домой, а то от мамки влетит по первое число.</do>'
	else
		$_str += '<do>- Да так, любовный роман...</do> - ответила Анька, краснея и пытаясь спрятать книгу.<br>Быстро сообразив, что сестренка от вас что-то скрывает, вы ловко повалили ее на кровать и отобрали книгу - <dh>Эммануэль Арсан. «Эммануэль». Ничего себе, Анька, это же порнуха!</dh> - как на духу произнесли вы, прочитав название книги.<br><do>Никакая это не порнуха, а эротика. Поинтереснее твоих любовных романов с розовыми мечтами.</do> - отсекла Анька. - <do>Почитай как-нибудь, тебе понравится. Я оставлю на полке.<br>- Не понравится эта - сходи на рынок - за центральным входом второй ряд налево и в самый конец - там лоток с пор... эротикой.</do>'
	end
	gs 'zz_render', '', 'pavlovo/family/sister/sister_reading.jpg', $_str
	killvar '$_str'
	! открываем лоток с эротикой
	pornmarkonce = 1
	! делаем книгу активной для сестры
	reading['sister_book'] = 34
	! флажок для магаза
	reading['erotic_enable'] = 1
	! добавляем книгу в существующие
	$books[34+"_"+'exists'] = 1
	act 'Отойти': gt 'bedrPar'
end
if $args[0] = 'novel_readed':
	! проверка прочитаных любовных романов
	i = 20
	zz_novel = 0
	:loop_novel
	if $books['<<i>>,page'] >= 20: zz_novel += 1
	i += 1
	if i < 29: jump 'loop_novel'
	result = zz_novel
	killvar 'zz_novel'
end
if $args[0] = 'ero_readed':
	! проверка прочитаных эрокнижек
	i = 30
	zz_ero = 0
	:loop_ero_books
	if $books['<<i>>,page'] >= 20: zz_ero += 1
	i += 1
	if i < 39: jump 'loop_ero_books'
	result = zz_ero
	killvar 'zz_ero'
end
if $args[0] = 'erotic_block':
	! мать проявляет интерес
	*clr
	$_str = 'Только вы вошли в свою комнату, как на вас набросилась мать:'
	if $npc['37,relation'] < 40:
		cla
		! плохая репа
		gs 'npc_editor','change_rep','-', 37, 20
		$_str += '<do>- Это что еще такое? Порнуху в дом принесла, блядища ты этакая?! Нет, что б полезное что почитать!</do> - кричала мать, тряся книгой у ваc перед лицом.<br>Ругаясь, мать собрала все книги, выдавшиейся ей порнографическими и ушла, громко хлопнув дверью.'
		! блокируем доступ в магазине
		reading['erotic_enable'] = -1
		! удаляем всю эротику
		gs 'zz_books', 'remove_ero'
		gs 'zz_render', '', '', $_str
		act '...': gt 'bedrPar'
	else
		$_str += '<do>- Это что еще такое, <<$name[2]>>? Порнуху в дом принесла?</do> - строго спросила мать, и, явно ожидая ответа, ткнула вам под нос книгу. Но не успели вы открыть рот, как она продолжила:<br><do>- И не смей меня перебивать! Куда ж мир катится, в наше время-то...</do>'
		gs 'zz_render', '', '', $_str
		minut += 5
		cla
		act 'Молчать':
			cla
			dom -= 1
			reading['erotic_enable'] = -1
			gs 'zz_render', '', '', 'Ругаясь, мать собрала все книги, выдавшиейся ей порнографическими и ушла, громко хлопнув дверью.'
			gs 'zz_books', 'remove_ero'
			act '...': gt 'bedrPar'
		end
		act 'Перебить':
			cla
			dom += 1
			reading['erotic_enable'] = 2
			gs 'zz_render', '', '', '<dh>- Да в учебнике биологии порнографии больше, чем этих книгах, это эротика</dh>, - неожиданно, как для себя, так и для матери, выпалили вы. Мать, не сообразив, что ответить, лишь отдала вам книгу и сказав - <do>уж лучше так с взрослой жизнью знакомится, чем с непонятными особями где-то в подворотье...</do>, ушла.'
			act '...': gt 'bedrPar'
		end
	end
	killvar '$_str'
end
if $args[0] = 'remove_ero':
	i = 30
	:loop_ero_remove
	$books['<<i>>,exists'] = 0
	i += 1
	if i < 39: jump 'loop_ero_remove'
end
if $args[0] = 'shop':
	! init books
	if arrsize('books') = 0: gs 'zz_books','init'
	! ---
	$zz_ero = $args[1]
	i = iif($zz_ero = 'ero',30,0)
	$_str = '<center><table width=700>'
	:loop_shop
	! названия разделов
	if $zz_ero = 'ero':
		if i = 30: $_str += '<tr bgcolor=#bbee77><td colspan=2 align=center><b>Эротика - 500р.</b></td></tr>'
	else
		if i = 0: $_str += '<tr bgcolor=#bbee77><td colspan=2 align=center><b>Научно-популярная литература - 300р.</b></td></tr>'
		if i = 10: $_str += '<tr bgcolor=#bbee77><td colspan=2 align=center><b>Фантастика/фентези - 250р.</b></td></tr>'
		if i = 20: $_str += '<tr bgcolor=#bbee77><td colspan=2 align=center><b>Любовные романы - 200р.</b></td></tr>'
	end
	if $books['<<i>>,exists'] ! 1:
		! книги
		$zz_color = iif($zz_color='#f3f4ee','#ffffff','#f3f4ee')
		$_str += '<tr bgcolor='+$zz_color+'>'
		$_str += '<td width=600>'+func('zz_books','get_name',i)+'</td>'
		zz_price = func('zz_books','get_price',i)
		$_str += '<td width=100 align=center>'+iif(money >= zz_price,'<a href="exec:gs''zz_books'',''buy'',<<i>>,<<zz_price>>,''<<$zz_ero>>''">Купить</a>','Купить')+'</td>'
		$_str += '</tr>'
	end
	i += 1
	books_size = iif($zz_ero = 'ero',40,30)
	if i < books_size: jump 'loop_shop'
	$_str += '</table></center>'
	gs 'zz_render','','',$_str
	killvar '$_str'
	killvar 'books_size'
	killvar '$zz_ero'
	killvar '$zz_price'
	exit
end
if $args[0] = 'get_price':
	if args[1] < 10: result = 300
	if args[1] >= 10 and args[1] < 20: result = 250
	if args[1] >= 20 and args[1] < 30: result = 200
	if args[1] >= 30 and args[1] < 40: result = 500
end
if $args[0] = 'buy':
	*clr
	gs 'zz_funcs','message','', '<font color=green>Вы купили книгу "' + func('zz_books','get_name',args[1]) + '"</font>'
	$books['<<args[1]>>,exists'] = 1
	money -= args[2]
	gs 'stat'
	gs 'zz_books', 'shop', iif($args[3] = 'ero','ero','')
end
if $args[0] = 'book2bag':
	! make books-exists array
	! exclude sister book
	i = 0
	:loop_book2bag
	if $books['<<i>>,exists'] = 1 and i ! reading['sister_book']: arr_books[] = i
	i += 1
	if i < arrsize('$books')/2: jump 'loop_book2bag'
	reading['in_bag'] = arr_books[rand(0,arrsize('arr_books')-1)]
	killvar 'arr_books'
end
if $args[0] = 'read_on_walk':
	*clr & cla
	if glassqw = 1:
		gs 'zz_render', $_str, 'common/park/tired_eyes.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
		act 'Отложить книгу':killvar '_book' & gt $loc, $metka
	end
	act 'Положить книгу в сумочку': gt $loc, $metka
	i = reading['in_bag']
	if reading['read_per_day'] >= iif(nerdism = 0,3,5):
		$_str = '<b>Нее, на сегодня хватит!</b>'
	else
		$_str = func('zz_books','get_name',i)+'<br>Прочтено ' + iif($books['<<i>>,page']/20 = 0,$books['<<i>>,page'] * 20,($books['<<i>>,page'] mod 20) * 20) + ' из 400 страниц.<br>'
		$_str += 'Не обращая внимания на окружающих, вы '+iif($loc = 'zz_park','забрались с ногами на лавочку','лежите, загорая, на пляжном полотенце,')+' и с упоением читаете книгу.'
		if $loc ! 'zz_park':
			hapri = 1
			sweat += iif(temper < 22,1,iif(temper < 30,2,3))
			if sunWeather <= 2:
				tan += iif(current_clothing > 0,1,2)
			else
				tan += iif(current_clothing > 0,2,4)
			end
		end
		if $books['<<i>>,page'] >= 20 and $books['<<i>>,page'] mod 20 = 0:
			! intellect bonus
			if i < 10: intel += iif($books['<<i>>,page']/20 < 1, 3, 1)
			$_str += '<br>Вы наконец-то прочли эту книгу.'
		end
		gs 'zz_books', 'read_procedure'
	end
	gs 'stat'
	gs 'time'
	if $loc = 'zz_park':
		gs 'zz_render', '','common/park/reading_on_walk'+iif(month<9,0,1)+'.jpg',$_str
	elseif $loc = 'gadfield':
		gs 'zz_render', '','qwest/gadukino/gadfield/graze_cow_book'+rand(1,2)+'.jpg',$_str
	else
		gs 'zz_render', '','common/beach/reading_<<$loc>>'+iif(current_clothing = 0,'_nude'+rand(1,3),rand(1,3))+'.jpg',$_str
	end
	killvar '$_str'
end
! shelf for other places
! args[1] - optional: min value of range
! args[2] - optional: max value of range
if $args[0] = 'read_on_walk':
	*clr & cla
	act 'Положить книгу в сумочку': gt $loc, $metka
	i = reading['in_bag']
	if reading['read_per_day'] >= iif(nerdism = 0,3,5):
		$_str = '<b>Нее, на сегодня хватит!</b>'
	else
		gs 'zz_books', 'read_procedure'
		$_str = func('zz_books','get_name',i)+'<br>Прочтено ' + iif($books['<<i>>,page']/20 = 0,$books['<<i>>,page'] * 20,($books['<<i>>,page'] mod 20) * 20) + ' из 400 страниц.<br>'
		$_str += 'Не обращая внимания на окружающих, вы '+iif($loc = 'zz_park','забрались с ногами на лавочку','лежите, загорая, на пляжном полотенце,')+' и с упоением читаете книгу.'
		if $loc ! 'zz_park':
			hapri = 1
			sweat += iif(temper < 22,1,iif(temper < 30,2,3))
			if sunWeather <= 2:
				tan += iif(current_clothing > 0,1,2)
			else
				tan += iif(current_clothing > 0,2,4)
			end
		end
		if $books['<<i>>,page'] >= 20 and $books['<<i>>,page'] mod 20 = 0:
			! intellect bonus
			if i < 10: intel += iif($books['<<i>>,page']/20 < 1, 3, 1)
			$_str += '<br>Вы наконец-то прочли эту книгу.'
		end
	end
	gs 'stat'
	gs 'time'
	if $loc = 'zz_park':
		gs 'zz_render', '','common/park/reading_on_walk'+iif(month<9,0,1)+'.jpg',$_str
	elseif $loc = 'gadfield':
		gs 'zz_render', '','qwest/gadukino/gadfield/graze_cow_book'+rand(1,2)+'.jpg',$_str
	else
		gs 'zz_render', '','common/beach/reading_<<$loc>>'+iif(current_clothing = 0,'_nude'+rand(1,3),rand(1,3))+'.jpg',$_str
	end
	killvar '$_str'
end
! shelf for other places
! args[1] - optional: min value of range
! args[2] - optional: max value of range
if $args[0] = 'custom_shelf':
	! init books
	if arrsize('books') = 0: gs 'zz_books','init'
	! ---
	*clr & cla
	act 'Отойти': gt $loc,$metka
	! check ranges
	_min_book = iif(args[1]>0,args[1],0)
	_max_book = iif(args[2]>0 and args[2]<40,args[2],39)
	! make table
	i = 0
	$_str = '<table width=100%>'
	:loop_custom_shelf
	if i >= _min_book and i <= _max_book:
		$zz_color = iif($zz_color='#f3f4ee','#ffffff','#f3f4ee')
		$_str += '<tr bgcolor='+$zz_color+'>'
		$_str += '<td width=550><a href="exec:gt''zz_books'',''read'',<<i>>">'+func('zz_books','get_name',i)+'</a></td>'
		$_str += '<td align=center>' + iif($books['<<i>>,page']/20 = 0,$books['<<i>>,page'] * 20,'(Уже прочтена)<br>'+($books['<<i>>,page'] mod 20) * 20) + ' стр.</td>'
		$_str += '</tr>'
	end
	i += 1
	if i < arrsize('$books')/2: jump 'loop_custom_shelf'
	$_str += '</table>'
	gs 'zz_render','','',$_str
	killvar '$_str'
	killvar '_min_book'
	killvar '_max_book'
	exit
end