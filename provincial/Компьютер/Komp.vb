if $ARGS[0] = 'start':
	*clr & cla
	elektro += 5
	gorodokKomp = iif($control_point = 'gorodok',1,0)
	gs'stat'
	'<center><b>Ноутбук</b></center>'
	'<center><img src="images/pics/komp.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '1')
	if karta >= 10:
		'Вы можете <a href="exec:GT ''Komp'',''internet_pay''">оплатить</a> интернет через свой банковский счет. 1 час интернета стоит 10 рублей. На счету <<karta>> рублей.'
	end
	if internet > 0:
		internet = internetM/60
		gs 'zz_render', '', '', func('Komp_strings', '2')
		'У вас осталось <B><<internet>> часов</B> интернета'
		'Вы можете воспользоваться <a href="exec:GT ''Komp'',''brows''">браузером</a>'
	end
	if university['student'] > 0 and (month <= 6 or month >= 9):
		if university['course'] = 1:
			gs 'zz_render', '', '', '<a href="exec: gt''university_events'',''course_work'', 1">Писать курсовую работу.</a>'
		else
			gs 'zz_render', '', '', '<a href="exec: gt''university_events'',''graduate_work'', 1">Писать дипломную работу.</a>'
		end
	end
	'<a href="exec:GT ''Komp'',''pasians''">Раскладывать пасьянс</a>'
	act '<B>Выключить компьютер</B>':
		cla
		gt 'Komp','fin'
	end
end
if $ARGS[0] = 'brows':
	*clr & cla
	gs'stat'
	'<center><b>Бразуер</b></center>'
	'<center><img src="images/pics/komp/brows.jpg"></center>'
	'У вас осталось <<internet>> часов интернета.'
	'Вы вошли в поисковую систему. Вы можете посетить:'
	'<a href="exec:GT ''Komp'',''agent''">Сайт агентсва недвижимости</a>'
	if student > 0: '<a href="exec:GT ''Komp'',''study''">Институт педагогических измерений</a>'
	'<a href="exec:GT ''Komp'',''remont''">Сайт квартирного ремонта</a>'
	if BuyHous = 1 and husband = 0:'<a href="exec:GT ''Komp'',''sale''">Сайт объявлений</a>'
	'<a href="exec:GT ''Komp'',''porno''">Порно сайт</a>'
	'<a href="exec:GT ''Komp'',''znak''">Сайт знакомств</a>'
	if hour < 20 and hour > 7 and gorodokKomp = 0:'<a href="exec:GT ''Komp'',''rabota''">Подработка.su</a>'
	'<a href="exec:GT ''Komp'',''kabtv''">Сайт кабельного ТВ</a>'
	if shantfoto > 0:'Искать героиню фото в <a href="exec:GT ''Komp'',''foto''">"В жопе"</a>'
	if gor_dorm = 7:'Прочитать <a href="exec:GT ''etoexhib'',''pos91''">письмо</a> от Евгении Анатольевны'
	if camwhore = 1:'<a href="exec:GT ''Komp'',''mfc''">MyFreeCams.org</a>'
	!онлайн видео чат рунетка
	if $loc='shulga_room' and $npc['11,relation']>=50 or $loc='sitr' and webcamera = 1: '<a href="exec:GT ''webcam_site''">Онлайн видео чат "Рунетка"</a>'
	if internet = 0:
		*clr & cla
		'<center><b>Браузер</b></center>'
		'<center><img src="images/pics/komp/eror.jpg"></center>'
		gs 'zz_render', '', '', func('Komp_strings', '3')
	end
	act '<B>Выйти из браузера</B>':gt'Komp','start'
end
if $ARGS[0] = 'sale':
	*clr & cla
	minut += 60
	internetM -= 60
	elektro += 3
	internet -= 1
	gs'stat'
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
	internetM -= 60
	if housr = 1:elektro -= 3
	internet -= 1
	gs'stat'
	gs 'zz_render', '<b>Сайт квартирного ремонта</b>', 'images/pics/komp/remont.jpg','Вы вошли на сайт квартирного ремонта.'
	'<b><font color = red>Внимание! На весь срок ремонта доступ в ремонтирующиеся помещения будет закрыт.</font></b>'
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
					gs 'zz_render', '', '','Вы оплатили  косметический ремонт спальни.'
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
					gs 'zz_render', '', '','Вы оплатили  косметический ремонт зала.'
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
					gs 'zz_render', '', '','Вы оплатили  косметический ремонт коридора.'
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
					gs 'zz_render', '', '','Вы оплатили  косметический ремонт ванной.'
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
					gs 'zz_render', '', '','Вы оплатили  косметический ремонт кухни.'
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
					gs 'zz_render', '', '','Вы оплатили  дизайнерский ремонт ремонт спальни.'
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
					gs 'zz_render', '', '','Вы оплатили  дизайнерский ремонт ремонт зала.'
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
					gs 'zz_render', '', '','Вы оплатили  дизайнерский ремонт ремонт прихожей.'
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
					gs 'zz_render', '', '','Вы оплатили  дизайнерский ремонт ремонт ванной комнаты.'
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
					gs 'zz_render', '', '','Вы оплатили  дизайнерский ремонт ремонт кухни.'
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
	internetM -= 60
	manna += 5
	elektro += 3
	manna += RAND(10,50)
	horny += 30
	internet -= 1
	gs'stat'
	'<center><b>Порно сайт</b></center>'
	'<center><img src="images/pics/komp/porno.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '4')
	$pornomastr = {
		*clr & cla
		minut += 15
		sweat += 1
		horny += RAND(10,25)
		if divanmastr = 0: divanmastr = 1 & mastr += 1
		gs'stat'
		'<center><img src="images/pics/kompmas.jpg"></center>'
		gs 'zz_render', '', '', func('Komp_strings', '5')
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
		'<center><img src="images/pics/komp/porno.jpg"></center>'
		gt'Komp','porno'
	end
	if horny >= 50:act 'Мастурбировать 15 мин':dynamic $pornomastr
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'pasians':
	*clr & cla
	minut += 20
	manna += 5
	elektro += 3
	manna += RAND(10,50)
	gs'stat'
	'<center><b>Пасьянс</b></center>'
	'<center><img src="images/pics/komp/pasians.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '7')
	act 'Раскладывать еще 20 минут':gt'Komp','pasians'
	act '<B>Закрыть пасьянс</B>':gt'Komp','start'
end
if $ARGS[0] = 'znak':
	*clr & cla
	minut += 60
	internetM -= 60
	manna += 5
	elektro += 3
	internet -= 1
	gs'stat'
	'<center><b>Сайт знакомств</b></center>'
	'<center><img src="images/pics/komp/znak.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '8')
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
	if gor_dorm = 8:
		act 'Подобрать женихов для Евгении':
			cla
			gor_dorm = 9
			gs 'zz_render', '', '', func('Komp_strings', '12')
			act '<B>Закончить</B>':gt'Komp','brows'
		end
	end
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'kabtv':
	*clr & cla
	minut += 60
	internetM -= 60
	elektro += 3
	internet -= 1
	gs'stat'
	'<center><b>Сайт кабельного ТВ</b></center>'
	'<center><img src="images/pics/komp/kabtv.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '13')
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
if $ARGS[0] = 'foto':
	*clr & cla
	minut += 60
	internetM -= 60
	elektro += 3
	internet -= 1
	gs'stat'
	'<center><b>Социальная сеть</b></center>'
	'<center><img src="images/pics/komp/foto.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '19')
	if shantfoto > 0:
		act 'Искать':
			cla
			minut += 60
			fotsearchrand = RAND(0,10)
			if fotsearchrand <= 7:
				gs 'zz_render', '', '', func('Komp_strings', '20')
				act 'Закончить':gt'Komp','foto'
			end
			if fotsearchrand > 7:
				shantfoto -= 1
				gs 'zz_render', '', '', func('Komp_strings', '21')
				gerofotorand = RAND(0,100)
				if gerofotorand > 30:
					gs 'zz_render', '', '', func('Komp_strings', '22')
					act 'Закончить':gt'Komp','foto'
				end
				if gerofotorand >= 5 and gerofotorand <= 30:
					shantsr += 1
					gs 'zz_render', '', '', func('Komp_strings', '23')
					act 'Закончить':gt'Komp','foto'
				end
				if gerofotorand < 5:
					shantbog += 1
					! wtf???
					if shantbog > 0:
						:shantftb
						shantftbgrand = RAND(0,10)
						if shantftbgrand > 2:
							shantpopala += 1
							shantbog -= 1
							if shantbog > 0: jump'shantftb'
						elseif shantftbgrand <= 2:
							karta += 30000
							shantbog -= 1
							if shantbog > 0: jump'shantftb'
						end
					end
					gs 'zz_render', '', '', func('Komp_strings', '24')
					act 'Закончить':gt'Komp','foto'
				end
			end
		end
	end
	act '<B>Закончить</B>':gt'Komp','brows'
end
if $ARGS[0] = 'rabota':
	*clr & cla
	minut += 60
	internetM -= 60
	elektro += 3
	internet -= 1
	komprabota = RAND(0,15)
	gs'stat'
	'<center><b>Сайт поиска работы</b></center>'
	'<center><img src="images/pics/komp/rabota.jpg"></center>'
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
	elseif komprabota > 4 and komprabota < 8 and intel >= 70 and camwhore = 0:
		gs 'zz_render', '', '', func('Komp_strings', '30')
		act 'Заинтересоваться':
			*clr & cla
			minut += 5
			gs 'stat'
			'<center><img src="images/camwhore/camwhore1.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '31')
			act 'Заполнить анкету':
				*clr & cla
				camwhore = 1
				minut += 20
				gs 'stat'
				'<center><img src="images/camwhore/camwhore2.jpg"></center>'
				gs 'zz_render', '', '', func('Komp_strings', '32')
				act 'Закончить':gt'Komp','brows'
			end
			act 'Вернуться':gt'Komp','brows'
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
	'<center><b>Оплата через банковский счет</b></center>'
	'<center><img src="images/pics/komp/pay.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '34')
	act '<B>Выйти из системы оплаты</B>':gt'Komp','start'
	intinp = input ("Сколько часов интернета вы хотите оплатить? (час = 10 руб.)")
	if intinp <= 0 or intinp*10 > karta:
		gs 'zz_render', '', '', func('Komp_strings', '35')
	elseif intinp*10 <= karta:
		inttime = intinp
		karta -= inttime*10
		internetM += intinp*60
		internet = internetM/60
		gs 'zz_render', '', '', func('Komp_strings', '36')
	end
end
if $ARGS[0] = 'study':
	*clr & cla
	minut += 60
	internetM -= 60
	elektro += 3
	internet -= 1
	intel += 1
	'<center><b>Институт педагогических измерений</b></center>'
	'<center><img src="images/pics/komp/study.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '37')
	act '<B>Закончить</B>': gt'Komp','start'
end
if $ARGS[0] = 'agent':
	*clr & cla
	minut += 60
	internetM -= 60
	elektro += 3
	internet -= 1
	gs'stat'
	'<center><b>Cайт агенства недвижимости</b></center>'
	'<center><img src="images/pics/komp/agent.jpg"></center>'
	gs 'zz_render', '', '', func('Komp_strings', '39')
	if ArendHouseSL > 0:'У вас <B><<ArendHouseSL>> дней</B> аренды.'
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
if $ARGS[0] = 'mfc':
	if $sister['location'] ! $loc:
		act'Зайти в свою комнату':
			*clr & cla
			minut += 2
			gs 'stat'
			'<center><img src="images/camwhore/camwhore3.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '41')
			act 'Далее':gt'komp','startpagemfc'
		end
		act'Закрыть вкладку':
			*clr & cla
			minut += 2
			topmfc = 1
			backmfc = 1
			tokens = 0
			camclients = 0
			gs 'stat'
			gt'Komp','brows'
		end
	else
		*clr & cla
		minut += 2
		topmfc = 1
		backmfc = 1
		tokens = 0
		camclients = 0
		gs 'stat'
		'<center><img src="images/camwhore/camwhore2.jpg"></center>'
		gs 'zz_render', '', '', func('Komp_strings', '42')
		act 'Закрыть вкладку':gt'Komp','brows'
	elseif mesec > 0:
		*clr & cla
		minut += 2
		topmfc = 1
		backmfc = 1
		tokens = 0
		camclients = 0
		gs 'stat'
		'<center><img src="images/camwhore/camwhore2.jpg"></center>'
		gs 'zz_render', '', '', func('Komp_strings', '43')
		act 'Закрыть вкладку':gt'Komp','brows'
	end
end
if $ARGS[0] = 'startpagemfc':
	if vgape > 0 or agape > 0:
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', '', func('Komp_strings', '44')
		act 'Закрыть вкладку':
			karta += tokens/2
			gt'Komp','mfc'
		end
	else
		*clr & cla
		if mfcdaycum ! daystart:mfccum = 0
		gs 'stat'
		'<center><img src="images/camwhore/camwhore3.jpg"></center>'
		gs 'zz_render', '', '', func('Komp_strings', '45')
		act'Включить вебкамеру':gt'komp','waitclients'
		act'Выйти':
			karta += tokens/2
			gt'Komp','mfc'
		end
	end
end
if $ARGS[0] = 'waitclients':
	*clr & cla
	minut += RAND(1,4)
	if mfccum = 0:
		manna -= RAND(0,3)
	elseif mfccum = 1:
		mfcdaycum = daystart
		manna -= RAND(1,3)*mfccum
	elseif mfccum = 2:
		mfcdaycum = daystart
		manna -= RAND(2,5)*mfccum
	elseif mfccum = 3:
		mfcdaycum = daystart
		manna -= RAND(5,8)*mfccum
	elseif mfccum = 4:
		mfcdaycum = daystart
		manna -= RAND(5,11)*mfccum
	elseif mfccum = 5:
		mfcdaycum = daystart
		manna -= RAND(7,12)*mfccum
	elseif mfccum > 5:
		mfcdaycum = daystart
		manna -= RAND(10,20)*mfccum
	end
	mfcclients += 1
	if vnesh < 60:
		if topmfc = 1 and backmfc = 1:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(1,3)
				else
					camclients += RAND(1,3)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(3,5)
				else
					camclients += RAND(3,5)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(4,8)
				else
					camclients += RAND(4,8)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(5,15)
				else
					camclients += RAND(5,15)
				end
			end
			chancetips = RAND(0,100)
			clientask = RAND(0,100)
			if chancetips >= 95 and camclients >= 250:
				if webpopular >= 50:
					tokens += RAND(10,30)
				else
					tokens += RAND(1,20)
				end
			end
		end
	else
		if topmfc = 1 and backmfc = 1:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(3,5)
				else
					camclients += RAND(3,5)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(5,8)
				else
					camclients += RAND(5,8)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(5,12)
				else
					camclients += RAND(5,12)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(8,15)
				else
					camclients += RAND(8,15)
				end
			end
			chancetips = RAND(5,100)
			clientask = RAND(5,100)
			if chancetips >= 95 and camclients >= 200:
				if webpopular >= 50:
					tokens += RAND(10,40)
				else
					tokens += RAND(1,20)
				end
			end
		end
	end
	if vnesh < 60:
		if topmfc = 0 and backmfc = 1:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(1,3)
				else
					camclients += RAND(1,3)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(1,5)
				else
					camclients += RAND(1,5)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(5,10)
				else
					camclients += RAND(5,10)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(6,15)
				else
					camclients += RAND(6,15)
				end
			end
			chancetips = RAND(5,90)
			clientask = RAND(5,100)
			if chancetips >= 85 and camclients >= 230:
				if webpopular >= 50:
					tokens += RAND(10,35)
				else
					tokens += RAND(1,20)
				end
			end
		end
	else
		if topmfc = 0 and backmfc = 1:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(3,6)
				else
					camclients += RAND(3,6)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(5,10)
				else
					camclients += RAND(5,10)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(7,12)
				else
					camclients += RAND(7,12)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(10,15)
				else
					camclients += RAND(10,15)
				end
			end
			chancetips = RAND(10,90)
			clientask = RAND(10,100)
			if chancetips >= 85 and camclients >= 200:
				if webpopular >= 50:
					tokens += RAND(15,35)
				else
					tokens += RAND(1,20)
				end
			end
		end
	end
	if vnesh < 60:
		if topmfc = 1 and backmfc = 0:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(1,3)
				else
					camclients += RAND(1,3)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(2,5)
				else
					camclients += RAND(2,5)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(5,15)
				else
					camclients += RAND(5,15)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(5,20)
				else
					camclients += RAND(5,20)
				end
			end
			chancetips = RAND(10,80)
			clientask = RAND(10,100)
			if chancetips >= 75 and camclients >= 200:
				if webpopular >= 50:
					tokens += RAND(10,40)
				else
					tokens += RAND(1,20)
				end
			end
		end
	else
		if topmfc = 1 and backmfc = 0:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(4,7)
				else
					camclients += RAND(4,7)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(5,12)
				else
					camclients += RAND(5,12)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(9,15)
				else
					camclients += RAND(9,15)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(15,20)
				else
					camclients += RAND(15,20)
				end
			end
			chancetips = RAND(15,80)
			clientask = RAND(15,100)
			if chancetips >= 75 and camclients >= 170:
				if webpopular >= 50:
					tokens += RAND(15,45)
				else
					tokens += RAND(1,20)
				end
			end
		end
	end
	if vnesh < 60:
		if topmfc = 0 and backmfc = 0:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(1,4)
				else
					camclients += RAND(1,4)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(3,10)
				else
					camclients += RAND(3,10)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(10,20)
				else
					camclients += RAND(10,20)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(10,30)
				else
					camclients += RAND(10,30)
				end
			end
			chancetips = RAND(15,50)
			clientask = RAND(15,100)
			if chancetips >= 45 and camclients >= 150:
				if webpopular >= 50:
					tokens += RAND(20,50)
				else
					tokens += RAND(5,25)
				end
			end
		end
	else
		if topmfc = 0 and backmfc = 0:
			if webpopular < 15:
				if mfcclients > 3:
					camclients -= RAND(3,8)
				else
					camclients += RAND(3,8)
				end
			elseif webpopular >= 15 and webpopular < 35:
				if mfcclients > 3:
					camclients -= RAND(3,15)
				else
					camclients += RAND(3,15)
				end
			elseif webpopular >= 35 and webpopular < 75:
				if mfcclients > 3:
					camclients -= RAND(10,20)
				else
					camclients += RAND(10,20)
				end
			elseif webpopular >= 75:
				if mfcclients > 3:
					camclients -= RAND(10,30)
				else
					camclients += RAND(10,30)
				end
			end
			chancetips = RAND(20,50)
			clientask = RAND(20,100)
			if chancetips >= 45 and camclients >= 100:
				if webpopular >= 50:
					tokens += RAND(30,50)
				else
					tokens += RAND(10,30)
				end
			end
		end
	end
	if camclients <= 0:camclients = 0
	gs'stat'
	if backmfc = 1:
		'<center><img src="images/camwhore/camwhore'+iif(topmfc = 1,3,4)+'.jpg"></center>'
	else
		'<center><img src="images/camwhore/camwhore'+iif(topmfc = 1,5,6)+'.jpg"></center>'
	end
	gs 'zz_render', '', '', func('Komp_strings', '46')
	act'Ждать посетителей':gt'komp','waitclients'
	if topmfc = 1 and clientask >= 98:
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', '', func('Komp_strings', '47')
		act 'Снять бюстгальтер':
			*clr & cla
			webpopular += 1
			minut += 2
			topmfc = 0
			horny += 5
			if webpopular < 15:
				tokens += RAND(10,25)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(15,25)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(25,50)
			elseif webpopular >= 75:
				tokens += RAND(50,150)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore7.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '48')
			act'Далее':gt'Komp','waitclients'
		end
		act 'Игнорировать':
			*clr & cla
			webpopular -= 1
			gt'Komp','waitclients'
		end
	end
	if backmfc = 1 and clientask >= 96 and clientask < 98:
		*clr & cla
		gs 'zz_render', '', '', func('Komp_strings', '49')
		act 'Сделать':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 2
			backmfc = 0
			horny += 5
			if webpopular < 15:
				tokens += RAND(10,25)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(15,25)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(25,50)
			elseif webpopular >= 75:
				tokens += RAND(50,150)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore8.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '50')
			act'Далее':gt'Komp','waitclients'
		end
		act 'Игнорировать':
			*clr & cla
			webpopular -= 1
			gt'Komp','waitclients'
		end
	end
	if topmfc = 0 and clientask >= 94 and clientask < 96:
		*clr & cla
		gs 'zz_render', '', '', func('Komp_strings', '51')
		act 'Сделать':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 2
			backmfc = 0
			horny += RAND(5,10)
			if webpopular < 15:
				tokens += RAND(15,25)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(20,30)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(50,100)
			elseif webpopular >= 75:
				tokens += RAND(50,150)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore10.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '52')
			act'Далее':gt'Komp','waitclients'
		end
		act 'Игнорировать':
			*clr & cla
			webpopular -= 1
			gt'Komp','waitclients'
		end
	end
	if backmfc = 0 and clientask = 93:
		*clr & cla
		gs 'zz_render', '', '', func('Komp_strings', '53')
		act 'Сделать':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 2
			horny += RAND(5,10)
			if webpopular < 15:
				tokens += RAND(20,25)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(25,50)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(50,100)
			elseif webpopular >= 75:
				tokens += RAND(100,150)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore12.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '54')
			if horny >= 100:
				orgasm += 1
				mfccum += 1
				horny = 0
				manna = 100
				gs 'stat'
				gs 'zz_render', '', '', func('Komp_strings', '55')
			end
			act'Далее':gt'Komp','waitclients'
		end
		act 'Игнорировать':
			*clr & cla
			webpopular -= 1
			gt'Komp','waitclients'
		end
	end
	if backmfc = 0 and clientask = 92:
		*clr & cla
		gs 'zz_render', '', '', func('Komp_strings', '56')
		act 'Сделать':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 2
			if webpopular < 15:
				tokens += RAND(10,25)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(15,25)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(25,50)
			elseif webpopular >= 75:
				tokens += RAND(50,150)
			end
			gs 'stat'
			if analplugIN = 1:
				'<center><img src="images/camwhore/camwhore19.jpg"></center>'
			end
			if vagina = 0 and analplugIN = 0:
				'<center><img src="images/camwhore/camwhore18.jpg"></center>'
			end
			if vagina > 0 and vagina <= 10 and analplugIN = 0:
				'<center><img src="images/camwhore/camwhore13.jpg"></center>'
			end
			if vagina > 10 and vagina <= 15 and analplugIN = 0:
				'<center><img src="images/camwhore/camwhore14.jpg"></center>'
			end
			if vagina > 15 and vagina <= 25 and analplugIN = 0:
				'<center><img src="images/camwhore/camwhore15.jpg"></center>'
			end
			if vagina > 25 and vagina <= 35 and analplugIN = 0:
				'<center><img src="images/camwhore/camwhore16.jpg"></center>'
			end
			if vagina > 35 and analplugIN = 0:
				'<center><img src="images/camwhore/camwhore17.jpg"></center>'
			end
			gs 'zz_render', '', '', func('Komp_strings', '57')
			act'Далее':gt'Komp','waitclients'
		end
		act 'Игнорировать':
			*clr & cla
			webpopular -= 1
			gt'Komp','waitclients'
		end
	end
	if backmfc = 0 and anus >= 30 and webpopular >= 50 and clientask = 91:
		*clr & cla
		gs 'zz_render', '', '', func('Komp_strings', '58')
		act 'Потужиться':
			*clr & cla
			mfcclients = 0
			webpopular += 2
			dom -= 2
			minut += 2
			backmfc = 0
			horny -= RAND(20,30)
			if vnesh >= 60:
				tokens += RAND(50,100)
			else
				tokens += RAND(40,75)
			end
			if webpopular < 15:
				tokens += RAND(25,50)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(50,100)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(100,150)
			elseif webpopular >= 75:
				tokens += RAND(100,200)
			end
			gs 'stat'
			if analplugIN = 0:
				if cumanus > 0:
					'<center><img src="images/camwhore/camwhore74.jpg"></center>'
					gs 'zz_render', '', '', func('Komp_strings', '59')
				else
					'<center><img src="images/camwhore/camwhore20,'+rand(0,7)+'.jpg"></center>'
					gs 'zz_render', '', '', func('Komp_strings', '60')
				end
			else
				'<center><img src="images/camwhore/camwhore21.jpg"></center>'
				gs 'zz_render', '', '', func('Komp_strings', '61')
			end
			act'Далее':gt'Komp','waitclients'
		end
		act 'Игнорировать':
			*clr & cla
			gt'Komp','waitclients'
		end
	end
	if backmfc = 0 and clientask = 90: gt'kompMFC'
	if webpopular >= 15 and anus >= 15 and clientask = 89: gt'kompMFCtwo'
	if webpopular < 50 and clientask = 88: gt'kompMFCtwo'
	if webpopular >= 50 and vagina >= 35 and clientask = 87: gt'kompMFCtwo'
	if webpopular >= 35 and vagina >= 25 and alko >= 8 and clientask = 86: gt'kompMFCtwo'
	if webpopular >= 50 and vagina > 0 and anus > 0 and alko >= 8 and dom < -50 and clientask = 85: gt'kompMFCtwo'
	if backmfc = 0 and webpopular >= 25 and vagina >= 30 and anus >= 30 and alko >= 8 and clientask = 84: gt'kompMFCtwo'
	if backmfc = 0 and vagina > 20 and clientask = 83: gt'kompMFCtwo'
	if webpopular > 25 and backmfc = 0 and dom <= -25 and vagina > 10 and prezik > 0 and clientask = 82: gt'kompMFCtwo'
	if backmfc = 0 and webpopular >= 50 and anus > 25 and clientask = 81: gt'kompMFCtwo'
	if backmfc = 0 and webpopular >= 50 and anus > 10 and vagina > 10 and dom <= -50 and alko >= 6 and clientask = 80: gt'kompMFCtwo'
	if topmfc = 1 and clientask < 80:
		act'Снять бюстгальтер':
			*clr & cla
			mfcclients = 0
			minut += 2
			topmfc = 0
			horny += 5
			gs 'stat'
			'<center><img src="images/camwhore/camwhore'+iif(backmfc=1,4,5)+'.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '62')
			act'Далее':gt'Komp','waitclients'
		end
	end
	if topmfc = 0 and clientask < 80:
		act'Поиграться с грудью':
			*clr & cla
			if webpopular < 15:
				camclients += RAND(3,6)
			elseif webpopular >= 15 and webpopular < 35:
				camclients += RAND(5,10)
			elseif webpopular >= 35 and webpopular < 75:
				camclients += RAND(10,20)
			elseif webpopular >= 75:
				camclients += RAND(15,35)
			end
			minut += 2
			horny += 5
			if alko >= 4: nippain = 1
			chancetips = RAND(0,100)
			if chancetips >= 85:
				tokens += RAND(2,10)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore'+iif(alko>=4,80,9)+'.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '63')
			act'Далее':gt'Komp','waitclients'
		end
	end
	if backmfc = 1 and clientask < 80:
		act'Снять трусики':
			*clr & cla
			mfcclients = 0
			minut += 2
			backmfc = 0
			horny += 5
			gs 'stat'
			'<center><img src="images/camwhore/camwhore'+iif(topmfc = 1,5,6)+'.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '64')
			act'Далее':gt'Komp','waitclients'
		end
	end
	if backmfc = 0 and clientask < 80:
		act'Поиграться с киской':
			*clr & cla
			if webpopular < 15:
				camclients += RAND(5,10)
			elseif webpopular >= 15 and webpopular < 35:
				camclients += RAND(10,15)
			elseif webpopular >= 35 and webpopular < 75:
				camclients += RAND(10,30)
			elseif webpopular >= 75:
				camclients += RAND(15,40)
			end
			mfcclients = 0
			minut += 2
			horny += RAND(5,15)
			chancetips = RAND(0,100)
			if chancetips >= 75:
				tokens += RAND(10,15)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore11.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '65')
			if horny >= 100:
				webpopular -= 1
				orgasm += 1
				mfccum += 1
				horny = 0
				manna = 100
				gs 'stat'
				gs 'zz_render', '', '', func('Komp_strings', '66')
			end
			act'Далее':gt'Komp','waitclients'
		end
	end
	if backmfc = 0 and clientask < 80:
		act'Поиграться с попкой':
			*clr & cla
			if webpopular < 15:
				camclients += RAND(5,10)
			elseif webpopular >= 15 and webpopular < 35:
				camclients += RAND(10,15)
			elseif webpopular >= 35 and webpopular < 75:
				camclients += RAND(10,30)
			elseif webpopular >= 75:
				camclients += RAND(15,40)
			end
			if anus < 10:analplay += 1
			mfcclients = 0
			minut += 2
			horny += RAND(5,10)
			chancetips = RAND(0,100)
			if chancetips >= 60:
				tokens += RAND(10,20)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore85.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '67')
			if horny >= 100:
				webpopular -= 1
				orgasm += 1
				mfccum += 1
				horny = 0
				manna = 100
				gs 'stat'
				gs 'zz_render', '', '', func('Komp_strings', '68')
			end
			act'Далее':gt'Komp','waitclients'
		end
	end
	if topmfc = 0 and nippain < 3 and clientask < 80:
		act'Ущипнуть себя за соски':
			*clr & cla
			if webpopular < 15:
				camclients += RAND(5,10)
			elseif webpopular >= 15 and webpopular < 35:
				camclients += RAND(10,15)
			elseif webpopular >= 35 and webpopular < 75:
				camclients += RAND(10,30)
			elseif webpopular >= 75:
				camclients += RAND(15,40)
			end
			mfcclients = 0
			minut += 2
			nippain += 1
			horny -= RAND(20,50)
			chancetips = RAND(0,100)
			if chancetips >= 75:
				tokens += RAND(20,40)
			end
			gs 'stat'
			'<center><img src="images/camwhore/camwhore84.jpg"></center>'
			gs 'zz_render', '', '', func('Komp_strings', '69')
			act'Далее':gt'Komp','waitclients'
		end
	end
	gs 'zz_family','sister_sheduler'
	if $sister['location'] ! $loc:
		act'Выключить вебкамеру': gt'Komp','startpagemfc'
	else
		*clr & cla
		topmfc = 1
		backmfc = 1
		karta += tokens/2
		gs 'stat'
		'<center><img src="images/camwhore/camwhore2.jpg"></center>'
		gs 'zz_render', '', '', func('Komp_strings', '70')
		act 'Далее': gt'Komp','mfc'
	end
end