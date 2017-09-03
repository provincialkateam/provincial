if $args[0] = 'sisboyQW_caress':
	*clr & cla
	minut += 5
	horny = 0
	mastr += 1
	orgasm += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_12.jpg', func('sisterQW_strings', 'local_str1')
	act 'Уйти': gt 'korrPar'
end
if $args[0] = 'sisboyQWsee':
	i = rand(0,4)
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_'+(25 + i)+'.jpg', func('sisterQW_strings', 'local_str'+(2+i))
	act 'Ласкать себя': gt 'sisterQW', 'sisboyQW_caress'
	act 'Уйти': gt 'korrPar'
end
if $ARGS[0] = 'sisboyQW_bedroom':
	if $npc['38,qwSisterBoy'] = 3 or $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 7 or $npc['38,qwSisterBoy'] = 9:
		if horny >= 60 and $npc['38,relation'] >= 80 and $npc['38,qwSisterBoy'] = 3:
			*clr & cla
			minut += 5
			horny += 10
			voyeurism +=1
			if $npc['38,qwSisterBoy'] = 3: $npc['38,qwSisterBoy'] = 4
			blockBedrPar = 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_08.jpg', func('sisterQW_strings', 'local_str7')
			act 'Уйти': gt 'korrPar'
		elseif horny >= 60 and $npc['38,relation'] >= 80 and $npc['38,qwSisterBoy'] = 5:
			*clr & cla
			minut += 5
			horny += 10
			voyeurism +=1
			$npc['38,qwSisterBoy'] = 6
			blockBedrPar = 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_10.webm', func('sisterQW_strings', 'local_str8')
			act 'Уйти': gt 'korrPar'
		elseif horny >= 60 and $npc['38,relation'] >= 80 and $npc['38,qwSisterBoy'] = 7:
			*clr & cla
			minut += 5
			if horny < 85: horny = 85
			voyeurism +=1
			blockBedrPar = 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_11.jpg', func('sisterQW_strings', 'local_str9')
			act 'Продолжать наблюдать':
				*clr & cla
				minut += 5
				horny = 90
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_13.jpg', func('sisterQW_strings', 'local_str10')
				act 'Продолжать наблюдать':
					*clr & cla
					minut += 5
					horny = 95
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_14.jpg', func('sisterQW_strings', 'local_str11')
					act 'Продолжать наблюдать':
						*clr & cla
						minut += 5
						horny = 100
						if $npc['38,qwSisterBoy'] = 7:$npc['38,qwSisterBoy'] = 8 & $npc['38,qwSisterLesbi'] = 0
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_15.jpg', func('sisterQW_strings', 'local_str12')
						act 'Ласкать себя': gt 'sisterQW', 'sisboyQW_caress'
					end
					act 'Ласкать себя': gt 'sisterQW', 'sisboyQW_caress'
					act 'Уйти': gt'korrPar'
				end
				act 'Ласкать себя': gt 'sisterQW', 'sisboyQW_caress'
				act 'Уйти': gt'korrPar'
			end
			act 'Ласкать себя': gt 'sisterQW', 'sisboyQW_caress'
			act 'Уйти': gt'korrPar'
		elseif horny >= 60 and $npc['38,relation'] >= 80 and $npc['38,qwSisterBoy'] = 9:
			*clr & cla
			minut += 5
			horny += 10
			blockBedrPar = 1
			gs 'stat'
			gs 'sisterQW', 'sisboyQWsee'
		elseif horny >= 60 and $npc['38,relation'] < 80:
			*clr & cla
			minut += 2
			if horny <= 85: horny += 5
			blockBedrPar = 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_07.jpg', func('sisterQW_strings', 'local_str13')
			act 'Уйти': gt'korrPar'
		else
			*clr & cla
			minut += 1
			blockBedrPar = 1
			if $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 3: $npc['38,qwSisterBoy'] -= 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_06.jpg', func('sisterQW_strings', 'local_str14')
			act 'Уйти': gt'korrPar'
		end
	else
		*clr & cla
		minut += 1
		blockBedrPar = 1
		if $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 3:$npc['38,qwSisterBoy'] -= 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_06.jpg', func('sisterQW_strings', 'local_str14')
		act 'Уйти': gt'korrPar'
	end
end
if $ARGS[0] = 'sisboyQW_expel':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_07.jpg', func('sisterQW_strings', 'local_str'+iif($npc['38,qwSisterTrio'] ! 1,16,17))
	act 'Уйти': gt'korrPar'
end
! --- trio --- !
if $args[0] = 'sisboytrio_prepeare':
	*clr & cla
	if sisboytrio = 1:
		gs 'zz_render', '', 'pavlovo/family/sister/sisboyQW_41.jpg', func('sisterQW_strings', 'local_str20')
	elseif sisboytrio = 2:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_45.jpg', func('sisterQW_strings', 'local_str25')
	elseif sisboytrio = 3:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_49.jpg', func('sisterQW_strings', 'local_str31')
	elseif sisboytrio = 4:
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_53.jpg', func('sisterQW_strings', 'local_str35')
	else
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_57.jpg', func('sisterQW_strings', 'local_str41')
	end
	minut += 5
	horny += 5
	gs 'stat'
	gs 'sisterQW','sisboytrio_suck'
	gs 'sisterQW','sisboytrio_sex'
end
if $args[0] = 'sisboytrio_suck':
	act 'Сосать':
		*clr & cla
		if sisboytrio = 1:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_42.jpg', func('sisterQW_strings', 'local_str23')
		elseif sisboytrio = 2:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_46.jpg', func('sisterQW_strings', 'local_str30')
		elseif sisboytrio = 3:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_50.jpg', func('sisterQW_strings', 'local_str34')
		elseif sisboytrio = 4:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_54.jpg', func('sisterQW_strings', 'local_str40')
		else
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_58.jpg', func('sisterQW_strings', 'local_str44')
		end
		minut += 5
		horny += 5
		bj += 1
		if (sisboytrio = 4 or sisboytrio = 5) and throat < 10: throat += 1
		gs 'zz_funcs', 'cum', 'lip'
		gs 'stat'
		gs 'sisterQW','sisboytrio_sex'
		gs 'sisterQW','sisboytrio_end'
	end
end
if $args[0] = 'sisboytrio_sex':
	act 'Секс':
		*clr & cla
		if sisboytrio = 1:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_43.jpg', func('sisterQW_strings', 'local_str22')
		elseif sisboytrio = 2:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_47.jpg', func('sisterQW_strings', 'local_str27') + func('sisterQW_strings', 'local_str'+iif(vagina = 0,28,29))
		elseif sisboytrio = 3:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_51.jpg', func('sisterQW_strings', 'local_str33')
		elseif sisboytrio = 4:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_55.jpg', func('sisterQW_strings', 'local_str37') + func('sisterQW_strings', 'local_str'+iif(vagina = 0,28,39))
		else
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_59.jpg', func('sisterQW_strings', 'local_str43')
		end
		if sisboytrio = 2 or sisboytrio = 4 or sisboytrio = 5:
			sex += 1
			if vagina = 0: vgape = 3
			if vagina > 0 and vagina <= 5 and vgape < 2: vgape = 2
			if vagina > 5 and vgape < 1: vgape = 1
			vgapetime = totminut + (vgape + 1) * 1440
			if vagina < 10: vagina += 1
		end
		minut += rand(5,15)
		horny += rand(10,20)
		gs 'stat'
		gs 'sisterQW','sisboytrio_end'
	end
end
if $args[0] = 'sisboytrio_end':
	act 'Кончить':
		*clr & cla
		if sisboytrio = 1:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_44.jpg', func('sisterQW_strings', 'local_str21')
			guy += 1
			gs 'zz_funcs', 'cum', 'face'
		elseif sisboytrio = 2:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_48.jpg', func('sisterQW_strings', 'local_str26')
			gs 'zz_funcs', 'cum', 'face'
		elseif sisboytrio = 3:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_52.jpg', func('sisterQW_strings', 'local_str32')
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
		elseif sisboytrio = 4:
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_56.jpg', func('sisterQW_strings', 'local_str36')
			gs 'zz_funcs', 'cum', 'belly'
		else
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_60.jpg', func('sisterQW_strings', 'local_str42')
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
		end
		minut += 5
		horny = 0
		orgasm += 1
		gang += 1
		gs 'stat'
		act 'Уйти': gt 'korrPar'
	end
end
! ---
if $ARGS[0] = 'sisboytrioQW_bedroom':
	blockBedrPar = 1
	if minut > 30:
		*clr & cla
		minut += 1
		gs 'npc_editor','change_rep','-', 38, 10
		$npc['38,qwSisterTrio'] = 0
		sisboyday = 0
		sisThank = 0
		$npc['38,qwSisterBoy'] -= 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_38.jpg', func('sisterQW_strings', 'local_str18')
		act 'Уйти': gt 'korrPar'
		exit
	end
	sisboytrio += 1
	if sisboytrio = 1:
		*clr & cla
		minut += 5
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_39.jpg', func('sisterQW_strings', 'local_str19')
		act 'Целоваться': gt 'sisterQW','sisboytrio_prepeare'
		act 'Убежать':
			*clr & cla
			$npc['38,qwSisterTrio'] = -1
			sisboytrioDayOtkaz = daystart + 3
			minut += 5
			gs 'npc_editor','change_rep','-', 38, 20
			$npc['38,qwSisterBoy'] = 2
			sisThank = 0
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_40.jpg', func('sisterQW_strings', 'local_str24')
			act 'Убежать': gt 'korrPar'
		end
	else
		gt 'sisterQW','sisboytrio_prepeare'
	end
end
! --- end trio --- !
if $ARGS[0] = 'sisboyQW_party':
	if sisboypartyQW = 1:
		sisboyparty = 1
		sisboypartyQW = 2
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_8.jpg', func('sisterQW_strings', 'local_str45')
		$sisboy_dance = {
			act 'Идти танцевать':
				*clr & cla
				minut += 15
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_10.jpg', func('sisterQW_strings', 'local_str46')
				$sisboy_annaFind = {
					act 'Искать Аню':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', '', func('sisterQW_strings', 'local_str47')
						$sisboy_Annakuch = {
							act 'В кухне':
								*clr & cla
								minut += 5
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_24.jpg', func('sisterQW_strings', 'local_str48')
								act 'Повернуться':
									*clr & cla
									minut += 5
									horny += 5
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_25.jpg', func('sisterQW_strings', 'local_str49')
									act 'За Аней':
										*clr & cla
										minut += 5
										horny += 5
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_26.jpg', func('sisterQW_strings', 'local_str50')
										act 'Ждать':
											*clr & cla
											minut += 10
											horny += 10
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_27.jpg', func('sisterQW_strings', 'local_str51')
											if hour < 22:
												hour = 22
												minut = 0
												act 'Уйти':gt'bedrPar'
											else
												act 'Уйти':minut += 15 & gt'bedrPar'
											end
										end
										act 'Присоединиться':
											*clr & cla
											sisterknowslut = 2
											minut += 10
											horny += 10
											gang += 1
											sex += 1
											guy += 1
											gs 'zz_funcs', 'cum', 'lip'
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_28.jpg', func('sisterQW_strings', 'local_str52')
											if hour < 22:
												hour = 22
												minut = 0
												act 'Уйти': gt'bedrPar'
											else
												act 'Уйти': minut += 15 & gt'bedrPar'
											end
										end
									end
								end
							end
						}
						$sisboy_Annatoilet = {
							act 'В туалете':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_22.jpg', func('sisterQW_strings', 'local_str53')
								dynamic $sisboy_Annakuch
								dynamic $sisboy_Annakom
							end
						}
						$sisboy_Annakom = {
							act 'В комнате':
								*clr & cla
								minut += 5
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_23.jpg', func('sisterQW_strings', 'local_str54')
								dynamic $sisboy_Annakuch
								dynamic $sisboy_Annatoilet
							end
						}
						dynamic $sisboy_Annatoilet
						dynamic $sisboy_Annakuch
						dynamic $sisboy_Annakom
					end
				}
				$sisboy_reks = {
					act 'Поздравить Рекса лично':
						*clr & cla
						gs 'zz_funcs', 'alko'
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_19.jpg', func('sisterQW_strings', 'local_str55')
						dynamic $sisboy_annaFind
						act 'В туалет':
							*clr & cla
							minut += 5
							horny += 10
							toiletRexSex = 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_20.jpg', func('sisterQW_strings', 'local_str56')
							act 'Стать раком':
								*clr & cla
								minut += 5
								horny += 10
								sex += 1
								guy += 1
								reksSex = 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_21.gif', func('sisterQW_strings', 'local_str57')
								gs 'zz_funcs', 'cum', 'pussy'
								dynamic $sisboy_annaFind
							end
						end
					end
				}
				$sisboy_twoboy = {
					act 'Танцевать с ними':
						*clr & cla
						minut += 10
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_14.gif', func('sisterQW_strings', 'local_str58')
						act 'Идти':
							*clr & cla
							minut += 5
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_15.jpg', func('sisterQW_strings', 'local_str59')
							act 'Встать раком':
								*clr & cla
								minut += 5
								horny += 5
								gang += 1
								guy += 2
								bj += 1
								sex += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_16.jpg', func('sisterQW_strings', 'local_str60')
								act 'Поменяться':
									*clr & cla
									minut += 5
									horny += 5
									bj += 1
									sex += 1
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_funcs', 'cum', 'face'
									swallow += 1
									gs 'zz_funcs', 'cum', 'ass'
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_17.jpg', func('sisterQW_strings', 'local_str61')
									dynamic $sisboy_annaFind
								end
							end
						end
					end
				}
				act 'Бухать':
					*clr & cla
					gs 'zz_funcs', 'alko', 3
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_13.jpg', func('sisterQW_strings', 'local_str62')
					dynamic $sisboy_twoboy
				end
				act 'Продолжить танцевать':
					*clr & cla
					minut += 10
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_18.gif', func('sisterQW_strings', 'local_str63')
					dynamic $sisboy_twoboy
					dynamic $sisboy_annaFind
					dynamic $sisboy_reks
				end
				dynamic $sisboy_reks
			end
		}
		$sisboy_drink = {
			act 'Пить':
				*clr & cla
				gs 'zz_funcs', 'alko', 2
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_11.jpg', func('sisterQW_strings', 'local_str64')
				dynamic $sisboy_dance
			end
		}
		$sisboy_sit = {
			act 'Сидеть':
				*clr & cla
				minut += 10
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_12.jpg', func('sisterQW_strings', 'local_str65')
				dynamic $sisboy_dance
			end
		}
		act 'Выпить':
			*clr & cla
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_9.jpg', func('sisterQW_strings', 'local_str66')
			dynamic $sisboy_dance
			dynamic $sisboy_drink
			dynamic $sisboy_sit
		end
		act 'Попытаться отказаться':
			*clr & cla
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_9.jpg', func('sisterQW_strings', 'local_str67')
			dynamic $sisboy_dance
			dynamic $sisboy_drink
			dynamic $sisboy_sit
		end
		act 'Встать танцевать':
			*clr & cla
			gs 'zz_funcs', 'alko', 3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/Party/sisboyQWParty_9.jpg', func('sisterQW_strings', 'local_str68')
			dynamic $sisboy_dance
			dynamic $sisboy_drink
			dynamic $sisboy_sit
		end
	end
end
if $args[0] = 'party_pre_conditions':
	*clr & cla
	minut += 5
	gs 'stat'
	if $npc['27,relation'] <= 80:
		gs 'zz_render','','pavlovo/family/sister/sisterQW/ReksHome/Party_sister_1.jpg'
		if func('zz_reputation','get') < 2 and mesec <= 0 and manna >= 60 and alko < 3 and (cumfrot + cumlip + cumface) = 0:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str69')
			act 'Идти': gt 'sbReksHome','party'
			act 'Я передумала':
				*clr & cla
				minut += 5
				sisboyparty = -1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_sister_1.jpg', func('sisterQW_strings', 'local_str70')
				act 'Отойти': gt $loc, $metka
			end
		elseif func('zz_reputation','get') >= 2:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str71')
			act 'Отойти': gt $loc, $metka
		elseif mesec > 0 or manna < 60:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str72')
			act 'Отойти': gt $loc, $metka
		elseif alko >= 3:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str73')
			act 'Отойти': gt $loc, $metka
		elseif (cumfrot + cumlip + cumface) > 0:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str74')
			act 'Отойти': gt $loc, $metka
		end
	else
		gs 'zz_render','','pavlovo/family/sister/sisterQW/ReksHome/Reks.jpg'
		if func('zz_reputation','get') < 2 and mesec <= 0 and manna >= 60 and alko < 3 and (cumfrot + cumlip + cumface) = 0:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str75')
			act 'Идти':gt 'sbReksHome','party'
			act 'Я передумала':
				*clr & cla
				minut += 5
				sisboyparty = -1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Reks.jpg', func('sisterQW_strings', 'local_str76')
				act 'Отойти':gt $loc, $metka
			end
		elseif func('zz_reputation','get') >= 2:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str77')
			act 'Отойти': gt $loc, $metka
		elseif mesec > 0 or manna < 60:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str78')
			act 'Отойти': gt $loc, $metka
		elseif alko >= 3:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str79')
			act 'Отойти': gt $loc, $metka
		elseif (cumfrot + cumlip + cumface) > 0:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str80')
			act 'Отойти': gt $loc, $metka
		end
	end
end
if $args[0] = 'meet_sister':
	if week = 5 and hour = 16 and sisboyparty = 2:
		if sisboypartyQW < 2:
			act 'Идти на вечеринку': gt 'sisterQW', 'sisboyQW_party'
			exit
		else
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str81')
			act 'Идти на вечеринку': gt 'sisterQW','party_pre_conditions'
			exit
		end
	end
	if $sister['location'] = 'gdk' or $sister['location'] = 'glake' or $sister['location'] = 'cafe_parco':
		if $npc['38,relation'] < 40:
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str82')
		else
			cla
			gs 'zz_render', '', '', func('sisterQW_strings', 'local_str83')
			act 'Пить пиво':
				cla & *clr
				if AniaFrends = 1:
					gt 'annafrends'
				else
					AniaFrends = 1
					$npc['38,qwSisterBoy'] = 2
					minut += 40
					gs 'npc_editor','change_rep','+', 38
					gs 'zz_funcs', 'alko', 3
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/friends/'+$sister['location']+'_4.jpg', func('sisterQW_strings', 'local_str84')
				end
				act 'Отойти': gt $loc, $metka
			end
		end
		act '<B>Отойти</B>': gt $loc, $metka
		exit
	end
end
if $args[0] = 'incest_event1':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event1/01.jpg','Вы лежите на кровати и читаете Анькин женский журнал, сама она после вечеринки как обычно завалилась спать пораньше, в стельку бухая. Читая журнал, вы натыкаетесь на эротические рассказы. Они вас немного возбуждают, а ваша рука сама тянется к груди. '
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event1/02.jpg','Решив, что Аня спит крепко, вы обнажили грудь, руку запустили в трусики и начали поглаживать лобок, при этом продолжая читать журнал.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event1/03.jpg','Затем быстро избавились от трусиков и начали играться со своими дырочками, время от времени бросая взгляд на картинку в журнале.'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event1/04.jpg','Почувствовав, что пальцев вам будет недостаточно, вы вытащили из-под кровати дилдо и легли поудобнее.'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event1/05.jpg','Вставив фаллоимитатор в свою киску, вы закрыли глаза и начали медленно двигать его внутри, погружаясь в свои фантазии. Вам неистово захотелось, чтобы на его месте оказался настоящий мужской член.**\\- Ох да, еще, еще... трахай мою мокрую пизденку, братец!// - стали тихо шептать вы, возбуждаясь еще сильнее.'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event1/06.jpg','Внезапно ощутив на себе посторонний взгляд, вы открыли глаза. К вашему удивлению, там стоял Николай, который, вероятно, уже какое то время наблюдал за вами и все слышал.**\\- Коля, какого ху… ты тут делаешь?//**\\\- Да вот, решил пока все спят с любимой сестренкой покувыркатся.'
						act'Проваливай':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event1/06.jpg','\\- Ты что головой стукнулся, вали к себе немедленно, не то останешься без сладкого на пару месяцев!//**\\\- Ладно, ладно уже ухожу только не злись.'
							act 'Лечь спать.': gt 'bed', 'sleep'
						end
						act'Ну так и быть, только веди себя как можно тише.':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event1/07.jpg','Вы находились в позе, открывавшей Кольке великолепный вид на все ваши прелести:**\\- Коля, иди сюда твоя сестренка уже разогрелась, дальше твоя очередь.//**\\\- Ого, какой у тебя членозаменитель, даже не встречал подобного. Можно я им с тобой поиграю для начала?///**\\- Держи, только осторожнее,//- предупредили вы, вручая дилдо брату.'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event1/08.jpg','Колька взял дилдо и начал медленно и аккуратно вводить его вам в зад, постоянно спрашивая все ли у вас нормально.'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event1/09.jpg','Слегка приноровившись, брат стал более уверенно двигать игрушку, вы блаженно заулыбались:**\\- Да-да, вот так очень хорошо. А теперь поработай над главной гордостью девушки.//'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event1/10.jpg','Коля медленно вынул дилдо из вашей попки и также медленно и аккуратно вошел им в вашу киску. Затем начал двигать, наращивая темп. Вы застонали.**\\- Оооо, здорово, то, что и было надо! Теперь дай я попробую на вкус свои соки,// - как можно распутнее прошептали вы.'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event1/11.jpg','Коля поднес влажный фаллоимитатор к вашему рту, вы высунули язычек и начали облизывать его:**\\- А я весьма приятная на вкус, ты так не считаешь?//**\\\- Ага, может, уже пора тебе попробовать мой сегодняшний вкус?///'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event1/12.jpg','Вы улыбнулись, стянули с Кольки джинсы и начали обрабатывать его инструмент.'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event1/13.jpg','Посчитав, что он уже готов, вы стащили юбочку и запрыгнули сверху на член брата.**\\- И все же никакое дилдо не заменит настоящий член,// - простонали вы, играя руками с напряженными сисечками.'
													act'Далее':
														*clr & cla
														minut += 1
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event1/14.jpg','Колька прижал вас к себе и стал наращивать темп:**\\\- Света, ты так намекаешь, что нам почаще надо этим заниматься?///**Вас охватил легкий стыд, вы смущенно подумали: “А не прекратить ли?”. Но остановиться было просто невозможно.'
														act'Далее':
															*clr & cla
															minut += 1
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event1/15.jpg','А Колька тем временем не унимался он повернул вас на бок и стал двигаться еще активнее.**\\\- Света, я не слышу твоего ответа? С тобой все в порядке?///**\\- Ахх… боже … я не знаю..//- от наслаждения ваша руку сама потянулась к клитору и начала его теребить, вдруг до вас дошло что это и был ответ вашего тела на вопрос который так вас смутил.'
															act'Далее':
																*clr & cla
																minut += 1
																horny += 20
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event1/16.jpg','Вы больше не колебались, взяв инициативу в свои руки: встали на колени и подставили Кольке ваш зад, он вошел в вас неуверенно.**\\- Коля прости. Я… Я… дура… Пожалуйста, трахай свою глупую сестренку при первом удобном случае.//**\\\- Светуль, ты чего? Я все понимаю, я тоже много думал об этом…///**\\- Коля замолчи! Мы больше никогда не будем говорить на эту! Ты меня понял? А сейчас я хочу чтобы ты уделил внимание моей попке, она очень этого хочет.//'
																act'Далее':
																	*clr & cla
																	minut += 1
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event1/17.jpg','Колька ничего не стал отвечать, а решил дать ответ своими действиями, и сменил свое место дислокации. Ощутив как Колька входит в ваш зад, вы вдруг почувствовали надвигающуюся на вас очередную волну возбуждения улыбка появилась на вашем лице и похоть затмила все остальные ваши чувства:**\\- Ох да, как же хорошо разве можно от такого отказываться,// - в полный голос произнесли вы, не заботясь о том что вас могут услышать.**\\\- Тише, тише…//- прошептал Колька и видя, что вы на это не реагируете, сменил позу, дабы дать вам перевести дух.'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		horny += 25
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event1/18.jpg','Но вы уже завелись и через минуту вопили еще громче.**\\\- Света тише ты же Аньку разбудишь!///**\\- Нет, все нормально, трахай меня посильнее!//**\\\- Одумайся, ты хочешь чтобы нас застукали?///**\\- Не хочешь меня трахать? Тогда я сама тебя трахну!//'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event1/19.jpg','Оседлав Кольку, вы начали прыгать на нем, вопя все громче и громче.'
																			if horny >= 90 and $npc['38,Kolkawin'] = 1 :
																				act'Кончить':
																					*clr & cla
																					$npc['38,qwKolka'] = 1
																					minut += 1
																					orgasm += 1
																					analorgasm += 1
																					horny = 0
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event1/25.jpg','Бурно кончая вы завизжали так, что вас, наверно, услышали ближайшие несколько этажей, от такого ору Аня проснулась, с просони не совсем понимая, что случилось.**\\\- Что тут происходит, что за крики?/// - Аня, протирая глаза, уставилась на соседнюю кровать.**\\\- Светка, нахера ты ебаря к нам в комнату притащила родители узнают даже не знаю, что с тобой сделают!/// - сказала Аня и начала подниматься с кровати, чтобы разобраться с вашим блядством.'
																					act'Далее':
																						*clr & cla
																						minut += 1
																						gs 'stat'
																						gs 'zz_render', '', 'pavlovo/family/incest/event1/26.jpg','\\\- Колька, паразит, ты что ли?!///- с изумлением воскликнула Аня, подходя поближе.**\\- Аня, успокойся, мы тебе все объясним,// - неуверенно пролепетали вы.**\\\- Успокоится?! Вы что, в конец ебанулись?! Если родители слышали твой вопль - они же тебя из дома выкинут.///**\\- Если бы слышали - уже были тут. Колька, вали к себе, я тут сама все улажу.//**Колька быстро натянул штаны и выбежал из комнаты'
																						act'Далее':
																							*clr & cla
																							minut += 1
																							gs 'stat'
																							gs 'zz_render', '', 'pavlovo/family/incest/event1/27.jpg','Аня, кипя от злости, проводила Кольку взглядом и села рядом с вами.**\\\- Света, он же наш брат, как ты вообще до такого додумалась?/// - с гневом произнесла Аня.**\\- Ну отцы-то у нас разные… Все само как-то получилось… Да и в кровати он весьма хорош, попробовав однажды удержаться очень трудно… Я прошу только родителям не рассказывай!!!//**\\\- Я что, дура что ли, мне за такое наверняка тоже достанется! Но я все равно не понимаю тебя, что школьных парней мало, зачем ты с братом спать начала?///**\\- Ну ты же понимаешь, что я не могу привести парня домой: родители увидят - убьют, а Колька он всегда тут: трахнул по-быстренькому и никто ничего не заметит. К тому же ты не шибко возражала когда мы с тобой развлекались!//**\\\- Света, там совсем другое!!///**\\- Значит, по-твоему с родной сестрой трахатся нормально, а со сводным братом нет?// - возмущаясь спросили вы.**\\\- Ну… ладно… но все равно оно как то неправильно, да и подумай что будет если родители узнают…///**\\- Анька, поверь награда оправдывает любой риск!!!//**Аня покраснела, видимо, представляя себя на вашем месте.**\\\- Света, будь осторожнее родители узнаю мне тоже достанется, а теперь пора спать. Надеюсь, нам больше не придется такое обсуждать… Блин, из-за вас придурков только возбудилась!///**\\- Ооо, вот это правильно,// - рассмеялись вы, полностью отойдя от испуга.**<b>Надо бы утром пока родители спят с Колей переговорить</b>- подумали вы и легли спать'
																							act'Лечь спать.': gt 'bed', 'sleep'
																						end
																					end
																				end
																			else
																				act'Опомниться и снизить темп':
																					*clr & cla
																					minut += 1
																					horny = 75
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event1/20.jpg','Взяв себя в руки, вы слегка притормозили и сменили позу, давая отдохнуть своей заднице.**\\- Ух, пронесло…// - прошептали вы.**\\\- Света, ты чуть нас не спалила!///**\\- Прости, Коль, потеряла над собой контроль.//'
																					act'Далее':
																						*clr & cla
																						minut += 1
																						gs 'stat'
																						gs 'zz_render', '', 'pavlovo/family/incest/event1/21.jpg','Переведя дух, вы решили продолжить, и вставили колькин член обратно в попку.**\\- Коля, если меня снова понесет останови меня, а то Анька проснется,// - нежно прошептали вы ему на ушко и начали ерзать на его члене.'
																						act'Далее':
																							*clr & cla
																							minut += 1
																							gs 'stat'
																							gs 'zz_render', '', 'pavlovo/family/incest/event1/22.jpg','На этот раз Колька был уже намного осторожнее и при первых же признаках того, что вы заводитесь сразу сменил позу:**\\\- Света ты как готова к финальному броску? Я уже вот-вот кончу!///**\\- Хорошо, можешь кончить куда захочешь только смотри чтобы я не залетела,// - улыбаясь, сказали вы'
																							act'Далее':
																								*clr & cla
																								minut += 1
																								gs 'stat'
																								gs 'zz_render', '', 'pavlovo/family/incest/event1/23.jpg','Колька спустил вам прямо в попку, почувствовав горящее семя у себя в заднице вы жалели только об одном: вам сегодня так и не удалось самой кончить, но, понимая что это могло опасно закончится, вы смирись.'
																								act'Далее':
																									*clr & cla
																									minut += 1
																									$npc['38,Kolkawin'] = 1
																									gs 'stat'
																									gs 'zz_render', '', 'pavlovo/family/incest/event1/24.jpg','Вы слегка приподняли рукой попку, чтобы Колька видел вытекающую сперму и пробормотали:**\\- Надо завязывать с такими встречами, а то они могут плохо за кончится…//**\\\- Как устоять, когда видишь сестренку с торчащим из киски дилдо?/// - хмыкнул Колька,\\\- Ну ладно я пошел да и тебе пора спать.///**\\- Сладких снов,// - с этими словами вы нежно поцеловали Кольку и улеглись спать.'
																									act'Лечь спать.': gt 'bed', 'sleep'
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
if $args[0] = 'incest_event2':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event2/01.jpg','\\- Коля, а кому это ты с утра смс-ки строчишь? Дай-ка я посмотрю!// - вы выхватываете телефон у замешкавшегося брата.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event2/02.jpg','Вы взяли мобильник и начали читать вслух:**“Мишаня, спорим я уговорю Светку, чтобы она тебе тоже дала?” - прочитав это, вы повернулись.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event2/03.jpg','\\\- Свет, верни мобилу! Я все объясню!**\\- Я, значит, пришла сказать ему, что уладила всё с Анькой, - а он тут собрался меня под другого парня подложить?! Ты не охамел ли, а?//'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event2/04.jpg','\\\- Светик, Светик, прости, ты не так всё поняла… Мишка сказал, что ты ни за что с ним трахаться не будешь, а я решил с ним на деньги поспорить, потом уговорить тебя, а на выйгрошь купить Ане подарок, чтобы ее задобрить…///**\\- И на сколько поспорил?// - все еще злясь спросили вы**\\\-На 10000 рублей...///'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event2/05.jpg','Неожиданно для себя вы его крепко поцеловали, затем откинули одеяло и начали лизать его член. Коля был в полном недоумении.'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event2/06.jpg','Облизывая член вы спросили:**\\- Если не хочешь остаться должен своему дружку денег то тебе придется хорошенько постараться//**\\\- Так ты не злишься?/// - с удивлением спросил Колька**\\- Я тут кое что придумала ночью и не знала как тебя об этом попросить, а ты мне без вопросов поможешь сам, ну а пока трахни меня меня как следует а то прошлый раз я даже не кончила...//'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event2/07.jpg','Колька послушно стянул с вас трусики и начал вылизывать вашу задницу язычком.'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event2/08.jpg','Затем вы перевернулись на спину, расставили ноги и раздвинули пальчиками киску.**\\- Поторопись уже, ты сегодня какой то нерешительный!//'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event2/09.jpg','Колька быстро загнал член в вашу киску и начал усердно работать.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event2/10.jpg','Через пару минут Колько вновь почувствовал себя увереннее и взял инициативу в свои руки, перевернул вас на бок и начал двигаться наращивая темп при этом поигрывая пальчиком с вашим клитором.**\\- Хорошо, а теперь поработай над второй дырочкой.// - хихикая сказали вы . Затем встали на колени и подставили задницу.'
										act'Далее':
											*clr & cla
											minut += 1
											horny += 20
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event2/11.jpg','Колька не долго думая загнал в нее свой член и начал неистово долбить.**\\- Коля помедленнее порвешь же.// - тут же завопили вы.'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event2/12.jpg','Решив что в этой позе ему неудобно, он посадил вас сверху и начал рукой играть с вашей киской.**\\- Ахх.. дда… Ну вот можешь же когда захочешь!//'
												act'Далее':
													*clr & cla
													minut += 1
													horny += 10
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event2/13.jpg','Вы снова начали вопить как в прошлый раз, Колька не долго думая перевернул вас на бок.**\\\- Света прикуси одеяло не то родителей разбудишь своими визгами!///**\\- Ахх… хорошо.. тока еби меня, неостонавливайся!// - и прикусили одеяло.'
													act'Далее':
														*clr & cla
														minut += 1
														horny = 95
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event2/14.jpg','Вы и извивались как змея, если бы не одеяло родителеи бы точно услышали вас. Наконец вы кончили. Заметив это Колька вытащил член и поднес к ее лицу.**\\\- Светик открой ротик!///**\\- Не сегодня кончай на лицо я все равно щас в душ.// - но при этом все равно немного приоткрыли ротик и высунули язычек.'
														act'Далее':
															*clr & cla
															minut += 1
															orgasm += 1
															analorgas += 1
															horny = 0
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event2/15.jpg','Колька смачно обкончал ваше личико при этом попав и в слегка приоткрытый ротик. Вы явно были довольны таким началом дня.'
															act'Далее':
																*clr & cla
																minut += 1
																$npc['38,qwKolka'] = 2
																gs 'zz_funcs', 'cum', 'face'
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event2/16.jpg','Затем облизав сперму около рта вы уселись поэротичнее и начала рассказывать, что вы хочете от Кольки:**\\- Слушай я тут подумала ночью наверно нам стоит убедить Аню присоединится к нашим забавам.//**\\\-Света ты что хочешь что бы я Аньку трахнул?///**\\- А что девка она симпатичная небойсь сам не раз об этом мечтал!//**\\\- Ну …/// - Колька слегка опешил.**\\- Да не ломайся, я ее подготовлю.//**\\\- Ладно, но сначало тебе надо решить проблему с Мишкой он долго ждать не будет.///**\\- Я сама к нему не пойду! Пусть к нам приходит когда родителей дома не будет.//**\\\- Блин Света и что мне ему сказать”Приходи к нам Света тебя хочет трахнуть?”///**\\- Ты главное его к нам приведи под любым предлогом, а дальше я сама разберусь.//**\\\- Ладно я его в Хbox поиграть позову.///**\\- Ну вот и молодец!// - с этими словами вы встали подняли трусики затем выглянули за дверь и огляделись думая при этом, что надо будет <b>заглянуть в зал часа в 4 может колька приведет друга..</b>'
																act'Идти в ванную.': gt 'zz_bathroom','start'
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
if $args[0] = 'incest_event3':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event3/01.jpg','Вы заходите в зал и видите, что Колька и Миша сидят и в режутся в какую-то игру.**\\\- А, Света! Заходи! Помнишь Мишу - мы с ним в кафе познакомились, когда победу в городском турнире по футболу отмечали?///**\\- Разве такое забудешь? Привет, Миш,// - улыбнулись вы.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event3/02.jpg','Вы уселись на диван, а парни продолжили играть, не обращая на вас особого внимания.**\\- Во что играете?//**\\\- В гонки/// - пробурчал Коля, словно уже забыл - зачем на самом деле приглашал Мишу.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event3/03.jpg','Недолго думая, вы положили свою руку Мише на пах:**\\- Мишань, а может поиграем во что-нибудь более взрослое?//**\\\- Что?/// - с замешательством в голосе покосился Миша.'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event3/04.jpg','Решив не объяснять - что вы от него хотите, вы молча извлекли его член из штанов и наклонившись, лизнули.**\\\- Мы же не одни, Светик!///**\\- Не переживай, щас мы его спровадим.//'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event3/05.jpg','Вы оглянулись на Кольку: тот уже, забыв про игрушку, глядя во все глаза на вас, вовсю наяривает член.**\\- Коля! Может свалишь отсюда ненадолго?//**\\\- Ммм… а может… это... Может, мы вдвоём тебя… того?**- Колян! Она ж твоя сестра, ты чё!///'
					act'Оставить отношения с Колей в секрете и уйти':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event3/05.jpg','\\- Коль! Ты с ума сошел - такое предлагать? Вообще что-ли мозгов нет?!// - сделав гневное лицо, вы вышли в коридор, надеясь что Мишаня ничего не заподозрит.'
						act 'Далее': gt 'korrPar'
					end
					act'Вы уже сильно завелись и не против тройничка':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event3/06.jpg','Присев на столик посреди комнаты, вы, задрав маечку, берёте собственные грудки так, чтобы Мишаня отлично их рассмотрел.**\\- Мишань, да я и не против! У нас с ним это не впервой. Но не вздумайте проболтаться кому! Пусть это останется между нами, хорошо?// - пацаны яростно кивают в ответ.**\\\- Светк, я думал - ты вся такая недотрога, а ты оказывается очень даже современная девушка! Я таких очень люблю!/// - осклабился Мишаня.'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event3/07.jpg','Парни подошли поближе: вы по-хозяйски взяли их за торчащие “орудия”. Первым вы решили уделить внимание уже знакомому на вкус члену брата. Затем пришло время открывать новые для себя вкусы и вы переключаетесь на Михаила.**\\\- Колян, это ты её научил так сосать? Она не хуже моей бывшей, которая в порно снималась, на флейте играет!**- Это уж сам у неё спроси,/// - Кольке явно сейчас не до ответов на вопросы\\\- где и с кем она так насобачилась! Я свечку не держал!///'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event3/08.jpg','Миша, обойдя вас, отодвинул трусики и вы почувствовали его пальцы у себя в киске. От сладкого ощущения вы чуть рефлекторно не прикусили Колькин агрегат.**\\\- Светик, да ты уже мокрая как лужа!///'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event3/09.jpg','\\\- А это что у нас тут?/// - ваши трусики съезжают вниз и вы чувствуете вдруг Мишанин язык, вылизывающий колечко ануса. Он ясно даёт вам понять - чего ему хочется.**\\\- С такой попки грех не начать!///**\\- Обычно я люблю чтобы меня спереди разогрели, но раз уж ты мне задницу смазал - то ладно. Только не спеши!// - на секунду выпускаете вы изо рта Колькин член.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event3/10.jpg','Миша осторожно входит в вашу задницу и начинает медленно двигаться.**\\\- Попка что надо! Не узкая и не раздолбаная, а прям в самый раз!///**\\\- Думаю это ненадолго/// - усмехнулся Колька.'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event3/11.jpg','Через пару минут уже Колян буравил вашу задницу при этом присосавшись к груди, что еще больше вас возбуждало.**\\\- Светик, как насчёт двойного удовольствия?/// - поинтересовался Мишка, явно намекая, что тоже хочет присоединиться к Коляну.'
											act'Далее':
												*clr & cla
												minut += 1
												horny += 20
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event3/12.jpg','Вы, почти уже теряя сознание от наслаждения, только кивнули. Коля переместился в вашу “главную дырочку”, а Мишаня пристроился сверху к попе.'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event3/13.jpg','Ребята начали осторожно двигаться постепенно наращивая темп. К вашему удивлению вам это ужасно понравилось.**\\- Охх… дааа! Давайте, мальчики! Оххх… Как в раю!// - ощущение асинхронно двигающихся в вас поршней, почти соприкасающихся промеж собой через тоненькую перегородочку, доставляет чумовые ощущения и заводит до искр в глазах.**\\\- И там тебя трахнула толпа ангелов!/// - съязвил Колька.'
													act'Далее':
														*clr & cla
														minut += 1
														horny = 98
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event3/14.jpg','Чутка притеревшись, парни вас перевернули теперь уже Колька буравил ваш зад, а Миша наконец добрался до вашей щёлки.**\\- Ваши члены как будто специально подгоняли под меня…// - пыхтите вы,\\- я раньше никогда так быстро не кончала!//'
														act'Далее':
															*clr & cla
															minut += 1
															orgasm += 1
															DPorgasm += 1
															horny = 70
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event3/15.jpg','С этими словами вас застрясло. Заметив это Колька остановился, но Миша лишь схватил вас за грудь и начал наращивать темп.**\\- Миша-а-аа, остановии-и-иись, хвааатит!// - извиваясь и пытаясь соскочить с членов парней завопили вы, задыхаясь от волн оргазмов, накатывающих один за другим.**\\\- Расслабься, Светуля, я знаю, что делаю.///'
															act'Далее':
																*clr & cla
																minut += 1
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event3/16.jpg','Секунд через десять Миша остановился и дал вам слезть. Вы кое-как отдышались и неожиданно ощутили что возбуждение после оргазма никуда не пропало.**\\\- Ну как Светик хочется добавки не так ли?/// - широко улыбаясь сказал Мишка.**\\- Ещё сильнее чем прежде! Что ты со мной сделал, негодник?// - изумились вы. Улегшись на стол, вы ухватили Колькин член, а Миша в этот раз решил начать второй подход к вашей норке.'
																act'Далее':
																	*clr & cla
																	minut += 1
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event3/17.jpg','\\\- Этому меня научила бывшая подружка из порнобизнеса.///**\\- Колька! Учись, оболтус, как надо - потом мы с тобой попрактикуемся// - взмыленно выдыхаете вы.**А Миша тем временем снова принялся за ваш зад.'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event3/18.jpg','Спустя минуту вы уже не хотели выпускать Мишку из себя, хоть и пришла очередь брата.**\\\- Света, вставай: моя очередь!/// - Колька как-то даже обиженно засопел.**\\- Колюшка, солнышко, я всегда твоя! Но сегодня у Миши приоритетный вход// - вы повыше приподняли попку. Мишка засмеялся и вогнал член в вашу киску.'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			horny += 20
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event3/19.jpg','Наигравшись с вашей киской, Миша снова пристроился к попе, а Колька всё бурчал недовольно, что ему тоже хочется.**\\\- Мишань, ну ты давай там кончай уже! Я тоже присунуть ей хочу!**- Светик, куда тебе спустить? В задницу? В ротик? А может ты на таблетках я и в пизденьку тогда могу?///**\\- Я предпочитаю в ротик!//'
																			act'Далее':
																				*clr & cla
																				minut += 1
																				horny = 95
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event3/20.jpg','Колька наконец то добрался до вожделенной дырочки и начал неистово вас долбить, словно навёрстывая упущенное и вас тут же накрыл очередной оргазм, а Мишка засунул член вам в рот.**\\\- Свет, я уже почти готов!..///'
																				act'Далее':
																					*clr & cla
																					minut += 1
																					orgasm += 1
																					vaginalorgasm += 1
																					horny = 0
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event3/21.jpg','Через несколько секунд вы почувствовали горячую спермы у себя во рту.**\\\- Ай да Светик! Хороша почти как моя бывшая!///**\\- Ну не наглец ли?// - возмутились вы полушутя:\\- Нет бы сказал: “Лучше моей бывшей!”//**\\\- Светуль, до моей бывшей тебе ещё попрактиковаться надо малость. Хочешь - могу дать пару уроков?/// - ухмыльнулся Миша.'
																					act'Далее':
																						*clr & cla
																						minut += 1
																						gs 'zz_funcs', 'cum', 'face'
																						gs 'stat'
																						gs 'zz_render', '', 'pavlovo/family/incest/event3/22.jpg',' В это же время Колька вытащил член и кончил вам на живот.**Миша вышел из ванной и засобирался.**\\\- Мне надо бежать: время поджимает - почти час с тобой кувыркались.///**\\- Ох, щас уже родители домой вернутся! Нам тоже пора заканчивать, Коль.// - вы принялись приводить себя в порядок.**\\- Машань, а ты ещё к нам заходи когда родителей дома не будет.//**\\\- Обязательно зайду!/// - убегая, сказал Мишка.**\\- Коль, ты не подумай чего! Я просто Мишку соблазняла: он мне для плана с Анькой пригодится. Ты не хуже его трахаешся, чуть опыта поднаберёшься - и можно в порно идти!// - вы нежно и многообещающе целуете брата. Кажется, все его обиды тут же забыты.'
																						act'Далее':
																							*clr & cla
																							$loc = 'korrPar'
																							minut += 1
																							$npc['38,qwKolka'] = 3
																							gs 'zz_funcs', 'cum', 'belly'
																							gs 'stat'
																							gs 'zz_render', '', 'pavlovo/family/incest/event3/23.jpg','\\- Ну что. Ты теперь богаче на десять тысяч, а я опытнее на одно двойное проникновение// - захихикали вы.**\\\- Не очень-то и смешно/// - угрюмо буркнул Колька.\\\- Обидно, знаешь ли, было.///**\\- Был бы ты девушкой - ты бы меня понял! Да и это, не забывай, мы теперь на шаг ближе к моему плану: скоро у тебя будет богатый выбор, а не одна я.//**\\\- Не сцы! Я молодой, мне сил на обеих хватит и ещё на пятерых останется!/// - взбодрился Колька.**\\- Ладно, я в душ побежала, а то родичи придут - а я тут вся в в ваших головастиках измазанная// - с этими словами вы направляетесь в ванную, уже прокручивая в голове следующую часть плана:<b>теперь вам нужно застать Аньку на кухне после полуночи.</b>'
																							act'Идти в ванную': gt 'zz_bathroom','start'
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
if $args[0] = 'incest_event3_sub':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event3sub/01.jpg','Зайдя в зал, вы увидели, что там сидит Мишка и рубится в гоночки:**\\\ -Аа, Светик, иди со мной поиграй, а то Колян куда-то отошел.///**\\- Приветик, ну давай, правда, я не очень хорошо играю,// - вы сели рядом и включились в игру.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event3sub/02.jpg','Немного погоняв, Мишка понял, что ваши навыки игрока стремятся к нулю.**\\\- Светуль, может поиграем в игры которые тебе даются лучше?///- с этими словами Мишка стал вас целовать.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event3sub/03.jpg','Затем он спустил вашу маечку и начал облизывать груди.**\\- Да такие игры мне больше по душе,// - со вздохом наслаждения пробормотали вы.'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event3sub/04.jpg','Вдруг вы почувствовали, что кто- то схватил вас за другой сосок. Вы были так увлечены ласками Миши, что даже не заметили как Колька подкрался к вам:**\\- Колька, негодник! Я тебя даже не заметила!//'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event3sub/05.jpg','Колька улыбнулся и начал гладить ваше обнаженное тело, а Миша расстегнул ваши джинсы и запустил свою руку вам в трусики вы почувствовали как его рука стала гладить ваш лобок, горячая волна возбуждения прокатилась по вашему телу.**\\- Ну, раз вся команда в сборе, то пожалуй пора начинать нашу игру,// - кокетливым голосом воскликнули вы.'
					act'Далее':
						*clr & cla
						minut += 1
						horny += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event3sub/06.jpg','Через несколько секунд Колька уже лежал на диване, надрачивая свой член одной рукой, а другой ласкал вашу грудь, Миша же спустил с вас джинсы, затем приспустил трусики и начал рассматривать вашу упругую попку.'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(7,8)+'.jpg','Вы с энтузиазмом начали обрабатывать Колькин член, когда почувствовали что Мишка трахает вашу киску своим пальцем.**\\\- Мокренькая, как и всегда! Светуль, ты похоже нимфоманка. Всегда рада гостям,/// - хмыкнул Мишка,\\\- Тебе с такой жаждой траха внутри самое место в порнобизнесе.///'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(9,11)+'.jpg','Как только Миша наигрался с вашей дырочкой, вы тут же уселись на корточки и начали работать сразу с обоими инструментами парней, то полизывая, то посасывая их и поочередно и оба сразу.**\\\- Я бы тоже в порно пошел,/// - пробормотал Колька,\\\особенно если там все так сосут как Светка.///'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(12,13)+'.jpg','Вы, оторвавшись от членов ребят, сказали:**\\- Коля там не болтать надо, а работать,// - вы легли на диван и призывно раздвинули ноги,\\- А раз хочешь туда попасть начинай тренироваться прямо сейчас, на мне!//**\\\- Да это мы запросто/// - Колька вогнал свой инструмент в вашу киску и начал в ней двигаться.**\\\- Светик, а моим-то красавчиком забыла заняться?/// - ухмыльнулся Мишка.**\\- Ой, прости! Действительно забыла!// - улыбнулись вы и начала работать с Мишкиным агрегатом ротиком и ручками.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event3sub/14.jpg','Увлекшись Мишкиным членом вы почувствовали как Колькино хозяйство покинуло вашу писечку. Вы уже хотели было возмутится, но тут почувствовали, что он входит в вашу попку.**\\\- Светик, а давай представим что мы в порно снимаемся!/// - захихикал Колька.**\\\- Точно! Крутая идея!/// - поддержал Мишка.\\\- Света, ну-ка покажи свои прелести зрителям.///'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(15,16)+'.jpg','Это предложение вас вдохновило. Представив себя порноактрисой, вы раздвинули свою писечку, чтобы всем предполагаемым зрителям было ее видно, возбудившись еще сильнее.**\\\- Вау, Светик, да ты прирожденная порнозвезда!/// - восхитился Мишка.'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(17,18)+'.jpg','Через минутку парни поменялись местами, теперь уже Мишкин член терся внутри вас, а вы обрабатывали Кольку.**\\\- Света, да ты течешь рекой, в натуре!/// - отметил Мишка, услышав звуки хлюпанья от своих движений.\\\- Это тебе так понравилось когда тебя Колька в попку трахал или же от мысли, что на тебя будут смотреть миллионы людей?///'
												act'Далее':
													*clr & cla
													minut += 1
													horny += 20
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(19,20)+'.jpg','С этими словами Мишка переключился на вашу попку, ощутив его елдак, плотно заполнивший задний проход, вы ненадолго выпустили изо рта член брата и томно вздохнули:**\\- Меня и то, и другое заводит, Миш! Давай глубже! Протрахай меня как в кино!// - восторженно сказали вы, и вновь страстно заглотили ждущий вас горячий шланг.'
													act'Далее':
														*clr & cla
														minut += 1
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(21,22)+'.jpg','Хорошенько продрав вашу задницу, Мишаня снова вернул вас в руки брата.Тот поставил вас раком и вы почувствовали его напряженной кол внутри себя - не то что бы вам это не нравилось, но вы почувствовали что парни крутят вами как куклой, передавая по очереди друг другу.'
														act'Далее':
															*clr & cla
															minut += 1
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(23,24)+'.jpg','Наигравшись с вами, Колька передал инициативу Мишке, тот усадил вас сверху на свой член. Вы было подумали что наконец дождались этого момента “двойного удовольствия” - то ради чего с подспудным предвкушением ждали каждый день появления Мишки. Но Колька снова вернул свой шланг вам врот.**\\\- Сестренка, поработай с моим суперменом,/// - попросил братец.**\\- Коля// - освобождая свой рот сказали вы,\\- хватит филонить, твоя сестренка хочет вас обоих.**\\\- Светик, ты не забыла что мы вроде как в порнофильме? Что ты должна сказать зрителям?///- напомнил вам Мишка.**\\- Трахните меня в обе дырочки!// - с восторгом завопили вы, поддерживая игру.'
															act'Далее':
																*clr & cla
																minut += 1
																horny = 95
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(25,29)+'.jpg','И вот, наконец-то вы ощутили как второй член вошел в вас и начал двигаться внутри, пробуриваясь все глубже. Не прошло и минуты под двойными яростными ударами, как волны оргазма стали накрывать вас, слегка потряхивая и заставив забыть обо всем.**\\- Айи-ии, да-а-а, божечка, еще, сильнее, продолжайте, ууууух!// - замычали вы, мотая головой.**\\\- Блин, Светка, да ори ты потише,/// - мощно отдупляя вашу задницу пробормотал брат,\\\- кончила, что ли?///**\\-Уммм,//- только и смогли простонать вы.'
																act'Далее':
																	*clr & cla
																	minut += 1
																	orgasm += 1
																	DPorgasm += 1
																	horny = 0
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(30,33)+'.jpg','Парни перевернули вас, кидая как неваляшку, и поменялись на дырках. Вы радостно раздвинули ягодицы:**\\- Ну же, ну же, мальчики, желаю вам кончить так же круто как и я!//'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event3sub/34.jpg','\\\- Ооох, бли-н блинский, Светик, в ротик, как настоящая актриса, давай, я уже сдерживаться не могу!/// - Миша опустил вас на корточки перед диваном и сунул в рот подрагивающий, готовый выстрелить елдак.'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(35,36)+'.jpg','\\\- Вот так, уй, быстро-быстро, принимай на язычок! ...Фу-ух, вот еще последние капли.///**\\- Что, глотать и облизываться, как девчонки в фильмах, да?// - рассмеялись вы,\\- Ну ладно!//'
																			act'Далее':
																				*clr & cla
																				minut += 1
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(37,38)+'.jpg','\\\- А теперь у меня, давай, сеструха,/// - сдавленно простонал Коля и разрядился туда же.**\\- Мняяя, вот, проглотила!//'
																				act'Далее':
																					*clr & cla
																					minut += 1
																					$loc = 'korrPar'
																					gs 'zz_funcs', 'cum', 'face'
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(39,41)+'.jpg','Вы довольно облизали остатки спермы с заляпанного лица, снимая их пальчиком::**\\- Все, конец фильма, я пошла приводить себя в порядок, а то чего-то плохо соображаю уже.//'
																					act'Идти в ванную':gt 'zz_bathroom','start'
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
if $args[0] = 'incest_event4':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event4/01.jpg','Вы заходите на кухню и вдруг обнаруживаете там вашу сестру, роющуюся в холодильнике.**“Чего это она не спит? Ага, вот кто холодильник тайком опустошает!, впрочем я так и думала”.**\\\- Пи-и-ироженка,/// - шепчет Аня и облизывается.**Кажется, она забыла обо всем на свете кроме еды.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event4/02.jpg','\\- Вот ты и попалась!// - торжествующе говорите вы, делая вид, что схватили воришку.**\\\- Света! Фух, ну ты меня и напугала! А я это...тут так...зашла…///**\\- Ты же говорила, что на диете?//**\\\- Ну да.///**\\- Просила меня следить, не давать тебе обжираться.//**\\\-П-просила.///**\\- А сама жрешь на ночь?! Смотри, пузико уже растет!//**\\\- Я не толстая!///'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event4/03.jpg','\\- Аха-ха, ну это пока! Ладно, рубай сколько влезет по ночам, а утром делай вид, что опять на диете. Я больше не буду париться.//**\\\- Свет, ну ладно, чо ты, я же чуть-чуть...на меня не влияет, я и так красивая.///**\\- Ну ничего так, ну-ка повернись.//'
			act'Далее':
				*clr & cla
				minut += 1
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event4/04.jpg','\\- Задница-то уже ого-го!// - вы провели по заду Ани рукой, почувствовали возбуждение и желание продолжать. Сжали вполне упругие и красивые ягодицы.**\\\- Ох, что ты делаешь...Света! Я вообще-то зашла заесть напряг...ну там, понимаешь? Давно секса уже с Рексом не было...а ты еще меня заводишь!///**\\- А может я тоже хочу?// - игриво спросили вы, продолжая обнимать сестру, \\- Давай поможем друг другу сбросить напряжение.//**\\\- Ну, я не лесба, да и ты вроде…///**\\- А кто говорит про лесбийство всякое? Не лесби. А еще не толстая. И красивая.//'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event4/05.jpg','\\\- Ох, хрен с ним,/// - Аня неожиданно приникает к вам, сливая губы в жарком поцелуе.**\\- Да-да-да,// - шепчете вы ей, обнимая за талию, \\- мы быстро и тихонько, тебе понравится.//'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event4/06.jpg','Вы стянули с сестры трусики и облизали открывшиеся соблазнительные формы. Она тяжело задышала и вы ощутили как ее горячее тело податливо откликается на ваши ласки.'
						act'Далее':
							*clr & cla
							minut += 1
							horny += 20
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event4/07.jpg','Вы усадили Аню на стол и так усердно заработали язычком в ее киске, особое внимание уделяя клитору, что девушка едва не вскрикнула от быстро накатившего наслаждения.'
							act'Далее':
								*clr & cla
								minut += 1
								horny = 80
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event4/08.jpg','\\- Давай, Ань, теперь твоя очередь!// - вы взгромоздились на столешницу и уселись на корточки, раздвинув ноги.**\\\- Так, Свет? Тебе хорошо?/// - сестра стала интенсивно водить языком по вашему разбуженному бугорку страсти.**\\- Да-а, помедленнее, оух… еще, главное не останавливайся!//**Вы притянули голову Ани к своему паху и стали двигать ей в нужном ритме. Вскоре слегка запретное и оттого еще более сладкое удовольствие довело вас до высшей точки и вы со стоном оргазмировали.'
								act'Далее':
									*clr & cla
									minut += 1
									orgasm += 1
									horny = 0
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event4/09.jpg','\\\- Уммм, так здорово,/// - целуя вас, крепко прижав к себе, пробормотала Аня, после того как вы обе кончили,\\\- я и не думала…///**\\- Надо почаще такое устраивать,// - хихикнули вы.**\\\- Ладно, время от времени неплохо. Хотя я больше крепкий мужской член в себе люблю. Да Рекс в последнее время…///**\\- Что, проблемы? Могу помочь. Не отходя от кассы, ха-ха.//**\\\- Это каким же образом?///**\\- Да есть кандидатура помощника. Ближе чем ты думаешь,// - лукаво посмотрели вы на сестру,\\- только надо отбросить некоторые предрассудки. С этим у тебя, смотрю, нормально получается.//**Аня покраснела, но продолжила ласкаться и улыбнулась:**\\\- Кажется, я знаю кого ты имеешь в виду. Не слепая. Но это...даже не знаю. Может, слишком?///**\\- Да нормально!// - вы погладили сестру по груди и снова жарко поцеловали.'
									act'Далее':
										*clr & cla
										minut += 1
										energy += 5
										$npc['38,qwKolka'] = 4
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event4/10.jpg','\\\- А теперь давай съедим пироженку! Калорий-то много потратили!/// - Аня вытащила из холодильника вкусняшку и разделила ее с вами.**\\- Пойдем теперь баиньки, тебе завтра на работу. А над очевидным решением проблемы все же подумай,// - решительно заявили вы.**\\\- Ладно, всё может быть. По-крайней мере, таскаться далеко не надо. Да и родня мы только наполовину.///**\\- Во-о-от, точно!//**<b>Надо бы сообщить брату хорошую новость поймаю его на кухне часиков в 6 утра</b> - подумали вы'
										act'Пойти спать': gt 'kuhrPar'
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
if $args[0] = 'incest_event5':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event5/01.jpg','Решив перекусить пораньше, вы варите диетическую кашу - ведь вам надо следить за фигурой и не есть что попало. Каша почти готова и в этот момент на кухню заходит Колька.**\\\- Светик, доброе утро! Что готовишь?///**\\- Приветик! Кашу варю! Будешь?//**\\\- Буду,/// - улыбнулся Колька.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event5/02.jpg','Положив кашу по тарелкам, вы уселись завтракать:**\\- Коля, я как раз после завтрака хотела к тебе зайти, сообщить новость.//**\\\- Какую еще?/// - с недоумением посмотрел на вас Коля**\\- Ну как же: ты, я, Аня! Забыл, что ли? Ну так вот: она согласна! Вроде как. Если ты сам не лоханешься. Так, что заходи к нам вечерком!//**\\\- Вот это новость! Не ожидал, что Анька на такое пойдет!///'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event5/03.jpg','Колька ликующе улыбнулся и нежно взял вас за руку**\\\- Света, ты правда этого хочешь?/// - спросил он серьезно.**\\- Конечно! Мы тут развлекаемся, а у нее с Рексом проблемы, какая же я тогда сестра, если не помогу ей!//**\\\- Тогда хорошо! Я к вам обязательно загляну.///**\\<b>- После 22 заглядывай в воскресенье, а то утром мы в магазин пойдем часиков в 9.</b>//'
			act'Далее':
				*clr & cla
				minut += 1
				$npc['38,qwKolka'] = 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event5/04.jpg','С этими словами Колька страстно вас поцеловал**\\\- Свет, а может отметим это дело как надо?///'
				act'Нет, давай лучше доедим, я голодная':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event5/04.jpg','\\- Коль, нам обоим собираться надо, а после этого мне опять в душ идти, я тогда точно опоздаю…//**\\\- Ну ладно, тогда в другой раз…,/// - с сожалением произнес Колька.'
					act'Далее': gt 'kuhrPar'
				end
				act'Я уж думала ты и не предложишь!':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event5/05.jpg','Колька встал из за стола и подошел к вам, начал целовать и обниматься. Вы почувствовали как ваша майка поднимается вверх, а затем ощутили Колькину руку, сжимающую вашу грудь.**\\- Коля, подожди секунду, надо все убрать со стола,// - с этими словами вы поднялись и стали прибираться.'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event5/06.jpg','Прибравшись, вы оба разделись и братец уложил вас на стол.**\\\- Сестренка, раздвигай-ка ножки, я тебя языком порадую для начала,/// - Коля исследовал вашу трепетную писечку пальцами и стал ее вылизывать. Вы отдались блаженству, вскоре почувствовав палец, поигрывающий в вашем заднем проходе.**\\- Ухх.. Как классно!// - от этих действий по вашему телу побежали мурашки возбуждения.'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event5/07.jpg','Поиграв с вашими дырочками, Колька сам возбудился так, что ему не нужна была дополнительная обработка, он встал и вошел в вашу киску.**\\- Колька, ты сегодня окреп даже без моего участия!// - вы положили руку себе на грудь и начали ее ласкать.'
							act'Далее':
								*clr & cla
								minut += 1
								horny += 25
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event5/08.jpg','\\\- Да от одной мысли про вас с Анькой вдвоем у меня дикий стояк! Надеюсь, ты не злишься?/// - Колька переместил свой инструмент в вашу попку и, приподняв ваши ноги, свел их вместе.'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event5/09.jpg','\\- Конечно, нет! Меня и саму эта мысль сильно заводит!// - Колька радостно прыснул, поняв что ваши желания совпадают. Он развел ваши ноги в сторону и начал рассматривать вашу писечку.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event5/10.jpg','Затем он поднес руку к вашим вторым губкам, раздвинул их, потом сжал и снова раздвинул. Он продолжал повторять это движение, пристально глядя на вас. Вас охватил жар, и вы почувствовали как ваши соки вытекают наружу.**\\\- Похоже, моей сестренке это нравится!/// - с победной ноткой произнес Колька.**\\- Конечно, дурачок, ты же играешься с моей эрогенной зоной,// - сквозь вздохи пробормотали вы.'
										act'Далее':
											*clr & cla
											minut += 1
											horny = 95
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event5/11.jpg','Присев на стул, брат посадил вас сверху на свой инструмент и снова начал играть рукой с вашей киской. Вы поняли что больше не сможете сдерживаться, вас затрясло и из вашей дырочки потекли еще более обильные соки. Оргазм накрыл вас с головой, а Колька все не останавливался**\\- А-ах, Колечка, остановись, дай дух перевести,// - завопили вы, ловя ртом воздух.'
											act'Далее':
												*clr & cla
												minut += 1
												orgasm += 1
												analorgasm += 1
												horny = 0
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event5/12.jpg','Он остановился и дал перевести вам дух. Вы, опершись на стол, сказали:**\\- Фуу-ух, это было суперкруто! Но я еще готова можем продолжать!//**\\\- Как скажешь, сестренка,/// - Коля вновь легко проскочил в вашу норку, что было и неудивительно - она промокла насквозь.'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event5/13.jpg','Через минуту Колька снова сменил дырочку:**\\\- Светик, я почти готов! Куда ты сегодня хочешь?/// - ухмыльнулся Колька**\\- Обкончай мою попку!// - все еще слегка задыхаясь, попросили вы.'
													act'Далее':
														*clr & cla
														minut += 1
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event5/14.jpg','Вы почувствовали как его член покинул вашу задницу, а затем почти сразу же по ней потекли горячие струйки его семени.**\\\- Аух, чотко-о!/// - сдавленно простонал Николай, разрядившись.**\\- Пыщь-пыщь, пиу-пиу, как в твоих игрушках на приставке,// - рассмеялись вы.'
														act'Далее':
															*clr & cla
															minut += 1
															gs 'zz_funcs', 'cum', 'ass'
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event5/15.jpg','Вы уже было собирались вставать, как вдруг Колька резко всунул свой член обратно. Это было для вас весьма неожиданно, но крайне приятно. Ваша норка снова потекла.**\\\- О, да-ааа, хоть бы никогда не вынимал!///'
															act'Далее':
																*clr & cla
																minut += 1
																gs 'zz_funcs', 'cum', 'anus'
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event5/16.jpg','Закончив свое дело, брат приподнял вас и нежно поцеловал, а вы, ощущая как с вас стекают обе жидкости и капают на пол, почувствовали себя на седьмом небе от счастья.**\\\- Светуль, ну что теперь в душ?///**\\- Ага!// - кивнув головой сказали вы.\\Только я тут мигом уберу...ммм, всякое,// - вы хихикнули и подмигнули:\\- Готовься к встрече с обеими сестрами, держи себя в форме, футболист!//'
																act'Прибраться': gt 'kuhrPar'
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
if $args[0] = 'incest_event5sub':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event5sub/01.jpg','Вы, собираясь в школу, зашли в ванную. И увидели как ваш брат Николай принимает душ.**\\- Колечка, ты сегодня рановато!//**\\\- Оо, вообще-то я тебя и ждал! Один мой дружок по тебе сильно соскучился.///'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event5sub/02.jpg','Колян вышел из душа и с ходу, ласково обняв вашу шейку, подарил жаркий французский поцелуй с язычком.**\\- Уу, неугомонный! Вот я же теперь вся мокрая, мне тоже в душ надо!//**\\\- Так заходи, вместе и примем!///'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event5sub/03.jpg','Колян быстро оставил на вас лишь одни трусики, затем затащил в душ. Целуя вашу шею, он добрался шаловливыми пальцами до вашей киски.**\\- Ладно, ладно,//- простонали вы,\\- давай только по-быстрому!//**\\\- Ну-ка в ротик тогда сразу!///- нахально заявил Коля.'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(4,5)+'.jpg','Вы встали на колени и начали облизывать его член.**\\- Я только недавно проснулась, так что тебе придется и мою норку разогреть,//- игриво сказали вы.'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(6,7)+'.jpg','Колька поднял вас, быстро стянул и откинул трусики, затем отодвинул вашу ногу и впился своим язычком в вашу киску.**\\- Ох да, как хорошо, братец!... А у тебя все лучше получается!//- ободрили вы.'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						horny += 10
						gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(8,10)+'.jpg','Отлизав куночку, Колян повернул вас лицом к стене и быстро вошел в увлажнившуюся норку, а его рука стала гулять по вашему возбужденному телу.**\\- Колька, давай уже к любимой дырочке переходи!//- изрядно возбудившись простонали вы.'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							horny += 20
							gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(11,12)+'.jpg','Колька переместил свой инструмент в вашу попку и стал вгонять его поглубже:**\\\- Так и скажи, что хочешь в попку!///**\\- Я везде хочу! Всегда и во все!//'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(13,14)+'.jpg','Вы развернулись Николаю и начали его целовать. Он задрал вашу ногу и пристроился поудобнее.**\\- Да! Да! Вгоняй! Обожаю это чувство наполненности! Гляди, моя киска уже течет рекой!//- прекратив целовать брата, выпалили вы.'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									horny += 20
									gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(15,17)+'.jpg','Вы рукой стали поигрывать со своей норкой, из которой все сильнее струились соки.**\\- Братец, дай-ка я сама поскачу на твоем инструменте!//'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(18,19)+'.jpg','Вы как можно быстрее оседлали Колькин елдачок и стали неистово на нем прыгать.**\\\- Света, с такой скоростью я сейчас кончу!///**\\- Аааа... и я!//- со стоном ответили вы.'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											horny = 95
											gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(20,22)+'.jpg','Ваша киска вся горела: в тщетной попытке ее остудить, вы пальчиками раскрыли половые губы. Вас тут же затрясло и волны оргазмы накрыли с головой, заставив забыться и громко заныть. Как блаженство чуть отступило, вы почувствовали горячую жидкость, выплеснувшуюся в вашу задний проход и от этого вы снова оказались на пике.'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												orgasm += 1
												analorgasm += 1
												horny = 0
												flag_tanga = tanga
												gs 'zz_clothing', 'redress', 0
												tanga = 0
												gs 'zz_bathroom', 'clean_me'
												gs 'zz_render', '', 'pavlovo/family/incest/event5sub/'+rand(23,26)+'.jpg','Немного отойдя, вы слезли с члена. В ту же секунду из обоих ваших дырочек потекло.**\\\- Светуль, ты просто бомба! - констатировал удовлетворенный брат.///**\\- Насчет бомбы не знаю, а вот после наших приключений с Мишей кончаю от анала как из пулемета!//- рассмеялись вы,\\- Ну а теперь надо душ принимать, а то в родители проснутся скоро.//Следующие минут десять вы принимали вместе душ, с трудом сдерживаясь от повторного захода.'
												act'Выйти': gt 'zz_bathroom','start'
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
if $args[0] = 'incest_event6':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event6/02.jpg','Вы утром ходили за покупками и теперь решили примерить обновки.**\\\- Сестренка нафига мы столько шмоток накупили?/// - смеясь, спросила Аня.**\\- Да ладно, не часто удается выбраться! Давай лучше мерять!//'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event6/03.jpg','Вы начали раздеваться, Аня решила вам помочь**\\\-Светуль, у тебя соски торчат ты что, уже возбудилась?/// - ухмыльнулась Анька**\\- Ага, я уже вся в предвкушении сегодняшнего вечера.//'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event6/04.jpg','После того как вы разоблачились до трусиков, Аня тоже начала раздеваться, ваши руки сами потянулись к ее обнаженному телу.**\\- И все же классная у тебя попка, сестренка!//'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event6/05.jpg','Раздевшись, Аня начала примерять новое нижнее белье. Вы же не могли оторвать от этого зрелища глаз.**\\\-Света, а ты что сидишь, тоже примерь!///**\\- Ох, засмотрелась на тебя и совсем забыла.//'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event6/06.jpg','Переодевшись, вы обе подошли к зеркалу. Вы стали водить руками по своему телу и вертеться перед отражением, Аня подошла сзади и обняла вас:**\\\- Светочка, ну где там наш футболист, ты же ему сказала приходить?///**\\- Сказала. Но у меня есть идея чем заняться пока мы его ждем!// - ваше новое нижнее белье мгновенно оказалось на полу, а вы сами присели на кровать.'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event6/07.jpg','Аня тут же оказалась позади вас и начала нежно целовать, а ее рука уже играла с вашей киской.**\\- Анька, ты же не лезби, помнишь?// - хихикнули вы.**\\\- Нет! Но я слегка изменила свое отношение к этому после нашей встречи на кухне,/// - нежно прошептала уже горячая девушка вам на ушко.'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event6/08.jpg','Аня засунула два пальца в вашу киску и начала нежно ими двигать. Стон наслаждения вырвался из вашего рта.**\\- Сестренка, да ты так круто делаешь...еще! Я и не знала, что наша нелесби так умеет!//**\\\- Помастурбируешь с мое - тоже научишься,/// - весело сказала Аня.'
							act'Далее':
								*clr & cla
								minut += 1
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event6/09.jpg','\\\- Оба-на, девчонки, вы тут уже без меня начали развлекаться?!/// - услышали вы голос за спиной, Колька зашел как всегда очень тихо.**\\\- А ты не опаздывай!/// - повернув голову, сказал Аня и встала на колени, подставляя свою попку Кольке.'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event6/10.jpg','Поняв намек, он быстро стащил с Аньки ее кружевные трусики и начал играться пальчиком с ее дырочкой, она не чуточки не смущаясь целовала вас, а рукой поигрывала с вашей писечкой.**\\\- Аня, я начну с тебя, ты ведь не против?///- решил уточнить Коля.**\\\- А зачем я подставила тебе свою задницу по-твоему?/// - оторвавшись от вашего рта, кокетливо сказала Аня.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event6/11.jpg','Колька решил показать себя с лучшей стороны, и медленно вошел в ее норку. Она тут же перестала вас целовать ее глаза округлились а изо рта вырвался стон.**\\\- Ох! Большой! Коля поосторожнее… - но, поняв что он знает что делать, Аня вернулась игре с вашей киской.'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event6/12.jpg','Через минуту Колька уже без стеснения и опаски двигался в ней, благо Аня была еще та распутница и кто знает что побывало внутри нее.**\\\- Ну как, сеструха, тебе нравится?/// - приподняв ее и, поигрывая руками с ее грудью, поинтересовался Колька.**\\\- Ох! Да! Великолепно! Давно надо было такое попробовать!///**\\- Я же говорила что ты не пожалеешь, Ань!// - шепнули вы, подползая к Ане и крепко ее целуя.'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event6/13.jpg','\\- Теперь моя очередь!// - сказали вы, Аня нехотя слезла с члена, вы тут же запрыгнули на Кольку сверху так, чтобы ваша киска оказалась прямо у его рта, а сами начали лизать елдак брата. Вскоре к вам присоединился второй жадный и умелый ротик.**\\- Подготовь мою кисулю!// - нежно сказали вы брату и тут же почувствовали как его язычок касается вас.'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event6/14.jpg','Как только Коля вас разогрел, вы тут же запрыгнули на его инструмент и принялись прыгать в позе наездницы, потирая рукой клитор, что еще больше вас возбуждало.**\\\- Светик, иди ко мне,/// - сидящая рядом сестра начала целовать вас и водить рукой по вашему обнаженному телу.'
													act'Далее':
														*clr & cla
														minut += 1
														horny += 15
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event6/15.jpg','Когда наступила очередь Ани, она уже избавилась от хоть и красивого, но ненужного белья и быстро оседлала Кольку.**\\- Анюта, а в попку не хочешь?- наклонившись и увидя неплохо разработанное заднее отверстие, спросили вы.**\\\- Хочу…///- чуть поколебавшись, решилась Аня.'
														act'Далее':
															*clr & cla
															minut += 1
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event6/16.jpg','Вы взяли рукой Колькин член и начали медленно ввинчивать его в Анину попочку.**\\- Вау, да он как тут и был, вошел почти без сопротивления!//**\\\- Я не об этом переживала… Я.. Я.. Мне было неловко в первый же раз просить об этом. Мало чего вы подумаете!///**\\- Не выдумывай, сестренка! Мы тут все свои! Правда, к нашей компашке можно еще кое-кого добавить, надо больше крепких агрегатов, ага?// - вы засмеялись,\\- и в обеих дырочках!//'
															act'Далее':
																*clr & cla
																minut += 1
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event6/17.jpg','Вы снова встали так, чтобы Колька доставал своим язычком до вашей норки.**\\- Коляша, можешь делать два дела разом?// - с иронией спросили вы.**\\\- Могу и больше!/// - восторженно ответил Колька и начал вылизывать вашу киску, не забывая и протрахивать Анину попку.**\\\- Охх! Божечки! Я сейчас! Ахххх!/// - переходя почти на крик, Аня затряслась в оргазме.'
																act'Далее':
																	*clr & cla
																	minut += 1
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event6/18.jpg','Давая Ане передохнуть, Колька переключился на вашу истомившуюся по знакомому инструменту попку.**\\\- Светик, пожили мою киску, я так давно не кончала, что еще хочу как ненормальная,///- попросила сестра и прижала вашу голову к своей промежности.'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		horny = 95
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event6/19.jpg','Аня прилегла на кровать. Вы продолжили поигрывать с ее писечкой. Это продолжалось до тех пор пока вы тоже не кончили, ощутив мощный импульс анального оргазма. Любуясь на него, Колька как обычно поинтересовался:**\\\- Свет, я почти готов, куда ты хочешь сейчас?///**\\- У меня сегодня для тебя подарочек! Можешь кончить прямо в киску, я сегодня на таблетках.//'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			orgasm += 1
																			analorgasm += 1
																			horny = 0
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event6/20.jpg','Колька тут же засунул свой инструмент в вашу дырочку и вы почувствовали как горячая жидкость начала толчками заполнять лоно.**\\\- Братишка, оставь и мне немного,/// - распутно хихикнула Аня.'
																			act'Далее':
																				*clr & cla
																				minut += 1
																				gs 'zz_funcs', 'cum', 'pussy'
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event6/21.jpg','Она взяла инструмент Кольки и нежно облизала язычком остатки спермы.'
																				act'Далее':
																					*clr & cla
																					minut += 1
																					$npc['38,qwKolka'] = 6
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event6/22.jpg','В финале вы втроем сомкнули языки и облизали друг друга.**\\\- Потряс!/// - довольно выдал Коля.**\\- Угу,//- пробормотали вы,\\- хотя я больше люблю в обе щелки, как вы с Мишей меня вертите.//**\\\- Что еще за Миша?/// - несколько ревниво спросила Аня.**\\- Да есть такой, можем познакомить,//- вы засмеялись в унисон с братом,\\- потом, если захочешь, конечно.//**\\\- Уже хочу!///**Вы рассказали сестре про Михаила и ваши тройные развлечения. Коля воодушевленно комментировал, расписывая все в красках.**\\\- Блин, я так опять заведусь, все по койкам - спать!/// - решительно заявила ваша старшая сестричка, затем добавила со смешком,\\\- При случае подумаем о расширении компании вот только как с родителями быть...///**\\- Не беспокойся я все улажу//- сказали вы.'
																					act'Лечь спать.': gt 'bed', 'sleep'
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
if $args[0] = 'incest_event6shop':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', '','\\Я тут по магазинам решила пробежаться. Пойдем вместе, вдвоем веселее!//**\\\- Здорово, погнали, а то я и сама хотела по нормальным магазинам пробежаться!///'
	act 'Ехать в город' :
		*clr & cla
		minut += 120
		money -= 10000
		$npc['38,qwShopping'] = day
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event6/01.jpg','**Вы поехали с сестрой в город и прошатались по магазинам до обеда, накупив кучу вещей и всякого сопутствующего барахла.'
		act'Положить вещи и идти по своим делам': gt 'bedrPar'
	end
end
if $args[0] = 'incest_event6sub':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(1,2)+'.jpg','\\\- Свет, давай кое-что прикинем. Не зря же столько барахла набрали.///**Вы усаживаетесь вдвоем на Анькину кровать и начинаете прикидывать друг на друга обновки. Близость тел друг друга и постоянные легкие касания слегка заводят вас и явно возбуждают Аню. Она слегка краснеет и посматривает на вас заблестевшими глазками с чувственным вызовом.'
	act'Далее':
		*clr & cla
		minut += 1
		horny += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event6sub/03.jpg','\\- Ох, не могу больше, я тебя хочу!// - вы впиваетесь в губы сестры жарким поцелуем.**\\\- Умм, кто ж против-то…,///- страстно бормочет Аня.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event6sub/04.jpg','Вы нежно раздеваете Аню, покрывая ее тело поцелуями и сами скидываете блузку.**\\- Есть у меня для тебя один сюрприз, сестренка!//**\\\- Ка-кой?///**\\- Закрой-ка глаза!//'
			act'Далее':
				*clr & cla
				minut += 1
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event6sub/05.jpg','Вы лезете в тайничок и достаете свое тайное оружие - замысловатый фаллоимитатор размером в 20 сантиметров:**\\- А вот какой! Можешь полюбоваться!//**\\\- Вау! Отличная игрушка.///'
				act'Далее':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event6sub/06.jpg','Вы вдвоем принимаетесь облизывать каучуковый дилдак.**\\\- Mмм, крепкий какой, не у всякого мужика найдешь,///- бормочет Аня, уснащая слюной игрушку,\\\- спасибо, что заботишься обо мне, сестренка.///'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(7,8)+'.jpg','Вы укладываете сестру на постель и начинаете играться дилдаком с ее клитором и возить его между быстро увлажняющихся половых губ Ани.'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(9,10)+'.jpg','\\\- Встааа-а-авляяяй! Ну же!/// - стонет Аня**Вы легонечко пропихиваете дилдо в ее киску.**\\\- Ооо, как хорошо, трахай меня!///'
							act'Далее':
								*clr & cla
								minut += 1
								horny += 10
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event6sub/11.jpg','Вдруг вы заметили как в комнату зашел Николай, жадно наблюдая за происходящим. Вы подмигнули ему.**Аня сначала смутилась и попыталась прикрыться.'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event6sub/12.jpg','\\\- А я думаю что за стоны, вы бы уж потише.///**\\- Присоединяйся, что стоишь как неродной!// - сказали вы. Сестра немного подумала, потом рассмеялась:\\\- Ладно, иди уж к нам, любовничек!///'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event6sub/13.jpg','Коля разделся и запрыгнул к вам на кровать. Аня обняла его, похотливо поинтересовавшись:**\\\- Ну что, готов к подвигам, а то я вся горю сейчас!///**\\\- Всегда готов!///'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event6sub/14.jpg','Николай достал свое хозяйство, лаская Аню. Она же принялась стаскивать с вас остатки одежды:\\\- А я Свету буду радовать одной ее забавной штучкой.///'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event6sub/15.jpg','Вы тут же улеглись на сестру валетиком, подставили промежность и она вставила вам дилдак в киску.**\\\- Вот так! Твоя очередь на каучук!///**\\- Ууу, да-а!// - проныли вы,\\- Как же круто!//'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(16,17)+'.jpg','Пока сестра протрахивала вашу писечку, Коля дал ей в ротик свой вставший инструмент и принялся с восторгом ласкать вашу задницу, целуя ягодицы и вставляя пальцы в анус:**\\\- Как же я люблю эту попку.///**\\- Так трахни меня туда-а!//- изможденно потребовали вы.'
													act'Далее':
														*clr & cla
														minut += 1
														horny = 75
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(18,19)+'.jpg','Николай вставил своего солдатика в ваш задний проход и стал медленно им двигать. Аня же ускорила работу фаллоимитатором. Вы замычали от двойного наслаждения.'
														act'Далее':
															*clr & cla
															minut += 1
															horny = 95
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event6sub/20.jpg','\\- Уй-яяяаах, кончаю, Коля, крепче вгоняй!//- слегка забывшись завопили вы, вплотную приблизившись к оргазму.**\\\- Тише, дурочка,///- в унисон произнесли Аня с Колей и оба рассмеялись.**Брат схватил ваши ягодицы и так крепко протаранил вашу задницу, что вы разрядились в бурном оргазме, попутно неосознанно пихая пальцы в киску сестры.'
															act'Далее':
																*clr & cla
																minut += 1
																orgasm += 1
																DPorgasm += 1
																horny = 0
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event6sub/21.jpg','\\- Ооух, это был абсолютный кайф,//- довольно сообщили вы, оборачиваясь и даря брату нежный поцелуй,\\\- А теперь вторую сестру вытрахай!///'
																act'Далее':
																	*clr & cla
																	minut += 1
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event6sub/22.jpg','Коля не заставил себя просить дважды. Аня в свою очередь устроилась валетиком, навалившись на вас разгоряченном телом и вновь вогнала вам в киску дилдо.'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		horny += 10
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(23,24)+'.jpg','Николай стал увлеченно протрахивать киску тут же сладко застонавшей девушки. Вы раздвинули ей ягодицы, чтобы вгонял поглубже и принялись язычком ласкать его яйца.'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(25,26)+'.jpg','Отлизав яйца брату вы принялись за клитор сестры, которая в полном самозабвении ерзала по всему вашему телу.**\\\- Господи, ну еще, еще, сей-ча-ас, а да-а, Светочка!///- заныла Аня, дойдя до высшей точки. Сестра пустила обильные соки прямо в ваш широко раскрытый рот. Вы радостно облизнулись.**\\\- О-х, девчонки, я сейчас тоже кончу!///- сообщил Николай, слегка задыхаясь от взятого ритма.**\\\- Можешь в меня, я на таблетках!///**Коля со стоном финишировал в Анину щёлку.'
																			act'Далее':
																				*clr & cla
																				minut += 1
																				horny += 10
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(27,31)+'.jpg','Вы раскрыли ей промежность пошире и залюбовались как из сочного лона вытекает поток спермы. Затем вылизали капельки семени.'
																				act'Далее':
																					*clr & cla
																					minut += 1
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event6sub/32.jpg','\\\- Надо почаще такое повторять,///- вся лучась невероятным довольством, пробормотала ваша старшая сестра.**\\- Значит, будем!//- уверенно откликнулись вы, и снова взяли в рот головку члена брата,\\- уммм...//**\\\- Я только за,/// - подтвердил Николай с энтузиазмом, хватая и тиская Анины сисечки,\\\- Ну скажи, ведь классно, тебе так понравилось...///**\\\- Все, пошел отсюда, как тебя и не было!/// - рассмеялась Аня,\\\- Мы сами решим, когда нужен будешь.///'
																					act'Лечь спать.': gs 'bed', 'sleep'
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
if $args[0] = 'incest_event7':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event7/01.jpg','\\- Мальчики, я сегодня слегка припозднилась: наряжалась специально для вас,// - сообщили вы, входя в комнату.**\\- Нравится?// - приоткрывая свою грудь, спросили вы.**\\\- Светуль, нам не то что на тебе надето, а то что под одеждой скрыто интересно,/// - слегка хамовато ответил Мишка.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event7/02.jpg','\\- Ну вот только зря время потратила,// - сбрасывая с себя одежду и вставая на колени, фыркнули вы.**\\\- Ты в любой одежде и без нее - красивая!/// - сказал Колька, пытаясь сгладить углы. Ребята спустили штаны и их члены привычно оказались в ваших загребущих ручках. Вы принялись их посасывать.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event7/03.jpg','Приведя в готовность инструменты, вы решили больше не тратить попусту время - ведь его у вас сегодня не так много.**\\- Так, мальчики, у нас сегодня ускоренный курс! Коля, начинай сразу с попки!//'
			act'Далее':
				*clr & cla
				minut += 1
				horny += 20
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event7/04.jpg','Разогрев вашу попку, Коля уступил место Мишке**\\- Мишань, моя сестра Аня хочет с тобой познакомится. Как ты на это смотришь?//- сквозь вздохи спросили вы.**\\\- Сестра, говоришь? А она такая же раскрепощенная как ты?/// - решил уточнить Миша, растрахивая ваш задик.'
				act'Далее':
					*clr & cla
					minut += 1
					horny += 20
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event7/05.jpg','Ребята оккупировали обе ваши дырочки. Вам уже было не до ответов на вопросы. Заметив это, за вас ответил Коля:**\\\- Не совсем, но мы над этим работаем! Ха-ха, крепко работаем! Вот примерно так!///**\\- Ой-иии, да, ух, круто!// - взвизгнули вы.**\\\- Ага, круто! Да я не против познакомиться, но там уж как выйдет,/// - ответил Мишка.'
					act'Далее':
						*clr & cla
						minut += 1
						horny += 95
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event7/06.jpg','Парни перевернули вас и продолжили свое дело.**\\- Ахх! Охх! Божечки! Миша, я тебе позвоню когда приходить!// - это последнее что вы успели пробормотать перед тем как вас охватили волны оргазма. Потом все мысли окончательно вылетели из вашей головы и вы погрузились в безмятежное наслаждение.'
						act'Далее':
							*clr & cla
							minut += 1
							orgasm += 1
							DPorgasm += 1
							horny = 0
							$npc['38,qwKolka'] = 7
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event7/07.jpg','Вновь и вновь кончая под двойными ударами, вы на миг открыли глаза и внезапно увидели за спиной у Кольки наблюдающего отчима. Парни ничего не замечали и продолжали разгоряченно двигаться внутри вас, а вы безостановочно оргазмировалине в силах вымолвить и словечка. Только стон наслаждения вырвался, наконец, из груди. Отчим стоял все это время пока вы кончали, молча рассматривая как вас трахают. Очевидно, он просто наслаждался зрелищем.**\\\- Так-так, что вы тут делаете, малолетки отмороженные?! А ну-ка марш отсюда!/// - перепуганные парни вскочили и начали судорожно одеваться.**\\- А с тобой, проститутка эдакая, мы еще поговорим!// - грозным тоном добавил он.'
							act'Одется': gt 'sitrPar'
						end
					end
				end
			end
		end
	end
end
if $args[0] = 'incest_event8':
	*clr & cla
	minut += 5
	lubri -= 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event8/01.jpg','Как и договаривались ранее, вы пришли в зал одевшись как явная распутница. Там вас уже с нетерпением ожидали:**\\\- О, Светка, как тебе идет наряд шлюхи-то! А теперь: покажи-ка нам свои прелести!/// - нагло усмехаясь, сказал отчим.'
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event8/02.jpg','Вы с нарочитым вызовом медленно разделись, встали коленями на столик стоящий посередине комнаты и выставили на обозрение всю промежность.**\\\- Отлично, ну что, начнем без прелюдий?/// - спросил отчим.**\\- Только не сразу два в попку!// - хоть вы и смазали ее лубрикантом, вас терзали некоторые сомнения: влезут ли сразу оба?**\\\- Пап, предлагаю сперва по одному на дырочку, Свете надо привыкнуть,/// - сказал Колька.'
		act'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event8/03.jpg','Такая поза для вас была уже привычна, поэтому вы не стали возражать, отчим лег на диван и усадил вас сверху, Колька же занялся вашей попкой.**\\\- Колька, сынок, разработай ей проход!/// - возбужденно просипел отчим, наяривая увлажнившуюся киску.**\\- Только не перестарайся, пожалуйста!// - испуганно попросили вы. Колька вгонял свой инструмент глубоко, но осторожно, вы уже привыкли к его размеру раньше, а со смазкой такой заход не доставлял вам неудобств. Постепенно приноровившись к ритму обоих родственничков, вы стали все больше возбуждаться.**\\- Думаю, я готова...ну наверно,// - неуверенно произнесли вы, между стонами.'
			act'Далее':
				*clr & cla
				minut += 5
				horny += 25
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event8/04.jpg','Вы почувствовали как сначала один, а затем и второй член оказались в вашей попе.**\\- Ай о-ой, не фига ж себе!// - вскрикнули вы.**\\\- Надо же, влезли!/// - изумился отчим.**\\- Можете начинать двигаться, только медленно!//- наконец-то решились вы.**Поначалу вам было довольно больно и вы поняли, что требуется дополнительная работа с анусом.'
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event8/05.jpg','\\- А-ай, бли-ин, постойте, я чуток поспешила, надо еще разработать!// - переводя дыхание, сообщили вы, слегка скривясь от боли.**\\\- Колька, переворачивай ее, щас я ей быстренько жопу разработаю! Дело привычное, кхе!///**\\- Эй-эй, только без крайностей! Я вам не резиновая!// - завопили вы, когда отчим стал неистово долбить вашу попку, а Коля буравил вашу киску. К вашему удивлению, вы не почувствовали ничего, кроме наслаждения.**“Отличная марка смазки, еще и обезболивает. Надо такой лубрикант всегда теперь брать!” - подумалось вам перед тем, как мысли окончательно вылетели из головы под жаркой волной сладострастия.**\\\- Все, Светуля, раздвигай свою задницу на полную,/// - сказал отчим через пару минут интенсивной долбежки, почти обломав вам весь кайф.'
					act'Далее':
						*clr & cla
						minut += 5
						horny = 95
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event8/06.jpg','Ощутив в своей попке оба инструмента, вы уже было приготовились терпеть неприятную боль, как вдруг поняли что ее нет, члены начали движение, а она так и не появилась.**\\- Все хорошо, можете продолжать,// - вы почувствовали как елдаки начали двигаться быстрее и быстрее, все глубже проникая в недра ануса.**Внутри вашей норки стало так горячо что невозможно было терпеть.**\\- Божечки! Мне в норку как будто залили кипяток!// - вы инстинктивно потянулись рукой к одиноко мокнущей писе и раздвинули пошире пальцами, будто это могло ее охладить.**\\\- Папань, похоже ей по кайфу, реально!/// - воскликнул Колька, любуясь на вашу норку.**\\- А-аххх, Д-ДААА!// - только и смогли вы пролепетать, прежде чем вас накрыло волной оргазма.**\\\- Смотри-ка, она еще и кончила от первой же двойки в попце, а ведь все отнекивалась,/// - снимая ваше почти обмякшее тело с членов и укладывая на диван, заметил невероятно довольный отчим.'
						act'Далее':
							*clr & cla
							minut += 5
							orgasm += 1
							DPorgasm += 1
							horny = 0
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event8/07.jpg','Видя, что вы уже приходите в себя, отчим строго покачал пальцем у вас перед носом.**\\\- Ну что, сама- то обкончалась как мартовская кошка, теперь семье помогай.///**\\- Хор-ро-ош-шо,// - с трудом промычали вы, еще не совсем оправившись от столь мощного оргазма. Обнаружив, что вы еще не способны на активные действия отчим сунул свой инструмент вам в рот, а Колька примостился к заднице. Между тем вы потихоньку приходили в себя, начиная вести себя более активно.'
							act'Далее':
								*clr & cla
								minut += 5
								$loc = 'korrPar'
								gs 'zz_funcs', 'cum', 'face'
								gs 'zz_funcs', 'cum', 'belly'
								$npc['38,qwKolka'] = 8
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event8/05.jpg','Полностью оклемавшись, вы присели на корточки, а Коля и отчим по очереди кончили вам в рот. Первым тишину нарушил отчим, с ухмылкой разглядывая как сперма стекает по вашему подбородку на сисечки.**\\\- Похоже, все остались довольны, а?/// - спросил он.**\\- Я… Я… Мне понравилось,// - наконец определились вы.**\\\- Ну вот и замечательно! Можете не переживать, я прикрою вас перед матерью, но все равно будьте осторожнее!///**\\- Спасибо,// - выдавили из себя вы, а потом неожиданно добавили,\\- А может это... того... ну вы понимаете!//**\\\- Вообще-то нет,/// - покачал головой Колька.**\\- Коля! Дурак! Ну трахатся я хочу так почаще! Но только мне и другие варианты попробовать интересно…//**\\\- Какие варианты?/// - на этот раз недоумевающе спросил отчим.**Вы умоляющим взглядом посмотрели на него, в надежде, что вам не придется произносить ваши потаенные развратные желания вслух, но он по-прежнему недогонял.**\\- Ну что вы не понимаете что ли, после такого я хочу попробовать все! Секс с тремя, с четырьмя! Два члена в норке! И даже три в разных вариациях! Ой, я это сказала?!//**\\\- Ого, ну ты разошлась! Хотя... могу тебе гарантировать что мы с Николаем по выходным тебя может оприходывать... в разных позах и вариациях, а дополнительных участников ищи сама.///**\\- Правда? Вы точно не против?// - с загоревшимися глазами спросили вы.**\\\- Да почему бы и нет! Можешь дружка вон своего подтянуть. Ну а пока бегом в душ - мыться, а то мать скоро вернется. Чтоб была без малейших следов! И лимон бы неплохо съесть, ха-ха.///**\\\- Ха-ха-ха,/// - заржал Колька.**“Это что, анекдот? Странный какой-то”, - подумали вы, собирая раскиданные шмотки.**Вы вышли из зала и направились в ванную думая про себя <b>теперь можно звонить Мишке в пятницу после 10 вечера, сделаю Ане сюрприз.</b>'
								act'Уйти': gt 'zz_bathroom','start'
							end
						end
					end
				end
			end
		end
	end
end
if $args[0] = 'incest_event8sub':
	*clr & cla
	minut += 3
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event8sub/01.webm','Вы заходите в зал, истомленная возбуждением с мыслью отдаться.**Ваш брат и отчим смотрят какое-то дурацкое шоу.'
	act'Далее':
		*clr & cla
		minut += 3
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event8sub/02.webm','\\- Ой, ну сколько можно эту гадость по телеку зырить,//- томно произносите вы с блудливой улыбкой.'
		act'Далее':
			*clr & cla
			minut += 3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event8sub/03.webm','Вы уваливаетесь на диванчик прямо на отчима:\\- Давайте займемся чем-нибудь повеселее!//**Вас тут же начинают тискать за мягкие места. Вы радостно болтаете голыми ножками в воздухе.'
			act'Далее':
				*clr & cla
				minut += 3
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event8sub/04.webm','Папочка с Коляном раздевают вас под кокетливые хихиканья.**\\\- Ого, Светка, ну у тебя и румянец! Жаром так и пылаешь!///**\\- Мммм, хочу два члена, хочу в каждую дырку, и чтоб быть отодранной круче, чем потаскухи в порно!//'
				act'Далее':
					*clr & cla
					minut += 3
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(5,6)+'.webm','Вас зацеловывают и начинают полизывать киску:\\\- Сочная какая!///'
					act'Далее':
						*clr & cla
						minut += 3
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(7,8)+'.webm','Отчим и Колька раздраконивают ваши горячие дырочки пальцами. Вы, раздвинув ноги, блаженствуете и тихо постанываете.'
						act'Далее':
							*clr & cla
							minut += 3
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(9,8)+'.webm','Затем жадно всасываетесь в приподнявшиеся члены, наяривая их ручками.'
							act'Далее':
								*clr & cla
								minut += 3
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event8sub/9.webm','Затем жадно всасываетесь в приподнявшиеся члены, наяривая их ручками.'
								act'Далее':
									*clr & cla
									minut += 3
									horny += 10
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event8sub/10.webm','Колька впихивает вам елдачок поглубже в рот. Отчим трахает вашу норочку пальцами так, что вы испускаете громкий стон удовольствия.**\\- Аууу, вставляйте уже, не могу!//'
									act'Далее':
										*clr & cla
										minut += 3
										horny = 70
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(11,12)+'.webm','Брат впендюривает вам агрегат на всю длину и, задрав ножку, лихо долбит:\\- Еще, еще, еще-е! Нет, давайте два! Тьфу, я сама все сделаю!//'
										act'Далее':
											*clr & cla
											minut += 3
											horny = 90
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(13,14)+'.jpg','Вы устраиваетесь на двух болтах разом в позе наездницы и начинаете как одержимая на них насаживаться:\\- Вот так, ваух, толкайте, толкайте-е-е поглубжеее!//**\\\- Ну, доча, ты и затейница,///- посмеивается отчим.'
											act'Далее':
												*clr & cla
												minut += 3
												orgasm += 1
												vaginalorgasm += 1
												horny = 0
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(15,20)+'.webm','Вас дружно харят в вагину парой членов, шоркая с такой страстью, что вскоре неизбежный оргазм прокатывается по всему телу до самых пальчиков ног. Вы радостно вопите.'
												act'Далее':
													*clr & cla
													minut += 3
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event8sub/21.webm','Оклемавшись, разводите ягодицы и похотливо лепечете:\\- Давайте в обе щели теперь!//**Отчим хмыкает:\\\- Погодь, блудодейка! Я только что в твою розочку отстрелялся…///**\\- Ой, а я и не заметила,//- глупо хлопаете вы глазками и хихикаете.'
													act'Далее':
														*clr & cla
														minut += 3
														horny += 30
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event8sub/22.webm','Папочка сует вам елдачину в рот и жестко наяривает, таская за голову:\\\- На сосочку, кушай, детка!///**\\- Умффх!//**Вы энергично сосете, сладостно мыча и чувствуя как братец продолжает долбать киску.'
														act'Далее':
															*clr & cla
															minut += 3
															horny = 65
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(23,26)+'.webm','\\\- А где наша попочка?! На-ка в мою сладкую!///- отчим ввинчивает вам вновь готовый орган в задний проход.**\\- Айиии, божечки, да-аа, наконец-то!//- вы выгибаетесь и в экстазе елозите на болтах.**Вас крепко чихвостят в оба отверстия.'
															act'Далее':
																*clr & cla
																minut += 3
																horny = 80
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event8sub/27.webm','\\\- Дай-ка я, пап!///- Колька насаживает вас на свой вздыбившийся от возбуждения елдак до самого корня.**\\- Умм-хууу! Фкхх.. И в два туда, давайте-давайте! Раздерите задницу, чтоб я кончила еще!//'
																act'Далее':
																	*clr & cla
																	minut += 3
																	orgasm += 1
																	analorgasm += 1
																	horny = 0
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(28,31)+'.webm','Вам с некоторым трудом протыкают расфаканную попку двумя инструментами и распахивают до самых потрохов.**\\- Йиииих...аааа!//- испустив животный вопль, вы буквально плавитесь под лавиной анального оргазма.'
																	act'Далее':
																		*clr & cla
																		minut += 3
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event8sub/'+rand(32,35)+'.webm','Брат с отчимом кончают вам в рот, набузгав столько, что вы проливаете на сисечки и животик.**\\\- Во ты даешь,///- слегка ошарашенно бормочет блаженствующий Колян.**\\\- Наша девочка!///- довольно ухмыляется отчим.'
																		act'Далее':
																			*clr & cla
																			minut += 3
																			gs 'zz_funcs', 'cum', 'lip'
																			gs 'zz_funcs', 'cum', 'pussy'
																			gs 'zz_funcs', 'cum', 'face'
																			agape = 1
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event8sub/36.jpg','Вы слизываете и глотаете пролитую сперму, пальчиком собирая ее с тела и таща в рот:\\- Умм-ня, это было здоровски! Надо повторить!//**\\\- Все, давай дуй ванную пока мамки нет,///- шлепает вас отчим по заднице, отправляя к двери.**Вы удаляетесь, нарочито вихляя слегка побаливающей попкой.'
																			act'Уйти' : gt 'zz_bathroom'
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
if $args[0] = 'incest_event9':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event9/02.jpg','Минут через 15 вы услышали звонок в дверь и пошли открывать. Мишка стоял на пороге слегка неуверенный. Вы быстро взяли его за руку и потащили в свою комнату.**\\- Миша, а ты быстро приехал.//**\\\- Говори потише, сестра же спит,/// - поднеся палец к губам сказал он тихо,\\\- Да я живу-то рядом, минут пять пешком.///**\\- Круто, я не знала! Слушай, давай сестренке сюрпризик устроим?//**\\\- Какой именно?///- решил уточнить Миша.**\\- Давай займемся тем, чем обычно занимаемся прямо рядом с ней, она проснется и деваться ей будет некуда!//'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event9/03.jpg','Мишке явно понравилась эта идея он присел на кровать где спала Аня и начал раздевать вас.**\\- Кстати, как тебе моя сестрёнка?// - спросили вы.**\\\- Симпатичная! И фигурка что надо!///'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event9/04.jpg','Избавившись от джинсов, вы тут же запрыгнули Михаилу на колени и стали его целовать, почти сразу же вы почувствовав как его рука устремилась к вам в трусики. А затем его пальчик оказался в вашем заднем отверстии.**\\\- Света, пока мы не зашли слишком далеко, скажи честно, что ты от меня хочешь?///- с прямотой спросил ваш визитер.**\\- Понимаешь, у нее вроде как есть парень, только она с ним постоянно ссорится да и кампания у него не самая хорошая… В общем, она когда выпьет развратничать начинает, а они этим пользуются.//**\\\- Ага, теперь понял. Значит, бескорыстная помощь?///**\\- Ну, не совсем бескорыстная,// - хитро улыбнулись вы и притянули парня к себе.'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event9/05.jpg','Мишка стянул с вас трусики и положил на кровать рядом сестрой и начал обрабатывать язычком ваши отверстия. Убедившись что Аня все еще спит вы продолжили.**\\- Они ее можно сказать за шлюху считают, а ей ей всего лишь внимания хочется ну и крепкого инструмента в себе по вечерам…//**\\\- История старая как мир…///- оторвавшись от вашей промежности произнес Мишка, - и снова вернулся к своему занятию.**\\- Так и есть! А ты вроде парень приличный и как бы только рад если девушка развратничать начинает… Ну и ты хотя бы с недотрахом помочь можешь сам понимаешь с Колькой-то часто опасно…,//- борясь с нарастающим возбуждением сказали вы.**\\\- Таких красоток как вы я хоть целыми днями насаживать готов! Короче, я тебя понял: твоей сестренке нужен хороший трах как и тебе. Это я могу вам обеим устроить!///'
				act'Далее':
					*clr & cla
					minut += 1
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event9/06.jpg','Миша засунул пальчик в вашу норку вы застонали, а он продолжил радовать вашу киску.**\\- А-ахх, да-а-а,// - простонали вы достаточно громко, чтобы сестра проснулась.**\\\- Света, какого черта, что ты делаешь на моей кровати? Блин, кто тут еще?!/// - сказала Аня, поднимая голову.**\\- А, ты наконец то проснулась,// - сказали вы пока ваша сестра ошеломленно наблюдала как незнакомый ей парень потрахивает вашу киску пальцем.'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event9/07.jpg','Вы рассмеялись и повернулись к сестре, Миша как ни в чем не бывало продолжал работать пальцем:**\\- Анют, это Михаил, про которого я тебе говорила.//**\\\- Привет Анют! Мне сказали, что я очень нужен двум красивым девушкам!///**\\\- Привет,/// - озадаченно сказала Аня, но затем широко улыбнулась.**\\- Не надо стеснятся!// - сказали вы Ане\\- Мишка у нас очень понимающий молодой человек. Иди лучше и поцелуй сестрёнку!//'
						act'Далее':
							*clr & cla
							minut += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event9/08.jpg','Чуть поколебавшись, Аня подползла к вам и начала целовать, Миша же тем временем оккупировал пальчиком вашу попку и начал ее разрабатывать.**\\\- Аня, расскажи нам, что ты предпочитаешь?///- спросил Мишка.**\\\- Предпочитаю?///- оторвавшись от ваших губ, с недоумением переспросила она.**\\- Сестрёнка, он хочет знать в каких позах и в какие дырочки тебе больше всего нравится!//**\\\- Светка, я и так поняла!///- покраснев сказала Аня.**\\\- Ну хорошо давай начнем с другого,/// - оторвавшись от вас, и подходя к Ане, сказал Мишка.'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event9/09.jpg','Затем ее маечка быстро оказалась на полу. Миша начал водить рукою по ее обнаженной груди, а вы решили заняться пока своей норкой, то вынимая, то погружая туда пальчик.**\\\- Аня, смотри Света к примеру любит, чтобы ей сначала разогрели норку,/// - без малейшего смущения сказал Миша.**\\- Именно так! И это только начало!// - добавили вы.**Аня покраснела и улыбнулась, а затем добавила:**\\\- В киску мне нравится….///'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event9/10.jpg','Мишка тут же нагнул вашу сестру и спустил с нее шортики, отправив затем пару своих пальцев в глубины ее норки, Аня охнула, а вы продолжая поигрывать уже со своей норкой наблюдали за выражением ее лица.**\\\- Аня, помоги-ка моему другу окрепнуть,/// - попросил Миша, после того как обработал ее щелку.**\\\- Помогу!/// - коротко ответила Аня, но вы заметили ка на ее лице мелькнула похотливая улыбка.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event9/11.jpg','Мишка достал свой инструмент и принялся трахать Анин ротик, вы же занялись ее киской, отметив для себя что она была уже довольно влажная.**\\\- Светуль, твоя сестренка сосет не хуже тебя!/// - заявил Мишка.**\\- Правда, может устроим соревнование?// - игриво заявили вы, отрываясь от Аниной норки.'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event9/12.jpg','Спустя минуту, вы уже лежали на кровати избавившись от ненужной одежды и на пару с сестрой работали над инструментом Мишки.**\\\- Да вы обе потрясные!/// - заявил Мишка и продолжил\\\- Кто будет первой сегодня?///**\\- Давай я, сейчас мы научим сестренку как надо себя вести! Но сначало мне нужна дополнительная обработка!//- заявили вы.'
											act'Далее':
												*clr & cla
												minut += 1
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event9/13.jpg','Аня продолжила обрабатывать член Мишки и, уже возбудившись, стала играть со своей норкой. Вы практически полностью погрузили свою киску в Мишин ротик, он же стал посасывать и полизывать вас, проникая своим языком прямо внутрь.**\\- Ох, да как же круто!// - завопили вы, услышав это, Аня оторвалась от своего занятия и повернула голову к вам. Увидев ,что Мишка творит с вашей норкой она сглотнула и вернулась к своему занятию начав еще усерднее натирать свою промежность.'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event9/14.jpg','Мишка положил вас на кровать и вогнал свой инструмент в вашу норку, затем начал двигаться, наращивая темп:**\\\- Аня, не хочешь поиграть язычком с клитором своей сестренки, думаю, ей понравится!///**\\\- С удовольствием,/// - Аня усердно принялась играть язычком с вашим клитором. Вы замычали от наслаждения.'
													act'Далее':
														*clr & cla
														minut += 1
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event9/15.jpg','Миша вынул из вас инструмент и сказал**\\\- Анюта, не хочешь попробовать на вкус свою сестренку?/// - Миша продолжал вести себя ни чуть не смущаясь.**\\- Сестрёнка, после разогрева я люблю ощущение когда чей то елдачок буравит мою попку, так что смажь его получше!// - добавили вы побольше пикантных комментариев. Аня фыркнула, но исполнила просьбу.'
														act'Далее':
															*clr & cla
															minut += 1
															horny += 20
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event9/16.jpg','Миша вогнал свой член в вашу попку и начал двигаться, засовывая его почти на всю длину. Аня смотрела на это зрелище, потом сказала:**\\\- Хотите чтоб я разошлась на полную? Ну тогда потом не жалуйтесь!///- с этими словами она схватила вас за бедра и начала вылизывать вашу киску.**\\- Ох да, вот это кайф, давно бы так!// - простонали вы.**\\\- Миша, по-моему пришла моя очередь, ты так не считаешь?///- игриво спросила Аня.'
															act'Далее':
																*clr & cla
																minut += 1
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event9/17.jpg','Миша лег на кровать, Аня быстро оседлала его, вам же ничего не оставалось как продолжать возбуждать себя пальчиками.**\\\- Анюта, ну может теперь скажет как ты любишь?///- повторил свой вопрос Миша.**\\\- Я так же как Светка, мы с ней в этом очень похожи…,///- все еще стесняясь произнесла Аня.'
																act'Далее':
																	*clr & cla
																	minut += 1
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event9/18.jpg','Хорошо разогрев Аню, Миша решил опробовать ее попку.**\\- Ну что, сестрёнка, ты довольна?//- подходя и целуя Аню, спросили вы.**\\\- Великолепно!///- охая, ответила сестра.**\\- А вот если Миша с Колькой будут тебя одновременно иметь - это будет еще круче, уж поверь мне!//'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event9/19.jpg','Аня вам ничего не ответила она и не могла. В этот момент ее застрясло и она стала кончать.**Вы вынули инструмент Мишки из ее заднего отверстия и начала смачно его облизывать.**\\\- Кажется, Аня готова, теперь твоя очередь, Светик!///**\\- Наконец-то я уже заждалась!//'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			horny = 95
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event9/20.jpg','Для финального рывка Миша предложил весьма интересную позу. Вы с Аней встали в позицию 69, а Мишка сверху вошел в вашу попку.**\\- Глубже! Вгоняй глубже!// - завопили вы, когда вас начали накрывать волны оргазма.**\\- Сестрёнка, у тебя из писи потекло!// - облизывая вашу норку, игриво сказала Аня'
																			act'Далее':
																				*clr & cla
																				minut += 1
																				orgasm += 1
																				analorgasm += 1
																				horny = 0
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event9/21.jpg','\\\- Я тоже уже готов!///- сказал Мишка, вы было хотели сказать, чтоб он кончил прямо в вас, но Аня была быстрее.**\\\- Миша, спусти мне в ротик!///- сказала сестра и пошире открыла рот.'
																				act'Далее':
																					*clr & cla
																					minut += 1
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event9/22.jpg','Мишка кончил прямо в ротик Ани, последние капли остались лишь у нее на язычке. Вы быстро подоспели чтобы слизать их.'
																					act'Далее':
																						*clr & cla
																						minut += 1
																						$npc['38,qwKolka'] = 9
																						gs 'stat'
																						gs 'zz_render', '', 'pavlovo/family/incest/event9/23.jpg','Вы обменялись поцелуем с сестрой, разделяя порцию спермы. Затем обе глянули на Мишку:**\\\- Спасибо, помощник свободен!///- Аня весело рассмеялась.**\\\- Да-да, я пошел, понадоблюсь - зовите в любое время.///**Михаил быстренько собрался и ушел.**\\- Ну что, как тебе?//- осведомились вы.**\\\- Суперкайф!///**\\- Отлично. Хочешь двоих попробовать? Я реально фанатею от этого!//**\\\- Нууу, даже не знаю, интересно, конечно…///**\\- Всё, значит, организуем. Готовься!//**\\\- Ладно, моя сеструха-нимфоманка, я досыпать буду, нарисуется чего-нибудь - скажешь.///'
																						act'Лечь спать.': gs 'bed', 'sleep'
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
if $args[0] = 'incest_event10':
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/event10/01.jpg','Минут через 10 позвонили в дверь и вы пошли открывать. Возвращаясь в свою комнату, вы увидели, что Аня с Колей уже начали без вас. Особо не раздумывая, вы тут же присоединись к ним.**\\\- Что у нас сегодня по программе?/// - спросил Миша.**\\- Двойное удовольствие!// - воскликнули вы.'
	act'Далее':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event10/02.jpg','Аня обрабатывала инструмент Кольки, а Мишка работал с вашими дырочками.**\\\- Аня, ты тоже будешь участвовать?///- отрываясь от вашей попки, спросил Миша.**\\\- Я... я… еще не решила, вот! Давайте начнем с чего-нибудь обычного,///- предложила Аня.'
		act'Далее':
			*clr & cla
			minut += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event10/03.jpg','Аня запрыгнула на Кольку и начала интенсивно скакать на нем, Мишка же занялся вами.**\\- Не переживайте, мальчики, я уж точно такой возможности не упущу!// - хихикая, сказали вы.**\\\- Вот и отлично!/// - сказал Колька,\\\- Хотя бы одна сестренка у меня не из стеснительных!///'
			act'Далее':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event10/04.jpg','Теперь уже Колька насадил на себя Аню, а Мишаня поставил вас раком:**\\\- Светуля молодец, знает как доставить парням удовольствие и самой провести время не хуже!///**\\\- Колька давай уже в попу,///- умоляюще застонала Аня.'
				act'Далее':
					*clr & cla
					minut += 1
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event10/05.jpg','Колька уложил вашу сестру на бок и быстро вогнал свой кол в ее попку, вы тоже последовали их примеру и быстро насадили свой задик на Мишин инструмент.**\\\- Ах, да-а, трахай мою задницу!///- завопила Аня, начав теребить свою киску.**\\\- Анют, хочешь я тоже поработаю над твоей попкой?///- спросил Мишка.**\\\- Да,///- Аня слегка замялась, а потом, отбросив сомнения, продолжила,\\\- Да, да, да! И сразу двоих тоже хочу...///'
					act'Далее':
						*clr & cla
						minut += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event10/06.jpg','Вы сменили партнеров, зато позы на этот раз были почти одинаковые. Вздохи и повизгивания шли от вас обеих нескончаемым потоком.**\\- А теперь пусть Аня получит что хотела ведь это для нее все и организовывалось,//- сквозь стоны предложили вы.**\\\- Светка! Ты из меня такую же нимфоманку как сама сделать хочешь!///- провопила сестра.**\\- А тебе, можно подумать, не нравится! Мальчики ну-ка покажите этой недотроге! Растрахайте ее на пару, наконец!//'
						act'Далее':
							*clr & cla
							minut += 1
							horny += 20
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event10/07.jpg','Аньку уселась верхом на Колю, а Миша вошел сзади. Уже секунд через 10 сестренка начала сама подмахивать бедрами парням и вылизывать вашу подставленную к ее ротику грудь.**\\\- Аня, ты как?///- решил узнать Мишаня.**\\\- Ахх! Охх! Божественно! Что же я так долго ждала-то!///- спустя минуту Аня уже во всю кончала, а парни проделали с ней то же, что и в первый раз с вами.**\\- Дайте-ка и мне немного!//- взяв члены парней сказали вы, а Аня тем временем приходила в себя.'
							act'Далее':
								*clr & cla
								minut += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event10/08.jpg','Вы посасывали член Мишки, а рукой работали с Колиным инструментом.**\\\- Ну что Анюта продолжим?///- осведомился Миша.**\\\- Дааа! Еще хочу!///'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event10/09.jpg','Мальчишки перевернули ее и теперь уже Колька занялся ее попкой, а Мишка взял на себя норку, вы же решили поиграть с сисечками сестры.**\\- Вау! Похоже, нашу скромницу понесло,//- прыснули вы со смеху, видя как через минуту Аня снова впала в предоргазменное состояние.**\\\- Типа мы слегка перегнули, ага? Надо бы дать ей передохнуть///- сказал Миша.'
									act'Далее':
										*clr & cla
										minut += 1
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event10/10.jpg','Миша вынул из вашей сестры елдак, но вы были тут как тут и быстро обхватили его ротиком.**\\\- Эй-эй, оголодавшая, тут у нас кое-кто почти отключился!///**Вы взглянули на сестру, на миг выпустив член.**Зрелище было воистину великолепным: Аня была в полу сознательном состоянии, насаженная на Колькин инструмент, а из ее норки безостановочно сочились соки. Все это продолжалось до тех пор пока девушка не пришла в себя.'
										act'Далее':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event10/11.jpg','После того как ваша сестра, наконец, оклемалась парни занялись уже вашими дырочками.**\\\- Ребята, я так никогда не кончала в голове до сих пор все плывет!///**\\- А ты думала я просто так на это дело подсела,// - повизгивая от удовольствия, похвастались вы.**\\\- Анечка, иди сюда обработай мой шланг,///- сказал Мишаня, заметив, что Аня готова продолжить участие в оргии.'
											act'Далее':
												*clr & cla
												minut += 1
												horny = 95
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event10/12.jpg','Девушка, причмокивая, начала работать с разгоряченным агрегатом. Вы хоть и ощутили пустоту в попке, но Коля не давал скучать второй дырочке.**\\\- Эх, раз уж мы так сблизились теперь,///- тяжело придыхая, сказал Миша,\\\- я бы мог познакомить вас со своими друзьями: они тоже это дело любят, сестренки им точно понравятся!///**\\- Я согласна!!//- завопили вы\\- А теперь уже дотрахайте меня, наконец, чтоб я откончалась как наша Анька-пулемётчица!//'
												act'Далее':
													*clr & cla
													minut += 1
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event10/13.jpg','Ребята перевернули вас и начали загонять свои разбухшие органы как можно глубже внутрь. Знакомое ощущения мощного двойного оргазма прокатилось телу волна за волной.**\\\- Анют, как насчет тебя?///**\\\- Я не так быстро привыкаю к незнакомым как сестренка, поэтому я бы пока ограничилась братцем и тобой...пока!///'
													act'Далее':
														*clr & cla
														minut += 1
														orgasm += 1
														DPorgasm += 1
														horny = 0
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event10/14.jpg','Пока вы пытались отдышаться, переживая достигнутое блаженство, Аня решила попробовать влезут ли сразу оба инструмента в ее ротик.**\\\- Ого, влезли сразу парой!///- победоносно воскликнул Мишка,\\\- Давай-давай, потренируй сосочку! Ооо, кайф!... А что касается твоей просьбы Анюта, то я всегда готов помочь в этом благородном деле, особенно такой милашке.///'
														act'Далее':
															*clr & cla
															minut += 1
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event10/15.jpg','Парни усадили вас с Аней на кроватке и дали финально выдоить подрагивающие от возбуждения члены.**\\\- Ну-ка, девчонки, попробуйте вкус победы!///'
															act'Далее':
																*clr & cla
																minut += 1
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event10/16.jpg','Николай разрядился в Анечкин ротик. Девушка жадно облизала член застонавшего брата.'
																act'Далее':
																	*clr & cla
																	minut += 1
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event10/17.jpg','Миша выстрелил в вас впечатляющим фонтаном семени.**\\- Мняуу, как здорово!//- пропели вы, пытаясь все проглотить, но все же проливая.'
																	act'Далее':
																		*clr & cla
																		minut += 1
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event10/18.jpg','После чего не забыли поделиться полученными порциями с сестрой.'
																		act'Далее':
																			*clr & cla
																			minut += 1
																			$npc['38,qwKolka'] = 10
																			gs 'zz_funcs', 'cum', 'lip'
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event10/19.jpg','Вкусно облизав остатки семени друг с друга, вы стали приводить себя в порядок.**\\- Ух, классно провели времечко!//- весело констатировали вы.**\\\- Да, просто отлично,///- дружно поддержали остальные.**\\\- Миша, ты не мог бы ты задержатся на пару минут,///- остановила сестра уже уходящего Михаила.\\\- А вы идите-идите!///- добавила она вам с Колей.**Что потом происходило вам осталось неизвестно, однако, вы подметили как Мишка уходил минут через двадцать с широкой улыбкой на лице.'
																			act'Уйти': gt 'korrPar'
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
if $args[0] = 'incest_event10sub':
	*clr & cla
	minut += 1
	$npc['38,qwmisha'] = 1
	gs 'stat'
	gs 'zz_render', '', '','\\- А чей-то ты тут с Мишкой секретничаешь?//- спрашиваете вы, немного ревниво.\\\- Ну я...мы...нравится он мне,///- слегка мнясь, сообщает Аня,\\\- Или ты против?///\\- Ха-ха, да ни разу! Он, конечно, крутой трахарь, но у меня другие интересы. Шире, бггг!//\\\- Он меня на свидание пригласил,///- гордо сообщает Аня,\\\- но мы, конечно, будем и с вам тоже...с Колей, с тобой...это мне понравилось.///\\- Давай дерзай,//- подбадриваете вы сестру,\\- Уверена, все получится.//'
	act'Отойти': gt 'bedrPar','start'
end
if $args[0] = 'incest_event11':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', '','\\\- Свет, мне вчера Мишичка звонил. Уговаривал нас с тобой поехать в Энск, оторваться в клубешнике. Какую-то сделку его друзья отмечают. Солидные мужчины, при деньгах, говорит. Едем?///**\\- А Кольку-то пригласили?//- хихикая, спрашиваете вы.**\\\- Ну, куда ж без него,///- смеётся Аня в ответ.**\\- Да поехали,//- пожимаете вы плечами,\\- а когда?//**\\\- Бых-ха, прямо вот сейчас, если решаем. Думаю, накраситься надо поярче, ну и вообще... Успеешь?///**\\- Уже бегу!//**Через пять минут к подъезду вашего дома подъезжает такси. Вы с Аней спускаетесь и садитесь в машину. Миша с Колькой уже там.'
	act'Далее':
		*clr & cla
		minut += 30
		gs 'zz_funcs', 'alko', 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event11/01.jpg','Вы танцуете и веселитесь в клубе, обнимаясь с парнями. Вам постоянно приносят коктейли и вы легко выпиваете, но угнаться за сестрой явно не в силах. Та выглатывает алкогольные напитки в минуту и скоро приходит в кондицию крепкого опьянения.**Вы весело болтаете с одним из мужчин, с которыми познакомились. Он подмигивает вам и сует в ладошку какую-то розовую таблетку в виде сердечка.**\\\- Это экстази, попробуй - понравится!///**Скептически глянув на таблеточку, вы решаете, что если экспериментировать, то уж точно не на себе.**Вдруг видите Аню, целующейся с каким-то новым персонажем - кажется, это Руслан из ваших сегодняшних новых знакомых, друзей Миши.'
		act'Оттащить ее и сделать внушение':
			*clr & cla
			minut += 30
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event11/02.jpg','Вы отводите Аню в туалет:**\\- Анька, ты чо?! У вас же с Мишкой вроде отношения. Ты говорила он тебе нравится и хочешь, чтобы все было серьезно?//**\\\- Ой, да! Чо-т-та я перепила слегка. Недоперепила... ик, ха-ха. Прости, сёстренка, спасибо тебе! М-мишка-то не видел?///**\\- Нет, я тебя вовремя утащила. Еще минута и ты бы тут всем дала!//**\\\- Ну прям всем… Но кое-кому, хи-хи-хи...///**\\- Всё, пора ехать!//- решаете вы.**Вы находите Мишку с Колькой и ультимативно сообщаете, что надо заканчивать затянувшееся веселье в клубе.**Миша пожимает плечами:\\\- Давайте ко мне, сейчас такси вызову.///'
			act'Далее':
				*clr & cla
				minut += 30
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event11/04.jpg','Вы приехали в квартиру Михаила. Аня требует еще выпить. Вы стаскиваете с нее юбку и шлепаете по заднице:\\- А ну хорош бухать, я лучше покувыркаюсь.//**\\\- Ааа, давайте! Ребята, вы готовы?///** Дразня парней телесами - спрашиваете вы.'
				act'Далее':
					*clr & cla
					minut += 30
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event11/05.jpg','Миша с Колькой оперативно скидывают одежду и подходят к вам с членами наизготовку:**\\\- О, мои любимые кранчики!///- Аня с высунутым языком поглаживает елдак ладошкой, вторую руку опуская на киску,\\\- Хочу-хочу-хочу!///'
					act'Далее':
						*clr & cla
						minut += 30
						horny += 15
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event11/06.jpg','Вы обе сосете у парней. Как обычно, член во рту вас возбуждает.**\\\- Давайте уже дырочки, девчата! Я так в этом клубе подзавелся…,///- говорит Михаил,\\\- Попки к бою!///**Вы с Аней, хихикая, быстро уснащаете задницы смазкой.'
						act'Далее':
							*clr & cla
							minut += 30
							horny += 20
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event11/07.jpg','И резво запрыгиваете на болты. Брат растянув ваши ягодицы, аккуратненько протрахивает ваш задний проход. Анька самозабвенно скачет на Мишке, который разогревает ей кисочку рукой.'
							act'Далее':
								*clr & cla
								minut += 30
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event11/08.jpg','\\\Давайте поприкольнее! Девчонки, залезайте друг на дружку!///'
								act'Далее':
									*clr & cla
									minut += 30
									horny += 20
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event11/09.jpg','Вы устраиваетесь на спине сестры. В ваших попках, тем временем, меняются стволы партнеров.**\\\- Вау-ух, не могу, трахните меня в обе щёлки,///- умоляюще просит Аня.'
									act'Далее':
										*clr & cla
										minut += 30
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event11/10.jpg','Парни выполняют просьбу, ваша сестра довольна до предела и визжит:**\\\- Еще, еще, как же я люблю когда все заполнена-ааа!///**\\\- Ань, примешь два в попочку?///- спрашивает Михаил.**\\\- Йо-о! Да, я бы сейчас слона приняла!///'
										act'Далее':
											*clr & cla
											minut += 30
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event11/11.jpg','\\\- Сестричка, наслюнявь моего,///- Коля сует вам в рот багровый от возбуждения елдак. Вы интенсивно работаете ротиком, добавляя побольше слюны.**\\\- Во, теперь два в дырочку!///'
											act'Далее':
												*clr & cla
												minut += 30
												horny = 70
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event11/12.jpg','Аня с восторгом принимает пару членов в задний проход. Вы разгораетесь, наблюдая как она кайфует.**\\- Теперь меня, меня!//**\\\- Мы тебя не забудем, Свет, ха-ха!///'
												act'Далее':
													*clr & cla
													minut += 30
													horny = 85
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event11/13.jpg','Вы усаживаетесь на Мишкин корень. Аня услужливо раскрывает ваши ягодицы и член брата врубается между них.**Вы счастливо елозите между елдаками, наслаждаясь все больше под каждым ударом таранов внутрь.'
													act'Далее':
														*clr & cla
														minut += 30
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event11/14.jpg','Аня сама жадно хватает разбухшее достоинство брата и насасывает как заведенная.**Вы стонете:**\\- У-умх, и мне пару в задик, я готова!//'
														act'Далее':
															*clr & cla
															minut += 30
															orgasm += 1
															analorgasm += 1
															horny = 0
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event11/15.jpg','Ребята протыкают ваш анус двумя членами и вы, задрожав, оргазмируете.**\\- Уууууу-йииии,//- пищите вы,\\- как же круто-о-ооо! Я улетаю, блин!//**\\\- Я еще хочу!///- с завистью бормочет Аня.'
															act'Далее':
																*clr & cla
																minut += 30
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event11/16.jpg','Парни прохаривают ее по новой в две дырки и ваша сестра с протяжным стоном финиширует.'
																act'Далее':
																	*clr & cla
																	minut += 30
																	horny = 90
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event11/17.jpg','Мишка усаживает вас на раскаленный орган:**\\\- Давай, Светланка, сейчас, уже скоро...прыгай...ой..на-а..///**\\- Мамочка-а, я же еще кончу-у…,//- в экстазе вопите вы.**Зафаканная балдеющая Аня с чмоканьем обсасывает елдак брата.'
																	act'Далее':
																		*clr & cla
																		minut += 30
																		orgasm += 1
																		analorgasm += 1
																		horny = 0
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event11/18.jpg','Ребята снова меняются на ваших задних дырках, резко ускоряя фрикции.**И вы, внезапно, ловите еще один анальный оргазм.**\\\- Ааа, все девчонки, в ротики, в ротики, глотайте!///- ревет трясущийся Миша.'
																		act'Далее':
																			*clr & cla
																			minut += 30
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event11/19.jpg','Вы на коленках выдаиваете подрагивающие болты.'
																			act'Далее':
																				*clr & cla
																				minut += 30
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event11/20.jpg','Коля спускает в рот Ани.'
																				act'Далее':
																					*clr & cla
																					minut += 30
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event11/21.jpg','А Мишка разряжается на ваш подставленный язычок.'
																					act'Далее':
																						*clr & cla
																						minut += 30
																						$npc['38,wedding'] = 1
																						gs 'stat'
																						gs 'zz_render', '', 'pavlovo/family/incest/event11/22.jpg','Вы целуетесь с сестрой, слизывая друг с друга теплое семя.**\\\- Классно отдохнули,///- расслабленно бормочет Миша.**\\- Уум-мня, я за то, чтобы всегда так,//- практически хором говорите вы с Аней и смеетесь.**\\\- Домой надо, родоки наедут,///- напоминает Коля.**Приняв душь, вы втроем бегом, счастливо держась за руки, отправляетесь домой.**\\\- Нормально погуляли,///- констатирует Аня, с удивлением глядя, что уже стемнело.'
																						act'Зайти в квартиру': gt 'korrPar'
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
		act'Незаметно кинуть в ее бокал таблетку' :
			*clr & cla
			minut += 30
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event11/03.jpg','Вы решаете довести развращение сестры до конца и тихонько подкидываете ей в спиртное таблетку-сердечко, отлично осознавая как она подействует.**Аня заводится и начинает вести себя совершенно по-блядски, вешаясь на мужиков напропалую. Увидев это, Мишка только усмехается.**Руслан предлагает поехать к нему всем вместе и достойно завершить вечер, чтобы было что вспомнить.**\\\- Да-да-да! Едем,///- загорается Аня.'
			act'Далее':
				*clr & cla
				minut += 30
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event11/23.jpg','Вы приехали на квартиру Руслана в компании изрядного количества подвыпивших парней. В неплохо обставленных апартаментах обнаружился крепкий мускулистый мужчина в возрасте с характерной внешностью:**\\\- Это мой дядя Шавкат, все знакомьтесь!///**Дядя Шавкат весьма плотоядно рассмотрел вас с сестрой:**\\\- Ошэн приятна, дэвушки! Э, сейчас гулять будем, отдыхать. Ви молодежь, виселье нада. Есть коньяк - такой никто не пил, клянусь!///**\\\-Мне, мне!///- радостно завопила Аня. Вы только вздохнули: не исправишь.'
				act'Слегка пригубить спиртное':
					*clr & cla
					minut += 30
					horny += 10
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event11/24.jpg','\\\- Давайте продолжим танцевать! Девчонки, зажигайте!///**Вы танцуете с пьяной сестрой перед парнями и Шавкатом. Она вас обнимает и вдруг начинает раздеваться.**\\\- Ох, что-то я завелась, прям зуд нестерпимый!///**Вы лижете обнаженные сисечки сестры:**\\- Что, все так и будут глазеть? Присоединяйтесь!//- командуете вы.**\\\- Р-рз...тьфу! Раздевайтесь! Я хочу быть проёбана всеми!///- бесстыдно заявляет Аня.'
					act'Далее':
						*clr & cla
						minut += 30
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event11/25.jpg','Вскоре вас окружают голые мужские тела. Аня с восторгом смотрит на елдак Шавката:\\\- Уу, какой!///**\\\ -Э, попробуй, нэ атарвешься!///**\\\- Я с удовольствием!///**Вас обеих тискают и стаскивают нижнюю одежду.'
						act'Далее':
							*clr & cla
							minut += 30
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event11/26.jpg','Вы с сестрой устраиваетесь на коленях и принимаетесь сосать члены.**Аня чмокает с таким воодушевлением и жадностью, что каждый хочет отпользовать именно ее ротик.'
							act'Далее':
								*clr & cla
								minut += 30
								horny += 20
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event11/27.jpg','Вы сообразительно смазывате анус лубрикантом себе и самозабвенно глыркающей елдаками в горле Ане.'
								act'Далее':
									*clr & cla
									minut += 30
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event11/28.jpg','Вас устраивают на диване и вгоняют мощные посохи в подготовленные дырки.**\\\- Дай-ка попка твоя сладкая, вот так!///- Шавкат оккупирует своим солидным достоинством ваш задний проход.**\\- Аууу! Какой же он...ох...круто-о!//**\\\- Светка, покажи класс,///- смеется Миша, наяривая в ротик вашу мычащую от наркоты, алкоголя и похоти сестру.**\\\- Фигачьте меня во все щели!///- стонет Аня.'
									act'Далее':
										*clr & cla
										minut += 30
										horny += 20
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event11/29.jpg','Пока вашу попку яростно долбает болт кавказского родственника, Аню пропесочивают в три дырки.**Она с одержимостью изгибается и насаживается на члены, иногда отрываясь от соски и мотая головой в экстазе:**\\\- Божечки, как обадленно! Ещё, ещё!///**Мишка собирается протрахать вашу киску, но вы решительно возражаете:\\- Нет, сегодня меня только в зад! Добавь мне туда!//'
										act'Далее':
											*clr & cla
											minut += 30
											horny = 70
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event11/30.jpg','\\- Ыаааа, да-а!//- вы с истошным воплем принимаете пару елдаков в попочку.'
											act'Далее':
												*clr & cla
												minut += 30
												horny = 85
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event11/31.jpg','Вас с сестрой долбают в разных позах. Аня громко оргазмирует, но ваши похотливые вопли все перекрывают.'
												act'Далее':
													*clr & cla
													minut += 30
													orgasm =+ 1
													analorgasm =+ 1
													horny = 0
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event11/32.jpg','Вас усаживают на два горячих кола. Вы бешено скачете на них и, наконец, добиваетесь вожделенного анального оргазма.'
													act'Далее':
														*clr & cla
														minut += 30
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event11/33.jpg','Вас обеих на полу шкворят в услужливо раздвинутые попочки все по очереди, сменяя один другого.**\\\- Э, темненькая, ложысь на бляндинка, в попа кончу,///- Шавкат берет вас на руки и кладет на сестру.'
														act'Далее':
															*clr & cla
															minut += 30
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event11/34.jpg','Затем ускоряется, вбивая раскаленный таран в вашу кишку и с рыком эякулирует внутрь.'
															act'Далее':
																*clr & cla
																minut += 30
																horny += 20
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event11/35.jpg','Затем в вашу попку финишируют еще двое, вы не видите кто.'
																act'Далее':
																	*clr & cla
																	minut += 30
																	horny += 5
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event11/36.jpg','Вы выпускаете полученное семя, напрягая сфинктер, прямо в Анькин ротик.**Уфаканная вусмерть сестра поглощает сперму. Глотает и вылизывает остатки с вашей дырочки.'
																	act'Далее':
																		*clr & cla
																		minut += 30
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event11/37.jpg','\\\- Ааа, девчонки, держите ещё,///- слегка наклюкавшийся и слабо участвовавший в оргии, Колька разряжается вам на лица.'
																		act'Далее':
																			*clr & cla
																			minut += 30
																			agape = 1
																			anus += 1
																			$npc['38,anayslut'] = 1
																			gs 'zz_funcs', 'cum', 'face'
																			gs 'zz_funcs', 'cum', 'anus'
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event11/38.jpg','\\\- Нормально, девчат? Вы в порядке?///- заботливо интересуется Руслан.**\\\- Вау, суперчётко оторвались!///- осоловело говорит Аня.**\\\- Т- только ч-чота я все ещё никакая малость, как в космосе,///- добавляет шепотом она вам на ушко,\\\- и опять хочу, аж стыдно после такого...///**\\\- Пора нам, родаки накрутят!///- вспоминаете вы одновременно с Колей и смеетесь.**Миша вызывает такси и доставляет вас троих до самого подъезда.**\\\- А еще мы так оторвёмся?///- интересуется Аня, прощаясь. С ее лица не сходит блаженно-блудливая улыбка.**\\\- Да почему нет, устроим!///**Вы возвращаетесь в квартиру, удивляясь, что уже вечер.'
																			act'Зайти в квартиру': gt 'korrPar'
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
if $args[0] = 'incest_mini1':
	*clr & cla
	minut += 10
	horny += 10
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/mini/'+rand(1,7)+'.jpg','Вы подходите к своей комнате и слышите доносящиеся оттуда стоны. Приоткрыв дверь, вы обнаруживаете как Аня развлекается с Михаилом. Немного подумав, вы решаете оставить их кувыркаться дальше и идете по своим делам.'
	act'Уйти': gt 'korrPar'
end
if $args[0] = 'incest_mini2':
	*clr & cla
	minut += 10
	horny += 15
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/incest/mini/'+rand(8,13)+'.jpg','Вы подходите к своей комнате и слышите доносящиеся оттуда стоны. Приоткрыв дверь, вы обнаруживаете как Аня развлекается с Мишей и Колькой. Слегка огорчившись, что они вас не позвали, вы, показав троице язык и крутанув задом, уходите, отправляясь по своим делам.'
	act'Уйти': gt 'korrPar'
end
if $args[0] = 'incest_dialog1':
	*clr & cla
	minut += 10
	$npc['38,wedding'] = 2
	anya_event['init_relocation_day'] = daystart + 90
	gs 'stat'
	gs 'zz_render', '', '','\\- Ну как тебе вечеринка, сестрёнка?//**\\\- Ох, да мне на такие лучше не соваться, а то я там на всех подряд лезу, если бы не ты, то меня точно кто-нибудь из Мишкиных друзей в туалете оприходывал. Еще раз спасибо тебе, Светик.///**\\- Ну, мне бы хотелось бы, чтоб у тебя в жизни всё получилось...//- обнимая сестру, сказали вы.**\\\- Я тебя тоже порадую, Светик! В общем, мы с Мишей тут все серьёзно обсудили... Мы будем встречаться как настоящая пара! Он даже меня к себе жить позвал, представляешь? Я пока отказала, думаю, что рановато еще…///**\\- Эхх, как же я без вас буду - с одним только Колькой!//- смеясь, сказали вы.**\\\- И это мы с ним тоже обсудили. Решили так: с вами двумя мы можем делать что хотим оба! Но с другими - ни-ни! И к тебе просьба моя личная еще: сестрёнка, по возможности, удерживай меня от необдуманных поступков…///**\\- Не то что бы я не рада такой новости... Но как-то странно это для влюбленной парочки, не находишь?//- продолжая давиться смехом спросили вы Аню.**\\\- А у нас вообще семейка странная! Скажу тебе по секрету: это я была инициатором той самой договоренности - уж больно мне в обе дырочки понравилось,///- прошептала вам Аня на ухо.**Вы поцеловали и обняли сестренку, сказав\\- Надеюсь, у вас все получится!//'
	act 'Отойти': gt $loc, $metka
end
if $args[0] = 'incest_dialog2':
	*clr & cla
	minut += 10
	$npc['38,anayslut'] = 2
	gs 'stat'
	gs 'zz_render', '', '','\\- Ну как тебе вечеринка, сестрёнка?//**\\\- Мне Мишичка звонил…///- всхлипывая, рассказывает Аня,\\\- он... он… не будет со мной больше встреча-а-аться….///**\\- Вот блин, это чо, из-за той классной групповушки у Руслана?//**\\\- Да…. вот я дура, такого парня упустила, а все из-за бухла-а!///**\\- Поздно теперь уже виниться да горевать, лучше подумай о том, какую выгоду из этого извлечь можно!//**\\\- Ну и какую же?///- заинтересовывается Аня, прекратив разводить сопли.**\\- Теперь у нас есть целая толпа парней, которые не прочь удовлетворить все наши фантазии!//**\\\- Вот вы с Мишкой одного поля ягодки! И он сказал примерно то же…///**\\- Ты же сама говорила…,//- вы не успели закончить, как сестра вас оборвала.**\\\- Света! Он так мне выдал: “Анёк, я с друзьями по выходным можем вас с сестрой оттрахать как угодно, но кроме этого - больше ничего!”///**\\- Ну и радуйся, глупышка, может кого из их компашки подцепишь да и удовольствие получишь!//**\\\- Ох, Свет, наверно, ты права! Не стоит грустить из-за парня, которого я знаю совсем недавно!///- наконец, улыбнулась Аня.**Вы поцеловали и обняли сестренку, сказав:\\- Надеюсь, у тебя все получится!//'
	act 'Отойти': gt $loc, $metka
end
if $args[0] = 'incest_dialog3':
	*clr & cla
	minut += 10
	$npc['38,wedding'] = 3
	gs 'stat'
	gs 'zz_render', '', '','\\\- Ой, Светка, чо скажу! МЫ! С МИШКОЙ! СЪЕЗЖАЕМСЯ!///**\\- Круто! Вот это новость! Ну чо, поздравляю,//- вы обняли сестру, которая вся прямо-таки лучилась от счастья.'
	act'Отойти': gt $loc, $metka
end
if $args[0] = 'incest_event12sub':
	if $npc['38,wedding'] = 2:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '','У вас звонит телефон:\\\- Светик, привет, это Мишка! Слушай, сегодня такой день отличный, не хотите в бассейне покупаться?///**\\- Ох, я б точно не отказалась! Подожди секунду, у Ани спрошу!//**\\\- И Коляна прихватите!///**\\- Да оба поедут, а куда только ехать-то?//**\\\- Никуда, я у вашего подъезда жду в такси, спускайтесь быстрее.///'
		act'Ехать': gt 'sisterQW','incest_event12'
	elseif $npc['38,wedding'] > 2:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', '','У вас звонит телефон:\\\- Светик, привет, это Мишка! Слушай, сегодня такой день отличный, не хотите в бассейне покупаться?///**\\- Ох, я б точно не отказалась! Подожди секунду, у Коли спрошу!//**\\\- Купальники не забудьте!///**\\- Ага, Колька готов, тоже поедет, а куда только ехать-то?//**\\\- Никуда, мы у вашего подъезда ждем в такси, спускайтесь.///'
		act'Ехать': gt 'sisterQW','incest_event12'
	end
end
if $args[0] = 'incest_event12':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '','Схватив купальники, вы уже через пару минут спустились к такси. По дороге Миша рассказал, что вы направляетесь в коттедж, к его знакомому. Минут через двадцать вы прибыли на место. Поздоровавшись с хозяином, которого Миша коротко представил Дмитрием, вы втроем помчались переодеваться, а Мишка остался что-то обсудить с Димой.'
	act'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event12/01.webm','Обустроившись в бассейне, вы принялись всячески дурачиться. Мишка и Аня о чем-то болтали в сторонке, но и одного взгляда на парочку было достаточно, чтобы понять о чем разговор. Затем стали размышлять, что бы такое учудить для пущего веселья.'
		act'Просто хорошо провести время':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event12/02.webm','Вы купались и прозагорали весь день напролет. Потом отправились домой.'
			act'Зайти в квартиру' : gt 'korrPar','start'
		end
		act'Соблазнить Диму':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event12/02.jpg','Убедившись что хозяин коттеджа смотрит на вас, причем с явной заинтересованностью, вы отодвинули свои зачаточного вида купальные трусики и раздвинули половые губки пальцами. Затем вернули все на место и легли на бочок как будто ничего и не было.'
			act'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event12/03.jpg','\\- Дим, хочешь попробовать как в этой щелочке? Те-е-е-епло-о!//- распутно улыбаясь, спросили вы.**\\\- Света, ха-ха, что ты делаешь, мы же тут не одни!///**\\- А мне нравится, когда не одни! И не один,//- вы залихватски подмигнули парню,\\- Да и остальные, я думаю, не против! Правда же?//'
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event12/04.jpg','Первым откликнулся Колька:**\\\- Я всегда за!///**Вы обернулись и посмотрели на сладкую парочку, услышав краем уха как Аня шепчет: ”Миш, ну давай, пожалуйста, я только с тобой буду, если хочешь!”**”Ладно-ладно, если уж развлекаться, то по полной!”**\\\- Мы тоже не против,///- обернувшись, сказал Миша.**\\\- Я даже не знаю,///- замялся Дима.'
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(5,6)+'.webm','Без лишних слов, вы стянули с Ромки шорты и начали работать над его уже изрядно возбудившимся инструментом. Колька стал поигрывать с вашей попкой, а Аня занялась подготовкой Мишкиного агрегата.**\\\- Света... ты... это ну...///- пытался по началу остановить намечающуюся оргию Дима, но увидев, что все уже завертелось, только пожал плечами.**\\- Коль, я тут Димой вплотную займусь, а ты пока к Ане иди, пусть она с тобой поиграет,//- на секунду выпустив член изо рта, сказали вы.'
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(7,10)+'.webm','Аня начала по очереди обрабатывать инструменты парней, а вы сосредоточились на Диме.**\\\- Мальчики, возьмите меня уже,///- первой не выдержала Аня.**\\\- Я первый!///- выкрикнул Колька**Вы оставили агрегат Димы, затем оголив грудь прижались и поцеловали его, шепча на ушко:\\- А ты меня хочешь?//Ответ последовал незамедлительно:\\\- Как устоять перед такой горячей штучкой!///'
							act'Далее':
								*clr & cla
								minut += 5
								horny += 15
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(11,13)+'.webm','Вы сдвинули бикини и насадились своей норкой на внушительных размеров член Димы, Аня последовала вашему примеру и, обнажив свои прелести, оседлала брата. Миша избавился от лишней одежды и оккупировал ее ротик.**\\- Один хорошо, а два лучше,//- захихикали вы,\\- давайте теперь обменяемся партнерами!//**\\\- Дима, идите теперь ко мне!///- возбужденно позвала Аня.'
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(14,16)+'.webm','Николай уже попробовал сегодня киску сестры, так что вашу он уступил Михаилу, а сам пристроился у вашего ротика. Дима же подошел к Ане и начал нерешительно входить в ее норку. Она тут же взяла его агрегат рукой и перенаправила себе в попку, при этом сама насаживаясь на него поглубже.**\\\- Дима! Не стесняйся вгоняй до упора!///- эти слова взбодрили парня и он принялся действовать увереннее.**\\\- Ох да, вот так!///- застонала Аня.'
									act'Далее':
										*clr & cla
										minut += 5
										horny += 25
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(17,18)+'.webm','Миша сменил отверстие и начал засаживать вам в попку, Аня повизгивала неподалеку - видимо, Димитрий вошел во вкус.**\\\- Миша, иди ко мне, я хочу тебя!///- спрыгнув с Димкиного агрегата и обняв трахающего вас парня, сказала она.**\\\- Дима, а ты иди ко мне!///- пытаясь не отставать от сестры, сказали вы.**\\- Пока эта парочка развлекается вы с Колькой займетесь моими дырочками,//- вы уложили полностью отдавшегося вашей воле Дмитрия на удобный столик рядом.'
										act'Далее':
											*clr & cla
											minut += 5
											horny = 95
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(19,24)+'.webm','Оседлав Диму, вы тут же ощутили Колькин елдачок в своей второй дырочке и начали сами ерзать бедрами, давая понять Диме, что готовы и не испытываете неудобств. Миша положил вашу сестру на бок и раздвинул ей ножки входя в ее писечку так, чтобы всем было прекрасно видно чем они заняты.**\\- Мальчики, ну же вгоняйте поглубже!//- застонали вы.**\\\- Ах, божечки, я сейчас…ааа!///- Аня застонала от накатившего оргазма.'
											act'Далее':
												*clr & cla
												minut += 5
												orgasm += 1
												DPorgasm += 1
												horny = 0
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(25,27)+'.webm','Давая Ане передохнуть, Миша переключился на вас. Вы развернулись и насадили свою попку на инструмент Димы, Миша пристроился к вашей норке. Аня тем временем не давала заскучать братишке, посасывая его елдак.**\\- Да-да, вот так//- завопили вы, приближаясь к пику\\- Не останавливайтесь!//**\\- Анюта, а ты двушечку хочешь?//- продолжая жарить вас, спросил Мишка.\\\- Конечно! Мои дырочки уже заскучали от одиночества,///- пошутила Аня.'
												act'Далее':
													*clr & cla
													minut += 5
													horny += 25
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(28,33)+'.webm','Миша улегся на стол и посадил вашу сестренку на себя. Дима снова замешкался и вам пришлось самой засовывать его инструмент в Анину попку. Затем вы повернулись задиком перед братом и призывно поставили одну ножку на стол, сказав только одно слово:**\\- В киску!//- Колю не нужно было долго просить и вы тут же почувствовали внутри себя его орган.**\\\- Я уже готов кончить,///- сдавленно простонал Дмитрий.\\\- Нет-нет, я еще хочу!///- тут же завопила Анюта.'
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(34,38)+'.webm','Миша, воспользовавшись моментом, перевернул вашу сестренку и вошел в ее попку. Освободившееся место тут же занял Колька. Вам ничего не оставалось как заняться Димой, поддерживая его возбуждение, но не давая кончить раньше времени.**\\\- Ох, бли-ин, я снова конча-а-аюююю!///- завопила Аня под мощными толчками ребят.**\\\- Анька, подставляй ротик, я тоже уже готов,///- сказал Колян.'
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event12/39.webm','Ребята устроились рядом с вами и Аня начала доводить парней до эякуляции, вы же стали усердно работать с Димой.**\\- Дима, давай мне прямо в ротик!//- отрывая его пошире и высунув язычок, попросили вы.'
															act'Далее':
																*clr & cla
																minut += 5
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(40,41)+'.webm','Дима обильно кончил вам в ротик. Излишки семени медленно стекали по вашему подбородку, но большую часть вы все же успели проглотить.**\\- Вкусное завершение нашей встречи!//- хихикая, произнесли вы.'
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(42,43)+'.webm','Парни дружно спустили в ротик вашей сестренке - большую часть горячего молочка она, правда, пролила, но, как бы извиняясь, смачно обсосала оба инструмента.**\\\- Ну что, Анюта, довольна?///- осведомился Михаил.**\\\- Очень, спасибо тебе, милый, за такой замечательный отдых!///'
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event12/'+rand(44,45)+'.webm','Парни отошли в сторонку и стали что-то обсуждать, вы с сестрой принялись целоватся, слизывая друг с друга остатки семени.**\\- Классно отдохнули!//- прошептали вы на ушко сестре.**\\\- Да отлично!///- сказала Аня, и тихо добавила\\\- Что может быть лучше сразу двух горячих елдаков, двигающихся внутри тебя!?///**Вы рассмеялись и шемпнули:\\- Только три!//'
																		if $npc['38,qwpool'] = 1:
																			act'Далее':
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event12/41.jpg','Вы с сестрой повернулись к разговаривающим парням и громко спросили:**\\- Дима, ну как, тебе понравилось?//**\\\- Да, девочки, было здорово,///- несколько смущенно ответил он.**Вы еще какое-то время купались и загорали, уже полностью голые, а потом Миша вызвал такси и вы поехали домой.'
																				act'Зайти в квартиру' : gt 'korrPar','start'
																			end
																		else
																			act'Далее':
																				*clr & cla
																				minut += 5
																				gs 'stat'
																				gs 'zz_render', '', 'pavlovo/family/incest/event12/41.jpg','Вы с сестрой повернулись к разговаривающим парням и громко спросили:**\\- Дима, ну как, тебе понравилось?//**\\\- Да, девочки, было здорово,///- несколько смущенно ответил он.**Вы еще какое-то время купались и загорали, уже полностью голые, а потом Миша вызвал такси и вы поехали домой.'
																				act'Далее':
																					*clr & cla
																					minut += 5
																					$npc['38,qwpool'] = 1
																					gs 'stat'
																					gs 'zz_render', '', 'pavlovo/family/incest/event12/42.jpg',' По дороге домой Миша начал рассказывать вам про Дмитрия:**\\\- Девчата, скажу вам по секрету: Димка-то еще тот бабник, вот только любит он притворяться невинной овечкой!///**\\- А я сразу догадалась! Он по началу делает вид, что совсем не в курсе что делать, а как войдет в тебя, так сразу чувствуешь - опытный парень!//- в подробностях стали расписывать вы.**\\\- В общем, просьба у меня к вам: если опять поедем к нему, уж вы подыграйте! Парень-то он классный, хоть и немного странный,///- рассмеялся Мишка.**\\\- А мне это даже понравилось,///- добавила Аня.'
																					act'Зайти в квартиру' : gt 'korrPar','start'
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
if $args[0] = 'incest_event14':
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render', '', '','У вас звонит телефон:\\\- Светик, привет! У нас сегодня корпоративный банкет намечается. Все с женами да подругами будут, а мне некого взять, может, выручишь?///**\\- А ты на мне жениться, что ли, хочешь, хи-хи-хи?!//**\\\- Ну, типа того, но, буквально, на один день!///**\\- Ой, здорово как! Почувствую себя мужней жёнушкой! Во сколько заедешь?//**\\\- Через часик успеешь?///**\\- Да, буду готова.//'
	act'Далее':
		*clr & cla
		minut += 60
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/incest/event14/01.jpg','Миша, как обычно, заехал за вами на такси и вы уже по знакомому маршруту отправились в Энск.**\\\- Свет, если ты не против, я тебя всем представлю как свою невесту,///- начал разговор Михаил.**\\- Ой, не против, конечно, а ребят с прошлой вечеринки не будет? А то даже как то неловко...//**\\\- Нет, они не с работы, так, друзья,///- ответил Михаил.'
		act'Далее':
			*clr & cla
			minut += 120
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/incest/event14/02.jpg','Когда вы приехали, банкет был уже в разгаре. Народ вовсю веселился и распивал шампанское. Вы быстро включились в веселье. Пили вы немного, больше общались с коллегами Михаила, усердно играя роль невесты.**\\- Миша, может быть, поедем уже домой я что-то так устала... никогда столько не сплетничала!//- прошептали вы на ухо парню.**\\\- Пожалуй, поехали, я и сам не в восторге от этих корпоративов. Но чтоб повышение получить - приходится посещать, как насчёт заехать ко мне, у меня там бутылочка хорошего вина имеется?///**\\- Давай! Отметим наше грядущее “расставание”!//'
			act'Далее':
				*clr & cla
				minut += 60
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/incest/event14/03.jpg','Миша вызвал такси и вы поехали к нему.**\\- Ого, а у тебя шикарная квартира!//- зайдя внутрь и осмотревшись, сказали вы.**\\\- Ага, недавно ремонт сделал. Ты тут пока осваивайся, чувствуй себя как дома, а я вино принесу или может еще что то будешь?///'
				act'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/incest/event14/04.jpg','\\- Буду тебя!//- решительно заявили вы, поднимая платье и показывая Мише свою попку - нижнее белье вы принципиально не надели.**\\\- Ух! Светуля ты так и ходила без трусиков на корпоратив?///*\\- Конечно! Я надеялась, что ты меня прямо там! Но, увы, момент так и не представился.//'
					act'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/incest/event14/05.jpg','Миша подошел к вам обнял за талию и начал целовать вашу шею:**\\\- Света, ты не перестаешь меня удивлять.///**\\- Я как с тобой познакомилась - сама себя не узнаю!//- расстегивая Мишину ширинку, сказали вы.'
						act'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event14/06.jpg','Вы достали его агрегат начали его обрабатывать ротиком:**\\\- Завела ты меня, негодница!///'
							act'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event14/07.jpg','Парень схватил и поднял вас на руки, буквально насаживая вашу киску на свой член. Вы сладко вскрикнули, а затем стали страстно его целовать.**\\- Кажется, это первый раз когда мы с тобой только вдвоем,//- прошептали вы, отрываясь от его губ.**\\\- И правда!///- подтвердил Михаил, ставя вас на пол.'
								act'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/incest/event14/08.jpg','Оказавшись на полу, вы сразу повернули к Мише свой задок.**\\- В попку давай!//- приказным тоном заявили вы.**\\\- Как пожелаете, моя королева!///- проникая в ваш задний проход, откликнулся Миша.**\\- Раз я королева, тогда и трахни меня по королевски!//'
									act'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/family/incest/event14/09.jpg','Миша снял с вас платье и пристроил на диванчике:**\\- Аааа!!! Божечки!!! Не так глубоко! Мы же без смазки!//- завопили вы, когда Мишка стал вгонять свой член вам в попку по самые яйца.**\\\- Терпи, сама хотела!///- ехидно сказал Мишка.**Вы довольно быстро перестали чувствовать неудобство и начали получать кайф от мощных толчков Михаила, о чем ярко свидетельствовала ваша текущая киска.'
										act'Далее':
											*clr & cla
											minut += 5
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/family/incest/event14/10.jpg','Вы сменили позу: теперь Миша лежал на диване, а вы практически устроились на нем. Он развел ваши ноги в разные стороны и начал быстро двигаться внутри вас.**\\- Кончаю, вставляй по глубже!//- завопили вы и пальчиками раскрыли свою сочащуюся киску.**\\- А-ах, ну же, еще, еще!!//- уже оргазмируя, простонали вы.'
											act'Далее':
												*clr & cla
												minut += 5
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/family/incest/event14/11.jpg','Неожиданно для вас из вашей писечки брызнула мощная струя.**\\- Миша, Миша-а, постой!//- задыхаясь, застонали вы, пытаясь слезть с его кола.**\\\- Уже нагрязнили, поздно останавливаться,///- пожал плечами парень,\\\- да и прикольно...///**\\- Ох, прости, у меня раньше такого не было!//- не успели вы закончить фразу как из вашей писечки вырвалась очередная струя.'
												act'Далее':
													*clr & cla
													minut += 5
													gs 'stat'
													gs 'zz_render', '', 'pavlovo/family/incest/event14/12.jpg','Когда ваше тело наконец перестало извергать жидкости, а вы еле удерживались на Мишкином теле, он ухватил вас за бедра и медленно стал двигатся:**\\\- Светка ты там как? Живая?///**\\- Н-не з-знаю,//- заплетающимся языком пролепетали вы.**\\\- Давай тогда я тебе в ротик спущу!///'
													act'Далее':
														*clr & cla
														minut += 5
														gs 'stat'
														gs 'zz_render', '', 'pavlovo/family/incest/event14/13.jpg','Вы передвигаясь словно сомнабула, сползли с члена и встали на колени, открыв рот. Миша сам довел себя до эякуляции и кончил в ваш раскрытый ротик.**\\\- Ну ты даешь, Светуля, у меня девки так еще не кончали///- покачал головой Михаил.**\\- Миш, дико извиняюсь, не знаю, что нашло! Я все тут уберу...//- вы начали приходить в себя и отбалтываться.'
														act'Далее':
															*clr & cla
															minut += 5
															gs 'stat'
															gs 'zz_render', '', 'pavlovo/family/incest/event14/14.jpg','Усевшись на попу рядом со стоящим парнем, вы осмотрелись вокруг, оценивая объем предстоящей вам работы:**\\- Надеюсь у тебя есть чистящее средство.//**\\\- Ээ, найдется, наверно,//- неуверенно пробормотал Миша, потом хмыкнул,\\\- да ты так, Светка, не переживай, я уборщицу вызову.///**\\- Не-не-не, сама затопила, сама и убирать буду,//- мотая головой, настояли вы.'
															act'Далее':
																*clr & cla
																minut += 30
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event14/15.jpg','Встав, вы по хозяйски пошли в ванную и стали искать там все, что вам понадобится для уборки, при этом даже не думая одеться.**\\\- Светик, ты так и будешь голышем тут убираться? Трусики натянула бы, что ли.///**\\- Я без трусиков сегодня, забыл? Кто же знал что мне убираться придется, я бы тогда горничной нарядилась!//- принимаясь за работу, ответили вы.**Миша не в силах выдержать вид ваших прелестей, мелькающих перед его глазами, ушел на кухню, а вы полчаса приводили комнату в надлежащий вид.'
																act'Далее':
																	*clr & cla
																	minut += 5
																	gs 'stat'
																	gs 'zz_render', '', 'pavlovo/family/incest/event14/16.jpg','Закончив уборку, вы, с довольным видом, уселись на диван и позвали Мишку, который все это время был на кухне.**\\- Миш, я закончила иди посмотри!//- громко позвали вы и раздвинули ножки.**\\\- Ого!///- зайдя в комнату воскликнул Мишка, уставившись на вашу промежность, но потом все же взял себя в руки и осмотрел комнату.**\\- Нравится?//- поглаживая свое обнаженная тело, спросили вы.**\\\- Убралась ты замечательно! Может ты у меня постоянно уборку делать будешь?///**\\- Уборку…//- задумчиво повторили вы, прекращая поглаживать себя.\\- Хорошо, но ты мне будешь должен!//'
																	act'Далее':
																		*clr & cla
																		minut += 5
																		gs 'stat'
																		gs 'zz_render', '', 'pavlovo/family/incest/event14/17.jpg','\\\- Да без проблем! Слушай, давай я тебе ключи дам. Сам-то я до четырех на работе, а ты приходи в любое время. И Колю можешь приводить: у меня тут куча игр валяется,///- показывая на огромную полку забитую дисками, предложил Михаил.**\\\- Если хочешь, я тебе даже платить могу,///- добавил он.**\\- Я с тебя оплату другим способом возьму!//- засмеялись вы.**\\\- Ну окей, наше дело - предложить... Может, в душ тогда?///**\\-	Ага, пойдём вместе!//'
																		act'Далее':
																			*clr & cla
																			minut += 20
																			$npc['38,incest_event14'] = 1
																			gs 'stat'
																			gs 'zz_render', '', 'pavlovo/family/incest/event14/18.jpg','Приняв душ, вы вернулись вернулись в комнату и оделись: вам было пора возвращаться домой.**\\- Миш, мне пора, еще раз спасибо за отлично проведенный день!//**\\\- Увидимся, Светик,///- парень вручил ключи от квартиры и попрощался.'
																			act'Уйти': gt 'gorodok'
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