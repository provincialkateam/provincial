if $ARGS[0] = 'player':
	defsumV = agilV + reactV + KikDefV
	defkofV = defsumV*20/100
	defV = RAND(defsumV - defkofV,defsumV + defkofV)
	if popad >= defV*2:
		'<b><font color = green>КРИТ</font></b>'
		damageKrit = damage*20/100
		damage += damageKrit
		healthV -= damage
		pointKik += 1
		'<font color = green>Вы нанесли <<damage>> единиц урона</font>'
		if damage >= healthV*20/100:
			pointKik += 1
			'<font color = green><<$boy>> упала на ринг</font>'
			if healthV < (vitalV*10 + strenV*5)/4:
				'<font color = green><<$boy>> в нокауте. Это победа!!!</font>'
				xgt'enderKik','winKO'
				exit
			end
		end
	elseif popad < defV*2 and popad >= defV:
		'<font color = green>Попадание</font>'
		healthV -= damage
		pointKik += 1
		'<font color = green>Вы нанесли <<damage>> единиц урона</font>'
		if damage >= healthV*20/100:
			pointKik += 1
			'<font color = green><<$boy>> упала на ринг</font>'
			if healthV < (vitalV*10 + strenV*5)/4:
				'<font color = green><<$boy>> в нокауте. Это победа!!!</font>'
				xgt'enderKik','winKO'
				exit
			end
		end
	elseif popad < defV:
		'<font color = red>Промах</font>'
	end
end
if $ARGS[0] = 'enemy':
	defsum = agil + react + KikDef
	defkof = defsum*20/100
	def = RAND(defsum - defkof,defsum + defkof)
	if popad >= def*2:
		'<b><font color = red>КРИТ</font></b>'
		damageKrit = damage*20/100
		damage += damageKrit
		health -= damage
		pointKikV -= 1
		'<font color = red>Вам нанесли <<damage>> единиц урона</font>'
		if damage >= health*20/100:
			pointKikV -= 1
			'<font color = red>Вы упали на ринг</font>'
			if health < (vital*10 + stren*5)/4:
				'<font color = red>Вы в нокауте. Это поражение!</font>'
				xgt'enderKik','loss'
				exit
			end
		end
	elseif popad < def*2 and popad >= def:
		'<font color = red>Попадание</font>'
		health -= damage
		pointKikV -= 1
		'<font color = red>Вам нанесли <<damage>> единиц урона</font>'
		if damage >= health*20/100:
			pointKikV -= 1
			'<font color = red>Вы упали на ринг</font>'
			if health < (vital*10 + stren*5)/4:
				'<font color = red>Вы в нокауте. Это поражение!</font>'
				xgt'enderKik','loss'
				exit
			end
		end
	elseif popad < def:
		'<font color = green>Промах</font>'
	end
end