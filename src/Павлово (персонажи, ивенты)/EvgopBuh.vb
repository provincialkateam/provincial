﻿if $args[0] = '' or $args[0] = 'main':
	minut += 5
	gs 'stat'
	gs 'zz_render','','pavlovo/dk/dk_night'
	if func('zz_reputation','get') < 3:
		gs 'zz_render','','','Вы вышли с парнем из клуба он повел вас за клуб. Там уже бухали два его кореша. На земле стояла бутылка водки и пластиковые стаканчики.**\\\- Я <<$bname>>, это - <<$bname2>> и <<$bname3>>.///**\\- Света.//**<<$bname2>> взял бутылку и пластиковый стаканчик. Он пьяными, неуверенными движениями налил водки в стаканчик, после чего протянул стаканчик вам.'
		act 'Выпить':
			*clr & cla
			minut += rand(2,5)
			gs 'zz_funcs','alko',2
			gs 'stat'
			gs 'zz_render','','pavlovo/dk/dk_night','Вы выпили водки и у вас захватило дух от этой сивухи. <<$bname3>> достал из кармана конфетку:**\\\- На Светик, закуси.///**Вы быстро засунули конфетку в рот стараясь перебить отвратительный вкус сивухи.'
			if alko < 3: act 'Уйти обратно в клуб': gt 'gdkin'
			act 'Остаться с парнями':
				*clr & cla
				minut += rand(2,5)
				horny += rand(5,10)
				gs 'stat'
				gs 'zz_render','','pavlovo/dk/dk_night','Вы остались с парнями. <<$bname>> подошел к вам и обнял вас за талию.**\\\- Светик, ты классная чувиха.///**Его руки начали гладить вашу попку и сжимать ее.'
				gs 'EvgopBuh','disgust'
				if dom > 0 and alko < 6 and horny <= 75:
					act 'Шептать "Не надо"':
						*clr & cla
						minut += rand(2,5)
						horny += rand(5,10)
						gs 'stat'
						gs 'zz_render','','images/nigma/gor/publ.pre0,'+rand(0,1),'<<$bname>> посадил вас на пенек рядом с поляной где пьют парни. Он расстегнул ширинку и достал свой стоячий член. <<$bname>> сказал вам в пол голоса:**\\\- Ну же детка, не стесняйся, смотри какая вкусная карамелька, можешь облизнуть...///'
						act 'Уйти обратно в клуб': gt 'gdkin'
						gs 'EvgopBuh','disgust'
						act 'Сидеть на пеньке':
							*clr & cla
							minut += rand(2,5)
							horny += rand(5,10)
							bj += 1
							guy += 1
							gs 'stat'
							gs 'zz_render','','images/qwest/alter/Ev/gop2.jpg','Вас охватила апатия и вы сидели на пеньке смотря на член. <<$bname>> взяв член рукой провел вам им по губам. Вы открыли рот, что бы возмутиться и тут же его член хлопнул своей багровой головкой по вашему мокрому языку. Еще секунда и его член уже был в вашем рту.'
							act 'Сосать':
								*clr & cla
								minut += rand(3,7)
								horny += rand(5,10)
								gs 'stat'
								gs 'zz_render','','common/sex/public_bj/'+rand(0,4)+'.gif','Сами того не понимая вы начали сосать твердый член парня обхватывая его своими <<$liptalk2>>. Вы закрыли глаза стараясь не думать о том, что же вы делаете. Твердый и горячий член скользил между ваших губ, заполняя ваш рот до горла.'
								act 'Дальше':
									*clr & cla
									minut += rand(3,7)
									gs 'zz_funcs','cum','lip'
									water -= 1
									gs 'zz_reputation','set',2
									gs 'stat'
									gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif','Внезапно вам в рот из члена вылетела горячая струя спермы. Ваш рот оказался наполненным остро пахнущей, теплой кончей. <<$bname>> достал член у вас изо рта и вытер его о ваши <<$liptalk2>>. После чего он убрал член в штаны.**\\\- Пацаны, можете пользоваться вафлершей, я ее уже отхуесосил.///'
									gs 'EvgopBuh','disgust',1
									act 'Выплюнуть сперму':
										*clr & cla
										gs 'zz_render','','common/sex/double_bj/'+rand(0,4),'Вы наклонились и выплюнули сперму себе под ноги. К вам подошли <<$bname2>> и <<$bname3>>, они достали из штанов члены и подставили их вам к лицу.'
										gs 'EvgopBuh','double_bj'
									end
									act 'Проглотить сперму':
										*clr & cla
										swallow += 1
										gs 'zz_render','','common/sex/double_bj/'+rand(0,4),'Вы проглотили сперму, ощущая ее мерзкий вкус в своем рту. К вам подошли <<$bname2>> и <<$bname3>>, они достали из штанов члены и подставили их вам к лицу.'
										gs 'EvgopBuh','double_bj'
									end
								end
							end
						end
					end
				end
				act 'Молчать':
					*clr & cla
					minut += rand(3,7)
					horny += rand(5,10)
					gs 'stat'
					gs 'zz_render','','pavlovo/dk/dk_night','<<$bname>> стал стаскивать с вас одежду, вы пьяно мотались в его руках и вдруг ощутили дуновение ветра на своей обнаженной попе.'
					act 'Дальше':
						*clr & cla
						minut += rand(3,7)
						horny += rand(5,10)
						sex += 1
						$boy = $bname
						guy += 1
						pose = 1
						dynamic $venerasiak
						gs 'stat'
						gs 'zz_render','','common/sex/public_sex/'+rand(0,2)+'.gif','<<$bname>> нагнул вас и вы схватились руками за что то, что бы не упасть.'
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
						gs 'zz_render','','','Парень убрал член в штаны и сказал:**\\\- Пацаны, можете пользоваться давалкой.///'
						gs 'EvgopBuh','disgust'
						act 'Молчать':
							*clr & cla
							minut += rand(3,7)
							horny += rand(5,10)
							sex += 1
							guy += 1
							bj += 1
							gs 'zz_funcs','cum','lip'
							$boy = $bname3
							dynamic $venerasiak
							gs 'stat'
							gs 'zz_render','','common/sex/dp/'+rand(0,4), '<<$bname2>> подошел к вам и вы увидели его обнаженный член, вы постарались хоть что-то сделать, но он схватил вас за волосы и тут же в вашем рту оказался его член. <<$bname3>> подошел к вам сзади и вы почувствовали его руки на ваших бедрах.'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							gs 'zz_render','','','Вы ощутили как вам в рот начинает кончать член и <<$bname2>> еще крепче держит вас за волосы.'
							gs 'EvgopBuh','finish',1
						end
					end
				end
			end
		end
	else
		gs 'zz_render','','','Вы вышли с парнем из клуба он повел вас за клуб. Там уже бухали два его кореша. На земле стояла бутылка водки и пластиковые стаканчики. Парень сказал:**\\\- Я <<$bname>>, это - <<$bname2>> и <<$bname3>>. Я кстати в курсе, что ты Света местная <<$gnikname>>. Короче не тяни резину, бери на клыка!///'
		gs 'EvgopBuh','triple_bj'
		if dom > 0:
			act 'Отказаться':
				*clr & cla
				manna -= rand(30,50)
				gs 'zz_render','','','Вы отказались и парень рассвирепел:**\\\- Чего? Ты охуела шалава? Да я тебе сейчас еблище разобью!///**После этих слов он сильно ударил вам в живот кулаком. Вы задохнулись от боли и согнулись пополам.**\\\- Ну что тварь? Передумала? Или тебя отпиздеть а потом бутылку в жопу затолкать?///'
				gs 'EvgopBuh','triple_bj'
				if dom >= 10:
					act 'Послать его':
						*clr & cla
						manna -= rand(50,70)
						gs 'zz_reputation','set',2
						gs 'stat'
						gs 'zz_render','','','Вы плюнули парни под ноги прожигая его взглядом:**\\- Пошел ты на хуй мальчик.//**Тут же в голове зазвенело и вы поняли что лежите на земле.**Парень в бешенстве подскочил к вам, но бить не решился:**\\\- Пошла на хуй отсюда, шалава.///'
						act 'Уйти': gt 'gdk'
					end
				end
			end
		end
	end
end
! Светка возмущается:
! args[1]: 0 - до минета, 1 - после минета
if $args[0] = 'disgust':
	if dom > 10 and alko < 3 and horny <= 90:
		act 'Возмутиться':
			*clr & cla
			minut += rand(2,5)
			if args[1] = 0: dom += 1
			gs 'stat'
			gs 'zz_render','','',iif(args[1] = 0,'Вы возмутились рявкнув на борзого пацана:**\\- Ты охуел что ли?//**<<$bname>> даже отдернул руки от вас. Вы отошли от него на шаг:**\\\- Вот и держи свое хозяйство при себе!///','Вы возмущенно харкнули спермой под ноги пацану:**\\- Ты охуел что ли?//**Пацан начал хорохориться:**\\\- Заткнись вафлерша.///**Но вы встали с пенька и обматерили пацанов.')
			act 'Уйти обратно в клуб': gt 'gdkin'
		end
	end
end
! args[1]: 0 - падение репутации до 3, 1 - до 4
if $args[0] = 'finish':
	act 'Дальше':
		*clr & cla
		minut += rand(3,7)
		cumfrot += 1
		manna -= rand(20,30)
		if args[1] = 0:
			if func('zz_reputation','get') < 3: gs 'zz_reputation','set',3
		else
			if func('zz_reputation','get') < 4: gs 'zz_reputation','set',4
		end
		gs 'zz_render','','images/qwest/alter/Ev/gop8','Ваши ноги устали и подгибаются, вы не выдерживаете и садитесь на землю, из вашего рта стекает тонкой, тянущейся струей сперма. Вы вяло замечаете, что часть спермы попала вам на одежду. Парни разлили водку по стаканчикам и выпили еще раз. Один хмыкнул глядя на вас:**\\\- Классную соску ты нашел. Не плохо она пошлепала своими губами мне по елде.///**Второй засмеялся:**\\\- Посмотри, шлюшка до сих пор в себя придти не может.///**Третий сказал задумчиво:**\\\- Надо дать объяву пацанам, чтоб не зашкварились о шалаву.///'
		gs 'stat'
		act 'Уйти': gt 'gdk'
	end
end
if $args[0] = 'double_bj':
	act 'Открыть рот':
		*clr & cla
		minut += rand(2,5)
		horny += rand(5,10)
		bj += 2
		guy += 1
		gs 'stat'
		gs 'zz_render','','common/sex/double_bj/'+rand(0,4),'Вы покорно открыли рот и парни сразу же вставили вам оба члена в рот, растянув его до предела. Вы начали отсасывать два твердых и горячих члена по очереди.'
		act 'Дальше':
			*clr & cla
			minut += rand(2,5)
			horny += rand(5,10)
			gs 'zz_funcs','cum','lip'
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/Ev/gop7','Вдруг один из парней начал кончать вам в рот, следом тут же начал кончать второй. Один из парней схватил вас за голову не давая вам убрать лицо. Парни накончали вам полный рот и достали свои члены из вашего рта. Оставив вас сидящей на пеньке с полным ртом спермы.'
			gs 'EvgopBuh','finish'
		end
	end
end
if $args[0] = 'triple_bj':
	act 'Сесть на корточки':
		*clr & cla
		minut += rand(3,7)
		horny += rand(5,10)
		bj += 3
		guy += 3
		dom -= 1
		gs 'stat'
		gs 'zz_render', '', 'common/sex/triple_bj/'+rand(0,3)+'.gif','Вы покорно сели на корточки и парни достали свои члены. Вы обхватили два хуя своими пальчиками и начали дрочить их. Третий парень тут же хлопнул вам по <<$liptalk2>> членом. Вы разжали губы и вобрали член в свой горячий и влажный рот. Вы стали сосать члены по очереди и ласкать руками те хуи которые не оказались в вашем горячем ротике. Наконец парни уже стали готовы кончить.'
		act 'Закрыть глаза':
			*clr & cla
			minut += rand(2,5)
			horny += rand(5,10)
			gs 'zz_funcs','cum','face'
			gs 'stat'
			gs 'zz_render','','common/sex/triple_bj/trio_cum.gif','Вы закрыли глаза и подставили свое лицо. Практически тут же вы ощутили как горячие струи спермы попадают вам на лицо. Вскоре парни иссякли полностью покрыв ваше лицо спермой.'
			act 'Уйти': gt 'gdk'
		end
	end
end