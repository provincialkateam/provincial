if $args[0] = '48,check':
	if week <= 7:
		if hour >= 0 and hour <= 7 : $npc['48,sleep'] = 1
		if hour = 8 : $npc['48,bath'] = 1
		if hour = 9 : $npc['48,eat'] = 1
		if hour >= 10 and hour <= 15 : $npc['48,work'] = 1
		if hour >= 16 and hour < 0 : $npc['48,room'] = 1
	end
end
if $args[0] = '38,check':
	if week <= 5:
		if (hour >= 0 and hour <= 7) or (hour >= 18 and hour < 0) : $sister['location'] = 'room'
		if (hour = 8 and minut > 30) or (hour >= 16 and hour <= 18): $sister['location'] = 'kitchen'
		if hour = 8 and minut <= 30: $sister['location'] = 'bathroom'
		if hour >= 8 and hour < 16: $sister['location'] = 'shop'
	end
	if week > 5:
		if (hour >= 9 and hour <= 15) or (hour >= 20 and hour < 0) : $sister['location'] = 'room'
		if (hour = 8 and minut > 30) or hour = 19 :	$sister['location'] = 'kitchen'
		if hour = 8 and minut <= 30: $sister['location'] = 'bathroom'
		if hour > 15 and hour <= 18: $sister['location'] = 'cafe_parco'
	end
	if $sister['location'] = $curloc: gs 'zz_family', 'sister_act'
end