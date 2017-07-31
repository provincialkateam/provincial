if $ARGS[0] = 'boss':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	if pfilm = 1: pfcash = 2000
	if pfilm = 2: pfcash = 3000
	if pfilm = 3: pfcash = 5000
	if pfilm = 4: pfcash = 6000
	if pfilm = 5: pfcash = 7000
	if pfilm = 6: pfcash = 9000
	film_history[film+"_"+'day'] = day
	film_history[film+"_"+'month'] = month
	film_history[film+"_"+'year'] = year
	film_history[film+"_"+'pfilm'] = pfilm - 1
	film += 1
	if pfilmNOPAY = 0:
		money += pfcash + iif(film < 10, 0, 100 * film)
		gs 'zz_render', '', '', func('pf_strings', 'local_str'+iif(film < 10,1,2))
	else
		pfilmNOPAY = 0
		gs 'zz_render', '', '', func('pf_strings', 'local_str3')
	end
	pfilm = 0
	if film < 10: filmkoef = 2
	if film >= 10 and film < 20: filmkoef = 5
	if film >= 20: filmkoef = 10
	pffilmday = daystart + (film + filmkoef)
	pfilmday = 0
	gs 'stat'
	gs 'zz_render', '', '', func('pf_strings', 'local_str4')
	act 'Уйти': gt'pornstudio','start'
end
if $ARGS[0] = 'doc':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('pf_strings', 'local_str5')
	act 'Ждать':gt'pf','lab'
end
if $ARGS[0] = 'lab':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gs 'stat'
	if venera > 0:
		pfilmNO = 1
		pfilmNoVenera = 1
		gs 'zz_render', '', '', func('pf_strings', 'local_str6')
		act 'Уйти': gt'pornstudio','start'
	else
		gs 'zz_render', '', '', func('pf_strings', 'local_str7')
		act 'Идти в гримерку': gt'pf','grim'
	end
end
if $ARGS[0] = 'grim':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	mop = 4
	gs 'stat'
	gs 'zz_render', '', '', func('pf_strings', 'local_str8') + func('pf_strings', 'local_str9')
	act 'Идти на съемочную площадку': gt 'pf', str(pfilm)
end
if $args[0] = 'finish':
	act 'Идти в душ':
		*clr & cla
		minut += 5
		gs 'zz_bathroom', 'shower'
		gs 'zz_render', '', 'images/pics/dush.jpg', func('pf_strings', 'local_str10')
		act 'Идти к Петру': gt 'pf', 'boss'
	end
end
if $args[0] = 'prepeare':
	gs 'zz_render', '', '', func('pf_strings', 'local_str11')
	$pakter_arr[0] = 'Алексей'
	$pakter_arr[1] = 'Сергей'
	$pakter_arr[2] = 'Джордж'
	$pakter_arr[3] = 'Игнат'
	$pakter_arr[4] = 'Семен'
	$pakter_arr2[0] = 'Алексея'
	$pakter_arr2[1] = 'Сергея'
	$pakter_arr2[2] = 'Джорджа'
	$pakter_arr2[3] = 'Игната'
	$pakter_arr2[4] = 'Семена'
	if $args[1]= 'group':
		! make array
		zz_arr[0] = 0
		zz_arr[1] = 1
		zz_arr[2] = 2
		zz_arr[3] = 3
		zz_arr[4] = 4
		! first guy
		akrand = RAND(0,4)
		! copy unused id to new arr
		i = 0
		:loop_remake_arr
		if i < 5:
			if zz_arr[i]!akrand: zz_arr2[] = zz_arr[i]
			i += 1
			jump 'loop_remake_arr'
		end
		! second guy
		akrand2 = zz_arr2[rand(arrsize('zz_arr2'))]
		$pakter = $pakter_arr[akrand]
		$pakter2 = $pakter_arr[akrand2]
		$pakter22 = $pakter_arr2[akrand2]
		! remove temporary variables
		killvar 'zz_arr'
		killvar 'zz_arr2'
		killvar 'akrand2'
		gs 'zz_render', '', '', func('pf_strings', 'local_str12')
	else
		$pakter = $pakter_arr[akrand]
		gs 'zz_render', '', '', func('pf_strings', 'local_str13')
	end
	killvar 'akrand'
	killvar '$pakter_arr'
	killvar '$pakter_arr2'
end
if $args[0] = 'hj':
	hj += 1
	gs 'zz_render', '', 'images/city/center/studia/hj.gif', func('pf_strings', 'local_str14')
end
if $args[0] = 'bj':
	*clr & cla
	bj += 1
	minut += 5
	gs 'zz_render', '', 'images/city/center/studia/bj.gif', func('pf_strings', 'local_str15')
end
if $args[0] = 'bj2':
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/city/center/studia/deep.gif', func('pf_strings', 'local_str16')
end
if $args[0] = 'facial':
	act 'Сесть на колени и открыть рот':
		*clr & cla
		minut += 5
		gs 'zz_funcs', 'cum', 'lip'
		gs 'stat'
		gs 'zz_render', '', 'images/city/center/studia/cum.gif', func('pf_strings', 'local_str17')
		act 'Чистить ртом его член от спермы':
			*clr & cla
			minut += 5
			swallow += 1
			gs 'stat'
			gs 'zz_render', '', 'images/city/center/studia/bj2.gif', func('pf_strings', 'local_str18')
			gs 'pf', 'finish'
		end
	end
end
if $args[0] = 'vaginal':
	*clr & cla
	sex += 1
	vagina += 1
	minut += 15
	gs 'zz_render', '', 'images/city/center/studia/sex.gif', func('pf_strings', 'local_str19')
end
if $args[0] = 'bj_group':
	bj += 2
	gs 'zz_render', '', 'images/city/center/studia/tbj.gif', func('pf_strings', 'local_str20')
end
if $args[0] = 'bj2_group':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/tbj2.gif', func('pf_strings', 'local_str21')
end
if $args[0] = 'vaginal_group':
	*clr & cla
	minut += 15
	sex += 1
	vagina += 1
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/three.gif', func('pf_strings', 'local_str22')
end
if $args[0] = 'anal_group':
	*clr & cla
	minut += 15
	anal += 1
	anus += 1
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/threea.gif', func('pf_strings', 'local_str23')
end
if $args[0] = 'facial_group':
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/tcum.gif', func('pf_strings', 'local_str24')
	gs 'pf', 'finish'
end
if $ARGS[0] = '1':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'pf', 'prepeare'
	act 'Сниматься':
		*clr & cla
		minut += 30
		pornhj += 1
		guy += 1
		gs 'stat'
		gs 'pf', 'hj'
		act 'Дрочить на груди':
			*clr & cla
			minut += 5
			gs 'zz_render', '', 'images/city/center/studia/hjcumontits.gif', func('pf_strings', 'local_str25')
			gs 'pf', 'finish'
		end
	end
end
if $ARGS[0] = '2':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'pf', 'prepeare'
	act 'Сниматься':
		*clr & cla
		minut += 30
		pornbj += 1
		guy += 1
		gs 'stat'
		gs 'pf', 'hj'
		act 'Взять в рот':
			gs 'pf', 'bj'
			act 'Сосать':
				gs 'pf', 'bj2'
				gs 'zz_render', '', '', func('pf_strings', 'local_str26')
				gs 'pf', 'facial'
			end
		end
	end
end
if $ARGS[0] = '3':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'pf', 'prepeare'
	act 'Сниматься':
		*clr & cla
		minut += 30
		pornclassic += 1
		guy += 1
		gs 'stat'
		gs 'pf', 'hj'
		act 'Взять в рот':
			gs 'pf', 'bj'
			act 'Сосать':
				gs 'pf', 'bj2'
				act 'Встать раком':
					gs 'pf', 'vaginal'
					gs 'pf', 'facial'
				end
			end
		end
	end
end
if $ARGS[0] = '4':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'pf', 'prepeare'
	act 'Сниматься':
		*clr & cla
		minut += 30
		pornall += 1
		guy += 1
		gs 'stat'
		gs 'pf', 'hj'
		act 'Взять в рот':
			gs 'pf', 'bj'
			act 'Сосать':
				gs 'pf', 'bj2'
				act 'Встать раком':
					gs 'pf', 'vaginal'
					gs 'zz_render', '', '', func('pf_strings', 'local_str27')
					act 'Расслабить анус':
						*clr & cla
						anal += 1
						anus += 1
						minut += 5
						gs 'zz_render', '', 'images/city/center/studia/sex.gif', func('pf_strings', 'local_str28')
						gs 'pf', 'facial'
					end
				end
			end
		end
	end
end
if $ARGS[0] = '5':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gang += 1
	gs 'stat'
	gs 'pf', 'prepeare', 'group'
	act 'Сниматься':
		*clr & cla
		minut += 10
		porngroup += 1
		gs 'stat'
		gs 'pf', 'bj_group'
		act 'Сосать':
			gs 'pf', 'bj2_group'
			act 'Трахаться':
				gs 'pf', 'vaginal_group'
				act 'Анал':
					gs 'pf', 'anal_group'
					act 'Окончание на лицо': gs 'pf', 'facial_group'
				end
			end
		end
	end
end
if $ARGS[0] = '6':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 30
	gang += 1
	gs 'stat'
	gs 'pf', 'prepeare', 'group'
	act 'Сниматься':
		*clr & cla
		minut += 10
		porngrouphard += 1
		gs 'stat'
		gs 'pf', 'bj_group'
		act 'Сосать':
			gs 'pf', 'bj2_group'
			act 'Трахаться':
				gs 'pf', 'vaginal_group'
				act 'Анал':
					gs 'pf', 'anal_group'
					act 'Двойное проникновение':
						*clr & cla
						minut += 15
						anus += 1
						vagina += 1
						gs 'stat'
						gs 'zz_render', '', 'images/city/center/studia/three2.gif', func('pf_strings', 'local_str29')
						act 'Окончание на лицо': gs 'pf', 'facial_group'
					end
				end
			end
		end
	end
end