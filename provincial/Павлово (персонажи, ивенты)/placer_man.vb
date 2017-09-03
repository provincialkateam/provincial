if mass_ver_zn > 0:
	!расчет вероятности знакомства
	ver_zn = 0
	vn_ver = RAND(0,60)
	rand_vero = RAND(0,1)
	if vn_ver < vnesh and rand_vero = 0:ver_zn = 1
	if kol_man = 1: $kol_man_text = 'парень' & $kol_man_text_a = 'парня' & $kol_man_prefiks = '' & $kol_man_prefiks_he = 'Он'
	if kol_man = 2: $kol_man_text = 'два парня' & $kol_man_text_a = 'парней' & $kol_man_prefiks = 'и' & $kol_man_prefiks_he = 'Они'
	if kol_man = 3: $kol_man_text = 'три парня' & $kol_man_text_a = 'парней' & $kol_man_prefiks = 'и' & $kol_man_prefiks_he = 'Они'
	if kol_man = 4: $kol_man_text = 'четыре парня' & $kol_man_text_a = 'парней' & $kol_man_prefiks = 'и' & $kol_man_prefiks_he = 'Они'
	if kol_man = 5: $kol_man_text = 'пять парней' & $kol_man_text_a = 'парней' & $kol_man_prefiks = 'и' & $kol_man_prefiks_he = 'Они'
	if kol_man = 6: $kol_man_text = 'шесть парней' & $kol_man_text_a = 'парней' & $kol_man_prefiks = 'и' & $kol_man_prefiks_he = 'Они'
	$text_znak = ''
	!знаковые моменты
	if func('zz_reputation','get') > 0:
		if know_status = 0:
		end
		if know_status = 1:
			knowrand = RAND(0,1)
		end
		if know_status = 2:
			knowrand = RAND(0,4)
		end
		if knowrand >= 1:know_gor_slut = 1
	end
	if ver_zn = 0:
		if know_gor_slut = 1:
			if kol_man = 1:
				$text_znak = 'Парень заметно усмехнулся.'
			elseif kol_man > 1:
				$text_znak = 'Парни стали перешептываться "Эй, да это же <<$name[2]>> <<$gnikname>>"'
			end
		end
	elseif ver_zn = 1:
		if Frend_num = 0:
			slut_vid = 0
			if mop = 4: slut_vid += 1
			if pirsA > 0: slut_vid += 1
			if pirsB > 0: slut_vid += 1
			$txt_a = 'Привет'
			$txt_b = 'красавица'
			if know_status = 2:
				textrand = RAND(0,1)
				if textrand = 0:$txt_a = 'Хэллоу'
				if textrand = 1:$txt_a = 'Здорова'
				textrand2 = RAND(0,1)
				if textrand2 = 0:$txt_b = 'красавица'
				if textrand2 = 1:$txt_b = 'чикуля'
			end
			$text_znak = '<<$txt_a>> <<$txt_b>>'
		elseif Frend_num > 0 and dick = 0:
			$text_znak = 'Привет девченки!'
			if know_status = 2:$text_znak = 'Привет чикули!'
		end
	end
	if func('zz_clothing', 'get_group') = 12:
		randtext = RAND(0,5)
		if randtext = 0:$txt_a = 'Эй, шмара'
		if randtext = 1:$txt_a = 'Эй, шлюха'
		if randtext = 2:$txt_a = 'Эй, соска'
		if randtext = 3:$txt_a = 'Эй, девушка'
		if randtext = 4:$txt_a = 'Классная телка, эй'
		if randtext = 5:$txt_a = 'О! Проститутка,'
		randtext2 = RAND(0,5)
		if randtext2 = 0:$txt_b = 'почем минет?'
		if randtext2 = 1:$txt_b = 'за стольник возьмешь за щеку?'
		if randtext2 = 2:$txt_b = 'классный у тебя жопец'
		if randtext2 = 3:$txt_b = 'не плохие у тебя сиськи'
		if randtext2 = 4:$txt_b = 'ты на работе?'
		if randtext2 = 5:$txt_b = 'я гляжу у тебя рабочий ротик'
		$text_znak = '<<$txt_a>> <<$txt_b>>'
	end
end