! nanny_act - action`s counter
! nanny_cleaning
! nanny_food
! nanny_story
! nanny_vika
! --- LOCATIONS --- !
if $ARGS[0] = 'hall':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	gs 'stat'
	'<center><b><font color = maroon>Прихожая</font></b></center>'
	'<center><img src="images/qwest/nord/clinic/misha/kor.jpg"></center>'
	if nanny_vika = 1:
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str1')
		act 'Уйти': gt 'nord'
	end
	act 'Комната Михаила': gt 'misha_inv', 'room'
	act 'Кухня': gt 'misha_inv', 'kitchen'
end
if $ARGS[0] = 'room':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	gs 'stat'
	'<center><b><font color = maroon>Комната Михаила</font></b></center>'
	'<center><img src="images/qwest/nord/clinic/misha/kom.jpg"></center>'
	if nanny_clean_day ! day:
		act 'Начать уборку':
			cla
			*clr
			nanny_cleaning = 1
			minut += 45
			nanny_clean_day = day
			manna -= 10
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/nord/clinic/misha/uborka.jpg', func('misha_inv_strings', 'local_str2')
			act 'Закончить уборку': gt $loc, $metka
		end
	end
	gs 'zz_render', '', '', func('misha_inv_strings', 'local_str3')
	act 'Выйти': gt 'misha_inv', 'hall'
end
if $ARGS[0] = 'kitchen':
	*clr & cla
	$metka = $ARGS[0]
	$loc = $CURLOC
	minut += 5
	gs 'stat'
	'<center><b><font color = maroon>Кухня</font></b></center>'
	'<center><img src="images/qwest/nord/clinic/misha/kuh.jpg"></center>'
	if nanny_cook_day ! day:
		act 'Приготовить еду':
			cla
			*clr
			minut += 45
			nanny_cook_day = day
			nanny_food = 1
			gs 'zz_render', '', 'images/qwest/nord/clinic/misha/gotovka.jpg', func('misha_inv_strings', 'local_str4')
			act '...': gt $loc, $metka
		end
	end
	act 'Выйти': gt 'misha_inv', 'hall'
end
! --- NPCs --- !
! --- nanny Vika --- !
if $args[0] = 'vika':
	VikaAge = age + 5
	gs 'zz_render', '', 'images/qwest/nord/clinic/vika/0.jpg', func('misha_inv_strings', 'local_str5')
	act'Поболтать':
		*clr & cla
		gs 'stat'
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str6')
		! strings array
		$zz_str[0] = 'Вы болтали с Викой, шутите, смеётесь. Она очень веселая девушка.'
		$zz_str[1] = 'Вы спросили у Вики про университет. Она сказала что учиться в медицинском на последнем курсе."'
		$zz_str[2] = 'Вы спросили у Вики про ее парня. Она заулыбалась: "Ну, у меня есть парень. Предстовляешь кажется он ревнует меня к Михаилу, говорит что я уже изменилась."'
		$zz_str[3] = 'Вы болтаете с Викой и она рассказывает вам, что ходила раньше на танцы, но из-за не хватки денег ей пришлось бросить танцы.'
		$zz_str[4] = 'Вы болтаете с Викой, обсуждая последние тенденции в моде.'
		$zz_str[5] = 'Вы болтаете с Викой и немного обсудили Михаила.'
		$zz_str[6] = 'Вы болтаете с Викой, она рассказала вам про Михаила что он хороший и щедрый человек.'
		! print random string
		gs 'zz_render','','qwest/nord/clinic/vika/1.jpg', $zz_str[rand(0,6)]
		! kill tmp variable
		killvar '$zz_str'
		! add action
		act '<B>Отойти</B>': gt 'misha_inv', 'hall'
	end
	act 'А вы никуда не опаздываете?':
		*clr & cla
		nanny_vika = 0
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/nord/clinic/vika/2.jpg', func('misha_inv_strings', 'local_str7')
		act 'За работу': gt 'misha_inv', 'hall'
	end
	act '<B>Отойти</B>': gt 'misha_inv', 'hall'
end
! --- Михаил --- !
if $args[0] = 'misha':
	MishaAge = age + 20
	gs 'zz_render', 'Михаил Алексеевич', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str8')
	act'Поболтать':
		*clr
		gs 'stat'
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str9')
		$zz_str[0] = 'Вы болтали с Михаилом узнали что он родился в Павлово, так же как и вы. Его семья переехала в сюда, когда ему было семь. В семье было четверо детей, он — старший. Он говорит что часто воспоминает о жизни, которую он вел до того, как перенес полиомиелит.'
		$zz_str[1] = 'В раннем возрасте у меня умерла сестра, Настя, умерла от пневмонии, тогда я уже несколько лет болел полиомиетитом, и с тех пор я не мог избавиться от чувства вины. Ему казалось, что родители, особенно мать, уделяли ему слишком много внимания и не заметили, что Карен нуждается в помощи, пока не стало слишком поздно. Ничто не указывало на то, что его опасения обоснованы, но избавиться от чувства вины Михаил так и не смог.'
		$zz_str[2] = 'Он расказывает что в детстве очень любил играть с соседскими детьми... Но болезнь обрушилась на меня когда мне было шесть лет, и я сразу же стал главной заботой своей семьи, особенно матери. Она полностью посвятила себя мне. На протяжении всех ранних лет моей жизни она ухаживала за мной с неизменной лаской и терпением.'
		$zz_str[3] = 'Несмотря на физические трудности, которые приходилось преодолевать, Михаил получил диплом специалиста по английскому языку в университете, и его поэтические произведения и статьи издавались. Он работал на текстовом процессоре с помощью палочки, которую держал ртом. Степень магистра он собирался получать по специальности журналиста, но вскоре начали сказываться последствия полиомиелита, поражающие мышцы. От учебы пришлось отказаться.'
		$zz_str[4] = 'Вы разговариваете с Михаилом, он рассказал вам про "железное легкое", что этот аппарат позволяет ему дышать, но он может обходиться без него несколько часов используя протативный респиратор и это зависит от того как он себя чувствует.'
		$zz_str[5] = 'Вы разговариваете с Михаилом, он рассказал вам что он ни то чтобы парализован, просто у него не работают мышцы.'
		$zz_str[6] = '- Вы верующая? - спросил он вас. - Да не особо, как то. - ответили вы. - А я все еще верю, — сказал он. — Нужно же мне хоть кого то обвинять во всем, что со мной происходит. - с улыбкой сказал он.'
		! print random string
		gs 'zz_render','','images/qwest/nord/clinic/misha/misha.jpg', $zz_str[rand(0,6)]
		! kill tmp variable
		killvar '$zz_str'
	end
	gs 'misha_inv', 'event2'
end
! --- EVENTS --- !
! starting event
if $ARGS[0] = 'event0':
	cla
	*clr
	gs 'stat'
	gs 'zz_render', 'Ваша коллега - Ольга', 'images/etogame/bukli_olga.jpg', func('misha_inv_strings', 'local_str10')
	nanny_act = 0
	act 'Пойти': gt 'misha_inv', 'event1'
end
if $ARGS[0] = 'event1':
	cla
	*clr
	nanny_act = 1
	buklinik = 11
	buklinikDay = day
	minut += 20
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/nord/clinic/vika/3.jpg', func('misha_inv_strings', 'local_str11')
	gs 'zz_render','','','- Вы из клиники милосердия?'
	gs 'zz_render', '', '', func('misha_inv_strings', 'local_str12')
	act 'Войти':
		*clr & cla
		gs 'zz_render', '', 'images/qwest/nord/clinic/misha/kor.jpg', func('misha_inv_strings', 'local_str13')
		act'Пойти за ней':
			*clr & cla
			gs 'zz_render', '', '', func('misha_inv_strings', 'local_str14')
			act'Смотреть':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/nord/clinic/vika/4.gif', func('misha_inv_strings', 'local_str15')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', '', func('misha_inv_strings', 'local_str16')
					act 'Не переживайте все будет хорошо': gt 'misha_inv', 'hall'
				end
			end
		end
	end
end
! entrance
if $args[0] = 'entrance':
	cla
	*clr
	buklinikDay = day
	minut += 20
	gs 'stat'
	gs 'zz_render','','images/qwest/nord/clinic/vika/'+iif(args[1]=0,5,3)
	if args[1] = 0:
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str17')
	end
	if args[1] = 1:
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str18')
	end
	if args[1] = 2 or args[1] = 4:
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str19')
	end
	if args[1] = 3:
		gs 'zz_render', '', '', func('misha_inv_strings', 'local_str20')
	end
	if args[1] = 5:
		if nanny_story = 1: gs 'zz_render', '', '', func('misha_inv_strings', 'local_str21')
		if MishaLove = 1: gs 'zz_render', '', '', func('misha_inv_strings', 'local_str22')
	end
	act '...': gt 'misha_inv', 'hall'
end
if $args[0] = 'event2':
	if nanny_cleaning = 1 and nanny_food = 1 and nanny_act = 1:
		act 'Я всё сделала':
			*clr & cla
			nanny_cleaning = 0
			nanny_food = 0
			nanny_act = 2
			bumtolik = 11
			gs 'zz_render', '', '', func('misha_inv_strings', 'local_str23')
			act 'Попрощаться и уйти': gt'buklinik', 'olga2'
		end
	end
	if nanny_cleaning = 1 and nanny_food = 1 and nanny_act = 2:
		act 'Я всё сделала':
			*clr & cla
			nanny_cleaning = 0
			nanny_food = 0
			nanny_act = 3
			gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str24')
			act'Спросить о Вике':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str25')
				act 'Ну а между вами что-то есть?':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str26')
					act 'Ладно я подумаю!':
						*clr & cla
						nanny_vika = 1
						bumtolik = 12
						gs 'zz_render', '', '', func('misha_inv_strings', 'local_str27')
						act'Уйти':gt'buklinik','olga2'
					end
					act 'Дождаться Вики':
						*clr & cla
						bumtolik = 3000
						gs 'zz_render', '', '', func('misha_inv_strings', 'local_str28')
						act 'Уйти': gt'buklinik','olga2'
					end
				end
			end
		end
	end
	if nanny_cleaning = 1 and nanny_food = 1 and nanny_act = 3 and nanny_vika = 0:
		act 'Насчёт вашей просьбы':
			cla
			*clr
			nanny_cleaning = 0
			nanny_food = 0
			nanny_act = 4
			bumtolik = 13
			buklinikDay = day
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str29')
			act'Давайте...':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str30')
				act 'А у вас есть хоть какой-нибудь опыт? ':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg"', func('misha_inv_strings', 'local_str31')
					act'Далее':
						*clr & cla
						minut += 15
						gs'stat'
						gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg"', func('misha_inv_strings', 'local_str32')
						act'Раздеть его':
							*clr & cla
							gs 'zz_render', '', '', func('misha_inv_strings', 'local_str33')
							act 'О, боже! что случилось?':
								*clr & cla
								gs 'zz_render', '', '', func('misha_inv_strings', 'local_str34')
								act 'Снять его штаны':
									*clr & cla
									horny+=5
									gs 'stat'
									gs 'zz_render', '', 'images/qwest/nord/clinic/misha/pants.gif', func('misha_inv_strings', 'local_str35')
									act'Раздеться самой':
										*clr & cla
										horny+=5
										gs 'stat'
										gs 'zz_render', '', '', func('misha_inv_strings', 'local_str36')
										act 'Далее':
											*clr & cla
												gs 'zz_render', '', '', func('misha_inv_strings', 'local_str37')
												act'Прикоснуться к нему':
												*clr & cla
												horny += 5
												gs 'stat'
												gs 'zz_render', '', '', func('misha_inv_strings', 'local_str38')
												act'Далее':
													*clr & cla
													horny += 5
													gs 'stat'
													gs 'zz_render', '', 'images/qwest/nord/clinic/misha/cum.gif', func('misha_inv_strings', 'local_str39')
													act 'Далее':
														*clr & cla
														gs 'zz_render', '', '', func('misha_inv_strings', 'local_str40')
														act'Дать свою грудь':
															*clr & cla
															horny += 5
															gs 'stat'
															gs 'zz_render', '', 'images/qwest/nord/clinic/misha/nipple.gif', func('misha_inv_strings', 'local_str41')
															act 'Ну на этом мы пока и закончим':
																*clr & cla
																nanny_vika = 1
																gs 'zz_render', '', '', func('misha_inv_strings', 'local_str42')
																act 'Уйти': gt 'buklinik', 'olga2'
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
	if nanny_cleaning = 1 and nanny_food = 1 and nanny_act = 4 and nanny_vika = 0:
		act'Ну что продолжим':
			cla
			*clr
			nanny_cleaning = 0
			nanny_food = 0
			nanny_act = 5
			bumtolik = 14
			buklinikDay = day
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str43')
			act'Раздеть его':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/nord/clinic/misha/pants.gif', func('misha_inv_strings', 'local_str44')
				act 'Раздеться самой':
					*clr & cla
					gs 'zz_render', '', '', func('misha_inv_strings', 'local_str45')
					act'Лечь на кровать':
						*clr & cla
						gs 'zz_render', '', '', func('misha_inv_strings', 'local_str46')
						act'Мне бы хотелось':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/nord/clinic/misha/tits.gif', func('misha_inv_strings', 'local_str47')
							act'Тебе нужен воздух?':
								*clr & cla
								gs 'zz_render', '', '', func('misha_inv_strings', 'local_str48')
								act'Выполнить просьбу':
									*clr & cla
									gs 'zz_render', '', '', func('misha_inv_strings', 'local_str49')
									act'Хочу куни':
										*clr & cla
										gs 'zz_render', '', 'images/qwest/nord/clinic/misha/facesitting.gif', func('misha_inv_strings', 'local_str50')
										act'Ускорить темп':
											*clr & cla
											gs 'zz_render', '', 'images/qwest/nord/clinic/misha/tube.gif', func('misha_inv_strings', 'local_str51')
											act'Сесть на член':
												*clr & cla
												gs'stat'
												gs 'zz_render', '', 'images/qwest/nord/clinic/misha/cum2.gif', func('misha_inv_strings', 'local_str52')
												act'Далее':
													*clr & cla
													gs 'zz_render', '', 'images/qwest/nord/clinic/misha/end.jpg', func('misha_inv_strings', 'local_str53')
													act'Нет':
														*clr & cla
														gs 'zz_render', '', 'images/qwest/nord/clinic/misha/end.jpg', func('misha_inv_strings', 'local_str54')
														act'Это прекрасно':
															*clr & cla
															gs'stat'
															gs 'zz_render', '', 'images/qwest/nord/clinic/misha/end.jpg', func('misha_inv_strings', 'local_str55')
															act'Ну на этом мы пока и закончим':
																*clr & cla
																nanny_vika = 1
																gs 'zz_render', '', '', func('misha_inv_strings', 'local_str56')
																act 'Уйти': gt'buklinik','olga2'
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
	if nanny_cleaning = 1 and nanny_food = 1 and nanny_act = 5 and nanny_vika = 0:
		act 'Ну что начнем':
			cla
			*clr
			nanny_cleaning = 0
			nanny_food = 0
			nanny_act = 6
			bumtolik = 15
			buklinikDay = day
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/nord/clinic/misha/Misha.jpg"', func('misha_inv_strings', 'local_str57')
			act'Снять одежду':
				*clr & cla
				gs 'zz_render', '', '', func('misha_inv_strings', 'local_str58')
				act'Далее':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/nord/clinic/misha/cum.gif', func('misha_inv_strings', 'local_str59')
					act'Далее':
						*clr & cla
						gs 'zz_render', '', '', func('misha_inv_strings', 'local_str60')
						act'Ввести член':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/nord/clinic/misha/sex.gif', func('misha_inv_strings', 'local_str61')
							act'Далее':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str62')
								act'Ну на этом сегодня мы закончим':
									*clr & cla
									nanny_vika = 1
									gs'stat'
									gs 'zz_render', '', '', func('misha_inv_strings', 'local_str63')
									act 'Уйти': gt 'buklinik', 'olga2'
								end
							end
						end
					end
				end
			end
		end
	end
	if nanny_act = 6 and nanny_vika = 0:
		act'Ну что начнем':
			cla
			*clr
			buklinikDay = day
			gs 'zz_render', '', '', func('misha_inv_strings', 'local_str64')
			act'Далее':
				*clr & cla
				gs 'zz_render', '', '', func('misha_inv_strings', 'local_str65')
				act'Конечно':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/nord/clinic/misha/lick.gif', func('misha_inv_strings', 'local_str66')
					act'Спуститься к члену':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/nord/clinic/misha/dickplay.gif', func('misha_inv_strings', 'local_str67')
						act'Сосать':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/nord/clinic/misha/suck.gif', func('misha_inv_strings', 'local_str68')
							act'Сесть на член':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/nord/clinic/misha/anal.gif', func('misha_inv_strings', 'local_str69')
								act'Тебе нужен кислород?':
									*clr & cla
									gs 'zz_render', '', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str70')
									act'Ждать Вику':
										*clr & cla
										nanny_vika = 1
										gs 'zz_render', '', '', func('misha_inv_strings', 'local_str71')
										act'Поцеловать в щеку':
											*clr & cla
											nanny_story = 1
											bumtolik = 16
											gs 'zz_render', '', 'images/qwest/nord/clinic/misha/kiss_cheek.jpg', func('misha_inv_strings', 'local_str72')
											act'Уйти': gt'buklinik','olga2'
										end
										act'Поцеловать в губы':
											*clr & cla
											nanny_story = 1
											bumtolik = 16
											MishaLove = 1
											gs 'zz_render', '', 'images/qwest/nord/clinic/misha/kiss_lips.gif', func('misha_inv_strings', 'local_str73')
											act 'Уйти': gt'buklinik', 'olga2'
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
	if nanny_cleaning = 1 and nanny_food = 1 and nanny_story = 1:
		act 'Я всё сделала':
			*clr & cla
			nanny_cleaning = 0
			nanny_food = 0
			gs 'zz_render', 'Михаил Алексеевич', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str74')
			act 'Слушать':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/nord/clinic/vika/massage.gif', func('misha_inv_strings', 'local_str75')
				act 'Дальше':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/nord/clinic/vika/massage2.gif', func('misha_inv_strings', 'local_str76')
					act 'Слушать':
						*clr & cla
						gs 'zz_render', '', 'images/qwest/nord/clinic/vika/6.gif', func('misha_inv_strings', 'local_str77')
						act 'Дальше':
							*clr & cla
							gs 'zz_render', '', 'images/qwest/nord/clinic/vika/shave.gif', func('misha_inv_strings', 'local_str78')
							act 'Дальше':
								*clr & cla
								gs 'zz_render', '', 'images/qwest/nord/clinic/vika/walk0.gif', func('misha_inv_strings', 'local_str79')
								act 'Дальше':
									*clr & cla
									gs 'zz_render', '', 'images/qwest/nord/clinic/vika/walk1.jpg', func('misha_inv_strings', 'local_str80')
									act 'Дальше':
										*clr & cla
										gs 'zz_render', '', 'images/qwest/nord/clinic/vika/walk2.jpg', func('misha_inv_strings', 'local_str81')
										act 'Дальше':
											*clr & cla
											gs 'zz_render', '', 'images/qwest/nord/clinic/vika/walk3.jpg', func('misha_inv_strings', 'local_str82')
											act 'Дальше':
												*clr & cla
												gs 'zz_render', '', 'images/qwest/nord/clinic/vika/6.gif', func('misha_inv_strings', 'local_str83')
												act 'Дальше':
													*clr & cla
													gs 'zz_render', '', 'images/qwest/nord/clinic/vika/kiss.gif', func('misha_inv_strings', 'local_str84')
													act 'И дальше что?':
														*clr & cla
														gs 'zz_render', '', 'images/qwest/nord/clinic/vika/picnic.gif', func('misha_inv_strings', 'local_str85')
														act 'Слушать дальше':
															*clr & cla
															gs 'zz_render', '', 'images/qwest/nord/clinic/vika/walk4.gif', func('misha_inv_strings', 'local_str86')
															act 'Ой, да ладно тебе':
																*clr & cla
																gs 'zz_render', 'Михаил Алексеевич', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str87')
																act 'Уйти': gt 'buklinik', 'olga2'
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
	if nanny_cleaning = 1 and nanny_food = 1 and MishaLove = 1:
		act 'Я всё сделала':
			*clr & cla
			nanny_cleaning = 0
			nanny_food = 0
			gs 'zz_render', 'Михаил Алексеевич', 'images/qwest/nord/clinic/misha/misha.jpg', func('misha_inv_strings', 'local_str88')
			act 'Уйти': gt 'buklinik', 'olga2'
		end
	end
	act '<B>Отойти</B>': gt 'misha_inv', 'room'
end