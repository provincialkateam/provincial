if $ARGS[0] = 'start' or $ARGS[0] = '':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Автосалон', 'images/pic/manager.jpg','Менеджер приветливо улыбается и говорит:**\\\- Для покупки необходимо иметь права и достаточно наличности на счету в банке, мы не работаем по наличному расчету. Также нельзя иметь две машины, извините, но это новый, антипробковый закон городской мэрии.///'
	if age >= 18 and prava = 1: act 'Посмотреть машины': gt 'autosalonF','cars'
	act 'Уйти':
		gs 'zz_cars', 'dispose'
		gt 'nord'
	end
end
if $args[0] = 'cars':
	gs 'zz_cars', 'create_shop'
	act 'Уйти':
		gs 'zz_cars', 'dispose'
		gt 'nord'
	end
end