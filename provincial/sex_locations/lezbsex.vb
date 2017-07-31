if $ARGS[0] = 'start':
	gs'stat'
	girl += 1
	lesbian += 1
	picrand = RAND(0,1)
	if $npc['31,sex'] = 1: picrand = 12
	xgt'lezbsex','var'
end
if $ARGS[0] = 'var':
	gs 'stat'
	if picrand ! 11:act 'Куни':gt'lezbsex','lezb_variant','kuni'
	act 'Сделать куни':gt'lezbsex','lezb_variant','ukuni'
	if picrand ! 12 and picrand ! 13 and picrand ! 14 and picrand ! 16 and picrand ! 17 and picrand ! 18 and picrand ! 21:act 'Анулингус':gt'lezbsex','lezb_variant','anuli'
	if picrand ! 12 and picrand ! 13 and picrand ! 14 and picrand ! 16 and picrand ! 17 and picrand ! 18 and picrand ! 21:act 'Сделать анулингус':gt'lezbsex','lezb_variant','uanuli'
	if strapon = 1 and picrand ! 11 and picrand ! 12 and picrand ! 13 and picrand ! 14 and picrand ! 15 and picrand ! 16 and picrand ! 17 and picrand ! 18 and picrand ! 19 and picrand ! 20 and picrand ! 21 and picrand ! 22:
		act 'Страпон в киску': gt'lezbsex','lezb_variant','svag'
		act 'Страпон в попку': gt'lezbsex','lezb_variant','sanal'
		act 'Страпон вам в киску':gt'lezbsex','lezb_variant','usvag'
		act 'Страпон вам в попу':gt'lezbsex','lezb_variant','usanal'
	end
	if dildo = 1 and picrand ! 12 and picrand ! 19 and picrand ! 20 and picrand ! 22:
		act 'Дилдо в киску':gt'lezbsex','lezb_variant','dvag'
		if picrand ! 11 and picrand ! 15 and picrand ! 16 and picrand ! 17 and picrand ! 18 and picrand ! 21:act 'Дилдо в попку':gt'lezbsex','lezb_variant','danal'
		if picrand ! 11: act 'Дилдо вам в киску':gt'lezbsex','lezb_variant','udvag'
		if picrand ! 11 and picrand ! 14 and picrand ! 15 and picrand ! 16 and picrand ! 17 and picrand ! 18 and picrand ! 21:act 'Дилдо вам в попу':gt'lezbsex','lezb_variant','udanal'
	end
end
if $args[0] = 'lezb_variant':
	*clr & cla
	minut += 5
	horny += 10
	if horny >= 80:
		horny = 0
		orgasm += 1
	end
	'<center><img src="images/img/lezbsex/' + $args[1] + picrand + '.jpg"></center>'
	if $args[1] = 'ukuni': 'Вы целуете ей грудь постепенно спускаясь все ниже и ниже и вот уже перед вами её текущая киска, вы начинаете ласкать языком её губки, заводя свой язык между ними касаетесь клитора, девушка раздвигает губы пальцами, что бы ничто не мешало вам ласкать клитор.'
	if $args[1] = 'kuni': 'Девушка проводит языком по вашим бедрам, целует лобок и спускается к вагине, её язычок скользит по вашей промежности то лаская клитор то проникая в вагину.'
	if $args[1] = 'anuli': 'Она целует ваши ягодицы постепенно приближаясь к центру, достигнув цели она проводит языком по вашему анусу затем вталкивает его внутрь вашей попы, выводит и снова лижет анус, потом все повторяется вновь.'
	if $args[1] = 'uanuli': 'Вы облизываете её ягодицы постепенно приближаясь к центру, достигнув ануса, проводите языком по нему языком и проникаете внутрь её попы, вынимаете и снова лижет анус.'
	if $args[1] = 'svag': 'Вы одеваете страпон и вставляете в её киску, она постанывает пока вы трахаете её.'
	if $args[1] = 'sanal': DOM += 1 & 'Вы одеваете страпон и аккуратно вводите его в анус девушки, начиная трахать её зад сначала медленно затем все быстрее и быстрее.'
	if $args[1] = 'usvag': 'Девушка вставляет страпон вам в киску, она двигается взад и вперед доставляя вам удовольствие.'
	if $args[1] = 'usanal': 'Девушка плюет вам на попку, собирает слюну кончиком страпона и вставляет его вам в анус, вы чувствуете как он движется в вашей попке, с каждым толчком все быстрее и глубже.'
	if $args[1] = 'dvag': 'Вы берете дилдо и засовываете в её киску, девушка целует вас пока вы одной рукой управляете дилдо а второй ласкаете её грудь.'
	if $args[1] = 'danal': 'Вы берете дилдо, облизываете его, стараясь оставить на нем максимальное количество слюны, и аккуратно вводите в анус девушки, начиная трахать её зад дилдо сначала медленно затем все быстрее и быстрее.'
	if $args[1] = 'udvag': 'Девушка вставляет дилдо вам в киску, она двигает его взад и вперед при этом постоянно проворачивая его, дилдо в её руках становиться лучше любого члена.'
	if $args[1] = 'udanal': 'Девушка плюет вам на попку, собирает слюну кончиком дилдо и вставляет его вам в анус, вы чувствуете как он растягивает ваш анус, доставляя вам удовольствие.'
	act 'Еще':xgt'lezbsex','var'
	act 'Уйти':gt'lezbsex','end'
end
if $ARGS[0] = 'end':
	cla
	if picrand = 22: gt'down'
	if picrand = 21: gt'zz_bathroom','start'
	if picrand = 19 or picrand = 20:gt'office','work'
	if $npc['31,sex'] = 1: gt'fit','razd'
	gt '<<$sexloc>>','start'
end