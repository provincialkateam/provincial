! групповушка с неграми - начало в кафешке
! доступно только после секса с Демаркусом
if $args[0] = 'park_group_init':
	*clr & cla
	$npc['47,day'] = day
	gs 'zz_render','','city/center/university/dorm/niger/0',func('npc_niger_str',0)
	act 'Подойти':
		*clr & cla
		gs 'zz_render','','city/center/university/dorm/niger/1',func('npc_niger_str',1)
		act '...':
			*clr & cla
			minut += rand(15,30)
			gs 'zz_funcs','alko',4
			gs 'stat'
			gs 'zz_render','','city/center/university/dorm/niger/2',func('npc_niger_str',2)
			act 'Идти в общагу': minut += rand(20,40) & gt 'npc_niger','first_sex'
			act 'Отказаться и уйти': gt 'zz_park'
		end
	end
	act 'Лучше свалить...': gt 'zz_park'
end
if $args[0] = 'first_sex':
	*clr & cla
	_stage = args[1]
	minut += rand(2,5)
	if _stage < 5:
		horny += rand(15,20)
		if _stage = 3:
			gs 'zz_funcs','set_gape','vagina',horny,val($npc['47,dick']),val($npc['47,silavag'])
			gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),val($npc['47,dick']),val($npc['47,silavag'])
		end
	elseif stage = 5:
		horny = 0
	else
		horny += rand(3,7)
	end
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/niger/'+(_stage+3),func('npc_niger_str',_stage+3)
	act iif(_stage < 8,'...','Привести себя в порядок и уйти'):
		if _stage < 8:
			gt 'npc_niger','first_sex',_stage+1
		else
			$npc['47,nigraQW'] = 5
			guy += 2
			gang += 1
			sex += 1
			anal += 1
			swallow += 3
			bj += 3
			mop = 1
			gt 'uni_dorm','3'
		end
	end
end