!под наркотой
if drugs['status'] > 0 :
	cla & *clr
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/GG_nark.jpg', $skk_gym_[205]
	minut+=1
	act 'Уйти' : gt 'skk_gym_kor'
	exit
end
gs 'stat'
gs 'zz_render','Тренажерный зал','city/north/skk/gym/zal.jpg', $skk_gym_[34] +'<a href="exec:GT ''skk_gym_cardio_zona''"><<$skk_gym_[35]>></a>'+', <<$skk_gym_[36]>> '+'<a href="exec:GT ''skk_gym_block_zona''"><<$skk_gym_[37]>></a>' + ', ' + '<a href="exec:GT ''skk_gym_lever_zona''"><<$skk_gym_[38]>></a>' + $skk_gym_[39] + '<a href="exec:GT ''skk_gym_free_zona''"><<$skk_gym_[40]>></a>.'+$skk_gym_[201]+ ' <a href="exec:GT ''skk_gym_zal'',''muzhiki''"><<$skk_gym_[52]>></a>.'+iif(day_tren_SKK = day,' <b><<$skk_gym_[203]>></b>','')
!МУЖИКИ В УГЛУ КОПОШАТСЯ
if $args[0] = 'muzhiki' :
	cla & *clr
	minut += 3
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/kach/<<rand(1,19)>>_muzhiki.webm',''
	act '<<$skk_gym_[123]>>' : gt 'skk_gym_zal'
end
!условие, что не тренировалась сегодня
if day_tren_SKK ! day :
	act 'Начать разминку':
		cla & *clr
		!больная
		if sick >= 1 :
			gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/GG_sick.jpg', $skk_gym_[202]
			minut+=1
			act 'Уйти' : gt 'skk_gym_kor'
			exit
		!пьяная
		elseif alko >= 1 :
			gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/GG_alko.jpg', $skk_gym_[204]
			minut+=1
			act 'Уйти' : gt 'skk_gym_kor'
			exit
		end
		gt 'skk_gym_zal', 'train'
	end
end
act 'В коридор' : gt 'skk_gym_kor'
!тренировка, разминка
if $args[0] = 'train' :
	cla & *clr
	day_tren_SKK = day
	i = rand(1,3)
	if i =1 : i1 = rand(1,3)
	if i =2 : i1 = 1
	if i =3 : i1 = rand(1,2)
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/razmin/razmin<<i>>_<<i1>>.jpg', $skk_gym_train[i]
	minut += 10
	gs 'zz_funcs', 'sport', 5
	act 'Тренировка на силу' : gt 'skk_gym_zal', 'train_sila'
	act 'Тренировка на выносливость' : gt 'skk_gym_zal', 'train_stamina'
	exit
end
!кач на силу
if $args[0] = 'train_sila' :
	cla & *clr
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_sila<<iif(stren>=95,1,0)>>_<<rand(1,3)>>.jpg', $skk_gym_train_sila[1]
	act 'Далее':
		cla & *clr
		gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_sila<<iif(stren>=95,4,3)>>_<<iif(stren>=95,rand(1,2),rand(1,5))>>.jpg', $skk_gym_train_sila[2]
		act 'Далее':
			cla & *clr
			gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_sila5_<<rand(1,6)>>.jpg', $skk_gym_train_sila[3]
			act 'Далее':
				cla & *clr
				gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_sila6_<<rand(1,7)>>.jpg', $skk_gym_train_sila[4] + $skk_gym_train_sila1[rand(1,10)]
				act 'Далее':
					cla & *clr
					gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_sila7_1.jpg', $skk_gym_train_sila[5]
					act 'Далее':
						cla & *clr
						gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_sila<<iif(stren>=95,9,8)>>_<<iif(stren>=95,rand(1,7),rand(1,1))>>.jpg', $skk_gym_train_sila[6]
						act 'Закончить':
							minut += 45
							stren += 1
							gs 'zz_funcs', 'sport', 30
							gt 'skk_gym_zal'
						end
					end
				end
			end
		end
	end
end
!кач на выносливость
if $args[0] = 'train_vital' :
	cla & *clr
	gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_vital1.jpg', $skk_gym_train_vital[1] + $skk_gym_train_sila1[rand(1,10)]
	act 'Далее':
		cla & *clr
		gs 'zz_render','Тренажерный зал','city/north/skk/gym/train/train_vital2.jpg', $skk_gym_train_vital[2]
		act 'Закончить':
			minut += 45
			vital += 1
			gs 'zz_funcs', 'sport', 30
			gt 'skk_gym_zal'
		end
	end
end