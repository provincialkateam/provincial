$qwmeetkatdy = {
	gs 'zz_render', '', '', func('qwmeet2_strings', 'local_str1')
	act 'Очень приятно':
		*clr & cla
		minut += 5
		gs'stat'
		'<center><b><font color = maroon>Николай</font></b></center>'
		gs 'zz_render', '', 'images/qwest/kolan/001.jpg', func('qwmeet2_strings', 'local_str2')
		act 'Очень приятно':
			*clr & cla
			minut += 5
			gs'stat'
			'<center><b><font color = maroon>Изольда</font></b></center>'
			gs 'zz_render', '', 'images/qwest/kolan/izolda.jpg', func('qwmeet2_strings', 'local_str3')
			act 'Очень приятно':
				*clr & cla
				minut += 5
				gs'stat'
				'<center><b><font color = maroon>Виталий</font></b></center>'
				gs 'zz_render', '', 'images/qwest/marafet/001.jpg', func('qwmeet2_strings', 'local_str4')
				act 'Подняться на борт катера':
					*clr & cla
					minut += 5
					gs'stat'
					'<center><b><font color = maroon>Катер</font></b></center>'
					gs 'zz_render', '', 'images/qwest/vladimir/kater.jpg', func('qwmeet2_strings', 'local_str5')
					act 'Идти в каюту вслед за Изольдой':
						*clr & cla
						minut += 5
						gs'stat'
						'<center><b><font color = maroon>Каюта</font></b></center>'
						gs 'zz_render', '', 'images/qwest/kolan/izolda.jpg', func('qwmeet2_strings', 'local_str6')
						act 'Спросить про нее и Николая':
							cla
							minut += 5
							gs'stat'
							gs 'zz_render', '', '', func('qwmeet2_strings', 'local_str7')
							act 'Спросить про Виталия':
								cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', '', func('qwmeet2_strings', 'local_str8')
								act 'Спросить про Славу':
									cla
									minut += 5
									gs'stat'
									gs 'zz_render', '', '', func('qwmeet2_strings', 'local_str9')
									act 'Выйти на палубу с подносом':gt'qwpaluba'
								end
							end
						end
					end
				end
			end
		end
	end
}
$qwslavady = {
	gs 'zz_render', '', '', func('qwmeet2_strings', 'local_str10')
	act 'Поцеловать в щеку':
		*clr & cla
		'<center><b><font color = maroon>Владимир</font></b></center>'
		gs 'zz_render', '', 'images/qwest/vladimir/001.jpg', func('qwmeet2_strings', 'local_str11')
		dynamic $qwmeetkatdy
	end
	act 'Поцеловать в губы':
		*clr & cla
		'<center><b><font color = maroon>Владимир</font></b></center>'
		gs 'zz_render', '', 'images/qwest/vladimir/001.jpg', func('qwmeet2_strings', 'local_str12')
		dynamic $qwmeetkatdy
	end
}
minut += 3
gs'stat'
gs 'zz_render', '', 'images/qwest/kim/001.jpg', func('qwmeet2_strings', 'local_str13')
act 'Сесть рядом с водителем':
	*clr & cla
	minut += 3
	gs'stat'
	gs 'zz_render', '', 'images/qwest/kim/002.jpg', func('qwmeet2_strings', 'local_str14')
	dynamic $qwslavady
end
act 'Сесть на заднее сиденье':
	*clr & cla
	minut += 3
	gs'stat'
	gs 'zz_render', '', 'images/qwest/kim/002.jpg', func('qwmeet2_strings', 'local_str15')
	dynamic $qwslavady
end