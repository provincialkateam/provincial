$meet_haerBoyA = {
	if haerBoyA ! hcol:
		bfA -= 5
		if haerBoyA = 0: $meetcol = 'черный'
		if haerBoyA = 1: $meetcol = 'русый'
		if haerBoyA = 2: $meetcol = 'рыжий'
		if haerBoyA = 3: $meetcol = 'светлый'
		$meetcol = '<<$boyA>> говорит, что вам бы пошел ' + $meetcol + ' цвет волос.'
	elseif haerBoyA = hcol:
		bfA += 1
		gs 'zz_render', '', '', func('meet_strings', 'local_str1')
	end
}
$meet_giftBoyA = {
	if rand(0,2) <= financeA:
		giftDayA = dayA
		giftNum += 1
		if financeA = 0:
			gift = RAND(bfa*5, bfa*10)
			if gift > 500: gift = 500
		elseif financeA = 1:
			gift = RAND(bfa*10, bfa*20)
			if gift > 1500: gift = 1500
		else
			gift = RAND(bfa*20, bfa*30)
			if gift > 2500: gift = 2500
		end
		giftNumA = giftNum
		money += gift
		gs 'zz_render', '', '', func('meet_strings', 'local_str2')
	end
}
if $ARGS[0] = 'start':
	minut += 15
	dayA = dayA + 1
	svidanieA = 0
	giftNum = giftNumA
	gs 'zz_funcs', 'colorize_day'
	$boy = $boyA
	$boy[1] = $boyA[1]
	$boybody = $boybodyA
	$boybod = $boybodA
	$boyface = $boyfaceA
	boyage = boyageA
	!длинна члена
	dick = dickA
	!! половая сила от 0 до 2
	silaVag = silaVagA
	!!Обеспеченность, отвечает за деньги и требования 0 нищий, 1 середняк 2 богат
	finance = financeA
	!!проверка по внешности, от параметра vnesh
	vneshBoy = vneshBoyA
	$boyClo = $boyCloA
	!0 - зад меньше 80, 1 зад от 80 до 100, 2 зад свыше 100
	figurBoy = figurBoyA
	!0 - грудь меньше 3, 1 грудь 3-4, 2 грудь больше 4
	titBoy = titBoyA
	!любимый цвет волос 0 - брюнетка, 1 - шатенка, 2 - рыжая, 3 - блондинка
	haerBoy = haerBoyA
	!характер 0 - мягкий, 1 -норма 2 - агрессор
	harakBoy = harakBoyA
	!извращенность
	izvrat = izvratA
	if love = 3:
		gs 'zz_render', '', 'images/img/hasb/WeddingCar.jpg', func('meet_strings', 'local_str3')
		act 'Сесть в лимузин':
			cla
			gs 'zz_render', '', '', func('meet_strings', 'local_str4')
			act 'Выйти за муж':
				cla
				minut += 60
				love = 0
				bfA = 0
				husband = 100
				husbanday = 0
				before_h_guy = guy
				before_h_girl = girl
				$husName = $boyA
				$husName[1] = $boy[1]
				$husHair = $boyfaceA
				$husBody = $boybodyA
				$husFat = $boybodA
				HusbPic = boypicA
				husbAge = boyageA
				husb_birth_year = year - husbAge
				husDick = dickA
				harakHusb = harakBoyA
				izvratH = izvratA
				silavagH = silavagA
				husbFin = financeA
				husbandMark = 1
				gs 'zz_render', '', '', func('meet_strings', 'local_str5')
				act 'Брачная ночь':gt'husbsex','room'
			end
		end
		exit
	elseif love = 2:
		gs 'zz_render', '', '', func('meet_strings', 'local_str6')
		act 'Нет (Расстаться)':
			minut += 60
			bfA = 0
			pregtalk = 0
			gt'street'
		end
		act 'Да':
			cla
			gs 'zz_render', '', '', func('meet_strings', 'local_str7')
			act 'Ехать за платьем':
				cla
				minut += 60
				love = 3
				gs 'zz_render', '', '', func('meet_strings', 'local_str8')
				act 'Уйти':gt'street'
			end
		end
		exit
	end
	if mop > 1 and func('zz_clothing','is_glamour') = 1 and curly > 0 and love = 1 and harakBoyA = 0:
		gs 'zz_render', '', '', func('meet_strings', 'local_str9')
		act 'Ехать к родителям':gt'love','mother'
		exit
	elseif mop > 1 and func('zz_clothing','is_glamour') = 1 and curly > 0 and love = 1 and harakBoyA = 1 and tanga = 1:
		gs 'zz_render', '', '', func('meet_strings', 'local_str10')
		act 'Ехать к друзьям':gt'love','frends'
		exit
	end
	if skin = 0:bfA -= 2 & $meetskin = 'стоит смотря себе под ноги'
	if skin = 1:bfA -= 1 & $meetskin = 'бросает на вас взгляд'
	if skin = 2:$meetskin = 'глядит на вас'
	if skin = 3:bfA += 1 & $meetskin = 'улыбается завидев вас'
	if skin = 4:bfA += 2 & $meetskin = 'улыбается завидев вас'
	if harakBoyA = 0:
		if mop <= 2 and mop > 0:bfA += 1 & $meetmop = 'ты сегодня такая красивая.'
		if mop = 4:bfA -= 1 & $meetmop = 'отличная сегодня погода.'
	elseif harakBoyA = 1:
		if mop <= 3 and mop > 0:bfA += 1 & $meetmop = 'ты сегодня такая красивая.'
		if mop = 4:bfA -= 1 & $meetmop = 'ярко ты накрасилась, вроде не хэллоуин.'
	elseif harakBoyA = 2:
		if mop = 4:bfA += 1 & $meetmop = 'ты сегодня такая красивая.'
		if mop <= 2 and mop > 0:bfA -= 1 & $meetmop = 'отличная сегодня погода.'
	end
	if mop = 0:bfA -= 1 & $meetmop = 'Эмм, у тебя косметика потекла.'
	if curly > 0:bfA += 2 & $meethair = 'У тебя очень красивая прическа.'
	if curly = 0:bfA += 1 & $meethair = 'У тебя симпатичная прическа.'
	if harakBoyA = 0:$meet = '"Привет любимая! Рад тебя видеть, <<$meetmop>> <<$meethair>>"'
	if harakBoyA = 1:$meet = '"Привет <<$name[1]>>! Рад тебя видеть, <<$meetmop>> <<$meethair>>"'
	if harakBoyA = 2:$meet = '"Привет <<$name[2]>>! Рад тебя видеть, <<$meetmop>> <<$meethair>>"'
	$meetcol = ''
	if dayA > 10 and harakBoy = 2:
		dynamic $meet_haerBoyA
	elseif dayA > 20 and harakBoy = 1:
		dynamic $meet_haerBoyA
	elseif dayA > 30 and harakBoy = 0:
		dynamic $meet_haerBoyA
	end
!!!!!!!!!!!!
!!!ДИАЛОГ!!!
!!!!!!!!!!!!
	'<center><B><font color = maroon><<$boyA>></font></B></center>'
	gs 'zz_render', '', 'images/pic/boy_face/<<boypicA>>.jpg', func('meet_strings', 'local_str11')
	if financeA = 0: $clom = 'одетым в дешевый спортивный костюм.'
	if financeA = 1: $clom = 'одетым в джинсы и свитер.'
	if financeA = 2: $clom = 'одетым в респектабельный и дорогой пиджак.'
	if harakBoyA = 0:'<<$boyA>> выглядит робким и не уверенным в себе молодым человеком <<$clom>>'
	if harakBoyA = 1:'<<$boyA>> выглядит уверенным и спокойным молодым человеком <<$clom>>'
	if harakBoyA = 2:'<<$boyA>> выглядит дерзким и нахальным молодым человеком <<$clom>>'
	if giftDay < (dayA - giftNum):
		if dayA >= 2 and financeA = 2:
			dynamic $meet_giftBoyA
		elseif dayA >= 5 and financeA = 1:
			dynamic $meet_giftBoyA
		elseif dayA >= 10 and financeA = 0:
			dynamic $meet_giftBoyA
		end
	end
	gs 'zz_render', '', '', func('meet_strings', 'local_str12')
	if venera < 4 and cumface = 0:
		!cumlip
		act 'Поцеловать с языком':
			*clr & cla
			cla
			gs'stat'
			if cumlip = 0:
				'<center><B><font color = maroon><<$boyA>></font></B></center>'
				gs 'zz_render', '', 'images/pic/kiss.jpg', func('meet_strings', 'local_str13')
				if harakBoyA = 0: bfA -= 2 & '<<$boyA>> покраснел и отстранился.'
				if harakBoyA = 1: bfA -= 1 & '<<$boyA>> нежно обсосал ваш язык.'
				if harakBoyA = 2: bfA += 2 & '<<$boyA>> агрессивно протолкнул свой язык вам в рот и практически начал сношать вас в рот своим языком.'
				act 'Закончить поцелуй': xgt'meet', 'a'
				exit
			else
				'<center><B><font color = maroon><<$boyA>></font></B></center>'
				gs 'zz_render', '', 'images/pic/cumlip.jpg', func('meet_strings', 'local_str14')
				if izvrat = 1:
					bfA += 5
					DOM += 1
					gs 'zz_render', '', '', func('meet_strings', 'local_str15')
					act 'Закончить поцелуй':xgt'meet','a'
					exit
				else
					boya = 0
					gs 'zz_render', '', '', func('meet_strings', 'local_str16')
					act 'Уйти':gt'street'
					exit
				end
			end
		end
		act 'Поцеловать в губы':
			*clr & cla
			cla
			gs'stat'
			if cumlip = 0:
				'<center><B><font color = maroon><<$boyA>></font></B></center>'
				'<center><img src="images/pic/kiss1.jpg"></center>'
				if harakBoyA = 0: 'Вы подставили для поцелуя губы и <<$boyA>> немного смущаясь поцеловал вас.'
				if harakBoyA = 1: bfA += 2 & 'Вы подставили для поцелуя губы и <<$boyA>> быстро вас чмокнул.'
				if harakBoyA = 2: bfA -= 1 & 'Вы подставили для поцелуя губы и <<$boyA>> смачно поцеловал вас, вдавливая свои твердые губы в ваши <<$liptalk3>>.'
				act 'Закончить поцелуй': xgt'meet','a'
				exit
			else
				'<center><B><font color = maroon><<$boyA>></font></B></center>'
				gs 'zz_render', '', 'images/pic/cumlip.jpg', func('meet_strings', 'local_str17')
				if izvrat = 1:
					bfA += 5
					DOM += 1
					gs 'zz_render', '', '', func('meet_strings', 'local_str18')
					act 'Закончить поцелуй': xgt'meet','a'
					exit
				else
					bfa = 0
					gs 'zz_render', '', '', func('meet_strings', 'local_str19')
					act 'Уйти': gt 'street'
					exit
				end
			end
		end
		act 'Поцеловать в щеку':
			*clr & cla
			cla
			gs'stat'
			DOM += 1
			'<center><B><font color = maroon><<$boyA>></font></B></center>'
			'<center><img src="images/pic/kiss2.jpg"></center>'
			if harakBoyA = 0:bfA += 1 & 'Вы подставили щечку и <<$boyA>> робко вас чмокнул.'
			if harakBoyA = 1:'Вы подставили щечку и <<$boyA>> вас чмокнул.'
			if harakBoyA = 2:bfA -= 2 & 'Вы подставили щечку и <<$boyA>> поцеловал вас с обескураженным видом.'
			if giftDayA = dayA:
				bfA -= 3
				if harakBoyA = 0:'<<$boyA>> выглядит расстроенным.'
				if harakBoyA = 1:'<<$boyA>> выглядит оскорбленным.'
				if harakBoyA = 2:'<<$boyA>> выглядит рассерженным.'
			end
			act 'Закончить поцелуй':xgt'meet','a'
			exit
		end
		act 'Не целоваться':
			*clr & cla
			cla
			gs'stat'
			DOM += 2
			if harakBoyA = 0:bfA -= 1 & 'Вы кивнули и поздоровались, <<$boyA>> стушевался и немного покраснел.'
			if harakBoyA = 1:bfA -= 2 & 'Вы кивнули и поздоровались, <<$boyA>> немного нахмурился.'
			if harakBoyA = 2:bfA -= 3 & 'Вы кивнули и поздоровались, <<$boyA>> хмыкнул и ухмыльнулся.'
			if giftDayA = dayA:
				bfA -= 3
				if harakBoyA = 0:'<<$boyA>> выглядит расстроенным.'
				if harakBoyA = 1:'<<$boyA>> выглядит оскорбленным.'
				if harakBoyA = 2:'<<$boyA>> выглядит рассерженным.'
			end
			act 'Далее':xgt'meet','a'
			exit
		end
	elseif venera >= 4:
		*clr & cla
		gs'stat'
		bfa = 0
		'<center><B><font color = maroon><<$boyA>></font></B></center>'
		gs 'zz_render', '', 'images/pic/venera.jpg', func('meet_strings', 'local_str20')
		act 'Уйти':gt'street'
		exit
	elseif cumface > 0:
		*clr & cla
		cla
		gs'stat'
		'<center><B><font color = maroon><<$boyA>></font></B></center>'
		gs 'zz_render', '', 'images/pic/cumface.jpg', func('meet_strings', 'local_str21')
		if izvrat = 1:
			bfA += 5
			DOM += 1
			gs 'zz_render', '', '', func('meet_strings', 'local_str22')
			act 'Да это сперма, еще вопросы есть?':
				cla
				gs'stat'
				gs 'zz_render', '', '', func('meet_strings', 'local_str23')
				xgt 'meet', 'a'
			end
			exit
		else
			boya = 0
			gs 'zz_render', '', '', func('meet_strings', 'local_str24')
			act 'Уйти':gt'street'
			exit
		end
	end
end
if $ARGS[0] = 'a':
	if cumfrot > 0:
		gs 'zz_render', '', '', func('meet_strings', 'local_str25')
		if izvrat = 1:
			bfA += 5
			DOM += 1
			gs 'zz_render', '', '', func('meet_strings', 'local_str26')
		else
			bfa = 0
			gs 'zz_render', '', '', func('meet_strings', 'local_str27')
			act 'Уйти': gt'street'
			exit
		end
	end
	if financeA = 0:
		if func('zz_clothing','is_glamour') = 1:
			bfA -= (harakBoyA + 1)
			gs 'zz_render', '', '', func('meet_strings', 'local_str28')
		elseif func('zz_clothing','is_skirt') = 1 or val($wardrobe[current_clothing+"_"+'group']) = 3:
			bfA += (harakBoyA + 1)
			gs 'zz_render', '', '', func('meet_strings', 'local_str29')
		end
		mesorand = RAND(0,1)
		if mesorand = 0:
			gs 'zz_render', '', '', func('meet_strings', 'local_str30')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'podezdM','start'
			exit
		elseif mesorand = 1:
			gs 'zz_render', '', '', func('meet_strings', 'local_str31')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'parkM','start'
			exit
		end
	elseif financeA = 1:
		if func('zz_clothing','is_skirt') = 1:
			bfA -= (harakBoyA + 1)
			gs 'zz_render', '', '', func('meet_strings', 'local_str32')
		end
		if val($wardrobe[current_clothing+"_"+'group']) = 3:
			bfA -= (harakBoyA + 1)
			gs 'zz_render', '', '', func('meet_strings', 'local_str33')
		end
		mesorand = RAND(0,2)
		if mesorand = 0:
			gs 'zz_render', '', '', func('meet_strings', 'local_str34')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'kinoM','start'
			exit
		elseif mesorand = 1:
			gs 'zz_render', '', '', func('meet_strings', 'local_str35')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'parkM','start'
			exit
		elseif mesorand = 2:
			gs 'zz_render', '', '', func('meet_strings', 'local_str36')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'kafeM','start'
			exit
		end
	elseif financeA = 2:
		if func('zz_clothing','is_glamour') = 1:
			bfA += (harakBoyA + 1)
			gs 'zz_render', '', '', func('meet_strings', 'local_str37')
		else
			bfA -= (harakBoyA + 1)
			gs 'zz_render', '', '', func('meet_strings', 'local_str38')
		end
		if RAND(0,1) = 0:
			gs 'zz_render', '', '', func('meet_strings', 'local_str39')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'kafeM','start'
			exit
		else
			gs 'zz_render', '', '', func('meet_strings', 'local_str40')
			act 'Извини, но мне срочно нужно бежать':
				cla
				bfA -= (harakBoyA + 1)
				gt'street'
			end
			act 'Пойдем':gt'restoranM','start'
			exit
		end
	end
end