*clr & cla
gs 'stat'
$_str = ''
if $loc = 'sitr':
	if stolmoney > 0: $_str += 'У вас <<stolmoney>> рублей в столе.<br>'
	if prezik > 0: $_str += 'Упаковка презервативов, в ней <<prezik>> шт.<br>'
	if tabletki > 0: $_str += 'Противозачаточные таблетки <<tabletki>> шт.<br>'
	if lubri > 0: $_str += 'Лубрикант, хватит на <<lubri>> раз.<br>'
	if dildo > 0: $_str += 'Фалоимитатор реалистик<br>'
	if money > 0:
		act 'Положить деньги в стол':
			stolIN = input ("Сколько денег вы хотите положить в стол?")
			if stolIN > 0 and stolIN <= money:
				stolmoney += stolIN
				money -= stolIN
			end
			gt 'table'
		end
	end
	if stolmoney > 0:
		act 'Взять деньги из стола ':
			stolOUT = input ("Сколько денег вы хотите взять из стола?")
			if stolOUT > 0 and stolOUT <= stolmoney:
				stolmoney -= stolOUT
				money += stolOUT
			end
			gt 'table'
		end
	end
end
if abonement > 0: $_str += 'Абонемент, на посещение фитнесс-центра, действителен на <<abonement>> занятий<br>'
if krem > 0: $_str += 'Крем для загара <<krem>><br>'
gs 'zz_render','Письменный стол','images/common/furniture/table/'+iif($loc = 'Gadhouse',2,komp)+'.jpg','Вы сели за письменный стол.'+iif(komp = 1 and $loc ! 'Gadhouse',' У вас под руками открытый <a href="exec: GT ''Komp'',''start''">ноутбук</a>','')+'.**' + $_str
killvar '$_str'
act 'Встать из-за стола': gt $loc, $metka
gs 'zz_school','homework'
if university['student'] > 0 and (month <= 6 or month >= 9):
	if university['course'] = 1:
		act 'Писать курсовую работу': gt'university_events','course_work'
	else
		act 'Писать дипломную работу': gt'university_events','graduate_work'
	end
end