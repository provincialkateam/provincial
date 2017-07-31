$din_artom_bj = {
	act 'Сосать':
		*clr & cla
		minut += 5
		horny += 10
		bj += 1
		if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
		artomBJQW += 1
		dom -= 1
		dick = 16
		gs'stat'
		'<center><img src="images/qwest/alter/artom/bj_'+ rand(1,6) +'.jpg"></center>'
		gs 'zz_dynamic_sex', 'bj'
		gs 'zz_dynamic_sex', 'swallow'
		act 'Далее': gt'artemhome'
	end
}
$din_artom_leghump = {
	act 'Позволить Артему ласкать вашу попу':
		*clr & cla
		minut += 5
		horny += 10
		hump += 1
		if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
		leghumpArtom += 1
		dom += 1
		dick = 16
		cumfrot += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/artomHump.jpg', func('artemEv_strings', '1')
		cumfrot = 0
		if school['homework'] > 0:
			dynamic $din_artom_lern
		else
			act 'Далее': gt'artemhome'
			act 'Идти домой': minut += 5 & gt'pod_ezd','etaj_1'
		end
	end
}
$din_artom_leghump2 = {
	if dom > 0:
		act 'Снять одежду и позволить Артему тереться о вас':
			*clr & cla
			minut += 5
			horny += 10
			hump += 1
			if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
			leghumpArtom += 1
			dom += 1
			dick = 16
			gs 'zz_funcs', 'cum', 'ass'
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/Ev/artomHump2.jpg', func('artemEv_strings', '2')
			if school['homework'] > 0:
				dynamic $din_artom_lern
			else
				act 'Далее': gt'artemhome'
				act 'Идти домой': minut += 5 & gt'pod_ezd','etaj_1'
			end
		end
	end
}
$din_artom_lern = {
	act 'Заниматься с Артемом':
		*clr & cla
		minut += 60
		$npc['2,relation'] += 10
		school['homework'] = 0
		school['intellect'] += 1
		artemtimes += 1
		ArtomBeInHome = 1
		gs'stat'
		act 'Передохнуть': gt 'artemhome'
		gs 'zz_render', '', 'common/npc/2.jpg', func('artemEv_strings', '3')
		if $npc['2,relation'] >= 90:
			gs 'zz_render', '', '', func('artemEv_strings', '4')
		end
		if GorSlut >= 2 and artemblag = 0:
			if artomBJQW = 0 and $npc['2,qwSex'] = 0:
				cla
				gs 'zz_render', '', '', func('artemEv_strings', '5')
				dynamic $din_artom_bj
				act 'Нет':
					*clr & cla
					dom += 1
					artomLernQW = 0
					artemblok = 1
					$npc['2,relation'] = 0
					gs'stat'
					gs 'zz_render', '', '', func('artemEv_strings', '6')
					act 'Идти домой':gt'pod_ezd','etaj_1'
				end
			elseif (artomBJQW > 0 and artomBJQW < 10 and $npc['2,qwSex'] = 0) or (artomStripSee = 3 and $npc['2,qwSex'] = 0 and artomTouch > daystart):
				cla
				gs 'zz_render', '', '', func('artemEv_strings', '7')
				dynamic $din_artom_bj
			elseif artomBJQW = 10 and $npc['2,qwSex'] = 0:
				cla
				gs 'zz_render', '', '', func('artemEv_strings', '8')
				if dom >= 30 and $npc['1,qwDimaFilm'] > 0 and $npc['2,qwArtemHack'] = 0 and vagina > 0:
					act 'Согласиться в обмен на услугу':
						*clr & cla
						minut += 5
						artomhakday = daystart
						$npc['2,qwArtemHack'] = 1
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/anatomy.jpg', func('artemEv_strings', '9')
						artomStripSee = 1
						gs 'zz_render', '', '', func('artemEv_strings', '10')
						dynamic $din_artom_bj
					end
				else
					act 'Согласиться':
						*clr & cla
						minut += 5
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/anatomy.jpg', func('artemEv_strings', '11')
						money += 300
						artomStripSee = 1
						gs 'zz_render', '', '', func('artemEv_strings', '12')
						dynamic $din_artom_bj
					end
				end
			elseif artomBJQW > 10 and artomStripSee < 2 and $npc['2,qwSex'] = 0:
				artomRand = rand(0,5)
				*clr & cla
				gs'stat'
				if artomRand = 5:
					gs 'zz_render', '', '', func('artemEv_strings', '13')
					artomStripSee = 2
					act 'Раздеться':
						minut += 5
						gs 'zz_render', '', 'images/qwest/alter/artom/anatomy2.jpg', func('artemEv_strings', '14')
						money += 300
						gs 'zz_render', '', '', func('artemEv_strings', '15')
						dynamic $din_artom_bj
					end
				else
					gs 'zz_render', '', '', func('artemEv_strings', '16')
					dynamic $din_artom_bj
				end
			elseif artomStripSee = 2 and $npc['2,qwSex'] = 0:
				*clr & cla
				money += 500
				minut += 5
				artomTouch = daystart + 7
				artomStripSee = 3
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '17')
				act 'Дать себя потрогать':
					if horny >= 80:
						*clr & cla
						minut += 5
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/anatomy3_1.jpg', func('artemEv_strings', '18')
						act 'Получать удовольствие':
							*clr & cla
							orgasm += 1
							horny = 0
							manna = 100
							minut += 5
							gs'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/anatomy3_2.jpg', func('artemEv_strings', '19')
							artomHorny = 1
							act 'Идти домой': minut += 5 & gt'pod_ezd','etaj_1'
						end
					else
						*clr & cla
						minut += 5
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/anatomy3_1.jpg', func('artemEv_strings', '20')
						artomHorny = 0
						dynamic $din_artom_bj
					end
				end
			elseif artomStripSee = 3 and $npc['2,qwSex'] = 0 and artomTouch <= daystart:
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '21')
				artomStripSee = 4
				if artomHorny = 1:
					gs 'zz_render', '', '', func('artemEv_strings', '22')
				else
					gs 'zz_render', '', '', func('artemEv_strings', '23')
				end
				act 'Далее': gt'artemhome'
			elseif artomStripSee = 4:
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '24')
				act 'Отказаться':
					*clr & cla
					dom += 1
					artomLernQW = 0
					artemblok = 1
					$npc['2,relation'] = 0
					gs'stat'
					gs 'zz_render', '', '', func('artemEv_strings', '25')
					act 'Идти домой': minut += 5 & gt'pod_ezd','etaj_1'
				end
				act 'Согласиться':
					$npc['2,qwArtomAndPetja'] = 1
					artomStripSee = 5
					gs 'zz_render', '', '', func('artemEv_strings', '26')
					act 'Далее': gt'artemhome'
				end
			elseif $npc['2,qwArtomAndPetja'] = 1:
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '27')
				act 'Показать сиськи':
					*clr & cla
					minut += 5
					horny += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy1_1.jpg', func('artemEv_strings', '28')
					act 'Растягивать':
						*clr & cla
						minut += 5
						horny += 10
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy1_2.jpg', func('artemEv_strings', '29')
						act 'Взять деньги':
							*clr & cla
							orgasm += 1
							horny = 0
							manna = 100
							minut += 10
							money += 1000
							$npc['2,qwArtomAndPetja'] = 2
							gs'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '30')
							act 'Идти домой': minut += 15 & gt'gorodok'
						end
					end
				end
			elseif $npc['2,qwArtomAndPetja'] >= 2 and $npc['2,qwArtomAndPetja'] <= 10:
				if $npc['2,qwArtomAndPetja'] >= 3:
					ArtomAndPetjaRand = rand(0,1)
				else
					ArtomAndPetjaRand = rand(0,5)
				end
				if ArtomAndPetjaRand ! 0:
					gs 'zz_render', '', '', func('artemEv_strings', '31')
					dynamic $din_artom_bj
				else
					*clr & cla
					minut += 5
					horny += 10
					bj += 2
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					if $npc['6,sex'] = 0: $npc['6,sex'] = 1 & guy += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy2_1.jpg', func('artemEv_strings', '32')
					act 'Наездница':
						*clr & cla
						minut += 5
						horny += 10
						vagina += 1
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy2_2.jpg', func('artemEv_strings', '33')
						act 'Поменяться местами':
							*clr & cla
							horny += 10
							artomBJQW += 1
							dom -= 1
							swallow += 1
							gs 'zz_funcs', 'cum', 'lip'
							gang += 1
							minut += 10
							money += 1000
							gs'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy2_3.jpg', func('artemEv_strings', '34')
							$npc['2,qwArtomAndPetja'] += 1
							act 'Идти домой': minut += 15 & gt'gorodok'
						end
					end
				end
			elseif $npc['2,qwArtomAndPetja'] = 11:
				*clr & cla
				minut += 10
				horny += 10
				if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
				if $npc['6,sex'] = 0: $npc['6,sex'] = 1 & guy += 1
				vagina += 1
				dom -= 1
				cumass += 2
				gang += 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy3.jpg', func('artemEv_strings', '35')
				act 'Закончить урок':
					*clr & cla
					minut += 5
					money += 1000
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '36')
					$npc['2,qwArtomAndPetja'] = 12
					act 'Идти домой': minut += 15 & gt'gorodok'
				end
			elseif $npc['2,qwArtomAndPetja'] = 12:
				minut += 5
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy4_1.jpg', func('artemEv_strings', '37')
				act 'Поменяться местами':
					*clr & cla
					orgasm += 1
					horny = 0
					manna = 100
					bj += 1
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					if $npc['6,sex'] = 0: $npc['6,sex'] = 1 & guy += 1
					artomBJQW += 1
					dom -= 1
					swallow += 1
					gs 'zz_funcs', 'cum', 'face'
					gang += 1
					minut += 10
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy4_2.jpg', func('artemEv_strings', '38')
					$npc['2,qwArtomAndPetja'] = 13
					act 'Идти домой': minut += 15 & gt'gorodok'
				end
			elseif $npc['2,qwArtomAndPetja'] = 13:
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '39')
				act 'Сходить сделать клизму':
					*clr & cla
					minut += 15
					horny += 10
					bj += 1
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					if $npc['6,sex'] = 0: $npc['6,sex'] = 1 & guy += 1
					artomBJQW += 1
					swallow += 1
					gs 'zz_funcs', 'cum', 'lip'
					anus += 1
					dom -= 1
					gs 'zz_funcs', 'cum', 'anus'
					gang += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy5.jpg', func('artemEv_strings', '40')
					act 'Закончить урок':
						*clr & cla
						minut += 10
						money += 1000
						gs'stat'
						gs 'zz_render', '', '', func('artemEv_strings', '41')
						$npc['2,qwArtomAndPetja'] = 14
						act 'Идти домой': minut += 5 & gt'pod_ezd','etaj_1'
					end
				end
			elseif $npc['2,qwArtomAndPetja'] = 14:
				*clr & cla
				minut += 5
				horny += 10
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy6_1.jpg', func('artemEv_strings', '42')
				act 'Покорно выполнять команды ребят':
					*clr & cla
					bj += 2
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					if $npc['6,sex'] = 0: $npc['6,sex'] = 1 & guy += 1
					artomBJQW += 1
					swallow += 1
					gs 'zz_funcs', 'cum', 'lip'
					vagina += 1
					anus += 1
					dom -= 3
					gang += 1
					minut += 30
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy6_2.jpg', func('artemEv_strings', '43')
					act 'Выпить':
						*clr & cla
						minut += 5
						water += 10
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/ap_anatomy6_3.jpg', func('artemEv_strings', '44')
						$npc['2,qwArtomAndPetja'] = 15
						$npc['2,qwArtemHack'] = 10
						artemblok = 1
						act 'Идти домой': minut += 15 & gt'gorodok'
					end
				end
			end
		end
		if ($npc['2,qwartem'] = 3 or $npc['2,qwartem'] = 20) and artomkissday ! daystart and (GorSlut < 2 or artemblag = 1):
			gs 'zz_render', '', '', func('artemEv_strings', '45')
			dynamic $artomKiss
		end
	end
}
$artomKiss = {
	act 'Поцеловать Артема':
		*clr & cla
		horny += 10
		minut += 5
		artomkissday = daystart
		if GorSlut >= 2 and artemblag = 0:
			cla
			gs 'zz_render', '', '', func('artemEv_strings', '46')
			dynamic $din_artom_bj
			exit
		end
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/Ev/kiss.jpg', func('artemEv_strings', '47')
		if artemtimes >= 20 and leghumpArtom = 0:
			gs 'zz_render', '', '', func('artemEv_strings', '48')
			dynamic $din_artom_leghump
		elseif leghumpArtom >= 1:
			gs 'zz_render', '', '', func('artemEv_strings', '49')
			dynamic $din_artom_leghump
			dynamic $din_artom_leghump2
		end
		if $npc['2,qwartem'] = 3:
			if horny < 50:
				if school['homework'] > 0:
					dynamic $din_artom_lern
				else
					act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
				end
				act 'Нехотя дрочить Артему':
					*clr & cla
					dom -= 1
					manna = manna/2
					minut += 15
					hj += 1
					hja += 1
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/hj.jpg', func('artemEv_strings', '50')
					if school['homework'] > 0:
						dynamic $din_artom_lern
					else
						act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
					end
				end
			elseif horny >= 50:
				act 'Дрочить Артему':
					*clr & cla
					minut += 15
					hj += 1
					hja += 1
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					dom += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/hj.jpg', func('artemEv_strings', '51')
					if school['homework'] > 0:
						dynamic $din_artom_lern
					else
						act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
					end
				end
			end
		end
		if $npc['2,qwartem'] = 20:
			if horny < 30:
				if school['homework'] > 0:
					dynamic $din_artom_lern
				else
					act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
				end
			elseif horny >= 30:
				act 'Дрочить Артему':
					*clr & cla
					minut += 15
					hj += 1
					hja += 1
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/hj.jpg', func('artemEv_strings', '52')
					if school['homework'] > 0:
						dynamic $din_artom_lern
					else
						act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
					end
				end
				act 'Взять в рот':
					*clr & cla
					minut += 5
					bj += 1
					bja += 1
					if $npc['2,sex'] = 0: $npc['2,sex'] = 1 & guy += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/bj.jpg', func('artemEv_strings', '53')
					if mesec > 0:
						if artomanal > 0:
							gs 'zz_render', '', '', func('artemEv_strings', '54')
							act 'Согласиться на анал':
								*clr & cla
								minut += 15
								anala += 1
								artomanal += 1
								gs'stat'
								gs 'zz_render', '', 'images/qwest/alter/artom/anal.jpg', func('artemEv_strings', '55')
								gs 'zz_dynamic_sex', 'anal_start', 'dick'
								gs 'zz_dynamic_sex', 'anal', 'dick'
								gs 'zz_dynamic_sex', 'anal_cum'
								if school['homework'] > 0:
									dynamic $din_artom_lern
								else
									act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
								end
							end
						elseif $npc['2,qwSex'] >= 10 and artomanal = 0:
							act 'У меня месячные':
								*clr & cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'images/qwest/alter/artom/2.jpg', func('artemEv_strings', '56')
								act 'Отказаться и продолжать сосать':
									*clr & cla
									minut += 5
									swallow += 1
									gs 'zz_funcs', 'cum', 'lip'
									gs'stat'
									gs 'zz_render', '', 'images/qwest/alter/artom/bjcum.jpg', func('artemEv_strings', '57')
									if school['homework'] > 0:
										dynamic $din_artom_lern
									else
										act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
									end
								end
								act 'Согласиться':
									*clr & cla
									minut += 15
									anala += 1
									artomanal += 1
									gs'stat'
									gs 'zz_render', '', 'images/qwest/alter/artom/anal.jpg', func('artemEv_strings', '58')
									gs 'zz_dynamic_sex', 'anal_start', 'dick'
									gs 'zz_dynamic_sex', 'anal', 'dick'
									gs 'zz_dynamic_sex', 'anal_cum'
									if school['homework'] > 0:
										dynamic $din_artom_lern
									else
										act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
									end
								end
							end
						end
					else
						act 'Отдаться':
							*clr & cla
							minut += 5
							sexa += 1
							pose = 0
							if $npc['2,qwSex'] >= 1:$npc['2,qwSex'] += 1
							gs'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/sex.jpg', func('artemEv_strings', '59')
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							if $npc['2,qwSex'] = 0:
								$npc['2,qwSex'] = 1
								gs 'zz_render', '', '', func('artemEv_strings', '60')
							end
							if school['homework'] > 0:
								dynamic $din_artom_lern
							else
								act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
							end
						end
					end
					act 'Продолжать сосать':
						*clr & cla
						minut += 5
						if horny < 90:
							$timeorgart = 'Во глотаете всю его сперму и тщательно облизываете член.'
						elseif horny >= 90:
							horny = 0
							orgasm += 1
							$timeorgart = 'Не вынимая член изо рта вы доводите себя до оргазма. Во время оргазма вы глотаете всю его сперму и тщательно облизываете член.'
						end
						swallow += 1
						gs 'zz_funcs', 'cum', 'lip'
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/bjcum.jpg', func('artemEv_strings', '61')
						if school['homework'] > 0:
							dynamic $din_artom_lern
						else
							act 'Уйти': minut += 5 & gt'pod_ezd','etaj_1'
						end
					end
				end
			end
		end
		act 'Идти домой': gt'pod_ezd','etaj_1'
	end
}
$artomSkver = {
	!прогулка в парке
	*clr & cla
	minut += 15
	gs 'stat'
	dynamic $artomGopSkver
	gs 'zz_render', '', 'images/qwest/alter/artom/walk/walk_'+ rand(1,2) +'.jpg', func('artemEv_strings', '62')
	act 'Пойти в кино':
		*clr & cla
		minut += 60
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/walk/kino_'+ rand(1,3) +'.jpg', func('artemEv_strings', '63')
		artomKino += 1
		if artomKino > 3 and artomKinoKiss < 5:
			*clr & cla
			gs 'zz_render', '', '', func('artemEv_strings', '64')
			gs 'zz_render', '', 'images/qwest/alter/artom/walk/kinokiss_'+ rand(1,2) +'.jpg', func('artemEv_strings', '65')
			artomKinoKiss += 1
		elseif artomKinoKiss >= 5:
			*clr & cla
			gs 'zz_render', '', '', func('artemEv_strings', '66')
			gs 'zz_render', '', 'images/qwest/alter/artom/walk/kinobj_'+ rand(1,3) +'.jpg', func('artemEv_strings', '67')
			bj += 1
			bja += 1
			swallow += 1
			gs 'zz_funcs', 'cum', 'lip'
			artomKinoKiss += 1
		end
		gs 'zz_render', '', '', func('artemEv_strings', '68')
		act 'Идти к Артему':gt'artemhome'
	end
	act 'Отказаться':
		*clr & cla
		minut += 30
		gs 'stat'
		gs 'zz_render', '', '', func('artemEv_strings', '69')
		dynamic $artomGopSkver
		gs 'zz_render', '', '', func('artemEv_strings', '70')
		act 'Идти к Артему':gt'artemhome'
	end
}
$artomGopSkver = {
	artomRand = rand(0,10)
	if artomRand < 2:
		*clr & cla
		minut += 5
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop.jpg', func('artemEv_strings', '71')
		act 'Не обращать внимания':'Вы игнорируя всех проходите мимо.' & act 'Гулять дальше':dynamic $artomSkver
		act 'Ответить':
			cla
			gs 'zz_render', '', '', func('artemEv_strings', '72')
			act 'Вступиться за него':
				*clr & cla
				minut += 5
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop_knee.jpg', func('artemEv_strings', '73')
				money = 0
				act 'Идти к Артему':gt'artemhome'
			end
			act 'Смотреть молча':
				*clr & cla
				gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop_udar.jpg', func('artemEv_strings', '74')
				act 'Отказаться':
					*clr & cla
					gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop_udar2.jpg', func('artemEv_strings', '75')
					act 'Отвести Артема': minut += 15 & gt'pod_ezd','etaj_1'
				end
				act 'Танцевать':
					*clr & cla
					minut += 5
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop_strip.jpg', func('artemEv_strings', '76')
					act 'Отсосать':
						*clr & cla
						minut += 15
						throat += 1
						bj += 3
						guy += 3
						eggs += 3
						gs 'zz_funcs', 'cum', 'face'
						dom -= 5
						if GorSlut < 3: GorSlut = 3
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop_bj.jpg', func('artemEv_strings', '77')
						act 'Идти':
							*clr & cla
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/walk/walk_slap.jpg', func('artemEv_strings', '78')
							act 'Уйти': minut += 15 & artemblok = 1 & gt'pod_ezd','etaj_1'
						end
					end
					act 'Попытаться сбежать':
						*clr & cla
						minut += 5
						gs 'stat'
						artomGopRange = speed + agil + beg
						if artomGopRange < 50:
							artomRand = rand(0,1)
						elseif artomGopRange >= 50 and artomGopRange < 100:
							artomRand = rand(0,2)
						elseif artomGopRange >= 100 and artomGopRange < 150:
							artomRand = rand(0,5)
						elseif artomGopRange >= 150 and artomGopRange < 200:
							artomRand = rand(0,10)
						else
							artomRand = rand(0,20)
						end
						if artomRand ! 0:
							dom += 5
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/walk/walk_save.jpg', func('artemEv_strings', '79')
							act 'Идти к Артему':gt'artemhome'
						else
							*clr & cla
							minut += 20
							throat += 1
							guy += 6
							rape += 1
							gang += 1
							dom -= 3
							gs 'zz_funcs', 'cum', 'lip'
							$npc['2,qwartem'] = 21
							if GorSlut < 5: GorSlut = 5
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/artom/walk/walkgop_rape.jpg', func('artemEv_strings', '80')
							act 'Уйти': minut += 15 & artemblag = 1 & gt'pod_ezd','etaj_1'
						end
					end
				end
			end
		end
	end
}
$artomBibl = {
	!прогулка в библеотеку
	school['homework'] = 0
	*clr & cla
	minut += 30
	school['intellect']
	gs 'stat'
	gs 'zz_render', '', 'images/qwest/alter/artom/walk/library.jpg', func('artemEv_strings', '81')
	act 'Идти к Артему':gt'artemhome'
}
gs 'stat'
gs 'npc_editor','get_npc_profile',2
if $npc['9,qwKotovLove'] >= 5 and artomVitokQW = 0:
	gs 'zz_render', '', '', func('artemEv_strings', '82')
	if dom >= 10:
		act 'Витек, отвали от него!':
			*clr & cla
			artomVitokQW = 1
			gs'stat'
			gs 'zz_render', '', '', func('artemEv_strings', '83')
			dynamic $din_artom_lern
		end
	end
	act 'Молчать':
		*clr & cla
		artomVitokQW = 2
		gs 'stat'
		gs 'zz_render', '', '', func('artemEv_strings', '84')
		act 'Уйти':gt'gschool'
	end
	exit
end
gs 'zz_render', '', '', func('artemEv_strings', '85')
act 'Идти к Артему':gt'artemhome'