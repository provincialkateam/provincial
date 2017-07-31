gs'stat'
if BistroBoss = 10:
	if week < 6 and hour >= 9 and hour < 17:'Анатолий Борисович сидит за столом и говорит с кем то по телефону.'
	if week < 6 and hour < 9 or week < 6 and hour >= 17:'Анатолия Борисовича нет на месте.'
	if week >= 6:'Сейчас выходные и Анатолия Борисовича нет на месте.'
	act 'Уйти':gt'burger','start'
	if PersSecWork = 2:
		if week < 6 and hour < 10:
			gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str1')
		end
	elseif PersSecWork = 1:
		if week < 6 and hour < 10 and func('zz_clothing','get_group') = 10:
			act 'Работать':gt'burgerWork'
			act 'Уволиться':
				PersSecWork = 0
				work = 0
				minut += 20
				gt'burger','start'
			end
		elseif week < 6 and hour < 10 and func('zz_clothing','get_group') ! 10:
			gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str2')
		end
	elseif PersSecWork = 0 and week < 6:
		if secrDiplom = 1:
			act 'Показать диплом':
				*clr & cla
				minut += 1
				gs'stat'
				gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str3')
				act 'Нет':
					*clr & cla
					minut += 1
					gs'stat'
					gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str4')
					act 'Уйти':gt'burger','start'
				end
				if work = 0 and PersSecWork = 0:
					act 'Вот трудовая':
						*clr & cla
						minut += 1
						gs'stat'
						gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str5')
						act 'Уйти':gt'burger','start'
						act 'Устроиться на работу':
							*clr & cla
							minut += 1
							work = 1
							PersSecWork = 1
							gs'stat'
							gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str6')
							act 'Уйти':gt'burger','start'
						end
					end
				end
			end
		end
	end
elseif BistroBoss = 1:
	gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str7')
	act 'Сесть на стул':
		*clr & cla
		minut += 1
		BistroBoss = 10
		gs'stat'
		if $npc['0,qwBistro'] = 57:
			kosmetica += 200
			gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str8')
			if secrDiplom = 1:
				act 'Да, у меня есть диплом':
					*clr & cla
					minut += 1
					gs'stat'
					gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str9')
					act 'Уйти':gt'burger','start'
				end
			elseif secrDiplom = 0 and sekrObu > 0:
				act 'У меня нет диплома, но я уже учусь на секретаря':
					*clr & cla
					minut += 1
					gs'stat'
					gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str10')
					act 'Уйти':gt'burger','start'
				end
			elseif secrDiplom = 0 and sekrObu = 0:
				act 'Нет':
					*clr & cla
					sekrObu = 1
					minut += 1
					gs'stat'
					gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str11')
					act 'Уйти':gt'burger','start'
				end
			end
		elseif $npc['0,qwBistro'] >= 65:
			gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str12')
			act 'Уйти':gt'burger','start'
			act 'Встать на колени':
				*clr & cla
				minut += 5
				money += 300
				bj += 1
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				BistroBoss = 2
				BistroBossDay = day
				gs'stat'
				gs 'zz_render', '', 'images/qwest/sosed/bj2.jpg', func('burgerBoss_strings', 'local_str13')
				act 'Уйти':gt'burger','start'
			end
		end
	end
elseif BistroBoss = 2 and BistroBossDay = day:
	gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str14')
	act 'Уйти':gt'burger','start'
elseif BistroBoss = 2 and BistroBossDay ! day:
	BistroBossDay = day
	gs 'zz_render', '', '', func('burgerBoss_strings', 'local_str15')
	act 'Уйти':gt'burger','start'
	act 'Встать на колени':
		*clr & cla
		minut += 5
		money += 300
		bj += 1
		swallow += 1
		gs 'zz_funcs', 'cum', 'lip'
		BistroBossDay = day
		gs'stat'
		gs 'zz_render', '', 'images/qwest/sosed/bj2.jpg', func('burgerBoss_strings', 'local_str16')
		act 'Уйти':gt'burger','start'
	end
end