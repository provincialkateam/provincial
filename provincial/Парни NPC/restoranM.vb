if $ARGS[0] = 'start':
	minut += 30
	'Вы приехали в ресторан и сели за столик. <<$boyA>> заказал у официанта еду и хорошее вино. Вы стали ждать когда вам принесут еду.'
	if dayA > 15 and harakBoyA = 2:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 1:gs'boylove','tits'
	if dayA > 25 and harakBoyA = 0:gs'boylove','tits'
	if dayA > 20 and harakBoyA = 2:gs'boylove','figure'
	if dayA > 25 and harakBoyA = 1:gs'boylove','figure'
	if dayA > 30 and harakBoyA = 0:gs'boylove','figure'
	gs'anekdot'
	'<<$boyA>> рассказывает вам анекдот:**<do>' + func('anekdot') + '</do>'
	act 'Смеяться':
		cla
		bfA += 1
		xgt 'restoranM','a'
	end
	act 'Улыбаться':
		cla
		xgt 'restoranM','a'
	end
	act 'Не смешно':
		cla
		bfA -= 1
		xgt 'restoranM','a'
	end
end
if $ARGS[0] = 'a':
	minut += 30
	'Наконец вам принесли еду. <<$boyA>> налил вам вина и предложил выпить за любовь.'
	act 'Есть':
		cla
		xgt 'restoranM', 'b'
	end
end
if $ARGS[0] = 'b':
	minut += 10
	gs 'zz_kitchen_acts', 'eat'
	gs 'zz_kitchen_acts', 'drink', 'tea'
	gs 'zz_funcs', 'alko', 2
	gs 'stat'
	'Через некоторое время с едой и вином было покончено и <<$boyA>> предложил проводить вас.'
	act 'Домой':gt'sexm','start'
end