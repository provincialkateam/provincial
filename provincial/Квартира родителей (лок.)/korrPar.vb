$metka = $ARGS[0]
$loc = $CURLOC
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
	act 'Идти в вашу комнату': gt 'sisterQW','sisboyQW_bedroom'
elseif blockBedrPar = 0 and sisboyday + 1 = daystart and hour = 18 and $npc['38,qwSisterTrio'] = 1:
	act 'Идти в вашу комнату': gt 'sisterQW','sisboytrioQW_bedroom'
elseif blockBedrPar = 0:
	act 'Идти в вашу комнату': gt 'bedrPar'
end
if parentsexday ! day: act 'Идти в комнату родителей': gt 'bedrPar2', 'main'
act 'Идти в зал': gt 'sitrPar'
act 'Идти в ванную': gs 'zz_bathroom','start'
act 'Идти на кухню': gt 'kuhrPar'
act '<font color = maroon>В подъезд</font>':
	if current_clothing > 2:
		minut += 5
		gt 'pod_ezd','etaj_2'
	else
		gs 'zz_render','','','<red>ВАМ НАДО ОДЕТЬСЯ.</red>'
		exit
	end
end
act '<font color = maroon><b>Идти на улицу</b></font>':
	if current_clothing > 2:
		minut += 10
		gt 'gorodok'
	else
		gs 'zz_render','','','<red>ВАМ НАДО ОДЕТЬСЯ.</red>'
		exit
	end
end
gs 'zz_render', 'Коридор', 'pavlovo/family/apartment/korr.jpg', 'На стене возле входной двери висит <a href="exec:GT ''mirror'',''start''">зеркало</a>.'
!короткие ивенты
if current_clothing = 1 and $brother['location'] = 'sitrPar' and RAND(0,5) = 0 and hour >= 20 and hour < 23 and $npc['39,rand_event_day']!day: gt 'short_random','pol_rand1'
!конец коротких ивентов
if palto > 0: gs 'zz_render', '', '', 'На крючке висит <<$palto>>'
if indorf = 0 and (week < 6 and (hour = 7 or hour >= 18 and hour <= 20) or week >= 6 and hour >= 7 and hour <= 20):
	if gad_punishment = 1 and $npc['37,relation'] < 80:gt 'gadukino_event', 'punishment'
	if gadukino_blok = 1 and grandmaQW > 40 and grandpaQW > 40: gt 'gadukino_event', 'absolution'
	if gadukino_blok = 1 and gad_offense = 1:gt 'gadukino_event', 'offense'
end
if hour >= 17 and hour <= 20 and indorf = 0:
	if artomvbrosvid = 1 and artomhakday ! daystart and mothervideotalk = 0 or BrotherNo = 1 and BrotherNoDay ! day:
		*clr & cla
		BJvideoPublic = 1
		BrotherNo = 0
		BrotherNoDay = day
		manna = 0
		gs 'stat'
		gs 'npc_editor','get_npc_profile',37
		gs 'zz_render','','',func('korrPar_strings', 'local_str1')
		if momslut < 2:
			act 'Умолять ничего не делать':
				*clr & cla
				mothervideotalk = 2
				minut += 5
				dom -= 5
				gs 'stat'
				gs 'npc_editor','get_npc_profile',37
				gs 'zz_render','','', func('korrPar_strings', 'local_str2')
				act 'Отойти':gt $curloc
			end
			act 'Молчать':
				*clr & cla
				mothervideotalk = 3
				minut += 5
				dom += 5
				spank += 1
				spanked += 75
				mother_spanking = 1
				gs 'stat'
				gs 'zz_render', '', 'qwest/alter/artom/spank.jpg', func('korrPar_strings', 'local_str3')
				act 'Отойти':gt $curloc
			end
		else
			act 'Угрожать':
				*clr & cla
				mothervideotalk = 1
				minut += 5
				gs 'stat'
				gs 'npc_editor','get_npc_profile',37
				gs 'zz_render','','',func('korrPar_strings', 'local_str4')
				act 'Отойти': gt $curloc
			end
		end
		exit
	end
	if school['absent'] >= 30 and school['certificate'] = 0:
		*clr & cla
		gs 'npc_editor','get_npc_profile',37
		school['block'] += 1
		$npc['37,relation'] = 0
		dom -= 1
		school['absent'] = 0
		gs 'zz_render', '', '', func('korrPar_strings', 'local_str'+(4+school['block']))
		if school['block'] = 3:
			ParHomeBlock = 1
			gs 'zz_clothing', 'lock_school_dress'
			act 'Уйти': gt 'gorodok'
			exit
		end
		act 'Отойти': gt $curloc
		exit
	end
end
if $npc['37,worry_check'] = 1 and family_trip = 0:gs 'dinmother', 'worry'
if notathomesleep > 7 and hour >= 18 and hour <= 20 and family_trip = 0:
	notathomesleep = 0
	*clr
	act '<B>Отойти</B>': gt 'korrPar'
	gs 'zz_render', '', '', func('korrPar_strings', 'local_str' + iif($npc['37,relation'] < 40,8,9))
end
!---
! гг слышит странные звуки с комнаты родителей
if hour = 21 and week ! 1 and father['horny'] >= 70 and family_trip = 0:
	gs 'zz_render', '', '', func('korrPar_strings', 'local_str10')
end
!------------------------------------------!
!если гг шлюха и она отдавалась уже пацанам в подъезде, то клиенты долбят в дверь: !
gs 'pod_whore'
if RAND(0,100) <= iif(pod_whore_countQW <= 15,5,20) and hour >= 10 and hour <= 23 and func('zz_reputation','get') >= 4 and $npc['0,qwPodezdWhore'] >=3: 'Кто-то трезвонит вам в дверь: <a href="exec: dynamic $pod_client_talk">открыть</a>'
!==========================================!