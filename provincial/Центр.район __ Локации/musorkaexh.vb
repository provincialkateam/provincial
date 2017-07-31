if $ARGS[0] = 'pos2':
	cla
	*clr
	bumtolik = 1
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bum.jpg', func('musorkaexh_strings', 'local_str1')
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'pos3':
	cla
	*clr
	bumtolik = 2
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bum.jpg', func('musorkaexh_strings', 'local_str2')
	act 'Спросить что ему нужно':gt'musorkaexh','pos4'
	act 'Уйти': gt'street'
end
if $ARGS[0] = 'pos4':
	cla
	*clr
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bum.jpg', func('musorkaexh_strings', 'local_str3')
	act 'Дать ему 200 рублей': gt 'musorkaexh','pos6'
	act 'Уйти': gt 'trashplace'
end
if $ARGS[0] = 'pos6':
	cla
	*clr
	minut += 5
	bumtolik = 3
	money -= 200
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bum.jpg', func('musorkaexh_strings', 'local_str5')
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'pos9':
	cla
	*clr
	minut += 5
	bumtolik = 4
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bumt4.jpg', func('musorkaexh_strings', 'local_str10')
	act 'Уйти':gt'street'
end