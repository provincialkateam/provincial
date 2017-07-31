$metka = $ARGS[0]
$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
*clr
gs 'stat'
gs 'time'
gs 'zz_render','Перон Павлово','images/pic/vokzalperG.jpg',''
if snarkozak = 1 and narkossista = 0 and narkozakday!day:
	if money >= 2000:
		act 'Искать закладку':
			minut += 20
			money -= 2000
			StrongNarkota += 25
			SNarkTimes += 1
			narkozakday = day
			gs 'zz_render','','','Вынашли зкладку и недолго думая ширнулись.'
			act 'Уйти': dynamic $snkayf
		end
	end
end
act 'В вокзал': minut += 2 & gt 'vokzalGin'