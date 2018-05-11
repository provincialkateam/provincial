! порядок действий
! 1. Приветствие
! 1.1. Проверка прически
! 1.2. Проверка следов спермы на лице или одежде
! 1.3. Проверка на видимые следы венерического заболевания
! 1.4. Рандомно - подарок
! 1.5. Поцелуй
! 2. Выбор куда пойти
! 2.1. Пить пиво возле дома
! 2.2. Кино
! 2.3. Парк
! 2.4. Кафе
! 2.5. Ресторан - только для сити
! 3. После свидания
! 3.1. Идти домой самой
! 3.2. Проводит парень
! 3.2.1. Для сити - пригласить домой
! 3.3. Парень приглашает домой
!-----------------------------
! встреча с ГГ
! args[1] - id бойфренда
if $args[0] = 'meet':
	*clr & cla
	_boy_id = args[1]
	! выводим табличку с профилем нпс
	gs 'npc_editor','get_npc_profile',_boy_id
	gs 'zz_render','','',func('zz_boys_str',0)
	!--
	!  Проверка следов спермы на лице или одежде и на на видимые следы венерического заболевания
	if venera >= 4 or cumface > 0 or cumfrot > 0:
		gs 'npc_editor','change_rep','down',_boy_id,100
		$npc['<<_boy_id>>,boyfriend'] = 0
		gs 'zz_render','','',func('zz_boys_str',iif(venera >= 4,1,2))
		act 'Уйти': gt $control_point
		exit
	else
		! подарок
		if rand(0,10) <= $npc['<<_boy_id>>,type'] and $npc['0,boyfriend_gift_day'] ! day:
			money += rand(100,150) + $npc['<<_boy_id>>,boyfriend']*10*($npc['<<_boy_id>>,type']+2)
			gs 'stat'
			gs 'zz_render','','',func('zz_boys_str',3)
		else
			gs 'zz_render','','',func('zz_boys_str',4)
		end
		act 'Не целоваться':
			*clr & cla
			gs 'npc_editor','change_rep','down',_boy_id,iif($npc['0,boyfriend_gift_day']=day,rand(5,7),val($npc['<<_boy_id>>,character']+1))
			gs 'zz_render','','',func('zz_boys_str',5+$npc['<<_boy_id>>,character']) + func('zz_boys_str',8)
			gs 'zz_boys','select_location'
		end
		act 'Поцеловать в щечку':
			*clr & cla
		end
		act 'Поцеловать в губы':
			*clr & cla
		end
		act 'Поцеловать с языком':
			*clr & cla
		end
	end
end
! выбор локации
if $args[0] = 'select_location':
	gs 'zz_render','','',func('zz_boys_str',iif(venera >= 4,1,2))
end