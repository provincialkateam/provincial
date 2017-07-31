if $args[0] = '' or $args[0] = 'main':
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Туалет','pic/PublicToilet.jpg'
	gs 'zz_toilet', 'actions', 1
	act 'Выйти из туалета': gt $loc, $metka
end
! args[1] - back to toilet-main, 0/1
if $args[0] = 'finish':
	killvar '_act_i'
	if args[1] = 0:
		gt $loc, $metka
	else
		gt 'zz_toilet', 'main'
	end
end
! args[1] - back to toilet-main, 0/1
if $args[0] = 'actions':
	_act_i = args[1]
	if tanga = 1:
		act 'Снять нижнее бельё':
			cla
			tanga = 0
			gt 'zz_toilet', 'finish', _act_i
		end
	else
		act 'Надеть нижнее бельё':
			cla
			tanga = 1
			gt 'zz_toilet', 'finish', _act_i
		end
	end
	if tampon > 0 and mesec > 0 and isprok = 0 and cheatTampon = 0:
		act 'Поменять тампон':
			*clr & cla
			tampon -= 1
			isprok = 1
			minut += 5
			manna -= 5
			gs 'zz_render','','picb/tampon.jpg','Вы поменяли тампон'
			gt 'zz_toilet', 'finish', _act_i
		end
	end
	if cumpussy > 0 or cumbelly > 0 or cumass > 0 or cumanus > 0:
		act 'Подмыться 5 мин':
			*clr & cla
			cumpussy = 0
			cumbelly = 0
			cumass = 0
			cumanus = 0
			sweat -= 1
			minut += 5
			if clrbelo > 0:
				clrbelo -= 1
				dirtbelo += 1
			end
			gs 'zz_render','','pics/wash5.jpg','Вы тщательно смыли сперму с себя.'
			act 'Закончить': gt 'zz_toilet', 'finish', _act_i
		end
	end
	act 'Умыться 5 мин':
		*clr & cla
		mop = 1
		cumlip = 0
		cumface = 0
		sweat -= 1
		minut += 5
		gs 'zz_render','','pic/facesp.jpg','Вы тщательно умыли лицо.'
		act 'Закончить': gt 'zz_toilet', 'finish', _act_i
	end
	if cumfrot > 0:
		act 'Оттирать сперму с одежды':
			*clr & cla
			cumfrot = 0
			minut += 15
			gs 'zz_render','','pic/frotsp.jpg','Вы замыли пятна спермы на своей одежде.'
			act 'Закончить': gt 'zz_toilet', 'finish',_act_i
		end
	end
	if body_write > 0 or face_write > 0:
		act 'Стереть надписи на теле':
			*clr & cla
			body_write = 0
			face_write = 0
			minut += 5
			!'тут нужна картинка'
			gs 'zz_render','','','Вы стёрли непристойные надписи.'
			act 'Закончить': gt 'zz_toilet', 'finish', _act_i
		end
	end
	if pregtest > 0:
		act 'Сделать тест на беременность':
			cla
			pregtest -= 1
			if preg = 1:
				gs 'zz_render','','','Тест показал две полоски. Вы беременны. Вы думаете, что отец <<$father>>.'
			else
				gs 'zz_render','','','Тест показал одну полоску.'
			end
			act 'Закончить': gt 'zz_toilet', 'finish', _act_i
		end
	end
	if vibrator = 1 and vibratorIN = 0:
		act 'Вставить вибратор 5 мин':
			*clr & cla
			minut += 5
			vibratorIN = 1
			if vagina < 6: vagina += 1
			gs 'zz_render','','pic/vibrator.jpg','Разведя ноги, вы вставляете вибратор в киску.'
			act 'Закончить': gt 'zz_toilet', 'finish', _act_i
		end
	elseif vibrator = 1 and vibratorIN = 1:
		act 'Вынуть вибратор 2 мин':
			*clr & cla
			minut += 2
			vibratorIN = 0
			gs 'zz_render','','pic/vibrator.jpg','Наклонились, вы вынимаете вибратор из влагалища.'
			act 'Закончить': gt 'zz_toilet', 'finish', _act_i
		end
	end
	if mop = 1 and kosmetica > 0:
		act 'Нанести макияж':
			cla
			act 'Лёгкий макияж':
				*clr & cla
				minut += 3
				kosmetica -= 1
				mop = 2
				gs 'zz_render','','images/common/furniture/mirror/mop_2.jpg','Вы легонечко подвели глаза и немного подкрасили губы.'
				act 'Посмотреть результат': gt 'zz_toilet', 'finish', _act_i
			end
			if kosmetica >= 2:
				act 'Нормальный макияж':
					*clr & cla
					minut += 5
					kosmetica -= 2
					mop = 3
					gs 'zz_render','','images/common/furniture/mirror/mop_3.jpg','Вы накрасили губы, подвели глаза и наложили тени.'
					act 'Посмотреть результат': gt 'zz_toilet', 'finish', _act_i
				end
			end
			if kosmetica >= 3:
				act 'Вызывающий макияж':
					*clr & cla
					minut += 10
					kosmetica -= 3
					vidageday -= 1
					mop = 4
					gs 'zz_render','','images/common/furniture/mirror/mop_4.jpg','Вы наложили густые тени на веки и тушь для ресниц, подвели контур губ карандашом и накрасили губы помадой.'
					act 'Посмотреть результат': gt 'zz_toilet', 'finish', _act_i
				end
			end
		end
	end
end