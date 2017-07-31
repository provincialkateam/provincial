if $ARGS[0] = 'start':
	cla
	*clr
	rand1=rand(0,100)
	minut += 5
	gs 'stat'
	gs 'zz_funcs', 'colorize_day'
	$loc = $curloc
	$metka = $args[0]
	'<center><b><font color = maroon>Закусочная Быстроешка</font></b></center>'
	gs 'zz_render', '', 'images/pic/burger.jpg', func('burger_strings', 'local_str1')
	if BistroBoss > 0:'<a href="exec:GT ''burgerBoss''">Кабинет директора</a> Анатолия Борисовича'
	act 'Выйти':
		cla
		minut += 5
		gt 'down'
	end
	if money >= 300:
		act 'Поесть 300 руб':
			cla
			*clr
			money -= 300
			gs 'zz_kitchen_acts', 'eat'
			gs 'zz_kitchen_acts', 'drink', 'tea'
			act 'Встать из за стола':gt'burger','start'
		end
	end
	act 'Заказать кофе': gt 'zz_common', 'coffee'
	if $npc['0,qwIvanPodstava'] = 2:
		act 'Зайти в кабинет к Анатолию Борисовичу':
			*clr & cla
			gs'stat'
			gs 'zz_render', '', '', func('burger_strings', 'local_str2')
			act 'Выйти':gt'burger','start'
			if money >= 650000:
				act 'Отдать долг':
					*clr & cla
					money -= 650000
					$npc['0,qwIvanPodstava'] = 5
					gs'stat'
					gs 'zz_render', '', '', func('burger_strings', 'local_str3')
					act 'Выйти':gt'burger','start'
				end
			end
			if IvanEvidence = 1:
				act 'Показать доказательства':
					*clr & cla
					$npc['0,qwIvanPodstava'] = 6
					IvanKvartira = 0
					IvanEvidence = 0
					gs'stat'
					gs 'zz_render', '', '', func('burger_strings', 'local_str4')
					act 'Выйти':gt'burger','start'
				end
			end
		end
	end
	if posuda = 0:
		act 'Поговорить о работе':
			cla
			gs 'zz_render', '', '', func('burger_strings', 'local_str5')
			act 'Отказаться и уйти':gt'burger','start'
			act 'Согласиться на работу':
				cla
				posuda = 1
				gs 'zz_render', '', '', func('burger_strings', 'local_str6')
				act 'Выйти':gt'burger','start'
			end
		end
	elseif posuda >= 3 and posudaA = 0:
		act 'Зайти к менеджеру':
			cla
			gs 'zz_render', '', '', func('burger_strings', 'local_str7')
			act 'Отказаться и уйти':gt'burger','start'
			act 'Согласиться на работу':
				cla
				posudaA = 1
				gs 'zz_render', '', '', func('burger_strings', 'local_str8')
				act 'Выйти':gt'burger','start'
			end
		end
	elseif posuda >= 1 and posudaday ! day and NoBistroWork = 0 and PersSecWork = 0:
		act 'Мыть посуду (1 час 100 руб)':
			cla
			*clr
			posudaday = day
			minut += 60
			posuda += 1
			manna -= 15
			money += 100
			sweat += 1
			if $npc['0,qwBistro'] = 10:$npc['0,qwBistro'] = 0
			gs 'zz_render', '', 'images/pics/dirt.jpg', func('burger_strings', 'local_str9')
			if vnesh >= 40 and posuda >= 7 and $npc['0,qwBistro'] < 10:
				if $npc['0,qwBistro'] = 1:
					gs 'zz_render', '', '', func('burger_strings', 'local_str10')
				elseif $npc['0,qwBistro'] = 0:
					$npc['0,qwBistro'] = 1
					gs 'zz_render', '', '', func('burger_strings', 'local_str11')
				end
				act 'Отказаться':gt'burger','start'
				act 'Согласиться':
					*clr & cla
					$npc['0,qwBistro'] = 10
					gs 'zz_render', '', '', func('burger_strings', 'local_str12')
					act 'Сесть в машину':
						*clr & cla
						minut += 15
						$npc['0,qwBistro'] = 20
						gs 'stat'
						gs 'zz_render', '', 'images/maggot/car.jpg', func('burger_strings', 'local_str13')
						act 'Идти в примерочную':
							*clr & cla
							minut += 15
							gs 'stat'
							gs 'zz_render', '', 'images/maggot/butic.jpg', func('burger_strings', 'local_str14')
							act 'Сделать минет':
								*clr & cla
								minut += 15
								$npc['0,qwBistro'] = 50
								bj += 1
								guy += 1
								swallow += 1
								gs 'zz_funcs', 'cum', 'lip'
								gs 'zz_clothing', 'init_clothing'
								gs 'zz_clothing', 'add_to_wardrobe', 67
								gs 'zz_clothing', 'dispose'
								gs'stat'
								gs 'zz_render', '', 'images/maggot/bj.jpg', func('burger_strings', 'local_str15')
								act 'Выйти из бутика':
									*clr & cla
									minut += 15
									gs'stat'
									gs 'zz_render', '', 'images/maggot/car.jpg', func('burger_strings', 'local_str16')
									act 'Выйти из машины':gt'street'
								end
							end
							act 'Мяться':
								*clr & cla
								minut += 15
								gs'stat'
								gs 'zz_render', '', '', func('burger_strings', 'local_str17')
								act 'Испуганно смотреть':
									*clr & cla
									minut += 1
									$npc['0,qwBistro'] = 50
									bj += 1
									guy += 1
									gs 'zz_clothing', 'init_clothing'
									gs 'zz_clothing', 'add_to_wardrobe', 67
									gs 'zz_clothing', 'dispose'
									gs'stat'
									gs 'zz_render', '', 'images/maggot/pr.jpg', func('burger_strings', 'local_str18')
									act 'Облизать':
										*clr & cla
										minut += 2
										gs'stat'
										gs 'zz_render', '', 'images/maggot/pr1.jpg', func('burger_strings', 'local_str19')
										act 'Лизать член':
											*clr & cla
											minut += 2
											gs'stat'
											gs 'zz_render', '', 'images/maggot/pr2.jpg', func('burger_strings', 'local_str20')
											act 'Сосать член':
												*clr & cla
												minut += 2
												gs 'zz_funcs', 'cum', 'lip'
												gs 'zz_funcs', 'cum', 'face'
												gs 'stat'
												gs 'zz_render', '', 'images/maggot/pr3.jpg', func('burger_strings', 'local_str21')
												act 'Сидеть на полу':
													*clr & cla
													minut += 2
													gs 'stat'
													gs 'zz_render', '', 'images/maggot/pr4.jpg', func('burger_strings', 'local_str22')
													act 'Выйти из примерочной':
														*clr & cla
														minut += 2
														gs 'stat'
														gs 'zz_render', '', 'images/maggot/pr4.jpg', func('burger_strings', 'local_str23')
														act 'Выйти из бутика':
															*clr & cla
															minut += 15
															gs 'stat'
															gs 'zz_render', '', 'images/maggot/car.jpg', func('burger_strings', 'local_str24')
															act 'Выйти из машины':gt'street'
														end
													end
												end
											end
										end
									end
								end
							end
							if dom > 0:
								act 'Большое спасибо (Отказать)':
									*clr
									dom += 5
									gs 'zz_render', '', '', func('burger_strings', 'local_str25')
									act 'Уйти':
										cla
										minut += 5
										gt 'down'
									end
								end
							end
						end
					end
				end
				exit
			elseif $npc['0,qwBistro'] = 20:
				if RAND(0,10) = 10: 'Из кабинета вышел хозяин Быстроежки Анатолий Борисович и увидев вас отвернулся с заносчивой миной.'
			elseif $npc['0,qwBistro'] = 56:
				gs 'zz_render', '', '', func('burger_strings', 'local_str26')
				act 'Да':
					*clr & cla
					gs'stat'
					gs 'zz_render', '', '', func('burger_strings', 'local_str27')
					act 'Я передумала':
						*clr & cla
						$npc['0,qwBistro'] = 57
						gs'stat'
						gs 'zz_render', '', '', func('burger_strings', 'local_str28')
						act 'Уйти':gt'burger','start'
					end
					act 'Взять ключ и идти в кабинет Анатолия Борисовича':
						*clr & cla
						$npc['0,qwBistro'] = 111
						gs'stat'
						gs 'zz_render', '', '', func('burger_strings', 'local_str29')
						act 'Заглянуть в конверт':
							*clr & cla
							$burgerIvanText = 'И заглянули в конверт. После этого вы закрыли сейф и направились на выход.'
							gs'stat'
							gs 'zz_render', '', '', func('burger_strings', 'local_str30')
							act 'Отнести конверт Ивану':
								*clr & cla
								IvanPodstavaDay = day
								$npc['0,qwIvanPodstava'] = 1
								NoBistroWork = 1
								gs'stat'
								gs 'zz_render', '', '', func('burger_strings', 'local_str31')
								act 'Уйти':gt'burger','start'
							end
						end
						act 'Отнести конверт Ивану':
							*clr & cla
							$burgerIvanText = 'Вы взяли конверт и закрыв сейф направились на выход.'
							IvanPodstavaDay = day
							$npc['0,qwIvanPodstava'] = 1
							NoBistroWork = 1
							gs'stat'
							gs 'zz_render', '', '', func('burger_strings', 'local_str32')
							act 'Уйти':gt'burger','start'
						end
					end
				end
				act 'Нет':
					*clr & cla
					$npc['0,qwBistro'] = 57
					gs'stat'
					gs 'zz_render', '', '', func('burger_strings', 'local_str33')
					act 'Уйти':gt'burger','start'
				end
				exit
			elseif $npc['0,qwBistro'] = 50:
				gs 'zz_render', '', '', func('burger_strings', 'local_str34')
				act 'Идти в кабинет менеджера':
					*clr & cla
					minut += 15
					$npc['0,qwBistro'] = 55
					gs'stat'
					gs 'zz_render', '', 'images/maggot/bj1.jpg', func('burger_strings', 'local_str35')
					act 'Нагнуться':
						*clr & cla
						gs 'zz_render', '', 'images/maggot/bj2.jpg', func('burger_strings', 'local_str36')
						act 'Взять в рот':
							*clr & cla
							minut += 3
							bj += 1
							guy += 1
							gs'stat'
							gs 'zz_render', '', 'images/maggot/bj3.jpg', func('burger_strings', 'local_str37')
							act 'Проглотить сперму и чистить его член языком':
								*clr & cla
								minut += 2
								swallow += 1
								gs 'zz_funcs', 'cum', 'lip'
								money += 1500
								gs'stat'
								gs 'zz_render', '', 'images/maggot/bj4.jpg', func('burger_strings', 'local_str38')
								act 'Уйти':gt'burger','start'
							end
						end
					end
					if dom >= 0:
						act 'Вырываться':
							*clr & cla
							$npc['0,qwBistro'] = 56
							gs'stat'
							gs 'zz_render', '', 'images/maggot/bj1.jpg', func('burger_strings', 'local_str39')
							act 'Перебьешься!':dom += 1 & gt'burger','start'
							act 'Взять в рот':
								*clr & cla
								$npc['0,qwBistro'] = 55
								minut += 3
								bj += 1
								guy += 1
								gs'stat'
								gs 'zz_render', '', 'images/maggot/bj3.jpg', func('burger_strings', 'local_str40')
								act 'Проглотить сперму и чистить его член языком':
									*clr & cla
									minut += 2
									swallow += 1
									gs 'zz_funcs', 'cum', 'lip'
									money += 1500
									gs'stat'
									gs 'zz_render', '', 'images/maggot/bj4.jpg', func('burger_strings', 'local_str41')
									act 'Уйти':gt'burger','start'
								end
							end
						end
					end
					exit
				end
			elseif $npc['0,qwBistro'] = 55:
				gs 'zz_render', '', '', func('burger_strings', 'local_str42')
				act 'Идти в кабинет менеджера':
					*clr & cla
					$npc['0,qwBistro'] = 60
					gs 'zz_render', '', '', func('burger_strings', 'local_str43')
					act 'Лезть под стол':
						*clr & cla
						minut += 3
						bj += 1
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						money += 1500
						gs'stat'
						gs 'zz_render', '', 'images/maggot/bjud.jpg', func('burger_strings', 'local_str44')
						act 'Уйти':gt'burger','start'
					end
				end
			elseif $npc['0,qwBistro'] = 60:
				gs 'zz_render', '', '', func('burger_strings', 'local_str45')
				act 'Идти в кабинет менеджера':
					*clr & cla
					$npc['0,qwBistro'] = 65
					gs 'zz_render', '', '', func('burger_strings', 'local_str46')
					act 'Покорно кивнуть головой':
						*clr & cla
						bj += 1
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_funcs', 'cum', 'face'
						guy += 1
						gs'stat'
						if rand1<10:'<center><img src="images/maggot/bj21.jpg"></center>'
						if rand1>=10 and rand1<50:'<center><img src="images/nigma/city/managger0,'+rand(0,1)+'.gif"></center>'
						if rand1>=50:'<center><img src="images/nigma/city/managger0,'+rand(0,3)+'.jpg"></center>'
						gs 'zz_render', '', '', func('burger_strings', 'local_str47')
						act 'Уйти':gt'burger','start'
					end
					act 'Послать его':
						*clr & cla
						gs 'zz_render', '', '', func('burger_strings', 'local_str48')
						act 'Да':
							*clr & cla
							$npc['0,qwBistro'] = 70
							bj += 1
							guy += 3
							gs 'stat'
							gs 'zz_render', '', 'images/maggot/tri.jpg', func('burger_strings', 'local_str49')
							act 'Подставить лицо':
								*clr & cla
								gs 'zz_funcs', 'cum', 'face'
								gs'stat'
								gs 'zz_render', '', 'images/maggot/tri2.jpg', func('burger_strings', 'local_str50')
								act 'Уйти':gt'burger','start'
							end
						end
						act 'Заорать во всю глотку и убежать':$npc['0,qwBistro'] = 61 & gt'burger','start'
					end
				end
			elseif $npc['0,qwBistro'] >= 65 and soplakTimes ! 3:
				gs 'zz_render', '', '', func('burger_strings', 'local_str51')
				act 'Работать ртом':
					*clr & cla
					bj += 1
					dom -= 1
					gs'stat'
					if rand1<10:'<center><img src="images/maggot/bj21.jpg"></center>'
					if rand1>=10 and rand1<50:'<center><img src="images/nigma/city/managger0,'+rand(0,1)+'.gif"></center>'
					if rand1>=50:'<center><img src="images/nigma/city/managger0,'+rand(0,3)+'.jpg"></center>'
					gs 'zz_render', '', '', func('burger_strings', 'local_str52')
					act '...':
						*clr & cla
						gs 'zz_funcs', 'cum', 'lip'
						money += 300
						soplakTimes1 += 1
						if soplaktimes1 = 10: soplaktimes = 3
						gs'stat'
						if rand1<40:'<center><img src="images/maggot/bj32.jpg"></center>'
						if rand1>=40:'<center><img src="images/nigma/city/cum0,'+rand(0,1)+'.jpg"></center>'
						gs 'zz_render', '', '', func('burger_strings', 'local_str53')
						act 'Уйти':gt'burger','start'
					end
				end
				exit
			elseif $npc['0,qwBistro'] = 57 and BistroBoss = 0 or $npc['0,qwBistro'] >= 65 and BistroBoss = 0 and soplakTimes = 10:
				BistroBoss = 1
				if soplakTimes = 3:soplakTimes = 4
				gs 'zz_render', '', '', func('burger_strings', 'local_str54')
				act 'Уйти':gt'burger','start'
				exit
			end
			act 'Уйти':gt'burger','start'
		end
	elseif posudaA >= 1 and posudaAday ! day and hour < 10 and NoBistroWork = 0 and PersSecWork = 0:
		act 'Мыть пол (1 час 150 руб)':
			cla
			*clr
			posudaAday = day
			minut += 60
			posuda += 1
			manna -= 15
			money += 100
			sweat += 1
			gs 'zz_render', '', 'images/pic/clener1.jpg', func('burger_strings', 'local_str55')
			act 'Уйти':gt'burger','start'
		end
	end
end