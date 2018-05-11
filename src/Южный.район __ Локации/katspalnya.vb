$sexloc = $CURLOC
if $ARGS[0] = 'start':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Kathouse/bedroom.jpg'
	if hour >= 18 and hour < 23:'На тахте сидит <a href="exec:gt''katspalnya'',''kat''">Катя</a> и смотрит телевизор'
	if hour >= 23 or hour < 6:'В кровати спит <a href="exec:gt''katspalnya'',''katslip''">Катя</a>.'
	gs 'zz_render','','','Большая комната по середине стоит огромная кровать, с боку небольшая тахта.'
	act 'Уйти':gt'south'
end
if $ARGS[0] = 'katslip':
	*clr & cla
	minut += 30
	gs 'zz_render','','images/img/Kathouse/kat.jpg'
	gs 'zz_render','','','Катя протирает глаза "Привет как делишки".'
	act 'Отойти':gt'katspalnya','start'
	if $npc['33,relation'] > 50:act 'Секс':gt'lezbsex','start'
end
if $ARGS[0] = 'kat':
	*clr & cla
	minut += 30
	gs 'zz_render','','images/img/Kathouse/kat.jpg'
	gs 'zz_render','','','Увидев вас Катя улыбается "Привет как делишки".'
	act 'Отойти':gt'katspalnya','start'
	if $npc['33,relation'] > 50:act 'Секс':gt'lezbsex','start'
	act 'Поболтать':
		*clr & cla
		if telkat = 0:telkat = 1
		gs 'npc_editor','change_rep','+', 33
		minut += 30
		gs 'zz_render','','images/img/Kathouse/kat.jpg'
		gs 'zz_render','','','Вы проболтали полчаса.'
		act 'Закончить':gt'katspalnya','start'
	end
end
if $args[0] = 'kat_emergency':
	*clr & cla
	hour = 31
	son = 20
	gs 'stat'
	gs 'zz_render','','images/img/Kathouse/slip.jpg','Катя привела вас к себе, уложила спать и сама легла с вами. Рано утром вы почувствовали как она выскользнула из ваших объятий и открыли глаза.
	\\\Спи, мне на работу надо, я тебе ключи оставлю./// - сказала Кэт и чмокнув вас убежала.
	Вы выспались и начали осматриваться, на кушетке напротив кровати лежал парень и смотрел на вас. Вероятно это один из её многочисленных парней про которых она вам рассказывала.'
	act 'Уйти': gt 'south'
	act 'Соблазнить':
		*clr & cla
		gs 'zz_render','','images/img/Kathouse/kathouse1.jpg','Вы скидываете с себя одеяло и начинаете гладить себя, сначала грудь затем трусики в районе киски, когда чувствуете что киска достаточно увлажнилась отводите трусики в бок и засовываете пару пальцев в вагину, слегка постанывая. Парень сел на кушетку и смотрит на вас не моргая.'
		act 'Подозвать':
			$sexloc = 'katspalnya'
			gt 'sex','start'
		end
	end
end