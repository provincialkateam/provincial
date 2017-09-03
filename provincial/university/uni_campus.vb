$loc = $curloc
if $args[0] = '':
	! сюда всегда переходим с города, это разводящяя локация
	*clr & cla
	$control_point = $curloc
	gs 'stat'
	gs 'time'
	gs 'zz_render','','','Типичный университетский городок бла-бла-бла'
	! переходы
	act 'Общежитие': minut += 5 & gt 'uni_dorm'
	if hour >= 7 and hour <= 20:
		act 'Учебный корпус':
			exit
		end
	end
	! стадион открыт только в светлую часть дня
	if func('zz_weather','is_day') = 1:
		act 'Стадион': minut += rand(5,10) & gt 'uni_campus','stadium'
	end
	if hour >= 10 and hour <= 20: act 'Кафе "Студент"': minut += rand(5,10) & gt 'uni_campus','caffe'
	act '<b>В город<b>': minut += rand(5,10) & gt 'down'
	exit
end
if $args[0] = 'stadium':
	*clr & cla
	gs 'zz_render','','','Небольшой уютный стадион посреди студенческого городка.'
	act '<b>В студгородок</b>': minut += rand(5,10) & gt 'uni_campus'
	if func('zz_weather','is_day') = 0: exit
	if func('zz_clothing','get_group') = 3 and running_day ! day and sick < 1:
		act 'Бегать (1 час)':
			*clr & cla
			gs 'zz_common','crossing'
			gs 'zz_render','','','На протяжении часа вы бегали на стадионе.'
			act '...': gt 'uni_campus','stadium'
		end
	end
	exit
end
if $args[0] = 'caffe':
	*clr & cla
	act '<b>В студгородок</b>': minut += rand(5,10) & gt 'uni_campus'
	if hour < 10 or hour > 20: exit
	gs 'zz_render','','Кафе "Студент"','Удачно расположенная кафешка вечно полна студентов - кто перекусить, кто взбодриться чашечкой кофе, а кто просто поболтать.'
	!gs 'zz_common','coffee'
	exit
end