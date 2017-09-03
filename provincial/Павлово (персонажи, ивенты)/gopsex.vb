! Разные вариации секса -------------!
!-----Настройки-----!
!кол-во раз может быть секс в сутки (по дефолту 2, после этого значения партнер говорит что устал)
!Вася:
if shgopsex_vasya_day ! daystart: shgopsex_vasya_count = 2
!Дэн:
if shgopsex_den_day ! daystart: shgopsex_den_count = 2
!Витя:
if shgopsex_vitya_day ! daystart: shgopsex_vitya_count = 2
!групповуха кол-во раз в сутки:
if shgopsex_gr_day ! daystart: shgopsex_gr_count = 1
!---------------------------------------------------------!
!кол-во выбора до того как партнер захочит кончить:
!1на1 (этот параметр обновляется после окончания секса, в $shgopsex_end)
shgopsex_count = rand(4,7)
!групповуха
shgopsex_group_count = rand(3,5)
!индикатор стамины нпс:
$ind_stamina_npc = {
	$ind_npc = func('zz_funcs','scale',sh_ind,7)
	sh_ind = shgopsex_count
	'<center>Вас трахает <<$gopsex_name_npc>>, его выносливость: <<$ind_npc>></center>'
}
!групповой индикатор стамины
$ind_stamina_groupnpc = {
	$ind_npc = func('zz_funcs','scale',sh_ind,5)
	sh_ind = shgopsex_group_count
	'<center>Вас <<$gop_sextext3>> <<$gop_text_npcr>>, их выносливость: <<$ind_npc>></center>'
}
! ---
!Рандомизация текста!
!выводим если у гг первый раз
$gg_devst_deflor = {
	if vagina <= 0:
		horny = 0
		manna -= 15
		vagina += 1
		'Вы предупреждаете что это ваш первый раз и просите быть поаккуратнее.'
		'<font color = red><b>Вы закусили губу, когда член вошёл в вас, разорвав девственную плеву. Это довольно болезненно в первое время.</b></font>'
	end
}
if $ARGS[0] = 'gg_devst_deflor':
	if vagina <= 0:'Вы предупреждаете, что это ваш первый раз и просите быть поаккуратнее.'
end
!текст оргазма нпс:
$npc_orgasm = {
	if shgopsex_count = 0:
		$_gopstr[0] = '\\- <<$gop_name_gg>> я уже не могу, ща кончу!// - со стоном предупреждает вас <<$gopsex_name_npc>>.'
		$_gopstr[1] = '<<$gopsex_name_npc>> предупреждает вас: \\-<<$gop_name_gg>> я уже на подходе, ща кончу!//'
		$_gopstr[2] = '<<$gopsex_name_npc>> интересуется: \\-Ну чего, <<$gop_name_gg>>, куда залить спермы? Всё равно? Ну ок, сам выберу!//'
		$_gopstr[3] = '\\- Я уже готов кончить! <<$gop_name_gg>>, куда хочешь, что бы я кончил? Не знаешь? Ну ладно сам выберу!//'
		$_gopstr[4] = '<<$gopsex_name_npc>> тяжело дышит: \\- <<$gop_name_gg>>, я уже на пике, скоро кончу!//'
		gs 'zz_render','','',$_gopstr[rand(0,4)]
		killvar '$_gopstr'
	end
}
!оргазм гг:
$gg_sex_orgasm = {
	if mesec > 0:
		!месячные, оргазм не возможен
		horny = 0
		manna -= 10
		'<font color = red><b>У вас месячные и в то время пока член таранит вас, из влагалища потихоньку вытекает кровь.</b></font>'
	elseif mesec <= 0 and horny >= 50:
		$_gopstr[0] = 'Вы просите сильнее вас <<$gop_sextext1>>, пытаясь кончить.'
		$_gopstr[1] = 'Вы принимаетесь быстрее подмахивать, пытаясь кончить.'
		$_gopstr[2] = 'Вы на пике оргазма, и стонете: \\- Глубже!..//.'
		$_gopstr[3] = 'Вы пытаясь кончить, умоляете чтобы вас стали <<$gop_sextext1>> быстрее.'
		$_gopstr[4] = 'Вам сильно хочется кончить, и вы стараетесь двигаться в такт с парнем.'
		$_gopstr[5] = 'Вам хочется кончить, и вы начинаете активнее насаживатся на член.'
		$_gopstr[6] = 'Вы стараясь кончить, стали просить партнера ускориться.'
		$_gopstr[7] = 'Вы просите <<$gop_sextext1>> вас жёстче.'
		$_gopstr[8] = 'Вы просите жёстче с вами обращаться, пытаясь кончить.'
		$_gopstr[9] = 'Вы молите партнера, чтобы он стал <<$gop_sextext1>> вас сильнее.'
		$_gopstr[10] = 'Вы орёте матом какая вы ебливая шлюха, пытаясь подзадорить партнера и кончить.'
		$_gopstr[11] = 'Вы сильно перевозбуждены и умоляете партнера активнее вас <<$gop_sextext1>>, пытаясь кончить.'
		gs 'zz_render','','',$_gopstr[RAND(0,11)]
		killvar '$_gopstr'
		if horny >=70:
			orgasm += 1
			horny = 0
			manna += 25
			$_gopstr[0] = 'От перевозбуждения вы, громко застонав, бурно кончаете.'
			$_gopstr[1] = 'Ваше тело задрожало и вы бурно кончаете.'
			$_gopstr[2] = 'Из ваших уст вырывается громкий стон, когда накатывает оргазм.'
			$_gopstr[3] = 'Вы забились в конвульсиях мощного оргазма.'
			$_gopstr[4] = 'Вы возбужденно задышали и вскоре кончили.'
			$_gopstr[5] = 'От умелых действий вашего партнёра вас накрывает сильный оргазм.'
			$_gopstr[6] = 'От переполняющих вас чувств вы бурно кончаете.'
			$_gopstr[7] = 'От сильнейшего оргазма вас трясёт пару минут.'
			$_gopstr[8] = 'Вы кончаете, испытав непередаваемые ощущения.'
			$_gopstr[9] = 'Вы громко мычите, закусив губу, извиваясь в оргазме от умелых действий партнёра.'
			$_gopstr[10] = 'Комната нaпoлняется жeнским крикoм. Вы кoнчaете грoмкo, никoгo нe стeсняясь.'
			$_gopstr[11] = 'От обилия нахлынувших чувств вы с громким стоном кончаете.'
			gs 'zz_render','','',$_gopstr[RAND(0,11)]
			killvar '$_gopstr'
		end
	end
}
!дрочка гг(когда подсматривает):
$masturb_gg = {
	rnd_masturb_text = rand(1,3)
	if rnd_masturb_text = 1:$rnd_masturb_text = 'Вас эта картина немного возбудила, рукой вы полезли в трусики и начали теребить клитор.'
	if rnd_masturb_text = 2:$rnd_masturb_text = 'Вы от увиденного сильно возбудились и вам захотелось снять напряжение. Запустив руку себе в штаны, вы начали натирать свою киску.'
	if rnd_masturb_text = 3:$rnd_masturb_text = 'Наблюдая вы сильно возбудились, приспустив штаны, запустили руку в трусики начали мастурбировать'
	if mesec > 0:
		!месячные, оргазм не возможен
		horny = 0
		manna -= 10
		'<font color = red><b>Вас эта картина немного возбудила, но так как у вас месячные подрочить не получится...</b></font>'
	elseif mesec <= 0:
		!нет месячных, оргазм возможен
		if horny >=50:'<br><<$rnd_masturb_text>>'
		if horny >=60:'Ваше возбуждение увеличивалось, вы еще быстрее начали натирать свою киску, глубже засовывать пальцы, теребить клитор.'
		if horny >=70:
			orgasm += 1
			horny = 0
			mastr +=1
			'От обилия нахлынувших чувств вы с громким стоном кончили.'
		end
	end
}
!анальная пробка и смазка (1на1)
$gop_sex_analplugin = {
	if analplugin = 1:
		analplugin = 0
		'- "Это что пробка у тебя в жопе?", удивленно спрашивает <<$gopsex_name_npc>>.'
		'- Ага, очко разрабатываю!'
		'- "Похвально, но она сейчас нам мешать будет", сказал он и вынул из вашей попки пробку.<br>'
	end
}
$gop_sex_lubri = {
	if gop_sex_lubri = 0:
		if lubri > 0:
			lubri -= 1
			agape = 1
			horny += 20
			gop_sex_lubri = 1
			$pod_whore_lubri_text = '- "<<$gopsex_name_npc>> подожди если хочешь ебать в жопу, надо же смазать", говорите вы доставая из сумочки тюбик. Вы выдавили анальной смазки себе на руку и смазали свою попку.'
		else
			agape = 2
			horny = 0
		end
		agapetime = totminut + (agape + 1) * 1440
	end
}
!анальная пробка и смазка(групповуха):
$gop_groupsex_analplugin = {
	if analplugin = 1:
		analplugin = 0
		'- "Это что пробка у тебя в жопе?", удивленно спрашивает <<$gop_name_npc>>.'
		'- Ага, для вас очко разрабатываю!'
		'- "Похвально, но она сейчас нам мешать будет", сказал он и вынул из вашей попки пробку.<br>'
	end
}
$gop_groupsex_lubri = {
	if gop_groupsex_lubri = 0:
		if lubri > 0:
			lubri -= 1
			agape = 1
			horny += 20
			gop_groupsex_lubri = 1
			$pod_whore_lubri_text = '- "<<$gop_text_npcr>> подождите если хотите ебать в жопу, надо же смазать", говорите вы доставая из сумочки тюбик. Вы выдавили анальной смазки себе на руку и смазали свою попку.'
		else
			agape = 2
			horny = 0
		end
		agapetime = totminut + (agape + 1) * 1440
	end
}
!знакомые случайно застают гг в подъезде когда ее пользуют
$accview_ggsex = {
	!дела домашние
	rnd_domdela_text = rand(1,9)
	if rnd_domdela_text = 1:$rnd_domdela_text = 'обед приготовить'
	if rnd_domdela_text = 2:$rnd_domdela_text = 'уроки сделать'
	if rnd_domdela_text = 3:$rnd_domdela_text = 'свою комнату убрать'
	if rnd_domdela_text = 4:$rnd_domdela_text = 'посуду помыть'
	if rnd_domdela_text = 5:$rnd_domdela_text = 'в магазин за хлебом сходить'
	if rnd_domdela_text = 6:$rnd_domdela_text = 'пизду отмыть'
	if rnd_domdela_text = 7:$rnd_domdela_text = 'в магазин сходить'
	if rnd_domdela_text = 8:$rnd_domdela_text = 'ужин приготовить'
	if rnd_domdela_text = 9:$rnd_domdela_text = 'вещи постирать'
	!репа: давалка
	rnd_telogg_text = rand(1,15)
	if rnd_telogg_text = 1:$rnd_telogg_text = 'Не пизда а ведро'
	if rnd_telogg_text = 2:$rnd_telogg_text = 'Совсем девку заебали'
	if rnd_telogg_text = 3:$rnd_telogg_text = 'Бездонной дыркой стала наша <<$gop_name_gg>>'
	if rnd_telogg_text = 4:$rnd_telogg_text = 'Опять <<$gop_name_gg>> ты тут отдаешся всем подряд...'
	if rnd_telogg_text = 5:$rnd_telogg_text = 'Опять <<$gop_name_gg>> тебя <<gop_sextext3>>, сколько можно то?, не устала всем подряд дырки подставлять...'
	if rnd_telogg_text = 6:$rnd_telogg_text = 'Бедная девка, на каждом углу <<gop_sextext3>>'
	if rnd_telogg_text = 7:$rnd_telogg_text = '<<$gop_name_gg>> безотказная <<$gop_gg_name2>>'
	if rnd_telogg_text = 8:$rnd_telogg_text = 'Бедная <<$gop_name_gg>>, поди все дырки разъебали'
	if rnd_telogg_text = 9:$rnd_telogg_text = 'Нихуя себе <<$gop_name_gg>>, вот ты пизда рваная'
	if rnd_telogg_text = 10:$rnd_telogg_text = 'Нифига себе <<$gop_name_gg>>, как тебя тут так раскорячили'
	if rnd_telogg_text = 11:$rnd_telogg_text = 'Со всем страх потеряла <<$gop_gg_name2>>'
	if rnd_telogg_text = 12:$rnd_telogg_text = 'Со всем стыд потеряла <<$gop_gg_name2>>'
	if rnd_telogg_text = 13:$rnd_telogg_text = 'Постыдилась бы на право и на лево дырки подставлять, <<$gop_gg_name2>>!'
	if rnd_telogg_text = 14:$rnd_telogg_text = '<<$gop_name_gg>> ну ты и бесстыжая <<$gop_gg_name2>>'
	if rnd_telogg_text = 15:$rnd_telogg_text = 'Ох, <<$gop_name_gg>>, не жалеешь ты себя.'
	!репа: шлюха
	rnd_telogg2_text = rand(1,14)
	if rnd_telogg2_text = 1:$rnd_telogg2_text = '<<$gop_name_gg>> и не стыдно тебе в таком грязном месте подрабатывать?'
	if rnd_telogg2_text = 2:$rnd_telogg2_text = '<<$gop_name_gg>> уже и тут подрабатываешь?'
	if rnd_telogg2_text = 3:$rnd_telogg2_text = '<<$gop_name_gg>> на каждом углу пиздой торгуешь?'
	if rnd_telogg2_text = 4:$rnd_telogg2_text = 'Клиентов себе нашла, с полной отдачей работаешь <<$gop_name_gg>>'
	if rnd_telogg2_text = 5:$rnd_telogg2_text = 'Быстро же ты <<$gop_name_gg>> клиентов себе находишь, я поражаюсь!'
	if rnd_telogg2_text = 6:$rnd_telogg2_text = 'Смотри <<$gop_name_gg>> разъебут все твои дырки, торговать нечем будет!'
	if rnd_telogg2_text = 7:$rnd_telogg2_text = 'Если где попало и всем подряд будешь отдаваться <<$gop_name_gg>>, быстро разшатают твои щели, без работы останешся!'
	if rnd_telogg2_text = 8:$rnd_telogg2_text = 'Что я вижу <<$gop_name_gg>>, опять телом торгуешь!, я поражаюсь какая ты прирожденная <<$gop_gg_name2>>!'
	if rnd_telogg2_text = 9:$rnd_telogg2_text = 'И тут телом торгуешь, ну ты и <<$gop_gg_name2>> <<$gop_name_gg>>, в кого ты такая не пойму.'
	if rnd_telogg2_text = 10:$rnd_telogg2_text = 'Опять за сто рублей дырки подставляешь кому попало и не надоело тебе?'
	if rnd_telogg2_text = 11:$rnd_telogg2_text = '<<$gop_name_gg>> ну ты и <<$gop_gg_name2>>, выходной бы себе сделала!'
	if rnd_telogg2_text = 12:$rnd_telogg2_text = 'Ну ты и <<$gop_gg_name2>> <<$gop_name_gg>>, как не пройду, все пиздой торгуешь...'
	if rnd_telogg2_text = 13:$rnd_telogg2_text = 'Со всем <<$gop_gg_name2>> стыд потеряла, в подъезде отдается...'
	if rnd_telogg2_text = 14:$rnd_telogg2_text = 'Шлюха со всем стыд потеряла, за 50 рублей готова хоть на улице дырки подставлять...'
	!разный текст
	rnd_rodnya_text = rand(1,2)
	if rnd_rodnya_text = 1:$rnd_rodnya_text = 'Мимо проходила'
	if rnd_rodnya_text = 2:$rnd_rodnya_text = 'Мимо шла'
	if rnd_rodnya_text = 3:$rnd_rodnya_text = 'Вас заметила'
	rnd_rodnya_text2 = rand(1,2)
	if rnd_rodnya_text2 = 1:$rnd_rodnya_text2 = 'Мимо проходил'
	if rnd_rodnya_text2 = 2:$rnd_rodnya_text2 = 'Мимо шел'
	if rnd_rodnya_text2 = 3:$rnd_rodnya_text2 = 'Вас заметил'
	rnd_viewgg_text = rand(1,7)
	if rnd_viewgg_text = 1:$rnd_viewgg_text = 'заметив вас'
	if rnd_viewgg_text = 2:$rnd_viewgg_text = 'увидив вас'
	if rnd_viewgg_text = 3:$rnd_viewgg_text = 'запалив вас'
	if rnd_viewgg_text = 4:$rnd_viewgg_text = 'обратив на вас внимание'
	if rnd_viewgg_text = 5:$rnd_viewgg_text = 'кинув на вас взгляд'
	if rnd_viewgg_text = 6:$rnd_viewgg_text = 'метнув на вас взгляд'
	if rnd_viewgg_text = 7:$rnd_viewgg_text = 'увидив как вас <<$gop_sextext3>>'
	if rnd_viewgg_text = 8:$rnd_viewgg_text = 'заметив как вас <<$gop_sextext3>>'
	rnd_talkgg_text = rand(1,2)
	if rnd_talkgg_text = 1:$rnd_talkgg_text = 'сказала'
	if rnd_talkgg_text = 2:$rnd_talkgg_text = 'произнесла'
	rnd_talkgg_text2 = rand(1,2)
	if rnd_talkgg_text2 = 1:$rnd_talkgg_text2 = 'сказал'
	if rnd_talkgg_text2 = 2:$rnd_talkgg_text2 = 'произнес'
	rnd_talkgg2_text = rand(1,14)
	if rnd_talkgg2_text = 1:$rnd_talkgg2_text = 'мягко'
	if rnd_talkgg2_text = 2:$rnd_talkgg2_text = 'язвительно'
	if rnd_talkgg2_text = 3:$rnd_talkgg2_text = 'не громко'
	if rnd_talkgg2_text = 4:$rnd_talkgg2_text = 'тихо'
	if rnd_talkgg2_text = 5:$rnd_talkgg2_text = 'надменно'
	if rnd_talkgg2_text = 6:$rnd_talkgg2_text = 'с ухмылкой'
	if rnd_talkgg2_text = 7:$rnd_talkgg2_text = 'громко'
	if rnd_talkgg2_text = 8:$rnd_talkgg2_text = 'грубо'
	if rnd_talkgg2_text = 9:$rnd_talkgg2_text = 'в пол голоса'
	if rnd_talkgg2_text = 10:$rnd_talkgg2_text = 'оглядываясь'
	if rnd_talkgg2_text = 11:$rnd_talkgg2_text = 'спокойно'
	if rnd_talkgg2_text = 12:$rnd_talkgg2_text = 'со смешком'
	if rnd_talkgg2_text = 13:$rnd_talkgg2_text = 'вяло'
	if rnd_talkgg2_text = 14:$rnd_talkgg2_text = 'зло'
	rnd_namemom_text = rand(1,6)
	if rnd_namemom_text = 1:$rnd_namemom_text = 'Мать'
	if rnd_namemom_text = 2:$rnd_namemom_text = 'Мама'
	if rnd_namemom_text = 3:$rnd_namemom_text = 'Мамка'
	if rnd_namemom_text = 4:$rnd_namemom_text = 'Матушка'
	if rnd_namemom_text = 5:$rnd_namemom_text = 'Мамуля'
	if rnd_namemom_text = 6:$rnd_namemom_text = 'Маман'
	rnd_namesis_text = rand(1,4)
	if rnd_namesis_text = 1:$rnd_namesis_text = 'Сестра'
	if rnd_namesis_text = 2:$rnd_namesis_text = 'Сеструха'
	if rnd_namesis_text = 3:$rnd_namesis_text = 'Сестрица'
	if rnd_namesis_text = 4:$rnd_namesis_text = 'Сестрёнка'
	!рандомизация если застукали ГГ за сексом в подъезде
	!----
	!Мать:
	rnd_mom_txt1 = rand(1,2)
	if rnd_mom_txt1 = 1:$rnd_mom_txt1 = '— Всё <<$rnd_namemom_text>>, иду уже.'
	if rnd_mom_txt1 = 2:$rnd_mom_txt1 = '— <<$rnd_namemom_text>>, ещё один выебет и приду.'
	!---->
	rnd_caught_mom = rand(1,6)
	if rnd_caught_mom = 1 and func('zz_reputation','get') < 4:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg_text>>'
	if rnd_caught_mom = 1 and func('zz_reputation','get') = 4:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg2_text>>'
	if rnd_caught_mom = 2 and momslut >= 1:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — Закончишь ребят обслуживать, не забудь <<$rnd_domdela_text>>'
	if rnd_caught_mom = 2 and momslut < 1:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — Опять ты чудишь <<$gop_name_gg>>, я же тебе просила не ебатьца на каждом углу, со всем от рук отбилась шалава!'
	if rnd_caught_mom = 3 and func('zz_reputation','get') < 4:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, ну ты и место нашла, чтобы ноги раздвинуть: антисанитария сплошная. — А я виновата, что им здесь приспичило? Сейчас доебут, зайду домой, подмоюсь", сказали вы сидя на корточках, вытирая свои разъёбанные дырки салфеткой'
	if rnd_caught_mom = 3 and func('zz_reputation','get') >= 4:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, ну ты и место нашла, где клиентов принимать.'
	if rnd_caught_mom = 4:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, вместо того, чтобы со всем городом ебаться, лучше бы шла уроки делать.<br> — "Да сделала я!"'
	if rnd_caught_mom = 5 and vagina >= 30:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — Доча, ты бы от ебли хоть немного отдохнула — у тебя пизда уже как ведро, не закрывается даже.'
	if rnd_caught_mom = 5 and vagina < 30:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — Доча, ты бы от ебли хоть немного отдохнула.'
	if rnd_caught_mom = 6:$rnd_caught_mom = '<<$rnd_rodnya_text>> ваша <<$rnd_namemom_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: —Дочка, как же тебя разъебли… Ты скоро домой? <br> <<$rnd_mom_txt1>>'
	!------
	!Сестра:
	rnd_caught_sister = rand(1,4)
	if rnd_caught_sister = 1 and func('zz_reputation','get') < 4:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_namemom_text>> просила тебе передать, что бы ты как закончишь, не забыла <<$rnd_domdela_text>>'
	if rnd_caught_sister = 1 and func('zz_reputation','get') = 4:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — Какая же ты шлюха <<$gop_name_gg>>'
	if rnd_caught_sister = 2 and func('zz_reputation','get') < 4:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg_text>>'
	if rnd_caught_sister = 2 and func('zz_reputation','get') = 4:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg2_text>>'
	if rnd_caught_sister = 3:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — Я, блин, бегаю, ищу её везде... А её, оказывается, тут ебут! Колокольчик что ли на шею повесь, чтобы в следующий раз легче найти тебя было. <br>Ключи давай, дырка подзаборная, а то я свои дома забыла... Ладно, не дёргайся, сама возьму. В сумочке? Да вынь ты хуй изо рта, когда тебя старшие спрашивают! В кармане? Всё, нашла уже... Пойдёшь в ванную - вычисти после себя всё с порошком. Не хватало мне ещё после тебя от Святого Духа аборты делать.'
	if rnd_caught_sister = 4 and func('zz_reputation','get') < 4:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, мама тебя обыскалась, а она тут ебётся! Ты долго ещё?<br>— Ох, сестрёнка, сладко очень… Ещё минут 10 поебут и приду.'
	if rnd_caught_sister = 4 and func('zz_reputation','get') = 4:$rnd_caught_sister = '<<$rnd_rodnya_text>> ваша <<$rnd_namesis_text>>, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, ты с клиентами? Долго ещё? Тебе завтра вставать рано.<br>Сеструха обращается к стоящим рядом парням:<br>— Вы ебли уже её?<br>— Неа, первый только начал'
	!----
	!Брат:
	rnd_caught_brother = rand(1,3)
	if rnd_caught_brother = 1 and momslut >= 1:$rnd_caught_brother = '<<$rnd_rodnya_text2>> ваш Брат, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_namemom_text>> просила тебе передать, что бы ты как закончишь, не забыла <<$rnd_domdela_text>>'
	if rnd_caught_brother = 1 and momslut < 1:$rnd_caught_brother = '<<$rnd_rodnya_text2>> ваш Брат, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — Какая же ты шлюха <<$gop_name_gg>>'
	if rnd_caught_brother = 2 and func('zz_reputation','get') < 4:$rnd_caught_brother = '<<$rnd_rodnya_text2>> ваш Брат, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_telogg_text>>'
	if rnd_caught_brother = 2 and func('zz_reputation','get') = 4:$rnd_caught_brother = '<<$rnd_rodnya_text2>> ваш Брат, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_telogg2_text>>'
	if rnd_caught_brother = 3 and $npc['39,qwPornoFootball'] < 16:$rnd_caught_brother = '<<$rnd_rodnya_text2>> ваш Брат, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$gop_name_gg>>, моим корешам только сосёшь, значит, а чёрт знает кому в пизду даёшь?<br>— Так они и не просили. Попросят — дам хоть в пизду, хоть в жопу."'
	!-----
	!Отчим:
	rnd_caught_stepfather = rand(1,2)
	if rnd_caught_stepfather = 1 and momslut >= 1:$rnd_caught_stepfather = '<<$rnd_rodnya_text2>> ваш Отчим, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_namemom_text>> просила тебе передать, что бы ты как закончишь, не забыла <<$rnd_domdela_text>>'
	if rnd_caught_stepfather = 1 and momslut < 1:$rnd_caught_stepfather = '<<$rnd_rodnya_text2>> ваш Отчим, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — Какая же ты шлюха <<$gop_name_gg>>'
	if rnd_caught_stepfather = 2 and func('zz_reputation','get') < 4:$rnd_caught_stepfather = '<<$rnd_rodnya_text2>> ваш Отчим, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_telogg_text>>'
	if rnd_caught_stepfather = 2 and func('zz_reputation','get') = 4:$rnd_caught_stepfather = '<<$rnd_rodnya_text2>> ваш Отчим, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_telogg2_text>>'
	!----------
	!Разные нпс:
	rnd_caught_othernpc = rand(1,13)
	if rnd_caught_othernpc = 1 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> дядя Миша, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_telogg_text>>'
	if rnd_caught_othernpc = 1 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> дядя Миша, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$rnd_telogg2_text>>'
	if rnd_caught_othernpc = 2 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$shulga_name_rnd>> проходя мимо увидил как вас <<$gop_sextext3>>, показал большой палец пацанам, сказав: — "<<$rnd_telogg_text>>" и пошел дальше по своим делам'
	if rnd_caught_othernpc = 2 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$shulga_name_rnd>> проходя мимо увидил как вас <<$gop_sextext3>>, показал большой палец пацанам и не скрывая улыбки сказал вам: — "<<$rnd_telogg2_text>>" и пошел дальше по своим делам'
	if rnd_caught_othernpc = 3 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> тетя Люда, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg_text>>'
	if rnd_caught_othernpc = 3 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> тетя Люда, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: -"<<$rnd_telogg2_text>>"'
	if rnd_caught_othernpc = 4 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> Наташа Белова, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg_text>>'
	if rnd_caught_othernpc = 4 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> Наташа Белова, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg2_text>>'
	if rnd_caught_othernpc = 5 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> Юля Милова, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg_text>>'
	if rnd_caught_othernpc = 5 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> Юля Милова, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$rnd_telogg2_text>>'
	if rnd_caught_othernpc = 6:$rnd_caught_othernpc = 'Вас заметили мелкие пацаны, подкалывая друг друга они щёлкали происходящее на телефон, вы краем ухо услышали их разговор: — "Глянь! Глянь! Да не туда. Во-он там! Бля-аа!!! Снимай, снимай скорее! Охуеть! Никогда раньше вживую не видел, как баб <<$gop_sextext3>>!", "Ни-ху-я ж себе!", "Вот это пелотка!", "А что, разве в жопу тоже можно?", "Дебил, туда даже руку по локоть суют. Тёлки от этого прутся. Я у Киряна фотку видел", "Гонишь!", "На что спорим?"..."'
	if rnd_caught_othernpc = 7:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> дядя Миша, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — "Ба! Какие лю-юди! Яблочко от яблоньки, гляжу, не далеко укатилось. Прям, один-в-один: сиськи врозь, пизда нараспашку. И глазки такие хитрющие-хитрющие... Зайди потом ко мне: поговорить надо."'
	if rnd_caught_othernpc = 7 and $npc['39,qwPornoFootball'] < 16:$rnd_caught_othernpc = 'Вас заметили мимо проходящие друзья брата, остановились и активно начали вас обсуждать: — Ебать-копать! Мы-то с ней как с принцессой: только в ротик, спасибо-пожалуйста-досвиданья. А она, оказывается, проблядь та ещё. Да вааще пиздец! Знали б раньше, <<$gop_sextext3>> бы сразу эту пиздорванку втроём в одну калитку, как всегда и хотели. А то всё - Све-еточка... Тебе ж не тру-удно нам помочь, да?.. Всё-таки ж сестра Коляна. Старшая, к тому же. Рыцари, бля... Теперь - всё!... Блядей ведь, не спрашивают, в них же сразу хуями тычут? Правда ж, <<$gop_name_gg>>? Гы-ы!!! Кивает! Ах, ты ж наша пре-елесть! Охуеть, подфартило: теперь свой спермоприёмник есть! До скорого, пиздопроёбина. Готовь дупло! Пойдём, Коляна обрадуем. Он с детства на неё обдрочился... Чур я в жопу первый! А в рот три сразу войдут? Давно надо было попробовать. Стеснялись, бля, предложить, джентельмены ебучие...'
	if rnd_caught_othernpc = 8:$rnd_caught_othernpc = 'К вам подошла уборщица в подъезде: — Так, мальчики! Отлепитесь-ка на секунду от своей игрушки. Будете уходить - бутылки не выбрасывайте, на подоконник поставьте. Я их сама потом уберу. И нацюцюрники не разбрасывайте тут повсюду. Каждый день за вами по пол-ведра собираю! Лучше - вообще их не доставайте: без них же и вам и вашей коханке приятней будет. Или в сумочку их ей аккуратно складывайте: пусть как кончит, с собой забирает свои трофеи. Эй! Эй!!! Многостаночница!!! Глотай, а не на пол сплёвывай!!! Поняла? Вот же ж сучилища облямудованная! За каждой блядью подтирать - никакого здоровья не хватит! И из пизды мне тут на пол не сифонь! А то саму языком вылизывать заставлю!'
	if rnd_caught_othernpc = 9:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> Тётя Люда: — "Привет, <<$gop_name_gg>>! Как жизнь половая? Подумать только, вроде только недавно, такая вся из себя девочка-припевочка в бантиках, краснея и заикаясь, впервые у меня в аптеке прокладки покупала. А теперь тут на всю округу своей лоханкой хлюпает, аж с улицы слышно. Совсем уже большая стала. И рачком здесь лучше не стой, дурочка. Знаешь, как шлюх от порядочных девочек отличают? По содранным коленкам. Приходи за зелёнкой, в полцены продам, горе луковое"'
	if rnd_caught_othernpc = 10:$rnd_caught_othernpc = 'Вас заметили: Мамашка, гуляющая с дочкой, хватая ту на руки — Отвернись, не смотри. Эта девочка просто маму не слушала, поэтому её и наказывают. Слышишь, как теперь маму зовёт? Слушайся маму, и никогда не станешь такой, как она. <br>Обращаясь к вам: — До дома дотерпеть не могла, шалашовка?! Обязательно надо именно здесь своей мандищей трясти?! Тут, между прочим, дети гуляют!'
	if rnd_caught_othernpc = 11 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> <<$shulga_name_rnd>>, остановился и спросил у вас: — <<$gop_name_gg>>, ты нахрена этим дрищам даёшь?<br>— Вообще-то я всем даю.'
	if rnd_caught_othernpc = 11 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> <<$shulga_name_rnd>>, остановился и спросил у вас: — <<$gop_name_gg>>, у тебя сегодня сеанс благотворительности что ли?<br>— С какого перепуга. Я незнакомым бесплатно не даю.'
	if rnd_caught_othernpc = 12 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> дядя Миша, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$gop_name_gg>>, тебя разогрели уже, может уважишь старика?<br>— дядь Миш, я как тут закончу к вам заскочу!'
	if rnd_caught_othernpc = 12 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text2>> дядя Миша, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text2>>: — <<$gop_name_gg>>, тебя разогрели уже, может уважишь старика?<br>— Дядь Миш я ближе к вечеру к вам заскочу, но за бесплатно только отсосать могу, а в пизду или в попку за денежку.<br>— Хорошо я обжумаю твое предложение и буду ждать тебя вечером!'
	if rnd_caught_othernpc = 13 and func('zz_reputation','get') < 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> тетя Люда, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, опять своих ёбарей притащила! Тебя на весь подъезд слышно!<br>— Тёть Люб, я тихо не умею.'
	if rnd_caught_othernpc = 13 and func('zz_reputation','get') = 4:$rnd_caught_othernpc = '<<$rnd_rodnya_text>> тетя Люда, <<$rnd_viewgg_text>> <<$rnd_talkgg2_text>> <<$rnd_talkgg_text>>: — <<$gop_name_gg>>, ты мне завтра опять план сделаешь!'
	!выбираем нпс которое запалит гг
	rnd_caughtgg_npc = rand(1,5)
		!мама
		if rnd_caughtgg_npc = 1:
			motherKnowWhore = 1
			$rnd_caughtgg_npc = '<<$rnd_caught_mom>>'
		end
		!разные нпс (Дядя Миша, Шульга, Тетя Люда и т.д.)
		if rnd_caughtgg_npc = 2:$rnd_caughtgg_npc = '<<$rnd_caught_othernpc>>'
		!сестра
		if rnd_caughtgg_npc = 3:
			sisterknowslut = 2
			$rnd_caughtgg_npc = '<<$rnd_caught_sister>>'
		end
		!брат
		if rnd_caughtgg_npc = 4:
			brotherknowslut = 2
			$rnd_caughtgg_npc = '<<$rnd_caught_brother>>'
		end
		!отчим
		if rnd_caughtgg_npc = 5:$rnd_caughtgg_npc = '<<$rnd_caught_stepfather>>'
	!рандомно палим гг
	rnd_caughtgg_view = rand(0,100)
		if rnd_caughtgg_view < 50:$rnd_caughtgg_view = ''
		if rnd_caughtgg_view >= 50 and hour >= 0 and hour < 5:$rnd_caughtgg_view = ''
		if rnd_caughtgg_view >= 50 and hour >= 5 and hour <= 23:$rnd_caughtgg_view = '<br><font color = red><b><<$rnd_caughtgg_npc>></b></font>'
	'<<$rnd_caughtgg_view>>'
}
!если гг шлюха
gg_whore_text = RAND(0,7)
	if gg_whore_text = 0:$gg_whore_text = 'шлюшка'
	if gg_whore_text = 1:$gg_whore_text = 'проститутка'
	if gg_whore_text = 2:$gg_whore_text = 'шлюха'
	if gg_whore_text = 3:$gg_whore_text = 'девка легкого поведения'
	if gg_whore_text = 4:$gg_whore_text = 'баба легкого поведения'
	if gg_whore_text = 5:$gg_whore_text = 'девушка легкого поведения'
	if gg_whore_text = 6:$gg_whore_text = 'шмара'
	if gg_whore_text = 7:$gg_whore_text = 'индивидуалка'
!текст обращения к гг, пацанам и т.д.
!рандомные вариации имени Васи Шульгина
shulga_name_rnd = RAND(0,5)
	if shulga_name_rnd = 0:$shulga_name_rnd = 'Шульга'
	if shulga_name_rnd = 1:$shulga_name_rnd = 'Васян'
	if shulga_name_rnd = 2:$shulga_name_rnd = 'Васёк'
	if shulga_name_rnd = 3:$shulga_name_rnd = 'Васька'
	if shulga_name_rnd = 4:$shulga_name_rnd = 'Василий'
	if shulga_name_rnd = 5:$shulga_name_rnd = 'Вася'
gop_name_gg = RAND(0,3)
	if gop_name_gg = 0:$gop_name_gg = '<<$name[2]>>'
	if gop_name_gg = 1:$gop_name_gg = '<<$name>>'
	if gop_name_gg = 2:$gop_name_gg = '<<$name[1]>>'
	if gop_name_gg = 3:$gop_name_gg = '<<$name[3]>>'
gop_gg_name = RAND(0,30)
	if gop_gg_name = 0:$gop_gg_name = 'шмара'
	if gop_gg_name = 1:$gop_gg_name = 'давалка'
	if gop_gg_name = 2:$gop_gg_name = 'шлюха'
	if gop_gg_name = 3:$gop_gg_name = 'хуесоска'
	if gop_gg_name = 4:$gop_gg_name = 'защеканка'
	if gop_gg_name = 5:$gop_gg_name = 'дырка'
	if gop_gg_name = 6:$gop_gg_name = 'блядь'
	if gop_gg_name = 7:$gop_gg_name = 'шлюшка'
	if gop_gg_name = 8:$gop_gg_name = 'мокрощелка'
	if gop_gg_name = 9:$gop_gg_name = 'сука'
	if gop_gg_name = 10:$gop_gg_name = 'сучка'
	if gop_gg_name = 11:$gop_gg_name = 'общая дырка'
	if gop_gg_name = 12:$gop_gg_name = 'анальная сука'
	if gop_gg_name = 13:$gop_gg_name = 'вафлёрша'
	if gop_gg_name = 14:$gop_gg_name = 'наша игрушка'
	if gop_gg_name = 15:$gop_gg_name = 'спермоприемник'
	if gop_gg_name = 16:$gop_gg_name = 'поблядушка'
	if gop_gg_name = 17:$gop_gg_name = 'бесплатная блядь'
	if gop_gg_name = 18:$gop_gg_name = 'соска'
	if gop_gg_name = 20:$gop_gg_name = 'ебливая дырка'
	if gop_gg_name = 22:$gop_gg_name = 'сасалка'
	if gop_gg_name = 23:$gop_gg_name = 'ебанашка'
	if gop_gg_name = 24:$gop_gg_name = 'трехдырочная'
	if gop_gg_name = 25:$gop_gg_name = 'безотказная давалка'
	if gop_gg_name = 26:$gop_gg_name = 'школьная давалка'
	if gop_gg_name = 27:$gop_gg_name = 'дворовая блядь'
	if gop_gg_name = 28:$gop_gg_name = 'потаскушка'
	if gop_gg_name = 29:$gop_gg_name = '<<$gnikname>>'
gop_gg_name2 = RAND(1,11)
	if gop_gg_name2 = 1:$gop_gg_name2 = 'шмара'
	if gop_gg_name2 = 2:$gop_gg_name2 = 'давалка'
	if gop_gg_name2 = 3:$gop_gg_name2 = 'шлюха'
	if gop_gg_name2 = 4:$gop_gg_name2 = 'сука'
	if gop_gg_name2 = 5:$gop_gg_name2 = 'проблядь'
	if gop_gg_name2 = 6:$gop_gg_name2 = 'шалава'
	if gop_gg_name2 = 7:$gop_gg_name2 = 'прошмандовка'
	if gop_gg_name2 = 8:$gop_gg_name2 = 'блядь'
	if gop_gg_name2 = 9:$gop_gg_name2 = 'потаскуха'
	if gop_gg_name2 = 10:$gop_gg_name2 = 'блядуха'
gop_text_npcr = RAND(1,4)
	if gop_text_npcr = 1:$gop_text_npcr = 'пацаны'
 	if gop_text_npcr = 2:$gop_text_npcr = 'ребята'
 	if gop_text_npcr = 3:$gop_text_npcr = 'кореша'
 	if gop_text_npcr = 4:$gop_text_npcr = 'друганы'
gop_name_npc = RAND(1,3)
	if gop_name_npc = 1:$gop_name_npc = 'Вася'
	if gop_name_npc = 2:$gop_name_npc = 'Витек'
	if gop_name_npc = 3:$gop_name_npc = 'Дэн'
gop_family_npc = RAND(1,3)
	if gop_family_npc = 1:$gop_family_npc = 'Шульга'
	if gop_family_npc = 2:$gop_family_npc = 'Котов'
	if gop_family_npc = 3:$gop_family_npc = 'Рыжов'
gop_sextext1 = RAND(0,7)
	if gop_sextext1 = 0:$gop_sextext1 = 'пользовать'
	if gop_sextext1 = 1:$gop_sextext1 = 'ебать'
	if gop_sextext1 = 2:$gop_sextext1 = 'трахать'
	if gop_sextext1 = 3:$gop_sextext1 = 'драть'
	if gop_sextext1 = 4:$gop_sextext1 = 'шпилить'
	if gop_sextext1 = 5:$gop_sextext1 = 'сношать'
	if gop_sextext1 = 6:$gop_sextext1 = 'дрючить'
	if gop_sextext1 = 7:$gop_sextext1 = 'сношать'
gop_sextext2 = RAND(0,7)
	if gop_sextext2 = 0:$gop_sextext2 = 'ебали'
	if gop_sextext2 = 1:$gop_sextext2 = 'драли'
	if gop_sextext2 = 2:$gop_sextext2 = 'шпилили'
	if gop_sextext2 = 3:$gop_sextext2 = 'трахали'
	if gop_sextext2 = 4:$gop_sextext2 = 'вертели'
	if gop_sextext2 = 5:$gop_sextext2 = 'пользовали'
	if gop_sextext2 = 6:$gop_sextext2 = 'дрючили'
	if gop_sextext2 = 7:$gop_sextext2 = 'сношали'
gop_sextext3 = RAND(0,8)
	if gop_sextext3 = 0:$gop_sextext3 = 'имеют'
	if gop_sextext3 = 1:$gop_sextext3 = 'пользуют'
	if gop_sextext3 = 2:$gop_sextext3 = 'трахают'
	if gop_sextext3 = 3:$gop_sextext3 = 'ебут'
	if gop_sextext3 = 4:$gop_sextext3 = 'дрючат'
	if gop_sextext3 = 5:$gop_sextext3 = 'используют'
	if gop_sextext3 = 6:$gop_sextext3 = 'шпилят'
	if gop_sextext3 = 7:$gop_sextext3 = 'дерут'
	if gop_sextext3 = 8:$gop_sextext3 = 'сношают'
gop_text3 = RAND(0,4)
	if gop_text3 = 0:$gop_text3 = 'трогать'
	if gop_text3 = 1:$gop_text3 = 'мацать'
	if gop_text3 = 2:$gop_text3 = 'щупать'
	if gop_text3 = 3:$gop_text3 = 'мять'
	if gop_text3 = 4:$gop_text3 = 'гладить'
!Бухач
gop_text_beer2 = RAND(0,9)
	if gop_text_beer2 = 0:$gop_text_beer2 = '<<$gop_name_npc>> открыл новую бутылку пива, сделал пару глотков и передал вам. Вы стали не торопясь выпивать вместе с пацанами.'
	if gop_text_beer2 = 1:$gop_text_beer2 = '<<$gop_name_npc>> налил в пустой стакан пиво и передал вам. Вы стали не спеша выпивать вместе с пацанами.'
	if gop_text_beer2 = 2:$gop_text_beer2 = '<<$gop_name_npc>> передал вам бутылку пива. Вы стали взахлеб ее опрокидывать. <<$gop_family_npc>> громко сказал "Алкашка-ебанашка".'
	if gop_text_beer2 = 3:$gop_text_beer2 = '<<$gop_name_npc>> откупорил и дал вам бутылку пива. Вы жадно ее вылакали. <<$gop_text_npcr>> аж прихуели от такого поворота.'
	if gop_text_beer2 = 4:$gop_text_beer2 = '<<$gop_name_npc>> взял баклажку пива, налил в стакан и передал вам. Вы не спеша вальяжно развалившись на лавочке, бухая с гопорями.'
	if gop_text_beer2 = 5:$gop_text_beer2 = '<<$gop_name_npc>> открыл бутылку пива и передал вам. Вы не торопясь небольшими глотками выпивали.'
	if gop_text_beer2 = 6:$gop_text_beer2 = '<<$gop_name_npc>> откупорил бутылку пива и отдал вам. Вы с жадностью ее осушили и плюхнулись на лавочку.'
	if gop_text_beer2 = 7:$gop_text_beer2 = '<<$gop_name_npc>> сделал глоток из 2х литровой баклажки пива и отдал вам. Вы сделали пару глотков и <<$gop_family_npc>> забрал ее у вас.'
	if gop_text_beer2 = 8:$gop_text_beer2 = '<<$gop_name_npc>> глотнул из полторашки и передал вам. Вы с жадностью начали лакать из бутылки... <<$gop_family_npc>> со словами "дура нам оставь" отнял у вас баклажку'
	if gop_text_beer2 = 9:$gop_text_beer2 = '-"На держи"- <<$gop_name_npc>> протягивает вам недопитую бутылку жигуля и с усмешкой смотрит как вы жадно выпиваете ее. Ваше настроение немного улучшается.'
gop_beer_drova = RAND (0,8)
	if gop_beer_drova = 0:$gop_beer_drova = '<<$gop_gg_name>>, все пиво выжрала!, теперь давай в позу становись <<$gop_sextext1>> будем!'
	if gop_beer_drova = 1:$gop_beer_drova = 'Все наше пиво вылакала <<$gop_gg_name>>, теперь в позу вставай для отработки'
	if gop_beer_drova = 2:$gop_beer_drova = '<<$gop_name_gg>> прекращай бухать, давай в позу становись!'
	if gop_beer_drova = 3:$gop_beer_drova = 'Ебать ты <<$gop_name_gg>>-Алкашка, больше не нальем, а то и так почти в дрова, давай в позу вставай, <<$gop_sextext1>> будем!'
	if gop_beer_drova = 4:$gop_beer_drova = 'Набухалась?, теперь отрабатывай: готовь станок, вставай в позу!'
	if gop_beer_drova = 5:$gop_beer_drova = 'Алё <<$gop_name_gg>>, все пиво выжрала <<$gop_gg_name>>, давай в позу встань, <<$gop_sextext1>> будем!'
	if gop_beer_drova = 6:$gop_beer_drova = 'Все <<$gop_name_gg>> халява кончилась, в позу вставай <<$gop_sextext1>> тебя будем!'
	if gop_beer_drova = 7:$gop_beer_drova = '<<$gop_name_gg>>, ты еще стоять то можешь?, Больше не нальем, заебала нас на пиво разводить, давай в позу и отрабатывай!'
	if gop_beer_drova = 8:$gop_beer_drova = 'Такими темпами дрова ебать придется, а я это не люблю. <<$gop_text_npcr>> больше её не наливаем! <<$gop_name_gg>> вставай в позу и показывай свой станок'
!позы, приставания и т.д.
txt_sveta_obol = RAND(0,8)
	if txt_sveta_obol = 0:$txt_sveta_obol = 'обольстительной'
	if txt_sveta_obol = 1:$txt_sveta_obol = 'соблазнительной'
	if txt_sveta_obol = 2:$txt_sveta_obol = 'блядской'
	if txt_sveta_obol = 3:$txt_sveta_obol = 'очаровательной'
	if txt_sveta_obol = 4:$txt_sveta_obol = 'привлекательной'
	if txt_sveta_obol = 5:$txt_sveta_obol = 'пленительной'
	if txt_sveta_obol = 6:$txt_sveta_obol = 'чарующей'
	if txt_sveta_obol = 7:$txt_sveta_obol = 'прелестной'
	if txt_sveta_obol = 8:$txt_sveta_obol = 'восхитительной'
poza_gop_txt3 = RAND(0,7)
	if poza_gop_txt3 = 0:$poza_gop_txt3 = 'удачно'
	if poza_gop_txt3 = 1:$poza_gop_txt3 = 'сексуально'
	if poza_gop_txt3 = 2:$poza_gop_txt3 = 'по блядски'
	if poza_gop_txt3 = 3:$poza_gop_txt3 = 'возбуждающе'
	if poza_gop_txt3 = 4:$poza_gop_txt3 = 'вульгарно'
	if poza_gop_txt3 = 5:$poza_gop_txt3 = 'красиво'
	if poza_gop_txt3 = 6:$poza_gop_txt3 = 'хорошо'
	if poza_gop_txt3 = 7:$poza_gop_txt3 = 'отлично'
poza_gop_txt2 = RAND(0,10)
	if poza_gop_txt2 = 0:$poza_gop_txt2 = 'Отличную позу наша <<$gop_gg_name>> выбрала'
	if poza_gop_txt2 = 1:$poza_gop_txt2 = 'В супер позу наша <<$gop_gg_name>> встала, молодец'
	if poza_gop_txt2 = 2:$poza_gop_txt2 = 'Ахуеть <<$gop_gg_name>> встала, у меня аж встал'
	if poza_gop_txt2 = 3:$poza_gop_txt2 = '<<$poza_gop_txt3>> встала, покорная <<$gop_gg_name>>'
	if poza_gop_txt2 = 4:$poza_gop_txt2 = '<<$gop_text_npcr>> смотрите станок готов'
	if poza_gop_txt2 = 5:$poza_gop_txt2 = 'Cмотрите как <<$poza_gop_txt3>> встала, первосортная <<$gop_gg_name>>'
	if poza_gop_txt2 = 6:$poza_gop_txt2 = 'Cмотрите как <<$poza_gop_txt3>> встала <<$gop_name_gg>> наша'
	if poza_gop_txt2 = 7:$poza_gop_txt2 = 'Cмотрите как <<$poza_gop_txt3>> встала наша <<$gop_name_gg>>'
	if poza_gop_txt2 = 8:$poza_gop_txt2 = 'Ну <<$gop_gg_name>>, <<$poza_gop_txt3>> в позу встала'
	if poza_gop_txt2 = 9:$poza_gop_txt2 = 'Хаха, <<$gop_gg_name>>, <<$poza_gop_txt3>> стоишь, глаз радуется'
	if poza_gop_txt2 = 10:$poza_gop_txt2 = '<<$gop_name_gg>>, а мне нравится твой выбор позы, молодец заслужила крепкий хуй'
poza_gop_txt = RAND(0,9)
	if poza_gop_txt = 0:$poza_gop_txt = 'Ну что <<$gop_text_npcr>> кто её первый будет <<$gop_sextext1>>?'
	if poza_gop_txt = 1:$poza_gop_txt = '<<$gop_text_npcr>> кто первый будет это тело <<$gop_sextext1>>?'
	if poza_gop_txt = 2:$poza_gop_txt = '<<$gop_text_npcr>> кто первый ее <<$gop_sextext1>> будет?'
	if poza_gop_txt = 3:$poza_gop_txt = 'Давайте <<$gop_text_npcr>> решим кого первого она обслужит?'
	if poza_gop_txt = 4:$poza_gop_txt = '<<$gop_text_npcr>> надо решить кого она первого обслужит.'
	if poza_gop_txt = 5:$poza_gop_txt = '-"Может я первый ее <<$gop_sextext1>> буду?, для вас <<$gop_text_npcr>> подготовлю, хаха.", спрашивает <<$gop_family_npc>>'
	if poza_gop_txt = 6:$poza_gop_txt = '<<$gop_text_npcr>>, ну и кто сейчас ее <<$gop_sextext1>> будет?'
	if poza_gop_txt = 7:$poza_gop_txt = '-"<<$gop_text_npcr>>, может она для начала у меня в рот возьмет?", уточняет <<$gop_family_npc>>'
	if poza_gop_txt = 8:$poza_gop_txt = '<<$gop_family_npc>> говорит: -"<<$gop_text_npcr>>, давайте я первый её <<$gop_sextext1>> буду?!.'
	if poza_gop_txt = 9:$poza_gop_txt = '-"<<$gop_text_npcr>>, хочу первый её <<$gop_sextext1>>, пока она еще не зашкварена.", говорит <<$gop_family_npc>>'
poza_txt = RAND(0,17)
	if poza_txt = 0:$poza_txt = 'Вы выбрали наиболее удобную для вас позу.'
	if poza_txt = 1:$poza_txt = 'Вам показалось эта поза более <<$txt_sveta_obol>>.'
	if poza_txt = 2:$poza_txt = 'Вы встали в удобную вам позу. Которая была еще и <<$txt_sveta_obol>>'
	if poza_txt = 3:$poza_txt = 'Вы решили встать в такую позу. Она была вполне <<$txt_sveta_obol>>'
	if poza_txt = 4:$poza_txt = 'Вам захотелось встать именно в такую позу.'
	if poza_txt = 5:$poza_txt = 'Вы выбрали вот такую блядскую позу и подмигнули ребятам.'
	if poza_txt = 6:$poza_txt = 'Вы подумали и опустились в такую позу.'
	if poza_txt = 7:$poza_txt = 'Вам хотелось встать именно в такую позу. Она была <<$txt_sveta_obol>>'
	if poza_txt = 8:$poza_txt = 'Вы покорно встали в позу. Как вам показалось она была наиболее <<$txt_sveta_obol>>'
	if poza_txt = 9:$poza_txt = 'Вы спокойно поставили бутылку и встали в такую стандартную позу.'
	if poza_txt = 10:$poza_txt = 'Вам пришлось встать в развратную позу и показать все свои прелести.'
	if poza_txt = 11:$poza_txt = 'Не долго думаю вы решили встать в стандартную для такого случая позу.'
	if poza_txt = 12:$poza_txt = 'Немножко подумав вы встали в сексуальную позу.'
	if poza_txt = 13:$poza_txt = 'Вы плохо соображали в какую позу они хотят что бы вы встали и вам показалось что такая поза будет более <<$txt_sveta_obol>>.'
	if poza_txt = 14:$poza_txt = 'Вы решили долго не думать и встали вот так. Поза была <<$txt_sveta_obol>>'
	if poza_txt = 15:$poza_txt = 'Долго вам соображать не дали и вы встали в стандартную позу.'
	if poza_txt = 16:$poza_txt = 'Вам не особо хотелось что-то выдумывать и вы выбрала обычную позу.'
	if poza_txt = 17:$poza_txt = 'Вам захотелось встать именно в эту позу. Вам она показалась более <<$txt_sveta_obol>>'
!===========================================================!
!-------------!
! Текст секса !
!=============!
!куни:
$text_sex_cun = {
	$_gopstr[0] = 'Вы запустили руку ему в шевелюру и потянула его голову вниз. Он поцеловал вашу киску.<br>Вы еще больше выпятили киску вперёд, а <<$gopsex_name_npc>> припал к ней губами.<br>— Ты знаешь, она у тебя красивая.<br>— Знаю, — улыбнулись вы.<br>Его язычок проникал вам в киску, раздвигая губки, а ваш стон постепенно переходил на крик.'
	$_gopstr[1] = '<<$gopsex_name_npc>> прислонил лицо к вашей киске.<br>— Нравится? — спросили вы.<br>— Очень, — и он прильнул к вашему клитору, лаская его языком. Лизал он хорошо. Тем более для его возраста. Видно было, что он не впервые опускает свой язык в лоно девушки.<br>— Ты хорошо лижешь. Ты тренируешься?<br>— Иногда, — сказал он с улыбкой.<br>— У тебя есть девушка?<br>— Нет, — он отвечал время от времени отрываясь от процесса.<br>— А с кем ты там научился?<br>— Есть знакомая.<br>— У-у. Я её знаю? Она со школы?<br>— Нет. Потом расскажу.'
	$_gopstr[2] = 'Вы легли на спину и раздвинули широко ноги. <<$gopsex_name_npc>> отодвинул край трусиков и прильнул к вашей пизде.<br>Он лизал и сосал губы, клитор, а иногда входил внутрь язычком, а вы стонали, обхватив его голову и прижимая сильнее к своей мокрой киске.'
	$_gopstr[3] = '<<$gopsex_name_npc>> положил вас на спину и припал к вашему сокровищу. Он вылизывал клитор, затем вставил сразу 2 пальца в вашу вагину и стал потрахивать.<br>Начали раздаваться хлюпающие звуки, вы застонали, а <<$gopsex_name_npc>> лишь ускорил движения.'
	$_gopstr[4] = 'Вы расставили ножки в стороны, предоставив его взору свою сокровенную киску. Не раздумывая, <<$gopsex_name_npc>> стал покрывать поцелуями ваше сокровище.<br>Он прошелся язычком по клитору, добрался до влагалища, оно оказалось вовсю влажным. Вы давно готовы к сношению. В общем трах можно было начинать прямо сейчас.<br>Но <<$gopsex_name_npc>> не спешил. Какое то время он ласкал вас языком, пальчиками, слушая ваши сладкие стоны. Вы вся извивались, но ни о чем не просили, просто наслаждались моментом.'
	$_gopstr[5] = '- "<<$gopsex_name_npc>>, полижи мне письку", ласково просите вы.<br>- С удовольствием это сделаю!, отвечает <<$gopsex_name_npc>>, приближая свои губы к вашей письке и начинает умело вылизывать'
	gs 'zz_render','','',$_gopstr[rand(0,5)]
	killvar '$_gopstr'
}
!-------------------------
!69:
$text_sex_69 = {
	txt_sex_69 = RAND(0,1)
	if txt_sex_69 = 0:$txt_sex_69 = 'Ваши <<$liptalk3>> податливо принял его член, страстно обсасывая его со всех сторон, словно чупа-чупс, помогали себе язычком, который нежно щекотал уздечку.<br><<$gopsex_name_npc>> тем временем обхватил кончиками пальцев клитор и нежно мял его между ними, языком тем временем обследуя вашу дырочку, которая уже давно была готова принять в себя нечто большее...'
	if txt_sex_69 = 1:$txt_sex_69 = '<<$gopsex_name_npc>> лёг на спину, взял вашу ногу и перекинул через себя так, чтобы ваша попка находилась прямо перед его лицом.<br>Запустив язычок между ваших половых губок, он почувствовал как вы в очередной раз глубоко заглотили его член. Потом чуть ослабив хватку начали его обсасывать своими <<$liptalk>>.'
	'<<$txt_sex_69>>'
}
!-------------------------
!дрочка руками
$text_sex_hj = {
	txt_sex_hj = RAND(0,3)
	if txt_sex_hj = 0:$txt_sex_hj = '<<$gopsex_name_npc>> без разговоров сунул свой член вам в лицо.<br>— Вот это по-мужски, — со смехом сказали вы, беря член в руку и принимаясь дрочить.'
	if txt_sex_hj = 1:$txt_sex_hj = 'Вы взяли его член своей рукой, он увеличивался на глазах. Вы начали надрачивать его, любуясь им.'
	if txt_sex_hj = 2:$txt_sex_hj = '<<$gopsex_name_npc>> сунул в вашу руку член. Вы неуверенно зажали упругий, толстенький ствол в маленькой руке. Он заставил вас сжать руку сильнее.<br>- "Не отпускай... Двигай рукой вверх-вниз...", распоряжался он, показывая, как надо делать.<br>- "Не так резко... Вот так. Не дергай... Да, вот так. Хорошо... Еще... Еще!"'
	if txt_sex_hj = 3:$txt_sex_hj = '<<$gopsex_name_npc>> просит подрочить ему, вы берете его хуй в руку и начинаете гонять шкурку туда-сюда.'
	'<<$txt_sex_hj>>'
}
!-------------------------
!минет
$text_sex_bj = {
	txt_sex_bj = RAND(0,7)
	if txt_sex_bj = 0:$txt_sex_bj = 'Вы взяли его член своими <<$liptalk>>, и <<$gopsex_name_npc>> начал трахать вас в рот.'
	if txt_sex_bj = 1:$txt_sex_bj = 'Вы взяли член в рот и принялись его сосать. <<$gopsex_name_npc>> схватился руками за ваши <<$hapri>> <<$hair2>> и насаживал вашу голову на свой хуй.<br>Вы заглатывали член, причмокивая, водили по нему рукой, ощущали своими <<$liptalk>> на нём каждую вену и каждый бугорок.'
	if txt_sex_bj = 2:$txt_sex_bj = 'Вы обхватили его член рукой и, надрачивая, взяли своими <<$liptalk>> головку в рот. Член ещё больше затвердел и принял внушительные размеры.<br>Вы уже давно научилась довольно неплохо заглатывать член, и с тех пор всегда это применяли.<br><<$gopsex_name_npc>> был в восторге. Одной рукой вы ласкали его яички, другой — водили рукой по члену, время от времени отпуская, чтобы взять его в рот полностью.'
	if txt_sex_bj = 3:$txt_sex_bj = '<<$gopsex_name_npc>> ничего не сказал, взял вас за <<$hapri>> <<$hair2>>, наклонив вашу голову к своему члену. Начал двигать свои тазом, таким образом трахая вас в рот.'
	if txt_sex_bj = 4:$txt_sex_bj = '<<$gopsex_name_npc>> взял вас за <<$hapri>> <<$hair2>> и начал двигать вашей головой в такт своим движениям. Вы немного закашлялись, но продолжали сосать.'
	if txt_sex_bj = 5:$txt_sex_bj = 'Вы начали лизать его член своим язычком, потом немного набрав слюней, взяли его своими <<$liptalk>> и стали сосать, помогая себе рукой. '
	if txt_sex_bj = 6:$txt_sex_bj = 'Взяв его хуй в рот, своим язычком ласкали его то сбоку, то снизу, то по центру. Потом сильнее сжали <<$liptalk>> и стали быстрее водить ртом туда-сюда.<br>Выпустили член наружу, и посмотрев на свою работу, получили удовольствие. Головка стала еще тверже, красней, блестящей.<br>У вас аж томно заныло внизу живота. Загнули член вверх, и повели языком от яиц до головки, потом со всех сторон, и впилась своими <<$liptalk>> в его головку. '
	if txt_sex_bj = 7:$txt_sex_bj = 'Влажными <<$liptalk>> нежно обхватываете его член, вбираете в рот, теребите его язычком, ласкаете рукой и мнете его мошонку.<br>Вбираете его все сильнее, причмокивая, слыша, как ваши слюнки обволакивают его головку. Ласкаете язычком, трётесь о его головку. <<$gopsex_name_npc>> сладко стонет. '
	'<<$txt_sex_bj>>'
}
!-------------------------
!глубокий минет
$text_sex_bjt = {
	txt_sex_bjt = RAND(0,2)
	if txt_sex_bjt = 0:$txt_sex_bjt = 'Он засунул член вам глубоко в горло при том ещё сдавив его рукой, ваши <<$liptalk3>> плотно сжимали его хуй. Вы не делали ему минет, <<$gopsex_name_npc>> просто грубо имел вас в глотку и вам обоим это доставляло огромное удовольствие.'
	if txt_sex_bjt = 1:$txt_sex_bjt = 'Попробовали своими <<$liptalk>> заглотнуть его поглубже. И снова надрачивали рукой, и ласкали ртом. Потом с каждым разов все больше и больше вбирали его в рот по самое горло.<br>У вас на глазах появились слезы, но вы все равно старались взять глубже. <<$gopsex_name_npc>> взял вас за <<$hapri>> <<$hair2>> и стал сам наяривать, натягивая вашу голову себе на член.'
	if txt_sex_bjt = 2:$txt_sex_bjt = 'Головка упиралась в самое горло и проникала еще глубже, но вы не могли засунуть ее дальше — уж слишком толстой она была.<br>Однако с каждым разом на пару миллиметров, немного, но она пролизала все глубже и глубже. По вашим <<$liptalk2>> текла слюна капая на пол.'
	'<<$txt_sex_bjt>>'
}
!-------------------------
!раком в киску
$text_sex_doggy = {
	txt_sex_doggy = RAND(0,6)
	if txt_sex_doggy = 0:$txt_sex_doggy = '<<$gopsex_name_npc>> был в восторге от вас. Он вскочил, поставил вас раком, задрал юбку, открыв вашу прилесную попку, и вонзил член в киску сзади.<br>Вы не ожидали таких резких действий, однако он трахал вас минут десять, практически не сбавляя темпа, лишь изредка останавливаясь, чтобы перевести дыхание.<br>Вы думали, что он вот-вот выдохнется, но он оказался выносливее, чем можно было предположить. Последние минут пять вы забыли, где находитесь, и кричали во всё горло.<br><<$gopsex_name_npc>> рычал, одной рукой шлёпая по заднице, другой взяв вас за <<$hapri>> <<$hair2>>.'
	if txt_sex_doggy = 1:$txt_sex_doggy = '<<$gopsex_name_npc>> надрочил свой член и насадил вас на него. Вы принялись подмахивать задом. Он скользил внутри вас, упирался вам в матку.<br>Вы прогибали спину, а он руками сильнее ухватился за вашу жопу и начал сильнее ебать.'
	if txt_sex_doggy = 2:$txt_sex_doggy = 'Вы тяжело дышали стоя раком и старательно подмахивали попочкой. <<$gopsex_name_npc>> стоял сзади и натягивал вас как кобель ссучку.<br>Грубые руки <<$gopsex_name_npc>> сжимали вашу попку помогая ей глубже насаживаться на его окаменевший ствол.<br>Вы стонали от удовольствия, ваша попка стремительно двигалась навстречу этому восхитительному и ненасытному стволу.<br><<$gopsex_name_npc>> поднял руку и с оттяжкой шлепнул вас по заднице.<br>— "Молодец, шлюшка, ну ка еще наподдай попочкой. Давай лапочка, проворней работай", приговаривал <<$gopsex_name_npc>> шлепая вас то одной то другой рукой.'
	if txt_sex_doggy = 3:$txt_sex_doggy = '<<$gopsex_name_npc>> поставил вас в позу раком и встал сзади вас. Затем он одним резким движением засунул хуй, вошел грубо и резко одним толчком, в вашу мокрую пизду.<br>Вы дернулись и вскрикнули от пронизывающей и резкой боли, но остались покорно стоять раком.<br>Он начал жестко насаживать вас под самый корень, он вбивал в вас свой кол так, как будто пытался вогнать его глубже и глубже с каждым толчком.<br>Он яростно ебал свою одноклассницу, держа одной рукой за <<$hapri>> <<$hair2>>. Движения <<$gopsex_name_npc>> были резкими и сильными.<br>Тишину прорезали громкие шлепки. Его таз с силой ударялся об упругую задницу бляди, которая в этот момент стонала сквозь сжатые зубы.'
	if txt_sex_doggy = 4:$txt_sex_doggy = '— Спускайся на пол и встань на четвереньки, моя сладкая.<br>Вы безоговорочно подчинились, встали раком на четвереньки. Вам нравилось, когда вас трахают в этой позе.<br>— "<<$name[2]>> прогни спинку, а голову опусти ниже".<br>— "Да, <<$gopsex_name_npc>>", cказали возбужденным голосом и сильнее прогнули спину и опустили голову.<br>Ваша попка задралась еще выше, а киска стала ближе и доступнее, что очень понравилось ему.<br><<$gopsex_name_npc>> опустился на пол и развел ее ноги в стороны, устраиваясь между ними на колени. Затем он широко раздвинул ее ягодицы, медленно провел членом по мокрой пизде, засадил глубоко.<br>— Ммм... ааааах... мммм, застонали вы.<br><<$gopsex_name_npc>> положил обе руки на ее попу и с наслаждением скользил своим членом в ее пизде.'
	if txt_sex_doggy = 5:$txt_sex_doggy = '<<$gopsex_name_npc>> держал ее за талию и трахал, потихоньку наращивая темп, вы усердно подмахивали и стонали от удовольствия, и желания угодить ему.<br>Ваши груди колыхались, а сочные розовые соски-вишенки сексуально торчали. Вы чувствовали, как крупный член то заполняет и приятно распирает стенки киски, то полностью выходит наружу, освобождая ее.<br>Сейчас вы чувствовали себя блядью, но вам это нравилось.'
	if txt_sex_doggy = 6:$txt_sex_doggy = '<<$gopsex_name_npc>> развернул вас и поставил раком, и начал без церемоний сношать вашу киску. Шлепки становились все громче и громче.<br>У него блестели плечи и спина, пальцы рук вцепились в попку, а удара стали еще сильнее и короче, <<$gopsex_name_npc>> уже не вынимал полностью член из киски, а лишь чуть-чуть.<br>И весь его член был в вас, и долбил, и долбил, не собираясь останавливаться.'
	'<<$txt_sex_doggy>>'
}
!-------------------------
!раком в попу
$text_sex_doggy_anal = {
	txt_sex_doggy_anal = RAND(0,8)
	if txt_sex_doggy_anal = 0:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> приставил хуй к вашему анусу и вогнал его в узкую дырочку одним толчком по самые яйца. Вы успели только дернуться и «ойкнуть», когда его большой член пронзил вашу жопу.
Через пару минут, вы привыкли и начали постанывать: — Ммм... дааааа... глууууубже... мммм...
Он схватил вас за талию и начал долбить, наращивая темп. Вы усердно подмахивали, желая сесть еще глубже на его орудие. Вы были безумно возбуждены и с удовольствием отдавались ему.'
	if txt_sex_doggy_anal = 1:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> стоял на коленях между ее ног и вгонял свой член по самые яйца, а вы стояли на четвереньках с высоко приподнятой попкой и подмахивала в такт, издавая стоны наслаждения.
Эти стоны еще больше заводили ее ебаря. Он трахал ее с пересохшим горлом иногда издавая какие то стоны.
— У тебя большая и красивая задница, <<$name[2]>>..., не меняя темпа сказал он.
— Мммм... дааааа... даааааа... сильнее и глубже... ммммм... какой же он у тебя большой... мммм..., ворковали вы.'
	if txt_sex_doggy_anal = 2:$txt_sex_doggy_anal = '— Я соскучился по твоей упругой попке, малышка. И сейчас буду трахать тебя в попу, моя сладкая сучка.
Вы почувствовали, что его член уже стоит и прижимается к вашей заднице.
<<$gopsex_name_npc>> плюнул себе в ладошку, смазал головку и приставил залупу к вашему анусу. Он начал медленно и нежно вводить хуй в вашу попу.
Когда хуй вошел на всю длину <<$gopsex_name_npc>> начал двигать тазом, придерживая вас за талию.
Вы застонали и начали подмахивать, насаживая свое очко на его большой хуй.'
	if txt_sex_doggy_anal = 3:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> приставил головку члена к узкому отверстию и надавил. Сфинктер без особого сопротивления впустил его не маленький член в вашу попку.
Он взял вас за бёдра и начал быстро трахать в зад. Вы вскрикивали при каждом толчке, ему это нравилось и он делал своё дело всё быстрее и быстрее.
Его охватило какое-то животное чувство, ему хотелось, чтобы вы кричали ещё и ещё громче не переставая. <<$gopsex_name_npc>> всаживал вам до самого конца, так что яйца ударялись о вашу промежность.'
	if txt_sex_doggy_anal = 4:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> поставил вас на колени, а сам пристроился сзади. Одной рукой придерживая вас за попку, второй рукой направил свою елду, в ваше очко.
Видно было, что вам это очень нравилось. Он крепко держал вас за попку, а сам задвигал своим телом вперед-назад с такой силой, что шлепки были какие-то остервенелыми, и звонкими и глухими одновременно.
И так быстро: замах, удар, замах, удар. Он стал натягивать вас: когда входил на всю глубину, руками притягивал к себе вашу попку, а по ней проходила волна от его ударов.'
	if txt_sex_doggy_anal = 5:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> потащил вас за собой. Вы оказались стоящей на коленях, опираясь на локти. Поняли, что сейчас он войдет в вас.
Он пристроил свой член напротив вашей попки и надавил. Было немного больно, но желание удовольствия взяло вверх.
<<$gopsex_name_npc>> входил в вас, все быстрее. Ваша попка освоилась и разработалась, пуская уже без проблем.'
	if txt_sex_doggy_anal = 6:$txt_sex_doggy_anal = 'Вы стоите раком, ваша попка в его руках, а его член полностью в вашей анальной дырке, и при этом вы тяжело дышите и получаете удовольствие.
Вы хотели, чтобы <<$gopsex_name_npc>> весь был в вас, и чтобы вы чувствовали всей попкой все его удары, чтобы его член ходил в вас туда-сюда, чтобы по вашей попке прокатывались волны от его проникновения, и чтобы он натягивал вас как последнюю блядь.'
	if txt_sex_doggy_anal = 7:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> крепко держал вас за попку, свои членом уже вовсю трахая ваше очко. Он с усилием и со всего размаха наяривал своим членом.
Сильнее, еще сильнее, помогая себе руками притянуть вашу упругую жопу к себе. Ваша попка уже не болела, а слегка отдавала приятным зудом, и вы чувствовали что-то горячее и упругое в себе, что проникало все глубже и глубже, и где-то там терялось.'
	if txt_sex_doggy_anal = 8:$txt_sex_doggy_anal = '<<$gopsex_name_npc>> поставил вас рачком, и пристроил свою головку, начал вдалбливать в вас свой член. Ваша попка была уже готова, разработана.
Его член уже был полностью в вашей дырке, и <<$gopsex_name_npc>> начал жестко трахать вас. Удар, удар, еще удар, шлепок. Член ходил туда-сюда. Волны от его ударов расходились по вашей попку, груди ходили ходуном, голова вздрагивала в такт его ударам.
И с ваших губ слетал стон удовольствия. Вы из последних сил старались держаться, старалась противостоять его яростному натиску и этой долбежке.
В глазах все поплыло, и проносились какие-то разноцветные тени и узоры. <<$gopsex_name_npc>> монотонно и сильно трахал вас, сжимая вашу попку.'
	'<<$txt_sex_doggy_anal>>'
}
!-------------------------
!сверху
$text_sex_cow = {
	txt_sex_cow = RAND(0,2)
	if txt_sex_cow = 0:$txt_sex_cow = '<<$gopsex_name_npc>> сел на диван, вы уселись сверху на его хуй. Ваша текущая похотливая киска жадно обхватила его член и заглотила в себя.
Вы активно начали двигать задом, подпрыгивая на его хую. Вы трахались, закрыв глаза и забыв обо всём на свете.'
	if txt_sex_cow = 1:$txt_sex_cow = 'Вы сели на него и вставили в свою пиздёнку член до упора.
— "О боже, как же классно" — выдохнули вы и, немного покрутив бедрами, начала подниматься и опускаться на его члене.
Вы стали двигаться ещё быстрее, через пару минут такой скачки вы подустали и начали медленно поднималась и опускалась на его члене.
<<$gopsex_name_npc>> обхватил вашу попку и стал задавать темп, двигаясь вам навстречу.'
	if txt_sex_cow = 2:$txt_sex_cow = 'Вы перекинули через него ногу и сев верхом на член, поскакали на нём. Трахая его, вы время от времени наклонялись к нему с поцелуем.
При этом ваши грудки касались его. Через какое-то время ваши ноги стали сильнее сжимать его, Вы плотнее прижимались к его паху, стараясь сильнее насадиться на член.'
	'<<$txt_sex_cow>>'
}
!-------------------------
!сверху анал
$text_sex_cow_anal = {
	txt_sex_cow_anal = RAND(0,0)
	if txt_sex_cow_anal = 0:$txt_sex_cow_anal = 'Вы подогнули ноги под себя, чтобы удобнее было контролировать высоту. Затем приподнялись и медленно опустились снова, пытаясь усесться попкой на член <<$gopsex_name_npc>> .
В ходе всего процесса вы почувствовали, что ваша попка немного привыкла к члену, боли не было. Вы сами не заметила, как стали садиться всё глубже и глубже.'
	'<<$txt_sex_cow_anal>>'
}
!-------------------------
!миссионерская
$text_sex_miss = {
	txt_sex_miss = RAND(0,5)
	if txt_sex_miss = 0:$txt_sex_miss = '<<$gopsex_name_npc>> oпрoкинул вас нa спину и улeгся свeрху. Пaрeнь пристрoил гoлoвку кo вхoду и слeгкa нaдaвил. Вы тoмнo вздoхнули и oбняли eгo ягoдицы нoжкaми.
Он вoшeл дo упoрa и принялся oстoрoжнo двигaться, слoвнo бoясь причинить вам бoль. Ваша киска былa мoкрaя внутри, a eщe жaркaя, кaк пeчь. Вы с ним в унисoн принялись двигaться, зaбыв oбo всeм нa свeтe.'
	if txt_sex_miss = 1:$txt_sex_miss = 'Вы не выдержала и произнесли: -"Давай же войди в мою похотливую щёлку", перевернувшись на спину и призывно разведя ноги.
Его не нужно было просить дважды. <<$gopsex_name_npc>> сразу же лёг сверху, и его член погрузился во влажную пещерку.
Вы тут же сильно обхватили его ногами, как будто боялись, что его фаллос вас покинет.
<<$gopsex_name_npc>> начал ритмичные движения, постепенно ускоряя темп, а вы активно подмахивали.
И громко стонали и вскрикивали, когда он особенно глубоко вводил свой член в вашу хлюпающую щель. '
	if txt_sex_miss = 2:$txt_sex_miss = '<<$gopsex_name_npc>> положил вас на спину, раздвинув тазом ваши ноги в стороны и лёг на вас животом. С тяжёлым вздохом он проник в вас, глядя на то, как член стремительно проникает в вас, мягко раздвигая половые губы.
Упругие стенки влагалища мягко обволокли член, затягивая в себя. Он упёрся руками в постель, нависнув над вами, глядя в лицо, а вы не спускали взгляда с него.
Вы были уже довольно опытной, несмотря на свой возраст. Вы плотно сжали под ним ноги, когда он входил в вас, чтобы дополнительно стимулировать член уже своими бёдрами.
С особым терпким удовольствием он двигал членом в ней, плотно схваченный бёдрами.'
	if txt_sex_miss = 3:$txt_sex_miss = 'Его член, как бешеный бык метался в вашей киске, вы чувствовали твердое его тело, как <<$gopsex_name_npc>> своим телом буквально штамповал ваше нежное лоно.
Затем он как-то напрягся, стал, вообще, безостановочно долбит вас, член стал каким-то огненым.'
	if txt_sex_miss = 4:$txt_sex_miss = 'Вы лежали на спине, <<$gopsex_name_npc>> стал водить обнаженной головкой вдоль половых губок. Вам было очень щекотно, когда он терся о ваш о клитор.
Затем, при посещении влагалища, стал погружаться туда чуть больше, делать по нескольку толчков, затем снова выходил и вверх.
Постепенно глубина погружений увеличивалась, и это уже был практически полноценный трах.
Правда, позиция не очень удобна. Зато можно видеть все тело стонущей партнерши. А посмотреть было на что.
Вдруг вы простонали: — "Ещё... Ещё... Давай".'
	if txt_sex_miss = 5:$txt_sex_miss = 'Смазки было достаточно и его член скользил легко в вашей письке. Вы чувствовали как головка раздвигает внутренние стенки влагалища. От каждого проникновения вы постанывали.
Через минуту, немного привыкнув вы положили свои руки на его ягодицы и начали задавать темп.
 — Ещё, ещё — нашёптывали вы, срываясь в постанывания и запрокинув голову назад.
<<$gopsex_name_npc>> не удержался и в очередном толчке вошёл в вас так глубоко, что ваши лобки соприкоснулись. Ваше дыхание сквозь зубы было частым и глубоким.
Через какое-то время <<$gopsex_name_npc>> уже откровенно ебал вас. В свою очередь вы вцепились ему в спину и монотонно постанывали.'
	'<<$txt_sex_miss>>'
}
!-------------------------
!миссионерская анал
$text_sex_miss_anal = {
	txt_sex_miss_anal = RAND(0,1)
	if txt_sex_miss_anal = 0:$txt_sex_miss_anal = '<<$gopsex_name_npc>> oпрoкинул вас нa спину и улeгся свeрху. Пaрeнь пристрoил гoлoвку кo вхoду и слeгкa нaдaвил. Вы тoмнo вздoхнули и oбняли eгo ягoдицы нoжкaми.
Он вoшeл дo упoрa и принялся oстoрoжнo двигaться, слoвнo бoясь причинить вам бoль. Ваша попка былa жaркaя, кaк пeчь. Вы с ним в унисoн принялись двигaться, зaбыв oбo всeм нa свeтe.'
	if txt_sex_miss_anal = 1:$txt_sex_miss_anal = 'Вы не выдержала и произнесли: -"Давай же войди в мою похотливую попку", перевернувшись на спину и призывно разведя ноги.'
	'<<$txt_sex_miss_anal>>'
}
!-----------!
! окончание !
!===========!
$text_sex_cumm = {
	!в рот
	txt_sex_cumm = RAND(0,2)
	if txt_sex_cumm = 0:$txt_sex_cumm = '<<$gopsex_name_npc>> быстро вытащил свой член и засунул его вам в рот, вы даже пикнуть не успели. Его сперма ударила вам в горло, вы инстинктивно прильнули сильнее к нему.
Он все кончал и кончал большими порциями, вы глотали, но все-таки по углам рта проступали его излишки.'
	if txt_sex_cumm = 1:$txt_sex_cumm = 'Вы с готовностью прильнули к члену, и с наслаждением его сосали, пока <<$gopsex_name_npc>> не излил в ваш ротик порцию спермы.'
	if txt_sex_cumm = 2:$txt_sex_cumm = 'Вы заглотили его член, язычок ласкал его яички и тёплая сперма полилась по пульсирующему члену прямо в ваш ротик.'
	'<<$txt_sex_cumm>>'
}
!на лицо
$text_sex_cumface = {
	txt_sex_cumface = RAND(0,3)
	if txt_sex_cumface = 0:$txt_sex_cumface = '<<$gopsex_name_npc>> залил все ваше лицо своей спермой.'
	if txt_sex_cumface = 1:$txt_sex_cumface = '<<$gopsex_name_npc>> вынул и стал спускать ей на лицо. Она видела близко перед собой плюющую сперму зaлупу и чувствовала, как появляются на лице горячие, тягучие капли и начинают стекать к подбородку и капать на пол.'
	if txt_sex_cumface = 2:$txt_sex_cumface = ' - "А, бля!", закричал <<$gopsex_name_npc>>, вызволяя хуй из сладкого девичьего плена и беря его в свои руки.
Первая длинная струя на мгновение мелькнула в воздухе. Вы зажмурились, струйка спермы, зацепив ваш подбородок, прочертив щеку. Второй залп он расчетливо направил прямо в ваше лицо так, что вы еле успели прикрыть глаза. Этого извержения хватило для того, чтобы все личико было покрыто жидкостью.'
	if txt_sex_cumface = 3:$txt_sex_cumface = '<<$gopsex_name_npc>> придвинулся хуем к вашему лицу. И в ту же секунду вязкая струйка ударила вам прямо в ваши <<$liptalk3>>. Ручейки спермы потекли по подбородку, капая на пол. С лица минетчицы свесилась целая спермяная борода! Но это <<$gopsex_name_npc>> увидел несколько позже, а пока он стоял, упоенно выдавливая последние капли спермы. '
	'<<$txt_sex_cumface>>'
}
!на тело
$text_sex_cumbody = {
txt_sex_cumbody = RAND(0,1)
	if txt_sex_cumbody = 0:$txt_sex_cumbody = 'Буквально через минуту, еле успев вытащить член из вас, <<$gopsex_name_npc>> кончил вам на грудь, часть спермы попало на лицо.'
	if txt_sex_cumbody = 1:$txt_sex_cumbody = '<<$gopsex_name_npc>> водил членом по вашему животику и кончал, было так горячо от его члена и от спермы.'
	'<<$txt_sex_cumbody>>'
}
!в писю
$text_sex_cumvag = {
	txt_sex_cumvag = RAND(0,3)
	if txt_sex_cumvag = 0:$txt_sex_cumvag = 'Через какое-то время вы почувствовали, что <<$gopsex_name_npc>> увеличил и так бешеный темп и захрипел. Он кончал, и причем очень бурно.
Чувствовали, как в вас брызгает сперма, струя за струей. Когда <<$gopsex_name_npc>> вытащил хуй из вашей пизды, сперма начала вытикать из нее.'
	if txt_sex_cumvag = 1:$txt_sex_cumvag = 'Через какое-то время <<$gopsex_name_npc>> почувствовал, как ваша пизда начала сжиматься и пульсировать, а вы застонали еще громче и чувственее...яростно подмахивали и стонали.
Он сильнее схватил вас и начал еще интенсивнее долбить и через несколько минут достиг пика удовольствия.
<<$gopsex_name_npc>> кончил прямо вам в пизду. Вы чувствовали, как его сперма заполняет вашу киску...'
	if txt_sex_cumvag = 2:$txt_sex_cumvag = 'Вдруг вы напрягли мышцы влагалища, и <<$gopsex_name_npc>> почувствовал как внутри стало заметно теснее. От этого он больше не смог сдерживаться и начал кончать прямо в вашу киску.
Вы напрягая стенки влагалища, выдаивали сперму из его члена.'
	if txt_sex_cumvag = 3:$txt_sex_cumvag = '<<$gopsex_name_npc>> лишь сильнее притянул вас за талию к себе. Не выпуская член наружу. Внутри был ураган, его член то сжимали, то отпускали пульсирующие движения.
Из-за ваших умелых действий, сжимающих движений...оргазм оказался на столько сильным, что он кончал вам в киску по меньшей мере секунд тридцать.'
	'<<$txt_sex_cumvag>>'
}
!в попу
$text_sex_cumass = {
	txt_sex_cumass = RAND(0,1)
	if txt_sex_cumass = 0:$txt_sex_cumass = '<<$gopsex_name_npc>> вставил своё член вам в попку — правда не весь, а только головку.
И стал дрочить свой член, оставляя головку у вас внутри и через какое-то время вылил вам в попку огромную дозу спермы, которая стекала вам по ногам и капала на пол.'
	if txt_sex_cumass = 1:$txt_sex_cumass = '<<$gopsex_name_npc>> начал кончать в вашу попку, его сперма обжигала и таяла в вашей жопе.
Он старался вогнать свой член еще глубже, когда кончал и с силой надавливал телом на вашу попку.'
	'<<$txt_sex_cumass>>'
}
!----------------------!
!	СЕКС ГГ И КО	!
!======================!
!выбор с кем трахаться:
$gopsex_select = {
	*clr & cla
	gop_sex_lubri = 0
	gop_groupsex_lubri = 0
	gs'stat'
	if horny <50 and func('zz_clothing', 'get_group') ! 12: '<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/body/b'+rand(1,17)+'.jpg"></center> <br> Вы хотите секса.'
	if horny >=50 and func('zz_clothing', 'get_group') ! 12: '<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/body/g'+rand(1,20)+'.jpg"></center> <br> Вы перевозбуждены и сильно хотите трахаться.'
	if func('zz_clothing', 'get_group') = 12: '<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/body/h'+rand(1,20)+'.jpg"></center>'
	act 'Потрахаться с Васькой':
		if shgopsex_vasya_count = 0:
			cla
			'Вася говорит: -"<<$gop_name_gg>> заебала уже меня, на сегодня хватит секса, не приставай."'
			act 'Уйти': gt'shulga_room'
		else
			$gopsex_name_npc = 'Вася'
			$gopsex_n_npc = 1
			shgopsex_vasya_day = daystart
			shgopsex_vasya_count -= 1
			if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
			dynamic $shgopsex
		end
	end
	if week < 6 and hour >= 0 and hour < 3:
		act 'Потрахаться с Дэном':
			if shgopsex_den_count = 0:
				cla
				'Дэн говорит: -"Вот ты <<$gop_gg_name>> заебала меня сегодня, отъебись."'
				act 'Уйти': gt'shulga_room'
			else
				$gopsex_name_npc = 'Дэн'
				$gopsex_n_npc = 0
				shgopsex_den_day = daystart
				shgopsex_den_count -= 1
				if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
				dynamic $shgopsex
			end
		end
		act 'Потрахаться с Витьком':
			if shgopsex_vitya_count = 0:
				cla
				'Витек говорит: -"Извини <<$gop_name_gg>>, больше сегодня не смогу."'
				act 'Уйти': gt'shulga_room'
			else
				$gopsex_name_npc = 'Витя'
				$gopsex_n_npc = 2
				shgopsex_vitya_day = daystart
				shgopsex_vitya_count -= 1
				if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
				dynamic $shgopsex
			end
		end
		if alko >= 3 and func('zz_reputation','get') >= 3 and shgopsex_gr_count > 0 or horny >= 50 and func('zz_reputation','get') >= 3 and shgopsex_gr_count > 0:
			act 'Участвовать в групповушке':
				shgopsex_gr_day = daystart
				shgopsex_gr_count -= 1
				if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
				if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
				if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
				dynamic $shgopsex_group
			end
		end
	end
	act 'Уйти': gt'shulga_room'
}
!===========================================================!
!Секс 1 на 1!
!===========!
!выбор секса!
$shgopsex = {
	cla
	gs'stat'
	'- "Ну чего <<$gopsex_name_npc>> как меня <<$gop_sextext1>> будеш?. Что мне для тебя сделать?", игриво спрашиваете вы.'
	if mesec > 0 and vagina >=1:
		'<font color = red><b>Вы предупреждаете, что у вас месячные и в пизду доступ закрыт!</b></font>'
	elseif vagina = 0:
		'<font color = red><b>Вы предупреждаете, что вы бережете свою девственность, по этому в письку не даете!</b></font>'
	end
	act 'Подрочить': dynamic $shgopsex_hj
	act 'В рот': dynamic $shgopsex_bj
	if throat >= 20:
		act 'Глубоко в рот': dynamic $shgopsex_throat
	end
	if mesec <=0 and vagina >=1:
		act 'В пизду': dynamic $shgopsex_vag
	end
	act 'В попу': dynamic $shgopsex_anal
	act 'Помацать грудь': dynamic $shgopsex_tits
	if mesec <=0:
		act 'Взаимные ласки': dynamic $shgopsex_69
		act 'Попросить полизать': dynamic $shgopsex_lick
	end
	if dom >= 5:
		act 'Уйти': gt'shulga_room'
	end
}
!окончание секса
$shgopsex_end = {
	cla
	shgopsex_count = $shgopsex_count
	gs'stat'
	!'<<shgopsex_count>>'
	!если дрочили, сосали, трахали сиськи кончаем в: рот, лицо или на тело
	if sh_bjandhj_cum >=1:
		act 'В рот': dynamic $shgopsex_swallow
		act 'На лицо': dynamic $shgopsex_cumface
		act 'На тело': dynamic $shgopsex_cumbelly
		!кончаем куда угодно
	else
		act 'В рот': dynamic $shgopsex_swallow
		act 'На лицо': dynamic $shgopsex_cumface
		act 'На тело': dynamic $shgopsex_cumbelly
		act 'В писю': dynamic $shgopsex_cumvag
		act 'В попу': dynamic $shgopsex_cumanal
	end
}
!===============================================================!
!полизать гг
$shgopsex_lick= {
	*clr & cla
	minut += 1
	gs'stat'
	!Вася (нпс 1)
	if $gopsex_n_npc = 1:
		if func('zz_reputation','get') >= 3:
			'<<$gop_name_gg>> ты же у нас <<$gnikname>>, мне западло такой бабе пизду лизать, хуй знает сколько там за сегодня хуев побывало. Так что давай, подставляй свои блядские дырки, ебать буду!'
		else
			horny += 10
			minut += rand(3,7)
			dynamic $ind_stamina_npc
			'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/lick/lick'+rand(1,11)+'.jpg"></center>'
			dynamic $text_sex_cun
		end
	end
	!Витя (нпс 2)
	if $gopsex_n_npc = 2:
		if func('zz_reputation','get') >= 3:
			'<<$gop_name_gg>> ты же у нас <<$gnikname>>, мне западло такой бабе пизду лизать, хуй знает сколько там за сегодня хуев побывало. Так что давай, лучше подставляй свои блядские дырки!'
		else
			horny += 10
			minut += rand(3,7)
			dynamic $ind_stamina_npc
			'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/lick/lick'+rand(1,11)+'.jpg"></center>'
			dynamic $text_sex_cun
			dynamic $gg_sex_orgasm
		end
	end
	!Дэн (нпс 0)
	if $gopsex_n_npc = 0:
	'- "Дэн, полижи мне письку", ласково просите вы.'
	'- <<$gop_name_gg>>, а ты не ахуела ли, мне такое предлагать?'
	'- А что тут такого?, тебе западло сделать мне приятно?'
	'- Да, мне западло давалке пизду лизать, хуй знает сколько там за сегодня хуев побывало... Так что давай, не еби мне мозг, подставляй свои блядские дырки, ебать буду!'
	end
	act 'Выбор секса': dynamic $shgopsex
	!act 'Закончить': dynamic $shgopsex_end
}
!взаимные ласки, поза 69
$shgopsex_69= {
	*clr & cla
	minut += 1
	gs'stat'
	if $gopsex_n_npc >= 1:
		if func('zz_reputation','get') >= 3:
			'<<$gop_name_gg>> ты же у нас <<$gnikname>>, мне западло такой бабе пизду лизать, хуй знает сколько там за сегодня хуев побывало. Так что давай, лучше подставляй свои блядские дырки!'
			act 'Выбор секса': dynamic $shgopsex
		else
			horny += 10
			minut += rand(3,7)
			shgopsex_count -= 1
			sh_bjandhj_cum = 1
			dynamic $ind_stamina_npc
			'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/lick/69_'+rand(1,3)+'.jpg"></center>'
			dynamic $text_sex_69
			dynamic $gg_sex_orgasm
			dynamic $npc_orgasm
			if shgopsex_count > 0:
				act 'Выбор секса': dynamic $shgopsex
				!act 'Закончить': dynamic $shgopsex_end
			else
				dynamic $shgopsex_end
			end
		end
	else
		'- "Нет, <<$gop_name_gg>> лизать пизду я не буду"'
		act 'Выбор секса': dynamic $shgopsex
	end
}
!===============================================================!
!сосать сиську
$shgopsex_eattits = {
	*clr & cla
	horny += 5
	minut += rand(1,3)
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/tits/eat'+rand(1,2)+'.jpg"></center>'
	'<<$gopsex_name_npc>> покусывает вашу сиську.'
	act 'Погонять член между сисек': dynamic $shgopsex_fucktits
	act 'Выбор секса': dynamic $shgopsex
}
!погонять между грудей
$shgopsex_fucktits = {
	*clr & cla
	horny += 10
	minut += rand(2,7)
	shgopsex_count -= 1
	sh_bjandhj_cum = 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/tits/tj'+rand(1,9)+'.jpg"></center>'
	'<<$gopsex_name_npc>> хочет погонять хуй между ваших сисек, а вы и не против.'
	if shgopsex_count > 0:
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
!поиграть с грудью
$shgopsex_tits= {
	*clr & cla
	horny += 5
	minut += rand(1,4)
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/tits/tits'+rand(1,6)+'.jpg"></center>'
	'- "Ну как <<$gopsex_name_npc>> нравится мои сиськи <<$gop_text3>>?"'
	'- "Да <<$gop_name_gg>>, заебись сиськи у тебя!"'
	act 'Сосать сиську': dynamic $shgopsex_eattits
	act 'Погонять член между сисек': dynamic $shgopsex_fucktits
	act 'Выбор секса': dynamic $shgopsex
}
!===============================================================!
!работать руками
$shgopsex_hj = {
	*clr & cla
	horny += 5
	minut += rand(3,7)
	shgopsex_count -= 1
	sh_bjandhj_cum = 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/hj'+rand(1,12)+'.jpg"></center>'
	dynamic $text_sex_hj
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
!===============================================================!
!сосать
$shgopsex_bj = {
	*clr & cla
	bj +=1
	horny += 10
	minut += rand(3,7)
	if throat < 20: throat += 1
	shgopsex_count -= 1
	sh_bjandhj_cum = 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/oral/bj'+rand(1,25)+'.jpg"></center>'
	dynamic $text_sex_bj
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
!глубоко в рот
$shgopsex_throat = {
	*clr & cla
	throat += 1
	horny += 10
	minut += rand(3,7)
	shgopsex_count -= 1
	sh_bjandhj_cum = 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/oral/throat'+rand(1,15)+'.jpg"></center>'
	dynamic $text_sex_bjt
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
!вагина!
!===============================================================!
!вагина!
$shgopsex_vag = {
	*clr & cla
	horny += 10
	sex += 1
	minut += rand(3,7)
	shgopsex_count -= 1
	sh_bjandhj_cum = 0
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/pussy/dog'+rand(1,20)+'.jpg"></center>'
	dynamic $gg_devst_deflor
	dynamic $text_sex_doggy
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: миссионерская': dynamic $shgopsex_vag1
		act 'Сменить позу: наездница': dynamic $shgopsex_vag2
		act 'Сменить позу: боком': dynamic $shgopsex_vag3
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
$shgopsex_vag1 = {
	*clr & cla
	horny += 10
	minut += rand(3,7)
	shgopsex_count -= 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/pussy/miss'+rand(1,20)+'.jpg"></center>'
	dynamic $text_sex_miss
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: раком': dynamic $shgopsex_vag
		act 'Сменить позу: наездница': dynamic $shgopsex_vag2
		act 'Сменить позу: боком': dynamic $shgopsex_vag3
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
$shgopsex_vag2 = {
	*clr & cla
	horny += 10
	minut += rand(3,7)
	shgopsex_count -= 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/pussy/cow'+rand(1,20)+'.jpg"></center>'
	dynamic $text_sex_cow
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: раком': dynamic $shgopsex_vag
		act 'Сменить позу: миссионерская': dynamic $shgopsex_vag1
		act 'Сменить позу: боком': dynamic $shgopsex_vag3
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
$shgopsex_vag3 = {
	*clr & cla
	horny += 10
	minut += rand(3,7)
	shgopsex_count -= 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/pussy/bok'+rand(1,3)+'.jpg"></center>'
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: раком': dynamic $shgopsex_vag
		act 'Сменить позу: миссионерская': dynamic $shgopsex_vag1
		act 'Сменить позу: наездница': dynamic $shgopsex_vag2
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
!анал!
!===============================================================!
!анал!
$shgopsex_anal = {
	*clr & cla
	horny += 5
	minut += rand(3,7)
	anal += 1
	shgopsex_count -= 1
	sh_bjandhj_cum = 0
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/anal/dog'+rand(1,20)+'.jpg"></center>'
	dynamic $gop_sex_analplugin
	dynamic $gop_sex_lubri
	dynamic $text_sex_doggy_anal
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: миссионерская': dynamic $shgopsex_anal1
		act 'Сменить позу: наездница': dynamic $shgopsex_anal2
		act 'Сменить позу: боком': dynamic $shgopsex_anal3
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
$shgopsex_anal1 = {
	*clr & cla
	horny += 5
	minut += rand(3,7)
	shgopsex_count -= 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/anal/miss'+rand(1,20)+'.jpg"></center>'
	dynamic $gop_sex_analplugin
	dynamic $gop_sex_lubri
	dynamic $text_sex_miss_anal
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: раком': dynamic $shgopsex_anal
		act 'Сменить позу: наездница': dynamic $shgopsex_anal2
		act 'Сменить позу: боком': dynamic $shgopsex_anal3
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
$shgopsex_anal2 = {
	*clr & cla
	horny += 5
	minut += rand(3,7)
	shgopsex_count -= 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/anal/cow'+rand(1,20)+'.jpg"></center>'
	dynamic $gop_sex_analplugin
	dynamic $gop_sex_lubri
	dynamic $text_sex_cow_anal
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: раком': dynamic $shgopsex_anal
		act 'Сменить позу: миссионерская': dynamic $shgopsex_anal1
		act 'Сменить позу: боком': dynamic $shgopsex_anal3
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
$shgopsex_anal3 = {
	*clr & cla
	horny += 5
	minut += rand(3,7)
	shgopsex_count -= 1
	gs'stat'
	dynamic $ind_stamina_npc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/sex/anal/bok'+rand(1,9)+'.jpg"></center>'
	dynamic $gop_sex_analplugin
	dynamic $gop_sex_lubri
	'на боку'
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_count > 0:
		act 'Сменить позу: раком': dynamic $shgopsex_anal
		act 'Сменить позу: миссионерская': dynamic $shgopsex_anal1
		act 'Сменить позу: наездница': dynamic $shgopsex_anal2
		act 'Выбор секса': dynamic $shgopsex
		!act 'Закончить': dynamic $shgopsex_end
	else
		dynamic $shgopsex_end
	end
}
!окончание!
!===============================================================!
!окончание в рот
$shgopsex_swallow = {
	*clr & cla
	minut += rand(1,3)
	swallow += 1
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/cum/swallow'+rand(1,18)+'.jpg"></center>'
	dynamic $text_sex_cumm
	act 'Уйти': gt'shulga_room'
}
!окончание на лицо
$shgopsex_cumface = {
	*clr & cla
	minut += rand(1,3)
	gs 'zz_funcs', 'cum', 'face'
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/cum/cumface'+rand(1,25)+'.jpg"></center>'
	dynamic $text_sex_cumface
	act 'Уйти': gt'shulga_room'
}
!окончание на тело
$shgopsex_cumbelly = {
	*clr & cla
	minut += rand(1,3)
	gs 'zz_funcs', 'cum', 'belly'
	gs 'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/cum/cumbody'+rand(1,14)+'.jpg"></center>'
	dynamic $text_sex_cumbody
	act 'Уйти': gt'shulga_room'
}
!окончание в писю
$shgopsex_cumvag = {
	*clr & cla
	minut += rand(1,3)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/cum/cumpussy'+rand(1,10)+'.jpg"></center>'
	dynamic $text_sex_cumvag
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Уйти': gt'shulga_room'
}
!окончание в попу
$shgopsex_cumanal = {
	*clr & cla
	minut += rand(1,3)
	gs 'zz_funcs', 'cum', 'ass'
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/cum/cumass'+rand(1,13)+'.jpg"></center>'
	dynamic $text_sex_cumass
	act 'Уйти': gt'shulga_room'
}
!END=
!==============!
!групповой секс!
!======
!текст!
!-----!
!отсос всем и сразу
$text_sex_group_bjall = {
	txt_sex_group_bjall = RAND(1,3)
	if txt_sex_group_bjall = 1:$txt_sex_group_bjall = 'Вы стали делать минет трем одновременно, ребята запихивали свои залупы вам в рот.
Кряхтя вы заглатывали их большие члены. Пока сосали один конец, двумя руками жестко дрочили два остальных. Пацаны были на вершине блаженства.'
	if txt_sex_group_bjall = 2:$txt_sex_group_bjall = '-Заглатывай сука, а то задохнешься на хуй!, - приказал Дэн, - я тебя сейчас научу отсасывать, ты у меня сейчас два члена возьмешь!
-Витек, что стоишь смотришь? Доставай член, я отсюда вижу как у тебя стоит, а у Вася пусть пусть по дрочит.
Ребята очнулись от созерцания картины того, как Дэн трахает ваш рот. Витя и Вася подошли к вам, расстегнули брюки и спустили их вниз вместе с трусами.
-Давай <<$name[2]>>, возьми у меня в ротик тоже, - так мило и по простому попросил Витек.
Дэн просто вынул свой член у вас изо рта, повернул вашу голову и насадил ее на член Витька. Сделал несколько движений вверх вниз и снова развернул меня к своему члену.
Так вас трахали в рот уже двое. Через некоторое время присоединился и Вася. Что бы не задохнутся, вам пришлось приноравливаться дышать в перерыве между членами.
Единственное что вам не удавалась, так это не давится когда их члены особенно глубоко входили вам в горло. Вы выкатывали глаза, давились, кашляли, вам давали короткую передышку и все начиналось сначала. '
	if txt_sex_group_bjall = 3:$txt_sex_group_bjall = 'Витек почувствовал свободу действий и вставлял вам в рот свой член по самые яйца, иногда вытаскивал и водил вам по губам.
Вася смотрел-смотрел, а потом тоже вытащил свой уже возбуждённый член и встал рядом с Витьком и они поочередно засовывали вам в рот свои члены иногда даже два сразу.
Через пару минут подключился и Дэн, ваш рот уже сношали трое, то по очереди, то пытаясь сразу три хуя пропихнуть...'
	'<<$txt_sex_group_bjall>>'
}
!отсос по очереди
$text_sex_group_bj = {
	txt_sex_group_bj = RAND(1,5)
	if txt_sex_group_bj = 1:$txt_sex_group_bj = 'Ребята поставили вас на колени и начали дрочить над лицом. Вы начали обслуживать их по очереди, сначала пару минут сосали одному, потом второму, третьему.
Это продолжалось приличное количество времени. Вам доставляло огромное удовольствие, стоять вот так и обслуживать ребят.'
	if txt_sex_group_bj = 2:$txt_sex_group_bj = 'Вас поставили на колени и вы начали по кругу сосать всем присутствующим ребятам. '
	if txt_sex_group_bj = 3:$txt_sex_group_bj = 'Ребята стали вокруг вас и начали по очереди давать вам в рот.'
	if txt_sex_group_bj = 4:$txt_sex_group_bj = 'Вот вы уже стоите на коленях и вас по очереди ебут в рот, мацают за сиськи, дают легкие пощечины и обзывают как последнюю шлюху. А вас все это только больше заводит.'
	if txt_sex_group_bj = 5:$txt_sex_group_bj = 'Вы сидите на коленях открыв рот, а ребята по очереди подходят и вы без рук, глубоко насаживаясь своим замечательным ротиком. Нет, вы не сосете, вас просто жестко ебут в рот.'
	'<<$txt_sex_group_bj>>'
}
!вагинальный трах и отсос:
$text_sex_group_vag = {
	txt_sex_group_vag = RAND(1,2)
	if txt_sex_group_vag = 1:$txt_sex_group_vag = '- А теперь соси - приказал Дэн.
Вы подчинились и припали к его члену, усиленно работая языком. Вы облизали его потные яйца, затем вылизали все основание и постепенно облизывая ствол добрались до головки.
После этого вы стали заглатывать его член почти полностью до самого основания. Рядом пристроился Вася и попросил у него тоже отсосать и вы стали обрабатывать ртом два члена.
А Витя тем временем стал пристраиваться сзади. Вы почувствовали его пальцы раздвигающие ваше отверстие, и шире расставили ноги. Через мгновение вы почувствовали как его инструмент входи в вашу промежность.
Он ритмично стал трахать вас, умудряясь при этом тискать вашу грудь и задницу. Инструмент у него был достаточно длинен и при каждом вводе его головка упиралась вам в самую матку.
Через пять минут такой трахалки ребята решили поменяться.'
	if txt_sex_group_vag = 2:$txt_sex_group_vag = '-Чего ты блядь расстоналась, Васян займи ей рот, а то я вижу у тебя стояк железный, так хоть делом хуй займешь!, сказал Дэн
Вася подошел с видимым воодушевлением и вставил вам член в рот. Его член не такой крупный, как у Дэна, но в длине не уступает.
Он с энтузиазмом начал мять глубину вашего горла, с восхищением смотря, на то как ваши губы достают до его лобка и яиц.
Тут к вашему рту еще пристроился Витек, а Дэн к этому времени уже полностью вставил член вам во влагалище и начал накачивать размашистыми движениями.
Так вы оказались насажанной на члены с двух сторон. При этом они, сговорившись, толкали члены в вас одновременно, увеличивая глубину проникновения.
По их довольным стонам, вы поняли, что это им безумно нравится.'
	'<<$txt_sex_group_vag>>'
}
!анальный трах и отсос:
$text_sex_group_anal = {
	txt_sex_group_anal = RAND(1,2)
	if txt_sex_group_anal = 1:$txt_sex_group_anal = 'Тут у ребят возникло желание по трахать вашу задницу. Вы это восприняли с радостью. Вас вас положили в удобную позу и Вася начал ебать вас в жопу, остальным вы дрочили и сосали хуи.
Через некоторое время ребята поменялись, Вася вытащил хуй тз вашей жопы и засунул вам в рот, а Дэн пристроился сзади и начал ебать ваше очко.
С каждым толчком вам перекрывало дыхание, с каждым выходом члена глубоко в ваш рот вы задыхались.
А сзади началась жара, Дэн и Витек по очереди стали терзать ваш анус. Видимо им это действительно доставляло невиданное удовольствие ебать в жопу, потом давать в рот.'
	if txt_sex_group_anal = 2:$txt_sex_group_anal = 'Так давайте двое по бокам один сзади - распорядился Дэн. Вы наклонились, упершись руками, двое пацанов встали по бокам, приставив свои члены к вашему лицу, третий зашел к вам сзади, и, облапав вашу попу, стал тыкаясь членом между булок пристраиваться к вашему колечку ануса.
Когда наконец член вошел в вашу дырку. Вы издали стон удовольствия. Витек начал вас трахать, вы поворачивая голову то в одну то в другую сторону, стали обсасывать члены стоящих рядом с вами ребят.
Постепенно темп члена в вашей попке нарастал, вместе с ним нарастало и ваше собственное возбуждение.'
	'<<$txt_sex_group_anal>>'
}
!двойное проникновение и отсос:
$text_sex_group_dp = {
txt_sex_group_dp = RAND(1,4)
	if txt_sex_group_dp = 1:$txt_sex_group_dp = 'Дэн прижал вас к своей груди и начал с силой и глубоко пихать в вас свой член, доставая до самой матки. Потом повернул голову к Ваське и сказал ему, чтобы заканчивал дрочить и начал трахать вас в зад.
Тот только этого и ждал, одним прыжком он оказался около вас, и, встав на колени, начал вставлять член вам в зад.
Дэн крепко охватил вашу спину руками и замер, давая возможность Ваську пропихнуть член. Естественно, разработанная попка, приняла его член почти без проблем.
Хотя когда его член протискивался мимо огромного члена Дэна, вам казалось, что они порвали перегородку между дырками и теперь трахают одну большую дыру.
В этот момент не выдержал такой картины Витек и подошел к вашему рту и при сунул свою залупу, вы начали умело обсасывать его хуй.
А сзади сначала двигался только Васян, а Дэн блаженно лежал под вами и мял ваши груди. Потом они стали поочередно входить в вас, но им показалось этого мало, и они по счету раз, стали вместе задвигать в меня члены.
Вы были зажаты между ними, как котлета в булочке, даже голова была занята хуем. Вы могли только глухо стонать, при одновременном вхождении в вас их членов. '
	if txt_sex_group_dp = 2:$txt_sex_group_dp = 'Они втроем, начали вас трахать, Дэн в письку, Витек в попку, а Василию достался ваш рот, они постепенно увеличивая темп и глубину проникновения.
Витек так старательно и нежно начал мять ваши груди и целовать тело, а Дэн гладил и раскачивал вашу попку, помогая вам насаживаться на их члены, у вас от такого в голове начали происходить странные метаморфозы.
Ребята напоследок стали проявлять столько нежности, что вы даже немного расслабились и начали получать удовольствие.
Вы даже начали слегка подмахивать им задом, помогая засаживать их члены и усерднее работали головой глубже пропихивая в горло член Василия.
Витек шептал вам всякие пошлости типа: что вы самая лучшая блядь в его жизни, что лучше девушки он не ебал и так далее.'
	if txt_sex_group_dp = 3:$txt_sex_group_dp = 'Положив Витька на спину, сев на его член глубоко, вы двигались не быстро ,насаживалась на всю глубину, одновременно взяв в рот член Дэна, который пытался глубже пропихнуть свой хуй.
Такого кайфа вы не испытывала никогда. Присутствовало только одно желание - что бы это никогда не заканчивалось! И тут в вашу сырую попку вошел очень аккуратно член Василия.
Это было чудесно! Вы чувствовали, как два члена разделяет только тоненькая перегородочка. Вас имели со всех сторон как резиновую куклу. '
	if txt_sex_group_dp = 4:$txt_sex_group_dp = 'Вы забрались на Васю и сели на его член. Член медленно входил в вашу плоть, доставляя невероятное удовольствие своему хозяину. Дэн, достав своего стоящего бойца, стал неуклюже тыкать вам в попу.
Его член был длинным и тонким. Вначале анус сопротивлялся и не впускал настойчивого бойца. Дэн усилил нажим, его член изогнулся, слегка сморщился. Но постепенно, сначала маленькая часть, а затем и вся головка исчезла в вашей заднице, оставляя снаружи крайнюю плоть.
Спустя некоторое время Дэн вовсю гонял своего длинного красавца в вашей попе. Вася пыхтел под вами, насаживая ваше влагалище, издавая чавкающие звуки. Вы извивались на членах, внутри нарастало давно забытое чувство приближающего оргазма.
В губы стало тыкаться, что-то мягкое и горячее. Это был член Вити. Открыв глаза, вы взяли в руку его член, и стали страстно сосать его головку. При этом работая по стволу рукой.'
	'<<$txt_sex_group_dp>>'
}
!двойное проникновение в попу:
$text_sex_group_dpa = {
	$txt_sex_group_dpa = 'Дэн прижал вас к своей груди и начал с силой и глубоко пихать в вашу попку свой член. Потом повернул голову к Васе и сказал ему, чтобы заканчивал дрочить и начал вставлять хуй в зад.
Тот только этого и ждал, одним прыжком он оказался около вас, и, встав на колени, начал вставлять член вам в анус.
Дэн крепко охватил вашу спину руками и замер, давая возможность Ваське пропихнуть член. Естественно, разработанная попка, приняла его член почти без проблем.
Когда он пропихнул свой член и теперь они вместе трахают одну большую дыру. Вы подумали что теперь ваше очко никогда не закроется, а будет лузой для хуев любого размера.
Не выдержал такой картины Витек и подошел к вашему рту и присунул свою залупу, вы начали умело обсасывать его хуй, активно подмахивая попкой активнее насаживаясь на хуи ребят.'
	'<<$txt_sex_group_dpa>>'
}
!тройное проникновение в попу:
$text_sex_group_triple = {
	$txt_sex_group_triple = 'Мальчики, сняв с вас остатки одежды, положили вас на кровать. Вы отдались в их руки как резиновая кукла, с которой можно воплотить все фантазии.
	Вы не успели опомниться, как вас уже ебали в жопу в три хуя. Ваше тело просто использовали как хотели...'
	'<<$txt_sex_group_triple>>'
}
!выбор секса:
$shgopsex_group = {
	cla
	gs'stat'
	group_sex_text = RAND(0,8)
		if group_sex_text = 0:$group_sex_text = '- "Ну чего <<$gop_text_npcr>> как меня <<$gop_sextext1>> будите?", игриво спрашиваете вы.'
		if group_sex_text = 1:$group_sex_text = '- "<<$gop_gg_name>> как тебя <<$gop_sextext1>> будем?", спрашивает <<$gop_name_npc>>.'
		if group_sex_text = 2:$group_sex_text = '- "<<$gop_gg_name>>, дупло готовь, ща по кругу пустим!", говорит <<$gop_family_npc>>.'
		if group_sex_text = 3:$group_sex_text = '- "<<$gop_name_gg>>, я же вижу, дырки то зудят у тебя, ебаца хочешь ведь!?", спрашивает <<$gop_name_npc>>.'
		if group_sex_text = 4:$group_sex_text = '- "<<$gop_name_gg>> - <<$gop_gg_name>>, готова три хуя обслуживать?", спрашивает <<$gop_name_npc>>.'
		if group_sex_text = 5:$group_sex_text = '- "<<$gop_name_gg>>, может мы тебя сразу во все дыры <<$gop_sextext1>> будем?", спрашивает <<$gop_name_npc>>.'
		if group_sex_text = 6:$group_sex_text = '-"<<$gop_name_gg>>, ты же наша <<$gop_gg_name>>, давай сразу во все щели!", говорит <<$gop_family_npc>>.'
		if group_sex_text = 7:$group_sex_text = 'Вы подмигнули пацанам и сказали: -"Мальчики ваша <<$gop_name_gg>> готова на все, как <<$gop_sextext1>> хотите?".'
		if group_sex_text = 8:$group_sex_text = 'Вы по блядски улыбнулись и сказали: -"Ваша <<$gop_name_gg>> хочет кончи, как <<$gop_sextext1>> будите?".'
	''
	'<<$group_sex_text>>'
	if mesec > 0 and vagina >= 1:
		'<font color = red><b>Вы предупреждаете, что у вас месячные и в пизду доступ закрыт!</b></font>'
	elseif vagina = 0:
		'<font color = red><b>Вы предупреждаете, что вы бережете свою девственность, по этому в письку не даете!</b></font>'
	end
	act 'Сосать по очереди': dynamic $shgopsex_group_bj
	if bj >= 50:
		act 'Сосать всем сразу': dynamic $shgopsex_group_bja
	end
	if vagina >=1 and mesec <=0:
		act 'В пизду': dynamic $shgopsex_group_vag
		act 'В пизду и попу': dynamic $shgopsex_group_dp
	end
	act 'В попу': dynamic $shgopsex_group_anal
	if anus >= 20:
		act 'Два члена в попу': dynamic $shgopsex_group_twoanal
	end
	if anus >= 30:
		act 'Три члена в попу': dynamic $shgopsex_group_tripleanal
	end
	if dom => 10:
		act 'Уйти': gt'shulga_room'
	end
}
!окончание секса
$shgopsex_group_end = {
	cla
	shgopsex_group_count = $shgopsex_group_count
	gs'stat'
	!'<<shgopsex_group_count>>'
	!если сосали, кончаем в рот, лицо или тело
	if sh_bjandhj_cum >=1:
		act 'В рот': dynamic $shgopsex_group_swallow
		act 'На лицо': dynamic $shgopsex_group_cumface
		act 'На тело': dynamic $shgopsex_group_cumbelly
	!если ебали, кончаем куда угодно
	else
		act 'В рот': dynamic $shgopsex_group_swallow
		act 'На лицо': dynamic $shgopsex_group_cumface
		act 'На тело': dynamic $shgopsex_group_cumbelly
		act 'В писю': dynamic $shgopsex_group_cumvag
		act 'В попу': dynamic $shgopsex_group_cumanal
	end
}
!отсос по очереди
$shgopsex_group_bj = {
	*clr & cla
	if throat < 20: throat += 1
	horny += 5
	minut += rand(7,12)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 1
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/oral/bj'+rand(1,3)+'.jpg"></center>'
	dynamic $text_sex_group_bj
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		dynamic $shgopsex_group_end
	end
}
!отсос всем сразу
$shgopsex_group_bja = {
	*clr & cla
	if throat < 20: throat += 1
	horny += 10
	minut += rand(5,10)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 1
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/oral/bja'+rand(1,25)+'.jpg"></center>'
	dynamic $text_sex_group_bjall
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		anal +=3
		sex +=3
		bj +=3
		dynamic $shgopsex_group_end
	end
}
!дать в пизду
$shgopsex_group_vag = {
	*clr & cla
	horny += 10
	minut += rand(10,15)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 0
	if vagina < 20: vagina += 1
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/vag'+rand(1,26)+'.jpg"></center>'
	dynamic $text_sex_group_vag
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		anal +=3
		sex +=3
		bj +=3
		dynamic $shgopsex_group_end
	end
}
!дать в жопу
$shgopsex_group_anal = {
	*clr & cla
	if anus < 20: anus += 1
	horny += 10
	minut += rand(10,15)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 0
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/anal'+rand(1,18)+'.jpg"></center>'
	dynamic $gop_groupsex_analplugin
	dynamic $gop_groupsex_lubri
	dynamic $text_sex_group_anal
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		anal +=3
		sex +=3
		bj +=3
		dynamic $shgopsex_group_end
	end
}
!дп
$shgopsex_group_dp = {
	*clr & cla
	horny += 20
	minut += rand(7,15)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 0
	if vagina < 20: vagina += 1
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/dp'+rand(1,30)+'.jpg"></center>'
	dynamic $gop_groupsex_analplugin
	dynamic $gop_groupsex_lubri
	dynamic $text_sex_group_dp
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		anal +=3
		sex +=3
		bj +=3
		dynamic $shgopsex_group_end
	end
}
!два хуя в жопу
$shgopsex_group_twoanal = {
	*clr & cla
	horny += 15
	minut += rand(7,15)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 0
	if anus < 30: anus += 1
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/dpa'+rand(1,10)+'.jpg"></center>'
	dynamic $gop_groupsex_analplugin
	dynamic $gop_groupsex_lubri
	dynamic $text_sex_group_dpa
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		anal +=3
		sex +=3
		bj +=3
		dynamic $shgopsex_group_end
	end
}
!три хуя в жопу
$shgopsex_group_tripleanal = {
	*clr & cla
	horny += 20
	minut += rand(5,15)
	shgopsex_group_count -= 1
	sh_bjandhj_cum = 0
	gs'stat'
	dynamic $ind_stamina_groupnpc
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/sex/triple'+rand(1,4)+'.jpg"></center>'
	dynamic $gop_groupsex_analplugin
	dynamic $gop_groupsex_lubri
	dynamic $text_sex_group_triple
	dynamic $gg_sex_orgasm
	dynamic $npc_orgasm
	if shgopsex_group_count > 0:
		act 'Выбор секса': dynamic $shgopsex_group
		!act 'Закончить': dynamic $shgopsex_group_end
	else
		anal +=3
		sex +=3
		bj +=3
		dynamic $shgopsex_group_end
	end
}
!=========!
!окончание!
!---------!
!окончание на лицо
$shgopsex_group_cumface = {
	*clr & cla
	gs 'zz_funcs', 'cum', 'face'
	minut += rand(2,5)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/cum/cumface'+rand(1,23)+'.jpg"></center>'
	'<<$gop_text_npcr>> обкончали ваше милое личико.'
	act 'Уйти': gt'shulga_room'
}
!окончание в рот
$shgopsex_group_swallow = {
	*clr & cla
	swallow += 1
	minut += rand(2,5)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/cum/swallow'+rand(1,12)+'.jpg"></center>'
	'<<$gop_text_npcr>> излили сперму вам в рот и вы её проглотили.'
	act 'Уйти': gt'shulga_room'
}
!окончание на тело
$shgopsex_group_cumbelly = {
	*clr & cla
	gs 'zz_funcs', 'cum', 'belly'
	minut += rand(2,5)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/cum/cumbody'+rand(1,15)+'.jpg"></center>'
	'<<$gop_text_npcr>> обтрухали все ваше тело.'
	act 'Уйти': gt'shulga_room'
}
!окончание в пизду
$shgopsex_group_cumvag = {
	*clr & cla
	cumpussy +=1
	minut += rand(2,5)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/cum/cumvag'+rand(1,6)+'.jpg"></center>'
	'<<$gop_text_npcr>> по очереди излились вам в пизду.'
	act 'Уйти': gt'shulga_room'
}
!окончание в попу
$shgopsex_group_cumanal = {
	*clr & cla
	gs 'zz_funcs', 'cum', 'ass'
	minut += rand(2,5)
	gs'stat'
	'<center><img src="images/zsoft/pod_ezd/shulgahome/bigroom/gopsex/group/cum/cumass'+rand(1,9)+'.jpg"></center>'
	'<<$gop_text_npcr>> по очереди накачали вашу жопу спермой.'
	act 'Уйти': gt'shulga_room'
}