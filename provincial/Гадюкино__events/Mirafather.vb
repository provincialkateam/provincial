$boy = 'Афанасий'
dick = 18
silaVag = 0
harakBoy = 1
if MiraFatherQW < 0:MiraFatherQW = 0
boyage = age+34
if cumface or cumfrot > 0:MiraFatherQW -= 1
if MiraFatherQW < 0:MiraFatherQW = 0
gs 'stat'
if MiraFatherQW < 10:'<center><b><font color = maroon>Отец Мирославы</font></b></center>'
if MiraFatherQW >= 10:'<center><b><font color = maroon>Афанасий</font></b></center>'
'<center><img src="images/qwest/gadukino/MiraFather.jpg"></center>'
'Отец Миры. Ему <<boyage>> лет. После смерти жены он сильно сдал и заметно постарел, хоть все еще и выглядит довольно сносно для своего возраста.'
if cumface > 0: iif(MiraFatherQW < 10,'отец Миры','Афанасий')+' отводит взгляд и хмурится. Видимо заметил сперму на вашем лице.'
if cumfrot > 0: iif(MiraFatherQW < 10,'отец Миры','Афанасий')+' отводит взгляд и хмурится. Видимо заметил пятна спермы на вашей одежде.'
if MiraFather ! daystart:
	MiraFather = daystart
	act 'Поздороваться':
		*clr & cla
		if MiraFatherQW < 10:MiraFatherQW += 1
		minut += 2
		gs 'stat'
		act 'Уйти': gt 'miroslavahome'
		'<center><img src="images/qwest/gadukino/MiraFather.jpg"></center>'
		'Вы здороваетесь с Мириным отцом и вежливо интересуетесь о его самочувствии. Он приветливо улыбается вам в ответ и говорит, что все хорошо.'
		if MiraFatherQW >= 10:
			act 'Поболтать':
				*clr & cla
				if MiraFatherQW < 20:MiraFatherQW += 1
				minut += 5
				gs 'stat'
				'<center><img src="images/qwest/gadukino/MiraFather.jpg"></center>'
				'Вы пару минут болтаете с Миркиным отцом о погоде и прочей ерунде.'
				act 'Уйти': gt 'miroslavahome'
			end
		end
		if MiraFatherQW >= 20 and grandpa_guest = 0:
			act 'Флиртовать':
				*clr & cla
				if MiraFatherQW < 30:MiraFatherQW += 1
				minut += 10
				horny += 10
				gs 'stat'
				'<center><img src="images/qwest/gadukino/MiraFather.jpg"></center>'
				'Вы пару минут перекидываетесь с Афанасием игривыми гляделками и двусмысленностями. Он рад компании молодой девушки и пару раз вы замечаете на себе его блуждающий недвусмысленный взгляд.'
				if MiraFatherQW = 30:
					act 'Соблазнить':
						*clr & cla
						MiraFatherQW = 31
						minut += 10
						horny += 30
						gs 'stat'
						'<center><img src="images/qwest/gadukino/MiraFather.jpg"></center>'
						'Вы совсем уж внаглую то поглаживаете себя по бедру, то по груди, то просто томно вздыхаете, проводя язычком по губам и уже через пару минут Афанасий, будучи опытным мужчиной, все прекрасно понимает и ведет вас за руку к себе в дом, а потом и в собственную комнату.'
						act 'Наслаждаться':
							*clr & cla
							minut += 10
							horny = 0
							kuni += 1
							guy += 1
							orgasm += 1
							gs 'stat'
							'<center><img src="images/qwest/gadukino/MiraFatherSexKuni.jpg"></center>'
							'Афанасий быстро, но нежно раздевает вас и припадает губами к вашей изнывающей киске и умело вылизывает ее до тех пор, пока не доводит вас до мощного оргазма.'
							act 'Дать':
								*clr & cla
								$boy = 'Афанасий'
								silavag = 0
								dick = 18
								pose = 0
								minut += 10
								horny += 10
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraFatherSex.jpg"></center>'
								if mesec = 0 or vagina > 0:
									gs 'zz_dynamic_sex', 'sex_start'
									gs 'zz_dynamic_sex', 'vaginal', 'dick'
									gs 'zz_dynamic_sex', 'sex_cum'
								else
									gs 'zz_dynamic_sex', 'anal_start', 'dick'
									gs 'zz_dynamic_sex', 'anal', 'dick'
									gs 'zz_dynamic_sex', 'anal_cum'
								end
								act 'Уйти':gt 'miroslavahome'
							end
						end
					end
				end
				if MiraFatherQW > 30:
					act 'Подмигнуть':
						*clr & cla
						$boy = 'Афанасий'
						silavag = 0
						dick = 18
						pose = 0
						minut += 5
						horny += 10
						temp = RAND(0,5)
						gs 'stat'
						'<center><img src="images/qwest/gadukino/MiraFather.jpg"></center>'
						if temp < 5:
							'Вы недвусмысленно подмигиваете Афанасию и тот, прекрасно все понимая, жестом приглашает вас в дом.'
							act 'Далее':
								*clr & cla
								minut += 10
								horny += 10
								temp = RAND(0,9)
								gs 'stat'
								if temp = 0:
									'<center><img src="images/qwest/gadukino/MiraFatherSex.jpg"></center>'
								elseif temp = 1:
									'<center><img src="images/qwest/gadukino/MiraFatherSex1.jpg"></center>'
								elseif temp = 2:
									'<center><img src="images/qwest/gadukino/MiraFatherSex2.jpg"></center>'
								elseif temp = 3:
									'<center><img src="images/qwest/gadukino/MiraFatherSex3.jpg"></center>'
								elseif temp = 4:
									'<center><img src="images/qwest/gadukino/MiraFatherSex4.jpg"></center>'
								elseif temp = 5:
									'<center><img src="images/qwest/gadukino/MiraFatherBj.jpg"></center>'
								elseif temp = 6:
									'<center><img src="images/qwest/gadukino/MiraFatherBj1.jpg"></center>'
								elseif temp = 7:
									'<center><img src="images/qwest/gadukino/MiraFatherBj2.jpg"></center>'
								elseif temp = 8:
									'<center><img src="images/qwest/gadukino/MiraFatherBj3.jpg"></center>'
								elseif temp = 9:
									'<center><img src="images/qwest/gadukino/MiraFatherBj4.jpg"></center>'
								end
								if temp < 5:
									minut += 10
									horny += 10
									gs 'stat'
									if mesec = 0 or vagina > 0:
										gs 'zz_dynamic_sex', 'sex_start'
										gs 'zz_dynamic_sex', 'vaginal', 'dick'
										gs 'zz_dynamic_sex', 'sex_cum'
									else
										gs 'zz_dynamic_sex', 'anal_start', 'dick'
										gs 'zz_dynamic_sex', 'anal', 'dick'
										gs 'zz_dynamic_sex', 'anal_cum'
									end
									act 'Уйти':gt 'miroslavahome'
								else
									$boy = 'Афанасий'
									minut += 10
									horny += 10
									gs 'stat'
									act 'Далее':
										*clr & cla
										minut += 5
										horny += 10
										bj += 1
										gs 'zz_funcs', 'cum', 'lip'
										gs 'zz_funcs', 'cum', 'belly'
										gs 'stat'
										'<center><img src="images/qwest/gadukino/MiraFatherCum.jpg"></center>'
										'Афанасий наконец мягко отстраняется от вас и остави пару капель спермы у вас во рту, начинает кончать вам на грудь и живот.'
										act 'Уйти':gt 'miroslavahome'
									end
								end
							end
						else
							'Вы недвусмысленно подмигиваете Афанасию, но тот только улыбается в ответ и говорит, что как-нибудь в следующий раз.'
							act 'Уйти': gt 'miroslavahome'
						end
					end
				end
				act 'Уйти': gt 'miroslavahome'
			end
		end
	end
	act 'Уйти':gt 'miroslavahome'
end
act 'Уйти': gt 'miroslavahome'