minut += 30
gs 'stat'
if volltime = 0:
	gs 'zz_render', '', '', func('volley_strings', 'local_str1')
	if volleysostav = 1:
		gs 'zz_render', '', 'images/pavlovo/dk/volley/game3.jpg', 'Вы сидите на скамейке запасных смотря как ваша команда играет.'
	end
	if volleysostav = 2:
		gs 'zz_render', '', 'images/pavlovo/dk/volley/game4.jpg', func('volley_strings', 'local_str2')
		poverkomand -= 100
		poverkomand += volleyboll
	end
	poverkomandV = RAND(500,1500)
	if poverkomand > poverkomandV:
		volpoint += 1
		gs 'zz_render', '', '', func('volley_strings', 'local_str3')
	elseif poverkomand = poverkomandV:
		volpoint += 1
		volpointv += 1
		gs 'zz_render', '', '', func('volley_strings', 'local_str4')
	else
		volpointv += 1
		gs 'zz_render', '', '', func('volley_strings', 'local_str5')
	end
	act 'Далее':volltime = 1 & gt $curloc
elseif volltime = 1:
	gs 'zz_render', '', '', func('volley_strings', 'local_str6')
	if poverkomand > poverkomandV:
		gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener6.jpg', func('volley_strings', 'local_str7')
	elseif poverkomand = poverkomandV:
		gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener1.jpg', func('volley_strings', 'local_str8')
	else
		gs 'zz_render', '', 'images/pavlovo/dk/volley/Tren/VolleyTrener2.jpg', func('volley_strings', 'local_str9')
	end
	if volleysostav = 1:
		gs 'zz_render', '', '', func('volley_strings', 'local_str10')
		act 'Проситься поиграть':
			*clr & cla
			if $npc['28,relation'] >= RAND(0,80) + seealko:
				seealko = 0
				volleysostav = 2
				dom += 1
				poverkomand -= 100
				poverkomand += volleyboll
				gs 'zz_render', '', '', func('volley_strings', 'local_str11')
				act 'Далее': volltime = 2 & gt $curloc
			else
				gs 'zz_render', '', '', func('volley_strings', 'local_str12')
				act 'Далее': volltime = 2 & gt $curloc
			end
		end
	end
	act 'Далее':volltime = 2 & gt $curloc
elseif volltime = 2:
	*clr & cla
	gs 'zz_render', '', 'images/pavlovo/dk/volley/game5.jpg', func('volley_strings', 'local_str13')
	if volleysostav = 1:
		gs 'zz_render', '', '', func('volley_strings', 'local_str14')
	end
	if poverkomand > poverkomandV:
		volpoint += 1
		gs 'zz_render', '', '', func('volley_strings', 'local_str15')
		if volleysostav = 2 and volpointv > 0: gs 'npc_editor','change_rep','+', 28
	elseif poverkomand = poverkomandV:
		volpoint += 1
		volpointv += 1
		gs 'zz_render', '', '', func('volley_strings', 'local_str16')
		if volleysostav = 2 and volpointv > 0: gs 'npc_editor','change_rep','+', 28
	else
		volpointv += 1
		gs 'zz_render', '', '', func('volley_strings', 'local_str17')
		if volleysostav = 2 and volpoint > 0: gs 'npc_editor','change_rep','-', 28
	end
	act 'Далее':volltime = 3 & gt $curloc
elseif volltime = 3:
	*clr & cla
	volsesongame += 1
	gs 'zz_render', '', '', func('volley_strings', 'local_str18')
	if volpoint > volpointv:
		volsesonwin += 1
		*clr
		gs 'zz_render', '', 'images/pavlovo/dk/volley/game6.jpg', func('volley_strings', 'local_str19')
	elseif volpoint = volpointv:
		volsesondraw += 1
		*clr
		gs 'zz_render', '', 'images/pavlovo/dk/volley/game7.jpg', func('volley_strings', 'local_str20')
	else
		volsesonloss += 1
		*clr
		gs 'zz_render', '', 'images/pavlovo/dk/volley/game8.jpg', func('volley_strings', 'local_str21')
	end
	if volleysostav = 2:volleysostav = 1 & poverkomand -= volleyboll & poverkomand += 110
	volpoint = 0
	volpointv = 0
	if trener_Speak=>9:volleysostav = 2
	act 'Уйти':gt'gdksport'
	act 'Зайти в тренерскую':gt'Voltrener'
end