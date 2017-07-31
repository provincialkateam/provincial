$metka = $ARGS[0]
$loc = $CURLOC
gs 'gadukino_event', 'gadsarai_check'
gs 'stat'
gs 'time'
gs 'zz_render', 'Сарай', func('zz_funcs','mk_image','qwest/gadukino/sarai'),'Ветхий сарай в котором хранятся инструменты. '+iif(mira_dog = 0,'Возле сарая пустует будка Пирата.','Возле сарая стоит будка Пирата в которой на цепи сидит голая <a href="exec: gt ''grandparents_events'',''mira_dog'' ">Мира</a>.')
if snow = 0:
	if hour > 9 and hour < 19:
		gs 'zz_render', '', '','Справа находится загон для коровы.'
	elseif hour = 19:
		gs 'zz_render', '', '','<a href="exec: gt ''grandma'' ">Бабушка</a> в загоне доит корову Зорьку .'
	else
		gs 'zz_render', '', '','Справа находится загон для <a href="exec: gt ''grandparents_events'',''cow'' ">коровы</a>.'
	end
	if hour > 9 and hour < 20 and week < 6 or horse_river = 2:
		gs 'zz_render', '', '','Слева находится загон для коня.'
	else
		gs 'zz_render', '', '','Слева находится загон с <a href="exec: gt ''grandparents_events'',''horse'' ">конем</a>.'
	end
else
	gs 'zz_render', '', '','Справа находится загон для <a href="exec: gt ''grandparents_events'',''cow'' ">коровы</a>.'
	gs 'zz_render', '', '','Слева находится загон с <a href="exec: gt ''grandparents_events'',''horse'' ">конем</a>.'
end
gs 'zz_render', '', '','В отдельном загоне живет<a href="exec: gt ''grandparents_events'',''boar''">кабан</a>.'
if findvel = 1:gs 'zz_render', '', '','В углу стоит старый <a href="exec:gt ''bicycle'',''sarai''">велосипед</a>.'
if grandma_ingadsarai = 1:gs 'zz_render', '', '','В сарае ковыряется ваша '+iif(grandma_notalk = 0,'<a href="exec: gt ''grandma'' ">бабушка</a>','сердитая бабушка')+'.'
if grandpa_ingadsarai = 1:gs 'zz_render', '', '','В сарае что-то делает ваш '+iif(grandpa_notalk = 0,'<a href="exec: gt ''grandpa'' ">дедушка</a>','дедушка')+'.'
act 'Выйти во двор': minut += 5 & gt'Gaddvor'
if card = 0 or findvel = 0:
    act 'Ковыряться в сарае':
	    *clr & cla
	    minut += 15
	    gs'stat'
	    if findvel=0:
			findvel=1
            gs 'zz_render', '', 'qwest/gadukino/new/findvel.jpg', 'В дальнем углу сарая вам удаётся найти старый велосипед. На удивление, он в хорошем состоянии'
		elseif card = 0:
			card = 1
			gs 'zz_render', '', 'pic/Cor.jpg', 'В шкафчике старые журналы "Здоровье", "Техника молодежи" и пыльные пожелтевшие книги.**\\"Хмм, а это что такое?"// подумали вы, когда нашли колоду карт.'
		end
		act 'Положить на место':gt $curloc
	end
end
if card > 0: act 'Взять колоду карт': gt 'card'
if horny >= 50 and grandparents_ingadsarai = 0:act 'Мастурбировать': gt'selfplay'
if month >= 5 and month <= 9 and sunWeather >= 0 and hour > 13 and hour < 18 and week < 6 and grandmaknowsick = 1:gt'grandma'
! это в память о безвременно почившем Пирате(((
if know_no_pirat = 0:
	*clr & cla
	minut += 60
	know_no_pirat = 1
	gs 'stat'
	gs 'zz_render', 'Сарай', 'qwest/gadukino/new/know_no_pirat.jpg','\\- А где же Пират? Наверное сбежал, сволочь, -// подумали с грустью вы, осматривая пустую будку и с нежностью вспоминая своего любимого пса.'
	act 'Далее': gt $loc, $metka
end
if grandmaknowmastr = 1 or grandpaknowmastr = 1:
	*clr & cla
	minut += 5
	gs 'stat'
	if grandmaknowmastr = 1:
		grandmaQW -= 5
		grandma_notalk = 1
		gs 'zz_render', 'Бабушка', 'qwest/gadukino/grandma.jpg','\\\- Ах ты бесстыдница!, -/// услышали вы голос бабушки.\\\ - А ну-ка брысь отсюда, пока дубцом не получила! Ишь чего удумала!///'
	elseif grandpaknowmastr = 1:
		grandpa_notalk = 1
		gs 'zz_render', 'Дедушка', 'qwest/gadukino/grandpa.jpg','\\\- Кхе-кхе! -/// неожиданно вы услышали дедушкин голос. Он стоял и во все глаза смотрел на вас.**\\- Ой!, -// воскликнули вы от неожиданности и бросились со всег ног прочь, на ходу поправляя одежду.'
	end
	act 'Убежать':grandpaknowmastr = 0 & grandmaknowmastr = 0 & minut += 1 & gt'Gaddvor'
end