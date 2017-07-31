if $ARGS[0] = 'start':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Общежитие</font></b></center>'
	gs 'zz_render', '', 'images/pic/dorm.jpg', func('dorm_strings', 'local_str1')
	if student = 1:
		act 'Зайти':
			cla
			minut += 5
			gt 'dorm','korr'
		end
	else
		act 'Попробовать зайти':
			cla
			minut += 5
			gs 'zz_render', '', '', func('dorm_strings', 'local_str2')
			act 'Уйти':gt'down'
			if afra > 0:
				act 'Я к Демаркусу':
					cla
					*clr
					gs 'zz_render', '', '', func('dorm_strings', 'local_str3')
					act 'Войти': gt'dorm','korr'
				end
			end
			if gosh > 0:
				act 'Я к Гоше':
					cla
					*clr
					gs 'zz_render', '', '', func('dorm_strings', 'local_str4')
					act 'Войти': gt'dorm','korr'
				end
			end
		end
	end
	act 'Выйти':
		cla
		minut += 5
		gt'down'
	end
end
if $ARGS[0] = 'korr':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	gs 'stat'
	'<center><b>Общежитие</b></center>'
	gs 'zz_render', '', 'images/img/centr/obkorr.jpg', func('dorm_strings', 'local_str5')
	act 'Уйти':
		cla
		minut += 5
		gt'down'
	end
	if student > 0:
		act 'Ваша комната':gt'obroom','start'
		act 'На общую кухню':
			minut += 5
			gt'obkitchen'
		end
		act 'В общую ванную':
			minut += 5
			obdysh = 1
			gt 'zz_bathroom', 'start'
		end
	end
	if student > 0 and week = 5 and hour > 18 and hour < 23:
		gs 'zz_render', '', '', func('dorm_strings', 'local_str6')
		act 'На вечеринку':gt'vecher','start'
	end
	if afra > 0 and hour < 22 and hour >= 7:
		act 'Комната Демаркуса':
			cla
			if RAND(1,20) = 1:
				minut += 5
				gs'stat'
				gs 'zz_render', '', '', func('dorm_strings', 'local_str7')
				act 'Уйти':gt'dorm','korr'
			else
				*clr
				gs 'zz_render', '', '', func('dorm_strings', 'local_str8')
				act 'Выпить с Демаркусом':
					*clr & cla
					minut += 120
					gs'stat'
					gs 'zz_render', '', '', func('dorm_strings', 'local_str9')
					afrand = RAND(0,30)
					if afrand <=10:
						if demarkus = 0:guy += 1 & demarkus = 1
						sex += 1
						gs 'zz_funcs', 'cum', 'ass'
						horny = 0
						afra += 1
						orgasm += 1
						vagina += 1
						if rand1<10:'<center><img src="images/pics2/afra0.jpg"></center>'
						if rand1>=10:'<center><img src="images/nigma/city/nigga/nigga1,'+rand(0,9)+'.gif"></center>'
						gs 'zz_render', '', '', func('dorm_strings', 'local_str10')
						act 'Уйти':gt'dorm','korr'
					elseif afrand >10 and afrand<=20:
						sex += 1
						anal += 1
						horny = 0
						afra += 1
						orgasm += 1
						anus += 1
						if rand1<10:'<center><img src="images/pics2/afra4.jpg"></center>'
						if rand1>=10:'<center><img src="images/nigma/city/nigga/nigga3,'+rand(0,8)+'.gif"></center>'
						gs 'zz_render', '', '', func('dorm_strings', 'local_str11')
						act 'Уйти':gt'dorm','korr'
					elseif afrand > 20:
						throat += 1
						sex += 1
						gs 'zz_funcs', 'cum', 'face'
						horny = 0
						afra += 1
						orgasm += 1
						VAF += 1
						if rand1<10:'<center><img src="images/pics2/afra41.jpg"></center>'
						if rand1>=10:'<center><img src="images/nigma/city/nigga/nigga0,'+rand(0,8)+'.gif"></center>'
						gs 'zz_render', '', '', func('dorm_strings', 'local_str12')
						act 'Уйти':gt'dorm','korr'
					end
				end
			end
		end
	end
	if afra > 10 and hour >= 8 and hour < 22:
		act 'Комната африканских студентов':
			*clr & cla
			minut += 5
			if RAND(1,2) = 1:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str13')
				act 'Уйти':
					minut += 5
					gt'dorm','korr'
				end
			else
				minut += 120
				if afragang = 0: afragang = 1
				guy += 6
				afrand = RAND(1,afra)
				throat += 1
				sex += 1
				gang += 1
				anal += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_funcs', 'cum', 'ass'
				horny = 0
				afra += 1
				vagina += 1
				orgasm += 1
				gs'stat'
				if afrand > 13:
					'<center><img src="images/nigma/city/nigga/nigga.orgy1,'+rand(0,4)+'.gif"></center>'
				else
					'<center><img src="images/pics2/afra'+afrand+'.jpg"></center>'
				end
				gs 'zz_render', '', '', func('dorm_strings', 'local_str14')
				gs 'zz_render', '', '', func('dorm_strings', 'local_str15')
			end
		end
	end
	if afra > 30 and afragang = 1 and hour >= 8 and hour < 22:
		act 'Комната Кендры':
			*clr & cla
			minut += 15
			gs'stat'
			if kendra = 5:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str16')
				act 'Раздеться':
					cla
					sex += 1
					lesb += 1
					horny = 0
					orgasm += 1
					vagina += 1
					gs'stat'
					gs 'zz_render', '', '', func('dorm_strings', 'local_str17')
					'<center><img src="images/pics2/kendraStrap'+RAND(1,5)+'.jpg"></center>'
					act 'Уйти':gt'dorm','korr'
				end
			elseif kendra = 4:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str18')
				act 'Уйти':gt'dorm','korr'
				act 'Сделать татуировку':
					cla
					minut += 60
					kendra = 5
					gs'stat'
					if tattoo['lip'] = 0:
						if RAND(1,2) = 1:
							tattoo['lip'] = 1
							'<center><img src="images/picb/tattoo/lip/0.jpg"></center>'
						else
							tattoo['lip'] = 3
							'<center><img src="images/picb/tattoo/lip/2.jpg"></center>'
						end
						gs 'zz_render', '', '', func('dorm_strings', 'local_str19')
					elseif tattoo['lip'] = 1 or tattoo['lip'] = 3:
						gs 'zz_render', '', '', func('dorm_strings', 'local_str20')
					elseif tattoo['lip'] > 1 and tattoo['lip'] ! 3:
						gs 'zz_render', '', '', func('dorm_strings', 'local_str21')
					end
					act 'Вылизать у Кендры':
						cla
						sex += 1
						lesb += 1
						horny = 0
						orgasm += 1
						vagina += 1
						gs 'zz_render', '', 'images/pics2/kendraStrap.jpg', func('dorm_strings', 'local_str22')
						act 'Уйти':gt'dorm','korr'
					end
				end
			elseif kendra = 3:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str23')
				act 'Уйти':gt'dorm','korr'
				act 'Сделать татуировку':
					cla
					minut += 60
					kendra = 4
					gs'stat'
					if tattoo['vag'] = 3 or tattoo['vag']=6:
						gs 'zz_render', '', 'images/picb/tattoo/vag/2.jpg', func('dorm_strings', 'local_str24')
					elseif tattoo['vag'] = 0:
						gs 'zz_render', '', 'images/picb/tattoo/vag/2.jpg', func('dorm_strings', 'local_str25')
					end
					if tattoo['vag'] > 0 and (tattoo['vag'] ! 3 or tattoo['vag']!6):
						tattoo['vag'] = 3
						gs 'zz_render', '', 'images/picb/tattoo/vag/2.jpg', func('dorm_strings', 'local_str26')
					end
					act 'Вылизать у Кендры':
						cla
						*clr
						lesb += 1
						horny += 20
						gs 'zz_render', '', 'images/pics2/kendra3.jpg', func('dorm_strings', 'local_str27')
						act 'Уйти':gt'dorm','korr'
					end
				end
			elseif kendra = 2:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str28')
				act 'Уйти':gt'dorm','korr'
				act 'Сделать татуировку':
					cla
					minut += 60
					kendra = 3
					gs'stat'
					if tattoo['shoulder'] = 4:
						gs 'zz_render', '', 'images/picb/tattoo/shoulder/3.jpg', func('dorm_strings', 'local_str29')
					elseif tattoo['shoulder'] = 0:
						tattoo['shoulder'] = 4
						gs 'zz_render', '', 'images/picb/tattoo/shoulder/3.jpg', func('dorm_strings', 'local_str30')
					elseif tattoo['shoulder'] > 0 and tattoo['shoulder'] ! 4:
						tattoo['shoulder'] = 4
						gs 'zz_render', '', 'images/picb/tattoo/shoulder/3.jpg', func('dorm_strings', 'local_str31')
					end
					act 'Вылизать у Кендры':
						cla
						*clr
						lesb += 1
						horny += 20
						gs 'zz_render', '', 'images/pics2/kendra2.jpg', func('dorm_strings', 'local_str32')
						act 'Уйти':gt'dorm','korr'
					end
				end
			elseif kendra = 1:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str33')
				act 'Уйти':gt'dorm','korr'
				act 'Сделать татуировку':
					cla
					*clr
					minut += 60
					kendra = 2
					gs'stat'
					if tattoo['leg'] = 1 or tattoo['leg'] = 2:
						gs 'zz_render', '', 'images/picb/tattoo/leg/1.jpg', func('dorm_strings', 'local_str34')
					elseif tattoo['leg'] = 0:
						tattoo['leg'] = 2
						gs 'zz_render', '', 'images/picb/tattoo/leg/1.jpg', func('dorm_strings', 'local_str35')
					elseif tattoo['leg'] > 2:
						tattoo['leg'] = 2
						gs 'zz_render', '', 'images/picb/tattoo/leg/1.jpg', func('dorm_strings', 'local_str36')
					end
					act 'Вылизать у Кендры':
						cla
						*clr
						repa = 9
						lesb += 1
						if kendrasex = 0:kendrasex = 1 & girl += 1
						horny += 20
						gs 'zz_render', '', 'images/pics2/kendra.jpg', func('dorm_strings', 'local_str37')
						act 'Уйти':gt'dorm','korr'
					end
				end
			elseif kendra = 0:
				gs 'zz_render', '', '', func('dorm_strings', 'local_str38')
				act 'Уйти':gt'dorm','korr'
				act 'Сделать татуировку':
					cla
					minut += 60
					kendra = 1
					gs'stat'
					if tattoo['waist'] = 4:
						gs 'zz_render', '', 'images/picb/tattoo/waist/3.jpg', func('dorm_strings', 'local_str39')
					elseif tattoo['waist'] = 0:
						tattoo['waist'] = 4
						gs 'zz_render', '', 'images/picb/tattoo/waist3.jpg', func('dorm_strings', 'local_str40')
					elseif tattoo['waist'] > 0 and tattoo['waist'] ! 4:
						tattoo['waist'] = 4
						gs 'zz_render', '', 'images/picb/tattoo/waist/3.jpg', func('dorm_strings', 'local_str41')
					end
					act 'Вылизать у Кендры':
						cla
						*clr
						if kendrasex = 0:kendrasex = 1 & girl += 1
						lesb += 1
						horny += 20
						gs 'zz_render', '', 'images/pics2/afra30.jpg', func('dorm_strings', 'local_str42')
						act 'Уйти':gt'dorm','korr'
					end
				end
			end
		end
	end
	if gosh > 0 and hour >= 8 and hour < 22:
		act 'Комната Гоши':
			cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', '', func('dorm_strings', 'local_str43')
			act 'Идти в комнату Гоши':
				cla
				minut += 60
				if goshsex = 0:goshsex = 1 & guy += 1
				gs'stat'
				gs 'zz_render', '', '', func('dorm_strings', 'local_str44')
				srand = RAND(1,3)
				if srand = 1:
					cla
					*clr
					sex += 1
					gs 'zz_funcs', 'cum', 'ass'
					horny = 0
					orgasm += 1
					vagina += 1
					gs 'zz_render','','common/sex/sex/'+rand(0,4)+'.gif', func('dorm_strings', 'local_str45')
					act 'Уйти':gt'dorm','korr'
				elseif srand = 2:
					cla
					*clr
					throat += 1
					sex += 1
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render','','common/sex/bj/'+rand(0,4)+'.gif', func('dorm_strings', 'local_str46')
					act 'Уйти':gt'dorm','korr'
				elseif srand = 3:
					cla
					*clr
					sex += 1
					anal += 1
					orgasm += 1
					anus += 1
					gs 'zz_render','','common/sex/anal/'+rand(0,4)+'.gif',func('dorm_strings', 'local_str47')
					act 'Уйти':gt'dorm','korr'
				end
			end
			act 'Пойти погулять с Гошей':
				cla
				gosh += 1
				minut += 120
				gs'stat'
				gs 'zz_render', '', '', func('dorm_strings', 'local_str48')
				act 'Уйти':gt'dorm','korr'
			end
		end
	end
end