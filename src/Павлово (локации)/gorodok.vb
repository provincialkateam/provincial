$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
! point for emergency button
$control_point = $curloc
!---
if health < 5 and rand(0,10) < 2: gt 'short_random','divine_intervention'
! птушники подкатывают к Светке-давалке
if func('zz_weather','is_day') = 1 and hour >= 12 and rand(0,5) = 1 and $npc['0,park_slut_event'] ! day and shameless['flag'] >= 3 and mesec = 0:
	gt 'park_events',iif($npc['0,park_slut_counter'] <= 5,'slut_ev1','slut_ev5')
end
!---
!мини-ивенты:
gs 'short_random','check'
!---
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
gs 'zz_render', 'Павлово', func('zz_funcs','mk_image','pavlovo/street/str')
if _taxi_time >= 0: gs 'taxi','check'
gs 'zz_loc_desc'
!if hour = 7 or hour = 8:
	!gs 'zz_render','','','<a href="exec:GT ''short_random'',''babushki''">Бабушки</a> сидящие у подъезда. Сколько вы себя помните - они здесь всегда сидят, обсуждая увиденное в "тиливизере" и всех мимо проходящих.'
!end
gs 'zz_funcs', 'waiting'
gs 'pavlovo_events', 'meet_misha'
gs 'car','check'
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
act 'Во двор' : gt 'ghomeyard'
gs 'zz_dyns', 'street_cum'
if RAND(1,5) >= 4:
	if func('zz_reputation','get') = 3: gs 'zz_render','','','Вы ловите на себя взгляды людей, некоторые пытаются узнать в вас кого-то, а может, и узнают. Изредка вы слышите смешки людей. Похоже, кто-то узнал о ваших похождениях.'
	if func('zz_reputation','get') = 4: gs 'zz_render','','','Все окружающие узнают в вас шлюху. Некоторые, проходя мимо, шлёпают вас по попе. Бабушки на лавочках обзывают вас блядью.'
end
if func('zz_reputation','get') = 4 and RAND(1,20) = 10:
	cla
	gs 'zz_render','','','К вам подходит парень и предлагает отойти в кусты перепихнуться за пятихатку.'
	act 'Согласиться': gt 'gevent','5'
	act 'Отказаться': gt $curloc
end
if rand(1,100) <= 40 and belgangQW > 0 and hour >= 15 and hour < 21 and daybelisex!daystart: gs 'belyi_events', 'meet'