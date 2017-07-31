$d_vok_man_toilet_event = {
vok_toilet_event = RAND(0,4)
if vok_toilet_event > 0:
	gs 'zz_render','','','Когда вы уже приступили к уборке туалета,'+func('vokmantoiev', 'vok_toilet_event_strings','toilet_event'+vok_toilet_event)
	if voyeurism > 40:
		act 'Подглядеть':
			cla & *clr
			minut += 1
			voyeurism += 1
			if voyeurism > 30:horny += 5
			gs 'zz_render','','images/wannabe/tualete/men/men_'+iif(vok_toilet_event = 2,'0',rand(3,12))+'.jpg','Вы оторвали свой взляд от тряпки, который вы мыли пол и стали подглядывать за тем как он отливает. '+iif(voyeurism > 30,'Зрелище немного вас возбудило.','')
			act 'Закончить уборку':
				cla & *clr
				minut += 10
				gs 'zz_render','','images/wannabe/tualete/clean.jpg','Когда он уходит, вы продолжаете заниматься уборкой мужского туалета. Протерев и дезинфицировав все унитазы и писсуары, вы тоже покидаете туалет.'
				act 'Уйти':minut += 1 & gt'vokzalGin'
			end
		end
	end
end
}
if $args[0] = 'vok_toilet_event_strings':
	if $args[1] = 'toilet_event1': $result = ' в него заскочил мужик, которому было явно невтерпёж. Он бросил на вас короткий взгляд и решив, что вы ему не помешаете устремился к писсуару.'
	if $args[1] = 'toilet_event2': $result = ' в него зашёл начальник вокзала. Он не обратил на вас никакого внимания и встав у писсуара начал писать.'
	if $args[1] = 'toilet_event3': $result = ' в него зашёл гоповатого вида парень. Он подмигнул вам и сказал: <do>- Чё каво, кисуля?</do> Не дождавшись ответа он подошёл к писсуару и начала писать.'
	if $args[1] = 'toilet_event4': $result = ' в него зашёл какой-то мужик и обойдя вас начал писать в писсуар.'
end