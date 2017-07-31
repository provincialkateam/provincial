if $ARGS[0] = 'start':
	minut += 30
	gs 'zz_render', '', '', func('kinoM_strings', 'local_str1')
	if dayA > 15 and harakBoyA = 2:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 1:gs'boylove','tits'
	if dayA > 25 and harakBoyA = 0:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 2:gs'boylove','figure'
	if dayA > 25 and harakBoyA = 1:gs'boylove','figure'
	if dayA > 30 and harakBoyA = 0:gs'boylove','figure'
	gs'anekdot'
	gs 'zz_render', '', '', func('kinoM_strings', 'local_str2')
	act 'Смеяться':
		cla
		bfA += 1
		xgt'kinoM','a'
	end
	act 'Улыбаться':
		cla
		xgt'kinoM','a'
	end
	act 'Не смешно':
		cla
		bfA -= 3
		xgt 'kinoM','a'
	end
end
if $ARGS[0] = 'a':
	*clr
	minut += 90
	body['day_weight'] += 1
	gs 'zz_render', '', 'images/pic/kino.jpg', func('kinoM_strings', 'local_str3')
	if harakBoyA < 2:
		act 'Обнять его руку':
			cla
			bfA += 1
			gs 'zz_render', '', '', func('kinoM_strings', 'local_str4')
			xgt'kinoM','b'
		end
	elseif harakBoyA = 2:
		act 'Обнять его руку':
			cla
			bfA += 1
			gs 'zz_render', '', '', func('kinoM_strings', 'local_str5')
			act 'Убрать его руку и смотреть кино':xgt'kinoM','b'
			act 'Подрочить':gt'kinoM','hj'
			act 'Отсосать':gt'kinoM','bj'
			act 'Сесть сверху на его член':gt'kinoM','sex'
		end
	end
	act 'Смотреть кино':
		cla
		bfA -= 1
		intel = intel + 1
		gs 'zz_render', '', '', func('kinoM_strings', 'local_str6')
		xgt'kinoM','b'
	end
end
if $ARGS[0] = 'sex':
	*clr
	sex += 1
	sexa += 1
	vagina += 1
	horny += 10
	bfA += 2
	gs 'brosok'
	gs 'zz_render', '', 'images/picVA/sinema.jpg', func('kinoM_strings', 'local_str7')
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		gs 'zz_render', '', '', func('kinoM_strings', 'local_str8')
	end
	gs 'zz_render', '', '', func('kinoM_strings', 'local_str9')
	act 'Далее':gt'kinoM','b'
end
if $ARGS[0] = 'bj':
	*clr
	bj += 1
	bja += 1
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	horny += 10
	bfA += 2
	gs 'brosok'
	gs 'zz_render', '', 'images/picVA/sinema1.jpg', func('kinoM_strings', 'local_str10')
	act 'Далее': gt 'kinoM','b'
end
if $ARGS[0] = 'hj':
	*clr
	hj += 1
	hja += 1
	horny += 10
	bfA += 1
	gs 'brosok'
	gs 'zz_render', '', 'images/picVA/sinema2.jpg', func('kinoM_strings', 'local_str11')
	act 'Далее':gt'kinoM','b'
end
if $ARGS[0] = 'b':
	minut += 30
	gs 'zz_render', '', '', func('kinoM_strings', 'local_str12')
	act 'Домой': gt 'sexm','start'
end