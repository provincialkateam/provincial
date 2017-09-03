minut += 15
gs'stat'
if hour >= 16 and izoldaday ! day:
	gs 'zz_render', 'Изольда', 'images/qwest/kolan/izolda.jpg', func('qwIzoldaApp_strings', 'local_str1')
	act 'Уйти':gt'down'
	act 'Войти в квартиру':
		cla
		minut += 30
		izoldaday = day
		izoldaQW += 1
		gs'stat'
		if izoldaQW < 5:
			gs 'zz_render', '', '', func('qwIzoldaApp_strings', 'local_str2')
		elseif izoldaQW >= 5 and izoldaSex = 0:
			gs 'zz_render', '', '', func('qwIzoldaApp_strings', 'local_str3')
			if izoldaQW >= 10 and izoldaSex = 0:
				gs 'zz_render', '', '', func('qwIzoldaApp_strings', 'local_str4')
				act 'Идти с Изольдой':
					*clr & cla
					girl += 1
					lesbian += 1
					izoldaSex = 1
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/kolan/izoldasex.jpg', func('qwIzoldaApp_strings', 'local_str5')
					act 'Целоваться с Изольдой':
						*clr & cla
						horny += 10
						gs'stat'
						gs 'zz_render', '', 'images/qwest/kolan/izoldasex1.jpg', func('qwIzoldaApp_strings', 'local_str6')
						act '...':
							*clr & cla
							horny += 10
							gs'stat'
							gs 'zz_render', '', 'images/qwest/kolan/izoldasex2.jpg', func('qwIzoldaApp_strings', 'local_str7')
							act '...':
								*clr & cla
								horny = 0
								orgasm += 1
								gs'stat'
								gs 'zz_render', '', 'images/qwest/kolan/izoldasex3.jpg', func('qwIzoldaApp_strings', 'local_str8')
								act 'Уйти':gt'down'
							end
						end
					end
				end
			end
		elseif izoldaSex > 0:
			gs 'zz_render', '', '', func('qwIzoldaApp_strings', 'local_str9')
			act 'Идти с Изольдой':
				*clr & cla
				lesbian += 1
				izoldaSex += 1
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/qwest/kolan/izoldasex.jpg', func('qwIzoldaApp_strings', 'local_str10')
				act 'Целоваться с Изольдой':
					*clr & cla
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/kolan/izoldasex1.jpg', func('qwIzoldaApp_strings', 'local_str11')
					act '...':
						*clr & cla
						horny += 10
						gs'stat'
						gs 'zz_render', '', 'images/qwest/kolan/izoldasex2.jpg', func('qwIzoldaApp_strings', 'local_str12')
						act '...':
							*clr & cla
							horny = 0
							orgasm += 1
							gs'stat'
							gs 'zz_render', '', 'images/qwest/kolan/izoldasex3.jpg', func('qwIzoldaApp_strings', 'local_str13')
							act 'Уйти':gt'down'
						end
					end
				end
			end
		end
		act 'Уйти':gt'down'
	end
else
	gs 'zz_render', '', '', func('qwIzoldaApp_strings', 'local_str14')
	act 'Уйти':gt'down'
end