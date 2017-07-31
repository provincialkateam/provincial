if $args[0] = 'strings':
	if $args[1] = 'motherQW_2_1': $result = 'Вы попытались поговорить со своей матерью и помириться. Весь получасовой разговор в основном представлял из себя довольно агрессивный монолог вашей матери о морали, болезнях и будущем. В какой-то момент вся эта тягомотина вам сильно надоела.'
	if $args[1] = 'motherQW_2_2': $result = '<dh> - Все, что ты говоришь, мам, конечно, верно и правильно, но разве ты самая не такая?</dh><br>Она оторопела от вашей фразы, но быстро пришла в себя.<br><do>- Что ты имеешь ввиду? Я не та...</do><br><dh>- Такая, такая. Такая же шлюха! Даже покруче меня будешь!</dh><br><do>- <<$name[1]>>! Да что ты себе поз...</do>'
	if $args[1] = 'motherQW_2_3': $result = '<dh>- Что я себе позволяю?</dh> - вы быстро перехватили инициативу, не дав ей договорить. <dh>- Ну мы же взрослые люди, и ведем вполне взрослый разговор о более чем взрослой теме. И уж прости, но я буду говорить все это прямым текстом.</dh><br><do>- <<$name[1]>>! Не переби...</do><br><dh>- Нет уж, мам, теперь ты не перебивай. Я полчаса слушала нравоучения! И от кого?!</dh><br><do>- <<$name[1]>>!..</do><br><dh>- Что <<$name[1]>>, что <<$name[1]>>?! Мама, тебе сейчас <<motherAge>>, Ане <<sisterAge>>. Сложению и вычитанию учат в первом классе. Да тебе было даже меньше, чем мне, когда ты залетела!</dh><br>Нервирующая тишина. Вы, красная как рак, пытались отдышаться, а ваша мать сидела с лицом, одновременно выражающим все человеческие эмоции. Скорее всего она пыталась понять, какого чёрта тут вообще происходит и почему она слушает нравоучения от своей дочери. Вам даже показалось, что когда-то давно она точно так же сидела и ругалась с вашей бабушкой.<br><do>- Но ведь это был твой отец,</do> - тихо сказала она.<br><dh>- И что с того?</dh><br><do>- А то, что я это делала по любви и не подставляла манду первому встречному из подворотни!</do><br><dh>А кто тебе сказал, что я это делаю не по любви и со всеми подряд?! Да и к тому же, ты залетела с первого раза?</dh><br><do>- Нет... - малость потерялась и смутилась мама - Там всё по любви было!</dh>'
	if $args[1] = 'motherQW_2_4': $result = '<dh>- А такое, мама: я в жизни не поверю, что трахаться тебе было неприятно и ты все это делала исключительно из любви к отцу.</dh><br><do>- <<$name[1]>>! Не ругайся!</do><br><dh>- Ладно, ладно, занималась сексом. С остальным ты, видимо, согласна.</dh><br><do>- Нуу...</do> - она на секунду задумалась, погрузившись в воспоминания своей молодости, <do>- да, было приятно, конечно, особенно когда дв...</do><br><dh>- Комментарии излишни,</dh> - с ехидством заметили вы.<br>Неловкая тишина. Теперь уже мать, красная как рак, пытается придти в себя. Минут через пять у нее это всё-таки получилось, и вы заметили, что она что-то обдумывает, посматривая то на вас, то на стену.<br><do>- Ну и дочка же у меня.</do><br><dh>- Вся в мать,</dh> - улыбаясь сказали вы.<br><do>- Вся в мать...</do> - с нервным смешком повторила она и опять замолчала на несколько минут.<br><dh>- Ну что ж, мам, по-моему, мы поняли друг друга, да и ситуацию криком, ором и скандалом все равно не исправить.</dh><br></do>- Не исправить, да... </do>- медленно сказала она, продолжая о чем-то думать. <do>- Не скажу, что одобряю твоё поведение, но...</do> - видно, что слова давались ей нелегко, <do> - но понимаю тебя.</do><br>Вы встали, обняли свою мать и направились к двери.'
	if $args[1] = 'motherQW_2_5': $result = '<do>- Постой, <<$name>>.</do><br><dh>- Ммм? </dh> - вы повернулись в дверях. Мать жестом сказала вам сесть обратно на кухонный стул.<br><do>- Анька хоть отчасти в Мишку пошла, а вот ты точно вся в меня, так что приключений на свою задницу найдешь и...</do><br><dh>- Маааам, мы же только что это обсудили!</dh><br><do>- Вот теперь ты меня не перебивай, я вообще о другом сейчас. Не хочу, знаешь ли, чтобы ты какую-нибудь болячку или ребеночка от непонятно кого себе нагуляла.</do>'
	if $args[1] = 'motherQW_2_6': $result = '<dh>- Не волнуйся, у меня все есть. Съездила в город и купила. Закончатся - еще раз съезжу.</dh>'
	if $args[1] = 'motherQW_2_7': $result = '<dh>- Нууу... Съезжу в город, там аптека есть.</dh>'
	if $args[1] = 'motherQW_2_8': $result = '<do>- В город значит. Знаешь, лучше покупай все в нашей аптеке. И тебе проще, и мне спокойней за тебя будет.</do><br><dh>- И как, скажите мне, пожалуйста, мадам, я это сделаю? Скажу тете Люде, что мне гандоны для шариков нужны?</dh><br><do>- Тьфу на тебя! Если Людка докопается, скажешь, мол, мне для огорода, она поймет. Только не покупай сразу много.</do><br><dh>- Хм, для огорода, понятно. А что это знач...</dh><br><do>- Не надо, доча!</do> - быстро перебила она.<br><dh>- Ладно, ладно.</dh><br>Вы встали, подбежали и чмокнули свою мать.<br><dh>- Знаешь, мам, а ты все-таки у меня самая лучшая.</dh><br><do>- Цени это, дурочка,</do> - с улыбкой ответила она.'
end
if $ARGS[0] = 'motherQW_2':
	minut += 60
	$npc['37,qwMother'] = 2
	gs 'npc_editor','change_rep','+', 37, 10
	gs 'stat'
	gs 'zz_render','Мама','images/qwest/alter/mother.jpg',func('motherQW','strings','motherQW_2_1')
	act 'Вклиниться':
		*clr & cla
		gs 'zz_render','Мама','images/qwest/alter/mother.jpg',func('motherQW','strings','motherQW_2_2')
		act 'Продолжить давить':
			*clr & cla
			gs 'zz_render','Мама','images/qwest/alter/mother.jpg',func('motherQW','strings','motherQW_2_3')
			act 'Далее':
				*clr & cla
				gs 'zz_render','Мама','images/qwest/alter/mother.jpg',func('motherQW','strings','motherQW_2_4')
				act 'Уйти':
					*clr & cla
					gs 'zz_render','Мама','images/qwest/alter/mother.jpg',func('motherQW','strings','motherQW_2_5') + func('motherQW','strings','motherQW_2_'+iif(prezik = 0 and tabletki = 0,'6','7')) + func('motherQW','strings','motherQW_2_8')
					act 'Уйти': gt'korrPar'
				end
			end
		end
	end
end
if $ARGS[0] = 'motherQW_3':
	minut += RAND(20,30)
	$npc['37,qwMother'] = 3
	gs 'stat'
	gs 'zz_render', '', '', func('motherQW_strings', 'local_str1')
	act 'Далее':
		*clr & cla
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str2')
		if gorslut = 0:'- Племяшка, держи - тётя протянула вам пачку презервативов:'
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str3')
		if gorslut > 0:'- Тогда и не надо из меня дуру делать. Все в Павлово в курсе, что ты <<$gnikname>>.'
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str4')
		act 'Отойти от прилавка':gt'gaptek','start'
	end
end
if $ARGS[0] = 'motherQW_4':
	minut += 60
	$npc['37,qwMother'] = 4
	gs 'stat'
	gs 'zz_render', 'Мама', 'images/qwest/alter/mother.jpg', func('motherQW_strings', 'local_str5')
	act 'Уйти':gt'kuhrPar'
end
if $ARGS[0] = 'olu':
	if tetyafirst = 0:
		oluuosegunday = day
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str6')
		act 'Согласиться':
			cla
			tetyafirst = 2
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str7')
			act 'Идти к тете домой':gt'motherQW','oluHome'
		end
		act 'Отказаться':
			cla
			tetyafirst = 1
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str8')
			act 'Уйти':gt'gorodok'
		end
	elseif tetyafirst = 1:
		oluuosegunday = day
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str9')
		act 'Согласиться':
			cla
			tetyafirst = 2
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str10')
			act 'Идти к тете домой':gt'motherQW','oluHome'
		end
		act 'Отказаться':
			cla
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str11')
			act 'Отойти от прилавка':gt'gaptek','start'
		end
	elseif tetyafirst = 2:
		oluuosegunday = day
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str12')
		act 'Согласиться':
			cla
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str13')
			act 'Идти к тете домой': gt 'motherQW', 'oluHome'
		end
		act 'Отказаться':
			cla
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str14')
			act 'Отойти от прилавка': gt 'gaptek', 'start'
		end
	end
end
if $ARGS[0] = 'oluHome':
	*clr & cla
	gs 'zz_render', 'Квартира тети', 'images/qwest/alter/motherQW/olu.jpg', func('motherQW_strings', 'local_str15')
	if olufirst = 0:
		olufirst = 1
		minut += RAND(5,10)
		gs 'stat'
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str16')
		act 'Очнуться':
			*clr & cla
			minut += 30
			guy += 1
			anal += 1
			dick = 23
			if anal < dick: anal += 1
			cumanus = 1
			dom -= 5
			agape = 3
			agapetime = totminut + (agape + 1) * 1440
			if mop ! 1: mop = 0
			gs 'stat'
			gs 'zz_render', 'Квартира тети', 'images/qwest/alter/motherQW/olu1.jpg', func('motherQW_strings', 'local_str17')
			act 'Вернуться к тете': gt'motherQW','oluEnd'
		end
	else
		olusexrand = RAND(1,100)
		if olusexrand <= 90:
			minut += 5
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str18')
			if olufirst = 2:
				olufirst = 3
				gs 'zz_render', '', '', func('motherQW_strings', 'local_str19')
			end
			act 'Далее':
				*clr & cla
				dick = 23
				minut += 30
				if anal < dick: anal += 1
				anus += 10
				dom -= 1
				cumanus = 1
				oluDRand = RAND(1,10)
				if lubri > 0:
					agape = 1
					horny += 20
				else
					agape = 2
					horny += 10
				end
				agapetime = totminut + (agape + 1) * 1440
				gs 'stat'
				gs 'zz_render', 'Квартира тети', 'images/qwest/alter/motherQW/olu'+RAND(1,3)+'.jpg', func('motherQW_strings', 'local_str20')
				if lubri > 0: lubri -= 1 & 'Негр взял у вас смазку, выдавил себе на руку и пальцами смазал ваш анус, затем и свой член.'
				if lubri = 0: 'Негр аккуратно стал массировать ваш в анус, затем ввел сначала один, потом два, три пальца и стал растягивать попу.'
				gs 'zz_render', '', '', func('motherQW_strings', 'local_str21')
				if oluD = 0 and oluDRand = 10:
					oluD = 1
					gs 'zz_render', '', '', func('motherQW_strings', 'local_str22')
				end
				gs 'zz_render', '', '', func('motherQW_strings', 'local_str23')
				act 'Вернуться к тете': gt'motherQW','oluEnd'
			end
		else
			*clr & cla
			gs 'zz_render', 'Квартира тети', 'images/pic/korr2.jpg', func('motherQW_strings', 'local_str24')
			act 'Заглянуть':
				*clr & cla
				gs 'zz_render', 'Квартира тети', 'images/qwest/alter/motherQW/oluM'+RAND(1,3)+'.jpg'
				minut += 25
				horny += 20
				if oluM = 0:
					oluM = 1
					gs 'zz_render', '', '', func('motherQW_strings', 'local_str25')
					act 'Вернуться к тете': gt'motherQW','oluEnd'
				else
					gs 'zz_render', '', '', func('motherQW_strings', 'local_str26')
					act 'Уйти': gt'gorodok'
				end
			end
		end
	end
end
if $ARGS[0] = 'oluEnd':
	*clr & cla
	gs 'stat'
	gs 'zz_render', 'Аптека', 'images/pic/aptek.jpg'
	if olufirst = 1:
		minut += 15
		gs 'zz_render', '', '', func('motherQW_strings', 'local_str27')
		act 'Час спустя':
			*clr & cla
			minut += 75
			galubri = 1
			olufirst = 2
			gs 'stat'
			gs 'zz_render', 'Аптека', 'images/qwest/alter/motherQW/gaptek.jpg', func('motherQW_strings', 'local_str28')
			if age < 18 and ssdostup = 0:'- Где я тебе ее возьму? В магазин для взрослых меня еще не пускают. К тому же я вообще офигела от его размера и отключилась, а очнулась, когда уже было поздно.'
			if age >= 18 or ssdostup = 1:'- Да я даже понять ничего не успела. Как увидела размерчик, так, можно сказать, отключилась. А когда очнулась было уже поздно. К тому же далековато в город ездить.'
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str29')
			act 'Уйти домой':gt'korrPar'
		end
	else
		if oluM ! 1:
			minut += RAND(5,10)
			money += RAND(500,700)
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str30')
			act 'Уйти':gt'gorodok'
		else
			minut += 15
			oluM = 2
			gs 'zz_render', '', '', func('motherQW_strings', 'local_str31')
			act 'Уйти домой':gt'motherQW','motherQW_4'
		end
	end
end