$metka = $ARGS[0]
$loc = $CURLOC
act 'В коридор': gt 'korr'
minut += 1
housrA = 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render', 'Спальня', 'images/city/south/apartment/bedr'+iif(my_house = 1,'',iif(rembedr = 0,0,iif(rembedr = 1,1,iif(rembedr = 2,2,3))))+'.jpg', iif(my_house = 1,'Тесная комнатушка',iif(rembedr = 0,'Комната с вылинявшими от времени обоями,',iif(rembedr = 1,'Невзрачная комната со старой мебелью,',iif(rembedr = 2,'Светлая комната, с аккуратным ремонтом','Светлая и красивая комната, с современной стильной мебелью,'))))+' в которой '+iif(my_house = 2 and rembedr = 0,'стоит','главное место занимает')+' <a href="exec:GT ''bed'',''start''">'+iif(my_house = 2 and rembedr = 0,'старая тахта','двухспальная кровать')+'</a>. У входа стоит '+iif(my_house = 1,'',iif(rembedr = 0,'добитый ',iif(rembedr = 1,'старый ',iif(rembedr = 2,'красивый','современный '))))+'<a href="exec:GT ''loker'',''start''">шкаф</a> для одежды. '+iif(my_house = 1,'Окно закрыто тяжелыми льняными шторами',iif(rembedr = 0,'',iif(rembedr = 1,'У стены находится старый <a href="exec:GT ''mirror'',''start''">трельяж</a>','На одной из стен висит <a href="exec:GT ''mirror'',''start''">зеркало</a>')))+'.'
if husband > 0 and husbandrinkday = day:
	if husbanstrapon = 1: gs 'zz_render', '', '','Муж спит пьяный на кровати с анальной пробкой в заднице.'
	if husbanstrapon = 2: gs 'zz_render', '', '','Муж спит пьяный на кровати после того как вы разработали его задницу дилдо.'
	if husbanstrapon = 3: gs 'zz_render', '', '','Муж спит пьяный на кровати после того как вы трахнули его страпоном.'
end
if husband > 0 and husbandrink ! 10 and husbandrinkday ! day and (hour > 22 or hour < 7): gs 'zz_render', '', '','<a href="exec: gt''husb'',''start'' ">На кровати спит муж.</a>'
if husbandrink = 11 and husbanstrapon > 0 and husbandrinkday ! day:gt 'apartment_south_event','husband_drin_end'
if husbandrink = 10 and hour > 20 and hour < 23 and husbandrinkday ! day:gt 'apartment_south_event','husband_drin_start'
if dur > 0: gs 'zz_render', '', '','У вас спрятано <<dur>> доз бледной леди'
if dur > 0 and narkday ! day: gs 'zz_common', 'drug_day'
if pornMagazine > 0:
	gs 'zz_render', '', '','На тумбочке рядом с кроватью лежит порножурнал.'
	gs 'zz_common','read_porn'
end