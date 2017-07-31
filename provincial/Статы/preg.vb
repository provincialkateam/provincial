if mesec = 0 and preg = 0 and tabletki = 0:
	!нет месячных
	pregrand = RAND(0,100)
	if pregrand >= 93:
		$father = $boy
		preg = 1
	end
	if tabletki > 0:
		pregrand = RAND(0,200)
		if pregrand = 0:
			$father = $boy
			preg = 1
		end
	end
end