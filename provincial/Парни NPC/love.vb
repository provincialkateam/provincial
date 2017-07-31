if $ARGS[0] = 'start':
	cla
	*clr
	gt 'love', str(harakBoyA)
end
if $ARGS[0] = '0':
	cla
	*clr
	love = 1
	gs 'zz_render', '', '', func('love_strings', 'local_str1')
	act 'Пригласить к себе':
		cla
		gt'sexm','room'
	end
end
if $ARGS[0] = 'mother':
	cla
	*clr
	minut += 60
	gs 'zz_render', '', '', func('love_strings', 'local_str2')
	if work = 1 and workKafe = 1:'Вы ответили, что вы официантка в кафе.'
	if student > 0 and diplom = 0:'Учусь в университете.'
	if diplom = 1:'Дипломированный специалист закончивший университет.'
	if work = 0 and workKafe ! 1:'Я безработная.'
	if modelfoto > 0:
		bfA = 0
		gs 'zz_render', '', '', func('love_strings', 'local_str3')
		act 'Уйти': gt 'street'
		exit
	end
	if kavslut > 0:
		bfA = 0
		gs 'zz_render', '', '', func('love_strings', 'local_str4')
		act 'Уйти': gt 'street'
		exit
	end
	if frot > 3:
		bfA = 0
		gs 'zz_render', '', '', func('love_strings', 'local_str5')
		act 'Уйти': gt 'street'
		exit
	end
	if gloryhole > 30:
		bfA = 0
		gs 'zz_render', '', '', func('love_strings', 'local_str6')
		act 'Уйти': gt 'street'
		exit
	end
	love = 2
	gs 'zz_render', '', '', func('love_strings', 'local_str7')
	act 'Уйти': gt 'street'
end
if $ARGS[0] = '1':
	cla
	*clr
	love = 1
	gs 'zz_render', '', '', func('love_strings', 'local_str8')
	act 'Пригласить к себе':
		cla
		gt'sexm','room'
	end
end
if $ARGS[0] = 'frends':
	cla
	*clr
	'<center><img src="images/img/hasb/z0.jpg"></center>'
	if proverka1 = 0 and proverka2 = 0 and proverka3 = 0 and proverka4 = 0 and proverka5 = 0:
		minut += 180
		gs 'zz_render', '', '', func('love_strings', 'local_str9')
	end
	if modelfoto > 0 and proverka1 = 0:
		gs 'zz_render', '', '', func('love_strings', 'local_str10')
		if intel <= 30:
			guy += 2
			picrand = 39
			bfA = 0
			gs 'zz_render', '', '', func('love_strings', 'local_str11')
			act 'Дальше':xgt'sexdvoe','var'
		else
			proverka1 = 1
			gs 'zz_render', '', '', func('love_strings', 'local_str12')
			act 'Дальше':gt'love','frends'
		end
		exit
	end
	if kavslut > 0 and proverka2 = 0:
		cla
		gs 'zz_render', '', '', func('love_strings', 'local_str13')
		if intel <= 50:
			guy += 2
			picrand = 39
			bfA = 0
			gs 'zz_render', '', '', func('love_strings', 'local_str14')
			act 'Дальше':gt'sexdvoe','var'
		else
			proverka2 = 1
			gs 'zz_render', '', '', func('love_strings', 'local_str15')
			act 'Дальше':gt'love','frends'
		end
		exit
	end
	if frot > 3 and proverka3 = 0:
		cla
		gs 'zz_render', '', '', func('love_strings', 'local_str16')
		if intel <= 40:
			guy += 2
			picrand = 39
			bfA = 0
			gs 'zz_render', '', '', func('love_strings', 'local_str17')
			act 'Дальше': gt 'sexdvoe','var'
		else
			proverka3 = 1
			gs 'zz_render', '', '', func('love_strings', 'local_str18')
			act 'Дальше': gt 'love','frends'
		end
		exit
	end
	if gloryhole > 30 and proverka4 = 0:
		cla
		gs 'zz_render', '', '', func('love_strings', 'local_str19')
		if intel <= 60:
			guy += 2
			picrand = 39
			bfA = 0
			gs 'zz_render', '', '', func('love_strings', 'local_str20')
			act 'Дальше': gt 'sexdvoe','var'
		else
			proverka4 = 1
			gs 'zz_render', '', '', func('love_strings', 'local_str21')
			act 'Дальше': gt 'love','frends'
		end
		exit
	end
	if film > 2 and proverka5 = 0:
		cla
		gs 'zz_render', '', '', func('love_strings', 'local_str22')
		if intel <= 70 and izvrat = 0:
			guy += 2
			picrand = 39
			bfA = 0
			gs 'zz_render', '', '', func('love_strings', 'local_str23')
			act 'Дальше':gt'sexdvoe','var'
		elseif intel > 70 or izvrat = 1:
			proverka5 = 1
			gs 'zz_render', '', '', func('love_strings', 'local_str24')
			act 'Дальше':gt'love','frends'
		end
		exit
	end
	love = 2
	gs 'zz_render', '', '', func('love_strings', 'local_str25')
	act 'Уйти':gt'street'
end
if $ARGS[0] = '2':
	cla
	*clr
	gs 'zz_render', '', '', func('love_strings', 'local_str26')
	act 'Пригласить к себе':
		cla
		gt 'sexm','room'
	end
end