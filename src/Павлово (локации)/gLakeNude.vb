$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs 'stat'
gs 'time'
! people_check
gs 'beach','check_people'
gs 'zz_phone','boyfriend_call_init'
$_str = 'Дикий пляж'
gs 'zz_render',$_str,func('zz_funcs','mk_image','images/pavlovo/glake/glakenude'+iif(lake_people = 0,'',lake_people)+'.jpg'),'Дикий пляж находится поодаль от городского и до него нужно довольно долго топать по берегу по тропинкам через заросли. На этом пляже частенько можно встретить любителей загорать и купаться голышом, как местных, так и даже приезжают из города.**'+iif(month < 3 or month > 10,'С приходом зимы делать здесь обсолютно нечего.',iif(hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset'),'',iif(lake_people = 0,'Сегодня '+iif(sunWeather >= 0,'погода не очень','идёт дождь')+', поэтому на пляже пустынно.','Сегодня '+iif(temper <= 25,'хорошая погода','солнце припекает во всю')+', '+iif(lake_people = 1,'но прохладно для купания и загара, поэтому на пляже никого нет',iif(lake_people = 2,'но '+iif(week <= 5,'будний день, поэтому ','несмотря на выходной день ')+'на пляже виднеется всего несколько человек',iif(lake_people = 3,iif(week > 5,'да к тому же еще и выходные,','')+' поэтому на пляже довольно людно','к тому же выходной день, поэтому на пляже собралось большое количество людей')))+'.')))
if lake_people > 1 and (hour = func('zz_weather','sunrise') or hour = func('zz_weather','sunrise')+ 1): gs 'zz_render', '', '','Люди постепенно стягиваются на пляж.'
if lake_people > 1 and (hour = func('zz_weather','sunset') or hour = func('zz_weather','sunset')- 1): gs 'zz_render', '', '','Люди постепенно расходятся по домам.'
if lake_people > 2 and cloth[0] > 0 and shameless['flag'] = 0: manna -= 10 & gs 'zz_render','', '', '<b>Вы чувствуете себя неловко, будучи в '+iif(cloth[0] = 2,'купальнике','одежде')+', в окружении совершенно обнажённых людей.</b'
if temper >= 20 and func('zz_weather','is_day') = 1:
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
	if lake_people > 2:
		if cloth[0] < 3 and horny >= 90 and shameless['flag'] < 2: manna -= 20 & '<b><font color = red>Вы очень возбудились. Боясь пошевелиться, вы прикрыли cво'+iif(cloth[0] = 0,'ю влажную писечку','и мокрые трусики')+' рукой, надеясь что никто не обратит на это внимание. Единственное ваше желание сейчас (помимо желания кончить): побыстрее одеться, чтобы никто, ничего не заметил.</font></b>'
		if voyeurism >= 40 and voyeurism_start = 2:
			gs 'zz_render','', '','<b>Вы видите как некоторые девушки иногда покидают пляж, чтобы сходить в лес по нужде. У вас возникает шальная мысль тоже прогуляться в лес, чтобы подглядеть за ними.</b'
			act iif(voyeurism_forest = 0,'Пойти в лес','Спрятаться в лесу у пляжа'): minut +=5 & gt 'gLakeNudeForest'
		end
	end
end
if cloth[0] < 3: act 'Одеться': gt 'beach','get_dressed',iif(cloth[0] = 0,1,0)
act 'Уйти':
	if cloth[0] > 0 or (cloth[0] = 0 and exhibi > 0):
		minut += 8
		gt 'glake'
		killvar '$_str'
	else
		gs 'zz_render','','','<red>Вы не можете разгуливать голышом среди такого количества людей.</red>'
	end
end