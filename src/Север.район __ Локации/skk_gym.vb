!'Тренажерка в СКК
start_skk_gym = 0 - стартовый ивент
start_skk_gym = 1 - согласилась и пошла к доктору
start_skk_gym = 2 - к тренеру
start_skk_gym = 3 - может оплачивать и ходить в зал
price_skk_gym - цена занятий
abonement_skk_gym - сколько занятий осталось у ГГ купленных
sport_trauma - травма, мешает заниматься спортом. В зависимости от тяжести дает разные штрафы'
if skk_gym_load = 0 : gs 'skk_gym_string'
!проверка одежды
!if func('zz_clothing2','get_group') = 1 and sport = 0:
gs 'skk_gym_string'+$lang
gs 'stat'
$metka = $curloc
price_skk_gym = 8000
gs 'zz_render','Тренажерный зал','city/north/skk/gym/holl.jpg','Это тренажерный зал с кучей супер пупер кабинетов и вообще это качалка для супер профи. За стойкой на ресепшен сидит девочка и невинно хлопает своими длинющими ресницами. Здесь можно приобрести абонемент на 30 занятий всего за 8000 р.'
!предложение участия в акции
if start_skk_gym = 0:
	cla & *clr
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/holl.jpg', $skk_gym_[1]
	!согласиться
	act '<<$skk_gym_[3]>>':
		cla
		gs 'zz_render','','', $skk_gym_[4]
		!согласиться
		act '<<$skk_gym_[9]>>':
			cla
			gs 'zz_render','','', $skk_gym_[5]
			start_skk_gym = 1
			!к доктору
			act '<<$skk_gym_[10]>>' : gt 'skk_gym'
		end
		!отказать
		act '<<$skk_gym_[8]>>':
			cla
			gs 'zz_render','','', $skk_gym_[6]
			act '<<$skk_gym_[7]>>' : gt 'skk','sport'
		end
		!не хватило денег
		if money < price_skk_gym and karta < price_skk_gym:
			cla
			gs 'zz_render','','', $skk_gym_[11]
			act 'Отойти' : gt 'skk','sport'
		end
		!болеет
		if sick >= 1 :
			cla
			gs 'zz_render','','', $skk_gym_[12]
			act '<<$skk_gym_[7]>>' : gt 'skk','sport'
		end
	end
	!отказаться
	act '<<$skk_gym_[2]>>' : gt 'skk','sport'
	exit
end
!Первичный прием у доктора
if start_skk_gym = 1:
	cla & *clr
	gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_cab.jpg', $skk_gym_[13]
	act 'Начать осмотр': startivent = 1 & gt 'skk_gym', 'smotr1'
	if startivent = 1 : cla & *clr
	if $args[0] = 'smotr1':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr1.jpg', $skk_gym_[15]
		act 'Раздеться': gt 'skk_gym', 'smotr2'
	elseif $args[0] = 'smotr2':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr2.jpg', $skk_gym_[16]
		act 'Промолчать': gt 'skk_gym', 'smotr3'
	elseif $args[0] = 'smotr3':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr3.jpg', $skk_gym_[17]
		act 'Далее': gt 'skk_gym', 'smotr4'
	elseif $args[0] = 'smotr4':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr4.jpg', $skk_gym_[18]
		act 'Раздвинуть ноги': gt 'skk_gym', 'smotr5'
	elseif $args[0] = 'smotr5':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr5.jpg', $skk_gym_[19]
		act '<font color="red">Возбуждаться</font>': gt 'skk_gym', 'smotr6'
		act '<font color="blue">Ждать Окончание осмотра</font>': blue = 1 & gt 'skk_gym', 'smotr16'
	elseif $args[0] = 'smotr6':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr6.jpg', $skk_gym_[20]
		act 'Далее': gt 'skk_gym', 'smotr7'
	elseif $args[0] = 'smotr7':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr7.jpg', $skk_gym_[21]
		act 'Зажмуриться': gt 'skk_gym', 'smotr8'
	elseif $args[0] = 'smotr8':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr8.jpg', $skk_gym_[22]
		act 'Закусить губу': gt 'skk_gym', 'smotr9'
	elseif $args[0] = 'smotr9':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr9.jpg', $skk_gym_[23]
		act 'Перевернуться': gt 'skk_gym', 'smotr10'
	elseif $args[0] = 'smotr10':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr10.jpg', $skk_gym_[24]
		horny = 80
		act 'Зажмуриться': gt 'skk_gym', 'smotr11'
	elseif $args[0] = 'smotr11':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr11.jpg', $skk_gym_[25]
		horny = 95
		act 'Сдерживаться': gt 'skk_gym', 'smotr12'
	elseif $args[0] = 'smotr12':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr12.jpg', $skk_gym_[26]
		act 'Закрыть глаза': gt 'skk_gym', 'smotr13'
	elseif $args[0] = 'smotr13':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr13.jpg', $skk_gym_[27]
		horny = 0
		act 'Расслабиться': gt 'skk_gym', 'smotr14'
	elseif $args[0] = 'smotr14':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr14.jpg', $skk_gym_[28]
		horny += 10
		act 'Наслаждаться': gt 'skk_gym', 'smotr15'
	elseif $args[0] = 'smotr15':
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr15.jpg', $skk_gym_[29]
		act 'Далее': gt 'skk_gym', 'smotr16'
	elseif $args[0] = 'smotr16':
		minut += 10
		start_skk_gym = 2
		killvar 'startivent'
		if blue = 1 :
			gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_cab.jpg', $skk_gym_[33]
			killvar 'blue'
			act 'Идти на ресепшен': gt 'skk_gym'
			exit
		end
		gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_osmotr16.jpg', $skk_gym_[30]
		lesbian +=1
		analorgasm += 1
		girl +=1
		horny += 10
		manna += 10
		act 'Идти на ресепшен': gt 'skk_gym'
	end
	exit
end
!C репешнен отправляют к главному тренеру + тренер
if start_skk_gym = 2:
	cla & *clr
	!ресепшен отправляет к тренеру
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/holl.jpg', $skk_gym_[31]
	act 'Идти к тренеру' :
		!диалог с тренером
		cla & *clr
		gs 'zz_render','Тренер','city/north/skk/gym/trener.jpg', $skk_gym_[32]
		minut += 5
		start_skk_gym = 3
		killvar 'startivent'
		act 'Идти на ресепшен' : gt 'skk_gym'
	end
	exit
end
!покупка абонемента
if money + karta >= price_skk_gym:
	act 'купить абонемент' :
		cla & *clr
		gs 'zz_funcs','payment',2,8000
		abonement_skk_gym += 30
		gs 'zz_render','Тренажерный зал','city/north/skk/gym/holl.jpg', 'Вы подошли к ресепшен и оплатили '+iif(price_from_karta = 1, 'картой', 'наличкой')+ ' себе абонемент на 30 занятий. Теперь  Вы можете посетить тренажерный зал <<abonement_skk_gym>> раз.'
		act 'Понятно' : gt 'skk_gym'
	end
end
if abonement_skk_gym > 0 : act 'пройти в коридор' : gt 'skk_gym_kor'
act 'В СКК' : gt 'skk','sport'