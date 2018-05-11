$loc = $curloc
frost = 0
if $args[0] = '':
	*clr & cla
	$metka = ''
	gs 'zz_render','Ателье по пошиву и ремонту одежды','pavlovo/market/tailor','Небольшое ателье, в котором можно перешить или продать неподходящую одежду.'
	act '<b>Уйти</b>': gt $control_point
	act 'Перешить/продать':
		*clr & cla
		gs 'zz_clothing2','tailor_list'
		act '<b>Назад</b>': gt 'tailor'
	end
end