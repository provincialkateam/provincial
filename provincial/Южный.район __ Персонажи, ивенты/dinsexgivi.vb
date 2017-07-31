$threesomedin = {
	act 'Сесть на член':
		*clr & cla
		minut += 5
		pose = 2
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/threeC'+RAND(1,2)+'.jpg', func('dinsexgivi_strings', 'local_str1')
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		dynamic $giviirasexdivibor2
	end
	dynamic $threesomedin2
}
$threesomedin2 = {
	act 'Целоваться дальше':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/threeC'+RAND(1,2)+'.jpg', func('dinsexgivi_strings', 'local_str2')
		dynamic $giviirasexdivibor
	end
}
$giviirasexdivibor = {
	!выбор ГГ
	act 'Лизать грудь Иры':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/threeD'+RAND(0,1)+'.jpg', func('dinsexgivi_strings', 'local_str3')
		dynamic $giviirasexdivibor3
	end
	act 'Подставить киску Ире':
		*clr & cla
		minut += 5
		horny += 20
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/threeE.jpg', func('dinsexgivi_strings', 'local_str4')
		if horny >= 90: horny = 0 & orgasm += 1 & 'Вас охватил оргазм и вы застонали от наслаждения.'
		gs 'zz_render', '', '', func('dinsexgivi_strings', 'local_str5')
		dynamic $giviirasexdivibor3
	end
}
$giviirasexdivibor2 = {
	!выбор Иры
	act 'Прыгать на члене':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		picrand = RAND(1,2)
		if RAND(0,1) = 0:
			gs 'zz_render', '', 'images/picKav/threeF.jpg', func('dinsexgivi_strings', 'local_str6')
		else
			gs 'zz_render', '', 'images/picKav/threeF1.jpg', func('dinsexgivi_strings', 'local_str7')
		end
		gs 'zz_render', '', '', func('dinsexgivi_strings', 'local_str8')
		dynamic $giviirasexdivibor3
	end
}
$giviirasexdivibor3 = {
	!выбор Иры
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 10
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_funcs', 'cum', 'face'
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/threeFin.jpg', func('dinsexgivi_strings', 'local_str9')
		act 'Уйти': dynamic $endirinaaftergang
	end
}
$endirinaaftergang = {
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('dinsexgivi_strings', 'local_str10')
	act 'Уйти': gt'street'
}