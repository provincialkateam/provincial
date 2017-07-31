act '<B>Отойти</B>': gt $loc, $metka
sisterAge = age + 2
gs 'npc_editor','get_npc_profile',38
gs 'zz_family', 'sister_sheduler'
! sister`s today book
if reading['sister_book'] < 0: reading['sister_book'] = func('zz_books','sister_book')
if $sister['location'] = 'kuhrPar':
	minut += 1
	gs 'zz_render','','','<do>- <<$name[1]>>, некогда болтать, я спешу!</do>'
	exit
end
if $sister['location'] = 'shop':
	!на работе
	cla
	gs 'zz_render', '', '', func('sister_strings', 'local_str1')
	act '<B>Отойти</B>': gt 'shop', 'start'
	exit
end
! erotic_enable event
if $npc['38,relation'] >= 80 and hour >= 22 and (sisterknowslut + SisterKnowMastr + func('zz_books','novel_readed')) > 0 and reading['erotic_enable'] = 0:
	gt 'zz_books', 'erotic_enable'
	!exit
end
if $npc['38,qwKolka'] >= 5 and week = 7 and hour = 10 and family_trip = 0 and money >= 10000 : act '<B>Позвать в город на шопинг</B>' : gt 'sisterQW','incest_event6shop'
! walk_prepeare
if (hour = 10 or hour = 11) and week >= 6:
	*clr
	gs 'zz_render','','pavlovo/family/sister/progulka.jpg','По комнате ходит, собираясь на прогулку, ваша сестра Аня. Она любуется собой в зеркале и вертит задом, пытаясь разглядеть себя получше. Аня, не поворачиваясь к вам, говорит: <br><do>- <<$name[2]>>, если надумаешь погулять, то я после работы возле клуба с друзьями или на пляже. Или в кафешку в парке пойдём если будет дождь. С пяти до девяти вечера - я у своего.</do>'
	exit
end
! ----
gs 'dinsister', 'piercing'
! ---
if StrongNarkota = 0 and narkossister = 1 : narkosstrah = 0 & narkossister = 0
if StrongNarkota > 20 and narkossister = 0 and narkossista = 0:
	if RAND(1,100) >= 90:
		gs 'dinsister', 'narko'
		exit
	end
end
if narkossister = 1 and narkosstrah > 0:
	if StrongNarkota > 20:
		*clr & cla
		manna -= 10
		narkosstrah += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/newfear.jpg', func('sister_strings', 'local_str2')
		act '<B>Отойти</B>': gt $loc, $metka
	else
		*clr & cla
		manna -= 10
		narkosstrah = 0
		narkossister = 0
		gs 'stat'
		gs 'zz_render','','pavlovo/family/sister/newfear.jpg', func('sister_strings', 'local_str3')
		act '<B>Отойти</B>': gt $loc, $metka
	end
end
if hour >= 7 and narkossister = 0:
	if current_clothing = 0:
		if $npc['38,qwSisterLesbi'] = 0:
			gs 'zz_render', '', '', func('sister_strings', 'local_str4')
		else
			gs 'zz_render', '', '', func('sister_strings', 'local_str5')
		end
	end
	if current_clothing <= 2 and pregTalkSister = 0 and pregtime > 90:
		gs 'zz_render', '', '', func('sister_strings', 'local_str6')
		pregTalkSister = 1
	end
	if current_clothing > 2 and pregTalkSister = 0 and pregtime > 150:
		gs 'zz_render', '', '', func('sister_strings', 'local_str7')
		pregTalkSister = 1
	end
	if cumlip > 1 or cumface > 0 or cumfrot > 0 and gorslut < 3:
		sisterknowslut = 1
		gs 'zz_render', '', '', func('sister_strings', 'local_str8')
	elseif cumlip > 1 or cumface > 0 or cumfrot > 0 and gorslut >= 3 and sisterknowslut = 0:
		sisterknowslut = 1
		gs 'zz_render', '', '', func('sister_strings', 'local_str9')
	elseif cumlip > 1 or cumface > 0 or cumfrot > 0 and gorslut >= 3 and sisterknowslut > 0:
		gs 'zz_render', '', '', func('sister_strings', 'local_str10')
	end
	!Условия похода на вечеринку
	if hour = 16 or (week > 5 and hour >= 12 and hour < 16):
		gs 'sisterQW', 'meet_sister'
		exit
	end
	if $npc['38,relation'] > 65 and mesec > 0 and preg = 0 and tampon = 0 and narkossister = 0:
		act 'Попросить тампон':
			gs 'zz_render', '', '', func('sister_strings', 'local_str11')
			tampon = 3
			minut += 3
			cla
			act '<B>Отойти</B>':gt $loc, $metka
			exit
		end
	end
	if narkossister = 0:
		act 'Болтать':
			*clr & cla
			minut += rand(10,15)
			gs 'stat'
			gs 'npc_editor','get_npc_profile',38
			gs 'npc_editor','change_rep','+', 38
			!sisboyparty
			!-1 - не пошла на вечеринку
			!0 - не знает о вечеренках
			!1 - знает о вечеринках
			!2 - согласилась пойти на вечеринку
			if sisboypartyQW >= 2 and sisboyparty = 1 and week < 5:
				gs 'zz_render', '', '', func('sister_strings', 'local_str12')
				act 'Скажи, что я буду':
					*clr & cla
					minut += 5
					sisboyparty = 2
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_2.jpg', func('sister_strings', 'local_str13')
					act 'Закончить': gt 'sister'
				end
				act 'Извини, у меня учеба':
					*clr & cla
					minut += 5
					sisboyparty = -1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_3.jpg', func('sister_strings', 'local_str14')
					act 'Закончить': gt'sister'
				end
				if bronzebeg > 0 or silverbeg > 0 or goldbeg > 0:
					act 'Некогда, у меня соревнования':
						*clr & cla
						minut += 5
						sisboyparty = -1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_4.jpg', func('sister_strings', 'local_str15')
						act 'Закончить': gt'sister'
					end
				end
				if volleyboll >= 100:
					act 'У меня волейбол':
						*clr & cla
						minut += 5
						sisboyparty = -1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_5.jpg', func('sister_strings', 'local_str16')
						act 'Закончить': gt'sister'
					end
				end
				exit
			end
			act '<B>Далее</B>': gs 'stat' & gt 'sister'
			gs 'dinsister', 'talk'
		end
		gs 'KolkaPrince', 'main'
		if $npc['38,qwSisterLesbi'] = 2:
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_24.jpg', func('sister_strings', 'local_str17')
			$npc['38,qwSisterLesbi'] = 3
			act 'Закончить': gt'sister'
			exit
		end
		if $npc['38,qwSisterBoy'] = 0 and $npc['38,relation'] >= 40:
			act 'Спросить про ее парня':
				*clr & cla
				minut += 5
				gs 'npc_editor','change_rep','+', 38
				$npc['38,qwSisterBoy'] = 1
				gs 'stat'
				gs 'npc_editor','get_npc_profile',38
				gs 'zz_render', '', '', func('sister_strings', 'local_str18')
				act 'Закончить': gt 'sister'
			end
		elseif $npc['38,qwSisterBoy'] >= 2 and $npc['38,relation'] >= 40 and $npc['38,qwSisterTrio'] > -1 and sisboytrioDayOtkaz <= daystart and sisboypartyQW < 2:
			act 'Говорить о Роме':
				*clr & cla
				minut += 5
				sisboyrand = RAND(1,10)
				gs 'stat'
				!sisboyparty
				!-1 - не пошла на вечеринку
				!0 - не знает о вечеренках
				!1 - знает о вечеринках
				!2 - согласилась пойти на вечеринку
				if sisboytrio >= 5 and sisboyparty = 0 and week < 5:
					*clr & cla
					minut += 5
					sisboyparty = 1
					!sisboyparty_day = daystart
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_1.jpg', func('sister_strings', 'local_str20')
					act 'Скажи, что я буду':
						*clr & cla
						minut += 5
						sisboypartyQW = 1
						sisboyparty = 2
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_2.jpg', func('sister_strings', 'local_str21')
						act 'Закончить': gt'sister'
					end
					act 'Извини, у меня учеба':
						*clr & cla
						minut += 5
						sisboyparty = -1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_3.jpg', func('sister_strings', 'local_str22')
						act 'Закончить':gt'sister'
					end
					if bronzebeg > 0 or silverbeg > 0 or goldbeg > 0:
						act 'Некогда, у меня соревнования':
							*clr & cla
							minut += 5
							sisboyparty = -1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_4.jpg', func('sister_strings', 'local_str23')
							act 'Закончить': gt'sister'
						end
					end
					if volleyboll >= 100:
						act 'У меня волейбол':
							*clr & cla
							minut += 5
							sisboyparty = -1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_5.jpg', func('sister_strings', 'local_str24')
							act 'Закончить':gt'sister'
						end
					end
					exit
				end
				if sisboyrand >= 8 and $npc['38,qwSisterBoy'] = 2 and sisboyday ! daystart:
					gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/sisboyQW_01.jpg', func('sister_strings', 'local_str25')
					act 'Конечно':
						*clr & cla
						minut += 5
						gs 'npc_editor','change_rep','+', 38, 10
						sisThank = 1
						$npc['38,qwSisterBoy'] = 3
						sisboyday = daystart
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_03.jpg', func('sister_strings', 'local_str26')
						act 'Закончить': gt 'sister'
					end
					act 'Нет':
						*clr & cla
						gs 'npc_editor','change_rep','-', 38, 10
						minut += 5
						sisboyday = daystart
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_04.jpg', func('sister_strings', 'local_str27')
						act 'Закончить': gt'sister'
					end
				elseif sisboyrand >= 8 and ($npc['38,qwSisterBoy'] = 4 or $npc['38,qwSisterBoy'] = 6 or $npc['38,qwSisterBoy'] = 8) and sisboyday ! daystart and sisboyparty = 0:
					gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/sisboyQW_09.jpg', func('sister_strings', 'local_str28')
					act 'Конечно':
						*clr & cla
						minut += 5
						gs 'npc_editor','change_rep','+', 38, 10
						sisThank = 1
						if $npc['38,qwSisterBoy'] = 4 or $npc['38,qwSisterBoy'] = 6 or $npc['38,qwSisterBoy'] = 8:$npc['38,qwSisterBoy'] += 1
						sisboyday = daystart
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_03.jpg', func('sister_strings', 'local_str29')
						act 'Закончить': gt 'sister'
					end
					act 'Нет':
						*clr & cla
						gs 'npc_editor','change_rep','-', 38, 10
						minut += 5
						sisboyday = daystart
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_04.jpg', func('sister_strings', 'local_str30')
						act 'Закончить': gt 'sister'
					end
				elseif sisboyrand >= 8 and $npc['38,qwSisterBoy'] = 9 and $npc['38,qwSisterLesbi'] = 4 and $npc['38,qwSisterTrio'] = 0 and sisboytrio < 5:
					if sisboyday = daystart: $siboyday_text = 'завтра'
					if sisboyday + 1 = daystart: $siboyday_text = 'сегодня'
					gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/sisboyQW_09.jpg', func('sister_strings', 'local_str'+iif(sisboytrio = 0,31,32))
					act 'Согласиться':
						*clr & cla
						$npc['38,qwSisterTrio'] = 1
						minut += 5
						gs 'npc_editor','change_rep','+', 38, 10
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_36.jpg', func('sister_strings', 'local_str33')
						act 'Закончить': gt 'sister'
					end
					act 'Отказаться':
						*clr & cla
						$npc['38,qwSisterTrio'] = -1
						sisboytrioDayOtkaz = daystart + 3
						minut += 5
						$npc['38,relation'] = 0
						$npc['38,qwSisterBoy'] = 2
						sisThank = 0
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_37.jpg', func('sister_strings', 'local_str34')
						act 'Закончить': gt'sister'
					end
				else
					minut += 10
					gs 'npc_editor','change_rep','+', 38
					talkrand = RAND(0,10)
					gs 'stat'
					gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/sisboyQW_05.jpg'
					if talkrand = 0:gs 'zz_render', '', '','Вы расспрашиваете сестру про Ромку, она долго и с удовольствием говорит какой он добрый, отзывчивый и мужественный.'
					if talkrand = 1:gs 'zz_render', '', '','Анька рассказывает, как до неё Ромка встречался с какой-то мымрой, и после расставания та долго названивала ему, и из-за этого Аня сильно ругалась и ревновала.'
					if talkrand = 2:gs 'zz_render', '', '','Однажды они вместе с Ромкой были в кино, и они заметили как на последних рядах девушка сосала парню, и что Ромка предложил ей как-нибудь сделать то же самое.'
					if talkrand = 3:gs 'zz_render', '', '','Аня ругается, что Рома слишком много пьёт пива, не дарит подарки, и вообще мало уделяет ей времени.'
					if talkrand = 4:gs 'zz_render', '', '','Аня рассказывает, что Ромка предложил ей секс втроём с другой девушкой, на что она сильно обиделась и неделю не общалась с ним.'
					if talkrand = 5:gs 'zz_render', '', '','Анька в подробностях с увлечением рассказывает вам про большое достоинство Ромки, и если бы не оно, то они бы давно расстались.'
					if talkrand = 7:gs 'zz_render', '', '','Анька делится с вами по секрету, что её любимая поза "наездницей", а Ромке больше нравится "раком".'
					if talkrand = 8:gs 'zz_render', '', '','Вы говорите с сестрой на очень сокровенные темы, и она смущенно говорит, что ей не нравится глотать сперму, но Ромку это сильно заводит, и она ради него готова глотать.'
					if talkrand = 9:
						if reksLike = 0:
							reksLike = 1
							$npc['27,relation']  =  50
							$npc['38,qwRexSisTalk'] = 0
							rexPark = 0
							rexCar = 0
							gs 'zz_render', '', '', func('sister_strings', 'local_str35')
						else
							gs 'zz_render', '', '', func('sister_strings', 'local_str36')
						end
					end
					if talkrand = 10: gs 'zz_render', '', '','Аня говорит, что вы очень понравились Роме.'
					act 'Закончить': gt'sister'
				end
			end
		end
		if ((sisboyday + 1 = daystart and hour > 18) or sisboyday + 1 < daystart) and sisThank = 1:
			*clr & cla
			if $npc['38,qwSisterBoy'] = 9 or $npc['38,qwSisterBoy'] = 7 or $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 3:$npc['38,qwSisterBoy'] = $npc['38,qwSisterBoy'] - 1
			sisboyday = 0
			sisThank = 0
			gs 'stat'
			gs 'zz_render', 'Аня', 'pavlovo/family/sister/sisterQW/sisboyQW_00.jpg', func('sister_strings', 'local_str38')
			if $npc['38,qwSisterTrio'] ! 1:
				gs 'zz_render', '', '', func('sister_strings', 'local_str39')
			else
				gs 'zz_render', '', '', func('sister_strings', 'local_str40')
				$npc['38,qwSisterTrio'] = 0
			end
			act 'Закончить': gt'sister'
		end
		if SisterKnowMastr > 0 and sisterQW = 0:
			*clr & cla
			sisterQW = 1
			gs 'npc_editor','get_npc_profile',38
			gs 'zz_render', '', '', func('sister_strings', 'local_str41')
			act 'Отойти': gt $loc, $metka
		end
		if $npc['38,relation'] >= 80 and sisterknowslut > 0:
			act 'Поговорить о сексе':
				*clr & cla
				if (week < 6 and hour >= 8 and hour < 18) or (week > 5 and hour >= 11 and hour < 18):
					gs 'npc_editor','get_npc_profile',38
					gs 'zz_render', '', '', func('sister_strings', 'local_str42')
					act '<B>Отойти</B>': gt 'bedrPar'
					exit
				end
				minut += rand(10,15)
				horny += RAND(5,10)
				gs 'npc_editor','change_rep','+', 38
				gs 'stat'
				gs 'dinsister','sex_stories'
				act '<B>Отойти</B>': gt 'sister'
			end
		end
	end
else
	gs 'zz_render', '', '', func('sister_strings', 'local_str43')
end