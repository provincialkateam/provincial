clr
gs 'stat'
'<center><b><font color = maroon>Сцена</font></b></center>'
'<center><img src="images/pic/stripclub1.jpg"></center>'
if publichot < 10: $pubhot = 'и освистывают вас, раздаются вопли "уберите эту тупую корову"'
if publichot >= 10 and publichot < 20: $pubhot = 'и освистывают вас'
if publichot >= 20 and publichot < 30: $pubhot = 'и откровенно скучают занимаясь выпивкой и разговорами между собой'
if publichot >= 30 and publichot < 60: $pubhot = 'иногда бросающие на вас взгляды сопровождаемые улыбками'
if publichot >= 60 and publichot < 70: $pubhot = 'и с легким интересом разглядывают вас и ведут беседы между собой за кружками пива'
if publichot >= 70 and publichot < 80: $pubhot = 'с интересом разглядывающие вас'
if publichot >= 80 and publichot < 90: $pubhot = 'с напряженными лицами, у некоторых даже заметен выступивший пот на лбах'
if publichot >= 90: $pubhot = 'забывшие о своей выпивке, улюлюкающие и трясущие деньгами'
gs 'zz_render', '', '', func('stwork2_strings', 'local_str1')
killvar '$pubhot'
if hour >= 15 or hour <= 2:
	if stpredmet > 0:
		act 'Танцевать стриптиз 5 минут (<<stpredmet>> предметов одежды)':
			*clr & cla
			minut += 5
			stpredmet -= 1
			sweat += 1
			body['day_weight'] -= 1
			if manna > 10: manna -= RAND(5,10)
			if stpredmet = 1: sweat += 1
			if stpredmet = 0: stripdancesum += 1
			publichot += RAND(stripdance/30,stripdance/10)
			if publichotstart = publichot: publichot -= RAND(5,10) & publichotstart = publichot
			gs 'zz_render', '', 'images/pic/stripclub2.jpg', func('stwork2_strings', 'local_str2')
			if body['group'] >= 2:
				if RAND(0,100) >= 75:
					publichot -= RAND(5,10)
					gs 'zz_render', '', '', func('stwork2_strings', 'local_str3')
				end
			end
			gs 'stat'
			dynamic $pubhotdi
			act 'Далее':gt $curloc
		end
		act 'Танцевать вокруг шеста 5 минут (<<stpredmet>> предметов одежды)':
			*clr & cla
			minut += 5
			stpredmet -= 1
			sweat += 2
			body['day_weight'] -= 1
			if manna > 10: manna -= RAND(5,10)
			if stpredmet = 0: mop = 0 & stripdancesum += 1
			publichot += RAND(stripdance/20,stripdance/5)+ RAND(poledance/20,poledance/5)
			if publichotstart = publichot: publichot -= RAND(5,10) & publichotstart = publichot
			gs 'stat'
			gs 'zz_render', '', 'images/pic/strippole.jpg', func('stwork2_strings', 'local_str4')
			if body['group'] >= 2:
				vesrand = RAND(0,100)
				if vesrand >= 75:
					publichot = 15
					gs 'zz_render', '', '', func('stwork2_strings', 'local_str5')
				elseif vesrand >= 50:
					publichot -= RAND(5,10)
					gs 'zz_render', '', '', func('stwork2_strings', 'local_str7')
				end
			end
			dynamic $pubhotdi
			act 'Далее':gt $curloc
		end
	end
	if stpredmet = 0:
		if publichot >= 80 and publichot < 90:
			if RAND(0,100) >= 90:
				gs 'zz_render', '', '', func('stwork2_strings', 'local_str8')
				dynamic $privatdancedi
				exit
			end
		elseif publichot >= 90:
			if RAND(0,100) >= 70:
				gs 'zz_render', '', '', func('stwork2_strings', 'local_str9')
				dynamic $privatdancedi
				exit
			end
		end
	end
else
	gs 'zz_render', '', '', func('stwork2_strings', 'local_str10')
end
act 'Уйти со сцены':gt'stwork','start'
$pubhotdi = {
	if publichot < 30:
		payrand = 0
		gs 'zz_render', '', '', func('stwork2_strings', 'local_str11')
	elseif publichot >= 30 and publichot < 60:
		payrand = 0
		gs 'zz_render', '', '', func('stwork2_strings', 'local_str12')
	elseif publichot >= 60 and publichot < 70:
		payrand = RAND(0,1)
		dynamic $strip_payment
	elseif publichot >= 70 and publichot < 80:
		payrand = RAND(0,5)
		dynamic $strip_payment
	elseif publichot >= 80 and publichot < 90:
		payrand = RAND(0,10)
		dynamic $strip_payment
	elseif publichot >= 90:
		payrand = RAND(0,15)
		dynamic $strip_payment
	end
}
$strip_payment = {
	if payrand = 0:
		gs 'zz_render', '', '', func('stwork2_strings', 'local_str13')
	elseif payrand >= 1 and payrand < 5:
		paymoneyrand = RAND(payrand, payrand + 2)
	elseif payrand = 5:
		paymoneyrand = RAND(5,10)
	elseif payrand = 6:
		paymoneyrand = RAND(7,12)
	elseif payrand = 7:
		paymoneyrand = RAND(10,15)
	elseif payrand = 8:
		paymoneyrand = RAND(15,20)
	elseif payrand = 9:
		paymoneyrand = RAND(20,30)
	elseif payrand = 10:
		paymoneyrand = RAND(30,40)
	elseif payrand = 11:
		paymoneyrand = RAND(40,50)
	elseif payrand = 12:
		paymoneyrand = RAND(50,60)
	elseif payrand = 13:
		paymoneyrand = RAND(60,70)
	elseif payrand = 14:
		paymoneyrand = RAND(70,80)
	elseif payrand = 15:
		paymoneyrand = RAND(80,100)
	end
	money += paymoneyrand*10
	if payrand > 0: 'Какой то парень сунул вам в трусики <<paymoneyrand>>0 рублей'
}
$privatdancedi = {
	act 'Идти на приватный танец':
		*clr & cla
		minut += 30
		money += 800
		sweat = 1
		mop = 0
		body['day_weight'] -= 1
		stripdancesum += 1
		gt 'stwork2', 'pr' + rand(1,3)
		gs 'stat'
		gs 'zz_render', '', 'images/pic/privatstrip.jpg', func('stwork2_strings', 'local_str14')
		act 'Уйти в раздевалку':gt'stwork','start'
	end
}
if $ARGS[0] = 'pr1':
	cla
	*clr
	gs 'zz_render', '', 'images/img/centr/pr1.jpg', func('stwork2_strings', 'local_str15')
	act 'Уйти':gt'stwork','start'
	act 'Согласиться':
		gang += 1
		guy += 4
		picrand = 12
		money += 5000
		gt 'paysex', 'var'
	end
end
if $ARGS[0] = 'pr2':
	cla
	*clr
	gs 'zz_render', '', 'images/img/centr/pr2.jpg', func('stwork2_strings', 'local_str16')
	act 'Уйти':gt'stwork','start'
	act 'Согласиться':
		guy += 1
		picrand = 39
		money += 3000
		xgt 'sex', 'var'
	end
end
if $ARGS[0] = 'pr3':
	cla
	*clr
	gs 'zz_render', '', 'images/img/centr/pr3.jpg', func('stwork2_strings', 'local_str17')
	act 'Уйти':gt'stwork','start'
	act 'Согласиться':
		girl += 1
		lesbian += 1
		picrand = 18
		money += 2000
		xgt 'lezbsex', 'var'
	end
end