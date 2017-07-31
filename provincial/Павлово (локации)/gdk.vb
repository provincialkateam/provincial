$metka = $ARGS[0]
$loc = $CURLOC
gs 'zz_phone','boyfriend_call_init'
gs 'stat'
gs 'time'
act '<b>Выйти</b>': gt 'gorodok'
gs 'zz_funcs','waiting'
gs 'zz_render','Дом культуры',func('zz_funcs','mk_image','pavlovo/dk/dk')
killvar '$result'
$result[0] = ' ,Рабочее время,Примечание'
$result[1] = 'Паспортный стол,09.00-14.00,выдача документов - по понедельникам'
$result[2] = 'Библиотека,09.00-18.00, '
$result[3] = 'Кружок кройки и шитья,15.00-20.00,3000 руб'
$result[4] = 'Cпортивные секции,15.00-20.00,1500-3000 руб'
$result[5] = 'Дискотека,20.00-23.00,50 руб'
gs 'zz_funcs','make_table',$result,600
gs 'zz_family', 'sister_sheduler'
if hour >= 9 and hour <= 14 and week < 6: act 'Паспортный стол': gt 'zz_passport_stol', 'start'
if hour >= 9 and hour <= 18: act 'Идти в библиотеку': gt 'gdkbibl'
if hour >= 15 and hour < 20:
	act 'Идти на кружки': gt 'gdkkru'
	act 'Идти в секцию': gt 'gdksport'
end
if hour >= 20 and hour <= 22:
	gs 'zz_render','','','У входа в ДК полно молодёжи: парни просто стоят и курят, болтают промеж собой почище девчонок, украдкой попивают пиво, и приглядываются к девчонкам. Девочки тусят маленькими группками по двое-трое и шушукаются, скорее всего либо сплетничая, либо обсуждая парней. Кто-то просто втихаря бухает в кустах. Полиция сюда порой заходит, но смотрит в основном сквозь пальцы - лишь бы драк не было.'
	act 'Войти в клуб':
		if dk_disco_day ! day:
			if money >= 50:
				dk_disco_day = day
				money -= 50
				minut += 5
				gt 'gdkin'
			else
				gs 'zz_render','','','<red>У вас недостаточно денег - вход 50 рублей.</red>'
			end
		else
			minut += 5
			gt 'gdkin'
		end
	end
end