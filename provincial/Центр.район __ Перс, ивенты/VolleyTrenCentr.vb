minut += 15
gs'stat'
'<center><img src="images/pavlovo/dk/volley/VoltrenerSpeak18.jpg"></center>'
if centr=1:
	gs 'zz_render', '', '', func('VolleyTrenCentr_strings', 'local_str1')
	act 'Здравствуйте':
		cla & *clr
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak11.jpg', func('VolleyTrenCentr_strings', 'local_str2')
		act 'Спрашивать про тренера':
			cla & *clr
			gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak12.jpg', func('VolleyTrenCentr_strings', 'local_str3')
			centr=2
			act 'Отойти':gt 'fit','raz'
		end
	end
elseif centr=2:
	gs 'zz_render', '', '', func('VolleyTrenCentr_strings', 'local_str4')
	act 'Здравствуйте':
		cla & *clr
		gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak13.jpg', func('VolleyTrenCentr_strings', 'local_str5')
		if wine = 1 and alkowine = 0:
			act'Отдать вино':
				cla
				wine = 0
				centr = 3 &! закрываю китайца
				gs 'zz_render', '', '', func('VolleyTrenCentr_strings', 'local_str6')
				act 'Задать вопрос':
					cla & *clr
					gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak15.jpg', func('VolleyTrenCentr_strings', 'local_str7')
					act 'Слушать дальше':
						cla & *clr
						gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak14.jpg', func('VolleyTrenCentr_strings', 'local_str8')
						act 'Слушать дальше':
							cla & *clr
							gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak16.gif', func('VolleyTrenCentr_strings', 'local_str9')
							act 'Удивится':
								cla & *clr
								gs 'zz_render', '', 'images/pavlovo/dk/volley/VoltrenerSpeak17.jpg', func('VolleyTrenCentr_strings', 'local_str10')
				act 'Отойти':gt 'fit','raz'
							end
						end
					end
				end
			end
		else
			gs 'zz_render', '', '', func('VolleyTrenCentr_strings', 'local_str11')
			act 'Отойти':gt 'fit','raz'
		end
	end
 end