$metka = $ARGS[0]
$loc = $CURLOC
$control_point = $curloc
*clr & cla
gs 'stat'
gs 'time'
! people_check
gs 'beach','check_people'
gs 'zz_phone','boyfriend_call_init'
$_str = 'Озеро'
gs 'zz_render',$_str,func('zz_funcs','mk_image','images/pavlovo/glake/glake'+iif(lake_people = 0,'',lake_people)+'.jpg'),'Небольшое озеро, расположившееся недалеко от Павлово. Или это Павлово построили рядом с озером, кто знает.<br>'+iif(month < 3 or month > 10,'С приходом холодов, вода в озере замёрзла, и его превратили в каток. Теперь, любой желающий может покататься на коньках, если они есть конечно.',iif(hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset'),'',iif(lake_people = 0,'Сегодня '+iif(sunWeather >= 0,'погода не очень','идёт дождь')+', поэтому на пляже пустынно.','Сегодня '+iif(temper <= 25,'хорошая погода','солнце припекает во всю')+', '+iif(lake_people = 1,'но прохладно для купания и загара, только редкие парочки прогуливаются вдоль берега',iif(lake_people = 2,'но '+iif(week <= 5,'будний день, поэтому ','несмотря на выходной день ')+'людей на пляже немного',iif(lake_people = 3,iif(week > 5,'да к тому же еще и выходные,','')+' поэтому на пляже довольно людно','к тому же выходной день, поэтому на пляже не протолкнуться')))+'.')))
if lake_people > 1 and (hour = func('zz_weather','sunrise') or hour = func('zz_weather','sunrise')+ 1): gs 'zz_render', '', '','Люди постепенно стягиваются на пляж.'
if lake_people > 1 and (hour = func('zz_weather','sunset') or hour = func('zz_weather','sunset')- 1): gs 'zz_render', '', '','Люди постепенно расходятся по домам.'
! family check
gs 'zz_family', 'mother_sheduler'
gs 'zz_family', 'sister_sheduler'
if prev_clothing > 2: gs 'zz_render', '', '','На берегу лежит ваша одежда.'
if temper >= 20 and hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'):
	act 'Прогуляться по берегу': gt 'beach','walk'
	if current_clothing ! 2: act'Надеть купальник': gt 'beach','undress'
	if (current_clothing = 0 or current_clothing = 2):
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
if current_clothing < 3: act 'Одеться': gt 'beach','get_dressed'
!зима
if snow > 0:
	if hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'):
		if skates > 0 and skates_cloth ! 1: act'Надеть коньки':gt 'ice_rink','get_skates'
		if skates_cloth = 1: act'На каток': gt 'ice_rink','rink_start'
	end
	if skates_cloth = 1: act'Снять коньки':gt 'ice_rink','off_skates'
end
act 'На дикий пляж': minut += 60 & gt 'gLakeNude'
act 'Уйти в Павлово':
	if current_clothing < 3:
		'<b><font color = red>Вам нужно надеть свою одежду. Не прилично ходить по улицам раздетой.</font></b>'
	elseif skates_cloth = 1:
		'<b><font color = red>Вам нужно снять коньки. Как вы собираетесь в них ходить по улицам?</font></b>'
	else
		minut += 30
		gt 'gorodok'
		killvar '$_str'
	end
end
! --- meynold event --- !
gs 'mey_vika_events', 'beach_event1'