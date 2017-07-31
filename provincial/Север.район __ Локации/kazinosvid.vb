$casino_svid = {
	kisvrand = RAND(0,10)
	if kisvrand > 0 and kisvrand < 3: gt'kazinosvid','1'
	if kisvrand > 2 and kisvrand < 5: gt'kazinosvid','2'
	if kisvrand = 0 or kisvrand > 4: gt'kazinosvid','3'
}
minut += 60
kisvrand = 0
manna += 10
gs 'stat'
'<center><b>Кинотеатр</b></center>'
gs 'zz_render', '', 'images/img/kazinosvid/0.jpg', func('kazinosvid_strings', 'local_str1')
act 'Играть':
	if $telsob = 'Алла':
		alla += 1
		if alla >= 20:
			dynamic $casino_svid
		elseif alla < 20:
			gt 'kazinosvid','3'
		end
	elseif $telsob = 'Маша':
		masha += 1
		if masha >= 20:
			dynamic $casino_svid
		elseif masha < 20:
			gt 'kazinosvid','3'
		end
	elseif $telsob = 'Катя':
		gs 'npc_editor','change_rep','+', 33
		if $npc['33,relation']  >= 20:
			dynamic $casino_svid
		elseif $npc['33,relation']  < 20:
			gt 'kazinosvid','3'
		end
	end
end
if $ARGS[0] = '1':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kazinosvid/0.jpg', func('kazinosvid_strings', 'local_str2')
	act 'Отказаться':gt'kazinosvid','3'
	act 'Согласиться':
		cla
		*clr
		'<center><img src="images/img/kazinosvid/'+RAND(14,15)+'.jpg"></center>'
		randkazinvsum = RAND(100,10000)
		if RAND(0,1) = 1:
			money += randkazinvsum
			gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str3')
			telsobnastr = RAND(0,10)
			if telsobnastr < 4:
				gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str4')
				act 'Закончить': gt'kazinosvid', '3'
			elseif telsobnastr > 3:
				gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str5')
				act 'Забрать <<$telsob>> и уйти': gt'kazinosvid', '3'
				act 'Утешить проигравших':
					kazsexdva = 1
					guy += 2
					gang += 1
					xgt'sexdvanadva','var'
				end
			end
		else
			gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str6')
			if money < randkazinvsum:
				gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str7')
				act 'Платить натурой':
					kazsexdva = 1
					guy += 2
					gang += 1
					xgt'sexdvanadva','var'
				end
			elseif money >= randkazinvsum:
				gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str8')
				if telsobnastr < 4:
					money -= randkazinvsum
					gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str9')
					act 'Закончить':gt'kazinosvid','3'
				elseif telsobnastr > 3:
					gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str10')
					act 'Отдать деньги, забрать <<$telsob>> и уйти':
						money -= randkazinvsum
						gt'kazinosvid','3'
					end
					act 'Воспользоваться альтернативной формой оплаты':
						kazsexdva = 1
						guy += 2
						gang += 1
						xgt'sexdvanadva','var'
					end
				end
			end
		end
	end
end
if $ARGS[0] = '2':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kazinosvid/0.jpg', func('kazinosvid_strings', 'local_str11')
	act 'Отказаться':gt'kazinosvid','3'
	act 'Согласиться':
		cla
		*clr
		gs 'zz_render', '', 'images/img/kazinosvid/3.jpg', func('kazinosvid_strings', 'local_str12')
		act 'Отказаться, забрать <<$telsob>> и уйти':gt'kazinosvid','3'
		act 'Согласиться':
			cla
			*clr
			gs 'zz_render', '', 'images/img/kazinosvid/4.jpg', func('kazinosvid_strings', 'local_str13')
			act 'Играть':
				cla
				*clr
				gs 'zz_render', '', 'images/img/kazinosvid/5.jpg', func('kazinosvid_strings', 'local_str14')
				act 'Начинать':
					guy += 1
					pikrand = 23
					kazsexdva = 1
					gt'podrsex','var'
				end
			end
		end
	end
end
if $ARGS[0] = '3':
	cla
	horny = 0
	minut += 90
	gs 'stat'
	gs 'zz_render', '', '', func('kazinosvid_strings', 'local_str15')
	act 'Уйти':gt'nord'
end