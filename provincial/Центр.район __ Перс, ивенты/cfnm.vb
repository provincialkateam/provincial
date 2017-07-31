if $ARGS[0] = 'start':
	cla
	*clr
	horny += 5
	minut += 15
	money -= 50
	gs'stat'
	gs 'zz_render', '', 'images/picVA/cfnm.jpg', func('cfnm_strings', 'local_str1')
	if hour < 23:
		act 'Наслаждаться':gt'cfnm','tits'
		act 'Потрогать его член рукой':gt'cfnm','hand'
	end
	act 'Отойти':gt'stripclub','stolW'
end
if $ARGS[0] = 'tits':
	cla
	*clr
	horny += 10
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/picVA/cfnm1.jpg', func('cfnm_strings', 'local_str2')
	if horny < 90:
		if hour < 23:
			act 'Наслаждаться':gt'cfnm','eat'
			act 'Потрогать его член рукой':gt'cfnm','hand'
		end
		act 'Отойти':gt'stripclub','stolW'
	elseif horny >= 90:
		act 'Отдаться':gt'cfnm','sex'
	end
end
if $ARGS[0] = 'hand':
	cla
	*clr
	horny += 5
	minut += 15
	fotoCFNMblowjob += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/cfnmHand.jpg', func('cfnm_strings', 'local_str3')
	act 'Взять в рот':gt'cfnm','blow'
	act 'Прекратить':gt'cfnm','eat'
end
if $ARGS[0] = 'eat':
	cla
	*clr
	horny += 10
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/picVA/cfnm2.jpg', func('cfnm_strings', 'local_str4')
	if horny < 90:
		if hour < 23:
			act 'Взять в рот':gt'cfnm','blow'
			act 'Дрочить у него':gt'cfnm','hand'
		end
		act 'Уйти от стриптизера':gt'stripclub','stolW'
	elseif horny >= 90:
		act 'Отдаться':gt'cfnm','sex'
	end
end
if $ARGS[0] = 'blow':
	cla
	*clr
	horny += 10
	minut += 15
	bj += 1
	if stripguy = 0:stripguy = 1 & guy += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/cfnmBlow.jpg', func('cfnm_strings', 'local_str5')
	if horny < 90:
		if hour < 23:
			act 'Отсасывать на глазах у всех':gt'cfnm','blow2'
			act 'Прекратить сосать':gt'cfnm','hand'
		end
		act 'Уйти от стриптизера':gt'stripclub','stolW'
	elseif horny >= 90:
		act 'Отдаться':gt'cfnm','sex'
	end
end
if $ARGS[0] = 'blow2':
	cla
	*clr
	horny += 10
	minut += 15
	fotoCFNMblowjob += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/cfnmBlow2.jpg', func('cfnm_strings', 'local_str6')
	if horny < 90:
		act 'Окончание на лицо':gt'cfnm','blow4'
		act 'Окончание в рот':gt'cfnm','blow3'
		if DOM > 0: act 'Окончание на пол':gt'cfnm','end'
	elseif horny >= 90:
		act 'Отдаться':gt'cfnm','sex'
	end
end
if $ARGS[0] = 'blow3':
	cla
	*clr
	horny += 10
	minut += 15
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	dom -= 1
	fotoCFNMblowjobCum += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/swallow.jpg', func('cfnm_strings', 'local_str7')
	act 'Уйти от стриптизера':gt'stripclub','stolW'
end
if $ARGS[0] = 'blow4':
	cla
	*clr
	horny += 10
	minut += 15
	gs 'zz_funcs', 'cum', 'face'
	dom -= 1
	fotoCFNMblowjobCum += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/facial.jpg', func('cfnm_strings', 'local_str8')
	act 'Уйти от стриптизера':gt'stripclub','stolW'
end
if $ARGS[0] = 'end':
	cla
	*clr
	horny += 10
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/picVA/end.jpg', func('cfnm_strings', 'local_str9')
	act 'Уйти от стриптизера':gt'stripclub','stolW'
end
if $ARGS[0] = 'sex':
	cla
	*clr
	horny = 0
	minut += 15
	sex += 1
	gs 'zz_funcs', 'cum', 'ass'
	dom -= 5
	fotoCFNMsex += 1
	if stripguy = 0:stripguy = 1 & guy += 1
	manna += 15
	orgasm += 1
	vagina += 1
	gs'stat'
	gs 'zz_render', '', 'images/picVA/sex.jpg', func('cfnm_strings', 'local_str10')
	act 'Уйти от стриптизера':gt'stripclub','stolW'
end