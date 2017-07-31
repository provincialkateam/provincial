$sexloc = $CURLOC
cla
*clr
gs'stat'
'<center><b>Бильярдная</b></center>'
gs 'zz_render', '', 'images/img/centr/bil.jpg', func('billiard_strings', 'local_str1')
act 'Уйти':gt'torgcentr'
if hour >= 8 and hour <= 20:
	if money >= 250:
		act 'Сыграть 250 руб час':
			money -= 250
			minut += 60
			billvar = 0
			billiardnav += RAND(0,3)
			billrand = RAND(0,5)
			if billrand = 0:
				cla
				gs 'zz_render', '', '', func('billiard_strings', 'local_str2')
				if money >= 1000:act 'Играть на деньги, ставка 1000':gt'billiard','randwin'
				if DOM > 20 and strapon = 1:
					act 'Играем на твою задницу, проиграю трахнешь меня':
						billvar = 1
						gt'billiard','randwin'
					end
				end
				act 'Уйти':gt'billiard'
			elseif billrand = 1:
				cla
				gs 'zz_render', '', '', func('billiard_strings', 'local_str3')
				if money >= 1000:act 'Играть на деньги, ставка 1000':gt'billiard','randwin'
				if DOM > 20 and strapon = 1:
					act 'Играем на ваши задницы, проиграю трахните меня':
						billvar = 2
						gt'billiard','randwin'
					end
				end
				act 'Уйти':gt'billiard'
			elseif billrand > 1:
				cla
				gs 'zz_render', '', '', func('billiard_strings', 'local_str4')
				act 'Уйти':gt'billiard'
			end
		end
	end
	if money >= 300:
		act 'Сыграть на деньги':
			money -= 300
			minut += 60
			billvar = 3
			gt'billiard','randwin'
		end
	end
end
if $ARGS[0] = 'randwin':
	cla
	if billiardnav < 10:
		billwin = RAND(0,10)
	elseif billiardnav >= 90:
		billwin = RAND(0,28)
	else
		billwin = RAND(0,billiardnav/5+10)
	end
	if billwin > 10 and billvar = 0:
		money += 1000
		gs 'zz_render', '', '', func('billiard_strings', 'local_str5')
		act 'Уйти':gt'billiard'
	elseif billwin > 10 and billvar = 1:
		*clr
		DOM += 5
		gs 'zz_render', '', 'images/img/centr/strapon.jpg', func('billiard_strings', 'local_str6')
		act 'Уйти':gt'billiard'
	elseif billwin > 10 and billvar = 2:
		DOM += 8
		gs 'zz_render', '', 'images/img/centr/strapon.jpg', func('billiard_strings', 'local_str7')
		act 'Уйти':gt'billiard'
	elseif billwin > 10 and billvar = 3:
		money += 300
		gs 'zz_render', '', '', func('billiard_strings', 'local_str8')
		act 'Уйти':gt'billiard'
	elseif billwin <= 10 and billvar = 0:
		money -= 1000
		gs 'zz_render', '', '', func('billiard_strings', 'local_str9')
		act 'Уйти':gt'billiard'
	elseif billwin <= 10 and billvar = 1:
		gs 'zz_render', '', '', func('billiard_strings', 'local_str10')
		act 'Платить':xgt'sex','var'
	elseif billwin <= 10 and billvar = 2:
		gs 'zz_render', '', '', func('billiard_strings', 'local_str11')
		act 'Платить':gt'paysex','var'
	elseif billwin <= 10 and billvar = 3:
		money -= 300
		gs 'zz_render', '', '', func('billiard_strings', 'local_str12')
		act 'Уйти':gt'billiard'
	end
end
if $ARGS[0] = 'start':
	'<center><b>Биллиардная</b></center>'
	'<center><img src="images/img/centr/bil.jpg"></center>'
	act 'Уйти':gt'billiard'
end