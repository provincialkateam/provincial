! ивент с прогулами, повторяемый
! absent['stage'] - стадия ивента:
!  0 - закрыт, достаточного количества прогулов не набралось
!  1 - ГГ в коридоре ловит завуч и отправляет к директору, необходим для случая с нажатием на аварийку
!  2 - разговор с директором
!  3 - ГГ неудачно пошутила - дома ждет разговор с матерью
!  4 - ГГ надо принести справку
!  5 - ГГ согласилась отработать
!  6 - ГГ получила справку у доктора
! absent['counter'] - количество отработанных дней
! absent['sex'] - был ли секс с директором по ивенту, нужен для проверки при повторе ивента
! absent['daycounter'] - счетчик ожидания справки или отработки ГГ, если ГГ не приходит к директору на отработку больше трех дней или не приносит справку - переход к варианту с матерью
!----------
! проверка количества прогулов
if $args[0] = 'check':
	if absent['daycounter'] > 0 and absent['stage'] = 0: absent['daycounter'] = 0
	if school['absent'] >= 20 and absent['stage'] = 0:
		absent['stage'] = 1
		xgt 'absent_events','init'
	elseif absent['daycounter'] > 3 or absent['stage'] = 6:
		gt 'absent_events','director'
	end
end
! старт ивента с прогулами
if $args[0] = 'init':
	cla
	gs 'zz_render','','',func('absent_str',0)
	absent['stage'] = 2
	act 'Идти к директору':
		*clr & cla
		gs 'zz_render','','pavlovo/school/absence/0',func('absent_str',1)
		act 'Пошутить':
			*clr & cla
			absent['stage'] = 3
			! ухудшение отношений с матерью
			gs 'zz_render','','pavlovo/school/absence/1',func('absent_str',4)
			act 'Уйти': gt 'zz_school'
		end
		act 'Плести небылицы':
			*clr & cla
			! справка спишет 10 прогулов
			gs 'zz_render','','pavlovo/school/absence/2',func('absent_str',2)
			! если по ивенту уже был секс - справка не катит
			if absent['sex'] > 0:
				gs 'zz_render','','',func('absent_str',6)
				act 'Согласиться на отработку':
					*clr & cla
					absent['stage'] = 5
					gs 'zz_render','','pavlovo/school/absence/2',func('absent_str',7)
					act 'Уйти': gt 'zz_school'
				end
				act 'Не соглашаться на отработку':
					*clr & cla
					absent['stage'] = 3
					gs 'zz_render','','pavlovo/school/absence/2',func('absent_str',8)
					act 'Уйти': gt 'zz_school'
				end
			else
				absent['stage'] = 4
				gs 'zz_render','','',func('absent_str',3)
			end
			act 'Уйти': gt 'zz_school'
		end
		if shameless['flag'] > 1:
			act 'Соблазнять':
				*clr & cla
				absent['stage'] = 5
				! отработка, 3+секс либо 5 раз
				! в случае секса - повторно возможен только вариант с сексом
				gs 'zz_render','','pavlovo/school/absence/2',func('absent_str',4)
				act 'Уйти': gt 'zz_school'
			end
		end
	end
	exit
end
! ГГ идет по справку в поликлинику
if $args[0] = 'gt_clinic':
	*clr & cla
	gs 'zz_render','','pavlovo/school/absence/clinic/0.webm',func('absent_str',9)
	if money >= 3000:
		act 'Заплатить 3000 р.':
			*clr & cla
			money -= 3000
			absent['stage'] = 6
			gs 'stat'
			gs 'zz_render','','pavlovo/school/absence/clinic/1.webm',func('absent_str',13)
			act 'Уйти': gt 'gpoli'
		end
	end
	if mesec = 0 and shameless['flag'] > 1:
		act 'Заплатить натурой':
			*clr & cla
			absent['stage'] = 6
			gs 'zz_render','','pavlovo/school/absence/clinic/2.webm',func('absent_str',11)
			act 'Сосать':
				*clr & cla
				gs 'zz_render','','pavlovo/school/absence/clinic/3.webm',func('absent_str',12)
				act '...':
					*clr & cla
					gs 'zz_render','','pavlovo/school/absence/clinic/1.webm',func('absent_str',13)
					act 'Уйти': gt 'gpoli'
				end
			end
		end
	end
	act 'Не платить':
		*clr & cla
		gs 'zz_render','','pavlovo/school/absence/clinic/0.webm',func('absent_str',10)
		act 'Уйти': gt 'gpoli'
	end
	exit
end
! ГГ приносит справку директору или приходит на беседу без нее
if $args[0] = 'director':
	*clr & cla
	gs 'zz_render','','',func('absent_str',0)
	act 'Идти к директору':
		*clr & cla
		if absent['stage'] = 6:
			! гг принесла справку
			gs 'zz_render','','pavlovo/school/absence/3',func('absent_str',14)
			school['absent'] -= 20
			if school['absent'] < 0: school['absent'] = 0
			absent['stage'] = 0
			absent['daycounter'] = 0
			act 'Уйти': gt 'zz_school'
		elseif absent['daycounter'] > 3:
			!гг не принесла справку или не явилась на протяжении трех дней на отработку
			gs 'zz_render','','pavlovo/school/absence/2',func('absent_str',iif(absent['stage']=4,15,16))
			absent['stage'] = 3
			absent['daycounter'] = 0
			act 'Уйти': gt 'zz_school'
		end
	end
	exit
end
! ГГ идет на отработку к директору
if $args[0] = 'gt_director_home':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','pavlovo/school/absence/maid/0',func('absent_str',iif(absent['counter']=0,17,18))
	act 'Убирать':
		*clr & cla
		minut += rand(50,70)
		gs 'stat'
		gs 'zz_render','','pavlovo/school/absence/maid/'+iif(absent['counter'] < 3,absent['counter']+1,'4.webm'),func('absent_str',absent['counter'] + 19)
		act 'Закончить уборку':
			*clr & cla
			absent['counter'] += 1
			if absent['counter'] = 5:
				gs 'zz_render','','pavlovo/school/absence/maid/10',func('absent_str',30)
				absent['counter'] = 0
				absent['stage'] = 0
				school['absent'] = 0
			else
				gs 'zz_render','','pavlovo/school/absence/maid/10',func('absent_str',22)
			end
			act 'Уйти': gt 'gorodok'
		end
		if absent['counter'] >= 3 or absent['sex'] > 0:
			act 'Соблазнить':
				*clr & cla
				gs 'zz_render','','pavlovo/school/absence/maid/5.webm',func('absent_str',23)
				act 'Целоваться':
					*clr & cla
					horny += 40
					minut += rand(5,10)
					if absent['sex'] = 0: guy += 1
					gs 'stat'
					gs 'zz_render','','pavlovo/school/absence/maid/5.webm',func('absent_str',24)
					act 'Сосать':
						*clr & cla
						bj += 1
						horny += 40
						gs 'stat'
						gs 'zz_render','','pavlovo/school/absence/maid/6.webm',func('absent_str',25)
						act '...': gt 'absent_events','director_sex_ender'
					end
					if mesec = 0:
						act 'Стать рачком':
							*clr & cla
							sex += 1
							horny += 40
							gs 'stat'
							gs 'zz_render','','pavlovo/school/absence/maid/7.webm',func('absent_str',26)
							act '...': gt 'absent_events','director_sex_ender'
						end
					end
					act 'На боку':
						*clr & cla
						anal += 1
						horny += 40
						gs 'stat'
						gs 'zz_render','','pavlovo/school/absence/maid/8.webm',func('absent_str',27)
						act '...': gt 'absent_events','director_sex_ender'
					end
				end
			end
		end
	end
	exit
end
if $args[0] = 'director_sex_ender':
	*clr & cla
	horny = 0
	orgasm += 1
	manna += rand(10,20)
	minut += rand(10,15)
	gs 'stat'
	gs 'zz_render','','pavlovo/school/absence/maid/9.webm',func('absent_str',28)
	act 'В душ':
		*clr & cla
		minut += rand(10,15)
		gs 'zz_bathroom','clean_me'
		gs 'stat'
		gs 'zz_render','','pavlovo/school/absence/maid/10',func('absent_str',29)
		absent['counter'] = 0
		absent['stage'] = 0
		school['absent'] = 0
		absent['sex'] += 1
		act 'Уйти': gt 'gorodok'
	end
end