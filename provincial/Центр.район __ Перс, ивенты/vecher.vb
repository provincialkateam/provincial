if $ARGS[0] = 'start':
	*clr & cla
	gs 'zz_render', '', 'images/img/centr/vecher.jpg', func('vecher_strings', 'local_str1')
	act 'Уйти': gt'dorm','korr'
	act 'Зажигать':
		cla
		hour = 23
		gs 'zz_funcs', 'alko', 6
		gs 'zz_render', '', '', func('vecher_strings', 'local_str2')
		gt 'vecher', 'end<<RAND(1,12)>>'
	end
end
if $ARGS[0] = 'end1':
	*clr & cla
	gs 'zz_render', '', 'images/picparty/itog.jpg', func('vecher_strings', 'local_str3')
	act 'Уйти': gt'dorm','korr'
end
if $ARGS[0] = 'end2':
	*clr & cla
	gs 'zz_render', '', 'images/picparty/itog2.jpg', func('vecher_strings', 'local_str4')
	act 'Уйти': gt'dorm','korr'
	act 'Уйти с Викой в комнату':
		if vikasex = 0: vikasex = 1
		$sexloc = 'obroom'
		gt 'lezbsex','start'
	end
end
if $ARGS[0] = 'end3':
	*clr & cla
	act 'Уйти': gt'dorm','korr'
	if vnesh < 40:
		gs 'zz_render', '', 'images/picparty/itog3.jpg"', func('vecher_strings', 'local_str5')
	else
		gs 'zz_render', '', 'images/img/centr/vechend1.jpg', func('vecher_strings', 'local_str6')
		act 'Наслаждаться':
			*clr & cla
			if vikasex = 0: vikasex = 1
			orgasm += 1
			girl += 4
			lesbian += 1
			gs 'zz_render', '', 'images/img/centr/vechend2.jpg', func('vecher_strings', 'local_str7')
			act 'Продолжать': gt'vecher','end13'
		end
	end
end
if $ARGS[0] = 'end4':
	*clr & cla
	gs 'zz_render', '', 'images/picparty/itog4.jpg', func('vecher_strings', 'local_str8')
	act 'Уйти': gt 'dorm','korr'
	act 'Уйти с Викой в пустую комнату':
		if vikasex = 0: vikasex = 1
		$sexloc = 'obroom'
		gt 'lezbsex','start'
	end
end
if $ARGS[0] = 'end5':
	*clr & cla
	guy += 1
	sex += 1
	gs 'zz_render', '', 'images/img/centr/itog5.jpg', func('vecher_strings', 'local_str9')
	act 'Уйти': gt'dorm','korr'
end
if $ARGS[0] = 'end6':
	*clr & cla
	gs 'zz_render', '', 'images/picparty/itog6.jpg', func('vecher_strings', 'local_str10')
	act 'Уйти': gt'dorm','korr'
end
if $ARGS[0] = 'end7':
	*clr & cla
	gs 'zz_render', '', 'images/img/centr/itog7.jpg', func('vecher_strings', 'local_str11')
	act 'Дать по яйцам и уйти':gt'dorm','korr'
	act 'Снять трусики':
		*clr & cla
		guy += 1
		bj += 1
		sex += 1
		gs 'zz_funcs', 'cum', 'ass'
		gs 'zz_render', '', 'images/img/centr/itog71.jpg', func('vecher_strings', 'local_str12')
		act 'Сосать':
			*clr & cla
			gs 'zz_render', '', 'images/img/centr/itog72.jpg', func('vecher_strings', 'local_str13')
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/img/centr/itog73.jpg', func('vecher_strings', 'local_str14')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/img/centr/itog74.jpg', func('vecher_strings', 'local_str15')
					act 'Уйти': gt'dorm','korr'
				end
			end
		end
	end
end
if $ARGS[0] = 'end8':
	*clr & cla
	gs 'zz_render', '', 'images/picparty/itog8.jpg', func('vecher_strings', 'local_str16')
	act 'Уйти':gt'dorm','korr'
	act 'Ласкать Вику':
		*clr & cla
		if vikasex = 0: vikasex = 1
		girl += 1
		lesbian += 1
		horny += 60
		gs 'zz_render', '', 'images/img/centr/itog81.jpg', func('vecher_strings', 'local_str17')
		if horny < 100:
			gs 'zz_render', '', '', func('vecher_strings', 'local_str30')
		else
			horny = 0
			orgasm += 1
			gs 'zz_render', '', '', func('vecher_strings', 'local_str31')
		end
		gs 'zz_render', '', '', func('vecher_strings', 'local_str18')
		act 'Наблюдать':
			*clr & cla
			gs 'zz_render', '', 'images/img/centr/itog82.jpg', func('vecher_strings', 'local_str19')
			act 'Целоваться с Викой':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_render', '', 'images/img/centr/itog83.jpg', func('vecher_strings', 'local_str20')
				act 'Уйти': gt'dorm','korr'
			end
		end
		act 'Сосать вместе с Викой':
			*clr & cla
			bj += 1
			guy += 1
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_render', '', 'images/img/centr/itog84.jpg', func('vecher_strings', 'local_str21')
			act 'Целоваться с Викой':
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_render', '', 'images/img/centr/itog83.jpg', func('vecher_strings', 'local_str22')
				act 'Уйти': gt'dorm','korr'
			end
		end
	end
end
if $ARGS[0] = 'end9':
	cla
	gs 'zz_render', '', 'images/picparty/itog9.jpg', func('vecher_strings', 'local_str23')
	act 'Уйти': gt'dorm','korr'
end
if $ARGS[0] = 'end10':
	cla
	gs 'zz_render', '', 'images/picparty/itog10.jpg', func('vecher_strings', 'local_str24')
	act 'Уйти':gt'dorm','korr'
	act 'Потрогать за ширинку':
		$sexloc = 'obroom'
		gt 'sex','start'
	end
end
if $ARGS[0] = 'end11':
	*clr & cla
	cumfrot += 1
	gs 'zz_render', '', 'images/picparty/skirtcum.jpg', func('vecher_strings', 'local_str25')
	act 'Уйти':gt'dorm','korr'
end
if $ARGS[0] = 'end12':
	*clr & cla
	minut += 15
	gs 'zz_render', '', 'images/img/centr/college/college_ass_show'+RAND(1,5)+'.jpg', func('vecher_strings', 'local_str26')
	act 'Уйти':gt'dorm','korr'
end
if $ARGS[0] = 'end13':
	*clr & cla
	minut += 15
	gs 'zz_render', '', 'images/img/centr/vechend'+RAND(3,9)+'.jpg', func('vecher_strings', 'local_str27')
	act 'Еще': gt 'vecher','end13'
	act 'Уйти': gt 'dorm','korr'
end
if $ARGS[0] = 'twister':
	*clr & cla
	hour = 23
	gs 'zz_render', '', 'images/img/centr/college/twister0.jpg', func('vecher_strings', 'local_str28')
	act 'Уйти': gt 'dorm','korr'
	act 'Раздеться': gt 'vecher','twister_nude'
end
if $ARGS[0] = 'twister_nude':
	*clr & cla
	minut += 15
	horny += 30
	gs 'zz_render', '', 'images/img/centr/college/twister'+RAND(1,8)+'.jpg', func('vecher_strings', 'local_str29')
	act 'Уйти':gt'dorm','korr'
end