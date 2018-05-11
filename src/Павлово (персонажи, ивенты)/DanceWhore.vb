if $args[0] = 'go_to_home_dance':
	act 'Ехать обратно':
		*clr & cla
		minut += 15
		gs 'stat'
		killvar '_client'
		gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str22')
		if cumface > 0: cumface = 0 & 'По пути вы стерли сперму с лица салфетками.'
		act 'Уйти': gt 'gorodok'
	end
end
if args[0] = 1 or args[0] = 3 or args[0] = 6:
	minut += 5
	_client = args[0]
	gs 'stat'
	! локальная переменная
	if _client = 1: dick = RAND(10,20) & $zz_str = 'Мужчина'
	if _client = 3: dick = RAND(15,20) & $zz_str = 'Кавказец'
	if _client = 6: dick = RAND(15,25) & $zz_str = 'Здоровенный негр'
	gs 'zz_render','','', $zz_str + ' взял вас под руку и отвел в комнату. Когда мужчина включил в комнате свет, вы увидели, что это большая спальная.'
	killvar '$zz_str'
	act 'Сесть на корточки':
		*clr & cla
		bj += 1
		guy += 1
		dom -= 1
		minut += 10
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/bj'+iif(_client = 6,'n','')+'.jpg', func('DanceWhore_strings', 'local_str1')
		i = RAND(0,2)
		if i = 0:
			gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str2')
			act 'Расслабить горло':
				*clr & cla
				if throat < dick: throat += 1
				minut += 10
				gs 'stat'
				gs 'zz_render','','pavlovo/albina/zvezdy/whoredance/throat'+iif(_client = 6,'n','')+'.jpg'
				if throat < dick/2:
					manna = 0
					horny = 0
					gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str3')
				elseif throat >= dick/2 and throat < dick:
					manna = manna/2
					horny = horny/2
					gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str4')
				else
					gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str5')
				end
				gs 'dancewhore', 'bj', '', iif(_client = 6,'n','')
			end
		elseif i = 1:
			gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str6')
			act 'Подставить попку':
				*clr & cla
				minut += 30
				$boy = 'Клиент'
				gs 'zz_funcs', 'cum', 'anus'
				gs 'stat'
				gs 'zz_render','','pavlovo/albina/zvezdy/whoredance/anal'+iif(_client = 6,'n','')+'.jpg'
				gs 'zz_dynamic_sex', 'anal_start', 'dick', 1
				gs 'zz_dynamic_sex', 'anal', 'dick'
				gs 'zz_dynamic_sex', 'anal_cum'
				gs 'DanceWhore', 'go_to_home_dance'
			end
		elseif i = 2:
			gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str7')
			act 'Лечь на спину':
				*clr & cla
				minut += 30
				$boy = 'Клиент'
				pose = 0
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/sex'+iif(_client = 6,'n','')+'.jpg', func('DanceWhore_strings', 'local_str8')
				gs 'zz_dynamic_sex', 'sex_start'
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				gs 'zz_dynamic_sex', 'sex_cum'
				gs 'DanceWhore', 'go_to_home_dance'
			end
		end
	end
end
if args[0] = 2 or args[0] = 4 or args[0] = 7:
	minut += 5
	_client = args[0]
	gs 'stat'
	if _client = 2: dick = RAND(10,20) & $zz_str = 'Парни'
	if _client = 4: dick = RAND(15,20) & $zz_str = 'Двое кавказцев'
	if _client = 7: dick = RAND(15,25) & $zz_str = 'Два негра'
	gs 'zz_render','','', $zz_str + ' повели вас в комнату.'
	killvar '$zz_str'
	act 'Сесть на корточки':
		*clr & cla
		bj += 2
		guy += 2
		gang += 1
		dom -= 1
		minut += 10
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/bjd'+iif(_client = 7,'n','')+'.jpg', func('DanceWhore_strings', 'local_str9')
		if RAND(0,1) = 0:
			gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str10')
			act 'Расслабить попку и сосать':
				*clr & cla
				minut += 30
				$boy = 'Клиент'
				gs 'zz_funcs', 'cum', 'anus'
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/d'+iif(_client = 7,'n','')+'.jpg', func('DanceWhore_strings', 'local_str11')
				gs 'zz_dynamic_sex', 'anal_start', 'dick', 1
				gs 'zz_dynamic_sex', 'anal', 'dick'
				gs 'zz_dynamic_sex', 'anal_cum'
				gs 'dancewhore', 'bj', 'group', iif(_client = 7,'n','')
			end
		else
			gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str12')
			act 'Сосать':
				*clr & cla
				minut += 30
				$boy = 'Клиент'
				pose = 0
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/d1'+iif(_client = 7,'n','')+'.jpg', func('DanceWhore_strings', 'local_str13')
				gs 'zz_dynamic_sex', 'sex_start'
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				protect = 0
				gs 'dancewhore', 'bj', 'group', iif(_client = 7,'n','')
			end
		end
	end
end
if args[0] = 5 or args[0] = 8:
	minut += 5
	_client = args[0]
	gs 'stat'
	if _client = 5: dick = RAND(15,20) & $zz_str = 'Трое кавказцев'
	if _client = 8: dick = RAND(15,25) & $zz_str = 'Три негра'
	gs 'zz_render','','', $zz_str + ' повели вас в комнату.'
	killvar '$zz_str'
	act 'Сесть на корточки':
		*clr & cla
		bj += 3
		guy += 3
		gang += 1
		dom -= 1
		minut += 10
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/bjt'+iif(_client = 8,'n','')+'.jpg', func('DanceWhore_strings', 'local_str14')
		act 'Расслабить попку и сосать':
			*clr & cla
			minut += 30
			$boy = 'Клиент'
			dynamic $venerasiak
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/f'+iif(_client = 8,'n','')+'.jpg', func('DanceWhore_strings', 'local_str15')
			gs 'zz_dynamic_sex', 'anal_start', 'dick', 1
			gs 'zz_dynamic_sex', 'anal', 'dick'
			act 'Далее':
				*clr & cla
				protect = 0
				if RAND(0,1) = 0:
					gs 'zz_funcs', 'cum', 'face'
					minut += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/facialt'+iif(_client = 8,'n','')+'.jpg', func('DanceWhore_strings', 'local_str16')
				else
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					minut += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/swallowt'+iif(_client = 8,'n','')+'.jpg', func('DanceWhore_strings', 'local_str17')
				end
				gs 'DanceWhore', 'go_to_home_dance'
			end
		end
	end
end
if $args[0] = 'bj':
	if RAND(0,1) = 0:
		gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str18')
		act 'Глотать':
			*clr & cla
			gs 'zz_funcs', 'cum', 'lip'
			swallow += 1
			minut += 10
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/swallow.jpg', func('DanceWhore_strings', 'local_str19')
			gs 'DanceWhore', 'go_to_home_dance'
		end
	else
		gs 'zz_render', '', '', func('DanceWhore_strings', 'local_str20')
		act 'Закрыть глаза':
			*clr & cla
			gs 'zz_funcs', 'cum', 'face'
			minut += 10
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/albina/zvezdy/whoredance/facial'+iif(len($args[2])>0,$args[2],'')+'.jpg', func('DanceWhore_strings', 'local_str21')
			gs 'DanceWhore', 'go_to_home_dance'
		end
	end
end