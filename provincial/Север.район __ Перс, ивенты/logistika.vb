if $ARGS[0] = 'start':
	*clr & cla
	If $npc['0,qwLogistika'] = 0 or $npc['0,qwLogistika'] = 2:
		$npc['0,qwLogistika'] = 1
		gt 'logistika','1'
	elseif $npc['0,qwLogistika'] = 4:
		gt 'logistika','4'
	elseif $npc['0,qwLogistika'] = 10:
		gt 'logistika','10'
	else
		act 'Попращаться и уйти':gt'nord'
	end
end
if $ARGS[0] = '1':
	minut += 10
	gs'stat'
	gs 'zz_render', 'КП Логистика, ресепшн', 'какая-то картинка', func('Logistika1_strings', 'local_str1')
	act 'Идти в кабинет':
		*clr & cla
		if worktaksi = 1:
			gs 'zz_render', 'КП Логистика, кадры', 'какая-то картинка', func('Logistika1_strings', 'local_str2')
			$npc['0,qwLogistika'] = 2
			act 'Уйти':gt'nord'
		else
			gs 'zz_render', 'КП Логистика, кадры', 'какая-то картинка', func('Logistika1_strings', 'local_str3')
			$npc['0,qwLogistika'] = 3
			act 'Идти в приёмную':
				gs 'zz_render', 'КП Логистика, приёмная', 'какая-то картинка', func('Logistika1_strings', 'local_str4')
				act 'Пройти в кабинет':
					gs 'zz_render', 'КП Логистика, приёмная', 'какая-то картинка', func('Logistika1_strings', 'local_str5')
					act 'Далее':
						gs 'zz_render', 'КП Логистика, приёмная', 'какая-то картинка', func('Logistika1_strings', 'local_str6')
						act 'Идти к кадровику':
							gs 'zz_render', 'КП Логистика, кадры', 'какая-то картинка', func('Logistika1_strings', 'local_str7')
							act 'Согласиться':
								$npc['0,qwLogistika'] = 10
								gs 'zz_render', 'КП Логистика, кадры', 'какая-то картинка', func('Logistika1_strings', 'local_str8')
							end
							act 'Отказаться':
								$npc['0,qwLogistika'] = 4
								gs 'zz_render', 'КП Логистика, кадры', 'какая-то картинка', func('Logistika1_strings', 'local_str9')
								act 'Уйти':gt'nord'
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = '4':
	minut += 10
	$npc['0,qwLogistika'] = 10
	gs'stat'
	gs 'zz_render', 'КП Логистика, кадры', 'какая-то картинка', func('Logistika1_strings', 'local_str10')
	act 'Уйти':gt'nord'
end
if $ARGS[0] = '10':
	minut += 10
	gs'stat'
	gs 'zz_render', 'КП Логистика, ресепшн', 'какая-то картинка', func('Logistika1_strings', 'local_str11')
	act 'Уйти':gt'nord'
end