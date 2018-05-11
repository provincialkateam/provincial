gs 'stat'
gs 'zz_render','Коридор','city/north/skk/gym/skk_gym_kor.jpg', $skk_gym_[41] +'<a href="exec:GT ''skk_gym_medic''"><<$skk_gym_[42]>></a>'+', '+'<a href="exec:GT ''skk_gym_massage''"><<$skk_gym_[43]>></a>'+', '+'<a href="exec:GT ''skk_gym_cabtrener''"><<$skk_gym_[44]>></a>'+', <a href="exec:GT ''skk_gym_men'',''in''"><<$skk_gym_[47]>></a>'+ $skk_gym_[50] + '<a href="exec: ivent_loc = rand(1,7) & GT ''skk_gym_girl'', ''in''"><<$skk_gym_[48]>></a>' + $skk_gym_[49]
act 'Идти в зал' :
	if func('zz_clothing2','get_group') = 1:
		gt 'skk_gym_zal'
	else
		delact 'Идти зал'
		gs 'zz_render','','','<b>Сначала надо переодеться в форму, иначе тренер меня кончит!</b>'
	end
end
act 'На ресепшен' : gt 'skk_gym'