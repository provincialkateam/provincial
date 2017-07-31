$pirsyaz = {
	*clr & cla
	'<center><img src="images/pic/pirsing.jpg"></center>'
	minut += 30
	money -= 2000
	if pirsA = 0:
		pirsA = 1
		pirs_pain_ton = 7
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str1')
	else
		pirsA = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str2')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirsgub = {
	*clr & cla
	'<center><img src="images/pic/pirsing2.jpg"></center>'
	minut += 30
	money -= 3000
	if pirsB = 0:
		pirsB = 1
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str3')
	else
		pirsB = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str4')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirsysh = {
	*clr & cla
	minut += 30
	money -= 1000
	if pirsC = 0:
		pirsC = 1
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str5')
	else
		pirsC = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str6')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirsnos = {
	*clr & cla
	minut += 30
	money -= 2000
	if pirsD = 0:
		pirsD = 1
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str7')
	else
		pirsD = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str8')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirsbro = {
	*clr & cla
	minut += 30
	money -= 2000
	if pirsE = 0:
		pirsE = 1
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str9')
	else
		pirsE = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str10')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirssos = {
	*clr & cla
	minut += 30
	money -= 5000
	if pirsF = 0:
		pirsF = 1
		nippain = 2
		nippainday = daystart
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str11')
	else
		pirsF = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str12')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirsvla = {
	*clr & cla
	minut += 30
	money -= 7000
	if pirsG = 0:
		pirsG = 1
		painpub = 2
		painpubday = daystart
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str13')
	else
		pirsG = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str14')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirspyp = {
	*clr & cla
	minut += 30
	money -= 5000
	if pirsN = 0:
		pirsN = 1
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str15')
	else
		pirsN = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str16')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
$pirsclit = {
	*clr & cla
	minut += 30
	money -= 7000
	if pirsGL = 0:
		pirsGL = 1
		painpub = 2
		painpubday = daystart
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str17')
	else
		pirsGL = 0
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str18')
	end
	gs 'stat'
	act 'Уйти': gt $curloc
}
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render','Салон пирсинга','images/pic/pirsingstudia.jpg', func('pirsingsalon_strings', 'local_str19')
if hour >= 12 and hour < 20:
	if money >= 1000: '<a href="exec:dynamic $pirsysh">'+iif(pirsC=0,'Сделать','Убрать')+' пирсинг ушей 1000 рублей</a>'
	if money >= 2000:
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str20')
	end
	if money >= 3000: '<a href="exec:dynamic $pirsgub">'+iif(pirsB=0,'Сделать','Убрать')+' пирсинг губ 3000 рублей</a>'
	if money >= 5000:
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str21')
	end
	if money >= 7000:
		gs 'zz_render', '', '', func('pirsingsalon_strings', 'local_str22')
	end
end
act 'Уйти': gt 'nord'