if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	$metkaSex = $ARGS[0]
	$locSex = $CURLOC
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'time'
	gs 'zz_render','Проститутка','images/pic/park2'
	if hour >= 16 and hour <= 23:
		if whoreQW = 2:
			gs 'zz_render', '', '', func('Prostitute_strings', 'local_str1')
		elseif whoreQW = 1:
			gs 'zz_render', '', '', func('Prostitute_strings', 'local_str2')
			act 'Поговорить':
				cla
				whoreQW = 2
				gs 'zz_render', '', '', func('Prostitute_strings', 'local_str3')
				act 'Отойти':gt'prostitute','start'
			end
		elseif whoreQW = 0:
			gs 'zz_render', '', '', func('Prostitute_strings', 'local_str4')
			act 'Да пошла ты!': gt 'zz_fight', 4
			act 'А как стать одной из ваших?':
				cla
				gs 'zz_render', '', '', func('Prostitute_strings', 'local_str5')
				act 'Отойти':gt'prostitute','start'
				act 'Я согласна':
					cla
					whoreQW = 2
					gs 'zz_render', '', '', func('Prostitute_strings', 'local_str6')
					act 'Отойти':gt'prostitute','start'
				end
			end
		end
		if whoreQW > 1 and func('zz_clothing','get_group') = 12 and son => 0:
			act 'Стоять на панели 15 мин':
				cla
				gs'stat'
				minut += 10
				prosrand = RAND(0,(vnesh+hour))
				if prosrand < 20:
					gs 'zz_render', '', '', func('Prostitute_strings', 'local_str7')
					act 'Уйти':gt'prostitute','start'
				elseif prosrand >= 20:
					gs 'zz_render', '', '', func('Prostitute_strings', 'local_str8')
					proseventrand = rand(0,110)
					if proseventrand <= 5:
						cla
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str9')
						if money >= 1000:
							act 'Отдать деньги':
								cla
								money -= 1000
								gs 'zz_render', '', '', func('Prostitute_strings', 'local_str10')
								act 'Отойти':gt'prostitute','start'
							end
						else
							act 'Я еще не заработала столько':
								cla
								money = 0
								gs 'zz_render', '', '', func('Prostitute_strings', 'local_str11')
								act 'Отрабатывать':
									$boy = 'Бандит'
									dick = RAND(18,21)
									gt'blowPR','start'
								end
							end
						end
						act 'Да пошел ты!': gt 'zz_fight', 3
					elseif proseventrand > 5 and proseventrand <= 30:
						klient_needs = 0
						prosti = 0
						KlientMON = RAND(1,10)
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str12')
					elseif proseventrand > 30 and proseventrand <= 50:
						klient_needs = 1
						prosti = 0
						KlientMON = RAND(3,25)
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str13')
					elseif proseventrand > 50 and proseventrand <= 70:
						klient_needs = 2
						prosti = 0
						KlientMON = RAND(5,40)
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str14')
					elseif proseventrand > 70 and proseventrand <= 80:
						klient_needs = 3
						prosti = 0
						KlientMON = RAND(5,40)
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str15')
					elseif proseventrand > 80 and proseventrand <= 90:
						klient_needs = 4
						prosti = 0
						KlientMON = RAND(5,40)
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str16')
					elseif proseventrand > 90 and proseventrand <= 100:
						klient_needs = 5
						prosti = 0
						KlientMON = RAND(5,40)
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str17')
					end
					if proseventrand > 0 and proseventrand <= 110:
						klienVNPR = RAND(0,30)
						act 'Уйти':gt'prostitute','start'
						if ProsMoney > 0:
							act '<<ProsMoney*100>> рублей':
								*clr & cla
								dynamic $universalklient
							end
						end
						act 'Назначить цену':
							*clr & cla
							gs'stat'
							ProsMoney = input("Назначте цену в сотнях")
							if ProsMoney < 1:
								gs 'zz_render', '', '', func('Prostitute_strings', 'local_str18')
								act 'Уйти':gt'prostitute','start'
							else
								dynamic $universalklient
							end
						end
					elseif proseventrand > 95:
						gs 'zz_render', '', '', func('Prostitute_strings', 'local_str19')
						if money >= 500:
							act 'Отдать деньги':
								cla
								money -= 500
								gs 'zz_render', '', '', func('Prostitute_strings', 'local_str20')
								act 'Отойти':gt'prostitute','start'
							end
						else
							act 'Я еще не заработала столько':
								cla
								money = 0
								gs 'zz_render', '', '', func('Prostitute_strings', 'local_str21')
								act 'Отойти':gt'prostitute','start'
							end
						end
						act 'Да пошла ты!': gt 'zz_fight', 5
					end
				end
			end
		end
	end
	act 'Уйти':
		cla
		minut += 5
		prosta = 0
		gt 'zz_park'
	end
end