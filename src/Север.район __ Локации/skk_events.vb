! Служба такси
! uber['work']
! 0 - не работала еще
! 1 - работает
! 3 - уволилась, может повторно устроиться
! 5 - уволена, больше не может здесь работать, локация закрыта
! uber['work_count'] - количество дней работы, до 20 - стажировка, больше - обычная работа
! uber['work_week_count'] - количество отработанных дней в неделю
! uber['work_absent'] - количество прогулов
! uber['work_week'] - график смен:
! 1 - работа с 8 утра
! 2 - работа с 16 дня
! рабочие дни: ПН,ВТ,ЧТ,ПТ,СБ
if $args[0] = 'uber':
	*clr & cla
	gs 'zz_render','Такси "Довезёт"','city/north/skk/uber/office.jpg',func('skk_strings',6)
	if uber['work'] = 0 or uber['work'] = 3:
		if hour >= 8 and hour <= 18:
			act 'Спросить о работе':
				*clr & cla
				gs 'zz_render','','city/north/skk/uber/boss.jpg',func('skk_strings',iif(uber['work'] = 0,7,15))
				act 'Согласиться':
					cla
					uber['work'] = 1
					uber['work_day'] = day
					uber['work_week'] = 1
					gs 'zz_render','','',func('skk_strings',9)
					gs 'skk_events','uber_go_out'
				end
				act 'Отказаться':
					cla
					gs 'zz_render','','',func('skk_strings',8)
					gs 'skk_events','uber_go_out'
				end
			end
		end
		gs 'skk_events','uber_go_out'
	elseif uber['work'] = 1:
		gs 'skk_events','uber_go_out'
		if uber['work_absent'] = 1 or uber['work_absent'] = 2:
			gs 'zz_render','','city/north/skk/uber/boss.jpg',func('skk_strings',13)
		elseif uber['work_absent'] = 3:
			gs 'zz_render','','city/north/skk/uber/boss.jpg',func('skk_strings',14)
			uber['work'] = 5
			karta += uber['work_week_count'] * iif(uber['work_count'] < 20,600,800)
			gs 'skk_events','uber_go_out'
			exit
		end
		if hour >= 8 and hour <= 18:
			act 'Уволиться':
				*clr & cla
				uber['work'] = 3
				uber['work_absent'] = 0
				karta += uber['work_week_count'] * iif(uber['work_count'] < 20,600,800)
				uber['work_week_count'] = 0
				gs 'zz_render','','city/north/skk/uber/boss.jpg',func('skk_strings',12)
				gs 'skk_events','uber_go_out'
			end
		end
		if uber['work_day'] ! day and week ! 3 and week ! 7 and hour = uber['work_week']*8:
			act 'Работать':
				*clr & cla
				if uber['work_count'] = 0:
					! первый раз на работе
					gs 'zz_render','','city/north/skk/uber/work0.jpg',func('skk_strings',10)
				else
					! последующие разы
					gs 'zz_render','','city/north/skk/uber/work1.jpg',func('skk_strings',11)
				end
				uber['work_day'] = day
				uber['work_count'] += 1
				uber['work_week_count'] += 1
				minut += 240
				gs 'skk_events','uber_go_out'
			end
		end
	end
end
if $args[0] = 'uber_go_out':
	act 'Уйти':
		minut += rand(1,5)
		gt 'skk','third_floor'
	end
end
! секция карате
! $npc['0,karate'] - стадийность
! $npc['0,karate_day'] - день занятия
! $npc['0,karate_count'] - количество дней абонемента
if $args[0] = 'karate_init':
	*clr & cla
	gs 'zz_funcs','colorize_day'
	if $npc['0,karate'] = 0:
		gs 'zz_render','','city/north/skk/karate/0',func('skk_strings',16)
		act 'Ждать':
			*clr & cla
			minut += rand(15,30)
			gs 'stat'
			gs 'zz_render','','city/north/skk/karate/sensey',func('skk_strings',17)
			if body['group'] >= 2:
				gs 'zz_render','','',func('skk_strings',18)
				act 'Уйти': gt 'skk','sport'
			else
				gs 'zz_render','','',func('skk_strings',19)
				act 'Переодеться':
					*clr & cla
					gs 'zz_render','','city/north/skk/karate/1',func('skk_strings',20)
					act '...': gt $curloc,'karate_training'
				end
			end
		end
	end
end
! тренировки
if $args[0] = 'karate_training':
	*clr & cla
	gs 'zz_funcs','colorize_day'
	gs 'zz_render','','city/north/skk/karate/1',func('skk_strings',21)
	if $npc['0,karate'] > 0:
		! толстожопую не пускаем на тренировку
		if body['group'] >= 2:
			gs 'zz_render','','city/north/skk/karate/sensey',func('skk_strings',26)
			exit
		end
		! вывводим количество доступных занятий
		gs 'zz_render','','',func('skk_strings',27)
		! абонемент закончился - покупаем новый или не покупаем
		if $npc['0,karate_count'] = 0:
			*clr & cla
			gs 'zz_render','','city/north/skk/karate/sensey',func('skk_strings',28)
			if money >= 8000:
				act 'Оплатить':
					money -= 8000
					$npc['0,karate_count'] = 30
					gs 'stat'
					gt $curloc,'karate_training'
				end
			end
			act 'Уйти': gt 'skk','sport'
		end
	end
	! сама тренировка
	if $npc['0,karate_count'] > 0 or $npc['0,karate'] = 0:
		act 'Тренироваться':
			*clr & cla
			minut += rand(45,60)
			body['day_weight'] -= 1
			gs 'zz_funcs','sport'
			agil += rand(0,1)
			react += rand(0,1)
			$npc['0,karate_day'] = day
			gs 'stat'
			gs 'zz_render','','city/north/skk/karate/2',func('skk_strings',22)
			act 'Дальше':
				*clr & cla
				if $npc['0,karate'] = 0:
					gs 'zz_render','','city/north/skk/karate/sensey',func('skk_strings',23)
					if money >= 8000:
						act 'Согласиться':
							*clr & cla
							money -= 8000
							$npc['0,karate_count'] = 30
							$npc['0,karate'] = 1
							gs 'stat'
							gs 'zz_render','','city/north/skk/karate/sensey',func('skk_strings',24)
							act 'Уйти': gt 'skk','sport'
						end
					end
					act 'Я подумаю':
						*clr & cla
						gs 'zz_render','','city/north/skk/karate/sensey',func('skk_strings',25)
						act 'Уйти': gt 'skk','sport'
					end
				else
					$npc['0,karate_count'] -= 1
					gs 'zz_funcs','sport'
					if boxing < 50:
						gs 'zz_render','','city/north/skk/karate/3',func('skk_strings',29)
						act 'Дальше':
							*clr & cla
							gs 'zz_render','','city/north/skk/karate/4',func('skk_strings',30)
							gs $curloc,'karate_training_skills_select'
						end
					else
						gs 'zz_render','','city/north/skk/karate/23',func('skk_strings',32)
						gs $curloc,'karate_training_skills_select'
					end
				end
			end
		end
	end
end
if $args[0] = 'karate_training_skills_select':
	! на выбор игрока одна их характеристик
	act 'Отработка прямых': gt $curloc,'karate_training_skills',0
	act 'Отработка боковых': gt $curloc,'karate_training_skills',1
	act 'Работа ногами': gt $curloc,'karate_training_skills',2
	act 'Защита': gt $curloc,'karate_training_skills',3
end
if $args[0] = 'karate_training_skills':
	*clr & cla
	if args[1] = 0:
		Jab += 1
		gs 'zz_render','','city/north/skk/karate/18',func('skk_strings',46)
	elseif args[1] = 1:
		Punch += 1
		gs 'zz_render','','city/north/skk/karate/19',func('skk_strings',47)
	elseif args[1] = 2:
		Kik += 1
		i = rand(0,2)
		gs 'zz_render','','city/north/skk/karate/'+(20+i),func('skk_strings',48+i)
	else
		KikDef += 1
		i = rand(0,1)
		gs 'zz_render','','city/north/skk/karate/'+(23+i),func('skk_strings',51+i)
	end
	minut += rand(15,20)
	gs 'stat'
	if boxing < 50:
		act 'Дальше':
			*clr & cla
			Jab += 1
			Punch += 1
			Kik += 1
			KikDef += 1
			minut += rand(15,20)
			gs 'zz_funcs','sport'
			gs 'stat'
			gs 'zz_render','','city/north/skk/karate/5',func('skk_strings',31)
			act 'Закончить тренировку': gt 'skk','sport'
		end
	else
		act 'Дальше':
			*clr & cla
			Jab += 1
			Punch += 1
			Kik += 1
			KikDef += 1
			minut += rand(15,20)
			dom += rand(0,1)
			gs 'zz_funcs','sport'
			gs 'stat'
			gs 'zz_render','','city/north/skk/karate/7',func('skk_strings',33)
			act 'Дальше':
				*clr & cla
				if rand(0,iif(boxing < 80,5,10)) < 2:
					gs 'zz_render','','city/north/skk/karate/8',func('skk_strings',34)
				else
					gs 'zz_render','','city/north/skk/karate/9',func('skk_strings',35)
				end
				act 'Закончить тренировку': gt 'skk','sport'
				if boxing > 70:
					act 'Остаться на дополнительное занятие':
						*clr & cla
						gs 'zz_render','','city/north/skk/karate/sempay',func('skk_strings',36)
						act 'Слушать':
							cla
							gs 'zz_render','','',func('skk_strings',rand(37,38))
							act 'Закончить тренировку': gt 'skk','sport'
						end
						if shameless['flag'] > 0 and manna > 70 and horny > 80: act 'Веселиться': gt $curloc,'karate_training_joke'
					end
				end
			end
		end
	end
end
if $args[0] = 'karate_training_joke':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	gs 'zz_funcs','sport'
	gs 'stat'
	gs 'zz_render','','city/north/skk/karate/'+(11+_stage),func('skk_strings',39+_stage)
	act iif(_stage < 6,'...','Уйти'):
		if _stage < 6:
			gt $curloc,'karate_training_joke',_stage+1
		else
			killvar '_stage'
			gt 'skk','sport'
		end
	end
end