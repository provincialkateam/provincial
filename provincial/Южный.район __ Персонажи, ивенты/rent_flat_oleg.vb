! images names R_0.jpg, R_1.jpg, R_2.jpg, R_5.jpg, R_6.jpg, R_7.gif - R_22.gif
if $args[0] = 'rent_event_1':
	*clr & cla
	minut += 1
	gs 'stat'
	_stage = args[1]
	if _stage < 2:
		gs 'zz_render', '', 'city/center/agency_rent/R_'+ _stage+ '.jpg', func('rent_flat_oleg_strings', $args[0], _stage)
		act 'Далее': gt $curloc, 'rent_event_1', _stage+1
	elseif _stage = 2:
		gs 'zz_render', '', 'city/center/agency_rent/R_'+ _stage+ '.jpg', func('rent_flat_oleg_strings', $args[0], _stage)
		if money >= 10000:
			act 'Согласиться':
				cla
				gs 'zz_render', '', '', func('rent_flat_oleg_strings', $args[0], 3)
				act 'Ехать': gt $curloc, 'rent_event_1', _stage+3
			end
		end
		act 'Отказаться':
			cla
			gs 'zz_render', '', '', func('rent_flat_oleg_strings', $args[0], 4)
			act 'К риэлтору':
				gt 'agentned', 'start'
				killvar '_stage'
			end
		end
	elseif _stage = 5:
		gs 'zz_render', '', 'city/center/agency_rent/R_'+ _stage+ '.jpg', func('rent_flat_oleg_strings', $args[0], _stage)
		if shameless['flag'] >= 3: act 'Попросить скидку': gt $curloc, 'rent_event_1', _stage+2
		act 'Заплатить':
			*clr & cla
			money -= 10000
			gs 'stat'
			gs 'zz_render', '', 'city/center/agency_rent/R_6.jpg', func('rent_flat_oleg_strings', $args[0], 6)
			killvar '_stage'
			ArendHouseSL += 30
			housr = 1
			rent_event_oleg_flag = 1
			act 'Далее': my_house = 1 & gt'korr'
		end
	elseif _stage >= 7 and _stage < 16:
		horny += 10
		gs 'zz_render', '', 'city/center/agency_rent/R_'+ _stage+ '.gif', func('rent_flat_oleg_strings', $args[0], _stage)
		act 'Далее': gt $curloc, 'rent_event_1', _stage+1
	elseif _stage = 16:
		horny = 0
		orgasm += 1
		money -= 9000
		ArendHouseSL += 30
		gs 'zz_render', '', 'city/center/agency_rent/R_6.jpg', func('rent_flat_oleg_strings', $args[0], _stage)
		killvar '_stage'
		housr = 1
		rent_event_oleg_flag = 1
		act 'Далее': my_house = 1 & gt'korr'
	end
end
! owner ask payment
if $args[0] = 'rent_event_2':
	*clr & cla
	minut += 1
	gs 'stat'
	_stage = args[1]
	$_m_img = func('zz_funcs','get_item_string','2,,,16,17,18,13,19,20,21,14,15,22,6',_stage)
	if _stage < 1:
		gs 'zz_render', '', 'city/center/agency_rent/R_'+ $_m_img + '.jpg', func('rent_flat_oleg_strings', $args[0], _stage)
		if money >= 10000:
			act 'Заплатить':
				*clr & cla
				money -= 10000
				ArendHouseSL += 30
				gs 'zz_render', '', 'city/center/agency_rent/R_6.jpg', 'Вы отдали деньги и Олег ушел.'
				killvar '_stage'
				killvar '$_m_img'
				act 'Далее': my_house = 1 & gt'korr'
			end
			act 'Попросить скидку':
				cla
				gs 'zz_render', '', '', func('rent_flat_oleg_strings', $args[0], 1)
				act 'Далее': gt $curloc, 'rent_event_2', _stage+3
			end
		else
			act 'Попросить отсрочку':
				cla
				ask_defer_pay = 1
				gs 'zz_render', '', '', func('rent_flat_oleg_strings', $args[0], 2)
				act 'Далее': gt $curloc, 'rent_event_2', _stage+3
			end
		end
	elseif _stage >= 3 and _stage < 13:
		gs 'zz_render', '', 'city/center/agency_rent/R_'+ $_m_img + '.gif', func('rent_flat_oleg_strings', $args[0], _stage)
		act 'Далее': gt $curloc, 'rent_event_2', _stage+1
	elseif _stage = 13:
		if ask_defer_pay = 1:
			gs 'zz_render', '', '', func('rent_flat_oleg_strings', $args[0], 14)
			ArendHouseSL +=10
		else
			money -= 9000
			ArendHouseSL +=30
			gs 'zz_render', '', 'city/center/agency_rent/R_6.jpg', func('rent_flat_oleg_strings', $args[0], _stage)
		end
		gs 'stat'
		killvar '_stage'
		killvar '$_m_img'
		act 'Далее': gt'korr'
	end
end