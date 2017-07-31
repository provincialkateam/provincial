!подгружаем динамику которая в "gopsex"
gs'gopsex'
if $args[0] = 'meet_misha':
	if hour > func('zz_weather','sunrise') and hour < func('zz_weather','sunset') and cumface > 0 and rand(0,3) = 0 and sosedday ! day:
		*clr & cla
		sosedday = day
		gs 'zz_render', '', 'pavlovo/misha/misha.jpg',iif(sosedknow = 0,'Внезапно вас кто-то окликает:**\\\- <<$name[1]>>...///** Вы оборачиваетесь и видите соседа дядю Мишу. Он смотрит на ваше лицо с удивлением:**\\\- Это что у тебя на лице?///**Вы '+iif(shameless['flag'] < 2,'краснеете и смущаетесь',iif(shameless['flag'] = 2,'краснеете','улыбаетесь'))+', стараясь рукой стереть сперму с лица.**\\\- Ну ну, все понятно... -/// ухмыляется он и идет дальше, по своим делам.','Вы опять столкнулись нос к носу с дядей Мишей, вашим соседом. Он хмыкнул, посмотрев на вас:**\\\- Ну <<$name[2]>> ты и шлюха...///')
		sosedknow = 1
		act 'Далее': gt $loc, $metka
	end
end
!мини ивенты на в подъезде
if $args[0] = 'front_door_events':
	i = rand(0,100)
	!разные ивенты с подглядыванием
	$text[0] = '<font color = red>Вы слышите какие-то звуки, доносящиеся между этажами: <a href="exec: gt ''pavlovo_events'', ''front_door''">пойти посмотреть</a></font>'
	$text[1] = 'На лестничной клетке никого нет'
	if  args[1] = 1:
		!этаж 1
		if i <= 3:
			gs 'zz_render','','', $text[0]
		else
			gs 'zz_render','','', $text[1]
		end
	elseif args[1] = 2:
		!этаж 2
		if i <= 3:
			gs 'zz_render','','', $text[0]
		elseif i > 3 and i <= 10 and (week < 6 and hour >= 19 or week >=6 and hour >= 10):
			gt 'pavlovo_events', 'smoke_misha'
		elseif i >= 95:
			gt 'pavlovo_events', 'smoke_boys'
		else
			gs 'zz_render','','', $text[1]
		end
	elseif args[1] = 3:
		!этаж 3
		if i <= 3:
			gs 'zz_render','','', $text[0]
		elseif i > 3 and i <= 10 and (hour >= 15 and hour < 17 or week >= 6 and hour < 3 or week >=6 and hour >= 11 and hour < 14):
			gt 'pavlovo_events', 'smoke_shulga'
		elseif i >= 90 and hour >= 15:
			gt 'pavlovo_events', 'milova'
		else
			gs 'zz_render','','', $text[1]
		end
	elseif args[1] = 4:
		!этаж 4
		if i <= 3:
			gs 'zz_render','','', $text[0]
		elseif i > 3 and i <= 10 and (hour < func('zz_weather','sunrise') or hour > func('zz_weather','sunset')):
			gt 'pavlovo_events', 'aunt_luda'
		else
			gs 'zz_render','','', $text[1]
		end
	else
		!этаж 5
		gs 'zz_render','','', iif(i <= 5,'Вы услышали странные звуки на чердаке и вспомнили разговоры ребят. Которые говорили, что на чердаке частенько кого-то ебут: <a href="exec: gt ''pavlovo_events'', ''attic'' ">подняться и посмотреть</a>',$text[1])
	end
	killvar '$text'
end
!дядя Миша курит
if $args[0] = 'smoke_misha':
	*clr & cla
	gs 'zz_render', '', 'pavlovo/misha/misha.jpg', 'На лестничной клетке курит дядя Миша.**Он ваш сосед, живет с вами на одном этаже. Мама всегда запрещала вам с ним общаться, мол он какой-то бывший местный криминальный авторитет, но он всегда был с вам вежлив и доброжелателен.'
	if (GorSlut >= 3 or $npc['42,qwDyadyaMisha'] >= 1) and dmishaday ! day:
		i = rand(1,3)
		if i = 1 and GorSlut >= 3:
			gs 'zz_render', '', '', 'Увидев вас, он предложил:**\\\-<<$name>>, может ублажишь старика, отсосешь по быстрому? А я тебе 100 рублей дам!///'
			act 'Сосать':
				*clr & cla
				dmishaday = day
				money += 100
				minut += 5
				horny += 5
				bj += 1
				dick = 18
				$boy = 'Дядя Миша'
				silavag = 2
				misha_refuse = 0
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/events/bj_misha.gif', 'Вы сели на ступеньки и растегнув дяде Мише ширинку, достали его член.'
				gs 'zz_dynamic_sex', 'bj'
				gs 'zz_render', '', '','Вам хватило пять минут, что бы довести дядю Мишу до оргазма...'
				gs 'zz_dynamic_sex', 'swallow'
				act 'Уйти': gt'pod_ezd', 'etaj_2'
			end
			if dom => 0 and horny < 70 and misha_refuse <= 3:
				act 'Отказать':
					*clr & cla
					misha_refuse += 1
					gs 'zz_render', '', 'pavlovo/misha/misha.jpg', '\\-Извини, дядя Миша, //- ответили вы. \\- Сейчас не могу - времени нет, как-нибудь в другой раз.//**\\\-Ловлю тебя на слове!, -/// улыбнулся дядя Миша.'
					act 'Уйти': gt'pod_ezd', 'etaj_2'
				end
			end
		elseif i = 2:
			gs 'zz_render', '', '', 'Увидев вас, он предложил:**<do>-"<<$name>> может ублажишь старика, зайдёшь в гости? Я тебе уже пятихатку приготовил!"</do>'
			act 'Согласиться': gt'misha','1', 1
			act 'Отказаться':
				*clr & cla
				misha_refuse += 1
				gs 'zz_render', '', 'pavlovo/misha/misha.jpg', '\\-Извини, дядя Миша, //- ответили вы. \\- Сейчас никак не могу, давай я как-нибудь в другой раз забегу.//**\\\-Ловлю тебя на слове!, -/// улыбнулся дядя Миша.'
				act 'Уйти': gt'pod_ezd', 'etaj_2'
			end
		else
			act 'Поболтать':
				*clr & cla
				manna +=5
				gs'stat'
				gs 'zz_render', '', 'pavlovo/misha/misha.jpg', 'Побеседовав с вами минут пять, дядя Миша докурил сигарету, и сославшись на занятость удалился.'
				act 'Уйти': gt'pod_ezd', 'etaj_2'
			end
			act 'Пройти мимо': gt'pod_ezd', 'etaj_2'
		end
	else
		act 'Подойти':
			*clr & cla
			manna +=5
			gs'stat'
			gs 'zz_render', '', 'pavlovo/misha/misha.jpg', iif(cumface = 0,'Пока дядя Миша курил, вы беседовали о всякой ерунде. Докурив сигарету, он попрощался с вами, и удалился.',iif(sosedknow = 0,'Дядя Миша смотрит на ваше лицо с удивлением:**\\\- Это что у тебя на лице?///**Вы '+iif(shameless['flag'] < 2,'краснеете и смущаетесь',iif(shameless['flag'] = 2,'краснеете','улыбаетесь'))+', стараясь рукой стереть сперму с лица.**\\\- Ну ну, всё понятно... -/// ухмыляется он и затушив сигарету уходит.','Дядя Миша хмыкнул, посмотрев на вас:**\\\- Ну <<$name[2]>> ты и шлюха...///'))
			if cumface > 0 and sosedknow = 0: sosedknow = 1
			act 'Уйти': gt'pod_ezd', 'etaj_2'
		end
		act 'Пройти мимо': gt'pod_ezd', 'etaj_2'
	end
end
!пацаны курят
if $args[0] = 'smoke_boys':
	*clr & cla
	!сколько денег за секс дают пацаны
	money_rand = rand(100,700)
	manna += 10
	if energy < 20: energy += 3
	minut +=5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/home/events/smoke_boys'+iif(month > 3 and month < 11,'','_winter')+'.jpg', 'На площадке вы столкнулись с компанией курящих пацанов.'
	if GorSlut >= 3 and GorSlut < 6:
		gs 'zz_render', '', '', 'Проходя мимо вы услышали  их перешептывания:**\\\- Это же <<$name[2]>>, местная соска! Давай ее накормим, а если получиться, то и выебем!///**Вдруг один из них подошел к вам и, вынул из штанов член, сказал:**\\\- Это тебе, ты же знаешь что надо с этим делать, соска?///'
		if dom > 0:
			act 'Послать':
				*clr & cla
				minut +=2
				dom -= 1
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/events/screams.jpg', '\\- Пацаны вы чего вообще охуели тут? Мозги все прокурили?, -// возмутились вы. \\- <br><dh>Быстро съебались отсюда, а то закричу, весь дом сбежится посмотреть на вас оболтусов!//**Ребята решили не испытывать судьбу и быстро удалились, кинув на прощание:**\\\- Ничего, ещё встретимся!///'
				act 'Уйти': gt'pod_ezd', 'etaj_2'
			end
		end
		act 'Смириться': gt 'pavlovo_events', 'pod_sex_ev', rand(1,3)
	elseif GorSlut >=6:
		gs 'zz_render', '', '', 'Вы услышали перешептывания пацанов:**\\\- Смотри это же <<$gop_name_gg>>, дворовая <<$gg_whore_text>>! Давай узнаем ценник, говорят не много берёт, а ебать можно куда захочешь и как захочешь!///**Один из пацанов подошел к вам, вынул из кармана все деньги что у него были, включая мелочь, пересчитал и протягивая их вам спросил:**\\\- За <<money_rand>> рублей обслужишь двоих?///'
		act 'Обслужить':
			money += money_rand
			slutty += 1
			gt 'pavlovo_events', 'pod_sex_ev', rand(1,3)
		end
		if horny < 90: act 'Отказать': gt'pod_ezd', 'etaj_3'
	else
		act 'Уйти': gt'pod_ezd', 'etaj_2'
	end
end
!секс ивенты с пацанами в подъезде
if $args[0] = 'pod_sex_ev':
	if args[1] = 1:
		*clr & cla
		minut += 2
		dick = rand(12,20)
		$boy = 'пацан'
		silavag = 0
		if gorslut >= 6 and $npc['0,qwPodezdWhore'] < 3: $npc['0,qwPodezdWhore'] += 1
		gs 'stat'
		gs 'zz_render', '', 'images/pavlovo/home/sex_event1/'+rand(1,3)+'.jpg', 'Один из пацанов стоял и курил, а другой, который понаглее, подошел к вам и начал мацать вас за попку.**\\\- А теперь покажи '+iif(rand(0,1) = 0,'дойки','сиськи')+', -/// сказал он, набаловавшись.'
		act 'Далее':
			*clr & cla
			minut += 3
			horny += 5
			guy += 2
			i = rand(4,6)
			gs 'stat'
			gs 'zz_render', '', 'images/pavlovo/home/sex_event1/<<i>>.jpg', 'Вы бесперекословно повернулись к ним лицом и оголили свою грудь <<body[''tits'']>> размера.**\\\- Гляди-ка какая поддатливая нам попалась соска,/// - загоготал парень'+iif(i = 6,', грубо лапая её','')+'. \\\- Давай <<$gop_gg_name2>> поворачивайся ко мне своей '+iif(rand(0,1) = 0,'жопой','попкой')+', <<$gop_sextext1>> тебя буду!///'
			act 'Далее':
				*clr & cla
				minut += 5
				i = rand(7,12)
				post = 1
				gs 'stat'
				gs 'zz_render', '', 'images/pavlovo/home/sex_event1/<<i>>.jpg', 'Вы покорно повернулись к наглому пацану попкой и нагнулись.'+iif(analplugin = 1,'\\\- Дрон, глянь, да у этой бляди затычка в жопе! ///- удивленно восклицает парень.','')
				if i < 10:
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					if vagina >= dick*2: gs 'zz_render', '', '', '\\\- Да у этой шмары не пизда, а пещера какая-то, нихуя не чувствую! - пыхтя произносит парень.///'
				else
					dynamic  $analsex
					if anus >= dick*2: gs 'zz_render', '', '', '\\\- Да у этой шмары не жопа, а дупло какое-то, нихуя не чувствую! - пыхтя произносит парень.///'
				end
				act 'Далее':
					*clr & cla
					minut += 5
					silavag = 0
					dick = rand(12,20)
					$boy = 'пацан'
					gs 'stat'
					gs 'zz_render', '', 'images/pavlovo/home/sex_event1/13.jpg', '\\\- Эй, чё зеваешь, присоеденяйся, -/// говорит через некоторое время наглый приятелю, вгоняя в очередной раз свой член в вашу '+iif(i < 10,'<<$vaginatipe2>> вагину','<<$anustipe2>> попу')+'. Повторять второму парню дважды не пришлось, и вы тут же почувствовали как к вашим губам прикоснулся его член.'
					gs 'zz_dynamic_sex', 'bj'
					act 'Далее':
						*clr & cla
						minut += 5
						i = rand(14,17)
						gs 'stat'
						gs 'zz_render', '', 'images/pavlovo/home/sex_event1/<<i>>.jpg', '\\\-Что-то я подзаебался, занимай моё место, дружище, -/// слышите вы голос наглого сзади, и вы чуствуете как его член выходит из вас.**Второй парень вынул член из вашего рта и начал пристраиваться сзади.'
						if i < 16:
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
						else
							dynamic  $analsex
						end
						if shameless['flag'] < 3: gs 'zz_render', '', '', 'Хлопки яиц о вашу промежность раздаются на весь этаж и вы уже думаете как бы быстрее всё это закончить, чтобы никто из соседей, или случайных прохожих, не заметил весь этот разврат.'
						act 'Далее':
							*clr & cla
							minut += 3
							bj += 2
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'images/pavlovo/home/sex_event1/18.jpg', 'Вы предлагаете пацанам хорошенько отсосать и они соглашаются. Вы начинаете быстро и глубоко сосать по очереди их члены. То одному сосете, другому дрочите, то на оборот.'
							dynamic $accview_ggsex
							act 'Далее':
								*clr & cla
								minut +=3
								gs 'zz_funcs', 'cum', 'lip'
								gs 'zz_funcs', 'cum', 'face'
								swallow += 1
								cumfrot += 1
								gs'stat'
								gs 'zz_render', '', 'images/pavlovo/home/sex_event1/'+rand(19,20)+'.jpg', 'Вы всё делали как заправская шлюха со стажем. Пацаны быстро излили свою сперму вам в рот и на лицо, молча привели себя в порядок и, не обращая на вас никакого внимания, удалились.'
								act 'Уйти': gt'pod_ezd', 'etaj_2'
							end
						end
					end
				end
			end
		end
	elseif args[1] = 2:
		*clr & cla
		dick = rand(12,20)
		$boy = 'пацан'
		silavag = 0
		if gorslut >= 6 and $npc['0,qwPodezdWhore'] < 3: $npc['0,qwPodezdWhore'] +=1
		gs 'stat'
		gs 'zz_render', '', 'images/pavlovo/home/sex_event2/1.jpg', 'Один из пацанов стоял и курил, а другой, который понаглее, сказал властным голосом, чтобы вы раздевались.'
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'images/pavlovo/home/sex_event2/2.jpg', 'Пока вы раздевались, он щупал вас в разных местах:**\\\- Я же тебе говорил, что она <<$gop_gg_name2>> местная, смотри какая покорная...///'
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'images/pavlovo/home/sex_event2/3.jpg', '\\\- '+iif(vnesh < 20,'Страшная',iif(vnesh < 40,'Нормальная',iif(vnesh < 60,'Ничё такая','Заебись')))+' <<$gop_gg_name2>> нам попалась, - ///обсуждая с приятелем вашу внешность, пацан мацал вашу же грудь.'
				act 'Далее':
					*clr & cla
					minut += 5
					guy += 2
					bj += 2
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'images/pavlovo/home/sex_event2/'+rand(4,5)+'.jpg', '\\\- Смотри, ща она по приказу сосать нам будет!///**Пацан делает небольшую паузу и приказывает вам:**\\\ - Давай, <<$gop_gg_name2>>, к ноге! Сосать!///**Вы покорно сели на корточки и поднесли член к своим губам.'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_render', '', '', 'Тут же подошел его приятель и вытащил свой хуй. Вы, взяв его в руку, начали дрочить, одновременно отсасывая первому пацану.'
					act 'Далее':
						*clr & cla
						minut += 5
						pose = 1
						gs 'stat'
						gs 'zz_render', '', 'images/pavlovo/home/sex_event2/'+rand(6,8)+'.jpg', '\\\- Всё, заебала мусолить, готовь станок, <<$gop_sextext1>> буду///**Вы разворачиваетесь к нему задом и нагибаетесь.'
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						act 'Далее':
							*clr & cla
							minut += 5
							horny += 5
							silavag = 0
							dick = rand(12,20)
							$boy = 'пацан'
							gs 'stat'
							gs 'zz_render', '', 'images/pavlovo/home/sex_event2/'+rand(9,10)+'.jpg', '\\\- А ты чего там встал? -/// спрашивает наглый у приятеля. \\\- Не теряйся, дай ей на клык - пусть сосёт!///'
							gs 'zz_dynamic_sex', 'bj'
							gs 'zz_render', '', '','Вы покорно обслуживали двух незнакомых ребят, один размеренно таранил вашу киску, другому вы сосали.**Минут через пять вы сказали ребятам, что устали и вам так не удобно.**\\\- Блядям не должно быть удобно! -/// услышали вы смешок сзади.'
							act 'Далее':
								*clr & cla
								minut += 5
								horny +=5
								i = rand(11,12)
								gs 'stat'
								gs 'zz_render', '', 'images/pavlovo/home/sex_event2/<<i>>.jpg', 'Но всё таки ваша просьба исполнилась. Второй пацан, занял место первого  и облокотил вас на перила.'
								if i = 11:
									gs 'zz_dynamic_sex', 'sex_start'
									gs 'zz_dynamic_sex', 'vaginal', 'dick'
								else
									dynamic  $analsex
								end
								dynamic $accview_ggsex
								act 'Далее':
									*clr & cla
									minut += 5
									gs 'zz_funcs', 'cum', 'face'
									gs 'zz_funcs', 'cum', 'lip'
									cumfrot += 1
									gs 'stat'
									gs 'zz_render', '', 'images/pavlovo/home/sex_event2/'+rand(13,15)+'.jpg', 'Наконец пацаны, удовлетворившись вашим телом, обкончали все ваше личико и отпустили с миром.'
									act 'Уйти': gt'pod_ezd', 'etaj_2'
								end
							end
						end
					end
				end
			end
		end
	else
		*clr & cla
		dick = rand(12,20)
		$boy = 'пацан'
		silavag = 0
		if gorslut >= 6 and $npc['0,qwPodezdWhore'] < 3: $npc['0,qwPodezdWhore'] +=1
		gs 'stat'
		gs 'zz_render', '', 'images/pavlovo/home/sex_event3/1.jpg', '\\\- Что смотришь <<$gop_gg_name2>>? -/// сказал один из пацанов. \\\- Показывай сиськи!///'
		act 'Далее':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'images/pavlovo/home/sex_event3/2.jpg', 'Вы подняли майку и оголили грудь. Пацан подошел к вам и начал щупать вашу грудь <<body[''tits'']>> размера:**\\\- '+iif(body['tits'] < 2,'Блять, что за прыщи',iif(body['tits'] < 3,'Ничё так сисяндры','Заебись дойки'))+'! А теперь жопу покажи! -/// властно говорит он.'
			act 'Далее':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'images/pavlovo/home/sex_event3/3.jpg', 'Вы поворачиваетесь к нему попкой и чуть наклоняетесь, его руки шуруют по вашим ягодицам.**'+iif (analplugin = 1,'\\\- Корешь смотри, у этой давалки затычка в жопе, вот блядина то какая! -/// коментирует он.**','')
				act 'Далее':
					*clr & cla
					minut += 5
					guy += 2
					i = rand(4,5)
					pose = 1
					gs 'stat'
					gs 'zz_render', '', 'images/pavlovo/home/sex_event3/<<i>>.jpg', 'Наигравшись, он разворачивает вас лицом к стенке и нагибает.'
					if i = 4:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						if vagina >= dick*2: gs 'zz_render', '', '', '\\\- Да у тебя пизда разъёбана - хоть на танке заезжай! - пыхтя произносит парень.///'
					else
						dynamic  $analsex
						if anus >= dick*2: gs 'zz_render', '', '', '\\\- Да у тебя не очко, а дупло какое-то - потеряться можно! - пыхтя произносит парень.///'
					end
					act 'Далее':
						*clr & cla
						dick = rand(12,20)
						$boy = 'пацан'
						silavag = 0
						minut += 5
						i = rand(6,7)
						gs 'stat'
						gs 'zz_render', '', 'images/pavlovo/home/sex_event3/<<i>>.jpg', 'Через некоторое время пацаны поменялись.'
						if i = 6:
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
						else
							dynamic  $analsex
						end
						gs 'zz_render', '', '', iif(shameless['flag'] < 3 and agape < 3 and vgape < 3,'Вы активно подмахиваете ему, что бы поскорее свалить, пока никто не заметил ваше падение.**','')+'Его друг стоит в стороне, наблюдает и дрочит.'
						dynamic $accview_ggsex
						act 'Далее':
							*clr & cla
							minut += 5
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							gs 'stat'
							gs 'zz_render', '', 'images/pavlovo/home/sex_event3/8.jpg', 'Пацаны посадили вас на корточки и, накончав вам полный рот спермы, полностью удовлетворились. Они привели себя в порядок и ушли на улицу, весело обсуждая на ходу произошедшее.'
							act 'Уйти': gt'pod_ezd', 'etaj_2'
						end
					end
				end
			end
		end
	end
end
!ивент с Юлей Миловой
if $args[0] = 'milova':
	*clr & cla
	gs 'npc_editor','get_npc_profile',12
	gs 'zz_render', '', '','На лестничной клетке вы увидели Юлю Милову.'
	act 'Подойти':
		*clr & cla
		minut += 5
		gs 'npc_editor','change_rep','+',12
		gs 'zz_render', '', 'pavlovo/home/milova_event/1.jpg',' Вы поздоровались с Юлькой, узнали как у нее дела, поболтали минут пять.'
		if $npc['12,qwTalkSexJulia'] >= 4:
			i = rand(1,3)
			if i = 1:
				manna += 20
				gs 'zz_render', '', '', 'Юля рассказала вам интересную историю.'
			elseif i = 2:
				gs 'zz_render', '', '', 'Юлька рассказывала вам какую-то ерунду.'
			else
				gs 'zz_render', '', '', 'Юля странно на вас смотрит.'
				act 'Спросить в чем дело':
					*clr & cla
					gs 'zz_render', '', 'pavlovo/home/milova_event/2.jpg', 'Юля молча подходит к вам и начинает целовать ваши <<$liptalk3>>.'
					if horny < 90: act 'Да ну тебя Юлька, отстань!': gt'pod_ezd', 'etaj_3'
					act 'Расслабиться':
						*clr & cla
						horny += 5
						if $npc['12,sex'] = 0: $npc['12,sex'] = 1 & girl += 1
						lesbian += 1
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/home/milova_event/3.jpg', 'Юля говорит вам, приспутив свои брюки:**\\\- <<$name[1]>>, я хочу, чтобы ты полизала меня...///'
						act 'Далее':
							*clr & cla
							minut += 2
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/home/milova_event/4.jpg', 'Вы снимаете штанишки и намекаете, чтобы сначала начала она.**\\\-Нет, <<$gop_name_gg>>, я не могу терпеть, давай сначала ты у меня!///'
							act 'Лизать':
								*clr & cla
								minut += 2
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/home/milova_event/5.jpg', 'Вы опустились на коленки, и зарылись головой между ножек, сидящей на ступеньках, Юли, вылизывая её писю вдоль и поперёк.'
								act 'Далее':
									*clr & cla
									minut += 2
									horny += 5
									gs 'zz_render', '', 'pavlovo/home/milova_event/6.jpg', '\\\- Подожди <<$name[2]>>, -/// прерывает вас Юля. \\\-  Смотри, что у меня с собой есть...///** Она роется в сумочке идостает из резиновый член:**\\\- Держи, это то что мне сейчас нужно больше всего!///'
									act 'Далее':
										*clr & cla
										minut += 5
										horny += 5
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/home/milova_event/'+rand(7,9)+'.jpg', 'Вы вставили в нее резиновый член и, под страстные стоны Юли, начали не спеша двигать его туда-сюда.'
										act 'Далее':
											*clr & cla
											minut += 2
											horny += 5
											gs 'stat'
											gs 'zz_render', '', 'pavlovo/home/milova_event/10.jpg', 'Юля от удовольствия промычала:**\\\- Дай, теперь я сама///**Она перехватила из ваших рук игрушку и начала яростно вгонять её в свою сочащуюся вагину, буквально за пару движений доведя себя до бурного оргазма.'
											act 'Далее':
												*clr & cla
												minut += 2
												horny += 5
												gs 'stat'
												gs 'zz_render', '', 'pavlovo/home/milova_event/11.jpg', 'Тут вы услышали как где-то в подъезде хлопнула дверь, и кто-то стал возиться с ключами, закрывая её. Вы с Юлей быстро напялили на себя свои вещи и она тут же упорхнула к себе домой.**Вы остались не удовлетворены.'
												act 'Уйти': gt'pod_ezd', 'etaj_3'
											end
										end
									end
								end
							end
						end
						act 'Отказаться':
							*clr & cla
							minut += 5
							dom += 1
							$npc['12,relation'] = 30
							BeInJulMilHome = 0
							gs 'stat'
							gs 'npc_editor','get_npc_profile',12
							gs 'zz_render', '', '','Юля обиделась и, одевшись, ушла в свою квартиру.'
						end
					end
				end
			end
		end
		act 'Уйти': gt'pod_ezd', 'etaj_3'
	end
	act 'Пройти мимо': gt'pod_ezd', 'etaj_3'
end
!Шульга курит
if $args[0] = 'smoke_shulga':
	*clr & cla
	gs 'stat'
	gs 'npc_editor','get_npc_profile',11
	gs 'zz_render', '', '', 'На лестничной клетке курит Вася Шульгин.'
	act 'Поболтать':
		*clr & cla
		minut += 5
		manna += 10
		gs 'npc_editor','change_rep','+',11
		gs 'stat'
		gs 'npc_editor','get_npc_profile',11
		gs 'zz_render', '', '', 'Вы минут пять беседуете с Васяном о всякой ерунде.'
		act 'Уйти': gt'pod_ezd', 'etaj_3'
	end
	act 'Пройти мимо': gt'pod_ezd', 'etaj_3'
	smoke_bj = RAND(0,100)
	if rand(0,100) <= 50 and (GorSlut >= 3 or $npc['11,relation'] >= 100): gt 'pavlovo_events', 'bj_smoke_shulga'
end
!Ивент с отсосом Шульге
if $args[0] = 'bj_smoke_shulga':
	*clr & cla
	gs 'npc_editor','get_npc_profile',11
	gs 'zz_render', '', '', 'На лестничной клетке курит Вася Шульгин. Увидев вас он оживился:**\\\- Иди сюда <<$gop_name_gg>>, дело есть!///**Когда вы к нему подошли, он сказал:**\\\- <<$gop_name_gg>> пососи мне по быстрому...///**\\- А если кто увидит?, -// замялись вы.**\\\- Да не ломайся ты, кто тут увидит?, -/// начал настаивать Васян.'+iif(GorSlut >= 3,'\\\ - Давай бери в рот, ты же знаешь, как сделать всё по быстрому!///','')
	if horny < 90 and  alko < 6 and GorSlut < 3:
		act 'Отказать':
			*clr & cla
			dom += 1
			gs 'npc_editor','change_rep','-',11
			gs 'stat'
			gs 'npc_editor','get_npc_profile',11
			gs 'zz_render', '', '', '\\- Нет, Вася, тут я сосать отказываюсь!, -//  говорите вы и уходите.'
			act 'Уйти': gt'pod_ezd', 'etaj_3'
		end
	end
	act 'Сосать':
		*clr & cla
		bj += 1
		minut += 5
		if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
		gs 'npc_editor','init_sex',11
		gs 'stat'
		gs 'zz_render', '', 'images/pavlovo/home/events/shulga_bj.gif', '\\- Ладно, все равно не отстанешь... -// говорите вы и садитесь на корточки.'
		gs 'zz_dynamic_sex', 'bj'
		act 'Сосать дальше':
			*clr & cla
			swallow += 1
			minut += 5
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_funcs', 'cum', 'lip'
			gs 'stat'
			gs 'zz_render', '', 'images/pavlovo/home/events/shulga_cum.gif', '<br>Вы понимали, что в любой момент может кто-то появиться, поэтому быстро довели Ваську до оргазма. Он излился вам в рот, заодно запачкав спермой и лицо, и спрятал свой член в штаны.**\\- Доволен?, -// спросили вы, пытаясь вытереть лицо.**\\\- Ага, замечательный и безотказный ротик у тебя!, -///, сделав такой своеобразный комплимент, <<$shulga_name_rnd>> удалился.'
			act 'Уйти': gt'pod_ezd', 'etaj_3'
		end
	end
end
!ивенты на чердаке (пятый этаж)attic
if $args[0] = 'attic':
	i = rand(1,4)
	if i = 1:
		*clr & cla
		minut += 5
		horny += 5
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/attic/ev1_1.jpg', 'Поднявшись на чердак, вы увидели несколько незнакомых ребят и девушку. Они занимались сексом и всё действо снимали на камеру.'
		dynamic $masturb_gg
		act 'Подсматривать':
			*clr & cla
			minut += 5
			horny += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/home/attic/ev1_2.jpg', 'Один парень нагнув девушку жестко трахал её сзади, другой пихал член ей в рот. Девчушка с удовольствием подмахивала попкой и, причмокивая, обсасывала член.'
			dynamic $masturb_gg
			act 'Подсматривать':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/attic/ev1_3.jpg', 'Парни поменялись местами и продолжали сношать девушку. Вам все это действо показалось однообразным и вы решили покинуть чердак.'
				act 'Уйти': gt'pod_ezd', 'etaj_5'
			end
		end
	elseif i = 2:
		*clr & cla
		minut += 2
		horny += 5
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/attic/ev2_1.jpg', 'Поднявшись на чердак вы увидели несколько незнакомых ребят и девушку. Девушка сосала член у парня, а другой парень снимал все на камеру.'
		act 'Подсматривать':
			*clr & cla
			minut += 3
			horny += 5
			gs'stat'
			gs 'zz_render', '', 'pavlovo/home/attic/ev2_2.jpg', 'Через мгновение девушка умело сосала уже два члена.'
			act 'Далее':
				*clr & cla
				minut += 2
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/attic/ev2_3.jpg', 'Ребята сказали девушке, что пора переходить к основному действию, и чтобы она показала попку на камеру.'
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut += 3
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/home/attic/ev2_4.jpg', 'Парень подошел и начал трахать девушку в вагину. Девушка активно подмахивала и постанывала.'
					dynamic $masturb_gg
					act 'Далее':
						*clr & cla
						minut += 2
						horny += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/home/attic/ev2_5.jpg', 'Парочка поменяла позу и вы заметили, что парень вставил свой член девушке в анус. Попка без проблем приняла член парня и девушка начала быстро подмахивать парню.'
						dynamic $masturb_gg
						act 'Далее':
							*clr & cla
							minut += 3
							horny += 5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/home/attic/ev2_6.jpg', 'Это продолжалась минут пять и оператор, не выдержав, подошел и вставил член девушке в рот. Так ее сношали еще минут пять. Девушка была на грани оргазма.'
							dynamic $masturb_gg
							act 'Далее':
								*clr & cla
								minut += 2
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/home/attic/ev2_7.jpg', 'Парни демонстративно на камеру обкончали ротик девушки и сказали ей попозировать на камеру.'
								dynamic $masturb_gg
								act 'Далее':
									*clr & cla
									minut += 3
									horny += 5
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/home/attic/ev2_8.jpg', 'Девушка с блядским взглядом смотрела в камеру и облизывала губы языком, собираяя с лица сперму пальчиками.'
									dynamic $masturb_gg
									act 'Далее':
										*clr & cla
										minut += 2
										gs 'stat'
										gs 'zz_render', '', 'pavlovo/home/attic/ev2_9.jpg', 'Ребята начали одеваться и приводить себя в порядок, вы решили по быстрому удалиться, пока не заметили.'
										act 'Уйти': gt'pod_ezd', 'etaj_5'
									end
								end
							end
						end
					end
				end
			end
		end
	elseif i = 3:
		*clr & cla
		minut +=5
		horny +=5
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/attic/ev3_1.jpg', 'Поднявшись на чердак вы увидели несколько незнакомых ребят и девушку. Один из парней снимал все на камеру, а девушка, то по очереди, то одновременно сосала члены парней.'
		act 'Подсматривать':
			*clr & cla
			minut +=2
			horny +=5
			gs'stat'
			gs 'zz_render', '', 'pavlovo/home/attic/ev3_2.jpg', 'Девушку подняли, развернули, она уперлась о стенку и выпятила попку. Парень быстрыми, резкими толчками начал трахать её киску. Девушка активно подмахивали и постанывала.'
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				minut +=5
				horny +=5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/attic/ev3_3.jpg', 'Оператору надоело стоять в стороне, он попросил друга, чтобы тот развернул бабу, головой в его сторону. Теперь девушку сношали с двух сторон. Судя по лицу ей все это действо было в кайф.**Через минут пять парень, трахавший девушку, кончил прямо в киску.'
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut +=2
					horny +=5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/home/attic/ev3_4.jpg', 'Второй парень слил всю сперму ей в ротик и попросил красиво разогнуться на камеру.'
					dynamic $masturb_gg
					act 'Далее':
						*clr & cla
						minut +=2
						horny +=5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/home/attic/ev3_5.jpg', 'Девушка выпятила попку прямо на камеру, показав как размазана сперма по ее писе, не забывая при этом по-блядски улыбаться**Похоже съемка закончена, ребята начали собираться, и вам нужно быстро удалиться, пока вас не заметили.'
						act 'Уйти': gt'pod_ezd', 'etaj_5'
					end
				end
			end
		end
	else
		*clr & cla
		minut +=5
		horny +=5
		voyeurism += 1
		gs'stat'
		gs 'zz_render', '', 'pavlovo/home/attic/ev4_1.jpg', 'Поднявшись на чердак вы увидели несколько незнакомых ребят и девушку. Девушка позировала на камеру, показывая свои сиськи.'
		act 'Подсматривать':
			*clr & cla
			minut +=2
			horny +=5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/home/attic/ev4_2.jpg', 'Один из парней подошел к девушке и достал свой член. Она без всякого стеснения села на корточки и начала умело обрабатывать член своими губами.'
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				minut +=3
				horny +=5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/attic/ev4_3.jpg', 'Второй парень, который снимал, решил тоже угостить девушку своей конфетой. Девушка даже не удивилась, и начала обрабатывать два ствола одновременно.'
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					minut +=2
					horny +=5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/home/attic/ev4_4.jpg', 'Девушку поставили раком и начали сношать с двух сторон, один в вагину, другой в рот.'
					dynamic $masturb_gg
					act 'Далее':
						*clr & cla
						minut +=3
						horny +=5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/home/attic/ev4_5.jpg', 'Девушка активно подмахивала попкой, даже вы слышали чавкающие звуки, которые издавала ее вагина, слышали как она демонстративно причмокивая, сосала член на камеру.'
						dynamic $masturb_gg
							act 'Далее':
							*clr & cla
							minut +=2
							horny +=5
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/home/attic/ev4_6.jpg', 'Девушка села на корточки и пацаны обкончали все её блядское личико.**Вы быстро удалились пока вас не заметили...'
							act 'Уйти': gt'pod_ezd', 'etaj_5'
						end
					end
				end
			end
		end
	end
end
!ивенты с подглядыванием на разных этажах
if $args[0] = 'front_door':
	i = rand(1,4)
	if i = 1:
		*clr & cla
		horny += 5
		minut += 2
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/events/ev1_1.jpg', 'Вы увидели как на лестничной клетке сидит на ступеньках какая-то дама. Она курит, беседуя со своим кавалером, и показывая ему свои прелести.'
		act 'Подсмотреть':
			*clr & cla
			horny += 5
			minut += 3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/home/events/ev1_2.jpg', 'Дамочка вульгарно себя ведет, показывая свою пилотку и грудь какому-то мужику.**Через пару минут парочка удалилась.'
			act 'Уйти': gt'pod_ezd', 'etaj_2'
		end
	elseif i = 2:
		*clr & cla
		minut += 10
		horny += 10
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/events/ev2.jpg', 'Вы увидели, как на лестничной клетке два пацана быстро сношали какую-то девку, судя по наряду проститутку.<br>Лицо разглядеть вы не смогли, так как девушка была зажата между парнями.'
		dynamic $masturb_gg
		gs 'zz_render', '', '', 'Вдруг вы услышали какие-то шаги на лестнице и решили быстро удалиться.'
		act 'Уйти': gt'pod_ezd', 'etaj_2'
	elseif i = 3:
		*clr & cla
		horny += 5
		minut +=3
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/events/ev3_1.jpg', 'Вы узнаете девчонку из параллельгого класса, которая снимает трусики перед каким-то пацаном.'
		act 'Наблюдать':
			*clr & cla
			horny += 5
			minut +=3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/home/events/ev3_2.jpg', 'Она вертит попкой и флиртует с пацаном.'
			act 'Далее':
				*clr & cla
				horny += 5
				minut +=3
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/events/ev3_3.jpg', 'Пацан достал телефон и начал фоткать девчонку.'
				dynamic $masturb_gg
				act 'Далее':
					*clr & cla
					horny += 5
					minut +=3
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/home/events/ev3_4.jpg', 'Девчонка принимает разные позы на камеру.'
					dynamic $masturb_gg
					act 'Далее':
						*clr & cla
						horny += 5
						minut +=3
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/home/events/ev3_5.jpg', 'Красуясь, она все больше и больше старается засветить письку.'
						dynamic $masturb_gg
						act 'Далее':
							*clr & cla
							horny += 5
							minut +=3
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/home/events/ev3_6.jpg', 'Девчонка вертит попкой, показывая все свои дырочки на камеру.'
							dynamic $masturb_gg
							gs 'zz_render', '', '', 'Фотосессия закончилась и ребята начали собираться. Вы быстренько удалились пока вас не заметили.'
							act 'Уйти': gt'pod_ezd', 'etaj_2'
						end
					end
				end
			end
		end
	else
		*clr & cla
		horny +=5
		minut +=3
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/home/events/ev4_1.jpg', 'Вы замечаете как какая-то баба, встает в разные позы, а её муж фоткает все это дело на камеру'
		act 'Наблюдать':
			*clr & cla
			horny +=5
			minut +=3
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/home/events/ev4_2.jpg', 'Муж не прекращает руководить:\\\- Давай подними ножку, поставь на перила...вот так, да...красивое фото сейчас будет.///'
			dynamic $masturb_gg
			act 'Далее':
				*clr & cla
				horny +=5
				minut +=3
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/home/events/ev4_3.jpg', '\\\- А теперь приподнеми пеньюар, сделаем более откровенное фото///'
				act 'Далее':
					*clr & cla
					horny +=5
					minut +=3
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/home/events/ev4_4.jpg', '\\\- А прикинь, сюда сейчас какие-нибудь наши соседи выйдут, и увидят тебя в таком полу голом виде?///**\\\- Да, меня это сильно заводит!///'
					dynamic $masturb_gg
					act 'Далее':
						*clr & cla
						horny +=5
						minut +=3
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/home/events/ev4_5.jpg', '\\\- Наклонись, покажи свою прелестную попку.///**\\\- Вот так да?///**\\\- Да так супер, еще рукой можешь раздвинуть ягодицу...///'
						dynamic $masturb_gg
						act 'Далее':
							*clr & cla
							horny +=5
							minut +=3
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/home/events/ev4_6.jpg', '\\\- Сейчас крупным планом сфоткаю, больше прогнись и замри в такой позе...///'
							dynamic $masturb_gg
							act 'Далее':
								*clr & cla
								horny +=5
								minut +=3
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/home/events/ev4_7.jpg', 'Муж говорит своей жене:**\\\- Бля, больше не могу, пойдем быстрее домой!///**Она отвечает:**\\\- Давай, я уже завелась не на шутку!///**Парочка удалилась в свою квартиру.'
								act 'Уйти': gt'pod_ezd', 'etaj_2'
							end
						end
					end
				end
			end
		end
	end
end
if $args[0] = 'aunt_luda':
	*clr & cla
	horny += 5
	minut += 5
	voyeurism += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/home/events/aunt_luda.jpg', 'Вы заметили тетю Люду, которая ходила выбрасывать мусор. Вас удивил ее внешний вид.'
	act 'Уйти': gt'pod_ezd', 'etaj_2'
end
!расписанная стена
if $args[0] = 'paint':
	*clr & cla
	gs 'stat'
	gs 'zz_render', '', 'images/pavlovo/home/floor2_whore.jpg', 'Вы посмотрели на надпись и подумали, а стоит ли закрашивать её, ведь это рекламное объявление привлекает много народу...'
	if paint_blue <= 0:
		gs 'zz_render', '', '', 'Для того что бы закрасить надпись на стене, вам нужно купить краску в магазине.'
	else
		gs 'zz_render', '', '', 'У вас есть <<paint_blue>> литров краски.'
		act 'Закрасить':
			*clr & cla
			pod_whore_countQW = 0
			minut +=40
			paint_blue -= 1
			gs 'stat'
			gs 'zz_render', '', 'images/pavlovo/home/floor2.jpg', 'Вы потратили более полу часа, что бы покрасить стену, зато теперь чисто, красиво и меньше народу будет ходить!'
			act 'Уйти': gt'pod_ezd','etaj_2'
		end
	end
	act 'Оставить эту затею': gt'pod_ezd','etaj_2'
end
!подъезд объявление
if $ARGS[0] = 'pod_objava':
	*clr & cla
	minut +=1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/home/events/ad'+rand(1,2)+'.jpg'
	act 'Далее': gt'pod_ezd','etaj_1'
end
! Носов поджидает ГГ
if $ARGS[0] = 'nosov_meet':
	*clr & cla
	gs'stat'
	gs 'npc_editor','get_npc_profile',1
	gs 'zz_render','','','Возле дома вас поджидает Дима Носов.\\\- Ну что, шлюшка? Если не хочешь, чтобы видео стало достоянием общественности, сейчас пойдем ко мне и поговорим!, -/// говорит он.'
	act 'Идти к Диме':
		*clr & cla
		if $npc['1,qwNosovRevenge'] = 2: $npc['1,qwNosovRevenge'] = 3
		minut += 15
		gs 'npc_editor','get_npc_profile',1
		gs 'stat'
		gs 'zz_render','','','Вы идете к дому Димы. Дом, где он живет, принадлежит его родителям. Это большой двухэтажный дом с ухоженным газоном и небольшим садом. Вместе с Димой вы идете в его комнату, он закрыват двери на ключ.'
		act 'Идти в комнату Димы': gt'dimaHome'
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		DimaRudeBlock = 1
		if GorSlut < 2:GorSlut = 2
		dom += 5
		gs 'npc_editor','get_npc_profile',1
		gs'stat'
		gs 'zz_render', '', '', 'Вы отказались идти с Димой. Он хмыкнул:**\\\- Ну и вали! Завтра все будут знать, что ты хуесоска!///'
		act 'Убежать': gt'gorodok'
	end
end