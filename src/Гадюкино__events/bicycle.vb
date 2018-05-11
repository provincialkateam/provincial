if $ARGS[0] = 'sarai':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'time'
	gs 'zz_render','','qwest/gadukino/new/findvel.jpg','Старенький велосипед. Но с виду он в исправном состоянии, так что ездить можно.'
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
				if cloth[0] = 0:
					horny += 20
					gs 'stat'
					gs 'zz_render','','qwest/gadukino/bike_nude.jpg','Вы катаетесь голышем, избегая людных мест и ликуя от своей смелости. Трудно сказать, чего в вас больше: страха или желания быть замеченой.'
					act 'Закончить поездку': gt $loc, $metka
					exit
				end
				if func('zz_clothing2','is_skirt') = 1:
					if rand(0,100) > 70:
						horny += 5
						gs 'stat'
						if cloth[1] = 1:
							gs 'zz_render','','qwest/gadukino/bike_tanga_1.jpg','Во время поездки у вас несколько раз задирается юбка, открывая прохожим вид на ваши трусы и попу'
						else
							gs 'zz_render','','qwest/gadukino/bike_tanga_2.jpg','Во время поездки у вас несколько раз задирается юбка, открывая прохожим вид на вашу ничем не прикрытую попу'
						end
						act 'Закончить поездку': gt $loc, $metka
						exit
					else
						gs 'zz_render','','images/qwest/gadukino/bike_2.jpg','Вы катаетесь на велосипеде, наслаждаясь окружающей вас природой.'
						act 'Закончить поездку': gt $loc, $metka
						exit
					end
				else
					gs 'zz_render','','images/qwest/gadukino/bike.jpg','Вы катаетесь на велосипеде, наслаждаясь окружающей вас природой.'
					act 'Закончить поездку': gt $loc, $metka
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
			gs 'stat'
			gs 'bicycle','clothes_findvel'
			gs 'zz_render','','','Вы сели на велосипед и отправились в лес.'
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
			gs 'stat'
			gs 'time'
			gs 'bicycle','clothes_findvel'
			gs 'zz_render','','','Вы сели на велосипед и отправились на болото.'
			if func('zz_weather','is_day') = 1:
				act 'Далее': gt'swamp_yard'
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
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'time'
	gs 'zz_render','','images/qwest/gadukino/new/findvel.jpg'
	act 'Ехать в деревню':
		if cloth[0] > 0 or (cloth[0] >= 0 and exhibi > 0):
			*clr & cla
			manna += 5
			findvel = 1
			minut += 25
			gs 'stat'
			gs 'bicycle','clothes_findvel'
			gs 'zz_render','','','Вы сели на велосипед и отправились в деревню.'
			act 'Далее':gt 'Gaddvor'
		else
			*clr & cla
			gs 'zz_render','','images/qwest/gadukino/new/findvel_nude.jpg','Вы не можете появиться в таком виде в деревне.'
			act 'Далее':gt'gadforest','1'
		end
	end
	if goswamp = 1:
		act 'Ехать на болото':
			*clr & cla
			minut += 50
			manna += 5
			findvel = 3
			gs 'stat'
			gs 'time'
			gs 'bicycle','clothes_findvel'
			gs 'zz_render','','','Вы сели на велосипед и отправились на болото.'
			if func('zz_weather','is_day') = 1:
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
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'time'
	gs 'zz_render','','images/qwest/gadukino/new/findvel.jpg'
	act 'Ехать в деревню':
		if cloth[0] > 0 or (cloth[0] >= 0 and exhibi > 0):
			*clr & cla
			minut += 75
			beg += RAND(0,1)
			speed += rand(0,1)
			body['day_weight'] -= 1
			sweat += 1
			manna += 10
			findvel = 1
			hanters = 0
			gs 'stat'
			gs 'time'
			gs 'bicycle','clothes_findvel'
			gs 'zz_render','','','Вы сели на велосипед и отправились в деревню.'
			if func('zz_weather','is_day') = 1:
				act 'Далее': gt 'Gaddvor'
			else
				act 'Далее': gt'gameover',9
			end
		else
			*clr & cla
			gs 'zz_render','','','Вы не можете появиться в таком виде в деревне.'
			act 'Далее':gt'swamp_yard'
		end
	end
	act 'Ехать в лес':
		*clr & cla
		minut += 50
		manna += 5
		hanters = 0
		findvel = 2
		gs 'stat'
		gs 'time'
		gs 'bicycle','clothes_findvel'
		gs 'zz_render','','','Вы сели на велосипед и отправились в лес.'
		if func('zz_weather','is_day') = 1:
			act 'Далее':gt'gadforest','1'
		else
			act 'Далее': gt'gameover',9
		end
	end
	act 'Поставить велосипед': gt'swamp_yard'
end
if $args[0] = 'clothes_findvel':
	gs 'zz_render','','qwest/gadukino/bike'+iif(cloth[0] = 0,'_nude',iif(func('zz_clothing2','is_skirt') = 0,'','_2'))
end