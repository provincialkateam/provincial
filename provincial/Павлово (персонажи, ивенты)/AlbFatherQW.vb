if $args[0] = '' or $args[0] = 'main':
	*clr & cla
	gs 'zz_render','','',func('AlbFatherQW_strings','local_str7')
	act 'Отойти с Черновым':
		*clr & cla
		minut += 1
		gs 'stat'
		gs 'zz_render','','',func('AlbFatherQW_strings','local_str8')
		act 'Как избежать?':
			*clr & cla
			gs 'zz_render','','',func('AlbFatherQW_strings','local_str'+iif(age < 18,9,10)) + func('AlbFatherQW_strings','local_str11')
			if intel >= 70:
				act 'А почему этим занимается служба безопасности, а не полиция?':
					*clr & cla
					gs 'zz_render','','',func('AlbFatherQW_strings','local_str12')
					if intel >= 75:
						act 'Вы не ответили на вопрос':
							*clr & cla
							gs 'zz_render','','',func('AlbFatherQW_strings','local_str13')
							gs 'AlbFatherQW','zajava_albfather'
							gs 'AlbFatherQW','zajava_albfather_no'
						end
					end
					gs 'AlbFatherQW','zajava_albfather'
					gs 'AlbFatherQW','zajava_albfather_no'
				end
			end
			gs 'AlbFatherQW','zajava_albfather'
			gs 'AlbFatherQW','zajava_albfather_no'
		end
	end
end
if $args[0] = 'zajava_albfather':
	act 'Ладно. Я напишу заявление':
		*clr & cla
		gs 'zz_render', '', '', func('AlbFatherQW_strings','local_str1')
		act 'Идти с Черновым':
			*clr & cla
			minut += 20
			$npc['23,qwMain'] = 70
			$npc['23,arrest_day'] = day
			gs 'stat'
			gs 'zz_render', '', '', func('AlbFatherQW_strings','local_str2')
			act 'Уйти': gt'gorodok'
		end
	end
end
if $args[0] = 'zajava_albfather_no2':
	act 'И все таки я откажусь':
		*clr & cla
		gs 'zz_render', '', '', func('AlbFatherQW_strings','local_str3')
		act 'Предупредить Альбину':
			*clr & cla
			$npc['23,qwMain'] = 50
			gs 'zz_render','','',func('AlbFatherQW_strings','local_str4')
			act 'Уйти': gt'gorodok'
		end
	end
end
if $args[0] = 'zajava_albfather_no':
	act 'Я не буду писать заявление!':
		*clr & cla
		gs 'zz_render', '', '', func('AlbFatherQW_strings','local_str5')
		if intel >= 80:
			act 'А зачем тогда я вам?':
				*clr & cla
				gs 'zz_render', '', '', func('AlbFatherQW_strings','local_str6')
				gs 'AlbFatherQW','zajava_albfather'
				gs 'AlbFatherQW','zajava_albfather_no2'
			end
		end
		gs 'AlbFatherQW','zajava_albfather'
		gs 'AlbFatherQW','zajava_albfather_no2'
	end
end