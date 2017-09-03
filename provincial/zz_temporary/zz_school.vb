﻿! массив school
! school['lesson_count'] - количество посещенных сегодня уроков 0-6
! school['lesson'] - текущий урок: 1-6, 10 - для всех до перемены, 20 - поход на все уроки сразу
! school['absent'] - прогулы 0-30
! school['certificate'] - аттестат 0-10
! school['block'] - блокировка школы 0/1
! school['homework'] - домашнее задание 0/1
! school['progress'] - успеваемость 0-100
! school['intellect'] - бонус прироста интеллекта 0-5
! school['vacation'] - каникулы 0-5
! school['certificate_gift'] - подарок от матери после окончания школы 0/1
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	frost = 0
	$loc = $curloc
	$metka = $args[0]
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Школьный коридор','pavlovo/school/hall',func('zz_school','make_shedule') + func('zz_school_str',0)
	! ---
	act '<center><font color=maroon><b>Уйти</b></font></center>': minut += 1 & gt 'gschool'
	! ---
	!if lariskaQwestDay < daystart and zverRageQW = 2:
	!	if $npc['18,qwZverevaSlut'] = 0:
	!	elseif $npc['18,qwZverevaSlut'] = 1:
	!		$npc['18,qwZverevaSlut'] = 2
	!	end
	!end
	! на всякий читовый случай обнуляем количество посещенных сегодня уроков
	if hour < 9: school['lesson_count'] = 0
	if hour < 18:
		if hour < 17: gs 'zz_funcs','waiting'
		! большая перемена
		if (hour = 11 and minut > 45) or (hour = 12 and minut < 15):
			! ---
			if $npc['14,qwKatya_day'] ! day:
				! Катя показывает отсутствие трусиков
				if $npc['14,qwKatya'] = 60 and rand(0,5) = 0: gt 'mey_katya_events','school_no_panty'
				! серьезный разговор с Катей
				if $npc['14,qwKatya'] = 82: gt 'mey_katya_events','hub_talk'
				! Катя говорит, что уезжает в сити
				if $npc['14,qwKatya'] = 95 and $npc['14,hub_talk_day'] <= daystart: gt 'mey_katya_events','after_talk'
			end
			! ---
			! Иван помогает отбить Соню
			if $npc['25,qwSonya'] = 41 and $npc['25,qwSonya_day'] ! day:
				act 'Идти с Иваном по Соню': gt 'sonya','ivan_help'
			end
			! помощь ТМ с Соней
			if $npc['25,qwSonya'] = 46 and $npc['25,qwSonya_day'] ! day: gt 'sonya','tamara_help'
			! проверка оплаты и вывод сообщения
			if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] < 255 and $npc['25,qwSonya_day'] ! day: gs 'sonya','check_payment'
			! ---
			! секс с Царевым на большой перемене - начало до 12 часов и не в среду
			if $npc['26,qwMain'] >= 30 and $npc['26,qwMain'] < 40 and hour = 11 and week ! 3 and $npc['26,qwMain_day'] ! day: act 'Идти к Анатолию Евгеньевичу': gt 'tsarev_events','goto_tsarev_office'
			! класс доступен только на большой перемене
			if school_minikcor_day ! day:
				gt 'zz_school','minik_corr'
			end
			gs 'zz_render','','',func('zz_school_str',1)
			act 'В класс': minut += 1 & gt 'zz_school','classroom'
		end
		if hour >= 9: act 'Идти в столовую': gt 'zz_school','canteen'
		act 'Идти в туалет': gt 'gschool_tualete'
		if $npc['26,qwMain'] >= 21 and $npc['26,qwMain'] < 40 and (hour = 15 or hour = 16) and $npc['26,qwMain_day'] ! day and week mod 2 > 0:
			act 'Идти на занятия к Анатолию Евгеньевичу': gt 'tsarev_events','goto_tsarev_office'
		end
		gs 'zz_school', 'gt_lesson'
	end
end
!проверка миника в корридоре
if $args[0] = 'minik_corr':
	*clr & cla
	gs 'zz_school','mini_break_cor'
	school_minikcor_day = day
	act '...': gt 'zz_school'
end
! класс во время большой перемены
if $args[0] = 'classroom':
	*clr & cla
	$metka = $args[0]
	gs 'stat'
	! автозапуск ивента с Соней
	if $npc['25,qwSonya'] = 56 or $npc['25,qwSonya'] = 57: gt 'sonya','talk_about_payment'
	!--
	if school_minik_day ! day:
		*clr & cla
		gs 'zz_school','mini_break_class'
		school_minik_day = day
	end
	gs 'zz_render','','',func('zz_school_str',2)
	act 'В коридор': gt 'zz_school'
	gs 'zz_school', 'gt_lesson'
end
! кнопка 'на урок'
if $args[0] = 'gt_lesson':
	! уроки
	if hour >= 8 and hour < 15:
		! можно ходить на каждый по отдельности
		if (hour > 8 and hour < 12 and minut <= 5) or (hour >= 12 and minut <= 20):
			act 'Идти на урок': gt 'zz_school', 'lessons', hour - 8
		elseif hour = 8 or (hour < 12 and minut >= 45):
			act 'Идти на урок': gt 'zz_school', 'lessons', iif(hour - 7 < 1, 1, hour - 7)
		else
			gs 'zz_funcs','message','images/common/down.png',func('zz_school_str',3)
		end
		! на все уроки до большой перемены
		if hour < 11: act 'Идти на все уроки до большой перемены': gt 'zz_school','lessons',10
		! на все уроки сразу
		act 'Идти на все уроки': gt 'zz_school', 'lessons', 20
	end
end
! делаем табличку-расписание
if $args[0] = 'make_shedule':
	$_shedule[0] = 'Время,ПН,ВТ,СР,ЧТ,ПТ'
	$_shedule[1] = '09.00 - 09.45,Математика,География,Информатика,Английский язык,Физика'
	$_shedule[2] = '10.00 - 10.45,Биология,Математика,Русский язык,История,География'
	$_shedule[3] = '11.00 - 11.45,Химия,Английский язык,Математика,Химия,Литература'
	$_shedule[4] = '12.15 - 13.00,Русский язык,Физика,Литература,Математика,Информатика'
	$_shedule[5] = '13.15 - 14.00,Информатика,История,Биология,Обществознание,Математика'
	$_shedule[6] = '14.15 - 15.00,Литература,Физкультура,ОБЖ,Физкультура,Русский язык'
	$_str = '<center><font size=-1><table cellpadding=0 cellspacing=1 align=center width=800>'
	i = 0
	:loop_lessons
	$_str += func('zz_funcs','make_table_row',$_shedule[i],iif(i=0,'#bbee77',iif(hour=8+i,'#eef5c7',iif(i mod 2 = 0,'#f3f4ee','#ffffff'))),iif(i=0,1,0),week,iif(i>0,iif(hour=8+i,'#d7e587','#eef5c7'),''))
	i += 1
	if i <= 6: jump 'loop_lessons'
	$_str += '</table></font></center>'
	$result = $_str
	killvar '$_str'
	killvar '$_shedule'
end
! уроки - вход
! lesson - текущий урок
! lesson_count - количество уроков в день, на которых была ГГ
if $args[0] = 'lessons':
	*clr & cla
	! если не сделана домашка - штраф к успеваемости
	if school['homework_check'] ! day: school['progress'] += iif(school['homework'] = 1,-1,1)
	school['homework_check'] = day
	school['lesson'] = args[1]
	if school['lesson'] = 20:
		! на все уроки сразу
		! получаем текущий урок
		if hour < 12:
			school['lesson'] = hour - iif(minut <= 5,9,8)
		else
			school['lesson'] = hour - 9
		end
		school['lesson_count'] += 6 - school['lesson']
		minut += 15*60 - (hour*60 + minut)
		gs 'zz_render','','pavlovo/school/mini/lesson',func('zz_school_str',4)
	elseif school['lesson'] = 10:
		! на все уроки до перемены
		school['lesson'] = hour - iif(minut <= 5,9,8)
		school['lesson_count'] += 3 - school['lesson']
		minut += (11*60 + 45) - (hour*60 + minut)
		gs 'zz_render','','pavlovo/school/mini/lesson',func('zz_school_str',4)
	else
		! на каждый по отдельности
		school['lesson_count'] += 1
		minut += iif(hour < 12,60,0) + iif(school['lesson'] <= 3,45,60) - minut
		if (week = 2 or week = 4) and school['lesson'] = 6:
			! физкультура
			if rand(0,10) < 2:
				gs 'zz_school','mini_phys'
			else
				gs 'zz_render','','pavlovo/school/mini/phys',func('zz_school_str',5)
			end
			if week = 4 and razradbeg <= 1: gs 'zz_render','','',func('zz_school_str',11+razradbeg)
			! воровство ключей по ветке учителя Царева
			if $npc['26,qwMain'] = 54:
				act 'Отпроситься пораньше': gt 'tsarev_events','stealing_keys_init'
				exit
			end
		elseif week = school['lesson']:
			! математика
			gt 'tsarev_events','math'
		else
			if rand(0,10) < 4:
				if $npc['14,qwKatya'] = 65 and $npc['14,qwKatya_day'] ! day:
					gs 'mey_katya_events','school_selfplay'
				else
					gs 'zz_school','mini_lessons'
				end
			else
				gs 'zz_render','','pavlovo/school/mini/lesson',func('zz_school_str',4)
			end
		end
	end
	gs 'stat'
	act iif(school['lesson'] < 6,'<b>На перемену</b>','<b>Уроки закончились!</b>'): school['homework'] = 1 & minut += 1 & gt 'zz_school'
end
! суточный пересчет статов
if $args[0] = 'recalc_stats':
	if school['certificate'] = 0 and school['vacation'] = 0 and week <= 5:
		if school['lesson_count'] >= 5:
			! успеваемость - прирост
			school['progress'] += 1
			! прирост к бонусу интеллекта
			school['intellect'] += 1
		end
		! успеваемость - суточное падение
		school['progress'] -= 1
		! пересчет прогулов
		school['absent'] += 6 - school['lesson_count']
		school['lesson_count'] = 0
	end
	! бонус к интеллекту
	if school['intellect'] >= 5:
		intel += 1
		school['intellect'] = 0
	end
	if school['intellect'] < 0:
		intel -= 1
		school['intellect'] = 0
	end
end
! каникулы
if $args[0] = 'vacation_status':
	school['vacation'] = 0
	$holiday = ''
	if school['certificate'] = 0 and school['block'] < 10:
		school['vacation'] = 0
		if month = 8 and day > 31:
			exit
		elseif (month = 10 and day >= 27) or (month = 11 and day <= 4):
			$holiday = 'Осенние каникулы (27.10-04.11)' & school['vacation'] = 1
		elseif (month = 12 and day >= 29) or (month = 1 and day <= 13):
			$holiday = 'Зимние каникулы (29.12-13.01)' & school['vacation'] = 2
		elseif month = 3 and day >= 25 and day <= 31:
			$holiday = 'Весенние каникулы (25.03-31.03)' & school['vacation'] = 3
		elseif (month = 5 and day >= 25) or month = 6 or month = 7 or month = 8:
			$holiday = 'Летние каникулы (25.05-31.08)' & school['vacation'] = 4
		elseif month = 1 and day = 1:
			$holiday = 'Новый год!' & school['vacation'] = 5
		end
	end
end
! статус домашки
if $args[0] = 'homework_status':
	if hour >= 9 and hour < 15 and school['certificate'] = 0 and school['block'] < 3 and school['vacation'] = 0: school['homework'] = 1
end
! домашка
if $args[0] = 'homework':
	if (hour < 9 or hour >= 15) and school['certificate'] = 0 and school['block'] < 3 and school['vacation'] = 0 and school['homework'] = 1:
		act 'Учить уроки':
			*clr & cla
			! brother_help_qw
			if $loc = 'bedrPar' and hour = 21 and week < 5 and ($npc['39,qwPornoFootball'] >= 16 or $npc['39,sex'] > 4) and $npc['39,relation'] > 80 and func('zz_clothing','is_skirt') = 1 and brother_help_qw < 4 and brother_help_qw_day ! day: gt 'brother_events','brother_help_qw'
			minut += 30 + (100 - intel)/2
			school['homework'] = 0
			gs 'stat'
			gs 'zz_render','','images/pic/homework.jpg',func('zz_school_str',6)
			act 'Встать из за стола': gt $loc, $metka
		end
	end
end
! поход в столовку
if $args[0] = 'canteen':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	if (hour >= 9 and hour < 12 and minut > 45) or (hour >= 12 and hour < 16 and minut < 15):
		gs 'zz_render', '', 'pavlovo/school/canteen.jpg', func('zz_school_str',7)
		if (hour = 11 and minut > 45) or (hour = 12 and minut < 15): gs 'zz_render','','',func('zz_school_str',8) + func('npc_editor','make_npc_group',0,1,1)
	else
		gs 'zz_render','','pavlovo/school/canteen_empty.jpg',func('zz_school_str',9)
	end
	act 'Выйти': gt 'zz_school'
	act 'Купить еду (200 руб.)':
		if money < 200:
			gs 'zz_render','','',func('zz_school_str',10)
			exit
		end
		*clr & cla
		money -= 200
		gs 'zz_kitchen_acts','eat','lunch'
		gs 'zz_kitchen_acts','drink','tea'
		gs 'stat'
		act 'Выйти': gt 'zz_school'
	end
end
! подслушивание болтовни
if $args[0] = 'gossip':
	cla
	if $npc['25,qwSonya'] >= 5 and $npc['25,qwSonya'] < 15 and rand(0,10) = 1:
		gs 'zz_render','','',func('zz_school_str',rand(13,15))
	else
		if rand(0,3) = 1:
			gs 'zz_render','','',func('zz_school_str',iif(func('zz_reputation','get') > 0,18+func('zz_reputation','get'),rand(16,18)))
		else
			gs 'zz_render','','',func('zz_school_str',25)
		end
	end
	act 'Ждать конца урока': minut += 1 & gt 'zz_school'
end
! школьные мини-ивенты
if $args[0] = 'mini_lessons':
	$_mini[0] = 'Класс идет вразнос: девчонки поспорили, и проигравшая показывает одноклассникам голую задницу. Ваши товарищи оглушительно ржут, кое-кто снимает происходящее на телефон.'
	$_mini[1] = 'Юля Милова, развернувшись боком за партой, лазит в телефоне, светя трусами на весь класс, не замечая того.'
	$_mini[2] = 'Пока учитель что-то рассказывает, вы замечаете интересное: Дэн Рыжов приспустил штаны, а сидящая с ним рядом Наташка Белова запустила ему руку в трусы и двигает ей там туда-сюда. Дэн же довольно лыбится.'
	$_mini[3] = 'Пока учитель что-то пишет на доске - девчонки достали телефоны и что-то показывают друг другу украдкой, прыская и шушукаясь.'
	$_mini[4] = 'Краем глаза вы замечаете, как Ленка Котова лезет в сумку и что-то извлекает оттуда. Она ставит учебник “на попа”, и прикрываясь им, возится под столом. Затем она достаёт из под стола банку “Ягуара”, и прячась за учебником, присасывается к банке.'
	$_mini[5] = 'Перед вами сидит Линка Старова. Она сегодня пришла в джинсах, хотя и не положено, но, видать, захотелось обновой похвастаться. Джинсы с очень низкой посадкой, и теперь, когда она сидит, они едва прикрывают половину задницы, выставив напоказ её трусики.'
	$_mini[6] = 'На уроке настолько скучно, что даже заучка Милова закатывает глаза, страдальчески дожидаясь когда эта тягомотина наконец закончится.'
	$_mini[7] = 'Учитель вышел из класса ненадолго, и Линка Старова, перегнувшись через парту, о чём-то болтает с Миловой.'
	$_mini[8] = 'Ожидая конца урока, вы обратили внимание, как одноклассница поправляет туфли, выставив свои стройные ножки в проход.'
	$_mini[9] = 'Ожидая конца урока, вы обратили внимание, как одна из одноклассниц не выдержала и уснула прямо на парте совершенно не заметив, что её юбочка немного задралась.'
	$_mini[10] = 'Ожидая конца урока, вы обратили внимание, что у одной из девченок видно трусики из-под одежды.'
	$_mini[11] = 'Вы сидите и разглядываете красивенькие колготки одной из ваших одноклассниц, думая, что надо и себе такие прикупить.'
	$_mini[12] = 'Звенит звонок, и Полька Себаготуллина пускается в пляс: "наконец-то кончилась эта тягомотина!".'
	$_mini[13] = 'От скуки ваши одноклассники впадают в детство. Мальчик написал на бумажке УЙ, и держит так, чтобы перекрещивающиеся лямки на платье сидящей впереди Вики Мейнольд изобразили недостающую букву.'
	$_mini[14] = 'В школу пришли ОМОН-овцы, рассказать, до чего их служба и опасна и трудна. Называется это “Урок мужества”. Вам скучно, но мальчишки с удовольствием примеряют снаряжение.'
	$_mini[15] = 'Стоя у доски, одноклассник приспускает штаны, показывая всем, кроме отвернувшейся училки, краешек задницы.'
	$_mini[16] = 'Лерка Царева отжигает у доски: уровень знаний такой же, как длина юбочки.'
	$_mini[17] = 'На уроке вы задремали, и вам снится, что все ваши одноклассницы пришли в школу голышом. Проснувшись, вы какое-то время раздумываете, не сагитировать ли подруг провернуть что-то такое в реальной жизни? Но, поразмыслив, отбрасываете эту идею - так и из школы вылететь недолго.'
	$_mini[18] = 'Ваши одноклассники своим хамством и пошлыми намёками доводят молоденькую учительницу, только недавно пришедшую в школу, до слёз.'
	$_mini[19] = 'Пацаны притащили из кабинета НВП макет автомата и даже на уроке с ним не расстаются.'
	$_mini[20] = 'Урок ведет практикантка из “педа”. Парни откровенно пялятся на стройные ножки, а ей хоть бы хны. Похоже, специально так оделась.'
	$_mini[21] = 'Лерка Царева взяла и прямо на уроке спустила джинсы.Хорошо хоть трусы на ней есть. А может - плохо...'
	$_mini[22] = 'Училка сидит на краю стола, демонстрируя стройные ноги. По горящим глазам парней понятно, что они охотно спели бы с ней дуэтом, а то и хором.'
	i = rand(0,arrsize('$_mini')-1)
	gs 'zz_render','','pavlovo/school/mini/' + i,$_mini[i]
	killvar '$_mini'
end
! школьные мини-ивенты - физра
if $args[0] = 'mini_phys':
	$_mini[0] = 'Вы разминаетесь с девчонками и купаетесь во внимании парней, не отрывающих взглядов от вашей попки и прелестей ваших одноклассниц. Решив ещё больше их подразнить, вы с девочками одновременно приспускаете тренировочные штаны, явив попки, обтянутые трусиками. Застывшие в разных позах парни с упавшими челюстями и даже учитель физкультуры выглядят довольно забавно, вызвав у вашей женской компашки приступ хохота.'
	$_mini[1] = 'Решив с девчонками немного подурачиться, вы засовываете под майки мячи и бегаете с ними, хвастаясь перед парнями "могучими бюстами". Урок проходит довольно весело.'
	$_mini[2] = 'Во время разминки физрук подошёл к вам и помог разминаться, прижимая вашу попку к своему паху. Злобный взгляд Зверевой в этот момент напоминает лазер: если б могла - взглядом бы сожгла как джедай световым мечом.'
	$_mini[3] = 'Ваня предложил вам потренироваться на шарах, этим тут же заинтересовалась Лариса: похоже Ваня ей очень нравится, но Вика... Расположившись с ней на шарах, вы принимаетесь выполнять какие-то упражнения под чутким руководством Вани. Вы так и не поняли в чём смысл тренировки, но Ваня за это время явно надержался как за вашу попу, так и за попу Ларисы. "Вот лишь бы за жопу помацать! - хихикаете вы про себя. Хотя и приятно было: Ваня аккуратен и нежен и его прикосновения совсем не противны. Весьма приятны даже.'
	$_mini[4] = 'После переклички физрук объявляет, что сегодня класс будет сдавать прыжки через козла. Вы вместе со всеми дожидались своей очереди, что бы прыгнуть через козла. Девки ржут, обсуждая "козлов и как их иметь".'
	$_mini[5] = 'После переклички физрук объявляет, что сегодня класс будет сдавать пресс. Вы вместе со всеми дожидаетесь своей очереди, чтобы выполнить упражнение.'
	$_mini[6] = 'После переклички физрук объявляет, что сегодня класс будет сдавать подтягивания. Вы вместе со всеми дожидаетесь своей очереди чтобы подтянуться на перекладине.'
	$_mini[7] = 'Физрук идет вдоль строя девочек, поглядывая на их выпуклости.'
	$_mini[8] = 'Сверкая стройными ножками, ваши одноклассницы занимаются физкультурой.'
	$_mini[9] = 'Сегодня на физре девчонки и парни по очереди бросают мяч в баскетбольное кольцо. Пацаны выпендриваются, изображая Майклов Джорданов, но попадают в кольцо крайне редко. Девчонки выстроились в очередь и бросают мяч по очереди, вызывая своей меткостью издевательские смешки парней. Бросает мяч Полинка, даже не попав в щит с кольцом. Пацаны ржут. Следующей становится Лариса Груздева. Она берёт мяч в одну руку и подкидывает его, привычным движением закрутив. Зверева громко фыркает:**\\\Это тебе не волейбол, дура, а баскетбол!/// - однако Лариса, ещё раз подбросив тяжёлый баскетбольный мяч в воздух, примеряясь к его весу и размеру, вдруг резким сильным звонким хлопком посылает его точно в кольцо, так что мяч заходит в сетку трёхочковым, не зацепив кольца. Кристинка недовольно отворачивается, заткнувшись.'
	i = rand(0,arrsize('$_mini')-1)
	gs 'zz_render','','pavlovo/school/mini/' + (100+i),$_mini[i]
	killvar '$_mini'
end
! школьные мини-ивенты - перемена, в классе
if $args[0] = 'mini_break_class':
	$_mini[0] = 'В классе вы видите, как Юлька Милова что-то грубо выговаривает Наташе Беловой и задрав подбородок отходит. Наташа понуро опускает голову, закрыв лицо руками.'
	$_mini[1] = 'Ваши одноклассницы стараются перещеголять друг дружку - у кого юбка короче? С большим отрывом побеждает Лерка Царева: её юбочка, будь она короче ещё на пару сантиметров, могла бы именоваться топиком.'
	$_mini[2] = 'Ничто человеческое учителям не чуждо. Даже селфи делают, в их-то возрасте!'
	$_mini[3] = 'Ваши одноклассницы что-то рассматривают, перегнувшись через парту. Три пухлых попки, обтянутых тканью, заставляют парней замирать.'
	$_mini[4] = 'Полина Себаготуллина на спор демонстрирует задницу. Оказывается, трусов она не носит, и парни шушукаются и тычут пальцами.'
	$_mini[5] = 'Ваши одноклассники- парни, хоть и выросли в некоторых местах, но остались мальчишками. Вот и Клюев в своем репертуаре: задрал девушке юбку. Зачем - непонятно, но все ржут.'
	$_mini[6] = 'Многие ваши одноклассницы весьма развиты местами. Школу еще не закончили, а сиськи такие, что мужчины на улице спотыкаются.'
	$_mini[7] = 'У Соньки Иванько порвались колготки, но ей, похоже, до фонаря.'
	i = rand(0,arrsize('$_mini')-1)
	gs 'zz_render','','pavlovo/school/mini/' + (200+i),$_mini[i]
	minut += 10
	killvar '$_mini'
end
! школьные мини-ивенты - перемена, в коридоре
if $args[0] = 'mini_break_cor':
	$_mini[0] = 'Две девочки из параллельного целуются в коридоре. На них показывают пальцами, но парочке не до этого.'
	$_mini[1] = 'Ваши одноклассники расселись на лавочках у стены и дружно уткнулись кто в смартфон, кто в планшет.'
	$_mini[2] = 'Вы выходите на перемену. В школьном коридоре толпа и шумно. Девчонки что-то показывают друг другу в телефонах.'
	$_mini[3] = 'Проходя по коридору, вы замечаете как техничка моет полы в классе.'
	$_mini[4] = 'Альбина Барловская что-то доказывает Ларисе Груздевой, а та с несколько озадаченным видом слушает.'
	$_mini[5] = 'В школу нагрянула полиция: ищут наркотики. Учеников выгнали из классов и построили в коридоре. Вдоль строя идет собака с сотрудником полиции и нюхает.'
	$_mini[6] = 'По коридору проходит училка с калашом, как будто так и надо. Наверное, в класс НВП идет. Но сердце на мгновение замирает: щас как даст очередь!'
	$_mini[7] = 'Многие ваши одноклассницы выставляют свои прелести напоказ.'
	$_mini[8] = 'К девченкам из параллельного пришли гости - пацаны, у которых на лбу написано “ПТУ”. Один даже в шлепанцах, как будто у себя в деревне. И как не белево с такими общаться?'
	$_mini[9] = 'Девушка c параллельного, сидя на подоконнике, позирует парню, фоткающему её на телефон.'
	$_mini[10] = 'Девушка c параллельного забралась на подоконник и с умным лицом смотрит в учебник, дразня парней видом своих ножек.'
	$_mini[11] = 'Девушка c параллельного опять забралась на подоконник - как будто нет других мест, чтобы подразнить парней!'
	$_mini[12] = 'Девушка c параллельного задумчиво смотрит в окно, и, вызывая ненавысть окружающих девушек, светит своей симпатичной попой на весь коридор.'
	i = rand(0,arrsize('$_mini')-1)
	gs 'zz_render','','pavlovo/school/mini/' + (300+i),$_mini[i]
	minut += 10
	killvar '$_mini'
end