minut += 15
gs 'stat'
gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex1.webm', func('Voltrenersex_strings', 'local_str1')
$din_trener_talk = {
	if Voltrenersee =1:
		gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str38')
	end
	if Voltrenersee =2:
		gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str39')
	end
	if Voltrenersee =>3:
		*clr
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex2.webm', func('Voltrenersex_strings', 'local_str2')
		if guy < 3 and func('zz_reputation','get') = 0:
			gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str40')
		end
		if (guy => 3 and guy < 7) or func('zz_reputation','get') > 0:
			gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str41')
		end
		if guy => 7 or func('zz_reputation','get') > 1:
			volleytanga=0
			sopr=1
			gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str42')
			! sopr флаг на начало действий в душевой
			! volleytanga=0 закрываю терерскую без трусиков в gdksport - зайти в трене
		else
			gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener3.jpg', func('Voltrenersex_strings', 'local_str3')
		end
	end
	act 'Уйти': gt'gdksport'
}
$din_trener_vagin = {
	*clr & cla
	gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex29.jpg', func('Voltrenersex_strings', 'local_str4')
	act 'Далее':
		*clr & cla
		horny = 100
		minut += 15
		pose = 0
		gs 'npc_editor','change_rep','+', 28
		gs'stat'
		gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex30.gif', func('Voltrenersex_strings', 'local_str5')
		act 'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex31.gif', func('Voltrenersex_strings', 'local_str6')
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex32.gif'
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str7')
				act 'Только не в меня':
					*clr & cla
					'<center><img src="images/pavlovo/dk/volley/voitrensex33.jpg"></center>'
					$sexstart2orgazm5 = func('Voltrenersex_strings', 'local_str37')
					act 'Стереть сперму':
						*clr & cla
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex34.jpg', func('Voltrenersex_strings', 'local_str8')
						act 'Уйти':gt'gdksport'
					end
				end
			end
		end
	end
}
$din_trener_anal = {
	*clr & cla
	gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex24.webm', func('Voltrenersex_strings', 'local_str9')
	act 'Далее':
		*clr & cla
		horny = 100
		minut += 15
		gs 'npc_editor','change_rep','+', 28
		gs'stat'
		gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex25.webm', func('Voltrenersex_strings', 'local_str10')
		act 'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex26.webm', func('Voltrenersex_strings', 'local_str11')
			gs 'zz_dynamic_sex', 'anal_start', 'dick'
			gs 'zz_dynamic_sex', 'anal', 'dick'
			gs 'zz_dynamic_sex', 'anal_cum'
			act'Прийти в себя':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex28.jpg', func('Voltrenersex_strings', 'local_str12')
				act 'Уйти':gt'gdksport'
			end
		end
	end
}
$din_trener_defl= {
*clr
gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex19.webm', func('Voltrenersex_strings', 'local_str13')
	act 'Показать письку':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex20.webm', func('Voltrenersex_strings', 'local_str14')
		act 'Уйти':gt'gdksport'
		act 'Остаться':
			*clr & cla
			kuni+=1
			horny = 100
			minut += 10
			pose = 1
			gs 'npc_editor','change_rep','+', 28
			gs'stat'
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex21.webm', func('Voltrenersex_strings', 'local_str15')
			Act 'Отдаться':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex22.webm', func('Voltrenersex_strings', 'local_str16')
				Act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex23.webm', func('Voltrenersex_strings', 'local_str17')
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str18')
					gs 'zz_dynamic_sex', 'sex_cum'
					act 'Прийти в себя':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex27.webm', func('Voltrenersex_strings', 'local_str19')
						act 'Уйти':gt'gdksport'
					end
				end
			end
		end
	end
}
$din_trener_mast= {
*clr & cla
minut += 10
gs'stat'
gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex11.webm', func('Voltrenersex_strings', 'local_str20')
	Act'Выставить письку':
		*clr & cla
		mastr+=1
		gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex12.webm', func('Voltrenersex_strings', 'local_str21')
		Act 'Ласкать соски':
			horny += 10
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex13.webm', func('Voltrenersex_strings', 'local_str22')
			act 'Ласкать клитор':
				horny += 10
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex14.webm', func('Voltrenersex_strings', 'local_str23')
				Act 'Ласкать анус':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex15.webm', func('Voltrenersex_strings', 'local_str24')
					Act'Кончить':
						horny = 0
						orgasm += 1
						manna += 20
						gs'stat'
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex16.webm', func('Voltrenersex_strings', 'local_str25')
						act 'Уйти':gt'gdksport'
					end
					if rand(1,4)=1:
						act'Посмотреть на тренера':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex17.webm', func('Voltrenersex_strings', 'local_str26')
							act'Схватится за член':
								*clr & cla
								minut += 10
								horny = 0
								orgasm += 1
								manna += 20
								gs'stat'
								gs 'zz_render', '', 'pavlovo/dk/volley/voitrensex18.webm', func('Voltrenersex_strings', 'local_str27')
								act 'Уйти':gt'gdksport'
							end
						end
					end
				end
			end
		end
	end
}
$din_trener_sex = {
		*clr & cla
		hj += 1
		horny += 10
		$npc['28,sex'] += 1
		gs 'stat'
		gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex3.webm', func('Voltrenersex_strings', 'local_str28')
		act 'Полизать':
			*clr & cla
			bj += 1
			eggs += 1
			gs 'stat'
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex4.webm', func('Voltrenersex_strings', 'local_str29')
			if 	horny < 60:
				act 'Вскочить':
					*clr & cla
					Joke += 1 & ! счетчик запуска секса на диско
					gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex5.webm', func('Voltrenersex_strings', 'local_str30')
					act 'Уйти':gt'gdksport'
				end
			end
			act 'Сосать':
				*clr & cla
				throat += 1
				horny += 10
				gs 'npc_editor','change_rep','+', 28
				gs 'stat'
				gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex6.webm', func('Voltrenersex_strings', 'local_str31')
				if $npc['28,sex'] >= 3 and vagina = 0 and sex = 0 and mesec <= 0:
					act 'Лишиться девственности': dynamic $din_trener_defl
				end
				act 'Продолжить сосать':
					cla
					gs 'zz_render', '', '', func('Voltrenersex_strings', 'local_str32')
					if $npc['28,sex'] >= 10 and throat > 15:
						act 'Заглотить':
							*clr & cla
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex6.webm', func('Voltrenersex_strings', 'local_str33')
							act 'Мастурбировать': dynamic $din_trener_mast
							act 'Уйти': gt 'gdksport'
						end
					end
					act 'Вынуть изо рта':
						*clr & cla
						gs 'zz_funcs', 'cum', 'belly'
						gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex9.webm', func('Voltrenersex_strings', 'local_str34')
						act 'Мастурбировать': dynamic $din_trener_mast
						act 'Уйти':gt'gdksport'
					end
					if $npc['28,sex'] >= 6:
						act 'Дать кончить в рот':
							*clr & cla
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex10.webm', func('Voltrenersex_strings', 'local_str35')
							act 'Мастурбировать': dynamic $din_trener_mast
							act 'Уйти': gt'gdksport'
						end
					end
					if trenerSex=>3:
						act 'Подставить язык':
							*clr & cla
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensex7.webm', func('Voltrenersex_strings', 'local_str36')
							act 'Мастурбировать': dynamic $din_trener_mast
							act 'Уйти': gt'gdksport'
						end
					end
				end
				if $npc['28,sex'] >= 10:
					act 'Подставить попку':	dynamic $din_trener_anal
				end
				if $npc['28,sex'] >= 15 and vagina > 13 and sex > 0 and mesec <= 0:
					act 'Подставить киску':	dynamic $din_trener_vagin
				end
			end
		end
}
	$boy = $npc['28,name']
	silavag = 2
	dick = $npc['28,dick']
	pose = 0
if $npc['28,sex'] > 0:
	act 'Не сопротивлятся': dynamic $din_trener_sex
elseif $npc['28,sex'] = 0 and sopr ! 1:
	act 'Смотреть на тренера':
		cla
		dynamic $din_trener_talk
	end
end
act 'Уйти':gt'gdksport'