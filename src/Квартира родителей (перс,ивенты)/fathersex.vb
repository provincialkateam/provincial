!_____________________КОНЧАЕТ_____________________________
if $args[0] = 'father_cum':
	horny = 0
	if args[1] = 0:
		act 'Кончай в попку':
			*clr & cla
			cumanus = 1
			father['horny'] = 0
			gs 'zz_render','','images/qwest/alter/father/fatherim11.jpg', func('fathersex_strings','1')
			act '<B>Отойти</B>': gt $loc, $metka
		end
	end
	if args[1] = 1:
		act 'Кончи мне на попку':
			*clr & cla
			cumass = 1
			father['horny'] = 0
			gs 'zz_render','','images/qwest/alter/father/fatherim5.jpg', func('fathersex_strings','2')
			act '<B>Отойти</B>': gt $loc, $metka
		end
	end
	if args[1] = 2:
		act 'Обкончай мне лицо':
			*clr & cla
			father['horny'] = 0
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_render','','images/qwest/alter/father/fatherim12.jpg', func('fathersex_strings','3')
			act '<B>Отойти</B>': gt $loc, $metka
		end
	end
	if args[1] = 3:
		act 'Кончить вместе':
			*clr & cla
			father['horny'] = 0
			gs 'zz_funcs', 'cum', 'face'
			if horny >= 100:
				gs 'zz_render','','', func('fathersex_strings', 4)
				act 'Провести по губам':
					*clr & cla
					gs 'zz_render','','images/qwest/alter/father/fatherim4_2.gif', func('fathersex_strings','5')
					act 'Обсосать член':
						*clr & cla
						gs 'zz_render','','images/qwest/alter/father/fatherim4_3.gif', func('fathersex_strings','6')
						act '<B>Отойти</B>': gt $loc, $metka
					end
				end
			else
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/father/fatherim6.gif', func('fathersex_strings','7')
				act '<B>Отойти</B>': gt $loc, $metka
			end
		end
	end
	if args[1] = 4:
		act 'Упасть на диван':
			*clr & cla
			father['horny'] = 0
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_render','','images/qwest/alter/father/fatherim7.jpg', func('fathersex_strings','8')
			act '<B>Отойти</B>': gt $loc, $metka
		end
	end
	if args[1] = 5:
		act 'Дать ему кончить в рот':
			*clr & cla
			cumlip = 1
			father['horny'] = 0
			gs 'zz_render','','images/qwest/alter/father/fatherim15.jpg', func('fathersex_strings','9')
			act '<B>Отойти</B>': gt $loc, $metka
		end
	end
end
!_____________________МИНЕТЫ_____________________________
if $args[0] = 'father_blow':
	bj += 1
	if args[1] = 0:
		act 'Сосать':
			*clr & cla
			gs 'zz_render','','images/qwest/alter/father/fatherim3.jpg', func('fathersex_strings','10')
			gs 'fathersex','father_sex',0
			gs 'fathersex','father_sex',1
		end
	end
	if args[1] = 1:
		act 'Продолжить сосать':
			*clr & cla
			gs 'zz_render','','images/qwest/alter/father/fatherim14.jpg', func('fathersex_strings','11')
			gs 'fathersex','father_cum',5
		end
	end
	if args[1] = 2:
		*clr & cla
		gs 'zz_render','','images/qwest/alter/father/fatherim3.jpg', func('fathersex_strings','12')
		gs 'fathersex','father_sex',0
		gs 'fathersex','father_sex',1
		gs 'fathersex','father_blow',1
	end
end
!_____________________НАГНУТЬСЯ___________________________
if $args[0] = 'father_bend':
	!Есть пробка
	if $npc['35,sex'] = 0: $npc['35,sex'] = 1 & guy += 1
	if args[1] = 0:
		*clr & cla
		gs 'zz_render','','images/qwest/alter/father/fatherim1.jpg', func('fathersex_strings','13')
		gs 'fathersex','father_other',0
		exit
	end
	!Нет пробки
	if args[1] = 1:
		*clr & cla
		gs 'zz_render','','images/qwest/alter/father/fatherim2.jpg', func('fathersex_strings','14')
		gs 'fathersex','father_blow',0
		exit
	end
	!Нет пробки и нижнего белья
	if args[1] = 2:
		*clr & cla
		gs 'zz_render','','', func('fathersex_strings','15')
		gs 'fathersex','father_blow',0
		exit
	end
end
!_____________________ДРУГОЕ___________________________
if $args[0] = 'father_other':
	if args[1] = 0:
		act 'Идти в спальню':
			*clr & cla
			gs 'zz_render','','images/qwest/alter/father/fahterim3.gif', func('fathersex_strings','16')
			gs 'fathersex','father_other',1
		end
	end
	if args[1] = 1:
		act 'Тужиться':
			*clr & cla
			gs 'zz_render','','images/qwest/alter/father/fatherim9.jpg', func('fathersex_strings','17')
			gs 'fathersex','father_other',2
		end
	end
	if args[1] = 2:
		act 'Помочь':
			*clr & cla
			if anus < 10: anus += 1
			gs 'zz_render','','', func('fathersex_strings','18')
			gs 'fathersex','father_cum',0
			gs 'fathersex','father_cum',1
			gs 'fathersex','father_cum',2
		end
	end
end
!_____________________SEX___________________________
if $args[0] = 'father_sex':
	if args[1] = 0:
		act 'На кровать':
			*clr & cla
			if anus < 10: anus += 1
			gs 'zz_render','','', func('fathersex_strings','19')
			if rand(1,2) = 1:
				cumanus = 1
				gs 'zz_render','','', func('fathersex_strings','20')
				act '<B>Отойти</B>': gt $loc, $metka
			else
				gs 'zz_render','','', func('fathersex_strings','21')
				gs 'fathersex','father_cum',3
			end
		end
	end
	if args[1] = 1:
		act 'Остаться':
			*clr & cla
			minut += 10
			if anus < 10: anus += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/alter/father/fatherim5.jpg', func('fathersex_strings','22')
			act 'Стонать':
				*clr & cla
				gs 'zz_render','','', func('fathersex_strings','23')
				if rand(1,2) = 1:
					cumanus = 1
					gs 'zz_render','','', func('fathersex_strings','24')
					act 'Показать попу':
						*clr & cla
						gs 'zz_render','','', func('fathersex_strings','25')
						act '<B>Отойти</B>': gt $loc, $metka
					end
				else
					gs 'zz_render','','', func('fathersex_strings','26')
					gs 'fathersex','father_cum',4
				end
			end
		end
	end
end