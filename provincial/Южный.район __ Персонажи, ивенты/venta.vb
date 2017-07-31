if $ARGS[0] = 'ven':
	gs'stat'
	money -= 1000
	minut += 60
	gs 'stat'
	gs 'zz_render', '', 'city/south/clinic/gynecologist/0.jpg', func('venta_strings', 'local_str1')
	act 'Раздеться':
		*clr & cla
		current_clothing = 0
		gs 'zz_render', '', 'city/south/clinic/gynecologist/2.jpg', func('venta_strings', 'local_str2')
		act 'Лечь':
			*clr & cla
			gs 'zz_render', '', 'city/south/clinic/gynecologist/3.jpg', func('venta_strings', 'local_str3')
			act 'Обследоваться':
				*clr & cla
				venosm = 1
				gs 'zz_render', '', 'city/south/clinic/gynecologist/5.jpg', func('venta_strings', 'local_str4')
				act 'Далее':
					*clr & cla
					gs 'zz_render', '', 'city/south/clinic/gynecologist/4.jpg', func('venta_strings', 'local_str5')
					if money >= 10000:
						venob = RAND(1,100)
						if venob >= 97:
							*clr & cla
							gs 'zz_render', '', 'city/south/clinic/gynecologist/3.jpg', func('venta_strings', 'local_str6')
							act 'Возмутиться':
								*clr & cla
								gs 'zz_render', '', 'city/south/clinic/gynecologist/0.jpg', func('venta_strings', 'local_str7')
									act 'Заплатить':gt'venta','ven1'
									act 'Взять деньги':gt'venta','ven2'
								act 'Пригрозить сдать':
									*clr & cla
									gs 'zz_render', '', 'city/south/clinic/gynecologist/0.jpg', func('venta_strings', 'local_str8')
									act 'Заплатить': gt'venta','ven1'
									act 'Взять деньги': gt'venta','ven2'
									act 'Бежать': gt'venta','ven3'
								end
							end
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'ven1':
	*clr & cla
	money -= 10000
	current_clothing = 0
	gs 'stat'
	gs 'zz_render', '', 'city/south/clinic/gynecologist/3.jpg', func('venta_strings', 'local_str9')
	act 'Ждать рузультатов': gt'poli','start'
end
if $ARGS[0] = 'ven2':
	*clr & cla
	money += 3000
	slava += 1
	current_clothing = 0
	gs 'stat'
	gs 'zz_render', '', 'city/south/clinic/gynecologist/3.jpg', func('venta_strings', 'local_str10')
	act 'Ждать рузультатов': gt'poli','start'
end
if $ARGS[0] = 'ven3':
	*clr & cla
	gs 'zz_render', '', 'images/pic/poli.jpg', func('venta_strings', 'local_str11')
	act 'Вырываться': gt 'gameover',7
end