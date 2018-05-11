$loc = $curloc
$metka = ''
if $args[0] = 'main' or $args[0] = '' or $args[0] = '0' or $args[0] = '4':
	*clr & cla
	killvar '_from'
	if $args[0] = '0' or $args[0] = '4':
		_nroad = val($args[0])
	else
		_nroad = val($args[1])
	end
	! очистка корзины с грибами
	if _nroad = 0 or _nroad = 4: gs 'gadukino_event','clearing_basket'
	!---
	gs 'stat'
	gs 'time'
	gs 'zz_render','Трасса М-7 - <<_nroad*10>> километр',func('zz_funcs','mk_image','pavlovo/road/road')
	if _nroad > 0 and _nroad < 4:
		gs 'zz_render','','','Неподалеку от трассы находится '+iif(cloth[0] > 2,'<a href="exec: _from = _nroad & gs''zz_train'',''train_tickets''">железнодорожный полустанок.</a>','железнодорожный полустанок.')
	end
	if _nroad = 0:
		act 'Идти в Сити': minut += rand(10,15) & killvar '_nroad' & gt 'north'
		gs 'zz_render','','','Окраина Северного района города.'
	elseif _nroad = 1:
		act 'Идти в дачный кооператив': minut += rand(10,15) & killvar '_nroad' & gt 'dachi'
		gs 'zz_render','','','Рядом с полустанком разместился дачный кооператив.'
	elseif _nroad = 2:
		if cloth[0] > 2:
			act 'Идти в Гадюкино': minut += rand(10,15) & killvar '_nroad' & gt 'gadukino'
			gs 'zz_render','','','От полустанка ведет грунтовая дорога к деревне Гадюкино.'
		else
			act 'Идти в Гадюкино': minut += rand(15,30) & killvar '_nroad' & gt 'gadukino_event','gadukino_back'
			gs 'zz_render','','','<b>У вас неподобающий вид, для прогулки по деревне, можно пробраться огородами.</b>'
		end
	elseif _nroad = 4:
		act 'Идти в Павлово': minut += rand(10,15) & killvar '_nroad' & gt 'gorodok'
		gs 'zz_render','','','Окраина провинциального городка Павлово.'
	end
	! пешие прогулки
	if cloth[0] > 2:
		if _nroad < 4:
			act 'Идти в сторону <b>Павлово</b>': minut += 120 & gt 'road','main','<<_nroad+1>>'
			if shameless['flag'] > 0: act 'Голосовать в сторону <b>Павлово</b>': gt 'road','hitchhiking'
		end
		if _nroad > 0:
			act 'Идти в сторону <b>Сити</b>': minut += 120 & gt 'road','main','<<_nroad-1>>'
			if shameless['flag'] > 0: act 'Голосовать в сторону <b>Сити</b>': gt 'road','hitchhiking'
		end
	end
end
!---
if $args[0] = 'hitchhiking':
	*clr & cla
	minut += rand(10,15)
	gs 'stat'
	if rand(0,100) < 50:
		gs 'zz_render','Трасса М-7',func('zz_funcs','mk_image','pavlovo/road/hitchhiking'),'Вы голосуете, но машины просто проносятся мимо, не обращая на вас никакого внимания.'
		act 'Далее': gt 'road','main','<<_nroad>>'
	else
		! 0 - фура, 1 - легковушка
		_driver[0] = rand(0,1)
		_driver[1] = rand(0,1)
		gs 'zz_render','','pavlovo/road/<<_driver[0]>><<_driver[1]>>','Возле вас остановилась '+iif(_driver[0]=0,'огромная фура','машина')+' и из окна на вас выглянул мужчина:**\\\- Девушка, куда путь держим?///'
		if _nroad ! 2: act 'Попросить отвезти вас до Гадюкино': gt 'road','payment',2
		if _nroad < 4: act 'Попросить отвезти вас до Павлово': gt 'road','payment',4
		if _nroad > 0: act 'Попросить отвезти вас в Сити': gt 'road','payment',0
	end
end
!---
if $args[0] = 'payment':
	*clr & cla
	_where = args[1]
	_dest = iif(_where > _nroad,_where - _nroad,_nroad - _where)
	if rand(0,10) mod 5 = 0:
		_price = 0
	else
		_price = _dest * iif(vnesh < 40,2,1)*100
	end
	gs 'zz_render','','pavlovo/road/<<_driver[0]>><<_driver[1]>>','Водитель осматривает вас оценивающим взглядом:**'+iif(_price = 0,'\\\- Садись, подвезу!///','\\\- <<_price>> рублей и поехали!///')
	! варианты ответа
	gs 'road','ans_variants'
	if dom >= 10 and _price > 0:
		act 'Попросить снизить цену':
			*clr & cla
			gs 'zz_render','','pavlovo/road/<<_driver[0]>><<_driver[1]>>','Вы кокетливо играя волосами и стреляя глазками просите снизить цену:**\\- Бли-и-ин, так дорого... а может можно как-то дешевле?//'
			gs 'road','ans_variants'
			i = rand(0,10)
			if vnesh >= 40 and i <= 4:
				cla
				gs 'zz_render','','','\\\- Могу вообще бесплатно, но только если отработаешь.///**\\- Каким образом?// - спрашиваете вы.**\\\- Сама знаешь, уже взрослая девочка.///'
				act 'Отказаться':
					gs 'road','clearing'
					gt 'road','main','<<_nroad>>'
				end
				act 'Могу, но только ручками':
					*clr & cla
					gs 'zz_render','','pavlovo/road/<<_driver[0]>><<_driver[1]>>','\\\- Хм... Ну давай, садись в машину тогда.///'
					act 'Сесть в машину': gt 'road','hj'
				end
				if shameless['flag'] > 1:
					act 'Минет - это максимум!':
						*clr & cla
						gs 'zz_render','','pavlovo/road/<<_driver[0]>><<_driver[1]>>','\\\- Хм... Ну давай, садись в машину тогда.///'
						act 'Сесть в машину': gt 'road','bj'
					end
				end
			elseif i mod 3 = 0:
				_price -= 100
				gs 'zz_render','','','Он еще раз оценивающе вас осматривает:**\\\- Так и быть, за <<_price>> подвезу.///'
			else
				gs 'zz_render','','','\\\- Не, <<_price>> или добирайся пешком.///'
			end
		end
		if shameless['flag'] > 1:
			act 'Предложить минет':
				*clr & cla
				gs 'zz_render','','pavlovo/road/<<_driver[0]>><<_driver[1]>>','\\\- Хм... Ну давай, садись в машину тогда.///'
				act 'Сесть в машину': gt 'road','bj'
			end
		end
	end
end
!---
if $args[0] = 'ans_variants':
	act 'Отказаться':
		gs 'road','clearing'
		gt 'road','main','<<_nroad>>'
	end
	if money >= _price:
		act 'Ехать':
			minut += _dest*10
			money -= _price
			_nroad = _where
			gs 'road','clearing'
			gt 'road','main','<<_nroad>>'
		end
	end
end
!---
if $args[0] = 'clearing':
	killvar '_driver'
	killvar '_where'
	killvar '_dest'
	killvar '_price'
end
!---
if $args[0] = 'hj':
	*clr & cla
	horny += RAND(20,30)
	guy += 1
	cumfrot += 1
	minut += rand(10,20)
	gs 'stat'
	gs 'zz_render','','pavlovo/road/hj.gif','Как только вы садитесь в машину, молча не дожидаясь приглошения начинаете расстегивать ему ширинку и достаете член.
	Немного поработав ручками, вы привели его в стоячее положение. Вы принялись усердно надрачивать его и немного мять ладошкой. Пикантность ситуации вас не на шутку возбудила и вы с неприкрытым старанием начали надрачивать ему.
	Вскоре, ваши старания увенчались успехом и член начал извергаться прямо на вас, попадая на одежду.'
	act 'Ехать дальше':
		_nroad = _where
		gs 'road','clearing'
		gt 'road','main','<<_nroad>>'
	end
end
!---
if $args[0] = 'bj':
	*clr & cla
	horny += RAND(20,30)
	minut += rand(10,20)
	guy += 1
	bj += 1
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'stat'
	gs 'zz_render','','pavlovo/road/bj.gif','Как только вы садитесь в машину, молча не дожидаясь приглошения начинаете расстегивать ему ширинку и достаете член.
	Немного поработав ручками, вы привели его в стоячее положение, опустили голову и обхватили его губками.
	Вы принялись усердно сосать, заглатывая и лаская его язычком. Пикантность отсоса незнакомцу вас не на шутку возбудила и вы с неприкрытым удовольствием начали заглатывать его как можно глубже.**Вскоре, ваши старания увенчались успехом и член начал извергаться прямо у вас во рту теплой спермой, которую вы исправно всю проглотили.'
	act 'Ехать дальше':
		_nroad = _where
		gs 'road','clearing'
		gt 'road','main','<<_nroad>>'
	end
end