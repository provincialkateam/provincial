gs 'stat'
gs 'zz_render','','','Добро пожаловать на полигон для испытания Светки!'
'Партнер <<$boy>> с членом <<dick>> см. У ГГ глотка <<throat>> см.'
'принуждение <<iif(rape_id = 1,''включено'',''выключено'')>>'
act 'задать партнера' :
	$boy = input('Введи имя партнера')
	dick = input('какой длины член тебя интересует (0-35)')
	gt 'poligon'
end
$katinka = 'city/north/skk/gym/shower/girl/GG_event1/'
act 'изменить навык ГГ для отсоса' :
	throat = input ('введи размер глотки (0-36)')
	gt 'poligon'
end
act 'принуждение':
	if rape_id = 1 :
		rape_id = 0
	else
		rape_id = 1
	end
	gs 'poligon'
end
act 'Сосать':
	cla & *clr
	gs 'zz_render','','city/north/skk/gym/shower/girl/GG_event1/GG_event<<rand(30)>>.jpg',''
	gs 'zz_dynamic_sex', 'bj2'
	act 'назад' : gt 'poligon'
end