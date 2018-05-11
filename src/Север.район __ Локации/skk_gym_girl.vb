gs 'stat'
!'
ivent_loc - место где появляется шанс на срабатывание ивента. Сделано, чтобы не было подряд рандомных потрахушек
Слышны подозрительные звуки при подходе к раздевалке 1
При входе в раздевалку 2
Осторожно заглянуть в кабинку 3
принять душ в кабинке 4
помыться в общем душе 5
зашла в туалет и увидела 6
зашла в туалет и поучаствовала 7
ivent_minut - отсчитывает интервалы между ивентами, не чаще 1 ивента в час
'
! отключение ивентов на 60 минут
if ivent_minut + 60 < minut_global : ivent_loc = 0
! блок на постоянное хлопанье дверью
if in_shower_minut + 10 >= minut_global:
	in_shower +=1
	in_shower_minut = minut_global
else
	in_shower = 0
	in_shower_minut = minut_global
end
!Если больше 4 раз подряд заходит в раздевалку - Матюги от тренера!
if in_shower>=4:
	*clr & cla
	gs 'zz_render','Коридор','city/north/skk/gym/train/GG_nark.jpg', $skk_gym_[254]
	wait 700
	gt 'skk_gym'
	exit
end
$loc = $curloc
!вход в раздевалку
gs 'zz_render','Женская раздевалка','city/north/skk/gym/shower/girl/girl_shower.jpg','Женская раздевалка, совмещённая с <a href="exec:GT ''skk_gym_girl'',''shower''">душевой</a>.На стене висит огромное <a href="exec:GT ''mirror'',''start''">зеркало</a>. В углу стоит ваш <a href="exec:GT ''loker''">Шкафчик</a>'
!---Подозрительные звуки, инициируется при входе в раздевалку, такой же модуль должен быть мужской раздевалке.
if rand(100) > 70 and $args[0] = 'in' and ivent_loc = 1:
	*clr & cla
	!в какой качалке услышала шум
	if rand(1,2) = 1 :
		!в мужской
		gs 'zz_render','Тренажерный зал','city/north/skk/gym/zal.jpg',$skk_gym_[45] +'<a href="exec:GT ''skk_gym_men'',''random_event''"><b><<$skk_gym_[46]>></b></a>'
		act 'Не обращать внимания' : gt 'skk_gym_girl'
	else
		!в женской
		gs 'zz_render','Тренажерный зал','city/north/skk/gym/zal.jpg',$skk_gym_[51] + '<a href="exec:GT ''skk_gym_girl'',''random_event''"><b><<$skk_gym_[46]>></b></a>'
		act 'Подождать' :
			*clr & cla
			gs 'zz_render','Тренажерный зал','city/north/skk/gym/zal.jpg','Лучше  я тут подожду, а то мало ли, еще перепадет и мне пару палок... Вы сделали вид, будто усилено изучаете разные плакаты и информационные листки, которых на стене было превиликое множество. Не смотря на то, что вы пытались всеми силами не слышать шороха стонов из раздевалки, воображение вес равно так и наравило дорисовать картинку к звуку. Это вас немного возбудило  Спустя 10 минут. Звуки стихли и вы поняли, что путь свободен.'
			minut += 10
			horny += 2
			act 'Зайти' : gt 'skk_gym_girl'
		end
	end
	exit
end
!---/Подозрительные звуки
!---душевая
if $args[0] = 'shower' :
	*clr & cla
	gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/shower.jpg','Женская душевая. '+iif (rand(100)>60 and ivent_loc = 3, 'Вы слышите странные звуки... <a href="exec:GT ''skk_gym_girl'',''shower_over_random''">Осторожно заглянуть в кабинку.</a>','')
	act 'Принять душ':
		i = rand(1,6)
		gs 'zz_bathroom','shower'
		*clr & cla
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_shower<<rand(1,10)>>.jpg','Наслаждаясь упругими струями, Вы обретаете первозданную чистоту.'
		if rand(100) > 60 and vagina > 0 and ivent_loc = 4:
			gs 'zz_render','','','<<$skk_gym_[i+124]>>**<a href="exec:GT ''skk_gym_girl'',''shower_GG_random'',i">Обернуться.</a>'
		end
		act 'Выйти из душевой': gt 'skk_gym_girl'
	end
	exit
end
!---рандом когда ГГ из раздевалки подглядывает, кто моется в душе
if $args[0] = 'shower_over_random' :
	*clr & cla
	exit
end
!---/рандом когда ГГ из раздевалки подглядывает, кто моется в душе
!---Секс ивент в раздевалке (подсматривает)
if $args[0] = 'random_event' :
	if deistvie ! 0 : jump 'event'
	ivent = rand(1,9)
	minut += 15
	ivent_minut = minut_global
	if ivent = 1 : deistvie = 49 & mastr += 3 & voyeurism += 1 & horny = 0 & orgasm += 3 & manna += 15 & $i_end = 'webm'
	if ivent = 2 : deistvie = 28 & mastr += 2 & voyeurism += 1 & horny = 0 & orgasm += 2 & manna += 15 & $i_end = 'jpg'
	if ivent = 3 : deistvie = 14 & manna += 15 & voyeurism += 1 & horny += 10& $i_end = 'jpg'
	if ivent = 4 : deistvie = 17 & mastr += 1 & voyeurism += 1 & horny = 0 & orgasm += 1 & manna += 15 & $i_end = 'jpg'
	if ivent = 5 : deistvie = 9 & manna += 5 & voyeurism += 1 & horny += 10 & $i_end = 'jpg'
	if ivent = 6 : deistvie = 9 & manna += 5 & voyeurism += 1 & horny += 10 & $i_end = 'jpg'
	if ivent = 7 : deistvie = 49 & mastr += 1 & voyeurism += 1 & horny = 0 & orgasm += 1 & manna += 15 & $i_end = 'jpg'
	if ivent = 8 : deistvie = 11 & voyeurism += 1 & manna += 15 & horny += 10 & $i_end = 'jpg'
	if ivent = 9 : deistvie = 19 & manna += 5 & voyeurism += 1 & horny += 10 & $i_end = 'jpg'
	if ivent = 10 : deistvie = 12 & manna += 5 & voyeurism += 1 & horny += 10 & $i_end = 'jpg'
	if ivent = 11 : deistvie = 17 & manna += 5 & voyeurism += 1 & horny += 10 & $i_end = 'jpg'
	if ivent = 12 : deistvie = 31 & mastr += 1 & manna += 5 & voyeurism += 1 & horny += 10 & $i_end = 'jpg'
	if ivent = 13 : deistvie = 19 & orgasm += 2 & mastr += 2 & manna += 5 & voyeurism += 1 & $i_end = 'jpg'
	if ivent = 14 : deistvie = 27 & orgasm += 1 & mastr += 1 & manna += 5 & voyeurism += 1 & $i_end = 'jpg'
	i = 1
	:event
	ivent_i = '<<ivent>>0<<i>>'
	if i < deistvie :
		*clr & cla
		!описание действия
		gs 'zz_render','Женская раздевалка','city/north/skk/gym/shower/girl/GG_raz<<ivent>>/GG_event<<i>>.<<$i_end>>',$skk_gym_raz[ivent_i]
		i += 1
		act 'Далее' :  gt 'skk_gym_girl', 'random_event'
		exit
	else
		!последние действие ивента и уход в локацию
		*clr & cla
		gs 'zz_render','Женская раздевалка','city/north/skk/gym/shower/girl/GG_raz<<ivent>>/GG_event<<i>>.jpg',$skk_gym_raz[ivent_i]
		act 'Зайти' :
			killvar 'ivent'
			killvar 'deistvie'
			killvar 'i'
			gt 'skk_gym_girl'
		end
	end
	exit
end
!---/Секс ивент в раздевалке (подсматривает)
!---рандом когда моется ГГ в кабинке
if $args[0] = 'shower_GG_random' :
	*clr & cla
	i = args[1]
	!1 рандом
	if i = 1 :
		!c девушкой
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event1.jpg',$skk_gym_[131]
		!если хватает разврата
		if shameless['flag'] > 1 :
			act 'Ответить':
				gs 'zz_render','','',$skk_gym_[133]
				act 'Поцеловать' :
					*clr & cla
					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event2.jpg',$skk_gym_[134]
					act 'Ласкать' :
						*clr & cla
						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event3.jpg',$skk_gym_[135]
						act 'Ласкать' :
							*clr & cla
							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event4.jpg',$skk_gym_[136]
							act 'Сесть' :
								*clr & cla
								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event5.jpg',$skk_gym_[137]
								act 'Наблюдать' :
									*clr & cla
									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event6.jpg',$skk_gym_[138]
									act 'Куни' :
										horny = 90
										*clr & cla
										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event7.jpg',$skk_gym_[139]
										act 'Продолжать' :
											*clr & cla
											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event8.jpg',$skk_gym_[140]
											act 'Продолжать' :
												*clr & cla
												gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event9.jpg',$skk_gym_[141]
												act 'Продолжать' :
													*clr & cla
													gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event10.jpg',$skk_gym_[142]
													act 'Продолжать' :
														*clr & cla
														gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event11.jpg',$skk_gym_[143]
														act 'Подняться' :
															*clr & cla
															gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event12.jpg',$skk_gym_[144]
															act 'Прижаться' :
																*clr & cla
																gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event13.jpg',$skk_gym_[145]
																act 'Поцеловаться' :
																	*clr & cla
																	gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event14.jpg',$skk_gym_[146]
																	act 'Наслаждаться' :
																		*clr & cla
																		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event15.jpg',$skk_gym_[147]
																		act 'Наслаждаться' :
																			*clr & cla
																			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event16.jpg',$skk_gym_[148]
																			act 'Стонать' :
																				*clr & cla
																				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event17.jpg',$skk_gym_[149]
																				act 'Помогать' :
																					*clr & cla
																					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event18.jpg',$skk_gym_[150]
																					act 'Кончить' :
																						lesbian += 1
																						horny = 0
																						orgasm += 1
																						*clr & cla
																						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event19.jpg',$skk_gym_[151]
																						act 'Целоваться' :
																							*clr & cla
																							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event20.jpg',$skk_gym_[152]
																							act 'Сесть на пол' :
																								*clr & cla
																								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event21.jpg',$skk_gym_[153]
																								act 'Целоваться' :
																									horny += 20
																									*clr & cla
																									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event22.jpg',$skk_gym_[154]
																									act 'Наслаждаться' :
																										horny += 20
																										*clr & cla
																										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event23.jpg',$skk_gym_[155]
																										act 'Далее' :
																											horny += 20
																											*clr & cla
																											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event24.jpg',$skk_gym_[156]
																											act 'Наслаждаться' :
																												horny += 20
																												*clr & cla
																												gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event25.jpg',$skk_gym_[157]
																												act 'Кончить' :
																													horny = 0
																													orgasm += 1
																													*clr & cla
																													gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event26.jpg',$skk_gym_[158]
																													act 'Подняться' :
																														*clr & cla
																														gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event27.jpg',$skk_gym_[159]
																														act 'Отказаться' :
																															*clr & cla
																															gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event28.jpg',$skk_gym_[160]
																															act 'В раздевалку' :
																																minut +=15
																																manna += 10
																																kuni += 1
																																girl += 1
																																ivent_minut = minut_global
																																gt 'skk_gym_girl'
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
											end
										end
									end
								end
							end
						end
					end
				end
				exit
			end
		end
		act 'Испугаться' :
			*clr & cla
			minut +=1
			horny -= 5
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event1/GG_event1.jpg',$skk_gym_[132]
			act 'В раздевалку' : gt 'skk_gym_girl'
			exit
		end
	!2 рандом
	elseif i = 2 :
		!красавица с крупной грудью
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event1.jpg',$skk_gym_[161]
		if shameless['flag'] > 1 :
			act 'Поцеловать' :
				*clr & cla
				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event2.jpg',$skk_gym_[162]
				act 'Повернуться' :
					*clr & cla
					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event3.jpg',$skk_gym_[163]
					act 'Наслаждаться' :
						*clr & cla
						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event4.jpg',$skk_gym_[164]
						act 'Наслаждаться' :
							*clr & cla
							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event5.jpg',$skk_gym_[165]
							act 'Кончить' :
								*clr & cla
								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event6.jpg',$skk_gym_[166]
								act 'Ласкать её' :
									*clr & cla
									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event7.jpg',$skk_gym_[167]
									act 'Заставить кончить' :
										*clr & cla
										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event8.jpg',$skk_gym_[168]
										act 'Поцеловать' :
											*clr & cla
											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event9.jpg',$skk_gym_[169]
											act 'В раздевалку' :
												minut +=15
												manna += 5
												orgasm += 1
												lesbian += 1
												girl += 1
												ivent_minut = minut_global
												gt 'skk_gym_girl'
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
		act 'Испугаться' :
			*clr & cla
			minut +=1
			horny -= 5
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event2/GG_event1.jpg',$skk_gym_[132]
			act 'В раздевалку' : gt 'skk_gym_girl'
			exit
		end
		exit
	elseif i = 3 :
		!кобыла с дилдаком
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event1.jpg',$skk_gym_[170]
		act 'Подчиниться':
			*clr & cla
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event2.jpg',$skk_gym_[171]
			act 'Поцеловаться' :
				*clr & cla
				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event3.jpg',$skk_gym_[172]
				act 'Куни' :
					*clr & cla
					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event4.jpg',$skk_gym_[173]
					act 'Раздеть' :
						*clr & cla
						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event5.jpg',$skk_gym_[174]
						act 'Ускориться' :
							*clr & cla
							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event6.jpg',$skk_gym_[175]
							act 'Раздвинуть ноги' :
								*clr & cla
								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event7.jpg',$skk_gym_[176]
								act 'Наслаждаться' :
									*clr & cla
									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event8.jpg',$skk_gym_[177]
									act 'Подчиниться ' :
										*clr & cla
										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event9.jpg',$skk_gym_[178]
										act 'Открыть рот' :
											*clr & cla
											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event10.jpg',$skk_gym_[179]
											act 'Продолжить' :
												*clr & cla
												gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event11.jpg',$skk_gym_[180]
												act 'Подчиниться' :
													*clr & cla
													gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event12.jpg',$skk_gym_[181]
													act 'Дилдо' :
														*clr & cla
														gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event13.jpg',$skk_gym_[182]
														act 'Трахать елдаком' :
															*clr & cla
															gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event14.jpg',$skk_gym_[183]
															act 'Кончить' :
																*clr & cla
																gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event15.jpg',$skk_gym_[184]
																act 'Фистинг' :
																	*clr & cla
																	gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event16.jpg',$skk_gym_[185]
																	act 'Поиметь ногой' :
																		*clr & cla
																		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event17.jpg',$skk_gym_[186]
																		act 'Продолжить' :
																			*clr & cla
																			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event18.jpg',$skk_gym_[187]
																			act 'Наслаждаться' :
																				*clr & cla
																				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event3/GG_event19.jpg',$skk_gym_[188]
																				act 'В раздевалку' :
																					minut +=15
																					manna += 5
																					orgasm += 1
																					lesbian += 1
																					girl += 1
																					dom -= 2
																					if throat <= 15 : throat += 1
																					if vagina <= 15 : vagina  += 1
																					ivent_minut = minut_global
																					gt 'skk_gym_girl'
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
										end
									end
								end
							end
						end
					end
				end
			end
		end
		exit
	elseif i = 4 :
		!2 девочки пришли к ГГ
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event1.jpg',$skk_gym_[189]
		!согласиться
		if shameless['flag'] > 1 :
			act 'Раздвинуть ноги':
				*clr & cla
				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event2.jpg',$skk_gym_[190]
				act 'Наслаждаться' :
					*clr & cla
					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event3.jpg',$skk_gym_[191]
					act 'Кончить' :
						*clr & cla
						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event4.jpg',$skk_gym_[192]
						act 'Ласкать' :
							*clr & cla
							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event5.jpg',$skk_gym_[193]
							act 'Лизать' :
								*clr & cla
								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event6.jpg',$skk_gym_[194]
								act 'Куни' :
									*clr & cla
									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event7.jpg',$skk_gym_[195]
									act 'Продолжить' :
										*clr & cla
										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event8.jpg',$skk_gym_[196]
										act 'Ласкать' :
											*clr & cla
											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event9.jpg',$skk_gym_[197]
											act 'Наблюдать' :
												*clr & cla
												gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event10.jpg',$skk_gym_[198]
												act 'Прижаться' :
													*clr & cla
													gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event11.jpg',$skk_gym_[199]
													act 'Улыбнуться' :
														*clr & cla
														gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event12.jpg',$skk_gym_[200]
														act 'В раздевалку' :
															minut += 15
															kuni += 1
															manna += 15
															horny = 0
															orgasm += 1
															lesbian += 1
															girl += 2
															ivent_minut = minut_global
															gt 'skk_gym_girl'
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
				end
			end
		end
		act 'Испугаться' :
			*clr & cla
			minut +=1
			horny -= 5
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event4/GG_event1.jpg',$skk_gym_[132]
			act 'В раздевалку' : gt 'skk_gym_girl'
			exit
		end
	elseif i = 5 :
		*clr & cla
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event1.jpg',$skk_gym_[206]
		act 'Далее' :
			*clr & cla
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event2.jpg',$skk_gym_[207]
			act 'Далее' :
				*clr & cla
				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event3.jpg',$skk_gym_[208]
				act 'Далее' :
					*clr & cla
					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event4.jpg',$skk_gym_[209]
					act 'Далее' :
						*clr & cla
						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event5.jpg',$skk_gym_[210]
						act 'Далее' :
							*clr & cla
							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event6.jpg',$skk_gym_[211]
							act 'Далее' :
								*clr & cla
								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event7.jpg',$skk_gym_[212]
								act 'Далее' :
									*clr & cla
									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event8.jpg',$skk_gym_[213]
									act 'Далее' :
										*clr & cla
										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event9.jpg',$skk_gym_[214]
										act 'Далее' :
											*clr & cla
											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event10.jpg',$skk_gym_[215]
											act 'Далее' :
												*clr & cla
												gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event11.jpg',$skk_gym_[216]
												act 'Далее' :
													*clr & cla
													gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event12.jpg',$skk_gym_[217]
													act 'Далее' :
														*clr & cla
														gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event13.jpg',$skk_gym_[218]
														act 'Далее' :
															*clr & cla
															gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event14.jpg',$skk_gym_[219]
															act 'Далее' :
																*clr & cla
																gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event15.jpg',$skk_gym_[220]
																act 'Далее' :
																	*clr & cla
																	gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event16.jpg',$skk_gym_[221]
																	act 'Далее' :
																		*clr & cla
																		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event17.jpg',$skk_gym_[222]
																		act 'Далее' :
																			*clr & cla
																			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event18.jpg',$skk_gym_[223]
																			act 'Далее' :
																				*clr & cla
																				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event19.jpg',$skk_gym_[224]
																				act 'Далее' :
																					*clr & cla
																					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event20.jpg',$skk_gym_[225]
																					act 'Далее' :
																						*clr & cla
																						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event21.jpg',$skk_gym_[226]
																						act 'Далее' :
																							*clr & cla
																							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event22.jpg',$skk_gym_[227]
																							act 'Далее' :
																								*clr & cla
																								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event23.jpg',$skk_gym_[228]
																								act 'Далее' :
																									*clr & cla
																									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event24.jpg',$skk_gym_[229]
																									act 'Далее' :
																										*clr & cla
																										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event25.jpg',$skk_gym_[230]
																										act 'Далее' :
																											*clr & cla
																											gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event26.jpg',$skk_gym_[231]
																											act 'Далее' :
																												*clr & cla
																												gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event27.jpg',$skk_gym_[232]
																												act 'Далее' :
																													*clr & cla
																													gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event28.jpg',$skk_gym_[233]
																													act 'Далее' :
																														*clr & cla
																														gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event29.jpg',$skk_gym_[234]
																														act 'Далее' :
																															*clr & cla
																															gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event30.jpg',$skk_gym_[235]
																															act 'Далее' :
																																*clr & cla
																																gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event31.jpg',$skk_gym_[236]
																																act 'Далее' :
																																	*clr & cla
																																	gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event32.jpg',$skk_gym_[237]
																																	act 'Далее' :
																																		*clr & cla
																																		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event33.jpg',$skk_gym_[238]
																																		act 'Далее' :
																																			*clr & cla
																																			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event34.jpg',$skk_gym_[239]
																																			act 'Далее' :
																																				*clr & cla
																																				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event35.jpg',$skk_gym_[240]
																																				act 'Далее' :
																																					*clr & cla
																																					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event36.jpg',$skk_gym_[241]
																																					act 'Далее' :
																																						*clr & cla
																																						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event37.jpg',$skk_gym_[242]
																																						act 'Далее' :
																																							*clr & cla
																																							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event38.jpg',$skk_gym_[243]
																																							act 'Далее' :
																																								*clr & cla
																																								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event39.jpg',$skk_gym_[244]
																																								act 'Далее' :
																																									*clr & cla
																																									gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event40.jpg',$skk_gym_[245]
																																									act 'Далее' :
																																										*clr & cla
																																										gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event41.jpg',$skk_gym_[246]
																																										act 'В раздевалку' :
																																											minut += 15
																																											kuni += 1
																																											manna += 15
																																											horny = 0
																																											orgasm += 1
																																											lesbian += 1
																																											girl += 1
																																											ivent_minut = minut_global
																																											gt 'skk_gym_girl'
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
		end
		act 'Испугаться' :
			*clr & cla
			minut +=1
			horny -= 5
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event5/GG_event1.jpg',$skk_gym_[132]
			act 'В раздевалку' : gt 'skk_gym_girl'
			exit
		end
	elseif i = 6 :
		*clr & cla
		gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event1.jpg',$skk_gym_[247]
		act 'Далее' :
			*clr & cla
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event2.jpg',$skk_gym_[248]
			act 'Далее' :
				*clr & cla
				gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event3.jpg',$skk_gym_[249]
				act 'Далее' :
					*clr & cla
					gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event4.jpg',$skk_gym_[250]
					act 'Далее' :
						*clr & cla
						gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event5.jpg',$skk_gym_[251]
						act 'Далее' :
							*clr & cla
							gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event6.jpg',$skk_gym_[252]
							act 'Далее' :
								*clr & cla
								gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event7.jpg',$skk_gym_[253]
								act 'В раздевалку' :
									minut += 15
									kuni += 1
									manna += 15
									horny = 0
									orgasm += 1
									lesbian += 1
									girl += 2
									ivent_minut = minut_global
									gt 'skk_gym_girl'
								end
							end
						end
					end
				end
			end
		end
		act 'Испугаться' :
			*clr & cla
			minut +=1
			horny -= 5
			gs 'zz_render','Женская душевая','city/north/skk/gym/shower/girl/GG_event6/GG_event1.jpg',$skk_gym_[132]
			act 'В раздевалку' : gt 'skk_gym_girl'
			exit
		end
	end
	exit
end
!---/рандом когда моется ГГ в кабинке
!уйти в коридор
act 'В коридор' : gt 'skk_gym_kor'