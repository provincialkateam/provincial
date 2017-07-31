if $ARGS[0] = 'start':
	*clr & cla
	minut += 30
	sweat += 1
	picrand = RAND(0,1)
	gs'stat'
	gt'sexorg','var'
end
if $ARGS[0] = 'var':
	sexorgrand = RAND(0,6)
	if sexorgrand = 0:
		*clr & cla
		horny += 10
		sexvar += 1
		if orsxbj = 0:
			bj += 1
			orsxbj = 1
		end
		gs 'zz_render', '', 'img/sexorg/minet11.jpg', func('sexorg_strings', 'local_str1')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	elseif sexorgrand = 1:
		*clr & cla
		horny += 10
		sexvar += 1
		gs 'zz_render', '', 'img/sexorg/vag11.jpg', func('sexorg_strings', 'local_str2')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	elseif sexorgrand = 2:
		*clr & cla
		horny += 10
		sexvar += 1
		if orsxsex = 0:
			sex += 1
			orsxsex = 1
		end
		gs 'zz_render', '', 'img/sexorg/uvag11.jpg', func('sexorg_strings', 'local_str3')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	elseif sexorgrand = 3:
		*clr & cla
		horny += 10
		sexvar += 1
		gs 'zz_render', '', 'img/sexorg/anal11.jpg', func('sexorg_strings', 'local_str4')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	elseif sexorgrand = 4:
		*clr & cla
		horny += 10
		if orsxanal = 0:
			anal += 1
			pdsxanal = 1
		end
		gs 'zz_render', '', 'img/sexorg/uanal11.jpg', func('sexorg_strings', 'local_str5')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	elseif sexorgrand = 5:
		*clr & cla
		horny += 10
		if orsxbj = 0:
			bj += 1
			orsxbj = 1
		end
		if orsxsex = 0:
			sex += 1
			orsxsex = 1
		end
		if orsxanal = 0:
			anal += 1
			orsxanal = 1
		end
		gs 'zz_render', '', 'img/sexorg/udp11.jpg', func('sexorg_strings', 'local_str6')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	elseif sexorgrand = 6:
		*clr & cla
		horny += 10
		sexvar += 1
		gs 'zz_render', '', 'img/sexorg/dp11.jpg', func('sexorg_strings', 'local_str7')
		act 'Еще':gt'sexorg','var'
		if sexvar >= 3:act 'Закончить':gt'sexorg','end'
	end
end
if $ARGS[0] = 'end':
	*clr & cla
	orsxbj = 0
	orsxsex = 0
	orsxanal = 0
	sexvar = 0
	cumlip = 1
	if horny >= 80:
		horny = 0
		orgasm += 1
	end
	gs 'zz_render', '', 'img/sexorg/cum11.jpg', func('sexorg_strings', 'local_str8')
	act 'Уйти':gt'<<$sexloc>>','start'
end