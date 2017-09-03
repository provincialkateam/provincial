if $args[0] = 'mock':
	if $npc['<<numnpc>>,group'] = 0:
		act 'Издеваться':
			*clr & cla
			if func('zz_reputation','get') < 2:
				$npc['<<numnpc>>,relation'] -= 5
				dom += 1
				gs 'zz_render','','',func('gnpc_events_strings', 'local_str16')
			else
				dom -= 1
				gs 'zz_render','','',func('gnpc_events_strings', 'local_str17')
			end
			act 'Отойти': gt $loc, $metka
		end
	end
end
if $args[0] = 'cumreaction':
	if cumface + cumfrot + cumlip > 0:
		$npc['<<numnpc>>,relation'] -= 10
		if func('zz_reputation','get') < 2: gs 'zz_reputation','set',2
		gs 'zz_render','','',func('gnpc_events_strings', 'local_str18')
		act 'Отойти': gt $loc, $metka
		exit
	end
end
! --
if $args[0] = 'krutishi_dance':
	*clr & cla
	minut += 5
	$npc['<<numnpc>>,relation'] += 5
	dance += RAND(1,3)
	gs 'npc_editor','get_npc_profile',numnpc
	gs 'stat'
	gs 'zz_render', '', '', func('krutishi_strings', 'local_str2')
	if numnpc = 4 and $npc['<<numnpc>>,relation'] >= 80:
		!Игорь Круглов
		horny += 5
		gs 'stat'
		if $npc['4,qwIgorLove'] > 0:
			gs 'zz_render', '', '', func('krutishi_strings', 'local_str'+iif(IgorDominaQW = 0,3,4))
			act 'Идти к Игорю': minut += 20 & gt 'igorHome'
			if alko < 6: act 'Отказаться': gt $loc, $metka
		else
			gs 'zz_render', '', '', func('krutishi_strings', 'local_str5')
			if $npc['1,qwDimaRude'] > 0:
				gs 'zz_render', '', '', func('krutishi_strings', 'local_str6')
				act 'Идти на улицу':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'npc_editor','get_npc_profile',numnpc
					gs 'zz_render', '', '', func('krutishi_strings', 'local_str7')
					gs 'gnpc_events','igor_disco_bj'
				end
				if dom > -25:
					act 'Отказываться':
						*clr & cla
						dom -= 1
						gs 'npc_editor','get_npc_profile',numnpc
						gs 'zz_render', '', '', func('krutishi_strings', 'local_str8')
						gs 'gnpc_events','igor_dima_disco_bj'
					end
				end
			else
				if $npc['1,relation'] = 0:
					gs 'zz_render', '', '', func('krutishi_strings', 'local_str9')
					gs 'gnpc_events','igor_disco'
				else
					gs 'zz_render', '', '', func('krutishi_strings', 'local_str10')
					gs 'gnpc_events','igor_disco'
				end
			end
		end
	elseif numnpc = 1 and $npc['<<numnpc>>,relation'] >= 80 and $npc['1,qwDimaRude'] > 0:
		gs 'zz_render', '', '', func('krutishi_strings', 'local_str11')
		if alko < 3 and dom > -10: act 'Отказаться': $npc['<<numnpc>>,relation'] -= 5 & gt $loc, $metka
		act 'Идти с Димой на улицу':
			*clr & cla
			dom -= 1
			minut += 5
			gs 'stat'
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render', '', '', func('krutishi_strings', 'local_str12')
			if DimaRudeBlock = 1:act 'Отказаться': $npc['<<numnpc>>,relation'] -= 5 & gt $loc, $metka
			act 'Сесть на корточки': gt 'gnpc_events','predlog_dima_bj'
		end
	elseif numnpc = 1 and $npc['<<numnpc>>,relation'] >= 80 and $npc['1,qwDimaRude'] = 0 and $npc['4,qwIgorLove'] = 0:
		gs 'zz_render', '', '', func('krutishi_strings', 'local_str13')
		if alko < 3 and dom > -25: act 'Отказаться': $npc['<<numnpc>>,relation'] -= 5 & gt $loc, $metka
		act 'Идти с Димой на улицу':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render', '', '', func('krutishi_strings', 'local_str14')
			act 'Нет':
				*clr & cla
				gs 'npc_editor','get_npc_profile',numnpc
				gs 'zz_render', '', '', func('krutishi_strings', 'local_str15')
				act 'Ну может быть немного':
					*clr & cla
					dom -= 1
					gs 'npc_editor','get_npc_profile',numnpc
					gs 'zz_render', '', '', func('krutishi_strings', 'local_str16')
					gs 'gnpc_events','dima_predlog'
				end
				if dom >= 0: act 'Уйти': gt $loc, $metka
			end
			act 'Да':
				*clr & cla
				gs 'npc_editor','get_npc_profile',numnpc
				gs 'zz_render', '', '', func('krutishi_strings', 'local_str17')
				gs 'gnpc_events','dima_predlog'
			end
		end
	else
		act 'Отойти': gt $loc, $metka
	end
end
if $args[0] = 'dima_predlog':
	if shameless['flag'] = 0 and dom > -25 or dom >= 25:
		act 'Дать ему пощечину':
			*clr & cla
			dom += 1
			$npc['<<numnpc>>,relation'] = 0
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str5')
			act 'Уйти': gt 'gdk'
		end
	end
	if shameless['flag'] > 0:
		act 'Смутиться':
			*clr & cla
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str6')
			if dom >= 10:
				act 'Дать ему пощечину':
					*clr & cla
					dom += 1
					$npc['<<numnpc>>,relation'] = 0
					gs 'npc_editor','get_npc_profile',numnpc
					gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str5')
					act 'Уйти': gt 'gdk'
				end
			end
			if shameless['flag'] = 1 and dom > -10:
				act 'А ты никому не скажешь?':
					*clr & cla
					dom -= 1
					gs 'npc_editor','get_npc_profile',numnpc
					gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str8')
					act 'Сесть на корточки': gt 'gnpc_events','predlog_dima_bj'
					if dom >= 0: act 'Передумать': $npc['<<numnpc>>,relation'] -= 10 & gt 'gdk'
				end
			else
				act 'Сесть на корточки': gt 'gnpc_events','predlog_dima_bj'
			end
		end
	end
	if shameless['flag'] > 1 or dom <= -25: act 'Сесть на корточки': gt 'gnpc_events','predlog_dima_bj'
end
if $args[0] = 'predlog_dima_bj':
	$npc['1,qwDimaRude'] = 1
	daynosovrevenge = daystart
	gs 'npc_editor','get_npc_profile',numnpc
	gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str1')
	act 'Взять в рот':
		*clr & cla
		minut += 5
		horny += 10
		bj += 1
		bja += 1
		dick = 16
		if $npc['<<numnpc>>,sex'] = 0: $npc['<<numnpc>>,sex'] = 1 & guy += 1
		dom -= 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/cocksucker2.jpg', func('gnpc_events_strings', 'local_str2')
		act 'Сосать':
			*clr & cla
			minut += 5
			dick = $npc['<<numnpc>>,dick']
			if throat < dick: throat += 1
			dom -= 1
			if mop > 1: mop = 0 & vidageday -= 1
			manna -= rand(10,20)
			horny = 0
			hapri = 0
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Ev/cocksucker3.jpg', func('gnpc_events_strings', 'local_str3')
			act 'Пытаться отдышаться':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				cumfrot += 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/cocksucker4.jpg', func('gnpc_events_strings', 'local_str4')
				act 'Уйти': gt 'gdk'
			end
		end
	end
end
if $args[0] = 'igor_disco_bj':
	act 'Сесть на корточки':
		*clr & cla
		if $npc['<<numnpc>>,sex'] = 0: $npc['<<numnpc>>,sex'] = 1 & guy += 1
		dick = $npc['<<numnpc>>,dick']
		bj += 1
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'qwest/alter/Ev/cocksucker5.jpg', func('gnpc_events_strings', 'local_str9')
		act 'Уйти': gt 'gdk'
	end
end
if $args[0] = 'igor_dima_disco_bj':
	act 'Сесть на корточки':
		*clr & cla
		daynosovrevenge = daystart
		if $npc['<<numnpc>>,sex'] = 0: $npc['<<numnpc>>,sex'] = 1 & guy += 1
		dick = $npc['<<numnpc>>,dick']
		bj += 2
		gs 'zz_funcs', 'cum', 'lip'
		swallow += 1
		minut += 10
		gs 'stat'
		gs 'zz_render', '', 'qwest/alter/Ev/cocksucker6.jpg', func('gnpc_events_strings', 'local_str10')
		act 'Уйти': gt 'gdk'
	end
end
if $args[0] = 'igor_disco':
	act 'Идти на улицу':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'npc_editor','get_npc_profile',numnpc
		gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str11')
		act 'Согласиться':
			*clr & cla
			$npc['4,qwIgorLove'] = 1
			!Если отношения с Носов были испорчены, они нормализуются, чтобы убрать несостыковки в ивенте "Дианы"
			if $npc['1,relation'] < 40: $npc['1,relation'] = 40
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str12')
			!Пока закомментировал, так как к ивенту "Дианы" не имеет никакого отношения
			!if dom >= 25:
				!act 'Перебьешься':
					!*clr & cla
					!dom += 1
					!IgorDominaQW = 1
					!gs 'npc_editor','get_npc_profile',numnpc
					!gs 'zz_render', '', '', func('gnpc_events_strings', 'local_str13')
					!if dom >= 50:
						!act 'Можешь поцеловать мои ноги':
							!*clr & cla
							!dom += 1
							!gs 'zz_render', '', 'qwest/alter/Ev/leg.jpg', func('gnpc_events_strings', 'local_str14')
							!act 'Уйти': gt 'gdk'
						!end
					!end
					!gs 'gnpc_events','igor_disco_kiss'
				!end
			!end
			gs 'gnpc_events','igor_disco_kiss'
		end
		act 'Отказаться':$npc['<<numnpc>>,relation'] -= 10 & gt 'gdk'
	end
	if alko < 6: act 'Отказаться': gt $loc, $metka
end
if $args[0] = 'igor_disco_kiss':
	act 'Поцеловать':
		*clr & cla
		IgorLove += 5
		gs 'zz_render', '', 'qwest/alter/Ev/kiss.jpg', func('gnpc_events_strings', 'local_str15')
		act 'Уйти': gt 'gdk'
	end
end
if $args[0] = 'drink':
	act 'Пить пиво':
		*clr & cla
		gs 'zz_funcs','alko',2
		gs 'stat'
		gs 'npc_editor','change_rep','+',numnpc
		gs 'npc_editor','get_npc_profile',numnpc
		gs 'zz_render','','',func('Snpc_strings', 'local_str8')
		act 'Отойти': gt $loc, $metka
	end
	if alko < 3 or alko >= 6:
		act 'Отказаться':
			*clr & cla
			if alko < 3: $npc['<<numnpc>>,relation'] -= 5
			gs 'npc_editor','get_npc_profile',numnpc
			gs 'zz_render','','', iif(alko < 3,'\\- Извини, <<$npc[''<<numnpc>>,name'']>>, я не хочу пить.//- сказали вы парню.','\\- Нет, <<npc[''<<numnpc>>,nickname'']>>... ик ... Мне уже... ик.... хватит...//- выдавили вы из себя.')
			act 'Отойти': gt $loc, $metka
		end
	end
end