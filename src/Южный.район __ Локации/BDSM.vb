﻿$create_picture = {
	if hcol = 0: $zz_str = 'Brunette_'
	if hcol = 1: $zz_str = 'Brown_'
	if hcol = 2: $zz_str = 'Redhead_'
	if hcol = 3: $zz_str = 'Blonde_'
	gs 'zz_render','','images/city/center/studia/'+$zz_str+args[0]+'.jpg'
	killvar '$zz_str'
}
$metka = $ARGS[0]
$loc = $CURLOC
cla
clr
*clr
gs 'stat'
gs 'zz_render','','','Вы прошли на съёмочную площадку. В очень ярко освещённом помещении жарко от софитов. Помимо актёров, там же находятся ещё несколько человек: режиссёр, оператор с камерой и звукооператор с длинной штангой, на конце которой закреплён здоровенный микрофон, кажущийся ещё больше из за мохнатого чехла-фильтра.'
act 'Сниматься':
	cla
	*clr
	dynamic $create_picture, 2
	gs 'zz_render','','','Вас стали снимать в сцене с двумя актерами'
	act 'Снять сцену с миньетом':
		cla
		*clr
		guy += 2
		bj += 2
		gang += 1
		dynamic $create_picture, 3
		gs 'zz_render','','','Вы обхватили губами член и взяли в ладошку член второго актера и начали энергично работать перед камерой, попеременно обсасывая члены и стараясь натянуть свой рот сразу на оба члена.'
		act 'Встать раком':
			cla
			*clr
			anal += 1
			anus += 1
			dynamic $create_picture, 4
			gs 'zz_render','','','Один из актёров поставил вас раком и начал грубо засовывать вам свой твердый член в зад, после того как его член вошел в вас он начал яростно трахать вас в очко, а вы продолжали сосать у второго...'
			act 'Сесть сверху...':
				cla
				*clr
				dynamic $create_picture, 5
				gs 'zz_render','','','Вы лихо сели на один хуй попкой и продолжили отсасывать другой...'
				act 'Продолжить телодвижения':
					cla
					*clr
					dynamic $create_picture, 6
					gs 'zz_render','','','Мужички поменялись местами и продолжили ебать вас'
					act 'Приготовиться к двойному проникновению':
						cla
						*clr
						sex += 1
						vagina += 1
						dynamic $create_picture, 7
						gs 'zz_render','','','Вы сели пиздёнкой на один член, и почувствовали как второй член входит в вас зудящий и раздолбанный анус'
						act 'Наслаждаться':
							cla
							*clr
							dynamic $create_picture, 8
							gs 'zz_render','','','Широко раскинув ноги, вы наслаждаетесь действом в два смычка, члены долбят ваше тело как поршни, вы стоните и раздвигаете булки руками, чтобы оператору было удобней брать крупный план.'
							act 'Пора кончать...':
								cla
								*clr
								swallow += 1
								dynamic $create_picture, 9
								gs 'zz_render','','','Парни вынули свои толстые члены из вас и вы готовностью встали перед ними на колени и открыв похотливо рот в ожидании спермы, ребята не заставили себя ждать и вскоре горячие струи спермы начали хлестать по вашему лицу и стекать по подбородку на грудь.'
								act 'Получить гонорар':
									cla
									*clr
									minut += 480
									film += 1
									BDSMfilm += 1
									money += vnesh*250
									actr = 0
									gs 'stat'
									gs 'zz_render','','images/city/center/studia/dvd-disс.jpg'
									gs 'zz_render','','','Вы потратили 9 часов на съёмки в фильме'
									gs 'zz_render','','','и получили <<vnesh*250>> рублей наличными'
									act 'Уйти со студии':gt'center'
								end
							end
						end
					end
				end
			end
		end
	end
end