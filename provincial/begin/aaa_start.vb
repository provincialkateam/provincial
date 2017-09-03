KILLALL
CLOSE ALL
USEHTML = 1
DEBUG = 1
SHOWSTAT 0
SHOWACTS 0
SHOWOBJS 0
SHOWINPUT 0
DISABLESCROLL = 1
$ONGLOAD = 'loadg'
$ONGSAVE = 'saveg'
$ONNEWLOC = 'LOCA'
! устанавливаем текущую версию игры
version = 120
! ---
gs 'zz_render','','common/start/screens/'+rand(1,3),'<center><b><span style="font-size:1.3em;"><a href="exec:gt''begin'',''main''">Новая игра</a>&nbsp;&nbsp;&nbsp;<a href="javascript:qspLoadGame(); return false;">Загрузить</a></span></span>
Версия '+ mid(version,1,1) + '.' + mid(version,2,1) + '.' + mid(version,3,1) +'
<span style="color:maroon;font-size:1.5em">Игра строго 18+!</span></b>
<span style="font-size:0.8em;">Игра ни к чему не призывает и имеет исключительно развлекательный характер.
Все персонажи выдуманы и достигли возраста сексуального согласия, любые совпадения случайны!
Разработчики строго осуждают любые реальные неправомерные или насильственные действия сексуального характера без обоюдного согласия всех его участников!
Начиная игру, вы автоматически отказываетесь от каких-либо претензий к разработчикам по поводу контента.</span></center>'