!проверка на присутствие мужа дома
if $args[0] = 'husband_check':
	husband_inhouse = 0
	if husband > 0 and husbandrink ! 10 and (week > 5 and hour >= 7 and hour <= 22 or week < 6 and (hour = 7 or hour >= 17 and hour <= 22)):husband_inhouse = 1
end
!Квартплата за квартиру
if $args[0] = 'rent':
	if housr = 1:
		if haday = 0:
			rent_money = iif(BuyHous ! 1, 3000,iif(ArendHouseSL = 0,3000,6000)) + house_debt
			haday = 1
			if money >= rent_money:
				money -= rent_money
				'<b><font color = red>Вы оплатили <<rent_money>> рублей за коммунальные платежи.</font></b>'
			elseif money < rent_money and karta >= rent_money:
				karta -= rent_money
				'<b><font color = red>С банковской карты сняли <<rent_money>> рублей за коммунальные платежи.</font></b>'
			elseif money < rent_money and karta < rent_money and ArendHouseSL > 0:
				ArendHouseSL -= rent_money/333
				if ArendHouseSL < 0:ArendHouseSL= 0
				'<b><font color = red>Срок вашей аренды уменьшен, в счет погашения оплаты за коммунальные платежи.</font></b>'
			else
				!долг за квартиру
				house_debt += rent_money
				'<b><font color = red>У вас нет денег для оплаты коммунальных платежей. Задолженность <<house_debt>> рублей.</font></b>'
			end
			rent_money = 0
		end
		if kabel > 0 and kabelday = 0:
			kabelday = 1
			if money >= 500:
				money -= 500
				'<b><font color = red>Вы оплатили 500 рублей за кабельное телевидение.</font></b>'
			else
				kabel = 0
				house_debt += 500
				'<b><font color = red>Кабельное телевидение отключено. Абоненская плата за прошедший месяц включена в общий долг за квартиру</font></b>'
			end
		end
	end
end
!Зал!
if $ARGS[0] = 'iron_clothes':
	*clr & cla
	minut += drybelo*5
	clrbelo += drybelo
	drybelo = 0
	manna -= 10
	gs 'zz_render','','images/city/south/apartment/event/iron_clothes'+iif(current_clothing > 0,'',iif(tanga = 0,'_nude','_tanga'))+'.jpg','Вы погладили белье.'
	act 'Выйти': gt $loc, $metka
end
!Спальня!
if $ARGS[0] = 'husband_drin_start':
	*clr & cla
	gs 'zz_render', '', '<<$husName>>','images/pic/boy_face/<<HusbPic>>.jpg','<<$husName>> завалился домой сильно пьяный и рухнув на кровать, уснул прямо в одежде.'
	if analplug = 1:
		gs 'zz_render', '', '','- Вот свинья!, - выругались вы, и тут вам в голову полезли нехорошие мысли:<br>"Может его проучить, что бы не напивался до бесчувствия?"'
		act 'Проучить(вставить анальную пробку)':
			*clr & cla
			husbandrinkday = day
			husbandrink = 11
			husbanstrapon = 1
			minut += 10
			gs 'zz_render', '', 'images/city/south/apartment/husband/h0.jpg',iif(analplugin = 1,'Вы вынимаете пробку из своей попки и аккуратно вводите её, мужу в анус.','Вы идете в ванну берете пробку и аккуратно вводите её, ему в анус.')+'<<$husName>> шевельнулся, но не проснулся, видать крепко набрался'
			if dildo > 0:
				act 'Вставить дилдо':
					*clr & cla
					minut += 20
					husbanstrapon = 2
					swallow += 1
					gs 'zz_funcs', 'cum', 'lip'
					horny += 30
					gs 'zz_render', '', 'images/city/south/apartment/husband/h1.jpg','Вы вынимаете пробку и вставляете на её место дилдо, <<$husName>> даже не шелохнулся. Вы начали потихоньку двигать дилдо стараясь не разбудить мужа. Вскоре перед вашим лицом начал подниматься его член, а <<$husName>> начал тихонько постанывать, но так и не проснулся. Вы уже вовсю орудовали дилдо в его анусе, а его фалос начал пульсировать готовый кончить. Вы обхватили его член губами и стоило вам коснуться языком головки как в рот вам ударила струя спермы, вы проглотили её и старательно очистив его член от остатков спермы, натянули на него штаны.'
					act 'Закончить':gt'bedr'
				end
			end
			if strapon > 0:
				act 'Одеть страпон':
					*clr & cla
					minut += 20
					husbanstrapon = 3
					swallow += 1
					gs 'zz_funcs', 'cum', 'lip'
					horny += 30
					gs 'zz_render', '', 'images/city/south/apartment/husband/h2.jpg','Вы одеваете страпон и вынув пробку медленно вводите его в анус мужа, <<$husName>> зашевелился, но не проснулся. Вы начали потихоньку двигать бедрами стараясь не разбудить мужа. Вскоре перед вашим лицом начал подниматься его член, а <<$husName>> начал тихонько постанывать, но так и не проснулся. Поняв что в таком состоянии он не проснется вы развили приличную скорость и не стесняясь вгоняли страпон на всю длину. Его член встал и вы схватив его рукой, начали дрочить почувствовав, что он вот вот кончит вы изогнулись и умудрились обхватить его член губами. Стоило вам коснуться языком головки как в рот вам ударила струя спермы, вы проглотили её и старательно очистив его член от остатков спермы, натянули на него штаны.'
					act 'Закончить':gt'bedr'
				end
			end
			act 'Закончить':gt'bedr'
		end
	else
		act 'Вот козёл!(Уйти)':gt'bedr'
	end
end
if $ARGS[0] = 'husband_drin_end':
	*clr & cla
	gs 'zz_render', '', '<<$husName>>','images/pic/boy_face/<<HusbPic>>.jpg','К вам подошел муж и спросил:<br>- Дорогая, у меня что-то зад болит, ты не в курсе, может я вчера упал неудачно?'
	act 'Соврать':
		cla
		husbanstrapon = 0
		'- Нет дорогой, я не знаю, - сказали вы сделав невинное лицо. Муж пожал плечами и ушел'
		act 'Закончить': gt 'bedr'
	end
	act 'Признаться':
		cla
		gs 'zz_render','','',iif(husbanstrapon = 1,'- Дорогой, ты вчера так напился, что я решила проучить тебя и вставила тебе пробку в зад, - сказали вы. - Но я так больше никогда не буду, прости меня пожалуйста...',iif(husbanstrapon = 2,'- Дорогой, я хотела сделать тебе приятное и начала делать минет, но ты никак не кончал. Тогда я вставила пальчик тебе в попку, но ты снова не кончил, и я воспользовалась дилдо. Вот тут тебя прорвало, я даже сделала тебе минет еще раз... Прости меня, но тебе было так хорошо что я не могла остановиться. Я все лишь хотела сделать тебе приятно, дорогой, - сказали вы, сильно приврав в своей истории.','Дорогой, я хотела сделать тебе приятное и начала делать минет. Но так как ты никак не кончал я вставила пальчик тебе в попку. Но и это не помогло. Когда я вставила второй, ты начал двигать попкой навстречу моим пальчикам и сильно стонать. Видя как тебе хорошо, я решила, что тебе понравится следующая забава и одела страпон. Тебе и правда было очень хорошо, ты кончал раз за разом, а я все продолжала. Когда я устала, то слизала всю, до последней капли, сперму с твоего тела и легла спать. Я только хотела сделать тебе приятное и сделала, хоть ты этого и не помнишь... прости меня пожалуйста, - сказали вы, сильно приврав в своей истории.'))
		if harakHusb = 2:
			husbizvradd = 0
			husbharmin = 0
			husbandMark = 0
			husband = 0
			divorced += 1
			minut += 120
			gs 'zz_render', '', '','Следующее, что вы почувствовали - это мощный удар в лицо. Когда вы пришли в себя, то поняли, что ни мужа, ни его вещей, нет. Он подал на развод...'
		elseif harakHusb = 1:
			if husbanstrapon = 1:
				gs 'zz_render', '', '','- Смотри, не шути так больше, - сказал он и вышел.'
			elseif husbanstrapon = 2:
				husbizvradd += 1
				gs 'zz_render', '', '','- Ну то, что яйца у меня пустые - это я уже понял. Но смотри, не шути так больше! Я все таки мужик и мне не положено никого в задницу к себе впускать, - сказал он и вышел.'
			elseif husbanstrapon = 3:
				if intel > 70 or izvratH = 1:
					husbharmin += 1
					gs 'zz_render', '', '','- Ты что совсем охренела?, - заорал он. - Я тебе что сучка, чтобы меня трахать?<br>Но тут вы пустили слезу и начали причитать, что лишь хотели доставить ему удовольствие. Он посмотрел на вас и выдохнув сказал:<br> "Да, верю я верю... хотела мне приятное сделать. Но больше так не делай!'
				else
					husbizvradd = 0
					husbharmin = 0
					husbandMark = 0
					husband = 0
					divorced += 1
					minut += 120
					gs 'zz_render', '', '','Следующее что вы почувствовали - это мощный удар в лицо. Когда вы пришли в себя, то поняли, что ни мужа, ни его вещей, нет. Он подал на развод...'
				end
			end
		elseif harakHusb = 0:
			husbizvradd += husbanstrapon
			gs 'zz_render', '', '',iif(husbanstrapon = 1,'- Прости меня, я больше не буду так напиваться, - сказал он и вышел.',iif(husbanstrapon = 2,'- Ты такая заботливая! Вместо того чтобы ругать меня, ты еще и приятное мне делаешь... спасибо тебе, дорогая, - сказал он и вышел.','- Мне и правда это понравилось? - спросил он, и вы тут утвердительно закивали.<br>- Ну тогда спасибо дорогая. Но в следующий раз все-таки спрашивай мое согласие,- сказал он и вышел'))
		end
		act 'Закончить':husbanstrapon = 0 & gt'bedr'
	end
end
!Кухня!
if $ARGS[0] = 'selfplay_start':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/selfplay/start.jpg',''
	if dildo >= 1 or middildo = 1 or largedildo = 1 or bigdildo = 1 or extradildo = 1 or superdildo = 1 or maddildo = 1:
		if dildo = 1:
			gs 'zz_render', '', '','У вас есть маленький дилдо длинной 10 см.'
			act 'Взять 10ти сантиметровый дилдо':dildohand = 10 & gt 'apartment_south_event','selfplay_dildo'
		end
		if middildo = 1:
			gs 'zz_render', '', '','У вас есть дилдо длинной 15 см.'
			act 'Взять 15ти сантиметровый дилдо':dildohand = 15 & gt 'apartment_south_event','selfplay_dildo'
		end
		if largedildo = 1:
			gs 'zz_render', '', '','У вас есть дилдо длинной 20 см.'
			act 'Взять 20ти сантиметровый дилдо':dildohand = 20 & gt 'apartment_south_event','selfplay_dildo'
		end
		if bigdildo = 1:
			gs 'zz_render', '', '','У вас есть дилдо длинной 25 см.'
			act 'Взять 25ти сантиметровый дилдо':dildohand = 25 & gt 'apartment_south_event','selfplay_dildo'
		end
		if extradildo = 1:
			gs 'zz_render', '', '','У вас есть дилдо длинной 30 см.'
			act 'Взять 30ти сантиметровый дилдо':dildohand = 30 & gt 'apartment_south_event','selfplay_dildo'
		end
		if superdildo = 1:
			gs 'zz_render', '', '','У вас есть дилдо длинной 35 см.'
			act 'Взять 35ти сантиметровый дилдо':dildohand = 35 & gt 'apartment_south_event','selfplay_dildo'
		end
		if maddildo = 1:
			gs 'zz_render', '', '','У вас есть дилдо длинной 40 см.'
			act 'Взять 40ти сантиметровый дилдо':dildohand = 40 & gt 'apartment_south_event','selfplay_dildo'
		end
	else
		gt 'selfplay'
	end
end
if $ARGS[0] = 'selfplay_husband':
	*clr & cla
	dick = husDick
	harakBoy = harakHusb
	$boy = $husName
	gs 'zz_render', '<<$husName>>','images/pic/boy_face/<<HusbPic>>.jpg',iif(hour = 7 or hour = 17,'<<$husName>> смотрит на вас, явно немного ошарашено','Только вы входите во вкус как на кухню входит <<$husName>>')+'.'
	if harakHusb = 0:
		gs 'zz_render', '', '','- Что ты делаешь дорогая? - спрашивает он.<br>- Извини дорогой, но мне очень надо, а ты был занят, - отвечаете вы, не прекращая мастурбировать.<br>- И часто ты так делаешь - спрашивает <<$husName>>.<br> - Нуууу... бывает иногда, - замялись вы.'+iif(horny ! 0,' - Хочешь мне помочь?','')
		if izvratH = 0 or horny = 0:
			husband -= 1
			husband_know_mastr = 1
			gs 'zz_render', '', '','- Я лучше подожду за дверью, пока ты закончишь, - сказал он и вышел.'
			if horny ! 0:act 'Продолжить': gt 'selfplay'
			act 'Отказаться от этой затеи':dildohand = 0 & gt $loc, $metka
		else
			gs 'zz_render', '', '','- Ну я не знаю, - замялся он.<br>- Значит хочешь, - улыбнулись коварно вы.'
			act 'В спальню':
				husband += 1
				suprdolg += 1
				dildohand = 0
				gt'husbsex','room'
			end
		end
	elseif harakHusb = 1:
		gs 'zz_render', '', '','- Вот это номер а меня значит тебе уже не хватает?, - спрашивает он вас.<br>- Извини дорогой, но мне очень надо, а ты был занят, - ответили вы, не прекращая мастурбировать.<br>- Ну сейчас то я не занят, - улыбнулся возбуждённо <<$husName>>.'
		act 'В спальню':
			husband += 1
			suprdolg += 1
			dildohand = 0
			gt'husbsex','room'
		end
	else
		gs 'zz_render', '', '','- Что, дырка зачесалась?" спрашивает он.<br>- Извини дорогой, но мне очень надо, а ты был занят, - отвечаете вы, не прекращая мастурбировать.<br>- Вали тогда сюда, - сказал он доставая член. - Трахну тебя по-настояшему!'
		act 'В спальню':
			husband += 1
			dildohand = 0
			suprdolg += 1
			gt'husbsex','room'
		end
	end
end
if $ARGS[0] = 'selfplay_dildo':
	*clr & cla
	dick = dildohand
	minut += 5
	gs'stat'
	gs 'apartment_south_event','husband_check'
	if husband_inhouse = 1:
		gs 'zz_render', '', 'images/city/south/apartment/husband/m'+iif($loc = 'kuhr',1,11)+'.jpg','Вы '+iif($loc = 'kuhr','залазите на стол','садитесь на диван')+' и вводите дилдо себе в киску...'
		gs 'zz_dynamic_sex', 'vaginal', 'dildo'
		iif($loc = 'kuhr' and (hour = 7 or hour = 17) or $loc = 'sitr' and (hour > 17 or hour < 23),'<<$husName>> смотрит на вас, явно немного ошарашено','Только вы входите во вкус как на кухню входит <<$husName>>')+'.'
		if harakHusb = 0:
			gs 'zz_render', '', '','- Что ты делаешь дорогая? - спрашивает он.<br>- Извини дорогой, но мне очень надо, а ты был занят, - отвечаете вы, не прекращая мастурбировать.<br>- И часто ты так делаешь - спрашивает <<$husName>>.<br> - Нуууу... бывает иногда, - замялись вы. - '+iif($loc = 'kuhr','А еще и в попку могу, х','Х')+'очешь посмотреть?'
			if izvratH = 0:
				husband -= 1
				husband_know_mastr = 1
				gs 'zz_render', '', '','- Я лучше подожду за дверью, пока ты закончишь, - сказал он и вышел.'
				act 'Продолжить': gt 'selfplay'
				act 'Отказаться от этой затеи':dildohand = 0 & gt $loc, $metka
			else
				gs 'zz_render', '', '','- Ну я не знаю, - замялся он.<br>- Значит хочешь, - улыбнулись коварно вы.'
				act 'Показать':
					*clr & cla
					minut += 5
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/city/south/apartment/husband/m'+iif($loc = 'kuhr',2,12)+'.jpg','Вы '+iif($loc = 'kuhr','вынимаете дилдо из киски и подмигнув мужу, подносите к своей <<$anustipe3>> попке','вновь погружаете дилдо, в свою <<vaginatipe2>> вагину, и сосредотачиваесь на своих ощущениях')+'.'
					if $loc = 'kuhr':
						gs 'zz_dynamic_sex','anal_start','dildo'
					else
						protect = 1
						gs 'zz_dynamic_sex','sex_start', 1
					end
					gs 'zz_dynamic_sex', iif($loc = 'kuhr','anal','vaginal'), 'dildo'
					gs 'zz_render', '', '','<<$husName>> внимательно наблюдает как дилдо исчезает в '+iif($loc = 'kuhr','вашем анусе','вашей вагине')+', а затем снова появляется. Вы видите как его штаны набухают.<br>- Дорогой, ты что-нибудь еще хочешь?, - улыбаясь спрашиваете вы его.<br>- Можно мне присоединиться?, - немного смущенно спрашивает <<$husName>>.'
					act 'Разрешить':
						*clr & cla
						if $loc = 'kuhr':
							analorgasm += 1
						else
							vaginalOrgasm += 1
						end
						orgasm += 1
						horny = 0
						husband += 1
						mastrOnce = 0
						minut += 5
						dildohand = 0
						gs'stat'
						gs 'zz_render', '', 'images/city/south/apartment/husband/m'+iif($loc = 'kuhr',3,13)+'.jpg','<<$husName>> достает член и начинает мастурбировать глядя не вас. Это не совсем то, чего вы от него ожидали, и поначалу вам даже стало немного обидно от того, что он не вошел в вас. Но потом пикантность момента начала вас заводить, и вы с энтузиазмом принялись вгонять дилдо себе в '+iif($loc = 'kuhr','попку','писю')+'. Вскоре вы вскрикнули и повалились на стол, испытав оргазм. <<$husName>> яростно дрочил глядя на торчащий из вашей '+iif($loc = 'kuhr','попки','вагины')+' дилдо, а вы, заметив его взгляд, вынули его и начали облизывать, смотря мужу прямо в глаза. От такого зрелища он сразу разрядился на пол. Вы потянулись к нему губами и через секунду он уже страстно целовал вас.'
						act 'Закончить': gt $loc, $metka
					end
					act 'Запретить':
						cla
						husband -= 1
						husband_know_mastr = 1
						gs 'zz_render', '', '','- Нет, я и сама справлюсь, - ответили вы ему.<br>- Я тогда подожду за дверью, пока ты закончишь, - сказал он обидевшись, и вышел.'
						act 'Продолжить': gt 'selfplay'
						act 'Отказаться от этой затеи':dildohand = 0 & gt $loc, $metka
					end
				end
			end
		elseif harakHusb = 1:
			husband += 1
			gs 'zz_render', '', '','- Вот это номер а меня значит тебе уже не хватает?, - спрашивает он вас.<br>- Извини дорогой, но мне очень надо, а ты был занят, - ответили вы, не прекращая мастурбировать.<br>- Ну тогда покажи мне все что ты умеешь, а я посмотрю, - улыбнулся возбуждённо <<$husName>>.<br>- И как я это в попку делаю, тоже показать?, - спросили вы его.'
			if izvratH = 0 or $loc = 'sitr':
				husbizvradd += 1
				horny = 0
				orgasm += 1
				vaginalOrgasm += 1
				mastrOnce = 0
				minut += 5
				dildohand = 0
				gs'stat'
				gs 'zz_render', '', '','- Нет, не нужно, пока и этого хватит,- ответил он и сев на стул начал наблюдать. Вы продолжили удовлетворять себя и вскоре бурно кончили у него на глазах. <<$husName>> встал и начал аплодировать.<br>- Браво, а на бис еще разок?, - смеясь сказал он.<br>- Для таких прекрасных зрителей, все что угодно, - также рассмеялись вы. - Но только после антракта!<br><<$husName>> подошел к вам и страстно поцеловал в губы.'
				act 'Закончить': gt $loc, $metka
			else
				gs 'zz_render', '', '','- А то как же, обязательно продемонстрируй, - ответил он.<br>- Все что пожелаете, сэр, - улыбнулись вы ему, обольстительно облизав губы'
				act 'Показать':
					*clr & cla
					minut += 5
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/city/south/apartment/husband/m2.jpg','Вы вынимаете дилдо из киски и подмигнув мужу, подносите к своей <<$anustipe3>> попке.'
					gs 'zz_dynamic_sex', 'anal_start', 'dildo'
					gs 'zz_dynamic_sex', 'anal', 'dildo'
					gs 'zz_render', '', '','<<$husName>> внимательно наблюдает как дилдо исчезает в вашем анусе, а затем снова появляется. Вы видите как его штаны набухают.<br>- Дорогой, ты что-нибудь еще хочешь?, - улыбаясь спрашиваете вы его.<br>- Не просто хочу, дорогая, но и сделаю, - ответил <<$husName>>, расстегивая штаны и подставляя член к вашему лицу.'
					act 'Взять в рот':dildohand = 0 & gt 'apartment_south_event','apartment_suck'
				end
			end
		else
			husband += 1
			dildohand = 0
			gs 'zz_render', '', '','- Что, дырка зачесалась?, - спрасол он.<br>- Извини дорогой, но мне очень надо, а ты был занят, - отвечаете вы, не прекращая мастурбировать.'
			if izvratH = 0:
				husbizvradd += 1
				gs 'zz_render', '', '','- Ну тогда вынь из дырки эту резиновую дрянь, мне тоже очень надо, - сказал он доставая член. - Сейчас я тебя трахать буду по-настояшему!'
				act 'Раздвинуть ноги':
					horny += 10
					suprdolg += 1
					dick = husDick
					harakBoy = harakHusb
					$boy = $husName
					picrand = 87
					gt 'sex', 'vaginal', 'vag'
				end
			else
				dom -= 1
				gs 'zz_render', '', '','- Ну тогда вставь эту хрень себе в очко и разомни, я скоро его попользую, - сказал он, доставая член. - А пока сосни по быстрому.<br>Вы быстро переставляете дилдо из киски в анус, и покорно открываете рот.'
				act 'Взять в рот':gt 'apartment_south_event','apartment_suck',1
			end
		end
	else
		gs 'zz_render', '', 'images/city/south/apartment/husband/mastr_'+iif($loc = 'kuhr','kuhr','sitr')+'.jpg','Вы взяли <<dildohand>>-см дилдо и приготовились действовать...'
		if vgape < 2:act 'Дилдо в вагину':gt 'apartment_south_event','apartment_selfplay_vag'
		if agape < 2:act 'Дилдо в анус':gt 'apartment_south_event','apartment_selfplay_anal'
		act 'Отказаться от этой затеи': gt $loc, $metka
	end
end
if $ARGS[0] = 'apartment_suck':
	*clr & cla
	minut += 5
	suprdolg += 1
	gs'stat'
	gs 'zz_render', '', 'images/city/south/apartment/husband/m'+iif($loc = 'kuhr',4,14)+'.jpg','Вы обхватываете его еще немного вялый член губами и начинаете сосать, продолжая вгонять дилдо себе в анус. Когда его член окончательно окреп, <<$husName>> остановил вас:<br>'+iif($args[1] = 1,'- Все, подставляй очко! А эту хрень себе в пизду засунь, как будто тебя в два ствола ебут','- Ну, а теперь я займу эту дырочку..')+'.'
	act 'Подставить попку':
		suprdolg += 1
		dick = husDick
		harakBoy = harakHusb
		$boy = $husName
		picrand = 87
		gt 'sex', 'anal'
	end
end
if $ARGS[0] = 'apartment_selfplay_vag':
	*clr & cla
	minut += 5
	gs 'apartment_south_event','husband_check'
	protect = 1
	gs'stat'
	gs 'zz_render', '', 'images/city/south/apartment/husband/mastr_vag'+iif($loc = 'kuhr',rand(0,5),rand(3,8))+'.gif'
	gs 'zz_dynamic_sex','sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dildo'
	if horny > 0:
		if husband_inhouse = 0:
			if vgape < 2:act 'Продолжать':gt 'apartment_south_event','apartment_selfplay_vag'
			if agape < 2:act 'Дилдо в анус':gt 'apartment_south_event','apartment_selfplay_anal'
			act 'Отказаться от этой затеи':dildohand = 0 & gt $loc, $metka
		else
			act 'Далее': gt 'apartment_south_event','selfplay_dildo'
		end
	else
		act 'Перевести дух':dildohand = 0 & gt $loc, $metka
	end
end
if $ARGS[0] = 'apartment_selfplay_anal':
	*clr & cla
	minut += 5
	gs 'apartment_south_event','husband_check'
	gs'stat'
	gs 'zz_render', '', 'images/city/south/apartment/husband/mastr_anal'+iif($loc = 'kuhr',rand(0,4),rand(4,7))+'.gif'
	gs 'zz_dynamic_sex', 'anal_start', 'dildo'
	gs 'zz_dynamic_sex', 'anal', 'dildo'
	if horny > 0:
		if husband_inhouse = 0:
			if agape < 2:act 'Продолжать':gt 'apartment_south_event','apartment_selfplay_anal'
			if vgape < 2:act 'Дилдо в вагину':gt 'apartment_south_event','apartment_selfplay_vag'
			act 'Отказаться от этой затеи':dildohand = 0 & gt $loc, $metka
		else
			act 'Далее': gt 'apartment_south_event','selfplay_dildo'
		end
	else
		act 'Перевести дух':dildohand = 0 & gt $loc, $metka
	end
end
if $ARGS[0] = 'plumber_start':
	*clr & cla
	kransloman = 0
	if husband = 0 or husbandrink = 10 or husband > 0 and week < 6 and hour > 7 and hour < 17:
		gt 'apartment_south_event','plumber'
	else
		gt 'apartment_south_event','plumber_husband'
	end
end
if $ARGS[0] = 'plumber_husband':
	*clr & cla
	minut += 20
	dick = husDick
	harakBoy = harakHusb
	$boy = $husName
	dick2 = 16
	$boy2 = 'сантехник'
	gs 'zz_render', '', 'images/city/south/apartment/plumber/12.jpg','Вы сказали мужу о сломаном кране и он тут же позвонил в круглосуточную службу ремонта. Через двадцать минут приехал сантехник.<br>Муж проводил его на кухню и вы вдвоем стали наблюдать за его действиями, вам надоело слушать как сантехник рассказывает о прокладках, китайских кранах, и что люди запихивают в раковины, и вы решили уйти в зал.'
	act 'Уйти':
		*clr & cla
		minut += 20
		horny += 50
		gs'stat'
		gs 'zz_render', '', 'images/city/south/apartment/plumber/13.jpg','Вы ушли в зал и сели на диван, вскоре пришел муж и сел рядом. Одной рукой он обнял вас, а вторую запустил вам в трусики и начал массировать вам клитор.<br>- Перестань, - сказали вы. - А если сантехник войдет?<br>- Да ему там еще час ковыряться, - ответил <<$husName>>. - Давай по быстрому минетик сделаешь и всё...<br>- Хорошо, давай, - ответили вы, тем более вам уже и самой очень хотелось, его рука сделала свое дело.'
		act 'Начать':
			*clr & cla
			gs 'zz_render', '', 'images/city/south/apartment/plumber/14.jpg','Муж встал и расстегнув ширинку достал член, вы опустились перед ним на колени и только его член оказался у вас во рту, как в комнату вошел сантехник<br>- Я закончил,- объявил он, и замер, увидев такую картину.'
			if izvratH = 0:
				gs 'zz_render', '', '','Муж попытался вынуть член из вашего рта'
				if horny < 80 or shameless['flag'] <= 1:
					act 'Прекратить':
						*clr & cla
						money -= 1500
						gs 'zz_render', '', 'images/city/south/apartment/plumber/15.jpg','Муж быстро спрятал член в штаны и вместе с сантехником вышел в коридор'
						act 'Уйти':gt'sitr'
					end
				end
				if shameless['flag'] > 1:
					act 'Не останавливаться':
						*clr & cla
						orgasm += 1
						bj += 1
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'images/city/south/apartment/plumber/16.jpg','Вы схватили мужа за бедра и продолжили работать ртом. Он еще пару раз дернулся, попытавшись высвободиться, но вы уже не могли остановиться и лишь глубже вбирали в себя его член. Когда он перестал сопротивляться, вы опустили одну руку к своей промежности, и всего парой движений довели себя до оргазма. Но возбуждение не спало, вам захотелось еще большего, а взгляд наблюдающего сантехника еще больше возбуждал вас. Вы уже не могли себя контролировать.'
						act 'Оседлать мужа':
							*clr & cla
							suprdolg += 1
							husband += 1
							husbizvradd += 1
							minut += 5
							pose = 2
							gs 'stat'
							gs 'zz_render', '', 'images/city/south/apartment/plumber/17.jpg','Вы выпустили член мужа из рта, быстро встав толкнули его на диван, и запрыгнули сверху.'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							gs 'zz_render', '', '','А сантехник всё это время так и стоял на пороге, наблюдая за вами. Кончив, муж снял вас с себя и, одев штаны, вышел вместе с сантехником в коридор.'
							act 'Уйти': gt 'sitr'
						end
					end
				end
			else
				gs 'zz_render', '', '','Муж даже не попытался остановить вас'
				if horny < 80 or shameless['flag'] <= 1:
					act 'Прекратить':
						*clr & cla
						if harakHusb ! 2:
							money -= 1500
							gs 'zz_render', '', 'images/city/south/apartment/plumber/15.jpg','Вы выпустили член мужа, он быстро спрятал его в штаны и вместе с сантехником вышел в коридор'
							act 'Уйти':gt'sitr'
						else
							guy += 1
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'images/city/south/apartment/plumber/18.jpg','Вы попытались выплюнуть член из рта, но муж схватил вас за голову и начал сам трахать вас в рот, одновременно разговаривая с сантехником.<br>- Мы тут немного заняты, подожди немного, - сказал он ему. - Сейчас женушку накормлю. Кстати сколько я тебе должен?<br>- Полторы тысячи, - ответил сантехник.<br>- Ну у вас и цены,- протянул ваш муж. - Может договоримся?<br>Сантехник непонимающе уставился на него.<br>- Что если ты её тоже покормишь и разойдемся?, - предложил ваш муж ему.<br>- Ну не знаю, минет это если только на скидку потянет, - ответил сантехник. - Вот если её всю опробовать, тогда да.<br>- А ты умеешь торговаться, - ответил муж. - Ладно договорились.<br>Зная характер своего мужа вы решили что возражать будет себе дороже.'
							act 'Обслужить обоих':picrand = 43 & gt'sexdvoe','var'
						end
					end
				end
				if shameless['flag'] > 1:
					act 'Не останавливаться':
						*clr & cla
						bj += 1
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'images/city/south/apartment/plumber/16.jpg','Вы продолжили сосать не обращая внимания на наблюдавшего за вами сантехника.'+iif(harakHusb = 0,'Муж старался не смотреть в сторону сантехника, явно стесняясь, зато тот не стесняясь следил за каждым вашим движением.',iif(harakHusb = 1,'Муж стоял и наслаждался процессом не обращая на сантехника внимания.','Муж болтал с сантехником совершенно не стесняясь и даже немного повернулся чтобы тому было лучше видно.'))
						act 'Продолжать':
							*clr & cla
							swallow += 1
							suprdolg += 1
							husband += 1
							horny += 20
							money -= 1500
							minut += 5
							gs 'stat'
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_funcs', 'cum', 'face'
							gs 'zz_render', '', 'images/city/south/apartment/plumber/19.jpg','Вы продолжили делать мужу минет, и вскоре струя горячей жидкости брызнула вам в рот, попадав и на лицо, пачкая его. Проглотив сперму, вы слизали остатки его семени с члена. Муж убрал член в штаны и вышел в коридор вместе с сантехником. А вы остались сидеть на полу изнемогая от желания.'
							act 'Уйти':gt'sitr'
						end
						if horny > 70:
							act 'Предложить втроем':
								*clr & cla
								gs 'zz_render', '', 'images/city/south/apartment/plumber/20.jpg','Вы оторвались от члена, и шепотом спросили у мужа, не хочет ли он попробовать втроем.'
								if harakHusb = 0:
									*clr & cla
									gs 'zz_render', '', 'images/city/south/apartment/plumber/21.jpg','Муж немного замялся с ответом, тогда чтобы убедить его вы уже во весь голос продолжили:<br>- Пусть он полижет у меня, пока я буду у тебя сосать.<br>Сантехник с готовностью напрягся, ожидая реакции мужа.<br>- Ну если только полижет, тогда пусть, - ответил муж.'
									act 'Стать раком':
										*clr & cla
										husband += 1
										minut += 5
										gs'stat'
										gs 'zz_render', '', 'images/city/south/apartment/plumber/22.jpg','Сантехника не пришлось уговаривать. Стоило мужу сесть на диван, а вам встать на колени и выпятить попку, как его язык проник в вашу киску. Поначалу муж посматривал в его сторону, но вскоре окончательно расслабился, и когда парень начал вовсю орудовать пальцами в ваших дырочках, не произнес ни звука. Вы решили, что он уже не против разделить вас с другим.'
										act 'Обслужить обоих':picrand = 43 & gt'sexdvoe','var'
									end
								elseif harakHusb = 1:
									*clr & cla
									husband -= 5
									money -= 1500
									gs 'zz_render', '', 'images/city/south/apartment/plumber/15.jpg','- Ты совсем сбрендила?,- крикнул, охреневший от такого предложения, муж, пряча член в штаны. - Чтобы я жену с каким то сантехником делил? Остуди пизду дура, думать надо головой!<br>Быстро приведя себя в относительный порядок, он вышел из комнаты вместе с сантехником.'
									act 'Уйти':gt'sitr'
								elseif harakHusb = 2:
									*clr & cla
									husband += 2
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'images/city/south/apartment/plumber/23.jpg','- Вот не зря говорят все бабы бляди, - c наигранным возмущением произнёс муж. - Эй, парень, хочешь эту шлюху на двоих распишем? Но тогда ремонт бесплатно!<br>Сантехнику дважды предлагать не пришлось. Он быстро подошел и достав член подставил его к вашему лицу. Вы вцепились в него и принялись сосать оба поочередно, а муж стоял и комментировал ваши действия:<br>- Вот присосалась к свежему мясу, про меня не забывай! Вот так молодец, глубже заглатывай, глубже...'
									act 'Обслужить обоих':picrand = 43 & gt'sexdvoe','var'
								end
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'plumber':
	*clr & cla
	kransloman = 0
	minut += 20
	dick = 16
	harakBoy = 2
	$boy = 'сантехник'
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/apartment/plumber/'+iif(vnesh >= 40,0,1)+'.jpg','Вы позвонили в круглосуточную службу ремонта. Через двадцать минут приехал сантехник.<br>Вы проводили его на кухню, а сами стали заниматься своими делами.'+iif(vnesh >= 40,' Когда вы потянулись к одной из полок, то заметили, что он пялится на вашу попку.','')
	act iif(shameless['flag'] > 0,'Не обращать внимания','Смутиться'): gt 'apartment_south_event','plumber_end'
end
if $ARGS[0] = 'plumber_end':
	*clr & cla
	kransloman = 0
	minut += 30
	gs'stat'
	gs 'zz_render', '', 'images/city/south/apartment/plumber/2.jpg','Спустя полчаса он сказал, что закончил, и с вас 1500 руб.'
	if money >= 1500:
		act 'Заплатить':
			money -= 1500
			gt 'kuhr'
		end
	else
		gs 'zz_render', '', '','<red>У вас не хватает денег.</red>'
		if money < 1500:
			act 'У меня не хватает денег':
				cla
				gs 'zz_render', '', '','Вы смутились и сказали '+iif(Grisha = 0,'сантехнику','Грише')+', что у вас не хватает денег. Он заметно разозлился:<br>- Что же вы '+iif(Grisha = 0,'девушка','<<$name>>')+' вызываете сантехника не имея даже денег? И что мне прикажете теперь делать?'
				act 'Я даже не знаю':gt 'apartment_south_event','plumber_bj'
				act 'Может в долг? Я потом отдам':gt 'apartment_south_event','plumber_credit_start'
			end
		end
		if shameless['flag'] > 1 or GrishaSex > 0:
			act 'Предложить другие варианты (сделать минет)':
				*clr & cla
				horny += 40
				gs'stat'
				gs 'zz_render', '', 'images/city/south/apartment/plumber/3.jpg','У меня не хватает денег, но может вы примите другую форму оплаты? - спрашиваете вы, опускаясь перед ним на колени, и начиная расстегивать его ширинку. Парень явно не возражает и наблюдает за вашими действиями.'
				act 'Продолжать':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'images/city/south/apartment/plumber/4.jpg','Вы достаете его еще вялый член и крепко сжав его рукой, начинаете целовать головку, постепенно засасывая его в рот.'
					gs 'zz_dynamic_sex', 'bj'
					act 'Продолжать':
						*clr & cla
						if GrishaSex = 0: GrishaSex = 1 & guy += 1
						bj += 1
						minut += 5
						gs 'stat'
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_render', '', 'images/city/south/apartment/plumber/5.jpg','Вы старательно сосали его член, а между ног все зудело от желания. Вы пару раз порывались прекратить и перейти к сексу, но он брал вас за голову и продолжал трахать ваш ротик. Вскоре '+iif(Grisha = 0,'парень','Гриша')+' кончил вам в рот и только вы собрались проглотить, и вновь поднять его член, как он одел штаны и молча пошел к выходу. Спать с вами он даже не собирался.'+iif(vnesh < 40,'От расстройства вы выплюнули сперму на пол, похоже вы даже сантехника не привлекаете.','')
						act 'Уйти':gt'korr'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'plumber_bj':
	*clr & cla
	gs 'zz_render', '', 'images/city/south/apartment/plumber/2.jpg','Вы растерянно пожали плечами и пробормотали что понятия не имеете, что теперь делать. '+iif(Grisha = 0,'Сантехник','Грише')+' осмотрел вас своими масляными глазами и сказал вам с гнусной ухмылкой:<br>- Может по другому отблагодаришь? Я могу взять за работу не только деньгами...'
	act 'Давай лучше в долг':gt 'apartment_south_event','plumber_credit_start'
	act iif(GrishaSex = 0,'Это как, по другому?','Как в прошлый раз?'):
		*clr & cla
		gs 'zz_render', '', 'images/city/south/apartment/plumber/6.jpg',iif(GrishaSex = 0,'Вы спросили у сантехника, что он имеет в виду. А он,','Гриша,')+' вместо ответа, взял вас за плечи и привлек к себе. Вы уперлись своей мягкой грудью в его грудь и почувствовали как вам в живот упирается, что-то твердое. Он легко надавил вам на плечи и прошептал:<br>- Ну же детка не стесняйся...'
		act 'Опуститься на колени':
			*clr & cla
			gs 'zz_render', '', 'images/city/south/apartment/plumber/'+iif(bj = 0,7,8)+'.jpg','Вы медленно опустились на колени перед пахнущим потом сантехником. Он расстегнул ширинку и перед вашим лицом оказался его член.'+iif(bj = 0,'Вам еще не приходилось брать в рот и вы с ужасом глядели на прибор, который вам предстояло отсосать. '+iif(Grisha = 0,'Сантехник','Гриша')+' видя ваше замешательство взял вас за голову и подтянул к члену, пока ваши губы невольно коснулись багровой головки.','Вы наклонили голову немного вперед и поцеловали багровую головку члена.')
			act 'Сосать':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/city/south/apartment/plumber/9.jpg',''
				gs 'zz_dynamic_sex', 'bj'
				act 'Продолжать':
					*clr & cla
					minut += 1
					bj += 1
					dom -= 1
					if GrishaSex = 0: GrishaSex = 1 & guy += 1
					gs'stat'
					gs 'zz_render', '', 'images/city/south/apartment/plumber/10.jpg',''
					gs 'zz_dynamic_sex', 'swallow'
					gs 'zz_render', '', '','Когда вы подняли голову, то увидели стоящего над вами, и ухмыляющегося, сантехника, застёгивающего ширинку. После этого он развернулся и пошел на выход из вашей квартиры.'
					act 'Проводить сантехника':gt $loc, $metka
				end
			end
		end
	end
end
if $ARGS[0] = 'plumber_credit_start':
	*clr & cla
	minut += 10
	santehnikDolg += 1500
	gs'stat'
	gs 'zz_render', '', 'images/city/south/apartment/plumber/11.jpg','Вы предложили сантехнику оформить работу в долг. '+iif(Grisha = 0,'Он подумал немного и сказал:<br>- Ладно. Только пишите расписку. Я как-нибудь загляну и вы отдадите мне деньги. Меня кстати Гриша зовут, а вас как?<br>Вы улыбнулись, почувствовав, что гроза миновала, и сказали сантехнику, что вас зовут <<$name[1]>>','Гриша вам улыбнулся:<br>- Мы, чай, не в первый, и не в последний раз работаем с вами')+'. После чего взяли бумагу и ручку и начали писать сантехнику расписку о том, что вы должны ему 1500 рублей. Гриша взял бумагу и спрятал в карман.<br>- Если что опять сломается, звони, вот моя визитка, - сказал он на последок и направился к выходу.'
	act 'Проводить сантехника':Grisha = 1 & gt $loc, $metka
end
if $ARGS[0] = 'plumber_Grisha':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'images/img/house/s3.jpg','Вы позвонили сантехнику Грише и он приехал к вам буквально через 15 минут. Быстро выяснив причину, он устранил ее, отремонтировав ваш кран.'
	act 'Далее': gt 'apartment_south_event','plumber_end'
end
if $ARGS[0] = 'edagotd':
	*clr & cla
	cook_food = val(input("Сколько порций вы хотите приготовить?"))
	if cook_food <= eda:
		edahot += cook_food
		eda -= cook_food
		manna -= cook_food
		minut += cook_food*15
		if husband > 0: husband += 5
		garbage += cook_food
	else
		'<font color=red>У вас недостаточно продуктов в холодильнике.</font>'
	end
	killvar 'cook_food'
	gs 'stat'
	gs 'zz_render', 'Кухня', 'images/city/south/apartment/event/cook','Вы приготовили еду на плите.'
	act 'Отойти от плиты': gt $loc, $metka
end
if $ARGS[0] = 'dirtarm':
	if fairy > 0:
		*clr & cla
		fairy -= 1
		minut += dirttarelka * 3
		cltarelka += dirttarelka
		dirttarelka = 0
		manna -= 5
		gs 'stat'
		gs 'zz_render', 'Кухня', 'images/city/south/apartment/event/dirt.jpg','Используя моющее средство, вы помыли посуду.'
		act 'Вытереть руки':gt $loc, $metka
	else
		gs 'zz_render', '', '','<b><font color = red>У вас нет моющего средства.</font></b>'
	end
end
!Прихожая!
if $ARGS[0] = 'go_out':
	if sick <= 72 and current_clothing > 2:
		if $args[1] = 'street':
			gt 'street'
		else
			gt 'front_door','start'
		end
	elseif sick > 72 and current_clothing > 2:
		'<b><font color = red>ВЫ СЛИШКОМ СИЛЬНО БОЛЕЕТЕ ЧТО БЫ ХОДИТЬ ПО УЛИЦЕ.</font></b>'
		xgt $loc, $metka
	else
		'<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
		xgt $loc, $metka
	end
end
if $ARGS[0] = 'cleaning_apartment':
	*clr & cla
	if husband > 0:husband += 5
	if my_house = 1:
		dirt_apartment_rent = 0
	else
		dirt_apartment_buy = 0
	end
	minut += dirt_apartment
	manna -= dirt_apartment/5
	gs 'zz_render', '', 'images/city/south/apartment/event/cleaning'+iif(current_clothing > 0,'',iif(tanga = 0,'_nude','_tanga'))+'.jpg','Вы взяли тряпку и начали убираться в квартире.'
	act 'Закончить уборку': gt 'korr'
end
if $ARGS[0] = 'Podstava_1':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/city/south/apartment/event/police1.jpg','Вы подошли к двери и посмотрели в глазок. На площадке вы увидели несколько мужчин. В темноте вы рассмотрели на них фуражки. Один из мужчин сказал вам через дверь:<<br>>- <<$name>> <<$surname>> откройте, милиция.'
	act 'Открыть дверь':
		*clr & cla
		minut += 60
		$npc['0,qwIvanPodstava'] = 2
		gs'stat'
		gs 'zz_render', '', 'images/city/south/apartment/event/police2.jpg','Вы открыли дверь милиционерам недоумевая, чего им от вас нужно. В комнату прошло несколько мужчин в форме и с ними несколько человек в гражданской одежде. Худой и тощий парень, с недельной небритостью, и пистолетом в кобуре, привязанной на ремне подмышкой, сказал:<<br>>- Понятые, займите свои места. Сейчас произойдет обыск в квартире этой гражданки, которая обвиняется в краже.<<br>> Следователь обернулся к вам:<<br>>- Вот ордера - этот на ваш арест, этот на обыск. Можете ознакомиться.<<br>>Милиционеры уже во всю обыскивали вашу квартиру. Вскоре один из них вышел и сказал:<<br>>- Вот нашел ключи. Судя по описанию, это как раз ключи от кабинета и сейфа, откуда были украдены деньги.<<br>>Понятые расписались в протоколе который дал им следователь. Он хмуро посмотрел на вас и кивнул головой милиционеру. Тот завел вам руки за спину и на ваших запястьях защелкнулись наручники.'
		act 'Идти с милиционерами':
			*clr & cla
			minut += 60
			DolgRS = 650000
			gs'stat'
			gs 'zz_render', '', 'images/city/south/apartment/event/police3.jpg','Вас вывели в наручниках из дома и посадили в милицейский уазик. После, стали хлопать двери уазика и машина тронулась рыча и трясясь на каждой кочке. Наконец вы приехали куда-то и вас достав из уазика проводили в кабинет к уже знакомому вам следователю. Он снял с вас наручники и предложил присесть. Вы сели на жесткий и неудобный стул, а следователь тем временем включил телевизор и вставил в видеомагнитофон кассету. На экране была картинка с камеры слежения в Быстроешке. Там виднелся коридор. Вскоре в коридоре показались вы. Вы подошли к двери и открыв ее вошли в кабинет. Через некоторое время дверь открылась и вы вышли из кабинета с толстым конвертом в руках. Следователь выключил видеомагнитофон и достал кассету, после чего он вставил другую кассету. На следующей кассете был кабинет Анатолия Борисовича. Входная дверь открылась и в нее вошли вы, держа ключи в руках. Вы подошли к сейфу и открыли его ключом. Достали конверт. <<$burgerIvanText>>. Следователь выключил телевизор и достал из стола полиэтиленовый пакет с ключами. Он бросил их на стол и наконец заговорил:<<br>>- Экспертиза установила, это действительно ключи от кабинета и сейфа владельца Быстроежки. При обыске они были найдены в вашей квартире. На записи камер наблюдения ясно видно как вы проникли в кабинет и украли 650 тысяч.<<br>>Он достал протокол и взяв ручку в руку стал писать. Исписав пол листа он поднял свои мрачные глаза на вас и сказал:<<br>>- Чистосердечное признание поможет вам на суде. Все таки это в первый раз и при условии, что вы вернете деньги, вам могут дать условное наказание, если вы признаете свою вину.'
			act 'Идти с милиционерами':
				*clr & cla
				minut += 60
				gs'stat'
				gs 'zz_render', '', 'images/city/south/apartment/event/police4.jpg','Следователь снял с вас наручники и предложил присесть. Вы сели на жесткий и неудобный стул, а он, тем временем, включил свой ноутбук и вставил в него флешку. На экране была картинка с камеры слежения в Быстроешке. Там виднелся коридор. Вскоре в коридоре показались вы. Вы подошли к двери и открыв ее вошли в кабинет. Через некоторое время дверь открылась и вы вышли из кабинета с толстым конвертом в руках. Следователь выключил видеомагнитофон и достал кассету, после чего он вставил другую кассету. На следующей кассете был кабинет Анатолия Борисовича. Входная дверь открылась и в нее вошли вы, держа ключи в руках. Вы подошли к сейфу и открыли его ключом. Достали конверт. <<$burgerIvanText>>. Следователь выключил телевизор и достал из стола полиэтиленовый пакет с ключами. Он бросил их на стол и наконец заговорил:<<br>>- Экспертиза установила, это действительно ключи от кабинета и сейфа владельца Быстроежки. При обыске они были найдены в вашей квартире. На записи камер наблюдения ясно видно как вы проникли в кабинет и украли 650 тысяч.<<br>>Он достал протокол и взяв ручку в руку стал писать. Исписав пол листа он поднял свои мрачные глаза на вас и сказал:<<br>>- Чистосердечное признание поможет вам на суде. Все таки это в первый раз и при условии, что вы вернете деньги, вам могут дать условное наказание, если вы признаете свою вину.'
				act 'Подписать признание':
					cla
					minut += 60
					gs 'stat'
					gs 'zz_render', '', '','Вы подписали признание и следователь гаркнул:<<br>>- Дежурный!<<br>>В комнату вошел милиционер. Следователь кивнул показывая ему на вас:<<br>>- Уведи ее...'
					act 'Идти':gt'kameraKPZ'
				end
				act 'Рассказать как все было':
					cla
					minut += 60
					gs 'stat'
					gs 'zz_render', '', '','Вы стали рассказывать следователю как все было. Как менеджер Иван подставил вас. Но следователь слушал вас в пол уха. Наконец он хлопнул кулаком по столу и заорал на вас:<<br>>- Я не вчера родился, чтобы меня такой чушью кормить! Если не будешь сотрудничать, я тебя сгною!<<br>>В комнату вошел милиционер. Следователь кивнул показывая ему на вас:- Уведи её...'
					act 'Идти':gt'kameraKPZ'
				end
			end
		end
	end
	exit
end
if $ARGS[0] = 'Podstava_2':
	*clr & cla
	$npc['0,qwIvanPodstava'] = 4
	money = money + karta - 650000
	karta = 0
	minut += 120
	gs 'zz_render', '', 'images/city/south/apartment/event/police5.jpg','За вами приехал наряд милиции и отвез вас на суд. '+iif(DolgRS <= money + karta,'Вы сумели выплатить свой долг и вас отпустили по примирению сторон.','За вами приехал наряд милиции и отвез вас на суд. На суде вам дали пять лет общего режима, обязав выплатить долг.<br>Но до конца срока вы не дожили...')
	if DolgRS <= money + karta:
		act 'Выйти из здания суда':gt'down'
	else
		gt'gameover',7
	end
end
if $ARGS[0] = 'plumber_credit_end':
	*clr & cla
	gs 'zz_render', '', 'images/city/south/apartment/plumber/plumber_credit_end.jpg','Вы подошли к двери и посмотрели в глазок. На площадке вы увидели темную мужскую фигуру. Видимо мужчина услышал вас и сказал вам через дверь:<br>- Это я. Сантехник Гриша. Вы мне денег должны."'
	act 'Открыть дверь':
		*clr & cla
		money -= santehnikDolg
		santehnikDolg = 0
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/city/south/apartment/plumber/Grisha.jpg','Вы открыли дверь сантехнику и Гриша довольно улыбнулся:<br>- Я думал вы прятаться от меня теперь будете. Ну как? Есть чем заплатить?<br>Вы кивнули и полезли за кошельком. Отсчитав полторы тысячи вы отдали деньги Грише и тот положил их в карман. После чего попрощался с вами и ушел.'
		act 'Закрыть дверь':gt 'korr'
	end
end
!Балкон!
if $ARGS[0] = 'neighbor':
	*clr & cla
	neighborday = day
	gs 'zz_render', 'Балкон', 'images/city/south/apartment/event/neighbor'+iif(args[1] = 0 or current_clothing > 0,'','_handjob')+'.jpg','В доме напротив, на балкон'+iif(args[1] = 1,'е,','')+iif(args[1] = 1,' стоит',' вышел')+' сосед и '+iif(current_clothing = 0 and args[1] = 1,' дрочит',' уставился')+' на вас'+iif(current_clothing = 0,' голую','')+'.'
	if current_clothing = 0:
		if shameless['flag'] > 0:
			act 'Демонстрировать тело': gt'apartment_south_event', 'show_body'
			act 'Показать средний палец': gt'apartment_south_event', 'fuck'
			act 'Не обращать внимания':neighbor = 1 & gt'balkon'
		end
		if args[1] = 0:act 'Убежать в комнату': gt'apartment_south_event', 'escape_room'
	else
		if shameless['flag'] > 0:act 'Показать соседу сиськи': gt'apartment_south_event', 'show_tits'
		act 'Не обращать внимания':neighbor = 1 & gt'balkon'
	end
end
if $ARGS[0] = 'show_body':
	*clr & cla
	neighbor = 0
	horny += 20
	minut += 5
	if exhibi = 2: exhibi = 3
	gs 'stat'
	gs 'zz_render', 'Балкон', 'images/city/south/apartment/event/show_body_'+iif(tanga = 1,'tanga'+rand(1,3),'nude'+rand(1,5))+'.jpg','Вы демонстративно начинаете позировать на балконе, радуя глаз соседа. Он яростно дрочит, глядя на вас возбуждёнными глазами. Спустя пять минут он кончил и ушел в свою квартиру.'
	act 'Далее': gt 'balkon'
end
if $ARGS[0] = 'show_tits':
	*clr & cla
	neighbor = 0
	horny += 10
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Балкон', 'images/city/south/apartment/event/show_tits'+rand(1,3)+'.jpg','Вы глянули на соседа напротив, а затем игриво задрали свой топик, демонстрируя ему свой грудь <<body[''tits'']>> размера. Увидев это, он принялся яростно дрочить, не сводя взгляда с вашей обнаженной груди. Спустя пять минут он кончил и ушел в свою квартиру.'
	act 'Далее': gt 'balkon'
end
if $ARGS[0] = 'fuck':
	*clr & cla
	horny += 5
	minut += 1
	if dom < 25: dom += 1
	sosedBalDay = day
	neighbor = 0
	gs 'stat'
	gs 'zz_render', 'Балкон', 'images/city/south/apartment/event/fuck.jpg','Вы показали соседу большой палец и он ушел с балкона.'
	act 'Далее': gt 'balkon'
end
if $ARGS[0] = 'escape_room':
	*clr & cla
	horny += 5
	minut += 1
	neighbor = 0
	gs 'stat'
	gs 'zz_render', 'Балкон', 'images/city/south/apartment/event/escape_room_'+iif(tanga = 1,'tanga'+iif(shameless['flag'] = 0,1,2),'nude'+iif(shameless['flag'] = 0,1,2))+'.jpg','Вы ойкнули, и '+iif(tanga = 0,'прикрывшись '+iif(shameless['flag'] = 0,'полотенцем',''),iif(shameless['flag'] = 0,'прикрывши грудь рукой','показав соседу язык'))+' кинулись назад в комнату.'
	act 'Далее': gt 'sitr'
end
!НЕ ДОДЕЛАНО!
if $ARGS[0] = 'look_down':
	*clr & cla
	gs'stat'
	gs'time'
	gs 'zz_render','Южный район','images/city/south/apartment/event/look_down'+iif(month >= 4 and month <= 10,iif(hour >= 6 and hour < 22,'','_night'),iif(hour >= 8 and hour < 18,'_winter','_winter_night'))+'.jpg','Вы смотрите на панораму с вашего балкона.'
	act 'Далее':gt'balkon','start'
end