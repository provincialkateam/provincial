﻿gs 'stat'
gs 'time'
frost = 0
gs 'zz_render','','images/qwest/gadukino/new/grandmahelp.jpg'
gs 'zz_render','','','Вы подошли к бабушке и спросили не нужна ли ей помочь по хозяйству. Бабушка немного подумала, взглянув на погоду и сказала:'
if month <= 4 or month >= 10:grandmahelping = RAND(0,2)
if month = 5 or month = 6:grandmahelping = RAND(0,5)
if month = 7:grandmahelping = RAND(0,6)
if month = 8:grandmahelping = RAND(7,13)
if month = 9:grandmahelping = RAND(14,19)
if grandmahelping = 0:
	gs 'zz_render','','',' - Конечно внученька, я уже старая совсем, сил не хватает пол помыть.'
	act 'Мыть пол':
		*clr & cla
		minut += 60
		grandmahelp += 1
		grandmaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/Washfloor.jpg'
		gs 'zz_render','','','Вы вооружились ведром и тряпкой, сели на корточки и принялись драить пол. После того как все засияло чистотой, вы довольная собой поставили инвентарь в угол и отправились по своим делам.'
		act 'Уйти':gt'Gadhouse'
	end
elseif grandmahelping = 1:
	gs 'zz_render','','',' - Конечно внученька, нужно белье постирать, а то мы с дедом скоро грязью зарастем.'
	act 'Стирать белье':
		*clr & cla
		minut += 60
		grandmahelp += 1
		grandmaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/Washclothes1.jpg'
		gs 'zz_render','','','Вы взяли тазик и принялись стирать белье в течение часа.'
		act 'Развесить белье':
			*clr & cla
			minut += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/Washclothes2.jpg'
			gs 'zz_render','','','Вы взяли постиранное белье и аккуратно развесили его во дворе.'
			act 'Уйти':gt'Gaddvor'
		end
	end
elseif grandmahelping = 2 and hour < 9 and hour > 20:
	gs 'zz_render','','',' - Внучка, сходи-ка в сарай, подоить корову нужно.'
	act 'Идти в сарай':
		*clr & cla
		minut += 10
		milk_cow = 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы пошли в сарай где вас уже заждалась Зорька'
		act 'Далее':gt'Gadsarai'
	end
elseif grandmahelping = 3:
	gs 'zz_render','','',' - Конечно внученька, ты у меня такая молодец, иди на двор, покорми кур.'
	act 'Взять корм для кур':
		*clr & cla
		feed_chickens = 1
		minut += 30
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/feed_chickens.jpg'
		gs 'zz_render','','','Вы взяли корм для кур и двинулись на двор.'
		act 'Уйти':gt'Gaddvor'
	end
elseif grandmahelping = 4 and sunWeather >= 0:
	gs 'zz_render','','',' - Светуля, сходи на огород, пора там порядок наводить.'
	act 'Идти на огород':
		*clr & cla
		work_garden = 1
		minut += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на огород.'
		act 'Далее':gt'Gadgarden','garden'
	end
elseif grandmahelping = 5 and sunWeather >= 0:
	gs 'zz_render','','',' - Света, внучка, сбегай полей огород, а то весь урожай посохнет'
	act 'Идти на огород':
		*clr & cla
		water_garden = 1
		minut += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на огород.'
		act 'Далее':gt'Gadgarden','garden'
	end
elseif grandmahelping = 6 and sunWeather >= 0:
	gs 'zz_render','','',' - Светуля, внученька, пора бы уже начать клубнику собирать, займись этим сегодня'
	act 'Идти на делянку':
		*clr & cla
		collect_strawberries = 1
		minut += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на клубничную делянку.'
		act 'Далее':gt'Gadgarden','strawberry'
	end
elseif grandmahelping = 7:
	gs 'zz_render','','',' - Конечно внученька, я уже старая совсем, сил не хватает пол помыть.'
	act 'Мыть пол':
		*clr & cla
		minut += 60
		grandmahelp += 1
		grandmaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/Washfloor.jpg'
		gs 'zz_render','','','Вы вооружились ведром и тряпкой, сели на корточки и принялись драить пол. После того как все засияло чистотой, вы довольная собой поставили инвентарь в угол и отправились по своим делам.'
		act 'Уйти':gt'Gadhouse'
	end
elseif grandmahelping = 8:
	gs 'zz_render','','',' - Конечно внученька, нужно белье постирать, а то мы с дедом скоро грязью зарастем.'
	act 'Стирать белье':
		*clr & cla
		minut += 60
		grandmahelp += 1
		grandmaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/Washclothes1.jpg'
		gs 'zz_render','','','Вы взяли тазик и принялись стирать белье в течение часа.'
		act 'Развесить белье':
			*clr & cla
			minut += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/Washclothes2.jpg'
			gs 'zz_render','','','Вы взяли постиранное белье и аккуратно развесили его во дворе.'
			act 'Уйти':gt'Gaddvor'
		end
	end
elseif grandmahelping = 9:
	gs 'zz_render','','',' - Конечно внученька, ты у меня такая молодец, иди на двор, покорми кур.'
	act 'Взять корм для кур':
		*clr & cla
		feed_chickens = 1
		minut += 30
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/feed_chickens.jpg'
		gs 'zz_render','','','Вы взяли корм для кур и двинулись на двор.'
		act 'Уйти':gt'Gaddvor'
	end
elseif grandmahelping = 10 and hour < 9 and hour > 20:
	gs 'zz_render','','',' - Внучка, сходи-ка в сарай, подоить корову нужно.'
	act 'Идти в сарай':
		*clr & cla
		minut += 10
		milk_cow = 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы пошли в сарай где вас уже заждалась Зорька'
		act 'Далее':gt'Gadsarai'
	end
elseif grandmahelping = 11 and sunWeather >= 0:
	gs 'zz_render','','',' - Светуля, сходи на огород, пора там порядок наводить.'
	act 'Идти на огород':
		*clr & cla
		work_garden = 1
		minut += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на огород.'
		act 'Далее':gt'Gadgarden','garden'
	end
elseif grandmahelping = 12 and sunWeather >= 0:
	gs 'zz_render','','',' - Света, внучка, сбегай полей огород, а то весь урожай посохнет'
	act 'Идти на огород':
		*clr & cla
		water_garden = 1
		minut += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на огород.'
		act 'Далее':gt'Gadgarden','garden'
	end
elseif grandmahelping = 13 and sunWeather >= 0:
	gs 'zz_render','','',' - Светуля, внученька, пора бы уже начать фрукты собирать в саду, займись этим сегодня'
	act 'Идти в сад':
		*clr & cla
		fruit_collect = 1
		minut += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись в сад.'
		act 'Далее':gt'Gadgarden','fruit_garden'
	end
elseif grandmahelping = 14:
	gs 'zz_render','','',' - Конечно внученька, я уже старая совсем, сил не хватает пол помыть.'
	act 'Мыть пол':
		*clr & cla
		minut += 60
		grandmahelp += 1
		grandmaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/Washfloor.jpg'
		gs 'zz_render','','','Вы вооружились ведром и тряпкой, сели на корточки и принялись драить пол. После того как все засияло чистотой, вы довольная собой поставили инвентарь в угол и отправились по своим делам.'
		act 'Уйти':gt'Gadhouse'
	end
elseif grandmahelping = 15:
	gs 'zz_render','','',' - Конечно внученька, нужно белье постирать, а то мы с дедом скоро грязью зарастем.'
	act 'Стирать белье':
		*clr & cla
		minut += 60
		grandmahelp += 1
		grandmaQW += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/Washclothes1.jpg'
		gs 'zz_render','','','Вы взяли тазик и принялись стирать белье в течение часа.'
		act 'Развесить белье':
			*clr & cla
			minut += 10
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/Washclothes2.jpg'
			gs 'zz_render','','','Вы взяли постиранное белье и аккуратно развесили его во дворе.'
			act 'Уйти':gt'Gaddvor'
		end
	end
elseif grandmahelping = 16:
	gs 'zz_render','','',' - Конечно внученька, ты у меня такая молодец, иди на двор, покорми кур.'
	act 'Взять корм для кур':
		*clr & cla
		feed_chickens = 1
		minut += 30
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/feed_chickens.jpg'
		gs 'zz_render','','','Вы взяли корм для кур и двинулись на двор.'
		act 'Уйти':gt'Gaddvor'
	end
elseif grandmahelping = 17 and hour < 9 and hour > 20:
	gs 'zz_render','','',' - Внучка, сходи-ка в сарай, подоить корову нужно.'
	act 'Идти в сарай':
		*clr & cla
		minut += 10
		milk_cow = 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы пошли в сарай где вас уже заждалась Зорька'
		act 'Далее':gt'Gadsarai'
	end
elseif grandmahelping = 18 and sunWeather >= 0:
	gs 'zz_render','','',' - Светуля, сходи на огород, пора там порядок наводить.'
	act 'Идти на огород':
		*clr & cla
		work_garden = 1
		minut += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на огород.'
		act 'Далее':gt'Gadgarden','garden'
	end
elseif grandmahelping = 19 and sunWeather >= 0:
	gs 'zz_render','','',' - Света, внучка, сегодня на огород иди, пришла пора урожай собирать.'
	act 'Идти на огород':
		*clr & cla
		harvest_garden = 1
		minut += 10
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/go_yard.jpg'
		gs 'zz_render','','','Вы собрались и двинулись на огород.'
		act 'Далее':gt'Gadgarden','garden'
	end
else
	gs 'zz_render','','',' - Сегодня нет работы внучка, отдыхай.'
	act 'Уйти':gt $loc, $metka
end