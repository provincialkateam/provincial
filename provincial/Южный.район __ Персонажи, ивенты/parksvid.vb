minut += 60
manna += 10
gs'stat'
'<center><b>Парк</b></center>'
gs 'zz_render', '', 'images/img/parksvid/0.jpg', func('parksvid_strings', 'local_str1')
act 'Идти гулять':
	if $telsob = 'Алла':
		alla += 1
		if alla >= 20:
			parksvidrand = RAND(0,5)
			if parksvidrand > 0 and parksvidrand < 3:
				gt'parksvid','1'
			elseif parksvidrand >= 3:
				gt'parksvid','3'
			end
		elseif alla < 20:
			gt'parksvid','3'
		end
	end
	if $telsob = 'Маша':
		masha += 1
		if masha >= 20:
			parksvidrand = RAND(0,10)
			if parksvidrand > 0 and parksvidrand < 3:
				gt'parksvid','1'
			elseif parksvidrand >= 3:
				gt'parksvid','3'
			end
		elseif masha < 20:
			gt'parksvid','3'
		end
	end
	if $telsob = 'Катя':
		gs 'npc_editor','change_rep','+', 33
		if $npc['33,relation'] >= 20:
			parksvidrand = RAND(0,10)
			if parksvidrand > 0 and parksvidrand < 3:
				gt'parksvid','1'
			elseif parksvidrand >= 3:
				gt'parksvid','3'
			end
		elseif $npc['33,relation'] < 20:
			gt'parksvid','3'
		end
	end
end
if $ARGS[0] = '1':
	cla
	*clr
	gs 'zz_render', '', 'images/img/parksvid/1.jpg', func('parksvid_strings', 'local_str2')
	act 'Идти дальше':gt'parksvid','3'
	act 'Посмотреть что он делает':
		cla
		*clr
		gs 'zz_render', '', 'images/img/parksvid/2.jpg', func('parksvid_strings', 'local_str3')
		act 'Отказаться и пойти гулять дальше':gt'parksvid','3'
		act 'Пойти с ней':
			cla
			*clr
			gs 'zz_render', '', 'images/img/parksvid/3.jpg', func('parksvid_strings', 'local_str4')
			act 'Отказаться и пойти гулять дальше':gt'parksvid','3'
			act 'Пойти к парню':
				cla
				*clr
				orgasm += 1
				lesbian += 1
				minut += 30
				gs 'zz_render', '', 'images/img/parksvid/4.jpg', func('parksvid_strings', 'local_str5')
				act 'Дальше':
					cla
					*clr
					gs 'zz_render', '', 'images/img/parksvid/5.jpg', func('parksvid_strings', 'local_str6')
					act 'Дальше':
						cla
						*clr
						gs 'zz_render', '', 'images/img/parksvid/6.jpg', func('parksvid_strings', 'local_str7')
						act 'Уйти':gt'parksvid','3'
					end
				end
			end
		end
	end
end
if $ARGS[0] = '3':
	cla
	horny = 0
	minut += 90
	gs'stat'
	gs 'zz_render', '', '', func('parksvid_strings', 'local_str8')
	act 'Уйти':gt'zz_park','main'
end