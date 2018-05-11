*clr & cla
$metka = $ARGS[0]
$loc = $CURLOC
minut += 1
frost = 0
gs 'zz_funcs','colorize_day'
gs 'banda_events','banda_check'
gs 'stat'
if banda['banda_sklad'] = 1 : gs 'zz_render','Склад','city/north/banda/01.jpg','Пустой склад в центре которого находится диван на котором сидят <a href="exec: gt ''banda''">бандиты</a>'
if banda['banda_sklad'] = 1 and banda['studio_start'] = 1 and flag_banda['studio'] < 4 and flag_banda['studio_day'] ! day and anal >= 18 and vagina >= 18 and lubri > 0: gt 'banda_events','banda_studio1'
if banda['banda_sklad'] = 1 and flag_banda['studio'] = 4 and horny >= 30 and banda['studio'] = 0: gt 'banda_events','banda_studio2'
act 'Уйти':
	killvar '$_str'
	minut += 5
	gt 'north'
end