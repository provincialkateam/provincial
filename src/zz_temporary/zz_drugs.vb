! drugs['type'] - тип препарата: 0 - трава, 1 - таблетки
! drugs['effect'] - эффект от наркоты: 0 - позитив, 1 - негатив
! drugs['status'] - текущее состояние наркомании, 0-100
!	76 - 100 - эйфория
!	51 - 75 - начало ломки
!	26 - 50 - активная ломка
!	1 - 25 - попуск
!	0 - чистый разум
! drugs['addict'] - счетчик употреблений:
!	< 5 - без привыкания
!	> 20 - зависимость
!---
! установка состояния
if $args[0] = 'set_status':
	drugs['type'] = args[0]
	drugs['status'] += 100
	! при 180 и выше - передоз, только для таблеток
	if drugs['type'] = 1 and drugs['status'] >= 180:
		gt 'gameover',6
	else
		! сброс в 100 для правильного расчета
		drugs['status'] = 100
	end
	drugs['effect'] = iif(rand(0,10) mod 5 = 0,1,0)
	if drugs['effect'] = 0:
		manna += rand(50,80)
	else
		manna -= rand(10,20)
	end
	if drugs['type'] = 0:
		energy -= rand(10,15)
	else
		drugs['addict'] += 1
	end
end
!---
! установка значений для stat
if $args[0] = 'set_values':
	if drugs['status'] > 50 and drugs['status'] <= 75:
		if drugs['type'] = 0:
			if manna > 80: manna = 80
			if horny > 80: horny = 80
		else
			if manna > 60: manna = 60
			if horny > 60: horny = 60
		end
	elseif drugs['status'] > 25 and drugs['status'] <= 50:
		if drugs['type'] = 0:
			if manna > 60: manna = 60
			if horny > 40: horny = 40
		else
			if manna > 10: manna = 10
			horny = 0
		end
	elseif drugs['status'] > 0 and drugs['status'] <= 25:
		if drugs['type'] = 0:
			if manna > 70: manna = 70
			if horny > 40: horny = 40
		else
			if manna > 30: manna = 30
			horny = 0
		end
	end
	if drugs['status'] < 0: drugs['status'] = 0
	! при зависимости ставим низкий уровень настроения и повышение депрессии
	if drugs['addict'] > 20 and manna >= 10: manna = 9
end
!---
! почасовой пересчет состояния
if $args[0] = 'hour_recalc':
	if drugs['status'] <= 0: exit
	if drugs['type'] = 0:
		_addict_time = 16
	else
		if drugs['status'] > 25 and drugs['status'] <= 50:
			_addict = drugs['addict']/5
			if _addict > 5: _addict = 5
			_addict_time = 12 - _addict
			health -= 1
			manna -= rand(_addict,3*(_addict+1))
		else
			_addict_time = 16
		end
	end
	drugs['status'] -= _addict_time
	killvar '_addict_time'
	killvar '_addict'
end
! просчет блокировки действий
if $args[0] = 'block':
	if (drugs['addict'] > 20 and drugs['status'] < 75) or (drugs['status'] > 0 and drugs['status'] < 75):
		result = 1
	else
		result = 0
	end
end