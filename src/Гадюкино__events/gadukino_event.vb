﻿if $ARGS[0] = 'walk':
	*clr & cla
	minut += 15
	i = RAND(0,100)
	gs 'stat'
	if meadow = 0:
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/trail_meadow.jpg','Гуляя по деревне, вы замечаете между двумя соседскими домами небольшую тропинку, ведущую между огородами куда-то в заросли...'
		act 'Пойти по ней':
			*clr & cla
			meadow = 1
			minut += 20
			gs 'stat'
			gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/meadow.jpg','Вы решаете пойти по ней, но спустя десять минут разочарованно упираетесь в густые заросли. Вы уже собрались было уходить, но тут замечаете едва заметную, явно проложенную какой-то живностью тропку. Пробравшись по ней сквозь заросли, вы видите давно заросший не плодоносящими деревьями сад, который когда-то, наверное, принадлежал местному колхозу, пока он не распался. Пройдя еще немного, вы видите и давно заросшую грунтовую дорогу - судя по траве на ней, ею уже давно никто не пользуется. Побродив еще минут двадцать, вы убеждаетесь в том, что местные сюда не ходят, а если и ходят, то очень редко. Вы решаете вернуться назад и, к огромному вашем удивлению, выходите прямо у себя во дворе...'
			act 'Отлично':gt'Gaddvor'
		end
	elseif meadow = 1 and miraQW = 0:
		*clr & cla
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/Miroslava.jpg','Прогуливаясь, вы замечаете молодую незнакомую вам девушку, которая за ошейник пытается куда-то тащить теленка. Тот недовольно мычит, трясет вислоухой головой и вместо того, чтобы идти, стоит, как вкопанный, на месте.'
		act 'Помочь':
			*clr & cla
			miraQW = 1
			minut += 15
			gs 'stat'
			gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/Mira.jpg','Вы решаете помочь девчонке, а заодно из любопытства и узнать что-то о ней, так как в Гадюкино незнакомые люди - большая редкость, даже скорее фантастика. Вы подходите к ней и легонько шлепаете теленка по заднице, после чего тот сразу же начинает идти вперед. Незнакомка благодарит вас и между вами сам собой завязывается разговор на протяжении того времени, пока вы за компанию решаете помочь отогнать ей животное домой. Мирослава оказывается довольно общительной девушкой и с разговора вы быстро узнаете, что они совсем недавно вынуждены были переехать в деревню. Из-за огромных долгов отца им пришлось продать все имущество, в том числе и квартиру в центре города, а на те деньги, что у них остались, они смогли позволить себе купить дом только в такой вот захудалой деревне... Вы доходите до ее дома и она приглашает вас приходить к ней в гости в любое время, а то в деревне после города скукотища ужасная.'
			act 'Закончить':gt'gadukino'
		end
	elseif i < 10 and Mira_no = 0:
		if miraQW > 0 and i < 5:
			*clr & cla
			if miraQW < 25:miraQW += 1
			minut += 10
			gs 'stat'
			gs 'zz_render', 'Мирослава', 'qwest/gadukino/Mira'+iif(miragopQW = 0,1,4)+'.jpg','Вы встречаете Мирославу, которая как раз идет по воду, и она охотно останавливается с вами немного поболтать.'
			if miragopQW >= 20:
				act 'Пусть посветит мандой':
					*clr & cla
					minut += 5
					i = RAND(0,30)
					dom += 1
					gs 'stat'
					if mirasextimes < 50:
						if i < 5:
							gs 'zz_render', 'Мирослава', 'qwest/gadukino/MiraSP2.jpg','Вы говорите Мире, чтобы посветила немного своей мандой и та непринужденно, словно бы невзначай, присаживается на заборчик и, оглянувшись, с озорной улыбкой оттягивает в сторону трусики...'
						elseif i >= 5 and i < 10:
							gs 'zz_render', 'Мирослава', 'qwest/gadukino/MiraSP.jpg','Вы говорите Мире, чтобы посветила немного своей мандой и та непринужденно, словно бы невзначай, опирается руками о лавочку, предоставляя вам вид своей голой киски.'
						elseif i >= 10 and i < 25:
							gs 'zz_render', 'Мирослава', 'qwest/gadukino/MiraSP1.jpg','Вы говорите Мире, чтобы посветила немного своей мандой и та непринужденно, словно бы невзначай, присаживается на заборчик и немного разведя ноги, показывает вам свою голую писечку.'
						else
							gs 'zz_render', 'Мирослава', 'qwest/gadukino/MiraSP5.jpg','Вы говорите Мире, чтобы посветила немного своей мандой и та непринужденно, словно бы невзначай, присаживается на попавшуюся рядом лавочку и, быстро оглянувшись по сторонам, поворачивается на бок и прогнувшись, показывает вам свой голый пельмень...'
						end
					else
						if i < 5:
							gs 'zz_render', 'Мирослава', 'qwest/gadukino/MiraSP3.jpg','Вы говорите Мире, чтобы посветила немного своей мандой и та непринужденно, словно бы невзначай, присаживается на заборчик и, оглянувшись по сторонам разводит ноги... Вы с удивлением видите, как из ее растраханной киски сочится сперма.**\\ - Кто это тебя так? -// с интересом спрашиваете вы Миру, но та с кокетливой улыбкой отвечает вам, что это секрет.'
						else
							gs 'zz_render', 'Мирослава', 'qwest/gadukino/MiraSP3.jpg','Вы говорите Мире, чтобы посветила немного своей мандой и та непринужденно, словно бы невзначай, присаживается на корточки... Вы замечаете, как сильно раздолбанно ее влагалище и сморщенным бугорком выпирает рабочий анус...'
						end
					end
					act 'Уйти':gt'gadukino'
				end
			else
				act 'Уйти':gt'gadukino'
			end
		elseif miraQW > 0 and miragopQW < 4 and i >= 5:
			*clr & cla
			if miraQW < 25:miraQW += 1
			minut += 10
			gs 'stat'
			gs 'zz_render', 'Мирослава', 'qwest/gadukino/Mira2.jpg','Вы встречаете Мирославу c теленком и вы тут же, весело хохоча, вспоминаете ваше знакомство.'
			act 'Закончить':gt'gadukino'
		elseif miraQW > 0 and miragopQW >= 4 and mirasextimes >= 10 and temper >= 15 and sunWeather >= 0 and i < 5:
			*clr & cla
			horny += 20
			i = RAND(0,1)
			minut += 5
			voyeurism += 1
			gs 'stat'
			gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad'+iif(i = 0,'',1)+'.jpg','Гуляя по деревне, вы случайно замечаете Миру, отсасывающую Митьке на заднем дворе. Она чавкает губами, почти полностью вбирая член себе в рот, и иногда поглядывает по сторонам.'+iif(i = 0,'Пока наконец не замечает вас. Она тут же стремительно краснеет, но не прекращает сосать, лишь изредка косится глазами в вашу сторону. Поняв, что она заметила вас, вы, словно не увидев ничего необычного, с максимально спокойным видом уходите прочь...','Пару раз вам кажется, что она вот-вот заметит вас, но она так и не замечает, продолжая ублажать Митьку. Тот вскоре закидывает голову назад и Мира, быстро надрачивая член рукой, направляет его себе в рот, принимая в него Митькину сперму. Проглотив ее, она вылизывает Митькин член и заправив его ему в штаны, поднимается с колен, а вы, не желая быть обнаруженной, поспешно удаляетесь.')
			act 'Уйти':gt'gadukino'
		elseif miraQW > 0 and miragopQW >= 6 and mirasextimes >= 10 and temper >= 15 and sunWeather >= 0 and i >= 5:
			*clr & cla
			horny += 20
			minut += 10
			voyeurism += 1
			gs 'stat'
			gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad2.jpg','Гуляя по деревне, вы случайно замечаете Миру, трахающуюся с Митькой. Она, широко раскинув ноги, протяжно стонет под митькиными толчками, надрачивая себе клитор, а тот, грубо вколачивая в нее свой член, одной рукой бесцеремонно мнет ей грудь.'
			act 'Смотреть дальше':
				*clr & cla
				horny += 10
				minut += 5
				i = rand(0,1)
				gs 'stat'
				gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad3.jpg', 'Они так увлечены друг другом, что не замечают ничего вокруг'+iif(i = 0,', а потому вы спокойно продолжаете наблюдать, как вскоре Митька вгоняет в Миру свой член до упора и начинает кончать. Через пару минут, немного отдышавшись, они начинают приводить себя в порядок и вы решаете уйти.','. Вы присматриваетесь получше и понимаете, что Митька трахает ее в задницу, при этом без презерватива, поэтому она, наверное, так под ним извивается. Через некоторое время Митька одним рывком вгоняет в ее зад свой член до упора и рыча, начинает кончать...')
				act 'Уйти':gt'gadukino'
			end
		else
			gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/walk.jpg','Вы убиваете время, гуляя по деревне.'
			act 'Уйти':gt 'gadukino'
		end
	elseif miragopQW >= 11 and i >= 10 and i < 15 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(15,30)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad5.jpg','Гуляя по деревне, вы замечаете за сараями Васяна с Мирой. Та со стонами скачет у него на члене и, кажется, не замечает ничего вокруг, чего не скажешь о самом Васяне... Вы решаете не рисковать и оставить парочку наедине.'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 11 and i >= 15 and i < 20 and temper >= 25 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(15,30)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad6.jpg','Гуляя по деревне, вы замечаете за сараями Васяна с Мирой. Та со стонами скачет у него на члене и, кажется, не замечает ничего вокруг, чего не скажешь о самом Васяне... Вы решаете не рисковать и оставить парочку наедине.'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 11 and i >= 20 and i < 25 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(15,30)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad7.jpg','Гуляя по деревне, вы замечаете за кустами Колямбу с Мирой. Та, присев на корточки, страстно чмокает губами на его члене...'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 15 and i >= 25 and i < 30 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(20,40)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad8.jpg','Гуляя по деревне, вы замечаете за кустами Колямбу с Васяном и Мирой. Та стоит к вам голым задом на четвереньках и по очереди отсасывает пацанам члены...'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 20 and i >= 30 and i < 35 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(20,40)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraHorny.jpg','Гуляя по деревне, вы видите Миру. Та сидит на заборе и постоянно оглядываясь усиленно натирает себе киску, когда никто не видит...'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 20 and i >= 35 and i < 40 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(25,50)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad9.jpg','Гуляя по деревне, вы замечаете за заборами Миру с Колямбой. Та кривится и стонет, но покорно подставляет свою голую задницу Колямбе, который пытается запихнуть в нее бутылку...'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 30 and mirasextimes > 50 and i >= 40 and i < 45 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(50,100)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad10.jpg','Гуляя по деревне, вы видите Миру, которая стоит перед Митькой со спущенными штанами и засунув пальцы себе в анус, показывает ему выпавшую задницу...'
		act 'Уйти':gt'gadukino'
	elseif miragopQW >= 20 and i >= 45 and i < 50 and temper >= 20 and sunWeather >= 0 and Mira_no = 0:
		*clr & cla
		minut += 5
		horny += RAND(25,40)
		voyeurism += 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/MiraSexGad11.jpg','Гуляя по деревне, вы встречаете Миру, которая поправляет обувь. При этом она без трусов и с ее киски торчит белая ниточка тампона...'
		act 'Уйти':gt'gadukino'
	elseif i >= 50 and i < 55:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/GadLol.jpg','Гуляя по деревне, вы видите двух бабулек, пилящих доски...'
		act 'Уйти':gt'gadukino'
	elseif i >= 55 and i < 60:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/GadLol1.jpg','Гуляя по деревне, вы видите двух вороватых бабулек, несущих доски с полуразваленной фермы...'
		act 'Уйти':gt'gadukino'
	elseif i >= 60 and i < 70:
		*clr & cla
		minut += 5
		if mitkasextimes >= 13:dom -= 1
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/GadLol'+iif(temper < 20,2,3)+'.jpg', iif(mitkasextimes < 13,'Гуляя по деревне, вы видите местную элиту. Они, как по команде, все вместе затихают и усиленно начинают смотреть куда-то в сторону, как только вы приближаетесь к ним'+iif(gad_woman_knownude = 1,', а едва вы оказываетесь позади, как слышите негодующие голоса:**\\\- Экая лахудра! Этож надо такое удумать - голяком по деревне ходить и мандищей своей светить!**- А с виду так приличная девочка!**- Где же приличная? Сразу видно праститутка!///','...///'),iif(gad_woman_knowsex = 1,'Гуляя по деревне, вы видите местную элиту. Они приветливо улыбаются вам в лицо, а как только вы проходите мимо, как слышите старушечье:**\\\- О, глядите-ка, девоньки, проститутка пошла. Уж как ее Митька Фроськин со своей бандой не вертели, а она ходит тут как ни в чем не бывало...**- Ну да ничего, Бог на том свете всех рассудит, я вам говорю, девоньки, там свете все по местам станет...**- У-у-у, праститу-у-у-тка, прости Госпади!///','Гуляя по деревне, вы видите местную элиту. Они приветливо улыбаются вам в лицо, а как только вы проходите мимо, тут же начинают шушукаться между собой...'))
		act 'Пройти мимо':gt'gadukino'
	elseif i >= 70 and i < 75 and temper >= 20 and sunWeather >= 0:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/GadLol4.jpg','Гуляя по деревне, вы видите подрастающее поколение. Те радостно улыбают вам зубы и пялятся во все глаза...'
		act 'Уйти':gt'gadukino'
	else
		gs 'zz_render', 'Деревня Гадюкино', 'qwest/gadukino/walk.jpg','Вы убиваете время, гуляя по деревне.'
		act 'Уйти':gt 'gadukino'
	end
end
if $ARGS[0] = 'mira_apologise':
	*clr & cla
	minut += 5
	gadboyday = daystart
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/turn_back.jpg'
	gs 'zz_render','','','Идя по деревне вы услышали, что вас кто-то догоняет. Оглянувшись, вы увидели Миру.'
	act 'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		dynamic $miraclothes
		gs 'zz_render','','','Мира подбежала к вам и сходу затараторила.'
		gs 'zz_render','','',' - Светик, я слышала, что произошло, - сбиваясь начала она. - Митьку с Колямбой подслушала.'
		gs 'zz_render','','','Вы стояли молча и ждали, что она еще скажет.'
		gs 'zz_render','','',' - Света, прости меня дуру, за то как я с тобой обращалась, - продолжила она. - Я вдруг поняла, что ты у меня тут единственная подруга.'
		gs 'zz_render','','',' - И что теперь?, - спросили вы глядя на неё.'
		gs 'zz_render','','',' - Ну хочешь, я в знак примирения тебе тоже сделаю приятно?, - смущаясь ответила она.'
		gs 'zz_render','','','Пока вы обдумывали, что ответить, Мира непрестанно следила за вами, покусывая губы от нетерпения.'
		act 'Согласиться':
			*clr & cla
			minut += 5
			horny += 5
			mirasex = 2
			gs 'stat'
			dynamic $miraclothes
			gs 'zz_render','','','Вы, наконец приняв решение, повернулись к Мире.'
			gs 'zz_render','','',' - Хорошо, Мир, я согласна, - сказали вы ей с улыбкой, уловив во взгляде неподдельную радость. - Ты прощена.'
			gs 'zz_render','','',' - И? - вопросительно подняла она бровь.'
			gs 'zz_render','','','Вместо ответа вы схватили её за руку и потащили на поляну.'
			act 'Далее': gt 'mirasex','miralick_first'
		end
		act 'Отказаться':
			*clr & cla
			minut += 30
			mirasex = 3
			gs 'stat'
			dynamic $miraclothes
			gs 'zz_render','','','Вы, наконец приняв решение, повернулись к Мире.'
			gs 'zz_render','','',' - Хорошо, Мир, я согласна, - сказали вы ей с улыбкой, уловив во взгляде неподдельную радость. - Ты прощена.'
			gs 'zz_render','','',' - И? - вопросительно подняла она бровь.'
			gs 'zz_render','','',' - Нет, Мир, взамен ничего не нужно, - ответили вы. - Знаешь, я лишний раз убедилась, что девочки мне неинтересны в плане секса.'
			gs 'zz_render','','',' - Ну как знаешь, - немного разочарованным голосом сказала Мира. Ну пошли хоть по деревне погуляем.'
			gs 'zz_render','','','И в течение часа вы спокойно гуляли по деревне, весело разговаривая.'
			act 'Уйти':gt 'gadukino'
		end
	end
end
if $ARGS[0] = 'mitka_apologise':
	*clr & cla
	minut += 5
	gadboyday = daystart
	gadriver_gang = 4
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/turn_back.jpg'
	gs 'zz_render','','','Идя по деревне вы услышали, что вас кто-то догоняет. Оглянувшись, вы увидели спешащего к вам Митьку. Зная по собственному опыту, что убежать все равно не выйдет, вы остановились, поджидая его.'
	act 'Далее':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render','','images/gadukino/mitka/mitka.jpg'
		gs 'zz_render','','','Митька подошел к вам и с ходу начал разговор.'
		gs 'zz_render','','',' - Вот что, Светик. Ко мне тут наши мужики подваливали, - сказал он с ухмылкой, видя испуг на вашем лице. - Сказали не трогать тебя больше, а то еще в мусарню заявишь.'
		gs 'zz_render','','','Вы стояли молча и ждали, что он еще скажет.'
		gs 'zz_render','','',' - Короче, помнишь как в детстве, мир-дружба-жвачка, - сказал он с ухмылкой. - Лады?'
		if miragopQW >= 12:
			gs 'zz_render','','',' - А к Мирке тоже не будете приставать?, - спросили вы с облегчением.'
			gs 'zz_render','','',' - А Мирка не против, гы гы гы, - заржал Митька.'
			gs 'zz_render','','',' - И ко мне совсем-совсем приставать не будете? - вы с недоверием посмотрели на Митьку.'
			gs 'zz_render','','',' - Ну если сама не попросишь, - снова заржал он. - Ну все, с тобой думаю мы все порешали, пойду я... Мирку поищу что ли, а то стояк заёб.'
			gs 'zz_render','','','И гогоча пошел в сторону дома Колямбы. Вы еще пару мгновений смотрели ему в след, потом отправились дальше по своим делам'
		else
			gs 'zz_render','','',' - И ко мне совсем-совсем приставать не будете? - вы с недоверием посмотрели на Митьку.'
			gs 'zz_render','','',' - Ну если сама не попросишь, - заржал он. - Ну все, с тобой думаю мы все порешали, пойду я...'
			gs 'zz_render','','','И гогоча пошел в сторону дома Колямбы. Вы еще пару мгновений смотрели ему в след, потом отправились дальше по своим делам'
		end
		act 'Уйти':gt 'gadukino'
	end
end
if $ARGS[0] = 'gang_apologise':
	*clr & cla
	minut += 5
	gadboyday = daystart
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/turn_back.jpg'
	gs 'zz_render','','','Идя по деревне вы вдруг услышали, что вас кто-то зовет по имени. Оглянувшись, вы увидели, что это дядя Степа, направляющийся в вашу сторону. Вы, помня о недавних событиях, ускорили шаг, не желая их повторения.'
	gs 'zz_render','','',' - Света, постой, мне поговорить с тобой нужно, - крикнул издали он, видя, что вы готовы уже перейти на бег.'
	act 'Подождать':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/uncle_Stepan.jpg'
		gs 'zz_render','','','Вы остановились в нерешительности, гадая, что же хочет от вас дядя Степа. Пока вы раздумывали, удрать все-таки или остаться, он подошел к вам и остановился, растерянно переминаясь с ноги на ногу, явно не зная, как начать разговор. Вы вопросительно глянули на него из-под лобья, как бы подталкивая его , и он наконец решился.'
		gs 'zz_render','','',' - Света, кх-ммм, - начал он, но сразу запнулся. - Короче, извини нас за вчерашнее... Незнаю, что на нас нашло, как будто бес вселился, после пьяных рассказов Митьки и его дружков.'
		gs 'zz_render','','','Удивленно подняв брови, вы уставились на него. Такого поворота событий вы явно не ожидали.'
		gs 'zz_render','','',' - Мы тут с мужиками покумекали с утра, и, ээээ, - опять сбился дядя Степа. - Ну короче мы тут с мужиками решили поговорить с тобой. Принести извинения и попросить сделать вид, что ничего вчера не было как бы... И еще мы тут денежку собрали тебе, так сказать в виде морального ущерба.'
		gs 'zz_render','','','Вы недоверчиво посмотрели на дядю Степу, не понимая, шутит он или нет.'
		act 'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/10000.jpg'
			gs 'zz_render','','','Видя ваш недоверчивый взгляд, дядя Степа полез в карман спортивных штанов и достав оттуда сверток, начал его быстро разворачивать.'
			gs 'zz_render','','',' - Вот, - показал он деньги в руке. - Здесь десять тысяч.'
			gs 'zz_render','','',' - И что мне с ними делать? - неуверенно спросили вы.'
			gs 'zz_render','','',' - Ну я не знаю, дело твое, - ответил дядя Степа. - Может на лечение какое потратить, или купи себе что-нибудь в качестве моральной компенсации.'
			gs 'zz_render','','','Вы задумались, не зная какое принять решение, глядя то на деньги, то на дядю Степу.'
			act 'Взять деньги':
				*clr & cla
				minut += 5
				dom -= 1
				gadriver_gang = 2
				money += 10000
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/new/take_money.jpg'
				gs 'zz_render','','',' - Ладно, хорошо, - наконец приняли решение вы. - Давайте будем считать, что ничего не было.'
				gs 'zz_render','','','И протянув руку, забрали деньги у дяди Степы.'
				gs 'zz_render','','',' - Ну вот и ладненько, - сказал облегченно дядя Степа. - Пойду я тогда.'
				gs 'zz_render','','','Вы уже собрались развернуться и уйти, когда дядя Степа добавил:'
				gs 'zz_render','','',' - И это ... Света, никто из мужиков к тебе приставать больше не будет просто так, так что не бойся.'
				gs 'zz_render','','',' - Хорошо, я поняла, - ответили вы и развернувшись отправились по своим делам.'
				act 'Уйти':gt 'gadukino'
			end
			act 'Отказаться':
				*clr & cla
				minut += 5
				dom += 1
				gadriver_gang = 3
				gs 'stat'
				gs 'zz_render','','images/qwest/alter/Ev/otel4.jpg'
				gs 'zz_render','','',' - Не нужны мне ваши деньги, я не проститутка какая-нибудь, - сказали вы твердым голосом, глядя в глаза дяде Степе. - Будем считать, что ничего не было, а деньги можете себе оставить.'
				gs 'zz_render','','','Вы заметили как блеснули глаза дяди Степы при вашей последней фразе. Деньги отдавать мужикам он явно не собирался. "Ну и бог с ним, это его дело" - подумали вы про себя .'
				gs 'zz_render','','',' - Ну вот и ладненько, - сказал облегченно дядя Степа. - Пойду я тогда.'
				gs 'zz_render','','','Вы уже собрались развернуться и уйти, когда дядя Степа добавил:'
				gs 'zz_render','','',' - И это ... Света. Никто в деревне ничего не узнает, и из мужиков никто к тебе приставать больше не будет. Митьку с бандой тоже предупредим, так что на пушечный выстрел не подойдут. А ежели что, ты мне скажи, я все улажу.'
				gs 'zz_render','','',' - Хорошо, я поняла, - ответили вы и развернувшись отправились по своим делам.'
				act 'Уйти':gt 'gadukino'
			end
		end
	end
	act 'Убежать':
		*clr & cla
		minut += 15
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/girl_escapes.jpg'
		gs 'zz_render','','','Вы кинулись на утек, не разбирая дороги, и остановились только на поляне за деревней.'
		gs 'zz_render','','',' "Пронесло, слава богу" - подумали вы и осмотрелись.'
		act 'Далее':gt'Meadow'
	end
end
if $ARGS[0] = 'gadriver_gang':
	*clr & cla
	minut += 5
	gadriver_gang = 1
	gadboyday = daystart
	mitkasextimes = 21
	dom -= 10
	if health <= 100:health = 100
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang.jpg'
	gs 'zz_render','','','Вы шли по тропинке, полностью погрузившись в свои мысли, поэтому не сразу заметили толпу пьяных деревенских мужиков. Тут было практически все взрослое мужское население деревни, возможно не только этой. Подхватив вас под руки, они отвели вас в сторону, чтобы не было видно с деревни и раздев до гола, обступили со всех сторон, вывалив свои члены перед вашим лицом. Сопротивляться, учитывая вашу репутацию в деревне, вы посчитали делом смешным, а учитываю количество мужиков , к томуже и бесполезным, поэтому покорно опустились на колени.'
	act 'Сосать':
		*clr & cla
		minut += 5
		gs 'zz_clothing2','redress',0
		$boy = 'Пьяный мужик'
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_oral1.jpg'
		gs 'zz_render','','','Вы взяли первый попавшийся вам под руку член и подрочив немного поднесли к своим губам...'
		dick = rand(12,20)
		gs 'zz_dynamic_sex', 'bj'
		act 'Сосать дальше':
			*clr & cla
			minut += 5
			$boy = 'Какой-то деревенский парень'
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_oral2.jpg'
			gs 'zz_render','','','Потом перевал вашим лицом оказался следующий член...'
			dick = rand(12,20)
			gs 'zz_dynamic_sex', 'bj'
			act 'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_oral3.jpg'
				gs 'zz_render','','','Потом еще один, и еще. Члены менялись у вас во рту один за другим по одному, иногда даже по два сразу. И вы каждый из них сосали, обхватывая своими <<$liptalk>> губами, вбирая с каждым движением до самого горла. '
				act 'Далее':
					*clr & cla
					minut += 5
					gs 'zz_funcs', 'cum', 'lip'
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_funcs', 'cum', 'belly'
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cum1.jpg'
					gs 'zz_render','','','Наконец появились и первые финишеры. Они подходили и не церемонясь кончали вам в рот, на лицо, на грудь. А действие тем временем продолжалось дальше...'
					act 'Далее':
						*clr & cla
						minut += 5
						$boy = 'какой-то деревенский мужик'
						silavag = rand(0,2)
						dick = rand(12,20)
						bj += 1
						guy += 1
						pose = 1
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog1.jpg'
						gs 'zz_render','','','Вы и сами не поняли, в какой момент вдруг оказались стоящей раком. Ваш рот все так же был занят членом, вы просто почувствовали, что в вашу <<$vaginatipe2>> вагину уперся чей-то член.'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						act 'Далее':
							*clr & cla
							minut += 5
							$boy = 'мужик'
							silavag = rand(0,2)
							dick = rand(12,20)
							temp = rand(1,2)
							protect = rand(0,1)
							bj += 1
							guy += 1
							pose = 1
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog2.jpg'
							gs 'zz_render','','','Через некоторое время его сменил другой.'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
							act 'Далее':
								*clr & cla
								minut += 5
								$boy = 'Пьяный Мужик'
								silavag = rand(0,2)
								dick = rand(12,20)
								temp = rand(1,2)
								if lubonus = 0:lubonus += 1
								bj += 1
								guy += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog3.jpg'
								gs 'zz_render','','','Следующий не торопился занять место в вашей вагине, вместо этого вы почувствовали как чьи-то пальцы изучают ваш <<$anustipe>> анус.'
								if anus <= 5:' - А жопа то не разработана совсем, - услышали вы мужской голос. - Ничего, сейчас исправим.'
								if anus <= 10:'Вы лишь могли мычать протестуя, так как ваш ротик был занят очередным членом.'
								gs 'zz_dynamic_sex', 'anal', 'dick'
								if temp = 2:gs 'zz_dynamic_sex', 'anal_cum'
								act 'Далее':
									*clr & cla
									minut += 5
									$boy = 'Митька'
									silavag = 0
									dick = 16
									temp = rand(1,2)
									if lubonus = 0:lubonus += 1
									bj += 1
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog2.jpg'
									gs 'zz_render','','','Видимо эта идея пришлась по душе еще кому-то, так как следующий член парень начал пристраиваться к той же дырочке. Оглянувшись, вы узнали Митьку....'
									gs 'zz_dynamic_sex', 'anal', 'dick'
									if temp = 2:gs 'zz_dynamic_sex', 'anal_cum'
									act 'Далее':
										*clr & cla
										minut += 5
										$boy = 'дядя Степа'
										silavag = 2
										dick = 22
										temp = rand(1,2)
										protect = rand(0,1)
										bj += 1
										guy += 1
										pose = 0
										gs 'stat'
										gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_mis1.jpg'
										gs 'zz_render','','','Вас положили на спину и вы увидели перед собой дядю Степу, рыбака, который устраивался между ваших раздвинутых ног.'
										gs 'zz_render','','','"Ужас, и он тут", - только и успели подумать вы.'
										gs 'zz_dynamic_sex', 'vaginal', 'dick'
										if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
										act 'Далее':
											*clr & cla
											minut += 5
											$boy = 'деревенский мужик'
											silavag = rand(0,2)
											dick = rand(12,20)
											temp = rand(1,2)
											protect = rand(0,1)
											bj += 1
											guy += 1
											pose = 0
											gs 'stat'
											gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_mis2.jpg'
											gs 'zz_render','','','Потом между ног пристроился очередной ваш "поклонник".'
											gs 'zz_dynamic_sex', 'vaginal', 'dick'
											if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
											act 'Далее':
												*clr & cla
												minut += 5
												$boy = 'Васян'
												silavag = 0
												dick = 14
												temp = rand(1,2)
												protect = rand(0,1)
												bj += 1
												pose = 0
												gs 'stat'
												gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_mis3.jpg'
												gs 'zz_render','','','Потом опять знакомое лицо - Васян.'
												gs 'zz_render','','','"Значит и Колямба где-то рядом", - подумали вы безразлично.'
												gs 'zz_dynamic_sex', 'vaginal', 'dick'
												if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
												act 'Далее':
													*clr & cla
													minut += 5
													if health <= 100:health = 100
													$boy = 'Незнакомый пьяный парень'
													gs 'stat'
													gs'time'
													gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_oral4.jpg'
													gs 'zz_render','','','Тут для ваших дырочек наступила передышка, в виде очередных финишеров. Вас поставили на колени и вложив в ваши ладошки члены, приказали сосать.'
													dick = rand(12,20)
													gs 'zz_dynamic_sex', 'bj'
													act 'Далее':
														*clr & cla
														minut += 5
														dick = rand(12,20)
														gs 'zz_funcs', 'cum', 'face'
														gs 'stat'
														gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cum2.jpg'
														gs 'zz_render','','','Развязку долго ждать не пришлось.'
														gs 'zz_dynamic_sex', 'bj'
														gs 'zz_dynamic_sex', 'swallow'
														gs 'zz_render','','','Они кончили и отошли в сторону.'
														act 'Далее':
															*clr & cla
															minut += 5
															$boy = 'мужик'
															silavag = rand(0,2)
															dick = rand(12,20)
															protect = rand(0,1)
															temp = rand(1,2)
															bj += 1
															guy += 1
															pose = 1
															gs 'stat'
															gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog5.jpg'
															gs 'zz_render','','','Вы опять оказались в положении раком, и очередной член начал прокладывать дорогу в вашу многострадальную, <<$vaginatipe2>>, киску.'
															gs 'zz_dynamic_sex', 'vaginal', 'dick'
															if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
															act 'Далее':
																*clr & cla
																minut += 5
																$boy = 'незнакомый парень'
																silavag = rand(0,2)
																dick = rand(12,20)
																protect = rand(0,1)
																bj += 1
																guy += 1
																pose = 1
																gs 'stat'
																gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog6.jpg'
																gs 'zz_render','','','Потом пристроился следующий.'
																gs 'zz_dynamic_sex', 'vaginal', 'dick'
																if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
																act 'Далее':
																	*clr & cla
																	minut += 5
																	$boy = 'Парень'
																	silavag = rand(0,2)
																	dick = rand(12,20)
																	protect = rand(0,1)
																	temp = rand(1,2)
																	bj += 1
																	guy += 1
																	gs 'stat'
																	gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog7.jpg'
																	gs 'zz_render','','','Затем опять наступила очередь попки.'
																	gs 'zz_dynamic_sex', 'anal', 'dick'
																	if temp = 2:gs 'zz_dynamic_sex', 'anal_cum'
																	act 'Далее':
																		*clr & cla
																		minut += 5
																		$boy = 'Пьяный мужик'
																		silavag = rand(0,2)
																		dick = rand(12,20)
																		if lubonus = 0:lubonus += 1
																		temp = rand(1,2)
																		bj += 1
																		guy += 1
																		gs 'stat'
																		gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog8.jpg'
																		gs 'zz_dynamic_sex', 'anal', 'dick'
																		if temp = 2:gs 'zz_dynamic_sex', 'anal_cum'
																		act 'Далее':
																			*clr & cla
																			minut += 5
																			if hantersKnow = 0:$boy = 'Незнакомый мужик'
																			if hantersKnow = 1:$boy = 'Андрей'
																			if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
																			silavag = 0
																			dick = 20
																			if lubonus = 0:lubonus += 1
																			temp = rand(1,2)
																			bj += 1
																			gs 'stat'
																			gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog9.jpg'
																			if hantersKnow = 0:'Скосив немного взгляд и продолжая сосать чей-то член, вы увидели очередного деревенского мужика, пристраивающегося к вашей попке.'
																			if hantersKnow = 1:'Когда очередной мужик пристраивался к вашей попке, вы скосив на него глаза, к своему ужасу узнали Андрея. То, что теперь и Игорь с Сергеем обо всем узнают, сомневаться не приходилось.'
																			gs 'zz_dynamic_sex', 'anal', 'dick'
																			if temp = 2:gs 'zz_dynamic_sex', 'anal_cum'
																			act 'Далее':
																				*clr & cla
																				minut += 5
																				$boy = 'мужик'
																				silavag = rand(0,2)
																				dick = rand(12,20)
																				protect = rand(0,1)
																				temp = rand(1,2)
																				bj += 1
																				guy += 1
																				pose = 1
																				gs 'stat'
																				gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_dog10.jpg'
																				gs 'zz_render','','','Вы продолжали стоять раком, когда следующий мужик решил воспользоваться вашей киской. Краем глаза, вы замечаете в толпе Колямбу, ждущего с нетерпением своей очереди.'
																				gs 'zz_dynamic_sex', 'vaginal', 'dick'
																				if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
																				act 'Далее':
																					*clr & cla
																					minut += 5
																					if health <= 100:health = 100
																					$boy = 'Мужик'
																					gs 'stat'
																					gs'time'
																					gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_oral5.jpg'
																					gs 'zz_render','','','Вы вдруг с удивлением обнаружили, что к вашей киске и попке больше никто не пристраивается.'
																					gs 'zz_render','','','"Неужели все?"- с надеждой подумали вы.'
																					gs 'zz_render','','','Но передышки не получилось. Вас поставили на колени и тут же у вашего лица очутился очередной член.'
																					dick = rand(12,20)
																					gs 'zz_dynamic_sex', 'bj'
																					act 'Далее':
																						*clr & cla
																						minut += 5
																						$boy = 'незнакомец'
																						silavag = rand(0,2)
																						dick = rand(10,20)
																						protect = rand(0,1)
																						temp = rand(1,2)
																						bj += 1
																						guy += 1
																						pose = 2
																						gs 'stat'
																						gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cow1.jpg'
																						gs 'zz_render','','',' - А теперь, пусть шлюшка сама поработает своей пиздёнкой, - услышали вы. Повернув голову вы увидели, разлегшегося на земле, голого мужика. И вам ничего другого не оставалось, как залезть на него сверху.'
																						gs 'zz_dynamic_sex', 'vaginal', 'dick'
																						if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
																						act 'Далее':
																							*clr & cla
																							minut += 5
																							$boy = 'выпивший парень'
																							silavag = rand(0,2)
																							dick = rand(12,20)
																							protect = rand(0,1)
																							temp = rand(1,2)
																							bj += 1
																							guy += 1
																							pose = 2
																							gs 'stat'
																							gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cow2.jpg'
																							gs 'zz_render','','','На следующего парня, тоже лежащего на земле, вы залезли уже сами, без подсказки. В лицо вам сразу уткнулся очередной член, который вы тут же принялись сосать.'
																							gs 'zz_dynamic_sex', 'bj'
																							dick = rand(10,20)
																							gs 'zz_dynamic_sex', 'vaginal', 'dick'
																							if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
																							act 'Далее':
																								*clr & cla
																								minut += 5
																								$boy = 'мужик'
																								silavag = rand(0,2)
																								dick = rand(12,20)
																								protect = rand(0,1)
																								temp = rand(1,2)
																								bj += 1
																								guy += 1
																								pose = 2
																								gs 'stat'
																								gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cow3.jpg'
																								gs 'zz_dynamic_sex', 'vaginal', 'dick'
																								if temp = 1:gs 'zz_dynamic_sex', 'sex_cum'
																								gs 'zz_render','','','Скача на члене очередного парня вы вдруг услышали голос Колямбы.'
																								gs 'zz_render','','',' - Да, бля, заебался я ждать уже, - и тут же в ваш <<$anustipe>> анус уперся его член.'
																								act 'Далее':
																									*clr & cla
																									minut += 5
																									$boy = 'незнакомый мужик'
																									$boy2 = 'Колямба'
																									silavag = rand(0,2)
																									dick = rand(12,20)
																									dick2 = 15
																									protect = rand(0,1)
																									temp = rand(1,2)
																									if lubonus = 0:lubonus += 1
																									bj += 2
																									guy += 1
																									gs 'stat'
																									gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_DP1.jpg'
																									gs 'zz_dynamic_sex', 'double_penetration'
																									gs 'zz_render','','',' - Ух ты, бутерброд прямо, - услышали вы чей-то пьяный смех как в тумане.'
																									act 'Далее':
																										*clr & cla
																										minut += 5
																										$boy = 'первый мужик'
																										$boy2 = 'второй мужик'
																										silavag = rand(0,2)
																										dick = rand(12,20)
																										dick2 = rand(12,20)
																										protect = rand(0,1)
																										temp = rand(1,2)
																										if lubonus = 0:lubonus += 1
																										bj += 2
																										guy += 2
																										gs 'stat'
																										gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_DP2.jpg'
																										gs 'zz_render','','','Эта шутка так понравилась следующим мужикам, что они решили повторить.'
																										gs 'zz_dynamic_sex', 'double_penetration'
																										act 'Далее':
																											*clr & cla
																											minut += 5
																											if health <= 100:health = 100
																											gs 'stat'
																											gs'time'
																											gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_oral6.jpg'
																											gs 'zz_render','','','Наконец, вас совсем обессиленную, поставили на колени перед оставшимися мужиками и вы желая завершения всего этого кошмара принялись с усердием отсасывать, стараясь чтобы они кончили побыстрее.'
																											act 'Далее':
																												*clr & cla
																												minut += 5
																												gs 'zz_funcs', 'cum', 'lip'
																												gs 'zz_funcs', 'cum', 'face'
																												swallow += 3
																												gs 'stat'
																												gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cum3.jpg'
																												gs 'zz_render','','','Ваши старания вскоре увенчались успехом, и парни как по команде стали кончать, кто в рот, кто на лицо. Впрочем на грудь и живот тоже немало попало.'
																												act 'Далее':
																													*clr & cla
																													minut += 5
																													gs 'zz_funcs', 'cum', 'lip'
																													gs 'zz_funcs', 'cum', 'face'
																													swallow += 3
																													gang += 1
																													bj += 20
																													gs 'stat'
																													gs 'zz_render','','images/qwest/gadukino/new/gadriver_gang_cum4.jpg'
																													gs 'zz_render','','','Когда последние мужики удачно отстрелялись, толпа начала рассасываться, оставив вас одну, обтекать на драном покрывале. Они расходились весело переговариваясь и делясь впечатлениями от своей пьяной выходки.'
																													act 'Далее':minut += 5 & gt 'gadbeach'
																												end
																											end
																										end
																									end
																								end
																							end
																						end
																					end
																				end
																			end
																		end
																	end
																end
															end
														end
													end
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'gadukino_mitka':
	*clr & cla
	minut += 5
	mitkaday = daystart
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/gadukino/mitka/mitka.jpg'
	gs 'zz_render','','','Идя по деревне вы встретили Митьку. Увидев вас он почесал яйца и сказал с ухмылкой:'
	gs 'zz_render','','',' - Ну чо, Светик, пойдем поебемся, а то стояк заеб.'
	act 'Далее':mitkagadsex = 1 & mitboyrand = 1 & gt 'mitkasex'
end
if $ARGS[0] = 'gadukino_kolyamba':
	*clr & cla
	minut += 5
	kolyambaday = daystart
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/gadukino/mitka/kolyamba.jpg'
	gs 'zz_render','','','Идя по деревне вы встретили Колямбу. Увидев вас он почесал яйца и поволок ближайшие в кусты.'
	act 'Далее':mitkagadsex = 1 & mitboyrand = 2 & gt 'mitkasex'
end
if $ARGS[0] = 'gadukino_vasyan':
	*clr & cla
	minut += 5
	vasyanday = daystart
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/gadukino/mitka/vasyan.jpg'
	gs 'zz_render','','','Идя по деревне вы встретили Васяна. Увидев вас он усмехнулся и поволок ближайшие в кусты.'
	act 'Далее':mitkagadsex = 1 & mitboyrand = 3 & gt 'mitkasex'
end
if $ARGS[0] = 'gadukino_2boys':
	*clr & cla
	minut += 5
	gadboyday = daystart
	mitboyrand = rand(1,3)
	gs 'stat'
	gs'time'
	if month >= 6 and month <= 8:
		gs 'zz_render','','images/qwest/gadukino/new/2boys.1.jpg'
	else
		gs 'zz_render','','images/qwest/gadukino/new/2boys.2.jpg'
	end
	if mitboyrand = 1:'Идя по деревне вы встретили Митьку и Колямбу. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	if mitboyrand = 2:'Идя по деревне вы встретили Митьку и Васяна. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	if mitboyrand = 3:'Идя по деревне вы встретили Колямбу и Васяна. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	act 'Далее':mitkagadsex = 2 & gt 'mitkasex'
end
if $ARGS[0] = 'mira_mitka':
	*clr & cla
	minut += 5
	mitkaday = daystart
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/gadukino/mitka/mitka.jpg'
	gs 'zz_render','','','Гуляя с Мирой по деревне вы встретили Митьку. Увидев вас он почесал яйца и сказал с ухмылкой:'
	gs 'zz_render','','',' - Ну чо, девчонки, пойдем поебемся, а то стояк заеб.'
	act 'Далее':mitkaforestsex = 1 & mitboyrand = 1 & gt 'mitkasex'
end
if $ARGS[0] = 'mira_kolyamba':
	*clr & cla
	minut += 5
	kolyambaday = daystart
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/gadukino/mitka/kolyamba.jpg'
	gs 'zz_render','','','Гуляя с Мирой по деревне вы встретили Колямбу. Увидев вас он почесал яйца и поволок ближайшие в кусты.'
	act 'Далее':mitkaforestsex = 1 & mitboyrand = 2 & gt 'mitkasex'
end
if $ARGS[0] = 'mira_vasyan':
	*clr & cla
	minut += 5
	vasyanday = daystart
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/gadukino/mitka/vasyan.jpg'
	gs 'zz_render','','','Гуляя с Мирой по деревне вы встретили Васяна. Увидев вас он усмехнулся и поволок ближайшие в кусты.'
	act 'Далее':mitkaforestsex = 1 & mitboyrand = 3 & gt 'mitkasex'
end
if $ARGS[0] = 'mira_2boys':
	*clr & cla
	minut += 5
	gadboyday = daystart
	mitboyrand = rand(1,3)
	gs 'stat'
	gs'time'
	if month >= 6 and month <= 8:
		gs 'zz_render','','images/gadukino/new/2boys.1.jpg'
	else
		gs 'zz_render','','images/qwest/gadukino/new/2boys.2.jpg'
	end
	if mitboyrand = 1:'Гуляя с Мирой по деревне вы встретили Митьку и Колямбу. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	if mitboyrand = 2:'Гуляя с Мирой по деревне вы встретили Митьку и Васяна. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	if mitboyrand = 3:'Гуляя с Мирой по деревне вы встретили Колямбу и Васяна. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	act 'Далее':mitkaforestsex = 2 & gt 'mitkasex'
end
if $ARGS[0] = 'mira_3boys':
	*clr & cla
	minut += 5
	gadboyday = daystart
	gs 'stat'
	gs'time'
	if month >= 6 and month <= 8:
		gs 'zz_render','','images/qwest/gadukino/new/3boys.1.jpg'
	else
		gs 'zz_render','','images/gadukino/mitka/3boys.2.jpg'
	end
	gs 'zz_render','','','Гуляя с Мирой по деревне вы встретили Митьку, Колямбу и Васяна. Увидев вас они усмехнулись и поволокли ближайшие в кусты.'
	act 'Далее':mitkaforestsex = 3 & gt 'mitkasex'
end
if $args[0] = 'go_home':
	if week = 7:
		if hour = 20 or hour = 21:
			family_trip_month = month
			if month >= 6 or month <= 8:
				*clr & cla
				gs 'zz_render','','','Мама спрашивает у вас "Ну что, Света, поедешь с нами или останешься пока в деревне?"'
				act 'Остаться': gt 'gadhouse'
				act 'Ехать домой': gs 'gadukino_event','go_home_ender'
			else
				gs 'gadukino_event','go_home_ender'
			end
		elseif hour > 21:
			family_trip_month = month
		end
	end
end
if $args[0] = 'go_home_ender':
	*clr & cla
	minut += rand(15,25)
	mira_guest = 0
	gs 'stat'
	gs 'zz_render','','','Вы сели в Волгу вместе с семьей и вскоре добрались в Павлово.'
	gs 'gadukino_event','clearing_basket'
	act 'В свою комнату': gt 'bedrPar'
end
if $args[0] = 'to_gadukino':
	*clr & cla
	minut += rand(15,25)
	gs 'stat'
	gs 'zz_render','','','Вы сели в Волгу и за быстро добрались до деревушки Гадюкино, в которой живут ваши бабушка и дедушка.'
	act 'Идти в избу': gt 'gadhouse'
end
!Пункт приема грибов и ягод
if $args[0] = 'collection_point':
	cla
	*clr
	minut += 5
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/new/collection_point.jpg'
	gs 'zz_render','','','Передвижной заготовительный пункт грибов и ягод.'
	if boletus > 0:
		act'Сдать грибы':
			cla
			*clr
			minut += 30
			money += boletus*150
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/collection_point.jpg'
			gs 'zz_render','','','Вы сдали грибы на <b><<boletus*150>></b> рублей.'
			act'Далее':boletus = 0 & gt 'gadukino_event','collection_point'
		end
	end
	if bilberry > 0:
		act'Сдать ягоды':
			cla
			*clr
			minut += 30
			money += bilberry*75
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/collection_point.jpg'
			gs 'zz_render','','','Вы сдали ягоды на <b><<bilberry*75>></b> рублей.'
			act'Далее':bilberry = 0 & gt 'gadukino_event','collection_point'
		end
	end
	act'Уйти':minut += 5 & gt'gadukino'
end
!Возвращение в деревню огородами
if $args[0] = 'gadukino_back':
	*clr & cla
	minut += 30
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/qwest/gadukino/new/gadukino_back'+iif(hour >= 6 and hour < 22,'','_night')+'.jpg'
	gs 'zz_render','','','Вы решили, осторожно, избегая посторонних глаз, пробраться к дому огородами..'
	act 'Далее': gt 'Gadgarden', 'garden'
end
!ГГ голая в деревне
if $args[0] = 'gadukino_nude':
	*clr & cla
	minut += 5
	temp = rand(1,5)
	if hour >= 6 and hour <= 21 and (sunWeather >= 0 and temp > 1 or sunWeather < 0 and temp > 3):gadukino_go_nude = 1
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/qwest/gadukino/new/gadukino_nude'+iif(hour < 6 or hour > 21,'_night',iif(sunWeather >= 0,'','_rain'))+'.jpg'
	gs 'zz_render','','','Несмотря, на то что на вас нет одежды, вы решили пройти домой через деревню.'
	if hour < 6 or hour > 21:'На дворе ночь и поэтому вам повезло проскочить незамеченной.'
	if hour >= 6 and hour <= 21 and sunWeather < 0 and temp < 4:'На улице дождь, все сидят по домам, поэтому вам повезло проскочить незамеченной.'
	if hour >= 6 and hour <= 21 and sunWeather >= 0 and temp = 1:'Вам повезло, вы никого не встретили по дороге, и добрались до дома незамеченной.'
	if gadukino_go_nude = 0:act 'Далее':gt 'Gaddvor'
	if gadukino_go_nude = 1:
		act 'Далее':
			*clr & cla
			gopsawnaked += 1
			if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
			gs 'stat'
			if month >= 4 and month <= 10 and sunWeather >= 0 and (hour > 14 and hour < 18 and week = 6 or hour > 13 and hour < 18 and week = 7):
				gs 'zz_render','','images/qwest/gadukino/new/grandma_gadukino.jpg'
				gs 'zz_render','','','Но вам не повезло. Не успев войти в деревню, вы тут же наткнулись на бабушку, сидящую на лавке с подругами.'
				gs 'zz_render','','','- Света ты что сдесь делаешь в таком виде? - округлила она глаза. - А ну марш домой одеваться!Бегом, пока дубца не получила!!!'
				gs 'zz_render','','','Вы со всех ног бросились в избу одеваться, слыша за спиной негодующие возгласы бабушкиных подруг.'
				act 'Далее':
					gadukino_go_nude = 0
					grandmaknownude = 1
					gad_woman_knownude = 1
					grandmaQW -= 20
					grandpaQW -= 20
					gs 'zz_clothing2','redress',cloth[3]
					clothesswamphouse = 0
					clothesbackwater = 0
					clothesforest = 0
					swamp_clothes = 0
					minut += 10
					gs 'stat'
					gt 'Gadhouse'
				end
			else
				gadukino_nude = 8 - week
				gad_woman_knownude = 1
				gs 'zz_render','','images/qwest/gadukino/new/gadukino_old_woman.jpg'
				gs 'zz_render','','','Но вам не повезло. Не успев войти в деревню, вы тут же наткнулись на бабушкиных подруг, сидящих на лавочке. Они выпучив глаза уставились на вас и тут же начали шептаться.'
				gs 'zz_render','','','"Теперь бабушка точно обо всем узнает" - подумалось вам.'
				act 'Далее':gt 'Gaddvor'
			end
		end
	end
end
!Бабка если ГГ видели голую в деревне
if $args[0] = 'gadukino_nude_end':
	*clr & cla
	minut += 30
	gadukino_nude = 0
	grandmaQW -= 20
	grandpaQW -= 20
	grandma_notalk = 1
	grandpa_notalk = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/grandma.jpg'
	gs 'zz_render','','','Не успели вы войти в избу, как на вас накинулась бабушка.'
	if grandmaknownude = 0:
		gs 'zz_render','','',' - Света, как ты могла голая по деревне разгуливать? Думала я не узнаю? Как тебе вообще такое в голову могло прийти, бесстыдница? Ты хоть представляешь какой позор мне пришлось пережить!!!'
		gs 'zz_render','','','Вы пытались, что-либо сказать в свое оправдание, но это было бесполезно. Через полчаса часа устав на вас кричать, она более или менее успокоилась.'
		gs 'zz_render','','',' - Света, неужели тебе самой не важна твоя репутация? - спросила она переводя дух. - Иди и хорошенько подумай над этим.'
	else
		gs 'zz_render','','',' - Вышла я с подругами перемолвится словечком и что я узнаю? Наша Света опять голая по деревне шастает, светит своими прелестями на всю округу. Ты хоть представляешь какой позор мне пришлось пережить, бесстыдница ты этакая!!!'
		gs 'zz_render','','','Вы уже и не пытались, что-либо говорить в свое оправдание, просто молча стояли, потупив взгляд.. Через полчаса часа устав на вас кричать, она более или менее успокоилась.'
		gs 'zz_render','','',' - Смотри Света, доиграешься, - сказала она переводя дух. - Отправлю тебя назад к матери. Да и Володе позвоню, чтобы он ремня тебе как следует всыпал, выбил из тебя эту дурь.'
	end
	act 'Далее':grandmaknownude += 1 & gt 'Gadhouse'
end
!Голая ГГ и рыбаки
if $args[0] = 'gadriver_nude':
	*clr & cla
	minut += 20
	if fishers = 1:
		fishers_nude = 8 - week
		gopsawnaked += 1
		if gopsawnaked >= 10:gopsawnaked = 0 & mitkasextimes += 1
	end
	gs 'stat'
	gs'time'
	gs 'zz_render','','images/qwest/gadukino/river/gadriver_nude'+iif(hour < 6 or hour > 21,'_night',iif(fishers = 0,'','_fishers'))+'.jpg'
	gs 'zz_render','','','Вы вышли к речке Змеявке, что находится около Гадюкино и двинулись в сторону деревни .'
	if hour < 6 or hour > 21:'На дворе ночь и поэтому тут пустынно, и никого нет. Это хорошо, учитывая, что вы совершенно голая.'
	if fishers = 0:'Слава богу тут никого нет, поэтому вам повезло проскочить незамеченной.'
	if fishers = 1:'Как назло на берегу вы заметили местных рыбаков. Судя по их округлившимся глазам, они вас тоже заметили."Ну всё, - подумалось вам. - Теперь дед точно обо всем узнает."'
	act 'Идти в деревню':gt 'gadukino'
	act 'Пробраться в деревню огородами':gt'gadukino_event','gadukino_back'
end
!Дед если рыбаки видели ГГ голую
if $args[0] = 'gadriver_nude_end':
	*clr & cla
	minut += 10
	fishers_nude = 0
	grandpaQW -= 10
	grandpa_notalk = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/granpma.jpg'
	gs 'zz_render','','','Не успели вы появится во дворе, как вам на встречу шагнул дед.'
	if grandpaknownude = 0:
		gs 'zz_render','','',' - Света, поди сюда, разговор есть, - сказал он задумчиво. - Мне тут с утра мужики говорили, что видели, как ты голая расхаживала вдоль речки. Правда это, али брешут по пьяни?'
		gs 'zz_render','','','Вы начали сбивчиво дедушке объяснять, как это произошло, но он вас перебил на полуслове.'
		gs 'zz_render','','',' - Значит правда, - перебил он вас на полуслове. - Света, не думаешь про нашу с бабкой репутацию, хоть про свою подумай. Мы то уже старые, а тебе с ней еще всю жизнь жить. Ладно, иди. Бабке я ничего не скажу, так уж и быть, не хочу чтобы расстраивалась.'
	else
		gs 'zz_render','','',' - Света, поди сюда, разговор есть, - сказал он хмурясь. - Мужики опять говорят, что тебя голую видели. Совсем совесть потеряла?'
		gs 'zz_render','','','Вы попытались оправдаться, но он опять вас перебил на полуслове.'
		gs 'zz_render','','',' - Доиграешься, Света, ты у меня , - перебил он вас на полуслове. - Вот сниму ремень и отхожу по твоей заднице вдоль и поперек, как когда-то твоей ма... Кхе-кхе-кхе... Короче мало не покажется. Дуй отсюда, пока я добрый.'
	end
	act 'Далее':grandpaknownude += 1 & gt 'Gaddvor'
end
!обработчик на подглядывающих местных
if $args[0] = 'onlooker':
	onlooker = 0
	temp = rand(1,10)
	if week < 6:
		if hour < 17 and temp = 1:onlooker = 1
		if hour >= 17 and temp < 3:onlooker = 1
	else
		if temp < 4:onlooker = 1
	end
end
!подглядывающие местные
if $args[0] = 'gadukino_onlooker':
	*clr & cla
	minut += 1
	gadukino_onlooker = rand(1,2)
	gs 'stat'
	if gadukino_onlooker = 1:
		onlooker_woman = 1
		gad_woman_knowsex = 1
		gs 'zz_render','','images/qwest/gadukino/new/gadukino_old_woman'+rand(1,5)+'.jpg'
		gs 'zz_render','','','Одеваясь и поправляя одежду, вы вдруг увидели одну из бабушкиных подруг. Судя по красноречивому взгляду она все видела.'
	else
		onlooker_man = 1
		gs 'zz_render','','images/qwest/gadukino/new/gadukino_old_woman'+rand(1,5)+'.jpg'
		gs 'zz_render','','','Одеваясь и поправляя одежду, вы вдруг увидели одного из деревенских жителей. Судя по красноречивому взгляду он все видел.'
	end
	act 'Уйти':gt $loc, $metka
end
!Бабка если ГГ застукали с местными
if $args[0] = 'gadukino_onlooker_woman':
	*clr & cla
	minut += 30
	onlooker_woman = 0
	grandmaQW -= 20
	grandpaQW -= 20
	grandma_notalk = 1
	grandpa_notalk = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/grandma.jpg'
	gs 'zz_render','','','Не успели вы войти в избу, как на вас накинулась бабушка.'
	if grandmaQW < 40:
		if grandma_know = 0:'- Света, это как понимать? Я думаю, что у меня внучка приличная, а мне рассказывают, что она ебется непонятно с кем. Пошла прочь отсюда, чтобы я тебя не видела!'
		if grandma_know = 1:'- Опять трахалась у всех на виду, шлюха малолетняя? Мне уже на улицу выходить стыдно из-за тебя! Пошла отсюда, не попадайся мне на глаза!'
	else
		if grandma_know = 0:'- Светуля, внучка, что ты такое вытворяешь? Я то думаю, что у меня внучка приличная, а мне тут рассказывают, как она по кустам трахается. Господи, за что ты меня так наказал!'
		if grandma_know = 1:'- Света, опять ты за своё? Трахаешься у всех на виду, хоть бы постеснялась людей. Ой, позор на мою голову!'
	end
	act 'Далее':grandma_know = 1 & grandpa_know = 1 & gt 'Gadhouse'
end
!Дед если мужики застукали
if $args[0] = 'gadukino_onlooker_man':
	*clr & cla
	minut += 10
	onlooker_man = 0
	grandpaQW -= 20
	grandpa_notalk = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/grandpa.jpg'
	gs 'zz_render','','','Не успели вы появится во дворе, как вам на встречу шагнул хмурый дед.'
	if grandpaQW < 40:
		gs 'zz_render','','','Дед посмотрел на вас гневным взглядом.'
		if grandpa_know = 0:'- Света, это как понимать? Я думаю, что у меня внучка приличная, а мне мужики тут докладывают, что она ебется на виду у всей деревни. Пошла отсюда, глаза б мои тебя не видели!'
		if grandpa_know = 1:'- Опять ебалась с кем не попадя, блядища малолетняя! Вся деревня скоро будет знать, что ты шлюха... Пошла отсюда, глаза б мои тебя не видели!'
	else
		if grandpa_know = 0:'- Света, внучка, это как понимать? Мне мужики тут рассказывают про тебя нехорошие вещи. Я понимаю, дело молодое, но на виду же у всей деревни. Не позорь нас с бабкой на старости лет.'
		if grandpa_know = 1:'Он хотел что-то сказать, но лишь махнул рукой, и еще больше нахмурившись, зашагал прочь.'
	end
	act 'Далее':grandpa_know = 1 & gt 'Gaddvor'
end
! Старики выгоняют ГГ из деревни
if $args[0] = 'gadukino_end':
	*clr & cla
	minut += 10
	grandpa_notalk = 1
	grandma_notalk = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/'+iif(grandpaQW > grandmaQW,'grandpa','grandma')+'.jpg'
	gs 'zz_render','','','Не успели вы появится в избе, как вам на встречу '+iif(grandpaQW > grandmaQW,'шагнул хмурый дед','вышла хмурая бабушка')+'.'
	if grandpaQW > grandmaQW:
		gs 'zz_render','','',' - Света, собирай свои вещи, - сказал он. - Ты едешь домой. Мать, звони Наташе, пусть приезжает за своей непутевой дочкой.'
		gs 'zz_render','','',' - Деда.... - начали вы.'
		if gad_woman_knowsex > 0 and gad_woman_knownude > 0:'- Что, деда? - грубо перебил он вас. - Раньше думать нужно было, когда голая бегала по деревне, и сношалась с кем не попадя, как сучка течная. Опозорила нас на всю деревню, на старости лет.'
		if gad_woman_knowsex > 0 and gad_woman_knownude = 0:'- Что, деда? - грубо перебил он вас. - Раньше думать нужно было, когда голая бегала по деревне и светила своей мандой всем встречным. Опозорила нас на всю деревню.'
		if gad_woman_knowsex = 0 and gad_woman_knownude > 0:'- Что, деда? - грубо перебил он вас. - Раньше думать нужно было, когда сношалась с кем не попадя, как сучка течная. Опозорила нас на всю деревню, на старости лет.'
		if gad_woman_knowsex = 0 and gad_woman_knownude = 0:'- Что, деда? - грубо перебил он вас. - Нужно было следить за своим поведением. Хорошо, что хоть на всю деревню нас не опозорила.'
	else
		gs 'zz_render','','',' - Света, собирай свои вещи, - сказал она. - Ты едешь домой. Сейчас позвоню Наташе, пусть приезжает за своей непутевой дочкой.'
		gs 'zz_render','','',' - Бабуль.... - начали вы.'
		if gad_woman_knowsex > 0 and gad_woman_knownude > 0:'- Что, бабуль? - перебила она вас. - Раньше думать нужно было, когда голая бегала по деревне, и сношалась с кем не попадя, как сучка течная. Опозорила нас на всю деревню, на старости лет.'
		if gad_woman_knowsex > 0 and gad_woman_knownude = 0:'- Что, бабуль? - перебила она вас. - Раньше думать нужно было, когда голая бегала по деревне и светила своими прелестями каждому. Опозорила нас на всю деревню.'
		if gad_woman_knowsex = 0 and gad_woman_knownude > 0:'- Что, бабуль? - перебила она вас. - Раньше думать нужно было, когда сношалась с кем не попадя, как сучка течная. Опозорила нас на всю деревню, на старости лет.'
		if gad_woman_knowsex = 0 and gad_woman_knownude = 0:'- Что, бабуль? - перебила она вас. - Нужно было вести себя лучше. Хорошо, хоть в деревне ничего не знают.'
	end
	act 'Идти собирать вещи':gt 'gadukino_event', 'pack_things'
end
! ГГ собирается домой
if $args[0] = 'pack_things':
	*clr & cla
	minut += 60
	gad_punishment = 1
	mother = 0
	father['relation'] = 0
	if gad_woman_knowsex > 0:motherKnowSpravka = 1 & motherKnowWhore = 1
	gadukino_blok = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/mother.jpg'
	gs 'zz_render','','','Пока вы рыдая собирали свои вещи, приехала мама с отчимом, и сразу же ушли на кухню, разговаривать с дедом и бабкой.'
	gs 'zz_render','','',' - Иди в машину, дома поговорим, - бросила вам мать, но по её виду вы поняли, что ничего хорошего вас там не ждет.'
	act 'Ехать в домой': gt 'gadukino_event', 'go_home_ender'
end
!Наказание ГГ
if $args[0] = 'punishment':
	*clr & cla
	manna = 0
	gad_punishment = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/mother.jpg'
	gs 'zz_render','','','В коридоре вас поджидала грозная мама.'
	if gad_woman_knowsex > 0:
		$npc['37,relation'] = 0
		$npc['35,relation'] = 0
		mother_punishment = 1
		gs 'zz_render','','','- Ну что, Света, думаю пора заняться твоим воспитанием, - с ходу начала она. - '+iif(mother_spanking = 0,'Я тебя никогда не порола... и видимо зря','Я смотрю предыдущая порка тебя ничему не научила')+'. Наверное нужно преподать тебе '+iif(mother_spanking = 0,'урок','новый урок')+'.'
	elseif gad_woman_knowsex = 0 and gad_woman_knownude > 0:
		gs 'zz_render','','','- Ну ты и учудила, Света, - сказала она, сурово глядя на вас. - Голяком по деревне бегать, это же надо додуматься!'+iif(momslut < 2,'Что о нас теперь в деревне думать будут?','Даже я в твоём возрасте такого не выкидывала!')
		gs 'zz_render','','','Вы виновато уставились в пол.'
		if mother_spanking > 0 and momslut < 2:$textmother[1] & mother_punishment = 1 & $npc['37,relation'] = 10 & $npc['35,relation'] = 10
		if mother_spanking = 0 or momslut >= 2:$textmother[2] & mother_punishment = 2 & $npc['37,relation'] = 20 & $npc['35,relation'] = 20
	else
		gs 'zz_render','','','- Света, это что за поведение? - сказала она, сурово глядя на вас. - Почему бабушка с дедушкой на тебя жалуются?'
		gs 'zz_render','','','- А что я такого сделала? - непонимающе уставились вы на мать.'
		gs 'zz_render','','','- Не хватало, чтобы ты еще что-нибудь сделала! - воскликнула она. - Они мне ничего конкретного не рассказывали, но видимо твое постоянное непослушание им надоело.'
		gs 'zz_render','','','Вы виновато уставились в пол.'
		if mother_spanking > 0:$textmother[1] & mother_punishment = 1 & $npc['37,relation'] = 20 & $npc['35,relation'] = 20
		if mother_spanking = 0:$textmother[2] & mother_punishment = 2 & $npc['37,relation'] = 30 & $npc['35,relation'] = 30
	end
	if mother_punishment = 1:
		act 'Умолять ничего не делать':
			*clr & cla
			minut += 5
			dom -= 5
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/nospanking.jpg'
			gs 'zz_render','','','- Мамочка! Прости! Это никогда не повторится! - разревелись вы, опускаясь на колени. - Я больше никогда, никогда так не буду...'
			gs 'zz_render','','','Мать смотрит на вас, качает головой, и отворачивается.'
			$textmother[2]
			act 'Отойти':gt 'korrPar'
		end
		act 'Молчать':
			*clr & cla
			mother_spanking = 1
			minut += 10
			dom += 5
			spank += 1
			spanked += 75
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/new/spanking.jpg'
			gs 'zz_render','','','Вы стоите уставившись в пол. А что тут можно сказать? Мать берет вас за руку и ведет в комнату:'
			gs 'zz_render','','','- Снимай трусы и нагнись! - слышите вы её голос и отрицательно качаете головой.'
			gs 'zz_render','','','Тогда мать хватает вас и переборов короткое сопротивление, укладывает к себе на колени. Она стягивает с вас нижнее белье берет ремень и начинает пороть вас.'
			gs 'zz_render','','','Сжав зубы вы выдерживаете экзекуцию не проронив ни слова. Подняв голову вы видите, как через незакрытую дверь, за всем этим наблюдают ваши брат и сестра.'
			$textmother[2]
			act 'Отойти':gt 'bedrPar'
		end
	else
		act 'Уйти':gt 'korrPar'
	end
end
$textmother[1] = '- Думаю нужно продолжить твое воспитание, - продолжила мать. - Я смотрю предыдущая порка тебя ничему не научила. Наверное нужно преподать тебе новый урок.'
$textmother[2] = '- Глаза б мои тебя не видели... - горько вздохнула мать, собираясь уходить. - Горе луковое... Не вздумай теперь в деревню соваться: старики не пустят даже в сарай. И на улице в деревне не смей появляться - не позорь нас с отцом! Деды простят со временем, конечно - они любят тебя, дурочку. Но для этого надо будет паинькой быть, и со мной отличные отношения иметь!'
!Прощение ГГ
if $args[0] = 'absolution':
	*clr & cla
	minut += 5
	gadukino_blok = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/mother.jpg'
	gs 'zz_render','','','В коридоре вы встретили маму.'
	gs 'zz_render','','',' - О, Светуля, на ловца и зверь бежит, - с улыбкой сказала она. - Звонила бабушка. Они с дедом отошли и простили тебя. Говорят, даже соскучились. Так что можешь приезжать к ним в Гадюкино когда захочешь.'
	act 'Отойти': gt $curloc
end
! Если ГГ появлялась в деревне во время запрета
if $args[0] = 'offense':
	*clr & cla
	minut += 5
	gs 'npc_editor','change_rep','-', 37, 10
	gad_offense = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/mother.jpg'
	gs 'zz_render','','','В коридоре вы встретили мать.'
	gs 'zz_render','','',' - Света, почему тебя видели в деревне?, - спросила она нахмурившись. - Я тебе что говорила? Чтобы ноги твоей в Гадюкино не было. Придет время, дедушка с бабушкой сами тебя простят. А до этого даже думать не смей там появляться, если не хочешь портить отношения со мной.'
	act 'Отойти': gt $curloc
end
! очистка корзинки
if $args[0] = 'clearing_basket':
	boletus = 0
	bilberry = 0
end
!проверка на присутствие деда и бабки в сарае
if $args[0] = 'gadsarai_check':
	grandma_ingadsarai = 0
	grandpa_ingadsarai = 0
	grandparents_ingadsarai = 0
	if month >= 5 and month <= 9 and sunWeather >= 0 and hour > 13 and hour < 18 and week < 6:grandma_ingadsarai = 1
	if month > 5 and month < 9 and sunWeather >= 0 and hour > 7 and hour < 13 and graze_cow = 0 and (week = 2 or week = 4):grandpa_ingadsarai = 1
	if grandma_ingadsarai = 1 or grandpa_ingadsarai = 1:grandparents_ingadsarai = 1
end