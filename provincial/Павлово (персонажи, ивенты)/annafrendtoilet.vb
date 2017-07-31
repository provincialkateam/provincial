minut += 10
piss +=1
gs'stat'
if gennpc = 0:$annafrendname = 'Аней' & $annafrendname2 = 'Аня'
if gennpc = 1:$annafrendname = 'Леной' & $annafrendname2 = 'Лена'
if gennpc = 2:$annafrendname = 'Ирой' & $annafrendname2 = 'Ира'
gs 'zz_render', '', 'pavlovo/family/sister/friends/' + $sister['location'] + '_piss_' + rand(1,4) + '.jpg', 'Вы пошли с <<$annafrendname>> '+iif($sister['location'] = 'gdk','за угол клуба',iif($sister['location'] = 'glake','в ближайшие заросли','в туалет'))+'. <<$annafrendname2>> '+iif($sister['location'] = 'gdk','огляделась, задрала юбку, спустила колготки',iif($sister['location'] = 'glake','огляделась','задрала юбку, спустила колготки'))+' и села на '+iif($sister['location'] = 'cafe_parco','унитаз','корточки')+'. Между ног хлынула целым потоком струя'+iif($sister['location'] = 'cafe_parco',', исчезая в унитазе',' на землю')+'.'
if hour <= 16:act 'Пить пиво дальше':gt 'annafrends'
act 'Уйти':
	if $sister['location'] = 'gdk':gt 'gdk'
	if $sister['location'] = 'glake':gt 'glake'
	if $sister['location'] = 'cafe_parco':gt 'cafe_parco', 'inner'
end