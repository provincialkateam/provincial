onceridePerDay=daystart
indorf = 0
if month >= 6 or month <= 8:
'Мама спрашивает у вас "Ну что, <<$name[1]>>, поедешь с нами или останешся пока в деревне?"'
	act'Ехать с родителями домой':
		*clr & cla
		hour = 21
		minut = 0
		'Вы сели в Волгу вместе с семьей и за час добрались в Павлово.'
		act 'Идти домой': gt 'korrPar'
	end
	act'Остатся в деревне':gt'Gadhouse'
else
	hour = 21
	minut = 0
	gs 'stat'
	'Вы сели в Волгу вместе с семьей и за час добрались в Павлово.'
	act 'Идти домой': gt 'korrPar'
end