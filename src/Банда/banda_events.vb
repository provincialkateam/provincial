if $args[0] = 'banda_check':
	! banda['location'] - где и чем занята банда
	! 0 - дома отдыхают
	! 1 - дома бухают
	! 2 - в парке
	! 3 - на складе
	! 4 - в неизвестности
	banda['location'] = 4
	if banda['stage'] > 0 and banda['stage'] < 20:
		if hour = 20: banda['location'] = 1
	else
		if hour = 8 or hour = 9 or hour = 14 or (hour >= 17 and hour <= 19) or hour = 21 or hour = 22: banda['location'] = 0
		if hour = 20: banda['location'] = 1
		if week <= 5:
			if hour = 15 or hour = 16: banda['location'] = 3
		else
			if hour >= 10 and hour <= 13: banda['location'] = 2
		end
	end
end
!Ивент в парке для некрасивой светки
if $args[0] = 'banda_event1':
	*clr & cla
	banda['stage'] = 1
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event1/01.jpg', func('banda_events_strings', 1)
	act'Подойти, нарочито вихляя бедрами.':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event1/02.jpg', func('banda_events_strings', 2)
		act'Выпить' :
			*clr & cla
			minut += 5
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event1/02.jpg', func('banda_events_strings', 3)
			act'Далее' :
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event1/03.jpg', func('banda_events_strings', 4)
				act'Далее' :
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event1/04.jpg', func('banda_events_strings', 5)
					act'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event1/05.jpg', func('banda_events_strings', 6)
						act'Далее' :
							*clr & cla
							minut += 5
							horny += 15
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event1/06.jpg', func('banda_events_strings', 7)
							act'Далее' :
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event1/07.jpg', func('banda_events_strings', 8)
								act'Далее' :
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event1/08.jpg', func('banda_events_strings', 9)
									act'Далее' :
										*clr & cla
										minut += 5
										horny += 15
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event1/09.jpg', func('banda_events_strings', 10)
										act'Далее' :
											*clr & cla
											minut += 5
											horny += 25
											gs 'stat'
											if lubri > 0: gs 'zz_render','','', func('banda_events_strings', 11)
											act 'Далее' :
												*clr & cla
												minut += 5
												if lubri > 0: lubri -= 1
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event1/11.jpg', func('banda_events_strings', 12)
												act'Далее' :
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event1/12.jpg', func('banda_events_strings', 13)
													act'Далее' :
														*clr & cla
														minut += 5
														horny = 80
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event1/13.jpg', func('banda_events_strings', 14)
														act'Далее' :
															*clr & cla
															minut += 5
															horny = 95
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event1/14.jpg', func('banda_events_strings', 15)
															act'Далее' :
																*clr & cla
																minut += 5
																orgasm += 1
																DPorgasm += 1
																bj += 1
																horny = 0
																gang += 1
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event1/15.jpg', func('banda_events_strings', 16)
																act'Далее' :
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event1/16.jpg', func('banda_events_strings', 17)
																	act'Далее' :
																		*clr & cla
																		minut += 5
																		dom -= 3
																		gs 'zz_funcs', 'cum', 'face'
																		gs 'zz_funcs', 'cum', 'lip'
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event1/17.jpg', func('banda_events_strings', 18)
																		act'Далее' :
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event1/18.jpg', func('banda_events_strings', 19)
																			act'Далее' :
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event1/19.jpg', func('banda_events_strings', 20)
																				act'Далее' :
																					*clr & cla
																					minut += 30
																					gs 'stat'
																					gs 'zz_render', '', '', func('banda_events_strings', 21)
																					act'Далее' :
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event1sub/01.jpg', func('banda_events_strings', 22)
																						act'Выпить' :
																							*clr & cla
																							minut += 5
																							gs 'zz_funcs', 'alko', 6
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event1sub/02.jpg', func('banda_events_strings', 23)
																							act'Далее' : gt 'banda_events','event1sub'
																						end
																						act'Вежливо отказаться':
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event1sub/02.jpg', func('banda_events_strings', 24)
																							act'Далее' : gt 'banda_events','event1sub'
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
	act 'Показать «фак» и убежать':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('banda_events_strings', 25)
		act 'Далее' :
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event1/20.jpg', func('banda_events_strings', 26)
			act 'Далее' :
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event1/21.jpg', func('banda_events_strings', 27)
				act 'Далее' :
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event1/22.jpg', func('banda_events_strings', 28)
					act 'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event1/23.jpg', func('banda_events_strings', 29)
						act 'Далее' :
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event1/08.jpg', func('banda_events_strings', 30)
							act 'Далее' :
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event1/11.jpg', func('banda_events_strings', 31)
								act 'Далее' :
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event1/10.jpg', func('banda_events_strings', 32)
									act 'Далее' :
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event1/24.jpg', func('banda_events_strings', 33)
										act 'Далее' :
											*clr & cla
											minut += 5
											horny += 25
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event1/25.jpg', func('banda_events_strings', 34)
											act 'Далее' :
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event1/26.jpg', func('banda_events_strings', 35)
												act 'Далее' :
													*clr & cla
													minut += 5
													horny = 80
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event1/27.jpg', func('banda_events_strings', 36)
													act 'Далее' :
														*clr & cla
														minut += 5
														horny = 95
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event1/14.jpg', func('banda_events_strings', 37)
														act 'Далее' :
															*clr & cla
															minut += 5
															orgasm += 1
															DPorgasm += 1
															bj += 1
															horny = 0
															gang += 1
															rape += 1
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event1/16.jpg', func('banda_events_strings', 38)
															act 'Далее' :
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event1/17.jpg', func('banda_events_strings', 39)
																act 'Далее' :
																	*clr & cla
																	minut += 5
																	mop = 0
																	gs 'zz_funcs','set_gape','anus',0,15,1
																	manna = 0
																	gs 'zz_funcs', 'cum', 'face'
																	gs 'zz_funcs', 'cum', 'lip'
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event1/19.jpg', func('banda_events_strings', 40)
																	act 'Далее' :
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event1sub/21.jpg', func('banda_events_strings', 41)
																		act 'Далее' :
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event1sub/01.jpg', func('banda_events_strings', 42)
																			act 'Далее' :
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event1sub/22.jpg', func('banda_events_strings', 43)
																				act 'Далее' :
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event1sub/23.jpg', func('banda_events_strings', 44)
																					act 'Далее' :
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event1sub/24.jpg', func('banda_events_strings', 45)
																						act 'Далее' :
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event1sub/25.jpg', func('banda_events_strings', 46)
																							act 'Далее' :
																								*clr & cla
																								minut += 5
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event1sub/26.jpg', func('banda_events_strings', 47)
																								act 'Далее' :
																									*clr & cla
																									minut += 5
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event1sub/27.jpg', func('banda_events_strings', 48)
																									act 'Далее' :
																										*clr & cla
																										minut += 5
																										gs 'stat'
																										gs 'zz_render', '', 'city/north/banda/event1sub/28.jpg', func('banda_events_strings', 49)
																										act 'Далее' :
																											*clr & cla
																											minut += 5
																											gs 'stat'
																											gs 'zz_render', '', 'city/north/banda/event1sub/08.jpg', func('banda_events_strings', 50)
																											act 'Попробовать сбежать.' :
																												*clr & cla
																												minut += 5
																												horny += 10
																												gs 'stat'
																												gs 'zz_render', '', 'city/north/banda/event1sub/29.jpg', func('banda_events_strings', 51)
																												act 'Далее' :
																													*clr & cla
																													minut += 5
																													gs 'stat'
																													gs 'zz_render', '', 'city/north/banda/event1sub/30.jpg', func('banda_events_strings', 52)
																													act 'Далее' :
																														*clr & cla
																														minut += 5
																														gs 'stat'
																														gs 'zz_render', '', 'city/north/banda/event1sub/31.jpg', func('banda_events_strings', 53)
																														act 'Далее' :
																															*clr & cla
																															minut += 5
																															horny += 15
																															gs 'stat'
																															gs 'zz_render', '', 'city/north/banda/event1sub/32.jpg', func('banda_events_strings', 54)
																															act 'Далее' :
																																*clr & cla
																																minut += 5
																																gs 'stat'
																																gs 'zz_render', '', 'city/north/banda/event1sub/33.jpg', func('banda_events_strings', 55)
																																act 'Далее' :
																																	*clr & cla
																																	minut += 5
																																	horny += 20
																																	gs 'stat'
																																	gs 'zz_render', '', 'city/north/banda/event1sub/34.jpg', func('banda_events_strings', 56)
																																	act 'Далее' :
																																		*clr & cla
																																		minut += 5
																																		horny += 20
																																		gs 'stat'
																																		gs 'zz_render', '', 'city/north/banda/event1sub/35.jpg', func('banda_events_strings', 57)
																																		act 'Далее' : gt 'banda_events','event1dom'
																																	end
																																end
																															end
																														end
																													end
																												end
																											end
																											act 'Не рыпаться, ждать что будет дальше':
																												*clr & cla
																												minut += 5
																												dom -= 2
																												gs 'stat'
																												gs 'zz_render', '', 'city/north/banda/event1sub/36.jpg', func('banda_events_strings', 58)
																												act 'Далее' :
																													*clr & cla
																													minut += 5
																													horny += 5
																													gs 'stat'
																													gs 'zz_render', '', 'city/north/banda/event1sub/37.jpg', func('banda_events_strings', 59)
																													act 'Далее' :
																														*clr & cla
																														minut += 5
																														gs 'stat'
																														gs 'zz_render', '', 'city/north/banda/event1sub/38.jpg', func('banda_events_strings', 60)
																														act 'Далее' :
																															*clr & cla
																															minut += 5
																															gs 'stat'
																															gs 'zz_render', '', 'city/north/banda/event1sub/39.jpg', func('banda_events_strings', 61)
																															act 'Далее' :
																																*clr & cla
																																minut += 5
																																horny += 15
																																gs 'stat'
																																gs 'zz_render', '', 'city/north/banda/event1sub/40.jpg', func('banda_events_strings', 62)
																																act 'Далее' :
																																	*clr & cla
																																	minut += 5
																																	gs 'stat'
																																	gs 'zz_render', '', 'city/north/banda/event1sub/41.jpg', func('banda_events_strings', 63)
																																	act 'Далее' :
																																		*clr & cla
																																		minut += 5
																																		horny += 25
																																		gs 'stat'
																																		gs 'zz_render', '', 'city/north/banda/event1sub/42.jpg', func('banda_events_strings', 64)
																																		act 'Далее' : gt 'banda_events','event1dom'
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
		end
	end
end
!Ивент в парке для красивой Светки
if $args[0] = 'banda_event':
	*clr & cla
	banda['stage'] = 1
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event/01.jpg', func('banda_events_strings', 65)
	act 'Подойти, нарочито вихляя бедрами':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event/02.jpg', func('banda_events_strings', 66)
		act 'Выпить' :
			*clr & cla
			minut += 5
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			gs 'zz_render', '', '', func('banda_events_strings', 67)
			act 'Далее' :
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event/03.jpg', func('banda_events_strings', 68)
				act 'Далее' :
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event/04.jpg', func('banda_events_strings', 69)
					act 'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event/05.jpg', func('banda_events_strings', 70)
						act 'Далее' :
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event/06.jpg', func('banda_events_strings', 71)
							act 'Далее' :
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event/07.jpg', func('banda_events_strings', 72)
								act 'Далее' :
									*clr & cla
									minut += 5
									gs 'stat'
									if lubri > 0: gs 'zz_render','','', func('banda_events_strings', 73)
									act 'Далее' :
										*clr & cla
										minut += 5
										horny += 25
										if lubri > 0: lubri -= 1
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event/09.jpg', func('banda_events_strings', 74)
										act 'Далее' :
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event/10.jpg', func('banda_events_strings', 75)
											act 'Далее' :
												*clr & cla
												minut += 5
												horny = 85
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event/11.jpg', func('banda_events_strings', 76)
												act 'Далее' :
													*clr & cla
													gs 'zz_funcs','set_gape','anus', iif(lubri>0,10,0),20,1
													minut += 5
													orgasm += 1
													DPorgasm += 1
													bj += 1
													horny = 0
													gang += 1
													anal += 1
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event/12.jpg', func('banda_events_strings', 77)
													act 'Далее' :
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event/13.jpg', func('banda_events_strings', 78)
														act 'Далее' :
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event/14.jpg', func('banda_events_strings', 79)
															act 'Далее' :
																*clr & cla
																gs 'zz_funcs','cum','face'
																gs 'zz_funcs','cum','lip'
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event1/19.jpg', func('banda_events_strings', 80)
																act 'Далее' : gt 'banda_events','banda_event2'
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
	act 'Показать «фак» и убежать':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('banda_events_strings', 81)
		act 'Далее' :
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event/15.jpg', func('banda_events_strings', 82)
			act 'Далее' :
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event/16.jpg', func('banda_events_strings', 83)
				act 'Спрятаться' :
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event/17.jpg', func('banda_events_strings', 84)
					act 'Далее' : gt 'banda_events','banda_event2'
				end
			end
		end
	end
end
!Продолжение ивента в парке с переездом на склад для не карсивой Светки если она сама согласилась
if $args[0] = 'event1sub':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event1sub/03.jpg', func('banda_events_strings', 85)
	act'Далее' :
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event1sub/04.jpg', func('banda_events_strings', 86)
		act'Далее' :
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event1sub/05.jpg', func('banda_events_strings', 87)
			act'Далее' :
				*clr & cla
				minut += 5
				horny += 15
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event1sub/06.jpg', func('banda_events_strings', 88)
				act'Далее' :
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event1sub/07.jpg', func('banda_events_strings', 89)
					act'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event1sub/08.jpg', func('banda_events_strings', 90)
						act'Далее' :
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event1sub/09.jpg', func('banda_events_strings', 91)
							act'Далее' :
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event1sub/10.jpg', func('banda_events_strings', 92)
								act'Далее' :
									*clr & cla
									minut += 5
									horny += 25
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event1sub/11.jpg', func('banda_events_strings', 93)
									act'Далее' :
										*clr & cla
										minut += 5
										horny += 10
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event1sub/12.jpg', func('banda_events_strings', 94)
										act'Далее' :
											*clr & cla
											minut += 5
											lubri -= 1
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event1sub/13.jpg', func('banda_events_strings', 95)
											act'Далее' :
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event1sub/14.jpg', func('banda_events_strings', 96)
												act'Далее' :
													*clr & cla
													minut += 5
													orgasm += 1
													DPorgasm += 1
													bj += 1
													horny = 0
													gang += 1
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event1sub/15.jpg', func('banda_events_strings', 97)
													act'Далее' :
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event1sub/16.jpg', func('banda_events_strings', 98)
														act'Далее' :
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event1sub/17.jpg', func('banda_events_strings', 99)
															act'Далее' :
																*clr & cla
																minut += 5
																dom -= 3
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event1sub/18.jpg', func('banda_events_strings', 100)
																act'Обтереть сперму и покушать' :
																	*clr & cla
																	minut += 5
																	energy = 100
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event1sub/19.jpg', func('banda_events_strings', 101)
																	act'Далее' :
																		*clr & cla
																		minut += 5
																		banda['studio_start'] = 1
																		banda['banda_event1'] = 1
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event1sub/20.jpg', func('banda_events_strings', 102)
																		act'Уйти' : gt 'north'
																	end
																end
																act'Отказаться и просто привести себя в порядок' :
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event1sub/19.jpg', func('banda_events_strings', 103)
																	act'Далее' :
																		*clr & cla
																		minut += 5
																		banda['studio_start'] = 1
																		banda['banda_event1'] = 1
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event1sub/20.jpg', func('banda_events_strings', 104)
																		act'Уйти' : gt 'north'
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
!Продолжение ивента в парке для не карсивой Светки если она отказалась
if $args[0] = 'event1dom':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event1sub/43.jpg', func('banda_events_strings', 105)
	act'Далее' :
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event1sub/44.jpg', func('banda_events_strings', 106)
		act'Далее' :
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event1sub/45.jpg', func('banda_events_strings', 107)
			act'Далее' :
				*clr & cla
				minut += 5
				hornu = 85
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event1sub/46.jpg', func('banda_events_strings', 108)
				act'Далее' :
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event1sub/47.jpg', func('banda_events_strings', 109)
					act'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event1sub/48.jpg', func('banda_events_strings', 110)
						act'Далее' :
							*clr & cla
							minut += 5
							orgasm += 1
							analorgasm += 1
							bj += 1
							horny = 0
							gang += 1
							rape += 1
							gs 'zz_funcs', 'cum', 'anus'
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event1sub/49.jpg', func('banda_events_strings', 111)
							act'Далее' :
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event1sub/50.jpg', func('banda_events_strings', 112)
								act'Далее' :
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event1sub/51.jpg', func('banda_events_strings', 113)
									act'Далее' :
										*clr & cla
										minut += 5
										gs 'zz_funcs','set_gape','anus', 0,20,1
										mop = 0
										banda['stage'] = 255
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event1sub/52.jpg', func('banda_events_strings', 114)
										act 'Уйти': gt 'north'
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
!Продолжение ивента в парке с переездом на склад для карсивой Светки
if $args[0] = 'banda_event2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','city/north/banda/home/bedr.jpg', func('banda_events_strings', 115)
	act'Далее' :
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render','','city/north/banda/event2/01.jpg', func('banda_events_strings', 116)
		act'Далее' :
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event2/02.jpg', func('banda_events_strings', 117)
			act'Далее' :
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event2/03.jpg', func('banda_events_strings', 118)
				act'Сопротивляться' :
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event2/03.jpg', func('banda_events_strings', 119)
					act'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event2/04.jpg', func('banda_events_strings', 120)
						act'Далее' :
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event2/05.jpg', func('banda_events_strings', 121)
							act'Далее' :
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event2/06.jpg', func('banda_events_strings', 122)
								act'Далее' :
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event2/07.jpg', func('banda_events_strings', 123)
									act'Далее' :
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event2/08.jpg', func('banda_events_strings', 124)
										act'Далее' :
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event2/09.jpg', func('banda_events_strings', 125)
											act'Далее' :
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event2/10.jpg', func('banda_events_strings', 126)
												act'Далее' :
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event2/11.jpg', func('banda_events_strings', 127)
													act'Далее' :
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event2/12.jpg', func('banda_events_strings', 128)
														act'Далее' :
															*clr & cla
															minut += 5
															horny += 20
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event2/13.jpg', func('banda_events_strings', 129)
															act'Далее' :
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event2/14.jpg', func('banda_events_strings', 130)
																act'Далее' :
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event2/15.jpg', func('banda_events_strings', 131)
																	act'Далее' :
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event2/16.jpg', func('banda_events_strings', 132)
																		act'Далее' :
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event2/17.jpg', func('banda_events_strings', 133)
																			act'Далее' :
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event2/18.jpg', func('banda_events_strings', 134)
																				act'Далее' :
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event2/19.jpg', func('banda_events_strings', 135)
																					act'Далее' :
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event2/20.jpg', func('banda_events_strings', 136)
																						act'Далее' :
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event2/21.jpg', func('banda_events_strings', 137)
																							act'Далее' :
																								*clr & cla
																								minut += 5
																								horny += 15
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event2/22.jpg', func('banda_events_strings', 138)
																								act'Далее' :
																									*clr & cla
																									minut += 5
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event2/23.jpg', func('banda_events_strings', 139)
																									act'Далее' :
																										*clr & cla
																										minut += 5
																										horny = 75
																										gs 'stat'
																										gs 'zz_render', '', 'city/north/banda/event2/24.jpg', func('banda_events_strings', 140)
																										act'Далее' :
																											*clr & cla
																											minut += 5
																											gs 'stat'
																											gs 'zz_render', '', 'city/north/banda/event2/25.jpg', func('banda_events_strings', 141)
																											act'Далее' :
																												*clr & cla
																												minut += 5
																												horny = 90
																												gs 'stat'
																												gs 'zz_render', '', 'city/north/banda/event2/26.jpg', func('banda_events_strings', 142)
																												act'Далее' :
																													*clr & cla
																													minut += 5
																													gs 'stat'
																													gs 'zz_render', '', 'city/north/banda/event2/27.jpg', func('banda_events_strings', 143)
																													act'Далее' :
																														*clr & cla
																														minut += 5
																														orgasm += 1
																														DPorgasm += 1
																														bj += 1
																														rape += 1
																														gang += 1
																														horny = 0
																														gs 'stat'
																														gs 'zz_render', '', 'city/north/banda/event2/28.jpg', func('banda_events_strings', 144)
																														act'Далее' :
																															*clr & cla
																															minut += 5
																															gs 'stat'
																															gs 'zz_render', '', 'city/north/banda/event2/29.jpg', func('banda_events_strings', 145)
																															act'Далее' :
																																*clr & cla
																																minut += 5
																																gs 'stat'
																																gs 'zz_render', '', 'city/north/banda/event2/30.jpg', func('banda_events_strings', 146)
																																act'Далее' :
																																	*clr & cla
																																	minut += 5
																																	gs 'stat'
																																	gs 'zz_render', '', 'city/north/banda/event2/31.jpg', func('banda_events_strings', 147)
																																	act'Далее' :
																																		*clr & cla
																																		minut += 5
																																		gs 'stat'
																																		gs 'zz_render', '', 'city/north/banda/event2/32.jpg', func('banda_events_strings', 148)
																																		act'Далее' :
																																			*clr & cla
																																			minut += 5
																																			gs 'stat'
																																			gs 'zz_render', '', 'city/north/banda/event2/33.jpg', func('banda_events_strings', 149)
																																			act'Далее' :
																																				*clr & cla
																																				minut += 5
																																				gs 'stat'
																																				gs 'zz_render', '', 'city/north/banda/event2/34.jpg', func('banda_events_strings', 150)
																																				act'Далее' :
																																					*clr & cla
																																					minut += 5
																																					gs 'stat'
																																					gs 'zz_render', '', 'city/north/banda/event2/35.jpg', func('banda_events_strings', 151)
																																					act'Далее' :
																																						*clr & cla
																																						minut += 5
																																						gs 'stat'
																																						gs 'zz_render', '', 'city/north/banda/event2/36.jpg', func('banda_events_strings', 152)
																																						act'Далее' :
																																							*clr & cla
																																							minut += 5
																																							gs 'stat'
																																							gs 'zz_render', '', 'city/north/banda/event2/37.jpg', func('banda_events_strings', 153)
																																							act'Далее' :
																																								*clr & cla
																																								minut += 5
																																								dom -= 1
																																								manna < 20
																																								gs 'zz_funcs','set_gape','anus', iif(lubri>0,10,0),20,1
																																								gs 'zz_funcs','set_gape','vagina',horny, 20, 1
																																								mop = 0
																																								energy += 7
																																								sweat = 1
																																								gs 'zz_funcs', 'cum', 'lip'
																																								gs 'zz_funcs', 'cum', 'face'
																																								banda['fail'] += 1
																																								gs 'stat'
																																								gs 'zz_render', '', 'city/north/banda/event2/38.jpg', func('banda_events_strings', 154)
																																								act'Одется' : gt 'banda_home','room','start'
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
								end
							end
						end
					end
				end
				act'Отдаться добровольно' :
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event2/39.jpg', func('banda_events_strings', 155)
					act'Далее' :
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event2/40.jpg', func('banda_events_strings', 156)
						act'Далее' :
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event2/41.jpg', func('banda_events_strings', 157)
							act'Далее' :
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event2/42.jpg', func('banda_events_strings', 158)
								act'Далее' :
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event2/43.jpg', func('banda_events_strings', 159)
									act'Далее' :
										*clr & cla
										minut += 5
										horny += 15
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event2/44.jpg', func('banda_events_strings', 160)
										act'Далее' :
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event2/45.jpg', func('banda_events_strings', 161)
											act'Далее' :
												*clr & cla
												minut += 5
												horny += 15
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event2/46.jpg', func('banda_events_strings', 162)
												act'Далее' :
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event2/47.jpg', func('banda_events_strings', 163)
													act'Далее' :
														*clr & cla
														minut += 5
														horny += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event2/48.jpg', func('banda_events_strings', 164)
														act'Далее' :
															*clr & cla
															minut += 5
															lubri -= 1
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event2/49.jpg', func('banda_events_strings', 165)
															act'Далее' :
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event2/50.jpg', func('banda_events_strings', 166)
																act'Далее' :
																	*clr & cla
																	minut += 5
																	horny += 10
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event2/51.jpg', func('banda_events_strings', 167)
																	act'Далее' :
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event2/52.jpg', func('banda_events_strings', 168)
																		act'Далее' :
																			*clr & cla
																			minut += 5
																			horny = 80
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event2/53.jpg', func('banda_events_strings', 169)
																			act'Далее' :
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event2/54.jpg', func('banda_events_strings', 170)
																				act'Далее' :
																					*clr & cla
																					minut += 5
																					horny = 90
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event2/55.jpg', func('banda_events_strings', 171)
																					act'Далее' :
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event2/56.jpg', func('banda_events_strings', 172)
																						act'Далее' :
																							*clr & cla
																							minut += 5
																							orgasm += 1
																							DPorgasm += 1
																							gang += 1
																							bj += 1
																							horny = 0
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event2/57.jpg', func('banda_events_strings', 173)
																							act'Далее' :
																								*clr & cla
																								minut += 5
																								horny += 30
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event2/58.jpg', func('banda_events_strings', 174)
																								act'Далее' :
																									*clr & cla
																									minut += 5
																									horny += 35
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event2/59.jpg', func('banda_events_strings', 175)
																									act'Далее' :
																										*clr & cla
																										minut += 5
																										horny = 90
																										gs 'stat'
																										gs 'zz_render', '', 'city/north/banda/event2/60.jpg', func('banda_events_strings', 176)
																										act'Далее' :
																											*clr & cla
																											minut += 5
																											orgasm += 1
																											analorgasm += 1
																											horny = 0
																											gs 'stat'
																											gs 'zz_render', '', 'city/north/banda/event2/61.jpg', func('banda_events_strings', 177)
																											act'Далее' :
																												*clr & cla
																												minut += 5
																												gs 'stat'
																												gs 'zz_render', '', 'city/north/banda/event2/62.jpg', func('banda_events_strings', 178)
																												act'Далее' :
																													*clr & cla
																													minut += 5
																													gs 'stat'
																													gs 'zz_render', '', 'city/north/banda/event2/63.jpg', func('banda_events_strings', 179)
																													act'Далее' :
																														*clr & cla
																														minut += 5
																														gs 'stat'
																														gs 'zz_render', '', 'city/north/banda/event2/64.jpg', func('banda_events_strings', 180)
																														act'Далее' :
																															*clr & cla
																															minut += 5
																															dom -= 4
																															manna = 80
																															gs 'zz_funcs','set_gape','anus', 0,20,1
																															gs 'zz_funcs','set_gape','vagina',horny, 20, 1
																															mop = 0
																															energy += 7
																															sweat = 1
																															gs 'zz_funcs', 'cum', 'lip'
																															gs 'zz_funcs', 'cum', 'face'
																															gs 'stat'
																															gs 'zz_render', '', 'city/north/banda/event2/65.jpg', func('banda_events_strings', 181)
																															act'Одется' : gt 'banda_home','room','start'
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
!Превый ивент для открытия студии
if $args[0] = 'banda_studio1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/event1/01.jpg', func('banda_events_strings', 182)
	act'Выпить':
		*clr & cla
		minut += 5
		gs 'zz_funcs', 'alko', 6
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/event1/02.jpg', func('banda_events_strings', 183)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/event1/03.jpg', func('banda_events_strings', 184)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/event1/04.jpg', func('banda_events_strings', 185)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/event1/05.jpg', func('banda_events_strings', 186)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(6,7)+'.jpg', func('banda_events_strings', 187)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/event1/08.jpg', func('banda_events_strings', 188)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 15
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(9,10)+'.jpg', func('banda_events_strings', 189)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 20
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(11,13)+'.jpg', func('banda_events_strings', 190)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 50
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/event1/14.jpg', func('banda_events_strings', 191)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/event1/15.jpg', func('banda_events_strings', 192)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 65
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(16,17)+'.jpg', func('banda_events_strings', 193)
												act'Далее':
													*clr & cla
													minut += 5
													horny = 80
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(18,19)+'.jpg', func('banda_events_strings', 194)
													act'Далее':
														*clr & cla
														minut += 5
														horny = 90
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(20,21)+'.jpg', func('banda_events_strings', 195)
														act'Далее':
															*clr & cla
															minut += 5
															orgasm += 1
															DPorgasm += 1
															gang += 1
															bj += 1
															horny = 0
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/event1/22.jpg', func('banda_events_strings', 196)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/event1/23.jpg', func('banda_events_strings', 197)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(24,25)+'.jpg', func('banda_events_strings', 198)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/studio/event1/26.jpg', func('banda_events_strings', 199)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(27,28)+'.jpg', func('banda_events_strings', 200)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				money += 1000
																				dom -= 3
																				energe += 5
																				sweat = 1
																				flag_banda['studio_day'] = day
																				flag_banda['studio'] += 1
																				gs 'zz_funcs', 'cum', 'lip'
																				gs 'zz_funcs', 'cum', 'face'
																				gs 'zz_funcs', 'alko', 3
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/studio/event1/29.jpg', func('banda_events_strings', 201)
																				act'Уйти' : gt 'north'
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
	act'Не, я не хочу':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/event1/02.jpg', func('banda_events_strings', 202)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/event1/03.jpg', func('banda_events_strings', 203)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/event1/04.jpg', func('banda_events_strings', 204)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/event1/04.jpg', func('banda_events_strings', 205)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(5,6)+'.jpg', func('banda_events_strings', 206)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/event1/7.jpg', func('banda_events_strings', 207)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 15
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(8,9)+'.jpg', func('banda_events_strings', 208)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 20
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(10,12)+'.jpg', func('banda_events_strings', 209)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 50
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/event1/13.jpg', func('banda_events_strings', 210)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/event1/14.jpg', func('banda_events_strings', 211)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 65
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(15,16)+'.jpg', func('banda_events_strings', 212)
												act'Далее':
													*clr & cla
													minut += 5
													horny = 80
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(17,18)+'.jpg', func('banda_events_strings', 213)
													act'Далее':
														*clr & cla
														minut += 5
														horny = 90
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(19,20)+'.jpg', func('banda_events_strings', 214)
														act'Далее':
															*clr & cla
															minut += 5
															orgasm += 1
															DPorgasm += 1
															gang += 1
															bj += 1
															horny = 0
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/event1/21.jpg', func('banda_events_strings', 215)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/event1/22.jpg', func('banda_events_strings', 216)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(23,24)+'.jpg', func('banda_events_strings', 217)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/studio/event1/25.jpg', func('banda_events_strings', 218)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/studio/event1/'+rand(26,27)+'.jpg', func('banda_events_strings', 219)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				money += 1000
																				dom -= 3
																				energe += 5
																				sweat = 1
																				flag_banda['studio_day'] = day
																				flag_banda['studio'] += 1
																				gs 'zz_funcs', 'cum', 'lip'
																				gs 'zz_funcs', 'cum', 'face'
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/studio/event1/28.jpg', func('banda_events_strings', 220)
																				act'Уйти' : gt 'north'
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
!Второй ивент для открытия студии
if $args[0] = 'banda_studio2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('banda_events_strings', 221)
	act'Далее':
		*clr & cla
		minut += 5
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/event2/01.jpg', func('banda_events_strings', 222)
		act'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/event2/02.jpg', func('banda_events_strings', 223)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/event2/03.jpg', func('banda_events_strings', 224)
				act'Далее':
					*clr & cla
					minut += 5
					horny = 50
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/event2/04.jpg', func('banda_events_strings', 225)
					act'Далее':
						*clr & cla
						minut += 5
						horny = 65
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/event2/05.jpg', func('banda_events_strings', 226)
						act'Далее':
							*clr & cla
							minut += 5
							horny = 85
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/event2/06.jpg', func('banda_events_strings', 227)
							act'Далее':
								*clr & cla
								minut += 5
								orgasm += 1
								DPorgasm += 1
								gang += 1
								bj += 1
								horny = 0
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/event2/07.jpg', func('banda_events_strings', 228)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 20
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/event2/08.jpg', func('banda_events_strings', 229)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 50
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/event2/09.jpg', func('banda_events_strings', 230)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 90
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/event2/10.jpg', func('banda_events_strings', 231)
											act'Далее':
												*clr & cla
												minut += 5
												orgasm += 1
												DPorgasm += 1
												horny = 0
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/event2/11.jpg', func('banda_events_strings', 232)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/event2/12.jpg', func('banda_events_strings', 233)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/event2/13.jpg', func('banda_events_strings', 234)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/event2/14.jpg', func('banda_events_strings', 235)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/event2/15.jpg', func('banda_events_strings', 236)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/event2/16.jpg', func('banda_events_strings', 237)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/studio/event2/17.jpg', func('banda_events_strings', 238)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			anus += 2
																			manna = 100
																			sweat = 1
																			banda['studio'] = 1
																			gs 'zz_funcs', 'cum', 'lip'
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/studio/event2/18.jpg', func('banda_events_strings', 239)
																			act'Уйти' : gt 'north'
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
!Разговор с бандой когда света рабыня
if $args[0] = 'razgovor1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','', func('banda_events_strings', 240)
	act'Отойти': gt 'banda_home','room'
end
!Секса по собсвенной просьбе с бандой когда света рабыня
if $args[0] = 'razgovor2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/razgovor/01.jpg', func('banda_events_strings', 241)
	if rand(1,2) = 1:
		act 'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', '', func('banda_events_strings', 242)
			act 'Отойти': gt 'banda_home','room'
		end
	else
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/razgovor/02.jpg', func('banda_events_strings', 243)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/razgovor/03.jpg', func('banda_events_strings', 244)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/razgovor/04.jpg', func('banda_events_strings', 245)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/razgovor/05.jpg', func('banda_events_strings', 246)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/razgovor/06.jpg', func('banda_events_strings', 247)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 75
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/razgovor/07.jpg', func('banda_events_strings', 248)
								act'Далее':
									*clr & cla
									minut += 5
									horny = 85
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/razgovor/'+rand(8,9)+'.jpg', func('banda_events_strings', 249)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 95
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/razgovor/'+rand(10,11)+'.jpg', func('banda_events_strings', 250)
										act'Далее':
											*clr & cla
											minut += 5
											orgasm += 1
											DPorgasm += 1
											gang += 1
											sex += 1
											anal += 1
											bj += 1
											horny = 0
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/razgovor/12.jpg', func('banda_events_strings', 251)
											act'Попросить два члена в задницу':
												*clr & cla
												minut += 5
												horny = 95
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/razgovor/13.gif', func('banda_events_strings', 252)
												act'Далее':
													*clr & cla
													minut += 5
													orgasm += 1
													DPorgasm += 1
													horny = 0
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/razgovor/14.gif', func('banda_events_strings', 253)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/razgovor/15.jpg', func('banda_events_strings', 254)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/razgovor/16.jpg', func('banda_events_strings', 255)
															act'Далее':
																*clr & cla
																minut += 5
																manna = 100
																sweat = 1
																gs 'zz_funcs','set_gape','anus', iif(lubri>0,10,0),20,1
																gs 'zz_funcs','set_gape','vagina',horny, 20, 1
																gs 'zz_funcs', 'cum', 'lip'
																gs 'zz_funcs', 'cum', 'face'
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/razgovor/17.jpg', func('banda_events_strings', 256)
																act'Одется' : gt 'banda_home','room'
															end
														end
													end
												end
											end
											act'Продолжать так':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/razgovor/15.jpg', func('banda_events_strings', 257)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/razgovor/16.jpg', func('banda_events_strings', 258)
													act'Далее':
														*clr & cla
														minut += 5
														manna = 100
														sweat = 1
														gs 'zz_funcs', 'cum', 'lip'
														gs 'zz_funcs', 'cum', 'face'
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/razgovor/17.jpg', func('banda_events_strings', 259)
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
!Повторяющийся ивент
if $args[0] = 'banda_event13':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('banda_events_strings', 260)
	act'Выпить':
		*clr & cla
		minut += 5
		gs 'zz_funcs','alko', 3
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event13/01.jpg', func('banda_events_strings', 261)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event13/02.jpg', func('banda_events_strings', 262)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event13/03.jpg', func('banda_events_strings', 263)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event13/04.jpg', func('banda_events_strings', 264)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 15
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event13/05.jpg', func('banda_events_strings', 265)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event13/06.jpg', func('banda_events_strings', 266)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event13/07.jpg', func('banda_events_strings', 267)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 25
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event13/08.jpg', func('banda_events_strings', 268)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event13/09.jpg', func('banda_events_strings', 269)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 70
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event13/'+rand(10,11)+'.jpg', func('banda_events_strings', 270)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 85
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event13/12.jpg', func('banda_events_strings', 271)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'park/banda/event13/13.jpg', func('banda_events_strings', 272)
													act'Далее':
														*clr & cla
														minut += 5
														orgasm += 1
														analorgasm += 1
														gang += 1
														bj += 1
														horny = 0
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event13/'+rand(14,15)+'.jpg', func('banda_events_strings', 273)
														act'Далее':
															*clr & cla
															minut += 5
															horny += 25
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event13/'+rand(16,17)+'.jpg', func('banda_events_strings', 274)
															act'Далее':
																*clr & cla
																minut += 5
																horny += 30
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event13/'+rand(18,19)+'.jpg', func('banda_events_strings', 275)
																act'Далее':
																	*clr & cla
																	minut += 5
																	horny = 90
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event13/20.jpg', func('banda_events_strings', 276)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		orgasm += 1
																		analorgasm += 1
																		horny = 0
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event13/21.jpg', func('banda_events_strings', 277)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event13/22.jpg', func('banda_events_strings', 278)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event13/23.jpg', func('banda_events_strings', 279)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					sweat = 1
																					anus += 3
																					gs 'zz_funcs','set_gape','anus', iif(lubri>0,10,0),20,1
																					gs 'zz_funcs', 'cum', 'lip'
																					gs 'zz_funcs', 'cum', 'ass'
																					gs 'zz_funcs', 'alko', 1
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event13/24.jpg', func('banda_events_strings', 280)
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
!ивент для выбора профессии в банде
if $args[0] = 'banda_event15':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event15/15.jpg', func('banda_events_strings', 281)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event15/01.jpg', func('banda_events_strings', 282)
		act'Смотреть':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event15/02.jpg', func('banda_events_strings', 283)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event15/03.jpg', func('banda_events_strings', 284)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event15/04.gif', func('banda_events_strings', 285)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event15/05.gif', func('banda_events_strings', 286)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 20
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event15/06.jpg', func('banda_events_strings', 287)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event15/07.gif', func('banda_events_strings', 288)
								act'Далее':
									*clr & cla
									minut += 5
									horny = 70
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event15/08.gif', func('banda_events_strings', 289)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event15/09.gif', func('banda_events_strings', 290)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event15/10.gif', func('banda_events_strings', 291)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event15/11.gif', func('banda_events_strings', 292)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event15/12.gif', func('banda_events_strings', 293)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event15/13.jpg', func('banda_events_strings', 294)
														act'Далее':
															*clr & cla
															minut += 5
															horny = 80
															bj += 1
															banda['banda_event15'] = 1
															gs 'zz_funcs', 'cum', 'lip'
															gs 'zz_funcs', 'cum', 'face'
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event15/14.gif', func('banda_events_strings', 295)
															act'Идти в ванную' : gt 'banda_home','bathroom'
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