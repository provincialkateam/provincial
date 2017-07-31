! создание NPC
if $args[0] = 'init':
	!Счётчик секса как шлюхи в подъезде
	$npc['0,qwPodezdWhore'] = 0
	!Квест с подставой Ивана в быстроешке
	$npc['0,qwIvanPodstava'] = 0
	!Квест по быстроешке
	$npc['0,qwBistro'] = 0
	!Квест с Настей из Сити
	$npc['0,qwNastya'] = 0
	!Квест по устройству в Логистику
	$npc['0,qwLogistika'] = 0
	! npc
	$npc['1,name'] = 'Дима'
	$npc['1,surname'] = 'Носов'
	$npc['1,nickname'] = ''
	$npc['1,relation'] = 40
	$npc['1,group'] = 3
	$npc['1,dick'] = 16
	$npc['1,sex'] = 0
	$npc['1,silavag'] = 1
	$npc['1,know'] = 1
	!Квест по съёмкам фильма с ГГ
	$npc['1,qwDimaFilm'] = 0
	!Квест с предлогом для минета Димы
	$npc['1,qwDimaRude'] = 0
	!Месть Носову
	$npc['1,qwNosovRevenge'] = 0
	!--
	$npc['2,name'] = 'Артём'
	$npc['2,surname'] = 'Чеботарёв'
	$npc['2,nickname'] = ''
	$npc['2,relation'] = 40
	$npc['2,group'] = 1
	$npc['2,dick'] = 16
	$npc['2,sex'] = 0
	$npc['2,silavag'] = 0
	$npc['2,know'] = 1
	!Квест по отношениям с Артёмом
	$npc['2,qwartem'] = 0
	!Квест по сексу Артёма и Пети с ГГ
	$npc['2,qwArtomAndPetja'] = 0
	!Квест на просьбу Артёму украсть видео с ГГ от Носова
	$npc['2,qwArtemHack'] = 0
	!--
	$npc['3,name'] = 'Иван'
	$npc['3,surname'] = 'Прохоров'
	$npc['3,nickname'] = ''
	$npc['3,relation'] = 40
	$npc['3,group'] = 2
	$npc['3,dick'] = 17
	$npc['3,sex'] = 0
	$npc['3,silavag'] = 2
	$npc['3,know'] = 1
	!Квест с Иваном в душе
	$npc['3,qwIvanShower'] = 0
	!Квест бой Ивана с Котовым
	$npc['3,qwKotovVsProhorov'] = 0
	!--
	$npc['4,name'] = 'Игорь'
	$npc['4,surname'] = 'Круглов'
	$npc['4,nickname'] = ''
	$npc['4,relation'] = 40
	$npc['4,group'] = 3
	$npc['4,dick'] = 10
	$npc['4,sex'] = 0
	$npc['4,silavag'] = 0
	$npc['4,know'] = 1
	!Отношения с Игорем
	$npc['4,qwIgorLove'] = 0
	!Ивент с Игорем
	$npc['4,qwIgorMain'] = 0
	!Ивент с Игорем и Носовым
	$npc['4,qwMeetDiana'] = 0
	!--
	$npc['5,name'] = 'Федор'
	$npc['5,surname'] = 'Козлов'
	$npc['5,nickname'] = ''
	$npc['5,relation'] = 40
	$npc['5,group'] = 2
	$npc['5,dick'] = 16
	$npc['5,sex'] = 0
	$npc['5,silavag'] = 0
	$npc['5,know'] = 1
	!--
	$npc['6,name'] = 'Петя'
	$npc['6,surname'] = 'Клюев'
	$npc['6,nickname'] = ''
	$npc['6,relation'] = 40
	$npc['6,group'] = 1
	$npc['6,dick'] = 14
	$npc['6,sex'] = 0
	$npc['6,silavag'] = 0
	$npc['6,know'] = 1
	!--
	$npc['7,name'] = 'Алексей'
	$npc['7,surname'] = 'Царев'
	$npc['7,nickname'] = 'Лошик'
	$npc['7,relation'] = 40
	$npc['7,group'] = 0
	$npc['7,dick'] = 21
	$npc['7,sex'] = 0
	$npc['7,silavag'] = 0
	$npc['7,know'] = 1
	!--
	$npc['8,name'] = 'Святослав'
	$npc['8,surname'] = 'Воинов'
	$npc['8,nickname'] = ''
	$npc['8,relation'] = 40
	$npc['8,group'] = 2
	$npc['8,dick'] = 16
	$npc['8,sex'] = 0
	$npc['8,silavag'] = 0
	$npc['8,know'] = 1
	$npc['8,name'] = 'Святослав'
	$npc['8,surname'] = 'Воинов'
	$npc['8,nickname'] = 'Свят'
	$npc['8,relation'] = 40
	$npc['8,group'] = 2
	$npc['8,dick'] = 16
	$npc['8,sex'] = 0
	$npc['8,silavag'] = 0
	$npc['8,know'] = 1
	!--
	$npc['9,name'] = 'Витёк'
	$npc['9,surname'] = 'Котов'
	$npc['9,nickname'] = 'Кот'
	$npc['9,relation'] = 40
	$npc['9,group'] = 4
	$npc['9,dick'] = 18
	$npc['9,sex'] = 0
	$npc['9,silavag'] = 2
	$npc['9,know'] = 1
	!Квест по отношениям с Котовым
	$npc['9,qwKotovLove'] = 0
	!--
	$npc['10,name'] = 'Денис'
	$npc['10,surname'] = 'Рыжов'
	$npc['10,nickname'] = 'Дэн'
	$npc['10,relation'] = 40
	$npc['10,group'] = 4
	$npc['10,dick'] = 17
	$npc['10,sex'] = 0
	$npc['10,silavag'] = 0
	$npc['10,know'] = 1
	!--
	$npc['11,name'] = 'Вася'
	$npc['11,surname'] = 'Шульгин'
	$npc['11,nickname'] = 'Васян'
	$npc['11,relation'] = 40
	$npc['11,group'] = 4
	$npc['11,dick'] = 16
	$npc['11,sex'] = 0
	$npc['11,silavag'] = 0
	$npc['11,know'] = 1
	!--
	$npc['12,name'] = 'Юля'
	$npc['12,surname'] = 'Милова'
	$npc['12,nickname'] = ''
	$npc['12,relation'] = 40
	$npc['12,group'] = 1
	$npc['12,dick'] = 0
	$npc['12,sex'] = 0
	$npc['12,know'] = 1
	!Квест с разговорами о сексе
	$npc['12,qwTalkSexJulia'] = 0
	!--
	$npc['13,name'] = 'Лариска'
	$npc['13,surname'] = 'Груздева'
	$npc['13,nickname'] = ''
	$npc['13,relation'] = 40
	$npc['13,group'] = 2
	$npc['13,dick'] = 0
	$npc['13,sex'] = 0
	$npc['13,know'] = 1
	!--
	$npc['14,name'] = 'Катя'
	$npc['14,surname'] = 'Мейнольд'
	$npc['14,nickname'] = ''
	$npc['14,relation'] = 40
	$npc['14,group'] = 3
	$npc['14,dick'] = 0
	$npc['14,sex'] = 0
	$npc['14,know'] = 1
	! Катя в городке
	$npc['14,homeward'] = 1
	!Квест с Катей Мейнольд
	$npc['14,qwKatya'] = 0
	!--
	$npc['15,name'] = 'Вика'
	$npc['15,surname'] = 'Мейнольд'
	$npc['15,nickname'] = 'Рыжик'
	$npc['15,relation'] = 40
	$npc['15,group'] = 3
	$npc['15,dick'] = 0
	$npc['15,sex'] = 0
	$npc['15,know'] = 1
	!Квест с Викой Мейнольд
	$npc['15,qwVika'] = 0
	!--
	$npc['16,name'] = 'Наташа'
	$npc['16,surname'] = 'Белова'
	$npc['16,nickname'] = 'Белка'
	$npc['16,relation'] = 40
	$npc['16,group'] = 1
	$npc['16,dick'] = 0
	$npc['16,sex'] = 0
	$npc['16,know'] = 1
	!Квест с долгом Беловой
	$npc['16,qwNatashaDolg'] = 0
	!--
	$npc['17,name'] = 'Инна'
	$npc['17,surname'] = 'Девятова'
	$npc['17,nickname'] = 'Девятка'
	$npc['17,relation'] = 40
	$npc['17,group'] = 3
	$npc['17,dick'] = 0
	$npc['17,sex'] = 0
	$npc['17,know'] = 1
	!--
	$npc['18,name'] = 'Кристина'
	$npc['18,surname'] = 'Зверева'
	$npc['18,nickname'] = ''
	$npc['18,relation'] = 40
	$npc['18,group'] = 2
	$npc['18,dick'] = 0
	$npc['18,sex'] = 0
	$npc['18,know'] = 1
	!Квест с побитием Зверевой
	$npc['18,qwZverevaSlut'] = 0
	!--
	$npc['19,name'] = 'Лина'
	$npc['19,surname'] = 'Старова'
	$npc['19,nickname'] = ''
	$npc['19,relation'] = 40
	$npc['19,group'] = 2
	$npc['19,dick'] = 0
	$npc['19,sex'] = 0
	$npc['19,know'] = 1
	!--
	$npc['20,name'] = 'Лена'
	$npc['20,surname'] = 'Котова'
	$npc['20,nickname'] = ''
	$npc['20,relation'] = 40
	$npc['20,group'] = 4
	$npc['20,dick'] = 0
	$npc['20,sex'] = 0
	$npc['20,know'] = 1
	!--
	$npc['21,name'] = 'Лера'
	$npc['21,surname'] = 'Царева'
	$npc['21,nickname'] = ''
	$npc['21,relation'] = 40
	$npc['21,group'] = 4
	$npc['21,dick'] = 0
	$npc['21,sex'] = 0
	$npc['21,know'] = 1
	!--
	$npc['22,name'] = 'Бэлла'
	$npc['22,surname'] = 'Артамонова'
	$npc['22,nickname'] = ''
	$npc['22,relation'] = 40
	$npc['22,group'] = 2
	$npc['22,dick'] = 0
	$npc['22,sex'] = 0
	$npc['22,know'] = 1
	!--
	$npc['23,name'] = 'Альбина'
	$npc['23,surname'] = 'Барловская'
	$npc['23,nickname'] = ''
	$npc['23,relation'] = 40
	$npc['23,group'] = 3
	$npc['23,dick'] = 0
	$npc['23,sex'] = 0
	$npc['23,know'] = 1
	!--
	$npc['24,name'] = 'Полина'
	$npc['24,surname'] = 'Себаготулина'
	$npc['24,nickname'] = ''
	$npc['24,relation'] = 40
	$npc['24,group'] = 4
	$npc['24,dick'] = 0
	$npc['24,sex'] = 0
	$npc['24,know'] = 1
	!--
	$npc['25,name'] = 'Соня'
	$npc['25,surname'] = 'Иванько'
	$npc['25,nickname'] = ''
	$npc['25,relation'] = 40
	$npc['25,group'] = 0
	$npc['25,dick'] = 0
	$npc['25,sex'] = 0
	$npc['25,know'] = 1
	!Квест с Соней по рукам
	$npc['25,qwSonya'] = 0
	!-- Школьный учитель в Павлово
	$npc['26,name'] = 'Анатолий Евгеньевич'
	$npc['26,surname'] = 'Царёв'
	$npc['26,nickname'] = 'Онотоле'
	$npc['26,relation'] = 40
	$npc['26,group'] = 5
	$npc['26,dick'] = 15
	$npc['26,sex'] = 0
	$npc['26,silavag'] = 1
	$npc['26,know'] = 1
	!-- друг сестры
	$npc['27,name'] = 'Александр'
	$npc['27,surname'] = 'Лобов'
	$npc['27,nickname'] = 'Рекс'
	$npc['27,relation'] = 40
	$npc['27,group'] = 6
	$npc['27,dick'] = 15
	$npc['27,sex'] = 0
	$npc['27,silavag'] = 1
	$npc['27,know'] = 0
	!-- тренер местной команды по волейболу в Павлово
	$npc['28,name'] = 'Михаил Николаевич'
	$npc['28,surname'] = 'Власов'
	$npc['28,nickname'] = ''
	$npc['28,relation'] = 40
	$npc['28,group'] = 6
	$npc['28,dick'] = 18
	$npc['28,sex'] = 0
	$npc['28,silavag'] = 2
	$npc['28,know'] = 0
	!--Вера - кассирша на Вокзале в Павлово
	$npc['29,name'] = 'Вера'
	$npc['29,surname'] = 'Царева'
	$npc['29,nickname'] = ''
	$npc['29,relation'] = 40
	$npc['29,group'] = 6
	$npc['29,dick'] = 0
	$npc['29,sex'] = 0
	$npc['29,know'] = 0
	! флаг болтовни с Верой
	$npc['29,talk_day'] = 0
	! история Веры
	$npc['29,qwVeraStory'] = 0
	!-- Барменша в Сити с членом
	$npc['30,name'] = 'Евгения'
	$npc['30,surname'] = 'Долина'
	$npc['30,nickname'] = 'Женя'
	$npc['30,relation'] = 40
	$npc['30,group'] = 8
	$npc['30,dick'] = 17
	$npc['30,sex'] = 0
	$npc['30,silavag'] = 1
	$npc['30,know'] = 0
	!--
	$npc['31,name'] = 'Татьяна'
	$npc['31,surname'] = 'Агузарова'
	$npc['31,nickname'] = 'Таня'
	$npc['31,relation'] = 40
	$npc['31,group'] = 8
	$npc['31,dick'] = 0
	$npc['31,sex'] = 0
	$npc['31,know'] = 0
	! квест с Таней
	$npc['31,qwTanyaMain'] = 0
	!-- Владелец секс-шопа в Сити
	$npc['32,name'] = 'Пётр'
	$npc['32,surname'] = 'Кироров'
	$npc['32,nickname'] = 'Питер'
	$npc['32,relation'] = 40
	$npc['32,group'] = 8
	$npc['32,dick'] = 0
	$npc['32,sex'] = 0
	$npc['32,silavag'] = 2
	$npc['32,know'] = 0
	!--
	$npc['33,name'] = 'Катя'
	$npc['33,surname'] = ''
	$npc['33,nickname'] = '"Кэт"'
	$npc['33,relation'] = 40
	$npc['33,group'] = 8
	$npc['33,dick'] = 0
	$npc['33,sex'] = 0
	$npc['33,know'] = 0
	!--
	$npc['34,name'] = 'Гиви Карапетович'
	$npc['34,surname'] = ''
	$npc['34,nickname'] = 'Карпетыч'
	$npc['34,relation'] = 40
	$npc['34,group'] = 8
	$npc['34,dick'] = 20
	$npc['34,sex'] = 0
	$npc['34,silavag'] = 2
	$npc['34,know'] = 0
	!--Отчим
	$npc['35,name'] = 'Владимир'
	$npc['35,surname'] = 'Скрябин'
	$npc['35,nickname'] = 'Отчим'
	$npc['35,relation'] = 40
	$npc['35,group'] = 5
	$npc['35,dick'] = 20
	$npc['35,sex'] = 0
	$npc['35,silavag'] = 1
	$npc['35,know'] = 1
	!Квест по развращению отчима
	$npc['35,qwOtchim'] = 0
	!--Сосед с 3 этажа в Павлово
	$npc['36,name'] = 'Сергей'
	$npc['36,surname'] = 'Шульгин'
	$npc['36,nickname'] = ''
	$npc['36,relation'] = 40
	$npc['36,group'] = 9
	$npc['36,dick'] = 20
	$npc['36,sex'] = 0
	$npc['36,silavag'] = 2
	$npc['36,know'] = 1
	!--Мать
	$npc['37,name'] = 'Наталья'
	$npc['37,surname'] = 'Лебедева'
	$npc['37,nickname'] = 'Мать'
	$npc['37,relation'] = 40
	$npc['37,group'] = 5
	$npc['37,dick'] = 0
	$npc['37,sex'] = 0
	$npc['37,know'] = 1
	!Квест с матерью и переход в Олу
	$npc['37,qwMother'] = 0
	!--Сестра
	$npc['38,name'] = 'Аня'
	$npc['38,surname'] = 'Лебедева'
	$npc['38,nickname'] = 'Сестра'
	$npc['38,relation'] = 40
	$npc['38,group'] = 5
	$npc['38,dick'] = 0
	$npc['38,sex'] = 0
	$npc['38,know'] = 1
	!разговор с сестрой про Рекса
	$npc['38,qwRexSisTalk'] = 0
	!квест с парнем сестры
	$npc['38,qwSisterBoy'] = 0
	!переход квеста с парнем сестры в тройник
	$npc['38,qwSisterTrio'] = 0
	!переход квеста с парнем сестры в лесбиянство
	$npc['38,qwSisterLesbi'] = 0
	!--Брат младший
	$npc['39,name'] = 'Николай'
	$npc['39,surname'] = 'Скрябин'
	$npc['39,nickname'] = 'Колька'
	$npc['39,relation'] = 40
	$npc['39,group'] = 5
	$npc['39,dick'] = 15
	$npc['39,sex'] = 0
	$npc['39,silavag'] = 0
	$npc['39,know'] = 1
	!Квест по просмотру порно с братцем вместо футбола
	$npc['39,qwPornoFootball'] = 0
	!Квест по Кольке-принцу brother['KolkaPrince']
	$npc['39,qwKolkaPrince'] = 0
	!Квест по показу голого тела Кольке
	$npc['39,qwBrotherNude'] = 0
	!-- Артур продавец на рынке в Павлово
	$npc['40,name'] = 'Артур'
	$npc['40,surname'] = ''
	$npc['40,nickname'] = ''
	$npc['40,relation'] = 40
	$npc['40,group'] = 9
	$npc['40,dick'] = 25
	$npc['40,sex'] = 0
	$npc['40,silavag'] = 2
	$npc['40,know'] = 0
	!Квест по устройству на работу к Артуру
	$npc['40,qwArtur'] = 0
	!-- Каталкин мент на вокзале Павлово
	$npc['41,name'] = 'Алексей'
	$npc['41,surname'] = 'Каталкин'
	$npc['41,nickname'] = 'Катала'
	$npc['41,relation'] = 40
	$npc['41,group'] = 9
	$npc['41,dick'] = 15
	$npc['41,sex'] = 0
	$npc['41,silavag'] = 1
	$npc['41,know'] = 0
	!-- дядя Миша с 3 этажа в Павлово
	$npc['42,name'] = 'Михаил Александрович'
	$npc['42,surname'] = 'Гробов'
	$npc['42,nickname'] = 'дядя Миша'
	$npc['42,relation'] = 40
	$npc['42,group'] = 9
	$npc['42,dick'] = 15
	$npc['42,sex'] = 0
	$npc['42,silavag'] = 1
	$npc['42,know'] = 1
	!Квест по сексу с Мишей
	$npc['42,qwDyadyaMisha'] = 0
	!-- биологический отец
	$npc['43,name'] = 'Михаил'
	$npc['43,surname'] = 'Лебедев'
	$npc['43,nickname'] = ''
	$npc['43,relation'] = 40
	$npc['43,group'] = 9
	$npc['43,dick'] = 15
	$npc['43,sex'] = 0
	$npc['43,silavag'] = 2
	$npc['43,know'] = 0
	!Квест про встречу с биологическим отцом - больше похоже на отношения
	$npc['43,qwBioOtec'] = 0
	!вторая часть по биотцу - надо переделать
	$npc['43,qwBioOtec2'] = 0
	!-- Ирина из Сити кафе с Гиви
	$npc['44,name'] = 'Ирина'
	$npc['44,surname'] = 'Пугач'
	$npc['44,nickname'] = ''
	$npc['44,relation'] = 40
	$npc['44,group'] = 8
	$npc['44,dick'] = 0
	$npc['44,sex'] = 0
	$npc['44,know'] = 0
	!Квест развитие лесбиянства с Ириной
	$npc['44,qwIrina'] = 0
	!Квест про шлюхловатость Ирины
	$npc['44,qwIrinaSlut'] = 0
	!-- Тамара Михайловна Мейнольд --!
	$npc['45,name'] = 'Тамара Михайловна'
	$npc['45,surname'] = 'Мейнольд'
	$npc['45,nickname'] = ''
	$npc['45,relation'] = 40
	$npc['45,group'] = 9
	$npc['45,dick'] = 0
	$npc['45,sex'] = 0
	$npc['45,know'] = 0
	!--
	$npc['46,name'] = 'Ашот'
	$npc['46,surname'] = ''
	$npc['46,nickname'] = ''
	$npc['46,relation'] = 40
	$npc['46,group'] = 8
	$npc['46,dick'] = 20
	$npc['46,sex'] = 0
	$npc['46,silavag'] = 2
	$npc['46,know'] = 0
	!--
	$npc['47,name'] = 'Вика'
	$npc['47,surname'] = 'Кирилова'
	$npc['47,nickname'] = ''
	$npc['47,relation'] = 40
	$npc['47,group'] = 8
	$npc['47,dick'] = 0
	$npc['47,sex'] = 0
	$npc['47,know'] = 0
	npc_arrsize = 48
	! потенциальные бойфренды - в списки не добавляем, номера 200-399, автогенерация
	! 200 - 299 - павловские
	! 300 - 399 - городские
	_npc_i = 200
	:loop_npc_boys
	if _npc_i < 399:
		$_name_arr = 'Саша,Леша,Коля,Петя,Вася,Гоша,Миша,Дэн,Паша,Гена,Дима,Славик,Виталик,Валера,Ваня,Серега,Андрей'
		$npc['<<_npc_i>>,name'] = func('zz_funcs','get_item_string',$_name_arr,-1)
		$npc['<<_npc_i>>,surname'] = ''
		$npc['<<_npc_i>>,nickname'] = ''
		$npc['<<_npc_i>>,relation'] = 40
		$npc['<<_npc_i>>,group'] = iif(_npc_i < 300,6,8)
		$npc['<<_npc_i>>,dick'] = rand(12,18)
		$npc['<<_npc_i>>,sex'] = 0
		$npc['<<_npc_i>>,know'] = 0
		$npc['<<_npc_i>>,silavag'] = rand(0,2)
		! последний день встречи
		$npc['<<_npc_i>>,meet_day'] = 0
		! переменная, отвечающая за статус отношений
		! 1 - 29 - если встречаются
		! >= 30 - если уже муж
		$npc['<<_npc_i>>,boyfriend'] = 0
		! добавляем типаж и характер
		! 0 - гопник
		! 1 - обычный
		! 2 - мажористый
		$npc['<<_npc_i>>,boy_type'] = rand(0,2)
		! характер - для гопоты исключаем мягкий
		! 0 - мягкий
		! 1 - обычный
		! 2 - нахальный
		$npc['<<_npc_i>>,boy_character'] = rand(iif($npc['<<_npc_i>>,boy_type']=0,1,0),2)
		! отношение парня к секс-экспериментам
		$npc['<<_npc_i>>,boy_izvrat'] = iif(rand(0,100)>80,1,0)
		! предпочения нпс
		! привлекательность ГГ
		$npc['<<_npc_i>>,boy_beauty'] = rand(40 + $npc['<<_npc_i>>,boy_type']*10,60 + $npc['<<_npc_i>>,boy_type']*10)
		! цвет волос
		! 0 - черные
		! 1 - русые
		! 2 - рыжые
		! 3 - блонди
		$npc['<<_npc_i>>,boy_haircolor'] = rand(0,3)
		! размер груди
		$npc['<<_npc_i>>,boy_tits'] = rand(0,6)
		! фигура, 0-4
		$npc['<<_npc_i>>,boy_body'] = rand(0,4)
		_npc_i += 1
		jump 'loop_npc_boys'
		killvar '_npc_i'
	end
end
! текст-описание NPC
if $args[0] = 'get_npc_text':
	if args[1] = 1: $result = 'Димка - симпатичный парень, о котором вздыхает большинство девчонок в классе.'
	if args[1] = 2: $result = 'Артём - типичный ботан и отличник.'
	if args[1] = 3: $result = 'Спортсмен, и хороший. Много времени проводит на тренировках, регулярно ездит на соревнования. Не слишком общителен, порой несколько неуклюж, медведеват, без веского повода рта лишний раз не откроет. Спокоен, даже флегматичен. Девочки в школе на него постоянно заглядываются, но встречается он только с Викой Мейнольд, что немало удивляет: они сочетаются как огонь и вода.'
	if args[1] = 4: $result = 'Стройный паренёк небольшого роста, с высоким тенорком и смазливым личиком, чем-то смахивающий на девчонку. '+iif($npc['4,qwMeetDiana'] = 12,'Игорь был застукан в образе "Дианы" своим другом Димой Носовым, поле чего отхватил от него пиздюлей. Мало того, что дружба между ними кончилась, так и еще вся школа об этом узнала.','Над ним бы издевались из за женоподобной внешности, но он водит дружбу с Димкой Носовым - “первым парнем школы” - и везде таскается за ним, и потому его не трогают. Чувствуя силу за спиной, он, как многие “шакалята”, нагловат, но с ним стараются не связываться - скорее терпят, чем приятельствуют. Друзей, кроме покровителя-Носова, у него нет.')
	if args[1] = 5: $result = 'Федька - неплохой спортсмен и лучший друг Ваньки Прохорова.'
	if args[1] = 6: $result = 'Петька - ботан и заучка, который не видит дальше учебника.'
	if args[1] = 7: $result = 'Над Лёшкой издеваются в классе все, кому не лень.'
	if args[1] = 8: $result = 'Святослав - атлетичный парень, который упорно занимается спортом.'
	if args[1] = 9: $result = 'Витёк - агрессивный, сильный и наглый гопник, который считает себя чётким пацанчиком. Но Витек туповат. Он занимается боксом, и, похоже, постоянные удары в голову ему явно на пользу не идут. У Витька есть сестра-двойняшка Лена.'
	if args[1] = 10: $result = 'Дэн - длинный и тощий парень из тусовки Витька Котова. С окружающими он общается с презрением и всегда готов разложить по понятием. Он утверждает, что знает чётких пацанов на районе, которые если что, впрягутся за него.'
	if args[1] = 11: $result = 'Васян - ваш сосед по подъезду, живущий над вами этажом выше. Он увивается вокруг Дэна и Витька, являясь по больше части их шестёркой, но старательно гнёт из себя крутого перца.'
	if args[1] = 12: $result = 'Юля - старательная и молчаливая девчонка. Круглая отличница. Она почти ни с кем не общается.'
	if args[1] = 13:
		if $npc['18,qwZverevaSlut'] = 2:
			if LariskaProfi = 1:
				$result = 'Лариска спортивная девчонка, но очень зависима от чужого мнения. Лариса очень изменилась, у нее искорки в глазах и практически всегда хорошее настроение. После вступления в команду быстро вошла в основной состав и теперь одна из лучших игроков'
			else
				$result = 'Лариска спортивная девчонка, но очень зависима от чужого мнения. Лариса очень изменилась, у нее искорки в глазах и практически всегда хорошее настроение. Хорошо играет в волейбол, но в профи идти боится, хотя ей и Михаил Николаевич, тренер команды волейболисток, уже предлагал войти в команду.'
			end
		elseif $npc['18,qwZverevaSlut'] = 1:
			$result = 'Лариска спортивная девчонка, но очень зависима от чужого мнения. После того как побили Кристину Лариска выглядит повеселевшей, но растерянной. Хорошо играет в волейбол, но в профи идти боится, хотя ей и Михаил Николаевич, тренер команды волейболисток, уже предлагал войти в команду.'
		else
			if $npc['18,qwZverevaSlut'] = 0 and lariskaQwestDay < daystart and zverRageQW = 2:
				if lariskaHelp > 0:
					$result = 'Лариска спортивная девчонка, но очень зависима от чужого мнения. После инцидента Лариска ходит мрачнее тучи и старается избегать вас. Хорошо играет в волейбол, но в профи идти боится, хотя ей и Михаил Николаевич, тренер команды волейболисток, уже предлагал войти в команду. Но говорят, что на нее сильно давит Зверева, запрещая участвовать в любых секциях, делая из нее изгоя и свою шестерку.'
				else
					$result = 'Лариска спортивная девчонка, но очень зависима от чужого мнения. После инцидента Лариска ходит мрачнее тучи и старается избегать вас. Хорошо играет в волейбол, но в профи идти боится, хотя ей и Михаил Николаевич, тренер команды волейболисток, уже предлагал войти в команду.'
				end
			else
				$result = 'Лариса - высоченная симпатичная девочка, но очень робкая и комплексующая по поводу своего роста: она выше большинства в классе. Лариса очень зависима от чужого мнения. Постоянно подавлена и заметно боится Кристину Звереву. В школе рядом с ней себя ведет ниже воды - тише травы. Хорошо играет в волейбол, но в профи идти боится, хотя ей и Михаил Николаевич, тренер команды волейболисток, уже предлагал войти в команду.'
			end
		end
	end
	if args[1] = 14: $result = 'Огненно-рыжая миниатюрная девушка, симпатичная, неглупая, но в общем-то ничем не примечательная. У неё есть сестра-близнец Вика. Вика и Катя близнецы не только внешне, но ещё и по знаку Зодиака - они родились в конце мая. Но по характеру они - как две стороны одной медали. Катя - достаточно тихая и рассудительная девочка, застенчивая, часто и густо краснеющая по любому поводу, хотя и общается вместе с сестрой в основном с “крутыми”. Катя - тихая, стеснительная, замкнутая, любящая читать, и, обычно, стоя с сестрой в компании “крутых”, лишь загадочно улыбается, думая о чём-то своём. В общении никого особо не выделяет, поддерживая со всеми ровные отношения. Она вместе с сестрой частенько тусит на дискотеке, но на фоне Вики почти незаметна. Какие тараканы бродят в Катиной хорошенькой рыжей головке - неведомо: их она никому не показывает.'
	if args[1] = 15: $result = 'Вика - прямая противоположность своей сестры: хитрожопая и бойкая девица «себе на уме». Учится хорошо. Со всеми поддерживает ровные отношения. Вика дружит с Иваном Прохоровым из вашей школы. Вика весёлая и заводная, страстно любит танцевать, и её очень часто можно встретить на дискотеке, как правило, вместе с сестрой и Ваней Прохоровым. Она обожает яркую одежду чумовых расцветок, но они ей идут: она сама яркая как фонарик и заводная как юла. Вика и Катя близнецы не только внешне, но ещё и по знаку Зодиака - они родились в конце мая. Но по характеру они - как две стороны одной медали. В детстве Вика ходила на спортивную гимнастику, и отличается отменной гибкостью. Она взбалмошная, и никогда не знаешь - что придёт ей в голову в следующий момент. Настроение у неё меняется совершенно непредсказуемо. Логика никогда не была Викиной сильной стороной: она живёт эмоциями и чувствами, а решения принимает чаще левой пяткой, а не головой, но эта её живость и непосредственность и открытая яркая улыбка очень к ней располагают.'
	if args[1] = 16: $result = 'Наташа хорошо учится и очень замкнута.'
	if args[1] = 17: $result = 'Инна - высокая девушка "фотомодельных статей", которая за милой улыбкой всегда скрывала свою заносчивость.'
	if args[1] = 18:
		if $npc['18,qwZverevaSlut'] = 2:
			$result = 'Кристина после того как отловила пиздюлей от вас, перед всей школой рассказала о том, как сосала хуй у физрука, после этого наводившая ужас на окружающих Кристина была сломлена и унижена. Также у нее нехватает зубов после неудачи с вашей подставой.'
		elseif $npc['18,qwZverevaSlut'] = 1:
			$result = 'Кристина после того как отловила пиздюлей от вас, перед всей школой рассказала о том, как сосала хуй у физрука, после этого наводившая ужас на окружающих Кристина была сломлена и унижена.'
		else
			$result = 'Кристина - рослая и сильная девушка. Она великолепная спортсменка, занимающаяся бегом. Кристина обладает лидерскими способностями, верховодя среди "спортсменок". Вместе с её упорством и умом это делает её очень серьёзной фигурой.'
		end
	end
	if args[1] = 19: $result = 'Лина - спортсменка и во всем слушается Кристину.'
	if args[1] = 20: $result = 'Ленка - сестра-двойняшка Витька Котова, агрессивного гопника, и сама недалеко ушла от брата, являясь заводилой девчонок-хулиганок.'
	if args[1] = 21: $result = 'Лера - дочь вашего учителя математики Анатолия Евгениевича. Семья небогата, и Лерка быстро связалась с Ленкой Котовой, начав курить в туалете.'
	if args[1] = 22: $result = 'Бэлла - красивая и заносчивая девушка.'
	if args[1] = 23: $result = 'Альбина из богатой семьи и всегда умела хорошо выглядеть и хорошо одеваться. Она профессионально занимается танцами и выступает в танцевальной группе "Звездушки".'
	if args[1] = 24: $result = 'У Полины как будто гвоздь в заднице, который не дает ей сидеть спокойно, она хулиганка и двоечница.'
	if args[1] = 25:
		if $npc['25,qwSonya'] >= 5:
			$result = 'Соня однажды неосторожно напилась и ее трахнули в рот по кругу Витек Котов с дружками. После этого девчонки сторонились Соню, а пацаны считали ее шлюхой. Местная гопота регулярно подкатывает к Соне с предложениями потрахаться.'
		else
			$result = 'Соня - обычная девушка, в общем-то ничем не выделяющаяся среди своих сверстниц. Симпатичная, умная, компанейская, всегда с широкой улыбкой на лице и редко бывающая в плохом настроении. Соня обожает тусовки - дома ей общения явно не хватает. Нередко она неразборчива в этом общении и рада поболтать и повеселиться  с любыми. Она склонна ко всяким авантюрам, что порой выходит ей боком.
	Живёт она с матерью в маленькой “двушке”. Отца нет. Мать - замученная жизнью, нервная,  истеричная и скандальная баба, давно переставшая следить за собой. Работает на Швейной фабрике, зарабатывает копейки. Порой выпивает, но не алкашка. С мужиками у неё не складывается, да и не общается мать с ними давно.
	Соня с детства была предоставлена сама себе. Она выросла, несмотря на тяжёлую атмосферу и постоянные скандалы дома, доброй, весёлой и общительной, неплохо учится в школе, в основном на четвёрки. О доме и о личной жизни распространяться не любит: отношения с матерью у них напряжённые. Мечтает о красивой жизни. В тусовках порой смущается своей скромной одежды, так как доход семьи невелик, но зависти к мажорным девицам вроде Барловской или Девятовой не питает. Каких-то хобби или особенных интересов не имеет - обычная симпатичная девчонка из небогатой неполной семьи, мечтающая о лучшей жизни.'
		end
	end
	if args[1] = 26: $result = 'Ваш школьный учитель математики. Строгий и требовательный. Его дочка Лера учится с вами в классе. Жена Вера работает кассиршей на ж/д вокзале.'
	if args[1] = 35: $result = 'Ваш отчим седоватый и немного обрюзгший мужик, работающий водителем. Ему ' + (age+30) + ' лет. Ваша мать развелась с вашим отцом, и вышла замуж за Владимира Михайловича когда вам был один год. Вашего настоящего отца вы не помните и никогда не видели.'
	if args[1] = 29: $result = 'Жена учителя математики Царева Анатолия Евгеньевича. Родилась где-то на севере, приехала вместе с мужем в Павлово. Работает на вокзале кассиршей. Красиво одевается, играет на гитаре. Знакомые считают их с мужем хорошей парой, но отмечают безволие Веры. В дочери души не чает, не мешает ей тусоваться с местной гопотой.'
	if args[1] = 37: $result = 'Ваша мать Наташа еще довольно молода и привлекательна. Ей всего <<motherAge>> лет. Она работает в привокзальном кафе. Недавно босс продолжил ее рабочий день до 17.00, но зато, как сказала сама мать - платить стал значительно больше.'
	if args[1] = 38: $result = 'Ваша сестра Аня немного старше вас. Ей <<sisterAge>> лет. Она закончила школу, но не сумела поступить в университет и теперь работает в магазине продавщицей.'
	if args[1] = 39: $result = 'Ваш сводный брат Колька младше вас и ему <<brotherAge>> лет. Колька, в отличие от вас с сестрой, родился уже от отчима. Он учится в той же школе, что и вы, и увлекается футболом, постоянно после школы гоняя мяч с друзьями на школьном стадионе.'
	! инфо по бойфренду
	if args[1] >= 200 and args[1] < 399:
		_npc_i = args[1]
		$_npc_str[0] = 'робким и не уверенным в себе'
		$_npc_str[1] = 'уверенным и спокойным молодым'
		$_npc_str[2] = 'дерзким и нахальным'
		$_npc_str[3] = 'дешевый спортивный костюм'
		$_npc_str[4] = 'джинсы и свитер'
		$_npc_str[5] = 'респектабельный и дорогой пиджак'
		$_npc_str[6] = 'брюнеток '
		$_npc_str[7] = 'шатенок '
		$_npc_str[8] = 'рыжеволосых '
		$_npc_str[9] = 'блондинок '
		if $npc['<<_npc_i>>,boy_body'] = 0:
			$_npc_str[10] = 'худощавых '
		elseif $npc['<<_npc_i>>,boy_body'] = 1 or $npc['<<_npc_i>>,boy_body'] = 2:
			$_npc_str[10] = 'стройных '
		else
			$_npc_str[10] = 'полненьких '
		end
		if $npc['<<_npc_i>>,boy_tits'] <= 1:
			$_npc_str[11] = 'маленькой'
		elseif $npc['<<_npc_i>>,boy_body'] = 2 or $npc['<<_npc_i>>,boy_body'] = 3:
			$_npc_str[11] = 'средней'
		elseif $npc['<<_npc_i>>,boy_body'] = 4:
			$_npc_str[11] = 'большой'
		else
			$_npc_str[11] = 'внушительной'
		end
		$result = $npc['<<_npc_i>>,name'] + ' выглядит ' + $_npc_str[val($npc['<<_npc_i>>,boy_character'])] + ' молодым человеком, одетым в ' + $_npc_str[val($npc['<<_npc_i>>,boy_type'])-3] + '.<br>'
		! после нескольких встреч открываем предпочтения бойфренда
		if $npc['<<_npc_i>>,boyfriend'] >= 3: $result += 'Предпочитает ' + $_npc_str[10] + $_npc_str[val($npc['<<_npc_i>>,boy_haircolor'])] + ' c ' + $_npc_str[11] + ' грудью.'
		killvar '$_npc_str'
		killvar '_npc_i'
	end
end
! получаем линк на NPC
if $args[0] = 'get_npc_link':
	$result = '<a href="exec:numnpc = <<args[1]>> & GT ''Snpc''">'+$npc['<<args[1]>>,name']+' '+$npc['<<args[1]>>,surname']+'</a>'
end
! получаем группу NPC
if $args[0] = 'get_npc_group':
	_npc_group = val($npc['<<args[1]>>,group'])
	if _npc_group < 0 or _npc_group > 4:
		$result = ''
		killvar '_npc_group'
		exit
	end
	$_npc_group[0] = 'одиночек'
	$_npc_group[1] = 'ботаников'
	$_npc_group[2] = 'спортиков'
	$_npc_group[3] = 'крутых'
	$_npc_group[4] = 'гопников'
	! не выводим строчку, но они есть в массиве
	!$_npc_group[5] = 'семья'
	!$_npc_group[6] = 'неписи с городка'
	!$_npc_group[7] = 'неписи с гадюкино'
	!$_npc_group[8] = 'неписи с сити'
	!$_npc_group[9] = 'неписи с Павлово'
	$result = $npc['<<args[1]>>,name'] + ' относится к группе ' + $_npc_group[_npc_group] + '.'
	killvar '$_npc_group'
end
! выводим карточку NPC
if $args[0] = 'get_npc_profile':
	_npc_id = args[1]
	$_npc_img = 'images/common/mobile'
	!msg $_img
	$_npc_info = '<center><table border=0 width=270 cellpadding=0 cellspacing=0>'
	! header
	$_npc_info += '<tr><td width=10><img src="'+$_npc_img+'/tl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_npc_img+'/tr.png"></td></tr>'
	! name
	$_npc_info += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee" align=center><b>'+ iif($npc['<<_npc_id>>,nickname'] = '',$npc['<<_npc_id>>,name']+ ' ' + $npc['<<_npc_id>>,surname'],$npc['<<_npc_id>>,nickname']) +'</b></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! image
	$_npc_info += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee"><img width=250 src="images/common/npc/<<_npc_id>>.jpg"></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! icons
	$_npc_info += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee" align=center><img align=center src="images/common/icons/relations/'+iif($npc['<<_npc_id>>,relation']>=100,4,$npc['<<_npc_id>>,relation']/20)+'.png"> '+ iif($npc['<<_npc_id>>,group']<5,'<img align=center src="images/common/icons/npc_groups/'+$npc['<<_npc_id>>,group']+'.png">','') +' <a href="exec:gs''npc_editor'',''get_npc_small_profile'',<<_npc_id>>"><img align=center src="images/common/icons/info.png"></a></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! footer
	$_npc_info += '<tr><td width=10><img src="'+$_npc_img+'/bl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_npc_img+'/br.png"></td></tr>'
	$_npc_info += '</table></center>'
	gs 'zz_render','','',$_npc_info
	killvar '$_npc_info'
	killvar '$_npc_img'
	killvar '_npc_id'
end
! создаем блок НПС в зависимости от группы
! args[0] - id группы
! args[1] - функция: 0 - нет, 1 - возвращает результат
! args[2] - разделитель: 0 - "<br>", 1 - ", "
if $args[0] = 'make_npc_group':
	i = 0
	$zz_str = ''
	:markgruploop
	i += 1
	!if args[1] = -1 and i = 18 and KotovZverHelp = 1 and daystart < lariskaQwestDay + 14: jump 'markgruploop'
	! пропуск Кати
	! 80-82 - если та свалила с дискотеки с парнем
	! 200 - уехала в сити
	if i = 14 and ($npc['14,homeward'] = 0 or ($loc = 'gdkin' and $npc['14,qwKatya'] >= 80 and $npc['14,qwKatya'] <= 82)): jump 'markgruploop'
	!--
	if $npc['<<i>>,group'] = args[1]: $zz_str += func('npc_editor','get_npc_link',i) + iif(args[3]=1,', ','<br>')
	if i < 26: jump 'markgruploop'
	! удаляем последнюю запятую, если такова есть
	if args[3] = 1:
		$zz_str = trim($zz_str)
		$zz_str = mid($zz_str,1,len($zz_str)-1)
	end
	if args[2] = 1:
		$result = $zz_str
	else
		*pl $zz_str
	end
	killvar '$zz_str'
end
! повышение/понижение отношений + уведомление
! ремейк функции @wannabee
! gs 'npc_editor','change_rep','ЧтоДелаем', НомерНПС, НаСколькоИзменяем, ПределРоста
! ЧтоДелаем: повышаем, понижаем или ничего не делаем, но выводим сообщение
! НаСколькоИзменяем - если надо изменить отношения не по формуле, а на определенное число
! ПределРоста - максимальное значение, до которого стоит повышать/понижать отношения
if $args[0] = 'change_rep':
	$_npc_change = $args[1]
	_npc_id = args[2]
	_npc_change_value = args[3]
	_npc_change_limit = args[4]
	! нулевого НПС нет - выходим
	if _npc_id <= 0: exit
	if $npc['<<_npc_id>>,know'] = 0: $npc['<<_npc_id>>,know'] = 1
	! ---
	if $_npc_change = '+' or $_npc_change = 'up':
		! повышение
		! если указано значение - изменяем на него, если нет - расчитываем по формуле
		if _npc_change_value <= 0:
			_npc_change_value = iif(vnesh<40,1,(vnesh-30)/10) +  iif(intel<50,1,intel/25) - iif(nerdism>0,iif(nerdism<20,1,2),0)
		end
		! проверяем лимит
		if _npc_change_limit > 0:
			if _npc_change_limit - $npc['<<_npc_id>>,relation'] < 0:
				! если текущие отношения уже выше границы - игнорируем ее
				$npc['<<_npc_id>>,relation'] += _npc_change_value
			else
				! если превысили границу - понижаем
				$npc['<<_npc_id>>,relation'] += _npc_change_value
				if $npc['<<_npc_id>>,relation'] > _npc_change_limit: $npc['<<_npc_id>>,relation'] = _npc_change_limit
			end
		end
		$npc['<<_npc_id>>,relation'] += _npc_change_value
		! проверяем границы диапазона отношений 0-100
		if $npc['<<_npc_id>>,relation'] > 100: $npc['<<_npc_id>>,relation'] = 100
		! выводим сообщение
		gs 'npc_editor','message',iif($npc['<<_npc_id>>,relation']=100,'max','up')
	elseif $_npc_change = '-' or $_npc_change = 'down':
		! понижение
		if _npc_change_value <= 0: _npc_change_value = $npc['<<_npc_id>>,relation'] / 10
		$npc['<<_npc_id>>,relation'] -= _npc_change_value
		! проверяем границы диапазона отношений 0-100
		if $npc['<<_npc_id>>,relation'] <= 0: $npc['<<_npc_id>>,relation'] = 0
		! выводим сообщение
		gs 'npc_editor','message','down'
	else
		! выводим сообщение о неизменности отношений
		gs 'npc_editor','message','neutral'
	end
	! ---
	killvar '$_npc_change'
	killvar '_npc_id'
	killvar '_npc_change_value'
	killvar '_npc_change_limit'
end
if $args[0] = 'message':
	if $args[1] = 'up': $rep_str = 'улучшены'
	if $args[1] = 'down': $rep_str = 'ухудшились'
	if $args[1] = 'max': $rep_str = 'максимальны'
	if $args[1] = 'neutral': $rep_str = 'не изменились'
	nl '<table border=0 width=250 align=center cellspacing=0 cellpadding=0><tr><td width=17><img src="images/common/icons/left.png"></td><td bgcolor="#eeeeee" align=center><img src="images/common/icons/'+$args[1]+'.png"></td><td bgcolor="#eeeeee"></td><td bgcolor="#eeeeee"><font face=calibri><i>Отношения '+$rep_str+'</i></font></td><td width=17><img src="images/common/icons/right.png"></td></tr></table>'
	killvar '$rep_str'
end
! функция по номеру NPC подставляет имя и размеры
if $args[0] = 'init_sex':
	! args[1] - npc_id
	$boy = $npc['<<args[1]>>,name']
	if $npc['<<args[1]>>,dick'] = 0:
		!Страпон у НПС женского пола
		dick = 15
		silavag = rand(0,2)
	else
		dick = $npc['<<args[1]>>,dick']
		silavag = $npc['<<args[1]>>,silavag']
	end
end
! выводим список всех отношений с НПС
if $args[0] = 'relation_list':
	i = 1
	:loop_relation_list
	pl func('zz_funcs','scale',val($npc['<<i>>,relation']),100) + ' ' + $npc['<<i>>,name'] + ' ' + $npc['<<i>>,surname']
	i += 1
	if i < npc_arrsize: jump 'loop_relation_list'
end
! ---
! вывод инфо по НПС
! общая таблица - все НПС
if $args[0] = 'get_npc_list':
	*clr
	$_npc_list = '<center><table border=0 cellpadding=0 cellspacing=10 width=800 align=center valign=top>'
	i = 1
	:loop_npc_list
		j = 0
		$_npc_list += '<tr>'
		! в строчку выводим по 5 колонок
		:loop_cols
			$_npc_list += '<td width=150>' + iif(i < npc_arrsize,func('npc_editor','npc_box',i),'') + '</td>'
			i += 1
			j += 1
			if j < 5: jump 'loop_cols'
		$_npc_list += '</tr>'
		!$_npc_list += '<tr><td colspan=9>&nbsp;</td></tr>'
	if i < npc_arrsize: jump 'loop_npc_list'
	$_npc_list += '</table></center>'
	gs 'zz_render','','',$_npc_list
	killvar '$_npc_list'
	act 'Закрыть': gt $loc,$metka
end
! табличка отдельного НПС
if $args[0] = 'npc_box':
	_npc_id = args[1]
	$_npc_img = 'images/common/mobile'
	!msg $_img
	$result = '<table border=0 width=130 cellpadding=0 cellspacing=0>'
	! header
	$result += '<tr><td width=10><img src="'+$_npc_img+'/tl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_npc_img+'/tr.png"></td></tr>'
	! image
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee"><a href="exec:gs''npc_editor'',''get_npc_small_profile'',<<_npc_id>>"><img width=130 src="images/common/npc/'+iif($npc['<<_npc_id>>,know']>0,_npc_id,0)+'.jpg"></a></td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! text
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee" align=center>'+iif($npc['<<_npc_id>>,know']>0,$npc['<<_npc_id>>,name'],'<br>')+'</td><td width=10 bgcolor="#eeeeee"></td></tr>'
	$result += '<tr><td width=10 bgcolor="#eeeeee"></td><td bgcolor="#eeeeee" align=center>'+iif($npc['<<_npc_id>>,know']>0,$npc['<<_npc_id>>,surname'],'<br>')+'</td><td width=10 bgcolor="#eeeeee"></td></tr>'
	! footer
	$result += '<tr><td width=10><img src="'+$_npc_img+'/bl.png"></td><td bgcolor="#eeeeee"></td><td width=10><img src="'+$_npc_img+'/br.png"></td></tr>'
	$result += '</table>'
	killvar '$_npc_img'
	killvar '_npc_id'
end
if $args[0] = 'get_npc_small_profile':
	clr
	_npc_id = args[1]
	if $npc['<<_npc_id>>,know'] = 0: exit
	$_npc_profile = '<tr><td align=center>' + func('zz_funcs','make_image_box','images/common/npc/'+_npc_id+'.jpg',240) + '</td></tr>'
	$_npc_profile += '<tr><td bgcolor=#efefef align=center><b>' + $npc['<<_npc_id>>,name'] + ' ' + $npc['<<_npc_id>>,surname'] + '</b></td></tr>'
	$_npc_profile += '<tr><td bgcolor=#efefef valign=middle><img height=16 src="images/common/icons/relations/'+iif($npc['<<_npc_id>>,relation']>=100,4,$npc['<<_npc_id>>,relation']/20)+'.png"> ' + func('zz_funcs','relations',$npc['<<_npc_id>>,relation']) + '</td></tr>'
	$_npc_profile += '<tr><td bgcolor=#efefef valign=middle>' + iif($npc['<<_npc_id>>,group']<5,'<img height=16 src="images/common/icons/npc_groups/'+$npc['<<_npc_id>>,group']+'.png"> ','') + func('npc_editor','get_npc_group',_npc_id) + '</td></tr>'
	$_npc_profile += '<tr><td>' + func('npc_editor','get_npc_text',_npc_id) + '</td></tr>'
	$_npc_profile = '<center><table cellpadding=0 cellspacing=3>' + $_npc_profile + '</center>'
	pl $_npc_profile
	killvar '$_npc_profile'
	killvar '_npc_id'
end