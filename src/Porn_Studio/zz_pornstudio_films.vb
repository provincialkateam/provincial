if $args[0] = 'films':
	*clr & cla
	act '<b>Закрыть</b>': gt 'zz_pornstudio'
	act 'Список актрисс': gt 'zz_pornstudio_actress','actress_list'
	act 'test update':
		daystart += 1
		day += 1
		if day > 30: day = 1
		gs 'zz_pornstudio_films','update_films_info'
		gt 'zz_pornstudio_films','films'
	end
	gs 'zz_pornstudio_films','film_list',-1
end
! фильмография студии или актриссы
! args[1] - id актриссы, если id = -1 - для все актрисс
if $args[0] = 'film_list':
	_actress_film_id = args[1]
	$_film_str = ''
	! шапка
	$_film_str += '<tr>'
	$_film_str +=	'<th>Дата</th>'
	$_film_str +=	'<th>Название</th>'
	$_film_str +=	'<th>Рейтинг</th>'
	$_film_str +=	'<th>Просмотры</th>'
	$_film_str +=	'<th>Актриссы</th>'
	$_film_str +=	'<th>Жанр</th>'
	$_film_str +=	'<th>Бюджет</th>'
	$_film_str +=	'<th>Реклама</th>'
	$_film_str +=	'<th>Прибыль</th>'
	$_film_str += '</tr>'
	i = 0
	:loop_films
	if i < arrsize('$films')/11:
		!--
		! выводим вначале самые большие id фильмов - "разворачиваем" массив
		_cur_id = arrsize('$films')/11 - 1 - i
		! проверяем условия для вывода фильмов для определенной актриссы
		if _actress_film_id >= 0:
			if func('zz_funcs','get_item_id',$films['<<_cur_id>>,actress'],str(_actress_film_id)) < 0:
				i += 1
				jump 'loop_films'
			end
		end
		!--
		$_film_str += '<tr>'
		$_film_str +=	'<td>'+$films['<<_cur_id>>,date_str']+'</td>'
		$_film_str +=	'<td><a href="exec:gt''zz_pornstudio_films'',''film_view'',<<_cur_id>>">'+$films['<<_cur_id>>,name']+'</a></td>'
		$_film_str +=	'<td><img class="rating" src="images/city/north/pornstudio/rating/'+$films['<<_cur_id>>,rating']/10+'.png"></td>'
		$_film_str +=	'<td>'+$films['<<_cur_id>>,view']+'</td>'
		$_film_str +=	'<td>'+func('zz_pornstudio_actress','get_actress_name',$films['<<_cur_id>>,actress'])+'</td>'
		$_film_str +=	'<td>'+$film_genre[val($films['<<_cur_id>>,genre'])+',name']+'</td>'
		$_film_str +=	'<td>'+$films['<<_cur_id>>,price']+'</td>'
		$_film_str +=	'<td>'+iif($films['<<_cur_id>>,promo']=0 and (daystart - val($films['<<_cur_id>>,date']) <= 10),'<a href="exec:gs''zz_pornstudio_films'',''film_promo'',<<_cur_id>>,<<_actress_film_id>>">'+$films['<<_cur_id>>,promo']+'</a>',$films['<<_cur_id>>,promo'])+'</td>'
		$_film_str +=	'<td>'+(val($films['<<_cur_id>>,profit']) - val($films['<<_cur_id>>,price']) - val($films['<<_cur_id>>,promo']))+'</td>'
		$_film_str += '</tr>'
		i += 1
		jump 'loop_films'
	end
	gs 'zz_render','','','**<center><table class="film-table">' + $_film_str + '</table></center>'
	! test
	!$_studio_str = '<div class="film-info">Прибыль за текущий месяц: <b><<studio[''money_month'']>></b>р.'
	!$_studio_str += '**Прибыль за прошлый месяц: <b><<studio[''money_last_month'']>></b>р.'
	!$_studio_str += '**Баланс студии: <b><<studio[''money'']>></b>р.</div>'
	!gs 'zz_render','','',$_studio_str
	!---
	killvar '$_film_str'
	killvar '_cur_id'
	killvar '_actress_film_id'
end
! реклама фильма
! args[1] - id фильма
! args[2] - id актриссы
if $args[0] = 'film_promo':
	_promo_price = input('Введите сумму, на которую хотите прорекламировать фильм (0-10000):')
	if _promo_price <= 0 or _promo_price > 10000:
		killvar '_promo_price'
		exit
	else
		$films['<<args[1]>>,promo'] = _promo_price
		killvar '_promo_price'
		if args[2] >= 0:
			gt 'zz_pornstudio_actress','actress_info',args[2]
		else
			gt 'zz_pornstudio_films','films'
		end
	end
end
! суточное обновление рейтингов фильмов
if $args[0] = 'update_films_info':
	i = 0
	_film_count = arrsize('$films')/11
	_film_view = 0
	:loop_films
	if i < _film_count:
		! древность фильма
		_film_old = daystart - val($films['<<i>>,date'])
		if _film_old > 100: _film_old = 100
		_film_quality = val($films['<<i>>,quality'])
		_film_actress = 100
		_film_genre = rand(($films['<<i>>,genre']+1)*10 - 5,($films['<<i>>,genre']+1)*10 + 5)
		_film_promo = val($films['<<i>>,promo'])/(_film_old+11)
		_film_view = (_film_quality*25/10 + (100-_film_old)*35/10 + _film_genre*20/10 + _film_actress + studio['rating'] + _film_promo)/(40+_film_old)
		_film_view = _film_view * (100 - _film_old)/100 + iif(rand(0,10)=0,1,0)
		if _film_view < 0: _film_view = 0
		$films['<<i>>,profit'] += _film_view*50
		studio['money_month'] += _film_view*50
		$films['<<i>>,view'] += _film_view
		i += 1
		jump 'loop_films'
	end
	!---
	! переход на новый месяц - пересчитываем финансы
 	if day = 1:
		! платежи
		! 25% - крыше
		! 20% - налоги
		! 10% чистой прибыли за месяц - на счет ГГ
		! 10000 + 500 за каждый апдейт помещений
		studio['money_month'] -= iif(studio['money_month'] < 0,-1,1)*studio['money_month']*45/100 + 10000 + 500*(studio['room,0']+studio['room,1']+studio['room,2']+studio['room,3'])
		if studio['money_month'] > 0:
			karta += studio['money_month']/10
			studio['money_month'] -= studio['money_month']/10
		end
		studio['money_last_month'] = studio['money_month']
		studio['money'] += studio['money_month']
		studio['money_month'] = 0
	end
	!---
	killvar '_film_count'
	killvar '_film_view'
	killvar '_film_old'
	killvar '_film_quality'
	killvar '_film_actress'
	killvar '_film_genre'
	killvar '_film_promo'
	killvar '_film_view'
end
! расчет среднего рейтинга всех фильмов студии
if $args[0] = 'avg_rating':
	_films_avg = 0
	_films_count = arrsize('$films')/11
	if _films_count = 0:
		result = 0
	else
		i = 0
		:loop_avg_rating
		if i < _films_count:
			_films_avg += $films['<<i>>,rating']
			i += 1
			jump 'loop_avg_rating'
		end
		result = _films_avg / _films_count
		killvar '_films_avg'
		killvar '_films_count'
	end
end
! съемки фильма - добавление нового фильма в массив
! args[1] - жанр фильма
! args[2] - id актриссы #1
if $args[0] = 'add_film':
	_film_id = arrsize('$films')/11
	! снимаем с текущей прибыли деньги за фильм
	studio['money_month'] -= 4000 + args[1]*500
	! снимаем с баланса студии деньги за фильм
	studio['money'] -= 4000 + args[1]*500
	! приращиваем индекс в серии фильмов
	$film_genre['<<args[1]>>,index'] += 1
	! заносим инфо по фильму в досье актрисс
	$actress['<<args[2]>>,date'] = daystart
	$actress['<<args[2]>>,last_film'] = _film_id
	if args[1] = 1:
		$actress['0,date'] = daystart
		$actress['0,last_film'] = _film_id
	end
	! рассчитываем средный рейтинг актрисс, снявшихся в фильме
	if args[1] = 1:
		_film_actress_rating = ($actress['<<args[2]>>,rating'] + $actress['0,rating'])/2
	else
		_film_actress_rating = $actress['<<args[2]>>,rating']
	end
	! расчитываем качество фильма
	_film_quality = (studio['work_rating']*7 + _film_actress_rating*3)/10
	! расчитываем рейтинг фильма
	_film_rating = (_film_quality*5 + _film_actress_rating*3 + _studio['rating']*2)/10
	! заносим инфо в массив фильмов
	$films['<<_film_id>>,name'] = $film_genre['<<args[1]>>,filmname'] + ' #' + ($film_genre['<<args[1]>>,index'])
	$films['<<_film_id>>,date'] = daystart
	$films['<<_film_id>>,genre'] = args[1]
	$films['<<_film_id>>,rating'] = _film_rating
	$films['<<_film_id>>,actress'] = str(args[2]) + iif(args[1]=1,',0','')
	$films['<<_film_id>>,promo'] = 0
	$films['<<_film_id>>,profit'] = 0
	$films['<<_film_id>>,price'] = 4000 + args[1]*500
	$films['<<_film_id>>,view'] = 0
	$films['<<_film_id>>,quality'] = _film_quality
	$films['<<_film_id>>,date_str'] = func('zz_funcs','make_datetime',day,month,'.',year)
	!---
	killvar '_film_id'
	killvar '_film_actress_rating'
	killvar '_film_quality'
	killvar '_film_rating'
end
! выбор жанра и актрисс для фильма
! args[1] - жанр фильма
! args[2] - id актриссы #1
if $args[0] = 'select_film':
	*clr & cla
	act 'Закрыть': gt 'zz_pornstudio'
	_film_genre = args[1]
	_film_actress = args[2]
	! генерим список жанров для выбора
	i = 0
	$_film_genres = ''
	:loop_genres
	if i < 10:
		! для лесбосцен вторая актрисса всегда гг - проверяем доступность
		if i = 1 and (mesec > 0 or func('zz_pornstudio_actress','calc_relax',0) >= daystart): i += 1
		$_film_genres += '<li class="film-select-link'+iif(i=_film_genre,'-checked','')+'"><a href="exec:gt''zz_pornstudio_films'',''select_film'',<<i>>,-1">'+$film_genre['<<i>>,name']+'</a></li>'
		i += 1
		jump 'loop_genres'
	end
	! генерируем список актрисс, исходя из доступности и жанра фильма
	$_film_actress = ''
	! если лесбо - вторая актрисса всегда ГГ
	i = iif(_film_genre = 1,1,0)
	:loop_actress
	if i < arrsize('$actress')/8:
		if i = 0 and (mesec > 0 or func('zz_pornstudio_actress','calc_relax',0) >= daystart): i += 1
		if $actress['<<i>>,hired'] = 1 and $actress['<<i>>,retire'] = 0 and func('zz_pornstudio_actress','calc_relax',i) < daystart and $actress['<<i>>,genres'] >= _film_genre:
			$_film_actress += '<li class="film-select-link'+iif(i=_film_actress,'-checked','')+'"><a href="exec:gt''zz_pornstudio_films'',''select_film'',<<_film_genre>>,<<i>>">'+$actress['<<i>>,name']+'</a></li>'
		end
		i += 1
		jump 'loop_actress'
	end
	gs 'zz_render','','','<div class="film-select-container"><div class="film-select"><p>Выберите жанр фильма:</p><ul><<$_film_genres>></ul></div><div class="film-select"><p>Выберите актриссу:</p><ul><<$_film_actress>></ul></div></div>'
	if _film_genre >= 0 and _film_actress >= 0: gs 'zz_render','','','<div class="film-shooting"><a href="exec:gt''zz_pornstudio_films'',''shooting_film'',<<_film_genre>>,<<_film_actress>>">Снимать фильм</a></div>'
	killvar '_film_genre'
	killvar '_film_actress'
	killvar '$_film_genres'
	killvar '$_film_actress'
end
! процедура съемки порнофильма
! args[1] - жанр фильма
! args[2] - id актриссы #1
! args[3] - стадия съемок
if $args[0] = 'shooting_film':
	*clr & cla
	_film_genre = args[1]
	_film_actress = args[2]
	_stage = args[3]
	gs 'zz_render','','city/north/pornstudio/films/<<_film_genre>>/<<_film_actress>>/<<_stage>>.webm'
	act iif(_stage < 4,'...','Снято!'):
		if _stage < 4:
			gt 'zz_pornstudio_films','shooting_film',_film_genre,_film_actress,_stage+1
		else
			! добавляем фильм в массив и вносим изменения в досье актрисс
			gs 'zz_pornstudio_films','add_film',_film_genre,_film_actress
			studio['film_day'] = day
			minut += rand(180,240)
			killvar '_film_genre'
			killvar '_film_actress'
			killvar '_stage'
			gt 'zz_pornstudio'
		end
	end
end
! просмотр снятого фильма
! args[1] - id фильма
if $args[0] = 'film_view':
	*clr & cla
	_stage = args[2]
	if _stage = 0:
		_film_id = args[1]
		if $films['<<_film_id>>,genre'] = 1:
			_film_actress = val(func('zz_funcs','get_item_string',$films['<<_film_id>>,actress'],0))
		else
			_film_actress = val($films['<<_film_id>>,actress'])
		end
	end
	gs 'zz_render','','city/north/pornstudio/films/'+$films['<<_film_id>>,genre']+'/<<_film_actress>>/<<_stage>>.webm'
	act iif(_stage < 4,'...','Закрыть'):
		if _stage < 4:
			gt 'zz_pornstudio_films','film_view',_film_id,_stage+1
		else
			killvar '_film_id'
			killvar '_film_actress'
			killvar '_stage'
			gt 'zz_pornstudio'
		end
	end
end