if $ARGS[0] = 'start':
	cla & *clr
	cleWTDay = day
	minut += 30
	sweat += 1
	if vital < 15:vital += RAND(0,1)
	if stren < 15:stren += RAND(0,1)
	gs'stat'
	gs 'zz_render','','images/pic/clener1.jpg','Вы взяли швабру, налили ведро воды и стали мыть пол в женском туалете.'
	WomanToilet_rnd = rand(0,6)
	if DrunkGirl_end = 0 and WomanToilet_rnd = 0:
		*p '<table><tr><td><img src="images/wannabe/voskl40.png"></td><td><font color="black" SIZE="4" FACE="Calibri">Внезапно дверь туалета распахнулась и в него буквально ввалилась пьяная в стельку девушка. Она посмотрела на вас невидящим взглядом и неровной походкой направилась к туалетной кабинке. Зайдя в кабинку, она отставила дверь открытой и через секунду оттуда раздался сильный грохот.</font></td></tr></table>'
		act 'Подойти посмотреть, что случилось': gt 'VokzalWomanToilet','DrunkGirl'
		else
	end
	if WomanToilet_rnd > 2:
		gs 'zz_render','','','По звукам доносящимся из одной туалетной кабинке вы понимаете, что там кто-то есть. Дверцы всех кабинок в туалете выломаны, так что при желании вы можете заглянуть внутрь.'
		if voyeurism > 40: act 'Заглянуть в кабинку': gt 'VokzalWomanToilet','PissGirl'
		elseif WomanToilet_rnd > 4:
		gs 'zz_render','','','В туалет заходит девушка и не обращая на вас никакого внимания проходит в свободную кабинку. Дверцы всех кабинок в туалете выломаны, так что при желании вы можете заглянуть внутрь.'
		if voyeurism > 40: act 'Заглянуть в кабинку': gt 'VokzalWomanToilet','PissGirl'
		else
	end
	act 'Домыть пол и уйти': gt'vokzalGin'
end
if $ARGS[0] = 'DrunkGirl':
	cla & *clr
	minut += 10
	gs'stat'
	DrunkGirl_stage = args[1]
	gs 'zz_render','','images/wannabe/tualete/women/DrunkGirl/DrunkGirl_'+DrunkGirl_stage+'.'+iif(DrunkGirl_stage = 2,'gif','jpg'),func('VokzalWomanToilet','strings','DrunkGirl_'+DrunkGirl_stage)
	if DrunkGirl_stage < 1:
		act 'Подойти к девушке и спросить чем вы можете ей помочь': gt 'VokzalWomanToilet','DrunkGirl', DrunkGirl_stage +1
		act 'Это не моё дело': gt'vokzalGin'
	elseif DrunkGirl_stage = 1:
		act 'Продолжить наблюдать за девушкой': voyeurism += 1 & gt 'VokzalWomanToilet','DrunkGirl', DrunkGirl_stage +1
		act 'Пожать плечами и уйти': gt'vokzalGin'
	elseif DrunkGirl_stage = 2:
		act 'Начать кричать на неё': gt 'VokzalWomanToilet','DrunkGirl', DrunkGirl_stage +1
		act 'Молча развернуться и уйти': gt 'VokzalWomanToilet','DrunkGirl_exit'
	elseif DrunkGirl_stage = 3:
		if dom >= 25:
			act 'Cхватить за волосы': gt 'VokzalWomanToilet','DrunkGirl', DrunkGirl_stage +1
		else
			act 'Силой заставить убирать':
				cla & *clr
				gs 'zz_render','','images/wannabe/tualete/women/DrunkGirl/DrunkGirl_Fist.jpg','Несмотря на ярость по отношению к этой суке, которая зассала вам только что вымытый пол, вы осознаёте, что ваше воспитание и характер не позволят вам поднять руку на другого человека.'
				act 'Развернуться и уйти': gt 'VokzalWomanToilet','DrunkGirl_exit'
			end
		end
		act 'Развернуться и уйти': gt 'VokzalWomanToilet','DrunkGirl_exit'
	elseif DrunkGirl_stage > 3 and DrunkGirl_stage < 7:
		act 'Далее': gt 'VokzalWomanToilet','DrunkGirl', DrunkGirl_stage +1
	elseif DrunkGirl_stage = 7:
		dom += 25
		killvar 'DrunkGirl_stage'
		act 'Уйти': gt 'VokzalWomanToilet','DrunkGirl_exit'
	end
end
if $ARGS[0] = 'DrunkGirl_exit':
	cla & *clr
	if dom >= 25: DrunkGirl_end = 1
	gs 'zz_render','','','<dh>Это пиздец!</dh> – думаете вы: <dh>на ТАКУЮ работу я не подписывалась!!!</dh>'
	act 'Уволиться':
		cla & *clr
		DrunkGirl_end = 1
		vokzalVork = 0
		gs 'zz_render','','images/wannabe/vokzal_nach.jpg','Вы врыветесь в кабинет начальника вокзала: <dh>– Я НЕ НАМЕРЕНА РАБОТАТЬ В ТАКИХ УСЛОВИЯХ!!</dh> – кричите вы. <dh>– Я ТОЛЬКО ВСЁ УБРАЛА, А ОНА НА ПОЛ ССЫТ!!!</dh>. Начальник с удивлением смотрит на вас. Вы понимаете, что со стороны это выглядит нелепо и буквально вылетаете из кабинета.'
		act 'Далее': gt'vokzalGin'
	end
	act 'Не увольняться':
		cla & *clr
		gs 'zz_render','','','<dh>Ладно. Бывают в жизни вещи и похуже.</dh> – философски думаете вы.'
		act 'Далее': gt'vokzalGin'
	end
end
if $ARGS[0] = 'PissGirl':
gs 'zz_render','','images/wannabe/tualete/women/WomanToiletPiss_'+RAND(1,90)+'.jpg','Вы начинаете мыть пол перед занятой кабинкой и как бы невзначай заглядываете внутрь.'
act 'Домыть пол и уйти': gt'vokzalGin'
end
if $args[0] = 'strings':
	if $args[1] = 'DrunkGirl_0': $result = 'Вы заглядываете в туалетную кабинку и видите, что она просто рухнула на унитаз и привалилась к стенке - это и вызвало такой шум.'
	if $args[1] = 'DrunkGirl_1': $result = '<dh>– Может быть, вам чем-нибудь помочь?</dh> – говорите вы.<br>Девушка мотает головой и говорит заплетающимся языком: <do>- Аааэээааааааа. Всёё нооооормаально. Счас...</do> - с этими словами она начинает задирать своё платье по самые сиськи. Трусов на девушке не оказалось – видимо уже где-то потеряла.<br><dh>"Ага, нормально. Она сейчас мне весь пол тут заблюёт!"</dh> – думаете вы.'
	if $args[1] = 'DrunkGirl_2': $result = 'Девушка откидывается на спинку унитаза и начинает писать. Вы с ужасом понимаете, что она ссыт мимо!'
	if $args[1] = 'DrunkGirl_3': $result = 'Вы кричите на девушку: <dh>– Cука! Мать твою, ты что творишь! Говно собачье, а!? Ты, засранка вонючая! Посмотри - ты мне весь пол обоссала! Кто это по-твоему будет убирать, а? Иди сюда, бери швабру и убирай всё, что наделала!</dh><br>Но девушка никак особенно не реагирует на вашу гневную тираду. <do>- Не мешай. Ээээ...</do> - слышите вы. '
	if $args[1] = 'DrunkGirl_4': $result = 'Вы хватаете эту зассыху за волосы и сдёргиваете её с унитаза. <dh>– Ах ты, мразь! Решила, что я с тобой шутки шутить буду?! Со мной этот номер не пройдёт!</dh> – кричите вы: <dh>– Не захотела убирать шваброй?! Значит будешь вылизывать языком свою ссанину, тварь!</dh>'
	if $args[1] = 'DrunkGirl_5': $result = 'С этими словами вы толкаете девушку и она падает на пол рядом с унитазом, прямо в лужу своей мочи. <dh>– А ну достала свой поганый язык и лижи пол, мразь!</dh> – кричите вы. Девушка лежит без движения на полу, такое впечатление что без сознания, но удар ногой в живот приводит её в чувства и она начинает скулить, а после второго высовывает язык и начинает лизать пол.'
	if $args[1] = 'DrunkGirl_6': $result = '<dh>– И здесь ты тоже всё обоссала.</dh> – говорите вы, поднимаете девушку за волосы и тыкаете губами в бортик унитаза: <dh>– Лижи давай, мразина.</dh> Девушка послушно выполняет ваш приказ.'
	if $args[1] = 'DrunkGirl_7': $result = 'Вдруг девушка начинает блевать, видимо сочетание алкоголя и мочи не самым лучшим образом подействовало на её желудок. Мощь, с которой извергается блевотина, может посоперничать с гейзером. Вы опустили её голову в унитаз, девушка вся обмякла и продолжила блевать. Похоже, ничего больше вы от неё не добьётесь.'
end