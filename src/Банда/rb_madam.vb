!Стартовый ивент ветки мадам
if $args[0] = 'eventmadam1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('rb_madam_strings', 1)
	act'Далее':
		*clr & cla
		minut += 5
		banda['madam'] = 1
		gs 'stat'
		gs 'zz_render', '', '', func('rb_madam_strings', 2)
		act'Уйти': gt 'banda_home', 'room'
	end
end
!Первый ивент ветки мадам с Аней с пляжа
if $args[0] = 'eventmadam2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('rb_madam_strings', 3)
	if rand(1,2) = 1:
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', '', func('rb_madam_strings', 4)
			act'Отойти': gt $loc, $metka
		end
	else
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', '', func('rb_madam_strings', 5)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event19/01.jpg', func('rb_madam_strings', 6)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event19/02.jpg', func('rb_madam_strings', 7)
					act'Сразу, сразу!':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event19/03.jpg', func('rb_madam_strings', 8)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 10
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event19/04.jpg', func('rb_madam_strings', 9)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event19/05.jpg', func('rb_madam_strings', 10)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 15
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event19/06.jpg', func('rb_madam_strings', 11)
									act'Далее':
										*clr & cla
										minut += 5
										horny += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event19/07.jpg', func('rb_madam_strings', 12)
										act'Далее':
											*clr & cla
											minut += 5
											horny += 20
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event19/08.jpg', func('rb_madam_strings', 13)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event19/09.jpg', func('rb_madam_strings', 14)
												act'Далее':
													*clr & cla
													minut += 5
													horny = 80
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event19/10.jpg', func('rb_madam_strings', 15)
													act'Далее':
														*clr & cla
														minut += 5
														horny = 90
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event19/11.jpg', func('rb_madam_strings', 16)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event19/12.jpg', func('rb_madam_strings', 17)
															act'Далее':
																*clr & cla
																minut += 5
																orgasm += 1
																DPorgasm += 1
																gang += 1
																bj += 1
																horny = 0
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event19/13.jpg', func('rb_madam_strings', 18)
																act'Далее':
																	*clr & cla
																	minut += 5
																	horny += 20
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event19/14.jpg', func('rb_madam_strings', 19)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny = 60
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event19/15.jpg', func('rb_madam_strings', 20)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny = 80
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event19/16.jpg', func('rb_madam_strings', 21)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				orgasm += 1
																				analorgasm += 1
																				horny = 0
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event19/17.jpg', func('rb_madam_strings', 22)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					horny += 10
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event19/18.jpg', func('rb_madam_strings', 23)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						horny += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event19/19.jpg', func('rb_madam_strings', 24)
																						act'Далее':
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event19/20.jpg', func('rb_madam_strings', 25)
																							act'Далее':
																								*clr & cla
																								minut += 5
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event19/21.jpg', func('rb_madam_strings', 26)
																								act'Далее':
																									*clr & cla
																									minut += 5
																									dom += 1
																									manna -= 10
																									banda['madam'] = 2
																									gs 'zz_funcs', 'cum', 'lip'
																									gs 'zz_funcs', 'cum', 'anus'
																									gs 'zz_funcs', 'alko', 1
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event19/22.jpg', func('rb_madam_strings', 27)
																									act'Уйти': gt 'south'
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
					act'Выпить':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_funcs', 'alko', 3
						gs 'zz_render', '', 'city/north/banda/event19/03.jpg', func('rb_madam_strings', 28)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 10
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event19/04.jpg', func('rb_madam_strings', 29)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event19/05.jpg', func('rb_madam_strings', 30)
								act'Далее':
									*clr & cla
									minut += 5
									horny += 15
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event19/06.jpg', func('rb_madam_strings', 31)
									act'Далее':
										*clr & cla
										minut += 5
										horny += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event19/07.jpg', func('rb_madam_strings', 32)
										act'Далее':
											*clr & cla
											minut += 5
											horny += 20
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event19/08.jpg', func('rb_madam_strings', 33)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event19/09.jpg', func('rb_madam_strings', 34)
												act'Далее':
													*clr & cla
													minut += 5
													horny = 80
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event19/10.jpg', func('rb_madam_strings', 35)
													act'Далее':
														*clr & cla
														minut += 5
														horny = 90
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event19/11.jpg', func('rb_madam_strings', 36)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event19/12.jpg', func('rb_madam_strings', 37)
															act'Далее':
																*clr & cla
																minut += 5
																orgasm += 1
																DPorgasm += 1
																gang += 1
																bj += 1
																horny = 0
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event19/13.jpg', func('rb_madam_strings', 38)
																act'Далее':
																	*clr & cla
																	minut += 5
																	horny += 20
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event19/14.jpg', func('rb_madam_strings', 39)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny = 60
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event19/15.jpg', func('rb_madam_strings', 40)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny = 80
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event19/16.jpg', func('rb_madam_strings', 41)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				orgasm += 1
																				analorgasm += 1
																				horny = 0
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event19/17.jpg', func('rb_madam_strings', 42)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					horny += 10
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event19/18.jpg', func('rb_madam_strings', 43)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						horny += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event19/19.jpg', func('rb_madam_strings', 44)
																						act'Далее':
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event19/20.jpg', func('rb_madam_strings', 45)
																							act'Далее':
																								*clr & cla
																								minut += 5
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event19/21.jpg', func('rb_madam_strings', 46)
																								act'Далее':
																									*clr & cla
																									minut += 5
																									dom += 1
																									manna -= 10
																									banda['madam'] = 2
																									gs 'zz_funcs', 'cum', 'lip'
																									gs 'zz_funcs', 'cum', 'anus'
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event19/22.jpg', func('rb_madam_strings', 47)
																									act'Уйти': gt 'south'
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
!Первый ивент с Самантой
if $args[0] = 'eventmadam3':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event20/01.jpg', func('rb_madam_strings', 48)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event20/02.jpg', func('rb_madam_strings', 49)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event20/03.jpg', func('rb_madam_strings', 50)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event20/04.jpg', func('rb_madam_strings', 51)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event20/05.jpg', func('rb_madam_strings', 52)
					act'Далее':
						*clr & cla
						minut += 5
						money += 17000
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event20/06.jpg', func('rb_madam_strings', 53)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event20/07.jpg', func('rb_madam_strings', 54)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event20/08.jpg', func('rb_madam_strings', 55)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event20/09.jpg', func('rb_madam_strings', 56)
									act'Далее':
										*clr & cla
										minut += 5
										horny += 10
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event20/10.jpg', func('rb_madam_strings', 57)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event20/11.jpg', func('rb_madam_strings', 58)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event20/12.jpg', func('rb_madam_strings', 59)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event20/13.jpg', func('rb_madam_strings', 60)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 25
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event20/14.jpg', func('rb_madam_strings', 61)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event20/15.jpg', func('rb_madam_strings', 62)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event20/16.jpg', func('rb_madam_strings', 63)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event20/17.jpg', func('rb_madam_strings', 64)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event20/18.jpg', func('rb_madam_strings', 65)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny = 70
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event20/19.jpg', func('rb_madam_strings', 66)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event20/20.jpg', func('rb_madam_strings', 67)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event20/21.jpg', func('rb_madam_strings', 68)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event20/22.jpg', func('rb_madam_strings', 69)
																						act'Далее':
																							*clr & cla
																							minut += 5
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event20/23.jpg', func('rb_madam_strings', 70)
																							act'Далее':
																								*clr & cla
																								minut += 5
																								gs 'stat'
																								gs 'zz_render', '', 'city/north/banda/event20/24.jpg', func('rb_madam_strings', 71)
																								act'Далее':
																									*clr & cla
																									minut += 5
																									gs 'stat'
																									gs 'zz_render', '', 'city/north/banda/event20/25.jpg', func('rb_madam_strings', 72)
																									act'Далее':
																										*clr & cla
																										minut += 5
																										horny = 75
																										gs 'stat'
																										gs 'zz_render', '', 'city/north/banda/event20/26.jpg', func('rb_madam_strings', 73)
																										act'Далее':
																											*clr & cla
																											minut += 5
																											horny = 85
																											gs 'stat'
																											gs 'zz_render', '', 'city/north/banda/event20/27.jpg', func('rb_madam_strings', 74)
																											act'Далее':
																												*clr & cla
																												minut += 5
																												gs 'stat'
																												gs 'zz_render', '', 'city/north/banda/event20/28.jpg', func('rb_madam_strings', 75)
																												act'Далее':
																													*clr & cla
																													minut += 5
																													gs 'stat'
																													gs 'zz_render', '', 'city/north/banda/event20/29.jpg', func('rb_madam_strings', 76)
																													act'Далее':
																														*clr & cla
																														minut += 5
																														gs 'stat'
																														gs 'zz_render', '', 'city/north/banda/event20/30.jpg', func('rb_madam_strings', 77)
																														act'Далее':
																															*clr & cla
																															minut += 5
																															orgasm += 1
																															horny = 0
																															gs 'stat'
																															gs 'zz_render', '', 'city/north/banda/event20/31.jpg', func('rb_madam_strings', 78)
																															act'Далее':
																																*clr & cla
																																minut += 5
																																banda['madam'] = 3
																																dom += 2
																																madam['eventmadam3'] = daystart + 7
																																criminal += rand(1,5)
																																gs 'stat'
																																gs 'zz_render', '', 'city/north/banda/event20/32.jpg', func('rb_madam_strings', 79)
																																act'Уйти': gt 'south'
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
!Воторой ивент с Самантой
if $args[0] = 'eventmadam4':
	*clr & cla
	minut += 5
	horny += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event21/01.jpg', func('rb_madam_strings', 80)
	act'Уйти': gt 'banda_home','corridor'
	act'Смотреть':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event21/02.jpg', func('rb_madam_strings', 81)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event21/03.jpg', func('rb_madam_strings', 82)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event21/04.jpg', func('rb_madam_strings', 83)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event21/05.jpg', func('rb_madam_strings', 84)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 15
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event21/06.jpg', func('rb_madam_strings', 85)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event21/07.jpg', func('rb_madam_strings', 86)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event21/08.jpg', func('rb_madam_strings', 87)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event21/09.jpg', func('rb_madam_strings', 88)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 50
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event21/10.jpg', func('rb_madam_strings', 89)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event20/22.jpg', func('rb_madam_strings', 90)
											act'Далее':
												*clr & cla
												minut += 5
												banda['madam'] = 4
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event20/32.jpg', func('rb_madam_strings', 91)
												act'Уйти': gt 'banda_home','corridor'
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
!Третий ивент с Самантой
if $args[0] = 'eventmadam5':
	*clr & cla
	minut += 5
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/event22/01.jpg', func('rb_madam_strings', 92)
	act'Далее':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event22/02.jpg', func('rb_madam_strings', 93)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event22/03.jpg', func('rb_madam_strings', 94)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event22/04.jpg', func('rb_madam_strings', 95)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event22/05.jpg', func('rb_madam_strings', 96)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 25
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event22/06.jpg', func('rb_madam_strings', 97)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event22/07.jpg', func('rb_madam_strings', 98)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 75
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event22/08.jpg', func('rb_madam_strings', 99)
								act'Далее':
									*clr & cla
									minut += 5
									orgasm += 1
									lesbian += 1
									horny = 0
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event22/09.jpg', func('rb_madam_strings', 100)
									act'Далее':
										*clr & cla
										minut += 5
										dom += 3
										banda['madam'] = 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event22/10.jpg', func('rb_madam_strings', 101)
										act'Уйти': gt 'banda_home','corridor'
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
!Ивент наказание светки за Саманту
if $args[0] = 'eventmadam6':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('rb_madam_strings', 102)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event23/01.jpg', func('rb_madam_strings', 103)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event23/02.jpg', func('rb_madam_strings', 104)
			act'Далее':
				*clr & cla
				minut += 5
				mop = 3
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event23/03.jpg', func('rb_madam_strings', 105)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event23/04.jpg', func('rb_madam_strings', 106)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event23/05.jpg', func('rb_madam_strings', 107)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 15
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event23/06.jpg', func('rb_madam_strings', 108)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event23/07.jpg', func('rb_madam_strings', 109)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event23/08.jpg', func('rb_madam_strings', 110)
									act'Далее':
										*clr & cla
										minut += 5
										horny += 15
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event23/09.jpg', func('rb_madam_strings', 111)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event23/10.jpg', func('rb_madam_strings', 112)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event23/11.jpg', func('rb_madam_strings', 113)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event23/12.jpg', func('rb_madam_strings', 114)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 50
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event23/13.jpg', func('rb_madam_strings', 115)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event23/14.jpg', func('rb_madam_strings', 116)
															act'Далее':
																*clr & cla
																minut += 5
																horny = 70
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event23/15.jpg', func('rb_madam_strings', 117)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event23/16.jpg', func('rb_madam_strings', 118)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny = 80
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event23/17.jpg', func('rb_madam_strings', 119)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny = 90
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event23/18.jpg', func('rb_madam_strings', 120)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				orgasm += 1
																				DPorgasm += 1
																				gang += 1
																				bj += 1
																				horny = 0
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event23/19.jpg', func('rb_madam_strings', 121)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event23/20.jpg', func('rb_madam_strings', 122)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/event23/21.jpg', func('rb_madam_strings', 123)
																						act'Далее':
																							*clr & cla
																							minut += 60
																							banda['eventmadam6'] = 1
																							banda['madam'] = 6
																							gs 'zz_funcs', 'cum', 'lip'
																							gs 'stat'
																							gs 'zz_render', '', 'city/north/banda/event23/22.jpg', func('rb_madam_strings', 124)
																							act'Уйти': gt 'banda_home','corridor'
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
!Повторяющийся ивент с Самантой
if $args[0] = 'eventmadam7':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('rb_madam_strings', 125)
	act'Заглянуть и посмотреть':
		*clr & cla
		minut += 5
		horny += 15
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/event24/01.gif', func('rb_madam_strings', 126)
		act'Неа, потом, может':
			*clr & cla
			minut += 5
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('rb_madam_strings', 127)
			act'Уйти': gt 'banda_home','corridor'
		end
		act'Вау, конечно! Я сейчас!':
			*clr & cla
			minut += 5
			horny += 20
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/event24/02.gif', func('rb_madam_strings', 128)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/event24/03.gif', func('rb_madam_strings', 129)
				act'Далее':
					*clr & cla
					minut += 5
					horny = 60
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/event24/04.gif', func('rb_madam_strings', 130)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/event24/05.gif', func('rb_madam_strings', 131)
						act'Далее':
							*clr & cla
							minut += 5
							horny = 75
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/event24/06.gif', func('rb_madam_strings', 132)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 95
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/event24/07.gif', func('rb_madam_strings', 133)
								act'Далее':
									*clr & cla
									minut += 5
									orgasm += 1
									analorgasm += 1
									gang += 1
									bj += 1
									horny = 0
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/event24/08.gif', func('rb_madam_strings', 134)
									act'Далее':
										*clr & cla
										minut += 5
										horny += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/event24/09.gif', func('rb_madam_strings', 135)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/event24/10.gif', func('rb_madam_strings', 136)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/event24/11.jpg', func('rb_madam_strings', 137)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/event24/12.gif', func('rb_madam_strings', 138)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 5
														gs 'zz_funcs', 'cum', 'lip'
														gs 'zz_funcs', 'cum', 'anus'
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/event24/13.gif', func('rb_madam_strings', 139)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/event24/14.jpg', func('rb_madam_strings', 140)
															act'Да пошла эта дешёвка! Мне лень':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', '', func('rb_madam_strings', 141)
																act'Уйти': gt 'banda_home','corridor'
															end
															act'О, я с удовольствием!':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/event24/15.jpg', func('rb_madam_strings', 142)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/event24/16.jpg', func('rb_madam_strings', 143)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		horny += 10
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/event24/17.jpg', func('rb_madam_strings', 144)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/event24/18.jpg', func('rb_madam_strings', 145)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/event24/19.jpg', func('rb_madam_strings', 146)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					horny += 10
																					dom += 3
																					banda['eventmadam7'] = day
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/event24/20.jpg', func('rb_madam_strings', 147)
																					act'Уйти': gt 'banda_home','corridor'
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