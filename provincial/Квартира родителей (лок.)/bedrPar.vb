$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
if $npc['38,qwSisterBoy'] > 10: $npc['38,qwSisterBoy'] = 10
minut += 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render','Ваша комната','pavlovo/family/apartment/bedr.jpg','Маленькая комната, куда с трудом втиснулись <a href="exec:GT ''loker'',''start''">шкаф</a>, ваши <a href="exec: gs ''bed'',''start''">кровать</a> и кровать сестры, <a href="exec:GT ''table''">письменный стол</a> и <a href="exec:gt ''zz_books'',''main''">книжная полка</a>.'
if $npc['38,qwSisterLesbi'] >= 3 and week = 7 and $npc['38,relation'] >= 80 and sister_show = 0 and hour >= 10 and hour <= 11 and family_trip = 0:
	gt 'dinsister', 'sister_show'
end
if (dildo >= 1 or middildo = 1 or largedildo = 1 or bigdildo = 1 or extradildo = 1 or superdildo = 1 or maddildo = 1) and $npc['38,turnirWin'] = 1 and anus >= 13 and shameless['flag'] = 3 and vagina >= 13 and $npc['39,sex'] >= 3 and $npc['38,qwKolka'] = 0 and week = 5 and hour = 23: gt 'sisterQW','incest_event1'
if $npc['38,qwKolka'] = 5 and $npc['38,qwShopping'] = day and week = 7 and hour = 22 and family_trip = 0 and tabletki > 0 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event6'
if $npc['38,qwKolka'] >= 6 and $npc['38,qwShopping'] = day and week = 7 and hour = 22 and family_trip = 0 and anus >= 13 and vagina >= 18 and largedildo = 1 and horny >= 40: gt 'sisterQW','incest_event6sub'
! init books
if arrsize('books') = 0: gs 'zz_books','init'
if komp = 1: gs 'zz_render','','','На столе стоит ваш <a href="exec: GT ''Komp'',''start''">ноутбук</a>.'
if sick < 1:
	gs 'zz_common', 'home_workout'
else
	gs 'zz_render','','','Вы болеете, поэтому заниматься физическими упражнениями совсем не хочется.'
end
act 'Выйти из комнаты': gt 'korrPar'
! wait button
gs 'zz_funcs', 'waiting', 1
gs 'zz_family', 'brother_sheduler'
gs 'zz_family', 'sister_sheduler'
gs 'zz_common', 'fancywork'
if reading['erotic_enable'] = 1 and hour >= 18 and hour < 21 and func('zz_books','ero_readed') > 0: gt 'zz_books', 'erotic_block'
! add random book to bag
if reading['in_bag'] < 0: gs 'zz_books','book2bag'
if horny >= 50 and $sister['location'] ! $curloc: act 'Мастурбировать': gt 'selfplay'
if pornMagazine > 0:
	gs 'zz_render','','','Под матрацем у вас спрятан порножурнал.'
	if $sister['location'] ! $curloc: gs 'zz_common','read_porn'
end
if tovarL > 0: gs 'zz_render','','','У вас хранится <<tovarL>> единиц мелкого товара. Максимально вы можете хранить в своей комнате 30 единиц товара.'
if card > 0: act 'Взять колоду карт': gt 'card'
if dur > 0: gs 'zz_render', '', '', 'У вас спрятано <<dur>> доз бледной леди'
if dur > 0 and narkday ! day: gs 'zz_common', 'drug_day'
if $npc['26,qwMain'] = 103 and $sister['location'] ! $curloc:
	gs 'zz_render','','','С вашей головы никак не выходят мысли об увиденном в доме Царева, может, стоит все <a href="exec:gt''tsarev_events'',''teacher_choice_detective4''">тщательно обдумать?</a>'
end
act 'Testroom': gt 'Testroom'