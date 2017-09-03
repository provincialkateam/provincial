if $ARGS[0] = '1':
	*clr & cla
	gs 'stat'
	gs 'time'
	$_str = 'Болото'
	gs 'zz_render', $_str, func('zz_funcs','mk_image','qwest/gadukino/Swamp/gadforestlostswamp'), 'Вы вышли к болоту, за ним виднеется какая-то избушка. Можно вернуться назад в лес или попробовать пройти к ней, но хватит ли вам сил и ловкости преодолеть эту грязь?'
	act 'Вернуться назад в лес':gt 'gadforestlost','main'
	act 'Идти через трясину':
		*clr & cla
		minut += 10
		sweat += 1
		i = RAND(1,100)
		gs 'stat'
		if current_clothing > 2:
			if func('zz_clothing','is_skirt') = 0:
				gs 'zz_render', $_str, 'qwest/gadukino/Swamp/goswamp.jpg'
			else
				gs 'zz_render', $_str, 'qwest/gadukino/Swamp/goswamp_ski.jpg'
			end
		else
			gs 'zz_render', $_str, 'qwest/gadukino/Swamp/goswamp_nude0.'+rand(1,3)+'.jpg'
		end
		gs 'zz_render', '', '', 'Вы вошли в болото и почувствовали, что ваши ноги начинает засасывать в грязь...'
		act 'Идти дальше':
			if stren + agil > i:
				killvar '$_str'
				gt 'swamp_yard'
			elseif stren + agil < i and i < 10:
				gt'gameover',10
			else
				gt 'gadforestswamp','2'
			end
		end
	end
end
if $ARGS[0] = '2':
	*clr & cla
	hapri = 0
	if mop > 1: mop = 0 & vidageday -= 1
	!одежда изнашивается
	if dirtyclothes = 0 and current_clothing > 2: dirtyclothes = 1 & gs 'zz_clothing', 'decrease_condition', 10
	gs'stat'
	gs'time'
	gs 'zz_render', $_str, 'qwest/gadukino/Swamp/panicswamp.jpg', 'Вы застряли посреди болота."Во попала!", - в панике думаете вы - "Что же делать?". '
	act 'Позвать на помощь':
		*clr & cla
		minut += 10
		if sweat < 10: sweat += 1
		gs 'stat'
		gs 'zz_render', $_str, 'qwest/gadukino/Swamp/gadforestlosthelp.jpg', 'Вы совершенно выбились из сил и стали кричать и звать на помощь, вдруг в домике есть люди...'
		act 'Ждать':
			*clr & cla
			minut += 10
			if rand(1,iif(week > 5,3,5)) = 1:
				hanters = 1
				hanterhelp = 1
				gs 'stat'
				gs 'zz_render', $_str, 'qwest/gadukino/Swamp/handshelp.jpg', 'Вы услышали мужские голоса и стали кричать громче. Голоса раздавались все ближе и вот наконец чьи-то сильные руки схватили вас и потащили в сторону берега.'
				killvar '$_str'
				act 'Далее':gt 'swamp_yard'
			else
				gs 'zz_render', $_str, 'qwest/gadukino/Swamp/panicswamp.jpg', 'Никто не откликается на ваш зов, похоже тут вы совершенно одни.'
				act 'Далее':gt 'gadforestswamp','2'
			end
		end
	end
	act 'Пробовать вернуться к лесу':
		*clr & cla
		minut += 10
		stren += 1
		agil += 1
		if sweat < 10:sweat += 3
		i = RAND(1,100)
		gs 'stat'
		gs 'gadforestswamp','swampclothes'
		gs 'zz_render', '', '', 'Вы решили не испытывать больше судьбу и повернуть назад...'
		act 'Идти':
			if stren + agil > i:
				gt 'gadforestswamp','1'
			elseif stren + agil < i and i <= 20:
				gt'gameover',10
			else
				gt 'gadforestswamp','2'
			end
		end
	end
	act 'Пробовать идти дальше к домику':
		*clr & cla
		minut += 10
		stren += 1
		agil += 1
		if sweat < 10:sweat += 3
		i = RAND(1,100)
		gs 'stat'
		gs 'gadforestswamp','swampclothes'
		gs 'zz_render', '', '', 'Вы посчитали, что к домику все же добраться предпочтительнее и стали продвигаться дальше...'
		act 'Идти':
			if stren + agil > i:
				killvar '$_str'
				gt 'swamp_yard'
			elseif stren + agil < i and i <= 30:
				gt'gameover',10
			else
				gt 'gadforestswamp','2'
			end
		end
 	end
end
if $ARGS[0] = 'swampclothes':
	if current_clothing > 2:
		if func('zz_clothing','is_skirt') = 0:
			gs 'zz_render', $_str, 'qwest/gadukino/Swamp/goswamp1.jpg'
		else
			gs 'zz_render', $_str, 'qwest/gadukino/Swamp/goswamp_ski1.jpg'
		end
	else
		gs 'zz_render', $_str, 'qwest/gadukino/Swamp/goswamp_nude0.'+rand(4,5)+'.jpg'
	end
end