if $args[0] = 'start' or $args[0] = '':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Дом культуры имени Ленина', 'images/pic/dk.jpg', func('dk_strings', 'local_str1')
	if hour >= 9 and hour <= 20: act 'Идти в дом культуры': gt 'dk', 'hall'
	if avtoskul >= 1 and avtoskul < 11 and skulday ! day and week >= 6 and money >= 1000:
		act 'Учиться на права за отдельную плату (1000 руб 2 часа)':
			*clr & cla
			money -= 1000
			skulday = day
			avtoskul += 1
			minut += 120
			gs 'zz_render', '', 'images/pic/dk2.jpg', func('dk_strings', 'local_str2')
			act 'Уйти': gt 'dk'
		end
	end
	act 'Уйти': gt 'nord'
end
if $args[0] = 'hall':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if vokalday ! day and hour >= 10 and hour <= 19: act 'Кружок пения': gt 'dk','song_club'
	! --
	gs 'zz_render', 'Дом культуры', 'images/pic/dk1.jpg', func('dk_strings','local_str3')
	if money >= 1000:
		act 'Курсы личностного роста (1 тыс.руб)':
			*clr & cla
			money -= 1000
			dom += 5
			minut += 60
			gs 'stat'
			gs 'zz_render', '', '', func('dk_strings', 'local_str4')
			act 'Уйти': gt 'dk','hall'
		end
	end
	! паспотный стол
	if hour >= 9 and hour <= 14 and week < 6:
		act 'Паспортный стол':
			$loc = $curloc
			$metka = $args[0]
			gt 'zz_passport_stol', 'start'
		end
	end
	if secrDiplom = 0 and sekrObu > 0:sekrObuA = sekrObu - 1 & 'Обучались на секретаря <<sekrObuA>> дней из 10'
	if hour >= 9 and hour <= 20 and week < 6:
		if age => 18 and spravka_prava = 1 and prava = 0:
			act 'Поменять справку на права':
				cla
				*clr
				spravka_prava = 0
				prava = 1
				minut += 30
				gs 'zz_render','','','Вы отдаёте сотруднику ГИБДД справку об успешной сдаче экзамена на права и говорите что вам уже исполнилось 18 лет. Сотрудник ищет вас в базе данных и кивает. Вас фотографируют и выдают готовые права. Теперь вы можете управлять автомобилем.'
				act 'Уйти':gt 'dk','hall'
			end
		end
		if avtoskul = 0 and money >= 30000 and prava = 0 and spravka_prava = 0:
			act 'Оплатить обучение на права (30 тыс.руб)':
				cla
				money -= 30000
				avtoskul = 1
				!'<center><img src="images/pic/dk2.jpg"></center>'
				gs 'zz_render', '', '', func('dk_strings', 'local_str27')
				act 'Уйти':gt 'dk','hall'
			end
		end
		if secrDiplom = 0 and sekrObu = 0 and money >= 15000:
			act 'Оплатить обучение на секретаря (15 тыс.руб)':
				cla
				money -= 15000
				sekrObu = 1
				!'<center><img src="images/pic/dk2.jpg"></center>'
				gs 'zz_render', '', '', func('dk_strings', 'local_str28')
				act 'Уйти':gt 'dk','hall'
			end
		end
		if sekrObu > 0 and sekrObu < 11 and secrday ! day:
			act 'Учиться на секретаря (2 часа)':
				cla
				*clr
				secrday = day
				sekrObu += 1
				minut += 120
				gs 'zz_render', '', 'images/pic/kurs.jpg', func('dk_strings', 'local_str29')
				if cumfrot > 0: horny += 10 & 'Вы нервно возитесь на стуле стараясь скрыть пятно спермы на своей попе, но кажется от этого только хуже. На вас начали обращать внимание другие ученицы.'
				act 'Уйти':gt 'dk','hall'
			end
		elseif sekrObu >= 11 and secrday ! day:
			act 'Получить диплом секретаря':
				cla
				*clr
				secrday = day
				sekrObu = 0
				minut += 15
				secrDiplom = 1
				gs 'zz_render', '', 'images/pic/kurs.jpg', func('dk_strings', 'local_str30')
				act 'Уйти':gt 'dk','hall'
			end
		end
		if avtoskul >= 1 and avtoskul < 11 and skulday ! day:
			act 'Учиться на права (2 часа)':
				cla
				*clr
				skulday = day
				avtoskul += 1
				minut += 120
				gs 'zz_render', '', 'images/pic/dk2.jpg', func('dk_strings', 'local_str31')
				act 'Уйти': gt 'dk','hall'
			end
		elseif avtoskul >= 11 and skulday ! day:
			act 'Сдать на права 2 часа':
				cla
				*clr
				minut += 120
				avtoskul = 0
				minut += 120
				gs 'zz_render','','images/pic/dk3.jpg','Вы ездили с сотрудником ГИБДД в течение 2х часов по городу, он остался удовлетворен и даже не нашел к чему придраться.'
				act 'Уйти': gt 'dk','hall'
				if age >= 18:
					gs 'zz_render','','','Вас фотографируют и выдают готовые права. Теперь вы можете управлять автомобилем.'
					prava = 1
					else
					gs 'zz_render','','','Вам говорят, что так как вы не достигли возраста 18 лет выдать вам права нельзя. Поэтому вы получаете справку об успешной сдаче экзамена. Вы можете обменять эту справку на права когда вам исполнится 18 лет.'
					spravka_prava = 1
				end
			end
		end
		if money >= 1000 and masash < 10 and masashshoolday ! day:
			act 'Учиться массажу':
				cla
				masashshoolday = day
				money -= 1000
				masash += 1
				minut += 120
				gs'stat'
				gs 'zz_render', '', '', func('dk_strings', 'local_str32')
				if masash = 10:gs 'zz_render', '', '','Вам выдали сертификат об окончании курсов массажистов.'
				act 'Уйти':gt 'dk','hall'
			end
		end
	end
	act 'Уйти':gt'nord'
end
if $args[0] = 'song_club':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Дом культуры', 'images/pic/dk1.jpg'
	! --- ветка Сони ---
	if (hour = 18 or hour = 19) and $npc['25,qwSonya']>0:
		! ГГ приходит в разведку в ДК
		if (week = 1 or week = 3) and $npc['25,qwSonya'] = 25: gt 'sonya','meet_in_dk'
		! ГГ приходит поболтать с руководителем по поводу оплаты
		if $npc['25,qwSonya'] = 55 and $npc['25,qwSonya_day'] ! day: gt 'sonya','talk_with_teacher'
		! еженедельная оплата
		if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] <= 255 and $npc['25,qwSonya_payday'] > 0:
			act 'Оплатить кружок Сони натурой': gt 'sonya','payment_bj'
			act 'Заплатить 1000 руб за кружок Сони': gt 'sonya','payment_money'
		end
		if $npc['25,qwSonya'] = 90 and $npc['25,qwSonya_demo'] < daystart: act 'Забрать демо': gt 'sonya','take_demo'
		gs 'zz_render','','city/north/dk/hall'
		act 'Назад': gt 'dk','hall'
		!if (week < 6 and (hour >= 9 and hour <= 14)) or (week >= 6 and (hour >= 12 and hour <= 18)):
		!	act 'Студия звукозаписи':
		!		*clr & cla
		!		gs 'zz_render','Студия звукозаписи','city/north/dk/sound'
		!		!if $npc['25,qwSonya'] = 85:
		!		!
		!		!end
		!		act 'Назад': gt 'dk','song_club'
		!	end
		!end
	end
	! ------------------
	!-----------
	if vokalday ! day and alexeySex > 0 and alexeyVopros = 2:
		act 'Идти на уроки вокала':
			*clr & cla
			alexeyQW += 1
			vokal += 1
			vokalday = day
			horny += 30
			gs 'stat'
			gs 'zz_render', '', '', func('dk_strings', 'local_str5')
			if RAND(0,10) >= 8:
				gs 'zz_render', '', '', func('dk_strings', 'local_str6')
				act 'Встать на колени и взять в рот':
					*clr & cla
					alexeySex += 1
					horny += 10
					bj += 1
					minut += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alexey/bj'+RAND(0,13)+'.jpg', func('dk_strings', 'local_str7')
					act 'Подставить рот':
						*clr & cla
						horny += 10
						minut += 10
						swallow += 1
						cumlip += 1
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alexey/bjcum'+RAND(0,13)+'.jpg', func('dk_strings', 'local_str8')
						act 'Уйти':gt 'dk','hall'
					end
				end
			else
				gs 'zz_render', '', '', func('dk_strings', 'local_str9')
				if sashaClubQW = 0: act 'Идти': gt'alex'
				if sashaClubQW > 0:
					act 'Идти':
						if rand(0,10) >= 8:
							gt'alexgang'
						else
							gt'alex'
						end
					end
				end
			end
		end
	elseif money >= 500 and vokalday ! day and alexeySex > 0 and alexeyVopros = 1:
		act 'Идти на уроки вокала (500 рублей 1 час)':
			*clr & cla
			money -= 500
			alexeyQW += 1
			vokal += 1
			vokalday = day
			gs 'stat'
			gs 'zz_render', '', '', func('dk_strings', 'local_str10')
			act 'Уйти':gt 'dk','hall'
		end
	elseif money >= 500 and vokalday ! day and alexeySex > 0 and alexeyVopros = 0:
		act 'Идти на уроки вокала (500 рублей 1 час)':
			*clr & cla
			alexeyQW += 1
			vokal += 1
			vokalday = day
			gs'stat'
			gs 'zz_render', '', '', func('dk_strings', 'local_str11')
			act 'Давай забудем, что между нами что-то было':
				*clr & cla
				money -= 500
				alexeyVopros = 1
				gs 'zz_render', '', '', func('dk_strings', 'local_str12')
				act 'Уйти':gt 'dk','hall'
			end
			act 'Если не будешь так напиваться, то мы могли бы попробовать еще раз':
				*clr & cla
				alexeyVopros = 2
				gs 'zz_render', '', '', func('dk_strings', 'local_str13')
				act 'Уйти':gt 'dk','hall'
			end
		end
	elseif money >= 500 and vokalday ! day and alexeySex = 0:
		act 'Идти на уроки вокала (500 рублей 1 час)':
			*clr & cla
			minut += 60
			money -= 500
			alexeyQW += 1
			vokal += 1
			vokalday = day
			gs'stat'
			!'<center><img src="images/pic/dk2.jpg"></center>'
			if alexeyQW = 1:
				gs 'zz_render', '', '', func('dk_strings', 'local_str14')
			!elseif alexeyQW = 2:
			elseif alexeyQW >= 2 and alexeyQW < 10:
				horny += 10
				gs 'zz_render', '', '', func('dk_strings', 'local_str15')
			!elseif alexeyQW >= 3 and alexeyQW < 7:
			elseif alexeyQW >= 10 and alexeyQW < 15:
				horny += 10
				gs 'zz_render', '', '', func('dk_strings', 'local_str16')
			!elseif alexeyQW >= 7:
			elseif alexeyQW >= 15 and alexeyQW < 20:
				horny += 20
				gs 'zz_render', '', '', func('dk_strings', 'local_str17')
			!elseif alexeyQW = 10 and alexeyVQW = 0:
			elseif alexeyQW >= 20:
				!Ну типа как повезет
				if rand(100) <= 5:
				!вероятность наверно 5%
					gs 'zz_render', '', '', func('dk_strings', 'local_str18')
				else
					gs 'zz_render', '', '', func('dk_strings', 'local_str19')
					act 'Пойти с Алексеем':
						*clr & cla
						gs 'zz_render', '', '', func('dk_strings', 'local_str20')
						act 'Уйти':gt'nord'
						act 'Идти к Алексею домой':
							*clr & cla
							!alexeyVQW += 1
							minut += 120
							gs'stat'
							gs 'zz_render', '', '', func('dk_strings', 'local_str21')
							act 'Встать на колени и взять в рот':
								*clr & cla
								guy += 1
								alexeySex = 1
								horny += 10
								bj += 1
								minut += 10
								gs'stat'
								gs 'zz_render', '', 'images/qwest/alexey/bj0.jpg', func('dk_strings', 'local_str22')
								act 'Раздеться':
									*clr & cla
									minut += 10
									$boy = 'Алексей'
									dick = 20
									silavag = 2
									pose = 1
									gs 'stat'
									gs 'zz_render', '', 'images/qwest/alexey/sex.jpg', func('dk_strings', 'local_str23')
									gs 'zz_dynamic_sex', 'sex_start'
									gs 'zz_render', '', '', func('dk_strings', 'local_str24')
									gs 'zz_dynamic_sex', 'vaginal', 'dick'
									gs 'zz_render', '', '', func('dk_strings', 'local_str25')
									act 'Стонать':
										*clr & cla
										minut += 10
										$boy = 'Алексей'
										dick = 20
										silavag = 2
										pose = 1
										gs 'stat'
										'<center><img src="images/qwest/alexey/anal.jpg"></center>'
										gs 'zz_dynamic_sex', 'anal_start', 'dick'
										gs 'zz_dynamic_sex', 'anal', 'dick'
										gs 'zz_dynamic_sex', 'anal_cum'
										gs 'zz_render', '', '', func('dk_strings', 'local_str26')
										act 'Уйти':gt'nord'
									end
								end
							end
						end
					end
				end
			end
			act 'Уйти':gt 'dk','hall'
		end
	else
		if vokalday = day:
			gs 'zz_render', '', '', 'Вы сегодня уже были на уроке пения. Приходите в другой день.'
		elseif money < 500:
			gs 'zz_render', '', '', 'Уроки пения стоят 500 рублей за час. У вас нет таких денег сейчас.'
		end
		act 'Уйти':gt'nord'
	end
end