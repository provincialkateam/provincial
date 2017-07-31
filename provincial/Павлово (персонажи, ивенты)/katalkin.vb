gs'stat'
gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str1')
if hour >= 8 and hour < 22:
	gs 'zz_render', '', '', func('katalkin_strings', 'local_str2')
	if katalkinSexDay < daystart and $npc['41,sex'] = 1:
		if schtraf = 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str3')
			act 'Пить чай':
				*clr & cla
				minut += 5
				katalkinNoexit = 0
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str4')
				act 'Положить ему руку на ширинку':katsexetap = 1 & gt'katalkinSex'
				act 'Не двигаться':katsexetap = 0 & gt'katalkinSex'
			end
		elseif schtraf > 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str5')
			if money >= schtraf:
				act 'Заплатить штраф':
					*clr & cla
					money -= schtraf
					schtraf = 0
					katalkinNoexit = 0
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str6')
					act 'Уйти':minut += 1 & gt'vokzalGin'
				end
			end
			act 'Отработаю':katsexetap = 0 & gt'katalkinSex'
		end
	elseif katalkinSexDay = daystart and $npc['41,sex'] = 1:
		if schtraf = 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str7')
		elseif schtraf > 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str8')
			act 'До свидания':
				*clr & cla
				schtraf = 0
				katalkinNoexit = 0
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str9')
				act 'Уйти':minut += 1 & gt $curloc
			end
		end
	elseif $npc['41,sex'] = 0:
		if schtraf = 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str10')
			act 'Пить чай':
				*clr & cla
				minut += 5
				katalkinNoexit = 0
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str11')
				act 'Уйти':minut += 1 & gt $curloc
				act 'Не двигаться':katsexetap = 0 & gt'katalkinSex'
			end
		elseif schtraf > 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str12')
			if money >= schtraf:
				act 'Заплатить штраф':
					*clr & cla
					money -= schtraf
					schtraf = 0
					katalkinNoexit = 0
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str13')
					act 'Уйти':minut += 1 & gt'vokzalGin'
				end
			else
				act 'У меня нет денег':
					*clr & cla
					money = 0
					schtraf = 0
					katalkinNoexit = 0
					kutime = 24
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str14')
					act 'В кутузку':gt'kutuzka'
				end
			end
			act 'Упрашивать':
				*clr & cla
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str15')
				if money >= schtraf:
					gs 'zz_render', '', '', func('katalkin_strings', 'local_str16')
					act 'Заплатить штраф':
						*clr & cla
						money -= schtraf
						schtraf = 0
						katalkinNoexit = 0
						gs'stat'
						gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str17')
						act 'Уйти':minut += 1 & gt'vokzalGin'
					end
				elseif money < schtraf:
					gs 'zz_render', '', '', func('katalkin_strings', 'local_str18')
				end
				act 'Улыбнуться ему':katsexetap = 0 & gt'katalkinSex'
			end
		end
	end
elseif hour >= 22:
	gs 'zz_render', '', '', func('katalkin_strings', 'local_str19')
	if $npc['41,sex'] = 1:
		if katGangMeet = 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str20')
			act 'Сесть за стол':
				*clr & cla
				minut += 5
				katalkinNoexit = 0
				katGangMeet = 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str21')
				act 'Выпить за знакомство':
					gs 'zz_funcs', 'alko', 2
					gt 'katalkinAlko'
				end
			end
		elseif katGangMeet > 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str22')
			act 'Сесть за стол':
				*clr & cla
				minut += 5
				katalkinNoexit = 0
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str23')
				act 'Выпить рюмку':
					gs 'zz_funcs', 'alko', 2
					gt 'katalkinAlko'
				end
			end
		end
	elseif $npc['41,sex'] = 0:
		gs 'zz_render', '', '', func('katalkin_strings', 'local_str24')
		if schtraf = 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str25')
			act 'Сесть за стол':
				*clr & cla
				minut += 5
				katalkinNoexit = 0
				gs'stat'
				gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str26')
				act 'Уйти':minut += 1 & gt $curloc
				act 'Не двигаться':katsexetap = 0 & gt'katalkinSex'
			end
		elseif schtraf > 0:
			gs 'zz_render', '', '', func('katalkin_strings', 'local_str27')
			if money >= schtraf:
				act 'Заплатить штраф':
					*clr & cla
					money -= schtraf
					schtraf = 0
					katalkinNoexit = 0
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str28')
					act 'Уйти':minut += 1 & gt'vokzalGin'
				end
			else
				act 'У меня нет денег':
					*clr & cla
					money = 0
					schtraf = 0
					katalkinNoexit = 0
					kutime = 24
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('katalkin_strings', 'local_str29')
					act 'В кутузку':gt'kutuzka'
				end
			end
		end
	end
elseif hour < 8:
	gs 'zz_render', '', '', func('katalkin_strings', 'local_str30')
	act 'Уйти':minut += 1 & gt'vokzalGin'
end
if katalkinNoexit = 0:act 'Уйти':minut += 1 & gt'vokzalGin'