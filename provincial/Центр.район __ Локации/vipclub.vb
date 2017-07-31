if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	gs'stat'
	'<center><b>Vip-зал</b></center>'
	'<center><img src="images/img/centr/vipclub.jpg"></center>'
	'Вип зона разбита на несколько отдельных комнат, причем дверей нет и проходя мимо можно наблюдать такие сцены, что позавидовали бы даже порно режиссеры.'
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
				cla
				*clr
				girl += 1
				lesbian += 1
				money -= 5000
				dynamic $venerasiak
				'<center><img src="images/img/centr/vip1.jpg"></center>'
				'Вы заказали представление и через пару минут к вам в комнату зашли парень с девушкой. Парень расстегнул штаны и сел на диван, девушка начала делать ему минет. Вы с интересом наблюдали за происходящим.'
				act 'Дальше':
					cla
					*clr
					'<center><img src="images/img/centr/vip2.jpg"></center>'
					'Парень ставит её раком и трахает её вагину, вы раздвигаете ноги и пододвигаете бедра к её лицу, поняв ваше желание девушка опустила голову к вашей киске и начала лизать вас.'
					act 'Далее':
						cla
						*clr
						'<center><img src="images/img/centr/vip3.jpg"></center>'
						'Затем она берет двойной дилдо и вставив один конец в вашу вагину, второй берет в рот и сосет его одновременно трахая вас.'
						act 'Далее':
							cla
							*clr
							horny = 0
							orgasm += 1
							'<center><img src="images/img/centr/vip4.jpg"></center>'
							'Затем она разворачивается и вставляет его в свою киску, вы начинаете активно двигаться стараясь принять дилдо как можно глубже и потереться о её киску, она в это время отсасывает у парня. Вскоре вас накрывает волна оргазма.'
							act 'Далее':
								cla
								*clr
								'<center><img src="images/img/centr/vip5.jpg"></center>'
								'Когда вы кончаете, парень разворачивает её к себе и подняв её зад в верх входит ей в анус. Вы наблюдаете как девушка стонет когда здоровый фалос трахает её в жопу.'
								act 'Далее':
									cla
									*clr
									'<center><img src="images/img/centr/vip6.jpg"></center>'
									'Когда парень насытился её попкой, он положил её на диван и встав сверху начал кончать. Вы высунув язык, наблюдали как сперма вылетает из его члена заливая её рот и грудь.'
									act 'Закончить':gt'vipclub','start'
									act 'Облизать её грудь':
										cla
										*clr
										gs 'zz_funcs', 'cum', 'lip'
										'<center><img src="images/img/centr/vip7.jpg"></center>'
										'Вы принялись слизывать капельки спермы с её груди, стараясь не пропустить ни сантиметра её тела.'
										act 'Закончить':gt'vipclub','start'
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