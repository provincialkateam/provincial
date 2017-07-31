if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	cla
	*clr
	hosprand = RAND(0,10)
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Поликлиника</font></b></center>'
	gs 'zz_render', '', 'images/pic/poli.jpg', func('poli_strings', 'local_str1')
	if workhosp = 1 and hour >= 8 and hour <= 9 and week < 6:act 'Выйти на смену':gt'poli','beginwork'
	act 'Выйти из Поликлиники':gt'street'
	if glassqw = 1:
		act 'Показаться Окулисту':
			cla
			*clr
			hour += 1
			minut += 35
			gs 'stat'
			gs 'zz_render', '', '', func('poli_strings', 'local_str2')
			nerdism += 1
			glassqw = 2
			glass = 1
			blizoruk += 1
			act 'Выйти': gt'poli','start'
		end
	end
	if money >= 1000:
		if health < (vital*10 + stren*5):
			act 'Лечить здоровье (1000 руб)':
				cla
				money -= 1000
				minut += 60
				health = 100
				if hosprand <= 2: gt 'poli', str(hosprand)
				gs 'zz_render', '', '', func('poli_strings', 'local_str3')
				act 'Выйти':gt'poli','start'
			end
		end
		if crazy >= 7:
			act 'Идти к Психотерапевту (1000 руб)':
				cla
				money -= 1000
				minut += 60
				crazy = 0
				manna = 100
				if hosprand <= 2: gt 'poli', str(hosprand)
				gs 'zz_render', '', '', func('poli_strings', 'local_str4')
				act 'Выйти': gt 'poli','start'
			end
		end
		if venosm = 0:
			act 'Идти к Венерологу (1000 руб)':gt'venta','ven'
		end
		if venosm = 1:
			venosm = 0
			act 'Идти к Венерологу':
				cla
				*clr
				minut += 6
				gs 'stat'
				gs 'zz_render', '', 'city/south/clinic/gynecologist/0.jpg', func('poli_strings', 'local_str5')
				if venera > 0:venosm = 0 & 'Врач состроил скорбную мину и сообщил, что у вас не все гладко с анализами.'
				if GerpesOnce = 1:
				gs 'zz_render', '', '', func('poli_strings', 'local_str6')
				if Gerpes >= 3:
					if GerpesNapr = 0:GerpesNapr = 3 & 'Вот вам направление на уколы от герпеса. Необходимо 3 укола, вы должны будете оплатить стоимость лекарств, это 1000 рублей.'
					if GerpesNapr > 0:'Сходите на уколы от герпеса, направление я вам выдал.'
				else
					gs 'zz_render', '', '', func('poli_strings', 'local_str7')
				end
			end
			if SifacOnce = 1:
				gs 'zz_render', '', '', func('poli_strings', 'local_str8')
				if Sifilis < 15:
					gs 'zz_render', '', '', func('poli_strings', 'local_str9')
				else
					if SifNapr = 0:SifNapr = 10 & 'Вот вам направление на уколы от сифилиса. Необходим курс из 10ти уколов, каждый укол будет стоить 5000 рублей.'
					if SifNapr > 0:'Сходите на уколы от сифилиса. Курс долгий, 10 дней. Но это необходимо, заболевание тяжелое.'
				end
			end
			if TriperOnce = 1:
				gs 'zz_render', '', '', func('poli_strings', 'local_str10')
				if TriperNapr = 0:TriperNapr = 5 & 'Вот вам направление на уколы от гонореи. Необходимо 5ть уколов, каждый укол 1500 рублей'
			end
			if KandidozOnce = 1:
				gs 'zz_render', '', '', func('poli_strings', 'local_str11')
				if KandidNapr = 0:KandidNapr = 1 & 'В аптеке можете купить таблетки.'
				if Kandidoz < 30:'Сейчас у вас кандидоз в неактивной стадии, принимайте витамины и он себя не проявит.'
			end
			if venera <= 0:venosm = 0 & 'Врач вас обрадовал тем что у вас нет венерических заболеваний.'
			act 'Выйти':gt'poli','start'
		end
		end
		if GerpesNapr > 0 and GerpesUkolDay ! day:
			act 'Идти на уколы от герпеса (1000 руб). Осталось <<GerpesNapr>> укола по направлению':
				cla
				*clr
				money -= 1000
				minut += 60
				GerpesUkolDay = day
				GerpesNapr -= 1
				gs 'stat'
				gs 'zz_render', '', 'city/south/clinic/gynecologist/1.jpg', func('poli_strings', 'local_str12')
				if GerpesNapr = 0:Gerpes = -10 & 'Это был последний укол'
				act 'Выйти':gt'poli','start'
			end
		end
	end
	if money >= 1500 and TriperNapr > 0 and TriperUkolDay ! day:
		act 'Идти на уколы от гонореи (1500 руб). Осталось <<TriperNapr>> укола по направлению':
			cla
			*clr
			money -= 1500
			minut += 60
			TriperUkolDay = day
			TriperNapr -= 1
			gs'stat'
			gs 'zz_render', '', 'city/south/clinic/gynecologist/1.jpg', func('poli_strings', 'local_str13')
			if TriperNapr = 0:Triper = 0 & Venera -= 1 & TriperOnce = 0 & 'Это был последний укол'
			act 'Выйти':gt'poli','start'
		end
	end
	if money >= 5000 and SifNapr > 0 and SifUkolDay ! day:
		act 'Идти на уколы от сифилиса (5000 руб). Осталось <<SifNapr>> укола по направлению':
			cla
			*clr
			money -= 5000
			minut += 60
			SifUkolDay = day
			SifNapr -= 1
			gs'stat'
			gs 'zz_render', '', 'city/south/clinic/gynecologist/1.jpg', func('poli_strings', 'local_str14')
			if SifNapr = 0:Sifilis = 0 & 'Это был последний укол'
			act 'Выйти':gt'poli','start'
		end
	end
	if money >= 20000 and preg = 1 and pregtime < 84:
		act 'Сделать аборт (20000 руб)':
			cla
			vidage += 1
			abort += 1
			money -= 20000
			pregtime = 0
			pregtalk = 0
			abortrand = RAND(0,10)
			if age > 18:
				if abortrand < 10:preg = 0
				if abortrand = 10:preg = 2
			else
				if abortrand < 4:preg = 0
				if abortrand >= 5:preg = 2
			end
			gs 'zz_render','','', func('poli_strings', 'local_str15')
			act 'Выйти': gt'poli','start'
		end
	end
	if money >= 50000 and KandidozOnce = 1 and week = 1 and day <= 10:
		act 'Лечь в платную клинику для полного уничтожения вируса молочницы (50000 руб)':
			cla
			*clr
			money -= 50000
			day += 3
			week += 3
			KandidozOnce = 0
			Kandidoz = 0
			gs'stat'
			gs 'zz_render', '', 'city/south/clinic/gynecologist/1.jpg', func('poli_strings', 'local_str16')
			act 'Выйти':gt'poli','start'
		end
	end
	if money >= 150000 and GerpesOnce = 1 and week = 1 and day <= 10:
		act 'Лечь в платную клинику для полного уничтожения вируса герпеса (150000 руб)':
			cla
			*clr
			money -= 150000
			day += 3
			week += 3
			GerpesOnce = 0
			Gerpes = 0
			Venera -= 1
			gs'stat'
			gs 'zz_render', '', 'city/south/clinic/gynecologist/1.jpg', func('poli_strings', 'local_str17')
			act 'Выйти':gt'poli','start'
		end
	end
	if money >= 350000 and SifacOnce = 1 and week = 1 and day <= 10:
		act 'Лечь в платную клинику для полного уничтожения сифилиса (350000 руб)':
			cla
			*clr
			money -= 350000
			day += 3
			week += 3
			SifacOnce = 0
			Sifilis = 0
			Venera -= 1
			gs'stat'
			gs 'zz_render', '', 'city/south/clinic/gynecologist/1.jpg', func('poli_strings', 'local_str18')
			act 'Выйти':gt'poli','start'
		end
	end
	if preg = 1 and pregtime = 280:
		act 'Родить':
			cla
			xgt 'gameover',3
			exit
		end
	end
	if sick > 0 and polisickday ! day:
		act 'Идти на прием к Терапевту':
			cla
			*clr
			polisickday = day
			gt 'poli', 'drPP'
		end
	end
	if katjob > 0:act 'Зайти к Главврачу':gt'poli','glavdoc'
	if zub > 0:
		act 'Идти к Стоматологу':
			*clr & cla
			zubpay = zub*30000
			gs'stat'
			gs 'zz_render', '', '', func('poli_strings', 'local_str19')
			act 'Уйти из поликлиники':gt'street'
			if money >= zubpay:
				act 'Оплатить протезирование':
					*clr & cla
					money -= zubpay
					minut += 60
					zub = 0
					gs'stat'
					gs 'zz_render', '', '', func('poli_strings', 'local_str20')
					act 'Уйти из поликлиники':gt'street'
				end
			end
		end
	end
	if anus > 5:
		act 'Идти к Проктологу':
			*clr & cla
			minut += 15
			if analplugIN ! 0:analplugIN = 0
			gs'stat'
			gs 'zz_render', '', 'images/picb/ass/<<anpic>>.jpg', func('poli_strings', 'local_str21')
			if anus <= 15:
				gs 'zz_render', '', '', func('poli_strings', 'local_str22')
			elseif anus > 15 and anus <= 25:
				gs 'zz_render', '', '', func('poli_strings', 'local_str23')
			elseif anus > 25 and anus <= 35:
				gs 'zz_render', '', '', func('poli_strings', 'local_str24')
			elseif anus > 35:
				gs 'zz_render', '', '', func('poli_strings', 'local_str25')
			end
			if money >= 1000 and anus > 15 and proktologday ! day:
				act 'Оплатить процедуру':
					*clr & cla
					money -= 1000
					minut += 60
					proktologday = day
					anus -= 5
					gs'stat'
					gs 'zz_render', '', 'images/picb/ass/<<anpic>>.jpg', func('poli_strings', 'local_str26')
					act 'Уйти из поликлиники':gt'street'
				end
			end
			act 'Уйти из поликлиники':gt'street'
		end
	end
	act 'Идти к Окулисту':
		*clr & cla
		gs 'stat'
		if blizoruk < 100:
			gs 'zz_render', '', '', func('poli_strings', 'local_str45')
		else
			gs 'zz_render', '', '', func('poli_strings', 'local_str27')
			if glass = 1: gs 'zz_render', '', '', func('poli_strings', 'local_str44')
		end
		act 'Уйти из поликлиники': gt'street'
		if blizoruk < 100:
			act 'Спросить о цветных линзах':
				cla
				gs 'zz_render', '', '', func('poli_strings', 'local_str46')
				if money >= 20000:
					act 'Купить линзы (20000 руб)':
						*clr & cla
						colorful_lenses = 30
						minut += 30
						money -= 20000
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/colorful_lenses.jpg', func('poli_strings', 'local_str47')
						act 'Уйти': gt 'street'
					end
				end
				act 'Уйти': gt 'street'
			end
		end
		if money >= 8000 and glass = 1:
			act 'Купить очки (8000 руб.)':
				*clr & cla
				money -= 8000
				minut += 10
				glass = 2
				gs 'stat'
				gs 'zz_render', '', '', func('poli_strings', 'local_str28')
				act 'Уйти из поликлиники': gt'street'
			end
		end
		if money >= 15000 and (glass = 1 or glass = 2):
			act 'Купить дорогие модные очки (15000 руб.)':
				*clr & cla
				money -= 15000
				minut += 10
				glass = 3
				gs 'stat'
				gs 'zz_render', '', '', func('poli_strings', 'local_str28')
				act 'Уйти из поликлиники': gt'street'
			end
		end
		if money >= 100000 and glass ! 0:
			act 'Оплатить лазерную коррекцию':
				*clr & cla
				money -= 100000
				minut += 60
				blizoruk = 0
				glass = 0
				gs 'stat'
				gs 'zz_render', '', '', func('poli_strings', 'local_str29')
				act 'Уйти из поликлиники':gt'street'
			end
		end
	end
end
if $ARGS[0] = 'drPP':
	cla
	*clr
	minut += RAND(3,10)
	gs 'stat'
	gs 'zz_render', '', '', func('poli_strings', 'local_str30')
	act 'Войти в кабинет':
		cla
		*clr
		'<center><img src="images/add-on/drPP.jpg"></center>'
		if drPP = 0:'За столом сидит пожилой лысоватый мужчина благообразной наружности. "Здравствуйте, больная. Меня зовут Петр Петрович, я ваш участковый терапевт, - говорит он, разглядывая вас сквозь очки".'
		if drPP = 1:'За столом сиди Петр Петрович. Он улыбается вам и говорит: "Здравствуйте, больная.'
		drPP = 1
		gs 'zz_render', '', '', func('poli_strings', 'local_str31')
		act 'Жаловаться':
			cla
			*clr
			minut += 5
			gs 'zz_render', '', '', func('poli_strings', 'local_str32')
			act 'Выполнять указания врача':
				cla
				minut += 20
				gs 'zz_render', '', 'images/inBed/ninel03', func('poli_strings', 'local_str33')
				act 'Идти домой': gt'street'
			end
		end
	end
end
if $ARGS[0] = 'glavdoc':
	minut += 5
	gs 'zz_render', '', '', func('poli_strings', 'local_str34')
	if work = 0 and workhosp = 0:
		act 'Устроиться на работу':
			cla
			workhosp = 1
			work = 1
			gs 'zz_render', '', '', func('poli_strings', 'local_str35')
			act 'Выйти':gt'poli','start'
		end
	end
	if workhosp = 1:act 'Уволиться':gt'poli','discharge'
	act 'Выйти':gt'poli','start'
end
if $ARGS[0] = 'beginwork':
	cla
	*clr
	'<center><b><font color = maroon>Поликлиника</font></b></center>'
	gs 'zz_render', '', 'images/img/spaln/hospital.jpg', func('poli_strings', 'local_str36')
	act 'Начать работу':
		smena += 1
		gt'WorkHosp','start'
	end
	act 'Уволиться':gt'poli','discharge'
end
if $ARGS[0] = 'discharge':
	cla
	minut += 10
	workhosp = 0
	work = 0
	pay = smena * 1000
	money += pay
	smena = 0
	gs 'zz_render', '', '', func('poli_strings', 'local_str37')
	act 'Уйти':gt'street'
end
if $ARGS[0] = '0':
	cla
	*clr
	gs 'zz_render', '', 'images/img/spaln/hospsex1.jpg', func('poli_strings', 'local_str38')
	act 'Послать его':gt'poli','start'
	act 'Развлечься':
		picrand = 11
		guy += 1
		xgt'sex','var'
	end
end
if $ARGS[0] = '1':
	cla
	*clr
	gs 'zz_render', '', 'images/img/spaln/hospsex2.jpg', func('poli_strings', 'local_str39')
	act 'Послать их':gt'poli','start'
	act 'Развлечься':
		picrand = 11
		guy += 2
		xgt'sexdvoe','var'
	end
end
if $ARGS[0] = '2':
	cla
	*clr
	gs 'zz_render', '', 'images/img/spaln/hospsex3.jpg', func('poli_strings', 'local_str40')
	act 'Уйти':gt'poli','start'
	act 'Войти в кабинет':
		cla
		*clr
		gs 'zz_render', '', 'images/img/spaln/hospsex4.jpg', func('poli_strings', 'local_str41')
		act 'Уйти':gt'poli','start'
		act 'Позволить ей':
			cla
			*clr
			guy += 1
			girl += 1
			lesbian += 1
			gs 'zz_render', '', 'images/img/spaln/hospsex5.jpg', func('poli_strings', 'local_str42')
			act 'Лизать ей':
				cla
				*clr
				gs 'zz_render', '', 'images/img/spaln/hospsex6.jpg', func('poli_strings', 'local_str43')
				act 'Продолжать втроем':picrand = 11 & gt'podrsex','var'
			end
		end
	end
end