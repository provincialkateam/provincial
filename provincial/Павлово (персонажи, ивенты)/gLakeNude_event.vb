﻿if $args[0] = 'gLakeNude_sex':
	zz_stage = args[1]
	if zz_stage <= 18:
		*clr & cla
		gs 'zz_render','','images/wannabe/voyeurism_start_even/voyeurism_start_event_'+ zz_stage +'.jpg', func('gLakeNude_event', 'gLakeNude_sex_strings','start_ev'+zz_stage)
		act iif(zz_stage < 1,'Продолжить смотреть','Далее'): gs 'gLakeNude_event', 'gLakeNude_sex', zz_stage+1
	else
		killvar 'zz_stage'
		gt 'gLakeNude'
	end
end
if $args[0] = 'gLakeNude_sex_strings':
	if $args[1] = 'start_ev0': $result = 'Вы отрываете глаза от своих прекрасных ножек и видите, что на пляже никого нет, кроме той самой пары. Сейчас они слишком увлечены друг другом, чтобы обращать внимание на вас. Девушка взяла член парня в рот, выставив попку в соблазнительной позе.'
	if $args[1] = 'start_ev1': $result = 'Девушка умело наяривает член помогая себе ручкой. Вы не можете оторвать взгляд от её умелых губ.'
	if $args[1] = 'start_ev2': $result = 'Оставив свою одежду лежать на песке, вы перемещаетесь чуть-чуть поближе к ним, делая вид что просто гуляете по пляжу. Девушка тем временем всё сильнее заглатывает член.'
	if $args[1] = 'start_ev3': $result = 'Вдруг сильная волна набегает на влюблённых и сбивает их настрой. Девушка отрывается от члена, очевидно решив немного отдохнуть и искупаться. Они встают, и вы понимаете, что нужно что-то делать - иначе сейчас они повернутся в вашу сторону и заметят, как вас трясёт от возбуждения.'
	if $args[1] = 'start_ev4': $result = 'Как тень вы бросаетесь в сторону леса. Кусты и ветки больно царапают по вашей коже. Сухие иголки от хвойных деревьев вонзаются в ступни, заставляя вас с грустью вспомнинать об обуви, которая остались лежать на пляже.<br><dh>– По крайней мере они меня не заметили и здесь меня не видно с пляжа.</dh> – думаете вы.<br>Аккуратно пройдясь по лесу, вы обнаруживаете кусты, за которыми открывается шикарный вид на купающуюся парочку. Понимая, что делать всё равно нечего, вы присаживаетесь и продолжаете наблюдать.'
	if $args[1] = 'start_ev5': $result = 'Вы видите, как девушка выходит из воды и вдруг падает на колени, а потом на локти, выставляя свои дырочки навстречу идущему за ней парню. По лицу парня становится понятно, что ему не нужно объяснять два раза.'
	if $args[1] = 'start_ev6': $result = 'Парень опускается на колени и начинает трахать девушку раком.'
	if $args[1] = 'start_ev7': $result = 'В один момент, когда парень засаживает свой член особенно глубоко, девушка вскрикивает на весь пляж. После чего отстраняется и ложится на спину.'
	if $args[1] = 'start_ev8': $result = 'Раскинув ножки девушки, парень опять вставляет член в её киску.'
	if $args[1] = 'start_ev9': $result = 'Он яростно вгоняет свой член снова и снова.'
	if $args[1] = 'start_ev10': $result = 'Похоже теперь набегающие волны совершенно не мешают им получать удовольствие.'
	if $args[1] = 'start_ev11': $result = 'Громкий стон срывается с губ девушки, когда парень вгонят свой член на всю длину. Видимо её вагина ещё недостаточно разработана, чтобы вместить его агрегат полностью. Девушка упирается руками в парня, прося дать ей небольшую передышку, отстраняется от него, встаёт и отходит подальше от воды. Вы видите, как дрожат её ноги, когда она идёт. Сделав ещё несколько шагов, она ложится животом на песок и широко раскидывает ноги.'
	if $args[1] = 'start_ev12': $result = 'Парень подходит к ней. Вы видите, как он сгорает от нетерпения вновь оказаться в ней. Схватившись за мягкую попку, он поднимет её над песком и всаживает член в сочащуюся соком дырочку.'
	if $args[1] = 'start_ev13': $result = 'Крепко сжимая попку, парен остервенело трахает её писечку.'
	if $args[1] = 'start_ev14': $result = 'Молниеносным движением парень переворачивает девушку на спину. Вы на секунду успеваете удивиться его силе…'
	if $args[1] = 'start_ev15': $result = '…он буквально два раза вгоняет свой член в неё…'
	if $args[1] = 'start_ev16': $result = '…и тут же достаёт его, начиная обильно кончать на живот девушке.'
	if $args[1] = 'start_ev17': $result = 'Сперма тяжёлыми каплями падает на перепачканный песком животик девушки. Вы видите, как она выгибается, пытаясь поймать язычком хотя-бы капельку.<br>Закончив парень обессилено валится на девушку сверху. Похоже ничего интересного больше не будет.'
	if $args[1] = 'start_ev18': $result = 'Вы отворачиваетесь от парочки и начинаете размышлять о том, как отсюда выбираться. Вы решаете аккуратно пройти по лесу в сторону своих вещей, а потом выйти из него сделав вид, что ходили пописать.'
	if $args[1] = 'piss0': $result = 'Девушка идёт по лесу, пытаясь найти место, где можно спокойно пописать.'
	if $args[1] = 'piss1': $result = 'Девушка останавливается, поднимает платье, и вы видите, что под ним нет трусиков.'
	if $args[1] = 'piss2': $result = 'Девушка присаживается. Вы присаживаетесь неподалёку от неё, делая вид что тоже собираетесь писать.'
	if $args[1] = 'piss3': $result = 'Тугая струя мочи вырывается из её киски. Видимо она давно хотела пописать.'
	if $args[1] = 'piss4': $result = 'Она явно получает удовольствие от процесса.'
	if $args[1] = 'piss5': $result = 'А вы возбуждаетесь, глядя как журчит моча из её киски.'
	if $args[1] = 'piss6': $result = 'Девушка бросает короткий взгляд в вашу сторону. Непонятно заметила она вас или нет.'
	if $args[1] = 'piss7': $result = 'Струя потихоньку ослабевает. Ясно, что она скоро закончит.'
	if $args[1] = 'piss8': $result = 'Зрелище писающей красотки так возбудило вас, что вы готовы кончить прямо сейчас.'
	if $args[1] = 'piss9': $result = 'Девушка встаёт и поправляет одежду. Вы тоже поднимаетесь и быстро ретируетесь на пляж.'
end
if $ARGS[0] = 'gLakeNude_nudist':
	*clr & cla
	minut += 10
	horny += 10
	voyeurism += 1
	!Эти локальные константы нужны для того, чтобы вероятность отображения каждой фотографии из трёх папок была одинаковой.
	!Если вы хотите добавить ещё фотографий их нужно разместить в папку по смыслу, назвать в соответствии с другими фото в папке и дать ей следующий номер по порядку.
	!После чего нужно увеличить константу которая соответствует этой папке, на это значение.
	kol_foto_girl = 117
	kol_foto_group = 9
	kol_foto_couple = 24
	!!!!!!!!!!!!!!!!!!!!!
	viewnudist = rand(1,kol_foto_girl+kol_foto_group+kol_foto_couple)
	if viewnudist <= kol_foto_girl:
		gs 'zz_render','','images/wannabe/nudist/girls/nudistgirl_'+rand(1,kol_foto_girl)+'.jpg','Вы тайком пялитесь на голую девушку.'
	end
	if viewnudist > kol_foto_girl and viewnudist <= kol_foto_girl+kol_foto_group:
		gs 'zz_render','','images/wannabe/nudist/group/nudistgroup_'+rand(1,kol_foto_group)+'.jpg','Вы коситесь на группу обнажённых людей. Может быть тоже прийти сюда с друзьями?'
	end
	if viewnudist > kol_foto_girl+kol_foto_group:
		gs 'zz_render','','images/wannabe/nudist/couple/nudistcouple_'+rand(1,kol_foto_couple)+'.jpg','Вы пялитесь на голую парочку. Похоже им хорошо вместе.'
	end
end
if $ARGS[0] = 'gLakeNudeForest_piss':
	zz_stage = args[1]
	if zz_stage <= 9:
		*clr & cla
		gs 'zz_render','','images/wannabe/piss_forest_start/piss_forest_start_'+ zz_stage +'.jpg', func('gLakeNude_event', 'gLakeNude_sex_strings','piss'+zz_stage)
		act iif(zz_stage < 1,'Подглядывать за ней','Далее'): gs 'gLakeNude_event', 'gLakeNudeForest_piss', zz_stage+1
	else
		horny += 30
		killvar 'zz_stage'
		gt 'gLakeNude'
	end
end