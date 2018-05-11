gs 'stat'
gs 'zz_render','Зона блочных тренажеров','city/north/skk/gym/block/block.jpg','Безопасная силовая тренировка. Здесь всегда много <a href="exec:GT ''skk_gym_block_zona'',''random''">людей</a>.'
!вернуться в зал
act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
if $args[0] = 'random' :
	cla & *clr
	i = rand(1,10)
	gs 'zz_render','Зона блочных тренажеров','city/north/skk/gym/block/blocks<<i>>.jpg',$skk_gym_[i+96]
	minut += 3
	if i ! 9 : horny += 1
	act 'к блочным тренажерам' : gt 'skk_gym_block_zona'
	act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
end