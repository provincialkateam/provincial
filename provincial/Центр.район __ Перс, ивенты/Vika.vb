$vika_descr = {
	'<center><B><font color=maroon>Вика Кирилова</font></B></center>'
	gs 'zz_render', '', 'images/img/centr/college/Vika/vika'+args[0]+'.jpg"', func('Vika_strings', 'local_str1')
	if vikaslut = 1: 'Вика работает шлюхой в борделе центрального района.'
	if vika<20:'У вас с Викой холодные отношения.'
	if vika>=20 and vika<40:'У вас с Викой соседские отношения.'
	if vika>=40 and vika<60:'У вас с Викой нормальные отношения.'
	if vika>=60 and vika<80:'У вас с Викой хорошие отношения.'
	if vika>=80:'У вас с Викой отличные отношения.'
	gs 'zz_render', '', '', func('Vika_strings', 'local_str2')
}
vikaAge=age+1
gs'stat'
dynamic $vika_descr, 0
act '<B>Отойти</B>':gt $loc, $metka
if vika_sleep = 1 and vikaslut = 0:
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/img/centr/college/Vika/vika_sleep.jpg"', func('Vika_strings', 'local_str3')
	act '<B>Отойти</B>':gt $loc, $metka
	exit
end
if vika_sleep = 1 and vikaslut = 1:
	cla
	*clr & cla
	minut += 5
	gs 'zz_render', '', 'images/img/centr/college/Vika/vika_sleep_b.jpg"', func('Vika_strings', 'local_str4')
	act '<B>Отойти</B>':gt $loc, $metka
	exit
end
if hour < 20:
	act 'Болтать с Викой (1 час)':
		cla
		minut += 60
		vika += 1
		talkrand = RAND(0,10)
		if talkrand = 0:'Вы завели разговор с Викой, она вам рассказывает о мальчиках с которыми она познакомилась, о вечеринках, о косметике.'
		if talkrand = 1:'Вика рассказывает как она была в кафе и ее приглашал на танец парень который потом даже оплатил ее счет.'
		if talkrand = 2:'Вика рассказывает что работала в стрип клубе танцовщицей, довольно доходная работа для студентки, хотя клиенты очень приставучий.'
		if talkrand = 3:'Вика рассказывает вам что несколько девчонок из секции бега при универе вышли на европейский спортивный уровень и зарабатывают на соревнованиях бешеные деньги, хотя конечно Вика признается что ей лень так пахать как они.'
		if talkrand = 4:'Вика рассказывает что одна из ее подруг залетела от парня который не успел вытащить из нее. Но Вика умнее, она покупает в аптеке противозачаточные, 100% гарантия.'
		if talkrand = 5:'Вика рассказывает как в парке она случайно зашла на панель и ей предложили секс за деньги.'
		if talkrand = 6:'Вика рассказывает как она снималась голой в фотостудии, не пыльная работа, но репутация страдает.'
		if talkrand = 7:'Вика рассказывает страшилку о том как одна симпатичная девушка не мылась и не брила ноги, потом стала на столько страшной, что ее за километр все оббегали.'
		if talkrand = 8:'Вика рассказывает что она покупает тампоны всегда с запасом, а то если ходить без них в месячные то быстро превратишься в неряху.'
		if talkrand = 9:'Вика рассказывает как один из ее парней хотел анального секса, но у нее при себе не было вазелина.'
		if talkrand = 10:'Вика рассказывает как летом она загорала на пляже, правда пришлось для этого ей купить купальник, но он и зимой пригодился ходить в бассейн. Бассейн не плохое средство поддерживать себя в тонусе.'
		act 'Закончить':gt'Vika'
	end
	act 'Заниматься с Викой (1 час)':
		cla
		minut += 60
		intel += 1
		vika += 1
		gs 'zz_render', '', '', func('Vika_strings', 'local_str5')
		act 'Закончить':gt'Vika'
	end
	if vikasex > 0 and vika > 40:
		act 'Предложить поразвлечься':
			minut += 60
			vika += 5
			gt'lezbsex','start'
		end
	end
	if vika > 80 and vikaslut = 0:
		act 'Спросить где её носит по ночам':
			cla
			minut += 30
			vikaslut = 1
			gs 'zz_render', '', '', func('Vika_strings', 'local_str6')
			act 'Идти с Викой':gt'bordelv','start'
		end
	elseif vika > 80 and vikaslut = 1 and bordel = 0:
		act 'Спросить о работе':
			cla
			vika += 5
			bordel = 1
			! добавляем одежду борделя
			gs 'zz_clothing', 'init_clothing'
			i = 158
			:loop_add_bordel_clothing
			if i <= 175:
				gs 'zz_clothing', 'add_to_wardrobe', i
				i += 1
				jump 'loop_add_bordel_clothing'
			end
			gs 'zz_clothing', 'dispose'
			gs 'zz_render', '', '', func('Vika_strings', 'local_str7')
			act 'Закончить':gt'Vika'
		end
	end
end
if vika>=60 and birthday = day and birthmonth = month and vikaslut = 1 and b_vika_present_Day!day:
	*clr & cla
	cla
	gs'stat'
	b_vika_present_Day=day
	dynamic $vika_descr, 1
	gs 'zz_render', '', '', func('Vika_strings', 'local_str8')
	act'Куда мы идем?':gt'univer_din','b_vika_present_start'
	exit
end