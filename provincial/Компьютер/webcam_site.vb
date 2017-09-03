!кол-во шоу в сутки:
if webcam_show_day ! daystart: webcam_show_count = 2
!-----------------------------------------------!
!------Страница регистрации онлайн чата---------!
!-----------------------------------------------!
$webcam_rega = {
*clr & cla
minut += 5
gs 'stat'
'Регистрация в онлайн чате, придумайте себе псевдоним...'
!$web_gg_name = '<<$name[2]>>'
$webcam_name = input ('Ваш псевдоним...')
cla
'Ваш псевдоним: <<$webcam_name>>'
act 'Далее': gt 'webcam_site'
!if $webcam_name = 0: $webcam_name = $web_gg_name
}
!-----------------------------------------------!
!-------Страница статистики онлайн чата---------!
!-----------------------------------------------!
$webcam_stat = {
*clr & cla
minut += 5
gs'stat'
'Ваша статистика вебкам чатов под псевдонимом: <<$webcam_name>>
Вы устраивали шоу: <<webcam_show_counter>>
делали растяжку: <<webcam_show_flex>>
танцевали стриптиз: <<webcam_show_strip>>
игрались с грудью: <<webcam_show_tits>>
мастурбировали: <<webcam_show_mast>>
засовывали дилдо в рот: <<webcam_show_throat>>
засовывали дилдо в письку: <<webcam_show_pussy>>
засовывали дилдо в попку: <<webcam_show_anus>>
засовывали дилдо сразу в письку и попку: <<webcam_show_dp>>
Фистинг анальный: <<webcam_show_afisting>>
Фистинг вагинальный: <<webcam_show_vfisting>>
сквиртовали: <<webcam_show_squirt>>
получали оргазм: <<webcam_show_orgazm>>
<hz>
Общее время ваших онлайн чатов: <<webcam_show_time>> минут.
На чаевых вы заработали: <<webcam_show_money>> рублей.
'
act 'На главную': gt 'webcam_site'
}
!-----------------------------------------------!
!-------Страница помощи онлайн чата-------------!
!-----------------------------------------------!
$webcam_help = {
*clr & cla
minut += 5
gs'stat'
'
Описание сервиса:
Видеочат - это программное обеспечение, позволяющее вести видеоголосовое общение пользователей в режиме реального времени в чате при помощи веб-камеры
После регистрации вы сможете устраивать шоу трансляции, получать чаевые. Для того что бы получать больше чаевых вы должны понимать, что от вас хотят пользователи.
Небольшие подсказки для увеличения чаевых:
Купите дилдо в секс шопе (понадобятся: маленький фалоимитатор, средний 15см фалоимитатор, большой 25см фалоимитатор, 40 см фалоимитатор)
Чем дилдо больше, тем больше вы получаете чаевые.
Так же за фистинг дают много чаевых, но для этого у вас должны быть хорошо разработаны дырки, желательно иметь лубрикант, иначе все будет болеть и не сможете устраивать шоу.
За оргазм получаете бонус чаевых.
'
act 'На главную': gt 'webcam_site'
}
!-----------------------------------------------!
!--------Главная страница онлайн чата-----------!
!-----------------------------------------------!
!if $args[0] = 'webcam_site':
*clr & cla
minut += 1
gs'stat'
	'<center>Онлайн видео чат с лучшими девушками Интернета!</center>'
	'<center><img src="images/zsoft/webcam/webcam.jpg"></center>'
if $webcam_name = 0: '<center>Если вы красивы и хотите немного заработать показывая себя, вам нужно иметь вебкамеру и пройти простую регистрацию.</center>'
	if $webcam_name > 0: '<center>Ваш псевдоним: <<$webcam_name>></center>'
	if $webcam_name > 0: '<center><a href="exec: dynamic $webcam_stat">Посмотреть вашу статистику</a></center>'
	if webcam_show_count <= 0: 'Сегодня вы уже устраивали шоу. Надо дать отдохнуть себе и зрителям.'
act 'Выйти': gt 'Komp', 'start'
if $webcam_name = 0: act 'Регистрация': dynamic $webcam_rega
if $webcam_name > 0 and webcam_show_count > 0: act 'Начать шоу': dynamic $webcam_index
if $webcam_name > 0: act 'Помощь': dynamic $webcam_help
if $webcam_name > 0: act 'Сменить псевдоним': dynamic $webcam_rega
$webcam_index = {
!act 'Выход': gt 'Komp', 'start'
		if week < 6 and hour < 19 or week >= 6 and hour < 15:
			if week < 6 and hour >= 7 and hour < 19: 'Еще рано устраивать шоу, большинство зрителей на работе.'
			if week >= 6 and hour >= 7 and hour < 15: 'Еще рано устраивать шоу, большинство зрителей все еще отсыпаются после трудовой недели.'
			if hour >= 0 and hour < 7: 'Уже так поздно. Вы не хотите распугать всех своих зрителей сонным видом.'
			if func('zz_reputation','get') < 1: 'Я стесняюсь вытворять... всякое. Пусть и всего лишь перед камерой.'
		else
			my_show_show = 0
			my_show_tits = 0
			my_show_mast = 0
			my_show_throat = 0
			my_show_pussy = 0
			my_show_anus = 0
			my_show_afisting = 0
			my_show_vfisting = 0
			my_show_dp = 0
			my_show_sex = 0
			my_show_squirt = 0
			my_show_flex = 0
			show_counter = 0
			my_show_tip_all = 0
			my_show_tip = 0
			dynamic $webcam_show
		end
}
!-----------------------------------------------!
!---------Вебкам шоу онлайн чата----------------!
!-----------------------------------------------!
!if $args[0] = 'show':
$webcam_show = {
act 'Выход': gt 'Komp', 'start'
	my_show_tip_all += my_show_tip
!------------------------------!
!----------Конец шоу-----------!
!------------------------------!
	if show_counter = 4:
		*clr
		'<center><img src="images/zsoft/webcam/end'+rand(1,2)+'.gif"></center>'
		'Вы уже сильно притомились. Да и зрителям нужно перевести дух после вашего суперского шоу. Пора закругляться.'
		'Вы собрали <<my_show_tip_all>> рублей во время сегодняшнего шоу.'
		webcam_show_day = daystart
		webcam_show_count -= 1
		money += my_show_tip_all
		webcam_show_money += my_show_tip_all
		webcam_show_time += 60
		webcam_show_counter += 1
		internetM -= 60
		internet -= 1
		minut += 60
		cla
		act 'Выйти': gt 'webcam_site'
	end
!------------------------------!
!-------Продолжение шоу--------!
!------------------------------!
	if show_counter > 0 and show_counter < 4:
		gs'stat'
		*clr
		'<center><img src="images/zsoft/webcam/show'+rand(5,7)+'.gif" ></center>'
		'Шоу должно продолжаться!'
		'Вы собрали уже <<my_show_tip_all>> рублей за время шоу.'
		show_counter += 1
		cla
		if my_show_show = 0:
			act 'Показать себя':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/show'+rand(1,4)+'.gif" ></center>'
				'Вы устраиваетесь так, чтобы ваша промежность оказалась прямо на против камеры, и предоставляете всем зрителям возможность рассмотреть все как следует.'
				my_show_tip = rand(50, 400)
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_show = 1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!-----------Сиськи-------------!
!------------------------------!
		if my_show_tits = 0:
			act 'Играть с грудью':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/tits'+rand(1,4)+'.gif" ></center>'
				'По просьбе зрителей вы играетесь со своей грудью.'
				my_show_tip = rand(100, 400)
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_tits = 1
				webcam_show_tits +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!---------Мастурбация----------!
!------------------------------!
		if my_show_mast = 0:
			act 'Мастурбировать':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/mast'+rand(1,9)+'.gif" ></center>'
				'Вы ласкаете поглаживая свою киску и попку, теребите клитор и выкручиваете сосочки.'
				my_show_tip = rand(100, 500)
				horny += 30
				!оргазм-бонус денег
				if horny > 100:
					'Вскоре вы доводите себя до предела и бурно кончаете. Счетчик чаевых от этого резко увеличивается.'
					webcam_show_orgazm +=1
					my_show_tip += rand(50, 500)
					horny = 0
				end
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_mast = 1
				webcam_show_mast +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!-----------------------------------------------!
!-----------Резиновый член в рот----------------!
!-----------------------------------------------!
		if throat >= 1 and dildo = 1 and my_show_throat = 0:
			act 'Дилдо в рот':
				gs'stat'
				*clr
				!средний дилдо 15см
				if throat >= 15 and throat < 25 and middildo = 1:
					'<center><img src="images/zsoft/webcam/toys/midthroat'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой большой 15см дилдо и начинаете облизывать, посасывать, засовывать в рот.'
					my_show_tip = rand(100, 500)
					if throat < 25: throat += 1
				end
				!большой дилдо 25см
				if throat >= 25 and throat < 35 and bigdildo = 1:
					*clr
					'<center><img src="images/zsoft/webcam/toys/bigthroat'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой гигантский 25см дилдо и начинаю ритмично загонять его в горло.'
					my_show_tip = rand(500, 1000)
					if throat < 35: throat += 1
				end
				!огромный дилдо 40см
				if throat >= 35 and maddildo = 1:
					*clr
					'<center><img src="images/zsoft/webcam/toys/extrthroat'+rand(1,2)+'.gif" ></center>'
					'Вы достаете свой экстремально гигантский 40см дилдо и начинаете засовывать его в горло.'
					my_show_tip = rand(600, 1400)
				end
				!обычный дилдо
				if throat < 15 and dildo = 1:
					'<center><img src="images/zsoft/webcam/toys/throat'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой обычный дилдо и начинаете аккуратно обсасывать.'
					my_show_tip = rand(100, 500)
					throat += 1
				end
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_throat = 1
				webcam_show_throat +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!-----------------------------------------------!
!---------Резиновый член в киску----------------!
!-----------------------------------------------!
		if vgape < 3 and vagina >= 1 and dildo = 1 and my_show_pussy = 0:
			act 'Дилдо в киску':
				gs'stat'
				*clr
				!средний дилдо 15см
				if vagina >= 15 and vagina < 25 and middildo = 1:
					'<center><img src="images/zsoft/webcam/toys/midvagin'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой средний 15см дилдо и начинаю ритмично загонять его в киску.'
					my_show_tip = rand(200, 700)
					if vagina < 25: vagina += 1
				end
				!большой дилдо 25см
				if vagina >= 25 and vagina < 35 and bigdildo = 1:
					*clr
					'<center><img src="images/zsoft/webcam/toys/bigvagin'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой большой 25см дилдо и начинаю ритмично загонять его в киску.'
					my_show_tip = rand(400, 800)
					if vagina < 35: vagina += 1
				end
				!гигантский дилдо 40см
				if vagina >= 35 and maddildo = 1:
					*clr
					'<center><img src="images/zsoft/webcam/toys/extrvagin'+rand(1,2)+'.gif" ></center>'
					'Вы достаете свой экстремально гигантский 40см дилдо и начинаете засовывать его в киску.'
					my_show_tip = rand(700, 1400)
				end
				!обычный дилдо
				if vagina < 15 and dildo = 1:
					'<center><img src="images/zsoft/webcam/toys/vagin'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой обычный дилдо и начинаете ритмично загонять его в киску.'
					my_show_tip = rand(100, 600)
					vagina += 1
				end
				horny += 30
				!оргазм-бонус денег
				if horny > 100:
					'Вскоре вы доводите себя до предела и бурно кончаете. Счетчик чаевых от этого резко увеличивается.'
					webcam_show_orgazm +=1
					my_show_tip += rand(100, 500)
					horny = 0
				end
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_pussy = 1
				webcam_show_pussy +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!-----------------------------------------------!
!---------Резиновый член в попку----------------!
!-----------------------------------------------!
		if agape < 3 and anus => 1 and dildo = 1 and my_show_anus = 0:
			act 'Дилдо в попку':
				gs'stat'
				*clr
				'Вы раздвинув свои ягодицы стали массировать анальное отверстие пальцами, сначала одним, потом двумя.'
				!анальная пробка
				if analplugin = 1:
					analplugin = 0
					'Вы вытащили из вашей попки анальную пробку,'
				end
				!смазка
				if lubri > 0:
					lubri -= 1
					'Вы выдавили анальной смазки себе на руку и начали намазывать свою попку. После этого вы немного смазали дилдо.'
				end
				!средний дилдо 15см
				if anus >= 15 and anus < 25 and middildo = 1:
					'<center><img src="images/zsoft/webcam/toys/midanal'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой средний 15см дилдо и начинаю ритмично загонять его в попку.'
					my_show_tip = rand(300, 800)
					if anus < 25: anus += 1
				end
				!большой дилдо 25см
				if anus >= 25 and anus < 35 and bigdildo = 1:
					*clr
					'<center><img src="images/zsoft/webcam/toys/biganal'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой большой 25см дилдо и начинаю ритмично загонять его в попку.'
					my_show_tip = rand(500, 1000)
					if anus < 35: anus += 1
				end
				!гигантский дилдо 40см
				if anus >= 35 and maddildo = 1:
					*clr
					'<center><img src="images/zsoft/webcam/toys/extranal'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой экстремально гигантский 40см дилдо и начинаете засовывать его в попку.'
					my_show_tip = rand(700, 1400)
				end
				!обычный дилдо
				if anus < 15 and dildo = 1:
					'<center><img src="images/zsoft/webcam/toys/anal'+rand(1,3)+'.gif" ></center>'
					'Вы достаете свой обычный дилдо и начинаете ритмично загонять его в попку.'
					my_show_tip = rand(100, 500)
					anus += 1
				end
				horny += 30
				!оргазм-бонус денег
				if horny > 100:
					'Вскоре вы доводите себя до предела и бурно кончаете. Счетчик чаевых от этого резко увеличивается.'
					webcam_show_orgazm +=1
					my_show_tip += rand(100, 500)
					horny = 0
				end
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_anus = 1
				webcam_show_anus +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!----Двойное проникновение-----!
!------------------------------!
		if agape < 3 and vgape < 3 and anus >= 20 and vagina >= 20 and my_show_dp = 0:
			act 'Дилдо в попку и письку':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/toys/dp'+rand(1,3)+'.gif" ></center>'
				'Вы раздвинув свои прелести стали массировать отверстия пальцами, сначала письку, потом попку.'
				!анальная пробка
				if analplugin = 1:
					analplugin = 0
					'Вы вытащили из вашей попки анальную пробку,'
				end
				!смазка
				if lubri > 0:
					lubri -= 1
					'Вы выдавили смазки себе на руку и начали намазывать свои прелести.'
				end
					'Засунув дилдо себе в пиьску и попку, ритмично начали сношать свои дырки.'
				horny += 30
				!оргазм-бонус денег
				if horny > 100:
					'Вскоре вы доводите себя до оргазма и не скрывая эмоции бурно кончаете. Счетчик чаевых от этого резко увеличивается.'
					webcam_show_orgazm +=1
					my_show_tip += rand(100, 600)
					horny = 0
				end
				my_show_tip = rand(600, 1600)
				my_show_dp = 1
				webcam_show_dp +=1
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!---------Рука в жопу----------!
!------------------------------!
		if agape < 3 and anus >= 30 and my_show_afisting = 0:
			act 'Фистинг анальный':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/afist'+rand(1,2)+'.gif" ></center>'
				'Вы раздвинув свои прелести стали массировать отверстие пальцами, сначала одним, потом двумя.'
				!анальная пробка
				if analplugin = 1:
					analplugin = 0
					'Вы вытащили из вашей попки анальную пробку,'
				end
				!смазка
				if lubri = 0: agape = 3
				if lubri > 0:
					lubri -= 1
					'Вы выдавили анальной смазки себе на руку и начали намазывать свою попку.'
				end
					'Вы медленно начали вводить свою руку себе в попку.'
				my_show_tip = rand(400, 1800)
				my_show_afisting = 1
				webcam_show_afisting +=1
				if anus <= 30: anus +=1
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!---------Рука в пизду---------!
!------------------------------!
		if vgape < 3 and vagina >= 30 and my_show_vfisting = 0:
			act 'Фистинг вагинальный':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/vfist'+rand(1,3)+'.gif" ></center>'
				'Вы раздвинув свои прелести стали массировать отверстие пальцами, сначала одним, потом двумя.'
				!смазка
				if lubri = 0: vgape = 3
				if lubri > 0:
					lubri -= 1
					'Вы выдавили смазки себе на руку и начали намазывать свою киску.'
				end
					'Вы медленно начали вводить свою руку себе в письку.'
				my_show_tip = rand(400, 1600)
				my_show_vfisting = 1
				webcam_show_vfisting +=1
				if vagina <= 30: vagina +=1
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!---------Секс - Васян---------!
!------------------------------!
		if $loc='shulga_room' and $npc['11,relation']>=100 and week >= 6 and hour >= 15 and vgape < 3 and agape < 3 and vagina >= 1 and my_show_sex = 0:
			act 'Позвать Васю и устроить секс шоу':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/sex'+rand(1,5)+'.gif" ></center>'
				!анальная пробка
				if analplugin = 1:
					analplugin = 0
					'Васька вытащил из вашей попки анальную пробку.'
				end
				'Василий начал поглаживать ваши прелести, стал массировать отверстия пальцами.'
				!смазка
				if lubri = 0: vgape = 1
				if lubri > 0:
					lubri -= 1
					'Он выдавил смазки себе на руки и начал смазывать ваши прелести'
				end
					'Минут 30 вы ебались с ним на камеру. Он вертел вас как хотел, иногда почитывая чат и выполнял прихоти зрителей: ебал то быстро, то медленно, засовывал хуй то в пизду, то в жопу, не забывал про ваш ротик.'
					'Зрителям все это действо понравилось, кол-во увеличилось, чаевые посыпались еще быстрее'
				horny += 30
				!оргазм-бонус денег
				if horny > 100:
					'Вскоре он доводит вас до оргазма и вы не скрывая эмоции бурно кончаете. Счетчик чаевых от этого резко увеличивается.'
					webcam_show_orgazm +=1
					my_show_tip += rand(100, 500)
					horny = 0
				end
				my_show_tip = rand(800, 2000)
				my_show_sex = 1
				webcam_show_sex += 1
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!-----------Сквирт-------------!
!------------------------------!
		if webcam_show_counter >= 30 and my_show_squirt = 0:
			act 'Сквирт':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/squirt'+rand(1,2)+'.gif" ></center>'
				'По просьбе зрителей вы сквиртуете прямо на камеру.'
				my_show_tip = rand(400, 1200)
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_squirt = 1
				webcam_show_squirt +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
!------------------------------!
!----------Растяжка------------!
!------------------------------!
		if dance >= 50 and my_show_flex = 0:
			act 'Растяжка':
				*clr
				'<center><img src="images/zsoft/webcam/flex'+rand(1,3)+'.gif" ></center>'
				'Вы демонстрируете зрителям свою гибкость.'
				my_show_tip = rand(dancePRO,dancePRO*2)
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				my_show_flex = 1
				webcam_show_flex +=1
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
	end
!------------------------------!
!----------Старт шоу-----------!
!------------------------------!
	if show_counter = 0:
		'Вы включаете веб камеру. Пора начинать представление!'
		show_counter = 1
		!если накрашены и причесаны бонус денег
		if mop = 1: my_show_tip = rand(10, 50)
		if mop = 2: my_show_tip = rand(10, 100)
		if mop = 3: my_show_tip = rand(10, 150)
		if mop = 4: my_show_tip = rand(10, 200)
		cla
		act 'Раздеться':
			*clr
			'<center><img src="images/zsoft/webcam/undress'+rand(1,7)+'.gif" ></center>'
			'Вы снимаете с себя одежду.'
			my_show_tip = rand(100, 200)
			'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
			cla
			act 'Далее': dynamic $webcam_show
		end
!------------------------------!
!----------СТРИПТИЗ------------!
!------------------------------!
		if stripdance > 10:
			act 'Стриптиз':
				gs'stat'
				*clr
				'<center><img src="images/zsoft/webcam/strip'+rand(1,7)+'.gif" ></center>'
				'Вы не спеша раздеваетесь под музыку, плавно стягивая один предмет одежды за другим.'
				!проверка самочувствия
				if agape > 2 or vgape > 2 or son < 2:
					'Вы как-то нехорошо себя чувствуете. Повезет, если вы сможете станцевать хотя бы в половину так хорошо, как обычно.'
					my_show_tip_mod = 2
				else
					my_show_tip_mod = 1
				end
				my_show_tip = (stripdance + dance/2 + dancePRO/3)/my_show_tip_mod
				webcam_show_strip +=1
				'За это небольшое представление вы заработали <<my_show_tip>> рублей.'
				cla
				act 'Далее': dynamic $webcam_show
			end
		end
	end
}