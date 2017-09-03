!============================================================================================================!
!ФИО: Василий Сергеевич Шульгин (кликуха Шульга)-------------------------------------------------------------!
!------------------------------------------------------------------------------------------------------------!
!$npc['11,relation'] - счетчик отношений: -------------------------------------------------------------------------!
!<= 50 - знакомы с детства ----------------------------------------------------------------------------------!
!> 30 - рассказывает про вебкам работу ----------------------------------------------------------------------!
!> 50 - друзья, предлагает вам устраивать вебкам шоу у него дома --------------------------------------------!
!>= 100 - близкие друзья, предлагает вместе устраивать вебкам шоу у него дома -------------------------------!
!============================================================================================================!
$metka = $ARGS[0]
$loc = $CURLOC
$metka = $ARGS[0]
$loc = $CURLOC
gs 'gopsex'
gs 'cardgame_durak'
!Разговоры в сутки:
!Васян
if bazar_day ! daystart: bazar_count = 10
!Дэн
if bazar_day_den ! daystart: bazar_count_den = 5
!Витек
if bazar_day_vitek ! daystart: bazar_count_vitek = 5
!игр в карты:
if playcardgame_day ! daystart: playcardgame_count = 2
!вас увидели в одежде проститутки:
if sh_hooker_day ! daystart: sh_hooker_count = 1
!----------------------------------------------------
sveta_rnd_name = RAND(0,3)
	if sveta_rnd_name = 0:$sveta_rnd_name = '<<$name[1]>>'
	if sveta_rnd_name = 1:$sveta_rnd_name = '<<$name[2]>>'
	if sveta_rnd_name = 2:$sveta_rnd_name = '<<$name[2]>>'
	if sveta_rnd_name = 3:$sveta_rnd_name = '<<$name>>'
!отношения
$vasya_shulgin_rep = {
	if $npc['11,relation']<50:'Вы и <<$shulga_name_rnd>> знакомы с детства'
	if $npc['11,relation']>=50 and $npc['11,relation']<100:'Вы и <<$shulga_name_rnd>> - хорошие друзья'
	if $npc['11,relation']>=100:'Вы и <<$shulga_name_rnd>> - близкие друзья'
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str1')
}
!============================================================================================================!
!БОЛЬШАЯ (КОМНАТА ШУЛЬГИ)---------------------------------------------------------------------БОЛЬШАЯ КОМНАТА!
!============================================================================================================!
*clr & cla
minut += 1
gs'stat'
gs 'zz_render', 'Большая комната', 'images/zsoft/pod_ezd/shulgahome/bigroom.jpg', func('shulga_room_strings', 'local_str2')
if hour >= 3 and hour < 7: 'На большом диване спит <a href="exec: dynamic $shulga_bazar_sleep"><<$shulga_name_rnd>></a>.'
shulga_room_rnd = RAND(0,2)
	if shulga_room_rnd = 0:$shulga_room_rnd = 'В комнате беседуя пьют пиво пацаны. На большом диване расположились'
	if shulga_room_rnd = 1:$shulga_room_rnd = 'В комнате пьют пиво и играют в карты пацаны:'
	if shulga_room_rnd = 2:$shulga_room_rnd = 'В комнате, попивая пиво, смотрят телек пацаны:'
if week < 6 and hour >= 0 and hour < 3: '<<$shulga_room_rnd>> <a href="exec: dynamic $shulga_bazar_night"><<$shulga_name_rnd>></a>, <a href="exec: dynamic $den_bazar">Дэн</a> и <a href="exec: dynamic $vitek_bazar">Витёк</a>, присесть рядом и <a href="exec: dynamic $shulga_beer">пить пиво с пацанами</a>'
if week >= 6 and (hour >= 10 and hour < 17 or hour >= 0 and hour < 3): 'На большом диване сидит <a href="exec: dynamic $shulga_bazar_day"><<$shulga_name_rnd>></a>.'
act 'Выйти из комнаты': gt'shulgahome'
if week < 6 and hour >= 0 and hour < 3:
	act 'Пить пиво с ребятами': dynamic $shulga_beer
	act 'Играть в карты': dynamic $card_game_durak
end
act 'Маленький диван':
	*clr & cla
	gs'stat'
	gs 'zz_render', 'Маленький диван', 'images/zsoft/pod_ezd/shulgahome/sdivan.jpg','Маленький диван, на котором можно вздремнуть.'
	act 'Отойти': gt'shulga_room'
	act 'Прилечь на диван вздремнуть':
	if son < 22:
		son += 2
		health += 5
		minut += 60
		gs 'stat'
		if son < 22:'Вы дремали около часа.'
	elseif son >= 22:
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('shulga_room_strings', 'local_str3')
		end
	end
end
act 'Смотреть телевизор': dynamic $shultv
!делать уроки:
if shulga_lern_count > 0 and school['certificate'] = 0 and school['vacation'] = 0 and week >= 6 and (hour >= 10 and hour < 17 or hour >= 0 and hour < 3):
	act 'Делать уроки': dynamic $shulga_lern
end
!ГГ хочет секса:
if week >= 6 and $npc['11,relation']>=70 and (hour >= 10 and hour < 17 or hour >= 0 and hour < 3) or week < 6 and hour >= 0 and hour < 3 and func('zz_reputation','get') >=3 and alko >= 1:
	act 'Потрахаться': dynamic $gopsex_select
end
!ивент в комнате если репа (GorSlut >=3), рандом 5%
!Светку ловят
roomsex_gang = RAND(0,100)
if roomsex_gang <= 2 and func('zz_reputation','get') >=3 and gangsexroom_count > 0 and week < 6 and hour >= 0 and hour <= 2:
	dynamic $gang_sex_room_ev1
end
!Соньку трахают пацаны
if roomsex_gang >= 97 and $npc['25,qwSoniaSlut'] >=3 and sexev_sonya_count > 0 and week < 6 and hour >= 0 and hour <= 2:
	dynamic $gang_sex_sonya
end
!Сонька и Шульга
roomsex_sonya = RAND(0,100)
if roomsex_sonya <= 5 and $npc['25,qwSoniaSlut'] >=1 and sexev_sonya_count > 0 and hour >= 10 and hour <= 16:
	dynamic $shulv_sex_sonya
end
if roomsex_sonya <= 5 and $npc['25,qwSoniaSlut'] >=1 and sexev_sonya_count > 0 and hour >= 0 and hour <= 2:
	dynamic $shulv_sex_sonya
end
!Если пришли в одежде проститутки
i = func('zz_clothing', 'get_group')
if i = 12 and sh_hooker_count > 0 and week < 6 and hour >= 0 and hour <= 2 and func('zz_reputation','get') >=3:
	dynamic $sh_hooker
end
if i = 12 and sh_hooker_count > 0 and week >= 6 and hour >= 0 and hour <= 2:
	dynamic $sh_hooker
end
if i = 12 and sh_hooker_count > 0 and hour >= 10 and hour <= 16:
	dynamic $sh_hooker
end
!в одежде проститутки:
$sh_hooker = {
	*clr & cla
	sh_hooker_day = daystart
	sh_hooker_count -= 1
	gs'stat'
	gs 'zz_render', '','images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/body/h'+rand(1,20)+'.jpg'
	if week < 6 and hour >= 0 and hour < 3:
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str4')
		act 'Трахаться':
			shgopsex_gr_day = daystart
			shgopsex_gr_count -= 1
			dynamic $shgopsex_group
		end
	elseif hour >= 10 and hour <= 16 or week >=6 and hour >= 0 and hour < 3:
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str5')
		act 'Трахаться':
			$gopsex_name_npc = 'Вася'
			$gopsex_n_npc = 1
			shgopsex_vasya_day = daystart
			shgopsex_vasya_count -= 1
			dynamic $shgopsex
		end
	end
	act iif(func('zz_reputation','get') >= 3,'Уйти, сделав вид что обиделись','Обидеться'):
		if func('zz_reputation','get') < 3: dom += 1
		gt'shulgahome'
	end
}
!------------------!
! Эвенты с Сонькой !
!==================!
!Эвент Шульга и Сонька в большой комнате
$shulv_sexev1_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/ev1_'+rand(1,3)+'.jpg', func('shulga_room_strings', 'local_str6')
	dynamic $masturb_gg
		act 'Еще подсмотреть':
		*clr & cla
		minut += 5
		horny += 10
		gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/ev1_'+rand(3,6)+'.jpg', func('shulga_room_strings', 'local_str7')
		dynamic $masturb_gg
		act 'Уйти': gt'shulgahome'
	end
}
$shulv_sexev2_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/ev2_11.jpg', func('shulga_room_strings', 'local_str8')
	dynamic $masturb_gg
		act 'Наблюдать':
		*clr & cla
		minut += 5
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/ev2_2'+rand(1,2)+'.jpg', func('shulga_room_strings', 'local_str9')
		dynamic $masturb_gg
			act 'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/ev2_3'+rand(1,2)+'.jpg', func('shulga_room_strings', 'local_str10')
			dynamic $masturb_gg
				act 'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/ev2_4'+rand(1,2)+'.jpg', func('shulga_room_strings', 'local_str11')
				dynamic $masturb_gg
				act 'Уйти': gt'shulgahome'
			end
		end
	end
}
$shulv_sex_sonya = {
	if RAND(0,100) <= 40:
		dynamic $shulv_sexev1_sonya
	else
		dynamic $shulv_sexev2_sonya
	end
}
!Эвент Пацаны в большой комнате шпилят Соньку
!Эвент с Соней #1
$gang_sexev1_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/group/ev1_1.jpg', func('shulga_room_strings', 'local_str12')
	dynamic $masturb_gg
		act 'Наблюдать':
		*clr & cla
		minut += 5
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/group/ev1_2.jpg', func('shulga_room_strings', 'local_str13')
		dynamic $masturb_gg
			act 'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/group/ev1_3.jpg', func('shulga_room_strings', 'local_str14')
			dynamic $masturb_gg
				act 'Далее':
				*clr & cla
				minut += 5
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/group/ev1_4.jpg', func('shulga_room_strings', 'local_str15')
				dynamic $masturb_gg
					act 'Уйти': gt'shulgahome'
			end
		end
	end
}
!Эвент с Соней #2
$gang_sexev2_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/group/ev2_'+rand(1,2)+'.jpg', func('shulga_room_strings', 'local_str16')
	act 'Не мешать': gt'shulgahome'
}
!Эвент с Соней #3
$gang_sexev3_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sonya/group/ev3_'+rand(1,2)+'.jpg', func('shulga_room_strings', 'local_str17')
	act 'Не мешать': gt'shulgahome'
}
!выбор эвента из 3
$gang_sex_sonya = {
	gang_sexev_sonya = RAND(0,100)
	if gang_sexev_sonya < 40:
		dynamic $gang_sexev1_sonya
	end
	if gang_sexev_sonya >= 40 and gang_sexev_sonya < 70:
		dynamic $gang_sexev2_sonya
	end
	if gang_sexev_sonya >= 70:
		dynamic $gang_sexev3_sonya
	end
}
!----------------------------------------------!
!Пьем пиво с пацанами, эвенты и т.д. c 00 до 03!
!==============================================!
!К гг пристают пацаны
$gang_sex_room_ev1 = {
	*clr & cla
	minut += 2
	if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
	if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
	if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
	gangsexroom_day = daystart
	gangsexroom_count -= 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_1.jpg', func('shulga_room_strings', 'local_str18')
		act 'Далее':
		*clr & cla
		minut += 3
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_2.jpg', func('shulga_room_strings', 'local_str19')
			act 'Далее':
			*clr & cla
			minut += 5
			horny += 5
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_3.jpg', func('shulga_room_strings', 'local_str20')
				act 'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_4.jpg', func('shulga_room_strings', 'local_str21')
					act 'Далее':
					*clr & cla
					minut += 10
					gang +=1
					horny += 5
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_5.jpg', func('shulga_room_strings', 'local_str22')
						act 'Далее':
						*clr & cla
						minut += 10
						bj +=3
						throat += 1
						horny += 5
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_6.jpg', func('shulga_room_strings', 'local_str23')
							act 'Далее':
							*clr & cla
							minut += 10
							horny += 10
							mastr += 1
							gs'stat'
							gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_7.jpg', func('shulga_room_strings', 'local_str24')
							if analplugin = 1:
								gs 'zz_render', '', '', func('shulga_room_strings', 'local_str25')
							end
							gs 'zz_render', '', '', func('shulga_room_strings', 'local_str26')
								act 'Далее':
								*clr & cla
								minut += 10
								horny += 10
								sex += 1
								gs'stat'
								gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_8.jpg', func('shulga_room_strings', 'local_str27')
									act 'Далее':
									*clr & cla
									minut += 10
									horny += 10
									gs 'stat'
									gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_9.jpg', func('shulga_room_strings', 'local_str28')
										act 'Далее':
										*clr & cla
										minut += 10
										horny += 5
										gs'stat'
										gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_10.jpg', func('shulga_room_strings', 'local_str29')
										if analplugin = 1:
										gs 'zz_render', '', '', func('shulga_room_strings', 'local_str30')
										else
										gs 'zz_render', '', '', func('shulga_room_strings', 'local_str31')
										end
										gs 'zz_render', '', '', func('shulga_room_strings', 'local_str32')
											act 'Далее':
											*clr & cla
											gs 'zz_funcs', 'alko', 2
											gs 'stat'
											gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_11.jpg', func('shulga_room_strings', 'local_str33')
												act 'Далее':
												*clr & cla
												minut += 10
												horny += 5
												anal += 1
												gs'stat'
												'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_12.jpg"></center>'
												if analplugin = 1:
													analplugin = 0
													gs 'zz_render', '', '', func('shulga_room_strings', 'local_str34')
												end
												if lubri > 0:
													lubri -= 1
													agape = 1
													horny += 20
													gs 'zz_render', '', '', func('shulga_room_strings', 'local_str35')
												else
													agape = 2
													horny += 10
												end
												agapetime = totminut + (agape + 1) * 1440
													gs 'zz_render', '', '', func('shulga_room_strings', 'local_str36')
													act 'Далее':
														*clr & cla
														minut += 10
														gs 'stat'
														gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_13.jpg', func('shulga_room_strings', 'local_str37')
													if horny >=70:
														orgasm += 1
														manna += 35
														horny = 0
														gs 'zz_render', '', '', func('shulga_room_strings', 'local_str38')
													end
														gs 'zz_render', '', '', func('shulga_room_strings', 'local_str39')
														act 'Далее':
														*clr & cla
														minut += 10
														horny += 10
														gs'stat'
														gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_14.jpg', func('shulga_room_strings', 'local_str40')
														act 'Далее':
															*clr & cla
															horny +=10
															minut +=10
															cumfrot +=1
															gs 'zz_funcs', 'cum', 'lip'
															gs 'zz_funcs', 'cum', 'face'
															swallow += 1
															energy -= 2
															son -= 2
															gs 'stat'
															gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/sex/1_15.jpg', func('shulga_room_strings', 'local_str41')
															act 'Уйти': gt 'zz_bathroom', 'start'
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
}
!согласие на секс если гг нажралась
$drunken_sex_yes = {
	*clr & cla
	minut += 5
	horny +=10
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/yes'+rand(1,6)+'.jpg', func('shulga_room_strings', 'local_str42')
	act 'Показать попку': dynamic $drunken_body_popa
	act 'Показать пизду': dynamic $drunken_body_piz
	act 'Показать сиськи': dynamic $drunken_body_sisi
	act 'Мастурбировать': dynamic $drunken_body_mast
}
!показать попку
$drunken_body_popa = {
	*clr & cla
	minut += 5
	horny +=10
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/popa'+rand(1,11)+'.jpg', func('shulga_room_strings', 'local_str43')
	act 'Далее': dynamic $drunken_sex
}
!показать писю
$drunken_body_piz = {
	*clr & cla
	minut += 5
	horny +=10
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/piz'+rand(1,10)+'.jpg', func('shulga_room_strings', 'local_str44')
	act 'Далее': dynamic $drunken_sex
}
!показать сиськи
$drunken_body_sisi = {
	*clr & cla
	minut += 5
	horny +=10
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sisi'+rand(1,11)+'.jpg', func('shulga_room_strings', 'local_str45')
	act 'Далее': dynamic $drunken_sex
}
!мастурбировать
$drunken_body_mast = {
	*clr & cla
	minut += 5
	horny +=15
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/mast'+rand(1,10)+'.jpg', func('shulga_room_strings', 'local_str46')
	dynamic $masturb_gg
	act 'Далее': dynamic $drunken_sex
}
!пьяный секс
$drunken_sex = {
	*clr & cla
	minut += 5
	horny +=10
	bj +=3
	dom -= 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sex/bj'+rand(1,13)+'.jpg', func('shulga_room_strings', 'local_str47')
		act 'Далее':
		*clr & cla
		minut += 20
		horny +=10
		sex += 1
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sex/sex'+rand(1,22)+'.jpg"></center>'
		dynamic $gg_devst_deflor
		gs 'zz_render', '', '', func('shulga_room_strings', 'local_str48')
		dynamic $gg_sex_orgasm
			act 'Далее':
			*clr & cla
			minut += 5
			horny +=5
			gs 'zz_funcs', 'cum', 'belly'
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_funcs', 'cum', 'face'
			son -= 2
			if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
			if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
			if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
			gs 'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sex/cum'+rand(1,9)+'.jpg', func('shulga_room_strings', 'local_str49')
				if func('zz_reputation','get') < 3:
					gs 'zz_reputation','set',3
					gs 'zz_render', '', '', func('shulga_room_strings', 'local_str50')
				end
				act 'Далее': dynamic $drunken_sleep
		end
	end
}
!отказ от секса если гг нажралась репа: GorSlut < 3 (если репа >= 3, то отказ не будет доступен)
$drunken_sex_no = {
	*clr & cla
	minut += 5
	dom +=1
	health -= 10
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/sleep'+rand(1,17)+'.jpg', func('shulga_room_strings', 'local_str51')
	act 'Уснуть': dynamic $drunken_sleep
}
$drunken_sleep = {
	*clr & cla
	minut += 180
	if son < 20: son += 5
	health -= 10
	manna -= 25
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel'+rand(1,4)+'.jpg', func('shulga_room_strings', 'local_str52')
	act 'Встать': gt'shulga_room'
}
$shulga_beer = {
	if alko < 6:
		*clr & cla
		gs 'zz_funcs', 'alko', RAND(1,2)
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/beer'+rand(1,8)+'.jpg', func('shulga_room_strings', 'local_str53')
		act 'Еще выпить': dynamic $shulga_beer
		act 'Отойти': gt'shulga_room'
	else
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/Pjanaja'+rand(1,8)+'.jpg', func('shulga_room_strings', 'local_str54')
		if 	func('zz_reputation','get') < 3:
			act 'Сопротивляться': dynamic $drunken_sex_no
			act 'Не сопротивляться': dynamic $drunken_sex_yes
		else
			act 'Не сопротивляться': dynamic $drunken_sex_yes
		end
	end
}
!------------------------------------!
!Телевизор, порноканал, эвенты и т.д.!
!====================================!
!смотреть порноканалы
$view_pornotv = {
	act 'Смотреть порноканал':
	*clr & cla
	minut += 30
	manna += 5
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/tv/tvporn'+rand(1,5)+'.gif', func('shulga_room_strings', 'local_str55')
	act 'Закончить просмотр': gt'shulga_room'
	end
}
!групповой порно эвент с 0 до 2 ночи в будни, когда гопота тусуеться...
$view_pornotv_evgr = {
	act 'Смотреть порноканал':
	*clr & cla
	minut += 10
	manna += 4
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/tv/tvporn'+rand(1,5)+'.gif"></center>', func('shulga_room_strings', 'local_str56')
		if func('zz_reputation','get') < 3: act 'Уйти': gt'shulga_room'
		act 'Сосать':
			*clr & cla
			minut += 10
			horny += 10
			bj += 3
			if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
			if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
			if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
			gs 'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex_group/bj'+rand(1,13)+'.jpg', func('shulga_room_strings', 'local_str57')
				if func('zz_reputation','get') >= 3 and horny < 30 or func('zz_reputation','get') < 3:
				act 'Далее':
					*clr & cla
					minut += 10
					horny += 5
					gs 'zz_funcs', 'cum', 'face'
					gs 'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex_group/cum'+rand(1,7)+'.jpg', func('shulga_room_strings', 'local_str58')
					act 'Закончить': gt'shulga_room'
					end
				end
				if func('zz_reputation','get') >= 3 and horny >= 30:
				gs 'zz_render', '', '', func('shulga_room_strings', 'local_str59')
					act 'Ебаться':
						*clr & cla
						horny += 10
						minut += 20
						sex +=1
						gs 'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex_group/sex'+rand(1,23)+'.jpg', func('shulga_room_strings', 'local_str60')
						if horny >=70:
							orgasm += 1
							horny = 0
							gs 'zz_render', '', '', func('shulga_room_strings', 'local_str61')
							act 'Смотреть':
								*clr & cla
								gs 'stat'
								gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/kaif'+rand(1,7)+'.jpg', func('shulga_room_strings', 'local_str62')
								act 'Далее':
									*clr & cla
									minut += 10
									horny += 5
									son -= 1
									gs 'zz_funcs', 'cum', 'face'
									swallow += 1
									gs'stat'
									gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex_group/cum'+rand(1,7)+'.jpg', func('shulga_room_strings', 'local_str63')
									act 'Закончить': gt'shulga_room'
								end
							end
						else
							act 'Далее':
							*clr & cla
							minut += 10
							horny += 5
							son -= 1
							gs 'zz_funcs', 'cum', 'face'
							swallow += 1
							cumfrot += 1
							gs'stat'
							gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex_group/cum'+rand(1,7)+'.jpg', func('shulga_room_strings', 'local_str64')
							act 'Закончить': gt'shulga_room'
						end
					end
				end
			end
		end
	end
}
!эвент с просмотром порно канала с Васькой
$view_pornotv_vasya = {
	act 'Смотреть порно канал':
		*clr & cla
		minut += 10
		manna += 4
		horny += 15
		gs 'stat'
		'<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvporn'+rand(1,5)+'.gif" width="748" height="540"></center>'
		gs 'zz_render', '', '','Вы переключили на порно канал.'+iif($npc['11,relation'] <20,'<<$shulga_name_rnd>> возбудился просматривая порно. Вы заметили у него выпуклость в области паха.',iif($npc['11,relation'] <50,'<<$shulga_name_rnd>> возбудился просматривая порно, достал свой хуй и начал при вас дрочить, через пару минут попросил вас подрочить ему.',iif($npc['11,relation'] <70,'<<$shulga_name_rnd>> возбудился просматривая порно, достал свой хуй и начал надрачивать его, попросив вас ему отсосать.','<<$shulga_name_rnd>> сильно возбудился просматривая порно и без церемоний подошел к вам и насодил вашу голову на свой член. Вы даже не успели ничего понять.')))
		if $npc['11,relation'] < 70: act 'Уйти': gt'shulga_room'
		if $npc['11,relation'] >=70 and func('zz_reputation','get') < 3:
			act 'Сосать':
				*clr & cla
				minut += 10
				bj += 1
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex/bj'+rand(1,11)+'.jpg', func('shulga_room_strings', 'local_str65')
				act 'Далее':
					*clr & cla
					minut += 10
					gs 'zz_funcs', 'cum', 'face'
					cumfrot += 1
					gs 'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex/cum'+rand(1,10)+'.jpg', func('shulga_room_strings', 'local_str66')
					act 'Уйти': gt'shulga_room'
				end
			end
		end
		if $npc['11,relation'] >=20 and $npc['11,relation'] < 50:
			act 'Дрочить':
				*clr & cla
				minut += 20
				horny += 5
				cumfrot += 1
				gs 'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex/hj'+rand(1,7)+'.jpg', func('shulga_room_strings', 'local_str67')
				act 'Уйти': gt'shulga_room'
			end
		end
		if func('zz_reputation','get') >= 3 and $npc['11,relation'] >=70:
			act 'Сосать':
				*clr & cla
				minut += 5
				bj +=1
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex/bj'+rand(1,11)+'.jpg', func('shulga_room_strings', 'local_str68')
				act 'Далее':
					*clr & cla
					minut += 10
					horny += 15
					sex +=1
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex/sex'+rand(1,10)+'.jpg'
					dynamic $gg_devst_deflor
					gs 'zz_render', '', '', func('shulga_room_strings', 'local_str69')
					dynamic $gg_sex_orgasm
					act 'Далее':
						*clr & cla
						minut += 5
						gs 'zz_funcs', 'cum', 'face'
						gs 'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/tv_ev/sex/cum'+rand(1,10)+'.jpg', func('shulga_room_strings', 'local_str70')
						act 'Уйти': gt 'shulga_room'
					end
				end
			end
		end
	end
}
!----------------------------------!
!Телевизор в большой комнате Васяна!
!==================================!
$shultv = {
	rndtvs=rand(1,100)
	*clr & cla
	if rndtvs>10: minut += 30
	if rndtvs>10: manna += 10
	if rndtvs<=10: minut += 5
	gs 'stat'
shulga_tv_rnd = RAND(0,3)
			if shulga_tv_rnd = 0:$shulga_tv_rnd = 'По телевизору идет'
			if shulga_tv_rnd = 1:$shulga_tv_rnd = 'По телевизору показывают'
			if shulga_tv_rnd = 2:$shulga_tv_rnd = 'Показывают'
			if shulga_tv_rnd = 3:$shulga_tv_rnd = 'Идет'
shulga_tv_rand = RAND(0,11)
			if shulga_tv_rand = 0:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvdance.gif"></center><<$shulga_tv_rnd>> подростковый музыкальный клип, где девушки трясут своими прелестями.'
			if shulga_tv_rand = 1:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvgeo1.gif"></center><<$shulga_tv_rnd>> документальный фильм про животных.'
			if shulga_tv_rand = 2:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvgeo2.gif"></center><<$shulga_tv_rnd>> документальный фильм про мир.'
			if shulga_tv_rand = 3:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvgeo3.gif"></center><<$shulga_tv_rnd>> документальный фильм про природу.'
			if shulga_tv_rand = 4:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvgeo4.gif"></center><<$shulga_tv_rnd>> документальный фильм про океан.'
			if shulga_tv_rand = 5:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvkino1.gif"></center><<$shulga_tv_rnd>> всеми любимая советская комедия.'
			if shulga_tv_rand = 6:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvkino2.gif"></center><<$shulga_tv_rnd>> импортный блокбастер.'
			if shulga_tv_rand = 7:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvkino3.gif"></center><<$shulga_tv_rnd>> старый вестерн.'
			if shulga_tv_rand = 8:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvmult1.gif"></center><<$shulga_tv_rnd>> относительно новый импортный мультик.'
			if shulga_tv_rand = 9:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvmult2.gif"></center><<$shulga_tv_rnd>> старый мультик.'
			if shulga_tv_rand = 10:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvsport1.gif"></center><<$shulga_tv_rnd>> бой без правил.'
			if shulga_tv_rand = 11:$shulga_tv_rand = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvsport2.gif"></center><<$shulga_tv_rnd>> футбол.'
if rndtvs>10:gs 'zz_render', '', '','<<$shulga_tv_rand>> <br> Вы промастриваете телевизор около получаса.'
if rndtvs<=10:gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/tv/tvrekl'+rand(1,4)+'.gif','Идёт реклама.'
act 'Закончить просмотр': gt'shulga_room'
	act 'Переключить канал': dynamic $shultv
	act 'Закончить просмотр': gt'shulga_room'
porno_tv_rand=RAND(0,100)
	if porno_tv_rand<50 or porno_tv_rand>=50 and week < 6 and hour >= 3 and hour <= 23 or porno_tv_rand>=50 and week >= 6 and hour > 2 and hour < 10 or porno_tv_rand>=50 and week >= 6 and hour > 16 and hour <= 23: dynamic $view_pornotv
	if porno_tv_rand>=50:
		if week >= 6 and hour >= 10 and hour <= 16: dynamic $view_pornotv_vasya
		if week >= 6 and hour >= 0 and hour <= 2:dynamic $view_pornotv_vasya
		if week < 6 and hour >= 0 and hour <= 2: dynamic $view_pornotv_evgr
	end
}
!--------------------------------------!
!Базар с Васяном ночью в будни с 0 до 2!
!======================================!
$shulga_bazar_night = {
	rnd_rebyata = RAND(0,7)
	if rnd_rebyata = 0:$rnd_rebyata = 'Витька'
	if rnd_rebyata = 1:$rnd_rebyata = 'Витёк'
	if rnd_rebyata = 2:$rnd_rebyata = 'Витя'
	if rnd_rebyata = 3:$rnd_rebyata = 'Рыжов'
	if rnd_rebyata = 4:$rnd_rebyata = 'Котов'
	if rnd_rebyata = 5:$rnd_rebyata = 'Дэн'
	if rnd_rebyata = 6:$rnd_rebyata = 'Дэнчик'
	if rnd_rebyata = 7:$rnd_rebyata = 'Денис'
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vasya.jpg', func('shulga_room_strings', 'local_str71')
	dynamic $vasya_shulgin_rep
	act 'Отойти': gt 'shulga_room'
	act 'Поговорить':
		*clr & cla
		minut += 10
		bazar_day = daystart
		bazar_count -= 1
		if bazar_count > 0: gs 'npc_editor','change_rep','+', 11
		gs 'stat'
		!базар когда гг с репой gorslut<3:
		vasyan_textb = RAND(0,8)
		if vasyan_textb = 0:$vasyan_textb = 'Вы недолго болтаете на разные темы.'
		if vasyan_textb = 1:$vasyan_textb = 'Вы слушаете как <<$shulga_name_rnd>> рассказывает какую-то историю.'
		if vasyan_textb = 2 and school['certificate'] = 0:$vasyan_textb = 'Вы треплетесь о школе'
		if vasyan_textb = 2 and school['certificate'] = 1:$vasyan_textb = 'Вы с настольгией вспоминаете то время, когда учились в школе.'
		if vasyan_textb = 3:$vasyan_textb = '<<$shulga_name_rnd>> рассказывает как провёл день.'
		if vasyan_textb = 4:$vasyan_textb = '<<$shulga_name_rnd>> рассказывает смешную шутку.'
		if vasyan_textb = 5:$vasyan_textb = 'Рассказывает анекдот:<br>Разговор по Skуpе: — Люся, покажи сиськи!<br> — Нет, ты что, мы же друзья.<br> — Будь другом, покажи сиськи!'
		if vasyan_textb = 6:$vasyan_textb = 'Рассказывает анекдот:<br>- Вовочка, ты когда с дискотеки вернешься?<br>- Рано. Вы ещё спать будете...'
		if vasyan_textb = 7:$vasyan_textb = 'Рассказывает анекдот:<br>"Стоит Вовочка на улице курит сигарету. Незнакомая женщина делает ему замечание:<br>- Мальчик, а твои родители знают, что ты куришь?<br>- Тётенька, а ваш муж знает, что вы пристаёте к незнакомым мужчинам на улицах?'
		if vasyan_textb = 8 and $npc['11,relation'] < 30:$vasyan_textb = 'Вы болтаете минут десять на разные темы.'
		if vasyan_textb = 8 and $npc['11,relation'] >=30 and webcamera = 1:$vasyan_textb = 'Вы беседуете на разные темы.'
		if vasyan_textb = 8 and $npc['11,relation'] >=30 and $npc['11,relation'] <50 and webcamera = 0:$vasyan_textb = '<<$shulga_name_rnd>> говорит: "Тут тема новая появилась, можно нормально деньжат поднять в интернете. Про вебкам-чаты слышала?"<br>-"Нет, но интересно. Рассказывай!" <br>- Васян продолжает: -"Ну так вот: короче, нужна вебкамера и компьютер, с интернетом, разумеется. Регишься на вебкам-сайте и можешь транслировать себя через интернет на камеру, а всякие лохи платят за просмотр денежку.<br>И, говорят, - чем откровеннее шоу, - тем больше бабла можно заработать."<br>-"Ну я не знаю, неправильно продавать своё тело" - в сомнениях мнётесь вы.<br>Вася парирует: -"Да чего ты там себе выдумываешь? - кому чего продавать то? Всего-то пару часиков перед камерой жопой повертеть - и можно нормально срубить денег! Это тебе не на дороге стоять, пиздой торговать!"'
		if vasyan_textb = 8 and $npc['11,relation'] >=50 and $npc['11,relation'] < 70:$vasyan_textb = '<<$shulga_name_rnd>> Спрашивает: -"Помнишь, я тебе говорил про вебкам-чаты, ну там где бабло можно заработать, вертя жопой?"<br>-"Ага, помню" - отвечаете вы.<br><<$shulga_name_rnd>> продолжает разговор: - "Я тут вебку недавно купил, чтобы по скайпу с пацанами базарить, ты, если хочешь - можешь воспользоваться моим ноутом, мне не жалко."<br>-"Спасибо, я подумаю..." - отвечаете вы.'
		if vasyan_textb = 8 and $npc['11,relation'] >=100:$vasyan_textb = '<<$shulga_name_rnd>> Спрашивает: -"Чо как, вебкой пользовалась? - вертела уже жопой в онлайн-чате?"<br>-"Да, было дело" - не смущаясь отвечаете вы.<br><<$shulga_name_rnd>> продолжает разговор: - "Ты, если что, по выходным можешь меня звать, вместе шоу будем делать: задроты больше денег заплатят, если увидят как тебя шпилят в онлайне!"<br>-"Идея неплохая, я подумаю..." - говорите вы.'
		!базар когда гг с репой gorslut>=3:
		vasyan_textb_gorslut = RAND(0,12)
		if vasyan_textb_gorslut = 0 and $npc['25,qwSoniaSlut'] = 1:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> рассказывает как он с корешами драл Соньку: "Прямо в парке эту шлюшку разложили на лавочке, вертели как хотели пока мы с пацанами не устали, а она, блядина такая, ещё требовала!"<br> <<$rnd_rebyata>> подтвердил: "Ага, у меня после пары палок уже не стоял, а она всё ещё не унималась, ртом пытаясь поднять мой хер, требуя продолжения!"'
		if vasyan_textb_gorslut = 0 and $npc['25,qwSoniaSlut'] <=0:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> мечтательно говорит: -"Сонька на дискаче, бывает, так набухивается!.. Надо бы её как-нибудь поймать и выебать: пьяная баба пизде же не хозяйка, ведь так?"<br> Пацаны хором ржут.'
		if vasyan_textb_gorslut = 1:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> спрашивает: "<<$sveta_rnd_name>>, хорошо ли мы вчера в парке тебя по кругу пустили? - Я ж тебя давно знаю, нравится тебе это дело, ведь так?"<br> - "Да, понравилось", - соглашаетесь вы.<br> <<$rnd_rebyata>> намекает: "Надо бы повторить!" <br>Вы просто по-блядски улыбаетесь в ответ.'
		if vasyan_textb_gorslut = 2 and $npc['25,qwSoniaSlut'] = 1:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> спрашивает: "<<$sveta_rnd_name>> а как тебе Соня? Я бы посмотрел на вас вместе, может как-нибудь нам с пацанами шоу устроите?"<br><<$rnd_rebyata>> добавляет: "Да, две наши нимфоманки могли бы такое показать!" <br> - "Всё может быть..." - улыбаясь, отвечаете вы.'
		if vasyan_textb_gorslut = 2 and $npc['25,qwSoniaSlut'] <=0:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> спрашивает: "<<$sveta_rnd_name>> а как тебе Соня? Я бы посмотрел на вас вместе, может как-нибудь нам с пацанами шоу устроите?"<br><<$rnd_rebyata>> добавляет: "Да, Соньку бы раскрутить... Надо на дискаче её напоить и выебать." <br> - "Всё может быть..." - улыбаясь, отвечаете вы.'
		if vasyan_textb_gorslut = 3 and school['certificate'] = 0:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> мечтательно говорит: "Эх сейчас бы нашу Англичанку выебать, на уроках покоя не даёт ее одежда, словно специально миниюбку надевает, чтобы пацанов подразнить!"<br> - "Согласна, вертит жопой как специально! - я бы посмотрела как её дрючат, а может и сама бы поруководила процессом!" - киваете вы.'
		if vasyan_textb_gorslut = 3 and school['certificate'] = 1:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> мечтательно говорит: "Эх сейчас бы Юльку выебать, покоя не даёт её тело! Словно специально лёгкие платья надевает чтобы подразнить!"<br> - "Согласна, вертит попкой как специально! Я бы посмотрела как её дрючат, а может и сама бы поруководила процессом!" - ухмыляетесь вы.'
		if vasyan_textb_gorslut = 4:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> рассказывает: "<<$sveta_rnd_name>>, говорят, твоя мамка - та ещё шлюшка: я тут не так давно слышал, что в кафешке, где она работает, хозяин её пялит почти каждый день. Хоть и не молодуха, но ещё ничего так: ухаживает за собой, фигурка хорошая, да и опыта вагон наверное... Я бы сам вдул." - Пацаны одобрительно соглашаются со словами Шульги.<br> "Мечтать не вредно!" - вертите вы кукиш у них перед носами.'
		if vasyan_textb_gorslut = 5 and school['certificate'] = 0 and $npc['25,qwSoniaSlut'] = 1:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> говорит: "Недавно в школе такое видал - аж ахуел... Соньку в туалете по кругу какие-то сопляки пускали. Ей уже, по-моему, похуй - где и с кем ебаться, главное чтобы побольше хуёв и покрепче."<br> - "Ага, сделали из неё нимфоманку, теперь без хуя и дня не протянет" - соглашаетесь вы. <br> <<$rnd_rebyata>> говорит: "Да мы её и так почти каждый день подкармливаем". - Пацаны ржут.'
		if vasyan_textb_gorslut = 5 and school['certificate'] = 1 and $npc['25,qwSoniaSlut'] = 1:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> говорит: "На рынке случайно такое видал - аж ахуел. Сонька, похоже, за шмотками пришла на рынок, а её там по кругу пустили Артур и его компания. Ей уже, по-моему, похуй - где и с кем ебаться, лишь бы много хуёв было. А на рынке ещё и скидку сделают." <br> - "Сделали из неё общую дырку - теперь ей и прохода нету, да и сама она без хуя уже и дня не протянет" - соглашаетесь вы. <br> <<$rnd_rebyata>> говорит: "Да мы её и так почти каждый день подкармливаем, но согласен - с нас скидку на шмотки не выбить!" Пацаны ржут.'
		if vasyan_textb_gorslut = 5 and $npc['25,qwSoniaSlut'] <= 0:$vasyan_textb_gorslut = 'Вы некоторое время беседуете на разные пошлые темы.'
		if vasyan_textb_gorslut = 6:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> намекает: "Что, <<$sveta_rnd_name>>, - когда ебаться будем?" - Пацаны переглядываются и уставляются на вас, ожидая ответа.<br> - "Как надумаю - так сразу" - спокойно отвечаете вы.<br> <<$rnd_rebyata>>: - "Может тебе выпить нужно, для расслабления организма, - быстрее надумаешь?". Пацаны ржут. <br> Вы бросаете недовольный взгляд на компашку: "Не в этом дело. Хотя выпить идея хорошая."'
		if vasyan_textb_gorslut = 7:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> возбуждённо расспрашивает: "<<$sveta_rnd_name>>, а ты в попку даёшь с удовольствием или это для тебя мучение?"<br> - "Сначала не нравилось, но потом привыкла и теперь даже иногда кайф от этого ловлю" - хитро прищуриваетесь вы.<br> <<$rnd_rebyata>> хохмит: "Ну конечно: уже нравится, когда дупло не закрывается!" Пацаны ржут.'
		if vasyan_textb_gorslut = 8:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> расспрашивает: "<<$sveta_rnd_name>>, а какая поза тебе больше всего нравится в сексе?"<br> - "Удобная!" - смеясь, отвечаете вы.<br> Пацаны хором ржут.'
		if vasyan_textb_gorslut = 9:$vasyan_textb_gorslut = 'Рассказывает пошлый анекдот:<br>"Пацан провожает деваху до дома. Заходят в подъезд, останавливаются на лестничной площадке.<br>Она: — Выкрути лампочку.<br>Он выкручивает. В полной темноте она говорит:<br> — Хочешь, в рот возьму?<br> — Ты что? Она же горячая!"'
		if vasyan_textb_gorslut = 10:$vasyan_textb_gorslut = 'Рассказывает анекдот:<br>"Удав, глядя на слона:<br> — Ха-ха, член на морде!<br> Слон, глядя на удава:<br> — Ха-ха морда на члене!"'
		if vasyan_textb_gorslut = 11:$vasyan_textb_gorslut = 'Рассказывает анекдот: "Ботаник Андрюша на шестой школьный Новый Год оделся не в костюм какой-то там белочки, а в костюм царя зверей, но всё равно получил пиздюлей от зайчика Ильи."'
		if vasyan_textb_gorslut = 12 and $npc['11,relation'] < 30:$vasyan_textb_gorslut = 'Вы беседуете минут десять на разные темы.'
		if vasyan_textb_gorslut = 12 and $npc['11,relation'] >=30 and webcamera = 1:$vasyan_textb_gorslut = 'Вы беседуете на разные темы.'
		if vasyan_textb_gorslut = 12 and $npc['11,relation'] >=30 and $npc['11,relation'] <50 and webcamera = 0:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> говорит: "Тут тема новая появилась, можно нормально деньжат поднять в интернете. Про вебкам-чаты слышала?"<br>-"Нет, но интересно. Рассказывай." - говорите вы.<br>Васян продолжает: -"Ну так вот: нужна вебкамера и компьютер. Регишься на вебкам-сайте и можешь транслировать себя через интернет на камеру, а всякие лохи платят за просмотр денежку.<br>И, говорят, - чем откровеннее шоу, - тем больше бабла можно заработать.<br>-"Ну я не знаю, неправильно продавать своё тело" - задумываетесь вы.<br>Вася парирует: -"Да чего ты там себе выдумываешь - кому чего продавать-то? Всего-то пару часиков перед камерой жопой повертеть - и можно нормально срубить денег! Это тебе не на дороге стоять, пиздой торговать."'
		if vasyan_textb = 12 and $npc['11,relation'] >=50 and $npc['11,relation'] < 70:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> Спрашивает: -"Помнишь, я тебе говорил про вебкам-чаты, ну там, где бабло можно заработать, вертя жопой?"<br>-"Ага, помню" - отвечаете вы.<br><<$shulga_name_rnd>> продолжает разговор: - "Я тут вебку недавно купил, чтобы по скайпу с пацанами базарить. Ты, если хочешь, можешь пользоваться моим ноутом - мне не жалко."<br>- Спасибо, я подумаю - отвечаете вы.'
		if vasyan_textb = 12 and $npc['11,relation'] >=100:$vasyan_textb_gorslut = '<<$shulga_name_rnd>> Спрашивает: -"Чо, как - вебкой пользовалась, вертела уже жопой в онлайн-чате?"<br>-"Да, было дело" - не смущаясь, отвечаете вы.<br><<$shulga_name_rnd>> продолжает разговор: - "Ты, если что, по выходным можешь меня звать - вместе шоу будем делать: задроты больше денег заплатят, если увидят как тебя шпилят в онлайне."<br>- Идея неплохая, я подумаю... - говорите вы.'
		dynamic $vasya_shulgin_rep
		if bazar_count <= 0:gs 'zz_render', '', '','<<$shulga_name_rnd>> отмахивается: - "<<$sveta_rnd_name>>, ты утомила своими разговорами, отстань."'
		if func('zz_reputation','get') < 3 and bazar_count > 0:gs 'zz_render', '', '', '<<$vasyan_textb>>'
		if func('zz_reputation','get') >=3 and bazar_count > 0:gs 'zz_render', '', '', '<<$vasyan_textb_gorslut>>'
		act 'Далее': dynamic $shulga_bazar_night
	end
	act 'Пить пиво': dynamic $shulga_beer
	if $npc['11,relation']>=70 and alko >= 1 or $npc['11,relation']>=70 and horny > 50 or func('zz_reputation','get') >=3 and alko >= 1:
		act 'Потрахаться':
		if shgopsex_vasya_count = 0:
			cla
			gs 'zz_render', '', '', func('shulga_room_strings', 'local_str72')
			act 'Далее': dynamic $shulga_bazar_night
		else
			$gopsex_name_npc = 'Вася'
			$gopsex_n_npc = 1
			shgopsex_vasya_day = daystart
			shgopsex_vasya_count -= 1
			dynamic $shgopsex
		end
	end
end
}
!--------------------------------------------!
!Базар с Дэном (Рыжов) ночью в будни с 0 до 2!
!============================================!
$den_bazar = {
rnd_rebyata2 = RAND(0,7)
	if rnd_rebyata2 = 0:$rnd_rebyata2 = 'Витька'
	if rnd_rebyata2 = 1:$rnd_rebyata2 = 'Витёк'
	if rnd_rebyata2 = 2:$rnd_rebyata2 = 'Витя'
	if rnd_rebyata2 = 3:$rnd_rebyata2 = 'Котов'
	if rnd_rebyata2 = 4:$rnd_rebyata2 = 'Васька'
	if rnd_rebyata2 = 5:$rnd_rebyata2 = 'Шульга'
	if rnd_rebyata2 = 6:$rnd_rebyata2 = 'Васян'
	if rnd_rebyata2 = 7:$rnd_rebyata2 = 'Васёк'
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/den.jpg', func('shulga_room_strings', 'local_str73')
	act 'Отойти': gt 'shulga_room'
	act 'Поговорить':
		*clr & cla
		minut += 5
		bazar_day_den = daystart
		bazar_count_den -= 1
		gs'stat'
!базар когда гг с репой gorslut<3:
den_textb = RAND(0,6)
			if den_textb = 0:$den_textb = 'Вы недолго беседуете на разные темы.'
			if den_textb = 1 and school['certificate'] = 0:$den_textb = 'Вы беседуете о школе.'
			if den_textb = 1 and school['certificate'] = 1:$den_textb = 'Вы беседуете о жизни после окончания школы.'
			if den_textb = 2:$den_textb = 'Вы слушаете как Дэн травит какую-то байку.'
			if den_textb = 3:$den_textb = 'Вы болтаете о всякой ерунде.'
			if den_textb = 4:$den_textb = 'Дэн хохмит, рассказывая какую-то шутку.'
			if den_textb = 5:$den_textb = 'Дэн жалуется: "Вот пример порочного круга. Мать говорит: "Слушай отца". Отец говорит: "Никогда не слушай баб."'
			if den_textb = 6:$den_textb = 'Рассказывает анекдот:<br>"Мариванна отчитывает Вовочку:<br>- Вовочка, добрая половина девочек нашей школы жалуется, что ты постоянно пристаёшь к ним с неприличными предложениями!<br>- Клевета, Мариванна! - отвечает Вовочка. - Это не добрая, а злая половина. Добрая отвечает на мои предложения согласием."'
!базар когда гг с репой gorslut>=3:
den_textb_gorslut = RAND(0,7)
			if den_textb_gorslut = 0:$den_textb_gorslut = 'Денис спрашиает вас: - <<$sveta_rnd_name>>, как у тебя с деньгами? Если мало - могу подработку для тебя найти: тело у тебя ничего так, рот рабочий, да и другие дырки разработаны. Можно нормально так бабло зашибать.<br>-"Прекращай фантазировать, я тебе что - шлюха какая!?" - зло отвечаете вы.<br><<$rnd_rebyata2>> защищая друга говорит: - Да ты не кипишуй, у него всего лишь мысли вслух...'
			if den_textb_gorslut = 1 and $npc['25,qwSoniaSlut'] = 1:$den_textb_gorslut = 'Дэн спрашиает: - <<$sveta_rnd_name>>, когда ты нам какую-нибудь свою подружку подгонишь?<br>- А я что - одна уже не справляюсь? - корча обиженную мину, спрашиваете вы.<br>Дэн отвечает: - Да не, я не в претензиях, просто сразу с двумя бабами охота попробовать!<br><<$rnd_rebyata2>> заголосил: - Да Соньку можно позвать, ей вообще похуй с кем и где. Её и <<$name_a[1]>> вместе разложить было бы супер."<br>Все соглашаются, что идея хорошая.'
			if den_textb_gorslut = 1 and $npc['25,qwSoniaSlut'] <=0:$den_textb_gorslut = 'Дэн спрашиает: - <<$sveta_rnd_name>>, когда ты нам какую-нибудь свою подружку подгонишь?<br>- А я, что разве одна не справляюсь? - корча обиженную мину спрашиваете вы.<br>Дэн отвечает: - Да не, я не в претензиях, просто сразу с двумя бабами охота попробовать!<br><<$rnd_rebyata2>> заголосил: - Отличная идея! Осталось найти подходящую кандидатуру.'
			if den_textb_gorslut = 2 and $npc['25,qwSoniaSlut'] = 1:$den_textb_gorslut = 'Дэнчик рассказывает: - Соньку вчера на дискаче все кому не лень танцевать звали, а потом в сортир водили. Недавно ещё такая паинька была, а теперь безотказная и самой ей походу в кайф такое положение.'
			if den_textb_gorslut = 2 and $npc['25,qwSoniaSlut'] <=0:$den_textb_gorslut = 'Дэнчик рассказывает: - Сонька такая паинька, у меня давно мысля появилась на дискаче её хорошенько напоить и пустить по кругу.'
			if den_textb_gorslut = 3:$den_textb_gorslut = 'Дэн говорит: - Прикиньте пацаны, я тут такое узнал! Аптекарша-то наша, Людка, с негром живёт. Говорят, у чёрных хуи огромные, небось с твою руку <<$name[2]>>!<br>Пацаны ржут, вы усмехаетесь.<br>- Людка баба хоть и в возрасте, но еще многим молодухам фору даст.'
			if den_textb_gorslut = 4:$den_textb_gorslut = 'Рассказывает анекдот:<br>Жена говорит мужу:<br> — Я когда-то в институте встречалась с одним парнем... Пошли мы как-то в кино, и посреди фильма он меня спрашивает: "Хочешь пососать?" Я, естественно, начала возмущаться, а он достал из кармана чупа-чупс и протянул мне.<br>Муж, задумчиво:<br> — У этого парня, походу, был просто гениальный план отступления.'
			if den_textb_gorslut = 5:$den_textb_gorslut = 'Дэн расспрашивает: - <<$sveta_rnd_name>>, как сеструха твоя поживает? Парень-то у неё есть? Она же в магазине продавщицей работает, небось от грузчиков отбоя нет, не мучают её там? Может помощь ей какая нужна? Девка-то она видная, да и я парень ходь куда: Яйца, табак, перегар и щетина - чем хуже грузчиков? <br>- Вроде есть, но я в её личную жизнь стараюсь не лезть - отвечаете вы.'
			if den_textb_gorslut = 6:$den_textb_gorslut = 'Рассказывает анекдот:<br>Мужик "снял" девушку в ресторане, шикарный стол, шампанское, икра и т. д.<br>Потом говорит: — Поехали ко мне! Едут (ночь, зима), он сворачивает в парк, останавливается, достаёт пистолет — Раздевайся догола, вылезай и лепи снеговика. - Она вся в слезах, разделась, вылезла, слепила.<br>— Залезай в машину. Одевайся. Приехали на "хату", офигенный стол, потом такой же ceкc, потом он отвозит ее куда она просит.<br>Она: — Зачем?! Зачем?! Я бы и без снеговика дала...<br>Он: — Понимаешь... шампанское... икра, ceкc — все это ты скоро забудешь, а вот "снеговика" — вряд ли...'
			if den_textb_gorslut = 7:$den_textb_gorslut = 'Рассказывает анекдот:<br>Приходит учительница на урок, надела на шею на цепочку, новый золотой кулончик в виде самолётика. Вовочка весь урок не сводит с него глаз. В конце урока учительница спрашивает:<br>"Что, Вовочка, тебе так самолётик понравился?"<br>- "Нет, аэродромик."'
if bazar_count_den <= 0:gs 'zz_render', '', '','Дэн ворчит: - <<$sveta_rnd_name>>, надоела своими разговорами, отстань.'
if func('zz_reputation','get') < 3 and bazar_count_den > 0:gs 'zz_render', '', '', '<<$den_textb>>'
if func('zz_reputation','get') >=3 and bazar_count_den > 0:gs 'zz_render', '', '', '<<$den_textb_gorslut>>'
		act 'Далее': dynamic $den_bazar
	end
	act 'Пить пиво': dynamic $shulga_beer
	if func('zz_reputation','get') >=3 and alko >= 1:
		act 'Потрахаться с Дэном':
		if shgopsex_den_count = 0:
			cla
			gs 'zz_render', '', '', func('shulga_room_strings', 'local_str74')
			act 'Уйти': gt'shulga_room'
		elseif shgopsex_den_count > 0:
			$gopsex_name_npc = 'Дэн'
			$gopsex_n_npc = 0
			shgopsex_den_day = daystart
			shgopsex_den_count -= 1
			dynamic $shgopsex
		end
	end
end
}
!---------------------------------------------!
!Базар с Витек(Котов) ночью в будни с 0 до 2!
!=============================================!
$vitek_bazar = {
rnd_rebyata3 = RAND(0,7)
	if rnd_rebyata3 = 0:$rnd_rebyata3 = 'Дэн'
	if rnd_rebyata3 = 1:$rnd_rebyata3 = 'Дэнчик'
	if rnd_rebyata3 = 2:$rnd_rebyata3 = 'Денис'
	if rnd_rebyata3 = 3:$rnd_rebyata3 = 'Рыжов'
	if rnd_rebyata3 = 4:$rnd_rebyata3 = 'Васька'
	if rnd_rebyata3 = 5:$rnd_rebyata3 = 'Шульга'
	if rnd_rebyata3 = 6:$rnd_rebyata3 = 'Васян'
	if rnd_rebyata3 = 7:$rnd_rebyata3 = 'Васёк'
rnd_vitek_name = RAND(0,3)
	if rnd_vitek_name = 0:$rnd_vitek_name = 'Витёк'
	if rnd_vitek_name = 1:$rnd_vitek_name = 'Витька'
	if rnd_vitek_name = 2:$rnd_vitek_name = 'Виктор'
	if rnd_vitek_name = 3:$rnd_vitek_name = 'Витя'
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vitek.jpg', func('shulga_room_strings', 'local_str75')
	act 'Отойти': gt 'shulga_room'
	act 'Поговорить':
		*clr & cla
		minut += 5
		bazar_day_vitek = daystart
		bazar_count_vitek -= 1
		gs'stat'
!базар когда гг с репой gorslut<3:
vitek_textb = RAND(0,7)
			if vitek_textb = 0:$vitek_textb = 'Вы недолго беседуете на разные темы.'
			if vitek_textb = 1 and school['certificate'] = 0:$vitek_textb = 'Вы беседуете о школе.'
			if vitek_textb = 1 and school['certificate'] = 1:$vitek_textb = 'Вы беседуете о разном.'
			if vitek_textb = 2:$vitek_textb = 'Вы слушаете как Витёк рассказывает интересную историю.'
			if vitek_textb = 3:$vitek_textb = 'Вы болтаете о всякой ерунде.'
			if vitek_textb = 4:$vitek_textb = 'Котов рассказывает смешную шутку.'
			if vitek_textb = 5:$vitek_textb = '— Правда, что минута смеха продлевает жизнь на пять минут?<br>— Ну, это смотря над кем смееться… Может и сократить…'
			if vitek_textb = 6:$vitek_textb = 'Рассказывает анекдот:<br>- Привет, Люся! Как выходные?<br>- Удались!<br>- Сама удались, овца!'
			if vitek_textb = 7:$vitek_textb = 'Интересный факт: если у человека полный холодильник пива, то всегда найдутся друзья с водкой.'
!базар когда гг с репой gorslut>=3:
vitek_textb_gorslut = RAND(0,7)
			if vitek_textb_gorslut = 0:$vitek_textb_gorslut = '<<$rnd_vitek_name>> рассказывает как они проводят время: - Мы с пацанами либо творим хуйню, либо вспоминаем о хуйне, которую натворили раньше.'
			if vitek_textb_gorslut = 1:$vitek_textb_gorslut = '<<$rnd_vitek_name>> говорит: - Близость к человеку определяется тем, насколько сильно ты можешь над ним издеваться, не получив при этом пиздюлей.'
			if vitek_textb_gorslut = 2:$vitek_textb_gorslut = '<<$rnd_vitek_name>> рассказывает: - <<$sveta_rnd_name>>, а ты знала, что опытным путем установлено, что до 95% девушек, не имеющих секса более месяца, не могут с первого раза произнести правильно название города Набережные Челны?'
			if vitek_textb_gorslut = 3 and school['certificate'] = 0 and $npc['25,qwSoniaSlut'] = 1:$vitek_textb_gorslut = '<<$rnd_vitek_name>> рассказывает: - Соньку вчера прижал в школьном туалете, но потом она забралась на меня сверху, и я вдруг понял, что изнасилование у меня как-то не задалось. <br>Все присутствующие в комнате заржали.'
			if vitek_textb_gorslut = 3 and school['certificate'] = 1 and $npc['25,qwSoniaSlut'] = 1:$vitek_textb_gorslut = '<<$rnd_vitek_name>> рассказывает: -"Соньку вчера прижал в парке, но потом она забралась на меня сверху, и я вдруг понял, что изнасилование у меня как-то не задалось."<br>Все присутствующие в комнате заржали.'
			if vitek_textb_gorslut = 3 and $npc['25,qwSoniaSlut'] <= 0:$vitek_textb_gorslut = 'Вы слушаете как Витёк рассказывает пошлую историю'
			if vitek_textb_gorslut = 4:$vitek_textb_gorslut = 'Друзья пьют пиво и беседуют о бабах и cекcе, вы влезаете в разговор и спрашиваете Витька:<br>— А как ты думаешь, кому cекc приятнее - мужчине или женщине?<br><<$rnd_vitek_name>> задумывается, но тут влезает <<$rnd_rebyata3>>:<br>— Ежу понятно, женщине! Вот у тебя ухо зачесалось, так какой части тела приятнее, пальцу, которым ты ухо почесала, или самому уху!'
			if vitek_textb_gorslut = 5:$vitek_textb_gorslut = '<<$rnd_vitek_name>> спрашивает: -"<<$sveta_rnd_name>>, а ты знаешь - какое главное качество пениса?<br>- это его воспитанность. Он обязан встать при виде обнажённой дамы, чтобы даме было на что сесть."<br>Комната наполнилась смехом.'
			if vitek_textb_gorslut = 6:$vitek_textb_gorslut = '<<$rnd_vitek_name>> говорит: - Пьяная девушка своей пизде не хозяйка.<br>Вы парируете: - Даааа. Как будто пьяный мужик своему хую великий командир".<br>Друзья ржут.'
			if vitek_textb_gorslut = 7:$vitek_textb_gorslut = 'Рассказывает анекдот:<br>Мужик заходит в аптеку и громко заявляет:<br>- Мне пачку презервативов, пожалуйста!<br>Молоденькая продавщица покраснела и шепчет:<br>- Такое надо на ухо...<br>Мужик:<br>- А зачем мне на ухо?! Мне на хуй нужно!!!'
if bazar_count_vitek <= 0:gs 'zz_render', '', '','Витёк бурчит: - <<$sveta_rnd_name>>, надоела своими разговорами, отстань.'
if func('zz_reputation','get') < 3 and bazar_count_vitek > 0:gs 'zz_render', '', '', '<<$vitek_textb>>'
if func('zz_reputation','get') >=3 and bazar_count_vitek > 0:gs 'zz_render', '', '', '<<$vitek_textb_gorslut>>'
		act 'Далее': dynamic $vitek_bazar
	end
	act 'Пить пиво': dynamic $shulga_beer
	if func('zz_reputation','get') >=3 and alko >= 1:
		act 'Потрахаться':
		if shgopsex_vitya_count = 0:
			cla
			gs 'zz_render', '', '', func('shulga_room_strings', 'local_str76')
			act 'Уйти': gt'shulga_room'
		elseif shgopsex_vitya_count > 0:
			$gopsex_name_npc = 'Витя'
			$gopsex_n_npc = 2
			shgopsex_vitya_day = daystart
			shgopsex_vitya_count -= 1
			dynamic $shgopsex
		end
	end
end
}
!-----------------------------------------------------------------!
!Базар с Васяном и другие ивенты в выходные с 10 до 17 и с 23 до 3!
!=================================================================!
!----------------------!
!-----Делаем уроки-----!
!======================!
!выбор сета картинок
lern_imgset = rand(1,7)
!ограничение в 1 секс после уроков
if shulga_lern_day ! daystart: shulga_lern_count = 1
!согласие на секс
$shulga_lern_sex_yes = {
	*clr & cla
	shulga_lern_day = daystart
	shulga_lern_count -= 1
	minut += 5
	if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
	if lern_imgset <= 3:sex += 1
	if lern_imgset >= 3:anal += 1
	bj += 1
	horny += 10
	$boy = 'Вася'
	dick = 15
	silaVag = 0
	if lern_imgset = 3:horny += 20
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/lern/ev<<lern_imgset>>_2.jpg'
	if lern_imgset ! 3:gs 'zz_dynamic_sex', 'bj'
	if lern_imgset = 3:gs 'zz_render', '', '','<<$boy>> быстро, но нежно раздевает вас и припадает губами к вашей изнывающей киске'+iif(horny < 100,'.',', вылизывая ее до тех пор, пока не доводит вас до мощного оргазма.')
	if horny >= 100:
		orgasm += 1
		horny = 0
		manna = 100
	end
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str77')
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 10
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/lern/ev<<lern_imgset>>_3.jpg"></center>'
		!dynamic $gg_devst_deflor
		if lern_imgset <= 3:
			gs 'gopsex', 'gg_devst_deflor'
			gs 'zz_dynamic_sex', 'sex_start', 1
			gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
		else
			gs 'zz_dynamic_sex', 'anal_start', 'dick'
			gs 'zz_dynamic_sex', 'anal', 'dick', 1
		end
		gs 'zz_render', '', '', func('shulga_room_strings', 'local_str78')
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/lern/ev<<lern_imgset>>_4.jpg"></center>'
			!dynamic $gg_sex_orgasm
			if lern_imgset <= 2:
				gs 'zz_dynamic_sex', 'sex_start', 1
				gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
			else
				gs 'zz_dynamic_sex', 'anal_start', 'dick'
				gs 'zz_dynamic_sex', 'anal', 'dick', 1
			end
			gs 'zz_render', '', '', func('shulga_room_strings', 'local_str79')
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs'stat'
				'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/lern/ev<<lern_imgset>>_5.jpg"></center>'
				if lern_imgset < 7:
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_dynamic_sex', 'swallow'
				else
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick', 1
					gs 'zz_dynamic_sex', 'anal_cum'
				end
				gs 'zz_render', '', '', func('shulga_room_strings', 'local_str80')
				act 'Уйти': gt 'shulga_room'
			end
		end
	end
}
!отказ от секса
$shulga_lern_sex_no = {
	*clr & cla
	minut += 2
	shulga_lern_day = daystart
	shulga_lern_count -= 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/lern/no.jpg', func('shulga_room_strings', 'local_str81')
	act 'Уйти': gt 'shulga_room'
}
!делаем уроки вместе с Васяном
$shulga_lern = {
	*clr & cla
	if school['homework'] ! 0:
		minut += 60
		school['homework'] = 0
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/lern/ev<<lern_imgset>>.jpg', func('shulga_room_strings', 'local_str82')
		act 'Передохнуть':
			dynamic $shulga_bazar_day
		end
	else
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/lern/ev<<lern_imgset>>_1.jpg', func('shulga_room_strings', 'local_str83')
		if func('zz_reputation','get') >=3:
			if vagina >=1:
				act 'Согласиться': dynamic $shulga_lern_sex_yes
			end
			if dom >=5:
				act 'Отказать': dynamic $shulga_lern_sex_no
			end
		else
			act 'Отказать': dynamic $shulga_lern_sex_no
			if vagina >=1:
				act 'Согласиться': dynamic $shulga_lern_sex_yes
			end
		end
	end
}
!--------------------------------------------------------------------
!разговоры с Васяном
$shulga_bazar_day = {
*clr & cla
minut += 1
gs 'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vasya.jpg', func('shulga_room_strings', 'local_str84')
dynamic $vasya_shulgin_rep
act 'Отойти': gt 'shulga_room'
	act 'Поговорить':
		*clr & cla
		minut += 10
		bazar_day = daystart
		bazar_count -= 1
		if bazar_count > 0: gs 'npc_editor','change_rep','+', 11
		gs'stat'
vasyan_textb_day = RAND(0,8)
			if vasyan_textb_day = 0:$vasyan_textb_day = 'Вы недолго беседуете на разные темы.'
			if vasyan_textb_day = 1:$vasyan_textb_day = 'Вы слушаете как <<$shulga_name_rnd>> рассказывает интересную историю.'
			if vasyan_textb_day = 2 and school['certificate'] = 0:$vasyan_textb_day = 'Вы беседуете о школе.'
			if vasyan_textb_day = 2 and school['certificate'] = 1:$vasyan_textb_day = 'Вы беседуете о жизни.'
			if vasyan_textb_day = 3:$vasyan_textb_day = '<<$shulga_name_rnd>> рассказывает как провёл день.'
			if vasyan_textb_day = 4:$vasyan_textb_day = '<<$shulga_name_rnd>> рассказывает смешную шутку.'
			if vasyan_textb_day = 5:$vasyan_textb_day = 'Рассказывает анекдот:<br>Весь Советский Союз смеялся над Вовочкой. А Вовочка вырос, стал президентом! И тебе один ржет над всей страной!'
			if vasyan_textb_day = 6:$vasyan_textb_day = 'Рассказывает анекдот:<br>— Вовочка, ты почему так мелко пишешь?<br>— Чтобы ошибки были не так заметны, Марь Иванна.'
			if vasyan_textb_day = 7:$vasyan_textb_day = 'Рассказывает анекдот:<br>Что у пьяной женщины на уме, то у трезвого мужчины вообще никогда не получится!!!'
			if vasyan_textb_day = 8 and $npc['11,relation'] < 30:$vasyan_textb = 'Вы беседуете минут десять на разные темы.'
			if vasyan_textb_day = 8 and $npc['11,relation'] >=30 and webcamera = 1:$vasyan_textb_day = 'Вы беседуете на разные темы.'
			if vasyan_textb_day = 8 and $npc['11,relation'] >=30 and $npc['11,relation'] <50 and webcamera = 0:$vasyan_textb_day = '<<$shulga_name_rnd>> говорит: - Тут тема новая появилась, можно нормально деньжат поднять в интернете: про вебкам-чаты слышала?"<br>- Нет, но интересно, рассказывай подробнее! - интересуетесь вы.<br>Васян продолжает: - Ну так вот: нужна вебкамера и компьютер. Регишься на вебкам-сайте и можешь транслировать себя через интернет на камеру, а всякие лохи платят за просмотр денежку.<br>И, говорят, - чем откровеннее шоу, - тем больше бабла можно заработать!<br>- Ну я не знаю, неправильно продавать своё тело - в сомнении мнётесь вы.<br>Вася парирует: - Да чего ты там себе выдумываешь - кому чего продавать то? Всего-то пару часиков перед камерой жопой повертеть - и можно нормально срубить денег! Это тебе не на дороге стоять, пиздой торговать.'
			if vasyan_textb_day = 8 and $npc['11,relation'] >=50 and $npc['11,relation'] < 70:$vasyan_textb_day = '<<$shulga_name_rnd>> Спрашивает: - Помнишь я тебе говорил про вебкам-чаты, ну там где бабло можно заработать, вертя жопой?"<br>- Ага, помню, - отвечаете вы.<br><<$shulga_name_rnd>> продолжает: - Я тут вебку недавно купил, чтобы по скайпу с пацанами базарить. Ты, если хочешь, - можешь пользоваться моим ноутом, мне не жалко.<br>- Спасибо, я подумаю... - чешете задумчиво голову вы.'
			if vasyan_textb_day = 8 and $npc['11,relation'] >=100:$vasyan_textb_day = '<<$shulga_name_rnd>> Спрашивает: - Чо как, вебкой пользовалась, вертела уже жопой в онлайн-чате?<br>- Тебе-то какое дело? - поднимаете бровь вы.<br><<$shulga_name_rnd>> продолжает разговор: - Ты, если что, по выходным можешь меня звать - вместе шоу будем делать: задроты больше денег заплатят, если увидят как тебя шпилят в онлайне"<br>- Идея неплохая, я подумаю, - говорите вы.'
dynamic $vasya_shulgin_rep
		if bazar_count <= 0:'<<$shulga_name_rnd>> отмахивается: - <<$sveta_rnd_name>>, ты утомила своими разговорами, отстань.'
		if bazar_count > 0: '<<$vasyan_textb_day>>'
		act 'Далее': dynamic $shulga_bazar_day
	end
	if shulga_lern_count > 0 and school['certificate'] = 0 and school['vacation'] = 0:
		act 'Делать уроки': dynamic $shulga_lern
	end
	if $npc['11,relation']>=70 and alko >= 1 and vagina >=1 or $npc['11,relation']>=70 and horny >= 30 and vagina >=1:
		act 'Предложить потрахаться':
		if shgopsex_vasya_count = 0:
			cla
			gs 'zz_render', '', '', func('shulga_room_strings', 'local_str85')
			act 'Уйти': gt'shulga_room'
		elseif shgopsex_vasya_count > 0:
			$gopsex_name_npc = 'Вася'
			$gopsex_n_npc = 1
			shgopsex_vasya_day = daystart
			shgopsex_vasya_count -= 1
			dynamic $shgopsex
		end
	end
end
}
!---------------------------------------!
!если разрешили спать рядом, тогда спим:!
!---------------------------------------!
$sleep_vasya_bed = {
	cla
	gs 'npc_editor','change_rep','+', 11
	if son < 20: son += 5
	minut += 180
	gs'stat'
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str86')
	act 'Встать': gt 'shulga_room'
}
!--------------------!
!отказать спать рядом!
!--------------------!
$sleep_vasya_otkaz = {
	cla
	minut += 2
	gs 'npc_editor','change_rep','-', 11
	gs 'stat'
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str87')
	act 'Уйти': gt 'shulga_room'
}
!---------------------!
!разрешить спать рядом!
!---------------------!
$sleep_vasya_soglasie = {
	cla
	minut += 2
	gs 'stat'
	gs 'zz_render', '', '', func('shulga_room_strings', 'local_str88')
	act 'Вздремнуть': dynamic $sleep_vasya_bed
		if $npc['11,relation']>=70:
			act 'Предложить потрахаться':
			if shgopsex_vasya_count = 0:
				cla
				gs 'zz_render', '', '', func('shulga_room_strings', 'local_str89')
				act 'Уйти': gt'shulga_room'
			elseif shgopsex_vasya_count > 0:
				$gopsex_name_npc = 'Вася'
				$gopsex_n_npc = 1
				shgopsex_vasya_day = daystart
				shgopsex_vasya_count -= 1
				dynamic $shgopsex
			end
		end
	end
}
!---------------------!
!-----Васька спит-----!
!---------------------!
$shulga_bazar_sleep = {
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vasya_sleep.jpg', func('shulga_room_strings', 'local_str90')
	act 'Уйти': gt 'shulga_room'
	act 'Разбудить':
		dynamic iif($npc['11,relation'] < 50, $sleep_vasya_otkaz, $sleep_vasya_soglasie)
	end
}