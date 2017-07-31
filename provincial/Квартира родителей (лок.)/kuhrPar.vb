$loc = $curloc
gs 'zz_phone','boyfriend_call_init'
minut += 1
gs 'zz_funcs', 'colorize_day'
if $npc['38,qwKolka'] = 3 and week <=4 and horny >= 30 and hour = 0: gt 'sisterQW','incest_event4'
if $npc['38,qwKolka'] = 4 and week <=5 and horny >= 30 and hour = 6 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event5'
! семейство завтракает
act '<b>Выйти из комнаты</b>': gt 'korrPar'
if hour = 7 and family_trip = 0:
	! отчим рассказывает ГГ о Соне
	if $npc['25,qwSonya'] = 20 and $npc['25,qwSonya_day'] ! day: gt 'sonya','father_talk_about_sonya'
	! --
	$_str = 'За столом сидят и завтракают <a href="exec:gt''zz_father'',''main''">отчим</a> и ваш брат <a href="exec:gt''zz_brother'',''main''">Колька</a>. <a href="exec:gt''mother''">Мать</a>, как всегда, крутится возле плиты.'
	! по буднях Анька тоже здесь
	if week <= 5: $_str += '<br><a href="exec:gt''sister''">Анька</a>, хоть и говорит, что против диет, но с утра лишь чаюет.'
else
	$_str = 'На кухне, рядом с плитой, находится мойка. Большой холодильник стоит в углу. У стены находится кухонный стол со стульями.'
end
gs 'zz_render', 'Кухня', 'pavlovo/family/apartment/kuhr', $_str
killvar '$_str'
gs 'zz_family', 'mother_sheduler'
gs 'zz_family', 'father_sheduler'
if $mother['location'] = $curloc and (current_clothing <= 2 or alko >= 6): *clr & gs 'mother' & exit
gs 'zz_kitchen_acts', 'all'
gs 'KolkaPrince', 'main'