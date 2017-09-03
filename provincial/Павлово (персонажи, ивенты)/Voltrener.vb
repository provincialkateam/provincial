$din_trener_bj = {
	act 'Сделать минет':
		*clr & cla
		bj += 1
		if $npc['28,sex'] = 0: guy += 1
		$npc['28,sex'] += 1
		if volleysostav > 0: gs 'npc_editor','change_rep','+', 28
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev/tren.jpg', func('Voltrener_strings', 'local_str1')
		if tipTrsex = 0:
			gs 'zz_funcs', 'cum', 'lip'
			swallow += 1
			gs'stat'
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str2')
		end
		if volleysostav = 0:
			volleysostav = 1
			$npc['28,relation'] = 20
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str3')
		end
		if tipTrsex = 0:act 'Уйти':tipTrsex = 0 & gt'gdksport'
	end
}
$din_trener_masaj = {
	gs 'zz_render', '', '', func('Voltrener_strings', 'local_str4')
	act 'Согласиться':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj1.jpg', func('Voltrener_strings', 'local_str5')
		act 'Раздеться':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj2.jpg', func('Voltrener_strings', 'local_str6')
			act 'Лечь':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj3.jpg', func('Voltrener_strings', 'local_str7')
				act 'Расслабиться':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj4.jpg', func('Voltrener_strings', 'local_str8')
					act 'Далее':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj5.jpg', func('Voltrener_strings', 'local_str9')
						act 'Далее':
							*clr & cla
							son += 5
							minut += 30
							manna += 20
							gs 'stat'
							gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj6.jpg', func('Voltrener_strings', 'local_str10')
							act 'Всё': gt'gdksport'
							if horny >= 100 and mesec <= 0:
								act 'Продолжим':
									*clr & cla
									gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj7.jpg', func('Voltrener_strings', 'local_str11')
									act 'Далее':
										*clr & cla
										orgasm += 1
										kuni += 1
										horny = 0
										gs 'npc_editor','change_rep','+', 28
										gs 'stat'
										gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj8.gif', func('Voltrener_strings', 'local_str12')
										act 'Прийти в себя':
											*clr & cla
											gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj9.jpg', func('Voltrener_strings', 'local_str13')
											act 'Облизать':
												*clr & cla
												gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj10.jpg', func('Voltrener_strings', 'local_str14')
												act 'Открыть рот':
													*clr & cla
													gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj11.jpg', func('Voltrener_strings', 'local_str15')
													act 'Проглотить':
														*clr & cla
														swallow += 1
														gs 'zz_funcs', 'cum', 'lip'
														bj += 1
														minut += 30
														manna += 20
														$npc['28,sex'] += 1
														gs 'stat'
														gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj12.gif', func('Voltrener_strings', 'local_str16')
														act 'Далее':
															*clr & cla
															gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerMasaj13.jpg', func('Voltrener_strings', 'local_str17')
															act 'Уйти': gt 'gdksport'
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
}
gs'stat'
gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener6.jpg', func('Voltrener_strings', 'local_str18')
if volleysostav > 0:
	if $npc['28,relation'] < 20:'Тренер не желает вас больше терпеть.'
	if $npc['28,relation'] >= 20 and $npc['28,relation'] < 40:'Тренер едва вас терпит.'
	if $npc['28,relation'] >= 40 and $npc['28,relation'] < 60:'У вас с тренером нормальные отношения.'
	if $npc['28,relation'] >= 60 and $npc['28,relation'] < 80:'У вас с тренером хорошие отношения.'
	if $npc['28,relation'] >= 80:'Тренер в вас души не чает.'
	if $npc['28,relation'] < 20:
		volleysostav = -1
		gs 'zz_render', '', '', func('Voltrener_strings', 'local_str19')
		act 'Уйти':gt'gdksport'
		exit
	end
end
if lariskaTrenerTalk > 0:
	gs 'zz_render', '', '', func('Voltrener_strings', 'local_str20')
	if lariskaTrenerTalk = 1:
		gs 'zz_render', '', '', func('Voltrener_strings', 'local_str21')
	elseif lariskaTrenerTalk = 2:
		if dom >= 10:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str22')
			LariskaProfi = 1
		else
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str23')
		end
	elseif lariskaTrenerTalk = 3:
		if dom >= 20:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str24')
			volleysostav = 1
			$npc['28,relation'] = 30
			LariskaProfi = 1
		else
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str25')
		end
	elseif lariskaTrenerTalk = 4:
		if $npc['28,relation'] >= 60:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str26')
			LariskaProfi = 1
		else
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str27')
		end
	end
	if LariskaProfi = 1:
		gs 'zz_render', '', '', func('Voltrener_strings', 'local_str28')
		$npc['13,relation'] += 20
	end
	minut += 10
	gs'stat'
	lariskaTrenerTalk = 0
	act 'Уйти': gt 'gdksport'
	exit
end
act 'Поговорить с тренером':
	*clr & cla
	'<center><img src="images/pavlovo/dk/volley/Tren/VolleyTrener6.jpg"></center>'
	if volleysostav = -1:
		if $npc['28,sex'] = 0:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str29')
		else
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str30')
		end
	elseif volleysostav = 0:
		if volleyboll < 25:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str31')
		elseif volleyboll >= 25 and volleyboll < 50:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str32')
		elseif volleyboll >= 50 and volleyboll < 75:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str33')
		elseif volleyboll >= 75:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str34')
			act 'Проситься в профи':
				*clr & cla
				if volleyboll < 100:
					gs 'zz_render', '', '', func('Voltrener_strings', 'local_str35')
				else
					gs 'zz_render', '', '', func('Voltrener_strings', 'local_str36')
					act 'Убеждать':
						*clr & cla
						dom -= 1
						gs'stat'
						if dom >= 10:
							volleysostav = 1
							$npc['28,relation'] = 20
							gs 'zz_render', '', '', func('Voltrener_strings', 'local_str37')
						else
							gs 'zz_render', '', '', func('Voltrener_strings', 'local_str38')
						end
						act 'Уйти':gt'gdksport'
					end
				end
				act 'Уйти':gt'gdksport'
			end
		end
	elseif volleysostav > 0:
		if $npc['28,sex'] > 0:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str39')
			act 'Положить руку тренеру на колено':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', '', func('Voltrener_strings', 'local_str40')
				dynamic $din_trener_bj
			end
			if son < 6 and tanga=1:
				delact 'Положить руку тренеру на колено'
				dynamic $din_trener_masaj
			end
		end
		if $npc['28,sex'] > 0:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str41')
		else
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str42')
		end
		n=20-volsesongame
		if n=1:
			$okonc='у'
		elseif n=>2 and n<=4:
			$okonc='ы'
		else
			$okonc=''
		end
		gs 'zz_render', '', '', func('Voltrener_strings', 'local_str43')
		r=volsesonloss-volsesonwin
		if r=1:
			$okonc1='у'
		elseif r=>2 and r<=4:
			$okonc1='ы'
		else
			$okonc1=''
		end
		if volsesongame<20:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str44')
		elseif volsesongame=>20 and volsesonwin=>volsesonloss:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str45')
		elseif volsesongame=>20 and volsesonwin<volsesonloss:
			gs 'zz_render', '', '', func('Voltrener_strings', 'local_str46')
		end
		if rand(0,3)=0:
			trenerskaia=1
			dynamic $din_trener_Speak
		end
	end
	act 'Уйти':gt'gdksport'
end
act 'Уйти':gt'gdksport'