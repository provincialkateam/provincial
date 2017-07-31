$boy = 'Мирослава'
boyage = age
temp = RAND(0,20)
mira_temp = rand(0,20)
gs'stat'
'<center><B>Мирослава</B></center>'
if mirainriver = 1:
	if current_clothing > 0:
		'<center><img src="images/qwest/gadukino/river/MiraBeach.jpg"></center>'
		'Мира лежит на пляже, млея на солнце.'
	else
		'<center><img src="images/qwest/gadukino/river/MiraBeachNude.jpg"></center>'
		'Голенькая Мира лежит на пляже, млея на солнце.'
	end
else
    if miragopQW = 0:
	    '<center><img src="images/qwest/gadukino/Mira.jpg"></center>'
    elseif miragopQW > 0 and miragopQW < 4:
	    '<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
    elseif miragopQW >= 4 and miragopQW < 8:
	    '<center><img src="images/qwest/gadukino/mira0,'+rand(0,5)+'.jpg"></center>'
    elseif miragopQW >= 8 and miragopQW < 12:
	    '<center><img src="images/qwest/gadukino/mira1,'+rand(0,2)+'.jpg"></center>'
    elseif miragopQW >= 12 and miragopQW < 20:
	    '<center><img src="images/qwest/gadukino/mira2,'+rand(0,5)+'.jpg"></center>'
    elseif miragopQW >= 20:
	    '<center><img src="images/qwest/gadukino/mira3,'+rand(0,3)+'.jpg"></center>'
    end
end
if mirainmeadow = 1:'- Чудесное место, здесь так уютно и солнечно! - восклицает Мира, с восторгом кружась по поляне.'
if mirainriver = 1:'Она общительная девушка. Мирослава с отцом совсем недавно вынуждена была перехать сюда. Из-за огромных долгов отца им пришлось продать все имущество, в том числе и квартиру в центре города, а на те деньги, что у них остались, они смогли позволить себе купить дом только в такой вот захудалой деревне.'
if mirainriver = 0 and mirainmeadow = 0:'Мирослава общительная девушка. Ей <<boyage>> лет. Она с отцом совсем недавно вынуждена была перехать в сюда. Из-за огромных долгов отца им пришлось продать все имущество, в том числе и квартиру в центре города, а на те деньги, что у них остались, они смогли позволить себе купить дом только в такой вот захудалой деревне.'
if miraQW < 5:'У вас с ней прохладные отношения.'
if miraQW >= 5 and miraQW < 15:'У вас с ней нормальные отношения.'
if miraQW >= 15 and miraQW < 30:'У вас с ней хорошие отношения.'
if miraQW >= 30 and miraQW < 50:'У вас с ней отличные отношения.'
if miraQW >= 50:'У вас с ней превосходные отношения.'
if cumface > 0 and cumfrot = 0:'Мира хихикает видя сперму на вашем лице.'
if cumface = 0 and cumfrot > 0:'Мира хихикает видя пятна спермы на вашей одежде.'
if cumface > 0 and cumfrot > 0:'Мира хихикает видя сперму на вашем лице и одежде.'
if graze_cow = 0:
    if miragopQW = 11:
        act 'Поговорить':
            gt 'Meadow_event','miragopQW11'
        end
    elseif miragopQW >= 15 and mirasex = 0 and  mirainmeadow = 1 and mitkasextimes < 13:
        act 'Поговорить':
            gt 'Meadow_event','lesb_talk_mira1'
        end
    elseif miragopQW >= 15 and mitkasextimes >= 13 and mirasex = 1 and miralick = 0 and  mirainmeadow = 1 and horny >= 40:
        act 'Поговорить':
            gt 'Meadow_event','lesb_talk_mira2'
        end
    else
        if mirasex = 1 and mitkasextimes < 13 and miralick > 0 and mirainmeadow = 1 and horny >= 40:act 'Приказать полизать':gt 'Meadow_event','lesb_talk_mira3'
        if mirasex = 2 and mirainmeadow = 1 and horny >= 40 and miraQW >= 15:act 'Приставать':gt 'Meadow_event','lesb_mira'
	    act 'Поболтать':dynamic $miratalk
        if month >= 4 and month <= 10 and sunWeather >= 0:
            act 'Предложить вместе погулять':
	            *clr & cla
	            if Mira_no = 0:
		            if mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1:
		                if mirainforest = 0:minut += 40
		                if mirainforest = 1:minut += 85
			            if miraQW < 15:miraQW += 1
			            mirainmeadow = 0
                        mirainriver = 0
                        mira_guest = 0
			            inriver = 0
			            mirainforest = 0
			            mirainhome = 0
			            manna += 10
                        if current_clothing < 3:
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
			                clothesforest = 0
			                swamp_clothes = 0
                        end
		                gs 'stat'
			            '<center><img src="images/qwest/gadukino/new/girls_walking'+rand(1,3)+'.jpg"></center>'
			            'Вы предлагаете ей вместе побродить по деревне и она с радостью соглашается, после чего вы вместе гуляете по небольшой деревеньке, рассказывая другу другу разные истории из жизни.'
			            if mitkasextimes > 15 and miragopQW > 15 and gadriver_gang < 3:
			                temp = rand(1,20)
                            if mitkarand = 1 and hour >= 7 and hour <= 16 and mitkaday ! daystart and week <= 5:
                                gt 'gadukino_event', 'mira_mitka'
                            elseif mitkarand = 2 and hour >= 7 and hour <= 16 and kolyambaday ! daystart and week <= 5:
                                gt 'gadukino_event', 'mira_kolyamba'
                            elseif mitkarand = 3 and hour >= 7 and hour <= 16 and vasyanday ! daystart and week <= 5:
                                gt 'gadukino_event', 'mira_vasyan'
                            elseif mitkarand = 4 and hour >= 17 and hour <= 19 and gadboyday ! daystart and week <= 5:
                                gt 'gadukino_event', 'mira_2boys'
                            elseif mitkarand <= 5 and hour >= 7 and hour <= 19 and gadboyday ! daystart and week > 5:
                                gt 'gadukino_event', 'mira_3boys'
			                else
			                    act 'Уйти':mira_guest = 0 & gt 'gadukino'
                            end
                        else
			                act 'Закончить':mira_guest = 0 & gt 'gadukino'
			            end
		            else
			            minut += 5
		                gs 'stat'
			            '<center><img src="images/qwest/gadukino/new/Mira_said_no.jpg"></center>'
			            'Вы предлагаете Мире вместе погулять, но та говорит вам, что не хочет, чтобы люди видели, как вы вместе гуляете, а то подумают, будто и она тоже такая же шлюха...'
			            act 'Уйти':gt $loc, $metka
		            end
	            else
		            minut += 5
		            gs 'stat'
		            '<center><img src="images/qwest/gadukino/new/Mira_shy.jpg"></center>'
		            'Вы предлагаете Мире вместе погулять, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
		            act 'Уйти':gt $loc, $metka
	            end
	        end
        end
        if meadow = 1 and mirainforest = 0:
		    act 'Показать ей ваше тайное место':
			    *clr & cla
			    minut += 30
			    manna += 10
			    miraQW += 2
			    meadow = 2
			    mirainmeadow = 1
			    mirainriver = 0
			    mira_guest = 0
			    mirainhome = 0
			    if current_clothing < 3:
                    gs 'zz_clothing', 'redress', prev_clothing
	                prev_clothing = -1
	                tanga = flag_tanga
	            end
			    gs 'stat'
			    '<center><img src="images/qwest/gadukino/new/girls_go.jpg"></center>'
			    'Вы ведете Миру сквозь густые заросли к скрытой поляне и всю дорогу она не умолкает, весело щебеча и рассказывая истории из своей прошлой городской жизни.'
			    act 'Пришли':gt 'meadow'
		    end
	    end
	    if meadow = 3 and hour >= 8 and hour < 19 and mirainmeadow = 0 and mirainforest = 0 and sunWeather >= 0  and month >= 4 and month <= 10:
		    act 'Предложить сходить на Поляну':
			    *clr & cla
			    if Mira_no = 0:
				    if mitkasextimes < 13 or miragopQW >= 5 or mirasex > 1:
			            if miraQW < 50:miraQW += 1
			            manna += 10
				        mirainmeadow = 1
				        mirainriver = 0
				        mira_guest = 0
				        inriver = 0
				        mirainforest = 0
				        mirainhome = 0
				        if current_clothing < 3:
                            gs 'zz_clothing', 'redress', prev_clothing
	                        prev_clothing = -1
	                        tanga = flag_tanga
	                    end
				        gs 'stat'
					    '<center><img src="images/qwest/gadukino/new/girls_go.jpg"></center>'
					    'Вы предлагаете Мирославе прогуляться в ваше тайное место и она охотно соглашается. По дороге вы с удовольствием рассказываете друг другу разные истории.'
					    act 'Далее':gt 'meadow'
				    else
					    minut += 5
					    gs 'stat'
				        '<center><img src="images/qwest/gadukino/new/Mira_said_no.jpg"></center>'
					    'Вы предлагаете Мире прогуляться за деревней, но та говорит, что не хочет с вами тащиться куда ни попадя.'
				        act 'Уйти':gt $loc, $metka
				    end
			    else
				    minut += 5
				    gs 'stat'
				    '<center><img src="images/qwest/gadukino/new/Mira_shy.jpg"></center>'
				    'Вы предлагаете Мире прогуляться за деревней, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
                    act 'Уйти':gt $loc, $metka
			    end
		    end
	    end
	    if miraQW >= 15 and hour >= 20 and miragopQW = 0 and sunWeather >= 0 and mirainforest = 0:
		    act 'Спросить, знакома ли она уже с деревенскими':
			    *clr & cla
			    minut += 2
			    miraQW += 1
			    miraingop = 1
			    miragopQW = 1
			    mirainmeadow = 0
			    mirainriver = 0
			    mira_guest = 0
			    inriver = 0
			    mirainhome = 0
			    if current_clothing < 3:
                    gs 'zz_clothing', 'redress', prev_clothing
	                prev_clothing = -1
	                tanga = flag_tanga
	            end
			    gs 'stat'
			    dynamic $miraclothes
			    'Вы спрашиваете Мирославу, со всеми ли она уже в деревне познакомилась, а когда она отвечает, что нет, то вы предлагаете познакомить ее с местными парнями и она охотно соглашается, прося вас пару минут подождать, пока она переоденется, после чего быстро скрывается в избенке. Когда она выходит, вы вместе идете к бухающей возле вашего дома компашке...'
			    act 'Далее':mira_guest = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh'
		    end
	    end
	    if miraQW >= 15 and hour >= 20 and miragopQW > 0 and sunWeather >= 0 and mirainforest = 0 and month >= 4 and month <= 10:
		    act 'Предложить побухать с деревенскими':
		        if Mira_no = 0:
			        *clr & cla
			        minut += 5
			        if miraQW < 20:miraQW += 1
			        miraingop = 1
			        mirainmeadow = 0
			        mirainriver = 0
			        if current_clothing < 3:
                        gs 'zz_clothing', 'redress', prev_clothing
	                    prev_clothing = -1
	                    tanga = flag_tanga
	                end
			        gs 'stat'
			        dynamic $miraclothes
			        if miragopQW = 5:
				        'Вы предлагаете Мирославе побухать с деревенскими и она уныло соглашается, шепотом сообщая вам, чтобы вы дождались, когда они с Митькой уйдут, а потом шли к Митькиному дому.'
			        else
				        'Вы предлагаете Мирославе побухать с деревенскими и она охотно соглашается, после чего просит вас подождать пару минут, пока она переоденется. Когда она выходит, вы вместе идете к бухающей возле вашего дома компашке...'
			        end
			        if miragopQW > 15 and mitkasextimes > 15 and gadriver_gang < 3 :
				        act 'Далее':mira_guest = 0 & mirainriver = 0 & mirainmeadow = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh_group'
			        else
				        act 'Далее':mira_guest = 0 & mirainriver = 0 & mirainmeadow = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh'
			        end
			    else
				    minut += 5
				    gs 'stat'
				    '<center><img src="images/qwest/gadukino/new/Mira_shy.jpg"></center>'
				    'Вы предлагаете Мире побухать с деревенскими, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
                    act 'Уйти':gt $loc, $metka
			    end
		    end
	    end
	    if miraQW >= 20 and week = 6 and hour > 18 and hour < 22:
		    act 'Предложить попариться в бане':
                if Mira_no = 0:
 	                if mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1:
 	                    *clr & cla
		                minut += 10
		                manna += 20
		                if miraQW < 50:miraQW += 1
		                mirainmeadow = 0
		                mirainriver = 0
		                mira_guest = 0
		                mirainhome = 0
			            if current_clothing < 3:
                            gs 'zz_clothing', 'redress', prev_clothing
	                        prev_clothing = -1
	                        tanga = flag_tanga
	                    end
		                gs 'stat'
		                dynamic $miraclothes
		               'Вы предлагаете Мирославе вместе попариться у вас в бане. Она долго медлит, но потом все же соглашается и вы идете к вам во двор...'
					    if mirainforest = 0:act 'Далее':minut += 15 & mira = 1 & gt 'Gadbana'
					    if mirainforest = 1:act 'Далее':mirainforest = 0 & mira = 1 & minut += 45 & gt 'Gadbana'
	                else
	                    *clr & cla
		                minut += 5
		                gs 'stat'
		                '<center><img src="images/qwest/gadukino/new/Mira_said_no.jpg"></center>'
		                'Вы предлагаете Мире вместе попариться у вас в бане, но та грубо отвечает вам, что ни за что не пойдет с такой шлюхой, как вы, в одну баню.'
		                act 'Уйти':gt $loc, $metka
                    end
			    else
				    minut += 5
				    gs 'stat'
				    '<center><img src="images/qwest/gadukino/new/Mira_shy.jpg"></center>'
				    'Вы предлагаете Мире попариться у вас в бане, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
                    act 'Уйти':gt $loc, $metka
			    end
	        end
        end
	    if sunWeather >= 0 and temper >= 20 and month >= 5 and month <= 9 and mirainriver = 0:
		    act 'Предложить сходить на речку':
			    *clr & cla
		        if Mira_no = 0:
			        if mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1:
				        minut += 2
					    if miraQW < 30:miraQW += 1
					    mirainriver = 1
					    mirainmeadow = 0
					    mira_guest = 0
					    inriver = 1
					    mirainhome = 0
			            if current_clothing < 3:
                            gs 'zz_clothing', 'redress', prev_clothing
	                        prev_clothing = -1
	                        tanga = flag_tanga
	                        swamp_clothes = 0
	                    end
					    gs 'stat'
					    dynamic $miraclothes
				        'Вы предлагаете ей сходить на речку покупаться или позагорать и она охотно соглашается.'
					    if mirainforest = 0:act 'Идти на речку':minut += 15 & gt  'gadbeach'
					    if mirainforest = 1:act 'Идти на речку':mirainforest = 0 & minut += 45 & gt 'gadbeach'
				    else
					    minut += 5
				        gs 'stat'
				        '<center><img src="images/qwest/gadukino/new/Mira_said_no.jpg"></center>'
					    'Вы предлагаете Мире вместе сходить на речку, но та презрительно хмыкает в ответ и говорит, что никуда не пойдет с такой шалавой, как вы.'
					    act 'Уйти':gt $loc, $metka
				    end
			    else
				    minut += 5
				    gs 'stat'
			        '<center><img src="images/qwest/gadukino/new/Mira_shy.jpg"></center>'
				    'Вы предлагаете Мире вместе сходить на речку, но Мира лишь отрицательно мотает головой, говоря, что после такого унижения она никуда из дома не выйдет.'
                    act 'Уйти':gt $loc, $metka
			    end
		    end
	    end
	    if miratalkforest = 0 and miraQW >= 5:
		    act 'Спросить про лес':
			    *clr & cla
				minut += 15
			    miraQW += 1
			    miratalkforest = 1
			    goforest += 1
			    gs 'stat'
			    dynamic $miraclothes
				' - Мир,а ты была в лесу за деревней? - решили поинтересоваться вы.'
				' - Не, <<$name[1]>>, ты что, я боюсь одна туда ходить, - ответила Мира, замотав головой.'
				' - А почему? - продолжили интересоваться вы у Мирославы.'
                ' - Ой, да говорят там заблудиться легко, если леса не знаешь, - ответила она. - А еще говорят там волки есть.'
                ' - Кто говорит?, - спросили вы недоверчиво. - Прямо настоящие волки?.'
                ' - Да местные говорят, - сказала Мира. - Всякие страшные истории рассказывают.'
                ' - Ой, да небойсь заливают, - со смехом сказали вы. - Ездят по ушам таким как мы, чтобы в лес не ходили. Им то грибов и ягод больше достанется.'
                ' - Не, не, <<$name[1]>>, - серьезным тоном ответила она. - Рассказывали, что прошлым летом волки девочку из соседней деревни насмерть задрали. Она в грибы пошла, но время не расчитала и задержалась до поздна. Утром её искать пошли, так только разодраный сарафанчик в крови нашли, да корзинку.'
                ' - Ужас какой, - поежились вы. - А более интересного ничего не рассказывали?.'
                ' - А как же, - захихикала Мирослава, перейдя на заговорческий шепот. - Подслушала недавно разговор двух теток в деревне. Они говорили, что если по лесу голышом ходить, то здоровье прибавляется и настроение улучшается. Воздух типа так свежий влияет.'
                ' Мирослава задумалась на минуту, а потом продолжила.'
                ' - Уж не знаю про здоровье, но там зудеть точно больше начинает, - Мирослава выразительно глянула между ног.'
                ' - Подожди, - прервали вы её. - Ты же говорила, что боишься в лес ходить одна.'
                ' - Ой, да это все разок и было, - сказала она покраснев. - Проверить, правду ли те тетки сказали.'
                ' - Ладно, ладно, не оправдывайся, - хихикнули вы, глядя на смущенную Миру. - А давай как-нибудь вместе сходим?.'
                ' - Ну не знаю <<$name[1]>>, - ответила она. - Если будет тепло и хорошая погода, то можно как-нибудь и сходить.'
                ' - Но вглубь леса не пойдем, - тут же бысто добавила она.'
                ' - Хорошо, хорошо, по окраине погуляем, - согласились вы.'
                act 'Далее':gt $loc, $metka
		    end
	    end
	    if sunWeather >= 0 and temper >= 20 and month >= 5 and month <= 9 and mirainforest = 0 and miratalkforest > 0 and miraQW >= 5:
		    act 'Предложить сходить в лес':
			    *clr & cla
		        if Mira_no = 0:
			        if mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1:
				        minut += 2
                        if miraQW < 30:miraQW += 1
					    mirainriver = 0
					    mirainmeadow = 0
					    mira_guest = 0
					    inriver = 0
					    mirainforest = 1
					    mirainhome = 0
			            if current_clothing < 3:
                            gs 'zz_clothing', 'redress', prev_clothing
	                        prev_clothing = -1
	                        tanga = flag_tanga
	                    end
					    gs 'stat'
					    dynamic $miraclothes
				        'Вы предлагаете ей сходить в лес за грибами и ягодами и она охотно соглашается.'
					    act 'Идти в лес':mira_guest = 0 & minut += 45 & gt'gadforest','1'
				    else
					    minut += 5
				        gs 'stat'
				        '<center><img src="images/qwest/gadukino/new/Mira_said_no.jpg"></center>'
					    'Вы предлагаете Мире вместе сходить в лес за грибами и ягодами, но та презрительно хмыкает в ответ и говорит, что никуда не пойдет с такой шалавой, как вы.'
					    act 'Уйти':gt $loc, $metka
				    end
			    else
				    minut += 5
				    gs 'stat'
			        '<center><img src="images/qwest/gadukino/new/Mira_shy.jpg"></center>'
				    'Вы предлагаете Мире вместе сходить в лес за грибами и ягодами, но Мира лишь отрицательно мотает головой, говоря, что после такого унижения она никуда из дома не выйдет.'
                    act 'Уйти':gt $loc, $metka
			    end
		    end
	    end
	    if sunWeather >= 0 and temper >= 20 and month >= 5 and month <= 9 and mirainforest = 1 and (miratalkforest = 2 and shameless['flag'] > 0 or miratalkforest = 3) and miraQW >= 5 and current_clothing ! 0 and forestpicnic = 0:
		    act 'Предложить погулять голышом':
			    *clr & cla
	            !одежда остается в лесу
		        clothesforest = 1
		        minut+=5
		        manna += 5
		        flag_tanga = tanga
		        tanga = 0
		        gs 'zz_clothing', 'redress', 0
		        gs 'stat'
		        '<center><img src="images/qwest/gadukino/forest/miraforest6.jpg"></center>'
	            'Вы придложили Мире погулять по лесу голенькими и она сразу же согласилась.'
	            act'Далее':gt'gadforest','1'
	        end
	    end
	    if miragopQW = 30 and hour < 19 and month >= 5 and month <= 9 and mirainforest = 0:
		    act '<b>Загадать третье желание</b>':
			    *clr & cla
			    minut += 2
			    manna += 10
			    mirainriver = 0
		        mirainmeadow = 0
                mira_guest = 0
                inriver = 0
                mirainhome = 0
			    if current_clothing < 3:
                    gs 'zz_clothing', 'redress', prev_clothing
	                prev_clothing = -1
	                tanga = flag_tanga
	            end
			    gs 'stat'
			    dynamic $miraclothes
			   'Вы напоминаете Мире о третьем желании и она неохотно кивает вам головой, подтверждая, что помнит о нем. Вы, загадочно улыбаясь, приказываете ей следовать за вами...'
			    act 'Идти на улицу':
				    *clr & cla
				    minut += 15
				    gs 'stat'
				    '<center><img src="images/qwest/gadukino/street.jpg"></center>'
				    'Вы ведете Миру по деревенской улице. Мира молча смотрит себе под ноги, иногда кидая на вас настороженные взгляды...'
				    act 'Приказать ей раздеться':
					    *clr & cla
					    minut += 2
					    gs 'stat'
					    '<center><img src="images/qwest/gadukino/new/Mira_looks.jpg"></center>'
					    'Выйдя на середину деревни вы увереннным, требовательным голосом приказываете Мирославе раздеться, добавляя, что это и есть ваше последнее желание, после которого вы простите ей ее предательство. У нее медленно отвисает челюсть и она смотрит на вас, как на умалишенную.'
					    ' - Да ладно, что ты как девочка, - презрительно фыркаете вы, - мы ведь обе знаем, что ты та еще шлюха и жить не можешь без членов. А тут такая реклама, и заметь, совсем бесплатно.'
					    'Мира молча смотрит то на вас, то оглядывается на деревенскую улицу, по которой ходят люди.'
					    '- <<$name[2]>>, может не надо? - жалобно с надеждой спрашивает она.'
					    act 'Подтвердить свои слова':
						    *clr & cla
						    minut += 5
						    horny += RAND(5,10)
						    gs 'stat'
						    '<center><img src="images/qwest/gadukino/new/Mira_nude1.jpg"></center>'
						    '- Нет уж Мира, тебя за язык никто не тянул, теперь уж будь добра выполняй обещание, - непреклонным тоном ответили вы.'
						    'Девушка еще минуту нерешительно мнется с ноги на ногу, после чего наконец решается и раздевается до гола.'
                            '- Ну вот, теперь доберешься до конца деревни и считай себя прощенной, - сказали вы с ехидной улыбкой и хлопнув ладонью Миру по заду, для придания скорости, принялись с интересом наблюдать за ней.'
						    act 'Смотреть':
							    *clr & cla
							    minut += 5
							    horny += RAND(5,10)
							    gs 'stat'
							    '<center><img src="images/qwest/gadukino/new/Mira_nude2.jpg"></center>'
							    'Мира нерешительно начинает двигаться по деревенской улице. Вы с интересом смотрит на нее и на реакцию прохожих.'
							    act 'Смотреть дальше':
								    *clr & cla
								    minut += 15
								    horny += RAND(5,10)
								    Mira_no += rand(10,30)
								    miraday = daystart
								    miragopQW = 33
								    miraQW = 1
								    gs 'stat'
								    '<center><img src="images/qwest/gadukino/new/Mira_nude3.jpg"></center>'
								    'Наконец раскрасневшаяся Мира добирается до конца деревни и подбегает к вам.'
								    ' - <<$name[2]>>, мы в расчете?, - спрашивает она вас с надеждой.'
								    'Вы утвердительно кивнув головой отдаете ей одежду и понаблюдав еще пару минут, как Мира под улюлюканье случайных свидетелей бежит к своему дому, разворачиваетесь и идете по своим делам.'
							        act 'Закончить':mira_guest = 0 & gt 'gadukino'
							    end
						    end
					    end
					    act 'Простить':
						    *clr & cla
						    minut += 5
						    miraQW += 5
						    miragopQW = 31
						    gs 'stat'
						   '<center><img src="images/qwest/gadukino/new/Mira_leaves.jpg"></center>'
						   '- Ладно Мира, черт с тобой, добрая я сегодня. Можешь считать себя прощенной, - ответили вы, после небольшой паузы.'
						   'Девушка еще пару мгновений нерешительно мнется с ноги на ногу, не веря ушам, после чего подскакивает к вам и чмокает в щеку.'
                           '- Спасибо <<$name[2]>>, я.. я.., - и не договорив и разревевшись убежала домой.'
                            act 'Закончить':mira_guest = 0 & gt 'gadukino'
                        end
				    end
				end
                act 'Идти к своему сараю':
				    *clr & cla
				    minut += 10
				    gs 'stat'
				    '<center><img src="images/qwest/gadukino/sarai.jpg"></center>'
				    'Вы ведете Миру к своему сараю, где стоит пустующая будка Пирата. Мира непонимающе смотрит на вас, ждя продолжения.'
				    act 'Приказать ей раздеться':
					    *clr & cla
					    minut += 2
					    gs 'stat'
					    '<center><img src="images/qwest/gadukino/new/Mira_looks.jpg"></center>'
					    'Окинув Миру и будку оценивающим взглядом, вы увереннным, требовательным голосом приказываете Мирославе раздеться и лезть в будку, добавляя, что это и есть ваше последнее желание, после которого вы простите ей ее предательство. У нее медленно отвисает челюсть и она смотрит на вас, как на умалишенную.'
					    ' - Да ладно, что ты как девочка, - презрительно фыркаете вы, - мы ведь обе знаем, что ты та еще шлюха и жить не можешь без членов. А тут всего лишь требуется посидеть в будке и поизображать Пирата.'
					    'Мира молча смотрит то на вас, то на будку, от которой еще несет псиной.'
					    '- <<$name[2]>>, может не надо, вдруг увидит кто? - жалобно с надеждой спрашивает она.'
					    act 'Подтвердить свои слова':
						    *clr & cla
						    minut += 5
						    horny += RAND(5,10)
						    gs 'stat'
						   '<center><img src="images/qwest/gadukino/new/Mira_kennel1.jpg"></center>'
						   '- Нет уж Мира, тебя за язык никто не тянул, теперь уж будь добра выполняй обещание, - непреклонным тоном ответили вы.'
						   'Девушка еще минуту нерешительно мнется с ноги на ногу, после чего наконец решается и раздевается до гола.Окинув будку в последний раз она становится на карачки и неловко пытается забраться в тесную будку.'
                           '- Ну вот, теперь посидишь пару-тройку часиков и свободна, - сказали вы с ехидной улыбкой и хлопнув ладонью Миру по заду, для придания скорости, принялись с интересом наблюдать за ней.'
						    act 'Смотреть':
							    *clr & cla
							    minut += 5
							    horny += RAND(5,10)
							    mira_dog += RAND(2,5)
							    miragopQW = 32
							    gs 'stat'
							    '<center><img src="images/qwest/gadukino/new/Mira_kennel2.jpg"></center>'
						        'Понаблюдав за Мирой некоторое время, вы пошли по своим делам.'
							    ' - Отвяжешься сама, если не приду, - бросили вы ей на последок.'
							    '<b>(Пока это конец ивента, продолжение последует в следующих версиях)</b>'
							    act 'Закончить':mira_guest = 0 & gt 'Gadsarai'
                            end
					    end
				        act 'Простить':
						    *clr & cla
						    minut += 5
						    miraQW += 2
						    miragopQW = 31
						    gs 'stat'
						   '<center><img src="images/qwest/gadukino/new/Mira_leaves.jpg"></center>'
						    '- Ладно Мира, черт с тобой, добрая я сегодня. Можешь считать себя прощенной, - ответили вы, после небольшой паузы.'
						    'Девушка еще пару мгновений мнется с ноги на ногу, не веря ушам, после чего подскакивает к вам и чмокает в щеку.'
                            '- Спасибо <<$name[2]>>, я.. я.., - и не договорив и разревевшись убежала домой.'
                            act 'Закончить':mira_guest = 0 & gt 'Gadsarai'
                        end
				    end
			    end
		    end
	    end
	    if miraQW >= 15 and mirainforest = 0 and (mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1):
	        if mira_guest = 0:
	            act 'Пригласить в гости':
				    *clr & cla
				    minut += 5
				    manna += 5
				    mira_guest = 1
				    mirainriver = 0
				    mirainmeadow = 0
				    inriver = 0
				    mirainhome = 0
				    if miraQW < 30:miraQW += 1
			        gs 'stat'
                    dynamic $miraclothes
                    'Вам надоело торчать на улице и вы решили пригласить Миру к себе в гости.'
                    act'Идти домой':
		                if current_clothing > 2:
		                    minut += 15 & gt'Gadhouse'
	                    else
			                cla
			                *clr
			                minut += 5
			                mira_guest = 1
			                mirainriver = 0
			                mirainmeadow = 0
			                inriver = 0
			                tanga = flag_tanga
			                gs 'zz_clothing', 'redress', prev_clothing
			                prev_clothing = -1
			                '<center><img src="images/qwest/gadukino/river/dressbch.jpg"></center>'
			               'Вы переоделись в свою одежду и пошли домой с Мирой.'
			               act 'Далее': minut += 15 & gt'Gadhouse'
	                   end
                   end
                end
	        end
	        if mira_guest = 1:
	            act 'Смотреть телевизор':
				    *clr & cla
				    minut += 60
				    if miraQW < 20:miraQW += 1
				    manna += rand(10,50)
			        gs 'stat'
                    '<center><img src="images/qwest/gadukino/new/Mira_TV'+rand(1,12)+'.jpg"></center>'
                   'Вы с Мирой целый час убили за просмотром телевизора.'
                    act'Далее':gt'Gadhouse'
                end
	        end
	        if mira_guest > 0:
	            act 'Попрощатся':
				    *clr & cla
				    minut += 5
				    mira_guest = 0
			        gs 'stat'
                    dynamic $miraclothes
                    'Вы попращались с Мирой, сославшись на неотложные дела и она ушла домой.'
                    act 'Далее':gt $loc, $metka
                end
	        end
	    end
	act 'Уйти':gt $loc, $metka
	end
end
if meadow = 2:
	*clr & cla
	minut += 2
	miraQW += 1
	gs 'stat'
	dynamic $miraclothes
    ' - А я ведь, хоть и недолго здесь, но об этом месте так и не знала, - весело сообщает вам Мирослава. - Теперь буду знать, где уединиться, когда захочется побыть наедине, ты ведь не возражаешь, правда?'
    act 'Разрешить ей приходить сюда самой':
		*clr & cla
		meadow = 3
	    minut += 2
	    miraQW += 1
	    gs 'stat'
        dynamic $miraclothes
		'Вы отвечаете, что вы не против и она может приходить сюда, когда ей заблагорассудится, но требуете с нее слово, чтобы она никому не рассказывала об этом месте. Мирослава, довольная как слон, активно кивает вам головой и говорит, что заберет этот секрет с собой в могилу, а если нет, то тогда, как джин, исполнит три любых ваших желания...'
		'Она выглядит очень довольной, и спустя какое-то время решает рассказать вам очень страшный-страшный секрет...'
		'Вы заинтригованно соглашаетесь в ожидании, чего же такого сможет поведать вам Мирка, и та вскоре рассказывает вам, что видела, как ее отец мастурбирует... Оказывается, после того, как умерла его жена - Миркина мама - у него не было ни одной женщины, вот он и... В общем, Мирке одновременно и жаль отца, но и помочь она ему ничем не может, хоть и очень сильно любит. Вы ожидали чего-то большего, а потому, услышав такую ерунду, конечно же, сказали, что это не секрет, а глупость какая-то. Мирка обиженно надулась, всем своим видом демонстрируя оскорбленную невинность. А через пару минут, к своему удивлению, вы почувствовали, как неожиданно приятно зудит и влажнеет у вас в промежности от мысли об Мирославином отце...'
		act 'Закончить':gt 'meadow'
	end
end
if graze_cow = 1:
    act 'Болтать с Мирой':
		*clr & cla
        minut += 60
        manna += 10
        if miraQW < 50: miraQW += 1
        gs 'stat'
		gs 'zz_render', '', 'qwest/gadukino/gadfield/graze_cow_mira.jpg','В течение часа вы весело болтали с Мирославой. Ваши отношения улучшились.'
        act 'Отойти': gt $loc, $metka
    end
    if temper >= 20 and sunWeather >= 0:
        if daybegskver ! daystart and ($metka = 'graze_field' or $metka = 'forest_field'): act 'Бегать по полю': gt'gadfield','run'
        if $metka = 'watering_place': act 'Купаться': gt'gadfield','swim'
        act 'Загорать': gt'gadfield','sunbathe'
    end
    act 'Отойти': gt $loc, $metka
end
if mira_temp = 0 and mira_go_blok = 0 and meadow > 2 and $loc ! 'MiroslavaHome' or hour >= 22 and $loc ! 'MiroslavaHome':
	cla
	*clr
    minut += 5
    mira_no_home = 0
    gs 'stat'
    if mirainriver = 1:gs 'zz_render', $_str, 'gadukino/river/events/mira_go_home'+iif(current_clothing = 0,'_nude','')+'.jpg'
	if mirainriver = 0:dynamic $miraclothes
	' - <<$name[2]>>, c тобой весело, но мне пора домой, - сказала вам Мира.'
    act 'Далее':mira = 0 & mira_guest = 0 & mirainriver = 0 & mirainmeadow = 0 & mirainforest = 0 & gt $loc, $metka
end
if miraQW >= 15 and Mira_no = 0 and (mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1):
	if mira_guest = 0 and mira_temp >= 1 and mira_temp <= 2 and mira_go_blok = 0 and mirainforest = 0:
	    cla
	    *clr
		minut += 1
		gs 'stat'
        if mirainriver = 1:dynamic $mira_river
	    if mirainriver = 0:dynamic $miraclothes
        ' - <<$name[2]>>, что-то скучно тут, а давай к тебе домой пойдем, - предложила вам Мира.'
        act'Согласиться':
		    if current_clothing > 2:
		        mira_go_blok = 1 & mirainmeadow = 0 & mirainhome = 0 & inriver = 0 & mirainriver = 0 & mira_guest = 1 & mira_go_blok = 1 & minut += 15 & miraQW += 1 & gt'Gadhouse'
	        else
			    cla
			    *clr
			    miraQW += 1
			    mira_go_blok = 1
			    mira_guest = 1
			    mirainriver = 0
			    mirainmeadow = 0
			    mirainhome = 0
			    inriver = 0
			    if miraQW < 30:miraQW += 1
			    minut += 20
			    tanga = flag_tanga
			    gs 'zz_clothing', 'redress', prev_clothing
			    prev_clothing = -1
			    '<center><img src="images/qwest/gadukino/river/dressbch.jpg"></center>'
			    'Вы переоделись в свою одежду и отправились с Мирой к вам домой.'
			    act 'Далее': gt'Gadhouse'
	        end
        end
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
			gs 'stat'
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            'Вы отказали Мире, сославшись на то, что там вам будет скучно.'
            act 'Далее': gt $loc, $metka
        end
	end
	if mira_guest = 1 and mira_temp >= 3 and mira_temp <= 4:
	    cla
	    *clr
	    minut += 1
		gs 'stat'
        dynamic $miraclothes
        ' - <<$name[2]>>, давай телик посмотрим, а то что-то скучно, - предложила вам Мира.'
        act'Согласиться':
            cla
			*clr
		    minut += 60
		    if miraQW < 20:miraQW += 1
		    manna += rand(10,50)
		    mira_go_blok = 1
			gs 'stat'
            '<center><img src="images/qwest/gadukino/new/Mira_TV'+rand(1,12)+'.jpg"></center>'
            'Вы с Мирой целый час убили за просмотром телевизора.'
            act'Далее':gt'Gadhouse'
        end
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            'Вы отказали Мире, сославшись на то, что вам это не интересно.'
            act 'Далее': gt $loc, $metka
        end
    end
	if mirainmeadow = 0 and mira_temp = 5 and meadow = 3 and mira_go_blok = 0 and mirainforest = 0 and hour < 19 and sunWeather >= 0 and month >= 4 and month <= 10:
	    cla
	    *clr
        minut += 1
		gs 'stat'
	    dynamic $miraclothes
        ' - <<$name[2]>>, может сходим на нашу поляну? - спросила у вас Мира. - Прогуляемся, воздухом подышим.'
        act'Согласиться':
            cla
			*clr
			minut += 15
			manna += 5
			if miraQW < 50:miraQW += 1
		    mira_guest = 0
		    mirainriver = 0
		    mirainmeadow = 1
            inriver = 0
            mira_go_blok = 1
            mirainhome = 0
			if current_clothing < 3:
                gs 'zz_clothing', 'redress', prev_clothing
	            prev_clothing = -1
	            tanga = flag_tanga
	        end
			gs 'stat'
			'<center><img src="images/qwest/gadukino/new/girls_go.jpg"></center>'
			'Вы идете с Мирой сквозь густые заросли к скрытой поляне и всю дорогу она не умолкает, весело щебеча и рассказывая истории из своей прошлой городской жизни.'
			act 'Далее': gt 'Meadow'
		end
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
			gs 'stat'
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            'Вы отказали Мире, сославшись на то, что там вам будет скучно.'
            act 'Далее': gt $loc, $metka
        end
	end
	if mirainriver = 0 and mira_temp >= 6 and mira_temp <= 7 and sunWeather >= 0 and temper >= 20 and mira_go_blok = 0 and mirainforest = 0 and hour < 18:
	    cla
	    *clr
        minut += 1
		gs 'stat'
	    dynamic $miraclothes
        ' - <<$name[2]>>, может сходим на речку? - спросила у вас Мира. - Искупаемся, позагораем.'
        act'Согласиться':
            cla
			*clr
			minut += 15
			if miraQW < 30:miraQW += 1
		    mira_guest = 0
		    mirainriver = 1
		    mirainmeadow = 0
		    inriver = 1
		    mira_go_blok = 1
		    mirainhome = 0
			if current_clothing < 3:
                gs 'zz_clothing', 'redress', prev_clothing
	            prev_clothing = -1
	            tanga = flag_tanga
	        end
			gs 'stat'
			'<center><img src="images/qwest/gadukino/new/girls_go.jpg"></center>'
			'Вы решили сходить с Мирой на деревенский пляж и всю дорогу она не умолкает, весело щебеча и рассказывая  разные истории.'
			act 'Далее': gt 'gadbeach'
		end
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
			gs 'stat'
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            'Вы отказали Мире, сославшись на то, что там вам будет скучно.'
            act 'Далее': gt $loc, $metka
        end
	end
	if hour >= 20 and mira_temp > 10 and sunWeather >= 0 and mira_go_blok = 0 and miragopQW > 0 and mirainforest = 0 and month >= 4 and month <= 10:
	    cla
	    *clr
        minut += 1
        mira_go_blok = 1
        miraingop = 1
        mirainhome = 0
		mira_guest = 0
		mirainriver = 0
		mirainmeadow = 1
        inriver = 0
	    if current_clothing < 3:
            gs 'zz_clothing', 'redress', prev_clothing
	        prev_clothing = -1
	        tanga = flag_tanga
	    end
		gs 'stat'
	    dynamic $miraclothes
        ' - <<$name[2]>>, может сходим с местными побухаем? - спросила у вас Мира. - Скучно, развеяться хочется.'
	    if miragopQW > 15 and mitkasextimes > 15:
		    act 'Согласиться':mira_guest = 0 & inriver = 0 & mirainriver = 0 & mirainmeadow = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh_group'
		else
		    act 'Согласиться':mira_guest = 0 & inriver = 0 & mirainriver = 0 & mirainmeadow = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh'
	    end
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
			gs 'stat'
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            'Вы отказали Мире, сославшись на то, что там вам будет скучно.'
            act 'Далее': gt $loc, $metka
        end
	end
	if mira_temp > 8 and mira_temp < 9:
	    cla
	    *clr
        minut += 1
        mira_go_blok = 1
		gs 'stat'
	    dynamic $miraclothes
        'Мира хочет с вами поболтать.'
        ' - <<$name[2]>>, ты не против? - спросила у вас Мира.'
	    act'Согласиться':act 'Поболтать':dynamic $miratalk
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
			gs 'stat'
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            ' - Не, Мир, давай не сейчас, - сказали вы. - Нет настроения сейчас разговаривать.'
            act 'Далее': gt $loc, $metka
        end
	end
	if mirainriver = 1 and mira_temp >= 8 and mira_temp <= 9 and sunWeather >= 0 and temper >= 20:
	    cla
	    *clr
        minut += 1
		gs 'stat'
	    dynamic $miraclothes
        ' - <<$name[2]>>, Чего ты на берегу киснешь, айда купаться? - крикнула вам Мира и кинулась в речку.'
        act'Согласиться':
            if current_clothing < 3:
			    cla
			    *clr
			    minut += 60
				gs 'zz_bathroom', 'clean_me'
			    manna += 10
			    if stren < 20:stren += 1
			    gs'stat'
			    if current_clothing = 2:
					'<center><img src="images/qwest/gadukino/river/RiverTwoGirls.jpg"></center>'
					'Вы искупнулись в речушке, весело брызгаясь с Мирой друг на дружку водой.'
			    else
					'<center><img src="images/qwest/gadukino/river/RiverTwoGirlsNude.jpg"></center>'
					'Вы искупнулись в речушке, весело брызгаясь с Мирой друг на дружку водой.'
                end
			    act 'Выйти из воды':gt 'gadbeach'
			else
			    cla
			    *clr
			    minut += 5
			    flag_tanga = tanga
			    tanga = 0
			    inriver = 1
                gs 'zz_clothing', 'redress', 2
			    '<center><img src="images/qwest/gadukino/river/undressbch.jpg"></center>'
			    ' - Сейчас Мирка, только купальник надену, - крикнули вы ей в ответ, хотя врятли она вас услышала, плескаясь уже во всю в речке.'
			    'Вы сняли свою одежду, надели купальник и кунулись в воду вслед за Мирой.'
			    act'Купаться':
			        cla
			        *clr
			        minut += 60
					gs 'zz_bathroom', 'clean_me'
			        manna += 10
			        if stren < 20:stren += 1
			        gs'stat'
					'<center><img src="images/qwest/gadukino/river/RiverTwoGirls.jpg"></center>'
					'Вы искупнулись в речушке, весело брызгаясь с Мирой друг на дружку водой.'
			        act 'Выйти из воды':gt 'gadbeach'
		        end
		    end
    	end
        act'Отказаться':
            cla
			*clr
			minut += 1
			miraQW -= 1
			gs 'stat'
            '<center><img src="images/qwest/alter/Ev/otel4.jpg"></center>'
            ' - Не, Мир, не охота, - ответили вы ей. - Я на берегу лучше побуду'
            act 'Далее': gt 'gadbeach'
        end
	end
end
$miraclothes = {
    '<center><B>Мирослава</B></center>'
    if miragopQW = 0:
	    '<center><img src="images/qwest/gadukino/Mira.jpg"></center>'
    elseif miragopQW > 0 and miragopQW < 4:
	    '<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
    elseif miragopQW >= 4 and miragopQW < 8:
	    '<center><img src="images/qwest/gadukino/mira0,'+rand(0,5)+'.jpg"></center>'
    elseif miragopQW >= 8 and miragopQW < 12:
	    '<center><img src="images/qwest/gadukino/mira1,'+rand(0,2)+'.jpg"></center>'
    elseif miragopQW >= 12 and miragopQW < 20:
	    '<center><img src="images/qwest/gadukino/mira2,'+rand(0,5)+'.jpg"></center>'
    elseif miragopQW >= 20:
	    '<center><img src="images/qwest/gadukino/mira3,'+rand(0,3)+'.jpg"></center>'
    end
}
$mira_river = {
	if current_clothing > 2:'<center><img src="images/qwest/gadukino/river/MiraRiverTalk.jpg"></center>'
	if current_clothing = 2:'<center><img src="images/qwest/gadukino/river/MiraRiverTalkBikini.jpg"></center>'
	if current_clothing = 0:'<center><img src="images/qwest/gadukino/river/MiraRiverNudeTalk.jpg"></center>'
}
$miratalk = {
	if miragopQW = 0:
		*clr & cla
		minut += 10
		manna += 5
		if miraQW < 10:miraQW += 1
		gs 'stat'
		if mirainriver = 0:dynamic $miraclothes
        if mirainriver = 1:dynamic $mira_river
		if mitkasextimes < 13 or mirasex > 1:
			'Вы десять минут весело болтаете о всяких пустяках.'
		else
			'Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
		end
		act 'Закончить':gt $loc, $metka
	elseif miragopQW = 1:
		*clr & cla
		minut += 10
		manna += 5
		if miraQW < 20:miraQW += 1
		gs 'stat'
		if mirainriver = 0:dynamic $miraclothes
        if mirainriver = 1:dynamic $mira_river
		if mitkasextimes < 13 or mirasex > 1:
			'Вы десять минут весело болтаете о всяких пустяках, иногда вспоминая, как вы напились с деревенскими парнягами...'
		else
			'Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
		end
		if mirasextimes > 3:
			act 'Спросить про нее и Митьку':
				*clr & cla
				minut += 2
				horny += 10
				miraQW += 1
				miragopQW = 2
				manna += 10
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
				'Вы спрашиваете Миру, есть ли что-то между ней и Митькой и она, немного помявшись, отвечает, что да, есть. На все дальнейшие расспросы она или отмалчивается или увиливает, поэтому вы решаете оставить это до более подходящих времен...'
				act 'Закончить':gt $loc, $metka
			end
		end
		act 'Закончить':gt 'Miroslava'
	elseif miragopQW = 2 or miragopQW = 3:
		*clr & cla
		minut += 10
		manna += 5
		if miraQW < 20:miraQW += 1
		gs 'stat'
		if mirainriver = 0:dynamic $miraclothes
        if mirainriver = 1:dynamic $mira_river
        if mitkasextimes < 13 or mirasex > 1:
		    'Вы десять минут весело болтаете о всяких пустяках, а Мира иногда заливается румянцем, что-то вспоминая...'
		    if miragopQW = 3 and mitkasextimes < 13:
			    act 'Сказать, что видели, как она трахалась с Митькой на поляне':
				    *clr & cla
				    minut += 2
				    horny += 10
				    miraQW -= 1
				    manna += 10
				    gs 'stat'
				    '<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
				    'Вы холодно говорите Мирославе, что видели, как она раздвигала ноги перед Митькой на вашей поляне и цитируете ее слова о том, как она клялась никому не рассказывать о вашем тайном месте. Мира краснеет и потупливает взор, бормоча, что ей очень жаль, что так получилось, а потом спрашивает, есть ли что-то, что она может сделать для вас, чтобы загладить свою вину. Вы ей тут же напоминаете про три желания, которые она обещала сделать, если кому-то расскажет, и она подобострастно кивает вам головой, что, мол, да, она помнит и готова искупить вину.'
				    !if dom >= 25:
				    !act 'Пусть снимет трусики, покажет вам промежность и расскажет, каково ей трахаться с Митькой на вашей поляне':
					    !*clr & cla
					    !minut += 5
					    !gs 'stat'
					    !'<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
					    !'Вы говорите, что хотите посмотреть, чем же так ценен ее передок, что она променяла его на дружбу с вами. Мира опешивает от таких слов и тупо смотрит на вас, но вы не даете ей опомниться и продолжаете напирать дальше, напоминая, что уговор есть уговор, и если она и это свое слово не сдержит, то на этом ваша дружба и закончится. Мирослава густо краснеет и нерешительно переминается с ноги на ноги и вы, решив идти ва-банк, разворачиваетесь и начинаете уходить...'
					    !' - Постой, - негромко кричит вам в спину Мирослава, но вы делаете вид, что не замечаете и идете дальше. Через пару секунд она вас догоняет и с пунцовым лицом хватает вас за руку и тащит куда-то покосившийся сарай.'
					        !act 'Идти за ней':
						    !*clr & cla
						    !minut += 10
						    !horny += 15
						    !gs 'stat'
						    !'<center><img src="images/qwest/gadukino/Mirawish1.jpg"></center>'
						    !'Вы, мысленно ликуя, позволяете ей тащить себя за руку, а когда она останавливается и поворачивается к вам, то делаете как можно более холодное лицо. Мирослава еще пару долгих секунд нерешительно топчется на месте, а потом, тяжело вздохнув, начинает снимать с себя трусики. '
						    !act 'Смотреть':
							    !*clr & cla
							    !minut += 15
							    !horny += 50
							    !miragopQW = 4
							    !gs 'stat'
							    !'<center><img src="images/qwest/gadukino/Mirawish1_1.jpg"></center>'
							    !'Сняв с себя трусы, Мирослава поворачивается к вам задницей и задрав юбку, низко нагибается. Вы, уже не сдерживаясь, широко улыбаетесь и как можно более безразличным голосом приказываете ей раздвинуть руками ягодицы. Мира нехотя исполняет ваше требование, после чего вы требуете поведать вам, каково ей было трахаться с Митькой на вашей поляне. Девушка пытается разогнуться, но вы, рыкнув на нее, говорите, чтобы рассказывала в этой унизительной и это будет наказание ей за то, что разболтала ваш секрет. Следующие пять минут, раздвигая перед вами ягодицы, Мирослава в подробностях рассказывает вам, что она чувствовала, когда ее трахал Митька...'
							    !act 'Развернуться и уйти':gt $loc, $metka
						    !end
					    !end
				    !end
				    act 'Сказать, что вы хотите посмотреть, как Митька будет драть ее в задницу':
					    *clr & cla
					    minut += 5
					    horny += 10
					    manna += 10
					    miragopQW = 5
					    miraQW -= 1
					    gs 'stat'
					    '<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
					    'Вы говорите, что хотите посмотреть, как Митька отдерет ее в задницу за то, что она разболтала ваш секрет. Мира опешивает от таких слов и тупо смотрит на вас, но вы не даете ей опомниться и продолжаете напирать дальше, напоминая, что уговор есть уговор, и если она и это свое слово не сдержит, то на этом ваша дружба и закончится. Мирослава густо краснеет и нерешительно переминается с ноги на ноги и вы, решив идти ва-банк, разворачиваетесь и начинаете уходить...'
					    ' - Постой, - негромко кричит вам в спину Мирослава, но вы делаете вид, что не замечаете и идете дальше.'
					    ' - Хорошо, <<$name[1]>>, - спустя долгих пару секунд доносится до вас истеричный крик Мирославы, - я что-нибудь придумаю!'
					    act 'Уйти':gt $loc, $metka
				    end
			    end
		    end
		else
			'Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
		end
		act 'Закончить':gt 'Miroslava'
	end
	if miragopQW >= 4 and miragopQW < 7:
		*clr & cla
		minut += 10
		horny += 10
		manna += 5
		gs 'stat'
		if mirainriver = 0:dynamic $miraclothes
        if mirainriver = 1:dynamic $mira_river
        if mitkasextimes < 13 or mirasex > 1:
		    'Вы десять минут болтаете о разных пустяках, при этом Мира иногда, краснея, рассказывает вам некоторые интимные подробности ее отношений с Митькой.'
		else
			'Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
		end
		if miragopQW = 6:
			act 'Сказать, что первое желание выполнено':
				*clr & cla
				minut += 10
				horny += 15
				miragopQW = 7
				manna += 10
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Mira3.jpg"></center>'
				'Вы говорите Мирославе, что видели, как Митька драл ее в задницу и ехидно спрашиваете, понравилось ли ей. К вашему удивлению, она, краснея и смущаясь, говорит, что немного... Вы разочарованно хмыкнув, напоминаете ей, что осталось еще два желания, по исполнении которых вы сможете забыть о ее предательстве. Мира подобострастно кивает вам головой и говорит, что готова искупить свою вину. Вы отвечаете, что пока подумаете над вторым желанием, и развернувшись, уходите...'
				act 'Уйти':gt $loc, $metka
			end
		end
		act 'Закончить':gt $loc, $metka
	end
	if miragopQW >= 7 and miragopQW < 12:
		*clr & cla
		minut += 10
		horny += 10
		manna += 5
		if miraQW < 10:miraQW += 1
		gs 'stat'
		if mirainriver = 0:dynamic $miraclothes
        if mirainriver = 1:dynamic $mira_river
        if mitkasextimes < 13:
		    'Вы десять минут вяло болтаете о разных пустяках, при этом Мира старается не встречаться с вами взглядом.'
		else
			'Вы десять минут болтаете о разных пустяках, при этом Мира иногда, краснея, рассказывает вам некоторые интимные подробности ее отношений с Митькой.'
		end
		act 'Закончить':gt $loc, $metka
	end
	if miragopQW >= 12:
		*clr & cla
		minut += 10
		manna += 5
		if mitkasextimes = 0 and miraQW < 10:miraQW += 1
		if mitkasextimes > 0 and mitkasextimes < 13 and miraQW < 15:miraQW += 1
		if mitkasextimes >= 13 and miraQW < 30:miraQW += 1
		if Mira_no > 0 and miraday ! daystart:miraday = daystart & Mira_no -= 1
		gs 'stat'
		if mirainriver = 0:dynamic $miraclothes
        if mirainriver = 1:dynamic $mira_river
		if miragopQW < 20 and mitkasextimes < 13:
			'Вы десять минут вяло болтаете о разных пустяках, при этом вы часто зовете ее не по имени, а называете просто шлюхой, на что она делает вид, будто ничего не замечает.'
		elseif miragopQW >= 20 and miragopQW < 30 and mitkasextimes < 13:
			'Вы десять минут вяло болтаете о разных пустяках, при этом Мира вообще не смотрит вам в глаза и со всем с вами соглашается, думая о чем-то своем.'
		elseif miragopQW >= 30 and mitkasextimes < 13:
			'Вы десять минут вяло болтаете о разных пустяках, но Мира вообще вас не слушает, все ее разговоры сводятся к сексу.'
		else
			'Вы десять минут весело болтаете о всяких пустяках.'
		end
		act 'Закончить':gt $loc, $metka
	end
}