!Первый ивент ветки вора
if $args[0] = 'eventthef1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('rb_thef_strings', 1)
	act'А может потом как-нибудь? Я не готова прямо сейчас' :
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('rb_thef_strings', 2)
		act'Отойти': gt $loc, $metka
	end
	act'Поехали':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event16/01.jpg', func('rb_thef_strings', 3)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event16/02.jpg', func('rb_thef_strings', 4)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event16/03.jpg', func('rb_thef_strings', 5)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event16/04.jpg', func('rb_thef_strings', 6)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event16/05.jpg', func('rb_thef_strings', 7)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event16/06.jpg', func('rb_thef_strings', 8)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event16/07.jpg', func('rb_thef_strings', 9)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event16/08.jpg', func('rb_thef_strings', 10)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event16/09.jpg', func('rb_thef_strings', 11)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event16/10.jpg', func('rb_thef_strings', 12)
											if agil >= 65 :
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event16/11.jpg', func('rb_thef_strings', 13)
													act'Далее':
														*clr & cla
														minut += 5
														sweat = 1
														criminal += rand(1,5)
														banda['thef'] = 1
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event16/12.jpg', func('rb_thef_strings', 14)
														act'Выйти из машины': gt 'south'
													end
												end
											else
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event16/13.jpg', func('rb_thef_strings', 15)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event16/14.jpg', func('rb_thef_strings', 16)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event16/15.jpg', func('rb_thef_strings', 17)
															act'Попробовать договориться за секс услуги':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event16/16.jpg', func('rb_thef_strings', 18)
																act'Далее':
																	*clr & cla
																	minut += 5
																	horny += 10
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event16/17.jpg', func('rb_thef_strings', 19)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny += 20
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event16/18.jpg', func('rb_thef_strings', 20)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event16/19.jpg', func('rb_thef_strings', 21)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				horny += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event16/20.jpg', func('rb_thef_strings', 22)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event16/21.jpg', func('rb_thef_strings', 23)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						horny = 70
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event16/22.jpg', func('rb_thef_strings', 24)
																						act'Далее':
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event16/23.jpg', func('rb_thef_strings', 25)
																							act'Далее':
																								*clr & cla
																								minut += 5
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event16/24.jpg', func('rb_thef_strings', 26)
																								act'Далее':
																									*clr & cla
																									minut += 5
																									horny = 80
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event16/25.jpg', func('rb_thef_strings', 27)
																									act'Далее':
																										*clr & cla
																										minut += 5
																										horny = 90
																										gs 'stat'
																										gs 'zz_render', '', 'city/north/banda/event16/26.jpg', func('rb_thef_strings', 28)
																										act'Далее':
																											*clr & cla
																											minut += 5
																											orgasm += 1
																											vaginalorgasm += 1
																											bj += 1
																											sex += 1
																											horny = 0
																											gs 'stat'
																											gs 'zz_render', '', 'city/north/banda/event16/27.jpg', func('rb_thef_strings', 29)
																											act'Далее':
																												*clr & cla
																												minut += 5
																												gs 'stat'
																												gs 'zz_render', '', 'city/north/banda/event16/28.jpg', func('rb_thef_strings', 30)
																												act'Далее':
																													*clr & cla
																													minut += 5
																													gs 'stat'
																													gs 'zz_render', '', 'city/north/banda/event16/29.jpg', func('rb_thef_strings', 31)
																													act'Далее':
																														*clr & cla
																														minut += 5
																														gs 'zz_funcs', 'cum', 'face'
																														gs 'zz_funcs', 'cum', 'lip'
																														gs 'stat'
																														gs 'zz_render', '', 'city/north/banda/event16/30.jpg', func('rb_thef_strings', 32)
																														act'Далее':
																															*clr & cla
																															minut += 5
																															manna -= 25
																															sweat = 1
																															banda['theffail'] = 1
																															gs 'stat'
																															gs 'zz_render', '', 'city/north/banda/event16/31.jpg', func('rb_thef_strings', 33)
																															act'Выйти из машины': gt 'south'
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
		end
	end
end
!Ивент при неудачном прохождении первого
if $args[0] = 'eventthef2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event15/15.jpg', func('rb_thef_strings', 34)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event17/01.jpg', func('rb_thef_strings', 35)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event17/02.jpg', func('rb_thef_strings', 36)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event17/03.jpg', func('rb_thef_strings', 37)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event17/04.jpg', func('rb_thef_strings', 38)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event17/05.jpg', func('rb_thef_strings', 39)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event17/06.jpg', func('rb_thef_strings', 40)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 15
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event17/07.jpg', func('rb_thef_strings', 41)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event17/08.jpg', func('rb_thef_strings', 42)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event17/09.jpg', func('rb_thef_strings', 43)
										act'Далее':
											*clr & cla
											minut += 5
											horny += 25
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event17/10.jpg', func('rb_thef_strings', 44)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event17/11.jpg', func('rb_thef_strings', 45)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event17/12.jpg', func('rb_thef_strings', 46)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event17/13.jpg', func('rb_thef_strings', 47)
														act'Далее':
															*clr & cla
															minut += 5
															horny = 75
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event17/14.jpg', func('rb_thef_strings', 48)
															act'Далее':
																*clr & cla
																minut += 5
																horny = 85
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event17/15.jpg', func('rb_thef_strings', 49)
																act'Далее':
																	*clr & cla
																	minut += 5
																	orgasm += 1
																	DPorgasm += 1
																	gang += 1
																	bj += 1
																	horny = 0
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event17/16.jpg', func('rb_thef_strings', 50)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event17/17.jpg', func('rb_thef_strings', 51)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny += 25
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event17/18.jpg', func('rb_thef_strings', 52)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				horny += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event17/19.jpg', func('rb_thef_strings', 53)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event17/20.jpg', func('rb_thef_strings', 54)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event17/21.jpg', func('rb_thef_strings', 55)
																						act'Далее':
																							*clr & cla
																							minut += 5
																							horny += 15
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event17/22.jpg', func('rb_thef_strings', 56)
																							act'Далее':
																								*clr & cla
																								minut += 5
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event17/23.jpg', func('rb_thef_strings', 57)
																								act'Далее':
																									*clr & cla
																									minut += 5
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event17/24.jpg', func('rb_thef_strings', 58)
																									act'Далее':
																										*clr & cla
																										minut += 5
																										don -= 4
																										sweat = 1
																										spanked = 0
																										banda['theffail'] = 2
																										gs 'zz_funcs', 'cum', 'lip'
																										gs 'zz_funcs', 'cum', 'face'
																										gs 'stat'
																										gs 'zz_render', '', 'city/north/banda/event17/25.jpg', func('rb_thef_strings', 59)
																										act'Одется' : gt 'banda_home','room'
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
!ивент для тренировки ловкости
if $args[0] = 'eventthef3':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event18/01.jpg', func('rb_thef_strings', 60)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event18/02.jpg', func('rb_thef_strings', 61)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event18/03.jpg', func('rb_thef_strings', 62)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event18/04.jpg', func('rb_thef_strings', 63)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event18/05.jpg', func('rb_thef_strings', 64)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event18/06.jpg', func('rb_thef_strings', 65)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event18/07.jpg', func('rb_thef_strings', 66)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event18/08.jpg', func('rb_thef_strings', 67)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 25
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event18/09.jpg', func('rb_thef_strings', 68)
									act'Далее':
										*clr & cla
										minut += 5
										horny += 15
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event18/10.jpg', func('rb_thef_strings', 69)
										act'Далее':
											*clr & cla
											minut += 5
											horny += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event18/11.jpg', func('rb_thef_strings', 70)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event18/12.jpg', func('rb_thef_strings', 71)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event18/13.jpg', func('rb_thef_strings', 72)
													act'Далее':
														*clr & cla
														minut += 5
														horny = 75
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event18/14.jpg', func('rb_thef_strings', 73)
														act'Далее':
															*clr & cla
															minut += 5
															horny = 90
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event18/15.jpg', func('rb_thef_strings', 74)
															act'Далее':
																*clr & cla
																minut += 5
																orgasm += 1
																DPorgasm += 1
																gang += 1
																bj += 1
																horny = 0
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event18/16.jpg', func('rb_thef_strings', 75)
																act'Далее':
																	*clr & cla
																	minut += 5
																	horny = 50
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event18/17.jpg', func('rb_thef_strings', 76)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny = 80
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event18/18.jpg', func('rb_thef_strings', 77)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			orgasm += 1
																			analorgasm += 1
																			horny = 0
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event18/19.jpg', func('rb_thef_strings', 78)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event18/20.jpg', func('rb_thef_strings', 79)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event18/21.jpg', func('rb_thef_strings', 80)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						agil += 3
																						stren += 1
																						gs 'zz_funcs','set_gape','anus', 10,20,1
																						gs 'zz_funcs','set_gape','vagina',horny, 20, 1
																						spanked = 0
																						banda['eventthef3'] = day
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event18/22.jpg', func('rb_thef_strings', 81)
																						act'Выйти из машины': gt 'south'
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
							end
						end
					end
				end
			end
		end
	end
end