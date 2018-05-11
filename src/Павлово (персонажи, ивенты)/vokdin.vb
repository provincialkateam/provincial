if $args[0] = 'vokzalg_kabinet':
	*clr & cla
	gs 'zz_render','','images/wannabe/vokzal_nach.jpg',func('vokdin_strings', 'local_str1')
	act 'Уйти': minut += 1 & gt 'vokzalGin'
	if vokzalVork = 0:
		act 'Устроиться уборщицей':
			cla
			vokzalVork = 1
			minut += 15
			gs 'stat'
			gs 'zz_render', '', '',func('vokdin_strings', 'local_str'+iif(DrunkGirl_end = 0,2,3))
			act 'Уйти': minut += 1 & gt 'vokzalGin'
		end
	end
end
if $args[0] = 'vokzalg_toilet_f':
	*clr & cla
	$loc = $curloc
	$metka = $args[0]
	gs 'zz_render', 'Женский туалет', 'images/pic/PublicToilet.jpg', func('vokdin_strings', 'local_str10')
	act 'Уйти': minut += 1 & gt 'vokzalGin'
	gs 'zz_toilet', 'actions'
end
if $args[0] = 'vokazalg_podbros2':
	*clr & cla
	gs 'zz_render', 'Вокзал', 'images/qwest/alter/vokzal.jpg', func('vokdin_strings', 'local_str12')
	act 'Вернуть деньги':
		money = 0
		podbros = 1
		gs 'stat'
		gs 'zz_render', '', '', func('vokdin_strings', 'local_str13')
		act 'Уйти': minut += 1 & gt 'vokzalGin'
	end
end
if $args[0] = 'vokazalg_podbros':
	*clr & cla
	gs 'zz_render', 'Вокзал', 'images/qwest/alter/vokzal.jpg', func('vokdin_strings', 'local_str14')
	act 'Уйти с кошельком':
		cla
		gs 'zz_render', '', '', func('vokdin_strings', 'local_str15')
		act 'Показать деньги': gt 'vokdin','vokazalg_podbros2'
	end
	act 'Отдать кошелек и уйти': minut += 1 & gt'vokzalGin'
	act 'Отойти в сторону и поделить деньги':
		cla
		gs 'zz_render', '', '', func('vokdin_strings', 'local_str16')
		act 'Показать деньги': gt 'vokdin','vokazalg_podbros2'
	end
end