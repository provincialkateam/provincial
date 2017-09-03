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
else
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
	'Наконец все это кончилось, парни оделись и вышли из подвала.'
	act 'Уйти':podvalrape = 0 & dormrape = 0 & gt'gorodok'
end