$sexloc = $CURLOC
if $ARGS[0] = 'start':
	*clr & cla
	gs'stat'
	'<center><b><font color = maroon>Комната Кати</font></b></center>'
	'<center><img src="images/img/Kathouse/bedroom.jpg"></center>'
	if hour >= 18 and hour < 23:'На тахте сидит <a href="exec:gt''katspalnya'',''kat''">Катя</a> и смотрит телевизор'
	if hour >= 23 or hour < 6:'В кровати спит <a href="exec:gt''katspalnya'',''katslip''">Катя</a>.'
	'Большая комната по середине стоит огромная кровать, с боку небольшая тахта.'
	act 'Уйти':gt'street'
end
if $ARGS[0] = 'katslip':
	cla
	*clr
	minut += 30
	if katjob = 0 and $npc['33,relation'] > 60:gt'katspalnya','katjobs'
	'<center><img src="images/img/Kathouse/kat.jpg"></center>'
	'Катя протирает глаза "Привет как делишки".'
	act 'Отойти':gt'katspalnya','start'
	if $npc['33,relation'] > 50:act 'Секс':gt'lezbsex','start'
end
if $ARGS[0] = 'kat':
	cla
	*clr
	minut += 30
	if katjob = 0 and $npc['33,relation'] > 60:gt'katspalnya','katjobs'
	'<center><img src="images/img/Kathouse/kat.jpg"></center>'
	'Увидев вас Катя улыбается "Привет как делишки".'
	act 'Отойти':gt'katspalnya','start'
	if $npc['33,relation'] > 50:act 'Секс':gt'lezbsex','start'
	act 'Поболтать':
		cla
		*clr
		if telkat = 0:telkat = 1
		gs 'npc_editor','change_rep','+', 33
		minut += 30
		'<center><img src="images/img/Kathouse/kat.jpg"></center>'
		'Вы проболтали полчаса.'
		act 'Закончить':gt'katspalnya','start'
	end
end
if $ARGS[0] = 'katjobs':
	cla
	*clr
	katjob = 1
	minut += 30
	'<center><img src="images/img/Kathouse/kat.jpg"></center>'
	'"<<$name[2]>> если хочешь я могу поговорить с глав врачом и тебя возьмут на работу в поликлинику".'
	act 'Но я же не медсестра':
		cla
		'"Но, я же не медсестра." попытались вы возразить.'
		'"Ой, да ладно тебе, начнешь с чего-нибудь простенького, будешь перевязки делать. А там научишься, ОБЖ в школе ведь было."'
		'"Да, было." ответили вы, думая о том что вас в то время интересовали совсем не перевязки.'
		'"Ну да ладно, я поговорю а ты сама смотри хочешь приходи, хочешь нет."'
		act 'Хорошо':gt'katspalnya','start'
	end
end