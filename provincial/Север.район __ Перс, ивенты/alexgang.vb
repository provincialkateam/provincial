minut += 30
horny += 10
gs 'stat'
gs 'zz_render', '', '', func('alexgang_strings', 'local_str1')
if alexgangbang = 0:
	gs 'zz_render', '', '', func('alexgang_strings', 'local_str2')
else
	gs 'zz_render', '', '', func('alexgang_strings', 'local_str3')
end
act 'Встать на колени и взять в рот':
	*clr & cla
	alexgangbang += 1
	horny += 10
	bj += 1
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alexey/bj'+RAND(0,13)+'.jpg', func('alexgang_strings', 'local_str4')
	gs 'zz_render', '', '', func('alexgang_strings', 'local_str5')
	act 'Взять в рот у Саши':
		*clr & cla
		if sashaclubsex = 0: sashaclubsex = 1 & guy += 1
		gang += 1
		alexgangbang += 1
		horny += 10
		bj += 1
		minut += 10
		$boy = 'Алексей'
		dick = 20
		silavag = 2
		pose = 1
		gs 'zz_funcs', 'cum', 'lip'
		swallow += 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alexey/gang'+RAND(0,9)+'.jpg', func('alexgang_strings', 'local_str6')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_render', '', '', func('alexgang_strings', 'local_str7')
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_render', '', '', func('alexgang_strings', 'local_str8')
		act 'Уйти':gt'nord'
	end
end