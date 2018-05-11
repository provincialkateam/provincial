if $ARGS[0] = 'kinosvid':
	*clr & cla
	minut += 60
	manna += 10
	bfA += 3
	gs 'stat'
	gs 'zz_render', '', 'images/img/boysvid/kino0.jpg', func('svidboy_strings', 'local_str1')
	act 'Смотреть кино':
		*clr & cla
		minut += 90
		gs 'zz_render', '', 'images/img/boysvid/kino1.jpg', func('svidboy_strings', 'local_str2')
		act 'Не здесь':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/kino0.jpg', func('svidboy_strings', 'local_str3')
			act 'Уйти':gt'center'
		end
		act 'Расстегнуть ему ширинку':
			*clr & cla
			picrand = 48
			svidboysex = 1
			svidboykino = 1
			bfA += 5
			gs 'zz_render', '', 'images/img/boysvid/kino2.jpg', func('svidboy_strings', 'local_str4')
			act 'Взять в рот':gt'sex','minet'
		end
	end
end
if $ARGS[0] = 'parksvid':
	*clr & cla
	minut += 60
	manna += 10
	bfA += 3
	gs 'stat'
	gs 'zz_render', '', 'images/img/boysvid/park0.jpg', func('svidboy_strings', 'local_str5')
	act 'Идти гулять':
		if RAND(0,1) = 1: gt 'svidboy', 'parksvid2'
		*clr & cla
		minut += 60
		gs 'zz_render', '', 'images/img/boysvid/park1.jpg', func('svidboy_strings', 'local_str6')
		act 'Идти дальше':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/park0.jpg', func('svidboy_strings', 'local_str7')
			act 'Уйти':gt'zz_park','main'
		end
		act 'Поцеловать его':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/park2.jpg', func('svidboy_strings', 'local_str8')
			act 'Прекратить':
				*clr & cla
				gs 'zz_render', '', 'images/img/boysvid/park0.jpg', func('svidboy_strings', 'local_str9')
				act 'Уйти':gt'zz_park','main'
			end
			act 'Продолжать':
				*clr & cla
				horny += 20
				gs 'zz_render', '', 'images/img/boysvid/park3.jpg', func('svidboy_strings', 'local_str10')
				act 'Прекратить':
					*clr & cla
					gs 'zz_render', '', 'images/img/boysvid/park0.jpg', func('svidboy_strings', 'local_str11')
					act 'Уйти':gt'zz_park','main'
				end
				act 'Продолжать':
					*clr & cla
					gs 'zz_render', '', 'images/img/boysvid/park4.jpg', func('svidboy_strings', 'local_str12')
					act 'Продолжать':
						picrand = 49
						svidboysex = 1
						svidboypark = 1
						bfA += 5
						gt'sex','kuni'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'parksvid2':
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', 'images/img/boysvid/park5.jpg', func('svidboy_strings', 'local_str13')
	if izvrat = 1:
		gs 'zz_render', '', '', func('svidboy_strings', 'local_str14')
		act 'Отказаться':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/park6.jpg', func('svidboy_strings', 'local_str15')
			act 'Уйти':gt'zz_park','main'
		end
		act 'Согласиться':
			picrand = 50
			svidboysex = 1
			svidboypark1 = 1
			bfA += 5
			gt'sex','minet'
		end
	end
	gs 'zz_render', '', '', func('svidboy_strings', 'local_str16')
	act 'Заняться сексом':
		*clr & cla
		gs 'zz_render', '', 'images/img/boysvid/park9.jpg', func('svidboy_strings', 'local_str17')
		act 'Минет':
			picrand = 50
			svidboysex = 1
			svidboypark2 = 1
			bfA += 5
			gt'sex','minet'
		end
	end
	act 'Отбросить эту мысль и идти дальше':
		*clr & cla
		gs 'zz_render', '', 'images/img/boysvid/park6.jpg', func('svidboy_strings', 'local_str18')
		act 'Уйти':gt'zz_park','main'
	end
end
if $ARGS[0] = 'parksvid21':
	*clr & cla
	gs 'zz_render', '', 'images/img/boysvid/park7.jpg', func('svidboy_strings', 'local_str19')
	act 'Отказаться':
		*clr & cla
		gs 'zz_render', '', 'images/img/boysvid/park6.jpg', func('svidboy_strings', 'local_str20')
		act 'Уйти':gt'zz_park','main'
	end
	act 'Согласиться':
		*clr & cla
		bfA += 5
		bj += 1
		swallow += 1
		gs 'zz_render', '', 'images/img/boysvid/park8.jpg', func('svidboy_strings', 'local_str21')
		act 'Уйти':gt'zz_park','main'
	end
end
if $ARGS[0] = 'parksvid22':
	*clr & cla
	gs 'zz_render', '', 'images/img/boysvid/park7.jpg', func('svidboy_strings', 'local_str22')
	act 'Успокоить его':
		*clr & cla
		gs 'zz_render', '', 'images/img/boysvid/park6.jpg', func('svidboy_strings', 'local_str23')
		act 'Уйти':gt'zz_park','main'
	end
	act 'Позлить его':
		*clr & cla
		bfa = 0
		bj += 1
		swallow += 1
		gs 'zz_render', '', 'images/img/boysvid/park8.jpg', func('svidboy_strings', 'local_str24')
		act 'Уйти':gt'zz_park','main'
	end
end
if $ARGS[0] = 'billsvid':
	*clr & cla
	minut += 60
	manna += 10
	bfA += 3
	gs 'stat'
	picrand = RAND(51,52)
	gs 'zz_render', '', 'images/img/boysvid/bil<<picrand>>.jpg', func('svidboy_strings', 'local_str25')
	act 'Играть':
		*clr & cla
		minut += 60
		gs 'zz_render', '', 'images/img/boysvid/bil1<<picrand>>.jpg', func('svidboy_strings', 'local_str26')
		act 'Не здесь':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/bil0<<picrand>>.jpg', func('svidboy_strings', 'local_str27')
			act 'Уйти':gt'center'
		end
		act 'Пусть продолжает':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/bil2<<picrand>>.jpg', func('svidboy_strings', 'local_str28')
			act 'Пусть продолжает':
				svidboysex = 1
				svidboykino = 1
				bfA += 5
				gt'sex','kuni'
			end
			act 'Стоп, хватит':
				*clr & cla
				gs 'zz_render', '', 'images/img/boysvid/bil0<<picrand>>.jpg', func('svidboy_strings', 'local_str29')
				act 'Уйти':gt'center'
			end
		end
	end
end
if $ARGS[0] = 'kafesvid':
	*clr & cla
	minut += 60
	manna += 10
	bfA += 3
	gs 'stat'
	gs 'zz_render', '', 'images/img/boysvid/kafe0.jpg', func('svidboy_strings', 'local_str30')
	act 'Ждать заказ':
		*clr & cla
		minut += 60
		gs 'zz_render', '', 'images/img/boysvid/kafe1.jpg', func('svidboy_strings', 'local_str31')
		act 'Не здесь':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/kafe0.jpg', func('svidboy_strings', 'local_str32')
			act 'Уйти':gt'center'
		end
		act 'Пусть продолжает':
			*clr & cla
			gs 'zz_render', '', 'images/img/boysvid/kafe2.jpg', func('svidboy_strings', 'local_str33')
			act 'Пусть продолжает':
				svidboysex = 1
				svidboykafe = 1
				bfA += 5
				picrand = 53
				gt'sex','kuni'
			end
			act 'Стоп, хватит':
				*clr & cla
				gs 'zz_render', '', 'images/img/boysvid/kafe0.jpg', func('svidboy_strings', 'local_str34')
				act 'Уйти':gt'center'
			end
		end
	end
end