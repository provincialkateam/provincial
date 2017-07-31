!'<<$boy>> <<$boybody>> <<$boybod>> <<$boyface>>.<<$boy>> <<$boyClo>>'
!Выбор фото
$boy_pic = {
	picrand = RAND(1,30)
	if picrand = boypicA or picrand = boypicB or picrand = boypicC: dynamic $boy_pic
	boypic = picrand
	if picrand = 30: boypic = 10
}
dynamic $boy_pic
!Рандомный возраст
boyage = rand(18,35)
!Рандомные мужские имена (русские)
boynamerand = RAND(1,38)
if boynamerand = 1:$boy = 'Александр' & $boy[1] = 'Саша'
if boynamerand = 2:$boy = 'Алексей' & $boy[1] = 'Леша'
if boynamerand = 3:$boy = 'Альберт' & $boy[1] = 'Альберт'
if boynamerand = 4:$boy = 'Анатолий' & $boy[1] = 'Толик'
if boynamerand = 5:$boy = 'Антон' & $boy[1] = 'Антон'
if boynamerand = 6:$boy = 'Аркадий' & $boy[1] = 'Аркаша'
if boynamerand = 7:$boy = 'Андрей' & $boy[1] = 'Андрей'
if boynamerand = 8:$boy = 'Борис' & $boy[1] = 'Боря'
if boynamerand = 9:$boy = 'Вадим' & $boy[1] = 'Вадик'
if boynamerand = 10:$boy = 'Валентин' & $boy[1] = 'Валик'
if boynamerand = 11:$boy = 'Валерий' & $boy[1] = 'Валера'
if boynamerand = 12:$boy = 'Василий' & $boy[1] = 'Вася'
if boynamerand = 13:$boy = 'Виктор' & $boy[1] = 'Витя'
if boynamerand = 14:$boy = 'Виталий' & $boy[1] = 'Виталик'
if boynamerand = 15:$boy = 'Владимир' & $boy[1] = 'Вова'
if boynamerand = 16:$boy = 'Вячеслав' & $boy[1] = 'Слава'
if boynamerand = 17:$boy = 'Геннадий' & $boy[1] = 'Гена'
if boynamerand = 18:$boy = 'Георгий' & $boy[1] = 'Гриша'
if boynamerand = 19:$boy = 'Григорий' & $boy[1] = 'Гриша'
if boynamerand = 20:$boy = 'Денис' & $boy[1] = 'Денис'
if boynamerand = 21:$boy = 'Евгений' & $boy[1] = 'Женя'
if boynamerand = 22:$boy = 'Егор' & $boy[1] = 'Егор'
if boynamerand = 23:$boy = 'Иван' & $boy[1] = 'Ваня'
if boynamerand = 24:$boy = 'Игорь' & $boy[1] = 'Игорь'
if boynamerand = 25:$boy = 'Кирилл' & $boy[1] = 'Кирилл'
if boynamerand = 26:$boy = 'Леонид' & $boy[1] = 'Лёня'
if boynamerand = 27:$boy = 'Максим' & $boy[1] = 'Макс'
if boynamerand = 28:$boy = 'Михаил' & $boy[1] = 'Миша'
if boynamerand = 29:$boy = 'Олег' & $boy[1] = 'Олег'
if boynamerand = 30:$boy = 'Павел' & $boy[1] = 'Паша'
if boynamerand = 31:$boy = 'Петр' & $boy[1] = 'Петя'
if boynamerand = 32:$boy = 'Семен' & $boy[1] = 'Сема'
if boynamerand = 33:$boy = 'Сергей' & $boy[1] = 'Сережа'
if boynamerand = 34:$boy = 'Степан' & $boy[1] = 'Степа'
if boynamerand = 35:$boy = 'Федор' & $boy[1] = 'Федя'
if boynamerand = 36:$boy = 'Эдуард' & $boy[1] = 'Эдик'
if boynamerand = 37:$boy = 'Юрий' & $boy[1] = 'Юра'
if boynamerand = 38:$boy = 'Яков' & $boy[1] = 'Яков'
!Внешность
boybodyrand = RAND(1,3)
if boybodyrand = 1:$boybody = 'высокий'
if boybodyrand = 2:$boybody = 'среднего роста'
if boybodyrand = 3:$boybody = 'небольшой'
boybodrand = RAND(1,4)
if boybodrand = 1:$boybod = 'худощавый'
if boybodrand = 2:$boybod = 'атлетичный'
if boybodrand = 3:$boybod = 'коренастый'
if boybodrand = 4:$boybod = 'полный'
boyfacerand = RAND(1,3)
if boyfacerand = 1:$boyface = 'брюнет'
if boyfacerand = 2:$boyface = 'шатен'
if boyfacerand = 3:$boyface = 'блондин'
!размер елды
grdikrand = RAND(0,100)
if grdikrand < 80:
	dick = RAND(12,18)
elseif grdikrand >= 80 and grdikrand < 90:
	dick = RAND(8,12)
elseif grdikrand >= 90:
	dick = RAND(18,25)
end
! половая сила
silaVag = RAND(0,2)
!переменная отвечающая за guy
boyonce = 0
!Переменные отвечающие за то какие черты нравятся
!Обеспеченность, отвечает за деньги и требования
harakBoy = RAND(0,2)
finance = RAND(0,2)
	if finance = 0:
		!нищий гопник или работяга
		!проверка по внешности Первичная
		if harakBoy = 0:vneshBoy = RAND(0,5)
		if harakBoy = 1:vneshBoy = RAND(0,10)
		if harakBoy = 2:vneshBoy = RAND(5,20)
		$boyClo = 'одет в мешковатый спортивный костюм.'
	elseif finance = 1:
		!середняк
		!проверка по внешности
		if harakBoy = 0:vneshBoy = RAND(0,10)
		if harakBoy = 1:vneshBoy = RAND(5,20)
		if harakBoy = 2:vneshBoy = RAND(10,30)
		$boyClo = 'одет в джинсы и свитер.'
	elseif finance = 2:
		!середняк
		!проверка по внешности
		if harakBoy = 0:vneshBoy = RAND(5,20)
		if harakBoy = 1:vneshBoy = RAND(10,30)
		if harakBoy = 2:vneshBoy = RAND(20,40)
		$boyClo = 'одет в дорогой костюм.'
	end
!требования по фигуре, размеру груди, цвет волос.
!0 - зад меньше 80, 1 зад от 80 до 100, 2 зад свыше 100
figurBoy = RAND(0,2)
!0 - грудь меньше 3, 1 грудь 3-4, 2 грудь больше 4
titBoy = RAND(0,2)
!0 - брюнетка, 1 - шатенка, 2 - рыжая, 3 - блондинка
haerBoy = RAND(0,3)
!характер 0 - мягкий, 1 -норма 2 - агрессор
randizvrat = RAND(0,100)
if randizvrat < 80:izvrat = 0
if randizvrat >= 80:izvrat = 1