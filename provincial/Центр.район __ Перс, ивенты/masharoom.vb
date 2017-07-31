if $ARGS[0] = 'start':
	cla
	*clr
	gs'stat'
	if hour >= 7 and hour <= 20:
		gs 'zz_render', '', 'images/img/masha/r1.jpg', func('masharoom_strings', 'local_str1')
		act 'Подождать час':
			minut += 60
			if hour >= 7 and hour <= 20:gt'masharoom','start'
			if hour < 7 or hour > 20:gt'masharoom','0'
		end
		act 'Померить костюмы':
			cla
			*clr
			minut += 60
			mashroomrand = RAND(0,10)
			if mashroomrand = 10:gt'masharoom','1'
			if mashroomrand = 9:gt'masharoom','2'
			gs 'zz_render', '', 'images/img/masha/r2.jpg', func('masharoom_strings', 'local_str2')
			act 'Закончить':gt'masharoom','start'
		end
		act 'Уйти':gt'sexshop','podval'
	elseif hour < 7 or hour > 20:
		gt'masharoom','0'
	end
end
if $ARGS[0] = '0':
	gs'stat'
	cla
	*clr
	gs 'zz_render', '', 'images/img/masha/r0.jpg', func('masharoom_strings', 'local_str3')
	if month > 5 and temper > 20 and sunWeather >= 0:
		act 'Выгулять на поводке':
			cla
			*clr
			DOM += 1
			minut += 60
			gs 'zz_render', '', 'images/img/masha/r30.jpg', func('masharoom_strings', 'local_str4')
			act 'Заставить подметать улицу':
				cla
				*clr
				DOM += 1
				gs 'zz_render', '', 'images/img/masha/r31.jpg', func('masharoom_strings', 'local_str5')
				act 'Похвалить':
					cla
					*clr
					gs 'zz_render', '', 'images/img/masha/r32.jpg', func('masharoom_strings', 'local_str6')
					act 'Закончить':gt'masharoom','start'
				end
				act 'Наказать':
					cla
					*clr
					gs 'zz_render', '', 'images/img/masha/r33.jpg', func('masharoom_strings', 'local_str7')
					act 'Закончить':gt'masharoom','start'
				end
			end
			act 'Закончить':gt'masharoom','start'
		end
	end
	act 'Поиграть со свечкой':
		cla
		*clr
		minut += 60
		lesbian += 1
		DOM += 1
		gs 'zz_render', '', 'images/img/masha/r34.jpg', func('masharoom_strings', 'local_str8')
		act 'Приказать сосать':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r35.jpg', func('masharoom_strings', 'local_str9')
			act 'Налить воск в рот':
				cla
				*clr
				gs 'zz_render', '', 'images/img/masha/r36.jpg', func('masharoom_strings', 'local_str10')
				act 'Закончить':gt'masharoom','start'
			end
			act 'Налить воск на грудь':
				cla
				*clr
				orgasm += 1
				gs 'zz_render', '', 'images/img/masha/r37.jpg', func('masharoom_strings', 'local_str11')
				act 'Дать её полизать':
					cla
					*clr
					gs 'zz_render', '', 'images/img/masha/r38.jpg', func('masharoom_strings', 'local_str12')
					act 'Закончить':gt'masharoom','start'
				end
				act 'Удовлетворить друг друга':
					cla
					*clr
					gs 'zz_render', '', 'images/img/masha/r39.jpg', func('masharoom_strings', 'local_str13')
					act 'Закончить':gt'masharoom','start'
				end
			end
		end
		act 'Трахнуть её':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r40.jpg', func('masharoom_strings', 'local_str14')
			act 'Войти в неё':
				cla
				*clr
				gs 'zz_render', '', 'images/img/masha/r41.jpg', func('masharoom_strings', 'local_str15')
				act 'Закончить':gt'masharoom','start'
			end
		end
	end
	act 'Приказать лизать':
		cla
		*clr
		minut += 60
		lesbian += 1
		DOM += 1
		orgasm += 1
		gs 'zz_render', '', 'images/img/masha/r27.jpg', func('masharoom_strings', 'local_str16')
		act 'Продолжать':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r29.jpg', func('masharoom_strings', 'local_str17')
			act 'Закончить':gt'masharoom','start'
		end
		act 'Приказать лизать попку':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r28.jpg', func('masharoom_strings', 'local_str18')
			act 'Закончить':gt'masharoom','start'
		end
	end
	act 'Поиграть':
		cla
		*clr
		minut += 60
		DOM += 1
		lesbian += 1
		gs 'zz_render', '', 'images/img/masha/r42.jpg', func('masharoom_strings', 'local_str19')
		act 'Продолжить играть с грудью':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r44.jpg', func('masharoom_strings', 'local_str20')
			act 'Заняться её киской':
				cla
				*clr
				gs 'zz_render', '', 'images/img/masha/r'+RAND(49,51)+'.jpg', func('masharoom_strings', 'local_str21')
				act 'Далее':
					cla
					*clr
					orgasm += 1
					gs 'zz_render', '', 'images/img/masha/r64.jpg', func('masharoom_strings', 'local_str22')
					act 'Закончить':gt'masharoom','start'
				end
			end
		end
		act 'Пусть целует вашу грудь':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r45.jpg', func('masharoom_strings', 'local_str23')
			act 'Приказать лизать':
				cla
				*clr
				orgasm += 1
				gs 'zz_render', '', 'images/img/masha/r'+RAND(46,48)+'.jpg', func('masharoom_strings', 'local_str24')
				act 'Пусть продолжает':
					cla
					gs 'zz_render', '', '', func('masharoom_strings', 'local_str25')
					act 'Закончить':gt'masharoom','start'
				end
				act 'Взять страпон':
					cla
					*clr
					gs 'zz_render', '', 'images/img/masha/r'+RAND(53,54)+'.jpg', func('masharoom_strings', 'local_str26')
					act 'В киску':
						cla
						*clr
						gs 'zz_render', '', 'images/img/masha/r'+RAND(57,63)+'.jpg', func('masharoom_strings', 'local_str27')
						act 'Закончить':gt'masharoom','start'
					end
					act 'В попку':
						cla
						*clr
						gs 'zz_render', '', 'images/img/masha/r'+RAND(55,56)+'.jpg', func('masharoom_strings', 'local_str28')
						act 'Закончить':gt'masharoom','start'
					end
				end
			end
		end
		act 'Пусть ласкает вашу киску':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r43.jpg', func('masharoom_strings', 'local_str29')
			act 'Пусть продолжает':
				cla
				gs 'zz_render', '', '', func('masharoom_strings', 'local_str30')
				act 'Закончить':gt'masharoom','start'
			end
			act 'Приказать взять дилдо':
				cla
				*clr
				gs 'zz_render', '', 'images/img/masha/r52.jpg', func('masharoom_strings', 'local_str31')
				act 'Закончить':gt'masharoom','start'
			end
		end
	end
	act 'Уйти':gt'sexshop','podval'
end
if $ARGS[0] = '1':
	cla
	*clr
	gs'stat'
	gs 'zz_render', '', 'images/img/masha/r3.jpg', func('masharoom_strings', 'local_str32')
	act 'Закрыть дверь':gt'masharoom','start'
	act 'Дразнить':
		cla
		*clr
		horny += 20
		gs 'zz_render', '', 'images/img/masha/r4.jpg', func('masharoom_strings', 'local_str33')
		act 'Продолжать':
			cla
			orgasm += 1
			gs 'zz_render', '', '', func('masharoom_strings', 'local_str34')
			act 'Закончить':gt'masharoom','start'
		end
		act 'Позвать его':
			cla
			*clr
			kuni += 1
			gs 'zz_render', '', 'images/img/masha/r5.jpg', func('masharoom_strings', 'local_str35')
			act 'Пусть лижет зад':
				cla
				*clr
				gs 'zz_render', '', 'images/img/masha/r6.jpg', func('masharoom_strings', 'local_str36')
				act 'Дать':
					cla
					*clr
					guy += 1
					sex += 1
					gs 'zz_render', '', 'images/img/masha/r8.jpg', func('masharoom_strings', 'local_str37')
					act 'Закончить':gt'masharoom','start'
				end
				act 'Наказать':
					cla
					*clr
					DOM += 1
					gs 'zz_render', '', 'images/img/masha/r9.jpg', func('masharoom_strings', 'local_str38')
					act 'Закончить':gt'masharoom','start'
				end
			end
			act 'Сесть на лицо':
				cla
				*clr
				orgasm += 1
				gs 'zz_render', '', 'images/img/masha/r7.jpg', func('masharoom_strings', 'local_str39')
				act 'Взять в рот':
					cla
					*clr
					bj += 1
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_render', '', 'images/img/masha/r10.jpg', func('masharoom_strings', 'local_str40')
					act 'Закончить':gt'masharoom','start'
				end
				act 'Оседлать':
					cla
					*clr
					guy += 1
					sex += 1
					gs 'zz_render', '', 'images/img/masha/r11.jpg', func('masharoom_strings', 'local_str41')
					act 'Закончить':gt'masharoom','start'
				end
				act 'Дрочить руками':
					cla
					*clr
					hj += 1
					gs 'zz_render', '', 'images/img/masha/r12.jpg', func('masharoom_strings', 'local_str42')
					act 'Далее':
						cla
						*clr
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_funcs', 'cum', 'face'
						gs 'zz_render', '', 'images/img/masha/r14.jpg', func('masharoom_strings', 'local_str43')
						act 'Закончить':gt'masharoom','start'
					end
				end
				act 'Дрочить грудью':
					cla
					*clr
					gs 'zz_render', '', 'images/img/masha/r13.jpg', func('masharoom_strings', 'local_str44')
					act 'Далее':
						cla
						*clr
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_funcs', 'cum', 'face'
						gs 'zz_render', '', 'images/img/masha/r14.jpg', func('masharoom_strings', 'local_str45')
						act 'Закончить':gt'masharoom','start'
					end
				end
			end
		end
	end
end
if $ARGS[0] = '2':
	cla
	*clr
	guy += 1
	gs'stat'
	gs 'zz_render', '', 'images/img/masha/r20.jpg', func('masharoom_strings', 'local_str46')
	act 'Продолжать просить освободить вас':
		cla
		*clr
		mop = 0
		rape += 1
		anal += 1
		gs 'zz_render', '', 'images/img/masha/r21.jpg', func('masharoom_strings', 'local_str47')
		act 'Терпеть':
			cla
			gs 'zz_funcs', 'cum', 'anus'
			gs 'zz_render', '', '', func('masharoom_strings', 'local_str48')
			act 'Закончить':gt'masharoom','start'
		end
		act 'Просить отпустить':
			cla
			*clr
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_funcs', 'cum', 'face'
			spank += 1
			bj += 1
			swallow += 1
			gs 'zz_render', '', 'images/img/masha/r22.jpg', func('masharoom_strings', 'local_str49')
			act 'Закончить':gt'masharoom','start'
		end
	end
	act 'Подчиниться':
		cla
		*clr
		dom -= 2
		bj += 1
		swallow += 1
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_render', '', 'images/img/masha/r23.jpg', func('masharoom_strings', 'local_str50')
		act 'Подчиниться':
			cla
			*clr
			gs 'zz_render', '', 'images/img/masha/r24.jpg', func('masharoom_strings', 'local_str51')
			act 'Повернуться':
				cla
				*clr
				anal += 1
				orgasm += 1
				analorgasm += 1
				gs 'zz_render', '', 'images/img/masha/r25.jpg', func('masharoom_strings', 'local_str52')
				act 'Открыть рот':
					cla
					*clr
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					gs 'zz_render', '', 'images/img/masha/r26.jpg', func('masharoom_strings', 'local_str53')
					act 'Закончить':gt'masharoom','start'
				end
			end
		end
	end
end