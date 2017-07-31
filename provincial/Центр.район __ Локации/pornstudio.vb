if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/studia_0.jpg'
	act 'Уйти': gt'down'
	if hour >= 9 and hour <= 22:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str1')
		act 'Зайти к менеджеру': gt'pornstudio','man'
		act 'Зайти к помощнику менеджера': gt'pornstudio','pomman'
		if bomzQW = 1 and week = 4 and workDisk = 0: act 'Зайти на счет работы': dynamic $workbomzdi
		if workDisk = 1 and week = 5:
			act 'Взять диск':
				*clr & cla
				minut += 5
				workDisk = 2
				gs 'stat'
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str2')
				act 'Уйти': gt'down'
			end
		elseif workDisk = 3 and week = 5:
			act 'Отдать конверт':
				*clr & cla
				minut += 5
				workDisk = 4
				if konvert = 0:
					workDolg = 200000
					workDolgDay = 7
					gs 'zz_render', '', '', func('pornstudio_strings', 'local_str3')
				else
					konvert = 0
					money += 5000
					gs 'zz_render', '', '', func('pornstudio_strings', 'local_str4')
				end
				gs 'stat'
				act 'Уйти':gt'down'
			end
		end
		if workDolg > 0 and money >= workDolg:
			act 'Отдать долг':
				*clr & cla
				minut += 5
				workDisk = 0
				money -= workDolg
				workDolg = 0
				gs 'stat'
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str5')
				act 'Уйти':gt'down'
			end
		end
		if pfilmNO = 1 and pfilmNoVenera = 1 and Venera = 0:
			act 'Показать справку о излеченных венерических заболеваниях':
				*clr & cla
				minut += 5
				pfilmNoVenera = 0
				pfilmNO = 0
				gs 'stat'
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str6')
				act 'Уйти': gt'down'
			end
		end
	else
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str7')
	end
end
if $ARGS[0] = 'pomman':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('pornstudio_strings', 'local_str8')
	if pfilmSTOP = 0: act 'Какой рейтинг просмотров у моих видео ?':gt'pornstudio','myvid'
	act 'Уйти': gt'pornstudio','start'
end
if $ARGS[0] = 'myvid':
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	gs 'stat'
	if film = 0:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str9')
	elseif film > 0:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str10')
		if film < 3:'Их рейтинг пока очень низок, попросту говоря, их почти никто не смотрит."'
		if film >= 3 and film < 7:'У вас есть просмотры, но не очень много. О вас почти никто не знает.'
		if film >= 7 and film < 10:'У вас начинает появляться своя аудитория. Вы более-менее известны в узких кругах.'
		if film >= 10 and film < 15:'Ваши видео можно встретить на большинстве крупных порносайтов, а просмотры переваливают тысячные отметки.'
		if film >= 15 and film < 20:'Вы довольно известны в порно индустрии. У вас уже есть свои фанаты и поклонники.'
		if film >= 25:'Вы порно звезда!'
		if film >= 15:
			if pornhj >= 15 and pornbj < 15 and pornclassic < 15 and pornall < 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str11')
			elseif pornhj >= 15 and pornbj >= 15 and pornclassic < 15 and pornall < 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str12')
			elseif pornhj < 15 and pornbj >= 15 and pornclassic < 15 and pornall < 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str13')
			elseif pornhj < 15 and pornbj < 15 and pornclassic >= 15 and pornall < 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str14')
			elseif pornhj < 15 and pornbj < 15 and pornclassic < 15 and pornall >= 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str15')
			elseif pornhj < 15 and pornbj < 15 and pornclassic >= 15 and pornall >= 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str16')
			elseif pornhj < 15 and pornbj >= 15 and pornclassic >= 15 and pornall >= 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str17')
			elseif pornhj >= 15 and pornbj >= 15 and pornclassic >= 15 and pornall >= 15 and porngroup < 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str18')
			elseif pornhj < 15 and pornbj < 15 and pornclassic < 15 and pornall < 15 and porngroup >= 15 and porngrouphard < 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str19')
			elseif pornhj < 15 and pornbj < 15 and pornclassic < 15 and pornall < 15 and porngroup >= 15 and porngrouphard >= 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str20')
			elseif pornhj < 15 and pornbj < 15 and pornclassic < 15 and pornall < 15 and porngroup < 15 and porngrouphard >= 15:
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str21')
			else
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str22')
			end
		end
		if film < 10:
			gs 'zz_render', '', '', func('pornstudio_strings', 'local_str23')
			act 'Расспросить подробнее':gt'pornstudio','myvid2'
		end
	end
	act 'Уйти':gt'pornstudio','start'
end
if $ARGS[0] = 'myvid2':
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	films_stop_payment = film * 40000
	gs 'stat'
	gs 'zz_render', '', '', func('pornstudio_strings', 'local_str24')
	if money >= films_stop_payment:act 'Согласиться':gt'pornstudio','myvid3'
	act 'Уйти':gt'pornstudio','start'
end
if $ARGS[0] = 'myvid3':
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	money -= films_stop_payment
	pfilmSTOP = 1
	$pfilmstory_new = 'В порно индустрии вас знают под именем ' + $pfname + '. Вы снимались в порнухе ' + film + ' раз. Съемки были прекращены, все видео изъяты.'
	film = 0
	gs 'stat'
	gs 'zz_render', '', '', func('pornstudio_strings', 'local_str25')
	act 'Уйти': gt'pornstudio','start'
end
if $ARGS[0] = 'man':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/studia_0.jpg', func('pornstudio_strings', 'local_str26')
	if pfilmNO = 1:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str27')
		act 'Уйти': gt'pornstudio','start'
		exit
	end
	if pfilmSTOP = 1:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str28')
		act 'Уйти': gt'pornstudio','start'
		exit
	end
	if pfilmday = daystart and pfilm > 0:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str29')
		act 'Уйти': gt'pornstudio','start'
		exit
	elseif pfilmday >= daystart+2:
		pfilmNO = 1
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str30')
		act 'Уйти': gt'pornstudio','start'
		exit
	end
	if pfilm > 0 and hour = 10:
		pfilmday = day
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str31')
		act 'Идти на медосмотр': gt'pf','doc'
		exit
	elseif pfilm > 0 and hour = 11:
		pfilmday = day
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str32')
		act 'Идти на медосмотр': gt'pf','doc'
		exit
	elseif pfilm > 0 and hour = 12:
		pfilmday = day
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str33')
		act 'Идти на медосмотр': gt'pf','doc'
		exit
	elseif pfilm > 0 and hour > 12:
		pfilmday = day
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str34')
		act 'Сам работай за бесплатно придурок':
			pfilmNO = 1
			pfilm = 0
			gt 'pornstudio','start'
		end
		act 'Ладно, отработаю за бесплатно':
			pfilmNOPAY = 1
			gt 'pornstudio','start'
		end
		exit
	end
	if film = 0 and firstkasting = 0:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str35')
		act 'Я передумала':gt'pornstudio','start'
		act 'Да':
			cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', '', func('pornstudio_strings', 'local_str36')
			if age < 18:
				*clr & cla
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str37')
				act 'Уйти': gt 'down'
				exit
			end
			gs 'zz_render', '', '', func('pornstudio_strings', 'local_str38')
			act 'Я передумала': gt 'pornstudio','start'
			act 'Раздеться':
				cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str39')
				act 'Я передумала': gt'pornstudio','start'
				act 'Лечь на диван и раздвинуть ноги':
					cla
					gs 'zz_render', '', '', func('pornstudio_strings', 'local_str40')
					act 'Встать на колени':
						cla
						gs 'zz_render', '', '', func('pornstudio_strings', 'local_str41')
						act 'Открыть рот и высунуть язык':
							cla
							gs 'zz_render', '', '', func('pornstudio_strings', 'local_str42')
							act 'Сосать палец':
								cla
								gs 'zz_render', '', '', func('pornstudio_strings', 'local_str43')
								act 'Назвать псевдоним':
									cla
									minut += 10
									gs 'stat'
									firstkasting = 1
									$pfname = input ("Какой у вас будет псевдоним в порнофильмах?")
									if $pfname <= 0:$pfname = '<<$name[1]>> Хуесоскина'
									gs 'zz_render', '', '', func('pornstudio_strings', 'local_str44')
									act '...':gt'pornstudio','man'
								end
							end
						end
					end
				end
			end
		end
	elseif film = 0 and firstkasting = 1 and pfilm = 0:
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str45')
		act 'Согласиться':
			cla
			pfilm = 1
			pfilmday = daystart
			gs 'zz_render', '', '', func('pornstudio_strings', 'local_str46')
			act 'Уйти': gt'pornstudio','start'
		end
		act 'Я передумала': gt'pornstudio','start'
	elseif film > 0:
		if daystart > pffilmday and pfilm = 0:
			gs 'zz_render', '', '', func('pornstudio_strings', 'local_str47')
			frand = RAND(1,6)
			if frand = 1:'Работа ручками, нужно подорочить парню и он спускает на груди. 2 тысячи.'
			if frand = 2:'Сделать минет парню, с окончанием в рот и на лицо. 3 тысяч.'
			if frand = 3:'Классика, сначала минет, потом секс с окончанием в рот и на лицо. 5 тысяч.'
			if frand = 4:'Жесткая классика, сначала минет, потом секс, потом анал и окончание в рот и на лицо. 6 тысяч.'
			if frand = 5:'Групповуха с двумя парнями, во все дыры, но без двойного проникновения. 7 тысяч.'
			if frand = 6:'Групповуха с двумя парнями, с двойным проникновением. 9 тысяч.'
			act 'Пожалуй подожду более подходящего предложения':
				pffilmday = daystart+1
				gt'pornstudio','start'
			end
			act 'Согласиться':
				cla
				pfilm = frand
				pfilmday = daystart
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str46')
				act 'Уйти':gt'pornstudio','start'
			end
		else
			if pffilmday-daystart > 0:
				$talkpsno = 'Приходи через <<pffilmday-daystart>> дней'
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str49')
			elseif pffilmday-daystart = 0:
				$talkpsno = 'Приходи завтра'
				gs 'zz_render', '', '', func('pornstudio_strings', 'local_str49')
			end
			act 'Уйти':gt'pornstudio','start'
		end
	else
		gs 'zz_render', '', '', func('pornstudio_strings', 'local_str51')
		act 'Уйти':gt'pornstudio','start'
	end
end
if $ARGS[0] = '1':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/city/center/studia/Pierre_1.jpg', func('pornstudio_strings', 'local_str52')
	act 'Изложить цель вашего визита':
		if age >= 18:
			*clr & cla
			minut += 60
			gs 'zz_render', '', 'images/city/center/studia/Pierre_2.jpg', func('pornstudio_strings', 'local_str53')
			act 'Раздеться':
				*clr & cla
				gs 'zz_render', '', 'images/city/center/studia/casting_3.jpg', func('pornstudio_strings', 'local_str54')
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/city/center/studia/model_0.jpg', func('pornstudio_strings', 'local_str55')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/city/center/studia/Film_0.jpg', func('pornstudio_strings', 'local_str56')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/city/center/studia/dvd-disс.jpg', func('pornstudio_strings', 'local_str57')
							act 'Всё ясно, а как и где это всё продаётся? Может, захочу посмотреть на себя...':
								*clr & cla
								gs 'zz_render', '', 'images/city/center/studia/Pierre_2.jpg', func('pornstudio_strings', 'local_str58')
								act 'А какие-то проблемы с законом?':
									*clr & cla
									gs 'zz_render', '', 'images/city/center/studia/ment_0.jpg', func('pornstudio_strings', 'local_str59')
									act 'Ну вроде как всё поняла':
										*clr & cla
										pornstudio = 3
										gs 'zz_render', '', 'images/city/center/studia/Pierre_2.jpg', func('pornstudio_strings', 'local_str60')
										gt'pornstudio','start'
									end
								end
							end
						end
					end
				end
			end
		else
			*clr & cla
			gs 'zz_render', '', 'images/city/center/studia/Pierre_2.jpg', func('pornstudio_strings', 'local_str61')
			act 'Уйти': gt 'down'
		end
	end
end