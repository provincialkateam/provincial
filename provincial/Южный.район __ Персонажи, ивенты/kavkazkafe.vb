if $ARGS[0] = 'podgivi':
	gs'npc_editor','init_sex',34
	gs 'dinsexgivi'
	minut += 30
	gs 'stat'
	if $npc['44,qwIrinaSlut'] >= 2:
		*clr & cla
		smenaKafe += 1
		if RAND(0,1) = 0:
			gs 'zz_render','','',func('kavkazkafe_strings','local_str1')
			act 'Идти':gt'kavkazkafe','threesome'
		else
			gs 'zz_render','','',func('kavkazkafe_strings','local_str2')
			act 'Идти':gt'kavkazkafe','foursome'
		end
		exit
	end
	if RAND(0,100) < 70:
		if kavslut > 0:
			gs 'npc_editor','init_sex',46
			gs 'zz_render', '', 'images/picKav/podsob.jpg', func('kavkazkafe_strings', 'local_str3')
			act 'Уйти': gt 'street'
			act 'Ладно': gt 'kavkazkafe', 'grup'
			exit
		elseif $npc['34,sex'] >= 10:
			gs 'npc_editor','init_sex',46
			gs 'zz_render', '', 'images/picKav/podsob.jpg', func('kavkazkafe_strings', 'local_str4')
			act 'Да за кого вы меня принимаете?':
				cla
				gs 'zz_render','','',func('kavkazkafe_strings', 'local_str5')
				act 'Позволить себя обнять': gt'kavkazkafe','grup'
				act 'Все с меня этого хватит, я иду домой!':
					cla
					gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str6')
					act 'Уйти': gt 'street'
				end
			end
			act 'Ну ладно, давайте': gt 'kavkazkafe','grup'
			exit
		end
	end
	gs 'zz_render', '', 'images/picKav/podsob.jpg', func('kavkazkafe_strings', 'local_str7')
	if $npc['34,sex'] = 0:
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str8')
		act 'Продолжать считать делая вид что не замечаете':
			cla
			gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str9')
			act 'Встать на колени':gt'kavkazkafe','givibj'
			act 'Да за кого вы меня принимаете?':
				cla
				gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str10')
				act 'Встать на колени':
					money += 5000
					gt'kavkazkafe','givibj'
				end
				act 'Все с меня этого хватит, я иду домой!':
					cla
					gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str11')
					act 'Пытаться вырвать руку':gt'kavkazkafe','givirape'
				end
			end
		end
		act 'Убрать его руки':
			cla
			gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str12')
			act 'Встать на колени':gt'kavkazkafe','givibj'
			act 'Да за кого вы меня принимаете?':
				cla
				gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str13')
				act 'Встать на колени':
					money += 5000
					gt'kavkazkafe','givibj'
				end
				act 'Все с меня этого хватит, я иду домой!':
					cla
					gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str14')
					act 'Уйти':gt'street'
				end
			end
		end
	else
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str15')
		act 'Встать на колени':gt'kavkazkafe','givibj'
		act 'Уйти':gt'street'
	end
end
if $ARGS[0] = 'grup':
	$npc['34,relation'] = 100
	smenaKafe += 2
	if $npc['34,sex'] = 0: $npc['34,sex'] = 1 & guy += 1
	if Ashotsex = 0:Ashotsex = 1 & guy += 1
	minut += 5
	kavslut += 1
	gang += 1
	bj += 2
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/grupbj'+RAND(0,1)+'.jpg', func('kavkazkafe_strings', 'local_str16')
	act 'Беспомощно мычать':gt'kavkazkafe','grup1'
end
if $ARGS[0] = 'grup1':
	minut += 5
	pose = 0
	gs'stat'
	gs 'zz_render','','images/picKav/grupv'+RAND(0,1)+'.jpg'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str17')
	if RAND(0,10) >= 8:
		anus += 1 & 'Во время секса Ашот засунул палец вам в попу и начал ее массировать.'
		if anus > 1 and RAND(0,10) >= 5:
			gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str18')
			act 'Сосать у Гиви':gt'kavkazkafe','grup2'
			exit
		end
	end
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str19')
	act 'Подставить лицо':gt'kavkazkafe','grupcum'
end
if $ARGS[0] = 'grup2':
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/grupd'+RAND(0,2)+'.jpg', func('kavkazkafe_strings', 'local_str20')
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	if anus > 1 and RAND(0,10) >= 8:
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str21')
		act 'Двойное проникновение':gt'kavkazkafe','grup3'
		exit
	end
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str22')
	act 'Подставить лицо':gt'kavkazkafe','grupcum'
end
if $ARGS[0] = 'grup3':
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/grupdouble'+RAND(0,2)+'.jpg', func('kavkazkafe_strings', 'local_str23')
	gs'npc_editor','init_sex',34
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs'npc_editor','init_sex',46
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str24')
	act 'Подставить лицо':gt'kavkazkafe','grupcum'
end
if $ARGS[0] = 'grupcum':
	minut += 5
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/grupcum.jpg', func('kavkazkafe_strings', 'local_str25')
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'givirape':
	$npc['34,relation'] = 100
	smenaKafe += 1
	if $npc['34,sex'] = 0: $npc['34,sex'] = 1 & guy += 1
	rape += 1
	givirape += 1
	minut += 5
	manna -= 20
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/rape.jpg', func('kavkazkafe_strings', 'local_str26')
	act 'Беспомощно мычать':gt'kavkazkafe','givirape1'
end
if $ARGS[0] = 'givirape1':
	minut += 5
	bj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/rape1.jpg', func('kavkazkafe_strings', 'local_str27')
	act 'Сосать':gt'kavkazkafe','givirapebj'
	act 'Укусить':gt'kavkazkafe','givirape2'
end
if $ARGS[0] = 'givirapebj':
	minut += 5
	if mop > 1:mop = 0
	throat += 1
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	money += 5000
	gs 'zz_render', '', 'images/picKav/rape1.jpg', func('kavkazkafe_strings', 'local_str28')
	if mop > 1:mop = 0 & 'У вас потекли слезы и размазалась косметика по лицу.'
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str29')
	gs 'stat'
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'givirape2':
	minut += 5
	money += 5000
	gs 'zz_render', '', 'images/picKav/rape2.jpg', func('kavkazkafe_strings', 'local_str30')
	if anus >= 1:
		anus += 3
		anal += 1
		gs 'zz_funcs', 'cum', 'ass'
		manna -= 100
		horny = 0
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str31')
	else
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str32')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str33')
		pose = 1
		gs 'zz_dynamic_sex', 'sex_cum'
	end
	gs 'stat'
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str34')
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'givibj':
	$npc['34,relation'] = 100
	smenaKafe += 1
	if $npc['34,sex'] = 0: $npc['34,sex'] = 1 & guy += 1
	$npc['34,sex'] += 1
	minut += 3
	gs'npc_editor','init_sex',34
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/before.jpg', func('kavkazkafe_strings', 'local_str35')
	act 'Дрочить его член':gt'kavkazkafe','givibj1'
	act 'Взять в рот':gt'kavkazkafe','givibj3'
end
if $ARGS[0] = 'givibj1':
	minut += 3
	hj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/before3.jpg', func('kavkazkafe_strings', 'local_str36')
	act 'Сосать его палец': gt'kavkazkafe','givibj2'
	act 'Взять в рот член': gt'kavkazkafe','givibj3'
end
if $ARGS[0] = 'givibj2':
	minut += 3
	dom -= 1
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/before2.jpg', func('kavkazkafe_strings', 'local_str37')
	act 'Взять в рот': gt'kavkazkafe','givibj3'
end
if $ARGS[0] = 'givibj3':
	minut += 3
	bj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/bj1.jpg', func('kavkazkafe_strings', 'local_str38')
	act 'Сосать дальше': gt'kavkazkafe','givibj4'
end
if $ARGS[0] = 'givibj4':
	minut += 3
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/bj.jpg', func('kavkazkafe_strings', 'local_str39')
	act 'Вынуть изо рта': gt'kavkazkafe','givibj5'
	act 'Продолжать сосать': gt'kavkazkafe','givibj6'
	if $npc['34,sex'] > 1 and RAND(0,100) >= 75:
		cla
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str40')
		act 'Встать раком': gt'kavkazkafe','givisex'
	end
end
if $ARGS[0] = 'givibj5':
	minut += 3
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/facial'+RAND(1,9)+'.jpg', func('kavkazkafe_strings', 'local_str41')
	act 'Уйти': gt 'street'
end
if $ARGS[0] = 'givibj6':
	minut += 3
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/cum'+RAND(1,9)+'.jpg', func('kavkazkafe_strings', 'local_str42')
	act 'Уйти': gt 'street'
end
if $ARGS[0] = 'givisex':
	minut += 3
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/before4.jpg', func('kavkazkafe_strings', 'local_str43')
	if $npc['34,sex'] > 5:
		if RAND(0,100) >= 75 and anal > 0:
			cla
			gs 'zz_render','','',replace($name[2],'е','э')+', я тебя в попку хочу.'
			act 'Я так не хочу': gt'kavkazkafe','givisex1'
			act 'Закрыть глаза': gt'kavkazkafe','givianal'
			exit
		end
	end
	act 'Закрыть глаза':gt'kavkazkafe','givisex1'
end
if $ARGS[0] = 'givisex1':
	minut += 3
	pose = 0
	gs 'stat'
	givserand = RAND(0,10)
	gs 'zz_render','','images/picKav/sex'+iif(RAND(0,10)<8,'',1)+'.jpg'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str44')
	if givserand >= 8:
		anus += 1
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str45')
		if anus > 1 and RAND(0,10) >= 8:
			gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str46')
			act 'Закрыть глаза': gt'kavkazkafe', 'givianal'
			exit
		end
	end
	if RAND(0,10) >= 8:
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str47')
		act 'Подставить лицо': gt'kavkazkafe','givibj5'
		act 'Открыть рот': gt'kavkazkafe','givibj6'
		exit
	end
	pose = 1
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'givianal':
	minut += 3
	gs 'stat'
	gs 'zz_render','','images/picKav/anal.jpg'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	if RAND(0,10) >= 8:
		gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str48')
		act 'Подставить лицо':gt'kavkazkafe','givibj5'
		act 'Открыть рот':gt'kavkazkafe','givibj6'
		exit
	end
	gs 'zz_dynamic_sex', 'anal_cum'
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'threesome':
	minut += 3
	gang += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/threestart.jpg', func('kavkazkafe_strings', 'local_str49')
	act 'Сосать член':
		*clr & cla
		minut += 3
		dom -= 1
		bj += 1
		gs 'stat'
		if RAND(0,1) = 0:
			gs 'zz_render', '', 'images/picKav/threeA'+RAND(1,6)+'.jpg', func('kavkazkafe_strings', 'local_str50')
			dynamic $threesomedin
		else
			gs 'zz_render', '', 'images/picKav/threeB'+RAND(1,3)+'.jpg', func('kavkazkafe_strings', 'local_str51')
			dynamic $threesomedin
		end
	end
	act 'Целовать Гиви':
		*clr & cla
		minut += 3
		bj += 1
		dom += 1
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/threeB'+RAND(1,3)+'.jpg', func('kavkazkafe_strings', 'local_str52')
		dynamic $threesomedin2
	end
end
if $ARGS[0] = 'foursome':
	minut += 3
	gang += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picKav/four.jpg', func('kavkazkafe_strings', 'local_str53')
	act 'Сосать':
		*clr & cla
		minut += 3
		bj += 1
		gs 'stat'
		gs 'zz_render', '', 'images/picKav/four'+RAND(1,10)+'.jpg', func('kavkazkafe_strings', 'local_str54')
		act '...':
			*clr & cla
			minut += 3
			pose = 0
			gs 'stat'
			gs 'zz_render', '', 'images/picKav/fourA'+RAND(1,5)+'.jpg', func('kavkazkafe_strings', 'local_str55')
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_render', '', '', func('kavkazkafe_strings', 'local_str56')
			act '...':
				*clr & cla
				minut += 3
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_funcs', 'cum', 'lip'
				gs 'stat'
				gs 'zz_render', '', 'images/picKav/fourfin.jpg', func('kavkazkafe_strings', 'local_str57')
				act 'Уйти':dynamic $endirinaaftergang
			end
		end
	end
end