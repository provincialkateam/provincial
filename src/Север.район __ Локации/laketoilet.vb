*clr & cla
$loc = $curloc
if hour < 4 and RAND(1,100) >= 83:
	gs 'zz_render','','images/LakeCafe/ToiletSexStart.jpg','Вы зашли в туалет и увидели в углу дрочащего мужчину. Кажется, он вас не заметил.'
	act 'Составить компанию': gt'LCporn','toiletsex'
else
	gs 'zz_render','','images/LakeCafe/Toilet.jpg','Грязный и вонючий туалет, в котором, похоже, никогда не убирались'
	gs 'zz_toilet', 'actions'
end
act 'Выйти из туалета':gt'lakecafe','main'