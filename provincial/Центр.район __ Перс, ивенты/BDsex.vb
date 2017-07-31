if $ARGS[0] = 'start':
	!выбор интеракций
	!gs'BDsex','start'
	minut += 3
	if NoGuy = 0: guy += 1
	horny += 10
	gs'stat'
	'<center><img src="images/picKav/petting.jpg"></center>'
	if harakBoy = 0:
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str1')
		act 'Полижи у меня':gt'BDsex','kuni'
		act 'Дрочить ему член':gt'BDsex','hj'
		act 'Взять в рот':gt'BDsex','minet'
		act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
		act 'Встать на четвереньки':gt'BDsex','sex2'
		act 'Анальный секс':gt'BDsex','anal2'
	elseif harakBoy = 1:
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str2')
		if RAND(0,100) < 70:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str3')
			if RAND(0,2) < 2:
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str4')
				act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
			else
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str5')
				act 'Встать на четвереньки':gt'BDsex','sex2'
			end
			act 'Давай я пососу':gt'BDsex','minet'
		else
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str6')
			act 'Дрочить ему член':gt'BDsex','hj'
			act 'Взять в рот':gt'BDsex','minet'
			act 'Я так не хочу. Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
		end
	elseif harakBoy = 2:
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str7')
		brand = RAND(0,100)
		if brand < 70:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str8')
			if RAND(0,2) < 2:
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str9')
				act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
			else
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str10')
				act 'Встать на четвереньки':gt'BDsex','sex2'
			end
		elseif brand >= 70 and brand < 90:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str11')
			act 'Взять в рот':gt'BDsex','minet'
			if dom > 0:
				act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
				act 'Встать на четвереньки':gt'BDsex','sex2'
			end
		elseif brand >= 90:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str12')
			act 'Анальный секс':gt'BDsex','anal2'
			if dom > 0:
				act 'Я так не хочу! Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
				act 'Я встану раком, но в попу не дам!':gt'BDsex','sex2'
				act 'Взять в рот':gt'BDsex','minet'
			end
		end
	end
end
if $ARGS[0] = 'kuni':
	minut += 15
	DOM += 1
	kuni += 1
	horny += DOM + (silaVag*2 + 5)
	gs'stat'
	gs 'zz_render', '', 'images/picV/kuni.jpg', func('BDsex_strings', 'local_str13')
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str14')
	else
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str15')
	end
	act 'Дрочить ему член':gt'BDsex','hj'
	act 'Взять в рот':gt'BDsex','minet'
	act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
	act 'Встать на четвереньки':gt'BDsex','sex2'
	act 'Анальный секс':gt'BDsex','anal2'
end
if $ARGS[0] = 'sex':
	!миссионерская поза
	minut += 10
	pose = 0
	gs'stat'
	'<center><img src="images/picV/vag.jpg"></center>'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	if harakBoy > 0:
		if RAND(0,10) >= 8:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str16')
			act 'Подставить лицо':gt'BDsex','facial'
			act 'Открыть рот':gt'BDsex','swallow'
			exit
		end
	end
	if harakBoy = 2:
		if RAND(0,10) >= 8:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str17')
			act 'Анальный секс':gt'BDsex','anal2'
			exit
		end
	end
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Уйти':gt'BDsex','end'
end
if $ARGS[0] = 'sex2':
	!раком
	minut += 10
	pose = 1
	gs'stat'
	'<center><img src="images/pics/vagdog'+RAND(1,5)+'.jpg"></center>'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	if harakBoy > 0:
		if RAND(0,10) >= 8:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str18')
			act 'Подставить лицо':gt'BDsex','facial'
			act 'Открыть рот':gt'BDsex','swallow'
			exit
		end
	end
	if harakBoy = 2:
		if RAND(0,10) >= 8:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str19')
			act 'Анальный секс':gt'BDsex','anal2'
			exit
		end
	end
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Уйти':gt'BDsex','end'
end
if $ARGS[0] = 'anal2':
	!раком
	minut += 10
	gs'stat'
	'<center><img src="images/pics/anal'+RAND(1,10)+'.jpg"></center>'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	if harakBoy > 0:
		if RAND(0,10) >= 8:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str20')
			act 'Подставить лицо':gt'BDsex','facial'
			act 'Открыть рот':gt'BDsex','swallow'
			exit
		end
	end
	gs 'zz_dynamic_sex', 'anal_cum'
	act 'Уйти':gt'BDsex','end'
end
if $ARGS[0] = 'hj':
	!ханджоб
	hj += 1
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/picV/hand1.jpg', func('BDsex_strings', 'local_str21')
	bjrand = RAND(0,100)
	if bjrand >= 75:
		if harakBoy = 0:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str22')
			act 'Пусть кончает':
				cla
				*clr
				gs 'zz_render', '', 'images/picV/hand2.jpg', func('BDsex_strings', 'local_str23')
				act 'Уйти':gt'BDsex','end'
			end
			act 'Взять в рот':gt'BDsex','minet'
			act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
		elseif harakBoy = 1:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str24')
			act 'Взять в рот':gt'BDsex','minet'
			act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
		else
			brand = RAND(0,100)
			if brand < 70:
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str25')
				if RAND(0,2) < 2:
					gs 'zz_render', '', '', func('BDsex_strings', 'local_str26')
					act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
				else
					gs 'zz_render', '', '', func('BDsex_strings', 'local_str27')
					act 'Встать на четвереньки':gt'BDsex','sex2'
				end
			elseif brand >= 70 and brand < 80:
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str28')
				act 'Анальный секс':gt'BDsex','anal2'
				if dom > 5:
					act 'Я так не хочу! Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
					act 'Я встану раком, но в попу не дам!':gt'BDsex','sex2'
					act 'Взять в рот':gt'BDsex','minet'
				end
			elseif brand >= 80:
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str29')
				act 'Взять в рот':gt'BDsex','minet'
			end
		end
	else
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str30')
		act 'Подставить лицо':gt'BDsex','facial'
		act 'Открыть рот':gt'BDsex','swallow'
	end
end
if $ARGS[0] = 'minet':
	!минет
	minut += 5
	gs'stat'
	'<center><img src="images/picV/bj'+RAND(0,4)+'.jpg"></center>'
	gs 'zz_dynamic_sex', 'bj'
	if RAND(0,100) >= 75:
		if harakBoy = 0:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str31')
			act 'В ладони':
				cla
				*clr
				gs 'zz_render', '', 'images/picV/hand2.jpg', func('BDsex_strings', 'local_str32')
				act 'Уйти':gt'BDsex','end'
			end
			act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
		elseif harakBoy = 1:
			gs 'zz_render', '', '', func('BDsex_strings', 'local_str33')
			act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
		else
			if RAND(0,100) < 70:
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str34')
				if RAND(0,2) < 2:
					gs 'zz_render', '', '', func('BDsex_strings', 'local_str35')
					act 'Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
				else
					gs 'zz_render', '', '', func('BDsex_strings', 'local_str36')
					act 'Встать на четвереньки':gt'BDsex','sex2'
				end
			else
				gs 'zz_render', '', '', func('BDsex_strings', 'local_str37')
				act 'Анальный секс':gt'BDsex','anal2'
				if dom > 0:
					act 'Я так не хочу! Лечь на спину и раздвинуть ноги':gt'BDsex','sex'
					act 'Я встану раком, но в попу не дам!':gt'BDsex','sex2'
				end
			end
		end
	else
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str38')
		act 'Подставить лицо':gt'BDsex','facial'
		act 'Открыть рот':gt'BDsex','swallow'
		if harakBoy = 0:
			act 'В ладони':
				cla
				*clr
				gs 'zz_render', '', 'images/picV/hand2.jpg', func('BDsex_strings', 'local_str39')
				act 'Уйти':gt'BDsex','end'
			end
		end
	end
end
if $ARGS[0] = 'facial':
	gs 'zz_funcs', 'cum', 'face'
	minut += 3
	gs'stat'
	gs 'zz_render', '', 'images/pics/facial'+RAND(1,5)+'.jpg', func('BDsex_strings', 'local_str40')
	act 'Приводить себя в порядок':gt'BDsex','end'
end
if $ARGS[0] = 'swallow':
	minut += 3
	gs'stat'
	gs 'zz_render', '', 'images/pics/cum'+RAND(1,10)+'.jpg'
	gs 'zz_dynamic_sex', 'swallow'
	act 'Приводить себя в порядок':gt'BDsex','end'
end
if $ARGS[0] = 'end':
	NoGuy = 0
	if InYouHome = 1:
		InYouHome = 0
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str42')
		act 'Уйти': gt 'korr'
		exit
	end
	if harakBoy = 0:
		horny += 1
		gs 'zz_bathroom', 'shower'
		gs 'zz_render', '', 'images/pics/dush.jpg', func('BDsex_strings', 'local_str43')
	elseif harakBoy = 1:
		if cumface > 0:cumface = 0
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str44')
	elseif harakBoy = 2:
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str45')
	end
	if finance > 0:
		if finance = 1:money += 300
		if finance = 2:money += 500
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str46')
	elseif finance = 0:
		gs 'zz_render', '', '', func('BDsex_strings', 'local_str47')
	end
	if GoToGuy = 0:
		act 'Уйти': gt 'street'
	else
		act 'Уйти':
			if GoToGuy = 1: GoToGuy = 0 & gt 'nord'
			if GoToGuy = 2: GoToGuy = 0 & gt 'street'
		end
	end
end