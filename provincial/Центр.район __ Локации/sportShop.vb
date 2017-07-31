if $args[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Спортивные товары','images/pic/sportshop.jpg'
	act 'Выйти':
		cla
		minut += 5
		gs 'zz_clothing', 'dispose'
		gt 'torgcentr'
	end
	$_str = '<tr><td>Название</td><td>Цена</td><td>...</td></tr>'
	if skak = 0: $_str += '<tr><td>Скакалка</td><td>200</td><td><a href="exec: skak = 1 & money -= 200 & gt ''sportshop'',''start''">Купить</a></td></tr>'
	if obruch = 0: $_str += '<tr><td>Обруч</td><td>400</td><td><a href="exec: obruch = 1 & money -= 400 & gt ''sportshop'',''start''">Купить</a></td></tr>'
	if skak = 0 or obruch = 0: gs 'zz_render','','','<table width=100%>'+$_str+'</table>'
	killvar '$_str'
	! 3 - shop_id
	gs 'zz_clothing', 'make_shop', 3
end