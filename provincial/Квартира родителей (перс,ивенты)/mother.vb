act '<B>Отойти</B>': gt $loc, $metka
motherAge = age + 19
if momslut >= 2 and $npc['37,relation'] < 40: $npc['37,relation'] = 40
if (motherKnowWhore > 0 or motherKnowSpravka > 0) and $npc['37,qwMother'] = 0 and $npc['37,qwMother'] = 0: $npc['37,qwMother'] = 1
!if $npc['37,qwMother'] = 1 and $npc['37,relation'] > 40: $npc['37,relation'] = 40
gs 'npc_editor','get_npc_profile',37
if current_clothing < 2:
	gs 'dinmother', 'clothes'
	exit
end
if cumlip + cumface + cumfrot > 0:
	gs 'dinmother', 'cum_talk'
	exit
end
if alko > 0:
	gs 'drunk_reaction', 'mother'
	exit
end
if motherPayDay ! day: gs 'dinmother', 'money_talk'
if mesec > 0: gs 'dinmother', 'tampon_talk'
if $loc = 'gkafe':
	cla
	gs 'zz_render','','','Мать, увидев вас, нахмурила брови: <do>- Чего пришла? Я сколько раз говорила - не ходи ко мне на работу. Нечего тут молодой девчонке делать!</do>'
	act '<B>Отойти</B>': gt $loc, $metka
	exit
end
if $loc = 'grinok' or $mother['location'] = 'shop':
	gs 'dinmother', 'cloth_talk'
	exit
end
if $loc = 'zz_park' or $loc = 'glake':
	gs 'zz_render','','','<do>Давай дома поболтаем - сейчас я немного занята.</do>'
	exit
end
if $loc = 'kuhrPar' or $loc = 'sitrPar' or $loc = 'bedrPar2':
	if hour >= 7 and hour <= 20:
		act 'Болтать':
			*clr & cla
			minut += rand(10,15)
			gs 'npc_editor','change_rep','+', 37
			gs 'stat'
			act '<B>Отойти</B>': gt $curloc
			if $npc['37,relation'] > 80 and rand(0,5) = 2:
				gs 'dinmother','memories'
			else
				gs 'dinmother','talk'
			end
		end
		if $loc = 'kuhrPar':
			act 'Предложить помочь':
				*clr & cla
				minut += 30
				gs 'npc_editor','change_rep','+', 37, 5
				manna -= 10
				gs 'stat'
				$zz_mom_pom[0] = 'помыть посуду и подмести на кухне. В течение получаса вы мыли посуду на кухне и убирались.'
				$zz_mom_pom[1] = 'почистить и нарезать овощи. Вы в течение получаса помогали маме на кухне с готовкой.'
				$zz_mom_pom[2] = 'помыть пол. Вы в течение получаса мыли полы в квартире.'
				$zz_mom_pom[3] = 'постирать бельё. Вы в течение получаса стирали бельё в ванной.'
				$zz_mom_pom[4] = 'погладить белье. Вы в течение получаса гладили бельё в зале.'
				$zz_mom_pom[5] = 'сбегать в магазин за продуктами. В течение получаса вы ходили за продуктами в супермаркет. Мелочь мама разрешила оставить себе.'
				$zz_mom_pom[6] = 'сбегать в аптеку за лекарствами. Там работает мамина сестра Людмила и она даст лекарства бесплатно, мама потом сама сочтётся с ней. Мама написала вам небольшой список и вы пошли в аптеку. Там как всегда за прилавком сидит тётя Люда:  \\- Привет, <<$name[3]>>. Как жизнь? Как настроение?// Вы поприветствовали тётю и подали ей бумажку, в которой мать написала - что нужно. Тётя Люда быстро собрала необходимое. Вернувшись домой, вы передали всё маме.'
				gs 'zz_render','','pavlovo/family/mother/motherhelp' + (MomPom+1) + '.jpg','Вы предложили помочь матери по хозяйству.'
				gs 'zz_render','','','Мама попросила вас ' + $zz_mom_pom[MomPom]
				if MomPom = 6: money += RAND(10,50)
				MomPom += 1
				if MomPom = 7: MomPom = 0
				killvar '$zz_mom_pom'
				act '<B>Отойти</B>':gt $loc, $metka
			end
			if preg = 1 and pregTalkFamily = 0:
				act 'Сказать матери, что вы беременны':
					*clr & cla
					minut += 5
					$npc['37,relation'] = 20
					pregTalkFamily = 1
					gs 'stat'
					gs 'dinmother', 'description'
					gs 'zz_render','','','Вы сказали матери, что беременны. Мать с округлившимися глазами обессиленно села на табуретку. Она грустно сказала: <do>- Ну что же. Я этого и боялась. Теперь не вздумай делать аборт, если ты сделаешь аборт, то в будущем вряд ли сумеешь иметь детей. Придется тебе рожать ребенка.</do>'
					act '<B>Отойти</B>':gt $loc, $metka
				end
			end
			if abort = 1 and pregTalkFamily = 1:
				pregTalkFamily = 2
				$npc['37,relation'] = 0
				gs 'zz_render','','','Мать грустно посмотрела на вас: <do>Какая же ты все-таки дура! Сделала аборт, а если теперь у тебя не будет детей? Что, думаешь, будешь вечно молодая и вся жизнь пройдет в веселье?</do>'
			end
			if momslut = 1:
				act 'Сказать, что вы видели, как мать трахалась с хозяином кафе':
					*clr & cla
					minut += 5
					momslut = 2
					gs 'stat'
					gs 'dinmother', 'description'
					gs 'zz_render','','','Вы сказали матери, что вы видели ее на складе кафе с хозяином кафе.<br>Мать заметно побледнела и села на табурет: <do>- И что ты видела?</do>.<br>Вы ответили ей, что видели, как она сосала у хозяина кафе, а потом он ее трахнул раком. Мать потупила глаза: <do>- Ну да, я сплю со Славой. Но хочу тебя сразу предупредить, шантажировать меня у тебя не получится.</do><br>Мать посмотрела вам в глаза: <do>- Все, чего ты можешь добиться, это разрушить семью.</do>'
					act '<B>Отойти</B>':gt $loc, $metka
				end
			end
		end
	end
	if school['certificate'] = 1 and school['block'] < 3 and school['certificate_gift'] = 0:
		school['certificate_gift'] = 1
		money += 5000
		gs 'zz_clothing', 'lock_school_dress'
		gs 'stat'
		gs 'zz_render','','','Мама обрадовалась: <do>- Теперь ты закончила школу и я хочу подарить тебе пять тысяч рублей. Можешь купить себе подарок.</do>'
		exit
	end
	if $npc['37,qwMother'] = 1 and $npc['37,relation'] < 40 and $loc = 'kuhrPar':
		act 'Попробовать помириться':
			*clr & cla
			gs 'dinmother', 'description'
			i = RAND(1,10)
			act '<B>Отойти<B/>':gt $loc, $metka
			if i <= 2:
				gs 'npc_editor','change_rep','-', 37
				minut += rand(5,15)
				gs 'stat'
				gs 'zz_render','','','Вы попытались поговорить со своей матерью и помириться. Но то ли вы слишком агрессивны, то ли у нее плохое настроение, но итогом "примирения" становится очередной скандал.'
			else
			!elseif i > 2 and i <= 8:
				gs 'npc_editor','change_rep','+', 37, 10
				minut += rand(25,30)
				gs 'stat'
				gs 'zz_render','','','Вы попытались поговорить со своей матерью и помириться. Несмотря на то, что весь получасовой разговор в основном представлял из себя довольно агрессивный монолог вашей матери о морали, болезнях и о том, что вас ждет в будущем, если вы не возьметесь за ум, определенные подвижки в отношениях все же есть.'
			!else
				!gt 'motherQW','motherQW_2'
			end
		end
	end
	if week = 5 and family_trip_month ! month:
		if hour > 9: gs 'zz_render','','','Мама, продолжая заниматься своими делами, говорит вам: <do>- <<$name[1]>>, мы завтра поедем в деревню, в 12 часов. Если хочешь с нами - то подойди ко мне до двенадцати дня.</do>'
		exit
	elseif week = 6 and family_trip_month ! month:
		if hour > 9 and hour < 12:
			gs 'zz_render','','','Мама спрашивает у вас: <do>- <<$name[1]>>, ну что? Поедешь с нами в деревню?</do>'
			act 'Ехать в деревню': gt 'gadukino_event', 'to_gadukino'
			exit
		end
	end
	if hcolmotherremember ! hcol: gs 'dinmother', 'hair' & exit
	if motherpirsday ! day: gs 'dinmother', 'piercing' & exit
	gs 'dinmother', 'virgin_check' & exit
end