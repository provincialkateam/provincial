$dinBistroWork[0] = {
	act 'Обедать':
		*clr & cla
		gs 'zz_kitchen_acts', 'eat','',func('burgerWork_strings', 'local_str1')
		gs 'zz_kitchen_acts', 'drink', 'tea'
		gs 'stat'
		dynamic $dinBistroWork3
	end
}
$dinBistroWork[1] = {
	act 'Уйти с работы':
		*clr & cla
		gs 'stat'
		if kompromatBlackMail >= 6 and ivanFilmBJ > 0:
			kobl2 = 2
		elseif kompromatBlackMail >= 6 and ivanFilmBJ = 0:
			kobl2 = 2
		elseif kompromatBlackMail < 6:
			kobl2 = 1
		end
		komblrand = RAND(0,kobl2)
		if kompromatBlackMail >= 2:
			if komblrand = 0:
				gs 'zz_render', '', '', func('burgerWork_strings', 'local_str5')
				act 'Согласиться':
					*clr & cla
					bj += 1
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					kompromatBlackMail += 1
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/sosed/ivanBJ.jpg', func('burgerWork_strings', 'local_str6')
					act 'Уйти':gt'down'
				end
				dynamic $din_Ivan_work4
			elseif komblrand = 1:
				gs 'zz_render', '', '', func('burgerWork_strings', 'local_str7')
				act 'Согласиться':
					*clr & cla
					bj += 1
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					kompromatBlackMail += 1
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/sosed/ivanBJcar.jpg', func('burgerWork_strings', 'local_str8')
					act 'Уйти':gt'down'
				end
				dynamic $din_Ivan_work4
			elseif komblrand = 2:
				gs 'zz_render', '', '', func('burgerWork_strings', 'local_str9')
				act 'Согласиться':
					*clr & cla
					kompromatBlackMail += 1
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'images/maggot/car.jpg', func('burgerWork_strings', 'local_str10')
					act 'Сосать':
						*clr & cla
						minut += 5
						bj += 1
						ivanFilmBJ += 1
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/sosed/ivanBJfilm.jpg', func('burgerWork_strings', 'local_str11')
						act 'Сосать':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/sosed/ivanBJfilm2.jpg', func('burgerWork_strings', 'local_str12')
							act 'Открыть рот':
								*clr & cla
								minut += 5
								gs 'zz_funcs', 'cum', 'face'
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/sosed/ivanBJfilm3.jpg', func('burgerWork_strings', 'local_str13')
								act 'Уйти':cumface = 0 & gt'nord'
							end
						end
					end
					dynamic $din_Ivan_work4
				end
				dynamic $din_Ivan_work4
			end
			exit
		end
		gt'burger','start'
	end
}
$dinBistroWork3 = {
	act 'Работать':
		*clr & cla
		PSBBtimes = 2
		minut += 60*3
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/work.jpg', func('burgerWork_strings', 'local_str14')
		dynamic $burger_work_din
		dynamic $dinBistroWork[1]
	end
}
if hour < 10: hour = 10 & minut = 0 & PersSecWorkTimes += 1
gs 'BurgerTip'
gs 'stat'
gs 'zz_render', '', 'images/qwest/sosed/work.jpg', func('burgerWork_strings', 'local_str15')
if hour < 17:
	act 'Работать до обеда':
		*clr & cla
		PSBBtimes = 1
		minut += 60*2
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/sosed/work.jpg', func('burgerWork_strings', 'local_str16')
		if TerminalPapper = 1:
			TerminalPapper = 0
			gs 'zz_render', '', '', func('burgerWork_strings', 'local_str17')
		elseif TerminalPapper = 2:
			TerminalPapper = 0
			gs 'zz_render', '', '', func('burgerWork_strings', 'local_str18')
		end
		if BankPapper = 1:
			BankPapper = 0
			gs 'zz_render', '', '', func('burgerWork_strings', 'local_str19')
		elseif BankPapper = 2:
			BankPapper = 0
			gs 'zz_render', '', '', func('burgerWork_strings', 'local_str20')
		end
		if BuSWworkEnd = 1 or kompromatBlackMail = 1:
			gs 'zz_render', '', '', func('burgerWork_strings', 'local_str21')
			act 'Писать заявление о увольнении':
				*clr & cla
				work = 0
				PersSecWork = 2
				Pay = PersSecWorkTimes*2500
				PersSecWorkTimes = 0
				money += Pay
				gs 'stat'
				gs 'zz_render', '', '', func('burgerWork_strings', 'local_str22')
				act 'Уйти': gt'down'
			end
			exit
		end
		dynamic $burger_work_din
		dynamic $dinBistroWork
	end
end
!Анатолий Борисович директор
!бойкая девушка менеджер по персоналу, отдел кадров
!менеджер Иван, игрок, мот и рисковый парень
!заместитель менеджера, прыщавый мальчишка, сын хозяина Быстроежки