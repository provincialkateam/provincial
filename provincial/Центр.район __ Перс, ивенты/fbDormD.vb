$d_fbd_start = {
	act 'Идти в общагу':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', '', func('fbDormD_strings', 'local_str1')
		tiprand = RAND(1,100)
		if tiprand >= 90:fbde = 1
		if tiprand < 90 and tiprand >= 60:fbde = 2
		if tiprand < 60:fbde = 3
		dynamic $d_fbd_dormroom
	end
}
$d_fbd_dormroom = {
	act 'Идти в комнату':
		*clr & cla
		minut += 5
		gs'stat'
		if fbde <= 1:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str2')
			dynamic $d_fbd_mass
		elseif fbde = 2:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str3')
			dynamic $d_fbd_regular
		elseif fbde = 3:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str4')
			tiprand = RAND(1,100)
			if tiprand < 90:
				gs 'zz_render', '', '', func('fbDormD_strings', 'local_str5')
				dynamic $d_fbd_regular
			elseif tiprand >= 90:
				gs 'zz_render', '', '', func('fbDormD_strings', 'local_str6')
				dynamic $d_fbd_drunk
			end
		end
	end
}
$d_fbd_regular = {
	act 'Целоваться':
		*clr & cla
		boy += 1
		dick = RAND(15,25)
		parkfuckboy += 1
		$ppBoyName[parkfuckboy] = $bname
		ppBoyTipe[parkfuckboy] = 1
		ppBoyPlace[parkfuckboy] = 3
		!дроч 2 минет 3 групповуха
		ppdick[parkfuckboy] = dick
		fbdormtimes += 1
		pphj = 0
		ppbj = 0
		ppsex = 0
		ppanal = 0
		minut += 5
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/fbdKiss.jpg', func('fbDormD_strings', 'local_str7')
		dynamic $d_fbd_blowhim
		act 'Продолжать целоваться':
			*clr & cla
			minut += 5
			horny += 10
			gs'stat'
			'<center><img src="images/qwest/alter/Ev/fbdKiss.jpg"></center>'
			tiprand = RAND(1,100)
			if tiprand >= 80:
				gs 'zz_render', '', '', func('fbDormD_strings', 'local_str8')
				dynamic $d_fbd_blowhim
			elseif tiprand < 80 and tiprand >= 40:
				gs 'zz_render', '', '', func('fbDormD_strings', 'local_str9')
				dynamic $d_fbd_miss
			elseif tiprand < 40:
				gs 'zz_render', '', '', func('fbDormD_strings', 'local_str10')
				dynamic $d_fbd_dog
			end
		end
	end
}
$d_fbd_blowhim = {
	act 'Взять в рот':
		*clr & cla
		minut += 5
		ppbj += 1
		gs'stat'
		'<center><img src="images/qwest/alter/Ev/fbdBJ.jpg"></center>'
		gs 'zz_dynamic_sex', 'bj'
		tiprand = RAND(0,1)
		if tiprand = 0:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str11')
			dynamic $d_fbd_miss
		elseif tiprand = 1:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str12')
			dynamic $d_fbd_dog
		end
	end
}
$d_fbd_miss = {
	act 'Лечь на спину':
		*clr & cla
		minut += 5
		horny += 10
		ppsex += 1
		pose = 0
		$boy = 'парень'
		gs'stat'
		'<center><img src="images/qwest/alter/Ev/fbdMiss.jpg"></center>'
		gs 'zz_dynamic_sex', 'sex_start', 1
		gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
		tiprand = RAND(1,100)
		if tiprand < 70:
			gs 'zz_dynamic_sex', 'sex_cum'
			dynamic $d_fbd_end
		elseif tiprand >= 50 and tiprand < 70:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str13')
			dynamic $d_fbd_dog
		elseif tiprand >= 70:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str14')
			dynamic $d_fbd_face
		end
	end
}
$d_fbd_dog = {
	act 'Встать раком':
		*clr & cla
		minut += 5
		horny += 10
		pose = 1
		ppsex += 1
		$boy = 'парень'
		gs'stat'
		'<center><img src="images/qwest/alter/Ev/fbdDog.jpg"></center>'
		gs 'zz_dynamic_sex', 'sex_start', 1
		gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
		tiprand = RAND(1,100)
		if tiprand < 70:
			gs 'zz_dynamic_sex', 'sex_cum'
			gs'stat'
			dynamic $d_fbd_end
		elseif tiprand >= 50 and tiprand < 70:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str15')
			dynamic $d_fbd_anal
		elseif tiprand >= 70:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str16')
			dynamic $d_fbd_face
		end
	end
}
$d_fbd_face = {
	act 'Лежать':
		*clr & cla
		minut += 5
		horny += 10
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_funcs', 'cum', 'lip'
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/fbdFace.jpg', func('fbDormD_strings', 'local_str17')
		dynamic $d_fbd_end
	end
}
$d_fbd_anal = {
	act 'Лечь на живот':
		*clr & cla
		minut += 5
		horny += 10
		ppanal += 1
		$boy = 'парень'
		gs'stat'
		'<center><img src="images/qwest/alter/Ev/fbdAnal.jpg"></center>'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick', 1
		tiprand = RAND(1,100)
		if tiprand >= 70:
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str18')
			dynamic $d_fbd_face
		elseif tiprand < 70:
			gs 'zz_dynamic_sex', 'anal_cum'
			dynamic $d_fbd_end
		end
	end
}
$d_fbd_end = {
	act 'Приводить себя в порядок':
		*clr & cla
		if ppbj > 0:bj += 1
		if pphj > 0:hj += 1
		if ppsex > 0:sex += 1
		if ppanal > 0:anal += 1
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/fbhend.jpg', func('fbDormD_strings', 'local_str20')
		act 'Уйти':gt'gorodok'
	end
}
$d_fbd_drunk = {
	act 'Выпивать':
		*clr & cla
		gs 'zz_funcs', 'alko', 6
		gs 'stat'
		gs 'zz_render', '', '', func('fbDormD_strings', 'local_str21')
		act 'Выпить еще':
			gs 'zz_funcs', 'alko', 6
			dormrape = 0
			kol_man = RAND(5,16)
			$kol_man_text = 'парни'
			gt'placer_sex'
		end
	end
}
$d_fbd_mass = {
	act 'Выпивать':
		*clr & cla
		boy += 2
		gang += 1
		dick = RAND(15,25)
		parkfuckboy += 1
		$ppBoyName[parkfuckboy] = $bname
		ppBoyTipe[parkfuckboy] = 1
		ppBoyPlace[parkfuckboy] = 4
		!дроч 2 минет 3 групповуха
		ppdick[parkfuckboy] = dick
		fbdormtimes += 1
		pphj = 0
		ppbj = 0
		ppsex = 0
		ppanal = 0
		minut += 30
		gs 'zz_funcs', 'alko', 6
		horny += 20
		gs 'stat'
		gs 'zz_render', '', '', func('fbDormD_strings', 'local_str22')
		act 'Только с тобой':
			*clr & cla
			minut += 5
			horny += 10
			ppsex += 1
			pose = 0
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/Ev/fbdtsingle.jpg', func('fbDormD_strings', 'local_str23')
			gs 'zz_dynamic_sex', 'sex_start', 1
			gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str24')
			act 'Приоткрыть рот':
				*clr & cla
				minut += 5
				horny += 10
				ppsex += 1
				pose = 0
				ppbj += 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/fbdtdouble.jpg', func('fbDormD_strings', 'local_str25')
				gs 'zz_dynamic_sex', 'sex_cum'
				act 'Сосать':
					*clr & cla
					minut += 5
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_funcs', 'cum', 'lip'
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/Ev/fbdtcum.jpg', func('fbDormD_strings', 'local_str26')
					dynamic $d_fbd_end
					act 'Обессиленно лежать':
						*clr & cla
						minut += 5
						gs 'zz_funcs', 'cum', 'face'
						gs 'zz_funcs', 'cum', 'lip'
						gs'stat'
						gs 'zz_render', '', '', func('fbDormD_strings', 'local_str27')
						dynamic $d_fbd_threesome
					end
				end
			end
		end
		act 'Ну я даже не знаю. Может быть':
			*clr & cla
			minut += 5
			horny += 10
			ppsex += 1
			pose = 0
			gs'stat'
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str28')
			dynamic $d_fbd_threesome
		end
	end
}
$d_fbd_threesome = {
	act 'Взять в рот':
		*clr & cla
		ppbj += 2
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/fbdrbj.jpg', func('fbDormD_strings', 'local_str29')
		act 'Продолжать сосать':
			*clr & cla
			minut += 5
			horny += 10
			ppsex += 1
			pose = 1
			$boy = $bname
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/Ev/fbdrsex.jpg', func('fbDormD_strings', 'local_str30')
			gs 'zz_dynamic_sex', 'sex_start', 1
			gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
			gs 'zz_render', '', '', func('fbDormD_strings', 'local_str31')
			act 'Расслабиться и продолжать сосать':
				*clr & cla
				minut += 5
				horny += 10
				ppsex += 1
				pose = 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/fbdranal.jpg', func('fbDormD_strings', 'local_str32')
				gs 'zz_dynamic_sex', 'anal_start', 'dick'
				gs 'zz_dynamic_sex', 'anal', 'dick', 1
				gs 'zz_render', '', '', func('fbDormD_strings', 'local_str33')
				act 'Сесть на член':
					*clr & cla
					minut += 5
					horny += 10
					ppsex += 1
					pose = 1
					dick2 = RAND(15,18)
					$boy2 = 'второй парень'
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/Ev/fbdrdp.jpg'
					gs 'zz_dynamic_sex', 'dp_start'
					gs 'zz_render', '', '', func('fbDormD_strings', 'local_str34')
					gs 'zz_dynamic_sex', 'double_penetration'
					gs 'zz_render', '', '', func('fbDormD_strings', 'local_str35')
					act 'Стоять на коленях':
						*clr & cla
						minut += 5
						gs 'zz_funcs', 'cum', 'face'
						gs 'zz_funcs', 'cum', 'lip'
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/Ev/fbdrcum.jpg', func('fbDormD_strings', 'local_str36')
						dynamic $d_fbd_end
					end
				end
			end
		end
	end
}