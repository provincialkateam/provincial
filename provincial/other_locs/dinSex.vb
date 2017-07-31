$universalklient = {
	if klient_needs = 0:$klientwanttext = 'минет'
	if klient_needs = 1 or klient_needs = 3 or klient_needs = 4:$klientwanttext = 'секс'
	if klient_needs = 2:$klientwanttext = 'анал'
	if klient_needs = 5:$klientwanttext = 'куни'
	gs 'zz_render','','images/pic/park2','Вы сказали клиенту, что <<$klientwanttext>> будет стоить <<ProsMoney*100>> рублей.'
	dynamic $dinprostable
	if vnpr >= 0:
		if ProsMoney = 1:
			clientPRyes = 1
		end
		if ProsMoney > 1:
			if KlientMON >= ProsMoney:
				if vnpr >= klienVNPR:
					clientPRyes = 1
				else
					clientPRyes = 0
				end
			elseif KlientMON < ProsMoney:
				if vnpr >= klienVNPR:
					torgklirand = RAND(0,1)
					if torgklirand = 0:
						clientPRyes = 0
					else
						gs 'zz_render','','','Клиент усмехается и предлагает вам <<KlientMON*100>> рублей за работу.'
						act 'Согласиться':
							cla
							clientPRyes = 1
							ProsMoney = KlientMON
							dynamic $dinklient
						end
						act 'Отказаться':gt'prostitute','start'
						exit
					end
				else
					clientPRyes = 0
				end
			end
		end
	end
	if vnpr < 0:clientPRyes = 0
	dynamic $dinklient
}
$dinprostable = {
	vnpr = 0
	if vidage >= 40:vnpr -= 20
	if vidage >= 35 and vidage < 40:vnpr -= 10
	if vidage >= 30 and vidage < 35:vnpr -= 5
	if vidage >= 25 and vidage < 30:vnpr += 1
	if vidage >= 20 and vidage < 25:vnpr += 5
	if vidage >= 18 and vidage < 20:vnpr += 10
	if vidage < 18:vnpr += 15
	if vnesh = -10:vnpr -= 100
	if vnesh > -10 and vnesh < 20:vnpr -= 10
	if vnesh >= 20 and vnesh < 40:vnpr -= 5
	if vnesh >= 40 and vnesh < 60:vnpr += 1
	if vnesh >= 60 and vnesh < 80:vnpr += 5
	if vnesh >= 80:vnpr += 10
	!!!!!if cumSUM > 0:vnpr -= 10
	if mop = 0:vnpr -= 10
	if mop = 1:vnpr -= 1
	if mop = 2:vnpr += 1
	if mop = 3:vnpr += 5
	if mop = 4:vnpr += 10
	if leghair <= 0:vnpr += 1
	if leghair > 0:vnpr -= 5
	if lobok > 0:vnpr -= 5
	if lobok <= 0:vnpr += 1
	if tan > 0:vnpr += 1
	if curly > 0:vnpr += 1
	if sweat > 0:vnpr -= 10
	if lip = 4:vnpr += 1
	!максимум 40
	!минимум -161
}
$dinklient = {
	if clientPRyes = 1:
		gs 'zz_render','','','Клиент кивает вам головой и открывает дверь своей машины.'
		if klient_needs = 0: dynamic $din_prost_bj
		if klient_needs = 1: dynamic $din_prost_sex
		if klient_needs = 2: dynamic $din_prost_anal
		if klient_needs = 3: dynamic $whore_event_1
		if klient_needs = 4: dynamic $whore_event_2
		if klient_needs = 5: dynamic $whore_event_3
	elseif clientPRyes = 0:
		gs 'zz_render','','','Клиент придирчиво осмотрел вас и сказал "Не, нахуй." После этого он тронул машину и уехал.'
		act 'Уйти':gt'prostitute','start'
	end
}
$din_prost_bj = {
	act 'Залезть в машину клиента':
		$boy = 'Клиент'
		slutty += 1
		dick = RAND(12,21)
		money += ProsMoney*100
		gt 'blowPR','start'
	end
}
$din_prost_sex = {
	act 'Залезть в машину клиента':
		$boy = 'Клиент'
		dick = RAND(12,21)
		money += ProsMoney*100
		prosti = 1
		slutty += 1
		gt 'blowPR','start'
	end
}
$din_prost_anal = {
	act 'Залезть в машину клиента':
		gs 'boy'
		prosti = 2
		analprotect = 0
		slutty += 1
		gt 'blowPR','start'
	end
}
$whore_event_1={
	act 'Работать':
		*clr & cla
		gs 'zz_funcs', 'cum', 'belly'
		slutty += 1
		money += ProsMoney * 100
		gs 'stat'
		gs 'zz_render','','images/NigmA/city/whore/whore.event0','Из машины вылезла группа мужиков. Один из них, толстяк, направился к вам. "Жирный, поехали, блять, нахуй ты просил остановить?" - один из них крикнул мужику, направившемуся к вам. Толстяк остановился, и обернулся к машине: - "Ща, мужики. Ебаться хочу - не могу. Ща шалаву выебу по-быстрому и вернусь. Он подошел к вам, взял за руку и повел к машине. Там он уложил вас на капот и трахнул. Продержался он действительно не долго. Поелозив несколько минут в вашей киске, он вытащил член и кончил вам на живот.'
		act'Уйти':gt'prostitute','start'
	end
}
$whore_event_2={
	act 'Работать':
		*clr & cla
		slutty += 1
		gs 'zz_funcs','cum','lip'
		gs 'zz_funcs','cum','ass'
		money += ProsMoney * 100
		gs 'stat'
		gs 'zz_render','','images/NigmA/city/whore/whore.event1','"Бля, че эти суки себе думают. Взяли и тупо продинамили" - услышали вы из остановившейся машины. "Да пиздец, можно подумать - королевы красоты нашлись. Ладно, Гоха, пойдем хоть шалаву выебем. А то яйца уже каменные." - Прозвучал второй голос. К вам подошли два парня. Быстренько сговорившись о цене, вы встали возле машины раком. Один из парней сразу зашел вам сзади и вставил член в киску. Второй подошел к вашему лицу и предоставил свой член вам на облуживание. Через минут десять парни кончили: первый кончил вам в рот, а второй на попу.'
		act 'Уйти': gt 'prostitute','start'
	end
}
$whore_event_3={
	act 'Работать':
		*clr & cla
		slutty += 1
		money += ProsMoney*100
		gs 'stat'
		gs 'zz_render','','images/NigmA/city/whore/whore.event2','Из остановившейся машины появилась женская рука, которыя поманила вас ближе. Когда вы подошли, из машины вышла женщина. "Чет, устала я за день. Сними мне напряжение" - сказала она, и приподняла юбку. Вы принялись вылизывать ей промежность, попеременно вставляя пальцы то в ее киску, то в поку. Наконец, женщина не выдержала и кончила, обдав вас своими соками.'
		act 'Уйти': gt 'prostitute','start'
	end
}
$venerasiak = {
	if prezik > 0:
		if RAND(0,1000) = 1000: dynamic $veneradinitog
	else
		if RAND(0,100) >= 80: dynamic $veneradinitog
	end
}
$veneradinitog = {
	tipvenerarand = RAND(0,10)
	if tipvenerarand >= 8:
		!герпес
		if RAND(0,100) > 90:
			if GerpesOnce = 0: GerpesOnce = 1
			Venera += 1
			Gerpes += 1
		end
	elseif tipvenerarand = 7:
		!сифилис
		if RAND(0,100) > 95:
			Venera += 1
			if SifacOnce = 0:SifacOnce = 1
			Sifilis += 1
		end
	elseif tipvenerarand >= 5 and tipvenerarand < 7:
		!гонорея/трипер
		if RAND(0,100) > 95:
			Venera += 1
			if TriperOnce = 0:TriperOnce = 1
			Triper += 1
		end
	elseif tipvenerarand < 5:
		!кандидоз/молочница
		if RAND(0,100) > 85:
			if KandidozOnce = 0:KandidozOnce = 1
			Kandidoz += 1
			Venera += 1
		end
	end
}