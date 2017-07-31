minut += 60
i = RAND(0,3)
if i = 0:
	gs 'zz_render', '', '', func('brosh_strings', 'local_str1')
	act 'Идти за школу':
		*clr & cla
		gs 'zz_render', '', '', func('brosh_strings', 'local_str2')
		act 'Отсосать Жендосу':
			*clr & cla
			bj += 1
			dom -= 1
			gs 'zz_render', '', 'images/qwest/alter/ev2/bs.jpg', func('brosh_strings', 'local_str3')
			act 'Сосать':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				swallow += 1
				gs 'zz_render', '', 'images/qwest/alter/ev2/bscum.jpg', func('brosh_strings', 'local_str4')
				act 'Отойти': gt 'gschool'
			end
		end
	end
	exit
elseif i = 1:
	gs 'zz_render', '', '', func('brosh_strings', 'local_str5')
	act 'Идти за школу':
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', '', func('brosh_strings', 'local_str6')
		act 'Отсосать Мишане':
			*clr & cla
			bj += 1
			dom -= 1
			gs 'zz_render', '', 'images/qwest/alter/ev2/bs1.jpg', func('brosh_strings', 'local_str7')
			act 'Сосать':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				swallow += 1
				gs 'zz_render', '', 'images/qwest/alter/ev2/bscum1.jpg', func('brosh_strings', 'local_str8')
				act 'Отойти': gt 'gschool'
			end
		end
	end
	exit
elseif i = 3:
	gs 'zz_render', '', '', func('brosh_strings', 'local_str9')
	act 'Идти за школу':
		*clr & cla
		gs 'zz_render', '', '', func('brosh_strings', 'local_str10')
		act 'Отсосать Парням':
			*clr & cla
			gang += 1
			bj += 2
			dom -= 1
			gs 'zz_funcs', 'cum', 'lip'
			swallow += 1
			gs 'zz_render', '', 'images/qwest/alter/ev2/bs2.jpg', func('brosh_strings', 'local_str11')
			act 'Отойти': gt 'gschool'
		end
	end
	exit
end