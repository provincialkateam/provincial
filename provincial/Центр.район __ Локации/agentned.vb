if $ARGS[0] = 'start':
	*clr & cla
	minut += 10
	gs 'stat'
	$_str = ''
	if ArendHouseSL = 0: $_str += ''+iif(money >= 10000,'Возле стойки также стоит мужчина со скучающим видом.<br><a href="exec:GT ''agentned'',''rent_event_1''">Подойти к стойке</a><br>','')
	if ArendHouseSL > 0: $_str += '<br>У вас <B><<ArendHouseSL>> дней</B> аренды.**'
	if ArendHouseSL = 0: $_str += ''+iif(karta >= 10000,'<a href="exec:GT ''agentned'',''rent''">Арендовать</a>','При наличии средств, вы можете арендовать')+' квартиру в спальном районе(10 тыс. рублей в месяц)**'
	if BuyHous = 0 and sdamonth = 0: $_str += ''+iif(karta >= 2000000,'<a href="exec:GT ''agentned'',''buy''">Купить квартиру</a>','При наличии средств, вы можете купить квартиру')+' за 2 млн. рублей.**'
	if BuyHous = 1: $_str += '<a href="exec:GT ''agentned'',''sell''">Продать квартиру</a> за 1 млн. рублей.**'
	if dachaest = 0: $_str += ''+iif(karta >= 100000,'<a href="exec:GT ''agentned'',''buy_dacha''">Купить дачу</a>','При наличии средств, вы можете купить дачу')+' за 100 тыс.руб.**'
	if dachaest = 1: $_str += '<a href="exec:GT ''agentned'',''sell_dacha''">Продать дачу</a> за 50 тыс.руб.**'
	gs 'zz_render', 'Агентсво недвижимости', 'images/pic/agenstvo.jpg', 'Главный офис самого крупного агенства недвижимости в области.<br>На ресепшене вы замечаете банер, где крупным шрифтом написано:**<b>"Ув. клиенты! Обращаем ваше внимание, что все операции покупки-продажи производятся исключительно через безналичные средства оплаты."</b>**' + $_str
	killvar '$_str'
	act '<B>Выйти</B>': gt'down'
end
if $ARGS[0] = 'buy':
	*clr & cla
	minut += 30
	karta -= 2000000
	BuyHous = 1
	housr = 1
	gs 'stat'
	gs 'zz_render', 'Агентсво недвижимости', 'images/pic/agenstvo_paperwork.jpg', func('agentned_strings', 'local_str2')
	act '<B>Выйти</B>': gt 'agentned', 'start'
end
if $ARGS[0] = 'sell':
	*clr & cla
	minut += 30
	karta += 1000000
	BuyHous = 0
	if ArendHouseSL = 0:housr = 0
	gs 'stat'
	gs 'zz_render', 'Агентсво недвижимости', 'images/pic/agenstvo_paperwork.jpg', func('agentned_strings', 'local_str3')
	act '<B>Выйти</B>': gt'agentned', 'start'
end
if $ARGS[0] = 'rent':
	*clr & cla
	minut += 30
	karta -= 10000
	housr = 1
	ArendHouseSL += 30
	gs 'stat'
	gs 'zz_render', 'Агентсво недвижимости', 'images/pic/agenstvo_paperwork.jpg', func('agentned_strings', 'local_str4')
	act '<B>Выйти</B>': gt'agentned', 'start'
end
if $ARGS[0] = 'buy_dacha':
	*clr & cla
	minut += 30
	karta -= 100000
	dachaest = 1
	!etoexhib = 0
	gs 'stat'
	gs 'zz_render', 'Агентсво недвижимости', 'images/pic/agenstvo_paperwork.jpg', func('agentned_strings', 'local_str5')
	act '<B>Выйти</B>': gt'agentned', 'start'
end
if $ARGS[0] = 'sell_dacha':
	*clr & cla
	minut += 30
	karta += 50000
	dachaest = 0
	gs 'stat'
	gs 'zz_render', 'Агентсво недвижимости', 'images/pic/agenstvo_paperwork.jpg', func('agentned_strings', 'local_str6')
	act '<B>Выйти</B>': gt'agentned', 'start'
end
if $ARGS[0] = 'rent_event_1':
  if ArendHouseSL = 0:
    gt 'rent_flat_oleg', 'rent_event_1', 0
  end
end