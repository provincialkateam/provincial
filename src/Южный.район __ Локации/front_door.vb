if $args[0] = '' or $args[0] = 'start':
	*clr & cla
	minut += 5
	! ивент в подъезде
	! anus > 10 и vagina > 10 можно и не ставить, но из-за читерства надо
	if anus > 10 and vagina > 10 and mesec = 0 and rand(0,10) > 8 and city['cherdak'] = 4 and city['cherdak_day'] ! day:
		gt 'front_door_event','front_ev2'
	end
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Подъезд', 'images/city/south/front_door/entryway.jpg','Подъезд многоэтажного дома, в котором вы живете. Замок, закрывающий дверь на технический этаж или чердак, сломан.'
	if sosedQW = 0: gt 'front_door_event','timofei'
	if sosedQW > 0 and hour >= 16 and sosedDay ! day and rand(0,100) > 70: gs 'zz_render', '', '','На площадке стоит ваш сосед, молодой парень <a href="exec: gt ''Timofei''">Тимофей</a> и курит сигарету, стряхивая пепел в баночку.'
	if BuyHous = 1:act '<b><font color = maroon>Ваша квартира</font></b>':my_house = 2 & gt'korr'
	if ArendHouseSL > 0:act '<font color = maroon>Арендованная квартира</font>':my_house = 1 & gt'korr'
	act 'На чердак': gt 'front_door','attic'
	act '<b>На улицу</b>': gt 'south'
	act '<b>В двор</b>': gt 'homeyard'
end
if $ARGS[0] = 'attic':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Чердак', 'city/south/front_door/attic.jpg','Через чердак можно попасть на крышу. На чердаке темно и страшно. Здесь явно не место приличной девушке.'
	if anus > 10 and vagina > 10 and mesec = 0 and rand(0,10) > 8 and city['cherdak'] <= 3 and city['cherdak_day'] ! day:
		gs 'zz_render','','','В глубине чердака вы слышите <a href="exec:GT ''front_door_event'',''cherdak_ev1''">гогочущую молодежь</a>. Кажется они вас не заметили.'
	end
	act 'На крышу':	gt 'front_door','roof'
	act 'В подъезд': gt 'front_door','start'
end
if $ARGS[0] = 'roof':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'time'
	gs 'zz_render', 'Крыша', func('zz_funcs','mk_image','city/south/front_door/roof'),'Крыша вашего дома'+iif(cloth[3] > 2,'. На кровле лежит ваша одежда.','.')
	if temper >= 20 and hour >= 6 and hour <= 20:
		if cloth[0] ! 2:
			act 'Надеть купальник':
				*clr & cla
				minut += 5
				gs 'zz_clothing2','redress',2
				gs 'stat'
				gs 'zz_render', '', 'city/south/front_door/undress','Вы, сняв одежду, надели купальник. Теперь можно спокойно загорать.'
				act'Далее': gt 'front_door','roof'
			end
		end
		if cloth[0] > 0 and shameless['flag'] > 0:
			act'Раздеться догола':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'city/south/front_door/undress_nude'+iif(cloth[0] = 2,1,2),'Вы, не стесняясь '+iif(cloth[0] = 2,'снимаете купальник','раздеваетесь')+', оставшись в чём мать родила.'
				gs 'zz_clothing2','redress',0
				act 'Далее': gt 'front_door','roof'
			end
		end
		if cloth[0] = 0 or cloth[0] = 2:
			act 'Загорать'+iif(shameless['main'] > 10 and cloth[0] = 2,' топлесс','')+' 1 час':
				cla & *clr
				minut += 30
				manna += 5
				if sunWeather < 2:
					tan += iif(cloth[0] > 0,iif(krem > 0,1,rand(0,1)),iif(krem > 0,2,1))
				else
					tan += iif(cloth[0] > 0,iif(krem > 0,2,1),iif(krem > 0,4,2))
				end
				if krem > 0:krem -= 1
				sweat += iif(temper < 22,0,iif(temper < 30,1,2))
				gs 'stat'
				gs 'zz_render', 'Крыша', 'city/south/front_door/sunbathe'+iif(cloth[0] = 0,'_nude'+rand(1,3),iif(shameless['main'] > 10 and cloth[0] = 2,'_topless','')),'Вы расстелили покрывало и легли загорать.'
				act 'Закончить': gt 'front_door','roof'
			end
		end
	end
	if cloth[0] = 0 or cloth[0] = 2:
		act 'Одеться':
			cla & *clr
			minut += 5
			gs 'zz_clothing2','redress',cloth[3]
			gs 'stat'
			gs 'zz_render', '', 'city/south/front_door/get_dressed','Вы переоделись в свою одежду.'
			act 'Назад': gt 'front_door','roof'
		end
	end
	act 'На чердак': gt'front_door','attic'
end