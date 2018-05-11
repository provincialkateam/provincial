$metka = $ARGS[0]
$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
minut += 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
act func('sitrPar_strings'+$lang, 'act1'): gt 'korrPar'
gs 'zz_render',func('sitrPar_strings'+$lang, 'act2'),'pavlovo/family/apartment/sitr',func('sitrPar_strings'+$lang, '1')
gs 'zz_family', 'mother_sheduler'
if father['in_garage'] = 0: gs 'zz_family', 'father_sheduler'
gs 'zz_family', 'brother_sheduler'
!gs 'zz_family', 'father_sheduler'
if month = 1 and day >= 1 and day <= 6 and hour >= 21 and hour < 23 and brother_newyear_qw = 0 and family_trip = 0: gt 'brother_events','happy_ny',1
if $npc['38,qwKolka'] = 1 and week <=6 and hour = 6 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event2'
if $npc['38,qwKolka'] = 2 and week <=5 and hour = 16 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event3'
if $npc['38,qwKolka'] >= 3 and week <=5 and hour = 16 and rand(1,5) = 1 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event3_sub'
if $npc['38,qwKolka'] = 6 and week >=2 and week <=5 and hour = 16 and minut >= 30 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event7'
if $npc['38,qwKolka'] = 7 and family_trip = 0 and week = 7 and hour >=9 and hour <= 11 and lubri > 0 and $npc['38,qwotchim'] = 1: gt 'sisterQW','incest_event8'
if $npc['38,qwKolka'] >= 8 and week = 6 and hour = 10 and family_trip = 0 and lubri > 0 and horny > 60: gt 'sisterQW','incest_event8sub'
! если гг голой или бухой в стельку завалилась в зал
if cloth[0] <= 2 or alko >= 6:
	if $mother['location'] = $curloc: *clr & gs 'mother' & exit
	if $father['location'] = $curloc: *clr & gs 'zz_father','main' & exit
end
!---
if $npc['26,qwMain'] = 125 and $father['location'] = $curloc: gt 'tsarev_events','teacher_choice_detective12'
!---
	if $mother['location'] = $curloc and $father['location'] = $curloc and $brother['location'] = $curloc and $family['tv_day'] ! day:
		act 'Посмотреть телек с семьёй': gt $curloc, 'family_watch_tv'
	end
!---
if week ! 7 and $father['location'] = $curloc and $father['location'] ! $brother['location'] and $father['location'] ! $mother['location'] and father['clean_day'] ! day and hour <= 19:
	gs 'zz_father','cleaning'
end
if month = 12 and day >= 25: gs 'zz_render','','',func('kuhrPar_strings'+$lang, '2')
if month = 12 and day = 31 and hour >= 20:
	act func('kuhrPar_strings'+$lang, 'act3'):
		*clr & cla
		gs 'npc_editor','change_rep','+', 37, 20
		gs 'npc_editor','change_rep','+', 35, 20
		gs 'npc_editor','change_rep','+', 38, 20
		gs 'npc_editor','change_rep','+', 39, 20
		money += 5000
		body['day_weight'] += 1
		hour = 23
		minut += 120
		manna += 50
		energy += 20
		water += 20
		gs 'stat'
		gs 'zz_render','','pavlovo/family/newyear',func('kuhrPar_strings'+$lang, '3')
		act func('kuhrPar_strings'+$lang, 'act6'): gt $curloc
	end
elseif month = 1 and day = 1:
	act func('kuhrPar_strings'+$lang, 'act4'):
		*clr & cla
		gs 'zz_render','','pics/food.jpg'
		minut += 15
		cumlip = 0
		body['day_weight'] += 1
		if energy >= 50:
			gs 'zz_render','','',func('kuhrPar_strings'+$lang, '4')
		else
			gs 'zz_render','','',func('kuhrPar_strings'+$lang, '5')
			health += 10
			manna += 20
			energy += 20
			water += 20
		end
		gs 'stat'
		act func('kuhrPar_strings'+$lang, 'act5'): gt $loc, $metka
	end
end
if $args[0] = 'family_watch_tv':
*clr & cla
	gs 'zz_render', '', 'pavlovo/family/apartment/family_tv.jpg', 'В комнате слышны тихие разговоры:
							' + func('family_smalltalks_data', 'tv_talk')
	gs 'npc_editor','change_rep','+', 37
	gs 'npc_editor','change_rep','+', 35
	gs 'npc_editor','change_rep','+', 38
	gs 'npc_editor','change_rep','+', 39
	manna += rand(1,5)
	minut += rand(50,70)
	$family['tv_day'] = day
	gs 'stat'
	act 'Отойти': gt $curloc
end