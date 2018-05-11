gs 'go_time'
clr
! очистка временных переменных системы достижений
gs 'zz_achievements','clear_ach_variables'
! ---
! автоприменение салфеток
if $settings['auto_wipes'] = 1: gs 'zz_common','wet_wipes',1
! наркомания
gs 'zz_drugs','set_values'
!---
if hour >= 21 and week = 7 and family_trip_month ! month: family_trip_month = month & family_trip = 0
! --
gs 'uni_events','university_status'
! --
!расчет попоболь
stat_vgape = vgape/24
stat_agape = agape/24
if analplay >= 2 and anus <= 10:anus += 1 & analplay = 0
if analplay >= 4 and anus <= 15:anus += 1 & analplay = 0
if analplay >= 8 and anus <= 20:anus += 1 & analplay = 0
!!!CHEATS!!!
if cheatHapri = 1:hapri = 1
!!!!!!!!!!!!
if alko > 0: frost = 0
if func('zz_reputation','get') > 0:
	$_gnik[0] = 'соска'
	$_gnik[1] = 'давалка'
	$_gnik[2] = 'безотказная давалка'
	$_gnik[3] = 'шлюха'
	$gnikname = $_gnik[func('zz_reputation','get')-1]
	killvar '$_gnik'
end
!!!Новая формула развратности основана на собранной статистике.(старая формула: shameless = guy+bj+anal+hj+(slutty*2)+(gang*2))
shameless['main'] = (mastr/3) + (rape/3) + (frot/3) + (voyeurism/3) + (cumfrot/3) + sex + bj + hj + kuni + piss + lesbian + stripdance+ modelfoto + (exhibi*3) + (stripdancesum*3) + (anal*3) + (spank*3) + (swallow*3) + (facial*3) + (throat*3) + (gang*6) + (slutty*6) + (film*9)
!!!Граничные значения специально вынесены отдельно чтобы можно было их поменть в будущем на основе собранных отзывов.
shameless['limit_1'] = 27
shameless['limit_2'] = 81
shameless['limit_3'] = 243
!!! Логика использования следующая:
! В эвентах, для единообразия рекомендуется использовать только переменную shameless['flag']
! shameless['flag'] = 0 - ГГ соверщенно не развратна
! shameless['flag'] = 1 - ГГ потеряла стеснение (например может раздеться на пляже)
! shameless['flag'] = 2 - ГГ потряла всякий стыд за свои действия и может например предложить минет на первых минутах знакомства.
! shameless['flag'] = 3 - ГГ максимально развратна и готова учствовать в любых извращениях.
if shameless['main'] < shameless['limit_1']:
	shameless['flag'] = 0
elseif shameless['main'] >= shameless['limit_1'] and shameless['main'] < shameless['limit_2']:
	shameless['flag'] = 1
elseif shameless['main'] >= shameless['limit_2'] and shameless['main'] < shameless['limit_3']:
	shameless['flag'] = 2
elseif shameless['main'] >= shameless['limit_3']:
	shameless['flag'] = 3
end
!cumSUM = cumbelly+cumpussy+cumass+cumlip+cumface+cumfrot+cumanus
if husbizvradd > 5:izvratH = 1
if husbharmin > 10:harakHusb = 0
if husband = 0:
	husbizvradd = 0
	husbharmin = 0
	husbandMark = 0
end
Venera = 0
if VeneraOnce > 0: VeneraOnce = 0
if SifacOnce = 1: Venera += 1
if GerpesOnce = 1: Venera += 1
if TriperOnce = 1: Venera += 1
!-------
father['horny'] = func('zz_funcs','checker',father['horny'])
poSkill = func('zz_funcs','checker',poSkill,0,1000)
vokal = func('zz_funcs','checker',vokal)
dance = func('zz_funcs','checker',dance)
stripdance = func('zz_funcs','checker',stripdance)
poledance = func('zz_funcs','checker',poledance)
goforest = func('zz_funcs','checker',goforest)
bucket = func('zz_funcs','checker',bucket,0,10)
beg = func('zz_funcs','checker',beg,0,2000)
oficiant = func('zz_funcs','checker',oficiant)
vagina = func('zz_funcs','checker',vagina)
throat = func('zz_funcs','checker',throat)
anus = func('zz_funcs','checker',anus)
Jab = func('zz_funcs','checker',Jab,0,120)
Punch = func('zz_funcs','checker',Punch,0,120)
Kik = func('zz_funcs','checker',Kik,0,120)
KikDef = func('zz_funcs','checker',KikDef,0,120)
boxing = func('zz_funcs','checker',boxing)
stren = func('zz_funcs','checker',stren)
speed = func('zz_funcs','checker',speed)
agil = func('zz_funcs','checker',agil)
react = func('zz_funcs','checker',react)
vital = func('zz_funcs','checker',vital)
intel = func('zz_funcs','checker',intel)
dom = func('zz_funcs','checker',dom,-100,100)
horny = func('zz_funcs','checker',horny)
health = func('zz_funcs','checker',health)
stat_vgape = func('zz_funcs','checker',stat_vgape,0,3)
stat_agape = func('zz_funcs','checker',stat_agape,0,3)
spanked = func('zz_funcs','checker',spanked)
!--
if bfa < 0:bfa = 0
if vidageday <= 0:
	vidageday = 360
	vidage += 1
end
!!!!!!!!!!!
!!!ВРЕМЯ!!!
!!!!!!!!!!!
if manna >= (100 - spanked): manna= 100 - spanked
if minut >= 60:
	:loopmin
	!Боль в дырках -1 час
	if vgape > 0: vgape -= 1
	if agape > 0: agape -= 1
	if nerdism > 0:
		nerdism -= 1
		manna -= 4 - nerdism/20
	end
	! не спать - вредно для настроения и здоровья
	if no_sleep_time > 0:
		manna -= 5
		health -= 2
	end
	! попоболь, снижение на 1 в час
	if spanked > 0: spanked -= 1
	! ---
	if obkvsdam > 0: obkvsdam = RAND(2,5)
	hour += 1
	if energy < 8:
		manna -= 2
		hungry_time += 1
	end
	! сброс голодовки
	if energy >= 24: hungry_time = 0
	energy -= 1
	water -= 1
	if water < 8: manna -= 2
	if InSleep = 0: son -= 1
	minut -= 60
	if alko > 0:
		if alko >= 6 and alkoday ! day:
			alkoday = day
			if beg > 0: beg -= 1
			if volleyboll > 0: volleyboll -= 1
			if stren > 10: stren -= 1
			if vital > 10: vital -= 1
			if react > 10: react -= 1
			if speed > 10: speed -= 1
			if agil > 10: agil -= 1
			if intel > 10: school['intellect'] -= 1
			if Jab > 50: Jab -= 1
			if Punch > 50: Punch -= 1
			if Kik > 50: Kik -= 1
			if KikDef > 50: KikDef -= 1
		end
		alko -= 1
	end
	! check cum status
	if cumface > 0: cumface -= 1
	if cumlip > 0: cumlip -= 1
	if cumbelly > 0: cumbelly -= 1
	if cumass > 0: cumass -= 1
	if cumpussy > 0: cumpussy -= 1
	if cumanus > 0: cumanus -= 1
	! ---
	if lipbalmstat > 0: lipbalmstat -= 1
	if sickstage = 1: sick += 1 & sicktimer += 1
	if sickstage = 1 and sicktimer >= 80: sicktimer = 0 & sickstage = 2
	if sickstage = 2 and sick > 0: sick -= 1
	if sickstage = 2 and sick <= 0: sick = 0 & sickstage = 0
	if frost > 0: frost -= 1
	! vovan edition
	if sweat > 2: gs 'zz_funcs','skin','-'
	if clearclothes > 0: clearclothes -= 1
	if hantersAndreisex > 0: hantersAndreisex -= 1
	if hantersSergeisex > 0: hantersSergeisex -= 1
	if hantersIgorsex > 0: hantersIgorsex -= 1
	if hantslutsex > 0: hantslutsex -= 1
	if mira_dog > 0: mira_dog - 1
	if mira_go_blok > 0: mira_go_blok -= 1
	if lost_girl > 0: lost_girl -= 1
	if mira_no_home > 0: mira_no_home -= 1
	!---
	! износ белья
	gs 'zz_clothing2','panty_check'
	!---
	! наркомания
	gs 'zz_drugs','hour_recalc'
	!---
	! проверка статуса ветки Царева - Светка прогуляла свидание - закрываем ветку
	if ($npc['26,qwMain'] = 116 or $npc['26,qwMain'] = 118) and $npc['26,qwMain_day'] ! day and hour >= 21: $npc['26,qwMain'] = 255
	!---
	if minut >= 60: minut_global += 60 & jump 'loopmin'
	minut2 = 0
end
minut_global += minut - minut2
minut2 = minut
if hour >= 24:
	if parentsexday >= 0: parentsexday = -1
	!---
	if painpub > 0: painpub -= 1
	if nippain > 0: nippain -= 1
	! дневное улучшение репутации на всех контрольных точках
	gs 'zz_reputation','increase_all'
	! счетчик дней в ивенте с прогулами
	if absent['stage'] >= 4: absent['daycounter'] += 1
	! счетчик оплаты кружка Сони
	if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] < 255: $npc['25,qwSonya_payday'] += 1
	! проверка местожительства Кати Мейнольд
	! 0 - в сити
	! 1 - в городке
	$npc['14,homeward'] = iif($npc['14,qwKatya'] >= 200 and week <= 5,0,1)
	! сброс тройничка с Катей, если ГГ не пришла
	if $npc['14,qwKatya'] = 72 and $npc['14,qwKatya_trio_day'] < daystart: $npc['14,qwKatya'] = 75
	$npc['14,qwKatya_disco'] = 0
	! проверка падения Сони
	if $npc['25,qwSonya'] >= 1 and $npc['25,qwSonya'] < 5: $npc['25,qwSonya'] = 5
	! пересчет школьных статов
	gs 'zz_school','recalc_stats'
	! время входного звонка
	next_call_time = 16*60 + rand(0,59)
	Gcall = 0
	!Wannabe: Здесь обнуляется переменная отвечающая за ограничение гринда подглядывания на пляже в день.
	voyeurism_nudist = 0
	!износ контактных линз
	if colorful_lenses > 0: colorful_lenses -= 1
	if blizoruk < 200: blizoruk -= 1
	if blizoruk < 0: blizoruk = 0
	! ---
	!суточное падение уровня знаний в универе
	if university['vacation'] = 0 and week < 6: university['progress'] -= 1
	if university['progress'] < 0: university['progress'] = 0
	! remove sister`s book
	reading['sister_book'] = -1
	reading['read_per_day'] = 0
	!reading['in_bag'] = -1
	! set father`s stats
	father['talk_count'] = 0
	mother['talk_count'] = 0
	if father['horny'] >= 100: father['horny'] = 0
	father['horny'] += rand(10,20)
	father['in_garage'] = 0
	father['drunk_reaction'] = 0
	! --
	brother_tv_enable = 0
	mother_drunk_reaction = 0
	! --
	! сброс флага отказа от вечеринки
	if sisboyparty = -1 and week = 7: sisboyparty = 1
	! протекание крыши
	! если меньше 1/10 max
	if manna < 10: crazy += 1
	if no_sleep_time >= 36: crazy += 1
	! если настроение больше 1/10 но меньше 1/4 - счетчик не обнуляем, но и не приращиваем
	! если настроение больше 1/4 max - отнимаем
	if manna >= 25 and crazy > 0: crazy -= 1
	if crazy >= 12: gt 'gameover',1
	!---
	! сброс счетчиков работы в кафешках
	gs 'zz_cafe','reset_work'
	!--
	condomProver += 1
	discoclose = 0
	trenerskaia = 0
	coffee_drink = 0
	if pirs_pain_ton > 0:pirs_pain_ton -= 1
	if brow > 19: brow = 19
	if brow > 0: brow -= 1
	if shorthair > 0:
		shorthairday += 1
		if shorthairday >= 60: shorthairday = 0 & shorthair -= 1
	end
	!if volleysostav > 0: gs 'npc_editor','change_rep','-',28
	!if birthday = day and birthmonth = month:
		!день рождения
		!age += 1
	!end
	if horny > hornyStat:
		hornyStat = horny
		if pirsA > 0: horny += 1
		if pirsB > 0: horny += 1
		if pirsC > 0: horny += 1
		if pirsD > 0: horny += 1
		if pirsE > 0: horny += 1
		if pirsF > 0: horny += 5
		if pirsG > 0: horny += 5
		if pirsN > 0: horny += 1
		if pirsGL > 0: horny += 5
	end
	if horny < hornyStat: hornyStat = horny
	dmishaevent = 0
	!Квартира в Южном райне
	if ArendHouseSL > 0:ArendHouseSL -= 1
	if ArendHouseSL <= 0:ArendHouseSL = 0
	housr = iif(ArendHouseSL > 0 or BuyHous = 1,1,0)
	if sdaday > 0: sdaday -= 1
	if sdaday = 0 and sdamonth = 1:
		sdamonth = 0
		BuyHous = 1
		gs 'zz_render','','','<red>Срок аренды вашей квартиры истёк, вам вернули ключи.</red>'
	end
	if repairs_time > 0: repairs_time -= 1
	if repairs_time = 0:
		if repairs_bedr > 0: rembedr = repairs_bedr & repairs_bedr = 0
		if repairs_sitr > 0: remsitr = repairs_sitr & repairs_sitr = 0
		if repairs_korr > 0: remkorr = repairs_korr & repairs_korr = 0
		if repairs_vanr > 0: remvanr = repairs_vanr & repairs_vanr = 0
		if repairs_kuhr > 0: remkuhr = repairs_kuhr & repairs_kuhr = 0
	end
	if husband > 0 and husbandrink ! 11:husbandrink = RAND(0,10)
	if Gspravka <= 0 and GspravkaT > 0:GspravkaT = 0 & Gspravka = 0
	if GspravkaT > 0:Gspravka -= 1
	if $npc['0,qwIvanPodstava'] = 2 and PodpiskaNeviezd = 30: $npc['0,qwIvanPodstava'] = 3
	if $npc['0,qwIvanPodstava'] = 2 and PodpiskaNeviezd > 0 and PodpiskaNeviezd < 30: PodpiskaNeviezd += 1
	inWorkYoungShop = 0
	husbandsexday = 0
	borsexkol = 0
	givisexday = 0
	! vovan
	if graze_cow > 0 and hour > 20:graze_cow = 0 & grandpaQW -= 5
	anuta['horny'] = rand(40,100)
	fishers = 0
	hanters_check = 0
	mushroom_pickers = 0
	horse_river = 0
	haying_time = 0
	mira_go_river = 0
	forestpicnic = 0
	if Mira_no > 0:Mira_no -= 1
	grandpa_notalk = 0
	grandma_notalk = 0
	if gadukino_nude > 0:gadukino_nude += 1
	if fishers_nude > 0:fishers_nude += 1
	if gadukino_blok = 1 and $npc['37,relation'] >= 80:grandpaQW += 1 & grandmaQW += 1
	!прогул работы на фабрике в Павлово
	if workFabrika = 1 and week <= 5:FabrikaProgul += 1
	! Счетчик прогулов на рынке городка у Артура
	if $npc['40,qwArtur'] = 2:artur_absence += 1
	!прогул работы на фабрике на Южном рынке
	if workrin = 1 and (week = 2 or week = 4 or week = 6):workrin_hooky += 1
	!прогул работы в КП Логистика в Южном районе
	if logist >= 10 and week < 6:
		logist_progul += 1
		logist_hours = -2
	end
	!---
	!if shantsr > 0:
	!	pay = shantsr*5000
	!	karta += pay
	!	shantsr = 0
	!end
	petersexday = 0
	:loop
	day += 1
	daystart += 1
	week += 1
	hour -= 24
	killvar '$holiday'
	gs 'zz_school','vacation_status'
	!ЗПП
	if SifacOnce = 1:Sifilis += 1
	if GerpesOnce = 1:Gerpes += 1
	if TriperOnce = 1:Triper += 1
	if KandidozOnce = 1:Kandidoz += 1
	beg -= iif(beg >= 100, beg / 500, 0)
	vidageday -= 1
	if husband > 0:husbanday += 1
	if husband > 10 and husbanday > 0:husband -= 15
	if husbandMark = 1 and husband <= 10:
		husbizvradd = 0
		husbharmin = 0
		husbandMark = 0
		husband = 0
		divorced += 1
		gs 'zz_render','','','<red>Ваш муж подал на развод.</red>'
	end
	gs 'cikl'
	! суточные пересчеты для порностудии
	if studio['init'] = 1: gs 'zz_pornstudio','update_info'
	banda['counter'] = 0
	! сброс счетчиков разговоров с нпс
	gs 'npc_editor','reset_talking'
	!---
	if internet > 0: internet -= 1
	!---
	sport = 0
	workout = 0
	if abonement > 0: abonement -= 1
	!---
	if hour >= 24: jump 'loop'
end
!Выплаты
if day = 25:
	! -- meynold payment ---!
	if $npc['45,qwTamara'] >= 3 and $npc['45,qwTamara'] ! 50 and $npc['0,mey_help_count'] >= 10:
		money += 5000
		gs 'zz_render','','','<green>За ваши труды тетя Тамара вручила вам 5000 рублей</green>'
		$npc['0,mey_help_count'] = 0
	end
	!--
	if PersSecWork = 1 and PersSecWorkTimes > 0 and paydaybistrosec = 0:
		Pay = PersSecWorkTimes*2500
		PersSecWorkTimes = 0
		money += Pay
		paydaybistrosec = 1
		gs 'zz_render','','','<green>Вам перечислили <<pay>> рублей зарплаты за работу секретаршей.</green>'
	end
	if workKafe = 1 and paydayKafe = 0:
		paydayKafe = 1
		pay = smenaKafe*750
		money += pay
		smenaKafe = 0
		gs 'zz_render','','','<green>Вам перечислили <<pay>> рублей зарплаты за работу официанткой в кафе.</green>'
	end
	if worksalon = 1 and nopaysalon = 0:
		pay = smena*800
		money += pay
		smena = 0
		nopaysalon = 1
		gs 'zz_render','','','<green>Вам перечислили <<pay>> рублей зарплаты за работу в салоне красоты.</green>'
	end
	if tanwork = 1 and nopaytanwork = 0:
		nopaytanwork = 1
		money += 25000
		gs 'zz_render','','','<green>Вам перечислили 25000 рублей зарплаты за работу гувернанткой.</green>'
	end
	if workSec = 1 and paydaySec = 0:
		paydaySec = 1
		pay = sekDay*1000
		if officebestslut >= 3:pay += 20000
		karta += pay
		sekDay = 0
		gs 'zz_render','','','<green>Вам перечислили на банковский счет <<pay>> рублей зарплаты за работу секретаршей.</green>'
	end
	if workFabrika = 1 and paydayFabrika = 0:
		paydayFabrika = 1
		pay = smenaFabrika*300
		money += pay
		smenaFabrika = 0
		gs 'zz_render','','','<green>Вам перечислили <<pay>> рублей зарплаты за работу на фабрике.</green>'
	end
	if husband > 0 and paydayHusb = 0:
		paydayHusb = 1
		if husbFin = 0: huspay = 15000
		if husbFin = 1: huspay = 30000
		if husbFin = 2: huspay = 60000
		money += huspay
		gs 'zz_render','','','<green>Вашему мужу перечислили зарплату на банковский счёт, в количестве <<huspay>> рублей.</green>'
	end
	if university['student'] = 2 and university['scholarship'] > 0 and university['scholarship_day'] = 0:
		university['scholarship_day'] = 1
		karta += university['scholarship']
		gs 'zz_render','','','<green>Вам перечислили <<university[''scholarship'']>> рублей стипендии.</green>'
	end
	gs 'apartment_south_event', 'rent'
end
if day ! 25:
	if university['scholarship_day'] = 1: university['scholarship_day'] = 0
	if paydayHusb = 1:paydayHusb = 0
	if workKafe = 1 and paydayKafe = 1:paydayKafe = 0
	if workSec = 1 and paydaySec = 1:paydaySec = 0
	if workFabrika = 1 and paydayFabrika = 1:paydayFabrika = 0
	if housr = 1 and haday = 1: haday = 0
	if housr = 1 and electroday = 1:electroday = 0
	if housr = 1 and kabel > 0 and kabelday = 1:kabelday = 0
	if stipuhaday = 1:stipuhaday = 0
	if nopaytanwork = 1:nopaytanwork = 0
	if nopaypoly = 1:nopaypoly = 0
	if nopaysalon = 1:nopaysalon = 0
	if paydaybistrosec = 1:paydaybistrosec = 0
end
if month < 1: month = 1
if month = 1 or month = 3 or month = 5 or month = 7 or month = 8 or month = 10 or month = 12:
	!31
	if day > 31:day -= 31 & month += 1
elseif month = 2:
	!28
	if day > 28:day -= 28 & month += 1
elseif month = 13:
	month = 1
	year += 1
	if day > 31:day -= 31 & month += 1
else
	!30
	if day > 30:day -= 30 & month += 1
end
if day = 0: day = 1
! фикс возраста для читов
if year - birthyear > age:
	if month > birthmonth:
		age += 1
	elseif month = birthmonth:
		if day >= birthday: age += 1
	end
end
if week > 7:
	! кружок Сони
	if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] < 255:
		if $npc['25,qwSonya_payday'] >= 5:
			! закрываем ветку, если ГГ не оплатила кружок Сони
			$npc['25,qwSonya'] = 255
		else
			! сброс счетчика оплаты кружка Сони
			$npc['25,qwSonya_payday'] = 0
		end
	end
	! перечисляем деньги за работу в службе такси
	karta += uber['work_week_count'] * iif(uber['work_count'] < 20,600,800)
	uber['work_week_count'] = 0
	uber['work_week'] = iif(uber['work_week']=1,2,1)
	:loopweek
	week -= 7
	husbandrink = 0
	if week > 7: jump 'loopweek'
end
$_week[0] ='Понедельник'
$_week[1] = 'Вторник'
$_week[2] = 'Среда'
$_week[3] = 'Четверг'
$_week[4] = 'Пятница'
$_week[5] = 'Суббота'
$_week[6] = 'Воскресенье'
$week = $_week[week-1]
killvar '$_week'
$_month[0] = 'января'
$_month[1] = 'февраля'
$_month[2] = 'марта'
$_month[3] = 'апреля'
$_month[4] = 'мая'
$_month[5] = 'июня'
$_month[6] = 'июля'
$_month[7] = 'августа'
$_month[8] = 'сентября'
$_month[9] = 'октября'
$_month[10] = 'ноября'
$_month[11] = 'декабря'
$month = $_month[month-1]
killvar '$_month'
!!!!!!!!!!!!!!!!!!!
!!!КОНЕЦ ВРЕМЕНИ!!!
!!!!!!!!!!!!!!!!!!!
subage = 0
:metakasubage
subage += 10
if subage+10 < age:
	jump'metakasubage'
else
	subage = age-subage
end
if subage = 0 or subage >= 5:
	$letgoda = 'лет'
elseif subage = 1:
	$letgoda = 'года'
else
	$letgoda = 'года'
end
subagevne = 0
:metakasubagevne
subagevne += 10
if subagevne+10 < vidage:
	jump'metakasubagevne'
else
	subagevne = vidage-subagevne
end
$letgoda2 = iif(subagevne ! 1, 'лет', 'года')
!!!!!!!!!!!!!
!!!ЭНЕРГИЯ!!!
!!!!!!!!!!!!!
if son < 0:
	! время без сна - при достижении 60 часов - gameover
	no_sleep_time += 1
	if no_sleep_time >= 60 and ($loc = 'gorodok' or $loc = 'center' or $loc = 'north' or $loc = 'south' or $loc = 'gadukino'): gt 'gameover',12
	!---
	son = 0
	manna -= 5
end
if son > 24: son = 24
if energy < 0:
	energy = 0
	health -= 1
end
if water < 0:
	water = 1
	health -= 1
end
if manna < 0: manna = 0
if health <= 0:
	gt 'gameover',0
	exit
end
!авто-повышение/понижение настроения после оргазма/изнасилования
if rape > 0 and rape ! rape_count and orgasm = orgasm_count:
	manna = 10
	rape_count = rape
elseif orgasm > 0 and orgasm ! orgasm_count:
	manna = 100
	orgasm_count = orgasm
elseif rape > 0 and rape ! rape_count and orgasm > 0 and orgasm ! orgasm_count:
	manna = 100
	orgasm_count = orgasm
	rape_count = rape
end
! ограничения на растянутость дырок
!if sex <= 5 and vagina > 5: vagina = 5
!if sex > 5 and sex <= 50 and vagina > 15: vagina = 15
!if sex > 50 and sex <= 200 and vagina > 25: vagina = 25
!if anal <= 5 and anus > 5: anus = 5
!if anal > 5 and anal <= 50 and anus > 15: anus = 15
!if anal > 50 and anal <= 200 and anus > 25: anus = 25
! ---
gs 'body'
!--
water = func('zz_funcs','checker',water,0,24)
energy = func('zz_funcs','checker',energy,0,24)
son = func('zz_funcs','checker',son,0,24)
manna = func('zz_funcs','checker',manna)
!--
!--- weather init
if weather_day ! day: gs 'zz_weather'
!---
!!!!!!!!!!!!!!!!!!!!!
!!!НАЧАЛО ОПИСАНИЯ!!!
!!!!!!!!!!!!!!!!!!!!!
p func('zz_weather','make_image',sunWeather,temper)
!--- menu
! картинка для кнопки персонажа
$_mnu_face_icon = str(hcol) + str(iif(shorthair >= 2,2,shorthair)) + str(iif(glass > 0,1,0))
$_mnu_buttons = '<div id="zz_user_menu">'
$_mnu_buttons += '<div class="tip" title="<font color=black>Персонаж</font>"><a href="exec:gt''menu_description''"><img src="images/common/icons/menu_faces/'+$_mnu_face_icon+'.png"></a></div>'
$_mnu_buttons += '<div class="tip" title="<font color=black>Телефон</font>"><a href="exec:gt''zz_phone''"><img src="images/common/icons/phone.png"></a></div>'
$_mnu_buttons += '<div class="tip" title="<font color=black>Сумочка</font>"><a href="exec:gt''menu_bag''"><img src="images/common/icons/bag.png"></a></div>'
$_mnu_buttons += '<div class="tip" title="<font color=black>Блокнот</font>"><a href="exec:gt''menu_notes''"><img src="images/common/icons/note.png"></a></div>'
$_mnu_buttons += '<div class="tip" title="<font color=black>Настройки</font>"><a href="exec:gt''zz_settings'',''tabs'',0"><img src="images/common/icons/settings.png"></a></div>'
$_mnu_buttons += '<div class="tip" title="<font color=black>Аварийка</font>"><a href="exec:gt''zz_common'',''error''"><img src="images/common/icons/warning.png"></a></div>'
$_mnu_buttons += '</div>'
p $_mnu_buttons
killvar '$_mnu_face_icon'
killvar '$_mnu_buttons'
!---
$_timebox = '<div class="time_box">'
$_timebox += '<div class="ui_time">'
$_timebox += iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''hours''">'+iif(hour<10,'0<<hour>>',hour)+'</a>:<a class="cheat" href="exec:gs''zz_cheats'',''minutes''">'+iif(minut<10,'0<<minut>>',minut)+'</a>',func('zz_funcs','make_datetime',hour,minut,':'))
$_timebox += '</div>'
$_timebox += iif($settings['cheats'] = 1,'<a class="cheat" href="exec:week+=1 & gs''stat''"><<$week>></a>',$week) + ', '
$_timebox += iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''day''"><<day>></a>',day) + ' '
$_timebox += iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''month''"><<$month>></a>',$month) + ' ' + year + ' года<br>'
$_timebox += '<b><img src="images/common/icons/money.png"> ' + iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''money''"><<money>></a>',money)
$_timebox += ' <img src="images/common/icons/card.png"> ' + iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''money'',0,1"><<karta>></a>',karta) + '</b></div>'
p $_timebox
killvar '$_timebox'
if birthday = day and birthmonth = month: pl '<b>Сегодня ваш день рождения.</b>'
p func('zz_funcs', 'scale', horny, 100, 1, iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''horny''">возбуждение</a>','возбуждение'))
p func('zz_funcs', 'scale', health, 100, 0, iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''health''">здоровье</a>','здоровье'))
p func('zz_funcs', 'scale', manna, 100, 0, iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''manna''">настроение</a>','настроение'))
p func('zz_funcs', 'scale', energy, 24, 0, iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''energy''">сытость</a>','сытость'))
p func('zz_funcs', 'scale', water, 24, 0, iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''water''">жажда</a>','жажда'))
p func('zz_funcs', 'scale', son, 24, 0, iif($settings['cheats'] = 1,'<a class="cheat" href="exec:gs''zz_cheats'',''son''">бодрость</a>','бодрость'))
p func('zz_funcs', 'scale', vnesh, 100,2, 'привлекательность')
!ArtRat
$double_button = '<div id="zz_user_menu">'
if $curloc = $control_point : $double_button += '<div class="tip" title="<font color=black>Карта</font>"><a href="exec: gs''zz_map_navigation'', ''button''"><img src="images/common/icons/map.png"></a></div>'
$double_button +='<div class="tip" title="<font color=black>Характеристики</font>"><a href="exec: gt ''menu_description'',''tabs'',1"><img src="images/common/icons/stat.png"></a></div>'
$double_button += '</div>'
p $double_button
killvar '$double_button'
!/ArtRat
if PillToggle = 1 and tabletki > 0:
	Stabletki += tabletki
	tabletki = 0
elseif PillToggle = 0 and Stabletki > 0:
	tabletki += Stabletki
	Stabletki = 0
end
if CondomToggle = 1 and condom > 0:
	Scondom += condom
	condom = 0
elseif CondomToggle = 0 and Scondom > 0:
	condom += Scondom
	Scondom = 0
end
if sweat > 4: sweat = 4
!if Gerpes >= 3: pl'<b><font color = red>На ваших губах язвочки. Все признаки генитального герпеса.</font></b>'
!if Gerpes < 10 and Gerpes >= 5: pl'<b><font color = red>Ваша киска покраснела и сильно зудит. Это генитальный герпес.</font></b>'
!if Gerpes >= 10: pl'<b><font color = red>На вашей киске появились язвочки. Это генитальный герпес.</font></b>'
!if Gerpes >= 20: pl'<b><font color = red>Вашу жопу покрывают язвочки генитального герпеса.</font></b>'
!if Sifilis >= 21 and Sifilis < 50: pl'<b><font color = red>У вас вскочила большая, твердая болячка на губе.</font></b>'
!if Sifilis >= 50: pl'<b><font color = red>Сифилитическая сыпь покрывает все ваше тело.</font></b>'
!if Triper > 2: pl'<b><font color = red>Из влагалища выходят белые выделения и сильная резь при мочеиспускании. Так же из влагалища сильно и противно пахнет.</font></b>'
!if Kandidoz > 30: pl'<b><font color = red>У вас молочница.</font></b>'
if meetday < daystart and svidanieA = 1: bfA -= 10 & svidanieA = 0
if nerdism > 100: nerdism = 100
!обнуление проверок на замужество
proverka1 = 0
proverka2 = 0
proverka3 = 0
proverka4 = 0
proverka5 = 0
! проверка открытия достижений
gs 'zz_achievements','check_ach'
! ---
! вывод статусов в накладку
gs 'zz_funcs','set_statuses'
!pl 'banda_stage: ' + banda['stage']
!pl 'banda_counter: ' + banda['counter']
!pl 'banda_location: ' + banda['location']
!pl 'banda_fail: ' + banda['fail']
pl '<a href="exec:gs''tester''">Run command</a>'
pl '<a href="exec:gs''zz_funcs'',''restart''">Restart game</a>'