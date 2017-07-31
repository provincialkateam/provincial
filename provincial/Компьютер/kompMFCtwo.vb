if webpopular >= 15 and anus >= 15 and clientask = 89:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str1')
	act 'Показать':
		*clr & cla
		mfcclients = 0
		webpopular += 1
		minut += 2
		if vnesh >= 60:
			tokens += RAND(5,15)
		else
			tokens += RAND(5,10)
		end
		if webpopular < 15:
			tokens += RAND(5,10)
		elseif webpopular >= 15 and webpopular < 35:
			tokens += RAND(10,15)
		elseif webpopular >= 35 and webpopular < 75:
			tokens += RAND(15,20)
		elseif webpopular >= 75:
			tokens += RAND(20,30)
		end
		gs 'stat'
		if anus < 25 and backmfc = 0:
			'<center><img src="images/camwhore/camwhore54.jpg"></center>'
		elseif anus >= 25 and vagina >= 25 and backmfc = 0:
			'<center><img src="images/camwhore/camwhore56.jpg"></center>'
		elseif anus >= 25 and backmfc = 0:
			'<center><img src="images/camwhore/camwhore55.jpg"></center>'
		elseif backmfc = 1:
			'<center><img src="images/camwhore/camwhore57.jpg"></center>'
		end
		if analplugIN = 1:
			gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str2')
		else
			gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str3')
		end
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		webpopular -= 1
		gt'Komp','waitclients'
	end
end
if webpopular < 50 and clientask = 88:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str4')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		webpopular += 1
		dom -= 1
		minut += 2
		horny -= RAND(5,10)
		if vnesh >= 60:
			tokens += RAND(0,5)
		else
			tokens += RAND(5,10)
		end
		if webpopular < 25:
			tokens += RAND(5,10)
		else
			tokens += RAND(10,15)
		end
		gs 'stat'
		if backmfc = 1:
			backmfc = 0
			gs 'zz_render', '', 'images/camwhore/camwhore58.jpg', func('kompMFCtwo_strings', 'local_str5')
		else
			gs 'zz_render', '', 'images/camwhore/camwhore58.jpg', func('kompMFCtwo_strings', 'local_str6')
		end
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		webpopular -= 1
		gt'Komp','waitclients'
	end
end
if webpopular >= 50 and vagina >= 35 and clientask = 87:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str7')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		webpopular += 1
		dom -= 2
		minut += 2
		horny += RAND(5,10)
		if vnesh >= 60:
			tokens += RAND(50,100)
		else
			tokens += RAND(0,50)
		end
		if webpopular < 75:
			tokens += RAND(50,100)
		else
			tokens += RAND(100,200)
		end
		gs 'stat'
		gs 'zz_render', '', 'images/camwhore/camwhore59.jpg', func('kompMFCtwo_strings', 'local_str8')
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		gt'Komp','waitclients'
	end
end
if webpopular >= 35 and vagina >= 25 and alko >= 8 and clientask = 86:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str9')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		vagina += 1
		webpopular += 2
		dom -= 1
		minut += 2
		horny -= RAND(10,20)
		gs 'stat'
		gs 'zz_render', '', 'images/camwhore/camwhore60.jpg', func('kompMFCtwo_strings', 'local_str10')
		act'Далее':gt'Komp','waitclients'
	end
end
if webpopular >= 50 and vagina > 0 and anus > 0 and alko >= 8 and dom <= -50 and clientask = 85:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str11')
	if cumpussy > 0:
		act 'Сделать':
			*clr & cla
			mfcclients = 0
			minut += 2
			dom += 1
			if vnesh >= 60:
				tokens += RAND(75,150)
			else
				tokens += RAND(50,100)
			end
			if webpopular < 75:
				tokens += RAND(75,150)
			else
				tokens += RAND(50,100)
			end
			gs 'stat'
			gs 'zz_render', '', 'images/camwhore/camwhore73.jpg', func('kompMFCtwo_strings', 'local_str12')
			act'Далее':gt'Komp','waitclients'
		end
	else
		act 'Поиграть с трусиками':
			*clr & cla
			mfcclients = 0
			webpopular += 2
			dom -= 2
			minut += 5
			horny -= RAND(10,20)
			if vnesh >= 60:
				tokens += RAND(75,150)
			else
				tokens += RAND(50,100)
			end
			if webpopular < 75:
				tokens += RAND(75,150)
			else
				tokens += RAND(50,100)
			end
			gs'stat'
			if anus > vagina:
				'<center><img src="images/camwhore/camwhore61.jpg"></center>'
				if backmfc = 1:
					agape = 1
					backmfc = 0
					gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str13')
				else
					gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str14')
				end
			else
				if backmfc = 1:
					backmfc = 0
					vgape = 1
					gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str15')
				else
					gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str16')
				end
			end
			act'Далее':gt'Komp','waitclients'
		end
		if body['tits'] >= 1:
			act 'Поиграть с грудью':
				*clr & cla
				mfcclients = 0
				webpopular += 2
				if alko >= 10:
					nippain = 2
				else
					nippain = 1
				end
				dom -= 2
				minut += 10
				horny -= RAND(10,20)
				if vnesh >= 60:
					tokens += RAND(75,150)
				else
					tokens += RAND(50,100)
				end
				if webpopular < 75:
					tokens += RAND(75,150)
				else
					tokens += RAND(50,100)
				end
				gs'stat'
				if topmfc = 1:
					topmfc = 0
				end
				if alko >= 10:
					gs 'zz_render', '', 'images/camwhore/camwhore63.jpg', func('kompMFCtwo_strings', 'local_str17')
				else
					if body['tits'] = 2:
						'<center><img src="images/camwhore/camwhore'+iif(pirsF = 1,64,63)+'.jpg"></center>'
					elseif body['tits'] = 3:
						'<center><img src="images/camwhore/camwhore65.jpg"></center>'
					elseif body['tits'] = 4:
						'<center><img src="images/camwhore/camwhore66.jpg"></center>'
					elseif body['tits'] = 5:
						'<center><img src="images/camwhore/camwhore'+iif(pirsF = 1,68,67)+'.jpg"></center>'
					elseif body['tits'] >= 6:
						'<center><img src="images/camwhore/camwhore69.jpg"></center>'
					end
					gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str18')
				end
				act'Далее':gt'Komp','waitclients'
			end
		else
			act 'Поиграть с киской':
				*clr & cla
				mfcclients = 0
				webpopular += 2
				dom -= 2
				minut += 10
				horny -= RAND(10,20)
				tokens += iif(vnesh >= 60,RAND(75,150),RAND(50,100))
				tokens += iif(webpopular < 75,RAND(75,150),RAND(50,100))
				gs'stat'
				if backmfc = 1:
					backmfc = 0
				end
				if vagina < 15 and anus < 15:
					vgape = 3
					gs 'zz_render', '', 'images/camwhore/camwhore70.jpg', func('kompMFCtwo_strings', 'local_str19')
				elseif vagina >= 15 and anus < 15:
					vgape = 2
					vagina += 1
					gs 'zz_render', '', 'images/camwhore/camwhore71.jpg', func('kompMFCtwo_strings', 'local_str20')
				elseif vagina >= 15 and anus >= 15
					vagina += 1
					anus += 1
					vgape = 2
					agape = 2
					gs 'zz_render', '', 'images/camwhore/camwhore72.jpg', func('kompMFCtwo_strings', 'local_str21')
				end
				act'Далее':gt'Komp','waitclients'
			end
		end
	end
end
if backmfc = 0 and webpopular >= 25 and vagina >= 30 and anus >= 30 and alko >= 8 and clientask = 84:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str22')
	act 'Выполнить':
		*clr & cla
		mfcclients = 0
		webpopular += 2
		dom -= 2
		minut += 10
		horny -= RAND(10,20)
		if vagina >= anus:
			vagina += 1
			vgape = 2
		else
			anus += 1
			agape = 2
		end
		if vnesh >= 60:
			tokens += RAND(100,150)
		else
			tokens += RAND(50,75)
		end
		if webpopular < 15:
			tokens += RAND(25,50)
		elseif webpopular >= 15 and webpopular < 35:
			tokens += RAND(50,75)
		elseif webpopular >= 35 and webpopular < 75:
			tokens += RAND(75,150)
		elseif webpopular >= 75:
			tokens += RAND(100,300)
		end
		gs 'stat'
		if vagina >= anus:
			gs 'zz_render', '', 'images/camwhore/camwhore75.jpg', func('kompMFCtwo_strings', 'local_str23')
		else
			gs 'zz_render', '', 'images/camwhore/camwhore76.jpg', func('kompMFCtwo_strings', 'local_str24')
		end
		act'Далее':gt'Komp','waitclients'
	end
end
if backmfc = 0 and vagina > 20 and clientask = 83:
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str25')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		vagina += 1
		webpopular += 1
		minut += 5
		vgape += 2
		horny = RAND(10,20)
		if vnesh >= 60:
			tokens += RAND(50,150)
		else
			tokens += RAND(25,75)
		end
		if webpopular < 15:
			tokens += RAND(25,50)
		elseif webpopular >= 15 and webpopular < 35:
			tokens += RAND(50,75)
		elseif webpopular >= 35 and webpopular < 75:
			tokens += RAND(75,150)
		elseif webpopular >= 75:
			tokens += RAND(150,250)
		end
		gs 'stat'
		gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str26')
		if horny >= 95:
			orgasm += 1
			horny = 0
			manna = 100
			gs 'zz_render', '', 'images/camwhore/camwhore78.jpg', func('kompMFCtwo_strings', 'local_str27')
		else
			gs 'zz_render', '', 'images/camwhore/camwhore77.jpg', func('kompMFCtwo_strings', 'local_str28')
		end
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		webpopular -= 1
		gt'Komp','waitclients'
	end
end
if webpopular > 25 and backmfc = 0 and dom <= -25 and vagina > 10 and prezik > 0 and clientask = 82:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str29')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		webpopular += 2
		minut += 10
		vgape = 3
		if vnesh >= 60:
			tokens += RAND(100,150)
		else
			tokens += RAND(50,100)
		end
		if webpopular < 15:
			tokens += RAND(50,100)
		elseif webpopular >= 15 and webpopular < 35:
			tokens += RAND(100,150)
		elseif webpopular >= 35 and webpopular < 75:
			tokens += RAND(150,200)
		elseif webpopular >= 75:
			tokens += RAND(200,300)
		end
		gs 'stat'
		gs 'zz_render', '', 'images/camwhore/camwhore81.jpg', func('kompMFCtwo_strings', 'local_str30')
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		webpopular -= 1
		gt'Komp','waitclients'
	end
end
if backmfc = 0 and webpopular >= 50 and anus > 25 and clientask = 81:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str31')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		webpopular += 2
		minut += 5
		anus += 1
		agape = 2
		if vnesh >= 60:
			tokens += RAND(100,150)
		else
			tokens += RAND(50,100)
		end
		if webpopular < 15:
			tokens += RAND(50,100)
		elseif webpopular >= 15 and webpopular < 35:
			tokens += RAND(100,150)
		elseif webpopular >= 35 and webpopular < 75:
			tokens += RAND(150,200)
		elseif webpopular >= 75:
			tokens += RAND(200,300)
		end
		gs 'stat'
		gs 'zz_render', '', 'images/camwhore/camwhore82,'+rand(0,9)+'.jpg', func('kompMFCtwo_strings', 'local_str32')
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		webpopular -= 1
		gt'Komp','waitclients'
	end
end
if backmfc = 0 and webpopular >= 50 and anus > 10 and vagina > 10 and dom <= -50 and alko >= 6 and clientask = 80:
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', '', func('kompMFCtwo_strings', 'local_str33')
	act 'Сделать':
		*clr & cla
		mfcclients = 0
		webpopular += 5
		minut += 15
		agape = 3
		vgape = 3
		if vnesh >= 60:
			tokens += RAND(500,1000)
		else
			tokens += RAND(250,500)
		end
		if webpopular < 15:
			tokens += RAND(250,500)
		elseif webpopular >= 15 and webpopular < 35:
			tokens += RAND(250,750)
		elseif webpopular >= 35 and webpopular < 75:
			tokens += RAND(500,750)
		elseif webpopular >= 75:
			tokens += RAND(500,100)
		end
		gs 'stat'
		gs 'zz_render', '', 'images/camwhore/camwhore83.jpg', func('kompMFCtwo_strings', 'local_str34')
		act'Далее':gt'Komp','waitclients'
	end
	act 'Игнорировать':
		*clr & cla
		webpopular -= 1
		gt'Komp','waitclients'
	end
end