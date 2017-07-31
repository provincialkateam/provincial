gs'stat'
if podvalrape = 0:
	'Вы лежите на грязном матраце в полу темном подвале пахнущем канализацией, в окружении пустых бутылок. Вокруг вас стоят <<$kol_man_text>> и обсуждают между собой "Ну что поцики, тянем жребий, кто первый дерет эту шалаву?"'
	act 'Далее':
		rape += 1
		gang += 1
		podvalrape = 1
		minut += 5
		silavag = 0
		$boy = 'Гопник'
		guy += kol_man
		ciklkm = kol_man
		if podvalrapeQW = 0:podvalrapeQW = 1
		gt $curloc
	end
elseif podvalrape = 1:
	'<center><img src="images/nigma/gor/orgy1,'+rand(0,4)+'.gif"></center>'
	:markpodvalrape
	ciklkm -= 1
	minut += 15
	dick = RAND(12,20)
	pose = 0
	if RAND(0,2) < 2:
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
	else
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_dynamic_sex', 'anal_cum'
	end
	gs 'stat'
	if ciklkm > 0:'Затем место между ваших ног занял следующий парень.' & jump'markpodvalrape'
	if RAND(0,1) = 0:
		'Наконец все это кончилось, парни оделись и вышли из подвала.'
		act 'Уйти':podvalrape = 0 & dormrape = 0 & gt'gorodok'
	else
		act 'Приходить в себя':
			*clr & cla
			minut += 5
			body_write = 5
			face_write = 1
			podvalwriterand = RAND (1,6)
			gs 'stat'
			'<center><img src="images/qwest/alter/placer/podvalwrite<<podvalwriterand>>.jpg"></center>'
			'Мало того что вас пропустили по кругу и отодрали как хотели, гопники разрисовали всякой похабщиной ваше беспомощно распластанное тело и посмеиваясь удалились. Вы ошеломленно лежите на полу, делая вялые попытки подняться.'
 			act 'Уйти':podvalrape = 0 & dormrape = 0 & gt'gorodok'
		end
	end
end