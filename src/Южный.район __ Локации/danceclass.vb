$loc = $curloc
minut += 5
gs 'stat'
frost = 0
gs 'zz_funcs', 'colorize_day'
gs 'stat'
gs 'zz_render','','city/south/danceclass/danceclass','Современный зал с хорошим освещением и зеркалами для развития танцевальных навыков.
Для новичков рекомендуется начинать с обычных клубных танцев, стриптиз и танцы на шесте откроются постепенно с развитием навыков, для последних также необходима физическая сила.
Все занятия - 100 рублей.'
act '<b>Уйти</b>': gt 'south'
if sport = 0 and money >= 100:
	if dance < 100:
		act 'Клубные танцы':
			*clr & cla
			minut += 120
			money -= 100
			body['day_weight'] -= 1
			agil += RAND(1,2)
			sport += 1
			gs 'zz_funcs','sport',3
			dance += RAND(5,15)
			gs 'zz_render','','city/south/danceclass/0/<<rand(0,2)>>','Вы обучались современным клубным танцам, которые очень популярны на дискотеках.'
			act '<b>Уйти</b>': gt 'south'
		end
	end
	if dance > 60 and stripdance < 100:
		act 'Стриптиз':
			*clr & cla
			minut += 120
			money -= 100
			body['day_weight'] -= 1
			agil += RAND(1,2)
			sport += 1
			gs 'zz_funcs','sport',4
			stripdance += rand(3,7)
			gs 'stat'
			gs 'zz_render','','city/south/danceclass/1/<<rand(0,2)>>','Вы обучались страстно раздеваться в танце под музыку.'
			act '<b>Уйти</b>': gt 'south'
		end
	end
	if stripdance > 60 and stren > 60 and poledance < 100:
		act 'Танцы на шесте':
			*clr & cla
			minut += 120
			money -= 100
			body['day_weight'] -= 1
			stren += RAND(1,2)
			vital += RAND(1,2)
			agil += RAND(1,2)
			sport += 1
			poledance += RAND(2,5)
			gs 'zz_funcs','sport',5
			gs 'stat'
			gs 'zz_render','','city/south/danceclass/2/<<rand(0,2)>>','Вы обучались разным акробатическим номерам на шесте.'
			act '<b>Уйти</b>': gt 'south'
		end
	end
end