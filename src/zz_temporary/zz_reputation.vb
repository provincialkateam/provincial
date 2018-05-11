!-----
! репутация в определенном месте может быть разной
! все места определеяются контрольными точками $control_point
! $control_point:
!	gorodok - Павлово
!	gadukino
!	south - южный район
!	center - центральный район
!	north - северный район
!	dachi
!	campus - репутация в университете
!-----
! 0 - 49 (0) - приличная
! 50 - 99 (1) - легко разводимая
! 100 - 149 (2) - давалка
! 150 - 199 (3) - безотказная давалка
! 200 - 249 (4) - шлюха
!-----
! секс с бойфрендом не несет последствий
! секс со случайным парнем на дискотеке: +5 в карму, даже "приличная" после 6-7 раз может стать "легко разводимой"
!-----
!-----
! очистка репутации
! каждый день плохая репутация снижается на -1
! субботник возле школы или ДК: -5, раз в неделю
! работа в клинике милосердия: -3, только по выходным, если ГГ еще школьница и -1 за день работы, если ГГ уже закончила школу
! помощь матери: -1 в день
! помощь отчиму: -1 в день
! помощь деду: -1 в день
! помощь бабке: -1 в день
! при высокой доминантности: -3 в день во время спора
! ТММ разово очищает репутацию полностью
! Альбина, если не сдать ее мусорам - не позволяет упасть репутации ниже безотказной давалки - т.е. ГГ не может стать шлюхой в городке
! Котов при высокой доминантности может разово очистить репутацию полностью
! угощение бабушек - только по выходным, -1
! ...
! другие еще не придуманые варианты
!-----
!-----
! устанавливаем базовый диапазон
reputation['range'] = 50
!---
! получаем строку-описание
if $args[0] = 'rep_description':
	! проверка границ
	gs 'zz_reputation','check_ranges'
	! массив описаний
	$_rep_desc[0] = ' вас считают приличной девушкой.'
	$_rep_desc[1] = ' вы слывете девушкой, которую легко развести на секс.'
	$_rep_desc[2] = ' вас считают давалкой.'
	$_rep_desc[3] = ' вас считают общей безотказной давалкой, которую можно трахать компаниями.'
	$_rep_desc[4] = ' вы пользуетесь дурной известностью как шлюха, продающаяся за деньги.'
	! массив строк в зависимости от местоположения
	$_rep_point['gorodok'] = 'В Павлово'
	$_rep_point['gadukino'] = 'В деревне'
	$_rep_point['south'] = 'В Южном районе'
	$_rep_point['center'] = 'В Центральном районе'
	$_rep_point['north'] = 'В Северном районе'
	$_rep_point['dachi'] = 'В Дачном массиве'
	$_rep_point['uni_campus'] = 'В университете'
	! возвращаем строку
	$result = $_rep_point[$control_point] + $_rep_desc[reputation[$control_point]/reputation['range']]
	! чистим переменные
	killvar '$_rep_desc'
	killvar '$_rep_point'
	exit
end
!-----
!-----
! функция для просчета репутации - использовать надо ее,
! поскольку мы сможем безболезненно изменить пересчет здесь и только здесь, не ползая по всему коду
if $args[0] = 'get':
	gs 'zz_reputation','check_ranges'
	result = reputation[$control_point]/reputation['range']
	exit
end
!-----
! установка репутации
! как и в случае с полученим - используем функцию для легких правок в будущем
! устанавливаем на средину диапазона чтобы не было быстрых переходов между уровнями
if $args[0] = 'set':
	reputation[$control_point] = args[1]*reputation['range'] + reputation['range']/2
	gs 'zz_reputation','check_ranges'
	exit
end
! Изменение репутации по ситуации
!gs 'zz_reputation','edit', -5
! args[1] - обязательный числовой аргумент!
!Если хотите повысить репутацию(улучшить) - ставим положительные аргументы >0
!Если хотите понизить репутацию (ухудшить) - ставим отрицательный аргумент <0
if $args[0] = 'edit':
	reputation[$control_point] -= args[1]
	gs 'zz_reputation','check_ranges'
	if args[1] < 0:
		gs 'zz_funcs','message','','<red>Ваша репутация ухудшилась!</red>'
	else
		gs 'zz_funcs','message','','<green>Ваша репутация улучшилась!</green>'
	end
	exit
end
! дневное улучшение репутации на всех контрольных точках
if $args[0] = 'increase_all':
	reputation['gorodok'] -= 1
	reputation['gadukino'] -= 1
	reputation['south'] -= 1
	reputation['center'] -= 1
	reputation['north'] -= 1
	reputation['dachi'] -= 1
	reputation['uni_campus'] -= 1
end
! проверка границ репутации
if $args[0] = 'check_ranges':
	if reputation[$control_point] < 0: reputation[$control_point] = 0
	if reputation[$control_point] >= reputation['range']*5: reputation[$control_point] = reputation['range']*5-1
end
!-----
! функция для перехода с GorSlut, вставить в загрузку игры
if $args[0] = 'recalc_gorslut':
	if GorSlut = 0:
		reputation['gorodok'] = 0
	elseif GorSlut = 1:
		reputation['gorodok'] = reputation['range']
	elseif GorSlut = 2:
		reputation['gorodok'] = reputation['range']*2
	elseif GorSlut = 3 or GorSlut = 4:
		reputation['gorodok'] = reputation['range']*3
	else
		reputation['gorodok'] = reputation['range']*4
	end
end
!-----