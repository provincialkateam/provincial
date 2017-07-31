if $ARGS[0] = 'var1':
	*clr & cla
	var = RAND(0,3)
	if var ! 0:
		minut += 180
		money += 2000
		gs 'zz_render', '', 'images/img/qjob/f0.jpg', func('qjob_strings', 'local_str1')
		act 'Поправить':
			cla
			gs 'zz_render', '', '', func('qjob_strings', 'local_str2')
			act 'Уйти': gt'down'
		end
		act 'Оставить как есть':
			*clr & cla
			gs 'zz_render', '', 'images/img/qjob/f1.jpg', func('qjob_strings', 'local_str3')
			act 'Остановить его':
				*clr & cla
				gs 'zz_render', '', 'images/img/qjob/f0.jpg', func('qjob_strings', 'local_str4')
				act 'Уйти': gt'down'
			end
			act 'Ничего не делать':
				*clr & cla
				orgasm += 1
				kuni += 1
				guy += 1
				gs 'zz_render', '', 'images/img/qjob/f2.jpg', func('qjob_strings', 'local_str5')
				act 'Отказаться':
					cla
					gs 'zz_render', '', '', func('qjob_strings', 'local_str6')
					act 'Уйти': gt'down'
				end
				act 'Согласиться':
					picrand = 30
					gt 'podrsex','var'
				end
			end
		end
	else
		minut += 60
		gs 'zz_render', '', 'images/img/qjob/f3.jpg', func('qjob_strings', 'local_str7')
		act 'Отказаться':
			cla
			gs 'zz_render', '', '', func('qjob_strings', 'local_str8')
			act 'Уйти':gt'down'
		end
		act 'Согласиться':
			*clr & cla
			minut += 90
			money += 2000
			gs 'zz_render', '', 'images/img/qjob/f4.jpg', func('qjob_strings', 'local_str9')
			act 'Встать':
				*clr & cla
				gs 'zz_render', '', 'images/img/qjob/f5.jpg', func('qjob_strings', 'local_str10')
				act 'Поменять позу':
					*clr & cla
					gs 'zz_render', '', 'images/img/qjob/f'+RAND(6,10)+'.jpg', func('qjob_strings', 'local_str11')
					act 'Уйти': gt'down'
				end
			end
		end
	end
end
if $ARGS[0] = 'var2':
	*clr & cla
	minut += 120
	money += 2000
	gs 'zz_render', '', 'images/img/qjob/f11.jpg', func('qjob_strings', 'local_str12')
	act 'Отказаться':
		cla
		gs 'zz_render', '', '', func('qjob_strings', 'local_str13')
		act 'Уйти': gt'down'
	end
	act 'Открыть':
		*clr & cla
		gs 'zz_render', '', 'images/img/qjob/f12.jpg', func('qjob_strings', 'local_str14')
		act 'Далее':
			picrand = 22
			xgt'lezbsex','var'
		end
	end
end
if $ARGS[0] = 'var3':
	*clr & cla
	qjobpristrand = RAND(0,5)
	var = RAND(0,5)
	if var = 0:
		minut += 60
		gs 'zz_render', '', 'images/img/qjob/n0.jpg', func('qjob_strings', 'local_str15')
		act 'Отказаться':
			cla
			gs 'zz_render', '', '', func('qjob_strings', 'local_str16')
			act 'Уйти': gt'down'
		end
		act 'Согласиться':
			*clr & cla
			minut += 60
			money += 1000
			gs 'zz_render', '', 'images/img/qjob/n1.jpg', func('qjob_strings', 'local_str17')
			act 'Начать':
				picrand = 81
				xgt 'sex','var'
			end
		end
	elseif var = 1:
		minut += 180
		money += 1000
		gs 'zz_render', '', 'images/img/qjob/n2.jpg', func('qjob_strings', 'local_str18')
		act 'Уйти':
			cla
			gs 'zz_render', '', '', func('qjob_strings', 'local_str19')
			act 'Уйти': gt'down'
		end
		act 'Переубедить':
			cla
			gs 'zz_render', '', '', func('qjob_strings', 'local_str20')
			act 'Начать':
				picrand = 82
				xgt 'sex','var'
			end
		end
	elseif var = 2:
		minut += 180
		money += 1000
		gs 'zz_render', '', 'images/img/qjob/n3.jpg', func('qjob_strings', 'local_str21')
		if qjobpristrand ! 0:
			gs 'zz_render', '', '', func('qjob_strings', 'local_str22')
			act 'Уйти': gt'down'
		else
			gs 'zz_render', '', '', func('qjob_strings', 'local_str23')
			act 'Прекратить':
				cla
				gs 'zz_render', '', '', func('qjob_strings', 'local_str24')
				act 'Уйти': gt'down'
			end
			act 'Позволить':
				picrand = 85
				gt'sex','kuni'
			end
		end
	elseif var = 3:
		minut += 180
		money += 1000
		gs 'zz_render', '', 'images/img/qjob/n4.jpg', func('qjob_strings', 'local_str25')
		if qjobpristrand ! 0:
			gs 'zz_render', '', '', func('qjob_strings', 'local_str26')
			act 'Уйти': gt'down'
		else
			gs 'zz_render', '', '', func('qjob_strings', 'local_str27')
			act 'Поправить одежду':
				cla
				gs 'zz_render', '', '', func('qjob_strings', 'local_str28')
				act 'Уйти': gt'down'
			end
			act 'Позволить':
				*clr & cla
				gs 'zz_render', '', 'images/img/qjob/n5.jpg', func('qjob_strings', 'local_str29')
				act 'Продолжать':
					picrand = 31
					gt 'podrsex','var'
				end
			end
		end
	elseif var = 4:
		minut += 180
		money += 1000
		gs 'zz_render', '', 'images/img/qjob/n6.jpg', func('qjob_strings', 'local_str30')
		if qjobpristrand ! 0:
			gs 'zz_render', '', '', func('qjob_strings', 'local_str31')
			act 'Уйти': gt'down'
		else
			gs 'zz_render', '', '', func('qjob_strings', 'local_str32')
			act 'Врезать':
				cla
				gs 'zz_render', '', '', func('qjob_strings', 'local_str33')
				act 'Уйти': gt'down'
			end
			act 'Позволить':
				*clr & cla
				gs 'zz_render', '', 'images/img/qjob/n7.jpg', func('qjob_strings', 'local_str34')
				act 'Продолжать':
					picrand = 32
					gt'podrsex','var'
				end
			end
		end
	else
		minut += 180
		money += 1000
		gs 'zz_render', '', 'images/img/qjob/n2.jpg', func('qjob_strings', 'local_str35')
		act 'Уйти': gt'down'
		act 'Домогаться':
			picrand = 86
			gt 'sex','minet'
		end
	end
end