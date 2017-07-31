$sister_party_cum ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_9_' + rand(1,2) + '.gif', func('sister_party_strings', '1')
	act 'Уснуть':dynamic $Party_sleep
}
$sister_party_hand ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_5_' + rand(1,3) + '.gif'
	if sister_party_dom = 1:
		gs 'zz_render', '', '', func('sister_party_strings', '2')
	elseif sister_party_dom =2:
		gs 'zz_render', '', '', func('sister_party_strings', '3')
	end
	act 'Ласкать взаимно':
		*clr & cla
		minut += 5
		gs 'stat'
		if rand(1,2) = 1:
			gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_6_'+rand(1,3)+'.gif', func('sister_party_strings', '4')
			act 'Кончить':dynamic $sister_party_cum
		else
			gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_7_'+rand(1,2)+'.gif'
			if sister_party_dom = 2:gs 'zz_render', '', '','Вам тоже захотелось поласкать пальчиками сестру, и приподнявшись продолжили вместе.'
			if sister_party_dom = 1:gs 'zz_render', '', '','Ане тоже захотелось поласкать вас пальчиками, и приподнявшись продолжили вместе.'
			gs 'zz_render', '', '', func('sister_party_strings', '5')
			act 'Кончить':dynamic $sister_party_cum
		end
	end
	act 'Тереться кисками':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_8_' + rand(1,4) + '.gif', func('sister_party_strings', '6')
		act 'Кончить':dynamic $sister_party_cum
	end
}
$sister_party_fun ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_3_' + rand(1,2) + '.gif', func('sister_party_strings', '7')
	if Rex_Love = 1:gs 'zz_render', '', '','Рекс с огромным любопытством наблюдает за вами.'
	act 'Отойти':gt $loc,$metka
	act 'Целоваться':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_3_' + rand(3,4) + '.jpg', func('sister_party_strings', '8')
	if Rex_Love = 1:
	gs 'zz_render', '', '', func('sister_party_strings', '9')
	end
	act 'В комнату':
	*clr & cla
	minut += 5
	gs'stat'
	'<center><b><font color = maroon>Аня</font></b></center>'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_3_' + rand(5,10) + '.jpg', func('sister_party_strings', '10')
	act 'Полизать ей':
	*clr & cla
	minut += 5
	sister_party_dom =1
	gs'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_4_' + rand(1,3) + '.gif', func('sister_party_strings', '11')
	act 'Ласкать ладошкой':dynamic $sister_party_hand
	end
	act 'Лечь на спину':
	*clr & cla
	minut += 5
	sister_party_dom =2
	gs'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_4_' + rand(1,3) + '.gif', func('sister_party_strings', '12')
	act 'Ласкать ладошкой':dynamic $sister_party_hand
	end
	end
	end
}
$sister_party_drink ={
	*clr & cla
	gs 'zz_funcs', 'alko'
	drunk_sveta += 1
	gs 'stat'
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_2.jpg', func('sister_party_strings', '13')
	if alko >= 7:gs 'zz_render', '', '','Голова внезапно сильно закружилась и вы готовы в любой момент...'
	if alko >= 7:act 'Отрубиться':dynamic $Party_sleep
	if alko < 7:act 'Танцевать топлес':dynamic $sister_party_fun
	if alko < 7:act 'Отойти':gt $loc,$metka
}
$sister_party_talk ={
	*clr & cla
	minut += 5
	sister_party_talk += 1
	sister_party_talkQW += 1
	gs'stat'
	gs 'zz_render', 'Аня','pavlovo/family/sister/sisterQW/ReksHome/Party_sister_1.jpg'
	if sister_party_talk < 3:
			if sister_party_talkQW = 1:	gs 'zz_render', '', '', func('sister_party_strings', '14')
			if sister_party_talkQW = 2:	gs 'zz_render', '', '', func('sister_party_strings', '15')
			if sister_party_talkQW = 3:	gs 'zz_render', '', '', func('sister_party_strings', '16')
			if sister_party_talkQW = 4:	gs 'zz_render', '', '', func('sister_party_strings', '17')
			if sister_party_talkQW = 5:	gs 'zz_render', '', '', func('sister_party_strings', '18')
			if sister_party_talkQW = 6:	gs 'zz_render', '', '', func('sister_party_strings', '19')
			if sister_party_talkQW = 7:	gs 'zz_render', '', '', func('sister_party_strings', '20')
			if sister_party_talkQW = 8:	gs 'zz_render', '', '', func('sister_party_strings', '21')
			if sister_party_talkQW = 9 and Rex_Love = 1: gs 'zz_render', '', '', func('sister_party_strings', '22')
			if sister_party_talkQW = 9 and Rex_Love = 0: gs 'zz_render', '', '', func('sister_party_strings', '23')
			if sister_party_talkQW = 10 and Rex_Love = 1: gs 'zz_render', '', '', func('sister_party_strings', '24')
			if sister_party_talkQW = 10 and Rex_Love = 0: gs 'zz_render', '', '', func('sister_party_strings', '25')
	elseif sister_party_talk >= 3:
		i = rand(1,9)
		if i = 1:''
		gs 'zz_render', '', '', func('sister_party_strings', '26')
		if i = 2:''
		gs 'zz_render', '', '', func('sister_party_strings', '27')
		if i = 3:''
		gs 'zz_render', '', '', func('sister_party_strings', '28')
		if i = 4:''
		gs 'zz_render', '', '', func('sister_party_strings', '29')
		if i = 5:''
		gs 'zz_render', '', '', func('sister_party_strings', '30')
		if i = 6:''
		gs 'zz_render', '', '', func('sister_party_strings', '31')
		if i = 7:''
		gs 'zz_render', '', '', func('sister_party_strings', '32')
		if i = 8:''
		gs 'zz_render', '', '', func('sister_party_strings', '33')
		if i = 9:''
		gs 'zz_render', '', '', func('sister_party_strings', '34')
	end
	act 'Отойти':gt $loc,$metka
}
if $ARGS[0] = 'sister_party':
	*clr & cla
	minut += 5
	gs'stat'
	if $metka = 'party_gost':
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_1.jpg', func('sister_party_strings', '35')
	else
	gs 'zz_render', 'Аня', 'pavlovo/family/sister/sister.jpg', func('sister_party_strings', '36')
	end
	gs 'zz_render', '', '', func('sister_party_strings', '37')
	if $metka = 'party_gost':''
	gs 'zz_render', '', '', func('sister_party_strings', '38')
	act 'Отойти':gt $loc,$metka
	if alko < 6 and $metka = 'party_home': act 'Предлагает выпить': gt'sbReksHome','party_drink'
	if $metka = 'party_gost': act 'Выпить':dynamic $sister_party_drink
	if $metka = 'party_gost': act 'Поболтать о парнях':dynamic $sister_party_talk
end