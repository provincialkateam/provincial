if $args[0] = '': $args[0] = 'arturQW_1'
if $ARGS[0] = 'arturQW_1':
	if $npc['40,sex'] >= 5 and func('zz_reputation','get') = 0 and vnesh >= 60:
		*clr & cla
		minut += 2
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturQW_strings', 'local_str1')
		act 'Согласиться':
			*clr & cla
			minut += 2
			$npc['40,qwArtur'] = 1
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_1.jpg', func('arturQW_strings', 'local_str2')
			act 'Идти с Артуром': gt 'artur_events'
			act 'Уйти': gt 'grinok'
		end
		act 'Отказаться':
			*clr & cla
			minut += 2
			$npc['40,qwArtur'] = 3
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_2.jpg', func('arturQW_strings', 'local_str3')
			act 'Идти с Артуром': gt 'artur_events'
			act 'Уйти': gt 'grinok'
		end
	else
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturQW_strings', 'local_str4')
		act 'Идти с Артуром': gt 'artur_events'
		act 'Уйти': gt 'grinok'
	end
end
if $ARGS[0] = 'arturQW_2':
	*clr & cla
	minut += 10
	money += 5000
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artur/artur.jpg', func('arturQW_strings', 'local_str5')
	act 'Согласиться':
		*clr & cla
		minut += 5
		$npc['40,qwArtur'] = 2
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_5.jpg', func('arturQW_strings', 'local_str6')
		act 'Идти с Артуром': gt 'artur_events'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		$npc['40,qwArtur'] = 3
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/arturQW/arturQW_2.jpg', func('arturQW_strings', 'local_str7')
		act 'Идти с Артуром': gt 'artur_events'
		act 'Уйти': gt 'grinok'
	end
end