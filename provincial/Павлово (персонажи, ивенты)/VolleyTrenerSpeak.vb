minut += 15
gs 'stat'
gs 'npc_editor','init_sex',28
$din_trener_discoSex={
	*clr & cla
	gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener4.jpg', func('VolleyTrenerSpeak_strings', 'local_str1')
	act 'Поити за ним':
		*clr & cla
		Joke = 0
		if horny > 80:
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensexdisco1.webm', func('VolleyTrenerSpeak_strings', 'local_str2')
			act 'Задрать подол':
				*clr & cla
				gs 'npc_editor','change_rep','+', 28
				horny += 10
				if tanga = 1: gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensexdisco2.webm', func('VolleyTrenerSpeak_strings', 'local_str30')
				if tanga = 0: gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensexdisco3.jpg', func('VolleyTrenerSpeak_strings', 'local_str31')
				act 'Выставить попку':
					*clr & cla
					horny += 10
					minut += 20
					gs 'stat'
					gs 'zz_render','','images/pavlovo/dk/volley/voitrensexdisco4.webm', func('VolleyTrenerSpeak_strings', 'local_str3')
					act'Подмахивать':
						*clr & cla
						gs 'zz_render','','images/pavlovo/dk/volley/voitrensexdisco5.webm'
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						act 'Далее':
							*clr & cla
							gs 'zz_funcs', 'cum', 'ass'
							gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensexdisco6.webm', func('VolleyTrenerSpeak_strings', 'local_str4')
							act'Пойти с тренером':
								*clr & cla
								Discoclose = 1 &!закрытие диско на этот день не забыть про stat
								minut += 20
								gs 'stat'
								gs 'zz_render', '', 'images/pic/gorodok.jpg', func('VolleyTrenerSpeak_strings', 'local_str5')
								dynamic $din_trener_Speak
							end
						end
					end
				end
			end
		else
			gs 'zz_render', '', 'images/pavlovo/dk/volley/voitrensexdisco7.jpg', func('VolleyTrenerSpeak_strings', 'local_str6')
			act 'Пойти с тренером':
				*clr & cla
				Discoclose=1 &!закрытие диско на этот день не забыть про stat
				minut += 20
				gs 'stat'
				gs 'zz_render', '', 'images/pic/gorodok.jpg', func('VolleyTrenerSpeak_strings', 'local_str7')
				dynamic $din_trener_Speak
			end
		end
	end
}
$din_trener_Speak={
	act 'Попробовать поговорить':
		cla
		if $npc['28,relation'] => 40 and trener_Speak=0:
			trener_Speak+=1 & ! счетчик болтания с тренером
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str8')
			if horny > 80 or func('zz_reputation','get') > 0:
				gs 'npc_editor','change_rep','+', 28
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str32')
			elseif $npc['28,relation'] > 10 and trener_Speak=1:
				trener_Speak += 1
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str9')
			end
			if horny > 80 or func('zz_reputation','get') > 0:
				gs 'npc_editor','change_rep','+', 28
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str33')
			elseif $npc['28,relation'] > 20 and trener_Speak=2:
				trener_Speak+=1
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str10')
			end
			if horny > 80 or func('zz_reputation','get') > 0:
				gs 'npc_editor','change_rep','+', 28
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str34')
			end
			act 'Прервать':
				*clr & cla
				horny += 10
				gs'stat'
				if Discoclose=1: gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak1.jpg', func('VolleyTrenerSpeak_strings', 'local_str36')
				if trenerskaia=1 and Discoclose=0:gs 'zz_render', '', 'img src="images/pavlovo/dk/volley/VoltrenerSpeak2.jpg', func('VolleyTrenerSpeak_strings', 'local_str35')
				act 'Уйти':
					if Discoclose = 1: gt 'korrPar'
					if trenerskaia = 1: gt 'gdksport'
				end
			end
		elseif $npc['28,relation']>30 and trener_Speak=3:
			trener_Speak+=1
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str11')
			volleytanga=1 & ! флаг запуска тренеровок без трусиков в gdksport - зайти в тренерскую
			act 'Проверить':
				*clr & cla
				horny+= 10
				gs'stat'
				if Discoclose=1: gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak3.jpg', func('VolleyTrenerSpeak_strings', 'local_str37')
				if trenerskaia=1 and Discoclose=0: gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak4.jpg', func('VolleyTrenerSpeak_strings', 'local_str38')
				act 'Уйти':
					if Discoclose = 1: gt 'korrPar'
					if trenerskaia = 1: gt 'gdksport'
				end
			end
		elseif $npc['28,relation']>40 and trener_Speak=4 and VoltrenerVoyeur=3:
			trener_Speak += 1
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str12')
			sopr=0 & ! закрываю подглядывание за светой соло
			ShowerIvan=1 & ! флаг запуска подглядываний тренера за ваней и вами
			if horny>80:
				gs 'npc_editor','change_rep','+', 28
				'Вы решаете проверить так уж он переживает как говорит.'
			end
			act'Проверить':
				*clr & cla
				horny += 10
				gs 'stat'
				if Discoclose = 1:
					if tanga = 1:
						gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSpeak5.jpg',func('VolleyTrenerSpeak_strings', 'local_str39')
					else
						gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSpeak6.jpg',func('VolleyTrenerSpeak_strings', 'local_str40')
					end
				else
					if trenerskaia = 1: gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSpeak7.gif',func('VolleyTrenerSpeak_strings', 'local_str41')
				end
				act 'Уйти':
					if Discoclose = 1: gt 'korrPar'
					if trenerskaia = 1: gt 'gdksport'
				end
			end
		elseif $npc['28,relation'] > 50 and trener_Speak=5 and VoltrenerVoyeur=5:
			trener_Speak += 1
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str13')
			act 'Смиренно слушать':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak20.jpg', func('VolleyTrenerSpeak_strings', 'local_str14')
				gs 'npc_editor','change_rep','+', 28
				centr=1 & ! флаг на появление тернера в центре
				act'Поцеловать':
					*clr & cla
					flag1=1 & ! флаг закрытия тренера в душе пока не поговорит с китайцем
					gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSpeak8.jpg',func('VolleyTrenerSpeak_strings', 'local_str42')
					act 'Достать член':
						*clr & cla
						gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSpeak9.jpg',func('VolleyTrenerSpeak_strings', 'local_str43')
						act 'Взять в рот':
							*clr & cla
							horny += 10
							gs 'stat'
							gs 'zz_render','','images/pavlovo/dk/volley/VoltrenerSpeak10.jpg',func('VolleyTrenerSpeak_strings', 'local_str44')
							act 'Попрощаться':
								if Discoclose = 1: gt 'korrPar'
								if trenerskaia = 1: gt 'gdksport'
							end
						end
					end
				end
			end
		elseif trener_Speak=6 and centr=3:
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak19.jpg', func('VolleyTrenerSpeak_strings', 'local_str15')
			centr = 4
			flag1 = 0 & ! продолжаем события после китайца
			trener_Speak += 1
		elseif trener_Speak = 7 and $npc['28,sex'] => 1:
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak21.jpg', func('VolleyTrenerSpeak_strings', 'local_str16')
			act 'Напомнить о случившемся':
				*clr & cla
				gs 'npc_editor','change_rep','-', 28, 50
				volleysostav = -1
				gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak22.jpg', func('VolleyTrenerSpeak_strings', 'local_str17')
				act 'Уйти':
					if Discoclose=1: gt 'korrPar'
					if trenerskaia=1: gt 'gdksport'
				end
			end
			act 'Стерпеть обиду':
				*clr & cla
				gs 'npc_editor','change_rep','+', 28
				trener_Speak += 1
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str18')
				if Discoclose=1 and tanga= 1: gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak25.jpg', func('VolleyTrenerSpeak_strings', 'local_str45')
				if Discoclose=1 and tanga= 0: gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak24.gif', func('VolleyTrenerSpeak_strings', 'local_str46')
				if trenerskaia=1 and Discoclose=0: gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak23.gif', func('VolleyTrenerSpeak_strings', 'local_str47')
				gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str19')
				act 'Уйти':
					if Discoclose = 1: gt 'korrPar'
					if trenerskaia = 1: gt 'gdksport'
				end
			end
		elseif trener_Speak=8 and $npc['28,relation'] > 150 and volleyboll>150:
			trener_Speak+=1
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener5.jpg', func('VolleyTrenerSpeak_strings', 'local_str20')
			volleysostav = 2
		else
			dynamic $din_trener_SpeakHis
		end
		act'Попрощаться':
			if Discoclose=1:gt 'korrPar'
			if trenerskaia=1:gt 'gdksport'
		end
	end
}
$din_trener_SpeakHis={
	gs 'npc_editor','change_rep','+', 28
	gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str21')
	gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str'+(rand(1,10) + 51))
}
!---------------------------Пока не в составе-------------------------
if volleysostav = 0:
	gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener1.jpg', func('VolleyTrenerSpeak_strings', 'local_str22')
	if volleyboll>0 and volleyboll<20:
		gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str48')
	end
	if volleyboll>20 and volleyboll<35:
		gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str49')
	end
	if volleyboll>35 and volleyboll<60:
		gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str50')
	end
	if volleyboll>60 and volleyboll<80:
		gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str23')
		if horny >= 80:
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str24')
		else
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str25')
		end
	end
	if volleyboll > 80: gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str26')
end
!------------------------------------------Попала в состав--------------------------------------
if volleysostav > 0:
	if Joke >= 3:
		dynamic $din_trener_discoSex
	else
		gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener2.jpg', func('VolleyTrenerSpeak_strings', 'local_str27')
		if alko > 0:
			gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str51')
			gs 'npc_editor','change_rep','-',28
			seealko=500
		end
		gs 'zz_render', '', '', func('VolleyTrenerSpeak_strings', 'local_str28')
		act'Пойти с тренером':
			*clr & cla
			Discoclose = 1 &!закрытие диско на этот день не забыть про stat
			minut += 20
			gs 'stat'
			gs 'zz_render', '', 'images/pic/gorodok.jpg', func('VolleyTrenerSpeak_strings', 'local_str29')
			dynamic $din_trener_Speak
		end
	end
end
act 'Отойти':gt $loc, $metka