$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
lake_people = iif(mirainriver = 1 and miratalkforest < 3,2,0)
i = rand(0,10)
gs 'stat'
gs 'time'
$_str = 'Деревенский пляж'
gs 'zz_render',$_str, func('zz_funcs','mk_image','images/gadukino/river/gadbeach.jpg'), 'Небольшой деревенский пляж, на котором можно худо-бедно позагорать и искупаться.'
if cloth[3] > 2: gs 'zz_render', '', '','На берегу лежит ваша одежда.'
if mirainriver = 1: gs 'zz_render','', '','На пляже вы видите <a href="exec: gt ''Miroslava''">Миру</a>.'
if horse_river > 0: gs 'zz_render','', '','В реке стоит дедушкин конь <a href="exec: gt ''river_events'',''horse_river'' ">Буян</a>.'
if temper >= 20 and func('zz_weather','is_day')=1:
	if mirainriver = 0 and mitkasextimes >= 13 and temp = 0 and sunWeather >= 0 and guysriver ! day: gt 'river_events','guys_beach'
	if cloth[0] ! 2: act'Надеть купальник': gt 'beach','undress'
	if cloth[0] > 0: act'Раздеться догола': gt 'beach','undress',1
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
if cloth[0] < 3: act 'Одеться': gt 'beach','get_dressed',iif(cloth[0] = 0,1,0)
act 'Уйти':
	if cloth[0] > 2 or (cloth[0] = 0 and exhibi > 0):
		killvar '$_str'
		minut += 5
		inriver = 0
		gt'Gadriver'
	else
		gs 'zz_render','','','<b><font color = red>Вы не можете появиться в деревне в таком виде, нужно одеться.</font></b>'
	end
end
! Мира на речке
gs 'river_events','mira_in_river'