if $ARGS[0] = 'main':
	cla
	*clr
	$loc = $curloc
	$metka = $args[0]
	if hour < 4 and RAND(1,100) >= 83:
		'<center><img src="images/LakeCafe/ToiletSexStart.jpg"></center>'
		'Вы зашли в туалет и увидели в углу дрочащего мужчину. Кажется, он вас не заметил.'
		act 'Составить компанию':
			gt'LCporn','toiletsex'
		end
		act 'Выйти из туалета':gt'lakecafe','main'
	else
		*clr
		gs 'stat'
		'<center><img src="images/LakeCafe/Toilet.jpg"></center>'
		'Грязный и вонючий туалет, в котором, похоже, никогда не убирались'
		gs 'zz_toilet', 'actions'
		act 'Выйти из туалета':gt'lakecafe','main'
	end
end