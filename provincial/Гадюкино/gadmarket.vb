*clr & cla
gs 'time'
frost = 0
gs 'zz_render','Магазин','qwest/gadukino/market.jpg',''
if hour = 14 and (week = 6 or week = 7):'В магазине у прилавка ваша <a href="exec: gt ''grandma'' ">бабушка</a> рассматривает товары.'
if money >= 500:
	act 'Купить печенье':
		money -= 500
		pranik += 10
		gs 'stat'
		gs 'zz_render','','','Вы купили печенье.'
	end
end
if money >= 75 and bottle = 0:
	act 'Купить бутылочку воды':
		money -= 75
		bottle = 1
		gs 'stat'
		gs 'zz_render','','','Вы купили бутылочку воды и положили ее в свою сумочку.'
	end
end
if money >= 300:
	act 'Купить тампоны(20шт - 300руб)':
		tampon += 20
		money -= 300
		gs 'stat'
		gs 'zz_render','','','Вы купили упаковку тампонов.'
	end
end
act 'Уйти': minut += 5 & gt 'gadukino'
if grandmaQW >= 60 and pranik = 0 and hour = 14 and (week = 6 or week = 7): gt 'grandparents_events','market'