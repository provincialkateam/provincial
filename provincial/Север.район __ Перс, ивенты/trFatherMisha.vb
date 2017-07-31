!сперма на лице
if cumface > 0:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_13.jpg', func('trFatherMisha_strings', 'local_str1')
	$npc['43,qwBioOtec'] = -1
	act 'Уйти': minut += 5 & gt 'Terminal'
	exit
end
!сперма на одежде
if cumfrot > 0:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_18.jpg', func('trFatherMisha_strings', 'local_str2')
	$npc['43,qwBioOtec'] = -1
	act 'Уйти':minut += 5 & gt 'Terminal'
	exit
end
$fatherMisha_end = {
	act 'Попрощаться':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_15.jpg', func('trFatherMisha_strings', 'local_str3')
		if fatherMishaCar > 0:
			act 'Уйти': minut += 5 & gt 'gorodok'
			exit
		end
		act 'Уйти': minut += 5 & gt 'Terminal'
	end
}
if $npc['43,qwBioOtec2'] = 0:$npc['43,qwBioOtec2'] = 1
if fatherMishaCar > 0:fatherMishaCar = 0
!встречи
if $npc['43,qwBioOtec2'] = 1:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('trFatherMisha_strings', 'local_str4')
	act 'В шашлычную':
		*clr & cla
		if water < 20: water += 20
		gs 'zz_kitchen_acts','eat','','images/qwest/alter/trfatherQW/trfatherQW_17.jpg',func('trFatherMisha_strings', 'local_str5')
		gs 'stat'
		act 'Поддержать':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_19.jpg', func('trFatherMisha_strings', 'local_str6')
			$npc['43,qwBioOtec2'] = 2
			dynamic $fatherMisha_end
		end
		act 'Продолжить расспрашивать':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_17.jpg', func('trFatherMisha_strings', 'local_str7')
			dynamic $fatherMisha_end
		end
	end
	act 'В быстроешку':
		*clr & cla
		if water < 20: water += 20
		gs 'zz_kitchen_acts','eat','','images/qwest/alter/trfatherQW/trfatherQW_20.jpg', func('trFatherMisha_strings', 'local_str8')
		gs 'stat'
		act 'Оглянуться':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_21.jpg', func('trFatherMisha_strings', 'local_str9')
			dynamic $fatherMisha_end
		end
	end
elseif $npc['43,qwBioOtec2'] = 2:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('trFatherMisha_strings', 'local_str10')
	act 'В быстроешку':
		*clr & cla
		if water < 20: water += 20
		gs 'zz_kitchen_acts','eat','','images/qwest/alter/trfatherQW/trfatherQW_20.jpg', func('trFatherMisha_strings', 'local_str11')
		gs 'stat'
		act 'Оглянуться':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_21.jpg', func('trFatherMisha_strings', 'local_str12')
			act 'Отказаться':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_21.jpg', func('trFatherMisha_strings', 'local_str13')
				dynamic $fatherMisha_end
			end
			act 'Участвовать в конкурсе':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_22.jpg', func('trFatherMisha_strings', 'local_str14')
				$npc['43,qwBioOtec2'] = 3
				dynamic $fatherMisha_end
			end
		end
	end
	act 'К аттракционам':
		*clr & cla
		minut += 30
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_23.jpg', func('trFatherMisha_strings', 'local_str15')
		act 'Гулять по парку':
			*clr & cla
			minut += 15
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_24.jpg', func('trFatherMisha_strings', 'local_str16')
			dynamic $fatherMisha_end
		end
		act 'Купить сладкую вату':
			*clr & cla
			minut += 15
			manna += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_25.jpg', func('trFatherMisha_strings', 'local_str17')
			dynamic $fatherMisha_end
		end
	end
elseif $npc['43,qwBioOtec2'] = 3:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('trFatherMisha_strings', 'local_str18')
	act 'К аттракционам':
		*clr & cla
		minut += 30
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_23.jpg', func('trFatherMisha_strings', 'local_str19')
		act 'Кататься на карусели':
			*clr & cla
			minut += 15
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_26.jpg', func('trFatherMisha_strings', 'local_str20')
			act 'Придержать платье':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_27.jpg', func('trFatherMisha_strings', 'local_str21')
				dynamic $fatherMisha_end
			end
			act 'Приподнять платье':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_28.jpg', func('trFatherMisha_strings', 'local_str22')
				$npc['43,qwBioOtec2'] = 4
				dynamic $fatherMisha_end
			end
		end
		act 'Стрелять в тире':
			*clr & cla
			minut += 15
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_29.jpg', func('trFatherMisha_strings', 'local_str23')
			dynamic $fatherMisha_end
		end
	end
	act 'В парк':
		*clr & cla
		minut += 30
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_24.jpg', func('trFatherMisha_strings', 'local_str24')
		act 'Гулять дальше':
			*clr & cla
			minut += 15
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_30.jpg', func('trFatherMisha_strings', 'local_str25')
			act 'Присмотреться':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_31.jpg', func('trFatherMisha_strings', 'local_str26')
				dynamic $fatherMisha_end
			end
			dynamic $fatherMisha_end
		end
		dynamic $fatherMisha_end
	end
elseif $npc['43,qwBioOtec2'] = 4:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('trFatherMisha_strings', 'local_str27')
	act 'В парк':
		*clr & cla
		minut += 30
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_24.jpg', func('trFatherMisha_strings', 'local_str28')
		act 'Стрелять в тире':
			*clr & cla
			minut += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_32.jpg', func('trFatherMisha_strings', 'local_str29')
			act 'Учиться стрелять':
				*clr & cla
				minut += 10
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_33.jpg', func('trFatherMisha_strings', 'local_str30')
				act 'Прижаться':
					*clr & cla
					minut += 10
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_34.jpg', func('trFatherMisha_strings', 'local_str31')
					$npc['43,qwBioOtec2'] = 5
					dynamic $fatherMisha_end
				end
				act 'Сконцентрироваться':
					*clr & cla
					minut += 10
					manna += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_35.jpg', func('trFatherMisha_strings', 'local_str32')
					dynamic $fatherMisha_end
				end
			end
			act 'Отказаться':
				*clr & cla
				minut += 10
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_36.jpg', func('trFatherMisha_strings', 'local_str33')
				dynamic $fatherMisha_end
			end
		end
		act 'В кафе':
			*clr & cla
			if water < 20: water += 20
			gs 'zz_kitchen_acts','eat','','images/qwest/alter/trfatherQW/trfatherQW_37.jpg', func('trFatherMisha_strings', 'local_str34')
			gs 'stat'
			dynamic $fatherMisha_end
		end
	end
elseif $npc['43,qwBioOtec2'] = 5:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('trFatherMisha_strings', 'local_str35')
	act 'В кафе':
		*clr & cla
		if water < 20:water += 20
		gs 'zz_kitchen_acts','eat','','images/qwest/alter/trfatherQW/trfatherQW_37.jpg', func('trFatherMisha_strings', 'local_str36')
		gs 'stat'
		act 'Нюхать цветочки':
			*clr & cla
			minut += 10
			manna += 50
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_38.jpg', func('trFatherMisha_strings', 'local_str37')
			dynamic $fatherMisha_end
		end
		act 'Спросить про женщин':
			*clr & cla
			minut += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_37.jpg', func('trFatherMisha_strings', 'local_str38')
			act 'Поцеловать':
				*clr & cla
				minut += 5
				horny += 10
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_39.jpg', func('trFatherMisha_strings', 'local_str39')
				$npc['43,qwBioOtec2'] = 6
				dynamic $fatherMisha_end
			end
			dynamic $fatherMisha_end
		end
	end
	act 'Покататься':
		*clr & cla
		minut += 30
		manna += 10
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_40.jpg', func('trFatherMisha_strings', 'local_str40')
		fatherMishaCar = 1
		dynamic $fatherMisha_end
	end
elseif $npc['43,qwBioOtec2'] = 6:
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('trFatherMisha_strings', 'local_str41')
	act 'Покататься':
		*clr & cla
		minut += 30
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_40.jpg', func('trFatherMisha_strings', 'local_str42')
		fatherMishaCar = 1
		act 'Сесть на колени':
			*clr & cla
			minut += 5
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_41.jpg', func('trFatherMisha_strings', 'local_str43')
			act 'К ширинке':
				*clr & cla
				minut += 5
				horny += 10
				gs 'zz_funcs', 'cum', 'lip'
				bj += 1
				guy += 1
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_42.jpg', func('trFatherMisha_strings', 'local_str44')
				act 'Выйти':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_43.jpg', func('trFatherMisha_strings', 'local_str45')
					if vagina = 0:'- Ты будешь моим первым мужчиной, - с этими словами вы вставили член в писю и папа сорвал ваш девственный цветок'
					vagina += 1
					sex += 1
					horny = 0
					orgasm += 1
					gs 'zz_render', '', '', func('trFatherMisha_strings', 'local_str46')
					gs 'zz_funcs', 'cum', 'pussy'
					$npc['43,qwBioOtec2'] = 7
					dynamic $fatherMisha_end
				end
			end
			act 'Остановиться':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_44.jpg', func('trFatherMisha_strings', 'local_str47')
				$npc['43,qwBioOtec2'] = 1
				dynamic $fatherMisha_end
			end
		end
		act 'Сесть в кресло':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_45.jpg', func('trFatherMisha_strings', 'local_str48')
			dynamic $fatherMisha_end
		end
	end
elseif $npc['43,qwBioOtec2'] = 7:
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render', '', '', func('trFatherMisha_strings', 'local_str49')
	dynamic $fatherMisha_end
end