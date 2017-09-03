*P ' '
!Ограничение в 5 разговоров в сутки на кухне
if sergebazarkuh_day ! daystart: sergebazarkuh_count = 5
!Ограничение в 1 помощь, мыть посуду
if sergehelppos_day ! daystart: sergehelppos_count = 1
!Ограничение в 1 помощь, мыть пол
if sergehelppol_day ! daystart: sergehelppol_count = 1
$orgasm_dyn_serg = {
if horny >=70:
	orgasm += 1
	horny = 0
	manna += 30
	health += 10
	gs 'zz_render', '', '', func('Serge_kuh_strings', '1')
end
}
!======================================================!
!СЕРГЕЙ НА КУХНЕ ГОТОВИТ ЕДУ(БОЛТОВНЯ) С 18:00 ДО 21:00!
!------------------------------------------------------!
	*clr & cla
	minut += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge2.jpg', func('Serge_kuh_strings', '2')
		dynamic $serge_shulgin_rep
	act 'Отойти': dynamic $shkuh
act 'Поговорить':
		*clr & cla
		if sergebazarkuh_count > 0:minut += 15
		sergebazarkuh_day = daystart
		sergebazarkuh_count -= 1
		if sergebazarkuh_count > 0: gs 'npc_editor','change_rep','+', 36
		gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge1.jpg', func('Serge_kuh_strings', '3')
serge_textbk = RAND(0,4)
			if serge_textbk = 0:$serge_textbk = 'Вы спрашиваете про мать Василия. Сергей, удивившись малость такому вопросу, начинает рассказывать: \\\- Все очень просто, встретил я мамку Васьки на банкете как отмечали получение диплома. Ну... тогда все нажрались, короче так получилось, что она залетела. Быстро сыграли свадьбу, через год родился Васян.<br>Еще через год такая жизнь наскучила и когда ей предложили работу за границей - она не думая уехала. С того времени больше мы не общались и я если честно даже не интересовался. А не так давно узнал, что она умерла от рака.///'
 			if serge_textbk = 1:$serge_textbk = 'Минут 15 вы беседуете на разные темы.'
 			if serge_textbk = 2:$serge_textbk = 'Вы интересуетесь про его работу, Сергей рассказывает: \\\- Работаю на заводе по производству кирпича, работа в первую смену с 9:00 до 15:00, 5 дней в неделю.<br>Работа непыльная, зарплата небольшая, но на жизнь хватает. В обязанности входит следить за качеством работы оборудования и персонала.///'
 			if serge_textbk = 3:$serge_textbk = 'Вы спросили про его отношения с сыном. Сергей машет рукой: \\\- Нормальные у нас отношения, вот только этот оболтус совсем отбился от рук, последний год ничего делать не хочет, учится хреново, шляется постоянно хрен знает где, да с дружками своими тусит.<br>Пробовал разными методами вразумить, но ничего не помогает, даже не знаю - чего с ним делать.///'
			if serge_textbk = 4:$serge_textbk = 'Немного поболтав, вы уходите.'
		if sergebazarkuh_count <= 0:'\\\- "<<$name>>, прекращай отвлекать меня от готовки - сгорит всё к херам!/// - отмахивается от вас Сергей.'
		if sergebazarkuh_count > 0:gs 'zz_render', '', '', '<<$serge_textbk>>'
	act 'Далее': gt 'Serge_kuh'
end
act 'Предложить помощь': dynamic $serge_kuh_posuda
!end
!=========================================================================================!
!СЕРГЕЙ НА КУХНЕ БУХАЕТ (БОЛТОВНЯ, СЕКС ЭВЕНТ (отношение>=50) С 18:00 ДО 21:00(рандом 5%)!
!-----------------------------------------------------------------------------------------!
if $ARGS[0] = 'kuh_buh':
	*clr & cla
	minut += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge2.jpg', func('Serge_kuh_strings', '4')
		dynamic $serge_shulgin_rep
	act 'Отойти': dynamic $shkuh
act 'Поговорить':
		*clr & cla
		if sergebazarkuh_count > 0:minut += 15
		sergebazarkuh_day = daystart
		sergebazarkuh_count -= 1
		if sergebazarkuh_count > 0: gs 'npc_editor','change_rep','+', 36
		gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge1.jpg', func('Serge_kuh_strings', '5')
serge_textbuhk = RAND(0,4)
			if serge_textbuhk = 0:$serge_textbuhk = 'Минут 15 вы беседуете на разные темы'
			if serge_textbuhk = 1:$serge_textbuhk = 'Вы внимательно слушаете о чём говорит Сергей и иногда поддакиваете.'
			if serge_textbuhk = 2:$serge_textbuhk = 'Вы смеётесь, когда он рассказывает вам очередной анекдот.'
			if serge_textbuhk = 3:$serge_textbuhk = 'Сергей рассказывает вам анекдот:<br>Идут два алкаша:<br>- Лёха!.. Мы где?.. В джунглях?!..<br>- Сёма, твою мать!.. Убери укроп с очков...'
			if serge_textbuhk = 4:$serge_textbuhk = '<<$name>>, а знаешь почему наш народ пить не умеет?<br>Это всё потому что у нас всего две стадии:<br>1.Чё-то вообще не взяло!<br>2.Блииин, я в гoвнoооо...'
			if serge_textbuhk = 5:$serge_textbuhk = 'Сергей ухмыляется: \\\- Если выбирать между Паркинсоном и Альцгеймером, я выбрал бы Паркинсона. Лучше пролить немного водки себе на брюки, чем забыть, куда ты поставил целую бутылку!///'
	if sergebazarkuh_count <= 0:'- "<<$name>>, я не хочу сейчас разговаривать, не мешай мне. - гонит вас Сергей.'
	if sergebazarkuh_count > 0:'<<$serge_textbuhk>>'
	act 'Далее': gt 'Serge_kuh','kuh_buh'
end
if $npc['36,relation'] >= 50: act 'Попросить и вам налить': dynamic $serge_kuh_buh
end
$serge_kuh_buh = {
	*clr & cla
	minut += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko2.jpg', func('Serge_kuh_strings', '6')
	act 'Уйти': dynamic $shkuh
		act 'Обидеться':
			*clr & cla
			minut += 2
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko1.jpg', func('Serge_kuh_strings', '7')
			act 'Согласиться':
			*clr & cla
			minut += 2
			if beer_count > 0: gs 'zz_funcs', 'alko'
			beer_day = daystart
			if beer_count > 0: beer_count -= 1
			gs'stat'
			'<center><img src="images/zsoft/pod_ezd/shulgahome/kuh/event/alko2.jpg"></center>Лицо ваше изменилось, подобрело и вы киваете в знак согласия.'
if beer_count > 0:
gs 'zz_render', '', '', func('Serge_kuh_strings', '8')
end
if beer_count <= 0:
gs 'zz_render', '', '', func('Serge_kuh_strings', '9')
end
				act 'Убежать': dynamic $shkuh
				act 'Остаться':
					*clr & cla
					minut += 5
					horny += 20
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko3.jpg', func('Serge_kuh_strings', '10')
						act 'Взять в рот':
						*clr & cla
						minut += 5
						bj += 1
						throat += 1
						horny += 20
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko4.jpg', func('Serge_kuh_strings', '11')
							act 'Далее':
							*clr & cla
							minut += 5
							horny += 30
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko5.jpg', func('Serge_kuh_strings', '12')
								act 'Далее':
								*clr & cla
								minut += 5
								orgasm += 1
								horny = 0
								manna += 10
								gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko6.jpg', func('Serge_kuh_strings', '13')
									act 'Далее':
									*clr & cla
									minut += 10
									horny += 5
									sex += 1
									gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko7.jpg', func('Serge_kuh_strings', '14')
dynamic $gg_devst_deflor
gs 'zz_render', '', '', func('Serge_kuh_strings', '15')
										act 'Перевернуться на живот':
										*clr & cla
										horny += 10
										minut += 10
										gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko8.jpg', func('Serge_kuh_strings', '16')
											act 'В рот':
											*clr & cla
											horny += 5
											minut += 5
											gs 'zz_funcs', 'cum', 'face'
											swallow += 1
											gs 'zz_funcs', 'cum', 'lip'
											gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko9.jpg', func('Serge_kuh_strings', '17')
												act 'Болтать':
												*clr & cla
												minut += 5
												cumfrot = 1
												gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/event/alko10.jpg', func('Serge_kuh_strings', '18')
												act 'Уйти': dynamic $shkuh
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
}
!=================================================!
!отношение > 10, доступна ПОМОЩЬ: МОЕМ ПОСУДУ, ПОЛ!
!-------------------------------------------------!
$serge_kuh_posuda = {
*clr & cla
gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/serge1.jpg"></center>'
if sergehelppos_count > 0 or sergehelppol_count > 0 : '<<$name>>, если не сложно - помой посуду или пол протри.'
if sergehelppos_count <= 0 and sergehelppol_count <= 0 : '<<$name>>, ты уже все сделала, больше на сегодня дел нет.'
act 'Уйти': gt 'Serge_kuh'
if sergehelppos_count > 0:
		act 'Мыть гору посуды':
		*clr & cla
		if sergehelppos_count > 0:minut += 30
		sergehelppos_day = daystart
		sergehelppos_count -= 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/posuda'+rand(1,5)+'.jpg', func('Serge_kuh_strings', '19')
		act 'Уйти': gt 'Serge_kuh'
		if $npc['36,relation'] >=25: dynamic $serge_kuh_help_ev1
	end
end
if sergehelppol_count > 0:
		act 'Мыть пол':
		*clr & cla
		if sergehelppol_count > 0:minut += 30
		sergehelppol_day = daystart
		sergehelppol_count -= 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/pol'+rand(1,4)+'.jpg', func('Serge_kuh_strings', '20')
		act 'Уйти': gt 'Serge_kuh'
		if $npc['36,relation'] >=25: dynamic $serge_kuh_help_ev1
	end
end
}
!==========================================================!
!ПОМОЩЬ: если отношения > 25, доступно ЗАИГРЫВАТЬ С СЕРЕГОЙ!
!----------------------------------------------------------!
$serge_kuh_help_ev1 = {
	act 'Заигрывать':
		*clr & cla
		minut +=10
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/jara' + rand(1,4) + '.jpg', func('Serge_kuh_strings', '21')
		act 'Уйти': dynamic $shkuh
		act 'Повертеть попкой':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/vert'+rand(1,10)+'.jpg', func('Serge_kuh_strings', '22')
			act 'Уйти': dynamic $shkuh
			if $npc['36,relation'] >=50 and vagina >= 1: act 'Продолжить мучать Сергея': dynamic $serge_kuh_izdev[rand(1,17)]
		end
	end
}
!============================================================!
!ПОМОЩЬ: если отношение > 50, ПРОДОЛЖАЕМ ЗАИГРЫВАТЬ С СЕРЕГОЙ!
!------------------------------------------------------------!
!$rand_kuh_sex = $serge_kuh_sex[RAND(0,2)]
$serge_kuh_izdev[1] = {
	*clr & cla
	minut +=15
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za2-1.jpg', func('Serge_kuh_strings', '23')
	act 'Далее':
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za2-2.jpg', func('Serge_kuh_strings', '24')
		act 'Далее':
			*clr & cla
			gs 'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za2-3.jpg', func('Serge_kuh_strings', '25')
			act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za2-4.jpg', func('Serge_kuh_strings', '26')
				act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za2-5.jpg', func('Serge_kuh_strings', '27')
					dynamic iif(rand(1,100)>=50,$serge_kuh_izn[1],$serge_kuh_izn[2])
				end
			end
		end
	end
}
$serge_kuh_izdev[2] = {
			*clr & cla
			minut +=15
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za1-1.jpg', func('Serge_kuh_strings', '28')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za1-2.jpg', func('Serge_kuh_strings', '29')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za1-3.jpg', func('Serge_kuh_strings', '30')
						act 'Далее':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za1-4.jpg', func('Serge_kuh_strings', '31')
							act 'Далее':
							*clr & cla
							gs'stat'
							gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za1-5.jpg', func('Serge_kuh_strings', '32')
							act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
				end
			end
		end
	end
}
$serge_kuh_izdev[3] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-1.jpg', func('Serge_kuh_strings', '33')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-2.jpg', func('Serge_kuh_strings', '34')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-3.jpg', func('Serge_kuh_strings', '35')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-4.jpg', func('Serge_kuh_strings', '36')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-5.jpg', func('Serge_kuh_strings', '37')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-6.jpg', func('Serge_kuh_strings', '38')
						act 'Далее':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za3-7.jpg', func('Serge_kuh_strings', '39')
							act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[4] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za4-1.jpg', func('Serge_kuh_strings', '40')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za4-2.jpg', func('Serge_kuh_strings', '41')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za4-3.jpg', func('Serge_kuh_strings', '42')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za4-4.jpg', func('Serge_kuh_strings', '43')
				act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
		end
	end
end
}
$serge_kuh_izdev[5] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za5-1.jpg', func('Serge_kuh_strings', '44')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za5-2.jpg', func('Serge_kuh_strings', '45')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za5-3.jpg', func('Serge_kuh_strings', '46')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za5-4.jpg', func('Serge_kuh_strings', '47')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za5-5.jpg', func('Serge_kuh_strings', '48')
					act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
			end
		end
	end
end
}
$serge_kuh_izdev[6] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za6-1.jpg', func('Serge_kuh_strings', '49')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za6-2.jpg', func('Serge_kuh_strings', '50')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za6-3.jpg', func('Serge_kuh_strings', '51')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za6-4.jpg', func('Serge_kuh_strings', '52')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za6-5.jpg', func('Serge_kuh_strings', '53')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za6-6.jpg', func('Serge_kuh_strings', '54')
						act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
				end
			end
		end
	end
end
}
$serge_kuh_izdev[7] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-1.jpg', func('Serge_kuh_strings', '55')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-2.jpg', func('Serge_kuh_strings', '56')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-3.jpg', func('Serge_kuh_strings', '57')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-4.jpg', func('Serge_kuh_strings', '58')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-5.jpg', func('Serge_kuh_strings', '59')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-6.jpg', func('Serge_kuh_strings', '60')
						act 'Далее':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-7.jpg', func('Serge_kuh_strings', '61')
							act 'Далее':
							*clr & cla
							gs'stat'
							gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za7-8.jpg', func('Serge_kuh_strings', '62')
								act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
						end
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[8] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za8-1.jpg', func('Serge_kuh_strings', '63')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za8-2.jpg', func('Serge_kuh_strings', '64')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za8-3.jpg', func('Serge_kuh_strings', '65')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za8-4.jpg', func('Serge_kuh_strings', '66')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za8-5.jpg', func('Serge_kuh_strings', '67')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za8-6.jpg', func('Serge_kuh_strings', '68')
						act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
				end
			end
		end
	end
end
}
$serge_kuh_izdev[9] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za9-1.jpg', func('Serge_kuh_strings', '69')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za9-2.jpg', func('Serge_kuh_strings', '70')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za9-3.jpg', func('Serge_kuh_strings', '71')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za9-4.jpg', func('Serge_kuh_strings', '72')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za9-5.jpg', func('Serge_kuh_strings', '73')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za9-6.jpg', func('Serge_kuh_strings', '74')
						act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
				end
			end
		end
	end
end
}
$serge_kuh_izdev[10] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-1.jpg', func('Serge_kuh_strings', '75')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-2.jpg', func('Serge_kuh_strings', '76')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-3.jpg', func('Serge_kuh_strings', '77')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-4.jpg', func('Serge_kuh_strings', '78')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-5.jpg', func('Serge_kuh_strings', '79')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-6.jpg', func('Serge_kuh_strings', '80')
						act 'Далее':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za10-7.jpg', func('Serge_kuh_strings', '81')
							act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[11] = {
	*clr & cla
	minut +=15
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-1.jpg', func('Serge_kuh_strings', '82')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-2.jpg', func('Serge_kuh_strings', '83')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-3.jpg', func('Serge_kuh_strings', '84')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-4.jpg', func('Serge_kuh_strings', '85')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-5.jpg', func('Serge_kuh_strings', '86')
					act 'Далее':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-6.jpg', func('Serge_kuh_strings', '87')
						act 'Далее':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/za11-7.jpg', func('Serge_kuh_strings', '88')
							act 'Далее': dynamic $serge_kuh_sex[RAND(1,3)]
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[12] = {
	*clr & cla
	minut +=15
	serge_countsex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-1.jpg', func('Serge_kuh_strings', '89')
	act 'Далее':
	*clr & cla
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-2.jpg', func('Serge_kuh_strings', '90')
		act 'Далее':
		*clr & cla
		horny += 5
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-3.jpg', func('Serge_kuh_strings', '91')
			act 'Далее':
			*clr & cla
			horny += 5
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-4.jpg', func('Serge_kuh_strings', '92')
				act 'Далее':
				*clr & cla
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-5.jpg', func('Serge_kuh_strings', '93')
					act 'Далее':
					*clr & cla
					horny += 20
					bj +=1
					throat += 1
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-6.jpg', func('Serge_kuh_strings', '94')
						act 'Далее':
						*clr & cla
						sex += 1
						horny += 30
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-7.jpg', func('Serge_kuh_strings', '95')
							act 'Далее':
							*clr & cla
							horny = 0
							orgasm +=1
							manna += 25
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-8.jpg', func('Serge_kuh_strings', '96')
								act 'Далее':
								*clr & cla
								horny += 10
								gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-9.jpg', func('Serge_kuh_strings', '97')
									act 'Далее':
									*clr & cla
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_funcs', 'cum', 'face'
									cumfrot = 1
									gs'stat'
									gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex1-10.jpg', func('Serge_kuh_strings', '98')
										act 'Уйти': dynamic $shkuh
								end
							end
						end
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[13] = {
	*clr & cla
	minut +=15
	if serge_countsex < 1: guy += 1
	serge_countsex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-1.jpg', func('Serge_kuh_strings', '99')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-2.jpg', func('Serge_kuh_strings', '100')
		act 'Далее':
		*clr & cla
		bj +=1
		horny += 10
		gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-3.jpg', func('Serge_kuh_strings', '101')
			act 'Далее':
			*clr & cla
			throat += 1
			horny += 10
			gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-4.jpg', func('Serge_kuh_strings', '102')
				act 'Далее':
				*clr & cla
				sex += 1
				horny += 10
				gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-6.jpg', func('Serge_kuh_strings', '103')
					act 'Далее':
					*clr & cla
					horny += 15
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-5.jpg', func('Serge_kuh_strings', '104')
						act 'Далее':
						*clr & cla
						horny += 10
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-7.jpg', func('Serge_kuh_strings', '105')
						dynamic $orgasm_dyn_serg
						act 'Далее':
							*clr & cla
							gs 'zz_funcs', 'cum', 'belly'
							swallow += 1
							gs 'zz_funcs', 'cum', 'face'
							gs 'zz_funcs', 'cum', 'lip'
							cumfrot = 1
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex2-8.jpg', func('Serge_kuh_strings', '106')
							act 'Уйти': dynamic $shkuh
						end
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[14] = {
	*clr & cla
	minut +=15
	serge_countsex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-1.jpg', func('Serge_kuh_strings', '107')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-2.jpg', func('Serge_kuh_strings', '108')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-3.jpg', func('Serge_kuh_strings', '109')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-4.jpg', func('Serge_kuh_strings', '110')
				act 'Далее':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-5.jpg', func('Serge_kuh_strings', '111')
					act 'Далее':
					*clr & cla
					bj +=1
					horny += 5
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-6.jpg', func('Serge_kuh_strings', '112')
						act 'Далее':
						*clr & cla
						throat += 1
						horny += 5
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-7.jpg', func('Serge_kuh_strings', '113')
						act 'Далее':
							*clr & cla
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							horny += 5
							cumfrot = 1
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-8.jpg', func('Serge_kuh_strings', '114')
							act 'Уйти': dynamic $shkuh
						end
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[15] = {
	*clr & cla
	minut +=15
	if serge_countsex < 1: guy += 1
	serge_countsex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex3-1.jpg', func('Serge_kuh_strings', '115')
	act 'Далее':
	*clr & cla
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex3-2.jpg', func('Serge_kuh_strings', '116')
		act 'Далее':
		*clr & cla
		horny += 5
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex3-3.jpg', func('Serge_kuh_strings', '117')
			act 'Далее':
			*clr & cla
			horny += 5
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex3-4.jpg', func('Serge_kuh_strings', '118')
				act 'Далее':
				*clr & cla
				horny += 5
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex3-5.jpg', func('Serge_kuh_strings', '119')
					act 'Далее':
					*clr & cla
					bj +=1
					throat += 1
					horny += 10
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-6.jpg', func('Serge_kuh_strings', '120')
						act 'Далее':
						*clr & cla
						anal += 1
						sex += 1
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-7.jpg', func('Serge_kuh_strings', '121')
	if analplugin = 1:
		analplugin = 0
		gs 'zz_render', '', '', func('Serge_kuh_strings', '122')
	end
gs 'zz_render', '', '', func('Serge_kuh_strings', '123')
				if lubri > 0:
					lubri -= 1
					agape = 1
					horny += 20
					gs 'zz_render', '', '', func('Serge_kuh_strings', '124')
				elseif lubri = 0:
					agape = 2
					horny += 10
					gs 'zz_render', '', '', func('Serge_kuh_strings', '125')
				end
				agapetime = totminut + (agape + 1) * 1440
gs 'zz_render', '', '', func('Serge_kuh_strings', '126')
						act 'Далее':
							*clr & cla
							gs 'zz_funcs', 'cum', 'belly'
							mastr += 1
							horny = 0
							orgasm +=1
							cumfrot = 1
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex5-8.jpg', func('Serge_kuh_strings', '127')
							act 'Уйти': dynamic $shkuh
						end
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[16] = {
	*clr & cla
	minut +=15
	if serge_countsex < 1: guy += 1
	serge_countsex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-1.jpg', func('Serge_kuh_strings', '128')
	act 'Далее':
	*clr & cla
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-2.jpg', func('Serge_kuh_strings', '129')
		act 'Далее':
		*clr & cla
		horny += 5
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-3.jpg', func('Serge_kuh_strings', '130')
			act 'Далее':
			*clr & cla
			horny += 5
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-4.jpg', func('Serge_kuh_strings', '131')
				act 'Далее':
				*clr & cla
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-5.jpg', func('Serge_kuh_strings', '132')
					act 'Далее':
					*clr & cla
					bj +=1
					horny += 10
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-6.jpg', func('Serge_kuh_strings', '133')
						act 'Далее':
						*clr & cla
						sex += 1
						horny += 20
						anal += 1
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-7.jpg', func('Serge_kuh_strings', '134')
	if analplugin = 1:
		analplugin = 0
		gs 'zz_render', '', '', func('Serge_kuh_strings', '135')
	end
gs 'zz_render', '', '', func('Serge_kuh_strings', '136')
				if lubri > 0:
					lubri -= 1
					agape = 1
					horny += 20
					gs 'zz_render', '', '', func('Serge_kuh_strings', '137')
				elseif lubri = 0:
					agape = 2
					horny += 10
				end
				agapetime = totminut + (agape + 1) * 1440
gs 'zz_render', '', '', func('Serge_kuh_strings', '138')
							act 'Далее':
							*clr & cla
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-8.jpg', func('Serge_kuh_strings', '139')
							act 'Далее':
							*clr & cla
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-9.jpg', func('Serge_kuh_strings', '140')
								act 'Далее':
								*clr & cla
								horny = 0
								manna += 15
								orgasm +=1
								gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-10.jpg', func('Serge_kuh_strings', '141')
									act 'Далее':
									*clr & cla
									gs 'zz_funcs', 'cum', 'ass'
									gs'stat'
									gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex6-11.jpg', func('Serge_kuh_strings', '142')
										act 'Уйти': dynamic $shkuh
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
}
$serge_kuh_izdev[17] = {
	*clr & cla
	minut +=15
	serge_countsex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-1.jpg', func('Serge_kuh_strings', '143')
	act 'Далее':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-2.jpg', func('Serge_kuh_strings', '144')
		act 'Далее':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-3.jpg', func('Serge_kuh_strings', '145')
			act 'Далее':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-4.jpg', func('Serge_kuh_strings', '146')
				act 'Далее':
				*clr & cla
				bj +=1
				throat += 1
				horny += 5
				gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-5.jpg', func('Serge_kuh_strings', '147')
					act 'Далее':
					*clr & cla
					sex += 1
					horny += 10
					gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-6.jpg', func('Serge_kuh_strings', '148')
						act 'Далее':
						*clr & cla
						horny += 5
						gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-7.jpg', func('Serge_kuh_strings', '149')
						act 'Далее':
							*clr & cla
							horny += 10
							gs'stat'
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-8.jpg', func('Serge_kuh_strings', '150')
							dynamic $orgasm_dyn_serg
								act 'Далее':
								*clr & cla
								gs 'zz_funcs', 'cum', 'belly'
								gs'stat'
								gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/sex4-9.jpg', func('Serge_kuh_strings', '151')
									act 'Уйти': dynamic $shkuh
							end
						end
					end
				end
			end
		end
	end
end
}
!=====================================================================================!
!ПОМОЩЬ: если отношение > 50, ПОСЛЕ ПРОДОЛЖЕНИЯ ЗАИГРЫВАНИЙ, СЕРЕГА МОЖЕТ ИЗНАСИЛОВАТЬ!
!-------------------------------------------------------------------------------------!
$serge_kuh_izn[1] = {
	*clr & cla
	minut +=5
	serge_countsex += 1
	rape += 1
	horny += 15
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/bj'+rand(1,11)+'.gif', func('Serge_kuh_strings', '152')
	act 'Далее':
	*clr & cla
	minut +=10
	horny += 25
	sex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/ra'+rand(1,4)+'.gif', func('Serge_kuh_strings', '153')
	act 'Далее':
	*clr & cla
	minut +=10
	horny += 20
	anal +=1
	agape = 2
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/ra'+rand(5,7)+'.gif', func('Serge_kuh_strings', '154')
	if analplugin = 1:
		analplugin = 0
		gs 'zz_render', '', '', func('Serge_kuh_strings', '155')
	end
	gs 'zz_render', '', '', func('Serge_kuh_strings', '156')
	act 'Далее':
	*clr & cla
	minut +=10
	horny += 25
	throat += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/foto.gif', func('Serge_kuh_strings', '157')
	act 'Далее':
	*clr & cla
	horny += 10
	gs 'zz_funcs', 'cum', 'face'
	minut += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/end1.gif', func('Serge_kuh_strings', '158')
		act 'Уйти': dynamic $shkuh
				end
			end
		end
	end
}
$serge_kuh_izn[2] = {
	*clr & cla
	minut +=10
	serge_countsex += 1
	rape += 1
	horny += 45
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/bj'+rand(1,3)+'.gif', func('Serge_kuh_strings', '159')
	act 'Далее':
	*clr & cla
	sex += 1
	anal +=1
	minut +=10
	orgasm += 1
	horny = 0
	manna += 30
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/ra'+rand(1,5)+'.gif', func('Serge_kuh_strings', '160')
		if analplugin = 1:
			analplugin = 0
			gs 'zz_render', '', '', func('Serge_kuh_strings', '161')
		end
	gs 'zz_render', '', '', func('Serge_kuh_strings', '162')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 35
	agape = 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/bj'+rand(4,11)+'.gif', func('Serge_kuh_strings', '163')
	act 'Далее':
	*clr & cla
	minut +=10
	orgasm += 1
	horny = 0
	manna = 100
	gs 'zz_funcs', 'cum', 'ass'
	mastr += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/ra'+rand(6,8)+'.gif', func('Serge_kuh_strings', '164')
	act 'Далее':
	*clr & cla
	minut +=5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/gif/end1.gif', func('Serge_kuh_strings', '165')
		act 'Уйти': dynamic $shkuh
				end
			end
		end
	end
}
!================================================================!
!ПОМОЩЬ: если отношение > 50, ПОСЛЕ ПРОДОЛЖЕНИЯ ЗАИГРЫВАНИЙ, СЕКС!
!----------------------------------------------------------------!
$serge_kuh_sex[1] = {
	*clr & cla
	minut +=5
	serge_countsex += 1
	horny += 10
	if serge_countsex < 1: guy += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex1-1.jpg', func('Serge_kuh_strings', '166')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 15
	bj += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex1-2.jpg', func('Serge_kuh_strings', '167')
	act 'Далее':
	*clr & cla
	minut +=10
	horny += 25
	sex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex1-3.jpg', func('Serge_kuh_strings', '168')
	act 'Далее':
	*clr & cla
	minut +=10
	gs 'zz_funcs', 'cum', 'face'
	orgasm += 1
	horny = 0
	manna = 100
	cumfrot = 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex1-4.jpg', func('Serge_kuh_strings', '169')
		act 'Уйти': dynamic $shkuh
			end
		end
	end
}
$serge_kuh_sex[2] = {
	*clr & cla
	minut +=5
	serge_countsex += 1
	horny += 10
	if serge_countsex < 1: guy += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex2-1.jpg', func('Serge_kuh_strings', '170')
	act 'Далее':
		*clr & cla
		minut +=5
		horny += 10
		throat += 1
		bj += 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex2-2.jpg', func('Serge_kuh_strings', '171')
		act 'Далее':
			*clr & cla
			minut +=5
			horny += 25
			sex += 1
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex2-3.jpg', func('Serge_kuh_strings', '172')
			act 'Далее':
				*clr & cla
				horny += 25
				minut +=5
				gs'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex2-4.jpg', func('Serge_kuh_strings', '173')
				act 'Далее':
					*clr & cla
					minut +=10
					orgasm += 1
					horny = 0
					manna = 100
					gs'stat'
					gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex2-5.jpg', func('Serge_kuh_strings', '174')
					gs 'zz_funcs', 'cum', 'pussy'
					act 'Уйти': dynamic $shkuh
				end
			end
		end
	end
}
$serge_kuh_sex[3] = {
	*clr & cla
	minut +=5
	serge_countsex += 1
	horny += 15
	manna += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-1.jpg', func('Serge_kuh_strings', '175')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 10
	bj +=1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-2.jpg', func('Serge_kuh_strings', '176')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 10
	sex += 1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-3.jpg', func('Serge_kuh_strings', '177')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 20
	manna += 5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-4.jpg', func('Serge_kuh_strings', '178')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 10
	anal +=1
	agape = 1
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-5.jpg"></center>'
		if analplugin = 1:
			analplugin = 0
			gs 'zz_render', '', '', func('Serge_kuh_strings', '179')
		end
	gs 'zz_render', '', '', func('Serge_kuh_strings', '180')
	act 'Далее':
	*clr & cla
	minut +=5
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-6.jpg', func('Serge_kuh_strings', '181')
	act 'Далее':
	*clr & cla
	minut +=5
	orgasm +=1
	horny = 0
	manna = 100
	cumpussy +=1
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/kuh/help/event/sex3-7.jpg', func('Serge_kuh_strings', '182')
			act 'Уйти': dynamic $shkuh
						end
					end
				end
			end
		end
	end
}