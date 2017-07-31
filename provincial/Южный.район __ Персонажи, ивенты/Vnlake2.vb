gs 'zz_render', '', 'images/img/Lake/Vnlake2/vnlake1.jpg', func('Vnlake2_strings', 'local_str1')
act 'Оттолкнуть их':gt'Nudelake'
act 'Коснуться члена':
	cla
	*clr
	guy += 2
	bj += 1
	gs 'zz_render', '', 'images/img/Lake/Vnlake2/vnlake2.jpg', func('Vnlake2_strings', 'local_str2')
	act 'Встать на карачки':
		cla
		*clr
		sex += 1
		gs 'zz_render', '', 'images/img/Lake/Vnlake2/vnlake3.jpg', func('Vnlake2_strings', 'local_str3')
		act 'Сменить позу':
			cla
			*clr
			anal += 1
			orgasm += 3
			gs 'zz_render', '', 'images/img/Lake/Vnlake2/vnlake4.jpg', func('Vnlake2_strings', 'local_str4')
			act 'Пересесть':
				cla
				*clr
				gs 'zz_funcs', 'cum', 'ass'
				gs 'zz_render', '', 'images/img/Lake/Vnlake2/vnlake5.jpg', func('Vnlake2_strings', 'local_str5')
				act 'Вынуть изо рта':
					cla
					*clr
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/img/Lake/Vnlake2/vnlake6.jpg', func('Vnlake2_strings', 'local_str6')
					act 'Остаться на пляже':gt'Nudelake'
				end
			end
		end
	end
end