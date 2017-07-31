$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
new_boletus = 0
new_bilberry = 0
lost = 4
gs'stat'
gs'time'
goswamp = 1
gs 'zz_render', 'Болото', func('zz_funcs','mk_image','qwest/gadukino/Swamp/swamp'),'Лесное болото в которое опасно лезть днем, не то что ночью. Зато в лесу возле болота можно найти много грибов и ягод.**Немного в стороне видна сухая <a href="exec: gt ''swamp_yard'' ">поляна</a> с ветхой избушкой - видимо это охотничий домик.'
if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):
	act 'Войти в лес':
		swamp_cloth = 0
		if goforest > rand(1,100):
			minut += 30
			gt 'gadforest','4'
		else
			gt 'gadforest_event', 'gadforest_lost_start'
		end
    end
end
if hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'):
	act 'Вернуться на окраину леса':swamp_cloth = 0 & hanters = 0 & minut += 150 & gt 'gadforest','1'
else
    act 'Вернуться на окраину леса':swamp_cloth = 0 & hanters = 0 & gt 'gadforest_event', 'forest_road'
end
if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset') and month >= 6 and month <= 9 and boletus + bilberry < 10 and swamp_day ! daystart:
   	act 'Искать ягоды':
   	    *clr & cla
		minut += 30
		temp = RAND(1,2)
		swamp_day = daystart
		if goforest < 20:goforest += rand(0,1)
		new_bilberry += rand(4,5)
		bilberry += new_bilberry
		manna += 5
		gs 'stat'
		gs 'gadforest_event', 'clothes1'
		gs 'zz_render', '', '','Вы в течение получаса бродили по лесу в поисках грибов или ягод и нашли <<new_bilberry>> кг ягод.'
		act 'Далее': gt'swamp'
 	end
end