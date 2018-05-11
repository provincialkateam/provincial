minut += 5
gs 'stat'
gs 'zz_render','Складской терминал','city/north/terminal/terminal0.jpg',func('Terminal_strings','local_str1')
! по понедельниках можно встретить отчима и напроситься ехать с ним домой
if week = 1 and hour >= 18 and hour <= 21: gs 'zz_render','','','Возле терминала вместе с другими водилами, ожидая загрузки, режется в картишки ваш <a href="exec: gt ''zz_father'',''meet_in_city''">отчим.</a>'
act 'Уйти':
	cla
	minut += 5
	gt 'north'
end
act 'Зайти в офис':
	minut += 5
	AboutBussines = 0
	AboutDocs = 0
	AboutDocsManager = 0
	YouNotOpenDoorDir = 0
	YouNotOpenDoorBuh = 0
	gt 'TerminalOffice','00'
end