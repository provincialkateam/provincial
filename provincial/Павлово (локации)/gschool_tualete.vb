﻿if $args[0] = '' or $args[0] = 'main':
	!*clr & cla
	$metka = $args[0]
	$loc = $curloc
	gs 'zz_render','','images/wannabe/tualete/tualete_door.jpg','Вы подходите к школьному туалету.' + iif((hour = 11 and minut >= 45) or (hour = 12 and minut <= 15),' Возле него вечно трётся местное хулиганье: ' + func('npc_editor','make_npc_group',4,1,1),'')
	if $npc['25,qwSonya'] >= 5 and $npc['25,qwSonya'] < 50: gs 'zz_render','','','Поговаривают, что на перемене школьная гопота в мужском туалете во всю пользует Соню.'
	act 'Заглянуть в мужской туалет': gt 'gschool_tualete','boys'
	act 'Зайти в женский туалет': gt 'gschool_tualete','girls'
	act 'Выйти': gt 'zz_school'
end
if $args[0] = 'boys':
	*clr & cla
	minut += 1
	$metka = $args[0]
	if ((hour = 11 and minut >= 45) or (hour = 12 and minut <= 15)) and $npc['25,qwSonya'] >= 5 and $npc['25,qwSonya'] < 50 and $npc['25,qwSonya_day'] ! day and rand(0,2) = 1:
		act 'Выйти': gt 'gschool_tualete'
		! большая перемена, Соня работает в туалете
		if $npc['25,qwSonya'] < 15: $npc['25,qwSonya'] += 1
		$npc['25,qwSonya_day'] = day
		horny += rand(10,20)
		gs 'stat'
		$_str[0] = 'Вы заглядываете в туалет и видите, что Соня сосёт член у какого-то пацана, помогая себе ручками.'
		$_str[1] = 'Вы заглядываете в туалет и видите, что там вашу одноклассницу Соню трахает какой-то пацан.'
		$_str[2] = 'Вы заглядываете в туалет и видите в нём Соню, которую со всех сторон окружили парни. Они уже вытащили свои члены и надрачивают, а у первого она уже взяла в рот.'
		$_str[3] = 'Вы заглядываете в туалет и видите как Соня берёт член одного из парней в рот и принимается сосать. Остальные продолжают надрачивать свои члены, сгрудившись поближе к Сонечке.'
		$_str[4] = 'Вы заглядываете в туалет и видите как парни сгрудились вокруг Сонечки с членами наперевес. У одного она сосёт, у двоих дрочит, а ещё пара ждёт своей очереди.'
		$_str[5] = 'Вы заглядываете в туалет и вдруг видите, как Соня трудится ротиком над членами... У вас падает челюсть: над членами двоих учителей!'
		$_str[6] = 'Вы заглядываете в туалет и видите как Соня, сидя промеж двух каких-то парней, глубоко вбирает его член в рот, рукой держа член второго.'
		$_str[7] = 'Вы заглядываете в туалет и видите, что Соня со всем старанием облизывает головку члена какого-то парня, держа его за ствол, словно микрофон.'
		i = rand(0,7)
		gs 'zz_render','','pavlovo/sonya/school/toilet/<<i>>',$_str[i]
		killvar '$_str'
		!---
		if $npc['25,qwSonya'] = 35 and func('zz_reputation','get') <= 1 and i!1: gs 'sonya','talk_in_toilet'
		!---
	else
		gs 'stat'
		gs 'zz_render','','images/wannabe/tualete/men/men_'+rand(1,2)+'.jpg','Вы заглядываете в туалет и видите парня, отливающего в писсуар. Засмущавшись вы идёте обратно в класс.'
		act 'Выйти': gt 'zz_school'
	end
end
if $args[0] = 'girls':
	*clr & cla
	$metka = $args[0]
	minut += 1
	gs 'stat'
	i = 0
	gs 'zz_render','','images/wannabe/tualete/tualete_women.jpg','Вы заходите в женский туалет. Недавно здесь сделали ремонт. В туалете стоит три кабинки и висит <a href="exec:GT ''mirror'',''start''">зеркало</a>.'
	if ((hour >= 9 and hour < 12 and minut >= 45) or (hour >= 12 and hour < 16 and minut <= 15)) and rand(0,4) = 0:
		! mini-ev
		if rand(0,10) = 1:
			*clr
			$_mini[0] = 'Вы заходите в туалет. У раковины стоит Полина Себаготуллина, ваша одноклассница. Почувствовав ваш взгляд, она оборачивается и внезапно задирает юбку, демонстрируя вам трусики. “Ну и школка”, - думаете вы.'
			$_mini[1] = 'Перед зеркалом крутится стайка девиц из параллельного класса, меряясь - у кого сиськи больше.'
			i = rand(0,arrsize('$_mini')-1)
			gs 'zz_render','','pavlovo/school/mini/' + (400+i),$_mini[i]
			killvar '$_mini'
		else
			gs 'zz_render','','','На переменах, как всегда, аншлаг - все туалетные кабинки заняты.'
		end
	else
		if rand(1,4) = 1:
			gs 'zz_render','','','Сейчас занята только одна туалетная кабинка занята.'
		else
			gs 'zz_render','','','В туалете никого нет. Все туалетные кабинки свободны.'
		end
	end
	if i > 0:
		act 'Зайти в свободную кабинку':
			*clr & cla
			gs 'zz_render','','images/wannabe/tualete/tualete.jpg','Вы зашли в туалетную кабинку. '+iif(i = 1,'В соседней кабинке кто-то есть.','')
			if voyeurism >= 40:
				act 'Подглядеть':
					*clr & cla
					gs 'zz_render','','images/wannabe/tualete/women/piss_'+rand(1,6)+'.gif','Вы опускаетесь на четвереньки и подглядываете как писает одноклассница в соседней кабинке.'
					act 'Выйти': gt $curloc
				end
			end
			act 'Выйти': gt 'gschool_tualete','girls'
		end
	end
	gs 'zz_toilet','actions'
	act 'Выйти': gt 'gschool_tualete'
end