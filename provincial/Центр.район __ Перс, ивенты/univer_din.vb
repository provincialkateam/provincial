!ПОДАРОК ВИКИ НА ДЕНЬ РОЖДЕНИЯ
if $ARGS[0] = 'b_vika_present_start':
	cla
	*clr
	minut += 10
	gs'stat'
	gs 'zz_render', 'Вика Кирилова', 'images/img/centr/college/Vika/vika1.jpg"', func('univer_din_strings', 'local_str1')
	act 'Сорвать повязку':gt'univer_din','b_vika_present_1'
end
if $ARGS[0] = 'b_vika_present_1':
	cla
	*clr
	minut += 10
	horny += 20
	b_present_guys = 6
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_1.jpg"', func('univer_din_strings', 'local_str2')
	if guy < 6:
		act 'Отдаться':gt'univer_din','b_vika_present_2'
	else
		act 'Отдаться':gt'univer_din','b_vika_present_3'
	end
	act 'Наорать и уйти':gt'univer_din','b_vika_present_out'
end
if $ARGS[0] = 'b_vika_present_out':
	cla
	*clr
	minut += 10
	vika = 0
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_1.jpg"', func('univer_din_strings', 'local_str3')
	act '<B>Уйти</B>':gt'obroom','start'
end
if $ARGS[0] = 'b_vika_present_2':
	cla
	*clr
	minut += 10
	horny += 20
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_2.jpg"', func('univer_din_strings', 'local_str4')
	act 'Спуститься на колени':gt'univer_din','b_vika_present_blow'
end
if $ARGS[0] = 'b_vika_present_3':
	cla
	*clr
	minut += 10
	horny += 20
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_2.jpg"', func('univer_din_strings', 'local_str5')
	act 'Спуститься на колени':gt'univer_din','b_vika_present_blow'
end
if $ARGS[0] = 'b_vika_present_blow':
	cla
	*clr
	minut += 10
	horny += 20
	guy += 6
	bj += 6
	gang += 1
	hj += 6
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_blow'+rand(1,4)+'.jpg"', func('univer_din_strings', 'local_str6')
	act 'Сосать':gt'univer_din','b_vika_present_blow1'
end
if $ARGS[0] = 'b_vika_present_blow1':
	cla
	*clr
	minut += 10
	horny += 20
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_blow'+rand(1,4)+'.jpg"', func('univer_din_strings', 'local_str7')
	act 'Сосать':gt'univer_din','b_vika_present_blow1'
	act 'Дальше':gt'univer_din','b_vika_present_sex1'
end
if $ARGS[0] = 'b_vika_present_sex1':
	cla
	*clr
	minut += 10
	horny += 20
	anal += 6
	gs'stat'
	if mop > 1: mop = 0 & vidageday -= 1
	if anus > 15:
		'<center><img src="images/img/centr/college/Vika/b_present_sex2.jpg" ></center>'
	else
		anus + 1
		'<center><img src="images/img/centr/college/Vika/b_present_sex1.jpg" ></center>'
	end
	gs 'zz_render', '', '', func('univer_din_strings', 'local_str8')
	if lubri = 0:
		lubonus = 2
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str9')
	elseif lubri > 0:
		lubri -= 1
		lubonus = 10
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str10')
	end
	if anus > 15:
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str11')
	elseif anus <= 15:
		agape += 2
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str12')
	end
	gs 'zz_render', '', '', func('univer_din_strings', 'local_str13')
	act 'Возьмите меня все сразу':gt'univer_din','b_vika_present_sex2'
end
if $ARGS[0] = 'b_vika_present_sex2':
	cla
	*clr
	minut += 10
	horny += 20
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_dp'+rand(1,8)+'.jpg"', func('univer_din_strings', 'local_str14')
	act 'Дальше':gt 'univer_din', 'b_vika_present_sex2'
	$zz_str = 'Долго орать не получается, во - первых, члены начинают в вас двигаться, а их руки вынуждают активно подмахивать, во - вторых к вам в рот отправляется третий фаллос.<br>'
	$zz_str += 'Вас жестко трахают во все дыры. Парни часто меняются местами и со временем их члены преобретают вкус ваших собственных соков.'
	if picrand => 1 and picrand <= 2:
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str15')
		gs 'zz_render','','', $zz_str
	elseif picrand => 3 and picrand <= 4:
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str16')
		gs 'zz_render','','', $zz_str
	elseif picrand = 5:
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str17')
		gs 'zz_render','','', $zz_str
	elseif picrand => 6 and picrand <= 8:
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str18')
	end
	killvar '$zz_str'
	b_present_cum = rand (0,1)
	if b_present_cum = 1:
		b_present_ass_or_vag = rand (1,2)
		if b_present_ass_or_vag = 1:
			b_present_guys -= 1
			gs 'zz_render', '', '', func('univer_din_strings', 'local_str19')
			gs 'zz_funcs', 'cum', 'pussy'
		elseif b_present_ass_or_vag = 2:
			b_present_guys -= 1
			gs 'zz_funcs', 'cum', 'anus'
			gs 'zz_render', '', '', func('univer_din_strings', 'local_str20')
		end
	end
	if b_present_guys = 2:
		cla
		gs 'zz_render', '', '', func('univer_din_strings', 'local_str21')
		act 'Попросить кончить на лицо': gt'univer_din', 'b_vika_present_cum'
	end
end
if $ARGS[0] = 'b_vika_present_cum':
	cla
	*clr
	manna += 10
	minut += 10
	horny = 0
	orgasm += 1
	analorgasm += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'stat'
	gs 'zz_render', '', 'images/img/centr/college/Vika/b_present_cum.jpg"', func('univer_din_strings', 'local_str22')
	act '<B>Уйти</B>':gt'obroom','start'
end