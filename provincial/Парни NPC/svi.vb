if $ARGS[0] = 'poor':
	minut += 20
	if Venera >= 3:
		bfA = 0
		gs 'zz_render', '', '', func('svi_strings', 'local_str1')
		act 'Уйти': gt 'street'
		exit
	end
	if sweat > 1:
		!вспотели
		bfA -= 1
		if harakBoyA = 0:'<<$boyA>> говорит вам, что у него появились срочные дела.'
		if harakBoyA = 1:'<<$boyA>> брезгливо морщит нос и говорит вам, что у него появились срочные дела.'
		if harakBoyA = 2:'<<$boyA>> говорит вам, что вам не мешало бы помыться.'
		if harakBoyA = 3:'<<$boyA>> говорит вам, что у неё появились срочные дела.'
		if harakBoyA = 4:'<<$boyA>> брезгливо морщит нос и говорит вам, что у неё появились срочные дела.'
		if harakBoyA = 5:'<<$boyA>> говорит вам, что вам не мешало бы помыться.'
		act 'Уйти': gt 'street'
		exit
	end
	if harakBoyA > 0 and izvrat = 0 and (cumface > 0 or cumlip > 0):
		bfA = 0
		gs 'zz_render', '', '', func('svi_strings', 'local_str2')
		act 'Уйти': gt 'street'
		exit
	end
	if daya < 10 and boyonceA = 0:
		!конфетно букетный период
		vstrand = RAND(0,2)
		if vstrand = 0:
			gs 'zz_render', '', '', func('svi_strings', 'local_str3')
			act 'Погулять в парке':
				cla
				minut += 60
				bfA += 1
				gs 'zz_render', '', '', func('svi_strings', 'local_str4')
				act 'Пригласить к себе':
					cla
					if dayA < 3:bfA -= 1
					gt'svidan','kvartA'
				end
				act 'Попрощаться и идти домой':
					bfA += 1
					gt 'street'
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		elseif vstrand = 1:
			gs 'zz_render', '', '', func('svi_strings', 'local_str5')
			act 'Пойти в кинотеатр':
				cla
				minut += 60
				bfA += 1
				gs 'zz_render', '', '', func('svi_strings', 'local_str6')
				act 'Обнять его руку':
					cla
					bfA += 1
					gs 'zz_render', '', '', func('svi_strings', 'local_str7')
					act 'Пригласить к себе':
						if dayA < 3:bfA -= 1
						gt 'svidan','kvartA'
					end
					act 'Попрощаться и идти домой':
						bfA += 1
						gt 'street'
					end
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		else
			gs 'zz_render', '', '', func('svi_strings', 'local_str8')
			act 'Пить пиво':
				cla
				minut += 20
				gs 'zz_funcs', 'alko'
				bfA += 1
				gs 'zz_render', '', '', func('svi_strings', 'local_str9')
				act 'Пригласить к себе':
					cla
					if dayA < 3:bfA -= 1
					gt 'svidan','kvartA'
				end
				act 'Попрощаться и идти домой':
					bfA += 1
					gt 'street'
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		end
	elseif daya >= 10 and boyonceA = 0:
		gs 'zz_render', '', '', func('svi_strings', 'local_str10')
		act 'Расстаться':
			bfA = 0
			gt 'street'
		end
		act 'Согласиться на секс':
			*clr & cla
			minut += 20
			gs 'zz_render', '', '', func('svi_strings', 'local_str11')
			act 'Пойти в вашу квартиру':gt'svidan','kvartA'
			act 'Пойти в кусты':gt'svidan','kustA'
		end
		exit
	end
	if dayA > 15:gs'boylove','haer'
	if dayA > 30:gs'boylove','figure'
	if dayA > 60:gs'boylove','tits'
	if boyonceA > 0:
		gs 'zz_render', '', '', func('svi_strings', 'local_str12')
		act 'Потусить':
			cla
			minut += 20
			bfA += 1
			gs 'zz_funcs', 'alko'
			gs 'zz_render', '', '', func('svi_strings', 'local_str13')
			act 'Пойти в вашу квартиру':gt'svidan','kvartA'
			act 'Пойти в кусты':gt'svidan','kustA'
		end
		act 'Отказаться':
			bfA -= 1
			gt 'street'
		end
	end
end
if $ARGS[0] = 'norm':
	minut += 20
	if Venera >= 3:
		bfA = 0
		gs 'zz_render', '', '', func('svi_strings', 'local_str14')
		act 'Уйти': gt 'street'
		exit
	end
	if sweat > 1:
		!вспотели
		bfA -= 1
		if harakBoyA = 0:'<<$boyA>> говорит вам, что у него появились срочные дела.'
		if harakBoyA = 1:'<<$boyA>> брезгливо морщит нос и говорит вам, что у него появились срочные дела.'
		if harakBoyA = 2:'<<$boyA>> говорит вам, что вам не мешало бы помыться.'
		act 'Уйти': gt 'street'
		exit
	end
	if harakBoyA >0 and izvrat = 0 and (cumface > 0 or cumlip > 0):
		bfA = 0
		gs 'zz_render', '', '', func('svi_strings', 'local_str15')
		act 'Уйти': gt 'street'
		exit
	end
	if daya < 10 and boyonceA = 0:
		!конфетно букетный период
		vstrand = RAND(0,2)
		if vstrand = 0:
			gs 'zz_render', '', '', func('svi_strings', 'local_str16')
			act 'Пойти в кафе':
				cla
				minut += 60
				bfA += 1
				body['day_weight'] += 1
				cumlip = 0
				gs 'zz_render', '', '', func('svi_strings', 'local_str17')
				act 'Пригласить к себе':
					cla
					if dayA < 3:bfA -= 1
					gt'svidan','kvartA'
				end
				act 'Попрощаться и идти домой':
					bfA += 1
					gt 'street'
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		elseif vstrand = 1:
			gs 'zz_render', '', '', func('svi_strings', 'local_str18')
			act 'Пойти в кинотеатр':
				cla
				minut += 60
				bfA += 1
				gs 'zz_render', '', '', func('svi_strings', 'local_str19')
				act 'Обнять его руку':
					cla
					bfA += 1
					gs 'zz_render', '', '', func('svi_strings', 'local_str20')
					act 'Пригласить к себе':
						cla
						if dayA < 3:bfA -= 1
						gt'svidan','kvartA'
					end
					act 'Попрощаться и идти домой':
						bfA += 1
						gt 'street'
					end
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		else
			gs 'zz_render', '', '', func('svi_strings', 'local_str21')
			act 'Гулять':
				cla
				minut += 60
				bfA += 1
				gs 'zz_render', '', '', func('svi_strings', 'local_str22')
				act 'Пригласить к себе':
					cla
					if dayA < 3:bfA -= 1
					gt'svidan','kvartA'
				end
				act 'Попрощаться и идти домой':
					bfA += 1
					gt 'street'
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		end
	elseif daya >= 10 and boyonceA = 0:
		gs 'zz_render', '', '', func('svi_strings', 'local_str23')
		act 'Расстаться':
			bfA = 0
			gt 'street'
		end
		act 'Согласиться на секс':
			*clr & cla
			minut += 20
			gs 'zz_render', '', '', func('svi_strings', 'local_str24')
			act 'Пойти в вашу квартиру':gt'svidan','kvartA'
			act 'Пойти в его машину':gt'svidan','carA'
		end
		exit
	end
	if dayA > 12 and skin < 2:bfA -= 1
	if dayA > 12:gs'boylove','haer'
	if dayA > 24:gs'boylove','figure'
	if dayA > 48:gs'boylove','tits'
	if dayA > 22 and glaraz < 1:bfA -= 1
	if dayA > 40 and lip < 1:bfA -= 1
	if boyonceA > 0:
		gs 'zz_render', '', '', func('svi_strings', 'local_str25')
		act 'В кафе':
			cla
			minut += 60
			body['day_weight'] += 1
			bfA += 1
			gs 'zz_render', '', '', func('svi_strings', 'local_str26')
			act 'Пойти в вашу квартиру':gt'svidan','kvartA'
			act 'Пойти в его машину':gt'svidan','carA'
		end
		act 'Отказаться':
			bfA -= 1
			gt 'street'
		end
	end
end
if $ARGS[0] = 'reach':
	minut += 20
	if Venera >= 3:
		bfA = 0
		gs 'zz_render', '', '', func('svi_strings', 'local_str27')
		act 'Уйти': gt 'street'
		exit
	end
	if sweat > 1:
		!вспотели
		bfA -= 1
		if harakBoyA = 0:'<<$boyA>> говорит вам, что у него появились срочные дела.'
		if harakBoyA = 1:'<<$boyA>> брезгливо морщит нос и говорит вам, что у него появились срочные дела.'
		if harakBoyA = 2:'<<$boyA>> говорит вам, что вам не мешало бы помыться.'
		act 'Уйти': gt 'street'
		exit
	end
	if harakBoyA > 0 and izvrat = 0 and (cumface > 0 or cumlip > 0):
		bfA = 0
		gs 'zz_render', '', '', func('svi_strings', 'local_str28')
		act 'Уйти': gt 'street'
		exit
	end
	if dayA > 5 and skin < 3:bfA -= 1
	if dayA > 10:gs'boylove','haer'
	if dayA > 20:gs'boylove','figure'
	if dayA > 30:gs'boylove','tits'
	if dayA > 10 and glaraz < 2:bfA -= 1
	if dayA > 6 and lip < 2:bfA -= 1
	if dayA > 8 and resnic < 1:bfA -= 1
	if daya < 10 and boyonceA = 0:
		!конфетно букетный период
		vstrand = RAND(0,2)
		if vstrand = 0:
			gs 'zz_render', '', '', func('svi_strings', 'local_str29')
			act 'Пойти в кафе':
				cla
				minut += 60
				body['day_weight'] += 1
				bfA += 1
				cumlip = 0
				gs 'zz_render', '', '', func('svi_strings', 'local_str30')
				act 'Пригласить к себе':
					cla
					if dayA < 3:bfA -= 1
					gt'svidan','kvartA'
				end
				act 'Попрощаться и идти домой':
					bfA += 1
					gt 'street'
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		elseif vstrand = 1:
			gs 'zz_render', '', '', func('svi_strings', 'local_str31')
			act 'Пойти в кинотеатр':
				cla
				minut += 60
				bfA += 1
				gs 'zz_render', '', '', func('svi_strings', 'local_str32')
				act 'Обнять его руку':
					cla
					bfA += 1
					gs 'zz_render', '', '', func('svi_strings', 'local_str33')
					act 'Пригласить к себе':
						cla
						if dayA < 3:bfA -= 1
						gt'svidan','kvartA'
					end
					act 'Попрощаться и идти домой':
						bfA += 1
						gt 'street'
					end
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		elseif vstrand = 2:
			gs 'zz_render', '', '', func('svi_strings', 'local_str34')
			act 'Пойти в ресторан':
				cla
				minut += 60
				body['day_weight'] += 1
				bfA += 1
				cumlip=0
				gs 'zz_render', '', '', func('svi_strings', 'local_str35')
				act 'Пригласить к себе':
					cla
					if dayA < 3:bfA -= 1
					gt'svidan','kvartA'
				end
				act 'Попрощаться и идти домой':
					bfA += 1
					gt 'street'
				end
			end
			act 'Отказаться':
				bfA -= 1
				gt 'street'
			end
		end
	elseif daya >= 10 and boyonceA = 0:
		gs 'zz_render', '', '', func('svi_strings', 'local_str36')
		act 'Расстаться':
			bfA = 0
			gt 'street'
		end
		act 'Согласиться на секс':
			*clr & cla
			minut += 20
			gs 'zz_render', '', '', func('svi_strings', 'local_str37')
			act 'Пойти в вашу квартиру':gt'svidan','kvartA'
			act 'Поехать к нему':gt'svidan','hisA'
		end
		exit
	elseif boyonceA > 0:
		gs 'zz_render', '', '', func('svi_strings', 'local_str38')
		act 'В кафе':
			cla
			minut += 60
			body['day_weight'] += 1
			bfA += 1
			cumlip=0
			gs 'zz_render', '', '', func('svi_strings', 'local_str39')
			act 'Пойти в вашу квартиру':gt'svidan','kvartA'
			act 'Пойти к нему':gt'svidan','hisA'
		end
		act 'Отказаться':
			bfA -= 1
			gt 'street'
		end
	end
end