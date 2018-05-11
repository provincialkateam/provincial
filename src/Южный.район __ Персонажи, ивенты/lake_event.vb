if $ARGS[0] = 'aquapark':
	*clr & cla
	minut += 5
	gs 'stat'
	gs'time'
	if lake_people < 2:
		gs 'zz_render', $_str, 'images/city/south/lake/event/aquapark.jpg','Вы подошли к аттракционам. Сейчас тут практически никого нет.'
	elseif lake_people < 4:
		gs 'zz_render', $_str, 'images/city/south/lake/event/aquapark1.jpg','Вы подошли к аттракционам. Вокруг развлекаются люди, но особого ажиотажа не наблюдается'
	else
		gs 'zz_render', $_str, 'images/city/south/lake/event/aquapark2.jpg','Вы подошли к аттракционам. Тут целое столпотворение народа, не протолкнуться. К аттракционам выстраиваются очереди'
	end
	gs 'zz_render','','','**Тут есть <a href="exec:gt''lake_event'',''gidro''">гидроциклы</a>, <a href="exec:gt''lake_event'',''banan''">банан</a> и <a href="exec:gt''lake_event'',''gorka''">горка</a>.'
	act 'Уйти':gt'Lake'
end
if $ARGS[0] = 'gidro':
	*clr & cla
	gs 'zz_render', $_str, 'images/city/south/lake/event/gidro.jpg','Вы подходите к гидроциклам.**Цена поездки 100 руб.'
	if money >= 100:
		act 'Прокатиться':
			*clr & cla
			manna += 10
			money -= 100
			minut += 30
			gs 'stat'
			gs 'zz_render', $_str, 'images/city/south/lake/event/gidro'+rand(1,3)+'.jpg','Вы садитесь на гидроцикл. Вам надевают на руку браслет с чекой-"глушилкой" и объясняют на что жать. Вы катаетесь, визжа от восторга.'
			if rand(1,5) = 1:gt'lake_event','kater1'
			act 'Закончить':gt'lake_event','aquapark'
		end
	end
	act 'Отойти':gt'lake_event','aquapark'
end
if $ARGS[0] = 'banan':
	*clr & cla
	gs 'zz_render', $_str, 'images/city/south/lake/event/banan.jpg','Вы подходите к надувному банану.**Цена поездки 100 руб.'
	if money >= 100:
		act 'Прокатиться':
			*clr & cla
			manna += 10
			minut += 30
			money -= 100
			gs 'stat'
			gs 'zz_render', $_str, 'images/city/south/lake/event/banan'+rand(1,3)+'.jpg','Вы садитесь на банан и вас катают за катером. Вы визжите, пытаясь удержаться на нём.'
			i = RAND(0,100)
			if i >= 80 and i < 90:gt'lake_event','kater2'
			if i >= 90:gt'lake_event','kater3'
			act 'Закончить':gt'lake_event','aquapark'
		end
	end
	act 'Отойти':gt'lake_event','aquapark'
end
if $ARGS[0] = 'gorka':
	*clr & cla
	gs 'stat'
	gs 'zz_render', $_str, 'images/city/south/lake/event/gorka.jpg','Вы подходите к горке.**Цена поездки 50 руб.'
	if money >= 50:
		act 'Прокатиться':
			manna += 20
			*clr & cla
			minut += 15
			money -= 50
			gs 'zz_render', $_str, 'images/city/south/lake/event/gorka'+rand(1,3)+'.jpg','Вы поднимаетесь на горку и скатываетесь вниз, плюхаясь в воду с тучей брызг.'
			act 'Закончить':gt'lake_event','aquapark'
		end
	end
	act 'Отойти':gt'lake_event','aquapark'
end
if $ARGS[0] = 'horse':
	*clr & cla
	gs 'stat'
	gs 'time'
	minut += 1
	gs 'zz_render', $_str, 'images/city/south/lake/event/horse.jpg','Вы подходите к лошадям.**Цена поездки 100 руб.'
	if money >= 100:
		act 'Прокатиться':
			manna += 10
			*clr & cla
			minut += 30
			money -= 100
			gs 'zz_render', $_str, 'images/img/Lake/horse.jpg','Вы садитесь в седло и отправляетесь кататься по берегу озера, опасливо вцепившись в узду. Но лошадка, похоже, привычная, и ведёт себя смирно.'
			horserand = RAND(0,100)
			if horserand >= 60 and horserand < 80: gt'lake_event','horse1'
			if horserand >= 80: gt'lake_event','horse2'
			act 'Закончить':gt'lake'
		end
	end
	act 'Отойти':gt'lake'
end
if $ARGS[0] = 'voleybol':
	*clr & cla
	minut += 1
	gs 'time'
	if lake_people >= 3:
		gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol1.jpg','Вы подходите к волейбольной площадке.'
		act 'Смотреть':
			*clr & cla
			minut += 30
			manna += 20
			gs 'stat'
			gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol'+rand(2,4)+'.jpg','Вы смотрите как отдыхающие на пляже люди, весело играют в волейбол.'
			act 'Уйти': gt'lake'
		end
		act 'Играть':
			*clr & cla
			if stren < 20: stren += 1
			if vital < 20: vital += 1
			agil += iif(agil<40,1,rand(0,1))
			if stren < 30: stren += iif(stren<30,1,rand(0,1))
			if vital < 30: vital += iif(vital<30,1,rand(0,1))
			speed += iif(speed<40,1,rand(0,1))
			minut += 30
			manna = 100
			gs 'stat'
			gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol_play'+rand(1,3)+'.jpg','Вы подходите к играющим и спрашиваете можно ли вам присоединиться. Вас с удовольствием принимают в команду.'
			act 'Закончить': gt'lake'
		end
	else
		gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol.jpg','Вы подходите к волейбольной площадке, но сейчас она пустует - желающих поиграть нет.'
	end
	act 'Уйти': gt'lake'
end
if $ARGS[0] = 'voleybol_nude':
	*clr & cla
	minut += 1
	gs 'time'
	if lake_people >= 3:
		gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol_nude1.jpg', 'Вы подходите к волейбольной площадке'
		act 'Смотреть':
			*clr & cla
			minut += 30
			manna += 20
			gs 'stat'
			gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol_nude'+rand(2,5)+'.jpg', 'Вы смотрите как играют другие.'
			act 'Уйти':gt'Nudelake'
		end
		act 'Играть':
			*clr & cla
			if stren < 20: stren += 1
			if vital < 20: vital += 1
			agil += iif(agil<40,1,rand(0,1))
			if stren < 30: stren += iif(stren<30,1,rand(0,1))
			if vital < 30: vital += iif(vital<30,1,rand(0,1))
			speed += iif(speed<40,1,rand(0,1))
			minut += 30
			manna = 100
			gs 'stat'
			gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol_nude_play'+rand(1,2)+'.jpg', 'Вы подходите к играющим и спрашиваете можно ли вам присоединиться. Вас с удовольствием принимают в команду.'
			act 'Закончить':gt'Nudelake'
		end
	else
		gs 'zz_render', $_str, 'images/city/south/lake/event/voleybol_nude.jpg', 'Вы подходите к волейбольной площадке, но сейчас она пустует, желающих поиграть нет.'
	end
	act 'Уйти':gt'Nudelake'
end
if $ARGS[0] = 'walklake':
	if rand(1,2) = 1:
		*clr & cla
		gs 'zz_render', '', 'images/city/south/lake/fisherman/walklake.jpg','Гуляя по берегу озера увидели рыбака дремавшего возле своих удочек.**\\\- Эй красавица иди сюда,/// - позвал он, услышав ваши шаги.'
		if dom > -25: act 'Пройти мимо':minut += 5 & gt'lake'
		if ribakSex = 0:
			act 'Подойти':
				*clr & cla
				if dom > -10 or vnesh < 20:act 'Уйти':minut += 5 & gt'lake'
				if vnesh >= 20:
					gs 'zz_render', '', 'images/city/south/lake/fisherman/fisherman.jpg','Вы подошли к парню с удочкой. Он похотливо и вальяжно осмотрел вас с головы до ног**\\\- А ты ничего так, симпотная/// удовлетворённо кивнул парень, когда вы подошли ближе.'
					act 'Чего тебе надо?':
						*clr & cla
						dick = 25
						gs 'zz_render', '', 'images/city/south/lake/fisherman/fisherman.jpg','Вы поинтересовались, что парню нужно.**\\\- У тебя на лице написано, что ты блядушка,/// - сказал парень ухмыляясь. -\\\ Хочешь соснуть?///'
						if shameless['flag'] < 1:
							act 'Да как ты смеешь?':
								*clr & cla
								gs 'zz_render', '', 'images/city/south/lake/fisherman/resent.jpg','Вы возмутились таким наглым высказываниям. Парень только шире ухмыльнулся:**\\\- Да ладно, не парься, я люблю блядей...///** После этих слов парень расстегнул ширинку и достал немаленький член.**\\\- Ну же детка,/// - поманил вас к себе парень. -\\\ Смотри какая у папы есть вкусняшка, для твоего блядского ротика...///'
								act 'Идиот! (уходить)':
									*clr & cla
									gs 'zz_render', '', 'images/city/south/lake/fisherman/angry.jpg','Вы обозвали этого придурка идиотом и собрались уходить.**\\\ - Ну может я ошибся и ты не блядь, а шлюха?,/// - задумчиво произнёс парень. -\\\ Слышь шлюшка, хочешь штуку заработать?///'
									act 'Уйти': gt 'lake_event','fisherman_fuck'
								end
							end
						else
							act 'Что?':
								*clr & cla
								gs 'zz_render', '', 'images/city/south/lake/fisherman/surprised.jpg','Вы удивились подобной наглости. Парень только шире ухмыльнулся:**\\\- Ты еще сильнее удивишься, увидев ЭТО!...///** После этих слов парень расстегнул ширинку и достал немаленький член.**\\\- Ну же детка,/// - поманил вас к себе парень. -\\\ Смотри какая у папы есть вкусняшка, для твоего блядского ротика...///'
								act 'Идиот! (уходить)':
									*clr & cla
									gs 'zz_render', '', 'images/city/south/lake/fisherman/angry.jpg','Вы обозвали этого придурка идиотом и собрались уходить.**\\\ - Ну может я ошибся и ты не блядь, а шлюха?,/// - задумчиво произнёс парень. -\\\ Слышь шлюшка, хочешь штуку заработать?///'
									act 'Уйти': gt 'lake_event','fisherman_fuck'
									act 'Деньги вперед!':
										*clr & cla
										gs 'zz_render', '', 'images/city/south/lake/fisherman/money.jpg','\\- Деньги вперед!,// - '+iif(shameless['flag'] < 2,'помявшись','решительно')+' сказали вы.**\\\- Ну так с этого бы и начинала!,/// - расхохотался парень. -\\\ Сказала бы что ты шлюха, а не пудрила бы мне мозг'+iif(shameless['flag'] < 2,' разыгрывая из себя школьницу целку!','')+'!///**Парень достал деньги и вальяжно протянул их вам.'
										act 'Передумать': gt 'lake_event','fisherman_fuck'
										act 'Взять деньги': gt 'lake_event','fisherman_oral_money'
									end
								end
							end
						end
						act 'Подойти ближе':
							*clr & cla
							gs 'zz_render', '', 'images/city/south/lake/fisherman/grabbing.jpg','Вы неуверенно подошли ближе к парню, и тот, проворно схватив вас за запястье, буквально подтащил к себе.**\\\- Ну же детка, не еби мозг,/// - сказал он вам прямо в лицо. -\\\ Мы оба в курсе, что тебе до ужаса хочется попробовать мой хуй на вкус. Так не стесняйся!///'
							if (stren + agil) > 50:
								act 'Вырваться и убежать':
									minut += 5
									gt 'lake'
								end
							else
								act 'Подчиниться': gt 'lake_event','fisherman_oral'
							end
						end
					end
				else
					gs 'zz_render', '', 'images/city/south/lake/fisherman/fisherman.jpg','Вы подошли к парню с удочкой. Он похотливо и вальяжно осмотрел вас с головы до ног**\\\-Ну чтож ты страшная такая/// усмехнулся он, напевая себе под нос, когда вы подошли ближе.'
				end
			end
		else
			act 'Подойти':
				*clr & cla
				gs 'zz_render', '', 'images/city/south/lake/fisherman/fisherman.jpg','Вы подошли к парню и тот сказал вам:**\\\- Привет <<$ribakName>>, хочешь соснуть?///'
				if dom > -25: act 'Уйти': gt 'lake_event','fisherman_fuck'
				if $ribakName = 'шлюха':
					act 'Штука!':
						*clr & cla
						gs 'zz_render', '', 'images/city/south/lake/fisherman/money.jpg','\\- Штука!,// - сказали вы. -\\ И деньги вперед!//**Усмехнувшись, парень достал деньги, и вальяжно протянул их вам.'
						act 'Взять деньги': gt 'lake_event','fisherman_oral_money'
					end
				else
					act 'Встать перед парнем на колени':gt 'lake_event','fisherman_oral'
				end
			end
		end
	else
		gs 'zz_render', '', 'images/city/south/lake/stasValera/stasValera.jpg','Гуляя по берегу вы заметили '+ iif(StasikValera = 0,'двух парней','Стасика и Валеру') +' смотрящих на вас.'
		act 'Пройти мимо':minut += 5 & gt'lake'
		if StasikValera = 0:
			act 'Посмотреть на них':
				*clr & cla
				minut += 1
				gs 'stat'
				gs 'zz_render', '', 'images/city/south/lake/stasValera/talk1','Вы посмотрели на них и заметили как они стали перешептываться между собой. Затем один из парней подошел к вам. Он улыбаясь сказал:**\\\- Привет красавица, может познакомимся? Я Стасик, а это мой друг Валера. А тебя как зовут?///'
				gs 'lake_event','stasValera'
				act 'Мне пора идти':
					*clr & cla
					minut += 1
					gs 'stat'
					gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse1','Вы не собираетесь знакомится с этими мужиками и стали собираться уходить. Стасик начал вас уговаривать:**\\\- Да ладно, красотка. Мы что дикари какие? Мы же просто пообщаться хотели, а ты сразу пугаться. Может все же скажешь, как тебя зовут?///'
					gs 'lake_event','stasValera'
					act 'Уйти':minut += 5 & gt'lake'
				end
			end
		else
			act 'Помахать им':
				*clr & cla
				gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse3','Вы помахали знакомым парням и они, заулыбавшись, направились в вашу сторону.'
				gs 'lake_event','stasValera'
				if StVaGang > 0 and horny > 50:
					act 'Раздеваться':
						*clr & cla
						gs 'zz_render', '', 'images/city/south/lake/stasValera/undress','Глядя как они приближаются, вы демонстративно начинаете расстегивать свою одежду. Увидев это, парни чуть ли не бегом направились к вам, расстёгивая на бегу брюки.'
						act 'Опуститься на колени': gt'lake_event','stasValera_oral'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'stasValera':
	act iif(StasikValera = 0,'Света','Поболтать'):
		*clr & cla
		minut += 2
		gs 'stat'
		if StasikValera = 0:
			gs 'zz_render', '', 'images/city/south/lake/stasValera/talk2.jpg','Вы ответили парню, что вас зовут Света.**\\\- Приятно познакомиться, - ///парень улыбнулся ещё шире.** К вам, поздоровавшись, присоединился Валера, и парни, начали развлекать вас разговорами.'
		else
			gs 'zz_render', '', 'images/city/south/lake/stasValera/talk'+rand(3,5)+'.jpg','Парни подошли к вам, и поздоровавшись, начали развлекать вас разговорами.'
		end
		act 'Разговаривать':
			*clr & cla
			minut += 2
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/stasValera/talk6.jpg',iif(StasikValera = 0,'Стасик стал рассказывать вам, что они с Валерой работают в торговом представительстве одной крупной фирмы, да и вообще они очень важные птицы, знающие людей','Стасик без умолку рассказывал о своей работе в торговом представительстве крупной фирмы, а Валера, время от времени, ему поддакивал')+'.'+iif(TPmainQW < 4,' Не прекращая болтать Стасик, как бы не взначай, начал играться с застёжкой, в районе вашей груди.','')
			StasikValera = 1
			if TPmainQW < 4:
				act 'Убрать руки Стасика от себя':
					*clr & cla
					minut += 2
					gs 'stat'
					gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse2.jpg','Вы возмущенно убрали руки Стасика со своего тела. Стасик усмехнулся:\\\- Да ладно, детка, расслабься...///'
					if StVaGang = 0 or shameless['flag'] < 1:
						act 'Возмутиться и уйти':
							*clr & cla
							minut += 2
							gs 'stat'
							gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse3.jpg','Вы возмущенно встали на ноги и стали собираться уходить. Стасик вскочил вслед за вами и чтобы загладить вину начал уговаривать вас сходить с ними в кафе.'
							act 'Уйти':minut += 5 & gt'lake'
						end
					end
					act 'Промолчать':
						*clr & cla
						minut += 2
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'images/city/south/lake/stasValera/tits1.jpg','Вы промолчали и Стасик тут же воспользовался вашим замешательством. Его рука аккуратно сжала вашу груди и вы почувствовали как приятное тепло и нежность охватила всё ваше тело.'
						gs 'lake_event','stasValera2'
					end
				end
				if shameless['flag'] > 0:
					act 'Улыбаться, делая вид, что ничего не происходит':
						*clr & cla
						minut += 2
						horny += 10
						gs 'stat'
						gs 'zz_render', '', 'images/city/south/lake/stasValera/tits1.jpg','Вы начали улыбаться, чувствуя как прикосновения Стасика возбуждают вас. Вы лишь на секунду прикрыли глаза и вдруг ощутили руку на своей груди. Вы удивленно открыли глаза и увидели, как совершенно невозмутимый Стасик мнет вашу грудь, с мечтательной улыбкой на лице.'
						gs 'lake_event','stasValera2'
					end
				end
			else
				act 'Попрощаться и уйти':minut += 5 & gt'lake'
			end
		end
	end
end
if $ARGS[0] = 'stasValera2':
	act 'Далее':
		*clr & cla
		minut += 2
		horny += 20
		gs 'stat'
		gs 'zz_render', '', 'images/city/south/lake/stasValera/tits2.jpg','Вы расслабились и стали наслаждаться ощущениями, возникающими от прикосновений Стасика. Парень, отточенным движением, растегнул вашу одежду, освободив ваши груди. Вы не успели и глазом моргнуть, как губы Стасика охватили ваш сосок.'
		act 'Эй! Ты чего творишь?':
			*clr & cla
			minut += 2
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse4.jpg','Вы тут же очнулись и начали поправлять одежду. Стасик улыбнулся:**\\\- Не надо пугаться, '+iif(StasikSex > 0,'Светик','девочка')+'...///'
			act 'Уйти': minut += 5 & gt'lake'
		end
		act iif(shameless['flag'] < 2,'Вяло протестовать','Молчать'):
			*clr & cla
			minut += 2
			horny += iif(shameless['flag'] < 2,10,20)
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/stasValera/tits3.jpg',iif(shameless['flag'] < 2,'Вы постарались натянуть лифчик обратно и зашептали:**\\- Не надо!//**Стасик улыбнулся:**\\\- Не надо стесняться, '+iif(StasikSex > 0,'Светик','девочка')+'///.**','')+'Вы закрыли глаза, наслаждаясь тем, как умело Стасик ласкал вашу грудь. Он тут же выпустил ваш сосок из рта и вы почувствовали, как его пальцы '+iif(cloth[1] = 0,'проникли в ваши трусики и ','')+'начали ласкать вашу киску. Тут же вы почувствовали как Валера, подойдя сзади, обнял вас, и его рука оказалась у вас на груди, лаская её, и доставляя вам неземное удовольствие. Вы нежились в этих двойных объятиях, когда почувствовали, что парни начинают настойчиво давить вам на плечи, заставляя опуститься на колени.'
			if horny < 90 and (StVaGang = 0 or shameless['flag'] < 1):
				act 'Вы что? Я не такая!':
					*clr & cla
					gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse4.jpg','\\- Вы что? Я не такая! -//воскликнули вы, выныривая из сладостной неги, и убирая от себя их руки.**\\\- Да ладно, '+iif(StasikSex > 0,'Светик','детка')+', расслабься - ///улыбнулся вам Стасик, продолжая давить на плечи.\\\ - Ничего страшного не происходит...///'
					act 'Уйти':minut += 5 & gt'lake'
					act 'Опуститься на колени': gt'lake_event','stasValera_oral'
				end
			else
				act 'Опуститься на колени': gt'lake_event','stasValera_oral'
			end
		end
	end
end
if $ARGS[0] = 'stasValera_oral':
	*clr & cla
	minut += 5
	horny += 10
	if StasikSex = 0: guy += 1
	if ValeraSex = 0: guy += 1
	if $args[1] ! 'valera':
		StasikSex += 1
		ValeraSex += 1
		StVaGang += 1
		gang += 1
		bj += 1
		dynamic $venerasiak
	end
	dick = iif($args[1] = 'valera',17,15)
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/lake/stasValera/oral'+iif($args[1] = 'valera',rand(4,6),rand(1,3))+'.jpg','Вы опустились перед парн'+iif($args[1] = 0,'ями','ем')+' на колени, где тут же столкнулись с '+iif($args[1] = 0,'их, уже вставшими, членами','его членом')+'. '+iif($args[1] > 0,'',''+iif(shameless['flag'] < 2,'Немного помявшись вы','Вы тут же')+' принялись сосать их поочерёдно, стараясь доставить наслаждения обоим парням поровну. По их нетерпеливым движения, вы понимаете, что они готовы приступить к более активным действиям.')
	if $args[1] = 'valera':
		gs 'zz_dynamic_sex', 'bj'
		act 'Сосать дальше': gt'lake_event','stasValera_cum','valera'
	else
		act 'Сосать дальше': gt'lake_event','stasValera_cum'
		act 'Дать Стасику': gt'lake_event','stasValera_sex'
		act 'Дать Валерику': gt'lake_event','stasValera_sex','valera'
	end
end
if $ARGS[0] = 'stasValera_cum':
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/lake/stasValera/cum'+iif($args[1] = 'valera',rand(1,3),'')+'.jpg',iif($args[1] = 0,'Не обращая внимая, вы продолжили усердно сосать, и через некоторое время первая струя спермы ударила вам в рот. Парни по очереди кончали, изливаясь вам в рот и стараясь наполнить его до краёв. Спермы оказалось так много, что как вы не старались глотать, но она всё равно стекала по подбородку, капая вам на грудь. Наконец поток иссяк, парни отошли в сторону, а вы принялись поправлять на себе одежду.','')
	if $args[1] = 'valera':gs 'zz_dynamic_sex', 'swallow'
	act 'Приводить себя в порядок': gt'lake_event','stasValera_end'
end
if $ARGS[0] = 'stasValera_sex':
	$boy = iif($args[1] = 'valera','Валера','Стасик')
	dick = iif($args[1] = 'valera',17,15)
	silavag = 1
	pose = 1
	i = rand(1,5)
	gs 'zz_render', '', 'images/city/south/lake/stasValera/sex'+iif(i = 5,'',iif($args[1] = 'valera',rand(4,6),rand(1,3)))+'.jpg','Вы нагнулись раком, предоставляя '+iif($args[1] = 'valera','Валере','Стасику')+' доступ к своей  киске.'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_render', '', '','Пока вас трахал <<$boy>>, '+iif($args[1] = 'valera','Стасик','Валера')+' подобрался к вашему лицу и упер свой стоячий член в ваши губы.'
	dick = iif($args[1] = 'valera',15,17)
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'sex_cum'
	if i = 5:
		gs 'zz_render', '', '',''+iif($args[1] = 'valera','Стас','Валера')+' застонал сжав губы и его член вздрогнул в вашем рту.'
		gs 'zz_dynamic_sex', 'swallow'
		act 'Приводить себя в порядок': gt'lake_event','stasValera_end'
	else
		act 'Сосать дальше '+iif($args[1] = 'valera','Стасику','Валере')+'': gt'lake_event','stasValera_oral','valera'
		act 'Дать '+iif($args[1] = 'valera','Стасику','Валере')+'': gt'lake_event','stasValera_sex2'
	end
end
if $ARGS[0] = 'stasValera_sex2':
	$boy = iif($args[1] = 'valera','Стас','Валерик')
	dick = iif($args[1] = 'valera',15,17)
	silavag = 1
	pose = 1
	gs 'zz_render', '', 'images/city/south/lake/stasValera/sex'+rand(7,9)+'.jpg',''
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Приводить себя в порядок': gt'lake_event','stasValera_end'
end
if $ARGS[0] = 'stasValera_end':
	*clr & cla
	minut += 5
	gs 'stat'
	if horny > 70:
		horny = 0
		orgasm += 1
		gs 'zz_render', '', 'images/city/south/lake/stasValera/orgasm.jpg','Видя, что вы всё еще не удовлетворены и возбуждены, к вам подошел Валера::**\\\- Стой спокойно, Светик, сейчас я тебе помогу...///**С этими словами он проник пальцами в вашу возбуждённую киску и начал быстро-быстро двигать ими. От этих движений, буквально через несколько мгновений, вас накрыл мощный оргазм.'
		act 'Далее': gt'lake_event','stasValera_end'
	else
		gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse4.jpg','Стасик помог вам привести одежду в порядок, после чего произнёс:**\\\- Ты классная девчонка, Светик. Хочешь мы тебя проводим домой?///'
		act 'Не надо, я сама как-нибудь':
			*clr & cla
			minut += 10
			cumface = 0
			cumlip = 0
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/stasValera/refuse2.jpg','Вы отказались и Стасик пожал плечами:**\\\- Ну как знаешь...///**Приведя себя в порядок вы отправились на пляж.'
			act 'Уйти':gt'lake'
		end
		act 'Я не против':
			*clr & cla
			if cloth[0] < 3: gs 'zz_clothing2','redress',cloth[3]
			minut += 60
			cumface = 0
			cumlip = 0
			if StVaGang > 1:manna = 100
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/stasValera/talk'+iif(StVaGang = 1,3,5)+'.jpg','Парни дождались пока вы приведете себя в порядок и пошли в сторону вашего дома. По пути они много шутили и травили разные анекдоты, и просто смешные истории из жизни. Наконец вы остановились перед дверями вашей квартиры. И парни, попрощавшись с вами, ушли.'
			act 'Уйти':gt'korr'
		end
	end
end
if $ARGS[0] = 'fisherman_fuck':
	*clr & cla
	minut += 5
	dom += 1
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/lake/fisherman/fuck'+iif(cloth[0] > 2,'',iif(cloth[0] = 2,'_swim','_nude'))+'.jpg','\\- Да пошёл ты, придурок!,// - крикнули вы, и показав на прощание средний палец, двинулись прочь.'
	act 'Уйти': gt'lake'
end
if $ARGS[0] = 'fisherman_oral_money':
	*clr & cla
	minut += 5
	money += 1000
	ribakSex += 1
	if ribakSex = 0: guy += 1
	bj += 1
	manna = 0
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/lake/fisherman/oral_money'+rand(1,3)+'.jpg','Вы взяли деньги у парня и спрятали их.**\\\- На колени шлюха!,/// - оскалился довольный парень. -\\\ Открывай свой блядский рот!///**Вы  покраснели, но все же опустились перед парнем на колени и открыли рот.'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render', '', '','\\\- Что блядь, нравится?,/// - спросил парень, глядя на вас сверху. -\\\ Такой шлюхе как ты, это должно понравиться!///**Вы никак не реагируя продолжали двигать головой, наращивая темп, пока парень не прервал вас, вынув член из вашего рта. '
	act 'Ждать':
		*clr & cla
		minut += 1
		dom -= 1
		gs 'zz_funcs', 'cum','face'
		gs 'zz_funcs', 'cum','lip'
		facial += 1
		gs 'stat'
		gs 'zz_render', '', 'images/city/south/lake/fisherman/cum_money'+rand(1,3)+'.jpg','Парень начал кончать вам на лицо и губы. Струи его спермы залетали вам в рот, дав вам почувствовать вкус спермы.**///- Ты грязная шлюха,/// - приговаривал он. -\\\ Любишь деньги, тогда придется привыкать к подобному...///'
		act 'Смотреть на парня':
			*clr & cla
			minut += 5
			$ribakName = 'шлюха'
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/fisherman/end_money.jpg','Вы устало посмотрели на парня. Он взял ваши волосы в ладонь, и вытер ими свой член, грубо сказал :**\\\- Все шлюха, теперь можешь проваливать...///'
			act 'Уйти':gt'lake'
		end
	end
end
if $ARGS[0] = 'fisherman_oral':
	*clr & cla
	minut += 5
	ribakSex += 1
	if ribakSex = 0: guy += 1
	bj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/lake/fisherman/oral'+rand(1,3)+'.jpg','Он буквально силой нагнул вас к своему паху и нетерпеливо шлепнул вас залупой по носу.**\\\- Чего сиськи мнешь? Начинай сосать!,/// - услышали вы и тут же приступили к делу.'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render', '', '','Но долго так продолжаться не могло.**\\\- Открой свой блядский рот,/// - рыкнул на вас парень. -\\\ И высунь свой язык!///'
	act 'Открыть рот и высунуть язык':
		*clr & cla
		minut += 1
		dom -= 1
		gs 'zz_funcs', 'cum','face'
		gs 'zz_funcs', 'cum','lip'
		facial += 1
		gs 'stat'
		gs 'zz_render', '', 'images/city/south/lake/fisherman/cum'+rand(1,3)+'.jpg','Вы послушно открыли рот и выставили язык. Тут же вам по лицу хлестнула струя спермы. Затем еще одна и еще, покрывая ваше лицо спермой, попадая в ваш открытый рот, и заставляя ощущать её вкус.**\\\- А теперь десерт,/// - усмехнулся парень, когда поток спермы иссяк.'
		act 'Смотреть на парня':
			*clr & cla
			minut += 5
			$ribakName = 'блядь'
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/fisherman/end1.jpg','По вашему лицу стекает сперма, вы ощущаете неприятный вкус во рту, и смотрите на парня. Парень усмехнувшись, выдавил из члена последние капли, и вытерев его об ваше лицо, сказал:**\\\- Проваливай отсюда тварь!///'
			act 'Уйти': gt'lake'
		end
	end
	if shameless['flag'] < 2 and dom > -10:
		act 'Постараться убрать лицо':
			*clr & cla
			minut += 5
			gs 'zz_funcs', 'cum', 'face'
			$ribakName = 'блядинка'
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/lake/fisherman/cum4.jpg','Вы постарались увернуться, но парень схватил вас за волосы и струи спермы стали попадать вам на лицо. Наконец парень иссяк и сказал:**\\\- Проваливай отсюда, блядина!///'
			act 'Уйти': gt'lake'
		end
	end
end
if $ARGS[0] = 'lake_3boys':
	*clr & cla
	gs 'stat'
	if vnesh < 40:
		gs 'zz_render', '', 'images/city/south/lake/lake_3boys/lake_3boys.jpg','Загорая на пляже вы обратили внимание на компанию из трёх симпатичных парней, расположившуюся неподалёку. Они что-то весело обсуждали, не обращая на вас никакого внимания. Поболтав еще какое-то время, они собрали свои вещи, оделись и ушли с пляжа.'
		act 'Далее': gt'lake'
	else
		gs 'zz_render', '', 'images/city/south/lake/lake_3boys/lake_3boys.jpg','Загорая на пляже вы обратили внимание на компанию из трёх симпатичных парней, расположившуюся неподалёку. Заметив ваш взгляд, один из парней, то-то шепнул остальным, и они всей компанией направились в вашу сторону.'
		act 'Далее':
			*clr & cla
			gs 'zz_render', '', 'images/city/south/lake/lake_3boys/lake_boys_flirt.jpg','Подойдя к вам, парни присели рядом, и принялись наперебой развлекать вас, рассказывая анекдоты, и просто смешные истории из жизни. Флиртуя с вами, они старались, как бы украдкой, дотронуться до вашего тела, лаская его, и постепенно возбуждая вас...'
			if horny < 70 or shameless['flag'] < 2: act 'Отшить': gt'lake'
			if (shameless['flag'] > 0 and horny >= 70) or shameless['flag'] > 1:
				act 'Расслабиться':
					*clr & cla
					guy += 3
					dynamic $venerasiak
					gs 'zz_render', '', 'images/city/south/lake/lake_3boys/start.jpg','Видя, что вы не против, парни берут вас за руки, и ведут в сторонку, чтобы никто из отдыхающих не мог вам помешать. Вы опустились перед ними на колени и тут же столкнулись с их выставленными членами, уже находящимися в боевой готовности..'
					act 'Cосать':
						*clr & cla
						bj += 3
						gang += 1
						gs 'zz_render', '', 'images/city/south/lake/lake_3boys/oral'+rand(1,2)+'.jpg','Вы принялись поочередно сосать члены парней, сидя перед ними на корточках, стараясь доставить им максимальное наслаждения, и показать своё оральное мастерство. Но парням видимо этого мало, они уже готовы приступить к основному блюду...'
						act 'Сосать дальше': gt'lake_event','lake_3boys_cum'
						act 'Раздвинуть ноги': gt'lake_event','lake_3boys_vag'
						act 'Дать в попу': gt'lake_event','lake_3boys_anal'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'lake_3boys_vag':
	*clr & cla
	lake_sex += 1
	$boy = 'Парень'
	dick = rand(12,20)
	silavag = rand(0,2)
	gs 'zz_render', '', 'images/city/south/lake/lake_3boys/vag'+rand(1,2)+'.jpg','Парни уложили вас на бок и один из них тут же начал пристраиваться к вашей  киске.'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_render', '', '','Одновременно с этим вы не забывали и про двух других парней, отсасывая у них по очереди, то у одного, то у другого...'
	if lake_sex < 3:
		act 'Продолжать': gt'lake_event','lake_3boys_vag'
		act 'Дать в попу': gt'lake_event','lake_3boys_anal'
		act 'Давайте вдвоём':gt'lake_event','lake_3boys_dp'
	else
		act 'Встать на колени':gt'lake_event','lake_3boys_cum'
	end
end
if $ARGS[0] = 'lake_3boys_anal':
	*clr & cla
	lake_sex += 1
	$boy = 'Парень'
	dick = rand(12,20)
	silavag = rand(0,2)
	gs 'zz_render', '', 'images/city/south/lake/lake_3boys/anal'+rand(1,2)+'.jpg','Один из парней лёг на песок и вы тут же начали пристраиваться своей  попкой к члену.'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	gs 'zz_render', '', '','Двое других парней, оценив позу, поднесли к вашему лицу свои члены, и вы принялись отсасывать у них по очереди, не забывая скакать покой на члене первого...'
	if lake_sex < 3:
		act 'Продолжать': gt'lake_event','lake_3boys_anal'
		act 'Раздвинуть ноги': gt'lake_event','lake_3boys_vag'
		act 'Давайте вдвоём':gt'lake_event','lake_3boys_dp','anal'
	else
		act 'Продолжать':gt'lake_event','lake_3boys_cum','anal'
	end
end
if $ARGS[0] = 'lake_3boys_dp':
	*clr & cla
	lake_sex += 2
	$boy = 'первый парень'
	dick = rand(12,20)
	silavag = 0
	temp = rand(1,2)
	$boy2 = 'второй парень'
	dick2 = rand(12,20)
	gs 'zz_render', '', 'images/city/south/lake/lake_3boys/dp'+rand(1,4)+'.jpg','- Давайте вдвоём, - предложили вы.**Один из парней тут же лёг на песок и вы тут же начали прицеливаться своей киской к его члену, одновременно чувствуя, как второй член пристраивается к вашей попке.'
	gs 'zz_dynamic_sex', 'dp_start'
	gs 'zz_dynamic_sex', 'double_penetration'
	gs 'zz_render', '', '','Оставшийся парень тут же воспользовался вашим последним, не занятым отверстием...'
	dick = rand(12,20)
	gs 'zz_dynamic_sex', 'bj'
	act 'Встать на колени':gt'lake_event','lake_3boys_cum'
end
if $ARGS[0] = 'lake_3boys_cum':
	*clr & cla
	lake_sex = 0
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'belly'
	if $args[1] = 'anal':
		gs 'zz_funcs', 'cum', 'anus'
		gs 'zz_render', '', 'images/city/south/lake/lake_3boys/cum1.jpg','Внезапно парень снизу запыхтел, его член дёрнулся еще пару раз, и вы почувствовали как вашу попу наполняет тепло. Через какие-то мгновения стали кончать и два оставшихся парня, заливая ваше лицо и грудь спермой, оставляя её терпкий вкус во рту... После, вы все вместе валялись на песке, отдыхая и лениво перешучиваясь. Наконец парни глянув на часы начали собираться домой...'
	else
		gs 'zz_render', '', 'images/city/south/lake/lake_3boys/cum2.jpg','Предвидя скорый финал, вы принялись с удвоенной энергией отсасывать парням, стоя перед ними на коленях. Ваши труды были вскоре вознаграждены и первая струя спермы ударила вам в рот. Потом была, и вторая, и третья - парни долго кончали, изливаясь в ваш открытый ротик, попадая на лицо и тело. После, вы все вместе валялись на песке, отдыхая и лениво перешучиваясь. Наконец парни глянув на часы начали собираться домой...'
	end
	act 'Уйти':gt'lake'
end
if $ARGS[0] = 'vlake2':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/Vlake2/vlake1.jpg'
	gs 'zz_render','','','Загорая вы заметили двух обнаженных мужчин идущих по берегу со стороны нудистского пляжа.'
	act 'Не обращать внимания':gt'lake'
	act 'Помахать им':
		*clr & cla
		gs 'zz_render','','images/img/Lake/Vlake2/vlake2.jpg'
		gs 'zz_render','','','Мужчины подходят к вам, один из них резко опускается перед вами на колено и впивается своими губами в ваши, второй гладит рукой ваши трусики.'
		act 'Оттолкнуть их и убежать':gt'lake'
		act 'Встать на колени':
			*clr & cla
			guy += 2
			bj += 1
			dom -= 1
			dynamic $venerasiak
			gs 'zz_render','','images/img/Lake/Vlake2/vlake3.jpg'
			gs 'zz_render','','','Вы поднимаетесь на колени, берете в руки их фаллосы и принимаетесь поочередно отсасывать оба.'
			act 'Продолжить':
				*clr & cla
				sex += 1
				gs 'zz_funcs','set_gape','vagina',horny,15,1
				gs 'zz_render','','images/img/Lake/Vlake2/vlake4.jpg'
				gs 'zz_render','','','Один из мужчин лег и вы продолжили ему сосать подняв свою попку вверх, второй сразу воспользовался открывшимся видом и вставил свой член в вашу влажную киску.'
				act 'Войдите в меня оба':
					*clr & cla
					anal += 1
					gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),15,1
					gs 'zz_render','','images/img/Lake/Vlake2/vlake5.jpg'
					gs 'zz_render','','','"Войдите в меня оба" простонали вы и оседлали одного из мужчин, второй не остался глух к вашей просьбе и засунул свой хрен в ваш анус.'
					act 'Сменить позу':
						*clr & cla
						gs 'zz_funcs', 'cum', 'ass'
						gs 'zz_render','','images/img/Lake/Vlake2/vlake6.jpg'
						gs 'zz_render','','','Вы насадили свой анус на лежащего мужчину. Второй подошел к вам и держа одной рукой вашу голову начал трахать ваш ротик, проникая своим фаллосом все глубже и глубже. Через некоторое время вы почувствовали как горячая сперма заполняет ваш анус и кончили вмести с ним, второй мужчина приготовился кончить вам в рот.'
						act 'Продолжить сосать':gt'lake','vlake2cum'
						act 'Вынуть':
							*clr & cla
							gs 'zz_funcs', 'cum', 'face'
							gs 'zz_render','','images/img/Lake/Vlake2/vlake7.jpg'
							gs 'zz_render','','','Вы вынули член изо рта и мужчина кончил вам на лицо.'
							act 'Уйти':gt'lake'
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'vlake2cum':
	*clr & cla
	gs 'stat'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_render','','images/img/Lake/Vlake2/vlake8.jpg'
	gs 'zz_render','','','Вы продолжили сосать и вскоре ваш рот заполнил поток спермы, проглотив её вы тщательно облизали его член, ни оставляя ни капли спермы.'
	act 'Уйти':gt'lake'
end
if $ARGS[0] = 'andrey1':
	*clr & cla
	gs 'stat'
	minut += 30
	gs 'zz_render','','','Вы подошли к Андрею, он усмехнулся, и сказал: "Пойдем купаться!"'
	act 'Отказаться':gt'lake'
	act 'Купаться':
		cla
		andreiday = day
		anreirape = 0
		gs 'zz_render','','images/img/Lake/Andrey1/andrey1.jpg'
		gs 'zz_render','','','- Вижу, дама согласна, - хищно оскалился Андрей. – Тогда пойдем купаться. Он подхватил вас на руки, засмеявшись вашим неуместным попыткам прикрыть от него свою грудь, отбросил вашу руку и губами мягко ущипнул за правый сосок. У вас вырвался вздох, а внизу живота начала подниматься теплая волна возбуждения.'
		gs 'zz_render','','','Вы немного поплавали, отдыхая и расслабляясь. И вот, вас уже несут обратно на покрывало, поглаживая в расслабляющем ритме ваше тело. Сначала ты должна возбудить мужчину, - произнес он, пододвинув свой член к вашему рту и немного потершись головкой о ваши губы.'
		act 'Разомкнуть губы':
			*clr & cla
			bj += 1
			sex += 1
			gs 'zz_funcs','set_gape','vagina',horny,15,1
			gs 'zz_render','','images/img/Lake/Andrey1/andrey2.jpg'
			gs 'zz_render','','','Вы разомкнули губы и провели языком вдоль его ствола, затем втянули его в себя насколько могли. Андрей начал с упоением трахать вас в ротик. Внезапно до вашего слуха донесся какой-то всхлип от ближайших кустов. Вы подняли глаза и увидели, как из кустов за вами подсматривает юноша, дергает вверх-вниз рукой в области паха.'
			gs 'zz_render','','','Андрей тоже понял, что за ними подглядывают, и повернул вашу голову так, чтобы наблюдателю были видны все детали того, как красная головка появляется и исчезает в вашем ротике. Вы демонстративно вылизывали член мужчины, то ускоряя, то замедляя темп, проводя своим язычком по уздечке и периодически вбирая в рот его яички. Откуда в вас родились эти инстинкты, вы не знали, но по реакции Андрея понимали, что вы все делаете правильно.'
			gs 'zz_render','','','Наконец, Андрей отстранил вас от себя, опрокинул вас на спину и одним рывком глубоко вошел в ваше лоно. Вы сжалась от боли, но Андрей, не останавливаясь, начал двигаться внутри вас. Через пару минут монотонных движений вас окутала сладкая нега, а когда Андрей пальцами стал стимулировать ваш анус, проникая сразу в оба отверстия, вас унесло на волнах невероятного наслаждения. Сквозь прищуренные веки, вы наблюдали за тем, как подсматривающий юноша, затаив дыхание, завороженный, словно в трансе, жадно ловил каждое движение.'
			act 'Позвать юношу':
				*clr & cla
				guy += 1
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'ass'
				anal += 1
				gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),15,1
				gs 'zz_render','','images/img/Lake/Andrey1/andrey3.jpg','Юноша стесняясь подошел к вам. "Ну и чего ждешь, трусы спускай, пока девушка не против" бросил ему Андрей, переворачивая вас на себя и раздвигая руками ваши ягодицы. Юноша подошел сзади и вставил свой член вам в анус. Теперь два члена двигались в вас как поршни доставляя немыслимое удовольствие. Постанывая вы скакали на двух членах, пока юноша не кончил вам на попку, а Андрей поднялся и разрядился вам в рот.'
				act 'Встать с пляжа':gt'lake'
			end
			act 'Глубже! Сильней!':
				*clr & cla
				gs 'zz_render','','images/img/Lake/Andrey1/andrey4.jpg','- Глубже, сильнее! – выкрикивали вы, не стесняясь, с упоением вбирая в себя всего мужчину. Он отвечал вам невнятным рычанием, вырывающимся из него в такт их рваному дыханию. Еще до того, как вы оба кончили, юноша убежал.'
				gs 'zz_funcs', 'cum', 'pussy'
				act 'Встать с пляжа':gt'lake'
			end
		end
	end
end
if $ARGS[0] = 'kater1':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/kater1/kater1.jpg'
	gs 'zz_render','','','Катаясь на гидроцикле вы делаете слишком крутой разворот, вас выбрасывает в воду, вы наглотались воды и начинаете тонуть. На ваше счастье вас замечает парень на катере он вытаскивает вас из воды, а гидроцикл привязывает к катеру. Через некоторое время когда вы отдышались и удобно устроились на носу катера, парень подходит к вам'
	gs 'zz_render','','','"Ну как дела красавица, очухалась, как на счет благодарности?" спрашивает он, одновременно ложа руку вам на лобок.'
	act 'Сесть на гидроцикл и уехать':gt'Lake'
	act 'Раздвинуть ноги':
		*clr & cla
		guy += 1
		kuni += 1
		dynamic $venerasiak
		gs 'zz_render','','images/img/Lake/kater1/kater2.jpg'
		gs 'zz_render','','','Вы раздвигаете ноги, давая понять что готовы отблагодарить спасителя, парень улыбнулся, ввел свои пальцы в вашу вагину, а языком стал ласкать ваш клитор.'
		act 'Сделать минет':
			*clr & cla
			bj += 1
			gs 'zz_render','','images/img/Lake/kater1/kater3.jpg'
			gs 'zz_render','','','Вы усаживаете парня облизываете фаллос, обхватываете его губами и начинаете самоотверженно сосать, через пару минут вы чувствуете как член в вашем рту начинает содрогаться готовый кончить.'
			act 'Продолжать сосать':gt'lake_event','kater1cum'
			act 'Остановиться':
				*clr & cla
				sex += 1
				gs 'zz_funcs','set_gape','vagina',horny,15,1
				gs 'zz_render','','images/img/Lake/kater1/kater4.jpg'
				gs 'zz_render','','','Вы останавливаетесь, парень ставит вас раком и буравит вашу вагину своим членом.'
				act 'Сменить позу':
					*clr & cla
					gs 'zz_render','','images/img/Lake/kater1/kater5.jpg'
					gs 'zz_render','','','Когда он устает, вы укладываете его, а сами запрыгиваете на него сверху и начинаете скакать как на необъезженном жеребце.'
					act 'Сменить позу':
						*clr & cla
						orgasm += 1
						gs 'zz_render','','images/img/Lake/kater1/kater6.jpg'
						gs 'zz_render','','','Вы разворачиваетесь на нем не выпуская из себя фаллос, и продолжаете нещадно насаживать свою киску на его фаллос и вот уже из вас вырывается стон наслаждения. Обессилившая выпадаете рядом с ним.'
						act 'Продолжить':
							*clr & cla
							gs 'zz_render','','images/img/Lake/kater1/kater7.jpg'
							gs 'zz_render','','','Парень поворачивает вас на бок и вновь входит в вашу киску, продолжая буравить её своим фаллосом.'
							act 'Сменить позу':
								*clr & cla
								gs 'zz_render','','images/img/Lake/kater1/kater8.jpg'
								gs 'zz_render','','','Затем он поднимает вас на ноги, задирает одну и с силой вставляет свой член в вашу вагину, вы удовлетворенная и уставшая повисаете на нем ожидая когда он кончит. Через несколько толчков он выдергивает свой член и отпускает вас, вы падаете на колени, а парень вставляет вам в рот.'
								act 'Сосать':gt'lake_event','kater1cum'
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'kater1cum':
	*clr & cla
	gs 'stat'
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'belly'
	gs 'zz_render','','images/img/Lake/kater1/kater9.jpg'
	gs 'zz_render','','','Поток спермы хлынувший в ваш рот оказался на столько велик что вы не успевали проглатывать и ваш рот оказался заполнен до краев, сперма лилась как из рога изобилия выливалась из вашего рта, растекалась по подбородку и заливала вашу грудь и живот.'
	act 'Слизать остатки':
		cla
		*clr
		gs 'zz_render','','images/img/Lake/kater1/kater10.jpg'
		gs 'zz_render','','','Когда поток иссяк, вы как обезумевшая вся залитая спермой принялись слизывать остатки с его члена, смакуя каждую каплю.'
		act 'Уйти':gt'lake'
	end
end
if $ARGS[0] = 'kater2':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/kater2/kater1.jpg'
	gs 'zz_render','','','Катаясь на банане вы не удержались, вас выбрасывает в воду, вы наглотались воды и начинаете тонуть. На ваше счастье вас замечают двое парней на катере они вытаскивает вас из воды. Через некоторое время вы отдышались, отдохнули и начали осматриваться. Вы увидели что на носу стоят оба ваших спасителя абсолютно голые.'
	act 'Притворяться спящей пока не пришвартовались':gt'lake'
	act 'Подойти к ним':
		*clr & cla
		guy += 2
		sex += 1
		gs 'zz_funcs','set_gape','vagina',horny,15,1
		dynamic $venerasiak
		gs 'zz_render','','images/img/Lake/kater2/kater2.jpg'
		gs 'zz_render','','','Вы снимаете купальник, подходите к парням и не говоря не слова, запрыгиваете на одного из парней и страстно его целуете, через секунду вы ощущаете как его вставший член упирается в ваши ягодицы, вы берете его в руку и направляете в свою киску.'
		act 'Сменить позу':
			*clr & cla
			anal += 1
			gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),15,1
			gs 'zz_render','','images/img/Lake/kater2/kater3.jpg'
			gs 'zz_render','','','Парень снимает вас со своего члена, поворачивает спиной к себе, хватает за ягодицы и поднимает, ваши ноги запрокидываются вверх, а парень прижав вас к себе натягивает ваш анус на свой фаллос. Вы стоните, то ли от боли причиняемой огромным фаллосом в вашей попе, то ли от наслаждения которое он вам доставляет, с каждым толчком вы пытаетесь принять его член как можно глубже в себя.'
			gs 'zz_render','','','"Хочешь глубже?" спрашивает он'
			act 'Да, глубже, сильнее!':
				*clr & cla
				bj += 1
				gs 'zz_render','','images/img/Lake/kater2/kater4.jpg'
				gs 'zz_render','','','"Да, глубже, сильнее!" кричите вы.'
				gs 'zz_render','','','"Ну тогда держись" говорит парень, ставя вас на четвереньки. Он входит в вас и засовывает свой член так глубоко в вашу задницу что его яица хлопают по вашим ягодицам. Второй парень который все это время смотрел на вас, подходит к тыкает хуем вам в лицо. Вы хватаете его член губами и начинаете сосать.'
				act 'Войдите оба':
					*clr & cla
					orgasm += 1
					gs 'zz_render','','images/img/Lake/kater2/kater5.jpg'
					gs 'zz_render','','','"Трахните меня в две дырки" кричите вы, сами поражаясь своей похоти, парни не стали раздумывать и вошли оба, засунули свои члены так глубоко на сколько смогли. Вскоре вы как будто провалились, перед глазами поплыли круги все, тело трепетало, вам хотелось что-бы этот оргазм никогда не кончался'
					act 'Далее':
						*clr & cla
						gs 'zz_render','','images/img/Lake/kater2/kater6.jpg'
						gs 'zz_render','','','Поняв что вы удовлетворены парни посадили вас на палубу, встали рядом и начали мастурбировать.'
						act 'Повернуться к одному':
							*clr & cla
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_render','','images/img/Lake/kater2/kater7.jpg'
							gs 'zz_render','','','Когда один из парней застонал, вы повернулись к нему открыв рот. И он выпрыснул свое семя вам в рот, вы с удовольствием его проглотили.'
							act 'Повернуться ко второму':
								*clr & cla
								gs 'zz_funcs', 'cum', 'face'
								gs 'zz_render','','images/img/Lake/kater2/kater8.jpg'
								gs 'zz_render','','','Вскоре застонал и второй, вы повернулись к нему, но как только вы открыли рот, парень разрядился вам на лицо.'
								act 'Уйти':gt'lake'
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'kater3':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/kater3/1.jpg'
	gs 'zz_render','','','Катаясь на гидроцикле вы делаете слишком крутой разворот, вас выбрасывает в воду, вы наглотались воды и начинаете тонуть. На ваше счастье вас замечает парень на катере он вытаскивает вас из воды, а гидроцикл привязывает к катеру. Через некоторое время когда вы отдышались и удобно устроились на носу катера, парень подходит к вам.'
	gs 'zz_render','','','"Ну как дела красавица, очухалась, как на счет благодарности?" спрашивает он, одновременно засовывая руку вам в трусы.'
	act 'Сесть на гидроцикл и уехать':gt'lake'
	act 'Раздвинуть ноги':
		*clr & cla
		guy += 2
		kuni += 1
		dynamic $venerasiak
		gs 'zz_render','','images/img/Lake/kater3/2.jpg'
		gs 'zz_render','','','Вы снимаете трусики и раздвигаете ноги, парень опускает свою голову к вашим ногам и лаская их языком постепенно добирается до вашего клитора.'
		act 'Сделать минет':
			*clr & cla
			bj += 1
			sex += 1
			gs 'zz_funcs','set_gape','vagina',horny,15,1
			gs 'zz_render','','images/img/Lake/kater3/4.jpg'
			gs 'zz_render','','','Вы усаживаете парня облизываете фаллос, обхватываете его губами и начинаете самоотверженно сосать, пока вы сосете из глубин катера появляется второй. Увидев такую картину он подходит к вам и вставляет свой член в вашу киску.'
			act 'Дальше':
				*clr & cla
				anal += 1
				gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),15,1
				gs 'zz_render','','images/img/Lake/kater3/6.jpg'
				gs 'zz_render','','','Вы садитесь на одного из них сверху, а второй входит вам в зад.'
				act 'Сменить позу':
					*clr & cla
					orgasm += 1
					gs 'zz_render','','images/img/Lake/kater3/8.jpg'
					gs 'zz_render','','','Парни разворачивают вас и снова входят вдвоем.'
					act 'Сменить позу':
						*clr & cla
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_render','','images/img/Lake/kater3/11.jpg'
						gs 'zz_render','','','Насытившись они поочередно кончают вам в рот.'
						act 'Уйти':gt'lake'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'horse1':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/horse1/horse1.jpg'
	gs 'zz_render','','','Катаясь по берегу вы заметили двух мужчин на квадроциклах, они подъехали к вам и предложили прогуляться вместе.'
	act 'Отказаться':gt'lake'
	act 'Пойти с ними':
		*clr & cla
		gs 'zz_render','','images/img/Lake/horse1/horse2.jpg'
		gs 'zz_render','','','Вы спускаетесь с лошади и идете вместе с мужчинами болтая о всякой ерунде.'
		act 'Идти дальше':
			*clr & cla
			gs 'zz_render','','images/img/Lake/horse1/horse3.jpg'
			gs 'zz_render','','','Внезапно один из мужчин поворачивает вас к себе и начинает лапать грудь, в это время второй обнимает вас сзади, запуская руку в ваши трусики.'
			act 'Оттолкнуть их и убежать':gt'lake'
			act 'Достать их члены':
				*clr & cla
				guy += 2
				bj += 1
				dynamic $venerasiak
				gs 'zz_render','','images/img/Lake/horse1/horse4.jpg'
				gs 'zz_render','','','Вы вынули их члены из штанов, опустились на корточки и начали жадно сосать.'
				act 'Трахните меня':
					*clr & cla
					sex += 1
					gs 'zz_funcs','set_gape','vagina',horny,15,1
					gs 'zz_render','','images/img/Lake/horse1/horse5.jpg'
					gs 'zz_render','','','"Трахните меня" выкрикнули вы. Один из мужчин лег и вы продолжили ему сосать, второй подошел сзади и вставил в вашу изнывающую от желания киску'
					act 'Сменить позу':
						*clr & cla
						gs 'zz_render','','images/img/Lake/horse1/horse6.jpg'
						gs 'zz_render','','','Вы оседлали одного из мужчин скача на нем как скакали на лошади все несколько минут назад. Второй подошел к вам и принялся дразнить вас своим членом, то опуская его к вам, что-бы вы могли его пососать то поднимая вверх вынуждая вас тянутся к нему пытаясь ухватить его губами.'
						act 'Сменить позу':
							*clr & cla
							orgasm += 1
							gs 'zz_render','','images/img/Lake/horse1/horse7.jpg'
							gs 'zz_render','','','Вы спрыгнули с члена и встали на четвереньки, мужчины обступили вас с разных сторон один трахал вашу вагину, второй засунул в рот. Вы принялись яростно сосать одновременно подмахивая бедрами, вскоре вы ощутили что член у вас во рту вот вот взорвется.'
							act 'Вынуть изо рта':
								*clr & cla
								gs 'zz_funcs', 'cum', 'lip'
								gs 'zz_render','','images/img/Lake/horse1/horse8.jpg'
								gs 'zz_render','','','Вы вынули член изо рта и начали дрочить высунув язык, через секунду ваши старания были вознаграждены потоком смермы на высунутый язычок'
								act 'Сосать у второго':
									*clr & cla
									gs 'zz_render','','images/img/Lake/horse1/horse9.jpg'
									gs 'zz_render','','','Вы встали на колени перед вторым мужчиной, провели языком от яиц до головки и взяли в рот, когда вы с наслаждением посасывали член, мужчина задрожал. "Сейчас кончит" пронеслось у вас в голове'
									act 'Продолжить сосать':gt'lake','horse1bj'
									act 'Вынуть':
										*clr & cla
										gs 'zz_funcs', 'cum', 'face'
										gs 'zz_render','','images/img/Lake/horse1/horse10.jpg'
										gs 'zz_render','','','Вы вынули член изо рта и мужчина кончил вам на лицо со словами "Вот тебе крем для лица малышка", вы удовольствием слизали остатки спермы с его члена.'
										act 'Уйти':gt'lake'
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'horse1bj':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/horse1/horse11.jpg'
	gs 'zz_render','','','И вот поток спермы хлынул в ваш рот, вы глотали ее урча от удовольствия, слизывали остатки с его члена и снова глотали'
	act 'Уйти':gt'lake'
end
if $ARGS[0] = 'horse2':
	*clr & cla
	gs 'stat'
	gs 'zz_render','','images/img/Lake/horse2/horse1.jpg'
	gs 'zz_render','','','Когда вы катались вас догнали двое мужчин на лошадях и предложили прогуляться вместе.'
	act 'Отказаться':gt'lake'
	act 'Пойти с ними':
		*clr & cla
		gs 'zz_render','','images/img/Lake/horse2/horse2.jpg'
		gs 'zz_render','','','Вы спустились с лошадей и пошли пешком по берегу болтая о всякой ерунде.'
		act 'Закончить прогулку':gt'lake'
		act 'Коснуться их штанов':
			*clr & cla
			bj += 1
			guy += 2
			dynamic $venerasiak
			gs 'zz_render','','images/img/Lake/horse2/horse3.jpg'
			gs 'zz_render','','','Вы касаетесь их штанов в паху, мужчины замирают переглядываясь, тогда вы опускаетесь на колени достаете их члены и начинаете ласкать своим языком плавно переходя к минету.'
			act 'Лечь на спину':
				*clr & cla
				anal += 1
				gs 'zz_funcs','set_gape','anus',iif(lubri>0,10,0),15,1
				gs 'zz_render','','images/img/Lake/horse2/horse4.jpg'
				gs 'zz_render','','','Отпустив их члены, вы легли на спину один из мужчин приподнял вас за ноги и вставил в зад, такого вы не ожидали и тихонько взвизгнули, второй расположился у вашей головы, пытаясь засунуть член в ваш рот.'
				act 'Взять в рот':
					*clr & cla
					gs 'zz_render','','images/img/Lake/horse2/horse5.jpg'
					gs 'zz_render','','','Вы схватили его член губами и жадно втянули в себя'
					act 'Сменить позу':
						*clr & cla
						sex += 1
						orgasm += 1
						gs 'zz_render','','images/img/Lake/horse2/horse6.jpg'
						gs 'zz_render','','','Вы сели на одного из мужчин верхом, второй подошел сзади засадив свой кол к вам в анус и сильными толчками трахал вашу попку, у вас потемнело в глазах от наслаждения, все тело задрожало и вас накрыло волной оргазма. Вскоре вы почувствовали как мужчины начали постанывать и сейчас взорвутся.'
						act 'Сменить позу':
							*clr & cla
							gs 'zz_render','','images/img/Lake/horse2/horse7.jpg'
							gs 'zz_render','','','Вы спрыгнули с членов и встали на колени, мужчины обступили вас с разных сторон, один кончил сразу же.'
							act 'Сосать у второго':
								*clr & cla
								gs 'zz_render','','images/img/Lake/horse2/horse8.jpg'
								gs 'zz_render','','','Вы повернулись ко второму, обхватили его член губами, но только вы втянули его член поглубже в себя как мужчина застонал его член напрягся готовый излить в ваш рот потоки спермы'
								act 'Вынуть изо рта':
									*clr & cla
									gs 'zz_funcs', 'cum', 'face'
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_render','','images/img/Lake/horse2/horse9.jpg'
									gs 'zz_render','','','Вынув член, вы широко открыли рот, приготовившись поймать струю спермы, мужчина не заставил вас ждать, сперма брызнула вам в рот, обволакивая ваш язык и горло.'
									act 'Уйти':gt'lake'
								end
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'andrey_start':
	*clr & cla
	anreirape = 1
	gs 'zz_render', '', 'images/common/beach/sunbathe_lake3','Вы задремали на пляже пока загорали. Вам снился что кто то ласкает вашу грудь. Ваши соски затвердели, грудь высоко поднималась от глубоких вздохов. Что-то мокрое очертило ореол на грудке, и вы сладко застонали.**Крепкая рука гладила складочки на вашем теле, от чего все тело охватывали мурашки, и вдруг палец проскользнул сквозь складочки половых губок и задел какую-то невообразимо приятную точку. Ваше тело бросило в жар, по спине пробежала сладкая дрожь, а внизу все увлажнилось. Уже чувствуя, что удовольствие наступает наяву, а не во сне, но еще не в силах преодолеть сонную негу и открыть глаза, вы раскинули ноги пошире, отдаваясь соблазнительным ласкам. Когда дерзкий палец, смоченный вашими соками, без труда проник в ваше лоно, вы даже успели удивиться, натуральности ощущений. Движения пальца ввели вас в некое подобие транса, вы уже стонали в полный голос, извиваясь всем телом под жаркими солнечными лучами. И вдруг, когда вам показалось, что вот-вот что-то должно было произойти, ощущение наполненности покинуло вас.'
	act 'Открыть глаза':
		*clr & cla
		gs 'zz_render', '', 'images/city/south/lake/andrei/andrei1.jpg','Открыв глаза, вы увидели неясную фигуру небритого мужчины, с вожделением глядящего на вас. Вам стало неловко - вы лежите перед незнакомцем голая, да еще вся стонущая и текущая, как последняя шлюшка. Одновременно пришел испуг - на пляже никого нет, он ведь может сделать с вами все, что пожелает!**Все эти мысли промелькнули в вашей голове, пока мужчина стягивал с себя шорты. Вы с ужасом смотрели на его обнажившийся член, до того огромным он вам показался.'
		act 'Вскочить':
			*clr & cla
			gs 'zz_render', '', 'images/city/south/lake/andrei/andrei1.jpg','Вы попытались вскочить но тут же были прижаты сильными руками к его волосатой груди.'
			act 'Врезать ему коленом по яйцам':
				*clr & cla
				andrei = 1
				gs 'zz_render', '', 'images/city/south/lake/andrei/andrei5','Вы очень точно ткнули его коленкой по яйцам, он заорал и отпустив вас упал.'
				act 'Уйти':gt'lake'
			end
			act 'Вырываться из объятий':
				*clr & cla
				andrei = 2
				andreiday = day
				guy += 1
				anal += 1
				$boy = 'Андрей'
				dick = 18
				silavag = 2
				gs 'zz_render', '', 'images/city/south/lake/andrei/andrei2.jpg','Вы стали вырываться из его объятий, но елозание привело к тому, что он еще больше возбудился и крепко прижал свой твердый член к вашему нагретому на солнце нежному бедру.**Незнакомец перевернул вас на живот и стал смачивать своей слюной ваш упругий анус.'
				gs 'zz_dynamic_sex', 'anal_start', 'dick'
				gs 'zz_dynamic_sex', 'anal', 'dick', 1
				if stat_agape > 1:
					gs 'zz_render', '', '','Никакого удовольствия вы не получали, только чуствовали острые приливы боли, отвращение к своему насильнику и чувство, будто вас используют, как шлюху.'
				else
					horny = 100
					gs 'zz_render', '', '','Тут, его пальцы небрежно дотронулись до вашего лона, и вас подхватила волна вожделения. Раз за разом вас пробивал словно бы насквозь огромный член вашего насильника, а вы подмахивали ему, и не могли сдержать сладких стонов.'
				end
				act 'Еще, еще, еще, еще...':
					*clr & cla
					gs 'zz_render', '', 'images/city/south/lake/andrei/andrei'+iif(horny = 100,3,4)+'.jpg','Еще, еще, еще, еще... бешено стучало в ваших висках одновременно с каждым толчком.Ваш клитор превратился в оголенный провод, казалось, еще миг – и вы взорветесь. Мужчина сменил позицию – теперь вы безвольно сидели у него на руках, а он подкидывал вас, продолжая насаживать на свой член.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
					gs 'zz_render','','','- Ну как, понравилось, Афродита? – с легкой иронией спросил мужчина.'
					act 'Да пошёл ты!':
						*clr & cla
						gs 'zz_render', '', 'images/city/south/lake/andrei/andrei.jpg','- Да пошёл ты!, - крикнули вы ему сквозь слёзы.**- Неужели так больно?- спросил он спокойным голосом. Вы округлили глаза от удивления, уставившись на него**- Больно?, - вы хотели закричать, но его спокойный тон, и взгляд посмеивающихся глаз, действовал на вас успокаивающе. - Да я теперь наделю на попе сидеть не смогу!**- Ну, извини, перестарался немного, - сказал парень улыбаясь. - Просто ты спящая так соблазнительно выглядела, что не смог сдержаться...**- А как вас зовут?? – вам собственный вопрос показался наиглупейшим, но слово, как говорится, не воробей...**- Андрей, - усмехнулся он. - А тебя как?**Света ответили вы.**- Надеюсь тебе понравилась наша игра, - вкрадчиво проговорил Андрей, одеваясь. - Хочешь поймать кайф? Приходи завтра, повторим наши подвиги...'
						act 'Далее':gt'lake'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'din_lake_adventure':
	i = rand(0,100)
	if i <= 30 and andrei = 0 and lake_people < 3 and vnesh >= 40:
		gt'lake_event','andrey_start'
	elseif i > 30 and i <= 35:
		gt'lake_event','vlake2'
	elseif i > 35 and i < 40:
		gt'lake_event','lake_3boys'
	end
end
if $ARGS[0] = 'din_nudelake_adventure':
	i = RAND(0,100)
	if lake_people > 2 and $npc['33,relation'] >= 60 and temper >= 20 and katkey = 0 and cloth[0] = 0 and katday ! day: gt'Katlake','key'
	if lake_people > 2 and $npc['33,know'] = 0 and cloth[0] = 0 and katday ! day: gt'Katlake'
	if i >= 80 and i < 95 and anutaQW < 2 and lake_people > 1 and anutaday ! day: gt'anuta_events','start'
	if i >= 80 and i < 95 and anutaQW = 2 and lake_people > 1 and anutaday ! day and anuta['horny'] >= 70: gt'anuta_events','alko'
end