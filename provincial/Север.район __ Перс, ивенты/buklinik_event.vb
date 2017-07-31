if $ARGS[0] = 'pos1':
	cla
	*clr
	minut += 30
	buklinikDay = day
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_spal.jpg', func('buklinik_event_strings', 'local_str1')
	act 'Зайти в комнату': gt'buklinik_event','pos2'
	act 'Остаться у двери': gt'buklinik_event','pos5'
	act 'Выйти в коридор': gt'buklinik','holl'
end
if $ARGS[0] = 'pos2':
	cla
	*clr
	bumtolik = 7
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_spal.jpg', func('buklinik_event_strings', 'local_str2')
	act 'Попытаться уйти':gt'buklinik_event','pos3'
end
if $ARGS[0] = 'pos3':
	cla
	*clr
	manna -= 20
	horny += 3
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_grop2.jpg', func('buklinik_event_strings', 'local_str3')
	act 'Посмотреть на дверь':gt'buklinik_event','pos4'
end
if $ARGS[0] = 'pos4':
	cla
	*clr
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_angry.jpg', func('buklinik_event_strings', 'local_str4')
	act 'Хорошо, я поняла':gt'buklinik','holl'
end
if $ARGS[0] = 'pos5':
	cla
	*clr
	manna -= 5
	bumtolik = 7
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_spal.jpg', func('buklinik_event_strings', 'local_str5')
	act 'Выйти в коридор':gt'buklinik','holl'
end
if $ARGS[0] = 'pos6':
	cla
	*clr
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_eat.jpg', func('buklinik_event_strings', 'local_str6')
	act 'Разносить тарелки':gt'buklinik_event','pos7'
end
if $ARGS[0] = 'pos7':
	cla
	*clr
	buklinikDay=day
	gs'stat'
	'<center><img src="images/etogame/bukli_eat2.jpg"></center>'
	if bumtolik > 7:
		gs 'zz_render', '', '', func('buklinik_event_strings', 'local_str7')
	elseif bumtolik = 7:
		bumtolik = 8
		gs 'zz_render', '', '', func('buklinik_event_strings', 'local_str8')
	end
	act 'Закончить':gt'buklinik','olga2'
end
if $ARGS[0] = 'pos8':
	cla
	*clr
	if bumtolik = 8:bumtolik = 9
	buklinikDay = day
	minut += 120
	manna += 20
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_sitter1.jpg', func('buklinik_event_strings', 'local_str9')
	act 'Закончить':gt'buklinik','olga2'
end
if $ARGS[0] = 'pos9':
	cla
	*clr
	buklinikDay = day
	minut += 120
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_mission.jpg', func('buklinik_event_strings', 'local_str10')
	if horny > 50 and tanga = 1 and func('zz_clothing','is_skirt') = 1:
		act 'Есть одна мысль': gt'buklinik_event','pos10'
	end
	act 'Понятия не имею': gt'buklinik','olga2'
end
if $ARGS[0] = 'pos10':
	cla
	*clr
	bumtolik = 10
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/etogame/bukli_mission1.jpg', func('buklinik_event_strings', 'local_str11')
	act 'Закончить':gt'buklinik','olga2'
end