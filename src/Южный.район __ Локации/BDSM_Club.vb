$metka = $ARGS[0]
$loc = $CURLOC
if $ARGS[0] = 'start':
	*clr & cla
	minut += 20
	gs 'stat'
	gs 'zz_render','','images/BDSM_Club/Club.jpg'
	if BDSMmeet < 5:
		if subdom = 1:
			$BDSMrole = 'r'
			gs 'zz_render','','',func('BDSM_Club_strings','local_str1')
			act 'Идти за охранником':gt 'BDSM_Club','in'
		end
	else
		if subdom = 1:
			if daystart < bdsmday and bdsmclose = 1:
				gs 'zz_render','','',func('BDSM_Club_strings', 'local_str2')
				act 'Уйти': minut += 15 & gt 'south'
			elseif daystart >= bdsmday and bdsmclose = 1:
				bdsmclose = 0
				gs 'zz_render', '', '', func('BDSM_Club_strings', 'local_str3')
				act 'Уйти': minut += 15 & gt 'south'
			elseif bdsmday ! daystart and hour >= 20 and week = 6:
				gs 'zz_render', '', '', func('BDSM_Club_strings', 'local_str4')
				act 'Идти за охранником': bdsmday = daystart & gt 'BDSM_Club','in'
			else
				gs 'zz_render', '', '', func('BDSM_Club_strings', 'local_str5')
				act 'Уйти': bdsmday = daystart & minut += 15 & gt 'south'
			end
		end
	end
end
if $ARGS[0] = 'in':
	if subdom = 1:
		if BDSMmeet = 0:
			*clr & cla
			dom -= 1
			minut += 20
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/1_1.jpg',func('BDSM_Club_strings', 'local_str6')
			act 'Встать':
				*clr & cla
				dom -= 1
				minut += 10
				gs 'stat'
				gs 'zz_render','','images/BDSM_Club/r1_2.jpg',func('BDSM_Club_strings', 'local_str7')
				act 'Выйти': BDSMmeet = 2 & minut += 15 & gt 'south'
			end
		end
		if BDSMmeet = 2:
			*clr & cla
			minut += 10
			dom -= 5
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_1.jpg',func('BDSM_Club_strings','local_str8')
			act 'Отпрянуть':
				*clr & cla
				minut += 10
				horny += 5
				gs 'stat'
				gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_2.jpg',func('BDSM_Club_strings', 'local_str9')
				act 'Выполнить':
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_3.jpg',func('BDSM_Club_strings', 'local_str10')
					act 'Слушать':
						*clr & cla
						minut += 10
						horny += 5
						gs 'stat'
						gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_4.jpg',func('BDSM_Club_strings', 'local_str11')
						act 'Да, госпожа!':
							*clr & cla
							minut += 10
							horny += 15
							gs 'stat'
							gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings', 'local_str12')
							act 'Далее':
								*clr & cla
								minut += 10
								horny += 15
								gs 'stat'
								gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_6.jpg',func('BDSM_Club_strings', 'local_str13')
								act 'Да, госпожа! Да, госпожа!':
									*clr & cla
									minut += 10
									horny += 15
									gs 'stat'
									gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_7.jpg',func('BDSM_Club_strings', 'local_str14')
									act 'Наслаждаться':
										*clr & cla
										minut += 10
										if horny < 100: horny = 100
										gs 'stat'
										gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_8.jpg',func('BDSM_Club_strings', 'local_str15')
										$BDSMend = {
											act 'Далее':
												*clr & cla
												minut += 10
												horny += 5
												gs 'stat'
												gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_10.jpg',func('BDSM_Club_strings', 'local_str16')
												act 'Выйти':BDSMmeet = 3 & minut += 15 & gt 'south'
											end
										}
										act 'Схитрить и кончить':
											*clr & cla
											minut += 10
											horny = 10
											manna += 25
											orgasm += 1
											gs 'stat'
											gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_9.jpg',func('BDSM_Club_strings','local_str17')
											dynamic $BDSMend
										end
										act 'Сдерживаться':
											*clr & cla
											minut += 10
											if horny < 100: horny = 100
											gs 'stat'
											gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_8.jpg',func('BDSM_Club_strings', 'local_str18')
											dynamic $BDSMend
										end
									end
								end
							end
						end
					end
				end
			end
		end
		if BDSMmeet = 3:
			minut += 10
			horny += 5
			dom -= 5
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_1.jpg',func('BDSM_Club_strings','local_str19')
			act 'Раздеться':
				*clr & cla
				minut += 10
				gs 'stat'
				gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_2.jpg',func('BDSM_Club_strings', 'local_str20')
				act 'Терпеть':
					*clr & cla
					minut += 10
					horny += 5
					spank += 1
					sweat += 1
					spanked += 75
					gs 'stat'
					gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_3.jpg',func('BDSM_Club_strings', 'local_str21')
					act 'Далее':
						*clr & cla
						minut += 10
						horny += 10
						gs 'stat'
						gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_4.jpg',func('BDSM_Club_strings','local_str22')
						act 'Далее':
							*clr & cla
							minut += 10
							if horny < 90: horny = 90
							gs 'stat'
							gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings','local_str23')
							act 'Далее':
								*clr & cla
								minut += 10
								horny += 5
								gs 'stat'
								gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_6.jpg',func('BDSM_Club_strings', 'local_str24')
								act 'Далее':
									*clr & cla
									minut += 10
									horny += 5
									gs 'stat'
									gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_7.jpg',func('BDSM_Club_strings','local_str25')
									act 'Далее':
										*clr & cla
										minut += 10
										horny += 5
										vagina += 1
										lesbian += 1
										gs 'stat'
										gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_8.jpg',func('BDSM_Club_strings', 'local_str26')
										act 'Стонать':
											*clr & cla
											minut += 10
											horny += 5
											gs 'stat'
											gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_9.jpg',func('BDSM_Club_strings','local_str27')
											act 'Далее':
												*clr & cla
												minut += 10
												horny += 5
												gs 'stat'
												gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_10.jpg',func('BDSM_Club_strings', 'local_str28')
												act 'Далее':
													*clr & cla
													minut += 10
													horny += 5
													gs 'stat'
													gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_11.jpg',func('BDSM_Club_strings','local_str29')
													act 'Стонать':
														*clr & cla
														minut += 10
														horny += 5
														gs 'stat'
														gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_12.jpg',func('BDSM_Club_strings','local_str30')
														act 'Целовать':
															*clr & cla
															minut += 10
															horny = 0
															orgasm += 2
															manna += 10
															gs 'zz_funcs','set_gape','anus'
															gs 'stat'
															gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_13.jpg',func('BDSM_Club_strings', 'local_str31')
															act 'Далее':
																*clr & cla
																minut += 10
																gs 'stat'
																gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_14.jpg',func('BDSM_Club_strings','local_str32')
																act 'Далее':
																	*clr & cla
																	minut += 10
																	horny += 15
																	gs 'zz_funcs','set_gape','vagina',horny
																	gs 'stat'
																	gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_15.jpg',func('BDSM_Club_strings','local_str33')
																	act 'Выйти':BDSMmeet = 4 & minut += 15 & gt 'south'
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
		if BDSMmeet = 4:
			minut += 10
			horny += 10
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_1.jpg',func('BDSM_Club_strings', 'local_str34')
			act 'Залезть':
				*clr & cla
				minut += 10
				horny += 10
				gs 'stat'
				gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_2.jpg',func('BDSM_Club_strings', 'local_str35')
				act 'Далее':
					*clr & cla
					minut += 10
					horny += 15
					gs 'stat'
					gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_3.jpg',func('BDSM_Club_strings', 'local_str36')
					act 'Далее':
						*clr & cla
						minut += 10
						horny += 15
						gs 'stat'
						gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_4.jpg',func('BDSM_Club_strings', 'local_str37')
						act 'Отвечать на вопросы':
							*clr & cla
							minut += 10
							horny += 15
							gs 'stat'
							gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings', 'local_str38')
							act 'Сдерживаться':
								*clr & cla
								minut += 10
								horny += 15
								gs 'stat'
								gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_6.jpg',func('BDSM_Club_strings', 'local_str39')
								act 'Далее':
									*clr & cla
									minut += 10
									horny += 5
									bj += 1
									guy += 1
									gs 'stat'
									gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_7.jpg',func('BDSM_Club_strings','local_str40')
									act 'Далее':
										*clr & cla
										minut += 10
										horny += 5
										sex += 1
										gs 'stat'
										gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_8.jpg',func('BDSM_Club_strings', 'local_str41')
										act 'Далее':
											*clr & cla
											minut += 10
											horny += 5
											gs 'stat'
											gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_9.jpg',func('BDSM_Club_strings','local_str42')
											act 'Далее':
												*clr & cla
												minut += 10
												gs 'zz_funcs','set_gape','vagina',horny
												horny = 0
												manna += 25
												orgasm += 1
												gs 'stat'
												gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_10.jpg',func('BDSM_Club_strings', 'local_str43')
												act 'Далее':
													*clr & cla
													minut += 10
													gs 'stat'
													gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_11.jpg',func('BDSM_Club_strings','local_str44')
													act 'Выйти':BDSMmeet = 5 & minut += 15 & gt 'south'
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
		if BDSMmeet = 5:
			minut += 10
			horny += 10
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_1.jpg',func('BDSM_Club_strings','local_str45')
			act 'Идти за ним':
				*clr & cla
				minut += 10
				horny += 10
				gs 'stat'
				gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_2.jpg',func('BDSM_Club_strings','local_str46')
				act 'Далее':
					*clr & cla
					minut += 5
					horny += 10
					gs 'stat'
					gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_3.jpg',func('BDSM_Club_strings','local_str47')
					act 'Далее':
						*clr & cla
						minut += 10
						horny += 10
						gs 'stat'
						gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_4.jpg',func('BDSM_Club_strings','local_str48')
						act 'Взять графин':
							*clr & cla
							minut += 10
							horny += 10
							gs 'stat'
							gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings','local_str49')
							act 'Обслужить':
								*clr & cla
								minut += 10
								horny += 20
								gs 'zz_funcs', 'cum', 'lip'
								swallow += 1
								bj += 1
								guy += 1
								gs 'stat'
								gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_6.jpg',func('BDSM_Club_strings','local_str50')
								act 'Подойти':
									*clr & cla
									minut += 10
									horny += 20
									girl += 1
									gs 'stat'
									gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_7.jpg',func('BDSM_Club_strings','local_str51')
									act 'Идти':
										*clr & cla
										minut += 15
										horny += 20
										guy += 1
										girl += 1
										gs 'zz_funcs', 'cum', 'lip'
										swallow += 1
										gs 'stat'
										gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_8.jpg',func('BDSM_Club_strings','local_str52')
										act 'Далее':
											*clr & cla
											minut += 15
											horny = 100
											gs 'stat'
											gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_9.jpg',func('BDSM_Club_strings','local_str53')
											act 'Далее':
												*clr & cla
												minut += 15
												gs 'stat'
												gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_10.jpg',func('BDSM_Club_strings','local_str54')
												act 'Далее':
													*clr & cla
													minut += 10
													orgasm += 1
													horny = 0
													if manna < 50: manna = 50
													gs 'stat'
													gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_11.jpg',func('BDSM_Club_strings','local_str55')
													act 'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_12.jpg',func('BDSM_Club_strings','local_str56')
														act 'Далее':
															*clr & cla
															minut += 10
															horny += 20
															lesbian += 1
															gs 'stat'
															gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_13.jpg',func('BDSM_Club_strings', 'local_str57')
															act 'Сосать':
																*clr & cla
																minut += 20
																horny += 50
																gs 'zz_funcs','set_gape','anus'
																guy += 2
																anal += 1
																gs 'zz_funcs', 'cum', 'anus'
																bj += 1
																gs 'zz_funcs', 'cum', 'lip'
																swallow += 1
																gs 'stat'
																gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_14.jpg',func('BDSM_Club_strings','local_str58')
																act 'Далее':
																	*clr & cla
																	gs 'zz_funcs','set_gape','vagina',horny
																	minut += 10
																	horny = 0
																	sex += 1
																	gang += 1
																	orgasm += 1
																	vaginalOrgasm += 1
																	guy += 1
																	gs 'stat'
																	gs 'zz_render', '', 'images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_15.jpg',func('BDSM_Club_strings','local_str59')
																	gs 'zz_funcs', 'cum', 'pussy'
																	act 'Далее':
																		*clr & cla
																		minut += 30
																		bj += 1
																		guy += 1
																		sweat = -3
																		mop = 1
																		hapri = 0
																		money += 45000
																		bdmistmoney = daystart + 4
																		gs 'zz_bathroom', 'clean_me'
																		gs 'stat'
																		gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_16.jpg',func('BDSM_Club_strings','local_str60')
																		act 'Выйти':BDSMmeet = 6 & paytomistress = 1 & minut += 15 & gt 'south'
																	end
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
		if BDSMmeet >= 6:BDSMmeet = RAND(6,7)
		if BDSMmeet = 6:
			minut += 20
			horny += 20
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_1.jpg',func('BDSM_Club_strings','local_str61')
			act 'Далее':
				*clr & cla
				minut += 20
				horny += 40
				temp = RAND(0,2)
				gang += 1
				if temp = 1: guy += 1
				orgasm += 1
				if temp = 0:
					anal += 1
					gs 'zz_funcs','cum','anus'
					gs 'zz_funcs','set_gape','anus'
					horny = 0
					orgasm += 1
					analorgasm += 1
				else
					gs 'zz_funcs','set_gape','vagina',horny
					sex += 1
					horny = 0
					vaginalOrgasm += 1
				end
				gs 'stat'
				gs 'zz_render', '', 'images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_2.jpg', func('BDSM_Club_strings', 'local_str62')
				if temp ! 0: gs 'zz_funcs','cum','pussy'
				if horny >= 100: 'Вы не выдерживаете и громко кончаете под редкие аплодисменты наблюдающих зрителей.'
				act 'Далее':
					*clr & cla
					minut += 10
					horny += 20
					gs 'stat'
					gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_3.jpg',func('BDSM_Club_strings','local_str63')
					act 'Далее':
						*clr & cla
						minut += 15
						horny += 20
						temp = RAND(0,2)
						bj += 1
						gs 'zz_funcs', 'cum', 'lip'
						swallow += 1
						if temp = 1:guy += 1
						gs 'stat'
						gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_4.jpg',func('BDSM_Club_strings','local_str64')
						act 'Далее':
							*clr & cla
							temp = RAND(0,2)
							minut += 20
							horny += 40
							if temp = 1:guy += 1
							if temp = 0:
								sex += 1
								gs 'zz_funcs','set_gape','vagina',horny
							end
							gs 'stat'
							if temp = 0:
								gs 'zz_render','','BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings','local_str65')
								gs 'zz_funcs','cum','pussy'
							else
								gs 'zz_render','','BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings','local_str66')
							end
							act 'Выйти':money += 45000 & paytomistress = 1 & minut += 15 & gt 'south'
						end
					end
				end
			end
		end
		if BDSMmeet = 7:
			minut += 15
			horny += 10
			gs 'stat'
			gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_1.jpg',func('BDSM_Club_strings','local_str67')
			act 'Стоять на коленях':
				*clr & cla
				minut += 5
				horny += 20
				dom -= 2
				gs 'stat'
				gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_2.jpg',func('BDSM_Club_strings','local_str68')
				act 'Стонать':
					*clr & cla
					minut += 10
					horny += 10
					spank += 1
					sweat += 1
					spanked += 20
					if bdsmcouple = 1:temp = RAND(0,2)
					gs 'stat'
					gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_3.jpg',func('BDSM_Club_strings','local_str69')
					act 'Наслаждаться':
						*clr & cla
						minut += 10
						sex += 1
						bj += 1
						lesbian += 1
						if bdsmcouple = 0:guy += 1 & girl += 1 & bdsmcouple = 1
						if temp = 1: guy += 1 & girl += 1
						horny += 20
						gs 'zz_funcs','set_gape','vagina',horny
						gs 'stat'
						gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_4.jpg',func('BDSM_Club_strings','local_str70')
						if horny >= 100:'Вы настолько возбуждены, что уже через пару минут вас накрыло мощным оргазмом.'
						act 'Сосать':
							*clr & cla
							if horny >= 100:horny = 0 & orgasm += 1 & vaginalOrgasm += 1
							minut += 10
							horny += 30
							anal += 1
							gs 'stat'
							gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_5.jpg',func('BDSM_Club_strings','local_str71')
							act 'Терпеть':
								*clr & cla
								minut += 5
								sweat += 1
								gs 'zz_funcs','set_gape','anus'
								gs 'zz_funcs','set_gape','vagina',horny
								gs 'stat'
								gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_6.jpg',func('BDSM_Club_strings','local_str72')
								if horny >= 100:'Вы настолько возбуждены, что уже через пару минут вас накрыло мощным оргазмом.'
								act 'Подмахивать':
									*clr & cla
									if horny >= 100:horny = 0 & orgasm += 1 & vaginalOrgasm += 1
									minut += 5
									spank += 1
									sweat += 1
									spanked += 20
									horny += RAND(10,30)
									gs 'stat'
									gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_7.jpg',func('BDSM_Club_strings','local_str73')
									act 'Терпеть':
										*clr & cla
										minut += 5
										horny += 20
										gs 'stat'
										gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_8.jpg',func('BDSM_Club_strings','local_str74')
										if horny >= 100:'Но именно от этого безумного движения вы и кончили, крича и содрогаясь в конвульсиях нахлынувшего оргазма.'
										act 'Терпеть':
											*clr & cla
											if horny >= 100: horny = 0 & orgasm += 1 & vaginalOrgasm += 1
											minut += 10
											swallow += 1
											gs 'zz_funcs', 'cum', 'lip'
											gs 'stat'
											gs 'zz_render','','images/BDSM_Club/<<$BDSMrole>>' + BDSMmeet + '_9.jpg',func('BDSM_Club_strings','local_str75')
											act 'Выйти':money += 45000 & paytomistress = 1 & minut += 15 & gt 'south'
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end