! нигра Демаркус
! знакомство - либо в общаге, либо в кафешке в парке
! полноценный доступ к телу возможен только при условии учебы в универе
!----------------------------------
! $npc['47,day'] - день ивента с Демаркусом
! $npc['47,mainQW'] - стадии ветки Демаркуса
! 0 - ветка не начата, доступно знакоство в парке
! 5 - ГГ знакома с Демаркусом
! $npc['47,nigraQW'] - стадии ветки Демаркуса и нигров
! 0 - не начата
! 5 - после первой групповушки в общаге
!----
! знакомство в парке
if $args[0] = 'park_init':
	*clr & cla
	$npc['47,day'] = day
	gs 'zz_render','','city/center/university/dorm/demarkus/0',func('npc_demarkus_str',0) + iif($npc['47,mainQW'] > 0,func('npc_demarkus_str',1),'')
	if $npc['47,mainQW'] > 0:
		act 'Поболтать':
			*clr & cla
			gs 'npc_editor','change_rep','+',47,2
			gs 'zz_render','','city/center/university/dorm/demarkus/1',func('npc_demarkus_str',2)
			if $npc['47,sex'] > 0 and ((vagina >= 15 and mesec = 0) or anus >= 15): act 'Развлечься с Демаркусом': gt 'npc_demarkus','toilet_fuck'
			act 'Уйти из кафе': gt 'zz_park'
		end
		act 'Уйти из кафе': gt 'zz_park'
	else
		act 'Поразглядывать':
			*clr & cla
			minut += rand(5,10)
			gs 'stat'
			gs 'zz_render','','city/center/university/dorm/demarkus/0',func('npc_demarkus_str',4)
			act 'Уйти из кафе': gt 'zz_park'
		end
		if shameless['flag'] >= 2:
			act 'Привлечь внимание':
				*clr & cla
				gs 'zz_render','','city/center/university/dorm/demarkus/2',func('npc_demarkus_str',5)
				act 'Приподнять юбку':
					*clr & cla
					gs 'zz_render','','city/center/university/dorm/demarkus/3',func('npc_demarkus_str',6)
					if vnesh < 40:
						i = 0
					elseif vnesh < 60:
						i = iif(rand(0,3) = 1,1,0)
					else
						i = rand(0,1)
					end
					!--
					if i = 0:
						gs 'zz_render','','',func('npc_demarkus_str',7)
						manna -= 5
						minut += rand(2,5)
						gs 'stat'
						act 'Да пошел он!': gt 'zz_park'
					else
						gs 'zz_render','','',func('npc_demarkus_str',8)
						act 'Да ну на хрен!': gt 'zz_park'
						act 'Подсесть к африканцу':
							*clr & cla
							$npc['47,mainQW'] = 5
							$npc['47,know'] = 1
							gs 'npc_editor','change_rep','+',47,5
							gs 'stat'
							gs 'zz_render','','city/center/university/dorm/demarkus/4',func('npc_demarkus_str',9)
							act 'Отказаться': gt 'npc_demarkus','park_decline'
							act 'Выпить':
								*clr & cla
								minut += rand(10,15)
								gs 'zz_funcs','alko',4
								gs 'stat'
								gs 'zz_render','','city/center/university/dorm/demarkus/5',func('npc_demarkus_str',10)
								act 'Поиграться ножкой':
									*clr & cla
									minut += rand(2,5)
									horny += rand(5,10)
									gs 'stat'
									gs 'zz_render','','city/center/university/dorm/demarkus/6',func('npc_demarkus_str',11)
									act 'Развлечься с Демаркусом': gt 'npc_demarkus','toilet_fuck'
									act 'Продинамить': gt 'npc_demarkus','park_decline'
								end
							end
						end
					end
				end
				act 'Да пошел он!': gt 'zz_park'
			end
		end
	end
end
! ГГ динамит Демаркуса в парке
if $args[0] = 'park_decline':
	*clr & cla
	minut += rand(2,5)
	gs 'npc_editor','change_rep','-',47,3
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/2',func('npc_demarkus_str',3)
	act 'Уйти из кафе': gt 'zz_park'
end
! секс в туалете кафешки
if $args[0] = 'toilet_fuck':
	*clr & cla
	_stage = args[1]
	horny += rand(7,15)
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+(8 + _stage),func('npc_demarkus_str',13+_stage)
	if _stage < 3:
		act '...': gt 'npc_demarkus','toilet_fuck',_stage+1
	else
		if $npc['47,sex'] = 0: guy += 1
		$npc['47,sex'] += 1
		bj += 1
		killvar '_stage'
		if vagina >= 15 and mesec = 0: act 'Дать в киску': gt 'npc_demarkus','toilet_fuck_vag'
		if anus >= 15: act 'Дать в попку': gt 'npc_demarkus','toilet_fuck_anal'
		! если что-то пошло не так и дырки не рабочие - минет всех спасет
		act 'Сосать дальше': gt 'npc_demarkus','toilet_fuck_bj'
	end
end
! секс в туалете кафешки - вагинал
if $args[0] = 'toilet_fuck_vag':
	*clr & cla
	_stage = args[1]
	horny += rand(5,10)
	if _stage = 0: gs 'zz_funcs','set_gape','vagina',horny,val($npc['47,dick']),val($npc['47,silavag'])
	if _stage = 4: horny = 0
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+(12 + _stage),func('npc_demarkus_str',17+_stage)
	act iif(_stage < 6,'...','Привести себя в порядок и уйти'):
		if _stage < 6:
			gt 'npc_demarkus','toilet_fuck_vag',_stage+1
		else
			sex += 1
			orgasm += 1
			mop = 1
			facial += 1
			killvar '_stage'
			gt 'zz_park'
		end
	end
end
! секс в туалете кафешки - вагинал
if $args[0] = 'toilet_fuck_anal':
	*clr & cla
	_stage = args[1]
	horny += rand(5,10)
	if _stage = 0: gs 'zz_funcs','set_gape','vagina',iif(lubri>0,10,0),val($npc['47,dick']),val($npc['47,silavag'])
	if _stage = 5: horny = 0
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+iif(_stage<6,19+_stage,11+_stage),func('npc_demarkus_str',24+_stage)
	act iif(_stage < 7,'...','Привести себя в порядок и уйти'):
		if _stage < 7:
			gt 'npc_demarkus','toilet_fuck_anal',_stage+1
		else
			anal += 1
			orgasm += 1
			analorgasm += 1
			if lubri > 0: lubri -= 1
			mop = 1
			facial += 1
			killvar '_stage'
			gt 'zz_park'
		end
	end
end
! секс в туалете кафешки - орал
if $args[0] = 'toilet_fuck_bj':
	*clr & cla
	horny += rand(5,10)
	minut += rand(2,5)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/25',func('npc_demarkus_str',32)
	act '...':
		*clr & cla
		horny += rand(5,10)
		minut += rand(2,5)
		gs 'stat'
		gs 'zz_render','','city/center/university/dorm/demarkus/17',func('npc_demarkus_str',22)
		act '...':
			*clr & cla
			horny += rand(5,10)
			minut += rand(2,5)
			gs 'stat'
			gs 'zz_render','','city/center/university/dorm/demarkus/18',func('npc_demarkus_str',23)
			act 'Привести себя в порядок и уйти':
				minut += rand(5,10)
				bj += 1
				mop = 1
				facial += 1
				gt 'zz_park'
			end
		end
	end
end
!---
! комната Демаркуса в общаге
!---
if $args[0] = 'dorm_room':
	*clr & cla
	if hour <= 16:
		gs 'zz_render','','city/center/university/dorm/interiors/locked','Похоже, никого нет дома.'
		act 'Уйти': gt 'uni_dorm','3'
		exit
	end
	gs 'zz_render','','city/center/university/dorm/room/demarkus'
	if $npc['47,day'] ! day:
		gt 'npc_demarkus','visit'
	else
		act 'Поболтать с Демаркусом':
			*clr & cla
			gs 'npc_editor','get_npc_profile',47
			act 'Отойти': gt 'npc_demarkus','dorm_room'
		end
		act 'Уйти': gt 'uni_dorm','3'
	end
end
! визит в комнату Демаркуса в общаге
if $args[0] = 'visit':
	*clr & cla
	_stage = args[1]
	if _stage = 1:
		gs 'zz_funcs','alko',4
		minut += rand(20,30)
	elseif _stage > 1:
		horny += rand(5,10)
		minut += rand(2,5)
	end
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+(26+_stage),func('npc_demarkus_str',33+_stage)
	act iif(_stage=0,'Выпить','...'):
		if _stage < 7:
			gt 'npc_demarkus','visit',_stage+1
		else
			bj += 1
			$npc['47,day'] = day
			! выбор развития в зависимости от разработанности ГГ
			! если не было секса при знакомстве - будет минет
			if $npc['47,sex'] > 0:
				guy += 1
				gt 'npc_demarkus','visit_bj'
			else
				! если дырки больше 15 - рандомно
				if vagina >= 15 and anus >= 15:
					gt 'npc_demarkus',iif(rand(0,2)=1,'visit_sex','visit_sex')
				elseif vagina >= 15:
					gt 'npc_demarkus','visit_sex'
				elseif anus >= 15:
					gt 'npc_demarkus','visit_anal'
				else
					! если обе дырки меньше 15 - минет
					gt 'npc_demarkus','visit_bj'
				end
			end
		end
	end
end
! минет при визите к Демаркусу
if $args[0] = 'visit_bj':
	*clr & cla
	_stage = args[1]
	if _stage < 3:
		horny += rand(15,20)
	else
		horny = 0
	end
	minut += rand(3,7)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+(39+_stage),func('npc_demarkus_str',46+_stage)
	act iif(_stage < 4,'...','Привести себя в порядок и уйти'):
		if _stage < 4:
			gt 'npc_demarkus','visit_bj',_stage+1
		else
			$npc['47,sex'] += 1
			mop = 1
			facial += 1
			killvar '_stage'
			gt 'uni_dorm','3'
		end
	end
end
! вагинал при визите к Демаркусу
if $args[0] = 'visit_sex':
	*clr & cla
	_stage = args[1]
	if _stage = 0: gs 'zz_funcs','set_gape','vagina',horny,val($npc['47,dick']),val($npc['47,silavag'])
	if _stage < 3:
		horny += rand(15,20)
	else
		horny = 0
	end
	minut += rand(3,7)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+(34+_stage),func('npc_demarkus_str',41+_stage)
	act iif(_stage < 4,'...','Привести себя в порядок и уйти'):
		if _stage < 4:
			gt 'npc_demarkus','visit_sex',_stage+1
		else
			sex += 1
			orgasm += 1
			$npc['47,sex'] += 1
			mop = 1
			facial += 1
			killvar '_stage'
			gt 'uni_dorm','3'
		end
	end
end
! анал при визите к Демаркусу
if $args[0] = 'visit_anal':
	*clr & cla
	_stage = args[1]
	if _stage = 2: gs 'zz_funcs','set_gape','anal',10,val($npc['47,dick']),val($npc['47,silavag'])
	if _stage < 5:
		horny += rand(15,20)
	else
		horny = 0
	end
	minut += rand(3,7)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/demarkus/'+(44+_stage),func('npc_demarkus_str',51+_stage)
	act iif(_stage < 6,'...','Привести себя в порядок и уйти'):
		if _stage < 6:
			gt 'npc_demarkus','visit_anal',_stage+1
		else
			anal += 1
			analOrgasm += 1
			$npc['47,sex'] += 1
			mop = 1
			facial += 1
			killvar '_stage'
			gt 'uni_dorm','3'
		end
	end
end