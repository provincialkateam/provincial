init = speed + react
initKoef = init*20/100
initi = RAND(initi - initKoef,initi + initKoef)
initV = speedV + reactV
initKoefV = initV*20/100
initiV = RAND(initiV - initKoefV,initiV + initKoefV)
if initi > initiV and hodtime < 3 and ionce = 0 or hodtimeV >= 3 and ionce = 0:
	hod = 0
	hodtime += 1
	if hodtimeV >= 3:hodtimeV = 0
	'<font color = green>Вы захватили инициативу</font>'
	ionce = 1
elseif initi < initiV and hodtimeV < 3 and ionce = 0 or hodtime >= 3 and ionce = 0:
	hod = 1
	hodtimeV += 1
	if hodtime >= 3:hodtime = 0
	'<font color = red><<$boy>> захватил инициативу</font>'
	ionce = 1
elseif initi = initiV and hodtime < 3 and hodtimeV < 3 and ionce = 0:
	ionce = 1
	if RAND(0,1) = 0:
		hod = 0
		hodtime += 1
		'<font color = green>Вы перехватили инициативу</font>'
	else
		hod = 1
		hodtimeV += 1
		'<font color = red><<$boy>> перехватила инициативу</font>'
	end
elseif initi = initiV and hodtime >= 3 and ionce = 0 or initi = initiV and hodtimeV >= 3 and ionce = 0:
	hodtime = 0
	hodtimeV = 0
	ionce = 1
	if RAND(0,1) = 0:
		hod = 0
		hodtime += 1
		'<font color = green>Вы перехватили инициативу</font>'
	else
		hod = 1
		hodtimeV += 1
		'<font color = red><<$boy>> перехватила инициативу</font>'
	end
end