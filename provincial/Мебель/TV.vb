if $ARGS[0] = 'start':
	*clr & cla
	elektro += 5
	gs'stat'
	'<center><img src="images/pics/telek.jpg"></center>'
	'Вы включили телевизор и поудобней устроились на диване.'
	if TV = 1:'Древний телевизор включился и из него хрипло донеслись звуки рекламы.'
	if TV = 2:'Огромная плазма включилась и из нее бойко донеслись звуки рекламы.'
	if kabel = 0:
		'Кабельного у вас нет, поэтому показывает только один канал с постоянной рекламой и новостями.'
		act 'Смотреть телевизор 1 час': gt'TV','nokable'
	elseif kabel = 1:
		'У вас подключено кабельное телевидение.'
		act 'Смотреть телевизор 1 час': gt'TV','kable'
	end
	act 'Выключить телевизор и встать с дивана': gt $loc, $metka
end
if $ARGS[0] = 'nokable':
	*clr & cla
	minut += 60
	manna += 10
	elektro += 3
	gs'stat'
	'<center><img src="images/pics/telek2.jpg"></center>'
	'Вы смотрите центральный канал лежа на диване. Смотреть почти нечего, сплошная реклама и дрянные программы.'
	act 'Смотреть телевизор 1 час': gt'TV','nokable'
	act 'Выключить телевизор и встать с дивана': gt $loc, $metka
end
if $ARGS[0] = 'kable':
	*clr & cla
	minut += 60
	manna += 20
	elektro += 3
	gs'stat'
	'<center><img src="images/pics/telek.jpg"></center>'
	'Вы смотрите кабельное телевидение.'
	act 'Смотреть телевизор 1 час': gt'TV','kable'
	act 'Выключить телевизор и встать с дивана': gt $loc, $metka
end