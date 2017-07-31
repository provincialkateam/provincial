! Pharmacy
!
!=====================
!Переменные глобальные
! AptekaDay[NUM] - Флаг обновления остатков в аптеке NUM
! AptekaStore['NUM,ITEM'] Остаток товара Item в аптеке NUM
!
! OluQW - уровень запуска квеста с Олу обычный
! OluAltQW - уровень альтстарта запуска квеста с Олу (Мать должна быть не в курсе, это секрет ГГ и Тетки, секс возможен только ОС, АС)
! старт при значении 100 или более
!читы для отладки
SeeBalance = 0 & SeeTable = 0
!:01*****************************************************************************************
! Масивы о товарах ценах и инструкциях будут
! создаваться каждый раз как игрок заходит в аптеку
$init_apteka = {
RealQuantity = 0 & MaxQuantity = 0 & MaxCost = 0
$prt_str_mem[0]='1' & ! в ячейке 0 храним позицию свободную для записи
$prt_str_scr[0]='1' & ! в ячейке 0 храним позицию свободную для записи
!Наименование товаров
$Apt_PriceList[0] = 'Презервативы'
$Apt_PriceList[1] = 'Тест на беременность'
$Apt_PriceList[2] = 'Противозачаточные таблетки'
$Apt_PriceList[3] = 'Витамины'
$Apt_PriceList[4] = 'Лекарства'
$Apt_PriceList[5] = 'Мазь от мозолей'
$Apt_PriceList[6] = 'Увлажняющий бальзам для губ'
$Apt_PriceList[7] = 'Жиросжигатели'
$Apt_PriceList[8] = 'Таблетки от молочницы'
$Apt_PriceList[9] = 'Лубрикант'
!Имя коплекта
$Apt_PriceKomplN[0] = 'упаковок'
$Apt_PriceKomplN[1] = 'упаковок'
$Apt_PriceKomplN[2] = 'упаковок'
$Apt_PriceKomplN[3] = 'упаковок'
$Apt_PriceKomplN[4] = 'упаковок'
$Apt_PriceKomplN[5] = 'тюбиков'
$Apt_PriceKomplN[6] = 'тюбиков'
$Apt_PriceKomplN[7] = 'капсул'
$Apt_PriceKomplN[8] = 'штук'
$Apt_PriceKomplN[9] = 'тюбиков'
!Цены товаров
Apt_PriceCost[0] = 100
Apt_PriceCost[1] = 200
Apt_PriceCost[2] = 500
Apt_PriceCost[3] = 500
Apt_PriceCost[4] = 500
Apt_PriceCost[5] = 600
Apt_PriceCost[6] = 1000
Apt_PriceCost[7] = 1500
Apt_PriceCost[8] = 1500
Apt_PriceCost[9] = 300
!Штук в комплекте
Apt_PriceKompl[0] = 5
Apt_PriceKompl[1] = 2
Apt_PriceKompl[2] = 28
Apt_PriceKompl[3] = 20
Apt_PriceKompl[4] = 10
Apt_PriceKompl[5] = 10
Apt_PriceKompl[6] = 25
Apt_PriceKompl[7] = 1
Apt_PriceKompl[8] = 1
Apt_PriceKompl[9] = 5
!Описание товаров
$Apt_PriceDescript[0] = '<center><b><<$Apt_PriceList[0]>></b></center><br>Средство контрацепции барьерного типа, а также средство защиты от многих патогенов, передающихся половым путём. Презервативы вторично использовать нельзя.<br><br><center>В упаковке <<Apt_PriceKompl[0]>> шт.</center>'
$Apt_PriceDescript[1] = '<center><b><<$Apt_PriceList[1]>></b></center><br>Экспресс-тест позволяющий определить признаки беременности женщины на ранней стадии. Тест-полоску можно использовать только один раз.<br><br><center>В упаковке <<Apt_PriceKompl[1]>> шт.</center>'
$Apt_PriceDescript[2] = '<center><b><<$Apt_PriceList[2]>></b></center><br>Комбинированные оральные контрацептивы на основе эстрогена и прогестина.<br>Применение: ежедневно по одной таблетке в день.<br><br><center>В упаковке <<Apt_PriceKompl[2]>> таблеток в блистере</center>'
$Apt_PriceDescript[3] = '<center><b><<$Apt_PriceList[3]>></b></center><br>Комплексное решение для вашего здоровья и поддержания имунитета. Помогют увеличить эффективность антибиотиков и противогрипковых препаратов. Противопоказаний нет.<br>Применение: по одной таблетки в день.<br><br><center>В упаковке <<Apt_PriceKompl[3]>> таблеток в блистере</center>'
$Apt_PriceDescript[4] = '<center><b><<$Apt_PriceList[4]>></b></center><br>Антибиотики. Необходимо принимать во время простудных заболеваний, хорошо помогает сократить процесс лечения и улучшает здоровье. При отсутствии болезни неэффективны.<br>Применение: по одной таблетке в день.<br><br><center>В упаковке <<Apt_PriceKompl[4]>> таблеток в блистере</center>'
$Apt_PriceDescript[5] = '<center><b><<$Apt_PriceList[5]>></b></center><br>Пока не работает. В будущем на этом месте будет супер лекарство от ран. А пока можно не покупать, даже в прок.<br><br><center>Тюбик, хватит на <<Apt_PriceKompl[5]>> применений</center>'
$Apt_PriceDescript[6] = '<center><b><<$Apt_PriceList[6]>></b></center><br>Бальзам увлажняет губы, придает им блеск, тем самым увеличивает привлекательность губ. Есть побочные эффекты: при постоянном использовании необратимо увеличивает губы.<br><br><center>Тюбик, хватит на <<Apt_PriceKompl[6]>> применений</center>'
$Apt_PriceDescript[7] = '<center><b><<$Apt_PriceList[7]>></b></center><br>Средство для сжигания жира, действует в течение Х дней с момента приема. Интенсивные физические нагрузки, например бег, значительно увеличивают эффективность препарата.<br><br><center>В упаковке <<Apt_PriceKompl[7]>> ядреная капсула</center>'
$Apt_PriceDescript[8] = '<center><b><<$Apt_PriceList[9]>></b></center><br>Весьма эффективное средство. Действует мнгновенно, можно даже не запивать водой. Принимайте сразу как окажется в руках.<br>Рекомендуется так же пропить курс витаминов.<br><br><center>В упаковке <<Apt_PriceKompl[8]>> шт.</center>'
$Apt_PriceDescript[9] = '<center><b><<$Apt_PriceList[10]>></b></center><br>Гель-смазка защищает слизистую оболочку от появления микротрещин и раздражения, через которые проникают инфекции, снимает болевые ощущения и повышает комфорт. Лубрикант не имеет противопоказаний к применению.<br><br><center>Тюбик, хватит на <<Apt_PriceKompl[5]>> применений</center>'
!Условие выполнится (должно) один раз за всю игру при первом входе в любую аптеку
!устанавливаются базовые лимиты на максимальное количество доступное к покупке
if AptekaDay[0] = 0 :
	AptekaDay[0] = 1
	AptekaStore['0,0']=10
	AptekaStore['0,1']=2
	AptekaStore['0,2']=10
	AptekaStore['0,3']=10
	AptekaStore['0,4']=10
	AptekaStore['0,5']=10
	AptekaStore['0,6']=4
	AptekaStore['0,7']=6
	AptekaStore['0,8']=1
	AptekaStore['0,9']=10
end
!Если были раньше, то "завозим" товар
if AptekaDay[AptekaNum] <> iif(daystart=0,-1,daystart):
	!В этой аптеке "давно" не были
	AptekaDay[AptekaNum] = iif(daystart=0,-1,daystart)
	!Все аптеки кроме Павлово (AptekaNum=1) должны иметь и имеют больший товарный запас
	AptekaStore['<<AptekaNum>>,0'] = RAND(5, AptekaStore['0,0']) + iif(AptekaNum > 1, 10, 0)
	AptekaStore['<<AptekaNum>>,1'] = RAND(1, AptekaStore['0,1']) + iif(AptekaNum > 1,  2, 0)
	AptekaStore['<<AptekaNum>>,2'] = RAND(5, AptekaStore['0,2']) + iif(AptekaNum > 1, 10, 0)
	AptekaStore['<<AptekaNum>>,3'] = RAND(5, AptekaStore['0,3']) + iif(AptekaNum > 1, 10, 0)
	AptekaStore['<<AptekaNum>>,4'] = RAND(5, AptekaStore['0,4']) + iif(AptekaNum > 1, 10, 0)
	AptekaStore['<<AptekaNum>>,5'] = RAND(5, AptekaStore['0,5']) + iif(AptekaNum > 1, 10, 0)
	AptekaStore['<<AptekaNum>>,6'] = RAND(2, AptekaStore['0,6']) + iif(AptekaNum > 1,  4, 0)
	AptekaStore['<<AptekaNum>>,7'] = RAND(2, AptekaStore['0,7']) + iif(AptekaNum > 1,  6, 0)
	AptekaStore['<<AptekaNum>>,8'] = AptekaStore['0,8']	& !но сделаем для работы циклов
	AptekaStore['<<AptekaNum>>,9'] = RAND(5, AptekaStore['0,9']) + iif(AptekaNum > 1, 10, 0)
end
}
!Чистка памяти
$close_apteka = {
	! Переменные покупок
	killvar 'RealQuantity' & killvar 'MaxQuantity' & killvar 'MaxCost'
	! Массивы описания товаров
	killvar '$Apt_PriceList' & killvar '$Apt_PriceKomplN' & killvar 'Apt_PriceCost' & killvar 'Apt_PriceKompl' & killvar '$Apt_PriceDescript'
	! Массивы вывода на экран диалогов
	killvar '$prt_str_mem' & killvar '$prt_str_scr'
}
!:02*****************************************************************************************
!Формирование чистого экрана с картинкой и заголовком
!ARGS 0 - заголовок 1 - имя файла с картинкой
$din_AptekaScreen = {*clr & *PL '<center><b><font color = maroon>'+$ARGS[0]+'</font></b><br><img src="'+$ARGS[1]+'"><br></center>'}
!Вспомогательная, вывод описания ARGS0 = номер позиции в прайсе
$din_APT0 = {$result = '<a href="exec: MSG $Apt_PriceDescript[<<ARGS[0]>>]"><img src="images/qwest/apteka/anptekainfo.jpg"></a>'}
!Вспомогательная, покупка, ARGS0 = номер позиции в прайсе
$din_APT1 = {$result = '<a href="exec: dynamic $din_BuyInApteka, <<ARGS[0]>>">Купить</a>'}
!Формирование таблицы прайса
$din_AptekaPriceTable = {
!Таблица расчитана на 14 товарных позиций, больше не считал т.к. на момент создания кода товаров всего 11 видов (0-10)
!Строки в цикле считаются в обратном порядке и их больше row на 2 единицы, чем товаров, если товаров меньше 14
!Потому что первая строка это заголовок, последняя пустая добавляется для "красоты" отображения товаров
!При 14 и более товарных позициях последняя пустая строка не нужна, она не будет добавлятся при MaxItem =>14
$table = ''  & !текст таблицы
item = -1	& !позиция прайса, минус один т.к. первым выйдет заголовок
MaxItem = 10 & !действующее максимальное количество строк с товаром
row = MaxItem + iif(MaxItem < 14, 2, 1) & ! задано кол-во строк таблицы
MaxRow = row & !под картинку с продавцом
!Рисуем таблицу
:loop_row & ! строки
	! открываем строчку
	if row = MaxRow :
		$table += '<tr align="center">'
	else
		$table += '<tr>'
	end
	if item < MaxItem :
		if row = MaxRow :
			!Заголовок таблицы
			$table += '<td rowspan="<<MaxRow>>">  <img src="images/qwest/apteka/apteka_worker_<<AptekaNum>>.jpg">  </td>'
			$table += '<th colspan="2"> Наименование</th>'
			$table += '<th>Цена</th>'
			$table += '<th>*</th>'
			if SeeBalance = 1 : $table += '<th>Ост.</th>'
		else
			!Основная часть таблицы
			$table += '<td align="center"><<DYNEVAL($din_APT0, item)>></td>'
			$table += '<td align="left"><<$Apt_PriceList[item]>></td>'
			$table += '<td align="right"><<Apt_PriceCost[item]>> руб.</td>'
			$table += '<td align="center"><<DYNEVAL($din_APT1, item)>></td>'
			if SeeBalance = 1 :
				apt_ostatok = 0 & apt_ostatok = AptekaStore['<<AptekaNum>>,<<item>>']
				$table += '<td align="right"><<apt_ostatok>></td>'
			end
		end
	else
		!если позиций в прайсе меньше, чем высота картинки 14 добавляем пустую строку для красоты таблицы
		if item = MaxItem and MaxItem < 14 : $table += '<td></td><td></td><td></td><td></td>' + iif(SeeBalance = 1, '<td></td>', '')
  	end
	! закрываем строчку
	$table += '</tr>' & row -= 1 & item  += 1
if row > 0: jump 'loop_row'
*pl '<center><table border="<<SeeTable>>">' + $table + '</table></center>'
killvar '$table' & killvar 'row' & killvar 'item' & killvar 'MaxItem' & killvar 'MaxRow' & killvar 'apt_ostatok'
}
!Вычисляем сумму к покупке, если возврат 0 покупки не будет
!ARGS 0 - номер позиции, 1 - количество к покупке
$din_BuyInAptekaSum = {
	!Вычисляем стоимость покупки
	MaxCost =  Apt_PriceCost[ARGS[0]] * ARGS[1]
	!Приоритет наличка, на второе пластик
	if money => MaxCost :
		money -= MaxCost
	else
		if karta => MaxCost :
			karta -= MaxCost
			dynamic $din_AptekaTextPrint, 1 ,  'Вы оплатили банковской картой т.к. у вас недостаточно наличности для оплаты покупки.'
		else
			MaxCost = 0
		end
	end
	!Сумма покупки и флаг сделки
	result = iif(MaxCost > 0, MaxCost , 0)
}
!Вычисляем сумму к покупке, если возврат 0 покупки не будет
!ARGS 0 - номер позиции
$din_BuyInApteka = {
	!Обнуляем количество, сумму и запрос пользователя
	MaxQuantity = 0 & MaxCost = 0 & RealQuantity = 0
	if ARGS[0] = 8 :
		if KandidNapr = 0 or Kandidoz <= 30:
			dynamic $din_AptekaTextPrint, 1 , 'У вас нет молочницы. Как появится тогда и купите таблетки.' & jump 'EndBuyInApteka'
		else
			MaxQuantity = 1
		end
	end
	! Если количество не известно, спрашиваем, если будет больше остатка будет повод поговорить
	if MaxQuantity = 0 : MaxQuantity = input ($Apt_PriceList[ARGS[0]]+'. Сколько '+$Apt_PriceKomplN[ARGS[0]]+' вы хотите купить?')
	:Quantity
	if MaxQuantity > 0 :
		! Запомним сколько просил пользователь в начале
		if RealQuantity = 0 : RealQuantity = MaxQuantity
		! Если запрашиваемое кол-во больше, чем есть в аптеке,
		if MaxQuantity > AptekaStore['<<AptekaNum>>,<<ARGS[0]>>'] :
			if AptekaNum = 1 :
				! Врезка для квестов в Павлово
				! Презики
				!'"Лучше не покупать сразу много, а то тетя может что-то заподозрить."'
				!'"<<$name[1]>>, завод резиновых изделий не успевает поставлять продукцию."'
				! Лубрикант
				!'"<<$name>>, могу продать только'+AptekaStore['<<AptekaNum,ARGS[0]>>']+' штук, больше не привезла, извини."'
				!'Вы подождали своей очереди и подошли к прилавку, кивком указав на нужную витрину. "Все раскупили, <<$name>>, - сказала тетя. И с ехидством почти шепотом добавила, - Придется твоим ебарям ждать до завтра."'
				!'Вы подождали своей очереди и подошли к прилавку. "Все раскупили, <<$name>>, - сказала тетя. И с ехидством почти шепотом добавила, - Придется твоим ебарям ждать до завтра."'
			end
			! Уменьшим запрос пользователя до фактических остатков и шаг назад
			MaxQuantity = AptekaStore['<<AptekaNum>>,<<ARGS[0]>>'] & jump 'Quantity'
		end
		!Количество норм, надо проверить деньги - $din_BuyInAptekaSum
		if dyneval( $din_BuyInAptekaSum, ARGS[0], MaxQuantity) > 0 :
			!Мы здесь деньги списаны, надо забрать покупки
			AptekaStore['<<AptekaNum>>,<<ARGS[0]>>'] -= MaxQuantity
			if ARGS[0] = 0 :
				!Презервативы
				prezik += MaxQuantity * Apt_PriceKompl[ARGS[0]]
				if AptekaNum = 1 :
					! если павлово звонок маме на принудительное обследование
					! при условии, что мать не в курсе о положении дел
					! даже если денег на покупку не хватит
					!
				end
			elseif ARGS[0] = 1 :
				!Тест на беременность
				pregtest += MaxQuantity * Apt_PriceKompl[ARGS[0]]
				if AptekaNum = 1 :
					! если павлово звонок маме на принудительное обследование
					! при условии, что мать не в курсе о положении дел
					! даже если денег на покупку не хватит
					!
				end
			elseif ARGS[0] = 2 :
				!Противозачаточные таблетки
				tabletki += MaxQuantity * Apt_PriceKompl[ARGS[0]]
				if AptekaNum = 1 :
					! если павлово звонок маме на принудительное обследование
					! при условии, что мать не в курсе о положении дел
					! даже если денег на покупку не хватит
					!
				end
			elseif ARGS[0] = 3 :
				!Витамины
				vitamin += MaxQuantity * Apt_PriceKompl[ARGS[0]]
			elseif ARGS[0] = 4 :
				!Лекарства
				lekarstvo += MaxQuantity * Apt_PriceKompl[ARGS[0]]
			elseif ARGS[0] = 5 :
				!Мазь от мозолей
				mosolmaz += MaxQuantity * Apt_PriceKompl[ARGS[0]]
			elseif ARGS[0] = 6 :
				!Увлажняющий бальзам для губ
				lipbalm += MaxQuantity * Apt_PriceKompl[ARGS[0]]
			elseif ARGS[0] = 7 :
				!Жиросжигатели
				fatdel += MaxQuantity * Apt_PriceKompl[ARGS[0]]
			elseif ARGS[0] = 8 :
				!Таблетки от молочницы
				Kandidoz = 0
			elseif ARGS[0] = 9 :
				!Лубрикат
				lubri += MaxQuantity * Apt_PriceKompl[ARGS[0]]
				if OluQW = 0 :
					if OluAltQW < 100 :
						OluAltQW += RAND(iif(MaxQuantity <= 10, 1, 5), MaxQuantity)
					elseif OluAltQW => 100
						! Надо поговорить, предложить ГГ помочь с Олу
					end
				end
			end
		end
		!обычный вывод резульатов покупок
		if MaxQuantity > 0 and MaxCost > 0 :
			!поздраввляем с покупкой
			dynamic $din_AptekaTextPrint, 1 , 'Вы купили <<$Apt_PriceList[ARGS[0]]>> - <<MaxQuantity>> <<$Apt_PriceKomplN[ARGS[0]]>>' + iif(RealQuantity > MaxQuantity, ' (это все что было в аптеке)','') + ', и заплатили <<MaxCost>> рублей.'
			if args[0] = 8 : dynamic $din_AptekaTextPrint, 1 , 'Сразу же около кассы вы приняли таблетку от молочницы'
		elseif MaxQuantity > 0 and MaxCost = 0 :
			!нет денег ни на карте, ни в кармане
			dynamic $din_AptekaTextPrint, 1 , 'Вы не можете купить <<$Apt_PriceList[ARGS[0]]>> - <<MaxQuantity>> <<$Apt_PriceKomplN[ARGS[0]]>>' + iif(RealQuantity > MaxQuantity , ' (это все что было в аптеке)','') + ' - у вас не хватает денег.'
		end
	else
		if RealQuantity > 0 and AptekaStore['<<AptekaNum>>,<<ARGS[0]>>'] = 0:
			!товара нет
			dynamic $din_AptekaTextPrint, 1 ,  'Вы не можете купить <<$Apt_PriceList[ARGS[0]]>> - в аптеке нет этого товара, приходите завтра'
		end
	end
:EndBuyInApteka
minut += 1 & gs 'stat'
gt 'apteka', 'work', 1
}
!:03*****************************************************************************************
! режим 0 выводит текст на экран
! режим 1 добавляет строку $args в массивы и выводит текст на экран
! режим 2 показ истории строк текущего посещения аптеки
$din_AptekaTextPrint = {
	! размер экрана 10 строк, памяти 100 строк
	max_num_str_scr = 10 & max_num_str_mem = 100
	if args[0] = 1:
		!Готовим переменные номеров строк
		num_str_scr = 0 & num_str_mem = 0
		num_for_loop = 0 & !счетчик циклов
		!Добавление новой строки экран
		num_str_scr = val($prt_str_scr[0])
		if num_str_scr = (max_num_str_scr + 1) :
			!Нужен сдвиг
			num_for_loop = 2
			:Scr_arr_move
			if num_for_loop <= max_num_str_scr :
				!Начало со строки 2, до строки 10, строка 10 должна освободится
				$prt_str_scr[num_for_loop  - 1] = $prt_str_scr[num_for_loop]
				num_for_loop += 1 & jump 'Scr_arr_move'
			end
			num_str_scr = max_num_str_scr
		end
		$prt_str_scr[num_str_scr] = $args[1]
		num_str_scr += 1 & $prt_str_scr[0] = '<<num_str_scr>>'
		!Добавление новой строки память
		num_str_mem = val($prt_str_mem[0])
		if num_str_mem = (max_num_str_mem + 1) :
			!Нужен сдвиг
			num_for_loop = 2
			:Mem_arr_move
			if num_for_loop <= max_num_str_mem :
				!Начало со строки 2, до строки 100, строка 100 должна освободится
				$prt_str_mem[num_for_loop  - 1] = $prt_str_mem[num_for_loop]
				num_for_loop += 1 & jump 'Mem_arr_move'
			end
			num_str_mem = max_num_str_mem
		end
		$prt_str_mem[num_str_mem] = iif(hour < 10 , '0' , '') + '<<hour>>:' + iif(minut < 10 , '0', '') + '<<minut>> - ' + $args[1]
		num_str_mem += 1 & $prt_str_mem[0] = '<<num_str_mem>>'
	end
	num_for_loop = 1
	if args[0] = 2 :
		:MemPrintString
		if num_for_loop <= min(max_num_str_mem, val($prt_str_mem[0])) :
			*PL '<<$prt_str_mem[num_for_loop]>>'
			num_for_loop += 1 & jump 'MemPrintString'
		end
	else
		:ScrPrintString
		if num_for_loop <= min(max_num_str_scr, val($prt_str_scr[0])) :
			*PL '<<$prt_str_scr[num_for_loop]>>'
			num_for_loop += 1 & jump 'ScrPrintString'
		end
	end
	killvar 'max_num_str_scr' & killvar 'max_num_str_mem'
	killvar 'num_str_scr' & killvar 'num_str_mem' & killvar 'num_for_loop'
}
!:04*****************************************************************************************
!====================
! Здесь начинаем Вход
!====================
if $ARGS[0] = 'start' :
	*clr & cla
	gs 'zz_funcs', 'colorize_day'
	minut += 5 & ! Время до аптеки
	gs 'stat' & ! Обновим информацию о прошедшем времени
	!ограничение по времени работы аптеки в Павлово
	if $loc = 'gorodok' and (hour < 8 or hour > 20) : gt 'apteka', 'stop', 1
	!1-павлово, 2-Южный р-н, 3-резерв, 0 быть не должен
	AptekaNum = 0
	AptekaNum = iif($loc = 'gorodok', 1 , iif($loc = 'street', 2, iif($loc = 'nord', 3, 4)))
	dynamic $init_apteka & !Готовим переменные
	people = RAND(0,5) & !Определим размер очереди в аптеке
	if people > 0 :
		dynamic $din_AptekaScreen, 'Аптека', 'images/qwest/apteka/aptekabusy<<people>>.jpg'
		'В аптеке очередь. Перед вами <<people>> ' + iif(people < 2 or people > 4, 'человек' , 'человека' ) + '. Ожидание потребует времени.'
		act 'Ждать своей очереди' :
			minut += RAND(1,4) * people & people = 0
			if $loc = 'gorodok' and (hour < 8 or hour > 20) : gt 'apteka', 'stop', 1
			gs 'stat' & gt 'apteka', 'work', 0
		end
	else
		gt 'apteka', 'work', 0
	end
	act 'Выйти из аптеки' : gt 'apteka', 'stop' , 0
end
!===========================
! Здесь выход, из-за Павлово
!===========================
! 0 - безусловный выход
! 1 - выход с паузой
if $ARGS[0] = 'stop' :
	if ARGS[1]>0 :
		*clr & cla
		gs 'stat'
		dynamic $din_AptekaScreen, 'Аптека', 'images/qwest/apteka/aptekaclose.jpg'
		*NL 'Аптека закрыта. Аптека работает с 8 до 20 часов'
		act 'Понятно' : gt 'apteka', 'stop' , 0
	else
		dynamic $close_apteka
		minut += 5 & gt $loc
	end
end
!=================================
! Здесь обработка экрана и актов
!=================================
!0 - только пришли 1 - от прилавка
if $ARGS[0] = 'work' :
	if $loc = 'gorodok' and (hour < 8 or hour > 20) : gt 'apteka', 'stop', 1
	cla
	act 'Выйти из аптеки' : gt 'apteka', 'stop' , 0
	!рисуем прилавок и таблицу с прайс-листом
	*clr & dynamic $din_AptekaPriceTable
	if ARGS[1] = 0 :
		if $loc = 'gorodok' :
			dynamic $din_AptekaTextPrint, 1 , 'За прилавком как всегда сидит тетя Люда. "Привет <<$name[3]>>. Как жизнь? Как настроение?"'
		else
			dynamic $din_AptekaTextPrint, 1 , 'За прилавком девушка в белом халате. - Здравствуйте, что вам необходимо?"'
		end
	else
		dynamic $din_AptekaTextPrint, 0
		if val($prt_str_mem[0]) > 10 :
			act 'Посмотреть историю' :
				*clr
				dynamic $din_AptekaTextPrint, 2
				delact 'Посмотреть историю'
				act 'Закрыть историю' : gt 'apteka', 'work', 1
			end
		end
	end
end