if $ARGS[0] = 'start':
	cla
	*clr
	if love = 0 and bfa >= 100 and daya >= 30 and husband = 0:
		act 'Поговорить о сожительстве': gt 'love', 'start'
	end
	gs 'zz_render', '', '', func('sexm_strings', 'local_str1')
	if harakBoyA = 2: '<<$name[2]>>, может пригласишь меня к себе на чашечку кофе?'
	if harakBoyA = 1: 'Дай я тебя поцелую, любимая.'
	if harakBoyA = 0: 'Пока <<$name[1]>>, я буду ждать момента когда мы снова увидимся и буду скучать по тебе.'
	act 'Поцеловать на прощанье':
		cla
		if harakBoyA = 2:
			if daya < 3:
				bfA += iif(boyonceA = 0, 1, -2)
				gs 'zz_render', '', '', func('sexm_strings', 'local_str2')
			elseif daya >= 3:
				bfA -= 2
				gs 'zz_render', '', '', func('sexm_strings', 'local_str3')
				*pl iif(boyonceA = 0,'"Ладно, пока, динама."','"А что ты сегодня то секса не хочешь?"')
			end
		elseif harakBoyA = 1:
			if daya < 10:
				bfA += iif(boyonceA = 0, 2, -1)
				gs 'zz_render', '', '', func('sexm_strings', 'local_str4')
			elseif daya >= 10:
				bfA -= 2
				gs 'zz_render', '', '', func('sexm_strings', 'local_str5')
				*pl iif(boyonceA = 0,'"Долго мы будем как пионеры за ручки держаться?"','"Ладно, проживу денек и без секса."')
			end
		elseif harakBoyA = 0:
			if daya < 20:
				bfA += iif(boyonceA = 0, 3, 1)
				gs 'zz_render', '', '', func('sexm_strings', 'local_str6')
			elseif daya >= 20:
				bfA -= 1
				gs 'zz_render', '', '', func('sexm_strings', 'local_str7')
			end
		end
		act 'Зайти в квартиру': gt 'korr'
	end
	act 'Попрощаться':
		cla
		if boyonceA = 0:
			if harakBoyA = 2:
				if daya < 3:
					bfA -= 1
					gs 'zz_render', '', '', func('sexm_strings', 'local_str8')
				elseif daya >= 3:
					bfA -= 3
					gs 'zz_render', '', '', func('sexm_strings', 'local_str9')
				end
			elseif harakBoyA = 1:
				if daya < 10:
					bfA += 1
					gs 'zz_render', '', '', func('sexm_strings', 'local_str10')
				elseif daya >= 10:
					bfA -= 2
					gs 'zz_render', '', '', func('sexm_strings', 'local_str11')
				end
			elseif harakBoyA = 0:
				if daya < 20:
					bfA += 2
					gs 'zz_render', '', '', func('sexm_strings', 'local_str12')
				elseif daya >= 20:
					bfA -= 1
					gs 'zz_render', '', '', func('sexm_strings', 'local_str13')
				end
			end
		elseif boyonceA = 1:
			if harakBoyA = 2:
				if daya < 3:
					bfA -= 2
					gs 'zz_render', '', '', func('sexm_strings', 'local_str14')
				elseif daya >= 3:
					bfA -= 4
					gs 'zz_render', '', '', func('sexm_strings', 'local_str15')
				end
			elseif harakBoyA = 1:
				if daya < 10:
					bfA -= 1
					gs 'zz_render', '', '', func('sexm_strings', 'local_str16')
				elseif daya >= 10:
					bfA -= 3
					gs 'zz_render', '', '', func('sexm_strings', 'local_str17')
				end
			elseif harakBoyA = 0:
				if daya < 20:
					bfA += 1
					gs 'zz_render', '', '', func('sexm_strings', 'local_str18')
				elseif daya >= 20:
					bfA -= 2
					gs 'zz_render', '', '', func('sexm_strings', 'local_str19')
				end
			end
		end
		act 'Зайти в квартиру': gt 'korr'
	end
	if husband = 0:
		act 'Пригласить к себе':
			cla
			gt'sexm','room'
		end
	elseif husband > 0:
		if week < 6 and hour < 17 and hour > 7:
			act 'Пригласить к себе':gt'sexm','room'
		elseif week > 5 or week < 6 and hour > 16:
			act 'Сказать что дома муж и к вам нельзя':
				cla
				if harakBoyA = 0:
					bfA = 0
					gs 'zz_render', '', '', func('sexm_strings', 'local_str20')
					act 'Зайти в квартиру':gt'korr'
				elseif harakBoyA = 1:
					gs 'zz_render', '', '', func('sexm_strings', 'local_str21')
					act 'Зайти в квартиру':gt'korr'
				elseif harakBoyA = 2:
					gs 'zz_render', '', '', func('sexm_strings', 'local_str22')
					act 'Отказаться': bfa -= 1 & gt 'korr'
					act 'Согласиться':
						bfa += 1
						boycherdaksex = 1
						gt 'sexm','room'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'room':
	*clr
	minut += 20
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if boycherdaksex = 1:
		gs 'zz_render', '', 'images/etogame/cherdak.jpg', func('sexm_strings', 'local_str23')
	else
		gs 'zz_render', 'Спальня', 'images/city/south/apartment/bedr'+iif(my_house = 1,'',iif(rembedr = 0,0,iif(rembedr = 1,1,iif(rembedr = 2,2,3))))+'.jpg', func('sexm_strings', 'local_str24')
	end
	if harakBoyA = 2:
		gs 'zz_render', '', '', func('sexm_strings', 'local_str25')
		if boyonceA = 1:
			sexrand = RAND(0,3)
			if sexrand = 0:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str26')
				act 'Сделать минет':
					cla
					bfA += 3
					gt'sexm','minet'
				end
				act 'Я не хочу, давай по другому':gt'sexm','variant'
			elseif sexrand = 1:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str27')
				act 'Анальный секс':
					cla
					bfA += 5
					gt'sexm','anal'
				end
				act 'Да ну нафиг, давай по другому':gt'sexm','variant'
			elseif sexrand = 2:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str28')
				act 'Раздвинуть ноги':gt'sexm','miss'
				act 'Я не хочу, давай по другому':gt'sexm','variant'
			elseif sexrand = 3:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str29')
				act 'Встать раком':gt'sexm','dog'
				act 'Я не хочу, давай по другому':gt'sexm','variant'
			end
		elseif boyonceA = 0:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str30')
			act 'Секс':gt'sexm','miss'
			act 'Я не хочу, давай по другому':gt'sexm','variant'
		end
	elseif harakBoyA = 1:
		gs 'zz_render', '', '', func('sexm_strings', 'local_str31')
		act 'Я хочу так, как хочешь ты':
			cla
			if boyonceA = 1:
				sexrand = RAND(0,3)
				if sexrand = 0:
					gs 'zz_render', '', '', func('sexm_strings', 'local_str32')
					act 'Сделать минет':
						cla
						bfA += 2
						gt'sexm','minet'
					end
					act 'Я не хочу, давай по другому':gt'sexm','variant'
				elseif sexrand = 1:
					gs 'zz_render', '', '', func('sexm_strings', 'local_str33')
					act 'Анальный секс':
						cla
						bfA += 4
						gt'sexm','anal'
					end
					act 'Я не хочу, давай по другому':gt'sexm','variant'
				elseif sexrand = 2:
					gs 'zz_render', '', '', func('sexm_strings', 'local_str34')
					act 'Раздвинуть ноги':gt'sexm','miss'
					act 'Я не хочу, давай по другому':gt'sexm','variant'
				elseif sexrand = 3:
					gs 'zz_render', '', '', func('sexm_strings', 'local_str35')
					act 'Встать раком':gt'sexm','dog'
					act 'Я не хочу, давай по другому':gt'sexm','variant'
				end
			elseif boyonceA = 0:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str36')
				act 'Секс':gt'sexm','miss'
				act 'Я не хочу, давай по другому':gt'sexm','variant'
			end
		end
		act 'Предложить варианты':gt'sexm','variant'
	elseif harakBoyA = 0:
		gs 'zz_render', '', '', func('sexm_strings', 'local_str37')
		act 'Предложить варианты':gt'sexm','variant'
	end
end
if $ARGS[0] = 'variant':
	if harakBoyA = 0: bfA += 1
	if harakBoyA = 2: bfA -= 1
	gs 'zz_render', '', '', func('sexm_strings', 'local_str38')
	act 'Раздвинуть ноги': gt 'sexm', 'miss'
	act 'Встать раком': gt 'sexm', 'dog'
	act 'Анальный секс': gt 'sexm', 'anal'
	act 'Сделать минет': gt 'sexm', 'minet'
	act 'Подрочить ему': gt 'sexm', 'hand'
	if kunday ! day:
		act 'Куни':gt'sexm','kuni'
	end
	if DOM > 0 and boyonceA = 1 and harakBoyA = 0 and izvratA = 1 and strapon > 0:
		act 'Отстрапонить': gt 'sexm', 'strapon'
	end
end
if $ARGS[0] = 'minet':
	*clr
	popolaini = 1
	bfA += 1
	bj += 1
	bja += 1
	dick = dickA
	harakBoy = harakBoyA
	minut += 30
	$boy = $boyA
	gs'brosok'
	gs'stat'
	gs 'zz_render', '', 'images/picV/bj0.jpg', func('sexm_strings', 'local_str39')
	gs 'zz_dynamic_sex', 'bj'
	act 'Продолжать сосать':
		cla
		*clr
		swallow += 1
		gs 'zz_funcs', 'cum', 'lip'
		bfA += 3
		gs 'zz_render', '', 'images/picV/swallow.jpg', func('sexm_strings', 'local_str40')
		act 'Уйти':gt'sexm','endsex'
	end
	act 'Вынуть изо рта':
		cla
		*clr
		if harakBoyA = 0:
			gs 'zz_render', '', 'images/picV/hand.jpg', func('sexm_strings', 'local_str41')
		elseif harakBoyA = 1:
			if RAND(0,3) < 3:
				gs 'zz_render', '', 'images/picV/hand.jpg', func('sexm_strings', 'local_str42')
			else
				gs 'zz_funcs', 'cum', 'face'
				bfA += 1
				gs 'zz_render', '', 'images/picV/facial.jpg', func('sexm_strings', 'local_str43')
			end
		elseif harakBoyA = 2:
			gs 'zz_funcs', 'cum', 'face'
			bfA += 1
			gs 'zz_render', '', 'images/picV/facial.jpg', func('sexm_strings', 'local_str44')
		end
		act 'Уйти':gt'sexm','endsex'
	end
end
if $ARGS[0] = 'hand':
	*clr
	popolaini = 1
	DOM += 1
	hj += 1
	hja += 1
	minut += 30
	horny += DOM
	gs 'brosok'
	gs 'stat'
	gs 'zz_render', '', 'images/picV/hand1.jpg', func('sexm_strings', 'local_str45')
	bfA -= iif(harakBoyA = 0, 1, harakBoyA * 5)
	act 'Вытереть руки и проводить парня до дверей':gt'sexm','endsex'
end
if $ARGS[0] = 'kuni':
	*clr
	kunday = day
	DOM += 1
	kuni += 1
	minut += 30
	horny += DOM + (silaVag*2 + 5)
	gs 'brosok'
	gs 'stat'
	gs 'zz_render', '', 'images/picV/kuni.jpg', func('sexm_strings', 'local_str46')
	bfA -= iif(harakBoyA = 0, 1, harakBoyA*5)
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		gs 'zz_render', '', '', func('sexm_strings', 'local_str47')
	else
		gs 'zz_render', '', '', func('sexm_strings', 'local_str48')
	end
	act 'Дальше':
		cla
		if husband > 0 and hour < 17 and hour > 7 and boycherdaksex = 0: popolaini = 2 & gt 'sexm', 'popala'
		gt 'sexm', 'variant'
	end
end
if $ARGS[0] = 'strapon':
	*clr
	DOM += 5
	pegging += 1
	minut += 30
	horny += DOM
	bfA += 5
	gs 'brosok'
	gs 'stat'
	gs 'zz_render', '', 'images/picV/pegging.jpg', func('sexm_strings', 'local_str49')
	act 'Вытереть руки и проводить парня до дверей': gt 'korr'
end
if $ARGS[0] = 'anal':
	*clr
	popolaini = 3
	bfA += 1
	minut += 30
	anal += 1
	anala += 1
	if dickA < anus: anus += 1
	gs 'brosok'
	gs 'stat'
	'<center><img src="images/picV/dog2.jpg"></center>'
	if analplugin = 1:
		analpluginbonus = 10
		analplugin = 0
		if anus < 16:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str50')
		else
			gs 'zz_render', '', '', func('sexm_strings', 'local_str51')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str52')
		if anus + analpluginbonus < dick:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str53')
		elseif anus + analpluginbonus >= dick:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str54')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str55')
		gs 'zz_funcs', 'cum', 'ass'
		minut += 3
		gs 'zz_funcs', 'cum', 'anus'
		if anus < dickA:anus += 1
		horny += ((anus-dickA)*3)
		if horny < 1:horny = 1
		if horny >= 100:
			horny = 1
			orgasm += 1
			analorgasm += 1
			gs 'zz_render', '', '', func('sexm_strings', 'local_str56')
		end
		gs 'stat'
		act 'Проводить до дверей':gt'sexm','endsex'
	else
		if lubri = 0:
			lubonus = 2
			gs 'zz_render', '', '', func('sexm_strings', 'local_str57')
		else
			lubri -=  1
			lubonus = 10
			gs 'zz_render', '', '', func('sexm_strings', 'local_str58')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str59')
		if anus < 10:'Когда в вашу попку вошло три пальца вы невольно застонали от боли.'
		if anus >= 10:'Потом парень ввел вам три пальца и начал растягивать ваш анус.'
		gs 'zz_render', '', '', func('sexm_strings', 'local_str60')
		if anus + lubonus < dickA:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str61')
		elseif anus + lubonus >= dickA:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str62')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str63')
		if anus + lubonus + 2 < dickA:
			if mop > 1: mop = 0 & vidageday -= 1
			gs 'zz_render', '', '', func('sexm_strings', 'local_str64')
		elseif anus + lubonus + 2 >= dickA:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str65')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str66')
			bfA += 5
		gs 'zz_funcs', 'cum', 'anus'
		if anus < dickA:anus += 1
		horny += ((anus-dickA)*3)
		if horny < 1: horny = 1
		if horny >= 100:
			horny = 1
			orgasm += 1
			analorgasm += 1
			gs 'zz_render', '', '', func('sexm_strings', 'local_str68')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str69')
		if anus < dick:anus += 1
		gs'stat'
		act 'Проводить до дверей':lubonus = 0 & gt'sexm','endsex'
	end
end
if $ARGS[0] = 'miss':
	*clr
	popolaini = 3
	bfA += 1
	sex += 1
	sexa += 1
	minut += 30
	pose = 0
	$boy = $boyA
	dick = dickA
	silavag = silavagA
	gs'brosok'
	gs'stat'
	gs 'zz_render', '', 'images/picV/vag.jpg', func('sexm_strings', 'local_str70')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Проводить до дверей':gt'sexm','endsex'
end
if $ARGS[0] = 'dog':
	*clr
	popolaini = 3
	bfA += 1
	sex += 1
	sexa += 1
	minut += 30
	pose = 1
	$boy = $boyA
	dick = dickA
	silavag = silavagA
	gs 'brosok'
	gs 'stat'
	gs 'zz_render', '', 'images/picV/dog1.jpg', func('sexm_strings', 'local_str71')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Проводить до дверей':gt'sexm','endsex'
end
if $ARGS[0] = 'startPod':
	if RAND(0,1) = 0:
		gs 'zz_render', '', '', func('sexm_strings', 'local_str72')
		act 'Отвали!':
			cla
			DOM += 1
			bfA = 0
			gt 'street'
		end
		act 'Встать на корточки': gt 'sexm', 'blow'
	else
		gs 'zz_render', '', '', func('sexm_strings', 'local_str73')
		act 'Отвали!':
			cla
			DOM += 1
			bfA = 0
			gt 'street'
		end
		act 'Встать раком':gt'sexm','doggy'
	end
end
if $ARGS[0] = 'doggy':
	bfA += 1
	sex += 1
	sexa += 1
	minut += 30
	pose = 1
	$boy = $boyA
	dick = dickA
	silavag = silavagA
	gs 'brosok'
	gs 'stat'
	gs 'zz_render', '', 'images/picV/dog.jpg', func('sexm_strings', 'local_str74')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Поправить одежду и уйти': gt 'street'
end
if $ARGS[0] = 'blow':
	minut += 20
	gs'stat'
	gs 'zz_render', '', '', func('sexm_strings', 'local_str75')
	act 'Взять в рот':
		cla
		*clr
		bfA += 1
		bj += 1
		bja += 1
		dick = dickA
		harakBoy = harakBoyA
		minut += 30
		$boy = $boyA
		gs 'brosok'
		gs 'stat'
		gs 'zz_render', '', 'images/picV/bj0.jpg', func('sexm_strings', 'local_str76')
		gs 'zz_dynamic_sex', 'bj'
		act 'Продолжать сосать':
			cla
			*clr
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render', '', 'images/picV/swallow.jpg', func('sexm_strings', 'local_str77')
			act 'Уйти': gt 'street'
		end
		act 'Вынуть изо рта':
			cla
			*clr
			if harakBoyA = 0:
				gs 'zz_render', '', 'images/picV/hand.jpg', func('sexm_strings', 'local_str78')
			elseif harakBoyA = 1:
				if RAND(0,3) < 3:
					gs 'zz_render', '', 'images/picV/hand.jpg', func('sexm_strings', 'local_str79')
				else
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/facial.jpg', func('sexm_strings', 'local_str80')
				end
			elseif harakBoyA = 2:
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'images/picV/facial.jpg', func('sexm_strings', 'local_str81')
			end
			act 'Уйти': gt 'street'
		end
	end
	act 'Подрочить ему':
		cla
		*clr
		DOM += 1
		hj += 1
		hja += 1
		minut += 30
		horny += DOM
		gs'brosok'
		gs'stat'
		gs 'zz_render', '', 'images/picV/hand1.jpg', func('sexm_strings', 'local_str82')
		bfA -= iif(harakBoyA = 0,1,harakBoyA*5)
		act 'Вытереть руки и уйти': gt 'street'
	end
end
if $ARGS[0] = 'gangrape':
	gs 'zz_render', '', '', func('sexm_strings', 'local_str83')
	act 'Подчиниться': gt 'sexm', 'gangbang'
	act 'Начать драку': gt 'zz_fight',0
end
if $ARGS[0] = 'gangbang':
	bfa += iif(izvrat = 1, 5, (-1)*bfa)
	minut += 30
	gang += 1
	guy += 4
	bj += 4
	anal += 1
	sex += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	vagina += 1
	anus += 1
	throat += 1
	if mop > 1: mop = 0 & vidageday -= 1
	dom -= 3
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/picV/gangbang.jpg', func('sexm_strings', 'local_str84')
	act 'Стонать':
		cla
		*clr
		gs 'zz_render', '', 'images/picV/gangbang1.jpg', func('sexm_strings', 'local_str85')
		if anus >= 10:
			horny += 10
			gs 'zz_render', '', '', func('sexm_strings', 'local_str86')
		elseif anus < 10:
			horny += (10 - anus)
			gs 'zz_render', '', '', func('sexm_strings', 'local_str87')
		end
		if horny >= 90:
			orgasm += 1
			gs 'zz_render', '', '', func('sexm_strings', 'local_str88')
		end
		gs 'zz_render', '', '', func('sexm_strings', 'local_str89')
		act 'Встать на колени':
			cla
			*clr
			gs 'zz_render', '', 'images/picV/gangbang2.jpg', func('sexm_strings', 'local_str90')
			act 'Уйти': gt 'korr'
		end
	end
end
if $ARGS[0] = 'popala':
	cla
	*clr
	if popolaini = 1:
		gs 'zz_render', '', 'images/img/hasb/p0.jpg', func('sexm_strings', 'local_str91')
	elseif popolaini = 2:
		gs 'zz_render', '', 'images/img/hasb/p5.jpg', func('sexm_strings', 'local_str92')
	end
	if harakHusb = 0:
		gs 'zz_render', '', '', func('sexm_strings', 'local_str93')
		if izvratH = 0:
			husbizvradd = 0
			husbharmin = 0
			husbandMark = 0
			husband = 0
			divorced += 1
			gs 'zz_render', '', '', func('sexm_strings', 'local_str94')
			if harakBoyA = 0:
				bfA = 0
				gs 'zz_render', '', '', func('sexm_strings', 'local_str95')
				act 'Уйти': gt 'korr'
			elseif harakBoyA = 1:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str96')
				act 'Пусть уходит': gt 'korr'
				act 'Пусть останется':
					bfA += 1
					picrand = 83
					if popolaini = 3: picrand = 84
					xgt'sex','var'
				end
			elseif harakBoyA = 2:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str97')
				act 'Отказаться': bfA -= 1 & gt 'korr'
				act 'Продолжать':
					bfA += 2
					picrand = 83
					if popolaini = 3: picrand = 84
					xgt'sex','var'
				end
			end
		elseif izvratH = 1:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str98')
			if harakBoyA = 0:
				bfA = 0
				husbizvradd = 0
				husbharmin = 0
				husbandMark = 0
				husband = 0
				divorced += 1
				gs 'zz_render', '', '', func('sexm_strings', 'local_str99')
				act 'Уйти':gt'korr'
			elseif harakBoyA = 1:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str100')
				act 'Лечь':
					cla
					*clr
					gs 'zz_render', '', 'images/img/hasb/p1.jpg', func('sexm_strings', 'local_str101')
					act 'Продолжать':
						bfA += 1
						picrand = 39 + popolaini
						xgt'sexdvoe','var'
					end
				end
			elseif harakBoyA = 2:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str102')
				act 'Лечь':
					cla
					*clr
					gs 'zz_render', '', 'images/img/hasb/p2.jpg', func('sexm_strings', 'local_str103')
					act 'Продолжать':
						bfA += 1
						picrand = 39 + popolaini
						xgt'sexdvoe','var'
					end
				end
			end
		end
	elseif harakHusb = 1:
		husbizvradd = 0
		husbharmin = 0
		husbandMark = 0
		husband = 0
		divorced += 1
		gs 'zz_render', '', '', func('sexm_strings', 'local_str104')
		if izvratH = 0:
			gs 'zz_render', '', '', func('sexm_strings', 'local_str105')
			if harakBoyA = 0:
				bfA = 0
				gs 'zz_render', '', '', func('sexm_strings', 'local_str106')
				act 'Уйти':gt'korr'
			elseif harakBoyA = 1:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str107')
				act 'Пусть уходит':gt'korr'
				act 'Пусть останется':
					bfA += 1
					picrand = 83
					if popolaini = 3:picrand = 84
					xgt'sex','var'
				end
			elseif harakBoyA = 2:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str108')
				act 'Отказаться':bfA -= 1 & gt'korr'
				act 'Продолжать':
					bfA += 2
					picrand = 83
					if popolaini = 3:picrand = 84
					xgt'sex','var'
				end
			end
		elseif izvratH = 1:
			bfA = 0
			gs 'zz_render', '', '', func('sexm_strings', 'local_str109')
			if harakBoyA = 0:
				act 'Взять в рот':
					cla
					*clr
					gs 'zz_render', '', 'images/img/hasb/p3.jpg', func('sexm_strings', 'local_str110')
					act 'Уйти':gt'korr'
				end
			elseif harakBoyA = 1:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str111')
				act 'Лечь на кровать':
					cla
					*clr
					gs 'zz_render', '', 'images/img/hasb/p1.jpg', func('sexm_strings', 'local_str112')
					act 'Продолжать':
						picrand = 39 + popolaini
						xgt'sexdvoe','var'
					end
				end
			elseif harakBoyA = 2:
				gs 'zz_render', '', '', func('sexm_strings', 'local_str113')
				act 'Лечь на кровать':
					cla
					*clr
					gs 'zz_render', '', 'images/img/hasb/p2.jpg', func('sexm_strings', 'local_str114')
					act 'Продолжать':
						picrand = 39 + popolaini
						xgt'sexdvoe','var'
					end
				end
			end
		end
	elseif harakHusb = 2:
		fingal += 1
		gs 'zz_render', '', '', func('sexm_strings', 'local_str115')
		if izvratH = 0:
			husbizvradd = 0
			husbharmin = 0
			husbandMark = 0
			husband = 0
			divorced += 1
			bfA = 0
			mop = 0
			minut += 120
			stolmoney = 0
			money = 0
			komp = 0
			gs 'zz_render', '', '', func('sexm_strings', 'local_str116')
			act 'Уйти':gt'korr'
		else
			bfA = 0
			gs 'zz_render', '', '', func('sexm_strings', 'local_str117')
			if harakBoyA = 0: '<<$boyA>> попытался возразить, но увидев перекошенное яростью лицо вашего мужа согласился'
			if harakBoyA = 1: '<<$boyA>> молча согласился'
			if harakBoyA = 2: '<<$boyA>> с радостью согласился'
			act 'Продолжать':
				picrand = 39 + popolaini
				xgt 'sexdvoe', 'var'
			end
		end
	end
end
if $ARGS[0] = 'endsex':
	if husband > 0 and hour < 17 and hour > 7 and boycherdaksex = 0:gt'sexm','popala'
	boycherdaksex = 0
	gt'korr'
end