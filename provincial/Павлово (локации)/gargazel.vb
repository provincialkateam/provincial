$metka = $ARGS[0]
$loc = $CURLOC
fatherdrunk = 0
if father['in_garage'] = 0 or $father['location'] ! $loc: gs 'zz_family', 'father_sheduler'
gs 'zz_render','Гараж','images/pic/gargazel'+iif(hour >= 18 and hour <= 20 and father['in_garage'] = 1,'','_empty')+'.jpg',''
if $father['location'] = $loc and hour >= 18 and hour <= 20:
	gs 'zz_render', '', '', func('gargazel_strings', 'local_str1')
	if hour = 20:
		'Сейчас <a href="exec:GT ''garfather''">отчим c дядей Мишей</a> в гараже пьют водку.'
		fatherdrunk = 1
	else
		'Сейчас <a href="exec:GT ''garfather''">отчим</a> в гараже, чинит машину.'
	end
else
	gs 'zz_render', '', '', func('gargazel_strings', 'local_str2')
end
gs 'stat'
act '<B>Уйти</B>': minut += 10 & gt 'gorodok'
if YouCanGar>0:
	gs 'zz_render', '', '', func('gargazel_strings', 'local_str3')
	if tovarL >= 30:
	gs 'zz_render', '', '', func('gargazel_strings', 'local_str4')
	end
	if tovarL < 30:
	perenGarTov = 30 - tovarL
	gs 'zz_render', '', '', func('gargazel_strings', 'local_str5')
		if GarTorgItem > 0:
			if GarTorgItem >= perenGarTov:
				act 'Перенести <<perenGarTov>> едениц товара':
				*clr & cla
				minut += 60
				tovarL += perenGarTov
				GarTorgItem -= perenGarTov
				gs 'stat'
				gs 'zz_render', '', '', func('gargazel_strings', 'local_str6')
				act 'Далее':gt $curloc
				end
			end
			if GarTorgItem < perenGarTov:
				act 'Перенести <<GarTorgItem>> едениц товара':
				*clr & cla
				minut += 60
				tovarL += GarTorgItem
				GarTorgItem = 0
				gs 'stat'
				gs 'zz_render', '', '', func('gargazel_strings', 'local_str7')
				act 'Далее': gt $curloc
				end
			end
		end
	end
end