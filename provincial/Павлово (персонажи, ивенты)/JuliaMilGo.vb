gs'stat'
gs 'npc_editor','get_npc_profile',12
gs 'zz_render', '', '', 'Вы подошли к Юле и она спросила у вас, пойдете ли вы к ней домой, учить уроки.'
act 'Идти с Юлей':
	*clr & cla
	minut += 15
	gs'stat'
	gs 'npc_editor','get_npc_profile',12
	gs 'zz_render', '', '', 'Вы 15 минут шли по улице к Юлиному дому обсуждая всякую ерунду.'
	act 'Войти в квартиру':gt'JuliaMilHome'
end