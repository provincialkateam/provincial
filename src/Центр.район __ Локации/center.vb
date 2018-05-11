$metka = $ARGS[0]
$loc = $CURLOC
$control_point = 'center'
gs 'stat'
gs 'time'
gs 'tanya_events','tanya_call_check'
!---
!мини-ивенты:
gs 'short_random','check'
!---
if health < 5 and rand(0,10) < 2: gt 'short_random','divine_intervention'
!---
gs 'zz_render', 'Центр города', func('zz_funcs','mk_image','city/center/center')
if _taxi_time >= 0: gs 'taxi','check'
gs 'zz_loc_desc'
gs 'zz_funcs', 'waiting'
gs 'car', 'check'
gs 'zz_dyns', 'street_cum'