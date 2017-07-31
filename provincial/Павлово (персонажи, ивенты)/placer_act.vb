gs'stat'
gs'skverdin'
if plact = 0:
	gs 'BnameGen'
	gs 'zz_render', '', '', func('placer_act_strings', 'local_str1')
	if know_status = 2:
		!гопы
		gs 'zz_render', '', 'images/gevent/skver_znacom_'+iif(month <= 2 or month >= 11,1,3), func('placer_act_strings', 'local_str2')
	else
		!норм
		gs 'zz_render', '', 'images/gevent/skver_znacom_'+iif(month <= 2 or month >= 11,1,2),func('placer_act_strings','local_str'+iif(kol_man = 1,2,6))
	end
	act 'Пить пиво':plact = 1 & gt $curloc
	act 'Уйти':gt'zz_park'
end
!!!!!!!!!!!!!!!
!!!ПЬЮТ ПИВО!!!
!!!!!!!!!!!!!!!
if plact = 1:
	bjgangrand = RAND (0,1)
	gs 'zz_funcs', 'alko', RAND(1,3)
	gs 'stat'
	$textsub2 = iif(kol_man = 1,'парню','парням')
	gs 'zz_render', '', 'images/gevent/skver_znacom_4.jpg', func('placer_act_strings', 'local_str9')
	if know_status = 2:
		!гопы
		if know_gor_slut = 0:
			horny += 5
			gs 'zz_render', '', '', func('placer_act_strings', 'local_str10')
			act 'Целоваться':
				*clr & cla
				horny += 5
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/kiss.jpg', func('placer_act_strings', 'local_str11')
				if dom > 0: act 'Отказаться пить и уйти':gt'zz_park'
				act 'Идти с парнями':
					*clr & cla
					gs 'zz_funcs', 'alko', 3
					gs 'stat'
					gs 'zz_render', '', '', func('placer_act_strings', 'local_str12')
					act 'Далее': gt'gopnik_house'
				end
			end
			act 'Отстраниться':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str13')
				tiprand = RAND(0,2)
				if tiprand = 0:
					gs 'zz_render', '', '', func('placer_act_strings', 'local_str14')
					act 'Выпить':
						*clr & cla
						gs 'zz_funcs', 'alko', 3
						gs 'stat'
						gs 'zz_render', '', '', func('placer_act_strings', 'local_str15')
						if dom > 0: act 'Отказаться пить и уйти':gt'zz_park'
						act 'Выпить':
							*clr & cla
							gs 'zz_funcs', 'alko', 3
							gs 'stat'
							gs 'zz_render', '', '', func('placer_act_strings', 'local_str16')
							gs 'zz_render', '', '', func('placer_act_strings', 'local_str'+iif(alko < 6,17,18))
							act 'Далее': gt'podval_rape'
						end
					end
					act 'Уйти':gt'zz_park'
				elseif tiprand = 1:
					gs 'zz_render', '', '', func('placer_act_strings', 'local_str19')
					act 'Идти с парнями':
						*clr & cla
						gs 'zz_funcs', 'alko', 3
						gs 'stat'
						gs 'zz_render', '', '', func('placer_act_strings', 'local_str20')
						act 'Далее':gt'gopnik_house'
					end
					act 'Уйти':gt'zz_park'
				elseif tiprand = 2:
					gs 'zz_render', '', '', func('placer_act_strings', 'local_str21')
					act 'Идти с парнями':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', '', func('placer_act_strings', 'local_str22')
						act 'Идти в подвал':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', '', func('placer_act_strings', 'local_str23')
							act 'Выпить':
								*clr & cla
								gs 'zz_funcs', 'alko', 3
								gs 'stat'
								gs 'zz_render', '', '', func('placer_act_strings', 'local_str24')
								act 'Далее':gt'podval_rape'
							end
							act 'Отказаться пить':
								*clr & cla
								minut += 5
								manna = 0
								gs 'stat'
								gs 'zz_render', '', '', func('placer_act_strings', 'local_str25')
								act 'Далее':gt'podval_rape'
							end
						end
						act 'Уйти':
							*clr & cla
							minut += 5
							manna = 0
							gs 'stat'
							gs 'zz_render', '', '', func('placer_act_strings', 'local_str26')
							act 'Далее':gt'podval_rape'
						end
					end
					act 'Уйти':gt'zz_park'
				end
			end
		elseif know_gor_slut = 1 and BjBeerQW > 1 and bjgangrand = 1:
			gs 'zz_render', '', '', func('placer_act_strings', 'local_str27')
			act 'Идти "отрабатывать"':
				*clr & cla
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str28')
				act 'Встать на колени и открыть рот':
					*clr & cla
					bj += kol_man
					guy += kol_man
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					face_write = 1
					gang += 1
					if mop > 1: mop = 0 & vidageday -= 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/placer/blowbang2.jpg', func('placer_act_strings', 'local_str29')
					act 'Тереть глаза':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/placer/blowbang'+RAND(3,4)+'.jpg', func('placer_act_strings', 'local_str30')
						act 'Уйти':gt'zz_park'
					end
				end
			end
		elseif know_gor_slut = 1:
			gs 'zz_render', '', '', func('placer_act_strings', 'local_str31')
			act 'Идти с парнями':
				*clr & cla
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str32')
				act 'Сесть на корточки':
					*clr & cla
					bj += kol_man
					guy += kol_man
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					gang += 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/placer/blowbang.jpg', func('placer_act_strings', 'local_str33')
					act 'Уйти':gt'zz_park'
				end
			end
		end
	end
	if know_status < 2:
		tiprand = RAND(0,1)
		tiploverand = RAND(0,1)
		!норм
		if kol_man = 1:
			if slut_vid > 0:
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str39')
				act 'Целоваться':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/Ev/kiss', func('placer_act_strings', 'local_str40')
					act 'Эй! Ты что творишь?':
						*clr & cla
						gs 'zz_render', '', '', func('placer_act_strings', 'local_str41')
						dynamic $d_park_placer_bj
						act 'Уйти': gt'zz_park'
					end
					act 'Ты с ума сошел? А если кто увидит?':
						*clr & cla
						gs 'zz_render', '', '', func('placer_act_strings', 'local_str42')
						act 'Я так не могу':
							*clr & cla
							gs 'zz_render', '', '', func('placer_act_strings', 'local_str43')
							act 'Идти с парнем': gt iif(RAND(0,1) = 0,'fbHouse','fbDorm')
							act 'Уйти': gt'zz_park'
						end
						dynamic $d_park_placer_bj
					end
					dynamic $d_park_placer_bj
				end
			else
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str44')
				act 'Идти с парнем': gt iif(RAND(0,1) = 0,'fbHouse','fbDorm')
			end
		else
			if slut_vid > 0:
				if kol_man = 2:$textsub = 'Второй парень смотрит на вас с интересом.'
				if kol_man > 2:$textsub = 'Остальные парни смотрят на вас с интересом'
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str53')
				act 'Целоваться':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/Ev/kiss', func('placer_act_strings', 'local_str54')
					act 'Идти с парнями':
						*clr & cla
						minut += 30
						gs 'stat'
						'<center><img src="images/qwest/alter/placer/go_gay.jpg"></center>'
						if kol_man < 4: 'Зайдя в магазин и прикупив продуктов к столу, парни привели вас в очень уютную квартиру'
						if kol_man => 4: 'Вы пошли в общагу вместе с парнями, по пути парни еще закупились бухлом.'
						act 'Далее':gt'placer_sex'
					end
				end
			else
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str55')
				act 'Идти с парнями':
					*clr & cla
					minut += 30
					gs 'stat'
					'<center><img src="images/qwest/alter/placer/go_gay.jpg"></center>'
					if kol_man < 4: 'Зайдя в магазин и прикупив продуктов к столу, парни привели вас в очень уютную квартиру'
					if kol_man => 4: 'Вы пошли в общагу вместе с парнями, по пути парни еще закупились бухлом.'
					act 'Далее':gt'placer_sex'
				end
			end
		end
	end
	act 'Уйти':
		*clr & cla
		if know_gor_slut = 0:
			if slut_vid = 0:
				gt'zz_park'
			else
				if know_status = 2:
					gs 'zz_render', '', '', func('placer_act_strings', 'local_str60')
					act 'Уйти':gt'zz_park'
				else
					gt'zz_park'
				end
			end
		else
			if know_status = 2:
				gs 'zz_render', '', '', func('placer_act_strings', 'local_str61')
				act 'Уйти': gt'zz_park'
			else
				gt 'zz_park'
			end
		end
	end
end