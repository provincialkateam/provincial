$loc = $curloc
if $args[0] = 'kotovkom' or $args[0] = '':
	*clr & cla
	minut += 5
	gs 'zz_bathroom','clean_me'
	gs 'stat'
	gs 'zz_render','','','qwest/alter/ev/Kotovsexsyst/kotovdom/kotovkom.jpg','На кровати лежит Витек и смотрит телевизор.'
	act 'Идти домой':
		*clr & cla
		minut += rand(10,15)
		kotov_bj_times = 0
		gs 'zz_render','','qwest/alter/ev/Kotovsexsyst/kotovpr.gif','Витек провел вас до дома, вы вместе поднялись на 2-ой этаж и остановились рядом с вашей квартирой.**Он поцеловал вас на прощанье, крепко лапая и сжимая ваши булки.**\\- Пока,Светик, еще встретимся, не скучай без меня.//'
		act 'Уйти': gt'pod_ezd','etaj_2'
	end
end