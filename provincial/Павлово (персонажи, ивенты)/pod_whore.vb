!ивенты с подработкой в подъезде если у гг репа: проститутка
!настройки:
!подгружаем динамику которая в "gopsex"
gs'gopsex'
!кол-во клиентов можно обслужить в сутки:
if pod_whore_countQW <= 15:
	if pod_whore_client_day ! daystart: pod_whore_client_count = rand(4,8)
elseif pod_whore_countQW > 15:
	if pod_whore_client_day ! daystart: pod_whore_client_count = rand(8,16)
end
!==========================================
!ценник на услуги гг
!внешность и др.параметры влияющие на цену
!------------------
!параметры в плюс:
!силикон
money_silicone = 0
if silicone > 0 and silicone < 30: money_silicone = 50
if silicone >= 30 and silicone < 40: money_silicone = 100
if silicone >= 40: money_silicone = 150
!косметика
money_mop = 0
if mop >= 2: money_mop = 50
!причесон
money_hapri = 50
!гламурная одежда
money_glamur = 0
if func('zz_clothing','is_glamour') = 1: money_glamur = 150
!одежда шлюхи
money_odethooker = 0
if func('zz_clothing', 'get_group') = 12: money_odethooker = 50
!гладкость и чистота кожи
money_skin = 0
if skin >= 3: money_skin = 50
!загар
money_tan = 0
if tan > 0: money_skin_tan = 50
!гладкость ног, бритые или нет
money_leghair = 0
if leghair <= 0: money_leghair = 50
!ухоженность ресниц
money_resnic = 0
if resnic = 2: money_resnic = 50
!бальзам для губ
money_lipbalmstat = 0
if lipbalmstat >= 1: money_lipbalmstat = 50
!глубокая глотка
money_throat = 0
if throat >= 20: money_throat = 50
!------------------------------------------
!параметры в минус
!расшатаность вагины
money_vagina = 0
if vagina >= 20: money_vagina = 50
!расшатаность ануса
money_anus = 0
if anus >= 20: money_anus = 50
!возбужденность
money_horny = 0
if horny > 70: money_horny = 50
!внешность -10, венерические заболевания
money_vnesh = 0
if vnesh = -10: money_vnesh = 150
!пятна спермы на одежде:
money_cumfrot = 0
if cumfrot > 0: money_cumfrot = 50
!чистота тела (потная или нет)
money_sweat = 0
if sweat >= 1 and sweat <= 3: money_sweat = 50
if sweat > 3: money_sweat = 100
!из рта пахнет
money_cumlip = 0
if cumlip > 0: money_cumlip = 50
!лицо перемазано в сперме
money_cumface = 0
if cumface > 0: money_cumface = 50
!тело перемазано в сперме
money_cumbelly = 0
if cumbelly > 0: money_cumbelly = 50
!вытекает сперма из пизды
money_cumpussy = 0
if cumpussy > 0: money_cumpussy = 50
!вытекает сперма из попы
money_cumanus = 0
if cumanus > 0: money_cumanus = 50
!попа перемазана в сперме
money_cumass = 0
if cumass > 0: money_cumass = 50
!ваша энергия:
money_son = 0
if son < 5: money_son = 50
!доп рандом бабло
whore_money_rnd = RAND(1,2)
	if whore_money_rnd = 1:$whore_money_rnd = 50
	if whore_money_rnd = 2:$whore_money_rnd = 100
whore_dopmoney = $whore_money_rnd
!цена, если клиент хочет только минет
whore_money_bjsex = money_silicone + money_mop + money_hapri + money_glamur + money_odethooker + money_skin + money_skin_tan + money_leghair + money_resnic + money_lipbalmstat + whore_dopmoney + 50 + money_throat - money_vnesh - money_horny - money_cumfrot - money_sweat - money_cumlip - money_cumface - money_cumbelly - money_cumpussy - money_cumanus - money_cumass - money_son
!whore_money_bjsex = $whore_money_bjsex
!цена, если клиент хочет классику
whore_money_clsex = money_silicone + money_mop + money_hapri + money_glamur + money_odethooker + money_skin + money_skin_tan + money_leghair + money_resnic + money_lipbalmstat + whore_dopmoney + 150 - money_vagina - money_vnesh - money_horny - money_cumfrot - money_sweat - money_cumlip - money_cumface - money_cumbelly - money_cumpussy - money_cumanus - money_cumass - money_son
!whore_money_clsex = $whore_money_clsex
!цена, если клиент хочет в попу
whore_money_analsex = money_silicone + money_mop + money_hapri + money_glamur + money_odethooker + money_skin + money_skin_tan + money_leghair + money_resnic + money_lipbalmstat + whore_dopmoney + 200 - money_anus - money_vnesh - money_horny - money_cumfrot - money_sweat - money_cumlip - money_cumface - money_cumbelly - money_cumpussy - money_cumanus - money_cumass - money_son
!whore_money_analsex = $whore_money_analsex
!цена, если клиент хочет все
whore_money_allsex = whore_money_bjsex + whore_money_analsex + 50
!whore_money_allsex = $whore_money_allsex
!цена за групповуха
whore_money_groupsex = whore_money_bjsex + whore_money_analsex + whore_money_clsex + whore_dopmoney
!whore_money_groupsex = $whore_money_groupsex
!цена за минет и классику
whore_money_bjvagsex = whore_money_bjsex + whore_money_clsex
!цена за минет и анал
whore_money_bjanalsex = whore_money_bjsex + whore_money_analsex
!анальная пробка и смазка:
$pod_whore_analplugin = {
if analplugin = 1:
	analplugin = 0
	gs 'zz_render', '', '', func('pod_whore_strings', '1')
end
}
$pod_whore_lubri = {
	if lubri > 0:
		lubri -= 1
		agape = 1
		horny += 20
		$pod_whore_lubri_text = ''
		gs 'zz_render', '', '', func('pod_whore_strings', '2')
	elseif lubri = 0:
		agape = 2
		horny = 0
	end
	agapetime = totminut + (agape + 1) * 1440
}
!--------------------------------------------------------------
!Текст ивентов:
!отсос
$text_pod_whore_bj = {
txt_pod_whore_bj = rand(1,5)
if txt_pod_whore_bj = 1:$txt_pod_whore_bj = 'На вас нахлынуло какое-то непонятное приподнятое настроение, вас саму возбуждала та мысль, что вы сейчас будите сосать член какому-то взрослому, некрасивому мужику в подъезде за денежку.<br>Вы заметили, что слегка дрожите - то ли от страха, то ли от возбуждения.:<br>- Встань на колени, шлюха и возьми мой член в рот. -Грубо приказал он.<br>С этими словами он расстегнул ширинку. Вы встали на колени и взяли сначала в руки его распухший красный член, потом обхватила его губами, засасывая. Тут он схватил вас за голову и стал сам насаживать на свой член.<br>- Давай, девочка, соси, не останавливайся, - нечленораздельно промямлил он.'
if txt_pod_whore_bj = 2:$txt_pod_whore_bj = 'Вам было противно смотреть на него. Мужик сказал вам:<br>- Становись на колени, глупая сука, и соси, пока не выебал тебя в жопу!.<br>Вы попятились, но все-таки сделали то, что он сказал. Вы не смотрели на него, а просто думали о деньгах и работали ртом.'
if txt_pod_whore_bj = 3:$txt_pod_whore_bj = 'Он вытащил свой член и сказал вам:<br>- Отсоси-ка красавица.<br>Не говоря ни слова, вы начали сосать его грязный член, чувствуя, как он твердеет у вас во рту.<br>Потом он вытащил его у вас изо рта и сказал:<br>- Яйца обработай, шлюха.<br>Вы молча обслуживали его по полной программе, делая все что скажут.'
if txt_pod_whore_bj = 4:$txt_pod_whore_bj = 'Вы опустились на колени перед ним и как смогли пошире открыли рот, он вставил свой член и дело пошло.<br>- соси, хуесосочка, опущенная, я тебя накормлю колбасой.<br>Умело работали не только губами. Но и язычком, так что он вскоре тихонько начал постанывать.'
if txt_pod_whore_bj = 5:$txt_pod_whore_bj = 'Вы вышли в подъезд на лестничную клетку, присели на корточки и спустив с мужика штаны.<br>Какое то время рассматривали его торчащий член, потом выдохнули, и взяв его рукой, облизала головку. Потом принялись сосать член, неглубоко беря головку в рот.<br>Он положил руки вам на голову и вы стали активней сосать, время от времени доставая член изо рта и поднимая на него глаза. '
if txt_pod_whore_bj = 6:$txt_pod_whore_bj = ''
if txt_pod_whore_bj = 7:$txt_pod_whore_bj = ''
gs 'zz_render', '', '', $txt_pod_whore_bj
}
!вагин секс
$text_pod_whore_vag = {
txt_pod_whore_vag = rand(1,3)
if txt_pod_whore_vag = 1:$txt_pod_whore_vag = 'Вы спустили штаны, оголив попку и, встав в позе рака, подставили её ему. Вы тут же почувствовали, как он вошел в вас сзади. Он трахал грубо, похлопывая по вашей заднице ладонью.<br>Вам было довольно терпимо. Одной рукой он звонко шлепал вас по попке, словно подгоняя к активности, а другой рукой закрывал вам рот. И тут он так сильно толкнул в вас свой член, что вы очень громко простонали.<br>Он больно ударил вас по заднице.<br>- Не вздумай орать, дура, тут люди живут. Тихо постанывай, - прохрипел он и засмеялся. '
if txt_pod_whore_vag = 2:$txt_pod_whore_vag = 'Вы встали к нему спиной, упершись руками в подоконник. Он отодвинул в сторону ваши трусики - они были изрядно мокрые.<br>Тем временем парень уже пристроился сзади и наконец ввел свой член вам в пизденку. Он вошел легко и до конца.<br>Вы охнули, а он стал медленно трахать, взявшись за ваши крепкие грудки с торчащими сосками, но это продолжалось недолго.'
if txt_pod_whore_vag = 3:$txt_pod_whore_vag = 'Он развернул вас, облокотил, рукой он направил член вам в киску, в ней было так горячо, он стал двигаться в ней.<br>Парень стал ускоряться, вы начали стонать громче, он побоялся, что вы разбудите соседей и закрыл вам рот своей рукой.<br><<$txt_pod_whore_vag>>'
gs 'zz_render', '', '', $txt_pod_whore_vag
}
!анал секс
$text_pod_whore_anal = {
dynamic $pod_whore_lubri
txt_pod_whore_anal = rand(1,2)
if txt_pod_whore_anal = 1:$txt_pod_whore_anal = 'Он обнял вас за талию и прижал к себе, приспустив трусики вы чувствовали своей оголенной попкой, как встает его член. <<$pod_whore_lubri_text>><br>Наконец он просунул руку под вашу задницу, где была его ширинка и, нащупав своим членом ваш анус, вставил его туда.<br>Это было, не без удовольствия. Какой-то грузчик средних лет имел молодую девчонку в попку за деньги!'
if txt_pod_whore_anal = 2:$txt_pod_whore_anal = 'Вы спустили штаны, оголив попку и, встав в позе рака, подставив ему свою дырочку. <<$pod_whore_lubri_text>><br>Через мгновение вы почувствовали, как он вошел в вашу попку. Он трахал грубо, похлопывая по вашей заднице ладонью.<br>Вам было довольно терпимо. Одной рукой он звонко шлепал вас по попке, словно подгоняя к активности, а другой рукой закрывал вам рот. И тут он так сильно толкнул в вас свой член, что вы очень громко простонали.<br>Он больно ударил вас по заднице и хрипло произнес:<br>- Не вздумай орать, дура, тут люди живут. Тихо постанывай!'
if txt_pod_whore_anal = 3:$txt_pod_whore_anal = ''
if txt_pod_whore_anal = 4:$txt_pod_whore_anal = ''
if txt_pod_whore_anal = 5:$txt_pod_whore_anal = ''
dynamic $pod_whore_analplugin
gs 'zz_render', '', '', $txt_pod_whore_anal
}
!окончание
$text_pod_whore_cum = {
txt_pod_whore_cum = rand(1,4)
if txt_pod_whore_cum = 1:$txt_pod_whore_cum = 'Мужик начал стонать. Не прошло и пяти минут, как он спустил вам в рот, и вам пришлось глотать.<br>Вы встали на ноги и вытерли губы. Мужик заправил член в штаны, достал кошелек и вынув пару купюр, передал вам.<br>- Мне понравилось, еще как-нибудь зайду шлюшка.<br>Вы смотрели как он уходит, думая о деньгах и о том, что будет, если он расскажет своим дружкам об этом, и те захотят тоже попробовать!?'
if txt_pod_whore_cum = 2:$txt_pod_whore_cum = 'И все как-то быстро закончилось, и когда он, наконец, застегнул ширинку, то сказал:<br>- "Молодец хорошая шлюшка, держи заработала" и протянул вам пару помятых бумажек. Вы взяли денежку, он попрощался и ушел.'
if txt_pod_whore_cum = 3:$txt_pod_whore_cum = 'Он вскоре тихонько застонал и стал спускать. Вы хотели выплюнуть его сперму. Но он заметил и держа ваш рот двумя руками велел проглотить.<br>- "Отлично поработала, заслужила шлюшка", сказал он и протянул пару мятых бумажек.'
if txt_pod_whore_cum = 4:$txt_pod_whore_cum = 'Член увеличился еще, вы не могли этого ни почувствовать... но когда сперма стала стрелять вам в ротик вы не отстранилась, а только больше вобрали его в горячий ротик.<br>Вы дождались окончания его оргазма и продолжили сосать, облизывая его член чистя от спермы. Он отдыхал, облокотившись спиной на стену.<br>- "Отлично поработала сучка, держи денежку, заслужила!"'
if txt_pod_whore_cum = 5:$txt_pod_whore_cum = ''
gs 'zz_render', '', '', $txt_pod_whore_cum
}
!=============================
!текст разговоров с клиентом:
rnd_client_text_bj = rand(1,10)
if rnd_client_text_bj = 1:$rnd_client_text_bj = 'Хочу минет'
if rnd_client_text_bj = 2:$rnd_client_text_bj = 'Сделай минет'
if rnd_client_text_bj = 3:$rnd_client_text_bj = 'Хочу, что бы ты хорошенько отсосала'
if rnd_client_text_bj = 4:$rnd_client_text_bj = 'В твой ротик хочу'
if rnd_client_text_bj = 5:$rnd_client_text_bj = 'Возмешь в рот и я буду доволен'
if rnd_client_text_bj = 6:$rnd_client_text_bj = 'Времени мало у меня, только на минет'
if rnd_client_text_bj = 7:$rnd_client_text_bj = 'По быстрому отсос'
if rnd_client_text_bj = 8:$rnd_client_text_bj = 'На клык дам'
if rnd_client_text_bj = 9:$rnd_client_text_bj = 'Говорят ты соска первоклассная, опробую твой ротик'
if rnd_client_text_bj = 10:$rnd_client_text_bj = 'В башню дам'
rnd_client_text_vag = rand(1,10)
if rnd_client_text_vag = 1:$rnd_client_text_vag = 'Хочу тебя в пизду'
if rnd_client_text_vag = 2:$rnd_client_text_vag = 'По быстрому в пизду выебу'
if rnd_client_text_vag = 3:$rnd_client_text_vag = 'Пизду опробую'
if rnd_client_text_vag = 4:$rnd_client_text_vag = 'Я думаю сегодня пиздой поработаешь'
if rnd_client_text_vag = 5:$rnd_client_text_vag = 'Сегодня в пизду буду <<$gop_sextext1>>'
if rnd_client_text_vag = 6:$rnd_client_text_vag = 'у меня времени мало, по быстрому в пизду выебу'
if rnd_client_text_vag = 7:$rnd_client_text_vag = 'В пизду <<$gop_sextext1>> буду'
if rnd_client_text_vag = 8:$rnd_client_text_vag = 'Письку твою <<$gop_sextext1>> буду'
if rnd_client_text_vag = 9:$rnd_client_text_vag = '<<$gop_sextext1>> в пизду буду'
if rnd_client_text_vag = 10:$rnd_client_text_vag = 'Трахну тебя в пизду'
rnd_client_text_anal = rand(1,10)
if rnd_client_text_anal = 1:$rnd_client_text_anal = 'Хочу тебя в жопу'
if rnd_client_text_anal = 2:$rnd_client_text_anal = 'По быстрому в жопу выебу'
if rnd_client_text_anal = 3:$rnd_client_text_anal = 'Попку твою опробую'
if rnd_client_text_anal = 4:$rnd_client_text_anal = 'В попку жахну'
if rnd_client_text_anal = 5:$rnd_client_text_anal = 'Говорят жопа у тебя, то что надо...'
if rnd_client_text_anal = 6:$rnd_client_text_anal = 'Время меня поджимает, по быстрому в попку трахну'
if rnd_client_text_anal = 7:$rnd_client_text_anal = 'В жопу <<$gop_sextext1>> буду'
if rnd_client_text_anal = 8:$rnd_client_text_anal = 'Очко твоё <<$gop_sextext1>> буду'
if rnd_client_text_anal = 9:$rnd_client_text_anal = '<<$gop_sextext1>> в попу буду'
if rnd_client_text_anal = 10:$rnd_client_text_anal = 'Сегодня трахну тебя в очко'
rnd_client_text_all = rand(1,10)
if rnd_client_text_all = 1:$rnd_client_text_all = 'Я пока не решил чего хочу, давай заплачу за все'
if rnd_client_text_all = 2:$rnd_client_text_all = 'Хочу во все твои дырки'
if rnd_client_text_all = 3:$rnd_client_text_all = 'Все твои дырки хочу'
if rnd_client_text_all = 4:$rnd_client_text_all = 'Давай я за все заплачу'
if rnd_client_text_all = 5:$rnd_client_text_all = 'Все хочу опробовать'
if rnd_client_text_all = 6:$rnd_client_text_all = 'А давай во все щели'
if rnd_client_text_all = 7:$rnd_client_text_all = 'А давай все сразу'
if rnd_client_text_all = 8:$rnd_client_text_all = 'Я даже не знаю чего выбрать, давай проплачу за все'
if rnd_client_text_all = 9:$rnd_client_text_all = 'Я пока не решил, давай проплачу за все'
if rnd_client_text_all = 10:$rnd_client_text_all = 'Сегодня хочу все твои дыры'
rnd_client_text_group = rand(1,10)
if rnd_client_text_group = 1:$rnd_client_text_group = 'Я тут не один, мы по быстрому тебя жахнем'
if rnd_client_text_group = 2:$rnd_client_text_group = 'Я не один и мы хотим тебя хорошенько выебать'
if rnd_client_text_group = 3:$rnd_client_text_group = 'Групповушку хочу, но ты не волнуйся, мы побыстрому тебя трахнем'
if rnd_client_text_group = 4:$rnd_client_text_group = 'Я тут не один пришел, не волнуйся мы быстро'
if rnd_client_text_group = 5:$rnd_client_text_group = 'Нам тебя пацаны посоветовали, говорят на все согласная, вот хотим тебя как следует выебать'
if rnd_client_text_group = 6:$rnd_client_text_group = 'Времени у нас мало, мы тебя по быстрому взъебем и разойдемся'
if rnd_client_text_group = 7:$rnd_client_text_group = 'Я с друганом, мы постораемся быстро управиться'
if rnd_client_text_group = 8:$rnd_client_text_group = 'Хотим тебя с товарищем попользовать'
if rnd_client_text_group = 9:$rnd_client_text_group = 'Мы тебя по быстрому трахнем'
if rnd_client_text_group = 10:$rnd_client_text_group = 'Групповушку устроим'
rnd_client_text_bj_vag = rand(1,10)
if rnd_client_text_bj_vag = 1:$rnd_client_text_bj_vag = 'Хочу твой рот и пизду'
if rnd_client_text_bj_vag = 2:$rnd_client_text_bj_vag = 'По быстрому в ротик и письку'
if rnd_client_text_bj_vag = 3:$rnd_client_text_bj_vag = 'Хочу выебать ротик твой и письку'
if rnd_client_text_bj_vag = 4:$rnd_client_text_bj_vag = 'В рот и в пизду трахну'
if rnd_client_text_bj_vag = 5:$rnd_client_text_bj_vag = 'Трахну твой рот и пизду'
if rnd_client_text_bj_vag = 6:$rnd_client_text_bj_vag = '<<$gop_sextext1>> буду в рот и пизду'
if rnd_client_text_bj_vag = 7:$rnd_client_text_bj_vag = 'В пизду и рот <<$gop_sextext1>> буду'
if rnd_client_text_bj_vag = 8:$rnd_client_text_bj_vag = 'Сегодня хочу твой рот и пизду'
if rnd_client_text_bj_vag = 9:$rnd_client_text_bj_vag = 'Я думаю меня устроит твоя пизда и рот'
if rnd_client_text_bj_vag = 10:$rnd_client_text_bj_vag = 'Поебу в рот, а потом в пизду'
rnd_client_text_bj_anal = rand(1,10)
if rnd_client_text_bj_anal = 1:$rnd_client_text_bj_anal = 'Хочу сначало в рот, а потом в попку'
if rnd_client_text_bj_anal = 2:$rnd_client_text_bj_anal = 'Хочу в рот и жопу'
if rnd_client_text_bj_anal = 3:$rnd_client_text_bj_anal = 'Дам в башню, а потом в очко засуну'
if rnd_client_text_bj_anal = 4:$rnd_client_text_bj_anal = 'Рот твой и очко <<$gop_sextext1>> буду'
if rnd_client_text_bj_anal = 5:$rnd_client_text_bj_anal = 'В рот и в жопу'
if rnd_client_text_bj_anal = 6:$rnd_client_text_bj_anal = 'Сегодня в рот и жопу'
if rnd_client_text_bj_anal = 7:$rnd_client_text_bj_anal = 'Трахну в твой сладенький ротик, а потом в попку'
if rnd_client_text_bj_anal = 8:$rnd_client_text_bj_anal = '<<$gop_sextext1>> буду в рот и в очко'
if rnd_client_text_bj_anal = 9:$rnd_client_text_bj_anal = 'В ротик и в попку выебу'
if rnd_client_text_bj_anal = 10:$rnd_client_text_bj_anal = 'Выебу в рот и в попу'
!------------------------------
rnd_client_torgtext = rand(1,5)
if rnd_client_torgtext = 1:$rnd_client_torgtext = 'но дорого, давай скидывай рублей 100'
if rnd_client_torgtext = 2:$rnd_client_torgtext = 'но дорого, сделай скидку в 100 рублей'
if rnd_client_torgtext = 3:$rnd_client_torgtext = 'но что-то я ожидал дешевле будет, давай рублей 100 скинь'
if rnd_client_torgtext = 4:$rnd_client_torgtext = 'но говорили ты дешевле стоишь, давай рублей 100 скидывай и нормально будет'
if rnd_client_torgtext = 5:$rnd_client_torgtext = 'но мне казалось ценник меньше должен быть, давай на сотку дешевле договоримся'
rnd_client_torgtext2 = rand(1,5)
if rnd_client_torgtext2 = 1:$rnd_client_torgtext2 = 'но ценник дороговат, скинь рублей 50 хоть...'
if rnd_client_torgtext2 = 2:$rnd_client_torgtext2 = 'но дороговато, сделай скидку хотя бы рублей 50'
if rnd_client_torgtext2 = 3:$rnd_client_torgtext2 = 'но что-то не так дешево как я думал, давай рублей 50 скинь'
if rnd_client_torgtext2 = 4:$rnd_client_torgtext2 = 'но говорили ты дешевле стоишь, давай рублей 50 скидывай и нормально будет'
if rnd_client_torgtext2 = 5:$rnd_client_torgtext2 = 'но мне не хватает чуть-чуть, скинешь 50 руб?'
rnd_client_torgtext3 = rand(1,5)
if rnd_client_torgtext3 = 1:$rnd_client_torgtext3 = 'но это же пиздец дорого, мне говорили ты не дорогая <<$gg_whore_text>>!'
if rnd_client_torgtext3 = 2:$rnd_client_torgtext3 = 'но это дорого, мне говорили ты не дорогая <<$gg_whore_text>>!'
if rnd_client_torgtext3 = 3:$rnd_client_torgtext3 = 'но мне <<$gop_text_npcr>> говорили ты не дорогая <<$gg_whore_text>>!'
if rnd_client_torgtext3 = 4:$rnd_client_torgtext3 = 'но <<$gop_text_npcr>> сказали ты ценник накручиваешь!'
if rnd_client_torgtext3 = 5:$rnd_client_torgtext3 = 'но что-то ты много денег хочешь с меня содрать!'
rnd_client_torgtext4 = rand(1,7)
if rnd_client_torgtext4 = 1:$rnd_client_torgtext4 = 'пойдет?'
if rnd_client_torgtext4 = 2:$rnd_client_torgtext4 = 'согласна?'
if rnd_client_torgtext4 = 3:$rnd_client_torgtext4 = 'устроит?'
if rnd_client_torgtext4 = 4:$rnd_client_torgtext4 = 'договорились?'
if rnd_client_torgtext4 = 5:$rnd_client_torgtext4 = 'возьмешь?'
if rnd_client_torgtext4 = 6:$rnd_client_torgtext4 = 'нормуль?'
if rnd_client_torgtext4 = 7:$rnd_client_torgtext4 = 'хорошо?'
rnd_client_torgtext5 = rand(1,5)
if rnd_client_torgtext5 = 1:$rnd_client_torgtext5 = 'могу дать'
if rnd_client_torgtext5 = 2:$rnd_client_torgtext5 = 'у меня есть'
if rnd_client_torgtext5 = 3:$rnd_client_torgtext5 = 'наскребу'
if rnd_client_torgtext5 = 4:$rnd_client_torgtext5 = 'у меня только'
if rnd_client_torgtext5 = 5:$rnd_client_torgtext5 = 'есть только'
!отказ
$pod_whore_no = {
	*clr & cla
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/no2.jpg"></center>'
	gs 'zz_render', '', '', func('pod_whore_strings', '20')
	act 'Уйти': gt'korrPar'
}
!не сошлись в цене:
$pod_whore_noprice = {
	*clr & cla
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/no1.jpg"></center>'
	gs 'zz_render', '', '', func('pod_whore_strings', '21')
	act 'Уйти': gt'korrPar'
}
!озвучиваем ценник
$pod_whore_price = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '22')
	if whore_money_rnd <= 0:
		gs 'zz_render', '', '', func('pod_whore_strings', '23')
	end
gs 'zz_render', '', '', func('pod_whore_strings', '24')
!'<<money_silicone>> + <<money_mop>> + <<money_hapri>> + <<money_glamur>> + <<money_odethooker>> + <<money_skin>> + <<money_skin_tan>> + <<money_leghair>> + <<money_resnic>> + <<money_lipbalmstat>> + <<whore_dopmoney>> + <<money_throat>> | - <<money_vagina>> - <<money_anus>> - <<money_vnesh>> - <<money_horny>> - <<money_cumfrot>> - <<money_sweat>> - <<money_cumlip>> - <<money_cumface>> - <<money_cumbelly>> - <<money_cumpussy>> - <<money_cumanus>> - <<money_cumass>> - <<money_son>>'
rnd_client_event = RAND(1,7)
	if rnd_client_event = 1:$rnd_client_text = '<<$rnd_client_text_bj>>' & $rnd_client_event = $pod_whore_ev1 & total_money = '<<whore_money_bjsex>>'
	if rnd_client_event = 2:$rnd_client_text = '<<$rnd_client_text_vag>>' & $rnd_client_event = $pod_whore_ev2 & total_money = '<<whore_money_clsex>>'
	if rnd_client_event = 3:$rnd_client_text = '<<$rnd_client_text_anal>>' & $rnd_client_event = $pod_whore_ev3 & total_money = '<<whore_money_analsex>>'
	if rnd_client_event = 4:$rnd_client_text = '<<$rnd_client_text_all>>' & $rnd_client_event = $pod_whore_ev4 & total_money = '<<whore_money_allsex>>'
	if rnd_client_event = 5:$rnd_client_text = '<<$rnd_client_text_group>>' & $rnd_client_event = $pod_whore_ev5 & total_money = '<<whore_money_groupsex>>'
	if rnd_client_event = 6:$rnd_client_text = '<<$rnd_client_text_bj_vag>>' & $rnd_client_event = $pod_whore_ev6 & total_money = '<<whore_money_bjvagsex>>'
	if rnd_client_event = 7:$rnd_client_text = '<<$rnd_client_text_bj_anal>>' & $rnd_client_event = $pod_whore_ev7 & total_money = '<<whore_money_bjanalsex>>'
!сколько денег за секс предлогает клиент если: минет, пизда или анал
$rnd_client_money = rand(150,245)
rnd_client_money = $rnd_client_money
!сколько денег за секс предлогает клиент если: все и сразу или групповуха
$rnd_client_money2 = rand(450,595)
rnd_client_money2 = $rnd_client_money2
!сколько денег за секс предлогает клиент если: минет + пизда или минет + анал
$rnd_client_money3 = rand(300,445)
rnd_client_money3 = $rnd_client_money3
rnd_clint_torg = RAND(1,5)
	if rnd_clint_torg = 1:$rnd_clint_torg = 'Клиент отвечает: — <<$rnd_client_text>>!'
	if rnd_clint_torg = 2:
		if total_money >= 250:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '25')
		else
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '26')
		end
	end
	if rnd_clint_torg = 3:
		if total_money >= 150:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '27')
		else
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '28')
		end
	end
	if rnd_clint_torg = 4:
		if rnd_client_event < 4 and total_money >= 250:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '29')
			total_money = '<<rnd_client_money>>'
		elseif rnd_client_event < 4 and total_money < 250:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '30')
		end
		if rnd_client_event >= 4 and rnd_client_event <= 5 and total_money >= 600:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '31')
			total_money = '<<rnd_client_money2>>'
		elseif rnd_client_event >= 4 and total_money < 600:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '32')
		end
		if rnd_client_event >= 6 and total_money >= 450:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '33')
			total_money = '<<rnd_client_money3>>'
		elseif rnd_client_event >= 6 and total_money < 450:
			$rnd_clint_torg = ''
			gs 'zz_render', '', '', func('pod_whore_strings', '34')
		end
	end
	if rnd_clint_torg = 5:$rnd_clint_torg = 'Клиент отвечает: — <<$rnd_client_text>>!'
	gs 'zz_render', '', '', func('pod_whore_strings', '35')
	act 'Обслужить': slutty += 1 & dynamic $rnd_client_event
	if rnd_clint_torg >= 2 and rnd_clint_torg <= 4:
		act 'Отказать': dynamic $pod_whore_noprice
	end
}
!долгий разговор не о чем)
$pod_client_talk_bazar1 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '36')
act 'Возмутиться': dynamic $pod_client_talk_bazar2
}
$pod_client_talk_bazar2 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '37')
if pod_whore_countQW <= 15:
	gs 'zz_render', '', '', func('pod_whore_strings', '38')
	act 'Закрыть дверь': gt'korrPar'
elseif pod_whore_countQW > 15:
	gs 'zz_render', '', '', func('pod_whore_strings', '39')
	act 'Парировать': dynamic $pod_client_talk_bazar3
	act 'Смягчить тон': dynamic $pod_client_talk_bazar5
end
}
$pod_client_talk_bazar3 = {
cla
dom -= 1
gs'stat'
gs 'zz_render', '', '', func('pod_whore_strings', '40')
act 'И это все?': dynamic $pod_client_talk_bazar9
act 'Закрыть дверь': gt'korrPar'
}
$pod_client_talk_bazar4 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '41')
act 'Закрыть дверь': gt'korrPar'
}
$pod_client_talk_bazar5 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '42')
act 'Продолжить глумление': dynamic $pod_client_talk_bazar6
act 'Закончить разговор': dynamic $pod_client_talk_bazar7
}
$pod_client_talk_bazar6 = {
cla
dom -= 1
gs'stat'
gs 'zz_render', '', '', func('pod_whore_strings', '43')
act 'Признаться': dynamic $pod_client_talk_bazar8
act 'Закончить разговор': dynamic $pod_client_talk_bazar7
}
$pod_client_talk_bazar7 = {
cla
dom -= 1
gs'stat'
gs 'zz_render', '', '', func('pod_whore_strings', '44')
act 'Закрыть дверь': gt'korrPar'
}
$pod_client_talk_bazar8 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '45')
act 'Озвучить ценник': dynamic $pod_whore_price
}
$pod_client_talk_bazar9 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '46')
act 'Да': dynamic $pod_client_talk_bazar10
act 'Нет': dynamic $pod_client_talk_bazar11
}
$pod_client_talk_bazar10 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '47')
act 'Даже так': dynamic $pod_client_talk_bazar12
act 'Нет, я пошутила': dynamic $pod_client_talk_bazar13
}
$pod_client_talk_bazar11 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '48')
act 'Озвучить ценник': dynamic $pod_whore_price
}
$pod_client_talk_bazar12 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '49')
act 'Нет': dynamic $pod_client_talk_bazar14
}
$pod_client_talk_bazar13 = {
cla
dom -= 1
gs'stat'
gs 'zz_render', '', '', func('pod_whore_strings', '50')
act 'Закрыть дверь': gt'korrPar'
}
$pod_client_talk_bazar14 = {
cla
gs 'zz_render', '', '', func('pod_whore_strings', '51')
act 'Озвучить ценник': dynamic $pod_whore_price
}
!гг сказала, что она не <<$name[1]>>
$pod_client_talk_no = {
cla
gs'stat'
gs 'zz_render', '', '', func('pod_whore_strings', '52')
	act 'Тут таких нет': dynamic $pod_client_talk_bazar4
	act 'А вам зачем?': dynamic $pod_client_talk_bazar1
}
!гг устала и не может принять клиента
$pod_client_talk_noson = {
cla
gs'stat'
gs 'zz_render', '', '', func('pod_whore_strings', '53')
act 'Закрыть дверь': gt'korrPar'
}
!болтовня с клиентом
$pod_client_talk = {
	*clr & cla
	gs'stat'
	if whore_money_bjsex < 50: '<center><img src="images/zsoft/pod_ezd/whore/fear.jpg"></center>'
	if current_clothing <= 2 and whore_money_bjsex >= 50:
	'<center><img src="images/zsoft/pod_ezd/whore/door_nude'+rand(1,3)+'.jpg"></center>'
	elseif current_clothing > 2 and whore_money_bjsex >= 50:
		'<center><img src="images/zsoft/pod_ezd/whore/door'+iif(func('zz_clothing','is_glamour') = 1,'_glamur','')+'.jpg"></center>'
	end
	if whore_money_bjsex < 50:
	gs 'zz_render', '', '', func('pod_whore_strings', '54')
		act 'Уйти': gt'korrPar'
	elseif whore_money_bjsex >=50:
	gs 'zz_render', '', '', func('pod_whore_strings', '55')
	act 'Да':
		cla
		gs'stat'
		gs 'zz_render', '', '', func('pod_whore_strings', '56')
		if son >= 2 and pod_whore_client_count > 0: act 'Озвучить ценник': dynamic $pod_whore_price
		if son >= 2 and pod_whore_client_count > 0: act 'Отказать': dynamic $pod_whore_no
		if son < 2 or pod_whore_client_count <= 0: act 'Отказать': dynamic $pod_client_talk_noson
		end
	act 'Нет': dynamic $pod_client_talk_no
	!act 'Тест гифок': dynamic $pod_whore_test_gifs
	end
}
$pod_whore_test_gifs = {
	*clr & cla
	'<center><img src="images/zsoft/pod_ezd/whore/sex/cum'+rand(1,7)+'.gif"></center>'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/bj'+rand(1,17)+'.gif"></center>'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(1,14)+'.gif"></center>'
	act 'Еще': dynamic $pod_whore_test_gifs
	act 'Выход': gt'pod_ezd','etaj_2'
}
!==========================================================
!конец ивентов:
$pod_whore_ev_end = {
	*clr & cla
	guy += 1
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	if current_clothing > 2: cumfrot = 1
	if energy >=3: energy -= 1
	minut += rand(2,5)
	money += total_money
	pod_whore_countQW += 1
	pod_whore_client_day = daystart
	pod_whore_client_count -= 1
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/cum'+rand(1,7)+'.gif"></center>'
	dynamic $text_pod_whore_cum
	gs 'zz_render', '', '', func('pod_whore_strings', '57')
	act 'Уйти': gt'pod_ezd','etaj_2'
}
!==============
!старт ивентов:
!--------------
!отсос
$pod_whore_ev1 = {
	*clr & cla
	bj +=1
	horny += 5
	minut += rand(5,15)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/bj'+rand(1,17)+'.gif"></center>'
	dynamic $text_pod_whore_bj
	dynamic $accview_ggsex
	act 'Далее': dynamic $pod_whore_ev_end
}
!классик секс
$pod_whore_ev2 = {
	*clr & cla
	sex +=1
	horny += 10
	minut += rand(7,15)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(1,7)+'.gif"></center>'
	dynamic $text_pod_whore_vag
	dynamic $gg_sex_orgasm
	dynamic $accview_ggsex
	act 'Далее': dynamic $pod_whore_ev_end
}
!анал секс
$pod_whore_ev3 = {
	*clr & cla
	anal +=1
	horny += 5
	minut += rand(7,15)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(8,14)+'.gif"></center>'
	dynamic $text_pod_whore_anal
	dynamic $accview_ggsex
	act 'Далее': dynamic $pod_whore_ev_end
}
!все включено
$pod_whore_ev4 = {
	*clr & cla
	bj +=1
	horny += 5
	minut += rand(3,12)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/bj'+rand(1,17)+'.gif"></center>'
	dynamic $text_pod_whore_bj
		act 'Далее':
		*clr & cla
		sex +=1
		horny += 10
		minut += rand(5,13)
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(1,7)+'.gif"></center>'
		dynamic $text_pod_whore_vag
		dynamic $gg_sex_orgasm
		dynamic $accview_ggsex
			act 'Далее':
			*clr & cla
			anal +=1
			horny += 5
			minut += rand(7,15)
			gs'stat'
			'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(8,14)+'.gif"></center>'
			dynamic $text_pod_whore_anal
			act 'Далее': dynamic $pod_whore_ev_end
		end
	end
}
!минет + классик секс
$pod_whore_ev6 = {
	*clr & cla
	bj +=1
	horny += 5
	minut += rand(5,15)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/bj'+rand(1,17)+'.gif"></center>'
	dynamic $text_pod_whore_bj
	act 'Далее':
		*clr & cla
		sex +=1
		horny += 10
		minut += rand(7,15)
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(1,7)+'.gif"></center>'
		dynamic $text_pod_whore_vag
		dynamic $gg_sex_orgasm
		dynamic $accview_ggsex
		act 'Далее': dynamic $pod_whore_ev_end
	end
}
!минет + анал секс
$pod_whore_ev7 = {
	*clr & cla
	bj +=1
	horny += 5
	minut += rand(5,15)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/bj'+rand(1,17)+'.gif"></center>'
	dynamic $text_pod_whore_bj
	act 'Далее':
		*clr & cla
		anal +=1
		horny += 5
		minut += rand(7,15)
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/whore/sex/sex'+rand(8,14)+'.gif"></center>'
		dynamic $text_pod_whore_anal
		dynamic $accview_ggsex
		act 'Далее': dynamic $pod_whore_ev_end
	end
}
!-----------------
!текст групповухи:
!=================
!минет
$text_pod_whore_groupbj = {
txt_pod_whore_groupbj = rand(1,2)
if txt_pod_whore_groupbj = 1:$txt_pod_whore_groupbj = ''
gs 'zz_render', '', '', func('pod_whore_strings', '58')
if txt_pod_whore_groupbj = 2:$txt_pod_whore_groupbj = ''
gs 'zz_render', '', '', func('pod_whore_strings', '59')
if txt_pod_whore_groupbj = 3:$txt_pod_whore_groupbj = ''
gs 'zz_render', '', '', func('pod_whore_strings', '60')
if txt_pod_whore_groupbj = 4:$txt_pod_whore_groupbj = ''
	gs 'zz_render', '', '', func('pod_whore_strings', '61')
}
!секс
$text_pod_whore_groupsex = {
txt_pod_whore_groupsex = rand(1,3)
if txt_pod_whore_groupsex = 1:$txt_pod_whore_groupsex = ''
gs 'zz_render', '', '', func('pod_whore_strings', '62')
if txt_pod_whore_groupsex = 2:$txt_pod_whore_groupsex = ''
gs 'zz_render', '', '', func('pod_whore_strings', '63')
if txt_pod_whore_groupsex = 3:$txt_pod_whore_groupsex = ''
gs 'zz_render', '', '', func('pod_whore_strings', '64')
!if txt_pod_whore_groupsex = 4:$txt_pod_whore_groupsex = ''
	gs 'zz_render', '', '', func('pod_whore_strings', '65')
}
$pod_whore_ev5 = {
	dynamic iif(rand(1,2)=1,$pod_whore_groupsexev1,$pod_whore_groupsexev2)
}
!групповуха ивент 1
$pod_whore_groupsexev1 = {
*clr & cla
guy +=2
bj +=2
horny += 10
minut += rand(3,10)
gs'stat'
'<center><img src="images/zsoft/pod_ezd/whore/sex/group/1_1_'+rand(1,2)+'.jpg"></center>'
dynamic $text_pod_whore_groupbj
	act 'Далее':
	*clr & cla
	sex +=1
	horny += 10
	minut += rand(5,11)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/group/1_2_'+rand(1,2)+'.jpg"></center>'
	dynamic $text_pod_whore_groupsex
	dynamic $gg_sex_orgasm
	dynamic $accview_ggsex
		act 'Далее':
		*clr & cla
		sex +=1
		horny += 15
		minut += rand(7,12)
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/whore/sex/group/1_3.jpg"></center>'
		dynamic $text_pod_whore_groupsex
		dynamic $gg_sex_orgasm
				act 'Далее':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				if current_clothing > 2: cumfrot = 1
				swallow += 1
				if energy >= 3: energy -= 2
				minut += rand(3,7)
				money += total_money
				pod_whore_countQW += 1
				pod_whore_client_day = daystart
				pod_whore_client_count -= 1
				gs'stat'
				'<center><img src="images/zsoft/pod_ezd/whore/sex/group/1_4_'+rand(1,2)+'.jpg"></center>'
				gs 'zz_render', '', '', func('pod_whore_strings', '66')
			act 'Уйти': gt'pod_ezd','etaj_2'
		end
	end
end
}
!групповуха ивент 2
$pod_whore_groupsexev2 = {
*clr & cla
guy +=2
bj +=2
horny += 10
minut += rand(3,10)
gs'stat'
'<center><img src="images/zsoft/pod_ezd/whore/sex/group/2_1_'+rand(1,2)+'.gif"></center>'
dynamic $text_pod_whore_groupbj
	act 'Далее':
	*clr & cla
	sex +=1
	horny += 10
	minut += rand(5,10)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/whore/sex/group/2_2_1.gif"></center>'
	dynamic $text_pod_whore_groupsex
	dynamic $gg_sex_orgasm
	dynamic $accview_ggsex
		act 'Далее':
		*clr & cla
		sex +=1
		horny += 15
		minut += rand(5,10)
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/whore/sex/group/2_3_1.gif"></center>'
		gs 'zz_render', '', '', func('pod_whore_strings', '67')
		dynamic $gg_sex_orgasm
			act 'Далее':
			*clr & cla
			minut += rand(5,10)
			gs'stat'
			'<center><img src="images/zsoft/pod_ezd/whore/sex/group/2_2_'+rand(2,3)+'.gif"></center>'
			gs 'zz_render', '', '', func('pod_whore_strings', '68')
			dynamic $gg_sex_orgasm
				act 'Далее':
				*clr & cla
				minut += rand(5,10)
				gs'stat'
				'<center><img src="images/zsoft/pod_ezd/whore/sex/group/2_3_2.gif"></center>'
				gs 'zz_render', '', '', func('pod_whore_strings', '69')
				dynamic $gg_sex_orgasm
					act 'Далее':
					*clr & cla
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					if current_clothing > 2: cumfrot = 1
					swallow += 1
					if energy >= 3: energy -= 2
					minut += rand(3,7)
					money += total_money
					pod_whore_countQW += 1
					pod_whore_client_day = daystart
					pod_whore_client_count -= 1
					gs'stat'
					'<center><img src="images/zsoft/pod_ezd/whore/sex/group/2_4.jpg"></center>'
					gs 'zz_render', '', '', func('pod_whore_strings', '70')
					act 'Уйти': gt'pod_ezd','etaj_2'
				end
			end
		end
	end
end
}