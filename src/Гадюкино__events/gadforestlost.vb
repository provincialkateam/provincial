if $args[0] = 'main':
	*clr & cla
	$metka = $args[0]
	$loc = $curloc
	gs 'stat'
	gs 'time'
	if snow = 0:
		if func('zz_weather','is_day') = 1:
			gs 'zz_render','Лес','qwest/gadukino/forest/gadforestlost0.'+rand(1,6)+'.jpg','Вы заблудились в лесу. Вокруг незнакомые места и вам не до красот природы.'
		else
			gs 'zz_render','Лес','qwest/gadukino/forest/gadforestlost_night0.'+rand(1,4)+'.jpg','Вы заблудились в лесу. Ночью от этого становится ещё страшнее.'
		end
	else
		if func('zz_weather','is_day') = 1:
			gs 'zz_render','Лес','qwest/gadukino/forest/gadforestlost_winter0.'+rand(1,5)+'.jpg','Вы заблудились в лесу. Вокруг незнакомые места и вам не до красот природы.'
		else
			gs 'zz_render','Лес','qwest/gadukino/forest/gadforestlost_winter_night0.'+rand(1,4)+'.jpg','Вы заблудились в лесу. Ночью от этого становится ещё страшнее.'
		end
	end
	if lost >= rand(1,5) and func('zz_weather','is_day') = 0: gt 'gadforest_event', 'lost'
	if lost > 1 and rand(1,10) = 1 and func('zz_weather','is_day') = 1: forest_lost = 1 & gt 'gadforest_event', 'forest_hanters'
	act 'Искать дорогу':
		*clr & cla
		minut += rand(50,70)
		manna -= 5
		goforest += rand(0,1)
		temp = rand(1,40*lost)
		gs 'stat'
		if cloth[0] > 0:
			gs 'zz_render', 'Где-то в лесу','qwest/gadukino/forest/gadforestsearch'+iif(func('zz_clothing2','is_skirt') = 0,'','_ski')+'0.'+rand(1,4)
		else
			gs 'zz_render', 'Где-то в лесу','qwest/gadukino/forest/gadforestsearch_nude0.'+rand(1,4)+'.jpg'
		end
		gs 'zz_render', '', '','Вы в течение часа блуждали по лесу и решили....'
		act 'Искать дорогу дальше ':
			if goforest > temp:
				gt 'gadforestlost','finish'
			else
				if lost = 4 and rand(1,10) > 7:
					gt 'gadforestswamp','1'
				else
					gt 'gadforestlost','main'
				end
			end
		end
		act 'Сесть передохнуть': gt 'gadforestrelax'
	end
end
if $args[0] = 'finish':
	*clr & cla
	temp = RAND(1,lost*3)
	manna += 20
	gs 'time'
	gs 'stat'
	gs 'zz_render', 'Где-то в лесу', 'qwest/gadukino/forest/gadjoy.jpg','Вы присматриваетесь и понимаете, что видите обжитые места места, и с радостью устремляетесь вперед.'
	act 'Выбежать из леса':
		minut += 15
		if temp = 1: gt'gadforest','1'
		if temp = 2: gt'gadfield','field'
		if temp = 3: gt'gadroad'
		if temp = 4: gt'Gadriver'
		if temp = 5: gt'gadbeach'
		if temp = 6: gt'Meadow'
		if temp = 7: gt 'road','main','2'
		if temp = 8 or temp = 9: gt'road','3'
		if temp >= 10:
			if goswamp = 0 and snow <= 0:
				gt 'gadforestswamp','1'
			else
				gt 'swamp'
			end
		end
	end
end