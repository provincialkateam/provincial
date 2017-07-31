if $args[0] = '' or $args[0] = 'main':
	$metka = $ARGS[0]
	$loc = $CURLOC
	gs 'zz_phone','boyfriend_call_init'
	gs 'stat'
	gs 'time'
	gs 'zz_render','Рынок','pavlovo/market/market.jpg','Маленький рынок расположен возле <a href="exec:minut += 5 & gt ''vokzalG''">вокзала</a>, но с него легко можно попасть в <a href="exec:minut += 10 & gt''gorodok''">городок</a>.'
	act '<b>В городок</b>': minut += 10 & gt 'gorodok'
	act '<b>Вокзал</b>': minut += 5 & gt 'vokzalg'
	if hour >= 8 and hour <= 16:
		gs 'zz_render','','','На рынке продавцы выставили товары и зазывают покупателей.'
		act 'Ателье по пошиву и ремонту одежды': gt 'zz_clothing','tailor'
		act 'Бродить по рынку':
			*clr & cla
			minut += rand(10,20)
			gs 'stat'
			gt 'grinok', 'grinok_events', iif(rand(1,100) > 5,rand(1,20),0)
			act 'Идти дальше': gt $loc, $metka
		end
		if pornmarkonce = 1: act 'Идти в уголок с порнухой': gt 'grinok','porn_market'
		if arturKnow = 1 and ($npc['40,qwArtur'] = 0 or $npc['40,qwArtur'] = 3):
			act 'Идти к Артуру': gt'arturRinok','start'
		elseif $npc['40,qwArtur'] = 1 and (week = 6 or week = 7):
			act 'Идти к Артуру': gt 'arturRinok',iif(hour < 9,'work_1','start')
		elseif $npc['40,qwArtur'] = 2:
			if hour = 16:
				act 'Идти к Артуру': gt 'arturRinok','work_2'
			else
				act 'Подождать Артура': minut += 30 & gt 'grinok'
			end
		end
		act 'Идти к книжному лотку':
			*clr & cla
			minut += 15
			gs 'stat'
			gs 'zz_books', 'shop'
			act 'Уйти': gt'grinok','main'
		end
		if gobelen > 0:
			act 'Продать гобелен':
				if gobQW = 0:
					*clr & cla
					gobQW = 1
					minut += rand(10,15)
					gs 'stat'
					gs 'zz_render','','pavlovo/market/gobelen.jpg','Вы тихонько встаете у входа в рынок и разворачиваете гобелен ожидая покупателей. К вам тут же, вместо покупателей, подходит мужчина, и сообщает вам, что незаконная торговля запрещена на территории рынка, но он может скупать у вас гобелены в любом количестве, от 750 рублей и выше, за штуку, в зависимости от качества'
					act 'Уйти': gt 'grinok'
				else
					*clr & cla
					minut += 15
					price_gobelen = iif(poSkill < 500,75,iif(poSkill < 1000,100,150))
					gs 'stat'
					gs 'zz_render','','pavlovo/market/roman_trades.jpg','Вы идете к мужчине, который предложил скупать у вас гобелены. Он, заметив вас, улыбается.'
					if gobQW = 2:
						gs 'zz_render','','','Роман приветствует вас и деловито интересуется, что у вас есть на продажу.'
					elseif gobQW = 1:
						gobQW = 2
						gs 'zz_render','','','Мужчина приветствует вас и представляется Романом, вы так же отвечаете, что вас зовут <<$name[1]>>. После приветствия Роман деловито интересуется, что у вас есть на продажу.'
					end
					act 'Показать гобелен':
						*clr & cla
						gobelen -= 1
						money += price_gobelen*10
						gs 'stat'
						gs 'zz_render','','pavlovo/market/roman.jpg','Вы показываете гобелен Роману и он дает вам <<price_gobelen*10>> рублей за него. Вы берете деньги и отдаете ему гобелен.'
						act 'Уйти': gt 'grinok'
					end
					if gobelen > 1:
						act 'Продать все гобелены':
							*clr & cla
							i = gobelen * (price_gobelen*10)
							money += i
							gobelen = 0
							gs 'zz_render','','pavlovo/market/roman.jpg','Вы показываете гобелены Роману и он дает вам <<i>> рублей за них. Вы берете деньги и отдаете ему гобелены.'
							gs 'stat'
							act 'Уйти': gt 'grinok'
						end
					end
					act 'Уйти': gt 'grinok'
				end
			end
		end
	else
		gs 'zz_render','','','На рынке никого нет.'
		if $npc['40,qwArtur'] = 1 and (week = 6 or week = 7) and hour < 12: act 'Подождать Артура':hour = 12 & minut = 0 & gt'grinok','main'
	end
	gs 'zz_family', 'mother_sheduler'
end
if $args[0] = 'grinok_events':
	*clr & cla
	$grinok_text[0] = 'Вы наткнулись на попрошайку'
	$grinok_text[1] = 'Вы видите нищего, просящего милостыню'
	$grinok_text[2] = 'Вы видите нищего'
	$grinok_text[3] = 'как переодевается девушка'
	$grinok_text[4] = 'что какая то женщина подбирает себе нижнее белье'
	$grinok_text[5] = 'полуголую девицу'
	$grinok_text[6] = 'девушку, примеряющую лифчик'
	$grinok_text[7] = 'Ничего необычного вам не попадается, всякое хламье, овощи и безвкусная одежда'
	$grinok_text[8] = 'Вам не везет и вы то и дело натыкаетесь на старушечьи домашние халаты, тапки и жилетки с карманами.'
	$grinok_text[9] = 'Вы не нашли ничего интересного'
	$grinok_text[10] = 'Вам попадается один китайский ширпотреб и больше ничего'
	$grinok_text[11] = 'Рынок работает в штатном режиме. Люди с сумками снующие туда сюда, дети выпрашивающие игрушку у родителей и горластые продавцы.'
	$grinok_text[12] = 'На рынке как всегда много народу. Толкотня и суета не дает вам сосредоточиться на своих желаниях'
	! def action
	act '<b>В городок</b>': minut += rand(10,15) & gt 'gorodok'
	act '<b>Вокзал</b>': minut += rand(5,10) & gt 'vokzalg'
	if hour >= 8 and hour <= 16: act 'Бродить дальше': minut += rand(10,30) & gt $loc, $metka
	if args[1] = 0:
		gs 'zz_render','','pavlovo/market/brodit'+rand(1,8),'Вы некоторое время гуляете по рынку. ' + $grinok_text[rand(7,12)]
	end
	if args[1] = 1:
		gs 'zz_render','','pavlovo/market/poproshaika'+rand(1,3),$grinok_text[rand(0,2)]
		if money >= 20:
			act 'Кинуть мелочь':
				*clr & cla
				money -= rand(5,20)
				manna += 5
				gs 'stat'
				gs 'zz_render','','pavlovo/market/podaet.jpg','Вы дали попрошайке мелочь'
				act 'Бродить дальше': gt $loc, $metka
			end
		end
	end
	if args[1] = 2:
		gs 'zz_render','','pavlovo/market/dedgitara.jpg','Вы видите деда, играющего на гитаре'
	end
	if args[1] = 3:
		gs 'zz_render','','pavlovo/market/girlvoyeur.jpg','Вы видите нагнувшуюся девушку, выставившую свою киску всем на обозрение'
		if girl > 0: horny += 10
		gs 'stat'
	end
	if args[1] = 4:
		gs 'zz_render','','pavlovo/market/goodass.jpg','Вы увидели девушку и завистливо посмотрели на ее красивую попу'
	end
	if args[1] = 5:
		gs 'zz_render','','pavlovo/market/dedgitara.jpg','Вы видите деда, играющего на гитаре'
	end
	if args[1] = 6:
		gs 'zz_render','','pavlovo/market/ciganka.jpg','Вам повстречалась цыганка. Она предложила погадать вам'
		act 'Согласиться':
			*clr & cla
			minut += 5
			gs 'zz_render','','pavlovo/market/gadaet'+rand(1,2),'Вы согласились и цыганка взяв вашу руку стала предсказывать вам огромное счастье и много денег. Закончив, она спешно зашагала прочь'
			act 'Осмотреться':
				*clr & cla
				money = 0
				manna -= 50
				gs 'stat'
				gs 'zz_render','','pavlovo/market/pusto.jpg','В вашу голову закрались подозрения и вы стали обыскивать ваши вещи. Но свой кошелек вы так и не нашли'
				act 'Окликнуть цыганку':
					*clr & cla
					gs 'zz_render','','pavlovo/market/okliknut.jpg','Вы обернулись в надежде увидеть воровку, но она словно расстворилась в толпе'
					act 'Назад': gt 'grinok', 'main'
				end
			end
		end
	end
	if args[1] = 7:
		money_rand = rand(4,8)*100
		gs 'zz_render','','pavlovo/market/kosmetic.jpg','Вы видите, что продают довольно дешевую косметику, на <<money_rand/25>> применений, за <<money_rand>> рублей'
		if money >= money_rand:
			act 'Купить':
				money -= money_rand
				kosmetica += money_rand/25
				gt $loc, $metka
			end
		end
	end
	if args[1] = 8:
		money_rand = rand(2,5)*100
		gs 'zz_render','','pavlovo/market/vitaminki.jpg','Вы видите, что продают витаминки, <<money_rand/20>> штук за <<money_rand>> рублей'
		if money >= money_rand:
			act 'Купить':
				vitamin += money_rand/20
				money -= money_rand
				gt $loc, $metka
			end
		end
	end
	if args[1] = 9:
		money_rand = rand(8,32)*10
		gs 'zz_render','','pavlovo/market/condoms.jpg','Вы видите, что продают презервативы, <<money_rand/20>> штук за <<money_rand>> рублей'
		if money >= money_rand:
			act 'Купить':
				prezik += money_rand/20
				money -= money_rand
				gt $loc, $metka
			end
		end
	end
	if args[1] = 10:
		money_rand = rand(3,8)*100
		gs 'zz_render','','pavlovo/market/balzam.jpg','Вы видите, что продают бальзам для губ, на <<money_rand/20>> применений, за <<money_rand>> рублей'
		if money >= money_rand:
			act 'Купить':
				'<<money_rand>>'
				lipbalm += money_rand/20
				money -= money_rand
				gt $loc, $metka
			end
		end
	end
	if args[1] = 11:
		if pornmarkonce = 0: pornmarkonce = 1
		gs 'zz_render','','pavlovo/market/porno.jpg','Прохаживаясь по рынку вы случайно забредаете в дальний угол, где продают порнуху.'
		act 'Подойти': gt 'grinok','porn_market'
	end
	if args[1] = 12:
		if arturKnow = 0:
			gs 'zz_render','','pavlovo/market/market.jpg','Внезапно вас окликают:**\\\- Эй девюшка, хочешь мандаринку скюшать?///'
			act 'Оглянуться': gt 'arturRinok','start'
		else
			gs 'zz_render','','pavlovo/market/market.jpg','Внезапно вас окликают:**\\\- Эй <<$name[2]>>, иди сюда, скюшай мандаринку.///'
			act 'Подойти': gt 'arturRinok','start'
		end
	end
	if args[1] = 13:
		gs 'zz_render','','pavlovo/market/cheburek.jpg','Гуляя по рынку, вы набрели на бабушку, торгующую пирожками'
		if energy <= 20 and money >= 50:
			act 'Купить пирожок за 50 рублей':
				*clr & cla
				body['day_weight'] += 1
				health += 5
				manna += 5
				water -= 5
				energy += 5
				money -= 50
				minut += 10
				gs 'stat'
				gs 'zz_render','','pavlovo/market/eat.jpg','Вы с удовольствием съели вкусный пирожок'
				act 'Бродить дальше': gt $loc, $metka
			end
		end
	end
	if args[1] = 14:
		gs 'zz_render','','pavlovo/market/dropwallet.jpg','Вы видите, как идущая впереди женщина выронила кошелек'
		act 'Сказать ей':
			*clr & cla
			minut += 2
			gs 'zz_render','','pavlovo/market/vernutwallet.jpg','Вы окликнули женщину и показали на выпавший кошелек. Она благодарно посмотрела на вас и, подняв утерянное, зашагала прочь'
			act 'Бродить дальше': gt $loc, $metka
		end
		act 'Поднять кошелек':
			*clr & cla
			minut += 5
			i = rand(40,200)
			gs 'zz_render','','pavlovo/market/zaglanut.jpg','В кошельке оказалось <<i>> рублей'
			act 'Забрать деньги и выкинуть кошелек':
				*clr & cla
				money += i
				manna += 10
				gt $loc, $metka
			end
			act 'Догнать женщину и вернуть ей кошелек':
				*clr & cla
				manna += 5
				gs 'zz_render','','pavlovo/market/proverka.jpg','Вы догнали женщину и со словами "У вас упало" отдали ей кошелек. Женщина тут же стала пересчитывать деньги. Убедевшись что все на месте, она поблагодарила вас и зашагала прочь'
				act 'Бродить дальше': gt $loc, $metka
			end
		end
	end
	if args[1] = 15:
		gs 'zz_render','','pavlovo/market/rebenok.jpg','Вы видите молодую мамашу, тянущую плачущего ребенка'
	end
	if args[1] = 16:
		gs 'zz_render','','pavlovo/market/rezba.jpg','Вы увидели палатку с красивыми поделками, вырезанными из дерева и металла'
	end
	if args[1] = 17:
		gs 'zz_render','','pavlovo/market/gruzchik.jpg','Глазея по сторонам, вы чуть не столкнулись с грузчиком'
	end
	if args[1] = 18:
		gs 'zz_render','','pavlovo/market/meatlavka.jpg','Вы забрели в мясной отдел и видите как мясник работает топором.'
	end
	if args[1] = 19:
		if vnesh >= 60:
			gs 'zz_render','','pavlovo/market/walk'+rand(1,2),'Вы идете, вызывающе виляя попой. Парни уставились на вас, провожая взглядом.'
			manna += 5
		else
			gs 'zz_render','','pavlovo/market/walk'+rand(3,4),'Вы проходите, старательно виляя бедрами. Но парни не обращаются на вас ни малейшего внимания'
			manna -= 5
		end
		gs 'stat'
	end
	if args[1] = 20:
		gs 'zz_render','','pavlovo/market/dirka.jpg','При обходе рядов с вещами, вы заметили небольшую дыру в палатке'
		act 'Заглянуть':
			*clr & cla
			if girl > 1: horny += 5
			gs 'zz_render','','pavlovo/market/pereodev'+rand(1,15)+'.jpg','Вы заглядываете внутрь палатки и видите ' + $grinok_text[rand(3,7)]
			act 'Отойти': gt $loc, $metka
		end
	end
	killvar '$grinok_text'
end
if $args[0] = 'buy_pornMagazine':
	if money >= 500:
		act 'Купить':
			*clr & cla
			minut += 5
			money -= 500
			pornMagazine = 50
			gs 'stat'
			gs 'zz_render','','pavlovo/market/buymagazine','Стараясь не смотреть продавцу в глаза, вы отсчитали деньги, и, взяв журнал, быстро его спрятали.'
			act 'Уйти': gt 'grinok'
		end
	end
end
if $args[0] = 'porn_market':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render','','pavlovo/market/porn_magazine','На лотке лежат разнообразные порножурналы. Возле лотка крутится продавец с бегающими глазками.'
	act 'Уйти': gt 'grinok'
	if pornMagazine = 0:
		gs 'zz_render','','','Вы замечаете в пачках всяких гламурных журналов уголки с пометкой "18+", явно намеренно выставленные наружу.'
	elseif pornMagazine = 1:
		gs 'zz_render','','','Вы зачитали свой журнал уже до дыр и было бы неплохо купить новый.'
		gs 'grinok','buy_pornMagazine'
	else
		gs 'zz_render','','','У вас уже есть журнал, и лишний раз крутиться возле лотка с подобным товаром не стоит.'
	end
	! erotic books
	if reading['erotic_enable'] > 0: gs 'zz_books','shop','ero'
	gs 'zz_render','','','Продавец спрашивает вас:**<do>- Желаете приобрести журнальчик?</do>'
	act 'Спросить цену':
		cla
		minut += 5
		if shameless['flag'] = 0:
			gs 'zz_render','','','Отчаянно краснея до кончиков волос осипшим голосом вы тихонько спросили у него цену на "эти вот журналы", указав кивком на торчащие из развала уголки "18+". Продавец с каменным лицом сказал: <br><do>- Все журналы по 500 рублей.</do>'
		else
			gs 'zz_render','','','<do>- Все журналы по 500 рублей.</do>'
		end
		gs 'grinok','buy_pornMagazine'
		act 'Уйти': gt 'grinok'
	end
end