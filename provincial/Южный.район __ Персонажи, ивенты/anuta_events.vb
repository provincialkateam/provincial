anutaday = day
if $ARGS[0] = 'start':
	*clr & cla
	minut += 5
	anutaQW = 1
	anuta['horny'] = 70
	gs'stat'
	gs 'zz_render', '','images/city/south/lake/anuta/walk'+iif(vnesh < 40,1,2)+'.jpg','Загорая вы '+iif(anutaQW = 1,'опять ','')+'заметили, бредущую по пляжу, подвыпившую девушку, с бутылкой вина в руке, которая лениво осматривала пляж, как будто кого-то искала среди загарающих.**'+iif(vnesh < 40,'Она медленно прошла мимо, даже не взглянув на вас. Видимо ваша внешность её не заинтересовала','Заметив ваш взгляд, она улыбнулась и подошла к вам:**<do>- Привет! Не против если я рядом присяду?</do>')
	if vnesh < 40:
		act 'Далее': gt'nudelake'
	else
		act 'Не против, присаживайся':
			anutaQW = 2
			*clr & cla
			gs 'zz_render', '','images/city/south/lake/anuta/talk1.jpg','Девушка опустилась на песок рядом с вами**<do>- Меня Аня, кстати зовут, - </do>представилась она, и улыбнувшись добавила.<do> - Но мне больше нравится когда меня Анютой называют...</do>**<dh>- <<$name[1]>>, -</dh> в ответ представились вы.**<do>- <<$name[1]>>... -</do> протянула она, словно смакуя.<do> - Значит <<$name[2]>>, можно я так тебя буду называть?</do>'
			act 'Можно':
				*clr & cla
				gs 'zz_render', '','images/city/south/lake/anuta/talk2.jpg','<dh>- Можно, конечно, -</dh> улыбнулись вы в ответ.**<do>- Вот и отлично, -</do> просияла ваша новая знакомая.<do> - Тогда может отметим наше знакомство?</do>**Она кивнула на бутылку вина, лежащую у неё в ногах.'
				act 'Давай':
					*clr & cla
					minut += 60
					gs 'zz_funcs', 'alko', 5
					gs'stat'
					gs 'time'
					gs 'zz_render', '','images/city/south/lake/anuta/talk3.jpg','Вы с новой знакомой нашли на пляже уеденённое место, подальше от посторонних глаз, и приступили к распитию вина, весело болтая между собой.**Распив бутылку вы расслаблено облокотились на новую подругу и вдруг почувствовали её руку, нежно поглаживающую ваша спину.'
					act 'Не реагировать':
						*clr & cla
						gs 'zz_render', '','images/city/south/lake/anuta/kiss1.jpg','Видя, что вы не против, Анюта медленно приблизила своё лицо к вам, ваши глаза встретились взглядом, ещё мгновение и ваши губы слились в жарком поцелуе.'
						act 'Целоваться': gt 'anuta_events','kiss'
					end
					if horny < 70 and shameless['flag'] < 2:
						act 'Убрать руку':
							*clr & cla
							gs 'zz_render', '','images/city/south/lake/anuta/talk4.jpg','<dh>- Анют, -</dh> сказали вы девушке. -<dh> Ты только не обижайся, но я '+iif(lesbian = 0,'не такая, мне мальчики нравятся','не хочу сейчас')+'.</dh>**<do>- Ну ладно, нет так нет, -</do> улыбнулась Анюта, подмигнув вам.<do> - Может в другой раз... Я тут, на пляже, часто бываю в хорошую погоду, приходи как-нибудь.</do>**Девушка поднялась, и махнув на прощание рукой ушла, оставив вас в одиночестве.'
							act 'Уйти': gt'nudelake'
						end
					end
				end
				act 'Нет, неохота':
					*clr & cla
					minut += 10
					gs'stat'
					gs 'zz_render', '','images/city/south/lake/anuta/talk1.jpg','<dh>- Нет, неохота, -</dh> ответили вы Анюте.<dh> - Ты только не обижайся...</dh>**<do>- Да ладно, нет так нет, -</do> улыбнулась Анюта.<do> - Может в другой раз... Я тут, на пляже, часто бываю в хорошую погоду, приходи...</do>**Поболтав с вами ещё минут десять, девушка поднялась, и махнув на прощание рукой, побрела к выходу с пляжа.'
					act 'Уйти': gt'nudelake'
				end
			end
			act 'Нельзя':
				*clr & cla
				gs 'zz_render', '','images/city/south/lake/anuta/talk5.jpg','<do>- Ну ты и бука, -</do> пьяно улыбнулась Анюта.<do> - Если оттаешь, присоеденяйся, я тут часто бываю в хорошую погоду.</do>**Девушка, покачнувшись поднялась, и махнув на прощание рукой, побрела к выходу с пляжа.'
				act 'Далее': gt'nudelake'
			end
		end
		act 'Против':
			*clr & cla
			anutaQW = 3
			gs 'zz_render', '','images/city/south/lake/anuta/talk6.jpg','<do>- Ну и кисни тут одна, -</do> девушка показала вам язык и побрела дальше в поисках приключений, оставив вас наедине с собой.'
			act 'Далее': gt'nudelake'
		end
	end
end
if $ARGS[0] = 'alko':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '','images/city/south/lake/anuta/walk2.jpg','Загорая вы заметили, бредущую по пляжу, подвыпившую Аню, с бутылкой вина в руке.Увидев вас она обрадовалась:**<do>- О, привет, <<$name[2]>>, скучаешь?</do>И не дожидаясь приглашения плюхнулась на песок рядом с вами.'
	act 'Далее':
		*clr & cla
		gs 'zz_render', '','images/city/south/lake/anuta/talk2.jpg','- Что-то скучно сегодня, -</do> сказала Аня взжохнув и посмотрела на вас.<do> - <<$name[2]>>, может составишь мне компанию?</do>**Она кивнула на бутылку вина, лежащую у неё в ногах.'
		act 'Давай':
			*clr & cla
			minut += 60
			gs 'zz_funcs', 'alko', 5
			gs'stat'
			gs 'time'
			gs 'zz_render', '','images/city/south/lake/anuta/talk3.jpg','Вы с новой знакомой нашли на пляже уеденённое место, подальше от посторонних глаз, и приступили к распитию вина, весело болтая между собой.**Распив бутылку вы расслаблено облокотились на новую подругу и вдруг почувствовали её руку, нежно поглаживающую ваша спину.'
			act 'Расслабиться':
				*clr & cla
				gs 'zz_render', '','images/city/south/lake/anuta/kiss1.jpg','Видя, что вы не против, Анюта медленно приблизила своё лицо к вам, ваши глаза встретились взглядом, ещё мгновение и ваши губы слились в жарком поцелуе.'
				act 'Целоваться': gt 'anuta_events','kiss'
			end
			if horny < 70 and shameless['flag'] < 2:
				act 'Убрать руку':
					*clr & cla
					gs 'zz_render', '','images/city/south/lake/anuta/talk4.jpg','<dh>- Анют, -</dh> сказали вы девушке. -<dh> Ты только не обижайся, но я не хочу сейчас.</dh>**<do>- Ой, ну ты и зануда, -</do> разачарованно сказала Анюта.<do> - Ну ладно, может в другой раз...</do>**Девушка поднялась, и прихватив бутылку с вином ушла, оставив вас в одиночестве.'
					act 'Уйти': gt'nudelake'
				end
			end
		end
		act 'Нет, неохота':
			*clr & cla
			minut += 10
			gs'stat'
			gs 'zz_render', '','images/city/south/lake/anuta/talk1.jpg','<dh>- Нет, неохота Анют -</dh> ответили вы ей. - Ты только не обижайся, ...**<do>- Да ладно, нет так нет, -</do> улыбнулась Анюта.<do> - Может в другой раз... </do>**Поболтав с вами ещё минут десять, девушка поднялась, и махнув на прощание рукой, побрела к выходу с пляжа.'
			act 'Уйти': gt'nudelake'
		end
	end
end
if $ARGS[0] = 'talk':
	*clr & cla
	minut += 60
	manna += 20
	gs'stat'
	gs 'time'
	gs 'zz_render', '','images/city/south/lake/anuta/talk'+rand(8,9)+'.jpg','В теченее часа вы с Анютой сидели обнявшись на берегу и просто болтали болтая о всяких пустяках.**<do>- Ой, <<$name[2]>>, заболталась я с тобой, -</do> взглянув на часы сказала Аня.<do>- Идти мне пора...</do>** Быстро одевшись и махнув на прощание рукой она направилась к выходу с пляжа.'
	act 'Вернуться на пляж': gt 'nudelake'
end
if $ARGS[0] = 'kiss':
	*clr & cla
	minut += 5
	if anuta['sex'] = 0: girl += 1
	anuta['sex'] += 1
	lesbian += 1
	$boy = 'Анюта'
	dick = 10
	protect = 1
	gs'stat'
	gs 'zz_render', '','images/city/south/lake/anuta/tits'+iif(horny < 50,1,2)+'.jpg','Вы с Аней страстно целуетесь, забыв обо всём на свете. Её руки блуждают по вашему '+iif(horny < 50,'','возбуждённому ')+'телу, доставляя вам наслаждение. Оторвавшись от ваших губ, она опустила голову ниже и впилась губами в вашу грудь, лаская и дразня язычком ваш сосок, '+iif(horny < 50,'и одновременно лаская рукой вашу киску, возбуждая вас не на шутку','сорвав с ваших уст сладострастный стон')+'.'
	if horny < 50: horny += 10
	act 'Далее': gt'anuta_events','kuni'
end
if $ARGS[0] = 'kiss2':
	*clr & cla
	minut += 5
	if anuta['sex'] = 0: girl += 1
	anuta['sex'] += 1
	lesbian += 1
	anuta['horny'] += 5
	protect = 1
	gs'stat'
	gs 'zz_render','','images/city/south/lake/anuta/tits'+iif(horny < 90,3,4)+'.jpg','Вы отрываетесь от Аниных губ и спускаетесь к её груди.'+iif(horny < 90,' Вскользь поцеловав сосок, вы принялись играться с ним, то игриво щекотя его кончиком языка, то нежно облизывая круговыми движениями',' Вы буквально впились в её сосок, обхватив его губами, и принялись страстно ласкать его, то посасывая, то начиная ласкать кончиком языка')+', вырывая из груди девушки стоны наслаждения.'
	act 'Далее': gt'anuta_events','ukuni'
end
if $ARGS[0] = 'variant':
	cla
	$boy = 'Анюта'
	dick = 10
	minut += 5
	protect = 1
	gs'stat'
	if you_orgasm = 0 or girl_orgasm = 0:
		if horny > anuta['horny'] and girl_orgasm = 0 or horny < anuta['horny'] and you_orgasm = 1:
			act 'Полизать ей': gt'anuta_events','ukuni'
			act 'Вставить ей бутылку в киску': gt'anuta_events','bvag'
			act 'Вставить ей бутылку в попку': gt'anuta_events','banal'
		elseif horny < anuta['horny'] and you_orgasm = 0 or horny > anuta['horny'] and girl_orgasm = 1:
			act 'Дать полизать киску': gt'anuta_events','kuni'
			act 'Дать полизать попку': gt'anuta_events','anuli'
			if vgape < 2:act 'Попросить вставить бутылку вам в киску': gt'anuta_events','ubvag'
			if agape < 2:act 'Попросить вставить бутылку вам в попу': gt'anuta_events','ubanal'
			if agape < 2:act 'Сесть попой на бутылку': gt'anuta_events','ubsit'
		else
			act 'Потереться кисками': gt'anuta_events','sex'
		end
	else
		act 'Далее': gt'anuta_events','end'
	end
end
$text = ''
$text[1] = 'Уткнувшись лицом между её ног, вы '+iif(lesbian < 20,'неумело','умело')+' лижете её киску, проводя '+iif(lesbian < 20,'неопытным ','')+'язычком по всей длине писи'+iif(lesbian < 20,'',', не забывая про клитор')+', '
$text[2] = 'Вы '+iif(lesbian < 20,'несмело ','')+'цeлуете её писeчку, пoсaсывaя половые губки, иногда '+iif(lesbian < 20,'задевая неопытным язычкoм клитoр','проникая своим язычком между ними, касаетесь клитора,')+', '
$text[3] = 'Вы '+iif(lesbian < 20,'осторожно','быстро')+' водите '+iif(lesbian < 20,'неопытным','умелым')+' язычком сверху вниз, скользя '+iif(lesbian < 20,'по всей длине её писи','вдоль всей её промежности')+', '+iif(lesbian < 20,'иногда осторожно касаясь клитoра','проникая в вагину и лаская её клитор')+', '
$text[4] = 'Раздвинув пальцами половые губки, она умело лижет, проводя язычком по всей длине вашей писи и щекоча ваш клиторок, '
$text[5] = 'Она цeлует вашу писeчку, пoсaсывaя ee губки, иногда пытаясь проникнуть шаловливым язычкoм в вашу <<$vaginatipe2>> вагину, '
$text[6] = 'Она быстро водит умелым язычком сверху вниз, по всей длине вашей писи, иногда делая круговые движения, и нежно касаясь клитoра, '
$text[7] = 'Раздвинув пальцами ваши ягодицы, она умело лижет ваш <<$anustipe>> анус, '
$text[8] = 'Она лижет ваш анус, иногда '+iif(anus <= 10,'пытаясь проникнуть',iif(anus <= 15,'проникая','легко проникая'))+' шаловливым язычкoм внутрь вашей <<$anustipe3>> попы, '
$text[9] = 'Она быстро водит умелым язычком сверху вниз по вашему анусу, иногда делая круговые движения, '
$text[10] = 'Вы берете бутылку и засовываете горлышко в её киску, девушка целует вас, пока вы одной рукой управляете бутылкой, а второй ласкаете её грудь, '
$text[11] = 'Взяв в руку бутылку, вы засовываете горлышко в её киску, а второй начинаете ласкаете её грудь, одновременно впиваясь в губы жарким поцелуем, '
$text[12] = 'Вы берете в руку бутылку, и засунув горлышко в её киску, начинаете двигать туда-сюда, одновременно лаская её грудь второй рукой, '
$text[13] = 'Вы берете бутылку, '+iif(lubri > 0,'смазываете лубрикантом','облизываете горлышко, стараясь оставить на нём максимальное количество слюны')+', и аккуратно вводите в анус девушки, начиная трахать её зад бутылкой, '
$text[14] = 'Взяв в руку бутылку, вы '+iif(lubri > 0,'смазываете её лубрикантом','старательно облизываете её горлышко, стараясь оставить на нём максимальное количество слюны')+', и аккуратно введя в анус девушки, начинаете трахать её зад бутылкой, '
$text[15] = 'Вы берете бутылку, '+iif(lubri > 0,'смазываете её лубрикантом','старательно облизываете её горлышко, стараясь получше смочить')+', и аккуратно введя в анус девушки, начинаете трахать её зад бутылкой, '
$text[16] = iif(horny < 60,'вызывая бурю эмоций внизу живота.',iif(horny < 80,'вызывая у вас стоны наслаждения. ','срывая с ваших губ стоны наслаждения и заставляя двигаться бедрами навстречу. '))
$text[17] = iif(anuta['horny'] < 60,'заставляя вздрагивать всем телом, при каждом прикосновении.',iif(anuta['horny'] < 80,'срывая с её губ стоны наслаждения. ','заставляя выгибаться всем телом и страстно стонать. '))
$text[18] = 'Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас, и все ваше тело охватывают горячие волны оргазма. Вы невольно кричите от удовольствия, извиваясь и вздрагивая всем телом.'
$text[19] = 'Через некоторое время <<$boy>> задрожала всем телом,  выгнулась в оргазме, и уже не сдерживаясь застонала во весь голос.'
$text[20] = 'Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас и все ваше тело охватывают горячие волны оргазма. Одновременно вы замечаете, что <<$boy>> задрожала всем телом и ее киска начала ритмично пульсировать. Она выгнулась в оргазме и уже не сдерживаясь застонала во весь голос.'
if $ARGS[0] = 'ukuni':
	*clr & cla
	anuta['horny'] += iif(lesbian < 20,10,20)
	gs 'zz_render', '', 'images/city/south/lake/anuta/ukuni'+iif(anuta['horny'] < 100,rand(1,3),4)+'.jpg','Вы целуете ей грудь, постепенно спускаясь все ниже и ниже, пока не доходите до её '+iif(anuta['horny'] < 50,'',iif(anuta['horny'] < 70,'возбуждённой','текущей'))+'киски. ' + $text[rand(1,3)] + $text[17] + $text[iif(anuta['horny'] < 100,'',19)]
	if anuta['horny'] >= 100: girl_orgasm = 1 & anuta['horny'] = 0
	gs'anuta_events','variant'
end
if $ARGS[0] = 'kuni':
	*clr & cla
	kuni += 1
	horny += rand(15,25)
	gs 'zz_render', '', 'images/city/south/lake/anuta/kuni'+iif(horny < 100,rand(1,2),3)+'.jpg','<<$boy>> проводит языком по вашим бедрам, целует лобок и спускается к вагине. '+$text[rand(4,6)] + $text[16] + $text[iif(horny < 100,'',18)]
	if horny >= 100: horny = 0 & orgasm += 1 & you_orgasm = 1
	gs'anuta_events','variant'
end
if $ARGS[0] = 'anuli':
	*clr & cla
	horny += rand(10,20)
	gs 'zz_render', '', 'images/city/south/lake/anuta/anuli'+iif(horny < 100,rand(1,3),rand(4,5))+'.jpg', $text[rand(7,9)] + $text[16] + $text[iif(horny < 100,'',18)]
	if horny >= 100: horny = 0 & orgasm += 1 & you_orgasm = 1
	gs'anuta_events','variant'
end
if $ARGS[0] = 'bvag':
	*clr & cla
	anuta['horny'] += 20
	gs 'zz_render', '', 'images/city/south/lake/anuta/bvag'+iif(anuta['horny'] < 100,rand(1,2),3)+'.jpg', $text[rand(10,12)] + $text[17] + $text[iif(anuta['horny'] < 100,'',19)]
	if anuta['horny'] >= 100: girl_orgasm = 1 & anuta['horny'] = 0
	gs'anuta_events','variant'
end
if $ARGS[0] = 'banal':
	*clr & cla
	i = rand(1,2)
	anuta['horny'] += 10
	gs 'zz_render', '', 'images/city/south/lake/anuta/banal'+iif(i = 1,iif(anuta['horny'] < 100,1,2),iif(anuta['horny'] < 100,rand(4,5),6))+'.jpg', $text[rand(13,15)] + $text[17] + $text[iif(anuta['horny'] < 100,'',19)]
	if anuta['horny'] >= 100: girl_orgasm = 1 & anuta['horny'] = 0
	gs'anuta_events','variant'
end
if $ARGS[0] = 'ubvag':
	*clr & cla
	if ubvag = 0: ubvag = 1 & sex += 1
	you_orgasm = orgasm
	gs 'zz_render', '', 'images/city/south/lake/anuta/ubvag'+iif(horny < 60,1,iif(horny < 80,2,iif(horny < 100,3,4)))+'.jpg'
	gs 'zz_dynamic_sex','sex_start', 1
	gs 'zz_dynamic_sex','vaginal','girl_bottle'
	you_orgasm = iif(you_orgasm > orgasm,1,0)
	gs'anuta_events','variant'
end
if $ARGS[0] = 'ubanal':
	*clr & cla
	if ubanal = 0: ubanal = 1 & anal += 1
	you_orgasm = orgasm
	gs 'zz_render', '', 'images/city/south/lake/anuta/ubanal'+iif(horny < 100,rand(1,4),5)+'.jpg'
	gs 'zz_dynamic_sex','anal_start','girl_bottle'
	gs 'zz_dynamic_sex','anal','girl_bottle'
	you_orgasm = iif(you_orgasm > orgasm,1,0)
	gs'anuta_events','variant'
end
if $ARGS[0] = 'ubsit':
	*clr & cla
	if ubanal = 0: ubanal = 1 & anal += 1
	gs 'zz_render', '', 'images/city/south/lake/anuta/ubsit'+iif(horny < 100,rand(1,2),3)+'.jpg'
	gs 'zz_dynamic_sex','anal_start','bottle'
	gs 'zz_dynamic_sex','anal','bottle'
	you_orgasm = iif(you_orgasm > orgasm,1,0)
	gs'anuta_events','variant'
end
if $ARGS[0] = 'sex':
	*clr & cla
	horny += rand(5,15)
	anuta['horny'] += iif(lesbian < 20,5,15)
	gs 'zz_render', '', 'images/city/south/lake/anuta/sex'+iif(horny < 100,1,2)+'.jpg', 'Вы сели напротив друг друга, сплели ваши ноги так, чтобы киски соприкасались, и начали двигать бедрами лаская друг друга, ' + $text[16] + $text[iif(horny < 100,'',20)]
	if horny >= 100: horny = 0 & orgasm += 1 & girl_orgasm = 1 & you_orgasm = 1 & anuta['horny'] = 0
	if anuta['horny'] >= 100: girl_orgasm = 1 & anuta['horny'] = 0
	gs'anuta_events','variant'
end
if $ARGS[0] = 'end':
	*clr & cla
	minut += 15
	ubanal = 0
	ubvag = 0
	you_orgasm = 0
	girl_orgasm = 0
	protect = 0
	gs'stat'
	gs 'zz_render', '', 'images/city/south/lake/anuta/end.jpg', 'Вы с Анютой уставшие, но весьма довольные, ещё какое-то время сидели рядом, отдыхая и лениво болтая о всяких пустяках. Наконец Анюта, глянув на часы, сказала что ей пора уходить и стала одеваться.**<do>- '+iif(anuta['sex'] = 1,'Я тут, на пляже, часто бываю в хорошую погоду, приходи как-нибудь','До скорой встречи, <<$name[2]>>')+', -</do> сказала она вам и улыбнувшись на последок ушла.'
	act 'Уйти': gt 'nudelake'
end