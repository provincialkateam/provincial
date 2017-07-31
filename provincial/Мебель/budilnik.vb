if $args[0] = 'start':
	cla
	*clr
	'<center><img src="images/pic/bed2.jpg"></center>'
	act 'Назад': gt 'budilnik', 'finish'
	if digit = 0 and timer = 0 and timerM = 0: '<center>00 : 00</center>'
	if digit > 0 and timer = 0 and timerM = 0:
		$zz_str = iif(digit >= 1,'<b>'+zz_alarm[0]+'</b>','0')
		$zz_str += iif(digit >= 2,'<b>'+zz_alarm[1]+'</b>','0') + ' : '
		$zz_str += iif(digit >= 3,'<b>'+zz_alarm[2]+'</b>','0')
		$zz_str += iif(digit >= 4,'<b>'+zz_alarm[3]+'</b>','0')
		'<center>'+$zz_str+'</center>'
	end
	if timer > 0 or timerM > 0:
		'<center><b>' + iif(timer<10,'0'+str(timer),timer) + ' : ' + iif(timerM<10,'0'+str(timerM),timerM) + '</b></center>'
	end
	*nl
	i = 1
	$zz_str = '<center><b>'
	:loop_clock
	if i < 10:
		$zz_str += '<a href="exec:gt ''budilnik'',''click'',' + i + '">' + i + '</a> '
		if (i mod 3) = 0: $zz_str += '</b></center><br><center><b>'
		i += 1
		jump 'loop_clock'
	end
	$zz_str += '<a href="exec:gt ''budilnik'',''click'',0">0</a></b></center>'
	*pl $zz_str
	killvar '$zz_str'
	'<center><b><a href="exec:gt ''budilnik'',''reset''">Сброс</a> <a href="exec:gt ''budilnik'',''set_time''">Установить время</a></b></center>'
end
if $args[0] = 'click':
	if digit = 0:
		if args[1] > 2:
			zz_alarm[0] = 0
			gt 'budilnik', 'start'
		else
			zz_alarm[0] = args[1]
		end
		digit = 1
		gt 'budilnik', 'start'
	end
	if digit = 1:
		zz_alarm[1] = args[1]
		if zz_alarm[0]*10 + zz_alarm[1] >= 24:
			zz_alarm[0] = 0
			zz_alarm[1] = 0
			digit = 0
			gt 'budilnik', 'start'
		else
			digit = 2
			gt 'budilnik', 'start'
		end
	end
	if digit = 2:
		if args[1] > 5:
			zz_alarm[2] = 0
			gt 'budilnik', 'start'
		else
			zz_alarm[2] = args[1]
		end
		digit = 3
		gt 'budilnik', 'start'
	end
	if digit = 3:
		zz_alarm[3] = args[1]
		if zz_alarm[2]*10 + zz_alarm[3] > 60:
			zz_alarm[2] = 0
			zz_alarm[3] = 0
			digit = 2
		else
			digit = 4
		end
		gt 'budilnik', 'start'
	end
	if digit = 4: gt 'budilnik', 'start'
end
if $args[0] = 'set_time':
	timer = zz_alarm[0]*10 + zz_alarm[1]
	timerM = zz_alarm[2]*10 + zz_alarm[3]
	digit = 0
	killvar 'zz_alarm'
	gt 'budilnik', 'finish'
end
if $args[0] = 'reset':
	timer = 0
	timerM = 0
	digit = 0
	killvar 'zz_alarm'
	gt 'budilnik', 'start'
end
if $args[0] = 'finish':
	killvar 'digit'
	killvar 'zz_alarm'
	gs 'bed','start'
end