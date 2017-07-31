if $args[0] = '' or $args[0] = 'main':
	$sexloc = $CURLOC
	gs 'zz_funcs', 'colorize_day'
	gs 'zz_render', 'Кис-киска', 'clothing/magaz.jpg', func('young_shop_strings','local_str1')
	act '<B>Выйти из магазина</B>':
		minut += 3
		gs 'zz_clothing', 'dispose'
		gt 'torgcentr'
	end
	if hour < 8 or hour > 18:
		gs 'zz_render','','',func('young_shop_strings', 'local_str59')
		exit
	end
	if hour >= 8 and hour <= 18 and week < 6:
		if young_shop_work = 1 and young_shop_miss >= 3: gt 'andrey'
		act 'Зайти к менеджеру':
			minut += 1
			gt 'andrey'
		end
	end
	! 9 - shop_id
	gs 'zz_clothing', 'make_shop', 9
	if hour = 15 and young_shop_work = 1 and week < 6:
		act 'Работать':
			*clr & cla
			inWorkYoungShop = 1
			young_shop_salary += 1
			minut += 135
			gs 'stat'
			gs 'zz_render','','clothing/magaz.jpg',func('young_shop_strings','local_str2')
			random = RAND(1,80)
			if random <= 20 and (kira ! 0 or young_shop_salary < 3):
				gs 'zz_render', '', '', func('young_shop_strings', 'local_str3')
				gs $curloc,'endwork'
			elseif random <= 20 and kira = 0 and young_shop_salary >= 3:
				*clr & cla
				kira = 1
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str4')
				act 'Да, конечно':
					*clr & cla
					gs 'zz_render', '', 'pictures/young_shop_quest9.jpg', func('young_shop_strings', 'local_str5')
					act 'С мини-юбочкой лучше':
						*clr & cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str6')
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str7')
						act 'Уговаривать Киру':
							*clr & cla
							if intel >= 50:
								gs 'zz_render', '', 'pictures/young_shop_quest9.jpg', func('young_shop_strings', 'local_str8')
								gs $curloc,'endwork'
							else
								gs 'zz_render', '', '', func('young_shop_strings', 'local_str9')
								act 'Снять с неё трусики':
									*clr & cla
									gs 'zz_render', '', 'pictures/young_shop_quest9.jpg', func('young_shop_strings', 'local_str10')
									gs $curloc,'endwork'
								end
							end
						end
					end
				end
				act 'Нет, ей ещё рано':
					*clr & cla
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str11')
					act 'Убеждать женщину':
						cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str12')
						if intel >= 60:
							gs 'zz_render', '', 'pictures/young_shop_quest9.jpg', func('young_shop_strings', 'local_str13')
							gs $curloc,'endwork'
						else
							gs 'zz_render', '', 'pictures/young_shop_quest9.jpg', func('young_shop_strings', 'local_str14')
							gs $curloc,'endwork'
						end
					end
				end
			elseif random = 21:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str15')
				act 'Не стыдно!':
					cla
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str16')
					gs $curloc,'endwork'
				end
				act 'Это только на работе так':
					cla
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str17')
					gs $curloc,'endwork'
				end
			elseif random = 22:
				*clr & cla
				gs 'zz_render', 'Случай на работе', 'pictures/young_shop_quest2.jpg', func('young_shop_strings', 'local_str18')
				if horny >= 80:
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str19')
					act 'Подслушивать':
						*clr & cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str20')
						act 'Заглянуть в кабинку':
							*clr & cla
							horny += 10
							gs 'zz_render', '', 'pictures/young_shop_quest3.jpg', func('young_shop_strings', 'local_str21')
							gs $curloc,'endwork'
						end
					end
				elseif horny < 80:
					act 'Игнорировать':
						*clr & cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str22')
						gs $curloc,'endwork'
					end
					act 'Разогнать':
						*clr & cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str23')
						gs $curloc,'endwork'
					end
				end
			elseif random = 23:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str24')
				act 'Забрать себе':
					cla
					gs 'zz_clothing', 'init_clothing'
					gs 'zz_clothing', 'add_to_wardrobe', rand(1,21)
					gs 'zz_clothing', 'dispose'
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str25')
					gs $curloc,'endwork'
				end
				gs $curloc,'endwork'
			elseif random = 24:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str26')
				act 'Рассказать о видеокамере':
					cla
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str27')
					gs $curloc,'endwork'
				end
				act 'Промолчать':
					cla
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str28')
					gs $curloc,'endwork'
				end
			elseif random = 25:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str29')
				if intel >= 40:
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str30')
					act 'Сдать педофила':
						cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str31')
						gs $curloc,'endwork'
					end
				end
				act 'Примерить одежду':
					*clr & cla
					if intel >= 40:
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str32')
					else
						horny += 30
						gs 'stat'
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str33')
					end
					act 'Отказаться':
						gs 'zz_render', '', 'pictures/young_shop_quest4.jpg', func('young_shop_strings', 'local_str34')
						gs $curloc,'endwork'
					end
					act 'Согласиться':
						*clr & cla
						money += 5000
						horny += 10
						gs 'stat'
						gs 'zz_render','','','Возбуждённый покупатель достаёт из кармана кошелёк и протягивает мне <b>5000</b> рублей'
						gs 'zz_render','','',func('young_shop_strings', 'local_str35')
						if horny >= 100: gs 'zz_render','','','Да и моё тело просто жаждет, чтобы на него кто-то смотрел.'
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str36')
						act 'Закрыть глаза':
							*clr & cla
							horny += 10
							gs 'zz_funcs', 'cum', 'face'
							gs 'stat'
							gs 'zz_render', '', 'pictures/young_shop_quest8.jpg', func('young_shop_strings', 'local_str37')
							if vaf > 10:
								swallow += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs 'stat'
								gs 'zz_render', '', '', func('young_shop_strings', 'local_str38')
								gs $curloc,'endwork'
							else
								gs 'zz_render', '', '', func('young_shop_strings', 'local_str39')
								if vaf > 0:
									swallow += 1
									gs 'zz_funcs', 'cum', 'lip'
									gs 'zz_render', '', '', func('young_shop_strings', 'local_str40')
								end
								gs 'zz_render', '', '', func('young_shop_strings', 'local_str41')
								gs $curloc,'endwork'
							end
						end
					end
					gs $curloc,'endwork'
				end
			elseif random = 26:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str42')
				gs $curloc,'endwork'
			elseif random = 27:
				*clr & cla
				gs 'zz_render', 'Случай на работе', 'pictures/young_shop_quest5.jpg', func('young_shop_strings', 'local_str43')
				act 'Вам помочь?':
					cla
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str44')
					if vnesh < 80:
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str45')
						gs $curloc,'endwork'
					else
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str46')
						gs $curloc,'endwork'
					end
				end
			elseif random = 28:
				*clr & cla
				money += 1000
				gs 'zz_render', 'Случай на работе', 'pictures/young_shop_quest6.jpg', func('young_shop_strings', 'local_str47')
				gs $curloc,'endwork'
			elseif random >= 29 and random <= 34:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str48')
				act 'Заглянуть внутрь':
					cla
					gs 'zz_render', '', 'pictures/young_shop_quest10.jpg', func('young_shop_strings', 'local_str49')
					act 'Ждать менеджера':
						cla
						gs 'zz_render', '', '', func('young_shop_strings', 'local_str50')
						gs $curloc,'endwork'
					end
					act 'Взять презерватив':
						*clr & cla
						gs 'zz_render', '', 'pictures/condom_cum.jpg', func('young_shop_strings', 'local_str51')
						act 'В рот!':
							cla
							gs 'zz_render', '', '', func('young_shop_strings', 'local_str52')
							gs $curloc,'endwork'
						end
					end
				end
			elseif random >= 35 and random <= 39:
				*clr & cla
				gs 'zz_render', 'Случай на работе', '', func('young_shop_strings', 'local_str'+(53+katia))
				katia = 1
				gs $curloc,'endwork'
			elseif random >= 40 and random <= 44:
				*clr & cla
				gs 'zz_render', 'Спокойный рабочий день', '', func('young_shop_strings', 'local_str55')
				gs $curloc,'endwork'
			elseif random >= 45 and random <= 50:
				*clr & cla
				gs 'zz_render', 'Тяжёлый рабочий день', '', func('young_shop_strings', 'local_str56')
				act 'Хорошо':
					cla
					minut += 70
					young_shop_bonus += 3
					gs 'stat'
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str57')
					gs $curloc,'endwork'
				end
				act 'Не могу':
					cla
					if young_shop_bonus > 0: young_shop_bonus -= 1
					gs 'zz_render', '', '', func('young_shop_strings', 'local_str58')
					gs $curloc,'endwork'
				end
			elseif random > 50:
				gt 'young_shop',(random-1)/5-10
			end
		end
	end
end
!---
if $ARGS[0] = '0':
	cla
	gs 'zz_render', '', '', func('young_shop_strings', 'local_str60')
	act 'Отказаться': gs $curloc,'endwork'
	act 'Переодеться в кабинке':
		cla
		gs 'zz_render', '', '', func('young_shop_strings', 'local_str61')
		act 'Уйти': gs $curloc,'endwork'
	end
	act 'Переодеться при нем':
		*clr & cla
		guy += 1
		picrand = 19
		gs 'zz_render', '', 'images/img/centr/mag0.jpg', func('young_shop_strings', 'local_str62')
		act 'Развлекаться': gt'sex','kuni'
	end
end
if $ARGS[0] = '1':
	cla
	gs 'zz_render', '', '', func('young_shop_strings', 'local_str63')
	act 'Отказаться': gs $curloc,'endwork'
	act 'Переодеться в кабинке':
		*clr & cla
		picrand = 29
		gs 'zz_render', '', 'img/centr/mag1.jpg', func('young_shop_strings', 'local_str64')
		act 'Закрыть штору': gs $curloc,'endwork'
		act 'Отвести в подсобку':guy += 1 & gt'sex','minet'
	end
end
if $ARGS[0] = '2':
	*clr & cla
	gs 'zz_render', '', 'img/centr/mag2.jpg', func('young_shop_strings', 'local_str65')
	act 'Отказаться': gs $curloc,'endwork'
	act 'Согласиться':
		guy += 1
		money += 2000
		picrand = 35
		gt'sex','minet'
	end
end
if $ARGS[0] = '3':
	*clr & cla
	gs 'zz_render', '', 'img/centr/mag3.jpg', func('young_shop_strings', 'local_str66')
	act 'Послать их': gs $curloc,'endwork'
	act 'Спросить что вы получите':
		cla
		picrand = 15
		gs 'zz_render', '', '', func('young_shop_strings', 'local_str67')
		act 'Послать их': gs $curloc,'endwork'
		act 'Отвести в подсобку':
			*clr & cla
			guy += 2
			gs 'zz_render', '', 'img/centr/mag4.jpg', func('young_shop_strings', 'local_str68')
			act 'Приз победителям':xgt'sexdvoe','var'
		end
	end
end
if $ARGS[0] = '4':
	*clr & cla
	gs 'zz_render', '', 'img/centr/mag5.jpg', func('young_shop_strings', 'local_str69')
	act 'Позвать менеджера':
		cla
		gs 'zz_render', '', '', func('young_shop_strings', 'local_str70')
		gs $curloc,'endwork'
	end
	act 'Дать им':
		guy += 2
		picrand = 16
		xgt'sexdvoe','var'
	end
end
if $ARGS[0] = '5':
	cla
	gs 'zz_render', '', '', func('young_shop_strings', 'local_str71')
	act 'Послать их': gs $curloc,'endwork'
	act 'Снять трусы':
		*clr & cla
		girl += 2
		lesbian += 1
		gs 'zz_render', '', 'img/centr/mag6.jpg', func('young_shop_strings', 'local_str72')
		act 'Отблагодарить её':
			*clr & cla
			gs 'zz_render', '', 'img/centr/mag7.jpg', func('young_shop_strings', 'local_str73')
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'img/centr/mag8.jpg', func('young_shop_strings', 'local_str74')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'img/centr/mag9.jpg', func('young_shop_strings', 'local_str75')
					gs $curloc,'endwork'
				end
			end
		end
	end
end
if $args[0] = 'endwork':
	act 'Закончить работу':
		if week = 5 and young_shop_salary > 0:
			gt 'andrey'
		else
			minut += 3
			gs 'zz_clothing', 'dispose'
			gt 'torgcentr'
		end
	end
end