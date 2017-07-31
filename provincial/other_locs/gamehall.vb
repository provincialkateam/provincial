if $args[0] = '':
	*clr & cla
	minut += 5
	frost = 0
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','','common/gamehall/gamehall.jpg','Вы входите в зал и видите множество игровых автоматов и кучу людей возле них. Постоянно слышится звон дергающихся ручек и падающих монет.**В левой части зала очень мало свободных мест.**Видимо там необходимая ставка меньше всех, но и выигрыш невелик.**Правее от них народу поменьше и ставка побольше.**Ну а в дальней части зала сидят единицы.**Там самая большая необходимая ставка, но и джекпот соответствующий - 10 млн. рублей.'
	act '<b>Уйти</b>': minut += 5 & gt $control_point
	if hour < 10 or hour > 20: exit
	act 'К автоматам за 10 руб': gt 'gamehall','play',10
	act 'К автоматам за 100 руб': gt 'gamehall','play',100
	act 'К автоматам за 1000 руб': gt 'gamehall','play',1000
end
! --
if $args[0] = 'play':
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	_bet = args[1]
	gs 'zz_render','','common/gamehall/slot_machine.jpg','Правила игры очень простые: кидаешь монетку <<_bet>> рублей и дергаешь рычаг. Джекпот ' + iif(_bet=10,'100 тысяч',iif(_bet=100,'миллион','10 млн.')) + ' рублей.'
	act 'Дернуть рычаг':
		if money >= _bet:
			i = 0
			minut += rand(1,3)
			money -= _bet
			b1 = RAND(1,8)
			b2 = RAND(1,8)
			b3 = RAND(1,8)
			*clr
			gs 'zz_render','','','<center><img src="images/common/gamehall/game_box/fon_t_a_<<_bet>>.jpg"><center><table border=0 cellpadding=0 cellspacing=0 bgcolor="#111111"><tr><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_a.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b1>>.gif"></td><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_b.jpg"></td><td rowspan="4" background="images/common/gamehall/game_box/fon_ba.jpg"><img src="images/common/gamehall/game_box/<<b2>>.gif"></td><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_b.jpg"></td><td rowspan="4" background="images/common/gamehall/game_box/fon_ba.jpg"><img src="images/common/gamehall/game_box/<<b3>>.gif"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_a_<<_bet>>.jpg"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_b_<<i>>.jpg"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_c_<<i>>.jpg"></td></tr></table><center><img src="images/common/gamehall/game_box/fon_b_a.jpg">'
			:loop
				if i < 4:
					if i = 0:
						wait 500
					else:
						if i = 1:
							b1 += 10
						elseif i = 2:
							b2 += 10
						elseif i = 3:
							b3 += 10
						end
						wait 500
						*clr
						gs 'zz_render','','','<center><img src="images/common/gamehall/game_box/fon_t_a_<<_bet>>.jpg"><center><table border=0 cellpadding=0 cellspacing=0 bgcolor="#111111"><tr><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_a.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b1>>.gif"></td><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_b.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b2>>.gif"></td><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_b.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b3>>.gif"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_a_<<_bet>>.jpg"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_b_0.jpg"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_c_0.jpg"></td></tr></table><center><img src="images/common/gamehall/game_box/fon_b_a.jpg">'
					end
				i += 1
				jump 'loop'
			end
			if b1 = b2 and b1 = b3:
				i = b1
				if b1 = 18:
					money += _bet*10000
					img_win = 18
				elseif b1 = 17:
					money += _bet*16
					img_win = _bet*16
				elseif b1 = 16:
					money += _bet*14
					img_win = _bet*14
				elseif b1 = 15:
					money += _bet*12
					img_win = _bet*12
				elseif b1 = 14:
					money += _bet*10
					img_win = _bet*10
				elseif b1 = 13:
					money += _bet*8
					img_win = _bet*8
				elseif b1 = 12:
					money += _bet*6
					img_win = _bet*6
				elseif b1 = 11:
					money += _bet*4
					img_win = _bet*4
				end
			elseif b1+b2=36 or b2+b3=36 or b1+b3=36:
				i = 10
				money += _bet*2
				img_win = _bet*2
			else
				img_win = i
			end
			*clr
			gs 'zz_render','','','<center><img src="images/common/gamehall/game_box/fon_t_a_<<_bet>>.jpg"><center><table border=0 cellpadding=0 cellspacing=0><tr><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_a.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b1>>.gif"></td><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_b.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b2>>.gif"></td><td rowspan="4"><img src="images/common/gamehall/game_box/fon_c_b.jpg"></td><td rowspan="4"><img src="images/common/gamehall/game_box/<<b3>>.gif"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_a_<<_bet>>.jpg"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_b_<<i>>.jpg"></td></tr><tr><td><img src="images/common/gamehall/game_box/fon_c_c_c_<<img_win>>.jpg"></td></tr></table><center><img src="images/common/gamehall/game_box/fon_b_a.jpg">'
			gs 'stat'
		else
			gs 'zz_render','','','<red>У вас недостаточно денег для игры!</red>'
		end
		act 'Отойти':
			killvar '_bet'
			gt 'gamehall'
		end
	end
end