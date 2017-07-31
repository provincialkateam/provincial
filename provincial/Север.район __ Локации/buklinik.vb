if $ARGS[0] = 'start' or $ARGS[0]='':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b>Клиника милосердия</b></center>'
	gs 'zz_render', '', 'images/etogame/bukli.jpg', func('buklinik_strings', 'local_str1')
	temp = RAND(1,10)
	if temp = 9:'Вы видите толпу бездомных, пытающихся попасть в приют.'
	if temp = 2:'Вы видите бездомного, пытающегося попасть в приют.'
	if temp = 3:'Вы видите старика пришедшего в приют.'
	if hour >= 9 and hour <= 17:
		act 'Зайти в клинику': gt 'buklinik','holl'
	end
	act 'Уйти': gt'nord'
end
if $ARGS[0] = 'holl':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Холл', 'images/etogame/bukli_holl.jpg', func('buklinik_strings', 'local_str2')
	if (school['certificate'] = 0 and bumtolik = 0) or bumtolik = 4:
		act 'Обратиться в регистратуру':gt 'buklinik', 'registr'
	end
	if school['certificate'] = 0 and week < 6 and bumtolik >= 5:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str3')
	else
		if bumtolik > 4: 'Вещи хранятся на <a href="exec:GT ''buklinik'',''sklad''">складе</a>.'
		if bumtolik > 5:
			gs 'zz_render', '', '', func('buklinik_strings', 'local_str4')
		end
		if bumtolik = 6: '<a href="exec:GT ''buklinik'',''spal''">Спальные места</a>.'
		if bumtolik > 6: 'Спальные места. (Я туда больше ни ногой)'
	end
	act 'Уйти': gt 'nord'
end
if $ARGS[0] = 'registr':
	cla
	*clr
	minut += 15
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Регистратура', 'images/etogame/bukli_reg.jpg', func('buklinik_strings', 'local_str5')
	if school['certificate'] = 0 and bumtolik = 0:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str6')
	else
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str7')
	end
	act 'Я поняла вас, мне надо подумать': gt 'nord'
	act 'Согласиться': gt 'buklinik', 'registr2'
end
if $ARGS[0] = 'registr2':
	cla
	*clr
	minut += 15
	bumtolik = 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Регистратура', 'images/etogame/bukli_reg.jpg', func('buklinik_strings', 'local_str8')
	act 'В коридор': gt 'buklinik', 'holl'
end
if $ARGS[0] = 'registr3':
	cla
	*clr
	minut += 15
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Регистратура', 'images/etogame/bukli_reg.jpg', func('buklinik_strings', 'local_str9')
	act 'В коридор':gt'buklinik','holl'
end
if $ARGS[0] = 'sklad':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Склад', 'img src="images/etogame/bukli_sklad.jpg', func('buklinik_strings', 'local_str10')
	if bumtolik = 5:act 'Найти Ольгу':gt'buklinik','olga'
	act 'В коридор':gt'buklinik','holl'
end
if $ARGS[0] = 'olga':
	cla
	*clr
	minut += 5
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ваша коллега - Ольга', 'images/etogame/bukli_olga.jpg', func('buklinik_strings', 'local_str11')
	if bumtolik = 5:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str12')
	end
	act 'К офис-менеджеру': gt'buklinik','sec'
end
if $ARGS[0] = 'sec':
	cla
	*clr
	minut += 15
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ваша коллега - Жанна', 'images/etogame/bukli_sec.jpg', func('buklinik_strings', 'local_str13')
	if bumtolik = 5:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str14')
		act 'К руководителю':gt'buklinik','dir'
	elseif bumtolik > 5:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str15')
		act 'В коридор':gt'buklinik','holl'
	end
end
if $ARGS[0] = 'dir':
	cla
	*clr
	minut += 15
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ваша коллега - Вера', 'images/etogame/bukli_dir.jpg', func('buklinik_strings', 'local_str16')
	if bumtolik = 5:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str17')
		act 'Закончить знакомство':gt'buklinik','olga2'
	elseif bumtolik > 5:
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str18')
		act 'В коридор':gt'buklinik','holl'
	end
end
if $ARGS[0] = 'shower':
	cla
	*clr
	minut += 15
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Душевая', 'images/etogame/bukli_show.jpg', func('buklinik_strings', 'local_str19')
	act 'В коридор':gt'buklinik','holl'
end
if $ARGS[0] = 'stol':
	cla
	*clr
	minut += 15
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Столовая', 'images/etogame/bukli_stol.jpg', func('buklinik_strings', 'local_str20')
	act 'В коридор':gt'buklinik','holl'
end
if $ARGS[0] = 'spal':
	cla
	*clr
	minut += 15
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Клиника милосердия. Спальни', 'images/etogame/bukli_spal.jpg', func('buklinik_strings', 'local_str21')
	if bumtolik = 6:
		act 'Поздороваться': gt 'buklinik_event','pos1'
	end
	act 'В коридор':gt'buklinik','holl'
end
if $ARGS[0] = 'olga2':
	cla
	*clr
	minut += 15
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ваша коллега - Ольга', 'images/etogame/bukli_olga.jpg', func('buklinik_strings', 'local_str22')
	if bumtolik > 5: '- Привет, <<$name[1]>>!'
	if buklinikDay = day:'- На сегодня больше работы нет, можем отдохнуть.'
	if bumtolik >= 7 and buklinikDay ! day: '- <<$name[1]>>, нам нужно помощь <a href="exec:GT ''buklinik_event'',''pos6''">накормить нуждающихся</a>.'
	if bumtolik >= 8 and buklinikDay ! day: '- <<$name[1]>>, вот адрес одного <a href="exec:GT ''buklinik_event'',''pos8''">пожилого человека</a>, сходи к нему помоги по хозяйству.'
	if bumtolik = 9 and buklinikDay ! day: '- <<$name[1]>>, нужно помочь уговорить одного алкаша не скитаться по улицам, а придти жить к <a href="exec:GT ''buklinik_event'',''pos9''">нам</a>.'
	if bumtolik = 10 and buklinikDay ! day: '- Нам нужна сиделка, для одного очень <a href="exec:GT ''misha_inv'',''event0''">необычного человека</a>.'
	if bumtolik = 11 and buklinikDay ! day: '- <<$name[1]>>, тебе снова нужно отправиться к <a href="exec:GT ''misha_inv'',''entrance'',0">Михаилу</a>.'
	if bumtolik = 12 and buklinikDay ! day: '- Тебя снова ждет <a href="exec:GT ''misha_inv'',''entrance'',1">Михаил</a>.'
	if bumtolik = 13 and buklinikDay ! day: '- <<$name[1]>>, тебя снова ждет <a href="exec:GT ''misha_inv'',''entrance'',2">Михаил</a>.'
	if bumtolik = 14 and buklinikDay ! day: '- <<$name[1]>>, тебя ждет <a href="exec:GT ''misha_inv'',''entrance'',3">Михаил</a>.'
	if bumtolik = 15 and buklinikDay ! day: '- Тебя ждет <a href="exec:GT ''misha_inv'',''entrance'',4">Михаил</a>.'
	if bumtolik = 16 and week = 1 and buklinikDay ! day: '- Тебя ждет <a href="exec:GT ''misha_inv'',''entrance'',5">Михаил</a>.'
	if bumtolik = 5:
		bumtolik = 6
		gs 'zz_render', '', '', func('buklinik_strings', 'local_str23')
	end
	act 'В коридор': gt 'buklinik','holl'
end