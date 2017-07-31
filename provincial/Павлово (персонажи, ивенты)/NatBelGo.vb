gs 'stat'
gs 'npc_editor','get_npc_profile',16
gs 'zz_render', '', '','Вы подошли к Наташе и она спросила у вас, пойдете ли вы к ней домой, учить уроки.'
act 'Идти с Наташей':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'npc_editor','get_npc_profile',16
	gs 'zz_render', '', '','Вы 15 минут шли по улице к Наташиному дому обсуждая всякую ерунду.'
	act 'Войти в квартиру': gt 'NatBelHome'
end