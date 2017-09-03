$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
minut += 1
housrA = 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Кухня','images/city/south/apartment/kuhr'+iif(my_house = 1,'',iif(remkuhr = 0,0,iif(remkuhr = 1,1,iif(remkuhr = 2,2,3))))+'.jpg',''
if rand(1,iif(remkuhr < 2 or my_house = 1,50,iif(remkuhr = 2,75,100))) = 1 and santehnikDolg = 0:kransloman = 1
if kransloman = 1:
	manna -= 20
	gs 'zz_render', '', '','<red>У вас сломался кран, надо вызвать сантехника.</red>'
	if Grisha = 0: act '<b>Вызвать сантехника</b>': gt 'apartment_south_event','plumber_start'
	if Grisha > 0: act '<b>Вызвать сантехника Гришу</b>': gt 'apartment_south_event','plumber_Grisha'
end
if posudomashina > 0 and my_house = 2 and remkuhr >= 2 and kransloman = 0 and dirttarelka > 0:
	if fairy >= dirttarelka:
		cltarelka += dirttarelka
		fairy -= dirttarelka
		dirttarelka = 0
		gs 'zz_render', '', '','Посудомоечная машина вымыла грязную посуду.'
	else
		gs 'zz_render', '', '','Посудомоечной машине не хватает моющего средства для работы.'
	end
end
gs 'zz_render', '', '',iif(cltarelka > 0,'Над раковиной стоит <b><<cltarelka>></b> штук чистых тарелок','<b><font color = red>У вас не осталось чистой посуды.</font></b>')
if dirttarelka > 0: gs 'zz_render', '', '','В раковине лежат <b><<dirttarelka>></b> штук грязных тарелок. '+iif(kransloman = 0,'<a href="exec: gt''apartment_south_event'',''dirtarm'' ">Которые можно бы и помыть</a>.','')
gs 'zz_render', '', '',iif(fairy > 0,'Над раковиной стоит моющее средство для посуды, которого хватит на <b><<fairy>></b> раз.','<b><font color = red>Вам не чем мыть посуду, нужно купить моющее средство для посуды.</font></b>')
if eda > 0 or eat_diet > 0: gs 'zz_render', '', '','В холодильнике хранится '+iif(eda > 0,'еда которой хватит на <b><<eda>></b> порци'+iif(eda = 1,'ю',iif(eda < 5,'и','й'))+', которую можно <a href="exec: gt''apartment_south_event'',''edagotd''">приготовить</a>','')+'.'
if edaD = 0 and eda = 0: gs 'zz_render', '', '','<b><font color = red>В холодильнике шаром покати, вообще нечего есть.</font></b>'
if posudomashina > 0: gs 'zz_render', '', '',iif(my_house = 2 and remkuhr >= 2,'На кухне установлена посудомоечная машина.','У вас есть посудомоечная машина, но подключить её невозможно.')
if edahot > 0: gs 'zz_render', '', '','На плите стоит <b><<edahot>></b> порци'+iif(edahot = 1,'я',iif(edahot < 5,'и','й'))+' приготовленной еды.'
if husband > 0 and husbandrink ! 10 and (hour = 7 or hour = 17): gs 'zz_render', '', '','<a href="exec: gt''husb'',''start'' ">За столом ест муж.</a>'
act 'В коридор': gt'korr'
gs 'zz_kitchen_acts', 'all', 1
if garbage > 10:
	manna -= iif(garbage < 15,5,iif(garbage < 25,10,20))
	gs 'zz_render', '', '','Возле мойки стоит полное ведро мусора'+iif(garbage < 15,'.',iif(garbage < 25,', от которого начинает пованивать.',', от которого нестерпимо воняет, и над ним кружатся мухи.'))
	if current_clothing > 2: act 'Выкинуть мусор':minut += 10 & take_out_trash = 1 & gt 'trashplace'
end
if horny >= 60:act 'Мастурбировать':gt 'apartment_south_event','selfplay_start'