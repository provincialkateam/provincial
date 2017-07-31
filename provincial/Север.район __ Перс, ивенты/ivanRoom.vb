	*clr
	minut += 5
	gs'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Квартира менеджера Ивана</font></b></center>'
	gs 'zz_render', '', 'images/pic/podezdhr.jpg', func('ivanRoom_strings', 'local_str1')
	act 'Выйти':
		cla
		minut += 5
		gt'nord'
	end
	if softKAR = 1:
		gs 'zz_render', '', '', func('ivanRoom_strings', 'local_str2')
		act 'Какой план?':
			*clr & cla
			horny = 0
			gs'stat'
			gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str3')
			act 'Давай приступим':
				*clr & cla
				minut += 5
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str4')
				act 'Войти в квартиру':
					*clr & cla
					minut += 5
					horny += 50
					gs'stat'
					gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str5')
					act 'Брызнуть тайком':
						*clr & cla
						minut += 5
						horny += 25
						gs'stat'
						gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str6')
						act 'Брызнуть еще раз':
							*clr & cla
							minut += 5
							horny += 25
							gs'stat'
							gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str7')
							act 'Предложить выпить':
								*clr & cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str8')
								act 'Выйти из квартиры':
									*clr & cla
									minut += 5
									softKAR = 0
									gs'stat'
									gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str9')
									act 'Уйти из подъезда':gt'nord'
								end
								end
								act 'Молчать':
								*clr & cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'images/picQW/Threesome.jpg', func('ivanRoom_strings', 'local_str10')
								act '...':
									*clr & cla
									minut += 5
									softKAR = 2
									gs'stat'
									gs 'zz_render', '', 'images/picQW/Threesome1.jpg', func('ivanRoom_strings', 'local_str11')
									act 'Сосать член вдвоем с Таней':
										*clr & cla
										minut += 5
										guy += 1
										if KarinSex = 0:KarinSex = 1 & girl += 1
										bj += 1
										gang += 1
										gs'stat'
										gs 'zz_render', '', 'images/picQW/Threesome2.jpg', func('ivanRoom_strings', 'local_str12')
										act '...':
											*clr & cla
											minut += 5
											gs'stat'
										gs 'zz_render', '', 'images/picQW/Threesome3.jpg', func('ivanRoom_strings', 'local_str13')
											act 'Сесть киской на лицо Ивана':
												*clr & cla
												minut += 5
												kuni += 1
												gs'stat'
										gs 'zz_render', '', 'images/picQW/Threesome4.jpg', func('ivanRoom_strings', 'local_str14')
												act '69 с Таней':
													*clr & cla
													minut += 5
													lesb += 1
													sex += 1
													vagina += 1
													orgasm += 1
													gs'stat'
										gs 'zz_render', '', 'images/picQW/Threesome5.jpg', func('ivanRoom_strings', 'local_str15')
													act 'На колени':
														*clr & cla
														minut += 5
														gs 'zz_funcs', 'cum', 'face'
														gs'stat'
										gs 'zz_render', '', 'images/picQW/Threesome6.jpg', func('ivanRoom_strings', 'local_str16')
														act 'Готовить камеру':
															*clr & cla
															softKAR = 10
															IvanEvidence = 1
															cumface = 0
															gs'stat'
										gs 'zz_render', '', 'images/img/centr/tanya.jpg', func('ivanRoom_strings', 'local_str17')
															act 'Уйти':gt'nord'
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end