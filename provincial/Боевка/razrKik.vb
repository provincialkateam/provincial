if razradKik = 0:
	if amatReit >= 5:
		razradKik = 1
		amatReit = 0
		kikmoney = 200
		'Вам присвоили 3й любительский разряд по кикбоксингу.'
	end
elseif razradKik = 1:
	if amatReit >= 10:
		razradKik = 2
		amatReit = 0
		kikmoney = 500
		'Вам присвоили 2й любительский разряд по кикбоксингу.'
	end
elseif razradKik = 2:
	if amatReit >= 15:
		razradKik = 3
		amatReit = 0
		kikmoney = 1500
		'Вам присвоили 1й любительский разряд по кикбоксингу.'
	end
elseif razradKik = 3:
	if amatReit >= 20:
		razradKik = 4
		amatReit = 0
		kikmoney = 3500
		'Вам присвоили звание Кандидата в Мастера Спорта по кикбоксингу.'
	end
elseif razradKik = 4:
	if amatReit >= 25:
		razradKik = 5
		amatReit = 0
		kikmoney = 7500
		'Вам присвоили звание Мастера Спорта по кикбоксингу.'
	end
end