if $args[0] = 'local_str1': $result = iif($sister['location'] = 'cafe_parco','Бокалы быстро опустели','Полторашка пива была быстро выпита')+' и парни '+iif($sister['location'] = 'cafe_parco','заказали еще по одному для всех.','достали новую бутылку.')
if $args[0] = 'local_str2': $result = 'Аня подошла к вам. <do>"<<$name>>, пойдем в туалет."</do>'
if $args[0] = 'local_str3': $result = 'Лена подошла к вам. <do>"<<$name>>, ты не хочешь в туалет?"</do>'
if $args[0] = 'local_str4': $result = 'Ира подошла к вам. <do>"<<$name[1]>>, ты не хочешь сходить кое куда?"</do>'
if $args[0] = 'local_str5': $result = 'Пацаны пошли '+iif($sister['location'] = 'gdk','за угол клуба',iif($sister['location'] = 'glake','в ближайшие заросли','в туалет'))+', чтобы опорожнить мочевой пузырь оставив девчонок одних.'