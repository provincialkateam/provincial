if vibrator = 1 or dildo = 1 or middildo = 1 or largedildo = 1 or bigdildo = 1 or extradildo = 1 or superdildo = 1 or maddildo = 1:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFC_strings', 'local_str1')
	if vagina = 0:
		act 'Расстаться с девственностью перед <<camclients>> людьми':
			*clr & cla
			mfcclients = 0
			webpopular += 10
			if webpopular < 15:
				tokens += RAND(100,300)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(200,500)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(500,1500)
			elseif webpopular >= 75:
				tokens += RAND(1000,5000)
			end
			dom -= 10
			vgape = 3
			minut += 5
			horny = 0
			vagina = 1
			if camclients > 1000:
				tokens += RAND(1000,5000)
			elseif camclients > 500:
				tokens += RAND(500,3000)
			elseif camclients > 250:
				tokens += RAND(500,1500)
			elseif camclients > 100:
				tokens += RAND(100,1000)
			elseif camclients < 100:
				tokens += RAND(50,500)
			end
			gs 'stat'
			gs 'zz_render', '', 'images/camwhore/camwhore22.jpg', func('kompMFC_strings', 'local_str2')
			act'Далее':gt'Komp','waitclients'
		end
		act 'В попку':
			*clr & cla
			gs 'stat'
			gs 'zz_render', '', '', func('kompMFC_strings', 'local_str3')
			act 'Все равно сделать':
				*clr & cla
				gs 'stat'
				if vibrator = 1:
					act 'Использовать вибратор':
						*clr & cla
						mfcclients = 0
						webpopular += 1
						if webpopular < 15:
							tokens += RAND(25,50)
						elseif webpopular >= 15 and webpopular < 35:
							tokens += RAND(50,100)
						elseif webpopular >= 35 and webpopular < 75:
							tokens += RAND(50,150)
						elseif webpopular >= 75:
							tokens += RAND(100,200)
						end
						minut += 5
						dildohand = 10
						if anus > 10:
							horny += RAND(10,20)
						else
							anus += 1
							horny += RAND(10,20)
						end
						gs 'stat'
						'<center><img src="images/camwhore/camwhore23.jpg"></center>'
						if anus > 10:
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str4')
							if horny >= 100:
								orgasm += 1
								mfccum += 1
								horny = 0
								manna = 100
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str5')
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str6')
							end
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str7')
						end
						act'Далее':gt'Komp','waitclients'
					end
				end
				if dildo = 1:
					act 'Использовать 10ти сантиметровый дилдо':
						*clr & cla
						mfcclients = 0
						webpopular += 1
						if webpopular < 15:
							tokens += RAND(20,30)
						elseif webpopular >= 15 and webpopular < 35:
							tokens += RAND(30,50)
						elseif webpopular >= 35 and webpopular < 75:
							tokens += RAND(30,100)
						elseif webpopular >= 75:
							tokens += RAND(50,100)
						end
						minut += 5
						dildohand = 10
						if anus > 10:
							horny += RAND(5,15)
						else
							horny -= RAND(5,15)
							anus += 1
						end
						gs 'stat'
						'<center><img src="images/camwhore/camwhore24.jpg"></center>'
						if anus > 10:
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str8')
							if horny >= 100:
								orgasm += 1
								mfccum += 1
								horny = 0
								manna = 100
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str9')
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str10')
							end
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str11')
						end
						act'Далее':gt'Komp','waitclients'
					end
				end
				if middildo = 1:
					if anus >= 15:
						act 'Использовать 15ти сантиметровый дилдо':
							*clr & cla
							mfcclients = 0
							webpopular += 1
							if webpopular < 15:
								tokens += RAND(25,35)
							elseif webpopular >= 15 and webpopular < 35:
								tokens += RAND(25,100)
							elseif webpopular >= 35 and webpopular < 75:
								tokens += RAND(25,150)
							elseif webpopular >= 75:
								tokens += RAND(100,150)
							end
							minut += 5
							dildohand = 15
							if anus > 15:
								horny += RAND(5,15)
							else
								horny -= RAND(5,15)
								anus += 1
							end
							gs 'stat'
							'<center><img src="images/camwhore/camwhore25.jpg"></center>'
							if anus > 15:
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str12')
								if horny >= 100:
									orgasm += 1
									mfccum += 1
									horny = 0
									manna = 100
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str13')
								else
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str14')
								end
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str15')
							end
							act'Далее':gt'Komp','waitclients'
						end
					end
				end
				if largedildo = 1:
					if anus >= 20:
						act 'Использовать 20ти сантиметровый дилдо':
							*clr & cla
							mfcclients = 0
							webpopular += 1
							if webpopular < 15:
								tokens += RAND(40,55)
							elseif webpopular >= 15 and webpopular < 35:
								tokens += RAND(40,100)
							elseif webpopular >= 35 and webpopular < 75:
								tokens += RAND(100,150)
							elseif webpopular >= 75:
								tokens += RAND(100,200)
							end
							minut += 5
							dildohand = 20
							if anus > 20:
								horny += RAND(5,15)
							else
								horny -= RAND(5,15)
								anus += 1
								agape = 1
							end
							gs 'stat'
							'<center><img src="images/camwhore/camwhore26.jpg"></center>'
							if anus > 20:
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str16')
								if horny >= 100:
									orgasm += 1
									mfccum += 1
									horny = 0
									manna = 100
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str17')
								else
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str18')
								end
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str19')
							end
							act'Далее':gt'Komp','waitclients'
						end
					end
				end
				if bigdildo = 1:
					if anus >= 25:
						act 'Использовать 25ти сантиметровый дилдо':
							*clr & cla
							mfcclients = 0
							webpopular += 1
							if webpopular < 15:
								tokens += RAND(50,60)
							elseif webpopular >= 15 and webpopular < 35:
								tokens += RAND(50,100)
							elseif webpopular >= 35 and webpopular < 75:
								tokens += RAND(100,200)
							elseif webpopular >= 75:
								tokens += RAND(100,300)
							end
							minut += 5
							dildohand = 25
							if anus > 25:
								horny += RAND(10,20)
							else
								horny -= RAND(10,20)
								anus += 1
								agape = 1
							end
							gs 'stat'
							'<center><img src="images/camwhore/camwhore27.jpg"></center>'
							if anus > 25:
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str20')
								if horny >= 100:
									orgasm += 1
									mfccum += 1
									horny = 0
									manna = 100
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str21')
								else
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str22')
								end
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str23')
							end
							act'Далее':gt'Komp','waitclients'
						end
					end
				end
				if extradildo = 1:
					if anus >= 30:
						act 'Использовать 30ти сантиметровый дилдо':
							*clr & cla
							mfcclients = 0
							webpopular += 1
							if webpopular < 15:
								tokens += RAND(50,75)
							elseif webpopular >= 15 and webpopular < 35:
								tokens += RAND(50,150)
							elseif webpopular >= 35 and webpopular < 75:
								tokens += RAND(100,300)
							elseif webpopular >= 75:
								tokens += RAND(300,500)
							end
							minut += 5
							dildohand = 30
							if anus > 30:
								horny += RAND(15,20)
							else
								horny -= RAND(15,20)
								anus += 1
								agape = 1
							end
							gs 'stat'
							'<center><img src="images/camwhore/camwhore28.jpg"></center>'
							if anus > 30:
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str24')
								if horny >= 100:
									orgasm += 1
									mfccum += 1
									horny = 0
									manna = 100
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str25')
								else
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str26')
								end
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str27')
							end
							act'Далее':gt'Komp','waitclients'
						end
					end
				end
				if superdildo = 1:
					if anus >= 35:
						act 'Использовать 35ти сантиметровый дилдо':
							*clr & cla
							mfcclients = 0
							webpopular += 1
							if webpopular < 15:
								tokens += RAND(75,100)
							elseif webpopular >= 15 and webpopular < 35:
								tokens += RAND(100,300)
							elseif webpopular >= 35 and webpopular < 75:
								tokens += RAND(100,500)
							elseif webpopular >= 75:
								tokens += RAND(300,500)
							end
							minut += 5
							dildohand = 35
							if anus > 35:
								horny += RAND(20,25)
							else
								horny -= RAND(20,25)
								anus += 1
								agape = 1
							end
							gs 'stat'
							'<center><img src="images/camwhore/camwhore29.jpg"></center>'
							if anus > 30:
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str28')
								if horny >= 100:
									orgasm += 1
									mfccum += 1
									horny = 0
									manna = 100
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str29')
								else
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str30')
								end
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str31')
							end
							act'Далее':gt'Komp','waitclients'
						end
					end
				end
				if maddildo = 1:
					if anus >= 35:
						act 'Использовать 40ти сантиметровый дилдо':
							*clr & cla
							mfcclients = 0
							webpopular += 1
							if webpopular < 15:
								tokens += RAND(100,150)
							elseif webpopular >= 15 and webpopular < 35:
							tokens += RAND(100,300)
							elseif webpopular >= 35 and webpopular < 75:
								tokens += RAND(300,500)
							elseif webpopular >= 75:
								tokens += RAND(500,750)
							end
							minut += 5
							dildohand = 40
							if anus > 35:
								horny += RAND(25,30)
							else
								horny -= RAND(25,30)
								anus += 1
								agape = 1
							end
							gs 'stat'
							'<center><img src="images/camwhore/camwhore30.jpg"></center>'
							if anus > 35:
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str32')
								if horny >= 100:
									orgasm += 1
									mfccum += 1
									horny = 0
									manna = 100
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str33')
								else
									gs 'zz_render', '', '', func('kompMFC_strings', 'local_str34')
								end
							else
								gs 'zz_render', '', '', func('kompMFC_strings', 'local_str35')
							end
							act'Далее':gt'Komp','waitclients'
						end
					end
				end
			end
			act 'Игнорировать':
				*clr & cla
				webpopular -= 1
				gt'Komp','waitclients'
			end
		end
	elseif vagina > 0:
		if vibrator = 1:
			act 'Использовать вибратор':
				*clr & cla
				mfcclients = 0
				webpopular += 1
				if webpopular < 15:
					tokens += RAND(25,50)
				elseif webpopular >= 15 and webpopular < 35:
					tokens += RAND(50,100)
				elseif webpopular >= 35 and webpopular < 75:
					tokens += RAND(50,150)
				elseif webpopular >= 75:
					tokens += RAND(100,200)
				end
				minut += 5
				dildohand = 10
				if vagina > 10:
					horny += RAND(10,20)
				else
					horny += RAND(10,15)
					vagina += 1
				end
				gs 'stat'
				'<center><img src="images/camwhore/camwhore31.jpg"></center>'
				if vagina > 15:
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str36')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str37')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str38')
					end
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str39')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str40')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str41')
					end
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
		if dildo = 1:
			act 'Использовать 10ти сантиметровый дилдо':
				*clr & cla
				mfcclients = 0
				webpopular += 1
				if webpopular < 15:
					tokens += RAND(20,30)
				elseif webpopular >= 15 and webpopular < 35:
					tokens += RAND(20,50)
				elseif webpopular >= 35 and webpopular < 75:
					tokens += RAND(20,100)
				elseif webpopular >= 75:
					tokens += RAND(50,100)
				end
				minut += 5
				dildohand = 10
				if vagina < 10:
					horny += RAND(10,15)
					vagina += 1
				else
					horny += RAND(5,10)
				end
				gs 'stat'
				'<center><img src="images/camwhore/camwhore36.jpg"></center>'
				if vagina > 10:
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str42')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str43')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str44')
					end
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str45')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str46')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str47')
					end
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
		if middildo = 1:
			act 'Использовать 15ти сантиметровый дилдо':
				*clr & cla
				mfcclients = 0
				webpopular += 1
				if webpopular < 15:
					tokens += RAND(25,35)
				elseif webpopular >= 15 and webpopular < 35:
					tokens += RAND(35,50)
				elseif webpopular >= 35 and webpopular < 75:
					tokens += RAND(50,75)
				elseif webpopular >= 75:
					tokens += RAND(50,100)
				end
				minut += 5
				dildohand = 15
				if vagina < 15:
					horny += RAND(10,15)
					vagina += 1
					vgape = 1
				else
					horny += RAND(5,10)
				end
				gs 'stat'
				'<center><img src="images/camwhore/camwhore37.jpg"></center>'
				if vagina > 15:
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str48')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str49')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str50')
					end
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str51')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str52')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str53')
					end
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
		if largedildo = 1:
			act 'Использовать 20ти сантиметровый дилдо':
				*clr & cla
				mfcclients = 0
				webpopular += 1
				if webpopular < 15:
					tokens += RAND(40,55)
				elseif webpopular >= 15 and webpopular < 35:
					tokens += RAND(50,100)
				elseif webpopular >= 35 and webpopular < 75:
					tokens += RAND(50,150)
				elseif webpopular >= 75:
					tokens += RAND(50,200)
				end
				minut += 5
				dildohand = 20
				if vagina < 20:
					horny += RAND(5,15)
					vagina += 1
					vgape = 2
				else
					horny += RAND(5,10)
				end
				gs 'stat'
				'<center><img src="images/camwhore/camwhore38.jpg"></center>'
				if vagina > 20:
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str54')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str55')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str56')
					end
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str57')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str58')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str59')
					end
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
		if bigdildo = 1:
			act 'Использовать 25ти сантиметровый дилдо':
				*clr & cla
				mfcclients = 0
				webpopular += 1
				if webpopular < 15:
					tokens += RAND(50,60)
				elseif webpopular >= 15 and webpopular < 35:
					tokens += RAND(50,150)
				elseif webpopular >= 35 and webpopular < 75:
					tokens += RAND(100,250)
				elseif webpopular >= 75:
					tokens += RAND(250,400)
				end
				minut += 5
				dildohand = 25
				if vagina < 25:
					horny += RAND(10,20)
					vagina += 1
					vgape = 3
				else
					horny += RAND(5,10)
				end
				gs 'stat'
				'<center><img src="images/camwhore/camwhore39.jpg"></center>'
				if vagina > 25:
				gs 'zz_render', '', '', func('kompMFC_strings', 'local_str60')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str61')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str62')
					end
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str63')
					if horny >= 100:
						orgasm += 1
						mfccum += 1
						horny = 0
						manna = 100
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str64')
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str65')
					end
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
		if extradildo = 1:
			if vagina >= 25:
				act 'Использовать 30ти сантиметровый дилдо':
					*clr & cla
					mfcclients = 0
					webpopular += 1
					if webpopular < 15:
						tokens += RAND(50,75)
					elseif webpopular >= 15 and webpopular < 35:
						tokens += RAND(75,100)
					elseif webpopular >= 35 and webpopular < 75:
						tokens += RAND(100,250)
					elseif webpopular >= 75:
						tokens += RAND(250,500)
					end
					minut += 5
					dildohand = 30
					if vagina < 30:
						horny += RAND(15,20)
						vagina += 1
						vgape = 1
					else
						horny += RAND(5,15)
					end
					gs 'stat'
					'<center><img src="images/camwhore/camwhore40.jpg"></center>'
					if vagina > 30:
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str66')
						if horny >= 100:
							orgasm += 1
							mfccum += 1
							horny = 0
							manna = 100
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str67')
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str68')
						end
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str69')
						if horny >= 100:
							orgasm += 1
							mfccum += 1
							horny = 0
							manna = 100
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str70')
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str71')
						end
					end
					act'Далее':gt'Komp','waitclients'
				end
			end
		end
		if superdildo = 1:
			if vagina >= 25:
				act 'Использовать 35ти сантиметровый дилдо':
					*clr & cla
					mfcclients = 0
					webpopular += 1
					if webpopular < 15:
						tokens += RAND(75,100)
					elseif webpopular >= 15 and webpopular < 35:
						tokens += RAND(100,250)
					elseif webpopular >= 35 and webpopular < 75:
						tokens += RAND(200,450)
					elseif webpopular >= 75:
						tokens += RAND(350,750)
					end
					minut += 5
					dildohand = 35
					if vagina < 30:
						horny += RAND(20,25)
						vagina += 1
						vgape = 1
					else
						horny += RAND(10,15)
					end
					gs 'stat'
					'<center><img src="images/camwhore/camwhore41.jpg"></center>'
					if vagina >= 30:
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str72')
						if horny >= 100:
							orgasm += 1
							mfccum += 1
							horny = 0
							manna = 100
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str73')
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str74')
						end
					else
						gs 'zz_render', '', '', func('kompMFC_strings', 'local_str75')
						if horny >= 100:
							orgasm += 1
							mfccum += 1
							horny = 0
							manna = 100
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str76')
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str77')
						end
					end
					act'Далее':gt'Komp','waitclients'
				end
			end
		end
		if maddildo = 1:
			if vagina >= 30:
				act 'Использовать 40ти сантиметровый дилдо':
					*clr & cla
					mfcclients = 0
					webpopular += 2
					if webpopular < 15:
						tokens += RAND(100,150)
					elseif webpopular >= 15 and webpopular < 35:
						tokens += RAND(150,450)
					elseif webpopular >= 35 and webpopular < 75:
						tokens += RAND(350,750)
					elseif webpopular >= 75:
						tokens += RAND(500,750)
					end
					minut += 5
					dildohand = 40
					if vagina < 35:
						horny += RAND(25,30)
						vagina += 1
						vgape = 2
					else
						horny += RAND(15,20)
					end
					gs 'stat'
					if vagina > 35:
						gs 'zz_render', '', 'images/camwhore/camwhore42.jpg', func('kompMFC_strings', 'local_str78')
						if horny >= 100:
							orgasm += 1
							mfccum += 1
							horny = 0
							manna = 100
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str79')
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str80')
						end
					else
						gs 'zz_render', '', 'images/camwhore/camwhore43.jpg', func('kompMFC_strings', 'local_str81')
						if horny >= 100:
							orgasm += 1
							mfccum += 1
							horny = 0
							manna = 100
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str82')
						else
							gs 'zz_render', '', '', func('kompMFC_strings', 'local_str83')
						end
					end
					act'Далее':gt'Komp','waitclients'
				end
			end
		end
	end
else
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFC_strings', 'local_str84')
	if vagina = 0:
		act 'Рукой в попку':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 5
			horny += RAND(10,15)
			if webpopular < 15:
				tokens += RAND(25,50)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(25,75)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(50,100)
			elseif webpopular >= 75:
				tokens += RAND(100,150)
			end
			anus += 1
			gs 'stat'
			if anus < 10:
				gs 'zz_render', '', 'images/camwhore/camwhore32.jpg', func('kompMFC_strings', 'local_str85')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str86')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str87')
				end
			elseif anus >= 10 and anus < 15:
				gs 'zz_render', '', 'images/camwhore/camwhore45.jpg', func('kompMFC_strings', 'local_str88')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str89')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str90')
				end
			elseif anus >= 15 and anus < 25:
				gs 'zz_render', '', 'images/camwhore/camwhore46.jpg', func('kompMFC_strings', 'local_str91')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str92')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str93')
				end
			elseif anus >= 25 and anus < 35:
				gs 'zz_render', '', 'images/camwhore/camwhore47.jpg', func('kompMFC_strings', 'local_str94')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str95')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str96')
				end
			elseif anus >= 35:
				gs 'zz_render', '', 'images/camwhore/camwhore48.jpg', func('kompMFC_strings', 'local_str97')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str98')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str99')
				end
			end
			act'Далее':gt'Komp','waitclients'
		end
		act 'Подручными средствами':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 5
			horny += RAND(10,15)
			if webpopular < 15:
				tokens += RAND(25,50)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(25,75)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(50,100)
			elseif webpopular >= 75:
				tokens += RAND(100,150)
			end
			anus += 1
			gs 'stat'
			if anus < 10:
				gs 'zz_render', '', 'images/camwhore/camwhore49.jpg', func('kompMFC_strings', 'local_str100')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str101')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str102')
				end
				act'Далее':gt'Komp','waitclients'
			elseif anus >= 10 and anus < 15:
				gs 'zz_render', '', 'images/camwhore/camwhore50.jpg', func('kompMFC_strings', 'local_str103')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str104')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str105')
				end
				act'Далее':gt'Komp','waitclients'
			elseif anus >= 15 and anus < 25:
				gs 'zz_render', '', 'images/camwhore/camwhore51.jpg', func('kompMFC_strings', 'local_str106')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str107')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str108')
				end
				act'Далее':gt'Komp','waitclients'
			elseif anus >= 25 and anus < 35:
				gs 'zz_render', '', 'images/camwhore/camwhore52.jpg', func('kompMFC_strings', 'local_str109')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str110')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str111')
				end
				act'Далее':gt'Komp','waitclients'
			elseif anus >= 35:
				gs 'zz_render', '', 'images/camwhore/camwhore53.jpg', func('kompMFC_strings', 'local_str112')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str113')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str114')
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
		act 'Игнорировать':
			*clr & cla
			webpopular -= 1
			gt'Komp','waitclients'
		end
	elseif vagina > 0:
		act 'Сделать':
			*clr & cla
			mfcclients = 0
			webpopular += 1
			minut += 5
			horny += RAND(15,30)
			if webpopular < 15:
				tokens += RAND(25,50)
			elseif webpopular >= 15 and webpopular < 35:
				tokens += RAND(25,75)
			elseif webpopular >= 35 and webpopular < 75:
				tokens += RAND(50,100)
			elseif webpopular >= 75:
				tokens += RAND(100,150)
			end
			if vagina >= 15:
				vagina += 1
			end
			gs 'stat'
			if vagina >= 25 and anus < 25:
				gs 'zz_render', '', 'images/camwhore/camwhore33.jpg', func('kompMFC_strings', 'local_str115')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str116')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str117')
				end
				act'Далее':gt'Komp','waitclients'
			elseif vagina >= 25 and anus >= 25:
				gs 'zz_render', '', 'images/camwhore/camwhore44.jpg', func('kompMFC_strings', 'local_str118')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str119')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str120')
				end
				act'Далее':gt'Komp','waitclients'
			elseif vagina > 15 and vagina < 25:
				gs 'zz_render', '', 'images/camwhore/camwhore34.jpg', func('kompMFC_strings', 'local_str121')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str122')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str123')
				end
				act'Далее':gt'Komp','waitclients'
			elseif vagina <= 15:
				gs 'zz_render', '', 'images/camwhore/camwhore35.jpg', func('kompMFC_strings', 'local_str124')
				if horny >= 100:
					orgasm += 1
					mfccum += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str125')
				else
					gs 'zz_render', '', '', func('kompMFC_strings', 'local_str126')
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
	end
end