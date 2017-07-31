if $ARGS[0] = 'lena':
	cls
	minut += 5
	gs 'stat'
	'<center><b><font color = maroon></font></b></center>'
	if $metka = 'party_gost':
		gs 'zz_render', '', 'Лена','<center><img src="pavlovo/family/sister/sisterQW/ReksHome/Party_iralena_1_' + rand(1,5) + '.jpg"></center>','Лена и Ира вместе бурно веселятся.**-<<$name>>, че морозишься, давай отрываться.**И предлагают вам...'
	else
		gs 'zz_render', '', 'Лена','<center><img src="pavlovo/family/sister/sisterQW/ReksHome/Lena.jpg"></center>','Маленькая и подвижная Лена'
	end
	act 'Отойти':gt $loc,$metka
	if alko < 6 and $metka = 'party_home': act 'Предлагает выпить': gt'sbReksHome','party_drink'
	if $metka = 'party_gost': act 'Выпить': dynamic $Party_ira_drink
	if $metka = 'party_gost': act 'Танцевать': dynamic $Party_ira_dance
end