$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs'stat'
gs'time'
!шанс появления охотников
if week = 6 or week = 7:hantersrand = RAND(1,3)
if week < 6:hantersrand = RAND(1,5)
if hantersrand = 1:hanters = 1
!шанс приставания к ГГ, если она давалка
hantslutsexrand = rand(1,3)
! для запоминания были трусы или нет
if lost_girl = 0:lost_girl += rand(40,60)
temp = rand(1,10)
gs 'zz_render', 'Поляна с избушкой', func('zz_funcs','mk_image','qwest/gadukino/Swamp/swamp_yard'),'Поляна с избушкой посреди болота.**За избушкой есть <a href="exec:minut += 5 & gt ''swampspring'' ">родник</a>, а немного дальше есть небольшая <a href="exec:minut += 5 & gt ''backwater'' ">заводь</a> с относительно чистой водой.'
if findvel = 3:gs 'zz_render', '', '','Возле избушки стоит старый <a href="exec:gt ''bicycle'',''swamp''">велосипед</a>.'
if clearclothes > 0 and clearclothesH = 0: gs 'zz_render', '', '','На поляне сушится ваша одежда.'
if hanters > 0 and hantersKnow = 0:gs 'zz_render', '', '','На поляне вы видите незнакомых <a href="exec: gt ''hanters'' ">людей</a>.'
if hanters > 0 and hantersKnow > 0 and hour >= 8 and hour < 20:gs 'zz_render', '', '','На поляне вы видите знакомых <a href="exec: gt ''hanters'' ">охотников</a>.'
act 'Идти в избу':minut += 5 & gt'swamphouse'
if dirty_swamp_yard > 10:act 'Убираться во дворе':hanterslut -= 1 & dynamic $dirty_swamp_yard
act '<b>Идти на болото</b>':
    if hanters = 1:
        if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):
            minut += 5
            gt 'swamp'
        else
            *clr & cla
            gs'stat'
            gs 'zz_render', 'Игорь', 'qwest/gadukino/Swamp/IgorHanter.jpg','Вы собрались идти в лес, когда вас окликнул Игорь.**\\\- <<$name[1]>>, это не самое лучшее время чтобы ходить по лесу, переночуй лучше тут.///'
            act 'Остаться':gt 'swamp_yard'
            act 'Да ладно, дойду как-нибудь':minut += 5 & gt 'swamp'
        end
    else
        minut += 5
        gt 'swamp'
    end
end
! Охотники спасли ГГ из болота
if hanterhelp = 1:
	*clr & cla
	minut += 5
	gs'stat'
	if current_clothing > 0:
		'<center><img src="images/qwest/gadukino/Swamp/hanterhelp.jpg"></center>'
	else
		'<center><img src="images/qwest/gadukino/Swamp/hanterhelp1.jpg"></center>'
	end
	if current_clothing = 0 and hantersKnow = 0:'- Ну нифига себе мы русалку выловили! - услышали вы чей-то удивлённый голос.'
	if current_clothing = 0 and hantersKnow = 1 and hantersKnowSlut = 0:'- <<$name[1]>>, опять ты голышом бегаешь по лесу! - покачал головой Андрей.'
	if current_clothing = 0 and hantersKnow = 1 and hantersKnowSlut = 1:'- О! Опять наша шлюшка в сети попалась, и в самом потребном виде! - заржал Андрей.'
	if hantersKnow = 0:'Вас отволокли на сухое место. Какое-то время вы ничего не соображали, просто тупо смотрели перед собой и пытались отдышаться. Немного отдохнув вы решаете все таки узнать куда вы попали и кто вас спас.'
	if hantersKnow = 1:'Вас отволокли на сухое место. Какое-то время вы ничего не соображали, просто тупо смотрели перед собой и пытались отдышаться. Немного отдохнув вы отправились на поляну перед избушкой.'
	''
	if hantersKnow = 0:act 'Осмотреться':hanterhelp = 2 & gt 'swamp_yard'
	if hantersKnow = 1:act 'Далее':hanterhelp = 0 & gt 'swamp_yard'
end
if hanterhelp = 2 and hantersKnow = 0:
	*clr & cla
	minut += 5
	hantersKnow = 1
	hantersAndreiQw += 1
	hantersIgorQw += 1
	hantersSergeiQw += 1
	gs'stat'
	if current_clothing > 2:
		*clr & cla
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterhelp2.jpg"></center>'
		'Вы увидели трех мужчин, которые переговаривались между собой. Увидев, что вы более или менее пришли в себя, они подошли к вам поближе.'
		if vnesh >= 40:'-Ну что, оклемалась чутка? Как звать-величать то тебя, красавица?- спросил один из них.'
		if vnesh < 40:'-Ну что, оклемалась чутка? Как звать-величать то тебя?- спросил один из них.'
		'- <<$name[1]>>, - ответили вы.'
		if gadriver_gang = 0:
			'-А я Андрей, - ответил ответил мужчина постарше, - а это друзья мои из центра, Игорь и Сергей.'
			'-А твоя фамилия не <<$surname>> случайно? - спросил он. Вы удивленно посмотрели на него и кивнули.'
			'-Не удивляйся <<$name[1]>>, ты очень похожа на маму в молодости. А я её ... Хммм... очень хорошо знал когда-то, я ведь тоже из Гадюкино.- сказал Андрей.'
			if sweat > 0 or dirtyclothes = 1:
				'-Ты иди пока помойся и постирай одежку, а то грязная совсем,- продолжил Андрей.'
				'-А где?'
				'-Ну летом, пока тепло помыться можно и в затоне, что за избушкой, а можно и в ней самой. Тазик там есть, воду возьмешь в роднике и нагреешь на печке, - ответил Андрей.- А вот в холода только в избушке и можно.'
				'-Постираться можно в избушке. Опять же, вода в роднике, греешь на печке и стираешь, - продолжил он.- Можно конечно и в заводи, но там только слегка отчиститься получится.'
			else
				'-Да ты не стесняйся, присаживайся, в ногах правды нет.- сказал Сергей, освобождая для вас место.'
			end
		else
			'- Ба, кого к нам занесло - удивлённо протянул мужчина постарше, - это же <<$name[1]>> <<$surname>>, местная шлюшка.'
			'Вы удивленно посмотрели на него.'
			'-Не удивляйся, я ведь тоже из Гадюкино, а ты очень похожа на маму в молодости, и судя по всему такая же блядоватая.- сказал он.'
			'-Я Андрей, - добавил он дальше, - а это друзья мои из центра, Игорь и Сергей.'
			if sweat > 3 or dirtyclothes = 1:
				hantersKnowSlut = 1
				hantersRape = 1
				'-Ты иди пока помойся и постирай одежку, а то грязная совсем,как кикимора болотная... смотреть противно- продолжил Андрей. - А мы пока подумаем, как с тобой быть.'
				'-А где?'
				'-Ну летом, пока тепло помыться можно и в затоне, что за избушкой, а можно и в ней самой. Тазик там есть, воду возьмешь в роднике и нагреешь на печке, - ответил Андрей.- А вот в холода только в избушке и можно.'
				'-Постираться можно в избушке. Опять же, вода в роднике, греешь на печке и стираешь, - продолжил он.- Можно конечно и в заводи, но там только слегка отчиститься получится.'
			else
				hantersKnowSlut = 1
				hantersRape = 1
				'-Да ты не стесняйся, присаживайся,в ногах правды нет.- сказал Сергей, с ехиднойулыбкой освобождая для вас место.'
			end
		end
	else
		'<center><img src="images/qwest/gadukino/Swamp/hanterhelp3.jpg"></center>'
		'Вы увидели трех мужчин, которые переговаривались между собой. Увидев, что вы более или менее пришли в себя, они направились в вашу сторону. Вы сообразив, что находитесь совершенно голая перед тремя незнакомыми мужчинами тихонько ойкнув начали прикрываться руками, незная куда деваться от стыда'
		'- Очухалась?- спросил один из них и протянул вам кусок какой-то ткани. - На вот прикройся, нечего нас смущать своими прелестями.'
		'-Как звать-величать тебя, красавица?- спросил другой.'
		'- <<$name[1]>>, - ответили вы.'
		if gadriver_gang = 0:
			'-А я Андрей, - ответил ответил мужчина постарше, - а это друзья мои из центра, Игорь и Сергей.'
			'-А твоя фамилия не <<$surname>> случайно? - спросил он. Вы удивленно посмотрели на него и кивнули.'
			'-Не удивляйся <<$name[1]>>, ты очень похожа на маму в молодости. А я её ... Хммм... очень хорошо знал когда-то, я ведь тоже из Гадюкино.- сказал Андрей.'
			if sweat > 0:
				'-Ты иди пока помойся, а мы тебе пока одежку какую подыщем,- продолжил Андрей.'
				'-А где?'
				'-Ну летом, пока тепло можно и в затоне, что за избушкой, а можно и в ней самой. Тазик там есть, воду возьмешь в роднике и нагреешь на печке, - продолжил Андрей.- А вот в холода только в избушке и можно.'
			else
				'-Да ты не стесняйся, присаживайся,в ногах правды нет.- сказал Сергей, освобождая для вас место.- А мы тебе пока одежку какую подыщем.'
			end
		else
			'-Ба, кого к нам занесло - удивлённо протянул мужчина постарше, - это же <<$name[1]>> <<$surname>>, местная шлюшка.'
			'Вы удивленно посмотрели на него.'
			'-Не удивляйся, я ведь тоже из Гадюкино, ты очень похожа на маму в молодости, такая же блядоватая.- сказал он.'
			' Я Андрей, - добавил он дальше, - а это друзья мои из центра, Игорь и Сергей.'
			if sweat > 0:
				*clr & cla
				gs'stat'
				hantersRape = 1
				hantersKnowSlut = 1
				'-Ты иди пока помойся, нечего тут на всю поляну вонять,- продолжил Андрей. - А мы пока подумаем, как с тобой быть.'
				'-А где?'
				'-Ну летом, пока тепло можно и в затоне, что за избушкой, а можно и в ней самой. Тазик там есть, воду возьмешь в роднике и нагреешь на печке, - продолжил Андрей.- А вот в холода только в избушке и можно.'
			else
				'-Да ты не стесняйся, присаживайся,в ногах правды нет.- сказал Сергей, освобождая для вас место.- Подумаем, как с тобой быть.'
				hantersKnowSlut = 1
				hantersRape = 1
			end
		end
	end
	!swamp_cloth - временная одежда если ГГ пришла голая
	if current_clothing = 0 and hantersKnowSlut = 0:
		act 'Уйти':
			*clr & cla
			hanterhelp = 0
			swamp_cloth = 1
			hanters = 1
			gs 'zz_clothing', 'redress', 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/tkan_cloth.jpg"></center>'
			'Вы, поблагодарив их, быстро прикрылись куском мешковины... Ну хоть что-то.'
			act'Далее':gt'swamp_yard'
		end
		act 'Присесть':
			*clr & cla
			hanterhelp = 0
			swamp_cloth = 1
			hanters = 1
			gs 'zz_clothing', 'redress', 1
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/tkan_cloth.jpg"></center>'
			'Вы, поблагодарив их, быстро прикрылись куском мешковины... Ну хоть что-то.'
			act'Далее':gt'hanters'
		end
	else
		act 'Уйти':hanters = 1 & hanterhelp = 0 & gt 'swamp_yard'
		act 'Присесть':hanters = 1 & hanterhelp = 0 & gt 'hanters'
	end
end
!просьба охотников по уборке в доме
if hanters > 0 and hantersKnow = 1 and hour >= 8 and hour < 20 and dirty_swamphouse > 5 and temp = 2:
	*clr & cla
	temp = rand(1,3)
	minut += 5
	if temp = 1:$boy = 'Андрей'
	if temp = 2:$boy = 'Сергей'
	if temp = 3:$boy = 'Игорь'
	gs'stat'
	if temp = 1:'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	if temp = 2:'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
	if temp = 3:'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
	'Вы шли по своим делам, когда к вам подошел <<$boy>>.'
	if hantersKnowSlut = 0:'-<<$name[2]>>,- сказал он. - В доме такой бардак, может уберешься? А то нам с парнями все некогда.'
	if hantersKnowSlut = 1:'-<<$name[1]>>,- сказал он. - В доме такой бардак, иди-ка наведи там марафет.'
	act 'Убираться в избушке':hanterslut -= 1 & dynamic $dirty_swamphouse
	if hantersKnowSlut = 0:
		act 'Отказаться':
			*clr & cla
			minut += 5
			hanterslut += 1
			dom += 1
			if temp = 1:hantersAndreiQw -=1
			if temp = 2:hantersSergeiQw -=1
			if temp = 3:hantersIgorQw -=1
			gs'stat'
			'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
			'-Не, <<$boy>>, мне некогда,- ответили вы ему. - И вообще, сами намусорили, сами и убирайте.'
			act 'Далее':gt 'swamp_yard'
		end
	end
end
!просьба охотников по уборке во дворе
if hanters > 0 and hantersKnow = 1 and hour >= 8 and hour < 20 and dirty_swamp_yard > 5 and temp = 3:
	*clr & cla
	temp = rand(1,3)
	minut += 5
	if temp = 1:$boy = 'Андрей'
	if temp = 2:$boy = 'Сергей'
	if temp = 3:$boy = 'Игорь'
	gs'stat'
	if temp = 1:'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	if temp = 2:'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
	if temp = 3:'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
	'Вы шли по своим делам, когда к вам подошел <<$boy>>.'
	if hantersKnowSlut = 0:'-<<$name[2]>>,- сказал он. - Во дворе такой бардак, может наведешь порядок? А то нам с парнями все некогда.'
	if hantersKnowSlut = 1:'-<<$name[1]>>,- сказал он. - В доме такой бардак, иди-ка убери мусор.'
	act 'Убираться на поляне':hanterslut -= 1 & dynamic $dirty_swamp_yard
	if hantersKnowSlut = 0:
		act 'Отказаться':
			*clr & cla
			minut += 5
			hanterslut += 1
			dom += 1
			if temp = 1:hantersAndreiQw -=1
			if temp = 2:hantersSergeiQw -=1
			if temp = 3:hantersIgorQw -=1
			gs'stat'
			'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
			'-Не, <<$boy>>, мне некогда,- ответили вы ему. - И вообще, сами намусорили, сами и убирайте.'
			act 'Далее':gt 'swamp_yard'
		end
	end
end
!разговор охотников, если ГГ снималась в порно, в фотостудии, танцевала стриптиз или шлюха в Гадюкино
if hanters > 0 and hantersKnowSlut = 0 and hantersKnow = 1 and hanters_check = 0 and hour >= 8 and hour < 20:
	if modelfoto > 0 and hantersknowfoto = 0 and hantersIgorLove = 0:
		*clr & cla
		minut += 5
		hanterslut += 5
		hanters_check = 1
		hantersknowfoto = 1
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterstalk.jpg"></center>'
		'Появившись на поляне вы увидели парней, что-то возбужденно обсуждавших.'
		'-Я её фотки видел в мужском журнале, точно вам говорю,- услышали вы возбужденный голос Игоря. Потом, заметив вас, парни замолчали и перевели разговор на другую тему.'
		act 'Далее':gt 'swamp_yard'
	elseif stripdancesum > 0 and hantersknowstrip = 0 and hantersSergeiLove = 0:
		*clr & cla
		minut += 5
		hanterslut += 10
		hanters_check = 1
		hantersknowstrip = 1
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterstalk.jpg"></center>'
		'Появившись на поляне вы увидели парней, что-то возбужденно обсуждавших.'
		'-Я её видел, точно вам говорю,- услышали вы возбужденный голос Сергея. - она там на сцене танцевала.'
		'Потом, заметив вас, парни замолчали и перевели разговор на другую тему.'
		act 'Далее':gt 'swamp_yard'
	elseif film > 0 and hantersknowfilm = 0 and hantersAndreiLove = 0:
		*clr & cla
		minut += 5
		hanterslut += 15
		hanters_check = 1
		hantersknowfilm = 1
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterstalk.jpg"></center>'
		'Появившись на поляне вы увидели парней, что-то возбужденно обсуждавших.'
		'-Я недавно порнуху скачал, она там снималась, точно вам говорю, это <<$pfname>>, - услышали вы возбужденный голос Андрея. Потом, заметив вас, парни замолчали и перевели разговор на другую тему.'
		act 'Далее':gt 'swamp_yard'
	elseif gadriver_gang > 0:
		*clr & cla
		minut += 5
		hantersRape = 1
		hanters_check = 1
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterstalk.jpg"></center>'
		'Появившись на поляне вы увидели парней, что-то возбужденно обсуждавших.'
		'-Я точно вам говорю, она всем в Гадюкино дает, сам недавно её "тестировал", - услышали вы возбужденный голос Андрея. Потом, заметив вас, парни замолчали и перевели разговор на другую тему.'
		act 'Далее':gt 'swamp_yard'
	end
end
!если ГГ голая и на поляне есть охотники
if current_clothing = 0 and hanterhelp = 0 and hanters = 1 and hour >= 8 and hour < 20 and hanterknowday ! day:
	*clr & cla
	gs'stat'
	if hantersKnowSlut = 0:
		cla
		*clr
		gs'stat'
		'<center><img src="images/qwest/gadukino/Swamp/swampdvornude.jpg"></center>'
		'Увидев во дворе мужчин, вы ойкнув, принялись прикрываться руками...'
		if clothesswamphouse = 1 and clearclothes = 0:
			act'Одеться':
				*clr & cla
				clothesswamphouse = 0
				minut += 5
				tanga = flag_tanga
				gs 'zz_clothing', 'redress', prev_clothing
				prev_clothing = -1
				'<center><img src="images/qwest/gadukino/Swamp/swampdvornude1.jpg"></center>'
				'И, сломя голову, кинулись в избушку одеваться.'
				act'Далее':gt'swamphouse'
			end
		else
			act'Одеться':
				*clr & cla
				minut+=5
		   		swamp_cloth = 1
				gs 'zz_clothing', 'redress', 1
				'<center><img src="images/qwest/gadukino/Swamp/tkan_cloth.jpg"></center>'
				'И быстро кинулись в избушку и прикрылись куском мешковины... Ну хоть что-то.'
				act'Далее':gt'swamphouse'
			end
		end
		act'Остаться голышом':
			*clr & cla
			hanterslut += 1
			hanterknowday = day
			gs'stat'
			'<center><img src="images/qwest/gadukino/Swamp/swampdvornude2.jpg"></center>'
			'Но потом решили пощекотать себе нервы и оставили все как есть.Мужчины старательно отводят глаза от вашего обнаженного тела.'
			iif(hantersKnow = 1,'- Ну ты, <<$name[2]>>, блин даешь, - услышали вы только фразу Андрея.','- Ни фига себе картина!, - услышали вы только удивлённый возглас.')
			act'Далее':gt'swamp_yard'
		end
	end
	if hantersKnowSlut > 0:
		if hantslutsex = 0:
			'<center><img src="images/qwest/gadukino/Swamp/swampdvornude2.jpg"></center>'
			'Увидев вас голую, парни возбудились...'
			'- Ну все <<$name[2]>>, допрыгалась, подойди-ка к нам, - позвал вас один из парней.'
			act'Далее':hantersexnude = 1 & gt'hanters'
		else
			hanterknowday = day
			'<center><img src="images/qwest/gadukino/Swamp/swampdvornude2.jpg"></center>'
			'Увидев вас голую, парни только покачали головами...'
			'- Смотри <<$name[2]>>, допрыгаешься у нас, если будешь прелестями тут светить, - шутливо сказал кто-то из парней.'
			act'Далее':gt'swamp_yard'
		end
	end
end
!разговор после пьяного стриптиза и траха ГГ с охотниками
if hantdanceslut = 1 and hour >= 8 and hour < 20:
	*clr & cla
	minut+=5
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	'Как только вы появились во дворе, к вам тут же направился Андрей.'
	'- <<$name[1]>>, есть разговор, - сказал он. - Ты помнишь, что ночью произошло?'
	'- Ну... эээ... да, - ответили вы покраснев и опустив глаза.'
	'- Я раньше говорил, что ты очень похожа на свою мать, - Андрей пристально посмотрел на вас. - Так вот , как оказалось, похожа ты не только внешне.'
	'Андрей немного помолчал глядя на вас, а вы пытались собраться с мыслями и понять к чему он клонит.'
	'- Короче, ты такая же шлюшка, как и твоя мать в молодости, яблоко от яблони как говорится... - усмехнулся он. - Прими это как данность.'
	'Вы ошарашено посмотрели на Андрея.'
	'- А призвание шлюшек это что? - продолжил он. - Правильно, обслуживать мужиков. Согласна?'
	act'Согласится':hantdanceslut = 2 & gt'hanters'
	if dom > 0 and alko < 8:act'Отказаться':hantdanceslut = 3 & gt'hanters'
end
!разговор после изнасилования ГГ охотниками
if hantersRape = 4 and hour >= 8 and hour < 20:
	*clr & cla
	minut+=5
	hantersKnowSlut = 2
	hantersRape = 5
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	'Как только вы появились во дворе, к вам тут же направился Андрей.'
	'- <<$name[2]>>, есть разговор, - сказал он. - Ты понимаешь, что произошло и как теперь себя вести нужно?'
	'Вы невольно кивнули головой.'
	'- В том что случилось ты сама виновата, нефиг было выёбываться, - Андрей внимательно посмотрел на вас. - Смотри, не делай глупостей больше.'
	'- И в милицию тебе идти не советую, - добавил он. - У Сергея там подвязки. Мы то отмажемся, а тебе потом пиздец будет. Усекла? .'
	'Вы испугано посмотрели на Андрея и закивали головой.'
	'- Ну вот и молодец, - сказал он и отошел в сторону он.'
	act 'Уйти':gt'swamp_yard'
end
!признание в любви Игоря
if hanters > 0 and hantersIgorLove = 0 and hantersIgorQw >= 35 and hantersKnowSlut = 0 and bfA < 1 and hour >= 8 and hour < 20 and vnesh >= 40:
	*clr & cla
	minut += 10
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
	'Выйдя на поляну перед избушкой вы замечаете Игоря. Он дожидался явно вас.'
	'- <<$name[2]>>, я хотел с тобой поговорить... - немного смущаясь начал говорить он. Вы с интересом взглянули на него, дожидаясь продолжения...'
	act 'Далее':gt'IgorHanter'
end
!секс с Игорем
if hanters > 0 and hantersIgorLove > 0 and hantersIgorQw >= 10 and temp = 4 and hantersIgorsex = 0 and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	hantersIgorsex += rand(12,36)
 	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Появившись на поляне вы увидели Игоря. Он с улыбкой подошел и впился в ваши губы страстным поцелуем.'
	'- <<$name[1]>>, я хочу тебя, - прошептал он, прервав поцелуй.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		hantersIgorQw += 1
		horny += 5
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
		act 'Идти':gt $loc, $metka
	end
end
!цветы от Игоря
if hanters > 0 and hantersKnowSlut = 0 and current_clothing > 2 and hantersIgorQw >= 20 and temp = 5 and flowersday ! day and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	horny += 5
	flowersday = day
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterflowers1.jpg"></center>'
	'Появившись на поляне вы увидели Игоря. Он с загадочной улыбкой подошел к вам держа руки за спиной.'
	'- <<$name[1]>>, это тебе, - немного смущаясь сказал он, протянув вам букет полевых цветов.'
	act 'Принять':
		*clr & cla
		minut += 5
		hanterslut -= 1
		hantersIgorQw += 1
		if hantersAndreiQw >= 10 and hantersKnowSlut = 0:hantersAndreiQw -= 2
		if hantersSergeiQw >= 10 and hantersKnowSlut = 0:hantersSergeiQw -= 2
		manna = 100
		gs 'stat'
		if hantersIgorLove = 0 and hantersIgorQw >= 20 and hantersIgorQw < 25:
			if func('zz_clothing','is_skirt') = 1:'<center><img src="images/qwest/gadukino/Swamp/hanterflowers2_ski.jpg"></center>'
			if func('zz_clothing','is_skirt') = 0:'<center><img src="images/qwest/gadukino/Swamp/hanterflowers2.jpg"></center>'
			'Улыбнувшись вы берете букет из его руки и уходите с задумчивым видом.'
		end
		if hantersIgorLove = 0 and hantersIgorQw >= 25 and hantersIgorQw < 20 or hantersIgorLove > 0:
			if func('zz_clothing','is_skirt') = 1:'<center><img src="images/qwest/gadukino/Swamp/hanterflowers3_ski.jpg"></center>'
			if func('zz_clothing','is_skirt') = 0:'<center><img src="images/qwest/gadukino/Swamp/hanterflowers3.jpg"></center>'
			'Улыбнувшись вы берете букет из его рук и уходите со счастливым видом.'
		end
		if hantersIgorLove = 0 and hantersIgorQw >= 30:
			'<center><img src="images/qwest/gadukino/Swamp/hanterflowerskiss.jpg"></center>'
			'Улыбнувшись вы берете букет из его рук, целуете его в щечку и смутившись убегаете.'
		end
		act 'Далее':gt $loc, $metka
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersIgorQw -= 2
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, Игорь, не нужно этого, - сказали вы, и не взяв цветы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Далее':gt $loc, $metka
	end
end
! общение с Сергеем
if hanters > 0 and hantersKnowSlut = 0 and current_clothing > 2 and hantersSergeiQw >= 15 and temp = 6 and hantersSergeiday ! day and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	hantersSergeiday = day
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
	'Появившись на поляне вы увидели Сергея, который улыбкой направлялся в вашу сторону.'
	'- <<$name[1]>>, давай посидим, пообщаемся, ты не против?, - немного смущаясь спросил он.'
	act 'Согласиться':
		*clr & cla
		minut += 120
		hanterslut -= 1
		hantersSergeiQw += 1
		if hantersIgorQw >= 10 and hantersKnowSlut = 0:hantersIgorQw -= 2
		if hantersAndreiQw >= 10 and hantersKnowSlut = 0:hantersAndreiQw -= 2
		manna = 100
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/hanterlove2.jpg"></center>'
		'Улыбнувшись вы соглашаетесь и следующие два часа вы проводите вместе с Сергеем за разговорами..'
		act 'Далее':gt $loc, $metka
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		hantersSergeiQw -= 2
		gs 'stat'
		'<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
		' - Нет, Сергей, не хочу, - сказали вы, и стараясь не смотреть на парня ушли.'
		act 'Далее':gt $loc, $metka
	end
end
! секс с Сергеем
if hanters > 0 and hantersSergeiLove > 0 and hantersSergeiQw >= 10 and temp = 7 and hantersSergeisex = 0 and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	hantersSergeisex += rand(9,30)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Появившись на поляне вы увидели Сергея. Он с улыбкой подошел и впился в ваши губы долгим поцелуем.'
	'- <<$name[1]>>, я хочу тебя, - сказал он, прервав поцелуй.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		horny += 5
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
		' - Нет, Сергей, давай не сейчас, - сказали вы, и стараясь не смотреть на расстерявшегося парня ушли.'
		act 'Идти':gt $loc, $metka
	end
end
! секс с Андреем
if hanters > 0 and hantersAndreiLove > 0 and hantersAndreiQw >= 10 and temp = 8 and hantersAndreisex = 0 and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	hantersAndreisex += rand(6,24)
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterlove1.4.jpg"></center>'
	'Появившись на поляне вы увидели Андрея. Неожиданно он  впился в ваши губы страстным поцелуем и ни слова не говоря потянул вас за собой.'
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
		' - Нет, Андрей, давай не сейчас, - сказали вы, и стараясь не смотреть на него ушли.'
		act 'Идти':gt $loc, $metka
	end
end
! секс если ГГ шлюха
if hanters > 0 and hantersRape = 5 and hantslutsexrand = 1 and hantslutsex = 0 and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	temphant = rand(1,3)
	! выбор того, кто будет сношать ГГ
	slutgosex = 1
	gs 'stat'
	if temphant = 1:'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	if temphant = 2:'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
	if temphant = 3:'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
	if temphant = 1:'Появившись на поляне вы увидели Андрея направляющегося в вашу сторону. " - Пошли <<$name[2]>>," - сказал он и больше ни слова не говоря потянул вас за собой, в сторону ближайших деревьев.'
	if temphant = 2:'Появившись на поляне вы увидели Сергея. Заметив вас он направился в вашу сторону. " - Пошли отойдем <<$name[2]>>, что-то приспичило," - сказал он и потянул вас за собой в сторону ближайших зарослей.'
	if temphant = 3:'Появившись на поляне вы увидели Игоря. Заметив вас он улыбнуся и подошел. " - <<$name[2]>>, мне нужно напряжение скинуть, давай отойдем," - сказал он улыбаясь и повел вас за собой.'
	if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнем, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнем, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
	act 'Идти':	gt'hanters'
end
!выбор межды любовниками
if hanters > 0 and hantersAndreiLove > 0 and hantersSergeiLove > 0 and hour >= 8 and hour < 20 and temp = 1:
	*clr & cla
	minut += 15
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.2.jpg"></center>'
	'К вам подошли Андрей и Сергей. Лица их были серьезны и вы поняли, что вам предстоит тяжелый разговор.'
	' - <<$name[3]>>, мы не мальчики, чтобы с нами в игрушки играть, и крутить любовь с обоими, - начал разговор Сергей. - Ты должна выбрать кого-то одного из нас.'
	if hanterslut >= 10:' - Ну, я вообще-то и против тройничка был бы не против, - усмехнулся Андрей, пристально смотря вам в глаза. - Выбор за тобой <<$name[2]>>.'
	'Вы задумались на на некоторое время, потом решили...'
	act 'Выбрать Сергея':
		*clr & cla
		minut += 5
		hantersAndreiLove = 0
		hantersAndreiQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
		'После раздумий вы решили выбрать Сергея. Он просиял от радости и тут же поцеловал вас в губы.'
		' - Ну что же, все по честному, это твой выбор, - сказал расстроеный Андрей и отошел в сторону.'
		act 'Далее':gt'swamp_yard'
	end
	act 'Выбрать Андрея':
		*clr & cla
		minut += 5
		hantersSergeiLove = 0
		hantersSergeiQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
		'После раздумий вы решили выбрать Андрея.'
		' - Ну вот и разобрались, - сказал Андрей заметно повеселев. - Иди ко мне <<$name[3]>>.'
		' - Ну что же, все по честному, это твой выбор, - сказал расстроеный Сергей и отошел в сторону.'
		act 'Далее':gt'swamp_yard'
	end
	if hanterslut >= 10:
		act 'Встречаться с обоими':
			*clr & cla
			minut += 5
			hanterslut += 10
			doublehanterlove = 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.7.jpg"></center>'
			' - Знаете, я бы попробовала любовь втроем, - опустив глаза сказали вы.'
			' - Хороший выбор <<$name[2]>>, - усмехнулся Сергей. - я примерно так и предпологал. Ну что Серёга, ты не против?.'
			' - Ну почему бы и нет, в конце концов это её выбор, - сказал Сергей, посмотрев на вас как-то совсем по другому.'
			act 'Далее':gt'swamp_yard'
		end
	end
	act 'Расстаться с обоими':
		*clr & cla
		minut += 5
		hantersAndreiLove = 0
		hantersAndreiQw -= 50
		hantersSergeiLove = 0
		hantersSergeiQw -= 50
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/hantersex/fuck.jpg"></center>'
		' - Да пошли вы со своим выбором, - в сердцах крикнули вы и показав им на прщание средний палец пошли прочь. - Вот вам мой выбор!'
		' - Охренеть, - только и смог произнести ошарашеный Сергей.'
		' - Ахахах, - неожиданно расмеялся Сергей. - Ну что же, все по честному, это твой выбор.'
		act 'Далее':gt'swamp_yard'
	end
end
if hanters > 0 and hantersAndreiLove > 0 and hantersIgorLove > 0 and hour >= 8 and hour < 20 and temp = 1:
	*clr & cla
	minut += 15
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.2.jpg"></center>'
	'К вам подошли Андрей и Игорь. Лица их были серьезны и вы поняли, что вам предстоит тяжелый разговор.'
	' - <<$name[1]>>, мы не мальчики, чтобы с нами в игрушки играть, и крутить любовь с обоими, - начал разговор Игорь. - Ты должна выбрать кого-то одного из нас.'
	if hanterslut >= 10:' - Ну, я вообще-то и против тройничка был бы не против, - усмехнулся Андрей, пристально смотря вам в глаза. - Выбор за тобой <<$name[2]>>.'
	'Вы задумались на на некоторое время, потом решили...'
	act 'Выбрать Игоря':
		*clr & cla
		minut += 5
		hantersAndreiLove = 0
		hantersAndreiQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
		'После раздумий вы решили выбрать Игоря. Он просиял от радости.'
		'Я верил, что ты выберешь меня <<$name[1]>>, - сказал Игорь и нежно поцеловал вас в губы.'
		' - Ну что же, все по честному, это твой выбор, - сказал расстроеный Андрей и отошел в сторону.'
		act 'Далее':gt'swamp_yard'
	end
	act 'Выбрать Андрея':
		*clr & cla
		minut += 5
		hantersIgorLove = 0
		if hantersIgorLove = 2:bfA = 0
		hantersIgorQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
		'После раздумий вы решили выбрать Андрея.'
		' - Ну вот и разобрались, - сказал Андрей заметно повеселев. - Иди ко мне <<$name[3]>>.'
		'Расстроеный Игорь молча отошел в сторону стараясь не смотреть на вас.'
		act 'Далее':gt'swamp_yard'
	end
	if hanterslut >= 10:
		act 'Встречаться с обоими':
			*clr & cla
			minut += 5
			hantersIgorLove = 0
			if hantersIgorLove = 2:bfA = 0
			hantersIgorQw -= 100
			hanterslut += 1
			gs 'stat'
			'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.7.jpg"></center>'
			' - Знаете, я бы попробовала любовь втроем, - опустив глаза сказали вы.'
			' - Хороший выбор <<$name[2]>>, - усмехнулся Сергей. - я примерно так и предпологал. Ну что Серёга, ты не против?.'
			' - Нет, Андрей, меня это не устраивает, - сказал Игорь, посмотрев на вас как-то совсем по другому. - Пожалуй я лучше пойду.'
			'Расстроеный Игорь ушел стараясь не смотреть на вас.'
			act 'Далее':gt'swamp_yard'
		end
	end
	act 'Расстаться с обоими':
		*clr & cla
		minut += 5
		hantersAndreiLove = 0
		hantersAndreiQw -= 50
		hantersIgorLove = 0
		if hantersIgorLove = 2:bfA = 0
		hantersIgorQw -= 50
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/hantersex/fuck.jpg"></center>'
		' - Да пошли вы со своим выбором, - в сердцах крикнули вы и показав им на прщание средний палец пошли прочь. - Вот вам мой выбор!'
		'Ошарашеный Игорь в изумлении посмотрел на вас.'
		' - Ахахах, - неожиданно расмеялся Сергей. - Ну что же, все по честному, это твой выбор.'
		act 'Далее':gt'swamp_yard'
	end
end
if hanters > 0 and hantersSergeiLove > 0 and hantersIgorLove > 0 and hour >= 8 and hour < 20 and temp = 1:
	*clr & cla
	minut += 15
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.2.jpg"></center>'
	'К вам подошли Игорь и Сергей. Лица их были серьезны и вы поняли, что вам предстоит тяжелый разговор.'
	' - <<$name[3]>>, мы не мальчики, чтобы с нами в игрушки играть, и крутить любовь с обоими, - начал разговор Сергей. - Ты должна выбрать кого-то одного из нас.'
	'Игорь молча кивнул.'
	'Вы задумались на на некоторое время, потом решили...'
	act 'Выбрать Сергея':
		*clr & cla
		minut += 5
		hantersIgorLove = 0
		if hantersIgorLove = 2:bfA = 0
		hantersIgorQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
		'После раздумий вы решили выбрать Сергея. Он просиял от радости и тут же поцеловал вас в губы.'
		' - Не ожидал <<$name[1]>>, но это твой выбор, - сказал расстроеный Игорь и отошел в сторону.'
		act 'Далее':gt'swamp_yard'
	end
	act 'Выбрать Игоря':
		*clr & cla
		minut += 5
		hantersSergeiLove = 0
		hantersSergeiQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
		'После раздумий вы решили выбрать Игоря. Он просиял от радости.'
		'Я верил, что ты выберешь меня <<$name[1]>>, - сказал Игорь и нежно поцеловал вас в губы.'
		' - Ну что же, все по честному, это твой выбор, - сказал расстроеный Андрей и отошел в сторону.'
		act 'Далее':gt'swamp_yard'
	end
	act 'Расстаться с обоими':
		*clr & cla
		minut += 5
		hantersIgorLove = 0
		if hantersIgorLove = 2:bfA = 0
		hantersIgorQw -= 100
		hantersSergeiLove = 0
		hantersSergeiQw -= 100
		hanterslut -= 1
		gs 'stat'
		'<center><img src="images/qwest/gadukino/hantersex/fuck.jpg"></center>'
		' - Да пошли вы со своим выбором, - в сердцах крикнули вы и показав им на прщание средний палец пошли прочь. - Вот вам мой выбор!'
		'Ошарашеный Игорь в изумлении посмотрел на вас.'
		' - Охренеть, - только и смог произнести Сергей.'
		act 'Далее':gt'swamp_yard'
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
	'На поляне вы увидели Андрея с Сергеем.'
	' - Пора, так сказать, исполнять супружеский долг, - сказал Андрей шутливым тоном. - Готовь <<$name[2]>> попу.'
	if klismaday ! day:' - Блин, а я попу не готовила сегодня, - смущаясь сказали вы. - Может не будем?.'
	if klismaday ! day:' - Будем <<$name[2]>>, будем, - ответил Андрей. - Ты не помыла, тебе и расхлебывать. В следующий раз не забудешь.'
	' - В кусты нужно поглубже забраться только, - добавил Сергей. - А то Игорь у нас сильно правильный, не поймет.'
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
		' - Нет, ребята, что-то я не хочу, - сказали вы, и не глядя на них  ушли.'
		act 'Идти':gt $loc, $metka
	end
end
! задирает ветром юбку
skirtsrand = RAND(1,10)
if hanters > 0 and hantersKnow > 0 and hour >= 8 and hour < 20 and func('zz_clothing','is_skirt') = 1 and tanga = 0 and skirtsrand = 1:
	*clr & cla
	minut += 15
	hanterslut += 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/no_tanga.jpg"></center>'
	'Вы шли по поляне, когда внезапно налетевший ветерок задрал вам юбку.'
	' - Блин, трусики..., - запоздало опомнились вы, сверкнув уже голой писькой на всю округу.'
	'Совладав наконец с юбкой вы осмотрелись, не заметил ли кто пикантные подробности вашего гардероба. Парни вроде как всегда занимались своими делами, однако по покрасневшему Игорю и довольно улыбающемуся Андрею, вы поняли, что ваша случайная демонстрация не прошла незамечаной.'
	act 'Далее':gt'swamp_yard'
end
! трио если ГГ шлюха
if hanters > 0 and hantersRape = 5 and hantslutsexrand = 2 and hantslutsex = 0 and hour >= 8 and hour < 20:
	*clr & cla
	minut += 5
	temphant = rand(1,3)
	slutgosex = 2
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/hanterswork1.2.jpg"></center>'
	'На поляне вы увидели Андрея с Сергеем.'
	if temphant = 1:'Идя по поляне вы увидели Андрея и Сергея идущих в вашу сторону. " - Пошли <<$name[2]>>," - сказал Андрей и больше ни слова не говоря потянул вас за собой, в сторону ближайших деревьев. Сергей двинулся следом'
	if temphant = 2:'Вы шли по поляне, когда увидели Андрея и Игоря. Заметив вас они направились в вашу сторону. " - Пошли отойдем <<$name[2]>>, что-то приспичило," - сказал Андрей и потянул вас за собой в сторону ближайших зарослей. Игорь пошел следом за вами.'
	if temphant = 3:'Появившись на поляне вы увидели Игоря и Сергея. Заметив вас Игорь улыбнуся и подошел. " - <<$name[2]>>, нам напряжение нужно скинуть, давай отойдем," - сказал он улыбаясь и повел вас за собой. Следом двинулся и Сергей.'
	if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнями, прекрасно понимая куда и зачем вас ведут.'
	if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнями, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
	act 'Идти с парнями':
		*clr & cla
		minut += 5
		horny += 5
		gs 'stat'
		'<center><img src="images/qwest/gadukino/Swamp/doublehanterlove.jpg"></center>'
		'Вы идете с парнями держась за руки, прекрасно понимая, куда и зачем они вас ведут. И вы совсем даже не против.'
		act 'Далее':gt'hantersex'
	end
end
!лесник ищет пропавшую ГГ
if lost_girl < 10:
	*clr & cla
	minut += 150
	lost_girl = 0
	hanters = 0
	goswamp = 1
	forester = 1
	gs 'stat'
	'<center><img src="images/qwest/gadukino/Swamp/forester.jpg"></center>'
	'Вы шли по поляне, когда увидели человека в форме лесника.'
	' - А вот и наша пропажа, - устало сказал он. - Твои дед и бабка уже с ног сбились в поисках тебя. Меня вот попросили помочь. Собирайся, домой отведу.'
	'" Ой, как стыдно" - подумали вы. "Бедные дедушка с бабушкой. Ну как я могла о них забыть."'
	'Быстро собравшись, вы пошли под присмотром лесника домой.'
	act 'Далее':gt'Gadhouse'
end
$dirty_swamp_yard = {
	*clr & cla
	if dirty_swamp_yard < 10:minut += 60 & sweat += 1
	if dirty_swamp_yard >= 10 and dirty_swamp_yard < 20:minut += 120 & sweat += 2
	if dirty_swamp_yard >= 20:minut += 180 & sweat += 3
	if hantersAndreiQw < 15:hantersAndreiQw += 1
	if hantersIgorQw < 15:hantersIgorQw += 1
	if hantersSergeiQw < 15:hantersSergeiQw += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/Swamp/dirty_swamp_yard.jpg"></center>'
	'Выйдя в очередной раз на поляну перед избушкой, вы заметили, сколько там накопилось разного мусора и грязи. " - С этим нужно что-то делать", - подумали вы и  принялись за уборку двора. Через некоторое врямя двор сиял первозданной чистотой.'
	act 'Далее':dirty_swamp_yard = 0 & gt'swamp_yard'
}