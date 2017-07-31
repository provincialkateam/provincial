if $ARGS[0] = 'start':
	*clr & cla
	gs'stat'
	gs 'time'
	gs 'zz_render', 'Рынок', 'images/city/south/south_market/market_work/trade'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg','Вы стоите за лотком с одеждой в ожидании покупателей.<br>В кассе <<rinmon>> рублей, продано <<rinvesh>> вещей.<br>Средняя цена на рынке <<prodpayum>>.'
	if market_sex > 10 and market_sex <= 20: $market_rep = 'На рынке ходят слухи, что вы спите со своим хозяином.'
	if market_sex > 20 and market_sex <= 35: $market_rep = 'На рынке точно знают, что вы спите со своим хозяином.'
	if market_sex > 35 and market_sex <= 50: $market_rep = 'На рынке ходят слухи, что вы спите не толькосо своим хозяином, но и с его друзьями.'
	if market_sex > 50: $market_rep = 'На рынке точно знают, что вы спите не только со своим хозяином, но и с его друзьями.'
	if market_sex > 10: gs 'zz_render', '', '','<<$market_rep>>'
	''
	if hour = 14:
		gs 'zz_render', '', '','К вам подошел Рустам'+iif(market_sex > 50,', Абдула и Хасан,','')+' и вы начали подсчитывать сколько вы должны отдать Рустаму.'
		act 'Отдать Рустаму деньги':
			*clr & cla
			rinrust = rinvesh*1000
			rinmon = rinmon-rinrust
			money += rinmon
			gs'stat'
			gs 'zz_render', 'Рустам', 'images/city/south/south_market/market_work/rustam.jpg','Вы отдали Рустаму <<rinrust>> рублей за проданные <<rinvesh>> вещей.<br>Сегодня вы заработали <<rinmon>> рублей.'
			if rinrust < rustam_plan:
				bad_trade += 1
				gs 'zz_render', '', '','<do>- Эээ, '+replace($name[1],'е','э')+', плохо работаешь, дэнег мало. Ты так разоришь мэня совсэм, -</do> сказал он.'
			else
				bad_trade -= 1
				gs 'zz_render', '', '','<do>- Маладэц '+replace($name[2],'е','э')+', хорошо поработала, -</do> сказал он вам.'
			end
			rinmon = 0
			rinvesh = 0
			if bad_trade > 10:
				work = 0
				workrin = 0
				gs 'zz_render', '', '','<do>- Ээ, заебала ты уже савсэм, -</do> сказал вам Руслан чуть помедлив.<do> - Вот твоя трудовая. Проваливай, чтоб я тэбя больше нэ видел!</do>'
				act 'Уйти':gt'street'
				exit
			elseif bad_trade = 9:
				work = 0
				workrin = 0
				gs 'zz_render', '', '','<do>- Ээ, '+replace($name,'е','э')+', -</do> сказал вам Руслан чуть помедлив.<do> - Если в слэдующий раз будэшь так плохо работать, выгоню!</do>'
				act 'Уйти':gt'street'
				exit
			end
			rinrand = RAND(1,60)
			if rinrand < vnesh:
				gs 'zz_render', '', '','<do>- Вай, '+replace($name[2],'е','э')+'!, -</do> продолжил Рустам.<do> -'+iif(market_sex = 0,' Ми с тобой ещё даже нэ познакомились хорошенько','')+'. Пойдем в контейнэр, покушаем шашлыка, выпьем, познакомимся.</do>'
				act 'Отказаться':
					cla
					gs 'zz_render', '', '','Вы стали отнекиваться, но Рустам вам сказал:**<do>- Вай, зачэм оскорбляешь,! У тэбя вот лоток нэ убран, пыль, грязь. Я вэдь и штраф могу с тэбя взять!</do>'
					act 'Ладно, пойдем выпьем':
						if market_sex <= 50:
							gt'market_sex','sex_start'
						else
							gt'market_sex','sex_start',1
						end
					end
					act 'Нет':
						cla
						rustam_plan += 1000
						if money >= 1000 and bad_trade >= 0:
							money -= 1000
							gs 'zz_render', '', '','Вы всё равно решили отказаться, тогда Рустам сказал:**<do>- Вай, у тэбя вещи грязные, отдавай тысячу рублей, это штраф, -</do> вы отдали Рустаму деньги.'
						else
							bad_trade += 1
							gs 'zz_render', '', '','Вы всё равно решили отказаться, тогда Рустам сказал:**<do>- Ладно, иды уже.</do>'
						end
						act 'Уйти':gt'street'
					end
				end
				act 'Пойдем':
					if bad_trade > -10: bad_trade -= 1
					if market_sex <= 50:
						gt'market_sex','sex_start'
					else
						rinslut = 1
						gt'market_sex','sex_start',1
					end
				end
				exit
			else
				act 'Уйти с работы':gt'street'
			end
		end
		exit
	elseif hour < 14:
		pokrand = RAND(0,1)
		if pokrand = 0:
			$pokup = 'Покупателей не видно.'
			pokupatel = 0
			!''
			gs 'zz_render', '', '','По рынку идет тетя Катя с тележкой в которой она везет пирожки и кофе.'
		elseif pokrand = 1:
			pokupatel = 1
			poktiprand = RAND(0,7)
			if poktiprand = 0:$pokup = 'К лотку подошел мужчина средних лет.' & $poktip = 'Мужчина' & pokti = 1
			if poktiprand = 1:$pokup = 'К лотку подошел молодой мужчина.' & $poktip = 'Парень' & pokti = 2
			if poktiprand = 2:$pokup = 'К лотку подошел парень подросток.' & $poktip = 'Пацан' & pokti = 3
			if poktiprand = 3:$pokup = 'К лотку подошла женщина.' & $poktip = 'Женщина' & pokti = 1
			if poktiprand = 4:$pokup = 'К лотку подошла девушка.' & $poktip = 'Девушка' & pokti = 2
			if poktiprand = 5:$pokup = 'К лотку подошла девушка подросток.' & $poktip = 'Девчонка' & pokti = 3
			if poktiprand = 6:$pokup = 'К лотку подошел старик.' & $poktip = 'Старик' & pokti = 0
			if poktiprand = 7:$pokup = 'К лотку подошла бабуля.' & $poktip = 'Бабуля' & pokti = 0
		end
		gs 'zz_render', '', '','<b><<$pokup>></b>'
		if pokupatel = 1:
			act 'Что желаете?':
				cla
				minut += 15
				pokvnirand = RAND(0,2)
				if pokvnirand = 0:
					gs 'zz_render', '', '','<<$poktip>> без интереса осматривает продаваемые вещи.'
				elseif pokvnirand = 1:
					gs 'zz_render', '', '','<<$poktip>> с интересом осматривает продаваемые вещи.'
				elseif pokvnirand = 2:
					gs 'zz_render', '', '','<<$poktip>> берет в руки вещь.'
				end
				act 'Сейчас это очень модно':
					cla
					tipred = 3
					gs 'market_work', 'answerrin'
					gs 'zz_render', '', '','<<$rinitog>>'
					if pokupatel = 0:act 'Дальше': gt'market_work','start'
					if pokupatel = 1:
						gs 'zz_render', '', '','<<$poktip>> спрашивает у вас цену'
						gs 'market_work', 'answerrin2'
					end
				end
				act 'Вещь очень качественная и надежная':
					cla
					tipred = 1
					gs 'market_work', 'answerrin'
					gs 'zz_render', '', '','<<$rinitog>>'
					if pokupatel = 0:act 'Дальше': gt'market_work','start'
					if pokupatel = 1:
						gs 'zz_render', '', '','<<$poktip>> спрашивает у вас цену'
						gs 'market_work', 'answerrin2'
					end
				end
				act 'Отдам не дорого':
					cla
					tipred = 0
					gs 'market_work', 'answerrin'
					gs 'zz_render', '', '','<<$rinitog>>'
					if pokupatel = 0:act 'Дальше': gt'market_work','start'
					if pokupatel = 1:
						gs 'zz_render', '', '','<<$poktip>> спрашивает у вас цену'
						gs 'market_work', 'answerrin2'
					end
				end
				act 'Вам очень идет':
					cla
					tipred = 2
					gs 'market_work', 'answerrin'
					gs 'zz_render', '', '','<<$rinitog>>'
					if pokupatel = 0:act 'Дальше': gt'market_work','start'
					if pokupatel = 1:
						gs 'zz_render', '', '','<<$poktip>> спрашивает у вас цену'
						gs 'market_work', 'answerrin2'
					end
				end
			end
		end
		act 'Бездельничать 15 минут':
			minut += 15
			gt 'market_work','start'
		end
		if hour = 9:
			rintakrand = RAND(0,5)
			if rintakrand = 0:
				$rintak = 'В лотке напротив Хасан выгружает шмотки продавщице Наде.'
				act 'Смотреть на Хасана и Надю':
					cla
					minut += 15
					talkrand = RAND(0,2)
					if talkrand = 0:gs 'zz_render', '', '','Хасан выговаривает Наде:**<do>- Сэгодня продашь большэ, а то штраф дам. Мнэ деньги нужны!</do>'
					if talkrand = 1:gs 'zz_render', '', '','Хасан открывает баулы и выкладывает шмотки на прилавок.'
					if talkrand = 2:gs 'zz_render', '', '','Хасан перетаскивает баулы к своему лотку.'
					act 'Далее': gt'market_work','start'
				end
			elseif rintakrand = 1:
				$rintak = 'В соседнем лотке Абдула, громко разговаривая, отдает шмотки продавщице Анне.'
				act 'Смотреть на Абдулу и Анну':
					cla
					minut += 15
					talkrand = RAND(0,2)
					if talkrand = 0:gs 'zz_render', '', '','Абдула ругается:**<do>- Ты уже заебала! Нычего продать нэ можешь!</do>**Анна парирует:**<do>- Так ты мне трухлявое дерьмо на продажу даешь, его брать никто не хочет!</do>'
					if talkrand = 1:gs 'zz_render', '', '','Абдула хлопнул по жопе Анну, та сделала вид, что ничего не произошло.'
					if talkrand = 2:gs 'zz_render', '', '','Абдула перетаскивает баулы к своему лотку.'
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 2:
				$rintak = 'Абдула и Хасан стоят около вашего лотка и о чем-то гортанно разговаривают.'
				act 'Смотреть на кавказцев':
					cla
					minut += 15
					talkrand = RAND(0,2)
					if talkrand = 0:gs 'zz_render', '', '','Абдула и Хасан продолжают о чем-то разговаривать. Языка вы не знаете и о чем они говорят понять не можете.'
					if talkrand = 1:gs 'zz_render', '', '','Абдула и Хасан пялятся на вас и гогочут, что-то обсуждая.'
					if talkrand = 2:gs 'zz_render', '', '','Абдула смотрит на вас и говорит Хасану:**<do>- Гляды какая дэвочка, губки пэрсик, вах!</do>'
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 3:
				$rintak = 'Анна развешивает шмотки в лотке и перекрикивается с Надей.'
				act 'Болтать с девчонками':
					cla
					minut += 15
					manna += iif(rinslut = 0,10,-10)
					talkrand = RAND(0,2)
					if rinslut = 0:
						if talkrand = 0:
							gs 'zz_render', '', '','Аня рассказывает, как заходила недавно в офисное здание и видела там объявление, что им требуется уборщица.**<do>- Думаю неплохой способ подзаработать, если деньги нужны, -</do> добавляет она задумчиво.'
							if clener = 0: clener = 1
						elseif talkrand = 1:
							gs 'zz_render', '', '','Надя рассказывает как к ней в метро приставал какой-то извращенец, терся об зад своим членом.'
						else
							gs 'zz_render', '', '','Вы весело поболтали с подружками, раассказывая другу истории из жизни.'
						end
					else
						gs 'zz_render', '', '','Аня и Надя демонстративно отвернулись от вас и продолжили разговор вдвоём.'
					end
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 4:
				$rintak = 'Рустам о чем-то разговаривает с Абдулой.'
				act 'Смотреть на кавказцев':
					cla
					minut += 15
					talkrand = RAND(0,2)
					if talkrand = 0:gs 'zz_render', '', '','Абдула и Рустам продолжают о чем-то разговаривать. Языка вы не знаете и о чем они говорят понять не можете.'
					if talkrand = 1:gs 'zz_render', '', '','Абдула и Рустам пялятся на вас и гогочут что-то обсуждая.'
					if talkrand = 2:gs 'zz_render', '', '','Абдула глядит на вас и говорит Рустаму:**<do>- Гляды какая дэвочка, губки пэрсик, вах!</do>'
					act 'Далее': gt 'market_work','start'
				end
			end
			if rintakrand = 5:
				$rintak = 'Рустам, Абдула и Хасан громко ржут и о чем-то разговаривают на не понятном языке.'
				act 'Смотреть на кавказцев':
					cla
					minut += 15
					talkrand = RAND(0,2)
					if talkrand = 0:gs 'zz_render', '', '','Кавказцы продолжают о чем-то разговаривать. Языка вы не знаете и о чем они говорят понять не можете.'
					if talkrand = 1:gs 'zz_render', '', '','Кавказцы пялятся на вас и гогочут что-то обсуждая.'
					if talkrand = 2:gs 'zz_render', '', '','Абдула глядит на вас и говорит другим кавказцам:**<do>- Гляды какая дэвочка, губки пэрсик, вах!</do>'
					act 'Далее': gt 'market_work','start'
				end
			end
			gs 'zz_render', '', '','<<$rintak>>'
		elseif hour = 10:
			rintakrand = RAND(0,5)
			if rintakrand = 0:
				$rintak = 'Хасан, сидя на стуле, уныло жует чебурек, и разговаривает, с набитым ртом, с продавщицей Надей.'
				act 'Смотреть на Хасана':
					cla
					minut += 15
					gs 'zz_render', '', '','Хасан говорит Наде:**<do>- Надэнька, зачэм ти отказываешься? Покушаем шашлыков, выпьем вина...</do>'
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 1:
				$rintak = 'В лотке напротив сидит Надя и разгадывает кроссворды.'
				act 'Болтать с Надей':
					cla
					minut += 15
					manna += iif(rinslut = 0,5,-5)
					if rinslut = 0:
						gs 'zz_render', '', '','Надя отрывается от кроссворда и охотно поддерживает беседу о всякой ерунде.'
						if clener = 0:
							clener = 1
							gs 'zz_render', '', '','Надя рассказывает, что иногда подрабатывет уборщицей в офисном здании, когда деньги нужны.'
						end
					else
						gs 'zz_render', '', '','Надя бросив презрительный взгляд отвернулась от вас.'
					end
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 2:
				$rintak = 'В лотке напротив к Наде подошли покупатели и она суетится выкладывая перед ними товар.'
				act 'Болтать с Надей':
					cla
					minut += 15
					manna -= 5
					gs 'zz_render', '', '','Надя недовольна:**<do>- '+iif(rinslut = 0,'<<$name>>, не отвлекай, у меня покупатели.</do>','Иди ты в жопу со своими разговорами!</do>')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 3:
				$rintak = 'В соседнем лотке Анна пьет кофе.'
				act 'Болтать с Аней':
					cla
					minut += 15
					manna += iif(rinslut = 0,5,-5)
					gs 'zz_render', '', '',iif(rinslut = 0,'Аня поддерживает беседу с вами и рассказывает какие-то пустяки.','Аня окинула вас презрительным взглядом и отвернулась.')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 4:
				$rintak = 'В соседнем лотке Анна пытается втюхать покупателям залежалый товар.'
				act 'Болтать с Аней':
					cla
					minut += 15
					manna -= 5
					gs 'zz_render', '', '','Аня недовольна:**<do>- '+iif(rinslut = 0,'<<$name>>, не отвлекай, у меня покупатели.</do>','Иди ты в задницу со своими разговорами!</do>')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 5:
				$rintak = 'Анна болтает о пустяках с тетей Катей.'
				act 'Болтать с Аней и тетей Катей':
					cla
					minut += 15
					manna += iif(rinslut = 0,10,-10)
					gs 'zz_render', '', '',iif(rinslut = 0,'Тётя Катя нахваливает пирожки, а Аня жалуется, что она себе уже на этих пирожках задницу наела в два раза больше, чем была...','Тётя Катя и Аня хмурясь отворачиваются от вас.')
					act 'Далее': gt 'market_work','start'
				end
			end
			gs 'zz_render', '', '','<<$rintak>>'
		elseif hour = 11:
			rintakrand = RAND(0,5)
			if rintakrand = 0:
				$rintak = 'К Наде подошли три кавказца, Аслан, Камиля и Мухтар, и начали к ней приставать, а она ругаясь на них, пытается увернуться.'
				act 'Смотреть на Надю и кавказцев':
					cla
					minut += 15
					gs 'zz_render', '', '','Кавказцы явно склоняют Надю к сексу.'
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 1:
				$rintak = 'В лотке напротив сидит Надя и ест пирожок.'
				act 'Болтать с Надей':
					cla
					minut += 15
					manna += iif(rinslut = 0,5,-5)
					if rinslut = 0:
						gs 'zz_render', '', '','Надя отрывается от кроссворда и охотно поддерживает беседу о всякой ерунде.'
						if clener = 0:
							clener = 1
							gs 'zz_render', '', '','Надя рассказывает, что в офисном здании можно подрабатывать уборщицей, если деньги нужны.'
						end
					else
						gs 'zz_render', '', '','Надя бросив презрительный взгляд отвернулась от вас.'
					end
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 2:
				$rintak = 'В лотке напротив к Наде подошли покупатели и она суетится выкладывая перед ними товар.'
				act 'Болтать с Надей':
					cla
					minut += 15
					manna -= 5
					gs 'zz_render', '', '','Надя недовольна:**<do>- '+iif(rinslut = 0,'<<$name>>, не отвлекай, у меня покупатели.</do>','Иди ты в жопу со своими разговорами!</do>')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 3:
				$rintak = 'В соседнем лотке Анна читает газету.'
				act 'Болтать с Аней':
					cla
					minut += 15
					manna += iif(rinslut = 0,5,-5)
					gs 'zz_render', '', '',iif(rinslut = 0,'Аня поддерживает беседу с вами и рассказывает какие то пустяки.','Аня отказывается с вами разговаривать.')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 4:
				$rintak = 'К Ане из соседнего лотка подошли покупатели.'
				act 'Болтать с Аней':
					cla
					minut += 15
					manna -= 5
					gs 'zz_render', '', '','Аня недовольна:**<do>- '+iif(rinslut = 0,'<<$name>>, не отвлекай, у меня покупатели.</do>','Иди ты в задницу со своими разговорами!</do>')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 5:
				$rintak = 'К Ане подошли три кавказца, Аслан, Камиля и Мухтар, и начали к ней приставать. Она отнекивается и большей частью испуганно молчит.'
				act 'Смотреть на Аню и кавказцев':
					cla
					minut += 15
					gs 'zz_render', '', '','Кавказцы явно склоняют Аню к сексу.'
					act 'Далее': gt 'market_work','start'
				end
			end
			gs 'zz_render', '', '','<<$rintak>>'
		elseif hour = 12:
			rintakrand = RAND(0,5)
			if rintakrand = 0:
				$rintak = 'Хасан купил чебурек и ест его, сидя за спиной Нади, в лотке.'
				act 'Болтать с Надей':
					cla
					minut += 15
					gs 'zz_render','','',iif(rinslut = 0,'Надя стесняется разговаривать при Хасане.','Надя, фыркнув, отварачивается от вас.')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 1:
				$rintak = 'Надя торгуется с покупателями.'
				act 'Болтать с Надей':
					cla
					minut += 15
					manna -= 5
					gs 'zz_render', '', '','Надя недовольна:**<do>- '+iif(rinslut = 0,'<<$name>>, не отвлекай, у меня покупатели.</do>','Иди ты в жопу со своими разговорами!</do>')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 2:
				$rintak = 'Надя болтает с Анной.'
				act 'Болтать с девчонками':
					cla
					minut += 15
					manna += iif(rinslut = 0,10,-10)
					talkrand = RAND(0,2)
					if rinslut = 0:
						if talkrand = 0:
							gs 'zz_render', '', '','Аня рассказывает, что в офисном здании требуются уборщицы и она подумывает, не устроиться ли на подработку.'
							if clener = 0: clener = 1
						elseif talkrand = 1:
							gs 'zz_render', '', '','Надя рассказывает как к ней в метро приставал какой-то извращенец, терся об зад членом.'
						else
							gs 'zz_render', '', '','Вы весело поболтали с подружками, раассказывая другу истории из жизни.'
						end
					else
						gs 'zz_render', '', '','Аня и Надя демонстративно отвернулись от вас и продолжили разговор вдвоём.'
					end
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 3:
				$rintak = 'Аня продает покупателям одежду.'
				act 'Болтать с Аней':
					cla
					minut += 15
					gs 'zz_render', '', '','Аня недовольна:**<do>- '+iif(rinslut = 0,'<<$name>>, не отвлекай, у меня покупатели.</do>','Иди ты в задницу со своими разговорами!</do>')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 4:
				$rintak = 'Аня пьет кофе сидя за своим лотком.'
				act 'Болтать с Аней':
					cla
					minut += 15
					manna += iif(rinslut = 0,5,-5)
					gs 'zz_render', '', '',iif(rinslut = 0,'Аня поддерживает беседу с вами и рассказывает какие то пустяки.','Аня, окинув вас брезгливым взглядом, отворачивается.')
					act 'Далее': gt 'market_work','start'
				end
			elseif rintakrand = 5:
				$rintak = 'Надя от безделья ловит мух.'
				act 'Болтать с Надей':
					cla
					minut += 15
					manna += iif(rinslut = 0,5,-5)
					gs 'zz_render', '', '',iif(rinslut = 0,'Надя обрадовалась хоть какому-то развлечению и с удовольствием болтает с вами.','Надя не желает с вами разговаривать.')
					act 'Далее': gt 'market_work','start'
				end
			end
			gs 'zz_render', '', '','<<$rintak>>'
		elseif hour = 13:
			$_str[0] = 'Хасан начал потихоньку собирать товар у Нади.'
			$_str[1] = 'Аня сидит и подсчитывает прибыль за день.'
			$_str[2] = 'Надя подсчитывает прибыль за день.'
			$_str[3] = 'Абдула начал собирать товар у Ани.'
			$_str[4] = 'Мимо вашего лотка прошел Рустам.'
			$_str[5] = 'Тетя катя заканчивает торговать пирожками и кажется собирается уходить.'
			gs 'zz_render', '', '',$_str[RAND(0,5)]
			killvar '$_str'
		end
		if money >= 200:
			act 'Перекусить 15 минут (200 руб)':
				cla
				*clr
				money -= 200
				gs 'zz_kitchen_acts', 'eat'
				gs 'zz_kitchen_acts', 'drink', 'coffee'
				gs 'stat'
				act 'Выкинуть остатки': gt 'market_work', 'start'
			end
		end
	end
end
if $ARGS[0] = 'answerrin':
	if tipred = pokti:
		$rinitog = ''
		if pokvnirand = 0:
			pokpay = RAND(1000,1200)
		elseif pokvnirand = 1:
			pokpay = RAND(1200,1500)
		elseif pokvnirand = 2:
			pokpay = RAND(1500,2000)
		end
	else
		$rinitog = '<<$poktip>> кладет вещь на место и уходит'
		pokupatel = 0
		manna -= 5
	end
end
if $ARGS[0] = 'answerrin2':
	act 'Назвать цену':
		cla
		prodpay = input ("Введите цену вещи")
		!if prodpay < 1000:prodpay = prodpayum
		gs 'zz_render', '', '','Вы назначили цену в <<prodpay>> рублей'
		if prodpay <= pokpay:
			poknorand = RAND(1,vnesh)
			if poknorand >= 10:
				rinmon += prodpay
				rinvesh += 1
				manna += 5
				gs 'zz_render', '', '','Покупатель забрал вещь и заплатил <<prodpay>> рублей'
				act 'Торговать дальше': gt 'market_work','start'
			else
				gs 'zz_render', '', '','Покупатель вертит вещь в руках:**<do>- <<prodpay>> рублей - это слишком дорого...</do>'
				gs 'market_work', 'answerrin3'
				act 'Меньше не могу, (забрать вещь)': gt 'market_work','start'
			end
		elseif prodpay > pokpay and prodpay <= pokpay+100:
			poknorand = RAND(1,vnesh)
			if poknorand >= 10:
				gs 'zz_render', '', '','Покупатель вертит вещь в руках:**<do>- <<prodpay>> рублей - это слишком дорого...</do>'
				gs 'market_work', 'answerrin3'
				act 'Меньше не могу, (забрать вещь)': gt 'market_work','start'
			else
				gs 'zz_render', '', '','Покупатель кладет вещь на место и уходит'
				act 'Торговать дальше': gt 'market_work','start'
			end
		elseif prodpay > pokpay+100:
			gs 'zz_render', '', '','Покупатель кладет вещь на место и уходит'
			act 'Торговать дальше': gt 'market_work','start'
		end
	end
end
if $ARGS[0] = 'answerrin3':
	if prodpay >= 1100:
		act 'Снизить цену на 100 руб':
			cla
			gs 'zz_render', '', '','Вы снизили цену на 100 рублей.'
			poknorand = RAND(1,vnesh)
			if poknorand >= 5:
				rinmon += prodpay-100
				rinvesh += 1
				gs 'zz_render', '', '','Покупатель забрал вещь и заплатил <<prodpay-100>> рублей'
				act 'Торговать дальше': gt 'market_work','start'
			else
				gs 'zz_render', '', '','Покупатель кладет вещь на место и уходит'
				act 'Торговать дальше': gt 'market_work','start'
			end
		end
	else
		act 'Снизить цену на 50 руб':
			cla
			gs 'zz_render', '', '','Вы снизили цену на 50 рублей.'
			poknorand = RAND(1,vnesh)
			if poknorand >= 5:
				rinmon += prodpay-50
				rinvesh += 1
				gs 'zz_render', '', '','Покупатель забрал вещь и заплатил <<prodpay-50>> рублей'
				act 'Торговать дальше': gt 'market_work','start'
			else
				gs 'zz_render', '', '','Покупатель кладет вещь на место и уходит'
				act 'Торговать дальше': gt 'rinwork','start'
			end
		end
	end
end