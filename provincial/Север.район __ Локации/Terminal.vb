minut += 5
gs 'stat'
gs 'zz_render','Складской терминал','city/north/terminal/terminal0.jpg',func('Terminal_strings','local_str1')
! по понедельниках можно встретить отчима и напроситься ехать с ним домой
if week = 1 and hour >= 18 and hour <= 21: gs 'zz_render','','','Возле терминала вместе с другими водилами, ожидая загрузки, режется в картишки ваш <a href="exec: gt ''zz_father'',''meet_in_city''">отчим.</a>'
if $npc['43,qwBioOtec'] = 4 and week >= 6 and hour >= 12 and hour < 14: gs 'zz_render','','','Возле грязной фуры копается ваш <a href="exec:GT ''trFatherMisha''">отец</a>'
act 'Уйти':
	cla
	minut += 5
	gt'nord'
end
if $npc['43,qwBioOtec'] = 2:
	act 'Искать отца':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_2.jpg', func('Terminal_strings', 'local_str2')
		act 'Спросить у диспетчера':
			*clr & cla
			minut += 5
			$npc['43,qwBioOtec'] = 3
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_3.jpg', func('Terminal_strings', 'local_str3')
			act 'Уйти':minut += 5 & gt $curloc
		end
		act 'Подойти к дальнобойщикам':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_4.jpg', func('Terminal_strings', 'local_str4')
			act 'Послать':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_5.jpg', func('Terminal_strings', 'local_str5')
				act 'Уйти':minut += 5 & gt $curloc
			end
			act 'Сосать':
				*clr & cla
				minut += 5
				horny += 5
				bj += 1
				guy += 1
				cumlip += 1
				swallow += 1
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_6.jpg', func('Terminal_strings', 'local_str6')
				act 'Ждать':
					*clr & cla
					minut += 5
					horny += 5
					bj += 1
					guy += 1
					cumlip += 1
					cumface += 1
					swallow += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_7.jpg', func('Terminal_strings', 'local_str7')
					act 'Выйти из кабины':
						*clr & cla
						minut += 5
						$npc['43,qwBioOtec'] = 3
						gs'stat'
						gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_8.jpg', func('Terminal_strings', 'local_str8')
						act 'Уйти':minut += 5 & gt $curloc
					end
				end
			end
		end
	end
elseif $npc['43,qwBioOtec'] = 3 and week = 6 and hour = 12:
	act 'Искать отца':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_9.jpg', func('Terminal_strings', 'local_str9')
		$askfather = {
			act 'Спросить про отца':
				*clr & cla
				minut += 5
				gs'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_9.jpg', func('Terminal_strings', 'local_str10')
				act 'Идти к отцу':
					*clr & cla
					minut += 5
					gs'stat'
					if cumface > 0:
						gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_13.jpg', func('Terminal_strings', 'local_str11')
						$npc['43,qwBioOtec'] = -1
						act 'Уйти':minut += 5 & gt $curloc
					else
						gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_14.jpg', func('Terminal_strings', 'local_str12')
						act 'Обнять':
							*clr & cla
							minut += 5
							gs'stat'
							gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_15.jpg', func('Terminal_strings', 'local_str13')
							act 'Идти в шашлычную':
								*clr & cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_17.jpg', func('Terminal_strings', 'local_str14')
								$npc['43,qwBioOtec'] = 4
								act 'Уйти':minut += 5 & gt 'nord'
							end
							act 'Обругать':
								*clr & cla
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_16.jpg', func('Terminal_strings', 'local_str15')
								$npc['43,qwBioOtec'] = -1
								act 'Уйти':minut += 5 & gt $curloc
							end
						end
					end
				end
			end
		}
		act 'Выпить':
			*clr & cla
			gs 'zz_funcs', 'alko',2
			gs 'stat'
			gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_10.jpg', func('Terminal_strings', 'local_str16')
			act 'Выпить':
				*clr & cla
				gs 'zz_funcs', 'alko', 3
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_11.jpg', func('Terminal_strings', 'local_str17')
				act 'Промычать':
					*clr & cla
					minut += 30
					cumlip += 1
					swallow += 1
					cumface += 1
					cumanus += 1
					cumpussy += 1
					cumbelly += 1
					cumass += 1
					gang += 1
					gs'stat'
					gs 'zz_render', '', 'images/qwest/alter/trfatherQW/trfatherQW_12.jpg', func('Terminal_strings', 'local_str18')
					act 'Уйти':minut += 5 & gt $curloc
				end
			end
			dynamic $askfather
			act 'Уйти':minut += 5 & gt $curloc
		end
		dynamic $askfather
		act 'Уйти':minut += 5 & gt $curloc
	end
end
act 'Зайти в офис':
	minut += 5
	AboutBussines = 0
	AboutDocs = 0
	AboutDocsManager = 0
	YouNotOpenDoorDir = 0
	YouNotOpenDoorBuh = 0
	gt 'TerminalOffice' , '00'
end