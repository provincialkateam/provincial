if args[1] = 0:
	if $args[0] = 'hours':
		hour += 1
		if hour >= 24: hour = 0
	elseif $args[0] = 'minutes':
		minut += 5
		if minut >= 60: minut = 0
	elseif $args[0] = 'month':
		month += 1
		if month >= 13: month = 1
	elseif $args[0] = 'day':
		day += 1
		if month = 1 or month = 3 or month = 5 or month = 7 or month = 8 or month = 10 or month = 12:
			if day >= 32: day = 1
		elseif month = 2:
			if day >= 29: day = 1
		else
			if day >= 31: day = 1
		end
	elseif $args[0] = 'money':
		if args[2] = 0:
			money += 5000
			if money >= 100000000: money = 100000000
		else
			karta += 50000
			if karta >= 100000000: karta = 100000000
		end
	end
	!---
	if $args[0] = 'horny':
		horny += 5
		if horny > 100: horny = 0
	elseif $args[0] = 'health':
		health += 5
		if health > 100: health = 5
	elseif $args[0] = 'manna':
		manna += 5
		if manna > 100: manna = 0
	elseif $args[0] = 'energy':
		energy += 4
		if energy > 24: energy = 0
	elseif $args[0] = 'water':
		water += 4
		if water > 24: water = 0
	elseif $args[0] = 'son':
		son += 4
		if son > 24: son = 0
	end
	gs 'stat'
	exit
end
!---
if args[1] = 1:
	if $args[0] = 'body_weight':
		body['weight'] += 2
		if body['weight'] > 130: body['weight'] = 40
	elseif $args[0] = 'body_height':
		body['height'] += 1
		if body['height'] > 180: body['height'] = 160
	elseif $args[0] = 'age':
		vidage += 1
		if vidage > 24: vidage = 16
	elseif $args[0] = 'lip':
		lip += 1
		if lip > 4: lip = 0
	elseif $args[0] = 'skin':
		skin += 1
		if skin > 4: skin = 0
	elseif $args[0] = 'tan':
		if tan = 0:
			tan = 10
		elseif tan > 0 and tan <= 30:
			tan = 70
		elseif tan > 30 and tan <= 100:
			tan = 120
		elseif tan > 100:
			tan = 0
		end
	elseif $args[0] = 'mop':
		mop += 1
		if mop >= 5: mop = 0
	elseif $args[0] = 'anus':
		if anus = 0:
			anus = 1
			if anal < 1: anal = 1
		elseif anus > 0 and anus <= 5:
			anus = 6
			if anal < 6: anal = 6
		elseif anus > 5 and anus <= 10:
			anus = 11
			if anal < 6: anal = 6
		elseif anus > 10 and anus <= 15:
			anus = 16
			if anal < 51: anal = 51
		elseif anus > 15 and anus <= 25:
			anus = 26
			if anal < 201: anal = 201
		elseif anus > 25 and anus <= 35:
			anus = 36
			if anal < 201: anal = 201
		else
			anus = 0
			anal = 0
		end
	elseif $args[0] = 'vagina':
		if vagina = 0:
			vagina = 1
			if sex < 1: sex = 1
		elseif vagina > 0 and vagina <= 5:
			vagina = 6
			if sex < 6: sex = 6
		elseif vagina > 5 and vagina <= 10:
			vagina = 11
			if sex < 6: sex = 6
		elseif vagina > 10 and vagina <= 15:
			vagina = 16
			if sex < 51: sex = 51
		elseif vagina > 15 and vagina <= 25:
			vagina = 26
			if sex < 201: sex = 201
		elseif vagina > 25 and vagina <= 35:
			vagina = 36
			if sex < 201: sex = 201
		else
			vagina = 0
			sex = 0
		end
	elseif $args[0] = 'slut':
		reputation[$control_point] += 50
		if reputation[$control_point] >= 250: reputation[$control_point] = 0
		gt 'menu_description','tabs',2
	elseif $args[0] = 'throat':
		if throat = 0:
			throat = 1
		elseif throat > 0 and throat <= 15:
			throat += 5
		elseif throat > 15 and throat <= 35:
			throat += 10
		else
			throat = 0
		end
	elseif $args[0] = 'lobok':
		lobok += 2
		if lobok > 4: lobok = 0
	elseif $args[0] = 'leghair':
		leghair += 2
		if leghair > 6: leghair = 0
	elseif $args[0] = 'haircurly':
		curly += 10
		if curly > 10: curly = 0
	elseif $args[0] = 'haircolor':
		hcol += 1
		if hcol >= 4: hcol = 0
	elseif $args[0] = 'hairlength':
		shorthair += 1
		if shorthair >= 4: shorthair = 0
	elseif $args[0] = 'glacol':
		glacol += 1
		if glacol > 3: glacol = 0
	elseif $args[0] = 'glaraz':
		glaraz += 1
		if glaraz > 3: glaraz = 0
	elseif $args[0] = 'resnic':
		resnic += 1
		if resnic > 2: resnic = 0
	elseif $args[0] = 'brow':
		brow += 1
		if brow > 1: brow = -1
	elseif $args[0] = 'glass':
		glass += 1
		if glass > 3: glass = 1
	end
	gs 'stat'
	gt 'menu_description','tabs'
	exit
end
!---
if args[1] = 2:
	if $args[0] = 'stren':
		stren += 5
		if stren > 100: stren = 5
	elseif $args[0] = 'speed':
		speed += 5
		if speed > 100: speed = 5
	elseif $args[0] = 'agil':
		agil += 5
		if agil > 100: agil = 5
	elseif $args[0] = 'vital':
		vital += 5
		if vital > 100: vital = 5
	elseif $args[0] = 'intel':
		intel += 5
		if intel > 100: intel = 5
	elseif $args[0] = 'react':
		react += 5
		if react > 100: react = 5
	elseif $args[0] = 'dom':
		dom += 5
		if dom > 100: dom = -100
	elseif $args[0] = 'Jab':
		Jab += 5
		if Jab > 120: Jab = 0
	elseif $args[0] = 'Punch':
		Punch += 5
		if Punch > 120: Punch = 0
	elseif $args[0] = 'Kik':
		Kik += 5
		if Kik > 120: Kik = 0
	elseif $args[0] = 'KikDef':
		KikDef += 5
		if KikDef > 120: KikDef = 0
	elseif $args[0] = 'beg':
		beg += 20
		if beg > 2000: beg = 10
	elseif $args[0] = 'volleyboll':
		volleyboll += 10
		if volleyboll > 100: volleyboll = 0
	elseif $args[0] = 'oficiant':
		oficiant += 5
		if oficiant > 100: oficiant = 0
	elseif $args[0] = 'maidstat':
		maidstat += 5
		if maidstat > 100: maidstat = 0
	elseif $args[0] = 'vokal':
		vokal += 5
		if vokal > 100: vokal = 0
	elseif $args[0] = 'dance':
		dance += 5
		if dance > 100: dance = 0
	elseif $args[0] = 'dancePRO':
		dancePRO += 5
		if dancePRO > 100: dancePRO = 0
	elseif $args[0] = 'stripdance':
		stripdance += 5
		if stripdance > 100: stripdance = 0
	elseif $args[0] = 'poledance':
		poledance += 5
		if poledance > 100: poledance = 0
	elseif $args[0] = 'poSkill':
		poSkill += 20
		if poSkill > 1000: poSkill = 0
	elseif $args[0] = 'progress':
		school['progress'] += 5
		if school['progress'] > 100: school['progress'] = 0
	elseif $args[0] = 'absent':
		school['absent'] += 3
		if school['absent'] > 30: school['absent'] = 0
	elseif $args[0] = 'uni_progress':
		university['progress'] += 5
		if university['progress'] > 100: university['progress'] = 0
	end
	gs 'stat'
	gt 'menu_description','tabs',1
end