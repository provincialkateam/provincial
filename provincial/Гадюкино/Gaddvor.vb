$metka = $ARGS[0]
$loc = $CURLOC
grandpa_ingaddvor = 0
gs 'stat'
gs 'time'
gs 'zz_render', 'Двор', func('zz_funcs','mk_image','qwest/gadukino/dvor'),'Двор с садом, избой и хозпостройками огорожен изгородью.'
if wetbelo > 0: gs 'zz_render', '', '','<b>На бельевой веревке сушится <<wetbelo>> единиц белья.</b>'
if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset') and month >= 4 and month <= 10:'По двору ходят <a href="exec: gt ''grandparents_events'',''chickens'' ">куры</a>'
if mira_guest = 1:gs 'zz_render', '', '','Во дворе, рядом с вами, стоит <a href="exec: gt ''Miroslava''">Мира</a>.'
if month > 5 and month < 9 and sunWeather >= 0 and hour > 7 and hour < 13 and graze_cow = 0 and (week = 1 or week = 3 or week = 5):grandpa_ingaddvor = 1 & gs 'zz_render', '', '','Во дворе работает ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+'.'
if month > 5 and month < 9 and sunWeather >= 0 and hour > 13 and hour < 18 and graze_cow = 0 and (week = 2 or week = 4):grandpa_ingaddvor = 1 & gs 'zz_render', '', '','Во дворе работает ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+'.'
act 'Идти в избу': minut += 5 & gt 'Gadhouse'
act 'Идти в сарай': minut += 5 & gt 'Gadsarai'
act 'Идти в баню': minut += 5 & gt 'Gadbana'
act 'Идти на огород': minut += 5 & gt 'Gadgarden', 'garden'
if meadow > 0 and hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset') and snow <= 0 and mira_guest = 0:act 'Иди на поляну':minut += 20 & gt'Meadow'
if current_clothing > 2:act '<b>Идти в деревню</b>':mira_guest = 0 & minut += 5 & gt 'gadukino'
if fishers_nude = 8 and hour >= 18 and hour <= 21 or gadukino_nude > 8 and hour >= 6 and hour <= 21:gt 'gadukino_event', 'gadriver_nude_end'
if onlooker_man = 1 and hour >= 6 and hour <= 21:gt 'gadukino_event', 'gadukino_onlooker_man'
mira_temp = rand(1,5)
if mira_temp = 3 and hour >= 9 and hour <= 19 and miraQW >= 15 and Mira_no = 0 and mira_guest = 0 and sunWeather >= 0 and mira_guestday ! daystart and (mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1):gt 'grandparents_events','mira_courtyard'
if current_clothing = 0: gt 'grandparents_events','courtyard_nude'