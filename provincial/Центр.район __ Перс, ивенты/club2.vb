if $ARGS[0] = 'туалет1':
	*clr & cla
	gs 'zz_render', '', 'images/pics/glory.jpg', func('club2_strings', 'local_str1')
	act 'Убежать':gt'club','inside'
	act 'Рассмотреть ближе':
		*clr & cla
		vaf += 1
		if TQuest = 1: TQuest = 2
		guy += 1
		bj += 1
		horny += 5
		throat += 1
		gs 'zz_render', '', 'images/pics/glory1.jpg', func('club2_strings', 'local_str2')
		act 'Охватить губами':
			*clr & cla
			gs 'zz_render', '', 'images/pics/glory2.jpg', func('club2_strings', 'local_str3')
			act 'Проглотить':
				*clr & cla
				vaf += 2
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				money += 2000
				gs 'stat'
				gs 'zz_render', '', 'images/pics/glory3.jpg', func('club2_strings', 'local_str4')
				act 'Уйти': gt'club','inside'
			end
			act 'Выплюнуть':
				cla
				gs 'zz_funcs', 'cum', 'lip'
				money += 1000
				gs 'stat'
				gs 'zz_render', '', 'images/pics/glory3.jpg', func('club2_strings', 'local_str5')
				act 'Уйти': gt'club','inside'
			end
		end
	end
end
if $ARGS[0] = 'туалет':
	*clr & cla
	gs 'zz_render', '', '', func('club2_strings', 'local_str6')
	act 'Уйти': gt'street'
	act 'Ласкать себя':
		cla
		TQuest = 1
		horny = 0
		mastr += 1
		orgasm += 1
		money += 1000
		gs 'stat'
		gs 'zz_render', '', 'images/pics/tomas.jpg', func('club2_strings', 'local_str7')
		act 'Убежать': gt'club','inside'
	end
end
if $ARGS[0] = 'туалет2':
	*clr & cla
	gs 'zz_render', '', '', func('club2_strings', 'local_str8')
	act 'Убежать': gt'club','inside'
	act 'Ждать':
		cla
		slutiness += 10
		gs 'zz_render', '', 'images/pics/glory4.jpg', func('club2_strings', 'local_str9')
		wait 500
		*clr
		gs 'zz_render', '', 'images/pics/glory5.jpg', func('club2_strings', 'local_str10')
		wait 500
		*clr
		gs 'zz_render', '', 'images/pics/glory6.jpg', func('club2_strings', 'local_str11')
		wait 500
		*clr
		gs 'zz_render', '', 'images/pics/glory7.jpg', func('club2_strings', 'local_str12')
		gs 'zz_funcs', 'hornyrand'
		wait 500
		money += 3000
		gs 'zz_render', '', '', func('club2_strings', 'local_str13')
		wait 500
		TQuest = 3
		if pornstudio = 0: pornstudio = 2
		guy += 2
		bj += 2
		swallow += 2
		gs 'zz_funcs', 'cum', 'lip'
		deep += 2
		gs 'stat'
		gs 'zz_render', '', '', func('club2_strings', 'local_str14')
		act 'Уйти': gt'club','inside'
	end
end