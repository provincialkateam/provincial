!$ev_name = 'Федор'
!$ev_name_a = 'Федора'
!$ev_name_om = 'Федором'
!dick = 17
!silavag = 0
!gnpcSex[numnpc] - секс
!grupNPC[numnpc] - отношения
!наличие нпс теоретически могущих познакомиться
mass_ver_zn = 0
!хотят или нет нпс познакомиться
ver_zn = 0
!количество мужчин
kol_man = 0
!текст приветствия
$text_znak = ''
!возможность знания репы гг
know_status = 0
!опознали репутацию или нет
know_gor_slut = 0
!обнуление текста
$kol_man_text_no = ''
plact = 0
gs'stat'
gs'time'
$textEvent = ''
if place = 0:
	!улица
	!if litltown = 1:$numplace = 'gorodok'
	$numplace = 'gorodok'
elseif place = 1:
	!парк
	$numplace = 'zz_park'
elseif place = 2:
	!кино
elseif place = 3:
	!домой к парню. Предлог видик
elseif place = 4:
	!дискотека в Павлово
end
gt 'placer_<<$numplace>>'