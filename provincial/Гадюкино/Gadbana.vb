$metka = $ARGS[0]
$loc = $CURLOC
frost = 0
bonusZ = 0
canpar = iif(week = 6 and hour >= 12 and hour < 22,1,0)
gs'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Баня', 'images/qwest/gadukino/bana.jpg','Небольшая баня с низкой печью, баками для воды из нержавейки, низким закопченым потолком, и почерневшим деревянным полком.**На полке лежит бабушкина клизма.'
if prev_clothing > 2: gs 'zz_render', '', '','На вешалке висит ваша <a href="exec: gt ''grandparents_events'',''dress_after_sauna''">одежда</a>'
if mira = 0:
    act 'Выйти во двор':
        if current_clothing > 2 or current_clothing >= 0 and shameless['flag'] > 2:
            minut += 5 & gt'Gaddvor'
	    else
            *clr & cla
		    gs 'zz_render', 'Баня', 'images/qwest/gadukino/Swamp/noundress.jpg','Вы стесняетесь появиться в таком виде во дворе.'
		    act 'Назад':gt'Gadbana'
	    end
    end
    if canpar = 1:
	    if hour >= 12 and hour <= 18:
		    gs 'zz_render', '', '','Баня топится. Где-то часам к семи можно будет париться.'
	    elseif hour > 18 and hour < 22:
		    gs 'zz_render', '', '','В бане можно париться'
		    if banaday ! day:
			    act 'Париться в бане':
				    *clr & cla
				    minut += 105
				    banaday = day
				    gs 'zz_bathroom', 'shower'
				    gs 'zz_funcs', 'skin', '+', 5
                    vidageday += 1
				    health += 10
				    manna += 20
			        if current_clothing > 0:flag_tanga = tanga
			        tanga = 0
			        body['day_weight'] -= 1
				    gs 'zz_clothing', 'redress', 0
				    gs'stat'
				    gs 'zz_render', 'Баня', 'images/qwest/gadukino/par.jpg','Вы парились в бане, после чего окатывались холодной водой и в конце помылись.**<b>Вы чувствуете, что состояние вашей кожи гораздо улучшилось.</b>'
				    act 'Далее':gt'Gadbana'
			    end
		    end
	    end
    else
	    act 'Мыться':
		    *clr & cla
		    gs 'zz_bathroom', 'shower'
		    minut += 15
		    manna += 10
		    body_write = 0
			face_write = 0
	        if current_clothing > 0:flag_tanga = tanga
	        tanga = 0
		    gs 'zz_clothing', 'redress', 0
		    gs'stat'
		    gs 'zz_render', 'Баня', 'images/qwest/gadukino/mit.jpg','Вы начали намыливать свое тело мочалкой. После смыли мыло и помыли волосы шампунем. Смыв шампунь вы стали совершенно чистой.'
		    act 'Далее':gt'Gadbana'
	    end
    end
	if tampon > 0 and mesec > 0 and isprok = 0 and cheatTampon = 0:
		act 'Поменять тампон':
			cla
			*clr
			tampon -= 1
			isprok = 1
			minut += 5
			manna -= 5
			gs 'zz_render', 'Баня', 'images/picb/tampon.jpg','Вы поменяли тампон'
			act 'Закончить': gt'Gadbana'
		end
	end
	if cumlip > 0 or cumface > 0 or mop ! 1:
		act 'Умыться':
			cla
			*clr
			mop = 1
			cumlip = 0
			cumface = 0
			sweat -= 1
			minut += 5
			gs 'zz_render', 'Баня', 'images/pic/facesp.jpg','Вы тщательно умыли  своё лицо.'
			act 'Закончить': gt'Gadbana'
		end
	end
	if dirtbelo > 0: act 'Стирать бельё': gt 'zz_bathroom','stirka'
	if mosolmaz > 0 and mosol > 0:
		act 'Втереть мазь от мозолей в писю 5 мин':
			cla
			minut += 5
			mosolmaz -= 1
			mosol -= 5
			gs 'zz_render', 'Баня', '','Достав тюбик с противомозольным кремом вы втерли его в свою зудящую писю.'
			act 'Выйти из ванной и одеться':gt'Gadbana'
		end
	end
	if cumfrot > 0:
		act 'Оттирать сперму с одежды':
			cla
			*clr
			cumfrot = 0
			minut += 15
			gs 'zz_render', 'Баня', 'images/pic/frotsp.jpg','Вы замыли пятна спермы на своей одежде.'
			act 'Закончить': gt'Gadbana'
		end
	end
    if leghair > 0 and stanok > 0:
	    act 'Брить ноги 15 мин':
		    cla
		    *clr
		    minut = minut + 15
		    leghair = -5
		    horny = horny + 5
		    stanok = stanok - 1
		    gs 'zz_render', 'Баня', 'images/pics/shave.gif','Вы намылили свои ноги и взяли бритву. Ловкими движениями вы сбрили волосы на ногах и смыли пенку для бритья.'
		    act 'Отложить станок':gt'Gadbana'
	    end
    end
    if lobok > 0 and stanok > 0:
	    act 'Брить лобок 15 мин':
		    cla
		    *clr
		    minut = minut + 15
		    lobok = -5
		    horny = horny + 5
		    stanok = stanok - 1
		    gs 'zz_render', 'Баня', 'images/pics/shave3.gif','Вы намылили лобок и взяв бритву ловкими движениями начали брить лобок, сбривая волоски вокруг киски. Наконец с бритьем было покончено и вы смыли пенку с киски.'
		    act 'Отложить станок':gt'Gadbana'
	    end
    end
	if analplug = 1 and analplugin = 1:
		act 'Вынуть анальную пробку (1 мин)':
			*clr & cla
			minut += 1
			analplugIN = 0
			gs 'stat'
			gs 'zz_render', 'Баня','images/pic/analplug.jpg',iif( anus >= 5,'Вы наклонились и привычным движением вынули из себя анальную пробку.','Вы поднатужились и, закусив губу, с громким чпоком вынули из ануса пробку.')
			act 'Закончить': gt'Gadbana'
		end
	elseif analplug = 1 and analplugin = 0 and klismaday = day:
		act 'Вставить анальную пробку (5 мин)':
			*clr & cla
			minut += 5
			analplugIN = 1
			if anus < 10: anus += 1
			cumanus = 0
			gs 'stat'
			gs 'zz_render', 'Баня','images/pic/analplug.jpg', iif( anus >= 5,'Вы наклонились и привычным движением вставили себе анальную пробку.','Вы постарались как можно сильнее расслабить попу и стали вставлять себе пробку. Закусив губу от чувства, что ваша попа вот вот лопнет, вы аккуратно протолкнули толстую часть в свою попу, и наконец-то пробка встала на место.')
			act 'Закончить': gt'Gadbana'
		end
	end
    if klismaday ! day and analplugin = 0:
		act 'Сделать себе клизму 5 мин':
			*clr & cla
			klismaday = day
			if agape < 2:
				minut += 5
				if anus < 5: anus += 1
				cumanus = 0
			end
			gs 'stat'
			gs 'zz_render', 'Баня','common/bathroom/klisma'+iif(agape < 2,'','_pain')+'.jpg', iif(agape < 2,'Вы поставили себе клизму и прочистили кишечник, теперь ваша попка готова к анальному сексу.','Ваша попка слишком болит, чтобы засовывать в неё клизму.')
			act 'Закончить': gt'Gadbana'
		end
    end
	if vibrator = 1 and vibratorIN = 0:
		act 'Вставить вибратор 5 мин':
			cla
			*clr
			minut += 5
			vibratorIN = 1
			if vagina < 6: vagina += 1
			gs 'zz_render', '', 'images/pic/vibrator.jpg','Вы наклонились и вставили себе вибратор в киску.'
			act 'Закончить': gt'Gadbana'
		end
	elseif vibrator = 1 and vibratorIN = 1 and vagina > 0:
		act 'Вынуть вибратор 5 мин':
			cla
			*clr
			minut += 5
			vibratorIN = 0
			gs 'zz_render', 'Баня', 'images/pic/vibrator.jpg','Вы наклонились и вынули вибратор из влагалища.'
			act 'Закончить': gt'Gadbana'
		end
	end
	if pregtest > 0:
		act 'Сделать тест на беременность':
			cla
			pregtest -= 1
			if preg = 1:
				gs 'zz_render', '', '',iif(preg = 1,'Тест показал две полоски. Вы беременны.**Вы думаете, что отец <<$father>>.','Тест показал одну полоску. Всё в порядке.')
			end
			act 'Закончить': gt'Gadbana'
		end
	end
else
	act 'Раздеться':
		*clr & cla
		minut += 10
		horny += 10
	    if current_clothing > 0:flag_tanga = tanga
	    tanga = 0
		gs 'zz_clothing', 'redress', 0
		gs 'stat'
		gs 'zz_render', 'Баня', 'images/qwest/gadukino/MiraBan.jpg','Вы раздеваетесь, краем глаза наблюдая за снимающей трусики Мирославой.'
		act 'Смотреть, как моется Мирослава':
			*clr & cla
			minut += 10
			horny += 15
			gs 'stat'
			gs 'zz_render', 'Баня', 'images/qwest/gadukino/MiraBan1.jpg','Вы, чувствуя, как горячий пар проникает в ваши поры, блаженно наблюдаете за намыливающейся Мирой. Она иногда бросает на вас короткие взгляды и нерешительно улыбается в ответ...'
			act 'Париться':
				*clr & cla
				minut += 105
				gs 'zz_bathroom', 'shower'
                vidageday += 1
				horny += 20
				manna += 20
				health += 10
				gs 'zz_funcs', 'skin', '+', 5
				gs 'stat'
				gs 'zz_render', 'Баня', 'images/qwest/gadukino/MiraBan2.jpg','Наконец Мира заканчивает мыться и за это дело принимаетесь вы. Вскоре вы присоединяетесь к разомлевшей подруге и все остальное время вы паритесь в бане, изредка перекидываясь ничего не значащими фразами...**<b>Вы чувствуете, что состояние вашей кожи гораздо улучшилось.</b>'
				act 'Закончить': mira = 0 & gt 'Gadbana'
			end
		end
	end
end