$metka = $ARGS[0]
$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
gs 'stat'
gs 'time'
gs 'zz_render','Школа','pavlovo/school/gschool.jpg', func('gschool_strings', 'local_str1')
if hour >= 7 and hour <= 15 and school['certificate'] = 0 and school['vacation'] = 0:
	gs 'zz_render', '', '', func('gschool_strings', 'local_str2')
end
act 'Выйти': gt'gorodok'
if hour >= 19 or hour < 7: exit
if zverRageQW = 1:
	*clr & cla
	zverRageQW = 2
	gs 'stat'
	gs 'time'
	gs 'zz_render', '', '', func('gschool_strings', 'local_str3')
	act 'Драка': gt 'zz_fight',6
	exit
end
if day = 29 and month = 12 and school['certificate'] = 0 and school['block'] < 3:
	if hour = 14:
		gs 'zz_render', '', '', func('gschool_strings', 'local_str4')
		if money >= 1000: act 'Идти на вечеринку (1000р)': money -= 1000 & gt'sny'
	end
end
if week = 6 and hour = 10 and school['certificate'] = 0 and school['block'] < 3 and school['vacation'] = 0:
	if razradbeg = 0:
		gs 'zz_render', '', '', func('gschool_strings', 'local_str13')
		act 'Участвовать в школьных соревнованиях по бегу':
			*clr & cla
			minut += 30
			gs 'stat'
			gs 'zz_render', '', '', func('gschool_strings', 'local_str14')
			act 'Выйти на старт':
				*clr & cla
				minut += 30
				kolsorev += 1
				gs 'stat'
				gs 'zz_common', 'run_competition', 'school'
				if swinbeg = 3 and razradbeg = 0:
					razradbeg = 1
					gs 'zz_render', '', '', func('gschool_strings', 'local_str15')
				end
			end
		end
	end
	if razradbeg = 1:
		gs 'zz_render', '', '', func('gschool_strings', 'local_str5')
		act 'Участвовать в городских соревнованиях по бегу':
			*clr & cla
			minut += 30
			gs 'stat'
			gs 'zz_render', '', '', func('gschool_strings', 'local_str6') + func('gschool_strings', 'local_str'+(7+swinbeggor))
			act 'Выйти на старт':
				*clr & cla
				kolsorev += 1
				minut += 30
				gs 'stat'
				gs 'zz_common', 'run_competition', 'city'
				if swinbeggor = 3 and razradbeg = 1:
					razradbeg = 2
					$npc['18,relation'] = 0
					gs 'zz_render', '', '', func('gschool_strings', 'local_str10')
				elseif swinbeggor = 2 and begresult >= 130:
					$npc['18,relation'] = 0
					gs 'zz_render', '', '', func('gschool_strings', 'local_str11')
				elseif swinbeggor = 1 and begresult >= 130:
					$npc['18,relation'] = 0
					gs 'zz_render', '', '', func('gschool_strings', 'local_str12')
				end
			end
		end
	end
end
if hour <= 8 and school['certificate'] = 0 and school['block'] < 3 and school['vacation'] = 4 and month = 5 and day >= 25:
	gs 'zz_render', '', '', func('gschool_strings', 'local_str16')
	act 'Идти на выпускной':
		*clr & cla
		school['certificate'] = 1
		intel += 10
		gs'stat'
		gs 'zz_render', '', '', func('gschool_strings', 'local_str17')
		act 'Выйти':gt'gorodok'
		act 'Идти на выпускной':
			*clr & cla
			minut += 100
			gs 'zz_funcs', 'alko', 5
			gs 'stat'
			!гы гы, нету нормального выпускного
			gs 'zz_render', '', '', func('gschool_strings', 'local_str18')
			act 'Выйти': gt'gorodok'
		end
	end
end
if (hour >= 7 and hour <= 15) and week < 6 and school['certificate'] = 0 and school['vacation'] = 0:
	if func('zz_clothing','is_schooldress') = 1:
		act 'Идти в школу':
			if rand(0,5) = 0 and hour < 9 and $npc['26,qwMain_day'] ! day:
				gt 'tsarev_events','meet_teacher'
			else
				gt 'zz_school'
			end
		end
	else
		gs 'zz_render', '', '', func('gschool_strings', 'local_str19')
	end
end
if hour = 15 and func('zz_reputation','get') >= 3 and SchoolGossip > 0 and afterschoolday ! day:
	if RAND(0,2) = 0:
		cla
		gs 'zz_render', '', '', func('gschool_strings', 'local_str20')
		act 'Идти за школу':
			*clr & cla
			afterschoolday = day
			SchoolGossip += 1
			gs 'zz_render', '', '', func('gschool_strings', 'local_str21')
			act 'Отсосать':
				*clr & cla
				bj += 3
				if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
				if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
				if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
				dom -= 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/toiletBJtreesome.jpg', func('gschool_strings', 'local_str22')
				act 'Сосать':
					*clr & cla
					minut += 60
					bj += 3
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					cumfrot += 1
					dom -= 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Ev/toiletBJcum.jpg', func('gschool_strings', 'local_str23')
					act 'Выйти': gt $curloc
				end
			end
		end
		act 'Отнекиваться':
			*clr & cla
			minut += 1
			:ReCheck
			i = rand(0,3)
			if lastlpp = i: jump 'ReCheck'
			gs 'zz_render', '', '', func('gschool_strings', 'local_str'+(30+i)) + func('gschool_strings', 'local_str34')
			lastlpp = i
			afterschoolday = day
			act 'Уйти': gt $curloc
		end
		exit
	end
end
if hour = 15 and minut < 20 and week < 6 and school['vacation'] = 0 and school['certificate'] = 0 and school['block'] < 3:
	! автозапуск ивента с Соней
	if $npc['25,qwSonya'] = 30 and $npc['25,qwSonya_day'] ! day and money >= 300: gt 'sonya','meet_near_school'
	! ---
	if LinaSlut > 0 and rand(1,10) < 3: gs 'zz_render','','','Вы видите как Рыжов и Шульгин уводят Лину за школу.'
	if LariskaHomeIn > 0: gs 'zz_render','','','Во дворе школы прогуливается <a href="exec:minut += 1 & GT ''LariskaGo''">Лариска Груздева</a>'
	if JuliaMilLernQW >= 1: gs 'zz_render','','','Во дворе школы прогуливается <a href="exec:minut += 1 & GT ''JuliaMilGo''">Юля Милова</a>'
	if NatBelLernQW >= 1: gs 'zz_render','','','Во дворе школы прогуливается <a href="exec:minut += 1 & GT ''NatBelGo''">Наташа Белова</a>'
	if artomLernQW = 1 and artomVitokQW ! 2 and artemblok = 0: gs 'zz_render','','','Во дворе школы вас уже ожидает <a href="exec:GT ''artemEv''">Артем Чеботарев</a>'
	if $npc['23,qwMain'] = 50 or $npc['23,qwMain'] = 55: gs 'zz_render','','',func('gschool_strings', 'local_str27')
	if $npc['1,qwDimaRude'] > 0 and dimarudeday ! day and DimaRudeBlock = 0: gs 'zz_render','','','Во дворе школы стоит, задумавшись, <a href="exec:GT ''dimaGoHome''">Дима Носов</a>'
	if $npc['4,qwIgorLove'] > 0 and igorkruglovday ! day: gs 'zz_render','','','Во дворе школы вас ждёт <a href="exec:minut += 15 & gt ''igorhome''">Игорь Круглов</a> чтобы идти с вами домой.'
	! meynold`s events
	if $npc['14,qwKatya'] >= 10 and $npc['14,qwKatya'] < 200: gs 'zz_render','','','Во дворе школы прогуливается <a href="exec:gt''mey_katya_events'',''goto_home''">Катя Мейнольд</a>'
	if minut <= 10 and school['vacation'] = 0: gs 'mey_vika_events','near_school'
	if ($npc['45,qwTamara'] = 3 or $npc['45,qwTamara'] = 6) and minut < 30:
		act 'Идти на занятия к Тамаре Михайловне':
			if $npc['45,qwTamara'] = 6: gt 'mey_tamara_events','rebuke'
			gt 'mey_tamara_events', 'learning0'
		end
	end
	if $npc['25,qwSonya'] >= 60 and $npc['25,qwSonya'] < 255 and $npc['25,qwSonya_day'] ! day: gs 'zz_render','','','В стороне от всех стоит <a href="exec:gt''sonya'',''walk_after_school''">Соня.</a>'
end
! учитель мотает домой
if (((week = 2 or week = 4) and hour = 15) or ((week = 1 or week = 3 or week = 5) and hour = 17)) and minut < 15:
	if $npc['26,qwMain'] >= 50 and $npc['26,qwMain'] < 53 and $npc['26,qwMain_day'] ! day: gs 'zz_render','','','Бодрым шагом с большим чемоданом со школы уходит Анатолий Евгеньевич. Может, стоит <a href="exec:gt''tsarev_events'',''teacher_lurking''">проследить</a> за ним?'
end
if week = 1 and school['vacation'] = 0 and $npc['2,qwArtemHack'] >= 10 and apmeetday ! daystart and hour >= 15 and apmeet < 6: gt 'artgar'
gs 'zz_family', 'brother_sheduler'