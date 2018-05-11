gs 'stat'
!секс после стриптиза если ГГ не шлюха
if hantdancesex = 1:
	*clr & cla
	minut += 5
	gang += 1
	manna = 100
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/dance5.jpg'
	gs 'zz_render','','','Вы устало присели на край стола, чтобы отдохнуть и перекурить.Во время танца вы не обращали на парней внимания,однако когда к вам подошел Игорь, вы поняли, что они все тоже полностью обнажены.'
	gs 'zz_render','','','-Светик, мы требуем продолжения банкета, - сказал он улыбаясь и показав на свой член.'
	act 'Далее':
		*clr & cla
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi.jpg','Алкоголь притупил ваше чувство стыда и вы не сомневаясь взяли член в руку и поднесли ко рту...'
		act 'Сосать':
			*clr & cla
 			minut += 5
			$boy = 'Игорь'
			silavag = 2
			dick = 16
			throat += 1
			bj += 1
			horny += rand(10,20)
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi1.jpg','Вы принялись сосать...'
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_render','','','Вдруг Игорь не дав вам опомнится засадил свой член вам в горло на всю длинну, аж слезы из глаз брызгнули...'
			act 'Сосать дальше':
				*clr & cla
 				minut += 5
				$boy = 'Игорь'
				silavag = 2
				dick = 16
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi2.jpg','Игорь продолжать долбить ваш рот, а Андрей с Сергеем с интереом наблюдали и даже помогали ему, давя врямя от времени вам на затылок...'
				act 'Сосать дальше':
					*clr & cla
					minut += 5
					pose = 0
					lubonus += 1
					bj += 2
					horny += rand(10,20)
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOasi1.'+rand(1,3)+'.jpg','Андрей с Сергеем решили тоже принять участие и подставили вам свои члены. Вы принялись сосать у обступивших вас парней, поочередно уделяя внимание каждому члену.'
					$boy = 'Андрей'
					silavag = 0
					dick = 20
					bj += 1
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Сергей'
					silavag = 1
					dick = 18
					bj += 1
					gs 'zz_dynamic_sex', 'bj'
					$boy = 'Игорь'
					silavag = 2
					dick = 16
					bj += 1
					gs 'zz_dynamic_sex', 'bj'
					act 'Лечь на спину':
						*clr & cla
						minut += 5
						pose = 0
						sex += 1
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaOsi1.'+rand(1,2)+'.jpg'
						gs 'zz_render','','','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь и Сергей стали над вами выставив свои члены перед вашим лицом...'
						$boy = 'Сергей'
						silavag = 1
						dick = 18
						gs 'zz_dynamic_sex', 'bj'
						$boy = 'Игорь'
						silavag = 2
						dick = 16
						gs 'zz_dynamic_sex', 'bj'
						$boy = 'Андрей'
						silavag = 0
						dick = 20
						gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
						act 'Лежать на спине':
							*clr & cla
							minut += 5
							pose = 0
							sex += 1
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsOai1.'+rand(1,4)+'.jpg'
							gs 'zz_render','','','Парни положили вас на топчан. Сергей начал пристраиваться между ног, а Игорь и Андрей стали над вами выставив свои члены перед вашим лицом...'
							$boy = 'Андрей'
							silavag = 0
							dick = 20
							gs 'zz_dynamic_sex', 'bj'
							$boy = 'Игорь'
							silavag = 2
							dick = 16
							gs 'zz_dynamic_sex', 'bj'
							$boy = 'Сергей'
							silavag = 1
							dick = 18
							gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
							act 'Лечь на бок':
								*clr & cla
								minut += 5
								pose = 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrV2aOsi1.'+rand(1,3)+'.jpg'
								gs 'zz_render','','','Андрей положил вас на бок и начал пристраиваться между ног, а Игорь и Сергей стали перед вами выставив свои члены перед лицом...'
								$boy = 'Сергей'
								silavag = 1
								dick = 18
								gs 'zz_dynamic_sex', 'bj'
								$boy = 'Игорь'
								silavag = 2
								dick = 16
								gs 'zz_dynamic_sex', 'bj'
								$boy = 'Андрей'
								silavag = 0
								dick = 20
								gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
								act 'Стать на четвереньки':
									*clr & cla
									minut += 5
									pose = 1
									sex += 1
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrViOas1.'+rand(1,4)+'.jpg'
									gs 'zz_render','','','Вас поставили на четвереньки. Игорь начал пристраиваться сзади, а Игорь и Андрей стали перед вами выставив свои члены перед вашим лицом...'
									$boy = 'Андрей'
									silavag = 0
									dick = 20
									gs 'zz_dynamic_sex', 'bj'
									$boy = 'Сергей'
									silavag = 1
									dick = 18
									gs 'zz_dynamic_sex', 'bj'
									$boy = 'Игорь'
									silavag = 2
									dick = 16
									gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
									act 'Сесть сверху':
										*clr & cla
										minut += 5
										pose = 2
										gs 'stat'
										gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsOia1.'+rand(1,3)+'.jpg'
										gs 'zz_render','','','Сергей сел на топчан, потянув вас за собой, а Игорь и Андрей стали перед вами выставив свои члены перед вашим лицом...'
										$boy = 'Андрей'
										silavag = 0
										dick = 20
										gs 'zz_dynamic_sex', 'bj'
										$boy = 'Игорь'
										silavag = 2
										dick = 16
										gs 'zz_dynamic_sex', 'bj'
										$boy = 'Сергей'
										silavag = 1
										dick = 18
										gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
										act 'Сесть сверху':
											*clr & cla
											minut += 5
											pose = 2
											gs 'stat'
											gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaOis1.'+rand(1,3)+'.jpg'
											gs 'zz_render','','','Андрей сел на топчан, потянув вас за собой, а Игорь и Сергей пристроились рядом вами выставив свои члены перед вашим лицом...'
											$boy = 'Сергей'
											silavag = 1
											dick = 18
											gs 'zz_dynamic_sex', 'bj'
											$boy = 'Игорь'
											silavag = 2
											dick = 16
											gs 'zz_dynamic_sex', 'bj'
											$boy = 'Андрей'
											silavag = 0
											dick = 20
											gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
											act 'Далее':
												*clr & cla
												minut += 5
												pose = 1
												gs 'stat'
												gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi3.jpg'
												gs 'zz_render','','','Вы отсасывали у Игоря, когда почувствовали как чей-то палец начинает проникать в вашу попу...'
												gs 'zz_render','','','- Попе видно сегодня тоже достанется, - подумали вы.'
												act 'Далее':
													*clr & cla
													minut += 5
													pose = 1
													lubonus += 5
													manna += 25
													gs 'stat'
													gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi4.jpg'
													gs 'zz_render','','','Андрей обильно смазал вашу попу вазелином...'
													gs 'zz_render','','','- Ну хоть так, не на сухую, - подумали вы с облегчением.'
													act 'Сесть сверху':
														*clr & cla
														minut += 5
														pose = 1
														gs 'stat'
														gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrDPVaAiOs1.'+rand(1,2)+'.jpg'
														gs 'zz_render','','','Андрей лёг на землю, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
														$boy = 'Сергей'
														silavag = 1
														dick = 18
														gs 'zz_dynamic_sex', 'bj'
														$boy = 'Андрей'
														$boy2 = 'Игорь'
														dick = 20
														dick2 = 16
														gs 'zz_dynamic_sex', 'dp_start', 1
														gs 'zz_dynamic_sex', 'double_penetration'
														act 'Лечь на спину':
															*clr & cla
															minut += 1
															pose = 0
															gs 'stat'
															gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi5.jpg'
															gs 'zz_render','','','Парни положили вас на спину, а сами нависли над вами. Они принялись дрочить перед вашим лицом, и вы поняли что они скоро кончат...'
															act 'Ждать':
																*clr & cla
																minut += 1
																pose = 0
																gs 'zz_funcs', 'cum', 'face'
																gs 'zz_funcs', 'cum', 'belly'
																gs 'zz_funcs', 'cum', 'lip'
																swallow += 1
																gs 'stat'
																gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi6.jpg'
																gs 'zz_render','','','Наконец парни начали кончать, струи спермы ударили в ваше лицо, попали вам в рот и на тело тоже немного прилетело...'
																act 'Вырубиться':
																	*clr & cla
																	minut += 1
																	 gs 'stat'
																	gs 'zz_render','','images/qwest/gadukino/Swamp/dancesexson.jpg'
																	gs 'zz_render','','','Как только парни отошли от вас, вы моментально отрубились не одеваясь и не меняя позы...'
																	if hantersIgorLove > 0:' - Я же говорил тебе Игорь, что она шлюха, а ты мне не верил, - услышали напоследок голос Андрея.'
																	if hantersIgorLove = 1 or hantersIgorLove = 2:' - Ну теперь знаю... а я то думал у нас все серьезно будет, - и ответ Игоря. Вы поняли, он вас бросил.'
																	if hantersIgorLove = 3:' - Ну теперь знаю... а я то вирил ей, - и ответ Игоря. Вы поняли, это развод.'
																	if hantersSergeiLove > 0:' - Я же говорил тебе Сергей, что она шлюха, а ты мне не верил, - услышали напоследок голос Андрея.'
																	if hantersSergeiLove > 0:' - Да уж, ты был прав, - и ответ Сергея. Вы поняли, он вас бросил.'
																	if hantersAndreiLove > 0:' - Да уж, думал ты другая, - услышали напоследок голос Андрея. Плюнув напоследок вам между ног, он вышел. Вы поняли, он вас бросил.'
																	act 'Проснуться':
																		*clr & cla
																		minut += 600
																		son += 20
																		health += 50
																		manna += 50
																		hantdanceslut = 1
																		if hantersIgorLove = 3:hantersIgorLove = 0 & hantersIgorQw -= 100 & husband = 0 & divorced += 1 & husbandMark = 0 & husbharmin = 0 & husbizvradd = 0
																		if hantersIgorLove = 2:hantersIgorLove = 0 & hantersIgorQw -= 100 & bfa += 0
																		if hantersIgorLove = 1:hantersIgorLove = 0 & hantersIgorQw -= 100
																		if hantersSergeiLove = 1:hantersSergeiLove = 0 & hantersSergeiQw -= 100
																		if hantersAndreiLove = 1:hantersAndreiLove = 0 & hantersAndreiQw -= 100
																		gs 'stat'
																		gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel1.jpg'
																		gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле оторвали голову от подушки. Голова болела и вы смутно помнили, что вчера происходило.'
																		act 'Далее': gt'swamphouse'
																	end
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
!секс после стриптиза если ГГ шлюха
if hantdancesex = 3:
	*clr & cla
	minut += 5
	gang += 1
	manna = 100
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	bj += 3
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
	hantslutsex += rand(9,12)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/dance6.jpg'
	gs 'zz_render','','','Вы устало присели на край стола, чтобы отдохнуть и перекурить. К вам с улыбкой подошел уже голый Игорь.'
	gs 'zz_render','','','-Светик, это было круто, - сказал он улыбаясь . - Продолжим?'
	gs 'zz_render','','','-Конечно, - пьяно улыбаясь ответили вы .'
	act 'Сосать': dynamic $hantergrOi
end
! секс если ГГ голая перед охотниками
if hantersexnude = 1:
	*clr & cla
	gang += 1
	minut += 1
	hantersexnude = 0
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	bj += 3
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
	hantslutsex += rand(9,12)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/hantersrelax1.4.jpg'
	gs 'zz_render','','','Вы подошли к парням с игривой улыбкой...'
	gs 'zz_render','','','- Ты знаешь, что делать Светик, - сказал Андрей улыбаясь. - Приступай.'
	act 'Сосать':dynamic $hantersgrOasi
end
! если ГГ шлюха
if sluthomesex = 1:
	*clr & cla
	minut += 5
	sluthomesex = 0
	hantslutsex += rand(3,6)
	! для перерыва между сексом, отнимается -1 каждый час
	clothesswamphouse = 1
	cloth[1] = 1
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	bj += 1
	gs 'zz_clothing2','redress',0
	if hanterandreisex = 0 and temphant = 1:hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0 and temphant = 2:hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0 and temphant = 3:hanterigorsex = 1 & guy += 1
	if temphant = 1:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 2:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomesex1.jpg'
	gs 'zz_render','','','Дойдя до топчана, парень тут же принялся вас раздевать.'
	gs 'zz_render','','','- Ты знаешь, что делать Светик, - сказал <<$boy>> улыбаясь. - Приступай.'
	act 'Сесть на корточки':dynamic $sluthomeSTART
end
!трио
if doublelovesex = 1 or slutgosex = 2 or forest_hantersex = 2 or forest_gopsex = 2:
	*clr & cla
	minut += 5
	slutgosex = 0
	doublelovesex = 0
	dom -= 1
	gang += 1
	bj += 2
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	! для перерыва между сексом, отнимается -1 каждый час
	if slutgosex = 2:hantslutsex += rand(6,9)
	if doublelovesex = 1:hantersAndreisex += rand(6,24)
	if doublelovesex = 1:hantersSergeisex += rand(9,30)
	hantsexa = rand(1,5)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doublelovesex.jpg'
	if doublelovesex = 1:
		gs 'zz_render','','','Войдя поглубже в заросли парни подошли к вам вплотную и начали обнимать и целовать. Они надавили вам на плечи и вы принялись...'
	else
		gs 'zz_render','','','Войдя поглубже в заросли парни подошли к вам вплотную и начали раздевать. Они надавили вам на плечи и вы принялись...'
	end
	if hantsexa < 4:act 'Сосать':dynamic $doubleloveOral12
	if hantsexa = 4:act 'Сосать':dynamic $doubleloveOralCum12_1
	if hantsexa = 5:act 'Сосать':dynamic $doubleloveOralCum12_2
end
! Двое vs ГГ
$doubleloveOral12 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 1
	hantsexa = rand(1,6)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOral12.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнями, и сосете их члены, поочередно уделяю внимание каждому...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','<<$textsexhanter5>>'
	if health > 50 and hantsexa = 1:act 'Стать на колени':dynamic $doubleloveOralCum12
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $doubleloveDog112
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $doubleloveDog212
	if health > 50 and hantsexa = 4:act 'Лечь на бок':dynamic $doubleloveSide12
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $doubleloveCow112
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $doubleloveCow212
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveOralCum12_1 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 2
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOralCum12_1.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнями, и сосете их члены, поочередно уделяю внимание каждому...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSide2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveOralCum12_2 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 2
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOralCum12_2.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнями, и сосете их члены, поочередно уделяю внимание каждому...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $doubleloveCow1
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveDog112 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,7)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveDog112.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы стоите на ногах перед парнями, согнувшись раком, и сосете их член одного, пока второй пристраивается сзади...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter7>>'
	if health > 50:
		if hantsexa = 1: act 'Стать на колени':dynamic $doubleloveOralCum12
		if hantsexa = 2: act 'Стать раком':dynamic $doubleloveDogCum112_1
		if hantsexa = 3: act 'Стать раком':dynamic $doubleloveDogCum112_2
		if hantsexa = 4: act 'Стать раком':dynamic $doubleloveDog212
		if hantsexa = 5: act 'Лечь на бок':dynamic $doubleloveSide12
		if hantsexa = 6: act 'Сесть сверху':dynamic $doubleloveCow112
		if hantsexa = 7: act 'Сесть сверху':dynamic $doubleloveCow212
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$doubleloveDogCum112_1 = {
	*clr & cla
	minut += 5
	lubonus += 1
	gs 'zz_funcs', 'cum', 'anus'
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveDogCum112_1.jpg'
	gs 'zz_render','','','Вы стоите на ногах перед парнями, согнувшись раком, и сосете их член одного, пока второй пристраивается сзади...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter6>>'
	lubonus += 1
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSide2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveDogCum112_2 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveDogCum112_2.jpg'
	gs 'zz_render','','','Вы стоите на ногах перед парнями, согнувшись раком, и сосете их член одного, пока второй пристраивается сзади...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $doubleloveCow1
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveDog212 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,7)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveDog212.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы стоите раком перед парнями и сосете их член одного, пока второй пристраивается сзади...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18 & boyBsexa += 1
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyBsexa += 1
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15 & boyBsexa += 1
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14 & boyBsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter7>>'
	if health > 50 and hantsexa = 1:act 'Стать на колени':dynamic $doubleloveOralCum12
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $doubleloveDogCum212_1
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $doubleloveDogCum212_2
	if health > 50 and hantsexa = 4:act 'Стать раком':dynamic $doubleloveDog112
	if health > 50 and hantsexa = 5:act 'Лечь на бок':dynamic $doubleloveSide12
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $doubleloveCow112
	if health > 50 and hantsexa = 7:act 'Сесть сверху':dynamic $doubleloveCow212
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveDogCum212_1 = {
	*clr & cla
	minut += 5
	lubonus += 1
	gs 'zz_funcs', 'cum', 'anus'
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveDogCum212_1.jpg'
	gs 'zz_render','','','Вы стоите раком перед парнями и сосете их член одного, пока второй пристраивается сзади...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter6>>'
	lubonus += 1
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $doubleloveCow1
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveDogCum212_2 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveDogCum212_2.jpg'
	gs 'zz_render','','','Вы стоите раком перед парнями и сосете их член одного, пока второй пристраивается сзади...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18 & boyBsexa += 1
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyBsexa += 1
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15 & boyBsexa += 1
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14 & boyBsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSide2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveSide12 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,7)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveSide12.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы лежите на боку, член одного парня перед вашим лицом, а второй в это время пристраивается сзади...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18 & boyBsexa += 1
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyBsexa += 1
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15 & boyBsexa += 1
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14 & boyBsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter7>>'
	if health > 50 and hantsexa = 1:act 'Стать на колени':dynamic $doubleloveOralCum12
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $doubleloveDog212
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $doubleloveDog112
	if health > 50 and hantsexa = 4:act 'Лечь на бок':dynamic $doubleloveSideCum12_1
	if health > 50 and hantsexa = 5:act 'Лечь на бок':dynamic $doubleloveSideCum12_2
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $doubleloveCow112
	if health > 50 and hantsexa = 7:act 'Сесть сверху':dynamic $doubleloveCow212
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveSideCum12_1 = {
	*clr & cla
	minut += 5
	lubonus += 1
	gs 'zz_funcs', 'cum', 'anus'
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveSideCum12_1.jpg'
	gs 'zz_render','','','Вы стоите раком перед парнями и сосете их член одного, пока второй пристраивается сзади...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter6>>'
	lubonus += 1
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $doubleloveCow1
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveSideCum12_2 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveSideCum12_2.jpg'
	gs 'zz_render','','','Вы стоите раком перед парнями и сосете их член одного, пока второй пристраивается сзади...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18 & boyBsexa += 1
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyBsexa += 1
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15 & boyBsexa += 1
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14 & boyBsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSide2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCow112 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,7)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCow112.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Один из парней лег на землю, пристраивая вас сверху, второй стал рядом, поднеся свой член к вашему лицу...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter7>>'
	if health > 50 and hantsexa = 1:act 'Стать на колени':dynamic $doubleloveOralCum12
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $doubleloveDog112
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $doubleloveDog212
	if health > 50 and hantsexa = 4:act 'Лечь на бок':dynamic $doubleloveSide12
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $doubleloveCowCum112_1
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $doubleloveCowCum112_2
	if health > 50 and hantsexa = 7:act 'Сесть сверху':dynamic $doubleloveCow212
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCowCum112_1 = {
	*clr & cla
	minut += 5
	lubonus += 1
	gs 'zz_funcs', 'cum', 'anus'
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCowCum112_1.jpg'
	gs 'zz_render','','','Один из парней лег на землю, пристраивая вас сверху, второй стал рядом, поднеся свой член к вашему лицу...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter6>>'
	lubonus += 1
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSide2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCowCum112_2 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCowCum112_2.jpg'
	gs 'zz_render','','','Один из парней лег на землю, пристраивая вас сверху, второй стал рядом, поднеся свой член к вашему лицу...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $doubleloveCow1
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCow212 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,7)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCow212.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Один из парней лег на землю, пристраивая вас сверху, второй стал рядом, поднеся свой член к вашему лицу...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter7>>'
	if health > 50 and hantsexa = 1:act 'Стать на колени':dynamic $doubleloveOralCum12
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $doubleloveDog112
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $doubleloveDog212
	if health > 50 and hantsexa = 4:act 'Лечь на бок':dynamic $doubleloveSide12
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $doubleloveCowCum212_1
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $doubleloveCowCum212_2
	if health > 50 and hantsexa = 7:act 'Сесть сверху':dynamic $doubleloveCow112
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCowCum212_1 = {
	*clr & cla
	minut += 5
	lubonus += 1
	gs 'zz_funcs', 'cum', 'anus'
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCowCum212_1.jpg'
	gs 'zz_render','','','Один из парней лег на землю, пристраивая вас сверху, второй стал рядом, поднеся свой член к вашему лицу...'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter6>>'
	lubonus += 1
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSide2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCowCum212_2 = {
	*clr & cla
	minut += 5
	lubonus += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCowCum212_2.jpg'
	gs 'zz_render','','','Один из парней лег на землю, пристраивая вас сверху, второй стал рядом, поднеся свой член к вашему лицу...'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter6>>'
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $doubleloveCow1
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveSide2 = {
	*clr & cla
	minut += 5
	hantsexa = rand(1,2)
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18 & boyBsexa += 1
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyBsexa += 1
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15 & boyBsexa += 1
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14 & boyBsexa += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveSide2.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы лежите на боку, <<$boy>> за вашей спиной пристраивается сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Лечь на бок':dynamic $doubleloveSideCum2
	if health > 50 and hantsexa = 2:act 'Сосать':dynamic $doubleloveOral2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveSideCum2 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveSideCum2.jpg'
	gs 'zz_render','','','Вы лежите на боку, <<$boy>> за вашей спиной пристраивается сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	lubonus = 0
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$doubleloveCow1 = {
	*clr & cla
	minut += 5
	hantsexa = rand(1,2)
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20 & boyAsexa += 1
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16 & boyAsexa += 1
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCow1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','<<$boy>> лег на землю, приглашая вам пристроиться сверху...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter3>>'
	if health > 50 and hantsexa = 1:act 'Стать на колени':dynamic $doubleloveCowCum1
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $doubleloveOral1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveCowCum1 = {
	*clr & cla
	minut += 5
	lubonus += 1
	gs 'zz_funcs', 'cum', 'anus'
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveCowCum1.jpg'
	gs 'zz_render','','','<<$boy>> лег на землю, приглашая вам пристроиться сверху...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter4>>'
	lubonus = 0
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$doubleloveOral1 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 1
	hantsexa = rand(1,5)
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16 & boyAsexa += 1
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14 & boyAsexa += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOral1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнем, его член прямо перед вашим лицом...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','<<$textsexhanter2>>'
	if health > 50:act 'Сосать дальше':dynamic $doubleloveOralCum1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveOralCum1 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	hantsexa = rand(1,5)
	if temphant <= 2:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 5:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOralCum1.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнем, его член прямо перед вашим лицом...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','<<$textsexhanter3>>'
	lubonus = 0
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$doubleloveOral2 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 1
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOral2.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнем, его член прямо перед вашим лицом...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter2>>'
	if health > 50:act 'Сосать дальше':dynamic $doubleloveOralCum2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$doubleloveOralCum2 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	hantsexa = rand(1,5)
	if temphant = 1 or temphant = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 2:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4 or temphant = 6:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 5:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOralCum2.jpg'
	gs 'zz_render','','','Вы стоите на коленях перед парнем, его член прямо перед вашим лицом...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter3>>'
	lubonus = 0
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$doubleloveOralCum12 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	gs 'zz_funcs', 'cum', 'face'
	hantsexa = rand(1,5)
	lubonus = 0
	if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
	if cloth[0] > 2:cumfrot += rand(0,1)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/doubleloveOralCum12.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы, стоите на коленях перед парнями с открытым ртом. Они яростно надрачивают свой члены перед вашим лицом...'
	gs 'zz_render','','','Вскоре струи спермы ударяют вам в рот, одна, вторая, третья. Спермы оказалось слишком много. Она стекает по подбородку, капая вниз. Парни убрали члены в штаны и пошели по своим делам, оставив вас одну приводить себя в порядок.'
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
! Секс ГГ vs парень в избушке
$sluthomeSTART = {
	*clr & cla
	minut += 5
	horny += rand(1,5)
	bj += 1
	hantsexa = rand(1,3)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeSTART.jpg'
	gs 'zz_render','','','Вы опустились на корточки и принялись стягивать с парня штаны. Когда дело было сделано, парень глянув на вас, сказал...'
	if hantsexa = 1:act 'Сосать':dynamic $sluthomeORAL1
	if hantsexa = 2:act 'Сосать':dynamic $sluthomeOralCum1
	if hantsexa = 3:act 'Снять трусики':dynamic $sluthomeTanga
}
$sluthomeORAL1 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 1
	hantsexa = rand(1,5)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeORAL1.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы, стоя раком перед парнем, подносите член к свом губам...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','<<$textsexhanter2>>'
	if hantsexa = 1:act 'Сосать дальше':dynamic $sluthomeORAL2
	if hantsexa = 2:act 'Сосать дальше':dynamic $sluthomeOralCum2
	if hantsexa = 3:act 'Сосать дальше':dynamic $sluthomeORAL3
	if hantsexa = 4:act 'Сосать дальше':dynamic $sluthomeOralCum3
	if hantsexa = 5:act 'Снять трусики':dynamic $sluthomeTanga
}
$sluthomeOralCum1 = {
	*clr & cla
	minut += 5
	lubonus = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeOralCum1.jpg'
	gs 'zz_render','','','Вы, стоя раком перед парнем, подносите член к свом губам...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeORAL2 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 1
	hantsexa = rand(1,4)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeORAL2.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы, стоя на коленях перед парнем, подносите член к свом губам...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','<<$textsexhanter2>>'
	if hantsexa = 1:act 'Сосать дальше':dynamic $sluthomeOralCum2
	if hantsexa = 2:act 'Сосать дальше':dynamic $sluthomeORAL3
	if hantsexa = 3:act 'Сосать дальше':dynamic $sluthomeOralCum3
	if hantsexa = 4:act 'Снять трусики':dynamic $sluthomeTanga
}
$sluthomeOralCum2 = {
	*clr & cla
	minut += 5
	lubonus = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeOralCum2.jpg'
	gs 'zz_render','','','Вы, стоя на коленях перед парнем, подносите член к свом губам...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeORAL3 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	lubonus += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeORAL3.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','<<$boy>> навалился на вас всем телом, заставив запрокинуть голову назад, и стал с силой вгонять свой член, проникая в самое горло.'
	if dick > throat:'Вас тут же скручивает рвотный рефлекс и из глаз тект слезы.'
	if dick < throat:'К счастью горло у вас тренированное и вы заглатываете член парня до основания без каких либо трудностей.'
	if hantsexa = 1:act 'Сосать дальше':dynamic $sluthomeOralCum3
	if hantsexa = 2:act 'Снять трусики':dynamic $sluthomeTanga
}
$sluthomeOralCum3 = {
	cls
	minut += 5
	lubonus = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeOralCum3.jpg'
	gs 'zz_render','','','<<$boy>> навалился на вас всем телом, заставив запрокинуть голову назад, и стал с силой вгонять свой член проникая в самое горло.'
	if dick > throat:'Вас тут же скручивает рвотный рефлекс и из глаз тект слезы.'
	if dick < throat:'К счастью горло у вас тренированное и вы заглатываете член парня до основания без каких-либо трудностей.'
	gs 'zz_render','','','<<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить...'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeORAL4 = {
	*clr & cla
	minut += 5
	horny += rand(5,10)
	if lubonus = 0:lubonus += 1
	hantsexa = rand(1,7)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeORAL4.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы, стоя на коленях перед парнем, подносите член к свом губам...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','<<$textsexhanter2>>'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $sluthomeOralCum4
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $sluthomeAnalDog1
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $sluthomeAnalDogCum1
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $sluthomeAnalCow1
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $sluthomeAnalCowCum1
	if health > 50 and hantsexa = 6:act 'Лечь на бок':dynamic $sluthomeAnalSide1
	if health > 50 and hantsexa = 7:act 'Лечь на бок':dynamic $sluthomeAnalSideCum1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeOralCum4 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	swallow += 1
	gs 'zz_funcs', 'cum', 'belly'
	lubonus = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeOralCum4.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Вы, стоите на коленях перед парнем с открытым ртом. <<$boy>> яростно надрачивает свой <<dick>> член перед вашим лицом...'
	gs 'zz_render','','','Вскоре струя спермы ударяет вам в рот, за ней вторая и третья. Спермы оказалось слишком много. Она стекает по подбородку, капая вниз и пачкая вашу грудь и живот. <<$boy>> убрал член в штаны и пошел по своим делам, оставив вас одну, приводить себя в порядок.'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeTanga = {
	*clr & cla
	minut += 5
	horny += 5
	cloth[1] = 0
	hantsexa = rand(1,6)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeTanga.jpg'
	gs 'zz_render','','','- Светик, снимай давай трусики - сказал <<$boy>> прервавшись. - Приступим к самому интересному.'
	gs 'zz_render','','','Вы быстренько сели на топчан и стянули с себя последнюю деталь одежды. Увидев это парень сказал..'
	if health > 50 and hantsexa = 1:act 'Стать раком':dynamic $sluthomeAnalDog1
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $sluthomeAnalDogCum1
	if health > 50 and hantsexa = 3:act 'Сесть сверху':dynamic $sluthomeAnalCow1
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $sluthomeAnalCowCum1
	if health > 50 and hantsexa = 5:act 'Лечь на бок':dynamic $sluthomeAnalSide1
	if health > 50 and hantsexa = 6:act 'Лечь на бок':dynamic $sluthomeAnalSideCum1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalDog1 = {
	*clr & cla
	minut += 5
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	hantsexa = rand(1,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalDog1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','<<$boy>> ставит вас раком на топчане и начинает пристраиваться сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Стать раком':dynamic $sluthomeAnalDog2
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $sluthomeAnalDogCum2
	if health > 50 and hantsexa = 3:act 'Сесть сверху':dynamic $sluthomeAnalCow1
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $sluthomeAnalCowCum1
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $sluthomeAnalCow2
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $sluthomeAnalCowCum2
	if health > 50 and hantsexa = 7:act 'Лечь на бок':dynamic $sluthomeAnalSide1
	if health > 50 and hantsexa = 8:act 'Лечь на бок':dynamic $sluthomeAnalSideCum1
	if health > 50 and hantsexa = 9:act 'Лечь на бок':dynamic $sluthomeAnalSide2
	if health > 50 and hantsexa = 10:act 'Лечь на бок':dynamic $sluthomeAnalSideCum2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalDogCum1 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalDogСum1.jpg'
	gs 'zz_render','','','Вы стоите раком на топчане, <<$boy>> пристраиваться сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeAnalDog2 = {
	*clr & cla
	minut += 5
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	hantsexa = rand(1,5)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalDog2.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы стоите раком на топчане, согнув своими руками ноги в коленях, чтобы <<$boy>> мог войти в вшу попу поглубже...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $sluthomeORAL4
	if health > 50 and hantsexa = 3:act 'Сесть сверху':dynamic $sluthomeAnalCow1
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $sluthomeAnalCowCum1
	if health > 50 and hantsexa = 5:act 'Лечь на бок':dynamic $sluthomeAnalSide1
	if health > 50 and hantsexa = 6:act 'Лечь на бок':dynamic $sluthomeAnalSideCum1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalDogCum2 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalDogСum2.jpg'
	gs 'zz_render','','','Вы стоите раком на топчане, согнув своими руками ноги в коленях, чтобы <<$boy>> мог войти в вшу попу поглубже...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее': gt'swamphouse'
}
$sluthomeAnalCow1 = {
	*clr & cla
	minut += 5
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	hantsexa = rand(1,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalCow1.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','<<$boy>> ложится на спину, вы забираетесь на него верхом...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Стать раком':dynamic $sluthomeAnalDog1
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $sluthomeAnalDogCum1
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $sluthomeAnalDog2
	if health > 50 and hantsexa = 4:act 'Стать раком':dynamic $sluthomeAnalDogCum2
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $sluthomeAnalCow2
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $sluthomeAnalCowCum2
	if health > 50 and hantsexa = 7:act 'Лечь на бок':dynamic $sluthomeAnalSide1
	if health > 50 and hantsexa = 8:act 'Лечь на бок':dynamic $sluthomeAnalSideCum1
	if health > 50 and hantsexa = 9:act 'Лечь на бок':dynamic $sluthomeAnalSide2
	if health > 50 and hantsexa = 10:act 'Лечь на бок':dynamic $sluthomeAnalSideCum2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalCowCum1 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalCowСum1.jpg'
	gs 'zz_render','','','<<$boy>> ложится на спину, вы забираетесь на него верхом...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее': gt'swamphouse'
}
$sluthomeAnalCow2 = {
	*clr & cla
	minut += 5
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	hantsexa = rand(1,3)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalCow2.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','<<$boy>> ложится на спину, вы забираетесь на него верхом, подогнув ноги под себя...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $sluthomeORAL4
	if health > 50 and hantsexa = 2:act 'Лечь на бок':dynamic $sluthomeAnalSide1
	if health > 50 and hantsexa = 3:act 'Лечь на бок':dynamic $sluthomeAnalSideCum1
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalCowCum2 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalCowСum2.jpg'
	gs 'zz_render','','','<<$boy>> ложится на спину, вы забираетесь на него верхом, подогнув ноги под себя...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeAnalSide1 = {
	*clr & cla
	pose = 0
	minut += 5
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	hantsexa = rand(1,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalSide1.'+rand(1,2)+'.jpg','<<$boy>> ложит вас на бок, а сам пристраивается сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Стать раком':dynamic $sluthomeAnalDog1
	if health > 50 and hantsexa = 2:act 'Стать раком':dynamic $sluthomeAnalDogCum1
	if health > 50 and hantsexa = 3:act 'Стать раком':dynamic $sluthomeAnalDog2
	if health > 50 and hantsexa = 4:act 'Стать раком':dynamic $sluthomeAnalDogCum2
	if health > 50 and hantsexa = 5:act 'Сесть сверху':dynamic $sluthomeAnalCow1
	if health > 50 and hantsexa = 6:act 'Сесть сверху':dynamic $sluthomeAnalCowCum1
	if health > 50 and hantsexa = 7:act 'Сесть сверху':dynamic $sluthomeAnalCow2
	if health > 50 and hantsexa = 8:act 'Сесть сверху':dynamic $sluthomeAnalCowCum2
	if health > 50 and hantsexa = 9:act 'Лечь на бок':dynamic $sluthomeAnalSide2
	if health > 50 and hantsexa = 10:act 'Лечь на бок':dynamic $sluthomeAnalSideCum2
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalSideCum1 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalSideСum1.jpg','<<$boy>> ложит вас на бок, а сам пристраивается сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
$sluthomeAnalSide2 = {
	*clr & cla
	pose = 0
	minut += 5
	if boyAsexa = 0:boyAsexa = 1 & anal += 1
	hantsexa = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalSide2.'+rand(1,2)+'.jpg','Вы лежите на боку, высоко задрав ногу вверх, <<$boy>> пристроился сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','<<$textsexhanter4>>'
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $sluthomeORAL4
	if health > 50 and hantsexa = 2:act 'Стать на колени':dynamic $sluthomeOralCum4
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$sluthomeAnalSideCum2 = {
	*clr & cla
	minut += 5
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/sluthomeAnalSideСum2.jpg','<<$boy>> ложит вас на бок, а сам пристраивается сзади...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','<<$textsexhanter3>>'
	act 'Далее':gt'swamphouse'
}
! ГГ vs три парня
$hantergrOi = {
	*clr & cla
	pose = 0
	minut += 5
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	throat += 1
	horny += rand(10,20)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOi2.'+rand(0,4)+'.jpg','Вы приблизили губы к члену Игоря..'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','Стараясь доставить больше удовольствия, вы стараетесь заглатывать как можно глубже и Игорю похоже это нравится...'
	hantsexa = rand(1,3)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantergrOi
	if health > 50 and hantsexa > 1:act 'Сосать у всех':dynamic $hantersgrOasi
}
$hantersgrOasi = {
	*clr & cla
	minut += 5
	pose = 0
	horny += rand(10,20)
	lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/dancesexOasi1.'+rand(1,3)+'.jpg','Вы принялись сосать у обступивших вас парней, поочередно уделяя внимание каждому члену.'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	bj += 1
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	bj += 1
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	bj += 1
	gs 'zz_dynamic_sex', 'bj'
	hantsexa = rand(1,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVaOsi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaOsi1.'+rand(1,2)+'.jpg','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVOsi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVOsi.jpg','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','Андрей кончил и отошел в сторону.'
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr2VsO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2AiOs
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2AiO
	if health > 50 and hantsexa = 2 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2AOs
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2AOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2AsO
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVaO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaO.jpg'
	gs 'zz_render','','','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'swallow'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Сергей с Игорем кончили и отошли отдыхать.'
	hantsexa = rand(1,3)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr1Va
	if health > 50 and hantsexa = 2:act 'Лечь на спину':dynamic $hantersgrO1
	if health > 50 and hantsexa = 3:act 'Сесть сверху':dynamic $hantersgr1Aa
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVaOi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaOi.jpg'
	gs 'zz_render','','','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Сергей кончил и присел рядом, просто понаблюдать'
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2VaOi
	if health > 50 and hantsexa = 1 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2VO
	if health > 50 and hantsexa = 1 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2VOi
	if health > 50 and hantsexa = 2 and hantsexb <= 4:act 'Стать на четвереньки':dynamic $hantersgr2ViOa
	if health > 50 and hantsexa = 2 and hantsexb > 4:act 'Стать на четвереньки':dynamic $hantersgr2ViO
	if health > 50 and hantsexa = 3:act 'Лечь на спину':dynamic $hantersgrO2
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVsOai = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsOai1.'+rand(1,4)+'.jpg'
	gs 'zz_render','','','Парни положили вас на топчан. Сергей начал пристраиваться между ног, а Игорь и Андрей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVOai = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVOai.jpg'
	gs 'zz_render','','','Парни положили вас на топчан. Сергей начал пристраиваться между ног, а Игорь и Андрей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','Сергей кончил и отошел.'
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2VaOi
	if health > 50 and hantsexa = 1 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2VO
	if health > 50 and hantsexa = 1 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2VOi
	if health > 50 and hantsexa = 2 and hantsexb <= 4:act 'Стать на четвереньки':dynamic $hantersgr2ViOa
	if health > 50 and hantsexa = 2 and hantsexb > 4:act 'Стать на четвереньки':dynamic $hantersgr2ViO
	if health > 50 and hantsexa = 3:act 'Лечь на спину':dynamic $hantersgrO2
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVsOi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsOi.jpg'
	gs 'zz_render','','','Парни положили вас на топчан. Сергей начал пристраиваться между ног, а Игорь и Андрей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Андрей кончил и вышел на перекур'
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr2VsO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2AiOs
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2AiO
	if health > 50 and hantsexa = 2 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2AOs
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2AOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2AsO
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVsO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsO.jpg'
	gs 'zz_render','','','Парни положили вас на топчан. Сергей начал пристраиваться между ног, а Игорь и Андрей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'swallow'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Сергей с Игорем кончили и отошли в сторону.'
	if health > 50:act 'Сесть сверху':dynamic $hantersgr1As
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrViOas = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrViOas1.'+rand(1,4)+'.jpg'
	gs 'zz_render','','','Вас поставили на четвереньки. Игорь начал пристраиваться сзади, а Сергей и Андрей стали перед вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsex = 0: boyCsex = 1 & sex += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrViO = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrViO.jpg'
	gs 'zz_render','','','Вас поставили на четвереньки. Игорь начал пристраиваться сзади, а Сергей и Андрей стали перед вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsex = 0: boyCsex = 1 & sex += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'swallow'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Андрей с Сергей кончили одновременно и сели за стол отдыхать'
	if health > 50:act 'Лечь на спину':dynamic $hantersgr1Ai
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVsOia = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsOia1.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Сергей сел на топчан, потянув вас за собой, а Игорь и Андрей стали перед вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVsOi1 = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVsOi1.jpg'
	gs 'zz_render','','','Сергей сел на топчан, потянув вас за собой, а Игорь и Андрей стали перед вами выставив свои члены перед вашим лицом...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Андрей кончил и вырубился, а вы продолжили с Сергеем и Игорем'
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr2VsO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2AiOs
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2AiO
	if health > 50 and hantsexa = 2 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2AOs
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2AOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2AsO
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVaOis = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaOis1.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Андрей сел на топчан, потянув вас за собой, а Игорь и Сергей пристроились рядом вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVaOs = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVaOs.jpg'
	gs 'zz_render','','','Андрей сел на топчан, потянув вас за собой, а Игорь и Сергей пристроились рядом вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Игорь кончил и отвал на боковую.'
	hantsexa = rand(1,2)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 4:act 'Лечь на бок':dynamic $hantersgr2VaOs
	if health > 50 and hantsexa = 1 and hantsexb <= 4:act 'Лечь на бок':dynamic $hantersgr2VaO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2DPVaAs
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2DPVaA
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrVO = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrVO.jpg'
	gs 'zz_render','','','Андрей сел на топчан, потянув вас за собой, а Игорь и Сергей пристроились рядом вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	pose = 2
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Парни кончили и сразу уснули.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgrV2aOsi = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrV2aOsi1.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Андрей положил вас на бок и начал пристраиваться между ног, а Игорь и Сергей стали перед вами выставив свои члены перед лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrV2aOs = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrV2aOs.jpg'
	gs 'zz_render','','','Андрей положил вас на бок и начал пристраиваться между ног, а Игорь и Сергей стали перед вами выставив свои члены перед лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Игорь кончил и ушел на перекур.'
	hantsexa = rand(1,2)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 4:act 'Лечь на бок':dynamic $hantersgr2VaOs
	if health > 50 and hantsexa = 1 and hantsexb <= 4:act 'Лечь на бок':dynamic $hantersgr2VaO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2DPVaAs
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2DPVaA
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrDPVaAiOs = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrDPVaAiOs1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Андрей лёг на топчан, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	$boy2 = 'Игорь'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	dick = 20
	dick2 = 16
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrDPVaAOs = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrDPVaAOs.jpg'
	gs 'zz_render','','','Андрей лёг на топчан, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	$boy2 = 'Игорь'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	dick = 20
	dick2 = 16
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration', 1
	lubonus += 2
	gs 'zz_funcs', 'cum', 'anus'
	gs 'zz_render','','','Через некоторое время <<$boy2>> застонал и вы почувствовали как вашу попу наполняет тепло. Он кончил и ушел на улицу.'
	hantsexa = rand(1,2)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 4:act 'Лечь на бок':dynamic $hantersgr2VaOs
	if health > 50 and hantsexa = 1 and hantsexb <= 4:act 'Лечь на бок':dynamic $hantersgr2VaO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2DPVaAs
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2DPVaA
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrAiOsa = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrAiOsa.jpg'
	gs 'zz_render','','','Парни положили вас на спину, Игорь задрав вам ноги, принялся пристраиваться к вашей попе, а Андрей и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	hantsexa = rand(2,10)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgrOasi
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVaOsi
	if health > 50 and hantsexa = 2 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOsi
	if health > 50 and hantsexa = 2 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVaO
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVaOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrVsOai
	if health > 50 and hantsexa = 3 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrVsO
	if health > 50 and hantsexa = 3 and hantsexb < 4:act 'Лечь на спину':dynamic $hantersgrVOai
	if health > 50 and hantsexa = 3 and hantsexb = 4:act 'Лечь на спину':dynamic $hantersgrVsOi
	if health > 50 and hantsexa = 4 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgrViOas
	if health > 50 and hantsexa = 4 and hantsexb > 5:act 'Стать на четвереньки':dynamic $hantersgrViO
	if health > 50 and hantsexa = 5 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgrVsOia
	if health > 50 and hantsexa = 5 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVsOi1
	if health > 50 and hantsexa = 5 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgrVaOis
	if health > 50 and hantsexa = 6 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgrVO
	if health > 50 and hantsexa = 6 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgrVaOs
	if health > 50 and hantsexa = 7 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgrV2aOsi
	if health > 50 and hantsexa = 7 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgrV2aOs
	if health > 50 and hantsexa = 8 and hantsexb <= 4:act 'Сесть сверху':dynamic $hantersgrDPVaAiOs
	if health > 50 and hantsexa = 8 and hantsexb > 4:act 'Сесть сверху':dynamic $hantersgrDPVaAOs
	if health > 50 and hantsexa = 9 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgrAiOsa
	if health > 50 and hantsexa = 9 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgrAiO
	if health > 50 and hantsexa = 9 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgrAOsa
	if health > 50 and hantsexa = 10:act 'Лечь на спину':dynamic $hantersgrO3
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrAiO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrAiO.jpg'
	gs 'zz_render','','','Парни положили вас на спину, Игорь задрав вам ноги, принялся пристраиваться к вашей попе, а Андрей и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'swallow'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Андрей с Сергеем кончили и пошли за стол.'
	if health > 50:act 'Лечь на спину':dynamic $hantersgr1Ai
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrO3 = {
	*clr & cla
	minut += 1
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrO3.'+rand(1,4)+'.jpg'
	gs 'zz_render','','','Парни положили вас на спину, а сами нависли над вами. Они принялись дрочить перед вашим лицом, иногда вставляя члены вам в рот, и вы поняли что они скоро кончат...'
	act 'Ждать':
		*clr & cla
		minut += 1
		pose = 0
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_funcs', 'cum', 'belly'
		gs 'zz_funcs', 'cum', 'lip'
		swallow += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrO3cum1.'+rand(1,6)+'.jpg'
		gs 'zz_render','','','Наконец парни начали кончать, струи спермы ударили в ваше лицо, попали вам в рот и на тело тоже немного прилетело...'
		if hantersexnude = 0:act 'Вырубиться': dynamic $hantersgrEND
		if hantersexnude = 1:act 'Далее': hantersexnude = 0 & gt'swamphouse'
	end
}
$hantersgrEND = {
	*clr & cla
	minut += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/Swamp/dancesexson.jpg'
	gs 'zz_render','','','Как только парни отошли от вас, вы моментально отрубились не одеваясь и не меняя позы...'
	act 'Проснуться':
		*clr & cla
		minut += 600
		son += 20
		health += 50
		manna += 50
		gs 'stat'
		gs 'zz_render','','images/zsoft/pod_ezd/shulgahome/bigroom/drunk_ev/pohmel1.jpg'
		gs 'zz_render','','','Вы проспали некоторое время, проснувшись растрепанная еле оторвали голову от подушки. Голова болела и вы смутно помнили, что вчера происходило.'
		act 'Далее': gt'swamphouse'
	end
}
$hantersgrAOsa = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrAOsa.jpg'
	gs 'zz_render','','','Парни положили вас на спину, Игорь задрав вам ноги, принялся пристраиваться к вашей попе, а Андрей и Сергей стали над вами выставив свои члены перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	lubonus += 2
	gs 'zz_render','','','Игорь кончил и пошел за стол.'
	hantsexa = rand(1,2)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 4:act 'Лечь на бок':dynamic $hantersgr2VaOs
	if health > 50 and hantsexa = 1 and hantsexb <= 4:act 'Лечь на бок':dynamic $hantersgr2VaO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2DPVaAs
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2DPVaA
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2VaOi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2VaOi.jpg'
	gs 'zz_render','','','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь стал над вами выставив свой член перед вашим лицом. Кончивший ранее Сергей просто с интересом наблюдает...'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2VaOi
	if health > 50 and hantsexa = 1 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2VO
	if health > 50 and hantsexa = 1 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2VOi
	if health > 50 and hantsexa = 2 and hantsexb <= 4:act 'Стать на четвереньки':dynamic $hantersgr2ViOa
	if health > 50 and hantsexa = 2 and hantsexb > 4:act 'Стать на четвереньки':dynamic $hantersgr2ViO
	if health > 50 and hantsexa = 3:act 'Лечь на спину':dynamic $hantersgrO2
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2VOi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2VOi.jpg'
	gs 'zz_render','','','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь стал над вами выставив свой член перед вашим лицом. Кончивший ранее Сергей просто с интересом наблюдает...'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','Андрей кончил и отошел'
	if health > 50:act 'Лечь на спину':dynamic $hantersgr1Ai
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2VO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2VO.jpg'
	gs 'zz_render','','','Парни положили вас на топчан, Андрей начал пристраиваться между ног, а Игорь стал над вами выставив свой член перед вашим лицом.Кончивший ранее Сергей просто с интересом наблюдает...'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Парни кончили и пошли все вместе за стол.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgr2ViOa = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2ViOa1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вас поставили на четвереньки. Игорь начал пристраиваться сзади, а Андрей стал перед вами выставив свои член перед вашим лицом. Сергей с интересом наблюдает...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsex = 0: boyCsex = 1 & sex += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2VaOi
	if health > 50 and hantsexa = 1 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2VO
	if health > 50 and hantsexa = 1 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2VOi
	if health > 50 and hantsexa = 2 and hantsexb <= 4:act 'Стать на четвереньки':dynamic $hantersgr2ViOa
	if health > 50 and hantsexa = 2 and hantsexb > 4:act 'Стать на четвереньки':dynamic $hantersgr2ViO
	if health > 50 and hantsexa = 3:act 'Лечь на спину':dynamic $hantersgrO2
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2ViO = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2ViO.jpg'
	gs 'zz_render','','','Вас поставили на четвереньки. Игорь начал пристраиваться сзади, а Андрей стал перед вами выставив свои член перед вашим лицом. Сергей с интересом наблюдает...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsex = 0: boyCsex = 1 & sex += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Андрей кончил и отошел в сторону, а вы продолжили с Игорем.'
	if health > 50:act 'Лечь на спину':dynamic $hantersgr1Ai
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2VsO = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2VsO.jpg'
	gs 'zz_render','','','Сергей сел на топчан, потянув вас за собой, а Игорь стал перед вами выставив член перед вашим лицом...'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsex = 0: boyBsex = 1 & sex += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Игорь кончил и вырубился, а вы продолжили с Сергеем.'
	if health > 50:act 'Сесть сверху':dynamic $hantersgr1As
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2VaOs = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2VaOs.jpg'
	gs 'zz_render','','','Андрей положил вас на бок и начал пристраиваться между ног, а Сергей стал перед вами выставив член перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(1,2)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 4:act 'Лечь на бок':dynamic $hantersgr2VaOs
	if health > 50 and hantsexa = 1 and hantsexb <= 4:act 'Лечь на бок':dynamic $hantersgr2VaO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2DPVaAs
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2DPVaA
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2VaO = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2VaO.jpg'
	gs 'zz_render','','','Андрей положил вас на бок и начал пристраиваться между ног, а Сергей стал перед вами выставив член перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Андрей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	swallow += 1
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Сергей кончил и отошел в сторону, вы продолжили с Андреем.'
	hantsexa = rand(1,3)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr1Va
	if health > 50 and hantsexa = 2:act 'Лечь на спину':dynamic $hantersgrO1
	if health > 50 and hantsexa = 3:act 'Сесть сверху':dynamic $hantersgr1Aa
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2AiOs = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2AiOs.jpg'
	gs 'zz_render','','','Парни положили вас на спину, Игорь задрав вам ноги, принялся пристраиваться к вашей попе, а Сергей стал над вами выставив свой член перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	hantsexa = rand(1,3)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr2VsO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Лечь на спину':dynamic $hantersgr2AiOs
	if health > 50 and hantsexa = 2 and hantsexb = 5:act 'Лечь на спину':dynamic $hantersgr2AiO
	if health > 50 and hantsexa = 2 and hantsexb < 5:act 'Лечь на спину':dynamic $hantersgr2AOs
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2AOi
	if health > 50 and hantsexa = 3 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2AsO
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2AOs = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2AOs.jpg'
	gs 'zz_render','','','Парни положили вас на спину, Игорь задрав вам ноги, принялся пристраиваться к вашей попе, а Сергей стал над вами выставив свой член перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	lubonus += 2
	gs 'zz_render','','','Игорь кончил и отрубился, вы остались с Сергеем.'
	if health > 50:act 'Сесть сверху':dynamic $hantersgr1As
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2AiO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2AiO.jpg'
	gs 'zz_render','','','Парни положили вас на спину, Игорь задрав вам ноги, принялся пристраиваться к вашей попе, а Сергей стал над вами выставив свой член перед вашим лицом...'
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	$boy = 'Сергей'
	silavag = 1
	dick = 18
	swallow += 1
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Сергей кончил и отошел, вы остались с Игорем.'
	if health > 50:act 'Лечь на спину':dynamic $hantersgr1Ai
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2AOi = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2AOi.jpg'
	gs 'zz_render','','','Сергей сел на топчан, потянув вас за собой, а Игорь стал перед вами выставив свой член перед вашим лицом...'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','Сергей кончил и ушел за стол к Андрею, вы остались с Игорем.'
	if health > 50:act 'Лечь на спину':dynamic $hantersgr1Ai
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2AsO = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2AsO.jpg'
	gs 'zz_render','','','Сергей сел на топчан, потянув вас за собой, а Игорь стал перед вами выставив свой член перед вашим лицом...'
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'bj'
	$boy = 'Сергей'
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	$boy = 'Игорь'
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Игорь кончил и ушел за стол к Андрею, вы остались с Сергеем.'
	if health > 50:act 'Сесть сверху':dynamic $hantersgr1As
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2DPVaAs = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2DPVaAs1.'+rand(1,3)+'.jpg'
	gs 'zz_render','','','Андрей лёг на топчан, потянув вас за собой, Сергей сразу же начал пристраиваться к вашей второй дырочке...'
	$boy = 'Андрей'
	$boy2 = 'Сергей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	dick = 20
	dick2 = 18
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration', 1
	hantsexa = rand(1,2)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb > 4:act 'Лечь на бок':dynamic $hantersgr2VaOs
	if health > 50 and hantsexa = 1 and hantsexb <= 4:act 'Лечь на бок':dynamic $hantersgr2VaO
	if health > 50 and hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgr2DPVaAs
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Сесть сверху':dynamic $hantersgr2DPVaA
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgr2DPVaA = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr2DPVaA.jpg'
	gs 'zz_render','','','Андрей лёг на топчан, потянув вас за собой, Сергей сразу же начал пристраиваться к вашей второй дырочке...'
	$boy = 'Андрей'
	$boy2 = 'Сергей'
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	dick = 20
	dick2 = 18
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration', 1
	gs 'zz_render','','','Через некоторое время <<$boy2>> застонал и вы почувствовали как вашу попу наполняет тепло. Он кончил и ушел на улицу, вы остались с Андреем'
	lubonus += 2
	gs 'zz_funcs', 'cum', 'anus'
	hantsexa = rand(1,3)
	if health > 50 and hantsexa = 1:act 'Сесть сверху':dynamic $hantersgr1Va
	if health > 50 and hantsexa = 2:act 'Лечь на спину':dynamic $hantersgrO1
	if health > 50 and hantsexa = 3:act 'Сесть сверху':dynamic $hantersgr1Aa
	if health <= 50:act 'Потерять сознание':dynamic $hantersexfaint
}
$hantersgrO2 = {
	*clr & cla
	minut += 1
	pose = 0
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrO2cum1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Сергей с Игорем положили вас на спину и тут же струи спермы ударили в ваш рот и лицо.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgr1Va = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr1Va.jpg'
	gs 'zz_render','','','Андрей сел на топчан, потянув вас за собой, вы уселись сверху на его член...'
	$boy = 'Андрей'
	silavag = 0
	dick = 20
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','Андрей кончил и ушел к столу.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgr1Ai = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr1Ai.jpg'
	gs 'zz_render','','','Игорь положил вас на спину и принялся пристраиваться к вашей попе...'
	$boy = 'Игорь'
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	silavag = 2
	dick = 16
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','Игорь кончил и пошел спать.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgr1Aa = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr1Aa.jpg'
	gs 'zz_render','','','Андрей поставил вас на четвереньки и начал пристраиваться сзади...'
	$boy = 'Андрей'
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	silavag = 0
	dick = 20
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','Андрей кончил и ушел на улицу курить.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgr1As = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgr1As.jpg'
	gs 'zz_render','','','Андрей сел на топчан, потянув вас за собой, вы уселись сверху на его член...'
	$boy = 'Сергей'
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	silavag = 1
	dick = 18
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	gs 'zz_render','','','Сергей кончил и ушел.'
	act 'Вырубиться': dynamic $hantersgrEND
}
$hantersgrO1 = {
	*clr & cla
	minut += 1
	pose = 0
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/dancesex/hantersgrO1cum.jpg'
	gs 'zz_render','','','Андрей положил вас на спину и тут же накачал кончать. Струи спермы ударили в ваш рот, попав и на лицо и на волосы. Кончив Андрей ушел, оставив вас одну...'
	act 'Вырубиться': dynamic $hantersgrEND
}
! потеря сознания
$hantersexfaint = {
	*clr & cla
	minut += 1
	horny += rand(5,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupfaint.jpg'
	gs 'zz_render','','','Вдруг от нестерпимой боли в глазах у вас потемнело, мир закружился и вы потеряли сознание...'
	if hantersRape = 4 or hantdanceslut = 4:
		act 'Очнуться':
			*clr & cla
			minut += 10
			health = 100
			manna += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupfaint1.jpg'
			gs 'zz_render','','','Вы очнулись от потока воды, вылившегося на вас...'
			gs 'zz_render','','','-Ну что, Света, живая? - спросил Андрей убедившись, что вы пришли в себя.'
			gs 'zz_render','','','Вы слабо качнули головой.'
			gs 'zz_render','','','-Ну и дадно, - сказал он и отошел в сторону.'
			act 'Далее': gt $loc, $metka
		end
	else
		act 'Очнуться':
			*clr & cla
			minut += 10
			health = 100
			manna += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupfaint2.jpg'
			gs 'zz_render','','','Вы очнулись от легкого похлопывания по щекам...'
			gs 'zz_render','','','-Ну что, Светик, ты как, живая? - спросил Андрей убедившись, что вы пришли в себя.'
			gs 'zz_render','','','Вы слабо качнули головой.'
			gs 'zz_render','','','-Напугала ты нас, признаться, пиздец, - сказал он и отошел в сторону. - Иди в избушку, отдохни.'
			act 'Далее': gt'swamphouse'
		end
	end
}