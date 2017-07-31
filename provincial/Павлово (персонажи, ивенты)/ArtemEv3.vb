if $ARGS[0] = 'slut_talk':
	*clr & cla
	minut += RAND(10,15)
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/talk1.jpg', func('ArtemEv3_strings', '1')
	if $npc['25,qwSonya'] >= 5 and $npc['25,qwSonya'] < 50:
		gs 'zz_render', '', '', func('ArtemEv3_strings', '2')
	else
		gs 'zz_render', '', '', func('ArtemEv3_strings', '3')
	end
	gs 'zz_render', '', '', func('ArtemEv3_strings', '4')
	act 'Поцеловать':
		*clr & cla
		$npc['2,qwartem'] = 22
		minut += RAND (5,10)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/talk2.jpg', func('ArtemEv3_strings', '5')
		act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
	end
	act 'Бросить его':
		*clr & cla
		minut += RAND (5,10)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/talk3.jpg', func('ArtemEv3_strings', '6')
		act 'Уйти': minut += 5 & artemblok = 1 & gt'pod_ezd','etaj_1'
	end
end
if $ARGS[0] = 'home_start':
	*clr & cla
	cla
	gs'stat'
end