!---
! Моддинг
! $mods['<<i>>,name'] - название стартовой локации мода, необходимое для проверки локаций мода
! $mods['<<i>>,init'] - статус мода - включен/выключен
! опционально:
! $mods['<<i>>,dispose'] - имя локации-обработчика выгрузки мода
! $mods['<<i>>,settings'] - имя локации настроек
!---
! формируем табличку модов
if $args[0] = 'mod_list':
	! шапка
	$_mod_table = '<tr bgcolor=#bbee77><th width=100>#</th><th width=200>Статус</th><th width=300>Стартовая локация</th><th width=200>...</th>'
	_mod_id = 0
	! строки модов
	if arrsize('$mods') > 0:
		:loop_make_list
		$_mod_table += '<tr bgcolor='+iif(_mod_id mod 2 = 0,'#f3f4ee','#ffffff')+'>'
			$_mod_table += '<td><<_mod_id+1>></td>'
			$_mod_table += '<td><a href="exec:gs''mod_init'',''set_mod'',<<_mod_id>>,'+iif($mods['<<_mod_id>>,init']=0,1,0)+'">' + iif($mods['<<_mod_id>>,init']=0,'Выключен','Включен') + '</a></td>'
			$_mod_table += '<td>' + $mods['<<_mod_id>>,name'] + '</td>'
			$_mod_table += '<td>' + iif($mods['<<_mod_id>>,settings']='','','<a href="exec:gt''<<$mods[''<<_mod_id>>,settings'']>>''">Настройки</a>') + '</td>'
		$_mod_table += '</tr>'
		_mod_id += 1
		if _mod_id < arrsize('$mods')/4: jump 'loop_make_list'
		gs 'zz_render','','','<center><table cellpadding=0 cellspacing=1 border=0 align=center>'+$_mod_table+'</table></center>'
	end
	killvar '_mod_id'
	act 'Добавить мод': gs 'mod_init','add_mod'
	killvar '$_mod_table'
end
! включить/выключить мод
if $args[0] = 'set_mod':
	_mod_id = args[1]
	_mod_status = args[2]
	if _mod_status = 1:
		$_loc_name = INPUT('Введите название стартовой локации мода')
		if len(trim($_loc_name)) > 0:
			$mods['<<_mod_id>>,name'] = trim($_loc_name)
			$mods['<<_mod_id>>,init'] = 1
			ADDQST 'mod<<_mod_id+1>>.qsp'
			_check_mod_id = 0
			gs 'mod_init','check_mod'
		else
			exit
		end
	else
		$mods['<<_mod_id>>,init'] = 0
		! очистка мода при выключении - если прописана переменная утилизации
		if $mods['<<_mod_id>>,dispose'] ! '': gs $mods['<<_mod_id>>,dispose']
		!---
		KILLQST
		gs 'mod_init','reopen'
	end
	killvar '_mod_id'
	killvar '_mod_status'
	killvar '$_loc_name'
	gt 'zz_render_settings','tabs',_selected_page
end
! перезагрузка модов
if $args[0] = 'reopen':
	_mod_id = 0
	:loop_reopen
	if _mod_id < arrsize('$mods')/4:
		if $mods['<<_mod_id>>,init'] = 1: ADDQST 'mod<<_mod_id+1>>.qsp'
		_mod_id += 1
		jump 'loop_reopen'
	end
	killvar '_mod_id'
end
! проверка подключения модов
if $args[0] = 'check_mod':
	if _check_mod_id > arrsize('$mods')/4:
		exit
	else
		:loop_check
		if $mods['<<_check_mod_id>>,init'] = 1: gs $mods['<<_check_mod_id>>,name']
		_check_mod_id += 1
		if _check_mod_id <= arrsize('$mods')/4: jump 'loop_check'
	end
end
! добавление мода - добавляем пустой элемент массива и перегружаем табличку
if $args[0] = 'add_mod':
	_mod_id = arrsize('$mods')/4
	$mods['<<_mod_id>>,name'] = ''
	$mods['<<_mod_id>>,init'] = 0
	$mods['<<_mod_id>>,dispose'] = ''
	$mods['<<_mod_id>>,settings'] = ''
	gs 'mod_init','set_mod',_mod_id,1
end