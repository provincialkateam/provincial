$metka = $ARGS[0]
$loc = $CURLOC
gs 'stat'
'<center><b>Кухня в общаге</b></center>'
'<center><img src="images/img/centr/obkitchen.jpg"></center>'
act 'В коридор': gt 'dorm','korr'
gs 'zz_kitchen_acts', 'all', 1
if eda > 0 or edaD > 0:
	'В холодильнике хранится <b><<eda>></b> порций еды, а также <b><<edaD>></b> диетических продуктов.'
elseif edaD = 0 and eda = 0:
	'<b><font color = red>В холодильнике шаром покати, вообще нечего есть.</font></b>'
end