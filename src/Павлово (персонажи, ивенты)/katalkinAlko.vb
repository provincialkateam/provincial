gs 'stat'
if hour < 8:
	gs 'zz_render', '', '', 'Полицейские наконец-то перепились и повалились спать кто где.'
	act 'Уйти': minut += 1 & gt'vokzalGin'
	exit
end
if alko < 6:
	gs 'zz_render', '', '', 'Вы выпили рюмку водки вместе с полицейскими. Вам опять подливают в рюмку водки.'
	act 'Выпить рюмку':
		gs 'zz_funcs', 'alko', 2
		gt $curloc
	end
else
	cla
	gs 'zz_render', '', '', 'Вы окончательно захмелели и едва сидите на стуле.'
end
act 'Уйти':minut += 2 & gt'vokzalGin'