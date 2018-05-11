if $ARGS[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','','images/pic/stripclub.jpg'
	if stripday ! day:
		stripday = day
		cfnm = iif(RAND(1,100)<=40,1,0)
	end
	gs 'zz_render', '', '', func('stripclub_strings', 'local_str1')
	act 'Выйти':
		cla
		minut += 5
		gt'center'
	end
	act 'Заплатить 500 рублей и войти':
			cla
			money -= 500
			minut += 5
			frost = 0
			if money >= 500 and hour < 23: gt 'stripclub', iif(cfnm = 1, 'forwoman', 'forman')
	end
	if stripdance > 0 and stripwork = 0:
			act 'Поговорить с менеджером о работе стриптизершей':
				cla
				minut += 15
				gs 'stat'
				gs 'zz_render', '', '', func('stripclub_strings', 'local_str2')
				act 'Нет':gt'stripclub','start'
				act 'Да':
					*clr & cla
					stripwork = 1
					gs 'zz_render', '', '', func('stripclub_strings', 'local_str3')
					if cfnm = 0:
						act 'Осматриваться':gt'stwork','start'
					else
						gs 'zz_render', '', '', func('stripclub_strings', 'local_str4')
						act 'Выйти':gt'stripclub','start'
					end
				end
			end
	end
	if stripwork > 0:
		if cfnm = 0:
			act 'Идти в раздевалку': gt'stwork','start'
		else
			gs 'zz_render', '', '', func('stripclub_strings', 'local_str5')
		end
	end
end
if $ARGS[0] = 'forman':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/pic/stripclub1.jpg', func('stripclub_strings', 'local_str6')
	act 'Выйти':
		cla
		minut += 5
		gt'stripclub','start'
	end
	if hour < 23:
		act 'Сесть за столик около сцены и смотреть стриптиз':gt'stripclub','stol'
		if money >= 1000:
			act 'Заказать приватный танец (1000 руб)': gt'stripclub','privat'
		end
		if money >= 5000:
			act 'Заказать особенное шоу': gt 'stripclub', 'stpr' + RAND(1,2)
		end
	end
end
if $ARGS[0] = 'privat':
	*clr & cla
	money -= 1000
	minut += 60
	horny += 25
	DOM += 1
	gs 'stat'
	privrand = RAND(0,4)
	if privrand = 0:
		gs 'zz_render', '', 'images/img/centr/priv2.jpg', func('stripclub_strings', 'local_str7')
		act 'Закончить':gt'stripclub','forman'
		act 'Позволить им':gt'stripclub','privsex'
	elseif privrand > 0:
		gs 'zz_render', '', 'images/pic/privat.jpg', func('stripclub_strings', 'local_str8')
		if money >= 1000:
			act 'Еще один приватный танец (1000 руб)':gt'stripclub','privat'
		end
		act 'Уйти к сцене':gt'stripclub','forman'
	end
end
if $ARGS[0] = 'stol':
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', 'images/pic/stripclub2.jpg', func('stripclub_strings', 'local_str9')
	act 'Смотреть стриптиз':
		*clr & cla
		gs 'stat'
		minut += 15
		gs 'zz_render', '', 'images/pic/stripclub4.jpg', func('stripclub_strings', 'local_str10')
		if money >= 50:
			act 'Сунуть ей 50 рублей':
				*clr & cla
				horny += 5
				minut += 15
				money -= 50
				gs 'zz_render', '', 'images/pic/stripclub6.jpg', func('stripclub_strings', 'local_str11')
				act 'Далее':gt'stripclub','stol'
			end
		end
		act 'Потупить взор':
			cla
			horny -= 5
			minut += 15
			gs 'zz_render', '', '', func('stripclub_strings', 'local_str12')
			act 'Далее':gt'stripclub','stol'
		end
	end
	act 'Отойти от сцены':gt'stripclub','forman'
end
if $ARGS[0] = 'forwoman':
	*clr & cla
	stripguy = 0
	minut += 5
	gs 'stat'
	gs 'zz_render','','images/pic/stripclub1.jpg'
	act 'Выйти':
		cla
		minut += 5
		gt'stripclub','start'
	end
	if hour < 23:
		act 'Сесть за столик около сцены и смотреть стриптиз':gt'stripclub','stolW'
	end
end
if $ARGS[0] = 'stolW':
	*clr & cla
	stripguy = 0
	gs 'stat'
	gs 'zz_render', '', 'images/picVA/stripW.jpg', func('stripclub_strings', 'local_str18')
	if hour < 23:
		act 'Смотреть стриптиз':
			*clr & cla
			gs 'stat'
			minut += 15
			gs 'zz_render', '', 'images/picVA/stripW1.jpg', func('stripclub_strings', 'local_str19')
			if money >= 50:
				act 'Сунуть ему 50 рублей':
					*clr & cla
					horny += 5
					minut += 15
					money -= 50
					gs 'zz_render', '', 'images/picVA/stripW2.jpg', func('stripclub_strings', 'local_str20')
					act 'Прекратить':gt'stripclub','stolW'
					act 'Позволить ему обнажить вашу грудь':gt'cfnm','start'
				end
			end
			act 'Потупить взор':
				cla
				horny -= 5
				minut += 15
				gs 'zz_render', '', '', func('stripclub_strings', 'local_str21')
				act 'Далее':gt'stripclub','stolW'
			end
		end
	end
	act 'Отойти от сцены':gt'stripclub','forwoman'
end
if $ARGS[0] = 'privsex':
	*clr & cla
	horny = 0
	orgasm += 1
	gs 'zz_render', '', 'images/img/centr/priv3.jpg', func('stripclub_strings', 'local_str22')
	act 'Закончить':gt'stripclub','forman'
	act 'Еще':gt'stripclub','privsex1'
end
if $ARGS[0] = 'privsex1':
	*clr & cla
	girl += 2
	lesbian += 1
	gs 'zz_render', '', 'images/img/centr/priv' + RAND(4,7) + '.jpg', func('stripclub_strings', 'local_str23')
	act 'Закончить':gt'stripclub','forman'
	if hour > 23: act 'Еще':gt'stripclub','privsex1'
end
if $ARGS[0] = 'stpr1':
	*clr & cla
	horny += 30
	gs 'zz_render', '', 'images/img/centr/prsex1.jpg', func('stripclub_strings', 'local_str24')
	act 'Закончить':gt'stripclub','forman'
	if vagina > 0 and anus > 0:
		act 'Присоединиться':
			*clr & cla
			dom -= 3
			girl += 2
			lesbian += 1
			sex += 1
			anal += 1
			gs 'zz_render', '', 'images/img/centr/prsex2.jpg', func('stripclub_strings', 'local_str25')
			act 'Встать раком':
				*clr & cla
				gs 'zz_render', '', 'images/img/centr/prsex3.jpg', func('stripclub_strings', 'local_str26')
				act 'В два ствола':
					*clr & cla
					horny = 0
					orgasm += 1
					gs 'zz_render', '', 'images/img/centr/prsex4.jpg', func('stripclub_strings', 'local_str27')
					act '...': gt 'stripclub', 'stpr4'
				end
			end
		end
	end
end
if $ARGS[0] = 'stpr2':
	*clr & cla
	girl += 2
	lesbian += 1
	gs 'zz_render', '', 'images/img/centr/prsex6.jpg', func('stripclub_strings', 'local_str28')
	act 'Трахнуть их':
		*clr & cla
		DOM += 3
		gs 'zz_render', '', 'images/img/centr/prsex7.jpg', func('stripclub_strings', 'local_str29')
		act 'Трахнуть их': gt 'stripclub', 'stpr3'
	end
	if vagina > 0 and anus > 0:
		act 'Отдаться':
			*clr & cla
			dom -= 3
			gs 'zz_render', '', 'images/img/centr/prsex8.jpg', func('stripclub_strings', 'local_str30')
			act 'Отдаться': gt 'stripclub', 'stpr4'
		end
	end
end
if $ARGS[0] = 'stpr3':
	*clr & cla
	horny = 0
	orgasm += 1
	gs 'zz_render', '', 'images/img/centr/prsex' + RAND(9,13) + '.jpg', func('stripclub_strings', 'local_str31')
	if hour > 23: act 'Еще': gt 'stripclub', 'stpr3'
	act 'Закончить': gt 'stripclub', 'forman'
end
if $ARGS[0] = 'stpr4':
	*clr & cla
	horny = 0
	orgasm += 1
	gs 'zz_render', '', 'images/img/centr/prsex' + RAND(14,19) + '.jpg', func('stripclub_strings', 'local_str32')
	if hour > 23: act 'Еще': gt 'stripclub', 'stpr4'
	act 'Закончить': gt 'stripclub', 'forman'
end