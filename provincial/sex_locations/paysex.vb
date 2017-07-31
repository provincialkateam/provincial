if $ARGS[0] = 'start':
	minut += 30
	gang += 1
	sweat += 1
	picrand = RAND(0,1)
	gt'paysex','var'
end
if $ARGS[0] = 'var':
	colpaysex += 1
	paysexrand = RAND(0,2)
	if paysexrand = 0:
		*clr & cla
		horny += 10
		dom -= 1
		if paysxbj = 0:
			bj += 1
			paysxbj = 1
		end
		if paysxsex = 0:
			sex += 1
			paysxsex = 1
		end
		gs 'zz_render', '', 'images/img/paysex/vag<<picrand>>.jpg', func('paysex_strings', 'local_str1')
		act 'Еще':gt'paysex','var'
		if colpaysex > 3: act 'Закончить':gt'paysex','end'
	elseif paysexrand = 1:
		*clr & cla
		horny += 10
		dom -= 1
		if paysxbj = 0:
			bj += 1
			paysxbj = 1
		end
		if paysxanal = 0:
			anal += 1
			paysxanal = 1
		end
		gs 'zz_render', '', 'images/img/paysex/anal<<picrand>>.jpg', func('paysex_strings', 'local_str2')
		act 'Еще': gt'paysex','var'
		if colpaysex > 3: act 'Закончить':gt'paysex','end'
	elseif paysexrand = 2:
		*clr & cla
		horny += 10
		if paysxbj = 0:
			bj += 1
			paysxbj = 1
		end
		if paysxsex = 0:
			sex += 1
			paysxsex = 1
		end
		if paysxanal = 0:
			anal += 1
			paysxanal = 1
		end
		gs 'zz_render', '', 'images/img/paysex/dp<<picrand>>.jpg', func('paysex_strings', 'local_str3')
		act 'Еще': gt'paysex','var'
		if colpaysex > 3: act 'Закончить':gt'paysex','end'
	end
end
if $ARGS[0] = 'end':
	*clr & cla
	paysxbj = 0
	paysxsex = 0
	paysxanal = 0
	colpaysex = 0
	cumbelly = 1
	cumpussy = 1
	cumass = 1
	cumlip = 1
	gs 'zz_funcs', 'cum', 'face'
	if horny >= 80:
		horny = 0
		orgasm += 1
	end
	gs 'zz_render', '', 'images/img/paysex/cum<<picrand>>.jpg', func('paysex_strings', 'local_str4')
	act 'Уйти':
		if picrand = 16 or picrand = 17: gt'office','work'
		if picrand = 18: gt 'husbSex','dolgend'
		gt '<<$sexloc>>','start'
	end
end