﻿hour = 31
son = 20
gs'stat'
'<center><img src="images/img/Kathouse/slip.jpg"></center>'
'Катя привела вас к себе, уложила спать и сама легла с вами. Рано утром вы почувствовали как она выскользнула из ваших объятий и открыли глаза.'
'"Спи, мне на работу надо, я тебе ключи оставлю." сказала Кэт и чмокнув вас убежала.'
'Вы выспались и начали осматриваться, на кушетке напротив кровати лежал парень и смотрел на вас. Вероятно это один из её многочисленных парней про которых она вам рассказывала.'
act 'Уйти':gt'street'
act 'Соблазнить':
	cla
	*clr
	'<center><img src="images/img/Kathouse/kathouse1.jpg"></center>'
	'Вы скидываете с себя одеяло и начинаете гладить себя, сначала грудь затем трусики в районе киски, когда чувствуете что киска достаточно увлажнилась отводите трусики в бок и засовываете пару пальцев в вагину, слегка постанывая.'
	'Парень сел на кушетку и смотрит на вас не моргая.'
	act 'Подозвать':
		$sexloc = 'katspalnya'
		gt'sex','start'
	end
end