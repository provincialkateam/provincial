! load dynamics
view
gs 'dinSex'
!флаг стринга
skk_gym_load = 0
! проверка старых версий
if $settings['autosave'] = '': $settings['autosave'] = 1
if version < 115:
	$npc['48,name'] = 'Миша'
	$npc['48,surname'] = ''
	$npc['48,nickname'] = ''
	$npc['48,relation'] = 40
	$npc['48,group'] = 9
	$npc['48,dick'] = 18
	$npc['48,sex'] = 0
	$npc['48,silavag'] = 2
	$npc['48,know'] = 0
	npc_arrsize = 49
end
if version < 120:
	! выгружаем переменную окна предпросмотра
	killvar 'preview_win'
	! выгружаем старые менюшки
	killobj
	killvar 'rodtime'
	if pregtime > 0: pregnancy = pregtime
	killvar 'pregtime'
	killvar 'preg'
	money += stolmoney
	killvar 'stolIN'
	killvar 'stolOUT'
	killvar 'stolmoney'
	killvar 'moneySUM'
	!--- нпс с универа ---!
	! Айгуль
	$npc['49,name'] = 'Айгуль'
	$npc['49,surname'] = ''
	$npc['49,nickname'] = ''
	$npc['49,relation'] = 40
	$npc['49,group'] = 10
	$npc['49,dick'] = 0
	$npc['49,sex'] = 0
	$npc['49,know'] = 0
	$npc['49,mainQW'] = 0
	! Вероника
	$npc['50,name'] = 'Вероника'
	$npc['50,surname'] = ''
	$npc['50,nickname'] = 'Ника'
	$npc['50,relation'] = 40
	$npc['50,group'] = 10
	$npc['50,dick'] = 0
	$npc['50,sex'] = 0
	$npc['50,know'] = 0
	! Замена выпавшего НПС на Демаркуса
	$npc['47,name'] = 'Демаркус'
	$npc['47,surname'] = ''
	$npc['47,nickname'] = ''
	$npc['47,relation'] = 40
	$npc['47,group'] = 8
	$npc['47,dick'] = 25
	$npc['47,sex'] = 0
	$npc['47,know'] = 0
	! исправляем группу для школьного учителя
	if $npc['26,group'] ! 6: $npc['26,group'] = 6
	! применяем репутацию
	gs 'zz_reputation','recalc_gorslut'
end
if version < 122:
	! устанавливаем новые настройки
	if $settings['cheats'] = '': $settings['cheats'] = 0
	if $settings['autotampon'] = '': $settings['autotampon'] = 1
	if $settings['auto_wipes'] = '': $settings['auto_wipes'] = 1
	if $settings['mini_events'] = '': $settings['mini_events'] = 1
	if $settings['background_music'] = '': $settings['background_music'] = 0
	if $settings['show_map'] = '': $settings['show_map'] = 1
end
if version < 124:
	$npc['31,meet_day'] = tanya['park_meet_day']
	$npc['31,clean_day'] = tanya['clean_day']
	$npc['31,punish_day'] = tanya['punish_day']
	! Царев -> Князев
	$npc['7,name'] = 'Алексей'
	$npc['7,surname'] = 'Князев'
	$npc['7,nickname'] = 'Лошик'
	$npc['7,relation'] = 40
	$npc['7,group'] = 0
	$npc['7,dick'] = 21
	$npc['7,sex'] = 0
	$npc['7,silavag'] = 0
	$npc['7,know'] = 1
	killvar 'tanya'
	killvar 'before_h_girl'
	killvar 'before_h_guy'
	killvar 'husbdolg'
	killvar '$gopnik'
	killvar '$gopS'
	killvar 'SeriLust'
	killvar '$gopU'
	killvar 'UdmurtLust'
	killvar '$gopK'
	killvar 'KotilLust'
	killvar '$gopVi'
	killvar 'VitekLust'
	killvar 'VasanLust'
	killvar 'BerezaLust'
	killvar '$gopB'
	killvar '$gopV'
	killvar '$namgopsum'
	killvar '$namgop6'
	killvar '$namgop5'
	killvar '$namgop4'
	killvar '$namgop3'
	killvar '$namgop2'
	killvar '$namgop'
	killvar 'frotknow'
	killvar 'frotknowrand'
	killvar 'kavslutknow'
	killvar 'kavknowrand'
	killvar 'filmknow'
	killvar 'randmon'
	killvar 'pfknowrand'
	killvar 'gopdeath'
	killvar 'gopstop'
	killvar 'vsehsdaladay'
	killvar 'goprandwork'
	killvar 'gopota'
	killvar 'gnewQW'
	killvar 'gopdaydolg'
	killvar 'loh'
	killvar 'rosetka'
	killvar 'sipovka'
	killvar 'GLust'
	killvar 'gopopusday'
	killvar 'glavar'
	killvar 'opusk'
	killvar '$goptalk2'
	killvar 'gtalkrand'
	killvar '$goptalk'
	killvar 'serisex'
	killvar 'SeriTut'
	killvar 'udmurtsex'
	killvar 'UdmurtTut'
	killvar 'kostilsex'
	killvar 'KostilTut'
	killvar 'viteksex'
	killvar 'VitekTut'
	killvar 'berezasex'
	killvar 'BerezaTut'
	killvar '$guygop'
	killvar 'vasansex'
	killvar 'VasanTut'
	killvar '$gopsexboy1'
	killvar '$saunabrit'
	killvar 'clenerSauna2'
	killvar 'clenerSauna'
	killvar 'klientrand'
	killvar 'whorehour'
	killvar 'paymamka'
	killvar 'saunaWorkNow'
	killvar 'saunarand'
	killvar 'SaunaWhore'
	killvar 'saunaWorkKlient'
	killvar 'bordysh'
	killvar 'workDiskAtkPlayer'
	killvar 'workDolgDay'
	killvar 'konvert'
	killvar '$workbomzdi'
	killvar 'workDisk'
	killvar '$bomzstartqwestdi'
	killvar 'bomzQW'
	killvar 'BuSWworkEnd'
	killvar 'workDolg'
	killvar '$din_kotov_vann'
	killvar '$din_kotov_provod'
	killvar '$din_kotov_kom'
	killvar '$gvokzal_description'
	killvar 'furisex'
	killvar 'furibj'
	killvar 'trfatherQW'
	killvar 'fatherMishaCar'
	killvar '$askfather'
	killvar '$fatherMisha_end'
	killvar 'nroad'
	killvar '$mirabrother'
	killvar '$din_hanters_sex_anal_no'
	killvar 'klismaday'
	killvar 'Mira_enema'
	killvar 'swamp_enema'
	killvar 'dirty_dickA'
	killvar 'dirty_dickB'
	killvar 'dirty_dickC'
	killvar 'andrhantanal'
	killvar '$textsexhanter'
	killvar '$textsexhanter1'
	killvar 'shantpopala'
	killvar 'gerofotorand'
	killvar 'shantbog'
	killvar 'shantftbgrand'
	killvar 'fotsearchrand'
	killvar 'stripdolg'
	killvar 'minifoto'
	killvar 'shantfoto'
	killvar 'stripfotorand'
	killvar 'gor_dorm'
	killvar 'internetM'
	killvar 'balans'
	killvar 'zz_added'
	killvar 'nude'
	killvar 'clrbelo'
	killvar 'drybelo'
	killvar 'wetbelo'
	killvar 'dirtbelo'
	killvar 'newdress_timer'
	killvar 'newdress_id'
	killvar 'KFOnLineReaga'
	killvar 'running_day'
	killvar 'sportday'
	killvar 'obruchday'
	killvar 'skakday'
	killvar 'pressday'
	killvar 'pushday'
	!---
	! переход на новую одежду
	!---
	panties = 3 * 500
	for i = 0 to arrsize('$wardrobe')/10 - 1:
		if $wardrobe[i+"_"+'group'] > 1:
			_old_wardrobe[arrsize('_old_wardrobe')] = $wardrobe[i+"_"+'group']
		end
	end
	killvar '$clothing'
	killvar '$wardrobe'
	!--
	gs 'zz_clothing2','init'
	gs 'zz_clothing2','add_to_wardrobe',3
	gs 'zz_clothing2','add_to_wardrobe',4
	for i = 0 to arrsize('_old_wardrobe') - 1:
		_value[2] = rand(30,49)
		_value[3] = rand(10,29)
		_value[5] = rand(50,69)
		_value[7] = rand(90,109)
		_value[8] = rand(70,89)
		_value[9] = rand(70,89)
		_value[10] = rand(110,129)
		if _old_wardrobe[i] < 2 or _old_wardrobe[i] ! 4 or _old_wardrobe[i] ! 6 or _old_wardrobe[i] ! 11 or  _old_wardrobe[i] ! 12:
			gs 'zz_clothing2','add_to_wardrobe',_value[_old_wardrobe[i]]
		end
	end
	gs 'zz_clothing2','dispose'
	killvar '_value'
	killvar '_old_wardrobe'
	! одеваем ГГ
	cloth[0] = 0
	cloth[1] = tanga
	cloth[2] = 0
	cloth[3] = 0
	cloth[4] = 1
	cloth[5] = 0
	gs 'zz_clothing2','redress',3
	killvar 'tanga'
	killvar 'flag_tanga'
	killvar 'prev_clothing'
	killvar 'current_clothing'
end
! на старте чекиним контрольную точку
if $control_point = '': $control_point = 'gorodok'
! проверяем загрузку ачивок
gs 'zz_achievements','check_ach_array'
! устанавливаем счетчик
if $counter = '': $counter = 'counter'
! устанавливаем текущую версию
version = 124