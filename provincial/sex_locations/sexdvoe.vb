if $ARGS[0] = 'start':
	minut += 30
	sweat += 1
	guy += 2
	picrand = RAND(0,1)
	xgt'sexdvoe','var'
end
if $ARGS[0] = 'var':
	sexrand = RAND(0,3)
	if picrand = 12:sexrand = RAND(0,2)
	if picrand = 40:sexrand = RAND(1,2)
	if sexrand = 0:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvsxbj = 0:
			bj += 1
			dvsxbj = 1
		end
		gs 'zz_render', '', 'img/sexdvoe/minet<<picrand>>.jpg', func('sexdvoe_strings', 'local_str1')
		if sexvar < 3:act 'Еще':xgt'sexdvoe','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvoe','end'
	elseif sexrand = 1:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvsxbj = 0:
			bj += 1
			dvsxbj = 1
		end
		if dvsxsex = 0:
			sex += 1
			dvsxsex = 1
		end
		gs 'zz_render', '', 'img/sexdvoe/vag<<picrand>>.jpg', func('sexdvoe_strings', 'local_str2')
		if sexvar < 3:act 'Еще':xgt'sexdvoe','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvoe','end'
	elseif sexrand = 2:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvsxbj = 0:
			bj += 1
			dvsxbj = 1
		end
		if dvsxanal = 0:
			anal += 1
			dvsxanal = 1
		end
		gs 'zz_render', '', 'img/sexdvoe/anal<<picrand>>.jpg', func('sexdvoe_strings', 'local_str3')
		if sexvar < 3:act 'Еще':xgt'sexdvoe','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvoe','end'
	elseif sexrand = 3:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvsxsex = 0:
			sex += 1
			dvsxsex = 1
		end
		if dvsxanal = 0:
			anal += 1
			dvsxanal = 1
		end
		gs 'zz_render', '', 'img/sexdvoe/dp<<picrand>>.jpg', func('sexdvoe_strings', 'local_str4')
		if sexvar < 3:act 'Еще':xgt'sexdvoe','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvoe','end'
	end
end
if $ARGS[0] = 'end':
	*clr & cla
	minut += 10
	dvsxbj = 0
	dvsxsex = 0
	dvsxanal = 0
	sexvar = 0
	cumbelly = 1
	cumlip = 1
	gs 'zz_funcs', 'cum', 'face'
	if horny >= 80:
		horny = 0
		orgasm += 1
	end
	gs 'zz_render', '', 'img/sexdvoe/cum<<picrand>>.jpg', func('sexdvoe_strings', 'local_str5')
	if picrand = 29: gs 'zz_render', '', '', func('sexdvoe_strings', 'local_str6')
	if picrand = 39: gs 'zz_render', '', '', func('sexdvoe_strings', 'local_str7')
	act 'Уйти':
		if picrand >= 24 and picrand <= 26:gt'office','work'
		if picrand >= 30 and picrand <= 34:gt'office','work'
		if picrand >= 35 and picrand <= 37:gt'house'
		if picrand >= 40 and picrand <= 43:gt'korr'
		if picrand = 38:gt'bed','vorend'
		if picrand = 29 or picrand = 39:gt'nord'
		if kafesexrand = 1:
			kafesexrand = 0
			gt'kafe','workPred'
		end
		gt'<<$sexloc>>','start'
	end
end