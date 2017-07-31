$burger_work_din = {
	burand = RAND(0,6)
	if burand = 0:
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str1')
		act 'Идти в кабинет Анатолия Борисовича':
			*clr & cla
			gs'stat'
			'<center><img src="images/qwest/sosed/work2.jpg"></center>'
			bossrand = RAND(0,3)
			if bossrand = 0:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str2')
				act 'Принести кофе':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/qwest/sosed/work3.jpg', func('BurgerTip_strings', 'local_str3')
					dynamic $dinBistroWork[PSBBtimes-1]
				end
			elseif bossrand = 1:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str4')
				act 'Сходить к главбуху':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/qwest/sosed/work9.jpg', func('BurgerTip_strings', 'local_str5')
					act 'Идти к директору':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/qwest/sosed/work2.jpg', func('BurgerTip_strings', 'local_str6')
						dynamic $dinBistroWork[PSBBtimes-1]
					end
				end
			elseif bossrand = 2:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str7')
				act 'Сходить к Ивану':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/qwest/sosed/work7.jpg', func('BurgerTip_strings', 'local_str8')
					act 'Идти к себе':
						*clr & cla
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/sosed/work.jpg', func('BurgerTip_strings', 'local_str9')
						dynamic $dinBistroWork[PSBBtimes-1]
					end
				end
			elseif bossrand = 3:
				*clr & cla
				bossexrand = RAND(0,3)
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/qwest/sosed/boss<<bossexrand>>.jpg', func('BurgerTip_strings', 'local_str10')
				if bossexrand = 0:'Анатолий Борисович подошел к вам и страстно прижал вас к стене покрывая поцелуями.'
				if bossexrand = 1:'Его рука скользнула по вашему животу и забралась под юбку, вы ощутили как его рука начала ласкать вашу киску.'
				if bossexrand = 2:'Он схватил вас за зад и задрав вам юбку начал мять вашу мягкую попку.'
				if bossexrand = 3:'Анатолий Борисович положил свои руки на ваши бедра, его руки скользнули вверх задирая вашу юбку.'
				act 'Целоваться':
					*clr & cla
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/sosed/bossex.jpg', func('BurgerTip_strings', 'local_str11')
					dynamic $boss_din_bj
					act 'Продолжать':
						*clr & cla
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/sosed/bossex2.jpg', func('BurgerTip_strings', 'local_str12')
						if rand(1,10) >= 3:
							dynamic $boss_din_sex2
						else
							gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str13')
							dynamic $boss_din_anal2
						end
					end
				end
				act 'Встать на колени':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/qwest/sosed/bossex1.jpg', func('BurgerTip_strings', 'local_str14')
					act 'Ласкать член сквозь трусы':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/qwest/sosed/bossBJ.jpg', func('BurgerTip_strings', 'local_str15')
						dynamic $boss_din_bj
					end
					dynamic $boss_din_bj
				end
			end
		end
		exit
	elseif burand = 1:
		*clr & cla
		gs'stat'
		'<center><img src="images/qwest/sosed/work5.jpg"></center>'
		if PSBBtimes = 1:
			bosstiprand = RAND(0,3)
			if bosstiprand = 0:
				TerminalPapper = 1
				DayTerminalPapper = day
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str16')
				act 'Уйти':gt'down'
			elseif bosstiprand = 1:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str17')
				act 'Принимать продукты':
					*clr & cla
					gs 'stat'
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str18')
					dynamic $dinBistroWork[PSBBtimes-1]
				end
			elseif bosstiprand = 2:
				BankPapper = 1
				dayBankPapper = day
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str19')
				act 'Уйти':gt'down'
			elseif bosstiprand = 3:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str20')
				act 'Вызвать компьютерщика':
					*clr & cla
					gs'stat'
					if sosedQW = 0:
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str21')
					elseif sosedQW > 0 and sosedKnowWork > 0:
						sosedKnowWork = 1
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str22')
					elseif sosedQW > 0 and sosedKnowWork = 0:
						sosedKnowWork = 1
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str23')
					end
					dynamic $dinBistroWork[PSBBtimes-1]
				end
			end
		else
			bosstiprand = RAND(0,3)
			if bosstiprand = 0:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str24')
				bburand = RAND(0,10)
				if bburand = 0:
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str25')
					dynamic $din_Ivan_work
					if kompromatLife = 0 or kompromatBlackMail > 1:
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str26')
						dynamic $dinBistroWork[PSBBtimes-1]
					end
				elseif bburand = 1:
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str27')
					if sergeyPQW = 1:
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str28')
					else
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str29')
						act 'Нет! И даже не думай!':
							*clr & cla
							gs 'stat'
							gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str30')
							dynamic $dinBistroWork[PSBBtimes-1]
						end
						act 'Давай':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/sosed/work7.jpg', func('BurgerTip_strings', 'local_str31')
							act 'Идти':
								*clr & cla
								minut += 60
								horny += 15
								water = 24
								energy = 24
								body['day_weight'] += 1
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/sosed/kafe2.jpg', func('BurgerTip_strings', 'local_str32')
								act 'Отказаться':
									*clr & cla
									minut += 15
									sergeyPQW = 1
									gs 'stat'
									gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str33')
									act 'Уйти':gt'down'
								end
							end
						end
						exit
					end
					dynamic $dinBistroWork[PSBBtimes-1]
				elseif bburand = 2:
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str34')
					dynamic $dinBistroWork[PSBBtimes-1]
				elseif bburand = 3:
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str35')
					dynamic $dinBistroWork[PSBBtimes-1]
				elseif bburand > 3:
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str36')
					dynamic $dinBistroWork[PSBBtimes-1]
				end
			elseif bosstiprand = 1:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str37')
				act 'Ехать с Анатолием Борисовичем':
					*clr & cla
					gs 'stat'
					'<center><img src="images/maggot/car.jpg"></center>'
					if RAND(0,1) = 0:
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str38')
						act 'Идти в сауну':
							*clr & cla
							gs'stat'
							if SaunaWhore > 0:
								BuSWworkEnd = 1
								gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str39')
								act 'Уйти':gt'street'
							else
								gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str40')
								act 'Далее':
									*clr & cla
									minut += 5
									bj += 1
									gs'stat'
									gs 'zz_render', '', 'images/qwest/sosed/bossBJS.jpg', func('BurgerTip_strings', 'local_str41')
									act 'Далее':
										*clr & cla
										minut += 5
										protect = 1
										$boy = 'Анатолий'
										dick = 12
										silavag = 0
										pose = 2
										gs 'stat'
										gs 'zz_render', '', 'images/qwest/sosed/bossSexS.jpg', func('BurgerTip_strings', 'local_str42')
										gs 'zz_dynamic_sex', 'vaginal', 'dick'
										sweat = -3
										gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str43')
										act 'Уйти':gt'street'
									end
								end
							end
						end
					else
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str44')
						act 'Отсосать':
							*clr & cla
							minut += 5
							bj += 1
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/sosed/bossBJcar.jpg', func('BurgerTip_strings', 'local_str45')
							act 'Уйти':gt'down'
						end
					end
				end
				exit
			elseif bosstiprand = 2:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str46')
				act 'Вызвать компьютерщика':
					*clr & cla
					gs'stat'
					if sosedQW = 0:
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str47')
					elseif sosedQW > 0 and sosedKnowWork > 0:
						sosedKnowWork = 1
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str48')
					elseif sosedQW > 0 and sosedKnowWork = 0:
						sosedKnowWork = 1
						gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str49')
					end
					dynamic $dinBistroWork[PSBBtimes-1]
				end
			elseif bosstiprand = 3:
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str50')
				act 'Далее':
					*clr & cla
					minut += 60
					gs'stat'
					gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str51')
					act 'Уйти':gt'down'
				end
			end
		end
		exit
	elseif burand = 2:
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str52')
		dynamic $din_Ivan_work
		if kompromatLife = 0 or kompromatBlackMail > 1:
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str53')
			dynamic $dinBistroWork[PSBBtimes-1]
		end
		exit
	elseif burand = 3:
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str54')
		dynamic $dinBistroWork[PSBBtimes-1]
		exit
	elseif burand = 4:
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str55')
		dynamic $dinBistroWork[PSBBtimes-1]
		exit
	elseif burand = 5:
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str56')
		dynamic $dinBistroWork[PSBBtimes-1]
		exit
	elseif burand = 6:
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str57')
		if gossipBU < 10:
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str58')
			dynamic $dinBistroWork[PSBBtimes-1]
		else
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str59')
			act 'Писать заявление о увольнении':
				*clr & cla
				work = 0
				PersSecWork = 2
				Pay = PersSecWorkTimes*2500
				PersSecWorkTimes = 0
				money += Pay
				gs'stat'
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str60')
				act 'Уйти':gt'down'
			end
		end
		exit
	end
}
$boss_ass_din = {
	if RAND(0,3) = 0: 'Когда вы наклонились забрать документы со стола, то получили смачный шлепок по заднице от Анатолия Борисовича.'
}
$boss_din_bj = {
	act 'Достать член из трусов':
		*clr & cla
		wantrand = RAND(0,3)
		bj += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossBJ'+RAND(0,14)+'.jpg', func('BurgerTip_strings', 'local_str61')
		if wantrand = 3:
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str62')
			dynamic $boss_din_bendover
		elseif wantrand = 2:
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str63')
			dynamic $boss_din_bendover
			dynamic $boss_din_bj2
		elseif wantrand < 2:
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str64')
			dynamic $boss_din_bj_cum
		end
	end
}
$boss_din_go_toilet = {
	act 'Идти в туалет':
		*clr & cla
		gs'stat'
		bosstoirand = RAND(0,10)
		if bosstoirand = 10:
			gossipBU += 1
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str65')
			dynamic $boss_din_toilet_wash
		elseif bosstoirand = 9:
			gossipBU += 1
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str66')
			dynamic $boss_din_toilet_wash
		elseif bosstoirand = 8:
			gossipBU += 1
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str67')
			dynamic $boss_din_toilet_wash
		elseif bosstoirand = 7:
			gossipBU += 1
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str68')
			dynamic $boss_din_toilet_wash
		elseif bosstoirand < 7:
			bosstoirandin = RAND(0,10)
			if bosstoirandin = 10:
				gossipBU += 1
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str69')
				dynamic $boss_din_toilet_wash2
			elseif bosstoirandin = 9:
				gossipBU += 1
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str70')
				dynamic $boss_din_toilet_wash2
			elseif bosstoirandin < 9:
				cumface = 0
				cumfrot = 0
				if cumface > 0: $deytoibur = 'Стоя возле раковины вы умыли лицо, смыв сперму.'
				if cumfrot > 0: $deytoibur2 = 'Незаметно стереть сперму с одежды не удалось и на блузке осталось большое мокрое пятно.'
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str71')
				dynamic $dinBistroWork[PSBBtimes-1]
			end
		end
	end
}
$boss_din_toilet_wash = {
	cumface = 0
	cumfrot = 0
	if cumface > 0:$deytoibur = 'Стоя возле раковины вы умыли лицо, смыв сперму.'
	if cumfrot > 0:$deytoibur2 = 'Незаметно стереть сперму с одежды не удалось и на блузке осталось большое мокрое пятно.'
	gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str72')
	dynamic $dinBistroWork[PSBBtimes-1]
}
$boss_din_toilet_wash2 = {
	cumface = 0
	cumfrot = 0
	if cumface > 0: $deytoibur = 'Стоя возле раковины вы умыли лицо, смыв сперму.'
	if cumfrot > 0: $deytoibur2 = 'Незаметно стереть сперму с одежды не удалось и на блузке осталось большое мокрое пятно.'
	gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str73')
	dynamic $dinBistroWork[PSBBtimes-1]
}
$boss_din_bj_cum = {
	act 'Вынуть член изо рта':
		*clr & cla
		gs'stat'
		reaktrand = RAND(0,10)
		if reaktrand <= 5:
			gs 'zz_render', '', 'images/qwest/sosed/bossBJcum.jpg', func('BurgerTip_strings', 'local_str74')
			dynamic $dinBistroWork[PSBBtimes-1]
		elseif reaktrand > 5 and reaktrand < 9:
			cumfrot += 1
			gs 'zz_render', '', 'images/qwest/sosed/bossBJcum2.jpg', func('BurgerTip_strings', 'local_str75')
			dynamic $boss_din_go_toilet
		elseif reaktrand >= 9:
			gs 'zz_funcs', 'cum', 'face'
			cumfrot += 1
			gs 'zz_render', '', 'images/qwest/sosed/bossBJcum3.jpg', func('BurgerTip_strings', 'local_str76')
			dynamic $boss_din_go_toilet
		end
		gs'stat'
	end
	dynamic $boss_din_bj2
}
$boss_din_bj2 = {
	act 'Продолжить сосать':
		*clr & cla
		gs 'zz_funcs', 'cum', 'lip'
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossBJcum4.jpg', func('BurgerTip_strings', 'local_str77')
		act 'Выплюнуть':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/qwest/sosed/bossBJcum5.jpg', func('BurgerTip_strings', 'local_str78')
			if RAND(0,10) > 2:
				dynamic $dinBistroWork[PSBBtimes-1]
			else
				cumfrot += 1
				gs 'stat'
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str79')
				dynamic $boss_din_go_toilet
			end
		end
		act 'Проглотить':
			*clr & cla
			swallow += 1
			gs'stat'
			gs 'zz_render', '', 'images/qwest/sosed/bossBJcum6.jpg', func('BurgerTip_strings', 'local_str80')
			if RAND(0,10) > 2:
				dynamic $dinBistroWork[PSBBtimes-1]
			else
				cumfrot += 1
				gs 'stat'
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str81')
				dynamic $boss_din_go_toilet
			end
		end
	end
}
$boss_din_bendover = {
	act 'Лечь грудью на стол':
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossbendover.jpg', func('BurgerTip_strings', 'local_str82')
		if RAND(0,10) <= 8:
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str83')
			dynamic $boss_din_sex
		else
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str84')
			dynamic $boss_din_anal
		end
	end
}
$boss_din_sex = {
	act 'Стонать':
		*clr & cla
		$boy = 'Анатолий'
		dick = 12
		silavag = 0
		pose = 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossfuck.jpg', func('BurgerTip_strings', 'local_str85')
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		if RAND(0,10) >= 3:
			gs 'zz_funcs', 'cum', 'ass'
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str86')
			dynamic $dinBistroWork[PSBBtimes-1]
		else
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str87')
			dynamic $boss_din_anal
		end
	end
}
$boss_din_anal = {
	act 'Расслабить анус':
		*clr & cla
		$boy = 'Анатолий'
		dick = 12
		silavag = 0
		pose = 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossanal.jpg', func('BurgerTip_strings', 'local_str88')
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_dynamic_sex', 'anal_cum'
		dynamic $dinBistroWork[PSBBtimes-1]
	end
}
$boss_din_sex2 = {
	act 'Стонать':
		*clr & cla
		$boy = 'Анатолий'
		dick = 12
		silavag = 0
		pose = 0
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossfuck2.jpg', func('BurgerTip_strings', 'local_str90')
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		if RAND(0,10) >= 3:
			gs 'zz_funcs', 'cum', 'belly'
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str91')
			dynamic $dinBistroWork[PSBBtimes-1]
		else
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str92')
			dynamic $boss_din_anal2
		end
	end
}
$boss_din_anal2 = {
	act 'Расслабить анус':
		*clr & cla
		$boy = 'Анатолий'
		dick = 12
		silavag = 0
		pose = 0
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bossanal2.jpg', func('BurgerTip_strings', 'local_str93')
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_dynamic_sex', 'anal_cum'
		dynamic $dinBistroWork[PSBBtimes-1]
	end
}
$din_Ivan_work = {
	if kompromatLife > 0 and kompromatBlackMail = 0:
		dynamic $compromat_dyn
		gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str95')
		dynamic $din_Ivan_work2
		act 'Промолчать':
			*clr & cla
			kompromatBlackMail = 1
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/qwest/sosed/work5.jpg', func('BurgerTip_strings', 'local_str96')
			dynamic $dinBistroWork[PSBBtimes-1]
			dynamic $din_Ivan_work2
		end
	end
}
$din_Ivan_work2 = {
	act 'Умолять Ивана не показывать эти фотки':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sosed/work5.jpg', func('BurgerTip_strings', 'local_str97')
		act 'Идти с Иваном в его кабинет':
			*clr & cla
			kompromatBlackMail = 2
			gs'stat'
			gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str98')
			act 'Раздеться':
				*clr & cla
				kompromatBlackMail = 2
				gs 'stat'
				gs 'zz_render', '', '', func('BurgerTip_strings', 'local_str99')
				act 'Встать на колени и открыть рот':
					*clr & cla
					kompromatBlackMail = 2
					gs 'zz_funcs', 'cum', 'face'
					boy += 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/sosed/ivanfacial.jpg', func('BurgerTip_strings', 'local_str100')
					dynamic $dinBistroWork[PSBBtimes-1]
				end
			end
			dynamic $din_Ivan_work3
		end
		dynamic $din_Ivan_work3
	end
}
$din_Ivan_work3 = {
	act 'Отказаться':
		*clr & cla
		kompromatBlackMail = 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/work7.jpg', func('BurgerTip_strings', 'local_str101')
		dynamic $dinBistroWork[PSBBtimes-1]
	end
}
$din_Ivan_work4 = {
	act 'Отказаться':
		*clr & cla
		kompromatBlackMail = 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sosed/work7.jpg', func('BurgerTip_strings', 'local_str102')
		act 'Уйти':gt'down'
	end
}