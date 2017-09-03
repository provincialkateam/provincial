if $ARGS[0] = 'start':
	numnpc = 13
	minut += 5
	gs 'stat'
	gs 'npc_editor','get_npc_card',numnpc
	gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str2')
	lariskaQwestDay = daystart + 1
	act 'Пойти за Лариской':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str3')
		act 'Ничего не делать':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_1.jpg', func('LariskaStart_strings', 'local_str4')
			act 'Успокоить':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_3.jpg', func('LariskaStart_strings', 'local_str5')
				lariskaHelp = 1
				if $npc['9,qwKotovLove'] >= 5:
					act 'Позвонить Котову':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str6')
						KotovZverHelp = 1
						act 'Уйти':gt'gdk'
					end
				end
				if $npc['3,qwIvanShower'] >= 10 and $npc['3,relation'] >= 60:
					act 'Позвонить Прохорову':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str7')
						IvanZverHelp = 1
						act 'Уйти':gt'gdk'
					end
				end
				if $npc['23,qwMain'] = 55:
					act 'Позвонить Альбине':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str8')
						AlbZverHelp = 1
						act 'Уйти': gt 'gdk'
					end
				end
				act 'Уйти':gt'gdk'
			end
		end
		if razradKik >= 2 and stren >= 55:
			act 'Атаковать':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_2.jpg', func('LariskaStart_strings', 'local_str9')
				act 'Посмотреть на противника':
					*clr & cla
					minut += 5
					gs 'stat'
					$npc['<<numnpc>>,relation'] = 0
					gs 'npc_editor','get_npc_profile',numnpc
					gs 'zz_render','','',func('LariskaStart_strings', 'local_str11')
					lariskaHelp = -1
					act 'Уйти': gt'gdk'
				end
			end
		end
	end
	act 'Уйти': gt'gdk'
end
if $ARGS[0] = 'end':
	*clr & cla
	minut += 5
	gs 'stat'
	if IvanZverHelp = 1:
		numnpc = 3
		gs 'npc_editor','get_npc_card',numnpc
		horny += 10
		gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str14')
		act 'Идти с Иваном':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/common/npc/19.jpg', func('LariskaStart_strings', 'local_str15')
			act 'Идти домой':
				*clr & cla
				minut += 15
				gs 'stat'
				gs 'npc_editor','get_npc_profile',numnpc
				gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str17')
				$IvanHelp_sex = {
					*clr & cla
					minut += 5
					horny += 5
					gs 'stat'
					$boy = $npc['<<numnpc>>,name']
					dick = $npc['<<numnpc>>,dick']
					silavag = 0
					pose = 1
					if $npc['<<numnpc>>,sex'] = 0: $npc['<<numnpc>>,sex'] = 1 & guy += 1
					gs 'zz_render','','common/sex/public_sex/'+rand(0,2)+'.gif',func('LariskaStart_strings', 'local_str18')
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
					act 'Идти домой':gt'korrPar'
				}
				$IvanHelp_down = {
					act 'Достать его член':
						*clr & cla
						horny += 5
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/Ev/cock3.jpg', func('LariskaStart_strings', 'local_str19')
						act 'Взять в рот':
							*clr & cla
							minut += 5
							horny += 10
							bj += 1
							gs 'stat'
							gs 'zz_render', '', 'common/sex/public_bj_cum/publ_cum.gif', func('LariskaStart_strings', 'local_str20')
							gs 'zz_dynamic_sex', 'swallow'
							act 'Идти домой':gt'korrPar'
						end
						act 'Дать':dynamic $IvanHelp_sex
					end
				}
				act 'Идти домой':gt'korrPar'
				act 'Отблагодарить':
					*clr & cla
					horny += 5
					minut += 5
					gs'stat'
					gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str21')
					dynamic $IvanHelp_down
					act 'Поцеловать':
						*clr & cla
						minut += 5
						dom += 1
						horny += 5
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/Ev/kiss.jpg', func('LariskaStart_strings', 'local_str22')
						act 'Запустить руку в штаны':
							*clr & cla
							horny += 10
							minut += 3
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/Ev/cock2.jpg', func('LariskaStart_strings', 'local_str23')
							act 'Дрочить':
								*clr & cla
								minut += 5
								if $npc['<<numnpc>>,sex'] = 0: $npc['<<numnpc>>,sex'] = 1 & guy += 1
								hj += 1
								gs 'stat'
								gs 'zz_render','','common/sex/hj_cum/'+rand(0,2)+'.gif', func('LariskaStart_strings', 'local_str24')
								act 'Идти домой':gt'korrPar'
							end
							dynamic $IvanHelp_down
						end
						act 'Идти домой':gt'korrPar'
					end
				end
			end
		end
	else
		gs 'zz_render', '', 'images/common/npc/19.jpg', func('LariskaStart_strings', 'local_str25')
		act 'Помочь':
			if KotovZverHelp = 1:
				numnpc = 9
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_4.jpg', func('LariskaStart_strings', 'local_str26')
				act 'Прийти в себя':
					*clr & cla
					minut += 40
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_kotov_end.jpg', func('LariskaStart_strings', 'local_str27')
					act 'Промолчать': LinaSlut = 1 & gt'kotovSex'
					act 'Лина наверняка не сама, её Зверева надоумила, пожалей её!': gt'kotovSex'
				end
			else
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_4.jpg', func('LariskaStart_strings', 'local_str28')
				act 'Прийти в себя':
					*clr & cla
					minut += 15
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_5.jpg', func('LariskaStart_strings', 'local_str29')
					act 'Далее':
						*clr & cla
						horny += 10
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_6.jpg', func('LariskaStart_strings', 'local_str30')
						act 'Далее':
							*clr & cla
							horny += 10
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_7.jpg', func('LariskaStart_strings', 'local_str'+iif(bj >= 100,37,38))
							bj += 1
							sex += 1
							guy += 2
							gang += 1
							vagina += 1
							throat += 1
							gs 'zz_render', '', '', func('LariskaStart_strings', 'local_str31')
							act 'Далее':
								*clr & cla
								horny += 10
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_8.jpg', func('LariskaStart_strings', 'local_str32')
								act 'Смотреть':
									*clr & cla
									horny += 10
									minut += 5
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_funcs', 'cum', 'face'
									gs 'stat'
									gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_9.jpg', func('LariskaStart_strings', 'local_str33')
									act 'Далее':
										*clr & cla
										horny += 10
										minut += 5
										cumface = 0
										gs 'stat'
										gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_10.jpg', func('LariskaStart_strings', 'local_str34')
										act 'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_11.jpg', func('LariskaStart_strings', 'local_str35')
											if func('zz_reputation','get') < 3: gs 'zz_reputation','set',3
											act 'Очнуться':
												*clr & cla
												minut += 5
												$npc['18,qwZverevaSlut'] = 0
												horny = 0
												orgasm += 1
												agape = 2
												vgape = 2
												gs 'stat'
												gs 'zz_render', '', 'images/qwest/alter/Lariska/Start/start_end.jpg', func('LariskaStart_strings', 'local_str36')
												act 'Уйти':gt'gorodok'
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
		act 'Уйти': gt'gorodok'
	end
end