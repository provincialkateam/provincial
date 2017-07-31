if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	gs 'stat'
	gs 'zz_render', 'Салон красоты', 'images/img/centr/salon.jpg', func('worksalon_strings', 'local_str1')
	salonjobrand = RAND(0,10)
	if salonjobrand = 2 and vnesh >= 40 and alla = 0:
		gt'worksalon','2'
	elseif salonjobrand = 3 and salonslut = 1:
		cla
		gs 'zz_render', '', '', func('worksalon_strings', 'local_str2')
		if DOM >= 10:
			act 'Пошел вон утырок':salonslut = 0 & gt'worksalon','start'
			act 'Идти с ним':gt'worksalon','3'
		elseif DOM < 10:
			act 'Идти с ним':gt'worksalon','3'
		end
	end
	act 'Делать массаж':
		minut += 120
		if salonjobrand = 0:gt'worksalon','0'
		if salonjobrand = 1:gt'worksalon','1'
		gs 'zz_render', '', '', func('worksalon_strings', 'local_str3')
		gt 'worksalon','start'
	end
	act 'Перекусить':
		gs 'zz_kitchen_acts', 'eat'
		gs 'zz_kitchen_acts', 'drink', 'tea'
		gs 'stat'
	end
	if masha > 0:
		act 'Болтать с Машей':
			cla
			minut += 30
			masha += 1
			gs 'zz_render', '', '', func('worksalon_strings', 'local_str4')
			act 'Отойти':gt'worksalon','start'
		end
		if masharab = 1:
			act 'Приказать Маше сделать массаж':
				*clr & cla
				DOM += 1
				minut += 30
				manna += 10
				horny += 10
				gs 'zz_render', '', 'images/img/masha/s7.jpg', func('worksalon_strings', 'local_str5')
				act 'Приказать массировать телом':
					*clr & cla
					minut += 30
					manna += 10
					horny += 10
					picrand = RAND(8,9)
					gs 'zz_render', '', 'images/img/masha/s<<picrand>>.jpg', func('worksalon_strings', 'local_str'+iif(picrand = 8,6,7))
					act 'Приказать лизать киску':
						*clr & cla
						DOM += 1
						lesbian += 1
						orgasm += 1
						horny = 0
						gs 'zz_render', '', 'images/img/masha/s10.jpg', func('worksalon_strings', 'local_str8')
						act 'Закончить':gt'worksalon','start'
					end
					act 'Приказать лизать попку':
						*clr & cla
						DOM += 1
						lesbian += 1
						orgasm += 1
						horny = 0
						gs 'zz_render', '', 'images/img/masha/s11.jpg', func('worksalon_strings', 'local_str9')
						act 'Закончить': gt'worksalon','start'
					end
					act 'Закончить': gt'worksalon','start'
				end
				act 'Приказать лизать киску':
					*clr & cla
					DOM += 1
					lesbian += 1
					orgasm += 1
					horny = 0
					gs 'zz_render', '', 'images/img/masha/s10.jpg', func('worksalon_strings', 'local_str10')
					act 'Закончить':gt'worksalon','start'
				end
				act 'Приказать лизать попку':
					*clr & cla
					DOM += 1
					lesbian += 1
					orgasm += 1
					horny = 0
					gs 'zz_render', '', 'images/img/masha/s11.jpg', func('worksalon_strings', 'local_str11')
					act 'Закончить': gt'worksalon','start'
				end
				act 'Закончить': gt'worksalon','start'
			end
		elseif masha > 5 and masharab = 0:
			act 'Попросить Машу сделать массаж':
				cla
				gs 'zz_render', '', '', func('worksalon_strings', 'local_str12')
				act 'Ну нафиг эту больную':gt'worksalon','start'
				act 'Идти в кабинку':
					*clr & cla
					masharab = 1
					minut += 30
					manna += 10
					horny += 10
					gs 'zz_render', '', 'images/img/masha/s1.jpg', func('worksalon_strings', 'local_str13')
					act 'Перевернуться':
						*clr & cla
						manna += 10
						horny += 10
						gs 'zz_render', '', 'images/img/masha/s2.jpg', func('worksalon_strings', 'local_str14')
						act 'Поговорить с ней':
							*clr & cla
							gs 'zz_render', '', 'images/img/masha/s5.jpg', func('worksalon_strings', 'local_str15')
							act 'Уйти':gt'worksalon','start'
						end
						act 'Приказать лизать киску':
							*clr & cla
							DOM += 1
							lesbian += 1
							orgasm += 1
							horny = 0
							gs 'zz_render', '', 'images/img/masha/s6.jpg', func('worksalon_strings', 'local_str16')
							act 'Поговорить с ней':
								*clr & cla
								gs 'zz_render', '', 'images/img/masha/s5.jpg', func('worksalon_strings', 'local_str17')
								act 'Уйти':gt'worksalon','start'
							end
						end
					end
					act 'Спросить почему она так говорит':
						cla
						gs 'zz_render', '', '', func('worksalon_strings', 'local_str18')
						act 'Поговорить с ней':
							cla
							gs 'zz_render', '', 'images/img/masha/s5.jpg', func('worksalon_strings', 'local_str19')
							act 'Уйти':gt'worksalon','start'
						end
						act 'Приказать лизать киску':
							*clr & cla
							DOM += 1
							lesbian += 1
							orgasm += 1
							horny = 0
							gs 'zz_render', '', 'images/img/masha/s3.jpg', func('worksalon_strings', 'local_str20')
							act 'Поговорить с ней':
								*clr & cla
								gs 'zz_render', '', 'images/img/masha/s5.jpg', func('worksalon_strings', 'local_str21')
								act 'Уйти':gt'worksalon','start'
							end
						end
						act 'Приказать лизать попку':
							*clr & cla
							DOM += 1
							lesbian += 1
							orgasm += 1
							horny = 0
							gs 'zz_render', '', 'images/img/masha/s4.jpg', func('worksalon_strings', 'local_str22')
							act 'Поговорить с ней':
								*clr & cla
								gs 'zz_render', '', 'images/img/masha/s5.jpg', func('worksalon_strings', 'local_str23')
								act 'Уйти':gt'worksalon','start'
							end
						end
					end
				end
			end
		end
	end
	if hour >= 19:
		*clr & cla
		gs 'zz_render', 'Салон', 'images/img/centr/salon.jpg', func('worksalon_strings', 'local_str24')
		act 'Идти домой':gt'down'
	end
end
if $ARGS[0] = '0':
	*clr & cla
	salonpicrand = RAND(0,4)
	picrand = salonpicrand + 30
	gs 'zz_render', '', 'images/img/centr/wmass<<salonpicrand>>.jpg', func('worksalon_strings', 'local_str25')
	act 'Закончить массаж':gt'worksalon','start'
	act 'Взять в рот':guy += 1 & gt'sex','minet'
end
if $ARGS[0] = '1':
	gs 'zz_render', '', '', func('worksalon_strings', 'local_str26')
	act 'Отказаться':gt'worksalon','start'
	act 'Сходить за второй девушкой':
		*clr & cla
		money += 1000
		gs 'zz_render', '', 'images/img/centr/wmass5.jpg', func('worksalon_strings', 'local_str27')
		act 'Перестать дрочить и спокойно закончить массаж':
			cla
			gs 'zz_render', '', '', func('worksalon_strings', 'local_str28')
			act 'Выйти':gt'worksalon','start'
		end
		act 'Взять в рот':
			girl += 1
			guy += 1
			lesbian += 1
			picrand = 14
			gt'podrsex','var'
		end
	end
end
if $ARGS[0] = '2':
	*clr & cla
	gs 'zz_render', '', 'images/img/centr/ira1.jpg', func('worksalon_strings', 'local_str29')
	act 'Оттолкнуть и уйти':gt'worksalon','start'
	act 'Позволить ей':
		*clr & cla
		girl += 1
		lesbian += 1
		telalla = 1
		alla += 1
		orgasm += 3
		gs 'zz_render', '', 'images/img/centr/ira2.jpg', func('worksalon_strings', 'local_str30')
		act 'Позволить уйти':gt'worksalon','start'
		act 'Отблагодарить':
			*clr & cla
			gs 'zz_render', '', 'images/img/centr/ira3.jpg', func('worksalon_strings', 'local_str31')
			if DOM >= 10:
				act 'Пошел вон утырок, с кем хочу с тем и трахаюсь':gt'worksalon','start'
				act 'Идти с ним': salonslut = 1 & gt'worksalon','3'
			else
				act 'Идти с ним': salonslut = 1 & gt'worksalon','3'
			end
		end
	end
end
if $ARGS[0] = '3':
	minut += 15
	dom -= 1
	guy += 1
	sex += 1
	gs 'zz_funcs', 'cum', 'ass'
	vagina += 1
	gs 'zz_render', '', 'images/img/centr/raks.jpg', func('worksalon_strings', 'local_str32')
	act 'Уйти':gt'worksalon','start'
end