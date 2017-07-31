!============================================================================================================!
!Отец Василия Шульгина (Шульги)------------------------------------------------------------------------------!
!ФИО: Шульгин Сергей Борисович-------------------------------------------------------------------------------!
!------------------------------------------------------------------------------------------------------------!
!$npc['36,relation'] - счетчик отношения:--------------------------------------------------------------------------!
! < 40 - знакомый (открыта только болтовня)------------------------------------------------------------------!
! > 60 - близкий друг (секс)---------------------------------------------------------------------------------!
! > 80 - очень близкий друг (много разнообразного секса)----------------------------------------------------!
! >=100 - Сергей дает ключ от квартиры (можно в любое время попасть в хату)----------------------------------!
!============================================================================================================!
$serge_shulgin_rep = {
	if $npc['36,relation']<20:'Вы Сергея Борисовича почти не знаете'
	if $npc['36,relation']>=20 and $npc['36,relation']<40:'У вас с Сергеем Борисовичем напряжённые отношения'
	if $npc['36,relation']>=40 and $npc['36,relation']<60:'У вас с Сергеем Борисовичем нормальные отношения'
	if $npc['36,relation']>=60 and $npc['36,relation']<80:'У вас с Сергеем дружеские отношения'
	if $npc['36,relation']>=80:'У вас с Серёжей отличные отношения'
}
$serg_bazar_rep = {
	if $npc['36,relation']<40:'Вы присели рядом на стул.'
	if $npc['36,relation']>=40:'Вы легли рядом на кровать.'
}
!-------------------------------------------------------------------------------------------------------------------!
!СОН с 23 до 7, если отношения>60 можно попроситься в кровать, спать...отношения>80 можно заигрывать, секс----------!
!===================================================================================================================!
clr
if serge_sleep_sex_day ! daystart: serge_sleep_sex_count = 2
gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/sleep.jpg', func('Serge_Shulgin_strings', 'local_str1')
act 'Уйти': dynamic $shsroom
act 'Разбудить':
	dynamic iif($npc['36,relation'] < 60, $sleep_serge_otkaz, $sleep_serge_soglasie)
end
!--------------------!
!отказать спать рядом!
!--------------------!
$sleep_serge_otkaz = {
	cla
	minut += 2
	gs 'npc_editor','change_rep','-', 36
	gs'stat'
	gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str2')
	act 'Уйти': dynamic $shsroom
}
!---------------------!
!разрешить спать рядом!
!---------------------!
$sleep_serge_soglasie = {
		cla
		minut += 2
		gs'stat'
		gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str3')
		act 'Вздремнуть': dynamic $sleep_serge_bed
		if $npc['36,relation'] >= 60 and mesec <= 0: act 'Приставать': dynamic $sleep_prstsex
!end
}
!---------------------------------------!
!если разрешили спать рядом, тогда спим:!
!---------------------------------------!
$sleep_serge_bed = {
	cla
	gs 'npc_editor','change_rep','+', 36
	if son < 20: son +=5
	minut += 180
	gs'stat'
	gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str4')
	act 'Встать': dynamic $shsroom
}
!---------------------------------------------------------------!
!приставашки к Сергею и если отношение>70 можно намекать на секс!
!---------------------------------------------------------------!
$sleep_prstsex = {
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/vert/dr'+rand(1,6)+'.gif', func('Serge_Shulgin_strings', 'local_str5')
	randnamek = rand(1,100)
	if $npc['36,relation'] < 80: dynamic $sleep_nameksex_otkaz
	if serge_sleep_sex_count > 0 and $npc['36,relation'] >=80 and randnamek<80: dynamic $sleep_nameksex_oral
	if serge_sleep_sex_count > 0 and $npc['36,relation'] >=80 and randnamek>=80 and randnamek<=90: dynamic $sleep_nameksex_rought
	if serge_sleep_sex_count > 0 and $npc['36,relation'] >=80 and randnamek>90: dynamic $sleep_nameksex_lick
	if serge_sleep_sex_count <= 0 and $npc['36,relation'] >=80: dynamic $serge_sleep_sex_perebor
}
!-------------------------------------------------------------------------!
!если отношение<70, Сергей не обращает внимания на приставание, отказывает!
!-------------------------------------------------------------------------!
$sleep_nameksex_otkaz = {
	act 'Далее':
		cla
		minut += 2
		gs'stat'
		gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str6')
		act 'Уйти': dynamic $shsroom
	end
}
!----------------------------------------------------------------!
!если сегодня уже был секс пару раз, Сергей отказывается от секса!
!----------------------------------------------------------------!
$serge_sleep_sex_perebor = {
	act 'Далее':
		cla
		minut += 2
		gs'stat'
	gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str7')
	act 'Уйти': dynamic $shsroom
	end
}
!--------------------!
!намекаем на пососать!
!--------------------!
$sleep_nameksex_oral = {
	act 'Намекнуть на секс':
		*clr & cla
		serge_sleep_sex_day = daystart
		serge_sleep_sex_count -= 1
		minut += 2
		$npc['36,sex'] += 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/vert/pr1.gif', func('Serge_Shulgin_strings', 'local_str8')
		$sleep_sex_oral_event = $sleep_sex_oral_event[rand(1,3)]
		act 'Далее': dynamic $sleep_sex_oral_event
	end
}
$sleep_nameksex_rought = {
	act 'Намекнуть на секс':
		*clr & cla
		serge_sleep_sex_day = daystart
		serge_sleep_sex_count -= 1
		minut += 2
		$npc['36,sex'] += 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/vert/pr1.gif', func('Serge_Shulgin_strings', 'local_str9')
		$sleep_sex_rought_event = $sleep_sex_rought_event[rand(1,2)]
		act 'Далее': dynamic $sleep_sex_rought_event
	end
}
!--------------------!
!намекаем на полизать!
!--------------------!
$sleep_nameksex_lick = {
	act 'Намекнуть на секс':
	*clr & cla
	serge_sleep_sex_day = daystart
	serge_sleep_sex_count -= 1
	minut += 2
	$npc['36,sex'] += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/vert/pr2.gif', func('Serge_Shulgin_strings', 'local_str10')
	!sleep_sex_lick_event = RAND(0,2)
	!	if sleep_sex_lick_event = 0:$sleep_sex_lick_event = '$sleep_sex_lick_event1'
	!	if sleep_sex_lick_event = 1:$sleep_sex_lick_event = '$sleep_sex_lick_event2'
	!	if sleep_sex_lick_event = 2:$sleep_sex_lick_event = '$sleep_sex_lick_event3'
		act 'Далее': dynamic $sleep_sex_lick_event1
	end
}
!-----------------------------!
!ивенты если намекали на отсос!
!-----------------------------!
$sleep_sex_oral_event[1] = {
	*clr & cla
	minut += 5
	bj += 1
	horny += 15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/oral'+rand(6,10)+'.gif', func('Serge_Shulgin_strings', 'local_str11')
	act 'Далее':
		*clr & cla
		minut += 5
		sex += 1
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/dog'+rand(1,11)+'.gif', func('Serge_Shulgin_strings', 'local_str12')
		dynamic $gg_devst_deflor
		gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str13')
		dynamic $gg_sex_orgasm
			act 'Далее':
			*clr & cla
			minut += 5
			anal +=1
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cow8.gif', func('Serge_Shulgin_strings', 'local_str14')
			dynamic $gg_sex_orgasm
				act 'Далее':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'face'
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cum'+rand(1,6)+'.gif', func('Serge_Shulgin_strings', 'local_str15')
			act 'Уйти': dynamic $shsroom
		end
	end
end
}
$sleep_sex_oral_event[2] = {
	*clr & cla
	minut += 5
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/oral'+rand(1,10)+'.gif', func('Serge_Shulgin_strings', 'local_str16')
	act 'Далее':
		*clr & cla
		minut += 5
		sex += 1
		horny += 15
		gs'stat'
		'<center><img src="images/zsoft/pod_ezd/shulgahome/smroom/event/miss'+rand(1,3)+'.gif"></center>'
		dynamic $gg_devst_deflor
		gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str17')
		dynamic $gg_sex_orgasm
			act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/dog'+rand(1,11)+'.gif', func('Serge_Shulgin_strings', 'local_str18')
			dynamic $gg_sex_orgasm
				act 'Далее':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'face'
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cum'+rand(1,6)+'.gif', func('Serge_Shulgin_strings', 'local_str19')
			act 'Уйти': dynamic $shsroom
		end
	end
end
}
$sleep_sex_oral_event[3] = {
	*clr & cla
	minut += 5
	horny += 15
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/69-'+rand(1,2)+'.gif', func('Serge_Shulgin_strings', 'local_str20')
	act 'Далее':
		*clr & cla
		minut += 5
		sex += 1
		anal +=1
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/dog'+rand(10,12)+'.gif', func('Serge_Shulgin_strings', 'local_str21')
		dynamic $gg_sex_orgasm
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/miss'+rand(1,3)+'.gif', func('Serge_Shulgin_strings', 'local_str22')
		dynamic $gg_sex_orgasm
			act 'Далее':
			*clr & cla
			minut += 5
			orgasm += 1
			horny = 0
			manna = 100
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cow'+rand(4,6)+'.gif', func('Serge_Shulgin_strings', 'local_str23')
			dynamic $gg_sex_orgasm
				act 'Далее':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cum'+rand(1,6)+'.gif', func('Serge_Shulgin_strings', 'local_str24')
			act 'Уйти': dynamic $shsroom
			end
		end
	end
end
}
!--------------------------------!
!эвенты если намекали на полизать!
!--------------------------------!
$sleep_sex_lick_event1 = {
	*clr & cla
	minut += 5
	horny += 45
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/lick'+rand(1,2)+'.gif', func('Serge_Shulgin_strings', 'local_str25')
	act 'Далее':
		*clr & cla
		minut += 5
		bj += 1
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/oral'+rand(1,10)+'.gif', func('Serge_Shulgin_strings', 'local_str26')
			act 'Далее':
			*clr & cla
			minut += 5
			sex += 1
			orgasm += 1
			horny = 0
			manna = 100
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/dog'+rand(1,11)+'.gif', func('Serge_Shulgin_strings', 'local_str27')
			dynamic $gg_devst_deflor
			gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str28')
				act 'Далее':
				*clr & cla
				minut += 5
				horny += 15
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/miss'+rand(1,3)+'.gif', func('Serge_Shulgin_strings', 'local_str29')
					act 'Далее':
					*clr & cla
					minut += 5
					horny += 15
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cow'+rand(1,7)+'.gif', func('Serge_Shulgin_strings', 'local_str30')
						act 'Далее':
						*clr & cla
						minut += 5
						gs 'zz_funcs', 'cum', 'face'
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cum'+rand(1,7)+'.gif', func('Serge_Shulgin_strings', 'local_str31')
					act 'Уйти': dynamic $shsroom
				end
			end
		end
	end
end
}
!----------------------!
!эвенты с грубым сексом!
!----------------------!
$sleep_sex_rought_event[1] = {
	*clr & cla
	minut += 5
	horny += 5
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/rought/oral'+rand(1,10)+'.gif', func('Serge_Shulgin_strings', 'local_str32')
	act 'Далее':
		*clr & cla
		minut += 5
		horny += 15
		sex += 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/rought/dog'+rand(1,12)+'.gif', func('Serge_Shulgin_strings', 'local_str33')
		dynamic $gg_devst_deflor
		gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str34')
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/rought/miss'+rand(1,4)+'.gif', func('Serge_Shulgin_strings', 'local_str35')
			dynamic $gg_sex_orgasm
			act 'Далее':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'face'
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cum'+rand(1,6)+'.gif', func('Serge_Shulgin_strings', 'local_str36')
				act 'Уйти': dynamic $shsroom
		end
	end
end
}
$sleep_sex_rought_event[2] = {
	*clr & cla
	minut += 5
	bj += 1
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/rought/oral'+rand(1,10)+'.gif', func('Serge_Shulgin_strings', 'local_str37')
	act 'Далее':
		*clr & cla
		minut += 5
		sex += 1
		horny += 15
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/rought/miss'+rand(1,4)+'.gif', func('Serge_Shulgin_strings', 'local_str38')
		dynamic $gg_devst_deflor
		gs 'zz_render', '', '', func('Serge_Shulgin_strings', 'local_str39')
		dynamic $gg_sex_orgasm
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/rought/dog'+rand(1,12)+'.gif', func('Serge_Shulgin_strings', 'local_str40')
			dynamic $gg_sex_orgasm
			act 'Далее':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'face'
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/smroom/event/cum'+rand(1,7)+'.gif', func('Serge_Shulgin_strings', 'local_str41')
				act 'Уйти': dynamic $shsroom
		end
	end
end
}