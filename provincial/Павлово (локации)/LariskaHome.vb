*clr & cla
gs'stat'
if (hour >= 16 and hour < 19 and week < 6) or (hour >= 9 and hour < 19 and (week >= 6 or school['vacation'] > 0)):
	'<center><img src="images/qwest/alter/Lariska/Home/home_1.jpg"></center>'
	if beInLariskaHome = 0:
		gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str1')
		beInLariskaHome = 1
	else
		if rand(1,10) < 3 and week >= 6 and lariskaMotherKnown = 0:
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/Lariska/LariskaMother.jpg', func('LariskaHome_strings', 'local_str2')
			lariskaMotherKnown = 1
		end
		gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str3')
	end
	minut += 5
	act 'Далее':gt 'LariskaHome','in'
else
	'<center><img src="images/qwest/alter/Lariska/LariskaMother.jpg"></center>'
	if lariskaMotherKnown = 0:
		minut += 5
		gs'stat'
		if hour >= 9:$text_home = 'Только, <<$name>>, Ларисы нет дома.'
		if hour < 9:$text_home = '<<$name[1]>>. Ночь на улице, приходи не раньше девяти.'
		gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str4')
		lariskaMotherKnown = 1
		act 'Идти домой':gt'gorodok'
		exit
	end
	if hour >= 9:'Дверь вам открыла мама Ларисы "Привет, <<$name[1]>>. А Ларисы нет дома."'
	if hour < 9:'Дверь вам открыла мама Ларисы "<<$name[1]>>. Ночь на улице, приходи не раньше девяти."'
	act 'Идти домой':gt'gorodok'
end
if $ARGS[0] = 'in':
	*clr & cla
	gs'stat'
	'<center><img src="images/qwest/alter/Lariska/Home/home_1.jpg"></center>'
	frost = 0
	if school['homework'] ! 0:
		act 'Учить уроки':
			cla
			school['homework'] = 0
			minut += 30
			gs'stat'
			if school['progress'] >= 90:
				gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str5')
			else
				gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str6')
			end
			act 'Передохнуть':gt 'LariskaHome','in'
		end
	end
	act 'Болтать':
		*clr & cla
		minut += 10
		gs'stat'
		gs 'zz_render', '', 'images/common/npc/13.jpg', func('LariskaHome_strings', 'local_str7')
		act 'Далее':gt 'LariskaHome','in'
	end
	if hour = 19:
		cla
		gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str8')
		act 'Идти с Лариской':lariskaTrain += 1 & minut += 20 & gt 'gdksport'
		act 'Попрощаться и идти домой':gt'gorodok'
		exit
	end
	if water >= 18:
		act 'Отойти в туалет':
			*clr & cla
			minut += 5
			gs'stat'
			if week < 6:
				gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str9')
				act 'Вернуться':gt 'LariskaHome','in'
			elseif week >= 6:
				lariskaRand = rand(1,100)
				'<center><img src="images/qwest/alter/Lariska/Home/home_2.jpg"></center>'
				if lariskaRand <= 10 and lariskaBDSM < 10:
					gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str10')
					lariskaBDSM += 1
				elseif lariskaRand >= 90 and lariskaBDSM < 10:
					gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str11')
					lariskaBDSM += 1
				elseif lariskaRand <= 10 and lariskaBDSM >= 10:
					gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str12')
				else
					gs 'zz_render', '', '', func('LariskaHome_strings', 'local_str13')
				end
				act 'Вернуться':gt 'LariskaHome','in'
			end
		end
	end
	if lariskaTrain > 5 and LariskaProfi = 0 and hour >= 16:
		act 'Поговорить с Лариской о становлении профи волейболисткой.':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/common/npc/13.jpg', func('LariskaHome_strings', 'local_str14')
			if volleyboll < 100:
				act 'Прекратить разговор':gt 'LariskaHome','in'
				act 'Сказать, что пойдете вместе с ней, чтобы поддержать её.':lariskaTrenerTalk = 1 & minut += 15 & gt 'Voltrener'
			elseif volleyboll >= 100 and volleysostav = 0:
				act 'Прекратить разговор':gt 'LariskaHome','in'
				act 'Сказать, что пойдете вместе с ней, чтобы поддержать её.':lariskaTrenerTalk = 2 & minut += 15 & gt 'Voltrener'
				act 'Сказать, что пойдете вместе с ней, чтобы вместе попроситься в команду.':lariskaTrenerTalk = 3 & minut += 15 & gt 'Voltrener'
			elseif volleyboll >= 100 and volleysostav > 0:
				act 'Прекратить разговор':gt 'LariskaHome','in'
				act 'Сказать, что пойдете вместе с ней, чтобы поддержать её.':lariskaTrenerTalk = 4 & minut += 15 & gt 'Voltrener'
			end
		end
	end
	act 'Попрощаться и идти домой':gt'gorodok'
end