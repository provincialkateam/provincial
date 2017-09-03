!-----
! репутация в определенном месте может быть разной
! все места определеяются контрольными точками $control_point
! $control_point:
!	gorodok - Павлово
!	gadukino
!	street - южный район
!	down - центральный район
!	nord - северный район
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
! получаем строку-описание
if $args[0] = 'rep_description':
	! проверка границ
	if reputation[$control_point] < 0: reputation[$control_point] = 0
	if reputation[$control_point] >= 250: reputation[$control_point] = 249
	! массив описаний
	$_rep_desc[0] = ' вас считают приличной девушкой.'
	$_rep_desc[1] = ' вы слывете девушкой, которую легко развести на секс.'
	$_rep_desc[2] = ' вас считают давалкой.'
	$_rep_desc[3] = ' вас считают общей безотказной давалкой, которую можно трахать компаниями.'
	$_rep_desc[4] = ' вы пользуетесь дурной известностью как шлюха, продающаяся за деньги.'
	! массив строк в зависимости от местоположения
	$_rep_point['gorodok'] = 'В Павлово'
	$_rep_point['gadukino'] = 'В деревне'
	$_rep_point['street'] = 'В Южном районе'
	$_rep_point['down'] = 'В Центральном районе'
	$_rep_point['nord'] = 'В Северном районе'
	$_rep_point['dachi'] = 'В Дачном массиве'
	$_rep_point['campus'] = 'В университете'
	! возвращаем строку
	$result = $_rep_point[$control_point] + $_rep_desc[reputation[$control_point]/50]
	! чистим переменные
	killvar '$_rep_desc'
	killvar '$_rep_point'
	exit
end
!-----
!-----
! функция для просчета репутации - использовать надо ее,
! поскольку мы сможем безболезненно изvенить пересчет здесь и только здесь, не ползая по всему коду
if $args[0] = 'get':
	if reputation[$control_point] < 0: reputation[$control_point] = 0
	if reputation[$control_point] >= 250: reputation[$control_point] = 249
	result = reputation[$control_point]/50
	exit
end
!func('zz_reputation','get')
!-----
! установка репутации
! как и в случае с полученим - используем функцию для легких правок в будущем
if args[0] = 'set':
	reputation[$control_point] = args[1]*50
	if reputation[$control_point] >= 250: reputation[$control_point] = 249
	exit
	! gs 'zz_reputation','set'
end
! понижение плохой репутации
! args[1] - на сколько изменяется репутация, по умолчанию -1
if $args[0] = 'decrease':
	reputation[$control_point] -= iif(args[1]=0,1,args[1])
	if reputation[$control_point] <= 0: reputation[$control_point] = 0
	! поскольку функцию можно использовать и для увеличения - проверяем заодно и верхнюю границу
	if reputation[$control_point] >= 250: reputation[$control_point] = 249
	exit
	! gs 'zz_reputation','decrease'
end
!-----
! функция для перехода с GorSlut, вставить в загрузку игры
if $args[0] = 'recalc_gorslut':
	if GorSlut = 0:
		reputation['gorodok'] = 0
	elseif GorSlut = 1:
		reputation['gorodok'] = 50
	elseif GorSlut = 2:
		reputation['gorodok'] = 100
	elseif GorSlut = 3 or GorSlut = 4:
		reputation['gorodok'] = 150
	else
		reputation['gorodok'] = 200
	end
end
!-----