if $ARGS[0] = 'start':
	if arturKnow = 0:
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturRinok_strings', 'local_str1')
		act 'Взять мандаринку':
			cla
			gs 'zz_render', '', '', func('arturRinok_strings', 'local_str2')
			act 'Отказываться':
				cla
				gs 'zz_render', '', '', func('arturRinok_strings', 'local_str3')
				act 'Уйти': gt 'grinok'
				act 'Заинтересоваться':
					cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', '', func('arturRinok_strings', 'local_str4')
					act 'Уйти': gt 'grinok'
					act 'Идти с Артуром': gt 'artur_events'
				end
			end
		end
	else
		if arturday ! day:
			if rand(1,2) = 1:
				gt 'arturQW','arturQW_1'
			else
				*clr & cla
				minut += 5
				gs 'zz_render','','images/qwest/alter/artur/artur.jpg', '', func('arturRinok_strings', 'local_str5')
				act 'Идти с Артуром': gt 'artur_events', 'suck_behind_kiosk'
			end
		else
			*clr & cla
			minut += 5
			gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturRinok_strings', 'local_str6')
			act 'Уйти': gt 'grinok'
		end
	end
	act 'Уйти': gt 'grinok'
end
if $ARGS[0] = 'work_1':
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturRinok_strings', 'local_str7')
	act 'Торговать':
		*clr & cla
		trade_start = hour
		trade_end = 18 - trade_start
		minut += trade_end*60
		arturDaysWorked1 += 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_3.jpg', func('arturRinok_strings', 'local_str8')
		if arturDaysWorked1 >= 10 and intel >= 80:
			gt 'arturQW', 'arturQW_2'
		else
			act 'Идти к Артуру':
				*clr & cla
				minut += 5
				money += 1000
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_4.jpg', func('arturRinok_strings', 'local_str9')
				temp = rand(1,3)
				if temp = 1:
					gs 'zz_render', '', '', func('arturRinok_strings', 'local_str10')
					act 'Идти с Артуром': gt 'artur_events'
				elseif temp = 2:
					gs 'zz_render', '', '', func('arturRinok_strings', 'local_str11')
					act 'Идти с Артуром': gt 'artur_events', 'suck_behind_kiosk'
				else
					act 'Уйти': gt 'grinok'
				end
			end
		end
	end
end
if $ARGS[0] = 'work_2':
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturRinok_strings', 'local_str1'+iif(arturDaysWorked2 = 0,'6',iif(artur_absence = 1,'7','8')))
	if artur_absence <= 1:
		act 'Работать':
			*clr & cla
			minut += 120
			arturDaysWorked2 += 1
			artur_absence = 0
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_6.jpg', func('arturRinok_strings', 'local_str12')
			act 'Идти к Артуру':
				*clr & cla
				minut += 5
				money += 2000
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_7', func('arturRinok_strings', 'local_str13')
				if rand(1,3) = 1:
					gs 'zz_render', '', '', func('arturRinok_strings', 'local_str14')
					act 'Идти с Артуром': gt 'artur_events'
				else
					act 'Уйти': gt 'grinok'
				end
			end
		end
		if arturDaysWorked2 > 0:
			act 'Уволиться':
				*clr & cla
				minut += 10
				arturDaysWorked2 = 0
				$npc['40,qwArtur'] = 3
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturRinok_strings', 'local_str15')
				act 'Идти с Артуром': gt 'artur_events'
				act 'Уйти': gt 'grinok'
			end
		end
	else
		act 'Уйти': $npc['40,qwArtur'] = 4 & arturDaysWorked2 = 0 & artur_absence = 0 & gt 'grinok'
	end
end