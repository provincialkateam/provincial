if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	$loc = $curloc
	$metka = $args[0]
	*clr & cla
	gs 'stat'
	act '<b>Выйти</b>': minut += 5 & killvar '$_salon' & gt 'torgcentr'
	if hour < 8 or hour > 20:
		gs 'zz_render', 'Салон красоты', 'images/img/centr/salon.jpg', func('salon_strings', 'local_str16')
		exit
	end
	act 'Подойти к администратору': gt 'salon','1'
	if (week = 1 or week = 3 or week = 5) and hour >= 9 and hour <= 10 and worksalon = 1: gt'salon','beginwork'
	salonrand = RAND(0,9)
	killvar '$_salon'
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	$_salon['0,name'] = 'Завить волосы'
	$_salon['0,price'] = 1500
	$_salon['1,name'] = 'Покрасить волосы'
	$_salon['1,price'] = 1500
	$_salon['2,name'] = iif($settings['hapri_mod'] = 0,'Короткая прическа','')
	$_salon['2,price'] = iif($settings['hapri_mod'] = 0,1500,'')
	$_salon['3,name'] = 'Солярий'
	$_salon['3,price'] = 1000
	$_salon['4,name'] = 'Удлинение ресниц'
	$_salon['4,price'] = 3000
	$_salon['5,name'] = 'Полная эпиляция'
	$_salon['5,price'] = 5000
	$_salon['6,name'] = 'Оздоровительный массаж (разгоняет жир, омолаживает тело)'
	$_salon['6,price'] = 5000
	$_salon['7,name'] = 'Перманентный татуаж бровей'
	$_salon['7,price'] = 3000
	$_salon['8,name'] = 'Сделать или свести татуировку'
	$_salon['8,price'] = 3000
	$_salon['9,name'] = 'Уход за кожей'
	$_salon['9,price'] = 15000
	$_salon['10,name'] = 'Уменьшение губ'
	$_salon['10,price'] = 15000
	$_salon['11,name'] = 'Увеличение губ'
	$_salon['11,price'] = 15000
	$_salon['12,name'] = 'Увеличение глаз'
	$_salon['12,price'] = 30000
	$_salon['13,name'] = 'Увеличение груди'
	$_salon['13,price'] = 150000
	$_salon['14,name'] = 'Отсос жира'
	$_salon['14,price'] = 150000
	$_salon['15,name'] = 'Процедуры омоложения'
	$_salon['15,price'] = 250000
	if $settings['hapri_mod'] = 1:
		if shorthair <= 1:
			$_salon['16,name'] = 'Средняя прическа'
			$_salon['16,price'] = 1500
		end
		if shorthair <= 2:
			$_salon['17,name'] = 'Короткая прическа'
			$_salon['17,price'] = 1500
		end
		if shorthair <= 3:
			$_salon['18,name'] = 'Прическа под мальчика'
			$_salon['18,price'] = 1500
		end
	end
	$_str = '<center><table border=0 width=700 cellpadding=0 cellspacing=1>'
	i = 0
	:loop_salon
	$_str += '<tr bgcolor='+iif(i mod 2 = 0,'#f3f4ee','#ffffff')+'><td>'+$_salon['<<i>>,name']+'</td><td align=center>'+iif(money>=val($_salon['<<i>>,price']),'<a href="exec:gt''salon'',''select'',<<i>>">'+$_salon['<<i>>,price']+'</a>',$_salon['<<i>>,price'])+' руб.</td></tr>'
	i += 1
	if i < arrsize('$_salon')/2: jump 'loop_salon'
	$_str += '</table></center>'
	gs 'zz_render', 'Салон красоты', 'images/img/centr/salon.jpg', $_str
	killvar '$_str'
end
if $args[0] = 'select':
	*clr & cla
	! exceptions
	if (args[1] = 0 and shorthair = 3) or (args[1] = 3 and tan_day = day) or (args[1] = 4 and resnic = 2) or (args[1] = 5 and lobok = -20) or (args[1] = 7 and brow = -1) or (args[1] = 9 and skin = 4) or (args[1] = 10 and lip = 0) or (args[1] = 11 and lip = 4) or (args[1] = 12 and glaraz = 3) or (args[1] = 14 and body['weight'] <= body['base_weight']):
		gs	'zz_render','Салон красоты','images/img/centr/salon.jpg',func('salon_strings', 'local_str34')
		act 'Назад': gt 'salon','start'
		exit
	end
	! ---
	if args[1] = 0: gt 'barbershop', 'hair_curl'
	if args[1] = 1: gt 'barbershop', 'hair_coloring'
	if args[1] = 2: gt 'barbershop', 'hair_short'
	if args[1] = 8: gt 'salon','tattoo'
	if args[1] = 16: gt 'barbershop', 'hair_medium'
	if args[1] = 17: gt 'barbershop', 'hair_medium_short'
	if args[1] = 18: gt 'barbershop', 'hair_short'
	!---
	minut += 60
	money -= val($_salon['<<args[1]>>,price'])
	if args[1] = 3:
		tan += 10
		tan_day = day
		if salonrand > 6 and $npc['0,qwNastya'] > 2: gt'etoexhib','pos1'
	end
	if args[1] = 4: resnic += 1
	if args[1] = 5: leghair = -20 & lobok = -20
	if args[1] = 6:
		body['day_weight'] -= 2
		vidageday += 3
		if salonrand = 0:
			*clr & cla
			picrand = RAND(25,28)
			gs 'zz_render', '', 'images/img/centr/salon6_1.jpg', func('salon_strings', 'local_str6_1')
			act 'Возмутиться': gt 'salon','start'
			act 'Наслаждаться':
				guy += 1
				gt 'sex','minet'
			end
		end
	end
	if args[1] = 7: brow = -1
	if args[1] = 9: skin += 1
	if args[1] = 10: lip -= 1
	if args[1] = 11: lip += 1
	if args[1] = 12: glaraz += 1
	if args[1] = 13: silicone += 10
	if args[1] = 14: body['increase_weight'] -= 5
	if args[1] = 15: vidage -= 1
	! ---
	if salonrand = 0 and masha = 0 and (args[1]=3 or args[1]=4 or args[1]=5 or args[1]=9 or args[1]=15): gt 'salon', '0'
	! ---
	gs 'zz_render', '', 'images/img/centr/salon'+iif(args[1] > 15,2,args[1])+'.jpg', func('salon_strings', 'local_str<<args[1]>>')
	gs 'stat'
	act 'Назад': gt 'salon','start'
end
if $ARGS[0] = '0':
	*clr & cla
	cumfrot += 1
	gs 'zz_render', '', 'images/img/centr/pri1.jpg', func('salon_strings', 'local_str17')
	act 'Согласиться':money += 5000 & gt'salon','start'
	if DOM > 10:
		act 'Потребовать наказать сейчас':
			cla
			orgasm += 1
			DOM += 1
			gs 'zz_render', '', '', func('salon_strings', 'local_str18')
			act 'Все ты можешь':
				*clr & cla
				gs 'zz_render', '', 'images/img/centr/pri2.jpg', func('salon_strings', 'local_str19')
				act 'Соси сучка':
					*clr & cla
					gs 'zz_render', '', 'images/img/centr/pri3.jpg', func('salon_strings', 'local_str20')
					act 'Поставь её раком':
						*clr & cla
						gs 'zz_render', '', 'images/img/centr/pri4.jpg', func('salon_strings', 'local_str21')
						act 'Посади её сверху':
							*clr & cla
							gs 'zz_render', '', 'images/img/centr/pri5.jpg', func('salon_strings', 'local_str22')
							act 'Ложись на пол':
								*clr & cla
								gs 'zz_render', '', 'images/img/centr/pri6.jpg', func('salon_strings', 'local_str23')
								act 'Заканчивай':
									*clr & cla
									telmasha = 1
									masha += 1
									gs 'zz_render', '', 'images/img/centr/pri7.jpg', func('salon_strings', 'local_str24')
									act 'Уйти': gt'salon','start'
								end
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = '1':
	cla
	minut += 5
	if worksalon = 0:
		gs 'zz_render', '', '', func('salon_strings', 'local_str25')
		if masash < 10:
			gs 'zz_render', '', '', func('salon_strings', 'local_str26')
			act 'Отойти': gt'salon','start'
		elseif masash >= 10:
			gs 'zz_render', '', '', func('salon_strings', 'local_str27')
			if work = 0 and worksalon = 0:
				act 'Отойти':gt'salon','start'
				act 'Устроиться на работу':
					cla
					worksalon = 1
					work = 1
					gs 'zz_render', '', '', func('salon_strings', 'local_str28')
					act 'Отойти':gt'salon','start'
				end
			end
			act 'Отойти':gt'salon','start'
		end
	elseif worksalon = 1:
		act 'Уволиться':gt'salon','discharge'
		act 'Отойти':gt'salon','start'
	end
end
if $ARGS[0] = 'beginwork':
	*clr & cla
	gs 'zz_render', 'Салон красоты', 'images/pic/salon.jpg', func('salon_strings', 'local_str29')
	act 'Начать работу':
		smena += 1
		gt 'worksalon','start'
	end
	act 'Уволиться': gt 'salon','discharge'
end
if $ARGS[0] = 'discharge':
	cla
	minut += 10
	worksalon = 0
	work = 0
	pay = smena * 800
	money += pay
	smena = 0
	gs 'zz_render', '', '', func('salon_strings', 'local_str30')
	act 'Уйти':gt'salon','start'
end
if $args[0] = 'tattoo':
	*clr & cla
	act 'Назад': gt 'salon', 'start'
	gs 'zz_render', '', '', func('salon_strings', 'local_str31')
	! make table
	$zz_str = '<center><table border=0 cellpadding=1 cellspacing=1 align=center width=600>'
	$zz_str += '<tr bgcolor="#f3f4ee"><th width=80>Пример</th><th>Название</th><th>Действие</th></tr>'
	i = 0
	j = 0
	:loop_make_tattoo_table
	if j = 0: $zz_place[0] = 'lip' & $zz_place[1] = 'на губе'
	if j = 1: $zz_place[0] = 'shoulder' & $zz_place[1] = 'на плече'
	if j = 2: $zz_place[0] = 'back' & $zz_place[1] = 'на спине'
	if j = 3: $zz_place[0] = 'vag' & $zz_place[1] = 'в паху'
	if j = 4: $zz_place[0] = 'leg' & $zz_place[1] = 'на ноге'
	if j = 5: $zz_place[0] = 'waist' & $zz_place[1] = 'на пояснице'
	$zz_img = 'images/picb/tattoo/<<$zz_place[0]>>/<<i>>.jpg'
	$zz_str += '<tr bgcolor="#f3f4ee"><td align=center><a href="exec:view''<<$zz_img>>''"><img src="<<$zz_img>>" height=60></a></td><td>Татуировка <<$zz_place[1]>> #<<i+1>></td><td><a href="exec:gt''salon'',''set_tattoo'',''<<$zz_place[0]>>'',<<i>>" >'+iif(tattoo[$zz_place[0]]=0,'Сделать','Свести')+'</a></td></tr>'
	if i < 3:
		i += 1
		jump 'loop_make_tattoo_table'
	elseif i = 3 and j < 5:
		i = 0
		j += 1
		jump 'loop_make_tattoo_table'
	end
	$zz_str += '</table></center>'
	gs 'zz_render', '', '', $zz_str
	killvar '$zz_str'
	killvar '$zz_img'
	killvar '$zz_place'
end
if $args[0] = 'set_tattoo':
	*clr & cla
	act 'Отойти': gt 'salon', 'tattoo'
	if money < 3000:
		gs 'zz_render', '', '', func('salon_strings', 'local_str32')
		exit
	end
	gs 'zz_render', '', 'images/pic/'+iif(tattoo[$args[1]]>0,'remove_tattoo.jpg','make_tattoo.gif'), func('salon_strings', 'local_str33')
	manna -= 5
	money -= 3000
	minut += rand(50,70)
	! remove
	if tattoo[$args[1]] > 0:
		tattoo[$args[1]] = 0
	else
		! make
		tattoo[$args[1]] = args[2]+1
	end
	gs 'stat'
end