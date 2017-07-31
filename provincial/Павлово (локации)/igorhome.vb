if $ARGS[0] = 'igorkom':
	*clr & cla
	frost = 0
	minut += 1
	bonusZ = 0
	gs 'zz_funcs', 'colorize_day'
	minut += 5
	gs 'stat'
	gs 'zz_render','Комната Игоря','images/qwest/alter/kruglov/kom.jpg'
	if hour >= 15:
		gs 'zz_render', '', '', 'Вы видите <a href="exec:GT ''igor''">Игоря</a>.'+iif($npc['4,mishka'] > 0,'**На кровате лежит плюшевый мишка, с сердечком в руках.','')
		act 'Выйти':gt 'igorHome','kor'
	else
		gs 'zz_render', '', '', 'Вы посмотрели на часы и поняли, что вам пора домой.'
		act 'Попрощаться и идти домой': gt 'gorodok'
	end
end
if $ARGS[0] = 'kor':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','Прихожая','images/qwest/alter/kruglov/kor.jpg',''
	act 'В комнату Игоря': gt 'igorhome','igorkom'
	act 'В ванную': gt 'igorhome','vann'
	act 'Уйти': gt 'gorodok'
end
if $ARGS[0] = 'vann':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	gs 'stat'
	gs 'zz_render','Ванная','images/qwest/alter/kruglov/vann.jpg','Ванная комната. Здесь вы можете принять душ.**На стене висит <a href="exec:GT ''mirror'',''start''">зеркало</a>.'
	act 'Принять душ (15 мин)':
		*clr & cla
		minut += 15
		gs 'zz_bathroom', 'clean_me'
		gs 'stat'
		gs 'zz_render','Ванная','images/qwest/alter/kruglov/mitsa.gif','Вы приняли душ.'
		act 'Выйти': gt 'igorhome','vann'
	end
	act 'Умыться (5 мин)':
	    *clr & cla
	    minut += 5
	    mop = 1
	    cumlip = 0
	    cumface = 0
	    face_write = 0
	    sweat -= 1
	    gs 'stat'
	    gs 'zz_render', '', 'images/pic/facesp.jpg','Вы тщательно умыли лицо.'
	    act 'Далее': gt 'igorhome','vann'
	end
	if analplug = 1 and analplugin = 1:
		act 'Вынуть анальную пробку (1 мин)':
			*clr & cla
			minut += 1
			analplugIN = 0
			gs 'stat'
			gs 'zz_render', '','images/pic/analplug.jpg',iif( anus >= 5,'Вы наклонились и привычным движением вынули из себя анальную пробку.','Вы поднатужились и, закусив губу, с громким чпоком вынули из ануса пробку.')
			act 'Закончить': gt 'igorhome','vann'
		end
	elseif analplug = 1 and analplugin = 0:
		act 'Вставить анальную пробку (5 мин)':
			*clr & cla
			minut += 5
			analplugIN = 1
			if anus < 10: anus += 1
			cumanus = 0
			gs 'stat'
			gs 'zz_render', '','images/pic/analplug.jpg', iif( anus >= 5,'Вы наклонились и привычным движением вставили себе анальную пробку.','Вы постарались как можно сильнее расслабить попу и стали вставлять себе пробку. Закусив губу от чувства, что ваша попа вот вот лопнет, вы аккуратно протолкнули толстую часть в свою попу, и наконец-то пробка встала на место.')
			act 'Закончить': gt 'igorhome','vann'
		end
	end
	act 'Выйти': gt 'igorhome', 'kor'
end