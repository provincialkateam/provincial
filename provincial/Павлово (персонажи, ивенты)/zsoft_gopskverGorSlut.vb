!бухач гг с гопотой в парке Павлово, если у нее репа >= 3 и когда ее гопота уже опустила
$metka = $ARGS[0]
$loc = $CURLOC
if $ARGS[0] = '1':
	*clr & cla
	gs'stat'
	gs'time'
	'<center><img src="images/gevent/skver.jpg"></center>'
!разные рандомные вариации разговоров гопоты
gop_textr = RAND(0,3)
	if gop_textr = 0:$gop_textr = 'пацаны'
 	if gop_textr = 1:$gop_textr = 'ребята'
 	if gop_textr = 2:$gop_textr = 'кореша'
 	if gop_textr = 3:$gop_textr = 'друганы'
gop_textr4 = RAND(0,3)
	if gop_textr4 = 0:$gop_textr4 = 'пацанам'
 	if gop_textr4 = 1:$gop_textr4 = 'ребятам'
 	if gop_textr4 = 2:$gop_textr4 = 'однокласникам'
 	if gop_textr4 = 3:$gop_textr4 = 'друзьям'
gop_sex_textr = RAND(0,6)
	if gop_sex_textr = 0:$gop_sex_textr = 'пользовать'
	if gop_sex_textr = 1:$gop_sex_textr = 'ебать'
	if gop_sex_textr = 2:$gop_sex_textr = 'трахать'
	if gop_sex_textr = 3:$gop_sex_textr = 'драть'
	if gop_sex_textr = 4:$gop_sex_textr = 'шпилить'
	if gop_sex_textr = 5:$gop_sex_textr = 'вертеть'
	if gop_sex_textr = 6:$gop_sex_textr = 'дрючить'
gop_sex_textr2 = RAND(0,1)
	if gop_sex_textr2 = 0:$gop_sex_textr2 = 'трахнет'
	if gop_sex_textr2 = 1:$gop_sex_textr2 = 'выебет'
gop_sex_textr3 = RAND(0,6)
	if gop_sex_textr3 = 0:$gop_sex_textr3 = 'ебали'
	if gop_sex_textr3 = 1:$gop_sex_textr3 = 'драли'
	if gop_sex_textr3 = 2:$gop_sex_textr3 = 'шпилили'
	if gop_sex_textr3 = 3:$gop_sex_textr3 = 'трахали'
	if gop_sex_textr3 = 4:$gop_sex_textr3 = 'вертели'
	if gop_sex_textr3 = 5:$gop_sex_textr3 = 'пользовали'
	if gop_sex_textr3 = 6:$gop_sex_textr3 = 'дрючили'
gop_textr3 = RAND(0,4)
	if gop_textr3 = 0:$gop_textr3 = 'трогать'
	if gop_textr3 = 1:$gop_textr3 = 'мацать'
	if gop_textr3 = 2:$gop_textr3 = 'щупать'
	if gop_textr3 = 3:$gop_textr3 = 'мять'
	if gop_textr3 = 4:$gop_textr3 = 'гладить'
shultextrand = RAND(0,20)
	if shultextrand = 0:$shultextrand = 'хочешь конфетку красный богатырь?'
	if shultextrand = 1:$shultextrand = 'хочешь Чупахуй?'
	if shultextrand = 2:$shultextrand = 'поебаца пришла?'
	if shultextrand = 3:$shultextrand = 'хочешь что бы выебали?'
	if shultextrand = 4:$shultextrand = 'хочешь хуй в жопу?'
	if shultextrand = 5:$shultextrand = 'хочешь много хуев?'
	if shultextrand = 6:$shultextrand = 'хочешь выебем?'
	if shultextrand = 7:$shultextrand = 'хочешь хуем по лбу?'
	if shultextrand = 8:$shultextrand = 'ебли захотелось?'
	if shultextrand = 9:$shultextrand = 'ща выебем!'
	if shultextrand = 10:$shultextrand = 'быстро в стойку встала!'
	if shultextrand = 11:$shultextrand = 'ебальник вниз, жопу вверх!'
	if shultextrand = 12:$shultextrand = 'ща по кругу пустим!'
	if shultextrand = 13:$shultextrand = 'дупло готовь!'
	if shultextrand = 14:$shultextrand = 'раком становись!'
	if shultextrand = 15:$shultextrand = 'чего пришла, секса не хватает?'
	if shultextrand = 16:$shultextrand = 'чего надо?, хуй в пизду и шоколада?'
	if shultextrand = 17:$shultextrand = 'чего пришла, дырки зудят?'
	if shultextrand = 18:$shultextrand = 'раз пришла нагибайся, <<$gop_sex_textr>> будем!'
	if shultextrand = 19:$shultextrand = 'три хуя хочешь?'
	if shultextrand = 20:$shultextrand = 'грязной ебли захотелось?'
shultextrand2 = RAND(0,30)
	if shultextrand2 = 0:$shultextrand2 = 'шмара'
	if shultextrand2 = 1:$shultextrand2 = 'давалка'
	if shultextrand2 = 2:$shultextrand2 = 'шлюха'
	if shultextrand2 = 3:$shultextrand2 = 'хуесоска'
	if shultextrand2 = 4:$shultextrand2 = 'защеканка'
	if shultextrand2 = 5:$shultextrand2 = 'дырка'
	if shultextrand2 = 6:$shultextrand2 = 'блядь'
	if shultextrand2 = 7:$shultextrand2 = 'шлюшка'
	if shultextrand2 = 8:$shultextrand2 = 'мокрощелка'
	if shultextrand2 = 9:$shultextrand2 = 'сука'
	if shultextrand2 = 10:$shultextrand2 = 'сучка'
	if shultextrand2 = 11:$shultextrand2 = 'общая дырка'
	if shultextrand2 = 12:$shultextrand2 = 'анальная сука'
	if shultextrand2 = 13:$shultextrand2 = 'вафлёрша'
	if shultextrand2 = 14:$shultextrand2 = 'наша игрушка'
	if shultextrand2 = 15:$shultextrand2 = 'спермоприемник'
	if shultextrand2 = 16:$shultextrand2 = 'поблядушка'
	if shultextrand2 = 17:$shultextrand2 = 'бесплатная блядь'
	if shultextrand2 = 18:$shultextrand2 = 'соска'
	if shultextrand2 = 19:$shultextrand2 = '<<$name[2]>>-конфетка'
	if shultextrand2 = 20:$shultextrand2 = 'ебливая дырка'
	if shultextrand2 = 21:$shultextrand2 = '<<$name[2]>>-нимфетка'
	if shultextrand2 = 22:$shultextrand2 = 'сасалка'
	if shultextrand2 = 23:$shultextrand2 = 'ебанашка'
	if shultextrand2 = 24:$shultextrand2 = 'трехдырочная'
	if shultextrand2 = 25:$shultextrand2 = 'безотказная давалка'
	if shultextrand2 = 26:$shultextrand2 = 'школьная давалка'
	if shultextrand2 = 27:$shultextrand2 = 'дворовая блядь'
	if shultextrand2 = 28:$shultextrand2 = 'потаскушка'
	if shultextrand2 = 29:$shultextrand2 = '<<$gnikname>>'
	if shultextrand2 = 30:$shultextrand2 = 'соска'
shultextrand3 = RAND(0,4)
	if shultextrand3 = 0:$shultextrand3 = 'Шульга'
	if shultextrand3 = 1:$shultextrand3 = 'Витек'
	if shultextrand3 = 2:$shultextrand3 = 'Рыжов'
	if shultextrand3 = 3:$shultextrand3 = 'Котов'
	if shultextrand3 = 4:$shultextrand3 = 'Дэн'
shultextrand33 = RAND(0,4)
	if shultextrand33 = 0:$shultextrand33 = 'Витек'
	if shultextrand33 = 1:$shultextrand33 = 'Дэн'
	if shultextrand33 = 2:$shultextrand33 = 'Шульга'
	if shultextrand33 = 3:$shultextrand33 = 'Котов'
	if shultextrand33 = 4:$shultextrand33 = 'Рыжов'
shultextrand7 = RAND(0,4)
	if shultextrand7 = 0:$shultextrand7 = 'попу'
	if shultextrand7 = 1:$shultextrand7 = 'попку'
	if shultextrand7 = 2:$shultextrand7 = 'жопу'
	if shultextrand7 = 3:$shultextrand7 = 'сиську'
	if shultextrand7 = 4:$shultextrand7 = 'грудь'
shultextrand4 = RAND(0,20)
	if shultextrand4 = 0:$shultextrand4 = '<<$gop_textr>> громко заржали над вами'
	if shultextrand4 = 1:$shultextrand4 = '<<$shultextrand33>> начал <<$gop_textr3>> вас за <<$shultextrand7>>'
	if shultextrand4 = 2:$shultextrand4 = '<<$gop_textr>> подошли ближе к вам, <<$shultextrand33>> звонко шлепнул по попке'
	if shultextrand4 = 3:$shultextrand4 = '<<$shultextrand33>> засунул руку вам в трусы'
	if shultextrand4 = 4:$shultextrand4 = '<<$shultextrand33>> взялся за вашу <<$shultextrand7>>'
	if shultextrand4 = 5:$shultextrand4 = '<<$shultextrand33>> шлёпнул вас по попке'
	if shultextrand4 = 6:$shultextrand4 = '<<$shultextrand33>> стал <<$gop_textr3>> вашу <<$shultextrand7>>'
	if shultextrand4 = 7:$shultextrand4 = '<<$shultextrand33>> схватился за <<$shultextrand7>> и прижал ваше тело к себе'
	if shultextrand4 = 8:$shultextrand4 = '<<$shultextrand33>> начал давить вам на плечи'
	if shultextrand4 = 9:$shultextrand4 = '<<$gop_textr>> начали <<$gop_textr3>> вашу грудь, <<$shultextrand33>> ущепнул за попку'
	if shultextrand4 = 10:$shultextrand4 = '<<$gop_textr>> начали растегивать ширинки, <<$shultextrand33>> первый вавалил свое хозяйство и потянул вашу руку к багровой головке'
	if shultextrand4 = 11:$shultextrand4 = '<<$shultextrand33>> сказал вам: "мы тут место знаем тихое, вчера Соньку там <<$gop_sex_textr3>>" и <<$gop_textr>> потащили вас в глубь леса'
	if shultextrand4 = 12:$shultextrand4 = '<<$shultextrand33>> засмотрелся на вашу <<$shultextrand7>>, остальные <<$gop_textr>> ухмыльнулись'
	if shultextrand4 = 13:$shultextrand4 = '<<$gop_textr>> переглянулись, <<$shultextrand33>> подошел ближе к вам и шепнул вам на ушко: "Твоя подружка Сонька всегда удовлетворенная от нас уходит"'
	if shultextrand4 = 14:$shultextrand4 = '<<$gop_textr>> пристально разглядывают вас, <<$shultextrand33>> крикнул: "<<$name[1]>> звезда миньета"'
	if shultextrand4 = 15:$shultextrand4 = '<<$gop_textr>> обсуждают как вчера вон за той березой Соньку <<$gop_sex_textr3>> по очереди, <<$shultextrand33>> сказал вам: "<<$name[2]>>, твоя очередь нас ублажать"'
	if shultextrand4 = 16:$shultextrand4 = '<<$shultextrand33>> взял вашу руку и положил на свой пах'
	if shultextrand4 = 17:$shultextrand4 = '<<$shultextrand33>> что-то шепнул вам на ушко'
	if shultextrand4 = 18:$shultextrand4 = '<<$shultextrand33>> схватил вас за <<$shultextrand7>>, <<$gop_textr>> ухмыльнулись'
	if shultextrand4 = 19:$shultextrand4 = '<<$shultextrand33>> подмигнул вам, достал хуй и начал дрочить'
	if shultextrand4 = 20:$shultextrand4 = '<<$shultextrand33>> предложил вас выебать прям тут на лавочке, <<$gop_textr>> кивнули в знак согласия'
	if shultextrand4 = 20:$shultextrand4 = '<<$shultextrand33>> засунул руку вам в трусы и схватился за киску'
shultextrand5 = RAND(0,17)
	if shultextrand5 = 0:$shultextrand5 = 'Вы увидели у ребят выпуклось между ног'
	if shultextrand5 = 1:$shultextrand5 = 'Вас бросило в жар от возбуждения'
	if shultextrand5 = 2:$shultextrand5 = 'Вы растерялись, не зная что делать'
	if shultextrand5 = 3:$shultextrand5 = 'Вы судорожно начали соображать что делать'
	if shultextrand5 = 4:$shultextrand5 = 'Вас возбудило их отношение к вам'
	if shultextrand5 = 5:$shultextrand5 = 'Вы увидили их горящие глаза и все поняли'
	if shultextrand5 = 6:$shultextrand5 = 'Вы начали думать остаться или уйти'
	if shultextrand5 = 7:$shultextrand5 = 'Вы перевозбужденно хлопали глазками'
	if shultextrand5 = 8:$shultextrand5 = 'Вы по блядски улыбались'
	if shultextrand5 = 9:$shultextrand5 = 'С вас не сходила блядская улыбка'
	if shultextrand5 = 10:$shultextrand5 = 'Вас возбудило такое грязное отношение к себе'
	if shultextrand5 = 11:$shultextrand5 = 'Вам было пофиг на их издевки'
	if shultextrand5 = 12:$shultextrand5 = 'Вы не обращали внимание на их подколы'
	if shultextrand5 = 13:$shultextrand5 = 'Их болтовня вас не смутила'
	if shultextrand5 = 14:$shultextrand5 = 'Вы были не против такого отношения к себе'
	if shultextrand5 = 15:$shultextrand5 = 'Вас этот разговор ни чуть не удивил'
	if shultextrand5 = 16:$shultextrand5 = 'Вы покорно хлопали глазками'
	if shultextrand5 = 17:$shultextrand5 = 'Вы уже давно привыкли к такому обращению'
shultextrand6 = RAND(0,17)
	if shultextrand6 = 0:$shultextrand6 = 'куражась'
	if shultextrand6 = 1:$shultextrand6 = 'с ухмылкой'
	if shultextrand6 = 2:$shultextrand6 = 'со смешком'
	if shultextrand6 = 3:$shultextrand6 = 'сдерживая смех'
	if shultextrand6 = 4:$shultextrand6 = 'спокойно'
	if shultextrand6 = 5:$shultextrand6 = 'возбужденно'
	if shultextrand6 = 6:$shultextrand6 = 'громко'
	if shultextrand6 = 7:$shultextrand6 = 'оглядываясь'
	if shultextrand6 = 8:$shultextrand6 = 'попивая пиво'
	if shultextrand6 = 9:$shultextrand6 = 'потирая ширинку'
	if shultextrand6 = 10:$shultextrand6 = 'потирая ладони'
	if shultextrand6 = 11:$shultextrand6 = 'в пол голоса'
	if shultextrand6 = 12:$shultextrand6 = 'задумчиво'
	if shultextrand6 = 13:$shultextrand6 = 'одобрительно'
	if shultextrand6 = 14:$shultextrand6 = 'вяло'
	if shultextrand6 = 15:$shultextrand6 = 'перевозбужденно'
	if shultextrand6 = 16:$shultextrand6 = 'надменно'
	if shultextrand6 = 17:$shultextrand6 = 'грубо'
shul_text_byh = RAND(0,4)
	if shul_text_byh = 0:$shul_text_byh = 'Ну проходи, обслужим по полной'
	if shul_text_byh = 1:$shul_text_byh = 'Присаживайся, дадим пивка'
	if shul_text_byh = 2:$shul_text_byh = 'Не вопрос, ща нальем'
	if shul_text_byh = 3:$shul_text_byh = 'Да легко, проходи садись, нальем пивасик'
	if shul_text_byh = 4:$shul_text_byh = 'Ну проходи, нальем пивка'
text_sveta_obol = RAND(0,8)
	if text_sveta_obol = 0:$text_sveta_obol = 'обольстительной'
	if text_sveta_obol = 1:$text_sveta_obol = 'соблазнительной'
	if text_sveta_obol = 2:$text_sveta_obol = 'блядской'
	if text_sveta_obol = 3:$text_sveta_obol = 'очаровательной'
	if text_sveta_obol = 4:$text_sveta_obol = 'привлекательной'
	if text_sveta_obol = 5:$text_sveta_obol = 'пленительной'
	if text_sveta_obol = 6:$text_sveta_obol = 'чарующей'
	if text_sveta_obol = 7:$text_sveta_obol = 'прелестной'
	if text_sveta_obol = 8:$text_sveta_obol = 'восхитительной'
	'<<$shultextrand3>> <<$shultextrand6>> говорит вам "Эй <<$shultextrand2>>, <<$shultextrand>>" <<$shultextrand4>>.'
	'<<$shultextrand5>>.'
	'Вам хочется холодного пивасика и вы решаете перехватить инициативу. - "Мальчики, зачем так грубо, может лучше угостите даму пивком?" - игривым тоном говорите вы, принимая соблазнительную позу и улыбаясь своей самой <<$text_sveta_obol>> улыбкой. <<$gop_textr>> переглядываются, о чем-то быстро шушукаются и <<$shultextrand33>> ухмыляясь, машет рукой, подзывая вас.'
	'Покачивая бедрами и томно облизывая свои пересохшие <<$lipbalmstat>> <<$liptalk3>>, вы подходите к троице парней. При виде запотевшей бутылки холодного пивасика, рот сразу наполнился слюной.'
	'<<$shultextrand33>> <<$shultextrand6>> говорит вам "<<$shul_text_byh>>"'
	act 'Уйти':gt'zz_park'
	act 'Пить пиво':gt'zsoft_gopskverGorSlut','2'
end
!act 'Плесните пивка для расслабона':
if $ARGS[0] = '2':
	cla
	*clr
	if alko<6: gs 'zz_funcs', 'alko'
	gs 'stat'
b2_rand_text = RAND (0,3)
	if b2_rand_text = 0:$b2_rand_text = 'сказал вам'
	if b2_rand_text = 1:$b2_rand_text = 'говорит вам'
	if b2_rand_text = 2:$b2_rand_text = 'прикрикнул на вас'
	if b2_rand_text = 3:$b2_rand_text = 'крикнул на вас'
beer_drova_text = RAND (0,9)
	if beer_drova_text = 0:$beer_drova_text = '<<$name[2]>>-конфетка, все пиво выжрала!, теперь давай в позу становись <<$gop_sex_textr>> будем!'
	if beer_drova_text = 1:$beer_drova_text = 'Все наше пиво вылакала сучка, теперь в позу вставай для отработки'
	if beer_drova_text = 2:$beer_drova_text = '<<$name[2]>> прекращай бухать, давай в позу становись!'
	if beer_drova_text = 3:$beer_drova_text = 'Ебать ты <<$name[2]>>-Алкашка, больше не нальем, а то и так почти в дрова, давай в позу вставай, <<$gop_sex_textr>> будем!'
	if beer_drova_text = 4:$beer_drova_text = 'Набухалась?, теперь отрабатывай: готовь станок, вставай в позу!'
	if beer_drova_text = 5:$beer_drova_text = 'Алё алкашка, все пиво выжрала сучара, давай в позу встань, <<$gop_sex_textr>> будем!'
	if beer_drova_text = 6:$beer_drova_text = 'Все <<$name[2]>> халява кончилась, в позу вставай ебаца будем!'
	if beer_drova_text = 7:$beer_drova_text = '<<$name[2]>>, ты еще стоять то можешь?, Больше не нальем, заебала нас на пиво разводить, давай в позу и отрабатывай!'
	if beer_drova_text = 8:$beer_drova_text = 'Такими темпами дрова ебать придется, а я это не люблю. <<$gop_textr>> больше её не наливаем! <<$name[1]>> вставай в позу и показывай свой станок'
	if beer_drova_text = 9:$beer_drova_text = 'Харе клянчить пиво. Бесплатная столовая для хуесосок на сегодня уже закрыта, сегодня больше не наливамем.'
beer_text = RAND(0,9)
	if beer_text = 0:$beer_text = '<<$shultextrand3>> открыл новую бутылку пива, сделал пару глотков и передал вам. Вы стали не торопясь выпивать вместе с пацанами.'
	if beer_text = 1:$beer_text = '<<$shultextrand3>> налил в пустой стакан пиво и передал вам. Вы стали не спеша выпивать вместе с пацанами.'
	if beer_text = 2:$beer_text = '<<$shultextrand3>> передал вам бутылку пива. Вы стали в захлеб ее опракидывать. <<$shultextrand33>> громко сказал "Алкашка-ебанашка".'
	if beer_text = 3:$beer_text = '<<$shultextrand3>> откупорил и дал вам бутылку пива. Вы жадно ее вылакали. <<$gop_textr>> аж прихуели от такого поворота.'
	if beer_text = 4:$beer_text = '<<$shultextrand3>> взял баклажку пива, налил в стакан и передал вам. Вы не спеша вальяжно развалившись на лавочке, бухая с гопорями.'
	if beer_text = 5:$beer_text = '<<$shultextrand3>> открыл бутылку пива и передал вам. Вы не торопясь небольшими глотками выпивали.'
	if beer_text = 6:$beer_text = '<<$shultextrand3>> откупорил бутылку пива и отдал вам. Вы с жадностью ее осушили и плюхнулись на лавочку.'
	if beer_text = 7:$beer_text = '<<$shultextrand3>> сделал глоток из 2х литровой баклажки пива и отдал вам. Вы сделали пару глотков и <<$shultextrand33>> забрал ее у вас.'
	if beer_text = 8:$beer_text = '<<$shultextrand3>> глотнул из полторашки и передал вам. Вы с жадностью начали лакать из бутылки... <<$shultextrand33>> со словами "дура нам оставь" отнял у вас баклажку'
	if beer_text = 9:$beer_text = '-"На держи"- <<$shultextrand3>> протягивает вам недопитую бутылку жигуля и с усмешкой смотрит как вы жадно выпиваете ее. Ваше настроение немного улучшается.'
if alko>=6:$beer_text = '<<$shultextrand3>> <<$shultextrand6>> <<$b2_rand_text>> "<<$beer_drova_text>>". <<$shultextrand4>>'
beer_text_bazar2 = RAND(0,5)
	if beer_text_bazar2 = 0:$beer_text_bazar2 = 'рассказывает'
	if beer_text_bazar2 = 1:$beer_text_bazar2 = 'начинает разговор'
	if beer_text_bazar2 = 2:$beer_text_bazar2 = 'говорит'
	if beer_text_bazar2 = 3:$beer_text_bazar2 = 'мечтательно говорит'
	if beer_text_bazar2 = 4:$beer_text_bazar2 = 'мечтательно рассказывает'
	if beer_text_bazar2 = 5:$beer_text_bazar2 = 'мечтательно начинает разговор'
beer_text_bazar = RAND(0,11)
	if beer_text_bazar = 0:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "<<$gop_textr>> не поверите, вчера на большой перемене Соньку в туалете зажал, она оказывается та еще соска. Сосала как пылесос, все до последний капли проглотила вафлежуйка".'
	if beer_text_bazar = 1:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "классно мы вчера на дискаче в клубе потусили, в гавно нажрались и даже какую-то бабу за клубом выебали"'
	if beer_text_bazar = 2:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "физичка меня задолбала со своими контрольными работами, бабе похоже мужика не хватает, давно никто не натягивал. Может кто подскажет как подкатить?" <<$shultextrand3>> посмеялся и сказал "такой алкаш и раздолбай как ты нахуй ни кому не нужен"'
	if beer_text_bazar = 3:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "Я тут не давно слух слышал буд-то Кристинка наша у физрука сосет, похоже первое место в команде по бегу отрабатывает." Встревает <<$shultextrand3>> "а прикинь она наверное не только ртом умеет работать, станок наверное тоже рабочий. Не была бы такой крутой, давно бы пользовали!"'
	if beer_text_bazar = 4:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> расспускает слух "говорят Альбинка та еще шлюха, видали какие мужики ее иногда встречают? дорогая блядь походу! На физре постоянно на нее заглядываюсь, жопа упругая так и манит. Вот только батя то у неё та еще шишка, даже подкатывать к ней стремно, закапают если, что не так"'
	if beer_text_bazar = 5:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "Сонька то после пьяного угара на дискаче по рукам пошла, теперь все кому не поподя при любом удобном случае зажимают, проходу её не дают". <<$shultextrand3>> говорит "Да ей то походу самой в кайф такое обращение, я вчера в туалет забежал поссать, так она там сидя на корташах за щеку брала у Лешки"'
	if beer_text_bazar = 6:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "Я тут не давно мимо вокзального кафе проходил где-то после обеда, кафе какого-то лешего закрыто было и странные звуки доносились от туда, заглянул в окно, а там какой-то мужик мамку <<$name_b[1]>> раком разогнул, пялил с остервинением, она аж не сдерживала стоны. Я тупанул надо было фоток на телефон сделать, тогда могли бы пользоваться опытной бабой с аппетитными формами, а то одни мокрощелки поподаются, которые нифига не умеют"'
	if beer_text_bazar = 7:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "Вчера мать <<$name_b[1]>> на рынке видел, красивая баба, вот бы ей вдуть. По любому ебатся она любит во все дыры, как и её дочурка." <<$shultextrand3>> рассмеялся и говорит "ага <<$name[2]>> то у нас еще та звездулька"'
	if beer_text_bazar = 8:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> распускает слух "говорят Англичанку нашу тут недавно на рынке видили, с Ашотом о чем-то долго договаривалась, потом села к нему в тачку. Минут через 15 вышла, тачка затонирована нихуя не видно, но похоже на клык брала, на следующий день в школу в новом платье пришла..."'
	if beer_text_bazar = 9:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "эй <<$name[2]>>, а ты в кино по сниматься не хочешь?, давай прямо сейчас на мобилку киношку снимем? Главную роль тебе выделим, сюжет такой: 3 молодых жеребца тебя тут в 3 ствола <<$gop_sex_textr>> будут, уверен сто пудов киношка популярна будет особенно в школе". <<$gop_textr>> во весь голос заржали. Вы только улыбнулись по блядски и продолжили пить пиво.'
	if beer_text_bazar = 10:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "<<$gop_textr>> вы слышали как в школе обсуждают якобы Кристинка наша однокласница отрабатывает каждую среду и пятницу у физрука нормативы по отсосу. <<$name[2]>> учись, вот как надо пробиваться в люди, а не тут с нами сидеть пивасик глотать за наш счет". Все громко заржали.'
	if beer_text_bazar = 11:$beer_text_bazar = '<<$shultextrand33>> <<$shultextrand6>> <<$beer_text_bazar2>> "Я тут недавно случайно увидел как Соньку за школой два школьника из 10б <<$gop_sex_textr3>> один в рот пихал, другой сзади в пизду или в анал пристроился, толком не разобрал, дела были подходить не стал, мимо прошел. Так вот Сонька как прищепка висела на хуях, такого я от нее не ожидал, пиздец мокрощелка ебаная, дает всем без разбора где попало. Таким темпом ее скоро еще и учителя <<$gop_sex_textr>> будут". <<$shultextrand3>> ответил "Ну а почему нет то?, успеваемость свою подтянет...хаха"'
	if alko>=6:$beer_text_bazar = ''
shultextrand8 = RAND(0,3)
	if shultextrand8 = 0:$shultextrand8 = 'грудь'
	if shultextrand8 = 1:$shultextrand8 = 'сиськи'
	if shultextrand8 = 2:$shultextrand8 = 'сисяндры'
	if shultextrand8 = 3:$shultextrand8 = 'сиську'
	if alko<6:'<center><img src="images/zsoft/park/gopota/beer/b'+rand(1,15)+'.jpg"></center>'
	if alko>=6:'<center><img src="images/zsoft/park/gopota/beer/drova'+rand(1,8)+'.jpg"></center>'
	'<<$beer_text>>'
	''
	'<<$beer_text_bazar>>'
	''
	if alko<6:'Сходить в кусты <a href="exec:GT ''zsoft_gopskverGorSlut'',''piss''">посикать</a>'
	r_event_p=rand(1,100)
	if r_event_p<=15:if alko<6:'<<$gop_textr>> <<$shultextrand6>> сказали "Эй Cветка покажи <<$shultextrand8>>" (<a href="exec:GT ''zsoft_gopskverGorSlut'',''siski''">показать</a>)'
	if alko<6:act 'Уйти':gt 'zz_park'
	if alko<6:act 'Ещё выпить с ребятами':gt'zsoft_gopskverGorSlut','2'
	act 'Встать в позу':
		*clr & cla
		minut += 2
		horny += 1
		gs'stat'
poza_text = RAND(0,17)
	if poza_text = 0:$poza_text = 'Вы выбрали наиболее удобную для вас позу.'
	if poza_text = 1:$poza_text = 'Вам показалось эта поза более <<$text_sveta_obol>>.'
	if poza_text = 2:$poza_text = 'Вы встали в удобную вам позу. Которая была еще и <<$text_sveta_obol>>'
	if poza_text = 3:$poza_text = 'Вы решили встать в такую позу. Она была вполне <<$text_sveta_obol>>'
	if poza_text = 4:$poza_text = 'Вам захотелось встать именно в такую позу.'
	if poza_text = 5:$poza_text = 'Вы выбрали вот такую блядскую позу и подмигнули ребятам.'
	if poza_text = 6:$poza_text = 'Вы подумали и опустились в такую позу.'
	if poza_text = 7:$poza_text = 'Вам хотелось встать именно в такую позу. Она была <<$text_sveta_obol>>'
	if poza_text = 8:$poza_text = 'Вы покорно встали в позу. Как вам показалось она была наиболее <<$text_sveta_obol>>'
	if poza_text = 9:$poza_text = 'Вы спокойно поставили бутылку и встали в такую стандартную позу.'
	if poza_text = 10:$poza_text = 'Вам пришлось встать в развратную позу и показать все свои прелести.'
	if poza_text = 11:$poza_text = 'Не долго думаю вы решили встать в стандартную для такого случая позу.'
	if poza_text = 12:$poza_text = 'Немножко подумав вы встали в сексуальную позу.'
	if poza_text = 13:$poza_text = 'Вы плохо соображали в какую позу они хотят что бы вы встали и вам показалось что такая поза будет более <<$text_sveta_obol>>.'
	if poza_text = 14:$poza_text = 'Вы решили долго не думать и встали вот так. Поза была <<$text_sveta_obol>>'
	if poza_text = 15:$poza_text = 'Долго вам соображать не дали и вы встали в стандартную позу.'
	if poza_text = 16:$poza_text = 'Вам не особо хотелось что-то выдумывать и вы выбрала обычную позу.'
	if poza_text = 17:$poza_text = 'Вам захотелось встать именно в эту позу. Вам она показалась более <<$text_sveta_obol>>'
poza_gop_text3 = RAND(0,7)
	if poza_gop_text3 = 0:$poza_gop_text3 = 'удачно'
	if poza_gop_text3 = 1:$poza_gop_text3 = 'сексуально'
	if poza_gop_text3 = 2:$poza_gop_text3 = 'по блядски'
	if poza_gop_text3 = 3:$poza_gop_text3 = 'возбуждающе'
	if poza_gop_text3 = 4:$poza_gop_text3 = 'вульгарно'
	if poza_gop_text3 = 5:$poza_gop_text3 = 'красиво'
	if poza_gop_text3 = 6:$poza_gop_text3 = 'хорошо'
	if poza_gop_text3 = 7:$poza_gop_text3 = 'отлично'
poza_gop_text2 = RAND(0,10)
	if poza_gop_text2 = 0:$poza_gop_text2 = 'отличную позу наша <<$shultextrand2>> выбрала'
	if poza_gop_text2 = 1:$poza_gop_text2 = 'в супер позу наша <<$shultextrand2>> встала, молодец'
	if poza_gop_text2 = 2:$poza_gop_text2 = 'ахуеть <<$shultextrand2>> встала, у меня аж встал'
	if poza_gop_text2 = 3:$poza_gop_text2 = '<<$poza_gop_text3>> встала, покорная <<$shultextrand2>>'
	if poza_gop_text2 = 4:$poza_gop_text2 = 'пацаны смотрите станок готов'
	if poza_gop_text2 = 5:$poza_gop_text2 = 'смотрите как <<$poza_gop_text3>> встала, первосортная <<$shultextrand2>>'
	if poza_gop_text2 = 6:$poza_gop_text2 = 'смотрите как <<$poza_gop_text3>> встала <<$shultextrand2>> наша'
	if poza_gop_text2 = 7:$poza_gop_text2 = 'смотрите как <<$poza_gop_text3>> встала наша <<$shultextrand2>>'
	if poza_gop_text2 = 8:$poza_gop_text2 = 'ну <<$shultextrand2>>, <<$poza_gop_text3>> в позу встала'
	if poza_gop_text2 = 9:$poza_gop_text2 = 'хаха, <<$shultextrand2>>, <<$poza_gop_text3>> стоишь, глаз радуется'
	if poza_gop_text2 = 10:$poza_gop_text2 = 'а мне нравится выбор твоей позы, молодец заслужила крепкий хуй'
poza_gop_text = RAND(0,9)
	if poza_gop_text = 0:$poza_gop_text = 'Ну что <<$gop_textr>> кто её первый будет <<$gop_sex_textr>>?'
	if poza_gop_text = 1:$poza_gop_text = '<<$gop_textr>> кто первый будет это тело <<$gop_sex_textr>>?'
	if poza_gop_text = 2:$poza_gop_text = '<<$gop_textr>> кто первый ее <<$gop_sex_textr2>>?'
	if poza_gop_text = 3:$poza_gop_text = 'Давайте решим кого первого она обслужит?'
	if poza_gop_text = 4:$poza_gop_text = '<<$gop_textr>> надо решить кого она первого обслужит.'
	if poza_gop_text = 5:$poza_gop_text = 'Может я первый ее <<$gop_sex_textr>> буду?, для вас <<$gop_textr>> подготовлю, хаха.'
	if poza_gop_text = 6:$poza_gop_text = '<<$gop_textr>>, ну и кто сейчас ее <<$gop_sex_textr>> будет?'
	if poza_gop_text = 7:$poza_gop_text = 'Может для начала она у меня в рот возьмет?'
	if poza_gop_text = 8:$poza_gop_text = '<<$gop_textr>>, давайте я первый её <<$gop_sex_textr>> буду?!.'
	if poza_gop_text = 9:$poza_gop_text = '<<$gop_textr>>, хочу первый её <<$gop_sex_textr>>, пока еще она не заебана.'
		'<center><img src="images/zsoft/park/gopota/poza/p'+rand(1,34)+'.jpg"></center>'
		'<<$poza_text>>'
		'<<$shultextrand3>> <<$shultextrand6>> сказал "<<$poza_gop_text2>>".'
		'<<$shultextrand4>>.'
		'<<$shultextrand33>> говорит "<<$poza_gop_text>>"'
horny_orgazm_text2 = RAND(0,10)
	if horny_orgazm_text2 = 0:$horny_orgazm_text2 = 'Вы просили сильнее вас <<$gop_sex_textr>>, пытаясь кончить'
	if horny_orgazm_text2 = 1:$horny_orgazm_text2 = 'Вы начали быстрее подмахивать, пытаясь кончить'
	if horny_orgazm_text2 = 2:$horny_orgazm_text2 = 'Вы были на пике оргазма, просили пихать хуй глубже'
	if horny_orgazm_text2 = 3:$horny_orgazm_text2 = 'Вы патылись кончить, просили что бы вас стали <<$gop_sex_textr>> быстрее'
	if horny_orgazm_text2 = 4:$horny_orgazm_text2 = 'Вам сильно хотелось кончить, стали пытаться подмахивать в такт'
	if horny_orgazm_text2 = 5:$horny_orgazm_text2 = 'Вам хотелось кончить, начали активнее насаживатся на хуй'
	if horny_orgazm_text2 = 6:$horny_orgazm_text2 = 'Вы старались кончить, стали просить партнера ускориться'
	if horny_orgazm_text2 = 7:$horny_orgazm_text2 = 'Вы просили <<$gop_sex_textr>> вас жёстче'
	if horny_orgazm_text2 = 8:$horny_orgazm_text2 = 'Вы просили жестче с вами обращаться, пытаясь кончить'
	if horny_orgazm_text2 = 9:$horny_orgazm_text2 = 'Вы молили партнера что бы он стал <<$gop_sex_textr>> вас сильнее'
	if horny_orgazm_text2 = 10:$horny_orgazm_text2 = 'Вы орали матом, говорили какая вы ебливая шлюха, пытаясь подзадорить партнера и кончить'
horny_orgazm_text3 = RAND(0,11)
	if horny_orgazm_text3 = 0:$horny_orgazm_text3 = 'Вы остались не удовлетворены'
	if horny_orgazm_text3 = 1:$horny_orgazm_text3 = 'Но у вас ничего не получилось'
	if horny_orgazm_text3 = 2:$horny_orgazm_text3 = 'Кончить вам не удалось'
	if horny_orgazm_text3 = 3:$horny_orgazm_text3 = 'Кончить у вас не получилось'
	if horny_orgazm_text3 = 4:$horny_orgazm_text3 = 'Кончить вы не успели'
	if horny_orgazm_text3 = 5:$horny_orgazm_text3 = 'Получить оргазм вы не успели'
	if horny_orgazm_text3 = 6:$horny_orgazm_text3 = 'У вас не получилось кончить'
	if horny_orgazm_text3 = 7:$horny_orgazm_text3 = 'Вы не смогли получить оргазм'
	if horny_orgazm_text3 = 8:$horny_orgazm_text3 = 'Вам чуть-чуть не хватило времени что бы кончить'
	if horny_orgazm_text3 = 9:$horny_orgazm_text3 = 'Вам немножко не хватило что бы испытать оргазм'
	if horny_orgazm_text3 = 10:$horny_orgazm_text3 = 'У вас не получилось испытать оргазм'
	if horny_orgazm_text3 = 11:$horny_orgazm_text3 = 'Партнер кончил быстрее, вы остались не удовлетворены'
horny_orgazm_text4 = RAND(0,11)
	if horny_orgazm_text4 = 0:$horny_orgazm_text4 = 'Вы громко застонали и кончили'
	if horny_orgazm_text4 = 1:$horny_orgazm_text4 = 'Ваше тело начало дрожать и вы бурно кончили'
	if horny_orgazm_text4 = 2:$horny_orgazm_text4 = 'Из ваших уст вырвался громкий стон и в этот момент вы поймали оргазм'
	if horny_orgazm_text4 = 3:$horny_orgazm_text4 = 'Вы забились в конвульсиях и начали кончать'
	if horny_orgazm_text4 = 4:$horny_orgazm_text4 = 'Вы возбужденно задышали и вскоре кончили'
	if horny_orgazm_text4 = 5:$horny_orgazm_text4 = 'Вас охватил оргазм'
	if horny_orgazm_text4 = 6:$horny_orgazm_text4 = 'Вы бурно кончили'
	if horny_orgazm_text4 = 7:$horny_orgazm_text4 = 'На этот раз вам удалось кончить'
	if horny_orgazm_text4 = 8:$horny_orgazm_text4 = 'Вам удалось поймать оргазм'
	if horny_orgazm_text4 = 9:$horny_orgazm_text4 = 'Вы кончили, испытав непередаваймые ощущения'
	if horny_orgazm_text4 = 10:$horny_orgazm_text4 = 'Вы громко замычали и обкончались'
	if horny_orgazm_text4 = 11:$horny_orgazm_text4 = 'И тут парк нaпoлнился жeнским крикoм. Вы кoнчaли грoмкo, никoгo нe стeсняясь, нeвoльнo привлeкaя внимaниe.'
		$hornyparksex = {
			if horand > horny:horny += 10 & manna -=5 & son -=1 & '<<$horny_orgazm_text2>>. <<$horny_orgazm_text3>>.'
			if horand <= horny:horny = 0 & orgasm += 1 & manna += 20 &'<<$horny_orgazm_text2>>. <<$horny_orgazm_text4>>.'
		}
		$hornyparksexanal = {
			if horand > horny:horny += 10 & son -=1 & '<<$horny_orgazm_text2>>. <<$horny_orgazm_text3>>.'
			if horand <= horny:horny = 0 & analorgasm += 1 & manna += 15 &'<<$horny_orgazm_text2>>. <<$horny_orgazm_text4>>.'
		}
		$gopcumface = {
			act 'Кончить на лицо':
				*clr & cla
				gs 'zz_funcs', 'cum', 'face'
				randpgiff=rand(1,100)
				if randpgiff>20:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/cumf'+rand(1,22)+'.jpg"></center>'
				if randpgiff<=20:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cumf'+rand(1,6)+'.gif"></center>'
cum_face_text = RAND(0,2)
	if cum_face_text = 0:$cum_face_text = 'Вам обильно кончили на ваше милое личико. Вы облизавшись, по блядски подмигнув, стали приводить себя в порядок'
	if cum_face_text = 1:$cum_face_text = 'Тягучая и слегка сладковатая сперма ударила вам мощным напором прямо в небо. Вы от неожиданности отодвинули голову и остальная сперма попала вам на личико. Отжали все до последней капли и облизали его увядающий член.'
	if cum_face_text = 2:$cum_face_text = 'Когда парень начал кончать, он вынул член изо рта, и его сперма буквально вылетела из напряженной головки. Заряд белой спермы брызнул с такой силой, что перелетел больше метра и упала вам на голову, второй заряд попал вам на личико. Волосы ваши слиплись от спермы...'
				'<<$cum_face_text>>'
				!dynamic $dinrandcum
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$cumfacegr = {
			act 'Кончить на лицо':
				*clr & cla
				gs 'zz_funcs', 'cum', 'face'
				gs'stat'
				randpgiffgr=rand(1,100)
				if randpgiffgr>20:'<center><img src="images/zsoft/park/gopota/sex/group/cum/cumf'+rand(1,14)+'.jpg"></center>'
				if randpgiffgr<=20:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cumf'+rand(1,6)+'.gif"></center>'
cum_face_textgr = RAND(0,4)
	if cum_face_textgr = 0:$cum_face_textgr = 'Вы обессилено сидите на корточках, словно рыба выброшенная на лед, лицо покрыто маской из растекшейся косметики, слез, слюней и спермы.'
	if cum_face_textgr = 1:$cum_face_textgr = 'Вы обессилено сидите на корточках, словно рыба выброшенная на лед, лицо покрыто маской из слез, слюней и спермы. -"Я же говорил что у нее рот рабочий" - усмехается <<$shultextrand3>> – "В такой ебать и ебать". Покраснев как рак и опустив голову вы отворачиваетесь и пытаетесь привести себя в порядок.'
	if cum_face_textgr = 2:$cum_face_textgr = 'Когда приблизился оргазм, <<$gop_textr>> приблизили свои хуи к вашему лицу и стали дрочить. Вы тут же начали целовать и обсасывать головку хуя, то одному, то другому, стараясь никого не обделить.
<<$shultextrand33>>, перед тем как кончить на лицо, сначала смачно плюнул вам в рот и отвесил пару пощечин. Видимо, всем троим это доставляло удовольствие. Одновременно <<$gop_textr>> начали изливать сперму вам на личико.'
	if cum_face_textgr = 3:$cum_face_textgr = 'Первый член выстрелил вам в губы и в нос залив их белыми сгустками. Сперма стекала по подбородку и капала на грудь. Двое последующих ребят поочередно слили свою сперму на лицо, попали на волосы, губы, носик, виски, завершив сочную маску на лице.'
	if cum_face_textgr = 4:$cum_face_textgr = '<<$gop_textr>> начали кончать почти одновременно, кончили вам на лицо, волосы. Спермы у них было много, поэтому ваша голова сильно походила на залитый сгущенкой пирог.'
	if cum_face_textgr = 4:$cum_face_textgr = 'К счастью <<$gop_textr>> перевозбудились и кончили довольно быстро. Обильно оросив ваше лицо спермой, они тщательно вытерли члены о ваши <<$hapri>> <<$hair2>> волосы и наконец отпустили голову.'
				'<<$cum_face_textgr>>'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$gopcummouth = {
			act 'Кончить в рот':
				*clr & cla
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs'stat'
				randpgifm=rand(1,100)
				if randpgifm>40:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/cumm'+rand(1,12)+'.jpg"></center>'
				if randpgifm<=40:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cumm'+rand(1,8)+'.gif"></center>'
cum_mouth_text = RAND(0,8)
	if cum_mouth_text = 0:$cum_mouth_text = 'В горло хлынула струя вязкой кончи, вы поперхнулись от неожиданности, но в итоге хоть и с трудом справились и несколькими мощными глотками проглотили все до капли.'
	if cum_mouth_text = 1:$cum_mouth_text = '- "Приятного аппетита, спермоглотка" - ухмыляется он позволяя вам наконец сделать жадный вдох, после чего вытирает свой обмякший конец о вашу щеку и отходит в сторону.'
	if cum_mouth_text = 2:$cum_mouth_text = 'Сделав несколько движений рукой, обильно спускает вам на язык и силой сжимает челюсти, заставляя проглотить.'
	if cum_mouth_text = 3:$cum_mouth_text = 'Вы обреченно глотаете, непроизвольно морщась от ужасного вкуса, все оттенки которого вы были вынуждены прочувствовать на языке.'
	if cum_mouth_text = 4:$cum_mouth_text = '- "Привыкай, опущенка, теперь тебе будут часто в рот спускать" - ухмыляется Шульга, пока вы старательно высасываете остатки и облизываете язычком опавший орган.'
	if cum_mouth_text = 5:$cum_mouth_text = 'Cтал издавать стонуще - мычащие звуки, его хуй в ваших руках стал как каменный, мошонка сжалась: и он каааак выстрелит! Хоть вы и ждали, что он кончит, часть спермы попала вам на лицо, остальное вы честно ловили в рот. Он кончал очень обильно, а вы дрочили ему не переставая и глотали сперму'
	if cum_mouth_text = 6:$cum_mouth_text = 'Вы взяла хуй в рот и заглотила его по самые яйца. Он застонал, прижал вашу голову к своей промежности и стал кончать вам прямо в горло. Вы чуть не задохнулись! Вырвались, пытаясь отдышаться, он сам схватил свой хуй, стал пихать вам в горло и продолжал кончать. Вы высосали все до капли.'
	if cum_mouth_text = 7:$cum_mouth_text = 'Член стал кончать прямо в ваш ротик, спермы было так много, что она не помещалась у вас во рту.'
	if cum_mouth_text = 8:$cum_mouth_text = 'Первые струи ударили вам прямо в гланды. Непроизвольно проглотив «первач», вы поняли, что рот ваш всё равно заполняется этой вязкой жидкостью. Часть стекала с губ по подбородку капая вниз.'
				'<<$cum_mouth_text>>'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$cummouthgr = {
			act 'Кончить в рот':
				*clr & cla
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs'stat'
				randpg=rand(1,100)
				if randpg>40:'<center><img src="images/zsoft/park/gopota/sex/group/cum/cumm'+rand(1,4)+'.jpg"></center>'
				if randpg<=40:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/cumm'+rand(6,10)+'.jpg"></center>'
cum_mouth_textgr = RAND(0,5)
	if cum_mouth_textgr = 0:$cum_mouth_textgr = '<<$gop_textr>> выстроились в очередь что бы заполнить ваш ротик, в горло хлынула струя вязкой кончи, вы поперхнулись от неожиданности, но в итоге хоть и с трудом справились и несколькими мощными глотками проглотили все до капли, тоже самое было и с двумя другими, вы все без остатка проглотили и облизались.'
	if cum_mouth_textgr = 1:$cum_mouth_textgr = '- "Приятного аппетита, спермоглотка" - ухмыляется он позволяя вам наконец сделать жадный вдох, после чего вытирает свой обмякший конец о вашу щеку и отходит в сторону. Уступая ваш ротик товарищу. Вы послушно принимали сперму в рот, стараясь не уронить ни капли.'
	if cum_mouth_textgr = 2:$cum_mouth_textgr = 'Вы обреченно глотаете сперму пацанов, непроизвольно морщась от ужасного вкуса, все оттенки которого вы были вынуждены прочувствовать на языке.
-"Я же говорил что у нее рот рабочий" - усмехается <<$shultextrand3>> – "В такой ебать и ебать". Покраснев как рак и опустив голову вы отворачиваетесь и пытаетесь привести себя в порядок.'
	if cum_mouth_textgr = 3:$cum_mouth_textgr = 'Вы засосали хуй в рот по самые яйца. Дэн застонал, прижал вашу голову к своей промежности и стал кончать вам прямо в горло. Вы чуть не задохнулись! Вырвались, пытаясь отдышаться пока меняется партнер, Шульга схватив вас за уши, стал пихать вам в горло и начал кончать. Котов уже был перевозбужден этим зрелещем, подбежал оттолкнув Шульгу и сунул вам в открытый рот свой хуй стал изливаться. Вы проглотили все до капли.'
	if cum_mouth_textgr = 4:$cum_mouth_textgr = '<<$gop_textr>> стали кончать прямо вам в ротик, спермы было так много, что она не помещалась у вас во рту. Вы сторательно высасывали всю сперму до капли и глотали. -"Я же говорил что у нее рот рабочий" - усмехается <<$shultextrand3>> – "В такой ебать и ебать".'
	if cum_mouth_textgr = 5:$cum_mouth_textgr = 'Рука на вашем затылке давала понять, что от вас ждут действий. Вы начали активно облизывать и целовать хуй, он извергся... Это был фонтан, он ударил вам в небо плотной струей и растекся во рту. Густая сперма, желтоватая и терпкая на вкус... Вы перекатывали её язычком, стараясь подольше наслаждаться необычным вкусом, до тех пор пока она не смешалась окончательно с вашей слюной. Понаблюдав за этим действом, остальные <<$gop_textr>> так же излились вам в рот. Вы смаковали и пытались разобрать вкус спермы каждого гопоря.'
				'<<$cum_mouth_textgr>>'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$gopcumbody = {
			act 'Кончить на тело':
				*clr & cla
				cumfrot += 1
				manna += 5
				gs'stat'
				randpgifb=rand(1,100)
				if randpgifb>50:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/cumb'+rand(1,9)+'.jpg"></center>'
				if randpgifb<=50:'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cumb'+rand(1,2)+'.gif"></center>'
				'Обильно кончали вам на живот, фонтан спермы добил аж до ваших грудей, и заляпал по дороге пупок и все остальное.'
				!dynamic $dinrandcum
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$gopcumass = {
			act 'Кончить в попку':
				*clr & cla
				manna += 5
				gs 'zz_funcs', 'cum', 'ass'
				gs'stat'
cumass_text = RAND(0,5)
	if cumass_text = 0:$cumass_text = 'Хуй начал кончать в вашей жопе, он вынув и стал дрочить на вас. Остатки спермы полилась вам на задницу, потом он потер хуй о вашу пизду и очко, размазывая свою сперму'
	if cumass_text = 1:$cumass_text = 'Он кончил вам в очко, после раздвинув ваши булки начал наблюдать как сперма вытикает из вашей жопы.'
	if cumass_text = 2:$cumass_text = 'Когда он вытащил член из попки, оттуда стала вытекать сперма, не так много, но достаточно, чтобы намочить всё промежность.'
	if cumass_text = 3:$cumass_text = 'Ваша бедная попка устала, ее только что пустили по кругу и хорошенько "накормили" мужским семенем.'
	if cumass_text = 4:$cumass_text = 'Гопники радостно гогочут глядя на дело своих рук: "Неплохо мы тебе разработали жопу, Cветка"'
	if cumass_text = 5:$cumass_text = 'Кончая, он вытащил член и залил ваши ягодицы белой вязкой жидкостью.'
				'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cumass'+rand(1,2)+'.gif"></center>'
				'<<$cumass_text>>'
				if agape = 3: 'Из вашего растерзанного ануса медленно вытекает сперма вперемешку с кровью'
				if agape < 3: '<<$anus>> После нескольких хуев побывавших в нем. Из него медленно вытекает сперма.'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$gopcumassgr = {
			act 'Кончить в попку':
				*clr & cla
				manna += 5
				gs 'zz_funcs', 'cum', 'ass'
				gs'stat'
				'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cumass'+rand(1,2)+'.gif"></center>'
				'Обслужив последнего вы устало валитесь на траву. К вам подходит <<$shultextrand3>> и с издвевкой спрашивает:
- "Ну что, <<$name[2]>>, твоя жопа теперь рабочая?"
- "Да рабочая", отвечаете вы, краснея и пряча взгляд.
- "Будешь теперь постоянно очко подставлять <<$gop_textr4>>?" - не унимается гопник.
- "Да, буду подставлять очко." - механически повторяете вы.
- "Вот и умница" - хохотнул парень.
После этого <<$shultextrand33>> сказал вам: "А теперь повернись и покажи всем свое рабочее очко"'
				act 'показать':
					*clr & cla
					gs'stat'
					if anus <= 10:
						'<center><img src="images/qwest/alter/placer/BjBeerAnal6.jpg" ></center>'
						'Вы покорно поворачиваетесь и раздвинув булки показываете вашу покрасневшую измученную дырочку.'
					elseif anus > 10 and anus < 25:
						'<center><img src="images/qwest/alter/placer/BjBeerAnal7.jpg" ></center>'
						'Вы покорно поворачиваетесь и раздвинув булки показываете вашу покрасневшую растянутую дыру.'
					else
						'<center><img src="images/qwest/alter/placer/BjBeerAnal8.jpg" ></center>'
						'Вы покорно поворачиваетесь и раздвинув булки показываете ваше разъебанное измочаленное дупло.'
					end
					'Ваша бедная попка устала, ее только что пустили по кругу и хорошенько "накормили" мужским семенем.'
					if agape = 3: 'Из вашего растерзанного ануса медленно вытекает сперма вперемешку с кровью'
					if agape < 3: '<<$anus>>, после нескольких хуев побывавших в нем. Из него медленно вытекает сперма.'
					'Гопники радостно гогочут глядя на дело своих рук: "Неплохо мы тебе разработали жопу, Cветка"'
					act 'Уйти':gt'zz_park'
					act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
				end
			end
		}
		$gopcumvagina = {
			act 'Кончить в киску':
				*clr & cla
				manna -=30
				health -=30
				gs'stat'
				cumvag_text = RAND(0,1)
				if cumvag_text = 0:$cumvag_text = 'Наконец его движения ускоряются и загнав напоследок по самые яйца с блаженной улыбкой он кончил глубоко в вас. Вы ощутили как теплая жикдость разливается по вашим внутренностям.'
				if cumvag_text = 1:$cumvag_text = 'Он не стал тянуть и спустил прямо в вас так, что из пизденки с чавканьем вылетели брызги спермы.'
				'<center><img src="images/zsoft/park/gopota/sex/oral/cum/gif/cump'+rand(1,2)+'.gif"></center>'
				'<<$cumvag_text>>'
				gs 'zz_funcs', 'cum', 'pussy'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		}
		$gopvaginsex = {
			act 'Дать в пизду':
				*clr & cla
				gs'stat'
				sex += 1
				dick = 17
				horny += 5
				minut += 5
				'<center><img src="images/zsoft/park/gopota/sex/vagin/v'+rand(1,40)+'.jpg"></center>'
vag_gop_text = RAND(0,3)
	if vag_gop_text = 0:$vag_gop_text = 'Ебарь повернулся к вам: "ух какая ты <<$shultextrand2>>" - сказал он, развернув и нагнув вас раком. Член оказался между ног, прижавшись к киске.
Вы взяли его член и провели по мокрым губкам вверх-вниз. Он понял намек, взял хуй в руки и начал вставлять в вас член, разведя ноги по сторонам и чуть надавив вам на спину.
С начало стал медленно входить и выходить из вашей пизды, наращивая темп. Член легко проникал в мокрую дырочку. Движения становились все резче, шлепки всё сильнее.
Ваша попка охотно и сильно поднималась навстречу таранящему члену. Пару раз вы повернули голову посмотреть на пьющих пиво и наблюдающих за вами пацанов.
Вы почти сразу начали постанывать под его натиском, потеряв голову начали в голос стонать и охать. Каждый раз, когда член касался матки, вы охали и вскрикивали.
Возбужденный клитор то же был на грани и оргазм не заставил себя ждать. По телу прошла дрожь, вы громче застонали и тоненько закричали в такт ударам: "аа...аааа...ааааа...ааааяяяя"'
	if vag_gop_text = 1:$vag_gop_text = 'Его член стоял вертикально вверх, от напряжения проступали вены. Вы подошли к нему, задрали платье, приспустив трусики, нагнувшись перед его членом, начали засовывать его себе в письку, через пару секунд вас начали бешенно ебать'
	if vag_gop_text = 2:$vag_gop_text = 'Вы поняли, что вам нужно пошире расставить ноги. Когда вы это сделали, раскорячившись как лягушка, он вошел в вас. Член входил как по маслу в ваше увлажненное влагалище, двигаясь ритмично, деловито, и в то же время властно, уверенно, доводя вас до исступления...
Вы дергались, вскрикивали, член был длинным, он ударялся прямо в вашу матку, заставляя сжиматься внутри и по кошачьи вопить от восторга.'
	if vag_gop_text = 3:$vag_gop_text = 'В одно мгновение он просто толкнул вас на землю, сдернул шорты и вошел в пизду. Он работал как зверь долбил вас с такой силой, что пот с него капал на вашу спину, а вы только молили его — Не останавливаться!.
Видимо его эти слова очень завели..., надавив вам на спину вы прогнулись как только могли и в этот момент ваша попка несомненно смотрелась очень аппетитно. Он еще яростней продолжил разъебывать вашу пизденку...'
				'<<$vag_gop_text>>'
				dynamic $hornyparksex
				dynamic $gopcumface
				dynamic $gopcummouth
				dynamic $gopcumbody
				dynamic $gopcumvagina
			end
		}
		$gopanalsex = {
			act 'Дать в жопу':
				*clr & cla
				gs'stat'
				anal += 1
				dick = 17
				horny += 2
				minut += 5
				'<center><img src="images/zsoft/park/gopota/sex/anal/ass'+rand(1,35)+'.jpg"></center>'
anal_gop_text = RAND(0,6)
	if anal_gop_text = 0:$anal_gop_text = 'Вы нагнулись, держась за край лавочки и подставив свою попку. Он одной рукой придерживал вас за бедро, а второй направил головку хуя к вашему заднему проходу. Вы хоть и ждали этого, очко у вас рефлекторно сжалось.
Он хлопнул вас ладонью по заднице и сказал "Расслабься: надо совсем расслабиться, тогда не будет больно". Вы попытались расслабиться, но когда почувствовали, что его головка входит, снова непроизвольно сжали очко. Если бы не на сухую, вам было бы легче. А так вы чувствовали, что его хуй медленно, плавно, без рывков, входит вам в жопу все глубже.
Было немного больно, но, это была приятная боль. Вы так сосредоточились на этих ощущениях, что больше ни о чем не думали. Когда он наконец засунул на всю длину и его яйца коснулись ваших ягодиц, он на несколько секунд замер. Через пару минут все пошло как по маслу.'
	if anal_gop_text = 1:$anal_gop_text = 'Вы встали раком, ваш ебарь встал на колени сзади вас и засадил вам в очко, причем не так медленно, как обычно вам засовывают, а рывком, и сразу стал ебать в хорошем темпе. Вы вскрикнули, но не отстранились, а просунули руку между ног и стала тереть себе клитор.'
	if anal_gop_text = 2:$anal_gop_text = 'Ваш партнер плюнул на вход в попку и начал погружать туда свой хуй. Вы дернулись, когда головка провалилась внутрь и немного напряглась, но немного привыкнув - расслабились, вас начали быстро <<$gop_sex_textr>> и <<$gop_textr3>> вашу жопу. Вы стали стонать громче, приближались к оргазму, причем к анальному!'
	if anal_gop_text = 3:$anal_gop_text = 'Крепко держа вас за бедра он жестко дерет вас, то глубоко на всю длину вгоняя свой хуй, то медленно вытаскивает, и, глядя на вашу тщетно пытающуюся сжаться дырочку, всаживает его с размаху обратно. Вы стонете в такт движениям, когда его здоровенная елда долбит ваш <<$anustipe>> анус с хлюпающими звуками.'
	if anal_gop_text = 4:$anal_gop_text = 'Вы покорно растягиваете в разные стороны свои полужопия. Он вальяжно подошел и первым делом харкнул в ваше гостепреимно открытое для него очко. Вы молча ждете когда он войдет в вас. Порывы воздуха холодят вашу мокрую раскрытую дырочку.
Ему скучно стало просто молча ебать вас в жопу: "Слышь <<$name[2]>>, нравится очко ебарям подставлять?". "Да"... - тихонько шепчете вы понимая какой ответ от вас ждут.
-"Громче, <<$shultextrand2>>, не слышу!" - крепко ухватил вас за волосы и натянул их, вызвав у вас непроизвольный вскрик и слезы из глаз. - "Кто ты у нас?"
Не дожидаясь следующего рывка вы заголосили не своим голосом - "Да я люблю когда меня имеют в жопу...я анальная шлюха...жоподайка...жучка...выебите меня в сраку пожалуйста...ааАах.."
<<$gop_textr>> засмеялись - "Смотри на вид такая пай девочка, а выражается как последняя блядь". Под ваши причитания он задвигался быстрее'
	if anal_gop_text = 5:$anal_gop_text = 'После чего подходит и грубо раздвигает ваши ягодицы с усмешкой глядя на ваш <<$anustipe>> сфинктер. Вы покорно стоите опустив голову, чуть пронувшись и слегка оттопырив свою аппетитную попку, которой предстоит жестокое испытание. Он входит в вас.
Вы громко стонете и поминаете маму. Ваши стоны только заводят парня и он еще резче начинает вгонять свой напряженнный хуй в вашу <<$anustipe2>> "лузу". Его яйца стучат о ваши ягодицы словно баскетбольные мячи. Наконец его движения ускоряются...'
	if anal_gop_text = 6:$anal_gop_text = 'Вдруг он тут же задрал ваше платье и, опрокинув грудью на лавочку, вошел в вас через задний проход. Это был шок.
Так неожиданно, без всякой подготовки, на глазах у посторонних, да еще и в попу...Лежа грудью на лавочке, вы закричали. В вашем крике было и чисто физическая боль, и возмущение таким предательским отношением, и стыд, от которого теперь уже не избавиться, и бессилие.
Член как гигантский штопор буравил вас, раздирая задний проход. Вы задыхались, и не переставая, кричали. Постепенно, под таким мощным напором, который обрушился на вашу бедную задницу, стенки ануса несколько растянулись. Боль поутихла, и вы стали ощущать сначала незаметные, а потом все более жгучие приливы наслаждения. Теперь вы уже даже старались «подмахивать», двигаться навстречу пацану.'
				if analplugin = 1: analplugin = 0 & '"Это тебе сейчас не понадобится" С громким чпоком рывком вытащил вашу анальную пробку, вызвав у вас гримасу боли."'
				'<<$anal_gop_text>>'
				if tattoo['waist'] > 0: 'При виде вашего тату на пояснице он одобрительно похлопал вас по попе - "Хорошо тебя пометили, шлюха."'
				dynamic $hornyparksexanal
				dynamic $gopcumface
				dynamic $gopcummouth
				dynamic $gopcumbody
				dynamic $gopcumass
			end
		}
oral_den_text = RAND(0,13)
	if oral_den_text = 0:$oral_den_text = 'Ваш друг застонал "Давай хуесоска, не филонь по полной обслуживай."'
	if oral_den_text = 1:$oral_den_text = 'Вы активно насаживаетесь на его уже вовсю стоящий агрегат, давясь, пуская слюни и изо всех сил подавляя рвотные рефлексы.'
	if oral_den_text = 2:$oral_den_text = 'Высунув язык и плотно обхватив своими <<$liptalk>> его член, вы успешно заглатываете его по самые гланды, с каждым движением доставая губами до мошонки.'
	if oral_den_text = 3:$oral_den_text = 'Старательно вбирая в свое <<$throattipe>> горло хуй, вы также не забываете работать язычком и периодически, уперевшись носом в живот гопаря, с энтузиазмом лижете его волосатые яйца.'
	if oral_den_text = 4:$oral_den_text = 'Не выдержав такой мощной стимуляции, парень отрывается от пива, начинает стонать и затем с силой нахлобучивает вас, крепко прижимая ваше лицо к паху, не давая вздохнуть.'
	if oral_den_text = 5:$oral_den_text = 'Вы лениво гоняете член во рту и за щекой, не особо форсируя события. Просто отбываете номер. Так продолжается довольно долго, он даже успевает раздавить бутылочку пивка. Наконец он достает свой хер и недовольно буркает – "Соска тупая, муслякаешь полчаса уже".'
	if oral_den_text = 6:$oral_den_text = '-"Хорошая соска, интересно, а другие дырки у тебя тоже рабочие? Надо будет проверить." - услышали вы тихие перешептывания за своей спиной.'
	if oral_den_text = 7:$oral_den_text = 'Благодаря позе в которой вы были, его член встал входить в вас на всю длину и вы стали прямо как шпагоглотательница в цирке. С каждым толчком вам перекрывало дыхание, с каждым выходом члены вы вздыхали.'
	if oral_den_text = 8:$oral_den_text = 'Вы раскрыли рот. Он взял вас сзади за волосы и как засадил в рот! Да во всю длину, так что его хуй вошел вам в горло. Вы от неожиданности чуть не блеванули, закашлялись, Он посмотрел на вас как на припезденную.'
	if oral_den_text = 9:$oral_den_text = 'С каждым разом вы пытались засунуть его член глубже, и у вас получилось заглотить его до основания. Чтобы перевести дыхание, достала член изо рта и стала играть горячим язычком с головкой то облизывая её, то посасывая. Весь член был мокрый от слюны и выделений, всё текло на руку, которой вы подрачивала его.'
	if oral_den_text = 10:$oral_den_text = 'Вы стали делать миньет, ваши сладкие губки кольцом обхватили достаточно большой ствол и медленно, как вы любите, двигаетесь к самому основанию и обратно.'
	if oral_den_text = 11:$oral_den_text = 'Вы решили немного разнообразить методичные ласки губами и языком, вы чуть помедлили и начали ласкать основание члена, целовать живот, облизывать яички. Учащённое дыхание вашего партнера говорило о том, что вы на верном пути. Успев почувствовать нарастающее напряжение, Вы поспешили заглотить член целиком.'
	if oral_den_text = 12:$oral_den_text = 'В безлюдном парке были отчетливо слышны усердные причмокивания и звуки глотания. Вы пытались засунуть его хуй как можно глубже себе в рот, а он в это время лапал вашу грудь, сжимал и тискал ее на столько сильно, что у вас все ноги были уже соках которые текли из пизденки. шортики были мокрые'
	if oral_den_text = 13:$oral_den_text = 'Он подошел к вам, наклонил... вы сосали ему с таким упоением, как не сосали уже давно, его члены был не большим но очень горячим. Он смотрел на вас и говорил, нет скорей приказывал смотреть ему в глаза и сосать сосать сосать!'
		act 'Сосать у Дэна':
			*clr & cla
			bj += 1
			if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
			dick = $npc['10,dick']
			minut += 5
			horny += 2
			BjBeerQW += 1
			gs'stat'
			'<center><img src="images/zsoft/park/gopota/sex/oral/1/o'+rand(1,28)+'.jpg"></center>'
			gs 'zz_dynamic_sex', 'bj'
			'<<$oral_den_text>>'
			dynamic $gopcumface
			dynamic $gopcummouth
			dynamic $gopcumbody
			dynamic $gopvaginsex
			dynamic $gopanalsex
		end
		act 'Сосать у Шульги':
			*clr & cla
			bj += 1
			if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
			dick = $npc['11,dick']
			minut += 5
			horny += 1
			BjBeerQW += 1
			gs'stat'
			'<center><img src="images/zsoft/park/gopota/sex/oral/2/o'+rand(1,28)+'.jpg"></center>'
			gs 'zz_dynamic_sex', 'bj'
			'<<$oral_den_text>>'
			dynamic $gopcumface
			dynamic $gopcummouth
			dynamic $gopcumbody
			dynamic $gopvaginsex
			dynamic $gopanalsex
		end
		act 'Сосать у Витька':
			*clr & cla
			bj += 1
			if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
			dick = $npc['9,sex']
			minut += 5
			horny += 1
			BjBeerQW += 1
			gs'stat'
			'<center><img src="images/zsoft/park/gopota/sex/oral/3/o'+rand(1,28)+'.jpg"></center>'
			gs 'zz_dynamic_sex', 'bj'
			'<<$oral_den_text>>'
			dynamic $gopcumface
			dynamic $gopcummouth
			dynamic $gopcumbody
			dynamic $gopvaginsex
			dynamic $gopanalsex
		end
		act 'Обслужить всех сразу':
			*clr & cla
			bj += 3
			dom -= 1
			minut += 15
			horny += 5
			BjBeerQW += 1
			gs'stat'
gop_grup_event_t1 = RAND(0,1)
	if gop_grup_event_t1 = 0:$gop_grup_event_t1 = 'С мокрыми от слез глазами, потекшей косметикой, размазанной по щекам и капающей с подбородка на <<$shultextrand8>> вязкой слюной.'
	if gop_grup_event_t1 = 1:$gop_grup_event_t1 = 'С мокрыми от слез глазами и капающей с подбородка на <<$shultextrand8>> вязкой слюной.'
gop_grup_event_t2 = RAND(0,1)
	if gop_grup_event_t2 = 0:$gop_grup_event_t2 = 'Вы готовы провалится сквозь землю от стыда, но выбора нет и cидя на коленях, вытирая лицо и глаза, вы тихим сломленым голосом говорите в камеру «Мама привет», искренне надеясь, что эту запись удалят и никто ее не увидит.'
	if gop_grup_event_t2 = 1:$gop_grup_event_t2 = 'Вы говорите: "<<$gop_textr>>, вы чего тут вообще мозги пропили?, если кому покажите запись захаживать к вам больше не буду!"'
gop_grup_event_t3 = RAND(0,1)
	if gop_grup_event_t3 = 0:$gop_grup_event_t3 = 'Хоть и с трудом, но вы смогли протолкнуть оба члена себе глубоко в рот и даже ухитряетесь иногда ласкать их языком, игнорируя рвотные позывы.'
	if gop_grup_event_t3 = 1:$gop_grup_event_t3 = 'Вам трудно дышать и на глазах непроизвольно выступили слезы. Давясь и хрипя, исходя слюнями, вы пытаетесь отсосать оба члена, с трудом игнорируя рвотные позывы.'
gop_grup_oral_text = RAND(0,5)
	if gop_grup_oral_text = 0:$gop_grup_oral_text = 'Вы обхватываете своими <<$liptalk>> губами член <<$shultextrand33>>, в этот момент подходит <<$shultextrand3>> и со cловами - "Открывай шире пасть, шалава" начинает бесцеремонно впихивать еще свой хер,
растягивая ваш девичий ротик до предела. Вы протестующе мычите, но парни крепко держат вашу голову, не давая вырваться, и начинают грубо сношать вас в рот одновременно.
<<$gop_grup_event_t3>>
Не обращая внимание на ваше состояние, гопники продолжают наяривать вас в рот, отпуская оскорбительные комментарии и похлопывая по щекам.'
	if gop_grup_oral_text = 1:$gop_grup_oral_text = '-"Надо будет в следующий раз на телефон снять, как она тут давится, да <<$gop_textr4>> показать" - услышали вы за спиной тихий голос <<$shultextrand33>>, обращенный к остальным гопникам. Позади вас раздались смешки.'
	if gop_grup_oral_text = 2:$gop_grup_oral_text = '<<$gop_textr>> шушукаются у вас за спиной думая что вы не слышите, вы слышите обрывки разговора- "...<<$name[2]>> то? Ну мне батя говорил что мать у нее та еще шлюха была в молодости, сосала как пылесос, так что это гены!". Вы покраснели.'
	if gop_grup_oral_text = 3:$gop_grup_oral_text = 'Вы стали делать минет трем одновременно, они по очереди запихивали свои большые залупы вам в рот. Кряхтя вы пытались заглатывать полностью их члены.
Пока сосали один конец, двумя руками жестко дрочили два остальных. <<$gop_textr>> были на вершине блажентства.
-"Хорошая соска, интересно, а другие дырки у нее тоже рабочие? Надо будет проверить." - услышали вы тихие перешептывания за своей спиной.'
	if gop_grup_oral_text = 4:$gop_grup_oral_text = '<<$gop_textr>> стали шлепать своими хуями вам по лицу. Вы раскрыли рот и пытались лизнуть их. Когда хуи окончательно отвердели, <<$shultextrand3>> улегся на землю.
Вы тут же встали раком и, склонив голову, заглотили хуй и стали сосать его, с явным удовольствием.
- Давай-давай, <<$shultextrand2>> - подбодрил вас <<$shultextrand3>>.
В это время, <<$shultextrand33>> плюнул себе на пальцы и засунул два из них вам в жопу. Вы застонали и завертели сракой. <<$shultextrand33>>, повращав пальцы в вашем очке, вытащил и поднес к вашему рту и вы облизали их.'
	if gop_grup_oral_text = 5:$gop_grup_oral_text = 'Вы широко раздвинула ляжки, продемонстрировав свою чисто выбритую пизду. Трусики прикрывали только дырку, и то немного. Взору <<$gop_textr4>> предстали сильно вытянутые половые губы плюс крупный клитор, что натолкнуло их на мысль о любви девушки к мастурбации.
Сильно возбудившись от своих действий, раньше вы об этом только мечтали, наслаждаясь в одиночестве, а сейчас решились перешагнуть через все приличия и превратить свои фантазии в реальность.
<<$shultextrand3>> не удержался и потрогал за клитор, после чего сильно растянул половые губы в разные стороны.
Вы сильно потекли от возбуждения и абсолютно не сопротивлялась. Тем не менее, <<$shultextrand3>> убрал руки и сказал:
	- У тебя отличная дырка, впечатление такое, что ты трахаешься постоянно. Даже трудно поверить, что это не так.
	- Или так? - спросил <<$shultextrand33>>.
	- Вы правы мужчины у меня не редкость последнее время, каждый день как минимум сосу.
	- Любишь брать в рот?
	- Мне нравиться есть сперму. Люблю когда ебут в горло несколько человек подряд, а потом все кончают на лицо, в рот. <<$gop_textr>> сильно возбудились.
Изгибаясь, наклоняясь вперед, показывая свои длинные срамные губы. Юбка и трусы были всего лишь эротическими атрибутами.
Сильно оттягивала срамные губы, стараясь растянуть их еще сильнее. Возбуждение нарастало, и вы просто сказали "выебите меня во все щели".
<<$gop_textr>> поняли, что пора приступать к действию. Вы не смотрели, кто был первым, вам было все равно. Члены входили в самое горло, заставляя вас давиться. Весь рот был в слюне, а по переносице постоянно били яйца.
Вас возбуждало такое положение еще больше.'
gop_grup_event = RAND(0,2)
	if gop_grup_event = 0:$gop_grup_event = '<center><img src="images/qwest/alter/placer/BjBeer'+RAND(14,15)+'.jpg"></center>
Вы помните что от вас требуется и покорно открываете рот как можно шире, член Витька с размаху ударяет в ваше <<$throattipe>> горло,
в этот момент подходит Ден и со словами "Держи пасть открытой, <<$shultextrand2>>" по традиции начинает бесцеремонно впихивать еще свой, растягивая ваш девичий ротик до предела.
Вы не сопротивляетесь, позволяя парням использовать свой рот как им угодно. С мычанием и причмокиванием, вы пытаетесь принять поглубже оба члена.
<<$gop_textr>> продолжают жестко пялить вас в рот, отпуская оскорбительные комментарии: "Смотри уже приноровилась к двум, может ей третий вставить?"
Шульга говорит "Я только за, уже заебался тут стоять дрочить"<br>
Неожиданно вы почувствовали чей то взгляд на себе. Подняв глаза, вы увидели вашего брата притаившегося в кустах и с ошеломленным видом наблюдающего вами.
Не было никаких сомнений в том, что он узнал вас и теперь с горящими от возбуждения глазами наблюдал за тем, как вы демонстрируете свои оральные навыки.
А может и не только наблюдал, судя по напряженной позе. А вы не в состоянии ни уйти, ни даже отчитать мелкого извращенца – вас в этот момент беспардонно нахлобучивают ртом на оба мужских достоинства разом.
Остается только возмущенно мычать и посылать гневные взгляды, сгорая от стыда за свой внешний вид.
Какой позор, как будто мало было прошлой съемки на телефон, думаете вы, параллельно стараясь сдержать рвотные позывы когда член ударяется вам в горло, вот непруха.
Что если он расскажет маме или отчиму? От размышлений вас оторвал поток спермы неожиданно заполонивший вашу гортань, вы закашлялись и отпрянули, подставляя под вязкую жидкость губы и лицо.
Затем вы попытались вновь найти брата глазами, но его уже и след простыл.'
	if gop_grup_event = 1:$gop_grup_event = '<center><img src="images/qwest/alter/placer/BjBeerPhone.jpg"></center>
Вы обхватываете своими <<$liptalk>> губами член Витька, в этот момент подходит Ден и со cловами "Открывай шире пасть, <<$shultextrand2>>" начинает бесцеремонно впихивать еще свой, растягивая ваш девичий ротик до предела.
Неожиданно Шульга достает телефон и начинает снимать вас, комментируя происходящее. "Всем хай, это новости Павлово, сегодня у нас в гостях <<$gnikname>> <<$name[1]>>, привет <<$name[1]>>"
"Мвхр…мфлм…" - мычите вы не в силах ничего сказать. Парни держат вас крепко, не давая вырваться, и продолжают грубо сношать вас в рот двумя хуями.
-"<<$name[1]>> сейчас сосет за пиво, она очень любит это дело. Любишь ведь?" - Ден сжал ваши <<$hapri>> <<$hair2>> волосы в кулаке и вы утвердительно замычали, кивая головой.
– "За бутылку пива - отсос с проглотом у троих, где еще найдешь такую дешевую хуесоску?" - продолжает издеваться гопарь.
Вы протестующе мычите и пытаетесь отвернуться от камеры, но парни крепко держат вашу голову, не давая пошевелиться.
Вы с ужасом представляете как глупо и унизительно вы выглядите на видео: на коленях, с двумя толстыми хуями в вашем девичьем ротике, втиснутыми так плотно, что оттопыриваются щеки, а губы растянуты до предела.
<<$gop_grup_event_t1>>
К счастью парни перевозбудились и кончили довольно быстро. Обильно оросив ваше лицо спермой, они заставили вас облизать опавшие члены, но не отпустили вас.
-"А еще она начинающая актриса, первая ее роль – это выебанная в рот шлюха, а теперь передай привет маме" - говорит Шульга, продолжая снимать вас на телефон.
<<$gop_grup_event_t2>>'
	if gop_grup_event = 2:$gop_grup_event = '<center><img src="images/qwest/alter/placer/BjBeerBeaten.jpg"></center>
Вы отказываетесь сосать ради банки пива. Гопники приходят в бешенство. "Ты че, тварь, ваще берега попутала, забыла где твое место?" – с этими словами <<$shultextrand3>> отвешивает вам пощечину.
Глаза моментально наполняются слезами. Вы пытаетесь убежать, но силы явно неравны, гопари хватают вас и бросают на землю. - "Придется проучить тебя."
Вы плачете и умоляете не трогать вас. "Заткнись, сука" - ваши трусики грубо запихивают вам в рот, вы едва не задохнулись. Двое держат, а <<$shultextrand3>> начинает звонко шлепать по жопе.
Вы стонете и мычите сквозь трусики, непроизвольно дергаясь когда рука опускается на ваши покрасневшие ягодицы, по щекам текут слезы.
"Ну что поняла свой косяк, шмара тупая?" - вы покорно киваете головой - "Посмотрим как поняла". Вас ставят коленями на скамейку, облокотив грудью на спинку.
Вытащив из вашего рта обслюнявленные трусики, <<$shultextrand33>> помещает на их место свой пахнущий мочой хер и делает несколько движений бедрами, вгоняя его глубже в горло.
Отшлепанная и сломленная, вы лишь причмокиваете, смирившись с хуем во рту. -"Ну вот сразу бы так, а то ломалась как английская королева"- смеется гопник.
Он дает вам небольшую передышку, вытаскивая член, от которого к вашим губам протянулась ниточка вязкой слюны. - "А теперь сама поработай своим блядским ротиком."'
			rndpsos=rand(1,100)
			if rndpsos>15:'<center><img src="images/zsoft/park/gopota/sex/group/oral/o'+rand(1,33)+'.jpg"></center>
			<<$gop_grup_oral_text>>'
			if rndpsos<=15:'<<$gop_grup_event>>'
			if rndpsos<=15: act 'Уйти':gt'zz_park'
			if rndpsos>15:
				act 'Трахаться':
					*clr & cla
					gs'stat'
					sex += 1
					anal +=1
					gang +=1
					if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
					dick = $npc['10,dick']
					horny += 5
					minut += 5
gop_grup_eba = RAND(0,2)
	if gop_grup_eba = 0:$gop_grup_eba = 'В это время, <<$shultextrand33>> плюнул себе на пальцы и засунул два из них вам в жопу. Вы застонали и завертели сракой. <<$shultextrand33>>, повращав пальцы в очке, вытащил и всадил вам в сраку свою елду по самые яйца - Вы охнули.
<<$shultextrand33>> сказал: "Судя по всему, наша <<$shultextrand2>> отлично разработала свое очко, идет как по маслу."
Остальные <<$gop_textr>> пристроили свои хуи к вашему рту. Вы начали сосать причмокивая как дорогая шлюха.
Подолбив вас достаточно долго, <<$gop_textr>> решили поменяться. <<$shultextrand33>> посадил вас на свой хуй, а <<$shultextrand3>> засунул хуй в ваше разработанное очко. Третий участник взял вас за волосы и принялся грубо ебать в рот.
Итак, <<$gop_textr4>> вы отдали все свои развратные дырки, и вы явно наслаждались этим действом, чувствуя хуи в своей пизде, сраке и рту одновременно, вас это сильно возбудило, вы не сдерживаясь мычали от наслаждения.'
	if gop_grup_eba = 1:$gop_grup_eba = '- Ну поехали - сказали вы и схватила два ближайших члена. Наклонив туловище, не сгибая коленей вы стали отсасывать у них поочередно. Дэн тем временем раздвинул ваши ягодицы и длинный член вонзился вам в пизду.
Затем сзади стали меняться и вдруг третий вставивший в вас член неожиданно кончил, все дружно загоготали. Один из парниш лег на пол и приказал вам сесть на него.
Вы покорно вставили его инструмент себе во влагалище и активно заерзали тазом вверх-вниз. Два толстых члена тут же уперлись вам в рот, от этого ваш рот чуть не растянулся до ушей.
Вы, как могли, стали одновременно отсасывать два члена, попеременно облизывая головки, и стараясь просунуть кончик языка в прорезь головок. <<$gop_textr>> от такой техники пришли в полный восторг.
<<$shultextrand33>> решил позариться на ваш анус, который единственный не принимал участия в оргии. Его палец проник в ваше очко и стал растягивать проход. Поняв, что растягивать там нечего, сунул свою залупу прямо вам в сраку.
Вы от неожиданного ощущения взвизгнула и слегка прикусили находящийся у вас во рту член одного из <<$gop_textr>>. После прикуса со словами "Охуела сука!!!" <<$shultextrand3>> влепил вам затрещину, и пошел разминать свой пострадавший инструмент.
Тем временем <<$shultextrand33>> стал усиленно трахать вас в очко. Два члена терлись вызывая неведомые до этого чувства кайфа и наслаждения.
Через каких то пару мгновений такой трахалки необыкновенная волна экстаза поднялась от низа вашего живота, заполняя всю до самого верха. Истошный вопль вырвался у вас изо рта. <<$gop_textr>> восприняли это на ура.'
	if gop_grup_eba = 2:$gop_grup_eba = 'А сзади началась жара, <<$gop_textr>> по очереди стали терзать ваш анус. Видимо им это доставляло невиданною удовольствие, каждый ебал пару минут и уступал место другу.
Так поебав вас минут 10 в сраку, они решили что вы слишком расслабились и начали ебать вас сразу во все дыры. Разложив на лавочке как бесплатную блядь
Поебав так вас еще минут 5 вы начали сходить с ума и кричать: "Чч... чч... что... же... же... вы... де... ла... е... те... . оййййй... ааааааййййй... . уууууй... мма... . . маааааа."'
					'<center><img src="images/zsoft/park/gopota/sex/group/sex/s'+rand(1,55)+'.jpg"></center>'
					'<<$gop_grup_eba>>'
					dynamic $hornyparksex
					dynamic $cumfacegr
					dynamic $cummouthgr
					dynamic $gopcumassgr
					!dynamic $cummouth
					!dynamic $cumbody
					!dynamic $cumvagina
				end
			end
		end
	end
end
!пару эвентов в парке когда гг писает
if $ARGS[0] = 'piss':
	$r1_event_piss = {
		minut += 5
		gs'stat'
		'Писая вы услышали шаги и разговор двух человек. Закончив свое дело, вы повернувшись увидели двух полицейских.
<table><tr><td><img src="images/zsoft/park/gopota/piss/event/p.jpg"></td><td>
Они подошли к вам и начали разговор.<br> Гражданка вы знаете где находитесь? Это общественная территория, парковая зона, тут люди ходят. А вы нужну справляете, как вам не стыдно?<br>
Справление естественной нужды в общественных местах грозит вам штрафом, у вас есть выбор:<br>
Проехать с нами в отделение полиции, посидеть в обезъяннике пока мы заполним протокол административного нарушения и выпишим вам штраф.<br>
Либо можно все упростить, вы оплачиваете штраф нам на руки, без протоколов и всей этой волокиты, вы экономите время. Мы возьмем с вас всего 500р
</td></tr><tr></table>'
		if money >= 500:
			act 'Заплатить штраф':
				*clr & cla
				gs'stat'
				money -= 500
				'<center><img src="images/zsoft/park/gopota/piss/event/vz'+rand(1,3)+'.jpg"></center>'
				'Вы отдали 500р. Полицейский взяв деньги, довольно улыбнулся и сказал: "Гражданка больше так не делайте, всего хорошего".'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		end
		act 'Ехать в участок':schtraf = 500 & minut += 5 & katalkinNoexit = 1 & gt'katalkin'
		act 'Сказать "У меня нет денег"':
			*clr & cla
			gs'stat'
			'<center><img src="images/zsoft/park/gopota/piss/event/p2.jpg"></center>'
			'Вы сказали что у вас нет денег.'
			'Один из полицейских сказал: "Тогда придется проехать в участок, там мы заполним протокол, выпишим штраф и позвоним вашим родным, они приедут заплатят штраф и заберут вас."'
			'Вам не хотелось, что бы все узнали о случившемся и предложили иной вариант который устроит всех.'
			act 'Ехать в участок':schtraf = 500 & minut += 5 & katalkinNoexit = 1 & gt'katalkin'
			act 'Сосать':
				*clr & cla
				horny += 5
				minut += 5
				bj += 1
				gs 'zz_funcs', 'cum', 'face'
				gs'stat'
				'<center><img src="images/zsoft/park/gopota/piss/event/p_otsos.gif"></center>'
				'Вы встали на колени и принялись за дело'
				'Вы провели своими толстыми губами по головке члена и вобрали его в свой ротик. Ваш ротик оказался быстро заполнен твердым членом который вы начали смачно сосать.'
				'Рядом с вашим лицом появился еще один член, чуть больше первого и начал тыкаться вам в щёку, вы жадно вцепились в него рукой и начали надрачивать, по очереди пихая себе в рот, то один, то другой член.'
				gs 'zz_dynamic_sex', 'swallow'
				'Второй член начал кончать теплой спермой на ваше милое личико'
				'Полицейские застегивая ширинки, поблагодарив вас за первокласный отсос.'
				act 'Уйти':gt'zz_park'
				act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
			end
		end
	}
	$r2_event_piss = {
		horny += 5
		minut += 5
		gs'stat'
		'Вы пошли в лес пописать. Только стянули трусики, присели и услышали позади себя треск веток, обернувшись увидели:'
		'Недалеко, в паре десятков метров от вас был мужик. Один из компании алкашей, которая частенько выпивала в этом парке. Видимо тоже пошел в лес по тому же самому делу.'
		'Вы хотели встать и уйти, но очень хотелось писать. Вы отвернули голову и расслабились. Думала, что он уйдет, но этого не произошло.'
		'Писая, прямо чувствовали, как он наблюдает за вами сзади. Вы встали, надела трусики и ушли как ни в чем не бывало.'
		'Вас эта бестыдная ситуация чуть-чуть возбудила.'
		act 'Уйти':gt'zz_park'
		act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
	}
	$r3_event_piss = {
		minut += 5
		gs'stat'
		'Вы отошли подальше в глубь парковой зоны и присели. В голове шумело от выпитого, очень хотелось пописать. Сняв трусики расставили ноги и теплая струя зажурчала по траве и сухим листьям.'
		'Приятное чувство опорожнения заставили присесть сильнее, рука скользнула вниз и палчики пощекотали клитор.'
		'Вдруг резкий толчек и вы уже лежите под чьим то телом, "Не кричи а то стукну" произнес хриплый голос и с вас стали стаскивать юбку с трусами'
		act 'Не сопротивляться':
			*clr & cla
			horny += 5
			manna -= 30
			health -= 30
			minut += 15
			rape += 1
			gs'stat'
			'<center><img src="images/zsoft/park/gopota/piss/event/ev3_1.gif"></center>'
			'К вам подошли остальные, парень который первым увидел у вас голую без трусов пизденку, подошел и сказал:'
			'— Девушка, давайте познакомимся, оттянемся по полной, предложил он.'
			'На, что вы ответили, что не отрываетесь с незнакомцами. Тогда он вплотную подошел и неожиданно даже для вас просунул руку под юбку.'
			'Вы дернулись, он провел рукой и сжал пиздень ладонью. Он широко улыбнулся, повернув голову сказал:'
			' — Девушка у нас замерзла, — вы попытались возразить, но он продолжил, — пизденка у этой бляди вся мокрая, наверное «насморк» подхватила.'
			'Толпа засмеялась, тут у вас в голове проскочила мысль: «доктор, бля нашелся», он продолжил:'
			'- Ну, пацаны, надо даму выручать, четыре свечи есть, правда дырки всего три, но я думаю лишнее лекарство не повредит.'
			'При этом он взял вас за голову, а сам присел на лавку, расстегнул штаны и достал член, довольно таки длинный но не тонкий, не давая время опомниться он вставил его вам в рот и надавил рукой на голову.'
			'Стоя раком с выпяченной задницей в окружении парней, которых даже не знаете, вы потекли еще сильней. Тут почувствовали, что у вас задрали юбку, но ни кто не вставляет и вдруг услышали голос:'
			' — Бля, да у этой шалавы охуительный станок для ебли.'
			act 'Далее':
				*clr & cla
				gs'stat'
				'<center><img src="images/zsoft/park/gopota/piss/event/ev3_2.gif"></center>'
				'Как вы ждали этих слов, вас начало потряхивать, чуть не взвыли.'
				'Вас усадили пиздой на член парня которому вы сосали, другой парень плюнув вам на анальное колечко и начал просовывать свою дубинку в попу'
				'Хотели вскрикнуть, но вам в рот уже вставляли третий член, а руку положили на четвертый, волна оргазма стала накатывать одна за одной, парни начали ускоряться, вы поняли что они сейчас кончат, вот, вот, еще чуть чуть...'
				act 'Далее':
					*clr & cla
					gang +=1
					horny += 5
					orgasm += 1
					manna += 5
					gs'stat'
					'<center><img src="images/zsoft/park/gopota/piss/event/ev3_3.gif"></center>'
					'Но не тут то было вас резко сняли с членов. Парень которому вы активно отсасывали лег на скамейку, несколько сильных рук переместили вас на его член, парень которому вы дрочили начал вставлять вам в зад свою багровую залупу.'
					'А два других ебарька встали перед вами и начали засовывать свои письки вам в рот.'
					'Парни были довольны, они обзывали вас шлюхой, конченой блядью, ебливой шалавой, вы слушали это и думали, что готовы не только на это, что готовы сейчас пропустить футбольную команду, лишь бы ваши дырки были заполнены.'
					'Ваше тело начало дрожать и вы бурно кончили.'
					act 'Далее':
						*clr & cla
						gs'stat'
						'<center><img src="images/zsoft/park/gopota/piss/event/ev3_4.gif"></center>'
						'Один вогнал елдак по самое самое горло и выстрелил вам в глотку.'
						'Остальные надрачивая стали кончать вам на лицо.'
						'Потом один из них достал из сумки которую вы не заметили пиво и раздал другим, они встали возле лавочки и практически одним глотком осушили бутылки и начали собираться, вы подумали, что они уйдут и практически так оно и получилось.'
						'Вдругодин из парней сказал, что на последок он хотел бы увидеть как вы пихаете бутылку пиво себе в пизду...'
						act 'Далее':
							*clr & cla
							horny += 5
							mastr += 1
							gs'stat'
							'<center><img src="images/zsoft/park/gopota/piss/event/but.jpg"></center>'
							'Вы были обессилены и не стали ничего говорить, взяли бутылку и стала засовывать в письку.'
							'Ребята одобрительно похвалили, немножно посмотрел шоу как вы мастурбируете бутылкой и потеряв к вам интерес, разошлись.'
							act 'Уйти':gt'zz_park'
							act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
						end
					end
				end
			end
		end
	}
	$r4_event_piss = {
		'Вы выбрали место как вам казалось, откуда вас была не видно и быстро приспустив трусики присели писать. Несколько бутылок пива дали о себе знать и быстро пописать не получилось.'
		'Мощная струя все лилась и лилась из вас, видели краем глаза как ваша компания стала фоткать вас на мобильный.'
		'Невольно покраснев как школьница у которой на физкультуре случайно обнажилась грудь, стало жарко от стыда, сердце стучало как бешенное, а вы все еще не могли остановиться и продолжала писать.'
		'Такого смущения вы не испытывали очень давно! Но, через минуту, которая показалась бесконечной, вслед за стыдом накатила волна возбуждения! В таком состоянии уже было все похуй.'
		'Тщательно и неспеша стряхнув последние капельки золотого дождя со своей развратной пизденки на землю.'
		'Довольная, но до предела возбужденная, вы виляя бедрами как последняя блядь, чувствовали на себе взгляды ребят.'
		act 'Уйти':gt'zz_park'
		act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
	}
rand_event_piss = RAND(0,3)
	if rand_event_piss = 0:$rand_event_piss = $r1_event_piss
	if rand_event_piss = 1:$rand_event_piss = $r2_event_piss
	if rand_event_piss = 2:$rand_event_piss = $r3_event_piss
	if rand_event_piss = 3:$rand_event_piss = $r4_event_piss
	*clr & cla
	manna += 10
	health +=10
	minut += 1
	water -=2
	piss +=1
	gs'stat'
	'<center><img src="images/zsoft/park/gopota/piss/piss'+rand(1,6)+'.jpg"></center>'
	ranadpercent = rand(1,100)
	if ranadpercent <= 30:
		dynamic $rand_event_piss
		exit
	end
r_piss_text = RAND(0,3)
	if r_piss_text = 0:$r_piss_text = 'Вы нашли безлюдное место и спокойно пописали'
	if r_piss_text = 1:$r_piss_text = 'Выбрав безлюдное место, приспустив трусики начали писать'
	if r_piss_text = 2:$r_piss_text = 'Приспустив трусики присели писать'
	if r_piss_text = 3:$r_piss_text = 'Стянув трусики вы начали сикать'
	if ranadpercent>30:'<<$r_piss_text>>. Ничего интересного не произошло.'
	if ranadpercent>30: act 'Уйти':gt'zz_park'
	if ranadpercent>30: act 'Вернутся к <<$gop_textr4>>':gt'zsoft_gopskverGorSlut','2'
end
!показать сиськи
if $ARGS[0] = 'siski':
	*clr & cla
	minut += 5
	horny += 1
	dom -= 1
	gs'stat'
sis_gop_text = RAND(0,5)
	if sis_gop_text = 0:$sis_gop_text = '<<$shultextrand2>>, заебись у тебя сиськи, на физре от тебя взгляд оторвать не могу.'
	if sis_gop_text = 1:$sis_gop_text = '<<$shultextrand2>>, супер сиськи, на физре когда бегаешь трясутся так возбуждающе, физрук глаза оторвать не может.'
	if sis_gop_text = 2:$sis_gop_text = '<<$shultextrand2>>, у кого денег насосала на такие классные сиськи?'
	if sis_gop_text = 3:$sis_gop_text = '<<$shultextrand2>>, бля я бы каждый день тебе между сисек свою палку пихал'
	if sis_gop_text = 4:$sis_gop_text = '<<$shultextrand2>>, я бы тебе вдул между этих классных мячиков'
	if sis_gop_text = 5:$sis_gop_text = '<<$shultextrand2>>, дашь вялого между сисек погонять?'
	if horny>=50:$sis_gop_text = '<<$shultextrand2>>, может шоу нам покажешь, подрочишь свою письку?'
	'<center><img src="images/zsoft/park/gopota/piss/event/tits'+rand(1,5)+'.gif"></center>'
	'По просьбе вы оголили <<$shultextrand8>>, <<$gop_textr>> начали вас <<$gop_textr3>>.'
	'<<$shultextrand3>> <<$shultextrand6>> говорит: "<<$sis_gop_text>>" <<$gop_textr>> заржали.'
	act 'Спрятать сиськи':gt'zsoft_gopskverGorSlut','2'
	if horny >= 50:
		act 'Подрочить':
			*clr & cla
			horny += 5
			minut += 5
			mastr += 1
			gs'stat'
			'<center><img src="images/zsoft/park/gopota/piss/event/mast'+rand(1,3)+'.gif"></center>'
rnd_droch_text = RAND(0,3)
	if rnd_droch_text = 0:$rnd_droch_text = 'Вы никого не стесняясь начали дрочить свою письку, <<$gop_textr>> с интересом наблюдали за вами.'
	if rnd_droch_text = 1:$rnd_droch_text = 'Как только рука коснулась вашей невероятно влажной писечки, вас накрыл сильнейший оргазм. Пришли в себя минуты через две.
<<$gop_textr>> похлопали вам, <<$shultextrand33>> <<$shultextrand6>> сказал: "Отличное шоу устроила наша классная <<$shultextrand2>>"'
	if rnd_droch_text = 2:$rnd_droch_text = 'Вы сняв трусики, удобно устроившись начинаете тихонько тереть клитор, <<$gop_textr>> с интересом наблюдают за вами.'
	if rnd_droch_text = 3:$rnd_droch_text = 'В сладостной истоме вы дрочили свою пизду, попутно мяли свои сиськи, <<$gop_textr>> смотрели на это шоу с широко раскрытыми глазами.'
			'<<$rnd_droch_text>>'
			act 'Превести себя в порядок':gt'zsoft_gopskverGorSlut','2'
		end
	end
end