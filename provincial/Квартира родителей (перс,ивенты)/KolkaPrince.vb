$KPimgpath = 'pavlovo/family/brother/KolkaPrince/KolkaPrince_'
if $ARGS[0] = 'main_1':
	if $curloc = 'kuhrPar':
		if $npc['39,qwKolkaPrince'] = 0 and func('zz_reputation','get') = 0 and (month >= 9 or month <= 5) and hour = 7: gt 'KolkaPrince', 'KolkaPrince_0'
	end
	if $curloc = 'zz_brother' and $brother['location'] = 'sitrPar' and $npc['39,qwKolkaPrince'] = 1:
		act 'Поговорить о поведении': gt 'KolkaPrince', 'KolkaPrince_1'
		!!! Выпилить TEST_WANN после окончания тестирования
		act 'TEST_WANN: Просмотр порно после уроков = 15': $npc['39,qwPornoFootball'] = 15
		act 'TEST_WANN: Секс с братом += 1': $npc['39,sex'] += 1
		act 'TEST_WANN: Внешность = 40': vnesh = 40
		act 'TEST_WANN: Отношения Прохоров = 100': $npc['3,relation'] = 100
		act 'TEST_WANN: Отношения Котов = 100': $npc['9,relation'] = 100
	end
	if $curloc = 'sister' and $npc['39,qwKolkaPrince'] = 2 and $npc['38,relation'] > 40:
		act 'Поговорить о занятих Коли': gt 'KolkaPrince', 'KolkaPrince_2'
		!!! Выпилить TEST_WANN после окончания тестирования
		act 'TEST_WANN: Отношения с сестрой = 100':$npc['38,relation'] = 100
		act 'TEST_WANN: Доминантность = 100': dom = 100
		act 'TEST_WANN: Секс с сестрой = 3': $npc['38,qwSisterLesbi'] = 3
	end
	if $curloc = 'zz_brother' and $npc['39,qwKolkaPrince'] = 3:
		act 'Рассказать о договорённости с Аней': gt 'KolkaPrince', 'KolkaPrince_3'
		act 'TEST_WANN: Ноут = 1': komp = 1
	end
	if $curloc = 'zz_brother' and $brother['location'] = 'bedrPar' and (hour >= 17 and hour <= 20):
		act 'Поболтать': gt 'KolkaPrince', 'KolkaPrince_4'
	end
	if $curloc = 'zz_brother' and $npc['39,qwKolkaPrince'] >= 2 and brother['SayBoksDay'] ! day and brother['SayBoksKotov'] = 0 and brother['SayBoksProhorov'] = 0:
		act 'Спросить про секцию бокса':
			*clr & cla
			gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str56')
			brother['SayBoksProhorov'] = 1
			brother['SayBoksKotov'] = 1
			act '<b>Отойти</b>': gt $loc, $metka
		end
	end
end
if $ARGS[0] = 'KolkaStats':
!!! Выпилить TEST_WANN после окончания тестирования
!act 'TEST_WANN: Увеличить силу Коли на 10': BrotherStats['Sila'] += 10
!act 'TEST_WANN: Увеличить интеллект Коли на 10': BrotherStats['Intel'] += 10
!act 'TEST_WANN: Увеличить бокс на 1': BrotherStats['Box'] += 1
	gs 'zz_render', '', '', '<br><br>По настоянию матери вы постоянно оцениваете прогресс Коли:<br>'
	if BrotherStats['Sila'] < 50:
		$SilaTemp = func('KolkaStats_strings', 'local_str1')
		elseif BrotherStats['Sila'] >= 50 and BrotherStats['Sila'] < 75:
		$SilaTemp = func('KolkaStats_strings', 'local_str2')
		elseif BrotherStats['Sila'] >= 75 and BrotherStats['Sila'] < 90:
		$SilaTemp = func('KolkaStats_strings', 'local_str3')
		elseif BrotherStats['Sila'] >= 90:
		$SilaTemp = func('KolkaStats_strings', 'local_str4')
	end
	if BrotherStats['Intel'] < 40:
		$IntelTemp = func('KolkaStats_strings', 'local_str5')
		elseif BrotherStats['Intel'] >= 40 and BrotherStats['Intel'] < 50:
		$IntelTemp = func('KolkaStats_strings', 'local_str6')
		elseif BrotherStats['Intel'] >= 50 and BrotherStats['Intel'] < 60:
		$IntelTemp = func('KolkaStats_strings', 'local_str7')
		elseif BrotherStats['Intel'] >= 60 and BrotherStats['Intel'] < 70:
		$IntelTemp = func('KolkaStats_strings', 'local_str8')
		elseif BrotherStats['Intel'] >= 70 and BrotherStats['Intel'] < 80:
		$IntelTemp = func('KolkaStats_strings', 'local_str9')
		elseif BrotherStats['Intel'] >= 80 and BrotherStats['Intel'] < 90:
		$IntelTemp = func('KolkaStats_strings', 'local_str10')
		elseif BrotherStats['Intel'] >= 90:
		$IntelTemp = func('KolkaStats_strings', 'local_str11')
	end
	if BrotherStats['Box'] = 0:
		$BoxTemp = func('KolkaStats_strings', 'local_str17')
		elseif BrotherStats['Box'] = 1:
		$BoxTemp = func('KolkaStats_strings', 'local_str12')
		elseif BrotherStats['Box'] = 2:
		$BoxTemp = func('KolkaStats_strings', 'local_str13')
		elseif BrotherStats['Box'] = 3:
		$BoxTemp = func('KolkaStats_strings', 'local_str14')
		elseif BrotherStats['Box'] = 4:
		$BoxTemp = func('KolkaStats_strings', 'local_str15')
		elseif BrotherStats['Box'] >= 5:
		$BoxTemp = func('KolkaStats_strings', 'local_str16')
	end
	'<table border="1" width="100%">
		<tr>
		<td><b>Физическое развитие:</b></td>
		<td><<$SilaTemp>></td>
		</tr>
		<tr>
		<td><b>Интеллект:</b></td>
		<td><<$IntelTemp>></td>
	 </tr>
		<tr>
		<td><b>Разряд в боксе:</b></td>
		<td><<$BoxTemp>></td>
	 </tr>
	</table>'
	killvar '$SilaTemp'
	killvar '$IntelTemp'
	killvar '$BoxTemp'
end
if $ARGS[0] = 'KolkaPrince_0':
	*clr & cla
	gs 'zz_render', '', 'КартинкаВП_001', func('KolkaPrince_strings', 'local_str1')
	gs 'zz_render', '', '', func('KolkaPrince_strings', 'local_str2')
	gs 'zz_render', '', '', func('KolkaPrince_strings', 'local_str3')
	gs 'zz_render', '', '', func('KolkaPrince_strings', 'local_str4')
	$npc['39,qwKolkaPrince'] = 1
	act '<b>Доесть и выйти</b>': gt 'korrPar'
end
if $ARGS[0] = 'KolkaPrince_1':
	*clr & cla
	gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str5')
	if func('zz_reputation','get') ! 0 or $npc['39,qwPornoFootball'] => 10:
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str6')
		$npc['39,qwKolkaPrince'] = -1
		gs 'npc_editor','change_rep','-'
		$npc['39,relation'] = 0
		act '<b>Отойти</b>': gt 'sitrPar'
	else
		act '<b>Отойти</b>': gt 'sitrPar'
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str7')
		if $npc['39,sex'] > 0:
			act 'Настаивать':
				*clr & cla
				gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str8')
				if vnesh < 60:
					gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str9')
					$npc['39,qwKolkaPrince'] = -1
					gs 'npc_editor','change_rep','-'
					$npc['39,relation'] = 0
					act '<b>Отойти</b>': gt 'sitrPar'
				else
					gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str10')
					act '<b>Дальше</b>':
						*clr & cla
						gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str11')
						gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str12')
						gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str13')
						gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str14')
						gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str15')
						gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str16')
						if $npc['3,relation'] > 90 and $npc['9,relation'] > 90:
							gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str19')
							brother['SayBoksProhorov'] = 1
							brother['SayBoksKotov'] = 1
						elseif $npc['3,relation'] > 90 and $npc['9,relation'] < 90:
							gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str17')
							brother['SayBoksProhorov'] = 1
						elseif $npc['3,relation'] < 90 and $npc['9,relation'] > 90:
							gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str18')
							brother['SayBoksKotov'] = 1
						end
						brother['SayBoksDay'] = day
						$npc['39,qwKolkaPrince'] = 2
						BrotherStats['Sila'] = 20
						BrotherStats['Intel'] = 10
						BrotherStats['Box'] = 0
						act '<b>Отойти</b>': gt 'sitrPar'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'KolkaPrince_2':
	*clr & cla
	gs 'zz_render','Аня','images/qwest/alter/sister/sister.jpg', func('KolkaPrince_strings', 'local_str20')
	if $npc['38,relation'] < 80:
		if brother['SisterSayDay'] ! day:
			gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str21')
			brother['SisterSayDay'] = day
		else
			gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str27')
			gs 'npc_editor','change_rep','-', 38
		end
	else
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str22')
		act 'Настаивать':
		*clr & cla
		act '<b>Отойти</b>': gt $loc, $metka
			if dom < 80:
				gs 'zz_render','Аня','images/qwest/alter/sister/sister.jpg', func('KolkaPrince_strings', 'local_str23')
				gs 'npc_editor','change_rep','-', 38
			else
				gs 'zz_render','Аня','images/qwest/alter/sister/sister.jpg', func('KolkaPrince_strings', 'local_str24')
				$npc['39,qwKolkaPrince'] = 3
			end
		end
		act 'Упрашивать':
		*clr & cla
		act '<b>Отойти</b>': gt $loc, $metka
			if $npc['38,qwSisterLesbi'] < 3:
				gs 'zz_render','Аня','images/qwest/alter/sister/sister.jpg', func('KolkaPrince_strings', 'local_str25')
				gs 'npc_editor','change_rep','-', 38
				act '<b>Отойти</b>': gt $loc, $metka
			else
				gs 'zz_render','Аня','images/qwest/alter/sister/sister.jpg', func('KolkaPrince_strings', 'local_str26')
				gs 'npc_editor','change_rep','+', 38
				$npc['39,qwKolkaPrince'] = 3
			end
		end
	end
	act '<b>Отойти</b>': gt $loc, $metka
end
if $ARGS[0] = 'KolkaPrince_3':
	gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str28')
	gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str29')
	if komp = 1:
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str30')
		else
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str31')
	end
	gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str32')
	$npc['39,qwKolkaPrince'] = 4
	act '<b>Отойти</b>': gt $loc, $metka
end
if $ARGS[0] = 'KolkaPrince_4':
	if brother['PrinceLearnDay'] = day:
		gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str55')
		act '<b>Отойти</b>': gt $loc, $metka
	else
		minut += rand(10,15)
		gs 'npc_editor','change_rep','+', 39
		gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str33')
		if rand(0,2) > 0:
			gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str34')
			act '<b>Отойти</b>': gt $loc, $metka
		else
			gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str35')
			act 'Отказать':
				cla
				gs 'stat'
				gs 'npc_editor','change_rep','-'
				gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str36')
				act '<b>Отойти</b>': gt $loc, $metka
			end
			act 'Помочь':
				*clr & cla
				gs 'stat'
				minut += rand(10,15)
				act '<b>Отойти</b>': gt $loc, $metka
				if horny < 80:
					gs 'npc_editor','change_rep','+', 39
					brother['PrinceLearn'] += 1
					gs 'zz_render', '','<<$KPimgpath>>001.webm', func('KolkaPrince_strings', 'local_str37')
				else
					*clr & cla
					brother['PrinceLearn'] -= 1
					brother['PrinceLearnDay'] = day
					gs 'zz_render', '','<<$KPimgpath>>002.webm', func('KolkaPrince_strings', 'local_str38')
					if hour > 17:
						act '<b>Отойти</b>': gt $loc, $metka
					elseif hour = 17:
						gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str40')
						act 'Продолжить':
							minut += 5
							*clr & cla
							gs 'zz_render', '','<<$KPimgpath>>006.webm', func('KolkaPrince_strings', 'local_str41')
							act 'Последовать за ним':
								*clr & cla
								gs 'zz_render', '','<<$KPimgpath>>007.webm', func('KolkaPrince_strings', 'local_str42')
								act 'Заглянуть':
									*clr & cla
									gs 'zz_render', '','<<$KPimgpath>>008.jpg', func('KolkaPrince_strings', 'local_str43')
									act 'Зайти и помочь':
										*clr & cla
										minut += 5
										bj += 1
										gs 'npc_editor','change_rep','+', 39
										gs 'zz_render', '','<<$KPimgpath>>009.webm', func('KolkaPrince_strings', 'local_str45')
										gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str44')
										act '<b>Отойти</b>': gt $loc, $metka
									end
									act 'Вернуться в комнату':
										*clr & cla
										gs 'KolkaPrince', 'KolkaPrince_4_room', 1
									end
								end
								act 'Зайти':
									*clr & cla
									minut += 5
									bj += 1
									gs 'npc_editor','change_rep','+', 39
									gs 'zz_render', '','<<$KPimgpath>>009.webm', func('KolkaPrince_strings', 'local_str44')
									act '<b>Отойти</b>': gt $loc, $metka
								end
								act 'Вернуться в комнату':
									gs 'KolkaPrince', 'KolkaPrince_4_room', 2
								end
							end
							act 'Остаться в комнате': gs 'KolkaPrince', 'KolkaPrince_4_room'
						end
						act 'Сесть ему на колени':
							*clr & cla
							gs 'zz_render', '','<<$KPimgpath>>004.webm', func('KolkaPrince_strings', 'local_str54')
							act 'Далее':
								*clr & cla
								minut += rand(10,15)
								bj += 1
								gs 'zz_render', '','<<$KPimgpath>>005.jpg', func('KolkaPrince_strings', 'local_str39')
								act '<b>Отойти</b>': gt $loc, $metka
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'KolkaPrince_4_room':
	*clr & cla
	gs 'zz_render', '','<<$KPimgpath>>010.webm',''
	if ARGS[1] = 1:
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str47')
	elseif ARGS[1] = 2:
		gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str45')
	end
	gs 'zz_render', '','', func('KolkaPrince_strings', 'local_str48')
	act 'Почитать учебный материал':
		*clr & cla
		minut += rand(10,15)
		gs 'npc_editor','change_rep','-', 39
		gs 'zz_render', '','<<$KPimgpath>>011.webm', func('KolkaPrince_strings', 'local_str49')
		act '<b>Отойти</b>': gt $loc, $metka
	end
	act 'Сбросить напряжение':
	*clr & cla
	gs 'zz_render', '','<<$KPimgpath>>012.jpg', func('KolkaPrince_strings', 'local_str50')
		act 'Прекратить':
			*clr & cla
			minut += 5
			gs 'npc_editor','change_rep','-', 39
			gs 'zz_render', 'Колька','images/qwest/alter/brother.jpg', func('KolkaPrince_strings', 'local_str51')
			act '<b>Отойти</b>': gt $loc, $metka
		end
		act 'Продолжить':
			*clr & cla
			minut += 5 & mastr += 1 & horny = 0 & orgasm += 1
			gs 'zz_render', '','<<$KPimgpath>>014.gif', func('KolkaPrince_strings', 'local_str52')
			act '<b>Отойти</b>': gt $loc, $metka
		end
		act 'Позвать':
			*clr & cla
			minut += 5 & kuni += 1 & horny = 0 & orgasm += 1
			gs 'npc_editor','change_rep','+', 39
			gs 'zz_render', '','<<$KPimgpath>>013.webm', func('KolkaPrince_strings', 'local_str53')
			act '<b>Отойти</b>': gt $loc, $metka
		end
	act '<b>Отойти</b>': gt $loc, $metka
	end
end
if $ARGS[0] = 'KolkaPrince_5':
end