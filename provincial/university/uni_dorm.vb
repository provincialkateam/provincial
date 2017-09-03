! первый этаж, вход в общагу, нежилые хозяйственные помещения
if $args[0] = '' or args[0] = 1:
	*clr & cla
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',1
	gs 'zz_render','','','Первый этаж общежития. Бла-бла-бля.'
end
if $args[0] = 'navigation':
	_dorm_cur_floor = args[1]
	if _dorm_cur_floor < 1: _dorm_cur_floor = 1
	act '<b>В студгородок</b>': minut += 5 & gt 'uni_campus'
	if _dorm_cur_floor ! 1: act 'Первый этаж': gt 'uni_dorm',1
	if _dorm_cur_floor ! 2: act 'Второй этаж': gt 'uni_dorm',2
	if _dorm_cur_floor ! 3: act 'Третий этаж': gt 'uni_dorm',3
	if _dorm_cur_floor ! 4: act 'Четвертый этаж': gt 'uni_dorm',4
	if _dorm_cur_floor ! 5: act 'Пятый этаж': gt 'uni_dorm',5
end
if args[0] = 2:
	*clr & cla
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',2
	gs 'zz_render','','','Второй этаж общежития. Азиаты. Вставить рандомно ивенты с готовкой селедки и собачатины.'
	! комнаты
	act 'Комната Ким Чен Ина':
		exit
	end
end
if args[0] = 3:
	*clr & cla
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',3
	gs 'zz_render','','','Третий этаж общежития. Нигры. Здесь стоит прикрутить главных планокуров.'
	! комнаты
	act 'Комната Лумумбы':
		exit
	end
end
if args[0] = 4:
	*clr & cla
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',4
	gs 'zz_render','','','Четвертый этаж общежития. Страны СНГ.'
	! комнаты
	act 'Комната Хабибулина':
		exit
	end
end
if args[0] = 5:
	*clr & cla
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',5
	gs 'zz_render','','','Пятый этаж общежития. Здесь комната Светки.'
	! комнаты
	act 'Комната Светки':
		exit
	end
	act 'Кухня (а она надо?)':
		exit
	end
	act 'Ванная':
		exit
	end
	act 'Комната Гоши':
		exit
	end
end