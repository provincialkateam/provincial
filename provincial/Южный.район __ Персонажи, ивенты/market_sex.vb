if $ARGS[0] = 'sex_start':
	minut += 15
	if rustam_plan > 4000:rustam_plan -= 1000
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/sex_start'+iif(args[1] = 0,1,2)+'.jpg','Вы зашли в контейнер, служащий складом и бытовкой.'
	act 'Выпивать':
		*clr & cla
		minut += 30
		gs 'zz_funcs', 'alko', 6
		energy = 24
		water = 24
		body['day_weight'] += 2
		cumlip = 0
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/city/south/south_market/market_work/sex_start'+iif(args[1] = 1,3,iif(horny < 70,4,5))+'.jpg',iif(args[1] = 0,'Рустам накрыл','Кавказцы, громко гомоня и смеясь, накрыли')+' стол, поставив бутылку коньяка c нехитрой закусью, и '+iif(palevorin < 2,'пригласил','пригласили')+' вас сесть на стул.<br>Вы быстро захмелели, выпивая вместе с '+iif(palevorin = 0,'хозяином','ними')+', и он'+iif(palevorin = 0,'','и')+' приступил'+iif(palevorin = 0,'','и ')+'к более активным действиям. '+iif(palevorin = 0,'Он начал вас вас обнимать, целуя ваши губы, и лаская ваши груди через одежду.'+iif(horny >= 70,' Расслабившись, вы начали отвечать на его поцелуи, поглаживая рукой в районе ширинки',''),'Они начали похотливо вас обнимать и лапать ваше тело, стягивая одежду')+'.'
		if args[1] = 0:
			act 'Сосать': gt'market_sex','oral'
			if horny < 70 and market_sex < 20:act 'Сопротивляться':gt'market_sex','refuse'
		else
			act 'Сосать': gt'market_sex','group'
		end
	end
end
if $ARGS[0] = 'refuse':
	*clr & cla
	minut += 5
	cumlip = 0
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/refuse.jpg',iif(args[1] > 0,'Вы, с красным от стыда лицом, отрицательно поматали головой'+iif(args[1] = 1,'стёрли остатки спермы с губ',''),'Вы начали сопротивляться, отталкивая Рустама руками. Вырвавшись, наконец, из его объятий, вы поправили одежду и прическу')+', и молча отправились к выходу из подсобки.**<do>- Вай, '+replace($name,'е','э')+', нэ хорошо поступаешь! Я вэдь и обидыться могу.</do>'
	act 'Передумать':
		if args[1] = 1:
			gang += 1
			gt'market_sex','oral',1
		elseif args[1] = 2:
			gang += 1
			gt'market_sex','vaginal',1
		elseif args[1] = 3:
			gang += 1
			gt'market_sex','anal',1
		else
			gt'market_sex','oral'
		end
	end
	act 'Уйти':minut += 15 & rustam_plan += 2000 & gt'street'
end
if $ARGS[0] = 'oral':
	*clr & cla
	minut += iif(args[1] = 1,15,5)
	market_sex += iif(args[1] = 1,iif(market_sex < 50,2,0),iif(market_sex < 20,1,0))
	if args[1] = 1:
		if abdulasex = 0:abdulasex = 1 & guy += 1
		if hasansex = 0:hasansex = 1 & guy += 1
		bj += 2
		gang += 1
		gs 'zz_funcs', 'cum', 'lip'
		money += 1000
	else
		bj += 1
		if rustamsex = 0:rustamsex = 1 & guy += 1
		$boy = 'Рустам'
		dick = 18
		silavag = 0
	end
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/oral'+iif(args[1] = 0,rand(1,3),4)+'.jpg',iif(args[1] = 1,'Обернувшись, вы кивнули головой, в знак своего согласия. Абдула и Хасан тут же вынули свои члены, и подставили их к вашему рту. Вы принялись сосать сразу у обоих, меняя их члены у себя во рту.<br>Через некоторое время, Абдула и Хасан стали кончать, наполняя ваш рот своей спермой, а вы глотали и слизывали её до тех пор, пока их члены не стали опадать.<br>После того как парни кончили, к вам подошел довольный Рустам, и протянул 1000 рублей премиальных','Вы сели перед хозяином на колени и достали его член')+'.'
	if args[1] = 0:
		gs 'zz_dynamic_sex', 'bj'
		''
		if market_sex < 20:
			act 'Сосать дальше':gt'market_sex','swallow'
			if vgape < 2:act 'Отдаться':gt'market_sex','vaginal'
			if agape < 2:act 'Подставить попу':gt'market_sex','anal'
		else
			temp = rand(1,3)
			if temp = 1:act 'Сосать дальше':gt'market_sex','swallow'
			if temp = 2:act 'Отдаться':gt'market_sex','vaginal'
			if temp = 3:act 'Подставить попу':gt'market_sex','anal'
		end
	else
		act 'Идти домой':minut += 15 & gt'street'
	end
end
if $ARGS[0] = 'swallow':
	*clr & cla
	minut += 5
	temp = RAND(1,100)
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/swallow'+rand(1,3)+'.jpg',''
	gs 'zz_dynamic_sex', 'swallow'
	''
	if temp < 95 and palevorin = 0 or temp < 70 and palevorin >= 1:
		money += 500
		gs 'zz_render', '', '','После секса хозяин выписал вам премию в количестве 500 рублей, и вы разошлись каждый по своим делам.'
		act 'Идти домой':minut += 15 & gt'street'
	else
		gs 'zz_render', '', '','Вы уже закончили делать минет и слизывали остатки спермы с члена Рустама, когда дверь открылась и в каморку вошло двое. В них узнали Абдулу и Хасана, владельцев соседних палаток.<br>'+iif(palevorin = 0,'Вы замерли от удивления и стыда, что вас застукали с полным ртом спермы облизывающей красную елду. ','')+'Мужики обрадовались и загоготали:**<do>- Вах, '+replace($name[2],'е','э')+', ми тоже хотим, нам отсосёшь?</do>**<do>- '+replace($name[2],'е','э')+', помоги моим братьям'+iif(palevorin = 0,', а то без женщины совсэм дыкие стали','')+', -</do> сказал расслабленый Рустам, роясь у себя в бумажнике.<do> - А за это двойную прэмию от мэня получишь!</do>'
		if palevorin = 0:palevorin = 1
		act 'Отказаться':gt'market_sex','refuse',1
		act 'Согласиться':gt'market_sex','oral',1
	end
end
if $ARGS[0] = 'vaginal':
	*clr & cla
	pose = 1
	minut += 5
	market_sex += iif(args[1] = 0,0,iif(market_sex < 50,1,0))
	$boy = iif(args[1] = 0,'Рустам',iif(args[1] = 1,'Абдула','Хасан'))
	dick = iif(args[1] = 0,18,iif(args[1] = 1,19,20))
	silavag = iif(args[1] = 0,0,iif(args[1] = 1,1,2))
	if args[1] > 0: bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/vaginal'+iif(args[1] = 0,rand(1,3),rand(4,6))+'.jpg','<<$boy>> раздел вас и '+iif(args[1] = 0,'оперев руками о стену','поставив раком')+', начал пристраиваться к вашей <<$vaginatipe3>> киске.'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	if args[1] > 0:
		gs 'zz_render', '', '',iif(args[1] = 1,'Хасан тут же достал свой член и стал хлопать им по вашему лицу, пока вы не взяли у него в рот','Абдула в это время обошел вас спереди и поднёс свой член к вашим губам')+'.'
		gs 'zz_dynamic_sex', 'bj'
	end
	if args[1] = 0:
		act 'Взять в рот': gt'market_sex','swallow'
		act 'Стоять раком': gt'market_sex','sexcum'
	elseif args[1] = 1:
		act 'Дать Хасану':gt'market_sex','vaginal',2
	else
		act 'Стоять раком':gt'market_sex','sexcum',1
	end
end
if $ARGS[0] = 'sexcum':
	*clr & cla
	minut += 5
	temp = RAND(1,100)
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/sexcum'+iif(args[1] = 0,1,2)+'.jpg',iif(args[1] = 0,'','Так вас жарили два парня, а хозяин сидел рядом, и смотрел на происходящее.')
	gs 'zz_dynamic_sex', 'sex_cum'
	if args[1] = 0:
		if temp < 95 and palevorin = 0 or temp < 70 and palevorin >= 1:
			money += 1000
			gs 'zz_render', '', '','После секса Рустам выписал вам премию, в количестве 1000 рублей, и вы разошлись каждый по своим делам.'
			act 'Идти домой':minut += 15 & gt'street'
		else
			gs 'zz_render', '', '','В это время дверь со скрипом открылась и в каморку вошло двое. Вы узнали Абдулу и Хасана, владельцев соседних палаток.<br>'+iif(palevorin = 0,'Вы замерли от удивления и стыда, что вас застукали, стонущей на елде, с голой жопой. ','')+'Мужики обрадовались и загоготали:**<do>- Вах, '+replace($name[2],'е','э')+', ми тоже хотим, нам дашь?</do>**<do>- '+replace($name[2],'е','э')+', помоги моим братьям'+iif(palevorin = 0,', а то без женщины совсэм дыкие стали','')+', -</do> сказал расслабленый Рустам, роясь у себя в бумажнике.<do> - А за это двойную прэмию от мэня получишь!</do>'
			if palevorin = 0:palevorin = 1
			act 'Отказаться':gt'market_sex','refuse',2
			act 'Согласиться':gang += 1 & gt'market_sex','vaginal',1
		end
	else
		money += 2000
		gs 'zz_render', '', '','Второй парень не заставил себя долго ждать.'
		gs 'zz_dynamic_sex', 'swallow'
		gs 'zz_render', '', '','После того как парни кончили к вам подошел хозяин и с улыбкой протянул 2000 рублей премиальных.'
		act 'Идти домой':minut += 15 & gt'street'
	end
end
if $ARGS[0] = 'anal':
	*clr & cla
	pose = 1
	minut += 5
	market_sex += iif(args[1] = 0,0,iif(market_sex < 50,1,0))
	$boy = iif(args[1] = 0,'Рустам',iif(args[1] = 1,'Абдула','Хасан'))
	dick = iif(args[1] = 0,18,iif(args[1] = 1,19,20))
	silavag = iif(args[1] = 0,0,iif(args[1] = 1,1,2))
	if args[1] > 0: bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/anal'+iif(args[1] = 0,rand(1,3),rand(4,6))+'.jpg','<<$boy>> раздел вас и поставив раком, и начал пристраиваться к вашей <<$anustipe3>> попке.'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	if args[1] > 0:
		gs 'zz_render', '', '',iif(args[1] = 1,'Хасан тут же достал свой член и стал хлопать им по вашему лицу, пока вы не взяли у него в рот','Абдула в это время обошел вас спереди и поднёс свой член к вашим губам')+'.'
		gs 'zz_dynamic_sex', 'bj'
	end
	''
	if args[1] = 0:
		act 'Стоять раком':gt'market_sex','analcum'
	elseif args[1] = 1:
		act 'Дать Хасану':gt'market_sex','anal',2
	else
		act 'Стоять раком':gt'market_sex','analcum',1
	end
end
if $ARGS[0] = 'analcum':
	*clr & cla
	minut += 5
	temp = RAND(1,100)
	gs'stat'
	gs 'zz_funcs', 'cum', 'anus'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/analcum'+iif(args[1] = 0,1,2)+'.jpg',iif(args[1] = 0,'Через некоторое время <<$boy>> застонал и вы почувствовали как вашу попу наполняет тепло.','Так вас и жарили два парня, а хозяин сидел рядом, и смотрел на происходящее.<br>Через некоторое время <<$boy>> застонал и вы почувствовали как вашу попу наполняет тепло.')
	if args[1] = 0:
		if temp < 95 and palevorin = 0 or temp < 70 and palevorin >= 1:
			money += 1500
			gs 'zz_render', '', '','После секса Рустам выписал вам премию, в количестве 1500 рублей, и вы разошлись каждый по своим делам.'
			act 'Идти домой':minut += 15 & gt'street'
		else
			gs 'zz_render', '', '','В это время дверь со скрипом открылась и в каморку вошло двое. Вы узнали Абдулу и Хасана, владельцев соседних палаток.<br>'+iif(palevorin = 0,'Вы замерли от удивления и стыда, что вас застукали голой, да еще и с членом в заднице. ','')+'Мужики обрадовались и загоготали:**<do>- Вах, '+replace($name[2],'е','э')+', ми тоже хотим, нам дашь?</do>**- '+replace($name[2],'е','э')+', помоги моим братьям'+iif(palevorin = 0,', а то без женщины совсэм дыкие стали','')+', -</do> сказал расслабленый Рустам, роясь у себя в бумажнике.<do> - А за это двойную прэмию от мэня получишь!</do>'
			if palevorin = 0:palevorin = 1
			act 'Отказаться':gt'market_sex','refuse',3
			act 'Согласиться':gang += 1 & gt'market_sex','anal',1
		end
	else
		money += 3000
		gs 'zz_render', '', '','Второй парень не заставил себя долго ждать.'
		gs 'zz_dynamic_sex', 'swallow'
		gs 'zz_render', '', '','После того как парни кончили к вам подошел хозяин и с улыбкой протянул 3000 рублей премиальных.'
		act 'Идти домой':minut += 15 & gt'street'
	end
end
if $ARGS[0] = 'group':
	*clr & cla
	minut += 10
	market_sex += 3
	bj += 3
	gang += 1
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/group'+rand(1,3)+'.jpg','Вы присели на корточки, а парни, обступив вас со всех сторон, вывалили из штанов свои члены. Вы принялись усердно сосать, стараясь не обделять своим вниманием ни один из предоставленых вам агрегатов. Парни в это время весело переговарились на своём языке. Видимо обсуждая вас.'
	act 'Далее':
		*clr & cla
		$boy = 'Рустам'
		dick = 18
		silavag = 0
		temp = rand(1,2)
		$boy2 = iif(temp = 1,'Абдула','Хасан')
		dick2 = iif($boy2 = 'Абдула',19,20)
		temp = rand(1,3)
		if temp = 1:
			gs 'market_sex','group_vaginal'
		elseif temp = 2:
			gs 'market_sex','group_anal'
		else
			gs 'market_sex','group_dp'
		end
		act 'Далее':
			*clr & cla
			$boy = 'Абдула'
			dick = 19
			silavag = 1
			temp = rand(1,3)
			$boy2 = iif(temp = 1,'Рустам','Хасан')
			dick2 = iif($boy2 = 'Рустам',18,20)
			if temp = 1:
				gs 'market_sex','group_vaginal'
			elseif temp = 2:
				gs 'market_sex','group_anal'
			else
				gs 'market_sex','group_dp'
			end
			act 'Далее':
				*clr & cla
				$boy = 'Хасан'
				dick = 20
				silavag = 1
				temp = rand(1,3)
				$boy2 = iif(temp = 1,'Абдула','Рустам')
				dick2 = iif($boy2 = 'Абдула',19,18)
				if temp = 1:
					gs 'market_sex','group_vaginal'
				elseif temp = 2:
					gs 'market_sex','group_anal'
				else
					gs 'market_sex','group_dp'
				end
				act 'Далее':
					*clr & cla
					minut += 5
					temp = RAND(1,100)
					money += market_money
					gs'stat'
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_funcs', 'cum', 'belly'
					gs 'zz_render', '', 'images/city/south/south_market/market_work/group_swallow'+rand(1,3)+'.jpg','Наконец парни выдохлись, и посадив вас на пол, начали кончать, заливая ваше лицо своей спермой, и попадая на тело.<br>После Абдула и Хасан оделись у ушли, а Рустам выписал вам <<market_money>> рублей примиальных и завалился отдыхать.'
					act 'Идти домой':market_money = 0 & minut += 15 & gt'street'
				end
			end
		end
	end
end
if $ARGS[0] = 'group_vaginal':
	minut += 5
	market_money += 500
	pose = 0
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/group_vaginal'+rand(1,4)+'.jpg',''
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_render', '', '','Одновременно с этим вы не забывали про двух других парней, поочередно погружая в свой рот их члены...'
end
if $ARGS[0] = 'group_anal':
	minut += 5
	market_money += 1000
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/group_anal'+rand(1,4)+'.jpg',''
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	gs 'zz_render', '', '','А двое других парней поочередно пользовались вашим ротиком...'
end
if $ARGS[0] = 'group_dp':
	minut += 5
	market_money += 1500
	gs'stat'
	gs 'zz_render', '', 'images/city/south/south_market/market_work/group_dp'+rand(1,3)+'.jpg'
	gs 'zz_dynamic_sex', 'dp_start'
	gs 'zz_dynamic_sex', 'double_penetration'
	gs 'zz_render', '', '','Оставшийся парень во всю пользовался вашим ртом, погружая в него свой член...'
end