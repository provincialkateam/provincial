if $ARGS[0] = 'firsttime':
	*clr & cla
	JenyaLCfirst = 1
	gs 'stat'
	gs 'zz_render', '', 'images/LakeCafe/LakeFirstTime.jpg', func('LCporn_strings', 'local_str1')
	act 'Продолжить':
		*clr & cla
		$npc['30,sex'] += 1
		gs 'npc_editor','change_rep','+', 30
		minut += 40
		$boy = 'Женя'
		dick = 17
		silavag = 1
		pose = 1
		gs 'stat'
		gs 'zz_render', '', 'images/LakeCafe/RandSex1/'+RAND(1,7)+'.jpg', func('LCporn_strings', 'local_str2')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Выйти':gt'Lakecafe','main'
	end
	act 'Убежать':
		*clr & cla
		gs 'npc_editor','change_rep','-', 30
		minut += 7
		gs'stat'
		gs 'zz_render', '', '', func('LCporn_strings', 'local_str3')
		act '...':gt'nord'
	end
end
if $ARGS[0] = 'sex':
	*clr & cla
	gs 'zz_render', '', 'images/LakeCafe/LakeFirstTime.jpg', func('LCporn_strings', 'local_str4')
	act 'Вагинальный':
		*clr & cla
		$npc['30,sex'] += 1
		gs 'npc_editor','change_rep','+', 30
		minut += 40
		$boy = 'Женя'
		dick = 17
		silavag = 1
		pose = 1
		gs 'zz_render', '', 'images/LakeCafe/RandSex1/'+RAND(1,7)+'.jpg', func('LCporn_strings', 'local_str5')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		gs 'stat'
		act 'Выйти':gt'Lakecafe','main'
	end
	act 'Оральный':
		*clr & cla
		bj += 1
		$npc['30,sex'] += 1
		gs 'npc_editor','change_rep','+', 30
		minut += 20
		gs 'zz_funcs', 'cum', 'face'
		minut += 40
		$boy = 'Женя'
		gs 'zz_render', '', 'images/LakeCafe/RandSex1/'+RAND(1,7)+'.jpg', func('LCporn_strings', 'local_str6')
		gs 'stat'
		act 'Выйти': gt'Lakecafe','main'
	end
end
if $ARGS[0] = 'toiletsex':
	*clr & cla
	gs 'stat'
	dick = 14
	hj += 1
	$boy = 'Мужик'
	gs 'zz_render', '', '', func('LCporn_strings', 'local_str7')
	act 'На колени':
		*clr & cla
		gs 'zz_render','','common/sex/hj/'+rand(0,1)+'.gif', func('LCporn_strings', 'local_str8')
		act 'Сосать':
			*clr & cla
			minut += 10
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/nigma/city/street0,'+rand(0,2)+'.jpg', func('LCporn_strings', 'local_str9')
			act 'Сосать глотая сперму':
				*clr & cla
				swallow += 1
				water -= 10
				minut += 10
				gs 'stat'
				gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif', func('LCporn_strings', 'local_str10')
				act 'Уйти':gt'laketoilet','main'
			end
			act 'Вынуть изо рта':
				*clr & cla
				gs 'zz_funcs', 'cum', 'face'
				minut += 10
				gs 'stat'
				gs 'zz_render', '','common/sex/bj_cum/'+rand(0,4)+'.gif', func('LCporn_strings', 'local_str11')
				act 'Уйти':gt'laketoilet','main'
			end
		end
	end
	act 'Дать ему':
		*clr & cla
		minut += 20
		horny += 20
		pose = 1
		gs 'stat'
		gs 'zz_render','','images/nigma/city/street1,'+rand(0,3)+'.gif'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Уйти':gt'laketoilet','main'
	end
end