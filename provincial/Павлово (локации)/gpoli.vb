*clr & cla
minut += 5
frost = 0
$loc = $curloc
gs 'zz_phone','boyfriend_call_init'
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Поликлиника', 'pavlovo/clinic/poli.jpg'
act 'Выйти': gt 'gorodok'
if hour >= 6 and hour <= 21:
	if gpoliuborka = 0:
		act 'Прочитать объявление':
			*clr & cla
			minut += 5
			gpoliuborka = 1
			gs 'zz_render', '', '', func('gpoli_strings', 'local_str1')
			act 'Отойти': gt'gpoli'
		end
	elseif gpoliuborka = 1 and hour >= 8 and hour <= 21:
		act 'Спросить у главврача про работу уборщицей':
			*clr & cla
			gpoliuborka = 2
			minut += 15
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/clinic/head_physician.jpg', func('gpoli_strings', 'local_str2')
			act 'Уйти':gt'gpoli'
		end
	elseif gpoliuborka > 1 and hour >= 16 and hour <= 21 and gpolicleanday ! day:
		act 'Работать уборщицей':
			*clr & cla
			gpolicleanday = day
			minut += 60
			manna -= 15
			money += 100
			sweat += 2
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/clinic/clener.jpg', func('gpoli_strings', 'local_str3')
			act 'Закончить работу':gt'gpoli'
			if Gspravka < 10 and RAND(0,1) = 0:
				gs 'zz_render', '', '', func('gpoli_strings', 'local_str4')
				if vagina > 0 and motherKnowSpravka = 0:
					act 'Подделать справку':
						*clr & cla
						Gspravka = 30
						GspravkaT = 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/clinic/fake.jpg', func('gpoli_strings', 'local_str5')
						act 'Закончить работу':gt'gpoli'
					end
				end
			end
		end
	end
	if glassqw=1:
		act'Показаться Окулисту':
			*clr & cla
			hour+=1
			minut+=35
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/clinic/oculist.jpg', func('gpoli_strings', 'local_str6')
			nerdism+=1
			glassqw=2
			glass=1
			blizoruk+=1
			act 'Выйти':gt $curloc
		end
	end
	if health < 100 and money >= 1000:
		act 'Лечить здоровье (1 тыс.руб)':
			*clr & cla
			money -= 1000
			minut += 60
			health = 100
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/clinic/injection.jpg', func('gpoli_strings', 'local_str7')
			act 'Выйти':gt $curloc
		end
	end
	if crazy >= 7 and money >= 1000:
		act 'Прием у психотерапевта (1 тыс.руб)':
			*clr & cla
			money -= 1000
			minut += 60
			manna = 100
			crazy = 0
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/clinic/psychotherapist.jpg', func('gpoli_strings', 'local_str8')
			act 'Выйти': gt $curloc
		end
	end
	if sick >= 1:
		act 'Идти к участковому терапевту':
			*clr & cla
			minut += 15
			sick = 0
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/clinic/therapist.jpg', func('gpoli_strings', 'local_str9')
			act 'Выйти':gt $curloc
		end
	end
	if Gorslut = 6:
		act 'Провериться у гинеколога':
			*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/clinic/gynecologist/1.jpg', func('gpoli_strings', 'local_str10') + func('gpoli_strings', 'local_str'+iif(docKnow = 0,11,12))
				act 'Раздеваться':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/clinic/gynecologist/3.jpg', func('gpoli_strings', 'local_str13')
					act 'Сесть в кресло':
						*clr & cla
						minut += 5
						docKnow = 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/clinic/gynecologist/4.jpg', func('gpoli_strings', 'local_str14')
						$gpoli_sick = ''
						if preg > 0: $gpoli_sick = 'беременна'
						if venera > 0:
							if $gpoli_sick ! '':$gpoli_sick = $gpoli_sick + ', имеешь венерическое заболевание'
							if $gpoli_sick = '':$gpoli_sick = 'имеешь венерическое заболевание'
						end
						gs 'zz_render', '', '', func('gpoli_strings', 'local_str'+iif($gpoli_sick = '',15,16)) + func('gpoli_strings', 'local_str17')
						act 'Предложить деньги.':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', '', func('gpoli_strings', 'local_str18')
							act 'Заплатить':
								*clr & cla
								minut += 5
								money -= 1000
								gs 'zz_render', '', '', func('gpoli_strings', 'local_str19')
								act 'Выйти':gt $curloc
							end
						end
						act 'Предложить себя.':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/clinic/gynecologist/6.jpg', func('gpoli_strings', 'local_str20')
							act 'Минет':
								*clr & cla
								minut += 5
								horny += 5
								bj += 1
								if gpoli_doctorhavesex = 0:gpoli_doctorhavesex = 1 & guy += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/clinic/gynecologist/7.jpg', func('gpoli_strings', 'local_str21')
								act 'Далее':
									*clr & cla
									minut += 5
									horny += 5
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/clinic/gynecologist/8.jpg', func('gpoli_strings', 'local_str22')
									act 'Секс':
										*clr & cla
										minut += 5
										orgasm += 1
										sex += 1
										horny += 10
										vagina += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/clinic/gynecologist/9.jpg', func('gpoli_strings', 'local_str23')
										act 'Секс на кушетке':
											*clr & cla
											minut += 5
											horny += 5
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/clinic/gynecologist/10.jpg', func('gpoli_strings', 'local_str24')
											act 'Анал':
												*clr & cla
												minut += 5
												horny += 15
												anal += 1
												anus += 1
												gs'stat'
												gs 'zz_render', '', 'pavlovo/clinic/gynecologist/11.jpg', func('gpoli_strings', 'local_str25')
												act 'Секс на полу':
													*clr & cla
													minut += 5
													horny += 15
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/clinic/gynecologist/12.jpg', func('gpoli_strings', 'local_str26')
													act 'Анал':
														*clr & cla
														minut += 5
														horny = 0
														orgasm += 1
														gs 'stat'
														gs 'zz_render', '', '', func('gpoli_strings', 'local_str27')
														act 'Принять':
															*clr & cla
															minut += 5
															horny += 5
															gs 'zz_funcs', 'cum', 'lip'
															swallow += 1
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/clinic/gynecologist/14.jpg', func('gpoli_strings', 'local_str28')
															act 'Собираться':
																*clr & cla
																minut += 5
																horny += 5
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/clinic/gynecologist/15.jpg', func('gpoli_strings', 'local_str29')
																act 'Выйти':gt $curloc
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
	if school['certificate'] = 0 and Gspravka < 3 and motherKnowSpravka = 0:
		act 'Идти к гинекологу за справкой':
			if vagina = 0:
				*clr & cla
				minut += 15
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/clinic/gynecologist/0.jpg', func('gpoli_strings', 'local_str30') + func('gpoli_strings', 'local_str31')
				Gspravka = 30
				GspravkaT = 1
				act 'Выйти':gt $curloc
			end
			if vagina > 0:
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/clinic/gynecologist/1.jpg', func('gpoli_strings', 'local_str32') + func('gpoli_strings', 'local_str'+iif(gpoliuborka = 2,33,34))
				$gpoli_spravka_badend = {
					act 'Взять настоящую справку.':
						*clr & cla
						minut += 5
						gs'stat'
						Gspravka = 30
						GspravkaT = 2
						gs 'zz_render', '', '', func('gpoli_strings', 'local_str35')
						act 'Выйти':gt $curloc
					end
				}
				$gpoli_spravka_arrange = {
					act 'Попробовать договориться.':
						*clr & cla
						minut += 5
						gs 'stat'
						if gpoliuborka = 2:
						gs 'zz_render', '', 'pavlovo/clinic/gynecologist/1.jpg', func('gpoli_strings', 'local_str36')
					else
						gs 'zz_render', '', '', func('gpoli_strings', 'local_str37')
						act 'Схватить справку и выбежать из кабинета.':
							*clr & cla
							Gspravka = 30
							GspravkaT = 1
							gs 'stat'
							gs 'zz_render', '', '', func('gpoli_strings', 'local_str38')
							act 'Выйти':gt $curloc
						end
					end
						act 'А что делать. Перед мамой палиться не хочется.':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/clinic/gynecologist/6.jpg', func('gpoli_strings', 'local_str39')
							act 'Минет':
								*clr & cla
								minut += 5
								horny += 5
								bj += 1
								if gpoli_doctorhavesex = 0:gpoli_doctorhavesex = 1 & guy += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/clinic/gynecologist/7.jpg', func('gpoli_strings', 'local_str40')
								act 'Далее':
									*clr & cla
									minut += 5
									horny += 5
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/clinic/gynecologist/8.jpg', func('gpoli_strings', 'local_str41')
									act 'Секс':
										*clr & cla
										minut += 5
										orgasm += 1
										sex += 1
										horny = horny/2
										vagina += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/clinic/gynecologist/9.jpg', func('gpoli_strings', 'local_str42')
										act 'Секс на кушетке':
											*clr & cla
											minut += 5
											horny += 5
											gs'stat'
											gs 'zz_render', '', 'pavlovo/clinic/gynecologist/10.jpg', func('gpoli_strings', 'local_str43')
											act 'Анал':
												*clr & cla
												minut += 5
												horny += 15
												anal += 1
												anus += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/clinic/gynecologist/11.jpg', func('gpoli_strings', 'local_str44')
												act 'Секс на полу':
													*clr & cla
													minut += 5
													horny += 15
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/clinic/gynecologist/12.jpg', func('gpoli_strings', 'local_str45')
													act 'Анал':
														*clr & cla
														minut += 5
														horny = 0
														orgasm += 1
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/clinic/gynecologist/13.jpg', func('gpoli_strings', 'local_str46')
														act 'Принять':
															*clr & cla
															minut += 5
															horny += 5
															gs 'zz_funcs', 'cum', 'lip'
															swallow += 1
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/clinic/gynecologist/14.jpg', func('gpoli_strings', 'local_str47')
															act 'Собираться':
																*clr & cla
																minut += 5
																horny += 5
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/clinic/gynecologist/15.jpg', func('gpoli_strings', 'local_str48')
																Gspravka = 30
																GspravkaT = 1
																act 'Выйти':gt $curloc
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
						act 'Нет. На это я не пойду.':
							gs 'zz_render', '', '', func('gpoli_strings', 'local_str49')
							dynamic $gpoli_spravka_badend
						end
					end
				}
				$gpoli_spravka_money = {
					act 'Предложить деньги.':
						*clr & cla
						minut += 5
						gs'stat'
						if gpoliuborka = 2:
							gs 'zz_render', '', '', func('gpoli_strings', 'local_str50')
							if money >= 2000:
								act 'Заплатить':
									*clr & cla
									minut += 5
									money -= 2000
									gs'stat'
									Gspravka = 30
									GspravkaT = 1
									gs 'zz_render', '', '', func('gpoli_strings', 'local_str51')
									act 'Выйти':gt $curloc
								end
							end
							dynamic $gpoli_spravka_badend
							dynamic $gpoli_spravka_arrange
						else
							gs 'zz_render', '', 'pavlovo/clinic/gynecologist/5.jpg', func('gpoli_strings', 'local_str52')
							dynamic $gpoli_spravka_badend
							dynamic $gpoli_spravka_arrange
						end
					end
				}
				act 'Провериться.':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/clinic/gynecologist/2.jpg', func('gpoli_strings', 'local_str53') + func('gpoli_strings', 'local_str54')
					act 'Раздеваться':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/clinic/gynecologist/3.jpg', func('gpoli_strings', 'local_str55')
						act 'Сесть в кресло':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/clinic/gynecologist/4.jpg', func('gpoli_strings', 'local_str56')
							$gpoli_sick = ''
							if preg > 0: $gpoli_sick = 'беременна'
							if venera > 0:
								if $gpoli_sick ! '':$gpoli_sick = $gpoli_sick + ', имеешь венерическое заболевание'
								if $gpoli_sick = '':$gpoli_sick = 'имеешь венерическое заболевание'
							end
							gs 'zz_render', '', '', func('gpoli_strings', 'local_str'+iif($gpoli_sick = '',57,58))
							dynamic $gpoli_spravka_money
							dynamic $gpoli_spravka_arrange
							dynamic $gpoli_spravka_badend
						end
					end
				end
				act 'Перейти сразу к делу.':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/clinic/gynecologist/1.jpg', func('gpoli_strings', 'local_str'+iif(gpoliuborka = 2,59,60))
					dynamic $gpoli_spravka_money
					dynamic $gpoli_spravka_arrange
					dynamic $gpoli_spravka_badend
				end
			end
		end
	end
else
	gs 'zz_render', '', '', func('gpoli_strings', 'local_str61')
end