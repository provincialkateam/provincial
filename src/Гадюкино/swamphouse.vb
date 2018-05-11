$metka = $ARGS[0]
$loc = $CURLOC
frost = 0
gs 'stat'
gs 'zz_funcs', 'colorize_day'
hantslutsexrand = rand(1,3)
temp = rand(1,5)
gs 'zz_render','','qwest/gadukino/Swamp/swampizba.jpg','Охотничья избушка. В маленькой комнате с низким потолком есть <a href="exec:GT ''bed'',''start''">топчан</a> на котором вы можете поспать.'
if bucket > 0:'В углу стоит <a href="exec: dynamic $bucket ">ведро</a> с водой.'
if bucket = 0:'В углу стоит пустое ведро.'
gs 'zz_render','','','Возле него висит старый <a href="exec: dynamic $washstand ">умывальник</a> и небольшое <a href="exec:GT ''mirror'',''start''">зеркало</a>, а под ними стоит <a href="exec: dynamic $basin">тазик</a>.'
gs 'zz_render','','','В другом углу стоит небольшая <a href="exec: dynamic $stove">печка</a>. На ней при наличии воды и грибов можно сварить нехитрую еду. Еще можно нагреть воды, чтобы помыться в тазике.'
gs 'zz_render','','','Возле неё лежит стопка потрепаных <a href="exec: dynamic $stackmagazines">журналов</a>, скорее всего для розжига.'
if clothesswamphouse = 1 and clearclothes = 0:'На полке лежит ваша <a href="exec: dynamic $dress_after_shower">одежда</a>.'
if clearclothes > 0 and clearclothesH = 1: 'Над печкой сушится ваша одежда.'
if hour = 20 and hanters = 1 and hantersKnow > 0 or hour = 7 and hanters = 1 and hantersKnow > 0:'За столом сидят <a href="exec:dynamic $hanterstable">охотники</a>.'
if hour > 20 and hour < 23 and hanters = 1 and hantersKnow > 0:'В избушке вы видите <a href="exec:dynamic $hantersrelax">охотников</a>.'
if hour = 23 and hanters = 1 and hantersKnow > 0 or hour >= 0 and hour < 7 and hanters = 1 and hantersKnow > 0:'На топчанах спят охотники.'
if edahot > 0:
	act 'Есть':
		*clr & cla
		gs 'zz_kitchen_acts','eat','','qwest/gadukino/Swamp/soup.jpg'
		act 'Встать из за стола':gt $loc, $metka
	end
end
if bilberry > 0:
	act 'Поесть ягод':
		*clr & cla
		minut += 30
		energy += 5
		water += 10
		bilberry -= 1
		health += 5
		manna += 10
		gs 'stat'
		gs 'zz_render','','qwest/gadukino/forest/bilberry.jpg','Вы поели ягод.'
		act 'Далее':gt $loc, $metka
	end
end
if cloth[0] > 0 and clothesswamphouse = 0 or swamp_cloth = 1:
	act'Снять одежду':
		if hantersKnowSlut > 0 or hanters = 0 or hanters = 1 and hour >= 8 and hour < 20 and hantersKnowSlut = 0:
			cla
			*clr
			clothesswamphouse = 1
			minut += 5
			gs 'zz_clothing2','redress',0
			gs 'zz_render','','qwest/gadukino/Swamp/swamphouseundress.jpg','Вы не стеснясь разделись, оставшись в чем мать родила.'
			act'Назад':gt'swamphouse'
		else
			cla
			*clr
			gs 'zz_render','','qwest/gadukino/Swamp/noundress.jpg','Несмотря на жару вы все таки стесняетесь раздеться, а вдруг кто-нибудь увидит?'
			act'Назад':gt'swamphouse'
		end
	end
end
if horny >= 50 and hanters = 0 or horny >= 50 and hanters = 1 and hour >= 8 and hour < 20:
	act 'Мастурбировать': gt 'selfplay'
end
if cloth[0] = 0 and swamp_cloth = 0:
	act 'Искать одежду':
		*clr & cla
		minut += 10
		swamp_clothes = 1
		gs 'zz_clothing2','redress',1
		gs 'zz_render','','qwest/gadukino/Swamp/swamphouse_tkancloth.jpg','Вы нашли кусок мешковины... Ну хоть что-то.'
		act 'Назад.':gt'swamphouse'
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
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanterlove1.4.jpg','Зайдя в избушку вы увидели Игоря. Он с улыбкой подошел к вам и впился в ваши губы страстным поцелуем.'
	gs 'zz_render','','','- Света, я хочу тебя, - прошептал он, прервав поцелуй.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersIgorQw += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanterflirt2.'+rand(4,6)+'.jpg','Улыбнувшись вы подмигиваете Игорю. Он, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersIgorQw -= 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg',' - Нет, Игорь, давай не сейчас, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
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
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanterlove1.4.jpg','Зайдя в избушку вы увидели Сергея. Он с улыбкой подошел и впился в ваши губы долгим поцелуем.'
	gs 'zz_render','','','- Света, я хочу тебя, - сказал он, прервав поцелуй.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersSergeiQw += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanterflirt2.'+rand(4,6)+'.jpg','Улыбнувшись вы подмигиваете Сергею. Он, все прекрасно понимая, берет вас за руку и ведет за собой.'
		act 'Идти':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersSergeiQw -= 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg',' - Нет, сергей, давай не сейчас, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
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
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanterlove1.4.jpg'
	gs 'zz_render','','','Зайдя в избушку вы увидели Андрея. Неожиданно он впился в ваши губы страстным поцелуем и ни слова не говоря потянул вас за собой.'
	act 'Идти с Андреем':
		*clr & cla
		minut += 5
		hantersAndreiQw += 1
		horny += 5
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanterhands.jpg'
		gs 'zz_render','','','Вы идете с Андреем держась за руки, прекрасно понимая, куда и зачем он вас ведет. И вы совсем даже не против.'
		act 'Далее':gt'HanterLoveSex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersAndreiQw -= 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg'
		gs 'zz_render','','',' - Нет, <<$boy>>, давай не сейчас, - сказали вы, и стараясь не смотреть на него ушли.'
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
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanterswork1.2.jpg'
	gs 'zz_render','','','В избушке вы увидели Андрея с Сергеем.'
	gs 'zz_render','','',' - Пора, так сказать, исполнять супружеский долг, - сказал Андрей шутливым тоном. - Готовь Светик попу.'
	gs 'zz_render','','',' - Из избушки только уйти нужно, и в кусты поглубже спрятаться, - добавил Сергей. - А то Игорь у нас сильно правильный, не поймет.'
	act 'Идти с парнями':
		*clr & cla
		minut += 5
		hantersAndreiQw += 1
		hantersSergeiQw += 1
		horny += 5
		doublelovesex = 1
		hanterslut += 1
		temphant = 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/doublehanterlove.jpg'
		gs 'zz_render','','','Вы идете с парнями держась за руки, прекрасно понимая, куда и зачем они вас ведут. И вы совсем даже не против.'
		act 'Далее':gt'hantersex'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersAndreiQw -= 1
		hantersSergeiQw -= 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg'
		gs 'zz_render','','',' - Нет, ребята, что-то я не хочу, - сказали вы, и не глядя на них ушли.'
		act 'Идти':gt $loc, $metka
	end
end
!охотники приглашают за стол
if hour = 20 and hanters = 1 and hantersKnow > 0 and hantersKnowSlut = 0 and hanter_refuse = 0:
	*clr & cla
	gs 'stat'
	if hour >= 20 and hour <= 23 = 1:
		*clr & cla
		minut += 1
		temp = rand(1,4)
		gs 'stat'
		if temp = 1:
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
			gs 'zz_render','','','Вы зашли в избушку и увидели выпивающих охотников.'
			gs 'zz_render','','','- О, Света, давай к нам!- начали на перебой приглашать они.'
		end
		if temp = 2:
			hantersAndreiQw += 1
			gs 'zz_render','','images/qwest/gadukino/Swamp/AndreiHanter.jpg'
			gs 'zz_render','','','Вы зашли в избушку и увидели выпивающих охотников.'
			gs 'zz_render','','','- О, Света, давай к нам!- заметив вас предложил Андрей.'
		end
		if temp = 3:
			hantersSergeiQw += 1
			gs 'zz_render','','images/qwest/gadukino/Swamp/SergeiHanter.jpg'
			gs 'zz_render','','','Вы зашли в избушку и увидели выпивающих охотников.'
			gs 'zz_render','','','- О, Света, давай к нам!- заметив вас позвал Сергей.'
		end
		if temp = 4:
			hantersIgorQw += 1
			gs 'zz_render','','images/qwest/gadukino/Swamp/IgorHanter.jpg'
			gs 'zz_render','','','Вы зашли в избушку и увидели выпивающих охотников.'
			gs 'zz_render','','','- О, Света, давай к нам!- перекрикивая разговор позвал Игорь.'
		end
	else
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
		gs 'zz_render','','','Вы зашли в избушку и увидели завтракающих охотников.'
		gs 'zz_render','','','- О, Света, ты вовремя, присоеденяйся!- начали на перебой приглашать они.'
	end
	act 'Присоединиться':dynamic $hanterstable
	act 'Вежливо отказаться':hanter_refuse = 1 & gt $loc, $metka
end
!если ГГ голая и охотники в избушке
if cloth[0] = 0 and hanters = 1 and hour >= 20 and hour < 23 and hanterknowday ! day or cloth[0] = 0 and hanters = 1 and hour = 7 and hanterknowday ! day:
	*clr & cla
	temp =rand(1,3)
	gs 'stat'
	if hantersKnowSlut = 0:
		*clr & cla
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousenude.jpg'
		gs 'zz_render','','','Увидев в избушке мужчин вы ойкнув, принялись прикрываться руками...'
		if clothesswamphouse = 1 and clearclothes = 0:
			act'Одеться':
				*clr & cla
				clothesswamphouse = 0
				minut += 5
				gs 'zz_clothing2','redress',cloth[3]
				gs 'zz_render','','images/qwest/gadukino/Swamp/swampdvornude1.jpg'
				gs 'zz_render','','','И, сломя голову, кинулись в избушку одеваться.'
				act'Далее':gt'swamphouse'
			end
		else
			act'Одеться':
				*clr & cla
				minut+=5
				swamp_clothes = 1
				gs 'zz_clothing2','redress',1
				gs 'zz_render','','images/qwest/gadukino/Swamp/tkan_cloth.jpg'
				gs 'zz_render','','','И быстро кинулись в избушку и прикрылись куском мешковины... Ну хоть что-то.'
				act'Далее':gt'swamphouse'
			end
		end
		act'Остаться голышом':
			*clr & cla
			hanterslut += 1
			hanterknowday = day
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousenude1.jpg'
			gs 'zz_render','','','Но потом решили пощекотать себе нервы и оставили все как есть. Мужчины старательно отводят глаза от вашего обнаженного тела.'
			gs 'zz_render','','','- Ну ты, Светик, блин даешь, - услышали вы только фразу Андрея.'
			act'Далее':gt'swamphouse'
		end
	end
	if hantersKnowSlut > 0:
		if hantslutsex = 0:
			*clr & cla
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousenude1.jpg'
			gs 'zz_render','','','Увидев вас голую, парни возбудились...'
			gs 'zz_render','','','- Светик, подойди-ка к нам, - позвал вас один из парней.'
			act'Далее':hantersexnude = 1 & gt'hantersex'
		else
			hanterknowday = day
			gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousenude1.jpg'
			gs 'zz_render','','','Увидев вас голую, парни только покачали головами...'
			gs 'zz_render','','','- Смотри Светик, допрыгаешься у нас, если будешь прелестями тут светить, - шутливо сказал кто-то из парней.'
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
	if temphant = 1:'Вы занимались своими делами, когда в избушку ввалился Андрей. " - Пошли Светик," - сказал он и больше ни слова не говоря потянул вас за собой на топчан.'
	if temphant = 2:'Вы занимались своими делами, когда в избушку вошел Сергея. Заметив вас он направился в вашу сторону. " - Пошли отойдем Светик, что-то приспичило," - сказал он и потянул вас за собой на топчан.'
	if temphant = 3:'Вы занимались своими делами, когда заметили вошедшего в избушку Игоря. Увидев вас он улыбнуся и подошел. " - Светик, мне нужно напряжение скинуть, давай отойдем," - сказал он улыбаясь и повел вас за собой.'
	if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнем, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнем, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
	act 'Идти':	gt'hantersex'
end
$bucket = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/vedro2.jpg'
	gs 'zz_render','','','Ведро с водой. В нем еще <<bucket>> литров воды.'
	act'Попить воды':
		cla
		minut+=5
		cumlip = 0
		bucket -= 1
		if water >= 20:
			gs 'zz_render','','','Вода в вас больше не лезет.'
		else
			water += 20
			gs 'zz_render','','','Вы с удовольствием выпили стакан воды.'
		end
		act 'Далее':gt $loc, $metka
	end
	act'Отойти':gt $loc, $metka
}
$washstand = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/washstand.jpg'
	gs 'zz_render','','','Старый умывальник. При наличии воды можно умыться.'
	if bucket > 0:
		act 'Умыться':
			*clr & cla
			minut += 5
			mop = 1
			cumlip = 0
			cumface = 0
			sweat -= 1
			bucket -= 1
			gs 'stat'
			gs 'zz_render','','images/pic/facesp.jpg'
			gs 'zz_render','','','Вы тщательно умыли лицо и смыли косметику.'
			act 'Далее':dynamic $washstand
		end
		if cumfrot > 0:
			act 'Оттирать сперму с одежды':
				cla
				cumfrot = 0
				minut += 15
				bucket -= 1
				gs 'stat'
				gs 'zz_render','','images/pic/frotsp.jpg'
				gs 'zz_render','','','Вы замыли пятна спермы на своей одежде.'
				act 'Закончить':dynamic $washstand
			end
		end
	end
	act'Отойти':gt $loc, $metka
}
$stove = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/stove.jpg'
	gs 'zz_render','','','Неказистая печка-буржуйка, однако свои со своими функциями успешно справляется. При наличии 5 литров воды можно её нагреть для стирки или мытья. Или при наличии грибов приготовить еду. '
	if bucket > 0 and boletus > 0 and edahot = 0:
		act 'Приготовить грибной суп':
			*clr & cla
			boletus -= 1
			minut += 30
			bucket -= 1
			edahot += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hotsoup.jpg'
			gs 'zz_render','','','Вы приготовили простенький грибной суп.'
			act 'Далее':gt $loc, $metka
		end
	end
	if bucket >= 5 and hotwater = 0:
		act 'Греть воду':
			*clr & cla
			minut += 30
			bucket -= 5
			hotwater = 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hotwater.jpg'
			gs 'zz_render','','','Вы нагрели воду, теперь можно помыться в тазике или постирать вещи.'
			act 'Далее':gt $loc, $metka
		end
	end
	act'Отойти':gt $loc, $metka
}
$clothes_read_magazines = {
	if cloth[0] > 0:'<center><img src="images/qwest/gadukino/Swamp/readmagazines.jpg"></center>'
	if cloth[0] = 0 and cloth[1] = 1:'<center><img src="images/qwest/gadukino/Swamp/readmagazines_tanga.jpg"></center>'
	if cloth[0] = 0 and cloth[1] = 0:'<center><img src="images/qwest/gadukino/Swamp/readmagazines_nude.jpg"></center>'
}
$stackmagazines = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'qwest/gadukino/Swamp/stackmagazines.jpg','Стопка самых разнообразных журналов, есть даже один с "интересными" картинками.'
	act 'Читать научный журнал':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
			exit
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
			exit
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
			exit
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
			exit
		end
		blizoruk += 1
		manna = 100
		minut += 60
		horny += 50
		gs 'stat'
		gs 'zz_render', '', 'qwest/gadukino/Swamp/readpornomag'+iif(cloth[0] > 0,'',iif(cloth[1] = 0,'_nude','_tanga'))+'.jpg', 'Вы листаете порно журнал читая истории и разглядывая картинки, потихоньку возбуждение начинает охватывать вас.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Далее':dynamic $stackmagazines
	end
	act'Отойти':gt $loc, $metka
}
$basin = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/basin.jpg'
	gs 'zz_render','','','Старый таз. При наличии горячей воды можно помыться или постирать одежду.'
	if hotwater = 1 and cloth[0] < 3:
		act 'Помыться':
			*clr & cla
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
			gs 'zz_render','','images/qwest/gadukino/Swamp/basinswim.jpg'
			gs 'zz_render','','','Вы вымылись дочиста и почувствоали себя гораздо лучше.'
			act 'Далее':gt $loc, $metka
		end
	end
	if hotwater = 1 and dirtyclothes = 1 and cloth[0] < 3:
		act 'Стирать одежду':
			*clr & cla
			minut += 60
			dirtyclothes = 0
			hotwater = 0
			cumfrot = 0
			gs 'stat'
			if cloth[0] = 0:
				gs 'zz_render','','images/qwest/gadukino/Swamp/basinwash.jpg'
			else
				gs 'zz_render','','images/qwest/gadukino/new/Washclothes1.jpg'
			end
			gs 'zz_render','','','Вы разделись и постирали свою грязную одежду.'
			act 'Развесить одежду в избушке':
				*clr & cla
				minut += 5
				clearclothes = 5
				clearclothesH = 1
				if cloth[0] = 0:
					gs 'zz_render','','images/qwest/gadukino/Swamp/basinwash1.jpg'
				else
					gs 'zz_render','','images/qwest/gadukino/new/Washclothes2.jpg'
				end
				gs 'zz_render','','','Вы развесили одежду сушиться внутри избушки.'
				act 'Далее':gt $loc, $metka
			end
			if month >= 5 and month <= 9:
				act 'Развесить на поляне':
					*clr & cla
					minut += 10
					clearclothes = 3
					clearclothesH = 0
					if cloth[0] = 0:
						gs 'zz_render','','images/qwest/gadukino/Swamp/basinwash2.jpg'
					else
						gs 'zz_render','','images/qwest/gadukino/new/Washclothes2.jpg'
					end
					gs 'zz_render','','','Вы развесили одежду сушиться на улице.'
					act 'Далее':gt'swamp_yard'
				end
			end
		end
	end
	act'Отойти':gt $loc, $metka
}
$hanterstableBJ = {
	*clr & cla
	minut += 1
	hanterstableBJ = 1
	dom -= 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable2.jpg'
	gs 'zz_render','','',' - Вот же гады, поесть спокойно и то не дадут, - подумали вы и полезли под стол...'
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
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg'
			gs 'zz_render','','','Вы устроились поудобнее под столом и приблизили свое лицо к его члену....'
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_render','','','Вскоре член Андрея напрягся и вы поняли что он сейчас кончит...'
			if temp = 1:
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					gs 'zz_funcs', 'cum', 'face'
					if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
					if cloth[0] > 0:cumfrot += rand(0,1)
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableCum1.'+rand(1,5)+'.jpg'
					gs 'zz_render','','','Андрей вынул член из вашего рта и тут же вам в лицо ударила струя горячей спермы, потом еще и еще пока наконец он не прекратил кончать.'
					act 'Далее':dynamic $hanterstableBJ
				end
			else
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					swallow += 1
					hanterstableBJA = 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg'
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
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg'
			gs 'zz_render','','','Вы устроились поудобнее под столом и приблизили свое лицо к его члену....'
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_render','','','Вскоре член Сергея напрягся и вы поняли что он сейчас кончит...'
			if temp = 1:
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					gs 'zz_funcs', 'cum', 'face'
					if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
					if cloth[0] > 0:cumfrot += rand(0,1)
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableCum1.'+rand(1,5)+'.jpg'
					gs 'zz_render','','','Сергей вынул член из вашего рта и тут же вам в лицо ударила струя горячей спермы, потом еще и еще пока наконец он не прекратил кончать.'
					act 'Далее':dynamic $hanterstableBJ
				end
			else
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					swallow += 1
					hanterstableBJS = 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg'
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
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg'
			gs 'zz_render','','','Вы устроились поудобнее под столом и приблизили свое лицо к его члену....'
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_render','','','Вскоре член Игорь напрягся и вы поняли что он сейчас кончит...'
			if temp = 1:
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					gs 'zz_funcs', 'cum', 'face'
					if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
					if cloth[0] > 0:cumfrot += rand(0,1)
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableCum1.'+rand(1,5)+'.jpg'
					gs 'zz_render','','','Игорь вынул член из вашего рта и тут же вам в лицо ударила струя горячей спермы, потом еще и еще пока наконец он не прекратил кончать.'
					act 'Далее':dynamic $hanterstableBJ
				end
			else
				act 'Сосать дальше':
					*clr & cla
					minut += 1
					swallow += 1
					hanterstableBJI = 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstableBJ1.'+rand(1,5)+'.jpg'
					gs 'zz_dynamic_sex', 'swallow'
					act 'Далее':dynamic $hanterstableBJ
				end
			end
		end
	end
	if hanterstableBJA = 1 and hanterstableBJS = 1 and hanterstableBJI = 1:act'Вылезти из под стола':edahot = 1 & dynamic $hanterstable
}
$hanterstable = {
	*clr & cla
	if hour >= 20 and hour <= 23 :
		hantersdrink = 1
	else
		hantersdrink = 0
	end
	minut += 1
	smokertemp = rand(1,3)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
	if hantersdrink = 1:
		dirty_swamphouse += rand(1,3)
		gs 'zz_render','','','На самодельном столе стоят бутылки с водкой и пивом, разложена закусь. Андрей с Сергеем и Игорем выпивают и весело разговаривают.'
	else
		dirty_swamp_yard += rand(0,2)
		gs 'zz_render','','','За самодельным столом едят и неспешно беседуют охотники.'
	end
	if hantersdrink = 1:
		act 'Выпить водки':
			*clr & cla
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/kuh/vodka2.jpg'
			gs 'zz_render','','','Вы выпили рюмку водки'
			act 'Закусить':
				*clr & cla
				minut += 10
				health += 10
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/snack1.'+rand(1,2)+'.jpg'
				if energy >= 24:
					gs 'zz_render','','','Вы больше не можете есть.'
				elseif energy >= 18 and energy < 24:
					gs 'zz_render','','','Вы через силу затолкали в себя еду.'
				else
					gs 'zz_render','','','Вы с удовольствием съели приготовленную еду.'
				end
				act 'Далее':dynamic $hanterstable
			end
		end
		act 'Выпить пива':
			*clr & cla
			gs 'zz_funcs', 'alko', 2
			gs 'stat'
			gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/kuh/beer2.jpg'
			gs 'zz_render','','','Вы выпили пива'
			act 'Далее':dynamic $hanterstable
		end
		act 'Поболтать':
			*clr & cla
			minut += 15
			if hantersAndreiQw < 10:hantersAndreiQw += 1
			if hantersIgorQw < 10:hantersIgorQw += 1
			if hantersSergeiQw < 10:hantersSergeiQw += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
			gs 'zz_render','','','Вы поболтали с ребятами с ребятами на разные темы...'
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
				gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmoker1.jpg'
				gs 'zz_render','','','Ребята предлагают выйти на перекур.'
				act 'Согласиться':
					*clr & cla
					minut += 15
					manna += 10
					if hantersKnowSlut = 0:hantersAndreiQw += 1
					if hantersKnowSlut = 0:hantersIgorQw += 1
					if hantersKnowSlut = 0:hantersSergeiQw += 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmoker2.jpg'
					gs 'zz_render','','','Вы вышли из избушки, ребята угостили вас сигареткой и вы покурили, продолжая прерванный разговор.'
					act 'Вернуться за стол':dynamic $hanterstable
				end
				act 'Отказаться': dynamic $hanterstable
 			end
			if temp = 2:
				*clr & cla
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/AndreiHanter.jpg'
				gs 'zz_render','','','Андрей предлагает выйти на перекур.'
				if hantersAndreiQw < 15 and hantersKnowSlut = 0 or hantersAndreiLove = 1:
					act 'Согласиться':
						*clr & cla
						minut += 15
						manna += 10
						hantersAndreiQw += 1
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmoker2.jpg'
						gs 'zz_render','','','Вы вышли из избушки, Андрей угостил вас сигаретой и вы покурили, продолжая прерванный разговор.'
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
							gs 'zz_render','','images/qwest/gadukino/Swamp/AndreiHanter.jpg'
							gs 'zz_render','','','Вы вышли из избушки, Андрей угостил вас сигаретой и вы покурили, продолжая прерванный разговор. Вдруг Андрей, положив руку вам на коленку и заглянув в глаза, сказал:'
							gs 'zz_render','','',' - Светик, а не могла бы ты мне помочь?'
							gs 'zz_render','','',' - Конечно, Андрей, я даже рада буду, - ответили вы, потом уже менее уверенно добавили. - А как именно я могу помочь тебе?'
							gs 'zz_render','','',' - Как ты знаешь Светик, я уже давно в разводе, - начал Андрей. - Но я же нормальный мужчина, мне нужно изредка снимать напряжение, ну ты понимаешь о чем я...'
							gs 'zz_render','','','Вы с изумлением посмотрели на него.'
							gs 'zz_render','','',' - Так вот Светик, если бы ты мне хоть изредка помогала его снимать, я был бы тебе очень благодарен, - продолжил Андрей.'
							gs 'zz_render','','','Вы с недоверием смотрели на него, не шутит ли он. Но Андрей говорил вполне серьёзно.'
							gs 'zz_render','','',' - Об этом естественно никто не узнает, не волнуйся , - быстро добавил он. - Ну так как, Светик, ты согласна?'
							act 'Согласиться':
								*clr & cla
								minut += 10
								horny += 10
								hanterslut += 2
								smokbj = 1
								bj += 1
								hantersAndreiQw += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/Swamp/thinks'+rand(1,2)+'.jpg'
								gs 'zz_render','','','Услышав такое вы надолго задумались. Помочь другу это конечно хорошо, но вот сам способ вызывал у вас сомнения.'
								gs 'zz_render','','',' - Хорошо Андрей, я согласна, - наконец решились вы ответить. - А каким именно способом тебе помогать и где?'
								gs 'zz_render','','',' - Блин, Светик, я знал, что будешь не против, - ответил он. - Ну а на счет способа не волнуйся, поработай ротиком, мне и этого хватит.'
								gs 'zz_render','','',' - Пошли за избушку, чтобы никто не увидел , - добавил он вставая с лавки.'
								act 'Идти':dynamic $hantersmokBJ
							end
							if alko < 6:
								act 'Отказаться':
									*clr & cla
									minut += 10
									hanterslut -= 1
									hantersAndreiQw += 1
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/Swamp/thinks'+rand(1,2)+'.jpg'
									gs 'zz_render','','','Услышав такое вы надолго задумались. Помочь другу это конечно хорошо, но вот сам способ вызывал у вас сомнения.'
									gs 'zz_render','','',' - Нет Андрей, я не согласна, - наконец решились вы ответить. - Как ты вообще мог мне такое предложить?'
									gs 'zz_render','','','И встав с лавки быстро ушли назад в избушку.'
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
							gs 'zz_render','','images/qwest/gadukino/Swamp/AndreiHanter.jpg'
							gs 'zz_render','','','Вы вышли из избушки, чтобы покурить, но Андрей сразу же сказал:'
							gs 'zz_render','','',' - К черту перекур, Светик, пошли за избушку.'
							act 'Идти':dynamic $hantersmokBJ
							if alko < 6:
								act 'Отказаться':
									*clr & cla
									minut += 10
									hanterslut -= 1
									hantersAndreiQw -= 50
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/Swamp/thinks'+rand(1,2)+'.jpg'
									gs 'zz_render','','',' - Знаешь Андрей, я передумала, - сказали вы набравшись смелости. - Я конечно рада помочь другу, но я не шлюха какая-нибудь, чтобы сосать по подворотням.'
									gs 'zz_render','','','И встав с лавки быстро убежали назад в избушку.'
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
						gs 'zz_render','','images/qwest/gadukino/Swamp/AndreiHanter.jpg'
						gs 'zz_render','','','Вы вышли из избушки, чтобы покурить, но Андрей сразу же сказал:'
						gs 'zz_render','','',' - К черту перекур, Светик, пошли за избушку, надо напряжение снять.'
						act 'Идти':dynamic $hantersmokBJ
					end
				end
				act 'Отказаться':dynamic $hanterstable
 			end
			if temp = 3:
				*clr & cla
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/SergeiHanter.jpg'
				gs 'zz_render','','','Сергей предлагает выйти на перекур.'
				act 'Согласиться':
					*clr & cla
					minut += 15
					manna += 10
					if hantersKnowSlut = 0:hantersSergeiQw += 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmoker2.jpg'
					gs 'zz_render','','','Вы вышли из избушки, Сергей угостил вас сигаретой и вы покурили, продолжая прерванный разговор.'
					act 'Вернуться за стол':dynamic $hanterstable
				end
				act 'Отказаться':dynamic $hanterstable
 			end
			if temp = 4:
				*clr & cla
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/IgorHanter.jpg'
				gs 'zz_render','','','Игорь предлагает выйти на перекур.'
				act 'Согласиться':
					*clr & cla
					minut += 15
					manna += 10
					if hantersKnowSlut = 0:hantersIgorQw += 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmoker2.jpg'
					gs 'zz_render','','','Вы вышли из избушки, Игорь угостил вас сигаретой и вы покурили, продолжая прерванный разговор.'
					act 'Вернуться за стол':dynamic $hanterstable
				end
				act 'Отказаться':dynamic $hanterstable
 			end
		end
		if alko >= 8 and hantersKnowSlut = 0:
			*clr & cla
			temp = rand(1,6)
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousedrunkgirl.jpg'
			gs 'zz_render','','','Вы напились в стельку, мозги уже почти не соображают, да и двигаетесь уже с трудом...'
			if hanterslut <= 20:
				if temp = 1:
					act 'Вырубиться':
						*clr & cla
						minut += 1
						if hantersIgorLove <= 1:hanterslut += 1
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousedrunkgirl2.jpg'
						gs 'zz_render','','','Вы отключились и уснули прямо за столом...'
						act 'Проснуться':
							*clr & cla
							minut += 180
							son += 6
							health -= 15
							manna -= 25
							gs 'stat'
							gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel1.jpg'
							gs 'zz_render','','','Вы проспали часа 3, проснувшись среди ночи. Голова болела и вы смутно помнили, что вчера происходило.'
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
						gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep7.jpg'
						gs 'zz_render','','','Вы пытались дойти до кровати, но вырубились прямо на полу, так и не дойдя до нее...'
						act 'Проснуться':
							*clr & cla
							minut += 240
							son += 8
							health -= 20
							manna -= 25
							gs 'stat'
							gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel4.jpg'
							gs 'zz_render','','','Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
							act 'Далее': gt $loc, $metka
						end
					end
				end
				if temp = 3:
					act 'Вырубиться':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep4.jpg'
						gs 'zz_render','','','Вы кое-как добрались до лежака и вырубились не раздеваясь...'
						act 'Проснуться':
							*clr & cla
							minut += 360
							son += 12
							health -= 10
							manna -= 25
							gs 'stat'
							gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg'
							gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле оторвали голову от подушки. Голова болела и вы смутно помнили, что вчера происходило.'
							act 'Далее': gt $loc, $metka
						end
					end
				end
				if temp > 3:
					act 'Выйти из-за стола':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja5.jpg'
						gs 'zz_render','','','Пьяные ребята предложили вам порадовать их и станцевать, Андрей включил музыку и вы пьяно покачиваясь вылезли из за стола...'
						if hanterslut < 5:
							act 'Отказаться от этой затеи':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep11.jpg'
								gs 'zz_render','','','Но встав на ноги, вы поняли, что вы не то что танцевать, вам до кровати дойти сложно будет. Поэтому махнув разочарованым ребятам рукой вы отправились спать.'
								act 'Проснуться':
									*clr & cla
									minut += 480
									son += 16
									health -= 5
									manna -= 25
									gs 'stat'
									gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg'
									gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле встали с кровати. Голова болела и вы смутно помнили, что вчера происходило.'
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
								gs 'zz_render','','images/qwest/gadukino/Swamp/dance1.'+rand(1,2)+'.jpg'
								gs 'zz_render','','','Выбравшись из-за стола вы принялись изображать ритмичный танец, под дружные аплодисменты ребят.'
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
										gs 'zz_render','','images/qwest/gadukino/Swamp/dance2.'+rand(1,2)+'.jpg'
										gs 'zz_render','','','В порыве танца, под одобрительные аплодисменты парней, вы срываете верхнюю часть одежды, оставшись только в бюстгалтере...'
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
												gs 'zz_render','','images/qwest/gadukino/Swamp/dance3.jpg'
												gs 'zz_render','','','Под одобрительные крики парней вы раздеваетесь дальше, оставшись только в нижнем белье...'
												act 'Вырубиться':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep10.jpg'
													gs 'zz_render','','','Вы явно переоценили свои силы и возможности организма. Поэтому немного потанцевав, неожиданно для парней, вырубились прямо на полу, там где танцевали....'
													act 'Проснуться':
														*clr & cla
														minut += 240
														son += 8
														health -= 5
														manna -= 25
														gs 'stat'
														gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel4.jpg'
														gs 'zz_render','','','Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
														act 'Далее': gt $loc, $metka
													end
												end
											end
										else
											act 'Вырубиться':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep11.jpg'
												gs 'zz_render','','','Но немного потанцевав, вы поняли что ноги вас уже не держат, поэтому махнув разочарованым ребятам рукой вы отправились спать.'
												act 'Проснуться':
													*clr & cla
													minut += 360
													son += 12
													health -= 15
													manna -= 25
													gs 'stat'
													gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg'
													gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле встали с кровати. Голова болела и вы смутно помнили, что вчера происходило.'
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
										gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep11.jpg'
										gs 'zz_render','','','Но немного потанцевав, вы поняли что ноги вас уже не держат, поэтому махнув разочарованым ребятам рукой вы отправились спать.'
										act 'Проснуться':
											*clr & cla
											minut += 360
											son += 12
											health -= 15
											manna -= 25
											gs 'stat'
											gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg'
											gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле встали с кровати. Голова болела и вы смутно помнили, что вчера происходило.'
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
					gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja5.jpg'
					gs 'zz_render','','','Пьяные ребята предложили вам порадовать их и станцевать, Андрей включил музыку и вы пьяно покачиваясь вылезли из за стола...'
					act 'Танцевать':
						*clr & cla
						minut += 10
						horny += rand(5,10)
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/Swamp/dance1.'+rand(1,2)+'.jpg'
						gs 'zz_render','','','Выбравшись из-за стола вы принялись изображать ритмичный танец, под дружные аплодисменты ребят.'
						act 'Танцевать дальше':
							*clr & cla
							minut += 10
							horny += rand(5,10)
							hanterslut += 1
							if hantersIgorLove > 0:hantersIgorQw -= 1
							if hantersSergeiLove > 0:hantersSergeiQw -= 1
							if hantersSergeiLove > 0:hantersSergeiQw -= 1
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/Swamp/dance2.'+rand(1,2)+'.jpg'
							gs 'zz_render','','','В порыве танца, под одобрительные крики парней, вы срываете верхнюю часть одежды, оставшись только в бюстгалтере...'
							act 'Танцевать дальше':
								*clr & cla
								minut += 10
								horny += rand(5,10)
								hanterslut += 1
								if hantersIgorLove > 0:hantersIgorQw -= 1
								if hantersSergeiLove > 0:hantersSergeiQw -= 1
								if hantersSergeiLove > 0:hantersSergeiQw -= 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/Swamp/dance3.jpg'
								gs 'zz_render','','','Под одобрительные возгласы парней вы раздеваетесь дальше, оставшись только в нижнем белье...'
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
									gs 'zz_render','','images/qwest/gadukino/Swamp/dance4.jpg'
									gs 'zz_render','','','Танцуя вы раздеваетесь дальше, лифчик летит в сторону и под одобрительные крики парней вы трясете перед ними своими грудями <<body[''tits'']>> размера.'
									if temp = 1:
										act 'Вырубиться':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep17.jpg'
											gs 'zz_render','','','Вы явно переоценили свои силы и возможности организма. Поэтому немного потанцевав, неожиданно для парней, вырубились прямо на полу, там где танцевали....'
											act 'Проснуться':
												*clr & cla
												minut += 240
												son += 8
												health -= 20
												manna -= 25
												gs 'stat'
												gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel3.jpg'
												gs 'zz_render','','','Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
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
											gs 'zz_render','','images/qwest/gadukino/Swamp/dance5.jpg'
											gs 'zz_render','','','Танцуя вы раздеваетесь дальше и остаетесь в чем мать родила. Судя по возбужденным лицам парней их это очень заводит.'
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
			gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousedrunkgirl1.jpg'
			gs 'zz_render','','','Вы напились в стельку, мозги уже почти не соображают, да и двигаетесь уже с трудом...'
			if temp = 1:
				act 'Вырубиться':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/swamphousedrunkgirl2.jpg'
					gs 'zz_render','','','Вы отключились и уснули прямо за столом...'
					act 'Проснуться':
						*clr & cla
						minut += 180
						son += 6
						health -= 15
						manna -= 25
						gs 'stat'
						gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel1.jpg'
						gs 'zz_render','','','Вы проспали часа 3, проснувшись среди ночи. Голова болела и вы смутно помнили, что вчера происходило.'
						act 'Далее': gt $loc, $metka
					end
				end
			end
			if temp = 2:
				act 'Вырубиться':
					*clr & cla
					minut += 3
					gs 'stat'
					gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep7.jpg'
					gs 'zz_render','','','Вы пытались дойти до кровати, но вырубились прямо на полу, так и не дойдя до нее...'
					act 'Проснуться':
						*clr & cla
						minut += 240
						son += 8
						health -= 20
						manna -= 25
						gs 'stat'
						gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel4.jpg'
						gs 'zz_render','','','Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
						act 'Далее': gt $loc, $metka
					end
				end
			end
			if temp = 3:
				act 'Вырубиться':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep4.jpg'
					gs 'zz_render','','','Вы кое-как добрались до лежака и вырубились не раздеваясь...'
					act 'Проснуться':
						*clr & cla
						minut += 360
						son += 12
						health -= 10
						manna -= 25
						gs 'stat'
						gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel2.jpg'
						gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле оторвали голову от подушки. Голова болела и вы смутно помнили, что вчера происходило.'
						act 'Далее': gt $loc, $metka
					end
				end
			end
			if temp > 3:
				act 'Выйти из-за стола':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja5.jpg'
					gs 'zz_render','','','Пьяные ребята предложили вам порадовать их и станцевать, Андрей включил музыку и вы пьяно покачиваясь вылезли из за стола...'
					act 'Танцевать':
						*clr & cla
						minut += 10
						horny += rand(5,10)
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/Swamp/dance1.'+rand(1,2)+'.jpg'
						gs 'zz_render','','','Выбравшись из-за стола вы принялись изображать ритмичный танец, под дружные аплодисменты ребят.'
						act 'Танцевать дальше':
							*clr & cla
							minut += 10
							horny += rand(5,10)
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/Swamp/dance2.'+rand(1,2)+'.jpg'
							gs 'zz_render','','','В порыве танца, под одобрительные крики парней, вы срываете верхнюю часть одежды, оставшись только в бюстгалтере...'
							act 'Танцевать дальше':
								*clr & cla
								minut += 10
								horny += rand(5,10)
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/Swamp/dance3.jpg'
								gs 'zz_render','','','Под одобрительные возгласы парней вы раздеваетесь дальше, оставшись только в нижнем белье...'
								act 'Танцевать дальше':
									*clr & cla
									minut += 10
									horny += rand(5,10)
									temp = rand(1,2)
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/Swamp/dance4.jpg'
									gs 'zz_render','','','Танцуя вы раздеваетесь дальше, лифчик летит в сторону и под одобрительные крики парней вы трясете перед ними своими грудями <<body[''tits'']>> размера.'
									if temp = 1:
										act 'Вырубиться':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep17.jpg'
											gs 'zz_render','','','Вы явно переоценили свои силы и возможности организма. Поэтому немного потанцевав, неожиданно для парней, вырубились прямо на полу, там где танцевали....'
											act 'Проснуться':
												*clr & cla
												minut += 240
												son += 8
												health -= 20
												manna -= 25
												gs 'stat'
												gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel3.jpg'
												gs 'zz_render','','','Вы проспали часа 4, проснувшись среди ночи, растрепанная еле встали с пола. Голова болела и вы смутно помнили, что вчера происходило.'
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
											gs 'zz_render','','images/qwest/gadukino/Swamp/dance5.jpg'
											gs 'zz_render','','','Танцуя вы раздеваетесь дальше и остаетесь в чем мать родила. Судя по возбужденным лицам парней их это очень заводит.'
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
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
			gs 'zz_render','','','Вы поболтали с ребятами с ребятами на разные темы...'
			act 'Выйти из за стола':gt $loc, $metka
		end
		act'Выйти из за стола':hanter_refuse = 1 & gt $loc, $metka
	end
	if hantersKnowSlut > 0 and hanterstableBJ = 0:
		if hantersdrink = 0:
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
			gs 'zz_render','','','Вы хотели присесть за стол и поесть с ребятами, но не тут-то было...'
			gs 'zz_render','','','- Не так быстро Светик, - шутливо сказал Андрей. - Ты же понимаешь, что сыр бесплатный , только в мышеловке бывает.'
			gs 'zz_render','','','- Хочешь кушать, заработай, - добавил он усмехнувшись и указал под стол.'
			act 'Лезть под стол':dom -= 1 & dynamic $hanterstableBJ
			act 'Отказаться':gt $loc, $metka
		else
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
			gs 'zz_render','','','Увидев вас, ребята расплылись в улыбках...'
			gs 'zz_render','','','- О! Наша Светик пришла, - шутливо сказал Андрей. - Нам только тебя и не хватало, садись за стол.'
			act 'Сесть за стол':hanterstableBJ = 1 & dynamic $hanterstable
		end
	end
	if cumpussy > 0 and cloth[0] = 0 or cumbelly > 0 and cloth[0] = 0 or cumass > 0 and cloth[0] = 0 or cumanus > 0 and cloth[0] = 0 or cumface > 0:
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanterstable.jpg'
		gs 'zz_render','','','Вы хотели присесть за стол и поесть с ребятами, но не тут-то было...'
		gs 'zz_render','','','- Фу, блин, Светик, - сказал Андрей. - Ты бы хоть наши художества с лица смыла, прежде чем застол садиться.'
		act 'Уйти':gt $loc, $metka
	end
}
$hantersrelax = {
	cla
	*clr
	minut += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/hantersrelax1.'+rand(1,8)+'.jpg'
	gs 'zz_render','','','В избушке вы видите Сергея, Андрея и Игоря. Они заняты каждый своим делом.'
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
	gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmokBJ1.'+rand(1,3)+'.jpg'
	if hantersmokBJ = 0:'Вы устроились поудобнее на коленях и приблизили свое лицо к его члену...'
	if hantersmokBJ = 1:'Андрей все не кончал, поэтому вы продолжили сосать...'
	gs 'zz_dynamic_sex', 'bj'
	if temp = 1:act 'Сосать дальше':hantersmokBJ = 1 & dynamic $hantersmokBJ
	if temp = 2:
		act 'Сосать дальше':
			*clr & cla
			minut += 1
			swallow += 1
			hantersmokBJ = 0
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hantersmokCUM.jpg'
			gs 'zz_dynamic_sex', 'swallow'
			gs 'zz_render','','','- Круто, блин, Светик, - сказал довольный Андрей. - Ты прямо мастерица.'
			gs 'zz_render','','','Приведя себя в порядок вы отправились с Андреем обратно в избушку'
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
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/dirty_swamphouse.jpg'
	gs 'zz_render','','','Зайдя в очередной раз в избушку, вы заметили, сколько там накопилось разного мусора и грязи. " - С этим нужно что-то делать", - подумали вы, и найдя веник и тряпку принялись за уборку. Через некоторое врямя избушка сияла чистотой и порядком.'
	act 'Далее':dirty_swamphouse = 0 & gt'swamphouse'
}
$dress_after_shower = {
	gs 'zz_clothing2','redress',cloth[3]
	clothesswamphouse = 0
	swamp_clothes = 0
	gt $loc, $metka
}