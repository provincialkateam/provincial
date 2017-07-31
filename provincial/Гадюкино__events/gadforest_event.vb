if $ARGS[0] = 'search':
	*clr & cla
	minut += 30
	edge_forestday[$metka]  = daystart
	if goforest < 20*args[0]:goforest += rand(0,1)
	gs 'stat'
	if $metka = '1':
		new_boletus += iif(mushroom_pickers = 0 or mushroom_pickers = 2,rand(0,1),0)
		new_bilberry += iif(mushroom_pickers = 0 or mushroom_pickers = 2,1,rand(0,1))
	elseif $metka = '2':
		new_boletus += iif(mushroom_pickers < 2,1,rand(0,1))
		new_bilberry += iif(mushroom_pickers < 2,rand(1,2),1)
	else
		new_boletus += rand(1,2)
		new_bilberry += iif($metka = '3',rand(1,2),rand(2,3))
	end
	boletus += new_boletus
	bilberry += new_bilberry
	manna += 5
	gs 'stat'
	if new_boletus > 0 and new_bilberry > 0:
		manna += 10
		gs 'gadforest_event', 'clothes1'
		gs 'zz_render', '', '', 'Вы в течение получаса бродили по лесу в поисках грибов или ягод и нашли <<new_boletus>> кг грибов и <<new_bilberry>> кг ягод.'
	elseif new_boletus = 0 and new_bilberry > 0:
		manna += 5
		gs 'gadforest_event', 'clothes1'
		gs 'zz_render', '', '', 'Вы в течение получаса бродили по лесу в поисках грибов или ягод и нашли <<new_bilberry>> кг ягод.'
	else
		manna -= 5
		gs 'gadforest_event', 'clothes2'
		gs 'zz_render', '', '', 'Вы в течение получаса бродили по лесу в поисках грибов или ягод, но ничего не нашли.'
	end
	act 'Далее':gt $loc, $metka
end
if $ARGS[0] = 'clothes1':
    if mirainforest = 0:
        if current_clothing > 0 and func('zz_clothing','is_skirt') = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/mushroom1.jpg'
	    if current_clothing > 0 and tanga = 1 and func('zz_clothing','is_skirt') = 1: gs 'zz_render', $_str, 'qwest/gadukino/forest/mushroom2.jpg'
	    if current_clothing > 0 and tanga = 0 and func('zz_clothing','is_skirt') = 1: gs 'zz_render', $_str, 'qwest/gadukino/forest/mushroom3.jpg'
	    if current_clothing = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/mushroom4.'+rand(1,3)+'.jpg'
	else
        if current_clothing > 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/miramushroom'+rand(1,2)+'.jpg'
	    if current_clothing = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/miramushroom_nude'+rand(1,2)+'.jpg'
    end
end
if $ARGS[0] = 'clothes2':
    if mirainforest = 0:
        if current_clothing > 0 and func('zz_clothing','is_skirt') = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest2.jpg'
	    if current_clothing > 0 and tanga = 1 and func('zz_clothing','is_skirt') = 1: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest3.jpg'
	    if current_clothing > 0 and tanga = 0 and func('zz_clothing','is_skirt') = 1: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest_tanga1.'+rand(1,2)+'.jpg'
	    if current_clothing = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest_nude1.'+rand(1,4)+'.jpg'
	else
        if current_clothing > 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/miramushroom3.jpg'
	    if current_clothing = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/miramushroom_nude3.jpg'
    end
end
if $ARGS[0] = 'gadforest_lost_start':
	*clr & cla
	gs'time'
	gs 'stat'
    gs 'zz_render', 'Где-то в лесу', 'qwest/gadukino/forest/gadfear'+iif(current_clothing = 0,2,iif(temper < 15,3,1))+'.jpg','Вы вдруг с ужасом понимаете, что местность вам не знакома... вы заблудились.'
    act 'Далее': gt 'gadforestlost', 'main', lost
end
if $ARGS[0] = 'gopforest_mitka':
    if current_clothing > 0:
        if mirainforest = 0:
            if mitkasextimes = 0 or gadriver_gang >= 3:
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу вы встретили Митьку. Поболтав с ним немного вы отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу вы встретили Митьку. Увидев вас Митька почесал яйца и сказал с ухмылкой:'
                ' - <<$name[2]>>, пойдем поебемся, а то стояк заеб.'
                act 'Согласиться':forest_gopsex = 1 & temphant = 4 & gt 'hanters'
                if mitkasextimes < 11 and alko < 6 and horny < 70:act 'Отказаться':gt 'gadforest','1'
            end
        else
            if mitkasextimes = 0 or gadriver_gang >= 3:
                if miragopQW >= 2 and miragopQW < 11:
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                mirainforest = 0
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                    '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Митьку. Поболтав немного вместе, вы уже собрались идти дальше, когда к вам подошла Мира.'
                    ' - <<$name[2]>>, ты погуляй дальше по лесу одна, а мне тут с Митькой поговорить наедине надо, - отчаянно краснея произнесла она. - Он меня потом проводит домой сам.'
                    ' - Ну ладно, - ответили вы Мире и подмигнув на прощанье отправились дальше.'
                    act 'Уйти':gt 'gadforest','1'
                    act 'Подсматривать':
	                    if miragopQW < 8:
		                    cla
		                    *clr
		                    minut += 2
		                    horny += 5
		                    voyeurism += 1
		                    gs 'stat'
		                    '<center><img src="images/qwest/gadukino/MiraMeadowSex.jpg"></center>'
		                    'Они болтают между собой, попутно раздеваясь, но о чем именно они говорят, вам не удается услышать из-за растояния.'
		                    act 'Смотреть':
			                    cla
                                *clr
			                    minut += 5
			                    horny += 25
			                    gs 'stat'
			                    '<center><img src="images/qwest/gadukino/MiraMeadowSex1.jpg"></center>'
			                    'Через пару минут Мирослава ложится перед Митькой на покрывало и призывно расставляет перед ним ноги. Тот, не заставляя себя ждать, тут же пристраивается у нее между ног и начинает грубо и сильно вколачивать в нее свой член, отчего она начинает громко и охать и подвизгивать.'
			                    act 'Смотреть':
			                        cla
                                    *clr
				                    minut += 5
				                    horny += 15
				                    if miragopQW = 2:miragopQW = 3
				                    gs 'stat'
				                    '<center><img src="images/qwest/gadukino/MiraMeadowSex2.jpg"></center>'
				                    'Минуть через пятнадцать Митька наконец кончает Мирославе на живот и еще немного полежав, они оделись и пошли в сторону деревни...'
				                    act 'Далее':gt 'gadforest','1'
			                    end
		                    end
                        else
		                    cla
		                    *clr
		                    minut += 2
		                    horny += RAND(15,30)
		                    temp = RAND(0,1)
		                    gs 'stat'
		                    if temp = 0:
			                    '<center><img src="images/qwest/gadukino/MiraMeadowAnal.jpg"></center>'
			                    'Мирка прыгает задницей на митькином члене, каждый раз шлепаясь ягодицами о его бедра, и громко постанывает.'
		                    else
			                    '<center><img src="images/qwest/gadukino/MiraMeadowAnal1.jpg"></center>'
			                    'Мирка, раздвинув руками ягодицы, стоит на четвереньках и громко охает, когда Митька, полностью вынимая, вгоняет в ее распахнутую задницу свой член.'
		                    end
		                    act 'Смотреть':
			                    cla
                                *clr
			                    minut += 10
			                    horny += RAND(15,30)
			                    mirasextimes += 1
			                    gs 'stat'
			                    '<center><img src="images/qwest/gadukino/MiraMeadowAnal2.jpg"></center>'
			                    'Через пару минут Митька сильно шлепает ее по заднице и Мира быстро разворачивается, встает перед ним на колени и далеко высунув язык, принимает на свое лицо его теплую сперму...'
			                    act 'Далее':gt 'gadforest','1'
		                    end
	                    end
                    end
                elseif miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                mirainforest = 0
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                    '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Митьку. Увидев Миру Митька не церемонясь схватил её за руку и поволок в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
                    act 'Уйти':gt 'gadforest','1'
                    act 'Подсматривать':
		                cla
		                *clr
		                minut += 2
		                horny += RAND(15,30)
		                temp = RAND(0,1)
		                voyeurism += 1
		                gs 'stat'
		                if temp = 0:
			                '<center><img src="images/qwest/gadukino/MiraMeadowAnal.jpg"></center>'
			                'Мирка прыгает задницей на митькином члене, каждый раз шлепаясь ягодицами о его бедра, и громко постанывает.'
		                else
			                '<center><img src="images/qwest/gadukino/MiraMeadowAnal1.jpg"></center>'
			                'Мирка, раздвинув руками ягодицы, стоит на четвереньках и громко охает, когда Митька, полностью вынимая, вгоняет в ее распахнутую задницу свой член.'
		                end
		                act 'Смотреть':
			                cla
                            *clr
			                minut += 10
			                horny += RAND(15,30)
			                mirasextimes += 1
			                gs 'stat'
			                '<center><img src="images/qwest/gadukino/MiraMeadowAnal2.jpg"></center>'
			                'Через пару минут Митька сильно шлепает ее по заднице и Мира быстро разворачивается, встает перед ним на колени и далеко высунув язык, принимает на свое лицо его теплую сперму...'
			                act 'Далее':gt 'gadforest','1'
		                end
	                end
	            else
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                    '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Митьку. Вы поболтали с ним немного, порой замечая, с каким интересом Мира рассматривает Митьку, и отправились дальше.'
                    act 'Далее':gt 'gadforest','1'
                end
            elseif mitkasextimes > 0 and mitkasextimes < 13 and gadriver_gang < 3 or mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу с Мирой вы встретили Митьку. Увидев вас Митька почесал яйца и не обращая внимания на рядом стоящую Мирославу сказал с ухмылкой:'
                ' - <<$name[2]>>, пойдем поебемся, а то стояк заеб.'
                act 'Согласиться':mirainforest = 0 & forest_gopsex = 1 & temphant = 4 & gt 'hanters'
                if mitkasextimes < 11 and alko < 6 and horny < 70:
                    act 'Отказаться':gt 'gadforest','1'
                end
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя с Мирой по лесу вы встретили Митьку. Увидев вас Митька почесал яйца и сказал с ухмылкой:'
                ' - О, вы то мне как раз и нужны,- и схватив вас за руки поволок в ближайшие кусты.'
                act 'Далее':mitboyrand = 1 & gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу с Мирой, вы встретили Митьку. Вы поболтали с ним немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            end
        end
    else
        if mirainforest = 0 or gadriver_gang >= 3:
            if mitkasextimes = 0 and gadriver_gang < 3:
	            cla
	            *clr
                minut += 5
	            temp = rand (1,2)
	            if temp = 1:gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                if temp = 1:'Идя по лесу вы нос к носу столкнулись с Митькой. Он вытаращился, глядя на вас обнаженную, а вы решили...'
                if temp = 2:'Идя по лесу вы увидели Митьку. Понимая, что он вас еще не заметил, вы решили...'
                ''
                if temp = 1:
                    act 'Убежать и одеться':
	                    cla
	                    *clr
	                    gopsawnaked += 1
	                    if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                    horny += 10
			            clothesforest = 0
			            swamp_clothes = 0
			            minut += 5
			            tanga = flag_tanga
			            gs 'zz_clothing', 'redress', prev_clothing
			            prev_clothing = -1
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/Swamp/swampbackwaternude1.jpg"></center>'
	                    'Взвизгнув от неожиданности, вы кинулись наутек, в сторону своей одежды. Одевшись и успокоившись вы отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                else
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/mitkahideforest.jpg"></center>'
	                    'Вы быстро спрятались в ближайших кустах, а когда Митька прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                end
                act 'Идти дальше':
	                cla
	                *clr
                    gadboyday = daystart
                    minut += 5
                    if mitkasextimes = 0:mitkasextimes += 1
                    horny += 20
	                gs'stat'
	                gs'time'
	                '<center><img src="images/qwest/gadukino/forest/mitkanudeforest.jpg"></center>'
	                'Вы, делая вид, что не замечаете остолбеневшего Митьку, прошли мимо него, демонстративно покачивая бедрами для закрепления эффекта. Оглянувшись украдкой, вы заметили, что произведенный эффект превзошел ваши ожидания. Митька спустив штаны до колен дрочил, глядя вам вслед.'
	                act 'Далее':gt 'gadforest','1'
                end
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу вы встретили Митьку. Увидев его вы попытались одеться, но Митька без лишних слов схватил вас за руку и потащил в ближайшие кусты.'
                act 'Далее':forest_gopsex = 1 & temphant = 4 & gt 'hanters'
            end
        else
            if mitkasextimes = 0 or gadriver_gang >= 3:
                if miragopQW < 11:
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                    '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                    if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Митькой. Он вытаращился, глядя на вас обнаженных...'
                    if temp = 2:'Идя по лесу вы увидели Митьку. Понимая, что он вас еще не заметил, вы решили...'
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись убегать к вашей одежде. Одевшись и успокоившись неспеша отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда Митька прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                elseif miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                    '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                    if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Митькой. Он вытаращился, глядя на вас обнаженных...'
                    if temp = 2:'Идя по лесу вы увидели Митьку. Понимая, что он вас еще не заметил, вы решили...'
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        mitboyrand = 1
	                        mirainforest = 0
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись к вашей одежде. Убегая вы успели замить краем глаза, как Митька не церемонясь схватил её за руку и поволок в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться. Одевшись и успокоившись вы решили...'
	                        act 'Уйти':gt 'gadforest','1'
                            act 'Подсматривать':
		                        cla
		                        *clr
		                        minut += 2
		                        horny += RAND(15,30)
		                        temp = RAND(0,1)
		                        voyeurism += 1
		                        gs 'stat'
		                        if temp = 0:
			                        '<center><img src="images/qwest/gadukino/MiraMeadowAnal.jpg"></center>'
			                        'Мирка прыгает задницей на митькином члене, каждый раз шлепаясь ягодицами о его бедра, и громко постанывает.'
		                        else
			                         '<center><img src="images/qwest/gadukino/MiraMeadowAnal1.jpg"></center>'
			                         'Мирка, раздвинув руками ягодицы, стоит на четвереньках и громко охает, когда Митька, полностью вынимая, вгоняет в ее распахнутую задницу свой член.'
		                        end
		                        act 'Смотреть':
			                        cla
                                    *clr
			                        minut += 10
			                        horny += RAND(15,30)
			                        mirasextimes += 1
			                        gs 'stat'
			                        '<center><img src="images/qwest/gadukino/MiraMeadowAnal2.jpg"></center>'
			                        'Через пару минут Митька сильно шлепает ее по заднице и Мира быстро разворачивается, встает перед ним на колени и далеко высунув язык, принимает на свое лицо его теплую сперму...'
			                        act 'Далее':gt 'gadforest','1'
			                    end
		                    end
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда Митька прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                end
            elseif mitkasextimes > 0 and mitkasextimes < 13 and gadriver_gang < 3 or mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            temp = rand (1,2)
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Митькой. Взвизгнув от неожиданности вы кинулись к своей одежде, за улепетывающей со всех ног Мирославой, но Митька без лишних слов схватил вас в охапку и потащил в ближайшие кусты.'
                if temp = 2:'Идя по лесу вы увидели Митьку. Понимая, что он вас еще не заметил, вы решили...'
                if temp = 1:act 'Далее':mirainforest = 0 & forest_gopsex = 1 & temphant = 4 & gt 'hanters'
                if temp = 2:
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                    'Вы с Мирой спрятались в ближайших кустах, а когда Митька прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mitboyrand = 1
	            mitkaforestsex = 1
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу с Мирой, вы нос к носу столкнулись с Митькой. Увидев вас обнаженных Митька почесал яйца и поволок в ближайшие кусты.'
                act 'Далее':gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Митька Шкворень</font></b></center>'
                '<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
                'Идя по лесу вы увидели Митьку. Понимая, что он вас еще не заметил, вы решили...'
                act 'Спрятаться':
	                cla
	                *clr
			        minut += 5
			        horny += 5
	                gs'stat'
	                gs'time'
	                '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                'Вы с Мирой спрятались в ближайших кустах, а когда Митька прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                act 'Далее':gt 'gadforest','1'
                end
            end
        end
    end
end
if $ARGS[0] = 'gopforest_kolyamba':
    if current_clothing > 0:
        if mirainforest = 0:
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу вы встретили Колямбу. Поболтав с ним немного вы отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу вы встретили Колямбу. Увидев вас он почесал яйца и поволок ближайшие в кусты.'
                act 'Далее':forest_gopsex = 1 & temphant = 5 & gt 'hanters'
            end
        else
            if mitkasextimes < 13 or gadriver_gang >= 3:
                if miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                mirainforest = 0
	                gadboyday = daystart
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Колямба</font></b></center>'
                    '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Колямбу. Увидев Миру он не церемонясь схватил её за руку и поволок в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
                    act 'Уйти':gt 'gadforest','1'
                    act 'Подсматривать':
		                cla
		                *clr
			            minut += 10
			            horny += 30
			            mirasextimes += 1
			            voyeurism += 1
			            gs 'stat'
			            '<center><img src="images/qwest/gadukino/MiraMeadowBJ2.jpg"></center>'
			            'Мира в одних шлепанцах стоит раком, оттопырив как раз в вашу сторону свою задницу, и громко охает, когда Колямба шлепает ее по промежности своими яйцами, вгоняя в ее влагалище свой член. Мирослава скребет руками по земле и выгибается как кошка, при этом что-то в перерывах между оханьями говоря Колямбе. Но тот, кажется. не обращает на это совершенно никакого внимания, продолжая долбить ее в киску, и вскоре доводит девушку до оргазма, а через минуту кончает и сам...'
			            act 'Далее':gt 'gadforest','1'
		            end
	            else
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Колямба</font></b></center>'
                    '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Колямбу. Вы поболтали с ним немного и отправились дальше.'
                    act 'Далее':gt 'gadforest','1'
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirainforest = 0
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу с Мирой вы встретили Колямбу. Увидев вас он почесал яйца и не обращая внимания на рядом стоящую Мирославу, поволок вас в ближайшие кусты.'
                act 'Далее':forest_gopsex = 1 & temphant = 5 & gt 'hanters'
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mitboyrand = 2
	            mitkaforestsex = 1
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя с Мирой по лесу вы встретили Колямбу. Увидев вас он почесал яйца и схватив вас обеих за руки, поволок в кусты.'
                act 'Далее':gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу с Мирой, вы встретили Колямбу. Вы поболтали с ним немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            end
        end
    else
        if mirainforest = 0:
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
                minut += 5
	            temp = rand (1,2)
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                if temp = 1:'Идя по лесу вы нос к носу столкнулись с Колямбой. Он вытаращился, глядя на вас обнаженную, а вы решили...'
                if temp = 2:'Идя по лесу вы увидели Колямбу. Понимая, что он вас еще не заметил, вы решили...'
                ''
                if temp = 1:
                    act 'Убежать и одеться':
	                    cla
	                    *clr
	                    gopsawnaked += 1
	                    if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                    horny += 10
			            clothesforest = 0
			            swamp_clothes = 0
			            minut += 5
			            tanga = flag_tanga
			            gs 'zz_clothing', 'redress', prev_clothing
			            prev_clothing = -1
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/Swamp/swampbackwaternude1.jpg"></center>'
	                    'Взвизгнув от неожиданности, вы кинулись наутек, в сторону своей одежды. Одевшись и успокоившись вы отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                else
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/mitkahideforest.jpg"></center>'
	                    'Вы быстро спрятались в ближайших кустах, а когда Колямба прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                end
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirainforest = 0
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу вы встретили Колямбу. Увидев его вы попытались одеться, но он без лишних слов схватил вас за руку и потащил в ближайшие кусты.'
                act 'Далее':forest_gopsex = 1 & temphant = 5 & gt 'hanters'
            end
        else
            if mitkasextimes < 13 or gadriver_gang < 3:
                if miragopQW < 11:
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Колямба</font></b></center>'
                    '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                    if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Колямбой. Он вытаращился, глядя на вас обнаженных...'
                    if temp = 2:'Идя по лесу вы увидели Колямбу. Понимая, что он вас еще не заметил, вы решили...'
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись убегать к вашей одежде. Одевшись и успокоившись неспеша отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда Митька прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                elseif miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Колямба</font></b></center>'
                    '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                    if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Колямбой. Он вытаращился, глядя на вас обнаженных...'
                    if temp = 2:'Идя по лесу вы увидели Колямбу. Понимая, что он вас еще не заметил, вы решили...'
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        mirainforest = 0
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись к вашей одежде. Убегая вы успели замить краем глаза, как Колямба, особо не церемонясь схватил её за руку, и поволок в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы побежали дальше одна. Одевшись и успокоившись вы решили...'
	                        act 'Уйти':gt 'gadforest','1'
                            act 'Подсматривать':
		                        cla
		                        *clr
			                    minut += 10
			                    horny += 30
			                    mirasextimes += 1
			                    voyeurism += 1
			                    gs 'stat'
			                    '<center><img src="images/qwest/gadukino/MiraMeadowBJ2.jpg"></center>'
			                    'Мира в одних шлепанцах стоит раком, оттопырив как раз в вашу сторону свою задницу, и громко охает, когда Колямба шлепает ее по промежности своими яйцами, вгоняя в ее влагалище свой член. Мирослава скребет руками по земле и выгибается как кошка, при этом что-то в перерывах между оханьями говоря Колямбе. Но тот, кажется. не обращает на это совершенно никакого внимания, продолжая долбить ее в киску, и вскоре доводит девушку до оргазма, а через минуту кончает и сам...'
			                    act 'Далее':gt 'gadforest','1'
		                    end
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда Колямба прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            temp = rand (1,2)
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Колямбой. Взвизгнув от неожиданности вы кинулись к своей одежде, за улепетывающей со всех ног Мирославой, но он без лишних слов схватил вас в охапку и потащил в ближайшие кусты.'
                if temp = 2:'Идя по лесу вы увидели Митьку. Понимая, что он вас еще не заметил, вы решили...'
                if temp = 1:act 'Далее':mirainforest = 0 & forest_gopsex = 1 & temphant = 5 & gt 'hanters'
                if temp = 2:
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                    'Вы с Мирой спрятались в ближайших кустах, а когда Колямба прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mitboyrand = 2
	            mitkaforestsex = 1
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу с Мирой, вы нос к носу столкнулись с Колямбой. Увидев вас обнаженных он почесал яйца и без разговоров поволок в ближайшие кусты.'
                act 'Далее':gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Колямба</font></b></center>'
                '<center><img src="images/gadukino/mitka/kolyamba.jpg"></center>'
                'Идя по лесу вы увидели Колямбу. Понимая, что он вас еще не заметил, вы решили...'
                act 'Спрятаться':
	                cla
	                *clr
			        minut += 5
			        horny += 5
	                gs'stat'
	                gs'time'
	                '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                'Вы с Мирой спрятались в ближайших кустах, а когда Колямба прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                act 'Далее':gt 'gadforest','1'
                end
            end
        end
    end
end
if $ARGS[0] = 'gopforest_vasyan':
    if current_clothing > 0:
        if mirainforest = 0 or gadriver_gang >= 3:
            if mitkasextimes < 13:
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя по лесу вы встретили Васяна. Поболтав с ним немного вы отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя по лесу вы встретили Васяна. Увидев вас он почесал яйца и поволок ближайшие в кусты.'
                act 'Далее':forest_gopsex = 1 & temphant = 6 & gt 'hanters'
            end
        else
            if mitkasextimes < 13 or gadriver_gang >= 3:
                if miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                mirainforest = 0
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                    '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Васяна. Увидев Миру он не церемонясь схватил её за руку и поволок в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
                    act 'Уйти':gt 'gadforest','1'
                    act 'Подсматривать':
		                cla
		                *clr
			            minut += 5
			            horny += 40
			            mirasextimes += 1
			            voyeurism += 1
			            gs 'stat'
			            '<center><img src="images/qwest/gadukino/MiraMeadowBJ6.jpg"></center>'
			            'Полностью голая Мирослава, согнувшись, стоит перед Васяном и усиленно подставляет ему попку, в которую он и вгоняет свой член. Судя по ее похотливым стонам, ей вполне нравится, что ее имеют в задницу, но уже через пару минут Васян вынимает из нее свой член и спускает ей на ягодицы...'
			            act 'Далее':gt 'gadforest','1'
		            end
	            else
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                    '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                    'Идя по лесу с Мирой, вы встретили Васяна. Вы поболтали с ним немного и отправились дальше.'
                    act 'Далее':gt 'gadforest','1'
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirainforest = 0
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя по лесу с Мирой вы встретили Васяна. Увидев вас он почесал яйца и не обращая внимания на рядом стоящую Мирославу, поволок вас в ближайшие кусты.'
                act 'Давлее':forest_gopsex = 1 & temphant = 6 & gt 'hanters'
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mitboyrand = 3
	            mitkaforestsex = 1
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя с Мирой по лесу вы встретили Васяна. Увидев вас он почесал яйца и схватив вас обеих за руки, поволок в кусты.'
                act 'Далее':gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя по лесу с Мирой, вы встретили Васяна. Вы поболтали с ним немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            end
        end
    else
        if mirainforest = 0:
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
                minut += 5
	            temp = rand (1,2)
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                if temp = 1:'Идя по лесу вы нос к носу столкнулись с Васяном. Он вытаращился, глядя на вас обнаженную, а вы решили...'
                if temp = 2:'Идя по лесу вы увидели Васяна. Понимая, что он вас еще не заметил, вы решили...'
                ''
                if temp = 1:
                    act 'Убежать и одеться':
	                    cla
	                    *clr
	                    gopsawnaked += 1
	                    if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                    horny += 10
			            clothesforest = 0
			            swamp_clothes = 0
			            minut += 5
			            tanga = flag_tanga
			            gs 'zz_clothing', 'redress', prev_clothing
			            prev_clothing = -1
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/Swamp/swampbackwaternude1.jpg"></center>'
	                    'Взвизгнув от неожиданности, вы кинулись наутек, в сторону своей одежды. Одевшись и успокоившись вы отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                else
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/mitkahideforest.jpg"></center>'
	                    'Вы быстро спрятались в ближайших кустах, а когда Васян прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                end
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/vasyan.jpg"></center>'
                'Идя по лесу вы встретили Васяна. Увидев его вы попытались одеться, но он без лишних слов схватил вас за руку и потащил в ближайшие кусты.'
                act 'Далее':forest_gopsex = 1 & temphant = 6 & gt 'hanters'
            end
        else
            if mitkasextimes < 13 or gadriver_gang >= 3:
                if miragopQW < 11:
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                    '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                    if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Васяном. Он вытаращился, глядя на вас обнаженных...'
                    if temp = 2:'Идя по лесу вы увидели Васяна. Понимая, что он вас еще не заметил, вы решили...'
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись к вашей одежде. Одевшись и успокоившись неспеша отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда Васян прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                elseif miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                    '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                    if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Васяном. Он вытаращился, глядя на вас обнаженных...'
                    if temp = 2:'Идя по лесу вы увидели Васяна. Понимая, что он вас еще не заметил, вы решили...'
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        mirainforest = 0
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись к вашей одежде. Убегая вы успели замить краем глаза, как Колямба, особо не церемонясь схватил её за руку, и поволок в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы побежали дальше одна. Одевшись и успокоившись вы решили...'
	                        act 'Уйти':gt 'gadforest','1'
                            act 'Подсматривать':
		                        cla
		                        *clr
			                    minut += 5
			                    horny += 40
			                    mirasextimes += 1
			                    voyeurism += 1
			                    gs 'stat'
			                    '<center><img src="images/qwest/gadukino/MiraMeadowBJ6.jpg"></center>'
			                    'Полностью голая Мирослава, согнувшись, стоит перед Васяном и усиленно подставляет ему попку, в которую он и вгоняет свой член. Судя по ее похотливым стонам, ей вполне нравится, что ее имеют в задницу, но уже через пару минут Васян вынимает из нее свой член и спускает ей на ягодицы...'
			                    act 'Далее':gt 'gadforest','1'
		                    end
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда Васян прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            temp = rand (1,2)
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                if temp = 1:'Идя по лесу с Мирой, вы нос к носу столкнулись с Васяном. Взвизгнув от неожиданности вы кинулись к своей одежде, за улепетывающей со всех ног Мирославой, но он без лишних слов схватил вас в охапку и потащил в ближайшие кусты.'
                if temp = 2:'Идя по лесу вы увидели Васяна. Понимая, что он вас еще не заметил, вы решили...'
                if temp = 1:act 'Далее':mirainforest = 0 & forest_gopsex = 1 & temphant = 6 & gt 'hanters'
                if temp = 2:
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                    'Вы с Мирой спрятались в ближайших кустах, а когда Колямба прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mitboyrand = 3
	            mitkaforestsex = 1
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя по лесу с Мирой, вы нос к носу столкнулись с Васяном. Увидев вас обнаженных он почесал яйца и без разговоров поволок в ближайшие кусты.'
                act 'Далее':gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gs'stat'
	            gs'time'
                '<center><b><font color = maroon>Васян Пакет</font></b></center>'
                '<center><img src="images/gadukino/mitka/vasyan.jpg"></center>'
                'Идя по лесу вы увидели Васяна. Понимая, что он вас еще не заметил, вы решили...'
                act 'Спрятаться':
	                cla
	                *clr
			        minut += 5
			        horny += 5
			        gadboyday = daystart
	                gs'stat'
	                gs'time'
	                '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                'Вы с Мирой спрятались в ближайших кустах, а когда Васян прошел мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                act 'Далее':gt 'gadforest','1'
                end
            end
        end
    end
end
if $ARGS[0] = 'gopforest_2boys':
    if current_clothing > 0:
        if mirainforest = 0:
            temphant = rand(4,6)
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if temphant = 4:'Идя по лесу вы встретили Митьку и Колямбу. Вы поболтали с ними немного и отправились дальше.'
	            if temphant = 5:'Идя по лесу вы встретили Митьку и Васяна. Вы поболтали с ними немного и отправились дальше.'
	            if temphant = 6:'Идя по лесу вы встретили Колямбу и Васяна. Вы поболтали с ними немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if temphant = 4:'Идя по лесу вы встретили Митьку и Колямбу. Увидев вас они  усмехнулись и поволокли ближайшие в кусты.'
	            if temphant = 5:'Идя по лесу вы встретили Митьку и Васяна. Увидев вас они  усмехнулись и поволокли ближайшие в кусты.'
	            if temphant = 6:'Идя по лесу вы встретили Колямбу и Васяна. Увидев вас они  усмехнулись и поволокли ближайшие в кусты.'
                act 'Далее':forest_gopsex = 2 & gt 'hantersex'
            end
        else
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            mitboyrand = rand(1,3)
                if miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                mirainforest = 0
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	                if mitboyrand = 1:'Идя с Мирой по лесу вы встретили Митьку и Колямбу. Увидев Миру они не церемонясь схватили её за руки и поволокли в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
	                if mitboyrand = 2:'Идя с Мирой по лесу вы встретили Митьку и Васяна. Увидев Миру они не церемонясь схватили её за руки и поволокли в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
	                if mitboyrand = 3:'Идя с Мирой по лесу вы встретили Колямбу и Васяна. Увидев Миру они не церемонясь схватили её за руки и поволокли в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
                    act 'Уйти':gt 'gadforest','1'
                    act 'Подсматривать':
		                cla
		                *clr
			            minut += 5
			            horny += 40
			            mirasextimes += 1
			            voyeurism += 1
			            gs 'stat'
		                if mitboyrand = 1:
			                '<center><img src="images/qwest/gadukino/MiraMeadowBJ11.jpg"></center>'
			                'Мира на корточках сидит перед одним из пацанов и как раз принимает себе в рот его сперму. Облизав и спрятав в штаны его член, она то же самое прожелывает с другим...'
		                elseif mitboyrand = 2:
			                '<center><img src="images/qwest/gadukino/MiraMeadowBJ10.jpg"></center>'
			                'Пацаны, вдвоем трахая Миру в рот и в киску, о чем-то со смехом разговаривают между собой. Мирослава же вторит им своими стонами и плямканьями... Минут через пятнадцать они заканчивают и начинают собираться...'
		                else
			                '<center><img src="images/qwest/gadukino/MiraMeadowBJ9.jpg"></center>'
			                'Все трое почти голые и одному из них Мира как раз отсасывает, а второй, судя по всему, уже кончил, а потому просто лапает ее грудь и шебуршит рукой у нее между похотливо рассталвенных ног...'
		                end
			            act 'Далее':gt 'gadforest','1'
		            end
	            else
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	                if mitboyrand = 1:'Идя с Мирой по лесу вы встретили Митьку и Колямбу. Вы поболтали с ними немного и отправились дальше.'
	                if mitboyrand = 2:'Идя с Мирой по лесу вы встретили Митьку и Васяна. Вы поболтали с ними немного и отправились дальше.'
	                if mitboyrand = 3:'Идя с Мирой по лесу вы встретили Колямбу и Васяна. Вы поболтали с ними немного и отправились дальше.'
                    act 'Далее':gt 'gadforest','1'
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirainforest = 0
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if mitboyrand = 1:'Идя с Мирой по лесу вы встретили Митьку и Колямбу. Увидев вас они усмехнулись и не обращая внимания на рядом стоящую Мирославу, поволокли в ближайшие кусты.'
	            if mitboyrand = 2:'Идя с Мирой по лесу вы встретили Митьку и Васяна. Увидев вас они усмехнулись и не обращая внимания на рядом стоящую Мирославу, поволокли в ближайшие кусты.'
	            if mitboyrand = 3:'Идя с Мирой по лесу вы встретили Колямбу и Васяна. Увидев вас они усмехнулись и не обращая внимания на рядом стоящую Мирославу, поволокли в ближайшие кусты.'
                act 'Далее':forest_gopsex = 2 & gt 'hantersex'
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if mitboyrand = 1:'Идя с Мирой по лесу вы встретили Митьку и Колямбу. Увидев вас они обрадовались и схватив вас обеих за руки, поволокли в ближайшие кусты.'
	            if mitboyrand = 2:'Идя с Мирой по лесу вы встретили Митьку и Васяна. Увидев вас они обрадовались и схватив вас обеих за руки, поволокли в ближайшие кусты.'
	            if mitboyrand = 3:'Идя с Мирой по лесу вы встретили Колямбу и Васяна. Увидев вас они обрадовались и схватив вас обеих за руки, поволокли в ближайшие кусты.'
                act 'Далее':mitkaforestsex = 2 & gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if mitboyrand = 1:'Идя с Мирой по лесу вы встретили Митьку и Колямбу. Вы поболтали с ними немного и отправились дальше.'
	            if mitboyrand = 2:'Идя с Мирой по лесу вы встретили Митьку и Васяна. Вы поболтали с ними немного и отправились дальше.'
	            if mitboyrand = 3:'Идя с Мирой по лесу вы встретили Колямбу и Васяна. Вы поболтали с ними немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            end
        end
    else
        if mirainforest = 0:
            temphant = rand(1,3)
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
                minut += 5
	            temp = rand (1,2)
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
                if temp = 1:
	                if temphant = 1:'Идя по лесу вы нос к носу столкнулись с Митькой и Колямбой. Они вытаращились, глядя на вас обнаженную, а вы решили...'
	                if temphant = 2:'Идя по лесу вы нос к носу столкнулись с Митькой и Васяном. Они вытаращились, глядя на вас обнаженную, а вы решили...'
	                if temphant = 3:'Идя по лесу вы нос к носу столкнулись с Колямбой и Васяном. Они вытаращились, глядя на вас обнаженную, а вы решили...'
                else
	                if temphant = 1:'Идя по лесу вы увидели Митьку и Колямбу. Понимая, что он вас еще не заметили, вы решили...'
	                if temphant = 2:'Идя по лесу вы увидели Митьку и Васяна. Понимая, что он вас еще не заметили, вы решили...'
	                if temphant = 3:'Идя по лесу вы увидели Колямбу и Васяна. Понимая, что он вас еще не заметили, вы решили...'
                end
                ''
                if temp = 1:
                    act 'Убежать и одеться':
	                    cla
	                    *clr
	                    gopsawnaked += 1
	                    if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                    horny += 10
			            clothesforest = 0
			            swamp_clothes = 0
			            minut += 5
			            tanga = flag_tanga
			            gs 'zz_clothing', 'redress', prev_clothing
			            prev_clothing = -1
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/Swamp/swampbackwaternude1.jpg"></center>'
	                    'Взвизгнув от неожиданности, вы кинулись наутек, в сторону своей одежды. Одевшись и успокоившись вы отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                else
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/mitkahideforest.jpg"></center>'
	                    'Вы быстро спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                end
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if temphant = 1:'Идя по лесу вы встретили Митьку и Колямбу. Увидев их вы попытались убежать и одеться, но они без лишних слов схватили вас под руки и потащили в ближайшие кусты.'
	            if temphant = 2:'Идя по лесу вы встретили Митьку и Васяна. Увидев их вы попытались убежать и одеться, но они без лишних слов схватили вас под руки и потащили в ближайшие кусты.'
	            if temphant = 3:'Идя по лесу вы встретили Колямбу и Васяна. Увидев их вы попытались убежать и одеться, но они без лишних слов схватили вас под руки и потащили в ближайшие кусты.'
                act 'Далее':forest_gopsex = 2 & gt 'hantersex'
            end
        else
            mitboyrand = rand(1,3)
            if mitkasextimes < 13 or gadriver_gang >= 3:
                if miragopQW < 11:
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
                    if temp = 1:
	                    if mitboyrand = 1:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Колямбой. Они вытаращились, глядя на вас обнаженных, а вы решили...'
	                    if mitboyrand = 2:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Васяном. Они вытаращились, глядя на вас обнаженных, а вы решили...'
	                    if mitboyrand = 3:'Идя с Мирой по лесу вы нос к носу столкнулись с Колямбой и Васяном. Они вытаращились, глядя на вас обнаженных, а вы решили...'
                    else
	                    if mitboyrand = 1:'Идя с Мирой по лесу вы увидели Митьку и Колямбу. Понимая, что они вас еще не заметили, вы решили...'
	                    if mitboyrand = 2:'Идя с Мирой по лесу вы увидели Митьку и Васяна. Понимая, что они вас еще не заметили, вы решили...'
	                    if mitboyrand = 3:'Идя с Мирой по лесу вы увидели Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                    end
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        gadboyday = daystart
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись убегать к вашей одежде. Одевшись и успокоившись неспеша отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                elseif miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
                    if temp = 1:
	                    if mitboyrand = 1:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Колямбой. Они вытаращились, глядя на вас обнаженных, а вы решили...'
	                    if mitboyrand = 2:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Васяном. Они вытаращились, глядя на вас обнаженных, а вы решили...'
	                    if mitboyrand = 3:'Идя с Мирой по лесу вы нос к носу столкнулись с Колямбой и Васяном. Они вытаращились, глядя на вас обнаженных, а вы решили...'
                    else
	                    if mitboyrand = 1:'Идя с Мирой по лесу вы увидели Митьку и Колямбу. Понимая, что они вас еще не заметили, вы решили...'
	                    if mitboyrand = 2:'Идя с Мирой по лесу вы увидели Митьку и Васяна. Понимая, что они вас еще не заметили, вы решили...'
	                    if mitboyrand = 3:'Идя с Мирой по лесу вы увидели Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                    end
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        mirainforest = 0
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись к вашей одежде. Убегая вы успели замить краем глаза, как парни, особо не церемонясь схватили её за руки, и поволокли в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы побежали дальше одна. Одевшись и успокоившись вы решили...'
	                        act 'Уйти':gt 'gadforest','1'
                            act 'Подсматривать':
		                        cla
		                        *clr
			                    minut += 5
			                    horny += 40
			                    mirasextimes += 1
			                    voyeurism += 1
			                    gs 'stat'
		                        if mitboyrand = 1:
			                        '<center><img src="images/qwest/gadukino/MiraMeadowBJ11.jpg"></center>'
			                        'Мира на корточках сидит перед одним из пацанов и как раз принимает себе в рот его сперму. Облизав и спрятав в штаны его член, она то же самое прожелывает с другим...'
		                        elseif mitboyrand = 2:
			                        '<center><img src="images/qwest/gadukino/MiraMeadowBJ10.jpg"></center>'
			                        'Пацаны, вдвоем трахая Миру в рот и в киску, о чем-то со смехом разговаривают между собой. Мирослава же вторит им своими стонами и плямканьями... Минут через пятнадцать они заканчивают и начинают собираться...'
		                        else
			                        '<center><img src="images/qwest/gadukino/MiraMeadowBJ9.jpg"></center>'
			                        'Все трое почти голые и одному из них Мира как раз отсасывает, а второй, судя по всему, уже кончил, а потому просто лапает ее грудь и шебуршит рукой у нее между похотливо рассталвенных ног...'
		                        end
			                    act 'Далее':gt 'gadforest','1'
		                    end
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            temp = rand (1,2)
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
                if temp = 1:
	                if mitboyrand = 1:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Колямбой. Взвизгнув от неожиданности вы кинулись к своей одежде, вслед за улепетывающей со всех ног Мирославой, но они без лишних слов схватили вас в охапку и потащили в ближайшие кусты.'
	                if mitboyrand = 2:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Васяном. Взвизгнув от неожиданности вы кинулись к своей одежде, вслед за улепетывающей со всех ног Мирославой, но они без лишних слов схватили вас в охапку и потащили в ближайшие кусты.'
	                if mitboyrand = 3:'Идя с Мирой по лесу вы нос к носу столкнулись с Колямбой и Васяном. Взвизгнув от неожиданности вы кинулись к своей одежде, вслед за улепетывающей со всех ног Мирославой, но они без лишних слов схватили вас в охапку и потащили в ближайшие кусты.'
                else
	                if mitboyrand = 1:'Идя с Мирой по лесу вы увидели Митьку и Колямбу. Понимая, что они вас еще не заметили, вы решили...'
	                if mitboyrand = 2:'Идя с Мирой по лесу вы увидели Митьку и Васяна. Понимая, что они вас еще не заметили, вы решили...'
	                if mitboyrand = 3:'Идя с Мирой по лесу вы увидели Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                end
                if temp = 1:act 'Далее':mirainforest = 0 & forest_gopsex = 2 & gt 'hantersex'
                if temp = 2:
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                    'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо, так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if mitboyrand = 1:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Колямбой. Увидев вас обнаженных они почесали яйца и без разговоров поволокли в ближайшие кусты.'
	            if mitboyrand = 2:'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой и Васяном. Увидев вас обнаженных они почесали яйца и без разговоров поволокли в ближайшие кусты.'
	            if mitboyrand = 3:'Идя с Мирой по лесу вы нос к носу столкнулись с Колямбой и Васяном. Увидев вас обнаженных они почесали яйца и без разговоров поволокли в ближайшие кусты.'
                act 'Далее':mitkaforestsex = 2 & gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/2boys.'+rand(1,2)+'.jpg"></center>'
	            if mitboyrand = 1:'Идя с Мирой по лесу вы увидели Митьку и Колямбу. Понимая, что они вас еще не заметили, вы решили...'
	            if mitboyrand = 2:'Идя с Мирой по лесу вы увидели Митьку и Васяна. Понимая, что они вас еще не заметили, вы решили...'
	            if mitboyrand = 3:'Идя с Мирой по лесу вы увидели Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                act 'Спрятаться':
	                cla
	                *clr
			        minut += 5
			        horny += 5
	                gs'stat'
	                gs'time'
	                '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                act 'Далее':gt 'gadforest','1'
                end
            end
        end
    end
end
if $ARGS[0] = 'gopforest_3boys':
    if current_clothing > 0:
        if mirainforest = 0:
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя по лесу вы встретили Митьку, Колямбу и Васяна. Вы поболтали с ними немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя по лесу вы встретили Митьку, Колямбу и Васяна. Увидев вас они  усмехнулись и поволокли ближайшие в кусты.'
                act 'Далее':forest_gopsex = 3 & gt 'hanters'
            end
        else
            if mitkasextimes < 13 or gadriver_gang >= 3:
                if miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                mirainforest = 0
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	                'Идя с Мирой по лесу вы встретили Митьку, Колямбу и Васяна. Увидев Миру они не церемонясь схватили её за руки и поволокли в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы решили не вмешиваться и отправились дальше.'
                    act 'Уйти':gt 'gadforest','1'
                    act 'Подсматривать':
		                cla
		                *clr
			            minut += 5
			            horny += 40
			            mirasextimes += 1
			            voyeurism += 1
			            gs 'stat'
			            '<center><img src="images/qwest/gadukino/MiraMeadowBJ8.jpg"></center>'
			            'Мира на корточках сидит между тремя дружками и с удовольствием чавкает их членами. Вы наблюдаете, как они по очереди спукают ей кто в рот, а кто просто на лицо...'
			            act 'Далее':gt 'gadforest','1'
		            end
	            else
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	                'Идя с Мирой по лесу вы встретили Митьку, Колямбу и Васяна. Вы поболтали с ними немного и отправились дальше.'
                    act 'Далее':gt 'gadforest','1'
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirainforest = 0
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя с Мирой по лесу вы встретили Митьку, Колямбу и Васяна. Увидев вас они усмехнулись и не обращая внимания на рядом стоящую Мирославу, поволокли в ближайшие кусты.'
                act 'Далее':forest_gopsex = 3 & gt 'hanters'
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя с Мирой по лесу вы встретили Митьку, Колямбу и Васяна. Увидев вас они обрадовались и схватив вас обеих за руки, поволокли в ближайшие кусты.'
                act 'Далее':mitkaforestsex = 3 & gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя с Мирой по лесу вы встретили Митьку, Колямбу и Васяна. Вы поболтали с ними немного и отправились дальше.'
                act 'Далее':gt 'gadforest','1'
            end
        end
    else
        if mirainforest = 0:
            if mitkasextimes < 13 or gadriver_gang >= 3:
	            cla
	            *clr
                minut += 5
	            temp = rand (1,2)
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
                if temp = 1:
	                'Идя по лесу вы нос к носу столкнулись с Митьку, Колямбу и Васяна. Они вытаращились, глядя на вас обнаженную, а вы решили...'
                else
	                'Идя по лесу вы увидели Митьку, Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                end
                ''
                if temp = 1:
                    act 'Убежать и одеться':
	                    cla
	                    *clr
	                    gopsawnaked += 1
	                    if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                    horny += 10
			            clothesforest = 0
			            swamp_clothes = 0
			            minut += 5
			            tanga = flag_tanga
			            gs 'zz_clothing', 'redress', prev_clothing
			            prev_clothing = -1
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/Swamp/swampbackwaternude1.jpg"></center>'
	                    'Взвизгнув от неожиданности, вы кинулись наутек, в сторону своей одежды. Одевшись и успокоившись вы отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                else
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/mitkahideforest.jpg"></center>'
	                    'Вы быстро спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
	                end
                end
            else
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя по лесу вы встретили Митьку, Колямбу и Васяна. Увидев их вы попытались убежать и одеться, но они без лишних слов схватили вас под руки и потащили в ближайшие кусты.'
                act 'Далее':forest_gopsex = 3 & gt 'hanters'
            end
        else
            if mitkasextimes < 13 or gadriver_gang >= 3:
                if miragopQW < 11:
	                cla
	                *clr
	                minut += 15
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
                    if temp = 1:
	                    'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой, Колямбой и Васяном. Они вытаращились, глядя на вас обнаженных, а вы решили...'
                    else
	                    'Идя с Мирой по лесу вы увидели Митьку, Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                    end
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        gadboyday = daystart
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись убегать к вашей одежде. Одевшись и успокоившись неспеша отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                elseif miragopQW >= 11:
	                cla
	                *clr
	                minut += 5
	                gadboyday = daystart
	                temp = rand (1,2)
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
                    if temp = 1:
	                    'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой, Колямбой и Васяном. Они вытаращились, глядя на вас обнаженных, а вы решили...'
                    else
	                    'Идя с Мирой по лесу вы увидели Митьку, Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                    end
                    if temp = 1:
                        act 'Убежать и одеться':
	                        cla
	                        *clr
	                        mirainforest = 0
	                        gopsawnaked += 1
	                        if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	                        horny += 10
			                clothesforest = 0
			                swamp_clothes = 0
			                minut += 5
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gopforestnude.jpg"></center>'
	                        'Взвизгнув от неожиданности, вы с Мирой кинулись к вашей одежде. Убегая вы успели замить краем глаза, как парни, особо не церемонясь схватили её за руки, и поволокли в ближайшие кусты. Видя , что Мира идет не сопротивляясь, вы побежали дальше одна. Одевшись и успокоившись вы решили...'
	                        act 'Уйти':gt 'gadforest','1'
                            act 'Подсматривать':
		                        cla
		                        *clr
			                    minut += 5
			                    horny += 40
			                    mirasextimes += 1
			                    voyeurism += 1
			                    gs 'stat'
			                    '<center><img src="images/qwest/gadukino/MiraMeadowBJ8.jpg"></center>'
			                    'Мира на корточках сидит между тремя дружками и с удовольствием чавкает их членами. Вы наблюдаете, как они по очереди спукают ей кто в рот, а кто просто на лицо...'
			                    act 'Далее':gt 'gadforest','1'
		                    end
	                    end
                    else
                        act 'Спрятаться':
	                        cla
	                        *clr
			                minut += 5
			                horny += 5
	                        gs'stat'
	                        gs'time'
	                        '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                        'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                        act 'Далее':gt 'gadforest','1'
	                    end
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW < 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            temp = rand (1,2)
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
                if temp = 1:
	                'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой, Колямбой и Васяном. Взвизгнув от неожиданности вы кинулись к своей одежде, вслед за улепетывающей со всех ног Мирославой, но они без лишних слов схватили вас в охапку и потащили в ближайшие кусты.'
                else
	                'Идя с Мирой по лесу вы увидели Митьку, Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                end
                if temp = 1:act 'Далее':mirainforest = 0 & forest_gopsex = 3 & gt 'hanters'
                if temp = 2:
                    act 'Спрятаться':
	                    cla
	                    *clr
			            minut += 5
			            horny += 5
	                    gs'stat'
	                    gs'time'
	                    '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                    'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо, так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                    act 'Далее':gt 'gadforest','1'
                    end
                end
            elseif mitkasextimes >= 13 and miragopQW >= 11 and gadriver_gang < 3:
	            cla
	            *clr
	            minut += 5
	            gadboyday = daystart
	            mirasextimes += 1
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя с Мирой по лесу вы нос к носу столкнулись с Митькой, Колямбой и Васяном. Увидев вас обнаженных они почесали яйца и без разговоров поволокли в ближайшие кусты.'
                act 'Далее':mitkaforestsex = 2 & gt 'mitkasex'
            else
	            cla
	            *clr
	            minut += 15
	            gadboyday = daystart
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/3boys.'+rand(1,2)+'.jpg"></center>'
	            'Идя с Мирой по лесу вы увидели Митьку, Колямбу и Васяна. Понимая, что они вас еще не заметили, вы решили...'
                act 'Спрятаться':
	                cla
	                *clr
			        minut += 5
			        horny += 5
	                gs'stat'
	                gs'time'
	                '<center><img src="images/qwest/gadukino/forest/gophideforest.jpg"></center>'
	                'Вы с Мирой спрятались в ближайших кустах, а когда парни прошли мимо так и не заметив вас, выбрались и переведя дух отправились дальше.'
	                act 'Далее':gt 'gadforest','1'
                end
            end
        end
    end
end
if $ARGS[0] = 'nude_event':
	cla
	*clr
	minut += 5
	horny += 10
	gs'stat'
	gs'time'
    if mirainforest = 0:
	    '<center><img src="images/qwest/gadukino/forest/forest_road.jpg"></center>'
	    'Войдя в лес, вы вдруг вспомнили рассказ Миры про гуляние нагишом и чудодейственное влияние местного воздуха на организм.'
	    ' - Хмммм.... подумали вы. - Байки наверное, но почему бы не попробовать?.'
	    'От одной мысли, что вы будете обнаженной посреди леса, между ножек стало предательски зудеть. Наконец в сотый раз оглянувшись, чтобы удостовериться, что рядом никого нет, вы решаете...'
	else
	    '<center><img src="images/qwest/gadukino/forest/miraforest4.jpg"></center>'
	    'Вы с Мирой вошли в лес, когда она начала разговор.'
	    ' - <<$name[2]>>, помнишь мой рассказ про лес? - начала она. - Байки наверное, но почему бы не попробовать?.'
	    ' - Это про гуляние голышом? - спросили вы её.'
	    ' - Ага, про это, - подтвердила Мира. - Не хочешь сама попробовать?.'
	    ' - Ээээ... ну я не знаю Мир, - неожиданное предложение Миры с одной стороны вас пугало, с другой стороны не на шутку возбуждало. - А если кто-нибудь увидит?'
	    ' - Ой, да кто тут увидит? - засмеялась она и отвернувшись от вас, закричала во весь голос. -  Эййй, люди, ауууу!!!.'
	    'В ответ, кроме щебетания птиц не раздалось ни звука.'
	    ' - Вот видишь, нет тут никого, - она опять повернулась в вашу сторону.'
	    'Вы все равно стояли и нерешительно оглядывались по сторонам.'
	    ' - Ну, <<$name[2]>>, давай, решайся, - весело сказала Мира и начала хватать вас за одежду, пытаясь её стянуть.'
	    'Наконец в сотый раз оглянувшись, чтобы удостовериться, что рядом никого нет, вы решаете...'
    end
	act'Поддаться искушению':
	    cla
		*clr
	    !одежда остается в лесу
		clothesforest = 1
		minut+=5
		flag_tanga = tanga
		tanga = 0
		horny += 10
		if mirainforest = 1:miraQW += 5
		miratalkforest = iif(mirainforest = 0,2,3)
		gs'stat'
		if func('zz_clothing','is_skirt') = 0 and mirainforest = 0:'<center><img src="images/qwest/gadukino/forest/nudeforest.jpg"></center>'
        if func('zz_clothing','is_skirt') = 1 and mirainforest = 0:'<center><img src="images/qwest/gadukino/forest/nudeforest1.'+rand(1,2)+'.jpg"></center>'
		if mirainforest = 1:'<center><img src="images/qwest/gadukino/forest/miraforest5.jpg"></center>'
        gs 'zz_clothing', 'redress', 0
	    if mirainforest = 0:'Вы не стеснясь разделись, оставшись в чем мать родила.'
		if mirainforest = 1:'Видя, что сопротивление сломлено, Мира быстро принялась вас раздевать, оставив в чем мать родила.'
	    act'Далее':gt'gadforest','1'
    end
end
if $ARGS[0] = 'mushroom_pickers1':
	cla
	*clr
	minut += 5
	mushroom_pickersday = daystart
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/mushroom_pickers1.jpg"></center>'
	'Бродя по лесу в поисках грибов, вы замечаете других грибников. Интересно, стоит ли продолжать поиски в этом месте, или стоит перейти в другое?'
	if current_clothing = 0:'Хорошо, что они вас не заметили, а то было бы разговоров на всю деревню.'
	act 'Далее':gt $loc, $metka
end
if $ARGS[0] = 'mushroom_pickers2':
	cla
	*clr
	minut += 5
	mushroom_pickersday = daystart
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/mushroom_pickers2.jpg"></center>'
	'На окраине леса вы увидели других грибников, уходящих в глубь леса. Интересно, может стоит пойти за ними? Вдруг они выведут в грибные места.'
	if current_clothing = 0:'Хорошо, что они вас не заметили, а то было бы разговоров на всю деревню.' & horny += 5
	act 'Остаться тут':gt'gadforest','1'
	if mirainforest = 0:
		act 'Пойти за грибниками':
			temp = rand(1,3)
			if temp = 1: gt 'gadforest','2'
			if temp = 2: gt 'gadforest','3'
			if temp = 3: gt 'gadforest','4'
		end
	end
end
if $ARGS[0] = 'mushroom_pickers3':
	cla
	*clr
	minut += 5
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/mushroom_pickers3.jpg"></center>'
	'Бродя по лесу в поисках грибов, вы замечаете грибников устроивших привал.'
	if current_clothing = 0:'Хорошо, что они вас не заметили, а то было бы разговоров на всю деревню.' & horny += 5
	act 'Пройти мимо':pickersday = daystart & gt $loc, $metka
	if current_clothing > 2:
	    act 'Поздороваться':
			cla
			*clr
			foresteventday = daystart
			minut += 3
			if pickersQW < 3:pickersQW += 1
			gs 'stat'
	        '<center><img src="images/qwest/gadukino/forest/mushroom_pickers3.jpg"></center>'
	        'Вы вежливо поздоровались, проходя мимо. Мужчины глянув на вас, ответили тем же.'
			if pickersQW >= 3:
				act 'Поболтать':
					cla
					*clr
					minut += 10
					pickersQW = rand(4,7)
					goforest += rand(0,1)
					gs 'stat'
					'<center><img src="images/qwest/gadukino/forest/mushroom_pickers3.jpg"></center>'
					if pickersQW <= 5:'Вы весело спрашиваете у грибников, как дела, и один из них, показывает большой палец, кивая на полную корзину грибов. Вы еще минут десять болтаете о лесе и грибных местах, потом попрощавшись уходите.'
				    if pickersQW > 5 and boletus + bilberry < 5:'Вы весело спрашиваете у грибников, как дела, и один из них, показывает большой палец, кивая на полную корзину грибов.
 - А у тебя как дела внучка? - спрашивает один из них.
 - Так себе, - грустно отвечаете вы, показывая свою почти пустую корзинку.
 - Ну что мужики, поможем девушке, отсыпем из наших немного? - весело спрашивает он своих друзей. Те с радостью соглашаются и ваша корзинка сразу становится значительно тяжелее.
Вы еще минут десять болтаете о лесе и грибных местах, потом попрощавшись уходите.' & pickershelp = 1
				    if pickersQW > 5 and boletus + bilberry >= 5:'Вы весело спрашиваете у грибников, как дела, и один из них, показывает большой палец, кивая на полную корзину грибов.
 - А у тебя как дела внучка? - спрашивает один из них.
 - Сегодня нормально, - отвечаете вы, показывая свою корзинку.
Вы еще минут десять болтаете о лесе и грибных местах, потом попрощавшись уходите.'
                    if pickershelp = 1:pickershelp = 0 & boletus += rand(1,2) & bilberry += rand(1,2)
					act 'Уйти':gt $loc, $metka
				end
	        end
            act 'Уйти':gt $loc, $metka
	    end
	end
end
if $ARGS[0] = 'mushroom':
	cla
	*clr
	foresteventday = daystart
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/mushroom0.'+rand(1,3)+'.jpg"></center>'
	'Бродя по лесу, вы наткнулись на грибную поляну. Вот так удача!.'
	act 'Собирать грибы':
	    cla
	    *clr
	    minut += 60
	    boletus += rand (5,10)
	    gs'stat'
        if current_clothing > 2 and func('zz_clothing','is_skirt') = 0:'<center><img src="images/qwest/gadukino/forest/mushroom1.jpg"></center>'
	    if current_clothing > 2 and tanga = 1 and func('zz_clothing','is_skirt') = 1:'<center><img src="images/qwest/gadukino/forest/mushroom2.jpg"></center>'
	    if current_clothing > 2 and tanga = 0 and func('zz_clothing','is_skirt') = 1:'<center><img src="images/qwest/gadukino/forest/mushroom3.jpg"></center>'
	    if current_clothing = 0:'<center><img src="images/qwest/gadukino/forest/mushroom4.'+rand(1,2)+'.jpg"></center>'
	    'Вы принялись собирать грибы стараясь все вместить в корзину.'
	    act 'Далее':gt $loc, $metka
	end
end
if $ARGS[0] = 'bilberry':
	cla
	*clr
	foresteventday = daystart
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/bilberry3.jpg"></center>'
	'Бродя по лесу, вы наткнулись на поляну с ягодами. Вот так удача!.'
	act 'Собирать ягоды':
	    cla
	    *clr
	    minut += 60
	    bilberry += rand (5,10)
	    gs'stat'
        '<center><img src="images/qwest/gadukino/forest/bilberry1.jpg"></center>'
	    'Вы принялись собирать грибы стараясь все вместить в корзину.'
	    act 'Далее':gt $loc, $metka
	end
end
if $ARGS[0] = 'basket':
	cla
	*clr
	minut += 5
	temp = rand(1,2)
	foresteventday = daystart
	gs'stat'
	gs'time'
    if temp = 1:
	    '<center><img src="images/qwest/gadukino/forest/basket_boletus.jpg"></center>'
	    'Бродя по лесу вы находите карзину полную грибов. Странно, наверное кто-то забыл её здесь или просто потерял.'
	    act 'Забрать':boletus += 10 & gt $loc, $metka
	end
    if temp = 2:
	    '<center><img src="images/qwest/gadukino/forest/basket_bilberry.jpg"></center>'
	    'Бродя по лесу вы находите карзину полную ягод. Странно, наверное кто-то забыл её здесь или просто потерял.'
	    act 'Забрать':bilberry += 10 & gt $loc, $metka
	end
end
if $ARGS[0] = 'picnic':
	cla
	*clr
	minut += 5
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/picnic1.'+rand(1,4)+'.jpg"></center>'
	'На окраине леса вы увидели людей. Судя по всему у них тут семейный пикник.'
	if current_clothing = 0:'Хорошо, что они вас не заметили.'
	if current_clothing = 0:
		act 'Спрятаться и одеться':
			cla
			*clr
			clothesforest = 0
			swamp_clothes = 0
			minut += 5
			tanga = flag_tanga
			gs 'zz_clothing', 'redress', prev_clothing
			prev_clothing = -1
			if func('zz_clothing','is_skirt') = 0:'<center><img src="images/qwest/gadukino/forest/nudeforest.jpg"></center>'
            if func('zz_clothing','is_skirt') = 1:'<center><img src="images/qwest/gadukino/forest/nudeforest1.'+rand(1,2)+'.jpg"></center>'
			'Вы переоделись в свою одежду.'
			act 'Назад': gt 'gadforest','1'
		end
 	else
	    act 'Уйти':gt'gadforest','1'
	end
end
if $ARGS[0] = 'forest_hanters':
	*clr & cla
	minut += 5
	foresteventday = daystart
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/forest_hanters'+rand(1,2)+'.jpg"></center>'
	if hantersKnow = 0:'Бродя по лесу вы наткнулись людей. Судя по внешнему виду это были охотники.'
	if hantersKnow > 0:'Бродя по лесу вы увидели людей. Это были ваши знакомые охотники Андрей, Сергей и Игорь.'
	''
	if forest_lost = 1:
	    act 'Далее':
            if hantersKnow = 0:
	            *clr & cla
	            minut += 5
	            forest_lost = 0
	            hantersKnow = 1
	            goforest += 1
	            gs'stat'
	            gs'time'
                if month >= 5 and month <= 9:
                    if current_clothing > 0:'<center><img src="images/qwest/gadukino/forest/gadfear1.jpg"></center>'
                    if current_clothing = 0:'<center><img src="images/qwest/gadukino/forest/gadfear2.jpg"></center>'
                else
                    '<center><img src="images/qwest/gadukino/forest/gadfear3.jpg"></center>'
                end
                if current_clothing > 0:
                    '- Дяденьки, помогите, -  кинулись вы к ним с криком.'
                    '- Что случилось? -  встрепенулись они, выставив ружья в разные стороны.'
                    '- Я заблудилась, а в лесу так страаашноо, - со слезами ответили вы.'
                    '- Тьфу ты, - сплюнул на землю мужчина постарше. - Ты так кричала, что мы подумали, что за тобой стая волков гонится, не меньше.'
                    if wolf_know = 0:'- А они тут есть? - в ужасе распахнули вы глаза.'
                    if wolf_know = 0:'- Конечно, - сказал охотник. - Днем они в основном не показываются, а вот ночью в лес ходить не советую.'
                    '- Да хорош пугать девчонку, - сказал другой охотник. - Лучше бы присесть предложил, смотри, умаялась вся.'
                    '- Да, действительно, пошли присядем, - согласился первый. - В ногах правды нет.'
                    '- Ага, - хохотнул второй. - И выше её тоже нет.'
                    'После этого вы отправились на видневшуюся за деревьями поляну.'
                else
                    'Вы замерли, не зная что вам делать, то ли спрятаться, то ли попросить помощи. Но прятаться было уже поздно, мужчины вас заметили и вы не смело двинулись к ним на встречу. Пока вы шли к ним, мужчины не сводили с вас глаз. Вам было неприятно под этими изучающими взглядами, но другого выхода не было.'
                    '- Что случилось? -  начал один, постарше, когда вы подошли ближе. -  И почему ты в таком... хмммм... виде?'
                    '- Я заблудилась, - ответили вы со слезами на глазах. И начали нести всякую околесицу про маньяков, насильников, погони и другие нелепости, объясняя свой совсем не подходящий для прогулки по лесу вид.'
                    '- Ладно, ладно, успокойся, - прервал он вас. - Все уже позади. Это хорошо, что ты нас встретила, а не стаю волков каких.'
                    if wolf_know = 0:'- А они тут есть? - в ужасе распахнули вы глаза.'
                    if wolf_know = 0:'- Конечно, - сказал охотник. - Днем они в основном не показываются, а вот ночью в лес ходить не советую.'
                    '- Да хорош пугать девчонку, - сказал другой охотник. - Лучше дай ей чем прикрыться, а то стоит, красная как рак. И присесть бы предложил, смотри, умаялась вся.'
                    '- Да, действительно,- согласился первый и покапавшись в рюкзаке достал кусок какой-то ткани. - Держи, не Дольче Габбана конечно, но другого все равно нет.'
                    '- Спасибо, - пискнули в ответ вы и быстренько обмотались тканью как полотенцем.'
                    '- Ну, а теперь пошли присядем, познакомимся, - сказал первый охотник. - В ногах правды нет.'
                    '- Ага, - хохотнул второй. - И выше её тоже нет.'
                    'После этого вы отправились на находящуюся за деревьями поляну.'
                    hanterslut += 1
                end
                act 'Далее':
	                *clr & cla
	                minut += 30
	                wolf_know = 1
	                if current_clothing = 0:
		                swamp_clothes = 1
		                gs 'zz_clothing', 'redress', 1
	                end
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/Swamp/hanters.jpg"></center>'
                    'Добравшись до поляны, парни уселись прямо на землю. Вы, немного подумав, поступили так же.'
	                if vnesh >= 40:'-Как звать-величать тебя, красавица?- спросил один из них.'
	                if vnesh < 40:'-Как звать-величать то тебя?- спросил один из них.'
                    '- <<$name[1]>>, - ответили вы.'
                    if gadriver_gang = 0:
                        '-А я Андрей, - ответил ответил мужчина постарше, - а это друзья мои из центра, Игорь и Сергей.'
                        '-А твоя фамилия не <<$surname>> случайно? - спросил он. Вы удивленно посмотрели на него и кивнули.'
                        '-Не удивляйся <<$name[1]>>, ты очень похожа на маму в молодости. А я её ... Хммм... очень хорошо знал когда-то, я ведь тоже из Гадюкино.- сказал Андрей.'
                    else
                        '-Ба, кого к нам занесло - удивлённо протянул мужчина постарше, присмотревшись к вам повнимательней, - это же <<$name[1]>> <<$surname>>, местная шлюшка.'
                        'Вы удивленно посмотрели на него.'
                        '-Не удивляйся, я ведь тоже из Гадюкино, а ты очень похожа на маму в молодости, и судя по всему такая же блядоватая.- сказал он.'
                        ' Я Андрей, - добавил он дальше, - а это друзья мои из центра, Игорь и Сергей.'
                        '-Да не вскакивай ты, мы дяди добрые, не кусаемся.- сказал Сергей, видя вашу попытку вскочить на ноги.'
                        hantersKnowSlut = 1
                        hantersRape = 1
                    end
                    'Отдохнув полчаса охотники начали подниматься на ноги.'
                    'Ладно <<$name[1]>>, давай мы тебя до болота доведем, -  сказал Андрей. -  А там дорога есть на деревню, а если захочешь, у нас в гостях останешься.'
                    act 'Далее':goswamp = 1 & hanters = 1 & minut += 60 & gt 'swamp_yard'
                end
            else
	            *clr & cla
	            minut += 5
	            goforest += 1
	            forest_lost = 0
	            gs'stat'
	            gs'time'
                if month >= 5 and month <= 9:
                    if current_clothing > 0:'<center><img src="images/qwest/gadukino/forest/gadfear1.jpg"></center>'
                    if current_clothing = 0:'<center><img src="images/qwest/gadukino/forest/gadfear2.jpg"></center>'
                else
                    '<center><img src="images/qwest/gadukino/forest/gadfear3.jpg"></center>'
                end
                if current_clothing > 0:
                    '- Ой, ребята, помогите, -  кинулись вы к ним с криком.'
                    '- Что случилось? -  встрепенулись они, выставив ружья в разные стороны.'
                    '- Я заблудилась, а в лесу так страаашноо, - со слезами ответили вы.'
                    '- Тьфу ты, - сплюнул на землю Андрей. - Ты так кричала, что мы подумали, что за тобой стая волков гонится, не меньше.'
                    if wolf_know = 0:'- А они тут есть? - в ужасе распахнули вы глаза.'
                    if wolf_know = 0:'- Конечно, - ответил он. - Днем они в основном не показываются, а вот ночью в лес ходить не советую.'
                    if hantersKnowSlut = 0:
                        '- Да хорош пугать <<$name_a[1]>>, - сказал другой охотник. - Давай её лучше к болоту выведем.'
                        '- Да, действительно, пошли к болоту, - согласился первый. - А там решишь сама, или к нам в гости или в деревню.'
                        'После этого вы отправились c ребятами через лес к болоту.'
                        act 'Далее':goswamp = 1 & hanters = 1 & wolf_know = 1 & minut += 60 & gt 'swamp_yard'
                    else
                        '- Да хорош пугать её, - сказал Игорь. - Давай её лучше к болоту выведем.'
                        '- Да, действительно, к болоту пойдем, - согласился Андрей и усмехнувшись добавил. - Но попозже...'
                        'Вы прекрасно поняли намек.'
                        if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	                    if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнями, прекрасно понимая куда и зачем вас ведут.'
	                    if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнями, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
						act 'Далее':
							goswamp = 1
							hanters = 1
							temp = rand(1,3)
							temphant = rand(1,3)
							if temp = 1:forest_hantersex = 1 & gt 'hanters'
							if temp = 2:forest_hantersex = 2 & gt 'hantersex'
							if temp = 3:forest_hantersex = 3 & gt 'hanters'
						end
                    end
                else
                    '- <<$name[1]>>, что случилось? -  спросил Андрей, когда вы подошли ближе. -  И почему ты в таком... хмммм... виде?'
                    '- Я заблудилась, - ответили вы со слезами на глазах. И начали нести всякую околесицу про маньяков, насильников, погони и другие нелепости, объясняя свой совсем не подходящий для прогулки по лесу вид.'
                    '- Ладно, ладно, успокойся, - прервал он вас. - Все уже позади. Это хорошо, что ты нас встретила, а не стаю волков каких.'
                    if wolf_know = 0:'- А они тут есть? - в ужасе распахнули вы глаза.'
                    if wolf_know = 0:'- Конечно, - ответил он. - Днем они в основном не показываются, а вот ночью в лес ходить не советую.'
                    if hantersKnowSlut = 0:
                        swamp_cloth = 1
						gs 'zz_clothing', 'redress', 1
                        '- Да хорош пугать <<$name_a[1]>>, - сказал другой охотник. - Дай ей чем прикрыться и пошли её лучше к болоту выведем.'
                        '- Да, действительно, пошли к болоту, - согласился первый, протянув вам кусок ткани, который он достал из рюкзака. - А там решишь сама, или к нам в гости или в деревню.'
                        'Вы быстренько заматотались в ткань и после этого вы отправились c ребятами через лес к болоту.'
                        act 'Далее':goswamp = 1 & hanters = 1 & wolf_know = 1 & minut += 60 & gt 'swamp_yard'
                    else
                        '- Да хорош пугать её, - сказал Игорь. - Давай её лучше к болоту выведем.'
                        '- Да, действительно, к болоту пойдем, - согласился Андрей и взяв вас за руку, усмехнувшись добавил. - Но попозже...Разве никто не соскучился по нашей шлюшке?'
                        if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	                    if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнями, прекрасно понимая куда и зачем вас ведут.'
	                    if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнями, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
						act 'Далее':
							goswamp = 1
							hanters = 1
							temp = rand(1,3)
							temphant = rand(1,3)
							if temp = 1:forest_hantersex = 1 & gt 'hanters'
							if temp = 2:forest_hantersex = 2 & gt 'hantersex'
							if temp = 3:forest_hantersex = 3 & gt 'hanters'
						end
                    end
                end
            end
        end
    else
        if current_clothing > 0:
            act 'Подойти':
                if hantersKnow = 0:
	                *clr & cla
	                minut += 30
	                hantersKnow = 1
	                goforest += 1
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/Swamp/hanters.jpg"></center>'
                    'Вы решили подойти подойти к незнакомцам и пообщаться. Чем черт не шутит, вдруг грибные места покажут. После взаимных приветствий вы всей компанией уселись прямо на землю и начался процесс знакомства.'
	                if vnesh >= 40:'-Как звать-величать тебя, красавица?- спросил один из них.'
	                if vnesh < 40:'-Как звать-величать то тебя?- спросил один из них.'
                    '- <<$name[1]>>, - ответили вы.'
                    if gadriver_gang = 0:
                        '-А я Андрей, - ответил ответил мужчина постарше, - а это друзья мои из центра, Игорь и Сергей.'
                        '-А твоя фамилия не <<$surname>> случайно? - спросил он. Вы удивленно посмотрели на него и кивнули.'
                        '-Не удивляйся <<$name[1]>>, ты очень похожа на маму в молодости. А я её ... Хммм... очень хорошо знал когда-то, я ведь тоже из Гадюкино.- сказал Андрей.'
                    else
                        '-Ба, кого к нам занесло - удивлённо протянул мужчина постарше, присмотревшись к вам повнимательней, - это же <<$name[1]>> <<$surname>>, местная шлюшка.'
                        'Вы удивленно посмотрели на него.'
                        '-Не удивляйся, я ведь тоже из Гадюкино, а ты очень похожа на маму в молодости, и судя по всему такая же блядоватая.- сказал он.'
                        '-Я Андрей, - добавил он дальше, - а это друзья мои из центра, Игорь и Сергей.'
                        '-Да не вскакивай ты, мы дяди добрые, не кусаемся.- сказал Сергей, видя вашу попытку вскочить на ноги.'
                        hantersKnowSlut = 1
                        hantersRape = 1
                    end
                    'Поболтав с вами о том, о сём, еще полчаса, охотники стали собираться..'
                    ' - Ладно <<$name[1]>>, пора нам, -  сказал Андрей. - До встречи.'
                    if hantersKnowSlut = 1:' -  Если хочешь, можем тебя до болота довести, - добавил он чуть помедлив. - Там дорога есть на деревню. А если захочешь, у нас в гостях останешься.'
                    if hantersKnowSlut = 1:act 'Идти с охотниками':goswamp = 1 & hanters = 1 & minut += 60 & gt 'swamp_yard'
                    act 'Остаться в лесу':gt $loc, $metka
                else
	                *clr & cla
	                minut += 5
	                goforest += 1
	                gs'stat'
	                gs'time'
                    '<center><img src="images/qwest/gadukino/Swamp/hanters.jpg"></center>'
                    'Вы решили подойти к ребятам и пообщаться.'
                    if hantersKnowSlut = 0 or hantersKnowSlut > 0 and hantslutsex > 0:
                        minut += 30
                        'Поболтав с вами о том, о сём, еще полчаса, охотники стали собираться..'
                        ' - Ладно <<$name[2]>>, пора нам, -  сказал Андрей. -  А может к нам в гости заглянешь?.'
                        act 'Идти с охотниками':goswamp = 1 & hanters = 1 & minut += 60 & gt 'swamp_yard'
                        act 'Остаться тут':gt $loc, $metka
                    else
                        ' - О, <<$name[2]>>, вовремя ты появилась, -  сказал Андрей с довольной улыбкой беря вас за руку.'
                        if horny < 40:' Вы покорно пошли следом, прекрасно понимая куда и зачем вас ведут.'
	                    if horny >= 40 and horny < 70:' - Надо, так надо, - подумали вы и пошли с парнями, прекрасно понимая куда и зачем вас ведут.'
	                    if horny >= 70:' - Отлично, то что нужно, главное вовремя, - подумали вы, чувствуя как ваша киска изнывает от желания. Вы пошли с парнями, чуть ли не обгоняя его, и уже не ясно было, кто кого ведет.'
						act 'Идти с охотниками':
							hanters = 1
							temp = rand(1,3)
							temphant = rand(1,3)
							goswamp = 1
							if temp = 1:forest_hantersex = 1 & gt 'hanters'
							if temp = 2:forest_hantersex = 2 & gt 'hantersex'
							if temp = 3:forest_hantersex = 3 & gt 'hanters'
						end
	                end
                end
            end
            act 'Пройти мимо':gt $loc, $metka
		else
            act 'Спрятаться':
	            *clr & cla
	            minut += 5
	            gs'stat'
	            gs'time'
                '<center><img src="images/qwest/gadukino/forest/hiding_woods.jpg"></center>'
                'Вы решили спрятаться от греха, пока вас не заметили. Подождав, пока мужчины уйдут, вы продолжили свой путь.'
                act 'Далее':gt $loc, $metka
            end
        end
    end
end
if $ARGS[0] = 'forest_road':
	cla
	*clr
	temp = rand(1,10)
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/forest_road.jpg"></center>'
	'Вы отправились по дороге в сторону деревни, весело напевая себе под нос.'
	if temp > 3:
		act 'Далее':
			cla
			*clr
			minut += 75
            gs'stat'
            gs'time'
            '<center><img src="images/qwest/gadukino/forest/howl.jpg"></center>'
			'Пройдя примерно половину пути, вы вдруг услышали страшный вой.'
			if dom >= 0:
			    act 'Убегать':
			        cla
			        *clr
                    wolftemp = rand(0,200)
                    lostrand = rand(0,100)
                    gs'stat'
                   '<center><img src="images/qwest/gadukino/forest/run.jpg"></center>'
			       'Вы не раздумывая кинулись наутек.'
                    act 'Далее':
                        if beg > wolftemp and goforest > lostrand:
                            cla
			                *clr
			                minut += 25
                            sweat += 2
                            gs'stat'
                            '<center><img src="images/qwest/gadukino/forest/run_end1.jpg"></center>'
			                'Вы долго бежали по дороге, боясь оглянуться назад. В конец выбившись из сил вы остановились и осмотревшись поняли, что за вами никто не гонится, а вы уже на окраине леса.'
			                act 'Далее':gt 'gadforest','1'
			            elseif  beg > wolftemp and goforest < lostrand:
                            cla
			                *clr
			                minut += 25
 			                temp = rand(1,4)
 			                sweat += 2
                            gs'stat'
                            '<center><img src="images/qwest/gadukino/forest/run_end2.jpg"></center>'
			                'Вы долго бежали не разбирая дороги и боясь оглянуться назад. В конец выбившись из сил вы остановились и осмотревшись поняли, что за вами никто не гонится, но вы понятия не имеете, где находитесь.'
                            act 'Далее':
                                act 'Далее':gt 'gadforestlost','main', rand(1,4)
                            end
                        else
                            cla
			                *clr
			                minut += 5
                            gs'stat'
                            gs'time'
                            '<center><img src="images/qwest/gadukino/forest/run_wolf.jpg"></center>'
			                'Вы кинулись в панике бежать, но почти сразу же почувствовали мощной толчок в спину и упали.'
                            act 'Далее':
                                cla
			                    *clr
			                    minut += 1
                                gs'stat'
                                '<center><img src="images/qwest/gadukino/forest/wolf.jpg"></center>'
			                    'Чуть приподнявшись на руках вы оглянулись и увидели оскаленную пасть волка, прямо у себя перед лицом.'
                                act 'Закричать от ужаса': gt'gameover',9
                            end
                        end
                    end
                end
            else
			    act 'Застыть в ужасе':
			        cla
			        *clr
                    minut += 1
                    gs'stat'
                   '<center><img src="images/qwest/gadukino/forest/horror.jpg"></center>'
			       'На вас напал ступор и вы застыли в ужасе, глядя в темноту в которой были уже заметны неясные тени.'
                    act 'Далее': gt'gameover',8
                end
            end
        end
 	else
	    act 'Далее':minut += 150 & gt 'gadforest','1'
	end
end
if $ARGS[0] = 'swamp_road':
	cla
	*clr
	temp = rand(1,10)
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/forest_road.jpg"></center>'
	'Вы отправились по дороге в сторону болота, весело напевая себе под нос.'
	if temp > 3:
		act 'Далее':
			cla
			*clr
			minut += 75
            gs'stat'
            gs'time'
            '<center><img src="images/qwest/gadukino/forest/howl.jpg"></center>'
			'Пройдя примерно половину пути, вы вдруг услышали страшный вой.'
			if dom >= 0:
			    act 'Убегать':
			        cla
			        *clr
                    wolftemp = rand(0,200)
                    lostrand = rand(0,100)
                    gs'stat'
                   '<center><img src="images/qwest/gadukino/forest/run.jpg"></center>'
			       'Вы не раздумывая кинулись наутек.'
                    act 'Далее':
                        if beg > wolftemp and goforest > lostrand:
                            cla
			                *clr
			                minut += 25
                            sweat += 2
                            gs'stat'
                            '<center><img src="images/qwest/gadukino/forest/run_end1.jpg"></center>'
			                'Вы долго бежали по дороге, боясь оглянуться назад. В конец выбившись из сил вы остановились и осмотревшись поняли, что за вами никто не гонится, а вы уже на окраине леса.'
			                act 'Далее':gt 'gadforest','1'
			            elseif  beg > wolftemp and goforest < lostrand:
                            cla
			                *clr
			                minut += 25
 			                temp = rand(1,4)
 			                sweat += 2
                            gs'stat'
                            '<center><img src="images/qwest/gadukino/forest/run_end2.jpg"></center>'
			                'Вы долго бежали не разбирая дороги и боясь оглянуться назад. В конец выбившись из сил вы остановились и осмотревшись поняли, что за вами никто не гонится, но вы понятия не имеете, где находитесь.'
                            act 'Далее':
                                act 'Далее':gt 'gadforestlost','main', rand(1,4)
                            end
                        else
                            cla
			                *clr
			                minut += 5
                            gs'stat'
                            '<center><img src="images/qwest/gadukino/forest/run_wolf.jpg"></center>'
			                'Вы кинулись в панике бежать, но почти сразу же почувствовали мощной толчок в спину и упали.'
                            act 'Далее':
                                cla
			                    *clr
			                    minut += 1
                                gs'stat'
                                '<center><img src="images/qwest/gadukino/forest/wolf.jpg"></center>'
			                    'Чуть приподнявшись на руках вы оглянулись и увидели оскаленную пасть волка, прямо у себя перед лицом.'
                                act 'Закричать от ужаса': gt'gameover',8
                            end
                        end
                    end
                end
            else
			    act 'Застыть в ужасе':
			        cla
			        *clr
                    minut += 1
                    gs'stat'
                   '<center><img src="images/qwest/gadukino/forest/horror.jpg"></center>'
			       'На вас напал ступор и вы застыли в ужасе, глядя в темноту в которой были уже заметны неясные тени.'
                    act 'Далее': gt'gameover',8
                end
            end
        end
 	else
	    act 'Далее':minut += 150 & gt 'swamp'
	end
end
if $ARGS[0] = 'lost':
	cla
	*clr
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/gadforestsearch0.4.jpg"></center>'
	'Вы блуждаете по лесу, пытаясь найти знакомые места и выйти из леса.'
    act 'Далее':
	    cla
	    *clr
		minut += 75
        gs'stat'
        gs'time'
        '<center><img src="images/qwest/gadukino/forest/howl.jpg"></center>'
	    'Вдруг в чаще леса послышался страшный страшный вой.'
		if dom >= 0:
			act 'Убегать':
			    cla
			    *clr
                wolftemp = rand(0,300)
                gs'stat'
                '<center><img src="images/qwest/gadukino/forest/run.jpg"></center>'
			    'Вы не раздумывая кинулись наутек.'
			    if  beg > wolftemp:
                    cla
			        *clr
			        minut += 25
 			        temp = rand(1,4)
 			        sweat += 2
                    gs'stat'
                    '<center><img src="images/qwest/gadukino/forest/run_end2.jpg"></center>'
			        'Вы долго бежали не разбирая дороги и боясь оглянуться назад. В конец выбившись из сил вы остановились и осмотревшись поняли, что за вами никто не гонится, но вы понятия не имеете, где находитесь.'
                    act 'Далее':
                        act 'Далее':gt 'gadforestlost','main', rand(1,4)
                    end
                else
                    cla
			        *clr
			        minut += 5
                    gs'stat'
                    '<center><img src="images/qwest/gadukino/forest/run_wolf.jpg"></center>'
			        'Вы кинулись в панике бежать, но почти сразу же почувствовали мощной толчок в спину и упали.'
                    act 'Далее':
                        cla
			            *clr
			            minut += 1
                        gs'stat'
                        '<center><img src="images/qwest/gadukino/forest/wolf.jpg"></center>'
			            'Чуть приподнявшись на руках вы оглянулись и увидели оскаленную пасть волка, прямо у себя перед лицом.'
                        act 'Закричать от ужаса': gt'gameover',8
                    end
                end
            end
        else
			act 'Застыть в ужасе':
			    cla
			    *clr
                minut += 1
                gs'stat'
                '<center><img src="images/qwest/gadukino/forest/horror.jpg"></center>'
			    'На вас напал ступор и вы застыли в ужасе, глядя в темноту в которой были уже заметны неясные тени.'
                act 'Далее': gt'gameover',8
            end
        end
    end
end
if $ARGS[0] = 'relax':
	cla
	*clr
	gs'stat'
	gs'time'
	'<center><img src="images/qwest/gadukino/forest/gadforestrelax3.jpg"></center>'
	'Вы сидите в лесу и отдыхаете, пытаясь вспомнить дорогу до деревни.'
    act 'Далее':
	    cla
	    *clr
		minut += 75
        gs'stat'
        gs'time'
        '<center><img src="images/qwest/gadukino/forest/howl.jpg"></center>'
	    'Вдруг в чаще леса послышался страшный страшный вой.'
		if dom >= 0:
			act 'Убегать':
			    cla
			    *clr
                wolftemp = rand(0,300)
                gs'stat'
                '<center><img src="images/qwest/gadukino/forest/run.jpg"></center>'
			    'Вы не раздумывая кинулись наутек.'
			    if  beg > wolftemp:
                    cla
			        *clr
			        minut += 25
 			        temp = rand(1,4)
 			        sweat += 2
                    gs'stat'
                    '<center><img src="images/qwest/gadukino/forest/run_end2.jpg"></center>'
			        'Вы долго бежали не разбирая дороги и боясь оглянуться назад. В конец выбившись из сил вы остановились и осмотревшись поняли, что за вами никто не гонится, но вы понятия не имеете, где находитесь.'
                    act 'Далее':
                        act 'Далее':gt 'gadforestlost','main', rand(1,4)
                    end
                else
                    cla
			        *clr
			        minut += 5
                    gs'stat'
                    '<center><img src="images/qwest/gadukino/forest/run_wolf.jpg"></center>'
			        'Вы кинулись в панике бежать, но почти сразу же почувствовали мощной толчок в спину и упали.'
                    act 'Далее':
                        cla
			            *clr
			            minut += 1
                        gs'stat'
                        '<center><img src="images/qwest/gadukino/forest/wolf.jpg"></center>'
			            'Чуть приподнявшись на руках вы оглянулись и увидели оскаленную пасть волка, прямо у себя перед лицом.'
                        act 'Закричать от ужаса': gt'gameover',8
                    end
                end
            end
        else
			act 'Застыть в ужасе':
			    cla
			    *clr
                minut += 1
                gs'stat'
                '<center><img src="images/qwest/gadukino/forest/horror.jpg"></center>'
			    'На вас напал ступор и вы застыли в ужасе, глядя в темноту в которой были уже заметны неясные тени.'
                act 'Далее': gt'gameover',8
            end
        end
    end
end