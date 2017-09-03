if $args[0] = 'veronika_check':
	!Расписание Вероники
	!Пн - Чт:
	!1.00-7.00 - спит
	!7.00-7.30 - пробежка.
	!7.30-8.00 - в душе
	!8.00-8.30. на кухне
	!8.30-16.00 - универ
	!16.00-17.00 - комната
	!17.00-20.00 - с НПС в общежитии
	!20.00-21.00 - комната
	!21.00-1.00 - бордель
	!Пт:
	!1.00-7.00 - спит
	!7.00-7.30 - пробежка
	!7.30-8.00 - в душе
	!8.00-8.30. на кухне
	!8.30-14.00 - универ
	!14.00-16.00 - комната
	!16.00-19.00 - с НПС в общежитии
	!19.00-20.00 - комната
	!20.00- -0,00 бордель
	!Сб:
	!0,00-9.00 - бордель
	!9.00-14.00 - спит
	!14.00-14.30 - в душе
	!14.30-15.00 на кухне
	!15.00-16.00 - комната
	!16.00-19.00 - с нпс в общежитии
	!19.00-20.00 - комната
	!20.00-0.00 - бордель
	!Вс:
	!0.00-9.00 - бордель
	!9.00-14.00 - спит
	!14.00-14.30 - в душе
	!14.30-15.00 на кухне
	!15.00-16.00 - комната
	!16.00-1.00 - спецклиенты
	!------------------------
	!спит
	$npc['47,sleep'] = 0
	!душ
	$npc['47,bath'] = 0
	!еда
	$npc['47,eat'] = 0
	!зарядка
	$npc['47,exercise'] = 0
	!универ
	$npc['47,university'] = 0
	!комната
	$npc['47,room'] = 0
	!с НПС в общежитии
	$npc['47,nps'] = 0
	!бордель
	$npc['47,bordello'] = 0
	!спецклиенты
	$npc['47,bordellovip'] = 0
	if week <= 4:
		if hour < 7: $npc['47,sleep'] = 1
		if hour = 7 and minut <= 30: $npc['47,exercise'] = 1
		if hour = 7 and minut > 30: $npc['47,bath'] = 1
		if hour = 8 and minut <= 30: $npc['47,eat'] = 1
		if hour >= 8 and minut > 30 and hour < 16: $npc['47,university'] = 1
		if hour = 16 and hour = 20: $npc['47,room'] = 1
		if hour >= 17 and hour < 20: $npc['47,nps'] = 1
		if hour >= 21: $npc['47,bordello'] = 1
	elseif week = 5:
		if hour < 7: $npc['47,sleep'] = 1
		if hour = 7 and minut <= 30: $npc['47,exercise'] = 1
		if hour = 7 and minut > 30: $npc['47,bath'] = 1
		if hour = 8 and minut <= 30: $npc['47,eat'] = 1
		if hour >= 8 and minut > 30 and hour < 14: $npc['47,university'] = 1
		if hour = 14 and hour <= 16 and hour = 19: $npc['47,room'] = 1
		if hour >= 16 and hour < 19: $npc['47,nps'] = 1
		if hour >= 20: $npc['47,bordello'] = 1
	elseif week = 6:
		if hour > 0 and hour < 9: $npc['47,bordello'] = 1
		if hour = 9 and hour < 14: $npc['47,sleep'] = 1
		if hour = 14 and minut <= 30: $npc['47,bath'] = 1
		if hour = 14 and minut > 30: $npc['47,eat'] = 1
		if hour = 15 and hour = 19: $npc['47,room'] = 1
		if hour >= 16 and hour < 19: $npc['47,nps'] = 1
		if hour >= 20: $npc['47,bordello'] = 1
	else
		if hour > 0 and hour < 9: $npc['47,bordello'] = 1
		if hour = 9 and hour < 14: $npc['47,sleep'] = 1
		if hour = 14 and minut <= 30: $npc['47,bath'] = 1
		if hour = 14 and minut > 30: $npc['47,eat'] = 1
		if hour = 15: $npc['47,room'] = 1
		if hour >= 16 and hour <= 0: $npc['47,bordello'] = 1
	end
end