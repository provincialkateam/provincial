if $ARGS[0] = 'start_door':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Квартира Питера</font></b></center>'
	'<center><img src="images/peter/peterdoor.jpg"></center>'
	act 'Выйти':
		minut += 5
		gt 'down'
	end
	act 'Позвонить в дверь':
		cla
		if petersexday ! day:
			petersexday = day
			gs 'zz_render', '', '', func('Peterroom_strings', 'local_str1')
			act 'Пройти в квартиру': gt'peterroom','start'
		else
			gs 'zz_render', '', '', func('Peterroom_strings', 'local_str2')
			act 'Выйти':
				minut += 5
				gt 'down'
			end
		end
	end
end
if $ARGS[0] = 'start':
	*clr & cla
	if $npc['32,relation'] > 0:
		peterrand = RAND(1,2)
		gs 'zz_render', '', 'images/peter/9.jpg', func('Peterroom_strings', 'local_str3')
		act 'Я, мой господин...':
			petersex = petersex+1
			if analplugin = 1:gt'peterroom','klap'
			if peterrand < 2:gt'peterroom','d1'
			if peterrand > 1:gt'peterroom','d2'
		end
	elseif $npc['32,relation'] < 1:
		petersexday += 1
		minut += 10
		gs 'zz_render', '', 'images/peter/1.jpg', func('Peterroom_strings', 'local_str4')
		act 'Надеть':
			*clr
			cla
			gs 'zz_render', '', 'images/peter/2.jpg', func('Peterroom_strings', 'local_str5')
			if analplugin = 1:
				analplugin = 0
				gs 'zz_render', '', '', func('Peterroom_strings', 'local_str6')
			end
			act 'Улыбнуться':
				cla
				*clr
				gs'stat'
				gs 'zz_render', '', 'images/peter/3.jpg', func('Peterroom_strings', 'local_str7')
				act 'Подчиниться':
					cla
					*clr
					gs 'zz_render', '', 'images/peter/4.jpg', func('Peterroom_strings', 'local_str8')
					act 'Продолжать сосать':
						cla
						*clr
						gs 'zz_render', '', 'images/peter/5.jpg', func('Peterroom_strings', 'local_str9')
						act 'Ползти':gt'peterroom','klap'
					end
				end
				act 'Не подчиниться':
					cla
					*clr
					gs 'zz_render', '', 'images/peter/4_1.jpg', func('Peterroom_strings', 'local_str10')
					act 'Да! Я буду твоей шлюхой!':gt'peterroom','klap'
				end
			end
		end
		act 'Уйти': gt'down'
	end
end
if $ARGS[0] = 'klap':
	cla
	*clr
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/peter/6.jpg', func('Peterroom_strings', 'local_str11')
	act 'Мычать':
		cla
		*clr
		gs 'zz_render', '', 'images/peter/7.jpg', func('Peterroom_strings', 'local_str12')
		if analplugin = 1:
			analplugin = 0
			gs 'zz_render', '', '', func('Peterroom_strings', 'local_str13')
		end
		gs 'zz_render', '', '', func('Peterroom_strings', 'local_str14')
		act 'Мычать':
			cla
			*clr
			horny += 10
			anal += 1
			gs 'zz_render', '', 'images/peter/8.jpg', func('Peterroom_strings', 'local_str15')
			if anus < 25:anus += 1
			if horny >= 100:
				horny = 1
				orgasm += 1
				analorgasm += 1
				gs 'zz_render', '', '', func('Peterroom_strings', 'local_str16')
			end
			gs 'zz_render', '', '', func('Peterroom_strings', 'local_str17')
			act 'Расслабиться':gt'peterroom','end'
		end
	end
end
if $ARGS[0] = 'end':
	cla
	*clr
	dom -= 1
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/peter/vanroom.jpg', func('Peterroom_strings', 'local_str18')
	act 'Выйти из ванной':
		cla
		*clr
		gs 'npc_editor','change_rep','+', 32
		minut += 20
		gs 'zz_render', '', 'images/peter/mash.jpg', func('Peterroom_strings', 'local_str19')
		act 'В центр': gt 'down'
		if housr = 1: act 'К дому': gt 'street'
	end
end
if $ARGS[0] = 'd1':
	cla
	*clr
	horny += 20
	anal += 1
	if anus < 25:anus += 1
	gs 'zz_render', '', 'images/peter/d1-1.jpg', func('Peterroom_strings', 'local_str20')
	act 'Сосать пальцы':
		cla
		*clr
		gs 'zz_render', '', 'images/peter/d1-2.jpg', func('Peterroom_strings', 'local_str21')
		act 'Стонать':
			cla
			*clr
			gs 'zz_render', '', 'images/peter/d1-3.jpg', func('Peterroom_strings', 'local_str22')
			act 'Стонать':
				cla
				*clr
				gs 'zz_render', '', 'images/peter/d1-4.jpg', func('Peterroom_strings', 'local_str23')
				if horny >= 100:
					orgasm += 1
					analorgasm += 1
					gs 'zz_render', '', '', func('Peterroom_strings', 'local_str24')
				else
					gs 'zz_render', '', '', func('Peterroom_strings', 'local_str25')
				end
				gs 'zz_render', '', '', func('Peterroom_strings', 'local_str26')
				act 'Далее':gt'peterroom','end'
			end
		end
	end
end
if $ARGS[0] = 'd2':
	cla
	*clr
	horny += 20
	gs 'zz_render', '', 'images/peter/d2-1.jpg', func('Peterroom_strings', 'local_str27')
	act 'Сосать':
		cla
		*clr
		gs 'zz_render', '', 'images/peter/d2-2.jpg', func('Peterroom_strings', 'local_str28')
		act 'Стонать':
			cla
			*clr
			gs 'zz_render', '', 'images/peter/d2-3.jpg', func('Peterroom_strings', 'local_str29')
			act 'Мычать':
				cla
				*clr
				dom -= 1
				bj += 1
				gs 'zz_render', '', 'images/peter/d2-4.jpg', func('Peterroom_strings', 'local_str30')
				if horny >= 100:
					VAF += 1
					lipkoef += 1
					orgasm += 1
					gs 'zz_render', '', '', func('Peterroom_strings', 'local_str31')
				end
				act 'Сглотнуть':gt'peterroom','end'
			end
		end
	end
end