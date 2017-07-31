minut += 5
gs 'stat'
if furisex = 0:
	gs 'zz_render', '', '', func('furisex_strings', 'local_str1')
	act 'Посмотреть на водителя':furisex = 1 & gt $curloc
elseif furisex = 1:
	gs 'zz_render', '', '', func('furisex_strings', 'local_str2')
	act 'Раздеться и залезть в спальник':furisex = 2 & gt $curloc
elseif furisex = 2:
	gs 'zz_render', '', '', func('furisex_strings', 'local_str3')
	prezik -= 1
	act 'Одеть презерватив руками':furisex = 3 & gt $curloc
	act 'Одеть презерватив ртом':furisex = 4 & gt $curloc
elseif furisex = 3:
	gs 'zz_render', '', 'images/qwest/alter/ev2/condomput.jpg', func('furisex_strings', 'local_str4')
	act 'Сосать':furisex = 5 & gt $curloc
elseif furisex = 4:
	gs 'zz_render', '', 'images/qwest/alter/ev2/condomput2.jpg', func('furisex_strings', 'local_str5')
	act 'Сосать':furisex = 5 & gt $curloc
elseif furisex = 5:
	bj += 1
	guy += 1
	furibj += 1
	gs 'zz_render', '', 'common/transport/taxi/'+rand(0,1)+'.gif', func('furisex_strings', 'local_str6')
	act 'Одеться':furisex = 6 & gt $curloc
elseif furisex = 6:
	gs 'zz_render', '', '', func('furisex_strings', 'local_str7')
	act 'Выйти':
		furisex = 0
		if nroad = 0:nroad = 40 & gt'gorodok'
		if nroad = 40:nroad = 0 & gt'nord'
	end
elseif furisex = 100:
	gs 'zz_render', '', '', func('furisex_strings', 'local_str8')
	act 'Сосать':furisex = 101 & gt $curloc
elseif furisex = 101:
	bj += 1
	guy += 1
	furibj += 1
	if RAND(0,100) >= 70: dynamic $veneradinitog
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_render', '', 'common/transport/taxi/'+rand(0,1)+'.gif', func('furisex_strings', 'local_str9')
	act 'Выйти':
		furisex = 0
		if nroad = 0:nroad = 40 & gt'gorodok'
		if nroad = 40:nroad = 0 & gt'nord'
	end
end