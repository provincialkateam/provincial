if $args[0] = '':
	*clr & cla
	act 'Назад': gt 'bed'
	$_str = '<a class="cheat" href="exec:gt''budilnik'',''set_time''">'+iif(timer<10,'0'+str(timer),timer)+'</a> : '
	$_str += '<a class="cheat" href="exec:gt''budilnik'',''set_time'',1">'+iif(timerM<10,'0'+str(timerM),timerM)+'</a>'
	gs 'zz_render','','','<div class="alarm_clock">'+$_str+'</div>'
	killvar '$_str'
end
if $args[0] = 'set_time':
	if args[1] = 0:
		timer += 1
		if timer > 23: timer = 0
	else
		timerM += 5
		if timerM > 59: timerM = 0
	end
	gt 'budilnik'
end