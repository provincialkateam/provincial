if $ARGS[0] = 'start':
	$metka = $ARGS[0]
	$loc = $CURLOC
	*clr & cla
	minut += 1
	gs 'zz_funcs', 'colorize_day'
	gs 'stat'
	gs 'zz_render', 'Кафе', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str1')
	if money >= 1500:
		act 'Поесть 500 руб':
			*clr & cla
			money -= 500
			gs 'zz_kitchen_acts', 'eat'
			gs 'zz_kitchen_acts', 'drink', 'tea'
			if RAND(1,10) > 5:
				gs 'boy'
				gs 'zz_render', '', '', func('kafe_strings', 'local_str2')
				xgt 'kafe','razvod'
			end
			act 'Встать из за стола':gt'kafe','start'
		end
	end
	act 'Выйти': gt'street'
end
if $ARGS[0] = 'vlad':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Кафе', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str'+iif($npc['34,relation'] > 0,65,64))
	if workKafe = 0:
		if $npc['34,sex'] >= 2 and Givisexday < 1 and Venera < 4:
			act 'Спровоцировать Гиви':
				*clr & cla
				Givisexday = 1
				$npc['34,sex'] += 1
				gs 'zz_render', '', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str3')
				act 'Встать на колени':
					*clr & cla
					bj += 1
					dick = 20
					harakBoy = 2
					minut += 30
					$boy = 'Гиви Карапетович'
					dom -= 1
					gs 'zz_render', '', 'images/nigma/city/boss0'+rand(0,5)+'.gif', func('kafe_strings', 'local_str4')
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_render', '', '', func('kafe_strings', 'local_str5')
					act 'Продолжать сосать':
						*clr & cla
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						money += 500
						gs 'zz_render', '', 'common/sex/bj_cum/'+rand(0,4)+'.gif', func('kafe_strings', 'local_str6')
						act 'Уйти':gt'kafe','start'
					end
				end
			end
		end
	else
		if $npc['34,sex'] >= 2 and Givisexday < 1 and Venera < 4:
			act 'Спровоцировать Гиви':
				*clr & cla
				Givisexday = 1
				$npc['34,sex'] += 1
				gs 'zz_render', '', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str7')
				act 'Встать на колени':
					*clr & cla
					smenaKafe += 1
					bj += 1
					dick = 20
					harakBoy = 2
					minut += 30
					$boy = 'Гиви Карапетович'
					dom -= 1
					gs 'zz_render', '', 'images/nigma/city/boss0'+rand(0,5)+'.gif', func('kafe_strings', 'local_str8')
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_render', '', '', func('kafe_strings', 'local_str9')
					act 'Продолжать сосать':
						*clr & cla
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						gs 'stat'
						gs 'zz_render', '', 'common/sex/bj_cum/'+rand(0,4)+'.gif', func('kafe_strings', 'local_str10')
						act 'Уйти': gt'kafe','start'
					end
				end
			end
		end
		act 'Уволиться':
			cla
			work = 0
			workKafe = 0
			pay = smenaKafe*600
			money += pay
			smenaKafe = 0
			gs 'zz_render', '', '', func('kafe_strings', 'local_str11')
			act 'Уйти': gt'kafe','start'
		end
	end
	if workKafe > 0 and week > 1 and week < 5:'Вах, <<$name[2]>>. Зачэм прогуливаешь?'
	if workKafe > 0 and week > 4:'Вах, прывэт <<$name[2]>>!'
	if $npc['34,relation'] = 1 and workKafe < 1:'Слушаю вас.'
	if $npc['34,relation'] = 0:
		$npc['34,relation'] = 1
		gs 'zz_render', '', '', func('kafe_strings', 'local_str12')
	end
	if work = 0 and workKafe = 0:
		act 'Спросить возьмет ли он вас на работу':
			cla
			gs 'zz_render', '', '', func('kafe_strings', 'local_str13')
			if vnesh < 20:
				'Вай, вай, вай, ты мне всех клиентов распугаешь. Сходи, что ли приоденься, косметику используй, причешись. А ты выглядишь просто страшно.'
			else
				gs 'zz_render', '', '', func('kafe_strings', 'local_str14')
				act 'Устроиться на работу':
					cla
					work = 1
					workKafe = 1
					smenaKafe = 0
					gs 'zz_render', '', '', func('kafe_strings', 'local_str15')
					act 'Отойти': gt'kafe','start'
				end
			end
			act 'Отойти': gt'kafe','start'
		end
	end
	act 'Отойти': gt'kafe','start'
end
if $ARGS[0] = 'work':
	*clr & cla
	minut += 5
	gs 'stat'
	smenaKafe += 1
	gs 'zz_render', 'Кафе', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str16')
	act 'Начать работу':
		cla
		minut = 0
		hour = 12
		gs 'npc_editor','change_rep','+', 34
		gt'kafe','workPred'
	end
	act 'Уволиться':
		cla
		work = 0
		workKafe = 0
		pay = smenaKafe*750
		money += pay
		smenaKafe = 0
		gs 'zz_render', '', '', func('kafe_strings', 'local_str17')
		act 'Уйти':gt'kafe','start'
	end
end
if $ARGS[0] = 'workPred':
	*clr & cla
	gs 'kafedinamic'
	gs 'stat'
	gs 'zz_render', 'Кафе', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str18')
	if $npc['34,relation'] > 100: $npc['34,relation'] = 100
	if $npc['34,relation'] > 90 and $npc['34,sex'] = 0: $npc['34,relation'] = 90
	if $npc['44,qwIrinaSlut'] = 1 and hour = 22:
		*clr & cla
		$npc['44,qwIrinaSlut'] = 2
		gs 'stat'
		gs 'zz_render', 'Кафе', 'images/pic/kafe.jpg', func('kafe_strings', 'local_str19')
		act 'Искать куда пропала Ира':
			*clr & cla
			horny += 10
			gs 'stat'
			gs 'zz_render', '', 'images/picKav/irinaslut.jpg', func('kafe_strings', 'local_str20')
			act 'Помочь Ире и проводить до дома':
				cla
				minut += 15
				gs 'stat'
				gs 'zz_render', '', '', func('kafe_strings', 'local_str21')
				act 'Идти домой': gt'street'
			end
			if horny >= 50:
				act 'Слизать сперму с ее зада':
					*clr & cla
					horny += 10
					minut += 15
					gs 'zz_funcs', 'cum', 'lip'
					gs 'stat'
					gs 'zz_render', '', 'images/picKav/irinaslut2.jpg', func('kafe_strings', 'local_str22')
					act 'Проглотить сперму и проводить Иру до дома':
						cla
						minut += 15
						dom -= 1
						swallow += 1
						gs 'stat'
						gs 'zz_render', '', '', func('kafe_strings', 'local_str23')
						act 'Идти домой': gt'street'
					end
					act 'Сплюнуть сперму Ире в рот':
						*clr & cla
						minut += 5
						dom += 1
						gs 'stat'
						gs 'zz_render', '', 'images/picKav/irinaslut3.jpg', func('kafe_strings', 'local_str24')
						act 'Целоваться':
							*clr & cla
							dom -= 1
							gs 'zz_render', '', 'images/picKav/irinaslut4.jpg', func('kafe_strings', 'local_str25')
							act 'Проводить Иру до дома':
								cla
								minut += 15
								gs 'stat'
								gs 'zz_render', '', '', func('kafe_strings', 'local_str26')
								act 'Идти домой': gt'street'
							end
						end
						act 'Проводить Иру до дома':
							cla
							minut += 15
							dom += 1
							swallow += 1
							gs 'stat'
							gs 'zz_render', '', '', func('kafe_strings', 'local_str27')
							act 'Идти домой':gt'street'
						end
					end
				end
			end
		end
		exit
	end
	if hour < 22:
		act 'Обслуживать столик':
			*clr & cla
			minut += 30
			znarand = RAND(0,600)
			chai = RAND(0,(vnesh + oficiant)/2)
			if oficiant < 100: oficiant += 1
			if vital < 30: vital += 1
			money += chai
			if chai = 0: manna -= 15
			gs 'stat'
			gs 'zz_render', '', 'images/picKav/waitress_client.jpg', func('kafe_strings', 'local_str28')
			act 'Отойти': gt'kafe','workPred'
			if znarand > vnesh or bfA > 0:
				kaferand = RAND(0,100)
				if kaferand = 0:
					*clr & cla
					gs 'zz_render', '', 'images/img/spaln/kafe1.jpg', func('kafe_strings', 'local_str29')
					act 'Уйти': gt'kafe','workPred'
					if daystart > 10 and sex > 0:
						act 'Присоединиться к девушке':
							kafesexrand = 1
							picrand = 13
							guy += 2
							girl += 1
							gang += 1
							xgt 'sexdvanadva','var'
						end
					end
				elseif kaferand = 1:
					*clr & cla
					gs 'zz_render', '', 'images/img/spaln/kafe2.jpg', func('kafe_strings', 'local_str30')
					act 'Уйти': gt'kafe','workPred'
					if daystart > 10 and sex > 0:
						act 'Поддаться':
							kafesexrand = 1
							picrand = 17
							guy += 2
							xgt'sexdvoe','var'
						end
					end
				elseif kaferand = 2 and vnesh >= 40:
					*clr & cla
					gs 'zz_render', '', 'images/picKav/waitress_client.jpg', func('kafe_strings', 'local_str31')
					act 'Уйти': gt'kafe','workPred'
					act 'Присесть рядом с ним':
						*clr & cla
						gs 'zz_render', '', '', func('kafe_strings', 'local_str32')
						act 'Уйти':gt'kafe','workPred'
						if horny >= 50 or bj > 0:
							act 'Расстегнуть ему ширинку':
								*clr & cla
								dick = RAND(12,20)
								gs 'stat'
								gs 'zz_render', '', 'images/picKav/waitress_work_2.jpg', func('kafe_strings', 'local_str33')
								act 'Дрочить член':
									*clr & cla
									boy += 1
									hj += 1
									money += 500
									gs 'stat'
									gs 'zz_render', '', 'images/picKav/waitress_work_hj.jpg', func('kafe_strings', 'local_str34')
									act 'Уйти': gt'kafe','workPred'
								end
								act 'Сосать член':
									*clr & cla
									boy += 1
									bj += 1
									gs 'stat'
									gs 'zz_render', '', 'images/nigma/city/cafe0,'+rand(0,2)+'.jpg'
									gs 'zz_dynamic_sex', 'bj'
									act 'Принять сперму в рот':
										*clr & cla
										money += 700
										gs 'stat'
										gs 'zz_render', '', 'common/sex/bj_cum/'+rand(0,4)+'.gif'
										gs 'zz_dynamic_sex', 'swallow'
										act 'Уйти':gt'kafe','workPred'
									end
								end
							end
						end
					end
				elseif kaferand = 3 and vnesh >= 40:
					*clr & cla
					gs 'zz_render', '', 'images/picKav/waitress_client.jpg', func('kafe_strings', 'local_str35')
					act 'Уйти':gt'kafe','workPred'
					act 'Лезть под стол':
						*clr & cla
						gs 'zz_render', '', 'images/picKav/waitress_work_3_1.jpg', func('kafe_strings', 'local_str36')
						act 'Уйти':gt'kafe','workPred'
						if horny >= 50 or bj > 0:
							act 'Отсосать':
								*clr & cla
								bj += 1
								guy += 1
								gs 'zz_render', '', 'images/picKav/waitress_work_3_2.jpg', func('kafe_strings', 'local_str37')
								act '...':
									*clr & cla
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_funcs', 'cum', 'face'
									money += 500
									gs 'stat'
									gs 'zz_render', '', 'common/sex/bj_cum/'+rand(0,4)+'.gif', func('kafe_strings', 'local_str38')
									act 'Уйти':gt'kafe','workPred'
								end
							end
						end
					end
				elseif kaferand = 4:
					*clr & cla
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'images/picKav/ivrand.jpg', func('kafe_strings', 'local_str39')
					act 'Тактично уйти':
						*clr & cla
						money += 300
						gs 'stat'
						gs 'zz_render', '', '', func('kafe_strings', 'local_str40')
						act 'Уйти': gt'kafe','workPred'
					end
					act 'Возмутиться':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', '', func('kafe_strings', 'local_str41')
						iverand = RAND(0,2)
						if iverand = 0:'Парень обозвал вас сукой и оторвав свою девушку от минета удалился из кафе не оставив ни копейки чаевых.'
						if iverand = 1:'Парень послал вас нахуй и обозвал фригидной шлюхой, после чего кончил в рот своей подруге и ушел не оставив ни копейки чаевых.'
						if iverand = 2:
							gs 'zz_render', '', '', func('kafe_strings', 'local_str42')
							act 'Выгнать их':gt'kafe','workPred'
							act 'Уйти':
								*clr & cla
								money += 500
								gs'stat'
								gs 'zz_render', '', '', func('kafe_strings', 'local_str43')
								act 'Уйти':gt'kafe','workPred'
							end
						end
						act 'Уйти':gt'kafe','workPred'
					end
					if bj > 10 and swallow > 5 and horny >= 50:
						act 'Хихикать':
							*clr & cla
							gs 'zz_render', '', '', func('kafe_strings', 'local_str44')
							act 'Тактично уйти':
								*clr & cla
								money += 300
								gs 'stat'
								gs 'zz_render', '', '', func('kafe_strings', 'local_str45')
								act 'Уйти': gt'kafe','workPred'
							end
							act 'Встать на колени перед парнем':
								*clr & cla
								bj += 1
								if SergeaAndKatjaSex = 0:SergeaAndKatjaSex = 1 & guy += 1
								gs 'zz_render', '', 'images/picKav/ivrandBJ.jpg', func('kafe_strings', 'local_str46')
								act '...':
									*clr & cla
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_funcs', 'cum', 'face'
									gs 'stat'
									gs 'zz_render', '', 'images/picKav/ivrandCUM.jpg', func('kafe_strings', 'local_str47')
									if SergeaAndKatjaQW = 0:
										SergeaAndKatjaQW = 1
										gs 'zz_render', '', '', func('kafe_strings', 'local_str48')
									end
									act 'Уйти': gt'kafe','workPred'
								end
							end
						end
					end
				elseif kaferand >= 5 and kaferand <= 24:
					*clr & cla
					horny += 5
					gs 'stat'
					gs 'zz_render', '', 'images/picKav/ivrand'+(kaferand-3)+'.jpg', func('kafe_strings', 'local_str'+(kaferand+65))
					act 'Уйти':gt'kafe','workPred'
				elseif kaferand >= 90 and opusk > 0 and pirsA = 0:
					*clr & cla
					pirsA = 1
					pirsday = day
					gs 'zz_render', '', 'images/picb/piercing/pirs.jpg', func('kafe_strings', 'local_str49')
					act 'Идти домой': gt'street'
				elseif kaferand > 25 and opusk > 0 and pirsA = 1 and hour >= 12 and hour <= 19:
					*clr & cla
					gs 'zz_render', '', '', func('kafe_strings', 'local_str50')
					act 'Залезть под стол':
						cla
						if glavar = 0: glavar = 1 & guy += 1
						bj += 1
						gs 'zz_funcs', 'cum', 'face'
						gs 'zz_render', '', 'images/pics/glavarBJ.jpg', func('kafe_strings', 'local_str51')
						gs 'zz_funcs', 'hornyrand'
						gs 'zz_render', '', '', func('kafe_strings', 'local_str52')
						act 'Вернуться к работе': gt'kafe','workPred'
					end
				end
			elseif znarand <= vnesh and bfA <= 0:
				*clr & cla
				gs 'boy'
				gs 'zz_render', '', 'images/picKav/waitress_client.jpg', func('kafe_strings', 'local_str53')
				act 'Нет':
					cla
					money += 10
					gs 'zz_render', '', '', func('kafe_strings', 'local_str54')
					act 'Отойти': gt'kafe','workPred'
				end
				if bfA <= 0 or bfB = 0 or bfC = 0:
					act 'Да':
						cla
						money += 100
						gs'boyfrend','start'
						stopboy = 0
						gs 'zz_render', '', '', func('kafe_strings', 'local_str55')
						act 'Отойти': gt'kafe','workPred'
					end
				end
			end
		end
	end
	if hour >= 22:
		act 'Собираться домой':
			cla
			if $npc['34,sex'] = 0 and $npc['34,relation'] < 90 or vnesh < 20:
				gs 'zz_render', '', '', func('kafe_strings', 'local_str56')
				act 'Уйти':
					minut += 5
					gt 'kafe','kafeend'
				end
			else
				gt 'kafedinamic','givipredlogdin'
			end
		end
	end
end
if $args[0] = 'toilet':
	*clr & cla
	act 'Уйти': gt 'kafe', 'workPred'
	i = RAND(0,100)
	if i < 3:
		gs 'zz_render', '', 'images/picKav/tuarand'+i+'.jpg', func('kafe_strings', 'local_str'+(66+i))
	else
		gs 'zz_render', '', 'images/LakeCafe/Toilet.jpg', func('kafe_strings', 'local_str57')
		gs 'zz_toilet', 'actions'
	end
end
if $ARGS[0] = 'razvod':
	cla
	deyst = RAND(0,3)
	if deyst = 0:
		gs 'zz_render', '', '', func('kafe_strings', 'local_str58')
		act 'Танцевать': gt'kafe2', 'танец'
		if horny < 75: act 'Отшить': gt'street'
	elseif deyst = 1:
		gs 'zz_render', '', '', func('kafe_strings', 'local_str59')
		act 'Выпивать': gt'kafe2', 'dance_ending', 'boy'
		if horny < 75: act 'Отшить': gt'street'
	elseif deyst = 2:
		gs 'zz_render', '', '', func('kafe_strings', 'local_str60')
		act 'Согласиться':gt'kafe2', 'dance_ending', 'company'
		if horny < 75: act 'Отшить': gt'street'
	else
		gs 'zz_render', '', '', func('kafe_strings', 'local_str61')
		act 'Согласиться':gt 'kafe3', 'туалет'
		if horny < 95:
			act 'Отшить':
				cla
				if rand(0,200) < vnesh:
					gs 'zz_render', '', '', func('kafe_strings', 'local_str62')
					act 'Согласиться':
						money += 2000
						gt 'kafe3','туалет'
					end
				else
					gs 'zz_render', '', '', func('kafe_strings', 'local_str63')
				end
				act 'Да пошел ты': gt'street'
			end
		end
	end
end
if $args[0] = 'kafeend':
	i = RAND(0,100)
	if i > 15:
		gt 'street'
	else
		horny += 5
		$zz_str[0] = 'На выходе из кафе вы увидели большую толпу молодежи решающей куда им двинуть дальше. Вы так же заметили что одна из девушек не теряя зря времени начала делать минет своему парню совершенно не смущаясь наличием посторонних.'
		$zz_str[1] = 'Выходя из кафе вы заметили машину стоящую в темноте, проходя из нее вы чутко увидели что в открытом багажнике какой-то парень жестко долбит телку, да так что аж амортизаторы скрипят и машина раскачивается. Подстилка только стонет и шепчет "Еще, еще!"'
		$zz_str[2] = 'На выходе из кафе вы увидели большую толпу молодежи решающей куда им двинуть дальше. В толпе вы с удивлением увидели как одна из девиц вылизывает киску другой не обращая внимания на окружающих.'
		$zz_str[3] = 'Выйдя из кафе вы направились домой и когда вы проходили мимо машины вы внезапно увидели как женщина сидящая на корточках делает минет довольному парню перед ней.'
		$zz_str[4] = 'Выйдя из кафе вы пошли домой и заметили как с боку от кафе трахается парочка. Девица сидела на корточках и отсасывала член парню.'
		$zz_str[5] = 'Выйдя из кафе вы направились домой и когда вы проходили мимо машины вы внезапно увидели как женщина сидящая на переднем сидении автомобиля делает минет парню причмокивая с членом во рту.'
		$zz_str[6] = 'Выходя из кафе вы заметили как между припаркованных машин сидит девица со спущенными штанами и ссыт блаженно улыбаясь.'
		$zz_str[7] = 'Выходя из кафе вы заметили какую то веселящуюся девицу которая отплясывала задирая ноги и при этом умудрялась еще и пить из стаканчика.'
		$zz_str[8] = 'Выходя из кафе вы заметили девушку лежащую на асфальте, на ней был только свитер совершенно не скрывающий ее обнаженной киски. Девушка явно была в стельку пьяная.'
		$zz_str[9] = 'Выходя из кафе вы заметили что на лавочке спят пьяные вусмерть парень с девушкой, видимо сон их настиг прямо во время петтинга подумали вы разглядывая их.'
		$zz_str[10] = 'Выходя из кафе вы заметили как какой-то мужчина средних лет и пьяная в хлам девица пытаются дотащить до машины отключившуюся девушку.'
		$zz_str[11] = 'Выходя из кафе вы заметили что прямо возле входа валяется на асфальте пьяная девушка находящаяся в отключке.'
		$zz_str[12] = 'Выходя из кафе вы заметили что пьяная девушка уснула сев жопой в урну и провалившись туда.'
		$zz_str[13] = 'Выходя из кафе вы заметили как одна девушка пытается отлепить от асфальта свою пьяную подругу которая что-то мычит и пьяно хихикает.'
		$zz_str[14] = 'Выходя из кафе вы заметили лежащую пьяную девушку без трусов.'
		$zz_str[15] = 'Выходя из кафе вы заметили как мужчина ведет куда то свою загулявшую женушку которая допилась до того что стала показывать стриптиз прямо на улице.'
		gs 'zz_render','','images/picKav/arand' + i + '.jpg', $zz_str[i]
		killvar '$zz_str'
		gs 'stat'
		act 'Уйти': gt 'street'
	end
end