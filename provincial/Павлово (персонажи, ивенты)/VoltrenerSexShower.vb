minut += 20
gs 'stat'
$din_trener_voyeur0= {
	*clr
	gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower1.jpg', func('VoltrenerSexShower_strings', 'local_str1')
	act 'Посмотреть что за шум':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower2.jpg', func('VoltrenerSexShower_strings', 'local_str2')
		VoltrenerVoyeur += 1
		act 'Закончить мытся':gt'gdksport'
	end
}
$din_trener_voyeur1= {
	*clr
	gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower1.jpg', func('VoltrenerSexShower_strings', 'local_str3')
	act 'Закричать':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower4.jpg', func('VoltrenerSexShower_strings', 'local_str4')
		act 'Закончить мытся':gt'gdksport'
	end
	if horny >= 60 :
		act 'Мытся дальше':
			gs 'npc_editor','change_rep','+', 28
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower6.jpg', func('VoltrenerSexShower_strings', 'local_str5')
			VoltrenerVoyeur += 1
			horny += 10
			gs 'stat'
			act 'Вытерется':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower5.gif', func('VoltrenerSexShower_strings', 'local_str6')
				act 'Закончить мытся': gt'gdksport'
			end
		end
	end
}
$din_trener_voyeur2= {
	*clr & cla
	gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower1.jpg', func('VoltrenerSexShower_strings', 'local_str7')
	act 'Пригрозить пальчиком':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower7.jpg', func('VoltrenerSexShower_strings', 'local_str8')
		act 'Уйти':gt'gdksport'
	end
	if horny>=70 :
		act 'Маструбировать':
			gs 'npc_editor','change_rep','+', 28
			minut += 10
			gs 'stat'
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower8.jpg', func('VoltrenerSexShower_strings', 'local_str9')
			act 'Смотреть':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower9.gif', func('VoltrenerSexShower_strings', 'local_str10')
				VoltrenerVoyeur += 1
				orgasm += 1
				manna = 100
				horny = 0
				sopr = 0
				gs 'stat'
				act 'Смыть сперму':gt'gdksport'
			end
		end
	end
}
$din_trener_voyeur3= {
	gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower10.jpg', func('VoltrenerSexShower_strings', 'local_str11')
	act 'Рассмотреть получше':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower19.jpg', func('VoltrenerSexShower_strings', 'local_str12')
		orgasm += 1
		analorgasm +=1
		manna = 100
		horny = 0
		minut += 10
		gs 'stat'
		act 'Прийти в себя':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower20.gif', func('VoltrenerSexShower_strings', 'local_str13')
			act 'Раздвинуть попку':
				VoltrenerVoyeur += 1
				gs 'npc_editor','change_rep','+', 28
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower11.gif', func('VoltrenerSexShower_strings', 'local_str14')
				act 'Вымыть попку': gt'gdksport'
			end
			act 'Испугатся':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower12.jpg', func('VoltrenerSexShower_strings', 'local_str15')
				act 'Вымыть попку': gt'gdksport'
			end
			act 'Вымыть попку': gt'gdksport'
		end
	end
}
$din_trener_voyeur4= {
	gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower10.jpg', func('VoltrenerSexShower_strings', 'local_str16')
	act 'Рассмотреть получше':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower19.jpg', func('VoltrenerSexShower_strings', 'local_str17')
		act 'Отпустится на колени':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower14.gif', func('VoltrenerSexShower_strings', 'local_str18')
			act 'Лизать яйца':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower15.gif', func('VoltrenerSexShower_strings', 'local_str19')
				act 'Подставить лицо':
					*clr & cla
					facial += 1
					gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower16.gif', func('VoltrenerSexShower_strings', 'local_str20')
					act 'Обернутся':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower17.jpg', func('VoltrenerSexShower_strings', 'local_str21')
						VoltrenerVoyeur += 1
						horny = 100
						facial += 1
						minut += 15
						gs 'npc_editor','change_rep','+', 28
						gs 'stat'
						act 'Маструбировать':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower18.jpg', func('VoltrenerSexShower_strings', 'local_str22')
							orgasm += 1
							horny = 0
							gs 'stat'
							act 'Вымыть лицо': gt 'gdksport'
						end
						act 'Вымыть лицо': gt 'gdksport'
					end
				end
			end
		end
	end
}
$din_trener_voyeur5= {
	gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower10.jpg', func('VoltrenerSexShower_strings', 'local_str23')
	act 'Рассмотреть получше':
		*clr & cla
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower19.jpg', func('VoltrenerSexShower_strings', 'local_str24')
		if horny < 40:
			act'Закрыть дверь душевой':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower21.jpg', func('VoltrenerSexShower_strings', 'local_str25')
				act 'Уйти':gt'gdksport'
			end
		else
			act'Соблазнить тренера':
				*clr & cla
				gs 'npc_editor','change_rep','+', 28
				VoltrenerVoyeur+=1
				ShowerIvan = 0 & ! закрываю секс с тренером в душевой
				volleytanga = 1 & ! Открываю опять тренировку без трусикв
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower22.jpg', func('VoltrenerSexShower_strings', 'local_str26')
				act 'На колени':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower23.jpg', func('VoltrenerSexShower_strings', 'local_str27')
					act 'Взять в рот':
						*clr & cla
						horny += 10
						bj += 1
						minut += 10
						throat += 1
						gs 'stat'
						gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower24.gif', func('VoltrenerSexShower_strings', 'local_str28')
						act 'Задрать ноги':
							*clr & cla
							minut += 15
							$boy = $npc['28,name']
							silavag = 2
							dick = $npc['28,dick']
							pose = 0
							if $npc['28,sex'] = 0: $npc['28,sex'] = 1 & guy += 1
							gs 'stat'
							gs 'zz_render', '', '', func('VoltrenerSexShower_strings', 'local_str29')
							if vagina = 0 and sex = 0:
								gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower26.gif', func('VoltrenerSexShower_strings', 'local_str30')
							elseif vagina <= 10:
								gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower26.gif', func('VoltrenerSexShower_strings', 'local_str31')
							elseif vagina > 10 and mesec <= 0:
								gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower25.gif', func('VoltrenerSexShower_strings', 'local_str32')
								act 'Запрыгнуть на член':
									*clr & cla
									pose = 2
									gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower27.jpg', func('VoltrenerSexShower_strings', 'local_str33')
									gs 'zz_dynamic_sex', 'vaginal', 'dick'
									gs 'zz_dynamic_sex', 'sex_cum'
									act 'Уйти': gt 'gdksport'
								end
							end
							act 'Подставить попку':
								*clr & cla
								gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower28.jpg', func('VoltrenerSexShower_strings', 'local_str34')
								act 'Расслабить попку':
									*clr & cla
									gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSexShower29.gif', func('VoltrenerSexShower_strings', 'local_str35')
									gs 'zz_dynamic_sex', 'anal_start', 'dick'
									gs 'zz_dynamic_sex', 'anal', 'dick'
									gs 'zz_dynamic_sex', 'anal_cum'
									act 'Уйти': gt 'gdksport'
								end
							end
						end
					end
				end
			end
		end
	end
}
if ShowerIvan ! 1:
	gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSexShower.jpg'
	act 'Мытся':
		*clr & cla
		if VoltrenerVoyeur=0: dynamic $din_trener_voyeur0
		if VoltrenerVoyeur=1: dynamic $din_trener_voyeur1
		if VoltrenerVoyeur=2: dynamic $din_trener_voyeur2
	end
else
	if VoltrenerVoyeur=3: dynamic $din_trener_voyeur3
	if VoltrenerVoyeur=4: dynamic $din_trener_voyeur4
	if VoltrenerVoyeur=5: dynamic $din_trener_voyeur5
end
act 'Уйти':gt'gdksport'