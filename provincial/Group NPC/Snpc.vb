gs 'stat'
gs 'npc_editor','get_npc_profile',numnpc
gs 'gnpc_events','cumreaction'
gs 'gnpc_events','mock'
if $npc['<<numnpc>>,group'] = 3 and func('zz_reputation','get') < 2:
	if $npc['<<numnpc>>,dick'] > 0 and $loc = 'gdkin' and $npc['<<numnpc>>,relation'] >= 40 and (vnesh >= 40 or $npc['1,qwDimaRude'] > 0 or $npc['4,qwIgorLove'] > 0):
		gs 'zz_render', '', '', func('krutishi_strings', 'local_str1')
		act 'Танцевать': gt 'gnpc_events','krutishi_dance'
		if $npc['1,qwDimaRude'] = 0 and alko < 6 and (numnpc = 1 and dom > -25 or numnpc = 4 and dom > -50): act 'Отказаться': $npc['<<numnpc>>,relation'] -= 5 & gt $loc, $metka
	end
end
if numnpc = 23:
	if $npc['23,qwMain'] > 0 and $npc['23,qwMain'] < 50: gs 'zz_render', '', '', func('Snpc_strings', 'local_str2') + iif(func('zz_reputation','get') > 0,func('Snpc_strings', 'local_str44'),'')
	if artomIzdev = 1:
		act 'Спросить про микрокамеру':
			cla
			minut += 5
			artomIzdev = 2
			gs 'zz_render', '', '', func('Snpc_strings', 'local_str3')
			act 'Отойти': gt $loc, $metka
		end
	end
	if $npc['23,qwMain'] = 80: gs 'zz_render', '', '', func('Snpc_strings', 'local_str5')
end
!!!ГОПОТА
if $npc['<<numnpc>>,group'] = 4:
	if numnpc = 9:
		! Котов что-то подозревает
		if $npc['9,qwKotovLove'] > 5:
			if func('zz_reputation','get') > 0: gt 'kotovtalker','kotov_suspicion'
			if $loc = 'zz_school': gt 'kotovtalker','talk'
		end
	end
	if $loc = 'gdkin':
		if func('zz_reputation','get') < 2:
			if numnpc = 9 and alko > 2 and $npc['<<numnpc>>,relation'] >= 60 and (vnesh >= 60 or $npc['9,qwKotovLove'] > 5):
				gt 'kotovtalker','kotov_dancing'
			else
				gs 'zz_render','','',func('Snpc_strings', 'local_str6')
				gs 'gnpc_events','drink'
			end
		else
			gs 'zz_render','','',func('Snpc_strings', 'local_str'+iif($npc['<<numnpc>>,dick'] > 0,9,10))
			act 'Уйти': $npc['<<numnpc>>,relation'] -= 5 & gt $loc, $metka
		end
		exit
	end
end
act 'Болтать':
	*clr & cla
	minut += 4
	gs 'stat'
	gs 'npc_editor','get_npc_profile',numnpc
	if numnpc = 1 and $npc['<<numnpc>>,relation'] = 0:
		gs 'zz_render', '', '', func('Snpc_strings', 'local_str11')
		act 'Отойти': gt $loc, $metka
	elseif numnpc = 4 and $npc['<<numnpc>>,relation'] = 0 and func('zz_reputation','get') < 2:
		gs 'zz_render', '', '', func('Snpc_strings', 'local_str45')
		act 'Отойти': gt $loc, $metka
	elseif numnpc = 3 and IvanShowerYes = 0 and $npc['3,qwIvanShower'] = 11:
		cla
		gs 'zz_render', '', '', func('Snpc_strings', 'local_str12')
		act 'Согласиться':
			IvanShowerYes = 1
			cla
			gs 'zz_render', '', '', func('Snpc_strings', 'local_str13')
			act 'Отойти': gt $loc, $metka
		end
		act 'Отказаться':
			IvanShowerYes = 2
			cla
			gs 'zz_render', '', '', func('Snpc_strings', 'local_str14')
			act 'Отойти': gt $loc, $metka
		end
	elseif numnpc = 13 and lariskaHelp = -1:
		gs 'zz_render', '', '', func('Snpc_strings', 'local_str15')
		act 'Отойти': gt $loc, $metka
	else
		gs 'check_gorslut'
		act 'Отойти': gt $loc, $metka
	end
	! Соня
	if numnpc = 25:
		if $npc['25,qwSonya'] = 50 and $npc['25,qwSonya_day'] ! day: gt 'sonya','talk_about_sergey'
		if $npc['25,qwSonya'] = 255:
			gs 'zz_render','','',func('Snpc_strings','local_str15')
			act 'Отойти': gt $loc, $metka
		end
	end
end
!!!АРТЕМ ЧЕБОТАРЕВ БОТАН!!!
if numnpc = 2:
	if dom > 0 and artomLernQW = 0:
		act 'Ты не мог бы немного подтянуть меня по учёбе?':
			*clr & cla
			if $loc = 'gdkin': minut += 5
			if func('zz_reputation','get') < 3: artomLernQW = 1
			gs 'stat'
			gs 'npc_editor','change_rep','+',numnpc
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render','','',func('Snpc_strings', 'local_str'+iif(func('zz_reputation','get') < 3,16,17))
			act 'Отойти': gt $loc, $metka
		end
	end
end
! Прохоров
if numnpc = 3:
	! попросить помощи у Ивана в случае с Соней
	if $npc['25,qwSonya'] = 40:
		act 'Попросить помощи с Соней': gt 'sonya','ask_ivan_for_help'
	end
end
!!!ЮЛЯ МИЛОВА БОТАН
if numnpc = 12:
	if dom > 0 and JuliaMilLernQW = 0 and $npc['<<numnpc>>,relation'] >= 80:
		act 'Ты не могла бы немного подтянуть меня по учёбе?':
			*clr & cla
			if $loc = 'gdkin': minut += 5
			JuliaMilLernQW = 1
			gs 'stat'
			gs 'npc_editor','change_rep','+',numnpc
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render','','',func('Snpc_strings', 'local_str'+iif(func('zz_reputation','get') < 1,40,18))
			act 'Отойти': gt $loc, $metka
		end
	end
end
!!!КАТЯ МЕЙНОЛЬД
if numnpc = 14:
	if $npc['14,qwKatya'] > 0 and mop <= 1:
		gs 'zz_render', '', '', func('Snpc_strings', 'local_str33')
		act 'Косметика':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render','','pavlovo/meynolds/katya/common/makeup',func('Snpc_strings','local_str34')
			act 'Легкий макияж':
				cla
				mop = 2
				gs 'zz_render', '', '', func('Snpc_strings', 'local_str35')
				act 'Отойти': gt $loc, $metka
			end
			act 'Нормальный макияж':
				cla
				mop = 3
				gs 'zz_render', '', '', func('Snpc_strings', 'local_str36')
				act 'Отойти': gt $loc, $metka
			end
			act 'Яркий макияж':
				cla
				mop = 4
				gs 'zz_render', '', '', func('Snpc_strings', 'local_str37')
				act 'Отойти': gt $loc, $metka
			end
		end
	end
	if $npc['14,qwKatya_day'] ! day:
		! trio talk
		if $npc['14,qwKatya'] = 71: gt 'mey_katya_events','ask_about_trio'
		!--
		if $npc['14,qwKatya'] >= 75 and $npc['14,qwKatya'] < 82: act 'Спросить о планах': gt 'mey_katya_events','random_hotel_sex'
		!---
	end
	if apmeet = 3 and artomIzdev = 0:
		act 'Посоветоваться как избавиться от шантажа бoтанов':
			*clr & cla
			if $loc = 'gdkin': minut += 5
			artomIzdev = 1
			gs 'stat'
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render','','', func('Snpc_strings', 'local_str38')
			act 'Отойти': gt $loc, $metka
		end
	end
end
!!!НАТАША БЕЛОВА БОТАН
if numnpc = 16:
	if dom > 0 and NatBelLernQW = 0 and $npc['16,relation'] >= 80:
		act 'Ты не могла бы немного подтянуть меня по учебе?':
			*clr & cla
			if $loc = 'gdkin': minut += 5
			NatBelLernQW = 1
			gs 'stat'
			gs 'npc_editor','change_rep','+',numnpc
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render','','',func('Snpc_strings','local_str'+iif(func('zz_reputation','get') < 1,42,43))
			act 'Отойти': gt $loc, $metka
		end
	end
end
act 'Отойти': gt $loc, $metka