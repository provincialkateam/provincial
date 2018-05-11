*clr & cla
frost = 0
gs 'zz_funcs', 'colorize_day'
minut += 5
gs 'stat'
gs 'zz_render','Комната Игоря','images/qwest/alter/kruglov/kom.jpg'
if hour >= 15:
	gs 'zz_render', '', '', 'Вы видите <a href="exec:GT ''igor''">Игоря</a>.'+iif($npc['4,mishka'] > 0,'**На кровате лежит плюшевый мишка, с сердечком в руках.','')
else
	gs 'zz_render', '', '', 'Вы посмотрели на часы и поняли, что вам пора домой.'
end
act 'Уйти': gt 'gorodok'