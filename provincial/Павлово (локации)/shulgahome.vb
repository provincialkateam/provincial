!============================!
!----ХАТА СЕМЬИ ШУЛЬГИНЫХ----!
!============================!
!-----Настройки-----!
!===================!
$metka = $ARGS[0]
$loc = $CURLOC
$metka = $ARGS[0]
$loc = $CURLOC
!подгружаем динамику которая в "gopsex"
gs'gopsex'
!обращение к Сергею Шульгину
$serg_obr = iif($npc['36,relation'] < 30,'дядя','')
!кол-во ивентов может стартовать с нпс Соня в сутки
if sexev_sonya_day ! daystart: sexev_sonya_count = 1
!кол-во ивентов может стартовать с нпс Мама в сутки
if sexev_momgg_day ! daystart: sexev_momgg_count = 2
!кол-во эвентов ГГ с Соней:
if ev_sonya_day ! daystart: ev_sonya_count = 2
!кол-во раз можно поболтать с Соней в сутки
if sonya_bazar_day ! daystart: sonya_bazar_count = 5
!эвенты: пацаны пристают к гг в комнате или на кухне:
if gangsexroom_day ! daystart: gangsexroom_count = 1
!============================================================================================================!
!ВХОД В ХАТУ (ПРОПУСКНОЙ ПУНКТ)----------------------------------------------------------------------КОНТРОЛЬ!
!============================================================================================================!
gs 'stat'
if shulgahomemark = 0:
	gs 'zz_render', '', '', func('shulgahome_strings', 'local_str1')
	act 'Уйти':minut += 1 & gt'pod_ezd','etaj_3'
	!Будни:
	if week < 6 and hour >= 10 and hour < 16: gs 'zz_render', '', '','Никто не открыл дверь. Видимо никого нет дома.'
	if $npc['36,relation'] >=70 and week < 6 and hour >= 10 and hour < 16:gs 'zz_render', '', '', 'Но, у вас есть ключ который дал вам Сергей.' & act 'Открыть ключом':shulgahomemark = 1 & gt $curloc
	if week < 6 and hour >= 16 and hour <= 23: gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge2.jpg','Дверь открыл <<$serg_obr>> Сергей и сказал что сына нет дома.'
	if $npc['36,relation'] >=30 and week < 6 and hour >= 16 and hour <= 23: gs 'zz_render', '', '','Входи, будь как дома.' & act 'Войти':shulgahomemark = 1 & gt $curloc
	!Ночь (будни и выходные):
	if hour >= 0 and hour < 2: gs 'zz_render', '', '','Дверь открыл <<$shulga_name_rnd>> и пригласил войти.' & act 'Войти':shulgahomemark = 1 & gt $curloc
	if hour >= 2 and hour < 5: gs 'zz_render', '', '','Слишком позднее время для того, чтобы ходить в гости.'
	if $npc['36,relation'] >=70 and hour >= 2 and hour < 5: gs 'zz_render', '', '','Но у вас есть ключ, который дал вам Сергей' & act 'Открыть ключом':shulgahomemark = 1 & gt $curloc
	if hour >= 5 and hour < 10: gs 'zz_render', '', '','Слишком раннее время, чтобы ходить в гости.'
	if $npc['36,relation'] >=70 and hour >= 5 and hour < 10: gs 'zz_render', '', '','Но у вас есть ключ, который дал вам Сергей' & act 'Открыть ключом':shulgahomemark = 1 & gt $curloc
	!Выходные:
	if week >= 6 and hour >= 10 and hour < 16: gs 'zz_render', '', '','Дверь открыл <<$shulga_name_rnd>> и пригласил войти.' & act 'Войти':shulgahomemark = 1 & gt $curloc
	if week >= 6 and hour >= 16 and hour <= 23: gs 'zz_render', '','images/zsoft/pod_ezd/shulgahome/serge2.jpg','Дверь открыл <<$serg_obr>> Сергей и сказал что сына нет дома.'
	if $npc['36,relation'] >=30 and week >= 6 and hour >= 16 and hour <= 23: gs 'zz_render', '', '','Заходи, будь как дома.' & act 'Войти':shulgahomemark = 1 & gt $curloc
!end
!============================================================================================================!
!КОРИДОР----------------------------------ХАТА СЕМЬИ ШУЛЬГИНЫХ---------------------------------------ПРИХОЖАЯ!
!============================================================================================================!
else
	'<center><b><font color = maroon>Прихожая</font></b></center>'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/korr.jpg"></center>'
	!ивенты с матерью гг и отцом Шульги
	!Эвенты с мамкой гг:
	$shulga_home_momgg1 = {
		*clr & cla
		sexev_momgg_day = daystart
		sexev_momgg_count -= 1
		minut += 5
		horny += 5
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev1_1.jpg', func('shulgahome_strings', 'local_str2')
		dynamic $masturb_gg
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev1_2.jpg', func('shulgahome_strings', 'local_str3')
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev1_3_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str4')
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev1_4_'+rand(1,3)+'.jpg', func('shulgahome_strings', 'local_str5')
					dynamic $masturb_gg
					act 'Далее':
						*clr & cla
						minut += 5
						horny += 15
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev1_5.jpg', func('shulgahome_strings', 'local_str6')
						act 'Уйти': gt'shulgahome'
					end
				end
			end
		end
	}
	$shulga_home_momgg2 = {
		*clr & cla
		sexev_momgg_day = daystart
		sexev_momgg_count -= 1
		minut += 5
		horny += 5
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev2_1_'+rand(1,4)+'.jpg', func('shulgahome_strings', 'local_str7')
		dynamic $masturb_gg
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev2_2_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str8')
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev2_3_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str9')
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev2_4.jpg', func('shulgahome_strings', 'local_str10')
					act 'Уйти': gt'shulgahome'
				end
			end
		end
	}
	$shulga_home_momggbang = {
		*clr & cla
		sexev_momgg_day = daystart
		sexev_momgg_count -= 1
		minut += 5
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev3_1_'+rand(1,3)+'.jpg', func('shulgahome_strings', 'local_str11')
		dynamic $masturb_gg
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev3_2_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str12')
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs 'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev3_3.jpg', func('shulgahome_strings', 'local_str13')
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs 'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/momgg/ev3_4_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str14')
					act 'Уйти': gt'shulgahome'
				end
			end
		end
	}
	shulga_home_rnd = RAND(0,100)
	shd = 0
	if week < 6:
		if hour>=15 and hour<23:
			if shulga_home_rnd <= 3 and momslut >= 1 and sexev_momgg_count > 0:shd=1
			if shulga_home_rnd > 3 and shulga_home_rnd <= 6 and momslut >= 1 and sexev_momgg_count > 0:shd=2
			if shulga_home_rnd > 97 and momslut >= 1 and sexev_momgg_count > 0:shd=3
		end
	else
		if hour >= 10 and hour < 23:
			if shulga_home_rnd <= 3 and momslut >= 1 and sexev_momgg_count > 0: shd = 1
			if shulga_home_rnd > 3 and shulga_home_rnd <= 6 and momslut >= 1 and sexev_momgg_count > 0: shd = 2
			if shulga_home_rnd > 97 and momslut >= 1 and sexev_momgg_count > 0: shd = 3
		end
	end
	if shd = 1: gs 'zz_render', '', '','Вы услышали какие-то странные звуки из маленькой комнаты: <a href="exec: dynamic $shulga_home_momgg1">посмотреть</a>'
	if shd = 2: gs 'zz_render', '', '','Вы услышали какие-то звуки из маленькой комнаты: <a href="exec: dynamic $shulga_home_momgg2">посмотреть</a>'
	if shd = 3: gs 'zz_render', '', '','Вы услышали какие-то громкие чавкающие звуки из маленькой комнаты: <a href="exec: dynamic $shulga_home_momggbang">посмотреть</a>'
	act 'Идти в большую комнату': gt'shulga_room'
	act 'Идти в маленькую комнату': dynamic $shsroom
	act 'Идти в ванную':
		gt 'zz_bathroom', 'start'
		!Соня эвенты в ванной
		ev_sonya = RAND(0,100)
		if ev_sonya >= 90 and $npc['25,qwSoniaSlut'] => 2 and sh_sonya_sexev > 2 and sonya_bazar_count > 0 and ev_sonya_count > 0: dynamic $vanna_ev_sonya
		if ev_sonya <= 5 and $npc['25,qwSoniaSlut'] => 2 and $npc['36,relation']>=20 and sexev_sonya_count > 0 and week < 6 and hour >= 16 and hour <= 23 or ev_sonya <= 5 and $npc['25,qwSoniaSlut'] => 2 and $npc['36,relation']>=20 and sexev_sonya_count > 0 and week >= 6 and hour >= 10 and hour <= 23: dynamic $vanna_sexev_sonya
	end
	act 'Идти на кухню': dynamic $shkuh
	act 'Уйти': shulgahomemark = 0 & minut += 1 & gt 'pod_ezd', 'etaj_3'
end
!============================================================================================================!
!МАЛЕНЬКАЯ КОМНАТА (СПАЛЬНЯ РОДИТЕЛЕЙ ШУЛЬГИ)------------------------------------ ----------МАЛЕНЬКАЯ КОМНАТА!
!============================================================================================================!
!Маленькая комната Соня эвент:
$smroom_sex_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 5
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/sonya/ev1_1_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str15')
	dynamic $masturb_gg
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/sonya/ev1_2_'+rand(1,3)+'.jpg', func('shulgahome_strings', 'local_str16')
		dynamic $masturb_gg
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/sonya/ev1_3_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str17')
			dynamic $masturb_gg
			act 'Уйти': gt'shulgahome'
		end
	end
}
!маленькая комната
$shsroom = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', 'Спальня отца Шульги', 'images/zsoft/pod_ezd/shulgahome/smroom.jpg', func('shulgahome_strings', 'local_str18')
	if hour < 7 or hour >= 23:gs 'zz_render', '', '', 'На кровати спит <<$serg_obr>> <a href="exec:GT ''Serge_Shulgin'',''serge_razbud''">Сергей</a>.'
	if week < 6:
		if hour >= 16 and hour < 18 or hour >= 21 and hour < 23:gs 'zz_render', '', '', 'На кровати лежит <<$serg_obr>> <a href="exec:GT ''serge_razgovor_tv''">Сергей</a> и смотрит телевизор.'
	else
		if hour >= 7 and hour < 18 or hour >= 21 and hour < 23:gs 'zz_render', '', '', 'На кровати лежит <<$serg_obr>> <a href="exec:GT ''serge_razgovor_tv''">Сергей</a> и смотрит телевизор.'
	end
	act 'Выйти из комнаты': gt'shulgahome'
	if week < 6 and hour >= 7 and hour < 16: dynamic $smroom_sleep
	if RAND(0,100) <= 5 and $npc['25,qwSoniaSlut'] => 1 and sexev_sonya_count > 0 and hour >= 15 and hour <= 23: dynamic $smroom_sex_sonya
}
!спать если кровать пуста
$smroom_sleep = {
	act 'Прилечь на кровать вздремнуть':
	*clr & cla
	if son < 22: son += 2
	health += 5
	minut += 60
	gs 'stat'
	gs 'zz_render', '', '', func('shulgahome_strings', 'local_str19')
	act 'Встать': dynamic $shsroom
	end
}
!============================================================================================================!
!ВАННА--------------------------------------------ВАННА-------------------------------------------------ВАННА!
!============================================================================================================!
!ГГ и Соня вместе ублажают Сергея:
$gg_sonya_serg_sex = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 15
	if $npc['25,sex'] = 0: $npc['25,sex'] = 1 & girl += 1
	if serge_countsex < 1: guy += 1
	lesbian += 1
	bj +=1
	throat += 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/gr/ev1_1_'+rand(1,5)+'.jpg', func('shulgahome_strings', 'local_str20')
	act 'Далее':
		*clr & cla
		minut += 5
		sex += 1
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/gr/ev1_2_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str21')
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/gr/ev1_3_'+rand(1,4)+'.jpg', func('shulgahome_strings', 'local_str22')
			if horny >=70:
				orgasm += 1
				horny = 0
				mastr +=1
				manna += 35
				minut += 5
				gs 'zz_render', '', '', func('shulgahome_strings', 'local_str23')
			end
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 10
				swallow += 1
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/gr/ev1_4_'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str24')
				act 'Уйти': gt'shulgahome'
			end
		end
	end
}
!Ванная, Соня выбор эвента:
$vanna_sexev_sonya = {
	if RAND(0,100) < 50:
		dynamic $vanna_sexev1_sonya
	else
		dynamic $vanna_sexev2_sonya
	end
}
!Ванна Соня эвент 1:
$vanna_sexev1_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/bj'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str25')
	act 'Не мешать': gt'shulgahome'
}
!Ванна, Соня эвент 2:
$vanna_sexev2_sonya = {
	*clr & cla
	minut += 5
	sexev_sonya_day = daystart
	sexev_sonya_count -= 1
	sh_sonya_sexev +=1
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev2_1'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str26')
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev2_2'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str27')
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev2_3'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str28')
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev2_4'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str29')
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev2_5'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str30')
					dynamic $masturb_gg
					gs 'zz_render', '', '', func('shulgahome_strings', 'local_str31')
					act 'Уйти': gt'shulgahome'
				end
			end
		end
	end
}
!Болтовня с Соней, если спалили её секс пару раз на этой хате.
$vanna_bazar_sonya = {
	*clr & cla
	ev_sonya_day = daystart
	ev_sonya_count -= 1
	sonya_bazar_day = daystart
	sonya_bazar_count -= 1
	sh_sonya_bazar +=1
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/b.jpg', func('shulgahome_strings', 'local_str32')
	sonya_textb_vanna = RAND(1,7)
		if sonya_textb_vanna = 1:$sonya_textb_vanna = 'Вы не долго беседуете на разные темы.'
		if sonya_textb_vanna = 2 and school['certificate'] = 0:$sonya_textb_vanna	= 'Вы распрашиваете про успеваемость в школе, Сонька рассказывает: -"Если найти подход к учителю, то оценки будут положительные без всяких усилий и домашних заданий!"'
		if sonya_textb_vanna = 2 and school['certificate'] = 1:$sonya_textb_vanna	= 'Вы спрашиваете про работу, Сонька отмахивается и говорит: -"В наше время с работой плохо, ты же знаешь! Верчусь-кручусь, то там помогут, то тут помогут, так что денег на жизнь мне хватает"'
		if sonya_textb_vanna = 3:$sonya_textb_vanna = 'Вы спрашиваете частенько ли она к Сергею заходит, Соня честно отвечает: -"Ну пару раз в недельку захожу, иногда чаще, иногда реже как денежка нужна, так подлизываюсь, ты же вроде не дура, знаешь мои методы. Это Пацаны вечно без денег, а вот взрослые дядьки никогда не обижают, плюс еще удовольствие получаю."'
		if sonya_textb_vanna = 4:$sonya_textb_vanna = 'Сонька рассказывает о своих похождениях.'
		if sonya_textb_vanna = 5:$sonya_textb_vanna = 'Соня рассказывает интересную историю.'
		if sonya_textb_vanna = 6:$sonya_textb_vanna = 'Вы болтаете о том, кто как провел день.'
		if sonya_textb_vanna = 7:$sonya_textb_vanna = 'Вы с Сонькой делитесь разными новостями и сплетнями.'
	gs 'zz_render', '', '', func('shulgahome_strings', 'local_str33')
	if sonya_bazar_count = 0: gs 'zz_render', '', '','Извини <<$gop_name_gg>>, мне уже пора уходить, в следующий раз поболтаем.'
	if sonya_bazar_count > 0: act 'Еще поболтать': dynamic $vanna_bazar_sonya
	if sh_sonya_bazar > 5 and mesec <=0: act 'Предложить принять ванну': dynamic $vanna_sonya_lesb
	if sh_sonya_bazar >= 25 and $npc['36,relation'] >= 50 and sonya_bazar_count >= 1 and vagina >=1:
		act 'Предложить Соне вместе трахнуть Сергея': dynamic $gg_sonya_serg_sex
	end
	act 'Уйти': gt'shulgahome'
}
$vanna_ev_sonya = {
	if ($npc['25,qwSoniaSlut'] => 1 and week < 6 and hour >= 16 and hour <= 23) or ($npc['25,qwSoniaSlut'] => 1 and week >= 6 and hour >= 10 and hour <= 23):
		if RAND(0,100) <= 80:
			dynamic $vanna_ev1_sonya
		else
			dynamic $vanna_ev2_sonya
		end
	end
}
!гг и Соня принимают ванну
$vanna_sonya_lesb = {
	*clr & cla
	minut += 5
	lesbian += 1
	girl += 1
	mop = 1
	sweat = -3
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev1_1.jpg', func('shulgahome_strings', 'local_str34')
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev1_2'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str35')
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev1_3'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str36')
			act 'Далее':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/ev1_4'+rand(1,3)+'.jpg', func('shulgahome_strings', 'local_str37')
				if horny >=70:
					orgasm += 1
					horny = 0
					manna += 35
					gs 'zz_render', '', '', func('shulgahome_strings', 'local_str38')
				end
				gs 'zz_render', '', '', func('shulgahome_strings', 'local_str39')
				act 'Уйти': gt'shulgahome'
			end
		end
	end
}
!Соня наводит марафет
$vanna_ev1_sonya = {
	*clr & cla
	minut += 2
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/m.jpg', func('shulgahome_strings', 'local_str40')
	act 'Поболтать': dynamic $vanna_bazar_sonya
	if sh_sonya_bazar > 5:
		act 'Предложить принять ванну': dynamic $vanna_sonya_lesb
	end
	if sh_sonya_bazar >= 25 and $npc['36,relation'] >= 50:
		act 'Предложить Соне вместе трахнуть Сергея': dynamic $gg_sonya_serg_sex
	end
	act 'Уйти': gt'shulgahome'
}
!Сонька сидит на толчке
$vanna_ev2_sonya = {
	*clr & cla
	minut += 2
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vanna/sonya/m.jpg', func('shulgahome_strings', 'local_str41')
	act 'Уйти': gt'shulgahome'
}
!============================================================================================================!
!КУХНЯ--------------------------------------------------------------------------------------------------КУХНЯ!
!============================================================================================================!
!Ивент на кухне с гопотой:
$gang_sex_ev1 = {
	*clr & cla
	minut += 2
	gangsexroom_day = daystart
	gangsexroom_count -= 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang1.jpg', func('shulgahome_strings', 'local_str42')
	act 'Далее':
		*clr & cla
		minut += 3
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang2.jpg', func('shulgahome_strings', 'local_str43')
		act 'Далее':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang3.jpg', func('shulgahome_strings', 'local_str44')
			act 'Далее':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang4.jpg', func('shulgahome_strings', 'local_str45')
				act 'Далее':
					*clr & cla
					minut += 10
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang5.jpg', func('shulgahome_strings', 'local_str46')
					act 'Далее':
						*clr & cla
						minut += 10
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang6.jpg', func('shulgahome_strings', 'local_str47')
						act 'Далее':
							*clr & cla
							minut += 10
							gs'stat'
							gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang7.jpg', func('shulgahome_strings', 'local_str48')
							if horny >=70:
								orgasm += 1
								horny = 0
								gs 'zz_render', '', '', func('shulgahome_strings', 'local_str49')
							end
							act 'Далее':
								*clr & cla
								minut += 10
								gs'stat'
								gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/gang8.jpg', func('shulgahome_strings', 'local_str50')
								act 'Уйти': dynamic $shkuh
							end
						end
					end
				end
			end
		end
	end
}
!---------------!
!-----Кухня-----!
!---------------!
$shkuh = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', 'Кухня', 'images/zsoft/pod_ezd/shulgahome/kuh.jpg'
	if hour >= 18 and hour < 21:
		rand_serg_buh=rand(1,100)
		if rand_serg_buh < 10:gs 'zz_render', '', '','На кухне сидит за столом <<$serg_obr>> <a href="exec:gt ''Serge_kuh'',''kuh_buh''">Сергей</a> и пьет водку.'
		if rand_serg_buh >= 10:gs 'zz_render', '', '','На кухне готовит еду <<$serg_obr>> <a href="exec:gt ''Serge_kuh''">Сергей</a>.'
	end
	act 'Выйти из кухни': gt'shulgahome'
	act 'Заглянуть в холодильник': dynamic $holodil
	act 'Выпить стакан воды':
		*clr & cla
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/voda.jpg'
		gs 'zz_kitchen_acts', 'drink', 'water'
		gs 'stat'
		act 'Далее': dynamic $shkuh
	end
	!старт ивента с гопотой на кухне
	if RAND(0,100) <= 5 and func('zz_reputation','get') >=3 and gangsexroom_count > 0 and week < 6 and hour >= 0 and hour < 3:
		dynamic $gang_sex_ev1
	end
}
!===========!
!ХОЛОДИЛЬНИК!
!-----------!
!наполнение холодильника:
!кол-во бутылок пива в сутки
if beer_day ! daystart: beer_count = 2
!кол-во рюмок в бутылке водки
if vodka_day ! daystart: vodka_count = 3
!кол-во тарелок в кострюле супа
if sup_day ! daystart: sup_count = 2
!открываем холодильник:
$holodil = {
	*clr & cla
	minut += 1
	gs 'stat'
	if beer_count = 2:$r_beer = '2 бутылки пива,'
	if beer_count = 1:$r_beer = '1 бутылка пива,'
	if beer_count = 0:$r_beer = ''
	if vodka_count = 3:$r_vodka = 'полную бутылку водки,'
	if vodka_count = 2:$r_vodka = 'наполовину пустую бутылку водки,'
	if vodka_count = 1:$r_vodka = 'почти пустую бутылку водки,'
	if vodka_count = 0:$r_vodka = ''
	if sup_count >= 1:$r_sup = 'большую кастрюлю с супом'
	if sup_count = 0:$r_sup = ''
	gs 'zz_render', '', 'zsoft/pod_ezd/shulgahome/kuh/holod'+iif(beer_count = 0 and vodka_count = 0 and sup_count = 0,'pusto',rand(1,3)), func('shulgahome_strings', 'local_str51')
	!пьем пиво
	if beer_count > 0:
		act 'Выпить пива':
			*clr & cla
			gs 'zz_funcs', 'alko'
			beer_day = daystart
			beer_count -= 1
			gs 'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/beer'+rand(1,3)+'.jpg', func('shulgahome_strings', 'local_str52')
			act 'Далее': dynamic $holodil
		end
	end
	!пьем водку
	if vodka_count > 0:
		act 'Выпить водки':
			*clr & cla
			gs 'zz_funcs', 'alko',2
			vodka_day = daystart
			vodka_count -= 1
			gs 'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/vodka'+rand(1,2)+'.jpg', func('shulgahome_strings', 'local_str53')
			act 'Убрать бутыль': dynamic $holodil
			act 'Еще жахнуть':
				if vodka_count = 0: gs 'zz_render', '', '','<font color = red>Больше водки нет</font>'
				if vodka_count > 0:
					gs 'zz_funcs', 'alko',2
					vodka_day = daystart
					vodka_count -= 1
					gs 'stat'
					gs 'zz_render', '', '', func('shulgahome_strings', 'local_str54')
				end
			end
		end
	end
	!хаваем суп
	if sup_count > 0:
		act 'Съесть тарелку супа':
			*clr & cla
			minut += 5
			sup_day = daystart
			sup_count -= 1
			gs 'zz_kitchen_acts', 'eat'
			gs 'stat'
			act 'Далее': dynamic $holodil
		end
	end
	act 'Закрыть холодильник': dynamic $shkuh
}