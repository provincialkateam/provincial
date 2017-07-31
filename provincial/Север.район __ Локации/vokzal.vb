$metka = $ARGS[0]
$loc = $CURLOC
*clr
gs 'stat'
act 'Туалет': minut += 5 & gt 'zz_toilet', 'main'
act 'В город': minut += 5 & gt 'nord'
gs 'zz_render','Северный Вокзал','images/pic/vokzalholle.jpg'
!if rand(1,100) > 70: gs 'zz_render','','','Вы видите <a href="exec:GT ''etoexhib'',''pos54''">подозрительную личность.</a>'
gs 'zz_train', 'train_tickets'