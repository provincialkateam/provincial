if curly > 0:curly -= 1
sweat += 1
if tan > 0:tan -= 2
if tan < 0: tan = 0
if tabletki > 0:tabletki -= 1
leghair += 1
lobok += 1
if wetbelo > 0: drybelo += wetbelo & wetbelo = 0
manna -= 10
if anus > 1:
	if anusK < 0: anusK = 0
	if anusK < 3: anusK += 1
	if anusK >= 3: anus -= 1 & anusK = 0
end
if vagina > 10:
	if vaginaK < 0: vaginaK = 0
	if vaginaK < 6: vaginaK += 1
	if vaginaK >= 6: vaginaK = 0 & vagina -= 1
end
lipkoef -= 1
!!!!!!!!!!!!
!!!РАБОТЫ!!!
!!!!!!!!!!!!
if isprok = 1: isprok = 0 & gs 'zz_render','','','Вы выкинули использованный тампон.'
!ЦИКЛ 28 дней, 4 дня ментсруация
if pregnancy = 0:
	if mesec > 0:mesec -= 1
	if mesec = 0:cikl += 1
	if cikl >= 23 and pregnancy = 0: mesec = 4 & cikl = 0
	if mesec > 0 and tampon > 0 and $settings['autotampon'] = 1:
		isprok = 1
		tampon -= 1
	end
else
	if pregnancy < 280:
		pregnancy += 1
		if pregTimes = 0: pregTimes = 1
	elseif pregnancy = 280:
		gs 'zz_render','','','<red>Резко толкнуло в живот и что-то потекло по ногам. Черт, у вас отошли воды! Надо срочно в поликлинику!</red>'
	else
		*clr & cla
		gs 'zz_render','','','<red>Страшная боль пронзила вас внизу живота.</red>'
		xgt 'gameover',3
		exit
	end
end
if vagina = 0:
	horny -= horny/5 + 1
elseif vagina > 0:
	if pregTimes = 0:
		horny -= horny/(iif(age < 18,5,8))
	else
		horny += iif(pregnancy = 0,10 - horny/10,pregnancy/10)
	end
end
if horny < 0: horny = 0
if horny > 100: horny = 100
! Обработка веса
if body['day_weight'] >= 3:
	! набор 3 ед. за день - прирост веса
	body['increase_weight'] += 1
	body['day_weight'] = 0
elseif body['day_weight'] = 0:
	! сброс веса при голодании
	if hungry_time >= 36:
		body['weight'] -= 1
		hungry_time = 0
		health -= 10
	end
elseif body['day_weight'] < 0:
	! сброс веса
	if hungry_time >= 36:
		! вариант 1 - голодание
		body['weight'] -= 1
		health -= 10
		hungry_time = 0
	else
		! вариант 2 - спорт
		! для нормального веса и выше
		if body['weight'] > (body['base_weight'] + 5):
			body['increase_weight'] -= 1
			body['day_weight'] = 0
		else
			! для мелкотни ничего, иначе загоним спортом в дистрофичку
		end
	end
end
body['day_weight'] = 0
if fatdel_day > 0:fatdel_day -= 1 & body['increase_weight'] -= 1
if body['increase_weight'] >= 5:
	body['weight'] += 1
	body['increase_weight'] = 0
elseif body['increase_weight'] <= -5:
	body['weight'] -= 1
	body['increase_weight'] = 0
end
! Падение физических показателей
downmusl += 1
if downmusl > 5:
	downmusl = 0
	if stren > 10: stren -= 1
	if vital > 10: vital -= 1
	if speed > 10: speed -= 1
	if agil > 10: agil -= 1
	if react > 10: react -= 1
	if Jab > 50: Jab -= 1
	if Punch > 50: Punch -= 1
	if Kik > 50: Kik -= 1
	if KikDef > 50: KikDef -= 1
end
gs 'zz_clothing', 'decrease_condition'