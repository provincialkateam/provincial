if $args[0] = 'start' or $args[0] = '':
	cla
	gs 'stat'
	act 'Выйти':
		if cloth[0] > 2 or (cloth[0] = 0 and shameless['flag'] >= 2 and ($loc = 'bedrPar' or $loc = 'bedr' or $loc = 'korr')):
			gt 'loker', 'fin'
		else
			gs 'zz_render','','','<red>Вы стесняетесь в таком виде появиться в комнате.</red>'
		end
	end
	if cloth[0] > 0 and $loc ! 'gschool':
		act 'Снять одежду':
			*clr & cla
			gs 'zz_clothing2','redress',0
			gs 'zz_render','','common/clothing/0/0','Вы полностью разделись'
			act 'Выйти': gt 'loker'
		end
	end
	if cloth[0] >= 3:
		act iif(cloth[1]=1,'Снять','Надеть') + ' трусики':
			*clr & cla
			cloth[1] = iif(cloth[1] = 1,0,1)
			gs 'zz_render','','common/clothing/0/'+iif(cloth[1] = 0,0,6),'Вы '+iif(cloth[1]=0,'сняли','надели')+' трусики.'
			act 'Назад': gt 'loker'
		end
	end
	gs 'zz_render','','','<p style="text-align:center">На верхней полке лежит купальник.**У вас есть еще <<panties/500+1>> ед. трусиков.**Внизу шкафа стоит <a href="exec:gt''zz_clothing2'',''trashbag''">корзина со старой одеждой</a></p>'
	gs 'zz_clothing2','wardrobe'
end
if $ARGS[0] = 'fin':
	clothesswamphouse = 0
	clothesbackwater = 0
	clothesforest = 0
	swamp_clothes = 0
	if dirtyclothes > 0: dirtyclothes = 0
	gt $loc, $metka
end