$metka = $ARGS[0]
$loc = $CURLOC
$control_point = $curloc
*clr & cla
gs 'stat'
gs 'time'
! people_check
gs 'beach','check_people'
$_str = 'Нудистский пляж'
gs 'zz_render',$_str,func('zz_funcs','mk_image','images/city/south/lake/nudelake'+iif(lake_people = 0,'',lake_people)+'.jpg'),'Часть пляжа, которую облюбовали любители ровного загара. В хорошую погоду здесь можно ходить голышом, и никто вас не осудит.<br>'+iif(month < 3 or month > 10,'С приходом зимы делать здесь обсолютно нечего.',iif(hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset'),'',iif(lake_people = 0,'Сегодня '+iif(sunWeather >= 0,'погода не очень','идёт дождь')+', поэтому на пляже пустынно','Сегодня '+iif(temper <= 25,'хорошая погода','солнце припекает во всю')+', '+iif(lake_people = 1,'но прохладно для купания и загара, только редкие парочки прогуливаются вдоль берега',iif(lake_people = 2,'но '+iif(week <= 5,'будний день, поэтому ','несмотря на выходной день ')+'людей на пляже немного',iif(lake_people = 3,iif(week > 5,'да к тому же еще и выходные,','')+' поэтому на пляже довольно людно','к тому же выходной день, поэтому на пляже не протолкнуться')))+'.')))
if temper >= 20 and sunWeather > 1 and current_clothing = 0 and hour > func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):gs 'zz_render', '', '','А ещё можно сыграть в <a href="exec:gt''lake_event'',''voleybol_nude''">пляжный волейбол</a>'
if lake_people > 2 and (hour = func('zz_weather','sunrise') or hour = func('zz_weather','sunrise')+ 1): gs 'zz_render', '', '','Люди постепенно стягиваются на пляж.'
if lake_people > 2 and (hour = func('zz_weather','sunset') or hour = func('zz_weather','sunset')- 1): gs 'zz_render', '', '','Люди постепенно расходятся по домам.'
if prev_clothing > 2: gs 'zz_render', '', '','На берегу лежит ваша одежда.'
if katday ! day and $npc['33,relation'] > 40 and current_clothing = 0 and lake_people > 2: gs 'zz_render', '', '','На пляже загорает <a href="exec: gt''Katlake'',''kat''">Кэт</a>.'
if anutaday ! day and anutaQW = 2 and current_clothing = 0 and lake_people > 2: gs 'zz_render', '', '','Вы видите '+iif(anuta['horny'] < 70,'загорающую на пляже','бредущую по пляжу, подвыпившую')+' <a href="exec: gt''anuta''">Анюту</a>.'
if temper >= 20 and hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'):
	if current_clothing ! 2: act 'Надеть купальник': gt 'beach','undress'
	if current_clothing > 0: act'Раздеться догола': gt 'beach','undress',1
	if current_clothing = 0 or current_clothing = 2:
		act 'Купаться полчаса': gt 'beach','swim'
		if sunWeather >= 0:
			if krem <= 0:
				act 'Загорать полчаса': gt 'beach','sunbathe'
			else
				act 'Намазаться кремом и лечь загорать': gt 'beach','cream'
			end
			if reading['in_bag'] >= 0: act 'Читать '+func('zz_books','get_name',reading['in_bag']): gt 'zz_books','read_on_walk'
		end
	end
end
if current_clothing < 3: act 'Одеться': gt 'beach','get_dressed',iif(current_clothing = 0,1,0)
act 'Уйти':
	if current_clothing > 0 or (current_clothing = 0 and exhibi > 0):
		minut += 20
		gt 'lake'
	else
		'<b><font color = red>Вы не можете разгуливать голышом среди такого количества людей.</font></b>'
	end
end