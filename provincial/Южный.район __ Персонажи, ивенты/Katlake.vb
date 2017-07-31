if $ARGS[0] = '': $ARGS[0] = 'start'
if $ARGS[0] = 'start':
	gs 'zz_render', '', 'images/img/Lake/kat.jpg', func('Katlake_strings', 'local_str1')
	act 'Не подходить': gt 'Nudelake'
	act 'Подойти':
		cla
		gs 'zz_render', '', '', func('Katlake_strings', 'local_str2')
		act 'Привет': gt 'Katlake','znakomstvo'
	end
end
if $ARGS[0] = 'znakomstvo':
	*clr & cla
	if vnesh < 40:
		katday = day
		gs 'zz_render', '', 'images/img/Lake/kat.jpg', func('Katlake_strings', 'local_str3')
		act 'Уйти': gt 'Nudelake'
	else
		cla
		katday = day
		telkat += 1
		gs 'npc_editor','change_rep','+',33
		minut += 30
		gs 'stat'
		gs 'zz_render', '', 'images/img/Lake/kat.jpg', func('Katlake_strings', 'local_str4')
		act 'Уйти': gt 'Nudelake'
	end
end
if $ARGS[0] = 'kat':
	*clr & cla
	minut += 30
	gs 'zz_render', '', 'images/img/Lake/kat.jpg', func('Katlake_strings', 'local_str5')
	act 'Уйти': gt 'Nudelake'
	act 'Предложить сыграть в волейбол': gt 'Katlake','voleybol'
	act 'Предложить прогуляться': gt'Katlake','walk'
	act 'Поболтать':
		cla
		katday = day
		gs 'npc_editor','change_rep','+', 33
		minut += 30
		gs 'stat'
		gs 'zz_render', '', '', func('Katlake_strings', 'local_str6')
		act 'Уйти': gt 'Nudelake'
	end
end
if $ARGS[0] = 'voleybol':
	*clr & cla
	katday = day
	gs 'npc_editor','change_rep','+', 33
	minut += 30
	agil += 1
	react += 1
	speed += 1
	gs 'stat'
	gs 'zz_render', '', 'images/img/Lake/voleybol.jpg', func('Katlake_strings', 'local_str7')
	act 'Закончить': gt 'Nudelake'
end
if $ARGS[0] = 'walk':
	*clr & cla
	katday = day
	gs 'npc_editor','change_rep','+', 33
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/img/Lake/kat.jpg', func('Katlake_strings', 'local_str8')
	act 'Закончить': gt 'Nudelake'
	if $npc['33,relation'] > 60 :
		i = rand(0,100)
		if i >= 80 and i < 90: gt 'Katlake','kwlake1'
		if i >= 90: gt 'Katlake','kwlake2'
	end
end
if $ARGS[0] = 'key':
	*clr & cla
	katkey = 1
	gs 'npc_editor','change_rep','+', 33
	minut += 60
	gs 'stat'
	gs 'zz_render', '', 'images/img/Lake/sun.jpg', func('Katlake_strings', 'local_str9')
	act 'Идти с Кэт': gt'kathouse0'
end
if $args[0] = 'kwlake1':
	gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake1.jpg', func('Katlake_strings', 'local_str11')
	act 'Посмеяться': gt 'Katlake','kwlake1_end'
	act 'Ласкать её':
		*clr & cla
		$npc['33,sex'] += 1
		gs 'npc_editor','change_rep','+', 33
		lesbian += 1
		gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake2.jpg', func('Katlake_strings', 'local_str12')
		act 'Лечь':
			*clr & cla
			kuni += 1
			gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake3.jpg', func('Katlake_strings', 'local_str13')
			act 'Уйти': gt'Nudelake'
			act 'Подозвать парня':
				*clr & cla
				gs 'npc_editor','change_rep','+', 33
				mastr += 1
				orgasm += 1
				gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake4.jpg', func('Katlake_strings', 'local_str14')
				act 'Подойти к Кэт':
					*clr & cla
					gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake5.jpg', func('Katlake_strings', 'local_str15')
					act '...':
						*clr & cla
						anal += 1
						gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake6.jpg', func('Katlake_strings', 'local_str16')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/img/Lake/kwlake1/kwlake7.jpg', func('Katlake_strings', 'local_str17')
							act 'Уйти': gt'Nudelake'
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'kwlake1_end':
	cla
	gs 'zz_render', '', '', func('Katlake_strings', 'local_str18')
	act 'Закончить': gt'Nudelake'
end
if $args[0] = 'kwlake2':
	gs 'zz_render', '', 'images/img/Lake/kwlake2/kwlake1.jpg', func('Katlake_strings', 'local_str21')
	act 'Нет, пойдем отсюда': gt'Nudelake'
	act 'Давай':
		*clr & cla
		gs 'npc_editor','change_rep','+', 33
		gs 'zz_render', '', 'images/img/Lake/kwlake2/kwlake2.jpg', func('Katlake_strings', 'local_str22')
		act 'Кэт, хватит, пошли отсюда': gt'Nudelake'
		act 'Позвать мужчину':
			*clr & cla
			$npc['33,sex'] += 1
			gs 'npc_editor','change_rep','+', 33
			kuni += 1
			bj += 1
			gs 'zz_render', '', 'images/img/Lake/kwlake2/kwlake3.jpg', func('Katlake_strings', 'local_str23')
			act '...':
				*clr & cla
				sex += 1
				gs 'zz_render', '', 'images/img/Lake/kwlake2/kwlake4.jpg', func('Katlake_strings', 'local_str24')
				act '...':
					*clr & cla
					gs 'zz_funcs', 'cum', 'lip'
					orgasm += 1
					gs 'zz_render', '', 'images/img/Lake/kwlake2/kwlake5.jpg', func('Katlake_strings', 'local_str25')
					act 'Уйти': gt'Nudelake'
				end
			end
		end
	end
end