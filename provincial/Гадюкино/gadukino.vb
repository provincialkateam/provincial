$metka = $ARGS[0]
$loc = $CURLOC
if gadukino_blok = 1:gad_offense = 1
gs 'stat'
gs 'time'
$control_point = $curloc
gs 'zz_render', 'Деревня Гадюкино', func('zz_funcs','mk_image','qwest/gadukino/street'),'Маленькая деревушка с покосившимися деревянными избами.**В одной из изб живут ваши '+iif(gadukino_blok = 0,'<a href="exec:minut += 5 & GT ''Gaddvor''">дедушка и бабушка</a>','дедушка и бабушка')+'.'+iif(miraQW > 0,'**Через тройку домов находится дом <a href="exec:minut += 5 & GT ''MiroslavaHome''">Мирославы</a>.','')+'**В сезон в деревню приезжает передвижной '+iif(hour >= 9 and hour <= 11 and month >= 6 and month <= 9,'<a href="exec: gt ''gadukino_event'',''collection_point'' ">пункт</a>','пункт')+' заготовки грибов и ягод.'
if hour >= 17 and hour < 20 and mitkaday ! daystart:gs 'zz_render', '', '','Не далеко от избы шарахается <a href="exec:GT ''mitka''">Митька Шкворень</a>'
if hour >= 20 and sunWeather >= 0 and month >= 4 and month <= 10: gs 'zz_render', '', '','Не далеко от избы сидит компашка деревенской <a href="exec:miraingop = 0 & GT ''mitkabuh''">молодежи</a>'
if month >= 5 and month <= 9 and sunWeather >= 0 and hour > 14 and hour < 18 and (week = 6 or week = 7):gs 'zz_render', '', '','На лавочке, возле дома, сидит ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+' и сплетничает с подругами.'
if month >= 6 and month <= 8 and sunWeather >= 0 and hour > 7 and hour < 13 and graze_cow = 0 and week = 7:gs 'zz_render', '', '','Ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+' с мужиками собрались возде магазина магазина и явно что-то замышляют.'
if month >= 5 and month <= 9 and sunWeather >= 0 and hour > 13 and hour < 18 and graze_cow = 0 and week = 6:gs 'zz_render', '', '','Ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+' с компанией сидят на лавке и что-то обсуждают.'
gs 'car', 'check'
if _taxi_time >= 0: gs 'taxi','check'
if hour >= 8 and hour < 18: act 'Идти в магазин': minut += 5 & gt 'gadmarket'
if hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset') and sunWeather >= 0 and snow <= 0: act 'Гулять по деревне': gt 'gadukino_event', 'walk'
act 'Идти на речку':minut += 20 & gt'Gadriver'
act 'Идти за деревню':minut += 20 & gt'gadroad'
act 'Выйти на шоссе':minut += 30 & nroad = 20 & gt'road'
if onlooker = 1:onlooker = 0 & gt 'gadukino_event', 'gadukino_onlooker'
if current_clothing = 0:gt 'gadukino_event', 'gadukino_nude'
mitkarand = rand(1,3)
if mitka = 0 and hour >= 7 and hour < 20 or mitka = 1 and hour >= 17 and hour < 20 and mitkarand = 1 and mitkaday ! daystart and mitkasextimes < 13:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Митька Шкворень', 'gadukino/mitka/mitka.jpg','В деревне к вам подошел ваш давний знакомый Митька.'
	act 'Далее':gt 'mitka'
end
mitkarand = rand(1,20)
if gadriver_gang < 3:
	if mitkarand = 1 and mitkasextimes >= 13 and hour >= 7 and hour <= 16 and month >= 4 and month <= 10 and mitkaday ! daystart: gt 'gadukino_event', 'gadukino_mitka'
	if mitkarand = 2 and mitkasextimes >= 13 and hour >= 7 and hour <= 16 and month >= 4 and month <= 10 and kolyambaday ! daystart: gt 'gadukino_event', 'gadukino_kolyamba'
	if mitkarand = 3 and mitkasextimes >= 13 and hour >= 7 and hour <= 16 and month >= 4 and month <= 10 and vasyanday ! daystart: gt 'gadukino_event', 'gadukino_vasyan'
	if mitkarand = 4 and mitkasextimes > 15 and hour >= 17 and hour <= 19 and month >= 4 and month <= 10 and gadboyday ! daystart and week <= 5: gt 'gadukino_event', 'gadukino_2boys'
	if mitkarand <= 5 and mitkasextimes > 15 and hour >= 7 and hour <= 19 and month >= 4 and month <= 10 and gadboyday ! daystart and week > 5: gt 'gadukino_event', 'gadukino_2boys'
end
if gadriver_gang = 1 and hour >= 6 and hour <= 21 and gadboyday ! daystart: gt 'gadukino_event', 'gang_apologise'
if gadriver_gang = 3 and hour >= 6 and hour <= 21 and gadboyday ! daystart: gt 'gadukino_event', 'mitka_apologise'
if gadriver_gang = 4 and mirasex = 1 and miralick = 0 and hour >= 8 and hour <= 20 and gadboyday ! daystart: gt 'gadukino_event', 'mira_apologise'
if mitkasextimes > 13 and mirasex = 1 and miragopQW < 11 and mitkarand >= 15 and miraday ! day:gt 'Meadow_event','mira_lesb_talk4'