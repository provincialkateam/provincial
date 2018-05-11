onceridePerDay = daystart
family_trip = 0
hour = 21
minut = 0
if month >= 6 or month <= 8:
	gs 'zz_render','','','Мама спрашивает у вас "Ну что, Света, поедешь с нами или останешся пока в деревне?"'
	act 'Ехать с родителями домой':
		*clr & cla
		gs 'zz_render','','','Вы сели в Волгу вместе с семьей и за час добрались в Павлово.'
		act 'Идти домой': gt 'korrPar'
	end
	act 'Остатся в деревне': gt 'Gadhouse'
else
	gs 'stat'
	gs 'zz_render','','','Вы сели в Волгу вместе с семьей и за час добрались в Павлово.'
	act 'Идти домой': gt 'korrPar'
end