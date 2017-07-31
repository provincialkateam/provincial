if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ночной клуб', 'images/pic/club.jpg', func('club_strings', 'local_str1')
	act 'Выйти из Клуба':
		cla
		minut += 5
		gt'down'
	end
	if func('zz_clothing','is_skirt') = 1 and money >= 250 and mop > 1 and sweat < 1:
		gs 'zz_render', '', '', func('club_strings', 'local_str2')
		act 'Войти в клуб (500 руб)':
			cla
			minut += 5
			money -= 500
			frost = 0
			gt 'club','inside'
		end
	else
		gs 'zz_render', '', '', func('club_strings', 'local_str3')
	end
end
if $ARGS[0] = 'inside':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Ночной клуб', 'images/pic/club2.jpg', func('club_strings', 'local_str4')
	if hour <= 3 or hour >= 15:
		act 'Туалет': gt 'club','toi'
		act 'Танцпол': gt 'club','dance'
		act 'Бар': gt 'club','bar'
	end
	act 'Уйти из Клуба':
		cla
		drunk = 0
		minut += 5
		gt 'down'
	end
end
if $ARGS[0] = 'toi':
	*clr & cla
	$loc = $curloc
	$metka = $args[0]
	gs 'zz_render', '', '', func('club_strings', 'local_str5')
	act 'Стоять в очереди':
		cla
		minut += RAND(10,30)
		gs 'zz_render', '', '', func('club_strings', 'local_str6')
		act 'Туалет': gt 'zz_toilet', 'main'
	end
	act 'Идти в мужской':
		cla
		acta += 1
		gs 'zz_render', '', '', func('club_strings', 'local_str7')
		act 'В кабинку':
			if TQuest = 0 and horny <50: gt 'zz_toilet', 'main'
			if TQuest = 0 and horny >= 50: gt 'club2', 'туалет'
			if TQuest = 1: gt 'club2','туалет1'
			if TQuest = 2: gt 'club2','туалет2'
			if TQuest >= 3:
				if RAND(1,100) < 60:
					gt 'zz_toilet', 'main'
				else
					gt 'club2','туалет1'
				end
			end
		end
	end
	act 'Забить': gt 'club','inside'
end
if $ARGS[0] = 'dance':
	*clr & cla
	gs 'stat'
	gs 'zz_render', 'Танцпол', iif(rand(0,20)<=10,'images/pic/club2.jpg','images/nigma/city/club/club.dance0,'+rand(0,4)+'.jpg'), func('club_strings', 'local_str8')
	act 'Выйти': gt'club','inside'
	if hour <= 3 or hour >= 16:
		act 'Танцевать 30 мин':
			*clr & cla
			minut += 30
			body['day_weight'] -= 1
			dance += 1
			manna += 10
			clrand = RAND(0,200)
			gs 'zz_render', '', iif(rand(0,20)<=10,'images/pic/club4.jpg','images/nigma/city/club/club.dance0,'+rand(0,4)+'.jpg'), func('club_strings', 'local_str9')
			if vnesh >= clrand:
				horny += 1
				gs 'boy'
				gs 'zz_render', '', '', func('club_strings', 'local_str10')
				act 'Танцевать с ним':
					*clr & cla
					minut += 30
					dance += 1
					horny += 10
					gs 'zz_render', '', 'images/pic/club8.jpg', func('club_strings', 'local_str11')
					if horny < 90: act 'Уйти с танцпола': gt 'club', 'dance'
					act 'Поцеловать':
						cla
						minut += 15
						horny += 10
						if RAND(0,1) = 1:
							picrand = 38
							gs 'zz_render', '', '', func('club_strings', 'local_str12')
							if horny < 70: act 'Уйти с танцпола':gt'club','dance'
							act 'Идти в Vip-зал с парнем': xgt'sex','var'
						else
							gs 'zz_render', '', '', func('club_strings', 'local_str13')
							if horny < 70: act 'Уйти с танцпола': gt 'club','dance'
							act 'Идти в туалет с парнем':gt'club','sex'
						end
					end
				end
				if clrand > 85:
					*clr & cla
					gs 'zz_render', '', 'images/img/centr/dancelezb.jpg', func('club_strings', 'local_str14')
					if RAND(0,1) = 0:
						act 'Пойдем в туалет, развлечемся': gt'club','lezbsort'
					else
						picrand = RAND(13,17)
						act 'Пойдем в Vip-зал, развлечемся': xgt'lezbsex','var'
					end
					act 'Послать её':gt'club'
				end
			end
			act 'Передохнуть':gt'club','dance'
		end
		act 'Подойти к диджею 30 мин':
			*clr & cla
			minut += 30
			gs 'zz_render', '', 'images/pic/club7.jpg'
			if alexeyQW = 0:
				gs 'zz_render', '', '', func('club_strings', 'local_str15')
			elseif alexeyQW > 0 and alexeySex = 0:
				gs 'zz_render', '', '', func('club_strings', 'local_str16')
			elseif alexeyQW > 0 and alexeySex > 0:
				gs 'zz_render', '', '', func('club_strings', 'local_str17')
				act 'Зайти в кабинку':
					*clr & cla
					minut += 30
					gs 'stat'
					gs 'zz_render', '', 'images/pic/club7.jpg', func('club_strings', 'local_str18')
					if alexeyClubSex = 3 and sashaClubQW = 0:
						sashaClubQW = 1
						gs 'zz_render', '', '', func('club_strings', 'local_str19')
						act 'Отойти':gt'club','dance'
						exit
					end
					if alexeyClubSex ! 3 or sashaClubQW > 0:
						act 'Отойти':gt'club','dance'
						act 'Встать на колени и взять в рот':
							*clr & cla
							alexeySex += 1
							alexeyClubSex += 1
							horny += 10
							bj += 1
							minut += 10
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alexey/bj'+RAND(0,13)+'.jpg', func('club_strings', 'local_str20')
							act 'Подставить рот':
								*clr & cla
								horny += 10
								minut += 10
								swallow += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs 'stat'
								gs 'zz_render', '', 'images/qwest/alexey/bjcum'+RAND(0,13)+'.jpg', func('club_strings', 'local_str21')
								act 'Отойти':gt'club','dance'
							end
						end
					end
				end
			end
			act 'Отойти': gt'club','dance'
		end
	end
end
if $ARGS[0] = 'bar':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Бар', 'images/pic/club5.jpg', func('club_strings', 'local_str22')
	if vnesh > 40 and rand(0,10) < 2: gt 'club', 'bar<<rand(0,1)>>'
	act 'Выйти': gt 'club','inside'
	if alko >= 7:
		*clr & cla
		temp = RAND(0,100)
		if temp >= 64 and temp < 70:
			gs 'zz_render', '', 'images/etogame/club<<temp>>.jpg', func('club_strings', 'str<<temp>>')
		elseif temp >= 70 and temp < 90:
			gs 'zz_render', '', 'images/picKav/ivrand'+(temp-68)+'.jpg', func('kafe_strings', 'local_str<<temp>>')
		end
		gs 'zz_render','','',func('club_strings','str63')
		act 'Далее': gt 'street'
		exit
	end
	if money >= 300:
		act 'Купить выпивку (300 руб)':
			*clr & cla
			gs 'zz_funcs', 'alko', 2
			horny += RAND(10,50)
			money -= 300
			gs 'stat'
			gs 'zz_render', '', 'images/pic/club6.jpg', func('club_strings', 'local_str44')
			act 'Встать': gt 'club','bar'
		end
	end
end
if $ARGS[0] = 'sex':
	*clr & cla
	dynamic $venerasiak
	minut += 5
	$boy = 'Незнакомец'
	dick = RAND(10,18)
	gs 'stat'
	gs 'zz_render', 'Туалетная кабинка', 'images/pic/sex.jpg', func('club_strings', 'local_str45')
	act 'Сделать минет':
		*clr & cla
		bj += 1
		guy += 1
		horny += VAF
		gs 'stat'
		'<center><img src="images/nigma/city/club/club.toilet0,'+rand(0,4)+'.jpg"></center>'
		gs 'zz_dynamic_sex', 'bj'
		act 'Вынуть изо рта':
			*clr & cla
			if harakBoy = 0:
				gs 'zz_render', '', 'images/picV/hand.jpg', func('club_strings', 'local_str46')
			elseif harakBoy = 1:
				act 'Направить член на пол':
					cla
					gs 'zz_render', '', 'images/picV/hand.jpg', func('club_strings', 'local_str47')
					act 'Встать': gt 'club','toi'
				end
				act 'Направить член на лицо':
					cla
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_render', '', 'images/picV/clubFacial1.jpg', func('club_strings', 'local_str48')
					act 'Встать':gt'club','toi'
				end
				exit
			elseif harakBoy = 2:
				gs 'zz_funcs', 'cum', 'face'
				dom -= 1
				gs 'zz_render', '', 'images/picV/clubFacial.jpg', func('club_strings', 'local_str49')
			end
			act 'Встать':gt'club','toi'
		end
		act 'Глотать сперму':
			*clr & cla
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_render', '', 'images/picV/clubSwallow.jpg', func('club_strings', 'local_str50')
			act 'Встать':gt'club','toi'
		end
	end
	act 'Встать раком':
		*clr & cla
		sex += 1
		guy += 1
		horny += 10
		vagina += 1
		gs 'stat'
		gs 'zz_render','','images/nigma/city/т1,'+rand(0,3)+'.gif'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		gs 'zz_dynamic_sex', 'sex_cum'
		act 'Встать': gt'club','toi'
	end
end
if $ARGS[0] = 'bar0':
	*clr & cla
	gs 'zz_render', 'Барная стойка', 'images/img/centr/bar0.jpg', func('club_strings', 'local_str51')
	act 'Отойти':gt'club','bar'
	act 'Поцеловать':
		*clr & cla
		gs 'zz_render', '', 'images/img/centr/bar1.jpg', func('club_strings', 'local_str52')
		act 'Позвать в туалет':gt'club','lezbsort'
		act 'Залезть в трусы':
			*clr & cla
			lesbian += 1
			girl += 1
			gs 'zz_render', '', 'images/img/centr/bar2.jpg', func('club_strings', 'local_str53')
			act 'Лизать':
				*clr & cla
				gs 'zz_render', '', 'images/img/centr/bar3.jpg', func('club_strings', 'local_str54')
				act 'Еще':
					*clr & cla
					horny = 0
					gs 'zz_render', '', 'images/img/centr/bar4.jpg', func('club_strings', 'local_str55')
					if dildo = 0:
						act 'Всё': gt'club','bar'
					else
						act 'Достать дилдо':
							*clr & cla
							gs 'zz_render', '', 'images/img/centr/bar5.jpg', func('club_strings', 'local_str56')
							act 'Еще':
								*clr & cla
								horny = 0
								orgasm += 1
								gs 'zz_render', '', 'images/img/centr/bar6.jpg', func('club_strings', 'local_str57')
								act 'Уйти': gt'club','inside'
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'bar1':
	*clr & cla
	gs 'zz_render', 'Барная стойка', 'images/img/centr/bar7.jpg', func('club_strings', 'local_str58')
	act 'Послать': gt'club',iif(alko < 4,'bar','rape')
	if DOM > 10:
		act 'Дать полизать':
			*clr & cla
			kuni += 1
			gs 'zz_render', '', 'images/img/centr/barkuni.jpg', func('club_strings', 'local_str59')
			act 'Послать': gt'club','bar'
			act 'Минет': gt'club','bar2'
			act 'Дать': gt'club','bar3'
		end
	end
	act 'Минет': gt'club','bar2'
	act 'Дать': gt'club','bar3'
end
if $ARGS[0] = 'bar2':
	*clr & cla
	dynamic $venerasiak
	bj += 1
	guy += 1
	gs 'zz_render', 'Барная стойка', 'images/img/centr/barminet.jpg', func('club_strings', 'local_str60')
	act 'Дать':gt'club','bar3'
	act 'Сосать':
		*clr & cla
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_render', '', 'images/img/centr/barcum.jpg', func('club_strings', 'local_str61')
		act 'Уйти': gt 'club','inside'
	end
end
if $ARGS[0] = 'bar3':
	*clr & cla
	sex += 1
	gs 'zz_render', 'Барная стойка', 'images/img/centr/barsex.jpg', func('club_strings', 'local_str62')
	gs 'zz_funcs', 'cum', 'pussy'
	act 'Уйти': gt'club','inside'
end
if $ARGS[0] = 'rape':
	*clr & cla
	dynamic $venerasiak
	dom -= 5
	rape += 1
	if RAND(0,1) = 0:
		bj += 1
		gs 'zz_render', '', 'images/img/centr/barminet.jpg', func('club_strings', 'local_str63')
		act 'Дальше':
			if RAND(0,1) = 0:
				*clr & cla
				gs 'zz_funcs', 'cum', 'lip'
				gs 'zz_funcs', 'cum', 'face'
				gs 'zz_render', '', 'images/img/centr/barcum.jpg', func('club_strings', 'local_str64')
				act 'Уйти':gt'club','inside'
			else
				*clr & cla
				sex += 1
				gs 'zz_render', '', 'images/img/centr/barsex.jpg', func('club_strings', 'local_str65')
				gs 'zz_funcs', 'cum', 'pussy'
				act 'Уйти':gt'club','inside'
			end
		end
	else
		sex += 1
		gs 'zz_render', '', 'images/img/centr/barsex.jpg', func('club_strings', 'local_str66')
		gs 'zz_funcs', 'cum', 'pussy'
		act 'Уйти':gt'club','inside'
	end
end
if $ARGS[0] = 'lezbsort':
	*clr & cla
	dynamic $venerasiak
	girl += 1
	lesbian += 1
	minut += 10
	gs 'zz_render', 'Туалет', 'images/img/centr/lezbsort.jpg', func('club_strings', 'local_str67')
	act 'Лизать': gt'club','lezbsort1'
	act 'Дать полизать': gt'club','lezbsort2'
	act 'Уйти': gt'club','toi'
end
if $ARGS[0] = 'lezbsort1':
	*clr & cla
	minut += 10
	horny = 0
	gs 'zz_render', 'Туалет', 'images/img/centr/sortukuni.jpg', func('club_strings', 'local_str68')
	if hour >= 15 or hour <= 3: act 'Дать полизать':gt'club','lezbsort2'
	act 'Уйти': gt'club','toi'
end
if $ARGS[0] = 'lezbsort2':
	*clr & cla
	minut += 10
	horny = 0
	gs 'zz_render', 'Туалет', 'images/img/centr/sortkuni.jpg', func('club_strings', 'local_str69')
	if hour >= 15 or hour <= 3:act 'Лизать':gt'club','lezbsort1'
	act 'Уйти':gt'club','toi'
end
if $ARGS[0] = 'vip':
	if vipcart = 0 and vipday ! day:
		gs 'zz_render', '', '', func('club_strings', 'local_str70')
		if money >= 50000:
			act 'Купить карту':
				money -= 50000
				vipcart = 10
				vipday = day
				gt'vipclub','start'
			end
		end
	elseif vipcart > 0 and vipday ! day:
		act 'Пройти в клуб':
			vipcart -= 1
			vipday = 1
			vipday = day
			gt'vipclub','start'
		end
	end
	if vipday = day: act 'Пройти в клуб':gt'vipclub','start'
	act 'Отойти': gt'club','inside'
end