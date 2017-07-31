if $ARGS[0] = '1':
	cla
	*clr
	dyadyamishaevent = 1
	dick = 18
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', '', '', func('gevent_strings', 'local_str1')
	gs 'zz_render', '', 'images/gevent/1.jpg', func('gevent_strings', 'local_str2')
	act 'Лечь на кровать':
		cla
		*clr
		gs 'zz_render', '', '', func('gevent_strings', 'local_str3')
		if vagina = 0 and sex = 0:
			gs 'zz_render', '', '', func('gevent_strings', 'local_str4')
			gs 'zz_render', '', 'images/gevent/mishasex1.jpg', func('gevent_strings', 'local_str5')
		else
			gs 'zz_render', '', '', func('gevent_strings', 'local_str6')
			gs 'zz_render', '', 'images/gevent/mishasex1.jpg', func('gevent_strings', 'local_str7')
			if dick - vagina > 10 and dick - vagina <= 7:'Вам было очень больно и вы молились, чтобы это быстрее закончилось'
			if dick - vagina > 6 and dick - vagina <= 3:'Вам было больно и неприятно'
			gs 'zz_render', '', '', func('gevent_strings', 'local_str8')
		end
		act 'Глотать':
			cla
			*clr
			sex += 1
			bj += 1
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			throat += 1
			if vagina < dick:vagina += 1
			rape += 1
			minut += 75
			money += 500
			gs'stat'
			gs 'zz_render', '', 'images/gevent/mishasex2.jpg', func('gevent_strings', 'local_str9')
			act 'Уйти':gt'gorodok'
		end
	end
end
if $ARGS[0] = '5':
	cla
	*clr
	guy += 1
	sex += 1
	vagina += 1
	cumass = 1
	minut += 15
	money += 500
	gs 'stat'
	gs 'zz_render', '', 'images/gevent/5.jpg', func('gevent_strings', 'local_str10')
	act 'Уйти':gt'gorodok'
end