if $args[0] = '' or $args[0] = 'main':
	gs 'npc_editor','init_sex',9
	minut += 15
	gs 'stat'
	if vagina = 0 or $npc['9,sex'] = 0:
		gs 'npc_editor','get_npc_profile',9
		if KotovZverHelp = 1 and lariskaQwestDay = daystart: gs 'zz_render','','',func('kotovsex_str',0)
		gs 'zz_render','','',func('kotovsex_str',1)
		if vagina = 0:
			act 'Я еще девочка':
				*clr & cla
				gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif',func('kotovsex_str',iif(school['certificate'] = 0,2,3))
				act 'Лишиться невинности': gs $curloc,'kotov_first_sex'
				gs $curloc,'kotov_bj'
				gs $curloc,'kotov_anal'
				act 'Расстаться с парнем':
					cla
					$npc['9,qwKotovLove'] = -1
					gs 'npc_editor','change_rep','-',9,30
					gs 'zz_render','','',func('kotovsex_str',4)
					act 'Уйти': minut += rand(10,15) & gt 'gorodok'
				end
			end
		else
			act 'Раздеваться':
				*clr & cla
				$npc['9,sex'] += 1
				guy += 1
				gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif',func('kotovsex_str',5)
				gs $curloc,'kotov_bj'
				gs $curloc,'kotov_sex'
				gs $curloc,'kotov_anal'
			end
		end
	else
		i = rand(0,3)
		if i = 0:
			gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre'+rand(0,4)+'.gif',func('kotovsex_str',7)
			if KotovZverHelp = 1 and lariskaQwestDay = daystart: gs 'zz_render','','',func('kotovsex_str',0)
			if pirsA = 1 and KotovKnowPirsA = 0:
				gs 'zz_render','','',func('kotovsex_str',6)
				KotovKnowPirsA = 1
			end
			if dom > 0:
				act 'Запрыгнуть на него':
					*clr & cla
					gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre2'+rand(0,3)+'.gif',func('kotovsex_str',8)
					act 'Сесть на член': gt 'sex1x1','sex_actions','cow'
					act 'Опуститься на колени': gt 'sex1x1','bj_select'
				end
			end
			act 'Раздеваться':
				*clr & cla
				gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif',func('kotovsex_str',5)
				if dom > 10:
					if dom >= 20: act 'Запрыгнуть сверху': gt 'sex1x1','sex_actions','cow'
					act 'Раздвинуть ноги': gt 'sex1x1','sex_actions','mis'
					act 'Опуститься на колени': gt 'sex1x1','bj_select'
				else
					act 'Подчиниться парню': gt 'sex1x1','sub'
				end
			end
		elseif i = 1:
			gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre30.gif',func('kotovsex_str',9)
			act 'Раздвинуть ножки': gt 'sex1x1','sex_actions','mis'
		elseif i = 2:
			! надо инициализировать!!!
			if kotov_kuni = 1:
				gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre50.gif',func('kotovsex_str',10)
				act 'Наслаждаться': gt 'sex1x1','sex_kuni'
			else
				gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre60.gif',func('kotovsex_str',11)
				act 'Опуститься на колени': gt 'sex1x1','bj_select'
			end
		else
			gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovpre4'+rand(0,2)+'.gif',func('kotovsex_str',12)
			act 'Нагнуться': gt 'sex1x1','sex_actions','dog'
		end
	end
end
! ---
if $args[0] = 'kotov_first_sex':
	*clr & cla
	minut += rand(15,30)
	sexa += 1
	$npc['9,sex'] += 1
	guy += 1
	pose = 0
	gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovfirst.jpg',func('kotovsex_str',13)
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'stat'
	act 'Приходить в себя':
		*clr & cla
		gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovfirst1.jpg',func('kotovsex_str',14)
		act 'Идти домой':
			*clr & cla
			minut += rand(10,15)
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovfirst1.jpg',func('kotovsex_str',15)
			act 'Уйти': gt 'korrPar'
		end
	end
end
! ---
if $args[0] = 'kotov_sex':
	act 'Лечь на спину':
		*clr & cla
		minut += rand(15,30)
		sexa += 1
		pose = 0
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/sex.jpg',func('kotovsex_str',16)
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		if horny >= 80 and kotov_sexday ! day: gs $curloc,'wanna_more_sex'
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
end
! ---
if $args[0] = 'wanna_more_sex':
	act '<<$boy>>, ещё хочу':
		*clr & cla
		gs 'zz_render','','images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif',func('kotovsex_str',17)
		if kotov_sexday ! day:
			kotov_sexday = day
			gs $curloc,'kotov_sex'
			gs $curloc,'kotov_anal'
		else
			act 'Уйти': minut += rand(10,15) & gt 'gorodok'
		end
	end
end
! ---
if $args[0] = 'kotov_bj':
	act 'Взять в рот':
		*clr & cla
		minut += 5
		bj += 1
		bja += 1
		if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
		kotovBJtimes += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/ev/kotovBJ'+RAND(0,6)+'.jpg',func('kotovsex_str',18)
		if kotovBJtimes > 5:
			act 'Продолжить сосать':
				*clr & cla
				minut += 5
				gs 'zz_funcs', 'cum', 'lip'
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/ev/kotovBJcum.jpg',func('kotovsex_str',19)
				act 'Сосать глотая сперму':
					*clr & cla
					minut += 5
					swallow += 1
					gs 'stat'
					gs 'zz_render','','images/qwest/alter/ev/cocksuck2.jpg',func('kotovsex_str',20)
					act 'Уйти': minut += rand(10,15) & gt 'gorodok'
				end
				if kotovBJtimes > 10:
					act 'Сосать удерживая сперму во рту':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/qwest/alter/ev/kotovBJcum4.jpg',func('kotovsex_str',21)
						act 'Выплюнуть':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render','','images/qwest/alter/ev/gop8.jpg',func('kotovsex_str',22)
							act 'Уйти': minut += rand(10,15) & gt 'gorodok'
						end
						if kotovBJtimes > 12:
							act 'Проглотить':
								*clr & cla
								minut += 5
								swallow += 1
								vaf += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/alter/ev/kotovBJcum5.jpg',func('kotovsex_str',23)
								act 'Уйти': minut += rand(10,15) & gt 'gorodok'
							end
						end
						if kotovBJtimes > 15:
							act 'Играть со спермой':
								*clr & cla
								minut += 5
								swallow += 1
								vaf += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/alter/ev/kotovBJcum2.jpg',func('kotovsex_str',24)
								act 'Уйти': minut += rand(10,15) & gt 'gorodok'
							end
						end
					end
				end
			end
		end
		act 'Вынуть изо рта':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/ev/kotovHJ.jpg',func('kotovsex_str',25)
			if kotovBJtimes > 15:
				act 'Направить на лицо':
					*clr & cla
					minut += 5
					gs 'zz_funcs', 'cum', 'face'
					gs 'stat'
					gs 'zz_render','','images/qwest/alter/ev/kotovFacial.jpg',func('kotovsex_str',26)
					act 'Уйти': minut += rand(10,15) & gt 'gorodok'
				end
			end
			act 'Кончить в ладони':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/ev/kotovHJ2.jpg',func('kotovsex_str',27)
				act 'Уйти': minut += rand(10,15) & gt 'gorodok'
			end
		end
	end
end
! ---
if $args[0] = 'kotov_anal':
	act 'Подставить попку':
		*clr & cla
		minut += rand(15,30)
		anala += 1
		if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/anal.jpg'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		gs 'zz_dynamic_sex', 'anal_cum'
		if horny >= 80 and kotov_sexday ! day: gs $curloc,'wanna_more_sex'
		act 'Уйти': minut += rand(10,15) & gt 'gorodok'
	end
end