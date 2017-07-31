if $args[0] = 'check_trip':
	if family_trip_month = month or (family_trip_month ! month and week < 6) or (family_trip_month ! month and week = 6 and hour < 12):
		family_trip = 0
	else
		family_trip = 1
	end
end
if $args[0] = 'mother_sheduler':
	gs 'zz_family','check_trip'
	if family_trip = 0:
		! default locations
		! --- mother --- !
		if hour < 6 or hour >= 21: $mother['location'] = 'bedrPar2'
		if hour = 6 or hour = 7 or hour = 18 or hour = 19: $mother['location'] = 'kuhrPar'
		if week < 6:
			if hour >= 8 and hour <= 17: $mother['location'] = 'gkafe'
		else
			! weekend
			if hour = 8: $mother['location'] = 'bedrPar2'
			if hour = 9 or hour = 10: $mother['location'] = iif(sunWeather < 0,'shop','grinok')
			if hour = 11 or hour = 12: $mother['location'] = 'sitrPar'
			if hour >= 13 and hour <= 15:
				! park/lake
				if month >= 5 and month <= 9:
					$mother['location'] = iif(sunWeather >= 0,iif(temper >= 20,'glake','zz_park'),'sitrPar')
				else
					$mother['location'] = iif(sunWeather >= 0 and (month = 4 or month = 10),'zz_park','sitrPar')
				end
			end
			! unknown loc
			if hour = 16 or hour = 17: $mother['location'] = ''
		end
		if hour = 20: $mother['location'] = 'sitrPar'
	else
		$mother['location'] = 'Gadhouse'
	end
	if $mother['location'] = $curloc: gs 'zz_family', 'mother_act'
end
if $args[0] = 'father_sheduler':
	gs 'zz_family','check_trip'
	if family_trip = 0:
		! --- father --- !
		if hour < 7 or hour >= 21: $father['location'] = 'bedrPar2'
		if hour = 7: $father['location'] = 'kuhrPar'
		if week < 6:
			if hour >= 8 and hour <= 16: $father['location'] = '_work'
			if hour >= 18 and hour <= 20:
				if week = 1:
					$father['location'] = ''
				else
					$father['location'] = iif(father['horny'] >= 70, 'sitrPar', 'gargazel')
				end
			end
		else
			if hour >= 8 and hour <= 16: $father['location'] = 'sitrPar'
			if hour >= 18 and hour <= 20:
				if week = 6: $father['location'] = iif(father['horny'] >= 70, 'sitrPar', 'gargazel')
				if week = 7: $father['location'] = 'sitrPar'
			end
		end
		if hour = 17: $father['location'] = iif(week=1,'','sitrPar')
	else
		$father['location'] = 'Gadhouse'
	end
	if $father['location'] = 'gargazel': father['in_garage'] = 1
	if $father['location'] = $curloc: gs 'zz_family', 'father_act'
end
if $args[0] = 'sister_sheduler':
	gs 'zz_family','check_trip'
	if family_trip = 0:
		if hour < 7 or hour >= 22: $sister['location'] = 'bedrPar'
		if week < 6:
			if hour = 7: $sister['location'] = 'kuhrPar'
			if hour >= 8 and hour < 16: $sister['location'] = 'shop'
			if hour = 16:
				! park/lake
				if month >= 5 and month <= 9:
					$sister['location'] = iif(sunWeather >= 0,iif(temper >= 20,'glake','gdk'),'cafe_parco')
				else
					$sister['location'] = iif(sunWeather >= 0 and (month = 4 or month = 10),'gdk','cafe_parco')
				end
			end
		else
			if hour >= 8 and hour <= 11: $sister['location'] = 'bedrPar'
			if hour >= 12 and hour <= 16:
				! park/lake
				if month >= 5 and month <= 9:
					$sister['location'] = iif(sunWeather >= 0,iif(temper >= 20,'glake','gdk'),'cafe_parco')
				else
					$sister['location'] = iif(sunWeather >= 0 and (month = 4 or month = 10),'gdk','cafe_parco')
				end
			end
		end
		! boys locs
		if hour >= 17 and hour <= 21: $sister['location'] = iif(week = 5,'reks_home','roma_home')
	else
		$sister['location'] = 'Gadhouse'
	end
	if $sister['location'] = $curloc:  gs 'zz_family', 'sister_act'
end
if $args[0] = 'brother_sheduler':
	gs 'zz_family','check_trip'
	if family_trip = 0:
		if $npc['39,qwKolkaPrince'] < 4 or school['vacation'] = 0:
			if hour < 7: $brother['location'] = 'sitrPar'
			if hour = 17: $brother['location'] = iif(sunWeather >= 0,'gschool','misha_home')
			if hour >= 18: $brother['location'] = 'sitrPar'
		else
			if hour < 6 or (hour = 6 and minut < 30): $brother['location'] = 'sitrPar'
			if hour = 6 and minut >= 30: $brother['location'] = 'bedrPar'
			if hour >= 17 and hour <= 20: $brother['location'] = 'bedrPar'
			if hour > 20: $brother['location'] = 'sitrPar'
		end
		if hour = 7: $brother['location'] = 'kuhrPar'
		if week < 6 and school['vacation'] = 0:
			! school, lessons
			if hour >= 8 and hour < 16: $brother['location'] = 'gschool2'
		else
			if hour >= 8 and hour < 11: $brother['location'] = 'sitrPar'
			if hour >= 11 and hour < 16: $brother['location'] = iif(sunWeather >= 0 and month > 2 and month < 12,'gschool','misha_home')
		end
		! football or not football
		if hour = 15 or hour = 16: $brother['location'] = 'gschool'
	else
		$brother['location'] = 'Gadhouse'
	end
	if $brother['location'] = $curloc: gs 'zz_family', 'brother_act'
end
if $args[0] = 'mother_act':
	if $mother['location'] = 'kuhrPar' and hour > 7:
		*clr
		! PaulRichard`s placers
		$_img[0] = 'posuda'+rand(1,3)
		$_img[1] = 'gotovka'
		$_img[2] = 'tea'
		$_img[3] = 'prost'+rand(1,11)
		$_img[4] = 'uborka'+rand(1,3)
		$_str[0] = 'Возле мойки стоит <a href="exec:GT ''mother''">мама</a> и моет посуду.'
		$_str[1] = 'Возле плиты стоит <a href="exec:GT ''mother''">мама</a> и что-то готовит.'
		$_str[2] = '<a href="exec:GT ''mother''">Мама</a> пьет чай.'
		$_str[3] = 'На кухне крутится <a href="exec:GT ''mother''">мама</a> и что-то ищет.'
		$_str[4] = '<a href="exec:GT ''mother''">Мама</a> с веником в руках наводит порядок.'
		! change action
		if $mother['action_hour'] ! hour:
			if $mother['action'] < 4:
				$mother['action'] += 1
			else
				$mother['action'] = 0
			end
			$mother['action_hour'] = hour
		end
		gs 'zz_render', '','pavlovo/family/mother/'+$_img[val($mother['action'])]+'.jpg',$_str[val($mother['action'])]
		killvar '$_img'
		killvar '$_str'
		exit
	end
	if $mother['location'] = 'bedrPar2':
		if hour = 8 and week >= 6: gs 'zz_render', '','','Ваша <a href="exec:GT ''mother''">мать</a>, похоже, решила раслабиться в выходной и поваляться в кровати.'
		exit
	end
	if $mother['location'] = 'sitrPar':
		gs 'zz_render', '','','На диване сидит ваша <a href="exec:GT ''mother''">мать</a>, совмещая просмотр телевизора и листание журнала.'
		exit
	end
	if $mother['location'] = 'zz_park':
		gs 'zz_render', '','','В парке на лавочке с другими тетками сидит ваша <a href="exec:GT ''mother''">мама</a>.'
		exit
	end
	if $mother['location'] = 'glake':
		gs 'zz_render', '','','В компании других теток на пляже загорает ваша <a href="exec:GT ''mother''">мама</a>.'
		exit
	end
	if $mother['location'] = 'shop' or $mother['location'] = 'grinok':
		gs 'zz_render', '','','Как обычно, по выходных с утра ваша <a href="exec:GT ''mother''">мама</a> пошла за покупками.'
		exit
	end
end
if $args[0] = 'father_act':
	if $father['location'] = 'sitrPar':
		gs 'zz_render', '','','На диване сидит <a href="exec: gt''zz_father'',''main''">отчим</a> и смотрит телевизор.'
		exit
	end
end
if $args[0] = 'brother_act':
	if $brother['location'] = 'gschool':
		if sunWeather >= 0 and month > 2 and month < 12:
			gs 'zz_render', '','','Возле школы <a href="exec:gt''zz_brother'',''main''">Колька</a> с друганами гоняет футбол.'
		else
			gs 'zz_render', '','','Возле школы в сторонке заговорщицки о чем-то болтает <a href="exec:gt''zz_brother'',''main''">Колька</a> с друганами.'
		end
	end
	if $brother['location'] = 'sitrPar':
		$_str[0] = 'За столом сидит ваш младший брат <a href="exec:gt''zz_brother'',''main''">Колька</a> и учит уроки.'
		$_str[1] = '<a href="exec:gt''zz_brother'',''main''">Колька</a>, развалившись на диване, смотрит телик.'
		$_str[2] = 'На диване спит ваш младший брат <a href="exec:gt''zz_brother'',''main''">Колька</a>.'
		if hour >= 18 and hour <= 20: gs 'zz_render', '','',$_str[iif(week < 6 and school['vacation'] = 0,0,1)]
		if hour = 21 or hour = 22 or (hour > 7 and hour < 11): gs 'zz_render', '','',$_str[1]
		if hour = 23 or hour < 7: gs 'zz_render', '','',$_str[2]
		killvar '$_str'
	end
	if $brother['location'] = 'bedrPar':
		$_str[0] = '<a href="exec:gt''zz_brother'',''main''">Колька</a> занимается зарядкой по середине комнаты.'
		$_str[1] = 'За вашим столом сидит <a href="exec:gt''zz_brother'',''main''">Колька</a> и учит уроки.'
		if hour = 6 and minut >= 30: gs 'zz_render','','',$_str[0]
		if hour >= 17 and hour <= 20: gs 'zz_render','','',$_str[1]
		killvar '$_str'
	end
end
if $args[0] = 'sister_act':
	if $sister['location'] = 'bedrPar':
		if hour >= 22:
			if week = 5:
				gs 'zz_render','','','Ваша пьяная сестра Аня спит на кровати.'
			else
				gs 'zz_render','','','Ваша сестра <a href="exec:gt ''sister''">Аня</a> сидит на кровати и читает книгу.'
			end
		end
		if (hour < 7 and week < 6) or (hour < 10 and week >= 6): gs 'zz_render','','','Ваша сестра <a href="exec:GT ''sistersleep''">Аня</a> спит на кровати.'
		if (hour = 10 or hour = 11) and week >= 6: gs 'zz_render','','','Ваша сестра <a href="exec:GT ''sister''">Аня</a> собирается на прогулку.'
	end
	if $sister['location'] = 'gdk': 'Ваша сестра <a href="exec: gt ''sister''">Аня</a> сидит в компании друзей и пьет пиво.'
	if $sister['location'] = 'cafe_parco': 'Ваша сестра <a href="exec: gt ''sister''">Аня</a> сидит в компании друзей и пьет пиво.'
	if $sister['location'] = 'glake': 'Ваша сестра <a href="exec: gt ''sister''">Аня</a> загорает в компании друзей.'
end