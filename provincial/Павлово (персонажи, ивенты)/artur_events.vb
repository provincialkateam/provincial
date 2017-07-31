if $args[0] = '': $args[0] = 'home'
if $args[0] = 'home':
	arturKnow = 1
	minut += 60
	gs 'zz_funcs', 'alko', 6
	energy = 24
	water = 24
	body['day_weight'] += 1
	$boy = 'Артур'
	silavag = 1
	dick = 26
	cumlip = 0
	arturday = day
	! счетчик количества трахов с Артуром
	$npc['40,sex'] += 1
	! локальный счетчик количества актов
	artsextimes = 0
	gs 'stat'
	$_str = 'Артур отвёл вас на стоянку, где стояла его чёрная заниженная Приора. Вы сели в машину, и он куда-то повёз вас.<br><do>- Дэвачка, я дэлаю настоящий, правильний шашлык, как у нас на Кавказе в горах готовят для сэбя, а не как для турыстов, и ни то щто дрянь из кошек здэсь!</do><br>Через некоторое время машина остановилась возле небольшого, но хорошо отделанного домика, и горец, взяв вас за руку, проводил в дом.'
	$_str += 'Артур щедро накрыл на стол. Вы ели самый роскошный шашлык в своей жизни - горец не обманул. Готовил он его сам, добавляя травки и щедро поливая мясо вином из простой баклажки для аромата.<br><do>- Это вино - ни тэ помои, что видают за наще! Это - виращено моим дэдом в горах!</do><br>На столе появилась и обещанная чача. Вы быстро захмелели. Артур включил музыку и подошёл к вам:<br><do>- Иди ка мнэ, дэвочка!</do><br>'
	if $npc['40,sex'] = 0: $_str += 'Вы попросили его надеть презерватив, на что он возмутился:<br><do>- Вай, это как цилаваться в пративагазе! Нэт!</do><br>'
	$_str += 'Артур обнял вас и его руки начали снимать вашу одежду и ласкать ваше тело.'
	gs 'zz_render','','images/qwest/alter/artur/artur.jpg',$_str
	killvar '$_str'
	gs 'artur_events','sex_init'
end
if $args[0] = 'sex_init':
	! всего 3 акта на выбор
	act 'Минет': artsextimes += 1 & gt 'artur_events', 'suck'
	act 'В киску': artsextimes += 1 & gt 'artur_events', iif(rand(0,1)=0,'art_bed','art_bedmiss')
	if artsextimes > 0:
		*clr
		'<center><img src="images/qwest/alter/artur/bedmiss.jpg"></center>'
		! доступ к попке вначале закрыт
		act 'В попку': artsextimes += 1 & gt 'artur_events', iif($npc['40,sex'] >= 3 and rand(0,2) = 0,'art_anal_fist','art_anal')
	end
end
if $args[0] = 'suck':
	*clr & cla
	minut += 5
	bj += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/artur/bj.jpg','Вы сели на колени перед Артуром и стали дрочить его длинный и толстый член. Артур в нетерпении гладит вашу голову своей жилистой рукой.'
	act 'Сосать':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/artur/bj2.jpg','Вы открыли рот и обхватили своими губами здоровенный член и начали сосать, но Артур вскоре потерял терпение и схватил вас за волосы.'
		act 'Дальше': gt 'artur_events', 'facefuck'
	end
	act 'Дрочить':
		cla
		gs 'zz_render','','','Вы начали дрочить член и Артур тут же потерял терпение и схватил вас за волосы.'
		act 'Дальше': gt 'artur_events', 'facefuck'
	end
end
! --- минеты ---
if $args[0] = 'facefuck':
	*clr & cla
	minut += 5
	if throat < dick: throat += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/artur/facefuck'+RAND(0,5)+'.jpg','Артур схватил вас за волосы и просто насадил ваш рот на свой здоровенный член.'
	if throat < dick:
		gs 'zz_render','','','Вы задыхаетесь когда член с разгону залетает в ваше горло обдавая его огнем. Вас скручивает рвотный рефлекс.'
	else
		gs 'zz_render','','','Горло обдает огнем когда член Артура с разгону входит в ваше горло и ваш нос упирается в кучерявый лобок Артура.'
	end
	! после третьего секса с Артуром добавляем доп.вариации минета
	if $npc['40,sex'] >= 3:
		act 'Дальше': gt 'artur_events', iif(rand(0,1)=0,'artlick','artchik')
	else
		! иначе переброс на выбор вариаций
		act 'Дальше':  gt 'artur_events', iif(artsextimes < 3,'sex_init','bj_cum')
	end
end
if $args[0] = 'artlick':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/artur/lick.jpg','Артур достает свой член из вашего рта и начинает бить вам по губам, вы высовываете язык облизывая головку и здоровенный член колотит вам по языку и лицу.'
	act 'Дальше': gt 'artur_events', iif(artsextimes < 3,'sex_init','bj_cum')
end
if $args[0] = 'artchik':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/artur/chik.jpg','Артур засовывает вам свой член между щекой и зубами и легко ударяет ладонью вам по щеке.'
	act 'Дальше': gt 'artur_events', iif(artsextimes < 3,'sex_init','bj_cum')
end
if $args[0] = 'bj_cum':
	*clr & cla
	gs 'zz_render','','images/qwest/alter/artur/cum0.jpg','Артур внезапно зарычал, как раненый зверь, вытащил член с вашего рта и выдал струю спермы на ваше личико.'
	act 'Дальше':
		*clr & cla
		gs 'zz_render','','images/qwest/alter/artur/cum1.jpg','Затем еще одна струя спермы попадает вам в лицо.'
		act 'Дальше':
			*clr & cla
			gs 'zz_render','','images/qwest/alter/artur/cum2.jpg','Следующая струя спермы попадает вам на губы и в рот.'
			act 'Дальше':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/artur/cum3.jpg','Наконец то Артур прекращает кончать покрыв почти все ваше лицо своей горячей спермой.'
				act 'Дальше': gt 'artur_events','ender'
			end
		end
	end
end
! --- вагинал ---
if $args[0] = 'art_bed':
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/artur/sexdog.jpg','Артур кладет вас на кровать кверху попой, схватив рукой за волосы, и вы чувствуете как его твердый член упирается в вашу киску.'
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if artsextimes < 3:
		act 'Дальше': gt 'artur_events', 'sex_init'
	else
		cla
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Дальше': gt 'artur_events','ender'
	end
end
if $args[0] = 'art_bedmiss':
	*clr & cla
	minut += 5
	gs 'stat'
	pose = 0
	gs 'zz_render','','images/qwest/alter/artur/sexmiss.jpg','Артур кладет вас на кровать и забирается вам между ног и вы чувствуете как его твердый член упирается вам в киску.'
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if artsextimes < 3:
		act 'Дальше': gt 'artur_events', 'sex_init'
	else
		cla
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Дальше': gt 'artur_events','ender'
	end
end
! --- анал ---
if $args[0] = 'art_anal':
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/artur/anal.jpg','Артур хватает вас своими ладонями за попу и вы чувствуете как его твердый член упирается в ваш анус.'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	act 'Дальше':
		if artsextimes < 3:
			gt 'artur_events', 'sex_init'
		else
			*clr & cla
			gs 'zz_funcs', 'cum', 'anus'
			gs 'zz_render','','images/qwest/alter/artur/analcreampi.jpg','Через некоторое время Артур застонал и вы почувствовали как вашу попу наполняет тепло.'
			act 'Дальше': gt 'artur_events','ender'
		end
	end
end
if $args[0] = 'art_anal_fist':
	*clr & cla
	minut += 5
	gs 'stat'
	if anus >= 20:
		gs 'zz_render','','images/qwest/alter/artur/fist2.jpg','Артур засовывает вам два пальца в попу, потом добавляет еще палец, и еще и вскоре рука Артура уже полностью в вашей попе.'
		if anus < 30: anus += 1
	else
		gs 'zz_render','','images/qwest/alter/artur/fist.jpg','Артур засовывает вам в попу палец и начинает там энергично ковырять.'
		if anus < 20: anus += 1
	end
	act 'Дальше': gt 'artur_events', 'art_anal'
end
! --- конец ---
if $args[0] = 'ender':
	*clr & cla
	if mop = 0: mop = 1
	minut += 5
	artsextimes = 0
	pose = 0
	cumface = 0
	if RAND(0,5) = 0:
		kosmetica += 20
		$_str = 'Артур подарил вам набор косметики.'
	else
		money += 1000
		$_str = 'Артур сказал:<br><do>- Эээ, у мэня времени нэ было тэбе подарок искать, на тысячу, сама купи, что тэбе нравится.</do>'
	end
	gs 'zz_render','','images/qwest/alter/artur/artur.jpg','Артур встал с вас и тут же, как ни в чем не бывало, занялся делами.<br>Вы, как могли, привели себя в порядок и взглянули на него, выразительно хлопая глазами, от чего тот подскочил, как будто что-то вспомнил, метнулся резвым архаром в соседнюю комнату, и, спустя миг, вернулся, пряча что-то за спиной. ' + $_str
	killvar '$_str'
	gs 'stat'
	act 'Уйти': gt 'gorodok'
end
! ---
if $args[0] = 'suck_behind_kiosk':
	dick = 26
	arturday = day
	gs 'zz_render','','images/qwest/alter/artur/artur.jpg','Вместе с Артуром вы зашли в контейнер который используется как склад. Он тут же расстегнул ширинку: <br><do>- Давай '+replace($name[2],'е','э')+', поработай ротиком.</do>'
	act 'Опуститься на колени':
		*clr & cla
		$npc['40,sex'] += 1
		minut += 5
		bj += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/artur/cocksucer.jpg','Вы сели на колени перед Артуром и стали дрочить его длинный и толстый член.'
		gs 'zz_dynamic_sex', 'bj'
		act 'Сосать':
			*clr & cla
			minut += 5
			money += 300
			gs 'stat'
			gs 'zz_dynamic_sex', 'swallow'
			gs 'zz_render','','images/qwest/alter/artur/cocksuckercum.jpg','После этого Артур ухмыльнулся, заправил член в штаны и сказал:<br><do>- Вай '+replace($name[1],'е','э')+', ты настоящая соска. Вот тебе от дяди Артурчика, купи сэбэ конфэток.</do><br>Он протянул вам 300 рублей.'
			act 'Уйти': gt'grinok', 'main'
		end
	end
end