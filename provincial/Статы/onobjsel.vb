$din_show_tits = {
	view 'images/picb/boobs/'+body['tits']+'.jpg'
}
$objdescrip = {
	clr
	pl'<center><img src="images/common/icons/description.png"><br></center>'
	pl'Вас зовут <B><i><<$name>> <<$surname>></B></i>.'
	pl'Вам <i><<age>></i> <<$letgoda>>, на вид вам можно дать не больше <<vidage>> <<$letgoda2>>.'
	if birthday > 0 and birthmonth > 0:pl'Дата вашего рождения <<birthday>>.0<<birthmonth>>.<<birthyear>>г.'
	nl
	pl'Рост '+body['height']+' см, вес '+body['weight']+' кг.'
	pl'<<$body>>'
	pl'<a href="exec:dynamic $objbody">'+body['breast']+' - '+body['waist']+' - '+body['hips']+'</a>, <a href="exec:dynamic $din_show_tits">размер груди '+body['tits']+'</a>.'
	pl'<<$vnesh>>'
	pl'<<$hair>>'
	pl'<<$lip>>'
	pl'<<$throat>>'
	pl'<<$skin>>'
	pl'<<$glaza>>'
	pl'<<$mop>>'
	pl'<<$leghair>>'
	pl'<<$lobok>>'
	pl'<<$vagina>>'
	pl'<<$anus>>'
	nl
	if curly > 0:pl'Завивки хватит еще на <<curly>> дней.'
	if zub = 1:$zuba = ' зуба'
	if zub >= 2:$zuba = 'х зубов'
	if zub > 0:pl'У вас не хватает <<zub>><<$zuba>>.'
}
$objskills = {
	clr
	$rc_param += '<center><img src="images/common/icons/stats.png"><br></center>'
	$rc_param += func('zz_funcs', 'scale', vnesh, 100,2) + 'Привлекательность<br>'
	$rc_param += func('zz_funcs', 'scale', stren, 100) + 'Сила<br>'
	$rc_param += func('zz_funcs', 'scale', speed, 100) + 'Скорость<br>'
	$rc_param += func('zz_funcs', 'scale', agil, 100) + 'Ловкость<br>'
	$rc_param += func('zz_funcs', 'scale', vital, 100) + 'Выносливость<br>'
	$rc_param += func('zz_funcs', 'scale', intel, 100) + 'Интеллект<br>'
	$rc_param += func('zz_funcs', 'scale', react, 100) + 'Реакция<br>'
	$rc_param += func('zz_funcs', 'scale', throat, 36,1) + 'Вместимость горла<br>'
	$rc_param += func('zz_funcs', 'scale', vagina, 36,1) + 'Эластичность вагины<br>'
	$rc_param += func('zz_funcs', 'scale', anus, 36,1) + 'Размер ануса<br>'
	if dom < 0:
		$rc_param += func('zz_funcs', 'scale', -dom, 100,1)
	else
		$rc_param += func('zz_funcs', 'scale', dom, 100)
	end
	if dom <= -10:
		if dom <= -10 and dom > -25: $rc_param += 'Склонная к подчинению<br>'
		if dom <= -25 and dom > -50: $rc_param += 'Покорная<br>'
		if dom <= -50 and dom > -75: $rc_param += 'Рабыня<br>'
		if dom <= -75: $rc_param += 'На всё готовая рабыня<br>'
	elseif dom >= 10:
		if dom >= 10 and dom < 25: $rc_param += 'Склонная к доминированию<br>'
		if dom >= 25 and dom < 50: $rc_param += 'Домина<br>'
		if dom >= 50 and dom < 75: $rc_param += 'Госпожа<br>'
		if dom >= 75: $rc_param += 'Строгая госпожа<br>'
	else
		$rc_param += 'Без склонностей<br>'
	end
	$rc_param += func('zz_funcs', 'scale', Jab, 120) + 'Джебы<br>'
	$rc_param += func('zz_funcs', 'scale', Punch, 120) + 'Силовые удары<br>'
	$rc_param += func('zz_funcs', 'scale', Kik, 120) + 'Удары ногами<br>'
	$rc_param += func('zz_funcs', 'scale', KikDef, 120) + 'Защита от ударов<br>'
	$rc_param += func('zz_funcs', 'scale', beg, 2000) + 'Бег<br>'
	$rc_param += func('zz_funcs', 'scale', volleyboll, 200) + 'Волейбол<br>'
	$rc_param += func('zz_funcs', 'scale', oficiant, 100) + 'Навыки официантки<br>'
	$rc_param += func('zz_funcs', 'scale', maidstat, 100) + 'Навыки гувернантки<br>'
	$rc_param += func('zz_funcs', 'scale', vokal, 100) + 'Вокал<br>'
	$rc_param += func('zz_funcs', 'scale', dance, 100) + 'Танцы<br>'
	$rc_param += func('zz_funcs', 'scale', dancePRO, 100) + 'Проф.танцы<br>'
	$rc_param += func('zz_funcs', 'scale', stripdance, 100) + 'Стриптиз<br>'
	$rc_param += func('zz_funcs', 'scale', poledance, 100) + 'Танцы на шесте<br>'
	$rc_param += func('zz_funcs', 'scale', poSkill, 1000) + 'Кройка и шитьё<br>'
	if school['certificate'] = 0:
		$rc_param += func('zz_funcs', 'scale', school['progress'], 100) + 'Успеваемость - '+iif(school['progress'] < 40,'двоечница',iif(school['progress'] < 70,'троечница',iif(school['progress'] < 90,'хорошистка','отличница')))+'<br>'
		if school['certificate'] = 0:$rc_param += func('zz_funcs', 'scale', school['absent'],30,1) + 'Прогулы'
	end
	if university['student'] > 0: $rc_param += func('zz_funcs', 'scale', university['progress'], 100) + 'Уровень знаний в универе<br>'
	pl $rc_param
	killvar '$rc_param'
}
$husb_cheat_count = {
	if husband > 0:
		if guy > before_h_guy :
			guy_cheat += guy - guy_cheat
			before_h_guy = guy
		end
		if girl > before_h_girl:
			girl_cheat += girl - before_h_girl
			before_h_girl = girl
		end
	end
	if before_h_girl > 0 and before_h_guy > 0:
		pl'За время супружества вы изменяли мужу с <<guy_cheat>> парнями и <<girl_cheat>> девушками'
	elseif before_h_guy > 0:
		pl'За время супружества вы изменяли мужу с <<guy_cheat>> парнями'
	elseif before_h_girl > 0:
		pl'За время супружества вы изменяли мужу с <<girl_cheat>> девушками'
	end
}
$objstatistika = {
	clr
	pl'<center><img src="images/common/icons/statistics.png"><br></center>'
	if BuyHous = 2 and ArendHouseSL > 0:pl'Квартира в Южном районе арендована на <<ArendHouseSL>> дней.<br>'
	if KikWinPro > 0 or KikLossPro > 0 or KikDrawPro > 0:pl'Профессиональный рекорд. Победы-Поражения-Ничьи (Победы нокаутом)'
	if KikWinPro > 0 or KikLossPro > 0 or KikDrawPro > 0:pl'<<KikWinPro>> - <<KikLossPro>> - <<KikDrawPro>> (<<KikKOPro>> КО)'
	if Win > 0 or Loss > 0:pl'Побед в драках <<Win>>, поражений в драках <<Loss>>'
	if razradKik > 0:pl'<<$razradKik>>'
	if KikWinAm > 0:pl'Побед в кикбоксинге среди любителей - <<KikWinAm>>'
	if KikLossAm > 0:pl'Поражений в кикбоксинге среди любителей - <<KikLossAm>>'
	if KikDrawAm > 0:pl'Ничьих в кикбоксинге среди любителей - <<KikDrawAm>>'
	if razradKik > 0:
		if razradKik = 1:$razradKik = 'У вас III любительский разряд по кикбоксингу'
		if razradKik = 2:$razradKik = 'У вас II любительский разряд по кикбоксингу'
		if razradKik = 3:$razradKik = 'У вас I любительский разряд по кикбоксингу'
		if razradKik = 4:$razradKik = 'У вас звание Кандидата в Мастера Спорта по кикбоксингу'
		if razradKik = 5:$razradKik = 'У вас звание Мастера Спорта по кикбоксингу'
	end
	if kolsorev > 0:pl'<br><<kolsorev>> раз принимали участие в соревнованиях по бегу'
	if bronzebeg > 0:pl'<<bronzebeg>> - бронзовых медалей по бегу'
	if silverbeg > 0:pl'<<silverbeg>> - серебряных медалей по бегу'
	if goldbeg > 0:pl'<<goldbeg>> - золотых медалей по бегу'
	if razradbegEB > 0:pl'<<razradbegEB>> кратный бронзовый призёр чемпионата Европы'
	if razradbegES > 0:pl'<<razradbegES>> кратная вице-чемпионка Европы'
	if razradbegEG > 0:pl'<<razradbegEG>> кратная чемпионка Европы.'
	if razradbeg > 0:
		if razradbeg = 1:pl'У вас 3й спортивный разряд по бегу'
		if razradbeg = 2:pl'У вас 2й спортивный разряд по бегу'
		if razradbeg = 3:pl'У вас 1й спортивный разряд по бегу'
		if razradbeg = 4:pl'У вас звание Кандидата в Мастера Спорта по бегу'
		if razradbeg = 5:pl'У вас звание Мастера Спорта по бегу'
		if razradbeg >= 6:pl'У вас звание Мастера Спорта Международного класса по бегу'
	end
	if school['certificate'] = 1:pl'Вы закончили школу.'
	if diplom = 1:pl'Вы закончили университет.'
	if exhibi > 0:pl'Опыт эксгибиционизма <<exhibi>>'
	if modelfoto > 0:pl'Вы снимались обнаженной <<modelfoto>> раз'
	if stripdancesum > 0:pl'<<stripdancesum>> раз танцевали стриптиз в клубе'
	if profiDanceTime > 0:pl'Вы <<profiDanceTime>> раз профессионально танцевали.'
	if mastr > 0:pl'Мастурбировали <<mastr>> раз'
	if guy > 0:pl'У вас было <<guy>> парней.'
	if divorced > 0:pl'У вас было <<divorced>> мужей.'
	if suprdolg > 0:pl'Выполняли супружеский долг с мужем <<suprdolg>> раз'
	dynamic $husb_cheat_count
	if gang > 0:pl'Групповой секс <<gang>> раз'
	if sex > 0 and sexa = 0:pl'вагинальный секс <<sex>> раз'
	if sex > 0 and sexa > 0:pl'вагинальный секс <<sex>> раз из них <<sexa>> раз со своим парнем'
	if bj > 0:
		if gloryhole = 0 and eggs = 0 and bja = 0:pl'минетов сделано <<bj>> раз'
		if gloryhole = 0 and eggs = 0 and bja > 0:pl'минетов сделано <<bj>> раз, из них <<bja>> раз своему парню'
		if gloryhole > 0 and eggs = 0 and bja = 0:pl'минетов сделано <<bj>> раз, из них вы <<gloryhole>> раз отсосали у незнакомцев через дыру в стене.'
		if gloryhole > 0 and eggs = 0 and bja > 0:pl'минетов сделано <<bj>> раз, из них вы <<gloryhole>> раз отсосали у незнакомцев через дыру в стене. Так же из них <<bja>> раз своему парню'
		if gloryhole = 0 and eggs > 0 and bja = 0:pl'минетов сделано <<bj>> раз, яиц обсосали <<eggs>> раз.'
		if gloryhole = 0 and eggs > 0 and bja > 0:pl'минетов сделано <<bj>> раз, яиц обсосали <<eggs>> раз. Так же из них <<bja>> раз своему парню'
		if gloryhole > 0 and eggs > 0 and bja = 0:pl'минетов сделано <<bj>> раз, из них вы <<gloryhole>> раз отсосали у незнакомцев через дыру в стене. Яиц обсосали <<eggs>> раз.'
		if gloryhole > 0 and eggs > 0 and bja > 0:pl'минетов сделано <<bj>> раз, из них вы <<gloryhole>> раз отсосали у незнакомцев через дыру в стене. Яиц обсосали <<eggs>> раз. Так же из них <<bja>> раз своему парню'
	end
	if hj > 0: pl'Дрочили парням <<hj>> раз из них <<hja>> раз дрочили своему парню'
	if hump > 0: pl'Об вас дрочили член <<hump>> раз'
	if rape > 0: pl'Вас изнасиловали <<rape>> раз'
	if anal > 0: pl(iif(anala = 0,'Анальный секс <<anal>> раз','Анальный секс <<anal>> раз из них <<anala>> раз со своим парнем'))
	if kuni > 0: pl'Вам сделали кунилингус <<kuni>> раз'
	if pegging > 0: pl'Пеггинг <<pegging>> раз'
	if spank > 0: pl'Вам напороли задницу <<spank>> раз'
	if slutty > 0: iif(bordelslutty = 0,'Продавали свою любовь <<slutty>> раз.','Продавали свою любовь <<slutty>> раз, из них в борделе <<bordelslutty>> раз.')
	if pfilmSTOP = 1: pl'<<$pfilmstory_new>>'
	if film > 0: pl'В порно индустрии вас знают под именем <<$pfname>>. Вы снимались в порнухе <<film>> раз.'
	if orgasm > 0: pl'Испытали оргазм <<orgasm>> раз. Из них <<vaginalOrgasm>> вагинальных оргазмов во время секса.'
	if analorgasm > 0:pl 'Из них <<analorgasm>> анальных оргазмов'
	if DPorgasm >0 :pl 'Из них <<DPorgasm>> оргазмов от двойного проникновения'
	if swallow > 0:pl'Спермы проглочено <<swallow>> раз'
	if facial > 0:pl'Кончили на лицо <<facial>> раз'
	if frot > 0:pl'Кончили на вас в транспорте <<frot>> раз'
	if VAF > 0:pl'Вафлизм <<VAF>>'
	if pee > 0:pl'Вас обоссали <<pee>> раз.'
	if piss > 0:pl'Вы писали в людных местах <<piss>> раз.'
	if girl > 0:pl'У вас было <<girl>> девушек.'
	if lesbian > 0:pl'Вы занимались леcбийским сексом <<lesbian>> раз.'
	if $npc['30,sex'] > 0:pl'Вы <<sexfuta>> раз занимались сексом с членодевкой.'
	if voyeurism > 0:pl'Вы <<voyeurism>> раз подглядывали за людьми.'
}
$rep_clear = {
	!очистка репутации (для опровержения слухов о ГГ и т.п.) Полной индульгенции репутации в игре быть не должно.
	!Сделал снижение плавным, добавил 50% шанс, что ГГ не поверят.
	if GorSlut > 0 and rand(0,1) = 0: GorSlut -= 1
}
$reputation = {
	clr
	pl'<center><img src="images/common/icons/reputation.png"><br></center>'
	if GorSlut > 0:
		if GorSlut = 1:pl'В Павлово вас знают как давалку.'
		if GorSlut = 2:pl'В Павлово вас знают как вафлершу бравшую в рот.'
		if GorSlut = 3:pl'В Павлово вас знают как вафлершу отсосавшую несколько хуев сразу.'
		if GorSlut = 4:pl'В Павлово вас знают как давалку которую трахали сразу несколько пацанов.'
		if GorSlut = 5:pl'В Павлово вас знают как конченную шлюху с которой можно делать все, что угодно.'
		if GorSlut = 6:pl'В Павлово вас знают как проститутку готовую за деньги на любую мерзость.'
	else
		pl'В Павлово у вас хорошая репутация приличной девушки'
	end
	if rinslut > 1 and kavslut > 0:pl'В Южном районе Сити вас знают как шлюху, ложащуюся под кавказцев'
	!if afra > 80: pl'В студенческой общаге вы известны как подстилка для черномазых'
	if opusk > 0: pl'В Южном районе все чёткие пацаны знают за вас, что вы опущенная хуесоска'
	nl
	if motherKnowSpravka > 0 and motherKnowWhore > 0:
		pl'Ваша мать знает, что вы уже не девственица и считает вас шлюхой'
	elseif motherKnowWhore > 0:
		pl'Ваша мать считает вас шлюхой'
	elseif motherKnowSpravka > 0:
		pl'Ваша мать знает, что вы уже не девственица'
	else
		pl'Ваша мать думает, что вы девственница'
	end
	if $npc['39,qwPornoFootball'] >= 30 and $npc['39,sex'] = 1:
		pl'Ваш брат считает вас нимфоманкой.'
	elseif $npc['39,sex'] = 1 or ($npc['39,qwPornoFootball'] >= 16 and $npc['39,qwPornoFootball'] < 30):
		pl'Ваш брат считает, что вы - удобная телка.'
	elseif brotherknowslut = 1:
		pl'Ваш брат видел сперму на вашем теле и думает, что вы даете'
	elseif brotherknowslut = 2:
		pl'Ваш брат видел как вы отсасывали гопникам'
	else
		pl'Ваш брат о вас хорошего мнения'
	end
	if sisterknowslut > 1 and sisboypartyQW = 2:
		pl'Ваша сестра считает вас отвязной шлюшкой'
	elseif sisterknowslut > 0:
		pl'Ваша сестра знает, что вы даете'
	else
		pl'Ваша сестра о вас хорошего мнения'
	end
	if workPTU > 1:pl'Репутация учителя <<teachlevel>>'
	if teachlevel > 0:pl'Ваш авторитет как учителя <<teachlevel>>'
}
$relation = {
	clr
	pl'<center><img src="images/common/icons/relation.png"><br></center>'
	gs 'npc_editor','relation_list'
}
$din_exhibiHideNewCloth = {
	exhibiHideNewCloth = 1
	gs'stat'
}
$din_cheat_tampon = {
	cheatTampon = iif(cheatTampon = 0,1,0)
	dynamic $din_cheat_menu_permanent
}
$din_cheat_age = {
	age = input("Сколько вам теперь лет?")
	if age <= 17:age = 17
	if age >= 25:age = 25
	dynamic $din_cheat_menu_look
}
$din_cheat_agel = {
	vidage = input("На сколько лет вы хотите выглядеть?")
	if vidage <= 16:vidage = 16
	dynamic $din_cheat_menu_look
}
$din_cheat_money = {
	i = val(input("Сколько денег вы хотите иметь?"))
	if i > 0: money = i
	dynamic $objcheat_menu
}
$din_cheat_hapri_mod = {
	if cheatHapri_mod = 0:
		cheatHapri_mod = 1
		if shorthair = 1: shorthair = 3
		glacol = 3
		hapri = 1
		dynamic $din_cheat_menu_permanent
		exit
	else
		cheatHapri_mod = 0
		if shorthair > 0: shorthair = 1
		glacol = 1
		hapri = 0
		dynamic $din_cheat_menu_permanent
	end
}
$din_cheat_hapri = {
	if cheatHapri = 0:
		cheatHapri = 1
		dynamic $din_cheat_menu_permanent
		exit
	else
		cheatHapri = 0
		dynamic $din_cheat_menu_permanent
	end
}
$din_cheat_menu_permanent = {
	clr
	pl'<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a></center>'
	pl''
	pl'<a href="exec:dynamic $din_cheat_tampon">Автоприменение прокладок</a>: ' + dyneval($dyn_make_str,cheatTampon)
	pl'<a href="exec:dynamic $din_cheat_hapri_mod">Альтернативное отображение лица и макияжа</a>: ' + dyneval($dyn_make_str,cheatHapri_mod)
	if cheatHapri_mod = 1:pl'<a href="exec:dynamic $din_cheat_hapri">Всегда причесаная</a>: ' + dyneval($dyn_make_str,cheatHapri)
	pl''
	pl'<a href="exec:alko = 0 & dynamic $din_cheat_menu_permanent">Протрезветь</a>'
	pl'<a href="exec:alko = 2 & dynamic $din_cheat_menu_permanent">Слегка опьянеть</a>'
	pl'<a href="exec:alko = 4 & dynamic $din_cheat_menu_permanent">Опьянеть</a>'
	pl'<a href="exec:alko = 7 & dynamic $din_cheat_menu_permanent">Сильно опьянеть</a>'
	pl'<a href="exec:alko = 10 & dynamic $din_cheat_menu_permanent">Опьянеть в дымину</a>'
	pl''
	pl'<a href="exec:horny = 100 & dynamic $din_cheat_menu_permanent">Возбудиться</a>'
	pl'<a href="exec:horny = 0 & dynamic $din_cheat_menu_permanent">Успокоится</a>'
}
$dyn_make_str = {
	$result = iif(args[0] = 1,'<b>ВКЛЮЧЕНО</b>','ВЫКЛЮЧЕНО')
}
$din_cheat_menu_look = {
	gs'stat'
	clr
	pl'<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a></center>'
	pl''
	pl'<a href=>Сейчас вам <<age>> лет</a>'
	if age >= 0:pl'<a href="exec:dynamic $din_cheat_age">Изменить возраст</a>'
	pl'<a href=>Вы выглядите на <<vidage>> лет</a>'
	if vidage >= 0:pl'<a href="exec:dynamic $din_cheat_agel">Изменить Видимый возраст</a>'
	pl''
	pl 'у вас <<body[''tits'']>> размер груди'
	if body['tits'] => 0 and body['tits'] < 6:pl'<a href="exec:silicone += 5 & dynamic $din_cheat_menu_look">Увеличить грудь</a>'
	if body['tits'] => 1:pl'<a href="exec:silicone -= 5 & dynamic $din_cheat_menu_look">Уменьшить грудь</a>'
	pl''
	pl'<<$lip>>'
	if lip < 4:pl'<a href="exec:lip += 1 & dynamic $din_cheat_menu_look">Увеличить губы</a>'
	if lip > 0:pl'<a href="exec:lip -= 1 & dynamic $din_cheat_menu_look">Уменьшить губы</a>'
	pl''
	pl'<<$skin>>'
	if skin < 4:pl'<a href="exec:skin += 1 & dynamic $din_cheat_menu_look">Улучшить кожу</a>'
	if skin > 0:pl'<a href="exec:skin -= 1 & dynamic $din_cheat_menu_look">Ухудшить кожу</a>'
	if tan >= 0:pl'<a href="exec:tan += 10 & dynamic $din_cheat_menu_look">Загореть</a>'
	if tan > 0:pl'<a href="exec:tan = 0 & dynamic $din_cheat_menu_look">Убрать загар</a>'
	pl''
	pl'<<$glaza>>'
	if resnic < 2:pl'<a href="exec:resnic += 1 & dynamic $din_cheat_menu_look">Увеличить ресницы</a>'
	if resnic > 0:pl'<a href="exec:resnic -= 1 & dynamic $din_cheat_menu_look">Уменьшить ресницы</a>'
	if glaraz < 3:pl'<a href="exec:glaraz += 1 & dynamic $din_cheat_menu_look">Увеличить размер глаз</a>'
	if glaraz > 0:pl'<a href="exec:glaraz -= 1 & dynamic $din_cheat_menu_look">Уменьшить размер глаз</a>'
	pl''
	if glass >= 0 and glass < 2:pl'<a href="exec:glass += 1 & dynamic $din_cheat_menu_look">Носить очки</a>'
	if glass > 0 and glass <= 2:pl'<a href="exec:glass -= 1 & dynamic $din_cheat_menu_look">Убрать очки</a>'
	pl''
	pl'<<$vagina>>'
	if vagina > 0:pl'<a href="exec:vagina = 0 & sex = 0 & dynamic $din_cheat_menu_look">Востановить девственность</a>'
	if vagina <= 31:pl'<a href="exec:vagina += 5 & dynamic $din_cheat_menu_look">Увеличить влагалище</a>'
	if vagina >= 5:pl'<a href="exec:vagina -= 5 & dynamic $din_cheat_menu_look">Уменьшить влагалище</a>'
	pl''
	pl'<<$anus>>'
	if anus <= 31:pl'<a href="exec:anus += 5 & dynamic $din_cheat_menu_look">Увеличить анус</a>'
	if anus >= 5:pl'<a href="exec:anus -= 5 & dynamic $din_cheat_menu_look">Уменьшить анус</a>'
	pl''
	pl'<a href="exec:dynamic $din_cheat_menu_tatoo">Удаление Татуировок</a>'
}
$din_cheat_menu_tatoo = {
	gs'stat'
	clr
	pl'<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a> - <a href="exec:dynamic $din_cheat_menu_look"><b>Внешний Вид</b></a></center>'
	pl''
	if tattoo['lip'] > 0: pl'<a href="exec:tattoo[''lip''] = 0 & dynamic $din_cheat_menu_tatoo">Свести татуировку с губ</a>'
	if tattoo['shoulder'] > 0: pl'<a href="tattoo[''shoulder''] = 0 & dynamic $din_cheat_menu_tatoo">Свести татуировку с плечей</a>'
	if tattoo['back'] > 0 :pl'<a href="exec:tattoo[''back''] = 0 & dynamic $din_cheat_menu_tatoo">Свести татуировку со спины</a>'
	if tattoo['waist'] > 0:pl'<a href="exec:tattoo[''waist''] = 0 & dynamic $din_cheat_menu_tatoo">Свести татуировку с поясницы</a>'
	if tattoo['vag'] > 0:pl'<a href="exec:tattoo[''vag''] = 0 & dynamic $din_cheat_menu_tatoo">Свести татуировку с паха</a>'
	if tattoo['leg'] > 0:pl'<a href="exec:tattoo[''leg''] = 0 & dynamic $din_cheat_menu_tatoo">Свести татуировку с лодыжки</a>'
}
$din_cheat_menu_stats = {
	gs 'stat'
	clr
	pl '<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a></center>'
	pl ''
	pl 'Сила (<<stren>>): <a href="exec:stren += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:stren += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:stren += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:stren += 25 & dynamic $din_cheat_menu_stats">+25</a> <a href="exec:stren -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:stren -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:stren -= 10 & dynamic $din_cheat_menu_stats">-10</a> <a href="exec:stren -= 25 & dynamic $din_cheat_menu_stats">-25</a>'
	pl 'Скорость (<<speed>>): <a href="exec:speed += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:speed += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:speed += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:speed += 25 & dynamic $din_cheat_menu_stats">+25</a> <a href="exec:speed -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:speed -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:speed -= 10 & dynamic $din_cheat_menu_stats">-10</a> <a href="exec:speed -= 25 & dynamic $din_cheat_menu_stats">-25</a>'
	pl 'Ловкость (<<agil>>): <a href="exec:agil += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:agil += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:agil += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:agil += 25 & dynamic $din_cheat_menu_stats">+25</a> <a href="exec:agil -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:agil -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:agil -= 10 & dynamic $din_cheat_menu_stats">-10</a> <a href="exec:agil -= 25 & dynamic $din_cheat_menu_stats">-25</a>'
	pl 'Реакция (<<react>>): <a href="exec:react += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:react += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:react += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:react += 25 & dynamic $din_cheat_menu_stats">+25</a> <a href="exec:react -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:react -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:react -= 10 & dynamic $din_cheat_menu_stats">-10</a> <a href="exec:react -= 25 & dynamic $din_cheat_menu_stats">-25</a>'
	pl 'Телосложение (<<vital>>): <a href="exec:vital += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:vital += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:vital += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:vital += 25 & dynamic $din_cheat_menu_stats">+25</a> <a href="exec:vital -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:vital -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:vital -= 10 & dynamic $din_cheat_menu_stats">-10</a> <a href="exec:vital -= 25 & dynamic $din_cheat_menu_stats">-25</a>'
	pl 'Интелект (<<intel>>): <a href="exec:intel += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:intel += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:intel += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:intel += 25 & dynamic $din_cheat_menu_stats">+25</a> <a href="exec:intel -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:intel -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:intel -= 10 & dynamic $din_cheat_menu_stats">-10</a> <a href="exec:intel -= 25 & dynamic $din_cheat_menu_stats">-25</a>'
	pl ''
	pl 'Доминантность (<<dom>>): <a href="exec:dom += 1 & dynamic $din_cheat_menu_stats">+1</a> <a href="exec:dom += 5 & dynamic $din_cheat_menu_stats">+5</a> <a href="exec:dom += 10 & dynamic $din_cheat_menu_stats">+10</a> <a href="exec:dom -= 1 & dynamic $din_cheat_menu_stats">-1</a> <a href="exec:dom -= 5 & dynamic $din_cheat_menu_stats">-5</a> <a href="exec:dom -= 10 & dynamic $din_cheat_menu_stats">-10</a>'
	pl '<a href="exec:beg += 25 & dynamic $din_cheat_menu_stats">Бег+25: <<beg>></a>'
	if beg >= 25: pl'<a href="exec:beg -= 25 & dynamic $din_cheat_menu_stats">Бег-25: <<beg>></a>'
	pl '<a href="exec:volleyboll += 25 & dynamic $din_cheat_menu_stats">Волейбол+25: <<volleyboll>></a>'
	if volleyboll >= 25: pl'<a href="exec:volleyboll -= 25 & dynamic $din_cheat_menu_stats">Волейбол-25: <<volleyboll>></a>'
	pl '<a href="exec:dance += 25 &dynamic $din_cheat_menu_stats">Танцы+25: <<dance>></a>'
	if dance >= 25: pl'<a href="exec:dance -= 25 &dynamic $din_cheat_menu_stats">Танцы-25: <<dance>></a>'
	pl '<a href="exec:dancePRO += 25 & dynamic $din_cheat_menu_stats">Проф. Танцы+25: <<dancePRO>></a>'
	if dancePRO >= 25: pl'<a href="exec:dancePRO -= 25 & dynamic $din_cheat_menu_stats">Проф. Танцы-25: <<dancePRO>></a>'
	pl '<a href="exec:stripdance += 25 &dynamic $din_cheat_menu_stats">Стриптиз+25: <<stripdance>></a>'
	if stripdance >= 25: pl'<a href="exec:stripdance -= 25 &dynamic $din_cheat_menu_stats">Стриптиз-25: <<stripdance>></a>'
	pl '<a href="exec:poledance += 25 & dynamic $din_cheat_menu_stats">Танцы на Шесте+25: <<poledance>></a>'
	if poledance >= 25: pl'<a href="exec:poledance -= 25 & dynamic $din_cheat_menu_stats">Танцы на Шесте-25: <<poledance>></a>'
	pl '<a href="exec:jab += 25 & dynamic $din_cheat_menu_stats">Джебы+25: <<jab>></a>'
	if Jab >= 25: pl'<a href="exec:jab -= 25 & dynamic $din_cheat_menu_stats">Джебы-25: <<jab>></a>'
	pl '<a href="exec:punch += 25 & dynamic $din_cheat_menu_stats">Силовые Удары+25: <<punch>></a>'
	if Punch >= 25: pl'<a href="exec:punch -= 25 & dynamic $din_cheat_menu_stats">Силовые Удары-25: <<punch>></a>'
	pl '<a href="exec:kik += 25 & dynamic $din_cheat_menu_stats">Удары Ногами+25: <<kik>></a>'
	if Kik >= 25: pl'<a href="exec:kik -= 25 & dynamic $din_cheat_menu_stats">Удары Ногами-25: <<kik>></a>'
	pl '<a href="exec:kikdef += 25 & dynamic $din_cheat_menu_stats">Защита+25: <<kikdef>></a>'
	if KikDef >= 25: pl'<a href="exec:kikdef -= 25 & dynamic $din_cheat_menu_stats">Защита-25: <<kikdef>></a>'
	pl '<a href="exec:vokal += 25 & dynamic $din_cheat_menu_stats">Вокальные навыки+25: <<vokal>></a>'
	if vokal >= 25: pl'<a href="exec:vokal -= 25 & dynamic $din_cheat_menu_stats">Вокальные навыки-25: <<vokal>></a>'
	if workPTU > 1: pl'<a href="exec:teachlevel += 10 & dynamic $din_cheat_menu_stats">Репутация учителя+10: <<teachlevel>></a>'
	if workPTU > 1 and teachlevel >= 10: pl'<a href="exec:teachlevel -= 10 & dynamic $din_cheat_menu_stats">Репутация учителя-10: <<teachlevel>></a>'
	if school['progress'] >= 0: pl'<a href="exec:school[''progress''] += 10 & dynamic $din_cheat_menu_stats">Повысить Успеваемость: <<school[''progress'']>></a>'
	if schoolprogul >= 0: pl'<a href="exec:schoolprogul = 0 & dynamic $din_cheat_menu_stats">Обнулить Прогулы: <<schoolprogul>></a>'
}
$din_cheat_menu_reputation = {
	!gs 'stat'
	clr
	pl '<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a></center>'
	pl ''
	_i = 0
	$_cheat_reputation = ''
	:loop_cheat_reputation
	if _i < npc_arrsize:
		if $npc['<<_i>>,know'] > 0:
			$_cheat_reputation += '<tr bgcolor=#f3f4ee><td width=32><a href="exec:gs''npc_editor'',''change_rep'',''-'',<<_i>> & dynamic $din_cheat_menu_reputation"><img src="images/common/icons/down.png" width=30></a></td>'
			$_cheat_reputation += '<td>'+$npc['<<_i>>,name']+' '+$npc['<<_i>>,surname']+'<br>'+func('zz_funcs','scale',val($npc['<<_i>>,relation']),100)+'</td>'
			$_cheat_reputation += '<td width=32><a href="exec:gs''npc_editor'',''change_rep'',''+'',<<_i>> & dynamic $din_cheat_menu_reputation"><img src="images/common/icons/up.png" width=30></a></td></tr>'
		end
		_i += 1
		jump 'loop_cheat_reputation'
	end
	pl '<center><table cellpadding=0 cellspacing=0 width=300 align=center border=0><<$_cheat_reputation>></table></center>'
	killvar '$_cheat_reputation'
	killvar '_i'
	if bfA > 0:
		pl''
		if bfA < 0: bfA = 0
		if daya < 0: daya = 0
		if harakBoyA > 2: harakBoyA = 0
		if izvratA > 1: izvratA = 0
		pl'<a href="exec:harakBoyA += 1 & dynamic $din_cheat_menu_reputation">Изменить характер парня: <<harakBoyA>></a>'
		pl'<a href="exec:izvratA += 1 & dynamic $din_cheat_menu_reputation">Изменить извращнность парня: <<izvratA>></a>'
		pl'<a href="exec:bfA += 10 & dynamic $din_cheat_menu_reputation">Увеличить отношения с парнем: <<bfA>></a>'
		pl'<a href="exec:bfA -= 10 & dynamic $din_cheat_menu_reputation">Уменьшить отношения с парнем: <<bfA>></a>'
		pl'<a href="exec:daya += 5 & dynamic $din_cheat_menu_reputation">Увеличить срок отношений с парнем: <<daya>></a>'
		pl'<a href="exec:daya -= 5 & dynamic $din_cheat_menu_reputation">Уменьшить срок отношений с парнем: <<daya>></a>'
	end
	pl''
	if GorSlut > 0:pl'В Павлово вы известны как <<$gnikname>> (<<GorSlut>>)'
	if GorSlut = 0:pl'У вас хорошая репутация в Павлово (0)'
	if GorSlut ! 1:pl'<a href="exec:GorSlut = 1 & dynamic $din_cheat_menu_reputation">Сменить репутацию на "Давалка" (1)</a>'
	if GorSlut ! 2:pl'<a href="exec:GorSlut = 2 & dynamic $din_cheat_menu_reputation">Сменить репутацию на "Вафлерша" (2)</a>'
	if GorSlut ! 3:pl'<a href="exec:GorSlut = 3 & dynamic $din_cheat_menu_reputation">Сменить репутацию на "Общая хуесоска" (3)</a>'
	if GorSlut ! 4:pl'<a href="exec:GorSlut = 4 & dynamic $din_cheat_menu_reputation">Сменить репутацию на "Общая дырка" (4)</a>'
	if GorSlut ! 5:pl'<a href="exec:GorSlut = 5 & dynamic $din_cheat_menu_reputation">Сменить репутацию на "Опущенная шалава" (5)</a>'
	if GorSlut ! 6:pl'<a href="exec:GorSlut = 6 & dynamic $din_cheat_menu_reputation">Сменить репутацию на "Проститутка" (6)</a>'
	if GorSlut > 0:pl'<a href="exec:GorSlut = 0 & dynamic $din_cheat_menu_reputation">Очистить репутацию в Павлово (0)</a>'
	if opusk > 0 or sipovka > 0 or rozetka > 0:pl'<a href="exec:opusk = 0 & sipovka = 0 & rozetka = 0 & dynamic $din_cheat_menu_reputation">Очистить репутацию у гопников</a>'
}
$din_cheat_menu_documents = {
	gs 'stat'
	clr
	pl '<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a></center>'
	pl ''
	if school['certificate'] = 0: pl'<a href="exec:school[''certificate''] = 1 & dynamic $din_cheat_menu_documents">Получить Атестат</a>'
	if school['certificate'] = 1: pl'У вас уже есть Атестат'
	if diplom = 0:pl'<a href="exec:diplom = 1 & dynamic $din_cheat_menu_documents">Получить Диплом</a>'
	if diplom = 1:pl'У вас уже есть Диплом'
	if secrdiplom = 0:pl'<a href="exec:secrdiplom = 1 & dynamic $din_cheat_menu_documents">Получить Диплом Секретаря</a>'
	if secrdiplom = 1:pl'У вас уже есть Диплом Секретаря'
	if masash < 10:pl'<a href="exec:masash = 10 & dynamic $din_cheat_menu_documents">Получить Сертификат Массажиста</a>'
	if masash >= 10:pl'У вас уже есть Сертификат Массажиста'
	if prava = 0:pl'<a href="exec:prava = 1 & dynamic $din_cheat_menu_documents">Получить Права</a>'
	if prava = 1:pl'У вас уже есть Права'
}
$din_cheat_menu_time = {
	gs'stat'
	clr
	pl'<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a></center>'
	pl''
	pl'Сейчас <<$week>> <<day>> <<$month>>, <<year>> год.'
	pl'<a href="exec:dynamic $din_cheat_menu_week">Выбрать День Недели</a>'
	pl'<a href="exec:day += 1 & dynamic $din_cheat_menu_time">+1 День</a>'
	pl'<a href="exec:day -= 1 & dynamic $din_cheat_menu_time">-1 День</a>'
	pl'<a href="exec:dynamic $din_cheat_menu_month">Выбрать Месяц</a>'
	pl'<a href="exec:year += 1 & dynamic $din_cheat_menu_time">+1 Год</a>'
	pl'<a href="exec:year -= 1 & dynamic $din_cheat_menu_time">-1 Год</a>'
	pl '<b>' + func('zz_funcs', 'make_datetime', hour, minut, ':') + '</b>'
	$SS=''
	pl'Часы:'
	if hour>0: $SS ='<a href="exec:hour -= 1 & dynamic $din_cheat_menu_time">-1</a> ' else $SS='	'
	if hour!0: $SS += '<a href="exec:hour = 0 & dynamic $din_cheat_menu_time">0</a> ' else $SS+='	'
	if hour<23: $SS += '<a href="exec:hour += 1 & dynamic $din_cheat_menu_time">+1</a>'
	pl $SS
	$SS=''
	pl'Минуты:'
	if minut>15: $SS='<a href="exec:minut -= 15 & dynamic $din_cheat_menu_time">-15</a> ' else $SS='	'
	if minut>0: $SS='<a href="exec:minut -= 1 & dynamic $din_cheat_menu_time">-1</a> ' else $SS='	'
	if minut!0: $SS += '<a href="exec:minut = 0 & dynamic $din_cheat_menu_time">0</a> ' else $SS=$SS+'	'
	if minut<59: $SS += '<a href="exec:minut += 1 & dynamic $din_cheat_menu_time">+1</a>'
	if minut<45: $SS += '<a href="exec:minut += 15 & dynamic $din_cheat_menu_time">+15</a>'
	pl $SS
}
$din_cheat_menu_week = {
	gs'stat'
	clr
	pl'<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a> - <a href="exec:dynamic $din_cheat_menu_time"><b>Время</b></a></center>'
	pl''
	pl'Сейчас <<$week>> <<day>> <<$month>>, <<year>> год.'
	pl'<a href="exec:week = 1 & dynamic $din_cheat_menu_time">Понедельник</a>'
	pl'<a href="exec:week = 2 & dynamic $din_cheat_menu_time">Вторник</a>'
	pl'<a href="exec:week = 3 & dynamic $din_cheat_menu_time">Среда</a>'
	pl'<a href="exec:week = 4 & dynamic $din_cheat_menu_time">Четверг</a>'
	pl'<a href="exec:week = 5 & dynamic $din_cheat_menu_time">Пятница</a>'
	pl'<a href="exec:week = 6 & dynamic $din_cheat_menu_time">Суббота</a>'
	pl'<a href="exec:week = 7 & dynamic $din_cheat_menu_time">Воскресенье</a>'
}
$din_cheat_menu_month = {
	gs'stat'
	clr
	pl'<center><a href="exec:dynamic $objcheat_menu"><b>Чит меню</b></a> - <a href="exec:dynamic $din_cheat_menu_time"><b>Время</b></a></center>'
	pl''
	pl'Сейчас <<$week>> <<day>> <<$month>>, <<year>> год.'
	$_str[0] = 'Январь'
	$_str[1] = 'Февраль'
	$_str[2] = 'Март'
	$_str[3] = 'Апрель'
	$_str[4] = 'Май'
	$_str[5] = 'Июнь'
	$_str[6] = 'Июль'
	$_str[7] = 'Август'
	$_str[8] = 'Сентябрь'
	$_str[9] = 'Октябрь'
	$_str[10] = 'Ноябрь'
	$_str[11] = 'Декабрь'
	i = 0
	:loop_set_month
	if i < 12:
		pl'<a href="exec:month = '+(i+1)+' & dynamic $din_cheat_menu_time">'+$_str[i]+'</a>'
		i += 1
		jump 'loop_set_month'
	end
	killvar '$_str'
}
$objcheat_menu = {
	gs'stat'
	clr
	pl'<center><a href="exec:gs''stat''"><b>Выйти из чит меню</b></a></center>'
	pl''
	pl'<a href="exec:dynamic $din_cheat_menu_permanent"><b>Перманентные</b></a>'
	pl'<a href="exec:dynamic $din_cheat_menu_look"><b>Внешность</b></a>'
	pl'<a href="exec:dynamic $din_cheat_menu_stats"><b>Характеристики</b></a>'
	pl'<a href="exec:dynamic $din_cheat_menu_reputation"><b>Отношения и Репутация</b></a>'
	pl'<a href="exec:dynamic $din_cheat_menu_documents"><b>Документы</b></a>'
	pl'<a href="exec:dynamic $din_cheat_menu_time"><b>Манипуляции временем</b></a>'
	pl''
	pl'<a href="exec:health = 100 & manna = 100 & vgape = 0 & agape = 0 & nippain = 0 & dynamic $objcheat_menu">Полное восстановление здоровья, манны, разума.</a>'
	pl'<a href="exec:dynamic $din_cheat_money">Изменить количество денег</a>'
	pl'<a href="exec:money = 0 & gs''stat''">Обнулить деньги</a>'
	pl''
	pl'Окно предпросмотра:'
	pl'<a href="exec:preview_win = 0 & dynamic $objcheat_menu">Скрывать</a>'
	pl'<a href="exec:preview_win = 1 & dynamic $objcheat_menu">Показывать лицо</a>'
	pl'<a href="exec:preview_win = 2 & dynamic $objcheat_menu">Показывать тело</a>'
	pl'<a href="exec:preview_win = 3 & dynamic $objcheat_menu">Показывать одежду</a>'
}
$objface = {
	view func('zz_common','get_hero_face')
}
$objbody = {
	if body['group'] = 0:
		if (stren + vital) >= 50:
			view 'images/picb/body/fit/0.jpg'
		else
			view 'images/picb/body/normal/3.jpg'
		end
	elseif body['group'] = 1:
		if (stren + vital) < 50:
			view 'images/picb/body/normal/5.jpg'
		elseif (stren + vital) >= 50 and (stren + vital) < 100:
			view 'images/picb/body/fit/3.jpg'
		else
			view 'images/picb/body/fit/4.jpg'
		end
		bodykoef = 3
	elseif body['group'] = 2:
		if (stren + vital) >= 50:
			view 'images/picb/body/fit/5.jpg'
		else
			view 'images/picb/body/normal/9.jpg'
		end
		bodykoef = -3
	elseif body['group'] = 3:
		if (stren + vital) >= 50:
			view 'images/picb/body/fit/6.jpg'
		else
			view 'images/picb/body/normal/11.jpg'
		end
		bodykoef = -5
	elseif body['group'] = 4:
		if (stren + vital) >= 50:
			view 'images/picb/body/fit/7.jpg'
		else
			view 'images/picb/body/normal/12.jpg'
		end
		bodykoef = -10
	end
}
$objclothes = {
	if current_clothing = 0 and tanga = 0:
		view 'images/clothing/0.jpg'
	elseif current_clothing = 0 and tanga = 1:
		view 'images/clothing/tanga.jpg'
	elseif current_clothing = 1:
		view 'images/clothing/1.jpg'
	elseif current_clothing = 2:
		view 'images/nigma/gor/lake/lake.walk.bikini0,3.jpg'
	else
		view func('zz_clothing','get_image_path')
	end
}
$objtattoos = {
	$show_tattoo = {
		view 'images/picb/tattoo/'+$args[0]+'/'+(args[1]-1)+'.jpg'
	}
	clr
	if tattoo['lip'] > 0: pl'<a href="exec: dynamic $show_tattoo,''lip'',<<tattoo[''lip'']>>">Тату на губе</a>'
	if tattoo['shoulder'] > 0:pl'<a href="exec: dynamic $show_tattoo,''shoulder'',<<tattoo[''shoulder'']>>">Тату на плечах</a>'
	if tattoo['back'] > 0:pl'<a href="exec: dynamic $show_tattoo,''back'',<<tattoo[''back'']>>">Тату на спине</a>'
	if tattoo['waist'] > 0:pl'<a href="exec: dynamic $show_tattoo,''waist'',<<tattoo[''waist'']>>">Тату на пояснице</a>'
	if tattoo['vag'] > 0:pl'<a href="exec: dynamic $show_tattoo,''vag'',<<tattoo[''vag'']>>">Тату в паху</a>'
	if tattoo['leg'] > 0:pl'<a href="exec: dynamic $show_tattoo,''leg'',<<tattoo[''leg'']>>">Тату на ногах</a>'
	if (tattoo['lip'] + tattoo['shoulder'] + tattoo['back'] + tattoo['waist'] + tattoo['leg'] + tattoo['vag']) = 0:
		pl 'У вас девственно чистое тело. Не в плане разврата, а в плане тату.'
	end
}
$objpirsing = {
	$dipirsA = {
		view 'images/picb/piercing/pirsA.jpg'
	}
	$dipirsB = {
		view 'images/picb/piercing/pirsB.jpg'
	}
	$dipirsC = {
		view 'images/picb/piercing/pirsC.jpg'
	}
	$dipirsD = {
		view 'images/picb/piercing/pirsD.jpg'
	}
	$dipirsE = {
		view 'images/picb/piercing/pirsE.jpg'
	}
	$dipirsF = {
		view 'images/picb/piercing/pirsF.jpg'
	}
	$dipirsG = {
		view 'images/picb/piercing/pirsG.jpg'
	}
	$dipirsN = {
		view 'images/picb/piercing/pirsN.jpg'
	}
	$dipirsGL = {
		view 'images/picb/piercing/pirsCli.jpg'
	}
	$dipirspiz = {
		view 'images/picb/piercing/pirscligub.jpg'
	}
	clr
	if pirsA = 1: pl 'Ваш язык проколот и туда вставлена маленькая штанга, которая постоянно чувствуется во рту. <a href="exec:dynamic $dipirsA">Посмотреть</a>'
	if pirsB = 1: pl 'У вас проколота нижняя губа и туда вдето колечко. <a href="exec:dynamic $dipirsB">Посмотреть</a>'
	if pirsC = 1: pl 'На ваших ушах висят сережки. <a href="exec:dynamic $dipirsC">Посмотреть</a>'
	if pirsD = 1: pl 'У вас маленькое колечко в носу. <a href="exec:dynamic $dipirsD">Посмотреть</a>'
	if pirsE = 1: pl 'В вашу бровь вставлена штанга. <a href="exec:dynamic $dipirsE">Посмотреть</a>'
	if pirsF = 1: pl 'У вас проколоты соски и в них вставлены маленькие металлические штанги. <a href="exec:dynamic $dipirsF">Посмотреть</a>'
	if pirsN = 1: pl 'У вас проколот пупок и туда вставлена штанга. <a href="exec:dynamic $dipirsN">Посмотреть</a>'
	if pirsG = 1 and pirsGL = 0: pl 'У вас проколоты половые губы и туда вставлены колечки. <a href="exec:dynamic $dipirsG">Посмотреть</a>'
	if pirsG = 0 and pirsGL = 1: pl 'У вас проколот клитор и туда вставлена штанга.<a href="exec:dynamic $dipirsGL">Посмотреть</a>'
	if pirsG = 1 and pirsGL = 1: pl 'У вас проколот клитор и в половых губах висят колечки.<a href="exec:dynamic $dipirspiz">Посмотреть</a>'
}
$objbloknot = {
	clr
	if uber['work'] = 1:
		pl 'Вы работаете в службе такси "Довезёт". Рабочие дни - ПН,ВТ,ЧТ,ПТ,СБ.'
		pl 'Текущая смена - ' + iif(uber['work_week']=1,'утренняя, с 08.00','вторая дневная, с 16.00')
		pl 'Отработано смен на этой неделе - ' + uber['work_week_count']
		pl 'Прогулов - ' + uber['work_absent']
		pl '<hr>'
	end
	if housr > 0: pl 'Вы живете в двухкомнатной квартире в Южном районе. Оплата за квартиру снимается автоматически, в сумме 3000 рублей 25-го числа каждого месяца. Электричество оплачивается отдельно.<hr>'
	if workPTU > 2: pl 'Вы работаете преподавателем в лицее. Рабочие дни ПН-СБ, с 14.00 до 16.00. Зарплата 300р/день. Форма одежды - офисная, строгая. Дорога от квартиры до лицея занимает 2 часа 10 минут.<hr>'
	if work = 1:
		if workKafe > 0: pl 'Вы работаете официанткой в кафе. На работу нужно приходить в промежуток с 11.00 до 12.00; рабочие дни - вторник, среда, четверг. На работе каждый день получаешь чаевые от клиентов. Зарплата автоматически перечисляется на карту 25-го числа.<hr>'
		if workhosp > 0: pl 'Вы работаете медсестрой в поликлинике. На работу нужно приходить в промежуток с 08.00 до 09.00 в будние дни. Зарплата автоматически перечисляется на карту 25-го числа месяца.<hr>'
		if worksalon > 0: pl 'Вы работаете массажисткой в салоне. На работу нужно приходить с 9 до 10, рабочие дни, понедельник, среда, пятница. Зарплата автоматически перечисляется на карту 25-го числа месяца.<hr>'
		if workSec > 0: pl' Вы работаете секретарем в офисе. На работу нужно приходить до 9, в будни. Зарплата автоматически перечисляется 25го числа.<hr>'
		if tanwork > 0: pl' Вы работаете гувернанткой у Тани. Зарплата автоматически перечисляется 25го числа.<hr>'
		if young_shop_work = 1: pl 'Вы работаете продавщицей в магазине "Кис-Киска". На работу нужно приходить в 15.00. Рабочие дни - понедельник-пятница, суббота и воскресенье - выходные. Зарплата выдается наличными раз в неделю по пятницам в конце смены.<hr>'
		if workFabrika = 1: pl 'Вы работаете швеёй на фабрике в Павлово. Рабочие дни - понедельник-пятница, суббота и воскресенье - выходные. Зарплата автоматически перечисляется на карту 25-го числа месяца.<hr>'
	end
	if workrin = 1: pl 'Вы работаете на рынке в палатке Рустама продавщицей одежды. Работа по вторникам, четвергам и субботам, приходить на работу нужно в 08.00 часов. Зарплата зависит от продаж.<hr>'
	if stripwork >= 1: pl 'Вы работаете стриптизёршей, график свободный, в любой день с 15.00 до 02.00. Зарплата только чаевые.<hr>'
	if pfilmSTOP = 1: pl '<<$pfilmstory_new>><hr>'
	if film > 0:
		pl 'Вы работаете порноактрисой под именем <<$pfname>>, фильмография:'
		! make filmhistory
		i = 0
		$filmtext[0] = 'вы отдрачивали парню и он спускал на ваши сиськи.'
		$filmtext[1] = 'вы отсасывали член у парня и он спускал вам в рот и на лицо.'
		$filmtext[2] = 'вы отсасывали член у парня, потом он трахал вас и кончил вам в рот.'
		$filmtext[3] = 'вы отсасывали член у парня, потом он трахал вас в киску и жопу и спустил вам в рот.'
		$filmtext[4] = 'вас во все дыры дуплят двое мужиков.'
		$filmtext[5] = 'вас долбят во все дыры двое мужиков и даже с двойным проникновением.'
		:loop_films
		if i < film:
			$pfilmhistory += 'Ваш ' + (i+1) + 'й порнофильм' + ' был снят ' + func('zz_funcs','make_datetime',film_history[i+"_"+'day'],film_history[i+"_"+'month'],'.',film_history[i+"_"+'year']) + 'г., в котором ' + $filmtext[film_history[i+"_"+'pfilm']] + '<br>'
			i += 1
			jump 'loop_films'
		end
		pl $pfilmhistory + '<hr>'
		killvar '$pfilmhistory'
		killvar '$filmtext'
	end
	if bumtolik = 4:pl'Служба помощи бездомным находится в Северном районе.<br>'
	if bumtolik = 5:pl'Вы волонтёр в службе помощи бездомным. Рабочие часы с 09.00 до 17.00 с понедельника по пятницу, выходные суббота и воскресенье.<br>'
	if husband > 0:pl'Вы замужем <<husbanday>> дней. Ваш муж <<$husName>> <<$husBody>> <<$husFat>> <<$husHair>>. Отношения <<husband>><br>'
	if $bfsex > 0: pl'<<$bfsex>><br>'
	if bfA > 1: pl'Ваш парень <<$boyA>> <<$boybodyA>> <<$boybodA>> <<$boyfaceA>>.<<$boyA>> <<$boyCloA>> Отношения <<bfA>>, встречались <<dayA>> раз.'
	if harakBoyA = 0 and bfA > 1: pl'У него спокойный и выдержанный характер.'
	if harakBoyA = 1 and bfA > 1: pl'У него весёлый и общительный характер.'
	if harakBoyA = 2 and bfA > 1: pl'У него вспыльчивый и жёсткий характер.'
	if bfB > 1: pl'Ваш парень <<$boyB>> <<$boybodyB>> <<$boybodB>> <<$boyfaceB>>.<<$boyB>> <<$boyCloB>> Отношения <<bfB>>, встречались <<dayB>> раз.'
	if bfC > 1: pl'Ваш парень <<$boyC>> <<$boybodyC>> <<$boybodC>> <<$boyfaceC>>.<<$boyC>> <<$boyCloC>> Отношения <<bfC>>, встречались <<dayC>> раз.'
}
$objavariya = {
	*clr & cla
	'<center><b>ВАМИ ТОЛЬКО ЧТО БЫЛ ИСПОЛЬЗОВАН АВАРИЙНЫЙ ВЫХОД ИЗ БАГА ПУСТОГО ЭКРАНА</b></center>'
	'<center><b>НЕ ИСПОЛЬЗУЙТЕ ЭТУ ВОЗМОЖНОСТЬ БЕЗ ВЕСКОЙ ПРИЧИНЫ: ЭТИМ ВЫ МОЖЕТЕ ВЫЗВАТЬ СБОЙ, КОТОРЫЙ РАЗРУШИТ ВАШИ СОХРАНЕНИЯ</b></center>'
	act 'Далее >>':
		if current_clothing < 3: gs 'zz_clothing', 'fix_emergency'
		gt iif($control_point = '','gorodok',$control_point)
	end
}
$objnewmenu = {
	killobj
	oldobjmenu = 0
	addobj '<img src="images/common/icons/pers.png">'
	addobj '<img src="images/common/icons/look.png">'
	addobj '<img src="images/common/icons/proch.png">'
	addobj '<img src="images/common/icons/purse.png">'
}
$objoldmenu = {
	killobj
	oldobjmenu = 1
	addobj '<font color = green>Персонаж</font>'
	addobj 'Навыки'
	addobj 'Статистика'
	addobj 'Лицо'
	addobj 'Тело'
	addobj 'Одежда'
	addobj 'Татуировки'
	addobj 'Пирсинг'
	addobj 'Записная книжка'
	addobj 'Список NPC'
	addobj 'Аварийный выход'
	addobj 'Обновить'
	addobj 'Новое меню'
	addobj 'Чит меню'
	addobj 'Настройки'
	addobj 'Сумочка'
}
$menu_character[0] = 'Описание:$menu_descrip'
$menu_character[1] = 'Характеристики:$menu_skills'
$menu_character[2] = 'Статистика:$menu_statistika'
$menu_character[3] = 'Репутация:$menu_reputation'
$menu_character[4] = 'Отношения:$menu_relation'
$menu_character[5] = 'Список NPC:$menu_npc_list'
$menu_lookon[0] = 'Лицо:$menu_face'
$menu_lookon[1] = 'Тело:$menu_body'
$menu_lookon[2] = 'Одежда:$menu_clothes'
$menu_lookon[3] = 'Татуировки:$menu_tattoos'
$menu_lookon[4] = 'Пирсинг:$menu_pirs'
$menu_other[0] = 'Обновить:$menu_obnovit'
$menu_other[1] = 'Записная книжка:$menu_bloknot'
$menu_other[2] = 'Аварийный выход:$menu_avariya'
$menu_other[3] = 'Старое меню:$menu_addoldmenu'
$menu_other[4] = 'Чит меню:$menu_cheat'
$menu_other[5] = 'Настройки:$menu_settings'
!Старое меню: начало
if $selobj = '<font color = green>Персонаж</font>': dynamic $objdescrip
if $selobj = 'Навыки': dynamic $objskills
if $selobj = 'Статистика': dynamic $objstatistika
if $selobj = 'Лицо': dynamic $objface
if $selobj = 'Тело': dynamic $objbody
if $selobj = 'Одежда': dynamic $objclothes
if $selobj = 'Татуировки': dynamic $objtattoos
if $selobj = 'Пирсинг': dynamic $objpirsing
if $selobj = 'Записная книжка': dynamic $objbloknot
if $selobj = 'Аварийный выход': dynamic $objavariya
if $selobj = 'Список NPC': gt 'npc_editor','get_npc_list'
if $selobj = 'Обновить': gs 'stat'
if $selobj = 'Новое меню': dynamic $objnewmenu
if $selobj = 'Чит меню': dynamic $objcheat_menu
if $selobj = 'Сумочка': dynamic $d_bag
if $selobj = 'Настройки': unselect & gt 'zz_render_settings','tabs'
!Старое меню: конец
!Новое меню: начало
if $selobj = '<img src="images/common/icons/pers.png">': menu '$menu_character'
if $selobj = '<img src="images/common/icons/look.png">': menu '$menu_lookon'
if $selobj = '<img src="images/common/icons/proch.png">': menu '$menu_other'
if $selobj = '<img src="images/common/icons/purse.png">': dynamic $d_bag
unselect