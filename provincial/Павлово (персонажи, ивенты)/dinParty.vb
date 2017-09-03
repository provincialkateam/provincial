!Случайное событие в туалете
$party_toilet_event = {
	i = rand(1,8)
	if toiletEvent_Girls = daystart:i += 1
	if toiletEvent_Rex = daystart:i += 1
	if toiletEvent_Sis = daystart:i += 1
	if toiletEvent_SisBoy = daystart:i = 1
	*clr & cla
	minut += 5
	gs'stat'
	if i = 1:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_2_' + rand(1,2) + '.jpg', func('dinParty_strings', '1')
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 2:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_3_' + rand(1,5) + '.jpg', func('dinParty_strings', '2')
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 3:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_4.jpg', func('dinParty_strings', '3')
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 4:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_1.jpg', func('dinParty_strings', '4')
		act 'Помочь':
			*clr & cla
			toiletEvent_Rex = daystart
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_2.jpg', func('dinParty_strings', '5')
			act 'Дрочить':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_' + rand(3,4) + '.jpg', func('dinParty_strings', '6')
				act 'Кончить':
					*clr & cla
					minut += 5
					gs'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_5.jpg', func('dinParty_strings', '7')
					act 'Отойти':gt $loc,$metka
				end
			end
			act 'Сосать':
				*clr & cla
				minut += 5
				bj += 1
				if reksMeet = 1:bja += 1
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_' + rand(6,10) + '.jpg', func('dinParty_strings', '8')
				act 'Кончить':
					*clr & cla
					minut += 5
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					gs'stat'
					i = rand(11,18)
					if i = 11:
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_<<i>>.gif'
					else
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_5_<<i>>.jpg'
					end
					gs 'zz_render', '', '', func('dinParty_strings', '9')
					act 'Отойти':gt $loc,$metka
				end
			end
		end
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 5:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_6_1.jpg', func('dinParty_strings', '10')
		act 'Облизать':
			*clr & cla
			toiletEvent_Sis = daystart
			minut += 5
			gs 'zz_funcs', 'cum', 'lip'
			gs'stat'
			i = rand(2,5)
			if i = 2 or i = 4:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_6_<<i>>.gif'
			else
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_6_<<i>>.jpg'
			end
			gs 'zz_render', '', '', func('dinParty_strings', '11')
			act 'Отойти':gt $loc,$metka
		end
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 6:
		toiletEvent_Girls = daystart
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_1.jpg', func('dinParty_strings', '12')
		act 'Наблюдать':
			*clr & cla
			minut += 5
			horny += 10
			gs'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_2.jpg', func('dinParty_strings', '13')
			act 'Смотреть':
				*clr & cla
				minut += 5
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_3.gif', func('dinParty_strings', '14')
				act 'Войти':
					*clr & cla
					minut += 5
					gs'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_4.jpg', func('dinParty_strings', '15')
					act 'Остаться':
						*clr & cla
						minut += 5
						horny += 10
						lesbian += 1
						gs'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_5.jpg', func('dinParty_strings', '16')
						act 'Наслаждаться':
							*clr & cla
							minut += 5
							horny = 0
							orgasm += 1
							manna = 100
							gs'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_6.gif', func('dinParty_strings', '17')
							act 'Поболтать':
								*clr & cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_7_7.gif', func('dinParty_strings', '18')
								act 'Отойти':gt $loc,$metka
							end
						end
					end
					act 'В гостиную':gt'sbReksHome','party_gost'
				end
				act 'В гостиную':gt'sbReksHome','party_gost'
			end
			act 'В гостиную':gt'sbReksHome','party_gost'
		end
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 7:
		i = rand(1,3)
		if i = 2:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_8_<<i>>.gif'
		else
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_8_<<i>>.jpg'
		end
		gs 'zz_render', '', '', func('dinParty_strings', '19')
		act 'В гостиную':gt'sbReksHome','party_gost'
	elseif i = 8:
		toiletEvent_SisBoy = daystart
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_9.jpg', func('dinParty_strings', '20')
		act 'В гостиную':gt'sbReksHome','party_gost'
	end
}
!Мастурбировать в туалете
$party_toilet_mast = {
	cla
	*clr
	minut += 5
	horny = 0
	orgasm += 1
	mastr += 1
	gs'stat'
	i = rand(1,3)
	if i < 3:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_1_<<i>>.jpg'
	if i = 3:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_toilet_1_<<i>>.gif'
	gs 'zz_render', '', '', func('dinParty_strings', '21')
	act 'Отойти':gt $loc,$metka
}
!Динамики для диджея
$party_dj ={
	cla
	*clr
	minut += 5
	dj_beer =1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_2_3.jpg', func('dinParty_strings', '22')
	act 'Отойти':gt $loc,$metka
}
$party_dj_beer ={
	cla
	*clr
	minut += 5
	dj_thank =1
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy.jpg', func('dinParty_strings', '23')
	act 'Отойти':gt $loc,$metka
}
$party_dj_thank ={
	cla
	*clr
	minut += 5
	dj_bad =1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy_1.jpg', func('dinParty_strings', '24')
	act 'Отойти':gt $loc,$metka
}
$party_dj_boobs ={
	cla
	*clr
	minut += 5
	dj_boobs = 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy_2.jpg', func('dinParty_strings', '25')
	act 'Отойти':gt $loc,$metka
	act 'Продолжить':dynamic $party_dj_cock
}
$party_dj_cock ={
	cla
	*clr
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy_3.jpg', func('dinParty_strings', '26')
	act 'Отойти':gt $loc,$metka
	act 'Взять его':dynamic $party_dj_suck
}
$party_dj_suck ={
	cla
	*clr
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy_4.jpg', func('dinParty_strings', '27')
	if Rex_Love = 1:gs 'zz_render', '', '', 'Вы подумали,что Рексу ваши игры с диджеем не понравятся, поразвлекались и хватит.'
	act 'Отойти':gt $loc,$metka
	if Rex_Love = 0:
	act 'Приласкать':
	cla
	*clr
	minut += 5
	bj += 1
	gs'stat'
gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy_5.jpg', func('dinParty_strings', '28')
	act 'Повернуться':
	cla
	*clr
	minut += 5
	guy += 1
	sex += 1
	vagina += 1
	cumfrot += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_boy_6.gif', func('dinParty_strings', '29')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Отойти':gt $loc,$metka
	end
	end
	end
}
!Динамик танца
$party_dance ={
	cla
	*clr
	minut += 5
	gs'stat'
gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_gost_1_' + rand(1,7) + '.gif', func('dinParty_strings', '30')
	if dance >= 50:gs 'zz_render', '', '', 'Ваши изгибы и движения в такт музыке будоражат окружающих, что вызывает у вас еще большее удовольствие'
	if dance < 50:gs 'zz_render', '', '', 'Ваши нелепые движения во время танца никого не смущают, вы плохо танцуете, но вам на это наплевать и вы круто отжигаете.'
	act 'Передохнуть':gt $loc,$metka
	act 'Танцевать еще':dynamic $party_dance
	}
	!ДИНАМИК СНА
	$Party_sleep ={
				*clr & cla
				minut += 5
				gs'stat'
				if Rex_save =1 and Rex_Love =1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_13_' + rand(1,4) + '.jpg', func('dinParty_strings', '31')
				elseif Rex_save =1 and Rex_Love =0:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_12_' + rand(1,11) + '.jpg', func('dinParty_strings', '32')
				elseif iralenasleep >=1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_6_' + rand(6,7) + '.jpg', func('dinParty_strings', '33')
				elseif drunk_sveta >=1 and sister_party_dom < 1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_4_' + rand(1,3) + '.jpg', func('dinParty_strings', '34')
				elseif sister_party_dom >=1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_9_' + rand(3,5) + '.jpg', func('dinParty_strings', '35')
				elseif party_boys_in >=1:
				i = rand(1,3)
				if i = 1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_6_' + rand(1,9) + '.jpg', func('dinParty_strings', '36')
				elseif i = 2:
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_8_' + rand(1,5) + '.jpg', func('dinParty_strings', '37')
				elseif i = 3:
				i = rand(1,2)
				if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_9_' + rand(1,2) + '.jpg'
				if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_9_3.gif'
				gs 'zz_render', '', '', func('dinParty_strings', '38')
				end
				end
				act 'Проснуться':
				*clr & cla
				minut += 90
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_7.jpg', func('dinParty_strings', '39')
				if Rex_save =1 and Rex_Love =0:gs 'zz_render', '', '', 'Выходя из квартиры, вы нежно целуете Рекса в щечку, поблагодарив за вечер.'
				if Rex_Love =1:gs 'zz_render', '', '', 'Выходя из квартиры, вы страстно целуете Рекса в губы, благодаря за прекрасный вечер.'
				if party_boys_in >=1:gs 'zz_render', '', '', 'Выходя из квартиры, пьяные парни с вами оживленно прощаются, и немного вас этим смущают'
				if hour < 22 and hour > 18:
				hour = 22
				minut = 0
				act 'Идти домой':gt 'bedrPar'
				else
				act 'Идти домой':minut += 15 & gt'bedrPar'
				end
				end
			}
	$party_boys_swalow ={
				*clr & cla
				minut += 5
				vaf += 1
				swallow += 1
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_' + rand(13,15) + '.gif', func('dinParty_strings', '40')
				act 'Уснуть':dynamic $Party_sleep
				!end
			}
			$party_boys_spit ={
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_' + rand(16,17) + '.gif', func('dinParty_strings', '41')
				act 'Уснуть':dynamic $Party_sleep
				!end
			}
 !ДИНАМИК Рекс
$Party_rex_hug ={
	*clr & cla
	minut += 5
	gs'stat'
	if Rex_Love =1:
		i = rand(1,2)
		if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_4_1.gif'
		if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_4_' + rand(2,5) + '.jpg'
		gs 'zz_render', '', '', func('dinParty_strings', '42')
		act 'Поцеловать':
			*clr & cla
			*clr
			minut += 5
			gs'stat'
			i = rand(1,2)
			if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_5_1.jpg'
			if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_5_' + rand(2,4) + '.gif'
			gs 'zz_render', '', '', func('dinParty_strings', '43')
			act 'Отойти':gt $loc,$metka
			act 'Идти за ним':dynamic $Party_rex_sex
		end
	end
	if Rex_Love = 0:
		i = rand(1,2)
		if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_13_' + rand(4,7) + '.jpg'
		if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_13_' + rand(1,3) + '.gif'
		gs 'zz_render', '', '', func('dinParty_strings', '44')
		act 'Идти за ним':dynamic $Party_rex_sex
	end
}
$Party_rex_dance ={
	*clr & cla
	minut += 5
	gs 'stat'
	i = rand(1,2)
	if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_3_' + rand(4,6) + '.gif'
	if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_3_' + rand(1,3) + '.jpg'
	gs 'zz_render', '', '', func('dinParty_strings', '45')
	act 'Отойти':gt $loc,$metka
	if rex_talk >=2: act 'Обнять':dynamic $Party_rex_hug
}
$Party_rex_talk ={
	*clr & cla
	gs 'zz_funcs', 'alko'
	rex_talk +=1
	gs 'stat'
	if Rex_Love = 1:
		i = rand(1,2)
		if i = 1:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_1_1.gif'
		if i = 2:gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_1_' + rand(2,7) + '.jpg'
		gs 'zz_render', '', '', func('dinParty_strings', '46')
		i = rand(1,7)
		if i = 1: gs 'zz_render', '', '', '- На планете есть семь чудес <<$name[1]>>, но есть еще одно, самое очаровательное и красивое - это ты!'
		if i = 2: gs 'zz_render', '', '', '- Ты, та, о ком я думаю каждую секунду, минуту, час, сутки!'
		if i = 3: gs 'zz_render', '', '', '- Я не могу поверить, в то, что я встретил такую очаровательную девушку как, ты!'
		if i = 4: gs 'zz_render', '', '', '- Я хочу подарить тебе весь мир вокруг! Просто потому, что не могу жить без тебя!'
		if i = 5: gs 'zz_render', '', '', '- Когда я смотрю в твои очаровательные глаза, я вижу взгляд ангела!'
		if i = 6: gs 'zz_render', '', '', '- Все думают, что солнце только на небе, Но я то знаю, что солнышко рядом со мной'
		if i = 7: gs 'zz_render', '', '', '- Ты такая великолепная, что я просто не могу оторвать от тебя взгляда, для меня нет большего счастья, чем быть рядом с тобой.'
		act 'Отойти':gt $loc,$metka
	end
	if Rex_Love = 0:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_2_' + rand(1,5) + '.gif', func('dinParty_strings', '47')
		i = rand(1,7)
		if i = 1:gs 'zz_render', '', '', '- <<$name[2]>>, ты очень красивая, а красивых девушек надо размножать.'
		if i = 2:gs 'zz_render', '', '', '- Не грусти, а то грудь не будет расти, веселись и сексом займись, ахаха.'
		if i = 3:gs 'zz_render', '', '', '- <<$name[2]>>, от тебя так приятно пахнет! Что ты сегодня пила?'
		if i = 4:gs 'zz_render', '', '', '- Ты так на меня смотришь, как будто я уже голый.'
		if i = 5:gs 'zz_render', '', '', '- Хотел бы я быть твоим тренером по фитнесу!'
		if i = 6:gs 'zz_render', '', '', '- Ты сегодня прекрасно выглядишь! Много бухала?'
		if i = 7:gs 'zz_render', '', '', '- У меня стоит важный вопрос — у тебя не чешется скорейший ответ?'
		if i = 8:gs 'zz_render', '', '', '- Вот смотрю я на тебя и думаю: еще выпить, или ты мне уже нравишься... '
		if i = 9:gs 'zz_render', '', '', '- Ну и ножки у тебя классные. Одна лучше другой, ей богу.'
		act 'Отойти':gt $loc,$metka
	end
}