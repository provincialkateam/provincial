*clr & cla
minut += 1
gs 'time'
gs 'stat'
gs 'zz_render', 'Балкон', 'images/city/south/apartment/balcony'+iif(my_house = 1,'',iif(remsitr = 0,0,iif(remsitr = 1,1,iif(remsitr = 2,2,iif(month >= 4 and month <= 10 and hour > 6 and hour < 21 or hour > 7 and hour < 18 and (month < 4 and month > 10),3,4)))))+'.jpg', 'Вы вышли на балкон.'
if neighbor = 0:
	gs 'zz_render', '', '','На вас никто не обращает внимания.'
else
	gs 'zz_render', '', '','Сосед, из дома напротив, смотрит на вас'+iif(current_clothing = 0,' голую и видимо дрочит','')+'.'
	act 'Посмотреть на соседа': gt 'apartment_south_event','neighbor',1
end
act 'Посмотреть вниз': gt'apartment_south_event','look_down'
act 'Уйти с балкона': neighbor = 0 & gt 'sitr'
if neighborday ! day and rand(1,5) = 5 and temper >= 20: gt 'apartment_south_event','neighbor'