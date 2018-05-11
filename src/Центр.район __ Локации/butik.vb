*clr & cla
$metka = $args[0]
$loc = $curloc
minut += 5
gs 'stat'
gs 'zz_funcs','colorize_day'
gs 'zz_render','','images/pic/butik.jpg'
if palto < 3:
	gs 'zz_render','','','В бутике продают шубу для зимы за 50000 руб'
	act 'Купить шубу':
		cla
		if func('zz_funcs','payment',2,50000,1) = 1:
			palto = 3
			$palto = 'шуба'
			gs 'zz_funcs','message','','<green>Вы купили шубу.</green>'
		end
		act 'Назад': gt 'butik'
	end
end
gs 'zz_clothing2','make_shop',5
act '<b>Выйти из Бутика</b>':
	minut += 5
	gs 'zz_clothing2','dispose'
	gt 'center'
end