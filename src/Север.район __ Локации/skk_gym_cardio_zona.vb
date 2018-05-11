gs 'stat'
!описание
gs 'zz_render','Кардио зона','city/north/skk/gym/cardio/cardio.jpg',$skk_gym_[121]+'<a href="exec:GT ''skk_gym_cardio_zona'',''random''"><<$skk_gym_[122]>></a>'
!вернуться в зал
act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
!рандом в зале
if $args[0] = 'random' :
	cla & *clr
	i = rand(1,7)
	minut += 3
	if i ! 1 or i ! 3 or i ! 5: horny += 1
	gs 'zz_render','Кардио зона','city/north/skk/gym/cardio/<<i>>_cardio.jpg',$skk_gym_[i+113]
	!уход из ивента
	act 'в кардиозону' : gt 'skk_gym_cardio_zona'
	act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
end