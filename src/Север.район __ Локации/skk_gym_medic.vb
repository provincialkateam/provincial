gs 'stat'
gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_cab.jpg', $skk_gym_[113]
act 'Пройти мед. осмотр' : gt 'skk_gym_medic' , 'med.osmotr'
act 'В коридор' : gt 'skk_gym_kor'
if $args[0] = 'med.osmotr' :
	cla & *clr
	gs 'zz_render','<<$skk_gym_[14]>>','city/north/skk/gym/med/med_cab.jpg', 'Пока пилится, тут делать нечего'
	act 'В коридор' : gt 'skk_gym_kor'
	exit
elseif $args[0] = 'med.osmotr' :
	cla & *clr
	exit
end