! первый этаж, вход в общагу, нежилые хозяйственные помещения
$loc = $curloc
if $args[0] = '':
	*clr & cla
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',1
	gs 'zz_render','Первый этаж','city/center/university/dorm/interiors/floor1','Первый этаж общежития. За окошком проходной вечно дремлет пожилая тётка-"привратница". Они меняются, но все на одно лицо.
	На этаже находится общая душевая, но <b>горячая вода</b> бывает только <b>по графику</b> - с <b>6</b> до <b>9</b> утра и с <b>17</b> до <b>24</b> вечера.'
	if (hour >= 6 and hour <= 9) or hour >= 17: act 'Душевая': gt 'uni_dorm','bathroom'
	if hour >= 7 and hour <= 17: act 'Прачечная': gt 'uni_dorm','laundry'
end
if $args[0] = 'navigation':
	_dorm_cur_floor = args[1]
	if _dorm_cur_floor < 1: _dorm_cur_floor = 1
	act '<b>В студгородок</b>': minut += 5 & gt 'uni_campus'
	if _dorm_cur_floor ! 1: act 'Первый этаж': gt 'uni_dorm'
	if _dorm_cur_floor ! 2: act 'Второй этаж': gt 'uni_dorm','2'
	if _dorm_cur_floor ! 3: act 'Третий этаж': gt 'uni_dorm','3'
	if _dorm_cur_floor ! 4: act 'Четвертый этаж': gt 'uni_dorm','4'
	if _dorm_cur_floor ! 5: act 'Пятый этаж': gt 'uni_dorm','5'
	killvar '_dorm_cur_floor'
end
!---
if $args[0] = 'laundry':
	*clr & cla
	$metka = $args[0]
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_render','','city/center/university/dorm/interiors/laundry'
	act '<b>Выйти</b>': gt 'uni_dorm'
	if hour < 7 or hour > 17: exit
	if $npc['50,mainQW'] >= 5 and $npc['50,mainQW_day'] ! day and rand(0,2) = 0: gt 'npc_veronika','veronika_ev2'
end
! душевая
if $args[0] = 'bathroom':
	*clr & cla
	$metka = $args[0]
	minut += rand(1,3)
	gs 'stat'
	act '<b>Выйти</b>': gt 'uni_dorm'
	if hour < 6 or (hour > 9 and hour < 16): exit
	! запуск ивента с Айгуль
	if hour >= 17 and $npc['49,mainQW'] >= 3 and $npc['49,mainQW'] <= 5 and $npc['49,mainQW_day'] ! day: gt 'npc_algul','algyl_ev4'
	gt 'zz_bathroom','init','uni_dorm',''
	exit
end
!---
if $args[0] = '2':
	*clr & cla
	$metka = $args[0]
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',2
	gs 'zz_render','Второй этаж','city/center/university/dorm/interiors/floor','Второй этаж общежития. Здесь живут "азиаты" - вьетнамцы, корейцы. Они там живут по каким-то своим правилам и посторонних к себе не пускают. Готовят они себе как правило сами - запахи несутся странные и не всегда приятные. Вставить рандомно ивенты с готовкой селедки и собачатины.'
	if hour = 18: gs 'zz_render','','','Возле кухни на непонятном для вас языке болтает компания азиатских студентов.'
	! комнаты
end
!---
if $args[0] = '3':
	*clr & cla
	$metka = $args[0]
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',3
	gs 'zz_render','Третий этаж','city/center/university/dorm/interiors/floor','Третий этаж общежития. "Африка". Тут живут африканские студенты. Посторонних они не любят. Ходят слухи, что тут всегда можно закупиться дурью.'
	if hour = 17: gs 'zz_render','','','Возле самодельной качалки как всегда трутся огромные чёрные "качки".'
	! типа качалка
	act 'Качалка':
		*clr & cla
		gs 'zz_render','','city/center/university/dorm/interiors/fit','Самодельная качалка, обустроенная в общей комнате на этаже. Никаких изысков, только хардкор - сборные гантели, несколько гирь, самодельная штанга и пара кое-как сколоченных лавочек-опор. Может, эти африканцы и принцы там у себя, но в универе экономят.'
		act 'Тягать железо':
			*clr & cla
			minut += rand(20,40)
			stren += iif(stren > 60,1,rand(1,2))
			gs 'zz_funcs','sport'
			gs 'stat'
			gs 'zz_render','','city/center/university/dorm/misc/fit','Под смешки африканской диаспоры вы начали тренировку - сначала разминка с гантелями, потом пришло время штанги.'
			if stren > 80:
				gs 'zz_render','','','Решив показать этим абизьянам, что вы далеко не слабачка, вы накинули два больших блина и без особых проблем взяли вес.'
			else
				gs 'zz_render','','','Решив показать этим чёрным рожам, что вы далеко не слабачка, вы накинули два больших блина, но вес так и не взяли, почти выжав, но руки прослабли. Парни подскочили, увидев, что штангу вы не удерживаете и "ща на грудак уронит" - и подхватили, поставив гриф на стойку.
				"Черт, надо больше тренироваться" - краснея, сползли вы с лавки.
				\\\- Не ссы/// - гыкнул самый огромный качок: \\\- хорощьё - ничъего не порвала! А что пьёрнула от натуга - ни страшьно!///
				Вы, с трудом отдышавшить, улыбаетесь от такого грубого, но доброго подбадривания.'
			end
			act 'Уйти': gt 'uni_dorm','3'
		end
		act 'Уйти': gt 'uni_dorm','3'
	end
	! комнаты
	if $npc['47,know'] = 1: act 'Комната Демаркуса': gt 'npc_demarkus','dorm_room'
end
!---
if $args[0] = '4':
	*clr & cla
	$metka = $args[0]
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	gs 'uni_dorm','navigation',4
	gs 'zz_render','Четвертый этаж','city/center/university/dorm/interiors/floor','Четвертый этаж общежития. Страны СНГ.'
	if hour = 20:
		gs 'zz_render','','','Как всегда, по вечерам собирается компания ребят поиграть на гитаре и попеть песен.'
	end
	! комнаты
end
!---
if $args[0] = '5':
	*clr & cla
	$metka = $args[0]
	minut += rand(1,3)
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	!---
	! автозапуск ивентов с Айгуль
	!---
	if hour >= 17 and hour <= 21 and $npc['49,mainQW_day'] ! day:
		if $npc['49,mainQW'] >= 3 and $npc['49,mainQW'] <= 5:
			if rand(0,2) = 0: gt 'npc_algul',iif(rand(0,1) = 0,'algyl_ev5','algyl_ev6')
		end
		if rand(0,1) = 1:
			if $npc['49,mainQW'] = 20: gt 'npc_algul','algyl_ev10'
			if $npc['49,mainQW'] = 25: gt 'npc_algul','algyl_ev11'
			if $npc['49,mainQW'] = 30: gt 'npc_algul','algyl_ev12'
		end
	end
	!---
	gs 'uni_dorm','navigation',5
	gs 'zz_render','Пятый этаж','city/center/university/dorm/interiors/floor','Пятый этаж общежития. Здесь комната Светы.'
	! комнаты
	act '<font color=maroon>Комната Светы</font>': gt 'uni_dorm','gg_room'
	if $npc['49,mainQW'] > 0 and $npc['49,mainQW'] < 255:
		act '<font color=maroon>Комната Айгуль</font>':
			if hour <= 15 and hour >= 23:
				gs 'zz_render','','','Никто не открывает!'
				exit
			else
				gt 'npc_algul'
			end
		end
	end
	! дополнительные ивенты
	if hour >= 20 and hour <= 23:
		! футбол
		if ((month >= 9 and month <= 11) or (month >= 3 and month <= 5)) and week = 3 and hour >= 22:
			gs 'zz_render','','','Среда - футбольный день, сегодня в холле возле телевизора собралась большая компания посмотреть матч Лиги Чемпионов.'
			act 'Смотреть футбол':
				*clr & cla
				gs 'zz_render','','city/center/university/dorm/misc/tv','\\\-Светик, ты за кого?/// - спросил кто-то с парней, явно пытаясь подшутить над вами.'
				! если ГГ спортсменка - ставим в ответ название одного из клубов, если нет - по цвету формы
				if achiev['start'] = 3:
					gs 'zz_render','','','\\- За ' + func('zz_funcs','get_item_string','Челси,МЮ,Барсу,Реал,Баварию,Атлетико,Сити,Динамо,Зенит,Юве,Порту,ПСЖ,Милан,Лион',-1) + '!// - ответили вы под радостные возгласы одной части и разочарование другой.'
				else
					gs 'zz_render','','','\\- За ' + func('zz_funcs','get_item_string','белых,красных,синих,зеленых,голубых,наших',-1) + '// - совершенно не разбираясь в командах, ответили вы, отчего все пацаны дружно заржали, но все же освободили вам место.'
				end
				act '<b>Уйти</b>': gt 'uni_dorm','5'
				act '<b>Досмотреть матч и уйти</b>':
					minut += 24*60 - (hour*60 + minut)
					manna += rand(5,10)
					gt 'uni_dorm','5'
				end
			end
		else
			gs 'zz_render','','','Небольшая компания смотрит какой-то старый голливудский боевик.'
			act 'Смотреть фильм':
				*clr & cla
				minut += 90
				manna += rand(10,15)
				gs 'stat'
				gs 'zz_render','','city/center/university/dorm/misc/tv','Фильм хоть и старый, но в компании смотрится весело и интересно. Вы и не поняли, как пролетело полтора часа.'
				act '<b>Уйти</b>': gt 'uni_dorm','5'
			end
		end
	end
	if hour = 19:
		gs 'zz_render','','','Возле окна курит разношёрстная компания.'
		act 'Покурить в компании':
			*clr & cla
			minut += rand(5,15)
			gs 'stat'
			gs 'zz_render','','city/center/university/dorm/misc/smoke','Вы стрельнули сигаретку и весело поболтали с ребятами, потягивая едкий дым.'
			act '<b>Уйти</b>': gt 'uni_dorm','5'
		end
	end
end
!---
if $args[0] = 'kitchen':
	*clr & cla
	$metka = $args[0]
	gs 'zz_render','','city/center/university/dorm/interiors/kitchen'
	act 'В коридор': gt 'uni_dorm','5'
	gs 'zz_kitchen_acts', 'all', 1
	if eda + edaD > 0:
		gs 'zz_render','','','В холодильнике хранится <b><<eda>></b> порций еды, а также <b><<edaD>></b> диетических продуктов.'
	else
		gs 'zz_render','','','<red>В холодильнике шаром покати, вообще нечего есть.</red>'
	end
end
!---
! комната Светки
if $args[0] = 'gg_room':
	*clr & cla
	$metka = $args[0]
	gs 'stat'
	gs 'zz_funcs','colorize_day'
	$_veronika_loc = func('npc_veronika','check')
	! знакомство с соседкой по комнате
	if $npc['50,mainQW'] = 0: gt 'npc_veronika','veronika_ev1'
	! автозапуск ивентов Вероники
	if $npc['50,mainQW_day'] ! day and rand(0,2) = 0 and $_veronika_loc = 'room':
		if $npc['50,mainQW'] = 5: gt 'npc_veronika','veronika_ev2'
		if $npc['50,mainQW'] = 15: gt 'npc_veronika','veronika_ev4'
		if $npc['50,mainQW'] = 20: gt 'npc_veronika','veronika_ev8'
		if $npc['47,know'] = 1 and $npc['50,mainQW'] = 35: gt 'npc_veronika','veronika_ev8'
	end
	!--
	gs 'zz_render','','city/center/university/dorm/interiors/rooms/your','Это ваша комната, вместе с вами живет девушка Вероника.**Сразу возле двери стоит <a href="exec:GT ''loker'',''start''">шкаф</a>. На стене, возле шкафа висит <a href="exec:GT ''mirror'',''start''">зеркало</a>. Возле стенки стоит ваша <a href="exec:GT ''bed'',''start''">кровать</a>.'
	if komp = 1: gs 'zz_render','','','На кровати валяется ваш <a href="exec:GT ''Komp'',''start''">ноутбук</a>.'
	act '<b>В коридор</b>':
		if cloth[0] > 2:
			minut += 5
			gt 'uni_dorm','5'
		else
			gs 'zz_render','','','<red>Вам надо одеться!</red>'
			exit
		end
	end
	if hour >= 6 and hour <= 8:
		act 'Сделать зарядку':
			*clr & cla
			minut += rand(20,30)
			gs 'stat'
			act 'Закончить': gt 'uni_dorm','gg_room'
			gs 'zz_render','','city/center/university/dorm/veronika/events1/43.jpg','Почти полчаса вы разминаетесь у своей кровати.'
			if $_veronika_loc = 'room' and sunWeather >= 0:
				cla
				gs 'zz_render','','','Уже почти закончив разминку, вы почувствовали на себе взгяд Вероники.'
				act 'Повернуться': gt 'npc_veronika','veronika_ev6'
			end
		end
	end
	if $_veronika_loc = 'sleep':
		gs 'zz_render','','','После ночных похождений в своей кроватке мирно спит Вероника.'
	elseif $_veronika_loc = 'room':
		gs 'zz_render','','','На своей кровати валяется ваша соседка <a href="exec:gt''npc_veronika'',''talk''">Вероника</a>.'
	elseif $_veronika_loc = 'room_dressing':
		if $npc['0,brothelQW'] >= 5 and $npc['0,brothelQW'] < 25 and anus >= 15 and vagina >= 15:
			act 'Попросить взять с собой':
				$npc['50,mainQW_day'] = day
				gt 'npc_veronika',iif($npc['0,brothelQW']=5,'veronika_ev12','veronika_ev13')
			end
		end
		gs 'zz_render','','','Возле шкафа одевает беленькие чулки ваша соседка <a href="exec:gt''npc_veronika'',''talk''">Вероника</a>.'
	end
	killvar '$_veronika_loc'
end