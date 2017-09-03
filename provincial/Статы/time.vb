if isprok = 0 and mesec > 0 and pregnancy = 0 and $settings['autotampon'] = 0:
	gs 'zz_render','','','<red>У вас кровь течет по ногам пачкая бельё и одежду.</red>'
	if clrbelo > 0 and mesecday ! day: mesecday = day & clrbelo -= 1
	sweat += 1
	manna -= 10
	gs 'zz_clothing', 'decrease_condition'
end
! смена бекграунда и цвета шрифта
if $settings['enable_background'] = 0:
	! цвета в зависимости от месяца и времени суток
	_sunrise = func('zz_weather','sunrise')
	_sunset = func('zz_weather','sunset')
	$_FColor = iif(hour < _sunrise or hour > _sunset,'#fff','#000')
	if hour < _sunrise - 1 or hour > _sunset + 1:
		$_BColor = $settings['day_color_0']
	elseif hour = _sunrise - 1:
		$_BColor = $settings['day_color_1']
	elseif hour = _sunrise:
		$_BColor = $settings['day_color_2']
	elseif hour = _sunrise + 1:
		$_BColor = $settings['day_color_3']
	elseif hour = _sunrise + 2:
		$_BColor = $settings['day_color_4']
	elseif hour = _sunset - 2:
		$_BColor = $settings['day_color_6']
	elseif hour = _sunset - 1:
		$_BColor = $settings['day_color_7']
	elseif hour = _sunset:
		$_BColor = $settings['day_color_8']
	elseif hour = _sunset + 1:
		$_BColor = $settings['day_color_9']
	else
		$_BColor = $settings['day_color_5']
	end
	*p '<script type="text/javascript">setBodyColors("'+$_BColor+'","'+$_FColor+'");</script>'
	killvar '_sunrise'
	killvar '_sunset'
	killvar '$_FColor'
	killvar '$_BColor'
end
if vibratorin = 1: horny += RAND(1,5)
if temper <= 0:
	if temper < -10 and palto = 1:
		frost += 1
		if energy < 5: frost += 1
		if tanga = 0: frost += 1
		if sweat > 0: frost += 1
	elseif temper < -20 and palto = 2:
		frost += 1
		if energy < 5: frost += 1
		if sweat > 0: frost += 1
	elseif temper < -30 and palto = 3:
		frost += 1
	end
	if palto <= 0:
		! в условии минус потому что температура тоже со знаком минус
		if temper < -5: frost -= (temper/3)
	end
	if frost >= 12: sick += 1
	if sick > 0 and sickstage = 0: sickstage = 1
end