gs'stat'
gs 'zz_render', '', 'images/qwest/alter/ev2/furi.jpg', func('furi_strings', 'local_str1')
act 'Уйти':minut += 5 & gt'road'
if $npc['43,qwBioOtec'] = 1:
	act 'Спросить про Михаила Кузнецова':
	*clr & cla
	minut += 5
	$npc['43,qwBioOtec'] = 2
	gs'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_1.jpg', func('furi_strings', 'local_str2')
	act 'Отойти':gt $loc, $metka
	end
end
act 'Автостоп':
	*clr & cla
	gs'stat'
	'<center><img src="images/qwest/alter/ev2/furi.jpg"></center>'
	if nroad = 0:'Вы спросили у водителя, может ли он вас подвезти до Павлово.'
	if nroad = 20:'Вы спросили у водителя, может ли он вас подвезти до города.'
	gs 'zz_render', '', '', func('furi_strings', 'local_str3')
	act 'Уйти':minut += 5 & gt $curloc
	act 'Я согласна':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/furi.jpg', func('furi_strings', 'local_str4')
		act 'Нет':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', '', func('furi_strings', 'local_str5')
			act 'Уйти':minut += 5 & gt $curloc
			act 'Уговаривать':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', '', func('furi_strings', 'local_str6')
				act 'Уйти':minut += 5 & gt $curloc
				act 'Залезть в фуру':minut += 5 & furisex = 100 & gt'furisex'
			end
		end
		if prezik > 0:
			act 'Есть':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', '', func('furi_strings', 'local_str7')
				act 'Уйти':minut += 5 & gt $curloc
				act 'Залезть в фуру':minut += 5 & furisex = 0 & gt'furisex'
			end
		end
	end
end