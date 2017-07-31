$boy = 'Артем'
dick = 16
silavag = 0
frost = 0
	if $npc['2,qwartem'] = 21:
		gt'ArtemEv3','slut_talk'
		exit
	elseif $npc['2,qwartem'] = 22:
		gt'ArtemEv3','home_start'
		exit
	elseif ($npc['2,qwArtemHack'] = 1 or ($npc['2,qwartem'] = 4 and $npc['2,qwArtemHack'] = 2)) and artomhakday ! daystart and artemblag = 0:
		!Наврала, отказала
		*clr & cla
		DimaRudeBlock = 1
		gs 'zz_render', '', '', func('artemhome_strings', '1')
		act 'На колени':
			*clr & cla
			minut += 5
			bj += 1
			if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/artom/meet/hack_1.jpg', func('artemhome_strings', '2')
			act 'Отдышаться':
				*clr & cla
				gs 'zz_render', '', 'common/npc/1.jpg', func('artemhome_strings', '3')
				act 'Вырваться и убежать':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/artom/meet/hack_2.jpg', func('artemhome_strings', '4')
					act 'Идти с парнями':
						*clr & cla
						minut += 15
						gs 'stat'
						'<center><img src="images/qwest/alter/artom/meet/hack_3.jpg"></center>'
						gs 'zz_render', '', '', func('artemhome_strings', '5')
						act 'Раздеться':
							*clr & cla
							gs 'stat'
							'<center><img src="images/qwest/alter/artom/meet/hack_4.jpg"></center>'
							gs 'zz_render', '', '', func('artemhome_strings', '6')
							act 'Встать раком':
								*clr & cla
								minut += 15
								vagina += 1
								anus += 1
								gs 'stat'
								'<center><img src="images/qwest/alter/artom/meet/hack_5.jpg"></center>'
								gs 'zz_render', '', '', func('artemhome_strings', '7')
								act 'Покорно ждать':
									*clr & cla
									'<center><img src="images/qwest/alter/artom/meet/hack_6.jpg"></center>'
									gs 'zz_render', '', '', func('artemhome_strings', '8')
									act 'Сосать':
										*clr & cla
										minut += 15
										bj += 2
										if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
										if $npc['1,sex'] = 0: $npc['1,sex'] = 1 & guy += 1
										gang += 1
										gs 'zz_funcs', 'cum', 'face'
										$npc['2,qwArtemHack'] = 10
										artemblok = 1
										gs 'stat'
										'<center><img src="images/qwest/alter/artom/meet/hack_7.jpg"></center>'
										gs 'zz_render', '', '', func('artemhome_strings', '9')
										act 'Посмотреть на Артёма':
											*clr & cla
											'<center><img src="images/qwest/alter/artom/2.jpg"></center>'
											gs 'zz_render', '', '', func('artemhome_strings', '10')
											act 'Возмутится':
												*clr & cla
												'<center><img src="images/qwest/alter/artom/meet/hack_8.jpg"></center>'
												gs 'zz_render', '', '', func('artemhome_strings', '11')
												act 'Одеться и уйти': gt 'gorodok'
											end
										end
										act 'Одеться и уйти': gt 'gorodok'
									end
								end
							end
						end
					end
				end
			end
		end
		act 'Вырваться и убежать':
			artomvbrosvid = 1
			artemblok = 1
			artomhakday = daystart
			gt'pod_ezd','etaj_1'
		end
	elseif ($npc['2,qwArtemHack'] = 2 or ($npc['2,qwArtemHack'] = 1 and artemblag = 1)) and artomhakday ! daystart:
		$npc['2,qwArtemHack'] = 7
		!правда
		DimaRudeBlock = 1
		gs 'zz_render', '', '', func('artemhome_strings', '12')
	end
	if artemtimes >= 15 and $npc['2,qwartem'] = 0 and school['homework'] > 0 and GorSlut < 2:$npc['2,qwartem'] = 1 & gt'artemev2'
	gs 'zz_render', '', '', func('artemhome_strings', '13')
	if rand(0,1) = 1 and artemtimes >= 45 and $npc['2,qwSex'] = 0 and artomanal > 0 and artomProgul ! day and (GorSlut < 2 or artemblag = 1):
		artomProgul = day
		cla
		gs 'stat'
		if rand(0,1) = 0:
			gs 'zz_render', '', '', func('artemhome_strings', '14')
			act 'Согласиться':
				gs 'zz_render', '', '', func('artemhome_strings', '15')
				act 'Гулять':dynamic $artomSkver
			end
			act 'Отказаться': gt $curloc
		else
			gs 'zz_render', '', '', func('artemhome_strings', '16')
			act 'Согласиться':
				gs 'zz_render', '', '', func('artemhome_strings', '17')
				act 'Заниматься':dynamic $artomBibl
			end
			act 'Отказаться': gt $curloc
		end
	end
	if $npc['2,qwartem'] = 2:
		!взяла цветы но не дрочила артему
		artcooldown += 1
		if artcooldown >= 10:artcooldown = 0 & $npc['2,qwartem'] = 1 & gt'artemev2'
	elseif $npc['2,qwartem'] = 3 and artomkissday ! daystart:
		!дрочила артему
		gs 'zz_render', '', '', func('artemhome_strings', '18')
		dynamic $artomKiss
	elseif $npc['2,qwartem'] >= 2 and $npc['2,qwartem'] <= 3 and artemtimes >= 30 and school['progress'] >= 90 and GorSlut < 2:
		$npc['2,qwartem'] = 10
		gt'artemev2'
	elseif $npc['2,qwartem'] = 20 and artomkissday ! daystart:
		gs 'zz_render', '', '', func('artemhome_strings', '19')
		dynamic $artomKiss
	end
	if $npc['1,qwDimaFilm'] > 0 and $npc['2,qwArtemHack'] = 0 and vagina > 0:
		act 'Попросить Артема украсть видео снятое Димой с вами':
			*clr & cla
			minut += 15
			gs 'stat'
			'<center><img src="images/qwest/alter/artom/2.jpg"></center>'
			gs 'zz_render', '', '', func('artemhome_strings', '20')
			act 'Соврать':
				*clr & cla
				minut += 5
				artomhakday = daystart
				$npc['2,qwArtemHack'] = 1
				gs 'stat'
				'<center><img src="images/qwest/alter/artom/2.jpg"></center>'
				gs 'zz_render', '', '', func('artemhome_strings', '21')
				if school['homework'] > 0:
					dynamic $din_artom_lern
				else
					act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
				end
			end
			act 'Сказать правду':
				*clr & cla
				minut += 5
				artomhakday = daystart
				$npc['2,qwArtemHack'] = 2
				gs'stat'
				'<center><img src="images/qwest/alter/artom/2.jpg"></center>'
				gs 'zz_render', '', '', func('artemhome_strings', '22')
				if school['homework'] > 0:
					dynamic $din_artom_lern
				else
					act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
				end
			end
		end
	end
	if school['homework'] > 0:dynamic $din_artom_lern
	act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
	if talkartemday ! daystart:
		act 'Болтать с Артемом':
			*clr & cla
			artemtimes += 1
			talkartemday = daystart
			minut += 60
			manna += 10
			gs 'stat'
			gs 'zz_render', 'common/npc/2.jpg', '', func('artemhome_strings', '23')
			act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
		end
	end