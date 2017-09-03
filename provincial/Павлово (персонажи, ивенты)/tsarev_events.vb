! ветка учителя математики Царева
!---
! $npc['26,qwMain'] - стадии ветки
! $npc['26,qwMain_day'] - день ивента
!---
! 0 - 20 - Светка заигривает с учителем перед и во время уроков
! 21 - 23 - дополнительные занятия в кабинете Царева
! 24 - первый секс на доп.занятии
! 25 - после первого секса на доп.занятии
! 26 - 28 - рандомный секс после уроков, при 28 - приглашение домой
! 30 - ГГ получила приглашение домой, открывается минет на перемене и анал после уроков
! 31 - после первого домашнего секса
! 54 - после второго домашнего секса, открываем возможность воровства ключей
! 50 - начало ветки орка - значение после столкновения в школе
! 51 - 52 - неудачная слежка
! 53 - слежка удалась, узнаем где дом
! 54 - удалось пробраться к дому, открываем возможность воровства ключей
! 55 - ключи сворованы
! 56 - Светка побывала в доме учителя, открываем ивент-хаб
! 100 - Светка выбрала детективную ветку
! 101 - после первого визита в дом учителя по детективной ветке
! 102 - после второго визита в дом учителя по детективной ветке
! 103 - после третьего визита в дом учителя по детективной ветке
! 105 - после обдумывания в своей комнате по детективной ветке
!! 200 - Светка выбрала обучение сексу
! 255 - ветка закрыта
!---------
! случайные встречи учителя в коридоре
if $args[0] = 'meet_teacher':
	*clr & cla
	if $npc['26,qwMain'] < 20: $npc['26,qwMain_day'] = day
	gs 'zz_render','','pavlovo/tsarev/school/0',func('tsarev_str',0)
	act 'Поздороваться':
		*clr & cla
		gs 'npc_editor','get_npc_profile',26
		if $npc['26,relation'] < 60:
			if vnesh < 60:
				gs 'zz_render','','',func('tsarev_str',rand(1,2))
				manna -= rand(0,10)
			else
				gs 'zz_render','','',func('tsarev_str',3)
				gs 'npc_editor','change_rep','up',26,1
			end
		else
			gs 'zz_render','','',func('tsarev_str',rand(4,5))
			gs 'npc_editor','change_rep','up',26,1
		end
		act 'Дальше': gt 'zz_school'
	end
	act 'Пройти мимо молча':
		*clr & cla
		gs 'npc_editor','get_npc_profile',26
		if $npc['26,relation'] < 60:
			gs 'zz_render','','',func('tsarev_str',iif(vnesh < 60,12,13))
			act 'Дальше': gt 'zz_school'
		else
			gs 'zz_render','','',func('gschool2_strings', 'local_str165')
			act 'Извиниться и поздороваться':
				*clr & cla
				gs 'npc_editor','get_npc_profile',26
				gs 'zz_render','','',func('tsarev_str',14)
				gs 'npc_editor','change_rep','up',26,1
				act 'Дальше': gt 'zz_school'
			end
			if $npc['26,relation'] >= 80:
				act 'Прикоснуться к руке и извиниться':
					*clr & cla
					gs 'npc_editor','get_npc_profile',26
					gs 'zz_render','','',func('tsarev_str',15)
					if vnesh >= 60: gs 'npc_editor','change_rep','up',26,1
					act 'Дальше': gt 'zz_school'
				end
			end
			if dom > 0:
				act 'Проигнорировать замечание':
					*clr & cla
					gs 'zz_render','','pavlovo/tsarev/school/1',func('tsarev_str',16)
					dom += 1
					gs 'npc_editor','change_rep','down',26,1
					act 'Дальше': gt 'zz_school'
				end
			end
		end
	end
	if $npc['26,relation'] >= 60:
		act 'Кокетливо поздороваться':
			*clr & cla
			gs 'npc_editor','get_npc_profile',26
			if $npc['26,relation'] < 80:
				if vnesh < 60:
					gs 'zz_render','','',func('tsarev_str',rand(6,7))
					gs 'npc_editor','change_rep','up',26,1
				else
					if rand(0,1) = 0:
						gs 'zz_render','','',func('tsarev_str',8)
						gs 'npc_editor','change_rep','up',26,1
					else
						gs 'zz_render','','',func('tsarev_str',9)
					end
				end
			else
				if rand(0,1) = 0:
					gs 'zz_render','','',func('tsarev_str',10)
					manna -= rand(5,10)
					gs 'npc_editor','change_rep','down',26,1
				else
					gs 'zz_render','','',func('tsarev_str',11)
					gs 'npc_editor','change_rep','up',26,1
				end
			end
			act 'Дальше': gt 'zz_school'
		end
	end
	if $npc['26,relation'] >= 80 and vnesh >= 60:
		act 'Соблазнять':
			*clr & cla
			if $npc['26,qwMain'] < 20: $npc['26,qwMain'] += 2
			gs 'npc_editor','get_npc_profile',26
			gs 'zz_render','','',func('tsarev_str',17)
			if $npc['26,qwMain'] = 20 and shameless['flag'] >= 2:
				! в зависимости от успеваемости автоматичемки разводим ветки
				if school['progress'] >= 80:
					act 'Договориться о дополнительных занятиях': gt 'tsarev_events','talk_about_personal_lessons'
				else
					act 'Столкнуться и потрогать': gt 'tsarev_events','teacher_start'
				end
			end
			act 'Облизнуть губы':
				*clr & cla
				gs 'zz_render','','pavlovo/tsarev/school/2',func('tsarev_str',18)
				gs 'npc_editor','change_rep','up',26,1
				act 'Дальше': gt 'zz_school'
			end
			act 'Выронить учебники':
				*clr & cla
				gs 'zz_render','Нужна фота - девушка собирает упавшие книги','pavlovo/tsarev/school/3',func('tsarev_str',19)
				act 'Встать и попробовать завести разговор':
					*clr & cla
					gs 'npc_editor','change_rep','up',26,1
					gs 'zz_render','','pavlovo/tsarev/school/4',func('tsarev_str',20)
					horny += 3
					act 'Дальше': gt 'zz_school'
				end
				act 'Оголить задницу':
					*clr & cla
					horny += 3
					gs 'npc_editor','change_rep','up',26,1
					gs 'zz_render', 'Нужна фота - девушка собирает упавшие книги с задранной юбкой','pavlovo/tsarev/school/5',func('tsarev_str',21) + func('tsarev_str',iif(tanga=1,22,23)) + func('tsarev_str',24)
					act 'Дальше': gt 'zz_school'
				end
			end
			act 'Споткнуться и упасть учителю на руки':
				*clr & cla
				if rand(0,4) > 0:
					gs 'zz_render','Нужна фота','pavlovo/tsarev/school/6',func('tsarev_str',25)
					gs 'npc_editor','change_rep','up',26,1
				else
					gs 'zz_render','','pavlovo/tsarev/school/7',func('tsarev_str',26)
					gs 'npc_editor','change_rep','up',26,2
				end
				act 'Дальше': gt 'zz_school'
			end
		end
	end
end
! урок математики - Светка может соблазнять учителя, создавать видимость учебы или филонить
if $args[0] = 'math':
	*clr & cla
	gs 'zz_render','Фотки нет','',func('tsarev_str',27)
	act 'Внимательно слушать Анатолия Евгеньевича':
		cla
		if vnesh >= 60 and $npc['26,relation'] >= 60:
			i = rand(1,$npc['26,relation']/20)
			gs 'npc_editor','change_rep','up',26,1
			if i = 1:
				gs 'zz_render','','',func('tsarev_str',28)
			elseif i = 2:
				gs 'zz_render','','',func('tsarev_str',29)
				gs 'tsarev_events','show_legs'
			elseif i = 3:
				gs 'zz_render','','',func('tsarev_str',30)
				act 'Легонько прикоснуться своей рукой к его руке':
					cla
					gs 'zz_render','','',func('tsarev_str',31)
					act 'Ждать конца урока': minut += 1 & gt 'zz_school'
				end
			else
				gs 'zz_render','','',func('tsarev_str',32)
			end
		else
			gs 'zz_render','','',func('tsarev_str',33)
		end
		act 'Задать вопрос по теме урока':
			cla
			gs 'npc_editor','change_rep','up',26,1
			if rand(1,4) = 1:
				gs 'zz_render','','',func('tsarev_str',34)
				if dom > 0:
					act 'Обернуться и попросить вести себя потише':
						cla
						gs 'npc_editor','change_rep','up',26,1
						gs 'zz_render','','',func('tsarev_str',iif(dom >= 30,35,36))
						act 'Ждать конца урока': minut += 1 & gt 'zz_school'
					end
				end
				act 'Подслушивать':
					cla
					gs 'zz_render','','',func('tsarev_str',37)
					gs 'zz_school','gossip'
				end
				act 'Ждать конца урока': minut += 1 & gt 'zz_school'
			else
				gs 'zz_render','','',func('tsarev_str',38)
			end
			act 'Ждать конца урока': minut += 1 & gt 'zz_school'
		end
		act 'Ждать конца урока': minut += 1 & gt 'zz_school'
	end
	act 'Глазеть по сторонам':
		cla
		if rand(0,1) = 1:
			gs 'zz_render','','',func('tsarev_str',39)
			if dom >= 10:
				act 'Не обращать внимание':
					cla
					if dom >= 70:
						gs 'zz_render','','',func('tsarev_str',40)
						gs 'npc_editor','change_rep','down',26,3
						act 'Остаться в классе':
							cla
							gs 'zz_render','','',func('tsarev_str',41)
							act 'Ждать конца урока': minut += 1 & gt 'zz_school'
						end
						act 'Выйти из класса':
							! ВАЖНО - время уже переведено на конец урока - надо вернуть назад
							minut -= rand(15,30)
							gt 'zz_school'
						end
					else
						gs 'zz_render','','',func('tsarev_str',42)
						act 'Ждать конца урока': minut += 1 & gt 'zz_school'
					end
				end
			end
			act 'Сосредоточиться на занятии': minut += 1 & gt 'zz_school'
		else
			act 'Ждать конца урока': minut += 1 & gt 'zz_school'
		end
	end
	act 'Сидеть в телефоне':
		cla
		gs 'npc_editor','change_rep','down',26,1
		if vnesh >= 60 and $npc['26,relation'] >= 60:
			gs 'tsarev_events','phone'
		else
			gs 'zz_render','','',func('tsarev_str',43)
		end
		act 'Ждать конца урока': minut += 1 & gt 'zz_school'
	end
end
! демонстрация ножек
if $args[0] = 'show_legs':
	act 'Игнорировать': minut += 1 & gt 'zz_school'
	act 'Поправить юбку':
		cla
		gs 'npc_editor','change_rep','down',26,1
		gs 'zz_render','','',func('tsarev_str',iif(dom >= 30,44,45))
		act 'Ждать конца урока': minut += 1 & gt 'zz_school'
	end
	act 'Раздвинуть ноги':
		cla
		gs 'npc_editor','change_rep','up',26,1
		if vnesh >= 60 and $npc['26,relation'] >= 60 and $npc['26,qwMain'] < 20: $npc['26,qwMain'] += 2
		gs 'zz_render','','',func('tsarev_str',iif(dom >= 30,46,47))
		act 'Ждать конца урока': minut += 1 & gt 'zz_school'
	end
	if dom > 30:
		act 'Показать средний палец':
			cla
			gs 'npc_editor','change_rep','down',26,5
			dom += 1
			gs 'zz_render','','',func('tsarev_str',48)
			act 'Ждать конца урока': minut += 1 & gt 'zz_school'
		end
	end
end
! сидит в телефоне
if $args[0] = 'phone':
	gs 'zz_render','','',func('tsarev_str',49)
	act 'Спрятать телефон':
		cla
		gs 'zz_render','','',func('tsarev_str',50)
		act 'Ждать конца урока': minut += 1 & gt 'zz_school'
	end
	if dom >= 10:
		act 'Не обращать внимание':
			cla
			gs 'zz_render','','',func('tsarev_str',51)
			if dom > 30:
				act 'Положить телефон между грудей':
					cla
					gs 'npc_editor','change_rep','down',26,1
					gs 'zz_render','','',func('tsarev_str',52)
					act 'Ждать конца урока': minut += 1 & gt 'zz_school'
				end
			end
			if dom > 70:
				act 'Сделать фото под юбкой':
					cla
					gs 'zz_render','','',func('tsarev_str',53)
					if vnesh >= 60 and $npc['26,relation'] >= 60 and $npc['26,qwMain'] < 20: $npc['26,qwMain'] += 2
					act 'Ждать конца урока': minut += 1 & gt 'zz_school'
				end
			end
			act 'Отдать телефон':
				cla
				gs 'zz_render','','',func('tsarev_str',53)
				act 'Ждать конца урока': minut += 1 & gt 'zz_school'
			end
		end
	end
end
! разговор об дополнительных уроках
if $args[0] = 'talk_about_personal_lessons':
	*clr & cla
	$npc['26,qwMain'] = 21
	gs 'npc_editor','get_npc_profile',26
	gs 'zz_render','','',func('tsarev_str',55)
	act 'Уйти': gt 'zz_school'
end
! первое доп.занятие
if $args[0] = 'goto_tsarev_office':
	*clr & cla
	$npc['26,qwMain_day'] = day
	! только для первых визитов
	if $npc['26,qwMain'] < 24: gs 'zz_render','','pavlovo/tsarev/lessons/0',func('tsarev_str',56)
	!--
	if $npc['26,qwMain'] = 21:
		act 'Строить глазки':
			*clr & cla
			gs 'zz_render','','pavlovo/tsarev/lessons/1',func('tsarev_str',57)
			act 'Заниматься': gt 'tsarev_events','lesson'
		end
	elseif $npc['26,qwMain'] = 22:
		act 'Придвинуться и выставить грудь':
			*clr & cla
			gs 'zz_render','','pavlovo/tsarev/lessons/2',func('tsarev_str',58)
			act 'Придвинуться еще ближе':
				*clr & cla
				gs 'zz_render','','pavlovo/tsarev/lessons/3',func('tsarev_str',59)
				act 'Заниматься': gt 'tsarev_events','lesson'
			end
		end
	elseif $npc['26,qwMain'] = 23:
		act 'Выронить бумаги':
			*clr & cla
			gs 'zz_render','','pavlovo/tsarev/lessons/4',func('tsarev_str',60)
			act '...':
				*clr & cla
				gs 'zz_render','','pavlovo/tsarev/lessons/5',func('tsarev_str',61)
				act 'Заниматься': gt 'tsarev_events','lesson'
			end
		end
	elseif $npc['26,qwMain'] = 24:
		gt 'tsarev_events','first_sex'
	elseif $npc['26,qwMain'] >= 25 and $npc['26,qwMain'] <= 27:
		! сюжетный секс с учителем
		$npc['26,qwMain'] += 1
		gt 'tsarev_events','school_sex<<rand(1,3)>>'
	elseif $npc['26,qwMain'] >= 30 and $npc['26,qwMain'] <= 40:
		gt 'tsarev_events','school_locked_room'
	end
end
! само занятие
if $args[0] = 'lesson':
	_stage = args[1]
	minut += rand(3,7)
	horny += rand(3,10)
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/lessons/<<6+_stage>>',func('tsarev_str',62+_stage)
	act iif(_stage < 8,'...','Уйти'):
		if _stage < 8:
			gt 'tsarev_events','lesson',_stage+1
		else
			minut += 5
			if $npc['26,qwMain'] < 24: $npc['26,qwMain'] += 2
			killvar '_stage'
			gt 'zz_school'
		end
	end
end
! первый секс на доп. занятии
if $args[0] = 'first_sex':
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 5 and _stage <= 10:
		horny += rand(10,20)
	elseif _stage = 11:
		horny = 0
		orgasm += 1
		manna += rand(10,30)
	elseif _stage = 12:
		gs 'zz_funcs','cum','ass'
	elseif _stage = 13:
		gs 'zz_funcs','cum','lip'
	end
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/first_sex/<<_stage>>',func('tsarev_str',71+_stage)
	act iif(_stage < 14,'...','Уйти'):
		if _stage < 14:
			gt 'tsarev_events','first_sex',_stage+1
		else
			minut += 5
			$npc['26,sex'] = 1
			$npc['26,qwMain'] = 25
			sex += 1
			guy += 1
			killvar '_stage'
			gt 'zz_school'
		end
	end
end
! рандомный секс в школе, #1
if $args[0] = 'school_sex1':
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 1 and _stage <= 4:
		horny += rand(10,20)
	elseif _stage = 5:
		horny = 0
		orgasm += 1
		manna += rand(10,30)
	end
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/school_sex/1/<<_stage>>',func('tsarev_str',86+_stage)
	act '...':
		if _stage < 7:
			gt 'tsarev_events','school_sex1',_stage+1
		else
			sex += 1
			minut += 5
			killvar '_stage'
			gt 'tsarev_events','school_sex_ender'
		end
	end
end
! рандомный секс в школе, #2
if $args[0] = 'school_sex2':
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 4 and _stage <= 8:
		horny += rand(10,20)
	elseif _stage = 9:
		horny = 0
		orgasm += 1
		manna += rand(10,30)
	elseif _stage = 11:
		gs 'zz_funcs','cum','lip'
	end
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/school_sex/2/'+ _stage + iif(_stage=7,'.gif','.jpg'),func('tsarev_str',94+_stage)
	act '...':
		if _stage < 11:
			gt 'tsarev_events','school_sex2',_stage+1
		else
			sex += 1
			minut += 5
			killvar '_stage'
			gt 'tsarev_events','school_sex_ender'
		end
	end
end
! рандомный секс в школе, #3
if $args[0] = 'school_sex3':
	_stage = args[1]
	minut += rand(3,7)
	if _stage >= 4 and _stage <= 6:
		horny += rand(20,30)
	elseif _stage = 7:
		horny = 0
		orgasm += 1
		manna += rand(10,30)
	elseif _stage = 8:
		gs 'zz_funcs','cum','ass'
	end
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/school_sex/3/<<_stage>>',func('tsarev_str',106+_stage)
	act '...':
		if _stage < 8:
			gt 'tsarev_events','school_sex3',_stage+1
		else
			sex += 1
			minut += 5
			killvar '_stage'
			gt 'tsarev_events','school_sex_ender'
		end
	end
end
! завершение рандомных функций секса
if $args[0] = 'school_sex_ender':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/lessons/14',func('tsarev_str',115)
	if $npc['26,qwMain'] = 28:
		$npc['26,qwMain'] = 30
		gs 'zz_render','','',func('tsarev_str',116)
	end
	act 'Уйти': gt 'zz_school'
end
! секс на перемене
if $args[0] = 'school_breaktime_sex':
	_stage = args[1]
	gs 'zz_render','','pavlovo/tsarev/school_sex/4/'+ _stage + iif(_stage=2 or _stage=3,'.gif','.jpg'),func('tsarev_str',117+_stage)
	act iif(_stage < 4,'...','Уйти'):
		if _stage < 4:
			gt 'tsarev_events','school_breaktime_sex',_stage+1
		else
			bj += 1
			swallow += 1
			! переводим время, включаем блок от читеров
			if hour > 11: hour = 11
			minut += 12*60 + 15 - (hour*60 + minut)
			killvar '_stage'
			gt 'zz_school'
		end
	end
end
! внесюжетный секс с Царевым после уроков
if $args[0] = 'school_anal_sex':
	_stage = args[1]
	if _stage >= 1 and _stage ! 6:
		horny += rand(10,15)
	elseif _stage = 6:
		horny = 0
		orgasm += 1
	end
	minut += rand(3,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/school_sex/5/<<_stage>>',func('tsarev_str',122+_stage)
	act iif(_stage < 9,'...','Уйти'):
		if _stage < 9:
			gt 'tsarev_events','school_anal_sex',_stage+1
		else
			anal += 1
			minut += 5
			gs 'zz_funcs','cum','anus'
			if anus < 10: anus += 1
			killvar '_stage'
			gt 'zz_school'
		end
	end
end
! закрываем кабинет - портим дневную попытку поймать Царева
if $args[0] = 'school_locked_room':
	*clr & cla
	if rand(0,2) = 0:
		gt 'tsarev_events',iif(hour = 11,'school_breaktime_sex','school_anal_sex')
	else
		gs 'zz_render','','pavlovo/tsarev/school/locked_door',func('tsarev_str',iif(rand(0,1)=0,132,133))
		minut += rand(3,5)
		act 'Уйти': gt 'zz_school'
	end
end
! первый домашний секс
if $args[0] = 'home_first_sex':
	_stage = args[1]
	if _stage >= 3 and _stage <= 8:
		horny += rand(10,20)
	elseif _stage = 9:
		horny = 0
		orgasm += 1
	elseif _stage = 10:
		gs 'zz_funcs','cum','lip'
	end
	minut += rand(3,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/home_sex/0/'+_stage+iif(_stage>=6 and _stage<=10,'.gif','.jpg'),func('tsarev_str',134+_stage)
	act iif(_stage < 13,'...','Уйти'):
		if _stage < 13:
			gt 'tsarev_events','home_first_sex',_stage+1
		else
			sex += 1
			bj += 1
			swallow += 1
			minut += rand(10,15)
			$npc['26,qwMain'] = 31
			$npc['26,qwMain_day'] = day
			killvar '_stage'
			gt 'gorodok'
		end
	end
end
! второй домашний секс
if $args[0] = 'home_second_sex':
	_stage = args[1]
	if _stage >= 3 and _stage <= 8:
		horny += rand(10,20)
	elseif _stage = 9:
		horny = 0
		orgasm += 1
	elseif _stage = 11:
		gs 'zz_funcs','cum','lip'
	end
	minut += rand(3,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/home_sex/1/'+_stage+iif(_stage=10,'.gif','.jpg'),func('tsarev_str',148+_stage)
	act iif(_stage < 12,'...','Уйти'):
		if _stage < 12:
			gt 'tsarev_events','home_second_sex',_stage+1
		else
			anal += 1
			bj += 1
			swallow += 1
			$npc['26,qwMain_day'] = day
			killvar '_stage'
			! переход на ивент-обьяснялку
			gt 'tsarev_events','home_second_sex_ender'
		end
	end
end
! ивент-обьяснялка, Царев внезапно прогоняет Светку, открывает воровство ключей
if $args[0] = 'home_second_sex_ender':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/home_sex/1/',func('tsarev_str',190)
	$npc['26,qwMain'] = 54
	minut += rand(10,15)
	act 'Уйти': gt 'gorodok'
end
! функция-дом - разводит по внутридомовым ивентам в зависимости от стадии ветки
if $args[0] = 'tsarev_home':
	! Светка первый раз после слежки приходит к дому Царева
	if $npc['26,qwMain_day'] = day:
		gt 'tsarev_events','tsarev_home_fail_visit'
	else
		if $npc['26,qwMain'] = 53:
			! Светка прокрадается в двор учителя
			gt 'tsarev_events','teacher_goto_home'
		elseif $npc['26,qwMain'] = 55:
			! Светка прокрадается в дом учителя
			if (week = 2 or week = 4) and hour <= 14:
				gt 'tsarev_events','teacher_house_lurking'
			else
				gt 'tsarev_events','tsarev_home_fail_visit'
			end
		elseif $npc['26,qwMain'] = 56:
			! Светка идет к дому Царева - ивент-хаб
			if (week = 2 or week = 4) and hour <= 14:
				gt 'tsarev_events','teacher_choice'
			else
				gt 'tsarev_events','tsarev_home_fail_visit'
			end
		elseif $npc['26,qwMain'] = 30 or $npc['26,qwMain'] = 31:
			! Светка приходит на секс с учителем
			if (week = 2 or week = 4) and hour >= 15:
				gt 'tsarev_events',iif($npc['26,qwMain']=30,'home_first_sex','home_second_sex')
			else
				gt 'tsarev_events','tsarev_home_fail_visit'
			end
		elseif $npc['26,qwMain'] = 100:
			gt 'tsarev_events','teacher_choice_detective1'
		elseif $npc['26,qwMain'] = 101:
			gt 'tsarev_events','teacher_choice_detective2'
		elseif $npc['26,qwMain'] = 102:
			gt 'tsarev_events','teacher_choice_detective3'
		else
			gt 'tsarev_events','tsarev_home_fail_visit'
		end
	end
end
! не время либо Светка уже была сегодня
if $args[0] = 'tsarev_home_fail_visit':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/nohome',func('tsarev_str',iif($npc['26,qwMain_day'] = day,161,162))
	act 'Уйти': minut += rand(10,15) & gt 'gorodok'
end
! начало ветки - вариант орка
if $args[0] = 'teacher_start':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/lurking/0',func('tsarev_str',163)
	$npc['26,qwMain'] = 50
	act 'Отойти': minut += 1 & gt 'zz_school'
end
! слежка за учителем
if $args[0] = 'teacher_lurking':
	*clr & cla
	$npc['26,qwMain_day'] = day
	! скрытности нет - привяжем к ловкости
	if rand(0,100-agil) = 0:
		$npc['26,qwMain'] = 53
	else
		$npc['26,qwMain'] += 1
	end
	!--
	if $npc['26,qwMain'] < 53:
		gs 'zz_render','','pavlovo/tsarev/lurking/1',func('tsarev_str',164)
	else
		gs 'zz_render','','pavlovo/tsarev/lurking/2',func('tsarev_str',165)
	end
	act 'Уйти': minut += rand(10,15) & gt 'gorodok'
end
! гг пытается попасть во двор учителя
if $args[0] = 'teacher_goto_home':
	*clr & cla
	$npc['26,qwMain_day'] = day
	act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	if hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset'):
		! от заката до рассвета лазейку не найти
		gs 'zz_render','картинка дома или забора в темноте','',func('tsarev_str',169)
		exit
	elseif (week mod 2 = 1 and hour >= 15) or hour >= 17:
		! 15.00-17.00 во ВТ,ЧТ,СБ или после 17.00 в любой день учитель дома
		gs 'zz_render','картинка дома или забора в темноте','',func('tsarev_str',167)
		exit
	!elseif hour <= 10:
		!! жена учителя дома
		!gs 'zz_render','картинка дома или забора в темноте','',func('tsarev_str',166)
		!exit
	else
		if rand(0,3) = 0:
			! рандомно может прогнать бабка с топором
			gs 'zz_render','','pavlovo/tsarev/lurking/3',func('tsarev_str',168)
			exit
		else
			! попадаем во двор
			gs 'zz_render','','pavlovo/tsarev/lurking/4',func('tsarev_str',170)
			act 'Двигаем дальше':
				gt 'tsarev_events','teacher_yard'
			end
			act 'Сохраниться':
				savegame
				cla
				act 'Двигаем дальше': gt 'tsarev_events','teacher_yard'
			end
		end
	end
end
! гг попала во двор учителя
if $args[0] = 'teacher_yard':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/lurking/5',func('tsarev_str',171)
	act 'Осмотреться':
		*clr & cla
		gs 'zz_render','','pavlovo/tsarev/lurking/6',func('tsarev_str',172)
		act 'Очнуться':
			*clr & cla
			minut += rand(15,30)
			gs 'stat'
			gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/7',func('tsarev_str',173)
			act 'Послать': gt 'tsarev_events','teacher_fuckoff'
			act 'Жаловаться': gt 'tsarev_events','teacher_complain'
		end
	end
end
! гг послала учителя, кто не сохранился - сам виноват
if $args[0] = 'teacher_fuckoff':
	*clr & cla
	gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/8',func('tsarev_str',174)
	act '...':
		*clr & cla
		gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/9',func('tsarev_str',175)
		act '...': gt 'gameover',11
	end
end
! гг жалеется учителю
if $args[0] = 'teacher_complain':
	*clr & cla
	gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/10',func('tsarev_str',176)
	act 'Идти с учителем':
		*clr & cla
		gs 'zz_render','','pavlovo/tsarev/lurking/11',func('tsarev_str',177)
		act 'Ну, я не знаю...':
			*clr & cla
			gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/12',func('tsarev_str',178)
			act 'Хочу тебя!': gt 'tsarev_events','teacher_sex'
		end
		act 'Молчать':
			*clr & cla
			gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/13',func('tsarev_str',179)
			$npc['26,qwMain'] = 255
			gs 'npc_editor','change_rep','down',37,100
			minut += rand(30,60)
			act 'В свою комнату': gt 'bedrPar'
		end
	end
end
! секс с учителем дома после подвала
if $args[0] = 'teacher_sex':
	clr & cla
	_stage = args[1]
	if _stage >= 1 and _stage <= 8:
		horny += rand(10,15)
	elseif _stage = 9:
		horny = 0
		orgasm += 1
	end
	minut += rand(3,5)
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/home_sex/2/<<_stage>>',func('tsarev_str',180+_stage)
	act iif(_stage < 10,'...','Уйти'):
		if _stage < 10:
			gt 'tsarev_events','teacher_sex',_stage+1
		else
			sex += 1
			bj += 1
			minut += rand(10,15)
			$npc['26,qwMain'] = 54
			$npc['26,qwMain_day'] = day
			killvar '_stage'
			gt 'gorodok'
		end
	end
end
! -- воровство ключей в раздевалке -- !
! подготовка массива
if $args[0] = 'stealing_keys_init':
	*clr & cla
	gs 'zz_render','Картинки нет','',func('tsarev_str',191)
	! случайно определяем местоположение ключей
	! 0 - ключей нет
	! 1 - ключи здесь
	! -1 - здесь уже смотрели
	_key_place[0] = 0
	_key_place[1] = 0
	_key_place[2] = 0
	! рандом побольше - чтобы увеличить шанс выпадения крайних вариантов
	_key_place[rand(0,29)/10] = 1
	! всего 2 попытки
	_key_times = 0
	$npc['26,qwMain_day'] = day
	xgt 'tsarev_events','stealing_keys'
end
! кнопки действий - убираем места, которые осмотрели
if $args[0] = 'stealing_keys':
	cla
	if _key_place[0] >= 0:
		act 'Искать в сумке':
			xgt 'tsarev_events',iif(_key_place[0] = 1,'stealing_keys_ender','stealing_keys_fail'),0
		end
	end
	if _key_place[1] >= 0:
		act 'Искать в куртке':
			xgt 'tsarev_events',iif(_key_place[1] = 1,'stealing_keys_ender','stealing_keys_fail'),1
		end
	end
	if _key_place[2] >= 0:
		act 'Искать джинсах':
			xgt 'tsarev_events',iif(_key_place[2] = 1,'stealing_keys_ender','stealing_keys_fail'),2
		end
	end
end
! неудачная попытка
if $args[0] = 'stealing_keys_fail':
	_key_times += 1
	_key_place[args[1]] = -1
	if _key_times = 2:
		cla
		! обе попытки использованы
		gs 'zz_render','','',func('tsarev_str',193)
		killvar '_key_place'
		killvar '_key_times'
		act 'Переодеться и уйти': gt 'zz_school'
	else
		! ищем в другом месте
		gs 'zz_render','','',func('tsarev_str',192)
		xgt 'tsarev_events','stealing_keys'
	end
end
! ключи своровали, уходим
if $args[0] = 'stealing_keys_ender':
	cla
	killvar '_key_place'
	killvar '_key_times'
	$npc['26,qwMain'] = 55
	gs 'zz_render','','',func('tsarev_str',194)
	act 'Переодеться и уйти': gt 'zz_school'
end
!---
! гг крадется в дом учителя
if $args[0] = 'teacher_house_lurking':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/lurking/12',func('tsarev_str',195)
	act '...':
		*clr & cla
		minut += rand(10,20)
		gs 'stat'
		$npc['26,qwMain'] = 55
		$npc['26,qwMain_day'] = day
		gs 'zz_render','Картинки нет','pavlovo/tsarev/lurking/13',func('tsarev_str',196)
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
end
! разводим ветки, отсекая одну из них
if $args[0] = 'teacher_choice':
	*clr & cla
	gs 'zz_render','','pavlovo/tsarev/lurking/14',func('tsarev_str',197)
	act 'Расследовать тайны учителя':
		cla
		$npc['26,qwMain'] = 100
		gs 'zz_render','','',func('tsarev_str',198) + func('tsarev_str',200)
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
	act 'Учиться сексу у Анатолия Евгеньевича':
		cla
		!$npc['26,qwMain'] = 200
		gs 'zz_render','','',func('tsarev_str',199) + func('tsarev_str',200)
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
	act 'Подумать еще': minut += rand(10,15) & gt 'gorodok'
end
!---
! ветка детективная - зацепка-1 - первый визит
if $args[0] = 'teacher_choice_detective1':
	*clr & cla
	minut += rand(20,30)
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/detective/0',func('tsarev_str',201) + func('tsarev_str',202)
	$npc['26,qwMain'] = 101
	$npc['26,qwMain_day'] = day
	act 'Уйти': minut += rand(10,15) & gt 'gorodok'
end
! ветка детективная - зацепка-1 - второй визит
if $args[0] = 'teacher_choice_detective2':
	*clr & cla
	minut += rand(20,30)
	gs 'stat'
	$npc['26,qwMain_day'] = day
	gs 'zz_render','','pavlovo/tsarev/detective/1',func('tsarev_str',201) + func('tsarev_str',203)
	act 'Вернуть все на место':
		*clr & cla
		$npc['26,qwMain'] = 102
		gs 'zz_render','','pavlovo/tsarev/detective/2',func('tsarev_str',204)
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
	act 'Рассматривать фотографии':
		*clr & cla
		$npc['26,qwMain'] = 255
		gs 'zz_render','','pavlovo/tsarev/detective/3',func('tsarev_str',205)
		act 'Бросить все':
			*clr & cla
			gs 'zz_render','','pavlovo/tsarev/detective/4',func('tsarev_str',206)
			act 'Свалить': minut += rand(10,15) & gt 'gorodok'
		end
		act 'Собирать':
			*clr & cla
			gs 'zz_render','','pavlovo/tsarev/detective/5',func('tsarev_str',207)
			act '...': gt 'gameover',11
		end
	end
end
! ветка детективная - зацепка-1 - третий визит
if $args[0] = 'teacher_choice_detective3':
	*clr & cla
	minut += rand(20,30)
	$npc['26,qwMain'] = 103
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/detective/6',func('tsarev_str',208)
	if intel < 50:
		gs 'zz_render','','',func('tsarev_str',209)
	else
		gs 'zz_render','','',func('tsarev_str',210)
	end
	act 'Уйти': minut += rand(10,15) & gt 'gorodok'
end
! ветка детективная - зацепка-1 - ГГ в своей комнате размышляет
if $args[0] = 'teacher_choice_detective4':
	*clr & cla
	minut += rand(5,15)
	$npc['26,qwMain'] = 105
	gs 'stat'
	gs 'zz_render','','pavlovo/tsarev/detective/6',func('tsarev_str',208)
	gs 'zz_render','','',func('tsarev_str',200)
	act '...': gt 'bedrPar'
end