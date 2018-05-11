if $ARGS[0] = 'room':
	*clr
	minut += 60
	$boy = $husName
	dick = husDick
	silavag = silavagH
	husbandsexday += 1
	sexrand = RAND(0,3)
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Спальня', 'images/pic/bedr'+iif(rembedr=0,'',2), func('husbSex_strings', 'local_str1')
	if sexrand = 0:
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str6')
		act 'Сделать минет':
			cla
			husband += 1
			gt'husbsex','minet'
		end
		act 'Я не хочу, давай по другому':husband -= 1 & gt'husbsex','variant'
	elseif sexrand = 1:
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str7')
		act 'Анальный секс':
			cla
			husband += 2
			gt'husbsex','anal'
		end
		act 'Да ну нафиг, давай по другому':husband -= 1 & gt'husbsex','variant'
	elseif sexrand = 2:
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str8')
		act 'Раздвинуть ноги':gt'husbsex','miss'
		act 'Я не хочу, давай по другому':husband -= 1 & gt'husbsex','variant'
	elseif sexrand = 3:
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str9')
		act 'Встать раком':gt'husbsex','dog'
		act 'Я не хочу, давай по другому':husband -= 1 & gt'husbsex','variant'
	end
end
if $ARGS[0] = 'variant':
	gs 'zz_render', '', '', func('husbSex_strings', 'local_str17')
	act 'Раздвинуть ноги':gt'husbsex','miss'
	act 'Встать раком':gt'husbsex','dog'
	act 'Анальный секс':gt'husbsex','anal'
	act 'Сделать минет':gt'husbsex','minet'
	act 'Подрочить ему':gt'husbsex','hand'
	if kunday ! day:
		act 'Куни': gt'husbsex','kuni'
	end
	if DOM > 0 and harakHusb = 0 and izvratH = 1 and strapon > 0:
		act 'Отстрапонить':gt'husbsex','strapon'
	end
end
if $ARGS[0] = 'minet':
	*clr
	gs'brosok'
	bj += 1
	minut += 30
	gs 'zz_render','','common/sex/bj/<<rand(0,4)>>.gif', func('husbSex_strings', 'local_str18')
	gs 'zz_dynamic_sex', 'bj'
	act 'Продолжать сосать':
		*clr & cla
		swallow += 1
		gs 'zz_funcs', 'cum', 'lip'
		husband += 1
		gs 'zz_render', '', 'images/picV/swallow.jpg', func('husbSex_strings', 'local_str19')
		gs 'husbSex','finish'
	end
	act 'Вынуть изо рта':
		*clr & cla
		if RAND(0,1) = 0:
			gs 'zz_funcs', 'cum', 'face'
			husband += 1
			gs 'zz_render', '', 'images/picV/facial.jpg', func('husbSex_strings', 'local_str20')
		else
			husband -= 1
			gs 'zz_render', '', 'images/picV/hand.jpg', func('husbSex_strings', 'local_str21')
		end
		gs 'husbSex','finish'
	end
end
if $ARGS[0] = 'hand':
	*clr
	gs'brosok'
	DOM += 1
	hj += 1
	minut += 30
	horny += rand(10,20)
	gs 'zz_render', '', 'images/picV/hand1.jpg', func('husbSex_strings', 'local_str22')
	gs 'husbSex','finish'
end
if $ARGS[0] = 'kuni':
	*clr
	kunday = day
	gs'brosok'
	DOM += 1
	kuni += 1
	minut += 30
	horny += rand(10,20)
	gs 'zz_render', '', 'images/picV/kuni.jpg', func('husbSex_strings', 'local_str23')
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str24')
	else
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str25')
	end
	act 'Дальше':
		cla
		gt'husbsex','variant'
	end
end
if $ARGS[0] = 'strapon':
	*clr
	gs'brosok'
	DOM += 5
	minut += 30
	horny += rand(10,20)
	gs 'zz_render', '', 'images/picV/pegging.jpg', func('husbSex_strings', 'local_str26')
	gs 'husbSex','finish'
end
if $ARGS[0] = 'anal':
	*clr
	gs'brosok'
	anal += 1
	minut += 30
	if analplugin = 1:
		analpluginbonus = 10
		analplugin = 0
		gs 'zz_funcs', 'cum', 'ass'
		minut += 3
		gs 'zz_funcs', 'cum', 'anus'
		if anus < husDick:anus += 1
		horny += (anus-husDick)*3
		gs 'zz_render','','images/picV/dog2.jpg'
		if anus < 16: '<<$husName>> вытащил из вашей ещё узкой и тугой попки пробку,'
		if anus >= 16: '<<$husName>> вытащил из вашей разгорячённой сочащейся соками попки пробку, и вы почувствовали как твердый член уперся в вашу дырочку.'
		if anus + analpluginbonus < husDick:
			gs 'zz_render', '', '', func('husbSex_strings', 'local_str27')
		else
			gs 'zz_render', '', '', func('husbSex_strings', 'local_str28')
		end
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str29')
		if horny >= 100:
			horny = 1
			orgasm += 1
			analorgasm += 1
			gs 'zz_render', '', '', func('husbSex_strings', 'local_str30')
		end
		gs 'husbSex','finish'
	end
	if husDick < anus: anus += 1
	gs 'zz_render','','images/picV/dog2.jpg'
	if lubri = 0:
		lubonus = 2
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str31')
	elseif lubri > 0:
		lubri -= 1
		lubonus = 10
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str32')
	end
	gs 'zz_render', '', '', func('husbSex_strings', 'local_str33')
	if anus < 10: 'Когда в вашу попку вошло три пальца вы невольно застонали от боли.'
	if anus >= 10: 'Потом парень ввел вам три пальца и начал растягивать ваш анус.'
	gs 'zz_render', '', '', func('husbSex_strings', 'local_str34')
	if anus + lubonus < husDick:
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str35')
	else
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str36')
	end
	gs 'zz_render', '', '', func('husbSex_strings', 'local_str37')
	if anus + lubonus + 2 < husDick:
		if mop > 1:mop = 0
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str38')
	else
		gs 'zz_render', '', '', func('husbSex_strings', 'local_str39')
	end
	gs 'zz_render', '', '', func('husbSex_strings', 'local_str40')
	husband += 5
	gs 'zz_render', '', '', func('husbSex_strings', 'local_str41')
	if anus < husDick: anus += 1
	act 'Идти в ванную':
		cla
		lubonus = 0
		$loc = 'korr'
		gt 'zz_bathroom','init','korr'
	end
end
if $ARGS[0] = 'miss':
	*clr
	husband += 1
	gs'brosok'
	sex += 1
	minut += 30
	pose = 0
	$boy = $husName
	dick = husDick
	silavag = silavagH
	gs 'zz_render', '', 'images/picV/vag.jpg', func('husbSex_strings', 'local_str43')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'husbSex','finish'
end
if $ARGS[0] = 'dog':
	*clr
	husband += 1
	gs 'brosok'
	sex += 1
	minut += 30
	pose = 1
	$boy = $husName
	dick = husDick
	silavag = silavagH
	gs 'zz_render', '', 'images/picV/dog1.jpg', func('husbSex_strings', 'local_str44')
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'husbSex','finish'
end
if $ARGS[0] = 'finish':
	cla
	act 'Идти в ванную':
		$loc = 'korr'
		gt 'zz_bathroom','init','korr'
	end
end
$husb_mastr_vtor = {
	if week > 5 or week < 6 and hour > 16:
		*clr & cla
		gs 'zz_render', '', 'images/img/hasb/m21.jpg', func('husbSex_strings', 'local_str45')
		if hour > 22 or hour < 7:'<<$husName>> смотрит на вас, явно немного ошарашено.'
		if hour >= 7 and hour <= 22:'Только вы входите во вкус как в комнату входит <<$husName>>'
		if harakHusb = 0:
			gs 'zz_render', '', '', func('husbSex_strings', 'local_str46')
			if izvratH = 0:
				husband -= 1
				horny = 0
				orgasm += 1
				gs 'zz_render', '', '', func('husbSex_strings', 'local_str47')
				act 'Закончить':gt'bed','start'
			else
				gs 'zz_render', '', '', func('husbSex_strings', 'local_str48')
				gs 'zz_render','','','"Значит хочешь" сказали вы'
				act 'Показать':
					*clr & cla
					gs 'zz_render', '', 'images/img/hasb/m22.jpg', func('husbSex_strings', 'local_str49')
					act 'Разрешить':
						*clr & cla
						analorgasm += 1
						orgasm += 1
						horny = 0
						gs 'zz_render', '', 'images/img/hasb/m23.jpg', func('husbSex_strings', 'local_str50')
						act 'Закончить':gt'bed','start'
					end
				end
			end
		elseif harakHusb = 1:
			gs 'zz_render', '', '', func('husbSex_strings', 'local_str51')
			husband += 1
			if izvratH = 0:
				husbizvradd += 1
				horny = 0
				orgasm += 1
				gs 'zz_render', '', '', func('husbSex_strings', 'local_str52')
				act 'Закончить': gt'bed','start'
			else
				gs 'zz_render', '', '', func('husbSex_strings', 'local_str53')
				act 'Показать':
					*clr & cla
					gs 'zz_render', '', 'images/img/hasb/m22.jpg', func('husbSex_strings', 'local_str54')
					act 'Взять в рот':
						*clr & cla
						gs 'zz_render', '', 'images/img/hasb/m24.jpg', func('husbSex_strings', 'local_str55')
						act 'Подставить попку':
							picrand = 89
							gt 'sex','anal'
						end
					end
				end
			end
		elseif harakHusb = 2:
			gs 'zz_render', '', '', func('husbSex_strings', 'local_str56')
			husband += 1
			if izvratH = 0:
				husbizvradd += 1
				gs 'zz_render', '', '', func('husbSex_strings', 'local_str57')
				act 'Раздвинуть ноги':
					picrand = 89
					gt 'sex', 'vaginal', 'vag'
				end
			else
				dom -= 1
				gs 'zz_render', '', '', func('husbSex_strings', 'local_str58')
				act 'Взять в рот':
					cla
					*clr
					gs 'zz_render', '', 'images/img/hasb/m24.jpg', func('husbSex_strings', 'local_str59')
					act 'Подставить попку':
						picrand = 89
						gt'sex','anal'
					end
				end
			end
		end
	end
}