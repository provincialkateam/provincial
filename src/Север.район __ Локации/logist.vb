!"---
Квест "КП Логистика"
Главная переменная - "logist". Определяет текущий статус отношений с работодателем.
 1 - прочла объявление, готова к прохождению собеседования - в связи с переездом в сев район - статус неактуален
 2 -
 3 - прошла собеседование, но в отделе кадров решила что подумает
 4 - сегодня устроилась на работу
 7 -
 10 - работает
moreman_rel - отношения с Боцманом.
logist_total_days - всего дней отработано в логистике.
logist_hours - определяет сколько часов осталось сегодня: отработать в логистике, а также статусы прогула и окончания работы
 4 - осталось 4 часа.
 -1 - день отработан полностью.
 -2 - день отработан полностью, отношения с Боцманом повышены, счетчик общего количества дней приращен. Это же значение устанавливается в stat при смене суток.
 -3 - сегодня был прогул.
logist_progul - общий счетчик прогулов.
Переменная uber['work'] - используется для проверки при устройстве на работу.
NinaQW - статус квеста с Ниной.
!---"
if $ARGS[0] = '':
!---
!КП Логистика. Общий коридор
!---
	*clr & cla
	if logist >= 10:
		*clr & cla
!Обработка прогулов
		if logist_day ! day and logist_progul < 3:
			logist_day = day
			logist_hours = 4
			if hour > 10:
				gt 'logist', 'work', 'late'
			else:
				logist_progul -= iif (logist_progul > 0, 1, 0)
			end
		end
!Интерфейс в общем корридоре
		if logist_progul > 2: gt 'logist', 'fired'
		if hour > 17 and logist_hours = -1:
			moreman_rel += iif (moreman_rel < 10, 1, 0)
			logist_total_days += 1
			logist_hours = -2
		end
		if hour < 20 and logist_hours ! -3:
			gs 'zz_render', '', 'images/city/north/skk/logistics/logist_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 1) _
			+ iif (hour < 18, ' Идти ' + '<a href="exec: gt ''logist'',''work''">работать</a>', ' Рабочий день окончен. Дней отработано: ' + logist_total_days + '. Прогулы: ' + logist_progul) + '.
			Вы можете пройти в' _
			+ ' <a href="exec: gt ''logist'',''priem''">приемную</a>' + ',' _
			+ ' <a href="exec: gt ''logist'',''ok''">отдел кадров</a>' + ',' _
			+ ' кабинет <a href="exec: gt ''logist'',''sb''">службы безопасности</a>' + ',' _
			+ ' <a href="exec: gt ''logist'',''server''">серверную</a>' + ',' _
			+ ' кабинет начальника <a href="exec: gt ''logist'',''soprovod''">Отдела логистики</a>' + ',' _
			+ ' в <a href="exec: gt ''logist'',''buhg''">бухгалтерию</a>' + ',' _
			+ ' к <a href="exec: gt ''logist'',''eksp''">экспедиторам</a>' + ',' _
			+ ' в <a href="exec: gt ''logist'',''toilet''">туалет</a>' + ',' _
			+ ' спуститься в <a href="exec: gt ''logist'',''basement''">подвал</a>' + ' или' _
			+ ' <a href="exec: gt ''logist'',''cafe''">пойти в кафе</a>' + '.' _
			+ ' Вы видите <a href="exec: gt ''logist'',''talk'',''cleaner''">уборщицу</a>' + '.'
			act 'Выйти на улицу':
				if logist_day = day and logist_hours > 0:
					*clr & cla
					gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_2', 3)
					act 'Вернуться в офис "Логистики"': gt 'logist'
					act 'Всё равно выйти':
						logist_progul += 1
						logist_hours = -3
						gt 'skk', 'third_floor'
					end
				else:
					gt 'skk', 'third_floor'
				end
			end
		end
		if hour >= 20 and logist_day = day and logist_hours ! -3:
			gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 1)+' Идти '+func ('zz_funcs','mk_link',8,17,'работать','logist', 'work')+'. Пройти в '+func ('zz_funcs','mk_link',8,17,'отдел кадров','logist', 'ok')
			act 'Закончить рабочий день и выйти в СКК': gt 'skk', 'third_floor'
		elseif logist_hours = -3:
			gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_2', 4)+func ('zz_funcs','mk_link',0,0,' Выйти на улицу', 'skk', 'third_floor')+' или выйти '+func ('zz_funcs','mk_link',8,17,'в коридор.', 'skk', 'third_floor')
		end
	elseif logist = 4:
		if logist_day = day:
			*clr & cla
			gs 'zz_render', '', 'images/city/north/skk/logistics/logist_<<rand(1,2)>>.jpg', 'Вы только что устроились на работу. Ваша смена - в следующий будний день'
			act 'Выйти в СКК': gt 'skk', 'third_floor'
		else:
			logist = 10
			gt 'logist'
		end
	end
!---
!КП Логистика. Блок устройства на работу
!---
	if logist > 1 and logist < 4: gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 1)+' Пройти в '+func('zz_funcs','mk_link',8,17,'отдел кадров','logist','ok')+' Вы также можете '+func('zz_funcs','mk_link',0,0,'выйти на третий этаж СКК', 'skk', 'third_floor')+' или выйти '+func('zz_funcs','mk_link',8,17,'на третий этаж СКК.', 'skk', 'third_floor')
	if logist = 0 and day ! day_priem:
		gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png','У входа висит объявление: Требуется секретать в офис'
		act 'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_1',1)
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/city/north/skk/logistics/ok_1.jpg', func ('logist_strings','logist_1', 2)
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings','logist_1', 3)
					if uber['work'] = 3 or uber['work'] = 5:
						day_priem = day
						*clr & cla
						gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg'
						gs 'zz_render', '', '', func ('logist_strings','logist_1',4)
						act 'Уйти': gt 'skk', 'third_floor'
					else
						gs 'zz_render', '', '', func ('logist_strings','logist_1',5)
						act 'Далее':
							*clr & cla
							gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,3)>>.jpg', func ('logist_strings','logist_1', 6)
							act 'Далее':
								time += 30
								*clr & cla
								gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,3)>>.jpg', func ('logist_strings','logist_1', 7)
								act 'Уйти': gt 'skk', 'third_floor'
								act 'Подождать':
									*clr & cla
									logist = 1
									gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_1.jpg', func ('logist_strings','logist_1', 8)
									act 'Пойти за боцманом': gt 'logist', 'moreman_office'
								end
							end
						end
					end
				end
			end
		end
	elseif day_priem = day:
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/logist_1.png', func ('logist_strings','logist_7', 2)
		act 'Уйти': gt 'skk', 'third_floor'
	end
end
!---
!КП Логистика. Увольнение за прогулы
!---
if $ARGS[0] = 'fired':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_1', 17)
	logist = 0
	day_priem = day
	logist_progul = 0
	logist_hours = 0
	moreman_rel = 0
	logist_day = 0
	logist_total_days = 0
	act 'Выйти из офиса': gt 'skk', 'third_floor'
end
!---
!КП Логистика. Приемная
!---
if $ARGS[0] = 'priem':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,5)>>.jpg', func ('logist_strings','logist_0', 2) + ' Зайти в кабинет <a href="exec: gt ''logist'',''moreman_office''">директора</a>' + '.'
	if hour ! 12 and hour < 18:
		act 'Подойти к Лене':
			*clr & cla
			gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,5)>>.jpg', func ('logist_strings','logist_6', 1)
			act 'Выйти': gt 'logist'
		end
	end
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Офис Боцмана
!---
if $ARGS[0] = 'moreman_office':
	if logist = 1:
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_cabinet_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 9)
		act 'Слушать боцмана':
			*clr & cla
			gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_cabinet_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 10)
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 11)
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 12)
					act 'Идти в отдел кадров':
						logist = 2
						gt 'logist', 'ok'
					end
				end
			end
		end
	end
!	else
!		*clr & cla
!		gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_cabinet_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 10)
!	end
	if logist >= 10:
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_cabinet_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 3)
		if hour ! 12 and hour < 18:
			act 'Подойти к директору': gt 'logist', 'talk', 'moreman'
		end
		act 'Выйти': gt 'logist'
	end
end
!---
!КП Логистика. Отдел кадров
!---
if $ARGS[0] = 'ok':
	if logist = 2:
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings','logist_1', 13)
	end
	if logist = 3:
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings','logist_1', 16)
	end
	if logist < 10:
		act 'Согласиться (к постоянной работе)':
			*clr & cla
			logist = 4
			logist_day = day
			logist_moreman_rel = 0
			logist_total_days = 0
			gs 'zz_render', '', 'images/city/north/skk/logistics/logist_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 14)+' Вы можете '+func('zz_funcs','mk_link',0,0,'выйти на улицу.', 'skk', 'third_floor')+' или вернуться '+func('zz_funcs','mk_link',8,17,'обратно в офис.', 'skk', 'third_floor')
		end
		act 'Отказаться':
			*clr & cla
			logist = 3
			gs 'zz_render', '', 'images/city/north/skk/logistics/logist_<<rand(1,2)>>.jpg', func ('logist_strings','logist_1', 15)+' Вы можете '+func('zz_funcs','mk_link',0,0,'выйти на улицу.', 'skk', 'third_floor')+' или вернуться '+func('zz_funcs','mk_link',8,17,'обратно в офис.', 'skk', 'third_floor')
		end
	elseif logist > 2:
		gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg'
		act 'Выйти': gt 'logist'
	end
	if logist >= 10:
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/ok_1>>.jpg', func ('logist_strings','logist_0', 4)
		if hour ! 12 and hour < 18:
			act 'Подойти к Нине Сергеевне':
				*clr & cla
				gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings','logist_7', 1)
				act 'Выйти': gt 'logist'
			end
		end
		if hour > 17 and hour < 21:
			act 'Подойти к Нине Сергеевне и Игорю':
				*clr & cla
				if hour < 18:
					gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings', 'logist_4', 2)
				else:
					gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings', 'logist_5', 2)
				end
				act 'Выйти': gt 'logist'
			end
		end
		act 'Выйти': gt 'logist'
	end
end
!---
!КП Логистика. Отдел сопровождения грузов
!---
if $ARGS[0] = 'soprovod':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 5)
	if hour ! 12 and hour < 18:
		act 'Подойти к Николаю Семеновичу': gt 'logist', 'talk', 'ignatiev'
	end
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Бухгалтерия
!---
if $ARGS[0] = 'buhg':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 6)
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Экспедиторы
!---
if $ARGS[0] = 'eksp':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 7)
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Служба безопасности
!---
if $ARGS[0] = 'sb':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 8)
	if hour ! 12 and hour > 15 and hour < 18:
		act 'Подойти к Виктору Афанасьевичу':
			*clr & cla
			gt 'logist', 'talk', 'sb'
		end
	end
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Серверная
!---
if $ARGS[0] = 'server':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/server_1.jpg', func ('logist_strings','logist_0', 9)
	if hour ! 12 and hour < 18:
		act 'Подойти к Игорю - админу':
			*clr & cla
			gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings', 'logist_4', 5)
			act 'Выйти': gt 'logist'
		end
	end
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Туалет
!---
if $ARGS[0] = 'toilet':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/toilet_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 11)
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Подвал
!---
if $ARGS[0] = 'basement':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_0', 12)
	act 'Выйти': gt 'logist'
end
!---
!КП Логистика. Работа
!---
if $ARGS[0] = 'work':
	*clr & cla
	gs 'zz_render', '', 'images/city/north/skk/logistics/logist_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 5)
	if $ARGS[1] = 'late':
		*clr & cla
		gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,5)>>.jpg', func ('logist_strings','logist_2', 5)
		act  'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_2', 6)
			act 'Далее': gt 'logist'
		end
	end
	if hour < 18 and $ARGS[1] = '':
		act 'Работать один час':
			minut += 60
			if logist_hours >= 0: logist_hours -= 1
			*clr & cla
			if hour < 17:
				gs 'zz_render', '', 'images/city/north/skk/logistics/work_<<rand(1,1)>>.jpg', func ('logist_strings','logist_2', iif (logist_hours > 0, 1, 2))
			else
				gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings','logist_2', 7)
			end
			gs 'stat'
			cla
			act 'Далее': gt 'logist', 'work'
		end
		act 'Отойти от своего рабочего места': gt 'logist'
	elseif $ARGS[1] = '':
		act 'Отойти от своего рабочего места': gt 'logist'
	end
end
!---
!КП Логистика. Кафетерий
!---
if $ARGS[0] = 'cafe':
	if $ARGS[1] = '':
		*clr & cla
		if hour = 12:
			gs 'zz_render', func ('logist_strings', 'logist_0', 10), 'images/city/north/skk/logistics/cafe_<<rand(1,2)>>.jpg', func ('logist_strings','logist_3', 1) _
			+ ' <a href="exec: gt ''logist'',''cafe'',''cafe_talk'',''moreman''">Боцман-директор</a>,' _
			+ ' <a href="exec: gt ''logist'',''cafe'',''cafe_talk'',''nok'',''2''">Нина Сергеевна</a>,' _
			+ ' <a href="exec: gt ''logist'',''cafe'',''cafe_talk'',''lena'',''4''">Елена</a>,' _
			+ ' <a href="exec: gt ''logist'',''cafe'',''cafe_talk'',''sb'',''3''">Начальник службы безопасности</a>,' _
			+ ' <a href="exec: gt ''logist'',''cafe'',''cafe_talk'',''igor'',''5''">админ Игорь</a>,' _
			+ ' <a href="exec: gt ''logist'',''cafe'',''cafe_talk'',''ignatiev'',''6''">Игнатьев</a>.'
		elseif hour < 18:
			gs 'zz_render', '', 'images/city/north/skk/logistics/cafe_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 10)
		end
		act 'Ланч (150 р.)':
			*clr & cla
			if func ('zz_funcs', 'money', 150) = 1:
				gs 'zz_kitchen_acts', 'eat', 'lunch'
				gs 'zz_kitchen_acts', 'drink', 'coffee'
				act 'Далее': gt 'logist', 'cafe', 'eating'
			end
		end
		act 'Плотно покушать (250 р.)':
			*clr & cla
			if func('zz_funcs', 'money', 250) = 1:
				gs 'zz_kitchen_acts', 'eat'
				gs 'zz_kitchen_acts', 'drink', 'tea'
				act 'Далее': gt 'logist', 'cafe', 'eating'
			end
		end
	end
	if $ARGS[1] = 'cafe_talk':
		*clr & cla
		if $ARGS[2] = 'moreman':	gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_<<rand(1,2)>>.jpg', func ('logist_strings', 'logist_4', 1)
		if $ARGS[2] = 'nok':	gs 'zz_render', '', 'images/city/north/skk/logistics/nok_<<rand(1,4)>>.jpg', func ('logist_strings', 'logist_4', 2)
		if $ARGS[2] = 'lena':	gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,5)>>.jpg', func ('logist_strings', 'logist_4', 3)
		if $ARGS[2] = 'sb':	gs 'zz_render', '', 'images/city/north/skk/logistics/sb_<<rand(1,1)>>.jpg', func ('logist_strings', 'logist_4', 4)
		if $ARGS[2] = 'igor':	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings', 'logist_4', 5)
		if $ARGS[2] = 'ignatiev':	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings', 'logist_4', 6)
		act 'Уйти': gt 'logist', 'cafe'
	end
	if $ARGS[1] = 'eating':
		*clr & cla
		if hour = 12:
			gs 'zz_render', '', 'images/city/north/skk/logistics/cafe_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 10) + ' ' + func ('logist_strings','logist_3', iif (Ninaqw = 0, rand(2,4), 5))
		else
			gs 'zz_render', '', 'images/city/north/skk/logistics/cafe_<<rand(1,2)>>.jpg', func ('logist_strings','logist_0', 10)
		end
	end
	act 'Уйти': gt 'logist'
end
!---
! Разговоры с нпс вне кафе
!---
if $ARGS[0] = 'talk':
	*clr & cla
	if $ARGS[1] = 'moreman':	gs 'zz_render', '', 'images/city/north/skk/logistics/moreman_<<rand(1,2)>>.jpg', func ('logist_strings', 'logist_4', 1)
	if $ARGS[1] = 'lena':	gs 'zz_render', '', 'images/city/north/skk/logistics/lena_<<rand(1,5)>>.jpg', func ('logist_strings', 'logist_4', 3)
	if $ARGS[1] = 'sb':	gs 'zz_render', '', 'images/city/north/skk/logistics/sb_<<rand(1,1)>>.jpg', func ('logist_strings', 'logist_4', 4)
	if $ARGS[1] = 'ignatiev':	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings', 'logist_4', 6)
	if $ARGS[1] = 'cleaner':	gs 'zz_render', '', 'images/city/north/skk/logistics/wanted.png', func ('logist_strings', 'logist_4', 7)
	act 'Уйти': gt 'logist'
end