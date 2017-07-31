$d_park_placer_bj = {
	boy += 1
	dick = RAND(15,25)
	parkfuckboy += 1
	$ppBoyName[parkfuckboy] = $bname
	ppBoyTipe[parkfuckboy] = 1
	ppBoyPlace[parkfuckboy] = 1
	!дроч 2 минет 3 групповуха
	ppdick[parkfuckboy] = dick
	pphj = 0
	ppbj = 0
	ppsex = 0
	ppanal = 0
	dynamic $d_pp_hand
	dynamic $d_pp_squat
}
$d_pp_hand = {
	act 'Потрогать член рукой':
		*clr & cla
		pphj += 1
		minut += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/hj.jpg', func('skverdin_strings', 'local_str1')
		tiprand = RAND(1,100)
		if tiprand >= 90:
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str2')
			dynamic $d_pp_squat
		elseif tiprand >= 50 and tiprand < 90:
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str3')
			dynamic $d_pp_squat
			if dom > 0:
				dynamic $d_pp_hjcum
			else
				gs 'zz_render', '', '', func('skverdin_strings', 'local_str4')
				dynamic $d_pp_hjcum
				dynamic $d_pp_squat
			end
		end
	end
}
$d_pp_hjcum = {
	act 'Додрочить':
		*clr & cla
		pphj += 1
		minut += 1
		gs'stat'
		tiprand = RAND(1,100)
		if tiprand >= 80:cumfrot += 1 & $pptext = 'вы заметили как одна из струй спермы попала вам на одежду'
		if tiprand < 80:$pptext = 'сперма парня тугими струями полетела на землю'
		gs 'zz_render', '', 'images/qwest/alter/Ev/pphjcum.jpg', func('skverdin_strings', 'local_str5')
		dynamic $d_pp_goend
	end
}
$d_pp_squat = {
	act 'Сесть на корточки':
		*clr & cla
		minut += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/squat.jpg', func('skverdin_strings', 'local_str6')
		dynamic $d_pp_bj
	end
}
$d_pp_bj = {
	act 'Сосать':
		*clr & cla
		ppbj += 1
		minut += 5
		parkslut += 1
		ppBoyTipe[parkfuckboy] = 2
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/ppbj.jpg', func('skverdin_strings', 'local_str7')
		tiprand = RAND(1,100)
		if tiprand = 100:
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str8')
			dynamic $d_pp_double
		elseif tiprand >= 90 and tiprand < 100:
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str9')
			dynamic $d_pp_sex
		elseif tiprand >= 70 and tiprand < 90:
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str10')
			dynamic $d_pp_sex
			dynamic $d_pp_bjcum
		elseif tiprand < 70:
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str11')
			dynamic $d_pp_hjcum
			dynamic $d_pp_bjcum
		end
	end
}
$d_pp_bjcum = {
	act 'Продолжать сосать':
		*clr & cla
		minut += 1
		gs 'zz_funcs', 'cum', 'lip'
		cumfrot += 1
		gs 'zz_funcs', 'cum', 'face'
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/ppbjcum.jpg', func('skverdin_strings', 'local_str12')
		dynamic $d_pp_goend
	end
}
$d_pp_sex = {
	act 'Нагнуться':
		*clr & cla
		minut += 1
		ppsex += 1
		pose = 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/ppsex.jpg', func('skverdin_strings', 'local_str13')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
		if RAND(1,100) >= 20:
			gs 'zz_dynamic_sex', 'sex_cum'
			dynamic $d_pp_goend
		else
			gs 'zz_render', '', '', func('skverdin_strings', 'local_str14')
			dynamic $d_pp_squat
		end
	end
}
$d_pp_double = {
	act 'Охреневать':
		*clr & cla
		ppBoyTipe[parkfuckboy] = 3
		parkslut += 10
		guy += 1
		gang += 1
		bj += 1
		ppbj += 1
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/ppbjdouble.jpg', func('skverdin_strings', 'local_str15')
		act 'Сосать два члена':
			*clr & cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/Ev/ppbjdouble2.jpg', func('skverdin_strings', 'local_str16')
			act 'Открыть рот':
				*clr & cla
				minut += 15
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_funcs', 'cum', 'lip'
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/ppbjdouble3.jpg', func('skverdin_strings', 'local_str17')
				act 'Повернуть лицо':
					*clr & cla
					minut += 15
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_funcs', 'cum', 'lip'
					cumfrot += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/Ev/ppbjdouble4.jpg', func('skverdin_strings', 'local_str18')
					dynamic $d_pp_goend
				end
			end
		end
	end
}
$d_pp_goend = {
	act 'Приводить себя в порядок':
		*clr & cla
		if ppbj > 0:bj += 1
		if pphj > 0:hj += 1
		if ppsex > 0:sex += 1
		if ppanal > 0:anal += 1
		minut += 5
		gs'stat'
		if cumface > 0 or cumlip > 0:
			'<center><img src="images/qwest/alter/Ev/ppendcum.jpg"></center>'
		else
			'<center><img src="images/qwest/alter/Ev/ppendno.jpg"></center>'
		end
		gs 'zz_render', '', '', func('skverdin_strings', 'local_str19')
		act 'Уйти':gt'zz_park'
	end
}