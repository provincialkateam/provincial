if lesbian > 0:
	horny += 10
else
	manna += 10
end
gs 'stat'
$dancegevtipe[0] = 'Вероничка Мохова делает растяжку и наконец то садится на шпагат.'
$dancegevtipe[1] = 'Вероничка Мохова делает стойку на руках.'
$dancegevtipe[2] = 'Вероничка Мохова разминается.'
$dancegevtipe[3] = 'Вероничка Мохова делает шпагат стоя на руках, при этом она без трусов.'
i = rand(0,3)
gs 'zz_render','','images/qwest/alter/ev2/ev<<i>>',$dancegevtipe[i]
killvar 'dancegevtipe'
act 'Уйти': gt 'gdksport'