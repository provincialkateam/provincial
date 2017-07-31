hour += 48
gs 'stat'
gs 'zz_render', 'Камера', 'images/img/police/c1.jpg', func('kamera_strings', 'local_str1')
act 'Поздороваться':
	*clr & cla
	girl += 1
	lesbian += 1
	gs 'zz_render', '', 'images/img/police/c2.jpg', func('kamera_strings', 'local_str2')
	act 'Открыть рот':
		*clr & cla
		bj += 1
		anal += 1
		gs 'zz_render', '', 'images/img/police/c3.jpg', func('kamera_strings', 'local_str3')
		act 'Встать':
			*clr & cla
			gs 'zz_render', '', 'images/img/police/c5.jpg', func('kamera_strings', 'local_str4')
			act 'Спать':
				*clr & cla
				vagina += 1
				hour += 4
				gs 'stat'
				gs 'zz_render', '', 'images/img/police/c6.jpg', func('kamera_strings', 'local_str5')
				act 'Рассказать':
					cla
					gopdeath = 1
					minut += 180
					vsehsdaladay = day
					gs 'stat'
					gs 'zz_render', '', '', func('kamera_strings', 'local_str6')
					act 'Уйти':gt'nord'
				end
				act 'Отказаться':
					*clr & cla
					minut += 90
					orgasm += 1
					horny = 0
					gs 'stat'
					gs 'zz_render', '', 'images/img/police/c7.jpg', func('kamera_strings', 'local_str7')
					act 'Ухмыльнуться':
						gt 'gameover',5
						exit
					end
					act 'Предложить полизать':
						*clr & cla
						lesbian += 1
						gs 'zz_render', '', 'images/img/police/c8.jpg', func('kamera_strings', 'local_str8')
						act 'Ждать':
							*clr & cla
							gnewQW = 3
							gs 'zz_render', '', 'images/img/police/c1.jpg', func('kamera_strings', 'local_str9')
							act 'Уйти':gt'nord'
						end
					end
				end
			end
		end
	end
	if DOM > 30:
		act 'Ударить':
			*clr & cla
			gs 'zz_render', '', 'images/img/police/c4.jpg', func('kamera_strings', 'local_str10')
			act 'Ждать':
				*clr & cla
				gnewQW = 3
				hour += 20
				gs 'stat'
				gs 'zz_render', '', 'images/img/police/c1.jpg', func('kamera_strings', 'local_str11')
				act 'Уйти': gt'nord'
			end
		end
	end
end