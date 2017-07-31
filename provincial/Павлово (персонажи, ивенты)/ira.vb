$Party_iralenafun_boys_fuck ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_6_' + rand(3,4) + '.jpg', func('ira_strings', '1')
	act 'Кончить':
		*clr & cla
		minut += 5
		cumfrot += 1
		gs 'zz_funcs', 'cum', 'belly'
		iralenasleep +=1
		gs'stat'
		gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_6_5.jpg', func('ira_strings', '2')
		act 'Уснуть':dynamic $Party_sleep
	end
}
$Party_iralenafun_boys ={
	*clr & cla
	minut += 5
	guy += 1
	gang += 3
	sex += 1
	vagina += 2
	gs'stat'
	gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_4.jpg', func('ira_strings', '3')
	act 'Сосать':
		*clr & cla
		minut += 5
		bj += 1
		gs'stat'
		gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_6_' + rand(1,2) + '.jpg', func('ira_strings', '4')
		act 'Потрахаться': dynamic $Party_iralenafun_boys_fuck
	end
	act 'Потрахаться':dynamic $Party_iralenafun_boys_fuck
}
$Party_iralenafun_boy_cum ={
	*clr & cla
	minut += 5
	cumfrot += 1
	gs'stat'
	if rand(1,2) = 1:
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_funcs', 'cum', 'belly'
		gs'stat'
		gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_5_6.jpg',iif(Rex_Love = 0,'Рекс','Рома') + ' выстрелил вас и обляпал всю вашу упругую попку. Лена и Ира не долго думая принялись всё облизывать, целуясь с вами и обмениваясь вкусом спермы.'
	else
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_funcs', 'cum', 'lip'
		gs'stat'
		gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_5_' + rand(7,8) + '.gif', func('ira_strings', '5')
	end
	act 'Отойти':gt 'sbReksHome','party_home'
}
$Party_iralenafun_boy ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_'+iif(rand(1,2)=1,'4_1.jpg','4_2.gif')+'', func('ira_strings', '6')
	act 'Сосать вместе':
		*clr & cla
		minut += 5
		bj += 1
		gs'stat'
		gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_5_'+iif(rand(1,2)=1,rand(1,2)+'.jpg','3.gif')+'', func('ira_strings', '7')
		act 'Лечь на спину':
			*clr & cla
			minut += 5
			guy += 1
			gang += 1
			sex += 1
			vagina += 1
			gs'stat'
			gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_5_4.jpg', func('ira_strings', '8')
			act 'Кончить':dynamic $Party_iralenafun_boy_cum
		end
		act 'Нагнуться':
			*clr & cla
			minut += 5
			guy += 1
			gang += 1
			sex += 1
			vagina += 1
			gs'stat'
			gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_5_5.jpg', func('ira_strings', '9')
			act 'Кончить':dynamic $Party_iralenafun_boy_cum
		end
	end
}
$Party_iralenafun ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_3_'+iif(rand(1,2)=1,'1.jpg','2.gif')+'', func('ira_strings', '10')
	if rand(1,2) = 1:
		gs 'zz_render', '', '', func('ira_strings', '11')+iif(Rex_Love = 1,'Рекс злобно посмотрел в сторону Ромы и вашей женской компании.','')
		act'Идти с ним': dynamic $Party_iralenafun_boy
		if Rex_Love = 1: act 'Остаться с Рексом':dynamic $Party_rex_talk
	else
		gs 'zz_render', '', '', func('ira_strings', '12')+iif(Rex_Love = 1,'Рекс злобно посмотрел в сторону вашей женской компании.','')
		act'Идти с ними':dynamic $Party_iralenafun_boys
		if Rex_Love = 1:act 'Остаться с Рексом':dynamic $Party_rex_talk
	end
}
$Party_ira_drink ={
	*clr & cla
	gs 'zz_funcs', 'alko'
	drunk_sveta += 1
	gs 'stat'
	gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_2.jpg', func('ira_strings', '13')+iif(alko >= 7,'Голова внезапно сильно закружилась и вы готовы в любой момент...','')
	if alko >= 7: act 'Отрубиться':dynamic $Party_sleep
	if alko < 7: act 'Веселиться':dynamic $Party_iralenafun
	if alko < 7: act 'Отойти':gt $loc,$metka
}
$Party_ira_dance ={
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_gost_1_'+ rand(1,7)+'.gif', func('ira_strings', '14')+iif(dance >= 50,'Ваши изгибы и движения в такт музыке будоражат окружающих, что вызывает у вас еще большее удовольствие','Ваши нелепые движения во время танца никого не смущают, вы плохо танцуете, но вам на это наплевать и вы круто отжигаете.')
	act 'Передохнуть':gt $loc,$metka
		act 'Целоваться':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_7_'+rand(1,2)+'.jpg', func('ira_strings', '15')
		act 'Отойти':gt $loc,$metka
		act 'Продолжить ласки':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_7_3.jpg', func('ira_strings', '16')
			if Rex_Love = 1: gs 'zz_render', '', '', func('ira_strings', '17')
			act 'Отойти':gt $loc,$metka
			act 'Потащить девчонок в комнату':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_7_4.jpg', func('ira_strings', '18')
				act 'Игры':
					*clr & cla
					minut += 5
					gs'stat'
					gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_7_'+iif(rand(1,2) = 1, rand(5,7), rand(8,9))+'.jpg', func('ira_strings', '19')
					act 'Кончить':
						*clr & cla
						minut += 5
						iralenasleep +=1
						gs'stat'
						gs 'zz_render', 'Ира и Лена', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_7_10.gif', func('ira_strings', '20')
						act 'Уснуть':dynamic $Party_sleep
					end
				end
			end
		end
	end
}
if $ARGS[0] = 'ira':
	*clr & cla
	minut += 5
	gs'stat'
	'<center><b><font color = maroon></font></b></center>'
	if $metka = 'party_gost':
		gs 'zz_render', 'Ира','pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_1_' + rand(1,5) + '.jpg', func('ira_strings', '21')
	else
		gs 'zz_render', 'Ира','pavlovo/family/sister/sisterQW/ReksHome/Ira.jpg', func('ira_strings', '22')
	end
	act 'Отойти':gt $loc,$metka
	if alko < 6 and $metka = 'party_home': act 'Предлагает выпить': gt'sbReksHome','party_drink'
	if $metka = 'party_gost':act 'Выпить':dynamic $Party_ira_drink
	if $metka = 'party_gost':act 'Танцевать':dynamic $Party_ira_dance
end