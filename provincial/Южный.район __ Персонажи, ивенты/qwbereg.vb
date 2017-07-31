$qwvlsexhjdy = {
	act 'Погладить его между ног рукой':
		*clr & cla
		minut += 5
		hj += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sex/hand.jpg', func('qwbereg_strings', 'local_str1')
		act 'Дрочить ему':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/qwest/sex/hand2.jpg', func('qwbereg_strings', 'local_str2')
			act '...':gt'qwbereg2'
		end
		act 'Взять в рот':
			*clr & cla
			minut += 5
			bj += 1
			gs'stat'
			gs 'zz_render', '', 'images/qwest/sex/bj.jpg', func('qwbereg_strings', 'local_str3')
			act 'Продолжать сосать':
				cla
				*clr
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_render', '', 'images/picV/swallow.jpg', func('qwbereg_strings', 'local_str4')
				act '...':gt'qwbereg2'
			end
			act 'Вынуть изо рта':
				cla
				*clr
				tiprand = RAND(0,1)
				if tiprand = 1:
					gs 'zz_render', '', 'images/picV/hand.jpg', func('qwbereg_strings', 'local_str5')
				elseif tiprand = 0:
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/facial.jpg', func('qwbereg_strings', 'local_str6')
				end
				act '...':gt'qwbereg2'
			end
		end
	end
}
minut += 30
gs'stat'
'<center><b><font color = maroon>Катер</font></b></center>'
gs 'zz_render', '', 'images/qwest/vladimir/kater.jpg', func('qwbereg_strings', 'local_str7')
act 'Сесть рядом':
	*clr & cla
	'<center><b><font color = maroon>Владимир</font></b></center>'
	gs 'zz_render', '', 'images/qwest/vladimir/001.jpg', func('qwbereg_strings', 'local_str8')
	act 'Было не плохо. Отличный катер':
		cla
		gs 'zz_render', '', '', func('qwbereg_strings', 'local_str9')
		act 'Целоваться':
			cla
			minut += 5
			horny += 10
			guy += 1
			gs'stat'
			gs 'zz_render', '', '', func('qwbereg_strings', 'local_str10')
			dynamic $qwvlsexhjdy
			act 'Наслаждаться':
				*clr & cla
				minut += 5
				horny += 15
				gs'stat'
				gs 'zz_render', '', 'images/qwest/sex/tits.jpg', func('qwbereg_strings', 'local_str11')
				dynamic $qwvlsexhjdy
				act 'Наслаждаться':
					cla
					*clr & cla
					minut += 5
					horny += 15
					DOM += 1
					kuni += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/sex/kuni.jpg', func('qwbereg_strings', 'local_str12')
					if horny >= 90:
						horny = 0
						manna += 15
						orgasm += 1
						gs 'zz_render', '', '', func('qwbereg_strings', 'local_str13')
					else
						gs 'zz_render', '', '', func('qwbereg_strings', 'local_str14')
					end
					dynamic $qwvlsexhjdy
					act 'Дать ему':
						*clr & cla
						sex += 1
						minut += 30
						pose = 0
						$boy = 'Владимир'
						dick = 16
						silavag = 1
						gs 'zz_render', '', 'images/picV/vag.jpg', func('qwbereg_strings', 'local_str15')
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
						act '...':gt'qwbereg2'
					end
				end
			end
		end
	end
end