gs'stat'
'<center><img src="images/pic/Cor.jpg"></center>'
act 'Вытянуть карту':
	*clr & cla
	dynamic $d_slut_horny
	minut += 1
	gs'stat'
	papkarand = RAND(0,4)
	if papkarand = 0: $papkacard = 'a'
	if papkarand = 1: $papkacard = 'b'
	if papkarand = 2: $papkacard = 'c'
	if papkarand = 3: $papkacard = 'd'
	if papkarand = 4: $papkacard = 'j'
	if papkarand = 4:
		numcard = RAND(1,2)
		nomcard = 10
	else
		numcard = RAND(2,14)
		if numcard < 10: nomcard = numcard
		if numcard >= 10: nomcard = 10
	end
	'<center><img src="images/qwest/card/<<$papkacard>>/<<$papkacard>><<numcard>>.jpg"></center>'
	'Номинал карты <<nomcard>>'
	act 'Положить в колоду': gt $curloc
end
act 'Убрать карты':gt $loc