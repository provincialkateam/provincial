BeInJulMilHome = 1
gs 'npc_editor','get_npc_profile',12
gs 'zz_render','','',func('JuliaMilHome_strings', 'local_str1')
if frost > 0: frost =0
if school['homework'] ! 0:
	gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str2')
	act 'Заниматься с Юлей':
		*clr & cla
		minut += 60
		school['homework'] = 0
		school['intellect'] += 1
		gs 'stat'
		gs 'zz_render', '', 'images/common/npc/12.jpg', func('JuliaMilHome_strings', 'local_str3')
		act 'Передохнуть':gt $curloc
	end
elseif school['homework'] = 0:
	gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str4')
	if eatJulMilDay ! daystart:
		gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str5')
		act 'Идти с Юлей на кухню':
			*clr & cla
			minut += 15
			body['day_weight'] += 1
			energy += 10
			water += 20
			eatJulMilDay = daystart
			cumlip = 0
			gs 'stat'
			gs 'zz_render', '', 'images/common/npc/12.jpg', func('JuliaMilHome_strings', 'local_str6')
			act 'Передохнуть': gt $curloc
		end
		act 'Отказаться':
			*clr & cla
			eatJulMilDay = daystart
			gt $curloc
		end
	else
		if wine = 1:
			act 'Выпить вина с Юлей':
				*clr & cla
				wine = 0
				gs 'npc_editor','change_rep','+', 12
				horny += 10
				gs 'zz_funcs', 'alko', 4
				gs 'zz_render', '', 'images/common/npc/12.jpg', func('JuliaMilHome_strings', 'local_str7')
				gs 'stat'
				act 'Передохнуть':gt $curloc
				if horny >= 50:
					act 'Болтать на сексуальные темы':
						*clr & cla
						minut += 5
						if $npc['12,qwTalkSexJulia'] < 4:$npc['12,qwTalkSexJulia'] += 1
						gs 'stat'
						gs 'zz_render', '', 'images/common/npc/12.jpg', func('JuliaMilHome_strings', 'local_str9')
						if $npc['12,qwTalkSexJulia'] = 1:
							gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str10')
						elseif $npc['12,qwTalkSexJulia'] = 2:
							gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str11')
							act 'Выспрашивать подробности':
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alter/ev2/outdoor.jpg', func('JuliaMilHome_strings', 'local_str12')
								act 'Передохнуть': gt $curloc
							end
							exit
						elseif $npc['12,qwTalkSexJulia'] = 3:
							gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str13')
							act 'Выспрашивать подробности':
								*clr & cla
								minut += 5
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alter/ev2/otrad.jpg', func('JuliaMilHome_strings', 'local_str14')
								act 'Передохнуть':gt $curloc
							end
							exit
						elseif $npc['12,qwTalkSexJulia'] = 4:
							gs 'zz_render', '', '', func('JuliaMilHome_strings', 'local_str15')
							act 'Целоваться с Юлей':
								*clr & cla
								minut += 5
								horny += 20
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alter/ev2/julkiss.jpg', func('JuliaMilHome_strings', 'local_str16')
								act 'Расслабиться':
									*clr & cla
									minut += 5
									horny += 20
									gs 'stat'
									gs 'zz_render', '', 'images/qwest/alter/ev2/jultit.jpg', func('JuliaMilHome_strings', 'local_str17')
									act 'Расслабиться':
										*clr & cla
										minut += 15
										if $npc['12,sex'] = 0: $npc['12,sex'] = 1 & girl += 1
										lesbian += 1
										horny = 0
										orgasm += 1
										gs 'stat'
										gs 'zz_render', '', 'images/qwest/alter/ev2/julick.jpg', func('JuliaMilHome_strings', 'local_str18')
										act 'Передохнуть': gt $curloc
									end
								end
								act 'Да ну тебя, Юлька, отстань':dom += 1 & gt $curloc
							end
							act 'Да ну тебя, Юлька, отстань':dom += 5 & gt $curloc
							exit
						end
						act 'Передохнуть':gt $curloc
					end
				end
			end
		end
		act 'Болтать с Юлей':
			*clr & cla
			minut += 15
			gs 'npc_editor','change_rep','+', 12
			gs 'stat'
			gs 'zz_render', '', 'images/common/npc/12.jpg', func('JuliaMilHome_strings', 'local_str19')
			if RAND(0,5) = 0:'Юля упоминает вскользь что раньше дружила с Наташкой Беловой, но та постоянно занимала денег и не отдавала и Юле это надоело.'
			act 'Передохнуть':gt $curloc
		end
	end
end
act 'Идти домой':gt'pod_ezd','etaj_3'