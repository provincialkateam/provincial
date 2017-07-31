if $ARGS[0] = 'start':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','Квартира бизнесмена Ярослава','images/yaroslav/podezd.jpg'
	act 'Позвонить в дверь':
		cla
		if (hour = 16 or hour = 17) and yaq = 1:
			gs 'zz_render','','',func('yarik_strings','local_str1')
			act 'Пройти в квартиру': gt 'yarik','yaqw'
		else
			gs 'zz_render','','',func('yarik_strings','local_str2')
			act 'Уйти':
				cla
				minut += 5
				gt 'down'
			end
		end
	end
end
if $args[0] = 'cleaning':
	_stage = args[1]
	minut += 3
	gs 'stat'
	gs 'zz_render','','city/center/yaroslav/<<_stage>>',func('yarik_strings',7+_stage)
	act func('zz_funcs','get_item_string','Хорошо,Драить пол,Возмутиться,Встать,Испачкаться,Снять футболку,Слушать Ярослава,Смотреть,Взять член,Опуститься вниз,Сосать член,Встать,Раздвинуть ножки,Наслаждаться,Спросить,Развернуться,Вздохнуть,Слезть,Подставить лицо,В ванную,Одеться и уйти',_stage):
		if _stage < 21:
			if _stage = 18:
				horny = 0
				orgasm += 1
			end
			if _stage = 19: gs 'zz_bathroom','clean_me'
			gt 'yarik','cleaning',_stage+1
		else
			money += 3000
			minut += rand(5,10)
			gt 'down'
		end
	end
end