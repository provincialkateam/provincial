gs 'zz_render', '', '', func('andrey_strings', 'local_str1')
if hour >= 18:
	msg '<center>Андрей Михайлович Собулягин прощается и уходит. Его рабочий день закончился</center>'
	gt 'young_shop'
end
if young_shop_work = 0:
	gs 'zz_render', '', '', func('andrey_strings', 'local_str2')
	act 'Поговорить о работе':
		cla
		minut += 5
		gs 'zz_render', '', '', func('andrey_strings', 'local_str3')
		act 'Обдумать условия и прийти в другое время':
			gt'young_shop'
		end
		if work = 0 and young_shop_work = 0 and hour < 15:
			gs 'zz_render', '', '', func('andrey_strings', 'local_str4')
			act 'Устроиться на работу':
				work = 1
				young_shop_work = 1
				minut += 5
				if week >= 1 and week <= 4:msg '<center>Я устраиваюсь на работу в Магазин молодёжной одежды Кис-киска. Начинаю завтра!</center>'
				if week = 5:msg '<center>Я устраиваюсь на работу в Магазин молодёжной одежды Кис-киска. Начинаю в понедельник!</center>'
				gt'young_shop'
			end
		end
	end
	act 'Уйти':gt'young_shop'
elseif young_shop_work = 1:
	gs 'zz_render', '', '', func('andrey_strings', 'local_str5')
	if week = 5 and young_shop_salary > 0:
		gs 'zz_render', '', '', func('andrey_strings', 'local_str6')
		act 'Получить зарплату':
			minut += 15
			money += young_shop_salary*800 + young_shop_bonus*200
			msg '<center>Я отработала <b><<young_shop_salary>></b> дней и получаю зарплату <b><<young_shop_salary*800>></b> рублей и бонус <b><<young_shop_bonus*200>></b> рублей. Всего <b><<young_shop_salary*800 + young_shop_bonus*200>></b> рублей</center>'
			gs 'zz_render', '', '', func('andrey_strings', 'local_str7')
			young_shop_salary = 0
			young_shop_bonus = 0
			act 'Уйти': gt 'young_shop'
		end
		exit
	end
	if young_shop_miss >= 3:
		cla
		gs 'zz_render', '', '', func('andrey_strings', 'local_str8')
		act 'Согласиться на увольнение':
			cla
			young_shop_work = 2
			young_shop_miss = 0
			char_honest = char_honest + 5
			work = 0
			bonus_mood = bonus_mood - 100
			minut += 15
			gs 'zz_render', '', '', func('andrey_strings', 'local_str9')
			if young_shop_salary > 0 or young_shop_bonus > 0:
				money += young_shop_salary*800 + young_shop_bonus*200
				msg 'За <b><<young_shop_salary>></b> дней я получаю зарплату <b><<young_shop_salary*800>></b> рублей и бонус <b><<young_shop_bonus*200>></b> рублей. Всего <b><<young_shop_salary*800 + young_shop_bonus*200>></b> рублей'
				gs 'zz_render', '', '', func('andrey_strings', 'local_str10')
				young_shop_salary = 0
				young_shop_bonus = 0
			end
			act 'Уйти':gt'young_shop'
		end
		act 'Умолять оставить':
			cla
			gs 'zz_render', '', '', func('andrey_strings', 'local_str11')
			act 'Убежать':
				minut += 2
				gt'young_shop'
			end
			act 'Запереть дверь и встать на колени':
				cla
				minut += 15
				if sobulaginsex = 0:sobulaginsex = 1 & guy += 1
				bj += 1
				swallow += 1
				gs 'zz_funcs', 'cum', 'lip'
				young_shop_miss = 2
				young_shop_salary = 1
				young_shop_bonus = 2
				gs 'zz_render', '', '', func('andrey_strings', 'local_str12')
				act 'Уйти':gt'young_shop'
			end
		end
	elseif young_shop_miss < 3:
		act 'Уволиться':
			cla
			gs 'zz_render', '', '', func('andrey_strings', 'local_str13')
			act 'Передумать':
				gs 'zz_render', '', '', func('andrey_strings', 'local_str14')
				act 'Уйти':gt'young_shop'
			end
			act 'Уволиться':
				young_shop_work = 3
				young_shop_miss = 0
				work = 0
				gs 'zz_render', '', '', func('andrey_strings', 'local_str15')
				if young_shop_salary > 0 or young_shop_bonus > 0:
					money += young_shop_salary*800 + young_shop_bonus*200
					msg '<center>За <b><<young_shop_salary>></b> дней я получаю зарплату <b><<young_shop_salary*800>></b> рублей и бонус <b><<young_shop_bonus*200>></b> рублей. Всего <b><<young_shop_salary*800 + young_shop_bonus*200>></b> рублей</center>'
					gs 'zz_render', '', '', func('andrey_strings', 'local_str16')
					young_shop_salary = 0
					young_shop_bonus = 0
				end
				act 'Уйти':gt'young_shop'
			end
		end
	end
	act 'Уйти':gt'young_shop'
elseif work = 0 and young_shop_work = 2:
	gs 'zz_render', '', '', func('andrey_strings', 'local_str17')
	act 'Умолять вернуть на работу':
		cla
		gs 'zz_render', '', '', func('andrey_strings', 'local_str18')
		act 'Ни за что!':
			cla
			gs 'zz_render', '', '', func('andrey_strings', 'local_str19')
			act 'Уйти':gt'young_shop'
		end
		act 'Согласиться':
			young_shop_work = 1
			work = 1
			minut += 60
			gs 'zz_render', '', '', func('andrey_strings', 'local_str20')
			if week >= 1 and week <= 4:msg '<center>Я устраиваюсь на работу в Магазин молодёжной одежды Кис-киска. Начинаю завтра!</center>'
			if week = 5:msg '<center>Я устраиваюсь на работу в Магазин молодёжной одежды Кис-киска. Начинаю в понедельник!</center>'
			act 'Уйти':gt'young_shop'
		end
	end
	act 'Уйти':gt'young_shop'
elseif young_shop_work = 3:
	gs 'zz_render', '', '', func('andrey_strings', 'local_str21')
	act 'Вернуться на работу':
		cla
		work = 1
		young_shop_work = 1
		minut += 15
		gs 'zz_render', '', '', func('andrey_strings', 'local_str22')
		if week >= 1 and week <= 4:msg '<center>Я устраиваюсь на работу в Магазин молодёжной одежды Кис-киска. Начинаю завтра!</center>'
		if week = 5:msg '<center>Я устраиваюсь на работу в Магазин молодёжной одежды Кис-киска. Начинаю в понедельник!</center>'
		act 'Уйти':gt'young_shop'
	end
	act 'Уйти':gt'young_shop'
end