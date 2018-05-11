! Достижения
!-----
! табличка шириной 820px, по 3 достижения в ряд
! рисунки: все рисунки должны быть JPG
!		путь: images/common/achievements/
!		размер: 260*150
!-----
! achievements[] - глобальный массив, содержит инфу открыто или нет достижение, 0/1
! $_ach - локальный массив, заполняется при заходе на страничку достижений:
! $_ach['id,img'] - имя рисунка
! $_ach['id,name'] - название достижения
! $_ach['id,desc'] - короткое описание достижения, показывается только в виде MSGBOX
! $_ach['id,group'] - группа достижения:
!	0 - общие, не знаете куда отнести достижение - валяйте сюда
!	1 - отношения и репутация - от прокачки отношений до скачков репутации
!	2 - учёба и работа - всё, что связано с оценками и зарабатыванием денег
!	3 - спорт и хобби - спортивние достижения, танцы, фотосессии
!	4 - секс-достижения - всё от первой мастурбации до количества партнёров и поз
!	5 - специальные достижения - ачивки за прохождение квестов
!-------------------------------------------------------------
! Переменные
! achiev['talk,group_id'] - болтовня с определенной группой нпс
! achiev['cloth,group_id'] - покупка определенного вида одежды
! achiev['start'] - старт определенным персонажем
!-------------------
! инициализация массива описаний достижений
if $args[0] = 'init_array':
	!---
	$_ach['0,img'] = 'edu100'
	$_ach['0,name'] = 'Эйнштейн в юбке'
	$_ach['0,group'] = 2
	$_ach['0,desc'] = 'Ваша успеваемость максимальна!'
	!---
	$_ach['1,img'] = 'edu0'
	$_ach['1,name'] = 'Опять двойка!'
	$_ach['1,group'] = 2
	$_ach['1,desc'] = 'Ваша успеваемость на нуле!'
	!---
	$_ach['2,img'] = 'friend_bot'
	$_ach['2,name'] = 'Зато мы умные!'
	$_ach['2,group'] = 1
	$_ach['2,desc'] = 'Вы подружились со всеми ботанами.'
	!---
	$_ach['3,img'] = 'friend_maj'
	$_ach['3,name'] = 'Элитный клуб'
	$_ach['3,group'] = 1
	$_ach['3,desc'] = 'Вы подружились со всеми мажорами.'
	!---
	$_ach['4,img'] = 'friend_gop'
	$_ach['4,name'] = 'На кортах'
	$_ach['4,group'] = 1
	$_ach['4,desc'] = 'Вы подружились со всеми одноклассниками-гопниками.'
	!---
	$_ach['5,img'] = 'friend_sport'
	$_ach['5,name'] = 'Плечом к плечу'
	$_ach['5,group'] = 1
	$_ach['5,desc'] = 'Вы подружились со всеми спортсменами.'
	!---
	$_ach['6,img'] = 'maj_talk25'
	$_ach['6,name'] = 'Приветики!'
	$_ach['6,group'] = 1
	$_ach['6,desc'] = 'Вы 25 раз болтали с мажорами.'
	!---
	$_ach['7,img'] = 'maj_talk75'
	$_ach['7,name'] = 'Бонжур, господа!'
	$_ach['7,group'] = 1
	$_ach['7,desc'] = 'Вы 75 раз болтали с мажорами.'
	!---
	$_ach['8,img'] = 'maj_talk150'
	$_ach['8,name'] = 'Выше нас только горы!'
	$_ach['8,group'] = 1
	$_ach['8,desc'] = 'Вы 150 раз болтали с мажорами.'
	!---
	$_ach['9,img'] = 'gop_talk25'
	$_ach['9,name'] = 'Ну и чё?'
	$_ach['9,group'] = 1
	$_ach['9,desc'] = 'Вы 25 раз болтали с гопниками.'
	!---
	$_ach['10,img'] = 'gop_talk75'
	$_ach['10,name'] = 'Сёмки есть? А если найду?'
	$_ach['10,group'] = 1
	$_ach['10,desc'] = 'Вы 75 раз болтали с гопниками.'
	!---
	$_ach['11,img'] = 'gop_talk150'
	$_ach['11,name'] = 'Пацаны ваще ребята!'
	$_ach['11,group'] = 1
	$_ach['11,desc'] = 'Вы 150 раз болтали с гопниками.'
	!---
	$_ach['12,img'] = 'sport_talk25'
	$_ach['12,name'] = 'Физкульт-привет!'
	$_ach['12,group'] = 1
	$_ach['12,desc'] = 'Вы 25 раз болтали со спортсменами.'
	!---
	$_ach['13,img'] = 'sport_talk75'
	$_ach['13,name'] = 'Салют!'
	$_ach['13,group'] = 1
	$_ach['13,desc'] = 'Вы 75 раз болтали со спортсменами.'
	!---
	$_ach['14,img'] = 'sport_talk150'
	$_ach['14,name'] = 'Олимпийский привет!'
	$_ach['14,group'] = 1
	$_ach['14,desc'] = 'Вы 150 раз болтали со спортсменами.'
	!---
	$_ach['15,img'] = 'bot_talk25'
	$_ach['15,name'] = 'Привет, ботаны!'
	$_ach['15,group'] = 1
	$_ach['15,desc'] = 'Вы 25 раз болтали с ботанами.'
	!---
	$_ach['16,img'] = 'bot_talk75'
	$_ach['16,name'] = 'Поговорим о Пифагоре?'
	$_ach['16,group'] = 1
	$_ach['16,desc'] = 'Вы 75 раз болтали с ботанами.'
	!---
	$_ach['17,img'] = 'bot_talk150'
	$_ach['17,name'] = 'Te saluto! Vos saluto!'
	$_ach['17,group'] = 1
	$_ach['17,desc'] = 'Вы 150 раз болтали с ботанами.'
	!---
	$_ach['18,img'] = 'miss_universe'
	$_ach['18,name'] = 'Мисс вселенная'
	$_ach['18,group'] = 0
	$_ach['18,desc'] = 'Вы - самая красивая девушка в игре!'
	!---
	$_ach['19,img'] = 'haute_couture'
	$_ach['19,name'] = 'Откутюр'
	$_ach['19,group'] = 0
	$_ach['19,desc'] = 'Вы купили 5 модельных платьев!'
	!---
	$_ach['20,img'] = 'furcoat'
	$_ach['20,name'] = 'Зима близко!'
	$_ach['20,group'] = 0
	$_ach['20,desc'] = 'Вы купили шубу.'
	!---
	$_ach['21,img'] = 'tattoo'
	$_ach['21,name'] = 'Девушка с татуировкой'
	$_ach['21,group'] = 0
	$_ach['21,desc'] = 'Вы сделали татуировки во всех возможных местах!'
	!---
	$_ach['22,img'] = 'piercing'
	$_ach['22,name'] = 'Подушка для иголок'
	$_ach['22,group'] = 0
	$_ach['22,desc'] = 'У вас есть пирсинг. Много пирсинга.'
	!---
	$_ach['23,img'] = 'orphan_black'
	$_ach['23,name'] = 'Темное дитя'
	$_ach['23,group'] = 5
	$_ach['23,desc'] = 'Вы открыли истинный образ вашего персонажа.'
	!---
end
! проверка системы достижений
! запуск проверки только при загрузке игры или старте новой
if $args[0] = 'check_ach_array':
	! инициализируем массив описаний достижений
	gs 'zz_achievements','init_array'
	! получаем длинну массива описаний достижений
	_ach_count = arrsize('$_ach')/4
	! если количество описаний ($_ach/4) больше длины масcива достижений (achievements)
	if arrsize('achievements') < _ach_count:
		! расширим массив - для этого достаточно инициализировать последний элемент массива
		achievements[_ach_count-1] = 0
	end
end
! проверка условий открытия достижения
if $args[0] = 'check_ach':
	! локальная переменная, если больше 0 - вконце процедуры выводим сообщение, что открыто новое достижение
	_ach_status = 0
	! прописываем условия для всех достижений
	if school['certificate'] = 0 and school['progress'] = 100 and achievements[0] = 0: achievements[0] = 1 & _ach_status = 1
	if school['certificate'] = 0 and school['progress'] = 0 and achievements[1] = 0: achievements[1] = 1 & _ach_status = 1
	if func('npc_editor','get_avg_relation',1) = 100 and achievements[2] = 0: achievements[2] = 1 & _ach_status = 1
	if func('npc_editor','get_avg_relation',3) = 100 and achievements[3] = 0: achievements[3] = 1 & _ach_status = 1
	if func('npc_editor','get_avg_relation',4) = 100 and achievements[4] = 0: achievements[4] = 1 & _ach_status = 1
	if func('npc_editor','get_avg_relation',2) = 100 and achievements[5] = 0: achievements[5] = 1 & _ach_status = 1
	if achiev['talk,3'] >= 25 and achievements[6] = 0: achievements[6] = 1 & _ach_status = 1
	if achiev['talk,3'] >= 75 and achievements[7] = 0: achievements[7] = 1 & _ach_status = 1
	if achiev['talk,3'] >= 150 and achievements[8] = 0: achievements[8] = 1 & _ach_status = 1
	if achiev['talk,4'] >= 25 and achievements[9] = 0: achievements[9] = 1 & _ach_status = 1
	if achiev['talk,4'] >= 75 and achievements[10] = 0: achievements[10] = 1 & _ach_status = 1
	if achiev['talk,4'] >= 150 and achievements[11] = 0: achievements[11] = 1 & _ach_status = 1
	if achiev['talk,2'] >= 25 and achievements[12] = 0: achievements[12] = 1 & _ach_status = 1
	if achiev['talk,2'] >= 75 and achievements[13] = 0: achievements[13] = 1 & _ach_status = 1
	if achiev['talk,2'] >= 150 and achievements[14] = 0: achievements[14] = 1 & _ach_status = 1
	if achiev['talk,1'] >= 25 and achievements[15] = 0: achievements[15] = 1 & _ach_status = 1
	if achiev['talk,1'] >= 75 and achievements[16] = 0: achievements[16] = 1 & _ach_status = 1
	if achiev['talk,1'] >= 150 and achievements[17] = 0: achievements[17] = 1 & _ach_status = 1
	if vnesh > 90 and achievements[18] = 0: achievements[18] = 1 & _ach_status = 1
	if achiev['cloth,7'] >= 5 and achievements[19] = 0: achievements[19] = 1 & _ach_status = 1
	if palto = 3 and achievements[20] = 0: achievements[20] = 1 & _ach_status = 1
	if tattoo['lip'] > 0 and tattoo['shoulder'] > 0 and tattoo['back'] > 0 and tattoo['waist'] > 0 and tattoo['vag'] > 0 and tattoo['leg'] > 0 and achievements[21] = 0: achievements[21] = 1 & _ach_status = 1
	if (pirsA + pirsB + pirsC + pirsD + pirsE + pirsF + pirsN + pirsG) >= 5 and achievements[22] = 0: achievements[22] = 1 & _ach_status = 1
	if achievements[21] = 1 and achievements[22] = 1 and achiev['start'] = 0 and achievements[23] = 0: achievements[23] = 1 & _ach_status = 1
	!...
	! выводим сообщение о новых открытых, если надо
	if _ach_status > 0:
		gs 'zz_funcs','message','images/common/icons/award.png','Открыто новое достижение!'
	end
	killvar '_ach_status'
end
! процедура очистки временных массивов и переменных
if $args[0] = 'clear_ach_variables':
	killvar '_ach_status'
	killvar '_ach_count'
	killvar '$_ach'
	killvar '$_ach_str'
	killvar '_ach_i'
	killvar '$_ach_group'
	killvar '$_ach_group_names'
end
! верстка странички достижений
if $args[0] = 'ach_page':
	! инициализируем массив описаний достижений
	killvar '$_ach'
	gs 'zz_funcs','colorize_day'
	gs 'zz_achievements','init_array'
	!--
	_ach_i = 0
	$_ach_img = 'images/common/achievements/'
	$_ach_group[0] = ''
	$_ach_group[1] = ''
	$_ach_group[2] = ''
	$_ach_group[3] = ''
	$_ach_group[4] = ''
	$_ach_group[5] = ''
	:loop_achievements
	if _ach_i < arrsize('achievements'):
		_ach_group = val($_ach['<<_ach_i>>,group'])
		$_ach_group[_ach_group] += '<div '+iif(achievements[_ach_i] = 1,'title="'+$_ach['<<_ach_i>>,desc']+'"','')+' class="achievement' + iif(achievements[_ach_i] = 0,'-disabled',' tip') + '" ' +iif(achievements[_ach_i] = 0,'','style="background:url(\"'+$_ach_img + $_ach['<<_ach_i>>,img'] + '.jpg\")"') + '><div>'+ $_ach['<<_ach_i>>,name'] + '</div></div>'
		_ach_i += 1
		jump 'loop_achievements'
	end
	$_ach_group_names[0] = 'Общие достижения'
	$_ach_group_names[1] = 'Отношения и репутация'
	$_ach_group_names[2] = 'Учеба и работа'
	$_ach_group_names[3] = 'Спорт и хобби'
	$_ach_group_names[4] = 'Секс-достижения'
	$_ach_group_names[5] = 'Специальные достижения'
	! разбиваем страничку на блоки - по группам достижений
	_ach_i = 0
	$_ach_str = ''
	:loop_achievements_page
	if _ach_i < 6:
		$_ach_str += '<div class="stat_header" onclick="javascript:toggleView(\"ach<<_ach_i>>\");">' + $_ach_group_names[_ach_i] + '</div>'
		$_ach_str += '<div id="ach<<_ach_i>>" class="ach_category"><div class="achievement-box">' + $_ach_group[_ach_i] + '</div></div>'
		_ach_i += 1
		jump 'loop_achievements_page'
	end
	$_ach_str = '<div id="achievements">' + $_ach_str + '</div>'
	gs 'zz_render','','',$_ach_str
end