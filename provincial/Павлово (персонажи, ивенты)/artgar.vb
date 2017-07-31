apmeetday = daystart
if apmeet = 0:
	*clr & cla
	apmeet = 1
	horny = 0
	minut += 30
	gs 'stat'
gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '1')
	act 'Раздеться':
		*clr & cla
		dom -= 1
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_01_1.jpg', func('artgar_strings', '2')
		if pirsA = 1:
			act 'Сосать':
				*clr & cla
				dom -= 1
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_01_2.jpg', func('artgar_strings', '3')
				act 'Сосать дальше':
					*clr & cla
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					bj += 1
					gs 'zz_funcs', 'cum', 'face'
					minut += 30
					gs'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_01_3.jpg', func('artgar_strings', '4')
					act 'Одеться и уйти': gt'gorodok'
				end
			end
		elseif pirsA = 0:
			act 'Сосать':
				*clr & cla
				dom -= 3
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_01_2.jpg', func('artgar_strings', '5')
				act 'Ждать':
					*clr & cla
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_01_4.jpg', func('artgar_strings', '6')
					act '.....':
						*clr & cla
						pirsA = 1
						pirs_pain_ton = 7
						dom -= 1
						gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_01_3.jpg', func('artgar_strings', '7')
						act 'Отдышаться':
							*clr & cla
							if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
							bj += 1
							gs 'zz_funcs', 'cum', 'face'
							minut += 30
							dom -= 1
							artemcam = 0
							gs'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '8')
							act 'Одеться и уйти': gt'gorodok'
						end
					end
				end
			end
		end
	end
elseif apmeet = 1:
	apmeet = 2
	artemcam = 0
	minut += 10
	horny += 10
	gs 'stat'
gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '9')
	act 'Раздеться и залезть в клетку':
		*clr & cla
		bj += 1
		minut += 15
		horny += 10
		gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_1.jpg', func('artgar_strings', '10')
		act 'Лечь':
			*clr & cla
			if $npc['1,sex'] = 0: $npc['1,sex'] = 1 & guy += 1
			minut += 15
			dom -= 2
			gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_2.jpg', func('artgar_strings', '11')
			act 'В клетку':
				*clr & cla
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_3.jpg', func('artgar_strings', '12')
				act 'Ждать':
					*clr & cla
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_4.jpg', func('artgar_strings', '13')
					act 'Плакать':
						*clr & cla
						minut += 40
						gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_5.jpg', func('artgar_strings', '14')
						act 'Терпеть':
							*clr & cla
							bj += 1
							minut += 15
							horny += 10
							gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_6.jpg', func('artgar_strings', '15')
							act 'Выполнить команду':
								*clr & cla
								dom -= 5
								gs 'zz_funcs', 'cum', 'face'
								gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_02_7.jpg', func('artgar_strings', '16')
								act 'Одеваться':
									*clr & cla
gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '17')
									act 'Довериться Артёму':
										*clr & cla
										dom -= 1
										artemcam = 1
										! Концовка Артёма
										gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '18')
										act 'Пока': gt 'gorodok'
									end
									act 'Я лучше пойду': gt 'gorodok'
								end
							end
						end
					end
				end
			end
		end
	end
elseif apmeet = 2:
	*clr & cla
	apmeet = 3
	minut += 30
	horny += 10
	dom -= 5
	gs 'stat'
gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '19')
	act 'Войти и раздеться':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_03_1.jpg', func('artgar_strings', '20')
		act 'Встать раком':
			*clr & cla
			minut += 5
			horny += 15
			gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/hack_6.jpg', func('artgar_strings', '21')
			act 'Выполнить команду':
				*clr & cla
				minut += 10
				gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_03_2.jpg', func('artgar_strings', '22')
				act 'Лечь':
					*clr & cla
					minut += 10
					horny += 15
					anal += 3
					dom -= 2
					gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_03_3.jpg', func('artgar_strings', '23')
					act 'Лечь':
						*clr & cla
						minut += 10
						horny += 15
						anal += 2
						if $npc['1,sex'] = 0: $npc['1,sex'] = 1 & guy += 1
						gs 'zz_funcs', 'cum', 'anus'
						gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_03_4.jpg', func('artgar_strings', '24')
						act 'Ждать':
							*clr & cla
							Dimapersuasion = 0
							minut += 10
							gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_03_5.jpg', func('artgar_strings', '25')
							if artemcam = 1:
								act 'Слушать':
									*clr & cla
									minut += 10
									gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '26')
									act 'Уйти': gt 'gorodok'
								end
							else
								act 'Слушать':
									*clr & cla
									minut += 10
									gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '27')
									act 'Уйти': gt 'gorodok'
								end
							end
						end
					end
				end
			end
		end
	end
elseif apmeet = 3:
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '28')
	act 'Идти с парнями':
		if hcol = 0:
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/artom/meet/AN_0001.jpg', func('artgar_strings', '29')
			act 'Сидеть и ждать': gt 'artgar', 'dimapersuasion'
		else
			*clr & cla
			minut += 60
			hcol = 0
			gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/AN_0001.jpg', func('artgar_strings', '30')
			act 'Покраситься': gt 'artgar', 'dimapersuasion'
		end
	end
elseif apmeet = 4:
	*clr & cla
gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '31')
	act 'Начать представление':
		*clr & cla
gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '32')
		act 'Далее':
			*clr & cla
			dom += 3
gs 'zz_render', '', 'images/qwest/alter/artom/meet/fin_AN_4.jpg', func('artgar_strings', '33')
			apmeet = 6
			act 'Уйти': gt 'gorodok'
		end
	end
elseif apmeet = 5:
	if artemcam >= 1 :
		*clr & cla
		money += 50000
		apmeet = 6
		gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '34')
		act 'Уйти': gt 'gorodok'
	else
		*clr & cla
		apmeet = 6
gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '35')
		act 'Уйти': gt 'gorodok'
	end
end
if $args[0] = 'dimapersuasion':
	*clr & cla
	if Dimapersuasion = 0:
		gs 'zz_render', '', 'images/qwest/alter/artom/meet/dev_01.jpg', func('artgar_strings', '36')
		act 'Идти следом': gt 'artgar', 'apmeetevent'
	elseif Dimapersuasion = 1:
		gs 'zz_render', '', 'images/qwest/alter/artom/meet/dev_01.jpg', func('artgar_strings', '37')
		act 'Идти следом': gt 'artgar', 'apmeetevent'
	elseif Dimapersuasion = 2:
		gs 'zz_render', '', 'images/qwest/alter/artom/meet/dev_01.jpg', func('artgar_strings', '38')
		act 'Идти следом': gt 'artgar', 'apmeetevent'
	elseif Dimapersuasion = 3:
		gs 'zz_render', '', 'images/qwest/alter/artom/meet/dev_01.jpg', func('artgar_strings', '39')
		act 'Далее':
			if tattoo['waist'] = 0 :
				*clr & cla
				minut += 60
				tattoo['waist'] = 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/meet/original.jpg', func('artgar_strings', '40')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/artom/meet/divan_an.jpg', func('artgar_strings', '41')
					act 'Идти следом': gt 'artgar', 'apmeetevent'
				end
			elseif tattoo['waist'] = 1 :
				*clr & cla
				minut += 60
				tattoo['waist'] = 4
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/meet/original.jpg', func('artgar_strings', '42')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/artom/meet/divan_an.jpg', func('artgar_strings', '43')
					act 'Идти следом': gt 'artgar', 'apmeetevent'
				end
			elseif tattoo['waist'] >= 2 :
				*clr & cla
				minut += 60
				tattoo['waist'] = 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/meet/original.jpg', func('artgar_strings', '44')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/artom/meet/divan_an.jpg', func('artgar_strings', '45')
					act 'Идти следом': gt 'artgar', 'apmeetevent'
				end
			end
		end
	end
end
if $args[0] = 'apmeetevent':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/Avto_n.jpg', func('artgar_strings', '46')
		act 'Войти':
			*clr & cla
			minut += 5
			gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_1.jpg', func('artgar_strings', '47')
			act 'Встать раком':
				*clr & cla
				minut += 5
				gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_3.jpg', func('artgar_strings', '48')
				act 'Стоять':
					*clr & cla
					minut += 5
					gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_4.jpg', func('artgar_strings', '49')
					act 'Стоять и ждать':
						*clr & cla
						minut += 5
						gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_5.jpg', func('artgar_strings', '50')
						act 'Выполнить':
							*clr & cla
							minut += 5
							anal += 3
							gs 'zz_funcs', 'cum', 'face'
							gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_7.jpg', func('artgar_strings', '51')
							if Dimapersuasion = 0:
								act 'Сосать':
									*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_9.jpg', func('artgar_strings', '52')
									act 'Слушать':
										*clr & cla
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '53')
										act 'Подумать':
											*clr & cla
											Dimapersuasion = 1
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '54')
											if artomIzdev = 4 and microcamera = 1 or apmeet = 5 :
												act 'Установить камеру':
													*clr & cla
													minut += 5
													gs 'stat'
										gs 'zz_render', '', 'images/qwest/alter/artom/microcam_2.jpg', func('artgar_strings', '55')
													artomIzdev = 5
													microcamera = 0
													apmeet = 4
													act 'Уйти':gt'gorodok'
												end
											else
												act 'Одеваться':
													*clr & cla
													minut += 5
													gs 'stat'
										gs 'zz_render', '', '', func('artgar_strings', '56')
													if artemcam = 1:
														act 'Ждать Артёма':
															*clr & cla
															artemcam = 2
															gs 'stat'
										gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '57')
															act 'Уйти':gt'gorodok'
														end
													else
														act 'Уйти':gt'gorodok'
													end
												end
											end
										end
										act 'Согласиться':
											*clr & cla
											Dimapersuasion = 3
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '58')
											act 'Уйти': gt 'gorodok'
										end
										act 'Ломаться':
											*clr & cla
											Dimapersuasion = 2
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '59')
											if artomIzdev = 4 and microcamera = 1 or apmeet = 5 :
												act 'Установить камеру':
													*clr & cla
													minut += 5
													gs'stat'
										gs 'zz_render', '', 'images/qwest/alter/artom/microcam_2.jpg', func('artgar_strings', '60')
													artomIzdev = 5
													microcamera = 0
													apmeet = 4
													act 'Уйти':gt'gorodok'
												end
											else
												act 'Одеваться':
													*clr & cla
													minut += 5
													gs 'stat'
										gs 'zz_render', '', '', func('artgar_strings', '61')
													if artemcam = 1:
														act 'Ждать Артёма':
															*clr & cla
															artemcam = 2
															gs 'stat'
										gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artgar_strings', '62')
															act 'Уйти':gt'gorodok'
														end
													else
															act 'Уйти':gt'gorodok'
													end
												end
											end
										end
									end
								end
							elseif Dimapersuasion = 1:
								act 'Сосать':
									*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_9.jpg', func('artgar_strings', '63')
									act 'Согласиться':
										*clr & cla
										Dimapersuasion = 3
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '64')
										act 'Уйти': gt 'gorodok'
									end
									act 'Ломаться':
										*clr & cla
										Dimapersuasion = 2
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '65')
											if artomIzdev = 4 and microcamera = 1 or apmeet = 5 :
												act 'Установить камеру':
													*clr & cla
													minut += 5
													gs 'stat'
										gs 'zz_render', '', 'images/qwest/alter/artom/microcam_2.jpg', func('artgar_strings', '66')
													artomIzdev = 5
													microcamera = 0
													apmeet = 4
													act 'Уйти':gt'gorodok'
												end
											else
												act 'Одеваться':
													*clr & cla
													minut += 5
													gs 'stat'
										gs 'zz_render', '', '', func('artgar_strings', '67')
													if artemcam = 2:
														act 'Ждать Артёма':
															*clr & cla
															apmeet = 5
															gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/artom/meet/apmemspeak.jpg', func('artgar_strings', '68')
															act 'Уйти':gt'gorodok'
														end
													else
														act 'Уйти':gt'gorodok'
													end
												end
											end
										end
									end
							elseif Dimapersuasion = 2:
								act 'Далее':
									*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_9.jpg', func('artgar_strings', '69')
									act 'Согласиться':
										*clr & cla
										Dimapersuasion = 3
	gs 'zz_render', '', 'images/common/npc/1.jpg', func('artgar_strings', '70')
										act 'Уйти': gt 'gorodok'
									end
								end
							elseif Dimapersuasion = 3:
								*clr & cla
								apmeet = 5
gs 'zz_render', '', 'images/qwest/alter/artom/meet/meet_04_9.jpg', func('artgar_strings', '71')
								act 'Уйти': gt 'gorodok'
							end
						end
					end
				end
			end
		end
end