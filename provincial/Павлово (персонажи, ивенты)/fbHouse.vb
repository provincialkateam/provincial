*clr & cla
gs'stat'
gs 'zz_render', '', 'images/qwest/alter/Ev/fbHouse.jpg', func('fbHouse_strings', 'local_str1')
act 'Целоваться':
	*clr & cla
	boy += 1
	dick = RAND(15,25)
	parkfuckboy += 1
	$ppBoyName[parkfuckboy] = $bname
	ppBoyTipe[parkfuckboy] = 1
	ppBoyPlace[parkfuckboy] = 2
	!дроч 2 минет 3 групповуха
	ppdick[parkfuckboy] = dick
	fbhousetimes += 1
	pphj = 0
	ppbj = 0
	ppsex = 0
	ppanal = 0
	minut += 5
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/qwest/alter/Ev/fbhKiss.jpg', func('fbHouse_strings', 'local_str2')
	act 'Взять в рот':
		*clr & cla
		ppbj += 1
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/fbhBJ.jpg', func('fbHouse_strings', 'local_str3')
		tiprand = RAND(0,1)
		if tiprand = 0:
			pose = 1
			$fbhactname = 'Встать раком'
			gs 'zz_render', '', '', func('fbHouse_strings', 'local_str4')
		elseif tiprand = 1:
			pose = 0
			$fbhactname = 'Лечь на спину'
			gs 'zz_render', '', '', func('fbHouse_strings', 'local_str5')
		end
		act '<<$fbhactname>>':
			*clr & cla
			minut += 5
			ppsex += 1
			gs'stat'
			if tiprand = 0:'<center><img src="images/qwest/alter/Ev/fbhdog.jpg"></center>'
			if tiprand = 1:'<center><img src="images/qwest/alter/Ev/fbhmiss.jpg"></center>'
			gs 'zz_dynamic_sex', 'sex_start', 1
			gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Приводить себя в порядок':
				*clr & cla
				if ppbj > 0:bj += 1
				if pphj > 0:hj += 1
				if ppsex > 0:sex += 1
				if ppanal > 0:anal += 1
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/fbhend.jpg', func('fbHouse_strings', 'local_str6')
				act 'Уйти':gt'gorodok'
			end
		end
	end
end