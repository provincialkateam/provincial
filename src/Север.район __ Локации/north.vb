$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
$control_point = $curloc
gs 'stat'
gs 'time'
gs 'banda_events','banda_check'
gs 'tanya_events','tanya_call_check'
!---
!мини-ивенты:
gs 'short_random','check'
!---
if health < 5 and rand(0,10) < 2: gt 'short_random','divine_intervention'
!---
gs 'zz_render','Северный район',func('zz_funcs','mk_image','city/north/north')
if _taxi_time >= 0: gs 'taxi','check'
gs 'zz_loc_desc'
!---
gs 'zz_funcs', 'waiting'
gs 'car','check'
gs 'zz_dyns','street_cum'
!---
! продвижение Сони
if $npc['25,qwSonya'] = 95 and $npc['25,qwSonya_day'] ! day and hour >= 11 and hour <= 17:
	act 'Заняться продвижением Сони': gt 'sonya','sonya_promo_init'
end