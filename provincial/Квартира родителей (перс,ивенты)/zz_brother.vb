if $args[0] = 'main':
	brotherAge = age - 1
	brotherDick = 14
	gs 'npc_editor','get_npc_profile',39
	if week =7 and $npc['38,turnirWin'] = 0 and family_trip = 0 and $npc['39,qwPornoFootball'] > 40 and hour >= 8 and hour <= 9: act '<B>Спросить у брата куда он собирается</B>' : gt 'zz_brother','incest_event'
	if $npc['38,qwKolka'] = 8 and $npc['38,qwKolkaTel'] = 0: act '<B>Спросить телефон Миши</B>' : gt 'zz_brother','incest_event_Kolka'
	act '<B>Отойти</B>': gt $loc, $metka
	if $brother['location'] = 'sitrPar' and (hour > 22 or hour < 7):
		gs 'zz_brother', 'get_off'
	exit
	end
	if current_clothing <= 2:
		gs 'zz_brother', 'check_naked'
		exit
	end
	if cumlip + cumface + cumfrot + cumass + cumbelly > 0:
		gs 'zz_brother', 'cum_reaction'
		exit
	end
	if alko > 0:
		gs 'drunk_reaction','brother'
		exit
	end
	if $brother['location'] = 'gschool': gt 'zz_brother', 'football'
!	if $brother['location'] = 'sitrPar' and $npc['39,qwKolkaPrince'] = 1: gs 'KolkaPrince', 'main'
	gs 'KolkaPrince', 'main'
	if brother_pirsF = 0 and pirsF > 0 and hour >= 21: gs 'zz_brother', 'check_piercing'
	!homework
	if school['vacation'] = 0 and week < 6 and brother_homework ! day and hour >= 18 and hour <= 20 and brotherAge < 18: gs 'zz_brother', 'homework_init'
	if pregTalkBrother = 0 and pregnancy > 90: gs 'zz_brother', 'check_pregnant' & exit
	if spanked >= 25 and current_clothing = 0 and tanga = 0: gs 'zz_brother', 'spank_reaction' & exit
	if $npc['39,qwKolkaPrince'] >= 2: gs 'KolkaPrince', 'KolkaStats'
end
if $args[0] = 'get_off':
	if $npc['39,relation'] < 40:
		gs 'npc_editor','change_rep','-', 39
		gs 'zz_render', '', '', '<do>- Отвали, дура, я спать хочу!</do>'
	else
		gs 'zz_render', '', '', '<do>- <<$name[1]>>, не мешай спать!</do>'
	end
	if school['vacation'] = 0 and (week < 5 or week = 7) and brotherAge < 18: gs 'zz_render', '', '', '<do>- Мне с утра вообще-то в школу!</do>'
end
if $args[0] = 'check_naked':
	if current_clothing = 1:
		if $npc['39,sex'] < 1:
			gs 'zz_render','','','Ваш брат ехидно комментирует коротенькое полотенце на вас:<do>- <<$name[2]>>, ты уверена что это не полотенце для рук?</do>'
		else
			gs 'zz_render','','','Ваш брат ехидно комментирует коротенькое полотенце на вас:<do>- Сестричка, ты специально для меня выбрала полотенце покороче?</do>'
		end
	elseif current_clothing = 0 and lobok > 2 and tanga = 0:
		gs 'zz_render','','','<do>- <<$name[2]>>, ты не думала сбрить эти свои заросли? Или хоть подстичь свои джунгли?</do>'
	elseif current_clothing = 0:
		if $npc['39,sex'] >= 1:
			'<do><<$name[2]>>, у тебя потрясающее тело!</do>'
		else
			gs 'zz_render','','','<do>Классно выглядишь. Ты что, нудизмом решила заняться?</do>'
			gs 'npc_editor','change_rep','+', 39
		end
	end
end
if $args[0] = 'cum_reaction':
	if cumface + cumlip > 0 :
		if brotherknowslut < 1: brotherknowslut = 1
		gs 'npc_editor','change_rep','-', 39
		gs 'zz_render','','','<do>- Вымой лицо, смотреть противно на всю эту кончу.</do>'
		exit
	end
	if cumfrot > 0 and current_clothing > 2:
		gs 'zz_render','','','<do>- У тебя вся одежда перепачкалась. Постирай, или мать попроси.</do>'
		exit
	end
	if cumbelly > 0 and current_clothing = 0:
		if brotherknowslut < 1: brotherknowslut = 1
		gs 'npc_editor','change_rep','-', 39
		gs 'zz_render','','','<do>- Иди помойся, дура - смотреть противно на всю эту кончу!</do>'
		exit
	end
	if cumass > 0 and current_clothing <= 2 and tanga = 0:
		gs 'zz_render','','','<do>- Иди помойся - а то вся жопа в конче! И барахло своё постирай обшликанное.</do>'
		if brotherknowslut < 1: brotherknowslut = 1
		gs 'npc_editor','change_rep','-', 39
		exit
	end
end
if $args[0] = 'spank_reaction':
	if $npc['39,relation'] < 40:
		gs 'zz_render', '', '', '<do>- Чё, дуреха, получила по заслугам?</do> - не скрывая радости выдал Колька.'
	else
		gs 'zz_render', '', '', '<do>- Что у тебя с попой? Наказали за что-то?</do>'
	end
end
if $args[0] = 'check_pregnant':
	if current_clothing <= 2 or (current_clothing > 2 and pregnancy > 150):
		gs 'zz_render', '', '', 'Брат удивлённо смотрит на ваш животик: <do>- <<$name[2]>>, ты залетела что-ли?</do>'
		pregTalkBrother = 1
	end
end
if $args[0] = 'football':
	gs 'npc_editor','get_npc_profile',39
	if $npc['39,relation'] < 40:
		gs 'zz_render','','','Брат хмурится: <do>Отвали от меня, придурошная!</do>'
		act '<b>Уйти</b>': gt 'gschool'
		exit
	else
		if sunWeather >= 0 and month > 2 and month < 12:
			gs 'zz_render','','','Брат приветственно машет рукой: <do>- <<$name[2]>>, давай к нам! Может, и с нами поиграешь?</do>'
			act '<b>Уйти</b>': gt 'gschool'
			if func('zz_clothing','get_group') = 3:
				act 'Играть с пацанами в футбол':
					*clr & cla
					minut += 60
					gs 'npc_editor','change_rep','+', 39
					agil += RAND(0,2)
					speed += RAND(0,2)
					sweat += 3
					beg += RAND(2,5)
					gs 'stat'
					gs 'zz_render','','images/qwest/alter/ev2/football3.jpg','Вы в течение часа носитесь по полю, гоняя мячик с братом и его друзьями Мишкой и Жендосом.'
					act '...': gs 'zz_brother','gt_porn_view'
				end
			end
			act 'Смотреть как пацаны играют':
				*clr & cla
				minut += 60
				gs 'npc_editor','change_rep','+', 39
				gs 'zz_render','','images/qwest/alter/ev2/football'+iif(month<3 or month=12,4,RAND(1,2))+'.jpg','Вы целый час сидите на лавочке, наблюдая за тем, как ребята играют в футбол.'
				act '...': gs 'zz_brother','gt_porn_view'
			end
		else
			gs 'zz_brother','gt_porn_view'
		end
	end
end
if $args[0] = 'gt_porn_view':
	if $npc['39,qwPornoFootball'] = 0:
		*clr & cla
		gs 'zz_render','','images/pavlovo/family/brother/boys_talk.jpg','Пацаны шушукаются между собой, обсуждая что-то.'
		act 'Вы тут о чем говорите?':
			cla
			act 'Отойти': gt $loc, $metka
			gs 'zz_render','','','Пацаны замялись: <do>- Да так, ни о чём...</do>'
			if dom > 0:
				gs 'zz_render','','','Вы немного надавили на них:<br><dh>- Вы что как малышня? Секретики какие-то у вас! - ехидно ухмыльнулись вы.</dh><br>Один из пацанов почти сразу "раскололся":<br><do>- Да мы, это, того... мы хотим сходить порнуху поглядеть...</do>'
				act 'Возьмите меня':
					cla
					gs 'zz_render','','','- А мне можно с вами, а? - спрашиваете вы - мне тоже интересно! Пацаны, немного посмущавшись и перетёрши тихонько промеж собой, соглашаются.'
					act 'Идти смотреть порнуху': minut += rand(5,15) & gt 'porn_view'
				end
			end
		end
	else
		*clr & cla
		gs 'zz_render','','images/pavlovo/family/brother/boys_talk.jpg','Пацаны, пошушукавшись промеж собой, предлагают вам: '+iif($npc['39,qwPornoFootball']<5,'<do><<$name[2]>>, пойдешь порнушку смотреть?</do>','<do>Да ну его, этот футбол, пойдем лучше порнушку смотреть!</do>')
		act 'Идти смотреть порнуху':
			minut += rand(5,15)
			gt 'porn_view'
		end
		act 'Уйти': gt $loc, $metka
	end
end
if $args[0] = 'check_piercing':
	if current_clothing = 0:
		! автозапуск если голышом
		*clr & cla
		minut += 1
		brother_pirsF = 1
		if $npc['39,relation'] < 40:
			gs 'zz_render','','','<do>- Ты это всем подряд показываешь, шлюха пришибленная?</do> - заходясь от смеха еле выдавил с себя Колька.'
		elseif $npc['39,relation'] >= 40 and $npc['39,relation'] < 60:
			gs 'zz_render','','','<do>- Не понимаю, зачем так издеваться над собой?</do>- Колька заметил ваши проколотые соски.'
		else
			horny += 3
			gs 'npc_editor','change_rep','+', 39
			if $npc['39,sex'] = 0:
				gs 'zz_render','','','<do>- Тебе идёт</do>, - брат, подмигнув, кивает на ваши проколотые соски.'
			else
				gs 'zz_render','','','<do>- Какая прелесть!</do> - Колька играет с вашими проколотыми сосками.'
			end
		end
		act '<B>Отойти</B>': gt $loc, $metka
	else
		act 'Показать пирсинг сосков':
			*clr & cla
			minut += 1
			brother_pirsF = 1
			gs 'zz_render','','images/qwest/alter/placer/9vh2v.jpg','<dh>- Смотри, что у меня есть</dh>, - вы подходите к Кольке поближе и оголяете грудь, показывая брату украшение в вашем соске,- <dh>не стесняйся, можешь потрогать</dh>.'
			if $npc['39,relation'] < 40:
				cla
				gs 'zz_render','','','<do>- Ты это всем подряд показываешь, шлюха пришибленная?</do> - заходясь от смеха еле выдавил с себя Колька.'
				act '<B>Отойти</B>': gt $loc, $metka
				exit
			end
			horny += 3
			gs 'npc_editor','change_rep','+', 39
			gs 'zz_render','','','Брат, ошарашеный вашим предложением, нерешительно дотрагивается к пирсингу в вашем соске, вызывая непроизвольный стон.'
			if $npc['39,sex'] = 0:
				gs 'zz_render','','','Колька резко убирает руку и извиняется за свою грубость. Вам ничего не остаётся, как уверить, что это не его вина и спрятать грудь.'
			else
				gs 'zz_render','','','Видя, что манипуляции с соском доставляют вам удовольствие, Колька начинает настойчивей играть с пирсингом, иногда сжимая выставленную грудь. Наигравшись, он отпускает вашу грудь, и говорит, что подобные украшения ему очень нравятся.'
			end
			horny += 10
			gs 'stat'
			act '<B>Отойти</B>': gt $loc, $metka
		end
	end
end
if $args[0] = 'homework_init':
	if $npc['39,qwPornoFootball'] >= 7 or $npc['39,qwBrotherNude'] >= 2:
		! автозапуск
		*clr & cla
		gs 'npc_editor','get_npc_profile',39
		gs 'zz_render','','','<do>- <<$name[2]>>, поможешь мне с домашкой, а то у меня тут задачка не получается?</do>'
		act 'Конечно помогу': gt 'zz_brother', 'homework'
		act 'Потом, сейчас не могу':
			cla
			gs 'zz_render','','','<dh>- Извини, я сейчас занята. Потом помогу.</dh>'
			act 'Отойти': gt $loc, $metka
		end
	else
		act 'Предложить помощь с домашкой':
			cla
			gs 'zz_render','','','<dh>- Коль, с уроками помощь не нужна?</dh>'
			if $npc['39,relation'] < 40:
				gs 'zz_render','','','<do>Сам разберусь, отвали.</do>'
				act 'Отойти': gt $loc, $metka
			else
				gs 'npc_editor','change_rep','+', 39
				gs 'zz_render','','','<do>Да, не помешала бы.</do>'
				gt 'zz_brother', 'homework'
			end
		end
	end
end
if $args[0] = 'homework':
	*clr & cla
	brother_homework = day
	minut += RAND(50,70)
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/homework1.jpg','Вы около часа помогали брату усвоить новый материал и разобраться в нем.'
	gs 'npc_editor','change_rep','+', 39
	act 'Закончить': gt 'sitrPar'
	if $npc['39,qwBrotherNude'] = 2:
		*clr & cla
		gs 'zz_render','','images/qwest/alter/ev2/brother/homework_touch.gif','Пока вы объясняли материал, Колька неожиданно начал гладить вашу ножку своей ладонью. Вы замерли от удивления, не зная что делать.'
		act 'Игнорировать и продолжить':
			cla
			$npc['39,qwBrotherNude'] = 3
			gs 'npc_editor','change_rep','+', 39
			horny += RAND(5,10)
			gs 'zz_render','','','Вы решаете продолжить заниматься домашкой, стараясь не обращать внимание на Колькину ладонь у вас на бедре. Поняв, что вы не против, он продолжает вас гладить чуть-чуть не дотягиваясь до вашей промежности.'
			act 'Закончить': gt $loc, $metka
		end
		act 'Убрать руку и продолжить':
			cla
			horny += RAND(1,5)
			dom += 1
			gs 'zz_render','','','Вы решаете убрать его руку и продолжить заниматься домашкой. Колька, покраснев как рак, усердно начинает делать вид, что решает задачки, стараясь не смотреть вам в глаза.'
			act 'Закончить': gt $loc, $metka
		end
		exit
	elseif $npc['39,qwPornoFootball'] >= 7 or $npc['39,qwBrotherNude'] >= 3:
		horny += RAND(5,10)
		cla
		gs 'zz_render','','','Пока вы объясняли материал, Колька опять начал гладить вашу ножку.'
		act 'Игнорировать и продолжить':
			*clr & cla
			gs 'npc_editor','change_rep','+', 39
			horny += rand(5,10)
			minut += rand(5,10)
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/ev2/brother/homework_touch.gif','Вы, не прерываясь, продолжаете заниматься домашкой, стараясь не обращать внимание на Колькину ладонь у вас на ноге. Зная, что вы абсолютно не против, он продолжает приятно вас гладить, от чего вы чувствуете теплый прилив возбуждения.'
			act 'Закончить': gt $loc, $metka
			if hour = 21:
				cla
				! новогодняя вставка, одноразовый ивент
				if month = 12 and day >= 25 and day <= 29 and brother_newyear_qw = 0: gt 'brother_events','happy_ny'
				! ---
				gs 'zz_render','','','Вы закончили с домашкой, когда уже родители пошли спать, оставив вас с братцем самих. Колька c красным от возбуждения лицом спрашивает: <do>- <<$name[2]>>, может немного пошалим?</do>'
				act 'Отказаться': gt $loc, $metka
				if $npc['39,sex'] < 4:
					act iif($npc['39,qwBrotherNude'] = 3,'В смысле?','Ну давай...'):
						gt 'zz_brother', 'show_body'
					end
				else
					gs 'zz_brother', 'brotherSexStart'
				end
			end
		end
		act 'Убрать руку и продолжить':
			*clr & cla
			horny += RAND(1,5)
			gs 'npc_editor','change_rep','-', 39
			gs 'zz_render','','images/qwest/alter/ev2/brother/homework1.jpg','<dh>- Не надо, вдруг родители увидят</dh> - шепчете вы, убирая его руку с ножки.<br><do>- Тю...</do> - буркнул себе под нос Колька и с гримассой обиды на лице продолжил заниматься.'
			act 'Закончить': gt $loc, $metka
		end
		exit
	end
end
if $args[0] = 'show_body':
	gs 'zz_render','','images/qwest/alter/ev2/brother/homework1.jpg','<do>- <<$name[2]>>, у меня скоро контрольная по анатомии будет, а я всё никак выучить её не могу. Не поможешь мне?</do><br><dh>- В смысле?...</dh> - в недоумении переспрашиваете вы.<br><do>- Ну там...</do> - брат немного замешкался - <do>посмотреть как у девочек всё там устроено, объяснить...</do>'
	if $npc['39,qwBrotherNude'] <= 3:
		cla
		if (sex + bj + hj + anal + kuni) = 0 and $npc['39,qwPornoFootball'] < 12:
			act 'Ты что совсем офигел?':
				cla
				gs 'zz_render','','','<dh>- Коля, ты ничего не путаешь? Я ведь твоя сестра! Ты что совсем офигел, как ты себе это представляешь?</dh><br><do>- Ну да, ты права. Глупость ляпнул...</do>'
				act 'Закончить': gt $loc, $metka
			end
		else
			if dom > -30: act 'Отказаться': gt $loc, $metka
		end
		act 'Хм...':
			cla
			$npc['39,qwBrotherNude'] = 4
			if ($npc['39,qwPornoFootball'] >= 12 and (sex + bj + hj + anal + kuni) = 0) or ($npc['39,qwPornoFootball'] >= 7 and (sex + bj + hj + anal + kuni) > 0):
				gs 'zz_render','','','<dh>- Как будто ты не видел</dh> - хихикнули вы, вспоминая совместные просмотры порно с компанией Колькиных друганов.<br><do>- Ну это не то...</do> - начал мямлить он.'
			else
				gs 'zz_render','','','<dh>- И как ты себе это представляешь? Мне перед тобой раздеться?</dh><br><do>- Ну... Было бы неплохо еще и рассказать</do> - добавил он.'
				gs 'zz_render','','','<dh>- А в книжке у тебя что картинок нет?</dh><br><do>- Есть, но там всё так коряво описано, а учительница пропустила этот урок, мол "вы и так все знаете", а контрольную ей напиши</do> - начал он вас уговаривать с разгоряченным лицом.'
			end
			gs 'zz_render','','','<dh>- Ладно, помогу тебе, но только если никому не скажешь. Договорились? Я серьёзно: "никому" - значит вообще никому!</dh> - строго говорите вы.<br><do>- Слово пионера!</do><br><dh>- Ты не пионер...</dh><br><do>- А... ну тогда просто честное слово!</do><br><dh>- Ладно, я поняла. Не продолжай.</dh>'
			act 'Раздеваться': gt 'zz_brother', 'brother_voyeur_ev4'
		end
		exit
	else
		if dom > -30: act 'Отказаться': gt $loc, $metka
		act 'Раздеваться': gt 'zz_brother', 'brother_voyeur_ev4'
		exit
	end
end
if $ARGS[0] = 'brother_go_away':
	*clr & cla
	horny += RAND(5,10)
	minut += RAND(5,10)
	gs 'npc_editor','change_rep','-', 39, 10
	dom += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/b13.jpg','Вы прикрываете двумя руками свою киску и выкрикиваете брату:<br><dh>- Коля, какого хрена!? Быстро свалил отсюда, мелюзга!</dh><br>Пойманный на горячем, Колька хлопает дверью и убегает прочь. Вы спокойно заканчиваете мыться и начинаете вытираться.'
	act '...': gt 'zz_bathroom','start'
end
if $ARGS[0] = 'brother_voyeur_end':
	*clr & cla
	horny += RAND(5,10)
	minut += RAND(5,10)
	gs 'npc_editor','change_rep','+', 39
	manna += 10
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/b_end'+RAND(1,2)+'.jpg','Смущённо, исподтишка глядя на брата, вы берёте полотенце и оборачиваете вокруг вашего разгорячённого, распаренного тела.<br>Вас бьёт дрожь от осознания неправильности и наказуемости ваших действий. Колька аккуратно прикрывает дверь и на цыпочках уходит.'
	act 'Выйти из ванной': gt 'zz_bathroom','start'
end
if $ARGS[0] = 'brother_voyeur_ev1':
	*clr & cla
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'npc_editor','change_rep','+', 39
	if $npc['39,qwBrotherNude'] < 1: $npc['39,qwBrotherNude'] = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/b'+RAND(2,7)+'.jpg','Вы продолжаете мыться как ни в чём ни бывало, изредка поглядывая на своего зрителя. Тщательно мылите свое тело, особое внимание уделяя груди и киске, от чего чувствуете нарастающее возбуждение внизу живота.'
	act 'Вытираться': gt 'zz_brother','brother_voyeur_end'
	if horny >= 40: act 'Поиграть с грудью': gt 'zz_brother','brother_voyeur_ev2'
end
if $ARGS[0] = 'brother_voyeur_ev2':
	*clr & cla
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'npc_editor','change_rep','+', 39
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/c'+RAND(1,7)+'.jpg','Вы поворачиваетесь лицом к двери, давая Кольке лучший обзор, и эротично мнете свои сисечки <<body[''tits'']>> размера. Сжимаете пальчиками сосочек, поливая из другой руки душем свою грудь, пристально глядя при этом на брата. Вы на миг прикрываете глаза и погружаетесь в фантазии, от чего с ваших непроизвально срывается легкий стон.'
	act 'Вытираться': gt 'zz_brother','brother_voyeur_end'
	if horny >= 90: act 'Направить воду на киску': gt 'zz_brother','brother_voyeur_ev3'
end
if $ARGS[0] = 'brother_voyeur_ev3':
	*clr & cla
	if $npc['39,qwBrotherNude'] <= 1: $npc['39,qwBrotherNude'] = 2
	minut += RAND(5,10)
	gs 'npc_editor','change_rep','+', 39
	horny = 0
	orgasm += 1
	mastr += 1
	manna += 15
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/d'+RAND(1,2)+'.jpg','Вы расставляете ножки пошире и направляете воду из шланга на свою киску. От нахлынувшего удовольствия вы начинаете тяжело дышать и тихонько постанывать. Вскоре вы почувствовали, как теплая волна охватывает всё ваше тело, и вы начали содрогаться в оргазме.'
	act 'Вытираться': gt 'zz_brother', 'brother_voyeur_end'
end
if $ARGS[0] = 'brother_voyeur_ev4':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/ev2/brother/f1.jpg',''
	if $npc['39,qwBrotherNude'] = 4:
		gs 'zz_render','','','Вы проверяете закрыта ли дверь в зал, затем молча быстро снимаете с себя всю одежду и усаживаетесь в кресло рядом с диваном, немного смущенно прикрывая свою грудь руками:<br><dh>- Ну что "пионер", что тебе объяснять?</dh> - спрашиваете вы, глядя на офигевшего от реальности происходящего брата.<br><do>- Охренеть...</do> - единственное, что смог выдавить из себя Колька, глазея на вас выпученными глазами.'
		gs 'zz_render','','','<dh>- Коля, ты просто полюбоваться захотел или тебе действительно нужна помощь?</dh> - строго говорите вы, замечая увеличивающийся бугорок у него в штанах.<br><do>- Нет-нет, нужна-нужна!</do><br><dh>- Так может, быстрее начнем - быстрее закончим?</dh><br><do>- Эм-да, хорошо...</do>'
		act 'Далее': gt 'zz_brother','brother_voyeur_ev5'
	elseif $npc['39,qwBrotherNude'] > 4:
		gs 'zz_render','','','Вы проверяете закрыта ли дверь в зал, затем молча быстро снимаете с себя всю одежду и усаживаетесь в кресло рядом с диваном:<br><do>- Ну что, повторение - мать учения?</do> - спрашивает брат.<br><dh>- Вроде того</dh> - с улыбкой отвечаете вы.'
		act 'Далее': gt 'zz_brother','brother_voyeur_ev5'
	end
end
if $ARGS[0] = 'brother_voyeur_ev5':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'stat'
	if brother_body_show = 0: brother_body_show = 1 & brother_anus_mem = anpic
	$_str = 'Вы разворачиваетесь попкой к брату и наклоняетесь, опираясь локтями на спинку кресла, открывая ему вид на <<$vaginatipe2>> киску и <<$anustipe>> анус'+iif(analplugIN=1,', в который вставлена анальная пробка:',':')
	$_str += '<br><do>-'+iif($npc['39,qwBrotherNude'] = 4,'Блин, офигеть','Крутой вид!')+'</do> - после небольшой паузы говорит брат.'
	if analplugIN = 1:
		if brother_saw_analplug = 0:
			brother_saw_analplug = 1
			$_str += '<br><do>- Ого, а это еще зачем?</do> - в недоумении заёрзав, спрашивает Коля, явно имея ввиду секс-игрушку в вашей попе.'
			$_str += '<br><dh>- Мне так нравится.</dh>'
			$_str += '<br><do>- Вау! Серьёзно?</do>'
			$_str += '<br><dh>- Ну да...</dh> - смутившись, отвечаете вы.'
			$_str += '<br><do>- И как ощущения?</do>'
			$_str += '<br><dh>- Хочешь попробовать?</dh>'
			$_str += '<br><do>- Эм... Нет, спасибо. А, всем девчонкам такие вещи нравятся?</do>'
			$_str += '<br><dh>- Не знаю... Я у всех не спрашивала</dh> - краснея, отвечаете вы.'
		else
			$_str += '<br><do>- Опять ты с этой штукой в заднице?</do> - спрашивает Коля, явно имея ввиду секс-игрушку в вашей попе.'
			$_str += '<br><dh>- Ага...</dh> - кокетливо отвечаете вы.'
			if $npc['39,sex'] = 1:
				$_str += '<br><do>- Может лучше туда что-нибудь другое вставлять?</do> - спрашивает он, явно намекая.'
				$_str += '<br><dh>- В другой раз, Коля</dh>'
				$_str += '<br><do>- Облом...</do>'
			else
				$_str += '<br><do>- Извращенка!</do>'
				$_str += '<br><dh>- Ну разве что совсем чуть-чуть</dh>'
			end
		end
	else
		if brother_anus_mem < anpic:
			brother_anus_mem = anpic
			$_str += '<br><do>- <<$name[2]>>, мне кажется или у тебя очко шире стало?</do>'
			$_str += '<br><dh>- Чего?</dh>'
			$_str += '<br><do>- Я серьезно, раньше меньше было!</do>'
			$_str += '<br><dh>- Не выдумывай, ничего там не изменилось и не надо на него пялиться!</dh>'
			if $npc['39,qwPornoFootball'] < 22:
				$_str += '<br><do>- Изменилось, точно говорю! Раньше меньше было! <<$name[2]>>, ты даешь в жопу?</do>'
				$_str += '<br><dh>- Охренел? Нет конечно!</dh> - краснеете вы.'
				$_str += '<br><do>- Точно даёшь!</do>'
				$_str += '<br><dh>- Коля, иди нахрен!</dh>'
				$_str += '<br><do>- Ладно-ладно, молчу...</do>'
			end
		end
	end
	$_str += '<br><dh>- Ты так и будешь таращиться?</dh>'
	$_str += '<br><do>- Ладно, давай начнём.</do>'
	$_str += '<br>Вы начинаете объяснять брату всю разницу между мужским и женским телом, зачем женщине грудь и тому подобное, попутно борясь с возбуждением вперемешку со стыдом от осознания того, что вы стоите раком голая перед своим родным братом.'
	$_str += '<br><do>- А это больно?</do> - перебивает вас брат.'
	$_str += '<br><dh>- Что?</dh>'
	$_str += '<br><do>- Ну, когда в тебя пихают член?</do>'
	if vagina > 0:
		$_str += '<br><dh>- Только в первый раз или два.</dh>'
		if brother_knows_not_virgin = 0:
			brother_knows_not_virgin = 1
			$_str += '<br><do>- Ты уже пробовала?</do>'
			$_str += '<br><dh>- Неважно...</dh>'
			$_str += '<br><do>- Ну, скажи!</do>'
			if sex = 0:
				$_str += '<br><dh>- Нет, не пробовала.</dh>'
			elseif sex >= 1 and sex < 10:
				$_str += '<br><dh>- Ну, было несколько раз</dh> - отвечаете вы.'
			else
				$_str += '<br><dh>- Ну было дело, пробовала</dh> - отвечаете вы.'
				$_str += '<br><do>- А много раз уже?</do>'
				$_str += '<br><dh>- '+iif(sex >= 20,'Много','Достаточно')+'.</dh>'
			end
		end
	else
		$_str += '<br><dh>- Не знаю, я не пробовала.</dh>'
		$_str += '<br><do>- Понятно...</do>'
	end
	gs 'zz_render','','images/qwest/alter/ev2/brother/f2.jpg', $_str
	killvar '$_str'
	act 'Далее': gt 'zz_brother','brother_voyeur_ev6'
end
if $ARGS[0] = 'brother_voyeur_ev6':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'stat'
	$_str = 'Вы присаживаетесь попой на пятки и разворачиваясь, чтоб посмотреть на Кольку и замечаете, что у него уже крепкий стояк, который сильно заметен через легкую домашнюю одежду, а его лицо красное от возбуждения.'
	if $npc['39,qwBrotherNude'] = 4:
		$_str += '<br><do>- <<$name[1]>>, а можешь поближе показать?</do><br>'
		$_str += '<dh>- Что показать?</dh><br>'
		$_str += '<do>- Ну ты поняла...</do><br>'
		$_str += '<dh>- Тебе мало что ли? И так далеко зашло...</dh> - возмущённо отвечаете вы.<br>'
		$_str += '<do>- Ну покажи!</do><br>'
	elseif $npc['39,qwBrotherNude'] > 4:
		$_str += '<do>- <<$name[2]>>, а покажи поближе?</do><br>'
		$_str += '<dh>- Опять?</dh><br>'
		$_str += '<do>- Снова</do> - улыбается он - <do>ну давай, чё ты ломаешься?</do><br>'
	end
	if brother_knows_not_virgin = 1: $_str += '<dh>- Коль, ты же всё это уже видел...</dh><br>'
	gs 'zz_render','','images/qwest/alter/ev2/brother/f3.jpg',$_str
	killvar '$_str'
	if dom > -30: act 'Отказать и одеваться': gt $loc, $metka
	act 'Показать': gt 'zz_brother','brother_voyeur_ev7'
end
if $ARGS[0] = 'brother_voyeur_ev7':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'stat'
	$_str = ''
	gs 'zz_render','','images/qwest/alter/ev2/brother/f4.jpg',''
	if $npc['39,qwBrotherNude'] = 4:
		$npc['39,qwBrotherNude'] = 5
		$_str += 'Вы усаживаетесь в кресло и широко раздвигаете ноги. Немного нерешительно вы берете пальчиками кончики ваших половых губ и оттягиваете их немного в стороны, раскрывая слегка этим свою <<$vaginatipe2>> киску:'
		$_str += '<br><do>- Охренеть!...</do> - вырывается дрожащим голосом у вашего брата.'
		$_str += '<br><dh>- Всё? Доволен?</dh>'
		$_str += '<br><do>- Подожди-подожди, дай рассмотреть!</do>'
		$_str += '<br><dh>- Всё, хватит.</dh> - вы убираете руки и встаёте.'
		$_str += '<br><do>- Ну, <<$name[1]>>!</do>'
		$_str += '<br><dh>- Я сказала всё!</dh> - строго отрезаете вы и одеваетесь.'
		gs 'zz_render','','',$_str
		killvar '$_str'
		act 'Отойти': gt $loc, $metka
	elseif $npc['39,qwBrotherNude'] > 4:
		$_str += 'Вы усаживаетесь в кресло и широко раздвигаете ноги. Вы берете пальчиками кончики ваших половых губ и оттягиваете их немного в стороны, раскрывая слегка этим свою <<$vaginatipe2>> киску:'
		$_str += '<br><do>- Охуенно!</do> - вырывается у вашего брата.'
		$_str += '<br><dh>- Доволен?</dh> - спрашиваете вы.'
		$_str += '<br><do>- Почти...</do>'
		if brother_knows_not_virgin = 1 and vagina > 0 and rand(1,2) = 1:
			$_str += '<br><dh>- Что еще?</dh>'
			$_str += '<br><do>- <<$name[2]>>, а можешь пальчик внутрь засунуть?</do>'
			$_str += '<br><dh>- Зачем?</dh>'
			$_str += '<br><do>- Ну, мне интересно посмотреть.</do>'
			act 'Отказать':
				cla
				$_str += '<br><dh>- Нет, конечно!</h>'
				$_str += '<br><do>- Почему?</do> - в недоуменнии спрашивает он.'
				$_str += '<br><dh>- Сам как думаешь?</dh> - строго говорите вы и встаёте, начиная одеваться.'
				gs 'zz_render','','',$_str
				killvar '$_str'
				act 'Отойти': gt $loc, $metka
			end
			act 'Засунуть':
				*clr & cla
				minut += RAND(5,10)
				$_str += '<br>Вы, не говоря ни слова, вводите палец во влагалище и затем ещё один. Вторая рука машинально потянулась к клитору.'
				if vagina < 5:
					horny += RAND(2,5)
					$_str += '<br>Скользкие стенки вашей киски очень плотно обхватили пальчики.'
				elseif vagina >= 5 and vagina < 10:
					horny += RAND(5,10)
					$_str += '<br>Вы чувствуете скользкие стенки вашей киски вокруг собственных пальчиков.'
				elseif vagina >= 10:
					horny += RAND(2,5)
					$_str += '<br>Ваша киска довольно просторна для пары пальцев, и вы, двигая пальцами, чувствуете скользкие стенки вашей киски.'
				end
				$_str += '<br>Сгорая от желания, вы, сами того не понимая, начинаете мастурбировать прямо перед лицом вашего брата.'
				$_str += '<br>Накопившееся возбуждение полностью затуманило ваш рассудок и вы даже не обратили внимание на то, что Колька, глядя на вас, занялся тем же самым прямо напротив.'
				gs 'zz_render','','images/qwest/alter/ev2/brother/f5.jpg',$_str
				killvar '$_str'
				act 'Далее': gt 'zz_brother', 'brother_voyeur_ev8'
			end
		else
			if $npc['39,qwBrotherNude'] = 5:
				$_str += '<br><dh>- Что еще?</dh>'
				$_str += '<br><do>- Помоги мне сбросить напряжение</do> - выдаёт Колька.'
				$_str += '<br><dh>- Ты охуел?</dh>'
				$_str += '<br><do>- Просто не одевайся и посиди на месте - я сам всё сделаю!</do>'
			elseif $npc['39,qwBrotherNude'] > 5:
				$_str += '<br><dh>- Что еще?</dh>'
				$_str += '<br><do>- Давай как в прошлый раз? Мне очень понравилось</do> - выдаёт Колька.'
			end
			gs 'zz_render','','',$_str
			killvar '$_str'
			if dom > -30: act 'Отказать и одеваться': gt $loc, $metka
			act 'Помочь': gt 'zz_brother',iif($npc['39,qwBrotherNude']=7,'brother_voyeur_ev9','brother_voyeur_ev8')
		end
	end
end
if $ARGS[0] = 'brother_voyeur_ev8':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	horny += RAND(10,15)
	minut += RAND(5,10)
	gs 'stat'
	$_str = 'Опустившись с кресла на ковёр, вы, не в силах преодолеть возбуждение и желание, лежите под дрочащим над вами братом и ласкаете свою киску.'
	if vagina > 0: $_str += 'Ваши пальцы проникают внутрь и вы извиваетесь на полу, тихо постанывая и тяжело дыша.'
	$_str += 'Ваш взгляд прикован к члену брата и вы пристально следите за каждым его движением, пока внизу живота не ударяет током и вы не отдаетесь волне сильного оргазма, совсем не обращая внимание на то, что ваш брат начинает кончать прямо на вас. Струи его теплой спермы падают вам на живот и вы, извиваясь в оргазме, неспециально немного размазываете её своими руками.'
	gs 'zz_funcs', 'cum', 'belly'
	gs 'zz_render','','images/qwest/alter/ev2/brother/f6'+RAND(1,2)+'.jpg',$_str
	horny = 0
	act 'Далее':
		*clr & cla
		gs 'stat'
		$_str = ''
		if $npc['39,qwBrotherNude'] = 5:
			$_str += 'Придя в себя, вы начинаете осознавать случившееся:'
			$_str += '<br><dh>- Офигеть!</dh> - взволнованно почти выкрикиваете вы, глядя на капли спермы у себя на животе.'
			$_str += '<br><do>- Ага...</do> - Колька тяжело переводит дыхание.'
			$_str += '<br><dh>- Блядь!.. Ты... НЕТ СЛОВ!</dh>'
			$_str += '<br><do>- А мне понравилось...</do> - отвечает он.'
			$_str += '<br><dh>- Никому! Слышышь?! НИКОМУ НИ СЛОВА!</dh>'
			$_str += '<br><do>- Да понял я, понял. Не кричи, а то мама услышит!</do>'
		elseif $npc['39,qwBrotherNude'] >= 6:
			$_str += 'Придя в себя, вы поднимаете голову на улыбающегося брата:'
			$_str += '<br><dh>- Опять всю меня забрызгал...</dh>'
			$_str += '<br><do>- Ага...</do> - Колька тяжело переводит дыхание.'
			$_str += '<br><dh>- Засранец! Ладно, пойду, пока никто нас не застукал.</dh>'
			$_str += '<br><do>- Давай... Было круто, <<$name[2]>>!</do>'
		end
		$npc['39,qwBrotherNude'] += 1
		gs 'zz_render','','images/qwest/alter/ev2/brother/f7'+RAND(1,2)+'.jpg',$_str
		act 'Одеваться': gt $loc, $metka
	end
end
if $ARGS[0] = 'brother_voyeur_ev9':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	minut += RAND(5,10)
	$_str = 'Опустившись с кресла на ковёр, вы, не в силах преодолеть возбуждение и желание, лежите под дрочащим над вами братом и ласкаете свою киску.'
	if vagina > 0: $_str += 'Ваши пальцы проникают внутрь и вы извиваетесь на полу, тихо постанывая и тяжело дыша.'
	$_str += 'Ваш взгляд прикован к члену брата и вы пристально следите за каждым его движением, пока внизу живота не ударяет током и вы не отдаетесь волне сильного оргазма. Но Колька в этот раз явно не спешит.'
	$_str += '<br>Вы терпеливо ждёте, бросая взляды то на него, то на дверь в комнату, чем еще больше смущаете братца.'
	if $npc['39,qwPornoFootball'] <= 10:
		$_str += '<br>Наконец, спустя несколько минут, он кончает, снова попадая на вас. Не говоря ни слова, вы одеваетесь и уходите.'
		gs 'zz_funcs', 'cum', 'belly'
		gs 'zz_render','','',$_str
		killvar '$_str'
		act 'Уйти': gt $loc, $metka
	else
		$_str += '<br><do>- <<$name[2]>>, помоги мне</do> - прошептал Колька.'
		gs 'zz_render','','',$_str
		killvar '$_str'
		cla
		gs 'zz_brother','brotherSexStart'
	end
end
if $ARGS[0] = 'brotherSexStart':
	!cla
	brother_tv_enable = 1
	if $npc['39,sex'] = 0: $npc['39,sex'] = 1 & guy += 1
	act 'Дрочить брату':
		*clr & cla
		minut += 5
		dick = brotherDick
		hj += 1
		gs 'zz_render','','images/qwest/alter/artom/hj.jpg','Вы взяли его твердый и горячий член в руку и начали дрочить его. Наконец брат сдавленно застонал, и вы увидели как из его члена вылетает сперма.'
		gs 'zz_brother','brotherSexEnd'
	end
	if $npc['39,sex'] > 4:
		act 'Сосать у брата':
			*clr & cla
			minut += 5
			horny += 10
			bj += 1
			dick = brotherDick
			gs 'stat'
			gs 'zz_render','','common/sex/bj/'+rand(0,4)+'.gif','Вы сели на корточки перед братом и приблизили лицо к его члену.'
			gs 'zz_dynamic_sex', 'bj'
			'Вскоре Колька застонал: "<<$name[2]>>, я сейчас кончу!"'
			act 'Сосать дальше':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif'
				gs 'zz_dynamic_sex', 'swallow'
				gs 'zz_brother','brotherSexEnd'
			end
			act 'Вынуть изо рта':
				*clr & cla
				minut += 5
				horny += 10
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'images/qwest/alter/Ev/cocksuckerFacial.jpg', 'Вы вынули изо рта член и тут же вам в лицо ударила струя горячей спермы, потом еще и еще. Наконец брат прекратил кончать на ваше лицо.'
				gs 'zz_brother','brotherSexEnd'
			end
			gs 'zz_brother','brotherSex_sex'
		end
	end
	gs 'zz_brother','brotherSex_sex'
end
if $ARGS[0] = 'brotherSex_sex':
	if $npc['39,sex'] > 6:
		act 'Отдаться':
			if $npc['39,sex'] > 10: $npc['39,sex'] = 10
			*clr & cla
			minut += 5
			horny += 10
			$boy = 'Колька'
			dick = brotherDick
			silavag = 0
			pose = 0
			gs 'zz_render','','common/sex/sex/'+rand(0,4)+'.gif','Вы легли на диван и брат лег на вас сверху.'
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			gs 'zz_brother','brotherSexEnd'
		end
	end
end
if $ARGS[0] = 'brotherSexEnd':
	$npc['39,sex'] += 1
	minut += rand(5,15)
	gs 'stat'
	if $loc = 'sitrPar':
		gs 'zz_render','','','Колька дал вам немного передохнуть, после чего сказав: <do>- '+iif(dom<0,'Молодец, <<$name[2]>>, хорошо поработала, а теперь вали давай!','Спасибо, <<$name[2]>>, ты мне очень помогла')+'</do>, продолжил заниматься своими делами.'
	else
		gs 'zz_render','','','Колька сказав: <do>- '+iif(dom<0,'Молодец, <<$name[2]>>, хорошо постаралась, а теперь вали давай!','Спасибо, сеструх. Ну я пошёл.')+'</do>'
	end
	act 'Уйти': gt $loc, $metka
end
if $args[0] = 'incest_event':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', '','\\\- Свет, мы сейчас на городские соревнования поедем, хочешь с нами? Поболеешь за нас!///**\\- Конечно, поеду! Куда вы теперь без меня!// - с энтузиазмом воскликнули вы.'
	act'Далее':
		*clr & cla
		minut += 480
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event/01.jpg','Вместе с ребятами вы поехали на большой городской стадион, там сегодня проходили соревнования любительских команд. Парни без особых проблем добрались до финала, но там им предстояло столкнуться с прошлогодними чемпионами, так что ребята немного приуныли. Вы решили их подбодрить:**\\- Мальчишки, я вас верю, давайте! Кстати, призы в этом году отличные!//**Затем вы подошли к ним поближе и вполголоса сказали, подмигнув:**\\- Если вы выиграете, то я вам особый подарочек приготовлю - уж точно не пожалеете.//'
		act'Далее':
			*clr & cla
			minut += 30
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event/02.jpg','После таких напутствий парни взбодрились и неожиданно разнесли соперника в пух и прах, забив 8 безответных голов. Колька был признан самым ценным игроком турнира и получил игровую приставку X-box в подарок. Сама же команда получила 25 тысяч рублей и памятные медали. На дворе был уже вечер и вы решили все вместе потратить часть призовых денег, отпраздновав победу в кафе.'
			act'Далее':
				*clr & cla
				minut += 60
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event/03.jpg','Немного посидев в кафе, парни решили, что им не мешало бы немного выпить, но несовершеннолетним тут не продавали спиртное. Оглядевшись по сторонам, вы увидели сидящего рядом с вашим столиком парня, на вид лет 20. Вы встали и подошли к нему.'
				act'Далее':
					*clr & cla
					minut += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event/04.jpg','\\- Привет! Не мог бы ты нам помочь?// - ни чуточки не стесняясь, сказали вы.**\\\- Привет! Помочь с чем конкретно?/// - улыбнулся парень, с удовольствием рассматривая вас.**\\- Тут такое дело... у мальчишек праздник сегодня, а пиво им тут не продают. Не мог бы ты купить нам немного и отпраздновать, конечно, вместе!//**\\\- Да без проблем! Пойдем, сейчас вместе все и принесем.///'
					act'Далее':
						*clr & cla
						minut += 120
						gs 'zz_funcs', 'alko', 1
						$npc['38,turnirWin'] = 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event/05.jpg','Вы принесли пиво и стали праздновать. Как выяснилось позднее, вашего нового знакомого звали Михаил, парень он был довольно простой, хотя по виду деньги у него водились. Весь вечер он увивался за вами, а узнав, что Колька ваш брат - быстренько с ним подружился и даже дал ему свой номер телефона. В кафе вы просидели почти до закрытия, а потом отправились по домам.'
						act'Идти домой': gt 'korrPar'
					end
				end
			end
		end
	end
end
if $args[0] = 'incest_event_Kolka':
	*clr & cla
	minut += 5
	$npc['48,know'] = 1
	$npc['38,qwKolkaTel'] = 1
	gs 'stat'
	gs 'zz_render', '', '','Вы быстро оглянулись, затем с многозначительной улыбкой провели рукой по бедру брата:\\- Ко-оленькаа, а дай-ка мне телефончик Михаила!//**\\\- А чего вдруг понадобился?///**\\- Сюрприз!//**\\\- Ну ладно, не такая уж тайна, вот, записывай.///**Николай надиктовал вам номер мобильного Мишки.**"Вау! Ну держись Анькина попка! Сейчас замутим!" - обрадовались вы, строя коварные планы по дальнейшему развращению сестры.'
	act'Уйти': gt 'sitrPar'
end