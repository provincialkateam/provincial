*clr & cla
frost = 0
gs 'stat'
gs 'time'
!---
! ивенты по ветке учителя
!---
if $npc['26,qwMain_day'] ! day:
	if $npc['26,qwMain'] = 127: gt 'tsarev_events','teacher_choice_detective13'
end
!---
gs 'zz_render','','pavlovo/carwash/main'
act '<b>Уйти</b>':
	!minut += rand(10,15)
	gt 'gorodok'
end
!----------
! работа на мойке открывается только по ветке учителя
if $npc['0,carwash'] = 1:
	act 'Работать':
		*clr & cla
		minut += rand(160,200)
		money += 300
		energy -= 2
		son -= 3
		if stren < 40: stren += 1
		sweat += 2
		gs 'stat'
		gs 'zz_render','','pavlovo/carwash/<<rand(0,2)>>','Вы проходите на автомойку, переодеваетесь и приступаете к работе. Футболка быстро намокает, и рабочие то и дело пялятся на вас. Делая вид, что не замечаете раздевающих взглядов, вы спокойно моете машины.'
		!---
		if $npc['26,qwMain'] >= 130 and $npc['26,qwMain'] <= 134:
			$npc['26,qwMain'] += 1
			if ($npc['26,qwMain'] >= 131 and rand(0,5) = 1) or $npc['26,qwMain'] = 135:
				act '...': gt 'tsarev_events','teacher_choice_detective14'
				exit
			end
		end
		!---
		act '<b>Уйти</b>':
			!minut += rand(10,15)
			gt 'gorodok'
		end
	end
end