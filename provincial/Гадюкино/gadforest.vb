if $ARGS[0] = '1':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs'stat'
	gs'time'
	!снятие прочности одежды, если не джинсы
	if goforestday ! daystart:
		if val($wardrobe[current_clothing+"_"+'group']) ! 2:gs 'zz_clothing', 'decrease_condition'
		if func('zz_clothing','is_glamour') >= 1:gs 'zz_clothing', 'decrease_condition', 4
	end
	if goforest < 20:goforest += rand(0,1)
	lost = 1
	!для определения продолжения пути если ГГ заблудилась
	!шанс заблудиться
	foresteventrand = rand(1,20)
	new_boletus = 0
	new_bilberry = 0
	$_str = 'Окраина леса'
	if snow = 0:
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'1.jpg', iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'Окраина леса. Здесь мало грибов и часто можно встретить грибников.', 'Ночью в лесу страшно и неуютно.')
	else
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest_winter'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'1.jpg',iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'Окраина леса. Зимний лес очень красив.','Ночью в зимнем лесу очень страшно и неуютно.')
	end
	if forestpicnic = 1: gs 'zz_render', '', '', 'На окраине леса вы видите людей. Судя по всему у них тут семейный <a href="exec:gt ''gadforest_event'',''picnic''">пикник</a>.'
	if mirainforest = 1: gs 'zz_render', '', '', 'Недалеко от вас по лесу бродит <a href="exec: gt ''Miroslava'' ">Мира</a>.'
	if clothesforest = 1: gs 'zz_render', '', '', 'На земле лежит ваша одежда.'
	if findvel = 2: gs 'zz_render', '', '', 'Возле дерева стоит старый <a href="exec:gt ''bicycle'',''forest''">велосипед</a>.'
	if goforest < 20: gs 'zz_render', '', '', 'Вы плохо знаете эту часть леса, дальше лучше не ходить.'
	if temper >= 20 and sunWeather >= 0 and hour>=6 and hour<=20 and miratalkforest = 1:gt 'gadforest_event', 'nude_event'
	if foresteventrand < 3 and month >= 6 and month <= 9 and mushroom_pickersday ! daystart:mushroom_pickers = 1 & gt'gadforest_event', 'mushroom_pickers1'
	if foresteventrand = 3 and month >= 5 and month <= 9 and temper >= 20 and sunWeather >= 0 and week > 5 and forestpicnic = 0: forestpicnic = 1 & gt 'gadforest_event', 'picnic'
	if foresteventrand = 4 and month >= 6 and month <= 9: gt 'gadforest_event', 'mushroom_pickers2'
	if foresteventrand = 5 and hour >= 8 and hour <= 15 and month >= 4 and month <= 10 and gadboyday ! daystart and week <= 5: gt 'gadforest_event', 'gopforest_mitka'
	if foresteventrand = 6 and hour >= 8 and hour <= 18 and month >= 4 and month <= 10 and gadboyday ! daystart and week <= 5: gt 'gadforest_event', 'gopforest_kolyamba'
	if foresteventrand = 7 and hour >= 8 and hour <= 18 and month >= 4 and month <= 10 and gadboyday ! daystart and week <= 5: gt 'gadforest_event', 'gopforest_vasyan'
	if foresteventrand = 8 and hour >= 8 and hour <= 15 and month >= 4 and month <= 10 and gadboyday ! daystart and week > 5: gt 'gadforest_event', 'gopforest_2boys'
	if foresteventrand = 9 and hour >= 8 and hour <= 15 and month >= 4 and month <= 10 and gadboyday ! daystart and week > 5: gt 'gadforest_event', 'gopforest_3boys'
	if clothesforest = 1 and current_clothing <= 1:
		act 'Одеться':
			*clr & cla
			clothesforest = 0
			swamp_clothes = 0
			minut += 5
			tanga = flag_tanga
			gs 'zz_clothing', 'redress', prev_clothing
			prev_clothing = -1
			if func('zz_clothing', 'is_skirt') = 1:
				gs 'zz_render', $_str, 'qwest/gadukino/forest/nudeforest1.'+rand(1,2)+'.jpg'
			else
				gs 'zz_render', $_str, 'qwest/gadukino/forest/nudeforest.jpg'
			end
			gs 'zz_render', '', '', 'Вы переоделись в свою одежду.'
			act 'Назад': gt 'gadforest','1'
		end
	end
	!если ГГ ушла из леса и оделась в другом месте
	if clothforest = 1 and current_clothing > 1:
		act 'Забрать брошеную одежду':
			cla
			clothesforest = 0
			'Вы забрали свою одежду.'
			act 'Назад': gt 'gadforest','1'
		end
	end
	if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):
		if current_clothing > 2 and clothforest = 0 and temper >= 20 and sunWeather >= 0 and miratalkforest > 1 and mirainforest = 0:
			act'Раздеться догола':
				*clr & cla
				if forestpicnic = 0:
					!одежда остается в лесу
					clothesforest = 1
					minut+=5
					flag_tanga = tanga
					tanga = 0
					if func('zz_clothing', 'is_skirt') = 1:
						gs 'zz_render', $_str, 'qwest/gadukino/forest/nudeforest1.'+rand(1,2)+'.jpg'
					else
						gs 'zz_render', $_str, 'qwest/gadukino/forest/nudeforest.jpg'
					end
					gs 'zz_render', '', '', 'Вы не стеснясь разделись, оставшись в чем мать родила.'
					gs 'zz_clothing', 'redress', 0
					act'Назад':gt'gadforest','1'
				else
					gs 'zz_render', $_str, 'qwest/gadukino/Swamp/noundress.jpg', 'Рядом люди, вы стесняетесь.'
					act'Назад':gt'gadforest','1'
				end
			end
		end
		if sunWeather >= 0:
			act 'Гулять по лесу':
				*clr & cla
				minut += 30
				manna += iif(current_clothing = 0,30,20)
				if current_clothing = 0:health += 20 & horny += 5
				gs 'stat'
				if month >= 4 and month <= 10:
					if mirainforest = 0:
						if current_clothing > 2 and func('zz_clothing','is_skirt') = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest0.'+rand(1,2)+'.jpg'
						if current_clothing > 2 and tanga = 1 and func('zz_clothing','is_skirt') = 1: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest1.'+rand(1,3)+'.jpg'
						if current_clothing > 2 and tanga = 0 and func('zz_clothing','is_skirt') = 1: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest_tanga0.'+rand(1,2)+'.jpg'
						if current_clothing = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforest_nude0.'+rand(1,4)+'.jpg'
						gs 'zz_render', '', '', 'Вы гуляете по лесу, наслаждаясь шумом деревьев и свежим воздухом.'
					else
						if current_clothing > 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/miraforest'+rand(1,3)+'.jpg'
						if current_clothing = 0: gs 'zz_render', $_str, 'qwest/gadukino/forest/miraforest_nude'+rand(1,3)+'.jpg'
						gs 'zz_render', '', '', 'Вы гуляете c Мирой по лесу, наслаждаясь шумом деревьев и свежим воздухом.'
					end
				else
					if mirainforest = 0:
						gs 'zz_render', $_str, 'qwest/gadukino/forest/gulforestwinter0.'+rand(1,2)+'.jpg', 'Вы гуляете по зимнему лесу, наслаждаясь шумом деревьев и свежим воздухом.'
					else
						gs 'zz_render', $_str, 'qwest/gadukino/forest/miraforestwinter.jpg', 'Вы гуляете с Мирой по зимнему лесу, наслаждаясь шумом деревьев и свежим воздухом.'
					end
				end
				act 'Далее':gt 'gadforest','1'
			end
		end
		if month >= 6 and month <= 9 and boletus + bilberry < 10 and edge_forestday[$metka] ! daystart+args[0]: act 'Искать грибы и ягоды': gt 'gadforest_event', 'search'
		if mirainforest = 0:
			act 'Идти дальше в лес':
				if goforest >= rand(1,30):
					minut += 30 & gt 'gadforest','2'
				else
					gt 'gadforest_event', 'gadforest_lost_start'
				end
			end
		end
	end
	if goswamp = 1 and mirainforest = 0:
		act 'Идти на болото':
			if hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'):
				minut += 75
				gt 'swamp'
			else
				gt 'gadforest_event', 'swamp_road'
			end
		end
	end
	act 'Выйти из леса':mirainforest = 0 & minut += 30 & gt'gadroad'
end
if $ARGS[0] = '2':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs'stat'
	gs'time'
	if goforest < 40:goforest += rand(0,1)
	!для определения продолжения пути ГГ заблудилась
	lost = 2
	foresteventrand = rand(1,10)
	new_boletus = 0
	new_bilberry = 0
	$_str = 'Лес'
	if snow = 0:
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'2.jpg', iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'От опьяняюще свежего воздуха и пения птиц на душе у вас светло и радостно.', 'Ночью в лесу страшно и неуютно.')
	else
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest_winter'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'2.jpg',iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'Зимний лес очень красив, свежий воздух поднимает вам настроение.','Ночью в зимнем лесу очень страшно и неуютно.')
	end
	if goforest < 40: gs 'zz_render', '', '','Вы плохо знаете эту часть леса, дальше лучше не ходить.'
	if foresteventrand = 1 and month >= 6 and month <= 9 and mushroom_pickersday ! daystart:mushroom_pickers = 2 & gt 'gadforest_event', 'mushroom_pickers1'
	if foresteventrand = 2 and hour > 8 and hour < 20 and foresteventday ! daystart:gt 'gadforest_event', 'forest_hanters'
	if foresteventrand > 7 and month >= 6 and month <= 9 and foresteventday ! daystart:mushroom_pickers = 2 & gt 'gadforest_event', 'mushroom_pickers3'
	act 'Вернуться назад':
		if goforest >= rand(1,30):
			minut += 30
			gt 'gadforest','1'
		else
			lost = 1
			gt 'gadforest_event', 'gadforest_lost_start'
		end
	end
	if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):
		if month >= 6 and month <= 9 and boletus + bilberry < 10 and edge_forestday[$metka] ! daystart+args[0]: act 'Искать грибы и ягоды': gt 'gadforest_event', 'search'
		act 'Идти дальше в лес':
			!шанс заблудиться
			if goforest >= rand(1,60):
				minut += 30
				gt 'gadforest','3'
			else
				gt 'gadforest_event', 'gadforest_lost_start'
			end
		end
	end
end
if $ARGS[0] = '3':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs'stat'
	gs'time'
	if goforest < 60:goforest += rand(0,1)
	!для определения продолжения пути ГГ заблудилась
	lost = 3
	foresteventrand = rand(1,10)
	new_boletus = 0
	new_bilberry = 0
	$_str = 'Чаща'
	if snow = 0:
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'3.jpg', iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'От опьяняюще свежего воздуха и пения птиц на душе у вас светло и радостно.', 'Ночью в лесу страшно и неуютно.')
	else
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest_winter'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'3.jpg',iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'Зимний лес очень красив, свежий воздух поднимает вам настроение.','Ночью в зимнем лесу очень страшно и неуютно.')
	end
	if goforest < 60: gs 'zz_render', '', '','Вы плохо знаете эту часть леса, дальше лучше не ходить.'
	if foresteventrand = 1 and month >= 6 and month <= 9 and foresteventday ! daystart: gt 'gadforest_event', 'basket'
	if foresteventrand = 2 and month >= 6 and month <= 9 and foresteventday ! daystart: gt 'gadforest_event', 'bilberry'
	if foresteventrand = 3 and foresteventday ! daystart: gt 'gadforest_event', 'mushroom'
	if foresteventrand = 4 and hour > 8 and hour < 20 and foresteventday ! daystart:gt 'gadforest_event', 'forest_hanters'
	act 'Вернуться назад':
		if goforest >= rand(1,60):
			minut += 30
			gt 'gadforest','2'
		else
			lost = 2
			gt 'gadforest_event', 'gadforest_lost_start'
		end
	end
	if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset'):
		if month >= 6 and month <= 9 and boletus + bilberry < 10 and edge_forestday[$metka] ! daystart: act 'Искать грибы и ягоды': gt 'gadforest_event', 'search'
		act 'Идти дальше в лес':
			!шанс заблудиться
			if goforest >= rand(1,100):
				minut += 30
				gt 'gadforest','4'
			else
				gt 'gadforest_event', 'gadforest_lost_start'
			end
		end
	end
end
if $ARGS[0] = '4':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	gs'stat'
	gs'time'
	if goforest < 80:goforest += rand(0,1)
	lost = 4
	!для определения продолжения пути ГГ заблудилась
	lostrand = rand(1,120)
	!шанс заблудиться
	foresteventrand = rand(1,10)
	dirty = 0
	new_boletus = 0
	new_bilberry = 0
	$_str = 'Лес около болота'
	if snow = 0:
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'4.jpg', iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'От опьяняюще свежего воздуха и пения птиц на душе у вас светло и радостно.', 'Ночью в лесу страшно и неуютно.')
	else
		gs 'zz_render', $_str, 'qwest/gadukino/forest/gadforest_winter'+iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'','_night')+'4.jpg',iif(hour >= func('zz_weather','sunrise') and hour <= func('zz_weather','sunset'),'Зимний лес очень красив, свежий воздух поднимает вам настроение.','Ночью в зимнем лесу очень страшно и неуютно.')
	end
	if goforest < 80: gs 'zz_render', '', '','Вы плохо знаете эту часть леса, дальше лучше не ходить.'
	if foresteventrand < 2 and month >= 6 and month <= 9 and foresteventday ! daystart: gt 'gadforest_event', 'bilberry'
	if foresteventrand > 7 and month >= 6 and month <= 9 and foresteventday ! daystart: gt 'gadforest_event', 'mushroom'
	if foresteventrand = 5 and hour > 8 and hour < 20 and foresteventday ! daystart:gt 'gadforest_event', 'forest_hanters'
	act 'Вернуться назад':
		if goforest >= rand(1,100):
			minut += 30
			gt 'gadforest','3'
		else
			lost = 3
			gt 'gadforest_event', 'gadforest_lost_start'
		end
	end
	if hour >= func('zz_weather','sunrise') and hour < func('zz_weather','sunset') and month >= 6 and month <= 9 and boletus + bilberry < 10 and edge_forestday[$metka] ! daystart: act 'Искать грибы и ягоды': gt 'gadforest_event', 'search'
	act 'Идти дальше в лес':
		if goforest >= lostrand and (goswamp = 1 or snow > 0):
			minut += 30
			gt 'swamp'
		elseif goforest >= lostrand and goswamp = 0:
			minut += 30
			gt 'gadforestswamp','1'
		else
			gt 'gadforest_event', 'gadforest_lost_start'
		end
	end
end