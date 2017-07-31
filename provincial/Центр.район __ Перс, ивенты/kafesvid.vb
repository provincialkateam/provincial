minut += 60
manna += 10
gs 'stat'
gs 'zz_render', 'Кафе', 'images/img/kafesvid/0.jpg', func('kafesvid_strings', 'local_str1')
act 'Болтать':
	if $telsob = 'Алла':
		alla += 1
		gt 'kafesvid',iif(alla >= 20,str(rand(3,11)/3),'3')
	elseif $telsob = 'Маша':
		masha += 1
		gt 'kafesvid',iif(masha >= 20,str(rand(3,11)/3),'3')
	elseif $telsob = 'Катя':
		gs 'npc_editor','change_rep','+', 33
		gt 'kafesvid',iif($npc['33,relation'] >= 20,str(rand(3,11)/3),'3')
	end
end
if $ARGS[0] = '1':
	*clr & cla
	gs 'zz_render', '', 'images/img/kafesvid/1.jpg', func('kafesvid_strings', 'local_str2')
	act 'Отодвинуться': gt'kafesvid','3'
	act 'Потрогать её':
		*clr & cla
		gs 'zz_render', '', 'images/img/kafesvid/2.jpg', func('kafesvid_strings', 'local_str3')
		act 'Ну не здесь же': gt'kafesvid','3'
		act 'Позволить ей':
			*clr & cla
			lesbian += 1
			gs 'zz_render', '', 'images/img/kafesvid/3.jpg', func('kafesvid_strings', 'local_str4')
			act 'Встать раком':
				*clr & cla
				orgasm += 1
				gs 'zz_render', '', 'images/img/kafesvid/5.jpg', func('kafesvid_strings', 'local_str5')
				act 'Продолжить': gt'kafesvid','10'
			end
			act 'Полизать ей':
				*clr & cla
				gs 'zz_render', '', 'images/img/kafesvid/4.jpg', func('kafesvid_strings', 'local_str6')
				act 'Продолжить': gt'kafesvid','10'
			end
		end
	end
end
if $ARGS[0] = '10':
	*clr & cla
	gs 'zz_render', '', 'images/img/kafesvid/6.jpg', func('kafesvid_strings', 'local_str7')
	act 'Ей в киску': gt'kafesvid','11'
	act 'Ей в попку': gt'kafesvid','12'
	act 'Себе в киску': gt'kafesvid','13'
	act 'Закончить': gt'kafesvid','3'
end
if $ARGS[0] = '11':
	*clr & cla
	kafesvidsex += 1
	gs 'zz_render', '', 'images/img/kafesvid/8.jpg', func('kafesvid_strings', 'local_str8')
	if kafesvidsex < 3:
		act 'Ей в попку': gt'kafesvid','12'
		act 'Себе в киску': gt'kafesvid','13'
	end
	act 'Закончить': gt'kafesvid','3'
end
if $ARGS[0] = '12':
	*clr & cla
	kafesvidsex += 1
	gs 'zz_render', '', 'images/img/kafesvid/9.jpg', func('kafesvid_strings', 'local_str9')
	if kafesvidsex < 3:
		act 'Ей в киску': gt'kafesvid','11'
		act 'Себе в киску': gt'kafesvid','13'
	end
	act 'Закончить': gt'kafesvid','3'
end
if $ARGS[0] = '13':
	*clr & cla
	orgasm += 1
	vagina += 1
	kafesvidsex += 1
	gs 'zz_render', '', 'images/img/kafesvid/7.jpg', func('kafesvid_strings', 'local_str10')
	if kafesvidsex < 3:
		act 'Ей в киску': gt'kafesvid','11'
		act 'Ей в попку': gt'kafesvid','12'
	end
	act 'Закончить': gt'kafesvid','3'
end
if $ARGS[0] = '2':
	*clr & cla
	gs 'zz_render', '', 'images/img/kafesvid/10.jpg', func('kafesvid_strings', 'local_str11')
	act 'Только попробуй, яйца отрежу':gt'kafesvid','3'
	act 'Не сопротивляться':
		*clr & cla
		gs 'zz_render', '', 'images/img/kafesvid/11.jpg', func('kafesvid_strings', 'local_str12')
		act 'Отказаться': gt'kafesvid','3'
		act 'Взять в руку':
			*clr & cla
			hj += 1
			gs 'zz_render', '', 'images/img/kafesvid/12.jpg', func('kafesvid_strings', 'local_str13')
			act 'Принять в рот':
				*clr & cla
				dom -= 1
				gs 'zz_funcs', 'cum', 'face'
				swallow += 1
				gs 'zz_render', '', 'images/img/kafesvid/16.jpg', func('kafesvid_strings', 'local_str14')
			end
			act 'Продолжить дрочить':
				*clr & cla
				gs 'zz_render', '', 'images/img/kafesvid/12.jpg', func('kafesvid_strings', 'local_str15')
				act 'Слизать сперму':
					*clr & cla
					dom -= 1
					swallow += 1
					gs 'zz_render', '', 'images/img/kafesvid/14.jpg', func('kafesvid_strings', 'local_str16')
					act 'Закончить': gt'kafesvid','3'
				end
				act 'Не трогать сперму':
					*clr & cla
					gs 'zz_render', '', 'images/img/kafesvid/15.jpg', func('kafesvid_strings', 'local_str17')
					act 'Закончить': gt'kafesvid','3'
				end
			end
		end
		act 'Взять в рот':
			*clr & cla
			bj += 1
			gs 'zz_render', '', 'images/img/kafesvid/13.jpg', func('kafesvid_strings', 'local_str18')
			act 'Встать раком':
				*clr & cla
				sex += 1
				gs 'zz_render', '', 'images/img/kafesvid/17.jpg', func('kafesvid_strings', 'local_str19')
				act 'Лечь на стол':
					*clr & cla
					gs 'zz_render', '', 'images/img/kafesvid/18.jpg', func('kafesvid_strings', 'local_str20')
					act 'Встать раком':
						*clr & cla
						gs 'zz_funcs', 'cum', 'anus'
						anal += 1
						analorgasm += 1
						orgasm += 1
						gs 'zz_render', '', 'images/img/kafesvid/19.jpg', func('kafesvid_strings', 'local_str21')
						act 'Нет, хватит': gt'kafesvid','3'
						act 'Поднять':
							*clr & cla
							bj += 1
							gs 'zz_funcs', 'cum', 'face'
							gs 'zz_render', '', 'images/img/kafesvid/20.jpg', func('kafesvid_strings', 'local_str22') + func('kafesvid_strings', 'local_str23')
							act 'Запрыгнуть на член':
								*clr & cla
								analorgasm += 5
								orgasm += 5
								anus += 1
								gs 'zz_render', '', 'images/img/kafesvid/21.jpg', func('kafesvid_strings', 'local_str24')
								act 'Открыть рот':
									*clr & cla
									gs 'zz_funcs', 'cum', 'face'
									gs 'zz_funcs', 'cum', 'lip'
									swallow += 1
									gs 'zz_render', '', 'images/img/kafesvid/22.jpg', func('kafesvid_strings', 'local_str25')
									act 'Поцеловать <<$telsob>>':
										*clr & cla
										gs 'zz_render', '', 'images/img/kafesvid/23.jpg', func('kafesvid_strings', 'local_str26')
										act 'Закончить': gt'kafesvid','3'
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
if $ARGS[0] = '3':
	cla
	kafesvidsex = 0
	horny = 0
	minut += 60
	gs 'stat'
	gs 'zz_render', '', '', func('kafesvid_strings', 'local_str27')
	act 'Уйти': gt'down'
end