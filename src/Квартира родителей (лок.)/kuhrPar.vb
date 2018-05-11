$loc = $curloc
gs 'zz_phone','boyfriend_call_init'
minut += 1
gs 'zz_funcs', 'colorize_day'
if $npc['38,qwKolka'] = 3 and week <=4 and horny >= 30 and hour = 0: gt 'sisterQW','incest_event4'
if $npc['38,qwKolka'] = 4 and week <=5 and horny >= 30 and hour = 6 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event5'
! семейство завтракает
act func('kuhrPar_strings'+$lang, 'act1'): gt 'korrPar'
if hour = 7 and family_trip = 0:
	! отчим рассказывает ГГ о Соне
	if $family['breakfast_day'] ! day:
		act 'Позавтракать с семьёй': gt $curloc, 'family_breakfast'
	end
	if $npc['25,qwSonya'] = 20 and $npc['25,qwSonya_day'] ! day: gt 'sonya','father_talk_about_sonya'
	! --
	gs 'zz_render', func('kuhrPar_strings'+$lang, 'act2'), 'pavlovo/family/apartment/kuhr',func('kuhrPar_strings'+$lang, '1')
else
	gs 'zz_render', func('kuhrPar_strings'+$lang, 'act2'), 'pavlovo/family/apartment/kuhr',func('kuhrPar_strings'+$lang, '2')
end
gs 'zz_family', 'mother_sheduler'
gs 'zz_family', 'father_sheduler'
gs 'zz_family', 'brother_sheduler'
if $mother['location'] = $curloc and (cloth[0] <= 2 or alko >= 6): *clr & gs 'mother' & exit
gs 'zz_kitchen_acts', 'all'
gs 'KolkaPrince', 'main'
if $args[0] = 'family_breakfast':
*clr & cla
	gs 'zz_kitchen_acts', 'eat'
	gs 'zz_kitchen_acts', 'drink', 'tea'
	gs 'zz_render', '', '', 'Во время заврака происходят занятные разговоры:
							' + func('family_smalltalks_data', 'kitchen_talk')
	gs 'npc_editor','change_rep','+', 37
	gs 'npc_editor','change_rep','+', 35
	gs 'npc_editor','change_rep','+', 38
	gs 'npc_editor','change_rep','+', 39
	$family['breakfast_day'] = day
	gs 'stat'
	act func('sitrPar_strings'+$lang, 'act5'): gt $curloc
end