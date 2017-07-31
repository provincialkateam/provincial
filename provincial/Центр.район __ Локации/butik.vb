if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Бутик</font></b></center>'
	'<center><img src="images/pic/butik.jpg"></center>'
	if palto < 3:
		'В бутике продают шубу для зимы. 50000 руб'
		if money >= 50000:
			act 'Купить шубу':
				cla
				money -= 50000
				palto = 3
				$palto = 'шуба'
				'Вы купили шубу.'
				act 'Выйти':gt'butik','start'
			end
		end
	end
	! 7 - shop_id
	gs 'zz_clothing', 'make_shop', 7
	act 'Выйти из Бутика':
		cla
		minut += 5
		gs 'zz_clothing', 'dispose'
		gt 'torgcentr'
	end
end