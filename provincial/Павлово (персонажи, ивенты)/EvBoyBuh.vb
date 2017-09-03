if $args[0] = 'main' or $args[0] = '':
	minut += 5
	gs 'stat'
	! х-ки парня
	$boy = $bname
	!--
	gs 'zz_render','','pavlovo/dk/dk_night', 'Вы вышли с парнем из клуба он повел вас за клуб.'
	if func('zz_reputation','get') = 0:
		gs 'zz_render','','','Парень достал из пакета полторашку пива, чипсы и пару стаканчиков. Вы нашли местечко в зарослях и устроились на поваленном дереве.'
		if alko < 3 or alko >= 6:
			act 'Отказаться от пива':
				*clr & cla
				gs 'zz_render', '', 'pavlovo/dk/dk_night', iif(alko < 3,'\\- Извини, я не хочу пить.//','\\- Нет. *ик* Мне уже *ик* хватит.//')+'- сказали вы парню.**\\\- Ну без проблем, можно просто поговорить, -/// ответил он.'
				act 'Поболтать': gt 'EvBoyBuh','talk_with_npc'
				act 'Уйти': gt 'gdkin'
			end
		end
		act 'Пить пиво':
			*clr & cla
			gs 'zz_funcs', 'alko'
			gs 'zz_render','','','Вы весело болтали с парнем потягивая пиво из стаканчиков и заедая чипсами. Парень оказался веселый и рассказывал забавные истории.'
			if alko >= 3:
				horny += rand(10,20)
				gs 'zz_render','','','<<$bname>> обнял вас и поцеловал. Вас охватило возбуждение от поцелуя. Вы почувствовали его руки на своей груди.'
				if horny < 90 and shameless['flag'] < 2 or horny < 75 and shameless['flag'] >= 2:
					act 'Шептать "Не надо"':
						*clr & cla
						minut += 5
						gs 'stat'
						if DPtipe = 2:
							gs 'zz_render','','pavlovo/dk/disco/drinking/0/grab', 'Парень пьян и не обращает внимания на вас.'
							act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
							act 'Молчать': gt 'EvBoyBuh','boy_sex'
						else
							horny += 10
							gs 'stat'
							gs 'zz_render','','pavlovo/dk/disco/drinking/0/tits', 'Парень немного ослабляет напор, но все еще не отпускает вас. Вы стоите в обнимку с парнем и он плавно достает вашу грудь и начинает ее облизывать и сосать соски.'
							if horny < 75: act 'Уйти': gt 'gdkin'
							act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
						end
						gs 'EvBoyBuh','boy_hj'
					end
				end
				act 'Молчать': gt 'EvBoyBuh','boy_sex'
			else
				gs 'EvBoyBuh',iif(DPtipe = 1,'talk_with_npc','kiss_with_npc')
			end
			gs 'stat'
		end
	elseif func('zz_reputation','get') <= 2:
		if rand(0,10) = 0:
			gs 'zz_render', '', '', '<<$bname>> сказал:**\\\- <<$name[2]>> '+iif(func('zz_reputation','get') = 1,'я слышал, что ты всем даешь','я слышал, что ты в рот берешь')+'...///**Парень достал член из штанов.'
			act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
			gs 'EvBoyBuh','boy_decline'
		else
			gs 'zz_funcs', 'alko'
			gs 'stat'
			gs 'zz_render', '', '', '<<$bname>> достал пиво и вы начали выпивать с ним. Когда с пивом было покончено парень подошел к вам и обнял вас.'
			gs 'EvBoyBuh','boy_decline'
			gs 'EvBoyBuh','kiss_with_npc'
			exit
		end
	elseif func('zz_reputation','get') = 3:
		gs 'zz_render', '', '', '<<$bname>> сказал:**\\\- <<$name[2]>> ты же <<$gnikname>>. Я хочу поразвлечься!///**Парень достал член из штанов.'
		act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
		gs 'EvBoyBuh','boy_decline'
	elseif func('zz_reputation','get') = 4:
		gs 'zz_render', '', '', '<<$bname>> сказал6**\\\- <<$name[2]>> ты же <<$gnikname>>. Обсужи меня, вот тебе 300 рублей...///**После этого парень достал член из штанов.'
		act 'Сесть на корточки': money += 300 & gt 'EvBoyBuh','boy_bj'
		act 'Уйти': gt 'gdkin'
	end
	if func('zz_reputation','get') >= 1:
		if dom >= 10:
			act 'Обругать парня':
				*clr & cla
				dom += 2
				minut += 3
				if func('zz_reputation','get') > 0 and rand(0,1) = 0: gs 'zz_reputation','decrease',3
				gs 'stat'
				gs 'zz_render', '', '', 'Вы отказали пацану:**\\- Ты совсем охерел? Жене своей будешь такие предложения делать!!! Урод...//**Парень смутился:**\\\- Ну пацаны же говорят...///**Вы его перебили:\\- Говорят в Москве кур доят, да только как доят, не говорят! Ты больше уши развешивай, придурок!//'
				act 'Уйти': gt 'gdkin'
			end
		end
		if func('zz_reputation','get') = 4 and dom > 0:
			act 'А у тебя деньги то есть?':
				*clr & cla
				dom -= 1
				minut += 3
				gs 'zz_reputation','set',4
				money += 300
				gs 'stat'
				gs 'zz_render','','','\\- А у тебя деньги то есть?//**Пацан достал из кармана 300 рублей. Вы взяли деньги и положили их себе в сумочку.'
				act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
			end
		end
	end
end
! ГГ болтает с нпс
if $args[0] = 'talk_with_npc':
	*clr & cla
	minut += rand(5,10)
	gs 'stat'
	if vnesh >= RAND(0,200):
		gs 'zz_render','','pavlovo/dk/dk_night','\\\- Ты классная девчонка. Может мы еще встретимся?///'
		act 'Отказать ему и уйти': gt 'gdkin'
		act 'Сказать ему свой телефон':
			*clr & cla
			manna += 10
			numboyFrend += 1
			$nameBoyfrend[numboyFrend] = $boy
			dickBoyFrend[numboyFrend] = rand(10,22)
			silavagBoyFrend[numboyFrend] = rand(0,2)
			otnBoyFrend[numboyFrend] = 50
			gs 'stat'
			gs 'zz_render','','', 'Вы сказали парню свой телефон и он записал его.'
			act 'Уйти': gt 'gdkin'
		end
	else
		gs 'EvBoyBuh','kiss_with_npc'
	end
end
! ГГ целуется с парнем + продолжение
if $args[0] = 'kiss_with_npc':
	gs 'zz_render','','', 'Вы общаетесь с парнем возле Дома Культуры. <<$bname>> подходит к вам ближе и начинает целовать вас.'
	if horny <= 25 or shameless['flag'] < 2: act 'Уйти': gt'gdkin'
	act 'Целоваться':
		*clr & cla
		horny += 5
		minut += 3
		gs 'stat'
		gs 'zz_render','','images/qwest/alter/Ev/kiss', '<<$bname>> страстно целует ваши <<$liptalk3>> и вы отвечаете взаимностью на этот поцелуй. Вы чувствуете как руки парня стараются вытащить вашу грудь.'
		if horny <= 50 or shameless['flag'] < 1: act 'Уйти': gt'gdkin'
		act 'Позволить ему':
			*clr & cla
			horny += 10
			minut += 3
			gs 'stat'
			gs 'zz_render','','pavlovo/dk/disco/drinking/0/tits', '<<$bname>> вытаскивает вашу грудь <<body[''tits'']>> размера наружу и начинает мять ваши груди и целовать их. Парень берет вашу руку и кладет себе на пах, вы чувствуете что у него там твердый член.'
			if horny <= 75:
				act 'Сопротивляться':
					*clr & cla
					horny += 10
					minut += 3
					gs 'stat'
					gs 'zz_render','','pavlovo/dk/disco/drinking/0/petting', 'Вы убрали руку от ширинки и парень засунул вам свою руку в трусы, вы ощутили как его пальцы ласкают вашу мокрую киску.'
					if horny <= 90:
						act 'Убрать его руки и уйти': dom += 1 & gt'gdkin'
					else
						cla
						horny = 0
						orgasm += 1
						gs 'stat'
						gs 'zz_render', '', '', 'Внезапно вы почувствовали как внизу живота нарастает приятное тепло и на вас обрушился оргазм. Вы прикусили губу что бы не заорать от ощущений.'
						act 'Стонать':
							*clr & cla
							horny += 5
							minut += 3
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/Ev/cock3.jpg', 'Вы застонали от удовольствия и ваши ноги подкосились, вы сели на корточки перед парнем. Когда в глазах прояснилось вы увидели перед вашим лицом член.'
							if dom < -10:
								act 'Сосать':
									*clr & cla
									minut += 5
									horny += 10
									bj += 1
									guy += 1
									dom -= 1
									gs 'stat'
									gs 'zz_render','','common/sex/public_bj/'+rand(0,4)+'.gif','Вы сами того не понимая внезапно поцеловали головку члена и поняли что же вы делаете только тогда, когда твердый член уже наполнил ваш рот и вы старательно его отсасывали.'
									act 'Далее':
										*clr & cla
										minut += 5
										horny += 10
										gs 'zz_funcs','cum','lip'
										gs 'zz_funcs','cum','face'
										cumfrot += 1
										if func('zz_reputation','get') < 2 and RAND(0,100) >= 80: gs 'zz_reputation','set',2
										gs 'stat'
										gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif', 'Внезапно вам в рот ударила теплая струя спермы, вы едва не захлебнулись но продолжили сосать. Семя стекало по вашим губам на член и капало вам на одежду, наконец член стал опадать в вашем рту и парень его вынул, и убрал в штаны.'
										act 'Посмотреть на парня':
											*clr & cla
											minut += 1
											gs 'stat'
											gs 'zz_render','','common/sex/public_bj_cum/publ_cum.gif', '<<$bname>> все еще держит вас за голову и вы с полным ртом спермы посмотрели вверх, ему в лицо. Парень блаженствует и довольно смотрит на вас:**\\\- Офигенно отсосала!///'
											act 'Встать и уйти': gt 'gdkin'
										end
									end
								end
							elseif dom >= -10 and dom <= 10:
								act 'Сидеть':
									*clr & cla
									minut += 5
									guy += 1
									dom -= 1
									gs 'zz_funcs','cum','face'
									cumfrot += 1
									gs 'stat'
									gs 'zz_render','','common/sex/public_bj_cum/'+rand(0,2), 'Вы как завороженная остались сидеть на земле и парень начал дрочить член перед вашим лицом. Все произошло очень быстро, вы не успели ничего понять и вдруг вам на лицо, из члена вылетает струя горячей жидкости и приземляется на нос. Вы вздрагиваете и зажмуриваете глаза, ощущая как новые струйки спермы попадают вам на лицо.'
									act 'Уйти': gt 'gdkin'
								end
							else
								gs 'EvBoyBuh','boy_hj'
							end
						end
					end
				end
			end
			act 'Ласкать его член через штаны':
				*clr & cla
				horny += 5
				minut += 3
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/Ev/cock.jpg', 'Вы начали гладить парня по ширинке, ощущая твердость члена.'
				act 'Залезть к парню в штаны':
					*clr & cla
					horny += 10
					minut += 3
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/Ev/cock2.jpg', 'Вы засунули руку к парню в штаны и почувствовали своими пальцами его твердый и горячий член.'
					if dom > 10: gs 'EvBoyBuh','boy_hj'
					act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
				end
			end
		end
	end
end
! секс с нпс
if $args[0] = 'boy_sex':
	*clr & cla
	minut += 5
	horny += rand(5,10)
	guy += 1
	if func('zz_reputation','get') = 0 and RAND(0,100) >= 80: gs 'zz_reputation','set',1
	pose = 1
	dynamic $venerasiak
	gs 'stat'
	gs 'zz_render', '', 'common/sex/public_sex/'+rand(0,2)+'.gif', 'Вы нагнулись и оголили свой зад перед парнем.'
	gs 'zz_dynamic_sex', 'sex_start'
	gs 'zz_dynamic_sex', 'vaginal', 'dick'
	gs 'zz_dynamic_sex', 'sex_cum'
	act 'Уйти': gt 'gdkin'
end
if $args[0] = 'boy_bj':
	*clr & cla
	minut += 5
	horny += 10
	bj += 1
	dom -= 1
	gs 'stat'
	gs 'zz_render','','images/qwest/alter/Ev/boybj.jpg', 'Вы сели на корточки перед парнем и стали дрочить его член.'
	act 'Сосать':
		*clr & cla
		minut += 5
		horny += 10
		if func('zz_reputation','get') < 2 and RAND(0,100) >= 80: gs 'zz_reputation','set',2
		gs 'stat'
		gs 'zz_render','','common/sex/bj/'+rand(0,4)+'.gif'
		gs 'zz_dynamic_sex', 'bj'
		act 'Сосать дальше':
			*clr & cla
			minut += 5
			horny += 10
			guy += 1
			gs 'zz_funcs', 'cum', 'face'
			gs 'stat'
			gs 'zz_render','','common/sex/public_bj_cum/publ_cum.gif'
			gs 'zz_dynamic_sex', 'swallow'
			act 'Уйти': gt 'gdkin'
		end
		act 'Нагнуться': gt 'EvBoyBuh','boy_sex'
	end
end
if $args[0] = 'boy_hj':
	if dom > 0:
		act 'Подрочить парню':
			*clr & cla
			minut += 5
			dom -= 1
			gs 'stat'
			if RAND(0,1) = 0:
				guy += 1
				hj += 1
				gs 'zz_render','','common/sex/hj_cum/'+rand(0,2)+'.gif', 'Вы достали его твердый и горячий член из штанов и взяли его в руку. Вы начали целоваться с парнем, одновременно дроча ему член. Наконец парень сдавленно застонал и вы увидели как из его члена вылетает сперма.'
				act 'Уйти': gt 'gdkin'
			else
				gs 'zz_render','','common/sex/hj/'+rand(0,1)+'.gif', 'Вы достали его твердый и горячий член из штанов и взяли его в руку. Вы начали целоваться с парнем, одновременно дроча ему член. Парень надавливает вам на плечи вынуждая сесть на корточки.'
				act 'Сесть на корточки': gt 'EvBoyBuh','boy_bj'
				if dom > 30 and horny < 100: act 'Уйти': gt 'gdkin'
			end
		end
	end
end
if $args[0] = 'boy_decline':
	if dom >= 0:
		act 'Уйти':
			*clr & cla
			dom += 1
			minut += 5
			gs 'stat'
			gs 'zz_render','','','Вы отказали парню и пошли обратно в клуб.'
			act 'В клуб': gt 'gdkin'
		end
	end
end