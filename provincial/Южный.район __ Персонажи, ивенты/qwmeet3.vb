minut += 3
gs'stat'
gs 'zz_render', '', 'images/qwest/kim/001.jpg', func('qwmeet3_strings', 'local_str1')
act 'Сесть рядом с водителем':
	*clr & cla
	minut += 3
	gs'stat'
	gs 'zz_render', '', 'images/qwest/kim/002.jpg', func('qwmeet3_strings', 'local_str2')
	if slavaQW > 0:slavaQW += 1 & 'Пока вы ехали по городу вы не принужденно болтали со Славой.'
	if slavaQW = 0:slavaQW = 1 & 'Пока вы ехали по городу, Слава рассказал вам, что он тусит в свободное время, в баре Полет расположенном в северном районе города.'
	dynamic $qwmeetdin
end
act 'Сесть на заднее сиденье':
	*clr & cla
	minut += 3
	gs'stat'
	gs 'zz_render', '', 'images/qwest/kim/002.jpg', func('qwmeet3_strings', 'local_str3')
	dynamic $qwmeetdin
end
$qwmeetdin = {
	gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str4')
	act 'Выйти из машины':
		*clr & cla
		minut += 60
		energy = 21
		water = 21
		vladimirday = day
		vladimirQW = 35
		gs'stat'
		gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str5')
		if VladimirKnowAboutHusband = 0:
			gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str6')
			act 'Извини, но у меня есть еще дела':gt'street'
			if husband <= 0:
				act 'Пригласить':
					*clr & cla
					minut += 15
					$boy = 'Владимир'
					dick = 16
					silavag = 1
					NoGuy = 1
					InYouHome = 1
					harakBoy = 0
					finance = 2
					money += 5000
					gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str7')
					act '...':gt'BDsex','start'
				end
			elseif husband > 0 and VladimirKnowAboutHusband = 0:
				act 'Я замужем':
					*clr & cla
					VladimirKnowAboutHusband = 1
					gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str8')
					act 'Уйти':gt'street'
				end
			end
		elseif VladimirKnowAboutHusband = 1:
			gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str9')
			act 'Извини, но у меня есть еще дела':gt'street'
			act 'Согласиться':
				*clr & cla
				minut += 15
				$boy = 'Владимир'
				dick = 16
				silavag = 1
				NoGuy = 1
				harakBoy = 0
				finance = 2
				GoToGuy = 2
				gs 'zz_render', '', '', func('qwmeet3_strings', 'local_str10')
				act '...':gt'BDsex','start'
			end
		end
	end
}