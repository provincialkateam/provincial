$metka = $ARGS[0]
$loc = $CURLOC
$control_point = $curloc
gs 'stat'
gs 'time'
!--
gs 'tanya_events','tanya_call_check'
!---
!мини-ивенты:
gs 'short_random','check'
if health < 5 and rand(0,10) < 2: gt 'short_random','divine_intervention'
!---
gs 'zz_render','Южный район',func('zz_funcs','mk_image','images/city/south/street.jpg')
if _taxi_time >= 0: gs 'taxi','check'
gs 'zz_loc_desc'
!--
gs 'car', 'check'
gs 'zz_funcs', 'waiting'
if rand(0,100) >= 95:
	if hour <= 3: gt 'zz_park','rapist'
	if money >= 1000 and daystart >= 10 and hour <= 3: gt 'zz_park','robber'
end
if rand(0,300) > vnesh and bfa < 1:
	gs 'boy'
	gs 'zz_render', '', '', 'К вам подошел <<$boybody>> <<$boybod>> <<$boyface>>. Он <<$boyClo>>**Парень представился как <<$boy>> и попросил ваш телефончик.'
	if housr = 1:
		act 'Сказать ему телефон':
			cla
			gs'boyfrend','start'
			stopboy = 0
			gs 'zz_render', '', '', '<<$boyA>> записал ваш телефон и ушел.'
			act 'Завершить прогулку':gt $curloc
		end
	else
		gs 'zz_render', '', '', '\\- Извини, я не здесь живу, а в Павлово, -// мило улыбнулись вы ухажёру.**\\\- Жаль... -/// отошёл от вас парень.'
		act 'Отвернуться' : gt 'south'
	end
end
gs 'zz_dyns', 'street_cum'