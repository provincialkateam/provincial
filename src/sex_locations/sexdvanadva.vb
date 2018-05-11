if $ARGS[0] = 'start':
	*clr & cla
	guy += 2
	girl += 1
	gang += 1
	minut += 30
	sweat += 1
	gs 'stat'
	picrand = RAND(0,1)
	xgt'sexdvanadva','var'
end
if $ARGS[0] = 'var':
	sexdvarand = RAND(0,6)
	if pikrand = 11:sexdvarand = RAND(0,5)
	if pikrand = 14:sexdvarand = RAND(0,4)
	if sexdvarand = 0:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvdvsxbj = 0:
			bj += 1
			dvdvsxbj = 1
		end
		gs 'zz_render', '', 'img/sexdvanadva/minet<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str1')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	elseif sexdvarand = 1:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		gs 'zz_render', '', 'img/sexdvanadva/vag<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str2')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	elseif sexdvarand = 2:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvdvsxsex = 0:
			sex += 1
			dvdvsxsex = 1
		end
		gs 'zz_render', '', 'img/sexdvanadva/uvag<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str3')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	elseif sexdvarand = 3:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		gs 'zz_render', '', 'img/sexdvanadva/anal<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str4')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	elseif sexdvarand = 4:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvdvsxanal = 0:
			anal += 1
			dvdvsxanal = 1
		end
		gs 'zz_render', '', 'img/sexdvanadva/uanal<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str5')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	elseif sexdvarand = 5:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		if dvdvsxsex = 0:
			sex += 1
			dvdvsxsex = 1
		end
		if dvdvsxanal = 0:
			anal += 1
			dvdvsxanal = 1
		end
		gs 'zz_render', '', 'img/sexdvanadva/udp<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str6')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	elseif sexdvarand = 6:
		*clr & cla
		horny += 10
		minut += 10
		sexvar += 1
		gs 'zz_render', '', 'img/sexdvanadva/dp<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str7')
		if sexvar < 3:act 'Еще':xgt'sexdvanadva','var'
		if sexvar >= 3:act 'Закончить':gt'sexdvanadva','end'
	end
end
if $ARGS[0] = 'end':
	*clr & cla
	minut += 10
	dvdvsxbj = 0
	dvdvsxsex = 0
	dvdvsxanal = 0
	cumlip = 1
	sexvar = 0
	if horny >= 80:
		horny = 0
		orgasm += 1
	end
	gs 'zz_render', '', 'img/sexdvanadva/cum<<picrand>>.jpg', func('sexdvanadva_strings', 'local_str8')
	act 'Уйти':
		if kafesexrand = 1:
			kafesexrand = 0
			gt'kafe','workPred'
		end
		if kazsexdva = 1:
			kazsexdva = 0
			gt'kazinosvid','3'
		end
		gt'<<$sexloc>>','start'
	end
end