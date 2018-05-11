if $ARGS[0] = 'start':
	*clr & cla
	gorodokKomp = iif($control_point = 'gorodok',1,0)
	gs 'stat'
	gs 'zz_render','','images/pics/komp.jpg',func('Komp_strings', '1')
	gs 'zz_render','','','Вы можете <a href="exec:GT ''Komp'',''internet_pay''">оплатить</a> интернет через свой банковский счет (300 руб). На счету <<karta>> рублей.'
	if internet > 0:
		gs 'zz_render','','','У вас осталось <B><<internet>> дней</B> интернета.'
		gs 'zz_render','','','Вы можете воспользоваться <a href="exec:GT ''Komp'',''brows''">браузером</a>'
	end
	if university['student'] > 0 and (month <= 6 or month >= 9):
		if university['course'] = 1:
			gs 'zz_render', '', '', '<a href="exec: gt''uni_events'',''course_work'', 1">Писать курсовую работу.</a>'
		else
			gs 'zz_render', '', '', '<a href="exec: gt''uni_events'',''graduate_work'', 1">Писать дипломную работу.</a>'
		end
	end
	gs 'zz_render','','','<a href="exec:GT ''Komp'',''pasians''">Раскладывать пасьянс</a>'
	act '<B>Выключить компьютер</B>':
		cla
		gt 'Komp','fin'
	end
end
if $ARGS[0] = 'brows':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/pics/komp/brows.jpg','У вас осталось <<internet>> дней интернета.'
	gs 'zz_render','','','Вы вошли в поисковую систему. Вы можете посетить:'
	gs 'zz_render','','','<a href="exec:GT ''Komp'',''agent''">Сайт агентсва недвижимости</a>'
	if student > 0: '<a href="exec:GT ''Komp'',''study''">Институт педагогических измерений</a>'
	gs 'zz_render','','','<a href="exec:GT ''Komp'',''remont''">Сайт квартирного ремонта</a>'
	if BuyHous = 1 and husband = 0:'<a href="exec:GT ''Komp'',''sale''">Сайт объявлений</a>'
	gs 'zz_render','','','<a href="exec:GT ''Komp'',''porno''">Порно сайт</a>'
	gs 'zz_render','','','<a href="exec:GT ''Komp'',''znak''">Сайт знакомств</a>'
	if hour < 20 and hour > 7 and gorodokKomp = 0:'<a href="exec:GT ''Komp'',''rabota''">Подработка.su</a>'
	gs 'zz_render','','','<a href="exec:GT ''Komp'',''kabtv''">Сайт кабельного ТВ</a>'
	!онлайн видео чат рунетка
	if $loc = 'shulga_room' and $npc['11,relation'] >= 50 or $loc = 'sitr': '<a href="exec:GT ''webcam_site''">Онлайн видео чат "Рунетка"</a>'
	if internet = 0:
		*clr & cla
		gs 'zz_render','','images/pics/komp/eror.jpg',func('Komp_strings', '3')
	end
	act '<B>Выйти из браузера</B>':gt'Komp','start'
end
if $ARGS[0] = 'sale':
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render', '<b>Сайт объявлений</b>', 'images/pics/komp/sale.jpg','Вы вошли на сайт бесплатных объявлений.'
	repair_apartments = (remkorr + rembedr + remkuhr + remsitr + remvanr)
	if obkvsdam = 0 and BuyHous = 1 and repair_apartments > 0:
		act 'Подать объявление о сдачи квартиры':obkvsdam = rand(1,5) & gt'Komp','sale'
	elseif obkvsdam > 0:
		act 'Проверить отклики на ваше объявление о сдачи квартиры':
			cla
			if obkvsdam < 5:
				gs 'zz_render', '', '','Никто не откликнулся на ваше объявление'
			else
				predsumm = repair_apartments * 1500
				gs 'zz_render', '', '','Вашу квартиру хотят снять на месяц за <<predsumm>> руб.'
				act 'Сдать':
					sdaday += 30
					sdamonth = 1
					BuyHous = 0
					money += predsumm
					gt'Komp','start'
				end
			end
			act '<B>Закончить</B>':gt'Komp','brows'
		end
	end
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'remont':
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render', '<b>Сайт квартирного ремонта</b>', 'images/pics/komp/remont.jpg','Вы вошли на сайт квартирного ремонта.'
	gs 'zz_render','','','<red>Внимание! На весь срок ремонта доступ в ремонтирующиеся помещения будет закрыт.</red>'
	if repairs_time > 0:'<b>Ваш ремонт продлится <<repairs_time>> дней.</b>'
	$no_money =	'<b>К сожалению, у вас на карте не достаточно средств для оплаты услуги.</b>'
	if BuyHous = 1:
		if rembedr < 2 and repairs_bedr = 0:
			act 'Косметический ремонт спальни(70 тыс.руб)':
				if karta >= 70000:
					cla
					repairs_time += 4
					repairs_bedr = 2
					karta -= 70000
					gs 'zz_render', '', '','Вы оплатили косметический ремонт спальни.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remsitr < 2 and repairs_sitr = 0:
			act 'Косметический ремонт зала(120 тыс.руб)':
				if karta >= 120000:
					cla
					repairs_time += 4
					repairs_sitr = 2
					karta -= 120000
					gs 'zz_render', '', '','Вы оплатили косметический ремонт зала.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remkorr < 2 and repairs_korr = 0:
			act 'Косметический ремонт коридора(35 тыс.руб)':
				if karta >= 35000:
					cla
					repairs_time += 4
					repairs_korr = 2
					karta -= 35000
					gs 'zz_render', '', '','Вы оплатили косметический ремонт коридора.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remvanr < 2 and repairs_vanr = 0:
			act 'Косметический ремонт ванной(80 тыс.руб)':
				if karta >= 80000:
					cla
					repairs_time += 4
					repairs_vanr = 2
					karta -= 80000
					gs 'zz_render', '', '','Вы оплатили косметический ремонт ванной.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remkuhr < 2 and repairs_kuhr = 0:
			act 'Косметический ремонт кухни(140 тыс.руб)':
				if karta >= 140000:
					cla
					repairs_time += 4
					repairs_kuhr = 2
					karta -= 140000
					gs 'zz_render', '', '','Вы оплатили косметический ремонт кухни.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if rembedr < 3 and repairs_bedr = 0:
			act 'Дизайнерский ремонт спальни(165 тыс.руб)':
				if karta >= 165000:
					cla
					repairs_time += 6
					repairs_bedr = 3
					karta -= 165000
					gs 'zz_render', '', '','Вы оплатили дизайнерский ремонт ремонт спальни.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remsitr < 3 and repairs_sitr = 0:
			act 'Дизайнерский ремонт зала('+iif(TV < 2,260,225)+' тыс.руб)':
				if karta >= iif(TV <= 2,260000,225000):
					cla
					repairs_time += 6
					repairs_sitr = 3
					TV = 2
					karta -= iif(TV <= 2,260000,225000)
					gs 'zz_render', '', '','Вы оплатили дизайнерский ремонт ремонт зала.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remkorr < 3 and repairs_korr = 0:
			act 'Дизайнерский ремонт коридора(80 тыс.руб)':
				if karta >= 80000:
					cla
					repairs_time += 6
					repairs_korr = 3
					karta -= 80000
					gs 'zz_render', '', '','Вы оплатили дизайнерский ремонт ремонт прихожей.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remvanr < 3 and repairs_vanr = 0:
			act 'Дизайнерский ремонт ванной('+iif(stiralka = 0,200,180)+' тыс.руб)':
				if karta >= iif(stiralka = 0,200000,180000):
					cla
					repairs_time += 6
					repairs_vanr = 3
					stiralka = 1
					karta -= iif(stiralka = 0,200000,180000)
					gs 'zz_render', '', '','Вы оплатили дизайнерский ремонт ремонт ванной комнаты.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
		if remkuhr < 3 and repairs_kuhr = 0:
			act 'Дизайнерский ремонт кухни('+iif(posudomashina = 0,300,270)+' тыс.руб)':
				if karta >= iif(posudomashina = 0,300000,270000):
					cla
					repairs_time += 6
					repairs_kuhr = 3
					posudomashina = 1
					karta -= iif(posudomashina = 0,300000,270000)
					gs 'zz_render', '', '','Вы оплатили дизайнерский ремонт ремонт кухни.'
				else
					cla
					gs 'zz_render', '', '', $no_money
				end
				act '<B>Выйти</B>':gt'Komp','remont'
			end
		end
	end
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'porno':
	*clr & cla
	minut += 60
	manna += RAND(10,50)
	horny += 30
	gs 'stat'
	gs 'zz_render','Порно сайт','pics/komp/porno.jpg', func('Komp_strings', '4')
	$pornomastr = {
		*clr & cla
		minut += 15
		sweat += 1
		horny += RAND(10,25)
		if divanmastr = 0: divanmastr = 1 & mastr += 1
		gs 'stat'
		gs 'zz_render', '', 'images/pics/kompmas.jpg', func('Komp_strings', '5')
		if horny >= 100:
			orgasm += 1
			horny = 0
			gs 'zz_render', '', '', func('Komp_strings', '6')
		end
		act '<B>Закончить</B>':divanmastr = 0 & gt'Komp','porno'
		if horny >= 50: act 'Продолжить':dynamic $pornomastr
	}
	act 'Смотреть порно дальше':
		cla
		gs 'zz_render','','pics/komp/porno.jpg'
		gt'Komp','porno'
	end
	if horny >= 50:act 'Мастурбировать 15 мин':dynamic $pornomastr
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'pasians':
	*clr & cla
	minut += 20
	manna += RAND(10,30)
	gs 'stat'
	gs 'zz_render','Пасьянс','pics/komp/pasians.jpg', func('Komp_strings', '7')
	act 'Раскладывать еще 20 минут':gt'Komp','pasians'
	act '<B>Закрыть пасьянс</B>':gt'Komp','start'
end
if $ARGS[0] = 'znak':
	*clr & cla
	minut += 60
	manna += 5
	gs 'stat'
	gs 'zz_render','Сайт знакомств', 'pics/komp/znak.jpg', func('Komp_strings', '8')
	if bfA <= 0:
		act 'Подобрать парня с мягким характером':
			cla
			gs'boy'
			gs'boyfrend','start'
			stopboy = 0
			harakBoyA = 0
			gs 'zz_render', '', '', func('Komp_strings', '9')
			act '<B>Закончить</B>':gt'Komp','brows'
		end
		act 'Подобрать парня с обыкновенным характером':
			cla
			gs'boy'
			gs'boyfrend','start'
			stopboy = 0
			harakBoyA = 1
			gs 'zz_render', '', '', func('Komp_strings', '10')
			act '<B>Закончить</B>':gt'Komp','brows'
		end
		act 'Подобрать парня с твердым характером':
			cla
			gs'boy'
			gs'boyfrend','start'
			stopboy = 0
			harakBoyA = 2
			gs 'zz_render', '', '', func('Komp_strings', '11')
			act '<B>Закончить</B>':gt'Komp','brows'
		end
	end
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'kabtv':
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render','Сайт кабельного ТВ','pics/komp/kabtv.jpg',func('Komp_strings', '13')
	if kabel = 1:
		gs 'zz_render', '', '', func('Komp_strings', '14')
		act 'Отказаться от кабельного ТВ':
			cla
			kabel = 0
			money -= 500
			gs 'zz_render', '', '', func('Komp_strings', '15')
			gt'Komp','kabtv'
		end
	else
		gs 'zz_render', '', '', func('Komp_strings', '16')
		act 'Подключить кабельное ТВ(500 руб в месяц)':
			if TV >= 2:
				cla
				kabel = 1
				gs 'zz_render', '', '', func('Komp_strings', '17')
				gt'Komp','kabtv'
			else
				cla
				gs 'zz_render', '', '', func('Komp_strings', '18')
				gt'Komp','kabtv'
			end
		end
	end
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'rabota':
	*clr & cla
	minut += 60
	komprabota = RAND(0,15)
	gs 'stat'
	gs 'zz_render','Сайт поиска работы','pics/komp/rabota.jpg'
	if komprabota = 0:
		gs 'zz_render', '', '', func('Komp_strings', '25')
		if vnesh < 60:
			gs 'zz_render', '', '', func('Komp_strings', '26')
		else
			act 'Отправиться по адресу':gt'qjob','var1'
		end
		if hour < 20 and hour > 7:act 'Искать ещё':gt'Komp','rabota'
		act '<B>Закончить</B>':gt'Komp','brows'
	elseif komprabota = 1:
		gs 'zz_render', '', '', func('Komp_strings', '27')
		if vnesh < 60:'Но вы под это описание не подходите'
		if vnesh >= 60:
			act 'Отправиться по адресу':gt'qjob','var2'
		end
		if hour < 20 and hour > 7:act 'Искать ещё':gt'Komp','rabota'
		act '<B>Закончить</B>':gt'Komp','brows'
	elseif komprabota > 1 and komprabota < 5:
		gs 'zz_render', '', '', func('Komp_strings', '28')
		if vnesh < 40:
			gs 'zz_render', '', '', func('Komp_strings', '29')
		else
			act 'Отправиться по адресу':gt'qjob','var3'
		end
		if hour < 20 and hour > 7:act 'Искать ещё':gt'Komp','rabota'
		act '<B>Закончить</B>':gt'Komp','brows'
	else
		gs 'zz_render', '', '', func('Komp_strings', '33')
		if hour < 20 and hour > 7:act 'Искать ещё':gt'Komp','rabota'
		act '<B>Закончить</B>':gt'Komp','brows'
	end
end
if $ARGS[0] = 'internet_pay':
	cla
	gs 'zz_render','','pics/komp/pay.jpg',func('Komp_strings','34')
	act '<B>Выйти из системы оплаты</B>': gt 'Komp','start'
	act 'Оплатить интернет (300 руб.)':
		cla
		minut += 5
		act '<B>Назад</B>': gt 'Komp','start'
		if karta < 300:
			gs 'zz_render','','',func('zz_atm_strings', 'atm_str6')
		else
			karta -= 300
			internet += 30
			gs 'zz_render','','',func('zz_atm_strings', 'atm_str10')
		end
		gs 'stat'
	end
end
if $ARGS[0] = 'study':
	*clr & cla
	minut += 60
	intel += 1
	gs 'zz_render','Институт педагогических измерений','pics/komp/study.jpg',func('Komp_strings', '37')
	act '<B>Закончить</B>': gt'Komp','start'
end
if $ARGS[0] = 'agent':
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render','Cайт агенства недвижимости','pics/komp/agent.jpg',func('Komp_strings', '39')
	if ArendHouseSL > 0:gs 'zz_render','','','У вас <B><<ArendHouseSL>> дней</B> аренды.'
	if karta >= 10000 and BuyHous ! 1:
		act 'Аренда квартиры онлайн':
			cla
			karta -= 10000
			housr = 1
			ArendHouseSL += 30
			gs 'zz_render', '', '', func('Komp_strings', '40')
			act '<B>Закончить</B>':gt'Komp','start'
		end
	end
	act '<B>Закончить</B>':gt'Komp','start'
end
if $ARGS[0] = 'fin':
	gt $loc, $metka
end