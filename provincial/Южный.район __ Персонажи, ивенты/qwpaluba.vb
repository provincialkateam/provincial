﻿minut += 30
energy = 21
water = 21
gs 'stat'
gs 'zz_render', 'Катер', 'images/qwest/vladimir/kater2.jpg', func('qwpaluba_strings', 'local_str1')
act 'Подойти к Изольде':
	*clr & cla
	izoldaQW = 1
	minut += 15
	gs 'stat'
	gs 'zz_render', 'Изольда', 'images/qwest/kolan/izolda.jpg', func('qwpaluba_strings', 'local_str2')
	act 'Сойти на берег':gt'qwbereg'
end
act 'Подойти к Славе':
	*clr & cla
	minut += 15
	gs'stat'
	gs 'zz_render', 'Слава', 'images/qwest/kim/001.jpg', func('qwpaluba_strings', 'local_str3')
	act 'Не очень':
		cla
		slavaQW = 1
		gs 'zz_render', '', '', func('qwpaluba_strings', 'local_str4')
		act 'Сойти на берег':gt'qwbereg'
	end
	act 'Да':
		cla
		slavaQW = 1
		gs 'zz_render', '', '', func('qwpaluba_strings', 'local_str5')
		act 'Сойти на берег':gt'qwbereg'
	end
end
act 'Поговорить с Виталием':
	*clr & cla
	minut += 15
	gs 'stat'
	gs 'zz_render', 'Виталий', 'images/qwest/marafet/001.jpg', func('qwpaluba_strings', 'local_str6')
	act 'Сойти на берег':gt'qwbereg'
end