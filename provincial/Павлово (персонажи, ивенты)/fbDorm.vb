gs'stat'
gs'fbDormD'
gs 'zz_render', '', '', func('fbDorm_strings', 'local_str1')
dynamic $d_fbd_start
act 'Э... Я передумала':
	*clr & cla
	minut += 5
	gs'stat'
	gs 'zz_render', '', '', func('fbDorm_strings', 'local_str2')
	if dom > 0:
		gs 'zz_render', '', '', func('fbDorm_strings', 'local_str3')
		act 'Уйти':gt'gorodok'
	else
		gs 'zz_render', '', '', func('fbDorm_strings', 'local_str4')
		dynamic $d_fbd_start
	end
end