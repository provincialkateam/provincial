﻿! vaginal only
if $args[0] = 'vaginal':
	i = 0
	:loop_bang
	gs 'zz_render', '', '', func('porn_view_strings', 'view_31_sex_next'+i)
	if tabletki = 0 and prezik = 0:
		gs 'zz_render', '', '', func('porn_view_strings', 'view_31'+iif(rand(0,10)>(6+i),'_cum'+i,'_no_condom'))
	else
		if tabletki > 0:
			gs 'zz_render', '', '', func('porn_view_strings', 'view_31_pills')
		elseif prezik > 0:
			gs 'zz_render', '', '', func('porn_view_strings', 'view_31_condom')
			prezik -= 1
		end
	end
	i += 1
	if i < 3: jump 'loop_bang'
end
! random w/o dp
if $args[0] = 'random':
	$_var_arr[0] = 'рот'
	$_var_arr[1] = 'киску'
	$_var_arr[2] = 'попу'
	_vaginal = 0
	! i = 0 - doggy
	! i > 0 - missionary
	i = 0
	:loop_random_bang
	_var = rand(0,2)
	if _var = 1: _vaginal += 1
	! vaginal required
	if i = 2 and _vaginal = 0: _var = 1
	$sex_variant = $_var_arr[_var]
	gs 'zz_render', '', '', func('porn_view_strings', 'view_pose_'+iif(i = 2 and _var = 1,3,i))
	! mouth
	if _var = 0:
		gs 'zz_render', '', '', func('porn_view_strings', 'view_cum_on4')
		bj += 1
		swallow += 1
	end
	! vag
	if _var = 1:
		gs 'porn_view_construct', 'cum_warning'
		if i = 2: gs 'zz_render', '', '', func('porn_view_strings', 'view_pose_4')
		if tabletki = 0 and prezik = 0:
			j = rand(0,10)
			gs 'zz_render', '', '', func('porn_view_strings', 'view_cum_on'+iif(j>(6+i),1,iif(i=0,2,5)))
			if j>(6+i): gs 'zz_render', '', '', func('porn_view_strings', iif(rand(0,1)=0,'view_cum_in'+rand(0,5),'view_cum_in_mind'+rand(0,2)))
		else
			if tabletki > 0:
				gs 'zz_render', '', '', func('porn_view_strings', 'view_pills')
			elseif prezik > 0:
				gs 'zz_render', '', '', func('porn_view_strings', 'view_condom')
				prezik -= 1
			end
		end
		sex += 1
	end
	! ass
	if _var = 2:
		gs 'zz_render', '', '', func('porn_view_strings', 'view_cum_on'+iif(i=0,rand(2,3),3))
		anal += 1
	end
	i += 1
	if i < 3: jump 'loop_random_bang'
	gs 'zz_render', '', '', func('porn_view_strings', 'view_end')
	killvar '_var'
	killvar '_vaginal'
	killvar '$_var_arr'
end
if $args[0] = 'dp':
	gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/9.webm', func('porn_view_strings', 'view_36_dp0')+func('porn_view_strings', 'view_36_dp1')
	if tabletki = 0 and prezik = 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_cum_in_mind'+rand(0,2))
	gs 'zz_render', '', '', func('porn_view_strings', 'view_36_fin')
	anal += 2
	sex += 1
	bj += 3
	if anus <= 10: anus += 1
end
if $args[0] = 'cum_warning':
	if tabletki = 0 and prezik = 0:
		gs 'zz_render', '', '', func('porn_view_strings', 'view_no_condom')
	elseif tabletki > 0:
		gs 'zz_render', '', '', func('porn_view_strings', 'view_pills')
	end
end
if $args[0] = 'wdays':
	gs 'zz_render', '', '', func('porn_view_strings', 'view_32_wdays')
	gs 'porn_view_construct', 'no_pussy'
end
if $args[0] = 'no_pussy':
	i = rand(0,3)
	gs 'zz_render', '', '', func('porn_view_strings', 'view_31_rand'+i)
	if i = 0:
		kuni += 1
		hj += 1
		bj += 3
		swallow += 3
	elseif i = 1:
		anal += 3
		bj += 2
		if anus <= 10: anus += 1
	elseif i = 2:
		bj += 3
		swallow += 3
	else
		kuni += 1
		hj += 1
		bj += 2
		swallow += 2
		anal += 1
		if anus <= 5: anus += 1
	end
end