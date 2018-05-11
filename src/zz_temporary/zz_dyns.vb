if $args[0] = 'compromat':
	if film > 0 and kompromatLife < 10:
		!порноактрисса
		kompromatLife = 10
		$result = 'На фотографии кадры из вашего порнофильма.'
		exit
	end
	if fotoyousuck = 1 and kompromatLife < 9:
		!сосала в паре у парней и была сфотографированна
		kompromatLife = 9
		$result = 'На фотографии отчетливо видно, как вы сосете сразу два члена. Очевидно это та самая фотография, которую расклеили в подъезде, после того как вы отсосали в парке.'
		exit
	end
	if fotoCFNMsex > 0 and kompromatLife < 8:
		kompromatLife = 8
		$result = 'На фотографии вы стоите раком перед толпой народу и вас трахает сзади обнаженный мужик. Явно фотография была сделана в стрипклубе.'
		exit
	end
	if fotoCFNMblowjobCum > 0 and kompromatLife < 7:
		!кончили на лицо в стрипклубе
		kompromatLife = 7
		$result = 'На фотографии вы сидите на корточках перед обнаженным мужиком. Его сперма видна на вашем лице и его член касается ваших губ. Явно фотография была сделана в стрипклубе.'
		exit
	end
	if fotoCFNMblowjob > 0 and kompromatLife < 6:
		!сосала на глазах у всех
		kompromatLife = 6
		$result = 'На фотографии вы сидите на корточках перед обнаженным мужиком, обхватив его член губами. Позади видна толпа девушек. Явно фотография была сделана в стрипклубе.'
		exit
	end
	if stripdancesum > 0 and kompromatLife < 2:
		!стриптизерша
		kompromatLife = 2
		$result = 'На фотографии, вы голая танцуете возле шеста. Очевидно вас фоткали когда вы работали стриптизершей.'
		exit
	end
	if modelfoto > 0 and kompromatLife < 1:
		!фото модель
		kompromatLife = 1
		$result = 'На фотографии ваше обнаженное тело. Когда вы позировали в модельном агентстве.'
		exit
	end
end
if $args[0] = 'street_cum':
	if func('zz_weather','is_day') = 1:
		if cumfrot > 0 or cumface > 0:
			manna -= 5
			gs 'zz_render','','''Прохожие недоуменно оборачиваются пристально разглядывая вас. Некоторые фотографируют на телефон вас, совершенно этого не скрывая и хихикая над вами. Явно на вас заметна сперма.'
		end
	end
end