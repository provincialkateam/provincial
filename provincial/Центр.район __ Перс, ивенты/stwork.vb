$stripgirl = {
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('stwork_strings', 'local_str1')
	striptalkrand = RAND(0,10)
	if striptalkrand = 0: 'Слышали? Тут как-то приходила одна девчонка, вся такая красавица, но на сцену вышла, полный ноль, ничего не умеет, так ее только освистали.'
	if striptalkrand = 1: 'Я вам точно говорю, мужиков заводят девчонки с татуировками.'
	if striptalkrand = 2: 'На шесте кончено гораздо выгодней танцевать чем просто стриптиз, легче клиента возбудить, но на этом шесте довольно трудно.'
	if striptalkrand = 3: 'Фух, как не выйду на сцену, возвращаюсь вся потная, волосы растрепанные и макияж обязательно сплывет. Тут на одной косметики разорится можно.'
	if striptalkrand = 4: 'Вообще с этими приватными танцами хоть и гарантированные деньги но не то, на сцене можно больше заработать.'
	if striptalkrand = 5: 'Тут одна страшненькая девчонка была, вышла на сцену, ее давай сразу освистывать, но как начала вокруг шеста крутится, у клиентов челюсти отпали, вполне она не плохо зарабатывала.'
	if striptalkrand = 6: 'И почему менеджер никогда не сообщает, мужской день или женский? Я недавно неслась на работу, даже ноготь сломала, прибегаю, а тут эти медведи скачут на сцене. Развернулась и обратно пошла.'
	if striptalkrand = 7: 'Некоторые девчонки рассказывали что у них проблемы возникают из за работы. Для многих стритизерша равно шлюха.'
	if striptalkrand = 8: 'Тут одна жирная баба пыталась на шесте станцевать, так плюхнулась мордой об пол и поставила крепкий такой синяк.'
	if striptalkrand = 9: 'Недавно одну жирнуху на смех подняли в зале. Вроде и симпотная и танцует хорошо, но не помогло.'
	if striptalkrand = 10: 'Я слышала в приличных клубах за границей стриптизерши сами платят за право работать в клубе.'
	act 'Отойти': gt $curloc, 'start'
}
$stripohr = {
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('stwork_strings', 'local_str2')
	act 'Отойти':gt $curloc, 'start'
}
if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	$metka = $ARGS[0]
	$loc = $CURLOC
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr
	minut += 5
	stripMir = 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Раздевалка для стриптизерш</font></b></center>'
	gs 'zz_render', '', 'images/pic/striprazd.jpg', func('stwork_strings', 'local_str3')
	if tattoo['shoulder'] > 0: stripKoef = RAND(1,3)
	if tattoo['back'] > 0: stripKoef2 = RAND(1,3)
	if tattoo['vag'] > 0: stripKoef3 = RAND(1,3)
	if tattoo['waist'] > 0: stripKoef4 = RAND(3,6)
	if tattoo['leg'] > 0: stripKoef5 = RAND(1,3)
	!publichot = vnesh - 10 + stripKoef + stripKoef2 + stripKoef3 + stripKoef4 + stripKoef5
	publichot = vnesh/2 + stripKoef + stripKoef2 + stripKoef3 + stripKoef4 + stripKoef5
	pl publichot
	publichotstart = publichot
	if hour >= 15 or hour <= 2:
		if mop >= 4:
			if sweat <= 0:
				if leghair <= 0 and lobok <= 0:
					if fingal <= 0:
						act 'Идти на сцену': stpredmet = 3 & gt 'stwork2'
					else
						gs 'zz_render', '', '', func('stwork_strings', 'local_str4')
					end
				else
					gs 'zz_render', '', '', func('stwork_strings', 'local_str5')
				end
			else
				gs 'zz_render', '', '', func('stwork_strings', 'local_str6')
			end
		else
			gs 'zz_render', '', '', func('stwork_strings', 'local_str7')
		end
	else
		gs 'zz_render', '', '', func('stwork_strings', 'local_str8')
	end
end