$d_dan_blowjob = {
	act 'Сесть на корточки':
		*clr & cla
		minut += 3
		horny += 10
		bj += 1
		if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
		swallow += 1
		gs 'zz_funcs', 'cum', 'lip'
		if DansOralSlut = 0:DansOralSlut = 1
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/placer/bjdan.jpg', func('gopskver_strings', 'local_str1')
		act 'Уйти домой':gt'korrPar'
	end
	act'Нагнуться':
		*clr & cla
		minut += 30
		horny += 20
		guy += 1
		dick = $npc['10,dick']
		$boy = $npc['10,name']
		pose = 1
		gs 'zz_render','','images/nigma/gor/den1,0.gif'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Уйти домой':gt'korrPar'
	end
}
$d_gop_triple_blow = {
	act 'Сосать у Дэна':
		*clr & cla
		if func('zz_reputation','get') < 3: gs 'zz_reputation','set',3
		bj += 1
		if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
		dick = $npc['10,dick']
		dom -= 1
		minut += 5
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/placer/bjgop.jpg'
		gs 'zz_dynamic_sex', 'bj'
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str2')
		gs 'zz_dynamic_sex', 'swallow'
		act 'Сосать у Шульги':
			*clr & cla
			bj += 1
			if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
			gs 'zz_funcs', 'cum', 'face'
			dick = $npc['11,dick']
			dom -= 1
			minut += 5
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/placer/bjgop2.jpg'
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str3')
			act 'Сосать у Витька':
				*clr & cla
				bj += 1
				if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
				dick = $npc['9,dick']
				dom -= 1
				gs 'zz_funcs', 'cum', 'face'
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/placer/bjgop3.jpg'
				gs 'zz_dynamic_sex', 'bj'
				gs 'zz_render','','',func('gopskver_strings', 'local_str4')
				act 'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/alter/placer/bjgop3.jpg', func('gopskver_strings', 'local_str5')
					act 'Поняла':
						*clr & cla
						dom -= 1
						gs 'stat'
						gs 'zz_render','','images/qwest/alter/placer/bjgop3.jpg', func('gopskver_strings', 'local_str6')
						act 'Уйти': gt 'zz_park'
					end
					act 'Да пошли вы!':
						*clr & cla
						dom -= 5
						pee += 1
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/placer/goppee.jpg', func('gopskver_strings', 'local_str7')
						act 'Уйти':gt'zz_park'
					end
				end
			end
		end
	end
}
*clr & cla
gs 'time'
if $loc = 'zz_park': gs 'zz_render','Парк',func('zz_funcs','mk_image_ex','common/park/park',1)
if $npc['9,qwKotovLove'] >= 5:
	if hour < 20:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str8')
		act 'Уйти': gt $loc, $metka
		act 'Пить пиво':
			*clr & cla
			gs 'zz_funcs', 'alko', 2
			gs 'stat'
			gs 'zz_render', '', 'images/pic/ParkBeer.jpg', func('gopskver_strings', 'local_str9')
			act 'Далее': gt $curloc
		end
		if alko > 2:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str10')
			act 'Идти к Витьку':
				*clr & cla
				minut += 15
				gs 'stat'
				gs 'zz_render', '', 'images/common/npc/9.jpg', func('gopskver_strings', 'local_str11')
				act 'Далее': gt 'kotovSex'
			end
		end
	elseif hour >= 20:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str12')
		act 'Уйти': gt $loc, $metka
		act 'Идти на дискотеку с пацанами': minut += 15 & gt 'gdkin'
	end
else
	if hour >= 20:
		if alko < 3:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str13')
			act 'Уйти': gt $loc, $metka
			act 'Идти на дискотеку с пацанами': minut += 15 & gt 'gdkin'
		elseif alko >= 3 and alko < 6 and DansOralSlut = 1:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str14')
			if dom >= 5: act 'Отказаться': gt $loc, $metka
			act 'Идти с Дэном':
				*clr & cla
				horny += 10
				minut += 15
				gs 'stat'
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str15')
				dynamic $d_dan_blowjob
				act 'Возмутиться':
					*clr & cla
					gs 'zz_reputation','set',2
					gs 'stat'
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str16')
					act 'Уйти домой': gt 'korrPar'
				end
			end
		elseif alko >= 3 and alko < 6 and DansOralSlut = 0:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str17')
			if dom >= 5: act 'Отказаться': gt $loc, $metka
			act 'Идти с Дэном':
				*clr & cla
				horny += 10
				minut += 15
				gs 'stat'
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str18')
				if dom >= 10: act 'Отказаться': gt $loc, $metka
				act 'Целоваться':
					*clr & cla
					horny += 10
					gs'stat'
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str19')
					if dom >= 15: act 'Уйти домой': gt'korrPar'
					dynamic $d_dan_blowjob
				end
			end
		elseif alko >= 6:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str20')
			if dom >= 5: act 'Уйти самой': gt $loc, $metka
			act 'Идти с парнями':
				*clr & cla
				if sgopgang = 0: sgopgang = 1
				if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
				if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
				if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
				sex += 3
				gang += 1
				vagina += 3
				cumbelly += 3
				gs 'stat'
				gs 'zz_render', '', 'images/nigma/gor/orgy1,'+rand(0,4)+'.gif', func('gopskver_strings', 'local_str21')
				act 'Уйти': gt 'gorodok'
			end
		end
	elseif hour < 20:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str22')
		if func('zz_reputation','get') < 3:
			if alko < 4:
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str23')
				act 'Уйти': gt $loc, $metka
				act 'Пить пиво':
					*clr & cla
					gs 'zz_funcs', 'alko', 2
					gs 'stat'
					gs 'zz_render', '', 'images/pic/ParkBeer.jpg', func('gopskver_strings', 'local_str24')
					act 'Далее': gt $curloc
				end
			else
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str25')
				act 'Уйти': gt $loc, $metka
				if func('zz_reputation','get') = 0:
					act 'Пить пиво':
						*clr & cla
						gs 'zz_funcs', 'alko', 2
						gs 'stat'
						gs 'zz_render', '', 'images/pic/ParkBeer.jpg', func('gopskver_strings', 'local_str26')
						act 'Далее':gt $curloc
					end
				elseif func('zz_reputation','get') = 1:
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str27')
					act 'Да':
						*clr & cla
						gs 'zz_render', '', '', func('gopskver_strings', 'local_str28')
						act 'Уйти': gt'zz_park'
					end
					act 'Нет':
						*clr & cla
						gs 'zz_render', '', '', func('gopskver_strings', 'local_str29')
						act 'Уйти':gt'zz_park'
					end
				elseif func('zz_reputation','get') >= 2:
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str30')
					act 'Да':
						*clr & cla
						gs 'zz_render', '', '', func('gopskver_strings', 'local_str31')
						act 'Да':
							*clr & cla
							gs 'zz_render', '', '', func('gopskver_strings', 'local_str32')
							act 'Нет':
								*clr & cla
								gs 'zz_render', '', '', func('gopskver_strings', 'local_str33')
								act 'Нет, не западло':
									*clr & cla
									gs 'zz_render', '', '', func('gopskver_strings', 'local_str34')
									dynamic $d_gop_triple_blow
								end
								act 'Западло':
									minut += 5
									dom -= 1
									manna -= 5
									*clr & cla
									gs 'stat'
									gs 'zz_render', '', 'images/qwest/alter/placer/body_cocksucker.jpg', func('gopskver_strings', 'local_str35')
									act 'Уйти':gt'zz_park'
								end
							end
							act 'Может быть':
								*clr & cla
								gs 'zz_render', '', '', func('gopskver_strings', 'local_str36')
								dynamic $d_gop_triple_blow
							end
						end
						act 'Нет':
							*clr & cla
							gs 'zz_render', '', '', func('gopskver_strings', 'local_str37')
							if swallow > 0:
								gs 'zz_render', '', '', func('gopskver_strings', 'local_str38')
							elseif swallow = 0 and facial > 0:
								gs 'zz_render', '', '', func('gopskver_strings', 'local_str39')
							else
								gs 'zz_render', '', '', func('gopskver_strings', 'local_str40')
							end
							gs 'zz_render', '', '', func('gopskver_strings', 'local_str41')
							dynamic $d_gop_triple_blow
						end
					end
					act 'Нет':
						*clr & cla
						gs 'zz_render', '', '', func('gopskver_strings', 'local_str42')
						dynamic $d_gop_triple_blow
					end
				end
			end
		elseif func('zz_reputation','get') >= 3:
			shultextrand = RAND(0,2)
			if shultextrand = 0:$shultextrand = 'хочешь конфетку красный богатырь?'
			if shultextrand = 1:$shultextrand = 'хочешь Чупахуй?'
			if shultextrand = 2:$shultextrand = 'хорошо бродить по свету с карамелькой за щекою?'
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str43')
			act 'Покраснеть и уйти': gt 'zz_park'
			if BjBeerQW >= 5: act 'Подойти к ребятам':gt'zsoft_gopskverGorSlut','1'
			act 'Строить глазки':
				if BjBeerDay = day:
					*clr & cla
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str44')
					act 'Уйти':gt'zz_park'
				else
					gt 'gopskver', 'BjBeerStart'
				end
			end
		end
	end
end
if $ARGS[0] = 'BjBeerStart':
	*clr & cla
	gs 'zz_render', '', '', func('gopskver_strings', 'local_str45')
	act 'Удивленно посмотреть на него.':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer.gif', func('gopskver_strings', 'local_str46')
		act 'Взять в рот за пиво': gt 'gopskver','BjBeerYes'
		if BjBeerQW >= 5:
			act 'Раздвинуть ноги за пиво': gt 'gopskver','BjBeerVag'
			act 'Дать в жопу за пиво': gt 'gopskver','BjBeerAnal'
		end
		if dom > 0 and stren + agil + speed < 200: act 'Возмутиться': gt 'gopskver', 'BjBeerBeaten'
		if dom > 0 and razradKik >= 3 or stren + agil + speed >= 200:
			act 'Отказаться и убежать':
				*clr & cla
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str47')
				act 'Вернуться в парк': gt 'zz_park'
			end
		end
	end
end
if $ARGS[0] = 'BjBeerBeaten':
	*clr & cla
	'<center><img src="images/qwest/alter/placer/BjBeerBeaten.jpg" ></center>'
	minut += 10
	spank += 1
	dom -= 3
	spanked += 10
	tanga = 0
	manna -= 10
	if mop > 1: mop = 0 & vidageday -= 1
	gs 'stat'
	gs 'zz_render', '', '', func('gopskver_strings', 'local_str48')
	if BjBeerQW = 3:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str49')
		if dom>10 and vagina = 0 and anus >5 and horny < 75:
			act 'Предложить другой вариант':
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str50')
				act 'Дать в жопу':gt 'gopskver','BjBeerAnal'
			end
		else
			act 'Покорно плестись': gt 'gopskver','BjBeerVag'
		end
	elseif BjBeerQW = 4:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str51') + func('gopskver_strings', 'local_str'+iif(anus <= 5,52,53))
		act 'Подчиниться': gt 'gopskver','BjBeerAnal'
	else
		act 'Старательно отсасывать': gt 'gopskver', 'BjBeerAct'
		act 'Вяло сосать': gt 'gopskver', 'BjBeerPas'
	end
end
if $ARGS[0] = 'BjBeerYes':
	*clr & cla
	minut += 10
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer'+RAND(1,2)+'.jpg', func('gopskver_strings', 'local_str54')
	if BjBeerQW = 3:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str55')
		if dom>10 and vagina = 0 and anus >5 and horny < 75:
			act 'Предложить другой вариант':
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str56')
				act 'Дать в жопу':gt 'gopskver','BjBeerAnal'
			end
		else
			act 'Покорно плестись': gt 'gopskver','BjBeerVag'
		end
	elseif BjBeerQW = 4:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str57') + func('gopskver_strings', 'local_str'+iif(anus <= 5,58,59))
		act 'Подчиниться': gt 'gopskver','BjBeerAnal'
	else
		act 'Старательно отсасывать': gt 'gopskver', 'BjBeerAct'
		act 'Вяло сосать': gt 'gopskver', 'BjBeerPas'
	end
end
if $ARGS[0] = 'BjBeerAct':
	*clr & cla
	minut += 15
	throat += 1
	swallow += 1
	bj += 1
	eggs +=1
	gs 'zz_funcs', 'cum', 'lip'
	BjBeerActiv = 1
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer3.jpg', func('gopskver_strings', 'local_str'+iif(throat <= 15,60,61))
	act 'Лизать яйца':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer'+RAND(7,8)+'.gif', func('gopskver_strings', 'local_str62')
		if BjBeerQW = 1:
			act 'Обслужить остальных': gt 'gopskver','BjBeerPhone'
		elseif BjBeerQW = 2:
			act 'Обслужить остальных': gt 'gopskver','BjBeerPalevo'
		else
			act 'Обслужить остальных': gt 'gopskver','BjBeerDouble'
		end
	end
end
if $ARGS[0] = 'BjBeerPas':
	*clr & cla
	minut += 30
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	bj += 1
	BjBeerActiv = 0
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer4.jpg', func('gopskver_strings', 'local_str63')
	act 'Открыть рот':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer'+RAND(9,10)+'.gif', func('gopskver_strings', 'local_str64')
		if BjBeerQW = 1:
			act 'Обслужить остальных': gt 'gopskver','BjBeerPhone'
		elseif BjBeerQW = 2:
			act 'Обслужить остальных': gt 'gopskver','BjBeerPalevo'
		else
			act 'Обслужить остальных': gt 'gopskver', 'BjBeerDouble'
		end
	end
end
if $ARGS[0] = 'BjBeerDouble':
	*clr & cla
	bj += 2
	throat += 1
	gs 'zz_funcs', 'cum', 'face'
	minut += 10
	if mop > 1: mop = 0 & vidageday -= 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/placer/BjBeer'+RAND(14,15)+'.jpg',func('gopskver_strings','local_str65') + func('gopskver_strings','local_str'+iif(throat <= 15,66,67)) + func('gopskver_strings', 'local_str68')
	act 'Обтекать': gt'gopskver','BjBeerFace'
end
if $ARGS[0] = 'BjBeerFace':
	*clr & cla
	if mop = 0:
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer6.jpg', func('gopskver_strings', 'local_str69')
	else
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer5.jpg', func('gopskver_strings', 'local_str70')
	end
	minut += 5
	BjBeerDay = day
	gs 'stat'
	gs 'zz_render', '', '', func('gopskver_strings', 'local_str71')
	if BjBeerQW = 0:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str72')
	elseif BjBeerQW = 1:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str73')
	elseif BjBeerQW = 2:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str74')
	end
	act 'А пиво?':
		*clr & cla
		if BjBeerActiv = 1:
			BjBeerQW += 1
			Alko+=3
			Manna+=5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer'+RAND(11,12)+'.jpg', func('gopskver_strings', 'local_str75')
			act 'Вернуться в парк': BjBeerActiv = 0 & gt'zz_park'
		elseif BjBeerActiv = 0:
			Manna = 0
			BjBeerQW += 1
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer13.jpg', func('gopskver_strings', 'local_str76')
			act 'Вернуться в парк': gt'zz_park'
		end
	end
end
if $ARGS[0] = 'BjBeerPhone':
	*clr & cla
	bj += 2
	throat += 1
	hapri = 0
	gs 'zz_funcs', 'cum', 'face'
	minut += 10
	if mop > 1: mop = 0 & vidageday -= 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/placer/BjBeerPhone.jpg',func('gopskver_strings', 'local_str77') + func('gopskver_strings','local_str'+iif(mop = 0,78,79)) + func('gopskver_strings', 'local_str80')
	act 'Передать':
		cla
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str81')
		act 'Охреневать': gt'gopskver','BjBeerFace'
	end
end
if $ARGS[0] = 'BjBeerPalevo':
	*clr & cla
	if brotherknowslut < 2: brotherknowslut = 2
	bj += 2
	throat += 1
	gs 'zz_funcs', 'cum', 'face'
	minut += 10
	if mop > 1: mop = 0 & vidageday -= 1
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer'+RAND(14,15)+'.jpg', func('gopskver_strings', 'local_str82')
	act 'Обтекать': gt'gopskver','BjBeerFace'
end
if $ARGS[0] = 'BjBeerVag':
	*clr & cla
	minut += 10
	rape += 1
	gang += 1
	dom -= 3
	if dom < 0: horny += 10
	BjBeerQW += 1
	BjBeerDay = day
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerVag.jpg', func('gopskver_strings', 'local_str83')
	if dom < -20: 'Однако вместе с тем унизительность положения и ощущение беспомощности вызывают у вас определенное возбуждение.'
	if analplugin = 1: '"Затычку для жопы таскаешь? Чтобы не бздеть чтоли?" С громким чпоком Шульга рывком вытащил вашу анальную пробку, вызвав у вас гримасу боли, и затем так же резко засунул ее обратно. Остальные заржали.'
	if lobok > 2:'Шаря рукой по вашей промежности, один из парней недовольно бросил: "Хоть бы побрила свою мандень. Какие то джунгли просто. Ничего счас три тарзана тобой займутся."'
	if lobok <=2:'Проведя ладонью по вашему <<$lobok3>>, Дэн с удовлетворением хмыкает: "Глянь, эта <<$gnikname>> пизду побрила, для нас видать приготовила, знала что ебать будем".'
	if pirsG = 1:
		horny+=10
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str84')
	end
	if tattoo['vag'] > 0 or tattoo['waist'] > 0: 'Обнаружив ваше тату Витек одобрительно заметил: "Правильно, подстилки типо тебя должна носить клеймо, чтобы их не перепутали с нормальными людьми".'
	if tattoo['vag'] = 0 and tattoo['waist'] = 0:'Лапая вас за попу Витек заметил: "Пора тебе <<$name[2]>> уже наколочку сделать соответствующую, чтобы нормальные пацаны сразу видели, что перед ними шлюха"'
	gs 'zz_render', '', '', func('gopskver_strings', 'local_str85')
	act 'Лежать':
		*clr & cla
		dick = 18
		$boy = 'Витек'
		minut += 10
		pose = 0
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerVag1.gif', func('gopskver_strings', 'local_str86')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		if protect ! 1:
			gs 'stat'
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str87')
			gs 'zz_funcs', 'cum', 'pussy'
		else
			protect = 0
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str88')
		end
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str89')
		act 'Попытаться расслабиться':
			*clr & cla
			$boy = 'Дэн'
			dick = 17
			gs 'zz_funcs', 'cum', 'belly'
			minut += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerVag'+RAND(2,3)+'.jpg', func('gopskver_strings', 'local_str90')
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str91')
			act 'Терпеть':
				*clr & cla
				$boy = 'Шульга'
				dick = 15
				gs 'zz_funcs', 'cum', 'ass'
				minut += 10
				pose = 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerVag4.gif', func('gopskver_strings', 'local_str92')
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str93')
				act 'Приходить в себя':
					*clr & cla
					alko += 3
					manna += 5
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer'+RAND(11,12)+'.jpg', func('gopskver_strings', 'local_str94')
					act 'Вернуться в парк': gt'zz_park'
				end
			end
		end
	end
end
if $ARGS[0] = 'BjBeerAnal':
	*clr & cla
	rape += 1
	gang += 1
	dom -= 3
	if dom < 0: horny += 10
	BjBeerQW += 1
	BjBeerDay = day
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerAnal.jpg', func('gopskver_strings', 'local_str95')
	if dom <= -20: 'Однако вместе с тем унизительность положения и ощущение беспомощности вызывают у вас определенное возбуждение.'
	if anus <= 5:'Пацаны позади вас быстро решают кто первый будет распечатывать ваше тугое очко. Повезло на этот раз Шульге.'
	if anus > 5: 'Пацаны быстро решают кто первый будет драть вас в вашу рабочую жопу. Это оказался Шульга.'
	if tattoo['waist'] > 0: 'При виде вашего тату на пояснице Шульга одобрительно похлопал вас по попе - "Хорошо тебя пометили, шлюха."'
	if tattoo['waist'] = 0: 'Звонко шлепнув вас по жопе Шульга недовольно буркнул - "Такие мочалки как ты должны ходить с клеймом на седле, чтобы их сразу видно было."'
	if analplugin = 1: analplugin = 0 & '"Это тебе сейчас не понадобится" С громким чпоком Шульга рывком вытащил вашу анальную пробку, вызвав у вас гримасу боли."'
	gs 'zz_render', '', '', func('gopskver_strings', 'local_str96')
	act 'Попытаться расслабить анус':
		*clr & cla
		dick = 15
		$boy = 'Шульга'
		gs 'zz_funcs', 'cum', 'anus'
		minut += 10
		gs 'stat'
		'<center><img src="images/qwest/alter/placer/BjBeerAnal2.jpg" ></center>'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str97') + func('gopskver_strings', 'local_str100')
		act 'Раздвинуть ягодицы': gt 'gopskver','BjBeerAnal2'
	end
end
if $ARGS[0] = 'BjBeerAnal2':
	*clr & cla
	$boy = 'Дэн'
	dick = 17
	gs 'zz_funcs', 'cum', 'anus'
	minut += 10
	if mop > 1: mop = 0 & vidageday -= 1
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerAnal<<RAND(3,4)>>.jpg', func('gopskver_strings', 'local_str101')
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	gs 'zz_render', '', '', func('gopskver_strings', 'local_str102') + func('gopskver_strings', 'local_str103')
	act 'Подставить жопу':
		*clr & cla
		$boy = 'Витек'
		dick = 18
		gs 'zz_funcs', 'cum', 'ass'
		minut += 10
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerAnal5', func('gopskver_strings', 'local_str104')
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str105')
		if BjBeerQW = 4: 'Обслужив последнего вы устало валитесь на траву. К вам подходит Шульга и с издвевкой спрашивает: "Ну что, <<$name[2]>>, твоя жопа теперь рабочая?" -"Да рабочая", отвечаете вы, краснея и пряча взгляд. - "Будешь теперь постоянно очко подставлять пацанам?" - не унимается гопник. "Да, буду подставлять очко." - механически повторяете вы. "Вот и умница" - хохотнул парень.'
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str106')
		act 'Показать':
			*clr & cla
			minut +=5
			dom -= 1
			gs 'stat'
			if anus <= 10:
				gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerAnal6.jpg', func('gopskver_strings', 'local_str107')
			elseif anus > 10 and anus < 25:
				gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerAnal7.jpg', func('gopskver_strings', 'local_str108')
			else
				gs 'zz_render', '', 'images/qwest/alter/placer/BjBeerAnal8.jpg', func('gopskver_strings', 'local_str109')
			end
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str110')
			if agape = 3: 'Из вашего растерзанного ануса медленно вытекает сперма вперемешку с кровью'
			if agape < 3:'<<$anus>>, после нескольких хуев побывавших в нем. Из него медленно вытекает сперма.'
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str111')
			act 'А пиво?':
				*clr & cla
				alko += 3
				manna += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/placer/BjBeer<<RAND(11,12)>>.jpg', func('gopskver_strings', 'local_str112')
				act 'Вернуться в парк': gt'zz_park'
			end
		end
	end
end