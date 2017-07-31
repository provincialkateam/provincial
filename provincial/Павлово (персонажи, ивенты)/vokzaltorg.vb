$d_kachatprava = {
	act 'Качать права':
		*clr & cla
		money = 0
		tovarL = 0
		minut += 120
		manna = 0
		gs'stat'
		gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('vokzaltorg_strings', 'local_str1')
		act 'Уйти':minut += 1 & gt'vokzalGin'
	end
}
*clr & cla
minut += 30
prodskill = vnesh + dom
if prodskill < 20: prodskill = 20
if prodskill > 150: minimumtov = 3
if prodskill > 100 and prodskill <= 150: minimumtov = 2
if prodskill <= 100: minimumtov = 1
tovarand = RAND(minimumtov,prodskill/10)
if tovarand > tovarL:tovarand = tovarL
tovpay = tovarand * 300
money += tovpay
tovarL -= tovarand
TorgVokzalTimes += 1
dom += 1
gs'stat'
gs 'zz_render', '', 'images/qwest/vokzal/peron.jpg', func('vokzaltorg_strings', 'local_str2')
act 'Уйти':
	*clr & cla
	gs'stat'
	gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('vokzaltorg_strings', 'local_str3')
	if money >= 500:
		act 'Заплатить 500 руб':
			*clr & cla
			money -= 500
			gs'stat'
			gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('vokzaltorg_strings', 'local_str4')
			act 'Уйти':minut += 1 & gt'vokzalGin'
		end
	end
	act 'Уговаривать простить':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('vokzaltorg_strings', 'local_str5')
		if $npc['41,sex'] >= 1:
			if katalkinSexDay+7 >= daystart:
				gs 'zz_render', '', '', func('vokzaltorg_strings', 'local_str6')
				act 'Уйти':minut += 1 & gt'vokzalGin'
			elseif katalkinSexDay+7 < daystart:
				gs 'zz_render', '', '', func('vokzaltorg_strings', 'local_str7')
				act 'Нет, что ты, просто времени нет':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/katalkin.jpg', func('vokzaltorg_strings', 'local_str8')
					act 'Идти в отделение':minut += 5 & katalkinNoexit = 1 & gt'katalkin'
				end
			end
		elseif $npc['41,sex'] = 0:
			schtraf = 500
			gs 'zz_render', '', '', func('vokzaltorg_strings', 'local_str9')
			act 'Идти в отделение':minut += 5 & katalkinNoexit = 1 & gt'katalkin'
		end
	end
	dynamic $d_kachatprava
end