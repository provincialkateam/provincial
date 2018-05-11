gs 'stat'
i = rand (1,11)
gs 'zz_render','Зона свободных весов','city/north/skk/gym/free/free.jpg','Только хардкор! <a href="exec:GT ''skk_gym_free_zona'',''random''">Суровые спортсмены и спортсменки</a> оккупировали это место и не пускают непосвящённых в этот клуб. Главный тренер <a href="exec:GT ''skk_gym_free_zona'',''trener_random'', i "><<$skk_gym_[i+52]>></a> За не разобранную штангу здесь можно получить пощечину блином от этой штанги.'
act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
!рандом в зале
if $args[0] = 'random' :
	cla & *clr
	i = rand (1,33)
	gs 'zz_render','Кардио зона','city/north/skk/gym/free/frees<<i>>.jpg','<<$skk_gym_[i+63]>>'
	minut +=3
	if i!6: horny +=1
	!к свободным весам или в общий зал
	act 'к свободным весам' : gt 'skk_gym_free_zona'
	act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
end
!тренер в зале
if $args[0] = 'trener_random' :
	cla & *clr
	i = args[1]
	gs 'zz_render','Кардио зона','city/north/skk/gym/free/trener/trener<<i>>.jpg','<<$skk_gym_[i+52]>>'
	minut +=3
	!к свободным весам или в общий зал
	act 'к свободным весам' : gt 'skk_gym_free_zona'
	act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
end