if $ARGS[0] = 'start':
	if svidanieA = 1 and svidanieB = 1 and svidanieC = 1:
		bfA = 0
		bfB = 0
		bfC = 0
		svidanieA = 0
		svidanieB = 0
		svidanieC = 0
		manna = 0
		gs 'zz_render', '', '', func('svidan_strings', 'local_str1')
		act 'Уйти': gt 'street'
		exit
	elseif svidanieA = 1 and svidanieB = 1 and svidanieC = 0:
		bfA -= 1
		bfB = 0
		!bfC = 0
		svidanieA = 0
		svidanieB = 0
		svidanieC = 0
		manna -= 10
		gs 'zz_render', '', '', func('svidan_strings', 'local_str2')
		if bfA > 0:'<<$boybodyA>> <<$boybodA>> <<$boyA>> бьет кулаком своему конкуренту в лицо. <<$boyB>> падает на землю с разбитым лицом. <<$boyA>> говорит поверженному сопернику, "еще раз тебя увижу возле моей девчонки вообще убью нахер."'
		if bfA <= 0:'<<$boyA>> плюет со злостью на землю и говорит. "Пошла ты на хер, шлюха." и уходит швырнув цветы в помойку. <<$boyB>> глядит на происходящее и уходит не говоря ни слова.'
		act 'Уйти': gt 'street'
		exit
	elseif svidanieA = 1 and svidanieB = 0 and svidanieC = 1:
		bfA -= 1
		!bfB = 0
		bfC = 0
		svidanieA = 0
		svidanieB = 0
		svidanieC = 0
		manna -= 10
		gs 'zz_render', '', '', func('svidan_strings', 'local_str3')
		if bfA > 0:'<<$boybodyA>> <<$boybodA>> <<$boyA>> бьет кулаком своему конкуренту в лицо. <<$boyC>> падает на землю с разбитым лицом. <<$boyA>> говорит поверженному сопернику, "еще раз тебя увижу возле моей девчонки вообще убью нахер."'
		if bfA <= 0:'<<$boyA>> плюет со злостью на землю и говорит. "Пошла ты на хер, шлюха." и уходит швырнув цветы в помойку. <<$boyC>> глядит на происходящее и уходит не говоря ни слова.'
		act 'Уйти':gt 'street'
		exit
	elseif svidanieA = 0 and svidanieB = 1 and svidanieC = 1:
		bfB -= 1
		!bfB = 0
		bfC = 0
		svidanieA = 0
		svidanieB = 0
		svidanieC = 0
		manna -= 10
		gs 'zz_render', '', '', func('svidan_strings', 'local_str4')
		if bfb > 0:'<<$boybodyB>> <<$boybodB>> <<$boyB>> бьет кулаком своему конкуренту в лицо. <<$boyC>> падает на землю с разбитым лицом. <<$boyB>> говорит поверженному сопернику, "еще раз тебя увижу возле моей девчонки вообще убью нахер."'
		if bfb <= 0:'<<$boyB>> плюет со злостью на землю и говорит. "Пошла ты на хер, шлюха." и уходит швырнув цветы в помойку. <<$boyC>> глядит на происходящее и уходит не говоря ни слова.'
		act 'Уйти': gt 'street'
		exit
	elseif svidanieA = 1 and svidanieB = 0 and svidanieC = 0:
		dayA = dayA + 1
		svidanieA = 0
		manna += RAND(5,10)
		if harakBoy = 0:
			if mop <= 2 and mop > 0:bfA += 1
			if mop = 4:bfA -= 1
		elseif harakBoy = 1:
			if mop <= 3 and mop > 0:bfA += 1
			if mop = 4:bfA -= 1
		elseif harakBoy = 2:
			if mop = 4:bfA += 1
			if mop <= 2 and mop > 0:bfA -= 1
		end
		gs 'zz_render', '', '', func('svidan_strings', 'local_str5')
		if dayA >= 30:
			if RAND(0,2) <= financeA:
				gift = RAND(bfa*10,bfa*50)
				money += gift
				gs 'zz_render', '', '', func('svidan_strings', 'local_str6')
			end
		end
		act 'Поцеловать':gt'svidan','a'
		act 'Избежать поцелуя':
			cla
			bfA -= 1
			gt'svidan','a'
		end
		exit
	elseif svidanieA = 0 and svidanieB = 1 and svidanieC = 0:
		dayB = dayB + 1
		svidanieB = 0
		gs 'zz_render', '', '', func('svidan_strings', 'local_str7')
		act 'Поцеловать':gt'svidan','b'
		exit
	elseif svidanieA = 0 and svidanieB = 0 and svidanieC = 1:
		dayc = dayc + 1
		svidaniec = 0
		gs 'zz_render', '', '', func('svidan_strings', 'local_str8')
		act 'Поцеловать':gt'svidan','c'
		exit
	end
end
if $ARGS[0] = 'a':
	if financeA = 0: gt'svi','poor'
	if financeA = 1: gt'svi','norm'
	if financeA = 2: gt'svi','reach'
end
if $ARGS[0] = 'kustA':
	*clr
	minut += 20
	gs 'zz_render', '', '', func('svidan_strings', 'local_str9')
	act 'Взять в рот':
		*clr & cla
		bfA += 1
		if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
		bj += 1
		dick = dickA
		harakBoy = harakBoyA
		minut += 30
		$boy = $boyA
		gs 'zz_render', '', 'images/picV/bj0.jpg', func('svidan_strings', 'local_str10')
		gs 'zz_dynamic_sex', 'bj'
		act 'Продолжать сосать':
			*clr & cla
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render', '', 'images/picV/swallow.jpg', func('svidan_strings', 'local_str11')
			act 'Уйти': gt 'street'
		end
		act 'Вынуть изо рта':
			*clr & cla
			if harakBoyA = 0:
				gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
			elseif harakBoyA = 1:
				if RAND(0,3) < 3:
					gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
				else
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str14')
				end
			elseif harakBoyA = 2:
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str15')
			end
			act 'Уйти': gt 'street'
		end
	end
end
if $ARGS[0] = 'carA':
	*clr
	minut += 20
	gs 'zz_render', '', '', func('svidan_strings', 'local_str16')
	act 'Секс':
		*clr & cla
		bfA += 1
		if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
		sex += 1
		minut += 30
		pose = 0
		$boy = $boyA
		dick = dickA
		silavag = silavagA
		gs 'zz_render', '', 'images/picV/vag.jpg', func('svidan_strings', 'local_str17')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Уйти': gt 'street'
	end
	act 'Взять в рот':
		*clr & cla
		bfA += 1
		if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
		bj += 1
		dick = dickA
		harakBoy = harakBoyA
		minut += 30
		$boy = $boyA
		gs 'zz_render', '', 'images/picV/bj0.jpg', func('svidan_strings', 'local_str10')
		gs 'zz_dynamic_sex', 'bj'
		act 'Продолжать сосать':
			*clr & cla
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render', '', 'images/picV/swallow.jpg', func('svidan_strings', 'local_str11')
			act 'Уйти': gt 'street'
		end
		act 'Вынуть изо рта':
			*clr & cla
			if harakBoyA = 0:
				gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
			elseif harakBoyA = 1:
				if RAND(0,3) < 3:
					gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
				else
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str14')
				end
			elseif harakBoyA = 2:
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str15')
			end
			act 'Уйти': gt 'street'
		end
	end
end
if $ARGS[0] = 'hisA':
	*clr
	minut += 20
	gs 'zz_render', '', '', func('svidan_strings', 'local_str24')
	act 'Секс':
		*clr & cla
		bfA += 1
		if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
		sex += 1
		minut += 30
		pose = 0
		$boy = $boyA
		dick = dickA
		silavag = silavagA
		gs 'zz_render', '', 'images/picV/vag.jpg', func('svidan_strings', 'local_str17')
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Уйти': gt 'street'
	end
	act 'Взять в рот':
		*clr & cla
		bfA += 1
		if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
		bj += 1
		dick = dickA
		harakBoy = harakBoyA
		minut += 30
		$boy = $boyA
		gs 'zz_render', '', 'images/picV/bj0.jpg', func('svidan_strings', 'local_str10')
		gs 'zz_dynamic_sex', 'bj'
		act 'Продолжать сосать':
			*clr & cla
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render', '', 'images/picV/swallow.jpg', func('svidan_strings', 'local_str11')
			act 'Уйти': gt 'street'
		end
		act 'Вынуть изо рта':
			*clr & cla
			if harakBoyA = 0:
				gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
			elseif harakBoyA = 1:
				if RAND(0,3) < 3:
					gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
				else
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str14')
				end
			elseif harakBoyA = 2:
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str15')
			end
			act 'Уйти': gt 'street'
		end
	end
end
if $ARGS[0] = 'kvartA':
	*clr
	minut += 20
	if housr > 0: housrA = 1
	gs 'zz_render', '', '', func('svidan_strings', 'local_str24')
	if husband = 0:
		act 'Секс':
			*clr & cla
			bfA += 1
			if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
			sex += 1
			minut += 30
			pose = 0
			$boy = $boyA
			dick = dickA
			silavag = silavagA
			gs 'zz_render', '', 'images/picV/vag.jpg', func('svidan_strings', 'local_str17')
			gs 'zz_dynamic_sex', 'sex_start'
			gs 'zz_dynamic_sex', 'vaginal', 'dick'
			gs 'zz_dynamic_sex', 'sex_cum'
			act 'Проводить до дверей': gt 'korr'
		end
		act 'Взять в рот':
			*clr & cla
			bfA += 1
			if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
			bj += 1
			dick = dickA
			harakBoy = harakBoyA
			minut += 30
			$boy = $boyA
			gs 'zz_render', '', 'images/picV/bj0.jpg', func('svidan_strings', 'local_str10')
			gs 'zz_dynamic_sex', 'bj'
			act 'Продолжать сосать':
				*clr & cla
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_render', '', 'images/picV/swallow.jpg', func('svidan_strings', 'local_str11')
				act 'Проводить до дверей': gt 'korr'
			end
			act 'Вынуть изо рта':
				*clr & cla
				if harakBoyA = 0:
					gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
				elseif harakBoyA = 1:
					if RAND(0,3) < 3:
						gs 'zz_render', '', 'images/picV/hand.jpg', func('svidan_strings', 'local_str12')
					else
						gs 'zz_funcs', 'cum', 'face'
						gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str14')
					end
				elseif harakBoyA = 2:
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/facial.jpg', func('svidan_strings', 'local_str15')
				end
				act 'Проводить до дверей': gt 'korr'
			end
			act 'Подрочить ему':
				*clr & cla
				if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
				DOM += 1
				hj += 1
				minut += 30
				horny += DOM
				gs 'zz_render', '', 'images/picV/hand1.jpg', func('svidan_strings', 'local_str40')
				bfA -= iif(harakBoyA=0,1,harakBoyA*5)
				act 'Вытереть руки и проводить до дверей': gt 'korr'
			end
			if DOM > 1 and kunday ! day and mesec <= 0:
				act 'Куни':
					*clr & cla
					kunday = day
					if boyonceA = 0: boyonceA = 1 & guy += 1 & vneshBoyA += 10
					DOM += 1
					kuni += 1
					minut += 30
					horny += DOM + (silaVag*2 + 5)
					gs 'zz_render', '', 'images/picV/kuni.jpg', func('svidan_strings', 'local_str41')
					bfA -= iif(harakBoyA=0,1,harakBoyA*5)
					if horny >= 90:
						horny = 0
						manna += 15
						orgasm += 1
						gs 'zz_render', '', '', func('svidan_strings', 'local_str42')
					else
						gs 'zz_render', '', '', func('svidan_strings', 'local_str43')
					end
				end
				act 'Дальше':
					cla
					gt'svidan','kvartA'
				end
			end
		end
	end
end