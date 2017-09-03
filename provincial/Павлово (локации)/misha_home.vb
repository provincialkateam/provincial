gs 'mixa_event','48,check'
gs 'mixa_event','38,check'
if $ARGS[0] = 'corridor':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	frost = 0
	gs 'zz_funcs', 'colorize_day'
	minut += 1
	gs 'stat'
	gs 'zz_render','Прихожая','pavlovo/family/insrct/home/korr.jpg','На стене висит большое <a href="exec:GT ''mirror'',''start''">зеркало</a>'
	act 'В комнату': gt 'misha_home','room'
	act 'На кухню': gt 'misha_home','kitchen'
	act 'В ванную': gt 'misha_home','bathroom'
	act 'Уйти': gt 'gorodok'
end
if $ARGS[0] = 'room':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 1
	gs 'stat'
	gs 'zz_render','Комната','pavlovo/family/insrct/home/bedr.jpg','Комната в которой есть <a href="exec:GT ''divan'',''start''">диванчик</a>, и <a href="exec: gt ''TV'',''start''">телевизор</a> напротив него.'
	if $npc['38,wedding'] < 3 :
		if $npc['48,home'] = 1: gs 'zz_render', '','','На диване сидит <a href="exec: gt ''misha''">Мишка</a> и смотрит телевизор'
	else
		$sister['location'] = 'room'
	end
	if $npc['38,wedding'] < 3 :
		if $npc['48,sleep'] = 1: gs 'zz_render', '','','На диване спит <a href="exec: gt ''misha''">Мишка</a>'
	else
		$sister['location'] = 'room'
	end
	if week = 7 and hour >= 14 and hour <= 21: act'Убраться' : gs 'zz_render', '','pavlovo/park/banda/home/uborka.jpg','Вы решили прибратся в комнате Михаила по они с Колькой пошли в магазин.'
	act 'В коридор':gt 'misha_home','corridor'
end
if $ARGS[0] = 'kitchen':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 1
	gs 'stat'
	gs 'zz_render','Комната','pavlovo/family/insrct/home/kuhr.jpg'
	gs 'zz_kitchen_acts', 'all'
	if $npc['38,wedding'] < 3 :
		if $npc['48,eat'] = 1: gs 'zz_render', '','','За столом сидит <a href="exec: gt ''misha''">Мишка</a>'
	else
		 $sister['location'] = 'kitchen'
		 $npc['48,eat'] = 1
	end
	act 'В коридор':gt 'misha_home','corridor'
end
if $ARGS[0] = 'bathroom':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 1
	gs 'stat'
	gs 'zz_render','Ванная','pavlovo/family/insrct/home/bath.jpg','Ванная комната. Здесь вы можете принять душ или ванну.**На стене висит <a href="exec:GT ''mirror'',''start''">зеркало</a>.'
	if prev_clothing > 2 : gs 'zz_render', '','','Рядом с раковиной акуратно сложена ваша <a href="exec: gs ''misha_home'',''dress''">одежда</a>'
	if $npc['38,wedding'] < 3 :
		if $npc['48,bath'] = 1: gs 'zz_render', '','','В ванной <a href="exec: gt ''misha''">Мишка</a> принимает душь'
	else
		$sister['location'] = 'bathroom'
	end
	if $npc['48,bath'] = 0:
		act 'Принять душ (15 мин)':
			*clr & cla
			horny += 1
			manna += 5
			gs 'zz_bathroom', 'shower'
			if current_clothing > 0:
				flag_tanga = tanga
				gs 'zz_clothing', 'redress', 0
			end
			tanga = 0
			gs 'zz_clothing', 'redress', 0
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/insrct/home/dush.jpg','Вы залезли в душ и начали намыливать свое тело мочалкой. После смыли мыло и помыли волосы шампунем. Смыв шампунь вы стали совершенно чистой.'
			act 'Вытираться': gt 'misha_home','bathroom'
		end
		act 'Мыться в ванной 1 час':
			*clr & cla
			minut += 45
			manna += 10
			if skinday ! daystart: skinday = daystart & gs 'zz_funcs', 'skin', '+', 3
			if current_clothing > 0:
				flag_tanga = tanga
				gs 'zz_clothing', 'redress', 0
			end
			tanga = 0
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/insrct/home/van.jpg','Включив воду, вы залезли в ванную и легли в теплую воду. Понаслаждавшись приятным теплом вы намылили свое тело мочалкой и волосы шампунем. Затем вы все смыли водой.'
			act 'Закончить': gt 'zz_bathroom', 'start'
			if horny >= 60:act 'Мастурбировать':gt 'selfplay'
		end
		act 'Умыться (5 мин)':
			*clr & cla
			minut += 5
			mop = 1
			cumlip = 0
			cumface = 0
			sweat -= 1
			gs 'stat'
			gs 'zz_render', '', 'images/pic/facesp.jpg','Вы тщательно умыли лицо.'
			act 'Далее': gt 'misha_home','bathroom'
		end
		if leghair > 0 and stanok > 0:
			act 'Брить ноги 15 мин':
				*clr & cla
				minut += 15
				leghair = -5
				horny += 5
				stanok -= 1
				gs 'stat'
				gs 'zz_render', '','images/pics/shave.gif','Вы намылили свои ноги и взяли бритву. Ловкими движениями вы сбрили волосы на ногах и смыли пенку для бритья.'
				act 'Отложить станок': gt 'misha_home','bathroom'
			end
		end
		if lobok > 0 and stanok > 0:
			act 'Брить лобок 15 мин':
				*clr & cla
				minut += 15
				lobok = -5
				horny += 5
				stanok -= 1
				if obdysh = 1 and obbritinvent = 0:
					britrand = RAND(0,5)
					if britrand = 5: gt'zz_bathroom','brit1'
				end
				gs 'stat'
				gs 'zz_render', '','images/pics/shave3.gif','Вы намылили лобок и взяв бритву, ловкими движениями начали брить лобок и сбривать волоски вокруг киски. Наконец с бритьем было покончено и вы смыли пенку с киски.'
				act 'Отложить станок': gt 'misha_home','bathroom'
			end
		end
		if analplug = 1 and analplugin = 1:
			act 'Вынуть анальную пробку (1 мин)':
				*clr & cla
				minut += 1
				analplugIN = 0
				gs 'stat'
				gs 'zz_render', '','images/pic/analplug.jpg',iif( anus >= 5,'Вы наклонились и привычным движением вынули из себя анальную пробку.','Вы поднатужились и, закусив губу, с громким чпоком вынули из ануса пробку.')
				act 'Закончить': gt 'misha_home','bathroom'
			end
		elseif analplug = 1 and analplugin = 0 and klismaday = day:
			act 'Вставить анальную пробку (5 мин)':
				*clr & cla
				minut += 5
				analplugIN = 1
				if anus < 10: anus += 1
				cumanus = 0
				gs 'stat'
				gs 'zz_render', '','images/pic/analplug.jpg', iif( anus >= 5,'Вы наклонились и привычным движением вставили себе анальную пробку.','Вы постарались как можно сильнее расслабить попу и стали вставлять себе пробку. Закусив губу от чувства, что ваша попа вот вот лопнет, вы аккуратно протолкнули толстую часть в свою попу, и наконец-то пробка встала на место.')
				act 'Закончить': gt 'misha_home','bathroom'
			end
		end
		if vibrator = 1 and vibratorIN = 0:
			act 'Вставить вибратор 5 мин':
				*clr & cla
				minut += 5
				vibratorIN = 1
				if vagina < 6: vagina += 1
				gs 'stat'
				gs 'zz_render', '','images/pic/vibrator.jpg','Вы наклонились и вставили себе вибратор в киску.'
				act 'Закончить': gt 'misha_home','bathroom'
			end
		elseif vibrator = 1 and vibratorIN = 1 and vagina > 0:
			act 'Вынуть вибратор 5 мин':
				*clr & cla
				minut += 5
				vibratorIN = 0
				gs 'zz_render', '','images/pic/vibrator.jpg','Вы наклонились и вынули вибратор из влагалища.'
				act 'Закончить': gt 'misha_home','bathroom'
			end
		end
		if tanga = 1:
			act 'Снять нижнее белье':
				cla
				tanga = 0
				gs 'zz_render', '','','Вы сняли трусики.'
				gt 'misha_home','bathroom'
			end
		end
		if tanga = 0:
			act 'Одеть нижнее белье':
				cla
				tanga = 1
				gs 'zz_render', '','','Вы одели трусики.'
				gt 'misha_home','bathroom'
			end
		end
		act 'Выйти': gt 'misha_home', 'corridor'
	end
	if $args[0] = 'dress':
		if prev_clothing < 0: prev_clothing = 0
		gs 'zz_clothing', 'redress', prev_clothing
		prev_clothing = -1
		gt $loc, $metka
	end
end