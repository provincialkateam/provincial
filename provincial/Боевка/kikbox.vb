if $ARGS[0] = 'start':
	cla
	if health <= 0:
		'<b><font color = red>Вы проиграли техническим нокаутом</font></b>'
		xgt'enderKik','loss'
		exit
	elseif healthV <= 0:
		'<b><font color = green><<$boy>> проиграла техническим нокаутом</font></b>'
		xgt'enderKik','win'
		exit
	end
	if round > 0:
		if minround < 5: minround +=  1
	else
		round = 1
	end
	'<b>= = = = = = = = = = = = = (РАУНД <<round>>) = = = = = = = = = = = = =</b>'
	if minround = 1:'<b>время боя 0:30</b>'
	if minround = 2:'<b>время боя 1:00</b>'
	if minround = 3:'<b>время боя 1:30</b>'
	if minround = 4:'<b>время боя 2:00</b>'
	if minround = 5:'<b>время боя 2:30</b>'
	'<b><<$boy>></b> жизнь <b><font color = red><<healthV>></font></b>'
	'Ваша жизнь <b><font color = red><<health>></font></b>'
	'<b>= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =</b>'
	'Ваши очки <<pointKik>>, очки соперника <<pointKikV>>'
	'<b>= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =</b>'
	gs'initKik'
	if hod = 0:
		!игрок атакует
		'<font color = green>Вы можете атаковать</font>'
		act 'Нанести быстрый Джеб':
			cla
			damage = RAND(stren/12,stren/8)
			if damage <= 0:damage = 1
			koefatak = (speed + react + jab)*2
			koefpop = koefatak*20/100
			popad = RAND(koefatak - koefpop,koefatak + koefpop)
			'<font color = green>Вы наносите быстрый джеб с шагом вперед.</font>'
			gs'Kikatak','player'
			xgt'kikbox','sta'
		end
		act 'Нанести силовой удар':
			cla
			damkoef = stren*20/100
			damage = RAND(stren - damkoef,stren + damkoef)
			if damage <= 0:damage = 1
			koefatak = (speed + react + punch)
			koefpop = koefatak*20/100
			popad = RAND(koefatak - koefpop,koefatak + koefpop)
			'<font color = green>Вы наносите мощный удар рукой.</font>'
			gs'Kikatak','player'
			xgt'kikbox','sta'
		end
		act 'Нанести удар ногой':
			cla
			damkoef = stren*20/100
			damage = RAND((stren - damkoef)*3,(stren + damkoef)*3)
			if damage <= 0:damage = 1
			koefatak = (speed + react + kik)/2
			koefpop = koefatak*20/100
			popad = RAND(koefatak - koefpop,koefatak + koefpop)
			'<font color = green>Вы наносите мощный пинок ногой.</font>'
			gs'Kikatak','player'
			xgt'kikbox','sta'
		end
	elseif hod = 1:
		!противник атакует
		'<font color = red><<$boy>> атакует</font>'
		tiprand = RAND(0,2)
		if tiprand = 0:
			damage = RAND(strenV/12,strenV/8)
			if damage <= 0:damage = 1
			koefatak = (speedV + reactV + JabV)*2
			koefpop = koefatak*20/100
			popad = RAND(koefatak - koefpop,koefatak + koefpop)
			'<font color = red><<$boy>> наносит быстрый джеб с шагом вперед.</font>'
			gs'Kikatak','enemy'
			xgt'kikbox','sta'
		elseif tiprand = 1:
			damkoef = strenV*20/100
			damage = RAND(strenV - damkoef,strenV + damkoef)
			if damage <= 0:damage = 1
			koefatak = (speedV + reactV + punchV)
			koefpop = koefatak*20/100
			popad = RAND(koefatak - koefpop,koefatak + koefpop)
			'<font color = red><<$boy>> наносит силовой удар рукой.</font>'
			gs'Kikatak','enemy'
			xgt'kikbox','sta'
		elseif tiprand = 2:
			damkoef = strenV*20/100
			damage = RAND((strenV - damkoef)*3,(strenV + damkoef)*3)
			if damage <= 0:damage = 1
			koefatak = (speedV + reactV + kikV)/2
			koefpop = koefatak*20/100
			popad = RAND(koefatak - koefpop,koefatak + koefpop)
			'<font color = red><<$boy>> наносит мощный удар ногой.</font>'
			gs'Kikatak','enemy'
			xgt'kikbox','sta'
		end
	end
end
if $ARGS[0] = 'sta':
	cla
	ionce = 0
	'<b>= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =</b>'
	if minround = 1:'<b>время боя 1:00</b>'
	if minround = 2:'<b>время боя 1:30</b>'
	if minround = 3:'<b>время боя 2:00</b>'
	if minround = 4:'<b>время боя 2:30</b>'
	if minround = 5:'<b>время боя 3:00</b>'
	'<b>= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =</b>'
	'<b><<$boy>></b> жизнь <b><font color = red><<healthV>></font></b>'
	'Ваша жизнь <b><font color = red><<health>></font></b>'
	'<b>= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =</b>'
	act 'Дальше':gt'kikbox','start'
	if minround = 5:
		cla
		minround = 0
		round += 1
		'Прозвенел гонг обозначающий конец раунда'
		if round <= formula:
			act 'Отдыхать в углу':
				cla
				'Вы отдохнули в своем углу.'
				act 'В ринг':gt'kikbox','start'
			end
		elseif round > formula and sparing = 0:
			act 'Выйти на середину для объявления победителя':
				cla
				if pointKik > pointKikV:
					'Вы победили.'
					act 'Уйти с ринга':gt'enderKik','win'
				elseif pointKik < pointKikV:
					'Вы проиграли.'
					act 'Уйти с ринга':gt'enderKik','loss'
				elseif pointKik = pointKikV:
					'Ничья.'
					act 'Уйти с ринга':gt'enderKik','draw'
				end
			end
		elseif round > formula and sparing = 1:
			act 'Уйти с ринга':gt'fit','start'
		end
	end
end