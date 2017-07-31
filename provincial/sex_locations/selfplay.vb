$d_self_fingering = {
	act 'Засунуть пальчик во влагалище':
		*clr & cla
		minut += 2
		selfplaytime += 2
		gs 'zz_render', '', 'images/qwest/selfplay/finger.jpg'
		if vagina = 0 and mesec <= 0:
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str1')
			act 'Проткнуть плеву':
				*clr & cla
				horny -= 25
				vagina += 1
				minut += 5
				selfplaytime += 5
				manna -= 100
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/selfplay/finger.jpg', func('selfplay_strings', 'local_str2')
				act 'Передохнуть':gt $curloc
			end
		elseif vagina > 0:
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str3')
			if vagina < 5:
				horny += RAND(2,5)
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str4')
			elseif vagina >= 5 and vagina < 10:
				horny += RAND(5,10)
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str5')
			elseif vagina >= 10:
				horny += RAND(2,5)
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str6')
			elseif vagina < 5:
				vaginaTemp += 1
			end
			act 'Трахать себя пальцами':
				*clr & cla
				minut += 5
				selfplaytime += 5
				horny += iif(vagina <= 10,RAND(5,10),RAND(2,5))
				gs 'zz_render', '', 'images/qwest/selfplay/finger.jpg', func('selfplay_strings', 'local_str7')
				if vagina <= 10:'Ваша киска нежно обхватывает ваши пальчики и вы чувствуете приятно тепло разливающееся внизу живота.'
				if vagina > 10:'Вагина довольно просторная и вам приходится довольно сильно потрудиться, что бы хоть что-то ощущать от своих пальцев.'
				if vagina < 10: vaginaTemp += 1
				if horny >= 100:
					orgasm += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('selfplay_strings', 'local_str8')
				end
				gs 'stat'
				if horny > 0 and grandmaknowmastr = 0 and grandpaknowmastr = 0:dynamic $d_self_fingering2
				act 'Передохнуть':gt $curloc
			end
		elseif mesec > 0:
			manna -= 5
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str9')
		end
		gs 'stat'
		act 'Передохнуть':gt $curloc
	end
}
$d_self_fingering2 = {
	act 'Засунуть ладонь во влагалище':
		*clr & cla
		minut += 2
		selfplaytime += 2
		gs 'zz_render','','images/qwest/selfplay/hand'
		if vagina > 0:
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str10')
			if vagina < 10:
				vgape += 1
				vgapetime = totminut + (vgape + 1) * 1440
				horny -= 10
				manna -= 10
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str11')
			elseif vagina >= 10 and vagina < 15:
				horny += RAND(1,3)
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str12')
			elseif vagina >= 15 and vagina < 20:
				horny += RAND(3,6)
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str13')
			elseif vagina >= 20:
				horny += RAND(6,12)
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str14')
			elseif vagina < 15:
				vaginaTemp += 1
			end
			act 'Трахать себя ладонью':
				*clr & cla
				minut += 5
				selfplaytime += 5
				if vagina < 10:
					if vgape = 2:vgape = 3
					if vgape = 1:vgape = 2
					if vgape = 0:vgape = 1
					vgapetime = totminut + (vgape + 1) * 1440
					horny -= 10
					manna -= 10
				end
				gs 'zz_render', '', 'images/qwest/selfplay/hand.jpg', func('selfplay_strings', 'local_str15')
				if vagina <= 15:horny -= 10 & manna -= 10 & 'Вам больно когда вы пытаетесь трахать свою киску всей ладонью.'
				if vagina > 10:horny += RAND(10,20) & 'Вагина довольно просторная и вам приходится довольно сильно потрудиться, что бы хоть что-то ощущать от своих пальцев.'
				gs'stat'
				if vagina < 20:vaginaTemp += 1
				if horny >= 100:
					orgasm += 1
					horny = 0
					manna = 100
					gs 'zz_render', '', '', func('selfplay_strings', 'local_str16')
				end
				if horny > 0 and grandmaknowmastr = 0 and grandpaknowmastr = 0:dynamic $d_self_fingering2
				act 'Передохнуть':gt $curloc
			end
		end
		gs'stat'
		act 'Передохнуть':gt $curloc
	end
}
$d_van_vtor = {
	if $father['location'] = 'korrPar' or $mother['location'] = 'korrPar' or $sister['location'] = 'korrPar' or $brother['location'] = 'korrPar':
		*clr & cla
		horny -= 50
		manna -= 10
		gs 'stat'
		gs 'zz_render', '', '', func('selfplay_strings', 'local_str17')
		act 'Выйти из ванной':
			analplay = 0
			selfplaytime = 0
			mastrOnce = 0
			if vaginaTemp > vagina*2:vagina += 1 & vaginaTemp = 0
			gt $loc, $metka
		end
		exit
	end
}
$d_self_agape = {
	if agape < 3: agape += 1
	agapetime = totminut + (agape + 1) * 1440
	horny -= 50
	if anus > 1:anus += 1
}
if mastrOnce = 0: mastr += 1 & mastrOnce = 1
gs 'stat'
! кв.родителей или кв.Южн.рн
if $loc = 'korrPar' or $loc = 'korr':
	gs 'zz_render','','qwest/selfplay/startvann'
else
	gs 'zz_render','','qwest/selfplay/start'
end
!тут расчет вторжения
if $loc = 'bedrPar':
	gs 'zz_family','sister_sheduler'
	if $sister['location'] = 'bedrPar':
		*clr & cla
		gs 'stat'
		gs 'zz_render','','qwest/selfplay/start'
		SisterKnowMastr += 1
		gs 'zz_render', '', '', func('selfplay_strings', 'local_str18')
	end
end
gs 'gadukino_event', 'gadsarai_check'
gs 'apartment_south_event','husband_check'
if selfplaytime > 5 and husband_inhouse > 0 and husband_know_mastr = 0:gt 'apartment_south_event','selfplay_husband'
if $loc = 'Gadsarai' and grandma_ingadsarai = 1:grandmaknowmastr = 1 & '<font color = red><b>Бабушка увидела, что вы мастурбируете.</b></font>'
if $loc = 'Gadsarai' and grandpa_ingadsarai = 1:grandpaknowmastr = 1 & '<font color = red><b>Дед увидел, что вы мастурбируете.</b></font>'
if dildo = 1:'У вас есть маленький дилдо длинной 10 см.'
if middildo = 1:'У вас есть дилдо длинной 15 см.'
if largedildo = 1:'У вас есть дилдо длинной 20 см.'
if bigdildo = 1:'У вас есть дилдо длинной 25 см.'
if extradildo = 1:'У вас есть дилдо длинной 30 см.'
if superdildo = 1:'У вас есть дилдо длинной 35 см.'
if maddildo = 1:'У вас есть дилдо длинной 40 см.'
if horny > 0 and grandmaknowmastr = 0 and grandpaknowmastr = 0:
	act 'Ласкать клитор':
		*clr & cla
		minut += 5
		selfplaytime += 5
		if $loc = 'korrPar' or $loc = 'korr':
			gs 'zz_render','','qwest/selfplay/klitvann'
		else
			gs 'zz_render','','qwest/selfplay/klit'
		end
		if manna >= 50:
			horny += RAND(5,10)
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str19')
		else
			horny += RAND(0,1)
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str20')
		end
		if horny >= 100:
			orgasm += 1
			horny = 0
			manna = 100
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str21')
		end
		gs 'stat'
		act 'Передохнуть':gt $curloc
		if horny > 0: dynamic $d_self_fingering
	end
end
if horny > 0 and agape < 3 and grandmaknowmastr = 0 and grandpaknowmastr = 0:
	act 'Засунуть палец в попу':
		*clr & cla
		minut += 5
		selfplaytime += 5
		gs 'zz_render','','qwest/selfplay/1'
		if anus >= 3:
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str22')
		elseif anus >= 1 and anus < 3:
			anus += 1
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str23')
		elseif anus = 0:
			anus = 1
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str24')
		end
		if $loc = 'vanrPar' and selfplaytime >= 60:dynamic $d_van_vtor
		gs 'stat'
		act 'Передохнуть': gt $curloc
		act 'Засунуть два пальца':
			*clr & cla
			minut += 5
			selfplaytime += 5
			gs 'zz_render','','qwest/selfplay/2'
			if anus >= 5:
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str25')
				if agape > 0:
					dynamic $d_self_agape
					gs 'zz_render', '', '', func('selfplay_strings', 'local_str26')
				end
			elseif anus >= 3 and anus < 5:
				analplay += 1
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str27')
				if agape > 0:
					dynamic $d_self_agape
					gs 'zz_render', '', '', func('selfplay_strings', 'local_str28')
				end
			elseif anus >= 1 and anus < 3:
				anus += 1
				if agape < 3: agape += 1
				horny -= 50
				agapetime = totminut + (agape + 1) * 1440
				gs 'zz_render', '', '', func('selfplay_strings', 'local_str29')
			end
			gs 'stat'
			act 'Передохнуть': gt $curloc
			if $loc = 'korrPar' and selfplaytime >= 60: dynamic $d_van_vtor
			if horny > 0 and agape < 3:
				act 'Засунуть три пальца':
					*clr & cla
					minut += 5
					selfplaytime += 5
					gs 'zz_render','','qwest/selfplay/3'
					if anus >= 10:
						gs 'zz_render', '', '', func('selfplay_strings', 'local_str30')
						if agape > 0:
							dynamic $d_self_agape
							gs 'zz_render', '', '', func('selfplay_strings', 'local_str31')
						end
					elseif anus >= 5 and anus < 10:
						analplay += 1
						gs 'zz_render', '', '', func('selfplay_strings', 'local_str32')
						if agape > 0:
							dynamic $d_self_agape
							gs 'zz_render', '', '', func('selfplay_strings', 'local_str33')
						end
					elseif anus < 5:
						dynamic $d_self_agape
						gs 'zz_render', '', '', func('selfplay_strings', 'local_str34')
					end
					act 'Передохнуть':gt $curloc
					if $loc = 'korrPar' and selfplaytime >= 60:dynamic $d_van_vtor
					gs 'stat'
					if horny > 0 and agape < 3:
						act 'Засунуть четыре пальца':
							*clr & cla
							minut += 5
							selfplaytime += 5
							gs 'zz_render','','qwest/selfplay/4'
							if anus >= 15:
								gs 'zz_render', '', '', func('selfplay_strings', 'local_str35')
								if agape > 0:
									dynamic $d_self_agape
									gs 'zz_render', '', '', func('selfplay_strings', 'local_str36')
								end
							elseif anus >= 10 and anus < 15:
								analplay += 1
								gs 'zz_render', '', '', func('selfplay_strings', 'local_str37')
								if agape > 0:
									dynamic $d_self_agape
									gs 'zz_render', '', '', func('selfplay_strings', 'local_str38')
								end
							elseif anus < 10:
								dynamic $d_self_agape
								gs 'zz_render', '', '', func('selfplay_strings', 'local_str39')
							end
							act 'Передохнуть':gt $curloc
							if $loc = 'korrPar' and selfplaytime >= 60: dynamic $d_van_vtor
							gs 'stat'
							if horny > 0 and agape < 3:
								act 'Засунуть всю руку':
									*clr & cla
									SelfFisting += 1
									minut += 5
									selfplaytime += 5
									gs 'zz_render','','qwest/selfplay/5'
									if anus >= 20:
										gs 'zz_render', '', '', func('selfplay_strings', 'local_str40')
										if agape > 0:
											dynamic $d_self_agape
										gs 'zz_render', '', '', func('selfplay_strings', 'local_str41')
										end
									elseif anus >= 15 and anus < 20:
										analplay += 1
										gs 'zz_render', '', '', func('selfplay_strings', 'local_str42')
										if agape > 0:
											dynamic $d_self_agape
										gs 'zz_render', '', '', func('selfplay_strings', 'local_str43')
										end
									else
										dynamic $d_self_agape
										gs 'zz_render', '', '', func('selfplay_strings', 'local_str44')
									end
									act 'Передохнуть':gt $curloc
									if $loc = 'korrPar' and selfplaytime >= 60:dynamic $d_van_vtor
									gs'stat'
								end
							end
						end
					end
				end
			end
		end
	end
end
if horny > 10 and grandmaknowmastr = 0 and grandpaknowmastr = 0:
	if dildo >= 1 or middildo = 1 or largedildo = 1 or bigdildo = 1 or extradildo = 1 or superdildo = 1 or maddildo = 1:
		if dildohand > 0:
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str45')
			if vgape <= 0:
				act 'Дилдо в киску':
					*clr & cla
					minut += 15
					selfplaytime += 15
					dick = dildohand
					protect = 1
					if $loc = 'korrPar' or $loc = 'korr':
						gs 'zz_render','','qwest/selfplay/dildovann'
					else
						gs 'zz_render','','qwest/selfplay/dildo'
					end
					gs 'zz_dynamic_sex','sex_start', 1
					gs 'zz_dynamic_sex','vaginal','dildo'
					gs'stat'
					if husband > 0 and housrA = 1 and husbandrink ! 10 and $loc = 'bedr': dynamic $husb_mastr_vtor
					act 'Передохнуть':gt $curloc
				end
			end
			if agape <= 0:
				act 'Дилдо в попу':
					*clr & cla
					minut += 15
					selfplaytime += 15
					dick = dildohand
					if $loc = 'korrPar' or $loc = 'korr':
						gs 'zz_render','','qwest/selfplay/dildovann'
					else
						gs 'zz_render','','qwest/selfplay/dildo'
					end
					gs 'zz_dynamic_sex','anal_start','dildo'
					gs 'zz_dynamic_sex','anal','dildo'
					gs'stat'
					act 'Передохнуть':gt $curloc
				end
			end
			act 'Положить дилдо на место':dildohand = 0 & gt $curloc
		elseif dildohand = 0:
			gs 'zz_render', '', '', func('selfplay_strings', 'local_str46')
			if dildo = 1:
				act 'Взять 10ти сантиметровый дилдо':dildohand = 10 & gt $curloc
			end
			if middildo = 1:
				act 'Взять 15ти сантиметровый дилдо':dildohand = 15 & gt $curloc
			end
			if largedildo = 1:
				act 'Взять 20ти сантиметровый дилдо':dildohand = 20 & gt $curloc
			end
			if bigdildo = 1:
				act 'Взять 25ти сантиметровый дилдо':dildohand = 25 & gt $curloc
			end
			if extradildo = 1:
				act 'Взять 30ти сантиметровый дилдо':dildohand = 30 & gt $curloc
			end
			if superdildo = 1:
				act 'Взять 35ти сантиметровый дилдо':dildohand = 35 & gt $curloc
			end
			if maddildo = 1:
				act 'Взять 40ти сантиметровый дилдо':dildohand = 40 & gt $curloc
			end
		end
	end
end
if horny > 0 and grandmaknowmastr = 0 and grandpaknowmastr = 0:dynamic $d_self_fingering
act 'Отказаться от этой затеи':
	analplay = 0
	selfplaytime = 0
	mastrOnce = 0
	if vaginaTemp > vagina*2:vagina += 1 & vaginaTemp = 0
	if $loc = 'korrPar': gs 'zz_bathroom','start'
	if $loc ! 'korrPar': gt $loc, $metka
end
! ванная в квартире родителей - вторжение
if $loc = 'korrPar' and selfplaytime >= 60: dynamic $d_van_vtor