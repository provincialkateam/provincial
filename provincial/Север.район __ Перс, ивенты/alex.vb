minut += 30
horny += 10
gs 'stat'
gs 'zz_render', '', '', func('alex_strings', 'local_str1')
act 'Встать на колени и взять в рот':
	*clr & cla
	alexeySex += 1
	horny += 10
	bj += 1
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alexey/bj'+RAND(0,13)+'.jpg', func('alex_strings', 'local_str2')
	act 'Раздеться':
		*clr & cla
		minut += 10
		$boy = 'Алексей'
		dick = 20
		silavag = 2
		pose = 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alexey/sex.jpg', func('alex_strings', 'local_str3')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_render', '', '', func('alex_strings', 'local_str4')
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_render', '', '', func('alex_strings', 'local_str5')
		act 'Стонать':
			*clr & cla
			minut += 10
			$boy = 'Алексей'
			dick = 20
			silavag = 2
			pose = 1
			gs 'stat'
			'<center><img src="images/qwest/alexey/anal.jpg"></center>'
			gs 'zz_dynamic_sex', 'anal_start', 'dick'
			gs 'zz_dynamic_sex', 'anal', 'dick'
			gs 'zz_dynamic_sex', 'anal_cum'
			gs 'zz_render', '', '', func('alex_strings', 'local_str6')
			act 'Уйти':gt'nord'
		end
	end
end