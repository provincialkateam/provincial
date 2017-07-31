if $args[0] = 'bj':
	lipkoef += 1
	if lipkoef > 50:
		lipkoef = 0
		lip += 1
	end
	gs 'stat'
	$_str[0] = 'Вы обхватили своими <<$liptalk>> его член. '
	$_str[1] = 'Вы обхватили своими <<$liptalk>> багровую головку его члена. '
	$_str[2] = 'Вы провели своими <<$liptalk>> по головке члена и вобрали его в свой ротик. '
	$_str[3] = 'Его член уперся вам в ваши <<$liptalk3>>, вы приоткрыли их и впустили член в свой рот. '
	$_str[4] = 'Ваш ротик оказался быстро заполнен чуть солоноватым и твердым членом который вы начали сосать. '
	$_str[5] = 'В ваш ротик вошел твердый и горячий член который вы начали сосать. '
	$_str[6] = 'Твердый член заполнял весь ваш рот, обхватывая его губами вы каждым движением его вбирали до горла. '
	$_str[7] = 'Парень закрыл глаза от удовольствия и наслаждается лаской ваших губ.'
	$_str[8] = 'Парень смотрит вам в лицо пока ваши губы скользят по его напряженному члену.'
	$_str[9] = 'Парень взял вас за волосы и стал трахать вас в рот, '+iif(throat <= dick,'от ударов члена в горло у вас потекли слезы из глаз.','но ваше горло уже достаточно тренировано, и поэтому вы только пошире открываете рот, давая парню полный доступ.')
	i = rand(4,6)
	gs 'zz_render','','',$_str[rand(0,3)] + $_str[i] + $_str[i+3]
	killvar '$_str'
	if i = 6 and throat <= dick:
		if mop > 1: mop = 0 & vidageday -= 1
		throat += 1
	end
	if horny >= 100 and swallow >= 100:
		orgasm += 1
		horny = 0
		manna += 15
		gs 'zz_render','','','Неожиданно для вас отсасывая член вы начали кончать сами. Между ног полыхал пожар и волны удовольствия охватывали тело, вы стонали но не выпускали член изо рта продолжая его отсасывать.'
	end
end
if $args[0] = 'swallow':
	swallow += 1
	gs 'zz_funcs', 'cum', 'lip'
	water -= 1
	gs 'stat'
	$_str[0] = 'Внезапно в ваш рот стрельнула струя вязкого семени. '
	$_str[1] = 'Член дернулся и струя спермы влетела между ваших губ вам в рот. '
	$_str[2] = 'Ваш рот наполнился спермой когда член между ваших губ начал кончать. '
	$_str[3] = 'Ваш ротик быстро заполнился теплой спермой и вы чувствовали ее резкий вкус. '
	$_str[4] = 'Сперма наполнила ваш рот и стала стекать по вашим <<$liptalk2>>. '
	$_str[5] = 'Горячее семя быстро наполнило ваш рабочий рот заставляя прочувствовать всю гамму вкуса терпкой и резкой спермы. '
	$_str[6] = 'Вы сглотнули и проглотили сперму находящуюся в вашем рабочем ротике. Во рту остался вкус спермы и чувствовался ее запах.'
	$_str[7] = 'Вы проглотили теплую сперму наполнявшую ваш рот и облизали свои <<$liptalk3>> слизывая остатки семени с них.'
	$_str[8] = 'Вы проглотили вязкую сперму заполнявшую ваш рабочий рот, после чего облизнулись.'
	gs 'zz_render','','',$_str[rand(0,2)] + $_str[rand(3,5)] + $_str[rand(6,8)]
	killvar '$_str'
end
if $args[0] = 'sex_start':
	if args[1] = 0: protect = 0
	if vibratorIN = 1:
		vibratorIN = 0
		gs 'zz_render','','', 'Вы вынули вибратор из влагалища.'
	end
	if prezik > 0 and protect = 0:
		prezik -= 1
		protect = 1
		lubonus += 1
		gs 'zz_render','','','<<$boy>> взял у вас презерватив и одел его на свой член.'
	end
	if horny/10 + vagina + alko < dick and lubri > 0:
		lubri -= 1
		lubonus += 5
		gs 'zz_render','','',iif(rand(1,2) = 1,'Вы выдавили лубрикант себе на руку и начали смазывать им свою вагину.','Выдавив лубрикант себе на руку, вы начали тщательно смазывать им свою вагину.')
	end
end
if $args[0] = 'vaginal':
	if cumpussy > 0:lubonus += 2
	if vibratorIN = 1:
		vibratorIN = 0
		gs 'zz_render','','', 'Вы вынули вибратор из влагалища.'
	end
	if vagina = 0:
		horny = 0
		manna -= 15
		vagina += 1
		vgape = 3
		$zz_str[0] = 'Вы закусили губу от боли и из глаз брызнули слезы когда '
		$zz_str[1] = ' в вас, разорвав вашу девственную плеву. Вы заплакали от боли и '
		if $args[1]= 'dick':
			if pose = 2:
				$_finalize = $zz_str[0]+'сели на член и почувствовали как <<$boy>> вошел'+$zz_str[1]+' продолжили прыгать на крепком члене своей окровавленной киской.'
			else
				$_finalize = $zz_str[0]+'<<$boy>> вошел в вас, разорвав вашу девственную плеву. Вы плачете и стонете пока крепкий член трахает вашу окровавленную киску.'
			end
		end
		if $args[1]= 'dildo': $_finalize = $zz_str[0]+'<<dick>> сантиметровый дилдо вошел'+$zz_str[1]+'вынули из себя окровавленный дилдо.'
		if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<dick>> сантиметровый страпон вошел'+$zz_str[1]+'<<$boy>> вынула из вас окровавленный страпон.'
		if $args[1]= 'bottle': $_finalize = $zz_str[0]+'бутылка вошла'+$zz_str[1]+'вынули из себя окровавленную бутылку.'
		if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'бутылка вошла'+$zz_str[1]+'<<$boy>> вынула из вас окровавленную бытылку.'
	elseif mesec > 0 and vagina > 0:
		!месячные, оргазм не возможен
		horny = 0
		manna -= 10
		if vagina < dick:
			if vagina*2 < dick:
				if vgape < 3:vgape = 3
			else
				if vgape < 2:vgape = 2
			end
		else
			if vgape < 1:vgape = 1
		end
		$zz_str[0] = 'У вас месячные и в то время пока '
		$zz_str[1] = ', из влагалища потихоньку вытекает кровь.'
		$zz_str[2] = ' Ощущения болезненные и неприятные. Вы стонете пока крепкий член '
		if $args[1]= 'dick':
			if $args[2]= 'horse':
				$_finalize = $zz_str[0]+'прыгаете на члене'+$zz_str[1]+$zz_str[2]+'входит в вас.'
			else
				$_finalize = $zz_str[0]+'член таранит вас'+$zz_str[1]+$zz_str[2]+'трахает вашу киску.'
			end
		end
		if $args[1]= 'dildo': $_finalize = $zz_str[0]+'вы засовываете в себя <<dick>> сантиметровый дилдо'+$zz_str[1]
		if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<$boy>> вгоняет в вашу киску <<dick>> сантиметровый страпон'+$zz_str[1]
		if $args[1]= 'bottle': $_finalize = $zz_str[0]+'вы засовываете в себя бутылку'+$zz_str[1]
		if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'<<$boy>> вгоняет в вашу киску бутылку'+$zz_str[1]
	elseif mesec <= 0 and vagina > 0:
		!месячных нет
		!horny - возбужденность
		!vagina - эластичность вагины
		!silavag - умение парня 0-неумеха, 1-середняк 2-ебарь
		!dick - размер члена парня
		!orgazm - коэфициент удовольствия Итог
		!0 - очень больно, 1 - больно, 2 - не приятно, 3 - так себе, 4 - недооргазм 5 - оргазм
		prinat = horny/10 + vagina + alko + lubonus
		if dick >= prinat*2:
			!член критично больше возможностей гг
			if silavag = 0:orgazm = 0
			if silavag = 1:orgazm = 1
			if silavag = 2:orgazm = 2
		elseif dick < prinat*2 and dick > prinat:
			!член больше возможностей гг
			if silavag = 0:
				if horny < 60: orgazm = 0
				if horny >= 60 and horny < 100: orgazm = horny / 10 - 5
				if horny >= 100: orgazm = 5
			elseif silavag = 1:
				if horny < 50: orgazm = 0
				if horny >= 50 and horny < 90: orgazm = horny / 10 - 4
				if horny >= 90: orgazm = 5
			elseif silavag = 2:
				if horny < 40: orgazm = 0
				if horny >= 40 and horny < 80: orgazm = horny / 10 - 3
				if horny >= 80: orgazm = 5
			end
		elseif dick <= prinat and dick >= vagina:
			!член меньше возможностей гг
			if silavag = 0:
				if horny < 40: orgazm = 2
				if horny >= 40 and horny < 80: orgazm = horny / 20 + 1
				if horny >= 80: orgazm = 5
			elseif silavag = 1:
				if horny < 30: orgazm = 2
				if horny >= 30 and horny < 70: orgazm = (horny + 10) / 20 + 1
				if horny >= 70: orgazm = 5
			elseif silavag = 2:
				if horny < 20: orgazm = 2
				if horny >= 20 and horny < 60: orgazm = horny / 20 + 2
				if horny >= 60: orgazm = 5
			end
		elseif dick <= prinat and dick < vagina:
			if silavag = 0:
				if horny >= 100:orgazm = 5
				if horny >= 90 and horny < 100:orgazm = 4
				if horny < 90:orgazm = 6
			elseif silavag = 1:
				if horny >= 90:orgazm = 5
				if horny >= 80 and horny < 90:orgazm = 4
				if horny < 80:orgazm = 6
			elseif silavag = 2:
				if horny >= 80:orgazm = 5
				if horny >= 70 and horny < 80:orgazm = 4
				if horny < 70:orgazm = 6
			end
		end
		if orgazm = 0:
			vgape = 3
			horny = 0
			manna -= 15
			if mop > 1: mop = 0 & vidageday -= 1
			$zz_str[0] = 'Вы застонали от боли когда '
			$zz_str[1] = ', из глаз потекли слезы и между ног ощущение как будто вам вогнали раскаленный прут.'
			if $args[1]= 'dick':
				if $args[2]= 'horse':
					$_finalize = $zz_str[0]+'сели на член и почувствовали как <<$boy>> вошел в вас своим членом'+$zz_str[1]
				else
					$_finalize = $zz_str[0]+'<<$boy>> вошел в вас'+$zz_str[1]+'Вы плачете и стонете пока крепкий член трахает вашу киску.'
				end
			end
			if $args[1]= 'dildo': $_finalize = $zz_str[0]+'засунули в себя дилдо'+$zz_str[1]
			if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас страпон'+$zz_str[1]
			if $args[1]= 'bottle': $_finalize = $zz_str[0]+'засунули в себя бутылку'+$zz_str[1]
			if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас бутылку'+$zz_str[1]
		elseif orgazm = 1:
			if vgape < 2: vgape = 2
			horny -= 10
			manna -= 10
			$zz_str[0] = 'Вы закусили губу от боли когда '
			$zz_str[1] = ', между ног болезненные ощущения.'
			if $args[1]= 'dick':
				if $args[2]= 'horse':
					$_finalize = $zz_str[0]+'сели на член и почувствовали как <<$boy>> вошел в вас'+$zz_str[1]+' Вы морщитесь и стонете от боли пока прыгаете на крепком члене.'
				else
					$_finalize = $zz_str[0]+'<<$boy>> вошел в вас'+$zz_str[1]+' Вы морщитесь и стонете от боли пока крепкий член трахает вашу киску.'
				end
			end
			if $args[1]= 'dildo': $_finalize = $zz_str[0]+'засунули в себя <<dick>> сантиметровый дилдо'+$zz_str[1]
			if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас <<dick>> сантиметровый страпон'+$zz_str[1]
			if $args[1]= 'bottle': $zz_str[0]+'засунули в себя бутылку'+$zz_str[1]
			if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас бутылку'+$zz_str[1]
		elseif orgazm = 2:
			if vgape < 1: vgape = 1
			horny -= 5
			manna -= 5
			$zz_str[0] = 'Вы вздрогнули от внезапной боли когда '
			$zz_str[1] = ', но болезненные ощущения между ног плавно успокаиваются и становятся вполне сносными. Вы пытаетесь возбудиться пока '
			$zz_str[2] = ' в вашей киске, но у вас ничего не выходит.'
			if $args[1]= 'dick':
				if pose = 2:
					$_finalize = $zz_str[0]+'сели на член и почувствовали как <<$boy>> вошел в вас'+$zz_str[1]+'крепкий член двигается'+$zz_str[2]
				else
					$_finalize = $zz_str[0]+'<<$boy>> вошел в вас'+$zz_str[1]+'крепкий член трахает вашу киску, но у вас ничего не выходит.'
				end
			end
			if $args[1]= 'dildo': $_finalize = $zz_str[0]+'засунули в себя <<dick>> сантиметровый дилдо'+$zz_str[1]+'двигаете <<dick>> сантиметровый дилдо'+$zz_str[2]
			if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас <<dick>> сантиметровый страпон'+$zz_str[1]+'<<$boy>> двигает <<dick>> сантиметровый страпон'+$zz_str[2]
			if $args[1]= 'bottle': $_finalize = $zz_str[0]+'засунули в себя бутылку'+$zz_str[1]+'двигаете бутылку'+$zz_str[2]
			if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас бутылку'+$zz_str[1]+'<<$boy>> двигает бутылкой'+$zz_str[2]
		elseif orgazm = 3:
			manna += 5
			horny += 5
			$zz_str[0] = 'Вы вздрогнули от ощущения, что ваша киска растягивается, когда '
			$zz_str[1] = ' Между ног становится немного приятно, когда '
			if $args[1]= 'dick':
				if $args[2]= 'horse':
					$_finalize = $zz_str[0]+'сели на член и почувствовали как <<$boy>> вошел в вас.'+$zz_str[1]+'вы прыгаете на крепком члене.'
				else
					$_finalize = $zz_str[0]+'<<$boy>> вошел в вас'+$zz_str[1]+'крепкий член трахает вашу киску.'
				end
			end
			if $args[1]= 'dildo': $_finalize = $zz_str[0]+'засунули в себя дилдо. '+$zz_str[1]+'вы трахаете себя при помощи дилдо.'
			if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас страпон.'+$zz_str[1]+'<<$boy>> трахает вас страпоном.'
			if $args[1]= 'bottle': $_finalize = $zz_str[0]+'засунули в себя бутылку. '+$zz_str[1]+'вы трахаете себя при помощи бутылки.'
			if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас бутылку.'+$zz_str[1]+'<<$boy>> трахает вас бутылкой.'
		elseif orgazm = 4:
			manna += 10
			horny += 10
			$zz_str[0] = 'Вы вздрогнули от ощущения, что ваша киска растягивается, когда '
			$zz_str[1] = '. Между ног становится немного приятно, когда '
			$zz_str[2] = '. Постепенно приятное тепло и пульсация нарастают в низу живота, потом ощущения чуть уменьшаются и остаются до конца.'
			if $args[1]= 'dick':
				if $args[2]= 'horse':
					$_finalize = $zz_str[0]+'сели на член и почувствовали как <<$boy>> вошел в вас'+$zz_str[1]+'вы прыгаете на крепком члене'+$zz_str[2]
				else
					$_finalize = $zz_str[0]+'<<$boy>> вошел в вас'+$zz_str[1]+'крепкий член трахает вашу киску'+$zz_str[2]
				end
			end
			if $args[1]= 'dildo': $_finalize = $zz_str[0]+'засунули в себя <<dick>> сантиметровый дилдо'+$zz_str[1]+'вы трахаете себя при помощи дилдо'+$zz_str[2]
			if $args[1]= 'strapon': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас <<dick>> сантиметровый страпон'+$zz_str[1]+'<<$boy>> трахает вас при помощи страпона'+$zz_str[2]
			if $args[1]= 'bottle': $_finalize = $zz_str[0]+'засунули в себя бутылку'+$zz_str[1]+'вы трахаете себя при помощи бутылки'+$zz_str[2]
			if $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'<<$boy>> засунула в вас бутылку.'+$zz_str[1]+'<<$boy>> трахает вас при помощи бутылки'+$zz_str[2]
		elseif orgazm = 5:
			horny = 0
			manna = 100
			orgasm += 1
			vaginalOrgasm += 1
			hapri = 0
			$zz_str[0] = 'Вы вздрогнули от приятного ощущения, когда ваша киска начала растягиваться принимая в себя '
			$zz_str[1] = '. Между ног становится очень тепло и приятно, когда '
			$zz_str[2] = ' двигается в вашей киске. Постепенно приятное тепло и пульсация нарастают в низу живота, потом ощущения обрушиваются на вас и всё ваше тело охватывают горячие волны оргазма, вы невольно кричите от удовольствия извиваясь на '
			if $args[1]= 'dick': $_finalize = $zz_str[0]+'член'+$zz_str[1]+'крепкий член'+$zz_str[2]+'елде.'
			if $args[1]= 'dildo': $_finalize = $zz_str[0]+'дилдо'+$zz_str[1]+'<<dick>> сантиметровый дилдо'+$zz_str[2]+'дилдо.'
			if $args[1]= 'strapon': $_finalize = $zz_str[0]+'страпон'+$zz_str[1]+'крепкий <<dick>> сантиметровый страпон'+$zz_str[2]+'страпоне.'
			if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize = $zz_str[0]+'бутылку'+$zz_str[1]+'бутылка'+$zz_str[2]+'бутылке.'
		elseif orgazm = 6:
			horny += 5
			manna += 5
			if $args[1]= 'dick': $zz_str[0] = 'член'
			if $args[1]= 'dildo': $zz_str[0] = 'дилдо'
			if $args[1]= 'strapon': $zz_str[0] = 'страпон'
			if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $zz_str[0] = 'бутылка'
			$_finalize = 'Вы почувствовали как '+$zz_str[0]+' проникает в вашу киску. Между ног приятно, но '+$zz_str[0]+' значительно меньше вашей киски и ее для вас мало.**Постепенно приятное тепло и пульсация нарастают в низу живота, потом ощущения чуть уменьшаются и остаются до конца.'
		end
	end
	if dick > vagina: vagina += 1
	vgapetime = totminut + (vgape + 1) * 1440
	lubonus = 0
	if args[2] = 0: sex += 1
	if $args[1] ! 'dick': protect = 0
	gs 'zz_render','','',$_finalize
	killvar '$zz_str'
	killvar '$_finalize'
end
if $args[0] = 'sex_cum':
	if protect = 0:
		!не защищенный секс
		if RAND(0,1) = 0:
			!внутрь
			cum_text = rand(0,2)
			if cum_text = 0: $cum_text = 'Наконец движения  парня ускоряются и, загнав напоследок по самые яйца, с блаженной улыбкой он кончил глубоко в вас. Вы ощутили как теплая жикдость разливается по вашим внутренностям.'
			if cum_text = 1: $cum_text = '<<$boy>> не стал тянуть и кончил прямо в вас так, что из вашей <<$vaginatipe3>> вагины с чавканьем вылетели брызги спермы.'
			if cum_text = 2: $cum_text = '<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
			gs 'zz_render', '', '', $cum_text
			gs 'zz_funcs', 'cum', 'pussy'
		else
			!наружу
			if pose = 0:
				gs 'zz_funcs', 'cum', 'belly'
				gs 'zz_render', '', '','<<$boy>> застонал и вынув член из вас, кончил на ваш живот.'
			else
				gs 'zz_funcs', 'cum', 'ass'
				gs 'zz_render', '', '','<<$boy>> застонал и вынув член из вас, кончил на вашу попу.'
			end
		end
	else
		protect = 0
		gs 'zz_render', '', '','<<$boy>> застонал и вы поняли, что он кончил в презерватив.'
		if RAND(0,100) = 0:
			gs 'zz_render', '', '','Вынув из вас член <<$boy>> сказал:\\\- Хмм, презерватив лопнул...///'
			gs 'zz_funcs', 'cum', 'pussy'
		end
	end
	pose = 0
	killvar '$cum_text'
end
if $args[0] = 'anal_start':
	$_finalize = ''
	if prezik > 0 and protect = 0 and args[2] ! 0:
		prezik -= 1
		protect = 1
		lubonus += 1
		gs 'zz_render','','','<<$boy>> взял у вас презерватив и одел его на свой <<dick>> сантиметровый член.'
	end
	if analplugin = 1:
		analpluginbonus = 5
		analplugin = 0
		gs 'zz_render','','', 'Вы вытащили из вашей <<$anustipe3>> попки анальную пробку.'
	end
	if lubri > 0:
		lubri -= 1
		lubonus += 5
		$zz_str[0] = 'Вы выдавили анальной смазки себе на руку и начали намазывать свою попку. '
		if $args[1]= 'dick' or $args[1]= '': $_finalize += $zz_str[0] + 'После этого вы дали парню тюбик и он намазал свой член смазкой.'
		if $args[1]= 'dildo' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + 'После этого вы немного смазали дилдо.'
		if $args[1]= 'strapon': $_finalize += $zz_str[0] + 'После этого <<$boy>> смазала страпон.'
		if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize += $zz_str[0] + 'После этого вы немного смазали бутылку.'
	end
	gs 'zz_render','','',$_finalize
	killvar '$zz_str'
end
if $args[0] = 'anal':
	! $zz_str - временная переменная для описания
	$_finalize = ''
	if analplugin = 1:
		analpluginbonus = 5
		analplugin = 0
		$zz_str[0] = 'Вы вытащили из вашей <<$anustipe3>> попки анальную пробку.'
		if $args[1]= 'dick': $_finalize = '<<$boy>> вытащил из вашей <<$anustipe3>> попки анальную пробку.'
		if $args[1]= 'dildo' or $args[1]= 'girl_dildo' or $args[1]= 'strapon' or $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize = $zz_str[0]
	end
	$zz_str[0] = ' массировать анальное отверстие пальцами, сначала одним, потом двумя.'
	$zz_str[1] = 'Вы раздвинув свои ягодицы стали'
	if $args[1]= 'dick': $_finalize += '<<$boy>> раздвинув ваши ягодицы стал' + $zz_str[0]
	if $args[1]= 'dildo' or $args[1]= 'bottle': $_finalize += $zz_str[1] + $zz_str[0]
	if $args[1]= 'strapon' or $args[1]= 'girl_dildo' or $args[1]= 'girl_bottle': $_finalize += '<<$boy>> раздвинув ваши ягодицы стала' + $zz_str[0]
	if cumanus > 0: lubonus += 2
	if klismaday = day: lubonus += 1
	if anus < 10:anus += 1
	if anus >= 10:
		$zz_str[0] = 'Потом вы ввели себе три пальца и начали растягивать анус.'
		if $args[1]= 'dick': $_finalize += 'Потом парень ввел вам три пальца и начал растягивать ваш анус.'
		if $args[1]= 'dildo' or $args[1]= 'bottle': $_finalize += $zz_str[0]
		if $args[1]= 'strapon' or $args[1]= 'girl_bottle': $_finalize += 'Потом <<$boy>> ввела вам три пальца и начала растягивать анус.'
	else
		$_finalize += 'Когда в вашу попку вошло три пальца вы невольно застонали от боли.'
	end
	$zz_str[0] = 'Вы вытащили пальцы из своей попы и приставили '
	if $args[1]= 'dick': $_finalize += '<<$boy>> вытащил пальцы из вашей попы и вы почувствовали как его твердый член уперся в вашу дырочку.'
	if $args[1]= 'dildo': $_finalize += $zz_str[0]+'дилдо к своей дырочке.'
	if $args[1]= 'bottle': $_finalize += $zz_str[0]+'бутылку к своей дырочке.'
	if $args[1]= 'strapon' or $args[1]= 'girl_bottle' or $args[1]= 'girl_dildo': $_finalize += '<<$boy>> вытащила пальцы из вашей попы и приставила '+iif($args[1]= 'strapon','страпон',iif($args[1]= 'girl_bottle','бутылку','дилдо'))+' к вашей дырочке.'
	if anus + lubonus + analpluginbonus + alko < dick:
		$zz_str[0] = 'Вы взвизгнули и закусили губы от резкой боли когда '
		$zz_str[1] = ' раздвинув вашу попку вошел в вас.'
		if $args[1]= 'dick': $_finalize += $zz_str[0] + 'его член' + $zz_str[1]
		if $args[1]= 'dildo' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + '<<dick>> сантиметровый дилдо' + $zz_str[1]
		if $args[1]= 'strapon': $_finalize += $zz_str[0] + '<<dick>> сантиметровый страпон' + $zz_str[1]
		if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize += $zz_str[0] + 'бутылка' + $zz_str[1]
	end
	if anus + lubonus + analpluginbonus + alko >= dick:
		$zz_str[0] = 'Вы застонали от чувства переполненности когда '
		$zz_str[1] = ' раздвинув вашу попку вошел в вас.'
		if $args[1]= 'dick': $_finalize += $zz_str[0] + 'его член' + $zz_str[1]
		if $args[1]= 'dildo' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + '<<dick>> сантиметровый дилдо' + $zz_str[1]
		if $args[1]= 'strapon': $_finalize += $zz_str[0] + '<<dick>> сантиметровый страпон' + $zz_str[1]
		if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize += $zz_str[0] + 'бутылка' + $zz_str[1]
	end
	$zz_str[0] = ' попе приспособится к торчащему в ней '
	$zz_str[1] = ' водить им всё настойчивей, растягивая ваш анус.'
	if $args[1]= 'dick': $_finalize += '<<$boy>> замер на минуту, давая вашей'+ $zz_str[0] +'члену, после чего начал' + $zz_str[1]
	if $args[1]= 'dildo': $_finalize += 'Вы замерли на минуту, давая своей' + $zz_str[0] + 'дилдо, после чего начали' + $zz_str[1]
	if $args[1]= 'strapon' or $args[1]= 'girl_bottle' or $args[1]= 'girl_dildo': $_finalize += '<<$boy>> замерла на минуту, давая вашей'+ $zz_str[0] + iif($args[1]= 'strapon','страпону',iif($args[1]= 'girl_bottle','горлышку бутылки','дилдо'))+', после чего начала' + $zz_str[1]
	if $args[1]= 'bottle': $_finalize += 'Вы замерли на минуту, давая своей'+ $zz_str[0] + ' горлышку бутылки, после чего начали водить ей все настойчивей, растягивая свой анус.'
	if anus + lubonus + analpluginbonus + alko < dick:
		if mop > 1: mop = 0 & vidageday -= 1
		horny -= 20
		manna -= 20
		agape = 3
		$zz_str[0] = 'Вашу попу пронзила острая боль когда '
		if $args[1]= 'dick': $_finalize += $zz_str[0] + 'член начал трахать её на полную силу. В попе всё горит огнем и вы мечтаете только о том, чтобы эта пытка побыстрее кончилась.'
		if $args[1]= 'dildo' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + 'вы начали двигать в своей попе <<dick>> сантиметровый дилдо.'
		if $args[1]= 'strapon' or $args[1]= 'girl_bottle' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + '<<$boy>> начала трахать вашу попу при помощи '+iif($args[1]= 'strapon','<<dick>> сантиметрового страпона',iif($args[1]= 'girl_bottle','бутылки','дилдо'))+'.'
		if $args[1]= 'bottle': $_finalize += $zz_str[0] + 'вы начали двигать в своей попе бутылку.'
	elseif anus + lubonus + analpluginbonus + alko >= dick:
		horny += 10
		if agape < 2: agape = iif(lubonus = 0,2,1)
		$zz_str[0] = 'Вы начали ритмично стонать в такт движениям '
		$zz_str[1] = ' Вы чувствуете как ваш анус растягивается когда '
		if $args[1]= 'dick': $_finalize += $zz_str[0] + 'члена внутри вас.' + $zz_str[1] + 'член входит в вас.'
		if $args[1]= 'dildo' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + '<<dick>> сантиметрового дилдо внутри вас.' + $zz_str[1] + 'дилдо двигается внутри попки.'
		if $args[1]= 'strapon': $_finalize += $zz_str[0] + '<<dick>> сантиметрового страпона внутри вас.' + $zz_str[1] + 'страпон двигается внутри попки.'
		if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize += $zz_str[0] + 'бутылки внутри вас.' + $zz_str[1] + 'бутылка двигается внутри попки.'
		if horny >= 100 and anal >= 10 and orgasm > 0:
			manna = 100
			orgasm += 1
			horny = 0
			analorgasm += 1
			hapri = 0
			if agape < 1:agape = iif(lubonus = 0,1,0)
			$zz_str[0] = 'Вам становится очень приятно, когда '
			$zz_str[1] = ' движется внутри вашей попки. В анусе полыхает пожар и волны удовольствия охватывают ваше тело. Вы стонете и сами насаживаетесь попкой на член, сотрясаясь от охватившего вас оргазма.'
			if $args[1]= 'dick': $_finalize += $zz_str[0] + 'член' + $zz_str[1]
			if $args[1]= 'dildo' or $args[1]= 'girl_dildo': $_finalize += $zz_str[0] + 'дилдо' + $zz_str[1]
			if $args[1]= 'strapon': $_finalize += $zz_str[0] + 'страпон' + $zz_str[1]
			if $args[1]= 'bottle' or $args[1]= 'girl_bottle': $_finalize += $zz_str[0] + 'бутылка' + $zz_str[1]
		end
	end
	if dick > anus:anus += 1
	lubonus = 0
	analpluginbonus = 0
	gs 'zz_render','','',$_finalize
	agapetime = totminut + (agape + 1) * 1440
	if args[2] = 0: anal += 1
	killvar '$zz_str'
	gs 'stat'
end
if $args[0] = 'anal_cum':
	if protect = 0:
		!не защищенный секс
		!внутрь
		cum_text = rand(0,2)
		if cum_text = 0: $cum_text = 'Наконец движения  парня ускоряются и, загнав напоследок по самые яйца, он кончил глубоко в вас. Вы ощутили как теплая жикдость разливается по вашим внутренностям.'
		if cum_text = 1: $cum_text = '<<$boy>> не стал тянуть и кончил в вашу <<$anustipe2>> попу, заливая внутренности своим вязким семенем.'
		if cum_text = 2: $cum_text = 'Через некоторое время <<$boy>> застонал и вы почувствовали как вашу попу наполняет тепло.'
		gs 'zz_render', '', '', $cum_text
		gs 'zz_funcs', 'cum', 'anus'
	else
		protect = 0
		gs 'zz_render', '', '','<<$boy>> застонал и вы поняли, что он кончил в презерватив.'
	end
	pose = 0
	killvar '$cum_text'
end
if $args[0] = 'dp_start':
	if args[1] = 0: protect = 0
	if prezik > 0 and protect = 0:
		prezik -= 1
		protect = 1
		lubonus_v += 1
		gs 'zz_render','','','<<$boy>> взял у вас презерватив и одел его на свой <<dick>> сантиметровый член.'
	end
	if analplugin = 1:
		analpluginbonus = 5
		analplugin = 0
		gs 'zz_render','','', 'Вы вытащили из вашей <<$anustipe3>> попки анальную пробку.'
	end
	if lubri > 0:
		lubri -= 1
		lubonus_a += 5
		gs 'zz_render', '', '', 'Выдавив анальной смазки себе на руку, вы начали смазывать им свою попку. После этого вы дали парню тюбик и он намазал свой член смазкой.'
	end
	if horny/10 + vagina + alko < dick and lubri > 0:
		lubri -= 1
		lubonus_v += 5
		gs 'zz_render','','',iif(rand(1,2) = 1,'Вы выдавили лубрикант себе на руку и начали намазывать парню член.','Парень взял у вас тюбик с лубрикантом и смазал свой член смазкой.')
	end
	killvar '$zz_str'
end
if $args[0] = 'double_penetration':
	if analplugin = 1:
		analpluginbonus = 5
		analplugin = 0
		gs 'zz_render', '', '', '<<$boy2>> вытащил из вашей <<$anustipe3>> попки пробку.'
	end
	if cumanus > 0: lubonus_a += 2
	if cumpussy > 0:lubonus_v += 2
	prinat = horny/10 + vagina + alko + lubonus_v
	if dick > prinat:
		!член больше возможностей гг
		vgape = 3
		DPvag = 2
	elseif dick <= prinat and dick >= vagina:
		!член меньше возможностей гг
		if vgape < 2: vgape = 2
		DPvag = 1
	elseif dick < vagina:
		if vgape < 1: vgape = 1
		DPvag = 0
	end
	if anus + lubonus_a + analpluginbonus + alko < dick2:
		agape = 3
		DPass = 2
	elseif anus + lubonus_a + analpluginbonus + alko < dick2 and anus + lubonus_a + analpluginbonus + alko >= dick2:
		if agape < 2: agape = 2
		DPass = 1
	elseif anus + lubonus_a + analpluginbonus + alko >= dick2:
		if agape < 1: agape = 1
		DPass = 0
	end
	if vagina = 0:
		horny = 0
		manna -= 15
		vgape = 3
		gs 'zz_render', '', '', 'Вы закусили губу от боли и из глаз брызнули слезы когда <<$boy>> вошел в вас, разорвав вашу девственную плеву.'
	end
	if mesec > 0 and vagina > 0:
		!месячные, оргазм не возможен
		horny = 0
		manna -= 10
		if vgape < 3: vgape += 1
		gs 'zz_render', '', '', 'У вас месячные и вам неприятно и больно, пока член первого парня таранит вашу кровоточащую вагину. Одновременно вы чувствуете как ваш <<$anustipe>> анус трахает второй член.'
	end
	vgapetime = totminut + (vgape + 1) * 1440
	agapetime = totminut + (agape + 1) * 1440
	totPAIN = DPvag + DPass + (agape-1) + (vgape-1)
	if totPAIN = 0:
		gs 'zz_render', '', '', 'Ощущения сливаются воедино, когда внутри вас двигаются два члена, соприкасаясь друг с другом через тоненькую стеночку, разделяющую ваше '+iif(vagina = 0,'окровавленное ','')+'влагалище и ваш <<$anustipe>> анус. Внизу живота горит приятный огонек распространяя тепло по всему телу.'
		DPplus = (vaginalOrgasm*10) + horny + manna
		DPminus = RAND(250,350)
		if DPplus > DPminus:
			vaginalOrgasm += 1
			DPorgasm += 1
			orgasm += 1
			manna = 100
			horny = 0
			vgape = 0
			agape = 0
			hapri = 0
			gs 'zz_render', '', '', 'Внезапно вас охватывает оргазм и вы, не помня себя, стонете и кричите, пока ваши мышцы судорожно сокращаются вокруг двух членов внутри вашего тела.'
		end
	elseif totPAIN = 1:
		gs 'zz_render', '', '', 'Ощущения сливаются воедино, когда внутри вас двигаются два члена, соприкасаясь друг с другом через тоненькую стеночку, разделяющую ваше '+iif(vagina = 0,'окровавленное ','')+'влагалище и ваш <<$anustipe>> анус. Немного больно, но все же очень приятно чувствовать как все свободные отверстия заполняются членами.'
	elseif totPAIN = 2:
		horny = horny/2
		manna = manna/2
		gs 'zz_render', '', '', 'Вы чуствуете себя так, как будто вот-вот готовы лопнуть от переполненности, когда внутри вас двигаются два члена, соприкасаясь друг с другом через тоненькую стеночку, разделяющую ваше '+iif(vagina = 0,'окровавленное ','')+'влагалище и ваш <<$anustipe>> анус. Ощущения очень странные, в один клубок смешалась боль, удовольствие и болезненная переполненность.'
	elseif totPAIN = 3:
		manna = manna/4
		horny = horny/4
		gs 'zz_render', '', '', 'Вам больно и иногда резкие вспышки боли заставляют вас застонать, когда внутри вас двигаются два члена, соприкасаясь друг с другом через тоненькую стеночку, разделяющую ваше '+iif(vagina = 0,'окровавленное ','')+'влагалищеи ваш <<$anustipe>> анус. Вы чувствуете себя готовой лопнуть, ваша попа и киска по ощущениям слились в один довольно болезненный комок. Ваши глаза не произвольно застилает пелена слез.'
	else
		manna = 0
		horny = 0
		if mop > 1: mop = 0 & vidageday -= 1
		gs 'zz_render', '', '', 'Вы визжите и слезы ручьем льются из ваших глаз от жуткой боли, весь ваш низ живота и попа отдает острой болью, пока вас трахает <<$boy>> '+iif(vagina = 0,'в окровавленное','во')+' влагалище и <<$boy2>> практически рвет ваш <<$anustipe>> анус своим орудием.'
	end
	if dick >= vagina:vagina += 2
	if dick2 >= anus:anus += 3
	if args[1] = 0:
		sex += 1
		anal += 1
	end
	lubonus_a = 0
	lubonus_v = 0
	gs'stat'
end