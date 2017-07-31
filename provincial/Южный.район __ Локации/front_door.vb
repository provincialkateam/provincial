if $args[0] =  '' or $args[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Подъезд', 'images/city/south/front_door/entryway.jpg','Подъезд многоэтажного дома в котором вы живете. Замок, закрывающий дверь на технический этаж, или чердак, сломан.'
	if sosedQW = 0: gt 'front_door_event','timofei'
	if sosedQW > 0 and hour >= 16 and sosedDay ! day  and rand(0,100) > 70: gs 'zz_render', '', '','На площадке стоит ваш сосед, молодой парень <a href="exec: gt ''Timofei''">Тимофей</a> и курит сигарету, стряхивая пепел в баночку.'
	if BuyHous = 1:act '<b><font color = maroon>Ваша квартира</font></b>':my_house = 2 & gt'korr'
	if ArendHouseSL > 0:act '<font color = maroon>Арендованная квартира</font>':my_house = 1 & gt'korr'
	act 'На чердак': gt'front_door','attic'
	act '<b>На улицу</b>':
		if sick <= 72 and current_clothing > 2:
			minut += 5 & gt'street'
		elseif current_clothing > 2:
			'<b><font color = red>ВЫ СЛИШКОМ СИЛЬНО БОЛЕЕТЕ ЧТО БЫ ХОДИТЬ ПО УЛИЦЕ.</font></b>'
			xgt $curloc
		else
			'<b><font color = red>ВАМ НАДО ОДЕТЬСЯ.</font></b>'
			xgt $curloc
		end
	end
end
if $ARGS[0] = 'attic':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', 'Чердак', 'images/city/south/front_door/attic.jpg','Лестничный пролет на крышу ведет через чердак. Темно и страшно. Здесь явно не место приличной девушке.'
	if RAND(1,100) > 90:'В глубине чердака вы слышите <a href="exec:GT ''front_door_event'',''attic_boys''">гогочущую молодежь</a>. Кажется они вас не заметили.'
	act 'На крышу':	gt 'front_door','roof'
	act 'В подъезд': gt 'front_door','start'
end
if $ARGS[0] = 'roof':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'time'
	gs 'zz_render', 'Крыша', func('zz_funcs','mk_image','city/south/front_door/roof'),'Крыша вашего дома'+iif(prev_clothing > 2,'. На кровле лежит ваша одежда.','.')
	if temper >= 20 and hour >= 6 and hour <= 20:
		if current_clothing ! 2:
			act 'Надеть купальник':
				*clr & cla
				minut += 5
				if current_clothing > 0:flag_tanga = tanga
				!tanga = 0
				gs 'zz_clothing', 'redress', 2
				gs'stat'
				gs 'zz_render', '', 'images/city/south/front_door/undress.jpg','Вы сняли свою одежду, и надели купальник. Теперь можно спокойно загорать.'
				act'Далее': gt 'front_door','roof'
			end
		end
		if current_clothing > 0 and shameless['flag'] > 0:
			act'Раздеться догола':
				*clr & cla
				minut += 5
				if current_clothing ! 2: flag_tanga = tanga
				tanga = 0
				gs'stat'
				gs 'zz_render', '', 'images/city/south/front_door/undress_nude'+iif(current_clothing = 2,1,2)+'.jpg','Вы не стеснясь '+iif(current_clothing = 2,'сняли купальник','раделись')+', оставшись в чем мать родила.'
				gs 'zz_clothing', 'redress', 0
				act 'Далее': gt 'front_door','roof'
			end
		end
		if current_clothing = 0 or current_clothing = 2:
			act 'Загорать'+iif(shameless['main'] > 10 and current_clothing = 2,' топлесс','')+' 1 час':
				cla & *clr
				minut += 30
				manna += 5
				if sunWeather < 2:
					tan += iif(current_clothing > 0,iif(krem > 0,1,rand(0,1)),iif(krem > 0,2,1))
				else
					tan += iif(current_clothing > 0,iif(krem > 0,2,1),iif(krem > 0,4,2))
				end
				if krem > 0:krem -= 1
				sweat += iif(temper < 22,0,iif(temper < 30,1,2))
				gs'stat'
				gs 'zz_render', 'Крыша', 'images/city/south/front_door/sunbathe'+iif(current_clothing = 0,'_nude'+rand(1,3),iif(shameless['main'] > 10 and current_clothing = 2,'_topless',''))+'.jpg','Вы расстелили покрывало и легли загорать.'
				act 'Закончить': gt 'front_door','roof'
			end
		end
	end
	if current_clothing = 0 or current_clothing = 2:
		act 'Одеться':
			cla & *clr
			minut += 5
			tanga = flag_tanga
			gs 'zz_clothing', 'redress', prev_clothing
			prev_clothing = -1
			gs'stat'
			gs 'zz_render', '', 'images/city/south/front_door/get_dressed.jpg','Вы переоделись в свою одежду.'
			act 'Назад': gt 'front_door','roof'
		end
	end
	act 'На чердак': gt'front_door','attic'
end