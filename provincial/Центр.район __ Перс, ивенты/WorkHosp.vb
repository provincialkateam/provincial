if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	gs 'stat'
	gs 'zz_render', 'Поликлиника', 'images/img/spaln/hospital.jpg', func('WorkHosp_strings', 'local_str1')
	jobhosprand = RAND(0,9)
	act 'Работать в процедурной':
		cla
		minut += 60
		if jobhosprand = 0: gt'WorkHosp','2'
		gs 'zz_render', '', '', func('WorkHosp_strings', 'local_str2')
		act 'Отойти': gt'WorkHosp','start'
	end
	act 'Помогать врачу на приеме':
		cla
		minut += 60
		if jobhosprand = 0: gt'WorkHosp','3'
		gs 'zz_render', '', '', func('WorkHosp_strings', 'local_str3')
		act 'Отойти': gt'WorkHosp','start'
	end
	act 'Отдохнуть в сестринской':
		cla
		minut += 30
		gs 'zz_render', '', '', func('WorkHosp_strings', 'local_str4')
		act 'Мастурбировать 15 мин':
			minut += 15
			if RAND(0,2) = 0:
				gt 'WorkHosp','1'
			else
				*clr & cla
				mastr += 1
				horny = 0
				orgasm += 1
				gs 'zz_render', '', '', func('WorkHosp_strings', 'local_str5')
			end
			act 'Выйти': gt 'WorkHosp', 'start'
		end
		act 'Отойти': gt 'WorkHosp', 'start'
	end
	act 'Есть в кафетерии':
		*clr & cla
		gs 'zz_kitchen_acts', 'eat'
		gs 'zz_kitchen_acts', 'drink', 'tea'
		gs 'stat'
		act 'Отойти': gt 'WorkHosp', 'start'
	end
	act 'Болтать с Катей':
		cla
		minut += 30
		gs 'npc_editor','change_rep','+', 33
		gs 'zz_render', '', '', func('WorkHosp_strings', 'local_str6')
		if $npc['33,relation'] > 60: act 'Предложить уединиться': gt'WorkHosp','0'
		act 'Отойти': gt'WorkHosp', 'start'
	end
	if hour >= 16:
		*clr & cla
		gs 'zz_render', 'Поликлиника', 'images/img/spaln/hospital.jpg', func('WorkHosp_strings', 'local_str7')
		act 'Идти домой':gt'street'
	end
end
if $ARGS[0] = '0':
	*clr & cla
	katprorand = RAND(0,2)
	if katprorand = 0:
		girl += 1
		lesbian += 1
		picrand = 11
		xgt 'lezbsex','var'
	elseif katprorand = 1:
		gs 'zz_render', '', 'images/img/spaln/hospsex7.jpg', func('WorkHosp_strings', 'local_str9')
		act 'Выйти':gt'WorkHosp','start'
		act 'Развлечься':
			girl += 1
			guy += 1
			lesbian += 1
			picrand = 12
			gt'podrsex','var'
		end
	else
		gs 'zz_render', '', 'images/img/spaln/hospsex8.jpg', func('WorkHosp_strings', 'local_str10')
		act 'Развлекаться':
			gang += 1
			picrand = 11
			xgt'sexdvanadva','var'
		end
	end
end
if $ARGS[0] = '1':
	*clr & cla
	if RAND(0,1) = 0:
		gs 'zz_render', '', 'images/img/spaln/hospsex9.jpg', func('WorkHosp_strings', 'local_str11')
		if horny < 50:act 'Вырваться и убежать':gt'WorkHosp','start'
		act 'Развлечься':
			guy += 1
			picrand = 12
			gt'sex','minet'
		end
	else
		picrand = RAND(12,13)
		gs 'zz_render', '', 'images/img/spaln/hospsex10.jpg', func('WorkHosp_strings', 'local_str12')
		if horny < 50: act 'Убежать': gt'WorkHosp','start'
		act 'Развлечься':guy += 2 & xgt'sexdvoe','var'
	end
end
if $ARGS[0] = '2':
	*clr & cla
	picrand = RAND(13,15)
	gs 'zz_render', '', 'images/img/spaln/hospsex11.jpg', func('WorkHosp_strings', 'local_str13')
	act 'Выгнать его': gt 'WorkHosp','start'
	act 'Поднять': guy += 1 & gt 'sex','minet'
end
if $ARGS[0] = '3':
	*clr & cla
	gs 'zz_render', '', 'images/img/spaln/hospsex12.jpg', func('WorkHosp_strings', 'local_str14')
	act 'Сделать ей замечание':gt'WorkHosp','start'
	act 'Развлечься':
		guy += 1
		girl += 1
		lesbian += 1
		picrand = 13
		gt 'podrsex','var'
	end
end