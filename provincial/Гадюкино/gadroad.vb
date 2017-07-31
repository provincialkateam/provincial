$metka = $ARGS[0]
$loc = $CURLOC
clr
gs'stat'
gs'time'
gs 'zz_render', 'Дорога к лесу', func('zz_funcs','mk_image','qwest/gadukino/gadroad/gadroad'),'Обыкновенная сельская дорога идущая через поле к лесу.'
act 'Идти на поле':minut += 10 & gt'gadfield','field'
act 'Идти в лес':minut += 30 & gt'gadforest','1'
if (func('zz_clothing','get_group') = 3 or func('zz_clothing','get_group') = 15) and hour >= 6 and hour < 21 and daybegskver ! daystart and sunWeather >= 0:
	if sick > 0:
		gs 'zz_render', '', '', '<b><font color = red>Вы болеете, поэтому заниматься физическими упражнениями совсем не хочется.</font></b>'
		exit
	end
	act 'Бегать по дороге в течение часа':
		*clr & cla
		minut += 60
		body['day_weight'] -= 1
		beg += RAND(3,6)
		gs 'zz_funcs', 'sport', 2
		speed += iif(speed<40,1,rand(0,1))
		if vital < 20:vital += 1
		daybegskver = daystart
		gs'stat'
		gs'time'
		if snow > 0:
			gs 'zz_render', 'Дорога к лесу', 'qwest/gadukino/gadroad/gadbeg4.jpg'
		elseif snow = 0 and (month < 5 or month > 9):
			gs 'zz_render', 'Дорога к лесу', 'qwest/gadukino/gadroad/gadbeg3.jpg'
		else
			gs 'zz_render', '', 'qwest/gadukino/gadroad/gadbeg'+iif(body['group'] > 1,iif(body['group']=2,5,6),iif((stren + vital) < 50,2,1))+'.jpg'
		end
		gs 'zz_render', '', '','Вы в течение часа бегали по дороге.'
		act 'Далее':gt'gadroad'
	end
end
if current_clothing < 3:act 'Пробраться в деревню огородами':gt'gadukino_event','gadukino_back'
act '<b>Идти в деревню</b>':minut += 20 & gt'gadukino'