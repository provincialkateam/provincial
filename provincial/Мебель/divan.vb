if $ARGS[0] = 'start':
	*clr & cla
	gs 'zz_render', '', 'images/pics/divan.jpg', 'Вы легли на диван.'
	gs 'zz_funcs','waiting',1
	if TV > 0: act 'Смотреть телевизор': gt 'TV','start'
	if horny >= 50: act 'Мастурбировать': gt 'selfplay'
	if son < 10:
		act 'Раздеться и лечь спать':notathomesleep += 1 & gs 'bed', 'sleep'
	else
		act 'Постараться уснуть':gs 'bed', 'sleep'
	end
	act 'Встать с дивана': gt $loc, $metka
end