$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs 'stat'
gs 'time'
! people_check
gs 'beach','check_people'
gs 'zz_render','Озеро',func('zz_funcs','mk_image','images/city/south/lake/lake'+iif(lake_people = 0,'',lake_people)+'.jpg'),'Большое озеро находящееся в черте города является излюбленным местом отдыха жителей в летнее время.**'+iif(month < 3 or month > 10,'С приходом зимы делать здесь обсолютно нечего.',iif(hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset'),'',iif(lake_people = 0,'Сегодня '+iif(sunWeather >= 0,'погода не очень','идёт дождь')+', поэтому на пляже пустынно.','Сегодня '+iif(temper <= 25,'хорошая погода','солнце припекает во всю')+', '+iif(lake_people = 1,'но прохладно для купания и загара, только редкие парочки прогуливаются вдоль берега',iif(lake_people = 2,'но '+iif(week <= 5,'будний день, поэтому ','несмотря на выходной день ')+'людей на пляже немного',iif(lake_people = 3,iif(week > 5,'да к тому же еще и выходные,','')+' поэтому на пляже довольно людно','к тому же выходной день, поэтому на пляже не протолкнуться')))+'.')))
if lake_people > 1 and (hour = func('zz_weather','sunrise') or hour = func('zz_weather','sunrise')+ 1): gs 'zz_render', '', '','Люди постепенно стягиваются на пляж.'
if lake_people > 1 and (hour = func('zz_weather','sunset') or hour = func('zz_weather','sunset')- 1): gs 'zz_render', '', '','Люди постепенно расходятся по домам.'
gs 'car', 'check'
if $npc['0,qwNastya'] = 3 and temper >= 20 and hour >= 6 and hour <= 20: gs 'zz_render', '', '','Вам приветственно машет рукой <a href="exec:gt''nastja'',''pos14''">Настя</a>.'
if temper >= 20 and func('zz_weather','is_day') = 1:
	if sunWeather > 1 and (cloth[0] = 0 or cloth[0] = 2):
		gs 'zz_render', '', '','Здесь можно сыграть в <a href="exec:gt''lake_event'',''voleybol''">пляжный волейбол</a>**Рядом есть <a href="exec:gt''lake_event'',''aquapark''">водные аттракционы</a>.**А ещё можно <a href="exec:gt''lake_event'',''horse''">прокатиться на лошади</a>'
	else
		gs 'zz_render', '', '','Здесь можно сыграть в пляжный волейбол.**Рядом есть водные аттракционы.**А ещё можно прокатиться на лошади.'
	end
	gs 'zz_render', '', '','И в паре километров есть даже <a href="exec:minut += 20 & gt''nudelake''">нудистский пляж</a>'
	act 'Прогуляться по берегу': gt 'beach','walk'
	if cloth[0] ! 2: act'Надеть купальник': gt 'beach','undress'
	if (cloth[0] = 0 or cloth[0] = 2):
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
if cloth[0] < 3: act 'Одеться': gt 'beach','get_dressed'
act 'Уйти с пляжа':
	if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
	minut += 20
	gt 'south'
	killvar '$_str'
end