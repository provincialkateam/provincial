gs 'stat'
gs 'zz_render','Зона рычажковых тренажеров','city/north/skk/gym/lever/lever.jpg','Куча приблуд для работы на силу со свободными весами, но всё ещё относительно безопасно. Здесь <a href="exec:GT ''skk_gym_lever_zona'',''random''">тренируются</a> всерьёз.'
act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
if $args[0] = 'random' :
	cla & *clr
	i = rand(1,6)
	minut += 3
	horny += 1
	gs 'zz_render','Кардио зона','city/north/skk/gym/lever/levers<<i>>.jpg',$skk_gym_[i+106]
	!к блочным или в зал
	act 'к блочным тренажерам' : gt 'skk_gym_lever_zona'
	act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
end