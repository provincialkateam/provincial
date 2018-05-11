! ылитние пэтэушники подкатывают к Светке
! $npc['0,park_slut_event'] - день ивента
! $npc['0,park_slut_counter'] - счетчик ивентов
if $args[0] = 'slut_ev1':
	*clr & cla
	_stage = args[1]
	minut += iif(_stage < 2,rand(5,7),rand(10,15))
	if _stage = 4: gs 'zz_funcs','alko',4
	if _stage >= 5 and _stage <= 11: horny += rand(5,10)
	gs 'stat'
	gs 'zz_render','','pavlovo/park/slut_ev1/'+iif(_stage >= 16,0,_stage),func('park_events_str',_stage)
	act func('zz_funcs','get_item_string','Закурить,Идти с парнями,...,...,...,...,...,...,...,...,...,...,...,...,...,<b>Уйти</b>,<b>Уйти</b>,<b>Уйти</b>',_stage):
		if _stage = 10:
			gt 'park_events','slut_ev1',iif(horny > 80,11,12)
		elseif _stage = 11:
			horny = 0
			orgasm += 1
			vaginalorgasm += 1
			$npc['0,park_slut_counter'] += 1
			gt 'park_events','slut_ev1',_stage+1
		elseif _stage = 13:
			sex += 2
			guy += 2
			gs 'zz_funcs','cum','lip'
			gs 'zz_reputation','edit', -5
			gt 'park_events','slut_ev1',_stage+1
		elseif _stage = 14 and horny > 0:
			gt 'park_events','slut_ev1',15
		elseif _stage >= 15 or (_stage = 14 and horny = 0):
			$npc['0,park_slut_event'] = day
			minut += rand(10,15)
			gt $loc, $metka
		else
			gt 'park_events','slut_ev1',_stage+1
		end
	end
	if _stage = 0 or _stage = 1:
		act 'Отказаться': gt 'park_events','slut_ev1',_stage+16
	end
	exit
end
!---
! птушники подкатывают к Светке на перемене в школе
!---
if $args[0] = 'slut_ev2':
	*clr & cla
	_stage = args[1]
	$npc['0,park_slut_day'] = day
	gs 'zz_render','','pavlovo/park/slut_ev2/'+iif(_stage=0 or _stage = 5,0,_stage),func('park_events_str',_stage+18)
	if dom >= 10 and _stage = 0:
		act 'Отказаться': gt 'park_events','slut_ev2',5
	end
	act iif(_stage < 5,'...','Уйти'):
		if _stage < 4:
			gt 'park_events','slut_ev2',_stage+1
		else
			if _stage = 4:
				bj += 2
				facial += 2
				gs 'zz_funcs','cum','lip'
				gs 'zz_reputation','edit', -5
				$npc['0,park_slut_counter'] += 1
			end
			minut += 12*60+15 - (hour*60 + minut)
			gt 'zz_school'
		end
	end
end
!---
! птушники подкатывают к Светке в парке
!---
if $args[0] = 'slut_ev3':
	*clr & cla
	_stage = args[1]
	$npc['0,park_slut_day'] = day
	if _stage >= 1 and _stage <= 5: horny += rand(5,10)
	minut += rand(3,7)
	gs 'stat'
	gs 'zz_render','','pavlovo/park/slut_ev3/'+iif(_stage=0 or _stage=7,0,_stage),func('park_events_str',_stage+24)
	if dom >= 10 and _stage = 0:
		act 'Отказаться': gt 'park_events','slut_ev3',7
	end
	if _stage = 4 and horny >= 60 and anus >= 15 and stat_agape = 0: act 'Подставить попку': gt 'park_events','slut_ev4'
	act func('zz_funcs','get_item_string','Идти с парнями,...,...,...,Сосать дальше,...,Уйти,Уйти',_stage):
		if _stage <= 5:
			gt 'park_events','slut_ev3',_stage+1
		elseif _stage = 6:
			bj += 2
			gs 'zz_funcs','cum','lip'
			gs 'zz_reputation','edit', -5
			$npc['0,park_slut_counter'] += 1
			gt 'zz_park'
		else
			gt 'zz_park'
		end
	end
end
!---
! птушники подкатывают к Светке в парке - анал
!---
if $args[0] = 'slut_ev4':
	*clr & cla
	_stage = args[1]
	if _stage <= 4:
		horny += rand(5,10)
	elseif _stage = 5:
		horny = 0
	end
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/park/slut_ev4/<<_stage>>',func('park_events_str',_stage+32)
	act iif(_stage < 6,'...','Уйти'):
		if _stage < 6:
			gt 'park_events','slut_ev4',_stage+1
		else
			anal += 2
			analorgasm += 1
			orgasm += 1
			gs 'zz_funcs','cum','lip'
			gs 'zz_funcs','cum','anus'
			gs 'zz_reputation','edit', -5
			killvar '_stage'
			gt 'zz_park'
		end
	end
end
!---
! птушники подкатывают к Светке на улице
!---
if $args[0] = 'slut_ev5':
	*clr & cla
	_stage = args[1]
	minut += iif(_stage = 1,rand(10,15),rand(3,7))
	if _stage = 2:
		gs 'zz_funcs','alko',5
	elseif _stage >= 5 and _stage <= 11:
		horny += rand(10,15)
	elseif _stage = 12:
		horny = 0
	elseif _stage = 14:
		sex += 3
		anal += 3
		analorgasm += 1
		dp += 1
		orgasm += 1
		facial += 1
		gs 'zz_funcs','cum','lip'
		gs 'zz_funcs','cum','anus'
		$npc['0,park_slut_counter'] += 1
	end
	$npc['0,park_slut_day'] = day
	gs 'stat'
	gs 'zz_render','','pavlovo/park/slut_ev5/'+iif(_stage=15,1,_stage),func('park_events_str',_stage+39)
	if _stage = 0: act 'Отказаться и уйти': gt 'gorodok'
	if _stage = 14: act 'Выпить': gt 'park_events','slut_ev6'
	act func('zz_funcs','get_item_string','Идти с парнями,Выпить,...,...,...,...,...,...,...,...,...,...,...,...,Отказаться,<b>Уйти</b>',_stage):
		if _stage <= 14:
			gt 'park_events','slut_ev5',_stage+1
		else
			gs 'zz_reputation','edit',5
			killvar '_stage'
			gt $loc, $metka
		end
	end
end
!---
! птушники отводят Светку к старшакам
!---
if $args[0] = 'slut_ev6':
	*clr & cla
	_stage = args[1]
	if _stage = 0: gs 'zz_funcs','alko',5
	minut += rand(3,7)
	gs 'stat'
	gs 'zz_render','','pavlovo/park/slut_ev6/<<_stage>>',func('park_events_str',_stage+55)
	act iif(_stage < 9,'...','<b>Уйти</b>'):
		if _stage < 9:
			gt 'park_events','slut_ev6',_stage+1
		else
			bj += 5
			guys += 5
			gs 'zz_reputation','edit', -5
			gs 'zz_funcs','cum','lip'
			gs 'zz_funcs','cum','face'
			killvar '_stage'
			gt 'gorodok'
		end
	end
end