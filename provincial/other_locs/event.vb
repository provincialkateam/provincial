if $ARGS[0] = 'klof 2':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/klof/15_1.jpg', func('event_strings', 'local_str1')
	act 'Одеться': gt'event','klof 3'
end
if $ARGS[0] = 'klof 3':
	*clr & cla
	minut += 5
	klofQW = 2
	gs 'stat'
	gs 'zz_render', '', 'images/klof/15_1.jpg', func('event_strings', 'local_str2')
	act 'Уйти': gt 'zz_park'
end
if $ARGS[0] = 'dima':
	*clr & cla
	gs 'zz_render', '', '', func('event_strings', 'local_str12')
	act 'Нет': gt 'shop','start'
	act 'Куда пригласить?':
		cla
		gs 'zz_render', '', '', func('event_strings', 'local_str13')
		act 'Нет': gt 'shop','start'
		act 'Да':
			*clr & cla
			minut += 60
			gs 'zz_render', '', '', func('event_strings', 'local_str14')
			act 'Вы извините, но я пожалуй пойду': gt'street'
			act 'Пить водку': gt'event','dima2'
		end
	end
end
if $ARGS[0] = 'dima2':
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'zz_render', '', '', func('event_strings', 'local_str15')
	act 'Стонать от удовольствия':gt'event','dima3'
end
if $ARGS[0] = 'dima3':
	*clr & cla
	minut += 10
	gs 'stat'
	gs 'zz_render', '', '', func('event_strings', 'local_str16')
	act 'Опуститься на колени':gt'event','dima4'
end
if $ARGS[0] = 'dima4':
	*clr & cla
	minut += 10
	guy += 2
	bj += 2
	throat += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima.jpg', func('event_strings', 'local_str17')
	act 'Вскрикнуть от боли':gt'event','dima5'
end
if $ARGS[0] = 'dima5':
	*clr & cla
	minut += 10
	group += 1
	throat += 1
	anus += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs 'zz_funcs', 'cum', 'lip'
	orgasm += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima1.jpg', func('event_strings', 'local_str18')
	act 'Облизать': gt'event','dima6'
end
if $ARGS[0] = 'dima6':
	*clr & cla
	if mop > 1: mop = 0 & vidageday -= 1
	minut += 10
	gs 'zz_funcs', 'cum', 'lip'
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima2.jpg', func('event_strings', 'local_str19')
	act 'Очень': gt'event','dima7'
end
if $ARGS[0] = 'dima7':
	*clr & cla
	minut += 10
	group += 1
	vagina += 1
	anus += 1
	gs 'zz_funcs', 'cum', 'ass'
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima3.jpg', func('event_strings', 'local_str20')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Не надо... Я сделаю все что хочешь!':gt'event','dima8'
end
if $ARGS[0] = 'dima8':
	*clr & cla
	spank += 1
	minut += 10
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima4.jpg', func('event_strings', 'local_str21')
	act 'Отсосать':gt'event','dima9'
end
if $ARGS[0] = 'dima9':
	*clr & cla
	minut += 30
	throat += 1
	bj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima5.jpg', func('event_strings', 'local_str22')
	act 'Плакать у батареи':gt'event','dima10'
end
if $ARGS[0] = 'dima10':
	*clr & cla
	minut += 30
	dimaQW = 2
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str23')
	act 'Сбежать': gt 'street'
	act 'Уснуть': gt 'event','dima11'
end
if $ARGS[0] = 'dima11':
	*clr & cla
	minut += 480
	datster = 1
	bj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima7.jpg', func('event_strings', 'local_str24')
	act 'Сосать': gt 'event','dima12'
end
if $ARGS[0] = 'dima12':
	*clr & cla
	minut += 10
	throat += 1
	bj += 1
	swallow += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima8.jpg', func('event_strings', 'local_str25')
	act 'Покорно исполнить': gt'event','dima13'
	act 'Исполнить с энтузиазмом': gt'event','dima14'
	act 'Попытаться откусить': gt'event','dima31'
end
if $ARGS[0] = 'dima13':
	*clr & cla
	minut += 5
	eggs += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima9.jpg', func('event_strings', 'local_str26')
	act 'Потупить взор': gt'event','dima39'
end
if $ARGS[0] = 'dima14':
	*clr & cla
	minut += 10
	eggs += 1
	throat += 1
	bj += 1
	swallow += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima9.jpg', func('event_strings', 'local_str27')
	act 'Сглотнуть': gt 'event','dima15'
end
if $ARGS[0] = 'dima15':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str28')
	act 'Попробовать сбежать':
		if rand(0,10) < 9:
			gt 'event','dima18'
		else
			gt 'street'
		end
	end
	act 'Идти в ванную':gt'event','dima16'
end
if $ARGS[0] = 'dima16':
	*clr & cla
	minut += 30
	lobkoef = 3
	legkoef = 3
	gs 'zz_bathroom', 'shower'
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str29')
	act 'Надеть сетку': gt'event','dima19'
	act 'Не надевать и выйти из ванной': gt'event','dima17'
end
if $ARGS[0] = 'dima17':
	*clr & cla
	dom += 2
	minut += 30
	lobkoef = 3
	legkoef = 3
	gs 'zz_bathroom', 'shower'
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str30')
	act 'Смотреть на мужиков с вызовом': gt'event','dima'+iif(rand(0,10),'18','21')
end
if $ARGS[0] = 'dima18':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str31')
	act 'Провалиться в сон': gt'event','dima49'
end
if $ARGS[0] = 'dima19':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', '', func('event_strings', 'local_str32')
	act 'Обслужить мужиков по высшему разряду': gt'event','dima20'
end
if $ARGS[0] = 'dima20':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', '', func('event_strings', 'local_str32')
	act 'Обслужить мужиков по высшему разряду': gt'event','dima21'
end
if $ARGS[0] = 'dima21':
	*clr & cla
	hour += 3
	dimaQW = 2
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima3.jpg', func('event_strings', 'local_str34')
	act 'Уйти': gt'street'
end
if $ARGS[0] = 'dima30':
	dimaQW = 2
	act 'Уйти': gt 'street'
end
if $ARGS[0] = 'dima31':
	*clr & cla
	minut += 30
	dimaQW = 2
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str36')
	act 'Очнуться': gt'event','dima32'
end
if $ARGS[0] = 'dima32':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10028_TommyPistolJacquelineBlackLady_180.jpg', func('event_strings', 'local_str37')
	act 'Сопротивляться': gt'event','dima33'
	if Kik > 50: act 'Ударить ногой': gt'event','dima37'
end
if $ARGS[0] = 'dima33':
	*clr & cla
	minut += 10
	throat += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10028_TommyPistolJacquelineBlackLady_183.jpg', func('event_strings', 'local_str38')
	act 'Продолжить ублажать': gt'event','dima38'
	act 'Перестать двигать языком': gt'event','dima34'
end
if $ARGS[0] = 'dima34':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10028_TommyPistolJacquelineBlackLady_187.jpg', func('event_strings', 'local_str39')
	act 'Стоять неподвижно':gt'event','dima35'
end
if $ARGS[0] = 'dima35':
	*clr & cla
	minut += 30
	vagina += 1
	rape += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10028_TommyPistolJacquelineBlackLady_301.jpg', func('event_strings', 'local_str40')
	act 'Прийти в себя':gt'event','dima36'
end
if $ARGS[0] = 'dima36':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10028_TommyPistolJacquelineBlackLady_352.jpg', func('event_strings', 'local_str41')
	act 'Уйти': gt'street'
end
if $ARGS[0] = 'dima37':
	*clr & cla
	minut += 30
	money = 0
	gs 'stat'
	gs 'zz_render', '', 'images/pic/Kik.jpg', func('event_strings', 'local_str42')
	act 'Расслабиться': gt 'street'
end
if $ARGS[0] = 'dima38':
	*clr & cla
	minut += 30
	bj += 1
	gs 'zz_funcs', 'cum', 'lip'
	throat += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10028_TommyPistolJacquelineBlackLady_184.jpg', func('event_strings', 'local_str43')
	act 'Уйти': gt'street'
end
if $ARGS[0] = 'dima39':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet085.jpg', func('event_strings', 'local_str44')
	act 'Кивать': gt'event','dima40'
	act 'Отказаться': gt'event','dima45'
end
if $ARGS[0] = 'dima40':
	*clr & cla
	minut += 30
	vagina += 2
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet113.jpg', func('event_strings', 'local_str45')
	act 'Сменить позицию': gt'event','dima41'
end
if $ARGS[0] = 'dima41':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet154.jpg', func('event_strings', 'local_str46')
	act 'Встать на колени': gt'event','dima42'
end
if $ARGS[0] = 'dima42':
	*clr & cla
	minut += 30
	bj += 1
	gs 'zz_funcs', 'cum', 'lip'
	throat += 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet231.jpg', func('event_strings', 'local_str47')
	act 'Ждать возвращения':gt'event','dima43'
	act 'Убежать': gt'event','dima44'
end
if $ARGS[0] = 'dima43':
	*clr & cla
	minut += 50
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet263.jpg', func('event_strings', 'local_str48')
	act 'Идти во двор': gt'street'
end
if $ARGS[0] = 'dima44':
	*clr & cla
	minut += 15
	money = 0
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet264.jpg', func('event_strings', 'local_str49')
	act 'Расслабиться': gt 'street'
end
if $ARGS[0] = 'dima45':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/13606_ZenzaRaggiNikiSweet084.jpg', func('event_strings', 'local_str50')
	act 'Идти в подвал': gt'event','dima46'
end
if $ARGS[0] = 'dima46':
	*clr & cla
	minut += 5
	throat += 1
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	bj += 1
	gloryhole += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/15933_MarkDavisDonnaAnnika_447.jpg', func('event_strings', 'local_str51')
	act 'Согласиться отсасывать': gt'event','dima47'
	act 'Отказаться продолжать': gt'event','dima48'
end
if $ARGS[0] = 'dima47':
	*clr & cla
	minut += 50
	throat += 5
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 8
	bj += 8
	gloryhole += 8
	vagina += 1
	money += 1000
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/15933_MarkDavisDonnaAnnika_494.jpg', func('event_strings', 'local_str52')
	act 'Выйти на улицу': gt'nord'
end
if $ARGS[0] = 'dima48':
	*clr & cla
	minut += 50
	throat += 5
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 8
	bj += 8
	gloryhole += 8
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/15933_MarkDavisDonnaAnnika_481.jpg', func('event_strings', 'local_str53')
	act 'Выйти на улицу':gt'nord'
end
if $ARGS[0] = 'dima49':
	*clr & cla
	minut += 50
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10022_ParisTommy_021.jpg', func('event_strings', 'local_str54')
	act 'Кивнуть':gt'event','dima50'
end
if $ARGS[0] = 'dima50':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10022_ParisTommy_028.jpg', func('event_strings', 'local_str55')
	act 'Отсосать': gt'event','dima51'
	act 'Послать': gt'event','dima'+iif(agil < 50,'52','53')
end
if $ARGS[0] = 'dima51':
	*clr & cla
	minut += 5
	throat += 1
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
	gs 'zz_funcs', 'cum', 'face'
	bj += 1
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10022_ParisTommy_088.jpg', func('event_strings', 'local_str56')
	act 'Привести себя в порядок': gt'nord'
end
if $ARGS[0] = 'dima52':
	*clr & cla
	minut += 20
	throat += 2
	gs 'zz_funcs', 'cum', 'lip'
	swallow += 2
	gs 'zz_funcs', 'cum', 'face'
	bj += 2
	money = 0
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/10022_ParisTommy_308.jpg', func('event_strings', 'local_str57')
	act 'Расслабиться': gt 'street'
end
if $ARGS[0] = 'dima53':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', '', func('event_strings', 'local_str58')
	act 'Привести себя в порядок':gt'nord'
end
if $ARGS[0] = 'scoreslut1':
	*clr & cla
	minut += 30
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str59')
	act 'Испуганно смотреть': gt'event','scoreslut2'
	act 'Пытаться вырваться': gt'event','scoreslut3'
end
if $ARGS[0] = 'scoreslut2':
	*clr & cla
	dom -= 2
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str60')
	gs 'event','dima30'
end
if $ARGS[0] = 'scoreslut3':
	*clr & cla
	dom -= 2
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/picQW/dima6.jpg', func('event_strings', 'local_str61')
	gs 'event','dima30'
end
if $ARGS[0] = 'dimaQW_intro':
	if dimaQW = 0:
		gs 'zz_render','','','В холле магазина на вас оценивающе смотрит какой-то мужчина.'
		act 'Смотреть на него': gt'event','dima'
	elseif dimaQW = 1:
		gs 'zz_render','','','В холле магазина вы замечаете Диму и вас сковывает страх, вы не можете пошевелиться.'
		act 'Смотреть на него':gt'event','scoreslut1'
	else
		gs 'zz_render','','','Вам встретился тот самый Дима который с дружком развлекался трахая вас. Дима с самоуверенной усмешкой подошел к вам и поздоровался.'
		act 'Поздороваться':
			cla
			gs 'zz_render','','','<do>- Пойдем ко мне, у меня жены дома нет</do> - сказал Дима.'
			act 'Нет': gt 'shop'
			act 'Пойдем':
				*clr & cla
				if RAND(1,2) = 1:
					throat += 1
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					gs 'zz_render','','images/pics/gostDT2.jpg','Дима отвел вас к себе домой и там приказал вам встать на колени. Вы встали на колени и он называя вас сучкой и хуесоской стал трахать вас в рот. Наконец то Дима кончил вам в рот, вы все послушно проглотили и слизали остатки спермы с его большого члена.'
				else
					anal += 1
					gs 'zz_funcs', 'cum', 'ass'
					spank += 1
					gs 'zz_render','','images/pics/gostAnal2.jpg','Дима привел вас к себе домой и прямо в коридоре начал вас целовать и раздевать. После того как он раздел вас он отвел вас в ванную. Там он усадил вас в ванную и открутив лейку душа вставил шланг с водой вам в зад. Быстро возникло чувство наполненности и Дима посадил вас на унитаз. После клизмы он поставил вас раком и вставил вам в анус свой большой член. Дима долго вас трахал и бил по заднице ладонями, вам сначала было больно, но постепенно вы вошли во вкус и начали ловить кайф, наконец ваша попка наполнилась горячей жидкостью и Дима застонав схватил ваши ягодицы.'
				end
				horny = 0
				sex += 1
				gs 'stat'
				act 'Идти домой': gt 'street'
			end
		end
	end
end