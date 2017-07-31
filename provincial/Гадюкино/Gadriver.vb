$metka = $ARGS[0]
$loc = $CURLOC
i = rand(0,20)
if i > 10 and month >= 5 and month <= 9 and sunWeather >= 0: fishers = 1
gs'stat'
gs'time'
$_str = 'Речка Змеявка'
gs 'zz_render',$_str, func('zz_funcs','mk_image','images/gadukino/river/gadriver.jpg'), 'Небольшая деревенская речушка, протекающая совсем рядом от Гадюкино.'
if fishers = 1 and hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):'На берегу раскинули свои удочки местные <a href="exec: gt ''river_events'',''fishers'' ">рыбаки</a>.'
if i <= 5 and hour <= 8 and month >= 5 and month <= 9 and miragopQW >= 20:'Прямо возле тропинки, ведущей к речке, стоит совершенно голая <a href="exec: gt ''river_events'',''mira_punish'' ">Мира</a>, распятая между двумя деревьями...'
if current_clothing = 0:gt 'gadukino_event', 'gadriver_nude'
if mitkasextimes = 20 and hour > func('zz_weather','sunrise') and hour < func('zz_weather','sunset') and month >= 5 and month <= 9 and sunWeather >= 0 and temper >= 20:gt 'gadukino_event', 'gadriver_gang'
if i <= 5 and mirainriver = 0 and mitkasextimes >= 13 and hour > 8 and hour < 20 and dom < 0 and guysriver ! day: gt 'river_events','guys_river'
act 'На пляж':minut += 5 & gt 'gadbeach'
act 'В деревню':
	killvar '$_str'
	minut += 10
	mirainriver = 0
	gt'gadukino'
end