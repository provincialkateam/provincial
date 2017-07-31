$loc = $CURLOC
gs 'dinParty'
gs 'zz_funcs', 'colorize_day'
if $ARGS[0] = 'party':
	*clr & cla
	$metka = $ARGS[0]
	minut += 15
	sisboyparty = 1
	sisboypartyQW += 1
	alkoParty = 0
	if sbReksHomeIn = 0:sbReksHomeIn = 1
	party_girls_talk = 0
	girls_smoke = 0
	party_dj = 0
	dj_beer = 0
	dj_thank = 0
	dj_bad = 0
	dj_boobs = 0
	party_boys_drink = 0
	Rex_save = 0
	party_boys_in = 0
	rex_talk =0
	drunk_sveta = 0
	iralenasleep = 0
	sister_party_dom = 0
	sister_party_talk = 0
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_1_'+rand(1,5)+'.jpg', func('sbReksHome_strings','local_str1')
	act 'Выпить':
		*clr & cla
		gs 'zz_funcs', 'alko'
		alkoParty += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_2_'+rand(1,4)+'.jpg', func('sbReksHome_strings','local_str2')
		act 'Отойти':gt'sbReksHome','party_home'
	end
end
!комната Рекса
if $ARGS[0] = 'party_home':
	*clr & cla
	$metka = $ARGS[0]
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Комната Рекса', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_1_' + rand(1,5) + '.jpg', func('sbReksHome_strings', 'local_str3')
	if alko < 3:
		'Они предлагают вам <a href="exec:GT ''sbReksHome'',''party_drink''">выпить</a> еще немного для поднятия настроения.'
	else
		!Вы пьяны
		*clr
		gs 'zz_render', 'Комната Рекса','pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_1_'+rand(1,5)+'.jpg',func('sbReksHome_strings','local_str4')
		iif(party_girls_talk >= 2,'Можно <a href="exec:GT ''party_girls'',''talk''">поболтать</a> и посплетничать вместе с ними. Одна из девушек где-то надыбала травки и предлагает всем <a href="exec:GT ''party_girls'',''smoke''">покурить</a>.','Можно <a href="exec:GT ''party_girls'',''talk''">поболтать</a> и посплетничать вместе с ними.')
		if manna = 100 and horny >= 50 and girls_smoke > 1: gs 'zz_render', '', '', func('sbReksHome_strings', 'local_str5')
	end
	act 'В гостиную':gt'sbReksHome','party_gost'
end
!Выпить
if $ARGS[0] = 'party_drink':
	*clr & cla
	gs 'zz_funcs', 'alko'
	alkoParty += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_2_'+rand(1,4)+'.jpg', func('sbReksHome_strings','local_str6')
	act 'Отойти': gt $loc,$metka
end
!Гостиная Рекса
if $ARGS[0] = 'party_gost':
	*clr & cla
	$metka = $ARGS[0]
	minut += 5
	gs 'stat'
	if alko < 3:
		gs 'zz_render', 'Гостиная комната', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_3.jpg', func('sbReksHome_strings', 'local_str7')
	else
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_4_'+rand(1,8)+'.jpg', func('sbReksHome_strings', 'local_str8')
		if Rex_Love =0: gs 'zz_render', '', '','<a href="exec:GT ''reks'',''party''">Рекс</a> веселится вместе с <a href="exec:GT ''party_girls'',''party_girls''">девчонками</a> и с вами.'
		if Rex_Love =1: gs 'zz_render', '', '','Вы тусуетесь в окружении <a href="exec:GT ''party_girls'',''party_girls''">девчонок</a> и <a href="exec:GT ''reks'',''party''">Рекса</a>, он пожирает вас влюбленными глазами.'
		gs 'zz_render', '', '', func('sbReksHome_strings', 'local_str9')
	end
	act 'В комнату': gt 'sbReksHome','party_home'
	act 'На кухню': gt 'sbReksHome','party_kuh'
	act 'В туалет': gt 'sbReksHome','party_toilet'
end
!Кухня Рекса
if $ARGS[0] = 'party_kuh':
	*clr & cla
	$metka = $ARGS[0]
	minut += 5
	gs 'stat'
	gs 'zz_render','Кухня','pavlovo/family/sister/sisterQW/ReksHome/Kuh.jpg', func('sbReksHome_strings', 'local_str10')
	if party_dj =1 and dj_beer < 1:gs 'zz_render', '', '','Можно выполнить просьбу и <a href="exec:dynamic $party_dj">взять</a> две бутылки для диджея'
	if alko >= 3: gs 'zz_render', '', '','За столом бухают <a href="exec:GT ''party_boys'',''party_boys''">парни</a> и предлагают <a href="exec:GT ''party_boys'',''drink''">выпить</a> вместе с ними.'
	act 'В гостиную': gt 'sbReksHome','party_gost'
end
!Туалет Рекса
if $ARGS[0] = 'party_toilet':
	*clr & cla
	$metka = $ARGS[0]
	minut += 5
	gs 'stat'
	if alko > 3 and rand(1,100) <= 30: dynamic $party_toilet_event & exit
	gs 'zz_render','Туалет','pavlovo/family/sister/sisterQW/ReksHome/Toilet.jpg',func('sbReksHome_strings', 'local_str13')
	if horny > 50: gs 'zz_render', '', '','Нас вас нахлынуло желание и вы хотите немедленно <a href="exec:dynamic $party_toilet_mast">мастурбировать</a>.'
	act 'Привести себя в порядок':
		*clr & cla
		gs 'zz_render', '', 'images/pic/facesp.jpg', func('sbReksHome_strings', 'local_str11')
		if cumlip > 0 or cumface > 0:
			act 'Смыть сперму с лица 15 мин':
				*clr & cla
				cumlip = 0
				cumface = 0
				sweat -= 1
				minut += 15
				gs 'zz_render', '', 'images/pic/facesp.jpg', func('sbReksHome_strings', 'local_str12')
				act 'Отойти': gt $loc,$metka
			end
		end
		act 'Отойти': gt $loc,$metka
	end
	act 'В гостиную': gt'sbReksHome','party_gost'
end