if $args[0] = 'start' or $args[0] = '':
	*clr & cla
	gs 'zz_render', 'Станция метро ' + iif($loc = 'street','"Южный район"',iif($loc = 'down','"Центр"','"Северный район"')), 'images/pic/subway_'+$loc+'.jpg"', func('metro_strings', 'local_str1')
	minut += 15
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if workDisk = 3 and konvert = 1 and rand(0,100) >= 80: konvert = 0
	if money >= 30:
		if $loc ! 'street':
			act 'Ехать в Южный район':
				$loc = 'street'
				gt 'metro', 'vagon'
			end
		end
		if $loc ! 'down':
			act 'Ехать в Центр':
				$loc = 'down'
				gt 'metro', 'vagon'
			end
		end
		if $loc ! 'nord':
			act 'Ехать в Северный район':
				$loc = 'nord'
				gt 'metro', 'vagon'
			end
		end
	end
	act 'Выйти из метро':
		minut += 15
		gt $loc
	end
end
if $ARGS[0] = 'vagon':
	*clr & cla
	money -= 30
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Вагон метро', 'images/pic/vag_'+$loc+'.jpg', func('metro_strings', 'local_str'+iif(hour >= 5 and hour <= 10 or hour >= 15,2,3))
	if (hour >= 5 and hour <= 10 or hour >= 15) and rand(0,100) > 60: gt 'metro', iif(frot < 3,'var0',iif(cumfrot = 0 and func('zz_clothing','is_skirt') = 1,'var<<rand(1,2)>>','var<<rand(3,5)>>'))
	if sosedQW >= 1 and (hour = 7 or hour = 17) and rand(0,100) > 60 and sosedMetroDay ! day: gs 'zz_render', '', '', func('metro_strings', 'local_str4')
	if (cumfrot + cumface > 0) and hour >= 7 and hour <= 21:
		manna -= 10
		gs 'zz_render', '', '', func('metro_strings', 'local_str5')
	end
	act 'Выйти из вагона': gt 'metro'
end
! ex. frot location
if $ARGS[0] = 'metro_handjob':
	act 'Дрочить ему член':
		*clr & cla
		horny += 10
		hj += 1
		gs 'zz_funcs', 'cum', 'ass'
		dom -= 1
		frot += 1
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frotD1.jpg', func('metro_strings', 'local_str11')
		act 'Выйти из вагона': gt 'metro'
	end
end
if $ARGS[0] = 'var0':
	*clr & cla
	gs 'zz_render', '', 'images/picV/frot.jpg', func('metro_strings', 'local_str12')
	act 'Перейти в другое место': gt 'metro', 'fin'
	act 'Не обращать внимания':
		*clr & cla
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frot1.jpg', func('metro_strings', 'local_str13')
		act 'Перейти в другое место': gt 'metro', 'fin'
		act 'Не обращать внимания':
			*clr & cla
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/picV/frot2.jpg', func('metro_strings', 'local_str14')
			act 'Перейти в другое место': gt 'metro', 'fin'
			act 'Не обращать внимания':
				*clr & cla
				horny += 10
				frot += 1
				cumfrot += 1
				dom -= 5
				gs 'stat'
				gs 'zz_render', '', 'images/picV/frot3.jpg', func('metro_strings', 'local_str15')
				act 'Выйти из вагона': gt 'metro'
			end
		end
	end
end
if $ARGS[0] = 'var1':
	*clr & cla
	gs 'zz_render', '', 'images/picV/frot.jpg', func('metro_strings', 'local_str16')
	act 'Перейти в другое место': gt 'metro', 'fin'
	act 'Не обращать внимания':
		*clr & cla
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frot1.jpg', func('metro_strings', 'local_str17')
		act 'Перейти в другое место': gt 'metro', 'fin'
		act 'Не обращать внимания':
			*clr & cla
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/picV/frotA1.jpg', func('metro_strings', 'local_str18')
			act 'Не обращать внимания':
				*clr & cla
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'images/picV/frotA2.jpg', func('metro_strings', 'local_str19')
				act 'Не обращать внимания':
					*clr & cla
					horny += 10
					frot += 1
					cumfrot += 1
					dom -= 1
					gs 'stat'
					gs 'zz_render', '', 'images/picV/frot3.jpg', func('metro_strings', 'local_str20')
					act 'Выйти из вагона': gt 'metro'
				end
			end
		end
	end
end
if $ARGS[0] = 'var2':
	*clr & cla
	gs 'zz_render', '', 'images/picV/frotD2.jpg', func('metro_strings', 'local_str40')
	act 'Перейти в другое место': gt 'metro', 'fin'
	act 'Не обращать внимания':
		*clr & cla
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frotD.jpg', func('metro_strings', 'local_str41')
		act 'Перейти в другое место': gt 'metro', 'fin'
		gs 'metro','metro_handjob'
	end
end
if $ARGS[0] = 'var3':
	*clr & cla
	gs 'zz_render', '', 'images/picV/frotP.jpg', func('metro_strings', 'local_str21')
	act 'Перейти в другое место': gt 'metro', 'fin'
	act 'Не обращать внимания':
		*clr & cla
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frotP1.jpg', func('metro_strings', 'local_str22')
		act 'Перейти в другое место': gt 'metro', 'fin'
		act 'Не обращать внимания':
			*clr & cla
			horny += 10
			clrbelo -= 1
			dom -= 1
			gs 'stat'
			gs 'zz_render', '', 'images/picV/frotP2.jpg', func('metro_strings', 'local_str23')
			act 'Наслаждаться':
				*clr & cla
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'images/picV/frotP3.jpg', func('metro_strings', 'local_str24')
				act 'Перейти в другое место': gt 'metro', 'fin'
				act 'Позволить ему это':
					*clr & cla
					horny += 10
					cumfrot += 1
					dom -= 5
					gs 'zz_clothing', 'decrease_condition', 5
					gs 'stat'
					gs 'zz_render', '', 'images/picV/frotP4.jpg', func('metro_strings', 'local_str25')
					act 'Позволить ему это':
						*clr & cla
						dom -= 1
						horny += 10
						guy += 1
						sex += 1
						vagina += 1
						gs 'stat'
						gs 'zz_render', '', 'images/picV/frotP5.jpg', func('metro_strings', 'local_str26')
						if horny >= 100:
							horny = 0
							manna += 15
							orgasm += 1
							gs 'zz_render', '', '', func('metro_strings', 'local_str27')
						else
							gs 'zz_render', '', '', func('metro_strings', 'local_str28')
						end
						act 'Дальше':
							*clr & cla
							horny += 10
							frot += 1
							cumfrot += 1
							dom -= 1
							gs 'stat'
							gs 'zz_render', '', 'images/picV/frotP6.jpg', func('metro_strings', 'local_str29')
							gs 'zz_funcs', 'cum', 'pussy'
							act 'Выйти из вагона': gt 'metro'
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'var4':
	*clr & cla
	gs 'zz_render', '', 'images/picV/frotP.jpg', func('metro_strings', 'local_str30')
	act 'Перейти в другое место': gt 'metro', 'fin'
	act 'Не обращать внимания':
		*clr & cla
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frotD.jpg', func('metro_strings', 'local_str31')
		act 'Перейти в другое место': gt 'metro', 'fin'
		gs 'metro','metro_handjob'
	end
end
if $ARGS[0] = 'var5':
	*clr & cla
	gs 'zz_render', '', 'images/picV/frotP.jpg', func('metro_strings', 'local_str32')
	act 'Перейти в другое место': gt 'metro', 'fin'
	act 'Не обращать внимания':
		*clr & cla
		horny += 30
		gs 'stat'
		gs 'zz_render', '', 'images/picV/frotE.jpg', func('metro_strings', 'local_str33')
		if horny >= 90:
			horny = 0
			manna += 15
			orgasm += 1
			gs 'zz_render', '', '', func('metro_strings', 'local_str34')
			act 'Сесть на корточки':
				*clr & cla
				horny += 10
				dom -= 1
				gs 'stat'
				gs 'zz_render', '', 'images/picV/frotE1.jpg', func('metro_strings', 'local_str35')
				act 'Взять в рот':
					*clr & cla
					horny += 10
					bj += 1
					guy += 1
					dom -= 1
					frot += 1
					gs 'stat'
					gs 'zz_render', '', 'images/picV/frotE2.jpg', func('metro_strings', 'local_str36')
					act 'Продолжать сосать':
						*clr & cla
						horny += 10
						gs 'zz_funcs', 'cum', 'face'
						gs 'stat'
						gs 'zz_render', '', 'images/picV/frotE3.jpg', func('metro_strings', 'local_str37')
						act 'Сидеть на полу':
							*clr & cla
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							dom -= 1
							gs 'stat'
							gs 'zz_render', '', 'images/picV/frotE4.jpg', func('metro_strings', 'local_str38')
							act 'Выйти из вагона': gt 'metro'
						end
					end
				end
			end
			exit
		else
			gs 'zz_render', '', '', func('metro_strings', 'local_str39')
			gs 'metro','metro_handjob'
		end
	end
end
if $ARGS[0] = 'fin':
	!cla
	gs 'zz_render', '', 'images/pic/vagonFull.jpg', func('metro_strings', 'local_str42')
	act 'Выйти из вагона': gt 'metro'
end