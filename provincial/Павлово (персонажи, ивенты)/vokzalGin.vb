$metka = $ARGS[0]
$loc = $CURLOC
frost = 0
poezddalsled = 0
gs 'vokdin'
gs 'vokmantoiev'
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render','Вокзал','images/qwest/alter/vokzal.jpg','В центре вокзала зал ожидания и кассы с табло. В одном крыле находятся '+iif(hour >= 8 and hour <= 16,'<a href="exec:minut += 1 & gt''vokdin'',''vokzalg_kabinet''">кабинеты начальства</a>','кабинеты начальства')+', а в другом <a href="exec:minut += 1 & gt''vokdin'',''vokzalg_toilet_f''">туалеты</a>.'
if vokzalVork = 0: gs 'zz_render','','','Около кабинета начальника висит объявление: "Требуется уборщица. 2 часа работы в любое время, зарплата 250 рублей в день.'
if (sunWeather < 0 or temper <= 0) and hour >= 18 and hour < 20 and week < 6: gs 'zz_render','','','Недалеко от касс тусуются Витек Котов, Дэн Рыжов и Шульга.'
if $npc['41,sex'] >= 1: gs 'zz_render','','','<a href="exec: minut += 5 & gt''katalkin''">отделение полиции</a>'
if podbros = 0:
	if money >= 1000 and hour >= 8 and hour <= 20 and RAND(0,20) = 0: gs 'zz_render','','','Идя по вокзалу вы замечаете как у мужчины выпадает толстый <a href="exec:gt''vokdin'',''vokazalg_podbros''">кошелек</a>.'
end
gs 'zz_funcs','waiting'
act 'На перрон': gt 'vokzalperG','start'
act '<b>В городок</b>': minut += 3 & gt'vokzalG'
if vokzalVork >= 1:
	if cleZalDay > day or cleZalDay < day:cleZalDay = day - 1
	if cleZalDay ! day:
		act 'Мыть пол в зале ожидания':
			*clr & cla
			cleZalDay = day
			minut += 60
			sweat += 1
			if vital < 15:vital += RAND(0,1)
			if stren < 15:stren += RAND(0,1)
			gs'stat'
			gs 'zz_render','','images/pic/clener1.jpg','Вы взяли инвентарь, налили воды в ведро и стали мыть пол в зале ожидания.'
			act 'Уйти':minut += 1 & gt'vokzalGin'
		end
	end
	if cleMTDay ! day:
		act 'Мыть пол в мужском туалете':
			*clr & cla
			cleMTDay = day
			minut += 30
			sweat += 1
			if vital < 15:vital += RAND(0,1)
			if stren < 15:stren += RAND(0,1)
			gs'stat'
			gs 'zz_render','','images/pic/clener1.jpg','Вы взяли инвентарь, налили воды в ведро и пошли в мужской туалет.'
			dynamic $d_vok_man_toilet_event
			act 'Уйти':minut += 1 & gt'vokzalGin'
		end
	end
	if cleWTDay ! day: act 'Мыть пол в женском туалете': gt 'VokzalWomanToilet','start'
	if cleMTDay = day and cleWTDay = day and cleZalDay = day and cleZarplatDay ! day:
		act 'Получить зарплату':
			*clr & cla
			cleZarplatDay = day
			vokzalVork += 1
			money += 250
			minut += 3
			gs 'stat'
			gs 'zz_render','','','Вы зашли в кассу и получили свои деньги.'
			act 'Уйти':minut += 1 & gt'vokzalGin'
		end
	end
end
if (hour = 11 or hour = 18) and minut <= 30:
	if minut = 0:
		gs 'zz_render','','','К платформе прибывает поезд дальнего следования.'
	elseif minut > 0 and minut < 30:
		gs 'zz_render','','','У платформы стоит поезд дальнего следования.'
	elseif minut = 30:
		gs 'zz_render','','','От платформы отбывает поезд дальнего следования.'
	end
	gs 'zz_render','','','По платформе суетливо бегают торгаши, втюхивающие свои товары пассажирам поезда. Со стороны за всей этой суетой следит полиция.'
	if tovarL > 0: act 'Втюхивать свой товар пассажирам': gt 'vokzaltorg'
end
if (hour = 9 or hour = 13 or hour = 17) and week mod 2 = 1 and minut <= 30 and vokzalVork > 0 and $npc['29,talk_day'] ! day: gs 'zz_render','','','В уголке у окна возле туалетов курит женщина, в который вы узнали <a href="exec:gt''vera''">кассиршу' + iif($npc['29,know']=0,'.',' Веру</a>.')
gs 'zz_train','train_tickets'