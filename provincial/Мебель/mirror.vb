if $ARGS[0] = 'start':
	*clr & cla
	$zz_goback = $args[1]
	gs 'zz_render','',func('zz_common','get_hero_face'),'<<$hair>> <<$mop>> <<$skin>> <<$vnesh>> <<$lip>> <<$glaza>>' + iif(kosmetica > 0,'**Косметика <<kosmetica>>','**У вас нет косметики.')
	if hapri = 0 and cheatHapri_mod = 1:
		act 'Причесаться':
			cla
			minut += 3
			hapri = 1
			gs'stat'
			gs 'zz_render','','','Вы расчесали волосы у зеркала'
			act 'Посмотреть результат':gt 'mirror', 'start', $zz_goback
		end
	end
	if mop = 1 and kosmetica > 0 and (cheatHapri_mod = 0 or hapri = 1 and cheatHapri_mod = 1):
		act 'Нанести макияж':
			cla
			act 'Легкий макияж':
				*clr & cla
				minut += 3
				kosmetica -= 1
				mop = 2
				gs 'stat'
				gs 'zz_render','','images/common/furniture/mirror/mop_2.jpg','Вы легонечко подвели глаза и немного подкрасили губы.'
				act 'Посмотреть результат': gt 'mirror', 'start', $zz_goback
			end
			if kosmetica >= 2:
				act 'Нормальный макияж':
					*clr & cla
					minut += 5
					kosmetica -= 2
					mop = 3
					gs 'stat'
					gs 'zz_render','','images/common/furniture/mirror/mop_3.jpg','Вы накрасили губы, подвели глаза и наложили тени.'
					act 'Посмотреть результат': gt 'mirror', 'start', $zz_goback
				end
			end
			if kosmetica >= 3:
				act 'Вызывающий макияж':
					*clr & cla
					minut += 10
					kosmetica -= 3
					vidageday -= 1
					mop = 4
					gs 'stat'
					gs 'zz_render','','images/common/furniture/mirror/mop_4.jpg','Вы густо накрасили глаза, наложили тени и тушь для ресниц, накрасили контур губ карандашом и губы помадой.'
					act 'Посмотреть результат': gt 'mirror', 'start', $zz_goback
				end
			end
		end
	end
	if brow <= 1 and browper = 0:
		act 'Выщипывать брови':
			*clr & cla
			minut += 10
			brow = 21
			manna -= 5
			gs 'stat'
			gs 'zz_render','','images/common/furniture/mirror/eyebrows.jpg','Вы выщипали ненужные волоски на бровях придав им красивый контур. Правда это довольно больно.'
			act 'Посмотреть результат': gt 'mirror', 'start', $zz_goback
		end
	end
	if lipbalm > 0 and lipbalmstat <= 0:
		act 'Намазать губы увлажняющим бальзамом':
			*clr & cla
			minut += 10
			lipbalm -= 1
			lipbalmstat += 8
			lipkoef += 5
			if lipkoef >= 50:
				lipkoef = 0
				lip += 1
			end
			gs 'stat'
			gs 'zz_render','','images/common/furniture/mirror/wet_lips.jpg','Вы намазали губы увлажняющим бальзамом.'
			act 'Посмотреть результат': gt 'mirror', 'start', $zz_goback
		end
	end
	act 'Отойти от зеркала':
		if $zz_goback = 'bath':
			killvar '$zz_goback'
			gt 'zz_bathroom', 'start'
		else
			killvar '$zz_goback'
			gt $loc, $metka
		end
	end
end