cla
*clr
minut += 30
horny += 20
gs'stat'
'<center><b><font color = maroon>Комната с зеркалом</font></b></center>'
gs 'zz_render', '', 'images/img/centr/bvika1.jpg', func('bordelv_strings', 'local_str1')
act 'Смотреть дальше':
	cla
	*clr
	horny += 20
	picrand = 2
	gs 'zz_render', '', 'images/img/centr/bvika2.jpg', func('bordelv_strings', 'local_str2')
	act 'Убежать':gt'bordelv','out'
	act 'Смотреть дальше':gt'bordelv','sex'
end
if $ARGS[0] = 'sex':
	cla
	*clr
	minut += 10
	dviksex += 1
	horny += 20
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/bvika'+RAND(3,7)+'.jpg', func('bordelv_strings', 'local_str3')
	act 'Смотреть еще':gt'bordelv','sex'
	if dviksex >= 3:act 'Закончить':gt'bordelv','end'
end
if $ARGS[0] = 'end':
	cla
	*clr
	minut += 10
	horny = 0
	orgasm += 1
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/bvika8.jpg', func('bordelv_strings', 'local_str4')
	act 'Ждать':
		cla
		*clr
		gs 'zz_render', '', 'images/img/centr/bvika9.jpg', func('bordelv_strings', 'local_str5')
		if slutty = 0:
			act 'Назвать шлюхой':
				cla
				vika = 10
				gs 'zz_render', '', '', func('bordelv_strings', 'local_str6')
				act 'Уйти':
					vika = 0
					gt'street'
				end
				act 'Успокоить её':
					cla
					vika += 5
					gs 'zz_render', '', '', func('bordelv_strings', 'local_str7')
					act 'Уйти':gt'down'
				end
			end
		elseif slutty > 0:
			act 'Успокоить':
				cla
				vika += 5
				gs 'zz_render', '', '', func('bordelv_strings', 'local_str8')
				act 'Уйти':gt'down'
			end
			act 'Спросить о работе':
				cla
				vika += 5
				bordel = 1
				gs 'zz_render', '', '', func('bordelv_strings', 'local_str9')
				act 'Уйти':gt'down'
			end
		end
	end
end
if $ARGS[0] = 'out':
	cla
	*clr
	minut += 20
	vika = 10
	gs'stat'
	gs 'zz_render', '', 'images/img/centr/bordel.jpg', func('bordelv_strings', 'local_str10')
	'<<$name[1]>> подожди, ты обещала поговорить'
	'"Где этот долбаный выход, потаскуха" выкрикнули вы. Вика смотрела на вас, вы заметили как её губы задрожали а на глазах наворачивались слезы "Там" сказала она, указав вам на одну из дверей, с трудом сдерживаясь что бы не заплакать.'
	act 'Уйти':
		vika = 0
		gt'down'
	end
	act 'Успокоить её':
		cla
		vika += 15
		gs 'zz_render', '', '', func('bordelv_strings', 'local_str11')
		act 'Уйти':gt'down'
	end
end