i = rand(1,3)
if $ARGS[0] = 'check_people':
	lake_people = 0
	!в зависимости от погоды или дня недели кол-во людей на пляже разное
	!t <+20C или идёт дождь - никого нет
	!пн-пт: до 17.00 практически никого нет, после 17.00 людей становится среднее кол-во
	!сб-вс: t +20+25Ct - среднее количество, >+25C - много народа на пляже
	if month > 4 and month < 10 and sunWeather >= 2 and hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'): lake_people = iif(temper < 20,1,iif(week <= 5,iif(hour < 17,2,3),iif(temper <= 25,3,4)))
	!с утра или к вечеру кол-во людей на пляже меняется
	if lake_people > 2 and (hour = func('zz_weather','sunrise') or hour = func('zz_weather','sunrise')+ 1 or hour = func('zz_weather','sunset') or hour = func('zz_weather','sunset')- 1): lake_people -= 1
end
if $ARGS[0] = 'walk':
	*clr & cla
	minut += 30
	manna += 5
	gs 'stat'
	gs 'zz_render', $_str, 'images/common/beach/walk_<<$loc>>'+iif(current_clothing > 2,'',iif(current_clothing = 2,'_swim','_nude'))+'.jpg','Вы гуляете по берегу, наслаждаясь свежим воздухом.'
	act 'Назад': gt $loc, $metka
	if $loc = 'lake' and rand(0,10) = 0: gt'lake_event','walklake'
end
if $ARGS[0] = 'undress':
	*clr & cla
	if args[1] = 1:
		if shameless['flag'] >= 1 or lake_people < 2:
			if horny >= 90:
				if shameless['flag'] > 1 or GorSlut > 2 or lake_people < 3:
					gt'beach','nude'
				else
					gs 'zz_render',$_str,'images/common/beach/wetpussy<<tanga>>.jpg','Вы хотите полностью раздеться, но понимаете, что все увидят влагу, сочащуюся из вашей писечки. От мысли, что всем это будет хорошо видно, вам становится не по себе и вы отказываетесь от этой идеи.**<dh>— Наверное стоит как-нибудь снять напряжение</dh>, — думаете вы.'
					act 'Назад': gt $loc, $metka
				end
			else
				gt'beach','nude'
			end
		else
			gs 'zz_render',$_str,'images/common/beach/shyness.jpg','У вас появляется желание раздеться полностью, но вы не можете побороть свою стеснительность.'
			act 'Назад': gt $loc, $metka
		end
	else
		if horny >= 90:
			if shameless['flag'] > 1 or GorSlut > 2 or lake_people < 3:
				gt 'beach','swimsuit'
			else
				gs 'zz_render',$_str,'images/common/beach/wetpussypants.jpg','Вы хотите переодеться в купальник, но понимаете, что ваша сочащаяся писечка тут же его намочит. От мысли, что люди могут это заметить, вам становится не по себе и вы отказываетесь от этой идеи.**<dh>— Наверное стоит как-нибудь снять напряжение</dh>, — думаете вы.'
				act 'Назад': gt $loc, $metka
			end
		else
			gt 'beach','swimsuit'
		end
	end
end
if $ARGS[0] = 'swimsuit':
	*clr & cla
	minut += 5
	if current_clothing > 0:flag_tanga = tanga
	gs 'zz_clothing', 'redress', 2
	gs 'stat'
	if $loc = 'gadbeach':
		inriver = 1
		gs 'zz_render', $_str, 'images/common/beach/swimsuit_<<$loc>>.jpg','Вы снимаете свою одежду, и надеваете купальник. Теперь можно спокойно идти купаться и загорать.'
	else
		gs 'zz_render', $_str, 'images/common/beach/swimsuit_<<$loc>>'+iif(shameless['flag'] < 2,shameless['flag'],2)+'.jpg',iif(shameless['flag'] = 0,'Вы заходите в '+iif($loc = 'lake','пляжную кабинку','ближайшие кустики')+' и переодеваетесь в купальник',iif(shameless['flag'] = 1,'Убедившись, что на вас никто не смотрит, вы быстренько переодеваетесь в купальник','Не обращая ни на кого внимания, на виду у всех'+iif($loc = 'lake',', прикрывшись только полотенцем,',',')+' вы переодеваетесь в купальник'))+'.<br>Теперь можно спокойно идти купаться и загорать.'
	end
	act 'Назад': gt $loc, $metka
end
if $ARGS[0] = 'nude':
	*clr & cla
	minut += 5
	if current_clothing ! 2: flag_tanga = tanga
	tanga = 0
	if $loc = 'gadbeach': inriver = 1
	gs 'zz_clothing', 'redress', 0
	gs 'stat'
	gs 'zz_render', $_str, 'images/common/beach/undress_<<$loc>>.jpg','Вы не стеснясь раздеваетесь, оставшись в чем мать родила.'+iif(horny >= 90 and lake_people > 2,' Проходящие мимо мужчины заинтересовано рассматривают вашу сочащуюся вагину. Но вам уже наплевать на то, что скажут или подумают о вас люди.','')
	act 'Назад': gt $loc, $metka
end
if $ARGS[0] = 'get_dressed':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_clothing', 'redress', prev_clothing
	tanga = flag_tanga
	prev_clothing = -1
	if $loc = 'gadbeach':
		gs 'zz_render', $_str, 'images/common/beach/'+iif(args[1] = 1,'dress','swimsuit')+'_<<$loc>>.jpg','Вы сняли купальник, и переодеваетесь в свою одежду.'
	else
		gs 'zz_render', $_str, 'images/common/beach/'+iif(args[1] = 1,'dress_<<$loc>>','swimsuit_<<$loc>>'+iif(shameless['flag'] < 2,shameless['flag'],2))+'.jpg', iif(shameless['flag'] = 0,'Вы заходите в '+iif($loc = 'lake','пляжную кабинку','ближайшие кустики')+' и переодеваетесь в свою одежду.',iif(shameless['flag'] = 1,'Убедившись, что на вас никто не смотрит, вы быстренько переодеваетесь в свою одежду','Не обращая ни на кого внимания, на виду у всех'+iif($loc = 'lake',', прикрывшись только полотенцем,',',')+' вы переодеваетесь в свою одежду.'))
	end
	act 'Назад': gt $loc, $metka
end
if $ARGS[0] = 'swim':
	*clr & cla
	minut += 30
	gs 'zz_bathroom', 'clean_me'
	if stren < 20: stren += 1
	horny -= iif(temper <= 25,10,5)
	manna += 10
	gs 'stat'
	if $loc = 'gadbeach'  and mirainriver = 1:
		gs 'zz_render', $_str, 'images/common/beach/swim_mira'+iif(current_clothing = 0,'_nude'+i,i)+'.jpg','Вы искупнулись в речушке, весело брызгаясь с Мирой, друг на дружку, водой.'
	else
		gs 'zz_render', $_str, 'images/common/beach/swim_<<$loc>>'+iif(current_clothing = 0,'_nude'+i,i)+'.jpg','Вы искупнулись в озере, вода освежает и бодрит.'
	end
	if $loc = 'glake'  and current_clothing = 0: manna -= 10 & gs 'zz_render','', '','Вы слышите как женщины вокруг вас шушукаются, что мол вон, гляди какая безстыжая <<$surname>>, совсем совесть потеряла, а мужики пристально разглядывают ваше обнаженное тело.'
	if $loc = 'glakenude' and lake_people > 1 and current_clothing = 2 and shameless['flag'] < 3: manna -= 10 & gs 'zz_render','', '','<b>Вы чувствуете себя неловко, будучи в купальнике, в окружении совершенно обнажённых людей.</b>'
	act 'Выйти из воды':
		if $loc = 'gadbeach': gs 'river_events','swim_guys'
		gt $loc, $metka
	end
end
if $ARGS[0] = 'sunbathe':
	*clr & cla
	minut += 30
	manna += iif(current_clothing > 0,5,10)
	sweat += iif(temper < 22,0,iif(temper < 30,1,2))
	hapri = 1
	if sunWeather < 2:
		tan += iif(current_clothing > 0,iif($args[1] = 'cream',1,rand(0,1)),iif($args[1] = 'cream',2,1))
	else
		tan += iif(current_clothing > 0,iif($args[1] = 'cream',2,1),iif($args[1] = 'cream',4,3))
	end
	i = iif($args[1] = 'cream',rand(4,6),rand(1,3))
	gs 'stat'
	if $loc = 'gadbeach' and mirainriver = 1:
		gs 'zz_render', $_str, 'images/common/beach/sunbathe_mira'+iif(current_clothing = 0,'_nude','')+rand(1,3)+'.jpg','Вы лежите рядом с Мирой на песке и болтая о пустяках, '+iif(sunWeather >= 2,'млеете на солнце.','загораете. На небе облачно, поэтому загар не очень.')
	else
		gs 'zz_render', $_str, 'images/common/beach/sunbathe_<<$loc>>'+iif(current_clothing = 0,'_nude'+i,i)+'.jpg','Вы загораете на пляже'+iif(sunWeather >= 2,', нежась в лучах солнца.','. На небе облачно, поэтому загар не очень.')
	end
	if $loc = 'glake'  and current_clothing = 0: manna -= 10 & gs 'zz_render','', '','Вы слышите как женщины вокруг вас шушукаются, что мол вон, гляди какая безстыжая <<$surname>>, совсем совесть потеряла, а мужики пристально разглядывают ваше обнаженное тело.'
	if $loc = 'gLakeNude' and lake_people > 1 and current_clothing = 2 and shameless['flag'] < 3: manna -= 10 & gs 'zz_render','', '','<b>Вы чувствуете себя неловко, будучи в купальнике, в окружении совершенно обнажённых людей.</b>'
	if $loc = 'gLakeNude' and lake_people > 1: gs'glake_events','voyeurism_start'
	act 'Далее':
		if $loc = 'lake': gs'lake_event','din_lake_adventure'
		if $loc = 'nudelake': gs'lake_event','din_nudelake_adventure'
		if $loc = 'glake': gs'glake_events','din_beach_adventure'
		if $loc = 'gadbeach': gs 'river_events','sunbathe_guys'
		gt $loc, $metka
	end
end
if $ARGS[0] = 'cream':
	*clr & cla
	minut += 5
	krem -= 1
	horny += iif(current_clothing > 0,5,10)
	gs 'stat'
	gs 'zz_render', $_str, 'images/common/beach/cream'+iif(current_clothing = 0,'_nude'+iif(lake_people <= 2 or $loc = 'gadbeach',1,iif(lake_people = 3,2,3)),i)+'.jpg','Вы намазали тело кремом для загара.'
	act 'Загорать полчаса': gt 'beach','sunbathe','cream'
end