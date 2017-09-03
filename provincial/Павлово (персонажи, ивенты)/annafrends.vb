if rexPark = 1 and rexParkDay < daystart and $npc['38,qwRexSisTalk'] = 2 or rexCar = 1 and rexCarDay < daystart and $npc['38,qwRexSisTalk'] = 3:
	*clr & cla
	minut += 5
	$npc['27,relation'] = 50
	rexPark = 0
	gs 'reks'
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('annafrends_strings', 'local_str1')
	gs 'zz_render', '', '', func('zz_funcs', 'relation', 27)
	act 'Продолжать пить пиво': gt'annafrends2'
	exit
end
if rexCar = 1 and rexCarDay < daystart and $npc['38,qwRexSisTalk'] = 4:
	*clr & cla
	minut += 5
	$npc['27,relation'] = 50
	rexCar = 0
	gs 'reks'
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('annafrends_strings', 'local_str2')
	gs 'zz_render', '', '', func('zz_funcs', 'relation', 27)
	act 'Продолжать пить пиво': gt'annafrends2'
	exit
end
!-----------!
minut += 40
gs 'npc_editor','change_rep','+', 38
gs 'zz_funcs', 'alko', 2
gs 'stat'
if $sister['location'] ! 'cafe_parco': gs 'time'
gs 'zz_render', '', 'pavlovo/family/sister/friends/' + $sister['location'] + '_' + rand(1,4) + '.jpg', func('annafrends_strings', 'local_str3')
dialogstartrand = rand(0,iif($sister['location'] = 'cafe_parco',2,4))
if dialogstartrand = 0:
	!аня
	gs 'zz_render', '', '', func('annafrends_strings', 'local_str4')
	tipDSrand = iif($sister['location'] = 'cafe_parco',0,rand(0,1))
	if tipDSrand = 0:
		if $sister['location'] ! 'cafe_parco':'Рекс взял полторашку из рук Ани.' & tipDSrand2 = rand(0,4)
		if $sister['location'] = 'cafe_parco':'Рекс тут же направился в сторону барной стойки.' & tipDSrand2 = rand(0,3)
		if tipDSrand2 = 0:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str5')
			tipDSrand3 = rand(0,2)
			if tipDSrand3 = 0:
			elseif tipDSrand3 = 1:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str6')
			elseif tipDSrand3 = 2:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str7')
				if rand(0,10) < 3: gs 'zz_render', '', '', func('annafrends_strings', 'local_str8')
			end
		elseif tipDSrand2 = 1:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str9')
			tipDSrand3 = rand(0,2)
			if tipDSrand3 = 0:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str10')
			elseif tipDSrand3 = 1:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str11')
			elseif tipDSrand3 = 2:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str12')
				tipDSrand4 = rand(0,2)
				if tipDSrand4 = 0:
					gs 'zz_render', '', '', func('annafrends_strings', 'local_str13')
					tipDSrandA = rand(0,10)
					if tipDSrandA < 3:
						gs 'zz_render', '', '', func('annafrends_strings', 'local_str14')
						tipDSrand5 = rand(0,2)
						gs 'zz_render', '', '', func('annafrends_strings', 'local_str15')
					end
				elseif tipDSrand4 = 1:
					gs 'zz_render', '', '', func('annafrends_strings', 'local_str16')
					if rand(0,10) < 3: gs 'zz_render', '', '', func('annafrends_strings', 'local_str17')
				elseif tipDSrand4 = 2:
					gs 'zz_render', '', '', func('annafrends_strings', 'local_str18')
					if rand(0,10) < 3: gs 'zz_render', '', '', func('annafrends_strings', 'local_str19')
				end
			end
		elseif tipDSrand2 = 2:
			if $sister['location'] ! 'cafe_parco':' - Че, рук нету пробку отвинтить?'
			if $sister['location'] = 'cafe_parco':' - Ну так сходила бы сама и заказала!'
			tipDSrand3 = rand(0,2)
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+(20+tipDSrand3*2))
			if rand(0,10) < 3: gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+(21+tipDSrand3*2))
		elseif tipDSrand2 = 3:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str26')
			tipDSrand3 = rand(0,2)
			if tipDSrand3 = 0:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str27')
			elseif tipDSrand3 = 1:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str28')
				if rand(0,10) < 3: gs 'zz_render', '', '', func('annafrends_strings', 'local_str29')
			elseif tipDSrand3 = 2:
				gs 'zz_render', '', '', func('annafrends_strings', 'local_str30')
			end
		elseif tipDSrand2 = 4:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str31')
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(32,34))
		end
	elseif tipDSrand = 1:
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str35')
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(36,38))
		if rand(0,3) = 0:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str39')
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(40,42))
		end
	end
elseif dialogstartrand = 1:
	!Лена
	gs 'zz_render', '', '', func('annafrends_strings', 'local_str43')
	if $sister['location'] = 'cafe_parco':
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str44')
	end
	if $sister['location'] ! 'cafe_parco':dialogstartrand = rand(3,4)
elseif dialogstartrand = 2:
	!Ира
	gs 'zz_render', '', '', func('annafrends_strings', 'local_str45')
	if $sister['location'] = 'cafe_parco':
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str46')
	end
	if $sister['location'] ! 'cafe_parco':dialogstartrand = RAND(3,4)
elseif dialogstartrand = 3:
	!Рекс
	if RAND(0,1) = 0:
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str47')
		tipDSrand2 = RAND(0,2)
		if tipDSrand2 = 0:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str48')
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(49,51))
		elseif tipDSrand2 = 1:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str52')
		end
	else
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str53')
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(54,56))
		if rand(0,3) = 0:
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str57')
			gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(58,60))
		end
	end
elseif dialogstartrand = 4:
	!Рома Мейнольд
	gs 'zz_render', '', '', func('annafrends_strings', 'local_str61')
	gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(62,64))
	if rand(0,3) = 0:
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str65')
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str'+rand(66,68))
	end
end
gs 'zz_render', '', '', func('annafrends_strings', 'local_str69')
if reksLike = 1 and toiletRexSex = 0 and sisboypartyQW > 1 and hour <= 16:
	temp = rand(1,100)
	if temp < 71:
		gs 'zz_render', '', '', func('annafrends_strings', 'local_str70')
		if horny > 85:
			act 'Закинуть ножку на ножку':
				*clr & cla
				minut += 5
				horny += 5
				gs 'npc_editor','change_rep','+', 27
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/rexpod' + rand(1,3) + '.jpg', func('annafrends_strings', 'local_str71')
				act 'Продолжать пить пиво': gt'annafrends2'
				exit
			end
		end
	end
	if alko > 2 and temp < 21 and $npc['27,relation'] <= 60:
		act 'Общаться с рексом':
			*clr & cla
			minut += 5
			gs 'npc_editor','change_rep','+', 27
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('annafrends_strings', 'local_str72')
			if dom > 0:
				act 'Отстраниться':
					*clr & cla
					minut += 5
					dom += 1
					gs 'npc_editor','change_rep','-'
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Reks/rexnet.jpg', func('annafrends_strings', 'local_str73')
					act 'Продолжать пить пиво': gt'annafrends2'
				end
			end
			act 'Ждать':
				*clr & cla
				minut += 5
				horny += 5
				gs 'npc_editor','change_rep','+', 27
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/rexda.gif', func('annafrends_strings', 'local_str74')
				act 'Продолжать пить пиво': gt'annafrends2'
			end
			exit
		end
	end
	if temp > 50 and $npc['27,relation'] >= 40:
		act 'Общаться с Рексом':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('annafrends_strings', 'local_str75')
			gs 'zz_render', '', '', func('zz_funcs', 'relation', 27)
			act 'Болтать':
				gs 'npc_editor','change_rep','+',27
				gs 'reks', 'rexGdkTalk'
				act 'Продолжать пить пиво': gt'annafrends2'
			end
			act 'Продолжать пить пиво': gt'annafrends2'
			exit
		end
	end
end
if $npc['38,qwSisterBoy'] = 1:
	act 'Познакомиться с парнем сестры':
		*clr & cla
		minut += 5
		$npc['38,qwSisterBoy'] = 2
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_02.jpg', func('annafrends_strings', 'local_str76')
		act 'Продолжать пить пиво': gt'annafrends2'
	end
else
	if hour <= 16: act 'Продолжать пить пиво': gt'annafrends2'
	act 'Уйти':
		if $sister['location'] = 'gdk': gt 'gdk'
		if $sister['location'] = 'glake': gt 'glake'
		if $sister['location'] = 'cafe_parco': gt 'cafe_parco', 'start'
	end
end