if $ARGS[0] = 'start':
	if bfA = 0 and stopboy = 0:
		stopboy = 1
		gs'boyfrend','A'
	elseif bfA > 0 and bfB = 0 and stopboy = 0:
		stopboy = 1
		gs'boyfrend','B'
	elseif bfA > 0 and bfB > 0 and bfC = 0 and stopboy = 0:
		stopboy = 1
		gs'boyfrend','C'
	elseif bfA > 0 and bfB > 0 and bfC > 0 and stopboy = 0:
		'Хмм, у вас и так уже три бойфренда, зачем вам четвертый?'
	end
end
if $ARGS[0] = 'A':
	!stopboy = 0
	$boyA = $boy
	boybodyrandA = boybodyrand
	$boybodyA = $boybody
	boybodrandA = boybodrand
	$boybodA = $boybod
	boyfacerandA = boyfacerand
	$boyfaceA = $boyface
	dickA = dick
	silaVagA = silaVag
	financeA = finance
	vneshBoyA = vneshBoy
	$boyCloA = $boyClo
	figurBoyA = figurBoy
	titBoyA = titBoy
	haerBoyA = haerBoy
	harakBoyA = harakBoy
	boydayA = day
	bfA = 1
	daya = 0
	boyonceA = 0
	izvratA = izvrat
	giftDayA = 0
	giftNumA = 0
	love = 0
	boypicA = boypic
end
if $ARGS[0] = 'B':
	!stopboy = 0
	$boyB = $boy
	boybodyrandB = boybodyrand
	$boybodyB = $boybody
	boybodrandB = boybodrand
	$boybodB = $boybod
	boyfacerandB = boyfacerand
	$boyfaceB = $boyface
	dickB = dick
	financeB = finance
	vneshBoyB = vneshBoy
	$boyCloB = $boyClo
	figurBoyB = figurBoy
	haerBoyB = haerBoy
	harakBoyB = harakBoy
	boydayB = day
	bfB = 1
	dayb = 0
	boyonceB = 0
	boypicB = boypic
end
if $ARGS[0] = 'C':
	!stopboy = 0
	$boyC = $boy
	boybodyrandC = boybodyrand
	$boybodyC = $boybody
	boybodrandC = boybodrand
	$boybodC = $boybod
	boyfacerandC = boyfacerand
	$boyfaceC = $boyface
	dickC = dick
	financeC = finance
	vneshBoyC = vneshBoy
	$boyCloC = $boyClo
	figurBoyC = figurBoy
	haerBoyC = haerBoy
	harakBoyC = harakBoy
	boydayC = day
	bfC = 1
	dayc = 0
	boyonceC = 0
	boypicC = boypic
end