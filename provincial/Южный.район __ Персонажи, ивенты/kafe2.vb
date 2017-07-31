$cafe_dance_act = {
	cla
	horny += 8
	if dick > 15 and dick < 18:
		$didanc = 'в штанах у него становится твердо и <<$boy>> прижимается к вашему животу своим вставшим членом.'
	elseif dick >= 18:
		$didanc = 'его член упираясь вам в живот твердеет и вырастает.'
	elseif dick <= 15:
		$didanc = 'в его штанах что-то увеличивается'
	end
	if $args[0] = 'kiss': 'Вы начали страстно обсасывать язык парня и целовать его своими <<$liptalk>>. Вы чувствуете как <<$didanc>>'
	if $args[0] = 'nokiss': 'Вы ведете себя пассивно и стараетесь убрать свой рот в сторону от назойливого языка парня, но это мало его останавливает и вы чувствуете как его ладони крепко сжимают вашу попку, потом его ладони поднимаются выше и он берет вас за грудь. Вы чувствуете как <<$didanc>>'
	gs 'zz_render', '', '', func('kafe_2_strings', 'local_str1')
	if rand(1,100) <= 75:
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str2')
		act 'Согласиться': gt'kafe3','дом'
	else
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str3')
		act 'Согласиться': gt'kafe3','туалет'
	end
	if horny < 75: act 'Отшить':gt'street'
}
if $ARGS[0] = 'танец':
	cla
	if dance < 50 and agil >= dance: dance += 1
	minut += 3
	gs 'stat'
	'<center><img src="images/pic/dance.jpg"></center>'
	deyst = RAND(1,100)
	if deyst <= 25:
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str4')
		act 'Закончить танец':gt'kafe2','танец2'
	elseif deyst > 25 and deyst <= 80:
		horny += 5
		clr
		gs'stat'
		if dick > 15 and dick < 18:
			$didanc = 'Во время танца вы чувствуете как что-то твердое между его ног прижимается к вашему животу.'
		elseif dick >= 18:
			$didanc = 'Во время танца вы чувствуете как его член упираясь вам в живот твердеет и вырастает.'
		elseif dick <= 15:
			$didanc = ''
		end
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str5')
		act 'Закончить танец':gt'kafe2','танец2'
	elseif deyst > 80:
		horny += 8
		clr
		gs'stat'
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str6')
		act 'Поцеловать':
			cla
			gs 'zz_render', '', '', func('kafe_2_strings', 'local_str7')
			act 'Обсасывать язык': dynamic $cafe_dance_act, 'kiss'
			act 'Избегать поцелуя': dynamic $cafe_dance_act, 'nokiss'
		end
		if horny < 75: act 'Прекратить танец и уйти':gt'street'
	end
end
if $ARGS[0] = 'танец2':
	cla
	if RAND(1,140) >= vnesh:
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str8')
		act 'Попрощаться': gt'kafe','start'
	else
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str9')
		act 'Согласиться':gt'kafe3','дом'
		if horny < 75: act 'Отшить':gt'street'
	end
end
if $ARGS[0] = 'dance_ending':
	cla
	minut += 30
	gs 'stat'
	if $args[1] = 'boy': 'Вы пьете с парнем и <<$boy>> рассказывает много чего интересного и интересуется вами.'
	if $args[1] = 'company': 'Вы пьете в обществе парней и девчонок. <<$boy>> общаеться и заигрывает с вами.'
	deyst = rand(1,100)
	if deyst < 75:
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str10')
		act 'Попрощаться': gt'kafe','start'
	elseif deyst >= 75 and deyst < 95:
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str11')
		act 'Согласиться': gt'kafe3','дом'
		if horny < 75: act 'Отшить':gt'street'
	elseif deyst >= 95:
		gs 'zz_render', '', '', func('kafe_2_strings', 'local_str12')
		if $args[1] = 'boy':
			gs 'zz_render', '', '', func('kafe_2_strings', 'local_str13')
			act 'Согласиться': gt'kafe3','туалет'
		end
		if $args[1] = 'company':
			gs 'zz_render', '', '', func('kafe_2_strings', 'local_str14')
			act 'Согласиться': gt'kafe3','компашка'
		end
		if horny < 75: act 'Отшить':gt'street'
	end
end