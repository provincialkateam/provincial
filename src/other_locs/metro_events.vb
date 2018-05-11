if $ARGS[0] = 'frot_start':
    *clr & cla
    $boy = 'незнакомец'
    dick = rand(12,22)
    silavag = rand(0,2)
    pose = 1
    frot_hour = hour
    gs 'stat'
    gs 'zz_render',$location_name,'common/metro/carriage/'+$control_point+iif(temper >= 15,'',iif(snow = 0,'_cold','_winter'))+metro_people, 'Вы зашли в битком набитый вагон и осмотрелись. Кто смог сесть уткнулись в книжки, телефоны или планшеты. Остальные стоя уныло пялятся на рекламу, которая щедро расклеена на стенах вагона.'
    act 'Ехать':
        *clr & cla
        horny += 5
        gs 'stat'
        gs 'zz_render', $location_name, 'common/metro/frot_event/start1', 'Неожиданно вы почувствовали, как в ваш зад тычется что-то твёрдое. Пошевелившись вы поняли, что вам между ягодиц упирается чей-то вставший член.'
        if shameless['flag'] = 0 or horny < 90: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
        if shameless['flag'] > 0:
            act 'Не обращать внимания':
                *clr & cla
                horny += 5
                gs 'stat'
                gs 'zz_render', $location_name, 'common/metro/frot_event/start2', 'Парень, стоящий сзади, как бы невзначай касается вашей попы рукой и ещё сильнее прижимается своим членом к вашей попе.'
                if shameless['flag'] <= 1 or horny < 90: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
                act 'Не обращать внимания':
                    *clr & cla
                    horny += 5
                    gs 'stat'
                    gs 'zz_render', $location_name, 'common/metro/frot_event/start3', 'Вы услышали, как сзади вас тихонько вжикнула молния и почувствовали как мужчина за вашей спиной достал член и стал тереться им о вашу попу, прижимаясь сзади и сжимая ваши ягодицы руками.'
                    if shameless['flag'] <= 1 or horny < 90: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
                    act 'Не обращать внимания':
                        *clr & cla
                        horny += 5
                        if rand(0,2) = 0:
                            if func('zz_clothing2','is_skirt') > 0:
                                gs 'stat'
                                gs 'zz_render', $location_name, 'common/metro/frot_event/up_skirt1', 'Вы почувствовали как руки стоящего позади незнакомца проникли под вашу юбку, задирая её, при этом не прекращая тискать вашу попку.'
                                if horny < 90: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
                                act 'Не обращать внимания':
                                    *clr & cla
                                    horny += 10
                                    if cloth[1] > 0:
                                        if rand(0,2) = 0:
                                            gs 'stat'
                                            gs 'zz_render', $location_name, 'common/metro/frot_event/finger.jpg', 'Мужчина приспустил ваши трусики и просунул руку между обнаженных ягодиц, лаская вашу '+iif(horny >= 50,'влажную ','')+'киску.'
                                            if horny >= 100:
                                                horny = 0
                                                manna = 100
                                                orgasm += 1
                                                gs 'zz_render', '', '', 'Не в силах больше сдерживать своё возбуждение, вы бурно кончаете, стараясь не выдать своё состояние окружающим людям. От пережитого мощного оргазма ноги трясутся и подкашиваются, не в силах удержать вас.'
                                                act 'Сесть на корточки':
                                                    *clr & cla
                                                    horny += 10
                                                    dom -= 1
                                                    gs 'stat'
                                                    gs 'zz_render', $location_name, 'common/metro/frot_event/squat', 'Не в силах больше удерживаться на ногах и стараясь перевести дух, вы сели на корточки, где тут же столкнулись с членом незнакомца, оказавшимся прямо перед вашим лицом. Парень, недолго думая, взял вас за голову и стал направлять ваше лицо к члену.'
                                                    act 'Взять в рот': gt 'metro_events','frot_bj'
                                                end
                                            else
                                                if shameless['flag'] <= 1 or horny < 75: act 'Убрать руку и отойти': gt 'metro_events', 'frot_end'
                                                if shameless['flag'] > 1: act 'Взять в руку его член': gt 'metro_events','frot_hj'
                                            end
                                        else
                                            frot += 1
                                            gs 'zz_funcs', 'cum', 'ass'
                                            guy += 1
                                            gs 'stat'
                                            gs 'zz_render', $location_name, 'common/metro/frot_event/cum_ass', 'Мужчина сзади засопел и вы почувствовали как что-то тёплое и вязкое стрельнуло на вашу оголённую попу. Парень кончил вам на задницу, после чего перешёл на другое место, а вы принялись оправлять на себе одежду.'
                                            act 'Ехать дальше': gt 'metro','carriage'
                                        end
                                    else
                                        gs 'stat'
                                        gs 'zz_render', $location_name, 'common/metro/frot_event/up_skirt1', 'Не нащупав под вашей юбкой припятствия в виде трусиков, парень довольно хмыкнул, и оголив вашу попу полностью начал пристраивать свой член к вашей '+iif(horny >= 50,'влажной ','')+'киске.'
                                        if shameless['flag'] <= 1 or horny < 75: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
                                        if shameless['flag'] > 1: act 'Взять в руку его член': gt 'metro_events','frot_hj'
                                        if shameless['flag'] > 2: act 'Не обращать внимания': gt 'metro_events','frot_sex'
                                    end
                                end
                            else
                                gs 'stat'
                                gs 'zz_render', $location_name, 'common/metro/frot_event/hand', 'Вдруг вы почувствовали как стоящий сзади вас незнакомец начал засовывать свою руку вам в штаны.'
                                if horny < 90: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
                                act 'Не обращать внимания':
                                    *clr & cla
                                    horny += 10
                                    gs 'stat'
                                    gs 'zz_render', $location_name, 'common/metro/frot_event/hands', 'Продолжая ласкать вашу попу, парень слегка нагнул вас вперёд и вы вдруг почувствовали как его руки вцепились в ваши штаны, пытаясь разорвать их.'
                                    if horny < 90: act 'Перейти в другое место': gt 'metro_events', 'frot_end'
                                    act 'Позволить ему это':
                                        *clr & cla
                                        horny += 10
                                        dom -= 1
                                        gs 'zz_clothing2', 'decrease_condition', 10
                                        i = rand(1,2)
                                        gs 'stat'
                                        gs 'zz_render', $location_name, 'common/metro/frot_event/tear', 'Незнакомец напрягся, ткань штанов затрещала и подалась, тем самым обнажив вашу '+iif(horny >= 50,'влажную ','')+'киску, и вы тут же почувствовали '+iif(i = 1,'изучающие прикосновения его пальцев к ней.','как его вздыбленый член упирается в неё.')
                                        if i = 1:
                                            act 'Позволить ему это':
                                                *clr & cla
                                                horny += 20
                                                gs 'stat'
                                                gs 'zz_render', $location_name, 'common/metro/frot_event/finger2.jpg', 'Парень просунул свою руку между ваших обнаженных ягодиц и вы тут же почувствовали, как его палец проникает в вашу '+iif(horny >= 50,'влажную ','')+'киску, лаская её.'
                                                if horny >= 100:
                                                    horny = 0
                                                    manna = 100
                                                    orgasm += 1
                                                    gs 'zz_render', '', '', 'Не в силах больше сдерживать возбуждение, вы бурно кончаете, стараясь не выдать своё состояние окружающим людям. От пережитого мощного оргазма ноги трясутся и подкашиваются, не в силах удержать вас.'
                                                    act 'Сесть на корточки':
                                                        *clr & cla
                                                        horny += 10
                                                        dom -= 1
                                                        gs 'stat'
                                                        gs 'zz_render', $location_name, 'common/metro/frot_event/squat', 'Не в силах больше удерживаться на ногах и стараясь перевести дух, вы сели на корточки, где тут же столкнулись с членом незнакомца, оказавшимся прямо перед вашим лицом. Парень, недолго думая, взял вас за голову и стал направлять ваше лицо к члену.'
                                                        act 'Взять в рот': gt 'metro_events','frot_bj'
                                                    end
                                                else
                                                    act 'Взять в руку его член': gt 'metro_events','frot_hj'
                                                end
                                            end
                                        else
                                            act 'Позволить ему это': gt 'metro_events','frot_sex', 1
                                            act 'Взять в руку его член': gt 'metro_events','frot_hj'
                                        end
                                    end
                                end
                            end
                        else
                            frot += 1
                            cumfrot += 1
                            guy += 1
                            gs 'stat'
                            gs 'zz_render', $location_name, 'common/metro/frot_event/cum_cloth', 'Мужчина сзади засопел и вы почувствовали как что-то тёплое и вязкое стрельнуло на вашу одежду, пачкая её. Парень кончил вам на задницу, после чего перешёл на другое место.'
                            act 'Ехать дальше': gt 'metro','carriage'
                        end
                    end
                    if shameless['flag'] > 1: act 'Взять в руку его член': gt 'metro_events','frot_hj'
                end
            end
        end
    end
end
if $ARGS[0] = 'frot_hj':
    *clr & cla
    horny += 10
    hj += 1
    gs 'stat'
    gs 'zz_render', $location_name, 'common/metro/frot_event/hj', 'Вы обхватили ладошкой его член и принялись двигать рукой туда-сюда, надрачивая его.'
    if rand(0,2) = 0:
        frot += 1
        cumfrot += 1
        guy += 1
        gs 'stat'
        gs 'zz_render', '', '', 'Вскоре член в вашей руке напрягся и из него стала брызгать вязкая сперма, пачкая вашу одежду. Кончив, незнакомец застегнул свои брюки и перешёл на другое место, оставив вас одну.'
        act 'Ехать дальше': gt 'metro','carriage'
    else
        gs 'zz_render', '', '', 'Но парню видимо этого мало - вы чуствуете как он ощутимо давит на плечи, приглашая опуститься на корточки.'
        if dom < 50:
            act 'Подчиниться':
                *clr & cla
                horny += 10
                dom -= 1
                gs 'stat'
                gs 'zz_render', $location_name, 'common/metro/frot_event/squat', 'вы уступили требованию незнакомца и сели на корточки, где тут же столкнулись с его членом, оказавшимся прямо перед вашим лицом. Парень, недолго думая, взял вас за голову и стал направлять к нему ваше лицо.'
                act 'Взять в рот': gt 'metro_events','frot_bj'
            end
        end
        if horny < 90 or dom >= 10:
            act 'Продолжить дрочить':
                *clr & cla
                frot += 1
                cumfrot += 1
                guy += 1
                gs 'stat'
                gs 'zz_render', $location_name, 'common/metro/frot_event/cum_cloth', 'Не обращая на намёки внимания вы продолжили дрочить член незнакомца. Мужчина сзади засопел и вы почувствовали как что-то тёплое и вязкое стрельнуло на вашу одежду, пачкая её. Парень кончил вам на задницу, после чего перешёл на другое место.'
                act 'Ехать дальше': gt 'metro','carriage'
            end
        end
    end
end
if $ARGS[0] = 'frot_bj':
    *clr & cla
    horny += 10
    bj += 1
    guy += 1
    frot += 1
    gs 'stat'
    gs 'zz_render', $location_name, 'common/metro/frot_event/bj'
    gs 'zz_dynamic_sex', 'bj'
    act 'Далее':
        *clr & cla
        gs 'zz_funcs', 'cum', 'face'
        gs 'zz_render', $location_name, 'common/metro/frot_event/cum_face','Вы продолжали сосать, когда парень вдруг засопел, и вынув свой член из вашего рта, стал кончать на ваше лицо, покрывая его своей мутной и вязкой спермой. После этого он не спеша спрятал член в штаны и перешёл в другое место, оставив вас сидя на полу переводить дыхание.'
        act 'Подняться на ноги': gt 'metro','carriage'
    end
end
if $ARGS[0] = 'frot_sex':
    *clr & cla
    horny += 10
    guy += 1
    frot += 1
    gs 'stat'
    gs 'zz_render', $location_name, 'common/metro/frot_event/sex'+args[1]
    gs 'zz_dynamic_sex', 'sex_start'
    gs 'zz_dynamic_sex', 'vaginal', 'dick'
    gs 'zz_dynamic_sex', 'sex_cum'
    gs 'zz_render', '', '', 'Кончив, незнакомец застегнул брюки и перешёл на другое место, оставив вас оправлять свою одежду.'
    act 'Ехать дальше': gt 'metro','carriage'
end
if $ARGS[0] = 'frot_end':
    *clr & cla
    gs 'zz_render', $location_name, 'common/metro/frot_event/frot_end', 'Вы с трудом протиснулись в другое место, подальше от озабоченного придурка.'
    act 'Ехать дальше': gt 'metro','carriage'
end
!Света, заходя в метро, постоянно видит разных музыкантов, играющих там.
if $ARGS[0] = 'musicians':
    *clr & cla
    minut += rand(5,15)
    manna += rand(2,10)
    gs 'stat'
    gs 'zz_render', '','common/metro/mini/musicians_hall'+rand(1,18),'Вы некоторое время стоите и слушаете игру.'
    if money => 100:
        act 'Поблагодарить':
			*clr & cla
            money -= 100
            manna += rand(2,10)
            gs 'stat'
            gs 'zz_render', '','common/metro/mini/musicians_money','Вы в благодарность кладёте в кофр сто рублей.'
            act 'Идти дальше': gt 'metro'
        end
    end
    act 'Идти дальше': gt 'metro'
end
! Созерцание в вагоне.
if $ARGS[0] = 'smile':
    *clr & cla
    minut += rand(1,3)
    manna += rand(1,3)
    gs 'zz_render', '','common/metro/carriage/smile/'+rand(1,16),'Вы с интересом рассматриваете окружающих людей.'
    act 'Выйти из вагона': gt 'metro','start'
end
! Наблюдения на пероне.
if $ARGS[0] = 'smile1':
    *clr & cla
    minut += rand(1,3)
    manna += rand(1,3)
    gs 'zz_render', '','common/metro/smile/'+rand(1,14),'Вы с любопытством рассматриваете окружающих.'
    act 'Отвернуться': gt 'metro','start'
end