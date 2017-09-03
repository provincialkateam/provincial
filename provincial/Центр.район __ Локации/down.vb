$metka = $ARGS[0]
$loc = $CURLOC
$control_point = $curloc
*clr
bordysh = 0
housrA = 0
obdysh = 0
gs 'stat'
gs 'time'
gs 'zz_render', 'Центр города', func('zz_funcs','mk_image','city/center/center')
if shantpopala > 0:
	cla
	*clr
	hour += 8
	gs 'zz_funcs', 'cum', 'belly'
	gs 'zz_funcs', 'cum', 'ass'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	cumfrot += 1
	gs 'zz_funcs', 'cum', 'anus'
	guy += 2
	rape += 1
	sex += 1
	bj += 1
	anal += 1
	shantpopala -= 1
	gs 'zz_render', '', 'images/img/centr/rape.jpg', 'На улице около вас резко тормозит черный джип, из него выскакивают двое амбалов и затаскивают вас в машину.<br><do>"Твоя работа тварь?"</do> кричит один тыча вам в нос фотографии которые вы вчера отправили в надежде получить прибыль.<br>"Нет, я ничего не понимаю" пытались вы оправдаться<br>"Не ври сука тебя вычислили" с этими словами он бьет вас рукояткой по голове и вы отрубаетесь<br>Очнулись вы уже где то за городом, связанная и абсолютно голая, все тело было покрыто спермой а анус с вагиной ужасно болели.<br>Амбалы сидели недалеко и курили, <do>"О наконец очнулась, ну что еще кружок, сейчас затрепыхается, будет веселее."</do> сказал один из них.<br>Они встали и подошли к вам, через минуту вы пожалели что очнулись, эти уроды имели вас как им хотелось, вы пытались сопротивляться но скотч не позволял вам двигаться, вскоре вы опять потеряли сознание.<br><do>"Ну что поняла, сука"</do> очнулись вы от голоса одного из них и тут же получили удар ботинком в живот. Амбалы сели в машину и уехали. До дороги было метров сто и вы связанная, извиваясь как змея поползли в сторону дороги. Когда вы доползли то снова отключились, очнулись вы в какой-то машине, которая и довезла вас до дома.'
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Уйти':gt $curloc
	exit
end
gs 'zz_funcs', 'waiting'
if _taxi_time >= 0: gs 'taxi','check'
gs 'car', 'check'
if $npc['31,qwTanyaMain'] > 3: gs 'zz_render', '', '', '<a href="exec:gt''tanya_apartment''">Квартира Тани</a>'
if izoldaQW >= 1:'<a href="exec:GT ''qwIzoldaApp''">Квартира Изольды</a>'
!if yaq = 1:'Квартира <a href="exec:GT ''yarik'',''start''">Ярослава</a>'
if $npc['32,relation'] > 45: gs 'zz_render', '', '', 'Квартира <a href="exec:GT ''peterroom'',''start_door''">Питэра</a>'
if hour >= 9 and hour <= 20: gs 'zz_render', '', '', 'Магазин женской одежды <a href="exec:minut += 15 & GT ''NewCloShop''">"Модница"</a>'
if hour >= 4 and hour <= 23: gs 'zz_render', '', '', 'Станция <a href="exec:GT ''metro'',''start''">метро</a> расположена в 5 минутах ходьбы'
if week >= 4 and hour > 15: gs 'zz_render', '', '', 'Модный <a href="exec:GT ''club'',''start''">Ночной клуб "Магнат"</a> вечерами сияет огнями, привлекая молодежь со всего города'
if hour > 15 or hour <= 2: gs 'zz_render', '', '', '<a href="exec:GT ''stripclub'',''start''">Стрип-клуб</a> расположился неподалёку от ночного клуба.'
if hour >= 9 and hour <= 20: gs 'zz_render', '', '', 'В центре города стоит большой <a href="exec:gt''torgcentr''">торгово-развлекательный центр</a><br>Дорогой и престижный <a href="exec:GT ''fit'',''start''">Фитнес-центр</a> в котором тренируются в основном желающие похудеть к пляжному сезону, но есть и неплохая секция кик-боксинга<br><a href="exec:GT ''foto'',''start''">Фотостудия "Стоп-кадр"</a>расположилась в паре кварталов от метро в старинном красивом, хоть и обшарпанном, особняке.<br><a href="exec:GT ''bass'',''start''">Бассейн</a>'
if hour >= 8 and hour <= 22: gs 'zz_render', '', '', 'Дорогой <a href="exec:GT ''restoran'',''start''">Ресторан</a> около которого всегда припаркованы роскошные автомобили'
gs 'zz_render', '', '', 'Крупный <a href="exec:GT ''sexshop'',''start''">Секс-шоп</a> для извращенцев со всего города'
if hour >= 6 and hour <= 23: gs 'zz_render', '', '', 'Закусочная <a href="exec:GT ''burger'',''start''">"Быстроешка"</a>'
if bordel > 0 and hour >= 20 or bordel > 0 and hour <= 3: gs 'zz_render', '', '', 'Во дворах вход в <a href="exec:GT ''bordel''">Бордель</a>'
if pornstudio >= 1 and hour > 5: gs 'zz_render', '', '', '<a href="exec:GT ''pornstudio'',''start''">Киностудия</a>, в которой снимают фильмы для взрослых'
gs 'zz_render', '', '', 'Практически всю южную часть района занимает <a href="exec:gt''uni_campus''">студенческий городок</a> гуманитароного университета.'
!if hour >= 7:gs 'zz_render', '', '','Престижный <a href="exec:gt ''university'',''start''">Университет</a> является альма матер практически всех образованных людей города.'
!if hour >= 6 and hour <= 23:'Университетское <a href="exec:GT ''dorm'',''start''">общежитие</a>, малость обшарпанное несмотря на высокий статус университета'
if week < 6 and hour >= 9 and hour <= 18: gs 'zz_render', '', '', '<a href="exec:GT ''bank''">Центральный Городской Банк</a>'
if week < 6 and hour >= 8 and hour <= 17: gs 'zz_render', '', '', 'Крупнейшая <a href="exec:GT ''office'',''start''">Проектная организация</a> в городе'
if hour >= 8 and hour <= 18: gs 'zz_render', '', '', '<a href="exec:GT ''agentned'', ''start''">Агентство недвижимости</a>'
gs 'zz_render', '', '', 'В 20 минутах ходьбы расположен большой <a href="exec:minut+=20 & GT ''zz_park''">Парк Победы</a>, соединяющий все части города.'
gs 'zz_dyns', 'street_cum'