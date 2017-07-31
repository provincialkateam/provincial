gs 'zz_funcs', 'alko', 5
gs 'stat'
gs 'zz_render', '', '', func('placer_house_one_strings', 'local_str1')
if rand(0,1) = 0:
	gs 'zz_render', '', '', func('placer_house_one_strings', 'local_str2')
	act 'Целоваться с парнем':
		*clr & cla
		horny += 10
		gs'stat'
		gs 'zz_render', '', '', func('placer_house_one_strings', 'local_str3')
		act 'Сесть на корточки':
			*clr & cla
			horny += 10
			guy += 1
			bj += 1
			minut += 15
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/placer/bjdan.jpg', func('placer_house_one_strings', 'local_str4')
			act 'Обхватить губами':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/placer/cum.jpg', func('placer_house_one_strings', 'local_str5')
				act 'Проглотить':
					*clr & cla
					swallow += 1
					vaf += 1
					dom -= 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/placer/swallow.jpg', func('placer_house_one_strings', 'local_str6')
					act 'Обсосать до суха':
						*clr & cla
						vaf += 1
						dom -= 1
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/placer/clean.jpg', func('placer_house_one_strings', 'local_str7')
						act 'Уйти': gt 'gorodok'
					end
				end
				act 'Выплюнуть':
					*clr & cla
					swallow += 1
					dom += 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/placer/bjdan.jpg', func('placer_house_one_strings', 'local_str8')
					act 'Уйти': gt 'gorodok'
				end
			end
		end
	end
end