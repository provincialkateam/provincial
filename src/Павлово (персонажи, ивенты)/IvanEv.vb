ivansportday = day
gs 'stat'
gs 'npc_editor','get_npc_profile',3
if $loc = 'gdksport':
	gs 'zz_render', '', '', func('IvanEv_strings', 'local_str1')
	act 'Уйти': gt'gdksport'
	if $npc['3,qwKotovVsProhorov'] = 0:
		gs 'zz_render', '', '', func('IvanEv_strings', 'local_str2')
		act 'Хочу':
			*clr & cla
			$npc['3,qwKotovVsProhorov'] = 1
			gs 'zz_render', '', 'images/qwest/alter/boxing/box0.jpg', func('IvanEv_strings', 'local_str3')
			act 'Смотреть':
				*clr & cla
				minut += 3
				gs 'stat'
				gs 'zz_render', '', 'images/qwest/alter/boxing/box1.jpg', func('IvanEv_strings', 'local_str4')
				act 'Смотреть':
					*clr & cla
					minut += 3
					gs 'stat'
					gs 'zz_render', '', 'images/qwest/alter/boxing/box2.jpg', func('IvanEv_strings', 'local_str5')
					act 'Смотреть':
						*clr & cla
						minut += 3
						gs 'stat'
						gs 'zz_render', '', 'images/qwest/alter/boxing/box3.jpg', func('IvanEv_strings', 'local_str6')
						act 'Смотреть':
							*clr & cla
							minut += 3
							gs 'stat'
							gs 'zz_render', '', 'images/qwest/alter/boxing/box4.jpg', func('IvanEv_strings', 'local_str7')
							act 'Спросить у тренера кто победил':
								*clr & cla
								minut += 3
								gs 'stat'
								gs 'zz_render', '', '', func('IvanEv_strings', 'local_str8')
								act 'Можно мне походить на тренировку?':
									*clr & cla
									minut += 3
									gs 'stat'
									gs 'zz_render', '', '', func('IvanEv_strings', 'local_str9')
									if dom >= 10:
										act 'Упрашивать':
											cla
											gs 'zz_render', '', '', func('IvanEv_strings', 'local_str10')
											act 'Спасибо!':
												cla
												ivan_trainer_qw = 1
												gs 'zz_render', '', '', func('IvanEv_strings', 'local_str11')
												act 'Уйти': gt 'gdksport'
											end
										end
									end
									act 'Уйти': gt 'gdksport'
								end
							end
						end
					end
				end
			end
		end
	end
end