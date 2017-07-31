if $args[0] = 'main':
	$local_metka = $ARGS[0]
	*clr & cla
	if $loc = 'mey_home':
		if $metka = 6:
			if hour < 7:
				gs 'zz_render','Вика Мейнольд','images/wannabe/mey_vika/<<$vika_state>>_talk.jpg', '<do>- Все, <<$name>>, спать пора.</do> - говорит Вика.'
			elseif hour >= 20 and hour <= 22:
				gs 'zz_render','Вика Мейнольд','images/wannabe/mey_vika/<<$vika_state>>_talk.jpg', '<do>- <<$name>>, ты меня совем заболтала! Мы же так танцы пропустим! А ну бегом в ДК!</do> - говорит Вика.'
				act 'Пойти на танцы':
					minut += 10
					killvar '$vika_state'
					killvar '$vika_state_talk'
					gt 'gdkin'
				end
			elseif hour = 23:
				gs 'zz_render','','images/wannabe/mey_vika/vika_ivan.jpg', 'Вы заходите в комнату. Завидев вас, Вика расплывается в улыбке: <do>- <<$name>>, давай к нам!</do>'
				act 'Присесть': gs 'mey_vika_talk', 'vika_ivan'
			elseif week < 6 and (hour = 8 and minut < 30):
				gs 'zz_render','Вика Мейнольд','images/wannabe/mey_vika/<<$vika_state>>_talk.jpg', '<do>- <<$name>>!! Я из-за твоей болтовни не успею позавтракать!</do> - фыркает Вика и убегает на кухню.'
			else
				gs 'mey_vika_talk' , 'actions'
			end
		end
		if $metka = 2:
			if (hour = 7 and minut < 30):
				gs 'mey_vika_talk' , 'actions'
			else
				gs 'zz_render','Вика Мейнольд','images/wannabe/mey_vika/<<$vika_state>>_talk.jpg', '<do>- <<$name>>! Я из-за твоей болтовни не успею одеться и пожрать по человечьи перед школой!</do> - сердится Вика и убегает к себе в комнату.'
			end
		end
		if $metka = 1:
			if hour = 8 and minut < 30:
				gs 'mey_vika_talk' , 'actions'
			else
				gs 'zz_render','Вика Мейнольд','images/wannabe/mey_vika/<<$vika_state>>_talk.jpg', '<do>- <<$name>>! Ну хватит трепаться!! Мы же уже в школу опаздываем!!</do> - сердится Вика.'
			end
		end
		else
		gs 'mey_vika_talk' , 'actions'
	end
	act '<B>Отойти</B>': gs 'mey_vika_talk', 'exit'
end
if $args[0] = 'actions':
	act 'Болтать':
		gs 'npc_editor','change_rep','+',15
		minut += 15
		gs 'stat'
		gs 'mey_vika_talk', 'talk'
	end
	gs 'npc_editor','get_npc_profile',15
end
if $args[0] = 'description':
	$_desc = ''
	if $loc = 'mey_home':
		if $metka = 6:
			if $vika_state = 'homework': $vika_state_talk = 'отрывает свой взгляд от учебника'
			if $vika_state = 'go_school': $vika_state_talk = 'прекращает собираться'
			if $vika_state = 'relax': $vika_state_talk = 'замечает, что вы зашли в комнату, принимает полулежащую позу'
		elseif $metka = 2:
			$vika_state = 'bathroom'
			$vika_state_talk = 'выключает воду в душе, поворачивается'
		elseif $metka = 1:
			$vika_state = 'kitchen'
			$vika_state_talk = ' уминает за обе щеки завтрак. <dh>-И как эта злыдня столько жрёт - и не толстеет?</dh> - с лёгкой завистью думается вам. Тем временем Вика отрывается от еды'
		end
		$_desc += '<br>Вика <<$vika_state_talk>> и с улыбкой смотрит на вас.'
	end
	gs 'zz_render','Вика Мейнольд','images/wannabe/mey_vika/<<$vika_state>>.jpg', $_desc
	killvar '$_desc'
end
if $args[0] = 'talk':
	*clr & cla
  if $metka = 6:
    $vika_state = 'homework'
	elseif $metka = 2:
		$vika_state = 'bathroom'
	elseif $metka = 1:
		$vika_state = 'kitchen'
	end
	act '<B>Закончить разговор</B>': gs 'mey_vika_talk', $local_metka
	$_talk[0] = 'Вы болтаете с Вичкой о всякой ерунде и сплетничаете.'
	$_talk[1] = 'Вы болтаете с Викой, обсуждая школу и планы на будущее: <dh>- Вик, а ты думала о после того, как школу закончим, а?</dh><br/>Вика легкомысленно машет рукой, тряхнув буйной рыжей гривой: <do>- А! Поживём - увидим! Буду я ещё себе голову всяким забивать! В порнухе сниматься пойду!</do> - хихикает она.'
	$_talk[2] = 'Вы расспрашиваете подругу о Тамаре Михайловне:<br/><dh>- Мама - потрясная!</dh> - искренне широко улыбается Вика. <dh>- Она - как лучшая подруга! Если не косячить - она всё разрешает! Но вот за проступки дрючит жёстко, да...</dh>'
	gs 'zz_render','','images/wannabe/mey_vika/<<$vika_state>>_talk.jpg', $_talk[rand(0,2)]
	killvar '$_talk'
  killvar '$vika_state'
end
if $args[0] = 'vika_ivan':
	$local_metka = $ARGS[0]
	*clr & cla
	gs 'zz_render','','images/wannabe/mey_vika/vika_ivan_seat.jpg', 'Вы присаживаетесь к ним и слушаете их беседу.'
	act 'Болтать с Викой':
		if hour = 23:
			$vika_state = 'vika_ivan'
			gs 'npc_editor','change_rep','+',15
			minut += 15
			gs 'stat'
			gs 'mey_vika_talk', 'talk'
		else
			gs 'mey_vika_talk', 'main'
		end
	end
	act '<B>Уйти</B>': gs 'mey_vika_talk', 'exit'
end
if $args[0] = 'sleep':
	*clr & cla
	minut += 1
	gs 'zz_render','','images/wannabe/mey_vika/sleep.jpg', 'Вы подходите и смотрите как спит Вика. Как обычно Вичка дрыхнет нагишом - она вообще, похоже, одевается лишь при крайней неоходимости. <br><dh>- Наверное не стоит её сейчас тревожить.</dh> - думаете вы.'
	act '<B>Уйти</B>': gt $loc, $metka
end
if $args[0] = 'exit':
	minut += 1
	killvar '$vika_state'
	killvar '$vika_state_talk'
	gt $loc, $metka
end