! $npc['31,qwTanyaMain']
! 0 - не начат
! 1 - первое подглядываение в душе в фитнесс-центре
! 2 - втрое подглядывание
! 3 - третье подглядывание
! 10 - ГГ работет в квартире Тани, платит отец Тани по субботам, деньги оставляет в зале после
! 20,30,40 - ГГ получает выговоры от отца Тани
! 50 - ГГ уволена, квартира Тани закрыта
! ---
! расписание Тани
! 0 - 8 - в комнате
! 8 - на кухне
! Пн - Пт:
! 9 - 17 - в сексшопе
! 18 - 20 - бегает в парке
! 21 - на кухне
! 22 - 24 - в комнате
! Сб - Вс:
! 9 - 12 - где-то в городе
! 12 - 14 - фитнесс-центр
! 15 - 16 - в комнате
! 17 - 18 - в зале, болтает с отцом или смотрит телик
! 19 - 24 - где-то в городе
! ---
! переменные
! $npc['31,meet_day'] - день последней встречи
! $npc['31,clean_day'] - день уборки
! $npc['31,punish_day'] - день наказания
! $npc['31,candle_day'] - флаг забавы со свечками, 0/1
!---
! встреча в парке
if $args[0] = 'park_meet':
	*clr & cla
	gs 'zz_render','','city/center/tanya/cross0.jpg',func('tanya_events_str',0)
	act 'Ну и пусть себе бежит':
		$npc['31,meet_day'] = day
		gt 'zz_park'
	end
	act 'Обогнать':
		*clr & cla
		minut += rand(3,7)
		gs 'stat'
		gs 'zz_render','','city/center/tanya/cross1.jpg',func('tanya_events_str',1)
		act 'Отдышаться':
			*clr & cla
			gs 'zz_render','','city/center/tanya/cross2.jpg',func('tanya_events_str',2)
			act 'Ах ты, сука!':
				*clr & cla
				gs 'zz_render','','common/fight/win4.jpg',func('tanya_events_str',3)
				act 'Хм-м':
					*clr & cla
					minut += rand(5,10)
					gs 'stat'
					gs 'zz_render','','city/center/tanya/cross2.jpg',func('tanya_events_str',4)
					act 'Идти к Тане':
						*clr & cla
						minut += rand(20,40)
						gs 'npc_editor','change_rep','+',31,10
						gs 'stat'
						gs 'zz_render','','city/center/tanya/hall.jpg',func('tanya_events_str',5)
						act 'В комнату Тани': gt 'tanya_events','tanya_selfplay'
					end
				end
			end
		end
	end
end
! первое развлечение с Таней
if $args[0] = 'tanya_selfplay':
	*clr & cla
	_zz_stage = args[1]
	gs 'stat'
	gs 'zz_render','','city/center/tanya/selfplay'+_zz_stage,func('tanya_events_str',6+_zz_stage)
	act 'Дальше':
		minut += rand(2,5)
		horny += rand(5,15)
		if _zz_stage = 4:
			gs 'npc_editor','change_rep','+',31,10
			killvar '_zz_stage'
			$npc['31,qwTanyaMain'] = 10
			gt 'tanya_apartment'
		else
			! ставим флаг, чтобы не получить выговор от отчима Тани в первый же день
			$npc['31,clean_day'] = day
			gt 'tanya_events','tanya_selfplay',_zz_stage+1
		end
	end
end
! встреча в фитнесс-клубе
if $args[0] = 'fitness_meet':
	*clr & cla
	if $npc['31,qwTanyaMain'] < 10: $npc['31,qwTanyaMain'] += 1
	$npc['31,meet_day'] = day
	! первая встреча в фитклубе
	if $npc['31,qwTanyaMain'] = 1:
		gs 'zz_render','','city/center/tanya/fit_meet0.jpg',func('tanya_events_str',31)
		act '...': gt $loc,$metka
	elseif $npc['31,qwTanyaMain'] = 2:
		! вторая встреча в фитклубе
		gs 'zz_render','','city/center/tanya/fit_meet1.jpg',func('tanya_events_str',32)
		act '...': gt $loc,$metka
	elseif $npc['31,qwTanyaMain'] = 3:
		! третья встреча в фитклубе
		gs 'zz_render','','city/center/tanya/fit_meet2.jpg',func('tanya_events_str',33)
		act '...': gt $loc,$metka
	else
		! четвертая встреча, открывается доступ к квартире Тани
		gs 'zz_render','','city/center/tanya/fit_meet3.jpg',func('tanya_events_str',34)
		act '...':
			*clr & cla
			gs 'zz_render','','city/center/tanya/fit_meet4.jpg',func('tanya_events_str',35)
			act '...':
				*clr & cla
				minut += rand(15,30)
				gs 'stat'
				gs 'npc_editor','change_rep','+',31,10
				gs 'zz_render','','city/center/tanya/fit_meet5.jpg',func('tanya_events_str',36)
				act 'В комнату Тани': gt 'tanya_events','tanya_selfplay'
			end
		end
	end
end
! плановые забавы с Таней
if $args[0] = 'punish':
	*clr & cla
	_zz_stage = args[1]
	gs 'stat'
	gs 'zz_render','','city/center/tanya/punish1/'+_zz_stage,func('tanya_events_str',11+_zz_stage)
	act 'Дальше':
		minut += rand(2,5)
		horny += rand(3,7)
		if _zz_stage = 10:
			gs 'npc_editor','change_rep','+',31,10
			$npc['31,punish_day'] = daystart
			killvar '_zz_stage'
			gt 'tanya_apartment'
		else
			gt 'tanya_events','punish',_zz_stage+1
		end
	end
end
! усиленные плановые забавы с Таней
if $args[0] = 'punish2':
	*clr & cla
	_zz_stage = args[1]
	gs 'stat'
	gs 'zz_render','','city/center/tanya/punish2/'+_zz_stage+'.webm',func('tanya_events_str',22+_zz_stage)
	act 'Дальше':
		minut += rand(2,5)
		horny += rand(3,7)
		if _zz_stage = 7:
			horny = 0
			manna += rand(10,20)
			orgasm += 1
			lesbian += 1
			if $npc['31,sex'] = 0: girl += 1
			$npc['31,sex'] += 1
		end
		if _zz_stage = 8:
			gs 'npc_editor','change_rep','+',31,10
			$npc['31,punish_day'] = daystart
			killvar '_zz_stage'
			gt 'tanya_apartment'
		else
			gt 'tanya_events','punish2',_zz_stage+1
		end
	end
end
! болтовня
if $args[0] = 'talk':
	*clr & cla
	gs 'npc_editor','get_npc_profile',31
	act 'Поболтать':
		minut += rand(5,10)
		gs 'npc_editor','change_rep','+',31
		gs 'stat'
		killvar '$_str'
		$_str[0] = 'Таня рассказывает, что ее отчим заходит к ней в гости днем в среду и субботу.'
		$_str[1] = 'Таня рассказывает вам забавную историю из сексшопа: \\\"Стою как-то, никого не трогаю. Заходит мужик: явно стремается, ни на кого не глядит. Выбирает латексные трусы себе, и подходит по мне, пробивать, значится./// Глаза поднимает, расплачиваясь: \\\"Таня?"/// Я - \\\"Дядя???"/// - дядька мой смотрит на меня, выпучив глаза. А на работе - суровый начальник! - хихикает Танька. - Он аж про сдачу забыл: \\\"Ты меня не видела!"///'
		$_str[2] = 'Таня рассказывает вам, что в подвале сексшопа хозяин оборудовал кабинки с глорихолом.'
		$_str[3] = '\\\Тут порой такие чудики приходят, что ах оторопь берёт.///'
		$_str[4] = 'Таня рассказывает:**\\\Заходит сегодня в магазин какой-то гусь, и прям с места в карьер:**- Девушка, давайте с вами переспим!**Я ему:**Молодой человек! У меня даже нет слов от такого нахальства.**А он такой:**А вы кивните!///'
		$_str[5] = 'бла-бла-бла-бла-бла-бла'
		$_str[6] = 'бла-бла-бла-бла-бла-бла-бла'
		$_str[7] = 'бла-бла-бла-бла-бла-бла-бла-бла'
		$_str[8] = 'бла-бла-бла-бла-бла-бла-бла-бла-бла'
		$_str[9] = 'бла-бла-бла-бла-бла-бла-бла-бла-бла-бла'
		gs 'zz_render','','',$_str[rand(0,arrsize('$_str')-1)]
		killvar '$_str'
	end
	act 'Отойти': gt $loc,$metka
end
! Светка получает выговор от отца Тани если в квартире не убрано
if $args[0] = 'check_room':
	if (week = 3 or week = 6) and hour >= 13 and hour <= 18 and $npc['31,clean_day'] ! day:
		*clr & cla
		$npc['31,qwTanyaMain'] += 10
		if $npc['31,qwTanyaMain'] >= 50:
			! выгоняем Светку
			gs 'zz_render','Фотка злого папика','','\\\- Света, почему в квартире так грязно? Разве за это я вам плачу? Всё, моё терпение лопнуло, вы уволены. Собирайте вещи и на выход!///'
			act 'Собрать вещи и уйти':
				! если ГГ голая - принудительно одеваем
				if cloth[0] < 3: gs 'zz_clothing2','fix_emergency'
				minut += rand(30,50)
				gt 'center'
			end
		else
			gs 'zz_render','Фотка злого папика','','\\\- Света, почему в квартире так грязно? Разве за это я вам плачу?///'+iif(cloth[0] < 3,'**\\\- И накиньте на себя что-нибудь, хотя бы пока я здесь!///','')
			act 'Убираться': gt 'tanya_events','clean_room'
		end
	end
end
! уборка
if $args[0] = 'clean_room':
	*clr & cla
	minut += rand(50,70)
	sweat += 1
	gs 'stat'
	$npc['31,clean_day'] = day
	gs 'zz_render','','','Вы около часа занимаетесь уборкой квартиры.'
	act 'Закончить': gt $loc,$metka
end
! Таня звонит и напрашивается на наказание
if $args[0] = 'tanya_call_check':
	if $npc['31,qwTanyaMain'] >= 10 and $npc['31,qwTanyaMain'] <= 50 and $npc['31,punish_day'] >= 7 and $npc['31,meet_day'] ! day and func('zz_weather','is_day') = 1:
		gt 'zz_phone','incoming_box','tanya_call','tanya_call_decline','images/common/npc/30.jpg','Таня'
	end
end
!
if $args[0] = 'tanya_call':
	*clr & cla
	gs 'zz_funcs','colorize_day'
	$_img = 'images/common/mobile/'
	gs 'zz_phone','header'
	$npc['31,candle_day'] = 1
	$npc['31,meet_day'] = day
	for i = 37 to 41:
		gs 'zz_phone','box_ext',iif((i - 37) mod 2,30,-1),func('tanya_events_str',i),(i - 37) mod 2
		wait 700
	end
end
!
if $args[0] = 'tanya_call_decline':
	$npc['31,meet_day'] = day
end
! забавы со свечкой
if $args[0] = 'tanya_candle':
	*clr & cla
	_stage = args[1]
	if _stage < 4:
		horny += 20
	elseif _stage = 4:
		horny = 0
		orgasm += 1
	end
	minut += rand(3,5)
	gs 'stat'
	gs 'zz_render','','city/center/tanya/punish3/<<_stage>>.webm',func('tanya_events_str',_stage + 42)
	act iif(_stage < 10,'...','Уйти'):
		if _stage < 10:
			gt 'tanya_events','tanya_candle',_stage+1
		else
			lesbian += 1
			dom += 5
			$npc['31,candle_day'] = 0
			$npc['31,punish_day'] = daystart
			minut += 5
			gt 'center'
		end
	end
end