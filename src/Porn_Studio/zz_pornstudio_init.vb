! init
! порностудия
! улучшения 0-5 звезд
! studio['room,0'] - съемочная площадка
! studio['room,1'] - гримерная
! studio['room,2'] - офис
! studio['room,3'] - зона отдыха
! studio['rating'] - расчетный рейтинг популярности студии у зрителей
! studio['work_rating'] - расчетный рейтинг популярности студии у актрисс
! studio['init'] - проверка загрузки базовых массивов
! studio['upgrade'] - студия на ремонте, 0-7
! studio['upgrade_room'] - помещение в ремонте
! studio['money'] - деньги на счету студии
! studio['money_month'] - прибыль за текущий месяц
! studio['money_last_month'] - прибыль за предыдущий месяц
! studio['film_day'] - день последних съемок
studio['room,0'] = 0
studio['room,1'] = 0
studio['room,2'] = 0
studio['room,3'] = 0
!---
studio['film_day'] = 0
studio['rating'] = 0
studio['work_rating'] = 0
studio['init'] = 1
studio['upgrade'] = 0
studio['upgrade_room'] = -1
studio['money'] = 100000
studio['money_month'] = 0
studio['money_last_month'] = 0
!---
! жанры фильмов, всего 10
$film_genre['0,name'] = 'solo'
$film_genre['1,name'] = 'lesbo'
$film_genre['2,name'] = 'sex'
$film_genre['3,name'] = 'ffm/mmf'
$film_genre['4,name'] = 'anal'
$film_genre['5,name'] = 'dp'
$film_genre['6,name'] = 'orgy'
$film_genre['7,name'] = 'orgy dp'
$film_genre['8,name'] = 'orgy dap'
$film_genre['9,name'] = 'hard-orgy (dp,dap,tap)'
!--
! названия фильмов в зависимоти от жанра
$film_genre['0,filmname'] = 'Hot Pussy'
$film_genre['1,filmname'] = 'Pink On Pink'
$film_genre['2,filmname'] = 'Hardcore Vibes'
$film_genre['3,filmname'] = 'The Young & The Beautiful'
$film_genre['4,filmname'] = 'Butt Fuck Me'
$film_genre['5,filmname'] = 'DP Mania'
$film_genre['6,filmname'] = 'Teenage Gangbang Party'
$film_genre['7,filmname'] = 'Teens Want Double'
$film_genre['8,filmname'] = 'Hard Double Anal'
$film_genre['9,filmname'] = 'Double Anal Festival'
!--
! рабочие индексы для номеров в серии фильмов
$film_genre['0,index'] = 0
$film_genre['1,index'] = 0
$film_genre['2,index'] = 0
$film_genre['3,index'] = 0
$film_genre['4,index'] = 0
$film_genre['5,index'] = 0
$film_genre['6,index'] = 0
$film_genre['7,index'] = 0
$film_genre['8,index'] = 0
$film_genre['9,index'] = 0
!--
! актриссы, общий массив, одновременно может работать масимум 10 актрисс
! actress['0,name'] - псевдоним акриссы
! actress['0,rating'] - текущий рейтинг популярности, 0-100
! actress['0,genres'] - категории фильмов, в которых согласна сниматься актрисса, 0-9, если 5 - согласна на все до dp включительно
! actress['0,age'] - возраст, 0-2, 0 - teen, 1 - teen/milf, 2 - milf
! actress['0,date'] - дата последней съемки - актрисса будет доступна минимум через [category]+1 дней (в зависимости от обустроенности зоны отдыха)
! actress['0,last_film'] - id последнего снятого фильма с актриссой
! actress['0,retire'] - уволена/закончила сниматься, 0/1
! актрисса id=0 - ГГ
$actress['0,name'] = 'Sveta'
$actress['0,rating'] = 0
$actress['0,genres'] = 9
$actress['0,age'] = 0
$actress['0,date'] = -1
$actress['0,last_film'] = -1
$actress['0,hired'] = 1
$actress['0,retire'] = 0
!--
$actress['1,name'] = 'Bambi'
$actress['1,rating'] = 0
$actress['1,genres'] = 1
$actress['1,age'] = 0
$actress['1,date'] = -1
$actress['1,last_film'] = -1
$actress['1,hired'] = 0
$actress['1,retire'] = 0
!--
$actress['2,name'] = 'Foxy'
$actress['2,rating'] = 0
$actress['2,genres'] = 4
$actress['2,age'] = 0
$actress['2,date'] = -1
$actress['2,last_film'] = -1
$actress['2,hired'] = 0
$actress['2,retire'] = 0
!--
$actress['3,name'] = 'Ivana'
$actress['3,rating'] = 0
$actress['3,genres'] = 7
$actress['3,age'] = 0
$actress['3,date'] = -1
$actress['3,last_film'] = -1
$actress['3,hired'] = 0
$actress['3,retire'] = 0
!--
$actress['4,name'] = 'Suzana'
$actress['4,rating'] = 0
$actress['4,genres'] = 8
$actress['4,age'] = 0
$actress['4,date'] = -1
$actress['4,last_film'] = -1
$actress['4,hired'] = 0
$actress['4,retire'] = 0
! фильмы
! $films['0,name'] - название фильма
! $films['0,date'] - дата съемок - daystart, при прокрутке читами могут быть проблемы
! $films['0,date_str'] - дата съемок в формате dd.mm.yyyy
! $films['0,rating'] - рейтинг фильма, 0-99, вывод в звездах, делим на 5
! $films['0,genre'] - жанр фильма, см.категории 0-10
! $films['0,actress'] - id актрисс, снявшихся в фильме, текстовый массив: 0,1
! $films['0,promo'] - сумма, вложенная в раскрутку фильма, 0 - 10000
! $films['0,profit'] - чистая прибыль, зависит от рейтинга фильма и рекламы
! $films['0,price'] - бюджет съемок, зависит от рейтинга актрисс и жанра фильма
! $films['0,view'] - количество просмотров
gs 'zz_pornstudio','update_info'