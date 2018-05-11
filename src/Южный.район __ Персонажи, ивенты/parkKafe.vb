if $ARGS[0] = 'food':
	if money < 400:
		gs 'zz_render', '', 'common/park/park_cafe/no', func('parc_kafe_strings', 'local_str1')
		act 'Уйти': gt 'zz_park'
		exit
	end
	cla
	money -= 400
	gs 'zz_kitchen_acts', 'eat', 'lunch','',func('parc_kafe_strings', 'local_str5')
	gs 'zz_kitchen_acts', 'drink', 'tea'
	killvar '$zz_str'
	$zz_str[0] = 'компанию гуляющей <a href="exec:GT ''parkKafe'',''молодёжь''">молодёжи</a>'
	$zz_str[1] = 'одиноко сидящего молодого парня.'
	$zz_str[2] = '<a href="exec:GT ''parkKafe'',''женщина''">женщину</a> властного вида'
	$zz_str[3] = 'солидного <a href="exec:GT ''parkKafe'',''мужчина''">мужчину</a> в возрасте'
	$zz_str[4] = 'двух <a href="exec:GT ''parkKafe'',''кавказцы''">кавказцев</a> сидящих за столом'
	if $npc['47,day'] ! day:
		if $npc['47,mainQW'] >= 5 and $npc['47,nigraQW'] = 0:
			$zz_str[5] = '<a href="exec:GT ''npc_demarkus'',''park_group''">Демаркуса в компании друзей</a> из солнечной Африки.'
		else
			$zz_str[5] = 'огромного <a href="exec:GT ''npc_demarkus'',''park_init''">африканца'+iif($npc['47,mainQW']>0,' Демаркуса.','.')+'</a>'
		end
	end
	gs 'zz_render','','','Вы осматриваете посетителей кафе и замечаете ' + $zz_str[rand(0,arrsize('$zz_str')-1)]
	killvar '$zz_str'
	gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str5')
	 act 'Уйти':
        if $loc = 'zoo':
            gt 'zoo','inside'
        else
            gt 'zz_park'
        end
    end
end
if $ARGS[0] = 'кавказцы':
	cla
	if RAND(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str15')
		act 'Идти домой':gt'zz_park','main'
	else
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str16')
		act 'Уйти':gt'zz_park','main'
		act 'Выпить вместе':
			*clr & cla
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str17')
			if RAND(1,2) = 1:
				if parkarman = 0:guy += 2 & parkarman = 1
				bj += 2
				gs 'zz_render', '', 'images/pics/ara.jpg', func('parc_kafe_strings', 'local_str18')
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'hornyrand'
				gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str19')
				act 'Уйти':gt'zz_park','main'
			else
				if parkarman = 0: guy += 2 & parkarman = 1
				sex += 1
				bj += 1
				gang += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'ass'
				vagina += 1
				gs 'zz_render', '', 'images/pics/ara2.jpg', func('parc_kafe_strings', 'local_str20')
				gs 'zz_funcs', 'hornyrand'
				gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str21')
				act 'Уйти':gt'zz_park','main'
			end
		end
	end
end
if $ARGS[0] = 'мужчина':
	cla
	if RAND(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str22')
		act 'Уйти':gt'zz_park','main'
	else
		cla
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str23')
		act 'Танцевать':
			cla
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str24')
			act 'В сауну':
				cla
				if saunasex = 0: saunasex = 1 & guy += 1
				sex += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'ass'
				horny = 0
				vagina += 1
				gs 'zz_render', '', 'images/pics/sauna2.jpg', func('parc_kafe_strings', 'local_str25')
				gs 'zz_funcs', 'hornyrand'
				act 'Уйти':gt'south'
			end
		end
		act 'Уйти':gt'zz_park','main'
	end
end
if $ARGS[0] = 'женщина':
	cla
	gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str26')
	act 'Уйти':gt'zz_park','main'
end
if $ARGS[0] = 'молодёжь':
	cla
	if rand(1,2) = 1:
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str27')
		act 'Уйти':gt'zz_park','main'
	else
		gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str28')
		act 'Уйти':gt'zz_park','main'
		act 'Компания':
			cla
			gs 'zz_render', '', '', func('parc_kafe_strings', 'local_str29')
			act 'Уйти':gt'zz_park','main'
			act 'Ехать вместе со всеми':
				*clr & cla
				gs 'zz_render', '', 'images/pics/Student.jpg', func('parc_kafe_strings', 'local_str30')
				act 'Уйти':gt'zz_park','main'
				act 'Встать на колени рядом с девушкой в круг из парней':
					*clr & cla
					hour = 22
					son = 0
					if studentsex = 0: studentsex = 1 & guy += 6
					bj += 6
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 6
					gs 'zz_render', '', 'images/pics/Student2.jpg', func('parc_kafe_strings', 'local_str31')
					act 'Целоваться с девушкой':
						*clr & cla
						gs 'zz_render', '', 'images/pics/Student3.jpg', func('parc_kafe_strings', 'local_str32')
						act 'Уйти':gt'south'
					end
				end
			end
		end
	end
end