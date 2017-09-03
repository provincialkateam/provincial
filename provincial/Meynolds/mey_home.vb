*clr & cla
$loc = $curloc
gs 'zz_funcs', 'colorize_day'
! костыль для действий на кухне
if val($args[0]) > 0: args[0] = val($args[0])
! проверка на доступность
if args[0] < 0:
	$_str[0] = 'Не время ходить в гости...'
	$_str[1] = 'Вы подходите к дому Мейнольдов и звоните в дверь...**'
	$_str[2] = 'Никто не открывает: видать, нету никого дома.'
	$_str[3] = 'После недолгого ожидания щёлкает замок, и дверь открывает мама Кати и Вики: <br><do>- О, <<$name[2]>>, привет! Проходи, чувствуй себя как дома.</do>'
	$_str[4] = 'Вы открываете дверь ключом, который дала Вика, и заходите в дом.'
	$_str[5] = 'Дверь открывает Катя и тащит вас в свою комнату.'
	! если есть ключ к дому
	if $npc['0,meynold_key'] = 1:
		gs 'zz_render','','',$_str[1]+$_str[4]
		act 'Войти': gt 'mey_home',0
	else
		if ((week < 6 and hour >= 15 and minut >= 20) or (week >= 6 and hour >= 10)) and hour < 20:
			if hour < 17:
				if $npc['14,qwKatya'] >= 10 and $npc['14,homeward'] = 1:
					! katya
					gs 'zz_render','','pavlovo/meynolds/home/door',$_str[1]+$_str[5]
					act 'Идти с Катей': gt 'mey_home',5
				else
					! no home
					gt 'mey_home_events','no_home'
				end
			else
				! TM
				if $npc['15,qwVika'] = 27 or $npc['14,qwKatya'] = 15:
					gt 'mey_tamara_events','next_meet'
				elseif $npc['15,qwVika'] >= 30 or $npc['14,qwKatya'] >= 20:
					gs 'zz_render','','pavlovo/meynolds/tamara/meeting/tea1',$_str[1]+$_str[3]
					act 'Войти': gt 'mey_home',0
				else
					! no home
					gt 'mey_home_events','no_home'
				end
			end
		else
			! no home
			gt 'mey_home_events','no_home'
		end
	end
	killvar '$_str'
	exit
end
mey_loc_id = args[0]
minut += 1
frost = 0
gs 'stat'
! ----- NAV array ----- !
$mey_desc['0,name'] = 'Холл'
$mey_desc['1,name'] = 'Кухня'
$mey_desc['2,name'] = 'Ванная'
$mey_desc['3,name'] = 'Гостевая'
$mey_desc['4,name'] = 'Зал'
$mey_desc['5,name'] = 'Комната Кати'
$mey_desc['6,name'] = 'Комната Вики'
$mey_desc['7,name'] = 'Комната Тамары Михайловны'
$mey_desc['8,name'] = 'Веранда'
$mey_desc['9,name'] = 'Двор'
$mey_desc['10,name'] = 'Коридор'
$mey_desc['0,image'] = 'corridor'
$mey_desc['1,image'] = 'kitchen'
$mey_desc['2,image'] = 'bathroom'
$mey_desc['3,image'] = 'guestroom'
$mey_desc['4,image'] = 'hall'
$mey_desc['5,image'] = 'katya_room'
$mey_desc['6,image'] = 'vika_room'
$mey_desc['7,image'] = 'tamara_room'
$mey_desc['8,image'] = 'terrace'
$mey_desc['9,image'] = 'courtyard'
$mey_desc['10,image'] = 'corridor_2stage'
$mey_desc['0,text'] = 'Большой и светлый холл, который "прихожей" язык не поворачивается назвать: в этой "прихожей" можно на велосипеде ездить! Половину стены занимает громадное ростовое зеркало. Из холла выходы на кухню, где виден большой обеденный стол, и в зал. Тут же лестница, ведущая на второй этаж. Видны и пара дверей с табличками "Туалет" и "Ванная".'
$mey_desc['1,text'] = 'Кухня огромна и роскошна. Отделана она в минималистическом хай-тек-стиле. Вокруг стоящего посередь её обеденного стола можно, как и холле, ездить на велосипеде. Бытовая техника вся скрыта, всттроенная. Кухня сияет чистотой.'
$mey_desc['2,text'] = 'Просторное помещение, где установлены душевая кабинка со стеклянной дверцей, унитаз и биде, а большую часть комнаты занимает огромная роскошная и дорогущая ванна с гидромассажем, больше похожая на небольшой бассейн.'
$mey_desc['3,text'] = 'В общем-то, выглядит, как стандартный номер в любом отеле "средней руки". Кровать, небольшой платяной шкаф, стол, тумбочка у кровати, зеркало на стене.'
$mey_desc['4,text'] = 'Просторная комната с диваном и креслами, расположившимися у камина, рядышком - книжный шкаф и большой плазменный телевизор. Из зала есть выход на светлую веранду, заросшую виноградом.'
$mey_desc['5,text'] = 'В комнате Кати складывается ощущение, что она ненадолго сюда въехала и скоро съедет. Идеальный порядок, зеркальная чистота и ощущение "нежилого помещения". "Необжитость" разбавляют только многочисленные цветы в горшочках на подоконнике, в кашпо на стенах и в кадках на полу, что придаёт Катиной комнате вид оранжереи. В углу стоит стол с компьютером, напротив - кровать. В другом углу просторной, но почему-то кажущейся тесной комнаты, спрятался шкаф. Напротив стоит книжный шкаф, но его почти не видно из за буйно разросшихся цветов.'
$mey_desc['6,text'] = 'В Викиной комнате всегда царит бардак. Здесь чисто, но всё раскидано в творческом беспорядке. Повсюду валяются мягкие игрушки в совершенно неимоверных количествах, а все стенки заклеены постерами с поп-звёздами и киноактёрами. На столе у окна стоит ноутбук, словно случайно привнёсший толику упорядоченности своим присутствием в Викину комнату. Из за горы каких-то журналов виднеются музыкальные колонки. Но главное место в комнате занимает кровать циклопических размеров, рядом с которой притулился теряющийся на её фоне платяной шкаф. Вика им, похоже, вообще не пользуется: её шмотки раскиданы как попало по всей комнате. Где-то в углу сиротливо притулилось кресло.'
$mey_desc['7,text'] = 'Комната Тамары Михайловны напоминала бы рабочий кабинет, если бы не кровать в углу. Тут стоит стол с компьютером, кожаное офисное кресло у него, платяной шкаф и довольно скромная кровать. Комнатка невелика и тесновата. "Украшательств" в ней нет, кроме висящего на стенке зачем-то меча. Что он тут делает - совершенно непонятно.'
$mey_desc['8,text'] = 'Веранда смотрит во двор дома. От соседей она заслонена высоким забором и вся заплетена виноградом. Здесь компактно разместились летняя кухня с жаровней и плетёная мебель - несколько кресел, столик и лежак, на котором лежит матрац-подушка.'
$mey_desc['9,text'] = 'У дома стоит машина Тамары Михайловны, а во дворике есть небольшой сборный бассейн.'
$mey_desc['10,text'] = 'Большой коридор второго этажа. Сразу у лестницы располагается комната Кати, напротив - комната Тамары Михайловны, дальше по коридору комната Вики, напротив неё - гостевая комната. В самом конце коридора - кладовка.'
gs 'zz_render', $mey_desc['<<mey_loc_id>>,name'],'pavlovo/meynolds/home/'+$mey_desc['<<mey_loc_id>>,image'], $mey_desc['<<mey_loc_id>>,text']
killvar '$mey_desc'
! ---------------------- !
! actions
if mey_loc_id = 0:
	if mey_loc_id = 0:
		act '<b>На улицу</b>': killvar 'mey_loc_id' & gt 'gorodok'
		act 'Дворик': gt $curloc, 9
	end
	if mey_loc_id ! 0: act 'Холл': gt $curloc, 0
	if mey_loc_id ! 1: act 'Кухня': gt $curloc, 1
	if mey_loc_id ! 2: act 'Ванная': gt $curloc, 2
	if mey_loc_id ! 4: act 'Зал': gt $curloc, 4
	act '<b>Подняться на 2 этаж</b>': gt $curloc, 10
elseif mey_loc_id = 10:
	if mey_loc_id ! 3: act 'Гостевая': gt $curloc, 3
	!if mey_loc_id = 4: act 'Веранда': gt $curloc, 8
	if mey_loc_id ! 5: act 'Комната Кати': gt $curloc, 5
	if mey_loc_id ! 6: act 'Комната Вики': gt $curloc, 6
	if mey_loc_id ! 7: act 'Комната Тамары Михайловны': gt $curloc, 7
	act '<b>Спуститься на 1 этаж</b>': gt $curloc, 0
end
! corr
if mey_loc_id = 0:
	gs 'mey_vika_events', 'case_gift'
	gs 'mey_vika_events', 'gym0'
	gs 'mey_vika_events', 'gym1'
	gs 'mey_vika_events', 'learning0'
	! корпоратив только в конце месяца по выходным, проверяем
	if day <= 25 and ($npc['45,qwTamara'] = 30 or $npc['45,qwTamara'] = 40): $npc['45,qwTamara'] = 10
	! приглашаем на корпоратив
	if week = 7 and hour >= 8 and hour <= 12 and day > 25 and ($npc['45,qwTamara'] = 7 or $npc['45,qwTamara'] = 10) and func('zz_reputation','get') < 3:
		gt 'mey_tamara_events', 'party0'
	end
	! проверка внешности перед поездкой на корпоратив
	if hour = 17 and $npc['45,qwTamara'] = 16:
		gs 'zz_render','','','<br>В холле вас ожидает <a href="exec: gt''mey_tamara_events'',''check_look''">Тамара Михайловна.</a>'
		exit
	end
	! надо трахнуть катю!
	if $npc['14,qwKatya'] >= 40 and $npc['14,homeward'] = 1 and $npc['15,qwVika'] > 35 and hour = 23 and $npc['15,mey_vika_bang_qw'] = 0:
		gs 'mey_vika_events', 'bang_katya'
		exit
	end
	if hour = 23 and $npc['15,qwVika'] >= 35 and $npc['15,qwVika_random_day'] ! day and rand(0,5) = 1: gt 'mey_vika_events','random_sex_prepeare'
	! вика зовет в душ
	if mesec = 0 and vagina > 0 and $npc['15,bath_qw'] = 1 and $npc['15,bath_qw_day'] ! day and rand(0,10) > 5 and hour >= 16 and hour < 18 and week mod 2 = 1:
		gs 'mey_vika_events', 'bath_qw1'
		exit
	end
	! уборка дома
	if $npc['45,qwTamara'] >= 3 and ((week < 6 and hour >= 16 and hour < 20) or (week = 6 and hour >= 10 and hour < 20)) and $npc['0,mey_help_day'] ! day:
		gs 'mey_home_events','clean_home'
	end
	exit
end
! kitchen
if mey_loc_id = 1:
	cla
	$metka = str(mey_loc_id)
	if (hour = 7 and minut < 30) or (hour = 16 and week >= 6) or (hour = 17 and minut >= 30 and week < 6): gs 'zz_render','','','На кухне хлопочет Тамара Михайловна.'
	if hour = 8 and minut < 30: gs 'zz_render','','','На кухне завтракают <a href="exec:gt''mey_vika_talk'',''main''">Вика</a> и Катя.'
	gs 'zz_kitchen_acts', 'all'
	if $npc['45,qwTamara'] >= 3 and ((week < 6 and hour >= 16 and hour < 20) or (week = 6 and hour >= 10 and hour < 20)) and $npc['0,mey_help_day'] ! day:
		gs 'mey_home_events','cooking'
	end
	act 'Выйти': gt 'mey_home', 0
	exit
end
! bathroom
if mey_loc_id = 2:
	$metka = str(mey_loc_id)
	cla
	act '<b>Выйти</b>': gt 'mey_home', 0
	if hour = 6 and minut < 30:
		gs 'zz_render','','','Ванна занята, судя по времени - Тамарой Михайловной.'
	elseif hour = 6 and minut >= 30:
		gs 'zz_render','','','Ванна занята, скорее всего, Катей.'
		! ивент Кати в душе
		if $npc['0,meynold_key'] = 1 and $npc['14,bath_event_day'] ! day and $npc['14,homeward'] = 1: gs 'mey_katya_events', 'bath_event'
	elseif hour = 7 and minut < 30:
		gs 'zz_render','','pavlovo/meynolds/vika/bath/11','Ванная занята, судя по времени - это стопудово соня <a href="exec:gt''mey_vika_talk'',''main''">Вика</a>, а эта может долго лёпаться.'
	else
		$metka = 0
		gs 'zz_bathroom', 'start'
	end
!	exit
end
! guestroom
if mey_loc_id = 3:
	cla
	$metka = str(mey_loc_id)
	if prev_clothing > 2:
		gs 'zz_render', '', '', 'Рядом с кроватью лежит ваша аккуратно сложенная одежда.'
		act 'Одеться':
			prev_clothing = -1
			gs 'zz_clothing', 'redress', prev_clothing
			gt 'mey_home', 3
		end
	end
	! если ключ не получен или не знакома с ТМ - выход только на улицу
	if $npc['0,meynold_key'] = 0 and $npc['14,qwKatya'] < 20:
		gs 'mey_home_events','go_out_no_key'
		exit
	end
	!---
	if horny >= 80: act 'Мастурбировать': gt 'selfplay'
	gs 'zz_common','home_workout'
	gs 'zz_funcs', 'waiting', 1
	act 'Спать': gs 'bed', 'start'
	act 'Шкаф': gt 'loker', 'start'
	act 'Зеркало': gt 'mirror','start'
	act '<b>Выйти</b>':
		if current_clothing < 3:
			*clr
			gs 'zz_render', '', 'images/clothing/'+iif(tanga=0,'0','tanga')+'.jpg','<red>В таком виде в гостях лучше не ходить!</red>'
			exit
		end
		gt 'mey_home', 10
	end
	exit
end
! hall
if mey_loc_id = 4:
	$metka = str(mey_loc_id)
	cla
	! находим диск с компроматом на ТМ
	if (hour = 16 or hour = 17) and week < 6 and week mod 2 = 0 and $npc['15,qwVika'] >= 35 and $npc['15,qwVika'] < 40 and $npc['45,dirt_qw'] = 0:
		gs 'mey_home_events','dirt'
		exit
	end
	if hour >= 18 and hour < 22:
		! спрашивем о Соне у ТМ
		if $npc['45,qwTamara'] >= 10 and $npc['45,qwTamara'] < 50 and $npc['25,qwSonya_day'] ! day and ($npc['25,qwSonya'] = 40 or $npc['25,qwSonya'] = 45):
			act 'Спросить о Соне у Тамары Михайловны': gt 'sonya',iif($npc['25,qwSonya'] = 40,'ask_tamara_for_help','ask_tamara_for_help2')
		end
		gs 'zz_render','','','В зале на диванчике сидит Тамара Михайловна.'
	end
	if week >= 6 and (hour >= 8 and minut >= 30) and hour <= 10: gs 'zz_render', '', '', 'В зале смотрит телевизор все семейство Мейнольдов.'
	act '<b>Выйти</b>': gt 'mey_home', 0
	gs 'zz_funcs', 'waiting', 1
	act 'Разжечь камин': gs 'mey_home_events','fireplace'
	act 'Смотреть телевизор': gt 'zz_common','watch_tv_on_sofa'
	act 'Заглянуть в книжный шкаф':
		*clr & cla
		! make bookshelf
		gs 'zz_books','custom_shelf',20,39
		gs 'zz_render','','','В книжном шкафу не так много книг - все "умные" давно перекочевали в комнату Кати, а в зале остались лишь "дамские романчики" (что они тут вообще делают?) и всякие "Пятьдесят оттенков коричневого".'
	end
	act 'На веранду': gt 'mey_home',8
	exit
end
! katya room
if mey_loc_id = 5:
	$metka = str(mey_loc_id)
	cla
	if $npc['14,homeward'] = 1:
		if hour < 6 or (hour = 6 and minut < 30): gs 'zz_render','','','Катя спит в своей кроватке.'
		if hour = 7: gs 'zz_render','','','<a href="exec: gt''mey_katya_events'',''hometalk''">Катя</a> разложила свои наряды и пытается выбрать, что ей надеть.'
		if ((hour = 15 and minut >= 20) or (hour >= 16 and hour <= 20)) and week < 6: gs 'zz_render','','','<a href="exec:gt''mey_katya_events'',''hometalk''">Катя</a> делает домашку, по уши зарывшись в учебники.'
		if hour = 23 or (week >= 6 and (sunWeather < 0 or temper < 5) and hour >= 10 and hour < 20): gs 'zz_render','','','<a href="exec:gt''mey_katya_events'',''hometalk''">Катя</a>, попивая ароматный какао, читает книгу.'
	end
	! если ключ не получен или не знакома с ТМ - выход только на улицу
	if $npc['0,meynold_key'] = 0:
		gs 'mey_home_events','go_out_no_key'
		exit
	end
	!---
	act '<b>Выйти</b>': gt 'mey_home', 10
	exit
end
! vika room
if mey_loc_id = 6:
	$metka = str(mey_loc_id)
	cla
	act '<b>Выйти</b>': gt 'mey_home', 10
	if hour < 7: gs 'zz_render','','','<a href="exec:gt''mey_vika_talk'',''sleep''">Вика</a> спит в своей кроватке.'
	if hour = 7 and minut >= 30: gs 'zz_render','','','Перед <a href="exec:gt''mey_vika_talk'',''main''">Викой</a> стоит тяжелейшая задача - выбрать среди кучи пёстрых одёжек что-то подходящее под сегодняшние буйные мыслишки.' & $vika_state = 'go_school'
	if week >= 6 and (sunWeather < 0 or temper < 5) and hour >= 10 and hour <= 15: gs 'zz_render','','','<a href="exec:gt''mey_vika_talk'',''main''">Вика</a>, развалившись на кровати в позе "я - большая морская звезда", мечтательно разглядывает потолок. Мыслями она явно где-то не здесь.' & $vika_state = 'relax'
	! Иван на тренировке, Вика сама
	if week mod 2 = 1 and hour >= 16 and hour < 20: gs 'zz_render','','','Бывает и такое - <a href="exec:gt''mey_vika_talk'',''main''">Вика</a> занята домашкой.' & $vika_state = 'homework'
	if hour = 23 and ($npc['15,qwVika'] < 32 or $npc['15,qwVika'] >= 35 or $npc['15,qw_day'] = day): gs 'zz_render','','','<a href="exec:gt''mey_vika_talk'',''main''">Вика с Иваном</a> о чём-то болтают.'
	exit
end
! tamara room
if mey_loc_id = 7:
	$metka = str(mey_loc_id)
	cla
	act '<b>Выйти</b>': gt 'mey_home', 10
	if hour <= 6: gs 'zz_render','','','Тамара Михайловна спит и нечего её тревожить.'
	if hour = 6 and minut >= 30: gs 'zz_render','','','Тамара Михайловна собирается на работу, не стоит ей мешать.'
	if ((($npc['45,qwTamara'] > 0 and $npc['45,qwTamara'] ! 3) or $npc['15,qw_day'] = day) and hour = 23) or hour = 22:gs 'zz_render','','', 'Тамара Михайловна читает книгу, лежа на кровати.'
	exit
end
! terrace
if mey_loc_id = 8:
	$metka = str(mey_loc_id)
	cla
	act '<b>Зайти в дом</b>': gt 'mey_home', 4
	if week >= 6 and hour >= 10 and hour <= 15 and month >= 3 and month <= 10 and (sunWeather < 0 or (temper >= 5 and temper < 20)): gs 'zz_render', '', '', 'На веранде, попивая чай, весело болтают Вика, Катя и тетя Тамара.'
	exit
end
! courtyard
if mey_loc_id = 9:
	cla
	act '<b>Уйти</b>':
		if current_clothing <= 2: gs 'mey_home_events','cloth_on'
		gt $curloc, 0
	end
	if hour = 7 and minut >= 30 and week < 6: gs 'zz_render', '', '', 'Во дворе возле машины разговаривает по телефону <a href="exec:gs''mey_tamara_events'',''tamara''">тётя Тамара.</a>'
	if week >= 6 and hour >= 10 and hour <= 15 and month >= 5 and month <= 9 and sunWeather >= 0 and temper >= 20: gs 'zz_render', '', '', 'В дворике нежится на солнце вся семейка Мейнольдов.'
	if hour >= 9 and hour <= 18 and month >= 3 and month <= 11:
		gs 'mey_home_events','redress'
		if current_clothing <= 2:
			if temper > 5: gs 'mey_home_events','swim'
			if temper >= 20 and sunWeather >= 0: gs 'mey_home_events','sunbathe'
		end
	end
	exit
end