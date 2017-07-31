! --- BJ ---
if $args[0] = 'bj_select':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','common/sex/1x1/bj/'+rand(0,2)+'.gif',func('kotovsex_str',124)
	i = rand(0,4)
	act func('zz_funcs','get_item_string','Лизать головку,Сосать головку,Поцеловать головку,Ласкать ладошкой,Провести языком',i): gt $curloc,'bj','<<i>>'
end
if $args[0] = 'bj':
	*clr & cla
	_bj = val($args[1])
	minut += rand(3,7)
	bj_temp += 1
	gs 'stat'
	gs 'zz_render','','common/sex/1x1/bj/' + str(_bj) + iif(_bj <= 9,str(rand(0,2)),0) + '.gif',func('kotovsex_str',_bj+75)
	if _bj <= 9:
		_bj_times += 1
		! если есть опыт - добавляем доп.возможности
		if bj > 10: gs 'zz_render','','',func('kotovsex_str',_bj+99)
	end
	if _bj_times >= 3:
		if rand(1,3) < 3:
			gs 'zz_render','','',func('kotovsex_str',109)
			gs $curloc,'after_bj_select'
		else
			gs 'zz_render','','',func('kotovsex_str',110)
			act 'Кончить':
				if _bj = 5:
					! в ладошки
					gt $curloc,'bj_cum',0
				elseif _bj = 12 or _bj = 13:
					! на грудь
					gt $curloc,'bj_cum',1
				elseif (_bj >= 8 and _bj <= 10) or _bj = 19 or _bj = 23:
					! в рот
					gt $curloc,'bj_cum',3
				elseif _bj = 11 or _bj = 22:
					! в рот после глубокой глотки
					gt $curloc,'bj_cum',4
				else
					! на лицо
					gt $curloc,'bj_cum',2
				end
			end
		end
	else
		gs 'zz_render','','',func('kotovsex_str',rand(111,115))
		_arr_bj[0] = 0
		_arr_bj[1] = 1
		_arr_bj[2] = 2
		_arr_bj[3] = 3
		j = 0
		:loop_rand_bj
		k = rand(0,arrsize('_arr_bj')-1)
		gs $curloc,'bj_rand',_arr_bj[k]
		killvar '_arr_bj',k
		j += 1
		if j <= 3: jump 'loop_rand_bj'
		killvar '_arr_bj'
		killvar 'k'
	end
	killvar '_bj'
end
if $args[0] = 'bj_rand':
	i = rand(1,2)
	if args[0] = 0:
		i = rand(0,4)
		act func('zz_funcs','get_item_string','Лизать головку,Сосать головку,Поцеловать головку,Ласкать ладошкой,Провести языком',i): gt $curloc,'bj','<<i>>'
	elseif args[0] = 1:
		if dom >= 10:
			act 'Дрочить': gt $curloc,'bj',5
		else
			act iif(i=1,'Лизать яйца','Лизать очко'): gt $curloc,'bj',iif(i=1,6,7)
		end
	elseif args[0] = 2:
		if throat > 15:
			if dom >= 10:
				act 'Заглотить глубоко': gt $curloc,'bj',10
			else
				act 'Расслабить горло': gt $curloc,'bj',11
			end
		else
			act iif(i=1,'Сосать подрачивая','Сосать без рук'): gt $curloc,'bj',iif(i=1,8,9)
		end
	else
		if body['tits'] < 3:
			act 'Провести вокруг соска': gt $curloc,'bj',12
		else
			act 'Сжать между сисек': gt $curloc,'bj',13
		end
	end
end
if $args[0] = 'bj_cum':
	*clr & cla
	_cum = args[1]
	minut += rand(1,5)
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	gs 'zz_render','','common/sex/bj_cum/'+ _cum + '.gif',func('kotovsex_str',_cum+116)
	! в ладони						0
	! на грудь, живот и лицо		1
	! на лицо						2
	! в рот							3
	! в рот после глубокой глотки	4
	! возможны комбинации, поэтому построчно
	if _cum = 1: gs 'zz_funcs','cum','belly'
	if _cum = 1 or _cum = 2: gs 'zz_funcs','cum','face'
	if _cum >= 3: gs 'zz_funcs','cum','lip'
	gs 'stat'
	if _cum = 3:
		act 'Проглотить':
			cla
			vaf += 1
			gs 'zz_render','','',func('kotovsex_str',121)
			act 'Отойти': gt $loc,$metka
		end
		act 'Выплюнуть':
			cla
			gs 'zz_render','','',func('kotovsex_str',122)
			act 'Отойти': gt $loc,$metka
		end
	end
	if _cum = 4: vaf += 1
	killvar '_cum'
	act 'Отойти': gt $loc,$metka
end
if $args[0] = 'after_bj_select':
	i = rand(0,4)
	act func('zz_funcs','get_item_string','Раздвинуть ноги,Сесть сверху,Нагнуться,Лечь на живот,Запрыгнуть на руки',i):
		gt $curloc,'sex_actions',func('zz_funcs','get_item_string','mis,cow,dog,bell,hand',i)
	end
end
! --- VAGINAL ---
! выбор позы
if $args[0] = 'zz_select_sex':
	$_var = $args[1]
	if $_var = '': $_var = 'mis'
	if _sex_count >= 3:
		gs 'zz_render','','',func('kotovsex_str',28)
	else
		gs 'zz_render','','',func('kotovsex_str',29)
		if rand(1,3) = 3:
			act 'Подставить попку':
				if $_var = '69' or $_var = 'hand' or $_var = 'dog': gt $curloc,'anal',1
				if $_var = 'bell': gt $curloc,'anal',2
				if $_var = 'cow': gt $curloc,'anal',3
				if $_var = 'cow_bonus0': gt $curloc,'anal',4
				if $_var = 'cow_bonus1': gt $curloc,'anal',5
				if $_var = 'mis': gt $curloc,'anal',0
			end
		end
		if $_var = '69' or $_var = 'hand': i = 4
		if $_var = 'bell': i = 3
		if $_var = 'cow' or $_var = 'cow_bonus0' or $_var = 'cow_bonus1': i = 2
		if $_var = 'dog': i = 1
		if $_var = 'mis': i = 0
		! добавляем список действий
		act 'Лечь на спину': gt $curloc,'sex_actions','mis'
		act 'Нагнуться': gt $curloc,'sex_actions','dog'
		act 'Сесть сверху': gt $curloc,'sex_actions','cow'
		act 'Лечь на живот': gt $curloc,'sex_actions','bell'
		act 'Запрыгнуть на руки': gt $curloc,'sex_actions','hand'
		delact func('zz_funcs','get_item_string','Лечь на спину,Нагнуться,Сесть сверху,Лечь на живот,Запрыгнуть на руки',i)
	end
end
if $args[0] = 'zz_sex_orgasm':
	if horny >= 90:
		horny = 0
		manna += rand(10,20)
		orgasm += 1
		gs 'zz_render','','','От умелых действий парня вас охватил оргазм.'
	else
		gs 'zz_render','','','Действия парня хоть и были возбуждающие, но они начали вас утомлять.'
	end
end
! описание и действия
if $args[0] = 'sex_actions':
	$_cur_pose = $args[1]
	if $_cur_pose = '': $_cur_pose = 'mis'
	_sex_count += 1
	sex_temp += 1
	*clr & cla
	gs 'zz_render','','common/sex/1x1/sex/' + $_cur_pose + '/' + str(rand(0,2)) + '.gif'
	minut += rand(3,10)
	gs 'stat'
	! получаем тексты для текущей точки и для продолжения
	if $_cur_pose = 'mis':
		$_text1 = func('kotovsex_str',30)
		$_text2 = func('kotovsex_str',iif(dom >= 30,31,32))
	elseif $_cur_pose = 'dog':
		$_text1 = func('kotovsex_str',33)
		$_text2 = func('kotovsex_str',iif(dom >= 30,34,35))
	elseif $_cur_pose = 'cow':
		$_text1 = func('kotovsex_str',37)
		$_text2 = func('kotovsex_str',iif(rand(1,2)=1,38,39))
	elseif $_cur_pose = 'bell':
		$_text1 = func('kotovsex_str',40)
		$_text2 = func('kotovsex_str',iif(rand(1,2)=1,41,42))
	else
		$_text1 = func('kotovsex_str',43)
		$_text2 = func('kotovsex_str',44)
	end
	gs 'zz_render','','',$_text1
	killvar '$_text1'
	gs 'zz_dynamic_sex', 'sex_start', 1
	if _sex_count >= 3:
		! конец
		gs 'zz_render','','',func('kotovsex_str',28)
		act 'Кончить':
			gt $curloc,'sex_cum',iif($_cur_pose='cow','cow',iif($_cur_pose = 'mis' or $_cur_pose = 'hand','mis','dog'))
		end
	else
		gs 'zz_render','','',$_text2
		if $_cur_pose = 'mis':
			if dom >= 10:
				if rand(0,1) = 0:
					act 'Раздвинуть ножки для куни': gt $curloc,'sex_kuni'
				else
					if dom >= 30: act 'Взаимно ласкать друг друга': gt $curloc,'sex_69'
				end
			end
		end
		gs $curloc,'zz_select_sex',$_cur_pose
	end
	killvar '$_text2'
end
if $args[0] = 'sex_kuni':
	*clr & cla
	if dom >= 30:
		kuni_temp += 1
		gs 'zz_render','','common/sex/1x1/kuni/'+rand(0,2)+'.gif',func('kotovsex_str',68)
		if dom >= 50: gs 'zz_render','','',func('kotovsex_str',70)
		gs $curloc,'zz_sex_orgasm'
		gs $curloc,'after_bj_select'
	else
		! парень отказывается
		gs 'zz_render','','',func('kotovsex_str',67)
		act 'Продолжить': gt $curloc,'sex_actions','mis'
	end
end
if $args[0] = 'sex_69':
	*clr & cla
	_sex_count += 1
	kuni_temp += 1
	sex_temp += 1
	gs 'zz_render','','common/sex/1x1/69/'+rand(0,2)+'.gif',func('kotovsex_str',74)
	gs $curloc,'zz_sex_orgasm'
	gs $curloc,'zz_select_sex','69'
	if _sex_count >= 3: act 'Кончить': gt $curloc,'bj_cum',2
	gs $curloc,'after_bj_select'
end
! бонусы
! mis
if $args[0] = 'mis_bonus':
	*clr & cla
	_sex_count += 1
	sex_temp += 1
	gs 'zz_render','','common/sex/1x1/sex/mis/'+(3+rand(args[1]*2,args[1]*2+1))+'.gif',func('kotovsex_str',51+args[1])
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if agil >= 60 and dom >= 30 and rand(1,3) < 3: gs 'zz_render','','',func('kotovsex_str',53)
	gs $curloc,'zz_select_sex','mis'
	if _sex_count >= 3: act 'Кончить': gt $curloc,'sex_cum','mis'
end
! doggy
if $args[0] = 'dog_bonus':
	*clr & cla
	_sex_count += 1
	sex_temp += 1
	gs 'zz_render','','common/sex/1x1/sex/dog/'+ (3+rand(args[1]*2,args[1]*2+1)) +'.gif',func('kotovsex_str',55+args[1])
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	gs $curloc,'zz_select_sex','dog'
	if _sex_count >= 3: act 'Кончить': gt $curloc,'sex_cum','dog'
end
! cowboy
if $args[0] = 'cow_bonus':
	*clr & cla
	_sex_count += 1
	_bonus = args[1]
	sex_temp += 1
	gs 'zz_render','','common/sex/1x1/sex/cow/'+ (3+rand(_bonus*2,_bonus*2+1)) +'.gif',func('kotovsex_str',58+_bonus)
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	if _bonus = 0:
		gs 'zz_render','','',func('kotovsex_str',62)
	else
		gs 'zz_render','','',func('kotovsex_str',63)
	end
	gs $curloc,'zz_select_sex','cow_bonus<<_bonus>>'
	if _sex_count >= 3: act 'Кончить': gt $curloc,'sex_cum','cow'
	killvar '_bonus'
end
! belly
if $args[0] = 'bell_bonus':
	*clr & cla
	_sex_count += 1
	sex_temp += 1
	gs 'zz_render','','common/sex/1x1/sex/bell/'+ (3+args[1]) +'.gif',func('kotovsex_str',64+args[1])
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	gs $curloc,'zz_select_sex','bell'
	if _sex_count >= 3: act 'Кончить': gt $curloc,'sex_cum','dog'
end
! hand
if $args[0] = 'hand_bonus':
	*clr & cla
	_sex_count += 1
	sex_temp += 1
	gs 'zz_render','','common/sex/1x1/sex/hand/1.gif',func('kotovsex_str',66)
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	gs $curloc,'zz_select_sex','hand'
	if _sex_count >= 3: act 'Кончить': gt $curloc,'sex_cum','mis'
end
! kuni
if $args[0] = 'kuni_bonus':
	*clr & cla
	gs 'zz_render','','common/sex/1x1/kuni/'+rand(3,4)+'.gif',func('kotovsex_str',72)
	gs $curloc,'zz_sex_orgasm'
	gs 'zz_render','','',func('kotovsex_str',73)
	gs $curloc,'after_bj_select'
end
! Завершение
if $args[0] = 'sex_cum':
	*clr & cla
	minut += rand(1,5)
	sweat += 1
	$_pose = $args[1]
	if sex_temp > 0: sex_temp = 0 & sex += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if protect = 1:
		!$_pose = 'protect'
		!_img = rand(0,1)
		protect = 0
		gs 'npc_editor','get_npc_profile',9
		gs 'zz_render','','',func('kotovsex_str',46)
	else
		if $_pose = 'anal':
			gs 'zz_funcs','cum','anus'
			$_text = func('kotovsex_str',45)
			_img = 0
		else
			! секс без презерватива - кончает внутрь, чем выше доминантность гг - тем ниже шанс
			if rand(1,iif(dom < 30,2,dom/10)) = 1:
				$_text = func('kotovsex_str',49) & gs 'zz_funcs','cum','pussy'
				_img = rand(2,3)
			else
				! наружу
				gs 'zz_funcs','cum',iif($_pose='dog','ass','belly')
				$_text = func('kotovsex_str',iif($_pose='dog',48,47))
				_img = rand(0,1)
			end
		end
		gs 'zz_render','','common/sex/1x1/cum/<<$_pose>>/<<_img>>.gif',$_text
	end
	gs 'stat'
	killvar '$_pose'
	killvar '_img'
	killvar '$_text'
	killvar '_sex_count'
	killvar '$_var'
	act 'Отойти': gt $loc,$metka
end
if $args[0] = 'sub':
	gs $curloc,'zz_sex_start','misionary'
	gs 'zz_render','','',func('kotovsex_str',125)
	i = rand(0,5)
	act func('zz_funcs','get_item_string','Опуститься на колени,Раздвинуть ноги,Сесть сверху,Нагнуться,Лечь на живот,Запрыгнуть на руки',i):
		if i = 0:
			gt $curloc,'bj_select'
		else
			gt $curloc,'sex_actions',func('zz_funcs','get_item_string','mis,cow,dog,bell,hand',-1)
		end
	end
end
! --- ANAL ---
if $args[0] = 'anal':
	*clr & cla
	_var_anal = args[1]
	minut += rand(5,15)
	gs 'stat'
	act 'Кончить': gt $curloc,'sex_cum','anal'
	gs 'zz_render','','common/sex/1x1/anal/' + str(_var_anal) + str(rand(0,1)) +'.gif',func('kotovsex_str',123)
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	gs 'zz_render','','',func('kotovsex_str',28)
	killvar '_var_anal'
end