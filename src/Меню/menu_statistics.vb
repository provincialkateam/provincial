gs 'stat'
if $args[0] = '' or $args[0] = 'main':
	!---
	$_str = '<div class="stat_header" onclick="javascript:toggleView(\"stat_school\");">Учёба</div>'
	$_str += '<div id="stat_school" class="stat_category">'
	if school['certificate'] = 1:
		$_str += 'Вы закончили школу.**'
	else
		$_str += 'Вы учитесь в школе.**'
	end
	if diplom = 1: $_str += 'Вы закончили университет.'
	$_str += '</div>'
	!---
	$_str += '<div class="stat_header" onclick="javascript:toggleView(\"stat_house\");">Проживание</div>'
	$_str += '<div id="stat_house" class="stat_category">'
	if (BuyHous = 2 and ArendHouseSL > 0) or BuyHous = 1:
		$_str += 'Квартира в Южном районе арендована на <<ArendHouseSL>> дней.'
	else
		$_str += 'Вы живёте в квартире родителей в Павлово.'
	end
	$_str += '</div>'
	!---
	$_str += '<div class="stat_header" onclick="javascript:toggleView(\"stat_sport\");">Спорт</div>'
	$_str += '<div id="stat_sport" class="stat_category">'
	if (KikWinPro + KikLossPro + KikDrawPro + Win + Loss + razradKik + KikWinAm + KikLossAm + KikDrawAm+razradbeg+kolsorev+bronzebeg+silverbeg+goldbeg+razradbegEB+razradbegES+razradbegEG) = 0:
		$_str += 'У вас нет спортивных достижений.**'
	else
		if KikWinPro > 0 or KikLossPro > 0 or KikDrawPro > 0:
			$_str += 'Профессиональный рекорд. Победы-Поражения-Ничьи (Победы нокаутом)**'
			$_str += '<<KikWinPro>> - <<KikLossPro>> - <<KikDrawPro>> (<<KikKOPro>> КО)**'
		end		$_str += 'Побед в драках <<Win>>, поражений в драках <<Loss>>**'
		if razradKik > 0:$_str += 'У вас '+func('menu_statistics','razrad',razradKik)+' по кикбоксингу**'
		if KikWinAm > 0:$_str += 'Побед в кикбоксинге среди любителей - <<KikWinAm>>**'
		if KikLossAm > 0:$_str += 'Поражений в кикбоксинге среди любителей - <<KikLossAm>>**'
		if KikDrawAm > 0:$_str += 'Ничьих в кикбоксинге среди любителей - <<KikDrawAm>>**'
		if razradbeg > 0:$_str += 'У вас '+func('menu_statistics','razrad',razradbeg)+' по бегу**'
		if kolsorev  > 0:$_str += '<<kolsorev>> раз принимали участие в соревнованиях по бегу**'
		if bronzebeg > 0:$_str += '<<bronzebeg>> - бронзовых медалей по бегу**'
		if silverbeg > 0:$_str += '<<silverbeg>> - серебряных медалей по бегу**'
		if goldbeg > 0:$_str += '<<goldbeg>> - золотых медалей по бегу**'
		if razradbegEB > 0: $_str += '<<razradbegEB>> кратный бронзовый призёр чемпионата Европы**'
		if razradbegES > 0: $_str += '<<razradbegES>> кратная вице-чемпионка Европы**'
		if razradbegEG > 0: $_str += '<<razradbegEG>> кратная чемпионка Европы.'
	end
	$_str += '</div>'
	!---
	$_str += '<div class="stat_header" onclick="javascript:toggleView(\"stat_naughty\");">Развращённость</div>'
	$_str += '<div id="stat_naughty" class="stat_category">'
		if shameless['flag'] = 0:
			$_str += 'Вы совершенно не развратны. Любое эротическое событие заставляет вас краснеть.**'
		elseif shameless['flag'] = 1:
			$_str += 'Вы  потеряли стеснение, вы даже можете совершенно раздеться на пляже.**'
		elseif shameless['flag'] = 2:
			$_str += 'Вы потряли всякий стыд.**'
		elseif shameless['flag'] = 3:
			$_str += 'Вы максимально развратны и готовы учствовать в любых извращениях.**'
		end
	if exhibi > 0:$_str += 'Опыт эксгибиционизма <<exhibi>>'
	if voyeurism > 0:$_str += '**Вы <<voyeurism>> раз подглядывали за людьми.'
	if piss > 0:$_str += '**Вы писали в людных местах <<piss>> раз.'
	if modelfoto > 0:$_str += '**Вы снимались обнаженной <<modelfoto>> раз'
	if film > 0: $_str += '**В порно индустрии вас знают под именем <<$pfname>>. Вы снимались в порно <<film>> раз.'
	if stripdancesum > 0:$_str += '**<<stripdancesum>> раз танцевали стриптиз в клубе'
	if profiDanceTime > 0:$_str += '**Вы <<profiDanceTime>> раз профессионально танцевали.'
	$_str += '</div>'
	!---
	$_str += '<div class="stat_header" onclick="javascript:toggleView(\"stat_sex\");">Секс</div>'
	$_str += '<div id="stat_sex" class="stat_category">'
	if (mastr + gang + sex + bj + hj + rape + spank + slutty + orgasm + vaginalOrgasm + analorgasm + DPorgasm + swallow + facial + frot + lesbian + sexfuta) = 0:
		$_str += 'У вас нет никакого сексуального опыта'
	else
		if mastr > 0:$_str += 'Мастурбировали <<mastr>> раз'
		if bj > 0:$_str += '**Минетов сделано <<bj>> раз' + iif(gloryhole > 0,', из них <<gloryhole>> раз отсосали у незнакомцев через дыру в стене.','')
		if hj > 0:$_str += '**Дрочили парням <<hj>> раз.'
		if swallow > 0:$_str += '**Спермы проглочено <<swallow>> раз'
		if facial > 0:$_str += '**Кончили вам на лицо <<facial>> раз'
		if frot > 0:$_str += '**Кончили вам на одежду <<frot>> раз'
		if sex > 0:$_str += '**Вагинальный секс <<sex>> раз.'
		if anal > 0:$_str += '**Анальный секс <<anal>> раз.'
		if kuni > 0:$_str += '**Вам сделали кунилингус <<kuni>> раз.'
		if lesbian > 0:$_str += '**Вы занимались леcбийским сексом <<lesbian>> раз.'
		if gang > 0:$_str += '**Групповой секс <<gang>> раз'
		if rape > 0:$_str += '**Вас изнасиловали <<rape>> раз.'
		if spank > 0:$_str += '**Вам напороли задницу <<spank>> раз.'
		if slutty > 0:$_str += '**Продавали свою любовь <<slutty>> раз.'
		if orgasm > 0:$_str += '**Испытали оргазм <<orgasm>> раз:'
		if vaginalOrgasm > 0:$_str += '**&nbsp;&nbsp;&nbsp;&nbsp;<<vaginalOrgasm>> вагинальных оргазмов во время секса.'
		if analorgasm > 0:$_str += '**&nbsp;&nbsp;&nbsp;&nbsp;<<analorgasm>> анальных оргазмов'
		if DPorgasm > 0:$_str += '**&nbsp;&nbsp;&nbsp;&nbsp;<<DPorgasm>> оргазмов от двойного проникновения'
		if sexfuta > 0:$_str += '**Вы <<sexfuta>> раз занимались сексом с членодевкой.'
	end
	$_str += '</div>'
	!---
	$_str += '<div class="stat_header" onclick="javascript:toggleView(\"stat_partners\");">Партнёры</div>'
	$_str += '<div id="stat_partners" class="stat_category">'
	if (girl + guy + sexfuta) = 0:
		$_str += 'У вас не было половых партнеров.**'
	else
		if girl > 0: $_str += 'У вас было <<girl>> девушек.**'
		if guy > 0: $_str += 'У вас было <<guy>> парней.**'
		if divorced > 0: $_str += 'У вас было <<divorced>> мужей.'
	end
	$_str += '</div>'
	!---
	$_str += '<div class="stat_header" onclick="javascript:toggleView(\"stat_jobs\");">Работа</div>'
	$_str += '<div id="stat_jobs" class="stat_category">'
	i = 0
	:loop
	if i < 6:
		if job_statistics['<<i>>,shift'] > 0:
			!ФУНКЦИЯ НЕ СРАБАТЫВАЕТ. ПРОШУ КОРИФЕЕВ ПОСМОТРЕТЬ В ЧЕМ ДЕЛО
			$_str += func('menu_statistics','jobs', i)
			$_str += '**&nbsp;&nbsp;&nbsp;&nbsp;Отработали ' + job_statistics['<<i>>,shift'] + ' смен/раз.'
			$_str += '**&nbsp;&nbsp;&nbsp;&nbsp;Заработали ' + job_statistics['<<i>>,money'] + ' рублей.'
			$_str += '**&nbsp;&nbsp;&nbsp;&nbsp;Дополнительный доход ' + job_statistics['<<i>>,extramoney'] + ' рублей.'
			$_str +=  $job_notes['<<i>>,text']
		end
		i = i + 1
		jump 'loop'
	end
	!$_str += '</div>'
	!---
	gs 'zz_render','','','<div id="statistics">' + $_str + '</div>'
	killvar '$_str'
end
if $args[0] = 'razrad':
	if args[1] > 6: args[1] = 6
	$s_str[0] = 'нет разряда'
	$s_str[1] = 'III любительский разряд'
	$s_str[2] = 'II любительский разряд'
	$s_str[3] = 'I любительский разряд'
	$s_str[4] = 'звание Кандидата в Мастера Спорта'
	$s_str[5] = 'звание Мастера Спорта'
	$s_str[6] = 'звание Мастера Спорта Международного класса'
	$result = $s_str[args[1]]
	killvar '$s_str'
end
if $args[0] = 'jobs':
	$s_str[0] = '**Вы работали в отеле в Павлово'
	$s_str[1] = '**Вы раздавали флаеры в парках'
	$s_str[2] = '**Вы работали в поликлинике'
	$s_str[3] = '**Вы работали в кафе DelParco'
	$s_str[4] = '**Вы работали в кафешке Гиви в Южном районе'
	$s_str[5] = '**Вы работали в шашлычной в Северном районе'
	$result = $s_str[args[1]]
	killvar '$s_str'
end