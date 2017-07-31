if hour < 12 or hour > func('zz_weather','sunset'):
	encounter = 0
else
	encounter = RAND(0,5)
end
n = rand(1,4)
if encounter = 1:
	if encrand = 2:
		! компания парней навстречу
		kol_man = RAND(1,5)
		if month < 3 or month >= 10:
			$zz_str = iif(kol_man<3,('7_'+kol_man),'7_3')
		else
			$zz_str = '6_'+kol_man
		end
		$zz_str = '<center><img src="images/gevent/skver'+$zz_str+'.jpg"></center>В парке по тротуару '
		if kol_man = 1: $textEvent = $zz_str + 'идёт парень'
		if kol_man = 2: $textEvent = $zz_str + 'идут двое парней'
		if kol_man = 3: $textEvent = $zz_str + 'идут трое парней'
		if kol_man = 4: $textEvent = $zz_str + 'идут четверо парней'
		if kol_man = 5: $textEvent = $zz_str + 'идут пятеро парней'
		killvar '$zz_str'
		mass_ver_zn = 1
		know_status = 1
	end
elseif encounter = 3:
	! компания молодежи
	kol_man = RAND(1,6)
	if month < 3 or month > 10:
		$zz_str = '<center><img src="images/gevent/skver9_' + iif(kol_man=1,1,2) + '.jpg"></center>В парке на лавочке '
	else
		$zz_str = '<center><img src="images/gevent/skver9_' + iif(kol_man<6,kol_man+6,11) + '.jpg"></center>В парке на лавочке '
	end
	if kol_man = 1: $textEvent = $zz_str + 'сидит парень'
	if kol_man = 2: $textEvent = $zz_str + 'сидят двое парней'
	if kol_man = 3: $textEvent = $zz_str + 'сидят трое парней'
	if kol_man >= 4: $textEvent = $zz_str + 'сидит компания молодежи'
	killvar '$zz_str'
	mass_ver_zn = 1
	know_status = 1
elseif encounter = 4:
	! гопники
	kol_man = RAND(3,6)
	$textEvent = '<center><img src="images/gevent/skver'+iif(month < 3 or month > 10,11,10)+'_<<n>>.jpg"></center>В парке на корточках сидят гопники и пьют пиво.'
	mass_ver_zn = 1
	know_status = 2
end
gs 'placer_man'
! -------------------------------------
if encounter ! 0: cla & *clr
'Вы прогуливаетесь по тихому '+iif(hour>=6 and hour<=20,'','ночному ')+'парку. <<$textEvent>>'
if ver_zn = 1:
	'На вас посмотрел<<$kol_man_prefiks>> оценивающе <<$kol_man_text>>.'
	if kol_man = 1:'Парень подошел к вам и сказал "<<$text_znak>>"'
	if kol_man > 1:'Парни подошли к вам и один из парней сказал "<<$text_znak>>"'
	act 'Познакомиться':gt'placer_act '
elseif ver_zn = 0 and kol_man > 0:
	if kol_man = 1:$kol_man_text_no = 'После того, как парень посмотрел на вас, он отвернулся.'
	if kol_man > 1:$kol_man_text_no = 'После того, как парни осмотрели вас, они отвернулись.'
	'На вас посмотрел<<$kol_man_prefiks>> оценивающе <<$kol_man_text>>. <<$kol_man_text_no>>.'
end
act 'Закончить':gt'zz_park'
gs 'stat'