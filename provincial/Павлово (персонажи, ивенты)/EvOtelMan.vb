if $args[0] = '' or $args[0] = 'main':
	minut += rand(10,20)
	$npc['0,hotel_sex'] += 1
	gs 'stat'
	gs 'zz_render','','pavlovo/dk/disco/drinking/2/taxi', 'Мужчина подошел к стоящему рядом с клубом таксисту и перемолвившись с ним парой фраз обернулся к вам:**\\\- <<$name[2]>> поехали.///**Вы вместе с мужчиной сели в такси и быстро доехали до отеля. Мужчина повел вас к себе в номер.'
	act 'Идти в номер':
		*clr & cla
		if DPtipe = 1:
			gs 'zz_render','','pavlovo/dk/disco/drinking/2/hotel0', 'Номер оказался вполне приличным. Мужчина подошел к холодильнику и начал выкладывать на стол. Бутылка запотевшего виски, сервелат, банка красной икры, тарелка с фруктами. Выложив все на стол, мужчина подставил вам стул, на который вы присели. Он сел на стул рядом с вами и разлил виски по рюмкам.**\\\- Ну, давайте, <<$name[2]>>, выпьем за знакомство. Я так рад, что встретил такую красивую и замечательную девушку, как вы.///'
			act 'Выпить':
				*clr & cla
				horny += rand(5,20)
				gs 'zz_funcs','alko',2
				gs 'stat'
				gs 'zz_render','','pavlovo/dk/disco/drinking/2/kiss1', 'Вы выпили с мужчиной и он встав со стула подошел к вам. Его губы начали целовать ваши и его руки стали стягивать с вас одежду.'
				gs 'EvOtelMan','hotel_prepeare'
			end
		else
			gs 'zz_render','','pavlovo/dk/disco/drinking/2/kiss.gif', 'Вы вошли в номер и едва мужчина закрыл двери как он впился в вас поцелуем и его руки начали шарить по вашему телу стараясь стянуть с вас одежду.'
			gs 'EvOtelMan','hotel_prepeare'
		end
	end
end
!---
! args[1] - 0 - добровольный секс, 1 - секс за деньги
if $args[0] = 'hotel_sex':
	*clr & cla
	minut += rand(10,30)
	$boy = $bname
	if args[1] = 1: money += 5000
	guy += 1
	dynamic $venerasiak
	gs 'zz_render','','common/sex/sex/'+rand(0,4)+'.gif',iif(args[1]=1,'Вы протянули ладошку и мужчина дрожащими руками вам отсчитал пять тысяч. После этого <<$bname>> повалил вас на кровать и раздвинул ваши ноги.','')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'stat'
	gs 'EvOtelMan','hotel_after_sex'
end
!---
if $args[0] = 'hotel_prepeare':
	if vagina = 0:
		act 'Я еще девочка и берегу девственность':
			*clr & cla
			minut += 5
			gs 'stat'
			if rand(0,2) < 2:
				gs 'zz_render','','pavlovo/dk/disco/drinking/2/hotel5', 'Вы признались мужчине что вы еще девочка и хотели бы сохранить девственность. Он улыбнулся и сказал, что сексом можно заниматься и оставаясь девочкой. <<$bname>> достал член из штанов.'
				act 'Сесть на корточки': gt 'EvOtelMan','hotel_bj'
				if dom > 0 and alko < 6: act 'Даже и не надейся': gt 'EvOtelMan','bj_prepeare'
			else
				gs 'zz_render','','pavlovo/dk/disco/drinking/2/hotel0', '<<$bname>> заинтересовался:**\\\- Правда? Ты девственница? Я дам тебе пятихатку, если ты покажешь мне свою киску.///'
				if dom > 0 and alko < 6: act 'Даже и не надейся': gt 'EvOtelMan','bj_prepeare'
				act 'Показать':
					*clr & cla
					money += 500
					gs 'stat'
					gs 'zz_render','','pavlovo/dk/disco/drinking/2/kiska', 'Вы разделись и показали свою киску мужчине. Тот с интересом рассмотрел вас:**\\\- Классно. Слушай, я дам тебе пять штук, если ты позволишь мне стать твоим первым.///'
					act 'Согласиться': gs 'EvOtelMan','hotel_sex', 1
					if dom > 0 and alko < 6: act 'Нет, я собираюсь остаться девственницей до брака': gt 'EvOtelMan','bj_prepeare'
					act 'Уйти': gt 'vokzalG'
				end
			end
		end
	else
		if dom >= 0 and alko < 6:
			act 'Разводить на бабло':
				*clr & cla
				minut += rand(3,5)
				dom -= 1
				gs 'stat'
				gs 'zz_render','','pavlovo/dk/disco/drinking/2/hotel0', 'Вы посмотрели на часы:\\- Ну мы неплохо провели время, но пожалуй я пойду. А то мамка ругаться будет, не даст потом денег на обеды.//**<<$bname>> улыбнулся вам:\\\- Я дам тебе штуку, этого хватит тебе на обеды?//'
				act 'Согласиться': money += 1000 & gt 'EvOtelMan','hotel_bj', 1
				act 'Минет - это максимум': gt 'EvOtelMan','bj_prepeare'
			end
		end
		act 'Заняться сексом': gt 'EvOtelMan','hotel_bj', 1
	end
end
!---
if $args[0] = 'hotel_after_sex':
	act 'Приводить себя в порядок':
		*clr & cla
		protect = 0
		minut += rand(10,20)
		gs 'zz_bathroom', 'clean_me'
		gs 'stat'
		gs 'zz_render','','pavlovo/dk/disco/drinking/2/hotel1.gif','Вы начали приводить себя в порядок. <<$bname>> потянулся и завалился на кровать.**\\\- Это было классно!///'
		act 'Уйти': gt 'vokzalG'
	end
end
!---
if $args[0] = 'bj_prepeare':
	*clr & cla
	gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg', 'Вы рассмеялись и отказали мужчине. <<$bname>> почесал голову:**\\\- Ну тогда, может, пососешь? Я дам тебе пятихатку.///'
	act 'Давай':
		*clr & cla
		money += 500
		gs 'stat'
		gs 'zz_render','','pavlovo/dk/disco/drinking/2/hotel6.jpg', 'Вы протянули ладошку и мужчина дал вам пятьсот рублей.'
		act 'Сесть на корточки': gt 'EvOtelMan','hotel_bj'
	end
	act 'Уйти': gt 'vokzalG'
end
!---
! args[1] - 0 - только минет, 1 - секс
if $args[0] = 'hotel_bj':
	*clr & cla
	$boy = $bname
	dick = rand(12,20)
	silavag = rand(0,2)
	bj += 1
	guy += 1
	dom -= 1
	minut += rand(5,10)
	dynamic $venerasiak
	gs 'stat'
	gs 'zz_render','','common/sex/bj/4.gif','Вы сели на корточки перед мужчиной и взяли его член рукой. Немного подвигав кожицу на члене вы облизнули головку. Ваш ловкий язычок начал ласкать горячий и твердый член мужчины. <<$bname>> сказал:**\\\- <<$name[2]>>, я так скоро кончу.///'
	act 'Сосать':
		*clr & cla
		gs 'zz_funcs','cum','lip'
		minut += rand(5,10)
		gs 'stat'
		gs 'zz_render','','common/sex/bj/'+rand(0,3)+'.gif','Вы обхватили губами член и начали его сосать старательно обхватывая твердый ствол своими <<$liptalk2>>. <<$bname>> стонет и вы чувствуете как вам в рот ударяет струя спермы.'
		act 'Сосать глотая сперму':
			*clr & cla
			swallow += 1
			water -= 10
			minut += rand(3,10)
			gs 'stat'
			gs 'zz_render','','common/sex/bj_cum/'+rand(0,2)+'.gif','Вы продолжили сосать кончающий член и сглатывать сперму попадающую вам в рот. Спермы было так много, что вы не успеваете все проглотить и она стекает из вашего рта по члену. Наконец <<$bname>> прекращает кончать и вы вытаскиваете член из своего пахнущего спермой рта. Во рту гадко от вкуса кончи, облизнувшись вы понимаете, что ваши <<$liptalk3>> влажные от спермы.'
			gs 'EvOtelMan','hotel_after_sex'
		end
		act 'Вынуть изо рта':
			*clr & cla
			gs 'zz_funcs','cum','face'
			minut += rand(3,10)
			gs 'stat'
			gs 'zz_render','','common/sex/bj_cum/'+rand(3,4)+'.gif','Вы вынули член изо рта и струя спермы тут же хлестнула вам по лицу. Вы зажмурили глаза боясь, что сперма попадет вам в глаза и почувствовали как еще одна струя горячей кончи приземлилась вам на лицо.'
			gs 'EvOtelMan','hotel_after_sex'
		end
	end
	if args[1] = 1:
		act 'Подставить киску': gs 'EvOtelMan','hotel_sex'
		act 'Подставить попку':
			*clr & cla
			minut += rand(10,20)
			gs 'stat'
			gs 'zz_render','','common/sex/anal/'+rand(0,4)+'.gif'
			gs 'zz_dynamic_sex', 'anal_start', 'dick', 1
			gs 'zz_dynamic_sex', 'anal', 'dick'
			gs 'zz_dynamic_sex', 'anal_cum'
			gs 'EvOtelMan','hotel_after_sex'
		end
	end
end