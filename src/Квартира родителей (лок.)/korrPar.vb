$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs 'zz_phone','boyfriend_call_init'
popolaini = 0
frost = 0
minut += 1
gs 'stat'
gs 'zz_funcs', 'colorize_day'
if father['in_garage'] = 0: gs 'zz_family', 'father_sheduler'
gs 'zz_family', 'mother_sheduler'
gs 'zz_family', 'sister_sheduler'
gs 'zz_family', 'brother_sheduler'
if $npc['38,wedding'] >= 2 and month >= 5 and month <= 9 and week = 7 and hour = 10 and sunWeather > 0: gt 'sisterQW','incest_event12sub'
if week = 7 and hour = 10 and $npc['38,anayslut'] = 1 and $npc['38,incest_event14'] = 0: gt 'sisterQW','incest_event14'
if hour ! 18 and blockBedrPar = 1: blockBedrPar = 0
if blockBedrPar = 0 and sisboyday + 1 = daystart and hour = 18 and ($npc['38,qwSisterBoy'] = 3 or $npc['38,qwSisterBoy'] = 5 or $npc['38,qwSisterBoy'] = 7 or ($npc['38,qwSisterBoy'] = 9 and $npc['38,qwSisterTrio'] ! 1)):
	act func('korrPar_strings'+$lang, 'act1'): gt 'sisterQW','sisboyQW_bedroom'
elseif blockBedrPar = 0 and sisboyday + 1 = daystart and hour = 18 and $npc['38,qwSisterTrio'] = 1:
	act func('korrPar_strings'+$lang, 'act1'): gt 'sisterQW','sisboytrioQW_bedroom'
elseif blockBedrPar = 0:
	act func('korrPar_strings'+$lang, 'act1'): gt 'bedrPar'
end
if parentsexday ! day: act func('korrPar_strings'+$lang, 'act2'): gt 'bedrPar2','main'
act func('korrPar_strings'+$lang, 'act3'): gt 'sitrPar'
act func('korrPar_strings'+$lang, 'act4'): gt 'zz_bathroom','init','korrPar'
act func('korrPar_strings'+$lang, 'act5'): gt 'kuhrPar'
act func('korrPar_strings'+$lang, 'act6'):
	if cloth[0] > 2:
		minut += 1
		gt 'pod_ezd','etaj_2'
	else
		gs 'zz_render','','',func('korrPar_strings'+$lang, '11')
		exit
	end
end
act func('korrPar_strings'+$lang, 'act7'):
	if cloth[0] > 2:
		!minut += 10
		gt 'gorodok'
	else
		gs 'zz_render','','',func('korrPar_strings'+$lang, '11')
		exit
	end
end
gs 'zz_render', func('korrPar_strings'+$lang, 'act8'), 'pavlovo/family/apartment/korr.jpg', func('korrPar_strings'+$lang, '12')
!короткие ивенты
if cloth[0] = 1 and $brother['location'] = 'sitrPar' and RAND(0,5) = 0 and hour >= 20 and hour < 23 and $npc['39,rand_event_day']!day: gt 'short_random','pol_rand1'
!конец коротких ивентов
if palto > 0: gs 'zz_render', '', '', func('korrPar_strings'+$lang, '13')
if family_trip = 0 and (week < 6 and (hour = 7 or hour >= 18 and hour <= 20) or week >= 6 and hour >= 7 and hour <= 20):
	if gad_punishment = 1 and $npc['37,relation'] < 80:gt 'gadukino_event', 'punishment'
	if gadukino_blok = 1 and grandmaQW > 40 and grandpaQW > 40: gt 'gadukino_event', 'absolution'
	if gadukino_blok = 1 and gad_offense = 1:gt 'gadukino_event', 'offense'
end
if hour >= 17 and hour <= 20 and family_trip = 0:
	if artomvbrosvid = 1 and artomhakday ! daystart and mothervideotalk = 0 or BrotherNo = 1 and BrotherNoDay ! day:
		*clr & cla
		BJvideoPublic = 1
		BrotherNo = 0
		BrotherNoDay = day
		manna = 0
		gs 'stat'
		gs 'npc_editor','get_npc_profile',37
		gs 'zz_render','','',func('korrPar_strings'+$lang, '1')
		if momslut < 2:
			act func('korrPar_strings'+$lang, 'act9'):
				*clr & cla
				mothervideotalk = 2
				minut += 5
				dom -= 5
				gs 'stat'
				gs 'npc_editor','get_npc_profile',37
				gs 'zz_render','','', func('korrPar_strings'+$lang, '2')
				act 'Отойти':gt $curloc
			end
			act func('korrPar_strings'+$lang, 'act10'):
				*clr & cla
				mothervideotalk = 3
				minut += 5
				dom += 5
				spank += 1
				spanked += 75
				mother_spanking = 1
				gs 'stat'
				gs 'zz_render', '', 'qwest/alter/artom/spank.jpg', func('korrPar_strings'+$lang, '3')
				act func('korrPar_strings'+$lang, 'act11'):gt $curloc
			end
		else
			act func('korrPar_strings'+$lang, 'act12'):
				*clr & cla
				mothervideotalk = 1
				minut += 5
				gs 'stat'
				gs 'npc_editor','get_npc_profile',37
				gs 'zz_render','','',func('korrPar_strings'+$lang, '4')
				act func('korrPar_strings'+$lang, 'act13'): gt $curloc
			end
		end
		exit
	end
	if school['block'] < 3:
		if (school['absent'] >= 30 and school['certificate'] = 0) or absent['stage'] = 3:
			*clr & cla
			gs 'npc_editor','get_npc_profile',37
			school['block'] += 1
			$npc['37,relation'] = 0
			dom -= 1
			school['absent'] = 0
			absent['stage'] = 0
			gs 'zz_render', '', '', func('korrPar_strings'+$lang, ''+(4+school['block']))
			if school['block'] = 3:
				ParHomeBlock = 1
				gs 'zz_clothing2','remove_at',4
				act func('korrPar_strings'+$lang, 'act14'): gt 'gorodok'
				exit
			end
			act func('korrPar_strings'+$lang, 'act15'): gt $curloc
			exit
		end
	end
end
if $npc['37,worry_check'] = 1 and family_trip = 0:gs 'dinmother', 'worry'
if notathomesleep > 7 and hour >= 18 and hour <= 20 and family_trip = 0:
	notathomesleep = 0
	*clr
	act func('korrPar_strings'+$lang, 'act16'): gt 'korrPar'
	gs 'zz_render', '', '', func('korrPar_strings'+$lang, '' + iif($npc['37,relation'] < 40,8,9))
end
!---
! гг слышит странные звуки с комнаты родителей
if hour = 21 and week ! 1 and father['horny'] >= 70 and family_trip = 0:
	gs 'zz_render', '', '', func('korrPar_strings'+$lang, '10')
end
!------------------------------------------!
!если гг шлюха и она отдавалась уже пацанам в подъезде, то клиенты долбят в дверь: !
gs 'pod_whore'
if RAND(0,100) <= iif(pod_whore_countQW <= 15,5,20) and hour >= 10 and hour <= 23 and func('zz_reputation','get') >= 4 and $npc['0,qwPodezdWhore'] >=3: 'Кто-то трезвонит вам в дверь: <a href="exec: dynamic $pod_client_talk">открыть</a>'
!==========================================!