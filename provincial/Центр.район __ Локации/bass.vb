if $ARGS[0] = 'start':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Бассейн</font></b></center>'
	'<center><img src="images/pic/bass.jpg"></center>'
	'Вход в бассейн стоит 300 рублей'
	act 'Выйти':minut += 5 & gt 'down'
	if db >= 1 and Goraday ! day: act 'Искать Жору':Goraday = day & gt'klofdomhouse','ev42'
	if money >= 300:
		act 'Заплатить 300 руб за 1 час в бассейне':
			cla
			minut += 5
			money -= 300
			gt'bass','a'
		end
	end
end
if $ARGS[0] = 'a':
	cla
	*clr
	minut += 5
	'<center><b><font color = maroon>Бассейн</font></b></center>'
	'<center><img src="images/pic/bass.jpg"></center>'
	act 'Купаться 1 час':
		cla
		*clr
		gs 'zz_bathroom', 'shower'
		minut += 45
		if stren < 40: stren += 1
		'<center><img src="images/pics/swim.jpg"></center>'
		'Вы искупались в бассейне, вода освежает и бодрит.'
		act 'Выйти из воды':gt'bass','start'
	end
	act 'Выйти':gt'bass','start'
end