if $ARGS[0] = 'mira_in_river':
	i = rand(1,10)
    if mira_go_blok = 0 and mirainriver = 1 and (i = 5 or hour = 20):
	    *clr & cla
        mirainriver = 2
        minut += 5
        mira_go_blok = 2
        mira_no_home = 0
        gs 'stat'
	    gs 'zz_render', $_str, 'gadukino/river/events/mira_go_home'+iif(current_clothing = 0,'_nude','')+'.jpg', ' - <<$name[2]>>, мне пора домой, - сказала вам Мира и стала собираться.'
        act 'Далее': gt 'gadbeach'
	end
    if miraQW > 0 and inriver = 1 and Mira_no = 0 and mirainriver = 0 and i > 7 and hour > 8 and hour < 20 and sunWeather >= 0 and temper >= 20:
	    *clr & cla
        mirainriver = 1
        mira_go_river = 1
        minut += 5
        mira_go_blok = 2
        gs 'stat'
	    gs 'zz_render', $_str, 'gadukino/river/events/mira_go_river'+iif(current_clothing = 0,'_nude','')+'.jpg', 'Вы загорали, когда на речке появилась Мира.'+iif(current_clothing = 0 and miratalkforest < 3 and shameless['flag'] = 0,' Покраснев, вы быстренько натянули свой купальник, и улеглись загорать дальше.','')+' Улыбнувшись вам, она разделась и принялась растилать свое покрывало рядом с вашим.'
	    if current_clothing = 0 and miratalkforest < 3 and shameless['flag'] = 0: gs 'zz_clothing', 'redress', 2
        act 'Далее': gt 'gadbeach'
	end
    if miraQW > 0 and inriver = 0 and Mira_no = 0 and mirainriver = 0 and i < 3 and hour > 8 and hour < 20 and sunWeather >= 0 and temper >= 20:
	    *clr & cla
        mirainriver = 1
        minut += 5
        mira_go_blok = 2
        gs 'stat'
	    gs 'zz_render', $_str, 'gadukino/river/events/mira_in_river.jpg', 'Придя на пляж, вы увидели загорающую на покрывале Мирославу.'
        act 'Далее': gt 'gadbeach'
	end
end
if $ARGS[0] = 'mira_punish':
	*clr & cla
	minut += 10
	horny += RAND(25,75)
	gs 'stat'
	gs 'zz_render', $_str, 'gadukino/river/events/mira_punish.jpg', 'Вы подходите к ней поближе и Мирослава радостно вам улыбается, прося освободить ее. Пока вы развязываете ее, она вам рассказывает, что это ее так Колямба наказал за то, что она слегка укусила его за член, когда сосала ему...**\\\- Слава богу, -/// со вздохом облегчения добавляет она к своему рассказу.\\\ - Хорошо, что это ты мне попалась, а не кто-нибудь другой. Представляешь, какая бы картина была - голая Мирка, распятая между деревьями - подходи и делай, что хочешь, хоть трахай, хоть бей, убивай... Ну да пронесло, спасибо тебе, <<$name[2]>>, ты меня здорово выручила!'
	act 'Уйти':minut += 5 & gt 'gadbeach'
end
if $ARGS[0] = 'swim_guys':
	i = rand(0,15)
	if guysriver ! day:
		guysriver = day
		if current_clothing = 2:
			if mirainriver = 0 and mitkasextimes >= 13 and temp = 0 and hour >= 8 and hour < 20:
				*clr & cla
				minut += 10
				dom -= 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				gang += 1
				bj += 3
				swallow += rand(1,3)
				gs 'stat'
				gs 'zz_render', $_str, 'gadukino/river/guys/'+rand(1,3)+'.jpg', 'Едва вы собрались вылезать из воды, как услышали на берегу громкий мужской гогот, а через пару мгновений у воды уже стояли деревенские пацаны с ухмыляющимся Митькой во главе. Они быстро вошли в воду и без предисловий начали по очереди трахать вас в рот. Кончив, они двинулись своей дорогой дальше, оставив вас на пляже с обконченым лицом и полным ртом спермы.'
				act 'Закончить': gt 'gadbeach'
			elseif mirainriver = 0 and mitkasextimes >= 13 and temp = 1 and hour >= 8 and hour < 20 and dom < 0:
				*clr & cla
				i = rand(1,3)
				$boy = iif(i = 1,'Митька',iif(i = 2,'Колямба','Васян'))
				dick = iif(i = 1,16,iif(i = 2,15,14))
				silavag = 0
				pose = 1
				gs 'stat'
				gs 'zz_render', $_str, 'images/gadukino/mitka/'+iif(i = 1,'mitka',iif(i = 2,'kolyamba','vasyan'))+'.jpg', 'Едва вы вылезли из воды, как наткнулись на ухмыляющегося '+iif(i = 1,'Митьку',iif(i = 2,'Колямбу','Васяна'))+'. Тот не терпящим возражений тоном потребовал, чтобы вы разделись и встали в позу...'
				act 'Нагнуться':
					*clr & cla
					minut += 5
					dom -= 1
					i = rand(4,5)
					gs 'stat'
					gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif'
					if i = 5:
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Закончить': gt 'gadbeach'
				end
			end
		else
			if mirainriver = 0 and mitkasextimes >= 13 and temp = 0 and hour >= 8 and hour < 20:
				*clr & cla
				minut += 5
				$boy = 'Митька'
				silavag = 0
				dick = 16
				gang += 1
				dom -= 1
				i = rand(5,14)
				pose = iif(i = 8,2,iif(i < 8 or i > 11,1,0))
				gs 'stat'
				gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif', 'Едва вы вылезли из воды, как наткнулись на пацанов, которые как раз шли куда-то на рыбалку. Увидев, что вы купаетесь голышом, они тут же не преминули вами попользоваться, совершенно не интересуясь вашим мнением.'
				if i < 10:
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				else
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Далее':
					*clr & cla
					minut += 5
					$boy = 'Васян'
					dick = 14
					i = rand(5,14)
					pose = iif(i = 8,2,iif(i < 8 or i > 11,1,0))
					gs 'stat'
					gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif'
					if i < 10:
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Далее':
						*clr & cla
						minut += 5
						$boy = 'Колямба'
						dick = 15
						i = rand(5,14)
						pose = iif(i = 8,2,iif(i < 8 or i > 11,1,0))
						gs 'stat'
						gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif'
						if i < 10:
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
						else
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
						end
						act 'Закончить': gt 'gadbeach'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'sunbathe_guys':
	i = rand(0,15)
	if guysriver ! day:
		guysriver = day
		if mirainriver = 0 and mitkasextimes >= 13 and i = 0 and hour >= 8 and hour < 20:
			*clr & cla
			minut += 5
			$boy = 'Колямба'
			silavag = 0
			dick = 15
			dom -= 1
			gang += 1
			i = rand(5,14)
			pose = iif(i = 8,2,iif(i < 8 or i > 11,1,0))
			gs 'stat'
			gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif', 'Через некоторое время вы слышите мужские голоса, которые стремительно приближаются, а уже через пару минут перед вами появляются деревенские пацаны. Увидев вас, они заметно оживляются и через пару минут, несмотря на все ваши вялые протесты, начинают иметь вас во все дыры...'
			if i < 10:
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				gs 'zz_dynamic_sex', 'sex_cum'
			else
				gs 'zz_dynamic_sex', 'anal', 'dick'
				gs 'zz_dynamic_sex', 'anal_cum'
			end
			act 'Далее':
				*clr & cla
				minut += 5
				$boy = 'Васян'
				dick = 14
				i = rand(5,14)
				pose = iif(i = 8,2,iif(i < 8 or i > 11,1,0))
				gs 'stat'
				gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif'
				if i < 10:
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				else
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Далее':
					*clr & cla
					minut += 5
					$boy = 'Митька'
					dick = 16
					i = rand(5,14)
					pose = iif(i = 8,2,iif(i < 8 or i > 11,1,0))
					gs 'stat'
					gs 'zz_render', $_str, 'gadukino/river/guys/<<i>>.gif'
					if i < 10:
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Закончить': gt 'gadbeach'
				end
			end
		elseif mirainriver = 1 and current_clothing = 2 and miragopQW >= 15 and i = 1 and hour >= 8 and hour < 20:
			*clr & cla
			minut += 15
			horny += 20
			dom += 5
			gs 'stat'
			gs 'zz_render', $_str, 'gadukino/river/guys/'+rand(15,16)+'.jpg', 'Через некоторое время вы слышите мужские голоса, которые стремительно приближаются, а уже через пару минут перед вами появляются деревенские пацаны. Увидев Мирославу, они тут же начинают похабно улыбаться, а через пару минут, ничуть вас не стесняясь, раскладывают ее на песке и начинают сношать во все щели...'
			act 'Закончить':minut += 5 & gt 'gadbeach'
		end
	end
end
if $ARGS[0] = 'guys_river':
	*clr & cla
	guysriver = day
	minut += 10
	horny += 10
	dom -= 1
	i = RAND(1,2)
	gs 'stat'
	if i = 1:
		gs 'zz_render', $_str, 'images/gadukino/mitka/3boys.1.jpg','По дороге вы встречаете деревенских пацанов и те настойчиво приглашают вас пройтись с ними.'
		act 'Идти с ними':
			*clr & cla
			minut += 5
			$boy = 'Васян'
			silavag = 0
			dick = 14
			dom -= 1
			i = rand(17,24)
			pose = iif(i < 19 or i > 22,1,0)
			killvar '$_str'
			gs 'stat'
			gs 'zz_render', '', 'gadukino/river/guys/<<i>>.gif','Пацаны приводят вас к Васяну домой, где, не церемонясь, по очереди, начинают сношать.'
			if i < 21:
				gs 'zz_dynamic_sex', 'sex_start'
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				gs 'zz_dynamic_sex', 'sex_cum'
			else
				gs 'zz_dynamic_sex', 'anal_start', 'dick'
				gs 'zz_dynamic_sex', 'anal', 'dick'
				gs 'zz_dynamic_sex', 'anal_cum'
			end
			act 'Дать Митяю':
				*clr & cla
				minut += 5
				$boy = 'Митяй'
				dick = 16
				i = rand(17,24)
				pose = iif(i < 19 or i > 22,1,0)
				gs 'stat'
				gs 'zz_render', '', 'gadukino/river/guys/<<i>>.gif'
				if i < 21:
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				else
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Далее':
					*clr & cla
					minut += 5
					$boy = 'Колямба'
					dick = 15
					i = rand(17,24)
					pose = iif(i < 19 or i > 22,1,0)
					gs 'stat'
					gs 'zz_render', '', 'gadukino/river/guys/<<i>>.gif'
					if i < 21:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Закончить': minut += 10 & gt'gadukino'
				end
			end
		end
	else
		i = rand(1,3)
		gs 'zz_render', $_str, 'images/gadukino/mitka/'+iif(i = 1,'mitka',iif(i = 2,'kolyamba','vasyan'))+'.jpg','По дороге вы встречаете '+iif(i = 1,'Митьку',iif(i = 2,'Колямбу','Васяна'))+' и тот требовательно приглашает вас к себе домой...'
		act 'Идти с ним':
			*clr & cla
			minut += 15
			$boy = iif(i = 1,'Митька',iif(i = 2,'Колямба','Васян'))
			dick = iif(i = 1,16,iif(i = 2,15,14))
			silavag = 0
			if mop > 1: mop = 0 & vidageday -= 1
			if throat < dick: throat += 1
			killvar '$_str'
			gs 'stat'
			gs 'zz_render', '', 'gadukino/river/guys/25.gif','Вы пришли к парню домой, где он тут же поставил вас на колени. Его член уперся вам в ваши <<$liptalk3>>, вы приоткрыли их и впустили его в свой рот. Твердый член заполнял весь ваш рот, обхватывая его губами вы каждым движением его вбирали до горла. <<$boy>> взял вас за волосы и стал трахать вас в рот, от ударов члена в горло у вас потекли слезы из глаз.'
			act 'Далее':
				*clr & cla
				minut += 5
				i = rand(17,24)
				pose = iif(i < 19 or i > 22,1,0)
				gs 'stat'
				gs 'zz_render', '', 'gadukino/river/guys/<<i>>.gif'
				if i < 21:
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				else
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Закончить': minut += 10 & gt'gadukino'
			end
		end
	end
	if dom > 0: act 'Уйти': gt 'gadbeach'
end
if $ARGS[0] = 'guys_beach':
	*clr & cla
	guysriver = day
	minut += 5
	horny += 10
	i = rand(1,3)
	gs 'stat'
	gs 'zz_render', $_str, 'gadukino/river/events/gays_river.jpg',' - О, <<$name[2]>>, нам-то как раз тебя и не хватало, - заулыбался Колямба, увидев вас на пляже.'
	if i = 1:
		gs 'zz_render', '', '', ' - Вроде вокруг никого, а ебаться хочется, так что давай, раздвигай ножки, поработай своей пизденкой...'
		act 'Обслужить Колямбу':
			*clr & cla
			$boy = 'Колямба'
			silavag = 0
			pose = 2
			dick = 15
			minut += 5
			horny += 10
			i = RAND(0,2)
			gs 'stat'
			gs 'zz_render', $_str, 'gadukino/river/guys/8.gif','Вы быстро '+iif(tanga > 0,'сняли трусы и ','')+'залезли на умостившегося Колямбу, рукой нащупывая его член.'
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Обслужить Васяна':
				*clr & cla
				$boy = 'Васян'
				silavag = 0
				dick = 14
				minut += 5
				horny += 10
				gs 'stat'
				if i = 0:
					pose = 0
					gs 'zz_render', $_str, 'gadukino/river/guys/9.gif','Вы перевернулись на спину и призывно распахнули Васяну ноги.'
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				elseif i = 1:
					bj += 1
					gs 'zz_render', $_str, 'gadukino/river/guys/26.gif','Васян подходит к вам и бесцеремонно вываливает перед вашим лицом свой член.'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_dynamic_sex', 'swallow'
				else
					pose = 1
					gs 'zz_render', $_str, 'gadukino/river/guys/13.gif','Васян ставит вас раком и пристраивается к вашему анусу.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Уйти': gt'gadbeach'
			end
		end
	elseif i = 2:
		gs 'zz_render', '', '', ' - Пососи нам, а? А мы тебе век благодарны будем, ха-ха!'
		act 'Обслужить Колямбу':
			*clr & cla
			$boy = 'Колямба'
			horny += 10
			minut += 5
			dick = 15
			bj += 1
			gs'stat'
			gs 'zz_render', $_str, 'gadukino/river/guys/27.gif','Вы сгибаетесь возле развалившегося Колямбы и подносите его член к своим губам...'
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_dynamic_sex', 'swallow'
			act 'Обслужить Васяна':
				*clr & cla
				$boy = 'Васян'
				silavag = 0
				dick = 14
				minut += 5
				horny += 10
				i = RAND(0,2)
				gs 'stat'
				if temp = 0:
					pose = 0
					gs 'zz_render', $_str, 'gadukino/river/guys/9.gif', 'Вы перевернулись на спину и призывно распахнули Васну ноги.'
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				elseif i = 1:
					bj += 1
					gs 'zz_render', $_str, 'gadukino/river/guys/26.gif','Васян подходит к вам и бесцеремонно вываливает перед вашим лицом свой член.'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_dynamic_sex', 'swallow'
				else
					pose = 1
					gs 'zz_render', $_str, 'gadukino/river/guys/14.gif','Васян ставит вас раком и пристраивается к вашему анусу.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Уйти': gt'gadbeach'
			end
		end
	else
		gs 'zz_render', '', '', ' - Подставляй свою жопку, а то мне ох как охота кончить в нее...'
		act 'Обслужить Колямбу':
			*clr & cla
			$boy = 'Колямба'
			horny += 10
			minut += 5
			dick = 15
			pose = 1
			gs'stat'
			gs 'zz_render', $_str, 'gadukino/river/guys/12.gif'
			gs 'zz_dynamic_sex', 'anal_start', 'dick'
			gs 'zz_dynamic_sex', 'anal', 'dick'
			gs 'zz_dynamic_sex', 'anal_cum'
			act 'Обслужить Васяна':
				*clr & cla
				$boy = 'Васян'
				silavag = 0
				dick = 15
				minut += 5
				horny += 10
				temp = RAND(0,2)
				gs 'stat'
				if temp = 0:
					pose = 0
					gs 'zz_render', $_str, 'gadukino/river/guys/9.gif','Вы перевернулись на спину и призывно распахнули Васну ноги.'
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
				elseif temp = 1:
					bj += 1
					gs'stat'
					gs 'zz_render', $_str, 'gadukino/river/guys/26.gif','Васян подходит к вам и бесцеремонно вываливает перед вашим лицом свой член.'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_dynamic_sex', 'swallow'
				else
					pose = 1
					gs 'zz_render', $_str, 'gadukino/river/guys/13.gif','Васян ставит вас раком и пристраивается к вашему анусу.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				act 'Уйти':minut += 5 & gt 'gadbeach'
			end
		end
	end
	if dom > 0: act 'Уйти': gt 'gadbeach'
end
if $ARGS[0] = 'horse_river':
	*clr & cla
	minut += 5
	inriver = 1
	gs 'stat'
	gs 'zz_render', $_str, 'images/gadukino/horse/river.jpg', 'Дедушкин помощник - конь Буян.'
    if horse_river = 2:
	    act 'Вымыть коня':
	        *clr & cla
		    minut += 30
			gs 'zz_bathroom', 'clean_me'
	        manna += 5
		    horse_river = 3
		    gs 'stat'
		    horny += RAND(5,15)
		    if current_clothing = 2:
		        gs 'zz_render', $_str, 'images/gadukino/horse/wash_swim'+iif(mirainriver = 1,'_mira','')+'.jpg', 'Вы в течение часа мыли и отскребали с Мирой коня Буяна.'
            elseif current_clothing = 0:
		        gs 'zz_render', $_str, 'images/gadukino/horse/wash_nude'+iif(mirainriver = 1,'_mira','')+'.jpg', 'Вы в течение часа мыли и отскребали с Мирой коня Буяна. И были при этом совершенно голенькие.'
            else
		        gs 'zz_render', $_str, 'images/gadukino/horse/wash.jpg', 'Вы в течение часа мыли и отскребали коня Буяна прямо в одежде.'
                gs 'zz_clothing', 'decrease_condition', 1
            end
            act 'Закончить':gt 'gadbeach'
        end
	end
    if horse_river = 3:
	    act 'Отвести коня домой':
		    if current_clothing > 2 or (current_clothing >= 0 and exhibi > 0):
		       *clr & cla
			    minut += 30
			    horse_river = 0
			    mirainriver = 0
			    grandmahelp += 1
			    grandpaQW += 1
			    inriver = 0
			    gs 'stat'
			    gs 'zz_render', $_str, 'images/gadukino/horse/lead'+iif(current_clothing = 0,'_nude',iif(current_clothing = 2,'_swim',''))+'.jpg', 'Вы взяли коня под уздцы и отправились с ним домой.'
		        act 'Далее':
					killvar '$_str'
					gt'Gadsarai'
				end
	        else
	            *clr & cla
		        gs 'stat'
		        gs 'zz_render', $_str, 'images/gadukino/horse/lead_'+iif(current_clothing = 0,'nude','swim')+'.jpg', '<b>Вы не можете появиться в таком виде в деревне.</b>'
		        act 'Далее': gt'river_events','horse_river'
	        end
	    end
	end
	act 'Уйти': gt 'gadbeach'
end
if $ARGS[0] = 'fishers':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render',$_str, 'images/gadukino/river/fishers/fishers.jpg'
	if fishersday ! daystart:
		act 'Поздороваться':
			*clr & cla
			fishersday = daystart
			minut += 5
			if fishersQW < 3: fishersQW += 1
			gs 'stat'
			gs 'zz_render',$_str, 'images/gadukino/river/fishers/say_hello.jpg', 'Вы вежливо здороваетесь с рыбаками, но те полностью сосредоточены на рыбной ловле, а потому один из них всего лишь отвлеченно махает вам рукой в ответ.'
			if fishersQW >= 3:
				act 'Поболтать':
					*clr & cla
					minut += 30
					if fishersQW = 3:fishersQW = 4
					gs 'stat'
					gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Подойдя к рыбакам вы весело спрашиваете у них как поклевка. Один из них, в этот раз с явной охотой, оборачивается к вам и вы минут десять болтаете о рыбе и особенностях местной рыбалки.'
					act 'Уйти':minut += 5 & gt'Gadriver'
				end
			end
			if fishersQW = 4:
				act 'Попроситься к ним':
					*clr & cla
					minut += 5
					fishersQW = 5
					gs 'stat'
					gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Вы решаете тоже попробовать порыбачить и спрашиваете у рыбаков, не одолжат ли они вам удочку. Уже знакомый вам Дядя Степа с охотой протягивает вам одну из своих удочек.'
					act 'Рыбачить': gt'river_events','fishing'
				end
			end
			if fishersQW = 5:
				act 'Порыбачить с ними':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Вы решаете присоединиться к своим знакомым и дядя Степа охотно дает вам одну из своих удочек, при этом масляными глазками не забывая пройтись вдоль вашего тела.'
					act 'Рыбачить': gt'river_events','fishing'
				end
			end
			act 'Уйти':minut += 5 & gt'Gadriver'
		end
		act 'Уйти':minut += 5 & gt'Gadriver'
	else
		act 'Уйти':minut += 5 & gt'Gadriver'
	end
end
if $ARGS[0] = 'fishing':
	*clr & cla
	gs'time'
	gs 'zz_render',$_str, func('zz_funcs','mk_image','images/gadukino/river/gadriver.jpg'),'Небольшая речка тихо плещет свои неглубокие воды, приятно щекоча слух деревенским умиротворением и спокойствием.**Вы поймали <<fish>> рыб'+iif(fish = 1,'у',iif(fish < 5,'ы',''))+'.'
	if hour < func('zz_weather','sunset'):
		act 'Забросить удочку':
			*clr & cla
			minut += 10
			if hour < 10:
				i = rand(10,20)
			elseif hour >= 12 and hour < 18:
				i = rand(0,20)
			else
				i = rand(5,20)
			end
			gs 'stat'
			gs 'zz_render',$_str, 'images/gadukino/river/fishers/fishing.jpg','Вы ловите рыбку, внимательно наблюдая за поплавком.'
			if i > 15:
				minut += 1
				gs 'stat'
				gs 'zz_render','', '','Внезапно поплавок резко ныряет под воду.'
				act 'Тянуть':
					*clr & cla
					minut += 1
					i = rand(0,120)
					if temp < 50:react += 1
					gs 'stat'
					if react > i:
						manna += 20
						react += 1
						fish += 1
						gs 'stat'
						gs 'zz_render',$_str, 'images/gadukino/river/fishers/fish.jpg','Вы ловко подсекаете, чувствуя, как напрягается удилище, и через секунду азартно вытаскиваете небольшую рыбёшку.'
					else
						manna -= 10
						gs 'stat'
						gs 'zz_render','', func('zz_funcs','mk_image','images/gadukino/river/gadriver.jpg'),'Вы подсекаете, но слишком поздно, рыбы на крючке уже нет.'
					end
					act 'Надеть наживку': gt'river_events','fishing'
				end
			else
				gs 'zz_render','', '','Но тот остается совершенно неподвижным и вы решаете сменить наживку.'
				act 'Надеть наживку': gt'river_events','fishing'
			end
		end
		act 'Закончить':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Вам надоедает и вы отдаете дяде Степе его удочку.'
			if fish > 0:
				gs 'river_events','fishing_end'
			else
				act 'Уйти': minut += 5 & gt'Gadriver'
			end
		end
	else
		*clr & cla
		minut += 5
		manna -= 10
		gs 'stat'
		gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Дядя Степа говорит, что уже собирается домой, поэтому вы с расстроенным видом отдаете ему удочку, понимая, что на сегодня все.'
		if fish > 0:
			gs 'river_events','fishing_end'
		else
			act 'Уйти':minut += 5 & gt'Gadriver'
		end
	end
end
if $ARGS[0] = 'fishing_end':
	act 'Выпустить рыбу':
		*clr & cla
		minut += 5
		fish = 0
		manna = 100
		gs 'stat'
		gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Вы решаете выпустить всю наловленную рыбу, на что мужики только неодобрительно покачивают головой, кидая косые взгляды на улепетывающую на глубину рыбешку.'
		act 'Уйти': minut += 5 & gt'Gadriver'
	end
	act 'Отдать рыбакам':
		*clr & cla
		minut += 5
		fish = 0
		gs 'stat'
		gs 'zz_render',$_str, 'images/gadukino/river/fishers/talk.jpg','Вы отдаете всю наловленную рыбу дяде Степе и тот с напускной неохотой принимает ее, хотя по всему его виду видно, что он вполне доволен таким раскладом.'
		act 'Уйти': minut += 5 & gt'Gadriver'
	end
	act 'Отнести Бонифацию':
		*clr & cla
		minut += 25
		fish -= 1
		manna += 20
		killvar '$_str'
		gs 'stat'
		gs 'zz_render','', 'images/gadukino/cat/feed.jpg','Едва вы входите в дом, как пушистая зверюга тут же оказывается у вас под ногами, чувствуя запах свежей рыбы. Вы угощаете Бонифация одной рыбкой и тот довольно урчит, хрустя косточками.'+iif(fish > 0,' Остальную рыбу вы отдаёте бабушке, и та благодарно вам улыбнулась.','')
		grandmahelp += fish
		fish = 1
		act 'Закончить': gt 'Gadhouse'
	end
	act 'Оставить себе(продукты)':
		*clr & cla
		minut += 5
		eda += fish
		gs 'stat'
		gs 'zz_render',$_str, 'images/gadukino/river/fishers/fish'+iif(fish <= 7,fish,iif(fish <= 10,8,iif(fish <= 20,9,10)))+'.jpg','Вы кладёте <<fish>> рыбин'+iif(fish = 1,'у',iif(fish < 5,'ы',''))+' в пакетик и прощаетесь с рыбаками.'
		fish = 0
		act 'Закончить': minut += 5 & gt'Gadriver'
	end
end