if $ARGS[0] = 'win':
	pointKik = 0
	pointKikV = 0
	round = 0
	minround = 0
	if health < 10: health = 10
	if profi = 1:
		KikWinPro += 1
		profi = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif amature = 1:
		KikWinAm += 1
		amature = 0
		amatReit += 1
		money += 500 + kikmoney
		gs 'zz_render','','','Вам вручили приз 500 рублей.'
		gs'razrKik'
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif sparing = 1:
		sparing = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	end
end
if $ARGS[0] = 'winKO':
	pointKik = 0
	pointKikV = 0
	round = 0
	minround = 0
	if health < 10:health = 10
	if profi = 1:
		KikWinPro += 1
		KikKOPro += 1
		profi = 0
		act 'Отойти':gt 'fitness','dressroom'
		exit
	elseif amature = 1:
		KikWinAm += 1
		amatReit += 1
		amature = 0
		money += 500
		gs 'zz_render','','','Вам вручили приз 500 рублей.'
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif sparing = 1:
		sparing = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	end
end
if $ARGS[0] = 'loss':
	pointKik = 0
	pointKikV = 0
	round = 0
	minround = 0
	if health < 10:health = 10
	if profi = 1:
		KikLossPro += 1
		profi = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif amature = 1:
		KikLossAm += 1
		if amatReit > 0: amatReit -= 1
		amature = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif sparing = 1:
		sparing = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	end
end
if $ARGS[0] = 'draw':
	pointKik = 0
	pointKikV = 0
	round = 0
	minround = 0
	if health < 10:health = 10
	if profi = 1:
		KikDrawPro += 1
		profi = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif amature = 1:
		KikDrawAm += 1
		amature = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	elseif sparing = 1:
		sparing = 0
		act 'Уйти': gt 'fitness','dressroom'
		exit
	end
end