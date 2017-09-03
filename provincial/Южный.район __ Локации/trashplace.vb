$bomzstartqwestdi = {
	gs 'zz_render', '', '', func('trashplace_strings', 'local_str1')
	act 'Да, есть':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'time'
		gs 'zz_render', '', '', func('trashplace_strings', 'local_str2')
		act 'В метро':
			*clr & cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', '', func('trashplace_strings', 'local_str3')
			$zz_str = '-Думаешь, на порно студии только пиздой торговать можно? - с ухмылкой сказал дядя Коля - тут и другие пути заработка есть.'
			if film > 0 and pfilmNO = 0:
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str4')
				gs 'zz_render', '', '', $zz_str
			elseif pfilmNO = 1:
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str5')
				gs 'zz_render', '', '', $zz_str + ' Ты ведь только на роль актрисы просилась?'
			else
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str6')
				gs 'zz_render', '', '', $zz_str
			end
			killvar '$zz_str'
			act 'Войти к менеджеру':
				*clr & cla
				minut += 15
				if pornstudio = 0: pornstudio = 1
				gs 'stat'
				gs 'zz_render', '', '', iif(film > 0,'Привет <<$pfname>>.','Вы по какому вопросу?')
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str7')
				act 'Так что за работа?':
					*clr & cla
					minut += 15
					gs'stat'
					gs 'zz_render', '', '', func('trashplace_strings', 'local_str8')
					act 'Показать паспорт':
						*clr & cla
						minut += 15
						gs 'stat'
						gs 'zz_render', '', '', func('trashplace_strings', 'local_str17')
						act 'Уйти': bomzQW = 1 & gt'down'
					end
					act 'Спасибо, но я откажусь (Уйти)':bomzQW = -1 & gt'down'
				end
			end
		end
	end
	act 'Ээ, лучше не надо, сама справлюсь': bomzQW = -1 & gt'street'
}
$workbomzdi = {
	*clr & cla
	minut += 15
	gs'stat'
	gs 'zz_render', '', '', func('trashplace_strings', 'local_str18')
	act 'Нет, мне это не подходит (Уйти)':bomzQW = -1 & gt'down'
	act 'Согласиться на работу':
		*clr & cla
		minut += 15
		gs'stat'
		gs 'zz_render', '', '', func('trashplace_strings', 'local_str19')
		act 'Хорошо, показывайте':
			*clr & cla
			workDisk = 1
			minut += 15
			gs 'stat'
			gs 'zz_render', '', '', func('trashplace_strings', 'local_str20')
			if saunasex = 1:
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str21')
			elseif sauna > 0:
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str22')
			else
				gs 'zz_render', '', '', func('trashplace_strings', 'local_str23')
			end
			gs 'zz_render', '', '', func('trashplace_strings', 'local_str24')
			act 'Уйти':bomzQW = 2 & gt'street'
		end
	end
}
*clr & cla
gs 'stat'
gs 'time'
if anus > 10 and vagina > 10 and mesec = 0 and func('zz_weather','is_day') = 1 and city['cherdak'] = 3 and city['cherdak_day'] ! day and rand(0,10) > 8:
	gt 'front_door_event','front_ev1_init'
end
gs 'zz_render', 'Мусорка', 'images/pic/musorka.jpg', func('trashplace_strings', 'local_str25')
if bumtolik = 2 and RAND(0,100) >= 50:
	*clr & cla
	gs 'stat'
	gs 'time'
	gs 'zz_render', '', 'images/pic/musorka.jpg', func('trashplace_strings', 'local_str26')
	act 'Выслушать': gt'musorkaexh','pos8'
end
if bumtolik = 3 and hour >= 6 and hour <= 20 and RAND(0,100) >= 50:
	*clr & cla
	gs 'stat'
	gs 'time'
	gs 'zz_render', '', 'images/etogame/bumt2.jpg', func('trashplace_strings', 'local_str27')
	gs 'zz_render', '', '', func('trashplace_strings', 'local_str28')
	act 'Поинтересоваться для чего ей это нужно': gt 'musorkaexh','pos9'
end
if take_out_trash > 0:
	act 'Выбросить мусор':
		*clr & cla
		minut += 5
		take_out_trash = 0
		garbage = 0
		gs 'stat'
		gs 'zz_render', '', 'images/pic/musorka.jpg', func('trashplace_strings', 'local_str29')
		if bumtolik = 0:
			gs 'zz_render', '', '', func('trashplace_strings', 'local_str31')
			act 'Посмотреть кто это сказал':gt'musorkaexh','pos2'
		elseif bumtolik = 1:
			gs 'zz_render', '', '', func('trashplace_strings', 'local_str32')
			act 'Взглянуть на бомжа':gt'musorkaexh','pos3'
		end
		act 'Отойти от бака':gt $CURLOC
	end
end
if RAND(0,100) >= 80 and hour <= 16 and bomzQW = 0 and week ! 4:
	*clr & cla
	gs 'stat'
	gs 'time'
	gs 'zz_render', '', 'images/sauna/bomz.jpg', func('trashplace_strings', 'local_str33')
	if money >= 300:
		act 'Да, держите':
			*clr & cla
			money -= 300
			gs 'stat'
			gs 'zz_render', '', '', func('trashplace_strings', 'local_str34')
			act 'Уйти': gt 'street'
		end
	end
	act 'Нет':
		*clr & cla
		gs 'time'
		gs 'zz_render', '', '', func('trashplace_strings', 'local_str35')
		dynamic $bomzstartqwestdi
	end
	act 'Отвали':
		*clr & cla
		bomzQW = -10
		gs 'stat'
		gs 'zz_render', '', '', func('trashplace_strings', 'local_str36')
		act 'Уйти': gt'street'
	end
	exit
end
act 'Уйти': gt'street'