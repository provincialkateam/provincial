﻿if $ARGS[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','','images/pic/podezdhr.jpg'
	act 'Выйти':
		cla
		minut += 5
		gt'south'
	end
	act 'Позвонить в дверь Ирине':
		cla
		if hour >= 16 and hour <= 21 and week >= 6 and $npc['44,qwIrina'] ! 2:
			gs 'zz_render', '', '', func('IrinaRoom_strings', 'local_str1')
			act 'Пройти в квартиру':gt'IrinaRoom','first'
		else
			gs 'zz_render', '', '', func('IrinaRoom_strings', 'local_str2')
			act 'Выйти':
				cla
				minut += 5
				gt'south'
			end
		end
	end
end
if $ARGS[0] = 'first':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/pic/IrinaRoom.jpg', func('IrinaRoom_strings', 'local_str3')
	act 'Выпивать на кухне':gt'IrinaRoom','first1'
end
if $ARGS[0] = 'first1':
	*clr & cla
	minut += 60
	manna += 10
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW.jpg', func('IrinaRoom_strings', 'local_str4')
	act 'Уйти':
		cla
		minut += 60
		manna += 10
		gt'south'
	end
	if $npc['44,qwIrina'] = 1:
		act 'Предложить выпить на брудершафт':gt'IrinaRoom','first2'
	end
	if $npc['44,qwIrina'] >= 10:
		act 'Целоваться':gt'IrinaRoom','kiss'
	end
end
if $ARGS[0] = 'kiss':
	*clr & cla
	minut += 10
	manna += 10
	horny += 20
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaKiss.jpg', func('IrinaRoom_strings', 'local_str5')
	act 'Секс':gt'IrinaRoom','sex'
end
if $ARGS[0] = 'sex':
	*clr & cla
	minut += 60
	manna += 10
	lesbian += 1
	manna += 10
	gs 'stat'
	gs 'zz_render','','images/picVA/IrinaSex.jpg'
	if horny < 50:
		horny -= 10
		gs 'zz_render', '', '', func('IrinaRoom_strings', 'local_str6')
	end
	if horny >= 50:
		horny = 0
		orgasm += 1
		gs 'zz_render', '', '', func('IrinaRoom_strings', 'local_str7')
	end
	act 'Выйти':
		cla
		minut += 5
		gt'south'
	end
end
if $ARGS[0] = 'first2':
	*clr & cla
	minut += 60
	manna += 10
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW1.jpg', func('IrinaRoom_strings', 'local_str8')
	act 'Поцеловать':gt'IrinaRoom','first3'
end
if $ARGS[0] = 'first3':
	*clr & cla
	manna += 10
	horny += 20
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW2.jpg', func('IrinaRoom_strings', 'local_str9')
	act 'Раздеть Иру':gt'IrinaRoom','first4'
	act 'Поить Иру дальше':gt'IrinaRoom','first5'
end
if $ARGS[0] = 'first4':
	*clr & cla
	$npc['44,qwIrina'] = 2
	gs 'stat'
	gs 'zz_render', '', '', func('IrinaRoom_strings', 'local_str10')
	act 'Выйти':
		cla
		minut += 5
		gt'south'
	end
end
if $ARGS[0] = 'first5':
	*clr & cla
	$npc['44,qwIrina'] = 10
	horny += 20
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW3.jpg', func('IrinaRoom_strings', 'local_str11')
	act 'Целовать':gt'IrinaRoom','first6'
end
if $ARGS[0] = 'first6':
	*clr & cla
	horny += 20
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW4.jpg', func('IrinaRoom_strings', 'local_str12')
	act 'Ласкать грудь':gt'IrinaRoom','first7'
end
if $ARGS[0] = 'first7':
	*clr & cla
	horny += 20
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW5.jpg', func('IrinaRoom_strings', 'local_str13')
	act 'Лизать киску':gt'IrinaRoom','first8'
end
if $ARGS[0] = 'first8':
	*clr & cla
	horny += 20
	girl = girl + 1
	lesbian += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW6.jpg', func('IrinaRoom_strings', 'local_str14')
	act 'Лизать киску':gt'IrinaRoom','first9'
end
if $ARGS[0] = 'first9':
	*clr & cla
	horny = 0
	orgasm += 1
	manna += 10
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/IrinaQW7.jpg', func('IrinaRoom_strings', 'local_str15')
	act 'Выйти':
		cla
		minut += 5
		gt'south'
	end
end