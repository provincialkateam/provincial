$metka = $ARGS[0]
$loc = $CURLOC
'<center><b><font color = maroon>Комната</font></b></center>'
'<center><img src="images/pic/saunaroom.jpg"></center>'
'В комнате едва убирается <a href="exec: & GT ''bed'',''start''">кровать</a> и <a href="exec:GT ''loker'',''start''">шкаф</a>.'
'На стене висит <a href="exec:GT ''mirror'',''start''">зеркало</a>'
if money > 0 and workDolg > 0:workDolg -= money & money = 0
if workDolg > 0:'Ваш долг составляет <<workDolg>> рублей'
act 'Выйти в сауну': gt'saunawork'
if workDolg > 0:
	act 'Есть в долг(5 мин)':
		cla
		*clr
		minut += 5
		workDolg += 50
		health += 30
		manna += 20
		energy = 20
		water = 20
		body['day_weight'] += 1
		cumlip = 0
		gs 'stat'
		'<center><img src="images/pics/food.jpg"></center>'
		'Вы попили чаю с печеньем, очень сладко и вредно для фигуры, но так приятно.'
		act 'Встать из за стола':gt $curloc
	end
	act 'Взять в долг косметику':
		workDolg += 1000
		kosmetica += 25
		gt $curloc
	end
end
if water < 20:
	act 'Пить':
		cla
		minut += 5
		gs 'zz_kitchen_acts', 'drink', 'water'
		act 'Встать из за стола': gt $curloc
	end
end