if $args[0] = 'start' or $args[0] = '':
    *clr & cla
    $location_name = 'Станция метро '+iif($loc = 'south','"Южная"',iif($loc = 'center','"Центральная"','"Северная"'))
    gs 'zz_funcs', 'colorize_day'
    frost = 0
    if week < 6:
        metro_people = iif(hour < 7,0,iif(hour < 9 or hour = 13 or hour > 16 and hour < 19,2,1))
    else
        metro_people = iif(hour < 9,0,iif(hour > 12 and hour < 15 or hour > 18 and hour < 22,2,1))
    end
    gs 'stat'
    gs 'zz_render',$location_name,'common/metro/'+$loc+iif(temper >= 15,'',iif(snow = 0,'_cold','_winter'))+metro_people, iif(metro_people = 0,'На перроне практически никого нет - всего несколько пассажиров, ожидающих прибытия состава.',iif(metro_people = 1,'На станции довольно много народа - кто-то из пассажиров ждёт прибытия состава, а кто-то идёт на выход из метро, добравшись уже до места назначения.','На станции полно народа - ожидающие приближающийся состав стоят, равномерно распределившись вдоль перрона, а прибывшие к месту назначения плотной массой идут к выходу из метро.'))+'**Стоимость проезда - 30 рублей.'
    gs 'zz_render', '', '', 'Что-то привлекло ваше внимание <a href="exec:Gt ''metro_events'',''smile1''">посмотреть</a>.'
    if hour >= 12 and hour <= 22: gs 'zz_render', '', '','В метро почти постоянно играют <a href="exec:gt ''metro_events'',''musicians''">музыканты</a>, стоя в вестибюлях, в переходах и на перронах станций.'
    if workDisk = 3 and konvert = 1 and rand(0,100) >= 80: konvert = 0
    if func('zz_funcs','prepayment',2,30) = 1:
        if $loc ! 'south':
            act 'Ехать в Южный район':
                minut += iif($loc = 'north',10,5)
                $loc = 'south'
                gt 'metro', 'carriage'
            end
        end
        if $loc ! 'center':
            act 'Ехать в Центр':
                minut += 5
                $loc = 'center'
                gt 'metro', 'carriage'
            end
        end
        if $loc ! 'north':
            act 'Ехать в Северный район':
                minut += iif($loc = 'south',10,5)
                $loc = 'north'
                gt 'metro', 'carriage'
            end
        end
    end
    act 'Выйти из метро':
        minut += 5
        gt $loc
    end
end
if $ARGS[0] = 'carriage':
    *clr & cla
    $location_name = 'Вагон метро'
    if metro_people > 1 and rand(0,300) <= vnesh and cumfrot+cumface = 0 and frot_hour ! hour: gt 'metro_events', 'frot_start'
	gs 'zz_funcs', 'payment', 2, 30, 0
    gs 'stat'
    gs 'zz_render',$location_name,'common/metro/carriage/'+$loc+iif(temper >= 15,'',iif(snow = 0,'_cold','_winter'))+metro_people, iif(metro_people = 0,'В вагоне людей немного и полно свободных мест. Пассажиры убивают время, уныло разглядывая рекламу, которой увешаны стены.',iif(metro_people = 1,'В вагоне довольно много народа - практически все места заняты. Кто-то уткнулся в в телефоны и планшеты, кто-то просто разглядывает рекламу, которой увешаны стены.','Вагон набит битком. Кто смог сесть - уткнулись каждый в своё: пожилые - в книжки, молодёжь - в телефоны и планшеты. Остальные уныло пялятся на рекламу, которой заляпаны все вагоны.'))
    gs 'zz_render', '', '', 'В вагоне вы ощутили не совсем обычную обстановку <a href="exec:Gt ''metro_events'',''smile''">Осмотреться</a>.'
    if sosedQW >= 1 and week < 6 and (hour = 7 or hour = 17) and rand(0,10) > 6 and sosedMetroHour ! hour: gs 'zz_render', '', '', 'В вагоне вы замечаете вашего соседа <a href="exec:Gt ''TimofeiMetro''">Тимофея</a>.'
    if cumfrot+cumface > 0 and metro_people > 0:
        manna -= 10
        if metro_people > 1:know_frot += 1
        gs 'zz_render', '', '', '<red><b>Несколько пассажиров вылупились на вас, разглядывая сперму в которой вы перемазаны.</b></red>'
    end
    act 'Выйти из вагона': gt 'metro','start'
end