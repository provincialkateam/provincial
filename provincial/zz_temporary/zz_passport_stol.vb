if $args[0] = 'start':
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Паспортный стол','pavlovo/dk/pass_stol','<red>Смена имени - 1000р.</red>'
	if flag_change_name = 0 and money >= 1000:
		act 'Сменить имя':
			gt 'zz_passport_stol','change_name'
		end
	elseif flag_change_name = 1 and week = 1 and change_name_day ! day and $flag_change_name_loc = $loc:
		act 'Забрать паспорт':
			cla
			flag_change_name = 0
			$name = iif(len($changer[0])>0,$changer[0],$name)
			$name_a = iif(len($changer[1])>0,$changer[1],$name_a)
			$name_b = iif(len($changer[2])>0,$changer[2],$name_b)
			$name[1] = iif(len($changer[3])>0,$changer[3],$name[1])
			$name_a[1] = iif(len($changer[4])>0,$changer[4],$name_a[1])
			$name_b[1] = iif(len($changer[5])>0,$changer[5],$name_b[1])
			$name[2] = iif(len($changer[6])>0,$changer[6],$name[2])
			$name_a[2] = iif(len($changer[7])>0,$changer[7],$name_a[2])
			$name_b[2] = iif(len($changer[8])>0,$changer[8],$name_b[2])
			$name[3] = iif(len($changer[9])>0,$changer[9],$name[3])
			$name_a[3] = iif(len($changer[10])>0,$changer[10],$name_a[3])
			$name_b[3] = iif(len($changer[11])>0,$changer[11],$name_b[3])
			$name[4] = iif(len($changer[12])>0,$changer[12],$name[4])
			$name_a[4] = iif(len($changer[13])>0,$changer[13],$name_a[4])
			$name_b[4] = iif(len($changer[14])>0,$changer[14],$name_b[4])
			$surname = iif(len($changer[15])>0,$changer[15],$surname)
			$surname_a = iif(len($changer[16])>0,$changer[16],$surname_a)
			$surname_b = iif(len($changer[17])>0,$changer[17],$surname_b)
			minut += 10
			gs 'stat'
			gs 'zz_render','','','Вы забрали свой новый паспорт, теперь вас зовут ' + $name + ' ' + $surname
			killvar '$changer'
			killvar 'flag_change_name'
			killvar 'change_name_day'
			killvar '$flag_change_name_loc'
			act 'Уйти': gt $loc, $metka
		end
	end
	if flag_change_name = 1: gs 'zz_render','','','За паспортом приходите в понедельник с 9 до 14.'
	act 'Уйти':
		killvar '$zz_str'
		gt $loc, $metka
	end
end
if $args[0] = 'change_name':
	cla
	killvar '$zz_str'
	! descriptions
	$zz_str['name'] = 'Укажите полное имя, например, Светлана:'
	$zz_str['name_a'] = 'Укажите полное имя в винительной падеже, например, Светлану:'
	$zz_str['name_b'] = 'Укажите полное имя в родительном падеже, например, Светланы:'
	$zz_str['name1'] = 'Укажите короткое имя, например, Света:'
	$zz_str['name_a1'] = 'Укажите короткое имя в винительной падеже, например, Свету:'
	$zz_str['name_b1'] = 'Укажите короткое имя в родительном падеже, например, Светы:'
	$zz_str['name2'] = 'Укажите уменьшительно-ласкательную форму имени, например, Светик:'
	$zz_str['name_a2'] = 'Укажите уменьшительно-ласкательную форму имени в винительной падеже, например, Светика:'
	$zz_str['name_b2'] = 'Укажите уменьшительно-ласкательную форму имени в родительном падеже, например, Светика:'
	$zz_str['name3'] = 'Укажите уменьшительно-ласкательную форму имени, например, Светка:'
	$zz_str['name_a3'] = 'Укажите уменьшительно-ласкательную форму имени в винительной падеже, например, Светку:'
	$zz_str['name_b3'] = 'Укажите уменьшительно-ласкательную форму имени в родительном падеже, например, Светки:'
	$zz_str['name4'] = 'Укажите обращение, (Свет):'
	$zz_str['name_a4'] = 'Укажите ласковое обращение, (Светуль):'
	$zz_str['name_b4'] = 'Укажите обращение, (Светлан):'
	$zz_str['surname'] = 'Укажите фамилию, например, Лебедева:'
	$zz_str['surname_a'] = 'Укажите фамилию в винительной падеже, например, Лебедеву:'
	$zz_str['surname_b'] = 'Укажите фамилию в родительном падеже, например, Лебедевой:'
	$zz_table = '<center><table width=100%>'
	i = 0
	:loop_change_name
	if i < 18:
		if i = 0: $zz_tmp = $name
		if i = 1: $zz_tmp = $name_a
		if i = 2: $zz_tmp = $name_b
		if i = 3: $zz_tmp = $name[1]
		if i = 4: $zz_tmp = $name_a[1]
		if i = 5: $zz_tmp = $name_b[1]
		if i = 6: $zz_tmp = $name[2]
		if i = 7: $zz_tmp = $name_a[2]
		if i = 8: $zz_tmp = $name_b[2]
		if i = 9: $zz_tmp = $name[3]
		if i = 10: $zz_tmp = $name_a[3]
		if i = 11: $zz_tmp = $name_b[3]
		if i = 12: $zz_tmp = $name[4]
		if i = 13: $zz_tmp = $name_a[4]
		if i = 14: $zz_tmp = $name_b[4]
		if i = 15: $zz_tmp = $surname
		if i = 16: $zz_tmp = $surname_a
		if i = 17: $zz_tmp = $surname_b
		$changer[i] = iif($zz_tmp = $changer[i], $zz_tmp, $changer[i])
		$zz_color = iif($zz_color = '#f3f4ee', '#ffffff', '#f3f4ee')
		$zz_table += '<tr bgcolor=' + $zz_color + '><td>' + $zz_str[i] + '</td><td> <a href="exec: gs ''zz_passport_stol'', ''changer'', '+ i +'">' + iif(len($changer[i])>1,$changer[i],$zz_tmp) + '</a></td></tr>'
		i += 1
		jump 'loop_change_name'
	end
	gs 'zz_render','Паспортный стол','',$zz_table + '</table></center>'
	killvar '$zz_tmp'
	killvar '$zz_table'
	act 'Подтвердить':
		change_name_day = day
		flag_change_name = 1
		$flag_change_name_loc = $loc
		money -= 1000
		gt 'zz_passport_stol', 'start'
	end
	act 'Отмена':
		killvar '$changer'
		gt 'zz_passport_stol', 'start'
	end
end
if $args[0] = 'changer':
	$zz_tmp = trim(input($zz_str[args[1]]))
	if len($zz_tmp) > 1: $changer[args[1]] = $zz_tmp
	killvar '$zz_tmp'
	gt 'zz_passport_stol', 'change_name'
end