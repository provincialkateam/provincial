if $ARGS[0] = 'dress_after_backwater':
	gs 'zz_clothing', 'redress', prev_clothing
	clothesbackwater = 0
	tanga = flag_tanga
	prev_clothing = -1
	swamp_clothes = 0
	gt $loc, $metka
end
if $ARGS[0] = 'backwater_ralax':
    *clr & cla
	minut += 5
	hantersRape = 3
	gs 'stat'
	gs 'zz_render', 'Затон', 'qwest/gadukino/hantersex/backwaterrelax.jpg', 'Сделав свои дела вы присели на берегу отдохнуть.'
	act 'Далее':gt 'hanters'
end
if $ARGS[0] = 'hunter_looks':
    *clr & cla
	minut += 5
	hantersday = day
    gs 'stat'
	gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/hunter_looks.jpg', 'Находясьу затона в чем мать родила, вы вдруг понимаете, что не одни тут. Обернувшись, вы увидели кого-то из охотников. Он просто стоял и смотрел, практически не различимый в своем камуфляже на фоне кустов и деревьев.'
	if clothesswamphouse = 1 and clearclothes = 0:
	    act'Одеться':
		    *clr & cla
			clothesswamphouse = 0
			minut += 5
			tanga = flag_tanga
			gs 'zz_clothing', 'redress', prev_clothing
			prev_clothing = -1
		    gs 'zz_render', 'Затон', 'images/qwest/gadukino/Swamp/swampbackwaternude1.jpg', 'Вы, сломя голову, кинулись к своей одежде, и в темпе принялись одеваться. Когда, уже одевшись, вы оглянулись, кроме вас у затона никого больше не было.'
		    act'Далее':gt'swamphouse'
		end
    else
        act'Спрятаться':
            *clr & cla
            minut += 1
		    gs 'zz_render', 'Затон', 'images/qwest/gadukino/Swamp/swampbackwaternude2.jpg', 'Вы кое-как прикрыв грудь и промежность юркнули в ближайшие кусты. Когда, справившись с испугом и смущением, вы оттуда выглянули, кроме вас у затона никого больше не было.'
		    act'Далее':gt 'backwater'
		end
    end
    if shameless['flag'] > 0:
		act'Остаться голышом':
			*clr & cla
			hanterslut += 1
			hanterknowday = day
			gs'stat'
			gs 'zz_render', 'Затон', 'qwest/gadukino/Swamp/swampbackwaternude3.jpg', 'Вы решили, что стеснятся вам нечего, и остались перед мужчиной как есть, полностью обнаженная. Мужчина еще с минуту разглядывал вас, потом хмыкнув голосом Андрея, развернулся и ушел прочь.'
			act'Далее':gt 'backwater'
		end
    end
end