gs 'zz_funcs', 'colorize_day'
sauna += 1
gs 'zz_render','Сауна','images/pic/sauna.jpg','Отлично отремонтированная сауна.'
act 'Уйти': minut += 15 & gt'street'
if SaunaWhore > 0: act 'Идти работать шлюхой': gt'saunawork'
if week = 5 and workDisk = 2:
	gs 'zz_render','','','У входа вас уже ждет крепкий мужчина ожидая от вас диска.'
	act 'Отдать диск':
		*clr & cla
		minut += 20
		workDisk = 3
		konvert = 1
		gs 'stat'
		gs 'zz_render','','','Вы отдали диск и вам вручили толстый конверт.'
		act 'Уйти': minut += 15 & gt 'street'
	end
end
if hour >= 8 and hour <= 23:
	if money >= 2000 and saunaday ! day:
		gs 'zz_render','','','Снять номер на час стоит 2000 руб.'
		act 'Идти в сауну':
			*clr & cla
			money -= 2000
			minut += 60
			body['day_weight'] -= 3
			gs 'zz_bathroom', 'clean_me'
			saunaday = day
			manna = 100
			vidageday += 1
			gs 'zz_funcs', 'skin', '+', 5
			gs 'stat'
			gs 'zz_render','Сауна','images/pic/sau.jpg','Вы в течение часа парились в сауне, мылись под душем и расслаблялись.'
			act 'Одеться и уйти': gt 'street'
		end
	end
end