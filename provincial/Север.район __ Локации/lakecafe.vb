if $args[0] = 'main' or $args[0] = '':
	*clr & cla
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'шашлычная "Шампур"', 'images/LakeCafe/LakeCafe.jpg', func('lakecafe_strings', 'local_str1')
	act '<B>Уйти</B>': minut += 2 & gt 'nord'
	if hour >= 12 or hour < 4:
		$_str[0] = '</a> и полирует бокалы'
		$_str[1] = '</a> и протирает стол'
		$_str[2] = '</a> и что-то смешивает'
		gs 'zz_render', '', '', func('lakecafe_strings', 'local_str2')
		if week = 1 and hour = 22:
			randguycafe = RAND(3,6)
			$_str[0] = iif(LCwork = 0,'группа мужчин','<a href="exec:GT ''LCwork'',''start'',''1''"><<randguycafe>> мужчин</a>')+' и выпивает, громко разговаривая и хохоча.'
			$_str[1] = iif(LCwork = 0,'пожилой мужчина','<a href="exec:GT ''LCwork'',''start'',''2''">пожилой мужчина</a>')+' и ест шашлык.'
			$_str[2] = iif(LCwork = 0,'два парня','<a href="exec:GT ''LCwork'',''start'',''3''">два парня</a>')+' и выпивают.'
			$_str[3] = iif(LCwork = 0,'парень с девушкой','<a href="exec:GT ''LCwork'',''start'',''4''">парень с девушкой</a>')+' и болтают о чём-то.'
			$_str[4] = iif(LCwork = 0,'девушка','<a href="exec:GT ''LCwork'',''start'',''5''">девушка</a>')+' и ужинает.'
			$_str[5] = iif(LCwork = 0,'толстый мужчина','<a href="exec:GT ''LCwork'',''start'',''6''">толстый мужчина</a>')+' и разговаривает по телефону.'
			gs 'zz_render','','','За одним из столов сидит ' + $_str[rand(0,5)]
		end
		killvar '$_str'
		if hour >= 23:'За небольшим столом, в углу зала сидят несколько <a href="exec:GT ''lakecafe'',''bandits''">мужчин</a> сомнительной внешности'
		gs 'zz_render', '', '', func('lakecafe_strings', 'local_str3')
		if money >= 75:
			act 'Поесть 300 руб':
				*clr & cla
				money -= 300
				gs 'zz_kitchen_acts', 'eat'
				gs 'zz_kitchen_acts', 'drink', 'tea'
				act 'Встать из за стола': minut += 20 & gt'lakecafe','main'
			end
		end
	end
	if LCwork2 >= 1 and LCwork2day ! day and hour = 18: act 'Помогать на кухне': gt'LCwork','Kitchen'
end
if $ARGS[0] = 'barmensha':
	*clr & cla
	gs 'stat'
	gs 'npc_editor','get_npc_profile',30
	gs 'zz_render', '', '', func('lakecafe_strings', 'local_str'+iif(barmenshameet = 0,5,6))
	if hour >= 12 or hour < 4:
		act 'Поболтать':
			*clr & cla
			minut += 30
			gs 'stat'
			gs 'npc_editor','change_rep','+',30
			gs 'zz_render', '', 'images/LakeCafe/LakeBarmensha.jpg', func('lakecafe_strings','local_str'+iif(barmenshameet=0,7,8))
			barmenshameet = 1
			act '...': gt'lakecafe','barmensha'
		end
		if $npc['30,relation'] >= 60 and horny > 50:
			act 'Заигрывать':
				*clr & cla
				minut += 10
				gs 'stat'
				gs 'zz_render', '', 'images/LakeCafe/LakeBarmensha.jpg', func('lakecafe_strings', 'local_str9')
				act '...':
					if JenyaLCfirst = 0: gt'LCporn','firsttime'
					if JenyaLCfirst = 1: gt'LCporn','sex'
				end
			end
		end
		if $npc['30,relation'] >= 35:
			act 'Спросить о работе':
				*clr & cla
				minut += 4
				gs 'zz_render', '', 'images/LakeCafe/LakeBarmensha.jpg'
				if LCworkwork2 = 0:
					LCworkwork2 = 1
					LCwork2 = 1
					gs 'zz_render', '', '', func('lakecafe_strings', 'local_str10')
					act '...': gt'lakecafe','barmensha'
				else
					gs 'zz_render', '', '', func('lakecafe_strings', 'local_str11')
					act '...': gt'lakecafe','barmensha'
				end
			end
		end
		if $npc['30,relation'] >= 80:
			act 'Спросить об "особой" работе':
				*clr & cla
				minut += 4
				if LCworkwork = 0:
					gs 'zz_render', '', 'images/LakeCafe/LakeBarmensha.jpg', func('lakecafe_strings', 'local_str12')
					act '...':
						LCworkwork = 1
						LCwork = 1
						gt'lakecafe','barmensha'
					end
				else
					gs 'zz_render', '', '', func('lakecafe_strings', 'local_str13')
					act '...': gt'lakecafe','barmensha'
				end
			end
		end
	end
	act 'Отойти': gt'lakecafe','main'
end
if $ARGS[0] = 'bandits':
	*clr & cla
	gs 'zz_render', 'Бандиты', 'images/LakeCafe/bandits.jpg', func('lakecafe_strings', 'local_str14')
	gs 'zz_render', '', '', func('lakecafe_strings', 'local_str'+iif(workDolg > 0,15,16))
	act '<B>Отойти</B>': gt'lakecafe', 'main'
	act 'Попросить денег в долг':
		intinp = input ("Сколько денег вы хотите взять в долг?")
		if intinp <= 0:
			gs 'zz_render', '', '', func('lakecafe_strings', 'local_str17')
		elseif intinp > 2000000:
			gs 'zz_render', '', '', func('lakecafe_strings', 'local_str18')
		elseif intinp > 0 and intinp <= 2000000:
			cla
			money += intinp
			workDolg += intinp + (intinp/100)*20
			workDolgDay = 7
			gs 'zz_render', '', '', func('lakecafe_strings', 'local_str19')
			act '<B>Отойти</B>': gt'lakecafe', 'main'
		end
	end
	if workDolg > 0:
		cla
		act '<B>Отойти</B>':gt'lakecafe', 'main'
		act 'Я всё отдам, клянусь': gs 'zz_render', '', '', func('lakecafe_strings', 'local_str20')
	end
	if workDolg > 0 and money >= workDolg:
		act 'Отдать долг':
			cla
			minut += 5
			workDisk = 0
			money -= workDolg
			workDolg = 0
			gs'stat'
			gs 'zz_render', '', '', func('lakecafe_strings', 'local_str21')
			act '<B>Отойти</B>':gt'lakecafe', 'main'
		end
	end
	if workDolgDay <= 0 and workDolg > 0:
		*clr & cla
		gs 'stat'
		gs 'time'
		workDisk = 0
		gs 'zz_render', '', 'images/sauna/bug.jpg', func('lakecafe_strings', 'local_str22')
		if money >= workDolg:
			money -= workDolg
			workDolg = 0
			gs 'zz_render', '', '', func('lakecafe_strings', 'local_str23')
			act 'Уйти':gt'lakecafe', 'main'
			exit
		else
			if money+karta >= workDolg:
				money += karta
				karta = 0
				money -= workDolg
				workDolg = 0
				gs 'zz_render', '', '', func('lakecafe_strings', 'local_str24')
				act 'Уйти':gt'korr'
				exit
			else
				money += karta
				karta = 0
				workDolg -= money
				money = 0
				workDolg += 10000
				gs 'zz_render', '', '', func('lakecafe_strings', 'local_str25')
				act 'Выйти из машины':
					*clr & cla
					minut += 30
					gs'stat'
					gs 'zz_render', '', '', func('lakecafe_strings', 'local_str26')
					act 'Оглядеться':gt'saunaroom'
				end
			end
		end
		exit
	end
end