$metka = $ARGS[0]
$loc = $CURLOC
if $ARGS[0] = 'pos1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/solar1.jpg', func('etoexhib_strings', 'local_str1')
	act 'Закрыть дверь':
		*clr & cla
		gs 'zz_render', '', 'images/etogame/solar8.jpg', func('etoexhib_strings', 'local_str2')
		act 'Далее':
			*clr & cla
			manna += 10
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/solar9.jpg', func('etoexhib_strings', 'local_str3')
			act 'Уйти':gt'salon','start'
		end
	end
	act 'Оставить дверь приоткрытой':
		*clr & cla
		manna += 10
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/solar1.jpg', func('etoexhib_strings', 'local_str4')
		act 'Раздеваться':
			*clr & cla
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/solar2.jpg', func('etoexhib_strings', 'local_str5')
			act 'Раздеться догола':
				*clr & cla
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'images/etogame/solar4.jpg', func('etoexhib_strings', 'local_str6')
				act 'Раздвинуть ноги':
					*clr & cla
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'images/etogame/solar5.jpg', func('etoexhib_strings', 'local_str7')
					act 'Мастурбировать':
						*clr & cla
						horny += 20
						gs 'stat'
						gs 'zz_render', '', 'images/etogame/solar6.jpg', func('etoexhib_strings', 'local_str8')
						act 'Далее':
							*clr & cla
							orgasm += 1
							horny -= 50
							manna = 100
							if exhibi = 2:exhibi = 3
							gs 'stat'
							gs 'zz_render', '', 'images/etogame/solar7.jpg', func('etoexhib_strings', 'local_str9')
							act 'Уйти':gt'salon','start'
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'pos2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1dachi.jpg', func('etoexhib_strings', 'local_str10')
	if etoexhib = 0:'Вас никто здесь не знает и у дачников не сложилось никакого мнения о вас.'
	if etoexhib = 10:'Идти на <a href="exec:GT ''etoexhib'',''pos9''">лязг пилы</a>.'
	act 'Идти в лес':gt'etoexhib','pos3'
	act 'Спуститься к озеру':gt'etoexhib','pos16'
	act 'Уйти':gt'dachi'
end
if $ARGS[0] = 'pos3':
	*clr & cla
	minut += 5
	gs 'stat'
	foresrand = RAND(1,100)
	gs 'zz_render', '', 'images/etogame/1fores.jpg', func('etoexhib_strings', 'local_str11')
	if foresrand < 30:
		*clr & cla
		gs 'zz_render', '', 'images/etogame/1fores.jpg', func('etoexhib_strings', 'local_str12')
		act 'Привлечь его внимание':gt'etoexhib','pos4'
	elseif foresrand > 90 and exhibi > 2:
		*clr & cla
		gs 'zz_render', '', 'images/etogame/1fores.jpg', func('etoexhib_strings', 'local_str13')
		act 'Раздеться':gt'etoexhib','pos5'
	end
	act 'Уйти':gt'dachi'
end
if $ARGS[0] = 'pos4':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('etoexhib_strings', 'local_str14')
	act 'Показать киску':
		*clr & cla
		minut += 5
		horny += 10
		if exhibi = 2: exhibi = 3
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/2fores.jpg', func('etoexhib_strings', 'local_str15')
		act 'Убежать': gt'dachi'
	end
end
if $ARGS[0] = 'pos5':
	*clr & cla
	minut += 5
	horny += 10
	if exhibi = 3:exhibi = 4
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/3fores.jpg', func('etoexhib_strings', 'local_str16')
	act 'Далее':
		*clr & cla
		gs 'zz_render', '', 'images/etogame/4fores.jpg', func('etoexhib_strings', 'local_str17')
		act 'Уйти':gt'dachi'
	end
end
if $ARGS[0] = 'pos6':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/rodnik.jpg', func('etoexhib_strings', 'local_str18')
	act 'Попить':
		gs 'zz_kitchen_acts', 'drink', 'water'
		act 'Уйти':gt'dachi'
	end
end
if $ARGS[0] = 'pos7':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/stolbik.jpg', func('etoexhib_strings', 'local_str19')
	if money >= 300:
		act 'Купить молока':
			*clr & cla
			money -= 300
			gs 'zz_kitchen_acts', 'eat','',func('etoexhib_strings', 'local_str21')
			gs 'stat'
			act 'Уйти':gt'dachi'
		end
	end
	act 'Уйти': gt'dachi'
end
if $ARGS[0] = 'pos8':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachakuz.jpg', func('etoexhib_strings', 'local_str23')
	if etoexhib < 10:
		act 'Окликнуть соседей':
			*clr & cla
			minut += 15
			etoexhib = 10
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/kuzmich.jpg', func('etoexhib_strings', 'local_str24')
			act 'Уйти': gt'dachi'
		end
		act 'Уйти': gt'dachi'
	end
	act 'Уйти': gt'dachi'
end
if $ARGS[0] = 'pos9':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachastroy.jpg', func('etoexhib_strings', 'local_str25')
	act 'Спросить рабочих о земляных работах':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/dachastroy.jpg', func('etoexhib_strings', 'local_str26')
		act 'Согласиться':
			*clr & cla
			etoexhib = 11
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/dachastroy.jpg', func('etoexhib_strings', 'local_str27')
			act 'Уйти':gt'dachi'
		end
		act 'Уйти':gt'dachi'
	end
	act 'Уйти':gt'dachi'
end
if $ARGS[0] = 'pos10':
	*clr & cla
	minut += 30
	horny += 10
	temp = day
	etoexhib = 12
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachabust.jpg', func('etoexhib_strings', 'local_str28')
	act 'Уйти': gt'dachi','dachamy'
end
if $ARGS[0] = 'pos11':
	*clr & cla
	minut += 15
	etoexhib = 13
	horny += 10
	temp = day
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachaex.jpg', func('etoexhib_strings', 'local_str29')
	act 'Уйти в дом': gt'dachi','dachamy'
end
if $ARGS[0] = 'pos12':
	*clr & cla
	minut += 15
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachabust2.jpg', func('etoexhib_strings', 'local_str30')
	act 'Подойти к рабочим':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/dachabust3.jpg', func('etoexhib_strings', 'local_str31')
		act 'Не согласиться':
			*clr & cla
			etoexhib = 15
			temp = day
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/dachabust3.jpg', func('etoexhib_strings', 'local_str32')
			act 'Уйти': gt'dachi'
		end
		act 'Согласиться и дать половину суммы':
			*clr & cla
			money -= 1500
			etoexhib = 14
			temp = day
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/dachabust3.jpg', func('etoexhib_strings', 'local_str33')
			act 'Уйти': gt'dachi'
		end
	end
	act 'Уйти':gt'dachi'
end
if $ARGS[0] = 'pos13':
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachagang.jpg', func('etoexhib_strings', 'local_str34')
	act 'Раздеться полностью':
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/dachagang1.jpg', func('etoexhib_strings', 'local_str35')
		act 'Отдаться':
			*clr & cla
			minut += 120
			etoexhib = 16
			horny += 50
			gang += 1
			gs 'zz_funcs', 'cum', 'ass'
			gs 'zz_funcs', 'cum', 'lip'
			vagina += 1
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/dachagang4.jpg', func('etoexhib_strings', 'local_str36')
			gs 'zz_funcs', 'hornyrand'
			gs 'zz_render', '', '', func('etoexhib_strings', 'local_str37')
			act 'Далее':gt 'dachi','dachain'
		end
	end
end
if $ARGS[0] = 'pos14':
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/dachagang2.jpg', func('etoexhib_strings', 'local_str38')
	act 'Далее':
		*clr & cla
		gs 'zz_render', '', 'images/etogame/dachagang3.jpg', func('etoexhib_strings', 'local_str39')
		act 'Отдаться':
			*clr & cla
			minut += 120
			etoexhib = 16
			horny += 50
			gang += 1
			gs 'zz_funcs', 'cum', 'ass'
			gs 'zz_funcs', 'cum', 'lip'
			vagina += 1
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/dachagang4.jpg', func('etoexhib_strings', 'local_str40')
			gs 'zz_funcs', 'hornyrand'
			gs 'zz_render', '', '', func('etoexhib_strings', 'local_str41')
			act 'Далее':gt 'dachi','dachain'
		end
	end
end
if $ARGS[0] = 'pos16':
	*clr & cla
	gs 'stat'
	gs 'zz_render', 'Озеро', 'images/etogame/lake.jpg'
	if temper >= 20 and hour >= 6 and hour <= 20:
		act 'Купаться в купальнике':
			*clr & cla
			cumpussy = 0
			cumbelly = 0
			cumass = 0
			cumlip = 0
			cumface = 0
			cumfrot = 0
			minut += 60
			sweat = -3
			manna += 5
			if stren < 30:stren += 1
			gs 'zz_render', '', 'images/pics/swim.jpg', func('etoexhib_strings', 'local_str44')
			act 'Выйти из воды':gt'etoexhib','pos16'
		end
	end
	if temper >= 20 and hour >= 6 and hour <= 20:
		act 'Купаться голышом':
			*clr & cla
			cumpussy = 0
			cumbelly = 0
			cumass = 0
			cumlip = 0
			cumface = 0
			cumfrot = 0
			minut += 60
			sweat = -3
			manna += 5
			horny += 10
			if stren < 30:stren += 1
			gs 'zz_render', '', 'etogame/lakenude.jpg', func('etoexhib_strings', 'local_str45')
			act 'Выйти из воды':gt'etoexhib','pos16'
		end
	end
	act 'Вернуться на аллею':gt'etoexhib','pos2'
end