$metka = $ARGS[0]
$loc = $CURLOC
gs 'stat'
$boy=$bname
dick = rand (15,18)
frost =0
if tanga = 1: Flag_tanga = 1
$din_room_rape_end = {
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex124.jpg', func('placer_sex_strings', 'local_str1')
	Act 'Далее':
		*clr & cla
		if month=12 or month<=2:
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex125.jpg', func('placer_sex_strings', 'local_str2')
		elseif (month>=3 and month<=4) or (month>9 and month<=11):
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex126.jpg', func('placer_sex_strings', 'local_str3')
		elseif month>=5 and month<=9:
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex127.jpg', func('placer_sex_strings', 'local_str4')
		end
		Act 'Одеться':
			*clr & cla
			cumfrot += 1
			nude = 0
			if Flag_tanga = 1: tanga = 1
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex128.jpg', func('placer_sex_strings', 'local_str5')
			Act'Пойти к тропинке в городок': gt 'gLake'
		end
	end
}
$din_room_rape = {
	if dom <= -10 and foto = 0:
		n = rand(1,3)
	else
		n = rand(1,10)
	end
if n = 3:
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex102.gif', func('placer_sex_strings', 'local_str6')
	Act 'Кричать':
		*clr & cla
		nude = 1 & tanga = 0
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex103.jpg', func('placer_sex_strings', 'local_str7')
		Act 'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex104.gif', func('placer_sex_strings', 'local_str8')
			Act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex105.jpg', func('placer_sex_strings', 'local_str9')
				Act 'Далее':
					*clr & cla
					'<center><img src="images/qwest/alter/parc_ev/placer_sex106.jpg"></center>'
					if analplugin = 1: analplugin = 0 & '"Смотри что у этой шлуши в жопе", - с этими словами <<$bname>> выдернул анальныю пробку у вас из попки.'
					gs 'zz_render', '', '', func('placer_sex_strings', 'local_str10')
					Act 'Далее':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex107.jpg', func('placer_sex_strings', 'local_str11')
						if dom > -10:
							Act 'Укусить':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex108.jpg', func('placer_sex_strings', 'local_str12')
								Act 'Далее':
									gs 'zz_funcs', 'cum', 'anus'
									gs'stat'
									*clr & cla
									gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex109.jpg', func('placer_sex_strings', 'local_str13')
									gs 'zz_funcs', 'cum', 'pussy'
									Act 'Далее':
										gs 'zz_funcs', 'cum', 'face'
										gs'stat'
										*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex110.jpg', func('placer_sex_strings', 'local_str14')
										Act 'Далее':
											minut += 60
											manna = 0
											horny = 0
											vagina += 2
											bj += 4
											swallow+= 1
											throat+= 2
											sex+=3
											anal+=2
											guy+=5
											anus+=2
											gs 'zz_funcs', 'cum', 'belly'
											gs 'zz_funcs', 'cum', 'ass'
											gs 'zz_funcs', 'cum', 'lip'
											rape += 1
											vgape = 3
											agape = 3
											gs'stat'
											*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex111.jpg', func('placer_sex_strings', 'local_str15')
											Act'Прийти в себя': dynamic $din_room_rape_end
										end
									end
								end
							end
						else
							Act 'Быть послушной':
								horny += 20
								gs'stat'
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex112.jpg', func('placer_sex_strings', 'local_str16')
								Act 'Далее':
									horny += 20
									gs'stat'
									*clr & cla
									gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex114.jpg', func('placer_sex_strings', 'local_str17')
									Act 'Далее':
										horny += 20
										gs'stat'
										*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex115.jpg', func('placer_sex_strings', 'local_str18')
										Act 'Далее':
											horny += 20
											gs'stat'
											*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex116.jpg', func('placer_sex_strings', 'local_str19')
											Act 'Далее':
												horny = 0
												gs'stat'
												*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex117.jpg', func('placer_sex_strings', 'local_str20')
												Act 'Далее':
													minut += 60
													horny = 0
													manna -= 50
													vagina += 2
													bj += 5
													swallow+= 1
													throat+= 2
													sex+=2
													anal+=2
													guy+=5
													anus+=2
													gs 'zz_funcs', 'cum', 'belly'
													gs 'zz_funcs', 'cum', 'ass'
													gs 'zz_funcs', 'cum', 'anus'
													gs 'zz_funcs', 'cum', 'face'
													gs 'zz_funcs', 'cum', 'lip'
													rape += 1
													orgasm += 2
													vaginalOrgasm += 1
													DPorgasm += 1
													vgape = 3
													agape = 3
													gs 'stat'
													*clr & cla
													gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex118.jpg', func('placer_sex_strings', 'local_str21')
													gs 'zz_funcs', 'cum', 'pussy'
													if Big_C = 0:
														Act 'Далее':
															*clr & cla
															gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex119.jpg', func('placer_sex_strings', 'local_str22')
															Act 'Пойти в душ':
																*clr & cla
																$din_dush_text='Приняв душ, и очень аккуратно вымыв все свои дырочки. Вы стали собиратся. "Большой член" стоял рядом с вами молчаливым охраником, "Посмотри на обратную сторону, и захочешь продолжения разберешся", - добавил он на последок'
																dynamic $din_dush
																Act 'Выйти из квартиры':
																	*clr & cla
																	manna = 0
																	if Flag_tanga = 1: tanga = 1
																	nude = 0 & minut += 10 & gs'stat'
																	Big_C = 1
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex121.jpg', func('placer_sex_strings', 'local_str23')
																	Act 'Положить фотографию в сумочку и пойти домой': VIEW & Foto = 1 & gt'gorodok'
																	Act 'Выбросить фотографию и пойти домой': VIEW & gt'gorodok'
																end
															end
														end
													else
														Act 'Далее':
															*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex111.jpg', func('placer_sex_strings', 'local_str24')
															Act 'Прийти в себя': manna = 0 & dynamic $din_room_rape_end
														end
													end
												end
											end
										end
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
	if Flag_tanga = 1: tanga = 1
	nude = 0 & minut += 10 & gs'stat' & gt'gorodok'
end
}
$din_play_twister = {
minut += 30
horny += 10
manna += 25
gs 'stat'
*clr & cla
gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex94.jpg', func('placer_sex_strings', 'local_str25')
if tanga = 0: 'Во время игры вы постоянно поправляли юбку, пытаясь скрыть что на вас нету трусиков, но похоже вам это не очень удалось, так как <<$bname>> то и дело замирал <a href="exec: VIEW ''images/qwest/alter/parc_ev/placer_sex95.jpg''">пялясь</a> вам под юбку.'
	Act 'Далее':
		horny += 20
		gs'stat'
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex96.jpg', func('placer_sex_strings', 'local_str26')
		Act '<<$bname>> остановись':
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/Ev/otel4.jpg', func('placer_sex_strings', 'local_str27')
			Act 'Собраться и пойти домой': dynamic $din_room_rape
		end
		Act 'Промолчать':
			horny += 20
			gs'stat'
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex97.jpg', func('placer_sex_strings', 'local_str28')
			Act 'Далее':
				nude = 1
				horny += 20
				gs'stat'
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex98.jpg', func('placer_sex_strings', 'local_str29')
				Act 'Далее':
					tanga = 0
					horny += 20
					gs'stat'
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex99.jpg', func('placer_sex_strings', 'local_str30')
					Act 'Далее':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex100.jpg', func('placer_sex_strings', 'local_str31')
						Act 'Далее':
							minut += 30
							horny = 0
							manna += 15
							vagina += 1
							orgasm += 1
							vaginalOrgasm += 1
							guy+=1
							bj += 1
							gs 'zz_funcs', 'cum', 'ass'
							gs'stat'
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex101.jpg', func('placer_sex_strings', 'local_str32')
							Act 'Собраться и пойти домой': nude = 0 & minut += 10 & gs'stat' & gt'gorodok'
						end
					end
				end
			end
		end
	end
}
$din_play_card_sex = {
*clr & cla
nude = 1
horny += 10
gs'stat'
gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex78.jpg', func('placer_sex_strings', 'local_str33')
	Act 'Далее':
		horny += 20
		gs'stat'
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex79.jpg', func('placer_sex_strings', 'local_str34')
		Act 'Далее':
			horny += 20
			tanga = 0
			gs'stat'
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex80.jpg', func('placer_sex_strings', 'local_str35')
			Act 'Далее':
				horny += 20
				gs'stat'
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex81.jpg', func('placer_sex_strings', 'local_str36')
				Act 'Далее':
					bj += 2
					swallow+= 1
					gs 'zz_funcs', 'cum', 'lip'
					throat+= 1
					facial+=1
					guy+=2
					minut += 30
					horny = 0
					manna += 25
					vagina += 1
					orgasm += 1
					vaginalOrgasm += 1
					gs'stat'
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex82.jpg', func('placer_sex_strings', 'local_str37')
					Act 'Далее':
						gs 'zz_funcs', 'cum', 'belly'
						gs'stat'
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex83.jpg', func('placer_sex_strings', 'local_str38')
						Act 'Пойти в душ':
							$din_dush_text='Приняв душ, и тщательно вымыв все свои дырочки. Вы стали собиратся. Выйдя из душа и поцеловав парней на прощанье.'
							dynamic $din_dush
							if Flag_tanga = 1: tanga = 1
							Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
						end
					end
				end
			end
		end
	end
}
$din_play_card_stript = {
*clr & cla
gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex67.jpg', func('placer_sex_strings', 'local_str39')
 Act 'Далее':
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex67.jpg', func('placer_sex_strings', 'local_str40')
	Act 'Далее':
		nude = 1
		horny += 10
		gs'stat'
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex68.jpg', func('placer_sex_strings', 'local_str41')
		Act 'Далее':
			*clr & cla
			'<center><img src="images/qwest/alter/parc_ev/placer_sex69.jpg"></center>'
			stripdance +=1
			if stripdance > 50:
				gs 'zz_render', '', '', func('placer_sex_strings', 'local_str42')
			else
				gs 'zz_render', '', '', func('placer_sex_strings', 'local_str43')
			end
			Act 'Далее':
				tanga = 0
				horny += 10
				gs'stat'
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex70.jpg', func('placer_sex_strings', 'local_str44')
				Act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex71.jpg', func('placer_sex_strings', 'local_str45')
					Act 'Далее':
						if horny < 100:
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex72.jpg', func('placer_sex_strings', 'local_str46')
							Act 'Убежать': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
						elseif vagina > 10 and horny >= 100:
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex73.jpg', func('placer_sex_strings', 'local_str47')
							Act 'Далее':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex74.jpg', func('placer_sex_strings', 'local_str48')
								Act 'Далее':
									minut += 30
									horny = 0
									manna += 15
									orgasm += 1
									gs'stat'
									*clr & cla
									gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex75.jpg', func('placer_sex_strings', 'local_str49')
									Act 'Далее':
										horny += 20
										bj += 2
										swallow+= 1
										throat+= 1
										facial+=1
										guy+=2
										gs'stat'
										*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex76.gif', func('placer_sex_strings', 'local_str50')
										Act 'Пойти в душ':
											$din_dush_text='Приняв душ, и тщательно вымыв все свои дырочки. Вы стали собиратся. Выйдя из душа и поцеловав парней на прощанье.'
											dynamic $din_dush
											if Flag_tanga = 1: tanga = 1
											Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
}
$din_play_card_win = {
*clr & cla
gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex63.jpg', func('placer_sex_strings', 'local_str51')
	Act 'Пойти с ними на улицу':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex'+iif(month > 4 and month < 11,64,65)+'.jpg', func('placer_sex_strings', 'local_str52')
		Act 'Убежать': minut += 10 & gs'stat' & gt'gorodok'
	end
}
$din_play_card = {
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex61.jpg', func('placer_sex_strings', 'local_str53')
	if kol_man > 2: '<<$bname3>>, встал и сказал: "не в карты я пас, даже с такой очаровательной леди", - и вышел из комнаты, вы недоуменно посмотрели на оставшихся парней. А те только махнули рукой и рассказали, что он игроман и боится подходить к картам, чтобы не сорваться.'
	gs 'zz_render', '', '', func('placer_sex_strings', 'local_str54')
	Act 'Играть':
		*clr & cla
		minut += 15
		gs'stat'
		gs 'zz_render', '', '', func('placer_sex_strings', 'local_str55')
		if rand (1,5) = 1:
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex62.jpg', func('placer_sex_strings', 'local_str56')
			Act 'Потребовать выигрыш': dynamic $din_play_card_win
		else
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex66.jpg', func('placer_sex_strings', 'local_str57')
			Act 'Согласится на стриптиз': dynamic $din_play_card_stript
			Act 'Попробовать отыграться':
				*clr & cla
				minut += 15
				gs'stat'
				gs 'zz_render', '', '', func('placer_sex_strings', 'local_str58')
				if rand (1,5) = 1:
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex62.jpg', func('placer_sex_strings', 'local_str59')
					Act 'Потребовать выигрыш': dynamic $din_play_card_win
				else
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex77.jpg', func('placer_sex_strings', 'local_str60')
					Act 'Далее': dynamic $din_play_card_sex
				end
			end
		end
	end
}
$din_play_game = {
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/Ev/otel4.jpg', func('placer_sex_strings', 'local_str61')
	Act 'В карты': dynamic $din_play_card
	Act 'В твистер': dynamic $din_play_twister
	Act 'Пойти домой':  dynamic $din_room_rape
}
$din_stay_in_bed = {
	if rand(1,2) = 1:
		horny += 10
		gs'stat'
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex47.jpg', func('placer_sex_strings', 'local_str62')
		Act 'Облизать':
			horny += 30
			bj += 1
			gs'stat'
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex48.jpg', func('placer_sex_strings', 'local_str63')
			Act 'Сесть сверху ':
				nude = 1
				tanga = 0
				horny += 30
				gs 'stat'
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex49.jpg', func('placer_sex_strings', 'local_str64')
				Act 'Стать раком':
					horny += 30
					gs'stat'
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex50.jpg', func('placer_sex_strings', 'local_str65')
					Act 'Давай в попку':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex51.jpg', func('placer_sex_strings', 'local_str66')
						Act 'Сесть попкой на член':
							*clr & cla
							'<center><img src="images/qwest/alter/parc_ev/placer_sex52.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							Act 'Слезть с члена':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex53.jpg', func('placer_sex_strings', 'local_str67')
								Act 'Пойти в душ':
									$din_dush_text='Приняв душ, и тщательно вымыв все свои дырочки. Вы стали собиратся.'
									dynamic $din_dush
									if Flag_tanga = 1: tanga = 1
									Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
								end
							end
						end
					end
				end
			end
		end
	else
		horny += 10
		gs'stat'
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex54.jpg', func('placer_sex_strings', 'local_str68')
		Act 'Взять в рот':
			nude = 1
			horny += 20
			bj += 1
			gs'stat'
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex55.jpg', func('placer_sex_strings', 'local_str69')
			Act 'Далее':
				tanga = 0
				horny += 20
				gs'stat'
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex56.jpg', func('placer_sex_strings', 'local_str70')
				Act 'Далее':
					horny += 20
					bj += 1
					gs'stat'
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex57.jpg', func('placer_sex_strings', 'local_str71')
					Act 'Далее':
						horny += 20
						gs'stat'
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex58.jpg', func('placer_sex_strings', 'local_str72')
						Act 'Далее':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex59.jpg', func('placer_sex_strings', 'local_str73')
							Act 'Далее':
								minut += 30
								horny = 0
								manna += 25
								vagina += 1
								orgasm += 2
								vaginalOrgasm += 1
								DPorgasm += 1
								anal += 1
								gs 'zz_funcs', 'cum', 'anus'
								gs'stat'
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex60.jpg', func('placer_sex_strings', 'local_str74')
								gs 'zz_funcs', 'cum', 'pussy'
								Act 'Пойти в душ':
									$din_dush_text='Приняв душ, и тщательно вымыв все свои дырочки. Вы стали собиратся. Выйдя из душа и поцеловав парней на прощанье.'
									dynamic $din_dush
									if Flag_tanga = 1: tanga = 1
									Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
								end
							end
						end
					end
				end
			end
		end
	end
}
$din_sleep_sex = {
 *clr & cla
 '<center><img src="images/qwest/alter/parc_ev/placer_sex93.jpg"></center>'
 'Вас что-то выдернула из сна. Чуть, чуть приоткрыв глаза, вы сквозь ресницы увидели в комнате мужской силуэт. Похоже, кто-то из парней решил разнообразить вам сон. Решив посмотреть, что будет дальше, вы притворяетесь спящей.'
 Act 'Далее':
 *clr & cla
 '<center><img src="images/qwest/alter/parc_ev/placer_sex84.jpg"></center>'
 'Этот страдающий «бессонницей» подошел к вам  стянул одеяло и задрал маячку, оголив сиськи. Вы задумались, что делать дальше, или дальше притворятся спящей, или «проснуться» и выгнать нахала к чертям?'
	Act '"Проснуться"':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex85.jpg', func('placer_sex_strings', 'local_str75')
		Act 'Приготовить завтрак': dynamic $din_breakfast
	end
	Act '"Спать дальше"':
		*clr & cla
		horny += 20
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex86.jpg', func('placer_sex_strings', 'local_str76')
		Act 'Далее':
			*clr & cla
			horny += 20
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex92.jpg', func('placer_sex_strings', 'local_str77')
			Act 'Далее':
				horny += 20
				gs'stat'
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex87.jpg', func('placer_sex_strings', 'local_str78')
				Act 'Далее':
					horny += 20
					gs'stat'
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex88.jpg', func('placer_sex_strings', 'local_str79')
					Act 'Далее':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex89.jpg', func('placer_sex_strings', 'local_str80')
						Act 'Далее':
							minut += 20
							horny = 0
							manna += 15
							vagina += 1
							orgasm += 1
							vaginalOrgasm += 1
							bj += 1
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							throat+= 1
							facial+=1
							gs'stat'
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex90.jpg', func('placer_sex_strings', 'local_str81')
							Act 'Далее':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex91.jpg', func('placer_sex_strings', 'local_str82')
								Act 'Приготовить завтрак': dynamic $din_breakfast
							end
						end
					end
				end
			end
		end
	end
end
}
$din_breakfast_sex = {
*clr & cla
nude = 1
gs 'stat'
gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex40.gif', func('placer_sex_strings', 'local_str83')
	Act 'Приспустить трусики':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex37.jpg', func('placer_sex_strings', 'local_str84')
		Act 'Подойти к парню':
			*clr & cla
			tanga = 0
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex41.jpg', func('placer_sex_strings', 'local_str85')
			Act'Стать раком':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex42.jpg', func('placer_sex_strings', 'local_str86')
				Act'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex43.jpg', func('placer_sex_strings', 'local_str87')
					Act 'Далее':
						minut += 30
						horny = 0
						manna += 15
						sex+=1
						orgasm += 1
						vaginalOrgasm += 1
						gs'stat'
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex44.jpg', func('placer_sex_strings', 'local_str88')
						Act 'Далее':
							horny += 30
							gs 'zz_funcs', 'cum', 'belly'
							gs'stat'
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex45.jpg', func('placer_sex_strings', 'local_str89')
							Act 'Далее':
								*clr & cla
								cumbelly =0
								gs'stat'
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex46.jpg', func('placer_sex_strings', 'local_str90')
								if Flag_tanga = 1: tanga = 1
								Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
							end
						end
					end
				end
			end
		end
	end
}
$din_breakfast = {
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex36.jpg', func('placer_sex_strings', 'local_str91')
	Act 'Снять лифчик': dynamic $din_breakfast_sex
	Act 'Показать язык':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex38.jpg', func('placer_sex_strings', 'local_str92')
		Act 'Завтракать':
			*clr & cla
			minut += 30
			body['day_weight'] += 1
			energy += 15
			water += 15
			cumlip = 0
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex39.jpg', func('placer_sex_strings', 'local_str93')
			Act 'Собраться и пойти домой': nude = 0 & minut += 10 & gs'stat' & gt'gorodok'
		end
	end
}
$din_stay_the_night = {
	*clr & cla
	if hour <= 22:
		hour = 23
		minut = 0
	end
	gs'stat'
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex29.jpg', func('placer_sex_strings', 'local_str94')
	Act 'Лечь спать':
		dynamic $din_sleep
		Act 'Приготовить завтрак': dynamic $din_breakfast
		Act 'Поваляться в постели': dynamic $din_stay_in_bed
		if rand (1,6)=1: delAct 'Приготовить завтрак' & delAct 'Поваляться в постели' & dynamic $din_sleep_sex
	end
}
$din_drink_vodca2 = {
	*clr & cla
	cumlip = 0
	gs'stat'
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex25.gif', func('placer_sex_strings', 'local_str95')
	Act 'Замереть':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex25.jpg', func('placer_sex_strings', 'local_str96')
		Act 'Крутить попкой':
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex26.gif', func('placer_sex_strings', 'local_str97')
			Act 'Соскочить с члена':
				*clr & cla
				horny = 50
				manna += 5
				sex += 1
				guy += 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex27.gif', func('placer_sex_strings', 'local_str98')
				gs 'zz_funcs', 'cum', 'pussy'
				if kol_man = 2:
					Act 'Сходить в душ':
						$din_dush_text='Ладно я в душ, пойду вымывать вашу сперму из своей письки. Ребята проводили вас до душа, показав что где лежит. Вы помылись, и тщательно вымыли все из себя, с мыслями о том что, лишь бы пронесло и вы не залетели. Во время секса об этом как-то не думалось.'
						dynamic $din_dush
						Act 'Выйти из душа':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex28.jpg', func('placer_sex_strings', 'local_str99')
							if Flag_tanga = 1: tanga = 1
							Act 'Собраться и пойти домой': nude = 0 & minut += 30 & gs'stat' & gt'gorodok'
							Act 'Остаться с парнями': dynamic $din_stay_the_night
						end
					end
				else
					Act 'Пойти с третим парнем':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex31.jpg', func('placer_sex_strings', 'local_str100')
						Act 'Далее':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex32.jpg', func('placer_sex_strings', 'local_str101')
							Act 'Далее':
								horny = 0
								manna += 15
								vagina += 1
								orgasm += 1
								vaginalOrgasm += 1
								sex += 1
								guy += 1
								gs'stat'
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex33.jpg', func('placer_sex_strings', 'local_str102')
								gs 'zz_funcs', 'cum', 'pussy'
								Act 'Задрать ноги':
									*clr & cla
									gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex34.jpg', func('placer_sex_strings', 'local_str103')
									Act 'Сходить в душ':
										$din_dush_text='Ладно я в душ, пойду вымывать вашу сперму из своей письки. Ребята проводили вас до душа, показав что где лежит. Вы помылись, и тщательно вымыли все из себя, с мыслями о том что, лишь бы пронесло и вы не залетели. Во время секса об этом как-то не думалось.'
										dynamic $din_dush
										Act 'Выйти из душа':
											*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex28.jpg', func('placer_sex_strings', 'local_str104')
											if (week >= 1 and week < 5) or week = 7: '"Не вы что мне завтра в школу, какой остаться. Может в другой раз", - немного с сожалением сказали вы.'
											if week = 5 or week = 6 :
										gs 'zz_render', '', '', func('placer_sex_strings', 'local_str105')
												Act 'Остаться с парнями': dynamic $din_stay_the_night
											end
											if Flag_tanga = 1: tanga = 1
											Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
}
$din_dush  = {
	*clr & cla
	gs 'zz_bathroom', 'clean_me'
	minut += 15
	horny += 1
	gs'stat'
	gs 'zz_render', '', 'images/pics/dush.jpg', func('placer_sex_strings', 'local_str106')
	$din_dush_text=''
}
$din_analplugin_off = {
	minut += 5
	analpluginbonus = 10
	analplugin = 0
	gs'stat'
	*clr
	'<center><img src="images/qwest/alter/parc_ev/placer_sex16.gif"></center>'
}
$din_drink_vodca = {
	*clr & cla
	gs 'zz_funcs', 'alko', rand(0,5)
	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex2.jpg', func('placer_sex_strings', 'local_str107')
	if tanga = 0: tanga = 1 & clrbelo -= 1 & '"Подожди чуть-чуть", - вы быстро сбегали в туалет и надели на себя <a href="exec: VIEW ''images/qwest/alter/parc_ev/placer_sex129.jpg''">трусики</a>, чтобы не сверкать пиздой, перед незнакомыми парнями.'
	act 'Выпить еще':
		*clr & cla
		gs 'zz_funcs', 'alko', rand(0,5)
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex3.jpg', func('placer_sex_strings', 'local_str108')
		Act 'Сидеть дальше':
			minut += 20
			gs'stat'
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex4.jpg', func('placer_sex_strings', 'local_str109')
			if alko > 5 or horny => 80:
				Act 'Пьянно улыбаться':
					*clr & cla
					nude = 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex5.jpg', func('placer_sex_strings', 'local_str110')
					Act 'Выставить попку':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex7.jpg', func('placer_sex_strings', 'local_str111')
						Act 'Смотреть':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex8.jpg', func('placer_sex_strings', 'local_str112')
							Act 'Взять в рот':
								horny +=30
								bj += 1
								guy += 1
								gs'stat'
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex9.jpg', func('placer_sex_strings', 'local_str113')
								if throat>10:
									Act 'Заглотить':
									*clr & cla
									gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex10.jpg', func('placer_sex_strings', 'local_str114')
										Act 'Глотать':
											swallow+= 1
											gs 'zz_funcs', 'cum', 'lip'
											throat+= 1
											gs'stat'
											*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex11.gif', func('placer_sex_strings', 'local_str115')
											Act 'Умыться': dynamic $din_drink_vodca2
										end
									end
								end
								Act 'Снять трусики':
								tanga = 0
								gs'stat'
								*clr & cla
								gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex12.gif', func('placer_sex_strings', 'local_str116')
									if analplugin = 1:
										Act 'Позволить вытащить пробку':
											delAct 'Позволить вытащить пробку'
											dynamic $din_analplugin_off
										gs 'zz_render', '', '', func('placer_sex_strings', 'local_str117')
										end
									end
									Act 'Стонать':
										sex +=1
										minut += 30
										gs'stat'
										*clr & cla
										if analplugin = 1: analplugin = 0
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex13.jpg', func('placer_sex_strings', 'local_str118')
										Act 'Перевернуться':
											*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex14.jpg', func('placer_sex_strings', 'local_str119')
											if guy > 30:
												minut += 30
												gs'stat'
												Act 'Позвать':
													*clr & cla
													gs 'zz_render', '', '', func('placer_sex_strings', 'local_str120')
													if kol_man = 2:
														gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex17.jpg', func('placer_sex_strings', 'local_str121')
														if analpluginbonus = 10:
															Act 'Далее':
																*clr & cla
																gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex18.jpg', func('placer_sex_strings', 'local_str122')
																Act 'Кричать':
																	guy += 1
																	bj += 1
																	horny = 0
																	manna += 25
																	vagina += 1
																	orgasm += 2
																	vaginalOrgasm += 1
																	DPorgasm += 1
																	anal += 1
																	gs 'zz_funcs', 'cum', 'anus'
																	anus+=1
																	gs'stat'
																	*clr & cla
																	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex19.gif', func('placer_sex_strings', 'local_str123')
																	gs 'zz_funcs', 'cum', 'pussy'
																	Act 'Попробовать подняться':
																		*clr & cla
																		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex20.jpg', func('placer_sex_strings', 'local_str124')
																		act 'Сходить в душ':
																			$din_dush_text='"Я в душ, и домой", - парни только обессилено кивнули. На трясущихся ногах вы  доползли до душа, вымыли свои дырочки. кое-как собрались, и пошли домой. '
																			dynamic $din_dush
																			if Flag_tanga = 1: tanga = 1
																			Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
																		end
																	end
																end
															end
														else
															Act 'Далее':
																*clr & cla
																gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex21.gif', func('placer_sex_strings', 'local_str125')
																Act 'Далее':
																	*clr & cla
																	gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex22.gif', func('placer_sex_strings', 'local_str126')
																	Act 'Далее':
																		guy += 1
																		bj += 1
																		horny = 0
																		manna += 25
																		vagina += 1
																		orgasm += 2
																		vaginalOrgasm += 1
																		gs'stat'
																		*clr & cla
																		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex15.gif', func('placer_sex_strings', 'local_str127')
																		gs 'zz_funcs', 'cum', 'pussy'
																		act 'Сходить в душ':
																			$din_dush_text='"Я в душ, и домой", - парни только обессилено кивнули. На трясущихся ногах вы  доползли до душа, помылись. кое-как собрались, и пошли домой. '
																			dynamic $din_dush
																			if Flag_tanga = 1: tanga = 1
																			Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
																		end
																	end
																end
															end
														end
													elseif kol_man = 3 and analpluginbonus = 10 and vagina => 15 :
														gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex23.jpg', func('placer_sex_strings', 'local_str128')
														Act 'Далее':
															guy += 2
															bj += 2
															horny = 0
															manna += 25
															vagina += 1
															orgasm += 2
															vaginalOrgasm += 1
															DPorgasm += 1
															anal += 1
															anus += 1
															gs 'zz_funcs', 'cum', 'anus'
															swallow += 1
															throat += 1
															gs'stat'
															*clr & cla
															gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex24.gif', func('placer_sex_strings', 'local_str129')
															gs 'zz_funcs', 'cum', 'pussy'
															Act 'Прийти в себя':
																*clr & cla
																gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex20.jpg', func('placer_sex_strings', 'local_str130')
																act 'Сходить в душ':
																	$din_dush_text='"Я в душ, и домой", - парни только обессилено кивнули. На трясущихся ногах вы  доползли до душа, вымыли свои дырочки. кое-как собрались, и пошли домой. '
																	dynamic $din_dush
																	if Flag_tanga = 1: tanga = 1
																	Act 'Собраться и пойти домой': nude = 0  & minut += 10 & gs'stat' & gt'gorodok'
																end
															end
														end
													else
														horny = 0
														manna += 15
														vagina += 1
														orgasm += 1
														vaginalOrgasm += 1
														gs'stat'
														gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex15.gif', func('placer_sex_strings', 'local_str131')
														gs 'zz_funcs', 'cum', 'pussy'
														act 'Следующий': dynamic $din_drink_vodca2
													end
												end
											else
												Act 'Не звать':
													horny = 0
													manna += 15
													vagina += 1
													orgasm += 1
													vaginalOrgasm += 1
													gs'stat'
													*clr & cla
													gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex15.gif', func('placer_sex_strings', 'local_str132')
													gs 'zz_funcs', 'cum', 'pussy'
													act 'Следующий': dynamic $din_drink_vodca2
												end
											end
										end
									end
								end
							end
						end
					end
				end
				act 'Убрать его руку':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex6.jpg', func('placer_sex_strings', 'local_str133')
					Act 'Отказатся': dynamic $din_play_game
				end
			else
				act 'Убрать его руку':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex6.jpg', func('placer_sex_strings', 'local_str134')
					Act 'Отказатся': dynamic $din_play_game
				end
			end
		end
	end
	act 'Отказатся': dynamic $din_play_game
}
$din_sleep = {
	if disable_autosave = 0: SAVEGAME 'autosave.sav'
	*clr & cla
	notathomesleep += 1
	health += 5
	InSleep = 1
	if Flag_tanga = 1: tanga = 1
	:loopson
	minut += 30
	stime += 30
	if stime = 60: stime = 0 & son += 3
	*clr & cla
	gs'stat'
	'<center><img src="images/qwest/alter/parc_ev/placer_sex35.jpg"></center>'
	if analplugIN = 1: analplugIN = 0 & 'Перед сном вы вынули анальную пробку.'
	if vibratorIN = 1: vibratorIN = 0 & 'Перед сном вы вынули вибратор.'
	if mop > 1: mop = 0 & vidageday -= 1 & 'Косметика размазалась по лицу, вы подумали, что вредно для внешности спать с косметикой, кожа стареет быстрее от этого.'
	gs 'zz_render', '', '', func('placer_sex_strings', 'local_str135')
	if son > 23 and dosip = 0:
		nude = 0
		hour = 8
		minut = 0
		gs'stat'
		gs 'zz_render', '', '', func('placer_sex_strings', 'local_str136')
		exit
	end
	jump 'loopson'
}
if kol_man < 4 and anus > 14 and vagina > 14 and mesec <= 0 :
		*clr & cla
		minut += 30
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/parc_ev/placer_sex1.jpg', func('placer_sex_strings', 'local_str137')
		Act 'Выпить с парнями': dynamic $din_drink_vodca
		Act 'Отказаться пить':dynamic $din_play_game
else
	*clr & cla
	gs 'zz_funcs', 'alko', 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/drunk.jpg', func('placer_sex_strings', 'local_str138')
	if dormrape = 0:
		gs 'zz_render', '', '', func('placer_sex_strings', 'local_str139')
		act 'Далее':
			rape += 1
			gang += 1
			dormrape += 1
			minut += 5
			silavag = 0
			$boy = 'Парень'
			guy += kol_man
			ciklkm = kol_man
			if dormrapeQW = 0:dormrapeQW = 1
			gt $curloc
		end
	elseif dormrape = 1:
		'<center><img src="images/nigma/gor/orgy1,'+rand(0,4)+'.gif"></center>'
		:markdormrape
		ciklkm -= 1
		minut += 15
		pose = 0
		dick = RAND(12,20)
		if RAND(0,2) < 2:
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
		else
			gs 'zz_dynamic_sex', 'anal', 'dick'
			gs 'zz_dynamic_sex', 'anal_cum'
		end
		if ciklkm > 0:'Затем место между ваших ног занял следующий парень.'
		if ciklkm > 0 and cumbelly >= 5:cumbelly -= 4 & cumfrot += 4 & 'Один из парней начал возмущаться "Бля, пацаны, вы чо как эту шалаву заструхали? К ей же подойти стремно! Короче дайте ее шмотки, я хоть ей пиздень протру" Вы почувствовали как вам вытирают живот и натруженное влагалище какой-то тканью.'
		gs'stat'
		if ciklkm > 0:jump'markdormrape'
		if RAND(0,1) = 0:
			gs 'zz_render', '', '', func('placer_sex_strings', 'local_str140')
			act 'Уйти': podvalrape = 0 & dormrape = 0 & gt'gorodok'
		else
			act 'Очухаться':
				cla
				*clr & cla
				minut += 5
				body_write = 5
				face_write = 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/placer/podvalwrite'+RAND(1,6)+'.jpg', func('placer_sex_strings', 'local_str141')
				act 'Уйти':podvalrape = 0 & dormrape = 0 & gt'gorodok'
			end
		end
	end
end