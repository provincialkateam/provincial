!Мини ивент в студии
if $ARGS[0] = 'mini1':
	*clr & cla
	minut += 5
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/studia/mini/'+rand(1,13)+'.jpg', func('banda_studioQW_strings', 1)
	act'Уйти': gt 'zz_pornstudio','shooting_space'
end
!Мини ивент в гримерной
if $ARGS[0] = 'mini2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/grim/mini/'+rand(1,5)+'.jpg', func('banda_studioQW_strings', 2)
	act'Уйти': gt 'zz_pornstudio','dressing_room'
end
!Мини ивент в гримерной 3 и выше уровня
if $ARGS[0] = 'mini3':
	*clr & cla
	minut += 5
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/grim/mini/'+rand(6,10)+'.jpg', func('banda_studioQW_strings', 3)
	act'Уйти': gt 'zz_pornstudio','dressing_room'
end
!Мини ивет в офисе с гримершей
if $ARGS[0] = 'mini4':
	*clr & cla
	minut += 5
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/mini/'+rand(1,5)+'.jpg', func('banda_studioQW_strings', 4)
	act'Уйти': gt 'zz_pornstudio'
end
!Мини ивент в офисе 4 и выше уровня
if $ARGS[0] = 'mini5':
	*clr & cla
	minut += 5
	horny += 15
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/mini/'+rand(6,10)+'.jpg', func('banda_studioQW_strings', 5)
	act'Уйти': gt 'zz_pornstudio'
end
!ивент в офисе с маструбацией светки
if $ARGS[0] = 'ofisevent1':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/01.jpg', func('banda_studioQW_strings', 6)
	act'Далее':
		*clr & cla
		minut += 5
		horny = 55
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/02.jpg', func('banda_studioQW_strings', 7)
		act'Далее':
			*clr & cla
			minut += 5
			horny = 60
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/03.jpg', func('banda_studioQW_strings', 8)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/04.jpg', func('banda_studioQW_strings', 9)
				act'Далее':
					*clr & cla
					minut += 5
					horny = 65
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/'+rand(5,6)+'.jpg', func('banda_studioQW_strings', 10)
					act'Далее':
						*clr & cla
						minut += 5
						horny = 70
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/'+rand(7,8)+'.jpg', func('banda_studioQW_strings', 11)
						act'Далее':
							*clr & cla
							minut += 5
							horny = 80
							studio['ofisevent1'] += 1
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/'+rand(9,13)+'.jpg', func('banda_studioQW_strings', 12)
							if studio['ofisevent1'] = 5:
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/23.jpg', func('banda_studioQW_strings', 13)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/24.jpg', func('banda_studioQW_strings', 14)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/25.jpg', func('banda_studioQW_strings', 15)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/26.jpg', func('banda_studioQW_strings', 16)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/27.jpg', func('banda_studioQW_strings', 17)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/28.jpg', func('banda_studioQW_strings', 18)
														act'Далее':
															*clr & cla
															minut += 5
															horny = 85
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/29.jpg', func('banda_studioQW_strings', 19)
															act'Далее':
																*clr & cla
																minut += 5
																horny = 95
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/30.jpg', func('banda_studioQW_strings', 20)
																act'Далее':
																	*clr & cla
																	minut += 5
																	orgasm += 1
																	lesbian += 1
																	horny = 0
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/31.jpg', func('banda_studioQW_strings', 21)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/32.jpg', func('banda_studioQW_strings', 22)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			horny += 5
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/33.jpg', func('banda_studioQW_strings', 23)
																			act'Далее':
																				*clr & cla
																				minut += 5
																				horny += 5
																				gs 'stat'
																				gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/34.jpg', func('banda_studioQW_strings', 24)
																				act'Далее':
																					*clr & cla
																					minut += 5
																					horny += 10
																					gs 'stat'
																					gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/35.jpg', func('banda_studioQW_strings', 25)
																					act'Далее':
																						*clr & cla
																						minut += 5
																						studio['inna'] = 1
																						gs 'stat'
																						gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/36.jpg', func('banda_studioQW_strings', 26)
																						act'Привести себя в порядок': gt 'zz_pornstudio'
																					end
																				end
																			end
																		end
																	end
																end
															end
														end
													end
												end
											end
										end
									end
								end
							else
								act'Далее':
									*clr & cla
									minut += 5
									horny = 95
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/14.jpg', func('banda_studioQW_strings', 27)
									act'Далее':
										*clr & cla
										minut += 5
										orgasm += 1
										mastr += 1
										horny = 0
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/'+rand(15,20)+'.jpg', func('banda_studioQW_strings', 28)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/21.jpg', func('banda_studioQW_strings', 29)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event1/22.jpg', func('banda_studioQW_strings', 30)
												act'Привести себя в порядок': gt 'zz_pornstudio'
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Ивент с Инной и Геннадием
if $ARGS[0] = 'ofisevent2':
	*clr & cla
	minut += 5
	horny += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/'+rand(1,2)+'.jpg', func('banda_studioQW_strings', 31)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/'+rand(3,4)+'.jpg', func('banda_studioQW_strings', 32)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/5.jpg', func('banda_studioQW_strings', 33)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/'+rand(6,7)+'.jpg', func('banda_studioQW_strings', 34)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/'+rand(8,9)+'.jpg', func('banda_studioQW_strings', 35)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/10.jpg', func('banda_studioQW_strings', 36)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/'+rand(11,13)+'.jpg', func('banda_studioQW_strings', 37)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/14.jpg', func('banda_studioQW_strings', 38)
								act'Далее':
									*clr & cla
									minut += 5
									studio['ofisevent2'] += 1
									studio['ofisevent2_day'] = day
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event2/'+rand(15,16)+'.jpg', func('banda_studioQW_strings', 39)
									act'Работать': gt 'zz_pornstudio'
								end
							end
						end
					end
				end
			end
		end
	end
end
!мвент с тройничком Инны
if $ARGS[0] = 'ofisevent3':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/1.jpg', func('banda_studioQW_strings', 40)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(2,3)+'.jpg', func('banda_studioQW_strings', 41)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(4,5)+'.jpg', func('banda_studioQW_strings', 42)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(6,7)+'.jpg', func('banda_studioQW_strings', 43)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 10
					studio['ofisevent3'] += 1
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(8,10)+'.jpg', func('banda_studioQW_strings', 44)
					if studio['ofisevent3'] = 1:
						act'Далее':
							*clr & cla
							minut += 5
							horny += 15
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(11,13)+'.jpg', func('banda_studioQW_strings', 45)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 15
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(14,16)+'.jpg', func('banda_studioQW_strings', 46)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/17.jpg', func('banda_studioQW_strings', 47)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(18,20)+'.jpg', func('banda_studioQW_strings', 48)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(21,22)+'.jpg', func('banda_studioQW_strings', 49)
											act'Далее':
												*clr & cla
												minut += 5
												horny += 15
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(23,25)+'.jpg', func('banda_studioQW_strings', 50)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(26,27)+'.jpg', func('banda_studioQW_strings', 51)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/28.jpg', func('banda_studioQW_strings', 52)
														act'Далее':
															*clr & cla
															minut += 5
															horny += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(29,31)+'.jpg', func('banda_studioQW_strings', 53)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/32.jpg', func('banda_studioQW_strings', 54)
																act'Далее':
																	*clr & cla
																	minut += 5
																	studio['ofisevent3_day'] = day
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/33.jpg', func('banda_studioQW_strings', 55)
																	act'Работать': gt 'zz_pornstudio'
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					else
						act'Далее':
							*clr & cla
							minut += 5
							horny += 15
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(11,13)+'.jpg', func('banda_studioQW_strings', 56)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 15
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(14,16)+'.jpg', func('banda_studioQW_strings', 57)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(18,20)+'.jpg', func('banda_studioQW_strings', 58)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(21,22)+'.jpg', func('banda_studioQW_strings', 59)
										act'Далее':
											*clr & cla
											minut += 5
											horny += 15
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(23,25)+'.jpg', func('banda_studioQW_strings', 60)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(26,27)+'.jpg', func('banda_studioQW_strings', 61)
												act'Далее':
													*clr & cla
													minut += 5
													horny += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/28.jpg', func('banda_studioQW_strings', 62)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/'+rand(29,31)+'.jpg', func('banda_studioQW_strings', 63)
														act'Далее':
															*clr & cla
															minut += 5
															studio['ofisevent3_day'] = day
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/ofis/event3/32.jpg', func('banda_studioQW_strings', 64)
															act'Работать': gt 'zz_pornstudio'
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Ивент с Инной в ванной
if $ARGS[0] = 'ofisevent4':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/grim/event1/1.jpg', func('banda_studioQW_strings', 65)
	act'Далее':
		*clr & cla
		minut += 5
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(2,3)+'.jpg', func('banda_studioQW_strings', 66)
		act'Далее':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(4,5)+'.jpg', func('banda_studioQW_strings', 67)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(6,7)+'.jpg', func('banda_studioQW_strings', 68)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/grim/event1/8.jpg', func('banda_studioQW_strings', 69)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(9,10)+'.jpg', func('banda_studioQW_strings', 70)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 20
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(11,12)+'.jpg', func('banda_studioQW_strings', 71)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(13,14)+'.jpg', func('banda_studioQW_strings', 72)
								act'Далее':
									*clr & cla
									minut += 5
									horny = 65
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(15,16)+'.jpg', func('banda_studioQW_strings', 73)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/grim/event1/17.jpg', func('banda_studioQW_strings', 74)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 95
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(18,20)+'.jpg', func('banda_studioQW_strings', 75)
											act'Далее':
												*clr & cla
												minut += 5
												orgasm += 1
												DPorgasm += 1
												gang += 1
												bg += 1
												horny = 0
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(21,22)+'.jpg', func('banda_studioQW_strings', 76)
												act'Далее':
													*clr & cla
													minut += 5
													horny += 10
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(23,24)+'.jpg', func('banda_studioQW_strings', 77)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 25
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(25,26)+'.jpg', func('banda_studioQW_strings', 78)
														act'Далее':
															*clr & cla
															minut += 5
															horny = 70
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(27,28)+'.jpg', func('banda_studioQW_strings', 79)
															act'Далее':
																*clr & cla
																minut += 5
																horny = 90
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(29,30)+'.jpg', func('banda_studioQW_strings', 80)
																act'Далее':
																	*clr & cla
																	minut += 5
																	orgasm += 1
																	analorgasm += 1
																	horny = 0
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/grim/event1/'+rand(31,32)+'.jpg', func('banda_studioQW_strings', 81)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		studio['ofisevent4_day'] = day
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/studio/grim/event1/33.jpg', func('banda_studioQW_strings', 82)
																		act 'Помытся': gt 'zz_pornstudio','dressing_room'
																	end
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Диалог с бандитами
if $ARGS[0] = 'ofisdialog1':
	if rand(1,2) = 1:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('banda_studioQW_strings', 83)
		act'Показать видео':
			*clr & cla
			minut += 5
			studio['ofisdialog1'] = day
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/1.jpg', func('banda_studioQW_strings', 84)
			act'Поболтать еще и сказать им, чтобы расслабились с актрисками': gt 'ofis'
			act'Обслужить бандитов': gt 'banda_studioQW','ofisevent5'
		end
	else
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('banda_studioQW_strings', 85)
		act'Показать видео':
			*clr & cla
			minut += 5
			horny += 10
			studio['ofisdialog1'] = day
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/1.jpg', func('banda_studioQW_strings', 86)
			act'Поболтать еще и сказать им, чтобы расслабились с актрисками': gt 'ofis'
			act'Обслужить бандитов': gt 'banda_studioQW','ofisevent6'
		end
	end
end
!Диалог при красоте больше 60
if $ARGS[0] = 'ofisdialog2':
	*clr & cla
	minut += 5
	studio['ofisdialog2'] = day
	gs 'stat'
	gs 'zz_render', '', '', func('banda_studioQW_strings', 87)
	act'Поболтать еще немного и заняться работой': gt 'zz_pornstudio'
	act'Приставать': gt 'banda_studioQW','ofisevent7'
end
!Первый ивент Светки с бандитами после диалога
if $ARGS[0] = 'ofisevent5':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/2.jpg', func('banda_studioQW_strings', 88)
	act'Далее':
		*clr & cla
		minut += 5
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/3.jpg', func('banda_studioQW_strings', 89)
		act'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/4.jpg', func('banda_studioQW_strings', 90)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(5,6)+'.jpg', func('banda_studioQW_strings', 91)
				act'Далее':
					*clr & cla
					minut += 5
					horny = 50
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(7,9)+'.jpg', func('banda_studioQW_strings', 92)
					act'Далее':
						*clr & cla
						minut += 5
						horny = 60
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(10,11)+'.jpg', func('banda_studioQW_strings', 93)
						act'Далее':
							*clr & cla
							minut += 5
							horny = 70
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(12,14)+'.jpg', func('banda_studioQW_strings', 94)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 85
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(15,16)+'.jpg', func('banda_studioQW_strings', 95)
								act'Далее':
									*clr & cla
									minut += 5
									orgasm += 1
									DPorgasm += 1
									gang += 1
									bj += 1
									horny = 0
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(17,18)+'.jpg', func('banda_studioQW_strings', 96)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(19,20)+'.jpg', func('banda_studioQW_strings', 97)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(21,22)+'.jpg', func('banda_studioQW_strings', 98)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(23,24)+'.jpg', func('banda_studioQW_strings', 99)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'zz_funcs', 'cum', 'belly'
													gs 'zz_funcs', 'cum', 'lip'
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event4/'+rand(25,26)+'.jpg', func('banda_studioQW_strings', 100)
													act'Одеться': gt 'zz_pornstudio'
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Второй ивент с бандитами после диалога
if $ARGS[0] = 'ofisevent6':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('banda_studioQW_strings', 101)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/1.jpg', func('banda_studioQW_strings', 102)
		act'Далее':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/2.jpg', func('banda_studioQW_strings', 103)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/'+rand(3,4)+'.jpg', func('banda_studioQW_strings', 104)
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/5.jpg', func('banda_studioQW_strings', 105)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/'+rand(6,7)+'.jpg', func('banda_studioQW_strings', 106)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 10
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/8.jpg', func('banda_studioQW_strings', 107)
							act'Далее':
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/9.jpg', func('banda_studioQW_strings', 108)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/10.jpg', func('banda_studioQW_strings', 109)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/11.jpg', func('banda_studioQW_strings', 110)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 50
											bj += 1
											studio['ofisdialog6'] = day
											gs 'zz_funcs', 'cum', 'belly'
											gs 'zz_funcs', 'cum', 'lip'
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event5/12.jpg', func('banda_studioQW_strings', 111)
											act'Уйти': gt 'zz_pornstudio'
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Ивент сбандитами после диалога при красоте больше 60
if $ARGS[0] = 'ofisevent7':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/1.jpg', func('banda_studioQW_strings', 112)
	act'Далее':
		*clr & cla
		minut += 5
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(2,3)+'.jpg', func('banda_studioQW_strings', 113)
		act'Далее':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/4.jpg', func('banda_studioQW_strings', 114)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(5,6)+'.jpg', func('banda_studioQW_strings', 115)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/7.jpg', func('banda_studioQW_strings', 116)
					act'Далее':
						*clr & cla
						minut += 5
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(8,9)+'.jpg', func('banda_studioQW_strings', 117)
						act'Далее':
							*clr & cla
							minut += 5
							horny += 20
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(10,11)+'.jpg', func('banda_studioQW_strings', 118)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 65
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(12,13)+'.jpg', func('banda_studioQW_strings', 119)
								act'Далее':
									*clr & cla
									minut += 5
									horny = 85
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(14,19)+'.jpg', func('banda_studioQW_strings', 120)
									act'Далее':
										*clr & cla
										minut += 5
										orgasm += 1
										DPorgasm += 1
										gang += 1
										bj += 1
										horny = 0
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(20,25)+'.jpg', func('banda_studioQW_strings', 121)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/26.jpg', func('banda_studioQW_strings', 122)
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(27,28)+'.jpg', func('banda_studioQW_strings', 123)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/'+rand(29,30)+'.jpg', func('banda_studioQW_strings', 124)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'zz_funcs', 'cum', 'lip'
														gs 'zz_funcs', 'cum', 'belly'
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event6/31.jpg', func('banda_studioQW_strings', 125)
														act'Одется': gt 'zz_pornstudio'
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Ивент в ванной после отсоса у бандитов
if $ARGS[0] = 'ofisevent8':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/grim/event2/1.jpg', func('banda_studioQW_strings', 126)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(2,3)+'.jpg', func('banda_studioQW_strings', 127)
		act'Далее':
			*clr & cla
			minut += 5
			horny = 60
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(4,5)+'.jpg', func('banda_studioQW_strings', 128)
			act'Далее':
				*clr & cla
				minut += 5
				horny = 65
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(6,7)+'.jpg', func('banda_studioQW_strings', 129)
				act'Далее':
					*clr & cla
					minut += 5
					horny = 75
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(8,9)+'.jpg', func('banda_studioQW_strings', 130)
					act'Далее':
						*clr & cla
						minut += 5
						horny = 90
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(10,11)+'.jpg', func('banda_studioQW_strings', 131)
						act'Далее':
							*clr & cla
							minut += 5
							orgasm += 1
							vaginalOrgasm += 1
							gang += 1
							bj += 1
							horny = 0
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(12,13)+'.jpg', func('banda_studioQW_strings', 132)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 25
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(14,15)+'.jpg', func('banda_studioQW_strings', 133)
								act'Далее':
									*clr & cla
									minut += 5
									horny = 45
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(16,17)+'.jpg', func('banda_studioQW_strings', 134)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 60
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/grim/event2/18.jpg', func('banda_studioQW_strings', 135)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 85
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(19,20)+'.jpg', func('banda_studioQW_strings', 136)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 95
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(21,22)+'.jpg', func('banda_studioQW_strings', 137)
												act'Далее':
													*clr & cla
													minut += 5
													orgasm += 1
													Dporgasm += 1
													horny = 0
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(23,24)+'.jpg', func('banda_studioQW_strings', 138)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/grim/event2/25.jpg', func('banda_studioQW_strings', 139)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/grim/event2/'+rand(26,27)+'.jpg', func('banda_studioQW_strings', 140)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/grim/event2/28.jpg', func('banda_studioQW_strings', 141)
																act'Помыться': gt 'dressing_room'
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Ивент с Стасом в офисе
if $ARGS[0] = 'ofisevent9':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/1.webm', func('banda_studioQW_strings', 142)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/2.webm', func('banda_studioQW_strings', 143)
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/3.webm', func('banda_studioQW_strings', 144)
			act'Как-нибудь потом, может':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', '', func('banda_studioQW_strings', 145)
				act'Работать' :gt 'zz_pornstudio'
			end
			act'Соблазнить':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', '', func('banda_studioQW_strings', 146)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(4,5)+'.webm', func('banda_studioQW_strings', 147)
					act'Далее':
						*clr & cla
						minut += 5
						horny = 50
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(6,7)+'.webm', func('banda_studioQW_strings', 148)
						act'Далее':
							*clr & cla
							minut += 5
							horny = 60
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(8,9)+'.webm', func('banda_studioQW_strings', 149)
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(10,11)+'.webm', func('banda_studioQW_strings', 150)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/12.webm', func('banda_studioQW_strings', 151)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 70
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(13,15)+'.webm', func('banda_studioQW_strings', 152)
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(16,17)+'.webm', func('banda_studioQW_strings', 153)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 80
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(18,19)+'.webm', func('banda_studioQW_strings', 154)
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/20.webm', func('banda_studioQW_strings', 155)
													act'Далее':
														*clr & cla
														minut += 5
														horny = 90
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(21,22)+'.webm', func('banda_studioQW_strings', 156)
														act'Далее':
															*clr & cla
															minut += 5
															horny = 95
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/'+rand(23,24)+'.webm', func('banda_studioQW_strings', 157)
															act'Далее':
																*clr & cla
																minut += 5
																orgasm += 1
																analorgasm += 1
																bj += 1
																anal += 1
																horny = 0
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/25.webm', func('banda_studioQW_strings', 158)
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/26.webm', func('banda_studioQW_strings', 159)
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/27.webm', func('banda_studioQW_strings', 160)
																		act'Далее':
																			*clr & cla
																			minut += 5
																			studio['ofisevent9_day'] = day
																			gs 'zz_funcs', 'cum', 'belly'
																			gs 'stat'
																			gs 'zz_render', '', 'city/north/banda/studio/ofis/event7/28.webm', func('banda_studioQW_strings', 161)
																			act'Работать' :gt 'zz_pornstudio'
																		end
																	end
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!ивент с Геннадием в офисе
if $ARGS[0] = 'ofisevent10':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/1.webm', func('banda_studioQW_strings', 162)
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/2.webm', func('banda_studioQW_strings', 163)
		act'Пофлиртовать и сказать Гене, чтобы потренировал актрисок':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', '', func('banda_studioQW_strings', 164)
			act'Работать' :gt 'zz_pornstudio'
		end
		act'Попросить трахнуть':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/3.webm', func('banda_studioQW_strings', 165)
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(4,6)+'.webm', func('banda_studioQW_strings', 166)
				act'Далее':
					*clr & cla
					minut += 5
					horny = 50
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/7.webm', func('banda_studioQW_strings', 167)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/8.webm', func('banda_studioQW_strings', 168)
						act'Далее':
							*clr & cla
							minut += 5
							horny = 60
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(9,10)+'.webm', func('banda_studioQW_strings', 169)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 75
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(11,12)+'.webm', func('banda_studioQW_strings', 170)
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/13.webm', func('banda_studioQW_strings', 171)
									act'Далее':
										*clr & cla
										minut += 5
										horny = 85
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(14,15)+'.webm', func('banda_studioQW_strings', 172)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 90
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(16,18)+'.webm', func('banda_studioQW_strings', 173)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 95
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(19,20)+'.webm', func('banda_studioQW_strings', 174)
												act'Далее':
													*clr & cla
													minut += 5
													orgasm += 1
													analorgasm += 1
													bj += 1
													anal += 1
													horny = 0
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(21,22)+'.webm', func('banda_studioQW_strings', 175)
													act'Далее':
														*clr & cla
														minut += 5
														horny += 10
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/'+rand(23,24)+'.webm', func('banda_studioQW_strings', 176)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/25.webm', func('banda_studioQW_strings', 177)
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/26.webm', func('banda_studioQW_strings', 178)
																act'Далее':
																	*clr & cla
																	minut += 5
																	sweat = 1
																	studio['ofisevent10_day'] = day
																	gs 'zz_funcs', 'cum', 'lip'
																	gs 'stat'
																	gs 'zz_render', '', 'city/north/banda/studio/ofis/event8/27.webm', func('banda_studioQW_strings', 179)
																	act'Одеться' :gt 'zz_pornstudio'
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!Ивент со Стаосм и Геннадием
if $ARGS[0] = 'ofisevent11':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/1.webm', func('banda_studioQW_strings', 180)
	act'Далее':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/2.webm', func('banda_studioQW_strings', 181)
		act'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/3.webm', func('banda_studioQW_strings', 182)
			act'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(4,5)+'.webm', func('banda_studioQW_strings', 183)
				act'Далее':
					*clr & cla
					minut += 5
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/6.webm', func('banda_studioQW_strings', 184)
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(7,8)+'.webm', func('banda_studioQW_strings', 185)
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/9.webm', func('banda_studioQW_strings', 186)
							act'Далее':
								*clr & cla
								minut += 5
								horny = 50
								gs 'stat'
								gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(10,12)+'.webm', func('banda_studioQW_strings', 187)
								act'Далее':
									*clr & cla
									minut += 5
									horny = 60
									gs 'stat'
									gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(13,14)+'.webm', func('banda_studioQW_strings', 188)
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(15,17)+'.webm', func('banda_studioQW_strings', 189)
										act'Далее':
											*clr & cla
											minut += 5
											horny = 65
											gs 'stat'
											gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(18,19)+'.webm', func('banda_studioQW_strings', 190)
											act'Далее':
												*clr & cla
												minut += 5
												horny = 85
												gs 'stat'
												gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(20,22)+'.webm', func('banda_studioQW_strings', 191)
												act'Далее':
													*clr & cla
													minut += 5
													orgasm += 1
													DPorgasm += 1
													bj += 1
													gang += 1
													horny = 0
													gs 'stat'
													gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(23,25)+'.webm', func('banda_studioQW_strings', 192)
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/26.webm', func('banda_studioQW_strings', 193)
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/27.webm', func('banda_studioQW_strings', 194)
															act'Далее':
																*clr & cla
																minut += 5
																horny += 5
																studio['ofisevent11_day'] = day
																gs 'zz_funcs', 'cum', 'lip'
																gs 'zz_funcs', 'cum', 'face'
																gs 'stat'
																gs 'zz_render', '', 'city/north/banda/studio/ofis/event9/'+rand(28,29)+'.webm', func('banda_studioQW_strings', 195)
																act'Одеться' :gt 'zz_pornstudio'
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end