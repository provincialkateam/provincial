$gopsexboy1 = {
	cla
	if VasanTut = 3:
		$guygop = 'Васян'
		if vasansex = 0:vasansex = 1 & guy += 1
	end
	if BerezaTut = 3:
		if berezasex = 0:berezasex = 1 & guy += 1
		$guygop = 'Береза'
	end
	if VitekTut = 3:
		if viteksex = 0:viteksex = 1 & guy += 1
		$guygop = 'Витек'
	end
	if KostilTut = 3:
		if kostilsex = 0:kostilsex = 1 & guy += 1
		$guygop = 'Костыль'
	end
	if UdmurtTut = 3:
		if udmurtsex = 0:udmurtsex = 1 & guy += 1
		$guygop = 'Удмурт'
	end
	if SeriTut = 3:
		if serisex = 0:serisex = 1 & guy += 1
		$guygop = 'Серый'
	end
	act 'Дать':gt'gopnew','1'
	act 'Сосать':gt'gopnew','11'
	act 'Дать в попу':gt'gopnew','12'
}
if $ARGS[0] = 'start':
	'<center><b>ДВОР У ДОМА</b></center>'
	gs 'zz_render', '', 'images/pic/dvor.jpg', func('gopnew_strings', 'local_str1')
	gtalkrand = RAND(0,10)
	if gtalkrand = 0:$goptalk = 'вафлерша'
	if gtalkrand = 1:$goptalk = 'вафельница'
	if gtalkrand = 2:$goptalk = 'шкварная'
	if gtalkrand = 3:$goptalk = 'шлюха'
	if gtalkrand = 4:$goptalk = 'тварина'
	if gtalkrand = 5:$goptalk = 'соска'
	if gtalkrand = 6:$goptalk = 'овца'
	if gtalkrand = 7:$goptalk = 'шмара'
	if gtalkrand = 8:$goptalk = 'шалава'
	if gtalkrand = 9:$goptalk = 'хуесоска'
	if gtalkrand = 10:$goptalk = 'блядушка'
	gtalkrand = RAND(0,10)
	if gtalkrand = 0:$goptalk2 = 'сколько сегодня хуев отсосала?'
	if gtalkrand = 1:$goptalk2 = 'хочешь на клыка взять?'
	if gtalkrand = 2:$goptalk2 = 'у тебя струхня на ебале.'
	if gtalkrand = 3:$goptalk2 = 'че молчишь? Полный рот кончи набрала?'
	if gtalkrand = 4:$goptalk2 = 'а тебе в рот уже ссали? Или нет?'
	if gtalkrand = 5:$goptalk2 = 'какое дупло у тебя больше? Задница или пизда?'
	if gtalkrand = 6:$goptalk2 = 'я из толчка вышел, а задницу вытереть забыл, подлижешь язычком?'
	if gtalkrand = 7:$goptalk2 = 'иди ко мне, прокачу на волосатом мотороллере.'
	if gtalkrand = 8:$goptalk2 = 'ты в рот берушка? Или в жопу попрошайка?'
	if gtalkrand = 9:$goptalk2 = 'хочешь в рот нассу, чтоб морем пахло?'
	if gtalkrand = 10:$goptalk2 = 'тебе нравится струхню слизывать?'
	gs'gopwho'
	gs'goplust'
	if opusk > 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str2')
		act 'Ждать пока подойдут гопники':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str3')
			if gopopusday ! day:
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str4')
				if money >= 2000:
					act 'Отдать деньги':
						cla
						money -= 2000
						gopopusday = day
						gs 'zz_render', '', '', func('gopnew_strings', 'local_str5')
						act 'Уйти':gt'street'
						if GLust > 0:
							cla
							gs 'zz_render', '', '', func('gopnew_strings', 'local_str6')
							act 'Идти с гопниками':gt'gopnew','sexstart'
						end
					end
				else
					act 'Ребята, пожалуйста, у меня нет денег':
						cla
						gs 'zz_render', '', '', func('gopnew_strings', 'local_str7')
						act 'В машину':gt'gopnew','degrading'
					end
				end
			elseif gopopusday = day:
				if GLust > 0:
					cla
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str8')
					act 'Идти с гопниками':gt'gopnew','sexstart'
				else
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str9')
					act 'Уйти':gt'street'
				end
			end
		end
		act 'Сделать вид, что вы их не заметили':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str10')
			if gopopusday = day:
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str11')
				act 'Забежать в квартиру':gt'street'
			elseif gopopusday ! day:
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str12')
				if money >= 2000:
					act 'Отдать деньги':
						cla
						money -= 2000
						gopopusday = day
						gs 'zz_render', '', '', func('gopnew_strings', 'local_str13')
						act 'Уйти':gt'street'
						if GLust > 0:
							cla
							gs 'zz_render', '', '', func('gopnew_strings', 'local_str14')
							act 'Идти с гопниками':gt'gopnew','sexstart'
						end
					end
				else
					act 'Ребята, пожалуйста, у меня нет денег':
						cla
						gs 'zz_render', '', '', func('gopnew_strings', 'local_str15')
						act 'В машину':gt'gopnew','degrading'
					end
				end
			end
		end
		exit
	end
	if sipovka > 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str16')
		if GLust > 0:
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str17')
			act 'Идти с гопниками':gt'gopnew','sexstart'
			act 'Уйти':gt'street'
		else
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str18')
			act 'Уйти':gt'street'
		end
		exit
	end
	if rosetka > 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str19')
		if GLust > 0:
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str20')
			act 'Идти с гопниками':gt'gopnew','sexstart'
			act 'Уйти':gt'street'
		else
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str21')
			act 'Уйти':gt'street'
		end
		exit
	end
	if loh > 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str22')
		if gopdolg > 0 and gopdaydolg > daystart:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str23')
		elseif gopdolg > 0 and gopdaydolg <= daystart:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str24')
			if money >= gopdolg:
				act 'Оплатить':
					cla
					money -= gopdolg
					gopdolg = 0
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str25')
					act 'Уйти':gt'street'
				end
			else
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str26')
				act 'Встать на колени перед гопником':gt'gopnew','rapebj'
			end
			exit
		end
		act 'Уйти':gt'street'
		exit
	end
	if gnewQW = 4:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str27')
		act 'Хотелось бы, но я спешу':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str28')
			act 'Попить пивасика':gt'gopnew','pivas'
			act 'Идти':gt'street'
		end
		act 'Попить пивасика':gt'gopnew','pivas'
	elseif gnewQW = 3:
		gopota += 5
		gnewQW = 4
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str29')
		act 'Уйти':gt'street'
	elseif gnewQW = 2:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str30')
		act 'Хотелось бы пивка, но я спешу':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str31')
			act 'Попить пивасика':gt'gopnew','pivas'
			act 'Уйти':gt'street'
		end
		act 'Попить пивасика':gt'gopnew','pivas'
		act 'Идти на делюгу':
			*clr
			cla
			'<center><img src="images/pic/park.jpg"></center>'
			goprandwork = RAND(1,100)
			if goprandwork < 75:
				cla
				minut += 60
				gopota += 1
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str32')
				act 'Идти домой':gt'street'
			elseif goprandwork >= 75 and goprandwork < 95:
				cla
				gopstop += 1
				gopota += 1
				minut += 60
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str33')
				act 'Идти домой':gt'street'
			elseif goprandwork >= 95:
				cla
				gopstop += 1
				gopota += 1
				minut += 60
				randmon = RAND(50,500)
				money += randmon
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str34')
				act 'Идти домой':gt'street'
			end
		end
	elseif gnewQW = 1:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str35')
		act 'Хотелось бы, но я спешу':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str36')
			act 'Попить пивасика':gt'gopnew','pivas'
			act 'Идти':gt'street'
		end
		act 'Попить пивасика':gt'gopnew','pivas'
	elseif gnewQW = 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str37')
		act 'Попить пивасика':gt'gopnew','pivas'
		act 'Нет':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str38')
			act 'Ладно, пойдем попьем пиво':gt'gopnew','pivas'
			act 'Я же сказала, нет':
				cla
				*clr
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str39')
				act 'Ладно, пойдем попьем пиво':gt'gopnew','pivas'
				act 'Отвали от меня':
					cla
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str40')
					act 'Сопротивляться':
						cla
						gs 'zz_render', '', '', func('gopnew_strings', 'local_str41')
						act 'Чего тебе от меня надо?':gt'gopnew','bazar'
					end
					act 'Подчиниться':
						cla
						gs 'zz_render', '', '', func('gopnew_strings', 'local_str42')
						act 'Чего тебе от меня надо?':gt'gopnew','bazar'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'pivas':
	minut += 30
	gs'stat'
	'<center><b>ДВОР У ДОМА</b></center>'
	gs 'zz_render', '', 'images/pic/dvor.jpg', func('gopnew_strings', 'local_str43')
	if cumface > 0 or cumlip > 0 or cumfrot > 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str44')
		act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
		exit
	end
	if gnewQW > 0:
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str45')
		if film > 0:
			pfknowrand = RAND(0,100)
			if film >= pfknowrand:filmknow = 1
		end
		if filmknow = 1:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str46')
			act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
			exit
		end
		if kavslut >= 3:
			kavknowrand = RAND(0,100)
			if kavknowrand >= 95:kavslutknow = 1
		end
		if kavslutknow = 1:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str47')
			act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
			exit
		end
		if frot >= 3:
			frotknowrand = RAND(0,100)
			if frot >= frotknowrand:frotknow = 1
		end
		if frotknow = 1:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str48')
			act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
			exit
		end
	elseif gnewQW = 0:
		gnewQW = 1
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str49')
		if film > 0 and film >= RAND(0,100):
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str50')
			act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
			exit
		end
		if kavslut >= 3 and RAND(0,100) >= 95:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str51')
			act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
			exit
		end
		if frot >= 3 and RAND(0,100) >= 95:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str52')
			act 'Идти в подворотню с пацанами':gt'gopnew','bazar'
			exit
		end
	end
	gopota += 1
	gs 'zz_render', '', '', func('gopnew_strings', 'local_str54')
	if gnewQW > 1:
		if VasanTut = 2 or BerezaTut = 2 or VitekTut = 2 or KostilTut = 2 or UdmurtTut = 2 or SeriTut = 2:gt'gopnew','sexstart'
	end
	act 'Идти':gt'street'
end
if $ARGS[0] = 'bazar':
	gs 'zz_render', '', '', func('gopnew_strings', 'local_str55')
	act 'Согласна':
		cla
		*clr
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str56')
		act 'Я не сука!':
			cla
			*clr
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str57')
			act 'Да':
				cla
				*clr
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str58')
				act 'Встать на колени перед гопником':gt'gopnew','rapebj'
				act 'Отказаться':
					cla
					*clr
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str59')
					act 'Встать на колени перед гопником':gt'gopnew','rapebj'
				end
			end
			act 'Нет':
				cla
				*clr
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str60')
				act 'Встать на колени перед гопником':gt'gopnew','rapebj'
			end
			act 'Я не пизжу!':
				cla
				*clr
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str61')
				act 'Согласна':
					cla
					*clr
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str62')
					act 'Встать на колени перед гопником':gt'gopnew','rapebj'
				end
				act 'Нет':
					cla
					*clr
					gs 'zz_render', '', '', func('gopnew_strings', 'local_str63')
					act 'Встать на колени перед гопником':gt'gopnew','rapebj'
				end
			end
		end
		act 'Промолчать':
			cla
			*clr
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str64')
			act 'Сколько?':gt'gopnew','dolg'
		end
	end
	act 'Нет!':
		cla
		*clr
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str65')
		act 'Да, ты пиздобол':
			cla
			*clr
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str66')
			act 'Встать на колени перед гопником':gt'gopnew','rapebj'
		end
		act 'Нет, ты не пиздобол':
			cla
			*clr
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str67')
			act 'Согласиться':
				cla
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str68')
				act 'Сколько?':gt'gopnew','dolg'
			end
			act 'Не соглашаться':
				cla
				gs 'zz_render', '', '', func('gopnew_strings', 'local_str69')
				act 'Упасть на колени перед гопником':gt'gopnew','rapebj'
			end
		end
	end
end
if $ARGS[0] = 'rapebj':
	minut += 3
	rape += 1
	gs 'zz_render', '', 'images/pictures/rapebj.jpg', func('gopnew_strings', 'local_str70')
	act 'Обхватить член губами':
		cla
		*clr
		if vasansex = 0:vasansex = 1 & guy += 1
		bj += 1
		gs 'zz_render', '', 'images/pictures/rapebj1.jpg', func('gopnew_strings', 'local_str71')
		act 'Стараться':gt'gopnew','tf'
		act 'Сосать как сосали':gt'gopnew','tf'
	end
	act 'Облизать член языком':
		cla
		*clr
		if vasansex = 0:vasansex = 1 & guy += 1
		bj += 1
		gs 'zz_render', '', 'images/pictures/rapebj2.jpg', func('gopnew_strings', 'local_str72')
		act 'Сосать':gt'gopnew','tf'
		act 'Облизывать дальше':gt'gopnew','tf'
	end
	act 'Нет!':
		cla
		*clr
		if vasansex = 0:vasansex = 1 & guy += 1
		bj += 1
		gs 'zz_render', '', 'images/pictures/rapebj3.jpg', func('gopnew_strings', 'local_str73')
		act 'Давиться':gt'gopnew','tf'
	end
end
if $ARGS[0] = 'tf':
	minut += 3
	throat += 1
	gs 'zz_render', '', 'images/pictures/rapebjt2.jpg', func('gopnew_strings', 'local_str74')
	act '...':
		cla
		*clr
		minut += 3
		gs 'zz_render', '', 'images/pictures/rapebjt.jpg', func('gopnew_strings', 'local_str75')
		act '...':
			cla
			*clr
			minut += 3
			gs 'zz_funcs', 'cum', 'face'
			if mop ! 1:mop = 0
			gs'stat'
			gs 'zz_render', '', 'images/pictures/rapebjcum.jpg', func('gopnew_strings', 'local_str76')
			act 'Чистить языком':
				cla
				*clr
				minut += 3
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs'stat'
				gs 'zz_render', '', 'images/pictures/rapebjcum2.jpg', func('gopnew_strings', 'local_str77')
				act 'Да':
					cla
					*clr
					minut += 3
					opusk = 1
					gs 'zz_render', '', 'images/pictures/spit.jpg', func('gopnew_strings', 'local_str78')
					act 'Уйти':gt'street'
				end
			end
		end
	end
end
if $ARGS[0] = 'dolg':
	minut += 3
	loh += 1
	gopdolg = money+stolmoney+karta+10000
	gopdaydolg = daystart+10
	gs 'zz_render', '', '', func('gopnew_strings', 'local_str79')
	act 'Уйти':gt'street'
	act 'Ребят, это слишком много, у меня нет таких денег':
		cla
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str80')
		act 'Уйти':gt'street'
		act 'Может как-нибудь по другому возьмете?':
			cla
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str81')
			act 'Уйти':gt'street'
			act 'Оплатить натурой':
				sipovka += 1
				gopdolg = 0
				VasanTut = 3
				gt'gopnew','sexstart'
			end
		end
	end
end
if $ARGS[0] = 'sexstart':
	!rosetka
	!sipovka
	minut += 3
	if opusk > 0 or sipovka > 0:
		if GLust = 1:
			if tiprand = 0:gt'gopnew','1'
			if tiprand = 1:gt'gopnew','11'
			if tiprand = 2:gt'gopnew','12'
		else
			gt 'gopnew',str(GLust)
		end
	elseif opusk = 0 and sipovka = 0:
		if GLust = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str82')
			act 'Согласиться трахаться с двумя':sipovka += 1 & gt'gopnew','2'
		elseif GLust = 3:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str83')
			act 'Согласиться трахаться с тремя':sipovka += 1 & gt'gopnew','2'
		elseif GLust = 4:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str84')
			act 'Согласиться трахаться с четырьмя':sipovka += 1 & gt'gopnew','2'
		elseif GLust = 5:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str85')
			act 'Согласиться трахаться с пятью':sipovka += 1 & gt'gopnew','2'
		elseif GLust = 6:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str86')
			act 'Согласиться трахаться с шестью':sipovka += 1 & gt'gopnew','2'
		end
		if VasanTut = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str87')
			act 'Пойти с Васяном':VasanTut = 3 & dynamic $gopsexboy1
		end
		if BerezaTut = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str88')
			act 'Пойти с Березой':BerezaTut = 3 & dynamic $gopsexboy1
		end
		if VitekTut = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str89')
			act 'Пойти с Витьком':VitekTut = 3 & dynamic $gopsexboy1
		end
		if KostilTut = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str90')
			act 'Пойти с Костылем':KostilTut = 3 & dynamic $gopsexboy1
		end
		if UdmurtTut = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str91')
			act 'Пойти с Удмуртом':UdmurtTut = 3 & dynamic $gopsexboy1
		end
		if SeriTut = 2:
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str92')
			act 'Пойти с Серым':SeriTut = 3 & dynamic $gopsexboy1
		end
		act 'Уйти':gt'street'
	end
end
if $ARGS[0] = '1':
	minut += 15
	vagina += 1
	sex += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs'stat'
	gs 'zz_render', '', 'images/pics/gopslut'+RAND(1,6)+'.jpg', func('gopnew_strings', 'local_str93')
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', '', func('gopnew_strings', 'local_str94')
	act 'Уйти':gt'street'
end
if $ARGS[0] = '11':
	minut += 15
	bj += 1
	throat += 1
	gs'stat'
	gs 'zz_render', '', 'images/pics/bj'+RAND(1,10)+'.jpg', func('gopnew_strings', 'local_str95')
	act 'Продолжать сосать':
		cla
		*clr
		gs 'zz_render', '', 'images/pics/cum'+RAND(1,10)+'.jpg', func('gopnew_strings', 'local_str96')
		act 'Проглотить':
			cla
			gs 'zz_funcs', 'cum', 'lip'
			swallow += 1
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str97')
			act 'Уйти':gt'street'
		end
		act 'Выплюнуть':
			cla
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render', '', '', func('gopnew_strings', 'local_str98')
			act 'Уйти':gt'street'
		end
	end
	act 'Вынуть изо рта':
		cla
		'<center><img src="images/pics/facial'+RAND(1,5)+'.jpg"></center>'
		bjrand = RAND(0,1)
		if bjrand = 0:'Вы успеваете вынуть член изо рта и <<$guygop>> кончает мимо вас.'
		if bjrand = 1: gs 'zz_funcs', 'cum', 'face' & '<<$guygop>> кончает вам на лицо.'
		if bjrand = 1:'Все ваше лицо в липкой и горячей сперме, гопник вытирает член о ваши губы и уходит.'
		act 'Уйти':gt'street'
	end
end
if $ARGS[0] = '12':
	minut += 15
	anal += 1
	anus += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs'stat'
	gs 'zz_render', '', 'images/pics/gopslut'+RAND(1,6)+'.jpg', func('gopnew_strings', 'local_str99')
	gs 'zz_funcs', 'hornyrand'
	gs 'zz_render', '', '', func('gopnew_strings', 'local_str100')
	act 'Уйти':gt'street'
end
if $ARGS[0] = '2':
	minut += 30
	gs'stat'
	if VasanTut = 3:
		$namgop = 'Васян'
	else
		$namgop = ''
	end
	if BerezaTut = 3:
		$namgop2 = 'Береза'
	else
		$namgop2 = ''
	end
	if VitekTut = 3:
		$namgop3 = 'Витек'
	else
		$namgop3 = ''
	end
	if KostilTut = 3:
		$namgop4 = 'Костыль'
	else
		$namgop4 = ''
	end
	if UdmurtTut = 3:
		$namgop5 = 'Удмурт'
	else
		$namgop5 = ''
	end
	if SeriTut = 3:
		$namgop6 = 'Серый'
	else
		$namgop6 = ''
	end
	$namgopsum = '<<$namgop>> <<$namgop2>> <<$namgop3>> <<$namgop4>> <<$namgop5>> <<$namgop6>> достали свои члены и начали сдирать с вас одежду.'
	if GLust ! 2:tiprand = RAND(0,1)
	if tiprand = 0 and GLust ! 2:
		bj += 3
		gang += 1
		throat += 3
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_funcs', 'cum', 'face'
		gs'stat'
		gs 'zz_render', '', 'images/pics/tri'+RAND(1,11)+'.jpg', func('gopnew_strings', 'local_str101')
		gs 'zz_funcs', 'hornyrand'
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str102')
		act 'Уйти':gt'street'
	elseif tiprand = 1 or GLust = 2:
		bj += 1
		vagina += 1
		sex += 1
		anal += 1
		anus += 5
		gang += 1
		throat += 3
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_funcs', 'cum', 'face'
		gs'stat'
		gs 'zz_render', '', 'images/pics/gang'+RAND(1,15)+'.jpg', func('gopnew_strings', 'local_str103')
		gs 'zz_funcs', 'hornyrand'
		gs 'zz_render', '', '', func('gopnew_strings', 'local_str104')
		act 'Уйти':gt'street'
	end
end
if $ARGS[0] = 'degrading':
	minut += 120
	vagina += 10
	anus += 10
	anal += 1
	sex += 1
	rape += 1
	gopopusday = day
	gs'stat'
	if VasanTut = 3 and vasansex = 0:vasansex = 1 & guy += 1
	if BerezaTut = 3 and berezasex = 0:berezasex = 1 & guy += 1
	if VitekTut = 3 and viteksex = 0:viteksex = 1 & guy += 1
	if KostilTut = 3 and kostilsex = 0:kostilsex = 1 & guy += 1
	if UdmurtTut = 3 and udmurtsex = 0:udmurtsex = 1 & guy += 1
	if SeriTut = 3 and serisex = 0:serisex = 1 & guy += 1
	if VasanTut = 3:
		$namgop = 'Васян'
	else
		$namgop = ''
	end
	if BerezaTut = 3:
		$namgop2 = 'Береза'
	else
		$namgop2 = ''
	end
	if VitekTut = 3:
		$namgop3 = 'Витек'
	else
		$namgop3 = ''
	end
	if KostilTut = 3:
		$namgop4 = 'Костыль'
	else
		$namgop4 = ''
	end
	if UdmurtTut = 3:
		$namgop5 = 'Удмурт'
	else
		$namgop5 = ''
	end
	if SeriTut = 3:
		$namgop6 = 'Серый'
	else
		$namgop6 = ''
	end
	$namgopsum = '<<$namgop>> <<$namgop2>> <<$namgop3>> <<$namgop4>> <<$namgop5>> <<$namgop6>> достали свои члены и начали сдирать с вас одежду.'
	gs 'zz_render', '', 'images/pictures/deg'+RAND(0,8)+'.jpg', func('gopnew_strings', 'local_str105')
	act 'Уйти':gt'street'
end