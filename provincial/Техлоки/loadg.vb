! load dynamics
view
gs 'din2'
gs 'dinSex'
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
elseif version < 120:
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
end
! исправляем группу для школьного учителя
if $npc['26,group'] ! 6: $npc['26,group'] = 6
$settings['cheats'] = 1
$settings['wardrobe_thumbnail_size'] = 0
$settings['autotampon'] = 1
$settings['auto_wipes'] = 1
! переход на новую репутацию
! на старте чекиним контрольную точку
if $control_point = '': $control_point = 'gorodok'
! применяем репутацию
gs 'zz_reputation','recalc_gorslut'
!---
gs 'zz_achievements','check_ach_array'
! устанавливаем текущую версию
version = 120