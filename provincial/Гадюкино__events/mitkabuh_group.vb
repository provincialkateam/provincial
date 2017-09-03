gs'stat'
gs'time'
if miraingop = 1 and miragopQW > 0:
	'<center><img src="images/gadukino/mitka/3boys.2.jpg"></center>'
	'Расположившись в укромном местечке, три деревенских пацана - Митька Шкворень, Васян Пакет и Колямба - пьют самогонку без всякой закуски. Вы с Мирославой подходите к ним и спрашиваете, можно ли к ним присоединиться. Парни тут же оживляются и активно кивают вам головами. Митька тут же начинает разливать самогон в стаканы, после чего подает один из них вам, сообщая, что так, как стаканов не всех не хватает, то вам придется пить из одного на двоих по очереди.'
	if alko >= 8:
		*clr & cla
		'<center><img src="images/qwest/gadukino/mitkabuh_group/drunkgirl1.jpg"></center>'
		'Вы напились в хлам, ноги уже практически не держат вас. Пацаны, заметив ваше состояние, тут же хватают вас с Мирой под руки и ведут домой к Митяю.'
		if mitkasextimes >= 15:
			temp = RAND(0,5)
			if temp = 0:
				act 'Сосать':
					*clr & cla
					$boy = 'Пацан'
					minut += 10
					horny += 10
					bj += 1
					if miragopQW < 20: miragopQW += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOral0.'+rand(1,8)+'.jpg"></center>'
					'Пацаны раздевают вас с Мирой и начинают ебать в рот по очереди, вместе, раздельно, насколько у них хватало фантазии'
					$boy = 'Митька'
					silavag = 0
					dick = 16
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Васян'
					silavag = 0
					dick = 14
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Колямба'
					silavag = 0
					dick = 15
					gs 'zz_dynamic_sex', 'bj'
					act 'Глотать':
						*clr & cla
						minut += 10
						horny += 10
						swallow += 3
						gs 'zz_funcs', 'cum', 'lip'
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(1,5)+'.jpg"></center>'
						'Парни быстро насытились и начали кончать вам с Мирой на лица'
						act 'Уйти':gt'gadukino'
					end
				end
			elseif temp = 1:
				act 'Отдаться Митьке':
					*clr & cla
					minut += 15
					$boy = 'Митька'
					silavag = 0
					dick = 16
					pose = 1
					dom -= 1
					if miragopQW < 30: miragopQW += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup1.'+rand(1,5)+'.jpg"></center>'
					'Вас с Миркой быстро раздели и начали грубо трахать по очереди.'
					if mesec = 0:
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
					else
						gs 'zz_dynamic_sex', 'anal_start', 'dick'
						gs 'zz_dynamic_sex', 'anal', 'dick'
						gs 'zz_dynamic_sex', 'anal_cum'
					end
					act 'Отдаться Колямбе':
						*clr & cla
						minut += 15
						$boy = 'Колямба'
						silavag = 0
						dick = 15
						pose = 1
						dom -= 1
						gs'stat'
						'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup1.'+rand(1,5)+'.jpg"></center>'
						if mesec = 0:
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
						else
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
						end
						act 'Отдаться Васяну':
							*clr & cla
							minut += 15
							$boy = 'Васян'
							silavag = 0
							dick = 14
							pose = 1
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup1.'+rand(1,5)+'.jpg"></center>'
							if mesec = 0:
								gs 'zz_dynamic_sex', 'sex_start'
								gs 'zz_dynamic_sex', 'vaginal', 'dick'
								gs 'zz_dynamic_sex', 'sex_cum'
							else
								gs 'zz_dynamic_sex', 'anal_start', 'dick'
								gs 'zz_dynamic_sex', 'anal', 'dick'
								gs 'zz_dynamic_sex', 'anal_cum'
							end
							act 'Глотать':
								*clr & cla
								minut += 10
								horny += 10
								swallow += 3
								gs 'zz_funcs', 'cum', 'lip'
								dom -= 1
								gs'stat'
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(1,5)+'.jpg"></center>'
								'Под конец они поставили вас с Миркой на колени и начали кончать вам на лица'
								act 'Уйти':gt'gadukino'
							end
						end
					end
				end
			elseif temp = 2:
				act 'Сосать':
					*clr & cla
					$boy = 'Парень'
					minut += 15
					horny += 30
					gs 'zz_funcs', 'cum', 'face'
					bj += 1
					dom -= 1
					if miragopQW < 20: miragopQW += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh1.'+rand(1,5)+'.jpg"></center>'
					'Вас не раздевая поставили на колени перед вставшими членами и вы по одному стали их обслуживать.'
					$boy = 'Митька'
					silavag = 0
					dick = 16
					gs 'zz_dynamic_sex', 'bj'
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
				act 'Плюхнуться на кровать':
					*clr & cla
					horny += 20
					minut += 5
					mitkasextimes += 1
					if miragopQW < 30: miragopQW += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh2.'+rand(3,4)+'.jpg"></center>'
					'Вы плюхаетесь на кровать и пацаны тут же начинают лапать вас и пихать пальцы во все щели.'
					act 'Дать пацанам':
						*clr & cla
						dom -= 2
						horny += 30
						silavag = 0
						pose = 0
						gang += 1
						minut += 10
						gs'stat'
						'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh2.'+rand(1,2)+'.jpg"></center>'
						'Вы не успеваете устроится на кровати, как в рот вам тут же врывается чей-то член...'
						act 'Стонать':
							*clr & cla
							$boy = 'Колямба'
							horny += 10
							minut += 10
							gs 'zz_funcs', 'cum', 'anus'
							dick = 15
							gs'stat'
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhanal0.'+rand(1,5)+'.jpg"></center>'
							gs 'zz_dynamic_sex', 'anal_start', 'dick'
							gs 'zz_dynamic_sex', 'anal', 'dick'
							gs 'zz_dynamic_sex', 'anal_cum'
							act 'Стонать':
								*clr & cla
								$boy = 'Митька'
								horny += 40
								minut += 10
								dick = 14
								gs'stat'
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup0.'+rand(1,5)+'.jpg"></center>'
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
									'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(1,3)+'.jpg"></center>'
									gs 'zz_dynamic_sex', 'bj'
									'Обессиленные, вы слышите, как начинает натужно сопеть Васян и не мешкая, тут же покрепче сжимаете его член и направляете его себе в рот, через секунду ощущая в нем терпкий вкус спермы...'
									act 'Уйти':gt'gadukino'
								end
							end
						end
					end
				end
			elseif temp = 4:
				act 'Идти с пацанами':
					*clr & cla
					temp = RAND(0,5)
					minut += 15
					$boy = 'Колямба'
					silavag = 0
					dom -= 1
					pose = 1
					dom -= 1
					if mitkasextimes < 20:mitkasextimes += 1
					if miragopQW < 30: miragopQW += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup.jpg"></center>'
					'Пацаны махнув на прощание Митяю с Миркой отвели вас к Васяну домой, где быстро начали снимать с вас одежду...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup0.'+rand(1,5)+'.jpg"></center>'
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
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(4,5)+'.jpg"></center>'
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
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhanal0.'+rand(1,5)+'.jpg"></center>'
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
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(4,5)+'.jpg"></center>'
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
					pose = 1
					dom -= 2
					if miragopQW < 30: miragopQW += 1
					gs'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh2.4.jpg"></center>'
					'Вы с Миркой послушно встаете на четвереньки. Пацаны тут же начинают пристраиваться к вашим дырочкам...'
					if temp < 4:
						act 'Стонать':
							*clr & cla
							$boy = 'Васян'
							horny += 50
							minut += 10
							dick = 154
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup1.'+rand(1,5)+'.jpg"></center>'
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
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(4,5)+'.jpg"></center>'
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
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhgroup1.'+rand(1,5)+'.jpg"></center>'
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
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhOralCum0.'+rand(4,5)+'.jpg"></center>'
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
		if temp = 0:
			act 'Выпить':
				*clr & cla
				gs 'zz_funcs', 'alko', rand (3,5)
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
				miralko += rand (1,4)
				minut += 15
				temp = 1
				mirapiss = RAND(0,10)
				gs 'stat'
				if miragopQW >= 15 and mirapiss <= 2:
					*clr & cla
					minut += 5
					if miragopQW < 20: miragopQW += 1
					gs 'stat'
					'<center><img src="images/qwest/gadukino/mitkabuh_group/drunk1.jpg"></center>'
					'Как только она выпила, подвыпивший Васян, словно в шутку, спрашивает у вас обоих, как вы смотрите на то, чтобы прямо здесь и сейчас отсосать.'
					'Мирослава, уже изрядно подвыпившая, только хихикает в ответ, а вы, пожав плечами, согласно киваете головой. Колямба сразу же встал и обнял кокетничающую Мирославу, а Васян подошел к вам. Мира, пьяно хихикая встает перед Колямбой на колени, вы следуете её примеру и смотрите, как Васян неспеша расстегивает ширинку и приспускает штаны...'
					act 'Сосать':
						*clr & cla
						$boy = 'Васян'
						minut += 10
						horny += 10
						bj += 1
						dick = 14
						gs'stat'
						'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh0.'+rand(1,5)+'.jpg"></center>'
						'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать...'
						gs 'zz_dynamic_sex', 'bj'
						act 'Глотать':
							*clr & cla
							minut += 10
							swallow += 1
							horny += 10
							gs 'zz_funcs', 'cum', 'lip'
							dom -= 1
							gs'stat'
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhCum0.'+rand(1,5)+'.jpg"></center>'
							'Вы покрепче сжимаете член Васяна рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
							act 'Сосать':
								*clr & cla
								$boy = 'Колямба'
								minut += 10
								horny += 10
								bj += 1
								dick = 15
								gs'stat'
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh0.'+rand(3,5)+'.jpg"></center>'
								'- Ну а теперь моя очередь, - говорит Колямба и подходит к вам.'
								gs 'zz_dynamic_sex', 'bj'
								act 'Глотать':
									*clr & cla
									minut += 10
									swallow += 1
									horny += 10
									gs 'zz_funcs', 'cum', 'lip'
									dom -= 1
									gs'stat'
									'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhCum0.'+rand(1,5)+'.jpg"></center>'
									'Вы с энтузиазмом отсасываете и ему, после чего <<$boy>> кончает.'
									act 'Нагнуться':
										*clr & cla
										minut += 15
										$boy = 'Митька'
										silavag = 0
										dick = 16
										pose = 1
										dom -= 1
										gs'stat'
										'<center><img src="images/qwest/gadukino/mitkabuh_group/MitkaSexPublic0.'+rand(1,2)+'.jpg"></center>'
										'Митька, уже успевший добавиться парой стаканов, молча подходит к вам и без предисловий говорит, чтобы вы стали в позу. Вы, едва удерживаясь на ногах, подходите к валяющемуся поблизости бревну и облегченно упираетесь в него руками, чувствуя, как сзади подходит Митька и начинает оголять вашу задницу и приспустив свои штаны, начинает грубо вас трахать.'
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
				elseif miragopQW >= 15 and mirapiss >= 3 and mirapiss < 6:
					if miralko >= 4:
						minut += 5
						if miragopQW < 30: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhshow1.jpg"></center>'
						' - Ну чо, девки, готовы поработать своими дырками? - раздается среди компашки пьяный требовательный голос.'
						'Мирка что-то пьяно хихикает в ответ, после вы вдвоем с готовностью разворачиваетесь к компании спиной, подставляя гопоте свои голые задницы.'
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
					else
						minut += 5
						if miragopQW < 20: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/MiraQW11_4.jpg"></center>'
						' - Ну чо, девки, соснете у пацанов? - раздается среди компашки пьяный требовательный голос.'
						'Вы киваете головой и покорно присаживаетесь прямо там, где и стояли, рядом присаживается Мирослава.'
						act 'Сосать':
							*clr & cla
							$boy = 'Васян'
							minut += 10
							horny += 10
							bj += 1
							dick = 14
							gs'stat'
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh0.'+rand(1,5)+'.jpg"></center>'
							'Вы, пьяно чавкая и причмокивая, послушно начинаете отсасывать...'
							gs 'zz_dynamic_sex', 'bj'
							act 'Глотать':
								*clr & cla
								minut += 10
								swallow += 1
								horny += 10
								gs 'zz_funcs', 'cum', 'lip'
								dom -= 1
								dick = 15
								gs'stat'
								'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhCum0.'+rand(1,5)+'.jpg"></center>'
								'Вы покрепче сжимаете член Васяна рукой и не вынимая его изо рта, начинаете яростно надрачивать его, пока, наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
								act 'Сосать':
									*clr & cla
									$boy = 'Колямба'
									minut += 10
									horny += 10
									bj += 1
									gs'stat'
									'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh0.'+rand(1,5)+'.jpg"></center>'
									'Вы причмокивая послушно сосете, изредко косясь на Мирославу.'
									gs 'zz_dynamic_sex', 'bj'
									act 'Глотать':
										*clr & cla
										minut += 10
										swallow += 1
										horny += 10
										gs 'zz_funcs', 'cum', 'lip'
										dom -= 1
										gs'stat'
										'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhCum0.'+rand(1,5)+'.jpg"></center>'
										'Вы быстрее начинаете двигать своей головой, пока наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
										act 'Сосать':
											*clr & cla
											$boy = 'Митька'
											minut += 10
											horny += 10
											bj += 1
											dick = 16
											gs'stat'
											'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuh0.'+rand(1,5)+'.jpg"></center>'
											'Вы устали, но послушно начинаете отсасывать...'
											gs 'zz_dynamic_sex', 'bj'
											act 'Глотать':
												*clr & cla
												minut += 10
												swallow += 1
												horny += 10
												gs 'zz_funcs', 'cum', 'lip'
												dom -= 1
												gs'stat'
												'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhCum0.'+rand(1,5)+'.jpg"></center>'
												'Вы покрепче сжимаете член Митьки губами и наращиваете темп, пока наконец, не чувствуете, как вам в рот начинает извергаться его теплая липкая сперма...'
												act 'Уйти':gt'gadukino'
											end
										end
									end
								end
							end
						end
					end
				elseif miragopQW >= 15 and mirapiss = 6:
					if miralko >= 4:
						minut += 5
						if miragopQW < 30: miragopQW += 1
						if mitkasextimes < 20:mitkasextimes += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/MiraQW15.jpg"></center>'
						' - Ну чо, Мирка, покажешь нам шоу? - гогочет Колямба. - Покажи нам, как ты надрачиваешь свои дырки...'
						'Мирослава утвердительно мычит в ответ, после чего раздевается, стает на четвереньки и оттопырив задницу в сторону компании, начинает трахать себя пальцами в обе дырочки. Мирослава пьяно постанывает и протяжно стонет, неуклюже засовывая пальцы себе в дырочки. Васян смотрит на вас оценивающе и говорит" - <<$name[2]>>, че стала, давай присоеденяйся " - и начинает хохатать. '
						act 'Присоединиться':
							*clr & cla
							minut += 15
							orgasm += 1
							horny = 0
							gs 'stat'
							if anus <= 15:'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhshow2.jpg"></center>'
							if anus > 15:'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhshow2.gif"></center>'
							'Вы пьяно покачиваясь подходите к Мирославе и бухаетесь рядом с ней на колени. Сначала вам неудобно, но возбуждение берёт своё, и вот вы уже стонете, засовывая пальцы себе в дырочки, и наконец доводите себя до первого оргазма.'
							act 'Далее':gt $curloc
						end
					else
						minut += 5
						if miragopQW < 25: miragopQW += 1
						gs 'stat'
						'<center><img src="images/qwest/gadukino/mitkabuh_group/drunk1.0.jpg"></center>'
						' - Ну чо, девчонки, покажете нам шоу? - гогочет Колямба. - Давайте танцы...'
						'Мирослава и вы со смехом скидываете одежду...'
						act 'Танцевать':
							*clr & cla
							horny += RAND(25,50)
							minut += 5
							gs 'stat'
							'<center><img src="images/qwest/gadukino/mitkabuh_group/mitkabuhdance0.'+rand(0,3)+'.jpg"></center>'
							'Вы кружитесь вокруг костранца в танце совершенно голые, вы пьяны, вам весело и интересно...'
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
				gs 'zz_funcs', 'alko', rand (3,5)
				temp = 2
				gs 'stat'
				'<center><img src="images/qwest/gadukino/drinking.jpg"></center>'
				'Вы берете стакан с самогоном и начинаете, кашляя и кривясь, цедить его сквозь зубы. Мирослава тем временем застенчиво отвечает на нагловатые вопросы деревенской молодежи.'
				act 'Отдышаться':gt $curloc
			end
		end
	end
end