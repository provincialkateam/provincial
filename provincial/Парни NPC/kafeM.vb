if $ARGS[0] = 'start':
	minut += 30
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str1')
	if dayA > 15 and harakBoyA = 2:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 1:gs'boylove','tits'
	if dayA > 25 and harakBoyA = 0:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 2:gs'boylove','figure'
	if dayA > 25 and harakBoyA = 1:gs'boylove','figure'
	if dayA > 30 and harakBoyA = 0:gs'boylove','figure'
	gs'anekdot'
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str2')
	act 'Смеяться':
		cla
		dom -= 1
		bfA += 1
		xgt'kafeM','a'
	end
	act 'Улыбаться':
		cla
		xgt'kafeM','a'
	end
	act 'Не смешно':
		cla
		DOM += 1
		bfA -= 1
		xgt'kafeM','a'
	end
end
if $ARGS[0] = 'a':
	minut += 30
	cumlip = 0
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str3')
	act 'Есть':
		*clr & cla
		xgt'kafeM','b'
	end
end
if $ARGS[0] = 'b':
	minut += 10
	gs 'zz_kitchen_acts', 'eat'
	gs 'zz_kitchen_acts', 'drink', 'tea'
	gs 'zz_funcs', 'alko', 2
	gs 'stat'
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str4')
	act 'Танцевать':
		*clr &cla
		bfA += 1
		xgt'kafeM','dance'
	end
	act 'Отказаться':
		*clr &cla
		bfA -= 1
		xgt'kafeM','end'
	end
end
if $ARGS[0] = 'dance':
	minut += 5
	gs 'zz_render', '', 'images/pic/dance.jpg', func('kafeM_strings', 'local_str5')
	if harakBoyA = 0:
		gs 'zz_render', '', '', func('kafeM_strings', 'local_str6')
		act 'Закончить танец':
			cla
			bfA += 1
			xgt'kafeM','end'
		end
	elseif harakBoyA = 1:
		gs 'zz_render', '', '', func('kafeM_strings', 'local_str7')
		act 'Закончить танец':
			cla
			bfA += 1
			xgt'kafeM','end'
		end
	elseif harakBoyA = 2:
		gs 'zz_render', '', '', func('kafeM_strings', 'local_str8')
		act 'Закончить танец':
			cla
			bfA += 1
			xgt'kafeM','end'
		end
		act 'Идти в туалет':xgt'kafeM','tualet'
	end
end
if $ARGS[0] = 'tualet':
	minut += 30
	horny += 10
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str9')
	act 'Сделать минет':gt'kafeM','bj'
	act 'Нагнуться над унитазом':gt'kafeM','sex'
end
if $ARGS[0] = 'sex':
	*clr
	sex += 1
	sexa += 1
	vagina += 1
	horny += 10
	bfA += 2
	gs'brosok'
	gs 'zz_render', '', 'images/picVA/kafe.jpg', func('kafeM_strings', 'local_str10')
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		gs 'zz_render', '', '', func('kafeM_strings', 'local_str11')
	end
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str12')
	act 'Далее':gt'kafeM','end'
end
if $ARGS[0] = 'bj':
	*clr
	bj += 1
	bja += 1
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	horny += 10
	bfA += 2
	gs'brosok'
	gs 'zz_render', '', 'images/picVA/kafe1.jpg', func('kafeM_strings', 'local_str13')
	act 'Далее':gt'kafeM','end'
end
if $ARGS[0] = 'end':
	minut += 30
	gs 'zz_render', '', '', func('kafeM_strings', 'local_str14')
	act 'Домой':gt'sexm','start'
end