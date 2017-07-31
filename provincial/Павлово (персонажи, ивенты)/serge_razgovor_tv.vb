$serge_tv = {
	if hour >=0 and hour < 7:
		*clr & cla
		gs'stat'
		gs 'zz_render', '', '', func('serge_razgovor_tv_strings', '1')
		act 'Уйти': dynamic $shsroom
	elseif hour >= 7 and hour <= 23:
		*clr & cla
		minut +=30
		gs'stat'
	serge_tv_rnd = RAND(0,3)
				if serge_tv_rnd = 0:$serge_tv_rnd = 'По телевизору идет'
				if serge_tv_rnd = 1:$serge_tv_rnd = 'По телевизору показывают'
				if serge_tv_rnd = 2:$serge_tv_rnd = 'Показывают'
				if serge_tv_rnd = 3:$serge_tv_rnd = 'Идет'
	serge_tv_rand = RAND(0,11)
				$zz_str = '<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tv'
				if serge_tv_rand = 0:$serge_tv_rand = $zz_str + 'dance.gif"></center><<$serge_tv_rnd>> подростковый музыкальный клип, где девушки трясут своими прелестями.'
				if serge_tv_rand = 1:$serge_tv_rand = $zz_str + 'geo1.gif"></center><<$serge_tv_rnd>> документальный фильм про животных.'
				if serge_tv_rand = 2:$serge_tv_rand = $zz_str + 'geo2.gif"></center><<$serge_tv_rnd>> документальный фильм про мир.'
				if serge_tv_rand = 3:$serge_tv_rand = $zz_str + 'geo3.gif"></center><<$serge_tv_rnd>> документальный фильм про природу.'
				if serge_tv_rand = 4:$serge_tv_rand = $zz_str + 'geo4.gif"></center><<$serge_tv_rnd>> документальный фильм про океан.'
				if serge_tv_rand = 5:$serge_tv_rand = $zz_str + 'kino1.gif"></center><<$serge_tv_rnd>> всеми любимая советская комедия.'
				if serge_tv_rand = 6:$serge_tv_rand = $zz_str + 'kino2.gif"></center><<$serge_tv_rnd>> импортный блокбастер.'
				if serge_tv_rand = 7:$serge_tv_rand = $zz_str + 'kino3.gif"></center><<$serge_tv_rnd>> старый вестерн.'
				if serge_tv_rand = 8:$serge_tv_rand = $zz_str + 'mult1.gif"></center><<$serge_tv_rnd>> относительно новый импортный мультик.'
				if serge_tv_rand = 9:$serge_tv_rand = $zz_str + 'mult2.gif"></center><<$serge_tv_rnd>> старый мультик.'
				if serge_tv_rand = 10:$serge_tv_rand = $zz_str + 'sport1.gif"></center><<$serge_tv_rnd>> бой без правил.'
				if serge_tv_rand = 11:$serge_tv_rand = $zz_str + 'sport2.gif"></center><<$serge_tv_rnd>> футбол.'
				killvar '$zz_str'
	rndtv=rand(1,100)
	if rndtv>10:'<<$serge_tv_rand>>'
	if rndtv<=10:'<center><img src="images/zsoft/pod_ezd/shulgahome/tv/tvrekl'+rand(1,4)+'.gif"></center> Идет реклама.'
	act 'Уйти': dynamic $shsroom
	act 'Переключить канал': dynamic $serge_tv
	if $npc['36,relation']>50:
	act 'Переключить на порно канал':
			*clr & cla
			horny +=10
			minut +=10
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/tv/tvporn'+rand(1,4)+'.gif', func('serge_razgovor_tv_strings', '2')
			if horny > 30:
				gs 'zz_render', '', '', func('serge_razgovor_tv_strings', '3')
			end
			act 'Уйти': dynamic $shsroom
			if $npc['36,relation']>70 and horny>30 and mesec <= 0:
				act 'Приставать': dynamic $sleep_prstsex
			end
		end
	end
	end
}
*clr
minut += 1
gs 'stat'
if sergebazar_day ! daystart: sergebazar_count = 10
gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge2.jpg', func('serge_razgovor_tv_strings', '4')
dynamic $serge_shulgin_rep
act 'Отойти': dynamic $shsroom
act 'Поговорить':
	*clr & cla
	minut += 15
	sergebazar_day = daystart
	sergebazar_count -= 1
	if sergebazar_count > 0: gs 'npc_editor','change_rep','+', 36
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/serge1.jpg', func('serge_razgovor_tv_strings', '22')
	dynamic $serg_bazar_rep
	if sergebazar_count <= 0:
		'Сергей сказал: - "<<$name>>, извини но не сейчас, важный матч начался, дай посмотреть, не отвлекай."'
	else
		gs 'zz_render', '', '', func('serge_razgovor_tv_strings', iif($npc['36,relation'] < 40,rand(5,13),rand(14,21)))
	end
	act 'Далее': gt 'serge_razgovor_tv'
	if $npc['36,relation'] > 60: act 'Прилечь рядом и смотреть ТВ': dynamic $serge_tv
end