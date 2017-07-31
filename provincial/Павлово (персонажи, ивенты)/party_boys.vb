if $ARGS[0] = 'drink':
	*clr & cla
	gs 'zz_funcs', 'alko'
	party_boys_drink += 1
	gs 'stat'
	gs 'zz_render', '','pavlovo/family/sister/sisterQW/ReksHome/reksParty_2_' + rand(1,4) + '.jpg'
	i = rand(1,6)
	if i = 1:
		gs 'zz_render', '', '', func('party_boys_strings', '1')
	elseif i = 2:
		gs 'zz_render', '', '', func('party_boys_strings', '2')
	elseif i = 3:
		gs 'zz_render', '', '', func('party_boys_strings', '3')
	elseif i = 4:
		gs 'zz_render', '', '', func('party_boys_strings', '4')
	elseif i = 5:
		gs 'zz_render', '', '', func('party_boys_strings', '5')
	elseif i = 6:
		gs 'zz_render', '', '', func('party_boys_strings', '6')
	end
	act 'Отойти':gt $loc,$metka
		if party_boys_drink > 2:
		*clr & cla
		minut +=5
		gs'stat'
		$V_komnatu ={
			*clr & cla
			minut += 5
			gs'stat'
			i = rand(1,5)
			if i = 1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_1.jpg', func('party_boys_strings', '7')
				if Rex_save =1: gs 'zz_render', '', '', func('party_boys_strings', '8')
				if party_boys_in =1: gs 'zz_render', '', '', func('party_boys_strings', '9')
			elseif i = 2:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_2.jpg', func('party_boys_strings', '10')
				if Rex_save =1: gs 'zz_render', '', '', func('party_boys_strings', '11')
				if party_boys_in =1: gs 'zz_render', '', '', func('party_boys_strings', '12')
			elseif i = 3:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_' + rand(3,4) + '.jpg', func('party_boys_strings', '13')
				if Rex_save = 1: gs 'zz_render', '', '', func('party_boys_strings', '14')
				if party_boys_in = 1: gs 'zz_render', '', '', func('party_boys_strings', '15')
			elseif i = 4:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_5.jpg', func('party_boys_strings', '16')
				if Rex_save =1: gs 'zz_render', '', '', func('party_boys_strings', '17')
				if party_boys_in =1: gs 'zz_render', '', '', func('party_boys_strings', '18')
			elseif i = 5:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_6.jpg', func('party_boys_strings', '19')
				if Rex_save = 1: gs 'zz_render', '', '', func('party_boys_strings', '20')
				if party_boys_in = 1: gs 'zz_render', '', '', func('party_boys_strings', '21')
			end
			if Rex_save =1: act 'Уснуть':dynamic $Party_sleep
			if party_boys_in =1: act 'Сосать':dynamic $party_boys_in
		}
			$Rex_save ={
				*clr & cla
				minut += 5
				Rex_save +=1
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_10.jpg', func('party_boys_strings', '22')
				act 'В комнату':dynamic $V_komnatu
				!end
			}
			!ПЕРЕМЕСТИЛ ГЛОТАТЬ И СПАТЬ В dinParty
			$party_boys_in ={
				*clr & cla
				minut += 5
				bj += 1
				guy += 3
				gang += 1
				sex += 1
				vagina += 2
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_' + rand(7,13) + '.jpg', func('party_boys_strings', '23')
				act 'Отдаться':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_' + rand(15,19) + '.jpg', func('party_boys_strings', '24')
				act 'Кончать':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				cumfrot += 1
				gs'stat'
				i = rand(1,2)
				if i = 1:gs 'zz_render', '','pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_' + rand(20,23) + '.jpg'
				if i = 2:gs 'zz_render', '','pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_5_' + rand(24,25) + '.gif'
				gs 'zz_render', '', '', func('party_boys_strings', '25')
				act 'Уснуть':dynamic $Party_sleep
				end
				end
				!end
			}
			$party_boys_out ={
				*clr & cla
				minut += 5
				bj += 1
				guy += 3
				gang += 1
				sex += 1
				vagina += 2
				gs'stat'
				i = rand(1,4)
				if i = 1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_4.gif', func('party_boys_strings', '26')
				act 'Нагнуться':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_5.gif', func('party_boys_strings', '27')
				act 'Открыть рот':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				cumfrot += 1
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_6.gif', func('party_boys_strings', '28')
				act 'Проглотить':dynamic $party_boys_swalow
				act 'Выплюнуть':dynamic $party_boys_spit
				end
				end
				elseif i = 2:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_7.jpg', func('party_boys_strings', '29')
				act 'Нагнуться':
				*clr & cla
				minut += 5
				cumfrot += 1
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'belly'
				gs 'zz_funcs', 'cum', 'ass'
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_8.gif', func('party_boys_strings', '30')
				gs 'zz_funcs', 'cum', 'pussy'
				act 'Уснуть':dynamic $Party_sleep
				end
				elseif i = 3:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_9.jpg', func('party_boys_strings', '31')
				act 'Дальше':
				*clr & cla
				minut += 5
				cumfrot += 1
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'belly'
				gs 'zz_funcs', 'cum', 'ass'
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_10.jpg', func('party_boys_strings', '32')
				gs 'zz_funcs', 'cum', 'pussy'
				act 'Уснуть':dynamic $Party_sleep
				end
				elseif i = 4:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_11.jpg', func('party_boys_strings', '33')
				act 'Встать':
				*clr & cla
				minut += 5
				cumfrot += 1
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'belly'
				gs 'zz_funcs', 'cum', 'ass'
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_12.gif', func('party_boys_strings', '34')
				act 'Уснуть':dynamic $Party_sleep
				end
				end
			}
			$Stupid_smile ={
				*clr & cla
				minut += 5
				party_boys_in +=1
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_' + rand(1,3) + '.jpg', func('party_boys_strings', '35')
				i = rand(1,2)
				if i = 1:act 'На улицу':dynamic $party_boys_out
				if i = 2:act 'В комнату':dynamic $V_komnatu
				!end
			}
			$Try_save ={
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_3.jpg', func('party_boys_strings', '36')
				act 'Отойти':gt $loc,$metka
				act 'Глупо хихикать':dynamic $Stupid_smile
				!end
			}
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_2_' + rand(1,3) + '.jpg', func('party_boys_strings', '37')
			if $npc['27,relation'] >= 50:gs 'zz_render', '', '','В комнате вы замечаете Рекса...'
			if $npc['27,relation'] >= 50: act 'Взглянуть на Рекса':dynamic $Rex_save
			act 'Глупо хихикать':dynamic $Stupid_smile
			if dom >= 10: act 'Пытаться вырваться':dynamic $Try_save
			end
end
$party_boys_gost_drink ={
	*clr & cla
	gs 'zz_funcs', 'alko'
	party_boys_in += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_1.jpg', func('party_boys_strings', '38')
	if alko >= 5:gs 'zz_render', '', '','-Давай чисто по приколу, покажи нам свои классные сиськи, а?'
	if alko < 7: act 'Отойти':gt $loc,$metka
	if alko >= 5 and alko < 7: act 'Показать сиськи':dynamic $party_boys_boobs
	if alko >= 7: act 'Отрубиться':dynamic $Party_sleep
}
$party_boys_boobs_yes ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_3.jpg', iif(Rex_Love = 1,'Вы полностью игнорируйте Рекса, смеясь вокруг веселых парней.','')
	gs 'zz_render', '', '', func('party_boys_strings', '39')
	act 'Глупо хихикать':
	*clr & cla
	minut += 5
	gs'stat'
	i = rand(1,2)
	if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_4_1.jpg'
	if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_4_2.gif'
	gs 'zz_render', '', '', func('party_boys_strings', '40')
	act 'Смотреть':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_5.jpg', func('party_boys_strings', '41')
	act 'Сосать':
	*clr & cla
	minut += 5
	bj += 1
	guy += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_6.gif', func('party_boys_strings', '42')
	act 'Нагнуться':
	*clr & cla
	minut += 5
	sex += 1
	vagina += 2
	pose = 1
	gs'stat'
	gs 'zz_render', '','pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_7_' + rand(1,2) + '.gif'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_render', '', '', func('party_boys_strings', '43')
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_render', '', '', func('party_boys_strings', '44')
	act 'Кончить':
	*clr & cla
	minut += 5
	cumfrot += 1
	gs 'zz_funcs', 'cum', 'face'
	party_boys_in += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_8.gif', func('party_boys_strings', '45')
	act 'Проглотить':dynamic $party_boys_swalow
	act 'Выплюнуть':dynamic $party_boys_spit
	end
	end
	end
	end
	end
}
$party_boys_boobs ={
	*clr & cla
	minut += 5
	gs'stat'
	i = rand(1,2)
	if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_2_1.gif'
	if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_2_' + rand(2,5) + '.jpg'
	gs 'zz_render', '', '', func('party_boys_strings', '46')
	if Rex_Love = 1:'Рекс недовольно смотрит в вашу сторону, сверкая от злости и ревности.'
	if Rex_Love = 1: act 'Потащить его в туалет': gt 'party_girls','party_girls_rex'
	act 'Ближе':dynamic $party_boys_boobs_yes
	act 'Отойти':gt $loc,$metka
}
$party_boys_gost_drink_else ={
	*clr & cla
	gs 'zz_funcs', 'alko'
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_4.jpg', func('party_boys_strings', '47')
	act 'Осмотреться':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_41.jpg', func('party_boys_strings', '48')
	act 'Сосать':
	*clr & cla
	minut += 5
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_42.gif', func('party_boys_strings', '49')
	act 'Отдаться':
	*clr & cla
	minut += 5
	guy += 3
	gang += 1
	sex += 1
	vagina += 3
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_43.gif', func('party_boys_strings', '50')
	act 'Кончать':
	*clr & cla
	minut += 5
	cumfrot += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'belly'
	gs 'zz_funcs', 'cum', 'ass'
	party_boys_in +=1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_44.jpg', func('party_boys_strings', '51')
	act 'Уснуть':dynamic $Party_sleep
	end
	end
	end
	end
}
$party_boys_gost_home_cum ={
	*clr & cla
	minut += 5
	cumfrot += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'belly'
	party_boys_in +=1
	gs'stat'
	gs 'zz_render', iif(Rex_Love = 0,'Рома и Рекс','Парни'), 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_' + rand(19,20) + '.jpg', func('party_boys_strings', '52')
	act 'Уснуть':dynamic $Party_sleep
}
$party_boys_gost_home_cow ={
	*clr & cla
	minut += 5
	sex += 1
	vagina += 2
	guy += 2
	gang += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_' + iif(rand(1,2) = 1,'16.gif',rand(17,18)+'.jpg'), func('party_boys_strings', '53')
	act 'Кончить':dynamic $party_boys_gost_home_cum
}
$party_boys_gost_home_dog ={
	*clr & cla
	minut += 5
	sex += 1
	vagina += 2
	guy += 2
	gang += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_' + rand(12,14) + '.gif', func('party_boys_strings', '54')
	act 'Кончить':dynamic $party_boys_gost_home_cum
}
$party_boys_gost_home_suck ={
	*clr & cla
	minut += 5
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_'+iif(rand(1,2) = 1,rand(8,9)+'.gif',rand(10,11)+'.jpg'), iif(Rex_Love = 0,'Рома и Рекс','Парни') + 'надавливают на ваши плечики и вы покорно опускаетесь перед ними на колени.'
	gs 'zz_render', '', '', func('party_boys_strings', '55')
	act 'Нагнуться':dynamic $party_boys_gost_home_dog
	act 'Запрыгнуть':dynamic $party_boys_gost_home_cow
}
$party_boys_gost_home_hand ={
	*clr & cla
	minut += 5
	hj +=1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_' + rand(6,7) + '.gif', iif(Rex_Love = 0,'Рома и Рекс','Парни') + ' продолжают вас ласкать, а вы находите рукой их вздыбленные стволы.'
	gs 'zz_render', '', '', func('party_boys_strings', '56')
	act 'Сосать':dynamic $party_boys_gost_home_suck
}
$party_boys_gost_home ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_5.gif', func('party_boys_strings', '57')
	act 'Подрочить':dynamic $party_boys_gost_home_hand
	act 'Сосать':dynamic $party_boys_gost_home_suck
}
$Party_boys_gost_dance ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9_' + rand(1,3) + '.gif', func('party_boys_strings',iif(Rex_Love = 1,'58','59'))
	if Rex_Love = 1:act 'Танцевать с Рексом':dynamic $Party_rex_dance
	act 'Ещё выпить':dynamic $party_boys_gost_drink_else
	act 'Идти с ними':dynamic $party_boys_gost_home
}
$party_boys_dance ={
	*clr & cla
	minut += 5
	gs'stat'
	'<center><img src=""></center>'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_party_gost_9.gif', func('party_boys_strings', '60')
	if dance >= 50:gs 'zz_render', '', '', 'Ваши изгибы и движения в такт музыке будоражат окружающих, что вызывает у вас еще большее удовольствие'
	if dance < 50:gs 'zz_render', '', '', 'Ваши нелепые движения во время танца никого не смущают, вы плохо танцуете, но вам на это наплевать и вы круто отжигаете.'
	act 'Танцевать с Рексом':dynamic $Party_rex_dance
	act 'Танцевать с парнями':dynamic $Party_boys_gost_dance
	act 'Передохнуть':gt $loc,$metka
}
if $ARGS[0] = 'party_boys':
*clr & cla
minut += 5
gs'stat'
if $metka = 'party_kuh' or $metka = 'party_gost':
	'<center><img src=""></center>'
	gs 'zz_render', 'Парни', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys_2.jpg', func('party_boys_strings', '61')
else
	gs 'zz_render', 'Парни', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boys.jpg', func('party_boys_strings', '62')
end
gs 'zz_render', '', '', func('party_boys_strings', '63')
if $metka = 'party_gost':
gs 'zz_render', '', '', func('party_boys_strings', '64')
end
if alko >= 5:
gs 'zz_render', '', '', func('party_boys_strings', '65')
end
act 'Отойти':gt $loc,$metka
if alko < 6 and $metka = 'party_home': act 'Предлагают выпить': gt'sbReksHome','party_drink'
if $metka = 'party_kuh': act 'Предлагают выпить': gt'party_boys','drink'
if $metka = 'party_gost': act 'Пить':dynamic $party_boys_gost_drink
if alko >= 5 and $metka = 'party_gost': act 'Показать сиськи':dynamic $party_boys_boobs
if $metka = 'party_gost': act 'Танцевать':dynamic $party_boys_dance
end