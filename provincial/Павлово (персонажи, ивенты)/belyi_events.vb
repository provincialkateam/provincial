if $args[0] = 'lake_start':
	if belgangQW = 0:
		gs 'zz_render', '', 'pavlovo/belyi/belyi_lake.jpg', 'Пока вы загораете к вам подсаживается компания взрослых мужиков, у которых все тело покрыто уголовными наколками.**Жирный и плешивый мужик, с пудовым золотым крестом на толстой цепи, сел рядом с вами и почесав пузо спросил:**\\\- Привет! Не помешаем?///'
		if dom >= 10:
			act 'Помешаете':
				cla & *clr
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/belyi/belyi_lake.jpg', 'Вы нахмурились и ответили твердым голосом:**\\- Помешаете.//**Плешивый тут же с вызовом спросил:**\\\- Э, я не вкурил, это чо, твое место, что-ли?///'
				if dom >= 25:
					act 'Да моё!':
						cla & *clr
						minut += 5
						gs'stat'
						gs 'zz_render', '', 'pavlovo/belyi/siplyi.jpg', 'Вы возмущенно ответили наглецу:**\\- Да, это мое место! Я тут первее вас!//**Возле вас на корточки сел хмурый мужик, с наколотой смертью и могилами на груди, и сказал мрачно глядя вам в глаза:**- Место есть только у проституток и кондукторов. А это нихуя не автобус. Так что делаем выводы, пацаны...**Плешивый усмехнулся положив вам ладонь на грудь и сжав её '+iif(current_clothing > 0,'под купальником','')+' спросил:**\\\- И чо по чём?///'
						act 'Уйти': gt 'belyi_events', 'lake_go'
						if dom >= 25:act 'Убери руки!': gt 'belyi_events','lake_hand'
					end
				end
				act'Уйти': gt 'belyi_events','lake_go'
			end
		end
		act 'Не помешаете':
			cla & *clr
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'pavlovo/belyi/take_belly.gif', 'Вы пожали плечами и постарались отвлечься от этих братков закрыв глаза. Но не тут то было, вы почувствовали, что вас по животу что-то легонько гладит и щекочет. Открыв глаза вы увидели, что толстопузый мужик водит кончиком своего пальца по вашему животу.'
			if dom >= 0:act'Уйти': gt 'belyi_events', 'lake_go'
			if dom >= 10:act'Убери руки!': gt 'belyi_events','lake_hand'
			act 'Лежать':
				cla & *clr
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/belyi/take_tits.'+iif(current_clothing > 0,'gif','jpg'), 'Вы постарались не обращать внимания и просто продолжили лежать на песке. Жирдяй тем временем отбросил травинку и стал поглаживать вас своей потной ладонью по животу и вдруг схватил вас за грудь.**\\\- Поехали ко мне детка, не пожалеешь. Со мной у тебя все будет!///'
				act 'Убери руки!': gt 'belyi_events','lake_hand'
				if shameless['flag'] > 1: act 'Ехать с жирдяем': gt 'belyi_events','lake_ride'
			end
		end
		if dom >= 0:act'Уйти': gt 'belyi_events','lake_go'
	else
		gt 'belyi_events', 'meet'
	end
end
if $args[0] = 'lake_ride':
	cla & *clr
	belgangQW = 1
	minut += 15
	gs 'zz_clothing', 'redress', prev_clothing
	tanga = flag_tanga
	prev_clothing = -1
	minut += 35
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/take_leg.jpg', 'Вы переоделись и пошли с жирдяем к его машине. Машина оказалась видавшим виды БМВ семёркой, естественно черного цвета. Пузан усадил вас на пассажирское сиденье и сам сел за руль положив вам руку на колено:**\\\- Можешь звать меня Белым, а тебя как звать?///**Вы скромно улыбнулись и ответили:**\\- <<$name[1]>>.//**Белый завел машину и она, утробно рыча, поехала по городу. Вскоре вы подъехали к обыкновенной пятиэтажке и Белый закрыв машину проводил вас в квартиру.'
	act 'Осмотреться': gt 'belyi_events','house'
end
if $args[0] = 'lake_go':
	cla & *clr
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/belyi_lake.jpg','Вы попытались встать на ноги, но вас за запястье тут же схватил плешивый мордоворот:**\\\- Э, расслабся. Ты чо какая нервная?///'
	if dom >= 0: act'Извините, но мне пора идти.': gt'belyi_events','lake_end'
	act 'Я не нервничаю.':
		cla & *clr
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'pavlovo/belyi/belyi_lake.jpg','Вы как можно спокойней сказали:**\\- А я и не нервничаю.//**Жирдяй хохотнул и схватил вас за грудь свой волосатой, потной лапищей:**\\\- Поехали ко мне детка, не пожалеешь. Со мной у тебя все будет...///'
		act'Убери руки!': gt'belyi_events', 'lake_hand'
		if dom >= 10:act 'Извините, но мне пора идти.': gt'belyi_events','lake_end'
		if shameless['flag'] > 1:act 'Ехать с жирдяем': gt'belyi_events','lake_ride'
	end
end
if $args[0] = 'lake_end':
	cla & *clr
	minut += 5
	dom -= 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/belyi_lake.jpg','Плешивый усмехнулся:**\\\- Ладно, девочка, иди. Ещё пересечемся, земля круглая...///'
	act 'Уйти': gt'glake'
end
if $args[0] = 'lake_hand':
	cla & *clr
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/hand1.jpg', 'Вы возмутились, отшвыривая руку плешивого от себя:**\\- Убери руки!//**Хмурый рыкнул и схватив вас за руки, больно сжал:\\\- Ты чо дерзишь?///'
	act 'Ай! Отпусти! Больно же!':
		cla & *clr
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'pavlovo/belyi/hand2.jpg','Вы тут же невольно взвизгнули от боли:**\\- Ай! Отпусти! Больно же!//**Хмурый немного выкрутил вам руку:**\\\- Ты в курсе, что ты конкретно не права?///**Жирдяй тем временем порылся в ваших вещах и достал ваши документы:**\\\- Сиплый, полегче, сломаешь руку. Девочка уже наверное осознала свою ошибку и глубоко раскаивается.///'
		act 'Извиняться':
			cla & *clr
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/belyi/hand3.jpg', 'Вы завизжали от новой порции боли в руке, когда Сиплый начал вам ее выворачивать, и в панике оглядев пляж, тут же заметили, что народ по быстрому исчезает с пляжа, и все единодушно стараются не смотреть в вашу сторону:**\\- Извините! Простите меня, я так больше не буду!//**Сиплый рыкнул на вас:**\\\- Ты чо, мокрощелка, совсем рамсы попутала? За фраеров нас держишь? Ты конкретно накосячила и должна нам.///'
			act 'Я заплачу! Только отпусти!':
				cla & *clr
				minut += 5
				if money < 10000:
					belgangPay = 50000
				end
				if money >= 10000:
					belgangPay = money*5
				end
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/belyi/hand4.jpg', 'Вы запричитали роняя слезы на песок:**\\- Я заплачу! Только отпусти!//**Пузатый ухмыльнулся достав ваши сбережения:**\\\- Это чо, ты считаешь деньгами эти гроши? Ты влетела минимум на <<belgangPay/1000>> кусков.///**Сиплый зарычал вам в ухо:**\\\- Слашала что Белый сказал? Что бы к завтраму приготовила <<belgangPay/1000>> кусков за свой косяк.///'
				act'Хорошо, завтра все отдам.':
					cla & *clr
					minut += 5
					belgangQW = 3
					belgangday = daystart
					gs'stat'
					gs 'zz_render', '', 'pavlovo/belyi/belyi_lake.jpg', 'Вы согласились с условиями и Сиплый отпустил вашу руку. Плешивый усмехнулся показав золотые фиксы:**\\\- И учти <<$name[2]>>, не отдашь <<belgangPay>> рублей, будешь отрабатывать. А в ментовку сунешся, мы тебя в лесочке прикопаем.///**После этого бандиты поднялись и ушли с пляжа.'
					act 'Встать': gt'glake'
				end
				act'У меня нет таких денег.':
					cla & *clr
					minut += 5
					gs'stat'
					gs 'zz_render', '', 'pavlovo/belyi/crying.jpg', 'Вы заплакали и начали умолять бандитов:\\- У меня нет таких денег!//**Плешивый зевнул и равнодушно сказал:\\\- Ну тогда будешь натурой отрабатывать. Вот прямо сейчас и начинай...///**Белый лег на пляж и достал из трусов свой вялый член. Сиплый схватил вас за волосы и наклонил к члену:**\\\- Ты чё ломаешся, сучка? Соси прощение.///'
					act 'Сосать.':
						cla & *clr
						minut += 5
						bj += 1
						if sashaBeliSex = 0: sashaBeliSex = 1 & guy += 1
						gs 'zz_funcs', 'cum', 'lip'
						belgangQW = 2
						belgangday = daystart
						belgangPay -= 100
						gs'stat'
						gs 'zz_render', '', 'pavlovo/belyi/lake_bj.gif', 'Вы обхватили вялый, немытый, стручок и начали его сосать. Постепенно член в вашем рту встал и толстопузый бандит захрюкав стал спускать вам в рот свою теплую, мерзкую на вкус сперму. Он крепко держал вас за волосы и вы, стараясь не сблевать от отвращения, начали проглатывать его мерзкую кончу. Когда все наконец закончилось, вы увидели как Сиплый смотрит в свой телефон:\\\- Охуенный видос получился.///**Белый небрежно отодвинув вас от себя, встал на ноги, и сказал равнодушно:**\\\- Короче сотку ты отработала, осталось отработать еще <<belgangPay>> рублей. Ты не кипешуй, когда понадобятся твои услуги, мы сами тебя найдем.///**После этого братва собралась и ушла с пляжа.'
						act 'Встать':gt'glake'
					end
				end
			end
		end
	end
end
if $args[0] = 'house':
	cla & *clr
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/house.jpg', 'Вы осмотрели квартиру. Неплохой ремонт, минимум мебели и полное отсутствие всяких украшений жилища и уюта, скорее всего квартира съемная. Белый не дал вам долго осматриватся и схватив вас приблизил к себе, его пахнущий табаком рот прильнул к вашим нежным губам и вы почувствовали, как он засовывает свой язык вам в рот.'
	act 'Целоваться': gt'belyi_events','house_start'
end
if $args[0] = 'house_start':
	cla & *clr
	dick = 15
	$boy = 'Белый'
	silavag = 0
	if sashaBeliSex = 0: sashaBeliSex = 1 & guy += 1
	minut += 5
	sex_act = rand(1,3)
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/kiss.jpg', 'Вы обсасываете язык потного жирдяя и он грубо лапает вас за задницу.'
	tiperand=rand(1,100)
	if tiperand<=70:
		gs 'zz_render', '', '', 'Белый надавливает вам на плечи вынуждая вас встать на колени.'
		act 'Встать на колени': gt'belyi_events','house_bj'
	else
		gs 'zz_render', '', '', 'Белый лапает вас стараясь раздеть и завалить на кровать.'
		if vagina = 0:
			act 'Я ещё девственница': gt'belyi_events','house_virgin'
		else
			act 'Раздвинуть ноги': gt'belyi_events','house_sex'
		end
		act 'Встать на колени': gt'belyi_events','house_bj'
	end
end
if $args[0] = 'house_bj':
	cla & *clr
	minut += 5
	bj_temp += 1
	sex_act -= 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/sex/bj'+rand(1,3)+'.gif', 'Вы берете <<dick>> сантиметровый член в свой ротик и начинаете его сосать ощущая как твердый стержень ходит в вашем ротике. Белый взял вас за волосы и начал двигать членом навстречу вашим губам, буквально насаживая вашу голову на свой член.'
	if sex_act <= 0:
		gs 'zz_render', '', '', '<<$boy>> застонал и схватил вас покрепче.'
		act 'Открыть рот':
			cls
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
			gs'stat'
			gs 'zz_render', '', 'pavlovo/belyi/sex/cum.gif', 'Член начинает кончать и теплые струи вязкой спермы попадают вам в рот и на лицо. Вскоре поток спермы иссякает оставляя вас с противным вкусом во рту и обтекающей белой слизью по коже вашего лица.'
			act 'Встать': gt'belyi_events','house_end'
		end
	else
		if rand(1,100) <= 30:
			gs 'zz_render', '', '', 'Белый крепко держит вашу голову, не давая оторваться от своего члена.'
			act 'Сосать дальше': gt'belyi_events','house_bj'
		else
			gs 'zz_render', '', '', 'Белый отрывает вас от своего члена и ложит на кровать.'
			if vagina = 0: act 'Я ещё девственница': gt'belyi_events','house_virgin'
			act 'Раздвинуть ноги': gt'belyi_events','house_sex'
		end
	end
end
if $args[0] = 'house_virgin':
	cla & *clr
	gs 'zz_render', '', 'pavlovo/belyi/sex/beg.jpg'
	if bel_know_virgin = 0:
		bel_know_virgin += 1
		gs 'zz_render', '', '', '\\- Прошу, не нужно, пожалуйста! - //взмолились вы, глядя на Белого.\\ - Я ещё девочка...//**\\\- И чо? Ща мы это быстро исправим! -/// хохотнул в ответ Белый.**\\- Ну пожалуйста, не надо,-// продолжили вы упрашивать потупив глазки. \\- '+iif(age < 18,'Меня мамка заругает, если узнает...','Я для будущего мужа девственность берегу...')+'//**\\\- Хера себе! -/// удивился Белый.\\\ - '+iif(age < 18,'Такая здоровая кобыла, а мамку боится...','Типа правильная что-ли?')+'///**Белый сел на кровать и почесал пузо:**\\\- Ладно, становись рачком тогда, попользуем другую твою дырку!///'+iif(anus < 10,'**\\- А может я лучше ротиком? -// попробовали вы уклонится от новой напасти.**\\\- Не борзей, <<$name[1]>>, я и так сегодня что-то добрый, -/// отвел Белый, хлопнув вас по заду. \\\- Давай, вставай рачком и раслабь булки...///','')
		act 'Встать раком': gt'belyi_events','house_anal'
	elseif bel_know_virgin > 0 and bel_know_virgin < 10:
		bel_know_virgin += 1
		gs 'zz_render', '', '', '\\- Белый, прошу... - //начали вы.**\\\- Да помню, помню! '+iif(age < 18,'Мамка заругает','Для мужа бережёшься')+'... -/// заворчал в ответ он. \\\- Готовь очко тогда...///'
		act 'Встать раком': gt'belyi_events','house_anal'
	else
		bel_know_virgin += 1
		gs 'zz_render', '', '', '\\- Белый, прошу... - //начали вы.**\\\- Да достала ты уже со сво'+iif(age < 18,'ей мамкой','им мужем')+'!, -/// раздражённо ответил он. \\\- Короче! Давай решать конкретно. Я тебе даю десять штук и мы забываем об этой проблеме...///'
		act 'Давай лучше в попу':
			cla & *clr
			gs 'zz_render', '', 'pavlovo/belyi/sex/doggy_style'+iif(anus <= 10,1,iif(anus <= 25,2,3))+'.jpg', '\\- Не, давай всё таки лучше в попу... - //сказали вы, привычно занимая коленно-локтевую позицию.'
			if bel_know_virgin < 15 or dom >= 50:
				gs 'zz_render', '', '', '\\\- Ну как знаешь... -/// вздохнул он в ответ. \\\- Моё дело предложить...///'
				act 'Встать раком': gt'belyi_events','house_anal'
			else
				gs 'zz_render', '', '', '\\\- Нет уж, ты меня реально заебала уже со своей целкой... -/// набычился он. \\\- Давай, раздвигай ноги бесплатно... Будешь знать, как выёбываться, в следующий раз!///'
				act 'Раздвинуть ноги': gt'belyi_events','house_sex'
			end
		end
		act 'Раздвинуть ноги': money += 10000 & gt'belyi_events','house_sex'
	end
end
if $args[0] = 'house_sex':
	cla & *clr
	minut += 5
	sex_act -= 1
	sex_temp += 1
	pose = 0
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/sex/sex'+iif(vagina = 0,'',rand(1,3))+'.gif'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if sex_act <= 0:
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Встать': gt'belyi_events','house_end'
	else
		i = rand(1,100)
		if i <= 30:
			gs 'zz_render', '', '', 'Белый достаёт из вас член, поднимает с кровати, и ставит перед собой на колени.'
			act 'Взять в рот': gt'belyi_events','house_bj'
		elseif i > 30 and i <= 80:
			gs 'zz_render', '', '', 'Белый вытирает пот со лба, стараясь отдышатся.'
			act 'Раздвинуть ноги': gt'belyi_events','house_sex'
		else
			gs 'zz_render', '', '', 'Белый достаёт из вас член и ставит вас раком перед собой.'
			act 'Встать раком': gt'belyi_events','house_anal'
		end
	end
end
if $args[0] = 'house_anal':
	cla & *clr
	minut += 5
	sex_act -= 1
	anal_temp += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/sex/anal'+rand(1,3)+'.gif'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if sex_act <= 0:
		gs 'zz_funcs', 'cum', 'anus'
		gs 'zz_render', '', '', '<<$boy>> застонал и кончил вам в попу, наполняя её своей теплой спермой.'
		act 'Встать': gt'belyi_events','house_end'
	else
		i = rand(1,100)
		if i <= 30:
			gs 'zz_render', '', '', 'Белый достаёт из вашей попы член и ставит перед собой на колени.'
			act 'Взять в рот': gt'belyi_events','house_bj'
		elseif i > 30 and i <= 80:
			gs 'zz_render', '', '', 'Белый достаёт из вашей попы член и кладёт вас на спину.'
			if vagina = 0: act 'Я ещё девственница': gt'belyi_events','house_virgin'
			act 'Раздвинуть ноги': gt'belyi_events','house_sex'
		else
			gs 'zz_render', '', '', 'Белый вытирает пот со лба стараясь отдышатся'
			act 'Стоять раком': gt'belyi_events','house_anal'
		end
	end
end
if $args[0] = 'house_end':
	cla & *clr
	sex_act = 0
	bel_money = 0
	if sex_temp > 0: bel_money += 1000 & sex_temp = 0 & sex += 1
	if bj_temp > 0: bel_money += 500 & bj_temp = 0 & bj += 1
	if anal_temp > 0: bel_money += 1500 & anal_temp = 0 & anal += 1
	gs 'zz_bathroom', 'clean_me'
	minut += 15
	horny += 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/glake/lake_boy/shower'+rand(1,3)+'.jpg', 'Вы встали с кровати и пошли в ванную комнату. Включив воду вы начали намыливать свое тело мочалкой. После смыли мыло и помыли волосы шампунем. Смыв шампунь вы стали совершенно чистой.'
	act 'Выйти из ванны':
		cla & *clr
		BelSexTime=0
		money += bel_money
		hapri = 1
		minut += 10
		gs'stat'
		gs 'zz_render', '', 'pavlovo/belyi/house.jpg', '<<$boy>> даёт вам <<bel_money>> рублей и выпроваживает вас из квартиры.'
		act'Уйти': gt'gorodok'
	end
end
if $args[0] = 'meet':
	cla & *clr
	daybelisex = daystart
	gs 'zz_render', '', 'pavlovo/belyi/belyi_'+iif($loc = 'glake','lake','car')+'.jpg'
	if belgangQW = 1:
		gs 'zz_render', '', '', iif($loc = 'glake','Пока вы загораете к вам подсаживается Белый со своими братками, и почесывая пузо, лениво спрашивает:**\\\- Ну чо <<$name[2]>>, прокатимся?///','К вам подъезжает чёрный, потрёпаный БМВ и из открытого водительского окна выглядывает толстая плешивая рожа Белого:**\\\- Короче <<$name[2]>>, садись, покатаемся.'+iif(bel_refuse >= 3,' Возражения не принимаются!',''))+'///'
		act iif($loc = 'glake','Ехать с белым','Сесть в машину'):
			cla & *clr
			if current_clothing < 3:
				gs 'zz_clothing', 'redress', prev_clothing
				tanga = flag_tanga
				prev_clothing = -1
			end
			minut += iif($loc = 'glake',35,5)
			bel_refuse = 0
			gs'stat'
			gs 'zz_render', '', 'pavlovo/belyi/go_car'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', 'Вы сели в машину и Белый поехал по городу.'
			i = rand(1,100)
			if tiperand <= 30 and $loc ! 'glake':
				gs 'zz_render', '', '', 'Белый расстегивая ширинку сказал:**\\\- <<$name[2]>> , у меня мало времени, поэтому давай побыстрей...///'
				act'Отсосать':
					cla & *clr
					bj += 1
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					minut += 5
					money += 1000
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/belyi/car_bj'+rand(1,3)+'.gif', 'Вы наклонились к члену Белого и начали его сосать, толстяк долго не продержался и противная сперма стала выстреливать вам в рот. Выплевывать её было некуда и вы сглотнули. Когда Белый прекратил кончать, он остановил машину и сунув вам 1000 рублей выпроводил вас на улицу.'
					act'Уйти': gt $loc, $metka
				end
			else
				gs 'zz_render', '', '', 'Вскоре вы подъехали к обыкновенной пятиэтажке и Белый закрыв машину проводил вас в квартиру.'
				act 'Осмотреться': gt 'belyi_events','house'
			end
		end
		if dom > 0 and bel_refuse < 3:
			act 'Отказаться':
				cla & *clr
				bel_refuse += 1
				gs 'zz_render', '', 'pavlovo/belyi/belyi_'+iif($loc = 'glake','lake','car')+'.jpg', '\\- Слушай, Белый, я сейчас никак не могу, давай в другой раз? - попросили вы Белого.**\\\- Лады, в другой, так в другой, - недовольным голосом ответил он и '+iif($loc = 'glake','сплюнув на землю пошёл прочь вместе со своей братвой.','рыкнув двигателем умчался прочь.')
				act 'Уйти': gt $loc, $metka
			end
		end
	end
	if belgangQW = 2:
		gs 'zz_render', '', '', iif($loc = 'glake','Пока вы загораете к вам подсаживается Белый со своими','К вам подъезжает чёрный БМВ с Белым и его')+' братками:**\\\- Слышь, шалава, '+iif($loc = 'glake','вставай','запрыгивай')+', поедешь долги отрабатывать.///'
		act iif($loc = 'glake','Ехать с белым','Сесть в машину'):
			cla & *clr
			if current_clothing < 3:
				gs 'zz_clothing', 'redress', prev_clothing
				tanga = flag_tanga
				prev_clothing = -1
			end
			minut += iif($loc = 'glake',60,30)
			gs'stat'
			gs 'zz_render', '', 'pavlovo/belyi/ride'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', 'Вы сели на заднее сиденье и Белый поехал по городу.'
			if month >= 5 and month <= 9:
				if rand(0,1) = 0:
					gs 'zz_render', '', '', 'Машина выехала за город и взревев мощным мотором помчалась по трассе. Один из молчащих бандюков соизволил пояснить:**\\\- Пикничок у нас намечается на природе.///**Наконец машина остановилась где-то возле трассы и бандюки вышли из машины.'
					act 'Выйти из машины': bel_picnic = 1 & gt 'belyi_events','gang_start'
				else
					gs 'zz_render', '', '', 'Машина подъехала к неухоженному частному дому с высоким металическим забором'
					act 'Выйти из машины': gt 'belyi_events','gang_start'
				end
			else
				gs 'zz_render', '', '', 'Машина подъехала к неухоженному частному дому с высоким металическим забором'
				act'Выйти из машины': gt 'belyi_events','gang_start'
			end
		end
	end
	if belgangQW = 3:
		belgangQW = 1
		gs 'zz_render', '', '', iif($loc = 'glake','Пока вы загораете к вам подсаживается Белый со своими со своими братками','Возле вас остановился, видавший виды, чёрный БМВ и из него вылезли братки. Белый тут же подошел к вам и спросил')+':**\\\- Ну как дела <<$name>>? Есть хорошие новости?///'
		if money >= belgangPay:
			act 'Отдать деньги':
				cla & *clr
				money -= belgangPay
				gs'stat'
				gs 'zz_render', '', 'pavlovo/belyi/money.jpg', 'Вы достали деньги и передали их бандитам. Белый усмехнулся:\\\- Надеюсь пересчитывать не надо? А то мы можем вернуться.///**Вы отрицательно покачали головой:**\\- Тут все деньги. И лучше пересчитайте при мне.//**Белый посчитал деньги:\\\- Лады, вся сумма на месте. Ну не хворай <<$name[2]>>, думаю мы ещё не раз пересечёмся.**'+iif($loc = 'glake','Он поднялся на ноги и неспешным шагом отправился дальше.','После этого вся банда села опять в БМВ и тот, рыкнув мощным мотором, уехал.')
				act 'Уйти': gt $loc, $metka
			end
		else
			act 'У меня нет таких денег':
				cla & *clr
				gs 'zz_render', '', 'pavlovo/belyi/crying_meet.jpg', 'Вы едва не плача покачали головой:**\\- У меня нет таких денег.//**Плешивый нахмурился:**\\\- Ай ай ай, <<$name[2]>>, как нехорошо, ну ничего, я тебя в одно теплое место пристрою, там ты мне все живо отработаешь.///**Вас тут же грубо схватили и '+iif($loc = 'glake','поволокли к выходу с пляжа. Напрасно вы брыкались и звали на помощь, все присутствующие в это время на пляже старательно отводили глаза, не решаясь перечить мордоворотам Белого. Дойдя до машины, вас силой посадили на заднее сидение','силой посадили в машину')+'. Вся банда расселась по местам и БМВ, взревев, помчался по трассе в сторону города.'
				act 'Ехать':
					cla & *clr
					if current_clothing < 3:
						gs 'zz_clothing', 'redress', prev_clothing
						tanga = flag_tanga
						prev_clothing = -1
					end
					minut += iif($loc = 'glake',95,60)
					workDolg = belgangPay
					workDolg -= money
					money = 0
					belgangPay = 0
					gs'stat'
					gs 'zz_render', '', 'pavlovo/belyi/ride_city.jpg', 'Вы долго ехали по трассе, пока наконец не въехали в город. Там поплутав по улицам, вы подъехали с чёрного входа к неприметному зданию сауны. Бандиты оттащили вас в какую-то комнату и начали объяснять:**\\\- Ты будешь здесь жить и работать, до тех пор, пока не расплатишься с долгами. Все понятно? Попробуешь бузить или сбежать, всё! Мы тебе пулю в башку всадим и в лесу прикопаем. Усекла?///**Вы испуганно кивнули, поняв что они не шутят.'
					act 'Оглядеться': gt'saunaroom'
				end
			end
		end
	end
end
if $args[0] = 'gang_start':
	cla & *clr
	sashaBeliTimes = rand(1,3)
	sipliGangTimes = rand(1,3)
	kolGangTimes = rand(1,3)
	tatarGangTimes = rand(1,3)
	times_picknick = sashaBeliTimes + sipliGangTimes + kolGangTimes + tatarGangTimes
	minut += 5
	gs 'zz_render', '', 'pavlovo/belyi/gang/picnic_start<<bel_picnic>>.jpg', 'Бандюки быстро '+iif(bel_picnic = 1,'соорудили мангал и стали жарить на нём мясо попутно набираясь водярой практически без закуски','зашли во внутрь, и пройдя в большую комнату начали накрывать на стол, доставая из пакетов уже приготовленную еду и гремя бытылками с водкой. Когда всё было готово, они дружно уселись за стол и, под весёлый смех вперемешку с сальными сальные шуточками, принялись методично нажираться')+'. Белый сунул вам стакан:**\\\- На, выпей.///'
	act'Выпить':
		cla & *clr
		gs 'zz_funcs', 'alko', 3
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'pavlovo/belyi/gang/drink.jpg', 'Вы выпили водки ощутив как она обожгла горло и приятное тепло разлилось по телу.'
		act 'Далее': gt 'belyi_events','gang_1'
	end
	act'Отказаться':
		cla & *clr
		gs 'zz_render', '', 'pavlovo/belyi/gang/drink_no<<bel_picnic>>.jpg', 'Вы отрицательно мотнули головой и Белый пожал плечами:**\\\- Ну, как хочешь...///'
		act 'Далее': gt 'belyi_events','gang_1'
	end
end
if $args[0] = 'gang_1':
	cla & *clr
	minut += 60
	gs 'zz_render', '', 'pavlovo/belyi/gang/picnic_drink<<bel_picnic>>.jpg', 'Бандиты всё нажирались и нажирались, и вскоре уже были пьяны в дым. Кто-то из бандитов крикнул пьяным голосом, врубив '+iif(bel_picnic = 1,'магнитолу в машине','музыкальный центр')+' на полную мощность:**\\\- Стриптиз!///**Братки подхватили и вытащили вас в центр круга.**\\\- Стриптиз, стриптиз, стриптиз!,/// - заорали они пьяными голосами.'
	act'Устроить стриптиз':
		cla & *clr
		minut += 5
		gs'stat'
		if shameless['flag'] > 0:
			if dance < 50:
				gs 'zz_render', '', 'pavlovo/belyi/gang/dance<<bel_picnic>>.jpg', 'Вы начали неловко танцевать, стягивая с себя одежду. Один из бандюков выкрикнул:**\\\- Это чё за херня? Уборщица тетя Катя и то лучше сможет!///**Другой подхватил:**\\\- Да уж, полный отстой!///**Сиплый взял пустую бутылку и сунул вам в руки.**\\\- Ну раз ты мокрощелка такая кривоногая, то тогда устраивай другое шоу!, ///- хохотнув сказал он. \\\- Пихай себе в дырки бутылку и если ты и тут нихрена не сможешь, то пизда тебе!'
				act'Засунуть себе бутылку горлышком во влагалище': gt 'belyi_events','bottle_vag_light'
				if vagina > 10: act'Засунуть себе бутылку донышком во влагалище': gt 'belyi_events','bottle_vag_hard'
				act'Засунуть себе бутылку горлышком в попу': gt 'belyi_events','bottle_anal_light'
				if anus > 10:act'Засунуть себе бутылку донышком в попу': gt 'belyi_events','bottle_anal_hard'
			else
				gs 'zz_render', '', 'pavlovo/belyi/gang/dance'+iif(stripdance < 50,iif(bel_picnic = 1,rand(2,4),rand(5,7)),iif(bel_picnic = 1,rand(8,10),rand(11,13)))+'.jpg', 'Вы '+iif(stripdance < 50,'зажигательно','сексуально')+' танцуете перед бандюками, '+iif(stripdance < 50,'стараясь раздеваться как можно сексуальней','грациозно, под музыку, освобождаясь от одежды')+'. Бандосы, глядя на ваши движения, явно возбуждаются и начинают доставать свои, уже вставшие, писюны:**\\\- А теперь покажи <<$name[2]>>, как ты умеешь ротиком работать!///'
				act'Сесть на корточки':
					cla & *clr
					minut += 5
					bj += 4
					gang += 1
					if sashaBeliSex = 0: sashaBeliSex = 1 & guy += 1
					if sipliGangSex = 0: sipliSex = 1 & guy += 1
					if kolGangSex = 0:kolGangSex = 1 & guy += 1
					if tatarGangSex = 0:tatarGangSex = 1 & guy += 1
					gs'stat'
					gs 'zz_render', '', 'pavlovo/belyi/gang/bj<<bel_picnic>>.gif', 'Вы садитесь на корточки в центр круга и начинаете обрабатывать своим ротиком четыре члена.'
					fuckerrand = rand(1,4)
					gmember = fuckerrand
					gs 'belyi_events','selection'
					''
					if rand(0,1) = 0:
						gs 'zz_render', '', '', 'Внезапно вас отрывают от отсоса и <<$boy>> кладет вас на спину'
						act'Лечь на спину': gt 'belyi_events','gang_2'
					else
						gs 'zz_render', '', '', 'Внезапно вас отрывают от отсоса и <<$boy>> ставит вас раком'
						act'Встать раком': gt 'belyi_events','gang_3'
					end
				end
			end
		else
			gs 'zz_render', '', 'pavlovo/belyi/gang/dance_shy<<bel_picnic>>.jpg', 'Вы, жутко стесняясь и краснея, ощущая на себе обжигающие взгляды бандюков, начали стягивать с себя одежду, даже не думая о танце, и стараясь прикрыться руками. Один из бандюков воскликнул:**\\\- Стеснительная? Ничё, ща мы это быстро исправим!'
			act'Далее': gt 'belyi_events','gang_4'
		end
	end
end
if $args[0] = 'gang_2':
	cla & *clr
	gs 'belyi_events','selection'
	times_picknick -= 1
	pose = 0
	gs 'zz_render', '', 'pavlovo/belyi/gang/mis'+iif(bel_picnic = 1,rand(0,2),rand(3,5))+'.gif'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	if gmember = 1: sashaBeliTimes -= 1
	if gmember = 2: sipliGangTimes -= 1
	if gmember = 3: kolGangTimes -= 1
	if gmember = 4: tatarGangTimes -= 1
	times_picknick = sashaBeliTimes + sipliGangTimes + kolGangTimes + tatarGangTimes
	if times_picknick <= 0:
		act'Встать': gt 'belyi_events','gang_end'
	else
		gs 'belyi_events','search'
		gs 'belyi_events','selection'
		if rand(0,1) = 0:
			gs 'zz_render', '', '', '<<$boy>> кладет вас на спину.'
			act'Лечь на спину': gt 'belyi_events','gang_2'
		else
			gs 'zz_render', '', '', '<<$boy>> ставит вас раком.'
			act'Встать раком': gt 'belyi_events','gang_3'
		end
	end
end
if $args[0] = 'gang_3':
	cla & *clr
	gs 'belyi_events','selection'
	times_picknick -= 1
	pose = 1
	if rand(0,1) = 0:
		gs 'zz_render', '', 'pavlovo/belyi/gang/dog'+iif(bel_picnic = 1,rand(0,2),rand(3,5))+'.gif'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
	else
		gs 'zz_render', '', 'pavlovo/belyi/gang/anal'+iif(bel_picnic = 1,rand(0,2),rand(3,5))+'.gif'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_dynamic_sex', 'anal_cum'
	end
	if gmember = 1: sashaBeliTimes -= 1
	if gmember = 2: sipliGangTimes -= 1
	if gmember = 3: kolGangTimes -= 1
	if gmember = 4: tatarGangTimes -= 1
	times_picknick = sashaBeliTimes + sipliGangTimes + kolGangTimes + tatarGangTimes
	if times_picknick <= 0:
		act'Встать': gt 'belyi_events','gang_end'
	else
		gs 'belyi_events','search'
		gs 'belyi_events','selection'
		if rand(0,1) = 0:
			gs 'zz_render', '', '', '<<$boy>> кладет вас на спину'
			act'Лечь на спину': gt 'belyi_events','gang_2'
		else
			gs 'zz_render', '', '', '<<$boy>> ставит вас раком'
			act'Встать раком': gt 'belyi_events','gang_3'
		end
	end
end
if $args[0] = 'gang_4':
	cla & *clr
	if sashaBeliSex = 0: sashaBeliSex = 1 & guy += 1
	if sipliGangSex = 0: sipliSex = 1 & guy += 1
	if kolGangSex = 0: kolGangSex = 1 & guy += 1
	if tatarGangSex = 0:tatarGangSex = 1 & guy += 1
	gang += 1
	bj += 2
	minut += 5
	gs'stat'
	vagmembergang = rand(1,4)
	if vagmembergang = 1:
		dick = 15
		$boy = 'Белый'
		silavag = 0
	elseif vagmembergang = 2:
		dick = 18
		$boy = 'Сиплый'
		silavag = 1
	elseif vagmembergang = 3:
		dick = 21
		$boy = 'Кол'
		silavag = 0
	else
		dick = 17
		$boy = 'Татарин'
		silavag = 1
	end
	:markpoiskanalmembergang
	analmembergang = rand(1,4)
	if analmembergang = 1:
		dick2 = 15
		$boy2 = 'Белый'
		silavag2 = 0
	elseif analmembergang = 2:
		dick2 = 18
		$boy2 ='Сиплый'
		silavag2 = 1
	elseif analmembergang = 3:
		dick2 = 21
		$boy2 = 'Кол'
		silavag2 = 0
	else
		dick2 = 17
		$boy2 = 'Татарин'
		silavag2 = 1
	end
	if vagmembergang = analmembergang: jump'markpoiskanalmembergang'
	gs 'zz_render', '', 'pavlovo/belyi/gang/dp'+iif(bel_picnic = 1,rand(0,2),rand(3,5))+'.gif', '<<$boy>> сажает вас на себя готовясь войти вам во влагалище. <<$boy2>> устраивается сзади вас готовясь войти в вашу попу, а оставшиеся двое бандитов подставляют вам свои члены ко рту...'
	gs 'zz_dynamic_sex', 'dp_start'
	gs 'zz_dynamic_sex', 'double_penetration'
	gs 'zz_render', '', '', 'Вас скидывают на траву и бандиты становятся в круг над вами надрачивая члены...'
	act'Сидеть':
		cla & *clr
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_render', '', 'pavlovo/belyi/gang/cum<<bel_picnic>>.gif', 'Горяие струи спермы начинают подать вам на лицо, в глаза, растекатmся по щекам и затекать в рот. Наконец-то бандюки прекращают кончать и оставляют вас в покое...'
		act'Встать': gt 'belyi_events','gang_end'
	end
end
if $args[0] = 'gang_end':
	cla & *clr
	minut += 60
	i = rand(1,100)
	gs 'zz_render', '', 'pavlovo/belyi/gang/picnic_end'+iif(i < 60,'',bel_picnic)+'.jpg', 'Бандиты начали собираться обратно, громхо хохоча и обсуждая прошедшую гулянку.'
	if belgangPay > 0:
		belgangPay -= 1000
		if belgangPay > 0:
			gs 'zz_render', '', '', 'Белый сказал, что вы отработали тысячу и вам осталось отработать <<belgangPay>> рублей.'
		else
			belgangQW = 1
			gs 'zz_render', '', '', 'Белый сказал ,что вы полностью отработали долг.'
		end
	end
	if i < 60:
		bel_picnic = 0
		minut += 30
		gs 'zz_render', '', '', 'Вас затолкали в багажник и БМВ помчался обратно в Павлово. Белый с трудом управлял машиной и в Павлово вы кое-как доехали, на окраине Павлово, бандиты открыли багажник машины и пинками выкинули вас на улицу.'
		act 'Выйти':gt'gorodok'
	else
		gs 'zz_render', '', '', 'Сиплый поглядев на вас сказал:**\\\- Нахуй, пускай шалава сама домой добирается!///**После этого бандюганы сели в машину и уехали бросив вас в лесу.'
		act 'Идти к дороге':
			nroad = iif(bel_picnic = 1,rand(1,4)*5,40)
			bel_picnic = 0
			gt'road'
		end
	end
end
if $args[0] = 'bottle_vag_light':
	cla & *clr
	minut += 5
	dick = 10
	protect = 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/gang/bottle_vag_light<<bel_picnic>>.gif'
	gs 'zz_dynamic_sex','sex_start', 1
	gs 'zz_dynamic_sex','vaginal','bottle'
	''
	if rand(1,100) <= 10:
		gs 'zz_render', '', '', 'Один из бандитов недовольно говорит:**\\\- Хуй с тобой шалава, сейчас мы сами тебя распечатаем...///'
		act'Далее': gt 'belyi_events','gang_2'
	else
		gs 'zz_render', '', '', 'Сиплый недоумевая спросил:**\\\- Это че за хуйня? Не еби мозг шалава, давай по нормальному!///'
		if vagina > 10: act'Засунуть себе бутылку донышком во влагалище': gt 'belyi_events','bottle_vag_hard'
		act'Засунуть себе бутылку горлышком в попу': gt 'belyi_events','bottle_anal_light'
		if anus > 10:act'Засунуть себе бутылку донышком в попу': gt 'belyi_events','bottle_anal_hard'
	end
end
if $args[0] = 'bottle_vag_hard':
	cla & *clr
	minut += 5
	dick = 40
	protect = 1
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/gang/bottle_vag_hard<<bel_picnic>>.gif'
	gs 'zz_dynamic_sex','sex_start', 1
	gs 'zz_dynamic_sex','vaginal','bottle'
	''
	if rand(1,100) <= 80:
		gs 'zz_render', '', '', 'Один из бандитов хмыкая говорит:**\\\- Хуй с тобой шалава, сейчас мы сами тебя распечатаем...///'
		act'Далее': gt 'belyi_events','gang_2'
	else
		gs 'zz_render', '', '', 'Сиплый недоумевая спросил:**\\\- Это че за хуйня? Не еби мозг шалава, давай в задницу пихай!///'
		act'Засунуть себе бутылку горлышком в попу': gt 'belyi_events','bottle_anal_light'
		if anus > 10:act'Засунуть себе бутылку донышком в попу': gt 'belyi_events','bottle_anal_hard'
	end
end
if $args[0] = 'bottle_anal_light':
	cla & *clr
	minut += 5
	dick = 10
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/gang/bottle_anal_light<<bel_picnic>>.gif'
	gs 'zz_dynamic_sex','anal_start','bottle'
	gs 'zz_dynamic_sex','anal','bottle'
	''
	if rand(1,100) <= 50 or anus <= 10:
		gs 'zz_render', '', '', 'Один из бандитов хмыкая говорит:**\\\- Хуй с тобой шалава, сейчас мы сами тебя распечатаем...///'
		act'Далее': gt 'belyi_events','gang_3'
	else
		gs 'zz_render', '', '', 'Сиплый недоумевая спросил:**\\\- Это че за хуйня? Не еби мозг шалава, давай донышком в задницу пихай!///'
		act'Засунуть себе бутылку донышком в попу': gt 'belyi_events','bottle_anal_hard'
	end
end
if $args[0] = 'bottle_anal_hard':
	cla & *clr
	minut += 5
	dick = 40
	gs'stat'
	gs 'zz_render', '', 'pavlovo/belyi/gang/bottle_anal_hard<<bel_picnic>>.gif'
	gs 'zz_dynamic_sex','anal_start','bottle'
	gs 'zz_dynamic_sex','anal','bottle'
	gs 'zz_render', '', '', 'Сиплый ржет:**\\\- Рабочая жопа, надо опробовать, ну чё пацаны, отжарим эту блядь в четыре ствола?///'
	act'Далее': gt 'belyi_events','gang_4'
end
if $args[0] = 'selection':
	if gmember = 1:
		dick = 15
		$boy ='Белый'
		silavag = 0
	end
	if gmember = 2:
		dick = 18
		$boy = 'Сиплый'
		silavag = 1
	end
	if gmember = 3:
		dick = 21
		$boy = 'Кол'
		silavag = 0
	end
	if gmember = 4:
		dick = 17
		$boy= 'Татарин'
		silavag = 1
	end
end
if $args[0] = 'search':
	gm = gmember
	:markpoisk_gmember
	gm += 1
	if gm > 4:gm = 1
	if gm = 1 and sashaBeliTimes = 0: jump'markpoisk_gmember'
	if gm = 2 and sipliGangTimes = 0: jump'markpoisk_gmember'
	if gm = 3 and kolGangTimes = 0: jump'markpoisk_gmember'
	if gm = 4 and tatarGangTimes = 0: jump'markpoisk_gmember'
	if gm = 1 and sashaBeliTimes > 0 or gm = 2 and sipliGangTimes > 0 or gm = 3 and kolGangTimes > 0 or gm = 4 and tatarGangTimes > 0: gmember = gm
end