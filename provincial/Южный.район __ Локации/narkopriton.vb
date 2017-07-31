*clr & cla
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Наркопритон', 'images/pic/narkopriton.jpg', func('narkopriton_strings', 'local_str1')
if StrongNarkota >= 24:
	if snarkozak = 0:
		act 'Спросить наличие точки в Павлово': dynamic $narkozakladka
	end
	act 'Уйти':minut += 15 & dynamic $snkayf1
end
if StrongNarkota <= 23: act 'Уйти': minut += 15 & gt 'street'
if money >= 1000:
	act 'Купить дури и ширнуться':
		*clr & cla
		minut += 5
		money -= 1000
		StrongNarkota += 25
		SNarkTimes += 1
		gs 'stat'
		gs 'zz_render', '', '', func('narkopriton_strings', 'local_str2')
		act 'Уйти':gt $curloc
	end
elseif money < 1000 and SLomka > 0:
	act 'Уговаривать дать товар в долг':
		*clr & cla
		minut += 5
		gs 'stat'
		if NarkShmaraTimes > 0:
			gs 'zz_render', '', '', func('narkopriton_strings', 'local_str3')
			act 'Уйти': gt $curloc
			act 'Умолять и обещать сделать для него все что угодно':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', '', func('narkopriton_strings', 'local_str4')
				act 'Уйти': gt $curloc
				act 'Идти в комнату':
					*clr & cla
					minut += 5
					gs'stat'
					bobrand = RAND(0,4)
					if bobrand <= 2: NarkShmaraTimes += 1 & $bobtalk = 'Встань на колени и отсоси у меня.' & $bobtext = 'Отсосать'
					if bobrand = 3:NarkShmaraTimes += 1 & $bobtalk = 'Отполируй мне очко.' & $bobtext = 'Вылизывать жопу'
					if bobrand = 4:NarkShmaraTimes += 1 & $bobtalk = 'Трахаться мне не охото, но вот поссал бы я с удовольствием. Встань на колени.' & $bobtext = 'Встать на колени'
					gs 'zz_render', '', '', func('narkopriton_strings', 'local_str5')
					act 'Уйти': gt $curloc
					act '<<$bobtext>>': gt'bobka'
				end
			end
			if NarkShmaraTimes > 5:
				act 'Покориться судьбе':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/sosed/crackwhore.jpg', func('narkopriton_strings', 'local_str6')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/sosed/crackwhore2.jpg', func('narkopriton_strings', 'local_str7')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/sosed/crackwhore3.jpg', func('narkopriton_strings', 'local_str8')
							act '...':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/sosed/crackwhore4.jpg', func('narkopriton_strings', 'local_str9')
								act '...':
									*clr & cla
									gs 'zz_render', '', 'images/qwest/sosed/crackwhore5.jpg', func('narkopriton_strings', 'local_str10')
									act '...':
										*clr & cla
										gs 'zz_render', '', 'images/qwest/sosed/crackwhore6.jpg', func('narkopriton_strings', 'local_str11')
										act '...': gt 'gameover',6
									end
								end
							end
						end
					end
				end
			end
		elseif NarkShmaraTimes = 0:
			gs 'zz_render', '', '', func('narkopriton_strings', 'local_str12')
			act 'Уйти':gt $curloc
			act 'Умолять и обещать сделать для него все что угодно':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', '', func('narkopriton_strings', 'local_str13')
				act 'Уйти':gt $curloc
				act 'Идти в комнату':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', '', func('narkopriton_strings', 'local_str14')
					act 'Уйти': gt $curloc
					act 'Отсосать':
						*clr & cla
						minut += 5
						guy += 1
						bj += 1
						swallow += 1
						NarkShmaraTimes += 1
						gs 'zz_funcs', 'cum', 'lip'
						gs 'stat'
						dynamic $venerasiak
						gs 'zz_render', '', 'images/qwest/sosed/bj.jpg', func('narkopriton_strings', 'local_str15')
						act 'Ширнуться':
							*clr & cla
							minut += 5
							StrongNarkota += 25
							SNarkTimes += 1
							gs 'stat'
							gs 'zz_render', '', '', func('narkopriton_strings', 'local_str16')
							act 'Уйти':minut += 15 & dynamic $snkayf1
						end
					end
				end
			end
		end
	end
end