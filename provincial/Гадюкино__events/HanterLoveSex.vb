$din_hanters_bj_bonusH1 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus1.gif"></center>'
	''
	'Вы засунули кончик языка в маленькую дырочку головки члена.'
	if harakBoyH = 2:'<<$boy>> от этого аж вздрогнул: -<<$name[2]>>, что ты делаешь, перестань, я ща кончу бля от этого.'
	if harakBoyH < 2:'<<$boy>> от этого аж вздрогнул: -<<$name[2]>>, что ты делаешь, перестань, так же и кончить сразу можно.'
	act 'Продолжить':dynamic $din_hanters_bjH1
}
$din_hanters_bjH1 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	if pirsA = 0:$textsexkotov = 'лижете язычком головку'
	if pirsA > 0:$textsexkotov = 'лижете язычком головку чувствуя как штанга в вашем языке шевелится от ударов об член'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj1'+rand(0,3)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы <<$textsexkotov>>'
	'Нежно и быстро щекочете кончиком языка самую вершину головки, ее отверстие.'
	''
	if hanters_bj_times < 3:'<a href="exec:dynamic $din_hanters_bj_bonusH1">Засунуть</a> кончик языка в дырочку.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	''
	if h = 3 and hanters_bj_times >= 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonusH2 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus2.gif"></center>'
	''
	'Решивишсь слегка укусить его, вы нежно прикусываете головку своими белыми зубами.'
	if harakBoyH = 2:'-Эй, бля, <<$name[2]>>, ты че, мой член с бананом перепутала? Не шути так больше.'
	if harakBoyH < 2:'-Осторожно, <<$name[2]>>, не шути так больше.'
	'Вы с улыбкой посмотрели на него и решили...'
	act 'Продолжить':dynamic $din_hanters_bjH2
}
$din_hanters_bjH2 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	if pirsA = 0:$textsexkotov = 'причмокивая сосете головку'
	if pirsA > 0:$textsexkotov = 'причмокивая сосете головку чувствуя как штанга в вашем языке шевелится от ударов о член'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj2'+rand(0,6)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы <<$textsexkotov>>, и плотно его сжимаете своими <<$liptalk>> '
	'Нежность ваших губ сводит парня с ума'
	''
	if hanters_bj_times < 3:'Попробовать слегка <a href="exec:dynamic $din_hanters_bj_bonusH2">укусить</a> красную головку члена'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	''
	if h = 3 and hanters_bj_times >= 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonusH3 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus3.gif"></center>'
	''
	'Смотря в глаза своего парня, вы дразните язычком одну из самых эрогенных зон члена.'
	'-Класс, <<$name[2]>>, знаешь как меня завести еще сильнее.'
	act 'Продолжить':dynamic $din_hanters_bjH3
}
$din_hanters_bjH3 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj3'+rand(0,1)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы покрываете член сладкими поцелуями, нежно его касаясь своими <<$liptalk>>'
	''
	if hanters_bj_times < 3:'Можно слегка <a href="exec:dynamic $din_hanters_bj_bonusH3">подразнить</a> тонкую уздечку члена'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	 ''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonusH4 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus4.gif"></center>'
	''
	'Взявшись за основание члена, вы выполняете просьбу парня, и шлепаете головкой по вашим щекам.'
	if harakBoyH = 2:'-О да, ты моя покорная сучка, так меня заводишь, давай продолжай милая.'
	if harakBoyH = 0:'-О да, ты так меня заводишь, давай продолжай милая.'
	act 'Продолжить':dynamic $din_hanters_bjH4
}
$din_hanters_bjH4 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj4'+rand(0,1)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы слегка обхватили член рукой и натянули кожу, оголяя сверкающую головку.'
	''
	if hanters_bj_times < 3:'<<$boy>> просит вас <a href="exec:dynamic $din_hanters_bj_bonusH4">шлепнуть</a> членом по вашей щечке.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3: act 'Дрочить':dynamic $din_hanters_bjH6
	if h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
		act 'Дрочить':dynamic $din_hanters_bjH6
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonusH6 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus6.gif"></center>'
	''
	'<<$boy>> шлепает членом по вашему языку.'
	if harakBoyH > 0:'-Плохая девочка, ща папочка тебя накажет.'
	if harakBoyH = 0:'- А ты оказывается развратная девчока, - с улыбкой говорит он.'
	act 'Продолжить':dynamic $din_hanters_bjH6
}
$din_hanters_bjH6 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj6'+rand(0,1)+'.gif"></center>'
	''
	h = rand(1,3)
	'Захватив член в свои цепкие руки, вы начали его уверенно надрачивать, и наблюдаете за реакцией парня.'
	if harakBoyH > 0:'-Неплохо,<<$name[2]>>, но дрочить я и сам себе могу, ты там давай включай все свои женские инструменты.'
	if harakBoyH = 0:'-Давай,<<$name[2]>>, покажи, на что ты способна, - с улыбкой говорит , - с улыбкой говорит <<$boy>>, глядя вам в глаза.'
	''
	if hanters_bj_times < 3:'Высунуть язык и <a href="exec:dynamic $din_hanters_bj_bonusH6">шлепать</a> по нему горячей головкой.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h = 3 and hanters_bj_times >= 3:
		act 'Кончить':dynamic $din_hanters_sex_cumface3
	end
}
$din_hanters_bj_bonusH7 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus11.gif"></center>'
	''
	'Вы взяли и плотно прижали головку за щекой и <<$boy>> начал грубо трахать вас в таком положении, расстягивая все лицо.'
	'-О да, детка, давай еще немного, твое личико так сексуально выглядит.'
	act 'Продолжить':dynamic $din_hanters_bjH7
}
$din_hanters_bjH7 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj11'+rand(0,4)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы хватаетесь за основание члена и начинаете жадно сосать.
Член парня полностью не помещается в вашем маленьком ротике и входит лишь наполовину, вы сосете и нежно надрачиваете остальную часть.'
	''
	if hanters_bj_times < 3:'Взять член <a href="exec:dynamic $din_hanters_bj_bonusH7">за щеку</a> и плотно прижать головку.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	 ''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	 ''
	if hanters_bj_times < 3:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
	 i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonusH8 ={
	*clr & cla
	minut += 5
	throat += 1
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus12.gif"></center>'
	''
	'Вы попытались взять член еще глубжe, но у вас ничего не получилось, и едва не вырвало прямо на парня.'
	if harakBoyH = 2:' -Фу бля,<<$name[2]>>, если не можешь нормально глотать, то лучше потренируйся дома на банане, а не на моем хую.'
	if harakBoyH = 0:' -Не расстраивайся <<$name[2]>>, может в следующий раз получится.'
	act 'Продолжить':dynamic $din_hanters_bjH8
}
$din_hanters_bjH8 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj12'+rand(0,2)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы начали сосать член не притрагиваясь к нему ручками, думая, что парню так вы доставите больше удовольствия.
	Член парня польностью не помещается в вашем рту, и вы причмокивая сосете лишь до половины.'
	''
	if hanters_bj_times < 3 and throat <= 15:'Попробовать <a href="exec:dynamic $din_hanters_bj_bonusH8">заглотить</a> член глубже.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,4)
		if k = 1 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary_analH">лечь на спину</a>.'
		if k = 2 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow_analH">запрыгнуть на парня</a>.'
		if k = 3 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog_analH">нагнуться</a>.'
		if k = 4 and klismaday = day: 'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell_analH">лечь на живот</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h < 3 and hanters_bj_times >= 3 and klismaday = day:
		i = rand(1,4)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
	elseif h < 3 and hanters_bj_times >= 3 and klismaday ! day:
		i = rand(1,2)
		if bj <= 10: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 1: act 'Сосать подрачивая':dynamic $din_hanters_bjH7
		if bj > 10 and i = 2: act 'Сосать без рук':dynamic $din_hanters_bjH8
	elseif h = 3 and hanters_bj_times >= 3:
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj = {
	act 'Опуститься на колени':
		*clr & cla
		minut += 5
		bj_temp += 1
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj'+rand(0,5)+'.gif"></center>'
		'Вы опустились на колени перед парнем. Он с интересом смотрит на вас, ожидая ваших действий. И вы принимаетесь...'
		i = rand(1,4)
		if bj > 10: act 'Сосать головку':dynamic $din_hanters_bjH2
		if bj > 5 and bj <= 10: act 'Лизать головку':dynamic $din_hanters_bjH1
		if bj > 2 and bj <= 5: act 'Поцеловать головку':dynamic $din_hanters_bjH3
		if bj <= 2: act 'Ласкать ладошкой':dynamic $din_hanters_bjH4
	end
}
$din_hanters_sex_bell_analH ={
	*clr & cla
	minut += 5
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal20.gif"></center>'
	''
	'Парень, положив вас на живот, принялся ласкать вашу попку. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	 ''
	i = rand(1,2)
	j = rand(1,3)
	h = rand(1,2)
	if h = 1:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	if h = 2:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 1 and i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if h = 1 and i = 2: act 'Кончить':dynamic $din_hanters_sex_cum5
	if h = 2 and j = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
	if h = 2 and j = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
	if h = 2 and j = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
}
$din_hanters_sex_cow_analH ={
	*clr & cla
	minut += 5
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal3'+rand(0,4)+'.gif"></center>'
	''
	'Парень лег на спину и потянул вас на верх. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	''
	i = rand(1,2)
	j = rand(1,3)
	h = rand(1,2)
	if h = 1:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	if h = 2:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 1 and i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if h = 1 and i = 2: act 'Кончить':dynamic $din_hanters_sex_cum4
	if h = 2 and j = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
	if h = 2 and j = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
	if h = 2 and j = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
}
$din_hanters_sex_dog_analH ={
	*clr & cla
	minut += 5
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal1'+rand(0,1)+'.gif"></center>'
	''
	'Парень поставил вас на четвереньки и принялся ласкать вашу попку. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	''
	i = rand(1,2)
	j = rand(1,3)
	h = rand(1,2)
	if h = 1:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	if h = 2:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 1 and i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if h = 1 and i = 2: act 'Кончить':dynamic $din_hanters_sex_cum3
	if h = 2 and j = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary_analH
	if h = 2 and j = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
	if h = 2 and j = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
}
$din_hanters_sex_misionary_analH ={
	*clr & cla
	minut += 5
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal'+rand(0,1)+'.gif"></center>'
	''
	'Парень положил вас на спину и принялся пристраиваться к вашей попке. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	''
	i = rand(1,2)
	j = rand(1,3)
	h = rand(1,2)
	if h = 1:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	if h = 2:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 1 and i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if h = 1 and i = 2: act 'Кончить':dynamic $din_hanters_sex_cum2
	if h = 2 and j = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow_analH
	if h = 2 and j = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog_analH
	if h = 2 and j = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell_analH
}
!69
$din_hanters_sex_cumface7 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf70.gif"></center>'
	''
	'Вы чувствуете как член начинает пульсировать у вас во рту и в небо бьют потоки терпкой спермы.'
	if harakBoyH < 2: '-Прости <<$name[2]>>, не смог сдержаться от твоей сладкой киски.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
!в горло
$din_hanters_sex_cumface6 ={
	*clr & cla
	minut += 5
	sweat += 1
	gs 'zz_funcs', 'cum', 'lip'
	vaf += 1
	swallow += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf60.gif"></center>'
	''
	'Вы чувствуете как член начинает пульсировать у вас во рту и в небо бьют потоки терпкой спермы. Во рту совсем нет места и вы глотаете всю сперму.'
	if harakBoyH = 2: '-Ненасытная шлюшка, вот тебе чего не хватало сегодня.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
!во время титфак
$din_hanters_sex_cumface5 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf50.gif"></center>'
	''
	'Мощные струи ударили вам в подбородок, несколько капель попали в лицо, сперма медленно стекает вниз к груди.'
	if harakBoyH = 2: '-<<$name[2]>>, просто тащусь от твоих охуеннх сисек.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
!на грудь
$din_hanters_sex_cumface4 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'belly'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf40.gif"></center>'
	''
	'<<$boy>> кончил вам на грудь, горячие капельки стекают вниз к животу, вы размазываете липкую сперму по всему телу.'
	if harakBoyH = 2: '-<<$name[2]>>, говорят так сиськи растут. Будешь моей пышногрудой красавицей.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
!от дрочки
$din_hanters_sex_cumface3 ={
	*clr & cla
	minut += 5
	sweat += 1
	hj += 1
	hja += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf30.gif"></center>'
	''
	'Твердый член начал пульсировать в объятиях вашей ладони и <<$boy>> кончил вам в ладошки покрыв их горячей и липкой спермой.'
	if harakBoyH > 0: '-Детка, у тебя просто золотые ручки, одолжишь их на время?'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
!в рот
$din_hanters_sex_cumface2 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'lip'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf20.gif"></center>'
	''
	'Вы чувствуете как член начинает пульсировать у вас во рту и в небо бьют потоки терпкой спермы.'
	act 'Проглотить':
		*clr & cla
		minut += 1
		vaf += 1
		swallow += 1
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_4_'+rand(13,14)+'.gif"></center>'
		''
		'С большим удовольствием проглотили все до единой капельки.'
		if harakBoyH = 2: '-Бля <<$name[2]>>, ты та еще вафлитска, рот не забудь помыть, я тебе еще иногда целовать хочу.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
	act 'Выплюнуть':
		*clr & cla
		minut += 1
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="pavlovo/family/sisterQW/ReksHome/reksParty_party_kuh_4_16.gif"></center>'
		''
		'Вам не нравится этот вкус и вы быстро выплюнули эту омерзительную жидкость.'
		if harakBoyH = 2: '-Что, не вкусно <<$name[2]>>? Я то думал все бабы тащатся от спермы, жаль ты у меня не такая. '
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
!на лицо
$din_hanters_sex_cumface1 ={
	*clr & cla
	minut += 1
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cumf10.gif"></center>'
	''
	'Брызги горячей спермы ударили вам по лицу, и капельки медленно стекают вниз.'
	if harakBoyH > 0: '-Охх, <<$name[2]>>, круто мы с тобой сегодня оторвались.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum11 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	if protect = 1:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum61.jpg"></center>'
		'<<$boy>> застонал и вы поняли, что он кончил в презерватив. Ваш парень полностью расслабился, выбросил куда-то презик и удовлетворенно лег на кровать.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	else
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum111.jpg"></center>'
		'<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
		gs 'zz_funcs', 'cum', 'pussy'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
$din_hanters_sex_cum10 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'belly'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum110.gif"></center>'
	''
	'<<$boy>> вытащил член, застонал и вы почувствовали как горячие струйки спермы стреляют вам на живот и на сиськи, и медленно стекают вниз. Ваш парень полностью расслабился и удовлетворенно лег на кровать.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum9 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	if protect = 1:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum91.jpg"></center>'
		''
		'<<$boy>> застонал и вы поняли, что он кончил в презерватив. Ваш парень полностью расслабился, выбросил куда-то презик и удовлетворенно лег на кровать.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	else
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum9.jpg"></center>'
		''
		'<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
		gs 'zz_funcs', 'cum', 'pussy'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
$din_hanters_sex_cum81 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	if protect = 1:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum82.jpg"></center>'
		''
		'<<$boy>> застонал и вы поняли, что он кончил в презерватив. Ваш парень полностью расслабился, выбросил куда-то презик и удовлетворенно лег на кровать.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	else
		gs 'zz_funcs', 'cum', 'pussy'
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum81.gif"></center>'
		'<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
		gs 'zz_funcs', 'cum', 'pussy'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
$din_hanters_sex_cum8 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	if protect = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum81.jpg"></center>'
	'<<$boy>> застонал и вы поняли, что он кончил в презерватив. Ваш парень полностью расслабился, выбросил куда-то презик и удовлетворенно лег на кровать.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	else
		gs 'zz_funcs', 'cum', 'pussy'
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum8.gif"></center>'
		'<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
		gs 'zz_funcs', 'cum', 'pussy'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
$din_hanters_sex_cum7 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	if protect = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum71.jpg"></center>'
	'<<$boy>> застонал и вы поняли, что он кончил в презерватив. Ваш парень полностью расслабился, выбросил куда-то презик и удовлетворенно лег на кровать.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	else
		gs 'zz_funcs', 'cum', 'pussy'
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum7.gif"></center>'
		'<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
		gs 'zz_funcs', 'cum', 'pussy'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
$din_hanters_sex_cum6 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'stat'
	if protect = 1:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum61.jpg"></center>'
		'<<$boy>> застонал и вы поняли, что он кончил в презерватив. Ваш парень полностью расслабился, выбросил куда-то презик и удовлетворенно лег на кровать.'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	 else
		gs 'zz_funcs', 'cum', 'pussy'
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum6.jpg"></center>'
		'<<$boy>> застонал и вы почувствовали как струя спермы ударила вам внутрь вашего тела.'
		gs 'zz_funcs', 'cum', 'pussy'
		if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
		if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
		if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
		''
		if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
			act '<<$boy>>, ещё хочу.':
				*clr & cla
				dikos += 1
				minut += 5
				hanters_bj_times = 0
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
				'Вы сказали парню, что ещё хотите.'
				'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
				if vagina = 0:dynamic $din_hanters_bj
				if vagina > 0:
					i = rand(1,5)
					if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
					if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
					if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
					if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
					if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
				end
			end
		end
		act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
	end
}
$din_hanters_sex_cum5 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum5.gif"></center>'
	''
	'<<$boy>> вытащил член, застонал и вы почувствовали как горячие струйки спермы стреляют вам на попу и спину. Ваш парень полностью расслабился и удовлетворенно лежит на спине.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	''
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum41 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'belly'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum41.gif"></center>'
	''
	'<<$boy>> вытащил член, застонал и вы почувствовали как горячие струйки спермы стреляют на животик, и медленно стекают вниз. Ваш парень полностью расслабился и удовлетворенно лежит на спине.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum4 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum4.jpg"></center>'
	''
	'<<$boy>> вытащил член, застонал и вы почувствовали как горячие струйки спермы стреляют вам на попу и спину. Ваш парень полностью расслабился и удовлетворенно лежит на спине.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum3 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum3.gif"></center>'
	''
	'<<$boy>> вытащил член, застонал и вы почувствовали как горячие капли спермы падают на вашу попу и спину.'
	if harakBoyH = 2:'-Черт,<<$name[2]>>, в такой позе тебя ебать и ебать. Парень легонько шлепнул вас по попе.'
	if harakBoyH = 0:'-<<$name[2]>>, в такой позе ты выглидишь просто неотразимо. Парень нежно поцеловал вас в щечку.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum2 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'belly'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum2.gif"></center>'
	''
	'<<$boy>> вытащил член, застонал и вы почувствовали как горячие капли спермы падают на ваш животик.'
	if harakBoyH = 2:'-Бля, было круто, <<$name[2]>>, <<$boy>> -младший тобой доволен. Парень страстно поцеловал вас.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_cum1 ={
	*clr & cla
	minut += 5
	sweat += 1
	if sex_temp > 0: sex_temp = 0 & sex += 1 & sexa += 1
	if bj_temp > 0: bj_temp = 0 & bj += 1 & bja += 1
	if hj_temp > 0: hj_temp = 0 & hj += 1 & hja += 1
	if kuni_temp > 0: kuni_temp = 0 & kuni += 1
	if anal_temp > 0: anal_temp = 0 & anal += 1 & anala += 1
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/cum1.gif"></center>'
	''
	'<<$boy>> застонал и вы почувствовали как вашу попу наполняет тепло.
	 -О да, крошка, ты просто супер. <<$boy>> чмокнул вас в лоб.'
	if silavag = 0 and dikos = 0:'Всё <<$name[2]>> харэ. Я больше не могу.'
	if silavag = 1 and dikos = 1:'Всё <<$name[2]>>. Я больше не могу.'
	if silavag = 2 and dikos = 2:'Всё <<$name[2]>>, хватит. Я больше не могу.'
	if silavag = 1 and dikos < 1 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
				''
			'Вы сказали парню, что ещё хотите.'
			'На что <<$boy>> ответил - "Пипец ты <<$name[2]>> ненасытная, я фигею".'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	if silavag = 2 and dikos < 2 and horny >= 60 and vagina > 0:
		act '<<$boy>>, ещё хочу.':
			*clr & cla
			dikos += 1
			minut += 5
			hanters_bj_times = 0
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
			''
			'Вы сказали парню, что ещё хотите.'
			'- Ну ты <<$name[2]>> и ненасытная, - улыбнулся в ответ вам <<$boy>>.'
			if vagina = 0:dynamic $din_hanters_bj
			if vagina > 0:
				i = rand(1,5)
				if i = 1: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
				if i = 2: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
				if i = 3: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
				if i = 4 and hanters_kuni = 1: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
				if i = 5: act 'Нагнуться':dynamic $din_hanters_sex_dog
			end
		end
	end
	act 'Отойти':hanters_bj_times = 0 & dikos = 0 & gt $loc, $metka
}
$din_hanters_sex_bell_anal ={
	*clr & cla
	minut += 10
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal20.gif"></center>'
	''
	'К счастью вы успели подготовить попку к аналу. Парень вытащил член из вашей киски и принялся ласкать вашу попку.'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	''
	'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cum5
}
$din_hanters_sex_cow_anal2 ={
	*clr & cla
	minut += 10
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal34.gif"></center>'
	''
	'К счастью вы успели подготовить попку к аналу. Парень вытащил член из вашей киски и принялся ласкать вашу попку.'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	''
	'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cum4
}
$din_hanters_sex_cow_anal1 ={
	*clr & cla
	minut += 10
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal3'+rand(0,1)+'.gif"></center>'
	''
	'К счастью вы успели подготовить попку к аналу. Парень вытащил член из вашей киски и принялся ласкать вашу попку. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	''
	'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cum4
}
$din_hanters_sex_cow_anal ={
	*clr & cla
	minut += 10
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal3'+rand(2,3)+'.gif"></center>'
	''
	'К счастью вы успели подготовить попку к аналу. Парень вытащил член из вашей киски и принялся ласкать вашу попку. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	''
	'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cum4
}
$din_hanters_sex_dog_anal ={
	*clr & cla
	minut += 10
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal1'+rand(0,1)+'.gif"></center>'
	''
	'К счастью вы успели подготовить попку к аналу. Парень вытащил член из вашей киски и принялся ласкать вашу попку. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	''
	'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cum3
}
$din_hanters_sex_misionary_anal ={
	*clr & cla
	minut += 10
	anal_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanal'+rand(0,1)+'.gif"></center>'
	''
	'К счастью вы успели подготовить попку к аналу. Парень вытащил член из вашей киски и принялся ласкать вашу попку. '
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick'
	''
	'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cum1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cum2
}
$din_hanters_sex_anal_no ={
	*clr & cla
	minut += 5
	anal_no = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexanalno.gif"></center>'
	''
	'-Прости <<$boy>>, но я не совсем готова. Ну если ты понимаешь, о чем я.'
	'-Понял я. Ладно, в следующий раз приходи с чистой попкой.'
	'<<$boy>> просит вас...'
	i = rand(1,4)
	if i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
}
$din_hanters_sex_69 ={
	*clr & cla
	minut += 5
	horny += rand(10,20)
	bj_temp += 1
	kuni_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex7'+rand(0,2)+'.gif"></center>'
	''
	'Вы сели на лицо парня и схватившись за его член, стали страстно сосать.
	 <<$boy>> умело облизывал вашу киску, вы постанывая и тяжело дыша продолжали сосать.'
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		'От умелых действий парня вас охватил оргазм.'
	else
		'Действия парня хоть и были возбуждающие, но они начали вас утомлять.'
	end
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h = 3: act 'Кончить':dynamic $din_hanters_sex_cumface7
}
$din_hanters_sex_hand_bonus ={
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex51.gif"></center>'
	''
	'Обвивая шею парня вы глубоко насаживаетесь на него, чувствуя как глубоко входит член.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum10
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum11
}
$din_hanters_sex_hand ={
	*clr & cla
	minut += 5
	sex_temp += 1
	pose = 2
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex50.gif"></center>'
	''
	'<<$boy>> взял вас в свои крепкие руки и резко вошел в вас.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Начать <a href="exec:dynamic $din_hanters_sex_hand_bonus">двигаться</a> парню навстречу.'
	''
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum10
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum11
}
$din_hanters_sex_bell_bonus1 ={
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus10.gif"></center>'
	'Расслаблено лежа на животе, вы лениво крутите попкой. <<$boy>> застывает и наслаждается происходящим.'
	if harakBoyH = 2: 'О да, моя кошечка, просто кайфую от твоей вкусной попки.'
	if harakBoyH = 2:'-Ухх, <<$name[2]>>, не останавливайся..'
	if harakBoyH < 2:'-Это супер, милая..'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_bell_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum5
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum9
}
$din_hanters_sex_bell_bonus ={
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus20.gif"></center>'
	'Вы страстно целуетесь, <<$boy>> продолжает грубо таранить вас сзади.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_bell_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum5
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum9
}
$din_hanters_sex_bell ={
	*clr & cla
	minut += 5
	sex_temp += 1
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex4'+rand(0,5)+'.gif"></center>'
	'Вы легли на живот и ваш парень пристроился сзади.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	 ''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	g = rand(1,2)
	if g = 1 and h < 3 and sex > 10:'Поднять голову и <a href="exec:dynamic $din_hanters_sex_bell_bonus">целоваться</a> с парнем.'
	if g = 2 and h < 3 and sex > 20:'Покрутить <a href="exec:dynamic $din_hanters_sex_bell_bonus1">попкой</a> пока член внутри.'
	''
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_bell_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum5
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum9
}
$din_hanters_sex_cow_bonus3 ={
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex61.gif"></center>'
	'Вы горячо поцеловались, прижимаясь друг другу все сильнее.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_cow_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum4
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum8
}
$din_hanters_sex_cow_bonus2 ={
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex60.gif"></center>'
	'<<$boy>> приподнялся и крепко и плотно прижал к себе. Вы приобняли его за шею, и двигаетесь и извиваете талию.'
	if harakBoyH = 2:'-Умм, какая горячая сучка, дай зацелую твои сисечки..'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	'Прильнуть к его губам и <a href="exec:dynamic $din_hanters_sex_cow_bonus3">целоваться</a>.'
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_cow_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum4
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum8
}
$din_hanters_sex_cow_bonus1 ={
	*clr & cla
	minut += 5
	pose = 2
	sex_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(17,19)+'.gif"></center>'
	''
	'Вы повернулись спиной к парню и продолжили скользить на нем своей мокрой киской.'
	if harakBoyH = 2:'-Ухх, детка, твоя жопа так выглядит просто охуенно..'
	if harakBoyH < 2:'-Круто выглядишь, <<$name[2]>>..'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_cow_anal2
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum41
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum81
}
$din_hanters_sex_cow_bonus ={
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(14,16)+'.gif"></center>'
	'<<$boy>> остановился, предоставляя вам всю инициативу. Вы начали ритмично двигаться и скакать.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	if sex > 30:'Повернуться к нему <a href="exec:dynamic $din_hanters_sex_cow_bonus1">спиной</a> и продолжить скакать на члене.'
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_cow_anal1
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum4
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum8
}
$din_hanters_sex_cow ={
	*clr & cla
	minut += 5
	sex_temp += 1
	pose = 2
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex2'+rand(0,1)+'.gif"></center>'
	''
	'<<$boy>> взял вас за руку чуть помогая вам, и вы сели на него сверху.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	g = rand(1,2)
	if g = 1 and h < 3 and sex > 20:'Дать парню передохнуть и <a href="exec:dynamic $din_hanters_sex_cow_bonus">прыгать</a> самой на крепком члене.'
	if g = 2 and h < 3 and sex > 10:'Попросить парня приподняться и <a href="exec:dynamic $din_hanters_sex_cow_bonus2">обнять</a> вас.'
	''
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_cow_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum4
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum8
}
$din_hanters_sex_dog_bonus ={
	*clr & cla
	minut += 5
	dom += 1
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(11,13)+'.gif"></center>'
	''
	'Не послувшавшись парня, вы начали двигать попой навстречу горячему члену.'
	if harakBoyH = 2:'<<$boy>> чуть сбавил свои движения, - "Отлично работаешь, жопастая сучка."'
	if harakBoyH = 1:'<<$boy>> чуть сбавил свои движения, - "Круто <<$name[2]>>."'
	if harakBoyH = 0:'<<$boy>> чуть сбавил свои движения, - "Ты умница просто,<<$name[2]>>."'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum3
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum7
}
$din_hanters_sex_dog_bonus1 ={
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(7,9)+'.gif"></center>'
	'Проигнорировав парня, вы лениво уткнулись лицом в мягкую постель.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum3
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum7
}
$din_hanters_sex_dog_bonus2 ={
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(21,22)+'.gif"></center>'
	'Вы вместе встали на ноги, <<$boy>> поддерживая вас продолжил яростно долбить вашу дырку.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum3
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum7
}
$din_hanters_sex_dog ={
	*clr & cla
	minut += 5
	sex_temp += 1
	pose = 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex1'+rand(0,3)+'.gif"></center>'
	'<<$boy>> поставил вас раком и вы сексуально прогнули спинку оттопырили попку перед ним.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	g = rand(1,2)
	if g = 1 and h < 3 and sex > 20:'Начать движения <a href="exec:dynamic $din_hanters_sex_dog_bonus">попой</a> ему навстречу.'
	if g = 1 and h < 3 and sex <= 20:'Уткнуться <a href="exec:dynamic $din_hanters_sex_dog_bonus1">лицом</a> в постель, продолжая трахаться в этой позе.'
	if g = 2 and h < 3 and sex > 20:'Попросить парня помочь вам <a href="exec:dynamic $din_hanters_sex_dog_bonus2">приподняться</a> .'
	''
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_dog_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Лечь на спину':dynamic $din_hanters_sex_misionary
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum3
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum7
}
$din_hanters_sex_misionary_bonus2 ={
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(5,6)+'.gif"></center>'
	'Вы страстно целуетесь, его ощущая жаркое дыхание. <<$boy>> продолжает вас трахать во время поцелуя.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_misionary_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum2
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum6
}
$din_hanters_sex_misionary_bonus1 ={
	*clr & cla
	minut += 5
	agil += 1
	dom += 1
	pose = 0
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus4.gif"></center>'
	'Не послувшавшись парня, вы достаточно ловко закинули ножки себе за голову, внутри все расстянулось и вы еще лучше почувствовали движение члена внутри.
-Ох, детка, ничего себе ты исполняешь.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_misionary_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':sexa += 1 & dynamic $din_hanters_sex_cum2
	if k = 2 and h = 3: act 'Кончить':sexa += 1 & dynamic $din_hanters_sex_cum6
}
$din_hanters_sex_misionary_bonus ={
	*clr & cla
	minut += 5
	dom += 1
	pose = 0
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(0,3)+'.gif"></center>'
	'Не послувшавшись парня, вы подняли свои ножки вверх, приоткрывая невероятный вид вашей киски, и предоставляя парню еще больше свободы.'
	'<<$boy>> продолжил яростно вас трахать в такой позе.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	''
	i = rand(1,4)
	j = rand(1,3)
	h = rand(1,3)
	if agil > 60 and dom > 30 and body['group'] < 2:'Закинуть ножки <a href="exec:dynamic $din_hanters_sex_misionary_bonus1">за голову</a> .'
	''
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and i = 1: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and i = 2: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if anal_no = 0 and h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_misionary_anal
	if anal_no = 0 and h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	if anal_no = 1 and h < 3 and j = 3 and i = 1: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if anal_no = 1 and h < 3 and j = 3 and i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if anal_no = 1 and h < 3 and j = 3 and i = 3: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if anal_no = 1 and h < 3 and j = 3 and i = 4: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum2
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum6
}
$din_hanters_sex_kuni_bonus ={
	*clr & cla
	minut += 5
	if silavag = 0: horny += 15
	if silavag = 1: horny += 20
	if silavag = 2: horny += 25
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsexbonus'+rand(23,24)+'.gif"></center>'
	if harakBoyH = 2:'-Что ты делаешь? О черт, <<$name[2]>>, только не это, и почему я разрешаю тебе такое дел.... '
	'Вы сели на парня, и третесь влажной киской об его лицо.'
	if harakBoyH > 0:'Ему это не сильно нравится, но он подолжает тщательно вам облизывать, вызывая у вас бурные чувства.'
	if harakBoyH = 0:'Судя по всему ему это даже нравится, и он подолжает тщательно вылизывать, вызывая у вас бурные чувства.'
	if horny >= 90:
		horny = 0
		manna += 15
		orgasm += 1
		'От умелых действий парня вас охватил оргазм.'
	else
		'Действия парня хоть и были возбуждающие, но они начали вас утомлять.'
	end
	''
	'Насладившись сладким куни своего парня.
	-Все, <<$boy>>, давай уже трахаться.'
	if harakBoyH > 0:'-Да бля, сама набросилась, как сумашедшая. Давай, а то член уже как каменный.'
	''
 	 i = rand(1,5)
	 if i = 1: act 'Продолжить':dynamic $din_hanters_sex_misionary
	 if i = 2: act 'Продолжить':dynamic $din_hanters_sex_cow
	 if i = 3: act 'Продолжить':dynamic $din_hanters_sex_dog
	 if i = 4: act 'Продолжить':dynamic $din_hanters_sex_bell
	 if i = 5: act 'Продолжить':dynamic $din_hanters_sex_hand
}
$din_hanters_sex_kuni = {
	*clr & cla
	minut += 5
	dom += 1
	gs 'stat'
	if hanters_kuni = 0:
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovecho.gif"></center>'
		if dom <= 50:
			'<<$boy>> отказался лизать вашу киску.'
			if harakBoyH = 2: '-Не <<$name[2]>>, отстань, не подобает нормальному мужику лизать пизду, лучше раздвинь ножки.'
			if harakBoyH = 0: 'Может в другой раз, милая'
			act 'Продолжить': dynamic $din_hanters_sex_misionary
		else
			if harakBoyH = 2:
				'<<$boy>> нехотя согласился полизать вам.'
				'-Ладно,<<$name[2]>>, только никому не говори, а то потеряю всякое уважение.'
			end
			if harakBoyH = 1: '<<$boy>> согласился полизать вам.'
			if harakBoyH = 0:
				'<<$boy>> с радостью согласился полизать вам.'
				'-<<$name[2]>>, я доставлю тебе неземное наслождение.'
			end
			act 'Раздвинуть ножки для куни':
				*clr & cla
				minut += 5
				hanters_kuni = 1
				kuni += 1
				kuni_temp += 1
				if silavag = 0: horny += 10
				if silavag = 1: horny += 15
				if silavag = 2: horny += 20
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex3'+rand(0,3)+'.gif"></center>'
				'<<$boy>> лег между ваших ног и начал работать язычком по вашей киске.'
				if horny >= 90:
					horny = 0
					manna += 15
					orgasm += 1
					'От умелых действий парня вас охватил оргазм.'
				else
					'Действия парня хоть и были возбуждающие, но они начали вас утомлять.'
				end
				''
				if dom >= 75: 'Уложить парня на спину и <a href="exec:dynamic $din_hanters_sex_kuni_bonus">сесть</a> на его лицо своей киской.'
				''
				i = rand(1,5)
				if i = 1: act 'Продолжить': dynamic $din_hanters_sex_misionary
				if i = 2: act 'Продолжить': dynamic $din_hanters_sex_cow
				if i = 3: act 'Продолжить': dynamic $din_hanters_sex_dog
				if i = 4: act 'Продолжить': dynamic $din_hanters_sex_bell
				if i = 5: act 'Продолжить': dynamic $din_hanters_sex_hand
			end
		end
	else
		kuni += 1
		kuni_temp += 1
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex3'+rand(0,3)+'.gif"></center>'
		'<<$boy>> лег между ваших ног и начал работать язычком по вашей киске.'
		if horny >= 90:
			horny = 0
			manna += 15
			orgasm += 1
			'От умелых действий парня вас охватил оргазм.'
		else
			'Действия парня хоть и были возбуждающие, но они начали вас утомлять.'
		end
		if dom >= 75:'Уложить парня на спину и <a href="exec:dynamic $din_hanters_sex_kuni_bonus">сесть</a> на его лицо своей киской.'
		''
		i = rand(1,5)
		if i = 1: act 'Продолжить': dynamic $din_hanters_sex_misionary
		if i = 2: act 'Продолжить': dynamic $din_hanters_sex_cow
		if i = 3: act 'Продолжить': dynamic $din_hanters_sex_dog
		if i = 4: act 'Продолжить': dynamic $din_hanters_sex_bell
		if i = 5: act 'Продолжить': dynamic $din_hanters_sex_hand
	end
}
$din_hanters_sex_misionary ={
	*clr & cla
	minut += 5
	sex_temp += 1
	pose = 0
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsex'+rand(0,3)+'.gif"></center>'
	''
	'<<$boy>> уложил вас на спину и раздвинул ваши ножки.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick',1
	''
	i = rand(1,9)
	j = rand(1,3)
	h = rand(1,3)
	g = rand(1,2)
	if g = 1 and h < 3 and sex > 30:'Вы наслаждаетесь каждым его движением, и хотите поднять ножки <a href="exec:dynamic $din_hanters_sex_misionary_bonus">вверх</a> .'
	if g = 2 and h < 3:'Вы громко стонете под своим парнем, <a href="exec:dynamic $din_hanters_sex_misionary_bonus2">поцеловать</a> парня.'
	''
	if hanters_kuni = 0 and dom > 30 and h < 3:'Попросить парня <a href="exec:dynamic $din_hanters_sex_kuni">полизать</a> вам киску.'
	''
	if h < 3:'Вдоволь насладившись в этой позе, парень просит вас...'
	if h = 3:'Внезапно <<$boy>> начал двигаться еще быстрее и вы поняли что он уже на грани и готов...'
	''
	if h < 3 and j < 3 and hanters_kuni = 0 and i = 8 or i = 1 or i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if h < 3 and j < 3 and hanters_kuni = 0 and i = 9 or i = 3 or i = 4: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if h < 3 and j < 3 and i = 5 or i = 6: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if h < 3 and j < 3 and i = 7: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	if h < 3 and j < 3 and hanters_kuni = 1 and i = 8: act 'Раздвинуть ножки для куни':dynamic $din_hanters_sex_kuni
	if h < 3 and j < 3 and hanters_kuni = 1 and i = 9: act 'Взаимно ласкать друг друга':dynamic $din_hanters_sex_69
	if h < 3 and j = 3 and klismaday = day: act 'Подставить попку':dynamic $din_hanters_sex_misionary_anal
	if h < 3 and j = 3 and klismaday ! day: act 'Подставить попку':dynamic $din_hanters_sex_anal_no
	k = rand(1,2)
	if k = 1 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum2
	if k = 2 and h = 3: act 'Кончить':dynamic $din_hanters_sex_cum6
}
$din_hanters_bj14 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj14'+rand(0,2)+'.gif"></center>'
	''
	h = rand(1,3)
	'<<$boy>> вставил свой член между ваших сисек <<body[''tits'']>>го размера и вы, плюнув и немного смазав член, сжали сиськи вместе. И ваш парень начал двигаться, жестко трахая ваши сиськи. Вы испытываете необычные, но приятные ощущения от этих действий.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,4)
		j = rand(1,4)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 4 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 4 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 4 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 4 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		act 'Кончить':dynamic $din_hanters_sex_cumface5
	end
}
$din_hanters_bj13 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj13'+rand(0,1)+'.gif"></center>'
	h = rand(1,3)
	'Крепко взявшись за член, вы проводите головкой по своим твердым чувствительным сосочкам. И парню и вам такой массаж доставляет массу эмоций.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,4)
		j = rand(1,4)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 4 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 4 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 4 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 4 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		act 'Кончить':dynamic $din_hanters_sex_cumface4
	end
}
$din_hanters_bj_bonus12 ={
	*clr & cla
	minut += 5
	if dick > throat: throat += 1
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus12.gif"></center>'
	'Вы попытались взять член еще глубжe, но у вас ничего не получилось, и едва не вырвало прямо на парня.'
	if harakBoyH = 2:' -Фу бля,<<$name[2]>>, если не можешь нормально глотать, то лучше потренируйся дома на банане, а не на моем хую.'
	if harakBoyH = 0:' -Не расстраивайся <<$name[2]>>, тяжело в учении, легко в бою.'
	if harakBoyH = 0:' -Не расстраивайся <<$name[2]>>, может в следующий раз получится.'
	act 'Продолжить':dynamic $din_hanters_bj12
}
$din_hanters_bj12 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj12'+rand(0,2)+'.gif"></center>'
	h = rand(1,3)
	'Вы начали сосать член не притрагиваясь к нему ручками, думая, что парню так вы доставите больше удовольствия.
	Член парня польностью не помещается в вашем рту, и вы причмокивая сосете лишь до половины.'
	''
	if hanters_bj_times < 3:'Попробовать <a href="exec:dynamic $din_hanters_bj_bonus12">заглотить</a> член глубже.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 : act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus11 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus11.gif"></center>'
	'Вы взяли и плотно прижали головку за щекой и <<$boy>> начал трахать вас в таком положении, расстягивая все лицо.'
	if harakBoyH = 2:'-О да, детка, давай еще немного, твое личико так сексуально выглядит.'
	if harakBoyH = 1:'-О да, <<$name[2]>>, давай еще немного, это круто.'
	if harakBoyH = 0:'-Милая, это супер, твое личико так сексуально выглядит.'
	act 'Продолжить':dynamic $din_hanters_bj11
}
$din_hanters_bj11 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj11'+rand(0,4)+'.gif"></center>'
	h = rand(1,3)
	'Вы хватаетесь за основание члена и начинаете жадно сосать. Член парня полностью не помещается в вашем маленьком ротике и входит лишь наполовину, вы сосете и нежно надрачиваете остальную часть.'
	''
	if hanters_bj_times < 3 and bj > 20:'Взять член <a href="exec:dynamic $din_hanters_bj_bonus11">за щеку</a> и плотно прижать головку.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 : act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
	i = rand(1,2)
	if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
	if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj10 ={
	*clr & cla
	minut += 5
	if dick > throat: throat += 1
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj10'+rand(0,3)+'.gif"></center>'
	''
	h = rand(1,3)
	'Вы подчинились парню и полностью расслабили горло. <<$boy>> начал двигать членом, погружаясь все глубже. Вы едва задыхаетесь но сдерживаете себя от рвотного порыва. Чувствуете как головка упирается и едва входит вам в горло и при этом делаете глотательные движения, сжимая головку внутри.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 : act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		act 'Кончить':dynamic $din_hanters_sex_cumface6
	end
}
$din_hanters_bj9 ={
	*clr & cla
	minut += 5
	if dick > throat: throat += 1
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj9'+rand(0,1)+'.gif"></center>'
	h = rand(1,3)
	'Вы начали ритмичные движения головой и глотаете член все глубже и глубже. Чувствуете как головка упирается и едва входит вам в горло и при этом делаете глотательные движения, сжимая головку внутри.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
	k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 : act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		act 'Кончить':dynamic $din_hanters_sex_cumface6
	end
}
$din_hanters_bj_bonus8 ={
	*clr & cla
	minut += 5
	dom += 1
	if harakBoyH > 0:hanters_bj_times -= 1
	if harakBoyH = 0:hanters_bj_times += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus8.gif"></center>'
	'Пока <<$boy>> продолжал наслаждаться, вы засунули кончик языка внутрь, и парень вздрогнул от неожиданности'
	if harakBoyH = 2:'-Решила трахнуть меня в жопу своим языком? Не, <<$name[2]>>, мне такое не по душе, прекрати нахуй это дело'
	if harakBoyH = 1:'- Лучше не нужно <<$name[2]>> , прекрати.'
	if harakBoyH = 0:'- Кайф <<$name[2]>> , не останавливайся, - попросил <<$boy>>.'
	act 'Продолжить':dynamic $din_hanters_bj8
}
$din_hanters_bj8 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj8'+rand(0,1)+'.gif"></center>'
	h = rand(1,3)
	'Вы спустились еще ниже, проведя языком ниже яичек, достигли ануса парня и начали ритмично дразнить кончиком языка.'
	'-Ой бля,<<$name[2]>>, что ты делаешь? Хотя охуенно, но только пацанам про это не рассказывай.'
	''
	if hanters_bj_times < 3 and dom > 0:'Попробовать пойти ещё дальше и <a href="exec:dynamic $din_hanters_bj_bonus8">засунуть</a> язык в дырку.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times >= 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 1 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 1 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 1 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus7 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus7.gif"></center>'
	'Вы продолжили играться с яичками парня и обхватив их <<$liptalk>>, поместили их в рот, дразня внутри языком.'
	'-Охуенно, детка, не останавливайся'
	act 'Продолжить':dynamic $din_hanters_bj7
}
$din_hanters_bj7 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj7'+rand(0,4)+'.gif"></center>'
	h = rand(1,3)
	'Вы спускаетесь ниже, нежно проводите язычком и облизываете яйца, покрывая их своей слюной.'
	''
	if hanters_bj_times < 3 and bj > 15:'Сосать и <a href="exec:dynamic $din_hanters_bj_bonus7">взять</a> яйца в рот.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 1 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 1 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 1 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus6 ={
	*clr & cla
	minut += 5
	dom += 1
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus6.gif"></center>'
	''
	'<<$boy>> шлепает членом по вашему языку.'
	if harakBoyH = 2:'-Плохая девочка, ща папочка тебя накажет.'
	if harakBoyH < 2:'- А ты оказывается развратная девчонка, - с улыбкой говорит он.'
	act 'Продолжить':dynamic $din_hanters_bj6
}
$din_hanters_bj6 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	hj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj6'+rand(0,1)+'.gif"></center>'
	h = rand(1,3)
	'Захватив член в свои цепкие руки, вы начали его уверенно надрачивать, и наблюдаете за реакцией парня.'
	if harakBoyH > 0:'-Неплохо,<<$name[2]>>, но дрочить я и сам себе могу, ты там давай включай все свои женские инструменты.'
	if harakBoyH = 0:'-Давай,<<$name[2]>>, покажи, на что ты способна,- с улыбкой говорит <<$boy>>, глядя вам в глаза.'
	''
	if hanters_bj_times < 3 and bj > 10:'Высунуть язык и <a href="exec:dynamic $din_hanters_bj_bonus6">шлепать</a> по нему горячей головкой.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		j = rand(1,4)
		if i = 1 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 1 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 1 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 1 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
		if i = 3 and j = 1: act 'Лизать головку':dynamic $din_hanters_bj1
		if i = 3 and j = 2: act 'Сосать головку':dynamic $din_hanters_bj2
		if i = 3 and j = 3: act 'Поцеловать головку':dynamic $din_hanters_bj3
		if i = 3 and j = 4: act 'Провести языком':dynamic $din_hanters_bj5
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		act 'Кончить':dynamic $din_hanters_sex_cumface3
	end
}
$din_hanters_bj_bonus5 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	lubonus += rand(1,3)
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus5.gif"></center>'
	'Вы плюнулю на член, и хорошенько ладошкой размазали слюну по всему члену.'
	' -Ухх,<<$name[2]>>, так и на смазку можно совсем не тратиться.'
	act 'Продолжить':dynamic $din_hanters_bj5
}
$din_hanters_bj5 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj5'+rand(0,3)+'.gif"></center>'
	h = rand(1,3)
	'Вы проводите влажным языком по всей длине пениса, смазывая его свой липкой слюной.'
	''
	if hanters_bj_times < 3 and bj > 20:'Смазать член и <a href="exec:dynamic $din_hanters_bj_bonus5">плюнуть</a> на него порцией своей липкой слюны.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus4 ={
	*clr & cla
	minut += 5
	dom -= 1
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus4.gif"></center>'
	''
	'Взявшись за основание члена, вы выполняете просьбу парня, и шлепаете головкой по вашим щекам.'
	if harakBoyH = 2:'-О да, ты моя покорная сучка, так меня заводишь,продолжай.'
	if harakBoyH = 0:'-О да, так меня заводишь, давай продолжай милая.'
	act 'Продолжить':dynamic $din_hanters_bj4
}
$din_hanters_bj4 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj4'+rand(0,1)+'.gif"></center>'
	h = rand(1,3)
	'Перед тем как облизнуть и приняться сосать сладкий член, вы слегка обхватили член рукой и натянули кожу, оголяя сверкающую головку.'
	''
	if hanters_bj_times < 3 and dom < 30:'<<$boy>> просит вас <a href="exec:dynamic $din_hanters_bj_bonus4">шлепнуть</a> членом по вашей щечке.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
	i = rand(1,3)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus3 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus3.gif"></center>'
	''
	'Смотря в глаза своего парня, вы дразните язычком одну из самых эрогенных зон члена.'
	'-Класс, <<$name[2]>>, знаешь как меня завести еще сильнее.'
	act 'Продолжить':dynamic $din_hanters_bj3
}
$din_hanters_bj3 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj3'+rand(0,1)+'.gif"></center>'
	h = rand(1,3)
	'Вы покрываете член сладкими поцелуями, нежно его касаясь своими <<$liptalk>>'
	''
	if hanters_bj_times < 3:'Можно слегка <a href="exec:dynamic $din_hanters_bj_bonus3">подразнить</a> тонкую уздечку члена'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus2 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus2.gif"></center>'
	'Решивишсь слегка укусить его, вы нежно прикусываете головку своими белыми зубами.'
	if harakBoyH = 2:'-Эй, бля, <<$name[2]>>, ты че, мой член с бананом перепутала? Не шути так больше.'
	if harakBoyH < 2:'-Осторожно, <<$name[2]>>, не шути так больше.'
	'Вы с улыбкой посмотрели на него и решили...'
	act 'Продолжить':dynamic $din_hanters_bj2
}
$din_hanters_bj2 ={
	*clr & cla
	minut += 5
	bj_temp += 1
	hanters_bj_times += 1
	if pirsA = 0:$textsexkotov = 'причмокивая сосете головку'
	if pirsA > 0:$textsexkotov = 'причмокивая сосете головку чувствуя как штанга в вашем языке шевелится от ударов о член'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj2'+rand(0,6)+'.gif"></center>'
	h = rand(1,3)
	'Вы <<$textsexkotov>>, и плотно его сжимаете своими <<$liptalk>> '
	'Нежность ваших губ сводит парня с ума'
	''
	if hanters_bj_times < 3:'Попробовать слегка <a href="exec:dynamic $din_hanters_bj_bonus2">укусить</a> красную головку члена'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
		k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj_bonus1 ={
	*clr & cla
	minut += 5
	hanters_bj_times -= 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbjbonus1.gif"></center>'
	'Вы засунули кончик языка в маленькую дырочку головки члена.'
	if harakBoyH = 2:'<<$boy>> от этого аж вздрогнул: -<<$name[2]>>, что ты делаешь, перестань, я ща кончу бля от этого.'
	if harakBoyH < 2:'<<$boy>> от этого аж вздрогнул: -<<$name[2]>>, что ты делаешь, перестань, так же и кончить сразу можно.'
	act 'Продолжить':dynamic $din_hanters_bj1
}
$din_hanters_bj1 ={
	*clr & cla
	minut += 5
	hanters_bj_times += 1
	bj_temp += 1
	if pirsA = 0:$textsexkotov = 'лижете язычком головку'
	if pirsA > 0:$textsexkotov = 'лижете язычком головку чувствуя как штанга в вашем языке шевелится от ударов об член'
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj1'+rand(0,3)+'.gif"></center>'
	h = rand(1,3)
	'Вы <<$textsexkotov>>'
	'Нежно и быстро щекочете кончиком языка самую вершину головки, ее отверстие.'
	''
	if hanters_bj_times < 3:'<a href="exec:dynamic $din_hanters_bj_bonus1">Засунуть</a> кончик языка в дырочку.'
	''
	if h < 3 and hanters_bj_times = 3:'Вдоволь насладившись вашими оральными ласками, парень просит вас...'
	''
	if hanters_bj_times < 3 and hanters_bj_times >= 1:
	k = rand(1,5)
		if k = 1:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_misionary">лечь на спину</a>.'
		if k = 2:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_cow">запрыгнуть на парня</a>.'
		if k = 3:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_dog">нагнуться</a>.'
		if k = 4:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_bell">лечь на живот</a>.'
		if k = 5:'Вы можете прекратить минет и <a href="exec:dynamic $din_hanters_sex_hand">запрыгнуть на руки</a>.'
	end
	''
	if h = 3 and hanters_bj_times = 3:'Внезапно член парня еще сильнее налился кровью и начал пульсировать, и вы поняли, что он уже на грани и готов...'
	''
	if hanters_bj_times < 3:
		i = rand(1,3)
		if i = 1: act 'Дрочить':dynamic $din_hanters_bj6
		if i = 2 and dom >= 10 and dom < 30: act 'Лизать яйца':dynamic $din_hanters_bj7
		if i = 2 and dom < 10: act 'Лизать очко':dynamic $din_hanters_bj8
		if i = 3 and dom >= 30 and throat > 15: act 'Заглотить глубоко':dynamic $din_hanters_bj9
		if i = 3 and dom < 30 and throat > 15: act 'Расслабить горло':dynamic $din_hanters_bj10
		if i = 3 and dom >= 30 and throat <= 15: act 'Сосать подрачивая':dynamic $din_hanters_bj11
		if i = 3 and dom < 30 and throat <= 15: act 'Сосать без рук':dynamic $din_hanters_bj12
		if i = 2 and dom >= 30 and body['tits'] < 3: act 'Провести вокруг соска':dynamic $din_hanters_bj13
		if i = 2 and dom >= 30 and body['tits'] >=3: act 'Сжать между сисек':dynamic $din_hanters_bj14
	elseif h < 3 and hanters_bj_times >= 3:
		i = rand(1,5)
		if i = 1: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if i = 2: act 'Сесть сверху':dynamic $din_hanters_sex_cow
		if i = 3: act 'Нагнуться':dynamic $din_hanters_sex_dog
		if i = 4: act 'Лечь на живот':dynamic $din_hanters_sex_bell
		if i = 5: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
	elseif h = 3 and hanters_bj_times >= 3:
		i = rand(1,2)
		if i = 1: act 'Кончить':dynamic $din_hanters_sex_cumface1
		if i = 2: act 'Кончить':dynamic $din_hanters_sex_cumface2
	end
}
$din_hanters_bj200 ={
	*clr & cla
	minut += 5
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovbj'+rand(0,5)+'.gif"></center>'
	'Вы опустились на колени перед парнем. Он с интересом смотрит на вас, ожидая ваших действий. И вы принимаетесь...'
	''
	if bj >= 10 and bj < 15: act 'Лизать головку':dynamic $din_hanters_bj1
	if bj >= 20: act 'Сосать головку':dynamic $din_hanters_bj2
	if bj >= 5 and bj < 10: act 'Поцеловать головку':dynamic $din_hanters_bj3
	if bj < 5: act 'Ласкать ладошкой':dynamic $din_hanters_bj4
	if bj >= 15 and bj < 20: act 'Провести языком':dynamic $din_hanters_bj5
}
$din_hanters_sub ={
	*clr & cla
	minut += 5
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovsub.jpg"></center>'
	'Вы как послушная девочка, полностью подчиняетесь воле парня. Еще немного поласкавшись, <<$boy>> просит вас...'
	i = rand(1,8)
	if i = 1 or i = 7: act 'Опуститься на колени':dynamic $din_hanters_bj200
	if i = 2 or i = 8: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
	if i = 3: act 'Сесть сверху':dynamic $din_hanters_sex_cow
	if i = 4: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if i = 5: act 'Лечь на живот':dynamic $din_hanters_sex_bell
	if i = 6: act 'Запрыгнуть на руки':dynamic $din_hanters_sex_hand
}
$din_hanters_first_sex ={
	*clr & cla
	minut += 30
	sexa += 1
	hantersVagSex += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovfirst.jpg"></center>'
	''
	'<<$boy>> уложил вас на спину и раздвинул ножки, приоткрывая ваше девственное лоно.'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Приходить в себя':
		*clr & cla
		minut += 5
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovfirst1.jpg"></center>'
		''
		if harakBoyH = 2:'Ох,<<$name[2]>>, ты охуенная девочка, поздравляю, теперь ты настоящая баба. Как себя чувствуешь?'
		if harakBoyH = 1:'Ну вот <<$name[2]>>, поздравляю, ты больше не девочка. Как себя чувствуешь?'
		if harakBoyH = 0:'-<<$name[2]>>, все хорошо, как ты себя чувствуешь? '
		'-Все болит блин, никогда больше не буду этим заниматься.'
		if harakBoyH = 2:'-Ха ха, это мы еще посмотрим, еще добавки просить будешь.'
		if harakBoyH = 1:'- Да ладно тебе, все через девушки это проходят.'
		if harakBoyH = 0:'- Успокойся, милая, в следующий раз будет гораздо лучше, тебе еще понравится, обещаю, - с улыбкой произнес <<$boy>> и нежно вас поцеловал.'
		act 'Далее':gt $loc, $metka
	end
}
if hantersIgorLove > 0 and hantersIgorQw <= 50:
	*clr & cla
	dick = 16
	silavag = 2
	harakBoyH = 0
	$boy = 'Игорь'
	minut += 5
	if hantersIgorLove = 2: bfa += 1
	if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
	boyonceA = 1
	hanters_bj_times = 0
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/gadukino/Swamp/IgorHanter.jpg"></center>'
	'<<$boy>> обнял вас и начал целовать. "<<$name[2]>>, раздевайся."'
	if vagina = 0 and sex = 0:
		if school['vacation'] = 0:
			act 'Я еще девочка':
				*clr & cla
				minut += 5
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif"></center>'
				if hantersIgorQw <= 45:'Вы, покраснев, прошептали парню, что вы еще девочка. <<$boy>> растерянно почесал подбородок "Вот блин, да еще и школу не окончила. Ну тогда может в рот или попу?."'
				if hantersIgorQw <= 45 and klismaday ! day:
					' - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...'
					' - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
				end
				if hantersIgorQw > 45:
					'-<<$name[2]>>, я хочу быть первым твоим мужчиной, я не сделаю тебе больно, только если чуть-чуть.'
					'-<<$boy>>, милый, я сама очень хочу, но если мама узнает, она меня просто убьет.'
					'-Ну узнает? Скажешь, что у нас все серьезно, любовь и все прочее...'
				end
				''
				if hantersIgorQw <= 45:dynamic $din_hanters_bj
				if hantersIgorQw > 45: act 'Лишиться невинности':dynamic $din_hanters_first_sex
				if hantersIgorQw > 45:
					act 'Расстаться с парнем':
						*clr & cla
						minut += 5
						if hantersIgorLove = 2:bfA = 0
						hantersIgorLove = 0
						hantersIgorQw -= 100
						dom += 1
						gs 'stat'
						'<center><H4>Изба</H4></center>'
						'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif"></center>'
						'-Прости, <<$boy>>, я бы очень хотела, но пока мне рано.'
						'-<<$name[2]>>, я нормальный парень и хочу нормального секса со своей девушкой, раз мы встречаемся.'
						'-<<$boy>>, я уже сказала нет. И я думаю нам лучше растаться, раз ты меня не хочешь понять.'
						''
						'Вы расстались с парнем'
						act 'Уйти':gt $loc, $metka
					end
				end
			end
		else
			act 'Я еще девочка':
				*clr & cla
				minut += 5
				gs 'stat'
				'Вы сказали парню, что вы еще девочка. <<$boy>> улыбнулся "<<$name[1]>> ты же школу закончила, взрослая уже теперь. Не ну конечно можешь взять в рот или дать в попу."'
				dynamic $din_hanters_bj
				act 'Лишиться невинности':dynamic $din_hanters_first_sex
			end
		end
	else
		act 'Раздеваться':
			*clr & cla
			minut += 5
			gs 'stat'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif"></center>'
			'Вы быстро скинули с себя одежду и <<$boy>> тоже разделся.'
			if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
			if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
			if mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
			if mesec > 0:dynamic $din_hanters_bj
		end
	end
elseif hantersIgorLove > 0 and hantersIgorQw > 50:
	dick = 16
	silavag = 2
	harakBoyH = 0
	hanters_bj_times = 0
	$boy = 'Игорь'
	if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
	if hantersIgorLove = 2: bfa += 1
	boyonceA = 1
	minut += 5
	horny += rand(10,20)
	gs 'stat'
	i = rand(1,3)
	if horny >= 60:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre'+rand(0,4)+'.gif"></center>'
		'<<$boy>> начал вас обнимать и целовать. Вас дико заводят эти ласки, и вы вместе возбуждаетесь еще сильнее'
	end
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
	act 'Запрыгнуть на него':
		*clr & cla
		minut += 5
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre2'+rand(0,3)+'.gif"></center>'
		'Вы запрыгнули на колени своего парня.
Продолжаете с ним целоваться и нежно третесь промежностью об его каменный ствол'
		if horny >= 80 and mesec <= 0: act 'Сесть на член':dynamic $din_hanters_sex_cow
		if horny < 80 and mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
		if mesec > 0:dynamic $din_hanters_bj
	end
	act 'Раздеваться':
		*clr & cla
		minut += 5
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif"></center>'
		'Вы быстро скинули с себя одежду и <<$boy>>, не отрывая от вас взгляда тоже разделся.'
		if dom > 50 and mesec <= 0: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
		if dom > 30 and mesec <= 0: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if dom > 10 and mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
		if dom <= 10 and mesec <= 0: act 'Подчиниться парню':dynamic $din_hanters_sub
		if mesec > 0:dynamic $din_hanters_bj
	end
elseif horny < 60 and i = 1:
	*clr & cla
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre30.gif"></center>'
	'<<$boy>> закинул вас на кровать и набросился сверху'
	'Вы долго целуетесь, <<$boy>> успел сорвать с вас одежду и еще сильнее возбудиться'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
	''
	if mesec <= 0: act 'Раздвинуть ножки':dynamic $din_hanters_sex_misionary
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 2 and hanters_kuni = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre50.gif"></center>'
	'<<$boy>> бросил вас на кровать и жадно прильнул губами между ваших ножек'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
	''
	if mesec <= 0: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 2 and hanters_kuni = 0:
	*clr & cla
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre60.gif"></center>'
	'Вы целуетесь с парнем, раздевая друг друга, он ласкает ваши сиськи, вы дотронулись до его члена и начали нежно его массировать.
<<$boy>> немного давит на ваши плечи и вы все прекрасно понимаете...'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
	''
	if mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 3:
	*clr & cla
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre4'+rand(0,2)+'.gif"></center>'
	'Ворвавшись в комнату, <<$boy>> поставил вас раком, и раздевая ласкает вашу попу'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
	''
	if mesec <= 0: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if mesec > 0:dynamic $din_hanters_bj
end
if hantersAndreiLove > 0 and vagina = 0:
	dick = 20
	silavag = 0
	harakBoyH = 2
	$boy = 'Андрей'
	minut += 5
	hanters_bj_times = 0
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/gadukino/Swamp/AndreiHanter.jpg"></center>'
	'<<$boy>> обнял вас и начал целовать. "<<$name[2]>>, раздевайся."'
	act 'Я еще девочка':
		*clr & cla
		minut += 5
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif"></center>'
		'Вы, покраснев, прошептали парню, что вы еще девочка.'
		'-<<$name[2]>>, я хочу быть первым твоим мужчиной, я не сделаю тебе больно, не бойся.
-<<$boy>>, милый, я сама очень хочу, но если мама узнает, она меня просто убьет.
-Ну узнает? И что? Короче выбирай, или мама или я...'
		act 'Лишиться невинности':dynamic $din_hanters_first_sex
		act 'Расстаться с парнем':
			*clr & cla
			minut += 5
			hantersAndreiLove = 0
			hantersAndreiQw -= 1
			dom += 1
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif"></center>'
			'-Прости, <<$boy>>, я бы очень хотела, но пока мне рано.
-<<$name[1]>>, я нормальный мужик и хочу нормального секса с тобой, раз мы решили быть вместе.
-<<$boy>>, я уже сказала нет. И я думаю нам лучше растаться, раз ты меня не хочешь понять.'
			''
			'Вы расстались с парнем'
			act 'Уйти':gt $loc, $metka
		end
	end
elseif hantersAndreiLove > 0 and vagina > 0:
	dick = 20
	silavag = 0
	harakBoyH = 2
	hanters_bj_times = 0
	$boy = 'Андрей'
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	minut += 5
	horny += rand(10,20)
	gs 'stat'
	i = rand(1,3)
	if horny >= 60:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre'+rand(0,4)+'.gif"></center>'
		'<<$boy>> начал вас обнимать и целовать.
Вас дико заводят эти ласки, и вы вместе возбуждаетесь еще сильнее'
		if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, можно же в зад или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Да бля, <<$name[1]>>, скажи что у тебя еще голова болит - сказал <<$boy>>. - Ладно, в следующий раз незабудь почистить.'
		if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, <<$name[1]>>, можно же в зад или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
		act 'Запрыгнуть на него':
			*clr & cla
			minut += 5
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre2'+rand(0,3)+'.gif"></center>'
			'Вы запрыгнули на колени своего парня. Продолжаете с ним целоваться и нежно третесь промежностью об его каменный ствол'
			''
			if horny >= 80 and mesec <= 0: act 'Сесть на член':dynamic $din_hanters_sex_cow
			if horny < 80 and mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
			if mesec > 0:dynamic $din_hanters_bj
		end
		act 'Раздеваться':
			*clr & cla
			minut += 5
			gs 'stat'
			'<center><H4>Изба</H4></center>'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif"></center>'
			'Вы быстро скинули с себя одежду и <<$boy>>, не отрывая от вас взгляда тоже разделся.'
			if dom > 50 and mesec <= 0: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
			if dom > 30 and mesec <= 0: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
			if dom > 10 and mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
			if dom <= 10 and mesec <= 0: act 'Подчиниться парню':dynamic $din_hanters_sub
			if mesec > 0:dynamic $din_hanters_bj
		end
	end
elseif horny < 60 and i = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre30.gif"></center>'
	'<<$boy>> закинул вас на кровать и набросился сверху'
	'Вы долго целуетесь, <<$boy>> успел сорвать с вас одежду и еще сильнее возбудиться'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, можно же в зад или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Да бля, <<$name[1]>>, скажи что у тебя еще голова болит - сказал <<$boy>>. - Ладно, в следующий раз незабудь почистить.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, <<$name[1]>>, можно же в зад или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Раздвинуть ножки':dynamic $din_hanters_sex_misionary
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 2 and hanters_kuni = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre50.gif"></center>'
	'<<$boy>> бросил вас на кровать и жадно прильнул губами между ваших ножек'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, можно же в зад или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Да бля, <<$name[1]>>, скажи что у тебя еще голова болит - сказал <<$boy>>. - Ладно, в следующий раз незабудь почистить.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, <<$name[1]>>, можно же в зад или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 2 and hanters_kuni = 0:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre60.gif"></center>'
	''
	'Вы целуетесь с парнем, раздевая друг друга, он ласкает ваши сиськи, вы дотронулись до его члена и начали нежно его массировать.
<<$boy>> немного давит на ваши плечи и вы все прекрасно понимаете...'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, можно же в зад или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Да бля, <<$name[1]>>, скажи что у тебя еще голова болит - сказал <<$boy>>. - Ладно, в следующий раз незабудь почистить.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, <<$name[1]>>, можно же в зад или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 3:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre4'+rand(0,2)+'.gif"></center>'
	'Ворвавшись в комнату, <<$boy>> поставил вас раком, и раздевая ласкает вашу попу'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, можно же в попку или в ротик, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Да бля, <<$name[1]>>, скажи что у тебя еще голова болит - сказал <<$boy>>. - Ладно, в следующий раз незабудь почистить.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Да хрен с ним, <<$name[1]>>, можно же в попку или в ротик, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if mesec > 0:dynamic $din_hanters_bj
end
if hantersSergeiLove > 0 and hantersIgorQw <= 40:
	dick = 18
	silavag = 1
	harakBoyH = 1
	$boy = 'Сергей'
	minut += 5
	if hantersergeisex = 0: hantersergeisex = 1 & guy += 1
	boyonceA = 1
	hanters_bj_times = 0
	gs 'stat'
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/gadukino/Swamp/SergeiHanter.jpg"></center>'
	'<<$boy>> обнял вас и начал целовать. "<<$name[2]>>, раздевайся."'
	if vagina = 0 and sex = 0:
		if school['vacation'] = 0:
			act 'Я еще девочка':
				*clr & cla
				minut += 5
				gs 'stat'
				'<center><H4>Изба</H4></center>'
				'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif"></center>'
				''
				if hantersIgorQw <= 35:'Вы, покраснев, прошептали парню, что вы еще девочка. <<$boy>> растерянно почесал подбородок "Вот блин, да еще и школу не окончила. Ну тогда может в рот или попу?."'
				if hantersIgorQw <= 35 and klismaday ! day:
					' - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...'
					'- Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попой.'
				end
				if hantersIgorQw > 35:
					'-<<$name[2]>>, я хочу быть первым твоим мужчиной, я не сделаю тебе больно.'
					'-<<$boy>>, милый, я сама очень хочу, но если мама узнает, она меня просто убьет.'
					'-Ну узнает? Скажешь, что у нас любовь и все.'
				end
				if hantersIgorQw <= 35: dynamic $din_hanters_bj
				if hantersIgorQw > 35: act 'Лишиться невинности': dynamic $din_hanters_first_sex
				if hantersIgorQw > 35:
					act 'Расстаться с парнем':
						*clr & cla
						minut += 5
						hantersSergeiLove = 0
						hantersSergeiQw -= 100
						dom += 1
						gs 'stat'
						'<center><H4>Изба</H4></center>'
						'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovotkaz.gif"></center>'
						'-Прости, <<$boy>>, я бы очень хотела, но пока мне рано.'
						'-<<$name[1]>>, я нормальный парень и хочу нормального секса с тобой.'
						'-<<$boy>>, я уже сказала нет. И я думаю нам лучше растаться, раз ты меня не хочешь понять'
						''
						'Вы расстались с парнем'
					end
					act 'Уйти':gt $loc, $metka
				end
			end
		else
			act 'Я еще девочка':
				*clr & cla
				minut += 5
				gs 'stat'
				'Вы сказали парню, что вы еще девочка. <<$boy>> улыбнулся "<<$name[1]>> ты же школу закончила, взрослая уже теперь. Не ну конечно можешь взять в рот или дать в попу."'
				dynamic $din_hanters_bj
				act 'Лишиться невинности':dynamic $din_hanters_first_sex
			end
		end
	else
		act 'Раздеваться':
			*clr & cla
			minut += 5
			gs 'stat'
			'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif"></center>'
			'Вы быстро скинули с себя одежду и <<$boy>> тоже разделся.'
			if mesec > 0 and klismaday ! day:
				' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.'
				' - Ничего страшного, <<$name[1]>>, можно же в попку или в ротик, - ответил он.'
				' - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...'
				' - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
			end
			if mesec > 0 and klismaday = day:
				' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.'
				' - Ничего страшного, <<$name[1]>>, можно же в попку или в ротик, - ответил он.'
				' - Ну ладно... - пробормотали вы.'
			end
			if mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
			if mesec > 0:dynamic $din_hanters_bj
		end
	end
elseif hantersSergeiLove > 0 and hantersSergeiQw > 45:
	dick = 18
	silavag = 1
	harakBoyH = 1
	hanters_bj_times = 0
	$boy = 'Сергей'
	if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
	boyonceA = 1
	minut += 5
	horny += rand(10,20)
	gs 'stat'
	i = rand(1,3)
	if horny >= 60:
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre'+rand(0,4)+'.gif"></center>'
		'<<$boy>> начал вас обнимать и целовать. Вас дико заводят эти ласки, и вы вместе возбуждаетесь еще сильнее'
	end
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	act 'Запрыгнуть на него':
		*clr & cla
		minut += 5
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre2'+rand(0,3)+'.gif"></center>'
		'Вы запрыгнули на колени своего парня.
Продолжаете с ним целоваться и нежно третесь промежностью об его каменный ствол'
		if horny >= 80 and mesec <= 0: act 'Сесть на член':dynamic $din_hanters_sex_cow
		if horny < 80 and mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
		if mesec > 0:dynamic $din_hanters_bj
	end
	act 'Раздеваться':
		*clr & cla
		minut += 5
		gs 'stat'
		'<center><H4>Изба</H4></center>'
		'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre1'+rand(0,6)+'.gif"></center>'
		'Вы быстро скинули с себя одежду и <<$boy>>, не отрывая от вас взгляда тоже разделся.'
		if dom > 50 and mesec <= 0: act 'Запрыгнуть сверху':dynamic $din_hanters_sex_cow
		if dom > 30 and mesec <= 0: act 'Раздвинуть ноги':dynamic $din_hanters_sex_misionary
		if dom > 10 and mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
		if dom <= 10 and mesec <= 0: act 'Подчиниться парню':dynamic $din_hanters_sub
		if mesec > 0:dynamic $din_hanters_bj
	end
elseif horny < 60 and i = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre30.gif"></center>'
	'<<$boy>> закинул вас на кровать и набросился сверху'
	'Вы долго целуетесь, <<$boy>> успел сорвать с вас одежду и еще сильнее возбудиться'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Раздвинуть ножки':dynamic $din_hanters_sex_misionary
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 2 and hanters_kuni = 1:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre50.gif"></center>'
	'<<$boy>> бросил вас на кровать и жадно прильнул губами между ваших ножек'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Наслаждаться':dynamic $din_hanters_sex_kuni
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 2 and hanters_kuni = 0:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre60.gif"></center>'
	''
	'Вы целуетесь с парнем, раздевая друг друга, он ласкает ваши сиськи, вы дотронулись до его члена и начали нежно его массировать.
<<$boy>> немного давит на ваши плечи и вы все прекрасно понимаете...'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Опуститься на колени':dynamic $din_hanters_bj200
	if mesec > 0:dynamic $din_hanters_bj
elseif horny < 60 and i = 3:
	'<center><H4>Изба</H4></center>'
	'<center><img src="images/qwest/alter/ev/Kotovsexsyst/kotovpre4'+rand(0,2)+'.gif"></center>'
	'Ворвавшись в комнату, <<$boy>> поставил вас раком, и раздевая ласкает вашу попу'
	if mesec > 0 and klismaday ! day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ой, а в попу не получится <<$boy>>, я не совсем готова. Ну если ты понимаешь, о чем я...
 - Понял я, - сказал <<$boy>>. - Ладно, в следующий раз приходи с чистой попкой.'
	if mesec > 0 and klismaday = day: ' - <<$boy>>, блин, у меня эти самые дни, - растерянно сказали вы.
 - Ничего страшного, <<$name[2]>>, можно же в попу или в рот, - ответил он.
 - Ну ладно... - пробормотали вы.'
	if mesec <= 0: act 'Нагнуться':dynamic $din_hanters_sex_dog
	if mesec > 0:dynamic $din_hanters_bj
end