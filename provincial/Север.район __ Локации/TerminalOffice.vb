﻿gs 'stat'
! В офисе если ГГ знает мы можем купить товар или выполнить поручение босса из быстроешки.
! О возможности продажи товара ГГ узнает на вокзале в павлово в кассирши Веры
! $npc['29,know'] > 0 - можно покупать товар
! TerminalPapper = 1 and DayTerminalPapper = day - можно выполнить поручение
!
! В офисе несколько кабинетов, один для покупки товара, второй для документов из быстроешки, третий для светлого будущего
!
! Администрация бухгалтерия и директор работают в лучших условиях, чем манагеры :)))
! Условия по времени требуют проработки
!
TerminalOfficeDirWorkTime = 0
TerminalOfficeBuhWorkTime = 0
if ((hour >= 9 and hour <= 12) or (hour >= 14 and hour <= 17)) and week < 6: TerminalOfficeDirWorkTime = 1
if ((hour >= 9 and hour <= 12) or (hour >= 14 and hour <= 19)) and week < 6: TerminalOfficeBuhWorkTime = 1
$din_TerminalOfficeScreen = {
	!0 - заголовок
	!1 - имя файла с картинкой
	*clr
	gs 'zz_render',$ARGS[0],'city/north/terminal/'+$ARGS[1]
}
!==================================================
!Холл 00
!==================================================
if $ARGS[0] = '00':
	dynamic $din_TerminalOfficeScreen, 'Холл офисного помещения', 'terminal4'
	'Вы в холле офисного помещения.'
	cla
	act 'Уйти из офиса': minut += 5 & gt 'Terminal'
	act 'Идти в отдел продаж': minut += 1 & gt 'TerminalOffice', '11'
	act 'Идти в бухгалтерию': minut += 1 & gt 'TerminalOffice', '21'
	act 'Идти к директору': minut += 1 & gt 'TerminalOffice', '31'
end
!==================================================
!Кабинет манагера = 1х
!==================================================
if $ARGS[0] = '11':
	!Можем купить товар если знаем что его можно покупать
	!Можем попытатся отдать документы от Анатолия Борисовича
	!Можем спросить когда работает бухгалтерия
	!Можем спросить когда работает директор
	cla
	dynamic $din_TerminalOfficeScreen, 'Отдел продаж', 'terminal2'
	gs 'zz_render','','', '- Чем я могу вам помочь? - Приветливо улыбаясь спрашивает вас менеджер.'
	act 'Уйти из кабинета': minut += 1 & gt 'TerminalOffice', '00'
	if $npc['29,know'] > 0:
		!Покупаем товар
		!Флаг заполнености хранилищ, уменьшение
		!этого флага позволяет перейти к покупкам
		DoNotBuy = 2
		!Сумма и Количество которое мы можем купить(хранить)
		MaxQuantityA = 0
		MaxQuantity1 = 0
		MaxQuantity2 = 0
		MaxCost = 0
		!Описание размера хранилищ
		TovarLimitRepository1 = 30
		TovarLimitRepository2 = 100
		gs 'zz_render','','', 'Вы заговорили с менеджером о покупке мелочевки...'
		!Получаем текущие остатки
		TovarRepository1 = tovarL
		if TovarRepository1 => TovarLimitRepository1:
			gs 'zz_render','','', ' Дома у вас все забито под завязку.'
		else
			DoNotBuy -= 1
			gs 'zz_render','','', ' Сейчас у вас дома хранится '+ TovarRepository1 +' шт., дома вы сможете разместить только <<TovarLimitRepository1>> шт.'
			MaxQuantity1 = TovarLimitRepository1 - TovarRepository1
		end
		if YouCanGar > 0:
			!Получаем текущие остатки по гаражу
			TovarRepository2 = GarTorgItem
			if TovarRepository2 => TovarLimitRepository2:
				gs 'zz_render','','', ' В гараже тоже нет свободного места.'
			else
				DoNotBuy -= 1
				gs 'zz_render','','', ' А в гараже хранится '+ TovarRepository2 +' шт., максимум в гараже вы сможете разместить <<TovarLimitRepository2>> шт.'
				MaxQuantity2 = TovarLimitRepository2 - TovarRepository2
			end
		end
		if DoNotBuy = 2:
			gs 'zz_render','','',' Подумав немного вы поняли, что вам просто негде хранить товар и решили отказаться от покупки.'
		else
			!Производим покупки
			act 'Купить мелкий товар по 100 рублей, указав конкретное количество':
				minut += 13
				MaxQuantityA = input("Сколько товара вы хотите купить по цене 100 рублей за штуку?")
				if MaxQuantityA > (MaxQuantity1 + MaxQuantity2):
					gs 'zz_render','','','<red>Вам негде будет хранить излишек в размере <<MaxQuantityA-(MaxQuantity1 + MaxQuantity2)>> шт. !!!</red>'
					cla
					act 'Понятно': gt 'TerminalOffice', '11'
				end
				MaxCost = MaxQuantityA * 100
				if MaxCost > money:
					!Если денег мало
					gs 'zz_render','','', 'У вас недостаточно наличных, придется отказаться от покупки.'
					if (money + karta >= MaxCost) or (karta >= MaxCost):
						!У игрока может быть пластик с деньгами
						gs 'zz_render','','', ' У вас есть деньги на карте и вы предложили менеждеру произвести оплату банковской картой.'
						gs 'zz_render','','',' - У нас нет терминала для оплаты картой - говорит менеджер. - К сожалению, мы можем принять только наличные.'
					end
					cla
					act 'Понятно': gt 'TerminalOffice', '11'
				else
					!Если деньги есть, списываем деньги, заполняем склады
					money -= MaxCost
					gs 'zz_render','','','Вы приобрели <<MaxQuantityA>> шт. товара на сумму <<MaxCost>>'
					!Сначала заполняем хнанилище 1
					if MaxQuantityA => MaxQuantity1:
						tovarL = TovarRepository1 + MaxQuantity1
						MaxQuantityA -= MaxQuantity1
						if YouCanGar > 0 : *P ', в т.ч. <<MaxQuantity1>> шт. для хранения в комнате, в гараж <<MaxQuantityA>> шт.'
					else
						if YouCanGar > 0 : *P ', в т.ч. <<MaxQuantityA>> шт. для хранения в комнате, в гараж 0 шт.'
						tovarL = TovarRepository1 + MaxQuantityA
						MaxQuantityA = 0
					end
					!Теперь заполняем хнанилище 2
					if MaxQuantityA > 0:
						GarTorgItem = TovarRepository2 + MaxQuantityA
					end
					if YouCanGar = 0 and money > 100:
						gs 'zz_render','','', 'Совершая покупку вы подумали о том, что могли бы купить больше товара, но где его хранить? Может попытаться поговорить с отчимом о выделении места под товар в его гараже...'
					end
					cla
					act 'Завершить покупку': gt 'TerminalOffice', '11'
				end
			end
			act 'Купить мелкий товар по 100 рублей, под "завязку" - это <<(MaxQuantity1 + MaxQuantity2)>> шт.':
				!На покупку тратим время
				minut += 13
				MaxQuantityA = MaxQuantity1 + MaxQuantity2
				MaxCost = MaxQuantityA * 100
				!Забиваем склады
				if MaxCost > money:
					!Если денег мало
					gs 'zz_render','','', 'У вас недостаточно наличных, придется отказаться от покупки.'
					if (money + karta >= MaxCost) or (karta >= MaxCost):
						!У игрока может быть пластик с деньгами
						gs 'zz_render','','', ' У вас есть деньги на карте и вы предложили менеждеру произвести оплату банковской картой.'
						gs 'zz_render','','',' - У нас нет терминала для оплаты картой - говорит менеджер. - К сожалению, мы можем принять только наличные.'
					end
					cla
					act 'Понятно': gt 'TerminalOffice', '11'
				else
					!Если деньги есть, списываем деньги, заполняем склады
					money -= MaxCost
					gs 'zz_render','','','Вы приобрели <<MaxQuantityA>> шт. товара на сумму <<MaxCost>>'
					!Сначала заполняем хнанилище 1
					if MaxQuantityA => MaxQuantity1:
						tovarL = TovarRepository1 + MaxQuantity1
						MaxQuantityA -= MaxQuantity1
						if YouCanGar > 0 : *P ', в т.ч. <<MaxQuantity1>> шт. для хранения в комнате, в гараж <<MaxQuantityA>> шт.'
					else
						if YouCanGar > 0 : *P ', в т.ч. <<MaxQuantityA>> шт. для хранения в комнате, в гараж 0 шт.'
						tovarL = TovarRepository1 + MaxQuantityA
						MaxQuantityA = 0
					end
					!Теперь заполняем хнанилище 2
					if MaxQuantityA > 0:
						GarTorgItem = TovarRepository2 + MaxQuantityA
					end
					if YouCanGar = 0 and money > 100:
						gs 'zz_render','','', 'Совершая покупку вы подумали о том, что могли бы купить больше товара, но где его хранить? Может попытаться поговорить с отчимом о выделении места под товар в его гараже...'
					end
					cla
					act 'Завершить покупку': gt 'TerminalOffice', '11'
				end
			end
		end
	end
	if YouNotOpenDoorDir = 1:
		!Где директор, Дверь дира была закрыта
		act 'Спросить о директоре':
			gs 'zz_render','','','- Скажите пожалуйста - спрашиваете вы - а как увидеть вашего руководителя?'
			gs 'zz_render','','','Менеджер еле заметно поморщившись отвечает: Юрий Михайлович у себя обычно с понедельника по пятницу, с 9-00 до 18-00. Ну еще может уехать на обед с 13 до 14'
			cla
			act 'Понятно': YouNotOpenDoorDir = 0 & gt 'TerminalOffice', '11'
		end
	end
	!Где бухгалтер? Дверь буха была закрыта
	if YouNotOpenDoorBuh = 1:
		act 'Спросить о бухгалтере':
			gs 'zz_render','','','- Скажите пожалуйста - спрашиваете вы - а как увидеть вашего бухгалтера?'
			gs 'zz_render','','','Менеджер улыбнувшись отвечает: Елизавета обычно у себя в кабинете с понедельника по пятницу, с 9-00 до 20-00. Ну еще может уехать на обед с 13 до 14'
			cla
			act 'Понятно': YouNotOpenDoorBuh = 0 & gt 'TerminalOffice', '11'
		end
	end
	!У ГГ Есть бумаги, но манагер должен сказать чтобы валила в бухгалтерию.
	if AboutDocsManager=0 and TerminalPapper = 1 and DayTerminalPapper = day:
		gs 'zz_render','','', '- Я от Анатолия Борисовича из компании "ООО Быстроешка Лимитед", мне поручено передать вам документы.'
		act 'Отдать документы':
			gs 'zz_render','','','- Вам лучше обратится в бухгалтерию к Елизавете, она должна знать. Это вам в следующую дверь по коридору.'
			cla
			act 'Понятно': AboutDocsManager=1 & gt 'TerminalOffice', '11'
		end
	end
	!У ГГ пока нет тем для разговора.
	if $npc['29,know'] = 0 and YouNotOpenDoorDir = 0 and YouNotOpenDoorBuh = 0 and TerminalPapper = 0:
		gs 'zz_render','','', 'Вам нечего сказать и ничего не остается делать как выйти из кабинета.'
	end
end
!==================================================
!Кабинет бухгалтера = 2х
!==================================================
if $ARGS[0] = '21':
	! Контроль времени работы буха отключим пока не будет решен вопрос временной совместимости получения задания в быстроешке
	if TerminalOfficeBuhWorkTime = 1:
		!Можно отдать документы
		cla
		dynamic $din_TerminalOfficeScreen, 'Кабинет бухгалтера', 'terminal3'
		act 'Уйти из кабинета': minut += 1 & gt 'TerminalOffice', '00'
		!ГГ не полная идиотка, поэтому ограничим общение с бухом лишь документами, может потом что-нить еще
		gs 'zz_render','','', '- Что вы хотели? - Оторвавшись от монитора и развернувшись к вам на кресле спрашивает симпатичная девушка.'
		if TerminalPapper = 1 and DayTerminalPapper = day:
			gs 'zz_render','','', '- Я от Анатолия Борисовича из компании "ООО Быстроешка Лимитед", мне поручено передать вам документы.'
			gs 'zz_render','','','- Отлично! Я очень жду эти бумаги, давайте их мне.'
			act 'Отдать документы' :
				gs 'zz_render','','', ' Девушка принимает из ваших рук папку, открывет и бегло просмативает ее содержимое'
				gs 'zz_render','','', ' - Скажите Анатолию Борисовичу большое спасибо за оперативность от Елизаветы.'
				gs 'zz_render','','',' Девушка улыбнулась, и потеряв интерес к вам отвернулась к экрану монитора.'
				minut += 1
				TerminalPapper = 2
				!следующие 2 строчки от оригинала кода версии 1.2.4 zalem, зачем они не разбирался, просто оставил
				gs 'stat'
				gs 'zz_funcs', 'colorize_day'
				cla
				act 'Уйти из кабинета': minut += 1 & gt 'TerminalOffice', '00'
			end
		else
			gs 'zz_render','','', 'Вам нечего ответить и ничего не остается делать как выйти из кабинета.'
		end
	else
		!Бухгалтера нет на месте
		cla
		dynamic $din_TerminalOfficeScreen, 'Дверь с табличкой', 'terminal6'
		act 'Отойти от двери': minut += 1 & gt 'TerminalOffice', '00'
		gs 'zz_render','','','Вы постучали, но за дверью тишина. Надавив на ручку двери вы поняли, что дверь заперта. Может попробовать придти в другое время или у кого-нибудь спросить во сколько лучше подойти? - подумали вы.'
		YouNotOpenDoorBuh = 1
	end
end
!==================================================
!Кабинет директора = 3х
!==================================================
if $ARGS[0] = '31':
	if TerminalOfficeDirWorkTime = 1:
		!Можно попытатся отдать документы
		!Можно попытатся поговорить
		cla
		dynamic $din_TerminalOfficeScreen, 'Кабинет директора', 'terminal1'
		act 'Уйти из кабинета': minut += 1 & gt 'TerminalOffice', '00'
		!До развития сюжета 'Поговорить' директор будет постоянно висеть на телефоне и посылать ГГ нах из кабинета
		gs 'zz_render','','', 'Вы постучали и открыли дверь. За массивным столом мужчина. Мужчина разговаривал по телефону и по всей видимости был не в настроении. Вы явно не тот человек, кого мужчина ожидал увидеть, поэтому он пренебрежительно замахал рукой явно указывая, что вам надо уйти из кабинета.'
		if AboutBussines = 0:
			act 'Поговорить':
				dynamic $din_TerminalOfficeScreen, 'Кабинет директора', 'terminal1'
				gs 'zz_render','','', '<center><b>Уважаемый игрок, здесь шикарное место для вашей истории.'
				gs 'zz_render','','','Идеальный вариант, если это будет начало хорошего, легального и доходного торгового бизнеса для ГГ'
				gs 'zz_render','','', 'А пока закройте дверь с другой стороны :)))</b></center>'
				AboutBussines = 1
				delact 'Поговорить'
			end
		end
		if AboutDocs = 0 and TerminalPapper = 1 and DayTerminalPapper = day:
			act 'Отдать документы':
				dynamic $din_TerminalOfficeScreen, 'Кабинет директора', 'terminal1'
				gs 'zz_render','','', 'Однако вы проигнорировали жесты мужчины, ведь у вас важное поручение от боса.'
				gs 'zz_render','','','- Я от Анатолия Борисовича из компании "ООО Быстроешка Лимитед", мне поручено передать вам документы.'
				gs 'zz_render','','','Мужчина остановил разговор по телефону, нахмурился, и указав вам на дверь произнес - Идите бухгалтерию.'
				AboutDocs = 1
				delact 'Отдать документы'
			end
		end
		if AboutBussines = 1 or AboutDocs = 1: gs 'zz_render','','', 'Вам ничего не остается делать как выйти из кабинета.'
	else
		!Директора нет на месте
		cla
		dynamic $din_TerminalOfficeScreen, 'Дверь с табличкой', 'terminal5'
		act 'Отойти от двери': minut += 1 & gt 'TerminalOffice', '00'
		gs 'zz_render','','','Вы постучали, но за дверью тишина. Надавив на ручку двери вы поняли, что дверь заперта. Может попробовать придти в другое время или у кого-нибудь спросить во сколько лучше подойти? - подумали вы.'
		YouNotOpenDoorDir = 1
	end
end