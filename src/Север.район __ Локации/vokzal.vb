$metka = $ARGS[0]
$loc = $CURLOC
$control_point = 'north'
gs 'stat'
act 'Туалет': minut += 5 & gt 'zz_toilet', 'main'
act 'В город': minut += 5 & gt 'north'
gs 'zz_render','Северный Вокзал','images/pic/vokzalholle.jpg'
gs 'zz_train','train_tickets'