if $args[0] = 'init':
	$loc = $curloc
	$metka = ''
	! точка возврата
	$_back_loc = $args[1]
	$_back_arg = $args[2]
	gt 'zz_bathroom'
end
if $args[0] = '':
	*clr & cla
	minut += 1
	no_bath = 0
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	! описания
	if $_back_loc = 'korrPar' or $_back_loc = 'shulgahome' or $_back_loc = 'banda_home':
		! кв.родителей, кв.Шульги
		gs 'zz_render','','common/interior/bathroom/bath4','Ванная тесная и очень простенькая.'
	elseif $_back_loc = 'mey_home':
		gs 'zz_render','','common/interior/bathroom/bath5','Чистый и опрятный санузел.'
	elseif $_back_loc = 'stwork' or $_back_loc = 'skk':
		! стрипклуб Центр и СКК
		no_bath = 1
		gs 'zz_render','Душевая','common/interior/bathroom/bath6','Небольшая и очень простенькая уборная.'
	elseif $_back_loc = 'korr':
		! квартира Южн.рн.
		gs 'zz_render', 'Ванная','common/interior/bathroom/bath'+iif(my_house = 1,'',remvanr)+'.jpg',iif(remvanr = 0 and my_house = 2,'В этой ванне явно помыться не получится.', '')
	elseif $_back_loc = 'uni_dorm':
		no_bath = 1
		gs 'zz_render','','city/center/university/dorm/interiors/bath','Душевая общежития. Явно не роскошная сауна. Но чистенько. Скромненько.'
	elseif $_back_loc = 'Gadbana':
		gt 'Gadbana'
	end
	!---
	! щеколда
	if $_back_loc = 'korrPar':
		act '<font size=1>' + iif(vanr_lock = 0, 'Закрыть', 'Открыть') + ' щеколду на двери</font>':
			vanr_lock = iif(vanr_lock = 0,1,0)
			gt 'zz_bathroom'
		end
		if $npc['38,qwKolka'] >= 5 and week <= 5 and hour = 6 and cloth[1] = 1 and anus >= 13 and vagina >= 13: gt 'sisterQW','incest_event5sub'
	end
	!---
	act iif(cloth[0] < 2 and cloth[3] > 2,'<b>Одеться и выйти</b>','<b>Выйти</b>'):
		! принудительное одевание ГГ
		! возможен чит на сарафаны
		if cloth[0] < 2 and cloth[3] < 2: gs 'zz_clothing2','fix_emergency'
		!---
		vanr_lock = 0
		if cloth[0] < 2: gs 'zz_clothing2','redress',cloth[3]
		gt $_back_loc,$_back_arg
	end
	if $_back_loc = 'korrPar':
		if shameless['flag'] >= 1:
			act 'Выйти из комнаты в полотенце':
				gs 'zz_clothing2','redress',1
				gt $_back_loc,$_back_arg
			end
		end
		if shameless['flag'] >= 2:
			act 'Выйти из комнаты голышом':
				gs 'zz_clothing2','redress',0
				gt $_back_loc,$_back_arg
			end
		end
	end
	!---
	if stanok > 0: gs 'zz_render','','','Вашего бритвенного станка хватит ещё на <<stanok>> раз.'
	if tampon > 0:
		gs 'zz_render','','',iif(no_bath = 0,'На полке лежит','У вас имеется')+' упаковка тампонов. Ее хватит ещё на <b><<tampon>></b> раз.'
	else
		gs 'zz_render','','','<red>У вас нет тампонов.</red>'
	end
	!---
	if $_back_loc = 'korr' and my_house = 2 and remvanr = 0:
		! нету зеркала
		gs 'zz_render','','','Судя по оставшемуся контуру, на этом месте висело зеркало.'
	else
		gs 'zz_render','','','Над раковиной висит <a href="exec: gt ''mirror'',''start'',''bath''">зеркало</a>.'
		act 'Зеркало': gt 'mirror','start','bath'
	end
	!---
	bad_vanr = iif($_back_loc = 'korr' and remvanr = 0 and my_house = 2,1,0)
	if bad_vanr = 0 or $_back_loc ! 'korr':
		!if sweat > 0:
			act 'Мыться под душем 15 мин':
				*clr & cla
				if ($_back_loc = 'korr' or $_back_loc = 'skk' or $_back_loc = 'uni_dorm') and shampoo = 0:
					gs 'zz_bathroom','no_shampoo'
					exit
				end
				horny += 1
				manna += 5
				gs 'zz_bathroom','shower'
				gs 'zz_clothing2','redress',1
				gs 'stat'
				gs 'zz_render', '', 'pics/dush.jpg','Вы залезли под душ. Намылившись мочалкой, вы смыли пену и вымыли волосы шампунем. Теперь вы чистенькая и благоухающая свежестью.'
				act 'Закончить': gt 'zz_bathroom'
				if vanr_lock = 0 and $_back_loc = 'korrPar':
					gs 'zz_render', '', '','Стараясь побыстрее умыться и вернуться к своим делам, вы совершенно забываете закрыть дверь - не до неё.<br>Мысль о том, что дверь открыта, настигает вас уже под конец, когда вы вытираетесь полотенцем. Было бы очень неловко, если бы брат или отчим заглянули бы не вовремя.'
					cla
					act 'Вытираться':
						if family_trip = 0:
							gs 'zz_bathroom_voyer','start'
						else
							gt 'zz_bathroom'
						end
					end
				end
			end
			if no_bath = 0:
				act 'Мыться в ванной 1 час':
					*clr & cla
					if $_back_loc = 'korr' and shampoo <= 0:
						gs 'zz_bathroom','no_shampoo'
						exit
					end
					minut += 45
					if skinday ! daystart: skinday = daystart & gs 'zz_funcs','skin','+',3
					gs 'zz_bathroom', 'shower'
					gs 'zz_clothing2','redress',0
					gs 'stat'
					gs 'zz_render', '', 'images/pics/wash4.jpg','Включив воду, вы залезли в ванную и легли в теплую воду. Понаслаждавшись приятным теплом вы намылили свое тело мочалкой и волосы шампунем. Затем вы все смыли водой.'
					act 'Закончить': gt 'zz_bathroom'
					if horny >= 90:
						act 'Направить воду на киску':
							*clr & cla
							horny = 0
							minut += 10
							mastr += 1
							orgasm += 1
							manna += 15
							gs 'stat'
							gs 'zz_render', '', 'images/pics/wash7.jpg','Вы направили кран с водой на киску и тугая струя теплой воды начали ласкать вас. Вскоре вы почувствовали как теплая волна охватывает весь ваш организм и вы начали содрогаться в оргазме.'
							act 'Закончить': gt 'zz_bathroom'
						end
					elseif horny >= 40 and horny < 90:
						act 'Направить воду на киску':
							*clr & cla
							horny += 5
							minut += 10
							manna += 10
							gs 'stat'
							gs 'zz_render', '', 'images/pics/wash7.jpg','Вы направили кран с водой на киску и тугая струя теплой воды начали ласкать вас. Сначала было очень даже не плохо, но потом возбуждение спало и стало даже как-то не приятно. Поэтому вы прекратили мастурбировать.'
							act 'Закончить': gt 'zz_bathroom'
						end
					end
					if horny >= 50: act 'Мастурбировать': gt 'selfplay'
				end
			end
		!end
	else
		act 'Умыться':
			*clr & cla
			minut += 5
			mop = 1
			cumlip = 0
			cumface = 0
			sweat -= 1
			gs 'stat'
			gs 'zz_render', '', 'pic/facesp.jpg','Вы тщательно умыли лицо и смыли косметику.'
			act 'Далее': gt 'zz_bathroom'
		end
	end
	if tampon > 0 and mesec > 0 and isprok = 0 and $settings['autotampon'] = 0:
		act 'Поменять тампон':
			*clr & cla
			tampon -= 1
			isprok = 1
			minut += 5
			manna -= 5
			gs 'zz_render','','picb/tampon.jpg','Вы поменяли тампон'
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if cumpussy > 0 or cumbelly > 0 or cumass > 0 or cumanus > 0:
		act 'Подмыться 5 мин':
			*clr & cla
			cumpussy = 0
			cumbelly = 0
			cumass = 0
			cumanus = 0
			sweat -= 1
			minut += 5
			gs 'zz_render','','pics/wash5.jpg','Вы тщательно смыли сперму в ванной.'
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if cumlip > 0 or cumface > 0:
		act 'Смыть сперму с лица 5 мин':
			*clr & cla
			mop = 1
			cumlip = 0
			cumface = 0
			sweat -= 1
			minut += 5
			gs 'zz_render','','pic/facesp.jpg','Вы тщательно смыли сперму с лица.'
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if mop ! 1:
		act 'Смыть косметику':
			*clr & cla
			mop = 1
			minut += 15
			gs 'zz_render','','pic/facesp.jpg','Вы смыли косметику.'
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if cumfrot > 0:
		act 'Оттирать сперму с одежды':
			cla
			cumfrot = 0
			gs 'zz_clothing2','decrease_condition'
			minut += 15
			gs 'zz_render','','pic/frotsp.jpg','Вы замыли пятна спермы на своей одежде.'
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if leghair > 0 and stanok > 0:
		act 'Брить ноги 15 мин':
			*clr & cla
			minut += 15
			leghair = -5
			horny += 5
			stanok -= 1
			gs 'zz_render','','pics/shave.gif','Вы намыливаете ноги, и взяв бритву, ловкими движениями сбриваете волоски на ногах, смыв затем пенку для бритья.'
			act 'Отложить станок': gt 'zz_bathroom'
		end
	end
	if lobok > 0 and stanok > 0:
		act 'Брить лобок 15 мин':
			*clr & cla
			minut += 15
			lobok = -5
			horny += 5
			stanok -= 1
			gs 'zz_render','','pics/shave3.gif','Вы намыливаете лобок, и взяв бритву, ловкими движениями сбриваете волоски вокруг киски.'
			act 'Отложить станок': gt 'zz_bathroom'
		end
	end
	if analplug = 1 and analplugin = 1:
		act 'Вынуть анальную пробку':
			*clr & cla
			minut += 1
			analplugIN = 0
			gs 'zz_render', '','images/pic/analplug.jpg',iif( anus >= 5,'Вы наклонились и привычным движением вынули из себя анальную пробку.','Вы поднатужились и, закусив губу, с громким чпоком вынули из ануса пробку.')
			act 'Закончить': gt 'zz_bathroom'
		end
	elseif analplug = 1 and analplugin = 0:
		act 'Вставить анальную пробку':
			*clr & cla
			minut += 5
			analplugIN = 1
			if anus < 10: anus += 1
			gs 'zz_render', '','images/pic/analplug.jpg', iif( anus >= 5,'Вы наклонились и привычным движением вставили себе анальную пробку.','Вы постарались как можно сильнее расслабить попу и стали вставлять себе пробку. Закусив губу от чувства, что ваша попа вот вот лопнет, вы аккуратно протолкнули толстую часть в свою попу, и наконец-то пробка встала на место.')
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if pregtest > 0:
		act 'Сделать тест на беременность':
			cla
			pregtest -= 1
			if pregnancy > 0:
				pregnancyKnow = 1
				gs 'zz_render','','','Тест показал две полоски. Вы беременны. Вы думаете, что отец <<$father>>.'
			else
				gs 'zz_render','','','Тест показал одну полоску.'
			end
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	if vibrator = 1 and vibratorIN = 0:
		act 'Вставить вибратор 5 мин.':
			*clr & cla
			minut += 5
			vibratorIN = 1
			if vagina < 6: vagina += 1
			gs 'zz_render','','pic/vibrator.jpg','Разведя ноги, вы вставляете вибратор в киску.'
			act 'Закончить': gt 'zz_bathroom'
		end
	elseif vibrator = 1 and vibratorIN = 1 and vagina > 0:
		act 'Вынуть вибратор 2 мин':
			*clr & cla
			minut += 2
			vibratorIN = 0
			gs 'zz_render','','pic/vibrator.jpg','Наклонились, вы вынимаете вибратор из влагалища.'
			act 'Закончить': gt 'zz_bathroom'
		end
	end
	! квартира Южн.рн.
	if $loc = 'korr':
		if stiralka > 0 or my_house = 1:
			if husband > 0 and husbanday > 0 and husporday ! day and poroshok >= 2:
				husband += 5
				poroshok -= 2
				husporday = day
				gs 'zz_render','','','Стиральная машинка выстирала вещи мужа.'
			end
			if poroshok < 2:
				gs 'zz_render', '','','<red>У вас кончился порошок для стиральной машины.</red>'
			end
		end
		if shampoo > 0:
			gs 'zz_render','','','У вас хватит шампуня на <<shampoo>> раз.'
		else
			gs 'zz_render','','','У вас кончился шампунь, поэтому с мытьём проблемы.'
		end
		if poroshok > 0:
			gs 'zz_render','','','Под ванной стоит упаковка стирального порошка, которого хватит на <b><<poroshok>></b> стирок.'
		end
		if stiralka > 0:'В ванной стоит стиральная машинка.'
		if husband > 0 and husbanday > 0 and husporday ! day and poroshok >= 2:
			act 'Стирать одежду мужа (1ч, 2 ед. стирального порошка)':
				cla
				*clr
				husband += 5
				poroshok -= 2
				minut += 60
				husporday = day
				manna -= 25
				gs 'zz_render','','pic/stir.jpg','Вы целый час отстирывали носки мужа и его труселя.'
				act 'Отойти от ванной': gt 'zz_bathroom'
			end
		end
	end
end
if $args[0] = 'no_shampoo':
	cla
	gs 'zz_render','','','<red>Чёрт, шампунь-то закончился!</red>'
	act 'Назад': gt 'zz_bathroom'
end
if $args[0] = 'shower':
	minut += 15
	gs 'zz_bathroom', 'clean_me'
	if $_back_loc = 'korr' and shampoo > 0:shampoo -= 1
end
if $args[0] = 'clean_me':
	cumpussy = 0
	cumbelly = 0
	cumass = 0
	cumanus = 0
	cumlip = 0
	cumface = 0
	cumfrot = 0
	sweat = -3
	mop = 1
	hapri = 0
end