if lesbian > 0:
	horny += 10
else
	manna += 10
end
danceevtimes += 1
dancegevtipe = iif(danceevtimes < 5,RAND(0,2),RAND(0,3))
gs 'stat'
'<center><img src="images/qwest/alter/ev2/ev'+dancegevtipe+'.jpg"></center>'
if dancegevtipe = 0:
	'Вероничка Мохова делает растяжку и наконец то садится на шпагат.'
elseif dancegevtipe = 1:
	'Вероничка Мохова делает стойку на руках.'
elseif dancegevtipe = 2:
	'Вероничка Мохова разминается'
elseif dancegevtipe = 3:
	'Вероничка Мохова делает шпагат стоя на руках, при этом она без трусов.'
end
act 'Уйти':gt'gdksport'