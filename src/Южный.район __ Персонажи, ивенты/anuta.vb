$boy = 'Анюта'
dick = 10
anutaday = day
if anuta['horny'] < 70:
	gs 'zz_render', 'Анюта','images/city/south/lake/anuta/anuta'+rand(1,3)+'.jpg', func('anuta_strings', 1)
else
	gs 'zz_render', 'Анюта','images/city/south/lake/anuta/anuta'+rand(4,6)+'.jpg', func('anuta_strings', 2)
end
!Условия старта ивента с Аней в ветке мадам (надо добавить условие знакомства что Света знакома с Аней я не нашел)
if banda['madam'] = 1 : act'Предложить потрахаться с компанией настоящих брутальных мужиков': gt 'rb_madam','eventmadam2'
if cumface > 0:
	if shameless['flag'] < 2:
		gs 'zz_render','','', func('anuta_strings', 3)
	elseif shameless['flag'] < 1:
		gs 'zz_render','','', func('anuta_strings', 4)
	else
		gs 'zz_render','','', func('anuta_strings', 5)
	end
	if shameless['flag'] < 1: act 'Убежать': gt'nudelake'
end
act 'Далее':
	*clr & cla
	if anuta['horny'] < 70:
		gs 'zz_render','','images/city/south/lake/anuta/talk7.jpg', func('anuta_strings', 6)
		if horny >= 50 and (anuta['sex'] > 0 or shameless['flag'] > 2):
			act 'Приставать':
				*clr & cla
				minut += 10
				gs 'stat'
				gs 'zz_render','','images/city/south/lake/anuta/kiss'+rand(4,5)+'.jpg', func('anuta_strings', 7)
				act 'Далее': gt 'anuta_events','kiss2'
			end
		end
		act 'Поболтать': gt 'anuta_events','talk'
	else
		if horny < 50:
			gs 'zz_render','','images/city/south/lake/anuta/talk7.jpg', func('anuta_strings', 8)
		elseif horny < 70:
			gs 'zz_render','','images/city/south/lake/anuta/talk7.jpg', func('anuta_strings', 9)
		elseif horny < 90:
			gs 'zz_render','','images/city/south/lake/anuta/talk7.jpg', func('anuta_strings', 10)
		end
		if horny < 90:
			act 'Пить вино':
				*clr & cla
				minut += 30
				gs 'zz_funcs', 'alko', 3
				gs 'stat'
				gs 'time'
				gs 'zz_render', '','images/city/south/lake/anuta/talk'+rand(10,12)+'.jpg', func('anuta_strings', 11)
				if horny < 70 or shameless['flag'] < 1:
					act 'Убрать руку':
						*clr & cla
						if lesbian = 0:
							If horny < 70:
								gs 'zz_render', '','images/city/south/lake/anuta/talk2.jpg', func('anuta_strings', 12)
							else
								gs 'zz_render', '','images/city/south/lake/anuta/talk2.jpg', func('anuta_strings', 13)
							end
						else
							gs 'zz_render', '','images/city/south/lake/anuta/talk2.jpg', func('anuta_strings', 14)
						end
					end
				end
				act 'Целоваться':
					*clr & cla
					gs 'stat'
					gs 'zz_render','','images/city/south/lake/anuta/kiss'+rand(1,3)+'.jpg', func('anuta_strings', 15)
					act 'Далее': gt 'anuta_events','kiss'
				end
			end
		else
			act 'Обниматься':
				*clr & cla
				gs 'stat'
				gs 'zz_render','','images/city/south/lake/anuta/tits5.jpg', func('anuta_strings', 16)
				act 'Далее':gt 'anuta_events','kiss'+iif(horny < anuta['horny'],'',2)
			end
		end
	end
end