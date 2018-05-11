! banda['stage'] = 0 - ветка не открыта
! 1 - ГГ трахнули в парке и притащили на квартиру
! 2 - 11 - ГГ трахают на хате, при 11 открывается диалог о присоединении
! 20 - бандиты согласились принять ГГ в банду, дальнейший путь пока не определен
! 50 - вступила на путь воровки
! 100 - вступила на студийный путь
! 200 - вступила на киллерпуть
! 255 - ветка закрыта
! banda['fail'] - счетчик неправильного выбора в квартире, если 3 и больше - закрытие ветки
! banda['counter'] - счетчик ивентов в день - не больше 2
! banda['documents'] -
! banda['counter'] -
*clr & cla
gs 'zz_render', '', 'city/north/banda/02.jpg','Альберт, он же Ал, лысый татуированный главарь бандитов'
act '<B>Отойти</B>': gt $loc, $metka
!тут расписываешь действия дома, поболтать потрахаться и старты ивентов
if banda['location'] = 0:
	if banda['stage'] < 20:
	else
		act 'Поболтать' : gt 'banda_events','razgovor1'
		if horny > 50: act 'Приставать' : gt 'banda_events','razgovor2'
	end
	exit
	!Условия старта ивента для тренировки ловкости
	if banda['theffail'] = 2 and agil <= 65 and banda['eventthef3'] ! day: act'Ехать тренироваться в спортзал': gt 'rb_thef','eventthef3'
	!Условия старта ивента для тренировки силы и ловкости
	if banda['sniper'] = 1 and banda['eventsniper2'] ! day: act'Заниматься в спортзале общефизической подготовкой с Альбертом.': gt 'rb_sniper','eventsniper2'
	!Условия старта первого ивента для тренировки ударов
	if banda['sniper'] = 1 and banda['sniper_trening'] = 0: act'Заниматься в спортзале единоборствами с Димасом.': gt 'rb_sniper','eventsniper3'
	!Условия старта ивента для тренировки меткости
	if banda['sniper'] = 1 and banda['eventsniper4'] ! day: act'Ехать в тир на работу Геннадия стрелять из пистолета.': gt 'rb_sniper','eventsniper4'
	!Условия старта ивента для продвинутой тренировки меткости
	if banda['sniper'] = 1 and banda['eventsniper5'] ! day: act' Ехать учиться стрелять из винтовки.': gt 'rb_sniper','eventsniper5'
	!Условие старта ивента для продвинутой тренировка ударов
	if banda['sniper_trening'] = 1 and banda['eventsniper6'] ! day: act'Заниматься в спортзале единоборствами с Димасом.': gt 'rb_sniper','eventsniper6'
!тут расписываешь действия когда бухают, выпить, закусить, поболтать, потрахаться и старты ивентов
elseif banda['location'] = 3:
	!разговор с бандитами в офисе студии
	if banda['studio'] = 1 and studio['ofisdialog1'] ! day :act'Поговорить о студии': gt 'banda_studioQW','ofisdialog1'
	!разговор с бандитами в офисе при красоте 60 и выше
	if banda['studio'] = 1 and vnesh > 60 and studio['ofisdialog1'] ! day :act'Поговорить о себе': gt 'banda_studioQW','ofisdialog2'
end