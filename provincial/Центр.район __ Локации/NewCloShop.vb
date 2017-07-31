$metka = $ARGS[0]
$loc = $CURLOC
*clr
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Магазин "Модница"'
act 'Уйти':
	minut += 15
	gs 'zz_clothing', 'dispose'
	gt 'down'
end
if hour >= 9 and hour <= 21:
	! 8 - shop_id
	gs 'zz_clothing', 'make_shop', 8
end