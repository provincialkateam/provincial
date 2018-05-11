gs 'beach','check_people'
gs 'stat'
gs 'time'
gs 'zz_render','Лес рядом с диким пляжем','images/pavlovo/glake/forest.jpg','Вы находитесь в лесу рядом с диким пляжем.**'+iif(voyeurism_forest = 0,'<b>Мимо вас проходит симпатичная блондинка в тёмном платье. У вас возникает желание проследить за ней.</b>','Вы нашли здесь замечательные кусты из-за которых хорошо видно пляж, но не видно вас и вашего возбуждения. Кроме того, в лес частенько заходят девушки чтобы пописать и проследить за ними не составляет труда.')
if lake_people > 2:
	if voyeurism_forest = 0:
		act 'Проследить за девушкой': minut += 10 & gt'glake_events','gLakeNudeForest_piss'
	else
		act 'Подсматривать за нудистами':
			gs 'glake_events','gLakeNude_nudist'
			act 'Отвести взгляд': gt 'gLakeNudeForest'
		end
		act 'Подсматривать за писающими':
			cla & *clr
			minut += 10
			horny += 10
			voyeurism += 1
			kol_foto_piss = 169
			viewforestpiss = rand(1,kol_foto_piss)
			gs 'stat'
			gs 'zz_render','','images/pavlovo/glake/piss_forest/piss_forest_'+rand(1,kol_foto_piss)+'.jpg','Вы прячетесь за дерево и смотрите, как струи мочи вырываются из киски девушки.'
			act 'Назад': gt 'gLakeNudeForest'
		end
	end
else
	gs 'zz_render','', '', 'На пляже '+iif(lake_people = 2,'практически ','')+'никого нет, так что подсматривать не за кем.'
end
act 'Выйти на пляж': minut +=5 & gt 'gLakeNude'