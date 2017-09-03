gs'stat'
if gophouse = 0:
	gs 'zz_render', '', '', func('gopnik_house_strings', 'local_str1')
	if alko < 6:
		gs 'zz_render', '', '', func('gopnik_house_strings', 'local_str2')
	else
		gs 'zz_render', '', '', func('gopnik_house_strings', 'local_str3')
	end
	gs 'zz_render', '', '', func('gopnik_house_strings', 'local_str4')
	act 'Далее':
		rape += 1
		gang += 1
		gophouse = 1
		minut += 5
		silavag = 0
		$boy = 'Гопник'
		guy += kol_man
		ciklkm = kol_man
		if gophouserapeQW = 0:gophouserapeQW = 1
		gt $curloc
	end
elseif gophouse = 1:
	'<center><img src="images/nigma/gor/orgy1,'+rand(0,4)+'.gif"></center>'
	:markgophouserape
	ciklkm -= 1
	minut += 15
	dick = RAND(12,20)
	pose = 0
	if RAND(0,2) < 2:
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
	else
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_dynamic_sex', 'anal_cum'
	end
	if ciklkm > 0:'Затем место между ваших ног занял следующий парень.'
	gs 'stat'
	if ciklkm > 0:jump'markgophouserape'
	if RAND (0,1) = 0:
	gs 'zz_render', '', '', func('gopnik_house_strings', 'local_str5')
		act 'Осмотреться':podvalrape = 0 & dormrape = 0 & gt'gorodok'
	else
		act 'Открыть глаза':
			cla
			*clr & cla
			minut += 5
			podvalwriterand = RAND(1,6)
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/placer/podvalwrite<<podvalwriterand>>.jpg', func('gopnik_house_strings', 'local_str6')
 			act 'Осмотреться':podvalrape = 0 & dormrape = 0 & gt'gorodok'
		end
	end
end