if $ARGS[0] = '1':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	prosti = 0
	minut += 15
	sex += 1
	protect = 1
	i = rand(1,2)
	gs 'zz_render', '', 'images/prost/sexcar<<i>>.jpg', func('NormPR_strings', 'local_str<<i>>')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'stat'
	act 'Уйти': gt $locSex, $metkaSex
end
if $ARGS[0] = '2':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	prosti = 0
	minut += 15
	sex += 1
	pose = 1
	prostRand = RAND(3,19)
	gs 'zz_render', '', 'images/prost/sexcar<<prostRand>>.jpg'
	if prostRand > 3 and prostRand <= 9:
		gs 'zz_render','','', func('NormPR_strings', 'local_str3')
	elseif prostRand > 10 and prostRand <= 12:
		gs 'zz_render','','', func('NormPR_strings', 'local_str4')
	else
		pose = 0
		gs 'zz_render','','', func('NormPR_strings', 'local_str5')
	end
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'stat'
	act 'Уйти': gt $locSex, $metkaSex
end