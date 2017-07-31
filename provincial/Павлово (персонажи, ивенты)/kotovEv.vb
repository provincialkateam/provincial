if $npc['9,qwKotovLove'] >= 5 and GorSlut > 0:
	gs 'npc_editor','get_npc_profile',9
	gs 'zz_render','','',func('kotovEv_strings', 'local_str1')
	act 'Устроить скандал':
		*clr & cla
		$npc['9,relation'] = 0
		$npc['9,qwKotovLove'] = -1
		gs 'zz_render', '', '', func('kotovEv_strings', 'local_str2')
		act 'Отойти': gt $loc, $metka
	end
	if dom >= 20:
		act 'Убеждать, что все это сплетни':
			*clr & cla
			GorSlut = 0
			gs 'zz_render', '', '', func('kotovEv_strings', 'local_str3')
			act 'Отойти': gt $loc, $metka
		end
	end
	exit
end
if $loc = 'gdksport':
	if kotovKnowSport = 0:
		gs 'zz_render', '', '', func('kotovEv_strings', 'local_str4')
		act 'А ты что тут делаешь?':
			*clr & cla
			gs 'npc_editor','get_npc_profile',9
			gs 'zz_render','','', func('kotovEv_strings', 'local_str5')
			act 'Ты же пьешь, да еще и куришь!':
				*clr & cla
				kotovKnowSport = 1
				gs 'npc_editor','get_npc_profile',9
				gs 'zz_render','','', func('kotovEv_strings', 'local_str6')
				act 'Отойти':gt $loc, $metka
			end
		end
	else
		gs 'zz_render', '', '', func('kotovEv_strings', 'local_str7')
		act 'Отойти': gt $loc, $metka
	end
elseif $loc = 'zz_park':
	gs 'zz_render', '', '', func('kotovEv_strings', 'local_str8')
	act 'Извини, я спешу':gt $loc, $metka
	act 'Подойти':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'npc_editor','get_npc_profile',9
		gs 'zz_render','','',func('kotovEv_strings', 'local_str9')
		act 'Пить пиво':
			*clr & cla
			gs 'zz_funcs', 'alko', 2
			gs 'stat'
			gs 'zz_render', '', '', func('kotovEv_strings', 'local_str10')
			act 'Ладно, мне пора':
				*clr & cla
				gs 'npc_editor','get_npc_profile',9
				gs 'zz_render','','',func('kotovEv_strings', 'local_str11')
				if dom > 0: act 'Извини, я спешу': gt $loc, $metka
				act 'Идти к Витьку':
					*clr & cla
					minut += 15
					gs 'stat'
					gs 'npc_editor','get_npc_profile',9
					gs 'zz_render','','',func('kotovEv_strings', 'local_str12')
					act 'Далее': gt 'kotovSex'
				end
			end
		end
		act 'Извини, я спешу': gt $loc, $metka
	end
end