$d_slut_horny = {
	you_slut += 1
	horny += iif(you_slut > 100, 10, you_slut/10)
}
$snkayf = {
	hour += 2
	snkz = RAND(1,6)
	if tanga = 1: tanga = 0
	if snkz = 1: gt 'gdk'
	if snkz = 2: gt 'zz_park'
	if snkz = 3: gt 'bedrPar'
	if snkz = 4: gt 'gopskver'
	if snkz = 5: gt 'vokdin','vokzalg_toilet_f'
	if snkz = 6: current_clothing = 0 & gt'glake'
}
$narkozakladka = {
	*clr & cla
	gs 'zz_render', 'Наркопритон', 'images/pic/narkopriton.jpg', func('din2_strings', 'local_str5')
	act 'Согласиться':
		snarkozak = 1
		gs 'zz_render', '', '', func('din2_strings', 'local_str6')
		act 'Уйти': gt 'narkopriton'
	end
}
$snkayf1 = {
	hour += 2
	snkz = RAND(1,5)
	if tanga = 1: tanga = 0
	if snkz = 1: gt 'zz_park'
	if snkz = 2: gt 'down'
	if snkz = 3: gt 'nord'
	if snkz = 4: gt 'street'
	if snkz = 5: gt 'lake','start'
}