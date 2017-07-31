if $ARGS[0] = 'start':
	cla
	*clr
	! mennolds ev
	if hour = 21 and minut < 30 and $npc['45,qwTamara'] = 6:
		gs 'mey_tamara_events', 'wait_qw'
		exit
	end
	! ---
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Ресторан','images/pic/restoran.jpg'
	if func('zz_clothing','is_glamour') >= 1 and mop > 1 and sweat <= 0:
		gs 'zz_render', '', '', func('restoran_strings', 'local_str1')
		if money >= 10000: act 'VIP зал': gt'restoran','vip'
		act 'Общий зал':gt'restoran','zal'
	else
		gs 'zz_render', '', '', func('restoran_strings', 'local_str2')
	end
	act 'Выйти из Ресторана':
		cla
		minut += 5
		gt'down'
	end
	if vladimirday = day and vladimirQW = 21 and hour = 20:gt'qwmeet'
end
if $ARGS[0] = 'zal':
	cla
	*clr
	minut += 5
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ресторан, общий зал', 'images/pic/restoran2.jpg', func('restoran_strings', 'local_str3')
	!etogame
	if RAND(0,100) > 80 and $npc['0,qwNastya'] = 0 and energy > 15 and nastjaday ! day:
		*clr & cla
		nastjaday = day
		gs'stat'
		gs 'zz_render', '', 'images/etogame/nastja1.jpg', func('restoran_strings', 'local_str4')
		act 'Опустить глаза':
			cla
			gs 'zz_render', '', '', func('restoran_strings', 'local_str5')
			act 'Уйти':gt'restoran','zal'
		end
		act 'Улыбнуться ей':gt'nastja','pos1'
	end
	if money >= 5000:
		act 'Поесть (5 тыс.руб)':
			cla
			minut += 60
			energy = 22
			body['day_weight'] += 1
			water = 22
			manna += 30
			health += 20
			money -= 5000
			gs 'stat'
			gs 'zz_render', '', '', func('restoran_strings', 'local_str6')
			act 'Уйти':gt'restoran','zal'
		end
	end
	act 'Уйти':minut += 5 & gt'restoran','start'
end
if $ARGS[0] = 'vip':
	cla
	*clr
	minut += 5
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ресторан, VIP зал', 'images/pic/restoran3.jpg', func('restoran_strings', 'local_str7')
	act 'Поесть (10 тыс.руб)':
		cla
		minut += 60
		energy = 24
		water = 24
		manna = 100
		health += 30
		money -= 10000
		gs'stat'
		gs 'zz_render', '', '', func('restoran_strings', 'local_str8')
		act 'Уйти':gt'restoran','vip'
	end
	act 'Уйти':
		cla
		minut += 5
		gt'restoran','start'
	end
end