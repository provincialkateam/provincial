$loc = $curloc
$metka = $args[0]
gs 'stat'
gs 'zz_render','Торгово-развлекательный центр','images/img/centr/torgcentr.jpg'
if hour >= 9 and hour <= 20:
	gs 'zz_render','','','<a href="exec:GT ''young_shop''">Магазин Кис-киска</a>.
Элитарный <a href="exec: gt ''butik'',''start''">Бутик</a> с модной и дорогой одеждой.
<a href="exec: gt ''salon'',''start''">Салон красоты</a>.
<a href="exec: gt ''shop'',''sport''">Магазин спорттоваров</a>.
<a href="exec: gt ''bouling''">Боулинг</a>, <a href="exec: gt''billiard''">бильярд</a> и <a href="exec: gt''cinema''">кинотеатр</a>.
На первом этаже расположился <a href="exec: gt ''shop'',''start''">сетевой супермаркет</a> такой же как в Южном районе.'
end
act 'Уйти': gt 'down'