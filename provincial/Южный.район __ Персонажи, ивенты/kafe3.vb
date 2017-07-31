$cafe_suck_start = {
	guy += 1
	bj += 1
	throat += 1
	gs 'zz_render', '', '', func('kafe3_strings', 'local_str1')
	act 'Вынуть член изо рта':
		*clr & cla
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_render','','images/pics/facial'+rand(0,5)+'.jpg', '<<$boy>> кончает вам на лицо.'
		act 'Уйти': gt'street'
	end
	act 'Сосать дальше':
		*clr & cla
		gs 'zz_render', '', 'images/pics/cum'+rand(1,10)+'.jpg', func('kafe3_strings', 'local_str2')
		act 'Проглотить':
			*clr & cla
			vaf += 1
			gs 'zz_funcs', 'cum', 'lip'
			swallow += 1
			gs 'zz_render', '', 'images/nigma/city/тс0,0.gif', func('kafe3_strings', 'local_str3')
			act 'Уйти': gt'street'
		end
		act 'Выплюнуть':
			cla
			gs 'zz_render', '', '', func('kafe3_strings', 'local_str4')
			act 'Уйти': gt'street'
		end
	end
}
$cafe_hands_off = {
	act 'Постараться убрать его руки':
		cla
		minut += 15
		horny += 10
		gs'stat'
		gs 'zz_render', '', '', func('kafe3_strings', 'local_str5')
		act 'Приехать': gt'BDsex','start'
	end
}
if $ARGS[0] = 'дом':
	*clr & cla
	money += 100
	minut += 15
	gs 'stat'
	gs 'zz_render', '', '', func('kafe3_strings', 'local_str6')
	act 'Наслаждаться ласками':
		cla
		minut += 15
		horny += 15
		gs 'stat'
		dynamic $venerasiak
		gs 'zz_render', '', '', func('kafe3_strings', 'local_str7')
		dynamic $cafe_hands_off
		act 'Ласкать руками его член':
			cla
			minut += 15
			horny += 10
			gs 'stat'
			gs 'zz_render', '', '', func('kafe3_strings', 'local_str8')
			if RAND(0,100) >= 90:
				gs 'zz_render', '', '', func('kafe3_strings', 'local_str9')
				act 'Взять в рот':
					*clr & cla
					minut += 15
					horny += 10
					guy += 1
					bj += 1
					gs 'zz_render', '', 'images/nigma/city/тк0,'+rand(0,3)+'.gif', func('kafe3_strings', 'local_str10')
					swallow += 1
					gs 'zz_funcs', 'cum', 'lip'
					gs 'stat'
					gs 'zz_render', '', '', func('kafe3_strings', 'local_str11')
					act 'Уйти': gt'street'
				end
				dynamic $cafe_hands_off, 'head'
			else
				act 'Приехать':gt'BDsex','start'
			end
		end
	end
	dynamic $cafe_hands_off
end
if $ARGS[0] = '0':
	*clr & cla
	minut += 15
	gs'stat'
	deyst = RAND(1,100)
	if deyst < 70:
		gs 'zz_render', '', '', func('kafe3_strings', 'local_str12')
		deysts = RAND(1,3)
		if deysts = 1:
			guy += 1
			sex += 1
			vagina += 1
			pose = 0
			gs 'zz_render', '', 'images/pics/vagmis'+rand(1,5)+'.jpg', func('kafe3_strings', 'local_str13')
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Уйти': gt'street'
		elseif deysts = 2:
			guy += 1
			sex += 1
			vagina += 1
			pose = 1
			gs 'zz_funcs', 'cum', 'ass'
			gs 'zz_render', '', 'images/pics/vagdog'+rand(1,5)+'.jpg', func('kafe3_strings', 'local_str14')
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Уйти': gt'street'
		else
			guy += 1
			sex += 1
			pose = 0
			gs 'zz_render', '', 'images/pics/vagcow'+rand(1,5)+'.jpg', func('kafe3_strings', 'local_str15')
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Уйти': gt'street'
		end
	elseif deyst >= 70 and deyst < 85:
		gs 'zz_render', '', '', func('kafe3_strings', 'local_str16')
		act 'Отказаться': gt'kafe3','0'
		act 'Взять в рот':
			cla
			gs 'zz_render','','images/pics/bj'+rand(1,10)+'.jpg'
			dynamic $cafe_suck_start
		end
	else
		gs 'zz_render', '', '', func('kafe3_strings', 'local_str17')
		act 'Отказаться': gt'kafe3','0'
		act 'Согласиться':
			cla
			guy += 1
			anal += 1
			anus += 1
			if lubri > 0:lubri -= 1
			gs 'zz_funcs', 'cum', 'ass'
			gs 'zz_render', '', 'images/pics/anal'+RAND(1,10)+'.jpg', func('kafe3_strings', 'local_str18')
			act 'Уйти': gt'street'
		end
	end
end
if $ARGS[0] = 'туалет':
	cla
	dynamic $venerasiak
	gs 'zz_render', '', '', func('kafe3_strings', 'local_str19')
	act 'Отказаться':
		cla
		guy += 1
		sex += 1
		gs 'zz_funcs', 'cum', 'ass'
		vagina += 1
		pose = 1
		gs 'zz_render', '', 'images/nigma/city/т1,'+rand(0,3)+'.gif', func('kafe3_strings', 'local_str20')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Уйти': gt'street'
	end
	act 'Взять в рот':
		cla
		gs 'zz_render','','images/nigma/city/т0,'+rand(0,4)+'.gif'
		dynamic $cafe_suck_start
	end
end
if $ARGS[0] = 'компашка':
	cla
	dynamic $venerasiak
	gs 'zz_render', '', 'images/pics/gang'+RAND(1,15)+'.jpg', func('kafe3_strings', 'local_str21')
	guy += 3
	sex += 1
	bj += 1
	anal += 1
	throat += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'ass'
	gs 'zz_funcs', 'cum', 'pussy'
	rape += 1
	gang += 1
	vagina += 1
	anus += 1
	act 'Уйти':gt'street'
end