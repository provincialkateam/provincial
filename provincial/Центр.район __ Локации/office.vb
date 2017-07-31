if $ARGS[0] = 'start':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Офис проектировочной фирмы</font></b></center>'
	'<center><img src="images/pic/office.jpg"></center>'
	if workSec = 0:'Требуется на работу секретарем молодая девушка с дипломом подтверждающим пройденный курс обучения.'
	if workSec = 0:'График работы с 9 до 17, каждый день кроме субботы и воскресенья.'
	if workSec = 0:'Зарплата перечисляется 25го числа на банковский счет. Зарплата 1000 рублей в день.'
	if workSec = 0:'На работу обязательно приходить в офисной одежде.'
	if secrDiplom = 1 and workSec = 0 and work = 0:
		act 'Пройти собеседование о приеме на работу':
			cla
			minut += 60
			gs 'zz_render', '', '', func('office_strings', 'local_str1')
			act 'Уйти':gt'office','start'
			act 'Устроиться на работу':
				cla
				work = 1
				workSec = 1
				sekDay = 0
				gs 'zz_render', '', '', func('office_strings', 'local_str2')
				act 'Уйти':gt'office','start'
			end
		end
	end
	if hour >= 9 and hour < 17 and workSec >= 1:'Вы опоздали на работу и вас отправили домой.'
	if workSec >= 1 and func('zz_clothing','get_group') ! 10 and hour >= 9 and hour < 17:'Вы не одеты согласно корпоративному стилю.'
	if hour >= 8 and hour < 9 and workSec >= 1 and func('zz_clothing','get_group') = 10:
		act 'Идти на рабочее место':
			sekDay += 1
			hour = 9
			minut = 0
			gt'office','work'
		end
	end
	if worksec = 1:
		act 'Уволиться':
			cla
			minut += 30
			work = 0
			workSec = 0
			gs 'zz_render', '', '', func('office_strings', 'local_str3')
			act 'Выйти':gt'down'
		end
	end
	act 'Выйти':gt'down'
end
if $ARGS[0] = 'work':
	cla
	*clr
	gs'stat'
	'<center><b><font color = maroon>Ваше рабочее место</font></b></center>'
	gs 'zz_render', '', 'images/pic/sekr.jpg', func('office_strings', 'local_str4')
	if fidayoffice = 0:
		fidayoffice = 1
		gs 'zz_render', '', '', func('office_strings', 'local_str5')
	elseif fidayoffice = 1:
		gs 'zz_render', '', '', func('office_strings', 'local_str6')
	end
	if hour < 17:
		act 'Работать':
			minut += 60
			cla
			gs 'zz_render', '', '', func('office_strings', 'local_str7')
			officerand = RAND(0,15)
			if officerand > 8 and svetslut = 0:gt'office','sveta'
			if officerand > 8 and svetslut = 2:gt'office','boss1'
			if officerand = 11 and officebestslut >= 3:gt'office','motiv1'
			if officerand = 12 and officebestslut >= 3:gt'office','motiv2'
			if officerand = 13 and officebestslut >= 3:gt'office','motiv3'
			if officerand = 9 and officeslut > 5:
				cla
				*clr
				gs 'zz_render', '', 'images/img/office/m0.jpg', func('office_strings', 'local_str8')
				act 'Чем помочь?':
					cla
					*clr
					gs 'zz_render', '', 'images/img/office/m1.jpg', func('office_strings', 'local_str9')
					act 'Взять в рот':
						picrand = 54
						officeslut += 1
						guy += 1
						gt'sex','minet'
					end
					if officeslut < 10:
						act 'Послать его':gt'office','work'
					end
				end
			elseif officerand = 8 and officeslut > 5:
				cla
				*clr
				gs 'zz_render', '', 'images/img/office/m2.jpg', func('office_strings', 'local_str10')
				act 'Да':
					cla
					*clr
					gs 'zz_render', '', 'images/img/office/m3.jpg', func('office_strings', 'local_str11')
					act 'Отдаться':
						picrand = 55
						officeslut += 1
						guy += 1
						gt'sex','minet'
					end
					if officeslut < 10:
						act 'Прогнать его':gt'office','work'
					end
				end
			elseif officerand = 7 and officeslut > 5:
				cla
				*clr
				gs 'zz_render', '', 'images/img/office/m4.jpg', func('office_strings', 'local_str12')
				act 'Позволить ему':
					cla
					*clr
					officeslut += 1
					gs 'zz_render', '', 'images/img/office/m5.jpg', func('office_strings', 'local_str13')
					act 'На корточки':
						cla
						*clr
						gs 'zz_render', '', 'images/img/office/m6.jpg', func('office_strings', 'local_str14')
						act 'Продолжать':
							picrand = 56
							officeslut += 3
							guy += 1
							gt'sex','minet'
						end
					end
					if officeslut < 10:
						act 'Прогнать его':gt'office','work'
					end
				end
				if officeslut < 10:
					act 'Убежать':gt'office','work'
				end
			elseif officerand = 6 and officeslut > 5:
				cla
				*clr
				gs 'zz_render', '', 'images/img/office/m8.jpg', func('office_strings', 'local_str15')
				act 'Да':
					cla
					*clr
					gs 'zz_render', '', 'images/img/office/m9.jpg', func('office_strings', 'local_str16')
					act 'Взять':
						picrand = 57
						officeslut += 1
						guy += 1
						gt'sex','minet'
					end
					if officeslut < 10:
						act 'Прогнать его':gt'office','work'
					end
				end
			elseif officerand = 5 and officeslut > 5:
				cla
				*clr
				gs 'zz_render', '', 'images/img/office/m10.jpg', func('office_strings', 'local_str17')
				act 'И как же':
					cla
					*clr
					gs 'zz_render', '', 'images/img/office/m11.jpg', func('office_strings', 'local_str18')
					act 'Сосать':
						picrand = 58
						officeslut += 1
						guy += 1
						gt'sex','minet'
					end
					if officeslut < 10:
						act 'Укусить':
							cla
							gs 'zz_render', '', '', func('office_strings', 'local_str19')
							act 'Вернуться к работе':gt'office','work'
						end
					end
				end
			elseif officerand = 0 and officeslut > 20 and officebestslut < 1:
				cla
				*clr
				officebestslut = 1
				officeslut += 1
				gang += 1
				guy += 4
				gs 'zz_render', '', 'images/img/office/g3.jpg', func('office_strings', 'local_str20')
				act 'Начать':
					picrand = 17
					gt'paysex','var'
				end
			end
			act 'Закончить':gt'office','work'
		end
		act 'В кабинет директора':gt'office','boss'
		act 'Коридор':gt'office','kor'
		act 'Болтать':
			cla
			minut += 30
			if officeslut > 0 and RAND(0,10) > 8: gt'office','negr'
			officebolt = RAND(0,3)
			if officebolt = 0:'"Представляешь, говорят что на корпоративе наша бухгалтерша которой уже за 40, приставала к одному из менеджеров пытаясь затащить его в кабинет. Он еле вырвался." - рассказала <<$name[1]>>.'
			if officebolt = 1:'"Представляешь, на одном корпоративе я так набралась, что станцевала стриптиз на столе при всех, мне потом так стыдно было, все ходили пальцем тыкали, я даже уволиться хотела, но передумала, шеф мне даже премию дал, сказал что я украшение офиса, а если остальные пальцем тыкают, так это от того что им показать нечего." - рассказала <<$name[1]>>.'
			if officebolt = 2:'"У нас была одна девушка, маркетолог так она на очередных посиделках напилась и в комнате отдыха заснула, а проснулась голой и вся в сперме, вокруг презиков использованных штук 20 валялось, уж не знаю сколько человек её там поимело, но она через два дня за трудовой пришла враскорячку и сесть не могла." - рассказала <<$name[1]>>.'
			if officebolt = 3:'"Представляешь, на одном корпоративе наш сисадмин напился и уснул в туалете, так девчонки маркетологи открыли его склад и набрав там старых клавиатур и каких то плат, примотали все это к нему скотчем, получился рыцарь в доспехах, так мы всем офисом, утром у туалета ждали когда он проснется, он вышел и только потом понял что к нему что-то примотано. Вот смеху то было." - рассказала <<$name[1]>>.'
			act 'Закончить':gt'office','work'
		end
		if svetslut = 1:
			act 'Спросить <<$name_a[1]>> о её отношениях с шефом':
				cla
				minut += 30
				svetslut = 2
				gs 'zz_render', '', '', func('office_strings', 'local_str21')
				act 'Закончить':gt'office','work'
			end
		elseif svetslut = 3:
			act 'Спросить про секс в кабинете при вас':
				cla
				minut += 30
				svetslut = 4
				gs 'zz_render', '', '', func('office_strings', 'local_str22')
				act 'Сказать что она вам нравиться':
					cla
					*clr
					officelezb = 1
					gs 'zz_render', '', 'images/img/office/s2.jpg', func('office_strings', 'local_str23')
					act 'Не сейчас':
						cla
						gs 'zz_render', '', '', func('office_strings', 'local_str24')
						act 'Вернуться к работе':gt'office','work'
					end
					act 'Не возражать':
						cla
						*clr
						gs 'zz_render', '', 'images/img/office/s3.jpg', func('office_strings', 'local_str25')
						act 'Продолжать':
							cla
							*clr
							girl += 1
							lesbian += 1
							gs 'zz_render', '', 'images/img/office/s4.jpg', func('office_strings', 'local_str26')
							act 'Пусть продолжает':
								cla
								*clr
								orgasm += 1
								gs 'zz_render', '', 'images/img/office/s5.jpg', func('office_strings', 'local_str27')
								act 'Кончить':
									cla
									gs 'zz_render', '', '', func('office_strings', 'local_str28')
									act 'Вернуться к работе':gt'office','work'
								end
								act 'Удовлетворить друг друга':
									cla
									*clr
									gs 'zz_render', '', 'images/img/office/s7.jpg', func('office_strings', 'local_str29')
									act 'Вернуться к работе':gt'office','work'
								end
							end
							act 'Полизать её':
								cla
								*clr
								gs 'zz_render', '', 'images/img/office/s6.jpg', func('office_strings', 'local_str30')
								act 'Пусть кончает':
									cla
									gs 'zz_render', '', '', func('office_strings', 'local_str31')
									act 'Вернуться к работе':gt'office','work'
								end
								act 'Удовлетворить друг друга':
									cla
									*clr
									orgasm += 1
									gs 'zz_render', '', 'images/img/office/s7.jpg', func('office_strings', 'local_str32')
									act 'Вернуться к работе':gt'office','work'
								end
							end
						end
						act 'Не сейчас':
							cla
							gs 'zz_render', '', '', func('office_strings', 'local_str33')
							act 'Вернуться к работе':gt'office','work'
						end
					end
				end
				act 'Возмутиться':
					cla
					gs 'zz_render', '', '', func('office_strings', 'local_str34')
					act 'Вернуться к работе':gt'office','work'
				end
			end
		end
		if officelezb > 0 or officeslut > 0:
			act 'Приставать':
				cla
				*clr
				minut += 30
				if officeslut > 0 and RAND(0,10) > 8:gt'office','dostavka'
				lesbian += 1
				picrand = 19
				officelezb += 1
				gs 'zz_render', '', 'images/img/office/s8.jpg', func('office_strings', 'local_str35')
				act 'Начать':xgt'lezbsex','var'
			end
		end
	elseif hour >= 17:
		act 'Уйти с работы':gt'down'
	end
end
if $ARGS[0] = 'boss':
	cla
	*clr
	minut += 15
	officerand = RAND(0,15)
	if officeslut > 0 and officerand >= 2 and officerand <= 6: gt'office','boss<<officerand>>'
	gs 'stat'
	'<center><b><font color = maroon>Кабинет директора</font></b></center>'
	'<center><img src="images/pic/boss.jpg"></center>'
	if officebestslut = 1:
		cla
		gs 'zz_render', '', '', func('office_strings', 'local_str36')
		act 'Согласиться':
			cla
			officebestslut = 3
			gs 'zz_render', '', '', func('office_strings', 'local_str37')
			act 'Ехать':gt'office','motiv0'
		end
		act 'Отказаться':
			cla
			gs 'zz_render', '', '', func('office_strings', 'local_str38')
			act 'Согласиться':
				cla
				officebestslut = 3
				gs 'zz_render', '', '', func('office_strings', 'local_str39')
				act 'Ехать':gt'office','motiv0'
			end
			act 'Отказаться':
				officebestslut = 2
				gt'office','work'
			end
		end
	end
	if officeslut > 0:
		act 'Домогаться шефа':
			cla
			*clr
			officeslut += 1
			picrand = RAND(61,63)
			gs 'zz_render', '', 'images/img/office/b<<picrand>>.jpg', func('office_strings', 'local_str40')
			act 'Раздвинуть ноги':gt'sex','kuni'
		end
	end
	act 'Выйти из кабинета':gt'office','work'
end
if $ARGS[0] = 'kor':
	cla
	*clr
	minut += 5
	gs'stat'
	'<center><b><font color = maroon>Коридор</font></b></center>'
	'<center><img src="images/pic/office.jpg"></center>'
	if hour < 17:
		act 'На свое рабочее место':gt'office','work'
		act 'Комната отдыха':gt'office','kuh'
	elseif hour >= 17:
		act 'Уйти с работы':gt'down'
	end
end
if $ARGS[0] = 'kuh':
	cla
	*clr
	minut += 5
	gs'stat'
	officerand = RAND(0,10)
	if officerand > 8 and officeslut > 8:
		gt'office','gang'
	elseif officerand < 2 and (officeslut > 5 or horny >= 90):
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/m12.jpg', func('office_strings', 'local_str41')
		act 'Пить':
			cla
			*clr
			gs 'zz_render', '', 'images/img/office/m13.jpg', func('office_strings', 'local_str42')
			if officeslut > 5:'И не дожидаясь ответа продолжил "Знаю что послушная, мне уже рассказывали, что ты очень прилежная девочка"'
			gs 'zz_render', '', '', func('office_strings', 'local_str43')
			act 'Не сопротивляться':
				cla
				*clr
				officeslut += 1
				gs 'zz_render', '', 'images/img/office/m14.jpg', func('office_strings', 'local_str44')
				act 'Продолжать':
					picrand = 59
					officeslut += 1
					guy += 1
					gt'sex','minet'
				end
			end
			if officeslut < 10:
				act 'Оттолкнуть его и убежать':gt'office','work'
			end
		end
		exit
	end
	'<center><b><font color = maroon>Комната отдыха</font></b></center>'
	'<center><img src="images/pic/kuh.jpg"></center>'
	if hour < 17:
		act 'Поесть':
			gs 'zz_kitchen_acts', 'eat', 'lunch'
			gs 'zz_kitchen_acts', 'drink', 'tea'
		end
		act 'Коридор':gt'office','kor'
	elseif hour >= 17:
		act 'Уйти с работы':gt'down'
	end
end
if $ARGS[0] = 'sveta':
	cla
	*clr
	minut += 30
	svetslut = 1
	gs 'zz_render', '', 'images/img/office/s1.jpg', func('office_strings', 'local_str48')
	act 'Вернуться к работе':gt'office','work'
end
if $ARGS[0] = 'boss1':
	cla
	*clr
	minut += 30
	gs 'zz_render', '', 'images/img/office/b1.jpg', func('office_strings', 'local_str49')
	act 'Принести чаю':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/b2.jpg', func('office_strings', 'local_str50')
		act 'Присоединиться':
			cla
			*clr
			officeslut += 1
			eggs += 1
			bj += 1
			guy += 1
			girl += 1
			lesbian += 1
			gs 'zz_render', '', 'images/img/office/b3.jpg', func('office_strings', 'local_str51')
			act 'Продолжать':
				cla
				*clr
				gs 'zz_render', '', 'images/img/office/b4.jpg', func('office_strings', 'local_str52')
				act 'Подставить киску ему':
					cla
					*clr
					sex += 1
					gs 'zz_render', '', 'images/img/office/b5.jpg', func('office_strings', 'local_str53')
					act 'Встать раком':
						cla
						*clr
						anal += 1
						orgasm += 1
						analorgasm += 1
						gs 'zz_render', '', 'images/img/office/b7.jpg', func('office_strings', 'local_str54')
						act 'Закончить':gt'office','boss0'
					end
					act 'Сесть сверху':
						cla
						*clr
						anal += 1
						orgasm += 1
						analorgasm += 1
						gs 'zz_render', '', 'images/img/office/b8.jpg', func('office_strings', 'local_str55')
						act 'Закончить':gt'office','boss0'
					end
					act 'Лечь на диван':
						cla
						*clr
						anal += 1
						orgasm += 1
						analorgasm += 1
						gs 'zz_render', '', 'images/img/office/b9.jpg', func('office_strings', 'local_str56')
						act 'Закончить':gt'office','boss0'
					end
				end
				act 'Подставить киску ей':
					cla
					*clr
					orgasm += 1
					gs 'zz_render', '', 'images/img/office/b6.jpg', func('office_strings', 'local_str57')
					act 'Встать раком':
						cla
						*clr
						anal += 1
						orgasm += 1
						analorgasm += 1
						gs 'zz_render', '', 'images/img/office/b7.jpg', func('office_strings', 'local_str58')
						act 'Закончить':gt'office','boss0'
					end
					act 'Сесть сверху':
						cla
						*clr
						anal += 1
						orgasm += 1
						analorgasm += 1
						gs 'zz_render', '', 'images/img/office/b8.jpg', func('office_strings', 'local_str59')
						act 'Закончить':gt'office','boss0'
					end
					act 'Лечь на диван':
						cla
						*clr
						anal += 1
						orgasm += 1
						analorgasm += 1
						gs 'zz_render', '', 'images/img/office/b9.jpg', func('office_strings', 'local_str60')
						act 'Закончить':gt'office','boss0'
					end
				end
			end
		end
		act 'Оставить чай и выйти':
			svetslut = 3
			gt'office','work'
		end
	end
end
if $ARGS[0] = 'boss0':
	cla
	*clr
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_render', '', 'images/img/office/b10.jpg', func('office_strings', 'local_str61')
	act 'Вернуться к работе':gt'office','work'
end
if $ARGS[0] = 'dostavka':
	cla
	*clr
	minut += 30
	gs'stat'
	gs 'zz_render', '', 'images/img/office/s9.jpg', func('office_strings', 'local_str62')
	act 'Расписаться':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/s10.jpg', func('office_strings', 'local_str63')
		act 'Выпроводить его':
			cla
			gs 'zz_render', '', '', func('office_strings', 'local_str64')
			act 'Начать':
				lesbian += 1
				picrand = 19
				officelezb += 1
				xgt'lezbsex','var'
			end
		end
		act 'Закрыть дверь':
			cla
			*clr
			officeslut += 1
			gs 'zz_render', '', 'images/img/office/s11.jpg', func('office_strings', 'local_str65')
			act 'Продолжать':
				picrand = 26
				guy += 1
				lesbian += 1
				gt'podrsex','var'
			end
		end
	end
end
if $ARGS[0] = 'negr':
	cla
	*clr
	minut += 30
	gs'stat'
	gs 'zz_render', '', 'images/img/office/s12.jpg', func('office_strings', 'local_str66')
	act 'Хочу':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/s13.jpg', func('office_strings', 'local_str67')
		act 'Оттолкнуть её':
			cla
			gs 'zz_render', '', '', func('office_strings', 'local_str68')
			act 'Вернуться к работе':gt'office','work'
		end
		act 'Ответить ей':
			cla
			*clr
			officeslut += 1
			gs 'zz_render', '', 'images/img/office/s14.jpg', func('office_strings', 'local_str69')
			act 'Продолжать':
				picrand = 27
				guy += 1
				lesbian += 1
				gt'podrsex','var'
			end
		end
	end
end
if $ARGS[0] = 'boss2':
	cla
	*clr
	minut += 30
	officeslut += 1
	gs 'zz_render', '', 'images/img/office/b11.jpg', func('office_strings', 'local_str70')
	act 'Встать на колени':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/b12.jpg', func('office_strings', 'local_str71')
		act 'Расписаться':
			cla
			*clr
			officeslut += 1
			gs 'zz_render', '', 'images/img/office/b13.jpg', func('office_strings', 'local_str72')
			act 'Да':
				picrand = 24
				guy += 1
				xgt'sexdvoe','var'
			end
		end
		if officeslut < 10:
			act 'Выбежать из кабинета':
				cla
				gs 'zz_render', '', '', func('office_strings', 'local_str73')
				act 'Вернуться к работе':gt'office','work'
			end
		end
	end
end
if $ARGS[0] = 'boss3':
	cla
	*clr
	minut += 30
	officeslut += 1
	gs 'zz_render', '', 'images/img/office/b14.jpg', func('office_strings', 'local_str74')
	act 'Встать на колени':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/b15.jpg', func('office_strings', 'local_str75')
		act 'Нагнуться':
			cla
			*clr
			gs 'zz_render', '', 'images/img/office/b16.jpg', func('office_strings', 'local_str76')
			act 'Да':
				picrand = 25
				guy += 1
				xgt'sexdvoe','var'
			end
		end
	end
end
if $ARGS[0] = 'boss4':
	cla
	*clr
	minut += 30
	officeslut += 1
	gs 'zz_render', '', 'images/img/office/b17.jpg', func('office_strings', 'local_str77')
	act 'Подозвать':
		cla
		*clr
		orgasm += 1
		officeslut += 1
		gs 'zz_render', '', 'images/img/office/b18.jpg', func('office_strings', 'local_str78')
		act 'Начать':
			picrand = 26
			guy += 1
			xgt'sexdvoe','var'
		end
	end
	if officeslut < 10:
		act 'Выбежать из кабинета':gt'office','work'
	end
end
if $ARGS[0] = 'gang':
	cla
	*clr
	guy += 3
	bj += 3
	swallow += 6
	minut += 30
	officeslut += 1
	gang += 1
	gs 'zz_render', '', 'images/img/office/g0.jpg', func('office_strings', 'local_str79')
	act 'Сосать':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/g1.jpg', func('office_strings', 'local_str80')
		act 'Сосать':
			cla
			*clr
			gs 'zz_render', '', 'images/img/office/g2.jpg', func('office_strings', 'local_str81')
			act 'Начать':
				picrand = 16
				gt'paysex','var'
			end
		end
	end
end
if $ARGS[0] = 'boss5':
	cla
	*clr
	minut += 30
	officeslut += 1
	gs 'zz_render', '', 'images/img/office/b19.jpg', func('office_strings', 'local_str82')
	act 'Снять':
		cla
		*clr
		swallow += 1
		bj += 1
		gs 'zz_render', '', 'images/img/office/b20.jpg', func('office_strings', 'local_str83')
		act 'Начать':
			picrand = 60
			gt'sex','kuni'
		end
	end
	if officeslut < 10:
		act 'Отказаться':gt'office','work'
	end
end
if $ARGS[0] = 'boss6':
	cla
	*clr
	spank += 1
	minut += 30
	officeslut += 1
	gs 'zz_render', '', 'images/img/office/b21.jpg', func('office_strings', 'local_str84')
	act 'Далее':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/b22.jpg', func('office_strings', 'local_str85')
		act 'Открыть рот':
			picrand = 64
			gt'sex','minet'
		end
	end
end
if $ARGS[0] = 'motiv0':
	cla
	*clr
	minut += 180
	gs 'zz_render', '', 'images/img/office/m15.jpg', func('office_strings', 'local_str86')
	act 'Конечно':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/m16.jpg', func('office_strings', 'local_str87')
		act 'Начать':
			picrand = 29
			guy += 1
			xgt'sexdvoe','var'
		end
	end
end
if $ARGS[0] = 'motiv1':
	cla
	*clr
	minut += 120
	gs 'zz_render', '', 'images/img/office/m'+RAND(65,68)+'.jpg', func('office_strings', 'local_str88')
	act 'Начать':
		guy += 1
		gt'sex','minet'
	end
end
if $ARGS[0] = 'motiv2':
	cla
	*clr
	if RAND(1,4) = 1:gt'office','motiv4'
	minut += 240
	swallow += 2
	bj += 2
	guy += 2
	gs 'zz_render', '', 'images/img/office/m'+RAND(69,73)+'.jpg', func('office_strings', 'local_str89')
	act 'Взять в рот':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/m0'+RAND(69,73)+'.jpg', func('office_strings', 'local_str90')
		act 'Начать':gt'sex','kuni'
	end
end
if $ARGS[0] = 'motiv3':
	cla
	*clr
	if RAND(1,4) = 1: gt'office','motiv5'
	minut += 240
	swallow += 2
	bj += 2
	guy += 2
	gs 'zz_render', '', 'images/img/office/m'+RAND(30,33)+'.jpg', func('office_strings', 'local_str91')
	act 'Взять в рот':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/m0'+RAND(30,33)+'.jpg', func('office_strings', 'local_str92')
		act 'Начать':xgt'sexdvoe','var'
	end
end
if $ARGS[0] = 'motiv4':
	cla
	*clr
	picrand = 29
	minut += 180
	guy += 1
	gs 'zz_render', '', 'images/img/office/m17.jpg', func('office_strings', 'local_str93')
	act 'Смотреть':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/m18.jpg', func('office_strings', 'local_str94')
		act 'Начать':gt'podrsex','var'
	end
end
if $ARGS[0] = 'motiv5':
	cla
	*clr
	picrand = 34
	minut += 180
	guy += 2
	gs 'zz_render', '', 'images/img/office/m19.jpg', func('office_strings', 'local_str95')
	act 'Раздеться':
		cla
		*clr
		gs 'zz_render', '', 'images/img/office/m20.jpg', func('office_strings', 'local_str96')
		act 'Начать':
			cla
			*clr
			gs 'zz_render', '', 'images/img/office/m21.jpg', func('office_strings', 'local_str97')
			act 'Продолжать':xgt'sexdvoe','var'
		end
	end
end