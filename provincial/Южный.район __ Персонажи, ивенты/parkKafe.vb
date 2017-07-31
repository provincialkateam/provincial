if $ARGS[0] = 'food':
	if money < 400:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str1')
		act 'Уйти': gt 'zz_park'
		exit
	end
	cla
	money -= 400
	gs 'zz_kitchen_acts', 'eat', 'lunch','',func('parc_kafe_strings', 'local_str5')
	gs 'zz_kitchen_acts', 'drink', 'tea'
	arand = RAND(1,7)
	$zz_str = 'Вы осматриваете посетителей кафе и замечаете '
	if arand = 1: $zz_str + 'компанию гуляющей <a href="exec:GT ''parkKafe'',''молодеж''">молодежи</a>'
	if arand = 2: $zz_str + 'одиноко сидящего молодого <a href="exec:GT ''parkKafe'',''парень''">парня</a>'
	if arand = 3: $zz_str + 'кампанию студентов <a href="exec:GT ''parkKafe'',''негры''">африканцев</a>'
	if arand = 4: $zz_str + '<a href="exec:GT ''parkKafe'',''женщина''">женщину</a> властного вида'
	if arand = 5: $zz_str + 'солидного <a href="exec:GT ''parkKafe'',''мужчина''">мужчину</a> в возрасте'
	if arand = 6: $zz_str + 'двух <a href="exec:GT ''parkKafe'',''армяне''">армян</a> сидящих за столом'
	if arand = 7: $zz_str + 'двух <a href="exec:GT ''parkKafe'',''парни''">парней спортивного вида</a> сидящих за столом и пьющих пиво'
	killvar '$zz_str'
	gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str5')
	act 'Уйти':gt'zz_park','main'
end
if $ARGS[0] = 'парни':
	cla
	if rand(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str6')
		act 'Идти домой': gt 'zz_park'
	else
		if parkara > 0:
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str7')
			act 'Уйти': gt 'zz_park'
		elseif parkara = 0:
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str8')
			act 'Уйти': gt 'zz_park'
			act 'Попить пива с парнями':
				cla
				gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str9')
				if rand(1,2) = 1:
					if parkara = 0: guy += 2 & parkara = 1
					sex += 1
					bj += 2
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_render', '', 'images/klof/022.jpg', func('parc_kafe_strings', 'local_str10')
					gs 'zz_funcs', 'hornyrand'
					gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str11')
					act 'Познакомиться':gt'parkKafe','klof 1'
				else
					if parkara = 0: guy += 2 & parkara = 1
					sex += 1
					vagina += 1
					gang += 1
					gs 'zz_funcs', 'cum', 'ass'
					anus += 1
					anal += 1
					gs 'zz_render', '', 'images/klof/004.jpg', func('parc_kafe_strings', 'local_str12')
					gs 'zz_funcs', 'hornyrand'
					gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str13')
					gs 'zz_funcs', 'cum', 'pussy'
					act 'Познакомиться':gt'parkKafe','klof 1'
				end
			end
		end
	end
end
if $ARGS[0] = 'klof 1':
	cla
	*clr
	minut += 5
	klofQW = 1
	gs'stat'
	gs 'zz_render', '', 'images/klof/11_1.jpg', func('parc_kafe_strings', 'local_str14')
	act 'Да':gt'event','klof 2'
	act 'Уйти':gt'zz_park','main'
end
if $ARGS[0] = 'армяне':
	cla
	if RAND(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str15')
		act 'Идти домой':gt'zz_park','main'
	else
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str16')
		act 'Уйти':gt'zz_park','main'
		act 'Выпить вместе':
			cla
			*clr
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str17')
			if RAND(1,2) = 1:
				if parkarman = 0:guy += 2 & parkarman = 1
				bj += 2
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_render', '', 'images/pics2/ara.jpg', func('parc_kafe_strings', 'local_str18')
				gs 'zz_funcs', 'hornyrand'
				gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str19')
				act 'Уйти':gt'zz_park','main'
			else
				if parkarman = 0: guy += 2 & parkarman = 1
				sex += 1
				bj += 1
				gang += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'ass'
				vagina += 1
				gs 'zz_render', '', 'images/pics2/ara2.jpg', func('parc_kafe_strings', 'local_str20')
				gs 'zz_funcs', 'hornyrand'
				gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str21')
				act 'Уйти':gt'zz_park','main'
			end
		end
	end
end
if $ARGS[0] = 'мужчина':
	cla
	if RAND(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str22')
		act 'Уйти':gt'zz_park','main'
	else
		cla
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str23')
		act 'Танцевать':
			cla
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str24')
			act 'В сауну':
				cla
				if saunasex = 0: saunasex = 1 & guy += 1
				sex += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'ass'
				horny = 0
				vagina += 1
				gs 'zz_render', '', 'images/pics2/sauna.jpg', func('parc_kafe_strings', 'local_str25')
				gs 'zz_funcs', 'hornyrand'
				act 'Уйти':gt'street'
			end
		end
		act 'Уйти':gt'zz_park','main'
	end
end
if $ARGS[0] = 'женщина':
	cla
	gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str26')
	act 'Уйти':gt'zz_park','main'
end
if $ARGS[0] = 'молодеж':
	cla
	if rand(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str27')
		act 'Уйти':gt'zz_park','main'
	else
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str28')
		act 'Уйти':gt'zz_park','main'
		act 'Компания':
			cla
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str29')
			act 'Уйти':gt'zz_park','main'
			act 'Ехать вместе со всеми':
				cla
				*clr
				gs 'zz_render', '', 'images/pics2/Student.jpg', func('parc_kafe_strings', 'local_str30')
				act 'Уйти':gt'zz_park','main'
				act 'Встать на колени рядом с девушкой в круг из парней':
					cla
					*clr
					hour = 22
					son = 0
					if studentsex = 0: studentsex = 1 & guy += 6
					bj += 6
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 6
					gs 'zz_render', '', 'images/pics2/Student2.jpg', func('parc_kafe_strings', 'local_str31')
					act 'Целоваться с девушкой':
						cla
						*clr
						gs 'zz_render', '', 'images/pics2/Student3.jpg', func('parc_kafe_strings', 'local_str32')
						act 'Уйти':gt'street'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'негры':
	cla
	rrand = RAND(1,2)
	if rrand = 1 or afra >= 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str33')
		act 'Уйти': gt'zz_park','main'
	elseif rrand = 2 and afra = 0:
		afra = 1
		obs = 1
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str34')
		act 'Уйти':gt'zz_park','main'
	end
end
if $ARGS[0] = 'парень':
	cla
	rrand = RAND(1,2)
	if rrand = 1 and gosh = 0:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str35')
		act 'Уйти': gt 'zz_park'
	elseif gosh = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str36')
		act 'Уйти': gt 'zz_park'
	elseif rrand = 2 and gosh = 0:
		gosh = 1
		obs = 1
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str37')
		act 'Уйти': gt 'zz_park'
	end
end