if $ARGS[0] = 'sarai':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 1
	gs 'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/new/findvel.jpg"></center>'
	'Старенький велосипед. Но с виду он в исправном состоянии, так что ездить можно.'
	if sunWeather < 0:'Но не во время дождя.'
	if hour >= 6 and hour <= 20 and sunWeather >= 0 and month >= 4 and month <= 10:
		if findvelday ! daystart:
			act 'Кататься на велосипеде':
				*clr & cla
				findvelday = daystart
				minut += 60
				beg += RAND(0,2)
				speed += rand(0,2)
				body['day_weight'] -= 1
				manna += 5
				sweat += 2
				findvelrand = RAND(0,100)
				if current_clothing = 0:
					horny += 20
					gs 'stat'
					'<center><img src="images/qwest/gadukino/bike_nude.jpg"></center>'
					'Вы катаетесь голышем, избегая людных мест и ликуя от своей смелости. Трудно сказать, чего в вас больше: страха или желания быть замеченой.'
					act 'Закончить поездку':gt $loc, $metka
					exit
				end
				if func('zz_clothing','is_skirt') = 1 and findvelrand > 70:
					horny += 5
					gs 'stat'
					if tanga=1:
						'<center><img src="images/qwest/gadukino/bike_tanga_1.jpg"></center>'
						'Во время поездки у вас несколько раз задирается юбка, открывая прохожим вид на ваши трусы и попу'
					else
						'<center><img src="images/qwest/gadukino/bike_tanga_2.jpg"></center>'
						'Во время поездки у вас несколько раз задирается юбка, открывая прохожим вид на вашу ничем не прикрытую попу'
					end
					act 'Закончить поездку':gt $loc, $metka
					exit
				end
				if func('zz_clothing','is_skirt') = 1 and findvelrand <= 70:
					'<center><img src="images/qwest/gadukino/bike_2.jpg"></center>'
					'Вы катаетесь на велосипеде, наслаждаясь окружающей вас природой.'
					act 'Закончить поездку':gt $loc, $metka
					exit
				end
				if func('zz_clothing','is_skirt') = 0:
					'<center><img src="images/qwest/gadukino/bike.jpg"></center>'
					'Вы катаетесь на велосипеде, наслаждаясь окружающей вас природой.'
					act 'Закончить поездку':gt $loc, $metka
					exit
				end
			end
		end
	end
	if goforest > 0 and sunWeather >= 0 and month >= 4 and month <= 10:
		act 'Ехать в лес':
			*clr & cla
			minut += 25
			manna += 5
			findvel = 2
			gs'stat'
			dynamic $clothes_findvel
			'Вы сели на велосипед и отправились в лес.'
			act 'Далее':gt'gadforest','1'
		end
	end
	if goswamp = 1 and sunWeather >= 0 and month >= 4 and month <= 10:
		act 'Ехать на болото':
			*clr & cla
			minut += 75
			beg += RAND(0,1)
			speed += rand(0,1)
			body['day_weight'] -= 1
			manna += 5
			sweat += 1
			findvel = 3
			gs'stat'
			gs'time'
			dynamic $clothes_findvel
			'Вы сели на велосипед и отправились на болото.'
			if hour >= 6 and hour < 22:
				act 'Далее':gt'swamp_yard'
			else
				act 'Далее': gt'gameover',9
			end
		end
	end
	act 'Поставить велосипед': gt'Gadsarai'
end
if $ARGS[0] = 'forest':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 1
	gs 'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/new/findvel.jpg"></center>'
	act 'Ехать в деревню':
		if current_clothing > 0 or (current_clothing >= 0 and exhibi > 0):
			*clr & cla
			manna += 5
			findvel = 1
			minut += 25
			gs'stat'
			dynamic $clothes_findvel
			'Вы сели на велосипед и отправились в деревню.'
			act 'Далее':gt 'Gaddvor'
		else
			*clr & cla
			'<center><img src="images/qwest/gadukino/new/findvel_nude.jpg"></center>'
			'Вы не можете появиться в таком виде в деревне.'
			act 'Далее':gt'gadforest','1'
		end
	end
	if goswamp = 1:
		act 'Ехать на болото':
			*clr & cla
			minut += 50
			manna += 5
			findvel = 3
			gs'stat'
			gs'time'
			dynamic $clothes_findvel
			'Вы сели на велосипед и отправились на болото.'
			if hour >= 6 and hour < 22:
				act 'Далее':gt'swamp_yard'
			else
				act 'Далее': gt'gameover',9
			end
		end
	end
	act 'Поставить велосипед': gt'gadforest','1'
end
if $ARGS[0] = 'swamp':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 1
	gs 'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/new/findvel.jpg"></center>'
	act 'Ехать в деревню':
		if current_clothing > 0 or (current_clothing >= 0 and exhibi > 0):
			*clr & cla
			minut += 75
			beg += RAND(0,1)
			speed += rand(0,1)
			body['day_weight'] -= 1
			sweat += 1
			manna += 10
			findvel = 1
			hanters = 0
			gs'stat'
			gs'time'
			dynamic $clothes_findvel
			'Вы сели на велосипед и отправились в деревню.'
			if hour >= 6 and hour < 22:
				act 'Далее':gt 'Gaddvor'
			else
				act 'Далее': gt'gameover',9
			end
		else
			*clr & cla
			'<center><img src="images/qwest/gadukino/new/findvel_nude.jpg"></center>'
			'Вы не можете появиться в таком виде в деревне.'
			act 'Далее':gt'swamp_yard'
		end
	end
	act 'Ехать в лес':
		*clr & cla
		minut += 50
		manna += 5
		hanters = 0
		findvel = 2
		gs'stat'
		gs'time'
		dynamic $clothes_findvel
		'Вы сели на велосипед и отправились в лес.'
		if hour >= 6 and hour < 22:
			act 'Далее':gt'gadforest','1'
		else
			act 'Далее': gt'gameover',9
		end
	end
	act 'Поставить велосипед': gt'swamp_yard'
end
$clothes_findvel = {
	if current_clothing > 2: '<center><img src="images/qwest/gadukino/bike'+iif(func('zz_clothing','is_skirt') = 0,'','_2')+'.jpg"></center>'
	if current_clothing = 0:'<center><img src="images/qwest/gadukino/bike_nude.jpg"></center>'
}