if $args[0] = '': $args[0] = 'main'
if $args[0] = 'main':
	$metka = $ARGS[0]
	$loc = $CURLOC
	$control_point = $curloc
	gs 'stat'
	gs 'time'
	gs 'zz_render','Дачный кооператив','images/pic/dachi.jpg',func('dachi_strings','local_str1') + iif(dachaest = 1,func('dachi_strings','local_str2'),'')
	gs 'car', 'check'
	if _taxi_time >= 0: gs 'taxi','check'
	act 'Прогуляться по аллеям': gt 'etoexhib', 'pos2'
	act 'Выйти на шоссе': minut += 15 & nroad = 5 & gt 'road'
end
if $args[0] = 'dachamy':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'time'
	gs 'zz_render','Дача','images/etogame/dachamy.jpg',func('dachi_strings','local_str3')
	act 'Зайти в домик': gt 'dachi','dachain'
	act 'Выйти на аллею': minut += 2 & gt 'dachi'
	if hour < 18 and hour >= 6:
		act 'Осмотреть огород':
			cla
			minut += 5
			if etoexhib < 16: gt 'dachi','dachaogr0'
			if etoexhib = 16: gt 'dachi','dachaogr'
		end
	end
end
if $args[0] = 'dachain':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Дача','images/etogame/dachain.jpg',func('dachi_strings','local_str3')
	if hour >= 6 and hour <= 20:
		if etoexhib = 11: gs 'zz_render','','',func('dachi_strings','local_str4')
		if etoexhib = 12: gs 'zz_render','','',func('dachi_strings','local_str5')
		if etoexhib = 13 and temp ! day: gs 'zz_render','','',func('dachi_strings','local_str6')
	end
	act 'На кровать': gt 'bed','start'
	act 'Выйти наружу': minut += 1 & gt 'dachi','dachamy'
end
if $args[0] = 'dachaogr':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'time'
	gs 'zz_render','Огород','images/etogame/vspah.jpg', func('dachi_strings','local_str'+iif(month > 4 and month < 10,7,8))
	act 'Уйти':
		minut += 2
		gt 'dachi','dachamy'
	end
end
if $args[0] = 'dachaogr0':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'stat'
	gs 'time'
	gs 'zz_render','Огород','images/etogame/burjan.jpg', func('dachi_strings','local_str'+iif(month > 4 and month < 10,7,8))
	if etoexhib < 11:
		gs 'zz_render','','',func('dachi_strings','local_str9')
	elseif etoexhib = 11:
		gs 'zz_render','','',func('dachi_strings','local_str10')
	elseif etoexhib >= 12 and etoexhib < 14:
		gs 'zz_render','','',func('dachi_strings','local_str11')
	elseif etoexhib = 14 and temp ! day:
		*clr & cla
		gs 'zz_render','Огород','images/etogame/vspah.jpg',func('dachi_strings','local_str12')
		act 'Расплатиться': gt 'etoexhib','pos14'
	elseif etoexhib = 15 and temp ! day:
		*clr & cla
		gs 'zz_render','Огород','images/etogame/vspah.jpg',func('dachi_strings','local_str13')
		act 'Расплатиться деньгами':
			*clr & cla
			money -= 3000
			etoexhib = 16
			gs 'stat'
			gs 'zz_render','','',func('dachi_strings','local_str14')
			act 'К домику': minut += 2 & gt 'dachi','dachamy'
		end
		if etoexhib = 15 and horny > 30: act 'Расплатиться телом': gt 'etoexhib','pos13'
	end
	act 'К домику': minut += 2 & gt 'dachi','dachamy'
end