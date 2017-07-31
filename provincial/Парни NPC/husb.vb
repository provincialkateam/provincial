!'сделать:
1. Романтика:
Совместные прогулки по парку, обнимашки, поцелуи
2. Бытовуха:
реакция мужа на уборку в доме, наличие приготовленной еды, наличие в доме шампуня, чистой посуды и т.п.
3. Не порно:
приход гостей (свекрови/друзей мужа), посиделки с ними.'
$d_husb_discription = {
	if birthyear < husb_birth_year:
		age_diff = husbAge - age
		$h_age = '<<husb_birth_year>> года рождения, ему <<husbAge>> лет. Он старше вас на <<age_diff>> лет.'
	elseif birthyear = husb_birth_year:
		$h_age = '<<husb_birth_year>> года рождения, ему <<husbAge>> лет. Вы ровестники.'
	else
		age_diff = age - husbAge
		$h_age = '<<husb_birth_year>> года рождения, ему <<husbAge>> лет. Вы старше его на <<age_diff>> лет.'
	end
	'Ваш муж <<$husName>>, <<$h_age>> Он <<$husBody>> <<$husFat>> <<$husHair>>.'
	if husband < 20: 'У вас с мужем ужасный скандал.'
	if husband >= 20 and husband < 40: 'У вас с мужем напряженные отношения.'
	if husband >= 40 and husband < 60: 'У вас с мужем нормальные отношения.'
	if husband >= 60 and husband < 80: 'У вас с мужем хорошие отношения.'
	if husband >= 80: 'У вас с мужем отличные отношения.'
	''
}
$d_husb_action = {
	if $loc = 'korr':$husb_action = ''
	if $loc = 'bedr':
		if hour > 22 or hour < 7: $husb_action = 'Ваш муж <<$husName>> лежа в кровати открывает глаза. "Чего тебе? Ночь уже, иди спать."'
	end
	if $loc = 'sitr':
		if hour > 7 and hour < 17 and week >= 6: $husb_action = '<<$husName>> сидит на диване и смотрит телевизор.'
		if hour > 17 and hour <= 22: $husb_action = '<<$husName>> сидит на диване и смотрит телевизор.'
	end
	if $loc = 'kuhr':
		if hour = 17 or hour = 7:$husb_action = '<<$husName>> сидит за кухонным столом.'
	end
	'<<$husb_action>>'
}
if $ARGS[0] = 'start':
	*clr & cla
	gs'stat'
	'<center><B><font color = maroon><<$husName>></font></B></center>'
	'<center><img src="images/pic/boy_face/<<HusbPic>>.jpg"></center>'
	dynamic $d_husb_discription
	dynamic $d_husb_action
	if current_clothing = 0: 'Ваш муж, увидев вас голой, сказал - "Ты очень красива."'
	act '<B>Отойти</B>': gt $loc, $metka
	if husbandsexday < 4: act 'Секс с мужем':gt'husbsex','room'
end