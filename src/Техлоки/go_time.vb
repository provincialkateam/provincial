!if'Техническая лока для просчета передвежения
	расчет идет по сетке слева направо, сверху вниз
	x - координата ячейки по номеру столбца
	y - координата по номеру строки
	x_end - координата x предыдущего места
	y_end - координата y предыдущего места
	$control_point - используется для контроля, что игрок не покинул текущую карту через такси или еще каким то способом.
	$control_point_end - предыдущая локация
	time_go - переменная полученная по результатам расчета в минутах.
	t1 и t2 - переменные для избегания отрицательного знака
	$loc - Проверка локаций, которые попадают в "исключения"
	$loc_point - точка, которая показывает, что ГГ прибыла в это место и его пока не покидала. Позволяет избегать постоянного расчета тайминга и уменьшает нагрузку.
	from_road = 1 - признак, что ГГ вышла на дорогу.
	ехала на такси = 1 ехала, 0 - не ехала
	1 - вышла на дорогу
	0 - не вышла'
!Задействованы такси или вышла на дорогу
if $curloc = 'road' : from_road = 1
!---------Перечень локаций и их координаты---------
!-----------------------------------------------------------------------------
!'--------------Павлово (gorodok_setka)-----------------------
zz_park		Парк
cafe_parco	Кафе "DelParco"
gpoli		Больница
glake		Озеро
gLakeNude	Дикий пляж
gschool		Школа
gdk			Дом культуры
gamehall	Игровые автоматы
cinema		Кинотеатр
shop		Супермаркет
barbershop	Парикмахерская
grinok		Рынок
vokzalG		Привокзальная площадь
hotel		Отель "Мимоза"
vokzalGin	Ж/д вокзал
gkafe		Кафе "Привокзальное"
apteka		Аптека
Gshveyfab	Швейная фабрика
gargazel	Гаражи
mey_home	Дом Мейнольдов
albina_ev	Дом Альбины
dimaGoHome2	Дом Носова
LariskaHome	квартира Груздевой
igorhome	квартира Круглова
korrPar		Квартира родителей
road		Трасса М-7
carwash		Автомойка'
if $control_point = 'gorodok':
	if $curloc = 'gpoli' : 			$loc_point = $curloc & x = 2 & y = 4
	if $curloc = 'cafe_parco' : 	$loc_point = $loc &  x = 7 & y = 3
	if $curloc = 'zz_park' : 		$loc_point = $curloc &  x = 6 & y = 5
	if $curloc = 'korrPar' : 		$loc_point = $curloc &  x = 7 & y = 8
	if $curloc = 'gdk' : 			$loc_point = $curloc &  x = 10 & y = 13
	if $curloc = 'barbershop' : 	$loc_point = $curloc &  x = 13 & y = 7
	if $curloc = 'gargazel' : 		$loc_point = $curloc &  x = 18 & y = 19
	if $curloc = 'gkafe' : 			$loc_point = $curloc &  x = 17 & y = 12
	if $curloc = 'glake' : 			$loc_point = $curloc &  x = 1 & y = 14
	if $curloc = 'gLakeNude' : 		$loc_point = $curloc &  x = 3 & y = 20
	if $curloc = 'grinok' : 		$loc_point = $curloc &  x = 14 & y = 11
	if $curloc = 'gschool' : 		$loc_point = $curloc &  x = 6 & y = 11
	if $curloc = 'Gshveyfab' : 		$loc_point = $curloc &  x = 16 & y = 1
	if $curloc = 'hotel' :			$loc_point = $curloc &  x = 16 & y = 13
	if $curloc = 'igorhome' : 		$loc_point = $curloc &  x = 11 & y = 5
	if $curloc = 'LariskaHome' : 	$loc_point = $curloc &  x = 13 & y = 9
	if $curloc = 'vokzalG' :		$loc_point = $curloc &  x = 16 & y = 10
	if $curloc = 'vokzalGin' :		$loc_point = $curloc &  x = 17 & y = 9
	if $curloc = 'albina_ev' : 		$loc_point = $curloc &  x = 4 & y = 14
	if $curloc = 'gamehall' : 		$loc_point = $curloc &  x = 9 & y = 7
	if $curloc = 'apteka' : 		$loc_point = $curloc &  x = 12 & y = 14
	if $curloc = 'shop' : 			$loc_point = $curloc &  x = 11 & y = 7
	if $curloc = 'mey_home' : 		$loc_point = $curloc &  x = 2 & y = 10
	if $curloc = 'dimaGoHome2' : 	$loc_point = $curloc &  x = 7 & y = 17
	if $curloc = 'tsarev_events' : 	$loc_point = $curloc &  x = 12 & y = 19
	if $curloc = 'road'  or  from_road = 1 : $loc_point = $curloc &  x = 20 & y = 6
end
!'---------Северный район (north_setka)----------------------------
banda_home		Бандитская квартира
banda_sklad		Бандитский склад
dk				ДК имени Ленина
skk				СКК “Турбина
zz_park			Парк Победы	/контроль локи
gamehall		Зал игровых автоматов
lakecafe		Шашлычная "Шампур"
shop			Супермаркет	/контроль локи
pirsingsalon	Пирсинг-салон
autosalonF		Автосалон
autotraidF		Авторынок
zz_pornstudio	Порно студия ГГ
autoservisF		Автомастерская
Terminal		Складской терминал
vokzal			Ж/д вокзал
metro			Метро “Северный”	/контроль локи
buklinik		Клиника милосердия
road			На трассу
apteka			Аптека'
if $control_point = 'north':
	if $curloc = 'Terminal' :               $loc_point = $curloc & x = 1 & y = 15
	if $curloc = 'skk' : 					$loc_point = $curloc & x = 2 & y = 13
	if $curloc = 'gamehall' : 				$loc_point = $curloc & x = 13 & y = 15
	if $curloc = 'vokzal' : 				$loc_point = $curloc & x = 5 & y = 2
	if $curloc = 'buklinik' : 				$loc_point = $curloc & x = 1 & y = 3
	if $curloc = 'road' or  from_road = 1 : $loc_point = $curloc & x = 6 & y = 19
	if $curloc = 'autosalonF' : 			$loc_point = $curloc & x = 2 & y = 6
	if $curloc = 'autotraidF' : 			$loc_point = $curloc & x = 1 & y = 8
	if $curloc = 'autoservisF' : 			$loc_point = $curloc & x = 2 & y = 5
	if $curloc = 'metro' : 					$loc_point = $curloc & x = 6 & y = 4
	if $curloc = 'shop' : 					$loc_point = $curloc & x = 10 & y = 5
	if $curloc = 'dk' : 					$loc_point = $curloc & x = 9 & y = 17
	if $curloc = 'zz_park' : 				$loc_point = $curloc & x = 19 & y = 19
	if $curloc = 'lakecafe' : 				$loc_point = $curloc & x = 11 & y = 1
	if $curloc = 'pirsingsalon' : 			$loc_point = $curloc & x = 15 & y = 12
	if $curloc = 'zz_pornstudio' : 			$loc_point = $curloc & x = 5 & y = 17
	if $curloc = 'banda_home' : 			$loc_point = $curloc & x = 2 & y = 4
	if $curloc = 'banda_sklad' : 			$loc_point = $curloc & x = 1 & y = 16
	if $curloc = 'apteka' : 				$loc_point = $curloc & x = 7 & y = 12
end
!'---------Центр(center_setka)-----------------------------
bordel		Бордель
fitness		Фитнес-центр
club		Ночной клуб
stripclub	Стрип-клуб
restoran	Ресторан "Bordeaux"
zz_park		Парк Победы
sexshop		Секс-шоп "Подружка"
burger		Кафе "Быстроешка"
uni_campus	Студенческий городок
foto		Фотостудия "Стоп-кадр"
pornstudio	Киностудия "Ню"
bank		Центральный Банк
office		Проектная организация
agentned	Агентство недвижимости
metro		Метро "Университетская"
salon		Салон красоты
apteka		Аптека
restoran	Ресторан
cinema		Кинотеатр
gamehall	Игровые автоматы
shop		Супермаркет
kiskis		Магазин одежды \"Кис-Киска\
peterroom		Квартира Питэра
tanya_apartment	Квартира Тани
butik		Бутик
university	Университет
bouling			Боулинг-клуб
		'
if $control_point = 'center':
	if $curloc = 'zz_park' : 	$loc_point = $curloc & x = 20 & y = 2
	if $curloc = 'pornstudio' : $loc_point = $curloc & x = 10 & y = 7
	if $curloc = 'bank' : 		$loc_point = $curloc & x = 6 & y = 12
	if $curloc = 'burger' : 	$loc_point = $curloc & x = 12 & y = 15
	if $curloc = 'sexshop' : 	$loc_point = $curloc & x = 7 & y = 8
	if $curloc = 'metro' : 		$loc_point = $curloc & x = 12 & y = 11
	if $curloc = 'agentned' : 	$loc_point = $curloc & x = 12 & y = 5
	if $curloc = 'office' : 	$loc_point = $curloc & x = 17 & y = 5
	if $curloc = 'foto' : 		$loc_point = $curloc & x = 11 & y = 12
	if $curloc = 'uni_campus' : $loc_point = $curloc & x = 16 & y = 14
	if $curloc = 'restoran' : 	$loc_point = $curloc & x = 8 & y = 17
	if $curloc = 'stripclub' : 	$loc_point = $curloc & x = 10 & y = 4
	if $curloc = 'fitness' : 	$loc_point = $curloc & x = 7 & y = 1
	if $curloc = 'restoran' : 	$loc_point = $curloc & x = 8 & y = 17
	if $curloc = 'salon' : 		$loc_point = $curloc & x = 15 & y = 8
	if $curloc = 'tanya_apartment' :	$loc_point = $curloc & x = 2 & y = 9
	if $curloc = 'club' : 		$loc_point = $curloc & x = 5 & y = 15
	if $curloc = 'peterroom' : 	$loc_point = $curloc & x = 19 & y = 18
	if $curloc = 'apteka' : 	$loc_point = $curloc & x = 5 & y = 6
	if $curloc = 'bordel' : 	$loc_point = $curloc & x = 15 & y = 8
	if $curloc = 'cinema' : 	$loc_point = $curloc & x = 10 & y = 10
	if $curloc = 'gamehall' : 	$loc_point = $curloc & x = 2 & y = 2
	if $curloc = 'shop' : 		$loc_point = $curloc & x = 2 & y = 17
	if $curloc = 'kiskis' : 	$loc_point = $curloc & x = 8 & y = 11
	if $curloc = 'butik' : 		$loc_point = $curloc & x = 13 & y = 9
	if $curloc = 'university' : $loc_point = $curloc & x = 12 & y = 18
	if $curloc = 'bouling' : 			$loc_point = $curloc & x = 3 & y = 12
	!if $curloc = '' : 			$loc_point = $curloc & x = 2 & y = 4
	!if $curloc = '' : 			$loc_point = $curloc & x = 2 & y = 4
	!if $curloc = '' : 			$loc_point = $curloc & x = 2 & y = 4
	!if $curloc = '' : 			$loc_point = $curloc & x = 2 & y = 4
end
!'---------Южный(south_setka)-----------------------------
zz_park		Парк
south_office		офисное здание
pizza		Пиццерия “Феличита”
lake		Пляж
BDSM_Club		Особняк
apteka		Аптека
katspalnya		Квартира Кати
shop		Супермаркет “Карта”
poli		Поликлиника №2
homeyard		Дворик
front_door		Подъезд
tailor		Ателье “белошвейка”
south_market		Рынок
relax		Студия “relax”
metro		Метро
gamehall		Лотерея
IrinaRoom		Квартира Ирины
kafe		Кафе “Кавказ”
billiards		Бильярд
danceclass		школа танцев'
	if $curloc = 'zz_park' : 		$loc_point = $curloc &  x = 4 & y = 3
	if $curloc = 'south_office' : 	$loc_point = $curloc &  x = 8 & y = 5
	if $curloc = 'pizza' : 			$loc_point = $curloc &  x = 10 & y = 4
	if $curloc = 'lake' : 			$loc_point = $curloc &  x = 16 & y = 2
	if $curloc = 'BDSM_Club' : 		$loc_point = $curloc &  x = 19 & y = 4
	if $curloc = 'apteka' : 		$loc_point = $curloc &  x = 17 & y = 7
	if $curloc = 'katspalnya' : 	$loc_point = $curloc &  x = 13 & y = 7
	if $curloc = 'shop' : 			$loc_point = $curloc &  x = 3 & y = 13
	if $curloc = 'poli' : 			$loc_point = $curloc &  x = 3 & y = 19
	if $curloc = 'homeyard' : 		$loc_point = $curloc &  x = 7 & y = 16
	if $curloc = 'front_door' : 	$loc_point = $curloc &  x = 8 & y = 17
	if $curloc = 'tailor' : 		$loc_point = $curloc &  x = 6 & y = 11
	if $curloc = 'south_market' : 	$loc_point = $curloc &  x = 8 & y = 10
	if $curloc = 'relax' : 			$loc_point = $curloc &  x = 8 & y = 13
	if $curloc = 'metro' : 			$loc_point = $curloc &  x = 10 & y = 15
	if $curloc = 'gamehall' : 		$loc_point = $curloc &  x = 11 & y = 10
	if $curloc = 'IrinaRoom' : 		$loc_point = $curloc &  x = 15 & y = 16
	if $curloc = 'kafe' : 			$loc_point = $curloc &  x = 17 & y = 14
	if $curloc = 'billiards' : 		$loc_point = $curloc &  x = 19 & y = 10
	if $curloc = 'danceclass' : 	$loc_point = $curloc &  x = 11 & y = 18
!Если на метро или поезде или через парк приезжает с другой карты
if $control_point_end ! $control_point and $control_point_end ! '' : x_end=x & y_end=y
if $loc_end = $loc_point and  $control_point_end = $control_point : jump 'end'
!старт игры
!-------Старт игры в локации begin задаются x и y
if x=0 and y=0  : x_end=x & y_end=y
!/-------Старт игры в локации begin задаются x и y
if $curloc ! 'road' and from_road = 1 : from_road = 0
!Если попал на дорогу с поезда или из другогопромежуточного пункта
if $curloc = 'road' and x ! x_end : x_end=x & y_end=y
!Приехал на такси/ ГГ попадает на карты и потом выбирает пункт, симулируется довоз такси человека на нужного пункта.
if $control_point_end ! $control_point and $loc_end ! $loc_point : $control_point_end = $control_point & x_end=x & y_end=y
!расчет t1 и t2
if x_end-x < 0:
	t1=x-x_end
else
	t1=x_end-x
end
if y_end-y < 0:
	t2=y-y_end
else
	t2=y_end-y
end
time_go = (t1 + t2)*2
x_end=x
y_end=y
$loc_end = $loc_point
!'здесь можно задавать условия для локаций "исключений"
if $loc = glakeNude
if $loc = glakeNude :
	iif(time_go<=.....)
end'
minut += time_go
:end
killvar 't1'
killvar 't2'
killvar 'time_go'