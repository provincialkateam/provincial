$metka = $ARGS[0]
$loc = $CURLOC
gs'stat'
gs'time'
gs 'zz_render', 'Поляна', 'qwest/gadukino/meadow.jpg','Тихое заброшенное местечко, хорошо скрытое зелеными зарослями от цивилизации.'+iif(mirainmeadow = 1,'На поляне с восторгом кружится <a href="exec: gt ''Miroslava'' ">Мира</a>.','')
if meadow = 3 and mirainmeadow = 0:
	temp = RAND(0,9)
	if Mira_no = 0 and mirainmeadow = 0 and temper >= 20 and sunWeather >= 0:
		$_str = ''
		if mirasextimes < 15 and temp = 0: $_str = 'Миру'
		if miragopQW >= 2 and temp = 1: $_str = 'Миру с Митькой'
		if miragopQW >= 8 and temp = 2: $_str = 'Миру с Митькой'
		if miragopQW >= 11 and temp = 3: $_str = 'Миру с Колямбой'
		if miragopQW >= 11 and temp = 4: $_str = 'Миру с Васяном'
		if miragopQW >= 11 and temp = 5: $_str = 'Миру с Васяном'
		if miragopQW >= 11 and temp = 6: $_str = 'Миру с Митькой, Васяном и Колямбой'
		if miragopQW >= 20 and temp = 7: $_str = 'Миру с Васяном и Колямбой'
		if miragopQW > 33 and temp = 8: $_str = 'кучу деревенских полуголых мужиков'
		if miragopQW >= 20 and temp = 9: $_str = 'Миру'
		if len($_str) > 0: gs 'zz_render', '', '', 'На поляне вы замечаете <a href="exec: gt ''Meadow_event'',''mirameadow''">'+$_str+'</a>.'
		killvar '$_str'
	end
end
act 'Уйти': minut += 30 & mirainmeadow = 0 & gt'Gaddvor'
miratemp = rand(1,5)
if meadow = 3 and mirainmeadow = 0 and miragopQW = 2 and temper >= 15 and sunWeather >= 0: gt 'Meadow_event','mira_mitka'
if meadow = 3 and Mira_no = 0 and mirainmeadow = 0 and miragopQW = 33 and temper >= 15 and sunWeather >= 0: gt 'Meadow_event','mira_gang'
if mitkasextimes > 13 and mirasex = 0 and miragopQW < 11:gt 'Meadow_event','mira_lesb_talk1'
if mitkasextimes > 13 and mirasex = 1 and miragopQW < 11 and miratemp = 1 and miraday ! day: gt 'Meadow_event','mira_lesb_talk3'
if mitkasextimes > 13 and mirasex = 1 and miragopQW > 11 and lickmira = 0:gt 'Meadow_event','mira_lesb_talk2'
if mirasex = 2 and miratemp > 3 and miraday ! day and miraQW >= 15:gt 'Meadow_event','mira_lesb'