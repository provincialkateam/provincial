BeInNatBelHome = 1
gs 'npc_editor','get_npc_profile',16
gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str1')
if frost > 0: frost = 0
gs 'stat'
if school['homework'] ! 0:
	gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str2')
	act 'Заниматься с Наташей':
		*clr & cla
		minut += 60
		school['homework'] = 0
		school['intellect'] += 1
		gs'stat'
		gs 'zz_render', '', 'images/common/npc/16.jpg', func('NatBelHome_strings', 'local_str3')
		act 'Передохнуть':gt $curloc
	end
elseif school['homework'] = 0:
	gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str4')
	act 'Болтать с Наташей':
		*clr & cla
		minut += 15
		gs 'npc_editor','change_rep','+', 16
		gs'stat'
		gs 'zz_render', '', 'images/common/npc/16.jpg', func('NatBelHome_strings', 'local_str5')
		act 'Далее':gt $curloc
	end
	if qwNatashaDolgMoney <= 0 and money >= 2000 and $npc['16,qwNatashaDolg'] > 0:
		gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str6')
		act 'Дать денег Наташе':
			*clr & cla
			minut += 15
			qwNatashaDolgMoney = 2000
			money -= 2000
			gs'stat'
			gs 'zz_render', '', 'images/common/npc/16.jpg', func('NatBelHome_strings', 'local_str7')
			act 'Далее':gt $curloc
		end
	elseif $npc['16,relation'] >= 80 and qwNatashaDolgMoney = 0 and money >= 5000 and $npc['16,qwNatashaDolg'] = 0:
		gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str8')
		act 'Дать в долг Наташе':
			*clr & cla
			minut += 15
			qwNatashaDolgMoney = 5000
			money -= 5000
			NatashaDolgDay = daystart + 30
			gs 'npc_editor','change_rep','+', 16
			gs'stat'
			gs 'zz_render', '', 'images/common/npc/16.jpg', func('NatBelHome_strings', 'local_str9')
			act 'Передохнуть':gt $curloc
		end
	elseif qwNatashaDolgMoney > 0 and NatashaDolgDay > daystart:
		gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str10')
	elseif qwNatashaDolgMoney > 0 and NatashaDolgDay <= daystart:
		gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str11')
		act 'Простить долг Наташе':
			*clr & cla
			minut += 15
			qwNatashaDolgMoney = 0
			NatashaDolgDay = 0
			gs 'npc_editor','change_rep','+', 16, 10
			gs'stat'
			gs 'zz_render', '', 'images/common/npc/16.jpg', func('NatBelHome_strings', 'local_str12')
			act 'Передохнуть':gt $curloc
		end
		if dom >= 10 and natotrab = 0:
			act 'Требовать деньги':
				*clr & cla
				minut += 15
				gs'stat'
				gs 'zz_render', '', 'images/common/npc/16.jpg', func('NatBelHome_strings', 'local_str13')
				act 'На колени! И пасть открой!':
					*clr & cla
					minut += 5
					natotrab += 1
					$npc['16,qwNatashaDolg'] += 1
					!natknee
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/ev2/natknee.jpg', func('NatBelHome_strings', 'local_str14')
					act 'Плюнуть ей в морду':
						*clr & cla
						minut += 5
						$npc['16,qwNatashaDolg'] += 1
						qwNatashaDolgMoney -= 500
						!natknee
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/ev2/natknee.jpg', func('NatBelHome_strings', 'local_str15')
						act 'Передохнуть':gt $curloc
					end
				end
			end
		end
		if natotrab > 0 and qwNatashaDolgMoney > 0:
			gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str16')
			act 'На колени! И пасть открой!':
				*clr & cla
				minut += 5
				natotrab += 1
				$npc['16,qwNatashaDolg'] += 1
				!natknee
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/ev2/natknee.jpg', func('NatBelHome_strings', 'local_str17')
				act 'Плюнуть ей в морду':
					*clr & cla
					minut += 5
					$npc['16,qwNatashaDolg'] += 1
					qwNatashaDolgMoney -= 500
					!natknee
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/ev2/natspit.jpg', func('NatBelHome_strings', 'local_str18')
					act 'Передохнуть':gt $curloc
				end
				if $npc['16,qwNatashaDolg'] >= 4:
					act 'Заставить ее вылизать':
						*clr & cla
						minut += 5
						$npc['16,qwNatashaDolg'] += 1
						qwNatashaDolgMoney -= 500
						if $npc['16,sex'] = 0: $npc['16,sex'] = 1 & girl += 1
						lesbian += 1
						natlesb += 1
						!natknee
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/ev2/natlick.jpg', func('NatBelHome_strings', 'local_str19')
						if $npc['16,qwNatashaDolg'] < 10:
							gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str20')
							if dom >= 20 and qwNatashaDolgMoney >= 500:
								act 'Нассать ей в рот':
									*clr & cla
									minut += 5
									$npc['16,qwNatashaDolg'] += 1
									qwNatashaDolgMoney -= 500
									natpee += 1
									!natknee
									gs'stat'
									gs 'zz_render', '', 'images/qwest/alter/ev2/natpee.jpg', func('NatBelHome_strings', 'local_str21')
									act 'Передохнуть':gt $curloc
								end
							end
						else
							orgasm += 1
							horny = 0
							gs'stat'
							gs 'zz_render', '', '', func('NatBelHome_strings', 'local_str22')
						end
						act 'Передохнуть':gt $curloc
					end
				end
			end
			if $npc['16,qwNatashaDolg'] >= 6:
				act 'Позвать брата':
					*clr & cla
					minut += 15
					$npc['16,qwNatashaDolg'] += 1
					qwNatashaDolgMoney -= 500
					natbj += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/ev2/natbj.jpg', func('NatBelHome_strings', 'local_str23')
					act 'Передохнуть':gt $curloc
				end
			end
		end
	end
end
act 'Идти домой':gt'pod_ezd','etaj_4'