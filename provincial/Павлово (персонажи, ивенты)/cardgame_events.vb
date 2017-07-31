if $args[0] = 'gg_lose_nosex':
	If cardLoseLevel = 0:cardLoseLevel = 0
	act 'Выполнять желание':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', '', ''
		act 'Уйти': gt 'gorodok'
	end
end