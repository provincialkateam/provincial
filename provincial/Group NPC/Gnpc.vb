if $args[0] = '' or $args[0] = 'main':
	!парни
	GvstreBoyAfter[numnpc] = 0
	GvstreBoy = 0
	boyvstre[numnpc] += 1
	gs 'stat'
	gs 'zz_render', $nameBoyfrend[numnpc], 'common/npc/<<numnpc>>.jpg', '<<$nameBoyfrend[numnpc]>> - ваш парень. ' + func('zz_funcs','relations',otnBoyFrend[numnpc])
	if preg = 1 and pregtime <= 80 and pregTalk[numnpc] = 0 and gnpcSex[numnpc] = 1:
		$pregLie = iif($father ! $nameBoyfrend[numnpc], '(Попытаться обмануть)', '')
		act 'Сказать парню, что вы залетели от него <<$pregLie>>':
			*clr & cla
			gs 'zz_render', '', '', func('Gnpc_strings', 'preg_talk1')
			if $father = $nameBoyfrend[numnpc] or ($father ! $nameBoyfrend[numnpc] and rand(1,5) >= 4):
				gs 'zz_render', '', '', func('Gnpc_strings', 'preg_talk2')
				act 'Бросить парня и взять деньги':
					*clr & cla
					dom += 5
					pregTalk[numnpc] = 1
					otnBoyFrend[numnpc] = 0
					money += 5000
					gs 'stat'
					gs 'zz_render', '', '', func('Gnpc_strings', 'preg_talk3')
					act 'Уйти': gt $loc, $metka
				end
				act 'Бросить парня, швырнув ему деньги в лицо':
					*clr & cla
					dom += 10
					pregTalk[numnpc] = 1
					otnBoyFrend[numnpc] = 0
					gs 'zz_render', '', '', func('Gnpc_strings', 'preg_talk4')
					act 'Уйти': gt $loc, $metka
				end
			else
				gs 'zz_render', '', '', func('Gnpc_strings', 'preg_talk5')
				act 'Бросить парня':
					*clr & cla
					dom += 10
					pregTalk[numnpc] = 1
					otnBoyFrend[numnpc] = 0
					gs 'zz_render', '', '', func('Gnpc_strings', 'preg_talk6')
					act 'Уйти': gt $loc, $metka
				end
			end
		end
	end
	if GboyBalabol[numnpc] = 1:
		act 'Обвинить парня в том, что он трепло':
			*clr & cla
			gs 'zz_render','','pavlovo/boyfriend/quarrel', func('Gnpc_strings', 'boy_talk1') + func('Gnpc_strings', 'boy_talk' + (2+rand(0,2)))
			act 'Бросить парня':
				cla
				dom += 10
				GboyBalabol[numnpc] = 2
				otnBoyFrend[numnpc] = 0
				gs 'zz_render', '', '', func('Gnpc_strings', 'boy_talk5')
				act 'Уйти': gt $loc, $metka
			end
			act 'Простить парня':
				cla
				GboyBalabol[numnpc] = 2
				gs 'zz_render', '', '', func('Gnpc_strings', 'boy_talk6')
				act 'Уйти': gt $loc, $metka
			end
		end
	end
	act 'Гулять по парку':
		*clr & cla
		if mop = 2: otnBoyFrend[numnpc] += 1
		if mop = 3: otnBoyFrend[numnpc] += 2
		if mop = 4: otnBoyFrend[numnpc] -= 2
		if sweat > 0: otnBoyFrend[numnpc] -= 3
		if func('zz_clothing','is_skirt') = 1: otnBoyFrend[numnpc] += 2
		minut += 15
		gs 'stat'
		gs 'zz_render','','pavlovo/boyfriend/walking_park'+iif(month <= 2 or month >= 11,'_winter',iif(sunWeather < 0,'_rain','')), func('Gnpc_strings', 'boy_talk7')
		if $npc['9,qwKotovLove'] >= 5:
			otnBoyFrend[numnpc] = 0
			gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk1')
			act 'Уйти': gt $loc, $metka
			exit
		end
		if temper >= 10:
			if sunWeather >= 0:
				gs 'Gnpc', iif(rand(0,2) = 0,'gt_cinema','drink_beer')
			else
				gs 'Gnpc', iif(rand(0,2) = 0,'gt_cinema','gt_home')
			end
		else
			gs 'Gnpc', iif(rand(0,2) = 0,'gt_cinema','gt_home')
		end
	end
	act 'Извиниться и уйти': otnBoyFrend[numnpc] -= 5 & gt $loc, $metka
end
if $args[0] = 'gt_cinema':
	gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk2')
	act 'Извиниться и уйти':otnBoyFrend[numnpc] -= 5 & gt $loc, $metka
	act 'Идти в кино':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/boyfriend/cinema', func('Gnpc_strings', 'boy_walk3')
		act 'Смотреть кино':
			cla
			manna += 30
			minut += 100
			otnBoyFrend[numnpc] += 5
			gs 'stat'
			gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk4')
			if otnBoyFrend[numnpc] < 80:
				gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk5')
				act 'Идти к выходу': gt 'Gnpc2'
			else
				if gnpcSex[numnpc] = 0:
					gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk6')
					act 'Убрать его руки':
						cla
						dom += 1
						otnBoyFrend[numnpc] -= 5
						gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk7')
						act 'Идти к выходу': gt'Gnpc2'
					end
					act 'Игнорировать':
						cla
						otnBoyFrend[numnpc] += 5
						gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk8')
						act 'Идти к выходу': gt'Gnpc2'
					end
				else
					gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk9')
					act 'Идти к выходу': gt 'Gnpc2'
				end
			end
		end
	end
end
if $args[0] = 'gt_home':
	cla
	gs 'zz_render', '', '', func('Gnpc2_strings', 'boy_talk2')
	act '...': gt 'gorodok'
end
if $args[0] = 'drink_beer':
	gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk10')
	act 'Извиниться и уйти': otnBoyFrend[numnpc] -= 5 & gt $loc, $metka
	act 'Идти за пивом':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render','','pavlovo/boyfriend/drinking_beer', func('Gnpc_strings', 'boy_walk11')
		act 'Выпивать':
			cla
			gs 'zz_funcs', 'alko', 2
			otnBoyFrend[numnpc] += 5
			gs 'stat'
			gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk12')
			if otnBoyFrend[numnpc] < 80:
				gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk13')
				act 'Дальше': gt 'Gnpc2'
			elseif otnBoyFrend[numnpc] >= 80 and gnpcSex[numnpc] >= 0:
				gs 'zz_render', '', '', func('Gnpc_strings', 'boy_walk13')
				act 'Дальше': gt 'Gnpc2'
			end
		end
	end
end