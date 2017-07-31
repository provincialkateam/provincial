if $ARGS[0] = 'pos1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/nastja.jpg', func('nastja_strings', 'local_str1')
	act 'Подойти познакомиться':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/nastja.jpg', func('nastja_strings', 'local_str2')
		act 'А почему ты сидишь одна, еще и в ресторане?':
			*clr & cla
			$npc['0,qwNastya'] = 1
			minut += 60
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/nastja.jpg', func('nastja_strings', 'local_str3')
			act 'Уйти':gt'restoran','zal'
		end
	end
	act 'Уйти':gt'restoran','zal'
end
if $ARGS[0] = 'pos4':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/nastja.jpg', func('nastja_strings', 'local_str4')
	act 'Ехать в кафе':gt'nastja','pos5'
end
if $ARGS[0] = 'pos5':
	*clr & cla
	minut += 60
	$npc['0,qwNastya'] = 2
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1party0.jpg', func('nastja_strings', 'local_str5')
	act 'Шампанское!': gt'nastja','pos6'
	act 'А давай водку!': gt'nastja','pos7'
	act 'Я не пью спиртное': gt'nastja','pos8'
end
if $ARGS[0] = 'pos6':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1shamp0.jpg', func('nastja_strings', 'local_str6')
	act 'Скромно умолчать и слушать только Настю':gt'nastja','pos9'
	act 'Рассказать о своём самом лучшем сексе':gt'nastja','pos10'
	act 'Выложить всё, что с вами происходило, с тех пор как вы стали девушкой':gt'nastja','pos10'
end
if $ARGS[0] = 'pos7':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1party.jpg', func('nastja_strings', 'local_str7')
	act 'Рассказать о своём самом лучшем сексе':gt'nastja','pos10'
	act 'Выложить всё, что с вами происходило, с тех пор как вы стали девушкой':gt'nastja','pos11'
end
if $ARGS[0] = 'pos8':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1shamp0.jpg', func('nastja_strings', 'local_str8')
	act 'Идти за Настей':
		*clr & cla
		horny += 30
		minut += 60
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/1turnik.jpg', func('nastja_strings', 'local_str9')
		act 'Разъехаться по домам':gt'street'
	end
end
if $ARGS[0] = 'pos9':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/nastja.jpg', func('nastja_strings', 'local_str10')
	act 'Ждать подругу':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/1shamp3.jpg', func('nastja_strings', 'local_str11')
		act 'Предупредить подругу':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', '', func('nastja_strings', 'local_str12')
			act 'Идти писать за заборы':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/etogame/1shamp1.jpg', func('nastja_strings', 'local_str13')
				gs 'zz_render', '', 'images/etogame/1shamp4.jpg', func('nastja_strings', 'local_str14')
				act 'Надеть трусики наклонившись и выпятив попу!':
					*clr & cla
					horny += 50
					minut += 60
					gs 'stat'
					gs 'zz_render', '', 'images/etogame/1shamp2.jpg', func('nastja_strings', 'local_str15')
					act 'Выбежать и уехать с Настей на такси':gt'street'
				end
			end
		end
		act 'Подсмотреть что будет':
			*clr & cla
			horny += 30
			minut += 60
			gs 'stat'
			gs 'zz_render', '', 'images/etogame/1shamp2.jpg', func('nastja_strings', 'local_str16')
			act 'Сесть в такси и разъехаться по домам':gt'street'
		end
	end
end
if $ARGS[0] = 'pos10':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1shamp0.jpg', func('nastja_strings', 'local_str17')
	act 'Смотреть на Настю':
		*clr & cla
		horny += 40
		minut += 60
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/1avtostop.jpg', func('nastja_strings', 'local_str18')
		act 'Разъехаться по домам':gt'street'
	end
end
if $ARGS[0] = 'pos11':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/1party2.jpg', func('nastja_strings', 'local_str19')
	act 'Спускаться к реке':
		*clr & cla
		horny += 50
		minut += 60
		gs 'stat'
		gs 'zz_render', '', 'images/etogame/1party3.jpg', func('nastja_strings', 'local_str20')
		act 'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/etogame/1party4.jpg', func('nastja_strings', 'local_str21')
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/etogame/1party5.jpg', func('nastja_strings', 'local_str22')
				act 'Ждать такси':
					*clr & cla
					gs 'zz_render', '', 'images/etogame/1party6.jpg', func('nastja_strings', 'local_str23')
					act 'Разъехаться по домам':gt'street'
				end
			end
		end
	end
end
if $ARGS[0] = 'pos12':
	*clr & cla
	minut += 10
	manna += 10
	$npc['0,qwNastya'] = 3
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/tel_talk.jpg', func('nastja_strings', 'local_str24')
	act 'Положить трубку':gt'telefon','fin'
end
if $ARGS[0] = 'pos13':
	*clr & cla
	minut += 30
	manna += 10
	nastjaday = day
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/tel_talk.jpg', func('nastja_strings', 'local_str25')
	act 'Положить трубку':gt'telefon','fin'
end
if $ARGS[0] = 'pos14':
	*clr & cla
	minut += 30
	manna += 10
	nastjaday = day
	$npc['0,qwNastya'] = 4
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2hello.jpg', func('nastja_strings', 'local_str26')
	act 'Идти к пляжным кабинкам':gt'nastja','pos15'
end
if $ARGS[0] = 'pos15':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2bcabin.jpg', func('nastja_strings', 'local_str27')
	act 'Ждать Настю':gt'nastja','pos16'
end
if $ARGS[0] = 'pos16':
	*clr & cla
	minut += 10
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2bgirl.jpg', func('nastja_strings', 'local_str28')
	act 'Выбрать место':gt'nastja','pos17'
end
if $ARGS[0] = 'pos17':
	*clr & cla
	minut += 60
	manna += 10
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2bimbos.jpg', func('nastja_strings', 'local_str29')
	act 'Интересует':gt'nastja','pos19'
	act 'Не интересует':gt'nastja','pos18'
end
if $ARGS[0] = 'pos18':
	*clr & cla
	minut += 20
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2bend.jpg', func('nastja_strings', 'local_str30')
	act 'Домой':gt'street'
end
if $ARGS[0] = 'pos19':
	*clr & cla
	minut += 10
	manna += 10
	horny += 30
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2btalk.jpg', func('nastja_strings', 'local_str31')
	act 'Обнажить грудь':gt'nastja','pos20'
end
if $ARGS[0] = 'pos20':
	*clr & cla
	minut += 20
	manna += 10
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2bvolley.jpg', func('nastja_strings', 'local_str32')
	act 'Закончить игру': gt 'nastja','pos21'
end
if $ARGS[0] = 'pos21':
	*clr & cla
	minut += 20
	$npc['0,qwNastya'] = 5
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2bslp.jpg', func('nastja_strings', 'local_str33')
	act 'По домам': gt 'street'
end
if $ARGS[0] = 'pos22':
	*clr & cla
	minut += 10
	manna += 10
	$npc['0,qwNastya'] = 6
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/tel_talk.jpg', func('nastja_strings', 'local_str34')
	act 'Положить трубку':gt'nastja','pos23'
end
if $ARGS[0] = 'pos23':
	*clr & cla
	minut += 30
	nastjaday = day
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/nast_home.jpg', func('nastja_strings', 'local_str35')
	act 'Далее':gt'nastja','pos24'
end
if $ARGS[0] = 'pos24':
	*clr & cla
	minut += 120
	gs 'zz_funcs', 'alko', 2
	horny += RAND(10,30)
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/wines.jpg', func('nastja_strings', 'local_str36')
	act 'Согласиться':gt'nastja','pos26'
	act 'Отказаться':gt'nastja','pos25'
end
if $ARGS[0] = 'pos25':
	*clr & cla
	minut += 30
	energy += 20
	money -= 100
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/nast_home.jpg', func('nastja_strings', 'local_str37')
	act 'Домой':gt'korr'
end
if $ARGS[0] = 'pos26':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/nast_home.jpg', func('nastja_strings', 'local_str38')
	act 'Идти открывать': gt'nastja','pos27'
	act 'Посмотреть с улыбкой на Настю': gt'nastja','pos29'
end
if $ARGS[0] = 'pos27':
	*clr & cla
	minut += 10
	horny += RAND(10,20)
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2del.jpg', func('nastja_strings', 'local_str39')
	act 'Отдать деньги':gt'nastja','pos28'
end
if $ARGS[0] = 'pos28':
	*clr & cla
	minut += 10
	horny += RAND(30,50)
	exhibi += 2
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/towel.jpg', func('nastja_strings', 'local_str40')
	act 'Закрыть дверь': gt'nastja','pos30'
end
if $ARGS[0] = 'pos29':
	*clr & cla
	minut += 10
	horny += RAND(10,30)
	exhibi += 1
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2nastdel.jpg', func('nastja_strings', 'local_str41')
	act 'Хлоп!': gt'nastja','pos30'
end
if $ARGS[0] = 'pos30':
	*clr & cla
	minut += 30
	energy += 20
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/2_towel.jpg', func('nastja_strings','local_str42') + func('nastja_strings','local_str'+iif(exhibi = 1,45,46)) + func('nastja_strings', 'local_str43')
	act 'Далее':gt'korr'
end
if $ARGS[0] = 'pos31':
	*clr & cla
	minut += 10
	manna += 10
	$npc['0,qwNastya'] = 7
	gs 'stat'
	gs 'zz_render', '', 'images/etogame/tel_talk.jpg', func('nastja_strings', 'local_str44')
	act 'Положить трубку':gt'korr'
end