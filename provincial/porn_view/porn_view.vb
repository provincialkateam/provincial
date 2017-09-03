! начальная строка
gs 'zz_render', '', '', func('porn_view_strings', 'init0')
if ($npc['39,qwPornoFootball'] > 0 and $npc['39,qwPornoFootball'] < 3) or ($npc['39,qwPornoFootball'] = 0 and (sex + bj + hj + anal + kuni) > 0):
	gs 'zz_render', '', '', func('porn_view_strings', 'init1')
end
if $npc['39,qwPornoFootball'] >= 3: gs 'zz_render', '', '', func('porn_view_strings', 'init2')
! начальная стадия
minut += iif($npc['39,qwPornoFootball'] < 4,rand(15,30),rand(60,80))
if $npc['39,qwPornoFootball'] < 10:
	if (sex + bj + hj + anal + kuni) = 0:
		! гг без опыта
		if $npc['39,qwPornoFootball'] = 0:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_1_virgin')
			$npc['39,qwPornoFootball'] += 1
			cla
			act 'Уйти': gt 'gorodok'
		elseif $npc['39,qwPornoFootball'] > 0 and $npc['39,qwPornoFootball'] < 3:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_2_virgin')
			! если сбегает - просмотр не защитываем
			act 'Сбежать из квартиры': gt 'gorodok'
			act 'Остаться':
				cla
				$npc['39,qwPornoFootball'] += 1
				act 'Уйти': gt 'gorodok'
				gs 'zz_render', '', '', func('porn_view_strings', 'view_2_virgin_next')
			end
		elseif $npc['39,qwPornoFootball'] = 3 or $npc['39,qwPornoFootball'] = 4:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_3_virgin'+iif(horny > 70,'_horny',''))
			$npc['39,qwPornoFootball'] +=1
			horny += 10
			cla
			act 'Уйти': gt 'gorodok'
		elseif $npc['39,qwPornoFootball'] = 5 or $npc['39,qwPornoFootball'] = 6:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_'+$npc['39,qwPornoFootball']+'_virgin'+iif(horny > 70,'_horny',''))
			$npc['39,qwPornoFootball'] += 1
			horny += 10
			cla
			act 'Уйти': gt 'gorodok'
		elseif $npc['39,qwPornoFootball'] >= 7 and $npc['39,qwPornoFootball'] < 10:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_7_virgin'+iif(horny > 70,'_horny',''))
			$npc['39,qwPornoFootball'] +=1
			horny += 10
			if tanga = 0:
				act '...':
					*clr & cla
					! а есть ли труселя
					if horny > 70:
						gs 'zz_render', '', '', func('porn_view_strings', 'view_7_virgin_horny_no_tanga')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/3.webm', func('porn_view_strings', 'view_71_virgin_horny_no_tanga')
							! у нас тут юбка!
							if func('zz_clothing','is_skirt') = 1:
								act '...':
									*clr & cla
									gs 'zz_render', '', '', func('porn_view_strings','view_7_virgin_horny_no_tanga_skirt')
									act 'Уйти': gt 'gorodok'
								end
							end
							act 'Уйти': gt 'gorodok'
						end
					else
						gs 'zz_render', '', '', func('porn_view_strings', 'view_7_virgin_no_tanga')
						act 'Уйти': gt 'gorodok'
					end
				end
			else
				act 'Уйти': gt 'gorodok'
			end
		end
	else
		! у гг есть опыт
		horny += rand(10,20)
		if $npc['39,qwPornoFootball'] < 3:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_1')
			$npc['39,qwPornoFootball'] += 1
			cla
			act 'Уйти': gt 'gorodok'
		elseif $npc['39,qwPornoFootball'] = 3 or $npc['39,qwPornoFootball'] = 4:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_3'+iif(horny > 70,'_horny',''))
			$npc['39,qwPornoFootball'] += 1
			cla
			act 'Уйти': gt 'gorodok'
		elseif $npc['39,qwPornoFootball'] = 5:
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_5'+iif(horny > 70,'_horny',''))
			! а есть ли труселя
			if tanga = 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_5'+iif(horny > 70,'_horny_no_tanga','_no_tanga'))
			$npc['39,qwPornoFootball'] += 1
			cla
			act 'Уйти': gt 'gorodok'
		elseif $npc['39,qwPornoFootball'] = 6:
			gs 'zz_render', '', '', func('porn_view_strings', 'view_6')
			! а есть ли труселя
			if tanga = 0: gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/1.webm', func('porn_view_strings', 'view_6'+iif(horny > 70,'_horny_no_tanga','_no_tanga'))
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/3.webm', func('porn_view_strings','view_6_next')
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/4.webm', func('porn_view_strings','view_61_next')
					horny = 0
					$npc['39,qwPornoFootball'] += 1
					act 'Уйти': gt 'gorodok'
				end
			end
		end
		if $npc['39,qwPornoFootball'] = 7:
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/4.webm', func('porn_view_strings','view_7')
				horny = 0
				$npc['39,qwPornoFootball'] += 1
				act 'Уйти': gt 'gorodok'
			end
		elseif $npc['39,qwPornoFootball'] = 8:
			act '...':
				*clr & cla
				horny = 0
				$npc['39,qwPornoFootball'] = 10
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/5.webm', func('porn_view_strings','view_8')
				gs 'zz_render', '', '', func('porn_view_strings','view_8'+iif(tanga=0,'_no_tanga','_tanga'))
				gs 'zz_render', '', '', func('porn_view_strings','view_8_next')
				! разработанность Светки
				if anus <= 15 and vagina <= 15:
					gs 'zz_render', '', '', func('porn_view_strings','view_8_tight')
					gs 'zz_render', '', '', func('porn_view_strings','view_8_finish')
				end
				if anus >= 15 and vagina >= 15:
					gs 'zz_render', '', '', func('porn_view_strings','view_8_stretched_both')
					gs 'zz_render', '', '', func('porn_view_strings','view_8_finish')
				end
				if anus >= 15:
					gs 'zz_render', '', '', func('porn_view_strings','view_8_stretched_anus')
					gs 'zz_render', '', '', func('porn_view_strings','view_8_finish')
				end
				if vagina >= 15:
					gs 'zz_render', '', '', func('porn_view_strings','view_8_stretched_vag')
					gs 'zz_render', '', '', func('porn_view_strings','view_8_finish')
				end
				act 'Уйти': gt 'gorodok'
			end
		end
	end
end
! продолжаем просмотры
if $npc['39,qwPornoFootball'] >= 10:
	orgasm += 1
	manna += 20
	!horny = 0
	if $npc['39,qwPornoFootball'] <= 14: mastr += 1
	! name randomizer
	$_init_arr[0] = 'Мишаня'
	$_init_arr[1] = 'Колька'
	$_init_arr[2] = 'Жендос'
	:loop_boys_names
	i = rand(0,arrsize('$_init_arr')-1)
	$_zz_boy_arr[] = $_init_arr[i]
	killvar '$_init_arr', i
	if arrsize('$_init_arr') > 1: jump 'loop_boys_names'
	$_zz_boy_arr[] = $_init_arr[0]
	killvar '$_init_arr'
	! ---
	if $npc['39,qwPornoFootball'] = 10:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/2.webm', func('porn_view_strings', 'view_10')
			act '...':
			*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/2.webm', func('porn_view_strings', 'view_10'+iif(horny>70,'_horny','_no_horny'))
				$npc['39,qwPornoFootball'] += 1
				horny = 0
				act 'Уйти': gt 'gorodok'
			end
		end
	elseif $npc['39,qwPornoFootball'] = 11:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/2.webm', func('porn_view_strings', 'view_11')
			$npc['39,qwPornoFootball'] += 1
			horny = 0
			act 'Уйти': gt 'gorodok'
		end
	elseif $npc['39,qwPornoFootball'] = 12:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/5.webm', func('porn_view_strings', 'view_12')
			$npc['39,qwPornoFootball'] += 1
			horny = 0
			act 'Уйти': gt 'gorodok'
		end
	elseif $npc['39,qwPornoFootball'] = 13:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/2.webm', func('porn_view_strings', 'view_13')
			if horny>70:
				act '...':
					*clr & cla
					$npc['39,qwPornoFootball'] += 1
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/4.webm', func('porn_view_strings', 'view_13_horny')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/11.webm', func('porn_view_strings', 'view_131_horny')
						horny = 0
						gs 'zz_bathroom', 'clean_me'
						hapri = 1
						act 'Уйти': gt 'gorodok'
					end
				end
			else
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/2.webm', func('porn_view_strings', 'view_13_no_horny')
				act 'Уйти': gt 'gorodok'
			end
		end
	elseif $npc['39,qwPornoFootball'] = 14:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/2.webm', func('porn_view_strings', 'view_14')
			gs 'zz_render', '', '', func('porn_view_strings', 'view_14'+iif(tanga=1,'_tanga','_no_tanga'))
			gs 'zz_render', '', '', func('porn_view_strings', 'view_14'+iif(lobok>2,'_bush','_no_bush'))
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/5.webm', func('porn_view_strings', 'view_14_next')
				gs 'zz_bathroom', 'clean_me'
				hapri = 1
				horny = 0
				hj += 2
				$npc['39,qwPornoFootball'] += 1
				act 'Уйти': gt 'gorodok'
			end
		end
	elseif $npc['39,qwPornoFootball'] = 15:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/6.webm', func('porn_view_strings', 'view_15_prev')
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/13.webm', func('porn_view_strings', 'view_15_prev2')
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/2.webm', func('porn_view_strings', 'view_15')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/4.webm', func('porn_view_strings', 'view_15_next'+iif(vagina=0,'_virgin',iif(mesec>0,'_wdays','')))
						gs 'zz_render', '', '', func('porn_view_strings', 'view_15_fin')
						gs 'zz_bathroom', 'clean_me'
						hapri = 1
						horny = 0
						hj += 3
						$npc['39,qwPornoFootball'] += 1
						act 'Уйти': gt 'gorodok'
					end
				end
			end
		end
	end
!мать его так - не понимает больше вложенности
	if $npc['39,qwPornoFootball'] = 16:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/4.webm', func('porn_view_strings', 'view_15')
			gs 'zz_render', '', '', func('porn_view_strings', 'view_15_next'+iif(vagina=0,'_virgin',iif(mesec>0,'_wdays','')))
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/5.webm', func('porn_view_strings', 'view_16')
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/2.webm', func('porn_view_strings', 'view_16_next')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/8.webm', func('porn_view_strings', 'view_16_next1'+iif(mesec>0,'_wdays',iif(vagina=0,'_virgin','')))
						gs 'zz_render', '', '', func('porn_view_strings', 'view_16_next2')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/20.webm', func('porn_view_strings', 'view_16_next3'+iif(bj=0,'_virgin',''))
							gs 'zz_render', '', '', func('porn_view_strings', 'view_16_fin')
							bj += 3
							hj += 3
							kuni += 1
							guy += 3
							gang += 1
							horny = 0
							$npc['39,sex'] += 1
							gs 'zz_funcs', 'cum', 'face'
							gs 'zz_bathroom', 'clean_me'
							$npc['39,qwPornoFootball'] += 1
							hapri = 1
							act 'Уйти': gt 'gorodok'
						end
					end
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] = 17 or $npc['39,qwPornoFootball'] = 18:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/9.webm', func('porn_view_strings', 'view_17')
			gs 'zz_render', '', '', func('porn_view_strings', 'view_17_next')
			!if rand(0,10) > 5: kuni += 1 & gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/7.webm', func('porn_view_strings', 'view_17_next_rand')
			gs 'zz_render', '', '', func('porn_view_strings', 'view_17_fin')
			bj += 1
			hj += 2
			horny = 0
			gs 'zz_funcs', 'cum', 'face'
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			$npc['39,qwPornoFootball'] += 1
			act 'Уйти': gt 'gorodok'
		end
	elseif $npc['39,qwPornoFootball'] = 19:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/10.webm', func('porn_view_strings', 'view_19')
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/7.webm', func('porn_view_strings', 'view_191')
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/13.webm', func('porn_view_strings', 'view_192')
					bj += 3
					kuni += 3
					swallow += 3
					horny = 0
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_bathroom', 'clean_me'
					hapri = 1
					$npc['39,qwPornoFootball'] += 1
					act 'Уйти': gt 'gorodok'
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] = 20 or $npc['39,qwPornoFootball'] = 21:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/11.webm', func('porn_view_strings', 'view_20')
			if mesec > 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_20_wdays')
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/7.webm', func('porn_view_strings', 'view_20_end')
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/13.webm', func('porn_view_strings', 'view_201_end')
					bj += 3
					kuni += 3
					swallow += 3
					horny = 0
					gs 'zz_funcs', 'cum', 'face'
					gs 'zz_bathroom', 'clean_me'
					hapri = 1
					$npc['39,qwPornoFootball'] += 1
					act 'Уйти': gt 'gorodok'
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] = 22:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/11.webm', func('porn_view_strings', 'view_20')
			if mesec > 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_20_wdays')
			act '...':
				*clr & cla
				gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/15.webm', func('porn_view_strings', 'view_22')
				if vagina > 0:
					if mesec = 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_22_no_virgin_no_wdays')
					if tabletki = 0 and prezik = 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_22_no_pills')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/3.webm', func('porn_view_strings', 'view_22_no_virgin')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/6.webm', func('porn_view_strings', 'view_221_no_virgin')
							sex += 3
							gang += 1
							bj += 3
							brother_knows_not_virgin = 1
							$npc['39,qwPornoFootball'] = 31
							act 'Уйти': gt 'gorodok'
						end
					end
				else
					swallow += 1
					mastr += 1
					if anus = 0: agape = 2
					$npc['39,qwPornoFootball'] = iif(anus = 0,23,24)
					anal += 1
					if anus <= 5: anus += 1
					gs 'zz_render', '', '', func('porn_view_strings', 'view_22_virgin')
					act '...':
						*clr & cla
						if anus = 0:
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_22_virgin_first_anal')
							act '...':
								*clr & cla
								gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/9.webm', func('porn_view_strings', 'view_221_virgin_first_anal')
								act '...':
									*clr & cla
									gs 'zz_render', '', '', func('porn_view_strings', 'view_222_virgin_first_anal')
									act '...':
										*clr & cla
										gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/19.webm', func('porn_view_strings', 'view_223_virgin_first_anal')
										act 'Уйти': gt 'gorodok'
									end
								end
							end
						else
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_22_virgin_anal')
							act '...':
								*clr & cla
								gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/19.webm', func('porn_view_strings', 'view_221_virgin_anal')
								act 'Уйти': gt 'gorodok'
							end
						end
					end
				end
				horny = 0
				gang += 1
				swallow += 1
				gs 'zz_bathroom', 'clean_me'
				hapri = 1
			end
		end
	end
	if $npc['39,qwPornoFootball'] >= 23 and $npc['39,qwPornoFootball'] <= 26:
		act '...':
			horny = 0
			bj += 3
			gang += 1
			$npc['39,qwPornoFootball'] += 1
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/9.webm', func('porn_view_strings', 'view_23')
			act '...':
				*clr & cla
				if agape > 0:
					gs 'zz_render', '', '', func('porn_view_strings', 'view_23_pain')
					swallow += 3
					act 'Уйти': gt 'gorodok'
				else
					if $npc['39,qwPornoFootball'] = 23:
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_23_anal')
						act '...':
							*clr & cla
							anal += 1
							agape = 1
							swallow += 2
							if anus <= 5: anus += 1
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/19.webm', func('porn_view_strings', 'view_231_anal')
							act 'Уйти': gt 'gorodok'
						end
					else
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/18.webm', func('porn_view_strings', 'view_24')
							act 'Уйти': gt 'gorodok'
						end
					end
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] >= 27 and $npc['39,qwPornoFootball'] <= 29:
		act '...':
			*clr & cla
			anal += 3
			if anus <= 10: anus += 1
			bj += 3
			gang += 1
			$npc['39,qwPornoFootball'] += 1
			horny = 0
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/15.webm', func('porn_view_strings', 'view_23')
			if agape > 0:
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/16.webm', func('porn_view_strings', 'view_27_pain')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/6.webm', func('porn_view_strings', 'view_27')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_271')
							act '...':
								*clr & cla
								gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/11.webm', func('porn_view_strings', 'view_27_rand')
								anal += 3
								bj += 3
								minut += 20
								gs 'zz_bathroom', 'clean_me'
								hapri = 1
								killvar '$_zz_boy_arr'
								act 'Уйти': gt 'gorodok'
							end
						end
					end
				end
			else
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_27')
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_271')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/11.webm', func('porn_view_strings', 'view_27_rand')
							anal += 3
							bj += 3
							minut += 20
							gs 'zz_bathroom', 'clean_me'
							hapri = 1
							killvar '$_zz_boy_arr'
							act 'Уйти': gt 'gorodok'
						end
					end
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] = 30:
		act '...':
			*clr & cla
			gang += 1
			bj += 2
			swallow += 2
			horny = 0
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/6.webm', func('porn_view_strings', 'view_30')
			if mesec > 0:
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/19.webm', func('porn_view_strings', 'view_30_anal')
					anal += 1
					if anus <= 5: anus += 1
					act 'Уйти': gt 'gorodok'
				end
			else
				brother_knows_not_virgin = 1
				sex += 1
				$npc['39,qwPornoFootball'] += 1
				if vagina > 0:
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_22_no_virgin_no_wdays')
						if tabletki = 0 and prezik = 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_22_no_pills')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/9.webm', func('porn_view_strings', 'view_30_sex')
							cla
							act 'Уйти': gt 'gorodok'
						end
					end
					if vagina <= 5: vagina += 1
				else
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/9.webm', func('porn_view_strings', 'view_30_first_sex')
						act '...':
							*clr & cla
							gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/10.webm', func('porn_view_strings', 'view_301_first_sex')
							vagina += 1
							vgape = 2
							act 'Уйти': gt 'gorodok'
						end
					end
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] = 31:
		act '...':
			gang += 1
			horny = 0
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/21.webm', func('porn_view_strings', 'view_31')
			if vgape > 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_31_vpain')
			if mesec > 0 or vgape > 0:
				if anus = 0:
					act '...':
						*clr & cla
						gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/8.webm', func('porn_view_strings', 'view_31_first_anal')
						gs 'zz_render', '', '', func('porn_view_strings', 'view_22_virgin_first_anal')
						if anus = 0: agape = 2
						anal += 1
						if anus <= 5: anus += 1
						bj += 2
						swallow += 2
						act 'Уйти': gt 'gorodok'
					end
				else
					act '...':
						*clr & cla
						gs 'porn_view_construct', 'no_pussy'
						act 'Уйти': gt 'gorodok'
					end
				end
			else
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/10.webm', func('porn_view_strings', 'view_31_sex')
					gs 'zz_render', '', '', func('porn_view_strings', 'view_22_no_pills')
					gs 'porn_view_construct', 'vaginal'
					if vagina < 10: vagina += 1
					sex += 3
					$npc['39,qwPornoFootball'] += 1
					bj += 3
					act 'Уйти': gt 'gorodok'
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] >= 32 and $npc['39,qwPornoFootball'] <= 35:
		act '...':
			*clr & cla
			if sweat >= 2: gs 'zz_render', '', '', func('porn_view_strings', 'view_32_sweat')
			if lobok > 2:
				gs 'zz_render', '', '', func('porn_view_strings', 'view_32_bush')
				lobok = 0
			end
			act '...':
				*clr & cla
				gs 'porn_view_construct', iif(mesec > 0,'wdays','random')
				$npc['39,qwPornoFootball'] += 1
				gang += 1
				horny = 0
				gs 'zz_bathroom', 'clean_me'
				hapri = 1
				act 'Уйти': gt 'gorodok'
			end
		end
	end
	if $npc['39,qwPornoFootball'] = 36:
		act '...':
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/8.webm', func('porn_view_strings', 'view_36')
			act '...':
				*clr & cla
				gs 'porn_view_construct', iif(mesec > 0,'wdays','dp')
				$npc['39,qwPornoFootball'] += 1
				gang += 1
				horny = 0
				gs 'zz_bathroom', 'clean_me'
				hapri = 1
				act 'Уйти': gt 'gorodok'
			end
		end
	elseif $npc['39,qwPornoFootball'] >= 37 and $npc['39,qwPornoFootball'] <= 39:
		act '...':
			*clr & cla
			horny = 0
			gang += 1
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_1/18.webm', func('porn_view_strings', 'view_40')
			if mesec > 0:
				act '...':
					*clr & cla
					gs 'porn_view_construct', 'wdays'
					act 'Уйти': gt 'gorodok'
				end
			else
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/4.webm', func('porn_view_strings', 'view_37')
					gs 'zz_render', '', '', func('porn_view_strings', 'view_37'+iif(vagina<30,'_no_more','_more'))
					gs 'zz_render', '', '', func('porn_view_strings', 'view_37_next')
					act '...':
						*clr & cla
						i = rand(0,10)
						if i < 5: gs 'porn_view_construct', 'random'
						if i >= 5 and i < 9: gs 'porn_view_construct', 'dp'
						if i >= 9: gs 'porn_view_construct', 'no_pussy'
						$npc['39,qwPornoFootball'] += 1
						act 'Уйти': gt 'gorodok'
					end
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] = 40:
		act '...':
			horny = 0
			gang += 1
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/5.webm', func('porn_view_strings', 'view_40')
			if mesec > 0:
				act '...':
					*clr & cla
					gs 'porn_view_construct', 'wdays'
					act 'Уйти': gt 'gorodok'
				end
			else
				act '...':
					*clr & cla
					gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_2/10.webm', func('porn_view_strings', 'view_36_dp0')+func('porn_view_strings', 'view_36_dp'+iif(vagina>=30,2,1))
					if tabletki = 0 and prezik = 0: gs 'zz_render', '', '', func('porn_view_strings', 'view_cum_in_mind'+rand(0,2))
					gs 'zz_render', '', '', func('porn_view_strings', 'view_36_fin')
					anal += 1
					sex += 2
					bj += 3
					vagina += 1
					if anus <= 10: anus += 1
					$npc['39,qwPornoFootball'] += 1
					act 'Уйти': gt 'gorodok'
				end
			end
		end
	elseif $npc['39,qwPornoFootball'] > 40:
		act '...':
			horny = 0
			gang += 1
			gs 'zz_bathroom', 'clean_me'
			hapri = 1
			*clr & cla
			gs 'zz_render', '', 'images/pavlovo/family/brother/porn_view/after_3/6.webm', func('porn_view_strings', 'view_40')
			gs 'zz_render', '', '', func('porn_view_strings', 'view_41')
			if mesec > 0:
				act '...':
					*clr & cla
					gs 'porn_view_construct', 'wdays'
					act 'Уйти': gt 'gorodok'
				end
			else
				act '...':
					*clr & cla
					i = rand(0,10)
					if i < 5: gs 'porn_view_construct', 'random'
					if i >= 5 and i < 9: gs 'porn_view_construct', 'dp'
					if i >= 9: gs 'porn_view_construct', 'no_pussy'
					act 'Уйти': gt 'gorodok'
				end
			end
		end
	end
end