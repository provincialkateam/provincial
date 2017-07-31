$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs'stat'
gs'time'
gs 'zz_render', 'Затон', func('zz_funcs','mk_image','qwest/gadukino/Swamp/backwater'),'Тихая заводь, с относительно чистой водой, в которой в теплую погоду можно помыться.**Так же, предварительно раздевшись, тут можно постирать одежду, если она грязная или просто отчистить от грязи не раздеваясь.'
if clothesbackwater = 1 and clearclothes = 0:'На берегу лежит ваша <a href="exec: gt ''swamp_events'',''dress_after_backwater''">одежда</a>.'
if current_clothing > 2 and clothesbackwater = 0 and temper >= 20:
	act'Снять одежду':
		*clr & cla
		if hantersKnowSlut > 0 or hanters = 0 or hour < 8 or hour >= 20 or shameless['flag'] > 0:
			!одежда остается на локации
			clothesbackwater = 1
			minut+=5
			flag_tanga = tanga
			tanga = 0
			if hantersRape = 1: hantersRape = 2
			gs 'zz_clothing', 'redress', 0
			gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/backwaterundress'+iif(func('zz_clothing','is_skirt') = 0,'','_ski')+'.jpg','Вы не стеснясь разделись, оставшись в чем мать родила.'
			act'Назад':gt'backwater'
		else
			gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/noundress.jpg','Вы стесняетесь раздеться, а вдруг кто-нибудь увидит?'
			act'Назад':gt'backwater'
		end
	end
    if  current_clothing > 0 and (cumpussy > 0 or cumbelly > 0 or cumass > 0 or cumanus > 0):
	    act 'Подмыться':
		    *clr & cla
		    cumpussy = 0
		    cumbelly = 0
		    cumass = 0
		    cumlip = 0
		    cumface = 0
		    cumanus = 0
		    cumfrot = 0
		    lubonus = 0
		    sweat -= 1
		    minut += 10
		    if hantersRape = 1: hantersRape = 2
		    gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/backwaterswim1.jpg','Вы тщательно смыли сперму в затоне.'
		    act 'Далее':gt 'backwater'
	    end
    end
    if cumfrot > 0 and current_clothing > 0:
	    act 'Оттирать сперму с одежды':
		    *clr & cla
		    cumfrot = 0
		    minut += 5
		    if hantersRape = 1: hantersRape = 2
		    gs'stat'
		    gs 'zz_render', 'Затон', 'pic/frotsp.jpg','Вы замыли пятна спермы на своей одежде.'
		    act 'Закончить':gt 'backwater'
	    end
    end
end
if temper >= 10 and current_clothing > 0:
	act 'Умыться':
		*clr & cla
		mop = 1
		cumlip = 0
		cumface = 0
		face_write = 0
		sweat -= 1
		minut += 5
		if hantersRape = 1: hantersRape = 2
		gs 'zz_render', 'Затон', 'pic/facesp.jpg','Вы тщательно умыли лицо.'
		act 'Далее':gt 'backwater'
	end
end
if dirtyclothes = 1 and current_clothing < 3:
    act 'Стирать одежду':
	    *clr & cla
		if hantersRape = 1: hantersRape = 2
	    minut += 60
	    dirtyclothes = 0
	    if clrbelo > 0: clrbelo -= 1 & dirtbelo += 1
		cumfrot = 0
        $wardrobe[current_clothing+"_"+'condition'] += iif(val(args[1]) >= 0, val(args[1]), 5)
	    gs 'stat'
	    gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/backwaterwash.jpg','Вы разделись и постирали свою грязную одежду. К сожалению в холодной воде она до конца не отстиралась, но хоть так.'
	    act 'Развесить на поляне':
	        *clr & cla
	        minut += 10
	        clearclothes = 3
	        clearclothesH = 0
	        gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/basinwash2.jpg','Вы развесили одежду сушиться на поляне.'
	        act 'Далее':gt'swamp_yard'
        end
	end
end
if dirtyclothes = 1 and current_clothing > 2 and temper >= 10:
    act 'Чистить одежду от грязи':
	    *clr & cla
		if hantersRape = 1: hantersRape = 2
	    minut += 30
	    dirtyclothes = 0
	    if clrbelo > 1: clrbelo -= 1 & dirtbelo += 1
		cumfrot = 0
        $wardrobe[current_clothing+"_"+'condition'] += iif(val(args[1]) >= 0, val(args[1]), 1)
	    gs 'stat'
	    gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/backwaterwash2.jpg','Вы не раздеваясь залезли в воду и как могли стали чистить свою одежду от грязи. К сожалению в холодной воде и не раздеваясь она очень плохо отчистилась, но хоть так.'
	    act 'Далее':gt'swamp_yard'
	end
end
if current_clothing < 3 or swamp_clothes = 1:
    act 'Помыться':
		*clr & cla
		cumpussy = 0
		cumbelly = 0
		cumass = 0
		cumlip = 0
		cumface = 0
		cumanus = 0
		face_write = 0
		body_write = 0
		minut += 30
		sweat = 0
		manna += 10
		if hantersRape = 1: hantersRape = 2
		gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/backwaterswim'+iif(tanga = 0,2,3)+'.jpg','Вы помылись в затоне.'
		act 'Далее':gt 'backwater'
    end
end
act 'Уйти':minut += 5 & gt'swamp_yard'
if hantersRape = 2: gt 'swamp_events', 'backwater_ralax'
if current_clothing = 0 and hantersKnowSlut = 0 and hanters = 1 and hour > 8 and hour < 20 and hantersday ! day: gt 'swamp_events', 'hunter_looks'