﻿if $args[0] = 'local_str1': $result = 'Наиобыкновеннейшая шашлычная, коих много на просторах страны.**Стоимость обеда - 300 рублей**Время работы кафе - с 12:00 до 04:00'
if $args[0] = 'local_str2': $result = 'За барной стойкой стоит улыбчивая <a href="exec:GT ''lakecafe'',''barmensha''">'+iif(barmenshameet = 0,'барменша','Женя')+$_str
if $args[0] = 'local_str3': $result = '<a href="exec:GT ''laketoilet'',''main''">Туалет</a>'
if $args[0] = 'local_str5': $result = 'Барменша подняла на вас глаза и, с улыбкой, спросила:**-Желаете чего- нибудь?'
if $args[0] = 'local_str6': $result = 'Женя улыбнулась, когда вы подошли к ней**-Привет! - с улыбкой сказала она'
if $args[0] = 'local_str7': $result = 'Вы поболтали с барменшей. В ходе разговора вы выяснили, что её зовут Женя и она работает тут вместе со своей подругой, Анжелой, которая в шашлычной на должности повара.'
if $args[0] = 'local_str8': $result = 'Вы разговариваете с Женей о делах, работе, жизни и всяких пустяках.'
if $args[0] = 'local_str9': $result = 'Вы болтаете с Женей, делая ей неоднозначные намёки. Женя, кажется, понимает вас и предлагает вам пойти за ней. Вы соглашаетесь и следуете вместе с ней на кухню.'
if $args[0] = 'local_str10': $result = 'Вы спрашиваете Женю о работе. Она вам говорит, что её сестре необходима помощь на кухне, приходить в 18 часов, работать нужно полтора часа, за это вам будут платить 175 рублей.'
if $args[0] = 'local_str11': $result = 'Вы спрашиваете Женю о работе. Она вам напоминает о том, что её сестре необходима помощь на кухне, приходить в 18 часов, работать нужно полтора часа, за это платят 175 рублей.'
if $args[0] = 'local_str12': $result = 'Вы спрашиваете Женю об "особой" работе. Она говорит вам, что по понедельникам, в 22 часа, в кафе приходят посетители, которые нуждаются в качественном "обслуживании". Платят от 500 до 2000 рублей.'
if $args[0] = 'local_str13': $result = 'Вы спрашиваете Женю о работе. Она напоминает вам условия: по понедельникам, в 22 часа, нужно будет "обслужить" определённых посетителей. За это платят от 500 до 2000 рублей.'