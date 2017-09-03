if $ARGS[0] = 'dress_after_sauna':
	gs 'zz_clothing', 'redress', prev_clothing
	tanga = flag_tanga
	prev_clothing = -1
	gt 'Gadbana'
end
if $ARGS[0] = 'chickens':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/gadukino/new/chickens1.jpg','Обычные деревенские куры.'
	!задание бабушки
	if feed_chickens = 1:
		act 'Покормить кур':
			cla
			*clr
			minut += 30
			grandmahelp += 1
			grandmaQW += 1
			feed_chickens = 0
			manna += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/gadukino/new/chickens2.jpg','Вы насыпали птицам зерна и они тут же бросились его клевать. Посмотрев на них немного вы отправились по своим делам.'
			act 'Закончить':gt'Gaddvor'
		end
	end
	act 'Уйти': gt'Gaddvor'
end
if $ARGS[0] = 'boar':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', 'Сарай', 'qwest/gadukino/new/boar.jpg','Гордость дедушки и бабушки - Кабан Пятак.'
	if feed_boar = 1:
		act 'Покормить кабана':
			cla
			*clr
			minut += 30
			grandmahelp += 1
			feed_boar = 0
			grandpaQW += 1
			gs 'stat'
			gs 'zz_render', '', 'qwest/gadukino/new/feed_boar.jpg','Вы покормили Пятака и отправились по своим делам.'
			act 'Закончить': gt'Gadsarai'
		end
	end
	act 'Уйти': minut += 5 & gt'Gadsarai'
end
if $ARGS[0] = 'cow':
	*clr & cla
	gs 'zz_render', 'Сарай', 'qwest/gadukino/new/cow.jpg','Бабушкина любимица - корова Зорька.'
	if milk_cow = 1:
		act 'Подоить корову':
			cla
			*clr
			minut += 30
			milk_cow = 0
			grandmahelp += 1
			grandmaQW += 1
			gs 'stat'
			gs 'zz_render', 'Сарай', 'qwest/gadukino/new/milk_cow.jpg','Вы, в течение часа доили, буренку и с каждым разом у вас получается все лучше и лучше.'
			act 'Закончить':gt'Gadsarai'
		end
	end
	if feed_cow = 1:
		act 'Покормить корову':
			cla
			*clr
			minut += 30
			feed_cow = 0
			grandmahelp += 1
			grandpaQW += 1
			gs 'stat'
			gs 'zz_render', '', 'qwest/gadukino/new/feed_cow.jpg','Вы покормили Зорьку и отправились по своим делам.'
			act 'Закончить':gt'Gadsarai'
		end
	end
	if cow_field = 1 or graze_cow = 1:
		act 'Отвести корову к стаду':
			cla
			*clr
			minut += 60
			cow_field = 0
			grandmahelp += 1
			grandpaQW += 1
			gs 'stat'
			gs 'zz_render', '', 'qwest/gadukino/new/cow_field.jpg', iif(cow_field = 1,'Взяв корову вы отправились на поле, где отдали её пастухам.','Взяв корову вы отправились на поле, где вас уже ждал дед и стадо коров.')
			act 'Далее':gt'gadfield','graze_field'
		end
	end
	act 'Уйти':minut += 5 & gt'Gadsarai'
end
if $ARGS[0] = 'horse':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'gadukino/horse/horse.jpg','Дедушкин помощник - конь Буян.'
	if feed_horse = 1:
		act 'Покормить коня':
			*clr & cla
			minut += 30
			feed_horse = 0
			grandmahelp += 1
			grandpaQW += 1
			gs 'stat'
			gs 'zz_render', 'Сарай', 'gadukino/horse/feed.jpg','Вы покормили коня и отправились по своим делам.'
			act 'Закончить':gt'Gadsarai'
		end
	end
	if horse_field = 1:
		act 'Отвести коня на поле':
			*clr & cla
			minut += 60
			horse_field = 0
			grandmahelp += 1
			grandpaQW += 1
			gs 'stat'
			gs 'zz_render', 'Буян', 'gadukino/horse/lead.jpg','Вы взяли коня под уздцы и отправились с ним на поле. Там, привязав его к штырю, отправились по своим делам.'
			act 'Далее':gt'gadfield','field'
		end
	end
	if horse_river = 1 and sunWeather >= 0 and temper >= 20:
		act 'Отвести коня на реку':
			*clr & cla
			minut += 30
			horse_river = 2
			gs 'stat'
			gs 'zz_render', 'Буян', 'gadukino/horse/lead.jpg','Вы взяли коня под уздцы и отправились с ним к реке.'
			act 'Далее':gt 'gadbeach'
		end
	end
	if comb_horse = 1:
		act 'Расчесать коня':
			*clr & cla
			minut += 60
			comb_horse = 0
			grandmahelp += 1
			grandpaQW += 1
			gs 'stat'
			gs 'zz_render', 'Сарай', 'gadukino/horse/comb.jpg','В течение часа вы расчесывали Буяна. В итоге, закончив, вы, довольная результатом, отправились по своим делам.'
			act 'Далее': gt'Gadsarai'
		end
	end
	act 'Уйти': minut += 5 & gt 'Gadsarai'
end
if $ARGS[0] = 'mira_dog':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Сарай', 'qwest/gadukino/new/Mira_kennel2.jpg','Около будки Пирата на цепи сидит голая Мира и изображает собачку.'
	act 'Отпустить':
		cla
		*clr
		minut += 5
		mira_dog = 0
		gs 'stat'
		gs 'zz_render', 'Сарай', 'qwest/gadukino/new/Mira_kennel3.jpg','Сжалившись, вы решаете отпустить Миру раньше срока.'
		'- Ладно Мира, добрая я сегодня. Можешь считать себя прощенной, - сказали вы, снимая с Миры ошейник.'
		'Девушка еще пару мгновений смотрит на вас, потом быстро одевается и убегает домой.'
		act 'Далее':gt'Gadsarai'
	end
	act 'Уйти': gt'Gadsarai'
end
if $ARGS[0] = 'mira_courtyard':
	cla
	*clr
	mira_guestday = daystart
	minut += 5
	mira_guest = 1
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render', '', '','Вы вышли во двор и заметили идущую на встречу Мирославу.**\\\ - О, <<$name[1]>> привет, а я к тебе в гости. Заскучала совсем одна дома, -/// сказала она улыбаясь.'
	act 'Далее':gt'Gaddvor'
end
if $ARGS[0] = 'mira_house':
	*clr & cla
	mira_guestday = daystart
	minut += 5
	mira_guest = 1
	gs 'stat'
	dynamic $miraclothes
	gs 'zz_render', '', '','Вы были в избе, когда заметили входящую Мирославу.**\\\- Тук-тук, <<$name[1]>> привет, я к тебе в гости. А то заскучала совсем одна дома, -/// сказала она улыбаясь.'
	act 'Далее':gt'Gadhouse'
end
if $ARGS[0] = 'courtyard_nude':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'qwest/gadukino/new/'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'gaddvor_nude' ,'gadukino_back_night')+'.jpg',iif(grandpa_ingaddvor = 0,'Вы зашли во двор и никого не встретив отправились в избу.','Вы вышли во двор и сразу наткнулись на дедушку...')
	if grandpa_ingaddvor = 0:
		act 'Идти в избу': gt 'Gadhouse'
	else
		act 'Далее': gt 'grandpa'
	end
end
if $ARGS[0] = 'garden_nude':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', $_str, 'qwest/gadukino/new/'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'gadgarden_nude' ,'gadukino_back_night')+'.jpg'
	if grandma_ingadgarden = 1 and grandpa_ingadgarden = 1:
		gs 'zz_render', '', '','Зайдя на на огород вы сразу же столкнулись с бабушкой и дедушкой. Дедушка округлив в удивлении глаза, а бабушка тут же кинулась к вам..'
		act 'Далее': gt 'grandma'
	elseif grandma_ingadgarden = 1 and grandpa_ingadgarden = 0:
		gs 'zz_render', '', '','Зайдя на на огород вы сразу же наткнулись на бабушку...'
		act 'Далее': gt 'grandma'
	else
		gs 'zz_render', '', '','Вы прошли по огороду, никого не встретив, и отправились во двор.'
		act 'Выйти во двор': gt 'Gaddvor'
	end
end
if $ARGS[0] = 'market':
	*clr & cla
	minut += 20
	grandmaQW += 1
	pranik += 10
	gs 'stat'
	gs 'zz_render','','qwest/gadukino/grandma.jpg','Вы зашли в магазин и увидели свою бабулю. Заметив вас, она улыбнулась.**<do>- <<$name[3]>>, хорошо, что ты зашла. Иди, я тебе гостинца куплю, -</do> сказала она, и купив упаковку печенья, протянула вам.**<dh>- Спасибо, бабуль, -</dh> ответили вы, и поцеловав бабушку в щёку, отошли.'
	act 'Далее':gt 'gadmarket'
end
if $ARGS[0] = 'villagecat':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'gadukino/cat/cat.jpg','Упитанный котяра даже не смотрит на вас, хотя знает, что вы рядом.'
	act 'Погладить':
		*clr & cla
		minut += 5
		manna += 10
		gs 'stat'
		gs 'zz_render', '', 'gadukino/cat/pat.jpg','Вы нежно ерошите кота за ушами, на что тот довольно мурлычит, но сразу же прекращает, едва вы перестаете.'
		act 'Уйти': gt 'Gadhouse'
	end
	act 'Уйти': gt 'Gadhouse'
end
if $ARGS[0] = 'talk_pay':
	*clr & cla
	monthbabkapay = 1
	money += 2000
	minut += 10
	monthgrandmahelp = month
	gs 'stat'
	gs 'zz_render', 'Бубушка', 'qwest/gadukino/new/grandmahelp.jpg','Войдя в избу, вы видите вашу любимую бабулю и с визгом бросаетесь ей на шею. Наконец наобнимавшись вы отрываетесь от неё. Бабушка осмотрев вас со всех сторон (естественно заметив, что у вас только кожа да кости), начала разговор.**\\\- Как ты выросла внучка. Взрослая уже почти. А мы с дедом все стареем и стареем, помогать нам уже нужно, сами почти ничего и не можем. Давай <<$name[3]>> договоримся так: ты нам будешь помогать по хозяйству по мере сил и возможностей, а мы с дедом будем тебе денюжку платить какую-никакую. И ты к работе и взрослой жизни привыкать будешь и нам помощь. Согласна?///**\\- Конечно буду помогать бабуль, -// с готовновностью ответили вы.**\\\- Ну вот и хорошо <<$name[2]>>, а для начала мы тебе немного авансом дадим, -/// сказала бабушка и протянула две тысячи.**Поблагодарив и чмокнув бабушку в щеку вы отправились по своим делам.'
	act 'Далее': gt 'Gadhouse'
end
if $ARGS[0] = 'grandpa_boletus':
	*clr & cla
	grandmahelp += 1
	boletus -= grandpa_boletus
	minut += 5
	go_in_boletus = 0
	grandpaQW += 1
	gs 'stat'
	gs 'zz_render', 'Дедушка', 'qwest/gadukino/grandpa1.jpg','Войдя в избу, вы сразу подходите к дедушке:**\\- Деда, вот грибы!//**\\\- Ой, спасибо внучка, порадовала старика, -/// ответил дедушка.\\\ - Нам то с бабкой до леса трудновато дойти, а грибочков иногда хочется.///**\\- Ну, если нужно, я еще могу сбегать, -// с готовностью сказали вы.\**\\\- Сейчас не нужно, <<$name[3]>>, -/// улыбнулся дед.\\\ - Но если что, я буду иметь ввиду.///**Чмокнув деда в щеку, вы отправились по своим делам.'
	act 'Далее': grandpa_boletus = 0 & gt 'Gadhouse'
end
if $ARGS[0] = 'grandpa_boletus_bilberry':
	*clr & cla
	grandmahelp += 1
	boletus -= grandpa_boletus
	bilberry -= grandpa_bilberry
	minut += 5
	go_in_boletus_bilberry = 0
	grandpaQW += 1
	gs 'stat'
	gs 'zz_render', 'Дедушка', 'qwest/gadukino/grandpa1.jpg','Войдя в избу, вы сразу подходите к дедушке:**\\- Деда, вот грибы и ягоды!//**\\\- Ой, спасибо внучка, порадовала старика, -/// ответил дедушка.**\\- Если нужно, я еще могу сбегать, -// с готовностью сказали вы.**\\\- Сейчас не нужно, <<$name[3]>>, -/// улыбнулся дед.\\\ - Но если что, я буду иметь ввиду.///**Чмокнув деда в щеку, вы отправились по своим делам.'
	act 'Далее': grandpa_boletus = 0 & grandpa_bilberry = 0 & gt 'Gadhouse'
end
if $ARGS[0] = 'grandpa_bilberry':
	*clr & cla
	grandmahelp += 1
	bilberry -= grandpa_bilberry
	minut += 5
	go_in_bilberry = 0
	grandpaQW += 1
	gs 'stat'
	gs 'zz_render', 'Дедушка', 'qwest/gadukino/grandpa1.jpg','Войдя в избу, вы сразу подходите к дедушке.**\\- Деда, вот ягоды!//**\\\- Ой, спасибо внучка, порадовала старика, - ответил дедушка.\\\ - Нам то с бабкой трудно за ягодами ходить, а варенье на зиму варить нужно.///**\\- Ну, если нужно, я еще могу сбегать, -// с готовностью сказали вы.**\\\- Сейчас не нужно, <<$name[3]>>, -/// улыбнулся дед.\\\ - Но если что, я буду иметь ввиду.///**Чмокнув деда в щеку, вы отправились по своим делам.'
	act 'Далее': grandpa_bilberry = 0 & gt 'Gadhouse'
end
if $ARGS[0] = 'talk_swamp':
	*clr & cla
	minut += 5
	forester = 0
	gs 'zz_render', 'Бабушка', 'qwest/gadukino/grandma.jpg'
	if back_swamp = 0:
		back_swamp = 1
		grandmaQW += 1
		gs 'zz_render', '', '','В избе вас уже ждала бабушка, с опухшими от слез глазами.**\\\- <<$name[3]>> ты где пропадала? -/// кинулась она к вам.\\\ - Мы с дедом с ног сбились, разыскивая тебя. Уже не знали, что и подумать...///**\\- Ба, ээээ... ну так вышло, -// начали мямлить вы, пытаясь как-то сгладить свой безответственный поступок.\\ - Я в лесу была... потом на болото попала... ну и задержалась немного у охотников в избушке.//**\\\- Совести у тебя нету <<$name>>, -/// сказала бабушка, все еще тиская и ощупывая вас, как будто проверяла, все ли части тела на месте.\\\ - Вот если бы с тобой что-нибудь случилось, чтобы мы с дедом делали? Чтобы матери твоей сказали? Ты о нас с ней хоть подумала?///**\\- Бабуль, ну не плачь, -// обняли в ответ вы бабушку, чувствуя, что глаза самопроизвольно начинают наполняться слезами.\\ - Я больше так не буду... честно-честно.//**Проплакав и пообнимавшись еще какое-то время вы наконец с бабушкой разошлись.'
	else
		grandmaQW -= 20
		grandpaQW -= 20
		gs 'zz_render', '', '','В избе вас уже ждала бабушка, глядя на вас с укоризной.**\\\- <<$name[1]>> ты же обещала... -/// только и произнесла она.**\\- Бабуль... -// начали вы, но она уже отвернулась и занялась своими делами.'
	end
	act 'Далее':gt'Gadhouse'
end