$loc = $curloc
if $args[0] = '':
	*clr & cla
	frost = 0
	gs 'stat'
	gs 'zz_render','Студия Relax','images/city/south/relax/0','Дорогое гламурное место для занятий йогой. Также здесь есть массажный кабинет и сауна.'
	act '<b>Уйти</b>': gt 'south'
	act 'Йога (1000 р.)':
		if func('zz_funcs','money',1000) = 1:
			*clr & cla
			manna += rand(20,30)
			if agil < 40: agil += 1
			sport += 1
			gs 'zz_funcs','sport'
			minut += 60
			gs 'stat'
			gs 'zz_render','','images/city/south/relax/0/<<rand(0,2)>>'
			act 'Уйти': gt 'relax'
		end
	end
!---
! рандомный секс-массаж в салоне Релакс. Шанс - 50% при возбуждении >20.
!---
	if massageday ! day:
		act 'Массаж (500 р.)':
			if func('zz_funcs','money',500) = 1:
				if rand(0,100) >= 50 and horny > 20:
					*clr & cla
					_stage=1
					gs 'zz_render','','images/city/south/relax/random/massage/m1.jpg', func('relax_event_data', 'relax_event_1', _stage)
					act 'Далее': gt $curloc, 'relax_event_1'
				else:
					*clr & cla
					massageday = day
					manna += rand(20,30)
					health += rand(3,7)
					vidageday -= 3
					minut += 30
					gs 'stat'
					gs 'zz_render','','images/city/south/relax/1/<<rand(0,2)>>', func('relax_event_data', 'relax_event_1', 0)
					act 'Уйти': gt 'relax'
				end
			end
		end
	end
	if saunaday ! day:
		act 'Сауна (2000 р.)':
			if func('zz_funcs','money',2000) = 1:
				*clr & cla
				saunaday = day
				manna += rand(20,30)
				health += rand(3,7)
				vidageday -= 3
				body['day_weight'] -= 3
				gs 'zz_funcs','skin','-'
				minut += 60
				gs 'zz_bathroom','clean_me'
				gs 'stat'
				gs 'zz_render','','images/city/south/relax/2/<<rand(0,1)>>'
				act 'Уйти': gt 'relax'
			end
		end
	end
end
!---
! здесь самое место для пошлых и не очень ивентов
!---
if $args[0] = 'relax_event_1':
	*clr & cla
	_stage += 1
	if _stage <= 17:
		$_m_img = func('zz_funcs','get_item_string','1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18',_stage)
		gs 'zz_render','','images/city/south/relax/random/massage/m' + $_m_img + '.webm', func('relax_event_data', $args[0], _stage)
		if _stage = 10:
			act 'Далее': gt $curloc,'relax_event_1'
			act 'Сказать массажисту, чтобы держал себя в руках':
				*clr & cla
				massageday = day
				manna += rand(20,30)
				health += rand(3,7)
				vidageday -= 3
				minut += 30
				gs 'stat'
				gs 'zz_render','','images/city/south/relax/1/<<rand(0,2)>>', func('relax_event_data', $args[0], 20)
				act 'Уйти': gt 'relax'
			end
		end
		act 'Далее': gt $curloc,'relax_event_1'
	else:
		massageday = day
		manna = 100
		health += 10
		skin += 2
		orgasm += 4
		sex += 1
		bj += 1
		horny = 0
		minut += 30
		gs 'stat'
		gs 'zz_render','','images/city/south/relax/1/<<rand(0,2)>>', func('relax_event_data', $args[0], _stage)
		act 'Уйти': gt 'relax'
	end
end
!---
! из ТЗ - manna = 100, состояние кожи += 2, здоровье += 10, оргазмы в статистику +4, vagina_sex и oral_sex в статистику +1.
!---