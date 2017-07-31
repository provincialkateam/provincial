gs 'stat'
gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str1')
if dom >= 20: act 'Драка': gt 'zz_fight',6
randhumiliation = iif(zverhumiliation >= 16,16,zverhumiliation)
if randhumiliation = 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str2')
	act 'Сосать дилдо':
		*clr & cla
		if zverhumiliation < 6:zverhumiliation += 1
		dilbj += 1
		dom -= 1
		minut += RAND(5,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj.jpg', func('gKristinaZv_strings', 'local_str3')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 1:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str4')
	act 'Сосать дилдо':
		*clr & cla
		if zverhumiliation < 6:zverhumiliation += 1
		dilbj += 1
		dom -= 1
		minut += RAND(5,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj2.jpg', func('gKristinaZv_strings', 'local_str5')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 2:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str6')
	act 'Сосать дилдо':
		*clr & cla
		if zverhumiliation < 6:zverhumiliation += 1
		dilbj += 1
		dom -= 1
		minut += RAND(5,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj3.jpg', func('gKristinaZv_strings', 'local_str7')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 3:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str8')
	act 'Сосать дилдо':
		*clr & cla
		if zverhumiliation < 6:zverhumiliation += 1
		dilbj += 1
		dom -= 1
		minut += RAND(5,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj4.jpg', func('gKristinaZv_strings', 'local_str9')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 4:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str10')
	act 'Сосать дилдо':
		*clr & cla
		if zverhumiliation < 6:zverhumiliation += 1
		dilbj += 1
		dom -= 1
		minut += RAND(5,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj5.jpg', func('gKristinaZv_strings', 'local_str11')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 5:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str12')
	act 'Сосать':
		*clr & cla
		if zverhumiliation < 6:zverhumiliation += 1
		dilbj += 1
		dom -= 1
		minut += RAND(5,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj6.jpg', func('gKristinaZv_strings', 'local_str13')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 6:
	*clr & cla
	gs 'zz_render', '', 'images/qwest/alter/zver/dildobj7.jpg', func('gKristinaZv_strings', 'local_str14')
	act 'Далее':
		*clr & cla
		dom -= 1
		minut += RAND(2,5)
		gs 'stat'
		if vagina = 0:
			*clr & cla
			if anus < 15:
				anus += 1
				if anus < 5:agape = 1
				minut += RAND(5,10)
				horny = RAND(20,40)
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/zver/dildobj9.jpg', func('gKristinaZv_strings', 'local_str15')
			elseif anus >= 15 and anus < 25:
				anus += 1
				if anus < 20:agape = 2
				if anus >= 20:agape = 1
				minut += RAND(5,10)
				horny = RAND(30,50)
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/zver/dildobj10.jpg', func('gKristinaZv_strings', 'local_str16')
			else
				horny = RAND(50,75)
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/zver/dildobj11.jpg', func('gKristinaZv_strings', 'local_str17')
			end
			act 'Уйти':gt'gschool'
		else
			if zverhumiliation < 7:zverhumiliation += 1
			vagina += 1
			if vagina < 10:vgape = 2 & horny = RAND(5,15)
			if vagina >= 10 and vagina < 15:vgape = 1 & horny = RAND(25,35)
			if vagina >= 15:horny = RAND(40,75)
			minut += RAND(5,10)
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/zver/dildobj12.jpg', func('gKristinaZv_strings', 'local_str18')
			if horny >= 100:
				nippain = 1
				horny -= RAND(15,40)
				dom += 1
				gs 'stat'
				gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str19')
			end
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str20')
			act 'Уйти':gt'gschool'
		end
	end
elseif randhumiliation = 7 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str21')
	act 'Запрыгнуть':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:vgape = 2 & horny = RAND(5,15)
		if vagina >= 10 and vagina < 15:vgape = 1 & horny = RAND(25,35)
		if vagina >= 15:horny = RAND(40,75)
		minut += RAND(10,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj13.jpg', func('gKristinaZv_strings', 'local_str22')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,40)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str23')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str24')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 8 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str25')
	act 'Запрыгнуть':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:vgape = 2 & horny = RAND(5,15)
		if vagina >= 10 and vagina < 15:vgape = 1 & horny = RAND(25,35)
		if vagina >= 15:horny = RAND(40,75)
		minut += RAND(10,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj14.jpg', func('gKristinaZv_strings', 'local_str26')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,40)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str27')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str28')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 9 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str29')
	act 'Работать':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:vgape = 2 & horny = RAND(5,15)
		if vagina >= 10 and vagina < 15:vgape = 1 & horny = RAND(25,35)
		if vagina >= 15:horny = RAND(40,75)
		minut += RAND(10,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj15.jpg', func('gKristinaZv_strings', 'local_str30')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,40)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str31')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str32')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 10 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str33')
	act 'Работать':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:vgape = 2 & horny = RAND(5,15)
		if vagina >= 10 and vagina < 15:vgape = 1 & horny = RAND(25,35)
		if vagina >= 15:horny = RAND(40,75)
		minut += RAND(10,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj16.jpg', func('gKristinaZv_strings', 'local_str34')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,40)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str35')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str36')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 11 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str37')
	act 'Взять расческу':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:horny = RAND(40,60)
		if vagina >= 10 and vagina < 15:horny = RAND(30,50)
		if vagina >= 15:horny = RAND(20,40)
		minut += RAND(10,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj17.jpg', func('gKristinaZv_strings', 'local_str38')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,40)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str39')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str40')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 12 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str41')
	act 'Работать вручную':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:vgape = 1 & horny = RAND(50,70)
		if vagina >= 10 and vagina < 15:horny = RAND(40,60)
		if vagina >= 15:horny = RAND(30,50)
		minut += RAND(10,15)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj18.jpg', func('gKristinaZv_strings', 'local_str42')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,30)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str43')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str44')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 13 and vagina > 0:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str45')
	act 'Засовывать':
		*clr & cla
		if zverhumiliation < 14:zverhumiliation += 1
		dom -= 1
		if vagina < 10:vgape = 3 & horny = RAND(10,20)
		if vagina >= 10 and vagina < 15:vgape = 2 & horny = RAND(30,50)
		if vagina >= 15:vgape = 1 & horny = RAND(50,75)
		minut += RAND(15,20)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj19,'+rand(0,1)+'.jpg', func('gKristinaZv_strings', 'local_str46')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,30)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str47')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str48')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 14:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str49')
	act 'Работать язычком':
		*clr & cla
		if zverhumiliation < 20:zverhumiliation += 1
		dom -= 1
		horny = RAND(10,20)
		minut += RAND(15,20)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj20,'+rand(0,1)+'.jpg', func('gKristinaZv_strings', 'local_str50')
		if horny >= 100:
			nippain = 1
			horny -= RAND(15,30)
			dom += 1
			gs 'stat'
			gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str51')
		end
		gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str52')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 15:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str53')
	act 'На колени':
		*clr & cla
		if zverhumiliation < 30:zverhumiliation += 1
		dom -= 2
		horny = 0
		minut += 5
		if mop > 1:mop = 0
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/zver/dildobj21.jpg', func('gKristinaZv_strings', 'local_str54')
		act 'Уйти':gt'gschool'
	end
elseif randhumiliation = 16:
	gs 'zz_render', '', '', func('gKristinaZv_strings', 'local_str55')
	act 'Уйти':gt'gschool'
end