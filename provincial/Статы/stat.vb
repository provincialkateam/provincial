clr
! ---
if father['horny'] > 100: father['horny'] = 100
if father['horny'] < 0: father['horny'] = 0
if hour >= 21 and week = 7 and family_trip_month ! month: family_trip_month = month & family_trip = 0
! --
gs 'university_events','university_status'
! --
if poSkill > 1000: poSkill = 1000
if nippain = 2:
	if nippainday+5 < daystart:
		$nippain = 'У вас сильно болят соски.'
		nippain = 1
		nippainday = daystart
	else
		$nippain = 'У вас сильно болят соски.'
	end
elseif nippain = 1:
	if nippainday+5 < daystart:
		$nippain = ''
		nippain = 0
	else
		$nippain = 'У вас немного болят соски.'
	end
end
if painpub = 2:
	if painpubday+5 < daystart:
		$painpub = 'У вас сильно болит влагалище.'
		painpub = 1
		painpubday = daystart
	else
		$painpub = 'У вас сильно болит влагалище.'
	end
elseif painpub = 1:
	if painpubday+5 < daystart:
		$painpub = ''
		painpub = 0
		painpubday = daystart
	else
		$painpub = 'У вас немного болит влагалище.'
	end
end
if analplay >= 2 and anus <= 10:anus += 1 & analplay = 0
if analplay >= 4 and anus <= 15:anus += 1 & analplay = 0
if analplay >= 8 and anus <= 20:anus += 1 & analplay = 0
!!!CHEATS!!!
if cheatHapri = 1:hapri = 1
!!!!!!!!!!!!
if alko > 0: frost = 0
if StrongNarkota >= 20 and alko > 0: alko = 0
if GorSlut > 0:
	if GorSlut > 6: GorSlut = 6
	$_gnik[0] = 'давалка'
	$_gnik[1] = 'вафлерша'
	$_gnik[2] = 'общая хуесоска'
	$_gnik[3] = 'общая дырка'
	$_gnik[4] = 'опущенная шалава'
	$_gnik[5] = 'проститутка'
	$gnikname = $_gnik[GorSlut-1]
	killvar '$_gnik'
end
!!!Новая формула развратности основана на собранной статистике.(старая формула: shameless = guy+bj+anal+hj+(slutty*2)+(gang*2))
shameless['main'] = (mastr/3) + (rape/3) + (frot/3) + (voyeurism/3) + (cumfrot/3) + sex + bj + hj + hump + kuni + piss + lesbian + stripdance+ modelfoto + (exhibi*3) + (stripdancesum*3) + (anal*3) + (spank*3) + (swallow*3) + (facial*3) + (pee*3) + (throat*3) + (eggs*3) + (gang*6) + (slutty*6) + (film*9)
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
	elseif shameless['main'] > shameless['limit_1'] and shameless['main'] < shameless['limit_2']:
	shameless['flag'] = 1
	elseif shameless['main'] > shameless['limit_2'] and shameless['main'] < shameless['limit_3']:
	shameless['flag'] = 2
	elseif shameless['main'] > shameless['limit_3']:
	shameless['flag'] = 3
end
moneySUM = money+karta+stolmoney
!cumSUM = cumbelly+cumpussy+cumass+cumlip+cumface+cumfrot+cumanus
if husbizvradd > 5:izvratH = 1
if husbharmin > 10:harakHusb = 0
if clrbelo <= 0:clrbelo = 0 & tanga = 0
if husband = 0:
	husbizvradd = 0
	husbharmin = 0
	husbandMark = 0
end
if SNarkvnesh = 0:SNarkvnesh = 1
if SNarkTimes >= SNarkvnesh*25:
	SNarkvnesh += 1
	vidage += 1
end
if gopota >= 20 and gnewQW = 1:gnewQW = 2
if workDisk = 4 and week > 5:workDisk = 1
if workDisk = 3 and week > 5:workDiskAtkPlayer = 1
VeneraN = 0
if VeneraOnce > 0:VeneraOnce = 0
if SifacOnce = 1:VeneraN += 1
if GerpesOnce = 1:VeneraN += 1
if TriperOnce = 1:VeneraN += 1
Venera = VeneraN
if vokal < 0:vokal = 0
if vokal > 100:vokal = 100
if dance > 100:dance = 100
if stripdance > 100:stripdance = 100
if poledance > 100:poledance = 100
! vovan edition
if goforest > 100: goforest = 100
if bucket > 10:bucket = 10
if bucket < 0:bucket = 0
!--
if bfa < 0:bfa = 0
if beg < 0:beg = 0
if beg > 2000:beg = 2000
if oficiant > 100:oficiant = 100
if vagina > 36:vagina = 36
if throat > 36:throat = 36
if anus > 36:anus = 36
if Jab > 120:Jab = 120
if Punch > 120:Punch = 120
if Kik > 120:Kik = 120
if KikDef > 120:KikDef = 120
if nark >= 30 and narkoman = 0:
	narkoman = 1
elseif nark = 0 and narkoman = 1:
	narkoman = 0
end
boxing = Jab + Punch + Kik + KikDef
if boxing > 100: boxing = 100
if stren > 100: stren = 100
if speed > 100: speed = 100
if agil > 100: agil = 100
if react > 100: react = 100
if vital > 100: vital = 100
if intel > 100: intel = 100
if dom > 100: dom = 100
if dom < -100: dom = -100
if horny < 0: horny = 0
if horny > 100: horny = 100
if VAF > 200: VAF = 200
if health > 100: health = 100
if manna > 100: manna = 100
if vidageday <= 0:
	vidageday = 360
	vidage += 1
end
!!!!!!!!!!!
!!!ВРЕМЯ!!!
!!!!!!!!!!!
if nminut ! minut:
	!totminut время игры в минутах
	totminut += minut
	nminut = minut
end
if vgape > 0:
	if vgape = 3 and manna > 25: manna = 25
	if vgape = 2 and manna > 50: manna = 50
	vgape = (vgapetime - totminut) / 1440
end
if agape <= 0:
	agape = 0
else
	if agape = 3 and manna > 25: manna = 25
	if agape = 2 and manna > 50: manna = 50
	agape = (agapetime - totminut) / 1440
end
if manna >= (100 - spanked): manna= 100 - spanked
if minut >= 60:
	:loopmin
	if nerdism > 0:
		nerdism -= 1
		manna -= 4 - nerdism/20
	end
	! попоболь, снижение на 1 в час
	if spanked < 0: spanked = 0
	if spanked > 0:
		if spanked > 100: spanked = 100
		spanked -= 1
	end
	! ---
	if obkvsdam > 0: obkvsdam = RAND(2,5)
	hour += 1
	if energy < 8:
		manna -= 5
		hungry_time += 1
	end
	! сброс голодовки
	if energy >= 24:hungry_time = 0
	energy -= 1
	water -= 1
	if water < 8: manna -= 5
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
	if shame > 0: shame -= 1 & manna -= 5
	if StrongNarkota > 20 and SNday ! day:
		SNday = day
		if beg > 0: beg -= 2
		if volleyboll > 0: volleyboll -= 1
		if stren > 10: stren -= 1
		if vital > 10: vital -= 1
		if react > 10: react -= 1
		if speed > 10: speed -= 1
		if agil > 10: agil -= 1
		if intel > 10: school['intellect'] -= 1
		body['day_weight'] -= 1
	end
	if SLomka > 0: SLomka += 1 & manna -= 5
	if SLomka > 100 and StrongNarkota <= 0: SLomka = 0 & SNarkTimes = 0
	! check cum status
	if cumface > 0: cumface -= 1
	if cumlip > 0: cumlip -= 1
	if cumbelly > 0: cumbelly -= 1
	if cumass > 0: cumass -= 1
	if cumpussy > 0: cumpussy -= 1
	if cumanus > 0: cumanus -= 1
	! ---
	if current_clothing > 2 and tanga = 0 and func('zz_clothing','is_skirt') = 0: mosolpred += 1
	if mosolpred >= 10:
		mosol += 1
		mosolpred = 0
	end
	if mosol >= 50: manna -= 5
	if (tanga = 1 or func('zz_clothing','is_skirt') = 1) and mosol > 0: mosol -= 1
	if lipbalmstat > 0: lipbalmstat -= 1
	if sickstage = 1: sick += 1 & sicktimer += 1
	if sickstage = 1 and sicktimer >= 80: sicktimer = 0 & sickstage = 2
	if sickstage = 2 and sick > 0: sick -= 1
	if sickstage = 2 and sick <= 0: sick = 0 & sickstage = 0
	if frost > 0: frost -= 1
	! vovan edition
	if sweat > 2: gs 'zz_funcs', 'skin', '-'
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
	if minut >= 60: jump 'loopmin'
end
if hour >= 24:
	! счетчик оплаты кружка Сони
	if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] < 255: $npc['25,qwSonya_payday'] += 1
	! проверка местожительства Кати Мейнольд
	! 0 - в сити
	! 1 - в городке
	$npc['14,homeward'] = iif($npc['14,qwKatya'] >= 200 and week <= 5,0,1)
	! --
	! сброс тройничка с Катей, если ГГ не пришла
	if $npc['14,qwKatya'] = 72 and $npc['14,qwKatya_trio_day'] < daystart: $npc['14,qwKatya'] = 75
	! --
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
	reading['in_bag'] = -1
	! set father`s stats
	father['talk_count'] = 0
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
	! если настроение больше 1/10 но меньше 1/4 - счетчик не обнуляем, но и не приращиваем
	! если настроение больше 1/4 max - отнимаем
	if manna >= 25 and crazy > 0: crazy -= 1
	if crazy >= 12: gt 'gameover',1
	!---
	prezikProver += 1
	discoclose = 0
	trenerskaia = 0
	coffee_drink = 0
	if pirs_pain_ton > 0:pirs_pain_ton -= 1
	if browper = 0:
		if brow > 0: brow -= 1
		if brow < 0: brow = 0
	end
	if shorthair > 0:
		shorthairday += 1
		if shorthairday >= 60: shorthairday = 0 & shorthair -= 1
	end
	!if volleysostav > 0: gs 'npc_editor','change_rep','-',28
	if birthday = day and birthmonth = month:
		!день рождения
		age += 1
	end
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
		'<b><font color = red>Срок аренды вашей квартиры истёк, вам вернули ключи.</font></b>'
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
	if workDolgDay > 0:workDolgDay -= 1
	if husband > 0:husbanday += 1
	if husband > 10 and husbanday > 0:husband -= 15
	if fingal > 0:fingal -= 1
	if husbandMark = 1 and husband <= 10:
		husbizvradd = 0
		husbharmin = 0
		husbandMark = 0
		husband = 0
		divorced += 1
		if KFOnLineReaga > 0:KFOnLineReaga -= 1
		'<b><font color = red>Ваш муж подал на развод.</font></b>'
	end
	gs 'cikl'
	if narkoman = 1:
		if beg > 0: beg -= 2
		if volleyboll > 0: volleyboll -= 2
		if stren > 10: stren -= 2
		if vital > 10: vital -= 2
		if react > 10: react -= 2
		if speed > 10: speed -= 2
		if agil > 10: agil -= 2
		if intel > 10: school['intellect'] -= 2
		body['day_weight'] -= 1
	end
	if nark > 0: nark -= 1
	if hour >= 24: jump 'loop'
end
!Выплаты
if day = 25:
	! -- meynold payment ---!
	if $npc['45,qwTamara'] >= 3 and $npc['45,qwTamara'] ! 50 and $npc['0,mey_help_count'] >= 10:
		money += 5000
		'<b><font color=green>За ваши труды тетя Тамара вручила вам 5000 рублей</font></b>'
		$npc['0,mey_help_count'] = 0
	end
	!--
	if PersSecWork = 1 and PersSecWorkTimes > 0 and paydaybistrosec = 0:
		Pay = PersSecWorkTimes*2500
		PersSecWorkTimes = 0
		money += Pay
		paydaybistrosec = 1
		'<b><font color = green>Вам перечислили <<pay>> рублей зарплаты за работу секретаршей.</font></b>'
	end
	if workKafe = 1 and paydayKafe = 0:
		paydayKafe = 1
		pay = smenaKafe*750
		money += pay
		smenaKafe = 0
		'<b><font color = green>Вам перечислили <<pay>> рублей зарплаты за работу официанткой в кафе.</font></b>'
	end
	if workhosp = 1 and nopaypoly = 0:
		pay = smena*700
		money += pay
		smena = 0
		nopaypoly = 1
		'<b><font color = green>Вам перечислили <<pay>> рублей зарплаты за работу в поликлинике.</font></b>'
	end
	if worksalon = 1 and nopaysalon = 0:
		pay = smena*800
		money += pay
		smena = 0
		nopaysalon = 1
		'<b><font color = green>Вам перечислили <<pay>> рублей зарплаты за работу в салоне красоты.</font></b>'
	end
	if tanwork = 1 and nopaytanwork = 0:
		nopaytanwork = 1
		money += 25000
		'<b><font color = green>Вам перечислили 25000 рублей зарплаты за работу гувернанткой.</font></b>'
	end
	if workSec = 1 and paydaySec = 0:
		paydaySec = 1
		pay = sekDay*1000
		if officebestslut >= 3:pay += 20000
		karta += pay
		sekDay = 0
		'<b><font color = green>Вам перечислили на банковский счет <<pay>> рублей зарплаты за работу секретаршей.</font></b>'
	end
	if workFabrika = 1 and paydayFabrika = 0:
		paydayFabrika = 1
		pay = smenaFabrika*300
		money += pay
		smenaFabrika = 0
		'<b><font color = green>Вам перечислили <<pay>> рублей зарплаты за работу на фабрике.</font></b>'
	end
	if husband > 0 and paydayHusb = 0:
		paydayHusb = 1
		if husbFin = 0: huspay = 15000
		if husbFin = 1: huspay = 30000
		if husbFin = 2: huspay = 60000
		money += huspay
		'<b><font color = green>Вашему мужу перечислили зарплату на банковский счёт, в количестве <<huspay>> рублей.</font></b>'
	end
	if university['student'] = 2 and university['scholarship'] > 0 and university['scholarship_day'] = 0:
		university['scholarship_day'] = 1
		karta += university['scholarship']
		'<b><font color = green>Вам перечислили <<university[''scholarship'']>> рублей стипендии.</font></b>'
	end
	gs 'apartment_south_event', 'rent'
end
if day ! 25:
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
$_month[0] = 'Января'
$_month[1] = 'Февраля'
$_month[2] = 'Марта'
$_month[3] = 'Апреля'
$_month[4] = 'Мая'
$_month[5] = 'Июня'
$_month[6] = 'Июля'
$_month[7] = 'Августа'
$_month[8] = 'Сентября'
$_month[9] = 'Октября'
$_month[10] = 'Ноября'
$_month[11] = 'Декабря'
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
if son < 0: son = 0 & manna -= 5
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
if sex <= 5 and vagina > 5: vagina = 5
if sex > 5 and sex <= 100 and vagina > 15: vagina = 15
if sex > 100 and sex <= 200 and vagina > 25: vagina = 25
if anal <= 5 and anus > 5: anus = 5
if anal > 5 and anal <= 100 and anus > 15: anus = 15
if anal > 100 and anal <= 200 and anus > 25: anus = 25
! ---
gs 'body'
!--
if water > 24: water = 24
if energy > 24: energy = 24
if son > 24: son = 24
!--
! только для варианта с текстовыми описаниями
if $settings['status_display'] = 1:
	!--
	$_stat_color[0] = 'red'
	$_stat_color[1] = 'brown'
	$_stat_color[2] = 'blue'
	$_stat_color[3] = 'green'
	$_stat_color[4] = 'green'
	!--
	$_stat[0] = 'Вы на пороге смерти.'
	$_stat[1] = 'Вы болеете.'
	$_stat[2] = 'Вам нездоровится.'
	$_stat[3] = 'Вы здоровы.'
	$_stat[4] = 'Вы полностью здоровы и сияете румянцем.'
	$health = '<font color=' + $_stat_color[health/25] + '>' + $_stat[health/25] + '</font>'
	!--
	$_stat[0] = 'Ваше настроение ниже любого плинтуса и городской канализации.'
	$_stat[1] = 'Вы в ужасном настроении.'
	$_stat[2] = 'Вы в скверном настроении.'
	$_stat[3] = 'У вас нормальное настроение.'
	$_stat[4] = 'Вы в прекрасном настроении.'
	$manna = '<font color=' + $_stat_color[manna/25] + '>' + $_stat[manna/25] + '</font>'
	!--
	$_stat[0] = 'Вы очень голодны.'
	$_stat[1] = 'Вы голодны.'
	$_stat[2] = 'Вы проголодались.'
	$_stat[3] = 'Вы сыты.'
	$_stat[4] = 'Вы наелись до отвала.'
	$energy = '<font color=' + $_stat_color[energy/6] + '>' + $_stat[energy/6] + '</font>'
	!--
	$_stat[0] = 'У вас сушняк.'
	$_stat[1] = 'Вы очень хотите пить.'
	$_stat[2] = 'Вы хотите пить.'
	$_stat[3] = 'Вы не хотите пить.'
	$_stat[4] = 'Вы напились и больше не хотите пить.'
	$water = '<font color=' + $_stat_color[water/6] + '>' + $_stat[water/6] + '</font>'
	!--
	$_stat[0] = 'Вы засыпаете на ходу.'
	$_stat[1] = 'Вы хотите спать.'
	$_stat[2] = 'Вы не хотите спать.'
	$_stat[3] = 'Вы выспались.'
	$_stat[4] = 'Вы отлично выспались и больше не хотите спать.'
	$son = '<font color=' + $_stat_color[son/6] + '>' + $_stat[son/6] + '</font>'
	!--
	$_stat[0] = ''
	$_stat[1] = ''
	$_stat[2] = ''
	$_stat[3] = 'Вы немного возбуждены: ощущение, как будто между ног что-то приятно <a href="exec:view''images/picb/briefs'+iif(tanga=1,'1','1a')+'.jpg''">зудит</a>.'
	$_stat[4] = 'Вы чувствуете, что между ног всё <a href="exec:view''images/picb/briefs'+iif(tanga=1,'2','2a')+'.jpg''">промокло</a> от ваших соков.'
	$horny = '<font color=' + $_stat_color[4-horny/25] + '>' + $_stat[horny/25] + '</font>'
	killvar '$_stat'
	killvar '$_stat_color'
end
!--- weather init
if weather_day ! day: gs 'zz_weather'
!---
!!!!!!!!!!!!!!!!!!!!!
!!!НАЧАЛО ОПИСАНИЯ!!!
!!!!!!!!!!!!!!!!!!!!!
pl func('zz_weather','make_image',sunWeather,temper)
pl '<center><font size=5><b> '+ func('zz_funcs','make_datetime',hour,minut,':') + '</b></font><br><<$week>>, <i><<day>></i> <<$month>> <i><<year>></i> года</center>'
pl '<center><font size=4><img src="images/common/icons/money.png"><b> <<money>></b> <img src="images/common/icons/card.png"><b> <<karta>></font></center>'
pl $holiday
if birthday = day and birthmonth = month: pl '<b>Сегодня ваш день рождения.</b>'
if $settings['status_display'] = 1:
	pl '<b><<$horny>></b>'
	pl '<b><<$health>></b>'
	pl '<b><<$manna>></b>'
	pl '<b><<$energy>></b>'
	pl '<b><<$water>></b>'
	pl '<b><<$son>></b>'
	pl '<b><<$vnesh>></b>'
else
	pl func('zz_funcs', 'scale', horny, 100, 1) + 'возбуждение'
	pl func('zz_funcs', 'scale', health, 100) + 'здоровье'
	pl func('zz_funcs', 'scale', manna, 100) + 'настроение'
	pl func('zz_funcs', 'scale', energy, 24) + 'сытость'
	pl func('zz_funcs', 'scale', water, 24) + 'жажда'
	pl func('zz_funcs', 'scale', son, 24) + 'бодрость'
	pl func('zz_funcs', 'scale', vnesh, 100,2) + 'привлекательность'
end
if PillToggle = 1 and tabletki > 0:
	Stabletki += tabletki
	tabletki = 0
elseif PillToggle = 0 and Stabletki > 0:
	tabletki += Stabletki
	Stabletki = 0
end
if CondomToggle = 1 and prezik > 0:
	Sprezik += prezik
	prezik = 0
elseif CondomToggle = 0 and Sprezik > 0:
	prezik += Sprezik
	Sprezik = 0
end
if pirs_pain_ton > 0:
	if pirs_pain_ton = 1: pl'<font color = red>У вас ноет язык и он немного припухший.</font>'
	if pirs_pain_ton = 2: pl'<font color = red>У вас сильно ноет язык и он заметно припухший.</font>'
	if pirs_pain_ton > 2: pl'<font color = red><b>У вас болит язык, он сильно опух и едва ворочается во рту.</b></font>'
end
if nippain > 0: pl '<font color = red><b><<$nippain>></b></font>'
if painpub > 0: pl '<font color = red><b><<$painpub>></b></font>'
pl '<<$mop>> и <<$hapri>> волосы.'
if func('zz_clothing','is_skirt') > 0 or current_clothing < 3: pl'<<$leghair>>'
if current_clothing = 0 and tanga = 0: pl'<<$lobok>>'
if sweat > 4: sweat = 4
if sweat = 1: pl'<font color = brown>Вы вспотели.</font>'
if sweat = 2: pl'<font color = red>От вас немного пахнет.</font>'
if sweat = 3: pl'<font color = red>От вас разит потом.</font>'
if sweat = 4: pl'<b><font color = red>От вас разит как от бомжихи.</font></b>'
if sweat > 3 and dirtyclothes = 1:pl'<font color = red>Вы с ног до головы <a href="exec:view''images/qwest/gadukino/Swamp/dirtyclothes1.jpg''">перемазаны</a> в грязи.</font>'
if sweat <= 3 and dirtyclothes = 1:pl'<font color = red>У вас грязная <a href="exec:view''images/qwest/gadukino/Swamp/dirtyclothes2.jpg''">одежда</a>.</font>'
if isprok = 0 and mesec > 0 and preg = 0 and cheatTampon = 0:pl'<b><font color = red>У вас течёт кровь между ног, срочно нужна прокладка.</font></b>'
if isprok = 1 and mesec > 0 and preg = 0:pl'У вас месячные, но прокладка вас защищает.'
if preg = 1 and pregtime = 280: pl'<b><font color = red>У ВАС НАЧАЛИСЬ СХВАТКИ. ВАМ СРОЧНО НАДО В РОДДОМ!</font></b>'
if preg = 1: rodtime = 280 - pregtime
if preg = 1 and pregtime < 280 and pregtime > 6:pl'<b><font color = blue>Вы беременны <<pregtime>> дней, до родов осталось <<rodtime>> дней</font></b>'
if preg = 1 and pregtime < 150 and pregtime >= 90:pl'<font color = black>У вас появился едва заметный <a href="exec:view''images/pregnant/1.jpg''"> животик</a>, который, впрочем, не заметен под одеждой</font>'
if preg = 1 and pregtime < 210 and pregtime >= 150:pl'<font color = black>Ваш <a href="exec:view''images/pregnant/2.jpg''"> животик</a> округлился, и весьма заметно. Окружающие видят, что вы беременны</font>'
if preg = 1 and pregtime <= 280 and pregtime >= 210:pl'<font color = black>У вас огромный <a href="exec:view''images/pregnant/3.jpg''"> живот</a> беременной женщины</font>'
if hour >= 11 and hour < 12 and week > 1 and week < 5 and workKafe = 1:pl'<b><font color = red>ВЫ МОЖЕТЕ ВЫЙТИ НА РАБОЧУЮ СМЕНУ ОФИЦИАНТКОЙ В КАФЕ</font></b>'
if hour >= 8 and hour < 9 and week < 5 and workSec >= 1:pl'<b><font color = red>ВАМ НУЖНО НА РАБОТУ СЕКРЕТАРЁМ В ПРОЕКТНУЮ ОРГАНИЗАЦИЮ</font></b>'
if PersSecWork = 1 and week < 6 and hour < 10 and hour >= 5:pl'<b><font color = red>ВАМ НУЖНО НА РАБОТУ СЕКРЕТАРШЕЙ В БЫСТРОЕЖКУ, НЕ ПОЗДНЕЕ 9 ЧАСОВ</font></b>'
if workFabrika = 1 and week => 1 and week <= 5 and hour = 8 and age >= 18 or workFabrika = 1 and week => 1 and week <= 5 and hour = 16 and age < 18:pl'<b><font color = red>ВAM НУЖНО НА РАБОТУ ШВЕЕЙ В ФАБРИКУ Павлово</font></b>'
$zz_str = ''
if body_write > 0 and face_write > 0: $zz_str = 'Ваше тело и лицо разрисованы похабными надписями.'
if body_write > 1 and face_write = 0: $zz_str = 'Ваше тело исписано унизительными надписями.'
if body_write = 1 and face_write = 0: $zz_str = 'На вашем теле непристойная надпись.'
if body_write = 0 and face_write > 1: $zz_str = 'Ваше лицо исписано похабными словечками.'
if body_write = 0 and face_write = 1: $zz_str = 'На вашем лице унизительная надпись.'
if len($zz_str) > 0 : pl '<b><font color = red><a href="exec:dynamic $clear_write"><b><font color = red>' + $zz_str + '</font></b></a>'
if cumlip > 0: pl'<b><font color = red>Из вашего рта пахнет спермой.</font></b>'
if (cumbelly + cumpussy + cumass + cumface + cumfrot + cumanus) > 0: gs 'zz_common','cumeater_prepeare'
if vgape = 3: pl'<b><font color = red>У вас сильно болит влагалище, вы даже с трудом ходите, при этом стараясь пошире расставлять ноги.</font></b>'
if vgape = 2: pl'<b><font color = red>У вас болит влагалище и вы с трудом можете свести ноги вместе.</font></b>'
if vgape = 1: pl'<b><font color = red>У вас немного болит влагалище.</font></b>'
if agape = 3: pl'<b><font color = red>У вас сильно болит и кровоточит анус.</font></b>'
if agape = 2: pl'<b><font color = red>У вас болит анус.</font></b>'
if agape = 1: pl'<b><font color = red>У вас немного болит и чешется анус.</font></b>'
if spanked > 0:
	if spanked/25 >= 2: pl'<b><font color = red>Ваша бедная <a href="exec:view''images/picb/ass/spanked2.jpg''">задница</a> нещадно болит, на ней видны ярко красные рубцы от ударов, местами переходящие в синяки.</font></b>'
	if spanked/25 = 1: pl'<b><font color = red>Ваши <a href="exec:view''images/picb/ass/spanked1.jpg''">ягодицы</a> горят огнём, на них отчётливо видны полосы.</font></b>'
	if spanked/25 = 0: pl'<b><font color = red>Ваши <a href="exec:view''images/picb/ass/spanked0.jpg''">ягодицы</a> немного покраснели от шлепков и грубых прикосновений и побаливают.</font></b>'
end
if Gerpes >= 3: pl'<b><font color = red>На ваших губах язвочки. Все признаки генитального герпеса.</font></b>'
if Gerpes < 10 and Gerpes >= 5: pl'<b><font color = red>Ваша киска покраснела и сильно зудит. Это генитальный герпес.</font></b>'
if Gerpes >= 10: pl'<b><font color = red>На вашей киске появились язвочки. Это генитальный герпес.</font></b>'
if Gerpes >= 20: pl'<b><font color = red>Вашу жопу покрывают язвочки генитального герпеса.</font></b>'
if Sifilis >= 21 and Sifilis < 50: pl'<b><font color = red>У вас вскочила большая, твердая болячка на губе.</font></b>'
if Sifilis >= 50: pl'<b><font color = red>Сифилитическая сыпь покрывает все ваше тело.</font></b>'
if Triper > 2: pl'<b><font color = red>Из влагалища выходят белые выделения и сильная резь при мочеиспускании. Так же из влагалища сильно и противно пахнет.</font></b>'
if Kandidoz > 30: pl'<b><font color = red>У вас молочница.</font></b>'
if SLomka > 0: pl'<b><font color = red>Вам очень плохо и болят все кости. У вас ломка</font></b>'
if narkday ! day and narkoman = 1: pl'<b><font color = red>Вам очень плохо и болят все кости. Срочно нужна бледная леди!</font></b>'
if fingal > 0: pl'<b><font color = red>У вас фингал на лице.</font></b>'
if current_clothing = 0:
	if tanga = 0: pl '<b><font color = red>Вы абсолютно обнажены, и от этого внутри всё трепещет</font></b>'
	if tanga = 1: pl '<b><font color = red>Вы разделись до трусиков и ваши сисечки призывно раскачиваются при ходьбе</font></b>'
elseif current_clothing = 1:
	pl '<b><font color = red>Ваше голое тело прикрывает лишь короткое полотенце</font></b>'
elseif current_clothing > 2:
	if tanga = 0:
		if func('zz_clothing', 'is_skirt') = 1 and shameless['flag'] = 0 :
			pl '<b><font color = red>Румянец заливает ваше лицо: вы не надели трусики и теперь из под вашей короткой юбки иногда сверкает <a href="exec:view''images/picb/upskirt.jpg''">голая задница</a>.</font></b>'
		else
			pl '<b><font color = red>Вы не надели трусики.</font></b>'
		end
	end
end
if mosol >= 30 and mosol < 50: pl'<b><font color = red>Пися покраснела и зудит, кажется вы её натёрли об одежду.</font></b>'
if mosol >= 50: pl '<b><font color = red>Пися болит и каждый шаг дается через боль, она пунцовая и видны потертости от хождения без нижнего белья.</font></b>'
if analplugIN = 1: pl '<b><font color = red>У вас в попу вставлена анальная пробка.</font></b>'
if vibratorin = 1: pl '<b><font color = red>У вас во влагалище работает вибратор.</font></b>'
if young_shop_work = 1 and week < 6:
	if hour = 14: pl'<b><font color = red>В 15 часов вам надо быть на работе в магазине "Кис-Киска".</font></b>'
	if hour = 16 and inWorkYoungShop = 0: young_shop_miss += 1 & pl'<b><font color = red>Вы прогуляли работу.</font></b>'
end
if uber['work'] = 1:
	if uber['work_day'] ! day and week ! 3 and week ! 7:
		if hour = uber['work_week']*8-1 or hour = uber['work_week']*8:
			pl '<b><font color = red>В <<uber[''work_week'']*8>> часов вам надо быть на работе в службе такси.</font></b>'
		elseif hour > uber['work_week']*8:
			uber['work_day'] = day
			uber['work_absent'] += 1
		end
	end
end
if workrin = 1:
	if week mod 2 = 0:
		if hour = 7: pl '<b><font color = red>В 08.00 нужно вам на работу на рынок.</font></b>'
		if hour = 8: pl '<b><font color = red>Вам надо на работу на рынок.</font></b>'
	end
end
!корзинка с грибами и ягодами
if boletus > 0 and bilberry = 0 and boletus + bilberry < 10:pl'У вас в корзинке <b><<boletus>></b> кг грибов.'
if boletus = 0 and bilberry > 0 and boletus + bilberry < 10:pl'У вас в корзинке <b><<bilberry>></b> кг ягод.'
if boletus > 0 and bilberry > 0 and boletus + bilberry < 10:pl'У вас в корзинке <b><<boletus>></b> кг грибов и <b><<bilberry>></b> кг ягод.'
if boletus + bilberry >= 10:pl'<b><font color = black>У вас полная корзина, больше в неё ничего не влазит. В ней <b><<boletus>></b> кг грибов и <b><<bilberry>></b> кг ягод</font></b>'
!долг за квартиру
if house_debt > 0:pl'<b><font color = black>У вас задолженность за квартиру <<house_debt>> рублей.</font></b>'
!---
if frost > 0 and frost <= 5: pl '<b><font>Вам немного холодно.</font></b>'
if frost > 5 and frost < 11: pl '<b><font color = red>Вы замёрзли.</font></b>'
if frost >= 11: pl '<b><font color = red>Вы очень замёрзли.</font></b>'
if sick = 1: pl'<b><font color = red>Вам что-то нехорошо, першит в горле и немного течёт из носа.</font></b>'
if sick > 1 and sick < 24: pl'<b><font color = red>Вас знобит. У вас течёт из носа и саднит горло, вы покашливаете и чихаете - похоже, вы простыли.</font></b>'
if sick >= 24 and sick < 48: pl'<b><font color = red>У вас поднялась температура. У вас забит нос, вам больно глотать - горло побаливает. Вы постоянно кашляете и чихаете - похоже, вы простудились.</font></b>'
if sick >= 48 and sick < 72: pl'<b><font color = red>У вас сильный жар. У вас заложен нос, болят голова и горло, вы сильно кашляете - похоже, вы сильно простудились. Может быть, это грипп.</font></b>'
if sick >= 72: pl'<b><font color = red>Вы мечетесь в жару. У вас заложен нос, болит голова и ломит все кости. Ваше горло воспалено и очень болит. Вы тяжело с надрывом кашляете - похоже, вы серьезно больны. Может быть, это ангина.</font></b>'
if hour < meethour and svidanieA = 1: pl'<<$boyA>> будет вас ждать около вашего дома в <<meethour>> часов'
if hour = meethour and svidanieA = 1: pl'<b><font color = red><<$boyA>> уже ждёт вас около дома.</font></b>'
if meetday < daystart and svidanieA = 1:bfA -= 10 & svidanieA = 0
if StrongNarkota > 20:pl'<b><font color = red>Вы под кайфом.</font></b>'
if alko > 0:
	if alko < 3: pl'<b><font color = red>Вы немного выпивши.</font></b>'
	if alko >= 3 and alko < 6: pl'<b><font color = red>Вы пьяны.</font></b>'
	if alko >= 6: pl'<b><font color = red>Вы в стельку пьяны.</font></b>'
end
if crazy >= 4 and crazy < 7: pl '<b><font color = red>Вы подавлены. Надо что-то в жизни менять.</font></b>'
if crazy >= 7 and crazy <= 10: pl '<b><font color = red>У вас депрессия. До добра это не доведёт, надо к врачу.</font></b>'
if crazy > 10: pl '<b><font color = red>Ваша депрессия затянулась, еще немного - и суицид неизбежен!</font></b>'
if day = 29 and month = 12 and age <= 17 and school['certificate'] = 0 and school['block'] < 3:
	if hour >= 5 and hour <= 14: pl '<font color = red>В 14 часов пройдёт школьная новогодняя вечеринка.</font>'
end
if sisboyday + 1 = daystart and hour < 19 and ($npc['38,qwSisterBoy'] = 3 or $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 7 or ($npc['38,qwSisterBoy'] = 9 and $npc['38,qwSisterTrio'] ! 1)): pl'' & pl'Вы обещали сестре не заходить в вашу комнату в 18 часов'
if sisboyday + 1 = daystart and hour < 19 and $npc['38,qwSisterTrio'] = 1:pl'' & pl'Вы обещали сестре прийти в вашу комнату в 18 часов'
if nerdism > 100: nerdism = 100
if nerdism > 0:
	j = nerdism / 20 + 1
	if j >= 5: pl '<font color = green>Вы погружены в свои фантазии после прочтения книги.</font>'
	if j = 4: pl '<font color = black>Вам немного скучно и хочется опять погрузится в книги.</font>'
	if j = 3: pl '<font color = red>Вам очень хочется что-нибудь почитать.</font>'
	if j <= 2: pl '<font color = red><b>Вы жутко хотите хоть что-нибудь почитать!!!</b></font>'
end
! preview_window
! nothing
if preview_win = 0: view
! face
if preview_win = 1: dynamic $objface
! body
if preview_win = 2: dynamic $objbody
! clothing
if preview_win = 3: dynamic $objclothes
!обнуление проверок на замужество
proverka1 = 0
proverka2 = 0
proverka3 = 0
proverka4 = 0
proverka5 = 0