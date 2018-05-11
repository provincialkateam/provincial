if $args[0] = 'check_talktime':
	cla
	!gs 'npc_editor','get_npc_profile',37
	i=0
	if mother['talk_count'] = mother['talk_max_count']:
		mother['talk_count'] += 1
		gs 'zz_render','','','\\\- Ну ты, Света, и болтушка!///'
		if $mother['location'] = 'sitrPar':
			if hour <= 17 and sunWeather >= 0:
				gs 'zz_render','','','\\\- Сходи на улицу, погуляй, погодка-то прекрасная.///'
			elseif hour <= 17 and sunWeather < 0:
				gs 'zz_render','','','\\\- Может, поможешь мне по дому?\\\'
			end
			if hour >= 18 and school['vacation'] = 0 and day < 6: gs 'zz_render','','','\\\- Помоги лучше Кольке с уроками.///'
		elseif $mother['location'] = 'kuhrPar':
			gs 'zz_render','','','\\\- Лучше Помоги мне с посудой\\\'
		elseif $mother['location'] = 'glake':
			gs 'zz_render','','','\\\- Ложись уже, всё солнце мне загородила\\\'
		else
			gs 'zz_render','','','\\\ - Давай позже поболтаем - сейчас я немного занята.//////'
		end
		i = 1
	elseif mother['talk_count'] > mother['talk_max_count']:
		! задрала болтовней в доску
		gs 'npc_editor','change_rep','-', 37
		manna -= 5
		mother['talk_count'] = 100
		gs 'zz_render','','','\\\Света, ну хватит уже разговоров! Сама ничерта не делаешь, еще и меня отвлекаешь/// - прикрикнула на вас мама.'
		i = 1
	end
end
if $args[0] = 'talk':
	cla
	gs 'dinmother', 'check_talktime'
	if i =0:
		if $npc['37,relation'] < 40:
			if mom_saw_you_peeking = 1:
				gs 'zz_render','','', func('dinmother_strings', 79)
				gs 'npc_editor','change_rep','-', 37, rand(5, 7)
				killvar 'mom_saw_you_peeking'
			else
				gs 'zz_render','','', func('dinmother_strings', rand(44,45))
				if mothersorryday ! day:
					act iif($npc['37,relation'] <= 20,'Просить прощения','Пытаться сгладить отношения'):
						cla
						mothersorryday = day
						mother['talk_count'] += 1
						minut += rand(10,15)
						gs 'npc_editor','change_rep','+', 37, 10
						gs 'zz_render','','',iif($npc['37,relation'] <= 20,'Вы извиняетесь перед мамой и она, кажется, вас прощает.','Вы подлизываетесь к маме и она, кажется, начинает к вам лучше относится.')
						act '<B>Отойти</B>': gs 'dinmother', 'go_out'
					end
				end
			end
		else
			if mom_saw_you_peeking = 1:
				if $npc['37,relation'] > 80:
					gs 'zz_render','','', func('dinmother_strings', 81)
				else
					gs 'zz_render','','', func('dinmother_strings', 80)
				end
				killvar 'mom_saw_you_peeking'
			else
				if $npc['37,relation'] > 80 and rand(0,5) = 2:
					gs 'zz_render','','',func('dinmother_strings', rand(67,70))
				else
					gs 'zz_render','','', func('dinmother_strings', 46)+ func('dinmother_strings', rand(47,66))
				end
			end
			minut += rand(10,15)
			mother['talk_count'] += 1
			gs 'npc_editor','change_rep','+', 37, rand(3,5)
		end
	end
	gs 'stat'
	act '<B>Отойти</B>': gs 'dinmother', 'go_out'
	killvar '$_str'
	killvar 'i'
end
if $args[0] = 'clothes':
	if cloth[0] < 2:
		cla
		act '<B>Отойти</B>': gt 'bedrPar'
		if motherKnowWhore = 0 and motherKnowSpravka = 0 and $npc['37,qwMother'] = 0:
			if momslut < 2:
				gs 'zz_render','','', func('dinmother_strings', 1)
			else
				gs 'zz_render','','', func('dinmother_strings', 2)
			end
		elseif (motherKnowWhore + motherKnowSpravka) > 0 and $npc['37,qwMother'] = 1:
			if momslut < 2:
				gs 'zz_render','','', func('dinmother_strings', 3)
			else
				gs 'zz_render','','', func('dinmother_strings', 4)
			end
		elseif $npc['37,qwMother'] >= 2:
			gs 'zz_render','','', func('dinmother_strings', 5)
		end
		exit
	end
	if func('zz_clothing2','is_glamour') = 1 and hour > 9:
		gs 'zz_render','','', func('dinmother_strings', 6)
	end
	if pregTalkFamily = 0 and pregTalkMom = 0:
		if cloth[0] <= 2 and pregnancy > 90: gs 'zz_render','','', func('dinmother_strings', 7)
		pregTalkFamily = 1
		pregTalkMom = 1
		act '<B>Отойти</B>': gt $loc, $metka
		exit
	end
end
if $args[0] = 'piercing':
	motherpirsday = day
	if pirsA >= 1 and pirsAmother = 0:
		!пирсинг языка
		if rand(1,100) >= 75:
			cla
			gs 'zz_render','','', func('dinmother_strings', 8)
			act 'Ничего':
				cla
				gs 'zz_render','','', func('dinmother_strings', 9)
				act '<B>Отойти</B>': gt $loc, $metka
			end
			act'Показать пирсинг языка':
				*clr & cla
				pirsAmother = 1
				gs 'zz_render','','images/picb/piercing/pirsA.jpg', func('dinmother_strings', 10)
				act '<B>Отойти</B>': gt $loc, $metka
			end
		end
		exit
	end
	if pirsB = 1 and pirsBmother = 0:
		!пирсинг губ
		cla
		gs 'zz_render','','', func('dinmother_strings', 11)
		act 'Мне понравилось':
			*clr & cla
			pirsBmother = 1
			gs 'zz_render','','images/picb/piercing/pirsB.jpg', func('dinmother_strings', 12)
			act '<B>Отойти</B>': gt $loc, $metka
		end
		exit
	end
	if pirsC = 1 and pirsCmother = 0:
		!сережки
		pirsCmother = 1
		gs 'zz_render','','', func('dinmother_strings', 13)
		exit
	end
	if pirsD = 1 and pirsDmother = 0:
		!кольцо в носу
		pirsDmother = 1
		gs 'zz_render','','', func('dinmother_strings', 14)
		exit
	end
	if pirsE = 1 and pirsEmother = 0:
		!пирсинг брови
		pirsEmother = 1
		gs 'zz_render','','', func('dinmother_strings', 15)
		exit
	end
end
if $args[0] = 'hair':
	!проверка цвета волос
	gs 'zz_render','','', func('dinmother_strings', 71)
	hcolmotherremember = hcol
end
if $args[0] = 'virgin_check':
	if school['certificate'] = 0:
		if GspravkaT = 0 and GspravkaTimes >= 3 and motherKnowSpravka = 0:
			cla
			if hour >= 7 and hour <= 17:
				gs 'npc_editor','change_rep','-', 37
				gs 'zz_render','','', func('dinmother_strings', 16)
				act 'Идти к гинекологу за справкой':
					*clr & cla
					minut += rand(20,40)
					gs 'zz_render','','pavlovo/family/mother/ginekolog.jpg', func('dinmother_strings', 17)
					Gspravka = 7
					GspravkaT = iif(vagina > 0,2,1)
					if vagina > 0:
						gs 'zz_render','','', func('dinmother_strings', 18)
					else
						gs 'zz_render','','', func('dinmother_strings', 19)
					end
					act '<B>Выйти</B>': gt $curloc
				end
			else
				gs 'zz_render','','', func('dinmother_strings', 20)
				act '<B>Отойти</B>': gt 'dinmother', 'go_out'
			end
			exit
		elseif GspravkaT = 0 and GspravkaTimes < 3 and motherKnowSpravka = 0:
			GspravkaTimes += 1
			gs 'zz_render','','', func('dinmother_strings', 21)
		elseif GspravkaT = 2 and motherKnowSpravka = 0:
			cla
			if motherKnowWhore = 0:
				$npc['37,relation'] = 0
				motherKnowSpravka = 1
				if momslut < 2:
					gs 'zz_render','','', func('dinmother_strings', 22)
				else
					gs 'zz_render','','', func('dinmother_strings', 23)
				end
			elseif motherKnowWhore > 0 and $npc['37,qwMother'] < 2:
				gs 'npc_editor','change_rep','-', 37, 10
				motherKnowSpravka = 1
				gs 'zz_render','','', func('dinmother_strings', 24)
			elseif $npc['37,qwMother'] >= 2:
				motherKnowSpravka = 2
				gs 'zz_render','','', func('dinmother_strings', 25)
			end
			act '<B>Отойти</B>': gs 'dinmother', 'go_out'
			exit
		end
	end
end
if $args[0] = 'money_talk':
	act 'Просить денег':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'npc_editor','get_npc_profile',37
		gs 'zz_render','','', func('dinmother_strings', 26)
		if func('zz_reputation','get') = 4:
			gs 'zz_render','','', func('dinmother_strings', 27)
			act '<B>Отойти</B>': gs 'dinmother', 'go_out'
			exit
		end
		zz_rel = ($npc['37,relation'] - 1) / 20 - 1
		zz_money = zz_rel * 100 - 50
		if zz_money < 0: zz_money = 0
		if school['certificate'] = 0:
			if motherPayDay = day:
				gs 'zz_render','','', func('dinmother_strings', zz_rel+74)
			else
				gs 'npc_editor','change_rep','-', 37
				motherPayDay = day
				if zz_rel > 0:
					if school['progress'] < 70:
						zz_money = 0
					elseif school['progress'] >= 90:
						zz_money += 100
					end
				end
				if zz_rel > 0:
					if school['progress'] < 70:
						gs 'zz_render','','',func('dinmother_strings', 72)
					elseif school['progress'] >= 70 and school['progress'] < 90:
						gs 'zz_render','','',func('dinmother_strings', 73)
					else
						gs 'zz_render','','',func('dinmother_strings', 74)
					end
					money += zz_money
				else
					if motherKnowWhore = 0 and motherKnowSpravka = 0:
						gs 'zz_render','','', func('dinmother_strings', 28)
					end
					if motherKnowWhore >= 1 or motherKnowSpravka >= 1:
						gs 'zz_render','','', func('dinmother_strings', 29)
					end
				end
			end
			act '<B>Отойти</B>': gs 'dinmother', 'go_out'
		else
			gs 'zz_render','','', func('dinmother_strings', 30)
		end
		killvar '$zz_money_str'
		killvar '$zz_no_money'
		killvar 'zz_rel'
		killvar 'zz_money'
		act '<B>Отойти</B>': gs 'dinmother', 'go_out'
	end
end
if $args[0] = 'go_out':
	if $mother['location'] = 'kuhrPar': gt 'kuhrPar'
	if $mother['location'] = 'sitrPar': gt 'sitrPar'
	if $mother['location'] = 'shop': gt 'shop'
	if $mother['location'] = 'grinok': gt 'grinok', 'main'
	if $mother['location'] = 'glake': gt 'glake'
	gt $loc, $metka
end
if $args[0] = 'cloth_talk':
	act 'Просить новую одежду':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'npc_editor','get_npc_profile',37
		gs 'zz_render','','', func('dinmother_strings', 31)
		if func('zz_reputation','get') = 4:
			gs 'zz_render','','', func('dinmother_strings', 32)
			act '<B>Отойти</B>': gs 'dinmother', 'go_out'
			exit
		end
		if school['certificate'] = 0:
			if $npc['37,relation'] >= 80:
				if motherClotheMonth ! month:
					motherClotheMonth = month
					minut += rand(30,50)
					gs 'stat'
					gs 'zz_render','','', func('dinmother_strings', 33)
					act 'Выбрать одежду':
						*clr & cla
						gs 'zz_render','','images/common/clothing/3/' + func('zz_clothing2','add_rand_dress',3),func('dinmother_strings', 75)
						act '<B>Отойти</B>': gs 'dinmother','go_out'
					end
					exit
				else
					gs 'zz_render','','', func('dinmother_strings', 34)
				end
			else
				gs 'zz_render','','', func('dinmother_strings', 35)
			end
		else
			gs 'zz_render','','', func('dinmother_strings', 36)
		end
		act '<B>Отойти</B>': gs 'dinmother', 'go_out'
	end
end
if $args[0] = 'tampon_talk':
	if $npc['37,relation'] >= 40 and mesec > 0 and pregnancy = 0 and tampon = 0:
		act 'Попросить тампон':
			gs 'zz_render','','', func('dinmother_strings', 37)
			tampon = 3
			minut += 3
			cla
			act '<B>Отойти</B>': gs 'dinmother', 'go_out'
			exit
		end
	end
end
if $args[0] = 'cum_talk':
	cla
	act '<B>Отойти</B>': gs 'dinmother', 'go_out'
	if motherKnowWhore = 0 and motherKnowSpravka = 0 and $npc['37,qwMother'] = 0:
		$npc['37,relation'] = 0
		motherKnowWhore = 1
		if momslut < 2:
			gs 'zz_render','','', func('dinmother_strings', 38)
		else
			gs 'zz_render','','', func('dinmother_strings', 39)
		end
	elseif (motherKnowWhore > 0 or motherKnowSpravka > 0) and $npc['37,qwMother'] = 1:
		if whoremday ! day: gs 'npc_editor','change_rep','+', 37, 20
		if motherKnowWhore = 0: motherKnowWhore = 1
		if momslut < 2:
			gs 'zz_render','','', func('dinmother_strings', 40)
		else
			gs 'zz_render','','', func('dinmother_strings', 41)
		end
	elseif $npc['37,qwMother'] >= 2:
		if whoremday ! day: gs 'npc_editor','change_rep','+', 37, 10
		if motherKnowWhore = 0: motherKnowWhore = 1
		gs 'zz_render','','', func('dinmother_strings', 42)
	end
	whoremday = day
end
if $args[0] = 'worry':
	*clr & cla
	$npc['37,worry_check'] = 0
	gs 'npc_editor','change_rep','-',37
	gs 'npc_editor','get_npc_profile',37
	gs 'zz_render','','', func('dinmother_strings', 43)
	act 'В свою комнату': gt 'bedrPar'
end