if $args[0] = 'din_beach_adventure':
	i = rand(1,200)
	if vnesh >= i:
		cla & *clr
		i = rand(1,10)
		if i < 3:
			gt'belyi_events','lake_start'
		elseif i = 3:
			gs 'zz_render', '', 'pavlovo/glake/lake_boy/3boys.jpg', 'Пока вы загораете к вам подсаживаются трое парней.'
			act 'Уйти':gt 'glake'
		elseif i = 4:
			gs 'zz_render', '', 'pavlovo/glake/lake_boy/caucasian.jpg', 'Пока вы загораете к вам подсаживаются трое молодых парней, по внешнему виду явно кавказцев.'
			act 'Уйти': gt 'glake'
		else
			gs'BnameGen'
			gs 'zz_render', '', 'pavlovo/glake/lake_boy/boy.jpg', 'Пока вы загораете к вам подсаживается парень. Он представляется как <<$bname>> и спрашивает как вас зовут.'
			act 'Уйти': gt 'glake'
			act'<<$name[1]>>':
				cla & *clr
				gs'stat'
				gs 'zz_render', '', 'pavlovo/glake/lake_boy/boy.jpg', 'Вы отвечаете парню, что вас зовут <<$name[1]>>.'
				i = RAND(0,200)
				if vnesh >= i:
					gs 'zz_render', '', '', '\\\- Ты классная девчонка. Может мы еще встретимся?/// - спросил <<$bname>>'
					if alko < 6:act 'Отказать ему и уйти':gt'glake'
					act 'Сказать ему свой телефон':
						cla & *clr
						manna += 10
						numboyFrend += 1
						$nameBoyfrend[numboyFrend] = $bname
						dickBoyFrend[numboyFrend] = dick
						silavagBoyFrend[numboyFrend] = silavag
						otnBoyFrend[numboyFrend] = 50
						minut += 30
						bmFrend[Tboynum] = 1
						gs'stat'
						gs 'zz_render', '', 'pavlovo/glake/lake_boy/boy.jpg', 'Вы сказали парню свой телефон и он записал его, после чего сославшись на срочные дела, и обещая позвонить, ушел.'
						act 'Уйти': gt'glake'
					end
				else
					gs 'zz_render', '', '','<<$bname>> подсаживается к вам ближе и предлагает вам выпить холодного пивка за знакомство.'
					if alko < 3 or alko >= 6:act 'Отказать ему и уйти': gt'glake'
					act'Выпить пива':
						cla & *clr
						minut += 15
						gs 'zz_funcs', 'alko', 3
						gs'stat'
						gs 'zz_render', '', 'pavlovo/glake/lake_boy/beer.jpg', 'Вы выпили пива с парнем. Пока выпили, он всё время травил вам байки и анекдоты, стараясь вас развеселить. Вдруг он положил свою ладонь вам на ногу:\\\- Еще по пиву <<$name[2]>>?///'
						if alko < 3:act 'Отказатся и уйти': gt'glake'
						act'Выпить еще пива':
							cla & *clr
							minut+=15
							gs 'zz_funcs', 'alko', 3
							horny += 5
							gs'stat'
							gs 'zz_render', '', 'pavlovo/glake/lake_boy/talk.jpg', 'Вы выпили еще пива с парнем и он продолжил вас развлекать свотми рассказами, поглаживая переодически ваши ноги, а вскоре и вовсе положил свою руку вам на грудь, начав нежно сжимать ее.'
							if rand(1,100)<=20:
								gs 'zz_render', '', '','Он прошептал вам:**\\\- Давай поцелуемся...///'
								if alko < 6 and horny < 75:act 'Отказатся и уйти': gt'glake'
								act 'Целоваться':
									cla & *clr
									horny += 10
									minut += 5
									gs'stat'
									gs 'zz_render', '', 'pavlovo/glake/lake_boy/kiss.jpg','Вы страстно целуетесь и <<$bname>> гладит ваше тело и ласкает ваши груди. Он предлагает пойти к нему домой'
									if alko < 6 and horny < 75: act 'Отказатся': gt'glake'
									act'Идти к парню':
										minut += 35
										gs 'zz_clothing', 'redress', prev_clothing
										tanga = flag_tanga
										prev_clothing = -1
										gt'glake_events','LBZhouse'
									end
								end
							else
								gs 'zz_render', '', '','\\\- Может прогуляемся? -/// предлагает он вам.'
								act 'Отказатся': gt'glake'
								act 'Идти гулять':
									cla & *clr
									minut += 60
									gs 'zz_clothing', 'redress', prev_clothing
									tanga = flag_tanga
									prev_clothing = -1
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/glake/lake_boy/walk.jpg','Вы быстро переодеваетесь и идете с парнем гулять. <<$bname>> предлагает зайти к нему домой.'
									if alko < 6 and horny < 75:act 'Отказатся и уйти':gt'gorodok'
									act'Идти к парню': gt'glake_events','LBZhouse'
								end
							end
						end
					end
				end
			end
		end
	end
end
if $args[0] = 'LBZhouse':
	cla & *clr
	temp_sex=0
	temp_bj=0
	temp_anal=0
	temp_hj=0
	$boy = $bname
	silavag = rand(0,2)
	dick = rand(12,20)
	i = rand(1,10)
	gs'stat'
	gs 'zz_render', '', 'pavlovo/glake/lake_boy/house<<i>>.jpg', 'Вы пришли домой к парню и он проводил вас в свою комнату, где начал вас целовать.'
	act'Целоваться':
		cla & *clr
		minut += 5
		gs'stat'
		if rand(1,100) < 70:
			gs 'zz_render', '', 'pavlovo/glake/lake_boy/kiss_house.jpg', '<<$bname>> надавливает вам на плечи и вы садитесь перед ним на корточки.'
			act'Сосать': gt'glake_events','LBZhouse_bj'
			act'Дрочить':
				cla & *clr
				hj+=1
				minut += 5
				gs 'stat'
				'<center><img src="images/lur/sex/hj0.gif"></center>'
				gs 'zz_render', '', 'pavlovo/glake/lake_boy/hj.gif','Вы берете член парня в руку и начинаете его дрочить, вскоре <<$bname>> сдавленно говорит:**\\\- <<$name>>, я сейчас кончу...///'
				act'Дать': gt'glake_events','LBZhouse_sex'
				act 'Дать в попу': gt'glake_events','LBZhouse_anal'
			end
		else
			gs 'zz_render', '', 'pavlovo/glake/lake_boy/kiss_house_bed.jpg','<<$bname>> раздевает вас и укладывает на кровать.'
			act'Дать': gt'glake_events','LBZhouse_sex'
			act 'Дать в попу': gt'glake_events','LBZhouse_anal'
			act'Давай лучше я ротиком поласкаю тебя': gt'glake_events','LBZhouse_bj',1
		end
	end
end
if $args[0] = 'LBZhouse_bj':
	cla & *clr
	bj+=1
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/glake/lake_boy/bj'+iif(args = 0,rand(0,2),rand(3,5))+'.gif','Вы берете член парня в руки и подносите к своим губам.'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render', '', '','Вскоре <<$bname>> сдавленно говорит:**\\\- <<$name>>, я сейчас кончу...///'
	act'Сосать дальше':
		cla & *clr
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_render', '', 'pavlovo/glake/lake_boy/bj<<args>>.gif','Член начинает кончать и теплые струи вязкой спермы попадают вам в рот и на лицо. Вскоре поток спермы иссякает оставляя вас с противным вкусом во рту и обтекающей белой слизью по коже вашего лица.'
		act'Встать': gt'glake_events','LBZhouse_end'
	end
	act'Дать': gt'glake_events','LBZhouse_sex'
	act 'Дать в попу': gt'glake_events','LBZhouse_anal'
end
if $args[0] = 'LBZhouse_sex':
	cla & *clr
	gs'stat'
	i = rand(0,2)
	pose = i
	gs 'zz_render', '', 'pavlovo/glake/lake_boy/sex<<i>>.gif'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act'Встать':gt'glake_events','LBZhouse_end'
end
if $args[0] = 'LBZhouse_anal':
	cla & *clr
	gs 'zz_funcs', 'cum', 'anus'
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/glake/lake_boy/anal'+rand(0,2)+'.gif'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal_', 'dick'
	gs 'zz_dynamic_sex', 'anal_cum'
	act'Встать': gt'glake_events','LBZhouse_end'
end
if $args[0] = 'LBZhouse_end':
	cla & *clr
	gs'stat'
	guy += 1
	gs 'zz_bathroom', 'clean_me'
	minut += 15
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/glake/lake_boy/shower'+rand(1,3)+'.jpg', 'Вы встали с кровати и пошли в ванную коинату. Включив воду вы начали намыливать свое тело мочалкой. После смыли мыло и помыли волосы шампунем. Смыв шампунь вы стали совершенно чистой.'
	act 'Выйти из ванны':
		cla & *clr
		hapri = 1
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/glake/lake_boy/house<<i>>.jpg', '<<$boy>>, встретив вас у дверей ванной комнаты, быстро выпроваживает вас из квартиры, едва дав одеться и привести себя в относительный порядок.'
		act'Уйти':gt'gorodok'
	end
end
if $args[0] = 'voyeurism_start':
	!!Глобальная переменная "voyeurism_start" отвечает за старт эвента подглядывания на пляже и разрешает игроку подглядывать за нудистами.
	!!Используется только здесь, но между первым и вторым тиком может пройти много игрового времени, поэтому определена глобально.
	if voyeurism_start < 2:
		act 'Оглядеться по сторонам':
			cla & *clr
			minut += 5
			i = rand(1,3)
			gs'stat'
			if i = 3:
				voyeurism_start = 1
				gs 'zz_render','','pavlovo/glake/voyeurism_start/start.jpg','Вы осматриваетесь и вдруг замечаете'+iif(voyeurism_start = 0,', что в конце пляжа'+iif(lake_people < 2,'',', укрывшись от других загарющих, но хорошо видимая с вашего места,')+' на песке лежит парочка влюблённых','парочку влюблённых, которую вы уже видели ранее')+'. Девушка полностью обнажена и её рука поглаживает член парня сквозь белоснежные штаны. '+iif(voyeurism_start = 0,'Парень поворачивает голову и замечает, что вы смотрите на них. Вы тут же отворачиваетесь, жутко краснеете и начинаете изучать свои ноги, как будто видите их первый раз в жизни.','')
				if voyeurism_start = 0:
					act 'Отвернуться': gt 'gLakeNude'
				else
					act 'Попробовать подсмотреть':
						cla & *clr
						!!Глобальная переменная "voyeurism" отвечает за общее количество раз, когда подсматривали за людьми.
						!!Сделана по большей части на будущее, чтобы стартовать другие ветки связанные с вуаеризмом. Если значение будет большое -
						!!понятно что игроку эта тема интересна, а если нет - показывать ему этот контент не нужно.
						!!Старался ограничить быстрый набор этой переменной в подглядывании за нудистами.
						!!В данный момент, выполнить условие, чтобы стартовать ветку можно подглядев за сестрой с другом, за отчимом и матерью - дома, Мирой в деревне.
						!!Или наткнувшись на случайный эвент с подглядыванием в подъезде дома ГГ. (Самый лёгкий способ позаходить несколько раз на крышу)
						minut += iif(voyeurism = 0,5,30)
						if voyeurism > 0:
							voyeurism_start = 2
							horny += 100
							voyeurism += 1
						end
						gs'stat'
						gs 'zz_render','','pavlovo/glake/self/legs.jpg','Краем глаза вы видите влюблённую парочку, но вам кажется, что они смотрят прямо на вас. Ваше лицо заливает краска и вы не в силах оторвать взляд от своих он ног.**\\"— Да и нужно мне это! Я что извращенка какая-нибудь, чтобы на голых людей пялиться?"// — думаете вы.**'+iif(voyeurism = 0,'Вы не можете вспомнить ни одного случая из своей жизни, когда вы подсматривали за кем-нибудь. Так стоит ли начинать это делать сейчас?','Но тут вы вспоминаете как совсем недавно подглядывали и думаете:**\\"– В прошлый раз было интересно, возможно всё-таки стоит поглядеть. Хотя бы одним глазом."//')
						if voyeurism = 0:
							act 'Отвернуться': gt 'gLakeNude'
						else
							act 'Подсмотреть': gt'glake_events','gLakeNude_sex'
						end
					end
				end
			else
				gs 'zz_render',$_str,func('zz_funcs','mk_image','images/pavlovo/glake/glake'+iif(lake_people = 0,'',lake_people)+'.jpg'),'Вы огляделись по сторонам, но не увидели ничего интересного.'
				act 'Назад': gt 'gLakeNude'
			end
		end
	end
	if voyeurism_start >= 2:
		act 'Подсматривать за нудистами':
			if voyeurism_nudist < 5 or func('zz_reputation','get') > 2 or shameless['flag'] > 1:
				voyeurism_nudist += 1
				gs'glake_events','gLakeNude_nudist'
				act 'Отвести взгляд': gt 'gLakeNude'
			else
				cla & *clr
				gs 'zz_render','','pavlovo/glake/self/self'+iif(current_clothing = 2,1,iif(lobok <= 0,2,iif(lobok <= 2,3,4)))+'.jpg','Вы хотите ещё поподсматривать за нудистами, но вдруг замечаете, что на вас начали странно коситься.**\\"— Наверное хватит пока подсматривать..."// — думаете вы и смотрите прямо перед собой.'
				act 'Назад': gt 'gLakeNude'
			end
		end
	end
end
if $args[0] = 'gLakeNude_sex':
	zz_stage = args[1]
	if zz_stage <= 18:
		*clr & cla
		gs 'zz_render','','pavlovo/glake/voyeurism_start/<<zz_stage>>.jpg', func('glake_events', 'gLakeNude_sex_strings','start_ev'+zz_stage)
		act iif(zz_stage < 1,'Продолжить смотреть','Далее'): gs 'glake_events', 'gLakeNude_sex', zz_stage+1
	else
		killvar 'zz_stage'
		gt 'gLakeNude'
	end
end
if $args[0] = 'gLakeNude_sex_strings':
	if $args[1] = 'start_ev0': $result = 'Вы отрываете глаза от своих прекрасных ножек и смотрите на них. Сейчас они слишком увлечены друг другом, чтобы обращать внимание на вас. Девушка взяла член парня в рот, выставив попку в соблазнительной позе.'
	if $args[1] = 'start_ev1': $result = 'Девушка умело наяривает член помогая себе ручкой. Вы не можете оторвать взгляд от её умелых губ.'
	if $args[1] = 'start_ev2': $result = 'Оставив свою одежду лежать на песке, вы перемещаетесь чуть-чуть поближе к ним, делая вид что просто гуляете по пляжу. Девушка тем временем всё сильнее заглатывает член.'
	if $args[1] = 'start_ev3': $result = 'Вдруг сильная волна набегает на влюблённых и сбивает их настрой. Девушка отрывается от члена, очевидно решив немного отдохнуть и искупаться. Они встают, и вы понимаете, что нужно что-то делать - иначе сейчас они повернутся в вашу сторону и заметят, как вас трясёт от возбуждения.'
	if $args[1] = 'start_ev4': $result = 'Как тень вы бросаетесь в сторону леса. Кусты и ветки больно царапают по вашей коже. Сухие иголки от хвойных деревьев вонзаются в ступни, заставляя вас с грустью вспомнинать об обуви, которая остались лежать на пляже.<br><dh>– По крайней мере они меня не заметили и здесь меня не видно с пляжа.</dh> – думаете вы.<br>Аккуратно пройдясь по лесу, вы обнаруживаете кусты, за которыми открывается шикарный вид на купающуюся парочку. Понимая, что делать всё равно нечего, вы присаживаетесь и продолжаете наблюдать.'
	if $args[1] = 'start_ev5': $result = 'Вы видите, как девушка выходит из воды и вдруг падает на колени, а потом на локти, выставляя свои дырочки навстречу идущему за ней парню. По лицу парня становится понятно, что ему не нужно объяснять два раза.'
	if $args[1] = 'start_ev6': $result = 'Парень опускается на колени и начинает трахать девушку раком.'
	if $args[1] = 'start_ev7': $result = 'В один момент, когда парень засаживает свой член особенно глубоко, девушка вскрикивает на весь пляж. После чего отстраняется и ложится на спину.'
	if $args[1] = 'start_ev8': $result = 'Раздвинув ножки девушки, парень опять вставляет член в её киску.'
	if $args[1] = 'start_ev9': $result = 'Он яростно вгоняет свой член снова и снова.'
	if $args[1] = 'start_ev10': $result = 'Похоже теперь набегающие волны совершенно не мешают им получать удовольствие.'
	if $args[1] = 'start_ev11': $result = 'Громкий стон срывается с губ девушки, когда парень вгоняет свой член на всю длину. Видимо её вагина ещё недостаточно разработана, чтобы вместить его агрегат полностью. Девушка упирается руками в парня, прося дать ей небольшую передышку, отстраняется от него, встаёт и отходит подальше от воды. Вы видите, как дрожат её ноги, когда она идёт. Сделав ещё несколько шагов, она ложится животом на песок и широко раскидывает ноги.'
	if $args[1] = 'start_ev12': $result = 'Парень подходит к ней. Вы видите, как он сгорает от нетерпения вновь оказаться в ней. Схватившись за мягкую попку, он поднимет её над песком и всаживает член в сочащуюся соком дырочку.'
	if $args[1] = 'start_ev13': $result = 'Крепко сжимая попку, парен остервенело трахает её писечку.'
	if $args[1] = 'start_ev14': $result = 'Молниеносным движением парень переворачивает девушку на спину. Вы на секунду успеваете удивиться его силе…'
	if $args[1] = 'start_ev15': $result = '…он буквально два раза вгоняет свой член в неё…'
	if $args[1] = 'start_ev16': $result = '…и тут же достаёт его, начиная обильно кончать на живот девушке.'
	if $args[1] = 'start_ev17': $result = 'Сперма тяжёлыми каплями падает на перепачканный песком животик девушки. Вы видите, как она выгибается, пытаясь поймать язычком хотя-бы капельку.<br>Закончив парень обессилено валится на девушку сверху. Похоже ничего интересного больше не будет.'
	if $args[1] = 'start_ev18': $result = 'Вы отворачиваетесь от парочки и начинаете размышлять о том, как отсюда выбираться. Вы решаете аккуратно пройти по лесу в сторону своих вещей, а потом выйти из него сделав вид, что ходили пописать.'
	if $args[1] = 'piss0': $result = 'Девушка идёт по лесу, пытаясь найти место, где можно спокойно пописать.'
	if $args[1] = 'piss1': $result = 'Девушка останавливается, поднимает платье, и вы видите, что под ним нет трусиков.'
	if $args[1] = 'piss2': $result = 'Девушка присаживается. Вы присаживаетесь неподалёку от неё, делая вид что тоже собираетесь писать.'
	if $args[1] = 'piss3': $result = 'Тугая струя мочи вырывается из её киски. Видимо она давно хотела пописать.'
	if $args[1] = 'piss4': $result = 'Она явно получает удовольствие от процесса.'
	if $args[1] = 'piss5': $result = 'А вы возбуждаетесь, глядя как журчит моча из её киски.'
	if $args[1] = 'piss6': $result = 'Девушка бросает короткий взгляд в вашу сторону. Непонятно заметила она вас или нет.'
	if $args[1] = 'piss7': $result = 'Струя потихоньку ослабевает. Ясно, что она скоро закончит.'
	if $args[1] = 'piss8': $result = 'Зрелище писающей красотки так возбудило вас, что вы готовы кончить прямо сейчас.'
	if $args[1] = 'piss9': $result = 'Девушка встаёт и поправляет одежду. Вы тоже поднимаетесь и быстро ретируетесь на пляж.'
end
if $ARGS[0] = 'gLakeNude_nudist':
	*clr & cla
	minut += 10
	horny += 10
	voyeurism += 1
	!Эти локальные константы нужны для того, чтобы вероятность отображения каждой фотографии из трёх папок была одинаковой.
	!Если вы хотите добавить ещё фотографий их нужно разместить в папку по смыслу, назвать в соответствии с другими фото в папке и дать ей следующий номер по порядку.
	!После чего нужно увеличить константу которая соответствует этой папке, на это значение.
	kol_foto_girl = 117
	kol_foto_group = 9
	kol_foto_couple = 24
	!!!!!!!!!!!!!!!!!!!!!
	viewnudist = rand(1,kol_foto_girl+kol_foto_group+kol_foto_couple)
	gs 'stat'
	if viewnudist <= kol_foto_girl:
		gs 'zz_render','','pavlovo/glake/nudist/girls/nudistgirl_'+rand(1,kol_foto_girl)+'.jpg','Вы тайком пялитесь на голую девушку.'
	end
	if viewnudist > kol_foto_girl and viewnudist <= kol_foto_girl+kol_foto_group:
		gs 'zz_render','','pavlovo/glake/nudist/group/nudistgroup_'+rand(1,kol_foto_group)+'.jpg','Вы коситесь на группу обнажённых людей. Может быть тоже прийти сюда с друзьями?'
	end
	if viewnudist > kol_foto_girl+kol_foto_group:
		gs 'zz_render','','pavlovo/glake/nudist/couple/nudistcouple_'+rand(1,kol_foto_couple)+'.jpg','Вы пялитесь на голую парочку. Похоже им хорошо вместе.'
	end
end
if $ARGS[0] = 'gLakeNudeForest_piss':
	voyeurism_forest = 1
	zz_stage = args[1]
	if zz_stage <= 9:
		*clr & cla
		gs 'zz_render','','pavlovo/glake/piss_forest_start/piss_forest_start_'+ zz_stage +'.jpg', func('glake_events', 'gLakeNude_sex_strings','piss'+zz_stage)
		act iif(zz_stage < 1,'Подглядывать за ней','Далее'): gs 'glake_events', 'gLakeNudeForest_piss', zz_stage+1
	else
		horny += 30
		minut += 5
		killvar 'zz_stage'
		gt 'gLakeNude'
	end
end