if mesec = 0 and pregnancy = 0 and tabletki = 0:
	!нет месячных
	if rand(0,100) >= 93:
		$father = $boy
		pregnancy = 1
	end
elseif tabletki > 0:
	if RAND(0,200) = 0:
		$father = $boy
		pregnancy = 1
	end
end