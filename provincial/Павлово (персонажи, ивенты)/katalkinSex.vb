$d_katanal = {
	act 'Далее':
		*clr & cla
		horny += 5
		minut += 15
		if $npc['41,sex'] = 0:$npc['41,sex'] = 1 & guy += 1
		KatalkinAnal += 1
		dom -= 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/vokzal/kat/katAnal.jpg', func('katalkinSex_strings', 'local_str1')
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick', 1
		act 'Далее':
			*clr & cla
			minut += 3
			anal += 1
			gs 'zz_funcs', 'cum', 'anus'
			gs'stat'
			gs 'zz_render', '', 'images/qwest/vokzal/kat/after.jpg', func('katalkinSex_strings', 'local_str2')
			cla
			act 'Привести себя в порядок и уйти': gt'vokzalG'
		end
	end
}
$d_katsub = {
	act 'Закрыть глаза':
		*clr & cla
		horny += 5
		minut += 3
		gs'stat'
		gs 'zz_render', '', 'images/qwest/vokzal/kat/bend.jpg', func('katalkinSex_strings', 'local_str3')
		act 'Стоять наклонившись':
			*clr & cla
			horny += 5
			minut += 3
			gs'stat'
			gs 'zz_render', '', 'images/qwest/vokzal/kat/grop.jpg', func('katalkinSex_strings', 'local_str4')
			act 'Раздеться и встать раком':
				*clr & cla
				horny += 5
				minut += 3
				gs'stat'
				gs 'zz_render', '','images/qwest/vokzal/kat/katBeforeAnal.jpg'
				if RAND(0,1) = 0:
					gs 'zz_render', '', '', func('katalkinSex_strings', 'local_str5')
					dynamic $d_katanal
				else
					gs 'zz_render', '', '', func('katalkinSex_strings', 'local_str6')
					act 'Нет':
						*clr & cla
						gs'stat'
						gs 'zz_render', '', 'images/qwest/vokzal/kat/katBeforeAnal.jpg', func('katalkinSex_strings', 'local_str7')
						dynamic $d_katanal
					end
					if prezik > 0:
						act 'Есть':
							*clr & cla
							pose = 1
							gs'stat'
							gs 'zz_render', '','images/qwest/vokzal/kat/sex.jpg'
							gs 'zz_dynamic_sex', 'sex_start'
							gs 'zz_dynamic_sex', 'vaginal', 'dick'
							gs 'zz_dynamic_sex', 'sex_cum'
							cla
							act 'Привести себя в порядок и уйти': gt'vokzalG'
						end
					end
				end
			end
		end
	end
}
$boy = 'Каталкин'
dick = 18
silavag = 0
horny += 10
schtraf = 0
katalkinNoexit = 0
katalkinSexDay = daystart
gs'stat'
if katsexetap = 0:
	gs 'zz_render', '', 'images/qwest/vokzal/kat/kat.jpg', func('katalkinSex_strings', 'local_str8')
	act 'Убирать его руки':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/qwest/vokzal/kat/kat.jpg', func('katalkinSex_strings', 'local_str9')
		act 'Гладить его ширинку':katsexetap = 1 & gt $curloc
		dynamic $d_katsub
	end
	dynamic $d_katsub
	if horny >= 75:
		act 'Обнимать его':
			*clr & cla
			horny += 5
			gs'stat'
			gs 'zz_render', '', 'images/qwest/vokzal/kat/kat.jpg', func('katalkinSex_strings', 'local_str10')
			act 'Гладить его ширинку':katsexetap = 1 & gt $curloc
			dynamic $d_katsub
		end
	end
elseif katsexetap = 1:
	gs 'zz_render', '', '', func('katalkinSex_strings', 'local_str11')
	act 'Встать на колени':
		*clr & cla
		if $npc['41,sex'] = 0:$npc['41,sex'] = 1 & guy += 1
		gs'stat'
		gs 'zz_render', '', 'images/qwest/vokzal/kat/kneel.jpg', func('katalkinSex_strings', 'local_str12')
		act 'Сосать':
			*clr & cla
			bj += 1
			gs'stat'
			gs 'zz_render', '','images/qwest/vokzal/kat/bj.jpg'
			gs 'zz_dynamic_sex', 'bj'
			kattiperand = RAND(0,1)
			if kattiperand = 0:
				act 'Глотать кончу':
					*clr & cla
					KatalkinSwallow += 1
					gs'stat'
					gs 'zz_render', '','images/qwest/vokzal/kat/swallow.jpg'
					gs 'zz_dynamic_sex', 'swallow'
					cla
					act 'Привести себя в порядок и уйти': gt'vokzalG'
				end
				act 'На лицо':
					*clr & cla
					gs 'zz_funcs', 'cum', 'face'
					KatalkinFacial += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/vokzal/kat/facial.jpg', func('katalkinSex_strings', 'local_str13')
					act 'Приводить себя в порядок':minut += 1 & gt'katalkin'
				end
			elseif kattiperand = 1:
				gs 'zz_render', '', '', func('katalkinSex_strings', 'local_str14')
				dynamic $d_katsub
			end
		end
	end
end