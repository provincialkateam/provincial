gs'stat'
if $npc['2,qwartem'] = 1:
	gs 'zz_render', '', 'images/qwest/alter/artom/flowers.jpg', func('artemev2_strings', '1')
	act 'Взять':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/flowers_take.jpg', func('artemev2_strings', '2')
		act 'Остановить его':
			*clr & cla
			minut += 5
			$npc['2,qwartem'] = 2
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemev2_strings', '3')
			dynamic $din_artom_lern
		end
		act 'Наслаждаться и ободрить его':
			*clr & cla
			minut += 5
			horny += 20
			$npc['2,qwartem'] = 3
			hj += 1
			hja += 1
			if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/cum.jpg', func('artemev2_strings', '4')
			dynamic $din_artom_lern
		end
	end
	act 'Не брать':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemev2_strings', '5')
		act 'Подбежать и забрать их из мусорки':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/flowers_take.jpg', func('artemev2_strings', '6')
			act 'Остановить его':
				*clr & cla
				minut += 5
				$npc['2,qwartem'] = 2
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemev2_strings', '7')
				dynamic $din_artom_lern
			end
			act 'Наслаждаться и ободрить его':
				*clr & cla
				minut += 5
				horny += 20
				$npc['2,qwartem'] = 3
				hj += 1
				hja += 1
				if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/cum.jpg', func('artemev2_strings', '8')
				dynamic $din_artom_lern
			end
		end
		act 'Оставить все как есть':
			*clr & cla
			minut += 5
			$npc['2,qwartem'] = 4
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemev2_strings', '9')
			dynamic $din_artom_lern
		end
	end
elseif $npc['2,qwartem'] = 10:
	minut += 30
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/date.jpg', func('artemev2_strings', '10')
	act 'Остановить его':
		*clr & cla
		minut += 5
		if $npc['2,qwartem'] = 2:$npc['2,qwartem'] = 4
		if $npc['2,qwartem'] = 3:artemtimes = 20
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemev2_strings', '11')
		act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
	end
	act 'Наслаждаться':
		*clr & cla
		minut += 5
		bj += 1
		bja += 1
		if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
		$npc['2,qwartem'] = 20
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/bj.jpg', func('artemev2_strings', '12')
		act 'Отдаться':
			*clr & cla
			minut += 5
			sexa += 1
			pose = 0
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/sex.jpg', func('artemev2_strings', '13')
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			if $npc['2,qwSex'] = 0:
				$npc['2,qwSex'] = 1
				gs 'zz_render', '', '', func('artemev2_strings', '14')
			end
			act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
		end
		act 'Продолжать сосать':
			*clr & cla
			minut += 5
			horny = 0
			orgasm += 1
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/bjcum.jpg', func('artemev2_strings', '15')
			act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
		end
	end
end