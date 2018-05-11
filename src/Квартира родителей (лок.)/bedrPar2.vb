if $args = 'main':
	act func('bedrPar2_strings'+$lang, 'act5'): gt 'korrPar'
	$metka = $ARGS[0]
	$loc = $CURLOC
	if hour = 21 and father['horny'] >= 70 and family_trip = 0: gt 'seeparentsex'
	minut += 1
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	if (hour >= 21 or hour < 6) and family_trip = 0:
		if week ! 1:
			gs 'zz_render',func('bedrPar2_strings'+$lang, 'act1'),'pavlovo/family/parents/parents_sleep',func('bedrPar2_strings'+$lang, '1')
		else
			if parentsexday = day:
				gs 'zz_render',func('bedrPar2_strings'+$lang, 'act1'),'pavlovo/family/parents/mother_sleep',func('bedrPar2_strings'+$lang, '2')
			else
				gt $curloc, 'mom_selfplay'
			end if
		end
		exit
	else
		gs 'zz_render',func('bedrPar2_strings'+$lang, 'act1'),'pavlovo/family/apartment/bedr_par',func('bedrPar2_strings'+$lang, '3')
	end
	gs 'zz_family', 'mother_sheduler'
	if $mother['location'] = $curloc and (cloth[0] <= 2 or alko >= 6): *clr & gs 'mother' & exit
	if hour > 7 and hour < 21 and $mother['location'] ! $curloc:
		if kamasutra_day ! day: gs 'zz_render','','',func('bedrPar2_strings'+$lang, '4')
		if condomday ! day:
			if condomProver >= 3:
				condomday = day - 4
				act func('bedrPar2_strings'+$lang, 'act4'):
					*clr & cla
					minut += rand(5,7)
					condom += rand(1,3)
					condomday = day
					condomProver = 0
					gs 'zz_render','','pavlovo/family/parents/condoms_steal',func('bedrPar2_strings'+$lang, '5')
					act func('bedrPar2_strings'+$lang, 'act5'): gt 'korrPar'
				end
			else
				gs 'zz_render','','',func('bedrPar2_strings'+$lang, '6')
			end
		end
	end
end
! book
if $args = 'kamasutra':
	*clr & cla
	minut += 1
	kamasutra_day = day
	kamasutra_page = 0
	gs 'zz_render','','pavlovo/family/parents/book',func('bedrPar2_strings'+$lang, '7')
	act func('bedrPar2_strings'+$lang, 'act2'): gt 'bedrPar2', 'read_book'
	act func('bedrPar2_strings'+$lang, 'act3'): gt $loc, $metka
end
! read book
if $args = 'read_book':
	*clr & cla
	horny += 2
	minut += 3
	gs 'stat'
	if (hour = 20 and minut > 50) or hour = 21:
		gs 'zz_render','','pavlovo/family/parents/kamasutra/ik' + kamasutra_page,func('bedrPar2_strings'+$lang, '8')
	else
		gs 'zz_render','','pavlovo/family/parents/kamasutra/ik' + kamasutra_page,func('bedrPar2_strings'+$lang, '9')
		if horny >= 60 and week = 6 and family_trip = 1: act func('bedrPar2_strings'+$lang, 'act6'): gt 'selfplay'
	end
	act func('bedrPar2_strings'+$lang, 'act13'): gt $loc, $metka
end
! parent`s wardrobe
if $args = 'parents_wardrobe':
	*clr & cla
	gs 'zz_render','','pavlovo/family/parents/wardrobe',func('bedrPar2_strings'+$lang, '10')
	act func('bedrPar2_strings'+$lang, 'act7'): gt 'bedrPar2', 'wardrobe_search'
	act func('bedrPar2_strings'+$lang, 'act8'): gt $loc, $metka
end
if $args = 'wardrobe_search':
	*clr & cla
	if rand(1,100) > 75:
		gs 'zz_render','','pavlovo/family/parents/wardrobesearch'+rand(1,4), func('bedrPar2_strings'+$lang, ''+rand(11,13))
	else
		gs 'zz_render','','pavlovo/family/parents/wardrobetoy.jpg', func('bedrPar2_strings'+$lang, ''+rand(14,16))
	end
	act func('bedrPar2_strings'+$lang, 'act9'): gt $loc, $metka
end
if $args[0] = 'momtoy_play':
	*clr & cla
	dildo = 1
	dildohand = 10
	selfmomtoyplay = 1
	gs 'zz_render','','qwest/selfplay/start'
	if horny >= 70: act func('bedrPar2_strings'+$lang, 'act12'): gt 'selfplay'
	act func('bedrPar2_strings'+$lang, 'act10'): gt $loc, $metka
end
! мать рукоблудит, Светка подглядывает
if $args[0] = 'mom_selfplay':
	*clr & cla
	gs 'zz_render','','pavlovo/family/mother/selfplay'+rand(0,4)+'.webm'
	gs 'zz_render','','',func('bedrPar2_strings'+$lang, '17')
	if voyeurism > 0:
		gs 'zz_render','','',func('bedrPar2_strings'+$lang, '18')
	else
		gs 'zz_render','','',func('bedrPar2_strings'+$lang, '19')
	end
	gs 'zz_render','','',func('bedrPar2_strings'+$lang, '20')
	! если впервой
	if mom_selfplay = 0:
		gs 'zz_render','','',func('bedrPar2_strings'+$lang, '21')
	else
		! уже видела
		gs 'zz_render','','',func('bedrPar2_strings'+$lang, '22')
	end
	mom_selfplay = 1
	parentsexday = day
	horny += rand(10,20)
	minut += rand(2,5)
	act func('bedrPar2_strings'+$lang, 'act11'): gt 'korrPar'
end