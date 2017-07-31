gs'stat'
gs'time'
if miraingop = 0 and alko < 8:
    *clr & cla
	'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
	'Расположившись в укромном местечке три деревенских пацана, Митька Шкворень, Васян Пакет и Колямба пьют самогонку без всякой закуски. Митька наливает самогонки в стакан и подает вам.'
	act 'Уйти':gt'gadukino'
	act 'Выпить':
		*clr & cla
		minut += 10
		gs 'zz_funcs', 'alko', 4
		gs'stat'
		'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
		'Вы выпили самогонку и внутри все обожгло, задохнувшись вы стали занюхивать рукавом ,так как закуски не было. Митька одобрительно сказал "Хороша зараза, продирает."'
		act 'Отдышаться':gt $curloc
	end
elseif miraingop = 0 and gadriver_gang < 3 and alko >= 8 and (mitkasextimes > 0 or dom <= -10):
	*clr & cla
	if mitkadaybuh ! daystart:
        mitkadaybuh = daystart
		'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
		if mitkasextimes < 13:'Вы напились в хлам, ноги уже практически не держат вас. Митька, заметив ваше состояние, удерживает вас за талию. "Ну чо, <<$name[2]>>, пойдем ебаться?"'
		if mitkasextimes >= 13:'Вы напились в хлам, ноги уже практически не держат вас. Один из пацанов, заметив ваше состояние, требовательно предлагает вам перепихнуться.'
		if mitkasextimes < 3:
			act 'Нечленораздельно мычать':
				*clr & cla
				minut += 15
				if mitkasex = 0:mitkasex = 1 & guy += 1
				$boy = 'Митька'
				silavag = 0
				dick = 16
				pose = 0
				mitkasextimes += 1
				gs'stat'
				if vagina = 0:
					'<center><img src="images/qwest/gadukino/mitkafirst.jpg"></center>'
				else
					'<center><img src="images/qwest/gadukino/mitkasex1.jpg"></center>'
				end
				'Митька отвел вас к своему дому, где, ничуть не церемонясь, начал быстро вас раздевать.'
				gs 'zz_dynamic_sex', 'sex_start'
				gs 'zz_dynamic_sex', 'vaginal', 'dick'
				gs 'zz_dynamic_sex', 'sex_cum'
				'Митяй, лег на бок и закурил. "Охуенно!"'
				act 'Уйти':gt'gadukino'
			end
		end
		if mitkasextimes >= 3 and mitkasextimes < 10:
			temp = RAND(0,5)
			if temp < 3:
				act 'Нечленораздельно мычать':
					*clr & cla
					minut += 15
					if mitkasex = 0:mitkasex = 1 & guy += 1
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					mitkasextimes += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkasex1.jpg"></center>'
					'Митька отвел вас к своему дому, где, ничуть не церемонясь, начал быстро вас раздевать.'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					'Митяй, лег на бок и закурил. "Охуенно!"'
					act 'Уйти':gt'gadukino'
				end
			end
			if temp >= 3 and temp < 5:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					temp = RAND(0,5)
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBj.jpg"></center>'
					'Митька отвел вас к своему дому, где требовательно начал давить вам на плечи, опуская на колени...'
					gs 'zz_dynamic_sex', 'bj'
					if temp < 3:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							mitkasextimes += 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Уйти':gt'gadukino'
						end
					elseif temp >= 3 and temp < 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'face'
							mitkasextimes += 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjCum1.jpg"></center>'
							'Вы не успеваете взять Митькин член в рот и он начинает кончать вам на губы, пока вы пьяно пытаетесь сообразить, что только что произошло...'
							act 'Уйти':gt'gadukino'
						end
					elseif temp = 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'face'
							mitkasextimes += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjCum2.jpg"></center>'
							'Вы пытаетесь взять Митькин член в рот, но он грубо хватает вас за волосы и отводит голову назад, тем самым начиная извергаться вам на лицо...'
							act 'Уйти':gt'gadukino'
						end
					end
				end
			end
			if temp = 5:
				act 'Нечленораздельно мычать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					gs 'zz_funcs', 'cum', 'anus'
					anus += 1
					if anus < 10:dom -= 1
					mitkasextimes += 1
					gs'stat'
					if anus < 10:
						'<center><img src="images/qwest/gadukino/mitkaanal.jpg"></center>'
					else
						'<center><img src="images/qwest/gadukino/mitkaanal1.jpg"></center>'
					end
					'Митька отвел вас к своему дому, где, ничуть не церемонясь, начал быстро вас раздевать.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
					act 'Уйти':gt'gadukino'
				end
			end
		end
		if mitkasextimes = 10:
			act 'Нечленораздельно мычать':
				*clr & cla
				minut += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/mitkabuh_group/drunkgirl1.jpg"></center>'
				' - Гы-гы, - внезапно развеселился Митька. - Но бля, что-то влом мне ногами топать, а елдак-то чешется... Слышь, <<$name[2]>>, давай, загибайся прямо тут, чего уж по углам да кустам прятаться, все равно пацаны и так знают, что я тебя трахаю. Вы ведь не против, да? - обернулся он уже к захмелевшим дружбанам.'
				' - Неее, - пьяно протянул Колямба. - Развлекайтесь, чо уж там, а мы пока с Пакетом еще накатим...'
				' - Ну вот и... Ик... Чудно, - заикаясь, самодовольно промычал Митька, - так что давай, <<$name[1]>>... Ик... Нагибайся!'
                if dom < 0:
				    act 'Нагнуться':
					    *clr & cla
					    minut += 15
					    $boy = 'Митька'
					    silavag = 0
					    dick = 16
					    pose = 1
					    dom -= 2
					    mitkasextimes += 1
					    gs'stat'
					    '<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					    'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					    if mesec = 0:
						    gs 'zz_dynamic_sex', 'sex_start'
						    gs 'zz_dynamic_sex', 'vaginal', 'dick'
						    gs 'zz_dynamic_sex', 'sex_cum'
					    else
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
						    gs 'zz_dynamic_sex', 'anal', 'dick'
						    gs 'zz_dynamic_sex', 'anal_cum'
					    end
					    act 'Уйти':gt'gadukino'
				    end
				else
					act 'Протестовать':
						*clr & cla
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
						'Вы пьяно отнекиваетесь и едва удерживаясь на ногах, изо всех сил отпихиваете пристающего Митьку, пока наконец он не сдается и не ведет вас к себе на веранду...'
						act 'Стонать':
							*clr & cla
							minut += 15
							$boy = 'Митька'
							silavag = 0
							dick = 16
							pose = 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaSexNoPublic.jpg"></center>'
							if mesec = 0:
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
							else
								gs 'zz_dynamic_sex', 'anal_start', 'dick'
								gs 'zz_dynamic_sex', 'anal', 'dick'
								gs 'zz_dynamic_sex', 'anal_cum'
							end
							act 'Уйти':gt'gadukino'
						end
					end
				end
			end
		end
		if mitkasextimes = 11:
			temp = RAND(0,5)
			if temp < 5:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			end
			if temp = 5:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					temp = RAND(0,5)
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					if temp < 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							mitkasextimes += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Уйти':gt'gadukino'
						end
					else
						'Вы продолжаете надрачивать и сосать Митькин член, пока неожиданно не чувствуете, как сильные мужские руки приподнимают ваш таз. Вы отвлекаетесь от члена, и пока выясняете, что происходит, Колямба уже успевает оголить ваш зад и теперь грубо пихает в вашу киску свои шершавые мозолистые пальцы.'
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 30
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							mitkasextimes += 1
							dom -= 2
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, чувствуя при этом, как в вашей киске быстро движутся мужские пальцы. Вскоре упругая струя мужской солоноватой спермы начинает заливать вам рот...'
							act 'Уйти':gt'gadukino'
						end
					end
				end
			end
		end
		if mitkasextimes = 12:
			temp = RAND(0,5)
			if temp < 4:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			else
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					temp = RAND(0,5)
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					if temp < 4:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Уйти':gt'gadukino'
						end
					else
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма. Едва вы облизали его член и заправили в штаны, как к вам подошли Колямба с Васяном. Первый выжидательным горящим от возбуждения взглядом посмотрел на Митьку, а когда тут равнодушно махнул рукой, тут же подошел к вам и расстегнул ширинку. Через пару секунд его примеру, не теряя даром времени, последовал и Васян...'
							act 'Сосать':
								*clr & cla
								minut += 15
								horny += 30
								gs 'zz_funcs', 'cum', 'face'
								guy += 2
								gang += 1
								dom -= 2
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
								'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
								$boy = 'Васян'
					            silavag = 0
					            dick = 14
								gs 'zz_dynamic_sex', 'bj'
								$boy = 'Колямба'
					            silavag = 0
					            dick = 15
								gs 'zz_dynamic_sex', 'bj'
								'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			end
		end
		if mitkasextimes = 13:
			temp = RAND(0,5)
			if temp < 3:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 3:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						horny += 10
						gs 'zz_funcs', 'cum', 'lip'
						swallow += 1
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
						'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 4:
				act 'Сосать':
					*clr & cla
					bj += 1
					minut += 15
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
					'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 5:
				act 'Сесть на лавку':
					*clr & cla
					horny += 20
					minut += 5
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGroup.jpg"></center>'
					'Вы плюхаетесь на лавочку и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						minut += 10
						gang += 1
						mitkasextimes += 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
						'Вы раздеваетесь и ложитесь на деревянную лавочку...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 16
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGroupCum1.jpg"></center>'
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
								act 'Сосать':
									*clr & cla
									$boy = 'Васян'
									horny += 15
									minut += 5
									dick = 14
									gs 'zz_funcs', 'cum', 'lip'
									bj += 1
									gs'stat'
									'<center><img src="images/qwest/gadukino/MitkaGroupCum2.jpg"></center>'
                                    gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			end
		end
		if mitkasextimes = 14:
			temp = RAND(0,5)
			if temp < 2:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						swallow += 1
						horny += 10
						gs 'zz_funcs', 'cum', 'lip'
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
						'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 2:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 3:
				act 'Сосать':
					*clr & cla
					minut += 15
					pose = 0
					bj += 1
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
					'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
					$boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
					'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 4:
				act 'Сесть на лавку':
					*clr & cla
					horny += 20
					minut += 5
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGroup.jpg"></center>'
					'Вы плюхаетесь на лавочку и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						gang += 1
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
						'Вы раздеваетесь и ложитесь на деревянную лавочку...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 16
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGroupCum1.jpg"></center>'
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
								act 'Сосать':
									*clr & cla
									$boy = 'Васян'
									horny += 15
									minut += 5
									dick = 14
									gs 'zz_funcs', 'cum', 'lip'
									bj += 1
									gs'stat'
									'<center><img src="images/qwest/gadukino/MitkaGroupCum2.jpg"></center>'
									gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			elseif temp = 5:
				act 'Нечленораздельно мычать':
					*clr & cla
					temp = RAND(0,5)
					minut += 15
					$boy = 'Колямба'
					silavag = 0
					pose = 1
					dom -= 2
					if anus < 10:dom -= 1
					mitkasextimes += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
					'Васян с Колямбой отвели вас к Васяну в летнюю кухню, где быстро начали снимать с вас одежду...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								horny += 15
								minut += 5
								dick = 15
								gs 'zz_funcs', 'cum', 'lip'
								bj += 1
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Колямба и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					else
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							anus += 1
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Васян'
								horny += 15
								minut += 5
								dick = 14
								bj += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			end
		end
		if mitkasextimes >= 15:
			temp = RAND(0,5)
			if temp = 0:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						horny += 10
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
						'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 1:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 2:
				act 'Сосать':
					*clr & cla
					minut += 15
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					bj += 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
					'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
				    $boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 3:
				act 'Сесть на лавку':
					*clr & cla
					horny += 20
					minut += 5
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGroup.jpg"></center>'
					'Вы плюхаетесь на лавочку и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						gang += 1
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
						'Вы раздеваетесь и ложитесь на деревянную лавочку...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 16
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGroupCum1.jpg"></center>'
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
								act 'Сосать':
									*clr & cla
									bj += 1
									$boy = 'Васян'
									horny += 15
									minut += 5
									dick = 14
									gs 'zz_funcs', 'cum', 'lip'
									gs'stat'
									'<center><img src="images/qwest/gadukino/MitkaGroupCum2.jpg"></center>'
									gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			elseif temp = 4:
				act 'Нечленораздельно мычать':
					*clr & cla
					temp = RAND(0,5)
					minut += 15
					$boy = 'Колямба'
					silavag = 0
					dom -= 1
					pose = 1
					if anus < 10:dom -= 1
					if mitkasextimes < 20:mitkasextimes += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
					'Васян с Колямбой отвели вас к Васяну в летнюю кухню, где быстро начали снимать с вас одежду...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								horny += 15
								bj += 1
								minut += 5
								dick = 15
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					else
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							anus += 1
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Васян'
								horny += 15
								minut += 5
								dick = 14
								bj += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			elseif temp = 5:
				act 'Встать в позу':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 2
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
					'Вы с ногами залезаете на лавку и послушно встаете на четвереньки. Пацаны тут же, пьяно переговариваясь между собой о каких-то своих делах, начинают вас раздевать и пристраиваться к вашим дырочкам...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								horny += 15
								minut += 5
								bj += 1
								dick = 15
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					else
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							anus += 1
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Васян'
								horny += 15
								minut += 5
								dick = 14
								bj += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			end
		end
	else
		'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
		if mirasextimes < 12:
			'Пацаны болтают о чем-то своем, не обращая на вас совершенно никакого внимания.'
		else
			' - Чо, <<$name[2]>>, опять на палку чая пришла? Ха-ха! Не стоит уже, извиняй, найди кого-нибудь другого, что ли... Ха-ха-ха...'
		end
		act 'Уйти':gt'gadukino'
	end
elseif miraingop = 0 and alko >= 8 and mitkasextimes = 0 and dom > -10 or gadriver_gang >= 3:
    *clr & cla
	'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
	'Вы напились в хлам, ноги уже практически не держат вас. Митька, заметив ваше состояние, удерживает вас за талию. Кажется, с вас уже хватит...'
	act 'Уйти':gt'gadukino'
end
if miraingop = 1 and miragopQW > 0:
    *clr & cla
	'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
	'Расположившись в укромном местечке, три деревенских пацана - Митька Шкворень, Васян Пакет и Колямба - пьют самогонку без всякой закуски. Вы с Мирославой подходите к ним и спрашиваете, можно ли к ним присоединиться. Парни тут же оживляются и активно кивают вам головами. Митька тут же начинает разливать самогон в стаканы, после чего подает один из них вам, сообщая, что так, как стаканов не всех не хватает, то вам придется пить из одного на двоих по очереди.'
	if alko >= 8 and gadriver_gang < 3 and (miragopQW > 10 or mitkasextimes > 0):
		*clr & cla
		'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
		'Вы напились в хлам, ноги уже практически не держат вас. Митька, заметив ваше состояние, удерживает вас за талию. "Ну чо, <<$name[2]>>, пойдем ебаться?"'
		if mitkasextimes < 10:
			temp = RAND(0,5)
			if temp < 3:
				act 'Нечленораздельно мычать':
					*clr & cla
					minut += 15
					if mitkasex = 0:mitkasex = 1 & guy += 1
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					mitkasextimes += 1
					gs'stat'
				    if vagina = 0:
					    '<center><img src="images/qwest/gadukino/mitkafirst.jpg"></center>'
				    else
					    '<center><img src="images/qwest/gadukino/mitkasex1.jpg"></center>'
				    end
					'Митька отвел вас к своему дому, где, ничуть не церемонясь, начал быстро вас раздевать.'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					'Митяй, лег на бок и закурил. "Охуенно!"'
					act 'Уйти':gt'gadukino'
				end
			end
			if temp >= 3 and temp < 5:
				act 'Сосать':
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
					'<center><img src="images/qwest/gadukino/MitkaBj.jpg"></center>'
					'Митька отвел вас к своему дому, где требовательно начал давить вам на плечи, опуская на колени...'
					gs 'zz_dynamic_sex', 'bj'
					if temp < 3:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							mitkasextimes += 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Уйти':gt'gadukino'
						end
					elseif temp >= 3 and temp < 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'face'
							mitkasextimes += 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjCum1.jpg"></center>'
							'Вы не успеваете взять Митькин член в рот и он начинает кончать вам на губы, пока вы пьяно пытаетесь сообразить, что только что произошло...'
							act 'Уйти':gt'gadukino'
						end
					elseif temp = 5:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'face'
							mitkasextimes += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjCum2.jpg"></center>'
							'Вы пытаетесь взять Митькин член в рот, но он грубо хватает вас за волосы и отводит голову назад, тем самым начиная извергаться вам на лицо...'
							act 'Уйти':gt'gadukino'
						end
					end
				end
			end
			if temp = 5:
				act 'Нечленораздельно мычать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					if mitkasex = 0:mitkasex = 1 & guy += 1
					silavag = 0
					dick = 16
					pose = 0
					gs 'zz_funcs', 'cum', 'anus'
					anus += 1
					if anus < 10:dom -= 1
					mitkasextimes += 1
					gs'stat'
					if anus < 10:
						'<center><img src="images/qwest/gadukino/mitkaanal.jpg"></center>'
					else
						'<center><img src="images/qwest/gadukino/mitkaanal1.jpg"></center>'
					end
					'Митька отвел вас к своему дому, где, ничуть не церемонясь, начал быстро вас раздевать.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
					act 'Уйти':gt'gadukino'
				end
			end
		end
		if mitkasextimes = 10:
			act 'Нечленораздельно мычать':
				*clr & cla
				minut += 5
				gs'stat'
				'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
				' - Гы-гы, - внезапно развеселился Митька. - Но бля, что-то влом мне ногами топать, а елдак-то чешется... Слышь, <<$name[2]>>, давай, загибайся прямо тут, чего уж по углам да кустам прятаться, все равно пацаны и так знают, что я тебя трахаю. Вы ведь не против, да? - обернулся он уже к захмелевшим дружбанам.'
				' - Неее, - пьяно протянул Колямба. - Развлекайтесь, чо уж там, а мы пока с Пакетом еще накатим...'
				' - Ну вот и... Ик... Чудно, - заикаясь, самодовольно промычал Митька, - так что давай, <<$name[1]>>... Ик... Нагибайся!'
                if dom < 0:
				    act 'Нагнуться':
					    *clr & cla
					    minut += 15
					    $boy = 'Митька'
					    silavag = 0
					    dick = 16
					    pose = 1
					    dom -= 2
					    mitkasextimes += 1
					    gs'stat'
					    '<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					    'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					    if mesec = 0:
						    gs 'zz_dynamic_sex', 'sex_start'
						    gs 'zz_dynamic_sex', 'vaginal', 'dick'
						    gs 'zz_dynamic_sex', 'sex_cum'
					    else
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
						    gs 'zz_dynamic_sex', 'anal', 'dick'
						    gs 'zz_dynamic_sex', 'anal_cum'
					    end
					    act 'Уйти':gt'gadukino'
				    end
				else
					act 'Протестовать':
						*clr & cla
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
						'Вы пьяно отнекиваетесь и едва удерживаясь на ногах, изо всех сил отпихиваете пристающего Митьку, пока наконец он не сдается и не ведет вас к себе на веранду...'
						act 'Стонать':
							*clr & cla
							minut += 15
							$boy = 'Митька'
							silavag = 0
							dick = 16
							pose = 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaSexNoPublic.jpg"></center>'
							if mesec = 0:
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
							else
								gs 'zz_dynamic_sex', 'anal_start', 'dick'
								gs 'zz_dynamic_sex', 'anal', 'dick'
								gs 'zz_dynamic_sex', 'anal_cum'
							end
							act 'Уйти':gt'gadukino'
						end
					end
				end
			end
		end
		if mitkasextimes = 11:
			temp = RAND(1,3)
			if temp < 3:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			end
			if temp = 3:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					temp = RAND(1,2)
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					if temp = 1:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Уйти':gt'gadukino'
						end
					else
						'Вы продолжаете надрачивать и сосать Митькин член, пока неожиданно не чувствуете, как сильные мужские руки приподнимают ваш таз. Вы отвлекаетесь от члена, и пока выясняете, что происходит, Колямба уже успевает оголить ваш зад и теперь грубо пихает в вашу киску свои шершавые мозолистые пальцы.'
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 30
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							dom -= 2
							mitkasextimes += 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, чувствуя при этом, как в вашей киске быстро движутся мужские пальцы. Вскоре упругая струя мужской солоноватой спермы начинает заливать вам рот...'
							act 'Уйти':gt'gadukino'
						end
					end
				end
			end
		end
		if mitkasextimes = 12:
			temp = RAND(1,3)
			if temp < 3:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			else
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					temp = RAND(1,2)
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					if temp = 1:
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							swallow += 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Уйти':gt'gadukino'
						end
					else
						act 'Глотать':
							*clr & cla
							minut += 10
							horny += 10
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
							'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма. Едва вы облизали его член и заправили в штаны, как к вам подошли Колямба с Васяном. Первый выжидательным горящим от возбуждения взглядом посмотрел на Митьку, а когда тут равнодушно махнул рукой, тут же подошел к вам и расстегнул ширинку. Через пару секунд его примеру, не теряя даром времени, последовал и Васян...'
							act 'Сосать':
								*clr & cla
								minut += 15
								horny += 30
								gs 'zz_funcs', 'cum', 'face'
								guy += 2
								gang += 1
								mitkasextimes += 1
								dom -= 2
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
								'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
								$boy = 'Васян'
					            silavag = 0
					            dick = 14
								gs 'zz_dynamic_sex', 'bj'
								$boy = 'Колямба'
					            silavag = 0
					            dick = 15
								gs 'zz_dynamic_sex', 'bj'
								'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			end
		end
		if mitkasextimes = 13:
			temp = RAND(1,4)
			if temp = 1:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 2:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						horny += 10
						gs 'zz_funcs', 'cum', 'lip'
						swallow += 1
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
						'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 3:
				act 'Сосать':
					*clr & cla
					bj += 1
					minut += 15
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
					'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 4:
				act 'Сесть на лавку':
					*clr & cla
					horny += 20
					minut += 5
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGroup.jpg"></center>'
					'Вы плюхаетесь на лавочку и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						minut += 10
						gang += 1
						mitkasextimes += 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
						'Вы раздеваетесь и ложитесь на деревянную лавочку...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 16
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGroupCum1.jpg"></center>'
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
								act 'Сосать':
									*clr & cla
									$boy = 'Васян'
									horny += 15
									minut += 5
									dick = 14
									gs 'zz_funcs', 'cum', 'lip'
									bj += 1
									gs'stat'
									'<center><img src="images/qwest/gadukino/MitkaGroupCum2.jpg"></center>'
									gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			end
		end
		if mitkasextimes = 14:
			temp = RAND(1,5)
			if temp = 1:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						swallow += 1
						horny += 10
						gs 'zz_funcs', 'cum', 'lip'
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
						'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 2:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 3:
				act 'Сосать':
					*clr & cla
					minut += 15
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					dom -= 1
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
					'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 4:
				act 'Сесть на лавку':
					*clr & cla
					horny += 20
					minut += 5
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGroup.jpg"></center>'
					'Вы плюхаетесь на лавочку и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						gang += 1
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
						'Вы раздеваетесь и ложитесь на деревянную лавочку...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 16
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGroupCum1.jpg"></center>'
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
								act 'Сосать':
									*clr & cla
									$boy = 'Васян'
									horny += 15
									minut += 5
									dick = 14
									gs 'zz_funcs', 'cum', 'lip'
									bj += 1
									gs'stat'
									'<center><img src="images/qwest/gadukino/MitkaGroupCum2.jpg"></center>'
									gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			elseif temp = 5:
				act 'Нечленораздельно мычать':
					*clr & cla
					temp = RAND(0,5)
					minut += 15
					$boy = 'Колямба'
					silavag = 0
					pose = 1
					dom -= 2
					if anus < 10:dom -= 1
					mitkasextimes += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
					'Васян с Колямбой отвели вас к Васяну в летнюю кухню, где быстро начали снимать с вас одежду...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								horny += 15
								minut += 5
								dick = 16
								gs 'zz_funcs', 'cum', 'lip'
								bj += 1
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					else
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							anus += 1
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Васян'
								horny += 15
								minut += 5
								dick = 14
								bj += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			end
		end
		if mitkasextimes >= 15:
			temp = RAND(0,5)
			if temp = 0:
				act 'Сосать':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 0
					horny += 10
					bj += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublic.jpg"></center>'
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						horny += 10
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaBjPublicCum.jpg"></center>'
						'Вы покрепче сжимаете Митькин член рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 1:
				act 'Нагнуться':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaSexPublic.jpg"></center>'
					'Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу...'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 2:
				act 'Сосать':
					*clr & cla
					minut += 15
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					bj += 1
					dom -= 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaBjPublicGuys2.jpg"></center>'
					'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать пацанам.'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					'Вскоре они кончают вам на лицо и теряют к вам всякий интерес...'
					act 'Уйти':gt'gadukino'
				end
			elseif temp = 3:
				act 'Сесть на лавку':
					*clr & cla
					horny += 20
					minut += 5
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGroup.jpg"></center>'
					'Вы плюхаетесь на лавочку и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						gang += 1
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
						'Вы раздеваетесь и ложитесь на деревянную лавочку...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGroupCum.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 16
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGroupCum1.jpg"></center>'
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
								act 'Сосать':
									*clr & cla
									bj += 1
									$boy = 'Васян'
									horny += 15
									minut += 5
									dick = 14
									gs 'zz_funcs', 'cum', 'lip'
									gs'stat'
									'<center><img src="images/qwest/gadukino/MitkaGroupCum2.jpg"></center>'
									gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			elseif temp = 4:
				act 'Нечленораздельно мычать':
					*clr & cla
					temp = RAND(0,5)
					minut += 15
					$boy = 'Колямба'
					silavag = 0
					dom -= 1
					pose = 1
					if anus < 10:dom -= 1
					if mitkasextimes < 20:mitkasextimes += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
					'Васян с Колямбой отвели вас к Васяну в летнюю кухню, где быстро начали снимать с вас одежду...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								horny += 15
								bj += 1
								minut += 5
								dick = 15
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					else
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							anus += 1
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Васян'
								horny += 15
								minut += 5
								dick = 14
								bj += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			elseif temp = 5:
				act 'Стать в позу':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 2
					gs'stat'
					'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
					'Вы с ногами залезаете на лавку и послушно встаете на четвереньки. Пацаны тут же, пьяно переговариваясь между собой о каких-то своих делах, начинают вас раздевать и пристраиваться к вашим дырочкам...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								horny += 15
								minut += 5
								bj += 1
								dick = 15
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					else
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							anus += 1
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Сосать':
								*clr & cla
								$boy = 'Васян'
								horny += 15
								minut += 5
								dick = 14
								bj += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs'stat'
								'<center><img src="images/qwest/gadukino/MitkaPublicGuys2.jpg"></center>'
								gs 'zz_dynamic_sex', 'bj'
								'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			end
		end
    elseif miralko >= 8:
		if miragopQW = 5:
			*clr & cla
			minut += 10
			gs 'stat'
			'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
			'Вы уже изрядно пьяны, но помните Мирины слова, а потому все же стараетесь сильно не перебирать. Мирослава все время бросала на вас многозначительные взгляды, а как только они с Митькой распрощались с вами, вы через пару минут прощаетесь с Васяном и Коляндой и идете к Митькиному дому. Не доходя пару до дома пары десятков метров, вы уже слышите их негромкую пьяную болтовню. Пошарив глазами в темноте, вы находите укромное место, с которого вас не было бы видно и устроившись поудобнее, начинаете присматриваться к происходящему на Митькином дворе....'
			act 'Смотреть':
				*clr & cla
				mirasextimes += 1
				miragopQW = 6
				horny += 50
				minut += 10
				gs 'stat'
				'<center><img src="images/qwest/gadukino/Mirawish1_2.jpg"></center>'
				'Пьяная голая Мирослава уже лежала на деревянном столе, прислоненном к забору, а Митька размеренно вколачивал в нее свой член. При каждом его толчке, болезненно кривясь, негромко мычала Мира, то и дело ударясь макушкой о забор, и надрывно скрипели доски. Присмотревшись, вы поняли, что Мира сдержала свое обещание, - член Митьки до самых яиц входил в ее задницу, из которой иногда раздавались странные хлюпанья, на которые, впрочем, никто, кроме вас, не обращал внимания. Громкие шлепки соприкасающихся тел вклинивались в эту животную музыкальную вакханалию двух сношающихся молодых людей, добавляя еще больше пикантности. Митька минут десять долбил в задницу извивающуюся и мычащую Мирославу, пока наконец на всю длинну последним рывком не вогнал в девушку свой член и начал шумно извергаться... Мира в это время пьяным взглядом шарила по окрестностям, наверняка выглядывая вас, но так и не заметила. Через полминуты Митяй вытащил из ее зада свой член и закурив, начал смотреть, как Мира подтирает салфетками сочащуюся из ануса сперму...'
				act 'Уйти':miraingop = 0 & minut += 15 & gt'gadukino'
			end
		else
			*clr & cla
			mirasextimes += 1
			minut += 10
			gs 'stat'
			'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
			'Мирослава напилась в хлам, ноги уже практически не держат ее, поэтому она прислонилась к деревеву и с последних сил пытается не упасть. Она мычит нечто совершенно невразумительное и вряд ли понимает, где она и что вообще вокруг происходит. Да и вы сами тоже не лучше - голова кружится, земля то и дело уходит из-под ног и все, что вам сейчас хочется, это прилечь на мягкую теплую постель. Вы, понимая, что если выпьете еще хотя бы один стакан, то свалитесь прямо здесь, решаете уйти, а потому прощаетесь с собутыльниками и уходите домой.'
		act 'Уйти':miraingop = 0 & gt'gadukino'
		end
	else
		if temp = 0:
			act 'Выпить':
				*clr & cla
				gs 'zz_funcs', 'alko', rand(3,5)
				temp = 2
				gs 'stat'
				'<center><img src="images/qwest/gadukino/drinking.jpg"></center>'
				'Вы берете стакан с самогоном и начинаете, кашляя и кривясь, цедить его сквозь зубы. Мирослава тем временем застенчиво отвечает на нагловатые вопросы деревенской молодежи.'
				act 'Отдышаться':gt $curloc
			end
		end
		if temp = 2:
			act 'Отдать стакан Мирославе':
				*clr & cla
				if gadriver_gang < 3 and (miragopQW > 10 or mitkasextimes > 0):
				    miralko += rand(1,4)
				else
					miralko += RAND(3,4)
				end
				minut += 15
				temp = 1
				mirapiss = RAND(0,10)
				gs 'stat'
				if miragopQW >= 8 and mirapiss <= 2:
					minut += 5
					if miragopQW < 10: miragopQW += 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/MiraPiss.jpg"></center>'
					'Вы отдаете стакан с самогоном Мирославе, но та просит вас пару минут подождать и отходит к ближайшему дереву, где, задрав юбку, начинает справлять нужду. Васян с Коляндой громко ржут и пялятся на ссущую Мирку, а Митька, сцепив зубы, делает равнодушный вид. Сделав свое дело, Мирослава, как ни в чем не бывало, возвращается к компании и выпивает самогон.'
					if miragopQW = 10:
						*clr & cla
						minut += 5
						gs 'stat'
						'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
						'Как только она выпила, подвыпивший Васян, словно в шутку, спрашивает у нее, как она смотрит на то, чтобы прямо здесь и сейчас отсосать у него с Колямбой.'
						if miralko >= 4:
							'Мирослава, уже изрядно подвыпившая, только хихикает в ответ и говорит, что ей нравится это дело. Митька тут же дает подзатыльник Васяну и говорит, чтобы не лез к ней, но тот отвечает, что она уже взрослая девка и может сама за себя ответить. Колямба тем временем уже встал и обнимает кокетничающую Мирославу, а через минуту настойчиво и с силой давит ей на плечи. Мира, пьяно хихикая, наигранно сопротивляется, но уже через пару секунд стает перед Колямбой на колени и словно завороженная смотрит, как тот расстегивает ширинку и приспускает штаны...'
							act 'Смотреть':
								*clr & cla
								horny += RAND(5,10)
								minut += 5
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW10.jpg"></center>'
								'Мирослава, увидев еще не полностью вставший член, тут же нежно заглатывает его до самых яиц и начинает елозить губами по кожице, то втягивая его в себя, то выпуская до самой головки. Колямба блаженно прикрыв глазами, наслаждается Миркиным минетом, Васян в ожидании чешет яйца, а разочарованный Митька предлагает вам накатить еще по одной, но после того, как вы отказываетесь пьет сам.'
								act 'Смотреть':
									*clr & cla
									horny += RAND(10,20)
									minut += 5
									gs 'stat'
									'<center><img src="images/qwest/gadukino/MiraQW10_1.jpg"></center>'
									'Через пару минут Колямба грубо отталкивает присосавшуюся Мирославу от своего члена и начинает кончать ей на лицо. Та, закрыв глаза, пьяно мычит, пытаясь изобразить сексуальность и пальцем размазывает сперму себе по лицу.'
									act 'Смотреть':
										*clr & cla
										horny += RAND(10,25)
										minut += 10
										gs 'stat'
										'<center><img src="images/qwest/gadukino/MiraQW10_2.jpg"></center>'
										' - Ну а теперь моя очередь, - говорит Васян и подходит к Мирославе. Та с энтузиазмом отсасывает и ему, после чего Васян спускает ей на язык.'
										act 'Смотреть':
											*clr & cla
											horny += RAND(10,30)
											minut += 5
											gs 'stat'
											'<center><img src="images/qwest/gadukino/MiraQW10_3.jpg"></center>'
											'Митька, уже успевший добавиться парой стаканов, молча подходит к Мирославе и без предисловий говорит ей, чтобы та стала в позу. Мира, пьяно пошатываясь, послушно поворачивается к нему задницей и рукой отодвигает в сторону трусики, при этом захватив рукой еще и половую губу...'
											act 'Смотреть':
												*clr & cla
												horny += RAND(10,35)
												minut += 10
												miragopQW = 11
												mirasextimes += 3
												gs 'stat'
												'<center><img src="images/qwest/gadukino/MiraQW10_4.jpg"></center>'
												'Но Митька, шлепнув ее по заднице, грубо спускает с нее трусы до самых колен и, приспустив свои штаны, начинает грубо ее трахать. Мира охает и постанывает, иногда стукаясь головой о дерево, о которое оперлась руками, и пытается подмахивать Митьке. Вы тем временем замечаете, как косятся на вас Васян с Колямбой и попрощавшись, решаете уйти от греха подальше...'
												act 'Уйти':miraingop = 0 & minut += 30 & gt'gadukino'
											end
										end
									end
								end
							end
						else
							'Мирослава только хихикает в ответ, а Васян получает от Митьки подзатыльник...'
							act 'Далее':gt $curloc
						end
						exit
					end
					act 'Далее':gt $curloc
				elseif miragopQW >= 11 and mirapiss >= 3 and mirapiss < 6:
					if miralko >= 4:
						minut += 5
						if miragopQW < 30: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/MiraQW11.jpg"></center>'
						' - Ну чо, Мирка, готова поработать своей пизденкой? - раздается среди компашки пьяный требовательный голос.'
						'Та что-то пьяно хихикает в ответ, после чего с готовностью разворачивается к компании спиной и приспустив штаны, подставляет гопоте свою голую задницу.'
						act 'Смотреть':
							*clr & cla
							minut += 5
							gs 'stat'
							if mirapiss = 3:
								horny += RAND(20,50)
								minut += 20
								mirasextimes += 1
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW11_1.jpg"></center>'
								'Колямба недовольно морщится и отводит ее в сторонку, где приказывает ей самой поработать своей пиздой. Там беспрекословно запрыгивает на него сверху и начинает скакать...'
							elseif mirapiss = 4:
								horny += RAND(20,50)
								minut += 20
								mirasextimes += 1
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW11_2.jpg"></center>'
								'Митька одобрительно хмыкает и отводит пьяную Мирославу в сторонку, где и начинает ее бесцеременно трахать...'
							elseif mirapiss = 5:
								horny += RAND(20,50)
								minut += 20
								mirasextimes += 1
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW11_3.jpg"></center>'
								'Васян отводит Миру немного в сторону и приказывает ей снять с себя шмотки, после чего, совершенно голую, начинает долбитьее своим членом...'
							end
							act 'Уйти':miraingop = 0 & minut += 10 & gt'gadukino'
						end
					else
						minut += 5
						if miragopQW < 20: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/MiraQW11_4.jpg"></center>'
						' - Ну чо, Мирка, пососешь у пацанов? - раздается среди компашки пьяный требовательный голос.'
						'Та, краснея, кивает головой и покорно присаживается прямо там, где и стояла.'
						act 'Смотреть':
							*clr & cla
							minut += 5
							mirasextimes += 3
							gs 'stat'
							if mirapiss = 3:
								horny += RAND(20,35)
								minut += 20
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW11_5.jpg"></center>'
								'Пацаны тут же совершенно забыв о вас, обступают Мирославу и та начинает по очереди у всех отсасывать, громкая чавкая губами...'
							elseif mirapiss = 4:
								horny += RAND(20,35)
								minut += 20
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW11_6.jpg"></center>'
								'Пацаны тут же совершенно забыв о вас, обступают Мирославу и по очереди начинают грубо трахать ее в рот. Она постоянно мычит и давится, но те не обращают на это совершенно никакого внимания, продолжая насаживать ее голову на свой член...'
							elseif mirapiss = 5:
								horny += RAND(20,35)
								minut += 20
								gs 'stat'
								'<center><img src="images/qwest/gadukino/MiraQW11_7.jpg"></center>'
								'Пацаны тут же совершенно забыв о вас, обступают Мирославу и та по очереди начинают у всех старательно отсасывать, одновременно надрачивая член рукой...'
							end
							act 'Уйти':miraingop = 0 & minut += 10 & gt'gadukino'
						end
					end
				elseif miragopQW >= 15 and mirapiss = 6:
					if miralko >= 4:
						minut += 5
						if miragopQW < 25: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
						' - Ну чо, Мирка, покажешь нам шоу? - гогочет Колямба. - Покажи нам, как ты надрачиваешь свои дырки...'
						'Мирослава утвердительно мычит в ответ, после чего раздевается, стает на четвереньки и оттопырив задницу в сторону компании, начинает трахать себя пальцами в обе дырочки...'
						act 'Смотреть':
							*clr & cla
							minut += 5
							gs 'stat'
							'<center><img src="images/qwest/gadukino/MiraQW15.jpg"></center>'
							'Мирослава пьяно постанывает и протяжно стонет, неуклюже засовывая пальцы себе в дырочки. Васян дурашливо спрашивает у вас, смогли бы вы тоже так, но вы только презрительно хмыкаете в ответ и он тут же остает - Мира наконец доводит себя до первого оргазма.'
							act 'Далее':gt $curloc
						end
					else
						minut += 5
						if miragopQW < 25: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/drunkgirl.jpg"></center>'
						' - Ну чо, Мирка, покажешь нам шоу? - гогочет Колямба. - Покажи нам, как ты надрачиваешь свои дырки...'
						'Мирослава отрицательно мотает головой, отчего гопники тут же набычиваются и начинают наезжать на Мирославу. Та отказывается выполнять их требование и предлагает найти какой-нибудь компромисс и они сходятся на том, что она просто разденется догола и немного поползает перед ними на четвереньках, изображая собаку...'
						act 'Смотреть':
							*clr & cla
							horny += RAND(25,50)
							minut += 5
							gs 'stat'
							'<center><img src="images/qwest/gadukino/MiraQW15_1.jpg"></center>'
							'Мирослава снимает с себя всю одежду и следующие пятнадцать минут на четвереньках ползает по земле, при этом постоянно вертя головой по сторонам, не идет ли кто. Но вокруг густые заросли и деревья, к тому же в деревне людей очень мало, да и темнеет уже, поэтому все обоходится благополучно...'
							act 'Далее':gt $curloc
						end
					end
				else
					'<center><img src="images/qwest/gadukino/drinking.jpg"></center>'
					'Вы отдаете стакан с самогоном Мирославе и та, немного помедлив, начинает, кашляя и кривясь, цедить его сквозь зубы. Вы тем временем оживленно разговариваете с деревенскими.'
					act 'Далее':gt $curloc
				end
			end
		end
		if temp = 1:
			act 'Выпить самой':
				*clr & cla
				gs 'zz_funcs', 'alko', rand(3,5)
				temp = 2
				gs 'stat'
				'<center><img src="images/qwest/gadukino/drinking.jpg"></center>'
				'Вы берете стакан с самогоном и начинаете, кашляя и кривясь, цедить его сквозь зубы. Мирослава тем временем застенчиво отвечает на нагловатые вопросы деревенской молодежи.'
				act 'Отдышаться':gt $curloc
			end
		end
	end
end