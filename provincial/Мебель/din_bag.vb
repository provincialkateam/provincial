$d_salf = {
	clr
	salfetka -= 1
	pl'<a href="exec:gs''stat''"><b>Выкинуть салфетку</b></a>'
	if cumface > 0: pl'<a href="exec:cumface -= 1 & gs''stat''"><b>Вытереть лицо</b></a>'
	if cumfrot > 0: pl'<a href="exec: cumfrot -= 1 & gs ''zz_clothing'',''decrease_condition'' & gs''stat''"><b>Вытереть одежду</b></a>'
	if cumbelly > 0: pl'<a href="exec:cumbelly -= 1 & gs''stat''"><b>Вытереть живот</b></a>'
	if cumass > 0: pl'<a href="exec:cumass -= 1 & gs''stat''"><b>Вытереть попку</b></a>'
	if mop ! 1: pl'<a href="exec:mop = 1 & gs''stat''"><b>Стереть косметику</b></a>'
}
$d_kosmetitka = {
	clr
	pl'<a href="exec:gs''stat''"><b>Закрыть косметичку</b></a>'
	if kosmetica >= 1: pl '<a href="exec:mop = 2 & kosmetica -= 1 & gs''stat''"><b>Легкий макияж</b></a>'
	if kosmetica >= 2: pl '<a href="exec:mop = 3 & kosmetica -= 2 & gs''stat''"><b>Нормальный макияж</b></a>'
	if kosmetica >= 3: pl '<a href="exec:mop = 4 & kosmetica -= 3 & gs''stat''"><b>Густой макияж</b></a>'
}
$d_bag = {
	clr
	pl'<center><img src="images/pic/icon/purse_icon.png"><br></center>'
	if greben > 0 and hapri = 0 and cheatHapri_mod = 1:pl'У вас есть расческа. <a href="exec:minut += 3 & hapri = 1 & gs''stat''"><b>Причесаться</b></a>'
	if salfetka > 0:pl'У вас есть влажные салфетки, <<salfetka>> штук. <a href="exec:dynamic $d_salf"><b>Взять салфетку</b></a>'
	if kosmetica > 0:
		pl'У вас есть переносная косметичка. Косметики хватит на <<kosmetica>> раз.' + iif(mop = 1,' <a href="exec:dynamic $d_kosmetitka"><b>Накраситься</b></a>','')
	end
	if prezik > 0 or Sprezik > 0:
		if CondomToggle = 0:pl 'У вас <<prezik + Sprezik>> презервативов и вы пользуетесь ими в случае необходимости.<a href="exec:CondomToggle = 1 & dynamic $d_bag"><b>Перестать пользоваться.</b></a>'
		if CondomToggle = 1:pl 'У вас <<prezik + Sprezik>> презервативов, но вы не пользуетесь ими.<a href="exec:CondomToggle = 0 & dynamic $d_bag"><b>Начать пользоваться.</b></a>'
	end
	if tabletki > 0 or Stabletki > 0:
		if PillToggle = 0:pl 'У вас <<tabletki + Stabletki>> противозачаточных таблеток и вы принимаете их.<a href="exec:PillToggle = 1 & dynamic $d_bag"><b>Прекратить принимать таблетки.</b></a>'
		if PillToggle = 1:pl 'У вас <<tabletki + Stabletki>> противозачаточных таблеток, но вы не принимаете их.<a href="exec:PillToggle = 0 & dynamic $d_bag"><b>Начать принимать таблетки.</b></a>'
	end
	if lubri > 0: pl'У вас есть лубрикант. Хватит на <<lubri>> раз.'
	if bottle > 0: pl'У вас есть бутылочка воды. <a href="exec:bottle = 0 & water = 20 & cumlip = 0 & gs''stat''"><b>Выпить</b></a>'
	if buterbrod > 0: pl'У вас есть бутерброд. <a href="exec:buterbrod = 0 & energy += 20 & cumlip = 0 & body[''day_weight''] += 1 & gs''stat''"><b>Съесть</b></a>'
	if wine = 1 and alkowine = 0: pl'В сумочке лежит бутылка <a href="exec:dynamic $dinalkowin1">вина</a>'
	if wine = 1 and alkowine = 1: pl'В сумочке лежит пол бутылки <a href="exec:dynamic $dinalkowin2">вина</a>'
	if foto = 1: pl'В сумочке лежит странное фото'
	pl '<a href="exec: gt ''zz_phone'',''menu'' "><b>Телефон</b></a>'
	if reading['in_bag'] >= 0: pl '<center><a href="exec:gs''stat''"><img src="images/common/books/'+reading['in_bag']+'.jpg" width="150" height="200"></a></center>'
	if reading['in_bag'] >= 0: pl 'В сумочке лежит книга "'+func('zz_books','get_name',reading['in_bag'])+'"'
	pl'<center><a href="exec:gs''stat''"><img src="images/common/icons/back.png"></a></center>'
}
$dinalkowin1 = {
	cla
	*clr
	alkowine = 1
	gs 'zz_funcs', 'alko', 5
	gs 'stat'
	'<center><img src="images/pic/alkowin.jpg"></center>'
	'Вы открыли сумочку и достали, припасённую в ней, бутылку вина и не спеша выпили половину.'
	act '...':gt $CURLOC
}
$dinalkowin2 = {
	cla
	*clr
	alkowine = 0
	wine = 0
	gs 'zz_funcs', 'alko', 5
	gs 'stat'
	'<center><img src="images/pic/alkowin.jpg"></center>'
	'Вы открыли сумочку и достали, оставшуюся половину бутылки вина не спеша допили и выкинули пустую бутылку.'
	act '...':gt $CURLOC
}