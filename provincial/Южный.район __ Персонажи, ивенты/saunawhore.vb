saunaWorkKlient = 1
guy += 1
slutty += 1
bj += 1
dynamic $venerasiak
gs'boy'
$boy = 'клиент'
minut += 15
SaunaWhore += 1
gs'stat'
gs 'zz_render', '', 'images/sauna/bj'+RAND(1,22)+'.jpg', func('saunawhore_strings', 'local_str1')
if dick <= 12:'Член не очень велик и вы постоянно тыкаете носом в курчавый лобок всасывая член до основания и мохнатые шары ударяют вас по подбородку.'
if dick > 12 and dick <= 15:'Член при каждом движении достает до вашего горла и вы немного давясь старательно обрабатываете его своими губками.'
if dick > 15:'Член великоват для вашего рта и вы сосете его на столько, насколько вам позволяет ваш рот всасывая его до горла и обрабатывая головку языком.'
!dynamic $saunadinsexbefore
if dick > 15: saunarand = RAND(0,100)
if dick > 15 and saunarand > 90:
	gs 'zz_render', '', '', func('saunawhore_strings', 'local_str2')
	act 'Глубокий минет':
		*clr & cla
		minut += 45
		sweat += 1
		mop = 0
		throat += 1
		gs 'stat'
		gs 'zz_render', '', 'images/sauna/deep' + RAND(1,34) + '.jpg', func('saunawhore_strings', 'local_str3')
		act 'Взять деньги с клиента и уйти':money += 1500 & saunaWorkNow = 1 & gt'saunawork'
	end
end
if dick <= 15 or saunarand <= 90:
	gs 'zz_render', '', '', func('saunawhore_strings', 'local_str4')
	act 'Далее':
		*clr & cla
		if RAND(0,100) <= 80:
			*clr & cla
			minut += 45
			sex += 1
			pose = 0
			sweat += 1
			gs'stat'
			gs 'zz_render', '', 'images/sauna/sex'+RAND(1,23)+'.jpg', func('saunawhore_strings', 'local_str5')
			if prezik <= 0:prezik += 1 & workDolg += 50 & 'Вы взяли презерватив из общей пачки, зная что за это с вас вычтут 50 рублей.'
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Взять деньги с клиента и уйти':money += 1000 & saunaWorkNow = 1 & gt'saunawork'
		else
			*clr & cla
			minut += 45
			sweat += 1
			gs 'stat'
			gs 'zz_render', '', 'images/sauna/anal'+RAND(1,23)+'.jpg', 'Клиент захотел вас в попку.'
			if prezik <= 0:prezik += 1 & workDolg += 50 & 'Вы взяли презерватив из общей пачки, зная что за это с вас вычтут 50 рублей.'
			gs 'zz_dynamic_sex', 'anal_start', 'dick', 1
			gs 'zz_dynamic_sex', 'anal', 'dick'
			gs 'zz_dynamic_sex', 'anal_cum'
			act 'Взять деньги с клиента и уйти':money += 2000 & saunaWorkNow = 1 & gt'saunawork'
		end
	end
end