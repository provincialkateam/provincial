! список текущих работниц студии
if $args[0] = 'actress_list':
	*clr & cla
	act '<b>Закрыть</b>': gt 'zz_pornstudio'
	act 'Кастинг': gt 'zz_pornstudio_actress','casting'
	act 'Фильмография студии': gt 'zz_pornstudio_films','films'
	_actress_count = arrsize('$actress')/8
	_cell_count = 0
	$_actress_str = ''
	for i = 0 to _actress_count - 1:
		if $actress['<<i>>,retire'] = 0 and $actress['<<i>>,hired'] = 1:
			if _cell_count = 0: $_actress_str += '<tr>'
			$_actress_str += '<td>'+func('zz_pornstudio_actress','actress_box',i)+'</td>'
			if _cell_count = 3:
				_cell_count = 0
				$_actress_str += '</tr>'
			else
				_cell_count += 1
			end
		end
	end
	! если надо - добиваем таблицу пустыми ячейками
	if _cell_count > 0:
		for i = _cell_count to 3:
			$_actress_str += '<td></td>'
		end
		$_actress_str += '</tr>'
	end
	gs 'zz_render','','','<center><table border=0>'+$_actress_str+'</table></center>'
	killvar '$_actress_str'
	killvar '_cell_count'
end
! инфо по актриссе
! args[1] - id актриссы
if $args[0] = 'actress_info':
	_actress_info_id = args[1]
	*clr & cla
	act '<b>Закрыть</b>': gt 'zz_pornstudio'
	act 'Список актрисс': gt 'zz_pornstudio_actress','actress_list'
	act 'Фильмография студии': gt 'zz_pornstudio_films','films'
	! лицо актриссы
	gs 'zz_render','','','<center><table border=0>'+func('zz_pornstudio_actress','actress_box',_actress_info_id)+'</table></center>'
	! инфо
	$_actress_str = 'Доступные жанры:**' + func('zz_pornstudio_actress','actress_genre',val($actress['<<_actress_info_id>>,genres'])) + '**'
	if $actress['<<_actress_info_id>>,retire'] = 0:
		_next_film_date = func('zz_pornstudio_actress','calc_relax',_actress_info_id)
		if _next_film_date >= daystart:
			$_actress_str += $actress['<<_actress_info_id>>,name'] + ' будет доступна для съемок через ' + (_next_film_date - daystart + 1) + ' дн.'
		else
			$_actress_str += $actress['<<_actress_info_id>>,name'] + ' доступна для съемок.'
		end
	else
		$_actress_str += $actress['<<_actress_info_id>>,name'] + ' больше у вас не снимается.'
	end
	gs 'zz_render','','','<div class="film-info">'+$_actress_str+'</div>'
	killvar '$_actress_str'
	killvar '_next_film_date'
	! фильмография
	gs 'zz_pornstudio_films','film_list',_actress_info_id
	killvar '_actress_info_id'
end
! обертка для актрисс
! args[1] - id актриссы
if $args[0] = 'actress_box':
	_actress_id = args[1]
	$result = '<div class="box actress">'
	! фотка актриссы
	$result += '<img src="images/city/north/pornstudio/actress/<<_actress_id>>.jpg">'
	! имя актриссы, оно же - линк на фильмографию
	$result += '<a href="exec:gt''zz_pornstudio_actress'',''actress_info'',<<_actress_id>>">'+$actress['<<_actress_id>>,name']+'</a>'
	! рейтинг
	$result += '<div><img src="images/city/north/pornstudio/rating/'+$actress['<<_actress_id>>,rating']/10+'.png"></div>'
	$result += '</div>'
	killvar '_actress_id'
end
! расчет времени доступности актриссы в зависимости от условий в студии
! args[1] - id актриссы
if $args[0] = 'calc_relax':
	_actress_last_id = args[1]
	! если last_film_id = -1 - актрисса еще не снималась и значит доступна
	_last_film_id = $actress['<<_actress_last_id>>,last_film']
	if _last_film_id < 0:
		result = daystart - 1
	else
		! если уже снималась
		! получаем жанр фильма по его id
		_last_film_genre = $films['<<_last_film_id>>,genre']
		! рассчитываем время отдыха в зависимости от условий в студии
		_last_film_relax = (1 + _last_film_genre)*2 - studio['relax_area']*3/2
		! между съемками должно быть минимум 2 дня, но по формуле возможно и меньше, проверяем
		if _last_film_relax < 2: _last_film_relax = 2
		! получаем дату последней съемки актриссы и добавляем дни отдыха
		result = val($actress['<<_actress_last_id>>,date']) + _last_film_relax
		! очистка переменных
		killvar '_actress_last_id'
		killvar '_last_film_id'
		killvar '_last_film_genre'
		killvar '_last_film_relax'
	end
end
! получаем имена актрисс, снимавшихся в фильме
! $args[1] - массив id актрисс
if $args[0] = 'get_actress_name':
	$_actress_arr = $args[1]
	! получаем длину массива - число актрисс
	_actress_count = func('zz_funcs','get_count',$_actress_arr)
	$_actress_names = ''
	_actress_i = 0
	:loop_actress_names
	if _actress_i < _actress_count:
		_actress_num = val(func('zz_funcs','get_item_string',$_actress_arr,_actress_i))
		if $actress['<<_actress_num>>,retire'] = 0:
			$_actress_names += '<a href="exec:gt''zz_pornstudio_actress'',''actress_info'',<<_actress_num>>">' + $actress['<<_actress_num>>,name'] + '</a>, '
		else
			$_actress_names += $actress['<<_actress_num>>,name'] + ', '
		end
		_actress_i += 1
		jump 'loop_actress_names'
	end
	$result = mid($_actress_names,1,len($_actress_names)-2)
	killvar '$_actress_arr'
	killvar '_actress_count'
	killvar '_actress_i'
	killvar '$_actress_names'
	killvar '_actress_num'
end
! список жанров для актрисс
! args[1] - максимальный доступный жанр
if $args[0] = 'actress_genre':
	_actress_genre_i = 0
	$result = ''
	:loop_genres
		$result += '<span class="film-tag">' + $film_genre['<<_actress_genre_i>>,name'] + '</span>'
		_actress_genre_i += 1
		if _actress_genre_i <= args[1]: jump 'loop_genres'
	!---
	killvar '_actress_genre_i'
end
! наем актриссы
! args[1] - id актриссы
if $args[0] = 'actress_hire':
	$actress['<<args[1]>>,hired'] = 1
	! снимаем с текущей прибыли бонус за подписание
	studio['money_month'] -= 10000
	! снимаем с баланса студии бонус за подписание
	studio['money'] -= 10000
	gt 'zz_pornstudio_actress','casting',args[1]
end
! расчет среднего рейтинга всех актрисс студии
if $args[0] = 'avg_rating':
	_actress_avg = 0
	_actress_count = arrsize('$actress')/8
	if _actress_count = 0:
		result = 0
	else
		i = 0
		:loop_avg_rating
		if i < _actress_count:
			_actress_avg += $actress['<<i>>,rating']
			i += 1
			jump 'loop_avg_rating'
		end
		result = _actress_avg / _actress_count
		killvar '_actress_avg'
		killvar '_actress_count'
	end
end
! пересчет статов актрисс
if $args[0] = 'update_actress_info':
	i = 0
	:loop_actress_rating
	if i < arrsize('$actress')/8:
		j = 0
		_actress_rating = 0
		_actress_films_count = 0
		_films_count = arrsize('films')/11
		:loop_films_rating
		if j < _films_count:
			if func('zz_funcs','get_item_id',$films['<<j>>,actress'],str(i)) > 0:
				_actress_rating += $films['<<j>>,rating']
				_actress_films_count += 1
			end
			j += 1
			jump 'loop_films_rating'
		end
		if _actress_films_count > 0:
			$actress['<<i>>,rating'] = _actress_rating / _actress_films_count
		else
			$actress['<<i>>,rating'] = 0
		end
		i += 1
		jump 'loop_actress_rating'
	end
	killvar '_actress_rating'
	killvar '_actress_films_count'
	killvar '_films_count'
end
! кастинг
if $args[0] = 'casting':
	*clr & cla
	act '<b>Закрыть</b>': killvar '_casting_id' &  gt 'zz_pornstudio_actress','actress_list'
	if arrsize('$actress')/8 <= 1: exit
	_casting_id = args[1]
	if _casting_id < 1: _casting_id = 1
	if _casting_id >= arrsize('$actress')/8: _casting_id = 1
	gs 'zz_render','','city/north/pornstudio/actress/casting/'+_casting_id
	$_casting_prev = '<a href="exec:gt''zz_pornstudio_actress'',''casting'',<<_casting_id-1>>">Предыдущая</a>'
	$_casting_next = '<a href="exec:gt''zz_pornstudio_actress'',''casting'',<<_casting_id+1>>">Следующая</a>'
	$_casting_hire = ' <a href="exec:gt''zz_pornstudio_actress'',''actress_hire'',<<_casting_id>>">Нанять</a> '
	if $actress['<<_casting_id>>,hired'] = 1:
		gs 'zz_render','','','<div class="film-casting">' + $_casting_prev + ' <span>Актрисса уже нанята!</span> ' + $_casting_next + '</div>'
	elseif $actress['<<_casting_id>>,retire'] = 1:
		gs 'zz_render','','','<div class="film-casting">' + $_casting_prev + ' <span>Актрисса уволена!</span> ' + $_casting_next + '</div>'
	else
		gs 'zz_render','','','<div class="film-casting">' + $_casting_prev + $_casting_hire + $_casting_next + '</div>'
	end
end