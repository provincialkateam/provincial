$metka = $ARGS[0]
$loc = $CURLOC
$metka = $ARGS[0]
$loc = $CURLOC
frost = 0
gs 'stat'
gs 'zz_funcs', 'colorize_day'
hantslutsexrand = rand(1,3)
temp = rand(1,5)
'<center><H4>Изба</H4></center>'
'<center><img src="images/qwest/gadukino/Swamp/swampizba.jpg"></center>'
'Охотничья избушка. В маленькой комнате с низким потолком есть <a href="exec:GT ''bed'',''start''">топчан</a> на котором вы можете поспать.'
if bucket > 0:'В углу стоит <a href="exec: dynamic $bucket ">ведро</a> с водой.'
if bucket = 0:'В углу стоит пустое ведро.'
'Возле него висит старый <a href="exec: dynamic $washstand ">умывальник</a> и небольшое <a href="exec:GT ''mirror'',''start''">зеркало</a>, а под ними стоит <a href="exec: dynamic $basin">тазик</a>.'
if swamp_enema = 1:'На полке лежит найденая спринцовка.'
'В другом углу стоит небольшая <a href="exec: dynamic $stove">печка</a>. На ней при наличии воды и грибов можно сварить нехитрую еду. Еще можно нагреть воды, чтобы помыться в тазике.'
'Возле неё лежит стопка потрепаных <a href="exec: dynamic $stackmagazines">журналов</a>, скорее всего для розжига.'
if clothesswamphouse = 1 and clearclothes = 0:'На полке лежит ваша <a href="exec: dynamic $dress_after_shower">одежда</a>.'
if clearclothes > 0 and clearclothesH = 1: 'Над печкой сушится ваша одежда.'
if hour = 20 and hanters = 1 and hantersKnow > 0 or hour = 7 and hanters = 1 and hantersKnow > 0:'За столом сидят <a href="exec:dynamic $hanterstable">охотники</a>.'
if hour > 20 and hour < 23 and hanters = 1 and hantersKnow > 0:'В избушке вы видите <a href="exec:dynamic $hantersrelax">охотников</a>.'
if hour = 23 and hanters = 1 and hantersKnow > 0 or hour >= 0 and hour < 7 and hanters = 1 and hantersKnow > 0:'На топчанах спят охотники.'
if edahot > 0:
	act 'Есть':
		cla
		*clr
		gs 'zz_kitchen_acts','eat','','qwest/gadukino/Swamp/soup.jpg'
		act 'Встать из за стола':gt $loc, $metka
	end
end
if bilberry > 0:
	act 'Поесть ягод':
		cla
		*clr
		minut += 30
		energy += 5
		water += 10
		bilberry -= 1
		health += 5
		manna += 10
		gs 'stat'
		'<center><img src="images/qwest/gadukino/forest/bilberry.jpg"></center>'
		'Вы поели ягод.'
		act 'Далее':gt $loc, $metka
	end
end
if current_clothing > 0 and clothesswamphouse = 0 or swamp_cloth = 1:
	act'Снять одежду':
		if hantersKnowSlut > 0 or hanters = 0 or hanters = 1 and hour >= 8 and hour < 20 and hantersKnowSlut = 0:
			cla
			*clr
			clothesswamphouse = 1
			minut += 5
			flag_tanga = tanga
			tanga = 0
			gs 'zz_clothing', 'redress', 0
			'<center><img src="images/qwest/gadukino/Swamp/swamphouseundress.jpg"></center>'
			'Вы не стеснясь разделись, оставшись в чем мать родила.'
			act'Назад':gt'swamphouse'
		else
			cla
			*clr
			'<center><img src="images/qwest/gadukino/Swamp/noundress.jpg"></center>'
			'Несмотря на жару вы все таки стесняетесь раздеться, а вдруг кто-нибудь увидит?'
			act'Назад':gt'swamphouse'
		end
	end
end
if horny >= 50 and hanters = 0 or horny >= 50 and hanters = 1 and hour >= 8 and hour < 20:
	act 'Мастурбировать':
		gt'selfplay'
	end
end
if current_clothing = 0 and swamp_cloth = 0:
	act 'Искать одежду':
		cla
		*clr
		minut += 10
		if swamp_enema = 0:
			swamp_enema = 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/enema.jpg"></center>'
			'Вы искали какую-нибудь одежду, но нашли клизму... зачем она здесь интересно?.'
			act 'Далее':gt'swamphouse'
		else
			swamp_clothes = 1
			gs 'zz_clothing', 'redress', 1
			'<center><img src="images/qwest/gadukino/Swamp/swamphouse_tkancloth.jpg"></center>'
			'Вы нашли кусок мешковины... Ну хоть что-то.'
			act 'Назад.':gt'swamphouse'
		end
	end
end
if klismaday ! day and swamp_enema = 1 and analplugin = 0 and hour >= 8 and hour < 20 and hanters = 1 or klismaday ! day and swamp_enema = 1 and analplugin = 0 and hanters = 0:
	act 'Сделать себе клизму 5 мин':
		cla
		*clr
		minut += 5
		klismaday = day
		'<center><img src="images/qwest/gadukino/Swamp/swamp_enema.jpg"></center>'
		'Вы поставили себе клизму и прочистили кишечник, теперь ваша попка готова к анальному сексу.'
		act 'Закончить': gt'swamphouse'
	end
end
if dirty_swamphouse > 25:act 'Убираться в избушке':hanterslut -= 1 & dynamic $dirty_swamphouse
act 'Выйти во двор':hanter_refuse = 0 & minut += 5 & gt'swamp_yard'
!секс с Игорем
if hantersIgorLove > 0 and hour > 8 and hour < 19 and hantersIgorQw >= 10 and temp = 1 and hantersIgorsex = 0:
	*clr & cla
	minut += 5
	horny += 5
 	hantersIgorsex += rand(12,36)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Зайдя в избушку вы увидели Игоря. Он с улыбкой подошел к вам и впился в ваши губы страстным поцелуем.'
	'- <<$name[1]>>, я хочу тебя, - прошептал он, прервав поцелуй.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersIgorQw += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(4,6)+'.jpg"></center>'
		'Улыбнувшись вы подмигиваете Игорю. Он, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersIgorQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, Игорь, давай не сейчас, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Уйти':gt $loc, $metka
	end
end
!секс с Сергеем
if hantersSergeiLove > 0 and horny <= 60 and hantersSergeiQw >= 10 and temp = 2 and hantersSergeisex = 0 and hour > 8 and hour < 19:
	*clr & cla
	minut += 5
	horny += 5
	hantersSergeisex += rand(9,30)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Зайдя в избушку вы увидели Сергея. Он с улыбкой подошел и впился в ваши губы долгим поцелуем.'
	'- <<$name[1]>>, я хочу тебя, - сказал он, прервав поцелуй.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersSergeiQw += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterflirt2.'+rand(4,6)+'.jpg"></center>'
		'Улыбнувшись вы подмигиваете Сергею. Он, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersSergeiQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, сергей, давай не сейчас, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Идти':gt $loc, $metka
	end
end
! секс с Андреем
if hantersAndreiLove > 0 and horny <= 60 and hantersAndreiQw >= 10 and temp = 3 and hantersAndreisex = 0 and hour > 8 and hour < 19:
	*clr & cla
	minut += 5
	horny += 5
	hantersAndreisex += rand(6,24)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Зайдя в избушку вы увидели Андрея. Неожиданно он впился в ваши губы страстным поцелуем и ни слова не говоря потянул вас за собой.'
	act 'Идти с Андреем':
		*clr & cla
		minut += 5
		hantersAndreiQw += 1
		horny += 5
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterhands.jpg"></center>'
		'Вы идете с Андреем держась за руки, прекрасно понимая, куда и зачем он вас ведет. И вы совсем даже не против.'
		act 'Далее':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersAndreiQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, <<$boy>>, давай не сейчас, - сказали вы, и стараясь не смотреть на него ушли.'
		act 'Идти':gt $loc, $metka
	end
end
! трио ГГ, Андрей и Сергей, если любовь
if hanters > 0 and doublehanterlove = 1 and hour >= 8 and hour < 20 and (hantersAndreisex = 0 or hantersSergeisex = 0):
	*clr & cla
	minut += 5
	hantersAndreisex += rand(6,24)
	hantersSergeisex += rand(9,30)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.2.jpg"></center>'
	'В избушке вы увидели Андрея с Сергеем.'
	' - Пора, так сказать, исполнять супружеский долг, - сказал Андрей шутливым тоном. - Готовь <<$name[2]>> попу.'
	if klismaday ! day:' - Блин, а я попу не готовила сегодня, - смущаясь сказали вы. - Может не будем?.'
	if klismaday ! day:' - Будем <<$name[2]>>, будем, - ответил Андрей. - Ты не помыла, тебе и расхлебывать. В следующий раз не забудешь.'
	' - Из избушки только уйти нужно, и в кусты поглубже спрятаться, - добавил Сергей. - А то Игорь у нас сильно правильный, не поймет.'
	act 'Идти с парнями':
		*clr & cla
		minut += 5
		hantersAndreiQw += 1
		hantersSergeiQw += 1
		horny += 5
		doublelovesex = 1
		hanterslut += 1
		temphant = 1
		if klismaday ! day:hanterslut += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/doublehanterlove.jpg"></center>'
		'Вы идете с парнями держась за руки, прекрасно понимая, куда и зачем они вас ведут. И вы совсем даже не против.'
		act 'Далее':gt'hantersex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersAndreiQw -= 1
		hantersSergeiQw -= 1
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, ребята, что-то я не хочу, - сказали вы, и не глядя на них ушли.'
		act 'Идти':gt $loc, $metka
	end
end
!охотники приглашают за стол
if hour = 20 and hanters = 1 and hantersKnow > 0 and hantersKnowSlut = 0 and hanter_refuse = 0:
	cla
	*clr
	hantersdrink = iif(hour >= 20 and hour <= 23,1,0)
	gs'stat'
	if hantersdrink = 1:
		*clr & cla
		minut += 1
		temp = rand(1,4)
		gs'stat'
		if temp = 1:
			'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
			'Вы зашли в избушку и увидели выпивающих охотников.'
			'- О, <<$name[1]>>, давай к нам!- начали на перебой приглашать они.'
			act 'Присоединиться':dynamic $hanterstable
			act 'Вежливо отказаться':hanter_refuse = 1 & gt $loc, $metka
		end
		if temp = 2:
			hantersAndreiQw += 1
			'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
			'Вы зашли в избушку и увидели выпивающих охотников.'
			'- О, <<$name[1]>>, давай к нам!- заметив вас предложил Андрей.'
			act 'Присоединиться':dynamic $hanterstable
			act 'Вежливо отказаться':hanter_refuse = 1 & gt $loc, $metka
		end
		if temp = 3:
			hantersSergeiQw += 1
			'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
			'Вы зашли в избушку и увидели выпивающих охотников.'
			'- О, <<$name[1]>>, давай к нам!- заметив вас позвал Сергей.'
			act 'Присоединиться':dynamic $hanterstable
			act 'Вежливо отказаться':hanter_refuse = 1 & gt $loc, $metka
		end
		if temp = 4:
			hantersIgorQw += 1
			'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
			'Вы зашли в избушку и увидели выпивающих охотников.'
			'- О, <<$name[1]>>, давай к нам!- перекрикивая разговор позвал Игорь.'
			act 'Присоединиться':dynamic $hanterstable
			act 'Вежливо отказаться':hanter_refuse = 1 & gt $loc, $metka
		end
	else
		'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
		'Вы зашли в избушку и увидели завтракающих охотников.'
		'- О, <<$name[1]>>, ты вовремя, присоеденяйся!- начали на перебой приглашать они.'
		act 'Присоединиться':dynamic $hanterstable
		act 'Вежливо отказаться':hanter_refuse = 1 & gt $loc, $metka
	end
end
!если ГГ голая и охотники в избушке
if current_clothing = 0 and hanters = 1 and hour >= 20 and hour < 23 and hanterknowday ! day or current_clothing = 0 and hanters = 1 and hour = 7 and hanterknowday ! day:
	cla
	*clr
	temp =rand(1,3)
	gs'stat'
	if hantersKnowSlut = 0:
		cla
		*clr
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/swamphousenude.jpg"></center>'
		'Увидев в избушке мужчин вы ойкнув, принялись прикрываться руками...'
		if clothesswamphouse = 1 and clearclothes = 0:
			act'Одеться':
				cla
				*clr
				clothesswamphouse = 0
				minut += 5
				tanga = flag_tanga
				gs 'zz_clothing', 'redress', prev_clothing
				prev_clothing = -1
				!tkan_cloth = 0
				'<center><img src="images/qwest/gadukino/Swamp/swampdvornude1.jpg"></center>'
				'И, сломя голову, кинулись в избушку одеваться.'
				act'Далее':gt'swamphouse'
			end
		else
			act'Одеться':
				cla
				*clr
				minut+=5
				swamp_clothes = 1
				gs 'zz_clothing', 'redress', 1
				'<center><img src="images/qwest/gadukino/Swamp/tkan_cloth.jpg"></center>'
				'И быстро кинулись в избушку и прикрылись куском мешковины... Ну хоть что-то.'
				act'Далее':gt'swamphouse'
			end
		end
		act'Остаться голышом':
			cla
			*clr
			hanterslut += 1
			hanterknowday = day
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/swamphousenude1.jpg"></center>'
			'Но потом решили пощекотать себе нервы и оставили все как есть. Мужчины старательно отводят глаза от вашего обнаженного тела.'
			'- Ну ты, <<$name[2]>>, блин даешь, - услышали вы только фразу Андрея.'
			act'Далее':gt'swamphouse'
		end
	end
	if hantersKnowSlut > 0:
		if hantslutsex = 0:
			*clr & cla
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/swamphousenude1.jpg"></center>'
			'Увидев вас голую, парни возбудились...'
			'- <<$name[2]>>, подойди-ка к нам, - позвал вас один из парней.'
			act'Далее':hantersexnude = 1 & gt'hantersex'
		else
			hanterknowday = day
			'<center><img src="images/qwest/gadukino/Swamp/swamphousenude1.jpg"></center>'
			'Увидев вас голую, парни только покачали головами...'
			'- Смотри <<$name[2]>>, допрыгаешься у нас, если будешь прелестями тут светить, - шутливо сказал кто-то из парней.'
			act'Далее':gt'swamphouse'
		end
	end
end
! секс если ГГ шлюха
if hanters > 0 and hantersRape = 5 and hantslutsexrand = 1 and hantslutsex = 0 and hour >= 7 and hour < 23:
	*clr & cla
	minut += 5
	temphant = rand(1,3)
	! выбор того, кто будет сношать ГГ
	sluthomesex = 1
	gs 'stat'
	if temphant = 1:'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	if temphant = 2:'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
	if temphant = 3:'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
	if temphant = 1:'Вы занимались своими делами, когда в избушку ввалился Андрей. " - Пошли <<$name[2]>>," - сказал он и больше ни слова не говоря потянул вас за собой на топчан.'
	if temphant = 2:'Вы занимались своими делами, когда в избушку вошел Сергея. Заметив вас он направился в вашу сторону. " - Пошли отойдем <<$name[2]>>, что-то приспичило," - сказал он и потянул вас за собой на топчан.'
	if temphant = 3:'Вы занимались своими делами, когда заметили вошедшего в избушку Игоря. Увидев вас он улыбнуся и подошел. " - <<$name[2]>>, мне нужно напряжение скинуть, давай отойдем," - сказал он улыбаясь и повел вас за собой.'
	if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнем, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнем, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
	act 'Идти':	gt'hantersex'
end
$bucket = {
	cla
	*clr
	minut += 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/vedro2.jpg"></center>'
	'Ведро с водой. В нем еще <<bucket>> литров воды.'
	act'Попить воды':
		cla
		minut+=5
		cumlip = 0
		bucket -= 1
		if water >= 20:
			'Вода в вас больше не лезет.'
		else
			water += 20
			'Вы с удовольствием выпили стакан воды.'
		end
		act 'Далее':gt $loc, $metka
	end
	act'Отойти':gt $loc, $metka
}
$washstand = {
	cla
	*clr
	minut += 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/washstand.jpg"></center>'
	'Старый умывальник. При наличии воды можно умыться.'
	if bucket > 0:
		act 'Умыться':
			cla
			*clr
			minut += 5
			mop = 1
			cumlip = 0
			cumface = 0
			sweat -= 1
			bucket -= 1
			gs 'stat'
			'<center><img src="images/pic/facesp.jpg"></center>'
			'Вы тщательно умыли лицо и смыли косметику.'
			act 'Далее':dynamic $washstand
		end
		if cumfrot > 0:
			act 'Оттирать сперму с одежды':
				cla
				cumfrot = 0
				minut += 15
				bucket -= 1
				gs'stat'
				'<center><img src="images/pic/frotsp.jpg"></center>'
				'Вы замыли пятна спермы на своей одежде.'
				act 'Закончить':dynamic $washstand
			end
		end
	end
	act'Отойти':gt $loc, $metka
}
$stove = {
	cla
	*clr
	minut += 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/stove.jpg"></center>'
	'Неказистая печка-буржуйка, однако свои со своими функциями успешно справляется. При наличии 5 литров воды можно её нагреть для стирки или мытья. Или при наличии грибов приготовить еду. '
	if bucket > 0 and boletus > 0 and edahot = 0:
		act 'Приготовить грибной суп':
			cla
			*clr
			boletus -= 1
			minut += 30
			bucket -= 1
			edahot += 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hotsoup.jpg"></center>'
			'Вы приготовили простенький грибной суп.'
			act 'Далее':gt $loc, $metka
		end
	end
	if bucket >= 5 and hotwater = 0:
		act 'Греть воду':
			cla
			*clr
			minut += 30
			bucket -= 5
			hotwater = 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hotwater.jpg"></center>'
			'Вы нагрели воду, теперь можно помыться в тазике или постирать вещи.'
			act 'Далее':gt $loc, $metka
		end
	end
	act'Отойти':gt $loc, $metka
}
$clothes_read_magazines = {
	if current_clothing > 0:'<center><img src="images/qwest/gadukino/Swamp/readmagazines.jpg"></center>'
	if current_clothing = 0 and tanga = 1:'<center><img src="images/qwest/gadukino/Swamp/readmagazines_tanga.jpg"></center>'
	if current_clothing = 0 and tanga = 0:'<center><img src="images/qwest/gadukino/Swamp/readmagazines_nude.jpg"></center>'
}
$stackmagazines = {
	cla
	*clr
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'qwest/gadukino/Swamp/stackmagazines.jpg','Стопка самых разнообразных журналов, есть даже один с "интересными" картинками.'
	act 'Читать научный журнал':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
		end
		if nerdism > 0:nerdism += 10
		school['intellect'] += 1
		blizoruk += 1
		manna += 10
		minut += 60
		gs 'stat'
		dynamic $clothes_read_magazines
		gs 'zz_render', '', '','Вы решили полистать научный журнал, пытаясь понять всякие умные фразочки и разобраться в предмете описания.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Далее':dynamic $stackmagazines
	end
	act 'Читать литературный журнал':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
		end
		if nerdism > 0:nerdism += 20
		blizoruk += 1
		manna += 10
		minut += 60
		if library_day ! day and school['certificate'] = 0:
			library_day = day
			school['progress'] +=1
		end
		gs 'stat'
		dynamic $clothes_read_magazines
		gs 'zz_render', '', '', 'Вы решили полистать литературный журнал...тягомотина редкая.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Далее':dynamic $stackmagazines
	end
	act 'Читать развлекательный журнал':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
		end
		if nerdism > 0:nerdism += 30
		blizoruk += 1
		manna = 100
		minut += 60
		gs 'stat'
		dynamic $clothes_read_magazines
		gs 'zz_render', '', '', 'Вы листаете развлекательный журнал, погружаясь в мир моды и шоу-бизнеса.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Далее':dynamic $stackmagazines
	end
	act 'Читать порно журнал':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
		end
		blizoruk += 1
		manna = 100
		minut += 60
		horny += 50
		gs 'stat'
		gs 'zz_render', '', 'qwest/gadukino/Swamp/readpornomag'+iif(current_clothing > 0,'',iif(tanga = 0,'_nude','_tanga'))+'.jpg', 'Вы листаете порно журнал читая истории и разглядывая картинки, потихоньку возбуждение начинает охватывать вас.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Далее':dynamic $stackmagazines
	end
	act'Отойти':gt $loc, $metka
}
$basin = {
	cla
	*clr
	minut += 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/basin.jpg"></center>'
	'Старый таз. При наличии горячей воды можно помыться или постирать одежду.'
	if hotwater = 1 and current_clothing < 3:
		act 'Помыться':
			cla
			*clr
			cumpussy = 0
			cumbelly = 0
			cumass = 0
			cumlip = 0
			cumface = 0
			cumanus = 0
			lubonus = 0
			sweat = 0
			manna += 5
			minut += 30
			hotwater = 0
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/basinswim.jpg"></center>'
			'Вы вымылись дочиста и почувствоали себя гораздо лучше.'
			act 'Далее':gt $loc, $metka
		end
	end
	if hotwater = 1 and dirtyclothes = 1 and current_clothing < 3:
		act 'Стирать одежду':
			cla
			*clr
			minut += 60
			dirtyclothes = 0
			hotwater = 0
			cumfrot = 0
			$wardrobe[current_clothing+"_"+'condition'] += iif(val(args[1]) >= 0, val(args[1]), 10)
			gs 'stat'
			if current_clothing = 0:
				'<center><img src="images/qwest/gadukino/Swamp/basinwash.jpg"></center>'
			else
				'<center><img src="images/qwest/gadukino/new/Washclothes1.jpg"></center>'
			end
			'Вы разделись и постирали свою грязную одежду.'
			act 'Развесить одежду в избушке':
				cla
				*clr
				minut += 5
				clearclothes = 5
				clearclothesH = 1
				if current_clothing = 0:
					'<center><img src="images/qwest/gadukino/Swamp/basinwash1.jpg"></center>'
				else
					'<center><img src="images/qwest/gadukino/new/Washclothes2.jpg"></center>'
				end
				'Вы развесили одежду сушиться внутри избушки.'
				act 'Далее':gt $loc, $metka
			end
			if month >= 5 and month <= 9:
				act 'Развесить на поляне':
					cla
					*clr
					minut += 10
					clearclothes = 3
					clearclothesH = 0
					if current_clothing = 0:
						'<center><img src="images/qwest/gadukino/Swamp/basinwash2.jpg"></center>'
					else
						'<center><img src="images/qwest/gadukino/new/Washclothes2.jpg"></center>'
					end
					'Вы развесили одежду сушиться на улице.'
					act 'Далее':gt'swamp_yard'
				end
			end
		end
	end
	act'Отойти':gt $loc, $metka
}
$hanterstableBJ = {
	cla
	*clr
	minut += 1
	hanterstableBJ = 1
	dom -= 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterstable2.jpg"></center>'
	' - Вот же гады, поесть спокойно и то не дадут, - подумали вы и полезли под стол...'
	if hanterstableBJA = 0:
		act 'Сосать Андрею':
			*clr & cla
			$boy = 'Андрей'
			dick = 20
			minut += 5
			horny += 10
			bj += 1
			hanterstableBJA = 1
			if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
			temp = rand(1,2)
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg"></center>'
			'Вы устроились поудобнее под столом и приблизили свое лицо к его члену....'
			gs 'zz_dynamic_sex', 'bj'
			'Вскоре член Андрея напрягся и вы поняли что он сейчас кончит...'
			if temp = 1:
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					gs 'zz_funcs', 'cum', 'face'
					if current_clothing = 0:gs 'zz_funcs', 'cum', 'belly'
					if current_clothing > 0:cumfrot += rand(0,1)
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterstableCum1.'+rand(1,5)+'.jpg"></center>'
					'Андрей вынул член из вашего рта и тут же вам в лицо ударила струя горячей спермы, потом еще и еще пока наконец он не прекратил кончать.'
					act 'Далее':dynamic $hanterstableBJ
				end
			else
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					vaf += 1
					hanterstableBJA = 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg"></center>'
					gs 'zz_dynamic_sex', 'swallow'
					act 'Далее':dynamic $hanterstableBJ
				end
			end
		end
	end
	if hanterstableBJS = 0:
		act 'Сосать Сергею':
			*clr & cla
			$boy = 'Сергей'
			dick = 18
			minut += 5
			horny += 10
			bj += 1
			hanterstableBJS = 1
			if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
			temp = rand(1,2)
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg"></center>'
			'Вы устроились поудобнее под столом и приблизили свое лицо к его члену....'
			gs 'zz_dynamic_sex', 'bj'
			'Вскоре член Сергея напрягся и вы поняли что он сейчас кончит...'
			if temp = 1:
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					gs 'zz_funcs', 'cum', 'face'
					if current_clothing = 0:gs 'zz_funcs', 'cum', 'belly'
					if current_clothing > 0:cumfrot += rand(0,1)
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterstableCum1.'+rand(1,5)+'.jpg"></center>'
					'Сергей вынул член из вашего рта и тут же вам в лицо ударила струя горячей спермы, потом еще и еще пока наконец он не прекратил кончать.'
					act 'Далее':dynamic $hanterstableBJ
				end
			else
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					vaf += 1
					hanterstableBJS = 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg"></center>'
					gs 'zz_dynamic_sex', 'swallow'
					act 'Далее':dynamic $hanterstableBJ
				end
			end
		end
	end
	if hanterstableBJI = 0:
		act 'Сосать Игорю':
			*clr & cla
			$boy = 'игорь'
			dick = 16
			minut += 5
			horny += 10
			bj += 1
			hanterstableBJI = 1
			if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
			temp = rand(1,5)
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg"></center>'
			'Вы устроились поудобнее под столом и приблизили свое лицо к его члену....'
			gs 'zz_dynamic_sex', 'bj'
			'Вскоре член Игорь напрягся и вы поняли что он сейчас кончит...'
			if temp = 1:
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					gs 'zz_funcs', 'cum', 'face'
					if current_clothing = 0:gs 'zz_funcs', 'cum', 'belly'
					if current_clothing > 0:cumfrot += rand(0,1)
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterstableCum1.'+rand(1,5)+'.jpg"></center>'
					'Игорь вынул член из вашего рта и тут же вам в лицо ударила струя горячей спермы, потом еще и еще пока наконец он не прекратил кончать.'
					act 'Далее':dynamic $hanterstableBJ
				end
			else
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					vaf += 1
					hanterstableBJI = 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg"></center>'
					gs 'zz_dynamic_sex', 'swallow'
					act 'Далее':dynamic $hanterstableBJ
				end
			end
		end
	end
	if hanterstableBJA = 1 and hanterstableBJS = 1 and hanterstableBJI = 1:act'Вылезти из под стола':edahot = 1 & dynamic $hanterstable
}
$hanterstable = {
	cla
	*clr
	if hour >= 20 and hour <= 23 :
		hantersdrink = 1
	else
		hantersdrink = 0
	end
	minut += 1
	smokertemp = rand(1,3)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
	if hantersdrink = 1:
		dirty_swamphouse += rand(1,3)
		'На самодельном столе стоят бутылки с водкой и пивом, разложена закусь. Андрей с Сергеем и Игорем выпивают и весело разговаривают.'
	else
		dirty_swamp_yard += rand(0,2)
		'За самодельным столом едят и неспешно беседуют охотники.'
	end
	if hantersdrink = 1 and hour >= 20:
		act 'Выпить водки':
			*clr & cla
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			'<center><img src="images/zsoft/pod_ezd/shulgahome/kuh/vodka2.jpg"></center>'
			'Вы выпили рюмку водки'
			act 'Закусить':
				*clr & cla
				minut += 10
				health += 10
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Swamp/snack1.'+rand(1,2)+'.jpg"></center>'
				if energy >= 24:
					'Вы больше не можете есть.'
				elseif energy >= 18 and energy < 24:
					'Вы через силу затолкали в себя еду.'
				else
					'Вы с удовольствием съели приготовленную еду.'
				end
				act 'Далее':dynamic $hanterstable
			end
		end
		act 'Выпить пива':
			*clr & cla
			gs 'zz_funcs', 'alko', 2
			gs 'stat'
			'<center><img src="images/zsoft/pod_ezd/shulgahome/kuh/beer2.jpg"></center>'
			'Вы выпили пива'
			act 'Далее':dynamic $hanterstable
		end
		act 'Поболтать':
			*clr & cla
			minut += 15
			if hantersAndreiQw < 10:hantersAndreiQw += 1
			if hantersIgorQw < 10:hantersIgorQw += 1
			if hantersSergeiQw < 10:hantersSergeiQw += 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
			'Вы поболтали с ребятами с ребятами на разные темы...'
			act 'Далее':dynamic $hanterstable
		end
		act'Выйти из за стола':hantersdrink = 0 & hanter_refuse = 1 & gt $loc, $metka
		if alko > 3 and alko < 8 and smokertemp = 1:
			*clr & cla
			temp = rand(1,4)
			gs 'stat'
			if temp = 1:
				*clr & cla
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Swamp/hantersmoker1.jpg"></center>'
				'Ребята предлагают выйти на перекур.'
				act 'Согласиться':
					*clr & cla
					minut += 15
					manna += 10
					if hantersKnowSlut = 0:hantersAndreiQw += 1
					if hantersKnowSlut = 0:hantersIgorQw += 1
					if hantersKnowSlut = 0:hantersSergeiQw += 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hantersmoker2.jpg"></center>'
					'Вы вышли из избушки, ребята угостили вас сигареткой и вы покурили, продолжая прерванный разговор.'
					act 'Вернуться за стол':dynamic $hanterstable
				end
				act 'Отказаться': dynamic $hanterstable
 			end
			if temp = 2:
				*clr & cla
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
				'Андрей предлагает выйти на перекур.'
				if hantersAndreiQw < 15 and hantersKnowSlut = 0 or hantersAndreiLove = 1:
					act 'Согласиться':
						*clr & cla
						minut += 15
						manna += 10
						hantersAndreiQw += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/Swamp/hantersmoker2.jpg"></center>'
						'Вы вышли из избушки, Андрей угостил вас сигаретой и вы покурили, продолжая прерванный разговор.'
						act 'Вернуться за стол':dynamic $hanterstable
					end
				end
				if hantersAndreiQw >= 15 and hantersAndreiLove = 0 and hantersKnowSlut = 0:
					if smokbj = 0:
						act 'Согласиться':
							*clr & cla
							minut += 15
							manna += 10
							hantersAndreiQw += 1
							gs 'stat'
							'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
							'Вы вышли из избушки, Андрей угостил вас сигаретой и вы покурили, продолжая прерванный разговор. Вдруг Андрей, положив руку вам на коленку и заглянув в глаза, сказал:'
							' - <<$name[2]>>, а не могла бы ты мне помочь?'
							' - Конечно, Андрей, я даже рада буду, - ответили вы, потом уже менее уверенно добавили. - А как именно я могу помочь тебе?'
							' - Как ты знаешь <<$name[2]>>, я уже давно в разводе, - начал Андрей. - Но я же нормальный мужчина, мне нужно изредка снимать напряжение, ну ты понимаешь о чем я...'
							'Вы с изумлением посмотрели на него.'
							' - Так вот <<$name[2]>>, если бы ты мне хоть изредка помогала его снимать, я был бы тебе очень благодарен, - продолжил Андрей.'
							'Вы с недоверием смотрели на него, не шутит ли он. Но Андрей говорил вполне серьёзно.'
							' - Об этом естественно никто не узнает, не волнуйся , - быстро добавил он. - Ну так как, <<$name[2]>>, ты согласна?'
							act 'Согласиться':
								*clr & cla
								minut += 10
								horny += 10
								hanterslut += 2
								smokbj = 1
								bj += 1
								hantersAndreiQw += 1
								gs 'stat'
								'<center><img src="images/qwest/gadukino/Swamp/thinks'+rand(1,2)+'.jpg"></center>'
								'Услышав такое вы надолго задумались. Помочь другу это конечно хорошо, но вот сам способ вызывал у вас сомнения.'
								' - Хорошо Андрей, я согласна, - наконец решились вы ответить. - А каким именно способом тебе помогать и где?'
								' - Блин, <<$name[2]>>, я знал, что будешь не против, - ответил он. - Ну а на счет способа не волнуйся, поработай ротиком, мне и этого хватит.'
								' - Пошли за избушку, чтобы никто не увидел , - добавил он вставая с лавки.'
								act 'Идти':dynamic $hantersmokBJ
							end
							if alko < 6:
								act 'Отказаться':
									*clr & cla
									minut += 10
									hanterslut -= 1
									hantersAndreiQw += 1
									gs 'stat'
									'<center><img src="images/qwest/gadukino/Swamp/thinks'+rand(1,2)+'.jpg"></center>'
									'Услышав такое вы надолго задумались. Помочь другу это конечно хорошо, но вот сам способ вызывал у вас сомнения.'
									' - Нет Андрей, я не согласна, - наконец решились вы ответить. - Как ты вообще мог мне такое предложить?'
									'И встав с лавки быстро ушли назад в избушку.'
									act 'Вернуться за стол':dynamic $hanterstable
								end
							end
						end
					else
						act 'Согласиться':
							*clr & cla
							minut += 10
							horny += 5
							hanterslut += 1
							hantersAndreiQw += 1
							bj += 1
							gs 'stat'
							'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
							'Вы вышли из избушки, чтобы покурить, но Андрей сразу же сказал:'
							' - К черту перекур, <<$name[2]>>, пошли за избушку.'
							act 'Идти':dynamic $hantersmokBJ
							if alko < 6:
								act 'Отказаться':
									*clr & cla
									minut += 10
									hanterslut -= 1
									hantersAndreiQw -= 50
									gs 'stat'
									'<center><img src="images/qwest/gadukino/Swamp/thinks'+rand(1,2)+'.jpg"></center>'
									' - Знаешь Андрей, я передумала, - сказали вы набравшись смелости. - Я конечно рада помочь другу, но я не шлюха какая-нибудь, чтобы сосать по подворотням.'
									'И встав с лавки быстро убежали назад в избушку.'
									act 'Вернуться за стол':dynamic $hanterstable
								end
							end
						end
					end
				end
				if hantersKnowSlut = 1:
					act 'Согласиться':
						*clr & cla
						minut += 10
						horny += 5
						bj += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
						'Вы вышли из избушки, чтобы покурить, но Андрей сразу же сказал:'
						' - К черту перекур, <<$name[2]>>, пошли за избушку, надо напряжение снять.'
						act 'Идти':dynamic $hantersmokBJ
					end
				end
				act 'Отказаться':dynamic $hanterstable
 			end
			if temp = 3:
				*clr & cla
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
				'Сергей предлагает выйти на перекур.'
				act 'Согласиться':
					*clr & cla
					minut += 15
					manna += 10
					if hantersKnowSlut = 0:hantersSergeiQw += 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hantersmoker2.jpg"></center>'
					'Вы вышли из избушки, Сергей угостил вас сигаретой и вы покурили, продолжая прерванный разговор.'
					act 'Вернуться за стол':dynamic $hanterstable
				end
				act 'Отказаться':dynamic $hanterstable
 			end
			if temp = 4:
				*clr & cla
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
				'Игорь предлагает выйти на перекур.'
				act 'Согласиться':
					*clr & cla
					minut += 15
					manna += 10
					if hantersKnowSlut = 0:hantersIgorQw += 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/hantersmoker2.jpg"></center>'
					'Вы вышли из избушки, Игорь угостил вас сигаретой и вы покурили, продолжая прерванный разговор.'
					act 'Вернуться за стол':dynamic $hanterstable
				end
				act 'Отказаться':dynamic $hanterstable
 			end
		end
		if alko >= 8 and hantersKnowSlut = 0:
			*clr & cla
			temp = rand(1,6)
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/swamphousedrunkgirl.jpg"></center>'
			'Вы напились в стельку, мозги уже почти не соображают, да и двигаетесь уже с трудом...'
			if hanterslut <= 20:
				if temp = 1:
					act 'Вырубиться':
						*clr & cla
						minut += 1
						if hantersIgorLove <= 1:hanterslut += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/Swamp/swamphousedrunkgirl2.jpg"></center>'
						'Вы отключились и уснули прямо за столом...'
						act 'Проснуться':
							*clr & cla
							minut += 180
							son += 6
							health -= 15
							manna -= 25
							gs 'stat'
							'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel1.jpg"></center>'
							'Вы проспали часа 3, проснувшись среди ночи. Голова болела и вы смутно помнили, что вчера происходило.'
							act 'Далее': gt $loc, $metka
						end
					end
				end
				if temp = 2:
					act 'Вырубиться':
						*clr & cla
						minut += 3
						if hantersIgorLove <= 1:hanterslut += 1
						gs 'stat'
						'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep7.jpg"></center>'
						'Вы пытались дойти до кровати, но вырубились прямо на полу, так и не дойдя до нее...'
						act 'Проснуться':
							*clr & cla
							minut += 240
							son += 8
							health -= 20
							manna -= 25
							gs 'stat'
							'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel4.jpg"></center>'
							'Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
							act 'Далее': gt $loc, $metka
						end
					end
				end
				if temp = 3:
					act 'Вырубиться':
						*clr & cla
						minut += 5
						gs 'stat'
						'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep4.jpg"></center>'
						'Вы кое-как добрались до лежака и вырубились не раздеваясь...'
						act 'Проснуться':
							*clr & cla
							minut += 360
							son += 12
							health -= 10
							manna -= 25
							gs 'stat'
							'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg"></center>'
							'Вы проспали некоторое время, проснувшись растрепанная еле оторвали голову от подушки. Голова болела и вы смутно помнили, что вчера происходило.'
							act 'Далее': gt $loc, $metka
						end
					end
				end
				if temp > 3:
					act 'Выйти из-за стола':
						*clr & cla
						minut += 1
						gs 'stat'
						'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja5.jpg"></center>'
						'Пьяные ребята предложили вам порадовать их и станцевать, Андрей включил музыку и вы пьяно покачиваясь вылезли из за стола...'
						if hanterslut < 5:
							act 'Отказаться от этой затеи':
								*clr & cla
								minut += 5
								gs 'stat'
								'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep11.jpg"></center>'
								'Но встав на ноги, вы поняли, что вы не то что танцевать, вам до кровати дойти сложно будет. Поэтому махнув разочарованым ребятам рукой вы отправились спать.'
								act 'Проснуться':
									*clr & cla
									minut += 480
									son += 16
									health -= 5
									manna -= 25
									gs 'stat'
									'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg"></center>'
									'Вы проспали некоторое время, проснувшись растрепанная еле встали с кровати. Голова болела и вы смутно помнили, что вчера происходило.'
									act 'Далее': gt $loc, $metka
								end
							end
						end
						if hanterslut >= 5:
							act 'Танцевать':
								*clr & cla
								minut += 10
								horny += rand(5,10)
								gs 'stat'
								'<center><img src="images/qwest/gadukino/Swamp/dance1.'+rand(1,2)+'.jpg"></center>'
								'Выбравшись из-за стола вы принялись изображать ритмичный танец, под дружные аплодисменты ребят.'
								if hanterslut >= 10:
									act 'Танцевать дальше':
										*clr & cla
										minut += 10
										horny += rand(5,10)
										hanterslut += 1
										if hantersIgorLove > 0:hantersIgorQw -= 1
										if hantersSergeiLove > 0:hantersSergeiQw -= 1
										if hantersSergeiLove > 0:hantersSergeiQw -= 1
										gs 'stat'
										'<center><img src="images/qwest/gadukino/Swamp/dance2.'+rand(1,2)+'.jpg"></center>'
										'В порыве танца, под одобрительные аплодисменты парней, вы срываете верхнюю часть одежды, оставшись только в бюстгалтере...'
										if hanterslut >= 15:
											act 'Танцевать дальше':
												*clr & cla
												minut += 10
												horny += rand(5,10)
												hanterslut += 1
												if hantersIgorLove > 0:hantersIgorQw -= 1
												if hantersSergeiLove > 0:hantersSergeiQw -= 1
												if hantersSergeiLove > 0:hantersSergeiQw -= 1
												gs 'stat'
												'<center><img src="images/qwest/gadukino/Swamp/dance3.jpg"></center>'
												'Под одобрительные крики парней вы раздеваетесь дальше, оставшись только в нижнем белье...'
												act 'Вырубиться':
													*clr & cla
													minut += 1
													gs 'stat'
													'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep10.jpg"></center>'
													'Вы явно переоценили свои силы и возможности организма. Поэтому немного потанцевав, неожиданно для парней, вырубились прямо на полу, там где танцевали....'
													act 'Проснуться':
														*clr & cla
														minut += 240
														son += 8
														health -= 5
														manna -= 25
														gs 'stat'
														'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel4.jpg"></center>'
														'Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
														act 'Далее': gt $loc, $metka
													end
												end
											end
										else
											act 'Вырубиться':
												*clr & cla
												minut += 5
												gs 'stat'
												'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep11.jpg"></center>'
												'Но немного потанцевав, вы поняли что ноги вас уже не держат, поэтому махнув разочарованым ребятам рукой вы отправились спать.'
												act 'Проснуться':
													*clr & cla
													minut += 360
													son += 12
													health -= 15
													manna -= 25
													gs 'stat'
													'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg"></center>'
													'Вы проспали некоторое время, проснувшись растрепанная еле встали с кровати. Голова болела и вы смутно помнили, что вчера происходило.'
													act 'Далее': gt $loc, $metka
												end
											end
										end
									end
								else
									act 'Вырубиться':
										*clr & cla
										minut += 5
										gs 'stat'
										'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep11.jpg"></center>'
										'Но немного потанцевав, вы поняли что ноги вас уже не держат, поэтому махнув разочарованым ребятам рукой вы отправились спать.'
										act 'Проснуться':
											*clr & cla
											minut += 360
											son += 12
											health -= 15
											manna -= 25
											gs 'stat'
											'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg"></center>'
											'Вы проспали некоторое время, проснувшись растрепанная еле встали с кровати. Голова болела и вы смутно помнили, что вчера происходило.'
											act 'Далее': gt $loc, $metka
										end
									end
								end
							end
						end
					end
				end
			end
			if hanterslut > 20:
				act 'Выйти из-за стола':
					*clr & cla
					minut += 1
					gs 'stat'
					'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja5.jpg"></center>'
					'Пьяные ребята предложили вам порадовать их и станцевать, Андрей включил музыку и вы пьяно покачиваясь вылезли из за стола...'
					act 'Танцевать':
						*clr & cla
						minut += 10
						horny += rand(5,10)
						gs 'stat'
						'<center><img src="images/qwest/gadukino/Swamp/dance1.'+rand(1,2)+'.jpg"></center>'
						'Выбравшись из-за стола вы принялись изображать ритмичный танец, под дружные аплодисменты ребят.'
						act 'Танцевать дальше':
							*clr & cla
							minut += 10
							horny += rand(5,10)
							hanterslut += 1
							if hantersIgorLove > 0:hantersIgorQw -= 1
							if hantersSergeiLove > 0:hantersSergeiQw -= 1
							if hantersSergeiLove > 0:hantersSergeiQw -= 1
							gs 'stat'
							'<center><img src="images/qwest/gadukino/Swamp/dance2.'+rand(1,2)+'.jpg"></center>'
							'В порыве танца, под одобрительные крики парней, вы срываете верхнюю часть одежды, оставшись только в бюстгалтере...'
							act 'Танцевать дальше':
								*clr & cla
								minut += 10
								horny += rand(5,10)
								hanterslut += 1
								if hantersIgorLove > 0:hantersIgorQw -= 1
								if hantersSergeiLove > 0:hantersSergeiQw -= 1
								if hantersSergeiLove > 0:hantersSergeiQw -= 1
								gs 'stat'
								'<center><img src="images/qwest/gadukino/Swamp/dance3.jpg"></center>'
								'Под одобрительные возгласы парней вы раздеваетесь дальше, оставшись только в нижнем белье...'
								act 'Танцевать дальше':
									*clr & cla
									minut += 10
									horny += rand(5,10)
									temp = rand(1,2)
									hanterslut += 1
									if hantersIgorLove > 0:hantersIgorQw -= 1
									if hantersSergeiLove > 0:hantersSergeiQw -= 1
									if hantersSergeiLove > 0:hantersSergeiQw -= 1
									gs 'stat'
									'<center><img src="images/qwest/gadukino/Swamp/dance4.jpg"></center>'
									'Танцуя вы раздеваетесь дальше, лифчик летит в сторону и под одобрительные крики парней вы трясете перед ними своими грудями <<body[''tits'']>> размера.'
									if temp = 1:
										act 'Вырубиться':
											*clr & cla
											minut += 1
											gs 'stat'
											'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep17.jpg"></center>'
											'Вы явно переоценили свои силы и возможности организма. Поэтому немного потанцевав, неожиданно для парней, вырубились прямо на полу, там где танцевали....'
											act 'Проснуться':
												*clr & cla
												minut += 240
												son += 8
												health -= 20
												manna -= 25
												gs 'stat'
												'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel3.jpg"></center>'
												'Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
												act 'Далее': gt $loc, $metka
											end
										end
									else
										act 'Танцевать дальше':
											*clr & cla
											minut += 10
											horny += rand(5,10)
											hantdancesex = 1
											gs 'stat'
											'<center><img src="images/qwest/gadukino/Swamp/dance5.jpg"></center>'
											'Танцуя вы раздеваетесь дальше и остаетесь в чем мать родила. Судя по возбужденным лицам парней их это очень заводит.'
											act 'Далее': gt 'hantersex'
										end
									end
								end
							end
						end
					end
				end
			end
		end
		if alko >= 8 and hantersKnowSlut > 0:
			*clr & cla
			temp = rand(1,6)
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/swamphousedrunkgirl1.jpg"></center>'
			'Вы напились в стельку, мозги уже почти не соображают, да и двигаетесь уже с трудом...'
			if temp = 1:
				act 'Вырубиться':
					*clr & cla
					minut += 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/Swamp/swamphousedrunkgirl2.jpg"></center>'
					'Вы отключились и уснули прямо за столом...'
					act 'Проснуться':
						*clr & cla
						minut += 180
						son += 6
						health -= 15
						manna -= 25
						gs 'stat'
						'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel1.jpg"></center>'
						'Вы проспали часа 3, проснувшись среди ночи. Голова болела и вы смутно помнили, что вчера происходило.'
						act 'Далее': gt $loc, $metka
					end
				end
			end
			if temp = 2:
				act 'Вырубиться':
					*clr & cla
					minut += 3
					gs 'stat'
					'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep7.jpg"></center>'
					'Вы пытались дойти до кровати, но вырубились прямо на полу, так и не дойдя до нее...'
					act 'Проснуться':
						*clr & cla
						minut += 240
						son += 8
						health -= 20
						manna -= 25
						gs 'stat'
						'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel4.jpg"></center>'
						'Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
						act 'Далее': gt $loc, $metka
					end
				end
			end
			if temp = 3:
				act 'Вырубиться':
					*clr & cla
					minut += 5
					gs 'stat'
					'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep4.jpg"></center>'
					'Вы кое-как добрались до лежака и вырубились не раздеваясь...'
					act 'Проснуться':
						*clr & cla
						minut += 360
						son += 12
						health -= 10
						manna -= 25
						gs 'stat'
						'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg"></center>'
						'Вы проспали некоторое время, проснувшись растрепанная еле оторвали голову от подушки. Голова болела и вы смутно помнили, что вчера происходило.'
						act 'Далее': gt $loc, $metka
					end
				end
			end
			if temp > 3:
				act 'Выйти из-за стола':
					*clr & cla
					minut += 1
					gs 'stat'
					'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja5.jpg"></center>'
					'Пьяные ребята предложили вам порадовать их и станцевать, Андрей включил музыку и вы пьяно покачиваясь вылезли из за стола...'
					act 'Танцевать':
						*clr & cla
						minut += 10
						horny += rand(5,10)
						gs 'stat'
						'<center><img src="images/qwest/gadukino/Swamp/dance1.'+rand(1,2)+'.jpg"></center>'
						'Выбравшись из-за стола вы принялись изображать ритмичный танец, под дружные аплодисменты ребят.'
						act 'Танцевать дальше':
							*clr & cla
							minut += 10
							horny += rand(5,10)
							gs 'stat'
							'<center><img src="images/qwest/gadukino/Swamp/dance2.'+rand(1,2)+'.jpg"></center>'
							'В порыве танца, под одобрительные крики парней, вы срываете верхнюю часть одежды, оставшись только в бюстгалтере...'
							act 'Танцевать дальше':
								*clr & cla
								minut += 10
								horny += rand(5,10)
								gs 'stat'
								'<center><img src="images/qwest/gadukino/Swamp/dance3.jpg"></center>'
								'Под одобрительные возгласы парней вы раздеваетесь дальше, оставшись только в нижнем белье...'
								act 'Танцевать дальше':
									*clr & cla
									minut += 10
									horny += rand(5,10)
									temp = rand(1,2)
									gs 'stat'
									'<center><img src="images/qwest/gadukino/Swamp/dance4.jpg"></center>'
									'Танцуя вы раздеваетесь дальше, лифчик летит в сторону и под одобрительные крики парней вы трясете перед ними своими грудями <<body[''tits'']>> размера.'
									if temp = 1:
										act 'Вырубиться':
											*clr & cla
											minut += 1
											gs 'stat'
											'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep17.jpg"></center>'
											'Вы явно переоценили свои силы и возможности организма. Поэтому немного потанцевав, неожиданно для парней, вырубились прямо на полу, там где танцевали....'
											act 'Проснуться':
												*clr & cla
												minut += 240
												son += 8
												health -= 20
												manna -= 25
												gs 'stat'
												'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel3.jpg"></center>'
												'Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
												act 'Далее': gt $loc, $metka
											end
										end
									else
										act 'Танцевать дальше':
											*clr & cla
											minut += 10
											horny += rand(5,10)
											hantdancesex = 3
											gs 'stat'
											'<center><img src="images/qwest/gadukino/Swamp/dance5.jpg"></center>'
											'Танцуя вы раздеваетесь дальше и остаетесь в чем мать родила. Судя по возбужденным лицам парней их это очень заводит.'
											act 'Далее': gt 'hantersex'
										end
									end
								end
							end
						end
					end
				end
			end
		end
	else
		act 'Есть':
			*clr & cla
			gs 'zz_kitchen_acts','eat'
			gs 'zz_kitchen_acts','drink','tea'
			gs 'stat'
			act 'Далее':gt $loc, $metka
	 	end
		act 'Поболтать':
			*clr & cla
			minut += 60
			if hantersAndreiQw < 10:hantersAndreiQw += 1
			if hantersIgorQw < 10:hantersIgorQw += 1
			if hantersSergeiQw < 10:hantersSergeiQw += 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
			'Вы поболтали с ребятами с ребятами на разные темы...'
			act 'Выйти из за стола':gt $loc, $metka
		end
		act'Выйти из за стола':hanter_refuse = 1 & gt $loc, $metka
	end
	if hantersKnowSlut > 0 and hanterstableBJ = 0:
		if hantersdrink = 0:
			*clr & cla
			minut += 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
			'Вы хотели присесть за стол и поесть с ребятами, но не тут-то было...'
			'- Не так быстро <<$name[2]>>, - шутливо сказал Андрей. - Ты же понимаешь, что сыр бесплатный , только в мышеловке бывает.'
			'- Хочешь кушать, заработай, - добавил он усмехнувшись и указал под стол.'
			act 'Лезть под стол':dom -= 1 & dynamic $hanterstableBJ
			act 'Отказаться':gt $loc, $metka
		else
			*clr & cla
			minut += 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
			'Увидев вас, ребята расплылись в улыбках...'
			'- О! Наша <<$name[2]>> пришла, - шутливо сказал Андрей. - Нам только тебя и не хватало, садись за стол.'
			act 'Сесть за стол':hanterstableBJ = 1 & dynamic $hanterstable
		end
	end
	if cumpussy > 0 and current_clothing = 0 or cumbelly > 0 and current_clothing = 0 or cumass > 0 and current_clothing = 0 or cumanus > 0 and current_clothing = 0 or cumface > 0:
		*clr & cla
		minut += 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterstable.jpg"></center>'
		'Вы хотели присесть за стол и поесть с ребятами, но не тут-то было...'
		'- Фу, блин, <<$name[2]>>, - сказал Андрей. - Ты бы хоть наши художества с лица смыла, прежде чем застол садиться.'
		act 'Уйти':gt $loc, $metka
	end
}
$hantersrelax = {
	cla
	*clr
	minut += 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hantersrelax1.'+rand(1,8)+'.jpg"></center>'
	'В избушке вы видите Сергея, Андрея и Игоря. Они заняты каждый своим делом.'
	act'Поговорить с Андреем':gt'AndreiHanter'
	act'Поговорить с Сергеем':gt'SergeiHanter'
	act'Поговорить с Игорем':gt'IgorHanter'
	act'Уйти':gt $loc, $metka
}
$hantersmokBJ = {
	*clr & cla
	$boy = 'Андрей'
	dick = 20
	minut += 5
	horny += 5
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	temp = rand(1,2)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hantersmokBJ1.'+rand(1,3)+'.jpg"></center>'
	if hantersmokBJ = 0:'Вы устроились поудобнее на коленях и приблизили свое лицо к его члену...'
	if hantersmokBJ = 1:'Андрей все не кончал, поэтому вы продолжили сосать...'
	gs 'zz_dynamic_sex', 'bj'
	if temp = 1:act 'Сосать дальше':hantersmokBJ = 1 & dynamic $hantersmokBJ
	if temp = 2:
		act 'Сосать дальше':
			*clr & cla
			minut += 1
			vaf += 1
			hantersmokBJ = 0
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hantersmokCUM.jpg"></center>'
			gs 'zz_dynamic_sex', 'swallow'
			'- Круто, блин, <<$name[2]>>, - сказал довольный Андрей. - Ты прямо мастерица.'
			'Приведя себя в порядок вы отправились с Андреем обратно в избушку'
			act 'Вернуться за стол':dynamic $hanterstable
		end
	end
}
$dirty_swamphouse = {
	cla
	*clr
	if dirty_swamphouse > 10:minut += 60 & sweat += 1
	if dirty_swamphouse >= 10 and dirty_swamphouse < 20:minut += 120 & sweat += 2
	if dirty_swamphouse >= 20:minut += 180 & sweat += 3
	if hantersAndreiQw < 15:hantersAndreiQw += 1
	if hantersIgorQw < 15:hantersIgorQw += 1
	if hantersSergeiQw < 15:hantersSergeiQw += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/dirty_swamphouse.jpg"></center>'
	'Зайдя в очередной раз в избушку, вы заметили, сколько там накопилось разного мусора и грязи. " - С этим нужно что-то делать", - подумали вы, и найдя веник и тряпку принялись за уборку. Через некоторое врямя избушка сияла чистотой и порядком.'
	act 'Далее':dirty_swamphouse = 0 & gt'swamphouse'
}
$dress_after_shower = {
gs 'zz_clothing', 'redress', prev_clothing
clothesswamphouse = 0
swamp_clothes = 0
tanga = flag_tanga
prev_clothing = -1
gt $loc, $metka
}