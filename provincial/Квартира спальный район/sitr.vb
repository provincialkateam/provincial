$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
minut += 1
housrA = 1
elektro += 1
gs 'stat'
gs 'apartment_south_event','husband_check'
gs 'zz_funcs', 'colorize_day'
$zz_str[0] = iif(my_house = 1,'Просторная комната, у ',iif(remsitr = 0,'Неухоженная комната, обои пошарпаны и местами отклеились. У ',iif(remsitr = 1,'Просторная, но неухоженная комната, с обшарпаными обоями. У ',iif(remsitr = 2,'Просторная комната с аккуратным ремонтом. У ','Просторная, светлая комната. У '))))
$zz_str[1] = 'стены стоит <a href="exec:GT ''divan'',''start''">'+iif(my_house = 1,'диван',iif(remsitr = 0,'ветхий диван',iif(remsitr = 1,'старый диван',iif(remsitr = 2,'диван','роскошный диван'))))+'</a>'
$zz_str[2] = iif(my_house = 1,'<a href="exec:GT ''TV'',''start''">телевизор</a>',iif(TV = 0,'отличное место для телевизора, которого у вас нет',iif(TV = 1,'<a href="exec:GT ''TV'',''start''">телевизор</a>','огромный плазменный <a href="exec:GT ''TV'',''start''">телевизор</a>')))
$zz_str[3] = iif(my_house = 1 or remsitr > 0,'<a href="exec:gt ''zz_books'',''main''">книжная полка</a>','пустое место под книжную полку')
$zz_str[4] = iif(my_house = 1,'письменный',iif(remsitr = 0,'добитый',iif(remsitr = 1,'старый',iif(remsitr = 2,'удобный','роскошный')))) + ' <a href="exec:GT ''table''"> стол</a>'
$zz_str[5] = iif(komp = 1,' на котором расположен <a href="exec:GT ''Komp'',''start''">ноутбук</a>.','.')
gs 'zz_render','Зал','images/city/south/apartment/sitr'+iif(my_house = 1,'',iif(remsitr = 0,0,iif(remsitr = 1,iif(TV = 0,10,iif(TV = 1,11,12)),iif(remsitr = 2,iif(TV = 0,20,iif(TV = 1,21,22)),30))))+'.jpg',$zz_str[0] + $zz_str[1] + '. Напротив дивана ' + $zz_str[2] + ' и ' + $zz_str[3] + '. Неподалеку от окна стоит ' + $zz_str[4] + $zz_str[5]
killvar '$zz_str'
if arrsize('books') = 0: gs 'zz_books','init'
if obruch > 0:gs 'zz_render','','', 'В углу стоит обруч.'
if skak > 0:gs 'zz_render','','', 'На полке лежит скакалка.'
if bookYog > 0:gs 'zz_render','','', 'В книжном шкафу пособие по йоге и медитации.'
if mishka > 0:gs 'zz_render','','','На полке лежит плюшевый мишка.'
if drybelo > 0:gs 'zz_render','','','На столе лежит <<drybelo>> штук высохшего белья, которое нужно <a href="exec: gt''apartment_south_event'',''iron_clothes'' ">погладить</a>.'
gs 'zz_common', 'home_workout'
if husband_inhouse = 1 and ((week < 6 and hour > 17 and hour <= 22) or (week >= 6 and hour > 7 and hour <= 22)): gs 'zz_render', '', '','<a href="exec: gt''husb'',''start'' ">На диване сидит муж и смотрит телевизор</a>'
act 'В коридор': gt 'korr'
act 'Выйти на балкон': gt'balkon'
gs 'zz_common', 'fancywork'
if horny >= 60:act 'Мастурбировать':gt 'apartment_south_event','selfplay_start'
! add random book to bag
if reading['in_bag'] < 0: gs 'zz_books','book2bag'