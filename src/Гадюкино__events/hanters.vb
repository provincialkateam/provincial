gs 'stat'
if hantersKnow > 0:
	if hour = 8 or hour = 14 or hour = 19:
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanters.jpg'
		gs 'zz_render','','','Расположившись на поляне возле избушки три охотника, Сергей, Игорь и Андрей расказывают друг другу всякие охотничьи байки.'
	else
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanterswork1.'+rand(1,9)+'.jpg','На поляне возле избушки три охотника, Сергей, Игорь и Андрей, занимаются своими делами.'
	end
else
	gs 'zz_render','','images/qwest/gadukino/Swamp/hanters.jpg','На поляне возле избушки вы видите трех незнакомых мужчин которые расказывают друг другу всякие охотничьи байки.'
end
act 'Уйти':gt'swamp_yard'
if hantersKnow = 0:
	act 'Познакомиться':
		*clr & cla
		minut += 5
		hantersKnow = 1
		hantersAndreiQw += 1
		hantersIgorQw += 1
		hantersSergeiQw += 1
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/Swamp/hanters1.jpg'
		gs 'zz_render','','','Вы подошли поближе и вежливо поздороваливались. Мужчины прервав разговор ответили тем же.'
		if vnesh >= 40:'-Как звать-величать тебя, красавица?- спросил один из них.'
		if vnesh < 40:'-Как звать-величать то тебя?- спросил один из них.'
		gs 'zz_render','','','- Света, - ответили вы.'
		if gadriver_gang = 0:
			gs 'zz_render','','','-А я Андрей, - ответил ответил мужчина постарше, - а это друзья мои из центра, Игорь и Сергей.'
			gs 'zz_render','','','-А твоя фамилия не Лебедева случайно? - спросил он. Вы удивленно посмотрели на него и кивнули.'
			gs 'zz_render','','','-Не удивляйся Света, ты очень похожа на маму в молодости. А я её ... Хммм... очень хорошо знал когда-то, я ведь тоже из Гадюкино.- сказал Андрей.'
			gs 'zz_render','','','-Да ты не стесняйся, присаживайся,в ногах правды нет.- сказал Сергей, освобождая для вас место .'
		else
			gs 'zz_render','','','-Ба, кого к нам занесло - удивлённо протянул мужчина постарше, - это же Света Лебедева, местная шлюшка.'
			gs 'zz_render','','','Вы удивленно посмотрели на него.'
			gs 'zz_render','','','-Не удивляйся, я ведь тоже из Гадюкино, а ты очень похожа на маму в молодости, и судя по всему такая же блядоватая.- сказал он.'
			gs 'zz_render','','',' Я Андрей, - добавил он дальше, - а это друзья мои из центра, Игорь и Сергей.'
			gs 'zz_render','','','-Да ты иди сюда, присаживайся, мы дяди добрые, не кусаемся.- сказал Сергей, освобождая для вас место .'
			hantersKnowSlut = 1
			hantersRape = 1
		end
		act 'Присесть': gt 'hanters'
		act 'Отойти': gt 'swamp_yard'
	end
elseif hour = 8 or hour = 14 or hour = 19:
	if hantersKnowSlut > 0 and horny > 50 and mesec <= 0:
		act 'Приставать':
			*clr & cla
			horny += 5
			minut += 5
			if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
			if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
			if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanters1.jpg','Вы парням строите глазки и делаете недвусмысленные намеки. Парни сразу заинтересовались...**-Светик у нас ненасытная прямо, - сказал Андрей улыбаясь. - Я рад, что мы не разачаровались в тебе.'
			act 'Далее':
				*clr & cla
				minut += 5
				gang += 1
				horny += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupundress.jpg','Растелив покрывало, ребята взяли вас под руки и подвели к нему, раздевая на ходу...'
				act 'Далее':
					*clr & cla
					minut += 1
					horny += 5
					bj += 3
					hantsexa = rand(1,3)
					hantsexb = rand(1,3)
					hantslutsex += rand(9,12)
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgrouptanga.jpg','Стянув с вас трусики, парни растегнув ширинки и дастав уже вставшие члены обступили вас.'
					if hantsexa < 3 : act 'Сосать':dynamic $hantersgroupORALasi
					if hantsexa = 3 and hantsexb = 1:act 'Сосать':dynamic $hantersgroupORALsi
					if hantsexa = 3 and hantsexb = 2:act 'Сосать':dynamic $hantersgroupORALai
					if hantsexa = 3 and hantsexb = 3:act 'Сосать':dynamic $hantersgroupORALas
				end
			end
		end
	end
	act 'Поболтать':
		*clr & cla
		minut += rand (30,90)
		manna += rand(10,20)
		if hantersAndreiQw < 10:hantersAndreiQw += 1
		if hantersIgorQw < 10:hantersIgorQw += 1
		if hantersSergeiQw < 10:hantersSergeiQw += 1
		gs 'stat'
		if func('zz_clothing2','is_skirt') and cloth[1] = 0:
			*clr & cla
			if hantersKnowSlut > 0:hanterslut += 1
			horny += rand (10,20)
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/Swamp/hantersnotanga1.jpg','Вы сидите напротив парней, забыв, что не одели трусики, поэтому рассказы у них получаются сбившимися и большую часть времени они искоса поглядывают на вашу голую письку, сверкающую из под юбки.'
		else
			gs 'zz_render','','images/qwest/gadukino/Swamp/hanters1.jpg','Вы подсев к парням стали слушать их охотничьи байки и расказывая им свои истории.'
			dynamic $hanters_talk
			gs 'zz_render','','','За разговорами время пролетело незаметно.'
		end
		act 'Отойти': gt 'swamp_yard'
	end
	if hantersAndreiQw >= 10 and hantersSergeiQw >= 10 and hantersIgorQw >= 10 and shootingday ! daystart:
		if hantersKnowSlut = 0:
			if shooting = 0:
				act 'Попросить научить стрелять из ружья':
					*clr & cla
					minut += 5
					shootingday = daystart
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/claps_eyes.jpg'
					gs 'zz_render','','',' - Ребята, а научите меня из ружья стрелять, - попросили вы парней, сидя на поляне.'
					gs 'zz_render','','',' - Светик , ну зачем тебе это? Ты же девочка, - сказал Андрей улыбаясь. - Тебе шитьем бы увлекаться, спортом, ну или еще не знаю чем. Стрельба это для мальчиков хобби.'
					gs 'zz_render','','',' - Ну пожааааалуйста, - захлопали вы глазками, сделав невинное личико.'
					if vnesh >= 40:
						shooting = 1
						if hantersAndreiQw < 20:hantersAndreiQw += 1
						if hantersIgorQw < 20:hantersIgorQw += 1
						if hantersSergeiQw < 20:hantersSergeiQw += 1
						gs 'zz_render','','',' - Все, все, Светик, сдаемся, - со смехом сказал Анрей. - Уговорила, научим мы тебя стрелять.'
					end
					if vnesh < 40:
						hantersAndreiQw -= 1
						hantersIgorQw -= 1
						hantersSergeiQw -= 1
						gs 'zz_render','','',' - Нет, Светик, не получится, - ответил сказал Анрей. - И не хлопай глазками, на нас это не действует.**- Ну и ладно, - надули вы губки и обиженно отвернулись. - Злые вы, уйду я от вас.'
					end
					if shooting = 1:
						act 'Идти стрелять':
							*clr & cla
							minut += 30
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/Swamp/shooting.jpg','Ребята вам долго объясняли, как нужно целиться, как лержать ружьё и прижимать приклад. В итоге вы решили, что готовы и решили сделать ...'
							act 'Выстрел':
								*clr & cla
								minut += 1
								shoot += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/Swamp/shooting1.gif','Все произошло не так как вы себе представляли и ожидали. Раздался ужасный гром, что-то больно ударило вас по лбу...'
								act 'Потерять сознание':dynamic $hantersgroupfaint
							end
						end
					else
						act'Уйти':gt 'swamp_yard'
					end
				end
			else
				act 'Попросить пострелять из ружья':
					*clr & cla
					minut += 5
					shootingday = daystart
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/Swamp/claps_eyes.jpg'
					gs 'zz_render','','',' - Ребята, дайте из ружья стрелять, - попросили вы парней, сидя на поляне, испульзуя проверенный, обезаруживающий взгляд.'
					if shooting = 1:' - Хорошо, Светик, только смотри не как в первый раз, - сказал Андрей улыбаясь.'
					if shooting > 1 and shooting <= 10:' - Хорошо, Светик, только смотри осторожно, - сказал Андрей улыбаясь.'
					if shooting > 10:' - Хорошо, Светик, только не увлекайся сильно, патороны не казенные, - сказал Андрей улыбаясь.'
					if shooting >= 1 and shooting <= 10:
						act 'Идти стрелять':
							temp = rand(1,2)
							if stren + shooting > 20 or stren + shooting < 20 and temp = 1:
								*clr & cla
								minut += 60
								shoot += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/Swamp/shooting2.gif','Целый час под присмотром парней вы палили из ружья.'
								act'Далее':gt 'swamp_yard'
							else
								*clr & cla
								minut += 5
								shoot += 1
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/hantersex/shooting1.gif'
								gs 'zz_render','','','Все произошло не так как в первый раз. Выстрел, удар в лоб, трава перед глазами...'
								gs 'zz_render','','',' - Света, ты там как, живая? - спросил Игорь с тревогой в голосе.'
								gs 'zz_render','','',' - Вроде да, - ответили вы, держась за ушибленный лоб и морщась.'
								gs 'zz_render','','',' - Это хорошо, - сказал Андрей смеясь. - Иди отдохни, Рэмбо ты наш.'
								act'Далее':
									*clr & cla
									minut += 1
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/Swamp/tongue.jpg',' - Я не Рэмбо, я Лара Крофт, - ответили вы Андрею, и показав на последок язык ушли.'
									act'Далее':gt 'swamp_yard'
								end
							end
						end
					else
						act 'Идти стрелять':
							*clr & cla
							minut += 60
							shoot += 1
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/Swamp/shooting2.gif','Целый час под присмотром парней вы палили из ружья.'
							act'Далее':gt 'swamp_yard'
						end
					end
				end
			end
		else
			if hantslutsex = 0:
				*clr & cla
				minut += 5
				shootingday = daystart
				hantersexnude = 1
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/claps_eyes.jpg'
				gs 'zz_render','','',' - Ребята, дайте из ружья стрелять, - попросили вы парней, сидя на поляне.'
				gs 'zz_render','','',' - Светик, харэ херней страдать, - ответил Андрей. - Иди-ка лучше к нам,делом займись.'
				act'Подойти':gt 'hanters'
			else
				*clr & cla
				minut += 5
				shootingday = daystart
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/claps_eyes.jpg'
				gs 'zz_render','','',' - Ребята, дайте из ружья стрелять, - попросили вы парней, сидя на поляне.'
				gs 'zz_render','','',' - Светик, харэ херней страдать,- ответил Андрей. - У тебя другие таланты.'
				gs 'zz_render','','',' И засмеялся, довольный своей шуткой.'
				act'Уйти':gt 'swamp_yard'
			end
		end
	end
else
	act'Поговорить с Андреем':gt'AndreiHanter'
	act'Поговорить с Сергеем':gt'SergeiHanter'
	act'Поговорить с Игорем':gt'IgorHanter'
end
!действия если ГГ шлюха в Гадюкино
if hantersRape = 3:
	cla
	*clr
	minut += 5
	hantersKnowSlut = 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	if hanterandreisex = 0:hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0:hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0:hanterigorsex = 1 & guy += 1
	if hantersIgorLove = 1:hantersIgorLove = 0 & hantersIgorQw -= 100
	if hantersIgorLove = 2:hantersIgorLove = 0 & hantersIgorQw -= 100 & bfA = 0
	if hantersIgorLove = 3:hantersIgorLove = 0 & hantersIgorQw -= 100 & husband = 0 & divorced += 1 & husbandMark = 0 & husbharmin = 0 & husbizvradd = 0
	if hantersSergeiLove = 1:hantersSergeiLove = 0 & hantersSergeiQw -= 100
	if hantersAndreiLove = 1:hantersAndreiLove = 0 & hantersAndreiQw -= 100
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax2.jpg'
	gs 'zz_render','','','Вы не успели толком расслабится, как неожиданно вас обступили парни-охотники.'
	gs 'zz_render','','','-Слыш, Светик,- сказал один из них. - Мы тут подумали, раз уж ты всем даешь, может и нас обслужишь?.'
	act 'Согласиться':
		*clr & cla
		minut += 5
		gang += 1
		hantersRape = 5
		dom -= 2
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupundress.jpg','Растелив покрывало, ребята взяли вас под руки и подвели к нему, раздевая на ходу...'
		act 'Далее':
			*clr & cla
			minut += 1
			bj += 3
			hantsexa = rand(1,3)
			hantsexb = rand(1,3)
			hantslutsex += rand(9,12)
			hantersexnude = 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgrouptanga.jpg','Стянув с вас трусики, парни растегнув ширинки и дастав уже вставшие члены обступили вас.'
			if hantsexa < 3 : act 'Сосать':dynamic $hantersgroupORALasi
			if hantsexa = 3 and hantsexb = 1:act 'Сосать':dynamic $hantersgroupORALsi
			if hantsexa = 3 and hantsexb = 2:act 'Сосать':dynamic $hantersgroupORALai
			if hantsexa = 3 and hantsexb = 3:act 'Сосать':dynamic $hantersgroupORALas
		end
	end
	act 'Отказаться':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax3.jpg'
		gs 'zz_render','','','Вы решили отказаться и начали их отталкивать, но парней такой вариант явно не устраивал.'
		gs 'zz_render','','','-Света, давай не выебывайся, - сказал Андрей, схватив вас за волосы.'
		act 'Согласиться':
			*clr & cla
			minut += 5
			gang += 1
			hantersRape = 5
			dom -= 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax4.jpg','Растелив покрывало, ребята схватив крепко вас под руки, чтобы вы и не подумали больше перечить, повели к нему ...'
			act 'Идти':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax5.'+rand(1,3),'Пока вас вели, руки ребят гуляли по всему вашему телу, ощупывая каждый сантиметр...'
				act 'Далее':
					*clr & cla
					minut += 1
					bj += 3
					hantsexa = rand(1,3)
					hantsexb = rand(1,3)
					hantslutsex += rand(9,12)
					hantersexnude = 1
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgrouptanga.jpg','Стянув с вас трусики, парни растегнув ширинки и дастав уже вставшие члены обступили вас.'
					if hantsexa < 3 : act 'Сосать':dynamic $hantersgroupORALasi
					if hantsexa = 3 and hantsexb = 1:act 'Сосать':dynamic $hantersgroupORALsi
					if hantsexa = 3 and hantsexb = 2:act 'Сосать':dynamic $hantersgroupORALai
					if hantsexa = 3 and hantsexb = 3:act 'Сосать':dynamic $hantersgroupORALas
				end
			end
		end
		act 'Сопротивляться':
			*clr & cla
			minut += 5
			gang += 1
			rape +=1
			hantersRape = 4
			dom += 1
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax6.jpg','Вы принялись отчаянно сопротивляться, но тут же получили оплеуху от Андрея, аж в ушах зазвенело...'
			act 'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax7.jpg','Он вас схватил за одежду и начал валить на землю...'
				act 'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax8.jpg'
					gs 'zz_render','','','Оказавший на земле, вы увидели перед глазами члеми Андрея. Мотнув головой вы попытались отстранится, но он крепко зажав вашу голову, насильно засунул его вам в рот.'
					gs 'zz_render','','','-Соси, сука,- услышали сквозь слёзы вы. - И не дай бог укусишь, живьем закопаю!.'
					$boy = 'Андрей'
					silavag = 0
					dick = 20
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_render','','','Сергей в это время, пользуясь вашей беспомощностью, оттянул полоску трусиков в сторону и начал орудовать пальцами в вашей писе.'
					gs 'zz_render','','','Игорь же схватив вас за руку притянул её к своему члену и вам ничего не оставалось как начать двигать вверх вниз.'
					act 'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax9.jpg','Наигравшись таким образов парни схватили вас за руки и ноги и понесли на поляну перед избушкой.'
						act 'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax10.jpg','Там вас поставили на ноги, заломав руки, чтобы присечь попытки к сопротивлению, пока Игорь не растелил покрывало...'
							act 'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax11.jpg','Растелив покрывало, вас бросили на него и стянули трусики...'
								act 'Далее':
									*clr & cla
									minut += 5
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax12.jpg','Пока Сергей с Игорем держали ваши руки и мяли ваши груди, Андрей принялся ощупывать вашу писю...'
									act 'Далее':
										*clr & cla
										minut += 5
										gs 'stat'
										gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax14.jpg','Он засунул в неё пальцы и принялся разрабатывать, вам оставалось только наблюдать, подрачивая члены Сергей с Игорем, которые они всунули вам в руки...'
										act 'Далее':
											*clr & cla
											minut += 1
											bj += 3
											hantsexa = rand(1,3)
											hantsexb = rand(1,3)
											hantslutsex += rand(9,12)
											hantersexnude = 1
											gs 'stat'
											gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax13.jpg','Наконец он вынул из вас свои пальцы и парни став вокруг вас поднесли свои члены к вашему лицу.**-Ну Света, приступим, - сказал Андрей.'
											act 'Сосать':dynamic $hantersgroupORALasi
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
!если ГГ согласилась отсосать после стриптиза и последующего секса
if hantdanceslut = 2:
	*clr & cla
	minut += 1
	hantdanceslut = 4
	hantersRape = 5
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax2.jpg','Парни подошли к вам и окружили со всех сторон.'
	act 'Сосать':
		*clr & cla
		minut += 15
		horny += rand(10,20)
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupBJ3.6.jpg','Вы принялись сосать, поочередно уделяя внимание каждому члену.'
		$boy = 'Андрей'
		silavag = 0
		dick = 20
		bj += 1
		gs 'zz_dynamic_sex', 'bj'
		$boy = 'Сергей'
		silavag = 1
		dick = 18
		bj += 1
		gs 'zz_dynamic_sex', 'bj'
		$boy = 'Игорь'
		silavag = 2
		dick = 16
		bj += 1
		gs 'zz_dynamic_sex', 'bj'
		act 'Сосать дальше':
			*clr & cla
			minut += 1
			dom -= 1
			bj += 3
			gs 'zz_funcs', 'cum', 'face'
			hantersKnowSlut = 2
			if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
			if cloth[0] > 2:cumfrot += rand(0,1)
			hantslutsex += rand(9,12)
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupO1.0.jpg'
			gs 'zz_render','','','Через пару минут парни, кончили вам на лицо и отошли в сторону.'
			gs 'zz_render','','','- Вот видишь Света, - бросил отходя Андрей. - Теперь ты и сама понимаешь кто ты.'
			gs 'zz_render','','','- И кстати, Светик, - обернулся , чуть отойдя он. - Ты не расстраивайся и не обижайся, ничего страшного в этом нет.'
			act 'Удивиться':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/Swamp/AndreiHanter.jpg'
				gs 'zz_render','','','- Как нет?, - чуть не плача спросили вы. - Вы только, что сделали из меня шлюху.'
				gs 'zz_render','','','- Светик, пойми, ты была такой всегда, просто это до поры, до времени скрывалось от тебя, - сказал Андрей. - И уж лучше, что это выяснилось здесь, с нами. Мы по крайней мере никому не расскажем. А ты , зная свою сущность, сможешь лучше контролировать себя.'
				gs 'zz_render','','','- Ты так считаешь?, - уже веселее спросили вы.'
				gs 'zz_render','','','- Конечно! - ответил он. - Ты любишь секс, мы любим секс, так зачем же нам стесняться в нашем узком кругу.'
				gs 'zz_render','','','- Да и чем черт не шутит, может и в жизни пригодится такой опыт, - добавил Андрей, задумчиво почесав подбородок.'
				act 'Далее':gt $loc, $metka
			end
		end
	end
end
!если ГГ сотказалась отсосать после стриптиза и последующего секса
if hantdanceslut = 3:
	*clr & cla
	minut += 1
	dom += 1
	hantdanceslut = 4
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/fuck.jpg','- Да пошел ты! - вы показали Андрею средний палец и развернулись, что бы уйти.'
	act 'Уйти':
		*clr & cla
		minut += 5
		gang += 1
		rape +=1
		hantersRape = 4
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax6.jpg'
		gs 'zz_render','','','- Ты совсем охуела тварь?!!! - услышали вы за спиной голос Андрея. Он схватил вас на волосы и повалил на землю.'
		gs 'zz_render','','','Вы принялись отчаянно сопротивляться, но тут же получили оплеуху от Андрея, аж в ушах зазвенело...'
		act 'Далее':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax8.jpg'
			gs 'zz_render','','','Оказавший на земле, вы увидели перед глазами члеми Андрея. Мотнув головой вы попытались отстранится, но он крепко зажав вашу голову, насильно засунул его вам в рот.'
			gs 'zz_render','','','-Соси, сука,- услышали сквозь слёзы вы. - И не дай бог укусишь, живьем закапаю!.'
			$boy = 'Андрей'
			silavag = 0
			dick = 20
			gs 'zz_dynamic_sex', 'bj'
			gs 'zz_render','','','Сергей в это время, пользуясь вашей беспомощностью, оттянул полоску трусиков в сторону и начал орудовать пальцами в вашей писе.'
			gs 'zz_render','','','Игорь же схватив вас за руку притянул её к своему члену и вам ничего не оставалось как начать двигать вверх вниз.'
			act 'Далее':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax9.jpg','Наигравшись таким образов парни схватили вас за руки и ноги и понесли на поляну перед избушкой.'
				act 'Далее':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax10.jpg','Там вас поставили на ноги, заломав руки, чтобы присечь попытки к сопротивлению, пока Игорь не растелил покрывало...'
					act 'Далее':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax11.jpg','Растелив покрывало, вас бросили на него и стянули трусики...'
						act 'Далее':
							*clr & cla
							minut += 5
							gs 'stat'
							gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax12.jpg','Пока Сергей с Игорем держали ваши руки и мяли ваши груди, Андрей принялся ощупывать вашу писю...'
							act 'Далее':
								*clr & cla
								minut += 5
								gs 'stat'
								gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax14.jpg','Он засунул в неё пальцы и принялся разрабатывать, вам оставалось только наблюдать, подрачивая члены Сергей с Игорем, которые они всунули вам в руки...'
								act 'Далее':
									*clr & cla
									minut += 1
									bj += 3
									hantsexa = rand(1,3)
									hantsexb = rand(1,3)
									hantslutsex += rand(9,12)
									hantersexnude = 1
									gs 'stat'
									gs 'zz_render','','images/qwest/gadukino/hantersex/backwaterrelax13.jpg','Наконец он вынул из вас свои пальцы и парни став вокруг вас поднесли свои члены к вашему лицу.**-Ну Света, приступим, - сказал Андрей.'
									act 'Сосать':dynamic $hantersgroupORALasi
								end
							end
						end
					end
				end
			end
		end
	end
end
!секс если ГГ голая перед охотниками
if hantersexnude = 1 or forest_hantersex = 3 or forest_gopsex = 3:
	*clr & cla
	minut += 1
	bj += 3
	hantslutsex += rand(3,6)
	gang += 1
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	if hanterandreisex = 0 and (hantersexnude = 1 or forest_hantersex = 3):hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0 and (hantersexnude = 1 or forest_hantersex = 3):hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0 and (hantersexnude = 1 or forest_hantersex = 3):hanterigorsex = 1 & guy += 1
	gs 'stat'
	if hantersexnude = 1 or forest_hantersex = 3:'<center><img src="images/qwest/gadukino/Swamp/hanters1.jpg"></center>'
	if forest_gopsex = 3:'<center><img src="images/qwest/gadukino/forest/3boys.1.jpg"></center>'
	if hantersexnude = 1 or forest_hantersex = 3:'Вы подошли к парням с игривой улыбкой...'
	gs 'zz_render','','','- Ты знаешь, что делать Светик, - сказал один из парней улыбаясь. - Приступай.'
	hantsexa = rand(1,3)
	hantsexb = rand(1,3)
	if hantsexa < 3 : act 'Сосать':dynamic $hantersgroupORALasi
	if hantsexa = 3 and hantsexb = 1:act 'Сосать':dynamic $hantersgroupORALsi
	if hantsexa = 3 and hantsexb = 2:act 'Сосать':dynamic $hantersgroupORALai
	if hantsexa = 3 and hantsexb = 3:act 'Сосать':dynamic $hantersgroupORALas
end
! секс если ГГ шлюха
if slutgosex = 1 or forest_hantersex = 1 or forest_gopsex = 1:
	*clr & cla
	minut += 5
	dom -= 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	hantslutsex += rand(3,6)
	! для перерыва между сексом, отнимается -1 каждый час
	if slutgosex = 1 or forest_hantersex = 1:clothesbackwater = 1
	if forest_gopsex = 1:clothesforest = 1
	gs 'zz_clothing2','redress',0
	if hanterandreisex = 0 and temphant = 1:hanterandreisex = 1 & guy += 1
	if hantersergeisex = 0 and temphant = 2:hantersergeisex = 1 & guy += 1
	if hanterigorsex = 0 and temphant = 3:hanterigorsex = 1 & guy += 1
	if temphant = 1:$boy = 'Андрей' & silavag = 0 & dick = 20
	if temphant = 2:$boy = 'Сергей' & silavag = 1 & dick = 18
	if temphant = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if temphant = 4:$boy = 'Митька' & silavag = 0 & dick = 16
	if temphant = 5:$boy = 'Колямба' & silavag = 0 & dick = 15
	if temphant = 6:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/slutgosex1.jpg','Вы ушли с парнем с поляны под деревья. Он тут же принялся вас раздевать.**- Ты знаешь, что делать Светик, - сказал парень улыбаясь. - Приступай.'
	act 'Сесть на корточки':dynamic $hanterslutSTART
end
!потеря сознания
$hantersgroupfaint = {
	*clr & cla
	minut += 1
	horny += rand(5,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupfaint.jpg'
	if shootingfaint = 1:
		shooting = 2
		gs 'zz_render','','','От боли в глазах у вас потемнело, мир закружился и вы потеряли сознание...'
	else
		gs 'zz_render','','','Вдруг от нестерпимой боли в глазах у вас потемнело, мир закружился и вы потеряли сознание...'
	end
	if hantersRape = 4 or hantdanceslut = 4 or forest_gopsex = 1:
		act 'Очнуться':
			*clr & cla
			minut += 10
			health = 100
			manna += 10
			hantersexnude = 0
			forest_gopsex = 0
			slutgosex = 0
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupfaint1.jpg'
			gs 'zz_render','','','Вы очнулись от потока воды, вылившегося на вас...'
			gs 'zz_render','','','-Ну что, Света, живая? - спросил <<$boy>> убедившись, что вы пришли в себя.'
			gs 'zz_render','','','Вы слабо качнули головой.'
			gs 'zz_render','','','-Ну и дадно, - сказал он и отошел в сторону.'
			act 'Далее':gt $loc, $metka
		end
	else
		act 'Очнуться':
			*clr & cla
			minut += 10
			health = 100
			manna += 10
			shootingfaint = 0
			hantersexnude = 0
			forest_gopsex = 0
			slutgosex = 0
			gs 'stat'
			gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupfaint2.jpg'
			gs 'zz_render','','','Вы очнулись от легкого похлопывания по щекам...'
			gs 'zz_render','','','-Ну что, Светик, ты как, живая? - спросил <<$boy>> убедившись, что вы пришли в себя.'
			gs 'zz_render','','','Вы слабо качнули головой.'
			gs 'zz_render','','','-Напугала ты нас, признаться, пиздец, - сказал он и отошел в сторону. - Иди в избушку, отдохни.'
			act 'Далее': gt'swamphouse'
		end
	end
}
$hantersgroupORALsi = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALsi1.'+rand(0,3)+'.jpg'
	gs 'zz_render','','','Вы принялись сосать, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел в сторону с блаженной улыбкой на лице.'
	hantsexa = rand(1,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
		if hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
		if hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
		if hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
		if hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
		if hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
		if hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
		if hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
		if hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
		if hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
		if hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
		if hantsexa = 5:act 'Сосать дальше':dynamic $hantersgroupOis
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupORALsi1 = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALsi2.'+rand(0,2)
	if hantersexnude = 1 or forest_hantersex = 3:'Вы принялись сосать Сергею и Игорю, поочередно уделяя внимание каждому члену.'
	if forest_gopsex = 3:'Вы принялись сосать Колямбе и Васяну, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	hantsexa = rand(1,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1:
			act 'Сосать дальше':
				if hantsexb < 6: dynamic $hantersgroupORALsi1
				if hantsexb = 6: dynamic $hantersgroupORALs
				if hantsexb = 7: dynamic $hantersgroupORALi
				if hantsexb = 8: dynamic $hantersgroupORALend1
			end
		elseif hantsexa = 2:
			act 'Стать на четвереньки':
				if hantsexb <= 5: dynamic $hantersgroupVis1
				if hantsexb > 6: dynamic $hantersgroupVi1
				if hantsexb = 6: dynamic $hantersgroupVs1
			end
		elseif hantsexa = 3:
			act 'Лечь на бок':
				if hantsexb <= 5: dynamic $hantersgroupVsOi
				if hantsexb > 6: dynamic $hantersgroupVOi
				if hantsexb = 6: dynamic $hantersgroupVsO
			end
		elseif hantsexa = 4:
			act 'Сесть сверху':dynamic $hantersgroupDPis
		else
			act 'Сосать дальше':dynamic $hantersgroupOis
		end
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupORALs = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALs.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Вы принялись сосать Сергею и Игорю, поочередно уделяя внимание каждому члену.'
	if forest_gopsex = 3:'Вы принялись сосать Колямбе и Васяну, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел с довольной улыбкой на лице.'
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Сосать дальше':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupORALs1 = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALs1.'+rand(0,1)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Вы принялись сосать Сергею. Он взяв вас за голову просто насаживал на свой член...'
	if forest_gopsex = 3:'Вы принялись сосать Колямбе. Он взяв вас за голову просто насаживал на свой член...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 3 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 3 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Сосать дальше':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupORALs1end = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALs1end.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Вы принялись сосать Сергею. Он взяв вас за голову просто насаживал на свой член....'
	if forest_gopsex = 3:'Вы принялись сосать Колямбе. Он взяв вас за голову просто насаживал на свой член...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел с довольной улыбкой на лице и вы остались на покрывале в одиночестве...'
	act 'Далее':gt $loc, $metka
}
$hantersgroupORALi1end = {
	*clr & cla
	pose = 0
	minut += 5
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALend1.'+rand(0,1),'Вы стали на колени. <<$boy>> взяв вас за голову просто насаживал на свой член....'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел с довольной улыбкой на лице и вы остались на покрывале в одиночестве...'
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupORALa1end = {
	*clr & cla
	pose = 0
	minut += 5
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALend1.'+rand(0,1),'Вы стали на колени. <<$boy>> взяв вас за голову просто насаживал на свой член....'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел с довольной улыбкой на лице и вы остались на покрывале в одиночестве...'
	if forest_hantersex = 0:act 'Далее':gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupORALi = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALi.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Вы принялись сосать Сергею и Игорю, поочередно уделяя внимание каждому члену.'
	if forest_gopsex = 3:'Вы принялись сосать Колямбе и Васяну, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел в сторону с довольной улыбкой на лице.'
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Сосать дальше':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupORALend1 = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALend1.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Вы принялись сосать Сергею и Игорю, поочередно уделяя внимание каждому члену.'
	if forest_gopsex = 3:'Вы принялись сосать Колямбе и Васяну, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Спермы оказалось так много, что вы не сумели всю проглотить и часть осталась на вашем лице. Сергей с Игорем отошли в сторону, оставив вас сидеть на покрывале... '
	if forest_gopsex = 3:'Спермы оказалось так много, что вы не сумели всю проглотить и часть осталась на вашем лице. Колямба с Васяном отошли в сторону, оставив вас сидеть на покрывале... '
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupORALai = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALsi1.'+rand(0,3),'Вы принялись сосать, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел в сторону с блаженной улыбкой на лице.'
	hantsexa = rand(1,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Сосать дальше':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupORALai1 = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALai1.'+rand(0,3),'Вы принялись сосать, пытаясь взять сразу два члена в рот одновременно.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	hantsexa = rand(1,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Сосать дальше':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupORALi1 = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(10,20)
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALi1.jpg','Вы принялись сосать, пытаясь взять сразу два члена в рот одновременно.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> со вздохом кончил и отошел в сторону.'
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Сосать дальше':dynamic $hantersgroupOiend
}
$hantersgroupORALas = {
	*clr & cla
	minut += 5
	pose = 0
	horny += rand(10,20)
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupORALsi1.'+rand(0,3),'Вы принялись сосать, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел в сторону с блаженной улыбкой на лице.'
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Стать на четвереньки':dynamic $hantersgroupVas1
	if health > 50 and hantsexa = 1 and hantsexb = 6 :act 'Стать на четвереньки':dynamic $hantersgroupVa
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Стать на четвереньки':dynamic $hantersgroupVs
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Лечь на живот':dynamic $hantersgroupVaOs
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Лечь на живот':dynamic $hantersgroupVOs
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Лечь на живот':dynamic $hantersgroupVaO
	if health > 50 and hantsexa = 3 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsOa
	if health > 50 and hantsexa = 3 and hantsexb <= 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsO
	if health > 50 and hantsexa = 3 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAOa
	if health > 50 and hantsexa = 4:act 'Сосать дальше':dynamic $hantersgroupOsa
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupORALasi = {
	*clr & cla
	minut += 5
	pose = 0
	horny += rand(10,20)
	lubonus += 3
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupBJ3.'+rand(0,8),'Вы принялись сосать, поочередно уделяя внимание каждому члену.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	hantsexa = rand(1,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALasi
		if hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupVias
		if hantsexa = 2 and hantsexb = 3:act 'Сесть сверху':dynamic $hantersgroupVia
		if hantsexa = 2 and hantsexb = 4:act 'Сесть сверху':dynamic $hantersgroupVis
		if hantsexa = 2 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupVi
		if hantsexa = 2 and hantsexb < 3:act 'Сесть сверху':dynamic $hantersgroupVas
		if hantsexa = 3 and hantsexb > 5:act 'Стать раком':dynamic $hantersgroupVaOsHi
		if hantsexa = 3 and hantsexb = 5:act 'Стать раком':dynamic $hantersgroupVaOHi
		if hantsexa = 3 and hantsexb < 5:act 'Стать раком':dynamic $hantersgroupVOsHi
		if hantsexa = 4 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgroupDPasi
		if hantsexa = 4 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupDPas
		if hantsexa = 4 and hantsexb = 6:act 'Сесть сверху':dynamic $hantersgroupDPsi
		if hantsexa = 4 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupDPai
		if hantsexa = 5 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgroupVsOaHi
		if hantsexa = 5 and hantsexb = 5:act 'Лечь на бок':dynamic $hantersgroupVsOHi
		if hantsexa = 5 and hantsexb < 5:act 'Лечь на бок':dynamic $hantersgroupVOaHi
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupVias = {
	*clr & cla
	minut += 5
	pose = 2
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVias3.'+rand(0,4)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой. Андрей и Сергей стали перед вами выставив свои члены перед вашим лицом.'
	if forest_gopsex = 3:'Игорь лёг на землю, потянув вас за собой. Митька и Колямба стали перед вами выставив свои члены перед вашим лицом.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALasi
		if hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupVias
		if hantsexa = 2 and hantsexb = 3:act 'Сесть сверху':dynamic $hantersgroupVia
		if hantsexa = 2 and hantsexb = 4:act 'Сесть сверху':dynamic $hantersgroupVis
		if hantsexa = 2 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupVi
		if hantsexa = 2 and hantsexb < 3:act 'Сесть сверху':dynamic $hantersgroupVas
		if hantsexa = 3 and hantsexb > 5:act 'Стать раком':dynamic $hantersgroupVaOsHi
		if hantsexa = 3 and hantsexb = 5:act 'Стать раком':dynamic $hantersgroupVaOHi
		if hantsexa = 3 and hantsexb < 5:act 'Стать раком':dynamic $hantersgroupVOsHi
		if hantsexa = 4 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgroupDPasi
		if hantsexa = 4 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupDPas
		if hantsexa = 4 and hantsexb = 6:act 'Сесть сверху':dynamic $hantersgroupDPsi
		if hantsexa = 4 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupDPai
		if hantsexa = 5 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgroupVsOaHi
		if hantsexa = 5 and hantsexb = 5:act 'Лечь на бок':dynamic $hantersgroupVsOHi
		if hantsexa = 5 and hantsexb < 5:act 'Лечь на бок':dynamic $hantersgroupVOaHi
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupVas = {
	*clr & cla
	minut += 5
	pose = 2
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVas.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой. Андрей и Сергей стали перед вами выставив свои члены перед вашим лицом'
	if forest_gopsex = 3:'Игорь лёг на землю, потянув вас за собой. Митька и Колямба стали перед вами выставив свои члены перед вашим лицом.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Стать на четвереньки':dynamic $hantersgroupVas1
	if health > 50 and hantsexa = 1 and hantsexb = 6 :act 'Стать на четвереньки':dynamic $hantersgroupVa
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Стать на четвереньки':dynamic $hantersgroupVs
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Лечь на живот':dynamic $hantersgroupVaOs
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Лечь на живот':dynamic $hantersgroupVOs
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Лечь на живот':dynamic $hantersgroupVaO
	if health > 50 and hantsexa = 3 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsOa
	if health > 50 and hantsexa = 3 and hantsexb <= 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsO
	if health > 50 and hantsexa = 3 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAOa
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsa
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVas1 = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVas1.'+rand(0,4)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей поставил вас на четвереньки и начал пристраиваться сзади, Сергей подошел спереди...'
	if forest_gopsex = 3:'Митька поставил вас на четвереньки и начал пристраиваться сзади, Колямба подошел спереди...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Стать на четвереньки':dynamic $hantersgroupVas1
	if health > 50 and hantsexa = 1 and hantsexb = 6 :act 'Стать на четвереньки':dynamic $hantersgroupVa
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Стать на четвереньки':dynamic $hantersgroupVs
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Лечь на живот':dynamic $hantersgroupVaOs
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Лечь на живот':dynamic $hantersgroupVOs
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Лечь на живот':dynamic $hantersgroupVaO
	if health > 50 and hantsexa = 3 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsOa
	if health > 50 and hantsexa = 3 and hantsexb <= 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsO
	if health > 50 and hantsexa = 3 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAOa
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsa
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVa = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVa.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей поставил вас на четвереньки и начал пристраиваться сзади,Сергей подошел спереди...'
	if forest_gopsex = 3:'Митька поставил вас на четвереньки и начал пристраиваться сзади, Колямба подошел спереди...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','<<$boy>> кончил и отошел в сторону.. '
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $hantersgroupORALa1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAa
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVa2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVa2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOaend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVs = {
	*clr & cla
	minut += 5
	pose = 2
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVs.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей поставил вас на четвереньки и начал пристраиваться сзади, Сергей подошел спереди...'
	if forest_gopsex = 3:'Митька поставил вас на четвереньки и начал пристраиваться сзади, Колямба подошел спереди...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','<<$boy>> кончил и отвалил в отдыхать.. '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVi = {
	*clr & cla
	minut += 5
	pose = 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVi.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой. Андрей и Сергей стали перед вами выставив свои члены перед вашим лицом.'
	if forest_gopsex = 3:'Васян лёг на землю, потянув вас за собой. Митка и Колямба стали перед вами выставив свои члены перед вашим лицом.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Спермы оказалось так много, что вы не сумели всю проглотить и стряхнув остатки вам на лицо Андрей с Сергеем довольные отошли в сторону, а вы продолжили скакать на Игоре... '
	if forest_gopsex = 3:'Спермы оказалось так много, что вы не сумели всю проглотить и стряхнув остатки вам на лицо Митька с Колямбой довольные отошли в сторону, а вы продолжили скакать на Васяне... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVis = {
	*clr & cla
	minut += 5
	pose = 2
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVis.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой. Андрей и Сергей стали перед вами выставив свои члены перед вашим лицом.'
	if forest_gopsex = 3:'Васян лёг на землю, потянув вас за собой. Митка и Колямба стали перед вами выставив свои члены перед вашим лицом.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Андрей отошел в сторону, а вы продолжили скакать на Игоре, отсасывая у Сергея... '
	if forest_gopsex = 3:'Удовлетворённый Митька отошел в сторону, а вы продолжили скакать на Васяне, отсасывая у Колямбы... '
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVis1 = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 2
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVis1.'+rand(0,4)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей поставил вас на четвереньки и начал пристраиваться сзади, Игорь поднес член к вашему лицу...'
	if forest_gopsex = 3:'Колямба поставил вас на четвереньки и начал пристраиваться сзади, Васян поднес член к вашему лицу...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVi1 = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVi1.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей поставил вас на четвереньки и начал пристраиваться сзади,Игорь поднес член к вашему лицу...'
	if forest_gopsex = 3:'Колямба поставил вас на четвереньки и начал пристраиваться сзади, Васян поднес член к вашему лицу...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','<<$boy>> кончил и отправился отдыхать в тенек... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVs1 = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVs1.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей поставил вас на четвереньки и начал пристраиваться сзади, Игорь поднес член к вашему лицу...'
	if forest_gopsex = 3:'Колямба поставил вас на четвереньки и начал пристраиваться сзади, Васян поднес член к вашему лицу...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь кончил и отвалил, а вы продолжили с Сергеем... '
	if forest_gopsex = 3:'Васян кончил и отвалил, а вы продолжили с Колямбой... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVia = {
	*clr & cla
	minut += 5
	pose = 2
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVia.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой. Андрей и Сергей стали перед вами, выставив свои члены перед вашим лицом.'
	if forest_gopsex = 3:'Васян лёг на землю, потянув вас за собой. Митька и Колямбой стали перед вами, выставив свои члены перед вашим лицом.'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_funcs', 'cum', 'face'
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Спермы оказалось так много, что вы не сумели всю проглотить и часть размазалась по вашему лицу. Удовлетворённый Сергей отошел в сторону, а вы продолжили скакать на Игоре, отсасывая у Андрея... '
	if forest_gopsex = 3:'Спермы оказалось так много, что вы не сумели всю проглотить и часть размазалась по вашему лицу. Удовлетворённый Колямба отошел в сторону, а вы продолжили скакать на Васяне, отсасывая у Митьки... '
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVia1 = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVia1.'+rand(0,2)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь поставил вас раком и начал пристраиваться сзади, Андрей поднес член к вашему лицу...'
	if forest_gopsex = 3:'Васян поставил вас раком и начал пристраиваться сзади, Митька поднес член к вашему лицу...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVi2 = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVi2.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь поставил вас раком и начал пристраиваться сзади, Андрей поднес член к вашему лицу...'
	if forest_gopsex = 3:'Васян поставил вас раком и начал пристраиваться сзади, Митька поднес член к вашему лицу...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Андрей отошел в сторону, а вы продолжили раскачиваться в такт размеренных движений Игоря... '
	if forest_gopsex = 3:'Удовлетворённый Митька отошел в сторону, а вы продолжили раскачиваться в такт размеренных движений Васяна... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVa1 = {
	*clr & cla
	minut += 5
	pose = 2
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVa1.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь поставил вас раком и начал пристраиваться сзади, Андрей поднес член к вашему лицу...'
	if forest_gopsex = 3:'Васян поставил вас раком и начал пристраиваться сзади, Митька поднес член к вашему лицу...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Игорь отошел в сторону, а вы продолжили с Андреем... '
	if forest_gopsex = 3:'Удовлетворённый Васян отошел в сторону, а вы продолжили с Митькой... '
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $hantersgroupORALa1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAa
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVa2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVa2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOaend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVaOsHi = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVaOsHi1.'+rand(0,3)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей поставил вас на четвереньки и начал пристраиваться сзади,Сергей подошел спереди, а вы в это время взяв в руку член Игоря начали надрачивать его...'
	if forest_gopsex = 3:'Митька поставил вас на четвереньки и начал пристраиваться сзади, Колямба подошел спереди, а вы в это время взяв в руку член Васяна начали надрачивать его...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALasi
		if hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupVias
		if hantsexa = 2 and hantsexb = 3:act 'Сесть сверху':dynamic $hantersgroupVia
		if hantsexa = 2 and hantsexb = 4:act 'Сесть сверху':dynamic $hantersgroupVis
		if hantsexa = 2 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupVi
		if hantsexa = 2 and hantsexb < 3:act 'Сесть сверху':dynamic $hantersgroupVas
		if hantsexa = 3 and hantsexb > 5:act 'Стать раком':dynamic $hantersgroupVaOsHi
		if hantsexa = 3 and hantsexb = 5:act 'Стать раком':dynamic $hantersgroupVaOHi
		if hantsexa = 3 and hantsexb < 5:act 'Стать раком':dynamic $hantersgroupVOsHi
		if hantsexa = 4 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgroupDPasi
		if hantsexa = 4 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupDPas
		if hantsexa = 4 and hantsexb = 6:act 'Сесть сверху':dynamic $hantersgroupDPsi
		if hantsexa = 4 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupDPai
		if hantsexa = 5 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgroupVsOaHi
		if hantsexa = 5 and hantsexb = 5:act 'Лечь на бок':dynamic $hantersgroupVsOHi
		if hantsexa = 5 and hantsexb < 5:act 'Лечь на бок':dynamic $hantersgroupVOaHi
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupVOsHi = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVaOsHi1.2.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей поставил вас на четвереньки и начал пристраиваться сзади,Сергей подошел спереди, а вы в это время взяв в руку член Игоря начали надрачивать его...'
	if forest_gopsex = 3:'Митька поставил вас на четвереньки и начал пристраиваться сзади, Колямба подошел спереди, а вы в это время взяв в руку член Васяна начали надрачивать его...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVaOHi = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVaOHi.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей поставил вас на четвереньки и начал пристраиваться сзади,Сергей подошел спереди, а вы в это время взяв в руку член Игоря начали надрачивать его...'
	if forest_gopsex = 3:'Митька поставил вас на четвереньки и начал пристраиваться сзади, Колямба подошел спереди, а вы в это время взяв в руку член Васяна начали надрачивать его...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Сергей отошел в сторону, а вы продолжили раскачиваться под толками Андрея и дроча Игорю... '
	if forest_gopsex = 3:'Удовлетворённый Колямба отошел в сторону, а вы продолжили раскачиваться под толками Митьки и дроча Васяну... '
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupDPasi = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupDPasi1.'+rand(0,2)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей лёг на землю, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
	if forest_gopsex = 3:'Митька лёг на землю, потянув вас за собой, Васян сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Колямбы...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if hantersexnude = 1 or forest_hantersex = 3:$boy2 = 'Игорь' & silavag = 2 & dick2 = 16
	if forest_gopsex = 3:$boy2 = 'Васян' & silavag = 0 & dick2 = 14
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration',1
	if lubonus = 0:lubonus += 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALasi
		if hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupVias
		if hantsexa = 2 and hantsexb = 3:act 'Сесть сверху':dynamic $hantersgroupVia
		if hantsexa = 2 and hantsexb = 4:act 'Сесть сверху':dynamic $hantersgroupVis
		if hantsexa = 2 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupVi
		if hantsexa = 2 and hantsexb < 3:act 'Сесть сверху':dynamic $hantersgroupVas
		if hantsexa = 3 and hantsexb > 5:act 'Стать раком':dynamic $hantersgroupVaOsHi
		if hantsexa = 3 and hantsexb = 5:act 'Стать раком':dynamic $hantersgroupVaOHi
		if hantsexa = 3 and hantsexb < 5:act 'Стать раком':dynamic $hantersgroupVOsHi
		if hantsexa = 4 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgroupDPasi
		if hantsexa = 4 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupDPas
		if hantsexa = 4 and hantsexb = 6:act 'Сесть сверху':dynamic $hantersgroupDPsi
		if hantsexa = 4 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupDPai
		if hantsexa = 5 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgroupVsOaHi
		if hantsexa = 5 and hantsexb = 5:act 'Лечь на бок':dynamic $hantersgroupVsOHi
		if hantsexa = 5 and hantsexb < 5:act 'Лечь на бок':dynamic $hantersgroupVOaHi
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupDPsi = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupDPai.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей лёг на землю, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
	if forest_gopsex = 3:'Митька лёг на землю, потянув вас за собой, Васян сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Колямбы...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if hantersexnude = 1 or forest_hantersex = 3:$boy2 = 'Игорь' & silavag = 2 & dick2 = 16
	if forest_gopsex = 3:$boy2 = 'Васян' & silavag = 0 & dick2 = 14
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration',1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','<<$boy>> кончил и ушел...'
	if lubonus = 0:lubonus += 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupDPas = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupDPas.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей лёг на землю, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
	if forest_gopsex = 3:'Митька лёг на землю, потянув вас за собой, Васян сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Колямбы...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if hantersexnude = 1 or forest_hantersex = 3:$boy2 = 'Игорь' & silavag = 2 & dick2 = 16
	if forest_gopsex = 3:$boy2 = 'Васян' & silavag = 0 & dick2 = 14
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration',1
	gs 'zz_render','','','Через некоторое время <<$boy2>> застонал и вы почувствовали как вашу попу наполняет тепло. Он кончил и отошел в сторону.'
	lubonus += rand(2,3)
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Стать на четвереньки':dynamic $hantersgroupVas1
	if health > 50 and hantsexa = 1 and hantsexb = 6 :act 'Стать на четвереньки':dynamic $hantersgroupVa
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Стать на четвереньки':dynamic $hantersgroupVs
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Лечь на живот':dynamic $hantersgroupVaOs
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Лечь на живот':dynamic $hantersgroupVOs
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Лечь на живот':dynamic $hantersgroupVaO
	if health > 50 and hantsexa = 3 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsOa
	if health > 50 and hantsexa = 3 and hantsexb <= 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsO
	if health > 50 and hantsexa = 3 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAOa
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsa
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupDPai = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupDPai.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей лёг на землю, потянув вас за собой, Игорь сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Сергея...'
	if forest_gopsex = 3:'Митька лёг на землю, потянув вас за собой, Васян сразу же начал пристраиваться к вашей второй дырочке, вам остается лишь расслабиться и сосать член Колямбы...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if hantersexnude = 1 or forest_hantersex = 3:$boy2 = 'Игорь' & silavag = 2 & dick2 = 16
	if forest_gopsex = 3:$boy2 = 'Васян' & silavag = 0 & dick2 = 14
	if boyAsex = 0: boyAsex = 1 & sex += 1
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration',1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Сергей отошел в сторону, а Андрей с Игорем продолжили вас драть... '
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Колямба отошел в сторону, а Митька с Васяном продолжили вас драть... '
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVsOaHi = {
	*clr & cla
	minut += 5
	pose = 0
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVsOaHi1.'+rand(0,1)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей положил вас на бок и вы уткнулись лицом в член Андрея...'
	if forest_gopsex = 3:'Колямба положил вас на бок и вы уткнулись лицом в член Митьки...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:'Протянув руку вверх вы нащупали член Игоря и начали его дрочить...'
	if forest_gopsex = 3:'Протянув руку вверх вы нащупали член Васяна и начали его дрочить...'
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50:
		if hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALasi
		if hantsexa = 2 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupVias
		if hantsexa = 2 and hantsexb = 3:act 'Сесть сверху':dynamic $hantersgroupVia
		if hantsexa = 2 and hantsexb = 4:act 'Сесть сверху':dynamic $hantersgroupVis
		if hantsexa = 2 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupVi
		if hantsexa = 2 and hantsexb < 3:act 'Сесть сверху':dynamic $hantersgroupVas
		if hantsexa = 3 and hantsexb > 5:act 'Стать раком':dynamic $hantersgroupVaOsHi
		if hantsexa = 3 and hantsexb = 5:act 'Стать раком':dynamic $hantersgroupVaOHi
		if hantsexa = 3 and hantsexb < 5:act 'Стать раком':dynamic $hantersgroupVOsHi
		if hantsexa = 4 and hantsexb < 5:act 'Сесть сверху':dynamic $hantersgroupDPasi
		if hantsexa = 4 and hantsexb > 5:act 'Сесть сверху':dynamic $hantersgroupDPas
		if hantsexa = 4 and hantsexb = 6:act 'Сесть сверху':dynamic $hantersgroupDPsi
		if hantsexa = 4 and hantsexb = 5:act 'Сесть сверху':dynamic $hantersgroupDPai
		if hantsexa = 5 and hantsexb > 5:act 'Лечь на бок':dynamic $hantersgroupVsOaHi
		if hantsexa = 5 and hantsexb = 5:act 'Лечь на бок':dynamic $hantersgroupVsOHi
		if hantsexa = 5 and hantsexb < 5:act 'Лечь на бок':dynamic $hantersgroupVOaHi
	else
		act 'Потерять сознание':dynamic $hantersgroupfaint
	end
}
$hantersgroupVsOHi = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVsOaHi1.'+rand(0,1)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей положил вас на бок и вы уткнулись лицом в член Андрея. Протянув руку вверх вы нащупали член Игоря и начали его дрочить..'
	if forest_gopsex = 3:'Колямба положил вас на бок и вы уткнулись лицом в член Митьки. Протянув руку вверх вы нащупали член Васяна и начали его дрочить..'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Андрей отошел в сторону, а вы продолжили с Сергеем и Игорем... '
	if forest_gopsex = 3:'Удовлетворённый Митька отошел в сторону, а вы продолжили с Колямбой и Васяном... '
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVsOi = {
	*clr & cla
	minut += 5
	pose = 0
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVsOi1.'+rand(0,2)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей положил вас на бок, а Игорь поднес член к вашим губам...'
	if forest_gopsex = 3:'Колямба положил вас на бок, а Васян поднес член к вашим губам...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVOi = {
	*clr & cla
	minut += 5
	pose = 0
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVOi.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей положил вас на бок, а Игорь поднес член к вашим губам...'
	if forest_gopsex = 3:'Колямба положил вас на бок, а Васян поднес член к вашим губам...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVsO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVsO.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей положил вас на бок, а Игорь поднес член к вашим губам...'
	if forest_gopsex = 3:'Колямба положил вас на бок, а Васян поднес член к вашим губам...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Игорь отошел в сторону, а вы продолжили с Сергеем... '
	if forest_gopsex = 3:'Удовлетворённый Васян отошел в сторону, а вы продолжили с Колямбой... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVOaHi = {
	*clr & cla
	minut += 5
	pose = 0
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVsOaHi1.'+rand(0,1)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей положил вас на бок и вы уткнулись лицом в член Андрея. Протянув руку вверх вы нащупали член Игоря и начали его дрочить..'
	if forest_gopsex = 3:'Колямба положил вас на бок и вы уткнулись лицом в член Митьки. Протянув руку вверх вы нащупали член Васяна и начали его дрочить..'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupViOa = {
	*clr & cla
	minut += 5
	pose = 0
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupViOa1.'+rand(0,1)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь положил вас на бок и вы уткнулись лицом в член Андрея...'
	if forest_gopsex = 3:'Васян положил вас на бок и вы уткнулись лицом в член Митьки...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupViO = {
	*clr & cla
	minut += 5
	pose = 0
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupViO.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь положил вас на бок и вы уткнулись лицом в член Андрея...'
	if forest_gopsex = 3:'Васян положил вас на бок и вы уткнулись лицом в член Митьки...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	gs 'zz_render','','','Удовлетворённый <<$boy>> отошел в сторону, а вы продолжили со вторым парнем... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVaOs = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVaOs1.'+rand(0,3)+'.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей положил вас на живот и растянул ваши руки, а Сергей поднес член к вашим губам...'
	if forest_gopsex = 3:'Митька положил вас на живот и растянул ваши руки, а Колямба поднес член к вашим губам...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Стать на четвереньки':dynamic $hantersgroupVas1
	if health > 50 and hantsexa = 1 and hantsexb = 6 :act 'Стать на четвереньки':dynamic $hantersgroupVa
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Стать на четвереньки':dynamic $hantersgroupVs
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Лечь на живот':dynamic $hantersgroupVaOs
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Лечь на живот':dynamic $hantersgroupVOs
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Лечь на живот':dynamic $hantersgroupVaO
	if health > 50 and hantsexa = 3 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsOa
	if health > 50 and hantsexa = 3 and hantsexb <= 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsO
	if health > 50 and hantsexa = 3 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAOa
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsa
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVOs = {
	*clr & cla
	minut += 5
	pose = 1
	if lubonus = 0:lubonus += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVOs.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей положил вас на живот и растянул ваши руки, а Сергей поднес член к вашим губам...'
	if forest_gopsex = 3:'Митька положил вас на живот и растянул ваши руки, а Колямба поднес член к вашим губам...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVaO = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVaO.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Андрей положил вас на живот и растянул ваши руки, а Сергей поднес член к вашим губам...'
	if forest_gopsex = 3:'Митька положил вас на живот и растянул ваши руки, а Колямба поднес член к вашим губам...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Сергей отошел в сторону, а Андрей продолжил вас драть... '
	if forest_gopsex = 3:'Удовлетворённый Колямба отошел в сторону, а Андрей продолжил вас драть... '
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $hantersgroupORALa1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAa
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVa2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVa2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOaend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupAsOa = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAsOa.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей поставил вас на четвереньки и начал пристраиваться сзади, Андрей подошел спереди ...'
	if forest_gopsex = 3:'Колямба поставил вас на четвереньки и начал пристраиваться сзади, Митька подошел спереди ...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Стать на четвереньки':dynamic $hantersgroupVas1
	if health > 50 and hantsexa = 1 and hantsexb = 6 :act 'Стать на четвереньки':dynamic $hantersgroupVa
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Стать на четвереньки':dynamic $hantersgroupVs
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Лечь на живот':dynamic $hantersgroupVaOs
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Лечь на живот':dynamic $hantersgroupVOs
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Лечь на живот':dynamic $hantersgroupVaO
	if health > 50 and hantsexa = 3 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsOa
	if health > 50 and hantsexa = 3 and hantsexb <= 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsO
	if health > 50 and hantsexa = 3 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAOa
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsa
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupAsO = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAsO.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей поставил вас на четвереньки и начал пристраиваться сзади,Андрей подошел спереди ...'
	if forest_gopsex = 3:'Колямба поставил вас на четвереньки и начал пристраиваться сзади, Митька подошел спереди ...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'swallow'
	if hantersexnude = 1 or forest_hantersex = 3:'Удовлетворённый Андрей отошел в сторону, а Сергей продолжил натягивать ваш зад... '
	if forest_gopsex = 3:'Удовлетворённый Митька отошел в сторону, а Колямба продолжил натягивать ваш зад... '
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupAOa = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAOa.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Сергей поставил вас на четвереньки и начал пристраиваться сзади,Андрей подошел спереди ...'
	if forest_gopsex = 3:'Колямба поставил вас на четвереньки и начал пристраиваться сзади, Митька подошел спереди ...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_dynamic_sex', 'bj'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	lubonus += rand(2,3)
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $hantersgroupORALa1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAa
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVa2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVa2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOaend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupDPis = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupDPis.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой, Сергей сразу же начал пристраиватться к вашей второй дырочке...'
	if forest_gopsex = 3:'Васян лёг на землю, потянув вас за собой, Колямба сразу же начал пристраиватться к вашей второй дырочке...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if hantersexnude = 1 or forest_hantersex = 3:$boy2 = 'Сергей' & silavag = 1 & dick2 = 18
	if forest_gopsex = 3:$boy2 = 'Колямба' & silavag = 0 & dick2 = 15
	if boyCsex = 0: boyCsex = 1 & sex += 1
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration',1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb < 6 :act 'Сосать дальше':dynamic $hantersgroupORALsi1
	if health > 50 and hantsexa = 1 and hantsexb = 6:act 'Сосать дальше':dynamic $hantersgroupORALs
	if health > 50 and hantsexa = 1 and hantsexb = 7:act 'Сосать дальше':dynamic $hantersgroupORALi
	if health > 50 and hantsexa = 1 and hantsexb = 8:act 'Сосать дальше':dynamic $hantersgroupORALend1
	if health > 50 and hantsexa = 2 and hantsexb <= 5:act 'Стать на четвереньки':dynamic $hantersgroupVis1
	if health > 50 and hantsexa = 2 and hantsexb > 6:act 'Стать на четвереньки':dynamic $hantersgroupVi1
	if health > 50 and hantsexa = 2 and hantsexb = 6:act 'Стать на четвереньки':dynamic $hantersgroupVs1
	if health > 50 and hantsexa = 3 and hantsexb <= 5:act 'Лечь на бок':dynamic $hantersgroupVsOi
	if health > 50 and hantsexa = 3 and hantsexb > 6:act 'Лечь на бок':dynamic $hantersgroupVOi
	if health > 50 and hantsexa = 3 and hantsexb = 6:act 'Лечь на бок':dynamic $hantersgroupVsO
	if health > 50 and hantsexa = 4:act 'Сесть сверху':dynamic $hantersgroupDPis
	if health > 50 and hantsexa = 5:act 'Стать на колени':dynamic $hantersgroupOis
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupDPia = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupDPia.jpg'
	if hantersexnude = 1 or forest_hantersex = 3:'Игорь лёг на землю, потянув вас за собой, Андрей сразу же начал пристраиватться к вашей второй дырочке...'
	if forest_gopsex = 3:'Васян лёг на землю, потянув вас за собой, Митька сразу же начал пристраиватться к вашей второй дырочке...'
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if hantersexnude = 1 or forest_hantersex = 3:$boy2 = 'Андрей' & silavag = 0 & dick2 = 20
	if forest_gopsex = 3:$boy2 = 'Митька' & silavag = 0 & dick2 = 16
	if boyCsex = 0: boyCsex = 1 & sex += 1
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	gs 'zz_dynamic_sex', 'dp_start', 1
	gs 'zz_dynamic_sex', 'double_penetration',1
	hantsexa = rand(2,5)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 6 :act 'Сосать дальше':dynamic $hantersgroupORALai1
	if health > 50 and hantsexa = 1 and hantsexb > 6 :act 'Сосать дальше':dynamic $hantersgroupORALi1
	if health > 50 and hantsexa = 2 and hantsexb < 6 :act 'Стать раком':dynamic $hantersgroupVia1
	if health > 50 and hantsexa = 2 and hantsexb = 6 :act 'Стать раком':dynamic $hantersgroupVi2
	if health > 50 and hantsexa = 2 and hantsexb > 6 :act 'Стать раком':dynamic $hantersgroupVa1
	if health > 50 and hantsexa = 3 and hantsexb <= 6 :act 'Лечь на бок':dynamic $hantersgroupViOa
	if health > 50 and hantsexa = 3 and hantsexb > 6 :act 'Лечь на бок':dynamic $hantersgroupViO
	if health > 50 and hantsexa = 4 :act 'Сесть сверху':dynamic $hantersgroupDPia
	if health > 50 and hantsexa = 5 :act 'Стать на колени':dynamic $hantersgroupOia
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupOis = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupO1.'+rand(0,1),'Парни поставили вас на колени и принялись дрочить перед вашим лицом пока струи спермы ударили вам в лицо. Кончив они отошли в сторону, а вы остались на покрывале обтекать.'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupOia = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'zz_funcs', 'cum', 'face'
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupO1.'+rand(0,1),'Парни поставили вас на колени и принялись дрочить перед вашим лицом пока струи спермы ударили вам в лицо. Обкончав вас они отошли в сторону, а вы остались сидеть на покрывале переводить дух.'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupOsa = {
	*clr & cla
	minut += 5
	pose = 1
	gs 'zz_funcs', 'cum', 'face'
	if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
	if cloth[0] > 2:cumfrot += rand(0,1)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupO1.'+rand(0,1)+'.jpg'
	gs 'zz_render','','','Парни поставили вас на колени и принялись дрочить. Вскоре струи спермы ударили вам в лицо, она стекала по подбородку, капая вниз. Кончив они отошли в сторону, а вы остались сидеть на покрывале.'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupAa = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersgroupA1.'+rand(0,4),'<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $hantersgroupORALa1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAa
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVa2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVa2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOaend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupAaEnd1 = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAEnd1.jpg','<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupAaEnd2 = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsexa = 0: boyAsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAaEnd2.jpg','<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','Через некоторое время <<$boy>> застонал и вы почувствовали как член покинул вашу попу и следом на неё брызнули струи спермы. <<$boy>> отошел в сторону оставив вас одну на покрывале...'
	gs 'zz_funcs', 'cum', 'ass'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupAs = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupA1.'+rand(0,4),'<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupAsEnd1 = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAEnd1.jpg','<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupAsEnd2 = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsexa = 0: boyBsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAEnd2.jpg','<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','Через некоторое время <<$boy>> застонал и вы почувствовали как член покинул вашу попу и следом на неё брызнули струи спермы. <<$boy>> отошел в сторону оставив вас одну на покрывале...'
	gs 'zz_funcs', 'cum', 'ass'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupAi = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupA1.'+rand(0,4),'<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupAiEnd1 = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAEnd1.jpg','<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_dynamic_sex', 'anal_cum'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupAiEnd2 = {
	*clr & cla
	minut += 5
	pose = 1
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsexa = 0: boyCsexa = 1 & anal += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupAEnd2.jpg','<<$boy>> поставил вас на четвереньки и начал пристраиваться к вашей попе...'
	gs 'zz_dynamic_sex', 'anal_start', 'dick'
	gs 'zz_dynamic_sex', 'anal', 'dick', 1
	gs 'zz_render','','','Через некоторое время <<$boy>> застонал и вы почувствовали как член покинул вашу попу и следом на неё брызнули струи спермы. <<$boy>> отошел в сторону оставив вас одну на покрывале...'
	gs 'zz_funcs', 'cum', 'ass'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupVa2 = {
	*clr & cla
	minut += 5
	pose = 2
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupV0.'+rand(0,1),'<<$boy>> лег на землю и потянул вас за собой...'
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(1,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать':dynamic $hantersgroupORALa1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAa
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAaEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVa2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVa2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOaend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVa2end = {
	*clr & cla
	minut += 5
	pose = 2
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVend.jpg','<<$boy>> лег на землю и потянул вас за собой...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','<<$boy>> отошел в сторону оставив вас одну на покрывале...'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupVs2 = {
	*clr & cla
	minut += 5
	pose = 2
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupV0.'+rand(0,1),'<<$boy>> лег на землю и потянул вас за собой...'
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1 and hantsexb <= 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1
	if health > 50 and hantsexa = 1 and hantsexb > 4 :act 'Сосать дальше':dynamic $hantersgroupORALs1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAs
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAsEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVs2
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVs2end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOsend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVs2end = {
	*clr & cla
	minut += 5
	pose = 2
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	if boyBsex = 0: boyBsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVend.jpg','<<$boy>> лег на землю и потянул вас за собой...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','<<$boy>> отошел в сторону оставив вас одну на покрывале...'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupVi3 = {
	*clr & cla
	minut += 5
	pose = 2
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupV0.'+rand(0,1),'<<$boy>> лег на землю и потянул вас за собой...'
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,4)
	hantsexb = rand(1,8)
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hantersgroupORALi1end
	if health > 50 and hantsexa = 2 and hantsexb = 5 :act 'Стать на четвереньки':dynamic $hantersgroupAi
	if health > 50 and hantsexa = 2 and hantsexb < 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd1
	if health > 50 and hantsexa = 2 and hantsexb > 5 :act 'Стать на четвереньки':dynamic $hantersgroupAiEnd2
	if health > 50 and hantsexa = 3 and hantsexb <= 3 :act 'Сесть сверху':dynamic $hantersgroupVi3
	if health > 50 and hantsexa = 3 and hantsexb > 3 :act 'Сесть сверху':dynamic $hantersgroupVi3end
	if health > 50 and hantsexa = 4:act 'Стать на колени':dynamic $hantersgroupOiend
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hantersgroupVi3end = {
	*clr & cla
	minut += 5
	pose = 2
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	if boyCsex = 0: boyCsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupVend.jpg','<<$boy>> лег на землю и потянул вас за собой...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	gs 'zz_dynamic_sex', 'sex_cum'
	gs 'zz_render','','','<<$boy>> отошел в сторону оставив вас одну на покрывале...'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupOsend = {
	*clr & cla
	pose = 0
	minut += 5
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Сергей' & silavag = 1 & dick = 18
	if forest_gopsex = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
	gs 'zz_funcs', 'cum', 'face'
	if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
	if cloth[0] > 2:cumfrot += rand(0,1)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupOend1.'+rand(0,2),'<<$boy>> поставил вас на колени и поднес член к лицу...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','Вы почувствовали как <<$boy>> напрягся и тут же вытащил член из вашего рта. Горячая струя спермы ударяет вас по лицу, потом еще одна струя и еще. Она стекает по подбородку, капая вниз, а <<$boy>> убрал член в штаны и отошел в сторону.'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupOaend = {
	*clr & cla
	pose = 0
	minut += 5
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Андрей' & silavag = 0 & dick = 20
	if forest_gopsex = 3:$boy = 'Митька' & silavag = 0 & dick = 16
	gs 'zz_funcs', 'cum', 'face'
	if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
	if cloth[0] > 2:cumfrot += rand(0,1)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupOend1.'+rand(0,2),'<<$boy>> поставил вас на колени и поднес член к лицу...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','Вы почувствовали как <<$boy>> напрягся и тут же вытащил член из вашего рта. Горячая струя спермы ударяет вас по лицу, потом еще одна струя и еще. Она стекает по подбородку, капая вниз, а <<$boy>> убрал член в штаны и отошел в сторону.'
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hantersgroupOiend = {
	*clr & cla
	pose = 0
	minut += 5
	if hantersexnude = 1 or forest_hantersex = 3:$boy = 'Игорь' & silavag = 2 & dick = 16
	if forest_gopsex = 3:$boy = 'Васян' & silavag = 0 & dick = 14
	gs 'zz_funcs', 'cum', 'face'
	if cloth[0] = 0:gs 'zz_funcs', 'cum', 'belly'
	if cloth[0] > 2:cumfrot += rand(0,1)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hantersgroupOend1.'+rand(0,2),'<<$boy>> поставил вас на колени и поднес член к лицу...'
	gs 'zz_dynamic_sex', 'bj'
	gs 'zz_render','','','Вы почувствовали как <<$boy>> напрягся и тут же вытащил член из вашего рта. Горячая струя спермы ударяла вас по лицу, потом еще одна струя и еще. Она стекает по подбородку, капая вниз, а <<$boy>> убрал член в штаны и отошел в сторону. '
	if forest_hantersex = 0:act 'Далее':hantersexnude = 0 & forest_gopsex = 0 & gt $loc, $metka
	if forest_hantersex > 0:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
}
$hanterslutSTART = {
	*clr & cla
	pose = 0
	minut += 5
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	horny += rand(5,10)
	temp = rand(1,2)
	gs 'stat'
	if temp = 1:
		gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutSTART1.jpg','Вы опустились на корточки, взяли член в руки, поднесли к губам и поцеловав головку принялись...'
	else
		gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutSTART2.jpg','Вы опустились на корточки, взяли член в руки, поднесли к губам и облизав головку принялись...'
	end
	act 'Сосать ':dynamic $hanterslutORAL
}
$hanterslutEND = {
	*clr & cla
	pose = 0
	minut += 5
	horny += rand(5,10)
	temp = rand(1,2)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutEND1.jpg'
	if protect = 1:'<<$boy>> выкинув использованый презерватив, посадил вас перед собой на корточки. Вы, подразнивая и облизывая головку члена языком, принялись дрочить... '
	if protect = 0:'Вы опустились на колени. Взяв член в руку, вы принялись дрочить, подразнивая и облизывая головку члена языком...'
	act 'Дрочить':
		*clr & cla
		minut += 5
		hj += 1
		protect = 0
		hantsex = 0
		gs 'zz_funcs', 'cum', 'face'
		gs 'zz_funcs', 'cum', 'belly'
		gs 'stat'
		gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutEND2.'+rand(1,2)+'.jpg'
		gs 'zz_dynamic_sex', 'swallow'
		gs 'zz_render','','','Спермы оказалось слишком много. Она стекает по подбородку, капая вниз и пачкая вашу грудь и живот. <<$boy>> убрал член в штаны и пошел по своим делам, оставив вас одну, приводить себя в порядок.'
		if slutgosex = 1:act 'Далее':slutgosex = 0 & gt 'backwater'
		if forest_hantersex = 1:act 'Далее':forest_hantersex = 0 & minut += 60 & gt 'swamp_yard'
		if forest_gopsex = 1:act 'Далее':forest_gopsex = 0 & gt 'gadforest','1'
	end
}
$hanterslutORAL = {
	*clr & cla
	pose = 0
	minut += 5
	bj += 1
	horny += rand(5,10)
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutORAL1.'+rand(1,2)+'.jpg'
	gs 'zz_render','','','Вы стоя на корточках, взяли член в руку и поднесли его к губам...'
	gs 'zz_dynamic_sex', 'bj'
	hantsexa = rand(1,10)
	if health > 50 and hantsexa <= 7:'Прервав вас, парень говорит...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево и поднять ногу':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanterslutCOW = {
	*clr & cla
	minut += 5
	pose = 0
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutCOW1.'+rand(1,4)+'.jpg'
	gs 'zz_render','','','<<$boy>> лёг на землю, потянув вас за собой.'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	if health > 50 and hantsexa <= 7:'Вдоволь насладившись в этой позе <<$boy>> говорит вам...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanterslutHANDS = {
	*clr & cla
	minut += 5
	pose = 0
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutHANDS1.'+rand(1,2),'<<$boy>> взял вас в свои крепкие руки и резко вошел в вас..'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	if health > 50 and hantsexa <= 7:'Вдоволь насладившись в этой позе <<$boy>> говорит вам...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanterslutTREE = {
	*clr & cla
	minut += 5
	pose = 1
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutTREE1.'+rand(1,3),'Вы повернулись к дереву и оперлись о него рукой, <<$boy>> пристроился сзади ...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	if health > 50 and hantsexa <= 7:'Вдоволь насладившись в этой позе <<$boy>> говорит вам...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanterslutTREELEG = {
	*clr & cla
	minut += 5
	pose = 1
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutTREELEG1.'+rand(1,4),'Вы повернулись к дереву и оперлись о него рукой, <<$boy>> приподнял вашу ногу для удобства и вошел в вас...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	if health > 50 and hantsexa <= 7:'Вдоволь насладившись в этой позе <<$boy>> говорит вам...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanterslutLEG1 = {
	*clr & cla
	minut += 5
	pose = 1
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutLEG1.'+rand(1,2),'Вы повернулись задом к парню и обняли его за шею, <<$boy>> приподнял вашу ногу для удобства и вошел в вас...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	if health > 50 and hantsexa <= 7:'Вдоволь насладившись в этой позе <<$boy>> говорит вам...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanterslutLEG2 = {
	*clr & cla
	minut += 5
	pose = 1
	if boyAsex = 0: boyAsex = 1 & sex += 1
	gs 'stat'
	gs 'zz_render','','images/qwest/gadukino/hantersex/hanterslutLEG2.'+rand(1,2),'Вы, стоя на ногах, повернулись к парню лицом и обняли его за шею, <<$boy>> приподнял вашу ногу для удобства и вошел в вас ...'
	gs 'zz_dynamic_sex', 'sex_start', 1
	gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
	hantsexa = rand(2,10)
	if health > 50 and hantsexa <= 7:'Вдоволь насладившись в этой позе <<$boy>> говорит вам...'
	if health > 50 and hantsexa > 7:'Внезапно <<$boy>> начал двигаться быстрее и вы поняли что он уже на грани и готов кончить.'
	if health > 50 and hantsexa = 1:act 'Сосать дальше':dynamic $hanterslutORAL
	if health > 50 and hantsexa = 2:act 'Сесть сверху':dynamic $hanterslutCOW
	if health > 50 and hantsexa = 3:act 'Запрыгнуть на руки':dynamic $hanterslutHANDS
	if health > 50 and hantsexa = 4:act 'Опереться на дерево':dynamic $hanterslutTREE
	if health > 50 and hantsexa = 5:act 'Опереться на дерево':dynamic $hanterslutTREELEG
	if health > 50 and hantsexa = 6:act 'Повернуться спиной':dynamic $hanterslutLEG1
	if health > 50 and hantsexa = 7:act 'Повернуться лицом':dynamic $hanterslutLEG2
	if health > 50 and hantsexa > 7:act 'Стать на колени':dynamic $hanterslutEND
	if health <= 50:act 'Потерять сознание':dynamic $hantersgroupfaint
}
$hanters_talk = {
	temp = rand(1,35)
	if temp = 1:
	gs 'zz_render','','','— Какая разница между собакой и лисицей? — 2 стакана водки!'
	elseif temp = 2:
	gs 'zz_render','','','Такса – это такая охотничья собака примерно половина собаки в высоту и полтора в длину.'
	elseif temp = 3:
	gs 'zz_render','','','Пошли мы как-то на охоту. Все взяли: ружья, патроны, собаку, соленые огурцы. А водку забыли. Пришлось возвращаться.'
	elseif temp = 4:
	gs 'zz_render','','','Собрались мужики на охоту, да вот беда, одного жена не пускает, мол, знаю я вашу охоту, нажрётесь как свиньи и на бровях домой приползёте... Вот, мол, возьмёте с собой, тогда можно. Посовещались мужики и решили взять - что-нибудь по ходу придумают..
Приехали в лес, нашли полянку подходящую, дали жене двустволку и говорят:
- Ты тут в кустах сиди, а мы пойдём лося загонять. Будем гнать прямо на тебя, а ты смотри не промахнись, а то весь труд на смарку пойдёт...
Оставили её, а сами в свой шалашик потопали водку кушать. Очнулись, когда уже луна светила... Муж схватился за голову, мол что с ним жена сделает и решили пойти сдаваться.
Пришли на поляну и видят такую картину: в центре лужайки лежит туша, вокруг неё с ружьём на плече вышагивает женщина, а рядом стоит незнакомый мужичок, потирает лысину.
- Это мой лось, это я его убила!!!
- Да твой это лось, твой. Дай только седло сниму.'
	elseif temp = 5:
	gs 'zz_render','','','Слyжил в кpаях далёких, на подводной лодке командиp, котоpый очень любил постpелять. Даже в дальние походы с собой винтовкy бpал. Hy мало ли, y беpега всплывyт, так какyю дичь заметит с капитанского мостика, так всё пpистpелить ноpовит. Видать, папа y него был сибиpский охотник, белке в глаз бил без пpомаха. Hадо сказать, что капитан этот стpелял тоже неплохо. Так вот, всплыли они как-то y скалистого pодного беpега, не знаю yж по какой пpичине, только заметил вдpyг капитан со своего мостика, что на yтёсе олень стоит, да так кpасиво, гоpдый такой, одинокий, на фоне хмypого севеpного неба. Пpинесли кэпy винтовкy, он тщательно пpицелился, все свободные от вахты сбежались посмотpеть на это пpедставление, ставки делать стали, попадёт или нет...Раздаётся выстpел, олень как подкошенный падает с обpыва в водy, за ним следом летят наpты с чyкчей... Коpоткая немая сцена... Сpочное погpyжение!!!!!!!'
	elseif temp = 6:
	gs 'zz_render','','','Приехал депутат на охоту на медведя. Джип - хамер, камуфляж, супер навороченный автомат с оптическим прицелом ночного виденья... Заходит в лес, навстречу мужичок в лаптях, в ушанке, в телогрейке - типичный деревенский мужик.
Мужик: - О, мил человек, куда путь держишь?
Депутат: - На медведя!
Мужик: - Да неблагодарное это занятие... Медведь - ХОЗЯИН! На него мой дед с рогатиной ходил, отец с рогатиной ходил...
Депутат: - Да ты смотри! Автомат - хоть слона вали... Оптика, пули со стальным сердечником...
И уходит в лес.
Мужик:- Да, (затягивается махоркой) теперь в лес вообще не стоит ходить... У медведя теперь не только две рогатины, а и автомат еще будет...'
	elseif temp = 7:
	gs 'zz_render','','','После выстрела по дичи охотник просит напарника:
- Сходи, посмотри, что за зверя я уложил.
Тот возвращается:
- Судя по паспорту, его фамилия Иванов.'
	elseif temp = 8:
	gs 'zz_render','','','Стоят два гриба в лесу - Белый и Мухомор.
Видят грибника.
Белый - Все, сейчас резня начнется!!!
Мухомор - Не знаю, как на счет резни, но по шапке сапогом точно кто-то получит!'
	elseif temp = 9:
	gs 'zz_render','','','Охотники:
- В Антарктиде я одним выстрелом убил кита.
- А я на Северном полюсе своими руками задушил медведя.
- А ты когда-нибудь слышал о Мертвом море?
- Кто же не слышал?
- Так это я его...'
	elseif temp = 10:
	gs 'zz_render','','','Выхожу я как из дому. Смотрю прям на моем телефонном столбе
Орел сидит. Ну я вскидываю ружье, целюсь, Бах-Бах, Ба-Бах.
Попал. Со столба. Когти в одну сторону, плоскогубцы и пасатижи в
другую.'
	elseif temp = 11:
	gs 'zz_render','','','Если во время охоты вы ни в кого не попали, значит, в лесу стало одним
косым больше.'
	elseif temp = 12:
	horny +=rand(5,20)
	gs 'zz_render','','','Встретились три охотника и обсуждают достоинства своих собак.
Первый:
- Пошел я один раз на охоту - ружье взял, а патроны забыл. Дал
собаке понюхать ружье - она патроны принесла!
Второй:
- Пошел я один раз на охоту - патроны взял, а ружье забыл. Дал
собаке понюхать патроны - она ружье принесла!!
Третий:
- А я как-то пошел с женой купаться, а она купальник забыла. Дал
собаке у жены промеж ног понюхать - она соседа за яйца притащила!!!'
	elseif temp = 13:
	gs 'zz_render','','','Мужик возражается с охоты довольный. Жена:
- Как охота?
- Класс! Ежей целую гору настрелял!
- Ты что совсем ебнулся? На хуй они нужны!
- Ну как же. Тебе на воротник, теще на стельки.'
	elseif temp = 14:
	gs 'zz_render','','','Встречаются два зайца. Один белый и пушистый, а второй перебинтован от лапок до ушей. Первый спрашивает:
- На охоте?
- На охоте..,- отвечает второй.
- Охотник?
- Охотник.
- Подстрелил?!
- Не... наступил.'
	elseif temp = 15:
	gs 'zz_render','','','Мужик возвращается с охоты домой. И заявляет приятелю:
- Ну все теперь целый месяц жена не будет покупать мясо!
- Что так много настелял?
- Нет, только пропил всю зарплату.'
	elseif temp = 16:
	horny +=rand(5,20)
	gs 'zz_render','','','Гонится, значит, охотник за медведем. Медведь хоть и здоровый
был, но бегал быстро и охотник отстал. А медведь-то и бегал,
пока между двух деревьев и застрял. А мимо заяц пробегал и
спрашивает у медведя:
- Ты что здесь делаешь?
Ну, тот зайцу все рассказал, а заяц взял и выебал медведя в жопу. Медведь расстроился, а выбраться не смог.
Тут он увидел пробегающего лиса и подзывает его:
- Лис, помоги, так мол так!
Лис подумал и тоже, как заяц, его и выебал. Медведь уже совсем отчаялся, когда увидел волка. Волк подходит и спрашивает:
- Что случилось?
Медведь:
- Ну ладно, волк, еби, потом расскажу!!'
	elseif temp = 17:
	horny +=rand(5,20)
	gs 'zz_render','','','Мужики пошли на охоту. Как водится напились. Пошли стрелять зверьё. И вдрцуг откуда ни возьмись медведь. Загнал одного охотника на дерево. Тот кричит:
- Мужики, спасите! Убейте медведя.
Товарищ пьяный, целится, качается, промахивается, отстреливает медведю одно яйцо. Медведь лезет дальше. Мужик орёт:
- Мужики, спасите скорее! Убейте этого гада медведя.
Опять товарищ пьяный, целится, качается, промахивается, отстреливает медведю другое яйцо. Мужик на дереве орёт:
- Ну что вы, гады, делаете! Он же меня не ебать лезет!'
	elseif temp = 18:
	horny +=rand(5,20)
	gs 'zz_render','','','Короче сидят три охотника как в той картине и о своих подвигах разговаривают. Ну один говорит:
- Я такого зайца вчера завалил, кое-как до дому донес.
Второй:
- Фигня, это я такого глухаря завалил, что поднять не смог.
Третий:
- Я один раз такого лося завалил тяжелый собака! Отрезал ляжки, закинул на плечи...
Тут один из охотников говорит:
- Слушай, давай пропустим по одной, потом доскажешь.
Ну вмазали. Третий:
- Ну так на чем я остановился?
- Ляжки у тебя на плечах...
- А-а-а, вспомнил. Ну, положил я ляжки на плечи, и как впердолил ей на всю длинну!'
	elseif temp = 19:
	gs 'zz_render','','','Отправился охотник на охоту, из-за кустов выскочили 2 зайца - и в стороны, у него глаза и разошлись по сторонам... Привозят
его в больницу, думают, как лечить. Профессор, с умным видом говорит практикантам:
- Недуг вылечить не сложно, просто положите между глаз яйцо, и зрение придет в норму.
На другое утро, придя на работу, профессор видит: охотника на каталке бодро везут в морг.
- Что случилось? - спрашивает.
- Ну так вы же сами сказали, чтобы ему между глаз яйцо положили. Так мы и хотели так сделать, только до пупа дотянули, а он
уж и околел...'
	elseif temp = 20:
	gs 'zz_render','','','Охотник садится в трамвай и кладет себе на колени ружье, направив дулом на соседа.
- Поосторожней, а то выстрелит!
- Ну и что? Еще раз заряжу.'
	elseif temp = 21:
	horny +=rand(5,20)
	gs 'zz_render','','','Пошел мужик на охоту. Ходит весь день, никого подстрелить не может. И тут - выходит он на опушку - а там
братки водку пьют, и зверья у них настрелянного - видимо-невидимо. Обидно мужику стало.
- Мужики,- говорит - поделились бы каким трофеем охотничьим, а то весь день хожу, никого подстрелить не могу,
чего жене домой нести?
- О чем разговор,- те отвечают. Только давай так: мы тебе глаза завяжем, а ты будешь зверя щупать и
говорить,как его убили. Договорились. Завязали мужику глаза, начал он зверье ощупывать.
- Вот кабанчик, одногодка, выстрел под лопатку, вод косуля, двухлетка, выстрел в голову... Ну и так далее.
Набрал мужик зверья, напоили его братки, пришел он домой, завалился спать. Утром встал, жена на него как-то
странно поглядывает.
- Ты чего это, - спрашивает.
- А что это, Вася, с тобой вчера было?
- А что?
- А что это ты меня всю ночь по п@зде гладил да приговаривал: "Ежик, трехлетка, удар топором..."'
	elseif temp = 22:
	gs 'zz_render','','','- Ты знаешь, когда я в командировку последний раз уезжал, в шкафу капкан на медведя поставил. Представляешь, приезжаю и
сразу бегу к шкафу. Смотрю - сидит, красавец!
- Кто? Любовник?
- Медведь!'
	elseif temp = 23:
	gs 'zz_render','','','Встретились как-то два друга-охотника, один перед одним хвастается.
- У меня собака, где утка подстреленная не упала найдет и принесет. Ну и тут же демонстрирует. Точно.
Второй говорит:
- А моя, круче. Hапример, летит стая уток я ее раскручиваю, бросаю по направлению к стае, она туда залетает,
хватает самую жирную утку и приносит мне. И для подтверждения раскручивает и бросает в пролетающую стая, а рядышком на лугу
пасется корова с теленком (ну, травку жуют), теленок поднимает голову вверх и видит летящую собаку и говорит:
- МУ, Мама-кoрoва, смотри собачка за утками летит. Корова отвечает:
- Я ж говорила трава хорошая.'
	elseif temp = 24:
	gs 'zz_render','','','Заядлый охотник в дверях кабачка столкнулся с местным врачом:
- Знаете, доктор, что я сегодня подстрелил?
- Да, знаю, я его уже перевязал.'
	elseif temp = 25:
	gs 'zz_render','','','- Вчера я подстрелил двух гусей...
- Они были дикие?
- Они-то нет, а вот их хозяин!'
	elseif temp = 26:
	horny +=rand(5,20)
	gs 'zz_render','','','Пошёл мужик на охоту. Подходит к берлоге медведя, сунул в берлогу ствол, выстрелил раз-другой. Вылез медведь и говорит:
- Мужик, либо я тебя заломаю, либо трахну, выбирай! Делать нечего, жить-то хочется... Но обиду на окаянного затаил, пошёл домой, достал пулемет, вернулся к месту бесчестия (берлоге), расстрелял в неё весь боекомплект. Вылезает медведь, говорит:
- Мужик, либо я тебя опять трахну, либо заломаю насмерть, выбирай! Выжил мужик и на этот раз, но обида пуще прежней не давала жить. Пошёл
домой, достал динамит, решил взорвать аспида подлого, вернулся к берлоге, обложил её со всех сторон динамитом, укрылся
неподалёку, взорвал. Позади него голос медведя:
- Мужик, я чего-то не понял, ты охотник или пидор?'
	elseif temp = 27:
	gs 'zz_render','','','Приходит охотник домой с охоты.
- Что это от тебя такой запах?
- Да понимаешь, пошел на медведя, а Тузика оставил дома. Пусть, думаю, дома побегает. Смотрю - берлога. Взял дрын, давай там шуровать. Когда слышу, кто-то мне сзади лапы на плечи положил. Поворачиваюсь. Ну вижу, что Тузик, а перестать срать не могу!'
	elseif temp = 28:
	horny +=rand(5,20)
	gs 'zz_render','','','Охотничий сезон. Охота на гусей. Охотник, изрядно уставший в поисках дичи, наконец-то увидел одинокого гуся, застывшего в
оцепенении у берега озера. Охотник стал подкрадываться к гусю, стараясь приблизится как можно ближе. Гусь не шевелится.
Когда, наконец, ствол двустволки коснулся затылка гуся, гусь обернулся и прошипел: "Тс-с-с-с! Карась!" "Что, клюет?" -
спросил с надеждой и шепотом обалдевший охотник. "Нет, сосет!!!"'
	elseif temp = 29:
	gs 'zz_render','','','Опытный охотник делится опытом с начинающим:
- Запомни, лучше всего охотиться с собаками: сколько бы ты ни ходил,
ни блуждал, а домой они дорогу всегда найдут, как проголодаются. Но уж
тогда поводка из рук не выпускай!'
	elseif temp = 30:
	gs 'zz_render','','','Будучи проездом в одной из областей, некий министр был приглашен на охоту на зайцев. По окончании он единогласно был провозглашен королем
стрелков. Министр один застрелил тридцать зайцев.
- Да, это великолепный результат, - скромно заметил он, - особенно,
если учесть, что у меня было только десять патронов.'
	elseif temp = 31:
	horny +=rand(5,20)
	gs 'zz_render','','','Разговаривают два охотника:
- Говорят, ты на прошлой неделе медведицу завалил?
- Было дело.
- Так расскажи же, как?
- Да как обычно - вино, легкая музыка, эротические журналы...'
	elseif temp = 32:
	horny +=rand(5,20)
	gs 'zz_render','','','Идут два охотника по лесу. Видят перед ними баба голая с раздвинупыми ногами лежит. Первый посмотрел и говорит:
- Хорош зверь!
Второй смотрит на жопу и говорит:
- Не-е-е стреляный.'
	elseif temp = 33:
	gs 'zz_render','','','Трое охотников. Один:
- Я как-то раз, на охоте, такого огромного кабана одним выстрем убил...
Второй:
- А я лося...
Третий:
- Пошел я, как-то на охоту. Один патрон в стволе.... И тут стая волков... Я стреляю - промах. Волки за мной. Я на сосну. Вожак за мой. Я на самую верхушку - вожак за мной. Я выше и он за мной. Тут ветка хрустнула и я вниз упал...
- Ну и чего?
- Сожрали на фиг...'
	elseif temp = 34:
	gs 'zz_render','','','Охотник идет по лесу, ему навстречу - кабан. Он из обоих стволов - бабах! Все в дыму, охотник
думает: попал или не попал? Дым рассеивается, кабан стоит целехонек и говорит:
- Ну, мужик, ты попал...'
	elseif temp = 35:
	gs 'zz_render','','','Разговаривают два охотника:
- Представляешь, вчера я набрел на парочку прекрасных фазанов, у меня сердце затрепетало, когда я их увидел!
- И ты их добыл?
- Нет, нескольких рублей не хватило.'
	end
}