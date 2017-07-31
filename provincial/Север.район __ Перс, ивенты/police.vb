if $ARGS[0] = '1':
	gopstop = 0
	minut += 60
	gs'stat'
	'<center><b>Отделение полиции</b></center>'
	gs 'zz_render', '', 'images/img/police/a1.jpg', func('police_strings', 'local_str1')
	act 'Упираться':
		cla
		*clr
		minut += 60
		anal += 1
		guy += 1
		gs 'zz_funcs', 'cum', 'anus'
		gs 'zz_render', '', 'images/img/police/a2.jpg', func('police_strings', 'local_str2')
		act 'Отказаться':
			cla
			*clr
			gs 'zz_render', '', 'images/img/police/a3.jpg', func('police_strings', 'local_str3')
			act 'В камеру':gt'kamera'
		end
	end
	act 'Рассказать':
		cla
		gopdeath = 1
		minut += 180
		vsehsdaladay = day
		gs'stat'
		gs 'zz_render', '', '', func('police_strings', 'local_str4')
		act 'Уйти':gt'nord'
	end
end