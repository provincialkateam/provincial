if $args[0] = '': $args[0] = 'main'
if $args[0] = 'init':
	! temperature
	! jan
	tc['0,0'] = -10
	tc['0,1'] = -12
	tc['0,2'] = -14
	tc['0,3'] = -12
	! feb
	tc['1,0'] = -8
	tc['1,1'] = -6
	tc['1,2'] = -4
	! mar
	tc['2,0'] = -2
	tc['2,1'] = 0
	tc['2,2'] = 2
	tc['2,3'] = 4
	! apr
	tc['3,0'] = 6
	tc['3,1'] = 8
	tc['3,2'] = 10
	tc['3,3'] = 11
	! may
	tc['4,0'] = 12
	tc['4,1'] = 14
	tc['4,2'] = 16
	tc['4,3'] = 17
	! jun
	tc['5,0'] = 19
	tc['5,1'] = 21
	tc['5,2'] = 23
	tc['5,3'] = 25
	! jul
	tc['6,0'] = 27
	tc['6,1'] = 29
	tc['6,2'] = 31
	tc['6,3'] = 30
	! aug
	tc['7,0'] = 30
	tc['7,1'] = 28
	tc['7,2'] = 26
	tc['7,3'] = 24
	! sep
	tc['8,0'] = 24
	tc['8,1'] = 22
	tc['8,2'] = 20
	tc['8,3'] = 18
	! oct
	tc['9,0'] = 16
	tc['9,1'] = 13
	tc['9,2'] = 10
	tc['9,3'] = 8
	! nov
	tc['10,0'] = 6
	tc['10,1'] = 3
	tc['10,2'] = 0
	tc['10,3'] = -2
	! dec
	tc['11,0'] = -4
	tc['11,1'] = -6
	tc['11,2'] = -8
	tc['11,3'] = -10
end
! args[1] - month
! args[2] - day
if $args[0] = 'main':
	! set per day flag
	weather_day = day
	! init temperature array
	if arrsize('tc') <= 0: gs 'zz_weather','init'
	!snow is melting
	if temper > 0 and snow > 0: snow -= temper
	! calc rain/sun
	if sunWeather = 1:
		if month = 4 or month = 5:
			sunWeather = rand(-3,-1)
		elseif month >= 9 and month <= 11:
			sunWeather = rand(-4,-1)
		elseif month >= 6 and month <= 8:
			sunWeather = rand(-2,-1)
		else
			sunWeather = rand(-3,-1)
		end
	elseif sunWeather = -1:
		! sunny days
		if month = 4 or month = 5:
			sunWeather = rand(4,6)
		elseif month >= 9 and month <= 11:
			sunWeather = rand(3,5)
		elseif month >= 6 and month <= 8:
			sunWeather = rand(6,10)
		else
			sunWeather = rand(3,6)
		end
	elseif sunWeather = 0:
		sunWeather = rand(1,3)
	end
	! set temperature
	temper = tc['<<month-1>>,<<day/10>>']
	if sunWeather < -1:
		sunWeather += 1
	elseif sunWeather > 1:
		sunWeather -= 1
	end
	if sunWeather > 0:
		! sunny
		if temper < 0:
			temper -= rand(1,3)
		else
			temper += rand(1,3)
		end
	elseif sunWeather < 0:
		! rain/snow
		if temper < 0:
			!loss of snow
			if snow < 30: snow += 1
			temper += rand(1,3)
			if temper > 0: temper = 0
		else
			temper -= rand(1,3)
			if temper < 0: temper = 0
		end
	end
	killvar 'tc'
end
if $args[0] = 'forecast':
	! init
	_forecast['month'] = month
	_forecast['day'] = day
	! get tomorrow day/month
	if (month = 1 or month = 3 or month = 5 or month = 7 or month = 8 or month = 10 or month = 12) and day = 31:
		_forecast['day'] = 1
	elseif month = 2 and (day = 28 or day = 29):
		if (year mod 4 = 0 and day = 29) or (year mod 4 > 0 and day = 28):
			_forecast['day'] = 1
		else
			_forecast['day'] += 1
		end
	elseif (month = 2 or month = 4 or month = 6 or month = 9 or month = 11) and day = 30:
		_forecast['day'] = 1
	else
		_forecast['day'] += 1
	end
	! check month
	if _forecast['day'] = 1: _forecast['month'] += 1
	if _forecast['month'] = 13: _forecast['month'] = 1
	! sunny/rainy
	if sunWeather > 1:
		_forecast['sunny'] = sunWeather - 1
	elseif sunWeather = 1:
		_forecast['sunny'] = -1
	elseif sunWeather = 0:
		_forecast['sunny'] = 1
	elseif sunWeather = -1:
		_forecast['sunny'] = 3
	elseif sunWeather < -1:
		_forecast['sunny'] = sunWeather + 1
	end
	! init temperature array
	if arrsize('tc') <= 0: gs 'zz_weather','init'
	! temperature
	_forecast['tC'] = tc['<<_forecast[''month'']-1>>,<<_forecast[''day'']/10>>']
	if _forecast['sunny'] >= 0:
		! sunny
		if _forecast['tC'] < 0:
			_forecast['tC_min'] = _forecast['tC'] - 3
			_forecast['tC_max'] = _forecast['tC'] - 1
		else
			_forecast['tC_min'] = _forecast['tC'] + 1
			_forecast['tC_max'] = _forecast['tC'] + 3
		end
	else
		! rain/snow
		if _forecast['tC'] < 0:
			_forecast['tC_min'] = _forecast['tC'] + 1
			_forecast['tC_max'] = _forecast['tC'] + 3
			if _forecast['tC_max'] > 0: _forecast['tC_max'] = 0
		else
			_forecast['tC_min'] = _forecast['tC'] - 3
			_forecast['tC_max'] = _forecast['tC'] - 1
			if _forecast['tC_min'] < 0: _forecast['tC_min'] = 0
		end
	end
	gs 'zz_render','<br><br>Прогноз погоды на завтра','',func('zz_weather','make_image',_forecast['sunny'],_forecast['tC'],1,_forecast['tC_min'],_forecast['tC_max'])
	killvar '_forecast'
	killvar 'tc'
end
if $args[0] = 'make_image':
	! required
	! args[1] - sunny/rainy
	! args[2] - temperature
	! optional
	! args[3] - forecast flag - 0/1
	! args[4] - t_min
	! args[5] - t_max
	!---
	_sunny = args[1]
	_temperature = args[2]
	_forecast_flag = args[3]
	_t_min = args[4]
	_t_max = args[5]
	! sunny
	if _sunny = 1: $_wimg = iif(hour>12,4,3)
	if _sunny = 2: $_wimg = 2
	if _sunny = 3: $_wimg = 1
	if _sunny >= 4: $_wimg = 0
	! rain/snow
	if _sunny = -1: $_wimg = iif(_temperature>0,5,7)
	if _sunny < -1: $_wimg = iif(_temperature>0,6,8)
	! add prefix if needed
	$_wimg = iif(_forecast_flag=0, iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'d','n'),'d') + $_wimg
	$_wstr = iif(_forecast_flag=0, _temperature+'&deg;C', iif(_t_min <= _t_max, _t_min+'...'+_t_max, _t_max+'...'+_t_min) + '<br>&deg;C')
	$result = '<center><table border=0 width=250 align=center><tr><td><img height=128 src="images/common/mobile/weather/'+$_wimg+'.png"></td><td><img height=128 src="images/common/mobile/weather/therm.png"></td><td><font size=8>'+$_wstr+'</font></td></tr></table></center>'
	killvar '_sunny'
	killvar '_temperature'
	killvar '_forecast_flag'
	killvar '$_wstr'
	killvar '_t_min'
	killvar '_t_max'
	killvar '$_wimg'
	killvar '$_wstr'
end
! восход
if $args[0] = 'sunrise':
	result = val(func('zz_funcs','get_item_string','8,7,7,6,5,5,5,6,6,7,7,8',month-1))
end
! закат
if $args[0] = 'sunset':
	result = val(func('zz_funcs','get_item_string','16,17,18,19,20,21,21,20,19,18,17,16',month-1))
end