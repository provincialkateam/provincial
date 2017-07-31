if bobrand = 0:
	minut += 5
	bj += 1
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs'stat'
	dynamic $venerasiak
	gs 'zz_render', '', 'images/qwest/sosed/bj.jpg', func('bobka_strings', 'local_str1')
	act 'Ширнуться':
		*clr & cla
		minut += 5
		StrongNarkota += 25
		SNarkTimes += 1
		NarkShmaraTimes += 1
		gs'stat'
		gs 'zz_render', '', '', func('bobka_strings', 'local_str2')
		act 'Уйти':minut += 15 & dynamic $snkayf1
	end
elseif bobrand = 1:
	minut += 5
	bj += 1
	gs'stat'
	dynamic $venerasiak
	gs 'zz_render', '', 'images/qwest/sosed/bj.jpg', func('bobka_strings', 'local_str3')
	act 'Встать раком':
		*clr & cla
		minut += 5
		sex += 1
		$boy = 'Бобка'
		dick = 16
		silavag = 1
		pose = 1
		gs'stat'
		'<center><img src="images/qwest/sosed/doggy.jpg"></center>'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Ширнуться':
			*clr & cla
			minut += 5
			StrongNarkota += 25
			SNarkTimes += 1
			NarkShmaraTimes += 1
			gs'stat'
			gs 'zz_render', '', '', func('bobka_strings', 'local_str4')
			act 'Уйти':minut += 15 & dynamic $snkayf1
		end
	end
elseif bobrand = 2:
	minut += 5
	bj += 1
	gs'stat'
	dynamic $venerasiak
	gs 'zz_render', '', 'images/qwest/sosed/bj.jpg', func('bobka_strings', 'local_str5')
	act 'Встать раком':
		*clr & cla
		minut += 5
		$boy = 'Бобка'
		dick = 16
		silavag = 1
		gs 'zz_funcs', 'cum', 'anus'
		gs'stat'
		'<center><img src="images/qwest/sosed/anal.jpg"></center>'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_render', '', '', func('bobka_strings', 'local_str6')
		act 'Ширнуться':
			*clr & cla
			minut += 5
			StrongNarkota += 25
			SNarkTimes += 1
			NarkShmaraTimes += 1
			gs'stat'
			gs 'zz_render', '', '', func('bobka_strings', 'local_str7')
			act 'Уйти':minut += 15 & gt'street'
		end
	end
elseif bobrand = 3:
	minut += 10
	gs'stat'
	gs 'zz_render', '', 'images/qwest/sosed/rimming.jpg', func('bobka_strings', 'local_str8')
	act 'Нехотя лизать': gt'bobka','rimming2'
	act 'Старательно вылизывать': gt'bobka','rimming3'
elseif bobrand = 4:
	minut += 5
	pee += 1
	gs'stat'
	gs 'zz_render', '', 'images/qwest/sosed/knees.jpg', func('bobka_strings', 'local_str9')
	act 'Подставить лицо': gt'bobka','peeface'
	act 'Открыть рот': gt'bobka','peeswallow'
end
if $ARGS[0] = 'rimming2':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/rimming2.jpg', func('bobka_strings', 'local_str10')
	act 'Мычать и работать языком.':gt'bobka','rimming4'
end
if $ARGS[0] = 'rimming3':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/rimming3.jpg', func('bobka_strings', 'local_str11')
	act 'Мычать и работать языком.':gt'bobka','rimming4'
end
if $ARGS[0] = 'rimming4':
	cla
	*clr & cla
	minut += 5
	dom -= 1
	gs'stat'
	gs 'zz_render', '', 'images/qwest/sosed/rimming4.gif', func('bobka_strings', 'local_str12')
	act 'Кончить':gt'bobka','rimming5'
end
if $ARGS[0] = 'rimming5':
	cla
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	gs'stat'
	gs 'zz_render', '', 'images/qwest/sosed/rimming5.jpg', func('bobka_strings', 'local_str13')
	act 'Ширнуться':
		cla
		*clr & cla
		minut += 5
		StrongNarkota += 25
		SNarkTimes += 1
		NarkShmaraTimes += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sosed/PeredDozoy.jpg', func('bobka_strings', 'local_str14')
		act 'Уйти':minut += 15 & dynamic $snkayf1
	end
end
if $ARGS[0] = 'peeface':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/peeface.jpg', func('bobka_strings', 'local_str15')
	act 'Смотреть в глаза':gt'bobka','peeface2'
end
if $ARGS[0] = 'peeface2':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/peeface2.jpg', func('bobka_strings', 'local_str16')
	act 'Обтекать':gt'bobka','peeface3'
end
if $ARGS[0] = 'peeface3':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/peeface3.jpg', func('bobka_strings', 'local_str17')
	act 'Схватить шприц':gt'bobka','peewhore'
end
if $ARGS[0] = 'peeswallow':
	cla
	*clr & cla
	minut += 5
	money += 100
	water += 10
	gs 'zz_render', '', 'images/qwest/sosed/peeswallow.jpg', func('bobka_strings', 'local_str18')
	act 'Откашляться':gt'bobka','peeswallow2'
end
if $ARGS[0] = 'peeswallow2':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/peeswallow2.gif', func('bobka_strings', 'local_str19')
	act 'Старательно глотать':gt'bobka','peeswallow3'
end
if $ARGS[0] = 'peeswallow3':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/peeswallow3.jpg', func('bobka_strings', 'local_str20')
	act 'Взять в рот':gt'bobka','peeswallow4'
end
if $ARGS[0] = 'peeswallow4':
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/qwest/sosed/peeswallow4.jpg', func('bobka_strings', 'local_str21')
	act 'Схватить шприц':gt'bobka','peewhore'
end
if $ARGS[0] = 'peewhore':
	cla
	*clr & cla
	minut += 5
	StrongNarkota += 25
	SNarkTimes += 1
	NarkShmaraTimes += 1
	gs'stat'
	gs 'zz_render', '', 'images/qwest/sosed/peewhore.jpg', func('bobka_strings', 'local_str22')
	act 'Уйти':minut += 10 & dynamic $snkayf1
end