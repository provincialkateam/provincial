if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 1
	guy += 1
	bj += 1
	throat += 1
	prosta += 1
	if rand(0,100) >= 70: dynamic $venerasiak
	gs 'stat'
	gs 'zz_render', '', 'images/prost/bj.jpg', func('blowPR_strings', 'local_str1')
	if prezik > 0:
		act 'Одеть ртом презерватив на член': gt'blowPR','1'
	else
		act 'Взять член в рот': gt'blowPR','2'
	end
end
if $ARGS[0] = '1':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 5
	prezik -= 1
	gs 'stat'
	gs 'zz_render', '', 'images/prost/bjp'+RAND(1,7)+'.jpg', func('blowPR_strings', 'local_str2')
	if prosti = 0:
		gs 'zz_render', '', '', func('blowPR_strings', 'local_str3')
		act 'Уйти': gt $locSex, $metkaSex
	elseif prosti = 1:
		gs 'zz_render', '', '', func('blowPR_strings', 'local_str4')
		act 'Дальше': gt'NormPR','1'
	elseif prosti = 2:
		gs 'zz_render', '', '', func('blowPR_strings', 'local_str4')
		act 'Дальше': gt'AnalPR'
	end
end
if $ARGS[0] = '2':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	dynamic $venerasiak
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/prost/bjp'+RAND(8,13)+'.jpg', func('blowPR_strings', 'local_str6')
	act 'Сосать': gt'blowPR','12'
end
if $ARGS[0] = '12':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	if prosti = 0:
		bjrand = RAND(0,100)
		if bj <= 15 and bjrand > 0 and bjrand <= 50:
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render','','images/prost/bjm.jpg', func('blowPR_strings','local_str11') + func('blowPR_strings','local_str13')
		elseif bj > 15 and bjrand > 0 and bjrand <= 50:
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render','','images/prost/bjm2.jpg', func('blowPR_strings','local_str10') + func('blowPR_strings','local_str14')
		elseif bjrand > 50 and bjrand <= 80 and bj <= 15 and mop = 1:
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_render','','images/prost/bjf.jpg', func('blowPR_strings','local_str11') + func('blowPR_strings','local_str12')
		elseif bjrand > 50 and bjrand <= 80 and bj <= 15 and mop > 1:
			gs 'zz_funcs', 'cum', 'face'
			mop = 0
			gs 'zz_render','','images/prost/bjf.jpg', func('blowPR_strings','local_str11') + func('blowPR_strings','local_str12')
		elseif bjrand > 50 and bjrand <= 80 and bj > 15:
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_render','','images/prost/bjf2.jpg', func('blowPR_strings','local_str10') + func('blowPR_strings','local_str15')
		elseif bjrand > 80 and bjrand <= 100 and bj <= 15:
			cumfrot += 1
			gs 'zz_render','','images/prost/bjt2.jpg', func('blowPR_strings','local_str11') + func('blowPR_strings','local_str16')
		elseif bjrand > 80 and bjrand <= 100 and bj > 15:
			money += 500
			gs 'zz_render','','images/prost/bjt.jpg', func('blowPR_strings','local_str10') + func('blowPR_strings','local_str17')
		end
		killvar '$zz_str'
		gs 'stat'
		act 'Уйти': gt $locSex, $metkaSex
	elseif prosti = 1:
		gs 'zz_render', '', '', func('blowPR_strings', 'local_str4')
		act 'Дальше':gt'NormPR','2'
	elseif prosti = 2:
		gs 'zz_render', '', '', func('blowPR_strings', 'local_str4')
		act 'Дальше': gt 'AnalPR'
	end
end