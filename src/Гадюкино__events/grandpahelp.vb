gs 'stat'
gs 'time'
gs 'zz_render','','images/qwest/gadukino/grandpa1.jpg'
gs 'zz_render','','','Вы подошли к дедушке и спросили не нужна ли ему какая-либо помощь. Дедушка подумал немного и сказал:'
if month = 1:grandpahelping = RAND(0,5)
if month = 2:grandpahelping = RAND(0,5)
if month = 3:grandpahelping = RAND(0,5)
if month = 4:grandpahelping = RAND(0,5)
if month = 5:grandpahelping = RAND(6,11)
if month = 6:grandpahelping = RAND(12,21)
if month = 7:grandpahelping = RAND(22,32)
if month = 8:grandpahelping = RAND(22,32)
if month = 9:grandpahelping = RAND(12,21)
if month = 10:grandpahelping = RAND(0,4)
if month = 11:grandpahelping = RAND(0,4)
if month = 12:grandpahelping = RAND(0,4)
!month >= 1 and month < 5 and month > 9
if grandpahelping = 0 or grandpahelping = 6 or grandpahelping = 12 or grandpahelping = 22:
	gs 'zz_render','','',' - Конечно внучка, нужно во дворе навести порядок.'
	act 'Убирать двор':
		*clr & cla
		minut += 60
		grandpahelp += 1
		grandpaQW += 1
		body['day_weight'] -= 1
		if month >= 4 and month <= 10:
			stren += 1
			gs 'zz_render','','images/qwest/gadukino/new/clean_yard1.jpg'
			gs 'zz_render','','','Вооружившись граблями, вы принялись за уборку двора. После того как двор приобрел божеский вид, вы довольная собой поставили грабли в сарай и отправились по своим делам.'
		else
			gs 'zz_render','','images/qwest/gadukino/new/clean_yard2.jpg'
			gs 'zz_render','','','Вооружившись лопатой, вы принялись очищать двор от снега. После того как двор приобрел божеский вид, вы довольная собой поставили лопату в сарай и отправились по своим делам.'
		end
		gs 'stat'
		act 'Уйти':gt'Gaddvor'
	end
end
if grandpahelping = 1 or grandpahelping = 7:
	gs 'zz_render','','',' - Конечно Света, нужно дров для печки принести.'
	act 'Принести дрова':
		*clr & cla
		minut += 15
		grandmahelp += 1
		grandpaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/firewood'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg'
		gs 'zz_render','','','Вы быстро оделись, и быстро сбегав к сараю за дровами вернулись обратно. '
		gs 'zz_render','','',' - Все, деда, принесла,- сказали вы дедушке.'
		gs 'zz_render','','',' - Быстро ты, однако,- посмотрев на вас ответил он с улыбкой. - Вот что значит молодость. Беги, гуляй, на сегодня работы нет больше.'
		act 'Уйти':gt'Gadhouse'
	end
end
if grandpahelping = 2:
	gs 'zz_render','','',' - Конечно внучка, ступай в сарай, покорми Буяна.'
	act 'Идти в сарай':
		*clr & cla
		feed_horse = 1
		minut += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg'
		gs 'zz_render','','','Вы пошли в сарай кормить коня.'
		act 'Далее':gt'Gadsarai'
	end
end
if grandpahelping = 3:
	gs 'zz_render','','',' - Внучка, сходи-ка в сарай, покормить Зорьку нужно.'
	act 'Идти в сарай':
		*clr & cla
		minut += 15
		feed_cow = 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg'
		gs 'zz_render','','','Вы пошли в сарай где вас уже заждалась Зорька'
		act 'Далее':gt'Gadsarai'
	end
end
if grandpahelping = 4:
	gs 'zz_render','','',' - Конечно внучка, ступай в сарай, нужно Буяна расчесать.'
	act 'Идти в сарай':
		*clr & cla
		comb_horse = 1
		minut += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg'
		gs 'zz_render','','','Вы пошли в сарай расчесывать коня.'
		act 'Далее':gt'Gadsarai'
	end
end
if grandpahelping = 5 or grandpahelping = 13 or grandpahelping = 23:
	gs 'zz_render','','',' - Конечно внучка, ступай в сарай, покорми кабана.'
	act 'Идти в сарай':
		*clr & cla
		feed_boar = 1
		minut += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg'
		gs 'zz_render','','','Вы пошли в сарай кормить кабана.'
		act 'Далее':gt'Gadsarai'
	end
end
if grandpahelping = 8 or grandpahelping = 14 or grandpahelping = 24:
	if week > 5:
		gs 'zz_render','','',' - Конечно внучка, ступай в сарай, нужно Буяна расчесать.'
		act 'Идти в сарай':
			*clr & cla
			comb_horse = 1
			minut += 15
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/go_yard'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg'
			gs 'zz_render','','','Вы пошли в сарай расчесывать коня.'
			act 'Далее':gt'Gadsarai'
		end
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти': gt $loc, $metka
	end
end
if grandpahelping = 9 or grandpahelping = 15 or grandpahelping = 25:
	if hour >= 6 and hour < 9:
		gs 'zz_render','','',' - Света, внучка, отведи коня на поле, а то у меня сегодня ноги болят. А вечером я его сам заберу.'
		act 'Идти в сарай':
			*clr & cla
			horse_field = 1
			minut += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
			gs 'zz_render','','','Вы пошли в сарай где стоит конь.'
			act 'Далее':& gt'Gadsarai'
		end
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти':gt $loc, $metka
	end
end
if grandpahelping = 10 or grandpahelping = 16 or grandpahelping = 26:
	if hour >= 6 and hour < 9:
		gs 'zz_render','','',' - Светуля у меня сегодня болят ноги. Так что, внучка, отведи корову на поле и отдай в стадо к пастухам, вечером они её сами пригонят домой.'
		act 'Идти в сарай':
			*clr & cla
			cow_field = 1
			minut += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
			gs 'zz_render','','','Вы пошли в сарай где стоит Зорька.'
			act 'Далее':gt'Gadsarai'
		end
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти': gt $loc, $metka
	end
end
if grandpahelping = 11 or grandpahelping = 17 or grandpahelping = 27:
	if hour >= 6 and hour < 9:
		if graze_cow_exp = 0: ' - Света, внучка, сегодня пришла наша очередь коров пасти. Так что, внучка, поешь быстренько, бери Зорьку и веди на поле. А я пойду туда сразу, стадо встречать.'
		if graze_cow_exp > 0: ' - Света, внучка, сегодня пришла наша очередь коров пасти. Так что, внучка, поешь быстренько, беги на поле стадо встречать. А я пригоню туда Зорьку.'
		act 'Идти '+iif(graze_cow_exp = 0,'в сарай','на поле'):
			*clr & cla
			graze_cow = 1
			manna += 20
			health += 10
			cumlip = 0
			water = 24
			energy += 10
			body['day_weight'] += iif(energy > 24,2,iif(energy > 15 and energy < 25,1,0))
			minut += 20
			$inventory[5+'_count'] += 1
			$inventory[6+'_count'] += 1
			gs 'stat'
			if graze_cow_exp = 0:
				gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
				gs 'zz_render','','','Быстро перекусив вы пошли в сарай где стоит Зорька. Бабушка еще вам положила в сумку бутерброд и бутылку воды на обед.'
				act 'Далее': gt 'Gadsarai'
			else
				gs 'zz_render','','images/qwest/gadukino/gadfield/cow_go_field.jpg'
				gs 'zz_render','','','Быстро перекусив вы побежали на поле, где уже собиралось деревенское стадо. Бабушка еще вам положила в сумку бутерброд и бутылку воды на обед.'
				act 'Далее':gt'gadfield','graze_field'
			end
		end
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти': gt $loc, $metka
	end
end
!month = 6 or month = 9
if grandpahelping = 18 or grandpahelping = 28:
	if temper >= 20 and sunWeather >= 0 and week > 5:
		gs 'zz_render','','',' - Внучка, сегодня хорошая погода. Отведи Буяна на речку, искупай его. Да и сама искупаешься.'
		act 'Идти в сарай':
			*clr & cla
			horse_river = 1
			minut += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
			gs 'zz_render','','','Вы пошли в сарай где стоит конь.'
			act 'Далее': gt'Gadsarai'
		end
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти': gt $loc, $metka
	end
end
if grandpahelping = 19 or grandpahelping = 29:
	if go_in_boletus = 0 and go_in_bilberry = 0 and go_in_boletus_bilberry = 0:
		grandpa_boletus = rand(2,3)
		go_in_boletus = 1
		gs 'zz_render','','',' - Света, внучка, сходи-ка в лес за грибами. Что-то грибочков жареных захотелось.'
		gs 'zz_render','','',' - А сколько нужно, деда? - спросили вы.'
		gs 'zz_render','','',' - Да <<grandpa_boletus>> кг будет достаточно, - ответил дедушка. - Только смотри, не заблудись внучка.'
		act 'Уйти':gt $loc, $metka
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти':gt $loc, $metka
	end
end
if grandpahelping = 20 or grandpahelping = 30:
	if go_in_boletus = 0 and go_in_bilberry = 0 and go_in_boletus_bilberry = 0:
		grandpa_bilberry = rand(3,5)
		go_in_bilberry = 1
		gs 'zz_render','','',' - Света, внучка, сходи-ка в лес за ягодами. Бабушка варенья наварит.'
		gs 'zz_render','','',' - А сколько нужно, деда? - спросили вы.'
		gs 'zz_render','','',' - Да <<grandpa_bilberry>> кг будет достаточно, - ответил дедушка. - Только смотри, не заблудись внучка.'
		act 'Уйти': gt $loc, $metka
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти': gt $loc, $metka
	end
end
if grandpahelping = 21 or grandpahelping = 31:
	if go_in_boletus = 0 and go_in_bilberry = 0 and go_in_boletus_bilberry = 0:
		grandpa_boletus = rand(2,3)
		grandpa_bilberry = rand(2,3)
		go_in_boletus_bilberry = 1
		gs 'zz_render','','',' - Света, внучка, сходи-ка в лес за ягодами и грибами. Бабушка супа грибного сварит, да и ягод свежих поедим.'
		gs 'zz_render','','',' - А сколько нужно, деда? - спросили вы.'
		gs 'zz_render','','',' - Да <<grandpa_boletus>> кг грибов и <<grandpa_bilberry>> кг ягод будет достаточно, - ответил дедушка. - Только смотри, не заблудись внучка.'
		act 'Уйти': gt $loc, $metka
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти': gt $loc, $metka
	end
end
!month = 7 or month = 8
if grandpahelping = 32:
	if temper >= 20 and sunWeather >= 0 and hour >= 6 and hour < 9:
		gs 'zz_render','','',' - Внучка, сегодня сенокос. Надо идти на поле и помочь.'
		gs 'zz_render','','',' - Хорошо, деда, - ответили вы. Потом, взяв грабли, отправились на поле '
		act 'Идти на поле':
			*clr & cla
			haying_time = 1
			minut += 40
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/gadfield/go_gadfield.jpg'
			gs 'zz_render','','','Вы взяли грабли и пошли на поле, где уже собирались остальные местные жители.'
			act 'Далее':gt'gadfield','field'
		end
	else
		gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
		act 'Уйти':gt $loc, $metka
	end
end