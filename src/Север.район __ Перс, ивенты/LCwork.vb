﻿if $args[0] = 'start':
	cla
	*clr
	if $args[1] = '1':
		horand = RAND(1,100) + 40
		gang += 1
		anal += 1
		bj += 1
		guy += randguycafe
		if vagina < 20: vagina += randguycafe
		$zz_str[0] = 'Вы подходите к группе мужчин и говорите, что сегодня вы их обслуживаете. Они встают и ведут к вас к машине. Во время поездки они поглаживали ваши сиськи и ноги, совали руки в трусики и пальцы в рот. Когда вы приехали, они раздели вас и поставили в позицию. Мужики выдрали вас во все щели, после чего обкончали всё ваше тело.'
		$zz_str[1] = 'Они дали вам умыться и довезли до дома. '
	end
	if $args[1] = '2':
		horand = RAND(1,100)
		gs 'zz_funcs', 'cum', 'face'
		if vagina < 18: vagina += 1
		guy += 1
		$zz_str[0] = 'Вы подходите к старику и говорите, что вы пришли его обслужить. Он встаёт, приобнимает вас и вы идёте с ним к его машине. Он везёт вам в лес, где останавливается и раздевает вас. Он раздвинул ваши ноги и выебал вас в киску, после чего кончил вам на лицо.'
		$zz_str[1] = 'Он сел в машину и довёз вас до дома. '
	end
	if $args[1] = '3':
		horand = RAND(1,100) + 20
		anal += 1
		bj += 1
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_funcs', 'cum', 'lip'
		guy += 2
		if vagina < 18:vagina += 2
		$zz_str[0] = 'Вы подходите к двум парням и говорите, что вы сегодня идёте с ними. Они ведут вас в машину и везут в квартиру, где трахают вас во все щели. Застонав, они достали свои хуйцы и кончили вам на лицо.'
		$zz_str[1] = 'Не дав вам умыться, они выгнали вас из дома. '
	end
	if $args[1] = '4':
		horand = RAND(1,100) + 20
		kuni += 1
		gang += 1
		lesbian += 1
		anal += 1
		bj += 1
		slutty += 1
		gs 'zz_funcs', 'cum', 'belly'
		girl += 1
		guy += 1
		if vagina < 18:vagina += 1
		$zz_str[0] = 'Вы подходите к паре и говорите, что сегодня обслуживаете их. Они ведут вас в свою квартиру. Вы с девушкой начинаете всячески ублажать парня. Через некоторое время парень не выдержал и кончил вам на животик. Его девушка слизала немного семени с вашего живота.'
		$zz_str[1] = 'Вы вышли из их квартиры и дошли до дома. '
	end
	if $args[1] = '5':
		horand = RAND(1,100)
		lesbian += 1
		kuni += 1
		girl += 1
		sex -= 1
		$zz_str[0] = 'Вы подходите к девушке и говорите, что вы сегодня с ней. Она ведёт вас в свою квартиру. Вы с девушкой начинаете ласкать друг друга, сувать пальчики и всякие предметы в свои дырочки. Наигравшись, девушка отпускает вас.'
		$zz_str[1] = 'Вы вышли из её квартиры и дошли до дома. '
	end
	if $args[1] = '6':
		horand = RAND(1,100)
		hj += 1
		guy += 1
		if vagina < 18: vagina += 1
		$zz_str[0] = 'Вы подходите к толстяку и говорите, что сегодня обслуживаете его. Он ведёт вас к машине и везёт в свой дом, где трахает вас в вагину. Застонав, он вынул свой хуй и вы, подрочив член, приняли сперму себе на личико.'
		$zz_str[1] = 'Вы вышли из его квартиры и дошли до дома. '
	end
	dynamic $venerasiak
	sex += 1
	slutty += 1
	minut += 140
	gs 'zz_render','','LakeCafe/LakeWork/'+$args[1]+'a.jpg', $zz_str[0]
	gs 'zz_funcs', 'hornyrand'
	act '...':
		*clr & cla
		gs 'stat'
		randLCpay = RAND(500,2000)
		gs 'zz_render','','LakeCafe/LakeWork/'+$args[1]+'b.jpg', $zz_str[1]+'Вы получили за это <<randLCpay>> рублей.'
		act '...':
			money += randLCpay
			killvar 'randLCpay'
			killvar '$zz_str'
			gt 'south'
		end
	end
end
if $ARGS[0] = 'Kitchen':
	cla
	*clr
	minut += 90
	LCwork2 += 1
	money += 175
	LCwork2day = day
	gs 'zz_render','','LakeCafe/KitchenWorkCafe.jpg','Вы моете посуду, полы, нарезаете овощи, готовите еду на протяжении полутора часов, за что вам дают ваши заслуженные 175 рублей.'
	act '...':
		gs 'stat'
		gt 'lakecafe','main'
	end
end