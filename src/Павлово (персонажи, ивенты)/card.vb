gs 'zz_render','','pic/Cor.jpg'
act 'Вытянуть карту':
	*clr & cla
	horny += rand(3,7)
	minut += 1
	gs 'stat'
	$papkacard[0] = 'a'
	$papkacard[1] = 'b'
	$papkacard[2] = 'c'
	$papkacard[3] = 'd'
	$papkacard[4] = 'j'
	i = rand(0,4)
	gs 'zz_render','','qwest/card/'+$papkacard[i]+'/'+$papkacard[i]+iif(i=4,rand(1,2),rand(2,14))
	killvar '$papkacard'
	act 'Положить в колоду': gt $curloc
end
act 'Убрать карты': gt $loc