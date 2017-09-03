if $ARGS[0] = 'timofei':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Подъезд', 'images/city/south/front_door/entryway.jpg','Неожиданно вы столкнулись в подъезде с молодым парнем, который чуть ли не бегом влетел на лестницу. Он отпрыгнул от вас и заметно смутился:**\\\- Ой извините, я вас не заметил. Вы в '+iif(BuyHous ! 1,'69','70')+'-ой квартире поселились?///'
	act 'Да':
		*clr & cla
		sosedQW = 1
		minut += 5
		gs'stat'
		gs 'zz_render', 'Подъезд', 'images/city/south/front_door/entryway.jpg','Вы кивнули головой подтверждая, что живете в '+iif(BuyHous ! 1,'69','70')+'-ой квартире. Парень заметно обрадовался и сказал:**\\\- Замечательно! Раньше там жил Петрович, алкаш редкий. Весь подъезд замучил. Меня кстати Тимофеем зовут, а вас?///'
		act '<<$name[1]>>':
			*clr & cla
			gs'stat'
			gs 'zz_render', 'Подъезд', 'images/city/south/front_door/entryway.jpg','Вы сказали парню что вас зовут <<$name_b[1]>>. Он кивнул головой и достав ключи начал открывать дверь 68-ой квартиры:**\\\- Очень приятно. Я как видите в соседней квартире живу, 68-й. А видите '+iif(BuyHous ! 1,'70','69')+'-ю квартиру? Она '+iif(BuyHous ! 1,'продаётся','сдаётся')+'. Ну это так, для информации, вдруг понадобится.///**Парень открыл дверь и на пороге показалась любопытное лицо пожилой женщины. Она направила на вас свой острый нос и стала с любопытством осматривать.**\\\- Мам, ну хватит уже торчать перед дверью!, -/// сказал Тимофей, входя в квартиру и закрывая за собой дверь.'
			act '...': gt 'front_door','start'
		end
	end
end
!Стартовые условия: зайти на чердак, подойти к группе гогочущей молодежи.
if $args[0] = 'cherdak_ev1':
	*clr & cla
	_stage = args[1]
	minut += 3
	if _stage >= 4 and _stage <= 9: horny += 15
	gs 'stat'
	gs 'zz_render', '', 'city/south/front_door/cherdak/event1/'+iif(_stage <= 1,1,_stage),func('front_door_event_str',_stage)
	act iif(_stage < 14,'...','Уйти'):
		if _stage < 14:
			if _stage = 10:
				orgasm += 1
				DPorgasm += 1
				horny = 0
			end
			gt 'front_door_event','cherdak_ev1',_stage+1
		else
			dom -= 1
			vagina += 1
			city['cherdak'] += 1
			city['cherdak_day'] = day
			gs 'zz_funcs', 'cum', 'pussy'
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
			killvar '_stage'
			gt 'front_door'
		end
	end
end
!---
if $args[0] = 'front_ev1_init':
	*clr & cla
	gs 'zz_render','','city/south/front_door/cherdak/event2/1',func('front_door_event_str',15)
	act 'Отвалите!':
		*clr & cla
		gs 'zz_render','','city/south/front_door/cherdak/event2/2',func('front_door_event_str',16)
		act 'Попробовать сбежать':
			*clr & cla
			gs 'zz_render','','city/south/front_door/cherdak/event2/4',func('front_door_event_str',31)
			if speed > 50:
				gs 'zz_render','','',func('front_door_event_str',32)
				act '...': gt 'front_door'
			else
				gs 'zz_render','','',func('front_door_event_str',33)
				act '...':
					*clr & cla
					gs 'zz_render','','city/south/front_door/cherdak/event2/3.gif',func('front_door_event_str',17)
					act '...': gt 'front_door_event','front_ev1'
				end
			end
		end
		act 'Идти с парнями':
			*clr & cla
			gs 'zz_render','','city/south/front_door/cherdak/event2/5',func('front_door_event_str',30)
			act '...': gt 'front_door_event','front_ev1'
		end
	end
end
!---
if $args[0] = 'front_ev1':
	*clr & cla
	_stage = args[1]
	if _stage < 8: horny += 15
	minut += 3
	gs 'stat'
	gs 'zz_render','','city/south/front_door/cherdak/event2/'+(6+_stage)+iif(_stage=0 or _stage=2 or _stage=10,'.webm','.jpg'),func('front_door_event_str',18+_stage)
	act iif(_stage <= 10,'...','Уйти'):
		if _stage <= 10:
			if _stage = 8:
				orgasm += 1
				DPorgasm += 1
				horny = 0
			end
			gt 'front_door_event','front_ev1',_stage+1
		else
			dom -= 3
			vagina += 1
			city['cherdak'] += 1
			city['cherdak_day'] = day
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
			killvar '_stage'
			gt 'front_door'
		end
	end
end
!---
if $args[0] = 'front_ev2':
	*clr & cla
	_stage = args[1]
	if _stage >= 1 and _stage <= 4: horny += 20
	minut += 3
	gs 'stat'
	gs 'zz_render','','city/south/front_door/cherdak/event3/<<_stage+1>>.webm',func('front_door_event_str',34+_stage)
	if _stage = 0:
		city['cherdak_day'] = day
		act 'Сбежать квартиру': gt 'apartment_south_event'
		act 'Улыбнуться': gt 'front_door_event','front_ev2',1
	else
		act iif(_stage <= 8,'...','Уйти'):
			if _stage <= 8:
				if _stage = 6:
					orgasm += 1
					vaginalorgasm += 1
					horny = 0
				end
				gt 'front_door_event','front_ev2',_stage+1
			else
				city['cherdak'] += 1
				gs 'zz_funcs', 'cum', 'lip'
				killvar '_stage'
				gt 'front_door'
			end
		end
	end
end