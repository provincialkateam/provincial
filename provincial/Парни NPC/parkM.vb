if $ARGS[0] = 'start':
	minut += 30
	gs 'zz_render', '', '', func('parkM_strings', 'local_str1')
	if dayA > 15 and harakBoyA = 2:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 1:gs'boylove','tits'
	if dayA > 25 and harakBoyA = 0:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 2:gs'boylove','figure'
	if dayA > 25 and harakBoyA = 1:gs'boylove','figure'
	if dayA > 30 and harakBoyA = 0:gs'boylove','figure'
	gs'anekdot'
	gs 'zz_render', '', '', func('parkM_strings', 'local_str2')
	act 'Смеяться':
		cla
		dom -= 1
		bfA += 1
		xgt'parkM','a'
	end
	act 'Улыбаться':
		cla
		xgt'parkM','a'
	end
	act 'Не смешно':
		cla
		DOM += 1
		bfA -= 1
		xgt'parkM','a'
	end
end
if $ARGS[0] = 'a':
	if harakBoyA = 0:
		gs'stihi'
		gs 'zz_render', '', '', func('parkM_strings', 'local_str3')
		act 'Далее':gt'parkM','aa'
	elseif harakBoyA = 1:
		gs 'zz_render', '', '', func('parkM_strings', 'local_str4')
		act 'Далее':gt'parkM','aa'
	elseif harakBoyA = 2:
		gs 'zz_render', '', '', func('parkM_strings', 'local_str5')
		act 'Целовать':gt'parkM','kiss'
		act 'Отстраниться':
			cla
			DOM += 1
			bfA -= 1
			gs 'zz_render', '', '', func('parkM_strings', 'local_str6')
			act 'Далее':gt'parkM','aa'
		end
	end
end
if $ARGS[0] = 'kiss':
	minut += 15
	bfA += 1
	horny += 5
	gs 'zz_render', '', '', func('parkM_strings', 'local_str7')
	act 'Прекрати':
		cla
		DOM += 1
		bfA -= 1
		gs 'zz_render', '', '', func('parkM_strings', 'local_str8')
		act 'Далее':gt'parkM','aa'
	end
	act 'Идти с парнем':gt'parkM','sexrand'
end
if $ARGS[0] = 'sexrand':
	cla
	*clr
	minut += 15
	bfA += 1
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/picVA/park.jpg', func('parkM_strings', 'local_str9')
	act 'Прекрати':
		cla
		DOM += 1
		bfA -= 1
		gs 'zz_render', '', '', func('parkM_strings', 'local_str10')
		act 'Далее':gt'parkM','aa'
	end
	act 'Позволить':gt'parkM','sexrand1'
end
if $ARGS[0] = 'sexrand1':
	cla
	*clr
	minut += 15
	bfA += 1
	horny += 20
	gs'stat'
	gs 'zz_render', '', 'images/picVA/park1.jpg', func('parkM_strings', 'local_str11')
	act 'Мы не можем тут этим заниматься':
		cla
		DOM += 1
		bfA -= 1
		gs 'zz_render', '', '', func('parkM_strings', 'local_str12')
		act 'Далее':gt'parkM','aa'
	end
	act 'Встать на колени':gt'parkM','sexrand2'
end
if $ARGS[0] = 'sexrand2':
	cla
	*clr
	minut += 15
	bfA += 1
	horny += 5
	bj += 1
	bja += 1
	gs'brosok'
	gs'stat'
	gs 'zz_render', '', 'images/picVA/park2.jpg', func('parkM_strings', 'local_str13')
	act 'Продолжить сосать':gt'parkM','sexrand3'
	act 'Секс':gt'parkM','sexrand4'
end
if $ARGS[0] = 'sexrand3':
	cla
	*clr
	minut += 15
	bfA += 1
	horny += 5
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/park3.jpg', func('parkM_strings', 'local_str14')
	act 'Уйти':gt'zz_park','main'
end
if $ARGS[0] = 'sexrand4':
	cla
	*clr
	minut += 15
	sex += 1
	sexa += 1
	pose = 1
	$boy = $boyA
	dick = dickA
	silavag = silavagA
	gs'stat'
	gs 'zz_render', '', 'images/picVA/park4.jpg', func('parkM_strings', 'local_str15')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Уйти':gt'zz_park','main'
end
if $ARGS[0] = 'aa':
	minut += 30
	gs 'zz_render', '', '', func('parkM_strings', 'local_str16')
	act 'Домой':gt'sexm','start'
end