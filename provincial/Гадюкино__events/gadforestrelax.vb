$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs'stat'
gs'time'
if current_clothing > 0:
	if func('zz_clothing','is_skirt') = 0:
		gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax'+iif(bonfire = 0,1,2)+'.jpg'
	else
		gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_ski'+iif(bonfire = 0,1,iif(tanga = 1,2,3))+'1.jpg'
	end
else
	gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_nude1.3.jpg'
end
gs 'zz_render', '', '','Вы устали и решили немного передохнуть.'
if lost >= rand(1,5) and bonfire = 0 and (hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset')):gt 'gadforest_event', 'relax'
if current_clothing > 2 and bonfire = 0:
    act 'Разжечь костер':
        *clr & cla
   	    minut += 10
   	    bonfire = 1
   	    gs 'stat'
   	    gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_bonfire1.jpg','Вы достали спички и решили разжечь костер...'
   	    act 'Далее':gt 'gadforestrelax'
   	end
end
if current_clothing > 2 and bonfire = 1:
	if boletus_hot = 1:
	    act 'Поесть жареных грибов':
	        *clr & cla
	        minut += 15
	        boletus_hot = 0
	        health += 10
	        manna += 20
	        gs'stat'
	        $eat_img = 'qwest/gadukino/forest/boletuscook.jpg'
	        gs 'zz_kitchen_acts', 'eat'
            act 'Далее':gt 'gadforestrelax'
        end
    end
   	act 'Греться у костра':
        *clr & cla
        minut += 60
        son += 3
        health += 10
        frost = 0
        manna += 10
		gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_bonfire'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),2,3)+'.jpg','В течение часа вы сидели молча, глядя на костер.Вы согрелись и отдохнули, наверное пора двигаться дальше.'
   	    act 'Далее':gt 'gadforestrelax'
   	end
	act 'Прилечь вздремнуть у костра':
        *clr & cla
	    if son < 20:
		    son += 10
		    health += 20
		    minut += 180
		    frost = 0
		    manna += 50
		    gs'stat'
	        gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_bonfiresleep.jpg','Вы дремали около 3 часов и прснувшись почувствовали себя бодрее часа.'
	        act 'Проснуться':gt 'gadforestrelax'
	    end
        if son >= 20:
            *clr & cla
		    minut += 5
		    frost = 0
		    gs'stat'
		    gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_bonfiresleep.jpg','Вы пытаетесь уснуть, но у вас ничего не выходит.'
		    act 'Далее':gt 'gadforestrelax'
		end
	end
	if boletus > 0:
	    act 'Пожарить грибы на костре':
	        *clr & cla
	        minut += 30
	        boletus_hot = 1
	        boletus -= 1
	        frost = 0
	        gs'stat'
	        gs 'zz_render', 'Лес', 'qwest/gadukino/forest/boletushot.jpg','Вы пожарили грибы на костре.'
            act 'Далее':gt 'gadforestrelax'
        end
    end
end
if current_clothing >= 0 and bonfire = 0:
   	act 'Посидеть на траве':
        *clr & cla
   	    if temper < 15:health -= 5
        minut += 60
        son += 2
        manna += 10
	    if current_clothing > 0:
			if func('zz_clothing','is_skirt') = 0:
				gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax3.jpg'
			else
				gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_ski'+iif(tanga = 1,4,5)+'.jpg'
			end
		else
			gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_nude1.'+rand(1,2)+'.jpg'
		end
   	    gs 'zz_render', '', '', 'В течение часа вы сидели молча, глядя себе под ноги. Вы немного отдохнули, наверное пора двигаться дальше.'
   	    act 'Далее':gt 'gadforestrelax'
   	end
	act 'Прилечь вздремнуть':
        *clr & cla
	    if son < 24:
		    son += 8
		    if temper < 15:health -= 10
		    minut += 180
		    manna += 20
		    gs'stat'
			if current_clothing > 0:
				if func('zz_clothing','is_skirt') = 0:
					gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_sleep.jpg'
				else
					gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_sleepski'+iif(tanga = 1,'',1)+'.jpg'
				end
			else
				gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_sleepnude1.'+rand(1,2)+'.jpg'
			end
	        gs 'zz_render', '', '','Вы дремали около 3 часов и проснувшись почувствовали себя бодрее.'
	        act 'Проснуться':gt 'gadforestrelax'
	    else
		    minut += 5
		    gs'stat'
		    gs 'zz_render', 'Лес', 'qwest/gadukino/forest/gadforestrelax_nosleep.jpg','Вы пытаетесь уснуть, но у вас ничего не выходит.'
		    act 'Далее':gt 'gadforestrelax'
		end
	end
end
if bilberry > 0:
	act 'Поесть ягод':
	    *clr & cla
	    minut += 30
	    energy += 5
	    water += 10
	    bilberry -= 1
	    health += 5
	    manna += 10
	    gs'stat'
	    gs 'zz_render', 'Лес', 'qwest/gadukino/forest/bilberry.jpg','Вы поели ягод.'
        act 'Далее':gt 'gadforestrelax'
    end
end
act 'Искать дорогу': gt 'gadforestlost','main'