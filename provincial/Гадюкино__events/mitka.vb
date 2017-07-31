gs'stat'
'<center><b><font color = maroon>Митька Шкворень</font></b></center>'
'<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
'Деревенский парень едва старше вас, вы его знаете с детства и будучи еще детьми вместе купались на реке.'
if mitka = 0:
	mitkaday = daystart
	' - Ну чо, <<$name[2]>>, если хорошая погода, заходи в восемь вечера, бухнем самогонки, попиздим за жизнь.'
	mitka = 1
else
	mitkaday = daystart
	' - Привет <<$name[2]>>. Как житуха?'
	act 'Нормально':
		*clr & cla
		gs'stat'
		'<center><b><font color = maroon>Митька Шкворень</font></b></center>'
		'<center><img src="images/gadukino/mitka/mitka.jpg"></center>'
		'Вы ответили что у вас все нормально и Митька улыбнувшись предложил:'
		' - Ну чо, <<$name[2]>>, заходи в восемь вечера, бухнем самогонки, попиздим за жизнь."'
		if mitkasextimes > 0 or dom <= -25:
			temp = RAND(0,5)
			'Тут он почесал яйца и добавил с ухмылкой:'
			' - <<$name[2]>>, а пойдем сейчас поебемся, а то стояк заеб.'
			if temp < 3:
				act 'Пойдем':
					*clr & cla
					minut += 15
					if mitkasex = 0:mitkasex = 1 & guy += 1
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					gs'stat'
					if vagina = 0:
						'<center><img src="images/qwest/gadukino/mitkafirst.jpg"></center>'
					else
						'<center><img src="images/qwest/gadukino/mitkasex2.jpg"></center>'
					end
					'Митька отвел вас к своему дому и привел на веранду, там он уложил вас на диване и стал бесцеремонно раздевать.'
					gs 'zz_dynamic_sex', 'sex_start'
					gs 'zz_dynamic_sex', 'vaginal', 'dick'
					gs 'zz_dynamic_sex', 'sex_cum'
					'Митяй лег на бок и закурил "Охуенно!"'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 3 or temp = 4:
				act 'Пойдем':
					*clr & cla
					if mitkasex = 0:mitkasex = 1 & guy += 1
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					temp = RAND(0,5)
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjHome.jpg"></center>'
					'Митька отвел вас к своему дому, где требовательно начал давить вам на плечи, опуская на колени...'
					gs 'zz_dynamic_sex', 'bj'
					if temp < 3:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjHomeCum1.jpg"></center>'
							'Митька крепко хватает руками вас за голову и с силой начинает долбить вас в глотку, пока, наконец, не начинает кончать.'
							act 'Уйти':gt'gadukino'
						end
					elseif temp >= 3 and temp < 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'face'
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjHomeCum2.jpg"></center>'
							'Митька берет член рукой и начинает яростно надрачивать его прямо перед вашим лицом, пока, наконец не покрывает своей липкой теплой спермой.'
							act 'Уйти':gt'gadukino'
						end
					elseif temp = 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							gs'stat'
							if mitkasextimes >= 14:
								'<center><img src="images/qwest/gadukino/MitkaBjHomeCum4.jpg"></center>'
								'Вы засовываете пальцы себе в рот и растягивая ими губы, с силой насаживаетесь головой на кончающий Митькин член.'
							else
								'<center><img src="images/qwest/gadukino/MitkaBjHomeCum3.jpg"></center>'
								'Вы сильнее насаживаетесь головой на Митькин член, а спустя пару мгновений чувствуете, как вам в рот ударяет горячая струя его терпкой спермы.'
							end
							act 'Уйти':gt'gadukino'
						end
					end
				end
			elseif temp = 5:
				act 'Пойдем':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					gs 'zz_funcs', 'cum', 'anus'
					anus += 1
					if anus < 10:dom -= 1
					gs'stat'
					if anus < 10:
						'<center><img src="images/qwest/gadukino/MitkaAnalHome.jpg"></center>'
					elseif anus >= 10 and anus < 25:
						'<center><img src="images/qwest/gadukino/MitkaAnalHome3.jpg"></center>'
					elseif anus >= 25:
						'<center><img src="images/qwest/gadukino/MitkaAnalHome2.jpg"></center>'
					end
					'Митька отвел вас к своему дому, где, ничуть не церемонясь, начал быстро вас раздевать.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
					act 'Уйти':gt'gadukino'
				end
			end
			if mitkasextimes < 11 and alko < 6 and dom > -25:act 'Отказаться':gt'gadukino'
		end
		if mitkasextimes = 0:act 'Уйти':gt'gadukino'
	end
end
if mitkasextimes = 0:act 'Уйти':gt'gadukino'