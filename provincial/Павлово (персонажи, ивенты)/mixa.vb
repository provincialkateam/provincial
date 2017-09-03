*clr & cla
gs 'zz_render', '', 'pavlovo/family/insrct/home/01.jpg'
if $npc['48,sleep'] = 1:
	!миша спит действия
elseif $npc['48,bath'] = 1:
	!миша в ванной действия
elseif $npc['48,eat'] = 1:
	!миша есть действия
elseif $npc['48,room'] = 1:
	!миша в комнате действия
end
act '<B>Отойти</B>': gt $loc, $metka