if $ARGS[0] = 'start':
	*clr & cla
	minut += 30
	sweat += 1
	girl += 1
	guy += 1
	lesbian += 1
	picrand = RAND(0,1)
	gt 'podrsex','var'
end
if $ARGS[0] = 'var':
	podrsexrand = RAND(0,4)
	if podrsexrand = 0:
		*clr & cla
		horny += 10
		sexvar += 1
		if pdsxbj = 0:
			bj += 1
			pdsxbj = 1
		end
		gs 'stat'
		gs 'zz_render', '', 'images/img/podrsex/minet<<picrand>>.jpg', func('podrsex_strings', 'local_str1')
		act 'Еще': gt'podrsex','var'
		if sexvar >= 3: act 'Закончить': gt'podrsex','end'
	elseif podrsexrand = 1:
		*clr & cla
		horny += 10
		sexvar += 1
		gs 'stat'
		gs 'zz_render', '', 'images/img/podrsex/vag<<picrand>>.jpg', func('podrsex_strings', 'local_str2')
		act 'Еще': gt 'podrsex','var'
		if sexvar >= 3: act 'Закончить': gt'podrsex','end'
	elseif podrsexrand = 2:
		*clr & cla
		horny += 10
		sexvar += 1
		if pdsxsex = 0:
			sex += 1
			pdsxsex = 1
		end
		gs 'stat'
		gs 'zz_render', '', 'images/img/podrsex/uvag<<picrand>>.jpg', func('podrsex_strings', 'local_str3')
		act 'Еще': gt'podrsex','var'
		if sexvar >= 3: act 'Закончить':gt'podrsex','end'
	elseif podrsexrand = 3:
		*clr & cla
		horny += 10
		sexvar += 1
		gs 'stat'
		gs 'zz_render', '', 'images/img/podrsex/anal<<picrand>>.jpg', func('podrsex_strings', 'local_str4')
		act 'Еще': gt'podrsex','var'
		if sexvar >= 3: act 'Закончить':gt'podrsex','end'
	else
		*clr & cla
		horny += 10
		sexvar += 1
		if pdsxanal = 0:
			anal += 1
			pdsxanal = 1
		end
		gs 'stat'
		gs 'zz_render', '', 'images/img/podrsex/uanal<<picrand>>.jpg', func('podrsex_strings', 'local_str5')
		act 'Еще': gt'podrsex','var'
		if sexvar >= 3: act 'Закончить':gt'podrsex','end'
	end
end
if $ARGS[0] = 'end':
	*clr & cla
	pdsxbj = 0
	pdsxsex = 0
	pdsxanal = 0
	sexvar = 0
	cumlip = 1
	if horny >= 80:
		horny = 0
		orgasm += 1
	end
	gs 'zz_render', '', 'images/img/podrsex/cum<<picrand>>.jpg', func('podrsex_strings', 'local_str6')
	act 'Уйти':
		if picrand = 26 or picrand = 27 or picrand = 29:gt'office','work'
		if picrand >= 30 and picrand <= 32:gt'down'
		if kazsexdva = 1:
			kazsexdva = 0
			gt 'kazinosvid','3'
		end
		gt '<<$sexloc>>','start'
	end
end