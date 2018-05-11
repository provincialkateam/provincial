$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
if $npc['38,qwSisterBoy'] > 10: $npc['38,qwSisterBoy'] = 10
minut += 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render',func('bedrPar_strings'+$lang, 'act1'),'pavlovo/family/apartment/bedr.jpg',func('bedrPar_strings'+$lang, '1')
if $npc['38,qwSisterLesbi'] >= 3 and week = 7 and $npc['38,relation'] >= 80 and sister_show = 0 and hour >= 10 and hour <= 11 and family_trip = 0:
	gt 'dinsister', 'sister_show'
end
if (dildo >= 1 or middildo = 1 or largedildo = 1 or bigdildo = 1 or extradildo = 1 or superdildo = 1 or maddildo = 1) and $npc['38,turnirWin'] = 1 and anus >= 13 and shameless['flag'] = 3 and vagina >= 13 and $npc['39,sex'] >= 3 and $npc['38,qwKolka'] = 0 and week = 5 and hour = 23: gt 'sisterQW','incest_event1'
if $npc['38,qwKolka'] >= 5 and $npc['38,qwShopping'] = day and week = 7 and hour = 22 and family_trip = 0:
	if tabletki > 0 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event6'
	if anus >= 13 and vagina >= 18 and largedildo = 1 and horny >= 40: gt 'sisterQW','incest_event6sub'
end
if anus >= 13 and vagina >= 13:
	if $npc['48,incest_event9_flag'] = 1: gt 'sisterQW','incest_event9'
	if $npc['48,incest_event10_flag'] = 1: gt 'sisterQW','incest_event10'
end
if $npc['38,qwmisha'] = 1 and week = 6 and hour = 10 and lubri > 0 and $npc['38,anayslut'] = 0 and $npc['38,wedding'] = 0 and anal >= 18 and vagina >= 18: gt 'sisterQW','incest_event11'
if $npc['38,wedding'] = 1 and hour = 18 and family_trip = 0:gt 'sisterQW','incest_mini1'
if $npc['38,wedding'] = 1 and hour = 17 and family_trip = 0:gt 'sisterQW','incest_mini2'
! init books
if arrsize('books') = 0: gs 'zz_books','init'
if komp = 1: gs 'zz_render','','',func('bedrPar_strings'+$lang, '2')
if sick < 1:
	gs 'zz_common', 'home_workout'
else
	gs 'zz_render','','',func('bedrPar_strings'+$lang, '2')
end
act ''+func('bedrPar_strings'+$lang, 'act2'): gt 'korrPar'
! wait button
gs 'zz_funcs', 'waiting', 1
act func('bedrPar_strings'+$lang, 'act3'): gt 'loker','start'
act func('bedrPar_strings'+$lang, 'act4'): gt 'bed','start'
act func('bedrPar_strings'+$lang, 'act5'): gt 'zz_books','main'
gs 'zz_family', 'brother_sheduler'
gs 'zz_family', 'sister_sheduler'
gs 'zz_common', 'fancywork'
if reading['erotic_enable'] = 1 and hour >= 18 and hour < 21 and func('zz_books','ero_readed') > 0: gt 'zz_books', 'erotic_block'
! add random book to bag
!artrat - выпилил рандомное добавление книжки
!if reading['in_bag'] < 0: gs 'zz_books','book2bag'
if horny >= 50 and $sister['location'] ! $curloc: act func('bedrPar_strings'+$lang, 'act6'): gt 'selfplay'
if pornMagazine > 0:
	gs 'zz_render','','',func('bedrPar_strings'+$lang, '4')
	if $sister['location'] ! $curloc: gs 'zz_common','read_porn'
end
if tovarL > 0: gs 'zz_render','','',func('bedrPar_strings'+$lang, '5')
if card > 0: act func('bedrPar_strings'+$lang, 'act7'): gt 'card'
if $sister['location'] ! $curloc and $npc['26,qwMain_day'] ! day:
	if $npc['26,qwMain'] = 103: gs 'zz_render','','',func('bedrPar_strings'+$lang, '6')
	if $npc['26,qwMain'] >= 105 and $npc['26,qwMain'] <= 112: gs 'zz_render','','',func('bedrPar_strings'+$lang, '7')
	if ($npc['26,qwMain'] = 115 or $npc['26,qwMain'] = 117) and hour >= 8 and hour <= 18 and mesec = 0: gt 'tsarev_events','teacher_choice_detective9'
	if $npc['26,qwMain'] = 120: gt 'tsarev_events','teacher_choice_detective11'
end
!act 'Testroom': gt 'Testroom'
!---
gs 'zz_school','homework'
if university['student'] > 0 and (month <= 6 or month >= 9):
	if university['course'] = 1:
		act func('bedrPar_strings'+$lang, 'act8'): gt'uni_events','course_work'
	else
		act func('bedrPar_strings'+$lang, 'act9'): gt'uni_events','graduate_work'
	end
end
if komp = 1: act func('bedrPar_strings'+$lang, 'act10'): gt 'Komp','start'