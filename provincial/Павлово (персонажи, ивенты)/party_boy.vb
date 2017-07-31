if $ARGS[0] = 'party_boy':
	*clr & cla
	minut += 5
	party_dj = 1
	gs 'stat'
	$zz_str = 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy.jpg'
	if party_dj = 1 and dj_beer < 1:
		gs 'zz_render', 'Диджей', $zz_str, func('party_boy_strings', 'local_str1')
	elseif dj_beer = 1 and dj_thank < 1:
		gs 'zz_render', 'Диджей', $zz_str, func('party_boy_strings', 'local_str2')
		'Вы взяли на кухне две бутылки пива и можете <a href="exec:dynamic $party_dj_beer">передать</a> их парням.'
	elseif dj_thank = 1 and dj_bad < 1:
		gs 'zz_render', 'Диджей', $zz_str, func('party_boy_strings', 'local_str3')
		'Вам разрешили <a href="exec:dynamic $party_dj_thank">покрутить</a> вертушку.'
	elseif dj_bad = 1 and dj_boobs < 1:
		gs 'zz_render', 'Диджей', $zz_str, func('party_boy_strings', 'local_str4')
	elseif dj_boobs = 1:
		gs 'zz_render', 'Диджей', $zz_str, func('party_boy_strings', 'local_str5')
		'Вам снова разрешили <a href="exec:dynamic $party_dj_cock">покрутить</a> вертушку.'
	end
	killvar '$zz_str'
	act 'Отойти':gt $loc,$metka
	if dj_bad = 1 and alko >= 3: act 'Оголить грудь': dynamic $party_dj_boobs
end