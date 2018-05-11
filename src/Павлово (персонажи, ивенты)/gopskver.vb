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
						act 'Уйти': gt $loc, $metka
					end
				end
			end
		end
	end
}
!---
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
			gs 'zz_render', '', 'common/park/beer'+rand(1,4), func('gopskver_strings', 'local_str9')
			act 'Далее': gt $curloc
		end
		if alko > 2:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str10')
			act 'Идти к Витьку':
				*clr & cla
				minut += 15
				gs 'stat'
				gs 'npc_editor','get_npc_profile',9
				gs 'zz_render','','',func('gopskver_strings','local_str11')
				act 'Далее': gt 'kotovSex'
			end
		end
	elseif hour >= 20 and hour < 23:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str12')
		act 'Уйти': gt $loc, $metka
		act 'Идти на дискотеку с пацанами': minut += 15 & gt 'gdkin'
	end
else
	if hour >= 20 and hour < 23:
		if alko < 3:
			gs 'zz_render', '', '', func('gopskver_strings', 'local_str13')
			act 'Уйти': gt $loc, $metka
			act 'Идти на дискотеку с пацанами': minut += 15 & gt 'gdkin'
		elseif alko >= 3 and DansOralSlut = 1:
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
		elseif alko >= 3 and DansOralSlut = 0:
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
					gs 'stat'
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str19')
					if dom >= 15: act 'Уйти домой': gt'korrPar'
					dynamic $d_dan_blowjob
				end
			end
		end
	elseif hour < 20 and hour < 23:
		gs 'zz_render', '', '', func('gopskver_strings', 'local_str22')
		if func('zz_reputation','get') < 3:
			if alko < 4:
				gs 'zz_render', '', '', func('gopskver_strings', 'local_str23')
				act 'Уйти': gt $loc, $metka
				act 'Пить пиво':
					*clr & cla
					gs 'zz_funcs', 'alko', 2
					gs 'stat'
					gs 'zz_render', '', 'common/park/beer'+rand(1,4), func('gopskver_strings', 'local_str24')
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
						gs 'zz_render', '', 'common/park/beer'+rand(1,4), func('gopskver_strings', 'local_str26')
						act 'Далее':gt $curloc
					end
				elseif func('zz_reputation','get') = 1:
					gs 'zz_render', '', '', func('gopskver_strings', 'local_str27')
					act 'Да':
						*clr & cla
						gs 'zz_render', '', '', func('gopskver_strings', 'local_str28')
						act 'Уйти': gt $loc, $metka
					end
					act 'Нет':
						*clr & cla
						gs 'zz_render', '', '', func('gopskver_strings', 'local_str29')
						act 'Уйти': gt $loc, $metka
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
							gs 'zz_render','','',func('gopskver_strings', 'local_str37')
							if swallow > 0:
								gs 'zz_render','','',func('gopskver_strings', 'local_str38')
							elseif swallow = 0 and facial > 0:
								gs 'zz_render','','',func('gopskver_strings', 'local_str39')
							else
								gs 'zz_render','','',func('gopskver_strings', 'local_str40')
							end
							gs 'zz_render','','',func('gopskver_strings', 'local_str41')
							dynamic $d_gop_triple_blow
						end
					end
					act 'Нет':
						*clr & cla
						gs 'zz_render','','',func('gopskver_strings', 'local_str42')
						dynamic $d_gop_triple_blow
					end
				end
			end
		elseif func('zz_reputation','get') >= 3:
			gs 'zz_render','','',func('gopskver_strings', 'local_str43')
			act 'Покраснеть и уйти': gt $loc, $metka
		end
	end
end