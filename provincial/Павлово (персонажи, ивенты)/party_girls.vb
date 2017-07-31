if $ARGS[0] = 'talk':
	*clr & cla
	minut += 5
	party_girls_talk += 1
	gs 'stat'
	i = rand(2,19)
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_2_<<i>>.jpg', func('party_girls_strings', 'local_str1') + func('party_girls_strings', 'local_str'+i)
	act 'Отойти': gt'sbReksHome','party_home'
end
if $ARGS[0] = 'smoke':
	*clr & cla
	minut += 5
	gs 'stat'
	if girls_smoke = 0:
		girls_smoke = 1
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_3_1.jpg', func('party_girls_strings', 'local_str20')
		act 'Курить':gt'party_girls','smoke'
		act 'Отойти':gt'sbReksHome','party_home'
	else
		girls_smoke += 1
		manna += 30
		horny += 30
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_3_' + rand(2,6) + '.jpg', func('party_girls_strings', 'local_str21')
		act 'Кайфовать':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_4_'+rand(1,7)+'.jpg', func('party_girls_strings', 'local_str'+rand(22,26))
			act 'Отойти':gt'sbReksHome','party_home'
		end
	end
end
if $ARGS[0] = 'fun':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_5_'+rand(1,6)+'.jpg', func('party_girls_strings', 'local_str27')
	act 'Веселиться':
		fun_rand = rand(1,3)
		if fun_rand = 1:
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_1_'+rand(1,6)+'.jpg', func('party_girls_strings', 'local_str28') + iif(Rex_Love = 1,func('party_girls_strings', 'local_str74'),'')
			act 'Вилять попкой':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_1_'+rand(7,11)+'.jpg', func('party_girls_strings', 'local_str29') + func('party_girls_strings', 'local_str30')
				act 'Отойти': gt'sbReksHome','party_home'
			end
		elseif fun_rand = 2:
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_'+rand(1,5)+'.jpg', func('party_girls_strings', 'local_str31')
			act 'Дальше':
				if rand(1,2) = 1:
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_6_' + rand(1,5) + '.jpg', func('party_girls_strings', 'local_str32')
					act 'Отойти':gt'sbReksHome','party_home'
					if horny > 50 and ($npc['27,relation']>=80 or Rex_Love = 0):
						act 'Стонать':
							*clr & cla
							minut += 5
							horny += 10
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_6_'+ rand(6,7)+'.gif', func('party_girls_strings', 'local_str33')
							act 'Отдаться':
								*clr & cla
								minut += 5
								sex += 1
								if Rex_Love = 0:
									guy += 1
								else
									sexa += 1
								end
								if rexSex = 0: rexSex = 1 & guy += 1
								gs 'stat'
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_6_8.jpg', func('party_girls_strings', 'local_str34')
								act 'Кончить':
									*clr & cla
									minut += 5
									horny += 10
									gs 'stat'
									gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_6_9.jpg', func('party_girls_strings', 'local_str35')
									act 'Отойти': gt'sbReksHome','party_home'
								end
							end
						end
					end
				else
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_7_'+rand(1,5)+'.jpg', func('party_girls_strings', 'local_str36')
					act 'Отойти':gt'sbReksHome','party_home'
					if horny > 50:
						act 'Стонать':
							*clr & cla
							minut += 10
							orgasm += 1
							horny = 0
							manna = 100
							lesbian += 1
							gs 'stat'
							if rand(1,2) = 1:
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_7_6.jpg', func('party_girls_strings', 'local_str37')
							else
								gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_7_7.jpg', func('party_girls_strings', 'local_str38')
							end
							act 'Отойти':gt'sbReksHome','party_home'
						end
					end
				end
			end
		elseif fun_rand = 3:
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_8_'+rand(1,3)+'.jpg', func('party_girls_strings', 'local_str39')
			act 'Отойти': gt'sbReksHome','party_home'
			if horny > 50:
				act 'Пососать':
					*clr & cla
					minut += 5
					bj += 1
					if Rex_Love = 1: bja += 1
					gs 'stat'
					if rand(1,2) = 1:
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_8_4.jpg', func('party_girls_strings', 'local_str41')
					else
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_8_5.jpg', func('party_girls_strings', 'local_str42')
					end
					act 'Кончать':
						*clr & cla
						minut += 5
						gs 'zz_funcs', 'cum', 'lip'
						gs 'zz_funcs', 'cum', 'face'
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_home_fun_2_8_' + rand(6,12) + '.jpg', func('party_girls_strings', 'local_str40')
						act 'Отойти': gt'sbReksHome','party_home'
					end
				end
			end
		end
	end
end
if $args[0] = 'party_girls_drunk':
	*clr & cla
	minut += 5
	drunk_sveta += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_3_'+iif(rand(1,2)=1,'1.gif',rand(2,3)+'.jpg'), func('party_girls_strings', 'local_str43')
	act 'Отрубиться':dynamic $Party_sleep
end
if $args[0] = 'party_girls_rex':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_7.jpg', func('party_girls_strings', 'local_str44')
	act 'Кончить':
		*clr & cla
		minut += 5
		bj += 1
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_funcs', 'cum', 'face'
		cumfrot += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_8.jpg', func('party_girls_strings', 'local_str45')
		act 'Отойти':gt 'sbReksHome','party_toilet'
	end
end
if $args[0] = 'party_girls_bra':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_5_'+rand(1,3)+'.jpg', func('party_girls_strings', 'local_str46')
	if Rex_Love = 1: 'За вами пристально наблюдает Рекс, но ничего не говорит.'
	act 'Отойти':gt $loc,$metka
	act 'Танцевать топлес':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_6_'+rand(1,3)+'.jpg', func('party_girls_strings', 'local_str47')
		if Rex_Love = 1:
			gs 'zz_render', '', '', func('party_girls_strings', 'local_str48')
			act 'Потащить его в туалет': gt 'party_girls','party_girls_rex'
		end
		act 'Отойти': gt $loc, $metka
		act 'Раздеться':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_9_'+iif(rand(1,2)=1,'1.jpg','2.gif'), iif(Rex_Love=1,func('party_girls_strings', 'local_str49'),'')+func('party_girls_strings', 'local_str49')
			act 'Идти с парнями':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_10.jpg', func('party_girls_strings', 'local_str50')
				act 'Сосать':
					*clr & cla
					minut += 5
					bj += 1
					guy += 3
					gang += 1
					sex += 1
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_11.jpg', func('party_girls_strings', 'local_str51')
					act 'Убрать руки':
						*clr & cla
						minut += 5
						gs 'stat'
						gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_12_'+iif(rand(1,2)=1,'1.gif','3.jpg'), func('party_girls_strings', 'local_str52')
						act 'Кончить':
							*clr & cla
							minut += 5
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_funcs', 'cum', 'face'
							cumfrot += 1
							gs 'stat'
							gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_13.jpg', func('party_girls_strings', 'local_str53')
							act 'Отойти':gt 'sbReksHome','party_toilet'
						end
					end
				end
			end
		end
	end
end
if $args[0] = 'party_girls_drink':
	*clr & cla
	gs 'zz_funcs', 'alko'
	drunk_sveta += 1
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_2_'+iif(rand(1,2)=1,'1.gif',rand(2,4)+'.jpg'), func('party_girls_strings', 'local_str54')
	if alko >= 7:
		gs 'zz_render','','','Сильно кружится голова, вам становится очень плохо.'
		act 'Отрубиться':dynamic $Party_sleep
	end
	if alko < 7:
		act 'Отойти': gt $loc,$metka
		act 'Выпить еще': gt 'party_girls','party_girls_drunk'
		act 'Снять лифчик': gt 'party_girls','party_girls_bra'
	end
end
if $args[0] = 'party_girls_boys':
	*clr & cla
	minut += 5
	i = rand(1,2)
		if i = 1:
		gs 'zz_funcs', 'cum', 'lip'
		gs 'zz_funcs', 'cum', 'face'
		cumfrot += 1
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_19.jpg', func('party_girls_strings', 'local_str55') + func('party_girls_strings', 'local_str56')
		act 'Отойти': gt $loc,$metka
	else
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_20_'+rand(1,2)+'.jpg', func('party_girls_strings', 'local_str57')
		act 'Дальше':
			*clr & cla
			minut += 30
			gs 'zz_funcs', 'cum', 'lip'
			gs 'zz_funcs', 'cum', 'face'
			cumfrot += 1
			bj += 1
			guy += 1
			gang += 1
			sex += 1
			vagina += 1
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_21_'+rand(1,6)+'.jpg', func('party_girls_strings', 'local_str58')
			gs 'zz_funcs', 'cum', 'pussy'
			act 'Уснуть':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_6_'+rand(1,9)+'.jpg', func('party_girls_strings', 'local_str59')
				act 'Проснуться':
					*clr & cla
					minut += 90
					gs 'stat'
					gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_7.jpg', func('party_girls_strings', 'local_str60')
					act 'Идти домой':gt 'bedrPar'
				end
			end
		end
	end
end
if $args[0] = 'party_girls_girls':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_16_'+rand(1,2)+'.jpg', func('party_girls_strings', 'local_str61')
	act 'Продолжить':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_17_'+iif(rand(1,2)=1,rand(1,3)+'.gif',rand(4,5)+'.jpg'), func('party_girls_strings', 'local_str62')
		act 'Уснуть':
			*clr & cla
			minut += 5
			gs 'stat'
			gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_18_'+rand(1,2)+'.jpg', func('party_girls_strings', 'local_str63')
			act 'Проснуться':
				*clr & cla
				minut += 90
				gs 'stat'
				gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_kuh_7.jpg', func('party_girls_strings', 'local_str64')
				act 'Идти домой':gt 'bedrPar'
			end
		end
	end
end
if $args[0] = 'party_girls_dirty':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_14_'+rand(1,4)+'.jpg', func('party_girls_strings', 'local_str65')+iif(Rex_Love=1,func('party_girls_strings', 'local_str72'),'') + func('party_girls_strings', 'local_str66')
	act 'Отойти': gt $loc,$metka
	act 'Веселиться':
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls_party_gost_15_'+rand(1,8)+'.jpg', func('party_girls_strings', 'local_str67')
		if rand(1,2) = 1:
			act 'Развлечься с парнями': gt 'party_girls','party_girls_boys'
		else
			act 'Идти в комнату': gt 'party_girls','party_girls_girls'
		end
	end
end
if $args[0] = 'party_girls_dance':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'pavlovo/family/sister/sisterQW/ReksHome/reksParty_party_gost_1_' + rand(1,7) + '.gif', func('party_girls_strings', 'local_str68') + func('party_girls_strings', 'local_str'+iif(dance<50,'70','71'))
	act 'Передохнуть': gt $loc,$metka
	act 'Танцевать еще': gt 'party_girls','party_girls_dirty'
end
if $ARGS[0] = 'party_girls':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', 'Девушки', 'pavlovo/family/sister/sisterQW/ReksHome/Party_girls'+iif($metka = 'party_home','','_party_gost_1_'+rand(1,4))+'.jpg', func('party_girls_strings', 'local_str69')
	act 'Отойти': gt $loc,$metka
	if $metka = 'party_gost':
		act 'Выпить': gt 'party_girls','party_girls_drink'
		act 'Танцевать вместе': gt 'party_girls','party_girls_dance'
	end
	if $metka = 'party_home' and alko < 6: act 'Предлагают выпить': gt'sbReksHome','party_drink'
end