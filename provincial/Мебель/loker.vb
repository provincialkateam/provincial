if $args[0] = 'start' or $args[0] = '':
	cla
	gs 'stat'
	act 'Выйти':
		if current_clothing > 2 or current_clothing = 0 and shameless['flag'] >= 2 and ($loc = 'bedrPar' or $loc = 'bedr' or $loc = 'korr'):
			gt 'loker', 'fin'
		else
			'<b><font color = red>Вы стесняетесь в таком виде появиться в комнате.</font></b>'
		end
	end
	if current_clothing ! 0 and $loc ! 'gschool':
		act 'Снять одежду':
			*clr & cla
			gs 'zz_clothing','redress',0
			tanga = 0
			gs 'zz_render','','clothing/0','Вы полностью разделись'
			act 'Выйти': gt 'loker'
		end
	end
	if current_clothing ! 1:
		if tanga = 1:
			act 'Снять трусики':
				*clr & cla
				tanga = 0
				flag_tanga = tanga
				gs 'zz_render','','clothing/take_off_panties','Вы сняли трусики'
				act 'Назад': gt 'loker'
			end
		elseif tanga = 0 and clrbelo > 0:
			act 'Надеть трусики':
				*clr & cla
				tanga = 1
				flag_tanga = tanga
				gs 'zz_render','','clothing/take_off_panties','Вы надели трусики'
				act 'Назад': gt 'loker'
			end
		end
	end
	gs 'zz_render','','','На верхней полке лежит купальник.
У вас есть еще <<clrbelo>> ед. трусиков.
Внизу шкафа стоит <a href="exec:gt''zz_clothing'',''trashbag''">корзина со старой одеждой</a>
<font size=-1><a href="exec:gt''zz_clothing'',''wardrobe_settings''">Настройки шкафчика</a></font>'
	gs 'zz_clothing', 'wardrobe', iif($loc = 'bordel',13,args[1])
end
if $ARGS[0] = 'fin':
	prev_clothing = -1
	clothesswamphouse = 0
	clothesbackwater = 0
	clothesforest = 0
	swamp_clothes = 0
	if dirtyclothes > 0:
		dirtyclothes = 0
		if clrbelo > 0: clrbelo -= 1 & dirtbelo += 1
	end
	gt $loc, $metka
end