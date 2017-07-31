if $ARGS[0] = 'start':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	'<center><b><font color = maroon>Фотостудия</font></b></center>'
	gs 'zz_render', '', 'images/pic/foto.jpg', func('foto_strings', 'local_str1')
	if artomIzdev = 2 or artomIzdev = 3:
		act 'Спросить про микрокамеру':
			minut += 5
			gs'stat'
			if artomIzdev = 3:'"Как я говорил мы можем договорить о продаже камеры, но это дорого."'
			if artomIzdev = 2:'"Да, я могу достать вам такую, но она стоит дорого."' & artomIzdev = 3
			if money < 70000:
				gs 'zz_render', '', '', func('foto_strings', 'local_str2')
			else
				gs 'zz_render', '', '', func('foto_strings', 'local_str3')
				act 'Купить микрокамеру':
					*clr & cla
					minut += 5
					money -= 70000
					artomIzdev = 4
					microcamera = 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/microcam_1.jpg', func('foto_strings', 'local_str4')
					act 'Далее':gs 'foto','start'
				end
			end
		end
	end
	if pfilmNO = 1:
		gs 'zz_render', '', '', func('foto_strings', 'local_str5')
		act 'Уйти':gt'down'
		exit
	end
	if model > 0 and modelmon = month:
		gs 'zz_render', '', '', func('foto_strings', 'local_str6')
		if pornstudio = 0:
			pornstudio = 2 & 'Вот возьмите визитку. Кастинг порноактрисс.'
		end
	end
	act 'Выйти':
		cla
		minut += 5
		gt'down'
	end
	if parkblackmail = 2:
		act 'Искать глазами шантажиста':gt'foto','blackm'
	elseif model = 0 and parkblackmail ! 2:
		act 'Спросить о работе фотомодели':
			cla
			minut += 5
			if vidage < 25:
				gs 'zz_render', '', '', func('foto_strings', 'local_str7')
				if skin < 2:
					gs 'zz_render', '', '', func('foto_strings', 'local_str8')
				else
					gs 'zz_render', '', '', func('foto_strings', 'local_str9')
					if age < 18:
						gs 'zz_render', '', '', func('foto_strings', 'local_str10')
					else
						gs 'zz_render', '', '', func('foto_strings', 'local_str11')
						act 'Раздеться': gt'foto','model'
					end
				end
			elseif vidage >= 25:
				gs 'zz_render', '', '', func('foto_strings', 'local_str12')
			end
			act 'Уйти':gt'foto','start'
		end
	elseif model > 0 and modelmon ! month and venera < 3:
		act 'Спросить о работе':gt'foto','model'
	end
end
if $ARGS[0] = 'model':
	cla
	*clr
	if vnesh >= 40:
		cla
		*clr
		minut += 5
		if model = 0:model = 1
		modelpay = vnesh*50
		modelmon = month
		gs'stat'
		'<center><b><font color = maroon>Фотограф</font></b></center>'
		gs 'zz_render', '', 'images/pic/fotograph.jpg', func('foto_strings', 'local_str13')
		forand = RAND(1,7)
		if forand = 1:
			gs 'zz_render', '', '', func('foto_strings', 'local_str14')
			act 'Мне это не подходит':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				slava += 1
				minut += 180
				modelpayfin = 9*modelpay/2
				money += modelpayfin
				modelfoto += 1
				gs'stat'
				gs 'zz_render', '', 'images/pic/model1.jpg', func('foto_strings', 'local_str15')
				act 'Переодеться в свою одежду':gt'foto','start'
			end
		elseif forand = 2:
			gs 'zz_render', '', '', func('foto_strings', 'local_str16')
			act 'Мне это не подходит':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				slava = slava + 1
				minut += 180
				modelpayfin = 6*modelpay
				money += modelpayfin
				modelfoto += 1
				gs'stat'
				gs 'zz_render', '', 'images/pic/model2.jpg', func('foto_strings', 'local_str17')
				act 'Переодеться в свою одежду':gt'foto','start'
			end
		elseif forand = 3:
			gs 'zz_render', '', '', func('foto_strings', 'local_str18')
			act 'Мне это не подходит':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				slava += 1
				minut += 180
				modelpayfin = 9*modelpay/2
				money += modelpayfin
				modelfoto += 1
				gs 'stat'
				gs 'zz_render', '', 'images/pic/model3.jpg', func('foto_strings', 'local_str19')
				act 'Переодеться в свою одежду':gt'foto','start'
			end
		elseif forand = 4:
			gs 'zz_render', '', '', func('foto_strings', 'local_str20')
			act 'Мне это не подходит':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				slava += 1
				minut += 180
				modelpayfin = 6 * modelpay
				money += modelpayfin
				modelfoto += 1
				gs'stat'
				gs 'zz_render', '', 'images/pic/model4.jpg', func('foto_strings', 'local_str21')
				act 'Переодеться в свою одежду':gt'foto','start'
			end
		elseif forand = 5:
			gs 'zz_render', '', '', func('foto_strings', 'local_str22')
			act 'Мне это не подходит':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				slava += 1
				mastr += 1
				minut += 180
				modelpayfin = 5 * 3 * modelpay/2
				money += modelpayfin
				modelfoto += 1
				gs'stat'
				gs 'zz_render', '', 'images/pic/model5.jpg', func('foto_strings', 'local_str23')
				act 'Переодеться в свою одежду':gt'foto','start'
			end
		elseif forand = 6:
			gs 'zz_render', '', '', func('foto_strings', 'local_str24')
			act 'Мне это не подходит':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				slava += 1
				lesbian += 1
				minut += 180
				modelpayfin = 9 * modelpay
				money += modelpayfin
				modelfoto += 1
				girl += 1
				gs 'stat'
				gs 'zz_render', '', 'images/pic/model6.jpg', func('foto_strings', 'local_str25')
				act 'Переодеться в свою одежду':gt'foto','start'
			end
		elseif forand = 7:
			gs 'zz_render', '', '', func('foto_strings', 'local_str26')
			act 'Уйти':gt'foto','start'
			act 'Согласиться':
				cla
				*clr
				minut += 180
				modelpayfin = 3 * modelpay
				money += modelpayfin
				modelfoto += 1
				gs 'zz_render', '', 'images/pic/fotograph.jpg', func('foto_strings', 'local_str27')
				act 'Уйти':gt'foto','start'
			end
		end
	else
		gs 'zz_render', '', '', func('foto_strings', 'local_str28')
		act 'Уйти':gt'foto','start'
	end
end
if $ARGS[0] = 'blackm':
	*clr
	gs'stat'
	if parkblackmail = 2:
		gs 'zz_render', '', '', func('foto_strings', 'local_str29')
		act 'Что вы хотите?':
			cla
			gs 'zz_render', '', '', func('foto_strings', 'local_str30')
			act 'Трахалась перед камерой?':
				cla
				gs 'zz_render', '', '', func('foto_strings', 'local_str31')
				act 'Пройти в комнату':
					cla
					gs 'zz_render', '', '', func('foto_strings', 'local_str32')
					act 'Открыть рот':
						cla
						clr
						throat += 1
						guy += 2
						sex += 1
						bj += 1
						gang += 1
						gs 'zz_funcs', 'cum', 'lip'
						swallow += 1
						$boy = 'Блондин'
						pose = 1
						dick = 18
						gs 'zz_render', '', 'images/pics2/studia.jpg', func('foto_strings', 'local_str33')
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_render', '', '', func('foto_strings', 'local_str34')
						act 'Заплакать':
							cla
							*clr
							gs 'zz_render', '', '', func('foto_strings', 'local_str35')
							act 'В душ':
								cla
								gs 'zz_render', '', '', func('foto_strings', 'local_str36')
								act 'Нет!':
									cla
									sex += 1
									bj += 1
									if dick > thraoat: throat += 1
									anal += 1
									gs 'zz_funcs', 'cum', 'ass'
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_funcs', 'cum', 'face'
									gs 'zz_render', '', 'images/pics2/studia2.jpg', func('foto_strings', 'local_str37')
									act 'Подмыться':
										cla
										*clr
										sex += 1
										anal += 1
										sex += 1
										gs 'zz_funcs', 'cum', 'belly'
										gs 'zz_funcs', 'cum', 'ass'
										$boy = 'Брюнет'
										pose = 1
										dick = 18
										gs 'zz_render', '', 'images/pics2/studia3.jpg', func('foto_strings', 'local_str38')
										gs 'zz_dynamic_sex', 'sex_start'
										gs 'zz_dynamic_sex', 'vaginal', 'dick'
										gs 'zz_dynamic_sex', 'sex_cum'
										parkblackmail = 4
										gs 'zz_render', '', '', func('foto_strings', 'local_str39')
										act 'Уйти':gt'Down'
									end
								end
							end
						end
					end
				end
			end
		end
	end
end