gs 'stat'
gs 'npc_editor','get_npc_profile',13
gs 'zz_render', '', '', 'Вы подошли к Ларисе и пошли к ней домой.'
act 'Идти с Лариской':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'npc_editor','get_npc_profile',13
	gs 'zz_render', '', '', 'Вы 15 минут шли по улице к дому Ларисы обсуждая всякую ерунду.'
	act 'Войти в квартиру': gt 'LariskaHome'
end