if $ARGS[0] = 'start':
	minut += 15
	gs 'zz_render', '', '', func('podezdM_strings', 'local_str1')
	act 'Идти обнявшись':
		cla
		if harakBoyA = 0:bfA += 2
		if harakBoyA = 1:bfA += 1
		if harakBoyA = 2:bfA -= 1
		gs 'zz_render', '', 'images/pic/boygo.jpg', func('podezdM_strings', 'local_str2')
		gt'podezdM','kiosk'
	end
	act 'Идти держась за руки':
		cla
		if harakBoyA = 0:bfA += 1
		if harakBoyA = 1:bfA += 2
		if harakBoyA = 2:bfA -= 1
		gs 'zz_render', '', 'images/pic/boygo1.jpg', func('podezdM_strings', 'local_str3')
		gt'podezdM','kiosk'
	end
	act 'Идти рядом':
		cla
		if harakBoyA = 0:bfA -= 1
		if harakBoyA = 1:bfA += 1
		if harakBoyA = 2:bfA += 2
		gs 'zz_render', '', 'images/pic/boygo2.jpg', func('podezdM_strings', 'local_str4')
		gt'podezdM','kiosk'
	end
end
if $ARGS[0] = 'kiosk':
	cla
	*clr
	minut += 30
	manna += 10
	cumlip = 0
	podrand = RAND(5,100)
	gs 'zz_render', '', 'images/pic/podezdM.jpg', func('podezdM_strings', 'local_str5')
	act 'Выпить немного':
		cla
		gs 'zz_funcs', 'alko'
		gs 'stat'
		if podrand < 9:
			xgt'podezdM','kiosk1'
		else
			gt'podezdM','grup'
		end
	end
	act 'Выпить бутылку':
		cla
		gs 'zz_funcs', 'alko',2
		gs 'stat'
		if podrand < 9:
			gt'podezdM','kiosk1'
		else
			gt'podezdM','grup'
		end
	end
end
if $ARGS[0] = 'kiosk1':
	cla
	*clr
	if dayA > 15 and harakBoyA = 2:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 1:gs'boylove','tits'
	if dayA > 25 and harakBoyA = 0:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 2:gs'boylove','figure'
	if dayA > 25 and harakBoyA = 1:gs'boylove','figure'
	if dayA > 30 and harakBoyA = 0:gs'boylove','figure'
	gs'anekdot'
	gs 'zz_render', '', '', func('podezdM_strings', 'local_str6')
	act 'Смеяться':
		cla
		dom -= 1
		bfA += 1
		gt'podezdM','kiosk2'
	end
	act 'Улыбаться':
		cla
		gt'podezdM','kiosk2'
	end
	act 'Не смешно':
		cla
		DOM += 1
		bfA -= 1
		gt'podezdM','kiosk2'
	end
end
if $ARGS[0] = 'kiosk2':
	cla
	*clr
	if harakBoyA = 0 or harakBoyA = 1 or (harakBoyA = 2 and izvrat = 0):
		gs 'zz_render', '', '', func('podezdM_strings', 'local_str7')
		act 'Идти вместе с парнем до своего подъезда': gt 'sexm','start'
		exit
	elseif harakBoyA = 2 and izvrat = 1:
		if daya < 3 and boyonceA = 0:
			gs 'zz_render', '', '', func('podezdM_strings', 'local_str8')
			act 'Вырваться':
				cla
				gs 'zz_render', '', '', func('podezdM_strings', 'local_str9')
				act 'Да пошел ты!':
					cla
					DOM += 1
					bfA = 0
					gt'street'
				end
				act 'Целоваться':
					cla
					gs 'zz_render', '', '', func('podezdM_strings', 'local_str10')
					gt'sexm','startPod'
				end
			end
			act 'Целоваться':
				cla
				dom -= 1
				gs 'zz_render', '', '', func('podezdM_strings', 'local_str11')
				gt'sexm','startPod'
			end
			exit
		else
			gs 'zz_render', '', '', func('podezdM_strings', 'local_str12')
			act 'Идти вместе с парнем до своего подъезда':gt'sexm','start'
			exit
		end
	end
end
if $ARGS[0] = 'grup':
	cla
	*clr
	gs 'zz_render', '', 'images/pic/podezdM1.jpg', func('podezdM_strings', 'local_str13')
	act 'Отказаться пить':
		cla
		if harakBoyA = 0:bfA += 1
		if harakBoyA = 1:bfA -= 1
		if harakBoyA = 2:bfA -= 2
		gt'podezdM','grup1'
	end
	act 'Выпить немного':
		cla
		gs 'zz_funcs', 'alko'
		gs 'stat'
		if harakBoyA = 0:bfA += 1
		if harakBoyA = 1:bfA += 2
		if harakBoyA = 2:bfA += 1
		gt'podezdM','grup1'
	end
	act 'Бухать с парнями':
		cla
		gs 'zz_funcs', 'alko',2
		gs'stat'
		if harakBoy = 0: bfa -= 1
		if harakBoy = 1: bfA += 1
		if harakBoy = 2: bfA += 2
		gt'podezdM','grup2'
	end
end
if $ARGS[0] = 'grup1':
	cla
	*clr
	gs'stat'
	gs 'zz_render', '', '', func('podezdM_strings', 'local_str14')
	act 'Идти вместе с парнем до своего подъезда':gt'sexm','start'
end
if $ARGS[0] = 'grup2':
	cla
	*clr
	gs'stat'
	gs 'zz_render', '', '', func('podezdM_strings', 'local_str15')
	if harakBoyA = 0:
		gs 'zz_render', '', '', func('podezdM_strings', 'local_str16')
		act 'Сопротивляться':gt'sexm','gangrape'
		act 'Отдаться':gt'sexm','gangbang'
		exit
	elseif harakBoyA = 1:
		gs 'zz_render', '', '', func('podezdM_strings', 'local_str17')
		act 'Идти вместе с парнем до своего подъезда':gt'sexm','start'
		act 'Заткнись, я сама решаю с кем мне спать, идите сюда мальчики':gt'sexm','gangbang'
		exit
	elseif harakBoyA = 2 and izvrat = 0:
		gs 'zz_render', '', '', func('podezdM_strings', 'local_str18')
		act 'Идти вместе с парнем до своего подъезда':gt'sexm','start'
		act 'А может все вместе..?':gt'sexm','gangbang'
		exit
	elseif harakBoyA = 2 and izvrat = 1:
		gs 'zz_render', '', '', func('podezdM_strings', 'local_str19')
		act 'Сопротивляться':gt'sexm','gangrape'
		act 'Отдаться':gt'sexm','gangbang'
		exit
	end
end