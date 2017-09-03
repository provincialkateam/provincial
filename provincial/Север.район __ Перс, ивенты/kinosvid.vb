minut += 60
manna += 10
gs'stat'
'<center><b>Кинотеатр</b></center>'
gs 'zz_render', '', 'images/img/kinosvid/0.jpg', func('kinosvid_strings', 'local_str1')
$kisvranddyn = {
	kisvrand = RAND(0,10)
	if kisvrand > 0 and kisvrand < 3: gt'kinosvid','1'
	if kisvrand > 2 and kisvrand < 5: gt'kinosvid','2'
	if kisvrand = 0 or kisvrand > 4: gt'kinosvid','3'
}
act 'Смотреть кино':
	if $telsob = 'Алла':
		alla += 1
		if alla >= 20:
			dynamic $kisvranddyn
		elseif alla < 20:
			gt'kinosvid','3'
		end
	elseif $telsob = 'Маша':
		masha += 1
		if masha >= 20:
			dynamic $kisvranddyn
		elseif masha < 20:
			gt'kinosvid','3'
		end
	elseif $telsob = 'Катя':
		gs 'npc_editor','change_rep','+', 33
		if $npc['33,relation'] >= 20:
			dynamic $kisvranddyn
		elseif $npc['33,relation'] < 20:
			gt'kinosvid','3'
		end
	end
end
if $ARGS[0] = '1':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/1.jpg', func('kinosvid_strings', 'local_str2')
	act 'Ой':
		cla
		*clr
		lesbian += 1
		gs 'zz_render', '', 'images/img/kinosvid/2.jpg', func('kinosvid_strings', 'local_str3')
		act 'Наслаждаться':gt'kinosvid','10'
		act 'Ласкать её':gt'kinosvid','11'
	end
end
if $ARGS[0] = '10':
	cla
	*clr
	orgasm += 1
	gs 'zz_render', '', 'images/img/kinosvid/3.jpg', func('kinosvid_strings', 'local_str4')
	act 'Наслаждаться':
		cla
		*clr
		orgasm += 1
		vagina += 1
		gs 'zz_render', '', 'images/img/kinosvid/4.jpg', func('kinosvid_strings', 'local_str5')
		act 'Ласкать её':gt'kinosvid','13'
		act 'Закончить':gt'kinosvid','3'
	end
	act 'Ласкать её':gt'kinosvid','12'
end
if $ARGS[0] = '11':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/5.jpg', func('kinosvid_strings', 'local_str6')
	act 'Ласкать её киску':gt'kinosvid','14'
	act 'Ласкать её попку':gt'kinosvid','15'
	act 'Поставить на колени':gt'kinosvid','16'
end
if $ARGS[0] = '12':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/6.jpg', func('kinosvid_strings', 'local_str7')
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '13':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/7.jpg', func('kinosvid_strings', 'local_str8')
	act 'Подставить попку':gt'kinosvid','110'
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '14':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/8.jpg', func('kinosvid_strings', 'local_str9')
	act 'Ласкать её':gt'kinosvid','17'
end
if $ARGS[0] = '15':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/9.jpg', func('kinosvid_strings', 'local_str10')
	act 'Ласкать её':gt'kinosvid','17'
end
if $ARGS[0] = '16':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/11.jpg', func('kinosvid_strings', 'local_str11')
	act 'Наслаждаться':gt'kinosvid','18'
	act 'Ласкать её':gt'kinosvid','19'
end
if $ARGS[0] = '17':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/10.jpg', func('kinosvid_strings', 'local_str12')
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '18':
	cla
	*clr
	orgasm += 1
	gs 'zz_render', '', 'images/img/kinosvid/12.jpg', func('kinosvid_strings', 'local_str13')
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '19':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/13.jpg', func('kinosvid_strings', 'local_str14')
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '110':
	cla
	*clr
	orgasm += 1
	gs 'zz_render', '', 'images/img/kinosvid/14.jpg', func('kinosvid_strings', 'local_str15')
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '2':
	cla
	*clr
	lesbian += 1
	gs 'zz_render', '', 'images/img/kinosvid/0.jpg', func('kinosvid_strings', 'local_str16')
	act 'Ждать':
		cla
		*clr
		'<center><img src="images/img/kinosvid/20.jpg"></center>'
		if kendra = 0:'Пока её не было к вам подсела симпатичная африканка и бесцеремонно положив руку вам на бедро, начала гладить его постепенно приближаясь к промежности и вот уже её пальцы наглаживают ваш клитор. Вы растерялись от такой наглости и просто сидели в ступоре наблюдая как наманикюринные ноготки проникают вам в вагину. В этот момент в зал вернулась <<$telsob>> и увидив эту картину, тут же схватила африканку за ухо и вытащила из зала, парни сидевшие в зале рассмеялись и вернувшись <<$telsob>> начала орать на них так, что они предпочли удалиться. В зале остались только вы и <<$telsob>>.'
		if kendra > 0:'Пока её не было к вам подсела Кендра и бесцеремонно положив руку вам на бедро, начала гладить его постепенно приближаясь к промежности и вот уже её пальцы наглаживают ваш клитор. Вы растерялись от такой наглости и просто сидели в ступоре наблюдая как наманикюринные ноготки проникают вам в вагину. В этот момент в зал вернулась <<$telsob>> и увидив эту картину, тут же схватила Кендру за ухо и вытащила из зала, парни сидевшие в зале рассмеялись и вернувшись <<$telsob>> начала орать на них так, что они предпочли удалиться. В зале остались только вы и <<$telsob>>.'
		act 'Ждать':
			cla
			*clr
			gs 'zz_render', '', 'images/img/kinosvid/21.jpg', func('kinosvid_strings', 'local_str17')
			act 'Ждать':
				cla
				*clr
				vagina += 1
				orgasm += 1
				gs 'zz_render', '', 'images/img/kinosvid/22.jpg', func('kinosvid_strings', 'local_str18')
				act 'Подчиниться':
					cla
					*clr
					orgasm += 1
					gs 'zz_render', '', 'images/img/kinosvid/23.jpg', func('kinosvid_strings', 'local_str19')
					act 'Далее':
						cla
						*clr
						gs 'zz_render', '', 'images/img/kinosvid/24.jpg', func('kinosvid_strings', 'local_str20')
						act 'Закончить':gt'kinosvid','3'
					end
				end
				act 'Ласкать её':gt'kinosvid','22'
			end
			act 'Ласкать её':gt'kinosvid','21'
		end
	end
end
if $ARGS[0] = '21':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/25.jpg', func('kinosvid_strings', 'local_str21')
	act 'Закончить':
		cla
		*clr
		orgasm += 1
		gs 'zz_render', '', 'images/img/kinosvid/26.jpg', func('kinosvid_strings', 'local_str22')
		act 'Закончить':gt'kinosvid','3'
	end
end
if $ARGS[0] = '22':
	cla
	*clr
	gs 'zz_render', '', 'images/img/kinosvid/27.jpg', func('kinosvid_strings', 'local_str23')
	act 'Закончить':gt'kinosvid','3'
end
if $ARGS[0] = '3':
	cla
	horny = 0
	minut += 90
	gs'stat'
	gs 'zz_render', '', '', func('kinosvid_strings', 'local_str24')
	act 'Уйти':gt'torgcentr'
end