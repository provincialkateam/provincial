$sexloc = $CURLOC
gs 'stat'
gs 'zz_render','','images/img/centr/boul.jpg'
act 'Уйти':gt'center'
if hour >= 8 and hour <= 20:
	act 'Сыграть 300 руб час':
		if money < 300:
			gs 'zz_render','','','У вас нет денег'
		else
			money -= 300
			minut += 60
			boulvar = 0
			boulingnav += RAND(0,3)
			boulrand = RAND(0,9)
			if boulrand = 0:
				cla
				gs 'zz_render','','','К вам подходят двое парней и предлагают сыграть с ними'
				act 'Играть на деньги, ставка 2000':boulvar = 1 & gt'bouling','randwin'
				act 'Уйти':gt'center'
			elseif boulrand = 1:
				cla
				gs 'zz_render','','','К вам подходят две девушки и предлагают сыграть с ними против двух парней, приз 5000, при проигрыше секс.'
				act 'Играть':boulvar = 2 & gt'bouling','randwin'
				act 'Уйти':gt'center'
			elseif boulrand > 1:
				cla
				gs 'zz_render','','','Вы поиграли в бильярд'
				act 'Уйти':gt'center'
			end
		end
	end
	if money >= 300:
		act 'Сыграть на деньги':
			money -= 300
			minut += 60
			boulvar = 0
			gt'bouling','randwin'
		end
	end
end
if $ARGS[0] = 'randwin':
	cla
	if boulingnav < 10:
		boulwin = RAND(0,10)
	elseif boulingnav >= 90:
		boulwin = RAND(0,28)
	else
		boulwin = RAND(0,boulingnav/5+10)
	end
	if boulwin > 10 and boulvar = 0:
		money += 300
		gs 'zz_render','','','Вы выиграли и получили 300 руб.'
		act 'Уйти':gt'center'
	elseif boulwin > 10 and boulvar = 1:
		money += 2000
		gs 'zz_render','','','Вы выиграли и получили 2000 руб.'
		act 'Уйти':gt'center'
	elseif boulwin > 10 and boulvar = 2:
		money += 5000
		gs 'zz_render','','','Вы выиграли и получили 5000 руб.'
		act 'Уйти':gt'center'
	elseif boulwin <= 10 and boulvar = 0:
		money -= 300
		gs 'zz_render','','','Вы проиграли и заплатили 300 руб.'
		act 'Уйти':gt'center'
	elseif boulwin <= 10 and boulvar = 1:
		picrand = 14
		if money >= 2000:
			gs 'zz_render','','','Вы проиграли и должны заплатить 2000 руб.'
			act 'Предложить натурой':xgt'sexdvoe','var'
			act 'Заплатить':
				money -= 2000
				gt'center'
			end
		else
			gs 'zz_render','','','Вы проиграли, но у вас нет денег чтобы расплатиться, способ оплаты лишь один.'
			act 'Натурой':xgt'sexdvoe','var'
		end
	elseif boulwin <= 10 and boulvar = 2:
		picrand = 11
		gs 'zz_render','','','Вы проиграли, придется раздвигать ноги.'
		act 'Платить':gt'sexorg','var'
	end
end
if $ARGS[0] = 'start':
	gs 'zz_render','','images/img/centr/boul.jpg'
	act 'Уйти':gt'bouling'
end