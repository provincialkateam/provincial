$sisboyQW_prycaress = {
	*clr & cla
	minut += 5
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_17.jpg', func('sistersleep_strings', 'local_str1')
	act 'Отойти': gt 'bedrPar'
}
if lesbian > 0:
	horny += 5 & siswath += 1
	gs 'stat'
end
gs 'zz_render', 'Аня', 'pavlovo/family/sister/sleep'+RAND(0,7)+'.jpg', func('sistersleep_strings', 'local_str2')
if $loc = 'bedrPar':
	if $npc['38,qwSisterBoy'] >= 8 and $npc['38,qwSisterLesbi'] = 0 and horny >= 60:
		act 'Потрогать':
			*clr & cla
			minut += 1
			horny += 5
			$npc['38,qwSisterLesbi'] = 1
			sisprynight = day
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_16.jpg', func('sistersleep_strings', 'local_str3')
			act 'Ласкать себя': dynamic $sisboyQW_prycaress
			act 'Отойти': gt 'bedrPar'
		end
	elseif $npc['38,qwSisterLesbi'] = 1 and horny >= 60 and sisprynight ! day:
		act 'Потрогать':
			*clr & cla
			minut += 1
			horny += 5
			sisprynight = day
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_18.jpg', func('sistersleep_strings', 'local_str4')
			act 'Продолжить':
				*clr & cla
				minut += 2
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_19.jpg', func('sistersleep_strings', 'local_str5')
				act 'Поцеловать Аню':
					*clr & cla
					minut += 1
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_21.jpg', func('sistersleep_strings', 'local_str6')
					act 'Ласкать сестру':
						*clr & cla
						minut += 1
						if horny < 95:horny += 5
						$npc['38,qwSisterLesbi'] = 2
						girl += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_22.jpg', func('sistersleep_strings', 'local_str7')
						act 'Отойти':gt'bedrPar'
					end
				end
				act 'Убрать руку':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_20.jpg', func('sistersleep_strings', 'local_str8')
					act 'Отойти':
						*clr & cla
						minut += 1
						$npc['38,relation'] = 0
						!if $npc['38,qwSisterBoy'] = 9:$npc['38,qwSisterBoy'] = 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_23.jpg', func('sistersleep_strings', 'local_str9')
						act 'Отойти':gt'bedrPar'
					end
				end
			end
			act 'Ласкать себя': dynamic $sisboyQW_prycaress
			act 'Отойти': gt 'bedrPar'
		end
	end
	if $npc['38,qwSisterLesbi'] = 3 and horny >= 60 and sisprynight ! day:
		act 'Потрогать':
			*clr & cla
			minut += 1
			horny += 5
			sisprynight = day
			lesbian += 1
			gs 'stat'
			if SisterLesbiScene = 0:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_30.jpg', func('sistersleep_strings', 'local_str10')
			elseif SisterLesbiScene = 1:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_31.jpg', func('sistersleep_strings', 'local_str11')
				horny = 0
				orgasm += 1
			elseif SisterLesbiScene = 2:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_32.jpg', func('sistersleep_strings', 'local_str12')
			elseif SisterLesbiScene = 3:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_33.jpg', func('sistersleep_strings', 'local_str13')
				if anus <= 5:
					agape = 3
					gs 'zz_render', '', '', func('sistersleep_strings', 'local_str14')
				elseif anus > 5 and anus <= 10:
					if agape < 2:agape = 2
					gs 'zz_render', '', '', func('sistersleep_strings', 'local_str15')
				elseif anus > 10 and anus <= 15:
					if agape < 1: agape = 1
					gs 'zz_render', '', '', func('sistersleep_strings', 'local_str16')
				else
					gs 'zz_render', '', '', func('sistersleep_strings', 'local_str17')
				end
				if anus > 5:
					gs 'zz_render', '', '', func('sistersleep_strings', 'local_str18')
				end
				anus += 1
				lesbian+=1
				horny = 0
				if agape < 3:orgasm += 1
				agapetime = totminut + (agape + 1) * 1440
				act 'Сосать страпон':
					*clr & cla
					throat += 1
					SisterLesbiScene += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_34.jpg', func('sistersleep_strings', 'local_str19')
					act 'Отойти':gt'bedrPar'
					exit
				end
			elseif SisterLesbiScene >= 4:
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_35.jpg', func('sistersleep_strings', 'local_str20')
				$npc['38,qwSisterLesbi'] = 4
				$npc['38,qwSisterTrio'] = 0
			end
			SisterLesbiScene += 1
			gs 'stat'
			act 'Отойти': gt 'bedrPar'
		end
	end
	act 'Отойти':gt'bedrPar'
else
	act 'Отойти': gt $loc, $metka
end