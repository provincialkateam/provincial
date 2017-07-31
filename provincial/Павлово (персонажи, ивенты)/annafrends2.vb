gs 'zz_render', '', 'pavlovo/family/sister/friends/' + $sister['location'] + '.jpg', func('annafrends2_strings', 'local_str1')
if RAND(0,1) = 0:
	gs 'zz_render', '', '', func('annafrends2_strings', 'local_str'+rand(2,4))
	act 'Пойти вместе':gt'annafrendtoilet'
else
	gs 'zz_render', '', '', func('annafrends2_strings', 'local_str5')
end
if hour <= 16:act 'Пить пиво дальше': gt 'annafrends'
act 'Уйти':
	if $sister['location'] = 'gdk': gt 'gdk'
	if $sister['location'] = 'glake': gt 'glake'
	if $sister['location'] = 'cafe_parco': gt 'cafe_parco', 'inner'
end