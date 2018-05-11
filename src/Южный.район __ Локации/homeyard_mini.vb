!$loc = $curloc
if $args[0] = 'start':
*clr & cla
! метка ивента: эвент произошел, -1 - минус в настроение, +1 - наоборот, 0  нейтральный
flag = 0
	if snow > 0:
		! ЗИМА
		!две девки на морозе (шанс 10% при -15С)
		if temper <= -15 and rand(0, 100) <= 10 and flag = 0:
			gt $curloc, 'homeyard_mini_10_000'
			flag = 1
		end
		!девка в купальнике (шанс 10% при -05С)
		if temper <= -5 and rand(0, 100) <= 10 and flag = 0:
			gt $curloc, 'homeyard_mini_11_000'
			flag = 1
		end
		!если нет осадков, художества дворников (шанс 10% при ясной погоде)
		if sunweather >=0 and rand(0, 100) <= 10 and flag = 0:
			if rand(1, 100) <= 10 and flag = 0:
				$_stage = '04'
				n = rand(1, 9)
				! не забываем обновлять кол-во картинок пр  добавлении новых!!
				flag = 1
			end
		else
		!если осадки, укладка асфальта (шанс 10% при осадках)
			if rand(1, 100) <= 10 and flag = 0:
				$_stage = '03'
				n = rand(1, 8)
				flag = -1
			end
		end
		!общие зима
		if flag = 0:
			$_stage = '01'
			n = rand(0, 54)
			! не забываем обновлять кол-во картинок пр  добавлении новых!!
			flag = 1
		end
	else
		! ЛЕТО
		if sunweather <0 and rand(0, 100) <= 10 and flag = 0:
		!если осадки, укладка асфальта (шанс 10% при осадках)
			if rand(1, 100) <= 10 and flag = 0:
				$_stage = '05'
				n = rand(1, 5)
				flag = -1
			end
		end
		!любовник (шанс по количеству общих картинок)
		if rand(0, 47) = 1 and flag = 0:
			gt $curloc, 'homeyard_mini_12_000'
			flag = 1
		end
		!голливудская алкашня (шанс по количеству общих картинок)
		if rand(0, 47) = 1 and flag = 0:
			gt $curloc, 'homeyard_mini_13_000'
			flag = 1
		end
		!общие лето
		if flag = 0:
			$_stage = '02'
			n = rand(0, 47)
			! не забываем обновлять кол-во картинок пр  добавлении новых!!
			flag = 1
		end
	end
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_' + $_stage + '_' + iif(len(n) = 1, '00' & n, iif(len(n) = 2, '0' & n, n)) + '.jpg', func('homeyard_mini_data', $_stage, n)
	gs $curloc,'homeyard_mini_end'
end
!две девки на морозе
if $args[0] = 'homeyard_mini_10_000':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_10_000.jpg', func('homeyard_mini_data', '10', 0)
	act '...': gt $curloc, 'homeyard_mini_10_001'
end
if $args[0] = 'homeyard_mini_10_001':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_10_001.jpg', func('homeyard_mini_data', '10', 1)
	gs $curloc,'homeyard_mini_end'
end
!девка в купальнике
if $args[0] = 'homeyard_mini_11_000':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_11_000.jpg', func('homeyard_mini_data', '11', 0)
	act '...': gt $curloc, 'homeyard_mini_11_001'
end
if $args[0] = 'homeyard_mini_11_001':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_11_001.jpg', func('homeyard_mini_data', '11', 1)
	gs $curloc,'homeyard_mini_end'
end
!любовник
if $args[0] = 'homeyard_mini_12_000':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_12_000.jpg', func('homeyard_mini_data', '12', 0)
	act '...': gt $curloc, 'homeyard_mini_12_001'
end
if $args[0] = 'homeyard_mini_12_001':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_12_001.jpg', func('homeyard_mini_data', '12', 1)
	gs $curloc,'homeyard_mini_end'
end
!голливудская алкашня
if $args[0] = 'homeyard_mini_13_000':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_13_000.jpg', func('homeyard_mini_data', '13', 0)
	act '...': gt $curloc, 'homeyard_mini_13_001'
end
if $args[0] = 'homeyard_mini_13_001':
	*clr & cla
	gs 'zz_render','','images/city/south/homeyard/mini/homeyard_mini_13_001.jpg', func('homeyard_mini_data', '13', 1)
	gs $curloc,'homeyard_mini_end'
end
!конец миника
if $args[0] = 'homeyard_mini_end':
	minut += rand(1,5)
	manna += rand(1,5) * flag
	$npc['0,mini_event_day'] = day
	killvar '$_stage'
	killvar 'n'
	killvar 'flag'
	act 'Идти дальше': gt $loc
end