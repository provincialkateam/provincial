*clr & cla
act '<b>Закрыть</b>': gt $loc, $metka
!---
$_bag_text = ''
if greben > 0 and hapri = 0 and $settings['hapri_mod'] = 1: $_bag_text += 'У вас есть расческа. <a href="exec:minut += 3 & hapri = 1 & gs''stat''"><b>Причесаться</b></a>'
if salfetka > 0: $_bag_text += '**У вас есть влажные салфетки, <<salfetka>> штук. ' + iif(cumface+cumfrot+cumbelly+cumass+cumpussy+cumanus>0,'<a href="exec:gs''zz_common'',''wet_wipes''"><b>Использовать салфетки</b></a>','')
if kosmetica > 0: $_bag_text += '**У вас есть <a href="exec:gt''mirror'',''start'',''menu_bag''">переносная косметичка</a>. Косметики хватит на <<kosmetica>> раз.'
if prezik + Sprezik > 0:
	if CondomToggle = 0:
		$_bag_text += '**У вас <<prezik + Sprezik>> презервативов и вы пользуетесь ими в случае необходимости. <a href="exec:CondomToggle = 1 & dynamic $d_bag"><b>Перестать пользоваться.</b></a>'
	else
		$_bag_text += '**У вас <<prezik + Sprezik>> презервативов, но вы не пользуетесь ими. <a href="exec:CondomToggle = 0 & dynamic $d_bag"><b>Начать пользоваться.</b></a>'
	end
end
if tabletki + Stabletki > 0:
	if PillToggle = 0:
		$_bag_text += '**У вас <<tabletki + Stabletki>> противозачаточных таблеток и вы принимаете их.<a href="exec:PillToggle = 1 & dynamic $d_bag"><b>Прекратить принимать таблетки.</b></a>'
	else
		$_bag_text += '**У вас <<tabletki + Stabletki>> противозачаточных таблеток, но вы не принимаете их.<a href="exec:PillToggle = 0 & dynamic $d_bag"><b>Начать принимать таблетки.</b></a>'
	end
end
if lubri > 0: $_bag_text += '**У вас есть лубрикант. Хватит на <<lubri>> раз.'
if bottle > 0: $_bag_text += '**У вас есть бутылочка воды. <a href="exec:bottle = 0 & water = 20 & cumlip = 0 & gs''stat''"><b>Выпить</b></a>'
if buterbrod > 0: $_bag_text += '**У вас есть бутерброд. <a href="exec:buterbrod = 0 & energy += 10 & cumlip = 0 & body[''day_weight''] += 1 & gs''stat''"><b>Съесть</b></a>'
if wine = 1: $_bag_text += '**В сумочке лежит бутылка вина.'
if foto = 1: $_bag_text += '**В сумочке лежит странное фото'
if abonement > 0: $_bag_text += '**Абонемент, на посещение фитнесс-центра, действителен на <<abonement>> занятий.'
if krem > 0: $_bag_text += '**Крем для загара <<krem>>.'
if reading['in_bag'] >= 0: $_bag_text += '**В сумочке лежит книга "'+func('zz_books','get_name',reading['in_bag'])+'".'
!---
$_html = '<div id="hero_description">'
	$_html += '<div id="hero_photo">'
		$_html += '<div id="hero_photo_container"><img src="images/common/books/'+reading['in_bag']+'.jpg"></div>'
	$_html += '</div>'
	$_html += '<div id="hero_text">'+$_bag_text+'</div>'
$_html += '</div>'
gs 'zz_render','','',$_html
killvar '$_bag_text'
killvar '$_html'