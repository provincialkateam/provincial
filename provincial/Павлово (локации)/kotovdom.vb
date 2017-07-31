$loc = $curloc
$din_kotov_provod ={
	*clr & cla
	minut += 5
	kotov_bj_times = 0
	gs 'stat'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpr.'+iif(rand(1,2),'jpg','gif')+'"></center>'
	'Витек провел вас до дома, вы вместе поднялись на 2-ой этаж и остановились рядом с вашей квартирой.
Он поцеловал вас на прощанье, крепко лапая и сжимая ваши булки.
-Пока,<<$name[2]>>, еще встретимся, не скучай без меня.'
	act 'Уйти':gt'pod_ezd','etaj_2'
}
$din_kotov_vann ={
	*clr & cla
	minut += 5
	gs 'zz_bathroom','clean_me'
	gs 'stat'
	'<center><b><font color = maroon>Ванная</font></b></center>'
	'<center><img src="images/pics/wash5.jpg"></center>'
	''
	'Вы тщательно смыли сперму в ванной.'
	act 'Отойти': gt 'kotovdom','vann'
}
$din_kotov_kom ={
	*clr & cla
	minut += 5
	gs'stat'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovdom/vann.jpg"></center>'
	''
	if sweat >= 1:'Иди умойся <<$name[2]>>, выйди и там найдешь душ.'
	if sweat < 1:'Ну что, ты уже готова? Тогда идем, я тебя проведу до дома.'
	if sweat < 1: act 'Идти домой': dynamic $din_kotov_provod
	if sweat >= 1: act 'Отойти':gt 'kotovdom','kotovkom'
}
if $args[0] = 'vann':
	*clr & cla
	minut += 5
	gs'stat'
	'<center><b><font color = maroon>Ванная</font></b></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovdom/vann.jpg"></center>'
	'Старая ванная комната. Здесь можно <a href="exec:dynamic $din_kotov_vann">умыться</a> и привести себя в порядок.'
	act 'Выйти': gt 'kotovdom','kor'
end
if $args[0] = 'kor':
	*clr & cla
	minut += 5
	gs'stat'
	'<center><b><font color = maroon>Прихожая</font></b></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovdom/kor.jpg"></center>'
	''
	act 'Комната Витька': gt 'kotovdom','kotovkom'
	act 'Ванная': gt 'kotovdom','vann'
	act 'Кухня': gt 'kotovdom','kuh'
end
if $args[0] = 'kotovkom' or $args[0] = '':
	*clr & cla
	minut += 5
	gs 'stat'
	'<center><b><font color = maroon>Комната Витька</font></b></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovdom/kotovkom.jpg"></center>'
	''
	'<a href="exec:dynamic $din_kotov_kom">Витек</a> лежит на кровати и смотрит телек.'
	act 'Выйти': gt 'kotovdom','kor'
end
if $args[0] = 'kuh':
	*clr & cla
	minut += 5
	gs 'stat'
	'<center><b><font color = maroon>Кухня</font></b></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovdom/kuh.jpg"></center>'
	''
	act 'Выйти': gt 'kotovdom','kor'
end