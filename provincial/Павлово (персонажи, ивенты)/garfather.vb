gs 'npc_editor','get_npc_profile',35
act '<B>Отойти</B>': gt $loc, $metka
if TorgVokzalTimes > 0 and YouCanGar = 0 and $father['location'] = 'gargazel':
	act 'Просить разрешения хранить в гараже товар':
		cla
		minut += 5
		gs 'stat'
		gs 'zz_render','','','Вы попросили отчима разрешения хранить в гараже товар.'
		if $npc['35,relation'] >= 80 or father['touched'] = 1:
			YouCanGar = 1
			gs 'zz_render','','','Отчим поколебавшись все же разрешил вам использовать его гараж для хранения товара на продажу.'
		else
			gs 'zz_render','','','Отчим отрицательно покачал головой: <do>- Нет <<$name[1]>>. У меня и так там мало места.</do>'
		end
		act '<B>Далее</B>': gt $loc, $metka
	end
end
act 'Помогать':
	*clr & cla
	minut += rand(40,70)
	sweat += 1
	gs 'npc_editor','change_rep','+', 35
	gs 'stat'
	gs 'npc_editor','get_npc_profile',35
	gs 'zz_render','','','Отчим сидит на стуле и крутит в руках какую-то грязную деталь. Вы присели рядом с ним на соседний стул.'
	act '<B>Отойти</B>': gt 'gargazel'
	gs 'zz_father','talk_variants'
end
if horny >= 70 and $npc['35,qwOtchim'] >= 5 and father['dadqw_day'] ! day and $npc['35,relation'] >= 80:
	act 'Соблазнить':
		*clr & cla
		father['dadqw_day'] = day
		gs 'zz_render','','images/nigma/gor/father/gar/father.gar.pre'+rand(0,5)+'.jpg','Вы подошли к Газельке, и взяли губку. Вы наклонились, чтобы помыть машину, выставив попку на обозрение отчиму.
		"- Ох... - Отчим явно не ожидал от вас такого, но по его непроизвольному выдоху и зажегшимся глазам вы понимаете, что ему это, как минимум, весьма понравилось.
		Отчим подошел сзади и положил руки вам на попу. Он неспеша начал мять ваши булки.'
		act'На колени':
			*clr & cla
			horny += 5
			minut += 3
			gs 'stat'
			gs 'zz_render','','common/sex/hj/'+rand(0,1)+'.gif','Вы опустились перед отчимом на колени и положили ладошку на его промежность. Вы ощутили уже стоящий член, и принялись его ласкать через ткань. Затем вы залезли в штаны к отчиму и вытащили член наружу. Вы принялись его надрачивать.'
			act 'В рот':
				*clr & cla
				horny += 10
				$boy = 'отчим'
				minut += 5
				gs 'stat'
				gs 'zz_render','','images/nigma/gor/father/gar/father.gar.0,'+rand(0,4)+'.jpg','Отчим открыл дверь Газельки, и сел на пассажирское сидение. Он притянул вашу голову к себе, и насадил ваш рот на член.
				Вы неспеша отсасываете своему отчиму, ласкаете его яйца языком, и снова вбираете член в рот. Вскоре член начал пульсировать, подавая признаки скорого конца.'
				act 'Сосать глотая сперму':
					*clr & cla
					gs 'npc_editor','change_rep','+', 35
					gs 'zz_funcs', 'cum', 'lip'
					swallow += 1
					water -= 10
					minut += 10
					gs 'stat'
					gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.gif','Вы продолжили сосать кончающий член и сглатывать сперму попадающую вам в рот. Спермы было так много, что вы не успеваете все проглотить и она стекает из вашего рта по члену. Наконец <<$boy>> прекращает кончать и вы вытаскиваете член из своего пахнущего спермой рта. Во рту гадко от вкуса кончи, облизнувшись вы понимаете, что ваши <<$liptalk3>> влажные от спермы.'
					act '<B>Отойти</B>': gt 'gargazel'
				end
				act 'Вынуть изо рта':
					*clr & cla
					gs 'npc_editor','change_rep','+', 35
					gs 'zz_funcs', 'cum', 'face'
					minut += 10
					gs 'stat'
					gs 'zz_render','','common/sex/bj_cum/'+rand(0,4)+'.jpg','Вы вынули член изо рта и струя спермы тут же хлестнула вам по лицу. Вы зажмурили глаза боясь, что сперма попадет вам в глаза и почувствовали как еще одна струя горячей кончи приземлилась вам на лицо.'
					act '<B>Отойти</B>': gt 'gargazel'
				end
			end
			act 'Дать':
				*clr & cla
				minut += 20
				horny += 20
				dick = 17
				$boy = 'Отчим'
				gs 'zz_render','','images/nigma/gor/father/gar/father.gar.1,'+rand(0,2)+'.jpg','Отчим поднял вас с колен, и развернул лицом к Газельке. Вы опперлись руками об машину, подставив ему попку.'
				gs 'zz_dynamic_sex', 'anal_start', 'dick'
				gs 'zz_dynamic_sex', 'anal', 'dick'
				act 'Дальше':
					*clr & cla
					gs 'npc_editor','change_rep','+', 35
					gs 'zz_funcs', 'cum', 'anus'
					if $npc['35,sex'] = 0:
						$npc['35,sex'] = 1
						guy += 1
					end
					gs 'stat'
					gs 'zz_render','','images/nigma/gor/father/gar/father.gar.cum1,0.jpg','Наконец, вы чувствуете как член начинает пульсировать внутри вас. Отчим делает еще несколько толчков, а затем наваливаете на вас всем телом, заливая вашу попку своей спермой.'
					gs 'zz_funcs', 'hornyrand'
					act '<B>Отойти</B>': gt'gargazel'
				end
			end
		end
	end
end
if fatherdrunk = 1:
	*clr & cla
	minut += 60
	gs 'stat'
	gs 'npc_editor','get_npc_profile',35
	gs 'zz_father', 'drunk'
	act '<B>Отойти</B>':gt $loc, $metka
end