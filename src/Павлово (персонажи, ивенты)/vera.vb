*clr & cla
gs 'zz_render','','pavlovo/rail_station/verasmoke.jpg',func('vera_str',iif($npc['29,know']=0,0,1))
!$npc['29,talk_day'] = day
minut += rand(3,10)
if $npc['29,know'] = 0:
	$npc['29,know'] = 1
	$npc['29,relation'] = 40
	act 'Отойти': gt 'vokzalGin'
else
	act 'Болтать':
		cla
		gs 'zz_render','','',func('vera_str',2)
		gs 'npc_editor','change_rep','+', 29
		act 'Уйти': gt 'vokzalGin'
	end
	if ($npc['29,relation'] > 60 and $npc['29,qwVeraStory'] < 3) or ($npc['29,relation'] > 80 and $npc['29,qwVeraStory'] < 10):
		act 'Говорить за жизнь':
			cla
			gs 'zz_render','','',func('vera_str',3+$npc['29,qwVeraStory'])
			gs 'npc_editor','change_rep','+',29
			$npc['29,qwVeraStory'] += 1
			act 'Уйти': gt 'vokzalGin'
		end
	end
end