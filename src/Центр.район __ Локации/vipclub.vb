if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	gs 'stat'
	gs 'zz_render','','images/img/centr/vipclub.jpg'
	gs 'zz_render','','','Вип зона разбита на несколько отдельных комнат, причем дверей нет и проходя мимо можно наблюдать такие сцены, что позавидовали бы даже порно режиссеры.'
	act 'Уйти':gt'club','inside'
	if hour >= 15 or hour <= 3:
		act 'Выпить коктейль':
			*clr
			minut += 15
			alko += 1
			water += 5
			son -= 5
			horny += RAND(10,20)
			gt'vipclub','start'
		end
		if money >= 3000:
			act 'Заказать девушку 3000руб':
				money -= 3000
				picrand = RAND(13,17)
				girl += 1
				lesbian += 1
				dynamic $venerasiak
				xgt'lezbsex','var'
			end
		end
		if money >= 3000:
			act 'Заказать парня 3000руб':
				money -= 3000
				picrand = 38
				guy += 1
				dynamic $venerasiak
				xgt'sex','var'
			end
		end
		if money >= 5000:
			act 'Заказать представление 5000руб':
				*clr & cla
				girl += 1
				lesbian += 1
				money -= 5000
				dynamic $venerasiak
				gs 'zz_render','','images/img/centr/vip1.jpg','Вы заказали представление и через пару минут к вам в комнату зашли парень с девушкой. Парень расстегнул штаны и сел на диван, девушка начала делать ему минет. Вы с интересом наблюдали за происходящим.'
				act 'Дальше':
					*clr & cla
					gs 'zz_render','','images/img/centr/vip2.jpg','Парень ставит её раком и трахает её вагину, вы раздвигаете ноги и пододвигаете бедра к её лицу, поняв ваше желание девушка опустила голову к вашей киске и начала лизать вас.'
					act 'Далее':
						*clr & cla
						gs 'zz_render','','images/img/centr/vip3.jpg','Затем она берет двойной дилдо и вставив один конец в вашу вагину, второй берет в рот и сосет его одновременно трахая вас.'
						act 'Далее':
							*clr & cla
							horny = 0
							orgasm += 1
							gs 'zz_render','','images/img/centr/vip4.jpg','Затем она разворачивается и вставляет его в свою киску, вы начинаете активно двигаться стараясь принять дилдо как можно глубже и потереться о её киску, она в это время отсасывает у парня. Вскоре вас накрывает волна оргазма.'
							act 'Далее':
								*clr & cla
								gs 'zz_render','','images/img/centr/vip5.jpg','Когда вы кончаете, парень разворачивает её к себе и подняв её зад в верх входит ей в анус. Вы наблюдаете как девушка стонет когда здоровый фаллос трахает её в жопу.'
								act 'Далее':
									*clr & cla
									gs 'zz_render','','images/img/centr/vip6.jpg','Когда парень насытился её попкой, он положил её на диван и встав сверху начал кончать. Вы высунув язык, наблюдали как сперма вылетает из его члена заливая её рот и грудь.'
									act 'Закончить':gt'vipclub','start'
									act 'Облизать её грудь':
										*clr & cla
										gs 'zz_funcs', 'cum', 'lip'
										gs 'zz_render','','images/img/centr/vip7.jpg','Вы принялись слизывать капельки спермы с её груди, стараясь не пропустить ни сантиметра её тела.'
										act 'Закончить': gt'vipclub','start'
									end
								end
							end
						end
					end
				end
			end
		end
	end
end