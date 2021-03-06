﻿$loc = $curloc
if $args[0] = '' or $args[0] = 'main':
    *clr & cla
    $metka = $args[0]
    gs 'stat'
    gs 'time'
    gs 'zz_render','Зоопарк','common/park/zoo/zoo_summer','Городской зоопарк, расположенный в парке Победы.'+iif(hour >= 10 and hour <= 20,'**У входа в зоопарк в рабочее время стоит <a href="exec:gt''zoo'',''coach''">"карета Золушки"</a>, за небольшую плату катающая по парку всех желающих.','')
    if money >= 100:
        act '<B>Сходить в зоопарк</B>':
            minut += 5
            money -= 100
            gs 'zz_clothing2','dispose'
            gt 'zoo','inside'
        end
    end
    act '<B>Уйти</B>':
        minut += 5
        gs 'zz_clothing2','dispose'
        gt 'zz_park'
    end
end
if $args[0] = 'coach':
    *clr & cla
    minut += 1
    gs 'stat'
    gs 'time'
    gs 'zz_render', 'Карета', 'common/park/zoo/brougham','У входа в зоопарк в рабочее время стоит "карета Золушки", за небольшую плату катающая по парку всех желающих. На облучке восседает молодой симпатичный парнишка.'
    if hour >= 10 and hour <= 20:
        act 'Покататься':
            *clr & cla
            minut += 30
            manna += 20
            money -= 100
            gs 'stat'
            gs 'zz_render', $_str, 'common/park/zoo/brougham3','Вас полчаса катают по аллеям парка.'
            act 'Уйти': gt 'zoo','main'
        end
        act 'Уйти': gt 'zoo','main'
    end
    !act 'Познакомиться с возницей':
end
if $args[0] = 'inside':
    *clr & cla
    $metka = $args[0]
    gs 'stat'
    gs 'time'
    gs 'zz_render','Зоопарк','common/park/zoo/inside','Городской зоопарк, расположенный в парке Победы.**В зоопарке есть небольшая кафешка  '+iif(hour >= 10 and hour <= 20,'<a href="exec:gt''parkKafe'',''food''">"Крокодил Гена"</a> где можно перекусить.','"Крокодил Гена", но сейчас она не работает.')
    if hour >= 10 and hour <= 20: act 'Гулять по зоопарку': gt 'zoo','events',iif(rand(1,20) > 5,rand(1,35),0)
    act '<B>Уйти</B>':
        minut += 5
        gs 'zz_clothing2','dispose'
        gt 'zoo','main'
    end
end
if $args[0] = 'events':
    *clr & cla
    gs 'time'
    $zoo_text[0] = 'Вы замечаете девушку, позирующую на фоне слонов парню, снимающему её на телефон. Чуть понаблюдав за ними, вы замечаете, что трусики носить девушка явно не любит.'
    $zoo_text[1] = 'Вы видите девушку, присевшую на фоне слонов, позируя парню, снимающему её на телефон. Чуть понаблюдав за ними, вы замечаете, что трусики носить девушка явно не любит.'
    $zoo_text[2] = 'Вы видите девушку, присевшую около слоновника. Парень снимает её на телефон. Чуть понаблюдав за ними, вы замечаете, что трусики - не самый её любимый предмет гардероба.'
    $zoo_text[3] = 'Девушку на фоне слонов фотографирует парень. Чуть понаблюдав за ними, вы замечаете, что нижним бельём девушка не обременена.'
    $zoo_text[4] = 'Вы видите двух девушек: одна перелезла через невысокое ограждение. Девчонки постоянно обнимаются и смеются. Обнимаются они как-то совсем не "по-дружески" нежно. Одна задирает, смеясь, подол перед подружкой: трусиков на ней нет.'
    $zoo_text[5] = 'Вы обращаете внимание на двух девушек: одна перелезла через невысокое ограждение и присела на камне, раздвинув ноги, и улыбается подруге. Трусики для неё, как вы замечаете - явно излишний предмет одежды!'
    $zoo_text[6] = 'Вы видите пару девушек: одна перелезла через невысокое ограждение и оттуда смеётся подружке, присев на камень. Девчонки постоянно обнимаются и смеются и ведут себя скорее как влюблённые, а не как подруги. На той, что в сарафане, нет нижнего белья, как вы замечаете: она то и дело со смехом приподнимает подол, дразня подругу гладко выбритой киской.'
    $zoo_text[7] = 'Жираф, вытянув длиннющую шею, лижет лицо хохочущей девушки.'
    $zoo_text[8] = ', наблюдая за жизнью животных, читаете таблички на клетках, вольерах и загонах, и посматриваете на посетителей.'
    $zoo_text[9] = ', отдыхая от забот.'
    $zoo_text[10] = ', больше глядя на посетителей, чем на обитателей зоопарка.'
    $zoo_text[11] = ', лениво глядя по сторонам.'
    $zoo_text[12] = ', созерцая жизнь зверей и наблюдая за посетителями.'
    $zoo_text[13] = '. В зоопарке много народу - шум, гам и толкотня.'
    $zoo_text[14] = 'В большом вольере с просторным бассейном, замаскированным под пруд, обитают бегемоты. Они постоянно подходят к ограждению и разевают широченные пасти в ожидании угощения.'
    $zoo_text[15] = 'Какой-то парень дразнит "корабля пустыни". Явно нарывается на то, о чём предупреждает табличка!'
    $zoo_text[16] = 'Две девушки, стоя у вольера с козлами, громко обсуждают своих бывших.'
    $zoo_text[17] = 'По зоопарку ходит группа старичков с фотоаппаратами и сопровождающим: какие-то иностранные туристы.'
    $zoo_text[18] = 'Бабуля у загонов копытных суёт через ограждение ветки.'
    $zoo_text[19] = 'Аниматор в костюме Тигры ведёт за собой галдящую как стая воробьёв группу малышей.'
    $zoo_text[20] = 'У пруда дети кормят уток и лебедей. Рядом стоит лоточек, где можно купить корм для птиц: кормить их хлебом, печеньем и прочими чипсами строго запрещено - предупреждает табличка.'
    $zoo_text[21] = 'Вы зашли в "контактный уголок", где можно пообщаться с некоторыми животными не через ограждение. Тут бродят маленькие ручные олешки, можно сфотографироваться с совой или соколом на руке, или в обнимку с обезьяной, или ещё с какой животиной. Многие тут делают селфи "Я и ещё одна скотина". Вы чем-то понравились оленям: они окружили вас и обнюхивают. Вдруг олень со спиленными рожками тычется носом вам в ноги, задрав при этом подол. От неожиданности вы взвизгиваете, а молодые парни одобрительно галдят, оценив открывшийся вид.'
    $zoo_text[22] = 'Вольер, где обитают гориллы, окружён толстым стеклом. Вы ещё подумали: "И зачем это?" Но стоило подойти - как здоровенный самец вдруг неожиданно кидается к вам, заставив шарахнуться, и лупит в стекло здоровенным кулачищем. "Кинг-Конг грёбаный! - чертыхаетесь вы, отходя. - Напугал до усрачки!"'
    $zoo_text[23] = 'В слоновнике служитель поливает слона из шланга водой. Тот, задрав хобот, довольно хлопает ушами.'
    $zoo_text[24] = 'У слонов - время перекуса: служители принесли несколько ящиков фруктов.'
    $zoo_text[25] = 'Вы зашли в "контактный уголок", где можно пообщаться с некоторыми животными не через ограждение. Здесь пасётся небольшое стадо оленей, они совсем ручные и без опаски подходят к людям.'
    $zoo_text[26] = 'Проходя мимо хищников, вы слышите заунывный полурёв-полумяв. Леопард лениво развалился в вальяжной позе и дерёт глотку. "Яйца прищемил - а встать лень?" - хмыкаете вы про себя.'
    $zoo_text[27] = 'Мама с маленьким сыном на руках кормят жирафа.'
    $zoo_text[28] = 'У загона со страусами, глядя на их крохотные головки, вспоминается из школьных уроков биологии: "глаз страуса больше чем его мозг". "Страусов не пугать - пол бетонный!" - ухмыляетесь вы.'
    $zoo_text[29] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей. В вольере шимпанзе возлежит, положив ногу на ногу, с видом олигарха, купившего этот зоопарк, крупный самец. Что самец - видно издалека! "Мда, плохой танцор. Почти как футболист российской сборной!" - прыскаете вы в голос от зрелища.'
    $zoo_text[30] = 'Девочка гладит флегматично жующую ламу через ограду загона.'
    $zoo_text[31] = 'В обезьяннике один из обитателей отхватил половину большого арбуза, и теперь выедает из него сладкую мякоть. Вспоминается анекдот, рассказанный кем-то: "Наташа Ростова интересуется у поручика Ржевского: "Поручик, а что это вы арбуз не кушаете?" - "Ухи пачкает-с когда кусаешь!"'
    $zoo_text[32] = 'Некоторые клетки отгорожены от посетителей толстым стеклом. Глядя на то как мамаша пальцем тыкает чуть не в нос тигру, показывая что-то ребёнку, - вы понимаете, зачем.'
    $zoo_text[33] = 'В "контактном уголке" всегда многолюдно.'
    $zoo_text[34] = 'У львиного семейства - сиеста.'
    $zoo_text[35] = 'Жираф через сетку тянется мордой к пытающимся потрогать его посетителям.'
    $zoo_text[36] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей: порой бывают забавные сценки, как вот эта например.'
    $zoo_text[37] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей: орангутаниха о чём-то размышляет.'
    $zoo_text[38] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей: "Однако, девушка богато оснащена! - прыскаете вы - видать, пользуется спросом у самцов!"'
    $zoo_text[39] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей. Обезьянья пара занимается любовью, не обращая ни на кого внимания. Вам даже становится как-то неловко, словно в чужую личную жизнь влезла.'
    $zoo_text[40] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей. Вы явно чем-то не понравились макаке.'
    $zoo_text[41] = 'Вы зашли в обезьянник. Стоя у вольера, вы наблюдаете за жизнью его обитателей. Шимпанзе, похожий на пожилого негра, вольготно устроился на травке.'
    $zoo_text[42] = 'Черепахи трапезничают.'
    $zoo_text[43] = 'У вольеров хищников какая-то девица пытается изображать из себя пантеру. "Кошка драная, куда тебе до настоящей пантеры - фыркаете вы, - то же мне, Багира нашлась!"'
    $zoo_text[44] = '"Ну какая же кошка не любит посидеть в коробке?" - смеётесь вы.'
    $zoo_text[45] = 'В слоновнике устраивают аттракционы: можно например покатиться на слоне, покормить или сфотографироваться.'
    $zoo_text[46] = 'Купив корма, вы некоторое с некоторой опаской протягиваете пищу огромному животному. Тот неожиданно ловко и осторожно берёт хоботом угощение из ваших рук.'
    $zoo_text[47] = 'Вас подсаживают, помогая взобраться на слона, и десять минут катают по площадке.'
! def action
    if hour >= 10 and hour <= 20: act 'Гулять дальше': minut += rand(5,10) & gt 'zoo','events'
    act 'Прекратить прогулку': minut += 5 & gt 'zoo','inside'
    if args[1] = 0:
        minut += rand(5,10)
        gs 'stat'
        gs 'zz_render','','common/park/zoo/walk'+rand(1,93),'Вы прогуливаетесь по дорожкам и павильонам зоопарка' + $zoo_text[rand(8,13)]
    end
    if args[1] = 1:
        minut += rand(5,10)
        gs 'stat'
        gs 'zz_render','','common/park/zoo/elephant'+rand(1,4),$zoo_text[rand(0,3)]
    end
    if args[1] = 2:
        horny += 5
        minut += rand(5,10)
        gs 'stat'
        gs 'zz_render','','common/park/zoo/girls'+rand(1,3),$zoo_text[rand(4,6)]
    end
    if args[1] = 3:
        gs 'zz_render','','common/park/zoo/giraffe',$zoo_text[7]
    end
    if args[1] = 4:
        manna += 10
        minut += 15
        gs 'stat'
        gs 'zz_render','','common/park/zoo/bamby'+rand(1,3),$zoo_text[25]
        if money >= 100:
            act 'Погладить оленя':
                *clr & cla
                minut += rand(10,15)
                gs 'zz_render','','common/park/zoo/bamby'+rand(1,3),'Вы с удовольствием гладите очаровательных созданий.'
                act 'Отойти': gt 'zoo','inside'
            end
        end
    end
    if args[1] = 5:
        manna += 10
        minut += 15
        money -= 100
        gs 'stat'
        gs 'zz_render','','common/park/zoo/hippo'+rand(1,3),$zoo_text[14]
        if money >= 100:
            act 'Покормить бегемота (100 рублей)':
                *clr & cla
                money -= 100
                minut += rand(10,15)
                gs 'zz_render','','common/park/zoo/hippo_eat'+rand(1,2), '"Такой бы пастью - да медку бы зачерпнуть!" - думаете вы, глядя как пища исчезает в ней как в чёрной дыре.'
                act 'Отойти': gt 'zoo','inside'
            end
        end
    end
    if args[1] = 6:
       gs 'zz_render','','common/park/zoo/camel',$zoo_text[15]
    end
    if args[1] = 7:
       gs 'zz_render','','common/park/zoo/girl_ass',$zoo_text[16]
    end
    if args[1] = 8:
       gs 'zz_render','','common/park/zoo/group_old' +rand(1,2),$zoo_text[17]
    end
    if args[1] = 9:
       gs 'zz_render','','common/park/zoo/granny',$zoo_text[18]
    end
    if args[1] = 10:
       gs 'zz_render','','common/park/zoo/animator',$zoo_text[19]
    end
    if args[1] = 11:
        manna += 10
        minut += 15
        money -= 100
        gs 'stat'
        gs 'zz_render','','common/park/zoo/swan',$zoo_text[20]
        if money >= 100:
            act 'Покормить птиц (100 рублей)':
                *clr & cla
                money -= 100
                minut += rand(10,15)
                gs 'zz_render','','common/park/zoo/duck'+rand(1,2),'Купив корма, вы некоторое время бросаете его птицам.'
                act 'Отойти': gt 'zoo','inside'
            end
        end
    end
    if args[1] = 12:
        manna += 5
        minut += 15
        gs 'stat'
        gs 'zz_render','','common/park/zoo/bamby_upskirt',$zoo_text[21]
    end
    if args[1] = 13:
        manna -= 15
        minut += 2
        gs 'stat'
        gs 'zz_render','','common/park/zoo/gorilla',$zoo_text[22]
    end
    if args[1] = 14:
       gs 'zz_render','','common/park/zoo/elephant_wash',$zoo_text[23]
    end
    if args[1] = 15:
       gs 'zz_render','','common/park/zoo/elephant_eat',$zoo_text[24]
    end
    if args[1] = 16:
       gs 'zz_render','','common/park/zoo/cat_scream',$zoo_text[26]
    end
    if args[1] = 17:
       gs 'zz_render','','common/park/zoo/giraffe1',$zoo_text[27]
    end
    if args[1] = 18:
       gs 'zz_render','','common/park/zoo/straus',$zoo_text[28]
    end
    if args[1] = 19:
       gs 'zz_render','','common/park/zoo/ape_ball',$zoo_text[29]
    end
    if args[1] = 20:
       gs 'zz_render','','common/park/zoo/lama',$zoo_text[30]
    end
    if args[1] = 21:
       gs 'zz_render','','common/park/zoo/monkey_eat',$zoo_text[31]
    end
    if args[1] = 22:
       gs 'zz_render','','common/park/zoo/tiger1',$zoo_text[32]
    end
    if args[1] = 23:
       gs 'zz_render','','common/park/zoo/touch'+rand(1,2),$zoo_text[33]
    end
    if args[1] = 24:
       gs 'zz_render','','common/park/zoo/lion',$zoo_text[34]
    end
    if args[1] = 25:
       gs 'zz_render','','common/park/zoo/giraffe2',$zoo_text[35]
    end
    if args[1] = 26:
        manna += 15
        minut += 15
        gs 'stat'
        gs 'zz_render','','common/park/zoo/ape_ass',$zoo_text[36]
    end
    if args[1] = 27:
       gs 'zz_render','','common/park/zoo/orangutan',$zoo_text[37]
    end
    if args[1] = 28:
        manna += 5
        minut += 10
        gs 'stat'
       gs 'zz_render','','common/park/zoo/ape_rear',$zoo_text[38]
    end
    if args[1] = 29:
        manna -= 5
        minut += 10
        horny += 10
        gs 'stat'
       gs 'zz_render','','common/park/zoo/ape_sex',$zoo_text[39]
    end
    if args[1] = 30:
       gs 'zz_render','','common/park/zoo/macaque',$zoo_text[40]
    end
    if args[1] = 31:
       gs 'zz_render','','common/park/zoo/ape1',$zoo_text[41]
    end
    if args[1] = 32:
       gs 'zz_render','','common/park/zoo/turtle1',$zoo_text[42]
    end
    if args[1] = 33:
        manna += 2
        gs 'stat'
       gs 'zz_render','','common/park/zoo/panther',$zoo_text[43]
    end
    if args[1] = 34:
        manna += 2
        gs 'stat'
       gs 'zz_render','','common/park/zoo/cat_box'+rand(1,5),$zoo_text[44]
    end
    if args[1] = 35:
        if money >= 200:
            gs 'zz_render','','common/park/zoo/elephant_show'+rand(1,4),$zoo_text[45]
            act 'Покормить слона (200 рублей)':
                *clr & cla
                money -= 200
                manna += 10
                minut += rand(10,15)
                gs 'zz_render','','common/park/zoo/elephant_eat'+rand(1,2),$zoo_text[46]
                act 'Отойти': gt 'zoo','inside'
            end
        end
        if money >= 100:
            act 'Покататься на слоне (100 рублей)':
                *clr & cla
                money -= 100
                manna += 10
                minut += rand(10,15)
                gs 'zz_render','','common/park/zoo/elephant_walk'+rand(1,2),$zoo_text[47]
                act 'Завершить': gt 'zoo','inside'
            end
        end
	end
end