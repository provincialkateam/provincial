if $args[0] = 'rexGdkTalk':
	if $npc['27,relation'] < 60:
		$rexTalk[0] = 'Вы болтаете с Рексом на разные темы.'
		$rexTalk[1] = 'Вы болтаете с Рексом, он рассказывает вам, как летом ездил с родителями в Абхазию.'
		$rexTalk[2] = 'Вы болтаете с Рексом и узнаете, что он очень любит фотографировать и мечтает стать фотографом.'
		$rexTalk[3] = 'Вы болтаете с Рексом, он рассказывает, что у его отца свой автосервис и он иногда не плохо там подрабатывает.'
		$rexTalk[4] = 'Вы болтаете с Рексом, он рассказывает вам, как попал в аварию.'
		$rexTalk[5] = 'Вы болтаете с Рексом, он говорит, что на самом деле его зовут Егор, а Рекс - это кликуха.'
		gs 'zz_render','','',$rexTalk[rand(0,5)]
		killvar '$rexTalk'
		act 'Продолжать пить пиво': gt'annafrends2'
		exit
	else
		i = rand(1,10)
		if i = 10 and $npc['27,relation'] >= 80:
			*clr
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/rexhistory1.jpg', func('reks_strings', 'local_str2')
			act 'Продолжать пить пиво': gt'annafrends2'
			exit
		elseif i < 3 and $npc['27,relation'] >= 80 and $npc['38,qwRexSisTalk'] < 4:
			if $npc['38,qwRexSisTalk'] = 0:
				gs 'zz_render', '', '', func('reks_strings', 'local_str3')
				$npc['38,qwRexSisTalk'] += 1
				act 'Продолжать пить пиво': gt'annafrends2'
				exit
			elseif $npc['38,qwRexSisTalk'] = 1:
				gs 'zz_render', '', '', func('reks_strings', 'local_str4')
				$npc['38,qwRexSisTalk'] += 1
				act 'Продолжать пить пиво': gt'annafrends2'
				exit
			elseif $npc['38,qwRexSisTalk'] = 2:
				cla
				gs 'zz_render', '', '', func('reks_strings', 'local_str5')
				act 'Согласиться':
					gs 'npc_editor','change_rep','+', 27
					gs 'zz_render', '', '', func('reks_strings', 'local_str6')
					rexPark = 1
					rexParkDay = daystart + 1
					act 'Продолжать пить пиво': gt'annafrends2'
				end
				act 'Отказаться':
					gs 'npc_editor','change_rep','-', 27, 3
					gs 'zz_render', '', '', func('reks_strings', 'local_str7')
					act 'Продолжать пить пиво': gt'annafrends2'
				end
				exit
			elseif $npc['38,qwRexSisTalk'] = 3:
				cla
				gs 'zz_render', '', '', func('reks_strings', 'local_str8')
				act 'Отказаться':
					gs 'npc_editor','change_rep','-', 27, 5
					gs 'zz_render', '', '', func('reks_strings', 'local_str9')
					act 'Продолжать пить пиво': gt'annafrends2'
				end
				act 'Согласиться':
					gs 'npc_editor','change_rep','+', 27
					gs 'zz_render', '', '', func('reks_strings', 'local_str10')
					rexCar = 1
					rexCarDay = daystart + 1
					act 'Продолжать пить пиво': gt'annafrends2'
				end
				exit
			end
		elseif i < 4 and $npc['27,relation'] >= 80 and $npc['38,qwRexSisTalk'] = 4 and rexCar ! 1 and rexCarCount < 9:
			gs 'zz_render', '', '', func('reks_strings','local_str11')
			act 'Отказаться':
				gs 'npc_editor','change_rep','-', 27
				gs 'zz_render','','',func('reks_strings','local_str12')
				act 'Продолжать пить пиво': gt'annafrends2'
			end
			act 'Согласиться':
				gs 'npc_editor','change_rep','+', 27
				gs 'zz_render','','',func('reks_strings','local_str13')
				rexCar = 1
				rexCarDay = daystart + 1
				act 'Продолжать пить пиво': gt'annafrends2'
			end
			exit
		else
			$rexTalk[0] = 'Вы болтаете с Рексом, он рассказывает вам, как иногда вечерами в тихоря берёт ключ от отцовской машины, пока того нет дома и катается без прав.'
			$rexTalk[1] = 'Вы болтаете с Рексом на разные темы, иногда он делает вам комплименты.'
			$rexTalk[2] = 'Вы болтаете с Рексом, он рассказывает какой крутой фотик ему подарили родители на день рождения.'
			$rexTalk[3] = 'Вы болтаете с Рексом, - "Ты знаешь, вот смотрю на вас с Анькой, определенно у вас много общего…"'
			$rexTalk[4] = 'Вы болтаете с Рексом, он говорит, что учится в автошколе и если повезёт, то вскоре получит права.'
			$rexTalk[5] = 'Вы болтаете с Рексом, с каждым разом он всё больше вам нравится, оказывается ни такой уж он и странный.'
			gs 'zz_render','','',$rexTalk[rand(0,5)]
			killvar '$rexTalk'
			act 'Продолжать пить пиво': gt 'annafrends2'
		end
	end
end
if $ARGS[0] = 'skver':
	*clr & cla
	rexPark = 2
	$npc['38,qwRexSisTalk'] += 1
	minut += 5
	gs 'npc_editor','change_rep','+', 27
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('zz_funcs', 'relation', 27)
	gs 'zz_render', '', '', func('reks_strings', 'local_str14')
	act 'Гулять':
		*clr & cla
		minut += 30
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Reks/progulpark.jpg', func('reks_strings', 'local_str15')
		act 'Далее':
			*clr & cla
			minut += 30
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/rexozero.jpg', func('reks_strings', 'local_str16')
			act 'Далее':
				*clr & cla
				minut += 30
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/newclo/8.jpg', func('reks_strings', 'local_str17')
				if dom > 5:
					act 'Уговорить Рекса купить платье':
						cla
						minut += 20
						gs 'zz_clothing', 'init_clothing'
						gs 'zz_clothing', 'add_to_wardrobe', 127
						gs 'zz_clothing', 'dispose'
						gs 'zz_render', '', '', func('reks_strings', 'local_str18')
						act 'В городок':gt'gorodok'
					end
				else
					act 'Посмотреть на Рекса':
						cla
						minut += 5
						gs'stat'
						gs 'zz_render', '', '', func('reks_strings', 'local_str19')
						act 'Отказаться':
							minut += 20
							gs 'zz_render', '', '', func('reks_strings', 'local_str20')
							act 'В городок':gt'gorodok'
						end
						act 'Согласиться':
							cla
							minut += 30
							gs 'zz_clothing', 'init_clothing'
							gs 'zz_clothing', 'add_to_wardrobe', 127
							gs 'zz_clothing', 'dispose'
							gs 'npc_editor','change_rep','+', 27
							gs 'stat'
							gs 'zz_render', '', '', func('reks_strings', 'local_str21')
							act 'Далее':
								*clr & cla
								zz_id = func('zz_clothing','is_exists', 127)
								if zz_id >= 0: gs 'zz_clothing', 'redress', zz_id
								killvar 'zz_id'
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Svet/fpr4.jpg', func('reks_strings', 'local_str22')
								act 'Идти в парк':
									*clr & cla
									minut += 10
									gs 'stat'
									gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Svet/fpr1.jpg', func('reks_strings', 'local_str23')
									act 'Далее':
										*clr & cla
										gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Svet/fpr2.jpg', func('reks_strings', 'local_str24')
										act 'Далее':
											*clr & cla
											gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Svet/fpr3.jpg', func('reks_strings', 'local_str25')
											act 'Смотреть':
												*clr & cla
												gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr1.jpg', func('reks_strings', 'local_str26')
												act 'Смотреть дальше':
													*clr & cla
													gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr2.jpg', func('reks_strings', 'local_str27')
													act 'Смотреть дальше':
														*clr & cla
														gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr3.jpg', func('reks_strings', 'local_str28')
														act 'Смотреть дальше':
															*clr & cla
															gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr4.jpg', func('reks_strings', 'local_str29')
															act 'Смотреть дальше':
																*clr & cla
																gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr5.jpg', func('reks_strings', 'local_str30')
																act 'Смотреть дальше':
																	*clr & cla
																	gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr6.jpg', func('reks_strings', 'local_str31')
																	act 'Смотреть дальше':
																		*clr & cla
																		gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr7.jpg', func('reks_strings', 'local_str32')
																		act 'Смотреть дальше':
																			*clr & cla
																			gs 'zz_render', '', 'images/qwest/alter/Reks/Rex foto/Sister/fsr8.jpg', func('reks_strings', 'local_str33')
																			act 'Далее':
																				*clr & cla
																				minut += 20
																				horny += 10
																				$npc['27,relation'] = 70
																				gs 'stat'
																				gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('reks_strings', 'local_str34')
																				gs 'zz_render', '', '', func('zz_funcs', 'relation', 27)
																				act 'Уйти': gt'gorodok'
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
if $ARGS[0] = 'avto':
	*clr & cla
	rexCar = 0
	$npc['38,qwRexSisTalk'] += 1
	minut += 5
	gs 'npc_editor','change_rep','+',27
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/Reks/skoda.jpg', func('reks_strings', 'local_str35')
	if dom > 5:
		act 'Отказаться':
			*clr & cla
			minut += 20
			gs 'npc_editor','change_rep','-',27
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('reks_strings', 'local_str42')
			gs 'reks','rexstory'
		end
	end
	act 'Согласиться':
		*clr & cla
		gs 'zz_funcs','alko',2
		gs 'npc_editor','change_rep','+',27
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/Reks/Rex.jpg', func('reks_strings', 'local_str43')
		gs 'reks','rexstory'
	end
end
if $args[0] = 'rexstory':
	gs 'zz_render', '', '', func('reks_strings', 'local_str36')
	act 'Далее':
		*clr & cla
		minut += 10
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/Reks/utrmin.jpg', func('reks_strings', 'local_str37')
		act 'Продолжать слушать':
			*clr & cla
			minut += 10
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/minrex.gif', func('reks_strings', 'local_str38')
			act 'Далее':
				*clr & cla
				minut += 10
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/minrex2.gif', func('reks_strings', 'local_str39')
				act 'Далее':
					*clr & cla
					minut += 10
					horny += 5
					gs 'stat'
					gs 'zz_render', '', '', func('reks_strings', 'local_str40')
					act 'Далее':
						*clr & cla
						minut += 30
						if horny < 95: horny = 95
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/Reks/rudivl.jpg', func('reks_strings', 'local_str41')
						act 'Домой':gt'gorodok'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'avto2':
	*clr & cla
	rexCar = 0
	rexCarCount += 1
	minut += 30
	gs 'npc_editor','change_rep','+', 27
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/Reks/CarRex1.jpg'
	gs 'reks','rexCarEnd'
	if rexCarCount <= 5:
		$rexTalk[0] = 'Вы катаетесь с Рексом, он говорит, что ему наконец то удалось сдать на права и теперь отец иногда разрешает ему брать машину. '
		$rexTalk[1] = 'Вы катаетесь с Рексом, он рассказывает разные смешные истории.'
		$rexTalk[2] = 'Вы катаетесь с Рексом, он вспоминает как нажрался на вечеринке в честь своего дня рождения.'
		$rexTalk[3] = 'Вы катаетесь с Рексом, он делится своими мечтами, хочет когда-нибудь открыть собственный фотосалон.'
		gs 'zz_render','','', $rexTalk[rand(0,3)]
		killvar '$rexTalk'
		minut += 30
		gs 'stat'
		gs 'reks','rexCarEnd'
	elseif rexCarCount > 5 and rexCarCount <= 8:
		gs 'zz_render', '', '', func('reks_strings', 'local_str45')
		act 'Оставить':
			*clr & cla
			horny += 10
			minut += 30
			gs 'npc_editor','change_rep','+', 27
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex2.jpg', func('reks_strings', 'local_str46')
			gs 'reks','rexCarEnd'
		end
		if dom >= 5:
			act 'Убрать руку':
				*clr & cla
				minut += 30
				rexCarCount -= 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex4.jpg', func('reks_strings', 'local_str47')
				gs 'reks','rexCarEnd'
			end
		end
	elseif rexCarCount = 9:
		gs 'zz_render', '', '', func('reks_strings', 'local_str48')
		if dom >= 5:
			act 'Убрать руку':
				*clr & cla
				minut += 30
				rexCarCount -= 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex4.jpg', func('reks_strings', 'local_str49')
				gs 'reks','rexCarEnd'
			end
		end
		act 'Оставить':
			*clr & cla
			horny += 10
			minut += 10
			gs 'npc_editor','change_rep','+', 27
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex3.jpg', func('reks_strings', 'local_str50')
			if dom >= 5:
				act 'Убрать руку':
					*clr & cla
					minut += 20
					rexCarCount -= 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex4.jpg', func('reks_strings', 'local_str51')
					gs 'reks','rexCarEnd'
				end
			end
			act 'Далее':
				*clr & cla
				horny += 10
				minut += 10
				gs 'npc_editor','change_rep','+', 27
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex5.jpg', func('reks_strings', 'local_str52')
				if dom >= 5:
					act 'Убрать руку':
						*clr & cla
						minut += 10
						rexCarCount -= 1
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex6.jpg', func('reks_strings', 'local_str53')
						gs 'reks','rexCarEnd'
					end
				end
				act 'Далее':
					*clr & cla
					horny += 10
					minut += 10
					gs 'npc_editor','change_rep','+', 27
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex8.jpg', func('reks_strings', 'local_str54')
					act 'Остановить':
						*clr & cla
						horny += 10
						minut += 10
						gs 'npc_editor','change_rep','-', 27
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/Reks/CarRex9.jpg', func('reks_strings', 'local_str55')
						gs 'reks','rexCarEnd'
					end
				end
			end
		end
	end
end
if $args[0] = 'rexCarEnd':
	gs 'zz_render', '', '', func('reks_strings', 'local_str44')
	act 'Домой': gt 'gorodok'
end
if $ARGS[0] = 'sms':
	*clr & cla
	minut += 10
	$npc['27,relation'] += 1
	rexSmsDay = daystart
	gs'stat'
	'<center><img src="images/qwest/alter/Reks/SmartSist.jpg"></center>'
	if horny < 50:
		gs 'zz_render', '', '', func('reks_strings', 'local_str56')
		act 'Положить телефон на место':gt'bedrPar'
	elseif horny >= 50 and smsForRex < 4:
		gs 'zz_render', '', '', func('reks_strings', 'local_str57')
		$smsEnd = {
			act 'Отправить':
				*clr & cla
				minut += 5
				gs 'npc_editor','change_rep','+', 27
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmartSist.jpg', func('reks_strings', 'local_str58')
				act 'Посмотреть':
					minut += 5
					gs'stat'
					gs 'zz_render', '', '', func('reks_strings', 'local_str59')
					act 'Положить телефон на место':gt'bedrPar'
				end
			end
		}
		smsForRex += 1
		if smsForRex = 1:
			act 'Фото':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex1.jpg', func('reks_strings', 'local_str60')
				dynamic $smsEnd
			end
		elseif smsForRex = 2:
			act 'Фото в чулках':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex2.jpg', func('reks_strings', 'local_str61')
				dynamic $smsEnd
			end
		elseif smsForRex = 3:
			act 'Фото с надписью':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex3.jpg', func('reks_strings', 'local_str62')
				dynamic $smsEnd
			end
		elseif smsForRex = 4:
			act 'Фото в чулках':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex4.jpg', func('reks_strings', 'local_str63')
				dynamic $smsEnd
			end
		end
	elseif horny >= 50 and smsForRex >= 4 and smsForRex < 13:
		gs 'zz_render', '', '', func('reks_strings', 'local_str64')
		$smsEnd = {
			act 'Отправить':
				*clr & cla
				minut += 5
				gs 'npc_editor','change_rep','+', 27
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmartSist.jpg', func('reks_strings', 'local_str65')
				act 'Положить телефон на место':gt'bedrPar'
			end
		}
		smsForRex += 1
		horny += 5
		if smsForRex = 5:
			act 'Фото':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex5.jpg', func('reks_strings', 'local_str66')
				dynamic $smsEnd
			end
		elseif smsForRex = 6:
			act 'Фото 2':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex6.jpg', func('reks_strings', 'local_str67')
				dynamic $smsEnd
			end
		elseif smsForRex = 7:
			act 'Фото 3':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex7.jpg', func('reks_strings', 'local_str68')
				dynamic $smsEnd
			end
		elseif smsForRex = 8:
			act 'Фото 4':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex8.jpg', func('reks_strings', 'local_str69')
				dynamic $smsEnd
			end
		elseif smsForRex = 9:
			act 'Фото 5':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex9.jpg', func('reks_strings', 'local_str70')
				dynamic $smsEnd
			end
		elseif smsForRex = 10:
			act 'Фото 6':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex10.jpg', func('reks_strings', 'local_str71')
				dynamic $smsEnd
			end
		elseif smsForRex = 11:
			act 'Фото 7':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex11.jpg', func('reks_strings', 'local_str72')
				dynamic $smsEnd
			end
		elseif smsForRex = 12:
			act 'Фото 8':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex12.jpg', func('reks_strings', 'local_str73')
				dynamic $smsEnd
			end
		elseif smsForRex = 13:
			act 'Фото 9':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex13.jpg', func('reks_strings', 'local_str74')
				act 'Отправить':
					*clr & cla
					minut += 5
					gs 'npc_editor','change_rep','+', 27
					horny += 5
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex14.jpg', func('reks_strings', 'local_str75')
					act 'Ответить':
						*clr & cla
						minut += 5
						gs 'npc_editor','change_rep','+', 27
						horny += 5
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex17.jpg', func('reks_strings', 'local_str76')
						act 'Ждать':
							*clr & cla
							minut += 10
							gs 'npc_editor','change_rep','+', 27
							horny += 15
							gs'stat'
							gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex18.jpg', func('reks_strings', 'local_str77')
							if horny >= 100:
								act 'Мастурбировать':
									*clr & cla
									minut += 10
									gs 'npc_editor','change_rep','+', 27
									horny = 0
									orgasm += 1
									horny = 0
									manna = 100
									gs'stat'
									gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex15.jpg', func('reks_strings', 'local_str78')
									act 'Ответить':
										*clr & cla
										minut += 10
										gs 'npc_editor','change_rep','+', 27, 10
										gs'stat'
										gs 'zz_render', '', 'images/qwest/alter/Reks/SmsRex16.jpg', func('reks_strings', 'local_str79')
										act 'Положить телефон на место':gt'bedrPar'
									end
									act 'Не отвечать':
										gs 'zz_render', '', '', func('reks_strings', 'local_str80')
										act 'Положить телефон на место':gt'bedrPar'
									end
								end
							else
								act 'Положить телефон на место':gt'bedrPar'
							end
						end
					end
					act 'Положить телефон на место':gt'bedrPar'
				end
			end
		end
	end
end
$Party_rex_sex_cum ={
	*clr & cla
	minut += 5
	cumfrot += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	sex += 1
	if Rex_Love = 0: party_boys_in +=1
	if Rex_Love = 1: Rex_save +=1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_11_' + rand(1,4) + '.gif', func('reks_strings', 'local_str81')
	act 'Уснуть':dynamic $Party_sleep
}
$Party_rex_sex_cow ={
	*clr & cla
	minut += 5
	vagina += 1
	$npc['27,sex'] += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_10_' + rand(1,5) + '.gif', func('reks_strings', 'local_str82')
	if $npc['27,sex'] < 2:
		'Немного снизив темп, Рекс попросил сменить позицию... '
		act 'Лечь на спину': dynamic $Party_rex_sex_missionary
		act 'Встать раком': dynamic $Party_rex_sex_dog
	else
		'Рекс с дикой страстью дерет вашу дырочку, он почти на грани и готов...'
		act 'Кончить': dynamic $Party_rex_sex_cum
	end
}
$Party_rex_sex_dog ={
	*clr & cla
	minut += 5
	vagina += 1
	$npc['27,sex'] += 1
	gs 'stat'
	gs 'zz_render','','pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_9_'+rand(2,5)+'.gif',func('reks_strings','local_str83')
	if $npc['27,sex'] < 2:
		'Немного снизив темп, Рекс попросил сменить позицию...'
		act 'Запрыгнуть сверху':dynamic $Party_rex_sex_cow
		act 'Лечь на спину':dynamic $Party_rex_sex_missionary
	else
		'Рекс с дикой страстью дерет вашу дырочку, он почти на грани и готов...'
		act 'Кончить':dynamic $Party_rex_sex_cum
	end
}
$Party_rex_sex_missionary ={
	*clr & cla
	minut += 5
	vagina += 1
	$npc['27,sex'] += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_8_'+rand(1,5)+'.gif', func('reks_strings','local_str84')
	if $npc['27,sex'] < 2:
		'Немного снизив темп, Рекс попросил сменить позицию...'
		act 'Встать раком': dynamic $Party_rex_sex_dog
		act 'Запрыгнуть сверху': dynamic $Party_rex_sex_cow
	else
		'Рекс с дикой страстью дерет вашу дырочку, он почти на грани и готов...'
		act 'Кончить': dynamic $Party_rex_sex_cum
	end
}
$Party_rex_sex = {
	minut += 5
	bj += 1
	gs 'stat'
	gs 'zz_render','','pavlovo/family/sister/sisterQW/ReksHome/Party_rex_party_gost_14_7.gif'
	if Rex_Love = 1:'Рекс нежно схватил вас за волосы и стал направлять член вам в рот.'
	gs 'zz_render', '', '', func('reks_strings', 'local_str85')
	if Rex_Love = 0:'Войдя в комнату, Рекс грубо схватил вас за волосы и стал направлять член вам в рот.'
	gs 'zz_render', '', '', func('reks_strings', 'local_str86')
	act 'Лечь на спину': dynamic $Party_rex_sex_missionary
	act 'Встать раком': dynamic $Party_rex_sex_dog
	act 'Запрыгнуть сверху': dynamic $Party_rex_sex_cow
}
if $ARGS[0] = 'party':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Рекс', 'pavlovo/family/sister/sisterQW/ReksHome/Reks.jpg', func('reks_strings', 'local_str87')
	if Rex_Love =0: 'Вы подошли к Рексу, он окинул вас пьяным взглядом, словно самец оценивающий самку.'
	if Rex_Love =1: 'Рекс подошел к вам и мило приобнял.'
	act 'Отойти': gt $loc,$metka
	if $metka = 'party_home' and alko < 6: act 'Предлагает выпить': gt'sbReksHome','party_drink'
	if $metka = 'party_gost': act 'Болтать': dynamic $Party_rex_talk
	if $metka = 'party_gost': act 'Танцевать вместе': dynamic $Party_rex_dance
end