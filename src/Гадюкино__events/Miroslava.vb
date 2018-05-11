$boy = 'Мирослава'
boyage = age
temp = RAND(0,20)
mira_temp = rand(0,20)
gs 'stat'
if mirainriver = 1:
	if cloth[0] > 0:
		gs 'zz_render','','qwest/gadukino/river/MiraBeach.jpg','Мира лежит на пляже, млея на солнце.'
	else
		gs 'zz_render','','qwest/gadukino/river/MiraBeachNude.jpg','Голенькая Мира лежит на пляже, млея на солнце.'
	end
else
	if miragopQW = 0:
		gs 'zz_render','','qwest/gadukino/Mira.jpg'
	elseif miragopQW > 0 and miragopQW < 4:
		gs 'zz_render','','qwest/gadukino/Mira3.jpg'
	elseif miragopQW >= 4 and miragopQW < 8:
		gs 'zz_render','','qwest/gadukino/mira0,'+rand(0,5)
	elseif miragopQW >= 8 and miragopQW < 12:
		gs 'zz_render','','qwest/gadukino/mira1,'+rand(0,2)
	elseif miragopQW >= 12 and miragopQW < 20:
		gs 'zz_render','','qwest/gadukino/mira2,'+rand(0,5)
	elseif miragopQW >= 20:
		gs 'zz_render','','qwest/gadukino/mira3,'+rand(0,3)
	end
end
if mirainmeadow = 1:'- Чудесное место, здесь так уютно и солнечно! - восклицает Мира, с восторгом кружась по поляне.'
if mirainriver = 1:'Она общительная девушка. Мирослава с отцом совсем недавно вынуждена была перехать сюда. Из-за огромных долгов отца им пришлось продать всё имущество, в том числе и квартиру в центре города, а на те деньги, что у них остались, они смогли позволить себе купить дом только в такой вот захудалой деревне.'
if mirainriver = 0 and mirainmeadow = 0:'Мирослава общительная девушка. Ей <<boyage>> лет. Она с отцом совсем недавно вынуждена была перехать в сюда. Из-за огромных долгов отца им пришлось продать все имущество, в том числе и квартиру в центре города, а на те деньги, что у них остались, они смогли позволить себе купить дом только в такой вот захудалой деревне.'
if miraQW < 5:'У вас с ней прохладные отношения.'
if miraQW >= 5 and miraQW < 15:'У вас с ней нормальные отношения.'
if miraQW >= 15 and miraQW < 30:'У вас с ней хорошие отношения.'
if miraQW >= 30 and miraQW < 50:'У вас с ней отличные отношения.'
if miraQW >= 50:'У вас с ней превосходные отношения.'
if cumface > 0 and cumfrot = 0:'Мира хихикает, видя сперму на вашем лице.'
if cumface = 0 and cumfrot > 0:'Мира хихикает, видя пятна спермы на вашей одежде.'
if cumface > 0 and cumfrot > 0:'Мира хихикает, видя сперму на вашем лице и одежде.'
if graze_cow = 0:
	if miragopQW = 11:
		act 'Поговорить':
			gt 'Meadow_event','miragopQW11'
		end
	elseif miragopQW >= 15 and mirasex = 0 and mirainmeadow = 1 and mitkasextimes < 13:
		act 'Поговорить':
			gt 'Meadow_event','lesb_talk_mira1'
		end
	elseif miragopQW >= 15 and mitkasextimes >= 13 and mirasex = 1 and miralick = 0 and mirainmeadow = 1 and horny >= 40:
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
						if cloth[0] < 3:
							gs 'zz_clothing2','redress',cloth[3]
							clothesforest = 0
							swamp_clothes = 0
						end
						gs 'stat'
						gs 'zz_render','','qwest/gadukino/new/girls_walking'+rand(1,3),'Вы предлагаете ей вместе побродить по деревне и она с радостью соглашается. Вы вместе гуляете по небольшой деревеньке, рассказывая другу другу разные истории из жизни.'
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
						gs 'zz_render','','qwest/gadukino/new/Mira_said_no.jpg','Вы предлагаете Мире вместе погулять, но та отвечает, что не хочет, чтобы люди видели, как вы вместе гуляете, а то подумают, будто и она тоже такая же шлюха...'
						act 'Уйти':gt $loc, $metka
					end
				else
					minut += 5
					gs 'stat'
					gs 'zz_render','','qwest/gadukino/new/Mira_shy.jpg','Вы предлагаете Мире вместе погулять, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
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
				if cloth[0] < 3:
					gs 'zz_clothing2','redress',cloth[3]
				end
				gs 'stat'
				gs 'zz_render','','qwest/gadukino/new/girls_go.jpg','Вы ведёте Миру сквозь густые заросли к скрытой поляне и всю дорогу она не умолкает, весело щебеча и рассказывая истории из своей прошлой городской жизни.'
				act 'Пришли':gt 'meadow'
			end
		end
		if meadow = 3 and hour >= 8 and hour < 19 and mirainmeadow = 0 and mirainforest = 0 and sunWeather >= 0 and month >= 4 and month <= 10:
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
						if cloth[0] < 3:
							gs 'zz_clothing2','redress',cloth[3]
						end
						gs 'stat'
						gs 'zz_render','','qwest/gadukino/new/girls_go.jpg','Вы предлагаете Мирославе прогуляться в ваше тайное место и она охотно соглашается. По дороге вы с удовольствием рассказываете друг другу разные истории.'
						act 'Далее':gt 'meadow'
					else
						minut += 5
						gs 'stat'
						gs 'zz_render','','qwest/gadukino/new/Mira_said_no.jpg','Вы предлагаете Мире прогуляться за деревней, но та говорит, что не хочет с вами тащиться куда ни попадя.'
						act 'Уйти':gt $loc, $metka
					end
				else
					minut += 5
					gs 'stat'
					gs 'zz_render','','qwest/gadukino/new/Mira_shy.jpg','Вы предлагаете Мире прогуляться за деревней, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
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
				if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
				gs 'stat'
				dynamic $miraclothes
				gs 'zz_render','','','Вы спрашиваете Мирославу - со всеми ли она уже в деревне познакомилась, а когда она отвечает, что нет - предлагаете познакомить её с местными парнями и она охотно соглашается, и попросив вас пару минут подождать, пока она переоденется, быстро скрывается в избёнке. Когда она выходит, вы вместе идете к бухающей возле вашего дома компашке...'
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
					if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
					gs 'stat'
					dynamic $miraclothes
					if miragopQW = 5:
						gs 'zz_render','','','Вы предлагаете Мирославе побухать с деревенскими и она уныло соглашается, шепотом сообщая вам, чтобы вы дождались, когда они с Митькой уйдут, а потом шли к Митькиному дому.'
					else
						gs 'zz_render','','','Вы предлагаете Мирославе побухать с деревенскими и она охотно соглашается, после чего просит вас подождать пару минут, пока она переоденется. Когда она выходит - вы вместе направляетесь к бухающей возле вашего дома компашке.'
					end
					mira_guest = 0
					mirainriver = 0
					mirainmeadow = 0
					minut += 15
					temp = 0
					miralko = 0
					act 'Далее':
						if miragopQW > 15 and mitkasextimes > 15 and gadriver_gang < 3:
							gt 'mitkabuh_group'
						else
							gt 'mitkabuh'
						end
					end
				else
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/new/Mira_shy.jpg','Вы предлагаете Мире побухать с деревенскими, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
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
						if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
						gs 'stat'
						dynamic $miraclothes
						gs 'zz_render','','','Вы предлагаете Мирославе вместе попариться у вас в бане. Она долго медлит, но потом всё-же соглашается и вы идёте к вам во двор...'
						if mirainforest = 0:act 'Далее':minut += 15 & mira = 1 & gt 'Gadbana'
						if mirainforest = 1:act 'Далее':mirainforest = 0 & mira = 1 & minut += 45 & gt 'Gadbana'
					else
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/new/Mira_said_no.jpg','Вы предлагаете Мире вместе попариться у вас в бане, но та грубо отвечает, что ни за что не пойдёт с такой шлюхой, как вы, в одну баню.'
						act 'Уйти':gt $loc, $metka
					end
				else
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/new/Mira_shy.jpg','Вы предлагаете Мире попариться у вас в бане, но Мира лишь отрицательно мотает головой, говоря, что после такого позора она никуда из дома не выйдет.'
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
						if cloth[0] < 3:
							gs 'zz_clothing2','redress',cloth[3]
							swamp_clothes = 0
						end
						gs 'stat'
						dynamic $miraclothes
						gs 'zz_render','','','Вы предлагаете ей сходить на речку покупаться-позагорать и она охотно соглашается.'
						if mirainforest = 0:act 'Идти на речку':minut += 15 & gt 'gadbeach'
						if mirainforest = 1:act 'Идти на речку':mirainforest = 0 & minut += 45 & gt 'gadbeach'
					else
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/new/Mira_said_no.jpg','Вы предлагаете Мире вместе сходить на речку, но та презрительно хмыкает в ответ, что никуда не пойдёт с такой шалавой, как вы.'
						act 'Уйти':gt $loc, $metka
					end
				else
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/new/Mira_shy.jpg','Вы предлагаете Мире вместе сходить на речку, но Мира лишь отрицательно мотает головой, говоря, что после такого унижения она никуда из дома не выйдет.'
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
				gs 'zz_render','','',' - Мир,а ты была в лесу за деревней? - решили поинтересоваться вы.'
				gs 'zz_render','','',' - Не, ты что, я боюсь одна туда ходить! - мотает Мира головой.'
				gs 'zz_render','','',' - А почему? - продолжили интересоваться вы у Мирославы.'
				gs 'zz_render','','',' - Ой, да говорят там заблудиться легко, если леса не знаешь. А ещё говорят - там волки есть.'
				gs 'zz_render','','',' - Кто говорит? - спросили вы недоверчиво. - Прямо настоящие волки?'
				gs 'zz_render','','',' - Да местные говорят. Всякие страшные истории рассказывают.'
				gs 'zz_render','','',' - Ой, да небось заливают, - хмыкаете вы. - Ездят по ушам таким как мы, чтобы в лес не ходили. Им грибов и ягод больше достанется!'
				gs 'zz_render','','',' - Не, не, Свет! - серьёзно ответила она. - Рассказывали, что прошлым летом волки девочку из соседней деревни насмерть задрали. Она по грибы пошла, но время не расчитала и задержалась дотемна. Утром её искать пошли - так только разодраный сарафанчик в крови нашли, да корзинку.'
				gs 'zz_render','','',' - Ужас какой! - поёжились вы. - А более интересного ничего не рассказывали?.'
				gs 'zz_render','','',' - А как же, - захихикала Мирослава, перейдя на заговорщицкий шепот. - Подслушала недавно разговор двух тёток в деревне. Они говорили, что если по лесу голышом ходить, то здоровье прибавляется и настроение улучшается. Воздух типа так свежий влияет.'
				gs 'zz_render','','',' Мирослава задумалась на минуту, а потом продолжила.'
				gs 'zz_render','','',' - Уж не знаю про здоровье, но там зудеть точно больше начинает, - Мирослава выразительно зыркает себе между ног.'
				gs 'zz_render','','',' - Подожди, - прервали вы её. - Ты же говорила, что боишься в лес ходить одна?!'
				gs 'zz_render','','',' - Ой, да это всего разок и было, - краснеет Мира. - Проверить, правду ли те тётки сказали?'
				gs 'zz_render','','',' - Ладно, ладно, не оправдывайся, - хихикнули вы, глядя на смущенную Миру. - А давай как-нибудь вместе сходим?.'
				gs 'zz_render','','',' - Ну не знаю Свет, - замялась она. - Если будет тепло и хорошая погода, то можно как-нибудь и сходить.'
				gs 'zz_render','','',' - Но вглубь леса не пойдём, только на опушку! - тут же быстро добавила она.'
				gs 'zz_render','','',' - Хорошо, хорошо, по окраине погуляем, - согласились вы.'
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
						if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
						gs 'stat'
						dynamic $miraclothes
						gs 'zz_render','','','Вы предлагаете ей сходить в лес за грибами и ягодами и она охотно соглашается.'
						act 'Идти в лес':mira_guest = 0 & minut += 45 & gt'gadforest','1'
					else
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/new/Mira_said_no.jpg'
						gs 'zz_render','','','Вы предлагаете Мире вместе сходить в лес за грибами и ягодами, но та презрительно хмыкает в ответ и говорит, что никуда не пойдет с такой шалавой.'
						act 'Уйти':gt $loc, $metka
					end
				else
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/new/Mira_shy.jpg'
					gs 'zz_render','','','Вы предлагаете Мире вместе сходить в лес за грибами и ягодами, но Мира лишь отрицательно мотает головой, говоря, что после такого унижения она никуда из дома не выйдет.'
					act 'Уйти':gt $loc, $metka
				end
			end
		end
		if sunWeather >= 0 and temper >= 20 and month >= 5 and month <= 9 and mirainforest = 1 and (miratalkforest = 2 and shameless['flag'] > 0 or miratalkforest = 3) and miraQW >= 5 and cloth[0] ! 0 and forestpicnic = 0:
			act 'Предложить погулять голышом':
				*clr & cla
				!одежда остается в лесу
				clothesforest = 1
				minut+=5
				manna += 5
				gs 'zz_clothing2','redress',0
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/forest/miraforest6.jpg'
				gs 'zz_render','','','Вы предложили Мире погулять по лесу голенькими и она сразу же согласилась.'
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
				if cloth[0] < 3: gs 'zz_clothing2', 'redress',cloth[3]
				gs 'stat'
				dynamic $miraclothes
				gs 'zz_render','','','Вы напоминаете Мире о третьем желании и она неохотно кивает вам головой, подтверждая, что помнит о нём. Вы, загадочно улыбаясь, приказываете ей следовать за вами...'
				act 'Идти на улицу':
					*clr & cla
					minut += 15
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/street.jpg'
					gs 'zz_render','','','Вы ведете Миру по деревенской улице. Мира молча смотрит себе под ноги, иногда кидая на вас настороженные взгляды...'
					act 'Приказать ей раздеться':
						*clr & cla
						minut += 2
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/new/Mira_looks.jpg'
						gs 'zz_render','','','Выйдя на середину деревни, вы уверенным требовательным голосом приказываете Мирославе раздеться, добавив, что это и есть ваше последнее желание, после которого вы простите ей её предательство. У неё медленно отвисает челюсть и она смотрит на вас как на умалишённую.'
							gs 'zz_render','','',' - Да ладно, что ты как девочка, - презрительно фыркаете вы, - мы ведь обе знаем, что ты та ещё шлюха и жить не можешь без членов. А тут такая реклама, и, заметь, совсем бесплатно.'
						gs 'zz_render','','','Мира молча смотрит то на вас, то оглядывается на деревенскую улицу, по которой ходят люди.'
						gs 'zz_render','','','- Светик, может не надо? - жалобно с надеждой спрашивает она.'
						act 'Подтвердить свои слова':
							*clr & cla
							minut += 5
							horny += RAND(5,10)
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/new/Mira_nude1.jpg'
							gs 'zz_render','','','- Нет уж Мира, тебя за язык никто не тянул, теперь уж будь добра выполняй обещание, - непреклонным тоном ответили вы.'
							gs 'zz_render','','','Девушка ещё минуту нерешительно мнётся с ноги на ногу, после чего наконец решается и быстро сбрасывает всю одежду.'
							gs 'zz_render','','','- Ну вот, теперь доберёшься до конца деревни - и считай себя прощённой! - с ехидной усмешкой звонко хлопаете вы ладонью Миру по заду для придания стартового импульса.'
							act 'Смотреть':
								*clr & cla
								minut += 5
								horny += RAND(5,10)
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/new/Mira_nude2.jpg'
								gs 'zz_render','','','Мира нерешительно начинает двигаться по деревенской улице. Вы с интересом наблюдаете за ней и реакцией прохожих.'
								act 'Смотреть дальше':
									*clr & cla
									minut += 15
									horny += RAND(5,10)
									Mira_no += rand(10,30)
									miraday = daystart
									miragopQW = 33
									miraQW = 1
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/new/Mira_nude3.jpg'
									gs 'zz_render','','','Наконец раскрасневшаяся Мира добирается до конца деревни и подбегает к вам.'
									gs 'zz_render','','',' - Светик, мы в расчёте? - спрашивает она с надеждой.'
									gs 'zz_render','','','Вы, утвердительно кивнув головой, отдаёте ей одежду и понаблюдав ещё пару минут как Мира под улюлюканье случайных свидетелей бежит к своему дому, разворачиваетесь и идёте по своим делам.'
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
							gs 'zz_render','','images/qwest/gadukino/new/Mira_leaves.jpg'
							gs 'zz_render','','','- Ладно, чёрт с тобой, добрая я сегодня. Можешь считать себя прощённой - отвечаете вы после небольшой паузы.'
							gs 'zz_render','','','Девушка ещё пару мгновений нерешительно мнётся с ноги на ногу, не веря ушам, после чего подскакивает к вам и чмокает в щёку.'
							gs 'zz_render','','','- Спасибо Светик, я... я... - и не договорив и разревевшись, она убегает домой.'
							act 'Закончить':mira_guest = 0 & gt 'gadukino'
						end
					end
				end
				act 'Идти к своему сараю':
					*clr & cla
					minut += 10
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/sarai.jpg'
					gs 'zz_render','','','Вы ведёте Миру к своему сараю, где стоит пустующая будка Пирата. Мира непонимающе смотрит на вас, ожидая продолжения.'
					act 'Приказать ей раздеться':
						*clr & cla
						minut += 2
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/new/Mira_looks.jpg'
						gs 'zz_render','','','Окинув Миру и будку оценивающим взглядом, вы увереннным требовательным голосом приказываете Мирославе раздеться и лезть в будку, добавив, что это и есть ваше последнее желание, после которого вы простите ей её предательство. У нее медленно отвисает челюсть и она смотрит на вас как на умалишённую.'
						gs 'zz_render','','',' - Да ладно, что ты как девочка, - презрительно фыркаете вы, - мы ведь обе знаем, что ты та ещё шлюха и жить не можешь без членов. А тут всего лишь требуется посидеть в будке и поизображать Пирата.'
						gs 'zz_render','','','Мира молча смотрит то на вас, то на будку, от которой ещё несет псиной.'
						gs 'zz_render','','','- Светик, может не надо, вдруг увидит кто? - жалобно с надеждой спрашивает она.'
						act 'Подтвердить свои слова':
							*clr & cla
							minut += 5
							horny += RAND(5,10)
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/new/Mira_kennel1.jpg'
							gs 'zz_render','','','- Нет уж Мира, - тебя за язык никто не тянул, теперь уж будь добра - выполняй обещание, - непреклонны вы.'
							gs 'zz_render','','','Девушка еще минуту нерешительно мнётся с ноги на ногу, после чего наконец решается и раздевается догола. Окинув будку унылым взглядом в последний раз, она становится на карачки и неловко пытается забраться в тесную будку.'
							gs 'zz_render','','','- Ну вот, теперь посидишь пару-тройку часиков и свободна, - хлопаете с ехидной улыбкой вы Миру по заду для придания скорости, и устроившись поудобнее поотдаль, с интересом наблюдаете за ней.'
							act 'Смотреть':
								*clr & cla
								minut += 5
								horny += RAND(5,10)
								mira_dog += RAND(2,5)
								miragopQW = 32
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/new/Mira_kennel2.jpg'
								gs 'zz_render','','','Понаблюдав за Мирой некоторое время, вы пошли по своим делам.'
								gs 'zz_render','','',' - Отвяжешься сама, если не приду, - бросили вы ей напоследок.'
								gs 'zz_render','','','<b>(Пока это конец ивента, продолжение последует в следующих версиях)</b>'
								act 'Закончить':mira_guest = 0 & gt 'Gadsarai'
							end
						end
						act 'Простить':
							*clr & cla
							minut += 5
							miraQW += 2
							miragopQW = 31
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/new/Mira_leaves.jpg'
							gs 'zz_render','','','- Ладно, чёрт с тобой, добрая я сегодня. Можешь считать себя прощённой, - отвечаете вы после небольшой паузы.'
							gs 'zz_render','','','Девушка ещё пару мгновений мнётся с ноги на ногу, не веря ушам, после чего подскакивает к вам и чмокает в щёку.'
							gs 'zz_render','','','- Спасибо Светик, я... я... - и не договорив и разревевшись, она убегает домой.'
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
					gs 'zz_render','','','Вам надоело торчать на улице и вы решили пригласить Миру к себе в гости.'
					act'Идти домой':
						if cloth[0] > 2:
							minut += 15 & gt'Gadhouse'
						else
							*clr & cla
							minut += 5
							mira_guest = 1
							mirainriver = 0
							mirainmeadow = 0
							inriver = 0
							gs 'zz_clothing2','redress',cloth[3]
							gs 'zz_render','','images/qwest/gadukino/river/dressbch.jpg'
							gs 'zz_render','','','Вы переоделись в свою одежду и пошли домой с Мирой.'
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
					gs 'zz_render','','images/qwest/gadukino/new/Mira_TV.jpg'
					gs 'zz_render','','','Вы с Мирой целый час убиваете за просмотром телевизора.'
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
					gs 'zz_render','','','Вы попрощались с Мирой, сославшись на неотложные дела, и она ушла домой.'
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
	gs 'zz_render','','',' - А я ведь, хоть и недолго здесь, но об этом месте так и не знала! - весело сообщает вам Мирослава. - Теперь буду знать, где уединиться, когда захочется побыть наедине, ты ведь не возражаешь, правда?'
	act 'Разрешить ей приходить сюда самой':
		*clr & cla
		meadow = 3
		minut += 2
		miraQW += 1
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','Вы отвечаете, что не против и она может приходить сюда когда ей заблагорассудится, но требуете с неё слово, чтобы она никому не рассказывала об этом месте. Мирослава, довольная как слон, активно кивает головой и говорит, что заберёт этот секрет с собой в могилу, а если нет - то тогда как джинн исполнит три любых ваших желания...'
		gs 'zz_render','','','Она выглядит очень довольной, и спустя какое-то время решает рассказать вам очень страшный-страшный секрет...'
			gs 'zz_render','','','Вы заинтригованно соглашаетесь в ожидании, чего же такого сможет поведать вам Мирка, и та вскоре рассказывает вам, что видела, как её отец мастурбирует... Оказывается, после того, как умерла его жена - Миркина мама - у него не было ни одной женщины, вот он и... В общем, Мирке одновременно и жаль отца, но и помочь она ему ничем не может, хоть и очень сильно любит. Вы ожидали чего-то большего, а потому, услышав такую ерунду, конечно же сказали, что это не секрет, а глупость какая-то. Мирка обиженно надулась, всем своим видом демонстрируя оскорблённую невинность. А через пару минут, к своему удивлению, вы почувствовали, как неожиданно приятно зудит и влажнеет у вас в промежности от мысли об Мирославином отце...'
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
	*clr & cla
	minut += 5
	mira_no_home = 0
	gs 'stat'
	if mirainriver = 1:gs 'zz_render', $_str, 'gadukino/river/events/mira_go_home'+iif(cloth[0] = 0,'_nude','')
	if mirainriver = 0:dynamic $miraclothes
	gs 'zz_render','','','- Светик, c тобой весело, но мне пора домой, - сказала вам Мира.'
	act 'Далее':mira = 0 & mira_guest = 0 & mirainriver = 0 & mirainmeadow = 0 & mirainforest = 0 & gt $loc, $metka
end
if miraQW >= 15 and Mira_no = 0 and (mitkasextimes < 13 or miragopQW >= 10 or mirasex > 1):
	if mira_guest = 0 and mira_temp >= 1 and mira_temp <= 2 and mira_go_blok = 0 and mirainforest = 0:
		*clr & cla
		minut += 1
		gs 'stat'
		if mirainriver = 1:dynamic $mira_river
		if mirainriver = 0:dynamic $miraclothes
		gs 'zz_render','','','- Светик, что-то скучно тут, а давай к тебе домой пойдём? - предлагает Мира.'
		act'Согласиться':
			if cloth[0] > 2:
				mira_go_blok = 1 & mirainmeadow = 0 & mirainhome = 0 & inriver = 0 & mirainriver = 0 & mira_guest = 1 & mira_go_blok = 1 & minut += 15 & miraQW += 1 & gt'Gadhouse'
			else
				*clr & cla
				miraQW += 1
				mira_go_blok = 1
				mira_guest = 1
				mirainriver = 0
				mirainmeadow = 0
				mirainhome = 0
				inriver = 0
				if miraQW < 30:miraQW += 1
				minut += 20
				gs 'zz_clothing2','redress',cloth[3]
				gs 'zz_render','','images/qwest/gadukino/river/dressbch.jpg','Вы переоделись и отправились с Мирой к вам домой.'
				act 'Далее': gt'Gadhouse'
			end
		end
		act'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg','Вы отказали Мире, сославшись на то, что там вам будет скучно.'
			act 'Далее': gt $loc, $metka
		end
	end
	if mira_guest = 1 and mira_temp >= 3 and mira_temp <= 4:
		*clr & cla
		minut += 1
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','- Светик, давай телек посмотрим, а то что-то скучно - предлагает Мира.'
		act'Согласиться':
			*clr & cla
			minut += 60
			if miraQW < 20:miraQW += 1
			manna += rand(10,50)
			mira_go_blok = 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/Mira_TV'+rand(1,12),'Вы с Мирой целый час убиваете за просмотром телевизора.'
			act'Далее':gt'Gadhouse'
		end
		act'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg','Вы отказали Мире, сославшись на то, что вам это не интересно.'
			act 'Далее': gt $loc, $metka
		end
	end
	if mirainmeadow = 0 and mira_temp = 5 and meadow = 3 and mira_go_blok = 0 and mirainforest = 0 and hour < 19 and sunWeather >= 0 and month >= 4 and month <= 10:
		*clr & cla
		minut += 1
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','- Светик, может сходим на нашу поляну? - спрашивает Мира. - Прогуляемся, воздухом подышим.'
		act'Согласиться':
			*clr & cla
			minut += 15
			manna += 5
			if miraQW < 50:miraQW += 1
			mira_guest = 0
			mirainriver = 0
			mirainmeadow = 1
			inriver = 0
			mira_go_blok = 1
			mirainhome = 0
			if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/girls_go.jpg','Вы идёте с Мирой сквозь густые заросли к скрытой поляне и всю дорогу она не умолкает, весело щебеча и рассказывая истории из своей прошлой городской жизни.'
			act 'Далее': gt 'Meadow'
		end
		act'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg','Вы отказали Мире, сославшись на то, что там вам будет скучно.'
			act 'Далее': gt $loc, $metka
		end
	end
	if mirainriver = 0 and mira_temp >= 6 and mira_temp <= 7 and sunWeather >= 0 and temper >= 20 and mira_go_blok = 0 and mirainforest = 0 and hour < 18:
		*clr & cla
		minut += 1
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','- Светик, может сходим на речку? - спрашивает Мира. - Искупаемся, позагораем.'
		act 'Согласиться':
			*clr & cla
			minut += 15
			if miraQW < 30:miraQW += 1
			mira_guest = 0
			mirainriver = 1
			mirainmeadow = 0
			inriver = 1
			mira_go_blok = 1
			mirainhome = 0
			if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/girls_go.jpg','Вы решили сходить с Мирой на деревенский пляж и всю дорогу она не умолкает, весело щебеча и рассказывая разные истории.'
			act 'Далее': gt 'gadbeach'
		end
		act 'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg','Вы отказали Мире, сославшись на то, что там вам будет скучно.'
			act 'Далее': gt $loc, $metka
		end
	end
	if hour >= 20 and mira_temp > 10 and sunWeather >= 0 and mira_go_blok = 0 and miragopQW > 0 and mirainforest = 0 and month >= 4 and month <= 10:
		*clr & cla
		minut += 1
		mira_go_blok = 1
		miraingop = 1
		mirainhome = 0
		mira_guest = 0
		mirainriver = 0
		mirainmeadow = 1
		inriver = 0
		if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','- Светик, может сходим с местными побухаем? - предлагает Мира. - Скучно, развеяться хочется.'
		if miragopQW > 15 and mitkasextimes > 15:
			act 'Согласиться':mira_guest = 0 & inriver = 0 & mirainriver = 0 & mirainmeadow = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh_group'
		else
			act 'Согласиться':mira_guest = 0 & inriver = 0 & mirainriver = 0 & mirainmeadow = 0 & minut += 15 & temp = 0 & miralko = 0 & gt 'mitkabuh'
		end
		act 'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg','Вы отказали Мире, сославшись на то, что там вам будет скучно.'
			act 'Далее': gt $loc, $metka
		end
	end
	if mira_temp > 8 and mira_temp < 9:
		*clr & cla
		minut += 1
		mira_go_blok = 1
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','Мира хочет с вами поболтать.'
		gs 'zz_render','','',' - Светик, ты не против? - спросила у вас Мира.'
		act'Согласиться':act 'Поболтать':dynamic $miratalk
		act'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg',' - Не, Мир, давай не сейчас. Нет настроения сейчас разговаривать.'
			act 'Далее': gt $loc, $metka
		end
	end
	if mirainriver = 1 and mira_temp >= 8 and mira_temp <= 9 and sunWeather >= 0 and temper >= 20:
		*clr & cla
		minut += 1
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','',' - Светик, чего ты на берегу киснешь? Айда купаться! - кричит вам Мира и кидается в речку.'
		act'Согласиться':
			if cloth[0] < 3:
				*clr & cla
				minut += 60
				gs 'zz_bathroom', 'clean_me'
				manna += 10
				if stren < 20:stren += 1
				gs 'stat'
				if cloth[0] = 2:
					gs 'zz_render','','images/qwest/gadukino/river/RiverTwoGirls.jpg','Вы искупнулись в речушке, весело брызгаясь с Мирой друг на дружку водой.'
				else
					gs 'zz_render','','images/qwest/gadukino/river/RiverTwoGirlsNude.jpg','Вы искупнулись в речушке, весело брызгаясь с Мирой друг на дружку водой.'
				end
				act 'Выйти из воды':gt 'gadbeach'
			else
				*clr & cla
				minut += 5
				inriver = 1
				gs 'zz_clothing2','redress',2
				gs 'zz_render','','images/qwest/gadukino/river/undressbch.jpg'
				gs 'zz_render','','',' - Сейчас, Мирка, только купальник надену! - крикнули вы в ответ, хотя вряд ли она вас услышала, плескаясь уже вовсю в речке.'
				gs 'zz_render','','','Вы переодеваетесь в купальник и кидаетесь в воду вслед за Мирой.'
				act'Купаться':
					*clr & cla
					minut += 60
					gs 'zz_bathroom', 'clean_me'
					manna += 10
					if stren < 20:stren += 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/river/RiverTwoGirls.jpg','Вы искупнулись в речушке, весело брызгаясь с Мирой друг на дружку водой.'
					act 'Выйти из воды':gt 'gadbeach'
				end
			end
		end
		act'Отказаться':
			*clr & cla
			minut += 1
			miraQW -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg',' - Не, Мир, неохота, - ответили вы ей. - Я на берегу лучше побуду.'
			act 'Далее': gt 'gadbeach'
		end
	end
end
$miraclothes = {
	if miragopQW = 0:
		gs 'zz_render','','images/qwest/gadukino/Mira.jpg'
	elseif miragopQW > 0 and miragopQW < 4:
		gs 'zz_render','','images/qwest/gadukino/Mira3.jpg'
	elseif miragopQW >= 4 and miragopQW < 8:
		gs 'zz_render','','images/qwest/gadukino/mira0,'+rand(0,5)
	elseif miragopQW >= 8 and miragopQW < 12:
		gs 'zz_render','','images/qwest/gadukino/mira1,'+rand(0,2)
	elseif miragopQW >= 12 and miragopQW < 20:
		gs 'zz_render','','images/qwest/gadukino/mira2,'+rand(0,5)
	elseif miragopQW >= 20:
		gs 'zz_render','','images/qwest/gadukino/mira3,'+rand(0,3)
	end
}
$mira_river = {
	if cloth[0] > 2:'<center><img src="images/qwest/gadukino/river/MiraRiverTalk.jpg"></center>'
	if cloth[0] = 2:'<center><img src="images/qwest/gadukino/river/MiraRiverTalkBikini.jpg"></center>'
	if cloth[0] = 0:'<center><img src="images/qwest/gadukino/river/MiraRiverNudeTalk.jpg"></center>'
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
			gs 'zz_render','','','Вы десять минут весело болтаете о всяких пустяках.'
		else
			gs 'zz_render','','','Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
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
			gs 'zz_render','','','Вы десять минут весело болтаете о всяких пустяках, иногда вспоминая, как вы напились с деревенскими парнягами...'
		else
			gs 'zz_render','','','Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
		end
		if mirasextimes > 3:
			act 'Спросить про неё и Митьку':
				*clr & cla
				minut += 2
				horny += 10
				miraQW += 1
				miragopQW = 2
				manna += 10
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Mira3.jpg','Вы спрашиваете Миру, есть ли что-то между ней и Митькой и она, немного помявшись, отвечает, что да, есть. На все дальнейшие расспросы она или отмалчивается или увиливает, поэтому вы решаете оставить это до более подходящих времен...'
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
			gs 'zz_render','','','Вы десять минут весело болтаете о всяких пустяках, а Мира иногда заливается румянцем, что-то вспоминая...'
			if miragopQW = 3 and mitkasextimes < 13:
				act 'Сказать, что видели, как она трахалась с Митькой на поляне':
					*clr & cla
					minut += 2
					horny += 10
					miraQW -= 1
					manna += 10
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Mira3.jpg'
					gs 'zz_render','','','Вы холодно говорите Мирославе, что видели, как она раздвигала ноги перед Митькой на вашей поляне и цитируете её слова о том, как она клялась никому не рассказывать о вашем тайном месте. Мира краснеет и потупливает взор, бормоча, что ей очень жаль, что так получилось, а потом спрашивает, есть ли что-то, что она может сделать для вас, чтобы загладить свою вину. Вы ей тут же напоминаете про три желания, которые она обещала исполнить, если кому-то расскажет, и она подобострастно кивает вам головой, что, мол, да, она помнит и готова искупить вину.'
					act 'Сказать, что вы хотите посмотреть, как Митька будет драть ее в задницу':
						*clr & cla
						minut += 5
						horny += 10
						manna += 10
						miragopQW = 5
						miraQW -= 1
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/Mira3.jpg'
						gs 'zz_render','','','Вы говорите, что хотите посмотреть, как Митька отдерёт её в задницу за то, что она разболтала ваш секрет. Мира опешивает от таких слов и тупо смотрит на вас, но вы не даёте ей опомниться и продолжаете напирать дальше, напоминая, что уговор есть уговор, и если она и это своё слово не сдержит, то на этом ваша дружба и закончится. Мирослава густо краснеет и нерешительно переминается с ноги на ногу, и вы, решив идти ва-банк, разворачиваетесь, собираясь уходить...'
						gs 'zz_render','','',' - Постой, - негромко кричит вам в спину Мирослава, но вы делаете вид, что не замечаете и идете дальше.'
						gs 'zz_render','','',' - Хорошо, Света, - спустя долгих пару секунд доносится до вас истеричный крик Мирославы, - я что-нибудь придумаю!'
						act 'Уйти':gt $loc, $metka
					end
				end
			end
		else
			gs 'zz_render','','','Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
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
			gs 'zz_render','','','Вы десять минут болтаете о разных пустяках, при этом Мира иногда, краснея, рассказывает вам некоторые интимные подробности её отношений с Митькой.'
		else
			gs 'zz_render','','','Вы некоторое время пытаетесь разговорить Миру, но та отмалчивается, иногда кидая на вас презрительные взгляды.'
		end
		if miragopQW = 6:
			act 'Сказать, что первое желание выполнено':
				*clr & cla
				minut += 10
				horny += 15
				miragopQW = 7
				manna += 10
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Mira3.jpg'
				gs 'zz_render','','','Вы говорите Мирославе, что видели, как Митька драл её в задницу и ехидно спрашиваете, понравилось ли ей. К вашему удивлению, она, краснея и смущаясь, говорит, что немного... Вы разочарованно хмыкнув, напоминаете ей, что осталось ещё два желания, по исполнении которых вы сможете забыть о её предательстве. Мира подобострастно кивает и говорит, что готова искупить свою вину. Вы отвечаете, что пока подумаете над вторым желанием, и развернувшись, уходите...'
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
			gs 'zz_render','','','Вы десять минут вяло болтаете о разных пустяках, при этом Мира старается не встречаться с вами взглядом.'
		else
			gs 'zz_render','','','Вы десять минут болтаете о разных пустяках, при этом Мира иногда, краснея, рассказывает вам некоторые интимные подробности её отношений с Митькой.'
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
			gs 'zz_render','','','Вы десять минут вяло болтаете о разных пустяках, при этом вы часто зовёте её не по имени, а называете просто шлюхой, на что она делает вид, будто ничего не замечает.'
		elseif miragopQW >= 20 and miragopQW < 30 and mitkasextimes < 13:
			gs 'zz_render','','','Вы десять минут вяло болтаете о разных пустяках, при этом Мира вообще не смотрит вам в глаза и со всем с вами соглашается, думая о чём-то своём.'
		elseif miragopQW >= 30 and mitkasextimes < 13:
			gs 'zz_render','','','Вы десять минут вяло болтаете о разных пустяках, но Мира вообще вас не слушает, все её разговоры сводятся к сексу.'
		else
			gs 'zz_render','','','Вы десять минут весело болтаете о всяких пустяках.'
		end
		act 'Закончить':gt $loc, $metka
	end
}