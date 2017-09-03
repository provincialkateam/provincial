if $ARGS[0] = '' or $ARGS[0] = 'start':
	$loc = $curloc
	$metka = $args[0]
	$sexloc = $curloc
	*clr & cla
	if university['entrance_exam'] = year: university['abiturient'] = 0
	minut += 5
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Университет', 'city/center/university/hall.jpg','Холл университета города Энска.**Недалеко от проходной находятся <a href="exec: minut += 5 & gt ''university'',''toilet''">туалеты</a> и вход в университестскую '+iif(university['student'] > 0 and hour >= 9 and hour <= 20 and (month <= 6 or month >= 9),'<a href="exec: minut += 5 & gt ''university'',''library''">библиотеку</a>','библиотеку')+'.**Пройдя по коридору можно попасть в '+iif(university['student'] > 0,'<a href="exec: minut += 5 & gt ''university'',''deanery''">деканат</a>','деканат')+' и <a href="exec: minut += 5 & gt ''university'',''accounting''">бухгалтерию</a>.'
	if university['student'] = 0: gs 'zz_render', '', '','Экзамены на зачисление в университет проходят в августе. Итог поступления зависит от вашего интеллекта и успеваемости в школе. Длительность обучения - два года.'
	if university['abiturient'] = 0 and university['student'] = 0: gs 'zz_render', '', '','Подготовительные курсы в летнее время - стоимость 15 тысяч рублей. Оплата в бухгалтерии университета.'
	if university['abiturient'] = 1: gs 'zz_render', '', '','Вы абитуриент.**Подготовительные занятия проходят с 8.00 до 21.00, по будним дням.'
	if university['student'] > 0:
		gs 'zz_render', '', '','Вы учитесь в <<university[''semester'']>> семестре <<university[''course'']>> курса. Лекции начинаются с 9 часов.**Библиотека работает с 9.00 до 21.00, без выходных. С июля по сентябрь библиотека закрывается на каникулы.**'+iif(university['student'] = 1 and university['payment'] ! university['semester'],'**<b><font color = red>Вам нужно оплатить учёбу за семестр в бухгалтерии ВУЗа</font></b>','')
		if university['vacation'] > 0: gs 'zz_render', '', '','Сейчас в университете <<$holiday>>'
	end
	!вступительный экзамен
	if month = 8 and university['student'] = 0 and university['diploma'] = 0 and school['certificate'] > 0 and university['entrance_exam'] ! year:
		gs 'zz_render', '', '','<b>Вы можете попытаться сдать вступительный экзамен. Даётся одна попытка в год.</b>'
		act '<b>Сдавать вступительный экзамен</b>': gt'university_events','entrance_exam'
	end
	!занятия и экзамены
	if week < 6 and hour >= 8 and hour <= 15:
		if university['vacation'] = 0 and (university['student'] = 2 or university['student'] = 1 and university['payment'] = university['semester']): act '<b>Идти на лекции</b>': gt'university_events','lecture',iif(hour < 12,1,2)
		if university['vacation'] = 2 and university['exam'] < 1 or university['vacation'] = 3 and university['exam'] < 2 or university['vacation'] = 5 and university['exam'] < 4 or university['vacation'] = 6 and university['exam'] < 5: act '<b>Идти на экзамены</b>': gt'university_events','exam'
		if university['vacation'] = 3 and university['exam'] = 2 and university['course_work'] >= 100: act '<b>Сдать курсовую работу</b>': gt'university_events','course_work_end'
		if university['vacation'] = 6 and university['exam'] = 5 and university['graduate_work'] >= 100: act '<b>Защитить диплом</b>': gt'university_events','graduate_work_end'
	end
	!подготовительные курсы
	if university['abiturient'] = 1 and month > 5 and month < 9 and hour < 21 and week < 6 and classes_day ! day: act 'Заниматься на подготовительных курсах': gt'university_events','preparatory_classes'
	act 'Выйти': minut += 5 & gt'down'
end
!бухгалтерия
if $ARGS[0] = 'accounting':
	*clr & cla
	minut += 5
	gs 'zz_render', 'Бухгалтерия', 'city/center/university/accounting.jpg','Бухгалтерия университета. Тут можно оплатить учёбу или курсы.'
	if university['student'] = 1 and money >= 50000 and university['payment'] ! university['semester']: act 'Оплатить обучение за семестр (50 тыс.руб)': gt'university_events','payment_student'
	if university['student'] = 0 and university['abiturient'] = 0 and money >= 15000 and month > 5 and month < 9 and diplom = 0 and school['certificate'] > 0: act 'Оплатить подготовительные курсы (15 тыс.руб)': gt'university_events','payment_abiturient'
	act 'Выйти из кабинета': gt'university','start'
end
!деканат
if $ARGS[0] = 'deanery':
	*clr & cla
	gs'stat'
	gs 'zz_render', 'Деканат', 'city/center/university/deanery.jpg','Деканат университета.'
	act 'Выйти из кабинета': gt'university','start'
end
!туалет
if $args[0] = 'toilet':
	*clr & cla
	$loc = $curloc
	$metka = $args[0]
	minut += 1
	dildohand = 0
	protect = 0
	mastrOnce = 0
	gs'stat'
	gs 'zz_render','Туалет','city/center/university/toilet/toilet.jpg','Университетский туалет.'
	act 'Зайти в кабинку': gt'university_events','toilet_cubicle'
	gs 'zz_toilet', 'actions'
	act 'Выйти': gt'university','start'
end
!библиотека
if $args[0] = 'library':
	$loc = $curloc
	$metka = $args[0]
	*clr & cla
	gs 'zz_render','Туалет','city/center/university/library.jpg','Университетская библиотека. Здесь можно найти практически любую литературу, необходимую для написания курсовой или дипломной работы.'
	if hour <= 20:
		gs 'library_acts'
	else
		gs 'zz_render', '', '', 'Библиотека закрывается.'
	end
	act 'Выйти из библиотеки': gt'university','start'
end