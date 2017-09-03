if $args[0] = '': $args[0] = 'main'
if $args[0] = 'main':
	*clr & cla
	gs 'zz_render', $nameBoyfrend[numnpc], 'qwest/alter/npc/<<numnpc>>.jpg', '<<$nameBoyfrend[numnpc]>> ваш парень.' + func('zz_funcs','relations',otnBoyFrend[numnpc])
	! при ненадлежащих отношениях или после 23 часов парень проводит Светку домой
	if otnBoyFrend[numnpc] < 80 or hour >= 23:
		gs 'Gnpc2', 'gt_home'
	else
		! сюда попадаем лишь при отличных отношениях и до 23 часов
		if hour < 20:
			! днем и до вечера провожаем домой или, если был секс - тащим к парню домой
			gs 'Gnpc2', iif(gnpcSex[numnpc] > 0 and rand(0,1)=0,'gt_boyhome','gt_home')
		else
			! на дискотеку или к парню
			gs 'Gnpc2', iif(rand(0,1),'gt_boyhome','gt_disco')
		end
	end
end
! блок-провожалка домой
if $args[0] = 'gt_home':
	gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk2')
	act 'Идти домой': gt 'gorodok'
end
! блок-приглашение гг на дискотеку
if $args[0] = 'gt_disco':
	gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk93')
	gs 'Gnpc2', 'disco_act'
	act 'Отказаться и идти домой': otnBoyFrend[numnpc] -= 10 & gt 'gorodok'
end
! блок-приглашение гг на потрахушки к парню домой
if $args[0] = 'gt_boyhome':
	gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk1')
	gs 'Gnpc2', 'boyhome_act'
	act 'Отказаться и идти домой': otnBoyFrend[numnpc] -= 10 & gt 'gorodok'
end
! --- обработчики ---
! дом, ивенты
if $args[0] = 'boyhome_act':
	act 'Идти к парню домой':
		*clr & cla
		minut += 15
		! установка флажка на дом парня
		_boy_back = 1
		gs 'stat'
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk81')
		if RAND(0,2) = 0:
			gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk82')
			act 'Смотреть видик':
				*clr & cla
				minut += 30
				gs 'stat'
				gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk83')
				if RAND(0,3) = 0:
					gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk84')
					act 'Смотреть порнуху':
						*clr & cla
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'qwest/alter/groped.jpg', func('Gnpc2_strings', 'boy_talk85')
						gs 'Gnpc2', 'boyhome_knee'
					end
					act 'Устроить скандал':
						*clr & cla
						dom += 1
						otnBoyFrend[numnpc] -= 20
						gs 'stat'
						gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk86')
						act 'Идти домой': gt 'gorodok'
					end
				else
					! смотрим боевик
					gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk87')
					! лапает коленко
					if RAND(0,2) = 0:
						gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk88')
						gs 'Gnpc2', 'boyhome_knee'
					else
						! уходим либо поцелуйчики
						act 'Идти домой': gt 'gorodok'
						if horny >= 75: gs 'Gnpc2', 'boyhome_kiss'
					end
				end
			end
		else
			gs 'zz_render', '', 'qwest/alter/groped.jpg', func('Gnpc2_strings', 'boy_talk9'+rand(1,2))
			gs 'Gnpc2', 'boyhome_knee'
		end
	end
end
! лапаем коленку в доме парня
if $args[0] = 'boyhome_knee':
	if horny < 90 or dom > 0: gs 'Gnpc2', 'boyhome_handsoff'
	act 'Делать вид, что ничего не происходит':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'qwest/alter/groped.jpg', func('Gnpc2_strings', 'boy_talk78')
		gs 'Gnpc2', 'boyhome_kiss'
		if horny < 75 or dom > 25: gs 'Gnpc2', 'boyhome_handsoff'
	end
	if horny >= 75: gs 'Gnpc2', 'boyhome_kiss'
end
! поцелуйчики в парня дома
if $args[0] = 'boyhome_kiss':
	act 'Поцеловать парня':
		*clr & cla
		minut += 5
		kissBoyFrend[numnpc] += 1
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'qwest/alter/Ev/kiss.jpg', func('Gnpc2_strings', 'boy_talk76') + func('Gnpc2_strings', 'boy_talk59')
		gs 'Gnpc2', 'boy_hj'
		if horny < 90: gs 'Gnpc2', 'boyhome_handsoff'
	end
end
! руки прочь, сволочь
if $args[0] = 'boyhome_handsoff':
	act 'Убрать его руку':
		*clr & cla
		minut += 5
		otnBoyFrend[numnpc] -= 10
		dom += 1
		gs 'stat'
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk89')
		gs 'Gnpc2', 'boy_back'
	end
end
! hj/bj
if $args[0] = 'boy_hj':
	act 'Позволить ему':
		*clr & cla
		horny += 10
		minut += 3
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/dk/disco/drinking/0/tits', func('Gnpc2_strings', 'boy_talk46')
		act 'Ласкать его член через штаны':
			*clr & cla
			horny += 5
			minut += 3
			gs 'stat'
			gs 'zz_render', '', 'qwest/alter/Ev/cock.jpg', func('Gnpc2_strings', 'boy_talk47')
			if horny < 80: gs 'Gnpc2', 'boyhome_handsoff'
			act 'Залезть к парню в штаны':
				*clr & cla
				horny += 10
				minut += 3
				gs 'stat'
				gs 'zz_render', '', 'qwest/alter/Ev/cock2.jpg', func('Gnpc2_strings', 'boy_talk49')
				gs 'Gnpc2', 'boy_bj'
			end
		end
		if horny <= 90:
			act 'Сопротивляться':
				*clr & cla
				horny += 10
				minut += 3
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/dk/disco/drinking/0/petting', func('Gnpc2_strings', 'boy_talk70')
				if horny < 70: gs 'Gnpc2', 'boyhome_handsoff'
				act 'Наслаждаться':
					*clr & cla
					minut += 5
					dom -= 1
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/dk/disco/drinking/0/petting', func('Gnpc2_strings', 'boy_talk72')
					gs 'Gnpc2', 'boyhome_vaginal'
					if dom > 0 or anal > 0: gs 'Gnpc2', 'boyhome_anal'
				end
			end
		end
	end
end
if $args[0] = 'boy_bj':
	act 'Подрочить парню':
		*clr & cla
		minut += 5
		if gnpcSex[numnpc] = 0:gnpcSex[numnpc] = 1 & guy += 1
		dick = dickBoyFrend[numnpc]
		hj += 1
		hja += 1
		gs 'stat'
		gs 'zz_render', '', 'qwest/alter/Ev/hj.jpg', func('Gnpc2_strings', 'boy_talk41')
		gs 'Gnpc2', 'boy_back'
	end
	act 'Взять в рот':
		*clr & cla
		minut += 5
		horny += 10
		bj += 1
		bja += 1
		dick = dickBoyFrend[numnpc]
		if gnpcSex[numnpc] = 0:gnpcSex[numnpc] = 1 & guy += 1
		if func('zz_reputation','get') < 2 and RAND(0,100):
			gs 'zz_reputation','set',2
			GboyBalabol[numnpc] = 1
		end
		dom -= 1
		gs 'stat'
		gs 'zz_render', '', 'qwest/alter/Ev/cocksucker.jpg', func('Gnpc2_strings', 'boy_talk42')
		gs 'zz_dynamic_sex', 'bj'
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk43')
		act 'Сосать дальше':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif'
			gs 'zz_dynamic_sex', 'swallow'
			gs 'Gnpc2', 'boy_back'
		end
		act 'Вынуть изо рта':
			*clr & cla
			minut += 5
			horny += 10
			gs 'zz_funcs', 'cum', 'face'
			gs'stat'
			gs 'zz_render', '', 'qwest/alter/Ev/cocksuckerFacial', func('Gnpc2_strings', 'boy_talk44')
			gs 'Gnpc2', 'boy_back'
		end
		! для дома парня ставим варианты секса
		if _boy_back = 1:
			gs 'Gnpc2', 'boyhome_vaginal'
			if dom > 0 or anal > 0: gs 'Gnpc2', 'boyhome_anal'
		end
	end
end
! возврат после hj/bj
if $args[0] = 'boy_back':
	act 'Уйти':
		if _boy_back = 0:
			killvar '_boy_back'
			gs 'Gnpc2', 'disco_end'
		else
			killvar '_boy_back'
			gt 'gorodok'
		end
	end
end
! анал
if $args[0] = 'boyhome_anal':
	act 'Подставить попку':
		*clr & cla
		minut += 10
		gs 'zz_funcs', 'cum', 'anus'
		anala += 1
		$boy = $nameBoyfrend[numnpc]
		dick = dickBoyFrend[numnpc]
		silavag = silavagBoyFrend[numnpc]
		if gnpcSex[numnpc] = 0: gnpcSex[numnpc] = 1 & guy += 1
		if func('zz_reputation','get') = 0 and RAND(0,100) = 100:
			gs 'zz_reputation','set',1
			GboyBalabol[numnpc] = 1
		end
		gs 'stat'
		gs 'zz_render','','common/sex/anal/'+rand(0,4)+'.gif'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk74')
		gs 'Gnpc2', 'boy_back'
	end
end
! вагинал
if $args[0] = 'boyhome_vaginal':
	act 'Отдаться':
		*clr & cla
		minut += 10
		horny += 10
		sexa += 1
		i= rand(0,4)
		pose = iif(i = 1 or i =4,0,1)
		if gnpcSex[numnpc] = 0:gnpcSex[numnpc] = 1 & guy += 1
		$boy = $nameBoyfrend[numnpc]
		dick = dickBoyFrend[numnpc]
		silavag = silavagBoyFrend[numnpc]
		if func('zz_reputation','get') = 0 and RAND(0,100) = 100:
			gs 'zz_reputation','set',1
			GboyBalabol[numnpc] = 1
		end
		gs 'stat'
		gs 'zz_render','','common/sex/sex/<<i>>.gif', func('Gnpc2_strings','boy_talk68')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		gs 'Gnpc2', 'boy_back'
	end
end
! дискотека
! бой, проигрыш
if $args[0] = 'disco_battle_lose':
	gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk22')
	act 'Идти домой': gt 'gorodok'
end
! бой, победа
if $args[0] = 'disco_battle_win':
	act 'Вцепиться одному из гопников в лицо':
		*clr & cla
		GopWin[numnpc] += 1
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk21')
		act 'Идти домой': gt 'gorodok'
	end
end
! отвали, мудила
if $args[0] = 'disco_fuckoff':
	act 'Послать его':
		*clr & cla
		dom += 1
		otnBoyFrend[numnpc] = 0
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk28')
		act 'Отойти': gt 'gdkin'
	end
end
! куда двинем после дискотеки
if $args[0] = 'disco_end':
	*clr & cla
	discofirsttime += 1
	gs 'Gnpc2', iif(gnpcSex[numnpc] > 0 and rand(0,1)=0,'gt_boyhome','gt_home')
end
! дискотека, ивенты
if $args[0] = 'disco_act':
	act 'Идти на дискотеку':
		*clr & cla
		minut += 120
		if dance < 50 and agil >= dance: dance += 1
		manna += 10
		gs 'stat'
		gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk3')
		if discofirsttime = 0 and RAND(0,100):
			if RAND(0,1) = 0:
				gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk4')
				if func('zz_reputation','get') < 3:
					gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk5')
					act 'Вырываться':
						*clr & cla
						dom += 1
						gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk6')
						tiprand = RAND(0,100)
						if tiprand <= 70:
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk7')
							act 'Идти домой': gt 'gorodok'
						elseif tiprand > 70 and tiprand < 90:
							otnBoyFrend[numnpc] -= 20
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk8')
							act 'Идти домой': gt 'gorodok'
						else
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk9')
							act 'Наблюдать за дракой со стороны':
								*clr & cla
								otnBoyFrend[numnpc] -= 20
								gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk10')
								act 'Идти домой': gt 'gorodok'
							end
							act 'Разнимать дерущихся':
								*clr & cla
								if stren < 90:
									gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk11')
									act 'Идти домой': gt 'gorodok'
								else
									gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk12')
									if agil < 90:
										gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk13')
										act 'Идти домой': gt 'gorodok'
									else
										gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk14')
										act 'Ударить гопника кулаком в лицо':
											*clr & cla
											if speed >= 50:
												gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk15')
												act 'Идти домой': gt 'gorodok'
											else
												gs 'Gnpc2', 'disco_battle_lose'
											end
										end
										act 'Пнуть гопнику ногой в голову':
											*clr & cla
											if speed >= 90:
												gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk17')
												gs 'Gnpc2', 'disco_battle_win'
											else
												gs 'Gnpc2', 'disco_battle_lose'
											end
										end
										act 'Пнуть гопнику по яйцам':
											*clr & cla
											if speed >= 70:
												gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk20')
												gs 'Gnpc2', 'disco_battle_win'
											else
												gs 'Gnpc2', 'disco_battle_lose'
											end
										end
									end
								end
							end
						end
					end
					act 'Танцевать':
						*clr & cla
						dom -= 1
						otnBoyFrend[numnpc] = 0
						DPtipe = 2
						gs 'BnameGen'
						gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk23')
						act 'Идти бухать': gt 'EvgopBuh'
					end
				else
					otnBoyFrend[numnpc] = 0
					gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk24')
					act 'Тереть щеку': gt 'gdkin'
				end
			else
				gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk25')
				act 'Отказаться и танцевать одной':
					*clr & cla
					if dance < 50 and agil >= dance:dance += 1
					minut += 3
					gs 'stat'
					gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk26')
					if func('zz_reputation','get') >= 3:
						gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk27')
						gs 'Gnpc2', 'disco_fuckoff'
						act 'Просить его не рассказывать':
							*clr & cla
							dom -= 1
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk29')
							gs 'Gnpc2', 'disco_fuckoff'
							act 'Согласиться':
								*clr & cla
								dom -= 1
								gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk30')
								gs 'Gnpc2', 'disco_fuckoff'
								act 'Отсосать':
									*clr & cla
									dom -= 5
									guy += 1
									bj += 1
									gs 'zz_funcs', 'cum', 'lip'
									swallow += 1
									minut += 3
									gs 'stat'
									gs 'zz_render', '', 'qwest/alter/Ev/public.jpg', func('Gnpc2_strings', 'boy_talk31')
									act 'Выскользнуть из туалета':
										*clr & cla
										gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk32')
										act 'Предложить уйти':
											*clr & cla
											gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk33')
											act 'Уйти': gs 'Gnpc2', 'disco_end'
										end
										act 'Танцевать':
											*clr & cla
											otnBoyFrend[numnpc] = 0
											gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk34')
											act 'Отойти': gt 'gdkin'
										end
									end
								end
							end
						end
					else
						gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk35')
						act 'Танцевать':
							*clr & cla
							otnBoyFrend[numnpc] -= 20
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk36')
							act 'Отойти': gt 'gdkin'
						end
						act 'Отказаться танцевать с незнакомцем':
							*clr & cla
							otnBoyFrend[numnpc] += 5
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk37')
							act 'Уйти': gs 'Gnpc2', 'disco_end'
						end
					end
				end
				act 'Идти с парнем и пить пиво':
					*clr & cla
					gs 'zz_funcs', 'alko', 2
					horny += 5
					minut += 10
					gs 'stat'
					gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk38')
					act 'Уйти': gs 'Gnpc2', 'disco_end'
					act 'Целоваться':
						*clr & cla
						minut += 5
						kissBoyFrend[numnpc] += 1
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'qwest/alter/Ev/kiss.jpg', func('Gnpc2_strings', 'boy_talk39')
						if gnpcSex[numnpc] > 0:
							! секс был, никаких прелюдий
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk40')
							gs 'Gnpc2', 'boy_bj'
						else
							! секса не было, немного нежностей
							gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk59')
							if horny < 90: gs 'Gnpc2', 'boyhome_handsoff'
							gs 'Gnpc2', 'boy_hj'
						end
					end
				end
			end
			exit
		end
		act 'Уйти с дискотеки': gs 'Gnpc2','disco_end'
	end
end