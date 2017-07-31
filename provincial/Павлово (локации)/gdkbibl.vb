$metka = $ARGS[0]
$loc = $CURLOC
frost = 0
gs'stat'
gs 'zz_funcs', 'colorize_day'
gs 'zz_render','Библиотека','pavlovo/dk/gdkbibl', 'Небольшая библиотека в которой много интересных книг.'
act 'Выйти':gt'gdk'
if hour >= 9 and hour <= 18:
	gs 'library_acts'
else
	gs 'zz_render', '', '', 'Библиотека закрывается.'
end