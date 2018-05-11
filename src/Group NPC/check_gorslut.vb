if func('zz_reputation','get') > 1:
	! отдельно для важных нпс
	if numnpc = 14 or numnpc = 15:
		!Катя/Вика Мейнольд
		achiev['talk,'+val($npc['<<numnpc>>,group'])] += 1
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str20')
		exit
	elseif $npc['23,qwMain'] = 55 and numnpc = 23:
		! Альбина
		achiev['talk,'+val($npc['<<numnpc>>,group'])] += 1
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str21')
		exit
	elseif numnpc = 18:
		!кристина зверева
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str'+iif(kristinaSex = 0,iif(swinbeggor = 0,'22','23'),'24'))
		exit
	elseif numnpc = 9:
		!Котов
		achiev['talk,'+val($npc['<<numnpc>>,group'])] += 1
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str25')
		exit
	elseif numnpc = 4 and $npc['4,group'] = 0:
		!Круглов
		achiev['talk,'+val($npc['<<numnpc>>,group'])] += 1
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str33')
		exit
	elseif numnpc = 25 and $npc['25,group'] = 0:
		!Соня
		achiev['talk,'+val($npc['<<numnpc>>,group'])] += 1
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str40')
		gs 'npc_editor','change_rep','+',numnpc
		exit
	end
	! остальные нпс
	gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str'+($npc['<<numnpc>>,group']*2 + iif($npc['<<numnpc>>,dick'] > 0,3,4)))
else
	achiev['talk,'+val($npc['<<numnpc>>,group'])] += 1
	gs 'npc_editor','change_rep','+',numnpc
	if $npc['<<numnpc>>,relation'] < 20:
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str30')
	elseif $npc['<<numnpc>>,relation'] >= 20 and $npc['<<numnpc>>,relation'] < 80:
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str31')
	else
		gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str32')
		if numnpc = 1:
			!крутой Дима Носов
			if $npc['4,qwMeetDiana'] = 3: act 'Сказать на счёт "Дианы"': gt 'igor_events','dima_talk2'
			if $npc['4,qwMeetDiana'] = 7: act 'Сказать о свидании с "Дианой"': gt 'igor_events','dima_talk4'
			if $npc['1,qwDimaRude'] > 0 and DimaRudeBlock = 0: gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str35')
		elseif numnpc = 3:
			!спортик Иван Прохоров
			if $npc['3,qwIvanShower'] = 1:
				$npc['3,qwIvanShower'] = 2
				gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str36')
			elseif $npc['3,qwIvanShower'] = 10:
				$npc['3,qwIvanShower'] = 11
				manna -= rand(10,20)
				gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str37')
			end
		elseif numnpc = 14:
			!Катя Мейнольд
			if $npc['14,qwKatya'] >= 10: gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str38')
		elseif numnpc = 18:
			!кристина зверева
			if kristinaSex = 0 and swinbeggor > 0:
				$npc['<<numnpc>>,relation'] = 20
				gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str39')
			end
			if kristinaSex > 0: gs 'zz_render', '', '', func('check_gorslut_strings', 'local_str24')
		end
	end
end