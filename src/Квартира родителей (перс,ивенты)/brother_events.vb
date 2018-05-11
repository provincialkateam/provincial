if $args[0] = 'watch_tv':
	if hour = 23 and brother_tv_enable = 0 and family_trip = 0: gt 'brother_events','go_away'
	gs 'zz_common','watch_tv_on_sofa'
end
if $args[0] = 'go_away':
	gs 'npc_editor','get_npc_profile',39
	gs 'zz_render','','', func('brother_events_strings', 1)
	act '<b>Уйти</b>': gt 'korrPar'
	act 'Послать':
		*clr & cla
		gs 'zz_render','','common/tv/fuck_of_brother.jpg', func('brother_events_strings', 2)
		if $npc['39,relation'] < 40:
			!не согласился пускать к телеку
			gs 'zz_render','','', func('brother_events_strings', 3)
			act 'Уйти': gt 'korrPar'
		else
			if $npc['39,sex'] = 1 or $npc['39,qwPornoFootball'] > 10:
				if $npc['39,sex'] > 4 or $npc['39,qwPornoFootball'] >= 16:
					gs 'zz_render','','', func('brother_events_strings', 4)
					gs 'zz_brother','brotherSexStart'
					act 'Уйти': gt 'korrPar'
				else
					!согласился и пошел на попятную
					brother_tv_enable = 1
					gs 'zz_render','','', func('brother_events_strings', 5)
					act 'Смотреть телевизор': gs 'zz_common', 'watch_tv_on_sofa'
				end
			else
				! часть из бывшего ивента с порножурналом
				if $npc['39,qwPornoFootball'] > 3 or $npc['39,qwBrotherNude'] >= 1:
					cla
					brother_tv_enable = 1
					gs 'zz_render','','','\\\- Ну... Даже не знаю... Тесно как-то вдвоём на диване... Но так и быть, подвинусь, если покажешь... сиськи!/// - улыбнулся брат. От такого предложения братца вы офигели, но с другой стороны - ' +iif($npc['39,qwBrotherNude'] >= 1,'он вас голой уже видел.','"Это же всего лишь показать сиськи мельком! Так что он толком ничего и не рассмотрит!" - подумалось вам.')
					act 'Ну ладно... - согласились вы.':
						*clr & cla
						gs 'zz_render','','pavlovo/family/brother/tits_show_'+rand(1,3), func('brother_events_strings', 6)
						act 'Смотреть телик': gs 'zz_common', 'watch_tv_on_sofa'
					end
					act 'Влепить пощечину':
						cla
						dom += 1
						gs 'zz_render','','', func('brother_events_strings', 7)
						act 'Уйти':
							cla
							gs 'zz_render','','', func('brother_events_strings', 8)
							act '...': gt 'korrPar'
						end
						act 'Смотреть телик': gs 'zz_common', 'watch_tv_on_sofa'
					end
				else
					cla
					gs 'zz_render','','', func('brother_events_strings', 9)
					act 'Уйти': gt 'korrPar'
				end
			end
		end
	end
end
! ---
! brother_help_qw
! 1 - возможен повтор на следующий день
! 2 - продолжение ивента, минет
! 4 - концовка обычная
! 5 - плохая концовка
if $args[0] = 'brother_help_qw':
	! переброс на вторую часть
	if brother_help_qw = 2: gt 'brother_events','brother_help_qw2'
	! ---
	*clr & cla
	brother_help_qw_day = day
	gs 'zz_render','','pavlovo/family/brother/help_qw/0.webm',func('brother_events_strings', 10)
	act 'Пускай уходит':
		gs 'npc_editor','change_rep','-', 39
		brother_help_qw = 4
		gt 'zz_school','homework'
	end
	act 'Остановить':
		*clr & cla
		horny += rand(10,20)
		minut += rand(2,5)
		gs 'stat'
		gs 'zz_render','','pavlovo/family/brother/help_qw/1.webm',func('brother_events_strings', 11)
		act 'Остановить':
			*clr & cla
			gs 'zz_render','','pavlovo/family/brother/help_qw/2.webm',func('brother_events_strings', 12)
			act '...':
				manna += rand(1,5)
				brother_help_qw = 1
				killvar '$_str'
				gt 'bedrPar'
			end
		end
		act 'Позволить':
			*clr & cla
			gs 'zz_render','','pavlovo/family/brother/help_qw/3.webm',func('brother_events_strings', 13)
			act '...':
				*clr & cla
				gs 'zz_render','','pavlovo/family/mother/prost10.jpg',func('brother_events_strings', 14)
				act '...':
					horny = 0
					manna += rand(10,20)
					minut += rand(2,5)
					brother_help_qw = 2
					killvar '$_str'
					gt 'bedrPar'
				end
			end
		end
	end
end
! продолжение
if $args[0] = 'brother_help_qw2':
	*clr & cla
	brother_help_qw_day = day
	gs 'zz_render','','pavlovo/family/brother/help_qw/0.webm', func('brother_events_strings', 15) + iif(dom<-10,func('brother_events_strings', 16),func('brother_events_strings', 15))
	act '...':
		*clr & cla
		gs 'npc_editor','change_rep','+', 39
		minut += rand(2,5)
		gs 'stat'
		if dom < -10:
			bj += 1
			gs 'zz_render','','pavlovo/family/brother/help_qw/7.webm',func('brother_events_strings', 23)
			brother_help_qw = 4
			gs 'zz_funcs', 'cum', 'lip'
			act '...': gt 'bedrPar'
		else
			horny = 0
			manna += rand(10,20)
			gs 'stat'
			gs 'zz_render','','pavlovo/family/brother/help_qw/4.webm',func('brother_events_strings', 17)
			act 'Ублажить':
				*clr & cla
				bj += 1
				gs 'zz_funcs', 'cum', 'lip'
				minut += rand(2,5)
				brother_help_qw = 4
				gs 'stat'
				gs 'zz_render','','pavlovo/family/brother/help_qw/6.webm',func('brother_events_strings', 20)
				act 'Отстраниться':
					*clr & cla
					gs 'zz_render','','pavlovo/family/brother/help_qw/8.webm',func('brother_events_strings', 21)
					act '...': gt 'bedrPar'
				end
				act 'Принять в рот':
					*clr & cla
					gs 'zz_render','','pavlovo/family/brother/help_qw/7.webm',func('brother_events_strings', 22)
					act '...': gt 'bedrPar'
				end
			end
			if dom >= 20:
				act 'Вырваться':
					*clr & cla
					gs 'zz_render','','pavlovo/family/brother/help_qw/5.webm',func('brother_events_strings', 19)
					minut += rand(2,5)
					$npc['39,relation'] = 20
					gs 'stat'
					brother_help_qw = 5
					act '...': gt 'bedrPar'
				end
			end
		end
	end
end
! новогодний ивент
if $args[0] = 'happy_ny':
	*clr & cla
	gs 'npc_editor','change_rep','+', 39
	brother_newyear_qw = 1
	i = args[1]
	gs 'zz_render','','pavlovo/family/brother/newyear/0'+iif(i=1,7,1)+'.jpg',func('brother_events_strings', iif(i=1,31,24))
	act 'Дальше':
		*clr & cla
		horny += 20
		minut += 5
		gs 'stat'
		gs 'zz_render','','pavlovo/family/brother/newyear/02.jpg',func('brother_events_strings', 25)
		act 'Дальше':
			*clr & cla
			! ничего не было
			if $npc['39,sex'] = 0:
				horny = 100
				minut += 5
				gs 'stat'
				gs 'zz_render','','pavlovo/family/brother/newyear/02.jpg',$func('brother_events_strings', 26)
				act 'Уйти': gt 'korrPar'
			elseif $npc['39,sex'] > 0 and $npc['39,sex'] <= 6:
				! был только орал
				horny = 0
				minut += 5
				$npc['39,sex'] += 1
				kuni += 1
				gs 'stat'
				gs 'zz_render','','pavlovo/family/brother/newyear/03.jpg',func('brother_events_strings', 27)
				act 'Уйти': gt 'korrPar'
			else
				! был секс
				gs 'zz_render','','pavlovo/family/brother/newyear/04.jpg',func('brother_events_strings', 28)
				act '...':
					*clr & cla
					minut += 5
					$npc['39,sex'] += 1
					gs 'stat'
					gs 'zz_render','','pavlovo/family/brother/newyear/05.jpg',func('brother_events_strings', 29)
					act '...':
						*clr & cla
						horny = 0
						minut += 5
						$npc['39,sex'] += 1
						manna += 20
						orgasm += 1
						gs 'stat'
						gs 'zz_render','','pavlovo/family/brother/newyear/06.jpg',func('brother_events_strings', 30)
						act 'Уйти': gt 'korrPar'
					end
				end
			end
		end
	end
end