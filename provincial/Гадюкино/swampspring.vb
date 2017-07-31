$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs'stat'
gs'time'
gs 'zz_render', 'Родник', func('zz_funcs','mk_image','qwest/gadukino/Swamp/swampspring'), 'Родник с чистой ключевой водой.'
act 'Попить воды':
	*clr & cla
	minut += 5
	if water >= 20:
		gs 'zz_render', 'Родник', 'qwest/gadukino/Swamp/hands.jpg','Вода в вас больше не лезет.'
	elseif water < 20:
		water = water +20
		cumlip = 0
		dirtylip = 0
		gs 'zz_render', 'Родник', 'qwest/gadukino/Swamp/hands.jpg','Вы с удовольствием напились родниковой воды.'
	end
    gs 'stat'
	act 'Закончить':gt 'swampspring'
end
if bucket < 10:
    act 'Набрать воды в ведро':
	    *clr & cla
	    minut += 10
	    bucket += 10
	    gs 'stat'
	    gs 'zz_render', 'Родник', 'qwest/gadukino/Swamp/vedro.jpg','Вы набрали воды в ведро.'
        act 'Закончить':gt 'swampspring'
    end
end
act 'Уйти':minut += 5 & gt'swamp_yard'