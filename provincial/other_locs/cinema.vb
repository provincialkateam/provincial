if $args[0] = '' or $args[0] = 'main':
	$_str[0] = 'Небольшой кинотеатр, в котором есть всего один небольшой зал.'
	$_str[1] = 'Лестница упирается в аккурат в двери кинотеатра "ГЭС". Кинотеатр навороченный, дорогой. Крутят в основном модные блокбастеры в 3D.'
	$_str[2] = 'Вы спокойно посмотрели фильм, после чего вышли из кинозала.'
	$_str[3] = 'Вы спокойно смотрите фильм, но вдруг сзади слышите какие-то странные звуки.'
	$_str[4] = '<red>У вас недостаточно денег на билет!</red>'
	! mini
	$_str[5] = 'Вы видите как на задних рядах девушка сосёт парню, никого не стесняясь, с громкими причмокиваниями на весь кинотеатр. Благо темно и народу в зале немного и почти все сидят на первых рядах, а парочка - сзади, почти у стены.'
	!$_str[6] = ''
	!$_str[7] = ''
	!$_str[8] = ''
	! ---
	! 1 - для городского дорогого кинотеатра
	! 0 - обычный небольшой кинотеатр
	_cinema = args[1]
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render','','common/cinema/cinema.jpg',$_str[_cinema]
	act 'Сходить в кино ('+iif(_cinema=1,200,100)+'р.)':
		if money < iif(_cinema=1,200,100):
			gs 'zz_render','','',$_str[4]
			gs $curloc,'finish'
			exit
		end
		*clr & cla
		money -= iif(_cinema=1,200,100)
		minut += 120
		manna += RAND(20,30)
		i = rand(1,100)
		gs 'zz_render','','common/cinema/film.jpg',$_str[iif(i>10,3,2)]
		if i > 10:
			act 'Повернуть голову и посмотреть':
				*clr & cla
				horny += rand(5,10)
				gs 'stat'
				i = rand(0,arrsize('$_str')-6)
				gs 'zz_render','','common/cinema/<<i>>.gif',$_str[i+5]
				gs $curloc,'finish'
			end
		end
		gs $curloc,'finish'
	end
	gs $curloc,'finish'
end
if $args[0] = 'finish':
	act 'Уйти':
		minut += 5
		killvar '$_str'
		killvar '_cinema'
		if $control_point = 'gorodok':
			gt 'zz_park'
		else
			gt $loc,$metka
		end
	end
end