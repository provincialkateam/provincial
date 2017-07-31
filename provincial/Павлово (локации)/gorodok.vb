$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
! point for emergency button
$control_point = $curloc
! ---
!мини-ивенты:
if $npc['0,mini_event_day'] ! day and rand(0,10) = 0 and hour > func('zz_weather','sunrize') and hour < func('zz_weather','sunset'):
	$npc['0,mini_event_day'] = day
	if month >= 3 and month <= 10:
		if func('zz_clothing','is_skirt') = 1:
			gt 'short_random','gg_veter'
		elseif sunWeather < 0:
			gt 'short_random','gg_mud'
		end
	end
	gt 'short_random','rand_unigor'
end
!конец мини-ивентов
! завершаем ивент с Альбиной
! Чернов предлагает сдать Альбину
if $npc['23,qwMain'] = 26 or $npc['23,qwMain'] = 36: gt 'AlbFatherQW'
! арест Альбины
if $npc['23,qwMain'] = 70 and $npc['23,arrest_day'] ! day: gt 'albina_ev','stars_end'
!---
gs 'zz_phone','boyfriend_call_init'
boynumBlock = 0
! ------
! разговор с Носовым по поводу "Дианы"
if $npc['4,qwMeetDiana'] = 1 and $npc['4,day'] ! day and (hour >= 15 and hour < 20 and week < 6 or hour >= 8 and hour < 20 and week >= 6): gt 'igor_events','dima_talk1'
! разговор с Носовым по поводу "Дианы", если та не пришла на свидание
if ($npc['4,qwMeetDiana'] = 5 or $npc['4,qwMeetDiana'] = 6) and $npc['4,day'] ! day and (hour >= 15 and hour < 20 and week < 6 or hour >= 8 and hour < 20 and week >= 6): gt 'igor_events','dima_talk3'
! разговор с Носовым по поводу Круглова, после фиаско "Дианы"
if $npc['4,qwMeetDiana'] = 10: gt 'igor_events','dima_talk5'
! Носов поджидает ГГ
if ($npc['1,qwNosovRevenge'] = 2 or $npc['1,qwDimaRude'] = 1 and DimaRudeBlock = 0) and daynosovrevenge < daystart: gt 'pavlovo_events','nosov_meet'
! ------
$npc['37,worry_check'] = iif(hour >= 1 and hour < 5 and school['certificate'] = 0 and age < 18,1,0)
!---
gs 'stat'
gs 'time'
!---
gs 'zz_render', 'Павлово', func('zz_funcs','mk_image','pavlovo/street/str'), 'Провинциальный тихий городишко, неотличимый от тысяч ему подобных. В одной из “хрущёвок” в центре живёт ваша семья. Из окон виднеется большое и красивое <a href="exec: gt ''Glake'',''start''">озеро</a>, на пляжи которого приезжают отдыхать даже из Города, до которого рукой подать - всего сорок минут на электричке с '+func('zz_funcs','mk_link',0,24,'железнодорожного вокзала','vokzalG')
gs 'zz_render', '', '', 'В старенькой пятиэтажке, в <a href="exec:minut += 2 & GT ''pod_ezd'',''etaj_1''">подъезде №1</a> находится ' + iif(ParHomeBlock = 0,'<a href="exec:minut += 5 & GT ''korrPar''">квартира</a>','квартира') + ' ваших родителей.'
if hour = 7 or hour = 8: gs 'zz_render','','','На скамейке у входа в подъезд вечно почти круглогодично восседает группа <a href="exec:GT ''short_random'',''babushki''">бабулек</a>: сколько вы себя помните - они здесь всегда сидят, обсуждая увиденное в "тиливизере" и всех мимо проходящих.'
gs 'zz_render','','','Недалеко от вашего дома находится местная '+func('zz_funcs','mk_link',7,18,'школа','gschool')+' и '+func('zz_funcs','mk_link',0,24,'дом культуры','gdk')+'. Севернее расположился старый '+func('zz_funcs','mk_link',0,24,'парк','zz_park')+'. С ним соседствует '+func('zz_funcs','mk_link',8,16,'районная больница им. Мечникова','gpoli')+', помимо которой не так далеко есть также '+func('zz_funcs','mk_link',8,18,'аптека','apteka','start')+'.
Крупнейший магазин в городе - это '+ func('zz_funcs','mk_link',8,20,'супермаркет','shop')+', конкуренцию ему составляет небольшой, но шумный '+func('zz_funcs','mk_link',8,16,'рынок','grinok')+'.
Любимым местом всех модниц городка является '+func('zz_funcs','mk_link',10,18,'парикмахерская "Локон"','barbershop')
gs 'zz_render','','','Потратить деньги можно в '+func('zz_funcs','mk_link',10,20,'зале игровых автоматов','gamehall')+', работающем на виду у всех под вывеской "Лотерея", а вот из промышленности только - '+func('zz_funcs','mk_link',8,20,'швейная фабрика Имени Парижской коммуны','Gshveyfab')+'.
На отшибе от жилых зданий раскинулся гаражный кооператив, где среди прочих находится <a href="exec:minut += 15 & GT ''gargazel''">гараж</a> вашего отчима с его любимой Газелькой.'
gs 'zz_render','','','Также в городке есть профессиональный лицей с общежитием, но в связи с капитальным ремонтом его территория огорожена высоким забором и у ворот сидит в будочке вечно сонный охранник.'
if $npc['15,qwVika'] >= 27 or ($npc['14,qwKatya'] >= 10 and $npc['14,homeward'] = 1) or $npc['0,meynold_key'] = 1: gs 'zz_render','','','Большой частный дом, в котором живут <a href="exec: gt''mey_home'',-1">близняшки Мейнольд</a>'
if func('zz_common','check_inhome') = 1:
	if DimaBeHomeOnce = 1 and DimaRudeBlock = 0: gs 'zz_render','','','Частный дом, в котором живёт <a href="exec:minut += 15 & GT ''dimaGoHome2''">Дима Носов</a>'
	if $npc['23,qwMain'] = 55: gs 'zz_render','','','Роскошный особняк, в котором живёт <a href="exec:minut += 15 & gt ''albina_ev''">Альбина Барловская</a>'
	if LariskaHomeIn > 0: gs 'zz_render','','','Квартира <a href="exec:minut += 15 & GT ''LariskaHome''">Лариски Груздевой</a>'
	if $npc['4,qwIgorLove'] > 0: gs 'zz_render','','','Квартира в котророй живёт <a href="exec:minut += 15 & gt ''igorhome'', ''kor''">Игорь Круглов</a>'
end
if ($npc['26,qwMain'] = 30 or $npc['26,qwMain'] = 31) or ($npc['26,qwMain'] = 53 or $npc['26,qwMain'] = 55) or ($npc['26,qwMain'] >= 100 and $npc['26,qwMain'] <= 102): gs 'zz_render','','','В частном секторе на окраине Павлово расположился '+func('zz_funcs','mk_link',10,20,'дом Анатолия Евгеньевича','tsarev_events','tsarev_home')
gs 'zz_funcs', 'waiting'
gs 'pavlovo_events', 'meet_misha'
gs 'car','check'
if _taxi_time >= 0: gs 'taxi','check'
! ------
if $npc['23,qwMain'] >= 10 and $npc['23,qwMain'] < 50: gs 'zz_render','','','На домах расклеены большие плакаты: "Борис Барловский - НАШ кандидат!"'
! ------
if rexCar = 1 and rexCarDay = daystart:
	gs 'zz_render','','','У подъезда вас ожидает Рекс.'
	act 'Сесть в машину':
		if hour >= 21 and hour < 23 and $npc['38,qwRexSisTalk'] = 3: gt 'reks', 'avto'
		if hour = 21 and $npc['38,qwRexSisTalk'] = 4: gt 'reks', 'avto2'
	end
end
gs 'zz_dyns', 'street_cum'
if RAND(1,5) >= 4:
	if GorSlut = 3: gs 'zz_render','','','Вы ловите на себя взгляды людей, некоторые пытаются узнать в вас кого-то, а может, и узнают. Изредка вы слышите смешки людей. Похоже, кто-то узнал о ваших похождениях.'
	if GorSlut = 4: gs 'zz_render','','','Люди смотрят на вас с ухмылкой, кто-то делает пошлые жесты в вашу сторону, некоторые намекают на ваши похождения.'
	if GorSlut = 5: gs 'zz_render','','','Все окружающие узнают в вас шлюху. Некоторые, проходя мимо, шлёпают вас по попе. Бабушки на лавочках обзывают вас блядью.'
	if GorSlut = 6: gs 'zz_render','','','В городке знают, что вы проститутка. Некоторые предлагают деньги за ваши услуги. Бабушки на лавочках обзывают вас проституткой.'
end
if GorSlut > 5 and RAND(1,20) = 10:
	cla
	gs 'zz_render','','','К вам подходит парень и предлагает отойти в кусты перепихнуться за пятихатку.'
	act 'Согласиться': gt 'gevent','5'
	act 'Отказаться': gt $curloc
end
if rand(1,100) <= 40 and belgangQW > 0 and hour >= 15 and hour < 21 and daybelisex!daystart: gs 'belyi_events', 'meet'