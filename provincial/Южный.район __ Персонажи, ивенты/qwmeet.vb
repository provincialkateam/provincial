$qwmeetdy = {
	gs 'zz_render', '', '', func('qwmeet_strings', 'local_str1')
	act 'Выйти из машины оперевшись на руку водителя':
		*clr & cla
		minut += 3
		gs'stat'
		gs 'zz_render', '', 'images/qwest/kim/001.jpg', func('qwmeet_strings', 'local_str2')
		act 'Идти домой':gt'street'
	end
}
minut += 5
vladimirQW = 25
vladimirday = day
gs'stat'
'<center><b><font color = maroon>Владимир</font></b></center>'
gs 'zz_render', '', 'images/qwest/vladimir/001.jpg', func('qwmeet_strings', 'local_str3')
act 'Взять букет и идти в ресторан с Владимиром':
	cla
	minut += 3
	gs'stat'
	gs 'zz_render', '', '', func('qwmeet_strings', 'local_str4')
	act 'Сесть на стул':
		cla
		minut += 3
		gs'stat'
		gs 'zz_render', '', '', func('qwmeet_strings', 'local_str5')
		act 'Сделать заказ':
			cla
			minut += 3
			gs'stat'
			gs 'zz_render', '', '', func('qwmeet_strings', 'local_str6')
			if workrin = 1:
				$qwvladwork = 'Работаю на рынке.'
			elseif young_shop_work = 1:
				$qwvladwork = 'Работаю в магазине.'
			elseif workKafe > 0:
				$qwvladwork = 'Работаю официанткой в кафе.'
			else
				$qwvladwork = 'По большому счету ничем.'
			end
			act '<<$qwvladwork>>':
				cla
				minut += 15
				gs'stat'
				gs 'zz_render', '', '', func('qwmeet_strings', 'local_str7')
				act 'Выпить':
					cla
					minut += 15
					energy = 21
					water = 21
					gs'stat'
					gs 'zz_render', '', '', func('qwmeet_strings', 'local_str8')
					act 'Танцевать с Владимиром':
						cla
						minut += 15
						gs'stat'
						gs 'zz_render', '', '', func('qwmeet_strings', 'local_str9')
						act 'Выйти из ресторана':
							*clr & cla
							minut += 15
							gs'stat'
							gs 'zz_render', '', 'images/qwest/vladimir/car.jpg', func('qwmeet_strings', 'local_str10')
							act 'Поцеловать в щеку':
								cla
								gs 'zz_render', '', '', func('qwmeet_strings', 'local_str11')
								dynamic $qwmeetdy
							end
							act 'Поцеловать в губы':
								cla
								gs 'zz_render', '', '', func('qwmeet_strings', 'local_str12')
								dynamic $qwmeetdy
							end
						end
					end
				end
			end
		end
	end
end