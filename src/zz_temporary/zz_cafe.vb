! общая локация - работа в кафе официанткой
!---
! индексы кафешек:
! 0 - DelParco
! 1 - кафешка Гиви в Южном районе
! 2 - шашлычная в Северном районе
!---
! cafe['<<_cafe_id>>,workday'] - счетчик работы за день
! cafe['<<_cafe_id>>,fail'] - количество прогулов или залетов, если больше 3 - увольнение
! cafe['<<_cafe_id>>,work'] - флаг работы ГГ:
!		0 - не работает
!		1 - работает
!		2 - уволена
!---------------
! args[1] - id кафешки
if $args[0] = 'init' or $args[0] = '':
	if $control_point = 'gorodok':
		_cafe_id = 0
	elseif $control_point = 'south':
		_cafe_id = 1
	else
		_cafe_id = 2
	end
	if cafe['<<_cafe_id>>,workday'] > 0 or cafe['<<_cafe_id>>,work'] = 2: exit
	if cafe['<<_cafe_id>>,work'] = 0:
		if hour >= 12 and hour <= 17: act 'Устроиться на работу': gt 'zz_cafe','hiring'
	else
		$loc = 'zz_cafe'
		$metka = $args[0]
		if week mod 2 = 0 and hour = 16 and minut <= 20:
			act 'Выйти на смену':
				*clr & cla
				minut += rand(10,15)
				gs 'zz_clothing2','redress',5
				gs 'stat'
				gs 'zz_render','','pavlovo/cafe/0','Вы переоделись и теперь готовы к работе.'
				act 'Идти работать': gt 'zz_cafe','work'
			end
		end
	end
end
! сброс счетчиков
if $args[0] = 'reset_work':
	cafe['0,workday'] = 0
	cafe['1,workday'] = 0
	cafe['2,workday'] = 0
end
! прием на работу
if $args[0] = 'hiring':
	*clr & cla
	gs 'zz_render','','pavlovo/cafe/2','\\- Здравствуйте, я по объявлению...// - неуверенно начали вы, войдя в кабинет хозяина кафешки.
	\\\- Какому еще объявлению?/// - даже не смотря в вашу сторону ответил мужчина.
	\\- Ну... Вам на работу нужны официантки... Вот, адресс ваш// - вы протянули мужчине листовку с объявлением.
	\\\- Ах, да, да... Совсем забыл.../// - все так же монотонно продолжал он.
	\\\- Смена с 16 часов и до закрытия, работать по ЧЕТНЫМ дням НЕДЕЛИ. Ты же отличаешь четные от нечетных? А то была тут до тебя дура. Уволил.../// - с неким удовольствием продолжал он.
	\\\- Так вот про увольнение - я люблю правила. Все должно быть четко.///'
	act 'Спросить о правилах':
		*clr & cla
		gs 'zz_render','','pavlovo/cafe/2','\\\- Улавливаешь на лету/// - хмыкнул хозяин, - \\\слушай внимательно, повторять не буду:
		1. Приходить вовремя - в 16 часов. Опоздаешь больше, чем на 20 минут - прогул.
		2. Выглядеть прилично - не надо мне тут клиентов распугивать: если не соответствуешь требованиям - идешь домой с прогулом впридачу.
		3. Работать только в форме - у нас здесь все прилично, знаешь ли...
		4. Не хамить клиентам, как бы они себя не вели.
		5. Больше трех залетов или погулов - до свидания.
		6. За смену получаешь 300 рублей плюс чаевые, также можешь перекусить на кухне.
		Надеюсь, я все ясно изложил. Согласна?///'
		act 'Да':
			*clr & cla
			cafe['<<_cafe_id>>,work'] = 1
			cafe['<<_cafe_id>>,workday'] = 4
			!---
			! добавляем форму в гардероб
			!---
			if func('zz_clothing2','get_wardrobe_id') = -1:
				gs 'zz_clothing2','add_to_wardrobe',5
				gs 'zz_clothing2','dispose'
			end
			!---
			gs 'zz_render','','pavlovo/cafe/2','\\\- Вот и хорошо, приходи на смену в следующий четный день.///'
			act 'Уйти': gt 'zz_cafe','go_out'
		end
		act 'Нет':
			*clr & cla
			gs 'zz_render','','pavlovo/cafe/2','\\\- Не смею больше задерживать. Выход найдешь сама!/// - грубо ответил вам хозяин кафешки.'
			act 'Уйти': gt 'zz_cafe','go_out'
		end
	end
end
! увольнение
if $args[0] = 'fired':
	if cafe['<<_cafe_id>>,fail'] > 3:
		cafe['<<_cafe_id>>,work'] = 2
		gs 'zz_render','','','\\\- Значит так - знать тебя больше не хочу, ты уволена! Собирай вещи и на выход!///'
	else
		gs 'zz_render','','','\\\- Пока предупреждаю! Последнее китайское! Вот честное слово - уволю!**Иди домой и хорошенько подумай над своим поведением!///'
	end
	act 'Уйти': gt 'zz_cafe','go_out'
end
! работа
if $args[0] = 'work':
	*clr & cla
	$metka = $args[0]
	gs 'stat'
	if vnesh < 40:
		cafe['<<_cafe_id>>,workday'] = 4
		cafe['<<_cafe_id>>,fail'] += 1
		gs 'zz_render','','pavlovo/cafe/<<_cafe_id>>/0','\\\- Эй, Света, ты чего, э-э-э, такая страшная сегодня? Забыла правила?///'
		gs 'zz_cafe','fired'
		exit
	end
	if cafe['0,workday'] = 2:
		gs 'zz_render','','pavlovo/cafe/<<_cafe_id>>/0','Перерыв. Можно и перекусить...'
		act 'Перекусить на кухне':
			*clr & cla
			minut += rand(10,15)
			gs 'zz_kitchen_acts', 'eat', 'lunch'
			gs 'zz_kitchen_acts', 'drink', 'tea'
			gs 'stat'
			act 'Работать дальше':
				cafe['<<_cafe_id>>,workday'] += 1
				gt 'zz_cafe','work'
			end
		end
		act 'Зайти к боссу':
			*clr & cla
			minut += rand(5,10)
			gs 'zz_render','','pavlovo/cafe/2','\\\- А, Света, это ты. Выкладывай, если что-то срочное, если нет - попрошу не мешать/// - не отрываясь от телефона вполголоса сказал босс.'
			act 'Уволиться':
				*clr & cla
				money += 200
				cafe['<<_cafe_id>>,work'] = 2
				gs 'zz_funcs','message','images/common/icons/money.png','<green>Вы получили <<cafe[''<<_cafe_id>>,payment'']>> руб.</green>'
				gs 'stat'
				gs 'zz_render','','pavlovo/cafe/2','\\\- Увольняешься значит? Хм, ну как хочешь. Вот рассчет, где выход - знаешь.///'
				act 'Уйти': gt 'zz_cafe','go_out'
			end
			act 'Идти работать':
				cafe['<<_cafe_id>>,workday'] += 1
				gt 'zz_cafe','work'
			end
		end
		act 'Работать дальше':
			cafe['<<_cafe_id>>,workday'] += 1
			gt 'zz_cafe','work'
		end
	elseif cafe['<<_cafe_id>>,workday'] >= 4:
		gs 'zz_render','','pavlovo/cafe/<<_cafe_id>>/0','На сегодня хватит! Пора домой.'
		act 'Переодеться и уйти':
			minut += rand(10,15)
			money += 300
				!статистика
				! 0 + 3 - DelParco
				! 1 + 3- кафешка Гиви в Южном районе
				! 2 + 3- шашлычная в Северном районе
				job_statistics[_cafe_id + 3 +',shift'] += 1
				job_statistics[_cafe_id + 3 +',money'] += 300
			gs 'zz_funcs','message','images/common/icons/money.png','<green>Вы получили 300 руб.</green>'
			gt 'zz_cafe','go_out'
		end
	else
		gs 'zz_render','','pavlovo/cafe/<<_cafe_id>>/0','"Чем заняться сейчас?**Простоять на кассе, делая кофе - спокойно, но без чаевых, или обслуживать столики?"'
		! работа без чаевых
		act 'Работать на кассе':
			*clr & cla
			minut += rand(60,90)
			cafe['<<_cafe_id>>,workday'] += 1
			gs 'zz_render','','pavlovo/cafe/<<_cafe_id>>/<<rand(1,3)>>','Вы работаете на кассе около полутора часа, готовя кофе зевакам, кторые, похоже, заходят попялиться на сиськи официанток, нежели за надобностью.'
			act 'Работать дальше': gt 'zz_cafe','work'
		end
		! здесь возможны чаевые
		act 'Обслуживать столики':
			*clr & cla
			minut += rand(60,90)
			cafe['<<_cafe_id>>,workday'] += 1
			oficiant += iif(oficiant < 50,1,rand(0,1))
			! здесь место для приключений на задницу ГГ
			if rand(0,10) < 3:
				! лапают Светку за попу
				gs 'zz_render','','pavlovo/cafe/3','Обслуживая столик, вы почувствовали, как чья-то рука залезла сам под юбку.'
				act 'Закатить скандал':
					*clr & cla
					cafe['<<_cafe_id>>,workday'] = 4
					cafe['<<_cafe_id>>,fail'] += 1
					gs 'zz_render','','pavlovo/cafe/1','\\\- Ты что себе надумала? Ты как с клиентами разговариваешь? Подумаешь, залез под юбку, большое дело.///'
					gs 'zz_cafe','fired'
				end
				act 'Дать по рукам':
					*clr & cla
					gs 'zz_render','','pavlovo/cafe/3','Вы звонко шлепнули по настырной руке, поглаживавшей вашу попу, отчего наглец и компания голосно засмеялись, как будто именно такого результата они и ожидали.'
					gs 'zz_cafe','tips'
				end
				if shameless['flag'] > 0:
					act 'Не обращать внимания':
						*clr & cla
						gs 'zz_render','','pavlovo/cafe/4','"Полапает и перестанет, с меня не убудет" - подумали вы, обслуживая посетителей.'
						gs 'zz_cafe','tips',2
					end
				end
			else
				! обычное обслуживание
				gs 'zz_render','','pavlovo/cafe/4','Вы без всяких эксцессов рассчитали компанию, заседавшую за столиком.'
				gs 'zz_cafe','tips'
			end
		end
	end
end
! чаевые
if $args[0] = 'tips':
	i = rand(0,(vnesh + oficiant)/20)*10*iif(args[1]>1,args[1],1)
	if i = 0:
		gs 'zz_render','','','Но увы, чаевых вам так и не оставили.'
	else
		gs 'zz_render','','','Вам оставили <<i>> руб. чаевых.'
		gs 'zz_funcs','message','images/common/icons/money.png','<green>+' + i + ' р.</green>'
		money += i
	end
		!статистика
		! 0 + 3 - DelParco
		! 1 + 3- кафешка Гиви в Южном районе
		! 2 + 3- шашлычная в Северном районе
		job_statistics[_cafe_id + 3 +',extramoney'] += 300
	act 'Работать дальше': gt 'zz_cafe','work'
end
! выход
if $args[0] = 'go_out':
	gs 'zz_clothing2','redress',cloth[3]
	! уход в зависимости от местоположения
	if _cafe_id = 0:
		killvar '_cafe_id'
		gt 'zz_park'
	else
		killvar '_cafe_id'
		gt $control_point
	end
end