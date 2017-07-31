if $args[0] = '' or $args[0] = 'main':
	gs 'stat'
	gs 'zz_atm','description'
	act '<B>Отойти</B>': gt 'shop','start'
	! actions
	gs 'zz_render', '', '', func('zz_atm_strings', 'atm_str1') + iif(komp = 1,func('zz_atm_strings', 'atm_str2'),'')
end
if $args[0] = 'description':
	gs 'zz_render',func('zz_atm_strings', 'atm_str3'),'pic/bank_terminal.jpg',func('zz_atm_strings', 'atm_str4')
end
if $args[0] = 'money2card':
	cla
	act '<B>Отойти</B>': gt 'shop','start'
	minut += 2
	gs 'stat'
	kartaIN = input(func('zz_atm_strings', 'atm_str5'))
	if kartaIN <= 0:
		exit
	elseif kartaIN > money:
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str6')
	else
		karta += kartaIN
		money -= kartaIN
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str7')
	end
end
if $args[0] = 'money_from_card':
	cla
	act '<B>Отойти</B>': gt 'shop', 'start'
	minut += 5
	kartaOUT = input(func('zz_atm_strings', 'atm_str8'))
	if kartaOUT <= 0:
		exit
	elseif kartaOUT > karta:
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str6')
	else
		karta -= kartaOUT
		money += kartaOUT
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str9')
	end
end
if $args[0] = 'internet_payment':
	cla
	minut += 5
	act '<B>Отойти</B>': gt 'shop', 'start'
	i = val(input(func('zz_atm_strings', 'atm_str11')))
	if i <= 0:
		exit
	elseif i * 10 > karta:
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str6')
	elseif i*10 <= karta:
		karta -= i * 10
		internetM += i * 60
		internet = internetM / 60
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str10')
	end
	gs 'stat'
end
if $args[0] = 'mobile_payment':
	cla
	minut += 5
	act '<B>Отойти</B>': gt 'shop', 'start'
	i = val(input(func('zz_atm_strings', 'atm_str5')))
	if i <= 0:
		exit
	elseif i > karta:
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str6')
	elseif i <= karta:
		balans += i
		karta -= i
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str12')
	end
	gs 'stat'
end
if $args[0] = 'house_payment':
	cla
	act '<B>Отойти</B>': gt 'shop', 'start'
	act 'В главное меню': gt 'zz_atm'
	gs 'zz_atm','description'
	gs 'zz_render','','',func('zz_atm_strings', 'atm_str13') + iif(ArendHouseSL > 0,func('zz_atm_strings', 'atm_str14'),'') + iif(BuyHous >= 0,func('zz_atm_strings', 'atm_str15'),'')
end
if $args[0] = 'house_payment_end':
	*clr & cla
	gs 'zz_atm', 'description'
	act '<B>Отойти</B>': gt 'shop', 'start'
	act 'В главное меню': gt 'zz_atm'
	i = args[1]
	if karta >= i * 10000:
		karta -= i * 10000
		ArendHouseSL += i * 30
		housr = 1
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str16')
	else
		gs 'zz_render','','',func('zz_atm_strings', 'atm_str6')
	end
	gs 'stat'
end