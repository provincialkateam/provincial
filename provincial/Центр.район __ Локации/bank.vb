*clr & cla
minut += 5
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render','Банк','images/pic/bank.jpg',iif(karta > 0,'На счету в банке <<karta>> рублей','')
if week <= 5 and hour = 16 and minut >= 30 and $npc['15,qwVika'] >= 32: gs 'zz_render','','','Похоже, <a href="exec:gs''mey_tamara_events'',''tamara''">Тамара Михайловна</a> собирается домой.'
if BankPapper = 1 and dayBankPapper = day:
	act 'Отдать документы':
		*clr
		minut += 15
		BankPapper = 2
		gs 'stat'
		gs 'zz_render','','','Вы зашли в офис и отдали документы менеджеру.'
		act 'Уйти': minut += 5 & gt'down'
	end
end
if money > 0:
	act 'Положить деньги на счет':
		cla
		kartaIN = input ("Сколько денег вы хотите положить на счет?")
		if kartaIN <= 0 or kartaIN > money:
			gs 'zz_render','','','Не корректная операция.'
		else
			karta += kartaIN
			money -= kartaIN
			gs 'zz_render','','','Вы положили на счет <<kartaIN>> рублей, теперь на вашем счету <<karta>> рублей.'
		end
		act 'Отойти': gt 'bank'
	end
end
if karta > 0:
	act 'Снять деньги со счета':
		cla
		kartaOUT = input("Сколько денег вы хотите снять со счета?")
		if kartaOUT <= 0 or kartaOUT > karta:
			gs 'zz_render','','','Не корректная операция.'
		else
			karta -= kartaOUT
			money += kartaOUT
			gs 'zz_render','','','Вы сняли со счета <<kartaOUT>> рублей, теперь на вашем счету <<karta>> рублей.'
		end
		act 'Отойти': gt 'bank'
	end
end
act 'Выйти': gt 'down'