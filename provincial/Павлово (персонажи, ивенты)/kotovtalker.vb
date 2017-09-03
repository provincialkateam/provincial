! $npc['9,qwKotovLove']
! -1 - отношения испорчены
! 0 - не были в отношениях
! 1-4 - потанцульки с Котовым
! 5 - Светка встречается с Котовым
!----
if $args[0] = 'kotov_suspicion':
	gs 'zz_render','','',func('kotovtalker_strings',0)
	act 'Устроить скандал':
		*clr & cla
		$npc['9,qwKotovLove'] = -1
		gs 'stat'
		gs 'npc_editor','change_rep','-',9,100
		gs 'zz_render','','',func('kotovtalker_strings',1)
		act 'Отойти': gt $loc, $metka
	end
	if dom >= 20:
		act 'Убеждать, что все это сплетни':
			*clr & cla
			gs 'zz_reputation','set',0
			gs 'stat'
			gs 'zz_render','','',func('kotovtalker_strings',2)
			act 'Отойти': gt $loc, $metka
		end
	end
	exit
end
!--
if $args[0] = 'kotov_dancing':
	gs 'npc_editor','get_npc_profile',9
	gs 'zz_render', '','',func('kotovtalker_strings',3)
	act 'Танцевать': gt 'kotovtalker','kotov_dance'
	if dom >= 10 and alko < 6: act 'Отказаться': $npc['9,relation'] -= 5 & gt $loc, $metka
end
if $args[0] = 'kotov_dance':
	*clr & cla
	minut += 5
	dance += RAND(1,3)
	horny += 10
	if $npc['9,relation'] >= 80: $npc['9,qwKotovLove'] += 1
	gs 'stat'
	gs 'npc_editor','change_rep','+',9
	gs 'zz_render','','pavlovo/dk/disco/boys/21',func('kotovtalker_strings',4)
	if $npc['9,qwKotovLove'] < 5:
		act 'Отойти': gt $loc, $metka
	elseif $npc['9,qwKotovLove'] = 5:
		! Котов предлагает встречаться
		gs 'zz_render','','',func('kotovtalker_strings',5)
		if dom > -10:
			act 'Отказаться':
				*clr & cla
				gs 'npc_editor','change_rep','-',9,50
				$npc['9,qwKotovLove'] -= 1
				gs 'npc_editor','get_npc_profile',9
				gs 'zz_render','','',func('kotovtalker_strings',6)
				act 'Отойти': gt $loc, $metka
			end
		end
		act 'Согласиться':
			*clr & cla
			dom += 1
			gs 'npc_editor','get_npc_profile',9
			gs 'zz_render','','',func('kotovtalker_strings',7)
			act 'Отойти': gt $loc, $metka
		end
	else
		! Котов тащит Светку домой
		gs 'zz_render','','',func('kotovtalker_strings',8)
		act 'Отойти': gt $loc, $metka
		act 'Идти к Витьку':
			*clr & cla
			minut += 15
			$loc = 'kotovdom'
			$metka = 'kotovkom'
			gs 'stat'
			gs 'npc_editor','get_npc_profile',9
			gs 'zz_render','','',func('kotovtalker_strings',9)
			act 'Далее': gt 'kotovSex'
		end
	end
end
!--
if $args[0] = 'talk':
	gs 'zz_render','','',func('kotovtalker_strings',10)
	act 'Отойти': gt 'zz_school'
	exit
end