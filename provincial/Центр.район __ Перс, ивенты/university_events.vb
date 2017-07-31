!подготовительные курсы
if $ARGS[0] = 'preparatory_classes':
	*clr & cla
	minut += 60
	school['intellect'] += 1
	gs'stat'
	gs 'zz_render', 'Университет', 'city/center/university/lecture/preparatory_classes'+iif(glass <= 0,0,1)+'.jpg','Вы занимались на подготовительных курсах в течение двух часов'+iif(intel >=100,', но ничего нового не почерпнули.','.')
	act 'Выйти из аудитории': gt'university','start'
end
!вступительный экзамен
if $ARGS[0] = 'entrance_exam':
	*clr & cla
	university['entrance_exam'] = year
	if school['certificate'] = 2:
		minut += 10
		university['student'] = 2
		university['course'] = 1
		university['semester'] = 1
		university['scholarship'] = 7000
		university['abiturient'] = 0
		gs'stat'
		gs 'zz_render', 'Университет', 'city/center/university/exam/result2.jpg','Благодаря золотой медали за окончание школы, вас зачислили в университет без сдачи экзаменов и назначили стипендию в размере <<university[''scholarship'']>> рублей.'
		act 'Выйти из аудитории': gt'university','start'
	else
		minut += 60
		university['stat'] = intel + school['progress'] + vnesh/10 - alko*10
		university['student'] = iif(university['stat'] < 150,0,iif(university['stat'] < 170,1,2))
		gs'stat'
		gs 'zz_render', 'Университет', 'city/center/university/exam/exam'+iif(glass <= 0,0,1)+'.jpg','В течении часа вы сдавали вступительный экзамен в университет.'
		act 'Узнать результат':
			*clr & cla
			minut += 60
			if university['student'] = 2:
				university['course'] = 1
				university['semester'] = 1
				university['scholarship'] = 5000
				university['abiturient'] = 0
			end
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/exam/result<<university[''student'']>>.jpg', 'Через час, в холле вывесили результаты экзаменов.'+iif(university['student'] = 0,' Вы завалили вступительные экзамены. Можно попытаться поступить ещё раз, но уже только в следущем году.',iif(university['student'] = 1,' Вы неплохо сдали экзамен, но к сожалению не смогли поступить на бесплатное отделение. Теперь вам нужно оплатить обучение в бухгалтерии университета.',' Вы успешно сдали вступительные экзамены и можете приступить к обучению с сентября. Вам назначена стипендия в размере <<university[''scholarship'']>> рублей.'))
			act 'Отойти': gt'university','start'
		end
	end
end
!лекции
if $ARGS[0] = 'lecture':
	*clr & cla
	if (hour > 8 and args = 1 or hour > 12 and args = 2): university['progress'] -= 1
	school['intellect'] += 1
	gs 'zz_render', 'Университет', 'city/center/university/lecture/lecture'+rand(1,5)+'.jpg', iif(hour > 9 and args = 1 or hour > 13 and args = 2,'Вы опаздали на лекцию и преподаватель смотрит на вас с осуждением, пока вы занимаете своё место.','Вы сидите в аудитории на лекции.')
	if alko < 3:
		act 'Слушать лекцию':
			*clr & cla
			if rand(1,8) >= son: gt'university_events','sleep',1
			if horny <= 75 and manna >= 40 and son > 8:
				university['progress'] += intel/40
				school['intellect'] += 1
			end
			minut += 180
			hour = iif(args = 1,12,16)
			minut = 0
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/lecture/'+iif(horny > 75,'_horny',iif(manna < 40,'_phone',iif(son <= 8,'_sleepy',iif(university['progress'] >= 100,'_successful','attentive'))))+'.jpg', 'Вы слушаете преподавателя'+iif(horny > 75,', но возбуждение не даёт вам сосредоточится на предмете изучения, и вы всю лекцию витаете в облаках, думая о чём-то своём.',iif(manna >= 20,', но скверное настроение мешает вам сосредоточиться на учёбе и вы откровенно скучаете, пытаясь его поднять копаясь в своём смартфоне.',iif(son <= 8,', но вам хочется и спать, и вы всю лекцию боретесь со сном, пытаясь не уснуть. О получении новых знаний речи вообще не идёт.',iif(university['progress'] >=100,', но ничего нового для себя не почерпнули.',', сосредоточенно впитывая новые знания.'))))
			if manna < 40: manna += 20
			act 'Выйти из аудитории': gt'university','start'
		end
	end
	if alko < 6:
		act 'Болтать':
			*clr & cla
			if rand(1,iif(alko < 3,8,iif(alko < 6,12,16))) >= son: gt'university_events','sleep',2
			university['progress'] += intel/80
			school['intellect'] += rand(0,1)
			manna += 20
			minut += 180
			hour = iif(args = 1,12,16)
			minut = 0
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/lecture/talk.jpg', 'Вы слушаете преподавателя в пол уха, сосредотовчишь в основном не на учёбе, а на болтовне с одногрупниками.'
			act 'Выйти из аудитории': gt'university','start'
		end
	end
	if son < 18 or alko >= 6: act 'Спать': gt'university_events','sleep'
end
!сон на лекции
if $ARGS[0] = 'sleep':
	*clr & cla
	minut += 180
	son += 9
	hour = iif(args = 1,12,16)
	minut = 0
	gs 'zz_render', 'Университет', 'city/center/university/lecture/sleep'+iif(alko > 0,'_alko','')+'.jpg', iif(args = 0,'Вы решаете, что сон самое лучшее времяпровождение на занятиях и, устроившись поудобнее, погружаетесь в сон до конца лекций.',iif(args = 1,'Вы слушаете лекцию, пытаясь вникнуть в суть темы, но незаметно для себя погружаетесь в сон, так и проспав до конца лекций.','Вы пытаетесь поддерживать разговор с одногрупниками, но усталость берёт своё, и вы проваливаетесь в сон, буквально на полуслове, так и проспав до конца лекций.'))
	gs'stat'
	act 'Выйти из аудитории': gt'university','start'
end
if $ARGS[0] = 'exam':
	*clr & cla
	university['stat'] = university['progress'] + vnesh/10 - alko*10
	minut += 120
	gs'stat'
	gs 'zz_render', 'Университет', 'city/center/university/exam/exam'+iif(glass <= 0,0,1)+'.jpg','В течении двух часов вы сдавали экзамены, закрывая сессию.'
	act 'Узнать результат':
		*clr & cla
		minut += 60
		if university['student'] = 2: university['scholarship'] = iif(university['stat'] < 70,0,iif(university['stat'] < 80,3000,iif(university['stat'] < 90,5000,7000)))
		if university['vacation'] = 2:
			university['exam'] = iif(university['stat'] < 50,0,1)
			if university['exam'] = 1: university['semester'] = 2
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/exam/result<<university[''exam'']>>.jpg', 'Через час, в холле вывесили результаты экзаменов.'+iif(university['exam'] = 0,' Вы завалили экзамен. Но у вас есть возможность пересдать его, до конца сессии.',' Вы успешно сдали экзамены и закрыли сессию. Вас перевели во второй семестр'+iif(university['student'] = 2 and university['stat'] < 70,', но за невысокую успеваемость вас лишили степендии.',' и назначили стипендию в размере <<university[''scholarship'']>> рублей.'))
		elseif university['vacation'] = 3:
			university['exam'] = iif(university['stat'] < 50,1,iif(university['course_work'] < 100,2,3))
			if university['exam'] = 3:
				university['course'] = 2
				university['semester'] = 1
			end
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/exam/result'+iif(university['exam'] = 1,0,iif(university['exam'] = 2,3,4))+'.jpg', 'Через час, в холле вывесили результаты экзаменов.'+iif(university['exam'] < 2,' Вы завалили экзамен. Но у вас есть возможность пересдать его, до конца сессии.',' Вы успешно сдали экзамены'+iif(university['course_work'] < 100,', но курсовая работа у вас не готова. Для закрытия сессии вам нужно её сдать до конца месяца.',' и сдали курсовую работу, закрыв сессию. Вас перевели следующий курс'+iif(university['student'] = 2 and university['stat'] < 70,', но за невысокую успеваемость вас лишили степендии.',' и назначили стипендию в размере <<university[''scholarship'']>> рублей.')))
		elseif university['vacation'] = 5:
			university['exam'] = iif(university['stat'] < 50,3,4)
			if university['exam'] = 4: university['semester'] = 2
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/exam/result'+iif(university['exam'] = 3,0,4)+'.jpg', 'Через час, в холле вывесили результаты экзаменов.'+iif(university['exam'] < 4,' Вы завалили экзамен. Но у вас есть возможность пересдать его, до конца сессии.',' Вы успешно сдали экзамены и закрыли сессию. Вас перевели во второй семестр'+iif(university['student'] = 2 and university['stat'] < 70,', но за невысокую успеваемость вас лишили степендии.',' и назначили стипендию в размере <<university[''scholarship'']>> рублей.'))
		elseif university['vacation'] = 6:
			university['exam'] = iif(university['stat'] < 50,4,iif(university['graduate_work'] < 100,5,6))
			if university['exam'] = 6:
				university['student'] = 0
				university['diploma'] = 1
			end
			gs'stat'
			gs 'zz_render', 'Университет', 'city/center/university/exam/result'+iif(university['exam'] = 4,0,iif(university['exam'] = 2,3,5))+'.jpg', 'Через час, в холле вывесили результаты экзаменов.'+iif(university['exam'] < 5,' Вы завалили экзамен. Но у вас есть возможность пересдать его, до конца сессии.',' Вы успешно сдали экзамены'+iif(university['graduate_work'] < 100,', но дипломная работа у вас не готова. Для закрытия сессии вам защитить диплом до конца месяца.',' и защитили диплом, закрыв сессию. Вы закончили весь цикл обучения и вам вручили диплом в торжественной обстановке.'))
		end
		act 'Уйти': gt'university','start'
	end
end
!курсовая работа
if $args[0] = 'course_work':
	*clr & cla
	if glassqw = 1:
		gs 'zz_render', '', 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
		act 'Отложить книгу':gt $loc, $metka
	end
	if housr = 1 and args[1] = 1: elektro += 3
	university['work_memory'] = university['course_work']
	university['course_work'] = iif(alko >= 3,0,(university['progress'] + (intel/2) - alko*50)/50)
	if alko = 0:
		school['intellect'] += 1
		if $loc = 'university': university['course_work'] += 2
	end
	minut += 60
	gs'stat'
	if $loc = 'university':
		gs 'zz_render', 'Библиотека', 'city/center/university/work/library'+iif(komp = 0,iif(university['course_work'] = university['work_memory'],0,iif(glass <= 0,1,2)),iif(university['course_work'] = university['work_memory'],3,iif(glass <= 0,4,5)))+'.jpg'
	else
		if university['work_memory'] = university['course_work']:
			gs 'zz_render', '', 'city/center/university/work/fail'+iif(args[1] = 0,'','_komp')+iif(current_clothing = 0,tanga,2)+'.jpg'
		elseif university['course_work'] >= 100:
			gs 'zz_render', '', 'city/center/university/work/end'+iif(args[1] = 0,'','_komp')+iif(current_clothing = 0,tanga,2)+'.jpg'
		else
			gs 'zz_render', '', 'city/center/university/work/'+iif(args[1] = 0,'work'+iif(current_clothing = 0,tanga,rand(2,3)),'komp'+iif(current_clothing > 0,0,iif(tanga = 0,rand(1,3),4)))+'.jpg'
		end
	end
	gs 'zz_render', '', '', 'Вы, в течении часа, '+iif(university['work_memory'] = university['course_work'],'пытались писать курсовую работу, но так ничего нового и не написали.'+iif(alko = 0,' Вам просто не хватило знаний и интеллекта для этого.',iif(alko < 3,' Вам просто нехватило знаний и интеллекта, или лёгкое опьянение повлияло на это. А может и всё вместе взятое.','так как из-за опьянения ничего не соображали.')) ,'писали курсовую работу'+iif(university['course_work'] >= 100,' и наконец её закончили',' и продвинулись вперёд.'))
	act 'Закончить':gt $loc, $metka
end
!сдача курсовой
if $args[0] = 'course_work_end':
	*clr & cla
	university['course'] = 2
	university['semester'] = 1
	minut += 60
	gs'stat'
	gs 'zz_render', 'Деканат', 'city/center/university/exam/result4.jpg','Вы зашли в деканат и сдали свою курсовую работу, закрыв наконец сессию. Теперь смело можно отправляться на каникулы.'
	act 'Выйти из кабинета': gt'university','start'
end
!дипломная работа
if $args[0] = 'graduate_work':
	*clr & cla
	if glassqw = 1:
		gs 'zz_render', '', 'city/center/university/work/library0.jpg', '<b>Текст расплывается по странице, похоже вы испортили зрение. Нужно обратиться к окулисту.</b>'
		act 'Отложить книгу':gt $loc, $metka
	end
	if housr = 1 and args[1] = 1: elektro += 3
	university['work_memory'] = university['graduate_work']
	university['graduate_work'] = iif(alko >= 3,0,(university['progress'] + (intel/2) - alko*50)/75)
	if alko = 0:
		school['intellect'] += 1
		if $loc = 'university': university['graduate_work'] += 1
	end
	minut += 60
	gs'stat'
	if $loc = 'university':
		gs 'zz_render', 'Библиотека', 'city/center/university/work_library'+iif(args[1] = 0,iif(university['graduate_work'] = university['work_memory'],0,iif(glass <= 0,1,2)),iif(university['graduate_work'] = university['work_memory'],3,iif(glass <= 0,4,5)))+'.jpg'
	else
		if university['work_memory'] = university['graduate_work']:
			gs 'zz_render', '', 'city/center/university/work/fail'+iif(args[1] = 0,'','_komp')+iif(current_clothing = 0,tanga,2)+'.jpg'
		elseif university['graduate_work'] >= 100:
			gs 'zz_render', '', 'city/center/university/work/end'+iif(args[1] = 0,'','_komp')+iif(current_clothing = 0,tanga,2)+'.jpg'
		else
			gs 'zz_render', '', 'city/center/university/work/'+iif(args[1] = 0,iif(current_clothing = 0,tanga,rand(2,3)),'komp'+iif(current_clothing > 0,0,iif(tanga = 0,rand(1,3),4)))+'.jpg'
		end
	end
	gs 'zz_render', '', '', 'Вы, в течении часа, '+iif(university['work_memory'] = university['graduate_work'],'пытались писать дипломную работу, но так ничего нового и не написали.'+iif(alko = 0,' Вам просто не хватило знаний и интеллекта для этого.',iif(alko < 3,' Вам просто нехватило знаний и интеллекта, или лёгкое опьянение повлияло на это. А может и всё вместе взятое.','так как из-за опьянения ничего не соображали.')) ,'писали дипломную работу'+iif(university['graduate_work'] >= 100,' и наконец её закончили',' и продвинулись вперёд.'))
	act 'Закончить': gt $loc, $metka
end
!защита диплома
if $args[0] = 'graduate_work_end':
	*clr & cla
	university['course'] = 2
	university['semester'] = 1
	minut += 60
	gs'stat'
	gs 'zz_render', 'Деканат', 'city/center/university/exam/result5.jpg','Вы защитили диплом и закрыли сессию, закончив весь цикл обучения. Вам вручили диплом об окончании высшего учебного заведения.'
	act 'Выйти из кабинета': gt'university','start'
end
if $args[0] = 'payment_student':
	*clr & cla
	minut += 5
	money -= 50000
	university['payment'] = university['semester']
	gs'stat'
	gs 'zz_render', 'Университет', 'city/center/university/payment.jpg','Вы оплатили 50 тысяч за учёбу в этом семестре.'
	act 'Выйти из кабинета': gt'university','start'
end
if $args[0] = 'payment_abiturient':
	*clr & cla
	minut += 5
	money -= 15000
	university['abiturient'] = 1
	gs'stat'
	gs 'zz_render', 'Университет', 'city/center/university/payment.jpg','Вы оплатили 15 тысяч за подготовительные курсы. Занятия проходят с 8.00 до 21.00, по будним дням.'
	act 'Выйти из кабинета': gt'university','start'
end
!Кабинка туалета
if $args[0] = 'toilet_cubicle':
	*clr & cla
	minut += 1
	gs'stat'
	gs 'zz_render','Туалет','city/center/university/toilet/toilet_cubicle.jpg','Туалетная кабинка.'
	if horny >= 60: act 'Мастурбировать': gt'university_events','selfplay'
	act 'Выйти': gt'university','toilet'
end
!мастурбация в туалете
if $args[0] = 'selfplay':
	*clr & cla
	gs 'zz_render','Туалет','city/center/university/toilet/toilet_cubicle.jpg'
	act 'Ласкать клитор':
		*clr & cla
		minut += 5
		horny += iif(mastr < 50,10,20)
		if mastrOnce = 0: mastr += 1 & mastrOnce = 1
		gs'stat'
		gs 'zz_render','Туалет','city/center/university/toilet/selfplay_clitoris.gif','Вы опустили руку себе между ног и нащупали в складках своей мягкой и влажной киски маленький бугорок, прикосновения к которому очень приятны. Вы начали ласкать пальчиками этот бугорок и наслаждаться чувством приятного тепла охватывающего вас между ног.'+iif(horny >= 100,'**Внезапно вас будто бы ударило током и внизу живота начались приятные спазмы. Вы извиваетесь, закусив губу, чтобы не закричать от удовольствия на весь туалет.','')
		if horny >= 100:
			orgasm += 1
			horny = 0
			manna = 100
		end
		if horny >= 60:
			act'Передохнуть': gt'university_events','selfplay'
		else
			act 'Закончить': gt'university_events','toilet_cubicle'
		end
	end
	if vagina > 0:
		act 'Трахать себя пальчиками':
			*clr & cla
			minut += 5
			if mastrOnce = 0: mastr += 1 & mastrOnce = 1
			horny += iif(vagina > 10,5,iif(mastr < 50,15,30))
			gs'stat'
			gs 'zz_render','Туалет','city/center/university/toilet/selfplay_fingers.gif','Вы ввели пальчики в свою <<$vaginatipe2>> вагину и принялись водить ими туда-сюда.'+iif(vagina <= 10,' Ваша киска нежно обхватывает ваши пальчики и вы чувствуете приятно тепло разливающееся внизу живота.',' Ваша вагина довольно просторная и вам приходится довольно сильно потрудиться, чтобы хоть что-то ощущать от своих пальцев.')
			if horny >= 100:
				orgasm += 1
				horny = 0
				manna = 100
				mastr += 1
				gs 'zz_render','','','Внезапно вас будто ударило током и внизу живота начались приятные спазмы. Вы извиваетесь закусив губу, что бы не закричать на весь туалет от удовольствия.'
			end
			if horny >= 60:
				act'Передохнуть': gt'university_events','selfplay'
			else
				act 'Закончить': gt'university_events','toilet_cubicle'
			end
		end
		if dildo >= 1 or middildo = 1 or largedildo = 1 or bigdildo = 1 or extradildo = 1 or superdildo = 1 or maddildo = 1:
			if dildohand > 0:
				act 'Вставить дилдо в киску':
					*clr & cla
					dick = dildohand
					minut += 5
					protect = 1
					horny += 20
					gs'stat'
					gs 'zz_render','Туалет','city/center/university/toilet/selfplay_dildo'+rand(1,3)+'.gif','Вы порылись в сумочке и достали оттуда дилдо, длинной <<dildohand>> см.'
					gs 'zz_dynamic_sex','sex_start', 1
					gs 'zz_dynamic_sex', 'vaginal', 'dildo'
					if horny >= 60:
						act'Передохнуть': gt'university_events','selfplay'
					else
						act 'Закончить': gt'university_events','toilet_cubicle'
					end
				end
			end
			act iif(dildohand = 0,'Взять в сумочке дилдо','Выбрать другой дилдо'):
				*clr & cla
				minut += 1
				gs'stat'
				gs 'zz_render','Туалет','city/center/university/toilet/toilet_cubicle.jpg'
				if dildo = 1 and dildohand ! 10:
					gs 'zz_render', '', '','У вас есть маленький дилдо длинной 10 см.'
					act 'Взять 10ти сантиметровый дилдо':dildohand = 10 & gt'university_events','selfplay'
				end
				if middildo = 1 and dildohand ! 15:
					gs 'zz_render', '', '','У вас есть дилдо длинной 15 см.'
					act 'Взять 15ти сантиметровый дилдо':dildohand = 15 & gt'university_events','selfplay'
				end
				if largedildo = 1 and dildohand ! 20:
					gs 'zz_render', '', '','У вас есть дилдо длинной 20 см.'
					act 'Взять 20ти сантиметровый дилдо':dildohand = 20 & gt'university_events','selfplay'
				end
				if bigdildo = 1 and dildohand ! 25:
					gs 'zz_render', '', '','У вас есть дилдо длинной 25 см.'
					act 'Взять 25ти сантиметровый дилдо':dildohand = 25 & gt'university_events','selfplay'
				end
				if extradildo = 1 and dildohand ! 30:
					gs 'zz_render', '', '','У вас есть дилдо длинной 30 см.'
					act 'Взять 30ти сантиметровый дилдо':dildohand = 30 & gt'university_events','selfplay'
				end
				if superdildo = 1 and dildohand ! 35:
					gs 'zz_render', '', '','У вас есть дилдо длинной 35 см.'
					act 'Взять 35ти сантиметровый дилдо':dildohand = 35 & gt'university_events','selfplay'
				end
				if maddildo = 1 and dildohand ! 40:
					gs 'zz_render', '', '','У вас есть дилдо длинной 40 см.'
					act 'Взять 40ти сантиметровый дилдо':dildohand = 40 & gt'university_events','selfplay'
				end
				act'Передумать': gt'university_events','selfplay'
			end
		end
	end
	act 'Отказаться от этой затеи': gt'university_events','toilet_cubicle'
end
! каникулы и отчисление
if $args[0] = 'university_status':
	if university['progress'] > 100: university['progress'] = 100
	if university['progress'] < 0: university['progress'] = 0
	university['vacation'] = 0
	if university['student'] > 0:
		if month = 8 and university['course'] = 1 and university['exam'] = 0:
			$holiday = '<b>Летние каникулы (до 31.08)</b>' & university['vacation'] = 1
		elseif month = 1 and university['course'] = 1:
			$holiday = '<b>'+iif(university['exam'] = 0,'Зимняя сессия','Зимние каникулы')+' (1.01-31.01)</b>' & university['vacation'] = 2
		elseif month = 6 and university['course'] = 1:
			$holiday = '<b>Летняя сессия(1.06-30.06)</b>' & university['vacation'] = 3
		elseif month >= 6 and month <= 8 and university['course'] = 2:
			$holiday = '<b>Летние каникулы(1.06-31.08)</b>' & university['vacation'] = 4
		elseif month = 1 and university['course'] = 2:
			$holiday = '<b>'+iif(university['exam'] < 4,'Зимняя сессия','Зимние каникулы')+' (1.01-31.01)</b>' & university['vacation'] = 5
		elseif month = 6 and university['course'] = 2:
			$holiday = '<b>Летняя сессия(1.06-30.06)</b>' & university['vacation'] = 6
		end
		if (university['vacation'] = 0 or university['vacation'] = 4 and month > 6) and university['student'] = 1 and university['payment'] ! university['semester']:
			university['student'] = 0
			university['exam'] = 0
			university['course_work'] = 0
			university['graduate_work'] = 0
			university['semester'] = 0
			'<font color=red><b>Вас отчислили из университета, так как вы не оплатили учёбу.</b></font>'
		end
		if month = 2 and university['semester'] = 1 or month = 7  and university['semester'] = 2:
			university['student'] = 0
			university['exam'] = 0
			university['course_work'] = 0
			university['graduate_work'] = 0
			university['semester'] = 0
			'<font color=red><b>Вы завалили сессию и вас отчислили из университета.</b></font>'
		end
	end
end