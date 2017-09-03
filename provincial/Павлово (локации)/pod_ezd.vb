!НАСТРОЙКИ:
gs 'zz_funcs','colorize_day'
$metka = $ARGS[0]
$loc = $CURLOC
!подгружаем динамику которая в "gopsex"
gs'gopsex'
!лифт не работает
if liftnotwork_day ! daystart: liftnotwork_count = 1
!Квартира тети Любы (Олу)
if oluuosegunday_day ! daystart: oluuosegunday_count = 1
!Квартира дяди Миши
if mishahouse_day ! daystart: mishahouse_count = 1
!================================================================================================!
!ЭТАЖИ: ---------------------------Подъезд в городке-------------------------------------- ЭТАЖИ:!
!================================================================================================!
!!подъезд в Павлово, этаж 1
if $ARGS[0] = 'etaj_1':
	*clr & cla
	frost = 0
	minut += 1
	gs 'stat'
	i = func('zz_common','check_inhome')
	$_str = 'Обычный подъезд, такой же как и любой другой в Павлово.'
	$_str += '<br>В одном подъезде с вами живут несколько ваших одноклассников: ботаны '+iif(BeInNatBelHome=1 and i=1,'<a href="exec:gt''NatBelHome''">Наташа Белова</a>','Наташа Белова')+', '+iif(BeInJulMilHome = 1 and i=1,'<a href="exec:gt''JuliaMilHome''">Юля Милова</a>','Юля Милова')+' и '+iif(ArtomBeInHome > 0 and artemblok = 0 and i=1,'<a href="exec:gt''artemhome''">Артем Чеботарев</a>','Артем Чеботарев')+'. На <a href="exec:gt''pod_ezd'',''etaj_3''">третьем этаже</a> живёт давнишний ваш приятель Васька Шульгин.'
	$_str += '<br>На <a href="exec:gt''pod_ezd'', ''etaj_4''">четвёртом этаже</a> живёт сестра вашей мамы, тётя Люда. Она работает фармацевтом в аптеке.<br>Напротив вас, <a href="exec:gt''pod_ezd'', ''etaj_2''">на втором этаже</a>, живёт дядя Миша. Он тихий и незаметный и лишь иногда выходит покурить на лестничную площадку.'
	gs 'zz_render','Подъезд','images/pavlovo/home/floor1.jpg',$_str
	gs 'pavlovo_events','front_door_events', 1
	killvar '$_str'
	act 'Доска объявлений': gt 'pod_ezd','board'
	act 'Подняться по леснице на второй этаж': gt 'pod_ezd','etaj_2'
	act '<b>Выйти на улицу</b>': minut += 5 & gt 'gorodok'
end
! Доска объявлений
if $args[0] = 'board':
	*clr & cla
	$_str = '<b>Кафе DelParco</b> приглашает симпатичных комуникабельных девушек на работу официантки. Рабочее время: 15.00-21.00. Оплата посменно: 300р. + чаевые.'
	$_str += '**В <b>отель "Мимоза"</b> требуются приличные девушки на работу горничными. Оплата: 300р. за смену.'
	$_str += '**В <b>поликлинику</b> требуется уборщица. Оплата: 100р. за смену.'
	$_str += '**На <b>железнодорожный вокзал</b> требуется уборщица. Оплата: 250р. за смену.'
	$_str += '**<b>Швейной фабрике им.Парижской коммуны</b> требуются: технолог производства, швеи, упаковщики, разнорабочие.'
	$_str += '**<b>Дом культуры им.Ленина</b> приглашает всех желающих! Вас ждут спортивные и танцевальные секции, кружок шитья и большая библиотека. А по вечерам - Дискотека!'
	gs 'zz_render','','pavlovo/home/events/ad'+rand(1,2),$_str
	act 'Отойти': gt 'pod_ezd','etaj_1'
end
!---
if $ARGS[0] = 'etaj_2':
	*clr & cla
	minut +=1
	gs 'stat'
	gs 'zz_render', '<B>Этаж #2</B>', 'images/pavlovo/home/floor2'+iif(pod_whore_countQW <= 15,'','_whore')+'.jpg', 'Чистый и ухоженный этаж. Не так давно сделан ремонт, соседи следят за чистотой'+iif(pod_whore_countQW <= 15,'.',', но уже кто-то успел расписать стену. Её можно <a href="exec: gt ''pavlovo_events'',''pod_objava''">закрасить</a>.')
	gs 'pavlovo_events','front_door_events', 2
	act 'Подняться на третий этаж': gt'pod_ezd','etaj_3'
	act 'Спуститься на первый этаж': gt'pod_ezd','etaj_1'
	if ParHomeBlock = 0: act '<font color = maroon>Ваша квартира</font>':gt'korrPar'
	act 'Квартира дяди Миши':
		if hour < 5: gs 'zz_render', '', '','Слишком позднее время, чтобы ходить в гости'
		if hour >= 5 and hour < 10: gs 'zz_render', '', '','Слишком раннее время, чтобы ходить в гости'
		if week < 6 and hour >= 10 and hour < 19: gs 'zz_render', '', '','Вы позвонили в дверь, но никто не открывает.'
		if $npc['42,qwDyadyaMisha'] <= 0 and hour >= 19 and hour <= 23: gs 'zz_render', '', '', 'Никто не открывает'
		if mishahouse_count = 1 and $npc['42,qwDyadyaMisha'] >= 1 and (week < 6 and hour >= 19 or week >= 6 and hour >= 10):
			*clr & cla
			gs 'stat'
			gs 'zz_render', '', '', 'Вам открыл дверь дядя Миша и пригласил войти в квартиру.'
			act 'Уйти': gt'pod_ezd','etaj_2'
			act 'Войти':
				mishahouse_day = daystart
				mishahouse_count -= 1
				gt'misha','1'
			end
		end
		if mishahouse_count <= 0 and $npc['42,qwDyadyaMisha'] >= 1 and (week < 6 and hour >= 19 or week >= 6 and hour >= 10): gs 'zz_render', '', '', 'Вы позвонили в дверь, вам открыл дядя Миша и сказал:**\\\- <<$gop_name_gg>>, я сейчас занят, зайди завтра.///'
	end
end
!этаж 3
if $ARGS[0] = 'etaj_3':
	*clr & cla
	minut +=1
	gs 'stat'
	gs 'zz_render', 'Этаж #3', 'images/pavlovo/home/floor3.jpg', 'Относительно чистый этаж. Не так давно сделан ремонт и стены расписать ещё не успели. В углу стоит банка с сигаретными окурками.'
	gs 'pavlovo_events','front_door_events', 3
	act 'Подняться на четвертый этаж': gt'pod_ezd','etaj_4'
	act 'Спуститься на второй этаж': gt'pod_ezd','etaj_2'
	act 'Квартира №11 Шульги': gt'shulgahome'
	if BeInJulMilHome = 1 and i = 1: act 'Квартира №12 Юлии Миловой': gt'JuliaMilHome'
end
!этаж 4
if $ARGS[0] = 'etaj_4':
	*clr & cla
	minut +=1
	gs 'stat'
	gs 'zz_render', 'Этаж #4', 'images/pavlovo/home/floor4.jpg', 'Довольно чистый этаж. На этаже не видно окурков или признаков мусора - видимо кто-то всё таки убирает здесь.'
	gs 'pavlovo_events','front_door_events', 4
	act 'Подняться на пятый этаж': gt'pod_ezd','etaj_5'
	act 'Спуститься на третий этаж': gt'pod_ezd','etaj_3'
	if BeInNatBelHome = 1 and i = 1: act 'Квартира №15 Наташи Беловой': gt'NatBelHome'
	act 'Квартира тети Люды':
		*clr & cla
		minut +=1
		gs 'stat'
		act 'Уйти': gt'pod_ezd','etaj_4'
		if tetyafirst < 2 and week >= 6 and hour > 19 or oluuosegunday_count = 0 and week >= 6 and hour > 19: gs 'zz_render', '', '', 'Вам открыла дверь тетя Люда и сказала:**\\\- <<$name>> извини я сейчас не могу разговаривать, у меня гость.///'
		if tetyafirst < 2 and week < 6 and hour > 19 or oluuosegunday_count = 0 and week < 6 and hour > 19: gs 'zz_render', '', '', 'Вам открыла дверь тетя Люда и сказала:**\\\- <<$name>> извини я сильно занята, не могу сейчас уделить тебе время.///'
		if tetyafirst < 2 and hour >= 10 and hour <= 19 or oluuosegunday_count = 0 and hour >= 10: gs 'zz_render', '', '', 'Никого нет дома'
		if hour < 5: gs 'zz_render', '', '', 'Слишком позднее время, чтобы ходить в гости'
		if hour >= 5 and hour < 10: gs 'zz_render', '', '', 'Слишком раннее время, чтобы ходить в гости'
		if oluuosegunday_count = 1 and $npc['37,qwMother'] >= 3 and tetyafirst >= 2 and hour >= 10:
			*clr & cla
			gs 'stat'
			gs 'zz_render', '', '', 'Вам никто не открывает дверь, вы можете воспользоваться ключом.'
			act 'Уйти': gt'pod_ezd','etaj_4'
			act 'Войти':
				oluuosegunday_day = daystart
				oluuosegunday_count -=1
				gt'motherQW','oluHome'
			end
		end
	end
end
!этаж 5
if $ARGS[0] = 'etaj_5':
	*clr & cla
	minut +=1
	gs 'stat'
	gs 'zz_render', 'Этаж #5', 'images/pavlovo/home/floor5.jpg', 'Чистый и ухоженный этаж. Ремонт не делали, это видно по цвету стен, но тут он не особо нужен: соседи следят за чистотой.'
	gs 'pavlovo_events','front_door_events', 5
	act 'Спуститься на четвёртый этаж': gt'pod_ezd','etaj_4'
end