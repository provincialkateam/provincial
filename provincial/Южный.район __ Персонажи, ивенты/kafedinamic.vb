if $args[0] = 'gividin':
	*clr & cla
	if hour < 22:
		gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str1')
		if hour = 20 and $npc['34,relation'] >= 90:
			act 'Отпроситься у Гиви':
				cla
				minut += 5
				gs 'npc_editor','change_rep','-', 34
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str2')
				act 'Отойти': gt'street'
			end
		end
		if Kavslut > 0 and $npc['44,qwIrina'] >= 10 and $npc['44,qwIrinaSlut'] = 0 and hour <= 20:
			act 'Попросить у Гиви повысить зарплату Ире':
				cla
				$npc['44,qwIrinaSlut'] = 1
				minut += 30
				gs'stat'
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str3')
				act 'Отойти':gt'kafe','workPred'
			end
		end
		act 'Болтать с Гиви':
			cla
			if $npc['34,sex'] = 0:
				minut += 30
				manna += 5
				if $npc['34,relation'] <= 90: gs 'npc_editor','change_rep','+',34,15
				if $npc['34,relation'] > 90 and $npc['34,sex'] = 0: $npc['34,relation'] = 90
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str4')
				if $npc['34,relation'] = 90: gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str5')
				act 'Отойти':gt'kafe','workPred'
			elseif $npc['34,sex'] >= 1 and kavslut = 0:
				minut += 63
				manna += 5
				$npc['34,relation'] = 100
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str6')
				act 'Отойти':gt'kafe','workPred'
			elseif $npc['34,sex'] >= 1 and kavslut > 0:
				minut += 30
				manna -= 5
				$npc['34,relation'] = 100
				givirand = RAND(0,100)
				if givirand < 10 and Venera < 4:
					gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str7')
					act 'Встать на колени':
						*clr & cla
						smenaKafe += 1
						$npc['34,sex'] += 1
						bj += 1
						gs'npc_editor','init_sex',34
						dom -= 1
						gs 'stat'
						gs 'zz_render', '', 'images/picVA/barbj.jpg', func('kafedinamic_strings', 'local_str8')
						gs 'zz_dynamic_sex', 'bj'
						gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str9')
						act 'Продолжать сосать':
							*clr & cla
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							gs 'stat'
							gs 'zz_render', '', 'images/picV/swallow1.jpg', func('kafedinamic_strings', 'local_str10')
							act 'Отойти': gt'kafe','workPred'
						end
					end
					if $npc['34,sex'] = 1:
						act 'Сдурел что ли?':
							cla
							gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str11')
							act 'Отойти':gt'kafe','workPred'
						end
					end
				elseif givirand >= 10 or Venera >= 4:
					gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str12')
					act 'Отойти':gt'kafe','workPred'
				end
			end
		end
	else
		if vnesh < 20:
			gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str13')
			act 'Уйти':
				cla
				minut += 5
				gt 'kafe','kafeend'
			end
		else
			gt 'kafedinamic','givipredlogdin'
		end
	end
end
if $args[0] = 'ashotdin':
	*clr & cla
	gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str14')
	if hour < 22:
		act 'Есть и пить на кухне':
			cla
			gs 'zz_kitchen_acts', 'eat'
			gs 'zz_kitchen_acts', 'drink', 'tea'
			gs 'stat'
			act 'Отойти': gt 'kafe', 'workPred'
		end
		act 'Болтать с Ашотом':
			cla
			minut += 30
			manna += 5
			gs'stat'
			if Ashot <= 90: Ashot += RAND(0,5)
			if $npc['34,sex'] > 0 and Ashotsex = 0:
				if Ashot <= 90: Ashot = 90
				horny += 10
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str15')
				act 'Отойти':gt'kafe','workPred'
			elseif $npc['34,sex'] = 0 and Ashotsex = 0:
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str16')
				act 'Отойти':gt'kafe','workPred'
			elseif $npc['34,sex'] > 0 and Ashotsex > 0:
				if rand(0,100) > 20:
					horny += 10
					gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str17')
					act 'Отойти':gt'kafe','workPred'
				else
					*clr & cla
					gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str18')
					act 'Позволить':
						*clr & cla
						if analplugin = 1:
							*clr & cla
							analplugin = 0
							gs 'zz_render', '', 'images/picKav/analplug.jpg', func('kafedinamic_strings', 'local_str19')
							act 'Смутиться':
								*clr & cla
								gs 'zz_render', '', 'images/picKav/analkafe.jpg', func('kafedinamic_strings', 'local_str20')
								act 'Стонать':
									*clr & cla
									horny += 5
									anal += 1
									Ashotsex += 1
									gs 'zz_funcs', 'cum', 'anus'
									if anus < 18:anus += 1
									gs 'zz_render', '', 'images/picKav/kafeanpie.jpg', func('kafedinamic_strings', 'local_str21')
									if horny >= 100:
										horny = 1
										orgasm += 1
										analorgasm += 1
										gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str22')
									end
									gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str23')
									act 'Отойти':gt'kafe','workPred'
								end
							end
						else
							*clr & cla
							gs 'zz_render', '', 'images/picKav/analkafe.jpg', func('kafedinamic_strings', 'local_str24')
							act 'Стонать':
								*clr & cla
								horny += 5
								anal += 1
								Ashotsex += 1
								gs 'zz_funcs', 'cum', 'anus'
								if 18 > anus:anus += 1
								gs 'zz_render', '', 'images/picKav/kafeanpie.jpg', func('kafedinamic_strings', 'local_str25')
								if horny >= 100:
									horny = 1
									orgasm += 1
									analorgasm += 1
									gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str26')
								end
								gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str27')
								act 'Отойти':gt'kafe','workPred'
							end
						end
					end
				end
			elseif $npc['34,sex'] = 0 and Ashotsex > 0:
				horny += 10
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str28')
			end
		end
	elseg
		gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str29')
	end
	act 'Отойти':gt'kafe','workPred'
end
if $args[0] = 'iradin':
	*clr & cla
	gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str30')
	if hour < 22:
		act 'Болтать с Ириной':
			cla
			minut += 30
			manna += 5
			gs'stat'
			if $npc['44,relation']<= 100: gs 'npc_editor','change_rep','+', 44
			gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str31')
			if $npc['44,qwIrina'] ! 10 or IrinaLesbSex >= 3:
				if $npc['34,sex'] >= 1 and Kavslut = 0:
					gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str32')
				elseif Kavslut > 0:
					gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str33')
				end
			elseif $npc['44,qwIrina'] = 10 and IrinaLesbSex = 2:
				IrinaLesbSex = 3
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str34')
			elseif $npc['44,qwIrina'] = 10 and IrinaLesbSex = 1:
				IrinaLesbSex = 2
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str35')
			elseif $npc['44,qwIrina'] = 10 and IrinaLesbSex = 0:
				IrinaLesbSex = 1
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str36')
			end
			act 'Отойти':gt'kafe','workPred'
		end
	else
		if $npc['44,qwIrinaSlut'] >= 2:
			gt 'kafedinamic','givipredlogdin'
		elseif $npc['44,qwIrinaSlut'] < 2:
			act 'Идти домой с Ириной':
				cla
				$npc['44,relation'] += 5
				minut += 5
				gs'stat'
				if $npc['44,relation']< 100:
					if $npc['44,relation']< 50:
						if ($npc['34,sex'] >= 1 and Kavslut = 0) or Kavslut > 0:
							$irinatalk = 'По дороге она в основном молчит и косится на вас'
						else
							$irinatalk = 'Ирина в основном молчит всю дорогу.'
						end
						$irinaend = 'Около подъезда она сдержанно с вами прощается и идет к себе домой.'
					elseif $npc['44,relation']>= 50:
						if $npc['34,sex'] >= 1 and Kavslut = 0:
							$irinatalk = 'По дороге она в основном молчит, но набравшись храбрости начинает расспрашивать вас о ваших отношениях с Гиви.'
						elseif Kavslut > 0:
							$irinatalk = 'По дороге она в основном молчит, но набравшись храбрости начинает расспрашивать вас про похождения с хачами удивляясь как можно быть такой подстилкой как вы.'
						else
							$irinatalk = 'Ирина по дороге рассказывает о всяких пустяках.'
						end
						$irinaend = 'Около подъезда она машет вам рукой и идет к себе домой.'
					end
				elseif $npc['44,relation']>= 100 and $npc['44,qwIrina'] = 0:
					$npc['44,qwIrina'] = 1
					$irinatalk = 'Ира весело щебечет всю дорогу.'
					$irinaend = 'Она приглашает вас как-нибудь в Субботу зайти к ней в гости и идет в свой подъезд.'
				elseif $npc['44,relation']>= 100 and $npc['44,qwIrina'] = 1:
					if $npc['34,sex'] >= 1 and Kavslut = 0:
						$irinatalk = 'Ирина по дороге рассказывает о своих бывших бойфрендах.'
					elseif Kavslut > 0:
						$irinatalk = 'Ирина по дороге рассказывает о своих бывших бойфрендах. А так же про то как она однажды сделала минет в туалете клуба напившись с каким то парнем.'
					else
						$irinatalk = 'Ирина весело болтает всю дорогу о пустяках.'
					end
					$irinaend = 'Ира стоя у подъезда приглашает вас зайти к ней.'
					act 'Пойти в гости к Ире':gt'IrinaRoom','first'
				elseif $npc['44,relation']>= 100 and $npc['44,qwIrina'] = 2:
					$irinatalk = 'Ирина в основном молчит всю дорогу, но набравшись решимости говорит что '
					if $npc['34,sex'] >= 1 and Kavslut = 0:
						$irinatalk += 'не ожидала того что не ожидала от вас, того что вы не только с мужчинами спите, но и с женщинами. Стараясь быть вежливой она сообщает вам, что вообщем то она не против секс меньшинств, но ей вовсе не хочется спать с женщинами, они такие мягкие и противные, просто ужас.'
					elseif Kavslut > 0:
						$irinatalk += 'от такой шлюхи как вы можно конечно было всякого ожидать и что вы вообще без тормозов. Стараясь быть вежливой она сообщает вам, что вообщем-то не против секс меньшинств, но ей вовсе не хочется спать с женщинами, они такие мягкие и противные, просто ужас.'
					else
						$irinatalk += 'не ожидала того что такая приличная девушка как вы, на самом деле лесба. Стараясь быть вежливой она сообщает вам, что вообщем то она не против секс меньшинств, но ей вовсе не хочется спать с женщинами, они такие мягкие и противные, просто ужас.'
					end
					$irinaend = 'Подойдя к подъезду она прощается с вами и уходит.'
				elseif $npc['44,relation']>= 100 and $npc['44,qwIrina'] >= 10 and $npc['44,qwIrinaSlut'] >= 2:
					if Kavslut > 0:
						$irinatalk = 'Ира улыбаясь рассказывает что ей давно хотелось прекратить быть монашкой и жить свободно и она благодарит вас за вашу помощь..'
					end
					$irinaend = 'Стоя у дверей своего подъезда Ира приглашает вас зайти к ней в гости.'
					act 'Идти к Ире в гости': gt'IrinaRoom','first'
				elseif $npc['44,relation']>= 100 and $npc['44,qwIrina'] >= 10 and $npc['44,qwIrinaSlut'] < 2:
					$irinatalk = 'Ира улыбаясь удивляется тому что не ожидала от секса с женщиной такого удовольствия.'
					if Kavslut > 0: $irinatalk += 'Она замечает, что впрочем у вас опыт явно больше, уж Ира то никогда не спала с двумя мужиками сразу.'
					if Kavslut > 0 and $npc['44,qwIrinaSlut'] = 0: $irinatalk += 'Она так же просит замолвить перед Гиви за ней словечко, ей тоже хочется повышения зарплаты.'
					$irinaend = 'Стоя у дверей своего подъезда Ира приглашает вас зайти к ней в гости.'
					act 'Идти к Ире в гости': gt'IrinaRoom','first'
				end
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str37')
				act 'Попрощаться':gt'street'
			end
		end
	end
end
if $args[0] = 'tamdin':
	*clr & cla
	gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str38')
	if hour < 22:
		act 'Болтать с Тамарой':
			cla
			minut += 30
			manna += 5
			if Tamara <= 100:Tamara += RAND(0,5)
			gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str39')
			if $npc['34,sex'] >= 1 and Kavslut = 0:
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str40')
			elseif Kavslut > 0:
				gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str41')
			end
			act 'Отойти':gt'kafe','workPred'
		end
	else
		gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str42')
		act 'Идти домой с Тамарой':
			cla
			minut += 5
			gs 'zz_render', '', '', 'Вы идете с Тамарой по улице, '+iif(clener = 0,'Тамара вам говорит о том, что она иногда подрабатывает уборщицей в офисном здании неподалеку.','она живет неподалеку от вас, и дойдя до ее дома она останавливается попрощаться с вами.')
			if clener = 0: clener = 1
			act 'Попрощаться':gt'street'
		end
	end
end
if $args[0] = 'givipredlogdin':
	if $npc['44,qwIrinaSlut'] >= 2:
		gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str43')
		act 'Остаться с ними': gt'kavkazkafe','podgivi'
		act 'Идти домой':
			cla
			minut += 5
			gt 'kafe','kafeend'
		end
		exit
	end
	gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str44')
	act 'Извините, но мне пора домой':
		cla
		minut += 5
		gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str45')
		if $npc['34,sex'] > 0:
			gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str46')
			act 'Все же я домой':
				cla
				minut += 5
				gt 'kafe','kafeend'
			end
			act 'Помочь Гиви': gt'kavkazkafe','podgivi'
			exit
		else
			gs 'zz_render', '', '', func('kafedinamic_strings', 'local_str47')
			act 'Все же я домой':
				cla
				$npc['34,relation'] = 0
				minut += 5
				gt 'kafe','kafeend'
			end
			act 'Помочь Гиви': gt'kavkazkafe','podgivi'
			exit
		end
		act 'Идти домой':
			cla
			minut += 5
			gt 'kafe','kafeend'
		end
	end
	act 'Помочь Гиви': gt'kavkazkafe','podgivi'
end