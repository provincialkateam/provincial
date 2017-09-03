$d_dima_end = {
	act 'Протирать глаза':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/facial2.jpg', func('sny_strings', 'local_str1')
		if $npc['1,qwNosovRevenge'] = 1:
			$npc['1,qwNosovRevenge'] = 2
			daynosovrevenge = daystart
			gs 'zz_render', '', '', func('sny_strings', 'local_str2')
		end
		act 'Уйти':gt'gorodok'
	end
}
$d_dima_kiss = {
	act 'Целоваться':
		*clr & cla
		minut += 5
		horny += 10
		!1 и 4
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/pett.jpg', func('sny_strings', 'local_str3')
		act 'Ждать':
			*clr & cla
			minut += 5
			horny += 10
			!1 и 4
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/ev2/pett2.jpg', func('sny_strings', 'local_str4')
			act 'Ждать':
				*clr & cla
				minut += 5
				$boy = $npc['1,name']
				silavag = 1
				dick = $npc['1,dick']
				if $npc['1,sex'] = 0: $npc['1,sex'] = 1 & guy += 1
				pose = 0
				gs'stat'
				'<center><img src="images/qwest/alter/ev2/fuck.jpg"></center>'
				gs 'zz_dynamic_sex', 'sex_start'
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				!gs 'zz_dynamic_sex', 'sex_cum'
				gs 'zz_render', '', '', func('sny_strings', 'local_str5')
				act 'Взять в рот':
					*clr & cla
					minut += 5
					if $npc['4,sex'] = 0: $npc['4,sex'] = 1 & guy += 1
					bj += 1
					if protect = 1:condomDima = 1
					gang += 1
					pose = 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/ev2/fuck2.jpg', func('sny_strings', 'local_str6')
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
					act 'Сосать':
						*clr & cla
						minut += 5
						gs 'zz_funcs', 'cum', 'face'
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/ev2/facial.jpg', func('sny_strings', 'local_str7')
						if condomDima = 1:
							act 'Далее':
								*clr & cla
								gs 'zz_funcs', 'cum', 'face'
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alter/ev2/cond.jpg', func('sny_strings', 'local_str8')
								dynamic $d_dima_end
							end
						elseif condomDima = 0:
							dynamic $d_dima_end
						end
					end
				end
			end
		end
	end
}
$d_otvali_nosov = {
	act 'Эй! Отвали!':
		*clr & cla
		minut += 5
		gs'stat'
		if alko < 6:
			if dom >= 10:
				if horny < 90:
					gs 'zz_render', '', '', func('sny_strings', 'local_str9')
					act 'Уйти':gt'gorodok'
				else
					gs 'zz_render', '', '', func('sny_strings', 'local_str10')
					dynamic $d_dima_kiss
				end
			else
				gs 'zz_render', '', '', func('sny_strings', 'local_str11')
				dynamic $d_dima_kiss
			end
		else
			gs 'zz_render', '', '', func('sny_strings', 'local_str12')
			dynamic $d_dima_kiss
		end
	end
}
gs 'stat'
if snyqw = 0:
	gs 'zz_render', '', '', func('sny_strings', 'local_str13')
	act 'Пить чай с плюшками':
		*clr & cla
		minut += 30
		body['day_weight'] += 1
		energy += 10
		water += 20
		cumlip = 0
		gs 'stat'
		gs 'zz_render', '', '', func('sny_strings', 'local_str14')
		act 'Встать из за стола':
			*clr & cla
			minut += 30
			snyqw = 1
			gs'stat'
			gs 'zz_render', '', '', func('sny_strings', 'local_str15')
			act 'Помогать убирать со стола':gt $curloc
		end
	end
elseif snyqw = 1:
	gs 'zz_render', '', '', func('sny_strings', 'local_str16')
	if func('zz_reputation','get') >= 3:
		gs 'zz_render', '', '', func('sny_strings', 'local_str17')
		act 'Молчать':
			*clr & cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', '', func('sny_strings', 'local_str18')
			if $npc['23,qwMain'] = 55:
				gs 'zz_reputation','set',func('zz_reputation','get')-1
				gs 'zz_render', '', '', func('sny_strings', 'local_str19')
				act 'Уйти':gt'gschool'
			else
				gs 'zz_render', '', '', func('sny_strings', 'local_str20')
				act 'Идти в сортир':snyqw = 2 & minut += 15 & gt $curloc
			end
		end
	elseif func('zz_reputation','get') <= 2:
		gs 'zz_render', '', '', func('sny_strings', 'local_str21')
		act 'Подойти':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', '', func('sny_strings', 'local_str22')
			act 'Выпить':
				*clr & cla
				gs 'zz_funcs', 'alko',3
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/ev2/drunk.jpg', func('sny_strings', 'local_str23')
				if $npc['1,relation'] = 0:
					$npc['1,relation'] = 50
					$npc['1,qwNosovRevenge'] = 1
					gs 'zz_render', '', '', func('sny_strings', 'local_str24')
				end
				act 'Идти на тусовку':snyqw = 3 & minut += 30 & gt $curloc
				act 'Уйти':gt'gschool'
			end
			act 'Отказаться пить':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', '', func('sny_strings', 'local_str25')
				if $npc['1,relation'] = 0:
					$npc['1,relation'] = 50
					$npc['1,qwNosovRevenge'] = 1
					gs 'zz_render', '', '', func('sny_strings', 'local_str26')
				end
				act 'Идти на тусовку':snyqw = 3 & minut += 30 & gt $curloc
				act 'Уйти':gt'gschool'
			end
		end
	end
elseif snyqw = 2:
	gs 'zz_render', '', '', func('sny_strings', 'local_str27')
	act 'Сосать':
		*clr & cla
		gang += 1
		bj += 10
		dom -= 100
		i = 1
		:loop_bj_ny
		if i ! 9 and $npc['<<i>>,sex'] = 0: $npc['<<i>>,sex'] = 1 & guy += 1
		i += 1
		if i < 11: jump 'loop_bj_ny'
		if func('zz_reputation','get') < 4: gs 'zz_reputation','set',4
		gs 'zz_render', '', 'images/qwest/alter/ev2/snybj.jpg', func('sny_strings', 'local_str28')
		act 'Обслуживать одноклассников':
			*clr & cla
			gs 'zz_render', '', 'images/qwest/alter/ev2/snyfilming.jpg', func('sny_strings', 'local_str29')
			act 'Сосать':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/ev2/snyblowbang.jpg', func('sny_strings', 'local_str30')
				act 'Сосать':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/ev2/snyblowbang2.jpg', func('sny_strings', 'local_str31')
					act 'Сосать':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/alter/ev2/snyblowbang3.jpg', func('sny_strings', 'local_str32')
						act 'Сосать':
							*clr & cla
							minut += 20
							gs 'zz_funcs', 'cum', 'face'
							gs 'zz_funcs', 'cum', 'lip'
							cumfrot += 1
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/ev2/snycum.jpg', func('sny_strings', 'local_str33')
							act 'Уйти':gt'gschool'
						end
					end
				end
			end
		end
	end
elseif snyqw = 3:
	gs 'zz_render', '', 'images/qwest/alter/ev2/tusa3.jpg', func('sny_strings', 'local_str34')
	act 'Выпить':
		*clr & cla
		gs 'zz_funcs', 'alko', 3
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/drunk.jpg', func('sny_strings', 'local_str35')
		act 'Тусить':snyqw = 4 & minut += 5 & gt $curloc
	end
	act 'Отказаться пить':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/tusa3.jpg', func('sny_strings', 'local_str36')
		act 'Тусить':snyqw = 4 & minut += 5 & gt $curloc
	end
elseif snyqw = 4:
	gs 'zz_render', '', 'images/qwest/alter/ev2/tusa4.jpg', func('sny_strings', 'local_str37')
	act 'Выпить':
		*clr & cla
		gs 'zz_funcs', 'alko', 3
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/drunk.jpg', func('sny_strings', 'local_str38')
		act 'Тусить':snyqw = 5 & minut += 5 & gt $curloc
	end
	act 'Отказаться пить':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/tusa4.jpg', func('sny_strings', 'local_str39')
		act 'Тусить':snyqw = 5 & minut += 5 & gt $curloc
	end
elseif snyqw = 5:
	gs 'zz_render', '', 'images/qwest/alter/ev2/tusa5.jpg', func('sny_strings', 'local_str40')
	act 'Выпить':
		*clr & cla
		gs 'zz_funcs', 'alko', 3
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/drunk.jpg', func('sny_strings', 'local_str41')
		act 'Тусить':snyqw = 6 & minut += 5 & gt $curloc
	end
	act 'Отказаться пить':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/tusa5.jpg', func('sny_strings', 'local_str42')
		act 'Тусить':snyqw = 6 & minut += 5 & gt $curloc
	end
elseif snyqw = 6:
	gs 'zz_render', '', 'images/qwest/alter/ev2/tusa6.jpg', func('sny_strings', 'local_str43')
	act 'Выпить':
		*clr & cla
		gs 'zz_funcs', 'alko', 3
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/drunk.jpg', func('sny_strings', 'local_str44')
		act 'Тусить':snyqw = 7 & minut += 5 & gt $curloc
	end
	act 'Отказаться пить':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/tusa6.jpg', func('sny_strings', 'local_str45')
		act 'Тусить':snyqw = 7 & minut += 5 & gt $curloc
	end
elseif snyqw = 7:
	if alko >= 10:
		gs 'zz_render', '', 'images/qwest/alter/ev2/vomit.jpg', func('sny_strings', 'local_str46')
		act 'Блевать':
			*clr & cla
			minut += 60*alko
			gs 'stat'
			if $npc['1,qwNosovRevenge'] = 0:
				cumfrot += 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/ev2/vom.jpg', func('sny_strings', 'local_str47')
				act 'Уйти': gt'gorodok'
			else
				gs 'zz_render', '', 'images/picb/tattoo/vag/5.jpg', func('sny_strings', 'local_str48')
				if tattoo['vag'] >= 1 and tattoo['vag'] < 5: 'Вам видимо перебили старую татушку на новую.'
				tattoo['vag'] = 5
				lobok = -10
				gs 'stat'
				gs 'zz_render', '', '', func('sny_strings', 'local_str49')
				act 'Уйти':gt'gorodok'
			end
		end
	elseif alko >= 6 and alko < 10:
		gs 'zz_render', '', 'images/qwest/alter/ev2/tit.jpg', func('sny_strings', 'local_str50')
		act 'Эй! Куда ты меня тащишь?':snyqw = 10 & minut += 5 & gt $curloc
	elseif alko > 0 and alko < 6:
		gs 'zz_render', '', 'images/qwest/alter/ev2/alb.jpg', func('sny_strings', 'local_str51')
		act 'Искать Катю':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/ev2/kat.jpg', func('sny_strings', 'local_str52')
			act 'Идти в комнату':snyqw = 8 & minut += 5 & gt $curloc
		end
	else
		gs 'zz_render', '', 'images/qwest/alter/ev2/idi.jpg', func('sny_strings', 'local_str53')
		act 'Уйти':gt'gorodok'
	end
elseif snyqw = 8:
	gs 'zz_render', '', 'images/qwest/alter/ev2/tusa8.jpg', func('sny_strings', 'local_str54')
	act 'Искать Альбину':
		*clr & cla
		minut += 5
		horny += 10
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/ev2/albgang.jpg', func('sny_strings', 'local_str55')
		act 'Идти в комнату':snyqw = 9 & minut += 5 & gt $curloc
	end
elseif snyqw = 9:
	gs 'zz_render', '', 'images/qwest/alter/ev2/tusa9.jpg', func('sny_strings', 'local_str56')
	if $npc['1,qwDimaFilm'] = 0 or DimaRudeBlock = 1:
		act 'Мне пора идти':
			*clr & cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', '', func('sny_strings', 'local_str57')
			act 'Уйти':gt'gorodok'
		end
	end
	act 'Пойдем':snyqw = 10 & minut += 5 & gt $curloc
elseif snyqw = 10:
	gs 'zz_render', '', 'images/qwest/alter/ev2/kiss.jpg', func('sny_strings', 'local_str58')
	if $npc['1,qwNosovRevenge'] = 1:
		dynamic $d_dima_kiss
		dynamic $d_otvali_nosov
	else
		if $npc['1,qwDimaFilm'] = 1 and DimaRudeBlock = 0:
			dynamic $d_dima_kiss
		else
			dynamic $d_dima_kiss
			dynamic $d_otvali_nosov
		end
	end
end