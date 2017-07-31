minut += 60
bilrand = 0
manna += 10
bilsvidukiy = 0
bilsvidkiy = 0
$bil_svid_rand = {
	bilrand = RAND(0,10)
	if bilrand > 0 and bilrand < 3: gt'billsvid','1'
	if bilrand > 2 and bilrand < 5: gt'billsvid','2'
	if bilrand = 0 or bilrand > 4: gt'billsvid','3'
	killvar 'bilrand'
}
gs'stat'
'<center><b>Бильярдная</b></center>'
gs 'zz_render', '', 'images/img/bilsvid/0.jpg', func('billsvid_strings', 'local_str1')
act 'Играть':
	if $telsob = 'Алла':
		alla += 1
		if alla >= 20:
			dynamic $bil_svid_rand
		elseif alla < 20:
			gt 'billsvid','3'
		end
	elseif $telsob = 'Маша':
		masha += 1
		if masha >= 20:
			dynamic $bil_svid_rand
		elseif masha < 20:
			gt 'billsvid','3'
		end
	elseif $telsob = 'Катя':
		gs 'npc_editor','change_rep','+', 33
		if $npc['33,relation'] >= 20:
			dynamic $bil_svid_rand
		elseif $npc['33,relation'] < 20:
			gt 'billsvid','3'
		end
	end
end
if $ARGS[0] = '1':
	cla
	*clr
	gs 'zz_render', '', 'images/img/bilsvid/1.jpg', func('billsvid_strings', 'local_str2')
	act 'Не сейчас <<$telsob>>':gt'billsvid','3'
	act 'Поцеловать её':
		cla
		*clr
		lesbian += 1
		gs 'zz_render', '', 'images/img/bilsvid/2.jpg', func('billsvid_strings', 'local_str3')
		act 'Сделать ей куни':gt'billsvid','10'
		act 'Куни':gt'billsvid','11'
	end
end
if $ARGS[0] = '10':
	cla
	*clr
	gs 'zz_render', '', 'images/img/bilsvid/4.jpg', func('billsvid_strings', 'local_str4')
	act 'Куни':gt'billsvid','11'
	if bilsvidkiy = 0:act 'Поиграть с кием':gt'billsvid','12'
	if bilsvidukiy = 0:act 'Попросить её поиграть с кием':gt'billsvid','13'
end
if $ARGS[0] = '11':
	cla
	*clr
	gs 'zz_render', '', 'images/img/bilsvid/3.jpg', func('billsvid_strings', 'local_str5')
	act 'Сделать ей куни':gt'billsvid','10'
	if bilsvidkiy = 0:act 'Поиграть с кием':gt'billsvid','12'
	if bilsvidukiy = 0:act 'Попросить её поиграть с кием':gt'billsvid','13'
end
if $ARGS[0] = '12':
	cla
	*clr
	bilsvidkiy = 1
	gs 'zz_render', '', 'images/img/bilsvid/6.jpg', func('billsvid_strings', 'local_str6')
	if bilsvidukiy = 0:act 'Попросить её поиграть с кием':gt'billsvid','13'
	act 'Закончить':gt'billsvid','3'
end
if $ARGS[0] = '13':
	cla
	*clr
	orgasm += 1
	vagina += 1
	bilsvidukiy = 1
	gs 'zz_render', '', 'images/img/bilsvid/5.jpg', func('billsvid_strings', 'local_str7')
	if bilsvidkiy = 0:act 'Поиграть с кием':gt'billsvid','12'
	act 'Закончить':gt'billsvid','3'
end
if $ARGS[0] = '2':
	cla
	*clr
	gs 'zz_render', '', 'images/img/bilsvid/10.jpg', func('billsvid_strings', 'local_str8')
	act 'Продолжить играть':gt'billsvid','3'
	act 'Поцеловать её':
		cla
		*clr
		lesbian += 1
		gs 'zz_render', '', 'images/img/bilsvid/11.jpg', func('billsvid_strings', 'local_str9')
		act 'Продолжить':
			cla
			*clr
			gs 'zz_render', '', 'images/img/bilsvid/12.jpg', func('billsvid_strings', 'local_str10')
			act 'Полизать её':
				cla
				*clr
				gs 'zz_render', '', 'images/img/bilsvid/13.jpg', func('billsvid_strings', 'local_str11')
				act 'Продолжить':
					cla
					*clr
					gs 'zz_render', '', 'images/img/bilsvid/14.jpg', func('billsvid_strings', 'local_str12')
					act 'Дать её полизать':
						cla
						*clr
						gs 'zz_render', '', 'images/img/bilsvid/15.jpg', func('billsvid_strings', 'local_str13')
						act 'Полизать её':
							cla
							*clr
							orgasm += 1
							gs 'zz_render', '', 'images/img/bilsvid/16.jpg', func('billsvid_strings', 'local_str14')
							act 'Закончить':gt'billsvid','3'
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = '3':
	cla
	horny = 0
	minut += 60
	gs'stat'
	gs 'zz_render', '', '', func('billsvid_strings', 'local_str15')
	act 'Уйти':gt'torgcentr'
end