$loc = $curloc
if $args[0] = '':
	! сюда всегда переходим с города, это разводящяя локация
	*clr & cla
	$control_point = $curloc
	$metka = $args[0]
	gs 'stat'
	gs 'time'
	gs 'zz_render','','city/center/university/campus/campus'+iif(func('zz_weather','is_day')=0,'_night',''),'Университетский студгородок, или как нынче модно называть по-импортному - "кампус", а на деле - несколько учебных корпусов и здание студенческого общежития, образующие замкнутый "микрорайон" в центре города. Здесь есть собственный небольшой стадион и кафе-столовка "Gaudeamus", которую студиози зовут "Гад", открыта с 10.00 до 21.00'
	! переходы
	act '<b>В город<b>': minut += rand(5,10) & gt 'center'
	if hour >= 7 and hour <= 20:
		act 'Учебный корпус': gt 'university'
	end
	if hour >= 10 and hour <= 20: act 'Кафе "Gaudeamus"': minut += rand(5,10) & gt 'uni_campus','caffe'
	if university['student'] > 0:
		act 'Общежитие': minut += 5 & gt 'uni_dorm'
		! стадион открыт только в светлую часть дня
		if func('zz_weather','is_day') = 1: act 'Стадион': minut += rand(5,10) & gt 'uni_campus','stadium'
	end
	exit
end
if $args[0] = 'stadium':
	*clr & cla
	$metka = $args[0]
	gs 'zz_render','','','Небольшой уютный стадион промеж корпусов студгородка.'
	act '<b>В студгородок</b>': minut += rand(5,10) & gt 'uni_campus'
	if func('zz_weather','is_day') = 0: exit
	if func('zz_clothing2','get_group') = 1 and workout < 3 and sick < 1:
		act 'Бегать':
			*clr & cla
			gs 'zz_common','crossing'
			act '...': gt 'uni_campus','stadium'
		end
	end
	exit
end
if $args[0] = 'caffe':
	*clr & cla
	$metka = $args[0]
	act '<b>В студгородок</b>': minut += rand(5,10) & gt 'uni_campus'
	if hour < 10 or hour > 20: exit
	gs 'zz_render','Кафе "Gaudeamus"','city/center/university/campus/caffe','Удачно расположенная кафешка вечно полна студентов - кто перекусить, кто взбодриться чашечкой кофе, а кто просто поболтать.'
	if money >= 150:
		act 'Поесть - 150 руб':
				*clr & cla
				money -= 150
				gs 'zz_kitchen_acts', 'eat'
				gs 'zz_kitchen_acts', 'drink', 'tea'
				gs 'stat'
				act 'Встать из за стола': minut += 20 & gt'uni_campus','caffe'
		end
	end
	!gs 'zz_common','coffee'
	exit
end