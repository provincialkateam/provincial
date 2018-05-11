$loc = $curloc
if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	$metka = $args[0]
	gs 'zz_funcs','colorize_day'
	gs 'zz_render','Кис-киска','city/center/kiskis/kiskis','Небольшой и не самый дешёвый магазинчик одежды для молодёжи. В основном тут продают довольно смелые наряды для раскрепощённых молодых людей с привлекательными телами.'
	act '<B>Выйти из магазина</B>':
		minut += 3
		gs 'zz_clothing2','dispose'
		gt 'center'
	end
	if hour < 8 or hour > 18:
		gs 'zz_render','','','<red>Магазин закрыт.</red>'
		exit
	end
	act 'Посмотреть одежду': gt 'kiskis','shop'
end
if $args[0] = 'shop':
	*clr & cla
	act 'Назад': gt 'kiskis','main'
	!--
	gs 'zz_clothing2','make_shop',4
	gs 'zz_clothing2','make_shop',8
	!--
end