if $loc = 'university' and (month <= 6 or month >= 9):
	if university['course'] = 1:
		act 'Писать курсовую работу': gt'university_events','course_work'
	else
		act 'Писать дипломную работу': gt'university_events','graduate_work'
	end
	act 'Читать специальную литературу':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
		end
		if nerdism > 0:nerdism += 5
		minut += 60
		university['progress'] += 1
		blizoruk += 1
		gs'stat'
		gs 'zz_render', $_str, 'common/library_acts/read'+iif(glass <= 0,0,1)+'.jpg', 'Вы в течение часа читаете специальную литературу, повышая уровень своих знаний.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Отложить книгу':gt $loc, $metka
	end
end
act 'Читать научную книгу (1 час)':
	*clr & cla
	if glassqw = 1:
		gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
		act 'Отложить книгу':gt $loc, $metka
	end
	if nerdism > 0:nerdism += 5
	minut += 60
	school['intellect'] += 1
	blizoruk += 1
	gs'stat'
	gs 'zz_render', $_str, 'common/library_acts/read'+iif(glass <= 0,2,3)+'.jpg', 'Вы в течение часа читаете книгу, пытаясь понять всякие умные фразочки, разобраться в предмете описания, и повышая свой интеллект.'
	if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
	act 'Отложить книгу':gt $loc, $metka
end
act 'Читать развлекательную книгу (1 час)':
	*clr & cla
	if glassqw = 1:
		gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
		act 'Отложить книгу':gt $loc, $metka
	end
	if nerdism > 0:nerdism += 20
	minut += 60
	manna = 100
	blizoruk += 1
	gs'stat'
	gs 'zz_render', $_str, 'common/library_acts/read'+iif(glass <= 0,4,5)+'.jpg', 'Вы в течение часа читаете книгу о приключениях.'
	if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
	act 'Отложить книгу':gt $loc, $metka
end
if school['certificate'] = 0:
	act 'Читать собрание сочинений Льва Толстого (2 часа)':
		*clr & cla
		if glassqw = 1:
			gs 'zz_render', $_str, 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
			act 'Отложить книгу':gt $loc, $metka
		end
		if nerdism > 0:nerdism += 10
		minut += 60
		blizoruk += 1
		school['progress'] += 1
		gs'stat'
		gs 'zz_render', $_str, 'common/library_acts/read'+iif(glass <= 0,6,7)+'.jpg', 'Вы, в течение двух часов читаете книгу, повышая свою успеваемость в школе. Толстой конечно классик, этого никто не отрицает, но писал он тягомотину редкую.'
		if blizoruk = 200 and glassqw = 0: glassqw = 1 & gs 'zz_render', '', '', '<font color=red>Текст расплывается по странице, похоже вы испортили зрение. Нужно будет сходить к окулисту.</font>'
		act 'Отложить книгу':gt $loc, $metka
	end
end