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
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/sisboyQW_10.jpg', func('sisterQW_strings', 'local_str8')
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
		if GorSlut < 2 and mesec <= 0 and manna >= 60 and alko < 3 and (cumfrot + cumlip + cumface) = 0:
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
		elseif GorSlut >= 2:
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
		if GorSlut < 2 and mesec <= 0 and manna >= 60 and alko < 3 and (cumfrot + cumlip + cumface) = 0:
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
		elseif GorSlut >= 2:
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
	if  week = 5 and hour = 16 and sisboyparty = 2:
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
																						gs 'zz_render', '', 'pavlovo/family/incest/event1/26.jpg','\\\- Колька, паразит, ты что ли?!///- с изумлением воскликнула Аня, подходя поближе.**\\- Аня,  успокойся, мы тебе все объясним,// - неуверенно  пролепетали вы.**\\\- Успокоится?! Вы что, в конец ебанулись?! Если родители слышали твой вопль - они же тебя из дома выкинут.///**\\- Если бы слышали - уже были тут. Колька, вали к себе, я тут сама все улажу.//**Колька быстро натянул штаны и выбежал из комнаты'
																						act'Далее':
																							*clr & cla
																							minut += 1
																							gs 'stat'
																							gs 'zz_render', '', 'pavlovo/family/incest/event1/27.jpg','Аня, кипя от злости, проводила Кольку взглядом и села рядом с вами.**\\\- Света, он же наш брат, как ты вообще до такого додумалась?/// - с гневом произнесла Аня.**\\- Ну отцы-то у нас разные… Все само как-то получилось… Да и в кровати он весьма хорош, попробовав однажды удержаться очень трудно… Я прошу только родителям не рассказывай!!!//**\\\- Я что, дура что ли, мне за такое наверняка тоже достанется! Но я все равно не понимаю тебя, что школьных парней мало, зачем ты с братом спать начала?///**\\- Ну ты же понимаешь, что я не могу привести парня домой: родители увидят - убьют, а Колька он всегда тут: трахнул по-быстренькому  и никто ничего не заметит. К тому же  ты не шибко возражала когда мы с тобой развлекались!//**\\\- Света, там совсем другое!!///**\\- Значит, по-твоему с родной сестрой трахатся нормально, а со сводным братом нет?// - возмущаясь спросили вы.**\\\- Ну… ладно… но все равно оно как то  неправильно, да и подумай что будет если родители узнают…///**\\- Анька, поверь награда оправдывает любой риск!!!//**Аня покраснела, видимо, представляя себя на вашем месте.**\\\- Света, будь осторожнее родители узнаю мне тоже достанется, а теперь пора спать. Надеюсь, нам больше не придется такое обсуждать… Блин, из-за вас придурков только возбудилась!///**\\- Ооо, вот это правильно,// - рассмеялись вы, полностью отойдя от испуга.**<b>Надо бы утром пока родители спят с Колей переговорить</b>- подумали вы и легли спать'
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
																					gs 'zz_render', '', 'pavlovo/family/incest/event1/20.jpg','Взяв себя в руки, вы слегка притормозили и сменили позу, давая отдохнуть своей заднице.**\\- Ух, пронесло…// - прошептали вы.**\\\- Света, ты чуть нас не спалила!///**\\-  Прости, Коль, потеряла над собой контроль.//'
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
				gs 'zz_render', '', 'pavlovo/family/incest/event2/04.jpg','\\\- Светик, Светик, прости, ты не так всё поняла… Мишка сказал, что ты ни за что с ним трахаться не будешь, а я решил с ним на деньги поспорить, потом уговорить тебя, а на выйгрошь купить Ане подарок, чтобы ее задобрить…///**\\- И на сколько поспорил?//  - все еще злясь спросили вы**\\\-На 10000 рублей...///'
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
													gs 'zz_render', '', 'pavlovo/family/incest/event2/13.jpg','Вы снова начали вопить как в прошлый раз, Колька  не долго думая перевернул вас на бок.**\\\- Света прикуси одеяло не то родителей разбудишь своими визгами!///**\\- Ахх… хорошо..  тока еби меня, неостонавливайся!// - и прикусили одеяло.'
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
															gs 'zz_render', '', 'pavlovo/family/incest/event2/15.jpg','Колька смачно обкончал ваше личико при этом попав и  в слегка приоткрытый ротик. Вы явно были довольны таким началом дня.'
															act'Далее':
																*clr & cla
																minut += 1
																$npc['38,qwKolka'] = 2
																gs 'zz_funcs', 'cum', 'face'
																gs 'stat'
																gs 'zz_render', '', 'pavlovo/family/incest/event2/16.jpg','Затем облизав сперму около рта вы уселись поэротичнее и начала рассказывать, что вы хочете от Кольки:**\\- Слушай я тут подумала ночью наверно нам стоит  убедить Аню присоединится к нашим забавам.//**\\\-Света ты что хочешь что бы я Аньку трахнул?///**\\- А что девка она симпатичная небойсь сам не раз об этом мечтал!//**\\\- Ну …/// - Колька слегка опешил.**\\- Да не ломайся, я ее подготовлю.//**\\\- Ладно, но сначало тебе надо решить проблему с Мишкой он долго ждать не будет.///**\\- Я сама к нему не пойду! Пусть к нам приходит когда родителей дома не будет.//**\\\- Блин Света и что мне ему сказать”Приходи к нам Света тебя хочет трахнуть?”///**\\- Ты главное его к нам приведи под любым предлогом, а дальше я сама разберусь.//**\\\- Ладно я его в Хbox поиграть позову.///**\\- Ну вот и молодец!// - с этими словами вы встали подняли трусики затем выглянули за дверь и огляделись думая при этом, что надо будет <b>заглянуть в зал часа в 4 может колька приведет друга..</b>'
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
																gs 'zz_render', '', 'pavlovo/family/incest/event3/16.jpg','Секунд через десять Миша остановился и дал вам слезть. Вы кое-как отдышались и неожиданно ощутили что возбуждение после оргазма никуда не пропало.**\\\- Ну как Светик хочется добавки не так ли?/// -  широко улыбаясь сказал Мишка.**\\- Ещё сильнее чем прежде! Что ты со мной сделал, негодник?// - изумились вы.  Улегшись на стол, вы ухватили Колькин член, а Миша в этот раз решил начать второй подход к вашей норке.'
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
																					gs 'zz_render', '', 'pavlovo/family/incest/event3/21.jpg','Через несколько секунд вы почувствовали горячую спермы у себя во рту.**\\\- Ай да Светик!  Хороша почти как моя бывшая!///**\\- Ну не наглец ли?// - возмутились вы полушутя:\\- Нет бы сказал: “Лучше моей бывшей!”//**\\\- Светуль, до моей бывшей тебе ещё попрактиковаться надо малость. Хочешь - могу дать пару уроков?/// - ухмыльнулся Миша.'
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
					gs 'zz_render', '', 'pavlovo/family/incest/event3sub/05.jpg','Колька улыбнулся и начал гладить ваше обнаженное тело, а Миша  расстегнул ваши джинсы и запустил свою руку вам в трусики вы почувствовали как его рука стала гладить ваш лобок, горячая волна возбуждения прокатилась по вашему телу.**\\- Ну, раз вся команда в сборе, то пожалуй пора начинать нашу игру,// - кокетливым голосом воскликнули вы.'
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
									gs 'zz_render', '', 'pavlovo/family/incest/event3sub/'+rand(12,13)+'.jpg','Вы, оторвавшись от членов ребят, сказали:**\\- Коля там не болтать надо, а работать,// - вы легли на диван и призывно раздвинули ноги,\\- А раз хочешь туда попасть начинай тренироваться прямо сейчас, на мне!//**\\\- Да это мы запросто/// - Колька вогнал  свой инструмент в вашу киску и начал в ней двигаться.**\\\- Светик, а моим-то красавчиком забыла заняться?/// - ухмыльнулся Мишка.**\\- Ой, прости! Действительно забыла!// - улыбнулись вы и начала работать с Мишкиным агрегатом ротиком и ручками.'
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
										act'Пойти спать': gt  'kuhrPar'
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
		gs 'zz_render', '', 'pavlovo/family/incest/event5/02.jpg','Положив кашу по тарелкам, вы уселись завтракать:**\\- Коля, я как раз после завтрака хотела к тебе зайти, сообщить новость.//**\\\- Какую еще?/// -  с недоумением посмотрел на вас Коля**\\- Ну как же: ты, я, Аня! Забыл, что ли? Ну так вот: она согласна! Вроде как. Если ты сам не лоханешься. Так, что заходи к нам вечерком!//**\\\- Вот это новость! Не ожидал, что Анька на такое пойдет!///'
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
					gs 'zz_render', '', 'pavlovo/family/incest/event5/04.jpg','\\- Коль, нам обоим собираться надо, а после этого мне опять в душ идти, я тогда точно опоздаю…//**\\\- Ну ладно, тогда в другой раз…,/// -  с сожалением произнес Колька.'
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
																				gs 'zz_render', '', 'pavlovo/family/incest/event6sub/'+rand(27,31)+'.jpg','Вы  раскрыли ей промежность пошире и залюбовались как из сочного лона вытекает поток спермы. Затем вылизали капельки семени.'
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
						gs 'zz_render', '', 'pavlovo/family/incest/event8/06.jpg','Ощутив в своей попке оба инструмента, вы уже было приготовились терпеть неприятную боль, как вдруг поняли что ее нет, члены начали движение, а она так и не появилась.**\\- Все хорошо, можете продолжать,// - вы почувствовали как елдаки начали двигаться быстрее и быстрее, все глубже проникая в недра ануса.**Внутри вашей норки стало так горячо что невозможно было терпеть.**\\- Божечки! Мне в норку как будто залили кипяток!// - вы инстинктивно потянулись рукой к одиноко мокнущей писе и раздвинули пошире пальцами, будто это могло ее охладить.**\\\- Папань, похоже ей по кайфу, реально!/// - воскликнул Колька, любуясь на вашу норку.**\\- А-аххх, Д-ДААА!// - только и смогли вы пролепетать, прежде чем вас накрыло волной оргазма.**\\\- Смотри-ка, она еще и кончила от первой же двойки в попце, а ведь все отнекивалась,///  - снимая ваше почти обмякшее тело с членов и укладывая на диван, заметил невероятно довольный отчим.'
						act'Далее':
							*clr & cla
							minut += 5
							orgasm += 1
							DPorgasm += 1
							horny = 0
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/incest/event8/07.jpg','Видя, что вы уже приходите в себя, отчим строго покачал пальцем у вас перед носом.**\\\- Ну что, сама- то обкончалась как мартовская кошка, теперь семье помогай.///**\\- Хор-ро-ош-шо,// - с трудом промычали вы, еще не совсем оправившись от столь мощного оргазма. Обнаружив, что вы еще не способны на активные действия  отчим сунул свой инструмент вам в рот, а Колька примостился к заднице. Между тем вы потихоньку приходили в себя, начиная вести себя более активно.'
							act'Далее':
								*clr & cla
								minut += 5
								$loc = 'korrPar'
								gs 'zz_funcs', 'cum', 'face'
								gs 'zz_funcs', 'cum', 'belly'
								$npc['38,qwKolka'] = 8
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/incest/event8/05.jpg','Полностью оклемавшись, вы присели на корточки, а Коля и отчим по очереди кончили вам в рот. Первым тишину нарушил отчим, с ухмылкой разглядывая как сперма стекает по вашему подбородку на сисечки.**\\\- Похоже, все остались довольны, а?/// - спросил он.**\\- Я… Я… Мне понравилось,// - наконец определились вы.**\\\- Ну вот и замечательно! Можете не переживать, я прикрою вас перед матерью, но все равно будьте осторожнее!///**\\- Спасибо,// - выдавили из себя вы, а потом неожиданно добавили,\\- А может это... того... ну вы понимаете!//**\\\- Вообще-то нет,/// - покачал головой Колька.**\\- Коля! Дурак! Ну трахатся я хочу так почаще! Но только мне и другие варианты попробовать интересно…//**\\\- Какие варианты?/// - на этот раз недоумевающе спросил отчим.**Вы умоляющим взглядом посмотрели на него, в надежде, что вам не придется произносить ваши потаенные развратные желания вслух, но он по-прежнему недогонял.**\\- Ну что вы не понимаете что ли, после такого я хочу попробовать все! Секс с тремя, с четырьмя! Два члена в норке! И даже три в разных вариациях! Ой, я это сказала?!//**\\\- Ого, ну ты разошлась! Хотя... могу тебе гарантировать что мы с Николаем по выходным тебя может оприходывать...  в разных позах и вариациях, а дополнительных участников ищи сама.///**\\- Правда? Вы точно не против?// - с загоревшимися глазами спросили вы.**\\\- Да почему бы и нет! Можешь дружка вон своего подтянуть. Ну а пока бегом в душ - мыться, а то мать скоро вернется. Чтоб была без малейших следов! И лимон бы неплохо съесть, ха-ха.///**\\\- Ха-ха-ха,/// - заржал Колька.**“Это что, анекдот? Странный какой-то”, - подумали вы, собирая раскиданные шмотки.**Вы вышли из зала и направились в ванную думая про себя <b>теперь можно звонить Мишке в пятницу после 10 вечера, сделаю Ане сюрприз.</b>'
								act'Уйти': gt 'zz_bathroom','start'
							end
						end
					end
				end
			end
		end
	end
end