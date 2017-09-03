!-----------------------------------------------!
!-----Игра в карты с пацанами на раздевание-----!
!===============================================!
$card_game_durak = {
	*clr & cla
	minut += 5
	!кол-во одежды на игроках
	card_game_durak_clothes = 5
	card_game_durak_npc_vasya = 4
	card_game_durak_npc_den = 4
	card_game_durak_npc_vitek = 4
	!выбор сета картинок
	cgd_clothes_set = rand(1,20)
	!обнуляем проигрыш нпс:
	cgd_loss_vasya = 0
	cgd_loss_den = 0
	cgd_loss_vitek = 0
	!обнуляем выигрыш нпс:
	cgd_win_vasya = 0
	cgd_win_den = 0
	cgd_win_vitek = 0
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/durak.jpg','\\- С тобой будем играть только на раздевание, плюс проигравший выполняет одно желание победившего// - заявляют вам пацаны.'
	'Ваша статистика игр: побед <<card_game_durak_win>>, поражений <<card_game_durak_loss>>, ничьих <<card_game_durak_draw>>, вас раздевали <<card_game_durak_nude>>'
	if playcardgame_count <= 0:'<br><<$rnd_rebyata>> сказал: - "Что-то уже надоело сегодня играть в карты, давай телек посмотрим или пивка попьем."'
	if playcardgame_count > 0:
		act 'Играть': dynamic $card_game_durak_play
	end
	act 'Уйти': gt 'shulga_room'
}
!игра
$card_game_durak_play = {
	*clr & cla
	minut +=3
	gs'stat'
	!раздевание)
	if card_game_durak_clothes = 0:$cgd_clothes = '<font color=red><b>Вы голая</b></font>'
	if card_game_durak_clothes = 1:$cgd_clothes = 'На вас сейчас надето: трусики'
	if card_game_durak_clothes = 2:$cgd_clothes = 'На вас сейчас надето: трусики, лифчик'
	if card_game_durak_clothes = 3:$cgd_clothes = 'На вас сейчас надето: трусики, лифчик, юбка'
	if card_game_durak_clothes = 4:$cgd_clothes = 'На вас сейчас надето: трусики, лифчик, юбка, майка'
	if card_game_durak_clothes = 5:$cgd_clothes = 'На вас сейчас надето: трусики, лифчик, юбка, майка, носки'
	if card_game_durak_npc_vasya = 0:$cgd_vasya_clothes = '<b>Вася голый</b>'
	if card_game_durak_npc_vasya = 1:$cgd_vasya_clothes = 'На Васе сейчас надето: трусы'
	if card_game_durak_npc_vasya = 2:$cgd_vasya_clothes = 'На Васе сейчас надето: трусы, шорты'
	if card_game_durak_npc_vasya = 3:$cgd_vasya_clothes = 'На Васе сейчас надето: трусы, шорты, майка'
	if card_game_durak_npc_vasya = 4:$cgd_vasya_clothes = 'На Васе сейчас надето: трусы, шорты, майка, носки'
	if card_game_durak_npc_den = 0:$cgd_den_clothes = '<b>Дэн голый</b>'
	if card_game_durak_npc_den = 1:$cgd_den_clothes = 'На Дэне сейчас надето: трусы'
	if card_game_durak_npc_den = 2:$cgd_den_clothes = 'На Дэне сейчас надето: трусы, спортивные штаны'
	if card_game_durak_npc_den = 3:$cgd_den_clothes = 'На Дэне сейчас надето: трусы, спортивные штаны, спортивная куртка'
	if card_game_durak_npc_den = 4:$cgd_den_clothes = 'На Дэне сейчас надето: трусы, спортивные штаны, спортивная куртка, носки'
	if card_game_durak_npc_vitek = 0:$cgd_vitek_clothes = '<b>Витек голый</b>'
	if card_game_durak_npc_vitek = 1:$cgd_vitek_clothes = 'На Вите сейчас надето: трусы'
	if card_game_durak_npc_vitek = 2:$cgd_vitek_clothes = 'На Вите сейчас надето: трусы, джинсы'
	if card_game_durak_npc_vitek = 3:$cgd_vitek_clothes = 'На Вите сейчас надето: трусы, джинсы, рубашка'
	if card_game_durak_npc_vitek = 4:$cgd_vitek_clothes = 'На Вите сейчас надето: трусы, джинсы, рубашка, носки'
	!картинки раздевания
	cgd_clothes_set1 = 6 - card_game_durak_clothes
	'<center><b>Вы играете в дурака на раздевание. Игра будет продолжаться до того момента пока кого-нибудь не разденут.</b></center>'
	'<table width="100%" cellspacing="0" cellpadding="5"><td width="200" valign="top"><img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/<<cgd_clothes_set>>-<<cgd_clothes_set1>>.jpg"></td><td valign="top">'
	'<<$cgd_clothes>>.
	<<$cgd_vasya_clothes>>.
	<<$cgd_den_clothes>>.
	<<$cgd_vitek_clothes>>.'
		if card_game_durak_clothes <=0:
			card_game_durak_nude +=1
			playcardgame_day = daystart
			playcardgame_count -= 1
			rnd_cgd_win_npc = RAND(1,3)
				if rnd_cgd_win_npc = 1:
					$rnd_cgd_win_npc = 'Вася'
					cgd_win_vasya = 1
				end
				if rnd_cgd_win_npc = 2:
					$rnd_cgd_win_npc = 'Дэн'
					cgd_win_den = 1
				end
				if rnd_cgd_win_npc = 3:
					$rnd_cgd_win_npc = 'Витя'
					cgd_win_vitek = 1
				end
			'<b>Игра закончена, на вас не осталось одежды, вы проиграли</b>'
			'Победил: <b><<$rnd_cgd_win_npc>></b>'
			'Вам выполнять его желание'
			if func('zz_reputation','get') < 3:
				act 'Далее': dynamic $card_game_nosex
			end
			if func('zz_reputation','get') >=3 and cg_clother_cum < 5:
				if RAND(0,100) <= 90:
					act 'Далее': dynamic iif(rand(0,100) <= 40, $card_game_gsex, $card_game_rough_sex)
				else
					act 'Далее': dynamic $card_game_nosex
				end
			end
			if func('zz_reputation','get') >=3 and cg_clother_cum >= 5:
				rnd_cgd_win_select = RAND(0,100)
				if rnd_cgd_win_select <= 70:
					act 'Далее': dynamic iif(rand(0,100) <= 40, $card_game_gsex, $card_game_rough_sex)
				end
				if rnd_cgd_win_select > 70 and rnd_cgd_win_select < 90:
					act 'Далее': dynamic $card_game_casual_sex
				end
				if rnd_cgd_win_select >= 90:
					act 'Далее': dynamic $card_game_nosex
				end
			end
		end
		if card_game_durak_npc_vasya <=0 or card_game_durak_npc_den <=0 or card_game_durak_npc_vitek <=0:
			horny += 10
			health += 10
			manna += 5
			playcardgame_day = daystart
			playcardgame_count -= 1
			if card_game_durak_npc_vasya <= 0:
				$cgd_name_igrok = 'Василий'
				cgd_loss_vasya = 1
			end
			if card_game_durak_npc_den <= 0:
				$cgd_name_igrok = 'Дэн'
				cgd_loss_den = 1
			end
			if card_game_durak_npc_vitek <= 0:
				$cgd_name_igrok = 'Виктор'
				cgd_loss_vitek = 1
			end
			''
			'<b>Игра закончена, остался голым <<$cgd_name_igrok>></b>.'
			rnd_cgd_win_select = RAND(0,100)
			if func('zz_reputation','get') < 3:
				act 'Далее': dynamic iif(rnd_cgd_win_select <= 70, $card_game_ggwin_clother, $card_game_ggwin_penis)
			end
			if func('zz_reputation','get') >=3:
			rnd_ggwin_select = RAND(0,100)
				if rnd_cgd_win_select <= 70:
					if rnd_ggwin_select <=50:
						act 'Далее': dynamic $card_game_ggwin_clothercum
					end
					if rnd_ggwin_select >50 and rnd_ggwin_select <90:
						act 'Далее': dynamic $card_game_ggwin_clother
					end
					if rnd_ggwin_select >=90:
						act 'Далее': dynamic $card_game_ggwin_penis
					end
				end
				if rnd_cgd_win_select > 70:
					act 'Далее': dynamic iif(rnd_ggwin_select <= 70, $card_game_gg_lick, $card_game_gg_sex)
				end
			end
		end
		if card_game_durak_clothes >0 and card_game_durak_npc_vasya >0 and card_game_durak_npc_den >0 and card_game_durak_npc_vitek >0:
			card_game_rand = RAND(0,100)
			if card_game_rand <= 60:
				card_game_durak_win +=1
				horny += 5
				manna += 5
				rnd_card_game_npc = RAND(1,3)
				if rnd_card_game_npc = 1: card_game_durak_npc_vasya -=1 & $cgd_name_npc = 'Василий'
				if rnd_card_game_npc = 2: card_game_durak_npc_den -=1 & $cgd_name_npc = 'Дэн'
				if rnd_card_game_npc = 3: card_game_durak_npc_vitek -=1 & $cgd_name_npc = 'Виктор'
				'<img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/card3.jpg">'
				'У вас на руках хорошие карты и вы без труда выигрываете кон. <b>Проиграл <<$cgd_name_npc>></b>.'
				act 'Раздать': dynamic $card_game_durak_play
			end
			if card_game_rand > 60 and card_game_rand < 95:
				card_game_durak_loss +=1
				card_game_durak_clothes -=1
				'<img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/card1.jpg">'
				'У вас на руках плохие карты. <b>Вы проиграли</b>.'
				act 'Раздать': dynamic $card_game_durak_play
			end
			if card_game_rand>=95:
				card_game_durak_draw +=1
				'<img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/card1.jpg">'
				'У вас на руках простенькие карты, но вы так удачно вывернулись, что получилось сыграть вничью.'
				act 'Раздать': dynamic $card_game_durak_play
			end
		end
	'</td></tr></table>'
}
!--------------------------!
!когда гг проиграла в карты!
!==========================!
!выполнение желания нпс (репа GorSlut < 3, тогда небольшое шоу)
$card_game_nosex_dance = {
	*clr & cla
	minut +=5
	gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/gif/dance'+rand(1,10)+'.gif', func('cardgame_durak_strings', '1')
	act 'Уйти': gt 'shulga_room'
}
!загадывание желания нпс (репа GorSlut < 3)
$card_game_nosex = {
	*clr & cla
	minut +=5
	gs'stat'
	!добавляем различные варианты проигрыша
	card_game_texta = RAND(0,6)
			if card_game_texta = 0:$card_game_texta = 'Хочу чтобы ты мне отсосала!'
			if card_game_texta = 1:$card_game_texta = 'Может подрочишь мне?'
			if card_game_texta = 2:$card_game_texta = 'Поцелуй меня в хуй!'
			if card_game_texta = 3:$card_game_texta = 'Возьми за щеку!'
			if card_game_texta = 4:$card_game_texta = 'Хочу тебя трахнуть!'
			if card_game_texta = 5:$card_game_texta = 'Хочу потрогать твою пизду!'
			if card_game_texta = 6:$card_game_texta = 'Дай помацать свои сиськи!'
			if card_game_texta = 7:$card_game_texta = 'Дай потрогать сиськи!'
	if cgd_win_vasya = 1:
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vasya.jpg', func('cardgame_durak_strings', '2')
	end
	if cgd_win_den = 1:
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/den.jpg', func('cardgame_durak_strings', '3')
	end
	if cgd_win_vitek = 1:
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vitek.jpg', func('cardgame_durak_strings', '4')
	end
	act 'Танцевать': dynamic $card_game_nosex_dance
}
!когда гг проиграла в карты (репа GorSlut >= 3), секс
$card_game_gsex = {
	*clr & cla
	minut +=2
	horny += 10
	if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
	if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
	if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
	gs 'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_1.jpg', func('cardgame_durak_strings', '5')
	act 'Далее':
		*clr & cla
		minut +=3
		horny += 10
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_2.jpg', func('cardgame_durak_strings', '6')
		act 'Далее':
			*clr & cla
			minut +=10
			horny += 10
			bj +=1
			gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_3.jpg', func('cardgame_durak_strings', '7')
			if horny >=70:
				orgasm += 1
				horny = 0
				manna += 35
				mastr +=1
		gs 'zz_render', '', '', func('cardgame_durak_strings', '8')
			end
			act 'Далее':
				*clr & cla
				minut +=10
				horny += 10
				sex += 1
				gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_4.jpg', func('cardgame_durak_strings', '9')
				act 'Далее':
					*clr & cla
					minut +=10
					horny += 10
					gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_5.jpg', func('cardgame_durak_strings', '10')
					act 'Далее':
						*clr & cla
						minut +=10
						horny += 20
						throat += 1
						gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_6.jpg', func('cardgame_durak_strings', '11')
						if horny >=70:
							orgasm += 1
							horny = 0
							manna += 35
	gs 'zz_render', '', '', func('cardgame_durak_strings', '12')
						end
						act 'Далее':
							*clr & cla
							minut += 5
							gs 'zz_funcs', 'cum', 'lip'
							gs 'zz_funcs', 'cum', 'face'
							son -= 2
							gs'stat'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/gsex/ev1_7.jpg', func('cardgame_durak_strings', '13')
							act 'Уйти': gt 'shulga_room'
						end
					end
				end
			end
		end
	end
}
!когда гг проиграла в карты (репа GorSlut >= 3), грубый секс
$card_game_rough_sex = {
	$rnd_img_rough_bj = '<img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/sexrough/bj'+rand(1,10)+'.gif">'
	$rnd_img_rough_sex1 = '<img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/sexrough/sex1_'+rand(1,10)+'.gif">'
	$rnd_img_rough_sex2 = '<img src="images/zsoft/pod_ezd/shulgahome/bigroom/card/sexrough/sex2_'+rand(1,10)+'.gif">'
	*clr & cla
	minut +=5
	bj +=1
	throat += 1
	horny += 5
	dom -= 1
	if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
	if $npc['11,sex'] = 0: $npc['11,sex'] = 1 & guy += 1
	if $npc['9,sex'] = 0: $npc['9,sex'] = 1 & guy += 1
	gs'stat'
	'<center><<$rnd_img_rough_bj>></center>'
	gs 'zz_render', '', '', func('cardgame_durak_strings', '14')
	act 'Далее':
		*clr & cla
		minut +=10
		anal += 1
		gs 'zz_funcs', 'cum', 'anus'
		horny += 10
		gs 'stat'
		'<center><<$rnd_img_rough_sex1>></center>'
		gs 'zz_render', '', '', func('cardgame_durak_strings', '15')
		if analplugin = 1:
			analplugin = 0
			gs 'zz_render', '', '', func('cardgame_durak_strings', '16')
		end
		if lubri > 0:
			agape = 2
			agapetime = totminut + (agape + 1) * 1440
			horny += 10
			gs 'zz_render', '', '', func('cardgame_durak_strings', '17')
		end
		gs 'zz_render', '', '', func('cardgame_durak_strings', '18')
		act 'Далее':
			*clr & cla
			minut +=20
			horny += 10
			guy += 2
			gang +=1
			cumfrot += 1
			gs 'zz_funcs', 'cum', 'ass'
			son -= 2
			gs 'stat'
			'<center><<$rnd_img_rough_sex2>></center>'
			gs 'zz_render', '', '', func('cardgame_durak_strings', '19')
			if horny >=70:
				orgasm += 1
				horny = 0
				manna += 35
				mastr += 1
				gs 'zz_render', '', '', func('cardgame_durak_strings', '20')
			end
			gs 'zz_render', '', '', func('cardgame_durak_strings', '21')
			act 'Показать':
				*clr & cla
				minut +=5
				gs 'stat'
				gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sexrough/ass'+rand(1,11)+'.jpg', func('cardgame_durak_strings', '22')
				act 'Уйти': gt 'zz_bathroom', 'start'
			end
		end
	end
}
$card_game_casual_sex = {
	*clr & cla
	minut +=5
	dom -= 1
	gs'stat'
	gs 'zz_render', '', '', func('cardgame_durak_strings', '23')
	act 'Далее':
		*clr & cla
		minut +=10
		horny += 5
		guy += 1
		bj +=1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/street_event/sexbj1.gif" width="642" height="490', func('cardgame_durak_strings', '24')
		act 'Далее':
			*clr & cla
			minut +=10
			horny += 15
			sex += 1
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/street_event/sex1.gif" width="570" height="576', func('cardgame_durak_strings', '25')
			if horny >=70:
				orgasm += 1
				horny = 0
				manna += 25
				mastr +=1
				gs 'zz_render', '', '', func('cardgame_durak_strings', '26')
			end
			gs 'zz_render', '', '', func('cardgame_durak_strings', '27')
			act 'Уйти': gt 'shulga_room'
		end
	end
}
!-------------------!
!гг победила в карты!
!===================!
!Когда гг победила, загадывает желание (репа GorSlut < 3) (срыв одежды)
$card_game_ggwin_clother = {
	*clr & cla
	minut +=3
	gs'stat'
	if cgd_loss_vasya = 1:
	$loss_npc_name = 'Вася'
	$loss_npc_name2 = 'Василию'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/vasya.jpg"></center>'
	end
	if cgd_loss_den = 1:
	$loss_npc_name = 'Дэн'
	$loss_npc_name2 = 'Дэну'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/den.jpg"></center>'
	end
	if cgd_loss_vitek = 1:
	$loss_npc_name = 'Витя'
	$loss_npc_name2 = 'Витьку'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/vitek.jpg"></center>'
	end
	gs 'zz_render', '', '', func('cardgame_durak_strings', '28')
	act 'Далее':
		*clr & cla
		minut +=15
		gs'stat'
		'<center>Проигравшему пришлось выполнять ваше желание.</center>'
		gs 'zz_render', '', '', func('cardgame_durak_strings', '29')
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/street_event/j'+RAND(1,12)+'.gif', func('cardgame_durak_strings', '30')
		act 'Уйти': gt 'shulga_room'
	end
}
!Когда гг победила, загадывает желание (репа GorSlut < 3) (трясти гениталиями)
$card_game_ggwin_penis = {
	*clr & cla
	minut +=5
	gs'stat'
	if cgd_loss_vasya = 1:
	$loss_npc_name = 'Вася'
	$loss_npc_name2 = 'Василию'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/vasya.jpg"></center>'
	end
	if cgd_loss_den = 1:
	$loss_npc_name = 'Дэн'
	$loss_npc_name2 = 'Дэну'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/den.jpg"></center>'
	end
	if cgd_loss_vitek = 1:
	$loss_npc_name = 'Витя'
	$loss_npc_name2 = 'Витьку'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/vitek.jpg"></center>'
	end
	gs 'zz_render', '', '', func('cardgame_durak_strings', '31')
	act 'Далее':
		*clr & cla
		minut +=15
		gs'stat'
		'<center>Проигравшему пришлось выполнять ваше желание.</center>'
		gs 'zz_render', '', '', func('cardgame_durak_strings', '32')
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/street_event/p'+RAND(1,3)+'.gif', func('cardgame_durak_strings', '33')
		act 'Уйти': gt 'shulga_room'
	end
}
!Когда гг победила, загадывает желание (репа GorSlut > 3) (кончить на жертву)
$card_game_ggwin_clothercum = {
	*clr & cla
	minut +=5
	cg_clother_cum +=1
	gs'stat'
	if cgd_loss_vasya = 1:
	$loss_npc_name = 'Вася'
	$loss_npc_name2 = 'Василию'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/vasya.jpg"></center>'
	end
	if cgd_loss_den = 1:
	$loss_npc_name = 'Дэн'
	$loss_npc_name2 = 'Дэну'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/den.jpg"></center>'
	end
	if cgd_loss_vitek = 1:
	$loss_npc_name = 'Витя'
	$loss_npc_name2 = 'Витьку'
	$loss_npc_img = '<center><img src="images/zsoft/pod_ezd/shulgahome/vitek.jpg"></center>'
	end
	gs 'zz_render', '', '', func('cardgame_durak_strings', '34')
	act 'Далее':
		*clr & cla
		minut +=10
		horny += 5
		bj +=1
		gs'stat'
		gs 'zz_render', '', '', func('cardgame_durak_strings', '35')
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/street_event/bj'+RAND(1,2)+'.gif', func('cardgame_durak_strings', '36')
		act 'Далее':
			*clr & cla
			minut +=5
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/street_event/cum'+RAND(1,2)+'.gif', func('cardgame_durak_strings', '37')
			act 'Уйти': gt 'shulga_room'
		end
	end
}
!Когда гг победила, загадывает желание (репа GorSlut >= 3), лизать
$card_game_gg_lick = {
	*clr & cla
	minut +=1
	gs'stat'
	if cgd_loss_vasya = 1:
		$lick_name_npc = 'Вася'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vasya.jpg', func('cardgame_durak_strings', '38')
	end
	if cgd_loss_den = 1:
		$lick_name_npc = 'Дэн'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/den.jpg', func('cardgame_durak_strings', '39')
	end
	if cgd_loss_vitek = 1:
		$lick_name_npc = 'Витек'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vitek.jpg', func('cardgame_durak_strings', '40')
	end
	act 'Далее':
		*clr & cla
		horny += 15
		minut +=10
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/lick'+rand(1,6)+'.jpg', func('cardgame_durak_strings', '41')
			if horny >=70:
				orgasm += 1
				horny = 0
				gs 'zz_render', '', '', func('cardgame_durak_strings', '42')
			else
				gs 'zz_render', '', '', func('cardgame_durak_strings', '43')
			end
		act 'Уйти': gt 'shulga_room'
	end
}
!Когда гг победила, загадывает желание (репа GorSlut >= 3), секс
$card_game_gg_sex = {
	*clr & cla
	minut +=1
	gs'stat'
	if cgd_loss_vasya = 1:
		$lick_name_npc = 'Вася'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vasya.jpg', func('cardgame_durak_strings', '44')
	end
	if cgd_loss_den = 1:
		$lick_name_npc = 'Дэн'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/den.jpg', func('cardgame_durak_strings', '45')
	end
	if cgd_loss_vitek = 1:
		$lick_name_npc = 'Витек'
	gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/vitek.jpg', func('cardgame_durak_strings', '46')
	end
	act 'Далее':
		*clr & cla
		horny += 15
		minut +=10
		sex += 1
		gs'stat'
		gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/sex'+rand(1,7)+'.jpg', func('cardgame_durak_strings', '47')
		dynamic $gg_sex_orgasm
		act 'Далее':
			*clr & cla
			minut +=5
			gs 'zz_funcs', 'cum', 'belly'
			cumfrot += 1
			gs'stat'
			gs 'zz_render', '', 'images/zsoft/pod_ezd/shulgahome/bigroom/card/sex/cum'+rand(1,6)+'.jpg', func('cardgame_durak_strings', '48')
			act 'Уйти': gt 'shulga_room'
		end
	end
}