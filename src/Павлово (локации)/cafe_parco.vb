$loc = $curloc
if $args[0]= '' or $args[0]= 'start':
	$metka = $args[0]
	gs 'zz_phone','boyfriend_call_init'
	gs 'zz_render','Кафе "Del Parco"','pavlovo/cafe/caffe_del_parco'+iif(func('zz_weather','is_day')=1,'','_night'), 'Недавно открывшаяся кафешка "Del Parco", с броским фасадом, большим количеством столиков и летней площадкой. Открыто с 12.00 до 22.00.'
	if hour >= 12 and hour <= 21: act 'Зайти': gt 'cafe_parco', 'inner'
	act 'В парк': gt 'zz_park'
end
if $args[0] = 'inner':
	frost = 0
	gs 'zz_funcs','colorize_day'
	gs 'zz_render','','pavlovo/cafe/caffe_del_parco_in'
	act 'Уйти': gt 'zz_park'
	if hour >= 22: exit
	gs 'zz_cafe','init',0
	act 'Заказать кофе': gt 'zz_common', 'coffee'
	gs 'zz_family', 'sister_sheduler'
	$loc = $curloc
	if (sunWeather < 0 or temper < 5) and week mod 2 = 0 and (hour >= 15 and hour < 20) and $npc['15,qw_day'] ! day:
		minut += rand(5,15)
		gs 'zz_render','', '', 'В кафешке за столиком сидят Вика с Иваном.'
		!---
		if $npc['15,qwVika'] = 18 or $npc['15,qwVika'] = 19:
			gt 'mey_vika_events','cafe_repeat_qw'
		else
			gs 'mey_vika_events','meet_process'
		end
		!---
	end
end